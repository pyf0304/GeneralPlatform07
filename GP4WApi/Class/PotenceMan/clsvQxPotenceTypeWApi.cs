
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPotenceTypeWApi
 表名:vQxPotenceType(00140026)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 18:36:49
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:权限管理(PotenceMan)
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
public static class  clsvQxPotenceTypeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPotenceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strPotenceTypeId">权限类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPotenceTypeEN SetPotenceTypeId(this clsvQxPotenceTypeEN objvQxPotenceTypeEN, string strPotenceTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPotenceTypeId, 6, convQxPotenceType.PotenceTypeId);
clsCheckSql.CheckFieldForeignKey(strPotenceTypeId, 6, convQxPotenceType.PotenceTypeId);
objvQxPotenceTypeEN.PotenceTypeId = strPotenceTypeId; //权限类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPotenceTypeEN.dicFldComparisonOp.ContainsKey(convQxPotenceType.PotenceTypeId) == false)
{
objvQxPotenceTypeEN.dicFldComparisonOp.Add(convQxPotenceType.PotenceTypeId, strComparisonOp);
}
else
{
objvQxPotenceTypeEN.dicFldComparisonOp[convQxPotenceType.PotenceTypeId] = strComparisonOp;
}
}
return objvQxPotenceTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPotenceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strPotenceTypeName">权限类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPotenceTypeEN SetPotenceTypeName(this clsvQxPotenceTypeEN objvQxPotenceTypeEN, string strPotenceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPotenceTypeName, convQxPotenceType.PotenceTypeName);
clsCheckSql.CheckFieldLen(strPotenceTypeName, 50, convQxPotenceType.PotenceTypeName);
objvQxPotenceTypeEN.PotenceTypeName = strPotenceTypeName; //权限类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPotenceTypeEN.dicFldComparisonOp.ContainsKey(convQxPotenceType.PotenceTypeName) == false)
{
objvQxPotenceTypeEN.dicFldComparisonOp.Add(convQxPotenceType.PotenceTypeName, strComparisonOp);
}
else
{
objvQxPotenceTypeEN.dicFldComparisonOp[convQxPotenceType.PotenceTypeName] = strComparisonOp;
}
}
return objvQxPotenceTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPotenceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strQxPrjId">项目Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPotenceTypeEN SetQxPrjId(this clsvQxPotenceTypeEN objvQxPotenceTypeEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, convQxPotenceType.QxPrjId);
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxPotenceType.QxPrjId);
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxPotenceType.QxPrjId);
objvQxPotenceTypeEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPotenceTypeEN.dicFldComparisonOp.ContainsKey(convQxPotenceType.QxPrjId) == false)
{
objvQxPotenceTypeEN.dicFldComparisonOp.Add(convQxPotenceType.QxPrjId, strComparisonOp);
}
else
{
objvQxPotenceTypeEN.dicFldComparisonOp[convQxPotenceType.QxPrjId] = strComparisonOp;
}
}
return objvQxPotenceTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPotenceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPotenceTypeEN SetPrjName(this clsvQxPotenceTypeEN objvQxPotenceTypeEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convQxPotenceType.PrjName);
clsCheckSql.CheckFieldLen(strPrjName, 30, convQxPotenceType.PrjName);
objvQxPotenceTypeEN.PrjName = strPrjName; //工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPotenceTypeEN.dicFldComparisonOp.ContainsKey(convQxPotenceType.PrjName) == false)
{
objvQxPotenceTypeEN.dicFldComparisonOp.Add(convQxPotenceType.PrjName, strComparisonOp);
}
else
{
objvQxPotenceTypeEN.dicFldComparisonOp[convQxPotenceType.PrjName] = strComparisonOp;
}
}
return objvQxPotenceTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPotenceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleId">模块Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPotenceTypeEN SetFuncModuleId(this clsvQxPotenceTypeEN objvQxPotenceTypeEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convQxPotenceType.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convQxPotenceType.FuncModuleId);
objvQxPotenceTypeEN.FuncModuleId = strFuncModuleId; //模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPotenceTypeEN.dicFldComparisonOp.ContainsKey(convQxPotenceType.FuncModuleId) == false)
{
objvQxPotenceTypeEN.dicFldComparisonOp.Add(convQxPotenceType.FuncModuleId, strComparisonOp);
}
else
{
objvQxPotenceTypeEN.dicFldComparisonOp[convQxPotenceType.FuncModuleId] = strComparisonOp;
}
}
return objvQxPotenceTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPotenceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleName">模块名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPotenceTypeEN SetFuncModuleName(this clsvQxPotenceTypeEN objvQxPotenceTypeEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convQxPotenceType.FuncModuleName);
objvQxPotenceTypeEN.FuncModuleName = strFuncModuleName; //模块名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPotenceTypeEN.dicFldComparisonOp.ContainsKey(convQxPotenceType.FuncModuleName) == false)
{
objvQxPotenceTypeEN.dicFldComparisonOp.Add(convQxPotenceType.FuncModuleName, strComparisonOp);
}
else
{
objvQxPotenceTypeEN.dicFldComparisonOp[convQxPotenceType.FuncModuleName] = strComparisonOp;
}
}
return objvQxPotenceTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPotenceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleNameSim">模块名_Sim</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPotenceTypeEN SetFuncModuleNameSim(this clsvQxPotenceTypeEN objvQxPotenceTypeEN, string strFuncModuleNameSim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleNameSim, 30, convQxPotenceType.FuncModuleNameSim);
objvQxPotenceTypeEN.FuncModuleNameSim = strFuncModuleNameSim; //模块名_Sim
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPotenceTypeEN.dicFldComparisonOp.ContainsKey(convQxPotenceType.FuncModuleNameSim) == false)
{
objvQxPotenceTypeEN.dicFldComparisonOp.Add(convQxPotenceType.FuncModuleNameSim, strComparisonOp);
}
else
{
objvQxPotenceTypeEN.dicFldComparisonOp[convQxPotenceType.FuncModuleNameSim] = strComparisonOp;
}
}
return objvQxPotenceTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPotenceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">排序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPotenceTypeEN SetOrderNum(this clsvQxPotenceTypeEN objvQxPotenceTypeEN, int intOrderNum, string strComparisonOp="")
	{
objvQxPotenceTypeEN.OrderNum = intOrderNum; //排序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPotenceTypeEN.dicFldComparisonOp.ContainsKey(convQxPotenceType.OrderNum) == false)
{
objvQxPotenceTypeEN.dicFldComparisonOp.Add(convQxPotenceType.OrderNum, strComparisonOp);
}
else
{
objvQxPotenceTypeEN.dicFldComparisonOp[convQxPotenceType.OrderNum] = strComparisonOp;
}
}
return objvQxPotenceTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPotenceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPotenceTypeEN SetInUse(this clsvQxPotenceTypeEN objvQxPotenceTypeEN, bool bolInUse, string strComparisonOp="")
	{
objvQxPotenceTypeEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPotenceTypeEN.dicFldComparisonOp.ContainsKey(convQxPotenceType.InUse) == false)
{
objvQxPotenceTypeEN.dicFldComparisonOp.Add(convQxPotenceType.InUse, strComparisonOp);
}
else
{
objvQxPotenceTypeEN.dicFldComparisonOp[convQxPotenceType.InUse] = strComparisonOp;
}
}
return objvQxPotenceTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPotenceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewId">界面编号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPotenceTypeEN SetViewId(this clsvQxPotenceTypeEN objvQxPotenceTypeEN, string strViewId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewId, 8, convQxPotenceType.ViewId);
clsCheckSql.CheckFieldForeignKey(strViewId, 8, convQxPotenceType.ViewId);
objvQxPotenceTypeEN.ViewId = strViewId; //界面编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPotenceTypeEN.dicFldComparisonOp.ContainsKey(convQxPotenceType.ViewId) == false)
{
objvQxPotenceTypeEN.dicFldComparisonOp.Add(convQxPotenceType.ViewId, strComparisonOp);
}
else
{
objvQxPotenceTypeEN.dicFldComparisonOp[convQxPotenceType.ViewId] = strComparisonOp;
}
}
return objvQxPotenceTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPotenceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewName">界面名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPotenceTypeEN SetViewName(this clsvQxPotenceTypeEN objvQxPotenceTypeEN, string strViewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewName, 100, convQxPotenceType.ViewName);
objvQxPotenceTypeEN.ViewName = strViewName; //界面名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPotenceTypeEN.dicFldComparisonOp.ContainsKey(convQxPotenceType.ViewName) == false)
{
objvQxPotenceTypeEN.dicFldComparisonOp.Add(convQxPotenceType.ViewName, strComparisonOp);
}
else
{
objvQxPotenceTypeEN.dicFldComparisonOp[convQxPotenceType.ViewName] = strComparisonOp;
}
}
return objvQxPotenceTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPotenceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsVisible">是否显示</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPotenceTypeEN SetIsVisible(this clsvQxPotenceTypeEN objvQxPotenceTypeEN, bool bolIsVisible, string strComparisonOp="")
	{
objvQxPotenceTypeEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPotenceTypeEN.dicFldComparisonOp.ContainsKey(convQxPotenceType.IsVisible) == false)
{
objvQxPotenceTypeEN.dicFldComparisonOp.Add(convQxPotenceType.IsVisible, strComparisonOp);
}
else
{
objvQxPotenceTypeEN.dicFldComparisonOp[convQxPotenceType.IsVisible] = strComparisonOp;
}
}
return objvQxPotenceTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPotenceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPotenceTypeEN SetUpdDate(this clsvQxPotenceTypeEN objvQxPotenceTypeEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convQxPotenceType.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQxPotenceType.UpdDate);
objvQxPotenceTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPotenceTypeEN.dicFldComparisonOp.ContainsKey(convQxPotenceType.UpdDate) == false)
{
objvQxPotenceTypeEN.dicFldComparisonOp.Add(convQxPotenceType.UpdDate, strComparisonOp);
}
else
{
objvQxPotenceTypeEN.dicFldComparisonOp[convQxPotenceType.UpdDate] = strComparisonOp;
}
}
return objvQxPotenceTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPotenceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPotenceTypeEN SetUpdUserId(this clsvQxPotenceTypeEN objvQxPotenceTypeEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUserId, convQxPotenceType.UpdUserId);
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convQxPotenceType.UpdUserId);
objvQxPotenceTypeEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPotenceTypeEN.dicFldComparisonOp.ContainsKey(convQxPotenceType.UpdUserId) == false)
{
objvQxPotenceTypeEN.dicFldComparisonOp.Add(convQxPotenceType.UpdUserId, strComparisonOp);
}
else
{
objvQxPotenceTypeEN.dicFldComparisonOp[convQxPotenceType.UpdUserId] = strComparisonOp;
}
}
return objvQxPotenceTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPotenceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">备注</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPotenceTypeEN SetMemo(this clsvQxPotenceTypeEN objvQxPotenceTypeEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxPotenceType.Memo);
objvQxPotenceTypeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPotenceTypeEN.dicFldComparisonOp.ContainsKey(convQxPotenceType.Memo) == false)
{
objvQxPotenceTypeEN.dicFldComparisonOp.Add(convQxPotenceType.Memo, strComparisonOp);
}
else
{
objvQxPotenceTypeEN.dicFldComparisonOp[convQxPotenceType.Memo] = strComparisonOp;
}
}
return objvQxPotenceTypeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQxPotenceTypeEN objvQxPotenceTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQxPotenceTypeCond.IsUpdated(convQxPotenceType.PotenceTypeId) == true)
{
string strComparisonOpPotenceTypeId = objvQxPotenceTypeCond.dicFldComparisonOp[convQxPotenceType.PotenceTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPotenceType.PotenceTypeId, objvQxPotenceTypeCond.PotenceTypeId, strComparisonOpPotenceTypeId);
}
if (objvQxPotenceTypeCond.IsUpdated(convQxPotenceType.PotenceTypeName) == true)
{
string strComparisonOpPotenceTypeName = objvQxPotenceTypeCond.dicFldComparisonOp[convQxPotenceType.PotenceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPotenceType.PotenceTypeName, objvQxPotenceTypeCond.PotenceTypeName, strComparisonOpPotenceTypeName);
}
if (objvQxPotenceTypeCond.IsUpdated(convQxPotenceType.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objvQxPotenceTypeCond.dicFldComparisonOp[convQxPotenceType.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPotenceType.QxPrjId, objvQxPotenceTypeCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objvQxPotenceTypeCond.IsUpdated(convQxPotenceType.PrjName) == true)
{
string strComparisonOpPrjName = objvQxPotenceTypeCond.dicFldComparisonOp[convQxPotenceType.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPotenceType.PrjName, objvQxPotenceTypeCond.PrjName, strComparisonOpPrjName);
}
if (objvQxPotenceTypeCond.IsUpdated(convQxPotenceType.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objvQxPotenceTypeCond.dicFldComparisonOp[convQxPotenceType.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPotenceType.FuncModuleId, objvQxPotenceTypeCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objvQxPotenceTypeCond.IsUpdated(convQxPotenceType.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvQxPotenceTypeCond.dicFldComparisonOp[convQxPotenceType.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPotenceType.FuncModuleName, objvQxPotenceTypeCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvQxPotenceTypeCond.IsUpdated(convQxPotenceType.FuncModuleNameSim) == true)
{
string strComparisonOpFuncModuleNameSim = objvQxPotenceTypeCond.dicFldComparisonOp[convQxPotenceType.FuncModuleNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPotenceType.FuncModuleNameSim, objvQxPotenceTypeCond.FuncModuleNameSim, strComparisonOpFuncModuleNameSim);
}
if (objvQxPotenceTypeCond.IsUpdated(convQxPotenceType.OrderNum) == true)
{
string strComparisonOpOrderNum = objvQxPotenceTypeCond.dicFldComparisonOp[convQxPotenceType.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQxPotenceType.OrderNum, objvQxPotenceTypeCond.OrderNum, strComparisonOpOrderNum);
}
if (objvQxPotenceTypeCond.IsUpdated(convQxPotenceType.InUse) == true)
{
if (objvQxPotenceTypeCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQxPotenceType.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQxPotenceType.InUse);
}
}
if (objvQxPotenceTypeCond.IsUpdated(convQxPotenceType.ViewId) == true)
{
string strComparisonOpViewId = objvQxPotenceTypeCond.dicFldComparisonOp[convQxPotenceType.ViewId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPotenceType.ViewId, objvQxPotenceTypeCond.ViewId, strComparisonOpViewId);
}
if (objvQxPotenceTypeCond.IsUpdated(convQxPotenceType.ViewName) == true)
{
string strComparisonOpViewName = objvQxPotenceTypeCond.dicFldComparisonOp[convQxPotenceType.ViewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPotenceType.ViewName, objvQxPotenceTypeCond.ViewName, strComparisonOpViewName);
}
if (objvQxPotenceTypeCond.IsUpdated(convQxPotenceType.IsVisible) == true)
{
if (objvQxPotenceTypeCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQxPotenceType.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQxPotenceType.IsVisible);
}
}
if (objvQxPotenceTypeCond.IsUpdated(convQxPotenceType.UpdDate) == true)
{
string strComparisonOpUpdDate = objvQxPotenceTypeCond.dicFldComparisonOp[convQxPotenceType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPotenceType.UpdDate, objvQxPotenceTypeCond.UpdDate, strComparisonOpUpdDate);
}
if (objvQxPotenceTypeCond.IsUpdated(convQxPotenceType.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvQxPotenceTypeCond.dicFldComparisonOp[convQxPotenceType.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPotenceType.UpdUserId, objvQxPotenceTypeCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvQxPotenceTypeCond.IsUpdated(convQxPotenceType.Memo) == true)
{
string strComparisonOpMemo = objvQxPotenceTypeCond.dicFldComparisonOp[convQxPotenceType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPotenceType.Memo, objvQxPotenceTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v权限类型(vQxPotenceType)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxPotenceTypeWApi
{
private static readonly string mstrApiControllerName = "vQxPotenceTypeApi";

 public clsvQxPotenceTypeWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_PotenceTypeId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v权限类型]...","0");
List<clsvQxPotenceTypeEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="PotenceTypeId";
objDDL.DataTextField="PotenceTypeName";
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

public static void BindCbo_PotenceTypeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convQxPotenceType.PotenceTypeId); 
List<clsvQxPotenceTypeEN> arrObjLst = clsvQxPotenceTypeWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvQxPotenceTypeEN objvQxPotenceTypeEN = new clsvQxPotenceTypeEN()
{
PotenceTypeId = "0",
PotenceTypeName = "选[v权限类型]..."
};
arrObjLst.Insert(0, objvQxPotenceTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convQxPotenceType.PotenceTypeId;
objComboBox.DisplayMember = convQxPotenceType.PotenceTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strPotenceTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxPotenceTypeEN GetObjByPotenceTypeId(string strPotenceTypeId)
{
string strAction = "GetObjByPotenceTypeId";
clsvQxPotenceTypeEN objvQxPotenceTypeEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strPotenceTypeId"] = strPotenceTypeId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvQxPotenceTypeEN = JsonConvert.DeserializeObject<clsvQxPotenceTypeEN>(strJson);
return objvQxPotenceTypeEN;
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
public static clsvQxPotenceTypeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvQxPotenceTypeEN objvQxPotenceTypeEN;
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
objvQxPotenceTypeEN = JsonConvert.DeserializeObject<clsvQxPotenceTypeEN>(strJson);
return objvQxPotenceTypeEN;
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
//该表没有使用Cache,不需要生成[GetPotenceTypeNameByPotenceTypeIdCache]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPotenceTypeEN> GetObjLst(string strWhereCond)
{
 List<clsvQxPotenceTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPotenceTypeEN>>(strJson);
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
 /// <param name = "arrPotenceTypeId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPotenceTypeEN> GetObjLstByPotenceTypeIdLst(List<string> arrPotenceTypeId)
{
 List<clsvQxPotenceTypeEN> arrObjLst; 
string strAction = "GetObjLstByPotenceTypeIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPotenceTypeId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPotenceTypeEN>>(strJson);
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
public static List<clsvQxPotenceTypeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvQxPotenceTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPotenceTypeEN>>(strJson);
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
public static List<clsvQxPotenceTypeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvQxPotenceTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPotenceTypeEN>>(strJson);
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
public static List<clsvQxPotenceTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvQxPotenceTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPotenceTypeEN>>(strJson);
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
public static List<clsvQxPotenceTypeEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvQxPotenceTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPotenceTypeEN>>(strJson);
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
public static bool IsExist(string strPotenceTypeId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strPotenceTypeId"] = strPotenceTypeId
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
 /// <param name = "objvQxPotenceTypeENS">源对象</param>
 /// <param name = "objvQxPotenceTypeENT">目标对象</param>
 public static void CopyTo(clsvQxPotenceTypeEN objvQxPotenceTypeENS, clsvQxPotenceTypeEN objvQxPotenceTypeENT)
{
try
{
objvQxPotenceTypeENT.PotenceTypeId = objvQxPotenceTypeENS.PotenceTypeId; //权限类型Id
objvQxPotenceTypeENT.PotenceTypeName = objvQxPotenceTypeENS.PotenceTypeName; //权限类型名
objvQxPotenceTypeENT.QxPrjId = objvQxPotenceTypeENS.QxPrjId; //项目Id
objvQxPotenceTypeENT.PrjName = objvQxPotenceTypeENS.PrjName; //工程名
objvQxPotenceTypeENT.FuncModuleId = objvQxPotenceTypeENS.FuncModuleId; //模块Id
objvQxPotenceTypeENT.FuncModuleName = objvQxPotenceTypeENS.FuncModuleName; //模块名
objvQxPotenceTypeENT.FuncModuleNameSim = objvQxPotenceTypeENS.FuncModuleNameSim; //模块名_Sim
objvQxPotenceTypeENT.OrderNum = objvQxPotenceTypeENS.OrderNum; //排序号
objvQxPotenceTypeENT.InUse = objvQxPotenceTypeENS.InUse; //是否在用
objvQxPotenceTypeENT.ViewId = objvQxPotenceTypeENS.ViewId; //界面编号
objvQxPotenceTypeENT.ViewName = objvQxPotenceTypeENS.ViewName; //界面名称
objvQxPotenceTypeENT.IsVisible = objvQxPotenceTypeENS.IsVisible; //是否显示
objvQxPotenceTypeENT.UpdDate = objvQxPotenceTypeENS.UpdDate; //修改日期
objvQxPotenceTypeENT.UpdUserId = objvQxPotenceTypeENS.UpdUserId; //修改用户Id
objvQxPotenceTypeENT.Memo = objvQxPotenceTypeENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvQxPotenceTypeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvQxPotenceTypeEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvQxPotenceTypeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvQxPotenceTypeEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvQxPotenceTypeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvQxPotenceTypeEN.AttributeName)
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
string strKey = string.Format("{0}", clsvQxPotenceTypeEN._CurrTabName);
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
public static DataTable GetDataTableByObjLst(List<clsvQxPotenceTypeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convQxPotenceType.PotenceTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPotenceType.PotenceTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPotenceType.QxPrjId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPotenceType.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPotenceType.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPotenceType.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPotenceType.FuncModuleNameSim, Type.GetType("System.String"));
objDT.Columns.Add(convQxPotenceType.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convQxPotenceType.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQxPotenceType.ViewId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPotenceType.ViewName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPotenceType.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQxPotenceType.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convQxPotenceType.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPotenceType.Memo, Type.GetType("System.String"));
foreach (clsvQxPotenceTypeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convQxPotenceType.PotenceTypeId] = objInFor[convQxPotenceType.PotenceTypeId];
objDR[convQxPotenceType.PotenceTypeName] = objInFor[convQxPotenceType.PotenceTypeName];
objDR[convQxPotenceType.QxPrjId] = objInFor[convQxPotenceType.QxPrjId];
objDR[convQxPotenceType.PrjName] = objInFor[convQxPotenceType.PrjName];
objDR[convQxPotenceType.FuncModuleId] = objInFor[convQxPotenceType.FuncModuleId];
objDR[convQxPotenceType.FuncModuleName] = objInFor[convQxPotenceType.FuncModuleName];
objDR[convQxPotenceType.FuncModuleNameSim] = objInFor[convQxPotenceType.FuncModuleNameSim];
objDR[convQxPotenceType.OrderNum] = objInFor[convQxPotenceType.OrderNum];
objDR[convQxPotenceType.InUse] = objInFor[convQxPotenceType.InUse];
objDR[convQxPotenceType.ViewId] = objInFor[convQxPotenceType.ViewId];
objDR[convQxPotenceType.ViewName] = objInFor[convQxPotenceType.ViewName];
objDR[convQxPotenceType.IsVisible] = objInFor[convQxPotenceType.IsVisible];
objDR[convQxPotenceType.UpdDate] = objInFor[convQxPotenceType.UpdDate];
objDR[convQxPotenceType.UpdUserId] = objInFor[convQxPotenceType.UpdUserId];
objDR[convQxPotenceType.Memo] = objInFor[convQxPotenceType.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}