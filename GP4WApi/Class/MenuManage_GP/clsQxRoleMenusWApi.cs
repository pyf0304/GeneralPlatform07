
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxRoleMenusWApi
 表名:QxRoleMenus(00140007)
 * 版本:2024.01.01.1(服务器:WIN-SRV103-116)
 日期:2024/01/08 11:16:35
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
using GP4WApi;

namespace GeneralPlatform4WApi
{
/// <summary>
/// 静态类
/// </summary>
public static class  clsQxRoleMenusWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">流水号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRoleMenusEN SetmId(this clsQxRoleMenusEN objQxRoleMenusEN, long lngmId, string strComparisonOp="")
	{
objQxRoleMenusEN.mId = lngmId; //流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRoleMenusEN.dicFldComparisonOp.ContainsKey(conQxRoleMenus.mId) == false)
{
objQxRoleMenusEN.dicFldComparisonOp.Add(conQxRoleMenus.mId, strComparisonOp);
}
else
{
objQxRoleMenusEN.dicFldComparisonOp[conQxRoleMenus.mId] = strComparisonOp;
}
}
return objQxRoleMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strRoleId">角色Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRoleMenusEN SetRoleId(this clsQxRoleMenusEN objQxRoleMenusEN, string strRoleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRoleId, conQxRoleMenus.RoleId);
clsCheckSql.CheckFieldLen(strRoleId, 8, conQxRoleMenus.RoleId);
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, conQxRoleMenus.RoleId);
objQxRoleMenusEN.RoleId = strRoleId; //角色Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRoleMenusEN.dicFldComparisonOp.ContainsKey(conQxRoleMenus.RoleId) == false)
{
objQxRoleMenusEN.dicFldComparisonOp.Add(conQxRoleMenus.RoleId, strComparisonOp);
}
else
{
objQxRoleMenusEN.dicFldComparisonOp[conQxRoleMenus.RoleId] = strComparisonOp;
}
}
return objQxRoleMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strQxPrjId">项目Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRoleMenusEN SetQxPrjId(this clsQxRoleMenusEN objQxRoleMenusEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, conQxRoleMenus.QxPrjId);
clsCheckSql.CheckFieldLen(strQxPrjId, 4, conQxRoleMenus.QxPrjId);
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, conQxRoleMenus.QxPrjId);
objQxRoleMenusEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRoleMenusEN.dicFldComparisonOp.ContainsKey(conQxRoleMenus.QxPrjId) == false)
{
objQxRoleMenusEN.dicFldComparisonOp.Add(conQxRoleMenus.QxPrjId, strComparisonOp);
}
else
{
objQxRoleMenusEN.dicFldComparisonOp[conQxRoleMenus.QxPrjId] = strComparisonOp;
}
}
return objQxRoleMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmPrjId">Cm项目Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRoleMenusEN SetCmPrjId(this clsQxRoleMenusEN objQxRoleMenusEN, string strCmPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCmPrjId, 6, conQxRoleMenus.CmPrjId);
clsCheckSql.CheckFieldForeignKey(strCmPrjId, 6, conQxRoleMenus.CmPrjId);
objQxRoleMenusEN.CmPrjId = strCmPrjId; //Cm项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRoleMenusEN.dicFldComparisonOp.ContainsKey(conQxRoleMenus.CmPrjId) == false)
{
objQxRoleMenusEN.dicFldComparisonOp.Add(conQxRoleMenus.CmPrjId, strComparisonOp);
}
else
{
objQxRoleMenusEN.dicFldComparisonOp[conQxRoleMenus.CmPrjId] = strComparisonOp;
}
}
return objQxRoleMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strMenuSetId">菜单集Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRoleMenusEN SetMenuSetId(this clsQxRoleMenusEN objQxRoleMenusEN, string strMenuSetId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMenuSetId, conQxRoleMenus.MenuSetId);
clsCheckSql.CheckFieldLen(strMenuSetId, 4, conQxRoleMenus.MenuSetId);
clsCheckSql.CheckFieldForeignKey(strMenuSetId, 4, conQxRoleMenus.MenuSetId);
objQxRoleMenusEN.MenuSetId = strMenuSetId; //菜单集Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRoleMenusEN.dicFldComparisonOp.ContainsKey(conQxRoleMenus.MenuSetId) == false)
{
objQxRoleMenusEN.dicFldComparisonOp.Add(conQxRoleMenus.MenuSetId, strComparisonOp);
}
else
{
objQxRoleMenusEN.dicFldComparisonOp[conQxRoleMenus.MenuSetId] = strComparisonOp;
}
}
return objQxRoleMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strMenuId">菜单Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRoleMenusEN SetMenuId(this clsQxRoleMenusEN objQxRoleMenusEN, string strMenuId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMenuId, conQxRoleMenus.MenuId);
clsCheckSql.CheckFieldLen(strMenuId, 8, conQxRoleMenus.MenuId);
clsCheckSql.CheckFieldForeignKey(strMenuId, 8, conQxRoleMenus.MenuId);
objQxRoleMenusEN.MenuId = strMenuId; //菜单Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRoleMenusEN.dicFldComparisonOp.ContainsKey(conQxRoleMenus.MenuId) == false)
{
objQxRoleMenusEN.dicFldComparisonOp.Add(conQxRoleMenus.MenuId, strComparisonOp);
}
else
{
objQxRoleMenusEN.dicFldComparisonOp[conQxRoleMenus.MenuId] = strComparisonOp;
}
}
return objQxRoleMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsDisp">是否显示</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRoleMenusEN SetIsDisp(this clsQxRoleMenusEN objQxRoleMenusEN, bool bolIsDisp, string strComparisonOp="")
	{
objQxRoleMenusEN.IsDisp = bolIsDisp; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRoleMenusEN.dicFldComparisonOp.ContainsKey(conQxRoleMenus.IsDisp) == false)
{
objQxRoleMenusEN.dicFldComparisonOp.Add(conQxRoleMenus.IsDisp, strComparisonOp);
}
else
{
objQxRoleMenusEN.dicFldComparisonOp[conQxRoleMenus.IsDisp] = strComparisonOp;
}
}
return objQxRoleMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRoleMenusEN SetUpdDate(this clsQxRoleMenusEN objQxRoleMenusEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conQxRoleMenus.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQxRoleMenus.UpdDate);
objQxRoleMenusEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRoleMenusEN.dicFldComparisonOp.ContainsKey(conQxRoleMenus.UpdDate) == false)
{
objQxRoleMenusEN.dicFldComparisonOp.Add(conQxRoleMenus.UpdDate, strComparisonOp);
}
else
{
objQxRoleMenusEN.dicFldComparisonOp[conQxRoleMenus.UpdDate] = strComparisonOp;
}
}
return objQxRoleMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRoleMenusEN SetUpdUserId(this clsQxRoleMenusEN objQxRoleMenusEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUserId, conQxRoleMenus.UpdUserId);
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conQxRoleMenus.UpdUserId);
objQxRoleMenusEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRoleMenusEN.dicFldComparisonOp.ContainsKey(conQxRoleMenus.UpdUserId) == false)
{
objQxRoleMenusEN.dicFldComparisonOp.Add(conQxRoleMenus.UpdUserId, strComparisonOp);
}
else
{
objQxRoleMenusEN.dicFldComparisonOp[conQxRoleMenus.UpdUserId] = strComparisonOp;
}
}
return objQxRoleMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">备注</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRoleMenusEN SetMemo(this clsQxRoleMenusEN objQxRoleMenusEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQxRoleMenus.Memo);
objQxRoleMenusEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRoleMenusEN.dicFldComparisonOp.ContainsKey(conQxRoleMenus.Memo) == false)
{
objQxRoleMenusEN.dicFldComparisonOp.Add(conQxRoleMenus.Memo, strComparisonOp);
}
else
{
objQxRoleMenusEN.dicFldComparisonOp[conQxRoleMenus.Memo] = strComparisonOp;
}
}
return objQxRoleMenusEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQxRoleMenusEN objQxRoleMenusCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQxRoleMenusCond.IsUpdated(conQxRoleMenus.mId) == true)
{
string strComparisonOpmId = objQxRoleMenusCond.dicFldComparisonOp[conQxRoleMenus.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conQxRoleMenus.mId, objQxRoleMenusCond.mId, strComparisonOpmId);
}
if (objQxRoleMenusCond.IsUpdated(conQxRoleMenus.RoleId) == true)
{
string strComparisonOpRoleId = objQxRoleMenusCond.dicFldComparisonOp[conQxRoleMenus.RoleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxRoleMenus.RoleId, objQxRoleMenusCond.RoleId, strComparisonOpRoleId);
}
if (objQxRoleMenusCond.IsUpdated(conQxRoleMenus.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objQxRoleMenusCond.dicFldComparisonOp[conQxRoleMenus.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxRoleMenus.QxPrjId, objQxRoleMenusCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objQxRoleMenusCond.IsUpdated(conQxRoleMenus.CmPrjId) == true)
{
string strComparisonOpCmPrjId = objQxRoleMenusCond.dicFldComparisonOp[conQxRoleMenus.CmPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxRoleMenus.CmPrjId, objQxRoleMenusCond.CmPrjId, strComparisonOpCmPrjId);
}
if (objQxRoleMenusCond.IsUpdated(conQxRoleMenus.MenuSetId) == true)
{
string strComparisonOpMenuSetId = objQxRoleMenusCond.dicFldComparisonOp[conQxRoleMenus.MenuSetId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxRoleMenus.MenuSetId, objQxRoleMenusCond.MenuSetId, strComparisonOpMenuSetId);
}
if (objQxRoleMenusCond.IsUpdated(conQxRoleMenus.MenuId) == true)
{
string strComparisonOpMenuId = objQxRoleMenusCond.dicFldComparisonOp[conQxRoleMenus.MenuId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxRoleMenus.MenuId, objQxRoleMenusCond.MenuId, strComparisonOpMenuId);
}
if (objQxRoleMenusCond.IsUpdated(conQxRoleMenus.IsDisp) == true)
{
if (objQxRoleMenusCond.IsDisp == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQxRoleMenus.IsDisp);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQxRoleMenus.IsDisp);
}
}
if (objQxRoleMenusCond.IsUpdated(conQxRoleMenus.UpdDate) == true)
{
string strComparisonOpUpdDate = objQxRoleMenusCond.dicFldComparisonOp[conQxRoleMenus.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxRoleMenus.UpdDate, objQxRoleMenusCond.UpdDate, strComparisonOpUpdDate);
}
if (objQxRoleMenusCond.IsUpdated(conQxRoleMenus.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objQxRoleMenusCond.dicFldComparisonOp[conQxRoleMenus.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxRoleMenus.UpdUserId, objQxRoleMenusCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objQxRoleMenusCond.IsUpdated(conQxRoleMenus.Memo) == true)
{
string strComparisonOpMemo = objQxRoleMenusCond.dicFldComparisonOp[conQxRoleMenus.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxRoleMenus.Memo, objQxRoleMenusCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objQxRoleMenusEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxRoleMenusEN objQxRoleMenusEN)
{
 if (objQxRoleMenusEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objQxRoleMenusEN.sfUpdFldSetStr = objQxRoleMenusEN.getsfUpdFldSetStr();
clsQxRoleMenusWApi.CheckPropertyNew(objQxRoleMenusEN); 
bool bolResult = clsQxRoleMenusWApi.UpdateRecord(objQxRoleMenusEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRoleMenusWApi.ReFreshCache(objQxRoleMenusEN.QxPrjId);
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
 /// 获取唯一性条件串--QxRoleMenus(角色菜单), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:RoleId_CmPrjId_MenuSetId_MenuId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objQxRoleMenusEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsQxRoleMenusEN objQxRoleMenusEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objQxRoleMenusEN == null) return "";
if (objQxRoleMenusEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and RoleId = '{0}'", objQxRoleMenusEN.RoleId);
 sbCondition.AppendFormat(" and CmPrjId = '{0}'", objQxRoleMenusEN.CmPrjId);
 sbCondition.AppendFormat(" and MenuSetId = '{0}'", objQxRoleMenusEN.MenuSetId);
 sbCondition.AppendFormat(" and MenuId = '{0}'", objQxRoleMenusEN.MenuId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objQxRoleMenusEN.mId);
 sbCondition.AppendFormat(" and RoleId = '{0}'", objQxRoleMenusEN.RoleId);
 sbCondition.AppendFormat(" and CmPrjId = '{0}'", objQxRoleMenusEN.CmPrjId);
 sbCondition.AppendFormat(" and MenuSetId = '{0}'", objQxRoleMenusEN.MenuSetId);
 sbCondition.AppendFormat(" and MenuId = '{0}'", objQxRoleMenusEN.MenuId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQxRoleMenusEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQxRoleMenusEN objQxRoleMenusEN)
{
try
{
clsQxRoleMenusWApi.CheckPropertyNew(objQxRoleMenusEN); 
bool bolResult = clsQxRoleMenusWApi.AddNewRecord(objQxRoleMenusEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRoleMenusWApi.ReFreshCache(objQxRoleMenusEN.QxPrjId);
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
 /// <param name = "objQxRoleMenusEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxRoleMenusEN objQxRoleMenusEN, string strWhereCond)
{
try
{
clsQxRoleMenusWApi.CheckPropertyNew(objQxRoleMenusEN); 
bool bolResult = clsQxRoleMenusWApi.UpdateWithCondition(objQxRoleMenusEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRoleMenusWApi.ReFreshCache(objQxRoleMenusEN.QxPrjId);
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
 /// 角色菜单(QxRoleMenus)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsQxRoleMenusWApi
{
private static readonly string mstrApiControllerName = "QxRoleMenusApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4WApi = null;

 public clsQxRoleMenusWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsQxRoleMenusEN objQxRoleMenusEN)
{
if (!Object.Equals(null, objQxRoleMenusEN.RoleId) && GetStrLen(objQxRoleMenusEN.RoleId) > 8)
{
 throw new Exception("字段[角色Id]的长度不能超过8!");
}
if (!Object.Equals(null, objQxRoleMenusEN.QxPrjId) && GetStrLen(objQxRoleMenusEN.QxPrjId) > 4)
{
 throw new Exception("字段[项目Id]的长度不能超过4!");
}
if (!Object.Equals(null, objQxRoleMenusEN.CmPrjId) && GetStrLen(objQxRoleMenusEN.CmPrjId) > 6)
{
 throw new Exception("字段[Cm项目Id]的长度不能超过6!");
}
if (!Object.Equals(null, objQxRoleMenusEN.MenuSetId) && GetStrLen(objQxRoleMenusEN.MenuSetId) > 4)
{
 throw new Exception("字段[菜单集Id]的长度不能超过4!");
}
if (!Object.Equals(null, objQxRoleMenusEN.MenuId) && GetStrLen(objQxRoleMenusEN.MenuId) > 8)
{
 throw new Exception("字段[菜单Id]的长度不能超过8!");
}
if (!Object.Equals(null, objQxRoleMenusEN.UpdDate) && GetStrLen(objQxRoleMenusEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objQxRoleMenusEN.UpdUserId) && GetStrLen(objQxRoleMenusEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objQxRoleMenusEN.Memo) && GetStrLen(objQxRoleMenusEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objQxRoleMenusEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxRoleMenusEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
clsQxRoleMenusEN objQxRoleMenusEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngmId"] = lngmId.ToString(),
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objQxRoleMenusEN = JsonConvert.DeserializeObject<clsQxRoleMenusEN>(strJson);
return objQxRoleMenusEN;
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
public static clsQxRoleMenusEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsQxRoleMenusEN objQxRoleMenusEN;
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
objQxRoleMenusEN = JsonConvert.DeserializeObject<clsQxRoleMenusEN>(strJson);
return objQxRoleMenusEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxRoleMenusEN GetObjBymIdCache(long lngmId,string strQxPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsQxRoleMenusEN._CurrTabName, strQxPrjId);
List<clsQxRoleMenusEN> arrQxRoleMenusObjLstCache = GetObjLstCache(strQxPrjId);
IEnumerable <clsQxRoleMenusEN> arrQxRoleMenusObjLst_Sel =
from objQxRoleMenusEN in arrQxRoleMenusObjLstCache
where objQxRoleMenusEN.mId == lngmId 
select objQxRoleMenusEN;
if (arrQxRoleMenusObjLst_Sel.Count() == 0)
{
   clsQxRoleMenusEN obj = clsQxRoleMenusWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrQxRoleMenusObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxRoleMenusEN> GetObjLst(string strWhereCond)
{
 List<clsQxRoleMenusEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxRoleMenusEN>>(strJson);
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
 /// <param name = "arrMId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxRoleMenusEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsQxRoleMenusEN> arrObjLst; 
string strAction = "GetObjLstByMIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsQxRoleMenusEN>>(strJson);
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
 /// <param name = "arrMId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsQxRoleMenusEN> GetObjLstByMIdLstCache(List<long> arrMId, string strQxPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsQxRoleMenusEN._CurrTabName, strQxPrjId);
List<clsQxRoleMenusEN> arrQxRoleMenusObjLstCache = GetObjLstCache(strQxPrjId);
IEnumerable <clsQxRoleMenusEN> arrQxRoleMenusObjLst_Sel =
from objQxRoleMenusEN in arrQxRoleMenusObjLstCache
where arrMId.Contains(objQxRoleMenusEN.mId)
select objQxRoleMenusEN;
return arrQxRoleMenusObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxRoleMenusEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsQxRoleMenusEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxRoleMenusEN>>(strJson);
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
public static List<clsQxRoleMenusEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsQxRoleMenusEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxRoleMenusEN>>(strJson);
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
public static List<clsQxRoleMenusEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsQxRoleMenusEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxRoleMenusEN>>(strJson);
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
public static List<clsQxRoleMenusEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsQxRoleMenusEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxRoleMenusEN>>(strJson);
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
public static int DelRecord(long lngmId)
{
string strAction = "DelRecord";
try
{
 clsQxRoleMenusEN objQxRoleMenusEN = clsQxRoleMenusWApi.GetObjBymId(lngmId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngmId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsQxRoleMenusWApi.ReFreshCache(objQxRoleMenusEN.QxPrjId);
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
public static int DelQxRoleMenuss(List<string> arrmId)
{
string strAction = "DelQxRoleMenuss";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrmId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
 clsQxRoleMenusEN objQxRoleMenusEN = clsQxRoleMenusWApi.GetObjBymId(long.Parse(arrmId[0]));
clsQxRoleMenusWApi.ReFreshCache(objQxRoleMenusEN.QxPrjId);
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
public static int DelQxRoleMenussByCond(string strWhereCond)
{
string strAction = "DelQxRoleMenussByCond";
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
public static bool AddNewRecord(clsQxRoleMenusEN objQxRoleMenusEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxRoleMenusEN>(objQxRoleMenusEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRoleMenusWApi.ReFreshCache(objQxRoleMenusEN.QxPrjId);
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
 /// <param name = "objQxRoleMenusEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsQxRoleMenusEN objQxRoleMenusEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxRoleMenusEN>(objQxRoleMenusEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRoleMenusWApi.ReFreshCache(objQxRoleMenusEN.QxPrjId);
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
public static bool UpdateRecord(clsQxRoleMenusEN objQxRoleMenusEN)
{
if (string.IsNullOrEmpty(objQxRoleMenusEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objQxRoleMenusEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxRoleMenusEN>(objQxRoleMenusEN);
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
 /// <param name = "objQxRoleMenusEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsQxRoleMenusEN objQxRoleMenusEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objQxRoleMenusEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objQxRoleMenusEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objQxRoleMenusEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxRoleMenusEN>(objQxRoleMenusEN);
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
public static bool IsExist(long lngmId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngmId"] = lngmId.ToString()
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
 /// <param name = "objQxRoleMenusENS">源对象</param>
 /// <param name = "objQxRoleMenusENT">目标对象</param>
 public static void CopyTo(clsQxRoleMenusEN objQxRoleMenusENS, clsQxRoleMenusEN objQxRoleMenusENT)
{
try
{
objQxRoleMenusENT.mId = objQxRoleMenusENS.mId; //流水号
objQxRoleMenusENT.RoleId = objQxRoleMenusENS.RoleId; //角色Id
objQxRoleMenusENT.QxPrjId = objQxRoleMenusENS.QxPrjId; //项目Id
objQxRoleMenusENT.CmPrjId = objQxRoleMenusENS.CmPrjId; //Cm项目Id
objQxRoleMenusENT.MenuSetId = objQxRoleMenusENS.MenuSetId; //菜单集Id
objQxRoleMenusENT.MenuId = objQxRoleMenusENS.MenuId; //菜单Id
objQxRoleMenusENT.IsDisp = objQxRoleMenusENS.IsDisp; //是否显示
objQxRoleMenusENT.UpdDate = objQxRoleMenusENS.UpdDate; //修改日期
objQxRoleMenusENT.UpdUserId = objQxRoleMenusENS.UpdUserId; //修改用户Id
objQxRoleMenusENT.Memo = objQxRoleMenusENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsQxRoleMenusEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsQxRoleMenusEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsQxRoleMenusEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsQxRoleMenusEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsQxRoleMenusEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsQxRoleMenusEN.AttributeName)
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
public static void ReFreshThisCache(string strQxPrjId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsQxRoleMenusEN._CurrTabName, strQxPrjId);
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
public static void ReFreshCache(string strQxPrjId)
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsQxRoleMenusWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsQxRoleMenusEN._CurrTabName, strQxPrjId);
CacheHelper.Remove(strKey);
clsQxRoleMenusWApi.objCommFun4WApi.ReFreshCache(strQxPrjId.ToString());
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxRoleMenusEN> GetObjLstCache(string strQxPrjId)
{
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsQxRoleMenusEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsQxRoleMenusEN._WhereFormat, strQxPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",conQxRoleMenus.QxPrjId, strQxPrjId);
}
var strKey = string.Format("{0}_{1}", clsQxRoleMenusEN._CurrTabName, strQxPrjId);
List<clsQxRoleMenusEN> arrQxRoleMenusObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrQxRoleMenusObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxRoleMenusEN> GetObjLstCacheFromObjLst(string strQxPrjId,List<clsQxRoleMenusEN> arrObjLst_P)
{
var strKey = string.Format("{0}_{1}", clsQxRoleMenusEN._CurrTabName, strQxPrjId);
List<clsQxRoleMenusEN> arrQxRoleMenusObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrQxRoleMenusObjLstCache = CacheHelper.Get<List<clsQxRoleMenusEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.QxPrjId == strQxPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrQxRoleMenusObjLstCache = CacheHelper.Get<List<clsQxRoleMenusEN>>(strKey);
}
return arrQxRoleMenusObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsQxRoleMenusEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conQxRoleMenus.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(conQxRoleMenus.RoleId, Type.GetType("System.String"));
objDT.Columns.Add(conQxRoleMenus.QxPrjId, Type.GetType("System.String"));
objDT.Columns.Add(conQxRoleMenus.CmPrjId, Type.GetType("System.String"));
objDT.Columns.Add(conQxRoleMenus.MenuSetId, Type.GetType("System.String"));
objDT.Columns.Add(conQxRoleMenus.MenuId, Type.GetType("System.String"));
objDT.Columns.Add(conQxRoleMenus.IsDisp, Type.GetType("System.Boolean"));
objDT.Columns.Add(conQxRoleMenus.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conQxRoleMenus.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conQxRoleMenus.Memo, Type.GetType("System.String"));
foreach (clsQxRoleMenusEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conQxRoleMenus.mId] = objInFor[conQxRoleMenus.mId];
objDR[conQxRoleMenus.RoleId] = objInFor[conQxRoleMenus.RoleId];
objDR[conQxRoleMenus.QxPrjId] = objInFor[conQxRoleMenus.QxPrjId];
objDR[conQxRoleMenus.CmPrjId] = objInFor[conQxRoleMenus.CmPrjId];
objDR[conQxRoleMenus.MenuSetId] = objInFor[conQxRoleMenus.MenuSetId];
objDR[conQxRoleMenus.MenuId] = objInFor[conQxRoleMenus.MenuId];
objDR[conQxRoleMenus.IsDisp] = objInFor[conQxRoleMenus.IsDisp];
objDR[conQxRoleMenus.UpdDate] = objInFor[conQxRoleMenus.UpdDate];
objDR[conQxRoleMenus.UpdUserId] = objInFor[conQxRoleMenus.UpdUserId];
objDR[conQxRoleMenus.Memo] = objInFor[conQxRoleMenus.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 角色菜单(QxRoleMenus)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4QxRoleMenus : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strQxPrjId)
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
clsQxRoleMenusWApi.ReFreshThisCache(strQxPrjId);
}
}

}