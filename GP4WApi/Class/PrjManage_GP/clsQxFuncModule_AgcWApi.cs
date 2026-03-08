
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxFuncModule_AgcWApi
 表名:QxFuncModule_Agc(00140101)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 18:24:00
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
public static class  clsQxFuncModule_AgcWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleAgcId">功能模块Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxFuncModule_AgcEN SetFuncModuleAgcId(this clsQxFuncModule_AgcEN objQxFuncModule_AgcEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, conQxFuncModule_Agc.FuncModuleAgcId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, conQxFuncModule_Agc.FuncModuleAgcId);
objQxFuncModule_AgcEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(conQxFuncModule_Agc.FuncModuleAgcId) == false)
{
objQxFuncModule_AgcEN.dicFldComparisonOp.Add(conQxFuncModule_Agc.FuncModuleAgcId, strComparisonOp);
}
else
{
objQxFuncModule_AgcEN.dicFldComparisonOp[conQxFuncModule_Agc.FuncModuleAgcId] = strComparisonOp;
}
}
return objQxFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleName">模块名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxFuncModule_AgcEN SetFuncModuleName(this clsQxFuncModule_AgcEN objQxFuncModule_AgcEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleName, conQxFuncModule_Agc.FuncModuleName);
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, conQxFuncModule_Agc.FuncModuleName);
objQxFuncModule_AgcEN.FuncModuleName = strFuncModuleName; //模块名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(conQxFuncModule_Agc.FuncModuleName) == false)
{
objQxFuncModule_AgcEN.dicFldComparisonOp.Add(conQxFuncModule_Agc.FuncModuleName, strComparisonOp);
}
else
{
objQxFuncModule_AgcEN.dicFldComparisonOp[conQxFuncModule_Agc.FuncModuleName] = strComparisonOp;
}
}
return objQxFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleEnName">模块英文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxFuncModule_AgcEN SetFuncModuleEnName(this clsQxFuncModule_AgcEN objQxFuncModule_AgcEN, string strFuncModuleEnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleEnName, 30, conQxFuncModule_Agc.FuncModuleEnName);
objQxFuncModule_AgcEN.FuncModuleEnName = strFuncModuleEnName; //模块英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(conQxFuncModule_Agc.FuncModuleEnName) == false)
{
objQxFuncModule_AgcEN.dicFldComparisonOp.Add(conQxFuncModule_Agc.FuncModuleEnName, strComparisonOp);
}
else
{
objQxFuncModule_AgcEN.dicFldComparisonOp[conQxFuncModule_Agc.FuncModuleEnName] = strComparisonOp;
}
}
return objQxFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleNameSim">模块名_Sim</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxFuncModule_AgcEN SetFuncModuleNameSim(this clsQxFuncModule_AgcEN objQxFuncModule_AgcEN, string strFuncModuleNameSim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleNameSim, 30, conQxFuncModule_Agc.FuncModuleNameSim);
objQxFuncModule_AgcEN.FuncModuleNameSim = strFuncModuleNameSim; //模块名_Sim
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(conQxFuncModule_Agc.FuncModuleNameSim) == false)
{
objQxFuncModule_AgcEN.dicFldComparisonOp.Add(conQxFuncModule_Agc.FuncModuleNameSim, strComparisonOp);
}
else
{
objQxFuncModule_AgcEN.dicFldComparisonOp[conQxFuncModule_Agc.FuncModuleNameSim] = strComparisonOp;
}
}
return objQxFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strQxPrjId">项目Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxFuncModule_AgcEN SetQxPrjId(this clsQxFuncModule_AgcEN objQxFuncModule_AgcEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, conQxFuncModule_Agc.QxPrjId);
clsCheckSql.CheckFieldLen(strQxPrjId, 4, conQxFuncModule_Agc.QxPrjId);
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, conQxFuncModule_Agc.QxPrjId);
objQxFuncModule_AgcEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(conQxFuncModule_Agc.QxPrjId) == false)
{
objQxFuncModule_AgcEN.dicFldComparisonOp.Add(conQxFuncModule_Agc.QxPrjId, strComparisonOp);
}
else
{
objQxFuncModule_AgcEN.dicFldComparisonOp[conQxFuncModule_Agc.QxPrjId] = strComparisonOp;
}
}
return objQxFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">排序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxFuncModule_AgcEN SetOrderNum(this clsQxFuncModule_AgcEN objQxFuncModule_AgcEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, conQxFuncModule_Agc.OrderNum);
objQxFuncModule_AgcEN.OrderNum = intOrderNum; //排序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(conQxFuncModule_Agc.OrderNum) == false)
{
objQxFuncModule_AgcEN.dicFldComparisonOp.Add(conQxFuncModule_Agc.OrderNum, strComparisonOp);
}
else
{
objQxFuncModule_AgcEN.dicFldComparisonOp[conQxFuncModule_Agc.OrderNum] = strComparisonOp;
}
}
return objQxFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strUseStateId">UseStateId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxFuncModule_AgcEN SetUseStateId(this clsQxFuncModule_AgcEN objQxFuncModule_AgcEN, string strUseStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUseStateId, conQxFuncModule_Agc.UseStateId);
clsCheckSql.CheckFieldLen(strUseStateId, 4, conQxFuncModule_Agc.UseStateId);
clsCheckSql.CheckFieldForeignKey(strUseStateId, 4, conQxFuncModule_Agc.UseStateId);
objQxFuncModule_AgcEN.UseStateId = strUseStateId; //UseStateId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(conQxFuncModule_Agc.UseStateId) == false)
{
objQxFuncModule_AgcEN.dicFldComparisonOp.Add(conQxFuncModule_Agc.UseStateId, strComparisonOp);
}
else
{
objQxFuncModule_AgcEN.dicFldComparisonOp[conQxFuncModule_Agc.UseStateId] = strComparisonOp;
}
}
return objQxFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改用户</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxFuncModule_AgcEN SetUpdUser(this clsQxFuncModule_AgcEN objQxFuncModule_AgcEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 18, conQxFuncModule_Agc.UpdUser);
objQxFuncModule_AgcEN.UpdUser = strUpdUser; //修改用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(conQxFuncModule_Agc.UpdUser) == false)
{
objQxFuncModule_AgcEN.dicFldComparisonOp.Add(conQxFuncModule_Agc.UpdUser, strComparisonOp);
}
else
{
objQxFuncModule_AgcEN.dicFldComparisonOp[conQxFuncModule_Agc.UpdUser] = strComparisonOp;
}
}
return objQxFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxFuncModule_AgcEN SetUpdDate(this clsQxFuncModule_AgcEN objQxFuncModule_AgcEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQxFuncModule_Agc.UpdDate);
objQxFuncModule_AgcEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(conQxFuncModule_Agc.UpdDate) == false)
{
objQxFuncModule_AgcEN.dicFldComparisonOp.Add(conQxFuncModule_Agc.UpdDate, strComparisonOp);
}
else
{
objQxFuncModule_AgcEN.dicFldComparisonOp[conQxFuncModule_Agc.UpdDate] = strComparisonOp;
}
}
return objQxFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">备注</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxFuncModule_AgcEN SetMemo(this clsQxFuncModule_AgcEN objQxFuncModule_AgcEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQxFuncModule_Agc.Memo);
objQxFuncModule_AgcEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(conQxFuncModule_Agc.Memo) == false)
{
objQxFuncModule_AgcEN.dicFldComparisonOp.Add(conQxFuncModule_Agc.Memo, strComparisonOp);
}
else
{
objQxFuncModule_AgcEN.dicFldComparisonOp[conQxFuncModule_Agc.Memo] = strComparisonOp;
}
}
return objQxFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strSynchDate">同步日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxFuncModule_AgcEN SetSynchDate(this clsQxFuncModule_AgcEN objQxFuncModule_AgcEN, string strSynchDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSynchDate, 14, conQxFuncModule_Agc.SynchDate);
objQxFuncModule_AgcEN.SynchDate = strSynchDate; //同步日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(conQxFuncModule_Agc.SynchDate) == false)
{
objQxFuncModule_AgcEN.dicFldComparisonOp.Add(conQxFuncModule_Agc.SynchDate, strComparisonOp);
}
else
{
objQxFuncModule_AgcEN.dicFldComparisonOp[conQxFuncModule_Agc.SynchDate] = strComparisonOp;
}
}
return objQxFuncModule_AgcEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQxFuncModule_AgcEN objQxFuncModule_AgcCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQxFuncModule_AgcCond.IsUpdated(conQxFuncModule_Agc.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objQxFuncModule_AgcCond.dicFldComparisonOp[conQxFuncModule_Agc.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxFuncModule_Agc.FuncModuleAgcId, objQxFuncModule_AgcCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objQxFuncModule_AgcCond.IsUpdated(conQxFuncModule_Agc.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objQxFuncModule_AgcCond.dicFldComparisonOp[conQxFuncModule_Agc.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxFuncModule_Agc.FuncModuleName, objQxFuncModule_AgcCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objQxFuncModule_AgcCond.IsUpdated(conQxFuncModule_Agc.FuncModuleEnName) == true)
{
string strComparisonOpFuncModuleEnName = objQxFuncModule_AgcCond.dicFldComparisonOp[conQxFuncModule_Agc.FuncModuleEnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxFuncModule_Agc.FuncModuleEnName, objQxFuncModule_AgcCond.FuncModuleEnName, strComparisonOpFuncModuleEnName);
}
if (objQxFuncModule_AgcCond.IsUpdated(conQxFuncModule_Agc.FuncModuleNameSim) == true)
{
string strComparisonOpFuncModuleNameSim = objQxFuncModule_AgcCond.dicFldComparisonOp[conQxFuncModule_Agc.FuncModuleNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxFuncModule_Agc.FuncModuleNameSim, objQxFuncModule_AgcCond.FuncModuleNameSim, strComparisonOpFuncModuleNameSim);
}
if (objQxFuncModule_AgcCond.IsUpdated(conQxFuncModule_Agc.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objQxFuncModule_AgcCond.dicFldComparisonOp[conQxFuncModule_Agc.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxFuncModule_Agc.QxPrjId, objQxFuncModule_AgcCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objQxFuncModule_AgcCond.IsUpdated(conQxFuncModule_Agc.OrderNum) == true)
{
string strComparisonOpOrderNum = objQxFuncModule_AgcCond.dicFldComparisonOp[conQxFuncModule_Agc.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conQxFuncModule_Agc.OrderNum, objQxFuncModule_AgcCond.OrderNum, strComparisonOpOrderNum);
}
if (objQxFuncModule_AgcCond.IsUpdated(conQxFuncModule_Agc.UseStateId) == true)
{
string strComparisonOpUseStateId = objQxFuncModule_AgcCond.dicFldComparisonOp[conQxFuncModule_Agc.UseStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxFuncModule_Agc.UseStateId, objQxFuncModule_AgcCond.UseStateId, strComparisonOpUseStateId);
}
if (objQxFuncModule_AgcCond.IsUpdated(conQxFuncModule_Agc.UpdUser) == true)
{
string strComparisonOpUpdUser = objQxFuncModule_AgcCond.dicFldComparisonOp[conQxFuncModule_Agc.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxFuncModule_Agc.UpdUser, objQxFuncModule_AgcCond.UpdUser, strComparisonOpUpdUser);
}
if (objQxFuncModule_AgcCond.IsUpdated(conQxFuncModule_Agc.UpdDate) == true)
{
string strComparisonOpUpdDate = objQxFuncModule_AgcCond.dicFldComparisonOp[conQxFuncModule_Agc.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxFuncModule_Agc.UpdDate, objQxFuncModule_AgcCond.UpdDate, strComparisonOpUpdDate);
}
if (objQxFuncModule_AgcCond.IsUpdated(conQxFuncModule_Agc.Memo) == true)
{
string strComparisonOpMemo = objQxFuncModule_AgcCond.dicFldComparisonOp[conQxFuncModule_Agc.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxFuncModule_Agc.Memo, objQxFuncModule_AgcCond.Memo, strComparisonOpMemo);
}
if (objQxFuncModule_AgcCond.IsUpdated(conQxFuncModule_Agc.SynchDate) == true)
{
string strComparisonOpSynchDate = objQxFuncModule_AgcCond.dicFldComparisonOp[conQxFuncModule_Agc.SynchDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxFuncModule_Agc.SynchDate, objQxFuncModule_AgcCond.SynchDate, strComparisonOpSynchDate);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objQxFuncModule_AgcEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxFuncModule_AgcEN objQxFuncModule_AgcEN)
{
 if (string.IsNullOrEmpty(objQxFuncModule_AgcEN.FuncModuleAgcId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objQxFuncModule_AgcEN.sfUpdFldSetStr = objQxFuncModule_AgcEN.getsfUpdFldSetStr();
clsQxFuncModule_AgcWApi.CheckPropertyNew(objQxFuncModule_AgcEN); 
bool bolResult = clsQxFuncModule_AgcWApi.UpdateRecord(objQxFuncModule_AgcEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000004)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQxFuncModule_AgcEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQxFuncModule_AgcEN objQxFuncModule_AgcEN)
{
 if (string.IsNullOrEmpty(objQxFuncModule_AgcEN.FuncModuleAgcId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQxFuncModule_AgcWApi.IsExist(objQxFuncModule_AgcEN.FuncModuleAgcId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQxFuncModule_AgcEN.FuncModuleAgcId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsQxFuncModule_AgcWApi.CheckPropertyNew(objQxFuncModule_AgcEN); 
bool bolResult = clsQxFuncModule_AgcWApi.AddNewRecord(objQxFuncModule_AgcEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxFuncModule_AgcWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000008)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值. 该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objQxFuncModule_AgcEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsQxFuncModule_AgcEN objQxFuncModule_AgcEN)
{
try
{
clsQxFuncModule_AgcWApi.CheckPropertyNew(objQxFuncModule_AgcEN); 
string strFuncModuleAgcId = clsQxFuncModule_AgcWApi.AddNewRecordWithMaxId(objQxFuncModule_AgcEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxFuncModule_AgcWApi.ReFreshCache();
return strFuncModuleAgcId;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000009)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objQxFuncModule_AgcEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxFuncModule_AgcEN objQxFuncModule_AgcEN, string strWhereCond)
{
try
{
clsQxFuncModule_AgcWApi.CheckPropertyNew(objQxFuncModule_AgcEN); 
bool bolResult = clsQxFuncModule_AgcWApi.UpdateWithCondition(objQxFuncModule_AgcEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxFuncModule_AgcWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000007)根据条件修改记录出错, {1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// 功能模块_Agc(QxFuncModule_Agc)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsQxFuncModule_AgcWApi
{
private static readonly string mstrApiControllerName = "QxFuncModule_AgcApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsQxFuncModule_AgcWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_FuncModuleAgcId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[功能模块_Agc]...","0");
List<clsQxFuncModule_AgcEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="FuncModuleAgcId";
objDDL.DataTextField="FuncModuleName";
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

public static void BindCbo_FuncModuleAgcId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conQxFuncModule_Agc.FuncModuleAgcId); 
List<clsQxFuncModule_AgcEN> arrObjLst = clsQxFuncModule_AgcWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsQxFuncModule_AgcEN objQxFuncModule_AgcEN = new clsQxFuncModule_AgcEN()
{
FuncModuleAgcId = "0",
FuncModuleName = "选[功能模块_Agc]..."
};
arrObjLst.Insert(0, objQxFuncModule_AgcEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conQxFuncModule_Agc.FuncModuleAgcId;
objComboBox.DisplayMember = conQxFuncModule_Agc.FuncModuleName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsQxFuncModule_AgcEN objQxFuncModule_AgcEN)
{
if (!Object.Equals(null, objQxFuncModule_AgcEN.FuncModuleAgcId) && GetStrLen(objQxFuncModule_AgcEN.FuncModuleAgcId) > 8)
{
 throw new Exception("字段[功能模块Id]的长度不能超过8!");
}
if (!Object.Equals(null, objQxFuncModule_AgcEN.FuncModuleName) && GetStrLen(objQxFuncModule_AgcEN.FuncModuleName) > 30)
{
 throw new Exception("字段[模块名]的长度不能超过30!");
}
if (!Object.Equals(null, objQxFuncModule_AgcEN.FuncModuleEnName) && GetStrLen(objQxFuncModule_AgcEN.FuncModuleEnName) > 30)
{
 throw new Exception("字段[模块英文名]的长度不能超过30!");
}
if (!Object.Equals(null, objQxFuncModule_AgcEN.FuncModuleNameSim) && GetStrLen(objQxFuncModule_AgcEN.FuncModuleNameSim) > 30)
{
 throw new Exception("字段[模块名_Sim]的长度不能超过30!");
}
if (!Object.Equals(null, objQxFuncModule_AgcEN.QxPrjId) && GetStrLen(objQxFuncModule_AgcEN.QxPrjId) > 4)
{
 throw new Exception("字段[项目Id]的长度不能超过4!");
}
if (!Object.Equals(null, objQxFuncModule_AgcEN.UseStateId) && GetStrLen(objQxFuncModule_AgcEN.UseStateId) > 4)
{
 throw new Exception("字段[UseStateId]的长度不能超过4!");
}
if (!Object.Equals(null, objQxFuncModule_AgcEN.UpdUser) && GetStrLen(objQxFuncModule_AgcEN.UpdUser) > 18)
{
 throw new Exception("字段[修改用户]的长度不能超过18!");
}
if (!Object.Equals(null, objQxFuncModule_AgcEN.UpdDate) && GetStrLen(objQxFuncModule_AgcEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objQxFuncModule_AgcEN.Memo) && GetStrLen(objQxFuncModule_AgcEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
if (!Object.Equals(null, objQxFuncModule_AgcEN.SynchDate) && GetStrLen(objQxFuncModule_AgcEN.SynchDate) > 14)
{
 throw new Exception("字段[同步日期]的长度不能超过14!");
}
 objQxFuncModule_AgcEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFuncModuleAgcId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxFuncModule_AgcEN GetObjByFuncModuleAgcId(string strFuncModuleAgcId)
{
string strAction = "GetObjByFuncModuleAgcId";
clsQxFuncModule_AgcEN objQxFuncModule_AgcEN;
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
objQxFuncModule_AgcEN = JsonConvert.DeserializeObject<clsQxFuncModule_AgcEN>(strJson);
return objQxFuncModule_AgcEN;
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
public static clsQxFuncModule_AgcEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsQxFuncModule_AgcEN objQxFuncModule_AgcEN;
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
objQxFuncModule_AgcEN = JsonConvert.DeserializeObject<clsQxFuncModule_AgcEN>(strJson);
return objQxFuncModule_AgcEN;
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
//该表没有使用Cache,不需要生成[GetFuncModuleNameByFuncModuleAgcIdCache]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxFuncModule_AgcEN> GetObjLst(string strWhereCond)
{
 List<clsQxFuncModule_AgcEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxFuncModule_AgcEN>>(strJson);
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
public static List<clsQxFuncModule_AgcEN> GetObjLstByFuncModuleAgcIdLst(List<string> arrFuncModuleAgcId)
{
 List<clsQxFuncModule_AgcEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxFuncModule_AgcEN>>(strJson);
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
public static List<clsQxFuncModule_AgcEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsQxFuncModule_AgcEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxFuncModule_AgcEN>>(strJson);
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
public static List<clsQxFuncModule_AgcEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsQxFuncModule_AgcEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxFuncModule_AgcEN>>(strJson);
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
public static List<clsQxFuncModule_AgcEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsQxFuncModule_AgcEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxFuncModule_AgcEN>>(strJson);
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
public static List<clsQxFuncModule_AgcEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsQxFuncModule_AgcEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxFuncModule_AgcEN>>(strJson);
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
 /// 根据关键字删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecord(string strFuncModuleAgcId)
{
string strAction = "DelRecord";
try
{
 clsQxFuncModule_AgcEN objQxFuncModule_AgcEN = clsQxFuncModule_AgcWApi.GetObjByFuncModuleAgcId(strFuncModuleAgcId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strFuncModuleAgcId.ToString(), out string strResult, out string strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecords)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecords(string strKeyIdLst)
{
string strAction = "DelRecords";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strKeyIdLst, out string strResult, out string strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelQxFuncModule_Agcs(List<string> arrFuncModuleAgcId)
{
string strAction = "DelQxFuncModule_Agcs";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrFuncModuleAgcId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelQxFuncModule_AgcsByCond(string strWhereCond)
{
string strAction = "DelQxFuncModule_AgcsByCond";
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool AddNewRecord(clsQxFuncModule_AgcEN objQxFuncModule_AgcEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxFuncModule_AgcEN>(objQxFuncModule_AgcEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithMaxId)
 /// </summary>
 /// <returns>新建记录的关键字</returns>
public static string AddNewRecordWithMaxId(clsQxFuncModule_AgcEN objQxFuncModule_AgcEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxFuncModule_AgcEN>(objQxFuncModule_AgcEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
var strFuncModuleAgcId = (string)jobjReturn0["returnStr"];
return strFuncModuleAgcId;
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsQxFuncModule_AgcEN objQxFuncModule_AgcEN)
{
if (string.IsNullOrEmpty(objQxFuncModule_AgcEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objQxFuncModule_AgcEN.FuncModuleAgcId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxFuncModule_AgcEN>(objQxFuncModule_AgcEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateWithCondition)
 /// </summary>
 /// <param name = "objQxFuncModule_AgcEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsQxFuncModule_AgcEN objQxFuncModule_AgcEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objQxFuncModule_AgcEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objQxFuncModule_AgcEN.FuncModuleAgcId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objQxFuncModule_AgcEN.FuncModuleAgcId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxFuncModule_AgcEN>(objQxFuncModule_AgcEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
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
 /// 根据条件设置字段值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_funSetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int SetFldValue(string strFldName, string strValue, string strWhereCond)
{
string strAction = "SetFldValue";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strValue"] = strValue,
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
string strMsg = string.Format("根据条件设置字段值,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId()
{
string strAction = "GetMaxStrId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
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
string strMsg = string.Format("获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefix(string strPrefix)
{
//检测记录是否存在
string strAction = "GetMaxStrIdByPrefix";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
{"strPrefix", strPrefix}
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
string strMsg = string.Format("根据前缀获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取字符串长度,其中汉字为2个字节,英文为1个字节
 /// (AutoGCLib.clsGeneCodeBase:GengetStrLen)
 /// </summary>
 /// <param name = "strTemp">给定的原字符串</param>
 /// <returns>返回字符串长度</returns>
public static int GetStrLen(string strTemp)
{
int len ;
byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
len = sarr.Length;//will output as 3+3*2 = 9
return len;
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objQxFuncModule_AgcENS">源对象</param>
 /// <param name = "objQxFuncModule_AgcENT">目标对象</param>
 public static void CopyTo(clsQxFuncModule_AgcEN objQxFuncModule_AgcENS, clsQxFuncModule_AgcEN objQxFuncModule_AgcENT)
{
try
{
objQxFuncModule_AgcENT.FuncModuleAgcId = objQxFuncModule_AgcENS.FuncModuleAgcId; //功能模块Id
objQxFuncModule_AgcENT.FuncModuleName = objQxFuncModule_AgcENS.FuncModuleName; //模块名
objQxFuncModule_AgcENT.FuncModuleEnName = objQxFuncModule_AgcENS.FuncModuleEnName; //模块英文名
objQxFuncModule_AgcENT.FuncModuleNameSim = objQxFuncModule_AgcENS.FuncModuleNameSim; //模块名_Sim
objQxFuncModule_AgcENT.QxPrjId = objQxFuncModule_AgcENS.QxPrjId; //项目Id
objQxFuncModule_AgcENT.OrderNum = objQxFuncModule_AgcENS.OrderNum; //排序号
objQxFuncModule_AgcENT.UseStateId = objQxFuncModule_AgcENS.UseStateId; //UseStateId
objQxFuncModule_AgcENT.UpdUser = objQxFuncModule_AgcENS.UpdUser; //修改用户
objQxFuncModule_AgcENT.UpdDate = objQxFuncModule_AgcENS.UpdDate; //修改日期
objQxFuncModule_AgcENT.Memo = objQxFuncModule_AgcENS.Memo; //备注
objQxFuncModule_AgcENT.SynchDate = objQxFuncModule_AgcENS.SynchDate; //同步日期
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
public static DataTable ToDataTable(List<clsQxFuncModule_AgcEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsQxFuncModule_AgcEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsQxFuncModule_AgcEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsQxFuncModule_AgcEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsQxFuncModule_AgcEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsQxFuncModule_AgcEN.AttributeName)
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
string strKey = string.Format("{0}", clsQxFuncModule_AgcEN._CurrTabName);
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

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsQxFuncModule_AgcWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsQxFuncModule_AgcEN._CurrTabName);
CacheHelper.Remove(strKey);
clsQxFuncModule_AgcWApi.objCommFun4WApi.ReFreshCache();
}
}
//该表没有使用Cache,不需要生成[GetObjLstCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsQxFuncModule_AgcEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conQxFuncModule_Agc.FuncModuleAgcId, Type.GetType("System.String"));
objDT.Columns.Add(conQxFuncModule_Agc.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(conQxFuncModule_Agc.FuncModuleEnName, Type.GetType("System.String"));
objDT.Columns.Add(conQxFuncModule_Agc.FuncModuleNameSim, Type.GetType("System.String"));
objDT.Columns.Add(conQxFuncModule_Agc.QxPrjId, Type.GetType("System.String"));
objDT.Columns.Add(conQxFuncModule_Agc.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conQxFuncModule_Agc.UseStateId, Type.GetType("System.String"));
objDT.Columns.Add(conQxFuncModule_Agc.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conQxFuncModule_Agc.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conQxFuncModule_Agc.Memo, Type.GetType("System.String"));
objDT.Columns.Add(conQxFuncModule_Agc.SynchDate, Type.GetType("System.String"));
foreach (clsQxFuncModule_AgcEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conQxFuncModule_Agc.FuncModuleAgcId] = objInFor[conQxFuncModule_Agc.FuncModuleAgcId];
objDR[conQxFuncModule_Agc.FuncModuleName] = objInFor[conQxFuncModule_Agc.FuncModuleName];
objDR[conQxFuncModule_Agc.FuncModuleEnName] = objInFor[conQxFuncModule_Agc.FuncModuleEnName];
objDR[conQxFuncModule_Agc.FuncModuleNameSim] = objInFor[conQxFuncModule_Agc.FuncModuleNameSim];
objDR[conQxFuncModule_Agc.QxPrjId] = objInFor[conQxFuncModule_Agc.QxPrjId];
objDR[conQxFuncModule_Agc.OrderNum] = objInFor[conQxFuncModule_Agc.OrderNum];
objDR[conQxFuncModule_Agc.UseStateId] = objInFor[conQxFuncModule_Agc.UseStateId];
objDR[conQxFuncModule_Agc.UpdUser] = objInFor[conQxFuncModule_Agc.UpdUser];
objDR[conQxFuncModule_Agc.UpdDate] = objInFor[conQxFuncModule_Agc.UpdDate];
objDR[conQxFuncModule_Agc.Memo] = objInFor[conQxFuncModule_Agc.Memo];
objDR[conQxFuncModule_Agc.SynchDate] = objInFor[conQxFuncModule_Agc.SynchDate];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 功能模块_Agc(QxFuncModule_Agc)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4QxFuncModule_Agc : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache()
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == false)
{
strMsg = string.Format("刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3));
clsSysParaEN.objLog.WriteDebugLog(strMsg);
return;
}
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxFuncModule_AgcWApi.ReFreshThisCache();
}
}

}