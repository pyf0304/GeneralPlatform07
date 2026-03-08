
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxRelaOfPotenceAndSymbolWApi
 表名:QxRelaOfPotenceAndSymbol(00140020)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 18:21:55
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
public static class  clsQxRelaOfPotenceAndSymbolWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRelaOfPotenceAndSymbolEN">需要设置字段值的实体对象</param>
 /// <param name = "lngRelaMid">流水号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRelaOfPotenceAndSymbolEN SetRelaMid(this clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN, long lngRelaMid, string strComparisonOp="")
	{
objQxRelaOfPotenceAndSymbolEN.RelaMid = lngRelaMid; //流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp.ContainsKey(conQxRelaOfPotenceAndSymbol.RelaMid) == false)
{
objQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp.Add(conQxRelaOfPotenceAndSymbol.RelaMid, strComparisonOp);
}
else
{
objQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp[conQxRelaOfPotenceAndSymbol.RelaMid] = strComparisonOp;
}
}
return objQxRelaOfPotenceAndSymbolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRelaOfPotenceAndSymbolEN">需要设置字段值的实体对象</param>
 /// <param name = "strPotenceId">权限ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRelaOfPotenceAndSymbolEN SetPotenceId(this clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN, string strPotenceId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPotenceId, conQxRelaOfPotenceAndSymbol.PotenceId);
clsCheckSql.CheckFieldLen(strPotenceId, 8, conQxRelaOfPotenceAndSymbol.PotenceId);
clsCheckSql.CheckFieldForeignKey(strPotenceId, 8, conQxRelaOfPotenceAndSymbol.PotenceId);
objQxRelaOfPotenceAndSymbolEN.PotenceId = strPotenceId; //权限ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp.ContainsKey(conQxRelaOfPotenceAndSymbol.PotenceId) == false)
{
objQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp.Add(conQxRelaOfPotenceAndSymbol.PotenceId, strComparisonOp);
}
else
{
objQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp[conQxRelaOfPotenceAndSymbol.PotenceId] = strComparisonOp;
}
}
return objQxRelaOfPotenceAndSymbolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRelaOfPotenceAndSymbolEN">需要设置字段值的实体对象</param>
 /// <param name = "strSymbolForProgramme">编程标志</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRelaOfPotenceAndSymbolEN SetSymbolForProgramme(this clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN, string strSymbolForProgramme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSymbolForProgramme, conQxRelaOfPotenceAndSymbol.SymbolForProgramme);
clsCheckSql.CheckFieldLen(strSymbolForProgramme, 20, conQxRelaOfPotenceAndSymbol.SymbolForProgramme);
objQxRelaOfPotenceAndSymbolEN.SymbolForProgramme = strSymbolForProgramme; //编程标志
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp.ContainsKey(conQxRelaOfPotenceAndSymbol.SymbolForProgramme) == false)
{
objQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp.Add(conQxRelaOfPotenceAndSymbol.SymbolForProgramme, strComparisonOp);
}
else
{
objQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp[conQxRelaOfPotenceAndSymbol.SymbolForProgramme] = strComparisonOp;
}
}
return objQxRelaOfPotenceAndSymbolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRelaOfPotenceAndSymbolEN">需要设置字段值的实体对象</param>
 /// <param name = "strSymbolName">标志名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRelaOfPotenceAndSymbolEN SetSymbolName(this clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN, string strSymbolName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSymbolName, 200, conQxRelaOfPotenceAndSymbol.SymbolName);
objQxRelaOfPotenceAndSymbolEN.SymbolName = strSymbolName; //标志名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp.ContainsKey(conQxRelaOfPotenceAndSymbol.SymbolName) == false)
{
objQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp.Add(conQxRelaOfPotenceAndSymbol.SymbolName, strComparisonOp);
}
else
{
objQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp[conQxRelaOfPotenceAndSymbol.SymbolName] = strComparisonOp;
}
}
return objQxRelaOfPotenceAndSymbolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRelaOfPotenceAndSymbolEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">备注</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRelaOfPotenceAndSymbolEN SetMemo(this clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQxRelaOfPotenceAndSymbol.Memo);
objQxRelaOfPotenceAndSymbolEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp.ContainsKey(conQxRelaOfPotenceAndSymbol.Memo) == false)
{
objQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp.Add(conQxRelaOfPotenceAndSymbol.Memo, strComparisonOp);
}
else
{
objQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp[conQxRelaOfPotenceAndSymbol.Memo] = strComparisonOp;
}
}
return objQxRelaOfPotenceAndSymbolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRelaOfPotenceAndSymbolEN">需要设置字段值的实体对象</param>
 /// <param name = "strQxPrjId">项目Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRelaOfPotenceAndSymbolEN SetQxPrjId(this clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, conQxRelaOfPotenceAndSymbol.QxPrjId);
clsCheckSql.CheckFieldLen(strQxPrjId, 4, conQxRelaOfPotenceAndSymbol.QxPrjId);
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, conQxRelaOfPotenceAndSymbol.QxPrjId);
objQxRelaOfPotenceAndSymbolEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp.ContainsKey(conQxRelaOfPotenceAndSymbol.QxPrjId) == false)
{
objQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp.Add(conQxRelaOfPotenceAndSymbol.QxPrjId, strComparisonOp);
}
else
{
objQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp[conQxRelaOfPotenceAndSymbol.QxPrjId] = strComparisonOp;
}
}
return objQxRelaOfPotenceAndSymbolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRelaOfPotenceAndSymbolEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRelaOfPotenceAndSymbolEN SetUpdDate(this clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conQxRelaOfPotenceAndSymbol.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQxRelaOfPotenceAndSymbol.UpdDate);
objQxRelaOfPotenceAndSymbolEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp.ContainsKey(conQxRelaOfPotenceAndSymbol.UpdDate) == false)
{
objQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp.Add(conQxRelaOfPotenceAndSymbol.UpdDate, strComparisonOp);
}
else
{
objQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp[conQxRelaOfPotenceAndSymbol.UpdDate] = strComparisonOp;
}
}
return objQxRelaOfPotenceAndSymbolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRelaOfPotenceAndSymbolEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRelaOfPotenceAndSymbolEN SetUpdUserId(this clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUserId, conQxRelaOfPotenceAndSymbol.UpdUserId);
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conQxRelaOfPotenceAndSymbol.UpdUserId);
objQxRelaOfPotenceAndSymbolEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp.ContainsKey(conQxRelaOfPotenceAndSymbol.UpdUserId) == false)
{
objQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp.Add(conQxRelaOfPotenceAndSymbol.UpdUserId, strComparisonOp);
}
else
{
objQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp[conQxRelaOfPotenceAndSymbol.UpdUserId] = strComparisonOp;
}
}
return objQxRelaOfPotenceAndSymbolEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQxRelaOfPotenceAndSymbolCond.IsUpdated(conQxRelaOfPotenceAndSymbol.RelaMid) == true)
{
string strComparisonOpRelaMid = objQxRelaOfPotenceAndSymbolCond.dicFldComparisonOp[conQxRelaOfPotenceAndSymbol.RelaMid];
strWhereCond += string.Format(" And {0} {2} {1}", conQxRelaOfPotenceAndSymbol.RelaMid, objQxRelaOfPotenceAndSymbolCond.RelaMid, strComparisonOpRelaMid);
}
if (objQxRelaOfPotenceAndSymbolCond.IsUpdated(conQxRelaOfPotenceAndSymbol.PotenceId) == true)
{
string strComparisonOpPotenceId = objQxRelaOfPotenceAndSymbolCond.dicFldComparisonOp[conQxRelaOfPotenceAndSymbol.PotenceId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxRelaOfPotenceAndSymbol.PotenceId, objQxRelaOfPotenceAndSymbolCond.PotenceId, strComparisonOpPotenceId);
}
if (objQxRelaOfPotenceAndSymbolCond.IsUpdated(conQxRelaOfPotenceAndSymbol.SymbolForProgramme) == true)
{
string strComparisonOpSymbolForProgramme = objQxRelaOfPotenceAndSymbolCond.dicFldComparisonOp[conQxRelaOfPotenceAndSymbol.SymbolForProgramme];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxRelaOfPotenceAndSymbol.SymbolForProgramme, objQxRelaOfPotenceAndSymbolCond.SymbolForProgramme, strComparisonOpSymbolForProgramme);
}
if (objQxRelaOfPotenceAndSymbolCond.IsUpdated(conQxRelaOfPotenceAndSymbol.SymbolName) == true)
{
string strComparisonOpSymbolName = objQxRelaOfPotenceAndSymbolCond.dicFldComparisonOp[conQxRelaOfPotenceAndSymbol.SymbolName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxRelaOfPotenceAndSymbol.SymbolName, objQxRelaOfPotenceAndSymbolCond.SymbolName, strComparisonOpSymbolName);
}
if (objQxRelaOfPotenceAndSymbolCond.IsUpdated(conQxRelaOfPotenceAndSymbol.Memo) == true)
{
string strComparisonOpMemo = objQxRelaOfPotenceAndSymbolCond.dicFldComparisonOp[conQxRelaOfPotenceAndSymbol.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxRelaOfPotenceAndSymbol.Memo, objQxRelaOfPotenceAndSymbolCond.Memo, strComparisonOpMemo);
}
if (objQxRelaOfPotenceAndSymbolCond.IsUpdated(conQxRelaOfPotenceAndSymbol.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objQxRelaOfPotenceAndSymbolCond.dicFldComparisonOp[conQxRelaOfPotenceAndSymbol.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxRelaOfPotenceAndSymbol.QxPrjId, objQxRelaOfPotenceAndSymbolCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objQxRelaOfPotenceAndSymbolCond.IsUpdated(conQxRelaOfPotenceAndSymbol.UpdDate) == true)
{
string strComparisonOpUpdDate = objQxRelaOfPotenceAndSymbolCond.dicFldComparisonOp[conQxRelaOfPotenceAndSymbol.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxRelaOfPotenceAndSymbol.UpdDate, objQxRelaOfPotenceAndSymbolCond.UpdDate, strComparisonOpUpdDate);
}
if (objQxRelaOfPotenceAndSymbolCond.IsUpdated(conQxRelaOfPotenceAndSymbol.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objQxRelaOfPotenceAndSymbolCond.dicFldComparisonOp[conQxRelaOfPotenceAndSymbol.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxRelaOfPotenceAndSymbol.UpdUserId, objQxRelaOfPotenceAndSymbolCond.UpdUserId, strComparisonOpUpdUserId);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objQxRelaOfPotenceAndSymbolEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN)
{
 if (objQxRelaOfPotenceAndSymbolEN.RelaMid == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objQxRelaOfPotenceAndSymbolEN.sfUpdFldSetStr = objQxRelaOfPotenceAndSymbolEN.getsfUpdFldSetStr();
clsQxRelaOfPotenceAndSymbolWApi.CheckPropertyNew(objQxRelaOfPotenceAndSymbolEN); 
bool bolResult = clsQxRelaOfPotenceAndSymbolWApi.UpdateRecord(objQxRelaOfPotenceAndSymbolEN);
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
 /// 获取唯一性条件串--QxRelaOfPotenceAndSymbol(权限编程标志关系), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PotenceId_SymbolForProgramme_SymbolName
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objQxRelaOfPotenceAndSymbolEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objQxRelaOfPotenceAndSymbolEN == null) return "";
if (objQxRelaOfPotenceAndSymbolEN.RelaMid == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PotenceId = '{0}'", objQxRelaOfPotenceAndSymbolEN.PotenceId);
 sbCondition.AppendFormat(" and SymbolForProgramme = '{0}'", objQxRelaOfPotenceAndSymbolEN.SymbolForProgramme);
 sbCondition.AppendFormat(" and SymbolName = '{0}'", objQxRelaOfPotenceAndSymbolEN.SymbolName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("RelaMid !=  {0}", objQxRelaOfPotenceAndSymbolEN.RelaMid);
 sbCondition.AppendFormat(" and PotenceId = '{0}'", objQxRelaOfPotenceAndSymbolEN.PotenceId);
 sbCondition.AppendFormat(" and SymbolForProgramme = '{0}'", objQxRelaOfPotenceAndSymbolEN.SymbolForProgramme);
 sbCondition.AppendFormat(" and SymbolName = '{0}'", objQxRelaOfPotenceAndSymbolEN.SymbolName);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQxRelaOfPotenceAndSymbolEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN)
{
try
{
clsQxRelaOfPotenceAndSymbolWApi.CheckPropertyNew(objQxRelaOfPotenceAndSymbolEN); 
bool bolResult = clsQxRelaOfPotenceAndSymbolWApi.AddNewRecord(objQxRelaOfPotenceAndSymbolEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRelaOfPotenceAndSymbolWApi.ReFreshCache();
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
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objQxRelaOfPotenceAndSymbolEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN, string strWhereCond)
{
try
{
clsQxRelaOfPotenceAndSymbolWApi.CheckPropertyNew(objQxRelaOfPotenceAndSymbolEN); 
bool bolResult = clsQxRelaOfPotenceAndSymbolWApi.UpdateWithCondition(objQxRelaOfPotenceAndSymbolEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRelaOfPotenceAndSymbolWApi.ReFreshCache();
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
 /// 权限编程标志关系(QxRelaOfPotenceAndSymbol)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsQxRelaOfPotenceAndSymbolWApi
{
private static readonly string mstrApiControllerName = "QxRelaOfPotenceAndSymbolApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsQxRelaOfPotenceAndSymbolWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN)
{
if (!Object.Equals(null, objQxRelaOfPotenceAndSymbolEN.PotenceId) && GetStrLen(objQxRelaOfPotenceAndSymbolEN.PotenceId) > 8)
{
 throw new Exception("字段[权限ID]的长度不能超过8!");
}
if (!Object.Equals(null, objQxRelaOfPotenceAndSymbolEN.SymbolForProgramme) && GetStrLen(objQxRelaOfPotenceAndSymbolEN.SymbolForProgramme) > 20)
{
 throw new Exception("字段[编程标志]的长度不能超过20!");
}
if (!Object.Equals(null, objQxRelaOfPotenceAndSymbolEN.SymbolName) && GetStrLen(objQxRelaOfPotenceAndSymbolEN.SymbolName) > 200)
{
 throw new Exception("字段[标志名称]的长度不能超过200!");
}
if (!Object.Equals(null, objQxRelaOfPotenceAndSymbolEN.Memo) && GetStrLen(objQxRelaOfPotenceAndSymbolEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
if (!Object.Equals(null, objQxRelaOfPotenceAndSymbolEN.QxPrjId) && GetStrLen(objQxRelaOfPotenceAndSymbolEN.QxPrjId) > 4)
{
 throw new Exception("字段[项目Id]的长度不能超过4!");
}
if (!Object.Equals(null, objQxRelaOfPotenceAndSymbolEN.UpdDate) && GetStrLen(objQxRelaOfPotenceAndSymbolEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objQxRelaOfPotenceAndSymbolEN.UpdUserId) && GetStrLen(objQxRelaOfPotenceAndSymbolEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
 objQxRelaOfPotenceAndSymbolEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngRelaMid">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxRelaOfPotenceAndSymbolEN GetObjByRelaMid(long lngRelaMid)
{
string strAction = "GetObjByRelaMid";
clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngRelaMid"] = lngRelaMid.ToString(),
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objQxRelaOfPotenceAndSymbolEN = JsonConvert.DeserializeObject<clsQxRelaOfPotenceAndSymbolEN>(strJson);
return objQxRelaOfPotenceAndSymbolEN;
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
public static long GetFirstID(string strWhereCond)
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
return long.Parse(strReturnStr);
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
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsQxRelaOfPotenceAndSymbolEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN;
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
objQxRelaOfPotenceAndSymbolEN = JsonConvert.DeserializeObject<clsQxRelaOfPotenceAndSymbolEN>(strJson);
return objQxRelaOfPotenceAndSymbolEN;
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
public static List<clsQxRelaOfPotenceAndSymbolEN> GetObjLst(string strWhereCond)
{
 List<clsQxRelaOfPotenceAndSymbolEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxRelaOfPotenceAndSymbolEN>>(strJson);
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
 /// <param name = "arrRelaMid">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxRelaOfPotenceAndSymbolEN> GetObjLstByRelaMidLst(List<long> arrRelaMid)
{
 List<clsQxRelaOfPotenceAndSymbolEN> arrObjLst; 
string strAction = "GetObjLstByRelaMidLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrRelaMid);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsQxRelaOfPotenceAndSymbolEN>>(strJson);
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
public static List<clsQxRelaOfPotenceAndSymbolEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsQxRelaOfPotenceAndSymbolEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxRelaOfPotenceAndSymbolEN>>(strJson);
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
public static List<clsQxRelaOfPotenceAndSymbolEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsQxRelaOfPotenceAndSymbolEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxRelaOfPotenceAndSymbolEN>>(strJson);
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
public static List<clsQxRelaOfPotenceAndSymbolEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsQxRelaOfPotenceAndSymbolEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxRelaOfPotenceAndSymbolEN>>(strJson);
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
public static List<clsQxRelaOfPotenceAndSymbolEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsQxRelaOfPotenceAndSymbolEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxRelaOfPotenceAndSymbolEN>>(strJson);
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
public static int DelRecord(long lngRelaMid)
{
string strAction = "DelRecord";
try
{
 clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN = clsQxRelaOfPotenceAndSymbolWApi.GetObjByRelaMid(lngRelaMid);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngRelaMid.ToString(), out string strResult, out string strErrMsg) == true)
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
public static int DelQxRelaOfPotenceAndSymbols(List<string> arrRelaMid)
{
string strAction = "DelQxRelaOfPotenceAndSymbols";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrRelaMid);
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
public static int DelQxRelaOfPotenceAndSymbolsByCond(string strWhereCond)
{
string strAction = "DelQxRelaOfPotenceAndSymbolsByCond";
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
public static bool AddNewRecord(clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxRelaOfPotenceAndSymbolEN>(objQxRelaOfPotenceAndSymbolEN);
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
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objQxRelaOfPotenceAndSymbolEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxRelaOfPotenceAndSymbolEN>(objQxRelaOfPotenceAndSymbolEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN)
{
if (string.IsNullOrEmpty(objQxRelaOfPotenceAndSymbolEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objQxRelaOfPotenceAndSymbolEN.RelaMid, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxRelaOfPotenceAndSymbolEN>(objQxRelaOfPotenceAndSymbolEN);
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
 /// <param name = "objQxRelaOfPotenceAndSymbolEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objQxRelaOfPotenceAndSymbolEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objQxRelaOfPotenceAndSymbolEN.RelaMid, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objQxRelaOfPotenceAndSymbolEN.RelaMid, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxRelaOfPotenceAndSymbolEN>(objQxRelaOfPotenceAndSymbolEN);
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
public static bool IsExist(long lngRelaMid)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngRelaMid"] = lngRelaMid.ToString()
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
 /// <param name = "objQxRelaOfPotenceAndSymbolENS">源对象</param>
 /// <param name = "objQxRelaOfPotenceAndSymbolENT">目标对象</param>
 public static void CopyTo(clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolENS, clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolENT)
{
try
{
objQxRelaOfPotenceAndSymbolENT.RelaMid = objQxRelaOfPotenceAndSymbolENS.RelaMid; //流水号
objQxRelaOfPotenceAndSymbolENT.PotenceId = objQxRelaOfPotenceAndSymbolENS.PotenceId; //权限ID
objQxRelaOfPotenceAndSymbolENT.SymbolForProgramme = objQxRelaOfPotenceAndSymbolENS.SymbolForProgramme; //编程标志
objQxRelaOfPotenceAndSymbolENT.SymbolName = objQxRelaOfPotenceAndSymbolENS.SymbolName; //标志名称
objQxRelaOfPotenceAndSymbolENT.Memo = objQxRelaOfPotenceAndSymbolENS.Memo; //备注
objQxRelaOfPotenceAndSymbolENT.QxPrjId = objQxRelaOfPotenceAndSymbolENS.QxPrjId; //项目Id
objQxRelaOfPotenceAndSymbolENT.UpdDate = objQxRelaOfPotenceAndSymbolENS.UpdDate; //修改日期
objQxRelaOfPotenceAndSymbolENT.UpdUserId = objQxRelaOfPotenceAndSymbolENS.UpdUserId; //修改用户Id
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
public static DataTable ToDataTable(List<clsQxRelaOfPotenceAndSymbolEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsQxRelaOfPotenceAndSymbolEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsQxRelaOfPotenceAndSymbolEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsQxRelaOfPotenceAndSymbolEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsQxRelaOfPotenceAndSymbolEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsQxRelaOfPotenceAndSymbolEN.AttributeName)
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
string strKey = string.Format("{0}", clsQxRelaOfPotenceAndSymbolEN._CurrTabName);
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
if (clsQxRelaOfPotenceAndSymbolWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsQxRelaOfPotenceAndSymbolEN._CurrTabName);
CacheHelper.Remove(strKey);
clsQxRelaOfPotenceAndSymbolWApi.objCommFun4WApi.ReFreshCache();
}
}
//该表没有使用Cache,不需要生成[GetObjLstCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsQxRelaOfPotenceAndSymbolEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conQxRelaOfPotenceAndSymbol.RelaMid, Type.GetType("System.Int64"));
objDT.Columns.Add(conQxRelaOfPotenceAndSymbol.PotenceId, Type.GetType("System.String"));
objDT.Columns.Add(conQxRelaOfPotenceAndSymbol.SymbolForProgramme, Type.GetType("System.String"));
objDT.Columns.Add(conQxRelaOfPotenceAndSymbol.SymbolName, Type.GetType("System.String"));
objDT.Columns.Add(conQxRelaOfPotenceAndSymbol.Memo, Type.GetType("System.String"));
objDT.Columns.Add(conQxRelaOfPotenceAndSymbol.QxPrjId, Type.GetType("System.String"));
objDT.Columns.Add(conQxRelaOfPotenceAndSymbol.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conQxRelaOfPotenceAndSymbol.UpdUserId, Type.GetType("System.String"));
foreach (clsQxRelaOfPotenceAndSymbolEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conQxRelaOfPotenceAndSymbol.RelaMid] = objInFor[conQxRelaOfPotenceAndSymbol.RelaMid];
objDR[conQxRelaOfPotenceAndSymbol.PotenceId] = objInFor[conQxRelaOfPotenceAndSymbol.PotenceId];
objDR[conQxRelaOfPotenceAndSymbol.SymbolForProgramme] = objInFor[conQxRelaOfPotenceAndSymbol.SymbolForProgramme];
objDR[conQxRelaOfPotenceAndSymbol.SymbolName] = objInFor[conQxRelaOfPotenceAndSymbol.SymbolName];
objDR[conQxRelaOfPotenceAndSymbol.Memo] = objInFor[conQxRelaOfPotenceAndSymbol.Memo];
objDR[conQxRelaOfPotenceAndSymbol.QxPrjId] = objInFor[conQxRelaOfPotenceAndSymbol.QxPrjId];
objDR[conQxRelaOfPotenceAndSymbol.UpdDate] = objInFor[conQxRelaOfPotenceAndSymbol.UpdDate];
objDR[conQxRelaOfPotenceAndSymbol.UpdUserId] = objInFor[conQxRelaOfPotenceAndSymbol.UpdUserId];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 权限编程标志关系(QxRelaOfPotenceAndSymbol)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4QxRelaOfPotenceAndSymbol : clsCommFun4BL
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
clsQxRelaOfPotenceAndSymbolWApi.ReFreshThisCache();
}
}

}