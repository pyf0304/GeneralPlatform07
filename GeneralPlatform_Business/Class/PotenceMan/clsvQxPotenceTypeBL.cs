
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPotenceTypeBL
 表名:vQxPotenceType(00140026)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:32:46
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:权限管理(PotenceMan)
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
public static class  clsvQxPotenceTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strPotenceTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxPotenceTypeEN GetObj(this K_PotenceTypeId_vQxPotenceType myKey)
{
clsvQxPotenceTypeEN objvQxPotenceTypeEN = clsvQxPotenceTypeBL.vQxPotenceTypeDA.GetObjByPotenceTypeId(myKey.Value);
return objvQxPotenceTypeEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPotenceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPotenceTypeEN SetPotenceTypeId(this clsvQxPotenceTypeEN objvQxPotenceTypeEN, string strPotenceTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPotenceTypeId, 6, convQxPotenceType.PotenceTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPotenceTypeId, 6, convQxPotenceType.PotenceTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPotenceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPotenceTypeEN SetPotenceTypeName(this clsvQxPotenceTypeEN objvQxPotenceTypeEN, string strPotenceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPotenceTypeName, convQxPotenceType.PotenceTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPotenceTypeName, 50, convQxPotenceType.PotenceTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPotenceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPotenceTypeEN SetQxPrjId(this clsvQxPotenceTypeEN objvQxPotenceTypeEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, convQxPotenceType.QxPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxPotenceType.QxPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxPotenceType.QxPrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPotenceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPotenceTypeEN SetPrjName(this clsvQxPotenceTypeEN objvQxPotenceTypeEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convQxPotenceType.PrjName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convQxPotenceType.PrjName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPotenceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPotenceTypeEN SetFuncModuleId(this clsvQxPotenceTypeEN objvQxPotenceTypeEN, string strFuncModuleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convQxPotenceType.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convQxPotenceType.FuncModuleId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPotenceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPotenceTypeEN SetFuncModuleName(this clsvQxPotenceTypeEN objvQxPotenceTypeEN, string strFuncModuleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convQxPotenceType.FuncModuleName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPotenceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPotenceTypeEN SetFuncModuleNameSim(this clsvQxPotenceTypeEN objvQxPotenceTypeEN, string strFuncModuleNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleNameSim, 30, convQxPotenceType.FuncModuleNameSim);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPotenceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPotenceTypeEN SetOrderNum(this clsvQxPotenceTypeEN objvQxPotenceTypeEN, int? intOrderNum, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPotenceTypeEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPotenceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPotenceTypeEN SetViewId(this clsvQxPotenceTypeEN objvQxPotenceTypeEN, string strViewId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewId, 8, convQxPotenceType.ViewId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strViewId, 8, convQxPotenceType.ViewId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPotenceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPotenceTypeEN SetViewName(this clsvQxPotenceTypeEN objvQxPotenceTypeEN, string strViewName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewName, 100, convQxPotenceType.ViewName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPotenceTypeEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPotenceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPotenceTypeEN SetUpdDate(this clsvQxPotenceTypeEN objvQxPotenceTypeEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convQxPotenceType.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQxPotenceType.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPotenceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPotenceTypeEN SetUpdUserId(this clsvQxPotenceTypeEN objvQxPotenceTypeEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUserId, convQxPotenceType.UpdUserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convQxPotenceType.UpdUserId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPotenceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPotenceTypeEN SetMemo(this clsvQxPotenceTypeEN objvQxPotenceTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxPotenceType.Memo);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvQxPotenceTypeENS">源对象</param>
 /// <param name = "objvQxPotenceTypeENT">目标对象</param>
 public static void CopyTo(this clsvQxPotenceTypeEN objvQxPotenceTypeENS, clsvQxPotenceTypeEN objvQxPotenceTypeENT)
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
 /// <param name = "objvQxPotenceTypeENS">源对象</param>
 /// <returns>目标对象=>clsvQxPotenceTypeEN:objvQxPotenceTypeENT</returns>
 public static clsvQxPotenceTypeEN CopyTo(this clsvQxPotenceTypeEN objvQxPotenceTypeENS)
{
try
{
 clsvQxPotenceTypeEN objvQxPotenceTypeENT = new clsvQxPotenceTypeEN()
{
PotenceTypeId = objvQxPotenceTypeENS.PotenceTypeId, //权限类型Id
PotenceTypeName = objvQxPotenceTypeENS.PotenceTypeName, //权限类型名
QxPrjId = objvQxPotenceTypeENS.QxPrjId, //项目Id
PrjName = objvQxPotenceTypeENS.PrjName, //工程名
FuncModuleId = objvQxPotenceTypeENS.FuncModuleId, //模块Id
FuncModuleName = objvQxPotenceTypeENS.FuncModuleName, //模块名
FuncModuleNameSim = objvQxPotenceTypeENS.FuncModuleNameSim, //模块名_Sim
OrderNum = objvQxPotenceTypeENS.OrderNum, //排序号
InUse = objvQxPotenceTypeENS.InUse, //是否在用
ViewId = objvQxPotenceTypeENS.ViewId, //界面编号
ViewName = objvQxPotenceTypeENS.ViewName, //界面名称
IsVisible = objvQxPotenceTypeENS.IsVisible, //是否显示
UpdDate = objvQxPotenceTypeENS.UpdDate, //修改日期
UpdUserId = objvQxPotenceTypeENS.UpdUserId, //修改用户Id
Memo = objvQxPotenceTypeENS.Memo, //备注
};
 return objvQxPotenceTypeENT;
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
public static void CheckProperty4Condition(this clsvQxPotenceTypeEN objvQxPotenceTypeEN)
{
 clsvQxPotenceTypeBL.vQxPotenceTypeDA.CheckProperty4Condition(objvQxPotenceTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vQxPotenceType
{
public virtual bool UpdRelaTabDate(string strPotenceTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v权限类型(vQxPotenceType)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvQxPotenceTypeBL
{
public static RelatedActions_vQxPotenceType relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "vQxPotenceTypeListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "vQxPotenceTypeList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsvQxPotenceTypeEN> arrvQxPotenceTypeObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvQxPotenceTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvQxPotenceTypeDA vQxPotenceTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvQxPotenceTypeDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvQxPotenceTypeBL()
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
if (string.IsNullOrEmpty(clsvQxPotenceTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxPotenceTypeEN._ConnectString);
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
objDS = vQxPotenceTypeDA.GetDataSet(strWhereCond);
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
objDS = vQxPotenceTypeDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = vQxPotenceTypeDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_vQxPotenceType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQxPotenceTypeDA.GetDataTable_vQxPotenceType(strWhereCond);
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
objDT = vQxPotenceTypeDA.GetDataTable(strWhereCond);
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
objDT = vQxPotenceTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vQxPotenceTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vQxPotenceTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vQxPotenceTypeDA.GetDataTable_Top(objTopPara);
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
objDT = vQxPotenceTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vQxPotenceTypeDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = vQxPotenceTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vQxPotenceTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = vQxPotenceTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = vQxPotenceTypeDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = vQxPotenceTypeDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = vQxPotenceTypeDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
 /// <param name = "arrPotenceTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvQxPotenceTypeEN> GetObjLstByPotenceTypeIdLst(List<string> arrPotenceTypeIdLst)
{
List<clsvQxPotenceTypeEN> arrObjLst = new List<clsvQxPotenceTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrPotenceTypeIdLst, true);
 string strWhereCond = string.Format("PotenceTypeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPotenceTypeEN objvQxPotenceTypeEN = new clsvQxPotenceTypeEN();
try
{
objvQxPotenceTypeEN.PotenceTypeId = objRow[convQxPotenceType.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxPotenceTypeEN.PotenceTypeName = objRow[convQxPotenceType.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxPotenceTypeEN.QxPrjId = objRow[convQxPotenceType.QxPrjId].ToString().Trim(); //项目Id
objvQxPotenceTypeEN.PrjName = objRow[convQxPotenceType.PrjName].ToString().Trim(); //工程名
objvQxPotenceTypeEN.FuncModuleId = objRow[convQxPotenceType.FuncModuleId] == DBNull.Value ? null : objRow[convQxPotenceType.FuncModuleId].ToString().Trim(); //模块Id
objvQxPotenceTypeEN.FuncModuleName = objRow[convQxPotenceType.FuncModuleName] == DBNull.Value ? null : objRow[convQxPotenceType.FuncModuleName].ToString().Trim(); //模块名
objvQxPotenceTypeEN.FuncModuleNameSim = objRow[convQxPotenceType.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxPotenceType.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objvQxPotenceTypeEN.OrderNum = objRow[convQxPotenceType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPotenceType.OrderNum].ToString().Trim()); //排序号
objvQxPotenceTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPotenceType.InUse].ToString().Trim()); //是否在用
objvQxPotenceTypeEN.ViewId = objRow[convQxPotenceType.ViewId] == DBNull.Value ? null : objRow[convQxPotenceType.ViewId].ToString().Trim(); //界面编号
objvQxPotenceTypeEN.ViewName = objRow[convQxPotenceType.ViewName] == DBNull.Value ? null : objRow[convQxPotenceType.ViewName].ToString().Trim(); //界面名称
objvQxPotenceTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convQxPotenceType.IsVisible].ToString().Trim()); //是否显示
objvQxPotenceTypeEN.UpdDate = objRow[convQxPotenceType.UpdDate].ToString().Trim(); //修改日期
objvQxPotenceTypeEN.UpdUserId = objRow[convQxPotenceType.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPotenceTypeEN.Memo = objRow[convQxPotenceType.Memo] == DBNull.Value ? null : objRow[convQxPotenceType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPotenceTypeEN.PotenceTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPotenceTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPotenceTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvQxPotenceTypeEN> GetObjLstByPotenceTypeIdLstCache(List<string> arrPotenceTypeIdLst)
{
string strKey = string.Format("{0}", clsvQxPotenceTypeEN._CurrTabName);
List<clsvQxPotenceTypeEN> arrvQxPotenceTypeObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPotenceTypeEN> arrvQxPotenceTypeObjLst_Sel =
arrvQxPotenceTypeObjLstCache
.Where(x => arrPotenceTypeIdLst.Contains(x.PotenceTypeId));
return arrvQxPotenceTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPotenceTypeEN> GetObjLst(string strWhereCond)
{
List<clsvQxPotenceTypeEN> arrObjLst = new List<clsvQxPotenceTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPotenceTypeEN objvQxPotenceTypeEN = new clsvQxPotenceTypeEN();
try
{
objvQxPotenceTypeEN.PotenceTypeId = objRow[convQxPotenceType.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxPotenceTypeEN.PotenceTypeName = objRow[convQxPotenceType.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxPotenceTypeEN.QxPrjId = objRow[convQxPotenceType.QxPrjId].ToString().Trim(); //项目Id
objvQxPotenceTypeEN.PrjName = objRow[convQxPotenceType.PrjName].ToString().Trim(); //工程名
objvQxPotenceTypeEN.FuncModuleId = objRow[convQxPotenceType.FuncModuleId] == DBNull.Value ? null : objRow[convQxPotenceType.FuncModuleId].ToString().Trim(); //模块Id
objvQxPotenceTypeEN.FuncModuleName = objRow[convQxPotenceType.FuncModuleName] == DBNull.Value ? null : objRow[convQxPotenceType.FuncModuleName].ToString().Trim(); //模块名
objvQxPotenceTypeEN.FuncModuleNameSim = objRow[convQxPotenceType.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxPotenceType.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objvQxPotenceTypeEN.OrderNum = objRow[convQxPotenceType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPotenceType.OrderNum].ToString().Trim()); //排序号
objvQxPotenceTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPotenceType.InUse].ToString().Trim()); //是否在用
objvQxPotenceTypeEN.ViewId = objRow[convQxPotenceType.ViewId] == DBNull.Value ? null : objRow[convQxPotenceType.ViewId].ToString().Trim(); //界面编号
objvQxPotenceTypeEN.ViewName = objRow[convQxPotenceType.ViewName] == DBNull.Value ? null : objRow[convQxPotenceType.ViewName].ToString().Trim(); //界面名称
objvQxPotenceTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convQxPotenceType.IsVisible].ToString().Trim()); //是否显示
objvQxPotenceTypeEN.UpdDate = objRow[convQxPotenceType.UpdDate].ToString().Trim(); //修改日期
objvQxPotenceTypeEN.UpdUserId = objRow[convQxPotenceType.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPotenceTypeEN.Memo = objRow[convQxPotenceType.Memo] == DBNull.Value ? null : objRow[convQxPotenceType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPotenceTypeEN.PotenceTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPotenceTypeEN);
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
public static List<clsvQxPotenceTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQxPotenceTypeEN> arrObjLst = new List<clsvQxPotenceTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPotenceTypeEN objvQxPotenceTypeEN = new clsvQxPotenceTypeEN();
try
{
objvQxPotenceTypeEN.PotenceTypeId = objRow[convQxPotenceType.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxPotenceTypeEN.PotenceTypeName = objRow[convQxPotenceType.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxPotenceTypeEN.QxPrjId = objRow[convQxPotenceType.QxPrjId].ToString().Trim(); //项目Id
objvQxPotenceTypeEN.PrjName = objRow[convQxPotenceType.PrjName].ToString().Trim(); //工程名
objvQxPotenceTypeEN.FuncModuleId = objRow[convQxPotenceType.FuncModuleId] == DBNull.Value ? null : objRow[convQxPotenceType.FuncModuleId].ToString().Trim(); //模块Id
objvQxPotenceTypeEN.FuncModuleName = objRow[convQxPotenceType.FuncModuleName] == DBNull.Value ? null : objRow[convQxPotenceType.FuncModuleName].ToString().Trim(); //模块名
objvQxPotenceTypeEN.FuncModuleNameSim = objRow[convQxPotenceType.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxPotenceType.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objvQxPotenceTypeEN.OrderNum = objRow[convQxPotenceType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPotenceType.OrderNum].ToString().Trim()); //排序号
objvQxPotenceTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPotenceType.InUse].ToString().Trim()); //是否在用
objvQxPotenceTypeEN.ViewId = objRow[convQxPotenceType.ViewId] == DBNull.Value ? null : objRow[convQxPotenceType.ViewId].ToString().Trim(); //界面编号
objvQxPotenceTypeEN.ViewName = objRow[convQxPotenceType.ViewName] == DBNull.Value ? null : objRow[convQxPotenceType.ViewName].ToString().Trim(); //界面名称
objvQxPotenceTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convQxPotenceType.IsVisible].ToString().Trim()); //是否显示
objvQxPotenceTypeEN.UpdDate = objRow[convQxPotenceType.UpdDate].ToString().Trim(); //修改日期
objvQxPotenceTypeEN.UpdUserId = objRow[convQxPotenceType.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPotenceTypeEN.Memo = objRow[convQxPotenceType.Memo] == DBNull.Value ? null : objRow[convQxPotenceType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPotenceTypeEN.PotenceTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPotenceTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvQxPotenceTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvQxPotenceTypeEN> GetSubObjLstCache(clsvQxPotenceTypeEN objvQxPotenceTypeCond)
{
List<clsvQxPotenceTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPotenceTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxPotenceType.AttributeName)
{
if (objvQxPotenceTypeCond.IsUpdated(strFldName) == false) continue;
if (objvQxPotenceTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPotenceTypeCond[strFldName].ToString());
}
else
{
if (objvQxPotenceTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxPotenceTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPotenceTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxPotenceTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxPotenceTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxPotenceTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxPotenceTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxPotenceTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxPotenceTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxPotenceTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxPotenceTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxPotenceTypeCond[strFldName]));
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
public static List<clsvQxPotenceTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvQxPotenceTypeEN> arrObjLst = new List<clsvQxPotenceTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPotenceTypeEN objvQxPotenceTypeEN = new clsvQxPotenceTypeEN();
try
{
objvQxPotenceTypeEN.PotenceTypeId = objRow[convQxPotenceType.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxPotenceTypeEN.PotenceTypeName = objRow[convQxPotenceType.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxPotenceTypeEN.QxPrjId = objRow[convQxPotenceType.QxPrjId].ToString().Trim(); //项目Id
objvQxPotenceTypeEN.PrjName = objRow[convQxPotenceType.PrjName].ToString().Trim(); //工程名
objvQxPotenceTypeEN.FuncModuleId = objRow[convQxPotenceType.FuncModuleId] == DBNull.Value ? null : objRow[convQxPotenceType.FuncModuleId].ToString().Trim(); //模块Id
objvQxPotenceTypeEN.FuncModuleName = objRow[convQxPotenceType.FuncModuleName] == DBNull.Value ? null : objRow[convQxPotenceType.FuncModuleName].ToString().Trim(); //模块名
objvQxPotenceTypeEN.FuncModuleNameSim = objRow[convQxPotenceType.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxPotenceType.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objvQxPotenceTypeEN.OrderNum = objRow[convQxPotenceType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPotenceType.OrderNum].ToString().Trim()); //排序号
objvQxPotenceTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPotenceType.InUse].ToString().Trim()); //是否在用
objvQxPotenceTypeEN.ViewId = objRow[convQxPotenceType.ViewId] == DBNull.Value ? null : objRow[convQxPotenceType.ViewId].ToString().Trim(); //界面编号
objvQxPotenceTypeEN.ViewName = objRow[convQxPotenceType.ViewName] == DBNull.Value ? null : objRow[convQxPotenceType.ViewName].ToString().Trim(); //界面名称
objvQxPotenceTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convQxPotenceType.IsVisible].ToString().Trim()); //是否显示
objvQxPotenceTypeEN.UpdDate = objRow[convQxPotenceType.UpdDate].ToString().Trim(); //修改日期
objvQxPotenceTypeEN.UpdUserId = objRow[convQxPotenceType.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPotenceTypeEN.Memo = objRow[convQxPotenceType.Memo] == DBNull.Value ? null : objRow[convQxPotenceType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPotenceTypeEN.PotenceTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPotenceTypeEN);
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
public static List<clsvQxPotenceTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvQxPotenceTypeEN> arrObjLst = new List<clsvQxPotenceTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPotenceTypeEN objvQxPotenceTypeEN = new clsvQxPotenceTypeEN();
try
{
objvQxPotenceTypeEN.PotenceTypeId = objRow[convQxPotenceType.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxPotenceTypeEN.PotenceTypeName = objRow[convQxPotenceType.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxPotenceTypeEN.QxPrjId = objRow[convQxPotenceType.QxPrjId].ToString().Trim(); //项目Id
objvQxPotenceTypeEN.PrjName = objRow[convQxPotenceType.PrjName].ToString().Trim(); //工程名
objvQxPotenceTypeEN.FuncModuleId = objRow[convQxPotenceType.FuncModuleId] == DBNull.Value ? null : objRow[convQxPotenceType.FuncModuleId].ToString().Trim(); //模块Id
objvQxPotenceTypeEN.FuncModuleName = objRow[convQxPotenceType.FuncModuleName] == DBNull.Value ? null : objRow[convQxPotenceType.FuncModuleName].ToString().Trim(); //模块名
objvQxPotenceTypeEN.FuncModuleNameSim = objRow[convQxPotenceType.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxPotenceType.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objvQxPotenceTypeEN.OrderNum = objRow[convQxPotenceType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPotenceType.OrderNum].ToString().Trim()); //排序号
objvQxPotenceTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPotenceType.InUse].ToString().Trim()); //是否在用
objvQxPotenceTypeEN.ViewId = objRow[convQxPotenceType.ViewId] == DBNull.Value ? null : objRow[convQxPotenceType.ViewId].ToString().Trim(); //界面编号
objvQxPotenceTypeEN.ViewName = objRow[convQxPotenceType.ViewName] == DBNull.Value ? null : objRow[convQxPotenceType.ViewName].ToString().Trim(); //界面名称
objvQxPotenceTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convQxPotenceType.IsVisible].ToString().Trim()); //是否显示
objvQxPotenceTypeEN.UpdDate = objRow[convQxPotenceType.UpdDate].ToString().Trim(); //修改日期
objvQxPotenceTypeEN.UpdUserId = objRow[convQxPotenceType.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPotenceTypeEN.Memo = objRow[convQxPotenceType.Memo] == DBNull.Value ? null : objRow[convQxPotenceType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPotenceTypeEN.PotenceTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPotenceTypeEN);
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
List<clsvQxPotenceTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvQxPotenceTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPotenceTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvQxPotenceTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvQxPotenceTypeEN> arrObjLst = new List<clsvQxPotenceTypeEN>(); 
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
	clsvQxPotenceTypeEN objvQxPotenceTypeEN = new clsvQxPotenceTypeEN();
try
{
objvQxPotenceTypeEN.PotenceTypeId = objRow[convQxPotenceType.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxPotenceTypeEN.PotenceTypeName = objRow[convQxPotenceType.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxPotenceTypeEN.QxPrjId = objRow[convQxPotenceType.QxPrjId].ToString().Trim(); //项目Id
objvQxPotenceTypeEN.PrjName = objRow[convQxPotenceType.PrjName].ToString().Trim(); //工程名
objvQxPotenceTypeEN.FuncModuleId = objRow[convQxPotenceType.FuncModuleId] == DBNull.Value ? null : objRow[convQxPotenceType.FuncModuleId].ToString().Trim(); //模块Id
objvQxPotenceTypeEN.FuncModuleName = objRow[convQxPotenceType.FuncModuleName] == DBNull.Value ? null : objRow[convQxPotenceType.FuncModuleName].ToString().Trim(); //模块名
objvQxPotenceTypeEN.FuncModuleNameSim = objRow[convQxPotenceType.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxPotenceType.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objvQxPotenceTypeEN.OrderNum = objRow[convQxPotenceType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPotenceType.OrderNum].ToString().Trim()); //排序号
objvQxPotenceTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPotenceType.InUse].ToString().Trim()); //是否在用
objvQxPotenceTypeEN.ViewId = objRow[convQxPotenceType.ViewId] == DBNull.Value ? null : objRow[convQxPotenceType.ViewId].ToString().Trim(); //界面编号
objvQxPotenceTypeEN.ViewName = objRow[convQxPotenceType.ViewName] == DBNull.Value ? null : objRow[convQxPotenceType.ViewName].ToString().Trim(); //界面名称
objvQxPotenceTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convQxPotenceType.IsVisible].ToString().Trim()); //是否显示
objvQxPotenceTypeEN.UpdDate = objRow[convQxPotenceType.UpdDate].ToString().Trim(); //修改日期
objvQxPotenceTypeEN.UpdUserId = objRow[convQxPotenceType.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPotenceTypeEN.Memo = objRow[convQxPotenceType.Memo] == DBNull.Value ? null : objRow[convQxPotenceType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPotenceTypeEN.PotenceTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPotenceTypeEN);
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
public static List<clsvQxPotenceTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvQxPotenceTypeEN> arrObjLst = new List<clsvQxPotenceTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPotenceTypeEN objvQxPotenceTypeEN = new clsvQxPotenceTypeEN();
try
{
objvQxPotenceTypeEN.PotenceTypeId = objRow[convQxPotenceType.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxPotenceTypeEN.PotenceTypeName = objRow[convQxPotenceType.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxPotenceTypeEN.QxPrjId = objRow[convQxPotenceType.QxPrjId].ToString().Trim(); //项目Id
objvQxPotenceTypeEN.PrjName = objRow[convQxPotenceType.PrjName].ToString().Trim(); //工程名
objvQxPotenceTypeEN.FuncModuleId = objRow[convQxPotenceType.FuncModuleId] == DBNull.Value ? null : objRow[convQxPotenceType.FuncModuleId].ToString().Trim(); //模块Id
objvQxPotenceTypeEN.FuncModuleName = objRow[convQxPotenceType.FuncModuleName] == DBNull.Value ? null : objRow[convQxPotenceType.FuncModuleName].ToString().Trim(); //模块名
objvQxPotenceTypeEN.FuncModuleNameSim = objRow[convQxPotenceType.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxPotenceType.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objvQxPotenceTypeEN.OrderNum = objRow[convQxPotenceType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPotenceType.OrderNum].ToString().Trim()); //排序号
objvQxPotenceTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPotenceType.InUse].ToString().Trim()); //是否在用
objvQxPotenceTypeEN.ViewId = objRow[convQxPotenceType.ViewId] == DBNull.Value ? null : objRow[convQxPotenceType.ViewId].ToString().Trim(); //界面编号
objvQxPotenceTypeEN.ViewName = objRow[convQxPotenceType.ViewName] == DBNull.Value ? null : objRow[convQxPotenceType.ViewName].ToString().Trim(); //界面名称
objvQxPotenceTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convQxPotenceType.IsVisible].ToString().Trim()); //是否显示
objvQxPotenceTypeEN.UpdDate = objRow[convQxPotenceType.UpdDate].ToString().Trim(); //修改日期
objvQxPotenceTypeEN.UpdUserId = objRow[convQxPotenceType.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPotenceTypeEN.Memo = objRow[convQxPotenceType.Memo] == DBNull.Value ? null : objRow[convQxPotenceType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPotenceTypeEN.PotenceTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPotenceTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQxPotenceTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvQxPotenceTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvQxPotenceTypeEN> arrObjLst = new List<clsvQxPotenceTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPotenceTypeEN objvQxPotenceTypeEN = new clsvQxPotenceTypeEN();
try
{
objvQxPotenceTypeEN.PotenceTypeId = objRow[convQxPotenceType.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxPotenceTypeEN.PotenceTypeName = objRow[convQxPotenceType.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxPotenceTypeEN.QxPrjId = objRow[convQxPotenceType.QxPrjId].ToString().Trim(); //项目Id
objvQxPotenceTypeEN.PrjName = objRow[convQxPotenceType.PrjName].ToString().Trim(); //工程名
objvQxPotenceTypeEN.FuncModuleId = objRow[convQxPotenceType.FuncModuleId] == DBNull.Value ? null : objRow[convQxPotenceType.FuncModuleId].ToString().Trim(); //模块Id
objvQxPotenceTypeEN.FuncModuleName = objRow[convQxPotenceType.FuncModuleName] == DBNull.Value ? null : objRow[convQxPotenceType.FuncModuleName].ToString().Trim(); //模块名
objvQxPotenceTypeEN.FuncModuleNameSim = objRow[convQxPotenceType.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxPotenceType.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objvQxPotenceTypeEN.OrderNum = objRow[convQxPotenceType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPotenceType.OrderNum].ToString().Trim()); //排序号
objvQxPotenceTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPotenceType.InUse].ToString().Trim()); //是否在用
objvQxPotenceTypeEN.ViewId = objRow[convQxPotenceType.ViewId] == DBNull.Value ? null : objRow[convQxPotenceType.ViewId].ToString().Trim(); //界面编号
objvQxPotenceTypeEN.ViewName = objRow[convQxPotenceType.ViewName] == DBNull.Value ? null : objRow[convQxPotenceType.ViewName].ToString().Trim(); //界面名称
objvQxPotenceTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convQxPotenceType.IsVisible].ToString().Trim()); //是否显示
objvQxPotenceTypeEN.UpdDate = objRow[convQxPotenceType.UpdDate].ToString().Trim(); //修改日期
objvQxPotenceTypeEN.UpdUserId = objRow[convQxPotenceType.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPotenceTypeEN.Memo = objRow[convQxPotenceType.Memo] == DBNull.Value ? null : objRow[convQxPotenceType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPotenceTypeEN.PotenceTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPotenceTypeEN);
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
public static List<clsvQxPotenceTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvQxPotenceTypeEN> arrObjLst = new List<clsvQxPotenceTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPotenceTypeEN objvQxPotenceTypeEN = new clsvQxPotenceTypeEN();
try
{
objvQxPotenceTypeEN.PotenceTypeId = objRow[convQxPotenceType.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxPotenceTypeEN.PotenceTypeName = objRow[convQxPotenceType.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxPotenceTypeEN.QxPrjId = objRow[convQxPotenceType.QxPrjId].ToString().Trim(); //项目Id
objvQxPotenceTypeEN.PrjName = objRow[convQxPotenceType.PrjName].ToString().Trim(); //工程名
objvQxPotenceTypeEN.FuncModuleId = objRow[convQxPotenceType.FuncModuleId] == DBNull.Value ? null : objRow[convQxPotenceType.FuncModuleId].ToString().Trim(); //模块Id
objvQxPotenceTypeEN.FuncModuleName = objRow[convQxPotenceType.FuncModuleName] == DBNull.Value ? null : objRow[convQxPotenceType.FuncModuleName].ToString().Trim(); //模块名
objvQxPotenceTypeEN.FuncModuleNameSim = objRow[convQxPotenceType.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxPotenceType.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objvQxPotenceTypeEN.OrderNum = objRow[convQxPotenceType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPotenceType.OrderNum].ToString().Trim()); //排序号
objvQxPotenceTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPotenceType.InUse].ToString().Trim()); //是否在用
objvQxPotenceTypeEN.ViewId = objRow[convQxPotenceType.ViewId] == DBNull.Value ? null : objRow[convQxPotenceType.ViewId].ToString().Trim(); //界面编号
objvQxPotenceTypeEN.ViewName = objRow[convQxPotenceType.ViewName] == DBNull.Value ? null : objRow[convQxPotenceType.ViewName].ToString().Trim(); //界面名称
objvQxPotenceTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convQxPotenceType.IsVisible].ToString().Trim()); //是否显示
objvQxPotenceTypeEN.UpdDate = objRow[convQxPotenceType.UpdDate].ToString().Trim(); //修改日期
objvQxPotenceTypeEN.UpdUserId = objRow[convQxPotenceType.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPotenceTypeEN.Memo = objRow[convQxPotenceType.Memo] == DBNull.Value ? null : objRow[convQxPotenceType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPotenceTypeEN.PotenceTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPotenceTypeEN);
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
public static IEnumerable<clsvQxPotenceTypeEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsvQxPotenceTypeEN objvQxPotenceTypeCond, string strOrderBy)
{
List<clsvQxPotenceTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPotenceTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxPotenceType.AttributeName)
{
if (objvQxPotenceTypeCond.IsUpdated(strFldName) == false) continue;
if (objvQxPotenceTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPotenceTypeCond[strFldName].ToString());
}
else
{
if (objvQxPotenceTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxPotenceTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPotenceTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxPotenceTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxPotenceTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxPotenceTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxPotenceTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxPotenceTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxPotenceTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxPotenceTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxPotenceTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxPotenceTypeCond[strFldName]));
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
public static IEnumerable<clsvQxPotenceTypeEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsvQxPotenceTypeEN objvQxPotenceTypeCond = JsonConvert.DeserializeObject<clsvQxPotenceTypeEN>(objPagerPara.whereCond);
if (objvQxPotenceTypeCond.sfFldComparisonOp == null)
{
objvQxPotenceTypeCond.dicFldComparisonOp = null;
}
else
{
objvQxPotenceTypeCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objvQxPotenceTypeCond.sfFldComparisonOp);
}
clsvQxPotenceTypeBL.SetUpdFlag(objvQxPotenceTypeCond);
 try
{
CheckProperty4Condition(objvQxPotenceTypeCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsvQxPotenceTypeBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objvQxPotenceTypeCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPotenceTypeEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsvQxPotenceTypeEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxPotenceTypeEN> arrObjLst = new List<clsvQxPotenceTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPotenceTypeEN objvQxPotenceTypeEN = new clsvQxPotenceTypeEN();
try
{
objvQxPotenceTypeEN.PotenceTypeId = objRow[convQxPotenceType.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxPotenceTypeEN.PotenceTypeName = objRow[convQxPotenceType.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxPotenceTypeEN.QxPrjId = objRow[convQxPotenceType.QxPrjId].ToString().Trim(); //项目Id
objvQxPotenceTypeEN.PrjName = objRow[convQxPotenceType.PrjName].ToString().Trim(); //工程名
objvQxPotenceTypeEN.FuncModuleId = objRow[convQxPotenceType.FuncModuleId] == DBNull.Value ? null : objRow[convQxPotenceType.FuncModuleId].ToString().Trim(); //模块Id
objvQxPotenceTypeEN.FuncModuleName = objRow[convQxPotenceType.FuncModuleName] == DBNull.Value ? null : objRow[convQxPotenceType.FuncModuleName].ToString().Trim(); //模块名
objvQxPotenceTypeEN.FuncModuleNameSim = objRow[convQxPotenceType.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxPotenceType.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objvQxPotenceTypeEN.OrderNum = objRow[convQxPotenceType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPotenceType.OrderNum].ToString().Trim()); //排序号
objvQxPotenceTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPotenceType.InUse].ToString().Trim()); //是否在用
objvQxPotenceTypeEN.ViewId = objRow[convQxPotenceType.ViewId] == DBNull.Value ? null : objRow[convQxPotenceType.ViewId].ToString().Trim(); //界面编号
objvQxPotenceTypeEN.ViewName = objRow[convQxPotenceType.ViewName] == DBNull.Value ? null : objRow[convQxPotenceType.ViewName].ToString().Trim(); //界面名称
objvQxPotenceTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convQxPotenceType.IsVisible].ToString().Trim()); //是否显示
objvQxPotenceTypeEN.UpdDate = objRow[convQxPotenceType.UpdDate].ToString().Trim(); //修改日期
objvQxPotenceTypeEN.UpdUserId = objRow[convQxPotenceType.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPotenceTypeEN.Memo = objRow[convQxPotenceType.Memo] == DBNull.Value ? null : objRow[convQxPotenceType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPotenceTypeEN.PotenceTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPotenceTypeEN);
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
public static List<clsvQxPotenceTypeEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxPotenceTypeEN> arrObjLst = new List<clsvQxPotenceTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPotenceTypeEN objvQxPotenceTypeEN = new clsvQxPotenceTypeEN();
try
{
objvQxPotenceTypeEN.PotenceTypeId = objRow[convQxPotenceType.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxPotenceTypeEN.PotenceTypeName = objRow[convQxPotenceType.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxPotenceTypeEN.QxPrjId = objRow[convQxPotenceType.QxPrjId].ToString().Trim(); //项目Id
objvQxPotenceTypeEN.PrjName = objRow[convQxPotenceType.PrjName].ToString().Trim(); //工程名
objvQxPotenceTypeEN.FuncModuleId = objRow[convQxPotenceType.FuncModuleId] == DBNull.Value ? null : objRow[convQxPotenceType.FuncModuleId].ToString().Trim(); //模块Id
objvQxPotenceTypeEN.FuncModuleName = objRow[convQxPotenceType.FuncModuleName] == DBNull.Value ? null : objRow[convQxPotenceType.FuncModuleName].ToString().Trim(); //模块名
objvQxPotenceTypeEN.FuncModuleNameSim = objRow[convQxPotenceType.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxPotenceType.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objvQxPotenceTypeEN.OrderNum = objRow[convQxPotenceType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPotenceType.OrderNum].ToString().Trim()); //排序号
objvQxPotenceTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPotenceType.InUse].ToString().Trim()); //是否在用
objvQxPotenceTypeEN.ViewId = objRow[convQxPotenceType.ViewId] == DBNull.Value ? null : objRow[convQxPotenceType.ViewId].ToString().Trim(); //界面编号
objvQxPotenceTypeEN.ViewName = objRow[convQxPotenceType.ViewName] == DBNull.Value ? null : objRow[convQxPotenceType.ViewName].ToString().Trim(); //界面名称
objvQxPotenceTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convQxPotenceType.IsVisible].ToString().Trim()); //是否显示
objvQxPotenceTypeEN.UpdDate = objRow[convQxPotenceType.UpdDate].ToString().Trim(); //修改日期
objvQxPotenceTypeEN.UpdUserId = objRow[convQxPotenceType.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPotenceTypeEN.Memo = objRow[convQxPotenceType.Memo] == DBNull.Value ? null : objRow[convQxPotenceType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPotenceTypeEN.PotenceTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPotenceTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPotenceTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvQxPotenceTypeEN> arrObjLst = new List<clsvQxPotenceTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPotenceTypeEN objvQxPotenceTypeEN = new clsvQxPotenceTypeEN();
try
{
objvQxPotenceTypeEN.PotenceTypeId = objRow[convQxPotenceType.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxPotenceTypeEN.PotenceTypeName = objRow[convQxPotenceType.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxPotenceTypeEN.QxPrjId = objRow[convQxPotenceType.QxPrjId].ToString().Trim(); //项目Id
objvQxPotenceTypeEN.PrjName = objRow[convQxPotenceType.PrjName].ToString().Trim(); //工程名
objvQxPotenceTypeEN.FuncModuleId = objRow[convQxPotenceType.FuncModuleId] == DBNull.Value ? null : objRow[convQxPotenceType.FuncModuleId].ToString().Trim(); //模块Id
objvQxPotenceTypeEN.FuncModuleName = objRow[convQxPotenceType.FuncModuleName] == DBNull.Value ? null : objRow[convQxPotenceType.FuncModuleName].ToString().Trim(); //模块名
objvQxPotenceTypeEN.FuncModuleNameSim = objRow[convQxPotenceType.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxPotenceType.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objvQxPotenceTypeEN.OrderNum = objRow[convQxPotenceType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPotenceType.OrderNum].ToString().Trim()); //排序号
objvQxPotenceTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPotenceType.InUse].ToString().Trim()); //是否在用
objvQxPotenceTypeEN.ViewId = objRow[convQxPotenceType.ViewId] == DBNull.Value ? null : objRow[convQxPotenceType.ViewId].ToString().Trim(); //界面编号
objvQxPotenceTypeEN.ViewName = objRow[convQxPotenceType.ViewName] == DBNull.Value ? null : objRow[convQxPotenceType.ViewName].ToString().Trim(); //界面名称
objvQxPotenceTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convQxPotenceType.IsVisible].ToString().Trim()); //是否显示
objvQxPotenceTypeEN.UpdDate = objRow[convQxPotenceType.UpdDate].ToString().Trim(); //修改日期
objvQxPotenceTypeEN.UpdUserId = objRow[convQxPotenceType.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPotenceTypeEN.Memo = objRow[convQxPotenceType.Memo] == DBNull.Value ? null : objRow[convQxPotenceType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPotenceTypeEN.PotenceTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPotenceTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvQxPotenceTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxPotenceType(ref clsvQxPotenceTypeEN objvQxPotenceTypeEN)
{
bool bolResult = vQxPotenceTypeDA.GetvQxPotenceType(ref objvQxPotenceTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strPotenceTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxPotenceTypeEN GetObjByPotenceTypeId(string strPotenceTypeId)
{
if (strPotenceTypeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strPotenceTypeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strPotenceTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strPotenceTypeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvQxPotenceTypeEN objvQxPotenceTypeEN = vQxPotenceTypeDA.GetObjByPotenceTypeId(strPotenceTypeId);
return objvQxPotenceTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvQxPotenceTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvQxPotenceTypeEN objvQxPotenceTypeEN = vQxPotenceTypeDA.GetFirstObj(strWhereCond);
 return objvQxPotenceTypeEN;
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
public static clsvQxPotenceTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvQxPotenceTypeEN objvQxPotenceTypeEN = vQxPotenceTypeDA.GetObjByDataRow(objRow);
 return objvQxPotenceTypeEN;
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
public static clsvQxPotenceTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvQxPotenceTypeEN objvQxPotenceTypeEN = vQxPotenceTypeDA.GetObjByDataRow(objRow);
 return objvQxPotenceTypeEN;
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
 /// <param name = "strPotenceTypeId">所给的关键字</param>
 /// <param name = "lstvQxPotenceTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxPotenceTypeEN GetObjByPotenceTypeIdFromList(string strPotenceTypeId, List<clsvQxPotenceTypeEN> lstvQxPotenceTypeObjLst)
{
foreach (clsvQxPotenceTypeEN objvQxPotenceTypeEN in lstvQxPotenceTypeObjLst)
{
if (objvQxPotenceTypeEN.PotenceTypeId == strPotenceTypeId)
{
return objvQxPotenceTypeEN;
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
 string strPotenceTypeId;
 try
 {
 strPotenceTypeId = new clsvQxPotenceTypeDA().GetFirstID(strWhereCond);
 return strPotenceTypeId;
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
 arrList = vQxPotenceTypeDA.GetID(strWhereCond);
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
bool bolIsExist = vQxPotenceTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strPotenceTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strPotenceTypeId)
{
if (string.IsNullOrEmpty(strPotenceTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strPotenceTypeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vQxPotenceTypeDA.IsExist(strPotenceTypeId);
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
 bolIsExist = clsvQxPotenceTypeDA.IsExistTable();
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
 bolIsExist = vQxPotenceTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objvQxPotenceTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsvQxPotenceTypeEN objvQxPotenceTypeEN)
{
try
{
objvQxPotenceTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvQxPotenceTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convQxPotenceType.PotenceTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPotenceTypeEN.PotenceTypeId = objvQxPotenceTypeEN.PotenceTypeId; //权限类型Id
}
if (arrFldSet.Contains(convQxPotenceType.PotenceTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPotenceTypeEN.PotenceTypeName = objvQxPotenceTypeEN.PotenceTypeName; //权限类型名
}
if (arrFldSet.Contains(convQxPotenceType.QxPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPotenceTypeEN.QxPrjId = objvQxPotenceTypeEN.QxPrjId; //项目Id
}
if (arrFldSet.Contains(convQxPotenceType.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPotenceTypeEN.PrjName = objvQxPotenceTypeEN.PrjName; //工程名
}
if (arrFldSet.Contains(convQxPotenceType.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPotenceTypeEN.FuncModuleId = objvQxPotenceTypeEN.FuncModuleId == "[null]" ? null :  objvQxPotenceTypeEN.FuncModuleId; //模块Id
}
if (arrFldSet.Contains(convQxPotenceType.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPotenceTypeEN.FuncModuleName = objvQxPotenceTypeEN.FuncModuleName == "[null]" ? null :  objvQxPotenceTypeEN.FuncModuleName; //模块名
}
if (arrFldSet.Contains(convQxPotenceType.FuncModuleNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPotenceTypeEN.FuncModuleNameSim = objvQxPotenceTypeEN.FuncModuleNameSim == "[null]" ? null :  objvQxPotenceTypeEN.FuncModuleNameSim; //模块名_Sim
}
if (arrFldSet.Contains(convQxPotenceType.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPotenceTypeEN.OrderNum = objvQxPotenceTypeEN.OrderNum; //排序号
}
if (arrFldSet.Contains(convQxPotenceType.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPotenceTypeEN.InUse = objvQxPotenceTypeEN.InUse; //是否在用
}
if (arrFldSet.Contains(convQxPotenceType.ViewId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPotenceTypeEN.ViewId = objvQxPotenceTypeEN.ViewId == "[null]" ? null :  objvQxPotenceTypeEN.ViewId; //界面编号
}
if (arrFldSet.Contains(convQxPotenceType.ViewName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPotenceTypeEN.ViewName = objvQxPotenceTypeEN.ViewName == "[null]" ? null :  objvQxPotenceTypeEN.ViewName; //界面名称
}
if (arrFldSet.Contains(convQxPotenceType.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPotenceTypeEN.IsVisible = objvQxPotenceTypeEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(convQxPotenceType.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPotenceTypeEN.UpdDate = objvQxPotenceTypeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convQxPotenceType.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPotenceTypeEN.UpdUserId = objvQxPotenceTypeEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convQxPotenceType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPotenceTypeEN.Memo = objvQxPotenceTypeEN.Memo == "[null]" ? null :  objvQxPotenceTypeEN.Memo; //备注
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
 /// <param name = "objvQxPotenceTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsvQxPotenceTypeEN objvQxPotenceTypeEN)
{
try
{
if (objvQxPotenceTypeEN.FuncModuleId == "[null]") objvQxPotenceTypeEN.FuncModuleId = null; //模块Id
if (objvQxPotenceTypeEN.FuncModuleName == "[null]") objvQxPotenceTypeEN.FuncModuleName = null; //模块名
if (objvQxPotenceTypeEN.FuncModuleNameSim == "[null]") objvQxPotenceTypeEN.FuncModuleNameSim = null; //模块名_Sim
if (objvQxPotenceTypeEN.ViewId == "[null]") objvQxPotenceTypeEN.ViewId = null; //界面编号
if (objvQxPotenceTypeEN.ViewName == "[null]") objvQxPotenceTypeEN.ViewName = null; //界面名称
if (objvQxPotenceTypeEN.Memo == "[null]") objvQxPotenceTypeEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvQxPotenceTypeEN objvQxPotenceTypeEN)
{
 vQxPotenceTypeDA.CheckProperty4Condition(objvQxPotenceTypeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_PotenceTypeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convQxPotenceType.PotenceTypeId); 
List<clsvQxPotenceTypeEN> arrObjLst = clsvQxPotenceTypeBL.GetObjLst(strCondition);
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
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_PotenceTypeId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v权限类型]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convQxPotenceType.PotenceTypeId); 
IEnumerable<clsvQxPotenceTypeEN> arrObjLst = clsvQxPotenceTypeBL.GetObjLst(strCondition);
objDDL.DataValueField = convQxPotenceType.PotenceTypeId;
objDDL.DataTextField = convQxPotenceType.PotenceTypeName;
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
public static void BindDdl_PotenceTypeIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v权限类型]...","0");
List<clsvQxPotenceTypeEN> arrvQxPotenceTypeObjLst = GetAllvQxPotenceTypeObjLstCache(); 
objDDL.DataValueField = convQxPotenceType.PotenceTypeId;
objDDL.DataTextField = convQxPotenceType.PotenceTypeName;
objDDL.DataSource = arrvQxPotenceTypeObjLst;
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
if (clsQxPotenceTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxPotenceTypeBL没有刷新缓存机制(clsQxPotenceTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsQxFuncModuleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxFuncModuleBL没有刷新缓存机制(clsQxFuncModuleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PotenceTypeId");
//if (arrvQxPotenceTypeObjLstCache == null)
//{
//arrvQxPotenceTypeObjLstCache = vQxPotenceTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strPotenceTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxPotenceTypeEN GetObjByPotenceTypeIdCache(string strPotenceTypeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvQxPotenceTypeEN._CurrTabName);
List<clsvQxPotenceTypeEN> arrvQxPotenceTypeObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPotenceTypeEN> arrvQxPotenceTypeObjLst_Sel =
arrvQxPotenceTypeObjLstCache
.Where(x=> x.PotenceTypeId == strPotenceTypeId 
);
if (arrvQxPotenceTypeObjLst_Sel.Count() == 0)
{
   clsvQxPotenceTypeEN obj = clsvQxPotenceTypeBL.GetObjByPotenceTypeId(strPotenceTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvQxPotenceTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strPotenceTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetPotenceTypeNameByPotenceTypeIdCache(string strPotenceTypeId)
{
if (string.IsNullOrEmpty(strPotenceTypeId) == true) return "";
//获取缓存中的对象列表
clsvQxPotenceTypeEN objvQxPotenceType = GetObjByPotenceTypeIdCache(strPotenceTypeId);
if (objvQxPotenceType == null) return "";
return objvQxPotenceType.PotenceTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strPotenceTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByPotenceTypeIdCache(string strPotenceTypeId)
{
if (string.IsNullOrEmpty(strPotenceTypeId) == true) return "";
//获取缓存中的对象列表
clsvQxPotenceTypeEN objvQxPotenceType = GetObjByPotenceTypeIdCache(strPotenceTypeId);
if (objvQxPotenceType == null) return "";
return objvQxPotenceType.PotenceTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxPotenceTypeEN> GetAllvQxPotenceTypeObjLstCache()
{
//获取缓存中的对象列表
List<clsvQxPotenceTypeEN> arrvQxPotenceTypeObjLstCache = GetObjLstCache(); 
return arrvQxPotenceTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxPotenceTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvQxPotenceTypeEN._CurrTabName);
List<clsvQxPotenceTypeEN> arrvQxPotenceTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQxPotenceTypeObjLstCache;
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


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstvQxPotenceTypeObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsvQxPotenceTypeEN> lstvQxPotenceTypeObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstvQxPotenceTypeObjLst, writer);
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
 /// <param name = "lstvQxPotenceTypeObjLst">[clsvQxPotenceTypeEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsvQxPotenceTypeEN> lstvQxPotenceTypeObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsvQxPotenceTypeBL.listXmlNode);
writer.WriteStartElement(clsvQxPotenceTypeBL.itemsXmlNode);
foreach (clsvQxPotenceTypeEN objvQxPotenceTypeEN in lstvQxPotenceTypeObjLst)
{
clsvQxPotenceTypeBL.SerializeXML(writer, objvQxPotenceTypeEN);
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
 /// <param name = "objvQxPotenceTypeEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsvQxPotenceTypeEN objvQxPotenceTypeEN)
{
writer.WriteStartElement(clsvQxPotenceTypeBL.itemXmlNode);
 
if (objvQxPotenceTypeEN.PotenceTypeId != null)
{
writer.WriteElementString(convQxPotenceType.PotenceTypeId, objvQxPotenceTypeEN.PotenceTypeId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPotenceTypeEN.PotenceTypeName != null)
{
writer.WriteElementString(convQxPotenceType.PotenceTypeName, objvQxPotenceTypeEN.PotenceTypeName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPotenceTypeEN.QxPrjId != null)
{
writer.WriteElementString(convQxPotenceType.QxPrjId, objvQxPotenceTypeEN.QxPrjId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPotenceTypeEN.PrjName != null)
{
writer.WriteElementString(convQxPotenceType.PrjName, objvQxPotenceTypeEN.PrjName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPotenceTypeEN.FuncModuleId != null)
{
writer.WriteElementString(convQxPotenceType.FuncModuleId, objvQxPotenceTypeEN.FuncModuleId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPotenceTypeEN.FuncModuleName != null)
{
writer.WriteElementString(convQxPotenceType.FuncModuleName, objvQxPotenceTypeEN.FuncModuleName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPotenceTypeEN.FuncModuleNameSim != null)
{
writer.WriteElementString(convQxPotenceType.FuncModuleNameSim, objvQxPotenceTypeEN.FuncModuleNameSim.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convQxPotenceType.OrderNum, objvQxPotenceTypeEN.OrderNum.ToString());
 
writer.WriteElementString(convQxPotenceType.InUse, objvQxPotenceTypeEN.InUse.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objvQxPotenceTypeEN.ViewId != null)
{
writer.WriteElementString(convQxPotenceType.ViewId, objvQxPotenceTypeEN.ViewId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPotenceTypeEN.ViewName != null)
{
writer.WriteElementString(convQxPotenceType.ViewName, objvQxPotenceTypeEN.ViewName.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convQxPotenceType.IsVisible, objvQxPotenceTypeEN.IsVisible.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objvQxPotenceTypeEN.UpdDate != null)
{
writer.WriteElementString(convQxPotenceType.UpdDate, objvQxPotenceTypeEN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPotenceTypeEN.UpdUserId != null)
{
writer.WriteElementString(convQxPotenceType.UpdUserId, objvQxPotenceTypeEN.UpdUserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPotenceTypeEN.Memo != null)
{
writer.WriteElementString(convQxPotenceType.Memo, objvQxPotenceTypeEN.Memo.ToString(CultureInfo.InvariantCulture));
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
public static clsvQxPotenceTypeEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsvQxPotenceTypeEN objvQxPotenceTypeEN = new clsvQxPotenceTypeEN();
reader.Read();
while (!(reader.Name == clsvQxPotenceTypeBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(convQxPotenceType.PotenceTypeId))
{
objvQxPotenceTypeEN.PotenceTypeId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPotenceType.PotenceTypeName))
{
objvQxPotenceTypeEN.PotenceTypeName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPotenceType.QxPrjId))
{
objvQxPotenceTypeEN.QxPrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPotenceType.PrjName))
{
objvQxPotenceTypeEN.PrjName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPotenceType.FuncModuleId))
{
objvQxPotenceTypeEN.FuncModuleId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPotenceType.FuncModuleName))
{
objvQxPotenceTypeEN.FuncModuleName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPotenceType.FuncModuleNameSim))
{
objvQxPotenceTypeEN.FuncModuleNameSim = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPotenceType.OrderNum))
{
objvQxPotenceTypeEN.OrderNum = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(convQxPotenceType.InUse))
{
objvQxPotenceTypeEN.InUse = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(convQxPotenceType.ViewId))
{
objvQxPotenceTypeEN.ViewId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPotenceType.ViewName))
{
objvQxPotenceTypeEN.ViewName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPotenceType.IsVisible))
{
objvQxPotenceTypeEN.IsVisible = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(convQxPotenceType.UpdDate))
{
objvQxPotenceTypeEN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPotenceType.UpdUserId))
{
objvQxPotenceTypeEN.UpdUserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPotenceType.Memo))
{
objvQxPotenceTypeEN.Memo = reader.ReadElementContentAsString();
}
}
return objvQxPotenceTypeEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strvQxPotenceTypeObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsvQxPotenceTypeEN GetObjFromXmlStr(string strvQxPotenceTypeObjXmlStr)
{
clsvQxPotenceTypeEN objvQxPotenceTypeEN = new clsvQxPotenceTypeEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strvQxPotenceTypeObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsvQxPotenceTypeBL.itemXmlNode))
{
objvQxPotenceTypeEN = GetObjFromXml(reader);
return objvQxPotenceTypeEN;
}
}
return objvQxPotenceTypeEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objvQxPotenceTypeEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsvQxPotenceTypeEN objvQxPotenceTypeEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objvQxPotenceTypeEN);
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
public static string Func(string strInFldName, string strOutFldName, string strPotenceTypeId)
{
if (strInFldName != convQxPotenceType.PotenceTypeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convQxPotenceType.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convQxPotenceType.AttributeName));
throw new Exception(strMsg);
}
var objvQxPotenceType = clsvQxPotenceTypeBL.GetObjByPotenceTypeIdCache(strPotenceTypeId);
if (objvQxPotenceType == null) return "";
return objvQxPotenceType[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objvQxPotenceTypeEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsvQxPotenceTypeEN objvQxPotenceTypeEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsvQxPotenceTypeEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objvQxPotenceTypeEN[strField]);
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
 /// <param name = "lstvQxPotenceTypeObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsvQxPotenceTypeEN> lstvQxPotenceTypeObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstvQxPotenceTypeObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsvQxPotenceTypeEN objvQxPotenceTypeEN in lstvQxPotenceTypeObjLst)
{
string strJSON_One = SerializeObjToJSON(objvQxPotenceTypeEN);
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
int intRecCount = clsvQxPotenceTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsvQxPotenceTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvQxPotenceTypeDA.GetRecCount();
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
int intRecCount = clsvQxPotenceTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvQxPotenceTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvQxPotenceTypeEN objvQxPotenceTypeCond)
{
List<clsvQxPotenceTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPotenceTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxPotenceType.AttributeName)
{
if (objvQxPotenceTypeCond.IsUpdated(strFldName) == false) continue;
if (objvQxPotenceTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPotenceTypeCond[strFldName].ToString());
}
else
{
if (objvQxPotenceTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxPotenceTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPotenceTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxPotenceTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxPotenceTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxPotenceTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxPotenceTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxPotenceTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxPotenceTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxPotenceTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxPotenceTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxPotenceTypeCond[strFldName]));
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
 List<string> arrList = clsvQxPotenceTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vQxPotenceTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vQxPotenceTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}