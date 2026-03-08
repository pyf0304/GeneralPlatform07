
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxRoleMenusBL
 表名:QxRoleMenus(00140007)
 * 版本:2024.08.23.1(服务器:WIN-SRV103-116)
 日期:2024/08/29 09:32:50
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:菜单管理(MenuManage_GP)
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
public static class  clsQxRoleMenusBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxRoleMenusEN GetObj(this K_mId_QxRoleMenus myKey)
{
clsQxRoleMenusEN objQxRoleMenusEN = clsQxRoleMenusBL.QxRoleMenusDA.GetObjBymId(myKey.Value);
return objQxRoleMenusEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQxRoleMenusEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQxRoleMenusEN objQxRoleMenusEN)
{
if (CheckUniqueness(objQxRoleMenusEN) == false)
{
var strMsg = string.Format("记录已经存在!角色Id = [{0}],Cm项目Id = [{1}],菜单集Id = [{2}],菜单Id = [{3}]的数据已经存在!(in clsQxRoleMenusBL.AddNewRecord)", objQxRoleMenusEN.RoleId,objQxRoleMenusEN.CmPrjId,objQxRoleMenusEN.MenuSetId,objQxRoleMenusEN.MenuId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsQxRoleMenusBL.QxRoleMenusDA.AddNewRecordBySQL2(objQxRoleMenusEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRoleMenusBL.ReFreshCache();

if (clsQxRoleMenusBL.relatedActions != null)
{
clsQxRoleMenusBL.relatedActions.UpdRelaTabDate(objQxRoleMenusEN.mId, objQxRoleMenusEN.UpdUserId);
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
public static bool AddRecordEx(this clsQxRoleMenusEN objQxRoleMenusEN)
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
objQxRoleMenusEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objQxRoleMenusEN.CheckUniqueness() == false)
{
strMsg = string.Format("(角色Id(RoleId)=[{0}],Cm项目Id(CmPrjId)=[{1}],菜单集Id(MenuSetId)=[{2}],菜单Id(MenuId)=[{3}])已经存在,不能重复!", objQxRoleMenusEN.RoleId, objQxRoleMenusEN.CmPrjId, objQxRoleMenusEN.MenuSetId, objQxRoleMenusEN.MenuId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objQxRoleMenusEN.AddNewRecord();
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
 /// <param name = "objQxRoleMenusEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsQxRoleMenusEN objQxRoleMenusEN)
{
if (CheckUniqueness(objQxRoleMenusEN) == false)
{
var strMsg = string.Format("记录已经存在!角色Id = [{0}],Cm项目Id = [{1}],菜单集Id = [{2}],菜单Id = [{3}]的数据已经存在!(in clsQxRoleMenusBL.AddNewRecordWithReturnKey)", objQxRoleMenusEN.RoleId,objQxRoleMenusEN.CmPrjId,objQxRoleMenusEN.MenuSetId,objQxRoleMenusEN.MenuId);
throw new Exception(strMsg);
}
try
{
string strKey = clsQxRoleMenusBL.QxRoleMenusDA.AddNewRecordBySQL2WithReturnKey(objQxRoleMenusEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRoleMenusBL.ReFreshCache();

if (clsQxRoleMenusBL.relatedActions != null)
{
clsQxRoleMenusBL.relatedActions.UpdRelaTabDate(objQxRoleMenusEN.mId, objQxRoleMenusEN.UpdUserId);
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
 /// <param name = "objQxRoleMenusEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRoleMenusEN SetRoleId(this clsQxRoleMenusEN objQxRoleMenusEN, string strRoleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRoleId, conQxRoleMenus.RoleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRoleId, 8, conQxRoleMenus.RoleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, conQxRoleMenus.RoleId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRoleMenusEN SetQxPrjId(this clsQxRoleMenusEN objQxRoleMenusEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, conQxRoleMenus.QxPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQxPrjId, 4, conQxRoleMenus.QxPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, conQxRoleMenus.QxPrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRoleMenusEN SetCmPrjId(this clsQxRoleMenusEN objQxRoleMenusEN, string strCmPrjId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmPrjId, 6, conQxRoleMenus.CmPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCmPrjId, 6, conQxRoleMenus.CmPrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRoleMenusEN SetMenuSetId(this clsQxRoleMenusEN objQxRoleMenusEN, string strMenuSetId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMenuSetId, conQxRoleMenus.MenuSetId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuSetId, 4, conQxRoleMenus.MenuSetId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMenuSetId, 4, conQxRoleMenus.MenuSetId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRoleMenusEN SetMenuId(this clsQxRoleMenusEN objQxRoleMenusEN, string strMenuId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMenuId, conQxRoleMenus.MenuId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuId, 8, conQxRoleMenus.MenuId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMenuId, 8, conQxRoleMenus.MenuId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRoleMenusEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRoleMenusEN SetUpdDate(this clsQxRoleMenusEN objQxRoleMenusEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conQxRoleMenus.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQxRoleMenus.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRoleMenusEN SetUpdUserId(this clsQxRoleMenusEN objQxRoleMenusEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUserId, conQxRoleMenus.UpdUserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conQxRoleMenus.UpdUserId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRoleMenusEN SetMemo(this clsQxRoleMenusEN objQxRoleMenusEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQxRoleMenus.Memo);
}
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
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objQxRoleMenusEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsQxRoleMenusEN objQxRoleMenusEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objQxRoleMenusEN.CheckPropertyNew();
clsQxRoleMenusEN objQxRoleMenusCond = new clsQxRoleMenusEN();
string strCondition = objQxRoleMenusCond
.SetmId(objQxRoleMenusEN.mId, "<>")
.SetRoleId(objQxRoleMenusEN.RoleId, "=")
.SetCmPrjId(objQxRoleMenusEN.CmPrjId, "=")
.SetMenuSetId(objQxRoleMenusEN.MenuSetId, "=")
.SetMenuId(objQxRoleMenusEN.MenuId, "=")
.GetCombineCondition();
objQxRoleMenusEN._IsCheckProperty = true;
bool bolIsExist = clsQxRoleMenusBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(RoleId_CmPrjId_MenuSetId_MenuId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objQxRoleMenusEN.Update();
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
 /// <param name = "objQxRoleMenus">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsQxRoleMenusEN objQxRoleMenus)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsQxRoleMenusEN objQxRoleMenusCond = new clsQxRoleMenusEN();
string strCondition = objQxRoleMenusCond
.SetRoleId(objQxRoleMenus.RoleId, "=")
.SetCmPrjId(objQxRoleMenus.CmPrjId, "=")
.SetMenuSetId(objQxRoleMenus.MenuSetId, "=")
.SetMenuId(objQxRoleMenus.MenuId, "=")
.GetCombineCondition();
objQxRoleMenus._IsCheckProperty = true;
bool bolIsExist = clsQxRoleMenusBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objQxRoleMenus.mId = clsQxRoleMenusBL.GetFirstID_S(strCondition);
objQxRoleMenus.UpdateWithCondition(strCondition);
}
else
{
objQxRoleMenus.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objQxRoleMenusEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxRoleMenusEN objQxRoleMenusEN)
{
 if (objQxRoleMenusEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxRoleMenusBL.QxRoleMenusDA.UpdateBySql2(objQxRoleMenusEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRoleMenusBL.ReFreshCache();

if (clsQxRoleMenusBL.relatedActions != null)
{
clsQxRoleMenusBL.relatedActions.UpdRelaTabDate(objQxRoleMenusEN.mId, objQxRoleMenusEN.UpdUserId);
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
 /// <param name = "objQxRoleMenusEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxRoleMenusEN objQxRoleMenusEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objQxRoleMenusEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxRoleMenusBL.QxRoleMenusDA.UpdateBySql2(objQxRoleMenusEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRoleMenusBL.ReFreshCache();

if (clsQxRoleMenusBL.relatedActions != null)
{
clsQxRoleMenusBL.relatedActions.UpdRelaTabDate(objQxRoleMenusEN.mId, objQxRoleMenusEN.UpdUserId);
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
 /// <param name = "objQxRoleMenusEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxRoleMenusEN objQxRoleMenusEN, string strWhereCond)
{
try
{
bool bolResult = clsQxRoleMenusBL.QxRoleMenusDA.UpdateBySqlWithCondition(objQxRoleMenusEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRoleMenusBL.ReFreshCache();

if (clsQxRoleMenusBL.relatedActions != null)
{
clsQxRoleMenusBL.relatedActions.UpdRelaTabDate(objQxRoleMenusEN.mId, objQxRoleMenusEN.UpdUserId);
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
 /// <param name = "objQxRoleMenusEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxRoleMenusEN objQxRoleMenusEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsQxRoleMenusBL.QxRoleMenusDA.UpdateBySqlWithConditionTransaction(objQxRoleMenusEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRoleMenusBL.ReFreshCache();

if (clsQxRoleMenusBL.relatedActions != null)
{
clsQxRoleMenusBL.relatedActions.UpdRelaTabDate(objQxRoleMenusEN.mId, objQxRoleMenusEN.UpdUserId);
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsQxRoleMenusEN objQxRoleMenusEN)
{
try
{
int intRecNum = clsQxRoleMenusBL.QxRoleMenusDA.DelRecord(objQxRoleMenusEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRoleMenusBL.ReFreshCache();

if (clsQxRoleMenusBL.relatedActions != null)
{
clsQxRoleMenusBL.relatedActions.UpdRelaTabDate(objQxRoleMenusEN.mId, objQxRoleMenusEN.UpdUserId);
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
 /// <param name = "objQxRoleMenusENS">源对象</param>
 /// <param name = "objQxRoleMenusENT">目标对象</param>
 public static void CopyTo(this clsQxRoleMenusEN objQxRoleMenusENS, clsQxRoleMenusEN objQxRoleMenusENT)
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
 /// <param name = "objQxRoleMenusENS">源对象</param>
 /// <returns>目标对象=>clsQxRoleMenusEN:objQxRoleMenusENT</returns>
 public static clsQxRoleMenusEN CopyTo(this clsQxRoleMenusEN objQxRoleMenusENS)
{
try
{
 clsQxRoleMenusEN objQxRoleMenusENT = new clsQxRoleMenusEN()
{
mId = objQxRoleMenusENS.mId, //流水号
RoleId = objQxRoleMenusENS.RoleId, //角色Id
QxPrjId = objQxRoleMenusENS.QxPrjId, //项目Id
CmPrjId = objQxRoleMenusENS.CmPrjId, //Cm项目Id
MenuSetId = objQxRoleMenusENS.MenuSetId, //菜单集Id
MenuId = objQxRoleMenusENS.MenuId, //菜单Id
IsDisp = objQxRoleMenusENS.IsDisp, //是否显示
UpdDate = objQxRoleMenusENS.UpdDate, //修改日期
UpdUserId = objQxRoleMenusENS.UpdUserId, //修改用户Id
Memo = objQxRoleMenusENS.Memo, //备注
};
 return objQxRoleMenusENT;
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
public static void CheckPropertyNew(this clsQxRoleMenusEN objQxRoleMenusEN)
{
 clsQxRoleMenusBL.QxRoleMenusDA.CheckPropertyNew(objQxRoleMenusEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsQxRoleMenusEN objQxRoleMenusEN)
{
 clsQxRoleMenusBL.QxRoleMenusDA.CheckProperty4Condition(objQxRoleMenusEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// 检查唯一性(Uniqueness)--QxRoleMenus(角色菜单), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:RoleId_CmPrjId_MenuSetId_MenuId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objQxRoleMenusEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsQxRoleMenusEN objQxRoleMenusEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objQxRoleMenusEN == null) return true;
if (objQxRoleMenusEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and RoleId = '{0}'", objQxRoleMenusEN.RoleId);
 if (objQxRoleMenusEN.CmPrjId == null)
{
 sbCondition.AppendFormat(" and CmPrjId is null", objQxRoleMenusEN.CmPrjId);
}
else
{
 sbCondition.AppendFormat(" and CmPrjId = '{0}'", objQxRoleMenusEN.CmPrjId);
}
 sbCondition.AppendFormat(" and MenuSetId = '{0}'", objQxRoleMenusEN.MenuSetId);
 sbCondition.AppendFormat(" and MenuId = '{0}'", objQxRoleMenusEN.MenuId);
if (clsQxRoleMenusBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objQxRoleMenusEN.mId);
 sbCondition.AppendFormat(" and RoleId = '{0}'", objQxRoleMenusEN.RoleId);
 sbCondition.AppendFormat(" and CmPrjId = '{0}'", objQxRoleMenusEN.CmPrjId);
 sbCondition.AppendFormat(" and MenuSetId = '{0}'", objQxRoleMenusEN.MenuSetId);
 sbCondition.AppendFormat(" and MenuId = '{0}'", objQxRoleMenusEN.MenuId);
if (clsQxRoleMenusBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--QxRoleMenus(角色菜单), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:RoleId_CmPrjId_MenuSetId_MenuId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objQxRoleMenusEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsQxRoleMenusEN objQxRoleMenusEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objQxRoleMenusEN == null) return "";
if (objQxRoleMenusEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and RoleId = '{0}'", objQxRoleMenusEN.RoleId);
 if (objQxRoleMenusEN.CmPrjId == null)
{
 sbCondition.AppendFormat(" and CmPrjId is null", objQxRoleMenusEN.CmPrjId);
}
else
{
 sbCondition.AppendFormat(" and CmPrjId = '{0}'", objQxRoleMenusEN.CmPrjId);
}
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
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_QxRoleMenus
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 角色菜单(QxRoleMenus)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsQxRoleMenusBL
{
public static RelatedActions_QxRoleMenus relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "QxRoleMenusListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "QxRoleMenusList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsQxRoleMenusEN> arrQxRoleMenusObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsQxRoleMenusDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsQxRoleMenusDA QxRoleMenusDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsQxRoleMenusDA();
}
return uniqueInstance;
}
}

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsQxRoleMenusBL()
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
if (string.IsNullOrEmpty(clsQxRoleMenusEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxRoleMenusEN._ConnectString);
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
objDS = QxRoleMenusDA.GetDataSet(strWhereCond);
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
objDS = QxRoleMenusDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = QxRoleMenusDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_QxRoleMenus(string strWhereCond)
{
DataTable objDT;
try
{
objDT = QxRoleMenusDA.GetDataTable_QxRoleMenus(strWhereCond);
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
objDT = QxRoleMenusDA.GetDataTable(strWhereCond);
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
objDT = QxRoleMenusDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = QxRoleMenusDA.GetDataTable(strWhereCond, strTabName);
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
objDT = QxRoleMenusDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = QxRoleMenusDA.GetDataTable_Top(objTopPara);
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
objDT = QxRoleMenusDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = QxRoleMenusDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = QxRoleMenusDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = QxRoleMenusDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = QxRoleMenusDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = QxRoleMenusDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = QxRoleMenusDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = QxRoleMenusDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsQxRoleMenusEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsQxRoleMenusEN> arrObjLst = new List<clsQxRoleMenusEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMIdLst);
 string strWhereCond = string.Format("mId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRoleMenusEN objQxRoleMenusEN = new clsQxRoleMenusEN();
try
{
objQxRoleMenusEN.mId = Int32.Parse(objRow[conQxRoleMenus.mId].ToString().Trim()); //流水号
objQxRoleMenusEN.RoleId = objRow[conQxRoleMenus.RoleId].ToString().Trim(); //角色Id
objQxRoleMenusEN.QxPrjId = objRow[conQxRoleMenus.QxPrjId].ToString().Trim(); //项目Id
objQxRoleMenusEN.CmPrjId = objRow[conQxRoleMenus.CmPrjId] == DBNull.Value ? null : objRow[conQxRoleMenus.CmPrjId].ToString().Trim(); //Cm项目Id
objQxRoleMenusEN.MenuSetId = objRow[conQxRoleMenus.MenuSetId].ToString().Trim(); //菜单集Id
objQxRoleMenusEN.MenuId = objRow[conQxRoleMenus.MenuId].ToString().Trim(); //菜单Id
objQxRoleMenusEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[conQxRoleMenus.IsDisp].ToString().Trim()); //是否显示
objQxRoleMenusEN.UpdDate = objRow[conQxRoleMenus.UpdDate].ToString().Trim(); //修改日期
objQxRoleMenusEN.UpdUserId = objRow[conQxRoleMenus.UpdUserId].ToString().Trim(); //修改用户Id
objQxRoleMenusEN.Memo = objRow[conQxRoleMenus.Memo] == DBNull.Value ? null : objRow[conQxRoleMenus.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxRoleMenusEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxRoleMenusEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsQxRoleMenusEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsQxRoleMenusEN._CurrTabName);
List<clsQxRoleMenusEN> arrQxRoleMenusObjLstCache = GetObjLstCache();
IEnumerable <clsQxRoleMenusEN> arrQxRoleMenusObjLst_Sel =
arrQxRoleMenusObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrQxRoleMenusObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxRoleMenusEN> GetObjLst(string strWhereCond)
{
List<clsQxRoleMenusEN> arrObjLst = new List<clsQxRoleMenusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRoleMenusEN objQxRoleMenusEN = new clsQxRoleMenusEN();
try
{
objQxRoleMenusEN.mId = Int32.Parse(objRow[conQxRoleMenus.mId].ToString().Trim()); //流水号
objQxRoleMenusEN.RoleId = objRow[conQxRoleMenus.RoleId].ToString().Trim(); //角色Id
objQxRoleMenusEN.QxPrjId = objRow[conQxRoleMenus.QxPrjId].ToString().Trim(); //项目Id
objQxRoleMenusEN.CmPrjId = objRow[conQxRoleMenus.CmPrjId] == DBNull.Value ? null : objRow[conQxRoleMenus.CmPrjId].ToString().Trim(); //Cm项目Id
objQxRoleMenusEN.MenuSetId = objRow[conQxRoleMenus.MenuSetId].ToString().Trim(); //菜单集Id
objQxRoleMenusEN.MenuId = objRow[conQxRoleMenus.MenuId].ToString().Trim(); //菜单Id
objQxRoleMenusEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[conQxRoleMenus.IsDisp].ToString().Trim()); //是否显示
objQxRoleMenusEN.UpdDate = objRow[conQxRoleMenus.UpdDate].ToString().Trim(); //修改日期
objQxRoleMenusEN.UpdUserId = objRow[conQxRoleMenus.UpdUserId].ToString().Trim(); //修改用户Id
objQxRoleMenusEN.Memo = objRow[conQxRoleMenus.Memo] == DBNull.Value ? null : objRow[conQxRoleMenus.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxRoleMenusEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxRoleMenusEN);
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
public static List<clsQxRoleMenusEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsQxRoleMenusEN> arrObjLst = new List<clsQxRoleMenusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRoleMenusEN objQxRoleMenusEN = new clsQxRoleMenusEN();
try
{
objQxRoleMenusEN.mId = Int32.Parse(objRow[conQxRoleMenus.mId].ToString().Trim()); //流水号
objQxRoleMenusEN.RoleId = objRow[conQxRoleMenus.RoleId].ToString().Trim(); //角色Id
objQxRoleMenusEN.QxPrjId = objRow[conQxRoleMenus.QxPrjId].ToString().Trim(); //项目Id
objQxRoleMenusEN.CmPrjId = objRow[conQxRoleMenus.CmPrjId] == DBNull.Value ? null : objRow[conQxRoleMenus.CmPrjId].ToString().Trim(); //Cm项目Id
objQxRoleMenusEN.MenuSetId = objRow[conQxRoleMenus.MenuSetId].ToString().Trim(); //菜单集Id
objQxRoleMenusEN.MenuId = objRow[conQxRoleMenus.MenuId].ToString().Trim(); //菜单Id
objQxRoleMenusEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[conQxRoleMenus.IsDisp].ToString().Trim()); //是否显示
objQxRoleMenusEN.UpdDate = objRow[conQxRoleMenus.UpdDate].ToString().Trim(); //修改日期
objQxRoleMenusEN.UpdUserId = objRow[conQxRoleMenus.UpdUserId].ToString().Trim(); //修改用户Id
objQxRoleMenusEN.Memo = objRow[conQxRoleMenus.Memo] == DBNull.Value ? null : objRow[conQxRoleMenus.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxRoleMenusEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxRoleMenusEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objQxRoleMenusCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsQxRoleMenusEN> GetSubObjLstCache(clsQxRoleMenusEN objQxRoleMenusCond)
{
List<clsQxRoleMenusEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxRoleMenusEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxRoleMenus.AttributeName)
{
if (objQxRoleMenusCond.IsUpdated(strFldName) == false) continue;
if (objQxRoleMenusCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxRoleMenusCond[strFldName].ToString());
}
else
{
if (objQxRoleMenusCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxRoleMenusCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxRoleMenusCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxRoleMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxRoleMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxRoleMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxRoleMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxRoleMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxRoleMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxRoleMenusCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxRoleMenusCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxRoleMenusCond[strFldName]));
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
public static List<clsQxRoleMenusEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsQxRoleMenusEN> arrObjLst = new List<clsQxRoleMenusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRoleMenusEN objQxRoleMenusEN = new clsQxRoleMenusEN();
try
{
objQxRoleMenusEN.mId = Int32.Parse(objRow[conQxRoleMenus.mId].ToString().Trim()); //流水号
objQxRoleMenusEN.RoleId = objRow[conQxRoleMenus.RoleId].ToString().Trim(); //角色Id
objQxRoleMenusEN.QxPrjId = objRow[conQxRoleMenus.QxPrjId].ToString().Trim(); //项目Id
objQxRoleMenusEN.CmPrjId = objRow[conQxRoleMenus.CmPrjId] == DBNull.Value ? null : objRow[conQxRoleMenus.CmPrjId].ToString().Trim(); //Cm项目Id
objQxRoleMenusEN.MenuSetId = objRow[conQxRoleMenus.MenuSetId].ToString().Trim(); //菜单集Id
objQxRoleMenusEN.MenuId = objRow[conQxRoleMenus.MenuId].ToString().Trim(); //菜单Id
objQxRoleMenusEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[conQxRoleMenus.IsDisp].ToString().Trim()); //是否显示
objQxRoleMenusEN.UpdDate = objRow[conQxRoleMenus.UpdDate].ToString().Trim(); //修改日期
objQxRoleMenusEN.UpdUserId = objRow[conQxRoleMenus.UpdUserId].ToString().Trim(); //修改用户Id
objQxRoleMenusEN.Memo = objRow[conQxRoleMenus.Memo] == DBNull.Value ? null : objRow[conQxRoleMenus.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxRoleMenusEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxRoleMenusEN);
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
public static List<clsQxRoleMenusEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsQxRoleMenusEN> arrObjLst = new List<clsQxRoleMenusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRoleMenusEN objQxRoleMenusEN = new clsQxRoleMenusEN();
try
{
objQxRoleMenusEN.mId = Int32.Parse(objRow[conQxRoleMenus.mId].ToString().Trim()); //流水号
objQxRoleMenusEN.RoleId = objRow[conQxRoleMenus.RoleId].ToString().Trim(); //角色Id
objQxRoleMenusEN.QxPrjId = objRow[conQxRoleMenus.QxPrjId].ToString().Trim(); //项目Id
objQxRoleMenusEN.CmPrjId = objRow[conQxRoleMenus.CmPrjId] == DBNull.Value ? null : objRow[conQxRoleMenus.CmPrjId].ToString().Trim(); //Cm项目Id
objQxRoleMenusEN.MenuSetId = objRow[conQxRoleMenus.MenuSetId].ToString().Trim(); //菜单集Id
objQxRoleMenusEN.MenuId = objRow[conQxRoleMenus.MenuId].ToString().Trim(); //菜单Id
objQxRoleMenusEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[conQxRoleMenus.IsDisp].ToString().Trim()); //是否显示
objQxRoleMenusEN.UpdDate = objRow[conQxRoleMenus.UpdDate].ToString().Trim(); //修改日期
objQxRoleMenusEN.UpdUserId = objRow[conQxRoleMenus.UpdUserId].ToString().Trim(); //修改用户Id
objQxRoleMenusEN.Memo = objRow[conQxRoleMenus.Memo] == DBNull.Value ? null : objRow[conQxRoleMenus.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxRoleMenusEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxRoleMenusEN);
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
List<clsQxRoleMenusEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsQxRoleMenusEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxRoleMenusEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsQxRoleMenusEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsQxRoleMenusEN> arrObjLst = new List<clsQxRoleMenusEN>(); 
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
	clsQxRoleMenusEN objQxRoleMenusEN = new clsQxRoleMenusEN();
try
{
objQxRoleMenusEN.mId = Int32.Parse(objRow[conQxRoleMenus.mId].ToString().Trim()); //流水号
objQxRoleMenusEN.RoleId = objRow[conQxRoleMenus.RoleId].ToString().Trim(); //角色Id
objQxRoleMenusEN.QxPrjId = objRow[conQxRoleMenus.QxPrjId].ToString().Trim(); //项目Id
objQxRoleMenusEN.CmPrjId = objRow[conQxRoleMenus.CmPrjId] == DBNull.Value ? null : objRow[conQxRoleMenus.CmPrjId].ToString().Trim(); //Cm项目Id
objQxRoleMenusEN.MenuSetId = objRow[conQxRoleMenus.MenuSetId].ToString().Trim(); //菜单集Id
objQxRoleMenusEN.MenuId = objRow[conQxRoleMenus.MenuId].ToString().Trim(); //菜单Id
objQxRoleMenusEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[conQxRoleMenus.IsDisp].ToString().Trim()); //是否显示
objQxRoleMenusEN.UpdDate = objRow[conQxRoleMenus.UpdDate].ToString().Trim(); //修改日期
objQxRoleMenusEN.UpdUserId = objRow[conQxRoleMenus.UpdUserId].ToString().Trim(); //修改用户Id
objQxRoleMenusEN.Memo = objRow[conQxRoleMenus.Memo] == DBNull.Value ? null : objRow[conQxRoleMenus.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxRoleMenusEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxRoleMenusEN);
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
public static List<clsQxRoleMenusEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsQxRoleMenusEN> arrObjLst = new List<clsQxRoleMenusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRoleMenusEN objQxRoleMenusEN = new clsQxRoleMenusEN();
try
{
objQxRoleMenusEN.mId = Int32.Parse(objRow[conQxRoleMenus.mId].ToString().Trim()); //流水号
objQxRoleMenusEN.RoleId = objRow[conQxRoleMenus.RoleId].ToString().Trim(); //角色Id
objQxRoleMenusEN.QxPrjId = objRow[conQxRoleMenus.QxPrjId].ToString().Trim(); //项目Id
objQxRoleMenusEN.CmPrjId = objRow[conQxRoleMenus.CmPrjId] == DBNull.Value ? null : objRow[conQxRoleMenus.CmPrjId].ToString().Trim(); //Cm项目Id
objQxRoleMenusEN.MenuSetId = objRow[conQxRoleMenus.MenuSetId].ToString().Trim(); //菜单集Id
objQxRoleMenusEN.MenuId = objRow[conQxRoleMenus.MenuId].ToString().Trim(); //菜单Id
objQxRoleMenusEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[conQxRoleMenus.IsDisp].ToString().Trim()); //是否显示
objQxRoleMenusEN.UpdDate = objRow[conQxRoleMenus.UpdDate].ToString().Trim(); //修改日期
objQxRoleMenusEN.UpdUserId = objRow[conQxRoleMenus.UpdUserId].ToString().Trim(); //修改用户Id
objQxRoleMenusEN.Memo = objRow[conQxRoleMenus.Memo] == DBNull.Value ? null : objRow[conQxRoleMenus.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxRoleMenusEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxRoleMenusEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsQxRoleMenusEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsQxRoleMenusEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsQxRoleMenusEN> arrObjLst = new List<clsQxRoleMenusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRoleMenusEN objQxRoleMenusEN = new clsQxRoleMenusEN();
try
{
objQxRoleMenusEN.mId = Int32.Parse(objRow[conQxRoleMenus.mId].ToString().Trim()); //流水号
objQxRoleMenusEN.RoleId = objRow[conQxRoleMenus.RoleId].ToString().Trim(); //角色Id
objQxRoleMenusEN.QxPrjId = objRow[conQxRoleMenus.QxPrjId].ToString().Trim(); //项目Id
objQxRoleMenusEN.CmPrjId = objRow[conQxRoleMenus.CmPrjId] == DBNull.Value ? null : objRow[conQxRoleMenus.CmPrjId].ToString().Trim(); //Cm项目Id
objQxRoleMenusEN.MenuSetId = objRow[conQxRoleMenus.MenuSetId].ToString().Trim(); //菜单集Id
objQxRoleMenusEN.MenuId = objRow[conQxRoleMenus.MenuId].ToString().Trim(); //菜单Id
objQxRoleMenusEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[conQxRoleMenus.IsDisp].ToString().Trim()); //是否显示
objQxRoleMenusEN.UpdDate = objRow[conQxRoleMenus.UpdDate].ToString().Trim(); //修改日期
objQxRoleMenusEN.UpdUserId = objRow[conQxRoleMenus.UpdUserId].ToString().Trim(); //修改用户Id
objQxRoleMenusEN.Memo = objRow[conQxRoleMenus.Memo] == DBNull.Value ? null : objRow[conQxRoleMenus.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxRoleMenusEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxRoleMenusEN);
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
public static List<clsQxRoleMenusEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsQxRoleMenusEN> arrObjLst = new List<clsQxRoleMenusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRoleMenusEN objQxRoleMenusEN = new clsQxRoleMenusEN();
try
{
objQxRoleMenusEN.mId = Int32.Parse(objRow[conQxRoleMenus.mId].ToString().Trim()); //流水号
objQxRoleMenusEN.RoleId = objRow[conQxRoleMenus.RoleId].ToString().Trim(); //角色Id
objQxRoleMenusEN.QxPrjId = objRow[conQxRoleMenus.QxPrjId].ToString().Trim(); //项目Id
objQxRoleMenusEN.CmPrjId = objRow[conQxRoleMenus.CmPrjId] == DBNull.Value ? null : objRow[conQxRoleMenus.CmPrjId].ToString().Trim(); //Cm项目Id
objQxRoleMenusEN.MenuSetId = objRow[conQxRoleMenus.MenuSetId].ToString().Trim(); //菜单集Id
objQxRoleMenusEN.MenuId = objRow[conQxRoleMenus.MenuId].ToString().Trim(); //菜单Id
objQxRoleMenusEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[conQxRoleMenus.IsDisp].ToString().Trim()); //是否显示
objQxRoleMenusEN.UpdDate = objRow[conQxRoleMenus.UpdDate].ToString().Trim(); //修改日期
objQxRoleMenusEN.UpdUserId = objRow[conQxRoleMenus.UpdUserId].ToString().Trim(); //修改用户Id
objQxRoleMenusEN.Memo = objRow[conQxRoleMenus.Memo] == DBNull.Value ? null : objRow[conQxRoleMenus.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxRoleMenusEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxRoleMenusEN);
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
public static IEnumerable<clsQxRoleMenusEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsQxRoleMenusEN objQxRoleMenusCond, string strOrderBy)
{
List<clsQxRoleMenusEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxRoleMenusEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxRoleMenus.AttributeName)
{
if (objQxRoleMenusCond.IsUpdated(strFldName) == false) continue;
if (objQxRoleMenusCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxRoleMenusCond[strFldName].ToString());
}
else
{
if (objQxRoleMenusCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxRoleMenusCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxRoleMenusCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxRoleMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxRoleMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxRoleMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxRoleMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxRoleMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxRoleMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxRoleMenusCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxRoleMenusCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxRoleMenusCond[strFldName]));
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
public static IEnumerable<clsQxRoleMenusEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsQxRoleMenusEN objQxRoleMenusCond = JsonConvert.DeserializeObject<clsQxRoleMenusEN>(objPagerPara.whereCond);
if (objQxRoleMenusCond.sfFldComparisonOp == null)
{
objQxRoleMenusCond.dicFldComparisonOp = null;
}
else
{
objQxRoleMenusCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objQxRoleMenusCond.sfFldComparisonOp);
}
clsQxRoleMenusBL.SetUpdFlag(objQxRoleMenusCond);
 try
{
CheckProperty4Condition(objQxRoleMenusCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsQxRoleMenusBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objQxRoleMenusCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxRoleMenusEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsQxRoleMenusEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsQxRoleMenusEN> arrObjLst = new List<clsQxRoleMenusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRoleMenusEN objQxRoleMenusEN = new clsQxRoleMenusEN();
try
{
objQxRoleMenusEN.mId = Int32.Parse(objRow[conQxRoleMenus.mId].ToString().Trim()); //流水号
objQxRoleMenusEN.RoleId = objRow[conQxRoleMenus.RoleId].ToString().Trim(); //角色Id
objQxRoleMenusEN.QxPrjId = objRow[conQxRoleMenus.QxPrjId].ToString().Trim(); //项目Id
objQxRoleMenusEN.CmPrjId = objRow[conQxRoleMenus.CmPrjId] == DBNull.Value ? null : objRow[conQxRoleMenus.CmPrjId].ToString().Trim(); //Cm项目Id
objQxRoleMenusEN.MenuSetId = objRow[conQxRoleMenus.MenuSetId].ToString().Trim(); //菜单集Id
objQxRoleMenusEN.MenuId = objRow[conQxRoleMenus.MenuId].ToString().Trim(); //菜单Id
objQxRoleMenusEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[conQxRoleMenus.IsDisp].ToString().Trim()); //是否显示
objQxRoleMenusEN.UpdDate = objRow[conQxRoleMenus.UpdDate].ToString().Trim(); //修改日期
objQxRoleMenusEN.UpdUserId = objRow[conQxRoleMenus.UpdUserId].ToString().Trim(); //修改用户Id
objQxRoleMenusEN.Memo = objRow[conQxRoleMenus.Memo] == DBNull.Value ? null : objRow[conQxRoleMenus.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxRoleMenusEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxRoleMenusEN);
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
public static List<clsQxRoleMenusEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsQxRoleMenusEN> arrObjLst = new List<clsQxRoleMenusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRoleMenusEN objQxRoleMenusEN = new clsQxRoleMenusEN();
try
{
objQxRoleMenusEN.mId = Int32.Parse(objRow[conQxRoleMenus.mId].ToString().Trim()); //流水号
objQxRoleMenusEN.RoleId = objRow[conQxRoleMenus.RoleId].ToString().Trim(); //角色Id
objQxRoleMenusEN.QxPrjId = objRow[conQxRoleMenus.QxPrjId].ToString().Trim(); //项目Id
objQxRoleMenusEN.CmPrjId = objRow[conQxRoleMenus.CmPrjId] == DBNull.Value ? null : objRow[conQxRoleMenus.CmPrjId].ToString().Trim(); //Cm项目Id
objQxRoleMenusEN.MenuSetId = objRow[conQxRoleMenus.MenuSetId].ToString().Trim(); //菜单集Id
objQxRoleMenusEN.MenuId = objRow[conQxRoleMenus.MenuId].ToString().Trim(); //菜单Id
objQxRoleMenusEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[conQxRoleMenus.IsDisp].ToString().Trim()); //是否显示
objQxRoleMenusEN.UpdDate = objRow[conQxRoleMenus.UpdDate].ToString().Trim(); //修改日期
objQxRoleMenusEN.UpdUserId = objRow[conQxRoleMenus.UpdUserId].ToString().Trim(); //修改用户Id
objQxRoleMenusEN.Memo = objRow[conQxRoleMenus.Memo] == DBNull.Value ? null : objRow[conQxRoleMenus.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxRoleMenusEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxRoleMenusEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxRoleMenusEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsQxRoleMenusEN> arrObjLst = new List<clsQxRoleMenusEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRoleMenusEN objQxRoleMenusEN = new clsQxRoleMenusEN();
try
{
objQxRoleMenusEN.mId = Int32.Parse(objRow[conQxRoleMenus.mId].ToString().Trim()); //流水号
objQxRoleMenusEN.RoleId = objRow[conQxRoleMenus.RoleId].ToString().Trim(); //角色Id
objQxRoleMenusEN.QxPrjId = objRow[conQxRoleMenus.QxPrjId].ToString().Trim(); //项目Id
objQxRoleMenusEN.CmPrjId = objRow[conQxRoleMenus.CmPrjId] == DBNull.Value ? null : objRow[conQxRoleMenus.CmPrjId].ToString().Trim(); //Cm项目Id
objQxRoleMenusEN.MenuSetId = objRow[conQxRoleMenus.MenuSetId].ToString().Trim(); //菜单集Id
objQxRoleMenusEN.MenuId = objRow[conQxRoleMenus.MenuId].ToString().Trim(); //菜单Id
objQxRoleMenusEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[conQxRoleMenus.IsDisp].ToString().Trim()); //是否显示
objQxRoleMenusEN.UpdDate = objRow[conQxRoleMenus.UpdDate].ToString().Trim(); //修改日期
objQxRoleMenusEN.UpdUserId = objRow[conQxRoleMenus.UpdUserId].ToString().Trim(); //修改用户Id
objQxRoleMenusEN.Memo = objRow[conQxRoleMenus.Memo] == DBNull.Value ? null : objRow[conQxRoleMenus.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxRoleMenusEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxRoleMenusEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objQxRoleMenusEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxRoleMenus(ref clsQxRoleMenusEN objQxRoleMenusEN)
{
bool bolResult = QxRoleMenusDA.GetQxRoleMenus(ref objQxRoleMenusEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxRoleMenusEN GetObjBymId(long lngmId)
{
clsQxRoleMenusEN objQxRoleMenusEN = QxRoleMenusDA.GetObjBymId(lngmId);
return objQxRoleMenusEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsQxRoleMenusEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsQxRoleMenusEN objQxRoleMenusEN = QxRoleMenusDA.GetFirstObj(strWhereCond);
 return objQxRoleMenusEN;
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
public static clsQxRoleMenusEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsQxRoleMenusEN objQxRoleMenusEN = QxRoleMenusDA.GetObjByDataRow(objRow);
 return objQxRoleMenusEN;
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
public static clsQxRoleMenusEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsQxRoleMenusEN objQxRoleMenusEN = QxRoleMenusDA.GetObjByDataRow(objRow);
 return objQxRoleMenusEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "lstQxRoleMenusObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxRoleMenusEN GetObjBymIdFromList(long lngmId, List<clsQxRoleMenusEN> lstQxRoleMenusObjLst)
{
foreach (clsQxRoleMenusEN objQxRoleMenusEN in lstQxRoleMenusObjLst)
{
if (objQxRoleMenusEN.mId == lngmId)
{
return objQxRoleMenusEN;
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
public static long GetFirstID_S(string strWhereCond) 
{
 long lngmId;
 try
 {
 lngmId = new clsQxRoleMenusDA().GetFirstID(strWhereCond);
 return lngmId;
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
 arrList = QxRoleMenusDA.GetID(strWhereCond);
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
bool bolIsExist = QxRoleMenusDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngmId)
{
//检测记录是否存在
bool bolIsExist = QxRoleMenusDA.IsExist(lngmId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngmId">流水号</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngmId, string strOpUser)
{
clsQxRoleMenusEN objQxRoleMenusEN = clsQxRoleMenusBL.GetObjBymId(lngmId);
objQxRoleMenusEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objQxRoleMenusEN.UpdUserId = strOpUser;
return clsQxRoleMenusBL.UpdateBySql2(objQxRoleMenusEN);
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
 bolIsExist = clsQxRoleMenusDA.IsExistTable();
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
 bolIsExist = QxRoleMenusDA.IsExistTable(strTabName);
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
 /// <param name = "objQxRoleMenusEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsQxRoleMenusEN objQxRoleMenusEN)
{
if (objQxRoleMenusEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!角色Id = [{0}],Cm项目Id = [{1}],菜单集Id = [{2}],菜单Id = [{3}]的数据已经存在!(in clsQxRoleMenusBL.AddNewRecordBySql2)", objQxRoleMenusEN.RoleId,objQxRoleMenusEN.CmPrjId,objQxRoleMenusEN.MenuSetId,objQxRoleMenusEN.MenuId);
throw new Exception(strMsg);
}
try
{
bool bolResult = QxRoleMenusDA.AddNewRecordBySQL2(objQxRoleMenusEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRoleMenusBL.ReFreshCache();

if (clsQxRoleMenusBL.relatedActions != null)
{
clsQxRoleMenusBL.relatedActions.UpdRelaTabDate(objQxRoleMenusEN.mId, objQxRoleMenusEN.UpdUserId);
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
 /// <param name = "objQxRoleMenusEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsQxRoleMenusEN objQxRoleMenusEN)
{
if (objQxRoleMenusEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!角色Id = [{0}],Cm项目Id = [{1}],菜单集Id = [{2}],菜单Id = [{3}]的数据已经存在!(in clsQxRoleMenusBL.AddNewRecordBySql2WithReturnKey)", objQxRoleMenusEN.RoleId,objQxRoleMenusEN.CmPrjId,objQxRoleMenusEN.MenuSetId,objQxRoleMenusEN.MenuId);
throw new Exception(strMsg);
}
try
{
string strKey = QxRoleMenusDA.AddNewRecordBySQL2WithReturnKey(objQxRoleMenusEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRoleMenusBL.ReFreshCache();

if (clsQxRoleMenusBL.relatedActions != null)
{
clsQxRoleMenusBL.relatedActions.UpdRelaTabDate(objQxRoleMenusEN.mId, objQxRoleMenusEN.UpdUserId);
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
 /// <param name = "strQxRoleMenusObjXml">代表实体对象的XML串</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql_XML(string strQxRoleMenusObjXml)
{
clsQxRoleMenusEN objQxRoleMenusEN = GetObjFromXmlStr(strQxRoleMenusObjXml);
try
{
bool bolResult = QxRoleMenusDA.AddNewRecordBySQL2(objQxRoleMenusEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRoleMenusBL.ReFreshCache();

if (clsQxRoleMenusBL.relatedActions != null)
{
clsQxRoleMenusBL.relatedActions.UpdRelaTabDate(objQxRoleMenusEN.mId, objQxRoleMenusEN.UpdUserId);
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
 /// <param name = "objQxRoleMenusEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsQxRoleMenusEN objQxRoleMenusEN)
{
try
{
bool bolResult = QxRoleMenusDA.Update(objQxRoleMenusEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRoleMenusBL.ReFreshCache();

if (clsQxRoleMenusBL.relatedActions != null)
{
clsQxRoleMenusBL.relatedActions.UpdRelaTabDate(objQxRoleMenusEN.mId, objQxRoleMenusEN.UpdUserId);
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
 /// <param name = "objQxRoleMenusEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsQxRoleMenusEN objQxRoleMenusEN)
{
 if (objQxRoleMenusEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = QxRoleMenusDA.UpdateBySql2(objQxRoleMenusEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRoleMenusBL.ReFreshCache();

if (clsQxRoleMenusBL.relatedActions != null)
{
clsQxRoleMenusBL.relatedActions.UpdRelaTabDate(objQxRoleMenusEN.mId, objQxRoleMenusEN.UpdUserId);
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
 /// <param name = "strQxRoleMenusObjXml">需要修改的对象,用XML来表示</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql_XML(string strQxRoleMenusObjXml)
{
clsQxRoleMenusEN objQxRoleMenusEN = GetObjFromXmlStr(strQxRoleMenusObjXml);
try
{
bool bolResult = QxRoleMenusDA.UpdateBySql2(objQxRoleMenusEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRoleMenusBL.ReFreshCache();

if (clsQxRoleMenusBL.relatedActions != null)
{
clsQxRoleMenusBL.relatedActions.UpdRelaTabDate(objQxRoleMenusEN.mId, objQxRoleMenusEN.UpdUserId);
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngmId)
{
try
{
 clsQxRoleMenusEN objQxRoleMenusEN = clsQxRoleMenusBL.GetObjBymId(lngmId);

if (clsQxRoleMenusBL.relatedActions != null)
{
clsQxRoleMenusBL.relatedActions.UpdRelaTabDate(objQxRoleMenusEN.mId, objQxRoleMenusEN.UpdUserId);
}
if (objQxRoleMenusEN != null)
{
int intRecNum = QxRoleMenusDA.DelRecord(lngmId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
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
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngmId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
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
//删除与表:[QxRoleMenus]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conQxRoleMenus.mId,
//lngmId);
//        clsQxRoleMenusBL.DelQxRoleMenussByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxRoleMenusBL.DelRecord(lngmId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxRoleMenusBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngmId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngmId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsQxRoleMenusBL.relatedActions != null)
{
clsQxRoleMenusBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = QxRoleMenusDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngmId) 
{
try
{
if (clsQxRoleMenusBL.relatedActions != null)
{
clsQxRoleMenusBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = QxRoleMenusDA.DelRecordBySP(lngmId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
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
 /// <param name = "arrmIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelQxRoleMenuss(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsQxRoleMenusBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsQxRoleMenusBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intDelRecNum = QxRoleMenusDA.DelQxRoleMenus(arrmIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
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
public static int DelQxRoleMenussByCond(string strWhereCond)
{
try
{
if (clsQxRoleMenusBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsQxRoleMenusBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum = QxRoleMenusDA.DelQxRoleMenus(strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[QxRoleMenus]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxRoleMenusDA.GetSpecSQLObj();
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
//删除与表:[QxRoleMenus]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxRoleMenusBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxRoleMenusBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngmId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objQxRoleMenusEN">源简化对象</param>
 public static void SetUpdFlag(clsQxRoleMenusEN objQxRoleMenusEN)
{
try
{
objQxRoleMenusEN.ClearUpdateState();
   string strsfUpdFldSetStr = objQxRoleMenusEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conQxRoleMenus.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxRoleMenusEN.mId = objQxRoleMenusEN.mId; //流水号
}
if (arrFldSet.Contains(conQxRoleMenus.RoleId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxRoleMenusEN.RoleId = objQxRoleMenusEN.RoleId; //角色Id
}
if (arrFldSet.Contains(conQxRoleMenus.QxPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxRoleMenusEN.QxPrjId = objQxRoleMenusEN.QxPrjId; //项目Id
}
if (arrFldSet.Contains(conQxRoleMenus.CmPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxRoleMenusEN.CmPrjId = objQxRoleMenusEN.CmPrjId == "[null]" ? null :  objQxRoleMenusEN.CmPrjId; //Cm项目Id
}
if (arrFldSet.Contains(conQxRoleMenus.MenuSetId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxRoleMenusEN.MenuSetId = objQxRoleMenusEN.MenuSetId; //菜单集Id
}
if (arrFldSet.Contains(conQxRoleMenus.MenuId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxRoleMenusEN.MenuId = objQxRoleMenusEN.MenuId; //菜单Id
}
if (arrFldSet.Contains(conQxRoleMenus.IsDisp, new clsStrCompareIgnoreCase())  ==  true)
{
objQxRoleMenusEN.IsDisp = objQxRoleMenusEN.IsDisp; //是否显示
}
if (arrFldSet.Contains(conQxRoleMenus.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objQxRoleMenusEN.UpdDate = objQxRoleMenusEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conQxRoleMenus.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxRoleMenusEN.UpdUserId = objQxRoleMenusEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conQxRoleMenus.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objQxRoleMenusEN.Memo = objQxRoleMenusEN.Memo == "[null]" ? null :  objQxRoleMenusEN.Memo; //备注
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
 /// <param name = "objQxRoleMenusEN">源简化对象</param>
 public static void AccessFldValueNull(clsQxRoleMenusEN objQxRoleMenusEN)
{
try
{
if (objQxRoleMenusEN.CmPrjId == "[null]") objQxRoleMenusEN.CmPrjId = null; //Cm项目Id
if (objQxRoleMenusEN.Memo == "[null]") objQxRoleMenusEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsQxRoleMenusEN objQxRoleMenusEN)
{
 QxRoleMenusDA.CheckPropertyNew(objQxRoleMenusEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsQxRoleMenusEN objQxRoleMenusEN)
{
 QxRoleMenusDA.CheckProperty4Condition(objQxRoleMenusEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框


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
if (clsQxRoleMenusBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxRoleMenusBL没有刷新缓存机制(clsQxRoleMenusBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrQxRoleMenusObjLstCache == null)
//{
//arrQxRoleMenusObjLstCache = QxRoleMenusDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxRoleMenusEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsQxRoleMenusEN._CurrTabName);
List<clsQxRoleMenusEN> arrQxRoleMenusObjLstCache = GetObjLstCache();
IEnumerable <clsQxRoleMenusEN> arrQxRoleMenusObjLst_Sel =
arrQxRoleMenusObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrQxRoleMenusObjLst_Sel.Count() == 0)
{
   clsQxRoleMenusEN obj = clsQxRoleMenusBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrQxRoleMenusObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxRoleMenusEN> GetAllQxRoleMenusObjLstCache()
{
//获取缓存中的对象列表
List<clsQxRoleMenusEN> arrQxRoleMenusObjLstCache = GetObjLstCache(); 
return arrQxRoleMenusObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxRoleMenusEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsQxRoleMenusEN._CurrTabName);
List<clsQxRoleMenusEN> arrQxRoleMenusObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrQxRoleMenusObjLstCache;
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
string strKey = string.Format("{0}", clsQxRoleMenusEN._CurrTabName);
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
public static void ReFreshCache()
{
if (clsQxRoleMenusBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsQxRoleMenusEN._CurrTabName);
CacheHelper.Remove(strKey);
clsQxRoleMenusBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--QxRoleMenus(角色菜单)
 /// 唯一性条件:RoleId_CmPrjId_MenuSetId_MenuId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQxRoleMenusEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsQxRoleMenusEN objQxRoleMenusEN)
{
//检测记录是否存在
string strResult = QxRoleMenusDA.GetUniCondStr(objQxRoleMenusEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2024-08-29
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstQxRoleMenusObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsQxRoleMenusEN> lstQxRoleMenusObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstQxRoleMenusObjLst, writer);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 序列化一个对象列表到XmlWriter
 /// 作者:pyf
 /// 日期:2024-08-29
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXML)
 /// </summary>
 /// <param name = "lstQxRoleMenusObjLst">[clsQxRoleMenusEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsQxRoleMenusEN> lstQxRoleMenusObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsQxRoleMenusBL.listXmlNode);
writer.WriteStartElement(clsQxRoleMenusBL.itemsXmlNode);
foreach (clsQxRoleMenusEN objQxRoleMenusEN in lstQxRoleMenusObjLst)
{
clsQxRoleMenusBL.SerializeXML(writer, objQxRoleMenusEN);
}
writer.WriteEndElement();
writer.WriteEndElement();
return true;
}

 /// <summary>
 /// 把一个对象序列化到XML中
 /// 作者:pyf
 /// 日期:2024-08-29
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeXML)
 /// </summary>
 /// <param name = "writer">目标:序列化到的XmlWriter</param>
 /// <param name = "objQxRoleMenusEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsQxRoleMenusEN objQxRoleMenusEN)
{
writer.WriteStartElement(clsQxRoleMenusBL.itemXmlNode);
 
writer.WriteElementString(conQxRoleMenus.mId, objQxRoleMenusEN.mId.ToString(CultureInfo.InvariantCulture));
 
if (objQxRoleMenusEN.RoleId != null)
{
writer.WriteElementString(conQxRoleMenus.RoleId, objQxRoleMenusEN.RoleId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxRoleMenusEN.QxPrjId != null)
{
writer.WriteElementString(conQxRoleMenus.QxPrjId, objQxRoleMenusEN.QxPrjId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxRoleMenusEN.CmPrjId != null)
{
writer.WriteElementString(conQxRoleMenus.CmPrjId, objQxRoleMenusEN.CmPrjId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxRoleMenusEN.MenuSetId != null)
{
writer.WriteElementString(conQxRoleMenus.MenuSetId, objQxRoleMenusEN.MenuSetId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxRoleMenusEN.MenuId != null)
{
writer.WriteElementString(conQxRoleMenus.MenuId, objQxRoleMenusEN.MenuId.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(conQxRoleMenus.IsDisp, objQxRoleMenusEN.IsDisp.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objQxRoleMenusEN.UpdDate != null)
{
writer.WriteElementString(conQxRoleMenus.UpdDate, objQxRoleMenusEN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxRoleMenusEN.UpdUserId != null)
{
writer.WriteElementString(conQxRoleMenus.UpdUserId, objQxRoleMenusEN.UpdUserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxRoleMenusEN.Memo != null)
{
writer.WriteElementString(conQxRoleMenus.Memo, objQxRoleMenusEN.Memo.ToString(CultureInfo.InvariantCulture));
}
writer.WriteEndElement();
}

 /// <summary>
 /// 读XmlReader到一个对象
 /// 作者:pyf
 /// 日期:2024-08-29
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlReader)
 /// </summary>
 /// <param name = "reader">提供的数据源:XmlReader</param>
 /// <returns>返回的一个对象</returns>
public static clsQxRoleMenusEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsQxRoleMenusEN objQxRoleMenusEN = new clsQxRoleMenusEN();
reader.Read();
while (!(reader.Name == clsQxRoleMenusBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(conQxRoleMenus.mId))
{
objQxRoleMenusEN.mId = reader.ReadElementContentAsLong();
}
if (reader.IsStartElement(conQxRoleMenus.RoleId))
{
objQxRoleMenusEN.RoleId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxRoleMenus.QxPrjId))
{
objQxRoleMenusEN.QxPrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxRoleMenus.CmPrjId))
{
objQxRoleMenusEN.CmPrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxRoleMenus.MenuSetId))
{
objQxRoleMenusEN.MenuSetId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxRoleMenus.MenuId))
{
objQxRoleMenusEN.MenuId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxRoleMenus.IsDisp))
{
objQxRoleMenusEN.IsDisp = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(conQxRoleMenus.UpdDate))
{
objQxRoleMenusEN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxRoleMenus.UpdUserId))
{
objQxRoleMenusEN.UpdUserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxRoleMenus.Memo))
{
objQxRoleMenusEN.Memo = reader.ReadElementContentAsString();
}
}
return objQxRoleMenusEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strQxRoleMenusObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsQxRoleMenusEN GetObjFromXmlStr(string strQxRoleMenusObjXmlStr)
{
clsQxRoleMenusEN objQxRoleMenusEN = new clsQxRoleMenusEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strQxRoleMenusObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsQxRoleMenusBL.itemXmlNode))
{
objQxRoleMenusEN = GetObjFromXml(reader);
return objQxRoleMenusEN;
}
}
return objQxRoleMenusEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2024-08-29
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objQxRoleMenusEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsQxRoleMenusEN objQxRoleMenusEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objQxRoleMenusEN);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2024-08-29
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != conQxRoleMenus.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conQxRoleMenus.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conQxRoleMenus.AttributeName));
throw new Exception(strMsg);
}
var objQxRoleMenus = clsQxRoleMenusBL.GetObjBymIdCache(lngmId);
if (objQxRoleMenus == null) return "";
return objQxRoleMenus[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2024-08-29
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objQxRoleMenusEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsQxRoleMenusEN objQxRoleMenusEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsQxRoleMenusEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objQxRoleMenusEN[strField]);
}
sbJSON.Remove(sbJSON.Length - 1, 1);
sbJSON.Append("}");
return sbJSON.ToString();
}

 /// <summary>
 /// 序列化一个对象列表到JSON串
 /// 作者:pyf
 /// 日期:2024-08-29
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToJSONStr)
 /// </summary>
 /// <param name = "lstQxRoleMenusObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsQxRoleMenusEN> lstQxRoleMenusObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstQxRoleMenusObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsQxRoleMenusEN objQxRoleMenusEN in lstQxRoleMenusObjLst)
{
string strJSON_One = SerializeObjToJSON(objQxRoleMenusEN);
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
int intRecCount = clsQxRoleMenusDA.GetRecCount(strTabName);
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
int intRecCount = clsQxRoleMenusDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsQxRoleMenusDA.GetRecCount();
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
int intRecCount = clsQxRoleMenusDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objQxRoleMenusCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsQxRoleMenusEN objQxRoleMenusCond)
{
List<clsQxRoleMenusEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxRoleMenusEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxRoleMenus.AttributeName)
{
if (objQxRoleMenusCond.IsUpdated(strFldName) == false) continue;
if (objQxRoleMenusCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxRoleMenusCond[strFldName].ToString());
}
else
{
if (objQxRoleMenusCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxRoleMenusCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxRoleMenusCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxRoleMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxRoleMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxRoleMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxRoleMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxRoleMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxRoleMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxRoleMenusCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxRoleMenusCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxRoleMenusCond[strFldName]));
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
 List<string> arrList = clsQxRoleMenusDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = QxRoleMenusDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = QxRoleMenusDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = QxRoleMenusDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxRoleMenusDA.SetFldValue(clsQxRoleMenusEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = QxRoleMenusDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxRoleMenusDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxRoleMenusDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxRoleMenusDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[QxRoleMenus] "); 
 strCreateTabCode.Append(" ( "); 
 // /**流水号*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**角色Id*/ 
 strCreateTabCode.Append(" RoleId char(8) not Null, "); 
 // /**项目Id*/ 
 strCreateTabCode.Append(" QxPrjId char(4) not Null, "); 
 // /**Cm项目Id*/ 
 strCreateTabCode.Append(" CmPrjId char(6) Null, "); 
 // /**菜单集Id*/ 
 strCreateTabCode.Append(" MenuSetId char(4) not Null, "); 
 // /**菜单Id*/ 
 strCreateTabCode.Append(" MenuId char(8) not Null, "); 
 // /**是否显示*/ 
 strCreateTabCode.Append(" IsDisp bit Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) not Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) not Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**菜单名*/ 
 strCreateTabCode.Append(" MenuName varchar(50) Null, "); 
 // /**角色名称*/ 
 strCreateTabCode.Append(" RoleName varchar(50) Null, "); 
 // /**菜单集名称*/ 
 strCreateTabCode.Append(" MenuSetName varchar(50) Null, "); 
 // /**排序号*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**是否在用*/ 
 strCreateTabCode.Append(" InUse bit Null, "); 
 // /**是否叶子*/ 
 strCreateTabCode.Append(" IsLeafNode bit Null, "); 
 // /**页面显示模式Id*/ 
 strCreateTabCode.Append(" PageDispModeId char(2) Null, "); 
 // /**上级菜单Id*/ 
 strCreateTabCode.Append(" UpMenuId char(8) Null, "); 
 // /**链接文件*/ 
 strCreateTabCode.Append(" LinkFile varchar(500) Null, "); 
 // /**工程名*/ 
 strCreateTabCode.Append(" PrjName varchar(30) Null, "); 
 // /**简化日期时间*/ 
 strCreateTabCode.Append(" DateTimeSim varchar(20) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 数据同步


 #endregion 数据同步
}
 /// <summary>
 /// 角色菜单(QxRoleMenus)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4QxRoleMenus : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4BL4CSharp:Gen_4CFBL_ReFreshCache)
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
clsQxRoleMenusBL.ReFreshThisCache();
}
}

}