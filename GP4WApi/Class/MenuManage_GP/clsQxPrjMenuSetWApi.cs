
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxPrjMenuSetWApi
 表名:QxPrjMenuSet(00140045)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 18:23:32
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:菜单管理(MenuManage_GP)
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
public static class  clsQxPrjMenuSetWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenuSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strMenuSetId">菜单集Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenuSetEN SetMenuSetId(this clsQxPrjMenuSetEN objQxPrjMenuSetEN, string strMenuSetId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMenuSetId, 4, conQxPrjMenuSet.MenuSetId);
clsCheckSql.CheckFieldForeignKey(strMenuSetId, 4, conQxPrjMenuSet.MenuSetId);
objQxPrjMenuSetEN.MenuSetId = strMenuSetId; //菜单集Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenuSetEN.dicFldComparisonOp.ContainsKey(conQxPrjMenuSet.MenuSetId) == false)
{
objQxPrjMenuSetEN.dicFldComparisonOp.Add(conQxPrjMenuSet.MenuSetId, strComparisonOp);
}
else
{
objQxPrjMenuSetEN.dicFldComparisonOp[conQxPrjMenuSet.MenuSetId] = strComparisonOp;
}
}
return objQxPrjMenuSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenuSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strMenuSetName">菜单集名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenuSetEN SetMenuSetName(this clsQxPrjMenuSetEN objQxPrjMenuSetEN, string strMenuSetName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMenuSetName, conQxPrjMenuSet.MenuSetName);
clsCheckSql.CheckFieldLen(strMenuSetName, 50, conQxPrjMenuSet.MenuSetName);
objQxPrjMenuSetEN.MenuSetName = strMenuSetName; //菜单集名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenuSetEN.dicFldComparisonOp.ContainsKey(conQxPrjMenuSet.MenuSetName) == false)
{
objQxPrjMenuSetEN.dicFldComparisonOp.Add(conQxPrjMenuSet.MenuSetName, strComparisonOp);
}
else
{
objQxPrjMenuSetEN.dicFldComparisonOp[conQxPrjMenuSet.MenuSetName] = strComparisonOp;
}
}
return objQxPrjMenuSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenuSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strMenuSetENName">菜单集英文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenuSetEN SetMenuSetENName(this clsQxPrjMenuSetEN objQxPrjMenuSetEN, string strMenuSetENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMenuSetENName, 50, conQxPrjMenuSet.MenuSetENName);
objQxPrjMenuSetEN.MenuSetENName = strMenuSetENName; //菜单集英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenuSetEN.dicFldComparisonOp.ContainsKey(conQxPrjMenuSet.MenuSetENName) == false)
{
objQxPrjMenuSetEN.dicFldComparisonOp.Add(conQxPrjMenuSet.MenuSetENName, strComparisonOp);
}
else
{
objQxPrjMenuSetEN.dicFldComparisonOp[conQxPrjMenuSet.MenuSetENName] = strComparisonOp;
}
}
return objQxPrjMenuSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenuSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strQxPrjId">项目Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenuSetEN SetQxPrjId(this clsQxPrjMenuSetEN objQxPrjMenuSetEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, conQxPrjMenuSet.QxPrjId);
clsCheckSql.CheckFieldLen(strQxPrjId, 4, conQxPrjMenuSet.QxPrjId);
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, conQxPrjMenuSet.QxPrjId);
objQxPrjMenuSetEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenuSetEN.dicFldComparisonOp.ContainsKey(conQxPrjMenuSet.QxPrjId) == false)
{
objQxPrjMenuSetEN.dicFldComparisonOp.Add(conQxPrjMenuSet.QxPrjId, strComparisonOp);
}
else
{
objQxPrjMenuSetEN.dicFldComparisonOp[conQxPrjMenuSet.QxPrjId] = strComparisonOp;
}
}
return objQxPrjMenuSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenuSetEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsDefault">是否默认</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenuSetEN SetIsDefault(this clsQxPrjMenuSetEN objQxPrjMenuSetEN, bool bolIsDefault, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsDefault, conQxPrjMenuSet.IsDefault);
objQxPrjMenuSetEN.IsDefault = bolIsDefault; //是否默认
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenuSetEN.dicFldComparisonOp.ContainsKey(conQxPrjMenuSet.IsDefault) == false)
{
objQxPrjMenuSetEN.dicFldComparisonOp.Add(conQxPrjMenuSet.IsDefault, strComparisonOp);
}
else
{
objQxPrjMenuSetEN.dicFldComparisonOp[conQxPrjMenuSet.IsDefault] = strComparisonOp;
}
}
return objQxPrjMenuSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenuSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenuSetEN SetUpdDate(this clsQxPrjMenuSetEN objQxPrjMenuSetEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conQxPrjMenuSet.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQxPrjMenuSet.UpdDate);
objQxPrjMenuSetEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenuSetEN.dicFldComparisonOp.ContainsKey(conQxPrjMenuSet.UpdDate) == false)
{
objQxPrjMenuSetEN.dicFldComparisonOp.Add(conQxPrjMenuSet.UpdDate, strComparisonOp);
}
else
{
objQxPrjMenuSetEN.dicFldComparisonOp[conQxPrjMenuSet.UpdDate] = strComparisonOp;
}
}
return objQxPrjMenuSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenuSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改用户</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenuSetEN SetUpdUser(this clsQxPrjMenuSetEN objQxPrjMenuSetEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 18, conQxPrjMenuSet.UpdUser);
objQxPrjMenuSetEN.UpdUser = strUpdUser; //修改用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenuSetEN.dicFldComparisonOp.ContainsKey(conQxPrjMenuSet.UpdUser) == false)
{
objQxPrjMenuSetEN.dicFldComparisonOp.Add(conQxPrjMenuSet.UpdUser, strComparisonOp);
}
else
{
objQxPrjMenuSetEN.dicFldComparisonOp[conQxPrjMenuSet.UpdUser] = strComparisonOp;
}
}
return objQxPrjMenuSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenuSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">备注</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenuSetEN SetMemo(this clsQxPrjMenuSetEN objQxPrjMenuSetEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQxPrjMenuSet.Memo);
objQxPrjMenuSetEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenuSetEN.dicFldComparisonOp.ContainsKey(conQxPrjMenuSet.Memo) == false)
{
objQxPrjMenuSetEN.dicFldComparisonOp.Add(conQxPrjMenuSet.Memo, strComparisonOp);
}
else
{
objQxPrjMenuSetEN.dicFldComparisonOp[conQxPrjMenuSet.Memo] = strComparisonOp;
}
}
return objQxPrjMenuSetEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQxPrjMenuSetEN objQxPrjMenuSetCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQxPrjMenuSetCond.IsUpdated(conQxPrjMenuSet.MenuSetId) == true)
{
string strComparisonOpMenuSetId = objQxPrjMenuSetCond.dicFldComparisonOp[conQxPrjMenuSet.MenuSetId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenuSet.MenuSetId, objQxPrjMenuSetCond.MenuSetId, strComparisonOpMenuSetId);
}
if (objQxPrjMenuSetCond.IsUpdated(conQxPrjMenuSet.MenuSetName) == true)
{
string strComparisonOpMenuSetName = objQxPrjMenuSetCond.dicFldComparisonOp[conQxPrjMenuSet.MenuSetName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenuSet.MenuSetName, objQxPrjMenuSetCond.MenuSetName, strComparisonOpMenuSetName);
}
if (objQxPrjMenuSetCond.IsUpdated(conQxPrjMenuSet.MenuSetENName) == true)
{
string strComparisonOpMenuSetENName = objQxPrjMenuSetCond.dicFldComparisonOp[conQxPrjMenuSet.MenuSetENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenuSet.MenuSetENName, objQxPrjMenuSetCond.MenuSetENName, strComparisonOpMenuSetENName);
}
if (objQxPrjMenuSetCond.IsUpdated(conQxPrjMenuSet.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objQxPrjMenuSetCond.dicFldComparisonOp[conQxPrjMenuSet.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenuSet.QxPrjId, objQxPrjMenuSetCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objQxPrjMenuSetCond.IsUpdated(conQxPrjMenuSet.IsDefault) == true)
{
if (objQxPrjMenuSetCond.IsDefault == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQxPrjMenuSet.IsDefault);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQxPrjMenuSet.IsDefault);
}
}
if (objQxPrjMenuSetCond.IsUpdated(conQxPrjMenuSet.UpdDate) == true)
{
string strComparisonOpUpdDate = objQxPrjMenuSetCond.dicFldComparisonOp[conQxPrjMenuSet.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenuSet.UpdDate, objQxPrjMenuSetCond.UpdDate, strComparisonOpUpdDate);
}
if (objQxPrjMenuSetCond.IsUpdated(conQxPrjMenuSet.UpdUser) == true)
{
string strComparisonOpUpdUser = objQxPrjMenuSetCond.dicFldComparisonOp[conQxPrjMenuSet.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenuSet.UpdUser, objQxPrjMenuSetCond.UpdUser, strComparisonOpUpdUser);
}
if (objQxPrjMenuSetCond.IsUpdated(conQxPrjMenuSet.Memo) == true)
{
string strComparisonOpMemo = objQxPrjMenuSetCond.dicFldComparisonOp[conQxPrjMenuSet.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenuSet.Memo, objQxPrjMenuSetCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objQxPrjMenuSetEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxPrjMenuSetEN objQxPrjMenuSetEN)
{
 if (string.IsNullOrEmpty(objQxPrjMenuSetEN.MenuSetId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objQxPrjMenuSetEN.sfUpdFldSetStr = objQxPrjMenuSetEN.getsfUpdFldSetStr();
clsQxPrjMenuSetWApi.CheckPropertyNew(objQxPrjMenuSetEN); 
bool bolResult = clsQxPrjMenuSetWApi.UpdateRecord(objQxPrjMenuSetEN);
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
 /// 获取唯一性条件串--QxPrjMenuSet(菜单集), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:MenuSetName_QxPrjId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objQxPrjMenuSetEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsQxPrjMenuSetEN objQxPrjMenuSetEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objQxPrjMenuSetEN == null) return "";
if (objQxPrjMenuSetEN.MenuSetId == null || objQxPrjMenuSetEN.MenuSetId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and MenuSetName = '{0}'", objQxPrjMenuSetEN.MenuSetName);
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxPrjMenuSetEN.QxPrjId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("MenuSetId !=  '{0}'", objQxPrjMenuSetEN.MenuSetId);
 sbCondition.AppendFormat(" and MenuSetName = '{0}'", objQxPrjMenuSetEN.MenuSetName);
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxPrjMenuSetEN.QxPrjId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQxPrjMenuSetEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQxPrjMenuSetEN objQxPrjMenuSetEN)
{
try
{
 if (string.IsNullOrEmpty(objQxPrjMenuSetEN.MenuSetId) == true || clsQxPrjMenuSetWApi.IsExist(objQxPrjMenuSetEN.MenuSetId) == true)
 {
     objQxPrjMenuSetEN.MenuSetId = clsQxPrjMenuSetWApi.GetMaxStrId();
 }
clsQxPrjMenuSetWApi.CheckPropertyNew(objQxPrjMenuSetEN); 
bool bolResult = clsQxPrjMenuSetWApi.AddNewRecord(objQxPrjMenuSetEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjMenuSetWApi.ReFreshCache();
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
 /// <param name = "objQxPrjMenuSetEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsQxPrjMenuSetEN objQxPrjMenuSetEN)
{
try
{
clsQxPrjMenuSetWApi.CheckPropertyNew(objQxPrjMenuSetEN); 
string strMenuSetId = clsQxPrjMenuSetWApi.AddNewRecordWithMaxId(objQxPrjMenuSetEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjMenuSetWApi.ReFreshCache();
return strMenuSetId;
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
 /// <param name = "objQxPrjMenuSetEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxPrjMenuSetEN objQxPrjMenuSetEN, string strWhereCond)
{
try
{
clsQxPrjMenuSetWApi.CheckPropertyNew(objQxPrjMenuSetEN); 
bool bolResult = clsQxPrjMenuSetWApi.UpdateWithCondition(objQxPrjMenuSetEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjMenuSetWApi.ReFreshCache();
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
 /// 根据表内容设置enum列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GeneEnumConstList)
 /// </summary>
public class enumQxPrjMenuSetWA
{
 /// <summary>
 /// 后台总菜单
 /// </summary>
public const string _0001 = "0001";
 /// <summary>
 /// 学生微格维护子菜单
 /// </summary>
public const string _0002 = "0002";
 /// <summary>
 /// 书法教学评议
 /// </summary>
public const string _0003 = "0003";
 /// <summary>
 /// 普通话教学评议
 /// </summary>
public const string _0004 = "0004";
 /// <summary>
 /// 微格教学评议
 /// </summary>
public const string _0005 = "0005";
 /// <summary>
 /// 技能示范与评议
 /// </summary>
public const string _0006 = "0006";
 /// <summary>
 /// 课例点播与评议
 /// </summary>
public const string _0007 = "0007";
 /// <summary>
 /// 青教评优教学评议
 /// </summary>
public const string _0008 = "0008";
 /// <summary>
 /// 职后微格课例添加
 /// </summary>
public const string _0009 = "0009";
 /// <summary>
 /// 职后微格教学评议扩展
 /// </summary>
public const string _0010 = "0010";
 /// <summary>
 /// 学生微格维护
 /// </summary>
public const string _0011 = "0011";
 /// <summary>
 /// 学生板书案例维护
 /// </summary>
public const string _0012 = "0012";
 /// <summary>
 /// 学生普通话案例维护
 /// </summary>
public const string _0013 = "0013";
 /// <summary>
 /// 后台案例维护
 /// </summary>
public const string _0014 = "0014";
 /// <summary>
 /// 课件点播与评议
 /// </summary>
public const string _0015 = "0015";
 /// <summary>
 /// 课堂教学点播与评议
 /// </summary>
public const string _0016 = "0016";
 /// <summary>
 /// 后台总菜单
 /// </summary>
public const string _0017 = "0017";
 /// <summary>
 /// 教学资源点播与评议
 /// </summary>
public const string _0018 = "0018";
 /// <summary>
 /// 视频资源库扩展
 /// </summary>
public const string _0019 = "0019";
 /// <summary>
 /// 课件资源库扩展
 /// </summary>
public const string _0020 = "0020";
 /// <summary>
 /// 教学案例资源库扩展
 /// </summary>
public const string _0021 = "0021";
 /// <summary>
 /// 课程教学扩展
 /// </summary>
public const string _0022 = "0022";
 /// <summary>
 /// 总菜单
 /// </summary>
public const string _0023 = "0023";
 /// <summary>
 /// 硕士优课评议
 /// </summary>
public const string _0024 = "0024";
 /// <summary>
 /// 后台总菜单
 /// </summary>
public const string _0025 = "0025";
 /// <summary>
 /// 后台总菜单
 /// </summary>
public const string _0026 = "0026";
 /// <summary>
 /// Win总菜单
 /// </summary>
public const string _0027 = "0027";
 /// <summary>
 /// 后台Core菜单
 /// </summary>
public const string _0028 = "0028";
}
 /// <summary>
 /// 菜单集(QxPrjMenuSet)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsQxPrjMenuSetWApi
{
private static readonly string mstrApiControllerName = "QxPrjMenuSetApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsQxPrjMenuSetWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_MenuSetId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[菜单集]...","0");
List<clsQxPrjMenuSetEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="MenuSetId";
objDDL.DataTextField="MenuSetName";
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

public static void BindCbo_MenuSetId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conQxPrjMenuSet.MenuSetId); 
List<clsQxPrjMenuSetEN> arrObjLst = clsQxPrjMenuSetWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsQxPrjMenuSetEN objQxPrjMenuSetEN = new clsQxPrjMenuSetEN()
{
MenuSetId = "0",
MenuSetName = "选[菜单集]..."
};
arrObjLst.Insert(0, objQxPrjMenuSetEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conQxPrjMenuSet.MenuSetId;
objComboBox.DisplayMember = conQxPrjMenuSet.MenuSetName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsQxPrjMenuSetEN objQxPrjMenuSetEN)
{
if (!Object.Equals(null, objQxPrjMenuSetEN.MenuSetId) && GetStrLen(objQxPrjMenuSetEN.MenuSetId) > 4)
{
 throw new Exception("字段[菜单集Id]的长度不能超过4!");
}
if (!Object.Equals(null, objQxPrjMenuSetEN.MenuSetName) && GetStrLen(objQxPrjMenuSetEN.MenuSetName) > 50)
{
 throw new Exception("字段[菜单集名称]的长度不能超过50!");
}
if (!Object.Equals(null, objQxPrjMenuSetEN.MenuSetENName) && GetStrLen(objQxPrjMenuSetEN.MenuSetENName) > 50)
{
 throw new Exception("字段[菜单集英文名]的长度不能超过50!");
}
if (!Object.Equals(null, objQxPrjMenuSetEN.QxPrjId) && GetStrLen(objQxPrjMenuSetEN.QxPrjId) > 4)
{
 throw new Exception("字段[项目Id]的长度不能超过4!");
}
if (!Object.Equals(null, objQxPrjMenuSetEN.UpdDate) && GetStrLen(objQxPrjMenuSetEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objQxPrjMenuSetEN.UpdUser) && GetStrLen(objQxPrjMenuSetEN.UpdUser) > 18)
{
 throw new Exception("字段[修改用户]的长度不能超过18!");
}
if (!Object.Equals(null, objQxPrjMenuSetEN.Memo) && GetStrLen(objQxPrjMenuSetEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objQxPrjMenuSetEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strMenuSetId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxPrjMenuSetEN GetObjByMenuSetId(string strMenuSetId)
{
string strAction = "GetObjByMenuSetId";
clsQxPrjMenuSetEN objQxPrjMenuSetEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strMenuSetId"] = strMenuSetId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objQxPrjMenuSetEN = JsonConvert.DeserializeObject<clsQxPrjMenuSetEN>(strJson);
return objQxPrjMenuSetEN;
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
public static clsQxPrjMenuSetEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsQxPrjMenuSetEN objQxPrjMenuSetEN;
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
objQxPrjMenuSetEN = JsonConvert.DeserializeObject<clsQxPrjMenuSetEN>(strJson);
return objQxPrjMenuSetEN;
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
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strMenuSetId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxPrjMenuSetEN GetObjByMenuSetIdCache(string strMenuSetId)
{
if (string.IsNullOrEmpty(strMenuSetId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsQxPrjMenuSetEN._CurrTabName);
List<clsQxPrjMenuSetEN> arrQxPrjMenuSetObjLstCache = GetObjLstCache();
IEnumerable <clsQxPrjMenuSetEN> arrQxPrjMenuSetObjLst_Sel =
from objQxPrjMenuSetEN in arrQxPrjMenuSetObjLstCache
where objQxPrjMenuSetEN.MenuSetId == strMenuSetId 
select objQxPrjMenuSetEN;
if (arrQxPrjMenuSetObjLst_Sel.Count() == 0)
{
   clsQxPrjMenuSetEN obj = clsQxPrjMenuSetWApi.GetObjByMenuSetId(strMenuSetId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrQxPrjMenuSetObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strMenuSetId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetMenuSetNameByMenuSetIdCache(string strMenuSetId)
{
if (string.IsNullOrEmpty(strMenuSetId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsQxPrjMenuSetEN._CurrTabName);
List<clsQxPrjMenuSetEN> arrQxPrjMenuSetObjLstCache = GetObjLstCache();
IEnumerable <clsQxPrjMenuSetEN> arrQxPrjMenuSetObjLst_Sel1 =
from objQxPrjMenuSetEN in arrQxPrjMenuSetObjLstCache
where objQxPrjMenuSetEN.MenuSetId == strMenuSetId 
select objQxPrjMenuSetEN;
List <clsQxPrjMenuSetEN> arrQxPrjMenuSetObjLst_Sel = new List<clsQxPrjMenuSetEN>();
foreach (clsQxPrjMenuSetEN obj in arrQxPrjMenuSetObjLst_Sel1)
{
arrQxPrjMenuSetObjLst_Sel.Add(obj);
}
if (arrQxPrjMenuSetObjLst_Sel.Count > 0)
{
return arrQxPrjMenuSetObjLst_Sel[0].MenuSetName;
}
string strErrMsgForGetObjById = string.Format("在QxPrjMenuSet对象缓存列表中,找不到记录[MenuSetId = {0}](函数:{1})", strMenuSetId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsQxPrjMenuSetBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strMenuSetId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByMenuSetIdCache(string strMenuSetId)
{
if (string.IsNullOrEmpty(strMenuSetId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsQxPrjMenuSetEN._CurrTabName);
List<clsQxPrjMenuSetEN> arrQxPrjMenuSetObjLstCache = GetObjLstCache();
IEnumerable <clsQxPrjMenuSetEN> arrQxPrjMenuSetObjLst_Sel1 =
from objQxPrjMenuSetEN in arrQxPrjMenuSetObjLstCache
where objQxPrjMenuSetEN.MenuSetId == strMenuSetId 
select objQxPrjMenuSetEN;
List <clsQxPrjMenuSetEN> arrQxPrjMenuSetObjLst_Sel = new List<clsQxPrjMenuSetEN>();
foreach (clsQxPrjMenuSetEN obj in arrQxPrjMenuSetObjLst_Sel1)
{
arrQxPrjMenuSetObjLst_Sel.Add(obj);
}
if (arrQxPrjMenuSetObjLst_Sel.Count > 0)
{
return arrQxPrjMenuSetObjLst_Sel[0].MenuSetName;
}
string strErrMsgForGetObjById = string.Format("在QxPrjMenuSet对象缓存列表中,找不到记录的相关名称[MenuSetId = {0}](函数:{1})", strMenuSetId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsQxPrjMenuSetBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPrjMenuSetEN> GetObjLst(string strWhereCond)
{
 List<clsQxPrjMenuSetEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxPrjMenuSetEN>>(strJson);
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
 /// <param name = "arrMenuSetId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPrjMenuSetEN> GetObjLstByMenuSetIdLst(List<string> arrMenuSetId)
{
 List<clsQxPrjMenuSetEN> arrObjLst; 
string strAction = "GetObjLstByMenuSetIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMenuSetId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsQxPrjMenuSetEN>>(strJson);
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

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMenuSetId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsQxPrjMenuSetEN> GetObjLstByMenuSetIdLstCache(List<string> arrMenuSetId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsQxPrjMenuSetEN._CurrTabName);
List<clsQxPrjMenuSetEN> arrQxPrjMenuSetObjLstCache = GetObjLstCache();
IEnumerable <clsQxPrjMenuSetEN> arrQxPrjMenuSetObjLst_Sel =
from objQxPrjMenuSetEN in arrQxPrjMenuSetObjLstCache
where arrMenuSetId.Contains(objQxPrjMenuSetEN.MenuSetId)
select objQxPrjMenuSetEN;
return arrQxPrjMenuSetObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPrjMenuSetEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsQxPrjMenuSetEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxPrjMenuSetEN>>(strJson);
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
public static List<clsQxPrjMenuSetEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsQxPrjMenuSetEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxPrjMenuSetEN>>(strJson);
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
public static List<clsQxPrjMenuSetEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsQxPrjMenuSetEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxPrjMenuSetEN>>(strJson);
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
public static List<clsQxPrjMenuSetEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsQxPrjMenuSetEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxPrjMenuSetEN>>(strJson);
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
public static int DelRecord(string strMenuSetId)
{
string strAction = "DelRecord";
try
{
 clsQxPrjMenuSetEN objQxPrjMenuSetEN = clsQxPrjMenuSetWApi.GetObjByMenuSetId(strMenuSetId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strMenuSetId.ToString(), out string strResult, out string strErrMsg) == true)
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
public static int DelQxPrjMenuSets(List<string> arrMenuSetId)
{
string strAction = "DelQxPrjMenuSets";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMenuSetId);
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
public static int DelQxPrjMenuSetsByCond(string strWhereCond)
{
string strAction = "DelQxPrjMenuSetsByCond";
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
public static bool AddNewRecord(clsQxPrjMenuSetEN objQxPrjMenuSetEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxPrjMenuSetEN>(objQxPrjMenuSetEN);
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
public static string AddNewRecordWithMaxId(clsQxPrjMenuSetEN objQxPrjMenuSetEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxPrjMenuSetEN>(objQxPrjMenuSetEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
var strMenuSetId = (string)jobjReturn0["returnStr"];
return strMenuSetId;
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
public static bool UpdateRecord(clsQxPrjMenuSetEN objQxPrjMenuSetEN)
{
if (string.IsNullOrEmpty(objQxPrjMenuSetEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objQxPrjMenuSetEN.MenuSetId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxPrjMenuSetEN>(objQxPrjMenuSetEN);
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
 /// <param name = "objQxPrjMenuSetEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsQxPrjMenuSetEN objQxPrjMenuSetEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objQxPrjMenuSetEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objQxPrjMenuSetEN.MenuSetId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objQxPrjMenuSetEN.MenuSetId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxPrjMenuSetEN>(objQxPrjMenuSetEN);
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
public static bool IsExist(string strMenuSetId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strMenuSetId"] = strMenuSetId
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
 /// <param name = "objQxPrjMenuSetENS">源对象</param>
 /// <param name = "objQxPrjMenuSetENT">目标对象</param>
 public static void CopyTo(clsQxPrjMenuSetEN objQxPrjMenuSetENS, clsQxPrjMenuSetEN objQxPrjMenuSetENT)
{
try
{
objQxPrjMenuSetENT.MenuSetId = objQxPrjMenuSetENS.MenuSetId; //菜单集Id
objQxPrjMenuSetENT.MenuSetName = objQxPrjMenuSetENS.MenuSetName; //菜单集名称
objQxPrjMenuSetENT.MenuSetENName = objQxPrjMenuSetENS.MenuSetENName; //菜单集英文名
objQxPrjMenuSetENT.QxPrjId = objQxPrjMenuSetENS.QxPrjId; //项目Id
objQxPrjMenuSetENT.IsDefault = objQxPrjMenuSetENS.IsDefault; //是否默认
objQxPrjMenuSetENT.UpdDate = objQxPrjMenuSetENS.UpdDate; //修改日期
objQxPrjMenuSetENT.UpdUser = objQxPrjMenuSetENS.UpdUser; //修改用户
objQxPrjMenuSetENT.Memo = objQxPrjMenuSetENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsQxPrjMenuSetEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsQxPrjMenuSetEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsQxPrjMenuSetEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsQxPrjMenuSetEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsQxPrjMenuSetEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsQxPrjMenuSetEN.AttributeName)
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
string strKey = string.Format("{0}", clsQxPrjMenuSetEN._CurrTabName);
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
if (clsQxPrjMenuSetWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsQxPrjMenuSetEN._CurrTabName);
CacheHelper.Remove(strKey);
clsQxPrjMenuSetWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxPrjMenuSetEN> GetObjLstCache()
{
//初始化列表缓存
var strWhereCond = "";
var strKey = clsQxPrjMenuSetEN._CurrTabName;
List<clsQxPrjMenuSetEN> arrQxPrjMenuSetObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrQxPrjMenuSetObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsQxPrjMenuSetEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conQxPrjMenuSet.MenuSetId, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjMenuSet.MenuSetName, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjMenuSet.MenuSetENName, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjMenuSet.QxPrjId, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjMenuSet.IsDefault, Type.GetType("System.Boolean"));
objDT.Columns.Add(conQxPrjMenuSet.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjMenuSet.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjMenuSet.Memo, Type.GetType("System.String"));
foreach (clsQxPrjMenuSetEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conQxPrjMenuSet.MenuSetId] = objInFor[conQxPrjMenuSet.MenuSetId];
objDR[conQxPrjMenuSet.MenuSetName] = objInFor[conQxPrjMenuSet.MenuSetName];
objDR[conQxPrjMenuSet.MenuSetENName] = objInFor[conQxPrjMenuSet.MenuSetENName];
objDR[conQxPrjMenuSet.QxPrjId] = objInFor[conQxPrjMenuSet.QxPrjId];
objDR[conQxPrjMenuSet.IsDefault] = objInFor[conQxPrjMenuSet.IsDefault];
objDR[conQxPrjMenuSet.UpdDate] = objInFor[conQxPrjMenuSet.UpdDate];
objDR[conQxPrjMenuSet.UpdUser] = objInFor[conQxPrjMenuSet.UpdUser];
objDR[conQxPrjMenuSet.Memo] = objInFor[conQxPrjMenuSet.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 菜单集(QxPrjMenuSet)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4QxPrjMenuSet : clsCommFun4BL
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
clsQxPrjMenuSetWApi.ReFreshThisCache();
}
}

}