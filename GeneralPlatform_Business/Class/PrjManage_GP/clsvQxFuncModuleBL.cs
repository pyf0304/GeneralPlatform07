
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxFuncModuleBL
 表名:vQxFuncModule(00140087)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:32:29
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:工程管理(PrjManage_GP)
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
public static class  clsvQxFuncModuleBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strFuncModuleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxFuncModuleEN GetObj(this K_FuncModuleId_vQxFuncModule myKey)
{
clsvQxFuncModuleEN objvQxFuncModuleEN = clsvQxFuncModuleBL.vQxFuncModuleDA.GetObjByFuncModuleId(myKey.Value);
return objvQxFuncModuleEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxFuncModuleEN SetFuncModuleId(this clsvQxFuncModuleEN objvQxFuncModuleEN, string strFuncModuleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convQxFuncModule.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convQxFuncModule.FuncModuleId);
}
objvQxFuncModuleEN.FuncModuleId = strFuncModuleId; //模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxFuncModuleEN.dicFldComparisonOp.ContainsKey(convQxFuncModule.FuncModuleId) == false)
{
objvQxFuncModuleEN.dicFldComparisonOp.Add(convQxFuncModule.FuncModuleId, strComparisonOp);
}
else
{
objvQxFuncModuleEN.dicFldComparisonOp[convQxFuncModule.FuncModuleId] = strComparisonOp;
}
}
return objvQxFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxFuncModuleEN SetFuncModuleName(this clsvQxFuncModuleEN objvQxFuncModuleEN, string strFuncModuleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convQxFuncModule.FuncModuleName);
}
objvQxFuncModuleEN.FuncModuleName = strFuncModuleName; //模块名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxFuncModuleEN.dicFldComparisonOp.ContainsKey(convQxFuncModule.FuncModuleName) == false)
{
objvQxFuncModuleEN.dicFldComparisonOp.Add(convQxFuncModule.FuncModuleName, strComparisonOp);
}
else
{
objvQxFuncModuleEN.dicFldComparisonOp[convQxFuncModule.FuncModuleName] = strComparisonOp;
}
}
return objvQxFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxFuncModuleEN SetFuncModuleNameSim(this clsvQxFuncModuleEN objvQxFuncModuleEN, string strFuncModuleNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleNameSim, 30, convQxFuncModule.FuncModuleNameSim);
}
objvQxFuncModuleEN.FuncModuleNameSim = strFuncModuleNameSim; //模块名_Sim
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxFuncModuleEN.dicFldComparisonOp.ContainsKey(convQxFuncModule.FuncModuleNameSim) == false)
{
objvQxFuncModuleEN.dicFldComparisonOp.Add(convQxFuncModule.FuncModuleNameSim, strComparisonOp);
}
else
{
objvQxFuncModuleEN.dicFldComparisonOp[convQxFuncModule.FuncModuleNameSim] = strComparisonOp;
}
}
return objvQxFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxFuncModuleEN SetFuncModuleEnName(this clsvQxFuncModuleEN objvQxFuncModuleEN, string strFuncModuleEnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleEnName, 30, convQxFuncModule.FuncModuleEnName);
}
objvQxFuncModuleEN.FuncModuleEnName = strFuncModuleEnName; //模块英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxFuncModuleEN.dicFldComparisonOp.ContainsKey(convQxFuncModule.FuncModuleEnName) == false)
{
objvQxFuncModuleEN.dicFldComparisonOp.Add(convQxFuncModule.FuncModuleEnName, strComparisonOp);
}
else
{
objvQxFuncModuleEN.dicFldComparisonOp[convQxFuncModule.FuncModuleEnName] = strComparisonOp;
}
}
return objvQxFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxFuncModuleEN SetOrderNum(this clsvQxFuncModuleEN objvQxFuncModuleEN, int? intOrderNum, string strComparisonOp="")
	{
objvQxFuncModuleEN.OrderNum = intOrderNum; //排序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxFuncModuleEN.dicFldComparisonOp.ContainsKey(convQxFuncModule.OrderNum) == false)
{
objvQxFuncModuleEN.dicFldComparisonOp.Add(convQxFuncModule.OrderNum, strComparisonOp);
}
else
{
objvQxFuncModuleEN.dicFldComparisonOp[convQxFuncModule.OrderNum] = strComparisonOp;
}
}
return objvQxFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxFuncModuleEN SetQxPrjId(this clsvQxFuncModuleEN objvQxFuncModuleEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, convQxFuncModule.QxPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxFuncModule.QxPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxFuncModule.QxPrjId);
}
objvQxFuncModuleEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxFuncModuleEN.dicFldComparisonOp.ContainsKey(convQxFuncModule.QxPrjId) == false)
{
objvQxFuncModuleEN.dicFldComparisonOp.Add(convQxFuncModule.QxPrjId, strComparisonOp);
}
else
{
objvQxFuncModuleEN.dicFldComparisonOp[convQxFuncModule.QxPrjId] = strComparisonOp;
}
}
return objvQxFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxFuncModuleEN SetPrjName(this clsvQxFuncModuleEN objvQxFuncModuleEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convQxFuncModule.PrjName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convQxFuncModule.PrjName);
}
objvQxFuncModuleEN.PrjName = strPrjName; //工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxFuncModuleEN.dicFldComparisonOp.ContainsKey(convQxFuncModule.PrjName) == false)
{
objvQxFuncModuleEN.dicFldComparisonOp.Add(convQxFuncModule.PrjName, strComparisonOp);
}
else
{
objvQxFuncModuleEN.dicFldComparisonOp[convQxFuncModule.PrjName] = strComparisonOp;
}
}
return objvQxFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxFuncModuleEN SetInUse(this clsvQxFuncModuleEN objvQxFuncModuleEN, bool bolInUse, string strComparisonOp="")
	{
objvQxFuncModuleEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxFuncModuleEN.dicFldComparisonOp.ContainsKey(convQxFuncModule.InUse) == false)
{
objvQxFuncModuleEN.dicFldComparisonOp.Add(convQxFuncModule.InUse, strComparisonOp);
}
else
{
objvQxFuncModuleEN.dicFldComparisonOp[convQxFuncModule.InUse] = strComparisonOp;
}
}
return objvQxFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxFuncModuleEN SetUpdDate(this clsvQxFuncModuleEN objvQxFuncModuleEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convQxFuncModule.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQxFuncModule.UpdDate);
}
objvQxFuncModuleEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxFuncModuleEN.dicFldComparisonOp.ContainsKey(convQxFuncModule.UpdDate) == false)
{
objvQxFuncModuleEN.dicFldComparisonOp.Add(convQxFuncModule.UpdDate, strComparisonOp);
}
else
{
objvQxFuncModuleEN.dicFldComparisonOp[convQxFuncModule.UpdDate] = strComparisonOp;
}
}
return objvQxFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxFuncModuleEN SetUpdUser(this clsvQxFuncModuleEN objvQxFuncModuleEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 18, convQxFuncModule.UpdUser);
}
objvQxFuncModuleEN.UpdUser = strUpdUser; //修改用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxFuncModuleEN.dicFldComparisonOp.ContainsKey(convQxFuncModule.UpdUser) == false)
{
objvQxFuncModuleEN.dicFldComparisonOp.Add(convQxFuncModule.UpdUser, strComparisonOp);
}
else
{
objvQxFuncModuleEN.dicFldComparisonOp[convQxFuncModule.UpdUser] = strComparisonOp;
}
}
return objvQxFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxFuncModuleEN SetMemo(this clsvQxFuncModuleEN objvQxFuncModuleEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxFuncModule.Memo);
}
objvQxFuncModuleEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxFuncModuleEN.dicFldComparisonOp.ContainsKey(convQxFuncModule.Memo) == false)
{
objvQxFuncModuleEN.dicFldComparisonOp.Add(convQxFuncModule.Memo, strComparisonOp);
}
else
{
objvQxFuncModuleEN.dicFldComparisonOp[convQxFuncModule.Memo] = strComparisonOp;
}
}
return objvQxFuncModuleEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvQxFuncModuleENS">源对象</param>
 /// <param name = "objvQxFuncModuleENT">目标对象</param>
 public static void CopyTo(this clsvQxFuncModuleEN objvQxFuncModuleENS, clsvQxFuncModuleEN objvQxFuncModuleENT)
{
try
{
objvQxFuncModuleENT.FuncModuleId = objvQxFuncModuleENS.FuncModuleId; //模块Id
objvQxFuncModuleENT.FuncModuleName = objvQxFuncModuleENS.FuncModuleName; //模块名
objvQxFuncModuleENT.FuncModuleNameSim = objvQxFuncModuleENS.FuncModuleNameSim; //模块名_Sim
objvQxFuncModuleENT.FuncModuleEnName = objvQxFuncModuleENS.FuncModuleEnName; //模块英文名
objvQxFuncModuleENT.OrderNum = objvQxFuncModuleENS.OrderNum; //排序号
objvQxFuncModuleENT.QxPrjId = objvQxFuncModuleENS.QxPrjId; //项目Id
objvQxFuncModuleENT.PrjName = objvQxFuncModuleENS.PrjName; //工程名
objvQxFuncModuleENT.InUse = objvQxFuncModuleENS.InUse; //是否在用
objvQxFuncModuleENT.UpdDate = objvQxFuncModuleENS.UpdDate; //修改日期
objvQxFuncModuleENT.UpdUser = objvQxFuncModuleENS.UpdUser; //修改用户
objvQxFuncModuleENT.Memo = objvQxFuncModuleENS.Memo; //备注
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
 /// <param name = "objvQxFuncModuleENS">源对象</param>
 /// <returns>目标对象=>clsvQxFuncModuleEN:objvQxFuncModuleENT</returns>
 public static clsvQxFuncModuleEN CopyTo(this clsvQxFuncModuleEN objvQxFuncModuleENS)
{
try
{
 clsvQxFuncModuleEN objvQxFuncModuleENT = new clsvQxFuncModuleEN()
{
FuncModuleId = objvQxFuncModuleENS.FuncModuleId, //模块Id
FuncModuleName = objvQxFuncModuleENS.FuncModuleName, //模块名
FuncModuleNameSim = objvQxFuncModuleENS.FuncModuleNameSim, //模块名_Sim
FuncModuleEnName = objvQxFuncModuleENS.FuncModuleEnName, //模块英文名
OrderNum = objvQxFuncModuleENS.OrderNum, //排序号
QxPrjId = objvQxFuncModuleENS.QxPrjId, //项目Id
PrjName = objvQxFuncModuleENS.PrjName, //工程名
InUse = objvQxFuncModuleENS.InUse, //是否在用
UpdDate = objvQxFuncModuleENS.UpdDate, //修改日期
UpdUser = objvQxFuncModuleENS.UpdUser, //修改用户
Memo = objvQxFuncModuleENS.Memo, //备注
};
 return objvQxFuncModuleENT;
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
public static void CheckProperty4Condition(this clsvQxFuncModuleEN objvQxFuncModuleEN)
{
 clsvQxFuncModuleBL.vQxFuncModuleDA.CheckProperty4Condition(objvQxFuncModuleEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQxFuncModuleEN objvQxFuncModuleCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQxFuncModuleCond.IsUpdated(convQxFuncModule.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objvQxFuncModuleCond.dicFldComparisonOp[convQxFuncModule.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxFuncModule.FuncModuleId, objvQxFuncModuleCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objvQxFuncModuleCond.IsUpdated(convQxFuncModule.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvQxFuncModuleCond.dicFldComparisonOp[convQxFuncModule.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxFuncModule.FuncModuleName, objvQxFuncModuleCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvQxFuncModuleCond.IsUpdated(convQxFuncModule.FuncModuleNameSim) == true)
{
string strComparisonOpFuncModuleNameSim = objvQxFuncModuleCond.dicFldComparisonOp[convQxFuncModule.FuncModuleNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxFuncModule.FuncModuleNameSim, objvQxFuncModuleCond.FuncModuleNameSim, strComparisonOpFuncModuleNameSim);
}
if (objvQxFuncModuleCond.IsUpdated(convQxFuncModule.FuncModuleEnName) == true)
{
string strComparisonOpFuncModuleEnName = objvQxFuncModuleCond.dicFldComparisonOp[convQxFuncModule.FuncModuleEnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxFuncModule.FuncModuleEnName, objvQxFuncModuleCond.FuncModuleEnName, strComparisonOpFuncModuleEnName);
}
if (objvQxFuncModuleCond.IsUpdated(convQxFuncModule.OrderNum) == true)
{
string strComparisonOpOrderNum = objvQxFuncModuleCond.dicFldComparisonOp[convQxFuncModule.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQxFuncModule.OrderNum, objvQxFuncModuleCond.OrderNum, strComparisonOpOrderNum);
}
if (objvQxFuncModuleCond.IsUpdated(convQxFuncModule.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objvQxFuncModuleCond.dicFldComparisonOp[convQxFuncModule.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxFuncModule.QxPrjId, objvQxFuncModuleCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objvQxFuncModuleCond.IsUpdated(convQxFuncModule.PrjName) == true)
{
string strComparisonOpPrjName = objvQxFuncModuleCond.dicFldComparisonOp[convQxFuncModule.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxFuncModule.PrjName, objvQxFuncModuleCond.PrjName, strComparisonOpPrjName);
}
if (objvQxFuncModuleCond.IsUpdated(convQxFuncModule.InUse) == true)
{
if (objvQxFuncModuleCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQxFuncModule.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQxFuncModule.InUse);
}
}
if (objvQxFuncModuleCond.IsUpdated(convQxFuncModule.UpdDate) == true)
{
string strComparisonOpUpdDate = objvQxFuncModuleCond.dicFldComparisonOp[convQxFuncModule.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxFuncModule.UpdDate, objvQxFuncModuleCond.UpdDate, strComparisonOpUpdDate);
}
if (objvQxFuncModuleCond.IsUpdated(convQxFuncModule.UpdUser) == true)
{
string strComparisonOpUpdUser = objvQxFuncModuleCond.dicFldComparisonOp[convQxFuncModule.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxFuncModule.UpdUser, objvQxFuncModuleCond.UpdUser, strComparisonOpUpdUser);
}
if (objvQxFuncModuleCond.IsUpdated(convQxFuncModule.Memo) == true)
{
string strComparisonOpMemo = objvQxFuncModuleCond.dicFldComparisonOp[convQxFuncModule.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxFuncModule.Memo, objvQxFuncModuleCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vQxFuncModule
{
public virtual bool UpdRelaTabDate(string strFuncModuleId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v功能模块(vQxFuncModule)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvQxFuncModuleBL
{
public static RelatedActions_vQxFuncModule relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "vQxFuncModuleListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "vQxFuncModuleList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsvQxFuncModuleEN> arrvQxFuncModuleObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvQxFuncModuleDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvQxFuncModuleDA vQxFuncModuleDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvQxFuncModuleDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvQxFuncModuleBL()
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
if (string.IsNullOrEmpty(clsvQxFuncModuleEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxFuncModuleEN._ConnectString);
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
objDS = vQxFuncModuleDA.GetDataSet(strWhereCond);
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
objDS = vQxFuncModuleDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = vQxFuncModuleDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_vQxFuncModule(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQxFuncModuleDA.GetDataTable_vQxFuncModule(strWhereCond);
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
objDT = vQxFuncModuleDA.GetDataTable(strWhereCond);
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
objDT = vQxFuncModuleDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vQxFuncModuleDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vQxFuncModuleDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vQxFuncModuleDA.GetDataTable_Top(objTopPara);
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
objDT = vQxFuncModuleDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vQxFuncModuleDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = vQxFuncModuleDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vQxFuncModuleDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = vQxFuncModuleDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = vQxFuncModuleDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = vQxFuncModuleDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = vQxFuncModuleDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
public static List<clsvQxFuncModuleEN> GetObjLstByFuncModuleIdLst(List<string> arrFuncModuleIdLst)
{
List<clsvQxFuncModuleEN> arrObjLst = new List<clsvQxFuncModuleEN>(); 
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
	clsvQxFuncModuleEN objvQxFuncModuleEN = new clsvQxFuncModuleEN();
try
{
objvQxFuncModuleEN.FuncModuleId = objRow[convQxFuncModule.FuncModuleId].ToString().Trim(); //模块Id
objvQxFuncModuleEN.FuncModuleName = objRow[convQxFuncModule.FuncModuleName] == DBNull.Value ? null : objRow[convQxFuncModule.FuncModuleName].ToString().Trim(); //模块名
objvQxFuncModuleEN.FuncModuleNameSim = objRow[convQxFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxFuncModule.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objvQxFuncModuleEN.FuncModuleEnName = objRow[convQxFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[convQxFuncModule.FuncModuleEnName].ToString().Trim(); //模块英文名
objvQxFuncModuleEN.OrderNum = objRow[convQxFuncModule.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxFuncModule.OrderNum].ToString().Trim()); //排序号
objvQxFuncModuleEN.QxPrjId = objRow[convQxFuncModule.QxPrjId].ToString().Trim(); //项目Id
objvQxFuncModuleEN.PrjName = objRow[convQxFuncModule.PrjName].ToString().Trim(); //工程名
objvQxFuncModuleEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxFuncModule.InUse].ToString().Trim()); //是否在用
objvQxFuncModuleEN.UpdDate = objRow[convQxFuncModule.UpdDate].ToString().Trim(); //修改日期
objvQxFuncModuleEN.UpdUser = objRow[convQxFuncModule.UpdUser] == DBNull.Value ? null : objRow[convQxFuncModule.UpdUser].ToString().Trim(); //修改用户
objvQxFuncModuleEN.Memo = objRow[convQxFuncModule.Memo] == DBNull.Value ? null : objRow[convQxFuncModule.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxFuncModuleEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxFuncModuleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrFuncModuleIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvQxFuncModuleEN> GetObjLstByFuncModuleIdLstCache(List<string> arrFuncModuleIdLst)
{
string strKey = string.Format("{0}", clsvQxFuncModuleEN._CurrTabName);
List<clsvQxFuncModuleEN> arrvQxFuncModuleObjLstCache = GetObjLstCache();
IEnumerable <clsvQxFuncModuleEN> arrvQxFuncModuleObjLst_Sel =
arrvQxFuncModuleObjLstCache
.Where(x => arrFuncModuleIdLst.Contains(x.FuncModuleId));
return arrvQxFuncModuleObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxFuncModuleEN> GetObjLst(string strWhereCond)
{
List<clsvQxFuncModuleEN> arrObjLst = new List<clsvQxFuncModuleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxFuncModuleEN objvQxFuncModuleEN = new clsvQxFuncModuleEN();
try
{
objvQxFuncModuleEN.FuncModuleId = objRow[convQxFuncModule.FuncModuleId].ToString().Trim(); //模块Id
objvQxFuncModuleEN.FuncModuleName = objRow[convQxFuncModule.FuncModuleName] == DBNull.Value ? null : objRow[convQxFuncModule.FuncModuleName].ToString().Trim(); //模块名
objvQxFuncModuleEN.FuncModuleNameSim = objRow[convQxFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxFuncModule.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objvQxFuncModuleEN.FuncModuleEnName = objRow[convQxFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[convQxFuncModule.FuncModuleEnName].ToString().Trim(); //模块英文名
objvQxFuncModuleEN.OrderNum = objRow[convQxFuncModule.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxFuncModule.OrderNum].ToString().Trim()); //排序号
objvQxFuncModuleEN.QxPrjId = objRow[convQxFuncModule.QxPrjId].ToString().Trim(); //项目Id
objvQxFuncModuleEN.PrjName = objRow[convQxFuncModule.PrjName].ToString().Trim(); //工程名
objvQxFuncModuleEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxFuncModule.InUse].ToString().Trim()); //是否在用
objvQxFuncModuleEN.UpdDate = objRow[convQxFuncModule.UpdDate].ToString().Trim(); //修改日期
objvQxFuncModuleEN.UpdUser = objRow[convQxFuncModule.UpdUser] == DBNull.Value ? null : objRow[convQxFuncModule.UpdUser].ToString().Trim(); //修改用户
objvQxFuncModuleEN.Memo = objRow[convQxFuncModule.Memo] == DBNull.Value ? null : objRow[convQxFuncModule.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxFuncModuleEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxFuncModuleEN);
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
public static List<clsvQxFuncModuleEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQxFuncModuleEN> arrObjLst = new List<clsvQxFuncModuleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxFuncModuleEN objvQxFuncModuleEN = new clsvQxFuncModuleEN();
try
{
objvQxFuncModuleEN.FuncModuleId = objRow[convQxFuncModule.FuncModuleId].ToString().Trim(); //模块Id
objvQxFuncModuleEN.FuncModuleName = objRow[convQxFuncModule.FuncModuleName] == DBNull.Value ? null : objRow[convQxFuncModule.FuncModuleName].ToString().Trim(); //模块名
objvQxFuncModuleEN.FuncModuleNameSim = objRow[convQxFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxFuncModule.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objvQxFuncModuleEN.FuncModuleEnName = objRow[convQxFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[convQxFuncModule.FuncModuleEnName].ToString().Trim(); //模块英文名
objvQxFuncModuleEN.OrderNum = objRow[convQxFuncModule.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxFuncModule.OrderNum].ToString().Trim()); //排序号
objvQxFuncModuleEN.QxPrjId = objRow[convQxFuncModule.QxPrjId].ToString().Trim(); //项目Id
objvQxFuncModuleEN.PrjName = objRow[convQxFuncModule.PrjName].ToString().Trim(); //工程名
objvQxFuncModuleEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxFuncModule.InUse].ToString().Trim()); //是否在用
objvQxFuncModuleEN.UpdDate = objRow[convQxFuncModule.UpdDate].ToString().Trim(); //修改日期
objvQxFuncModuleEN.UpdUser = objRow[convQxFuncModule.UpdUser] == DBNull.Value ? null : objRow[convQxFuncModule.UpdUser].ToString().Trim(); //修改用户
objvQxFuncModuleEN.Memo = objRow[convQxFuncModule.Memo] == DBNull.Value ? null : objRow[convQxFuncModule.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxFuncModuleEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxFuncModuleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvQxFuncModuleCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvQxFuncModuleEN> GetSubObjLstCache(clsvQxFuncModuleEN objvQxFuncModuleCond)
{
List<clsvQxFuncModuleEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxFuncModuleEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxFuncModule.AttributeName)
{
if (objvQxFuncModuleCond.IsUpdated(strFldName) == false) continue;
if (objvQxFuncModuleCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxFuncModuleCond[strFldName].ToString());
}
else
{
if (objvQxFuncModuleCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxFuncModuleCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxFuncModuleCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxFuncModuleCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxFuncModuleCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxFuncModuleCond[strFldName]));
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
public static List<clsvQxFuncModuleEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvQxFuncModuleEN> arrObjLst = new List<clsvQxFuncModuleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxFuncModuleEN objvQxFuncModuleEN = new clsvQxFuncModuleEN();
try
{
objvQxFuncModuleEN.FuncModuleId = objRow[convQxFuncModule.FuncModuleId].ToString().Trim(); //模块Id
objvQxFuncModuleEN.FuncModuleName = objRow[convQxFuncModule.FuncModuleName] == DBNull.Value ? null : objRow[convQxFuncModule.FuncModuleName].ToString().Trim(); //模块名
objvQxFuncModuleEN.FuncModuleNameSim = objRow[convQxFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxFuncModule.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objvQxFuncModuleEN.FuncModuleEnName = objRow[convQxFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[convQxFuncModule.FuncModuleEnName].ToString().Trim(); //模块英文名
objvQxFuncModuleEN.OrderNum = objRow[convQxFuncModule.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxFuncModule.OrderNum].ToString().Trim()); //排序号
objvQxFuncModuleEN.QxPrjId = objRow[convQxFuncModule.QxPrjId].ToString().Trim(); //项目Id
objvQxFuncModuleEN.PrjName = objRow[convQxFuncModule.PrjName].ToString().Trim(); //工程名
objvQxFuncModuleEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxFuncModule.InUse].ToString().Trim()); //是否在用
objvQxFuncModuleEN.UpdDate = objRow[convQxFuncModule.UpdDate].ToString().Trim(); //修改日期
objvQxFuncModuleEN.UpdUser = objRow[convQxFuncModule.UpdUser] == DBNull.Value ? null : objRow[convQxFuncModule.UpdUser].ToString().Trim(); //修改用户
objvQxFuncModuleEN.Memo = objRow[convQxFuncModule.Memo] == DBNull.Value ? null : objRow[convQxFuncModule.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxFuncModuleEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxFuncModuleEN);
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
public static List<clsvQxFuncModuleEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvQxFuncModuleEN> arrObjLst = new List<clsvQxFuncModuleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxFuncModuleEN objvQxFuncModuleEN = new clsvQxFuncModuleEN();
try
{
objvQxFuncModuleEN.FuncModuleId = objRow[convQxFuncModule.FuncModuleId].ToString().Trim(); //模块Id
objvQxFuncModuleEN.FuncModuleName = objRow[convQxFuncModule.FuncModuleName] == DBNull.Value ? null : objRow[convQxFuncModule.FuncModuleName].ToString().Trim(); //模块名
objvQxFuncModuleEN.FuncModuleNameSim = objRow[convQxFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxFuncModule.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objvQxFuncModuleEN.FuncModuleEnName = objRow[convQxFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[convQxFuncModule.FuncModuleEnName].ToString().Trim(); //模块英文名
objvQxFuncModuleEN.OrderNum = objRow[convQxFuncModule.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxFuncModule.OrderNum].ToString().Trim()); //排序号
objvQxFuncModuleEN.QxPrjId = objRow[convQxFuncModule.QxPrjId].ToString().Trim(); //项目Id
objvQxFuncModuleEN.PrjName = objRow[convQxFuncModule.PrjName].ToString().Trim(); //工程名
objvQxFuncModuleEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxFuncModule.InUse].ToString().Trim()); //是否在用
objvQxFuncModuleEN.UpdDate = objRow[convQxFuncModule.UpdDate].ToString().Trim(); //修改日期
objvQxFuncModuleEN.UpdUser = objRow[convQxFuncModule.UpdUser] == DBNull.Value ? null : objRow[convQxFuncModule.UpdUser].ToString().Trim(); //修改用户
objvQxFuncModuleEN.Memo = objRow[convQxFuncModule.Memo] == DBNull.Value ? null : objRow[convQxFuncModule.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxFuncModuleEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxFuncModuleEN);
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
List<clsvQxFuncModuleEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvQxFuncModuleEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxFuncModuleEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvQxFuncModuleEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvQxFuncModuleEN> arrObjLst = new List<clsvQxFuncModuleEN>(); 
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
	clsvQxFuncModuleEN objvQxFuncModuleEN = new clsvQxFuncModuleEN();
try
{
objvQxFuncModuleEN.FuncModuleId = objRow[convQxFuncModule.FuncModuleId].ToString().Trim(); //模块Id
objvQxFuncModuleEN.FuncModuleName = objRow[convQxFuncModule.FuncModuleName] == DBNull.Value ? null : objRow[convQxFuncModule.FuncModuleName].ToString().Trim(); //模块名
objvQxFuncModuleEN.FuncModuleNameSim = objRow[convQxFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxFuncModule.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objvQxFuncModuleEN.FuncModuleEnName = objRow[convQxFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[convQxFuncModule.FuncModuleEnName].ToString().Trim(); //模块英文名
objvQxFuncModuleEN.OrderNum = objRow[convQxFuncModule.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxFuncModule.OrderNum].ToString().Trim()); //排序号
objvQxFuncModuleEN.QxPrjId = objRow[convQxFuncModule.QxPrjId].ToString().Trim(); //项目Id
objvQxFuncModuleEN.PrjName = objRow[convQxFuncModule.PrjName].ToString().Trim(); //工程名
objvQxFuncModuleEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxFuncModule.InUse].ToString().Trim()); //是否在用
objvQxFuncModuleEN.UpdDate = objRow[convQxFuncModule.UpdDate].ToString().Trim(); //修改日期
objvQxFuncModuleEN.UpdUser = objRow[convQxFuncModule.UpdUser] == DBNull.Value ? null : objRow[convQxFuncModule.UpdUser].ToString().Trim(); //修改用户
objvQxFuncModuleEN.Memo = objRow[convQxFuncModule.Memo] == DBNull.Value ? null : objRow[convQxFuncModule.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxFuncModuleEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxFuncModuleEN);
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
public static List<clsvQxFuncModuleEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvQxFuncModuleEN> arrObjLst = new List<clsvQxFuncModuleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxFuncModuleEN objvQxFuncModuleEN = new clsvQxFuncModuleEN();
try
{
objvQxFuncModuleEN.FuncModuleId = objRow[convQxFuncModule.FuncModuleId].ToString().Trim(); //模块Id
objvQxFuncModuleEN.FuncModuleName = objRow[convQxFuncModule.FuncModuleName] == DBNull.Value ? null : objRow[convQxFuncModule.FuncModuleName].ToString().Trim(); //模块名
objvQxFuncModuleEN.FuncModuleNameSim = objRow[convQxFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxFuncModule.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objvQxFuncModuleEN.FuncModuleEnName = objRow[convQxFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[convQxFuncModule.FuncModuleEnName].ToString().Trim(); //模块英文名
objvQxFuncModuleEN.OrderNum = objRow[convQxFuncModule.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxFuncModule.OrderNum].ToString().Trim()); //排序号
objvQxFuncModuleEN.QxPrjId = objRow[convQxFuncModule.QxPrjId].ToString().Trim(); //项目Id
objvQxFuncModuleEN.PrjName = objRow[convQxFuncModule.PrjName].ToString().Trim(); //工程名
objvQxFuncModuleEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxFuncModule.InUse].ToString().Trim()); //是否在用
objvQxFuncModuleEN.UpdDate = objRow[convQxFuncModule.UpdDate].ToString().Trim(); //修改日期
objvQxFuncModuleEN.UpdUser = objRow[convQxFuncModule.UpdUser] == DBNull.Value ? null : objRow[convQxFuncModule.UpdUser].ToString().Trim(); //修改用户
objvQxFuncModuleEN.Memo = objRow[convQxFuncModule.Memo] == DBNull.Value ? null : objRow[convQxFuncModule.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxFuncModuleEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxFuncModuleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQxFuncModuleEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvQxFuncModuleEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvQxFuncModuleEN> arrObjLst = new List<clsvQxFuncModuleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxFuncModuleEN objvQxFuncModuleEN = new clsvQxFuncModuleEN();
try
{
objvQxFuncModuleEN.FuncModuleId = objRow[convQxFuncModule.FuncModuleId].ToString().Trim(); //模块Id
objvQxFuncModuleEN.FuncModuleName = objRow[convQxFuncModule.FuncModuleName] == DBNull.Value ? null : objRow[convQxFuncModule.FuncModuleName].ToString().Trim(); //模块名
objvQxFuncModuleEN.FuncModuleNameSim = objRow[convQxFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxFuncModule.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objvQxFuncModuleEN.FuncModuleEnName = objRow[convQxFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[convQxFuncModule.FuncModuleEnName].ToString().Trim(); //模块英文名
objvQxFuncModuleEN.OrderNum = objRow[convQxFuncModule.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxFuncModule.OrderNum].ToString().Trim()); //排序号
objvQxFuncModuleEN.QxPrjId = objRow[convQxFuncModule.QxPrjId].ToString().Trim(); //项目Id
objvQxFuncModuleEN.PrjName = objRow[convQxFuncModule.PrjName].ToString().Trim(); //工程名
objvQxFuncModuleEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxFuncModule.InUse].ToString().Trim()); //是否在用
objvQxFuncModuleEN.UpdDate = objRow[convQxFuncModule.UpdDate].ToString().Trim(); //修改日期
objvQxFuncModuleEN.UpdUser = objRow[convQxFuncModule.UpdUser] == DBNull.Value ? null : objRow[convQxFuncModule.UpdUser].ToString().Trim(); //修改用户
objvQxFuncModuleEN.Memo = objRow[convQxFuncModule.Memo] == DBNull.Value ? null : objRow[convQxFuncModule.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxFuncModuleEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxFuncModuleEN);
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
public static List<clsvQxFuncModuleEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvQxFuncModuleEN> arrObjLst = new List<clsvQxFuncModuleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxFuncModuleEN objvQxFuncModuleEN = new clsvQxFuncModuleEN();
try
{
objvQxFuncModuleEN.FuncModuleId = objRow[convQxFuncModule.FuncModuleId].ToString().Trim(); //模块Id
objvQxFuncModuleEN.FuncModuleName = objRow[convQxFuncModule.FuncModuleName] == DBNull.Value ? null : objRow[convQxFuncModule.FuncModuleName].ToString().Trim(); //模块名
objvQxFuncModuleEN.FuncModuleNameSim = objRow[convQxFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxFuncModule.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objvQxFuncModuleEN.FuncModuleEnName = objRow[convQxFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[convQxFuncModule.FuncModuleEnName].ToString().Trim(); //模块英文名
objvQxFuncModuleEN.OrderNum = objRow[convQxFuncModule.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxFuncModule.OrderNum].ToString().Trim()); //排序号
objvQxFuncModuleEN.QxPrjId = objRow[convQxFuncModule.QxPrjId].ToString().Trim(); //项目Id
objvQxFuncModuleEN.PrjName = objRow[convQxFuncModule.PrjName].ToString().Trim(); //工程名
objvQxFuncModuleEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxFuncModule.InUse].ToString().Trim()); //是否在用
objvQxFuncModuleEN.UpdDate = objRow[convQxFuncModule.UpdDate].ToString().Trim(); //修改日期
objvQxFuncModuleEN.UpdUser = objRow[convQxFuncModule.UpdUser] == DBNull.Value ? null : objRow[convQxFuncModule.UpdUser].ToString().Trim(); //修改用户
objvQxFuncModuleEN.Memo = objRow[convQxFuncModule.Memo] == DBNull.Value ? null : objRow[convQxFuncModule.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxFuncModuleEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxFuncModuleEN);
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
public static IEnumerable<clsvQxFuncModuleEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsvQxFuncModuleEN objvQxFuncModuleCond, string strOrderBy)
{
List<clsvQxFuncModuleEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxFuncModuleEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxFuncModule.AttributeName)
{
if (objvQxFuncModuleCond.IsUpdated(strFldName) == false) continue;
if (objvQxFuncModuleCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxFuncModuleCond[strFldName].ToString());
}
else
{
if (objvQxFuncModuleCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxFuncModuleCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxFuncModuleCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxFuncModuleCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxFuncModuleCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxFuncModuleCond[strFldName]));
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
public static IEnumerable<clsvQxFuncModuleEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsvQxFuncModuleEN objvQxFuncModuleCond = JsonConvert.DeserializeObject<clsvQxFuncModuleEN>(objPagerPara.whereCond);
if (objvQxFuncModuleCond.sfFldComparisonOp == null)
{
objvQxFuncModuleCond.dicFldComparisonOp = null;
}
else
{
objvQxFuncModuleCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objvQxFuncModuleCond.sfFldComparisonOp);
}
clsvQxFuncModuleBL.SetUpdFlag(objvQxFuncModuleCond);
 try
{
CheckProperty4Condition(objvQxFuncModuleCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsvQxFuncModuleBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objvQxFuncModuleCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxFuncModuleEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsvQxFuncModuleEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxFuncModuleEN> arrObjLst = new List<clsvQxFuncModuleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxFuncModuleEN objvQxFuncModuleEN = new clsvQxFuncModuleEN();
try
{
objvQxFuncModuleEN.FuncModuleId = objRow[convQxFuncModule.FuncModuleId].ToString().Trim(); //模块Id
objvQxFuncModuleEN.FuncModuleName = objRow[convQxFuncModule.FuncModuleName] == DBNull.Value ? null : objRow[convQxFuncModule.FuncModuleName].ToString().Trim(); //模块名
objvQxFuncModuleEN.FuncModuleNameSim = objRow[convQxFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxFuncModule.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objvQxFuncModuleEN.FuncModuleEnName = objRow[convQxFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[convQxFuncModule.FuncModuleEnName].ToString().Trim(); //模块英文名
objvQxFuncModuleEN.OrderNum = objRow[convQxFuncModule.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxFuncModule.OrderNum].ToString().Trim()); //排序号
objvQxFuncModuleEN.QxPrjId = objRow[convQxFuncModule.QxPrjId].ToString().Trim(); //项目Id
objvQxFuncModuleEN.PrjName = objRow[convQxFuncModule.PrjName].ToString().Trim(); //工程名
objvQxFuncModuleEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxFuncModule.InUse].ToString().Trim()); //是否在用
objvQxFuncModuleEN.UpdDate = objRow[convQxFuncModule.UpdDate].ToString().Trim(); //修改日期
objvQxFuncModuleEN.UpdUser = objRow[convQxFuncModule.UpdUser] == DBNull.Value ? null : objRow[convQxFuncModule.UpdUser].ToString().Trim(); //修改用户
objvQxFuncModuleEN.Memo = objRow[convQxFuncModule.Memo] == DBNull.Value ? null : objRow[convQxFuncModule.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxFuncModuleEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxFuncModuleEN);
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
public static List<clsvQxFuncModuleEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxFuncModuleEN> arrObjLst = new List<clsvQxFuncModuleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxFuncModuleEN objvQxFuncModuleEN = new clsvQxFuncModuleEN();
try
{
objvQxFuncModuleEN.FuncModuleId = objRow[convQxFuncModule.FuncModuleId].ToString().Trim(); //模块Id
objvQxFuncModuleEN.FuncModuleName = objRow[convQxFuncModule.FuncModuleName] == DBNull.Value ? null : objRow[convQxFuncModule.FuncModuleName].ToString().Trim(); //模块名
objvQxFuncModuleEN.FuncModuleNameSim = objRow[convQxFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxFuncModule.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objvQxFuncModuleEN.FuncModuleEnName = objRow[convQxFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[convQxFuncModule.FuncModuleEnName].ToString().Trim(); //模块英文名
objvQxFuncModuleEN.OrderNum = objRow[convQxFuncModule.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxFuncModule.OrderNum].ToString().Trim()); //排序号
objvQxFuncModuleEN.QxPrjId = objRow[convQxFuncModule.QxPrjId].ToString().Trim(); //项目Id
objvQxFuncModuleEN.PrjName = objRow[convQxFuncModule.PrjName].ToString().Trim(); //工程名
objvQxFuncModuleEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxFuncModule.InUse].ToString().Trim()); //是否在用
objvQxFuncModuleEN.UpdDate = objRow[convQxFuncModule.UpdDate].ToString().Trim(); //修改日期
objvQxFuncModuleEN.UpdUser = objRow[convQxFuncModule.UpdUser] == DBNull.Value ? null : objRow[convQxFuncModule.UpdUser].ToString().Trim(); //修改用户
objvQxFuncModuleEN.Memo = objRow[convQxFuncModule.Memo] == DBNull.Value ? null : objRow[convQxFuncModule.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxFuncModuleEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxFuncModuleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxFuncModuleEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvQxFuncModuleEN> arrObjLst = new List<clsvQxFuncModuleEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxFuncModuleEN objvQxFuncModuleEN = new clsvQxFuncModuleEN();
try
{
objvQxFuncModuleEN.FuncModuleId = objRow[convQxFuncModule.FuncModuleId].ToString().Trim(); //模块Id
objvQxFuncModuleEN.FuncModuleName = objRow[convQxFuncModule.FuncModuleName] == DBNull.Value ? null : objRow[convQxFuncModule.FuncModuleName].ToString().Trim(); //模块名
objvQxFuncModuleEN.FuncModuleNameSim = objRow[convQxFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxFuncModule.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objvQxFuncModuleEN.FuncModuleEnName = objRow[convQxFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[convQxFuncModule.FuncModuleEnName].ToString().Trim(); //模块英文名
objvQxFuncModuleEN.OrderNum = objRow[convQxFuncModule.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxFuncModule.OrderNum].ToString().Trim()); //排序号
objvQxFuncModuleEN.QxPrjId = objRow[convQxFuncModule.QxPrjId].ToString().Trim(); //项目Id
objvQxFuncModuleEN.PrjName = objRow[convQxFuncModule.PrjName].ToString().Trim(); //工程名
objvQxFuncModuleEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxFuncModule.InUse].ToString().Trim()); //是否在用
objvQxFuncModuleEN.UpdDate = objRow[convQxFuncModule.UpdDate].ToString().Trim(); //修改日期
objvQxFuncModuleEN.UpdUser = objRow[convQxFuncModule.UpdUser] == DBNull.Value ? null : objRow[convQxFuncModule.UpdUser].ToString().Trim(); //修改用户
objvQxFuncModuleEN.Memo = objRow[convQxFuncModule.Memo] == DBNull.Value ? null : objRow[convQxFuncModule.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxFuncModuleEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxFuncModuleEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvQxFuncModuleEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxFuncModule(ref clsvQxFuncModuleEN objvQxFuncModuleEN)
{
bool bolResult = vQxFuncModuleDA.GetvQxFuncModule(ref objvQxFuncModuleEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strFuncModuleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxFuncModuleEN GetObjByFuncModuleId(string strFuncModuleId)
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
clsvQxFuncModuleEN objvQxFuncModuleEN = vQxFuncModuleDA.GetObjByFuncModuleId(strFuncModuleId);
return objvQxFuncModuleEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvQxFuncModuleEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvQxFuncModuleEN objvQxFuncModuleEN = vQxFuncModuleDA.GetFirstObj(strWhereCond);
 return objvQxFuncModuleEN;
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
public static clsvQxFuncModuleEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvQxFuncModuleEN objvQxFuncModuleEN = vQxFuncModuleDA.GetObjByDataRow(objRow);
 return objvQxFuncModuleEN;
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
public static clsvQxFuncModuleEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvQxFuncModuleEN objvQxFuncModuleEN = vQxFuncModuleDA.GetObjByDataRow(objRow);
 return objvQxFuncModuleEN;
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
 /// <param name = "lstvQxFuncModuleObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxFuncModuleEN GetObjByFuncModuleIdFromList(string strFuncModuleId, List<clsvQxFuncModuleEN> lstvQxFuncModuleObjLst)
{
foreach (clsvQxFuncModuleEN objvQxFuncModuleEN in lstvQxFuncModuleObjLst)
{
if (objvQxFuncModuleEN.FuncModuleId == strFuncModuleId)
{
return objvQxFuncModuleEN;
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
 strFuncModuleId = new clsvQxFuncModuleDA().GetFirstID(strWhereCond);
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
 arrList = vQxFuncModuleDA.GetID(strWhereCond);
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
bool bolIsExist = vQxFuncModuleDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vQxFuncModuleDA.IsExist(strFuncModuleId);
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
 bolIsExist = clsvQxFuncModuleDA.IsExistTable();
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
 bolIsExist = vQxFuncModuleDA.IsExistTable(strTabName);
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
 /// <param name = "objvQxFuncModuleENS">源对象</param>
 /// <param name = "objvQxFuncModuleENT">目标对象</param>
 public static void CopyTo(clsvQxFuncModuleEN objvQxFuncModuleENS, clsvQxFuncModuleEN objvQxFuncModuleENT)
{
try
{
objvQxFuncModuleENT.FuncModuleId = objvQxFuncModuleENS.FuncModuleId; //模块Id
objvQxFuncModuleENT.FuncModuleName = objvQxFuncModuleENS.FuncModuleName; //模块名
objvQxFuncModuleENT.FuncModuleNameSim = objvQxFuncModuleENS.FuncModuleNameSim; //模块名_Sim
objvQxFuncModuleENT.FuncModuleEnName = objvQxFuncModuleENS.FuncModuleEnName; //模块英文名
objvQxFuncModuleENT.OrderNum = objvQxFuncModuleENS.OrderNum; //排序号
objvQxFuncModuleENT.QxPrjId = objvQxFuncModuleENS.QxPrjId; //项目Id
objvQxFuncModuleENT.PrjName = objvQxFuncModuleENS.PrjName; //工程名
objvQxFuncModuleENT.InUse = objvQxFuncModuleENS.InUse; //是否在用
objvQxFuncModuleENT.UpdDate = objvQxFuncModuleENS.UpdDate; //修改日期
objvQxFuncModuleENT.UpdUser = objvQxFuncModuleENS.UpdUser; //修改用户
objvQxFuncModuleENT.Memo = objvQxFuncModuleENS.Memo; //备注
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
 /// <param name = "objvQxFuncModuleEN">源简化对象</param>
 public static void SetUpdFlag(clsvQxFuncModuleEN objvQxFuncModuleEN)
{
try
{
objvQxFuncModuleEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvQxFuncModuleEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convQxFuncModule.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxFuncModuleEN.FuncModuleId = objvQxFuncModuleEN.FuncModuleId; //模块Id
}
if (arrFldSet.Contains(convQxFuncModule.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxFuncModuleEN.FuncModuleName = objvQxFuncModuleEN.FuncModuleName == "[null]" ? null :  objvQxFuncModuleEN.FuncModuleName; //模块名
}
if (arrFldSet.Contains(convQxFuncModule.FuncModuleNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxFuncModuleEN.FuncModuleNameSim = objvQxFuncModuleEN.FuncModuleNameSim == "[null]" ? null :  objvQxFuncModuleEN.FuncModuleNameSim; //模块名_Sim
}
if (arrFldSet.Contains(convQxFuncModule.FuncModuleEnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxFuncModuleEN.FuncModuleEnName = objvQxFuncModuleEN.FuncModuleEnName == "[null]" ? null :  objvQxFuncModuleEN.FuncModuleEnName; //模块英文名
}
if (arrFldSet.Contains(convQxFuncModule.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxFuncModuleEN.OrderNum = objvQxFuncModuleEN.OrderNum; //排序号
}
if (arrFldSet.Contains(convQxFuncModule.QxPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxFuncModuleEN.QxPrjId = objvQxFuncModuleEN.QxPrjId; //项目Id
}
if (arrFldSet.Contains(convQxFuncModule.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxFuncModuleEN.PrjName = objvQxFuncModuleEN.PrjName; //工程名
}
if (arrFldSet.Contains(convQxFuncModule.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxFuncModuleEN.InUse = objvQxFuncModuleEN.InUse; //是否在用
}
if (arrFldSet.Contains(convQxFuncModule.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxFuncModuleEN.UpdDate = objvQxFuncModuleEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convQxFuncModule.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxFuncModuleEN.UpdUser = objvQxFuncModuleEN.UpdUser == "[null]" ? null :  objvQxFuncModuleEN.UpdUser; //修改用户
}
if (arrFldSet.Contains(convQxFuncModule.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxFuncModuleEN.Memo = objvQxFuncModuleEN.Memo == "[null]" ? null :  objvQxFuncModuleEN.Memo; //备注
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
 /// <param name = "objvQxFuncModuleEN">源简化对象</param>
 public static void AccessFldValueNull(clsvQxFuncModuleEN objvQxFuncModuleEN)
{
try
{
if (objvQxFuncModuleEN.FuncModuleName == "[null]") objvQxFuncModuleEN.FuncModuleName = null; //模块名
if (objvQxFuncModuleEN.FuncModuleNameSim == "[null]") objvQxFuncModuleEN.FuncModuleNameSim = null; //模块名_Sim
if (objvQxFuncModuleEN.FuncModuleEnName == "[null]") objvQxFuncModuleEN.FuncModuleEnName = null; //模块英文名
if (objvQxFuncModuleEN.UpdUser == "[null]") objvQxFuncModuleEN.UpdUser = null; //修改用户
if (objvQxFuncModuleEN.Memo == "[null]") objvQxFuncModuleEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvQxFuncModuleEN objvQxFuncModuleEN)
{
 vQxFuncModuleDA.CheckProperty4Condition(objvQxFuncModuleEN);
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
string strCondition = string.Format("1 =1 Order By {0}", convQxFuncModule.FuncModuleId); 
List<clsvQxFuncModuleEN> arrObjLst = clsvQxFuncModuleBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvQxFuncModuleEN objvQxFuncModuleEN = new clsvQxFuncModuleEN()
{
FuncModuleId = "0",
FuncModuleName = "选[v功能模块]..."
};
arrObjLst.Insert(0, objvQxFuncModuleEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convQxFuncModule.FuncModuleId;
objComboBox.DisplayMember = convQxFuncModule.FuncModuleName;
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
string strCondition = string.Format("1 =1 Order By {0}", convQxFuncModule.FuncModuleId); 
IEnumerable<clsvQxFuncModuleEN> arrObjLst = clsvQxFuncModuleBL.GetObjLst(strCondition);
objDDL.DataValueField = convQxFuncModule.FuncModuleId;
objDDL.DataTextField = convQxFuncModule.FuncModuleName;
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
List<clsvQxFuncModuleEN> arrvQxFuncModuleObjLst = GetAllvQxFuncModuleObjLstCache(); 
objDDL.DataValueField = convQxFuncModule.FuncModuleId;
objDDL.DataTextField = convQxFuncModule.FuncModuleName;
objDDL.DataSource = arrvQxFuncModuleObjLst;
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
if (clsQxFuncModuleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxFuncModuleBL没有刷新缓存机制(clsQxFuncModuleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by FuncModuleId");
//if (arrvQxFuncModuleObjLstCache == null)
//{
//arrvQxFuncModuleObjLstCache = vQxFuncModuleDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strFuncModuleId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxFuncModuleEN GetObjByFuncModuleIdCache(string strFuncModuleId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvQxFuncModuleEN._CurrTabName);
List<clsvQxFuncModuleEN> arrvQxFuncModuleObjLstCache = GetObjLstCache();
IEnumerable <clsvQxFuncModuleEN> arrvQxFuncModuleObjLst_Sel =
arrvQxFuncModuleObjLstCache
.Where(x=> x.FuncModuleId == strFuncModuleId 
);
if (arrvQxFuncModuleObjLst_Sel.Count() == 0)
{
   clsvQxFuncModuleEN obj = clsvQxFuncModuleBL.GetObjByFuncModuleId(strFuncModuleId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvQxFuncModuleObjLst_Sel.First();
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
clsvQxFuncModuleEN objvQxFuncModule = GetObjByFuncModuleIdCache(strFuncModuleId);
if (objvQxFuncModule == null) return "";
return objvQxFuncModule.FuncModuleName;
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
clsvQxFuncModuleEN objvQxFuncModule = GetObjByFuncModuleIdCache(strFuncModuleId);
if (objvQxFuncModule == null) return "";
return objvQxFuncModule.FuncModuleName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxFuncModuleEN> GetAllvQxFuncModuleObjLstCache()
{
//获取缓存中的对象列表
List<clsvQxFuncModuleEN> arrvQxFuncModuleObjLstCache = GetObjLstCache(); 
return arrvQxFuncModuleObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxFuncModuleEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvQxFuncModuleEN._CurrTabName);
List<clsvQxFuncModuleEN> arrvQxFuncModuleObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQxFuncModuleObjLstCache;
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
string strKey = string.Format("{0}", clsvQxFuncModuleEN._CurrTabName);
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
 /// <param name = "lstvQxFuncModuleObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsvQxFuncModuleEN> lstvQxFuncModuleObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstvQxFuncModuleObjLst, writer);
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
 /// <param name = "lstvQxFuncModuleObjLst">[clsvQxFuncModuleEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsvQxFuncModuleEN> lstvQxFuncModuleObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsvQxFuncModuleBL.listXmlNode);
writer.WriteStartElement(clsvQxFuncModuleBL.itemsXmlNode);
foreach (clsvQxFuncModuleEN objvQxFuncModuleEN in lstvQxFuncModuleObjLst)
{
clsvQxFuncModuleBL.SerializeXML(writer, objvQxFuncModuleEN);
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
 /// <param name = "objvQxFuncModuleEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsvQxFuncModuleEN objvQxFuncModuleEN)
{
writer.WriteStartElement(clsvQxFuncModuleBL.itemXmlNode);
 
if (objvQxFuncModuleEN.FuncModuleId != null)
{
writer.WriteElementString(convQxFuncModule.FuncModuleId, objvQxFuncModuleEN.FuncModuleId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxFuncModuleEN.FuncModuleName != null)
{
writer.WriteElementString(convQxFuncModule.FuncModuleName, objvQxFuncModuleEN.FuncModuleName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxFuncModuleEN.FuncModuleNameSim != null)
{
writer.WriteElementString(convQxFuncModule.FuncModuleNameSim, objvQxFuncModuleEN.FuncModuleNameSim.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxFuncModuleEN.FuncModuleEnName != null)
{
writer.WriteElementString(convQxFuncModule.FuncModuleEnName, objvQxFuncModuleEN.FuncModuleEnName.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convQxFuncModule.OrderNum, objvQxFuncModuleEN.OrderNum.ToString());
 
if (objvQxFuncModuleEN.QxPrjId != null)
{
writer.WriteElementString(convQxFuncModule.QxPrjId, objvQxFuncModuleEN.QxPrjId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxFuncModuleEN.PrjName != null)
{
writer.WriteElementString(convQxFuncModule.PrjName, objvQxFuncModuleEN.PrjName.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convQxFuncModule.InUse, objvQxFuncModuleEN.InUse.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objvQxFuncModuleEN.UpdDate != null)
{
writer.WriteElementString(convQxFuncModule.UpdDate, objvQxFuncModuleEN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxFuncModuleEN.UpdUser != null)
{
writer.WriteElementString(convQxFuncModule.UpdUser, objvQxFuncModuleEN.UpdUser.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxFuncModuleEN.Memo != null)
{
writer.WriteElementString(convQxFuncModule.Memo, objvQxFuncModuleEN.Memo.ToString(CultureInfo.InvariantCulture));
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
public static clsvQxFuncModuleEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsvQxFuncModuleEN objvQxFuncModuleEN = new clsvQxFuncModuleEN();
reader.Read();
while (!(reader.Name == clsvQxFuncModuleBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(convQxFuncModule.FuncModuleId))
{
objvQxFuncModuleEN.FuncModuleId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxFuncModule.FuncModuleName))
{
objvQxFuncModuleEN.FuncModuleName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxFuncModule.FuncModuleNameSim))
{
objvQxFuncModuleEN.FuncModuleNameSim = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxFuncModule.FuncModuleEnName))
{
objvQxFuncModuleEN.FuncModuleEnName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxFuncModule.OrderNum))
{
objvQxFuncModuleEN.OrderNum = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(convQxFuncModule.QxPrjId))
{
objvQxFuncModuleEN.QxPrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxFuncModule.PrjName))
{
objvQxFuncModuleEN.PrjName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxFuncModule.InUse))
{
objvQxFuncModuleEN.InUse = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(convQxFuncModule.UpdDate))
{
objvQxFuncModuleEN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxFuncModule.UpdUser))
{
objvQxFuncModuleEN.UpdUser = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxFuncModule.Memo))
{
objvQxFuncModuleEN.Memo = reader.ReadElementContentAsString();
}
}
return objvQxFuncModuleEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strvQxFuncModuleObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsvQxFuncModuleEN GetObjFromXmlStr(string strvQxFuncModuleObjXmlStr)
{
clsvQxFuncModuleEN objvQxFuncModuleEN = new clsvQxFuncModuleEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strvQxFuncModuleObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsvQxFuncModuleBL.itemXmlNode))
{
objvQxFuncModuleEN = GetObjFromXml(reader);
return objvQxFuncModuleEN;
}
}
return objvQxFuncModuleEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objvQxFuncModuleEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsvQxFuncModuleEN objvQxFuncModuleEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objvQxFuncModuleEN);
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
if (strInFldName != convQxFuncModule.FuncModuleId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convQxFuncModule.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convQxFuncModule.AttributeName));
throw new Exception(strMsg);
}
var objvQxFuncModule = clsvQxFuncModuleBL.GetObjByFuncModuleIdCache(strFuncModuleId);
if (objvQxFuncModule == null) return "";
return objvQxFuncModule[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objvQxFuncModuleEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsvQxFuncModuleEN objvQxFuncModuleEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsvQxFuncModuleEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objvQxFuncModuleEN[strField]);
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
 /// <param name = "lstvQxFuncModuleObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsvQxFuncModuleEN> lstvQxFuncModuleObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstvQxFuncModuleObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsvQxFuncModuleEN objvQxFuncModuleEN in lstvQxFuncModuleObjLst)
{
string strJSON_One = SerializeObjToJSON(objvQxFuncModuleEN);
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
int intRecCount = clsvQxFuncModuleDA.GetRecCount(strTabName);
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
int intRecCount = clsvQxFuncModuleDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvQxFuncModuleDA.GetRecCount();
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
int intRecCount = clsvQxFuncModuleDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvQxFuncModuleCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvQxFuncModuleEN objvQxFuncModuleCond)
{
List<clsvQxFuncModuleEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxFuncModuleEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxFuncModule.AttributeName)
{
if (objvQxFuncModuleCond.IsUpdated(strFldName) == false) continue;
if (objvQxFuncModuleCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxFuncModuleCond[strFldName].ToString());
}
else
{
if (objvQxFuncModuleCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxFuncModuleCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxFuncModuleCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxFuncModuleCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxFuncModuleCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxFuncModuleCond[strFldName]));
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
 List<string> arrList = clsvQxFuncModuleDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vQxFuncModuleDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vQxFuncModuleDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}