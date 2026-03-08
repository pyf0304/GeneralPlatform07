
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxPrjPotenceV2BL
 表名:QxPrjPotenceV2(00140115)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:31:02
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
public static class  clsQxPrjPotenceV2BL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "intPId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxPrjPotenceV2EN GetObj(this K_PId_QxPrjPotenceV2 myKey)
{
clsQxPrjPotenceV2EN objQxPrjPotenceV2EN = clsQxPrjPotenceV2BL.QxPrjPotenceV2DA.GetObjByPId(myKey.Value);
return objQxPrjPotenceV2EN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQxPrjPotenceV2EN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQxPrjPotenceV2EN objQxPrjPotenceV2EN)
{
if (CheckUniqueness(objQxPrjPotenceV2EN) == false)
{
var strMsg = string.Format("记录已经存在!权限名称 = [{0}],项目Id = [{1}]的数据已经存在!(in clsQxPrjPotenceV2BL.AddNewRecord)", objQxPrjPotenceV2EN.PotenceName,objQxPrjPotenceV2EN.QxPrjId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsQxPrjPotenceV2BL.QxPrjPotenceV2DA.AddNewRecordBySQL2(objQxPrjPotenceV2EN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjPotenceV2BL.ReFreshCache(objQxPrjPotenceV2EN.QxPrjId);

if (clsQxPrjPotenceV2BL.relatedActions != null)
{
clsQxPrjPotenceV2BL.relatedActions.UpdRelaTabDate(objQxPrjPotenceV2EN.PId, objQxPrjPotenceV2EN.UpdUserId);
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000082)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 插入记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddRecordEx)
 /// </summary>
 /// <returns>插入记录是否成功？</returns>
public static bool AddRecordEx(this clsQxPrjPotenceV2EN objQxPrjPotenceV2EN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
try
{
 //2、检查传进去的对象属性是否合法
objQxPrjPotenceV2EN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objQxPrjPotenceV2EN.CheckUniqueness() == false)
{
strMsg = string.Format("(权限名称(PotenceName)=[{0}],项目Id(QxPrjId)=[{1}])已经存在,不能重复!", objQxPrjPotenceV2EN.PotenceName, objQxPrjPotenceV2EN.QxPrjId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objQxPrjPotenceV2EN.AddNewRecord();
}
catch(Exception objException)
{
strMsg = "(errid:Busi000152)添加记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objQxPrjPotenceV2EN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsQxPrjPotenceV2EN objQxPrjPotenceV2EN)
{
if (CheckUniqueness(objQxPrjPotenceV2EN) == false)
{
var strMsg = string.Format("记录已经存在!权限名称 = [{0}],项目Id = [{1}]的数据已经存在!(in clsQxPrjPotenceV2BL.AddNewRecordWithReturnKey)", objQxPrjPotenceV2EN.PotenceName,objQxPrjPotenceV2EN.QxPrjId);
throw new Exception(strMsg);
}
try
{
string strKey = clsQxPrjPotenceV2BL.QxPrjPotenceV2DA.AddNewRecordBySQL2WithReturnKey(objQxPrjPotenceV2EN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjPotenceV2BL.ReFreshCache(objQxPrjPotenceV2EN.QxPrjId);

if (clsQxPrjPotenceV2BL.relatedActions != null)
{
clsQxPrjPotenceV2BL.relatedActions.UpdRelaTabDate(objQxPrjPotenceV2EN.PId, objQxPrjPotenceV2EN.UpdUserId);
}
return strKey;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000091)带返回值的添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjPotenceV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjPotenceV2EN SetPId(this clsQxPrjPotenceV2EN objQxPrjPotenceV2EN, int intPId, string strComparisonOp="")
	{
objQxPrjPotenceV2EN.PId = intPId; //菜单Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjPotenceV2EN.dicFldComparisonOp.ContainsKey(conQxPrjPotenceV2.PId) == false)
{
objQxPrjPotenceV2EN.dicFldComparisonOp.Add(conQxPrjPotenceV2.PId, strComparisonOp);
}
else
{
objQxPrjPotenceV2EN.dicFldComparisonOp[conQxPrjPotenceV2.PId] = strComparisonOp;
}
}
return objQxPrjPotenceV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjPotenceV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjPotenceV2EN SetPotenceName(this clsQxPrjPotenceV2EN objQxPrjPotenceV2EN, string strPotenceName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPotenceName, conQxPrjPotenceV2.PotenceName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPotenceName, 200, conQxPrjPotenceV2.PotenceName);
}
objQxPrjPotenceV2EN.PotenceName = strPotenceName; //权限名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjPotenceV2EN.dicFldComparisonOp.ContainsKey(conQxPrjPotenceV2.PotenceName) == false)
{
objQxPrjPotenceV2EN.dicFldComparisonOp.Add(conQxPrjPotenceV2.PotenceName, strComparisonOp);
}
else
{
objQxPrjPotenceV2EN.dicFldComparisonOp[conQxPrjPotenceV2.PotenceName] = strComparisonOp;
}
}
return objQxPrjPotenceV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjPotenceV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjPotenceV2EN SetQxPrjId(this clsQxPrjPotenceV2EN objQxPrjPotenceV2EN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, conQxPrjPotenceV2.QxPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQxPrjId, 4, conQxPrjPotenceV2.QxPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, conQxPrjPotenceV2.QxPrjId);
}
objQxPrjPotenceV2EN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjPotenceV2EN.dicFldComparisonOp.ContainsKey(conQxPrjPotenceV2.QxPrjId) == false)
{
objQxPrjPotenceV2EN.dicFldComparisonOp.Add(conQxPrjPotenceV2.QxPrjId, strComparisonOp);
}
else
{
objQxPrjPotenceV2EN.dicFldComparisonOp[conQxPrjPotenceV2.QxPrjId] = strComparisonOp;
}
}
return objQxPrjPotenceV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjPotenceV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjPotenceV2EN SetFuncModuleId(this clsQxPrjPotenceV2EN objQxPrjPotenceV2EN, string strFuncModuleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, conQxPrjPotenceV2.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, conQxPrjPotenceV2.FuncModuleId);
}
objQxPrjPotenceV2EN.FuncModuleId = strFuncModuleId; //模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjPotenceV2EN.dicFldComparisonOp.ContainsKey(conQxPrjPotenceV2.FuncModuleId) == false)
{
objQxPrjPotenceV2EN.dicFldComparisonOp.Add(conQxPrjPotenceV2.FuncModuleId, strComparisonOp);
}
else
{
objQxPrjPotenceV2EN.dicFldComparisonOp[conQxPrjPotenceV2.FuncModuleId] = strComparisonOp;
}
}
return objQxPrjPotenceV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjPotenceV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjPotenceV2EN SetPotenceTypeId(this clsQxPrjPotenceV2EN objQxPrjPotenceV2EN, string strPotenceTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPotenceTypeId, 6, conQxPrjPotenceV2.PotenceTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPotenceTypeId, 6, conQxPrjPotenceV2.PotenceTypeId);
}
objQxPrjPotenceV2EN.PotenceTypeId = strPotenceTypeId; //权限类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjPotenceV2EN.dicFldComparisonOp.ContainsKey(conQxPrjPotenceV2.PotenceTypeId) == false)
{
objQxPrjPotenceV2EN.dicFldComparisonOp.Add(conQxPrjPotenceV2.PotenceTypeId, strComparisonOp);
}
else
{
objQxPrjPotenceV2EN.dicFldComparisonOp[conQxPrjPotenceV2.PotenceTypeId] = strComparisonOp;
}
}
return objQxPrjPotenceV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjPotenceV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjPotenceV2EN SetMenuId(this clsQxPrjPotenceV2EN objQxPrjPotenceV2EN, string strMenuId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuId, 8, conQxPrjPotenceV2.MenuId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMenuId, 8, conQxPrjPotenceV2.MenuId);
}
objQxPrjPotenceV2EN.MenuId = strMenuId; //菜单Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjPotenceV2EN.dicFldComparisonOp.ContainsKey(conQxPrjPotenceV2.MenuId) == false)
{
objQxPrjPotenceV2EN.dicFldComparisonOp.Add(conQxPrjPotenceV2.MenuId, strComparisonOp);
}
else
{
objQxPrjPotenceV2EN.dicFldComparisonOp[conQxPrjPotenceV2.MenuId] = strComparisonOp;
}
}
return objQxPrjPotenceV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjPotenceV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjPotenceV2EN SetMenuId4Win(this clsQxPrjPotenceV2EN objQxPrjPotenceV2EN, string strMenuId4Win, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuId4Win, 8, conQxPrjPotenceV2.MenuId4Win);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMenuId4Win, 8, conQxPrjPotenceV2.MenuId4Win);
}
objQxPrjPotenceV2EN.MenuId4Win = strMenuId4Win; //菜单Id4Win
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjPotenceV2EN.dicFldComparisonOp.ContainsKey(conQxPrjPotenceV2.MenuId4Win) == false)
{
objQxPrjPotenceV2EN.dicFldComparisonOp.Add(conQxPrjPotenceV2.MenuId4Win, strComparisonOp);
}
else
{
objQxPrjPotenceV2EN.dicFldComparisonOp[conQxPrjPotenceV2.MenuId4Win] = strComparisonOp;
}
}
return objQxPrjPotenceV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjPotenceV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjPotenceV2EN SetUpdDate(this clsQxPrjPotenceV2EN objQxPrjPotenceV2EN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQxPrjPotenceV2.UpdDate);
}
objQxPrjPotenceV2EN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjPotenceV2EN.dicFldComparisonOp.ContainsKey(conQxPrjPotenceV2.UpdDate) == false)
{
objQxPrjPotenceV2EN.dicFldComparisonOp.Add(conQxPrjPotenceV2.UpdDate, strComparisonOp);
}
else
{
objQxPrjPotenceV2EN.dicFldComparisonOp[conQxPrjPotenceV2.UpdDate] = strComparisonOp;
}
}
return objQxPrjPotenceV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjPotenceV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjPotenceV2EN SetUpdUserId(this clsQxPrjPotenceV2EN objQxPrjPotenceV2EN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conQxPrjPotenceV2.UpdUserId);
}
objQxPrjPotenceV2EN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjPotenceV2EN.dicFldComparisonOp.ContainsKey(conQxPrjPotenceV2.UpdUserId) == false)
{
objQxPrjPotenceV2EN.dicFldComparisonOp.Add(conQxPrjPotenceV2.UpdUserId, strComparisonOp);
}
else
{
objQxPrjPotenceV2EN.dicFldComparisonOp[conQxPrjPotenceV2.UpdUserId] = strComparisonOp;
}
}
return objQxPrjPotenceV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjPotenceV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjPotenceV2EN SetMemo(this clsQxPrjPotenceV2EN objQxPrjPotenceV2EN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQxPrjPotenceV2.Memo);
}
objQxPrjPotenceV2EN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjPotenceV2EN.dicFldComparisonOp.ContainsKey(conQxPrjPotenceV2.Memo) == false)
{
objQxPrjPotenceV2EN.dicFldComparisonOp.Add(conQxPrjPotenceV2.Memo, strComparisonOp);
}
else
{
objQxPrjPotenceV2EN.dicFldComparisonOp[conQxPrjPotenceV2.Memo] = strComparisonOp;
}
}
return objQxPrjPotenceV2EN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objQxPrjPotenceV2EN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsQxPrjPotenceV2EN objQxPrjPotenceV2EN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objQxPrjPotenceV2EN.CheckPropertyNew();
clsQxPrjPotenceV2EN objQxPrjPotenceV2Cond = new clsQxPrjPotenceV2EN();
string strCondition = objQxPrjPotenceV2Cond
.SetPId(objQxPrjPotenceV2EN.PId, "<>")
.SetPotenceName(objQxPrjPotenceV2EN.PotenceName, "=")
.SetQxPrjId(objQxPrjPotenceV2EN.QxPrjId, "=")
.GetCombineCondition();
objQxPrjPotenceV2EN._IsCheckProperty = true;
bool bolIsExist = clsQxPrjPotenceV2BL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(PotenceName_QxPrjId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objQxPrjPotenceV2EN.Update();
}
catch(Exception objException)
{
strMsg = "修改记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true; 
}

 /// <summary>
 /// 编辑记录存盘到数据表中。如果存在相关记录就修改,不存在就添加
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_EditRecordEx)
 /// </summary>
 /// <param name = "objQxPrjPotenceV2">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsQxPrjPotenceV2EN objQxPrjPotenceV2)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsQxPrjPotenceV2EN objQxPrjPotenceV2Cond = new clsQxPrjPotenceV2EN();
string strCondition = objQxPrjPotenceV2Cond
.SetPotenceName(objQxPrjPotenceV2.PotenceName, "=")
.SetQxPrjId(objQxPrjPotenceV2.QxPrjId, "=")
.GetCombineCondition();
objQxPrjPotenceV2._IsCheckProperty = true;
bool bolIsExist = clsQxPrjPotenceV2BL.IsExistRecord(strCondition);
if (bolIsExist)
{
objQxPrjPotenceV2.PId = clsQxPrjPotenceV2BL.GetFirstID_S(strCondition);
objQxPrjPotenceV2.UpdateWithCondition(strCondition);
}
else
{
objQxPrjPotenceV2.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objQxPrjPotenceV2EN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxPrjPotenceV2EN objQxPrjPotenceV2EN)
{
 if (objQxPrjPotenceV2EN.PId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxPrjPotenceV2BL.QxPrjPotenceV2DA.UpdateBySql2(objQxPrjPotenceV2EN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjPotenceV2BL.ReFreshCache(objQxPrjPotenceV2EN.QxPrjId);

if (clsQxPrjPotenceV2BL.relatedActions != null)
{
clsQxPrjPotenceV2BL.relatedActions.UpdRelaTabDate(objQxPrjPotenceV2EN.PId, objQxPrjPotenceV2EN.UpdUserId);
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000083)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式.(带事务处理)
 /// /// 优点:1、能够处理字段中的单撇问题；
 /// /// 2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库;
 /// /// 3、支持事务处理.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateWithTransaction)
 /// </summary>
 /// <param name = "objQxPrjPotenceV2EN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxPrjPotenceV2EN objQxPrjPotenceV2EN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objQxPrjPotenceV2EN.PId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxPrjPotenceV2BL.QxPrjPotenceV2DA.UpdateBySql2(objQxPrjPotenceV2EN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjPotenceV2BL.ReFreshCache(objQxPrjPotenceV2EN.QxPrjId);

if (clsQxPrjPotenceV2BL.relatedActions != null)
{
clsQxPrjPotenceV2BL.relatedActions.UpdRelaTabDate(objQxPrjPotenceV2EN.PId, objQxPrjPotenceV2EN.UpdUserId);
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000088)修改记录出错,{1}.(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objQxPrjPotenceV2EN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxPrjPotenceV2EN objQxPrjPotenceV2EN, string strWhereCond)
{
try
{
bool bolResult = clsQxPrjPotenceV2BL.QxPrjPotenceV2DA.UpdateBySqlWithCondition(objQxPrjPotenceV2EN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjPotenceV2BL.ReFreshCache(objQxPrjPotenceV2EN.QxPrjId);

if (clsQxPrjPotenceV2BL.relatedActions != null)
{
clsQxPrjPotenceV2BL.relatedActions.UpdRelaTabDate(objQxPrjPotenceV2EN.PId, objQxPrjPotenceV2EN.UpdUserId);
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000089)根据条件修改记录出错, {1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录.(带事务处理)
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateWithConditionTransaction)
 /// </summary>
 /// <param name = "objQxPrjPotenceV2EN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxPrjPotenceV2EN objQxPrjPotenceV2EN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsQxPrjPotenceV2BL.QxPrjPotenceV2DA.UpdateBySqlWithConditionTransaction(objQxPrjPotenceV2EN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjPotenceV2BL.ReFreshCache(objQxPrjPotenceV2EN.QxPrjId);

if (clsQxPrjPotenceV2BL.relatedActions != null)
{
clsQxPrjPotenceV2BL.relatedActions.UpdRelaTabDate(objQxPrjPotenceV2EN.PId, objQxPrjPotenceV2EN.UpdUserId);
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000090)根据条件修改记录出错!(带事务处理),{1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Delete)
 /// </summary>
 /// <param name = "intPId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsQxPrjPotenceV2EN objQxPrjPotenceV2EN)
{
try
{
int intRecNum = clsQxPrjPotenceV2BL.QxPrjPotenceV2DA.DelRecord(objQxPrjPotenceV2EN.PId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjPotenceV2BL.ReFreshCache(objQxPrjPotenceV2EN.QxPrjId);

if (clsQxPrjPotenceV2BL.relatedActions != null)
{
clsQxPrjPotenceV2BL.relatedActions.UpdRelaTabDate(objQxPrjPotenceV2EN.PId, objQxPrjPotenceV2EN.UpdUserId);
}
return intRecNum;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000084)根据关键字删除记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objQxPrjPotenceV2ENS">源对象</param>
 /// <param name = "objQxPrjPotenceV2ENT">目标对象</param>
 public static void CopyTo(this clsQxPrjPotenceV2EN objQxPrjPotenceV2ENS, clsQxPrjPotenceV2EN objQxPrjPotenceV2ENT)
{
try
{
objQxPrjPotenceV2ENT.PId = objQxPrjPotenceV2ENS.PId; //菜单Id
objQxPrjPotenceV2ENT.PotenceName = objQxPrjPotenceV2ENS.PotenceName; //权限名称
objQxPrjPotenceV2ENT.QxPrjId = objQxPrjPotenceV2ENS.QxPrjId; //项目Id
objQxPrjPotenceV2ENT.FuncModuleId = objQxPrjPotenceV2ENS.FuncModuleId; //模块Id
objQxPrjPotenceV2ENT.PotenceTypeId = objQxPrjPotenceV2ENS.PotenceTypeId; //权限类型Id
objQxPrjPotenceV2ENT.MenuId = objQxPrjPotenceV2ENS.MenuId; //菜单Id
objQxPrjPotenceV2ENT.MenuId4Win = objQxPrjPotenceV2ENS.MenuId4Win; //菜单Id4Win
objQxPrjPotenceV2ENT.UpdDate = objQxPrjPotenceV2ENS.UpdDate; //修改日期
objQxPrjPotenceV2ENT.UpdUserId = objQxPrjPotenceV2ENS.UpdUserId; //修改用户Id
objQxPrjPotenceV2ENT.Memo = objQxPrjPotenceV2ENS.Memo; //备注
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
 /// <param name = "objQxPrjPotenceV2ENS">源对象</param>
 /// <returns>目标对象=>clsQxPrjPotenceV2EN:objQxPrjPotenceV2ENT</returns>
 public static clsQxPrjPotenceV2EN CopyTo(this clsQxPrjPotenceV2EN objQxPrjPotenceV2ENS)
{
try
{
 clsQxPrjPotenceV2EN objQxPrjPotenceV2ENT = new clsQxPrjPotenceV2EN()
{
PId = objQxPrjPotenceV2ENS.PId, //菜单Id
PotenceName = objQxPrjPotenceV2ENS.PotenceName, //权限名称
QxPrjId = objQxPrjPotenceV2ENS.QxPrjId, //项目Id
FuncModuleId = objQxPrjPotenceV2ENS.FuncModuleId, //模块Id
PotenceTypeId = objQxPrjPotenceV2ENS.PotenceTypeId, //权限类型Id
MenuId = objQxPrjPotenceV2ENS.MenuId, //菜单Id
MenuId4Win = objQxPrjPotenceV2ENS.MenuId4Win, //菜单Id4Win
UpdDate = objQxPrjPotenceV2ENS.UpdDate, //修改日期
UpdUserId = objQxPrjPotenceV2ENS.UpdUserId, //修改用户Id
Memo = objQxPrjPotenceV2ENS.Memo, //备注
};
 return objQxPrjPotenceV2ENT;
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
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(this clsQxPrjPotenceV2EN objQxPrjPotenceV2EN)
{
 clsQxPrjPotenceV2BL.QxPrjPotenceV2DA.CheckPropertyNew(objQxPrjPotenceV2EN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsQxPrjPotenceV2EN objQxPrjPotenceV2EN)
{
 clsQxPrjPotenceV2BL.QxPrjPotenceV2DA.CheckProperty4Condition(objQxPrjPotenceV2EN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQxPrjPotenceV2EN objQxPrjPotenceV2Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQxPrjPotenceV2Cond.IsUpdated(conQxPrjPotenceV2.PId) == true)
{
string strComparisonOpPId = objQxPrjPotenceV2Cond.dicFldComparisonOp[conQxPrjPotenceV2.PId];
strWhereCond += string.Format(" And {0} {2} {1}", conQxPrjPotenceV2.PId, objQxPrjPotenceV2Cond.PId, strComparisonOpPId);
}
if (objQxPrjPotenceV2Cond.IsUpdated(conQxPrjPotenceV2.PotenceName) == true)
{
string strComparisonOpPotenceName = objQxPrjPotenceV2Cond.dicFldComparisonOp[conQxPrjPotenceV2.PotenceName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjPotenceV2.PotenceName, objQxPrjPotenceV2Cond.PotenceName, strComparisonOpPotenceName);
}
if (objQxPrjPotenceV2Cond.IsUpdated(conQxPrjPotenceV2.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objQxPrjPotenceV2Cond.dicFldComparisonOp[conQxPrjPotenceV2.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjPotenceV2.QxPrjId, objQxPrjPotenceV2Cond.QxPrjId, strComparisonOpQxPrjId);
}
if (objQxPrjPotenceV2Cond.IsUpdated(conQxPrjPotenceV2.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objQxPrjPotenceV2Cond.dicFldComparisonOp[conQxPrjPotenceV2.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjPotenceV2.FuncModuleId, objQxPrjPotenceV2Cond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objQxPrjPotenceV2Cond.IsUpdated(conQxPrjPotenceV2.PotenceTypeId) == true)
{
string strComparisonOpPotenceTypeId = objQxPrjPotenceV2Cond.dicFldComparisonOp[conQxPrjPotenceV2.PotenceTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjPotenceV2.PotenceTypeId, objQxPrjPotenceV2Cond.PotenceTypeId, strComparisonOpPotenceTypeId);
}
if (objQxPrjPotenceV2Cond.IsUpdated(conQxPrjPotenceV2.MenuId) == true)
{
string strComparisonOpMenuId = objQxPrjPotenceV2Cond.dicFldComparisonOp[conQxPrjPotenceV2.MenuId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjPotenceV2.MenuId, objQxPrjPotenceV2Cond.MenuId, strComparisonOpMenuId);
}
if (objQxPrjPotenceV2Cond.IsUpdated(conQxPrjPotenceV2.MenuId4Win) == true)
{
string strComparisonOpMenuId4Win = objQxPrjPotenceV2Cond.dicFldComparisonOp[conQxPrjPotenceV2.MenuId4Win];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjPotenceV2.MenuId4Win, objQxPrjPotenceV2Cond.MenuId4Win, strComparisonOpMenuId4Win);
}
if (objQxPrjPotenceV2Cond.IsUpdated(conQxPrjPotenceV2.UpdDate) == true)
{
string strComparisonOpUpdDate = objQxPrjPotenceV2Cond.dicFldComparisonOp[conQxPrjPotenceV2.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjPotenceV2.UpdDate, objQxPrjPotenceV2Cond.UpdDate, strComparisonOpUpdDate);
}
if (objQxPrjPotenceV2Cond.IsUpdated(conQxPrjPotenceV2.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objQxPrjPotenceV2Cond.dicFldComparisonOp[conQxPrjPotenceV2.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjPotenceV2.UpdUserId, objQxPrjPotenceV2Cond.UpdUserId, strComparisonOpUpdUserId);
}
if (objQxPrjPotenceV2Cond.IsUpdated(conQxPrjPotenceV2.Memo) == true)
{
string strComparisonOpMemo = objQxPrjPotenceV2Cond.dicFldComparisonOp[conQxPrjPotenceV2.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjPotenceV2.Memo, objQxPrjPotenceV2Cond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--QxPrjPotenceV2(工程权限V2), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:PotenceName_QxPrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objQxPrjPotenceV2EN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsQxPrjPotenceV2EN objQxPrjPotenceV2EN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objQxPrjPotenceV2EN == null) return true;
if (objQxPrjPotenceV2EN.PId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PotenceName = '{0}'", objQxPrjPotenceV2EN.PotenceName);
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxPrjPotenceV2EN.QxPrjId);
if (clsQxPrjPotenceV2BL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("PId !=  {0}", objQxPrjPotenceV2EN.PId);
 sbCondition.AppendFormat(" and PotenceName = '{0}'", objQxPrjPotenceV2EN.PotenceName);
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxPrjPotenceV2EN.QxPrjId);
if (clsQxPrjPotenceV2BL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
return bolIsUniqueness;
}

 /// <summary>
 /// 获取唯一性条件串--QxPrjPotenceV2(工程权限V2), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PotenceName_QxPrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objQxPrjPotenceV2EN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsQxPrjPotenceV2EN objQxPrjPotenceV2EN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objQxPrjPotenceV2EN == null) return "";
if (objQxPrjPotenceV2EN.PId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PotenceName = '{0}'", objQxPrjPotenceV2EN.PotenceName);
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxPrjPotenceV2EN.QxPrjId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("PId !=  {0}", objQxPrjPotenceV2EN.PId);
 sbCondition.AppendFormat(" and PotenceName = '{0}'", objQxPrjPotenceV2EN.PotenceName);
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxPrjPotenceV2EN.QxPrjId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_QxPrjPotenceV2
{
public virtual bool UpdRelaTabDate(int intPId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 工程权限V2(QxPrjPotenceV2)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsQxPrjPotenceV2BL
{
public static RelatedActions_QxPrjPotenceV2 relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "QxPrjPotenceV2ListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "QxPrjPotenceV2List";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsQxPrjPotenceV2EN> arrQxPrjPotenceV2ObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsQxPrjPotenceV2DA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsQxPrjPotenceV2DA QxPrjPotenceV2DA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsQxPrjPotenceV2DA();
}
return uniqueInstance;
}
}

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4BL = null;

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsQxPrjPotenceV2BL()
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
if (string.IsNullOrEmpty(clsQxPrjPotenceV2EN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxPrjPotenceV2EN._ConnectString);
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
objDS = QxPrjPotenceV2DA.GetDataSet(strWhereCond);
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
objDS = QxPrjPotenceV2DA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = QxPrjPotenceV2DA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_QxPrjPotenceV2(string strWhereCond)
{
DataTable objDT;
try
{
objDT = QxPrjPotenceV2DA.GetDataTable_QxPrjPotenceV2(strWhereCond);
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
objDT = QxPrjPotenceV2DA.GetDataTable(strWhereCond);
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
objDT = QxPrjPotenceV2DA.GetDataTable(strWhereCond, lstExclude);
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
objDT = QxPrjPotenceV2DA.GetDataTable(strWhereCond, strTabName);
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
objDT = QxPrjPotenceV2DA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = QxPrjPotenceV2DA.GetDataTable_Top(objTopPara);
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
objDT = QxPrjPotenceV2DA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = QxPrjPotenceV2DA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = QxPrjPotenceV2DA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = QxPrjPotenceV2DA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = QxPrjPotenceV2DA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = QxPrjPotenceV2DA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = QxPrjPotenceV2DA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = QxPrjPotenceV2DA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
 /// <param name = "arrPIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsQxPrjPotenceV2EN> GetObjLstByPIdLst(List<int> arrPIdLst)
{
List<clsQxPrjPotenceV2EN> arrObjLst = new List<clsQxPrjPotenceV2EN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrPIdLst);
 string strWhereCond = string.Format("PId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjPotenceV2EN objQxPrjPotenceV2EN = new clsQxPrjPotenceV2EN();
try
{
objQxPrjPotenceV2EN.PId = Int32.Parse(objRow[conQxPrjPotenceV2.PId].ToString().Trim()); //菜单Id
objQxPrjPotenceV2EN.PotenceName = objRow[conQxPrjPotenceV2.PotenceName].ToString().Trim(); //权限名称
objQxPrjPotenceV2EN.QxPrjId = objRow[conQxPrjPotenceV2.QxPrjId].ToString().Trim(); //项目Id
objQxPrjPotenceV2EN.FuncModuleId = objRow[conQxPrjPotenceV2.FuncModuleId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.FuncModuleId].ToString().Trim(); //模块Id
objQxPrjPotenceV2EN.PotenceTypeId = objRow[conQxPrjPotenceV2.PotenceTypeId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.PotenceTypeId].ToString().Trim(); //权限类型Id
objQxPrjPotenceV2EN.MenuId = objRow[conQxPrjPotenceV2.MenuId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.MenuId].ToString().Trim(); //菜单Id
objQxPrjPotenceV2EN.MenuId4Win = objRow[conQxPrjPotenceV2.MenuId4Win] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.MenuId4Win].ToString().Trim(); //菜单Id4Win
objQxPrjPotenceV2EN.UpdDate = objRow[conQxPrjPotenceV2.UpdDate] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.UpdDate].ToString().Trim(); //修改日期
objQxPrjPotenceV2EN.UpdUserId = objRow[conQxPrjPotenceV2.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjPotenceV2EN.Memo = objRow[conQxPrjPotenceV2.Memo] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjPotenceV2EN.PId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjPotenceV2EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsQxPrjPotenceV2EN> GetObjLstByPIdLstCache(List<int> arrPIdLst, string strQxPrjId)
{
string strKey = string.Format("{0}_{1}", clsQxPrjPotenceV2EN._CurrTabName, strQxPrjId);
List<clsQxPrjPotenceV2EN> arrQxPrjPotenceV2ObjLstCache = GetObjLstCache(strQxPrjId);
IEnumerable <clsQxPrjPotenceV2EN> arrQxPrjPotenceV2ObjLst_Sel =
arrQxPrjPotenceV2ObjLstCache
.Where(x => arrPIdLst.Contains(x.PId));
return arrQxPrjPotenceV2ObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPrjPotenceV2EN> GetObjLst(string strWhereCond)
{
List<clsQxPrjPotenceV2EN> arrObjLst = new List<clsQxPrjPotenceV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjPotenceV2EN objQxPrjPotenceV2EN = new clsQxPrjPotenceV2EN();
try
{
objQxPrjPotenceV2EN.PId = Int32.Parse(objRow[conQxPrjPotenceV2.PId].ToString().Trim()); //菜单Id
objQxPrjPotenceV2EN.PotenceName = objRow[conQxPrjPotenceV2.PotenceName].ToString().Trim(); //权限名称
objQxPrjPotenceV2EN.QxPrjId = objRow[conQxPrjPotenceV2.QxPrjId].ToString().Trim(); //项目Id
objQxPrjPotenceV2EN.FuncModuleId = objRow[conQxPrjPotenceV2.FuncModuleId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.FuncModuleId].ToString().Trim(); //模块Id
objQxPrjPotenceV2EN.PotenceTypeId = objRow[conQxPrjPotenceV2.PotenceTypeId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.PotenceTypeId].ToString().Trim(); //权限类型Id
objQxPrjPotenceV2EN.MenuId = objRow[conQxPrjPotenceV2.MenuId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.MenuId].ToString().Trim(); //菜单Id
objQxPrjPotenceV2EN.MenuId4Win = objRow[conQxPrjPotenceV2.MenuId4Win] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.MenuId4Win].ToString().Trim(); //菜单Id4Win
objQxPrjPotenceV2EN.UpdDate = objRow[conQxPrjPotenceV2.UpdDate] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.UpdDate].ToString().Trim(); //修改日期
objQxPrjPotenceV2EN.UpdUserId = objRow[conQxPrjPotenceV2.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjPotenceV2EN.Memo = objRow[conQxPrjPotenceV2.Memo] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjPotenceV2EN.PId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjPotenceV2EN);
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
public static List<clsQxPrjPotenceV2EN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsQxPrjPotenceV2EN> arrObjLst = new List<clsQxPrjPotenceV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjPotenceV2EN objQxPrjPotenceV2EN = new clsQxPrjPotenceV2EN();
try
{
objQxPrjPotenceV2EN.PId = Int32.Parse(objRow[conQxPrjPotenceV2.PId].ToString().Trim()); //菜单Id
objQxPrjPotenceV2EN.PotenceName = objRow[conQxPrjPotenceV2.PotenceName].ToString().Trim(); //权限名称
objQxPrjPotenceV2EN.QxPrjId = objRow[conQxPrjPotenceV2.QxPrjId].ToString().Trim(); //项目Id
objQxPrjPotenceV2EN.FuncModuleId = objRow[conQxPrjPotenceV2.FuncModuleId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.FuncModuleId].ToString().Trim(); //模块Id
objQxPrjPotenceV2EN.PotenceTypeId = objRow[conQxPrjPotenceV2.PotenceTypeId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.PotenceTypeId].ToString().Trim(); //权限类型Id
objQxPrjPotenceV2EN.MenuId = objRow[conQxPrjPotenceV2.MenuId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.MenuId].ToString().Trim(); //菜单Id
objQxPrjPotenceV2EN.MenuId4Win = objRow[conQxPrjPotenceV2.MenuId4Win] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.MenuId4Win].ToString().Trim(); //菜单Id4Win
objQxPrjPotenceV2EN.UpdDate = objRow[conQxPrjPotenceV2.UpdDate] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.UpdDate].ToString().Trim(); //修改日期
objQxPrjPotenceV2EN.UpdUserId = objRow[conQxPrjPotenceV2.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjPotenceV2EN.Memo = objRow[conQxPrjPotenceV2.Memo] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjPotenceV2EN.PId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjPotenceV2EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objQxPrjPotenceV2Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsQxPrjPotenceV2EN> GetSubObjLstCache(clsQxPrjPotenceV2EN objQxPrjPotenceV2Cond)
{
 string strQxPrjId = objQxPrjPotenceV2Cond.QxPrjId;
 if (string.IsNullOrEmpty(strQxPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsQxPrjPotenceV2BL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsQxPrjPotenceV2EN> arrObjLstCache = GetObjLstCache(strQxPrjId);
IEnumerable <clsQxPrjPotenceV2EN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxPrjPotenceV2.AttributeName)
{
if (objQxPrjPotenceV2Cond.IsUpdated(strFldName) == false) continue;
if (objQxPrjPotenceV2Cond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxPrjPotenceV2Cond[strFldName].ToString());
}
else
{
if (objQxPrjPotenceV2Cond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxPrjPotenceV2Cond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxPrjPotenceV2Cond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxPrjPotenceV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxPrjPotenceV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxPrjPotenceV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxPrjPotenceV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxPrjPotenceV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxPrjPotenceV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxPrjPotenceV2Cond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxPrjPotenceV2Cond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxPrjPotenceV2Cond[strFldName]));
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
public static List<clsQxPrjPotenceV2EN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsQxPrjPotenceV2EN> arrObjLst = new List<clsQxPrjPotenceV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjPotenceV2EN objQxPrjPotenceV2EN = new clsQxPrjPotenceV2EN();
try
{
objQxPrjPotenceV2EN.PId = Int32.Parse(objRow[conQxPrjPotenceV2.PId].ToString().Trim()); //菜单Id
objQxPrjPotenceV2EN.PotenceName = objRow[conQxPrjPotenceV2.PotenceName].ToString().Trim(); //权限名称
objQxPrjPotenceV2EN.QxPrjId = objRow[conQxPrjPotenceV2.QxPrjId].ToString().Trim(); //项目Id
objQxPrjPotenceV2EN.FuncModuleId = objRow[conQxPrjPotenceV2.FuncModuleId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.FuncModuleId].ToString().Trim(); //模块Id
objQxPrjPotenceV2EN.PotenceTypeId = objRow[conQxPrjPotenceV2.PotenceTypeId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.PotenceTypeId].ToString().Trim(); //权限类型Id
objQxPrjPotenceV2EN.MenuId = objRow[conQxPrjPotenceV2.MenuId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.MenuId].ToString().Trim(); //菜单Id
objQxPrjPotenceV2EN.MenuId4Win = objRow[conQxPrjPotenceV2.MenuId4Win] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.MenuId4Win].ToString().Trim(); //菜单Id4Win
objQxPrjPotenceV2EN.UpdDate = objRow[conQxPrjPotenceV2.UpdDate] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.UpdDate].ToString().Trim(); //修改日期
objQxPrjPotenceV2EN.UpdUserId = objRow[conQxPrjPotenceV2.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjPotenceV2EN.Memo = objRow[conQxPrjPotenceV2.Memo] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjPotenceV2EN.PId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjPotenceV2EN);
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
public static List<clsQxPrjPotenceV2EN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsQxPrjPotenceV2EN> arrObjLst = new List<clsQxPrjPotenceV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjPotenceV2EN objQxPrjPotenceV2EN = new clsQxPrjPotenceV2EN();
try
{
objQxPrjPotenceV2EN.PId = Int32.Parse(objRow[conQxPrjPotenceV2.PId].ToString().Trim()); //菜单Id
objQxPrjPotenceV2EN.PotenceName = objRow[conQxPrjPotenceV2.PotenceName].ToString().Trim(); //权限名称
objQxPrjPotenceV2EN.QxPrjId = objRow[conQxPrjPotenceV2.QxPrjId].ToString().Trim(); //项目Id
objQxPrjPotenceV2EN.FuncModuleId = objRow[conQxPrjPotenceV2.FuncModuleId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.FuncModuleId].ToString().Trim(); //模块Id
objQxPrjPotenceV2EN.PotenceTypeId = objRow[conQxPrjPotenceV2.PotenceTypeId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.PotenceTypeId].ToString().Trim(); //权限类型Id
objQxPrjPotenceV2EN.MenuId = objRow[conQxPrjPotenceV2.MenuId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.MenuId].ToString().Trim(); //菜单Id
objQxPrjPotenceV2EN.MenuId4Win = objRow[conQxPrjPotenceV2.MenuId4Win] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.MenuId4Win].ToString().Trim(); //菜单Id4Win
objQxPrjPotenceV2EN.UpdDate = objRow[conQxPrjPotenceV2.UpdDate] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.UpdDate].ToString().Trim(); //修改日期
objQxPrjPotenceV2EN.UpdUserId = objRow[conQxPrjPotenceV2.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjPotenceV2EN.Memo = objRow[conQxPrjPotenceV2.Memo] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjPotenceV2EN.PId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjPotenceV2EN);
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
List<clsQxPrjPotenceV2EN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsQxPrjPotenceV2EN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPrjPotenceV2EN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsQxPrjPotenceV2EN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsQxPrjPotenceV2EN> arrObjLst = new List<clsQxPrjPotenceV2EN>(); 
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
	clsQxPrjPotenceV2EN objQxPrjPotenceV2EN = new clsQxPrjPotenceV2EN();
try
{
objQxPrjPotenceV2EN.PId = Int32.Parse(objRow[conQxPrjPotenceV2.PId].ToString().Trim()); //菜单Id
objQxPrjPotenceV2EN.PotenceName = objRow[conQxPrjPotenceV2.PotenceName].ToString().Trim(); //权限名称
objQxPrjPotenceV2EN.QxPrjId = objRow[conQxPrjPotenceV2.QxPrjId].ToString().Trim(); //项目Id
objQxPrjPotenceV2EN.FuncModuleId = objRow[conQxPrjPotenceV2.FuncModuleId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.FuncModuleId].ToString().Trim(); //模块Id
objQxPrjPotenceV2EN.PotenceTypeId = objRow[conQxPrjPotenceV2.PotenceTypeId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.PotenceTypeId].ToString().Trim(); //权限类型Id
objQxPrjPotenceV2EN.MenuId = objRow[conQxPrjPotenceV2.MenuId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.MenuId].ToString().Trim(); //菜单Id
objQxPrjPotenceV2EN.MenuId4Win = objRow[conQxPrjPotenceV2.MenuId4Win] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.MenuId4Win].ToString().Trim(); //菜单Id4Win
objQxPrjPotenceV2EN.UpdDate = objRow[conQxPrjPotenceV2.UpdDate] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.UpdDate].ToString().Trim(); //修改日期
objQxPrjPotenceV2EN.UpdUserId = objRow[conQxPrjPotenceV2.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjPotenceV2EN.Memo = objRow[conQxPrjPotenceV2.Memo] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjPotenceV2EN.PId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjPotenceV2EN);
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
public static List<clsQxPrjPotenceV2EN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsQxPrjPotenceV2EN> arrObjLst = new List<clsQxPrjPotenceV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjPotenceV2EN objQxPrjPotenceV2EN = new clsQxPrjPotenceV2EN();
try
{
objQxPrjPotenceV2EN.PId = Int32.Parse(objRow[conQxPrjPotenceV2.PId].ToString().Trim()); //菜单Id
objQxPrjPotenceV2EN.PotenceName = objRow[conQxPrjPotenceV2.PotenceName].ToString().Trim(); //权限名称
objQxPrjPotenceV2EN.QxPrjId = objRow[conQxPrjPotenceV2.QxPrjId].ToString().Trim(); //项目Id
objQxPrjPotenceV2EN.FuncModuleId = objRow[conQxPrjPotenceV2.FuncModuleId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.FuncModuleId].ToString().Trim(); //模块Id
objQxPrjPotenceV2EN.PotenceTypeId = objRow[conQxPrjPotenceV2.PotenceTypeId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.PotenceTypeId].ToString().Trim(); //权限类型Id
objQxPrjPotenceV2EN.MenuId = objRow[conQxPrjPotenceV2.MenuId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.MenuId].ToString().Trim(); //菜单Id
objQxPrjPotenceV2EN.MenuId4Win = objRow[conQxPrjPotenceV2.MenuId4Win] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.MenuId4Win].ToString().Trim(); //菜单Id4Win
objQxPrjPotenceV2EN.UpdDate = objRow[conQxPrjPotenceV2.UpdDate] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.UpdDate].ToString().Trim(); //修改日期
objQxPrjPotenceV2EN.UpdUserId = objRow[conQxPrjPotenceV2.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjPotenceV2EN.Memo = objRow[conQxPrjPotenceV2.Memo] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjPotenceV2EN.PId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjPotenceV2EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsQxPrjPotenceV2EN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsQxPrjPotenceV2EN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsQxPrjPotenceV2EN> arrObjLst = new List<clsQxPrjPotenceV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjPotenceV2EN objQxPrjPotenceV2EN = new clsQxPrjPotenceV2EN();
try
{
objQxPrjPotenceV2EN.PId = Int32.Parse(objRow[conQxPrjPotenceV2.PId].ToString().Trim()); //菜单Id
objQxPrjPotenceV2EN.PotenceName = objRow[conQxPrjPotenceV2.PotenceName].ToString().Trim(); //权限名称
objQxPrjPotenceV2EN.QxPrjId = objRow[conQxPrjPotenceV2.QxPrjId].ToString().Trim(); //项目Id
objQxPrjPotenceV2EN.FuncModuleId = objRow[conQxPrjPotenceV2.FuncModuleId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.FuncModuleId].ToString().Trim(); //模块Id
objQxPrjPotenceV2EN.PotenceTypeId = objRow[conQxPrjPotenceV2.PotenceTypeId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.PotenceTypeId].ToString().Trim(); //权限类型Id
objQxPrjPotenceV2EN.MenuId = objRow[conQxPrjPotenceV2.MenuId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.MenuId].ToString().Trim(); //菜单Id
objQxPrjPotenceV2EN.MenuId4Win = objRow[conQxPrjPotenceV2.MenuId4Win] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.MenuId4Win].ToString().Trim(); //菜单Id4Win
objQxPrjPotenceV2EN.UpdDate = objRow[conQxPrjPotenceV2.UpdDate] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.UpdDate].ToString().Trim(); //修改日期
objQxPrjPotenceV2EN.UpdUserId = objRow[conQxPrjPotenceV2.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjPotenceV2EN.Memo = objRow[conQxPrjPotenceV2.Memo] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjPotenceV2EN.PId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjPotenceV2EN);
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
public static List<clsQxPrjPotenceV2EN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsQxPrjPotenceV2EN> arrObjLst = new List<clsQxPrjPotenceV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjPotenceV2EN objQxPrjPotenceV2EN = new clsQxPrjPotenceV2EN();
try
{
objQxPrjPotenceV2EN.PId = Int32.Parse(objRow[conQxPrjPotenceV2.PId].ToString().Trim()); //菜单Id
objQxPrjPotenceV2EN.PotenceName = objRow[conQxPrjPotenceV2.PotenceName].ToString().Trim(); //权限名称
objQxPrjPotenceV2EN.QxPrjId = objRow[conQxPrjPotenceV2.QxPrjId].ToString().Trim(); //项目Id
objQxPrjPotenceV2EN.FuncModuleId = objRow[conQxPrjPotenceV2.FuncModuleId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.FuncModuleId].ToString().Trim(); //模块Id
objQxPrjPotenceV2EN.PotenceTypeId = objRow[conQxPrjPotenceV2.PotenceTypeId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.PotenceTypeId].ToString().Trim(); //权限类型Id
objQxPrjPotenceV2EN.MenuId = objRow[conQxPrjPotenceV2.MenuId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.MenuId].ToString().Trim(); //菜单Id
objQxPrjPotenceV2EN.MenuId4Win = objRow[conQxPrjPotenceV2.MenuId4Win] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.MenuId4Win].ToString().Trim(); //菜单Id4Win
objQxPrjPotenceV2EN.UpdDate = objRow[conQxPrjPotenceV2.UpdDate] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.UpdDate].ToString().Trim(); //修改日期
objQxPrjPotenceV2EN.UpdUserId = objRow[conQxPrjPotenceV2.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjPotenceV2EN.Memo = objRow[conQxPrjPotenceV2.Memo] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjPotenceV2EN.PId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjPotenceV2EN);
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
public static IEnumerable<clsQxPrjPotenceV2EN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsQxPrjPotenceV2EN objQxPrjPotenceV2Cond, string strOrderBy)
{
 string strQxPrjId = objQxPrjPotenceV2Cond.QxPrjId;
 if (string.IsNullOrEmpty(strQxPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000173)在表中,缓存分类字段值不能为空!(clsQxPrjPotenceV2BL:GetObjLstByPagerCache)");
throw new Exception(strMsg);
}
List<clsQxPrjPotenceV2EN> arrObjLstCache = GetObjLstCache(strQxPrjId);
IEnumerable <clsQxPrjPotenceV2EN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxPrjPotenceV2.AttributeName)
{
if (objQxPrjPotenceV2Cond.IsUpdated(strFldName) == false) continue;
if (objQxPrjPotenceV2Cond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxPrjPotenceV2Cond[strFldName].ToString());
}
else
{
if (objQxPrjPotenceV2Cond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxPrjPotenceV2Cond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxPrjPotenceV2Cond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxPrjPotenceV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxPrjPotenceV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxPrjPotenceV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxPrjPotenceV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxPrjPotenceV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxPrjPotenceV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxPrjPotenceV2Cond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxPrjPotenceV2Cond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxPrjPotenceV2Cond[strFldName]));
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
public static IEnumerable<clsQxPrjPotenceV2EN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsQxPrjPotenceV2EN objQxPrjPotenceV2Cond = JsonConvert.DeserializeObject<clsQxPrjPotenceV2EN>(objPagerPara.whereCond);
if (objQxPrjPotenceV2Cond.sfFldComparisonOp == null)
{
objQxPrjPotenceV2Cond.dicFldComparisonOp = null;
}
else
{
objQxPrjPotenceV2Cond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objQxPrjPotenceV2Cond.sfFldComparisonOp);
}
clsQxPrjPotenceV2BL.SetUpdFlag(objQxPrjPotenceV2Cond);
 try
{
CheckProperty4Condition(objQxPrjPotenceV2Cond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsQxPrjPotenceV2BL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objQxPrjPotenceV2Cond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPrjPotenceV2EN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsQxPrjPotenceV2EN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsQxPrjPotenceV2EN> arrObjLst = new List<clsQxPrjPotenceV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjPotenceV2EN objQxPrjPotenceV2EN = new clsQxPrjPotenceV2EN();
try
{
objQxPrjPotenceV2EN.PId = Int32.Parse(objRow[conQxPrjPotenceV2.PId].ToString().Trim()); //菜单Id
objQxPrjPotenceV2EN.PotenceName = objRow[conQxPrjPotenceV2.PotenceName].ToString().Trim(); //权限名称
objQxPrjPotenceV2EN.QxPrjId = objRow[conQxPrjPotenceV2.QxPrjId].ToString().Trim(); //项目Id
objQxPrjPotenceV2EN.FuncModuleId = objRow[conQxPrjPotenceV2.FuncModuleId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.FuncModuleId].ToString().Trim(); //模块Id
objQxPrjPotenceV2EN.PotenceTypeId = objRow[conQxPrjPotenceV2.PotenceTypeId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.PotenceTypeId].ToString().Trim(); //权限类型Id
objQxPrjPotenceV2EN.MenuId = objRow[conQxPrjPotenceV2.MenuId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.MenuId].ToString().Trim(); //菜单Id
objQxPrjPotenceV2EN.MenuId4Win = objRow[conQxPrjPotenceV2.MenuId4Win] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.MenuId4Win].ToString().Trim(); //菜单Id4Win
objQxPrjPotenceV2EN.UpdDate = objRow[conQxPrjPotenceV2.UpdDate] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.UpdDate].ToString().Trim(); //修改日期
objQxPrjPotenceV2EN.UpdUserId = objRow[conQxPrjPotenceV2.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjPotenceV2EN.Memo = objRow[conQxPrjPotenceV2.Memo] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjPotenceV2EN.PId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjPotenceV2EN);
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
public static List<clsQxPrjPotenceV2EN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsQxPrjPotenceV2EN> arrObjLst = new List<clsQxPrjPotenceV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjPotenceV2EN objQxPrjPotenceV2EN = new clsQxPrjPotenceV2EN();
try
{
objQxPrjPotenceV2EN.PId = Int32.Parse(objRow[conQxPrjPotenceV2.PId].ToString().Trim()); //菜单Id
objQxPrjPotenceV2EN.PotenceName = objRow[conQxPrjPotenceV2.PotenceName].ToString().Trim(); //权限名称
objQxPrjPotenceV2EN.QxPrjId = objRow[conQxPrjPotenceV2.QxPrjId].ToString().Trim(); //项目Id
objQxPrjPotenceV2EN.FuncModuleId = objRow[conQxPrjPotenceV2.FuncModuleId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.FuncModuleId].ToString().Trim(); //模块Id
objQxPrjPotenceV2EN.PotenceTypeId = objRow[conQxPrjPotenceV2.PotenceTypeId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.PotenceTypeId].ToString().Trim(); //权限类型Id
objQxPrjPotenceV2EN.MenuId = objRow[conQxPrjPotenceV2.MenuId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.MenuId].ToString().Trim(); //菜单Id
objQxPrjPotenceV2EN.MenuId4Win = objRow[conQxPrjPotenceV2.MenuId4Win] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.MenuId4Win].ToString().Trim(); //菜单Id4Win
objQxPrjPotenceV2EN.UpdDate = objRow[conQxPrjPotenceV2.UpdDate] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.UpdDate].ToString().Trim(); //修改日期
objQxPrjPotenceV2EN.UpdUserId = objRow[conQxPrjPotenceV2.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjPotenceV2EN.Memo = objRow[conQxPrjPotenceV2.Memo] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjPotenceV2EN.PId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjPotenceV2EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPrjPotenceV2EN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsQxPrjPotenceV2EN> arrObjLst = new List<clsQxPrjPotenceV2EN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjPotenceV2EN objQxPrjPotenceV2EN = new clsQxPrjPotenceV2EN();
try
{
objQxPrjPotenceV2EN.PId = Int32.Parse(objRow[conQxPrjPotenceV2.PId].ToString().Trim()); //菜单Id
objQxPrjPotenceV2EN.PotenceName = objRow[conQxPrjPotenceV2.PotenceName].ToString().Trim(); //权限名称
objQxPrjPotenceV2EN.QxPrjId = objRow[conQxPrjPotenceV2.QxPrjId].ToString().Trim(); //项目Id
objQxPrjPotenceV2EN.FuncModuleId = objRow[conQxPrjPotenceV2.FuncModuleId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.FuncModuleId].ToString().Trim(); //模块Id
objQxPrjPotenceV2EN.PotenceTypeId = objRow[conQxPrjPotenceV2.PotenceTypeId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.PotenceTypeId].ToString().Trim(); //权限类型Id
objQxPrjPotenceV2EN.MenuId = objRow[conQxPrjPotenceV2.MenuId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.MenuId].ToString().Trim(); //菜单Id
objQxPrjPotenceV2EN.MenuId4Win = objRow[conQxPrjPotenceV2.MenuId4Win] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.MenuId4Win].ToString().Trim(); //菜单Id4Win
objQxPrjPotenceV2EN.UpdDate = objRow[conQxPrjPotenceV2.UpdDate] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.UpdDate].ToString().Trim(); //修改日期
objQxPrjPotenceV2EN.UpdUserId = objRow[conQxPrjPotenceV2.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjPotenceV2EN.Memo = objRow[conQxPrjPotenceV2.Memo] == DBNull.Value ? null : objRow[conQxPrjPotenceV2.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjPotenceV2EN.PId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjPotenceV2EN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objQxPrjPotenceV2EN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxPrjPotenceV2(ref clsQxPrjPotenceV2EN objQxPrjPotenceV2EN)
{
bool bolResult = QxPrjPotenceV2DA.GetQxPrjPotenceV2(ref objQxPrjPotenceV2EN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "intPId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxPrjPotenceV2EN GetObjByPId(int intPId)
{
clsQxPrjPotenceV2EN objQxPrjPotenceV2EN = QxPrjPotenceV2DA.GetObjByPId(intPId);
return objQxPrjPotenceV2EN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsQxPrjPotenceV2EN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsQxPrjPotenceV2EN objQxPrjPotenceV2EN = QxPrjPotenceV2DA.GetFirstObj(strWhereCond);
 return objQxPrjPotenceV2EN;
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
public static clsQxPrjPotenceV2EN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsQxPrjPotenceV2EN objQxPrjPotenceV2EN = QxPrjPotenceV2DA.GetObjByDataRow(objRow);
 return objQxPrjPotenceV2EN;
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
public static clsQxPrjPotenceV2EN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsQxPrjPotenceV2EN objQxPrjPotenceV2EN = QxPrjPotenceV2DA.GetObjByDataRow(objRow);
 return objQxPrjPotenceV2EN;
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
 /// <param name = "intPId">所给的关键字</param>
 /// <param name = "lstQxPrjPotenceV2ObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxPrjPotenceV2EN GetObjByPIdFromList(int intPId, List<clsQxPrjPotenceV2EN> lstQxPrjPotenceV2ObjLst)
{
foreach (clsQxPrjPotenceV2EN objQxPrjPotenceV2EN in lstQxPrjPotenceV2ObjLst)
{
if (objQxPrjPotenceV2EN.PId == intPId)
{
return objQxPrjPotenceV2EN;
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
public static int GetFirstID_S(string strWhereCond) 
{
 int intPId;
 try
 {
 intPId = new clsQxPrjPotenceV2DA().GetFirstID(strWhereCond);
 return intPId;
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
 arrList = QxPrjPotenceV2DA.GetID(strWhereCond);
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
bool bolIsExist = QxPrjPotenceV2DA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "intPId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(int intPId)
{
//检测记录是否存在
bool bolIsExist = QxPrjPotenceV2DA.IsExist(intPId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "intPId">菜单Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(int intPId, string strOpUser)
{
clsQxPrjPotenceV2EN objQxPrjPotenceV2EN = clsQxPrjPotenceV2BL.GetObjByPId(intPId);
objQxPrjPotenceV2EN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objQxPrjPotenceV2EN.UpdUserId = strOpUser;
return clsQxPrjPotenceV2BL.UpdateBySql2(objQxPrjPotenceV2EN);
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
 bolIsExist = clsQxPrjPotenceV2DA.IsExistTable();
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
 bolIsExist = QxPrjPotenceV2DA.IsExistTable(strTabName);
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


 #region 添加记录

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AddNewRecordBySql2)
 /// </summary>
 /// <param name = "objQxPrjPotenceV2EN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsQxPrjPotenceV2EN objQxPrjPotenceV2EN)
{
if (objQxPrjPotenceV2EN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!权限名称 = [{0}],项目Id = [{1}]的数据已经存在!(in clsQxPrjPotenceV2BL.AddNewRecordBySql2)", objQxPrjPotenceV2EN.PotenceName,objQxPrjPotenceV2EN.QxPrjId);
throw new Exception(strMsg);
}
try
{
bool bolResult = QxPrjPotenceV2DA.AddNewRecordBySQL2(objQxPrjPotenceV2EN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjPotenceV2BL.ReFreshCache(objQxPrjPotenceV2EN.QxPrjId);

if (clsQxPrjPotenceV2BL.relatedActions != null)
{
clsQxPrjPotenceV2BL.relatedActions.UpdRelaTabDate(objQxPrjPotenceV2EN.PId, objQxPrjPotenceV2EN.UpdUserId);
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000030)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AddNewRecordBySql2WithReturnKey)
 /// </summary>
 /// <param name = "objQxPrjPotenceV2EN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsQxPrjPotenceV2EN objQxPrjPotenceV2EN)
{
if (objQxPrjPotenceV2EN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!权限名称 = [{0}],项目Id = [{1}]的数据已经存在!(in clsQxPrjPotenceV2BL.AddNewRecordBySql2WithReturnKey)", objQxPrjPotenceV2EN.PotenceName,objQxPrjPotenceV2EN.QxPrjId);
throw new Exception(strMsg);
}
try
{
string strKey = QxPrjPotenceV2DA.AddNewRecordBySQL2WithReturnKey(objQxPrjPotenceV2EN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjPotenceV2BL.ReFreshCache(objQxPrjPotenceV2EN.QxPrjId);

if (clsQxPrjPotenceV2BL.relatedActions != null)
{
clsQxPrjPotenceV2BL.relatedActions.UpdRelaTabDate(objQxPrjPotenceV2EN.PId, objQxPrjPotenceV2EN.UpdUserId);
}
return strKey;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000049)带返回值的添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,数据来源为代表实体对象的XML串
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、使用XML串来源来插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AddNewRecordBySql_XML)
 /// </summary>
 /// <param name = "strQxPrjPotenceV2ObjXml">代表实体对象的XML串</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql_XML(string strQxPrjPotenceV2ObjXml)
{
clsQxPrjPotenceV2EN objQxPrjPotenceV2EN = GetObjFromXmlStr(strQxPrjPotenceV2ObjXml);
try
{
bool bolResult = QxPrjPotenceV2DA.AddNewRecordBySQL2(objQxPrjPotenceV2EN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjPotenceV2BL.ReFreshCache(objQxPrjPotenceV2EN.QxPrjId);

if (clsQxPrjPotenceV2BL.relatedActions != null)
{
clsQxPrjPotenceV2BL.relatedActions.UpdRelaTabDate(objQxPrjPotenceV2EN.PId, objQxPrjPotenceV2EN.UpdUserId);
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000032)添加记录出错!(使用XML), {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 添加记录


 #region 修改记录

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Update)
 /// </summary>
 /// <param name = "objQxPrjPotenceV2EN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsQxPrjPotenceV2EN objQxPrjPotenceV2EN)
{
try
{
bool bolResult = QxPrjPotenceV2DA.Update(objQxPrjPotenceV2EN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjPotenceV2BL.ReFreshCache(objQxPrjPotenceV2EN.QxPrjId);

if (clsQxPrjPotenceV2BL.relatedActions != null)
{
clsQxPrjPotenceV2BL.relatedActions.UpdRelaTabDate(objQxPrjPotenceV2EN.PId, objQxPrjPotenceV2EN.UpdUserId);
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000033)修改记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_UpdateBySql2)
 /// </summary>
 /// <param name = "objQxPrjPotenceV2EN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsQxPrjPotenceV2EN objQxPrjPotenceV2EN)
{
 if (objQxPrjPotenceV2EN.PId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = QxPrjPotenceV2DA.UpdateBySql2(objQxPrjPotenceV2EN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjPotenceV2BL.ReFreshCache(objQxPrjPotenceV2EN.QxPrjId);

if (clsQxPrjPotenceV2BL.relatedActions != null)
{
clsQxPrjPotenceV2BL.relatedActions.UpdRelaTabDate(objQxPrjPotenceV2EN.PId, objQxPrjPotenceV2EN.UpdUserId);
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000034)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式提供XML串来代表实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_UpdateBySql_XML)
 /// </summary>
 /// <param name = "strQxPrjPotenceV2ObjXml">需要修改的对象,用XML来表示</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql_XML(string strQxPrjPotenceV2ObjXml)
{
clsQxPrjPotenceV2EN objQxPrjPotenceV2EN = GetObjFromXmlStr(strQxPrjPotenceV2ObjXml);
try
{
bool bolResult = QxPrjPotenceV2DA.UpdateBySql2(objQxPrjPotenceV2EN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjPotenceV2BL.ReFreshCache(objQxPrjPotenceV2EN.QxPrjId);

if (clsQxPrjPotenceV2BL.relatedActions != null)
{
clsQxPrjPotenceV2BL.relatedActions.UpdRelaTabDate(objQxPrjPotenceV2EN.PId, objQxPrjPotenceV2EN.UpdUserId);
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000038)修改记录(UpdateBySql_XML)出错,{1}.!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 修改记录


 #region 删除记录

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord)
 /// </summary>
 /// <param name = "intPId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(int intPId)
{
try
{
 clsQxPrjPotenceV2EN objQxPrjPotenceV2EN = clsQxPrjPotenceV2BL.GetObjByPId(intPId);

if (clsQxPrjPotenceV2BL.relatedActions != null)
{
clsQxPrjPotenceV2BL.relatedActions.UpdRelaTabDate(objQxPrjPotenceV2EN.PId, objQxPrjPotenceV2EN.UpdUserId);
}
if (objQxPrjPotenceV2EN != null)
{
int intRecNum = QxPrjPotenceV2DA.DelRecord(intPId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objQxPrjPotenceV2EN.QxPrjId);
return intRecNum;
}
            else
{
return 0;
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000039)根据关键字删除记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
/// 扩展删除记录,即同时删除多个表的记录,需要基于原子性的事务处理
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordEx)
/// </summary>
/// <param name="intPId">表关键字</param>
 /// <param name = "strQxPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(int intPId , string strQxPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
//删除TeacherInfo本表中与当前对象有关的记录
SqlConnection objConnection = null;
SqlTransaction objSqlTransaction = null;
  try
{
//获取连接对象
objConnection = objSQL.getConnectObj(objSQL.ConnectionString);
//获取该连接对象中的事务
objSqlTransaction = objConnection.BeginTransaction();
//
//删除与表:[QxPrjPotenceV2]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conQxPrjPotenceV2.PId,
//intPId);
//        clsQxPrjPotenceV2BL.DelQxPrjPotenceV2sByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxPrjPotenceV2BL.DelRecord(intPId, strQxPrjId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxPrjPotenceV2BLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
intPId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);
if (objSqlTransaction != null)
{
objSqlTransaction.Rollback();
}
throw new Exception(strMsg);
        }
finally
{
objConnection.Close();
}
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordWithTransaction_S)
 /// </summary>
 /// <param name = "intPId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(int intPId, string strQxPrjId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsQxPrjPotenceV2BL.relatedActions != null)
{
clsQxPrjPotenceV2BL.relatedActions.UpdRelaTabDate(intPId, "UpdRelaTabDate");
}
bool bolResult = QxPrjPotenceV2DA.DelRecord(intPId,objSqlConnection,objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(strQxPrjId);
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000040)根据关键字删除记录出错!(使用事务),{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:删除关键字所指定的记录,通过存储过程(SP)来删除。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordBySP_S)
 /// </summary>
 /// <param name = "intPId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(int intPId, string strQxPrjId) 
{
try
{
if (clsQxPrjPotenceV2BL.relatedActions != null)
{
clsQxPrjPotenceV2BL.relatedActions.UpdRelaTabDate(intPId, "UpdRelaTabDate");
}
bool bolResult = QxPrjPotenceV2DA.DelRecordBySP(intPId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(strQxPrjId);
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000041)通过存储过程删除记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelMultiRecord)
 /// </summary>
 /// <param name = "arrPIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelQxPrjPotenceV2s(List<string> arrPIdLst)
{
if (arrPIdLst.Count == 0) return 0;
try
{
if (clsQxPrjPotenceV2BL.relatedActions != null)
{
foreach (var strPId in arrPIdLst)
{
int intPId = int.Parse(strPId);
clsQxPrjPotenceV2BL.relatedActions.UpdRelaTabDate(intPId, "UpdRelaTabDate");
}
}
 clsQxPrjPotenceV2EN objQxPrjPotenceV2EN = clsQxPrjPotenceV2BL.GetObjByPId(int.Parse(arrPIdLst[0]));
int intDelRecNum = QxPrjPotenceV2DA.DelQxPrjPotenceV2(arrPIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objQxPrjPotenceV2EN.QxPrjId);
return intDelRecNum;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000042)删除多关键字记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelMultiRecordByCond)
 /// </summary>
 /// <param name = "strWhereCond">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public static int DelQxPrjPotenceV2sByCond(string strWhereCond)
{
try
{
if (clsQxPrjPotenceV2BL.relatedActions != null)
{
List<string> arrPId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strPId in arrPId)
{
int intPId = int.Parse(strPId);
clsQxPrjPotenceV2BL.relatedActions.UpdRelaTabDate(intPId, "UpdRelaTabDate");
}
}
List<string> arrQxPrjId = GetFldValue(conQxPrjPotenceV2.QxPrjId, strWhereCond);
int intRecNum = QxPrjPotenceV2DA.DelQxPrjPotenceV2(strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
arrQxPrjId.ForEach(x => ReFreshCache(x));
return intRecNum;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000043)删除带条件表记录出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
/// 扩展删除记录,即同时删除多个表的记录,需要基于原子性的事务处理
/// 这里仅仅是演示函数,使用时请复制到扩展类:[QxPrjPotenceV2]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="intPId">表关键字</param>
 /// <param name = "strQxPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(int intPId, string strQxPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxPrjPotenceV2DA.GetSpecSQLObj();
//删除TeacherInfo本表中与当前对象有关的记录
SqlConnection objConnection = null;
SqlTransaction objSqlTransaction = null;
  try
{
//获取连接对象
objConnection = objSQL.getConnectObj(objSQL.ConnectionString);
//获取该连接对象中的事务
objSqlTransaction = objConnection.BeginTransaction();
//
//删除与表:[QxPrjPotenceV2]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxPrjPotenceV2BL.DelRecord(intPId, strQxPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxPrjPotenceV2BL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
intPId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);
if (objSqlTransaction != null)
{
objSqlTransaction.Rollback();
}
throw new Exception(strMsg);
        }
finally
{
objConnection.Close();
}
}


 #endregion 删除记录


 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CopyObj_S)
 /// </summary>
 /// <param name = "objQxPrjPotenceV2ENS">源对象</param>
 /// <param name = "objQxPrjPotenceV2ENT">目标对象</param>
 public static void CopyTo(clsQxPrjPotenceV2EN objQxPrjPotenceV2ENS, clsQxPrjPotenceV2EN objQxPrjPotenceV2ENT)
{
try
{
objQxPrjPotenceV2ENT.PId = objQxPrjPotenceV2ENS.PId; //菜单Id
objQxPrjPotenceV2ENT.PotenceName = objQxPrjPotenceV2ENS.PotenceName; //权限名称
objQxPrjPotenceV2ENT.QxPrjId = objQxPrjPotenceV2ENS.QxPrjId; //项目Id
objQxPrjPotenceV2ENT.FuncModuleId = objQxPrjPotenceV2ENS.FuncModuleId; //模块Id
objQxPrjPotenceV2ENT.PotenceTypeId = objQxPrjPotenceV2ENS.PotenceTypeId; //权限类型Id
objQxPrjPotenceV2ENT.MenuId = objQxPrjPotenceV2ENS.MenuId; //菜单Id
objQxPrjPotenceV2ENT.MenuId4Win = objQxPrjPotenceV2ENS.MenuId4Win; //菜单Id4Win
objQxPrjPotenceV2ENT.UpdDate = objQxPrjPotenceV2ENS.UpdDate; //修改日期
objQxPrjPotenceV2ENT.UpdUserId = objQxPrjPotenceV2ENS.UpdUserId; //修改用户Id
objQxPrjPotenceV2ENT.Memo = objQxPrjPotenceV2ENS.Memo; //备注
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
 /// <param name = "objQxPrjPotenceV2EN">源简化对象</param>
 public static void SetUpdFlag(clsQxPrjPotenceV2EN objQxPrjPotenceV2EN)
{
try
{
objQxPrjPotenceV2EN.ClearUpdateState();
   string strsfUpdFldSetStr = objQxPrjPotenceV2EN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conQxPrjPotenceV2.PId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjPotenceV2EN.PId = objQxPrjPotenceV2EN.PId; //菜单Id
}
if (arrFldSet.Contains(conQxPrjPotenceV2.PotenceName, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjPotenceV2EN.PotenceName = objQxPrjPotenceV2EN.PotenceName; //权限名称
}
if (arrFldSet.Contains(conQxPrjPotenceV2.QxPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjPotenceV2EN.QxPrjId = objQxPrjPotenceV2EN.QxPrjId; //项目Id
}
if (arrFldSet.Contains(conQxPrjPotenceV2.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjPotenceV2EN.FuncModuleId = objQxPrjPotenceV2EN.FuncModuleId == "[null]" ? null :  objQxPrjPotenceV2EN.FuncModuleId; //模块Id
}
if (arrFldSet.Contains(conQxPrjPotenceV2.PotenceTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjPotenceV2EN.PotenceTypeId = objQxPrjPotenceV2EN.PotenceTypeId == "[null]" ? null :  objQxPrjPotenceV2EN.PotenceTypeId; //权限类型Id
}
if (arrFldSet.Contains(conQxPrjPotenceV2.MenuId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjPotenceV2EN.MenuId = objQxPrjPotenceV2EN.MenuId == "[null]" ? null :  objQxPrjPotenceV2EN.MenuId; //菜单Id
}
if (arrFldSet.Contains(conQxPrjPotenceV2.MenuId4Win, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjPotenceV2EN.MenuId4Win = objQxPrjPotenceV2EN.MenuId4Win == "[null]" ? null :  objQxPrjPotenceV2EN.MenuId4Win; //菜单Id4Win
}
if (arrFldSet.Contains(conQxPrjPotenceV2.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjPotenceV2EN.UpdDate = objQxPrjPotenceV2EN.UpdDate == "[null]" ? null :  objQxPrjPotenceV2EN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conQxPrjPotenceV2.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjPotenceV2EN.UpdUserId = objQxPrjPotenceV2EN.UpdUserId == "[null]" ? null :  objQxPrjPotenceV2EN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conQxPrjPotenceV2.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjPotenceV2EN.Memo = objQxPrjPotenceV2EN.Memo == "[null]" ? null :  objQxPrjPotenceV2EN.Memo; //备注
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
 /// <param name = "objQxPrjPotenceV2EN">源简化对象</param>
 public static void AccessFldValueNull(clsQxPrjPotenceV2EN objQxPrjPotenceV2EN)
{
try
{
if (objQxPrjPotenceV2EN.FuncModuleId == "[null]") objQxPrjPotenceV2EN.FuncModuleId = null; //模块Id
if (objQxPrjPotenceV2EN.PotenceTypeId == "[null]") objQxPrjPotenceV2EN.PotenceTypeId = null; //权限类型Id
if (objQxPrjPotenceV2EN.MenuId == "[null]") objQxPrjPotenceV2EN.MenuId = null; //菜单Id
if (objQxPrjPotenceV2EN.MenuId4Win == "[null]") objQxPrjPotenceV2EN.MenuId4Win = null; //菜单Id4Win
if (objQxPrjPotenceV2EN.UpdDate == "[null]") objQxPrjPotenceV2EN.UpdDate = null; //修改日期
if (objQxPrjPotenceV2EN.UpdUserId == "[null]") objQxPrjPotenceV2EN.UpdUserId = null; //修改用户Id
if (objQxPrjPotenceV2EN.Memo == "[null]") objQxPrjPotenceV2EN.Memo = null; //备注
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
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsQxPrjPotenceV2EN objQxPrjPotenceV2EN)
{
 QxPrjPotenceV2DA.CheckPropertyNew(objQxPrjPotenceV2EN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsQxPrjPotenceV2EN objQxPrjPotenceV2EN)
{
 QxPrjPotenceV2DA.CheckProperty4Condition(objQxPrjPotenceV2EN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_PIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strQxPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[工程权限V2]...","0");
List<clsQxPrjPotenceV2EN> arrQxPrjPotenceV2ObjLst = GetAllQxPrjPotenceV2ObjLstCache(strQxPrjId); 
objDDL.DataValueField = conQxPrjPotenceV2.PId;
objDDL.DataTextField = conQxPrjPotenceV2.PotenceName;
objDDL.DataSource = arrQxPrjPotenceV2ObjLst;
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
if (clsQxPrjPotenceV2BL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxPrjPotenceV2BL没有刷新缓存机制(clsQxPrjPotenceV2BL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PId");
//if (arrQxPrjPotenceV2ObjLstCache == null)
//{
//arrQxPrjPotenceV2ObjLstCache = QxPrjPotenceV2DA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "intPId">所给的关键字</param>
 /// <param name = "strQxPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxPrjPotenceV2EN GetObjByPIdCache(int intPId, string strQxPrjId)
{

if (string.IsNullOrEmpty(strQxPrjId) == true)
{
  var strMsg = string.Format("参数:[strQxPrjId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strQxPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strQxPrjId]的长度:[{0}]不正确!(In {1})", strQxPrjId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsQxPrjPotenceV2EN._CurrTabName, strQxPrjId);
List<clsQxPrjPotenceV2EN> arrQxPrjPotenceV2ObjLstCache = GetObjLstCache(strQxPrjId);
IEnumerable <clsQxPrjPotenceV2EN> arrQxPrjPotenceV2ObjLst_Sel =
arrQxPrjPotenceV2ObjLstCache
.Where(x=> x.PId == intPId 
);
if (arrQxPrjPotenceV2ObjLst_Sel.Count() == 0)
{
   clsQxPrjPotenceV2EN obj = clsQxPrjPotenceV2BL.GetObjByPId(intPId);
   if (obj != null)
 {
if (obj.QxPrjId == strQxPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", intPId, strQxPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrQxPrjPotenceV2ObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "intPId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetPotenceNameByPIdCache(int intPId, string strQxPrjId)
{
//获取缓存中的对象列表
clsQxPrjPotenceV2EN objQxPrjPotenceV2 = GetObjByPIdCache(intPId, strQxPrjId);
if (objQxPrjPotenceV2 == null) return "";
return objQxPrjPotenceV2.PotenceName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "intPId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByPIdCache(int intPId, string strQxPrjId)
{
//获取缓存中的对象列表
clsQxPrjPotenceV2EN objQxPrjPotenceV2 = GetObjByPIdCache(intPId, strQxPrjId);
if (objQxPrjPotenceV2 == null) return "";
return objQxPrjPotenceV2.PotenceName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxPrjPotenceV2EN> GetAllQxPrjPotenceV2ObjLstCache(string strQxPrjId)
{
//获取缓存中的对象列表
List<clsQxPrjPotenceV2EN> arrQxPrjPotenceV2ObjLstCache = GetObjLstCache(strQxPrjId); 
return arrQxPrjPotenceV2ObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxPrjPotenceV2EN> GetObjLstCache(string strQxPrjId)
{

if (string.IsNullOrEmpty(strQxPrjId) == true)
{
  var strMsg = string.Format("参数:[strQxPrjId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strQxPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strQxPrjId]的长度:[{0}]不正确!(In {1})", strQxPrjId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsQxPrjPotenceV2EN._CurrTabName, strQxPrjId);
string strCondition = string.Format("QxPrjId='{0}'", strQxPrjId);
List<clsQxPrjPotenceV2EN> arrQxPrjPotenceV2ObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrQxPrjPotenceV2ObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strQxPrjId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsQxPrjPotenceV2EN._CurrTabName, strQxPrjId);
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strQxPrjId)
{
if (string.IsNullOrEmpty(strQxPrjId) == true)
{
string strMsg = string.Format("缓存分类字段:[QxPrjId]不能为空!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxPrjPotenceV2BL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsQxPrjPotenceV2EN._CurrTabName, strQxPrjId);
CacheHelper.Remove(strKey);
clsQxPrjPotenceV2BL.objCommFun4BL.ReFreshCache(strQxPrjId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--QxPrjPotenceV2(工程权限V2)
 /// 唯一性条件:PotenceName_QxPrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQxPrjPotenceV2EN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsQxPrjPotenceV2EN objQxPrjPotenceV2EN)
{
//检测记录是否存在
string strResult = QxPrjPotenceV2DA.GetUniCondStr(objQxPrjPotenceV2EN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstQxPrjPotenceV2ObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsQxPrjPotenceV2EN> lstQxPrjPotenceV2ObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstQxPrjPotenceV2ObjLst, writer);
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
 /// <param name = "lstQxPrjPotenceV2ObjLst">[clsQxPrjPotenceV2EN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsQxPrjPotenceV2EN> lstQxPrjPotenceV2ObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsQxPrjPotenceV2BL.listXmlNode);
writer.WriteStartElement(clsQxPrjPotenceV2BL.itemsXmlNode);
foreach (clsQxPrjPotenceV2EN objQxPrjPotenceV2EN in lstQxPrjPotenceV2ObjLst)
{
clsQxPrjPotenceV2BL.SerializeXML(writer, objQxPrjPotenceV2EN);
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
 /// <param name = "objQxPrjPotenceV2EN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsQxPrjPotenceV2EN objQxPrjPotenceV2EN)
{
writer.WriteStartElement(clsQxPrjPotenceV2BL.itemXmlNode);
 
writer.WriteElementString(conQxPrjPotenceV2.PId, objQxPrjPotenceV2EN.PId.ToString(CultureInfo.InvariantCulture));
 
if (objQxPrjPotenceV2EN.PotenceName != null)
{
writer.WriteElementString(conQxPrjPotenceV2.PotenceName, objQxPrjPotenceV2EN.PotenceName.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjPotenceV2EN.QxPrjId != null)
{
writer.WriteElementString(conQxPrjPotenceV2.QxPrjId, objQxPrjPotenceV2EN.QxPrjId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjPotenceV2EN.FuncModuleId != null)
{
writer.WriteElementString(conQxPrjPotenceV2.FuncModuleId, objQxPrjPotenceV2EN.FuncModuleId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjPotenceV2EN.PotenceTypeId != null)
{
writer.WriteElementString(conQxPrjPotenceV2.PotenceTypeId, objQxPrjPotenceV2EN.PotenceTypeId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjPotenceV2EN.MenuId != null)
{
writer.WriteElementString(conQxPrjPotenceV2.MenuId, objQxPrjPotenceV2EN.MenuId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjPotenceV2EN.MenuId4Win != null)
{
writer.WriteElementString(conQxPrjPotenceV2.MenuId4Win, objQxPrjPotenceV2EN.MenuId4Win.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjPotenceV2EN.UpdDate != null)
{
writer.WriteElementString(conQxPrjPotenceV2.UpdDate, objQxPrjPotenceV2EN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjPotenceV2EN.UpdUserId != null)
{
writer.WriteElementString(conQxPrjPotenceV2.UpdUserId, objQxPrjPotenceV2EN.UpdUserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjPotenceV2EN.Memo != null)
{
writer.WriteElementString(conQxPrjPotenceV2.Memo, objQxPrjPotenceV2EN.Memo.ToString(CultureInfo.InvariantCulture));
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
public static clsQxPrjPotenceV2EN GetObjFromXml(System.Xml.XmlReader reader)
{
clsQxPrjPotenceV2EN objQxPrjPotenceV2EN = new clsQxPrjPotenceV2EN();
reader.Read();
while (!(reader.Name == clsQxPrjPotenceV2BL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(conQxPrjPotenceV2.PId))
{
objQxPrjPotenceV2EN.PId = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(conQxPrjPotenceV2.PotenceName))
{
objQxPrjPotenceV2EN.PotenceName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjPotenceV2.QxPrjId))
{
objQxPrjPotenceV2EN.QxPrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjPotenceV2.FuncModuleId))
{
objQxPrjPotenceV2EN.FuncModuleId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjPotenceV2.PotenceTypeId))
{
objQxPrjPotenceV2EN.PotenceTypeId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjPotenceV2.MenuId))
{
objQxPrjPotenceV2EN.MenuId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjPotenceV2.MenuId4Win))
{
objQxPrjPotenceV2EN.MenuId4Win = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjPotenceV2.UpdDate))
{
objQxPrjPotenceV2EN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjPotenceV2.UpdUserId))
{
objQxPrjPotenceV2EN.UpdUserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjPotenceV2.Memo))
{
objQxPrjPotenceV2EN.Memo = reader.ReadElementContentAsString();
}
}
return objQxPrjPotenceV2EN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strQxPrjPotenceV2ObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsQxPrjPotenceV2EN GetObjFromXmlStr(string strQxPrjPotenceV2ObjXmlStr)
{
clsQxPrjPotenceV2EN objQxPrjPotenceV2EN = new clsQxPrjPotenceV2EN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strQxPrjPotenceV2ObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsQxPrjPotenceV2BL.itemXmlNode))
{
objQxPrjPotenceV2EN = GetObjFromXml(reader);
return objQxPrjPotenceV2EN;
}
}
return objQxPrjPotenceV2EN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objQxPrjPotenceV2EN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsQxPrjPotenceV2EN objQxPrjPotenceV2EN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objQxPrjPotenceV2EN);
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
 /// <param name = "strQxPrjId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, int intPId, string strQxPrjId)
{
if (strInFldName != conQxPrjPotenceV2.PId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conQxPrjPotenceV2.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conQxPrjPotenceV2.AttributeName));
throw new Exception(strMsg);
}
var objQxPrjPotenceV2 = clsQxPrjPotenceV2BL.GetObjByPIdCache(intPId, strQxPrjId);
if (objQxPrjPotenceV2 == null) return "";
return objQxPrjPotenceV2[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objQxPrjPotenceV2EN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsQxPrjPotenceV2EN objQxPrjPotenceV2EN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsQxPrjPotenceV2EN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objQxPrjPotenceV2EN[strField]);
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
 /// <param name = "lstQxPrjPotenceV2ObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsQxPrjPotenceV2EN> lstQxPrjPotenceV2ObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstQxPrjPotenceV2ObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsQxPrjPotenceV2EN objQxPrjPotenceV2EN in lstQxPrjPotenceV2ObjLst)
{
string strJSON_One = SerializeObjToJSON(objQxPrjPotenceV2EN);
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
int intRecCount = clsQxPrjPotenceV2DA.GetRecCount(strTabName);
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
int intRecCount = clsQxPrjPotenceV2DA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsQxPrjPotenceV2DA.GetRecCount();
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
int intRecCount = clsQxPrjPotenceV2DA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objQxPrjPotenceV2Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsQxPrjPotenceV2EN objQxPrjPotenceV2Cond)
{
 string strQxPrjId = objQxPrjPotenceV2Cond.QxPrjId;
 if (string.IsNullOrEmpty(strQxPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsQxPrjPotenceV2BL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsQxPrjPotenceV2EN> arrObjLstCache = GetObjLstCache(strQxPrjId);
IEnumerable <clsQxPrjPotenceV2EN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxPrjPotenceV2.AttributeName)
{
if (objQxPrjPotenceV2Cond.IsUpdated(strFldName) == false) continue;
if (objQxPrjPotenceV2Cond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxPrjPotenceV2Cond[strFldName].ToString());
}
else
{
if (objQxPrjPotenceV2Cond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxPrjPotenceV2Cond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxPrjPotenceV2Cond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxPrjPotenceV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxPrjPotenceV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxPrjPotenceV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxPrjPotenceV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxPrjPotenceV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxPrjPotenceV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxPrjPotenceV2Cond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxPrjPotenceV2Cond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxPrjPotenceV2Cond[strFldName]));
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
 List<string> arrList = clsQxPrjPotenceV2DA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = QxPrjPotenceV2DA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = QxPrjPotenceV2DA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 /// <summary>
 /// 功能:设置当前表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4String)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public int SetFldValue(string strFldName, string strValue, string strWhereCond) 
{
int intRecCount = QxPrjPotenceV2DA.SetFldValue(strFldName, strValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}


 /// <summary>
 /// 功能:设置当前表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Float)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "fltValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public int SetFldValue(string strFldName, float fltValue, string strWhereCond) 
{
int intRecCount = clsQxPrjPotenceV2DA.SetFldValue(clsQxPrjPotenceV2EN._CurrTabName, strFldName, fltValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置当前表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Int)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "intValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public int SetFldValue(string strFldName, int intValue, string strWhereCond) 
{
int intRecCount = QxPrjPotenceV2DA.SetFldValue( strFldName, intValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4String_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue(string strTabName, string strFldName, string strValue, string strWhereCond) 
{
int intRecCount = clsQxPrjPotenceV2DA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Int_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue(string strTabName, string strFldName, int intValue, string strWhereCond) 
{
int intRecCount = clsQxPrjPotenceV2DA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Float_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue(string strTabName, string strFldName, float fltValue, string strWhereCond) 
{
int intRecCount = clsQxPrjPotenceV2DA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}



 #endregion 表操作常用函数


 #region 表操作

 /// <summary>
 /// 功能:获取建立表的代码
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GenSQLCode4CreateTab)
 /// </summary>
 /// <returns>建立表的代码</returns>
public static string GetCode4CreateTable() 
{
 StringBuilder strCreateTabCode = new StringBuilder();
  strCreateTabCode.Append("CREATE table [dbo].[QxPrjPotenceV2] "); 
 strCreateTabCode.Append(" ( "); 
 // /**菜单Id*/ 
 strCreateTabCode.Append(" PId int primary key identity, "); 
 // /**权限名称*/ 
 strCreateTabCode.Append(" PotenceName varchar(200) not Null, "); 
 // /**项目Id*/ 
 strCreateTabCode.Append(" QxPrjId char(4) not Null, "); 
 // /**模块Id*/ 
 strCreateTabCode.Append(" FuncModuleId char(4) Null, "); 
 // /**权限类型Id*/ 
 strCreateTabCode.Append(" PotenceTypeId char(6) Null, "); 
 // /**菜单Id*/ 
 strCreateTabCode.Append(" MenuId char(8) Null, "); 
 // /**菜单Id4Win*/ 
 strCreateTabCode.Append(" MenuId4Win char(8) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 数据同步


 #endregion 数据同步
}
 /// <summary>
 /// 工程权限V2(QxPrjPotenceV2)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4QxPrjPotenceV2 : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4BL4CSharp:Gen_4CFBL_ReFreshCache)
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
clsQxPrjPotenceV2BL.ReFreshThisCache(strQxPrjId);
}
}

}