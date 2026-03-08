
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFuncModuleBL
 表名:vFuncModule(00140105)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:15:09
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:系统管理(SysManage)
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
public static class  clsvFuncModuleBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strFuncModuleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFuncModuleEN GetObj(this K_FuncModuleId_vFuncModule myKey)
{
clsvFuncModuleEN objvFuncModuleEN = clsvFuncModuleBL.vFuncModuleDA.GetObjByFuncModuleId(myKey.Value);
return objvFuncModuleEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncModuleEN SetFuncModuleId(this clsvFuncModuleEN objvFuncModuleEN, string strFuncModuleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convFuncModule.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convFuncModule.FuncModuleId);
}
objvFuncModuleEN.FuncModuleId = strFuncModuleId; //模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncModuleEN.dicFldComparisonOp.ContainsKey(convFuncModule.FuncModuleId) == false)
{
objvFuncModuleEN.dicFldComparisonOp.Add(convFuncModule.FuncModuleId, strComparisonOp);
}
else
{
objvFuncModuleEN.dicFldComparisonOp[convFuncModule.FuncModuleId] = strComparisonOp;
}
}
return objvFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncModuleEN SetFuncModuleName(this clsvFuncModuleEN objvFuncModuleEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleName, convFuncModule.FuncModuleName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convFuncModule.FuncModuleName);
}
objvFuncModuleEN.FuncModuleName = strFuncModuleName; //模块名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncModuleEN.dicFldComparisonOp.ContainsKey(convFuncModule.FuncModuleName) == false)
{
objvFuncModuleEN.dicFldComparisonOp.Add(convFuncModule.FuncModuleName, strComparisonOp);
}
else
{
objvFuncModuleEN.dicFldComparisonOp[convFuncModule.FuncModuleName] = strComparisonOp;
}
}
return objvFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncModuleEN SetFuncModuleNameSim(this clsvFuncModuleEN objvFuncModuleEN, string strFuncModuleNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleNameSim, 30, convFuncModule.FuncModuleNameSim);
}
objvFuncModuleEN.FuncModuleNameSim = strFuncModuleNameSim; //模块名_Sim
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncModuleEN.dicFldComparisonOp.ContainsKey(convFuncModule.FuncModuleNameSim) == false)
{
objvFuncModuleEN.dicFldComparisonOp.Add(convFuncModule.FuncModuleNameSim, strComparisonOp);
}
else
{
objvFuncModuleEN.dicFldComparisonOp[convFuncModule.FuncModuleNameSim] = strComparisonOp;
}
}
return objvFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncModuleEN SetFuncModuleEnName(this clsvFuncModuleEN objvFuncModuleEN, string strFuncModuleEnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleEnName, 30, convFuncModule.FuncModuleEnName);
}
objvFuncModuleEN.FuncModuleEnName = strFuncModuleEnName; //模块英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncModuleEN.dicFldComparisonOp.ContainsKey(convFuncModule.FuncModuleEnName) == false)
{
objvFuncModuleEN.dicFldComparisonOp.Add(convFuncModule.FuncModuleEnName, strComparisonOp);
}
else
{
objvFuncModuleEN.dicFldComparisonOp[convFuncModule.FuncModuleEnName] = strComparisonOp;
}
}
return objvFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncModuleEN SetOrderNum(this clsvFuncModuleEN objvFuncModuleEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, convFuncModule.OrderNum);
objvFuncModuleEN.OrderNum = intOrderNum; //排序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncModuleEN.dicFldComparisonOp.ContainsKey(convFuncModule.OrderNum) == false)
{
objvFuncModuleEN.dicFldComparisonOp.Add(convFuncModule.OrderNum, strComparisonOp);
}
else
{
objvFuncModuleEN.dicFldComparisonOp[convFuncModule.OrderNum] = strComparisonOp;
}
}
return objvFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncModuleEN SetPrjId(this clsvFuncModuleEN objvFuncModuleEN, string strPrjId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convFuncModule.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convFuncModule.PrjId);
}
objvFuncModuleEN.PrjId = strPrjId; //工程ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncModuleEN.dicFldComparisonOp.ContainsKey(convFuncModule.PrjId) == false)
{
objvFuncModuleEN.dicFldComparisonOp.Add(convFuncModule.PrjId, strComparisonOp);
}
else
{
objvFuncModuleEN.dicFldComparisonOp[convFuncModule.PrjId] = strComparisonOp;
}
}
return objvFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncModuleEN SetUseStateId(this clsvFuncModuleEN objvFuncModuleEN, string strUseStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUseStateId, convFuncModule.UseStateId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUseStateId, 4, convFuncModule.UseStateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUseStateId, 4, convFuncModule.UseStateId);
}
objvFuncModuleEN.UseStateId = strUseStateId; //UseStateId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncModuleEN.dicFldComparisonOp.ContainsKey(convFuncModule.UseStateId) == false)
{
objvFuncModuleEN.dicFldComparisonOp.Add(convFuncModule.UseStateId, strComparisonOp);
}
else
{
objvFuncModuleEN.dicFldComparisonOp[convFuncModule.UseStateId] = strComparisonOp;
}
}
return objvFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncModuleEN SetUseStateName(this clsvFuncModuleEN objvFuncModuleEN, string strUseStateName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUseStateName, 30, convFuncModule.UseStateName);
}
objvFuncModuleEN.UseStateName = strUseStateName; //使用状态名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncModuleEN.dicFldComparisonOp.ContainsKey(convFuncModule.UseStateName) == false)
{
objvFuncModuleEN.dicFldComparisonOp.Add(convFuncModule.UseStateName, strComparisonOp);
}
else
{
objvFuncModuleEN.dicFldComparisonOp[convFuncModule.UseStateName] = strComparisonOp;
}
}
return objvFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncModuleEN SetUpdDate(this clsvFuncModuleEN objvFuncModuleEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFuncModule.UpdDate);
}
objvFuncModuleEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncModuleEN.dicFldComparisonOp.ContainsKey(convFuncModule.UpdDate) == false)
{
objvFuncModuleEN.dicFldComparisonOp.Add(convFuncModule.UpdDate, strComparisonOp);
}
else
{
objvFuncModuleEN.dicFldComparisonOp[convFuncModule.UpdDate] = strComparisonOp;
}
}
return objvFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncModuleEN SetUpdUser(this clsvFuncModuleEN objvFuncModuleEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 18, convFuncModule.UpdUser);
}
objvFuncModuleEN.UpdUser = strUpdUser; //修改用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncModuleEN.dicFldComparisonOp.ContainsKey(convFuncModule.UpdUser) == false)
{
objvFuncModuleEN.dicFldComparisonOp.Add(convFuncModule.UpdUser, strComparisonOp);
}
else
{
objvFuncModuleEN.dicFldComparisonOp[convFuncModule.UpdUser] = strComparisonOp;
}
}
return objvFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncModuleEN SetMemo(this clsvFuncModuleEN objvFuncModuleEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFuncModule.Memo);
}
objvFuncModuleEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncModuleEN.dicFldComparisonOp.ContainsKey(convFuncModule.Memo) == false)
{
objvFuncModuleEN.dicFldComparisonOp.Add(convFuncModule.Memo, strComparisonOp);
}
else
{
objvFuncModuleEN.dicFldComparisonOp[convFuncModule.Memo] = strComparisonOp;
}
}
return objvFuncModuleEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvFuncModuleENS">源对象</param>
 /// <param name = "objvFuncModuleENT">目标对象</param>
 public static void CopyTo(this clsvFuncModuleEN objvFuncModuleENS, clsvFuncModuleEN objvFuncModuleENT)
{
try
{
objvFuncModuleENT.FuncModuleId = objvFuncModuleENS.FuncModuleId; //模块Id
objvFuncModuleENT.FuncModuleName = objvFuncModuleENS.FuncModuleName; //模块名
objvFuncModuleENT.FuncModuleNameSim = objvFuncModuleENS.FuncModuleNameSim; //模块名_Sim
objvFuncModuleENT.FuncModuleEnName = objvFuncModuleENS.FuncModuleEnName; //模块英文名
objvFuncModuleENT.OrderNum = objvFuncModuleENS.OrderNum; //排序号
objvFuncModuleENT.PrjId = objvFuncModuleENS.PrjId; //工程ID
objvFuncModuleENT.UseStateId = objvFuncModuleENS.UseStateId; //UseStateId
objvFuncModuleENT.UseStateName = objvFuncModuleENS.UseStateName; //使用状态名称
objvFuncModuleENT.UpdDate = objvFuncModuleENS.UpdDate; //修改日期
objvFuncModuleENT.UpdUser = objvFuncModuleENS.UpdUser; //修改用户
objvFuncModuleENT.Memo = objvFuncModuleENS.Memo; //备注
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
 /// <param name = "objvFuncModuleENS">源对象</param>
 /// <returns>目标对象=>clsvFuncModuleEN:objvFuncModuleENT</returns>
 public static clsvFuncModuleEN CopyTo(this clsvFuncModuleEN objvFuncModuleENS)
{
try
{
 clsvFuncModuleEN objvFuncModuleENT = new clsvFuncModuleEN()
{
FuncModuleId = objvFuncModuleENS.FuncModuleId, //模块Id
FuncModuleName = objvFuncModuleENS.FuncModuleName, //模块名
FuncModuleNameSim = objvFuncModuleENS.FuncModuleNameSim, //模块名_Sim
FuncModuleEnName = objvFuncModuleENS.FuncModuleEnName, //模块英文名
OrderNum = objvFuncModuleENS.OrderNum, //排序号
PrjId = objvFuncModuleENS.PrjId, //工程ID
UseStateId = objvFuncModuleENS.UseStateId, //UseStateId
UseStateName = objvFuncModuleENS.UseStateName, //使用状态名称
UpdDate = objvFuncModuleENS.UpdDate, //修改日期
UpdUser = objvFuncModuleENS.UpdUser, //修改用户
Memo = objvFuncModuleENS.Memo, //备注
};
 return objvFuncModuleENT;
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
public static void CheckProperty4Condition(this clsvFuncModuleEN objvFuncModuleEN)
{
 clsvFuncModuleBL.vFuncModuleDA.CheckProperty4Condition(objvFuncModuleEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFuncModuleEN objvFuncModuleCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFuncModuleCond.IsUpdated(convFuncModule.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objvFuncModuleCond.dicFldComparisonOp[convFuncModule.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncModule.FuncModuleId, objvFuncModuleCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objvFuncModuleCond.IsUpdated(convFuncModule.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvFuncModuleCond.dicFldComparisonOp[convFuncModule.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncModule.FuncModuleName, objvFuncModuleCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvFuncModuleCond.IsUpdated(convFuncModule.FuncModuleNameSim) == true)
{
string strComparisonOpFuncModuleNameSim = objvFuncModuleCond.dicFldComparisonOp[convFuncModule.FuncModuleNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncModule.FuncModuleNameSim, objvFuncModuleCond.FuncModuleNameSim, strComparisonOpFuncModuleNameSim);
}
if (objvFuncModuleCond.IsUpdated(convFuncModule.FuncModuleEnName) == true)
{
string strComparisonOpFuncModuleEnName = objvFuncModuleCond.dicFldComparisonOp[convFuncModule.FuncModuleEnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncModule.FuncModuleEnName, objvFuncModuleCond.FuncModuleEnName, strComparisonOpFuncModuleEnName);
}
if (objvFuncModuleCond.IsUpdated(convFuncModule.OrderNum) == true)
{
string strComparisonOpOrderNum = objvFuncModuleCond.dicFldComparisonOp[convFuncModule.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convFuncModule.OrderNum, objvFuncModuleCond.OrderNum, strComparisonOpOrderNum);
}
if (objvFuncModuleCond.IsUpdated(convFuncModule.PrjId) == true)
{
string strComparisonOpPrjId = objvFuncModuleCond.dicFldComparisonOp[convFuncModule.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncModule.PrjId, objvFuncModuleCond.PrjId, strComparisonOpPrjId);
}
if (objvFuncModuleCond.IsUpdated(convFuncModule.UseStateId) == true)
{
string strComparisonOpUseStateId = objvFuncModuleCond.dicFldComparisonOp[convFuncModule.UseStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncModule.UseStateId, objvFuncModuleCond.UseStateId, strComparisonOpUseStateId);
}
if (objvFuncModuleCond.IsUpdated(convFuncModule.UseStateName) == true)
{
string strComparisonOpUseStateName = objvFuncModuleCond.dicFldComparisonOp[convFuncModule.UseStateName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncModule.UseStateName, objvFuncModuleCond.UseStateName, strComparisonOpUseStateName);
}
if (objvFuncModuleCond.IsUpdated(convFuncModule.UpdDate) == true)
{
string strComparisonOpUpdDate = objvFuncModuleCond.dicFldComparisonOp[convFuncModule.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncModule.UpdDate, objvFuncModuleCond.UpdDate, strComparisonOpUpdDate);
}
if (objvFuncModuleCond.IsUpdated(convFuncModule.UpdUser) == true)
{
string strComparisonOpUpdUser = objvFuncModuleCond.dicFldComparisonOp[convFuncModule.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncModule.UpdUser, objvFuncModuleCond.UpdUser, strComparisonOpUpdUser);
}
if (objvFuncModuleCond.IsUpdated(convFuncModule.Memo) == true)
{
string strComparisonOpMemo = objvFuncModuleCond.dicFldComparisonOp[convFuncModule.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncModule.Memo, objvFuncModuleCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vFuncModule
{
public virtual bool UpdRelaTabDate(string strFuncModuleId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v功能模块(vFuncModule)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvFuncModuleBL
{
public static RelatedActions_vFuncModule relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "vFuncModuleListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "vFuncModuleList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsvFuncModuleEN> arrvFuncModuleObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvFuncModuleDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvFuncModuleDA vFuncModuleDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvFuncModuleDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvFuncModuleBL()
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
if (string.IsNullOrEmpty(clsvFuncModuleEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFuncModuleEN._ConnectString);
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
objDS = vFuncModuleDA.GetDataSet(strWhereCond);
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
objDS = vFuncModuleDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = vFuncModuleDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_vFuncModule(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vFuncModuleDA.GetDataTable_vFuncModule(strWhereCond);
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
objDT = vFuncModuleDA.GetDataTable(strWhereCond);
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
objDT = vFuncModuleDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vFuncModuleDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vFuncModuleDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vFuncModuleDA.GetDataTable_Top(objTopPara);
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
objDT = vFuncModuleDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vFuncModuleDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = vFuncModuleDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vFuncModuleDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = vFuncModuleDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = vFuncModuleDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = vFuncModuleDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = vFuncModuleDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
 /// <param name = "arrFuncModuleIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvFuncModuleEN> GetObjLstByFuncModuleIdLst(List<string> arrFuncModuleIdLst)
{
List<clsvFuncModuleEN> arrObjLst = new List<clsvFuncModuleEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrFuncModuleIdLst, true);
 string strWhereCond = string.Format("FuncModuleId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncModuleEN objvFuncModuleEN = new clsvFuncModuleEN();
try
{
objvFuncModuleEN.FuncModuleId = objRow[convFuncModule.FuncModuleId].ToString().Trim(); //模块Id
objvFuncModuleEN.FuncModuleName = objRow[convFuncModule.FuncModuleName].ToString().Trim(); //模块名
objvFuncModuleEN.FuncModuleNameSim = objRow[convFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[convFuncModule.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objvFuncModuleEN.FuncModuleEnName = objRow[convFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[convFuncModule.FuncModuleEnName].ToString().Trim(); //模块英文名
objvFuncModuleEN.OrderNum = Int32.Parse(objRow[convFuncModule.OrderNum].ToString().Trim()); //排序号
objvFuncModuleEN.PrjId = objRow[convFuncModule.PrjId] == DBNull.Value ? null : objRow[convFuncModule.PrjId].ToString().Trim(); //工程ID
objvFuncModuleEN.UseStateId = objRow[convFuncModule.UseStateId].ToString().Trim(); //UseStateId
objvFuncModuleEN.UseStateName = objRow[convFuncModule.UseStateName] == DBNull.Value ? null : objRow[convFuncModule.UseStateName].ToString().Trim(); //使用状态名称
objvFuncModuleEN.UpdDate = objRow[convFuncModule.UpdDate] == DBNull.Value ? null : objRow[convFuncModule.UpdDate].ToString().Trim(); //修改日期
objvFuncModuleEN.UpdUser = objRow[convFuncModule.UpdUser] == DBNull.Value ? null : objRow[convFuncModule.UpdUser].ToString().Trim(); //修改用户
objvFuncModuleEN.Memo = objRow[convFuncModule.Memo] == DBNull.Value ? null : objRow[convFuncModule.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncModuleEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncModuleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrFuncModuleIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvFuncModuleEN> GetObjLstByFuncModuleIdLstCache(List<string> arrFuncModuleIdLst)
{
string strKey = string.Format("{0}", clsvFuncModuleEN._CurrTabName);
List<clsvFuncModuleEN> arrvFuncModuleObjLstCache = GetObjLstCache();
IEnumerable <clsvFuncModuleEN> arrvFuncModuleObjLst_Sel =
arrvFuncModuleObjLstCache
.Where(x => arrFuncModuleIdLst.Contains(x.FuncModuleId));
return arrvFuncModuleObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFuncModuleEN> GetObjLst(string strWhereCond)
{
List<clsvFuncModuleEN> arrObjLst = new List<clsvFuncModuleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncModuleEN objvFuncModuleEN = new clsvFuncModuleEN();
try
{
objvFuncModuleEN.FuncModuleId = objRow[convFuncModule.FuncModuleId].ToString().Trim(); //模块Id
objvFuncModuleEN.FuncModuleName = objRow[convFuncModule.FuncModuleName].ToString().Trim(); //模块名
objvFuncModuleEN.FuncModuleNameSim = objRow[convFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[convFuncModule.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objvFuncModuleEN.FuncModuleEnName = objRow[convFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[convFuncModule.FuncModuleEnName].ToString().Trim(); //模块英文名
objvFuncModuleEN.OrderNum = Int32.Parse(objRow[convFuncModule.OrderNum].ToString().Trim()); //排序号
objvFuncModuleEN.PrjId = objRow[convFuncModule.PrjId] == DBNull.Value ? null : objRow[convFuncModule.PrjId].ToString().Trim(); //工程ID
objvFuncModuleEN.UseStateId = objRow[convFuncModule.UseStateId].ToString().Trim(); //UseStateId
objvFuncModuleEN.UseStateName = objRow[convFuncModule.UseStateName] == DBNull.Value ? null : objRow[convFuncModule.UseStateName].ToString().Trim(); //使用状态名称
objvFuncModuleEN.UpdDate = objRow[convFuncModule.UpdDate] == DBNull.Value ? null : objRow[convFuncModule.UpdDate].ToString().Trim(); //修改日期
objvFuncModuleEN.UpdUser = objRow[convFuncModule.UpdUser] == DBNull.Value ? null : objRow[convFuncModule.UpdUser].ToString().Trim(); //修改用户
objvFuncModuleEN.Memo = objRow[convFuncModule.Memo] == DBNull.Value ? null : objRow[convFuncModule.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncModuleEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncModuleEN);
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
public static List<clsvFuncModuleEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvFuncModuleEN> arrObjLst = new List<clsvFuncModuleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncModuleEN objvFuncModuleEN = new clsvFuncModuleEN();
try
{
objvFuncModuleEN.FuncModuleId = objRow[convFuncModule.FuncModuleId].ToString().Trim(); //模块Id
objvFuncModuleEN.FuncModuleName = objRow[convFuncModule.FuncModuleName].ToString().Trim(); //模块名
objvFuncModuleEN.FuncModuleNameSim = objRow[convFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[convFuncModule.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objvFuncModuleEN.FuncModuleEnName = objRow[convFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[convFuncModule.FuncModuleEnName].ToString().Trim(); //模块英文名
objvFuncModuleEN.OrderNum = Int32.Parse(objRow[convFuncModule.OrderNum].ToString().Trim()); //排序号
objvFuncModuleEN.PrjId = objRow[convFuncModule.PrjId] == DBNull.Value ? null : objRow[convFuncModule.PrjId].ToString().Trim(); //工程ID
objvFuncModuleEN.UseStateId = objRow[convFuncModule.UseStateId].ToString().Trim(); //UseStateId
objvFuncModuleEN.UseStateName = objRow[convFuncModule.UseStateName] == DBNull.Value ? null : objRow[convFuncModule.UseStateName].ToString().Trim(); //使用状态名称
objvFuncModuleEN.UpdDate = objRow[convFuncModule.UpdDate] == DBNull.Value ? null : objRow[convFuncModule.UpdDate].ToString().Trim(); //修改日期
objvFuncModuleEN.UpdUser = objRow[convFuncModule.UpdUser] == DBNull.Value ? null : objRow[convFuncModule.UpdUser].ToString().Trim(); //修改用户
objvFuncModuleEN.Memo = objRow[convFuncModule.Memo] == DBNull.Value ? null : objRow[convFuncModule.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncModuleEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncModuleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvFuncModuleCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvFuncModuleEN> GetSubObjLstCache(clsvFuncModuleEN objvFuncModuleCond)
{
List<clsvFuncModuleEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvFuncModuleEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFuncModule.AttributeName)
{
if (objvFuncModuleCond.IsUpdated(strFldName) == false) continue;
if (objvFuncModuleCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFuncModuleCond[strFldName].ToString());
}
else
{
if (objvFuncModuleCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFuncModuleCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFuncModuleCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFuncModuleCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFuncModuleCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFuncModuleCond[strFldName]));
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
public static List<clsvFuncModuleEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvFuncModuleEN> arrObjLst = new List<clsvFuncModuleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncModuleEN objvFuncModuleEN = new clsvFuncModuleEN();
try
{
objvFuncModuleEN.FuncModuleId = objRow[convFuncModule.FuncModuleId].ToString().Trim(); //模块Id
objvFuncModuleEN.FuncModuleName = objRow[convFuncModule.FuncModuleName].ToString().Trim(); //模块名
objvFuncModuleEN.FuncModuleNameSim = objRow[convFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[convFuncModule.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objvFuncModuleEN.FuncModuleEnName = objRow[convFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[convFuncModule.FuncModuleEnName].ToString().Trim(); //模块英文名
objvFuncModuleEN.OrderNum = Int32.Parse(objRow[convFuncModule.OrderNum].ToString().Trim()); //排序号
objvFuncModuleEN.PrjId = objRow[convFuncModule.PrjId] == DBNull.Value ? null : objRow[convFuncModule.PrjId].ToString().Trim(); //工程ID
objvFuncModuleEN.UseStateId = objRow[convFuncModule.UseStateId].ToString().Trim(); //UseStateId
objvFuncModuleEN.UseStateName = objRow[convFuncModule.UseStateName] == DBNull.Value ? null : objRow[convFuncModule.UseStateName].ToString().Trim(); //使用状态名称
objvFuncModuleEN.UpdDate = objRow[convFuncModule.UpdDate] == DBNull.Value ? null : objRow[convFuncModule.UpdDate].ToString().Trim(); //修改日期
objvFuncModuleEN.UpdUser = objRow[convFuncModule.UpdUser] == DBNull.Value ? null : objRow[convFuncModule.UpdUser].ToString().Trim(); //修改用户
objvFuncModuleEN.Memo = objRow[convFuncModule.Memo] == DBNull.Value ? null : objRow[convFuncModule.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncModuleEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncModuleEN);
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
public static List<clsvFuncModuleEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvFuncModuleEN> arrObjLst = new List<clsvFuncModuleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncModuleEN objvFuncModuleEN = new clsvFuncModuleEN();
try
{
objvFuncModuleEN.FuncModuleId = objRow[convFuncModule.FuncModuleId].ToString().Trim(); //模块Id
objvFuncModuleEN.FuncModuleName = objRow[convFuncModule.FuncModuleName].ToString().Trim(); //模块名
objvFuncModuleEN.FuncModuleNameSim = objRow[convFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[convFuncModule.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objvFuncModuleEN.FuncModuleEnName = objRow[convFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[convFuncModule.FuncModuleEnName].ToString().Trim(); //模块英文名
objvFuncModuleEN.OrderNum = Int32.Parse(objRow[convFuncModule.OrderNum].ToString().Trim()); //排序号
objvFuncModuleEN.PrjId = objRow[convFuncModule.PrjId] == DBNull.Value ? null : objRow[convFuncModule.PrjId].ToString().Trim(); //工程ID
objvFuncModuleEN.UseStateId = objRow[convFuncModule.UseStateId].ToString().Trim(); //UseStateId
objvFuncModuleEN.UseStateName = objRow[convFuncModule.UseStateName] == DBNull.Value ? null : objRow[convFuncModule.UseStateName].ToString().Trim(); //使用状态名称
objvFuncModuleEN.UpdDate = objRow[convFuncModule.UpdDate] == DBNull.Value ? null : objRow[convFuncModule.UpdDate].ToString().Trim(); //修改日期
objvFuncModuleEN.UpdUser = objRow[convFuncModule.UpdUser] == DBNull.Value ? null : objRow[convFuncModule.UpdUser].ToString().Trim(); //修改用户
objvFuncModuleEN.Memo = objRow[convFuncModule.Memo] == DBNull.Value ? null : objRow[convFuncModule.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncModuleEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncModuleEN);
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
List<clsvFuncModuleEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvFuncModuleEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFuncModuleEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvFuncModuleEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvFuncModuleEN> arrObjLst = new List<clsvFuncModuleEN>(); 
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
	clsvFuncModuleEN objvFuncModuleEN = new clsvFuncModuleEN();
try
{
objvFuncModuleEN.FuncModuleId = objRow[convFuncModule.FuncModuleId].ToString().Trim(); //模块Id
objvFuncModuleEN.FuncModuleName = objRow[convFuncModule.FuncModuleName].ToString().Trim(); //模块名
objvFuncModuleEN.FuncModuleNameSim = objRow[convFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[convFuncModule.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objvFuncModuleEN.FuncModuleEnName = objRow[convFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[convFuncModule.FuncModuleEnName].ToString().Trim(); //模块英文名
objvFuncModuleEN.OrderNum = Int32.Parse(objRow[convFuncModule.OrderNum].ToString().Trim()); //排序号
objvFuncModuleEN.PrjId = objRow[convFuncModule.PrjId] == DBNull.Value ? null : objRow[convFuncModule.PrjId].ToString().Trim(); //工程ID
objvFuncModuleEN.UseStateId = objRow[convFuncModule.UseStateId].ToString().Trim(); //UseStateId
objvFuncModuleEN.UseStateName = objRow[convFuncModule.UseStateName] == DBNull.Value ? null : objRow[convFuncModule.UseStateName].ToString().Trim(); //使用状态名称
objvFuncModuleEN.UpdDate = objRow[convFuncModule.UpdDate] == DBNull.Value ? null : objRow[convFuncModule.UpdDate].ToString().Trim(); //修改日期
objvFuncModuleEN.UpdUser = objRow[convFuncModule.UpdUser] == DBNull.Value ? null : objRow[convFuncModule.UpdUser].ToString().Trim(); //修改用户
objvFuncModuleEN.Memo = objRow[convFuncModule.Memo] == DBNull.Value ? null : objRow[convFuncModule.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncModuleEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncModuleEN);
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
public static List<clsvFuncModuleEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvFuncModuleEN> arrObjLst = new List<clsvFuncModuleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncModuleEN objvFuncModuleEN = new clsvFuncModuleEN();
try
{
objvFuncModuleEN.FuncModuleId = objRow[convFuncModule.FuncModuleId].ToString().Trim(); //模块Id
objvFuncModuleEN.FuncModuleName = objRow[convFuncModule.FuncModuleName].ToString().Trim(); //模块名
objvFuncModuleEN.FuncModuleNameSim = objRow[convFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[convFuncModule.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objvFuncModuleEN.FuncModuleEnName = objRow[convFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[convFuncModule.FuncModuleEnName].ToString().Trim(); //模块英文名
objvFuncModuleEN.OrderNum = Int32.Parse(objRow[convFuncModule.OrderNum].ToString().Trim()); //排序号
objvFuncModuleEN.PrjId = objRow[convFuncModule.PrjId] == DBNull.Value ? null : objRow[convFuncModule.PrjId].ToString().Trim(); //工程ID
objvFuncModuleEN.UseStateId = objRow[convFuncModule.UseStateId].ToString().Trim(); //UseStateId
objvFuncModuleEN.UseStateName = objRow[convFuncModule.UseStateName] == DBNull.Value ? null : objRow[convFuncModule.UseStateName].ToString().Trim(); //使用状态名称
objvFuncModuleEN.UpdDate = objRow[convFuncModule.UpdDate] == DBNull.Value ? null : objRow[convFuncModule.UpdDate].ToString().Trim(); //修改日期
objvFuncModuleEN.UpdUser = objRow[convFuncModule.UpdUser] == DBNull.Value ? null : objRow[convFuncModule.UpdUser].ToString().Trim(); //修改用户
objvFuncModuleEN.Memo = objRow[convFuncModule.Memo] == DBNull.Value ? null : objRow[convFuncModule.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncModuleEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncModuleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvFuncModuleEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvFuncModuleEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvFuncModuleEN> arrObjLst = new List<clsvFuncModuleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncModuleEN objvFuncModuleEN = new clsvFuncModuleEN();
try
{
objvFuncModuleEN.FuncModuleId = objRow[convFuncModule.FuncModuleId].ToString().Trim(); //模块Id
objvFuncModuleEN.FuncModuleName = objRow[convFuncModule.FuncModuleName].ToString().Trim(); //模块名
objvFuncModuleEN.FuncModuleNameSim = objRow[convFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[convFuncModule.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objvFuncModuleEN.FuncModuleEnName = objRow[convFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[convFuncModule.FuncModuleEnName].ToString().Trim(); //模块英文名
objvFuncModuleEN.OrderNum = Int32.Parse(objRow[convFuncModule.OrderNum].ToString().Trim()); //排序号
objvFuncModuleEN.PrjId = objRow[convFuncModule.PrjId] == DBNull.Value ? null : objRow[convFuncModule.PrjId].ToString().Trim(); //工程ID
objvFuncModuleEN.UseStateId = objRow[convFuncModule.UseStateId].ToString().Trim(); //UseStateId
objvFuncModuleEN.UseStateName = objRow[convFuncModule.UseStateName] == DBNull.Value ? null : objRow[convFuncModule.UseStateName].ToString().Trim(); //使用状态名称
objvFuncModuleEN.UpdDate = objRow[convFuncModule.UpdDate] == DBNull.Value ? null : objRow[convFuncModule.UpdDate].ToString().Trim(); //修改日期
objvFuncModuleEN.UpdUser = objRow[convFuncModule.UpdUser] == DBNull.Value ? null : objRow[convFuncModule.UpdUser].ToString().Trim(); //修改用户
objvFuncModuleEN.Memo = objRow[convFuncModule.Memo] == DBNull.Value ? null : objRow[convFuncModule.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncModuleEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncModuleEN);
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
public static List<clsvFuncModuleEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvFuncModuleEN> arrObjLst = new List<clsvFuncModuleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncModuleEN objvFuncModuleEN = new clsvFuncModuleEN();
try
{
objvFuncModuleEN.FuncModuleId = objRow[convFuncModule.FuncModuleId].ToString().Trim(); //模块Id
objvFuncModuleEN.FuncModuleName = objRow[convFuncModule.FuncModuleName].ToString().Trim(); //模块名
objvFuncModuleEN.FuncModuleNameSim = objRow[convFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[convFuncModule.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objvFuncModuleEN.FuncModuleEnName = objRow[convFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[convFuncModule.FuncModuleEnName].ToString().Trim(); //模块英文名
objvFuncModuleEN.OrderNum = Int32.Parse(objRow[convFuncModule.OrderNum].ToString().Trim()); //排序号
objvFuncModuleEN.PrjId = objRow[convFuncModule.PrjId] == DBNull.Value ? null : objRow[convFuncModule.PrjId].ToString().Trim(); //工程ID
objvFuncModuleEN.UseStateId = objRow[convFuncModule.UseStateId].ToString().Trim(); //UseStateId
objvFuncModuleEN.UseStateName = objRow[convFuncModule.UseStateName] == DBNull.Value ? null : objRow[convFuncModule.UseStateName].ToString().Trim(); //使用状态名称
objvFuncModuleEN.UpdDate = objRow[convFuncModule.UpdDate] == DBNull.Value ? null : objRow[convFuncModule.UpdDate].ToString().Trim(); //修改日期
objvFuncModuleEN.UpdUser = objRow[convFuncModule.UpdUser] == DBNull.Value ? null : objRow[convFuncModule.UpdUser].ToString().Trim(); //修改用户
objvFuncModuleEN.Memo = objRow[convFuncModule.Memo] == DBNull.Value ? null : objRow[convFuncModule.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncModuleEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncModuleEN);
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
public static IEnumerable<clsvFuncModuleEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsvFuncModuleEN objvFuncModuleCond, string strOrderBy)
{
List<clsvFuncModuleEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvFuncModuleEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFuncModule.AttributeName)
{
if (objvFuncModuleCond.IsUpdated(strFldName) == false) continue;
if (objvFuncModuleCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFuncModuleCond[strFldName].ToString());
}
else
{
if (objvFuncModuleCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFuncModuleCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFuncModuleCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFuncModuleCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFuncModuleCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFuncModuleCond[strFldName]));
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
public static IEnumerable<clsvFuncModuleEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsvFuncModuleEN objvFuncModuleCond = JsonConvert.DeserializeObject<clsvFuncModuleEN>(objPagerPara.whereCond);
if (objvFuncModuleCond.sfFldComparisonOp == null)
{
objvFuncModuleCond.dicFldComparisonOp = null;
}
else
{
objvFuncModuleCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objvFuncModuleCond.sfFldComparisonOp);
}
clsvFuncModuleBL.SetUpdFlag(objvFuncModuleCond);
 try
{
CheckProperty4Condition(objvFuncModuleCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsvFuncModuleBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objvFuncModuleCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFuncModuleEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsvFuncModuleEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvFuncModuleEN> arrObjLst = new List<clsvFuncModuleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncModuleEN objvFuncModuleEN = new clsvFuncModuleEN();
try
{
objvFuncModuleEN.FuncModuleId = objRow[convFuncModule.FuncModuleId].ToString().Trim(); //模块Id
objvFuncModuleEN.FuncModuleName = objRow[convFuncModule.FuncModuleName].ToString().Trim(); //模块名
objvFuncModuleEN.FuncModuleNameSim = objRow[convFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[convFuncModule.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objvFuncModuleEN.FuncModuleEnName = objRow[convFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[convFuncModule.FuncModuleEnName].ToString().Trim(); //模块英文名
objvFuncModuleEN.OrderNum = Int32.Parse(objRow[convFuncModule.OrderNum].ToString().Trim()); //排序号
objvFuncModuleEN.PrjId = objRow[convFuncModule.PrjId] == DBNull.Value ? null : objRow[convFuncModule.PrjId].ToString().Trim(); //工程ID
objvFuncModuleEN.UseStateId = objRow[convFuncModule.UseStateId].ToString().Trim(); //UseStateId
objvFuncModuleEN.UseStateName = objRow[convFuncModule.UseStateName] == DBNull.Value ? null : objRow[convFuncModule.UseStateName].ToString().Trim(); //使用状态名称
objvFuncModuleEN.UpdDate = objRow[convFuncModule.UpdDate] == DBNull.Value ? null : objRow[convFuncModule.UpdDate].ToString().Trim(); //修改日期
objvFuncModuleEN.UpdUser = objRow[convFuncModule.UpdUser] == DBNull.Value ? null : objRow[convFuncModule.UpdUser].ToString().Trim(); //修改用户
objvFuncModuleEN.Memo = objRow[convFuncModule.Memo] == DBNull.Value ? null : objRow[convFuncModule.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncModuleEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncModuleEN);
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
public static List<clsvFuncModuleEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvFuncModuleEN> arrObjLst = new List<clsvFuncModuleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncModuleEN objvFuncModuleEN = new clsvFuncModuleEN();
try
{
objvFuncModuleEN.FuncModuleId = objRow[convFuncModule.FuncModuleId].ToString().Trim(); //模块Id
objvFuncModuleEN.FuncModuleName = objRow[convFuncModule.FuncModuleName].ToString().Trim(); //模块名
objvFuncModuleEN.FuncModuleNameSim = objRow[convFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[convFuncModule.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objvFuncModuleEN.FuncModuleEnName = objRow[convFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[convFuncModule.FuncModuleEnName].ToString().Trim(); //模块英文名
objvFuncModuleEN.OrderNum = Int32.Parse(objRow[convFuncModule.OrderNum].ToString().Trim()); //排序号
objvFuncModuleEN.PrjId = objRow[convFuncModule.PrjId] == DBNull.Value ? null : objRow[convFuncModule.PrjId].ToString().Trim(); //工程ID
objvFuncModuleEN.UseStateId = objRow[convFuncModule.UseStateId].ToString().Trim(); //UseStateId
objvFuncModuleEN.UseStateName = objRow[convFuncModule.UseStateName] == DBNull.Value ? null : objRow[convFuncModule.UseStateName].ToString().Trim(); //使用状态名称
objvFuncModuleEN.UpdDate = objRow[convFuncModule.UpdDate] == DBNull.Value ? null : objRow[convFuncModule.UpdDate].ToString().Trim(); //修改日期
objvFuncModuleEN.UpdUser = objRow[convFuncModule.UpdUser] == DBNull.Value ? null : objRow[convFuncModule.UpdUser].ToString().Trim(); //修改用户
objvFuncModuleEN.Memo = objRow[convFuncModule.Memo] == DBNull.Value ? null : objRow[convFuncModule.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncModuleEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncModuleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFuncModuleEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvFuncModuleEN> arrObjLst = new List<clsvFuncModuleEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncModuleEN objvFuncModuleEN = new clsvFuncModuleEN();
try
{
objvFuncModuleEN.FuncModuleId = objRow[convFuncModule.FuncModuleId].ToString().Trim(); //模块Id
objvFuncModuleEN.FuncModuleName = objRow[convFuncModule.FuncModuleName].ToString().Trim(); //模块名
objvFuncModuleEN.FuncModuleNameSim = objRow[convFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[convFuncModule.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objvFuncModuleEN.FuncModuleEnName = objRow[convFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[convFuncModule.FuncModuleEnName].ToString().Trim(); //模块英文名
objvFuncModuleEN.OrderNum = Int32.Parse(objRow[convFuncModule.OrderNum].ToString().Trim()); //排序号
objvFuncModuleEN.PrjId = objRow[convFuncModule.PrjId] == DBNull.Value ? null : objRow[convFuncModule.PrjId].ToString().Trim(); //工程ID
objvFuncModuleEN.UseStateId = objRow[convFuncModule.UseStateId].ToString().Trim(); //UseStateId
objvFuncModuleEN.UseStateName = objRow[convFuncModule.UseStateName] == DBNull.Value ? null : objRow[convFuncModule.UseStateName].ToString().Trim(); //使用状态名称
objvFuncModuleEN.UpdDate = objRow[convFuncModule.UpdDate] == DBNull.Value ? null : objRow[convFuncModule.UpdDate].ToString().Trim(); //修改日期
objvFuncModuleEN.UpdUser = objRow[convFuncModule.UpdUser] == DBNull.Value ? null : objRow[convFuncModule.UpdUser].ToString().Trim(); //修改用户
objvFuncModuleEN.Memo = objRow[convFuncModule.Memo] == DBNull.Value ? null : objRow[convFuncModule.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncModuleEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncModuleEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvFuncModuleEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvFuncModule(ref clsvFuncModuleEN objvFuncModuleEN)
{
bool bolResult = vFuncModuleDA.GetvFuncModule(ref objvFuncModuleEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strFuncModuleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFuncModuleEN GetObjByFuncModuleId(string strFuncModuleId)
{
if (strFuncModuleId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strFuncModuleId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strFuncModuleId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strFuncModuleId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvFuncModuleEN objvFuncModuleEN = vFuncModuleDA.GetObjByFuncModuleId(strFuncModuleId);
return objvFuncModuleEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvFuncModuleEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvFuncModuleEN objvFuncModuleEN = vFuncModuleDA.GetFirstObj(strWhereCond);
 return objvFuncModuleEN;
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
public static clsvFuncModuleEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvFuncModuleEN objvFuncModuleEN = vFuncModuleDA.GetObjByDataRow(objRow);
 return objvFuncModuleEN;
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
public static clsvFuncModuleEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvFuncModuleEN objvFuncModuleEN = vFuncModuleDA.GetObjByDataRow(objRow);
 return objvFuncModuleEN;
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
 /// <param name = "strFuncModuleId">所给的关键字</param>
 /// <param name = "lstvFuncModuleObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFuncModuleEN GetObjByFuncModuleIdFromList(string strFuncModuleId, List<clsvFuncModuleEN> lstvFuncModuleObjLst)
{
foreach (clsvFuncModuleEN objvFuncModuleEN in lstvFuncModuleObjLst)
{
if (objvFuncModuleEN.FuncModuleId == strFuncModuleId)
{
return objvFuncModuleEN;
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
 string strFuncModuleId;
 try
 {
 strFuncModuleId = new clsvFuncModuleDA().GetFirstID(strWhereCond);
 return strFuncModuleId;
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
 arrList = vFuncModuleDA.GetID(strWhereCond);
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
bool bolIsExist = vFuncModuleDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strFuncModuleId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strFuncModuleId)
{
if (string.IsNullOrEmpty(strFuncModuleId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strFuncModuleId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vFuncModuleDA.IsExist(strFuncModuleId);
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
 bolIsExist = clsvFuncModuleDA.IsExistTable();
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
 bolIsExist = vFuncModuleDA.IsExistTable(strTabName);
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
 /// <param name = "objvFuncModuleENS">源对象</param>
 /// <param name = "objvFuncModuleENT">目标对象</param>
 public static void CopyTo(clsvFuncModuleEN objvFuncModuleENS, clsvFuncModuleEN objvFuncModuleENT)
{
try
{
objvFuncModuleENT.FuncModuleId = objvFuncModuleENS.FuncModuleId; //模块Id
objvFuncModuleENT.FuncModuleName = objvFuncModuleENS.FuncModuleName; //模块名
objvFuncModuleENT.FuncModuleNameSim = objvFuncModuleENS.FuncModuleNameSim; //模块名_Sim
objvFuncModuleENT.FuncModuleEnName = objvFuncModuleENS.FuncModuleEnName; //模块英文名
objvFuncModuleENT.OrderNum = objvFuncModuleENS.OrderNum; //排序号
objvFuncModuleENT.PrjId = objvFuncModuleENS.PrjId; //工程ID
objvFuncModuleENT.UseStateId = objvFuncModuleENS.UseStateId; //UseStateId
objvFuncModuleENT.UseStateName = objvFuncModuleENS.UseStateName; //使用状态名称
objvFuncModuleENT.UpdDate = objvFuncModuleENS.UpdDate; //修改日期
objvFuncModuleENT.UpdUser = objvFuncModuleENS.UpdUser; //修改用户
objvFuncModuleENT.Memo = objvFuncModuleENS.Memo; //备注
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
 /// <param name = "objvFuncModuleEN">源简化对象</param>
 public static void SetUpdFlag(clsvFuncModuleEN objvFuncModuleEN)
{
try
{
objvFuncModuleEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvFuncModuleEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convFuncModule.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncModuleEN.FuncModuleId = objvFuncModuleEN.FuncModuleId; //模块Id
}
if (arrFldSet.Contains(convFuncModule.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncModuleEN.FuncModuleName = objvFuncModuleEN.FuncModuleName; //模块名
}
if (arrFldSet.Contains(convFuncModule.FuncModuleNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncModuleEN.FuncModuleNameSim = objvFuncModuleEN.FuncModuleNameSim == "[null]" ? null :  objvFuncModuleEN.FuncModuleNameSim; //模块名_Sim
}
if (arrFldSet.Contains(convFuncModule.FuncModuleEnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncModuleEN.FuncModuleEnName = objvFuncModuleEN.FuncModuleEnName == "[null]" ? null :  objvFuncModuleEN.FuncModuleEnName; //模块英文名
}
if (arrFldSet.Contains(convFuncModule.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncModuleEN.OrderNum = objvFuncModuleEN.OrderNum; //排序号
}
if (arrFldSet.Contains(convFuncModule.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncModuleEN.PrjId = objvFuncModuleEN.PrjId == "[null]" ? null :  objvFuncModuleEN.PrjId; //工程ID
}
if (arrFldSet.Contains(convFuncModule.UseStateId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncModuleEN.UseStateId = objvFuncModuleEN.UseStateId; //UseStateId
}
if (arrFldSet.Contains(convFuncModule.UseStateName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncModuleEN.UseStateName = objvFuncModuleEN.UseStateName == "[null]" ? null :  objvFuncModuleEN.UseStateName; //使用状态名称
}
if (arrFldSet.Contains(convFuncModule.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncModuleEN.UpdDate = objvFuncModuleEN.UpdDate == "[null]" ? null :  objvFuncModuleEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convFuncModule.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncModuleEN.UpdUser = objvFuncModuleEN.UpdUser == "[null]" ? null :  objvFuncModuleEN.UpdUser; //修改用户
}
if (arrFldSet.Contains(convFuncModule.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncModuleEN.Memo = objvFuncModuleEN.Memo == "[null]" ? null :  objvFuncModuleEN.Memo; //备注
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
 /// <param name = "objvFuncModuleEN">源简化对象</param>
 public static void AccessFldValueNull(clsvFuncModuleEN objvFuncModuleEN)
{
try
{
if (objvFuncModuleEN.FuncModuleNameSim == "[null]") objvFuncModuleEN.FuncModuleNameSim = null; //模块名_Sim
if (objvFuncModuleEN.FuncModuleEnName == "[null]") objvFuncModuleEN.FuncModuleEnName = null; //模块英文名
if (objvFuncModuleEN.PrjId == "[null]") objvFuncModuleEN.PrjId = null; //工程ID
if (objvFuncModuleEN.UseStateName == "[null]") objvFuncModuleEN.UseStateName = null; //使用状态名称
if (objvFuncModuleEN.UpdDate == "[null]") objvFuncModuleEN.UpdDate = null; //修改日期
if (objvFuncModuleEN.UpdUser == "[null]") objvFuncModuleEN.UpdUser = null; //修改用户
if (objvFuncModuleEN.Memo == "[null]") objvFuncModuleEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvFuncModuleEN objvFuncModuleEN)
{
 vFuncModuleDA.CheckProperty4Condition(objvFuncModuleEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_FuncModuleId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convFuncModule.FuncModuleId); 
List<clsvFuncModuleEN> arrObjLst = clsvFuncModuleBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvFuncModuleEN objvFuncModuleEN = new clsvFuncModuleEN()
{
FuncModuleId = "0",
FuncModuleName = "选[v功能模块]..."
};
arrObjLst.Insert(0, objvFuncModuleEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convFuncModule.FuncModuleId;
objComboBox.DisplayMember = convFuncModule.FuncModuleName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_FuncModuleId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v功能模块]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convFuncModule.FuncModuleId); 
IEnumerable<clsvFuncModuleEN> arrObjLst = clsvFuncModuleBL.GetObjLst(strCondition);
objDDL.DataValueField = convFuncModule.FuncModuleId;
objDDL.DataTextField = convFuncModule.FuncModuleName;
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
public static void BindDdl_FuncModuleIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v功能模块]...","0");
List<clsvFuncModuleEN> arrvFuncModuleObjLst = GetAllvFuncModuleObjLstCache(); 
objDDL.DataValueField = convFuncModule.FuncModuleId;
objDDL.DataTextField = convFuncModule.FuncModuleName;
objDDL.DataSource = arrvFuncModuleObjLst;
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
if (clsFuncModuleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleBL没有刷新缓存机制(clsFuncModuleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by FuncModuleId");
//if (arrvFuncModuleObjLstCache == null)
//{
//arrvFuncModuleObjLstCache = vFuncModuleDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strFuncModuleId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFuncModuleEN GetObjByFuncModuleIdCache(string strFuncModuleId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvFuncModuleEN._CurrTabName);
List<clsvFuncModuleEN> arrvFuncModuleObjLstCache = GetObjLstCache();
IEnumerable <clsvFuncModuleEN> arrvFuncModuleObjLst_Sel =
arrvFuncModuleObjLstCache
.Where(x=> x.FuncModuleId == strFuncModuleId 
);
if (arrvFuncModuleObjLst_Sel.Count() == 0)
{
   clsvFuncModuleEN obj = clsvFuncModuleBL.GetObjByFuncModuleId(strFuncModuleId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvFuncModuleObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFuncModuleId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetFuncModuleNameByFuncModuleIdCache(string strFuncModuleId)
{
if (string.IsNullOrEmpty(strFuncModuleId) == true) return "";
//获取缓存中的对象列表
clsvFuncModuleEN objvFuncModule = GetObjByFuncModuleIdCache(strFuncModuleId);
if (objvFuncModule == null) return "";
return objvFuncModule.FuncModuleName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFuncModuleId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByFuncModuleIdCache(string strFuncModuleId)
{
if (string.IsNullOrEmpty(strFuncModuleId) == true) return "";
//获取缓存中的对象列表
clsvFuncModuleEN objvFuncModule = GetObjByFuncModuleIdCache(strFuncModuleId);
if (objvFuncModule == null) return "";
return objvFuncModule.FuncModuleName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFuncModuleEN> GetAllvFuncModuleObjLstCache()
{
//获取缓存中的对象列表
List<clsvFuncModuleEN> arrvFuncModuleObjLstCache = GetObjLstCache(); 
return arrvFuncModuleObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFuncModuleEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvFuncModuleEN._CurrTabName);
List<clsvFuncModuleEN> arrvFuncModuleObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvFuncModuleObjLstCache;
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
string strKey = string.Format("{0}", clsvFuncModuleEN._CurrTabName);
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
 /// <param name = "lstvFuncModuleObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsvFuncModuleEN> lstvFuncModuleObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstvFuncModuleObjLst, writer);
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
 /// <param name = "lstvFuncModuleObjLst">[clsvFuncModuleEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsvFuncModuleEN> lstvFuncModuleObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsvFuncModuleBL.listXmlNode);
writer.WriteStartElement(clsvFuncModuleBL.itemsXmlNode);
foreach (clsvFuncModuleEN objvFuncModuleEN in lstvFuncModuleObjLst)
{
clsvFuncModuleBL.SerializeXML(writer, objvFuncModuleEN);
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
 /// <param name = "objvFuncModuleEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsvFuncModuleEN objvFuncModuleEN)
{
writer.WriteStartElement(clsvFuncModuleBL.itemXmlNode);
 
if (objvFuncModuleEN.FuncModuleId != null)
{
writer.WriteElementString(convFuncModule.FuncModuleId, objvFuncModuleEN.FuncModuleId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvFuncModuleEN.FuncModuleName != null)
{
writer.WriteElementString(convFuncModule.FuncModuleName, objvFuncModuleEN.FuncModuleName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvFuncModuleEN.FuncModuleNameSim != null)
{
writer.WriteElementString(convFuncModule.FuncModuleNameSim, objvFuncModuleEN.FuncModuleNameSim.ToString(CultureInfo.InvariantCulture));
}
 
if (objvFuncModuleEN.FuncModuleEnName != null)
{
writer.WriteElementString(convFuncModule.FuncModuleEnName, objvFuncModuleEN.FuncModuleEnName.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convFuncModule.OrderNum, objvFuncModuleEN.OrderNum.ToString(CultureInfo.InvariantCulture));
 
if (objvFuncModuleEN.PrjId != null)
{
writer.WriteElementString(convFuncModule.PrjId, objvFuncModuleEN.PrjId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvFuncModuleEN.UseStateId != null)
{
writer.WriteElementString(convFuncModule.UseStateId, objvFuncModuleEN.UseStateId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvFuncModuleEN.UseStateName != null)
{
writer.WriteElementString(convFuncModule.UseStateName, objvFuncModuleEN.UseStateName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvFuncModuleEN.UpdDate != null)
{
writer.WriteElementString(convFuncModule.UpdDate, objvFuncModuleEN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objvFuncModuleEN.UpdUser != null)
{
writer.WriteElementString(convFuncModule.UpdUser, objvFuncModuleEN.UpdUser.ToString(CultureInfo.InvariantCulture));
}
 
if (objvFuncModuleEN.Memo != null)
{
writer.WriteElementString(convFuncModule.Memo, objvFuncModuleEN.Memo.ToString(CultureInfo.InvariantCulture));
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
public static clsvFuncModuleEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsvFuncModuleEN objvFuncModuleEN = new clsvFuncModuleEN();
reader.Read();
while (!(reader.Name == clsvFuncModuleBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(convFuncModule.FuncModuleId))
{
objvFuncModuleEN.FuncModuleId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convFuncModule.FuncModuleName))
{
objvFuncModuleEN.FuncModuleName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convFuncModule.FuncModuleNameSim))
{
objvFuncModuleEN.FuncModuleNameSim = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convFuncModule.FuncModuleEnName))
{
objvFuncModuleEN.FuncModuleEnName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convFuncModule.OrderNum))
{
objvFuncModuleEN.OrderNum = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(convFuncModule.PrjId))
{
objvFuncModuleEN.PrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convFuncModule.UseStateId))
{
objvFuncModuleEN.UseStateId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convFuncModule.UseStateName))
{
objvFuncModuleEN.UseStateName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convFuncModule.UpdDate))
{
objvFuncModuleEN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convFuncModule.UpdUser))
{
objvFuncModuleEN.UpdUser = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convFuncModule.Memo))
{
objvFuncModuleEN.Memo = reader.ReadElementContentAsString();
}
}
return objvFuncModuleEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strvFuncModuleObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsvFuncModuleEN GetObjFromXmlStr(string strvFuncModuleObjXmlStr)
{
clsvFuncModuleEN objvFuncModuleEN = new clsvFuncModuleEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strvFuncModuleObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsvFuncModuleBL.itemXmlNode))
{
objvFuncModuleEN = GetObjFromXml(reader);
return objvFuncModuleEN;
}
}
return objvFuncModuleEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objvFuncModuleEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsvFuncModuleEN objvFuncModuleEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objvFuncModuleEN);
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
public static string Func(string strInFldName, string strOutFldName, string strFuncModuleId)
{
if (strInFldName != convFuncModule.FuncModuleId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convFuncModule.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convFuncModule.AttributeName));
throw new Exception(strMsg);
}
var objvFuncModule = clsvFuncModuleBL.GetObjByFuncModuleIdCache(strFuncModuleId);
if (objvFuncModule == null) return "";
return objvFuncModule[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objvFuncModuleEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsvFuncModuleEN objvFuncModuleEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsvFuncModuleEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objvFuncModuleEN[strField]);
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
 /// <param name = "lstvFuncModuleObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsvFuncModuleEN> lstvFuncModuleObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstvFuncModuleObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsvFuncModuleEN objvFuncModuleEN in lstvFuncModuleObjLst)
{
string strJSON_One = SerializeObjToJSON(objvFuncModuleEN);
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
int intRecCount = clsvFuncModuleDA.GetRecCount(strTabName);
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
int intRecCount = clsvFuncModuleDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvFuncModuleDA.GetRecCount();
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
int intRecCount = clsvFuncModuleDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvFuncModuleCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvFuncModuleEN objvFuncModuleCond)
{
List<clsvFuncModuleEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvFuncModuleEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFuncModule.AttributeName)
{
if (objvFuncModuleCond.IsUpdated(strFldName) == false) continue;
if (objvFuncModuleCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFuncModuleCond[strFldName].ToString());
}
else
{
if (objvFuncModuleCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFuncModuleCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFuncModuleCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFuncModuleCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFuncModuleCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFuncModuleCond[strFldName]));
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
 List<string> arrList = clsvFuncModuleDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vFuncModuleDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vFuncModuleDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}