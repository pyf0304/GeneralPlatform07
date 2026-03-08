
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxFuncModule_AgcWApi
 表名:vQxFuncModule_Agc(00140102)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 18:30:57
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:工程管理(PrjManage_GP)
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
public static class  clsvQxFuncModule_AgcWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxFuncModule_AgcEN SetPrjName(this clsvQxFuncModule_AgcEN objvQxFuncModule_AgcEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convQxFuncModule_Agc.PrjName);
clsCheckSql.CheckFieldLen(strPrjName, 30, convQxFuncModule_Agc.PrjName);
objvQxFuncModule_AgcEN.PrjName = strPrjName; //工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(convQxFuncModule_Agc.PrjName) == false)
{
objvQxFuncModule_AgcEN.dicFldComparisonOp.Add(convQxFuncModule_Agc.PrjName, strComparisonOp);
}
else
{
objvQxFuncModule_AgcEN.dicFldComparisonOp[convQxFuncModule_Agc.PrjName] = strComparisonOp;
}
}
return objvQxFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strUseStateName">使用状态名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxFuncModule_AgcEN SetUseStateName(this clsvQxFuncModule_AgcEN objvQxFuncModule_AgcEN, string strUseStateName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUseStateName, 30, convQxFuncModule_Agc.UseStateName);
objvQxFuncModule_AgcEN.UseStateName = strUseStateName; //使用状态名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(convQxFuncModule_Agc.UseStateName) == false)
{
objvQxFuncModule_AgcEN.dicFldComparisonOp.Add(convQxFuncModule_Agc.UseStateName, strComparisonOp);
}
else
{
objvQxFuncModule_AgcEN.dicFldComparisonOp[convQxFuncModule_Agc.UseStateName] = strComparisonOp;
}
}
return objvQxFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleAgcId">功能模块Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxFuncModule_AgcEN SetFuncModuleAgcId(this clsvQxFuncModule_AgcEN objvQxFuncModule_AgcEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convQxFuncModule_Agc.FuncModuleAgcId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convQxFuncModule_Agc.FuncModuleAgcId);
objvQxFuncModule_AgcEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(convQxFuncModule_Agc.FuncModuleAgcId) == false)
{
objvQxFuncModule_AgcEN.dicFldComparisonOp.Add(convQxFuncModule_Agc.FuncModuleAgcId, strComparisonOp);
}
else
{
objvQxFuncModule_AgcEN.dicFldComparisonOp[convQxFuncModule_Agc.FuncModuleAgcId] = strComparisonOp;
}
}
return objvQxFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleName">模块名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxFuncModule_AgcEN SetFuncModuleName(this clsvQxFuncModule_AgcEN objvQxFuncModule_AgcEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleName, convQxFuncModule_Agc.FuncModuleName);
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convQxFuncModule_Agc.FuncModuleName);
objvQxFuncModule_AgcEN.FuncModuleName = strFuncModuleName; //模块名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(convQxFuncModule_Agc.FuncModuleName) == false)
{
objvQxFuncModule_AgcEN.dicFldComparisonOp.Add(convQxFuncModule_Agc.FuncModuleName, strComparisonOp);
}
else
{
objvQxFuncModule_AgcEN.dicFldComparisonOp[convQxFuncModule_Agc.FuncModuleName] = strComparisonOp;
}
}
return objvQxFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleEnName">模块英文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxFuncModule_AgcEN SetFuncModuleEnName(this clsvQxFuncModule_AgcEN objvQxFuncModule_AgcEN, string strFuncModuleEnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleEnName, 30, convQxFuncModule_Agc.FuncModuleEnName);
objvQxFuncModule_AgcEN.FuncModuleEnName = strFuncModuleEnName; //模块英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(convQxFuncModule_Agc.FuncModuleEnName) == false)
{
objvQxFuncModule_AgcEN.dicFldComparisonOp.Add(convQxFuncModule_Agc.FuncModuleEnName, strComparisonOp);
}
else
{
objvQxFuncModule_AgcEN.dicFldComparisonOp[convQxFuncModule_Agc.FuncModuleEnName] = strComparisonOp;
}
}
return objvQxFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleNameSim">模块名_Sim</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxFuncModule_AgcEN SetFuncModuleNameSim(this clsvQxFuncModule_AgcEN objvQxFuncModule_AgcEN, string strFuncModuleNameSim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleNameSim, 30, convQxFuncModule_Agc.FuncModuleNameSim);
objvQxFuncModule_AgcEN.FuncModuleNameSim = strFuncModuleNameSim; //模块名_Sim
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(convQxFuncModule_Agc.FuncModuleNameSim) == false)
{
objvQxFuncModule_AgcEN.dicFldComparisonOp.Add(convQxFuncModule_Agc.FuncModuleNameSim, strComparisonOp);
}
else
{
objvQxFuncModule_AgcEN.dicFldComparisonOp[convQxFuncModule_Agc.FuncModuleNameSim] = strComparisonOp;
}
}
return objvQxFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strQxPrjId">项目Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxFuncModule_AgcEN SetQxPrjId(this clsvQxFuncModule_AgcEN objvQxFuncModule_AgcEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, convQxFuncModule_Agc.QxPrjId);
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxFuncModule_Agc.QxPrjId);
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxFuncModule_Agc.QxPrjId);
objvQxFuncModule_AgcEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(convQxFuncModule_Agc.QxPrjId) == false)
{
objvQxFuncModule_AgcEN.dicFldComparisonOp.Add(convQxFuncModule_Agc.QxPrjId, strComparisonOp);
}
else
{
objvQxFuncModule_AgcEN.dicFldComparisonOp[convQxFuncModule_Agc.QxPrjId] = strComparisonOp;
}
}
return objvQxFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">排序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxFuncModule_AgcEN SetOrderNum(this clsvQxFuncModule_AgcEN objvQxFuncModule_AgcEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, convQxFuncModule_Agc.OrderNum);
objvQxFuncModule_AgcEN.OrderNum = intOrderNum; //排序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(convQxFuncModule_Agc.OrderNum) == false)
{
objvQxFuncModule_AgcEN.dicFldComparisonOp.Add(convQxFuncModule_Agc.OrderNum, strComparisonOp);
}
else
{
objvQxFuncModule_AgcEN.dicFldComparisonOp[convQxFuncModule_Agc.OrderNum] = strComparisonOp;
}
}
return objvQxFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strUseStateId">UseStateId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxFuncModule_AgcEN SetUseStateId(this clsvQxFuncModule_AgcEN objvQxFuncModule_AgcEN, string strUseStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUseStateId, convQxFuncModule_Agc.UseStateId);
clsCheckSql.CheckFieldLen(strUseStateId, 4, convQxFuncModule_Agc.UseStateId);
clsCheckSql.CheckFieldForeignKey(strUseStateId, 4, convQxFuncModule_Agc.UseStateId);
objvQxFuncModule_AgcEN.UseStateId = strUseStateId; //UseStateId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(convQxFuncModule_Agc.UseStateId) == false)
{
objvQxFuncModule_AgcEN.dicFldComparisonOp.Add(convQxFuncModule_Agc.UseStateId, strComparisonOp);
}
else
{
objvQxFuncModule_AgcEN.dicFldComparisonOp[convQxFuncModule_Agc.UseStateId] = strComparisonOp;
}
}
return objvQxFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改用户</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxFuncModule_AgcEN SetUpdUser(this clsvQxFuncModule_AgcEN objvQxFuncModule_AgcEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 18, convQxFuncModule_Agc.UpdUser);
objvQxFuncModule_AgcEN.UpdUser = strUpdUser; //修改用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(convQxFuncModule_Agc.UpdUser) == false)
{
objvQxFuncModule_AgcEN.dicFldComparisonOp.Add(convQxFuncModule_Agc.UpdUser, strComparisonOp);
}
else
{
objvQxFuncModule_AgcEN.dicFldComparisonOp[convQxFuncModule_Agc.UpdUser] = strComparisonOp;
}
}
return objvQxFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxFuncModule_AgcEN SetUpdDate(this clsvQxFuncModule_AgcEN objvQxFuncModule_AgcEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQxFuncModule_Agc.UpdDate);
objvQxFuncModule_AgcEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(convQxFuncModule_Agc.UpdDate) == false)
{
objvQxFuncModule_AgcEN.dicFldComparisonOp.Add(convQxFuncModule_Agc.UpdDate, strComparisonOp);
}
else
{
objvQxFuncModule_AgcEN.dicFldComparisonOp[convQxFuncModule_Agc.UpdDate] = strComparisonOp;
}
}
return objvQxFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">备注</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxFuncModule_AgcEN SetMemo(this clsvQxFuncModule_AgcEN objvQxFuncModule_AgcEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxFuncModule_Agc.Memo);
objvQxFuncModule_AgcEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(convQxFuncModule_Agc.Memo) == false)
{
objvQxFuncModule_AgcEN.dicFldComparisonOp.Add(convQxFuncModule_Agc.Memo, strComparisonOp);
}
else
{
objvQxFuncModule_AgcEN.dicFldComparisonOp[convQxFuncModule_Agc.Memo] = strComparisonOp;
}
}
return objvQxFuncModule_AgcEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQxFuncModule_AgcEN objvQxFuncModule_AgcCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQxFuncModule_AgcCond.IsUpdated(convQxFuncModule_Agc.PrjName) == true)
{
string strComparisonOpPrjName = objvQxFuncModule_AgcCond.dicFldComparisonOp[convQxFuncModule_Agc.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxFuncModule_Agc.PrjName, objvQxFuncModule_AgcCond.PrjName, strComparisonOpPrjName);
}
if (objvQxFuncModule_AgcCond.IsUpdated(convQxFuncModule_Agc.UseStateName) == true)
{
string strComparisonOpUseStateName = objvQxFuncModule_AgcCond.dicFldComparisonOp[convQxFuncModule_Agc.UseStateName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxFuncModule_Agc.UseStateName, objvQxFuncModule_AgcCond.UseStateName, strComparisonOpUseStateName);
}
if (objvQxFuncModule_AgcCond.IsUpdated(convQxFuncModule_Agc.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objvQxFuncModule_AgcCond.dicFldComparisonOp[convQxFuncModule_Agc.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxFuncModule_Agc.FuncModuleAgcId, objvQxFuncModule_AgcCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objvQxFuncModule_AgcCond.IsUpdated(convQxFuncModule_Agc.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvQxFuncModule_AgcCond.dicFldComparisonOp[convQxFuncModule_Agc.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxFuncModule_Agc.FuncModuleName, objvQxFuncModule_AgcCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvQxFuncModule_AgcCond.IsUpdated(convQxFuncModule_Agc.FuncModuleEnName) == true)
{
string strComparisonOpFuncModuleEnName = objvQxFuncModule_AgcCond.dicFldComparisonOp[convQxFuncModule_Agc.FuncModuleEnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxFuncModule_Agc.FuncModuleEnName, objvQxFuncModule_AgcCond.FuncModuleEnName, strComparisonOpFuncModuleEnName);
}
if (objvQxFuncModule_AgcCond.IsUpdated(convQxFuncModule_Agc.FuncModuleNameSim) == true)
{
string strComparisonOpFuncModuleNameSim = objvQxFuncModule_AgcCond.dicFldComparisonOp[convQxFuncModule_Agc.FuncModuleNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxFuncModule_Agc.FuncModuleNameSim, objvQxFuncModule_AgcCond.FuncModuleNameSim, strComparisonOpFuncModuleNameSim);
}
if (objvQxFuncModule_AgcCond.IsUpdated(convQxFuncModule_Agc.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objvQxFuncModule_AgcCond.dicFldComparisonOp[convQxFuncModule_Agc.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxFuncModule_Agc.QxPrjId, objvQxFuncModule_AgcCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objvQxFuncModule_AgcCond.IsUpdated(convQxFuncModule_Agc.OrderNum) == true)
{
string strComparisonOpOrderNum = objvQxFuncModule_AgcCond.dicFldComparisonOp[convQxFuncModule_Agc.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQxFuncModule_Agc.OrderNum, objvQxFuncModule_AgcCond.OrderNum, strComparisonOpOrderNum);
}
if (objvQxFuncModule_AgcCond.IsUpdated(convQxFuncModule_Agc.UseStateId) == true)
{
string strComparisonOpUseStateId = objvQxFuncModule_AgcCond.dicFldComparisonOp[convQxFuncModule_Agc.UseStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxFuncModule_Agc.UseStateId, objvQxFuncModule_AgcCond.UseStateId, strComparisonOpUseStateId);
}
if (objvQxFuncModule_AgcCond.IsUpdated(convQxFuncModule_Agc.UpdUser) == true)
{
string strComparisonOpUpdUser = objvQxFuncModule_AgcCond.dicFldComparisonOp[convQxFuncModule_Agc.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxFuncModule_Agc.UpdUser, objvQxFuncModule_AgcCond.UpdUser, strComparisonOpUpdUser);
}
if (objvQxFuncModule_AgcCond.IsUpdated(convQxFuncModule_Agc.UpdDate) == true)
{
string strComparisonOpUpdDate = objvQxFuncModule_AgcCond.dicFldComparisonOp[convQxFuncModule_Agc.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxFuncModule_Agc.UpdDate, objvQxFuncModule_AgcCond.UpdDate, strComparisonOpUpdDate);
}
if (objvQxFuncModule_AgcCond.IsUpdated(convQxFuncModule_Agc.Memo) == true)
{
string strComparisonOpMemo = objvQxFuncModule_AgcCond.dicFldComparisonOp[convQxFuncModule_Agc.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxFuncModule_Agc.Memo, objvQxFuncModule_AgcCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v功能模块_Agc(vQxFuncModule_Agc)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxFuncModule_AgcWApi
{
private static readonly string mstrApiControllerName = "vQxFuncModule_AgcApi";

 public clsvQxFuncModule_AgcWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFuncModuleAgcId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxFuncModule_AgcEN GetObjByFuncModuleAgcId(string strFuncModuleAgcId)
{
string strAction = "GetObjByFuncModuleAgcId";
clsvQxFuncModule_AgcEN objvQxFuncModule_AgcEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFuncModuleAgcId"] = strFuncModuleAgcId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvQxFuncModule_AgcEN = JsonConvert.DeserializeObject<clsvQxFuncModule_AgcEN>(strJson);
return objvQxFuncModule_AgcEN;
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
public static clsvQxFuncModule_AgcEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvQxFuncModule_AgcEN objvQxFuncModule_AgcEN;
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
objvQxFuncModule_AgcEN = JsonConvert.DeserializeObject<clsvQxFuncModule_AgcEN>(strJson);
return objvQxFuncModule_AgcEN;
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
public static List<clsvQxFuncModule_AgcEN> GetObjLst(string strWhereCond)
{
 List<clsvQxFuncModule_AgcEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxFuncModule_AgcEN>>(strJson);
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
 /// <param name = "arrFuncModuleAgcId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxFuncModule_AgcEN> GetObjLstByFuncModuleAgcIdLst(List<string> arrFuncModuleAgcId)
{
 List<clsvQxFuncModule_AgcEN> arrObjLst; 
string strAction = "GetObjLstByFuncModuleAgcIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrFuncModuleAgcId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxFuncModule_AgcEN>>(strJson);
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
public static List<clsvQxFuncModule_AgcEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvQxFuncModule_AgcEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxFuncModule_AgcEN>>(strJson);
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
public static List<clsvQxFuncModule_AgcEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvQxFuncModule_AgcEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxFuncModule_AgcEN>>(strJson);
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
public static List<clsvQxFuncModule_AgcEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvQxFuncModule_AgcEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxFuncModule_AgcEN>>(strJson);
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
public static List<clsvQxFuncModule_AgcEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvQxFuncModule_AgcEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxFuncModule_AgcEN>>(strJson);
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
public static bool IsExist(string strFuncModuleAgcId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFuncModuleAgcId"] = strFuncModuleAgcId
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
 /// <param name = "objvQxFuncModule_AgcENS">源对象</param>
 /// <param name = "objvQxFuncModule_AgcENT">目标对象</param>
 public static void CopyTo(clsvQxFuncModule_AgcEN objvQxFuncModule_AgcENS, clsvQxFuncModule_AgcEN objvQxFuncModule_AgcENT)
{
try
{
objvQxFuncModule_AgcENT.PrjName = objvQxFuncModule_AgcENS.PrjName; //工程名
objvQxFuncModule_AgcENT.UseStateName = objvQxFuncModule_AgcENS.UseStateName; //使用状态名称
objvQxFuncModule_AgcENT.FuncModuleAgcId = objvQxFuncModule_AgcENS.FuncModuleAgcId; //功能模块Id
objvQxFuncModule_AgcENT.FuncModuleName = objvQxFuncModule_AgcENS.FuncModuleName; //模块名
objvQxFuncModule_AgcENT.FuncModuleEnName = objvQxFuncModule_AgcENS.FuncModuleEnName; //模块英文名
objvQxFuncModule_AgcENT.FuncModuleNameSim = objvQxFuncModule_AgcENS.FuncModuleNameSim; //模块名_Sim
objvQxFuncModule_AgcENT.QxPrjId = objvQxFuncModule_AgcENS.QxPrjId; //项目Id
objvQxFuncModule_AgcENT.OrderNum = objvQxFuncModule_AgcENS.OrderNum; //排序号
objvQxFuncModule_AgcENT.UseStateId = objvQxFuncModule_AgcENS.UseStateId; //UseStateId
objvQxFuncModule_AgcENT.UpdUser = objvQxFuncModule_AgcENS.UpdUser; //修改用户
objvQxFuncModule_AgcENT.UpdDate = objvQxFuncModule_AgcENS.UpdDate; //修改日期
objvQxFuncModule_AgcENT.Memo = objvQxFuncModule_AgcENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvQxFuncModule_AgcEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvQxFuncModule_AgcEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvQxFuncModule_AgcEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvQxFuncModule_AgcEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvQxFuncModule_AgcEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvQxFuncModule_AgcEN.AttributeName)
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
string strKey = string.Format("{0}", clsvQxFuncModule_AgcEN._CurrTabName);
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
public static DataTable GetDataTableByObjLst(List<clsvQxFuncModule_AgcEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convQxFuncModule_Agc.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convQxFuncModule_Agc.UseStateName, Type.GetType("System.String"));
objDT.Columns.Add(convQxFuncModule_Agc.FuncModuleAgcId, Type.GetType("System.String"));
objDT.Columns.Add(convQxFuncModule_Agc.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convQxFuncModule_Agc.FuncModuleEnName, Type.GetType("System.String"));
objDT.Columns.Add(convQxFuncModule_Agc.FuncModuleNameSim, Type.GetType("System.String"));
objDT.Columns.Add(convQxFuncModule_Agc.QxPrjId, Type.GetType("System.String"));
objDT.Columns.Add(convQxFuncModule_Agc.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convQxFuncModule_Agc.UseStateId, Type.GetType("System.String"));
objDT.Columns.Add(convQxFuncModule_Agc.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convQxFuncModule_Agc.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convQxFuncModule_Agc.Memo, Type.GetType("System.String"));
foreach (clsvQxFuncModule_AgcEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convQxFuncModule_Agc.PrjName] = objInFor[convQxFuncModule_Agc.PrjName];
objDR[convQxFuncModule_Agc.UseStateName] = objInFor[convQxFuncModule_Agc.UseStateName];
objDR[convQxFuncModule_Agc.FuncModuleAgcId] = objInFor[convQxFuncModule_Agc.FuncModuleAgcId];
objDR[convQxFuncModule_Agc.FuncModuleName] = objInFor[convQxFuncModule_Agc.FuncModuleName];
objDR[convQxFuncModule_Agc.FuncModuleEnName] = objInFor[convQxFuncModule_Agc.FuncModuleEnName];
objDR[convQxFuncModule_Agc.FuncModuleNameSim] = objInFor[convQxFuncModule_Agc.FuncModuleNameSim];
objDR[convQxFuncModule_Agc.QxPrjId] = objInFor[convQxFuncModule_Agc.QxPrjId];
objDR[convQxFuncModule_Agc.OrderNum] = objInFor[convQxFuncModule_Agc.OrderNum];
objDR[convQxFuncModule_Agc.UseStateId] = objInFor[convQxFuncModule_Agc.UseStateId];
objDR[convQxFuncModule_Agc.UpdUser] = objInFor[convQxFuncModule_Agc.UpdUser];
objDR[convQxFuncModule_Agc.UpdDate] = objInFor[convQxFuncModule_Agc.UpdDate];
objDR[convQxFuncModule_Agc.Memo] = objInFor[convQxFuncModule_Agc.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}