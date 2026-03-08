
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxPotenceTypeBL
 表名:QxPotenceType(00140003)
 * 版本:2024.03.19.1(服务器:WIN-SRV103-116)
 日期:2024/03/20 11:15:06
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
public static class  clsQxPotenceTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strPotenceTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxPotenceTypeEN GetObj(this K_PotenceTypeId_QxPotenceType myKey)
{
clsQxPotenceTypeEN objQxPotenceTypeEN = clsQxPotenceTypeBL.QxPotenceTypeDA.GetObjByPotenceTypeId(myKey.Value);
return objQxPotenceTypeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQxPotenceTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQxPotenceTypeEN objQxPotenceTypeEN)
{
 if (string.IsNullOrEmpty(objQxPotenceTypeEN.PotenceTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQxPotenceTypeBL.IsExist(objQxPotenceTypeEN.PotenceTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQxPotenceTypeEN.PotenceTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (CheckUniqueness(objQxPotenceTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!权限类型名 = [{0}],项目Id = [{1}]的数据已经存在!(in clsQxPotenceTypeBL.AddNewRecord)", objQxPotenceTypeEN.PotenceTypeName,objQxPotenceTypeEN.QxPrjId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsQxPotenceTypeBL.QxPotenceTypeDA.AddNewRecordBySQL2(objQxPotenceTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPotenceTypeBL.ReFreshCache();

if (clsQxPotenceTypeBL.relatedActions != null)
{
clsQxPotenceTypeBL.relatedActions.UpdRelaTabDate(objQxPotenceTypeEN.PotenceTypeId, objQxPotenceTypeEN.UpdUserId);
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
public static bool AddRecordEx(this clsQxPotenceTypeEN objQxPotenceTypeEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsQxPotenceTypeBL.IsExist(objQxPotenceTypeEN.PotenceTypeId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objQxPotenceTypeEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objQxPotenceTypeEN.CheckUniqueness() == false)
{
strMsg = string.Format("(权限类型名(PotenceTypeName)=[{0}],项目Id(QxPrjId)=[{1}])已经存在,不能重复!", objQxPotenceTypeEN.PotenceTypeName, objQxPotenceTypeEN.QxPrjId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objQxPotenceTypeEN.AddNewRecord();
}
catch(Exception objException)
{
strMsg = "(errid:Busi000152)添加记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值。该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objQxPotenceTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsQxPotenceTypeEN objQxPotenceTypeEN)
{
if (CheckUniqueness(objQxPotenceTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!权限类型名 = [{0}],项目Id = [{1}]的数据已经存在!(in clsQxPotenceTypeBL.AddNewRecordWithMaxId)", objQxPotenceTypeEN.PotenceTypeName,objQxPotenceTypeEN.QxPrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQxPotenceTypeEN.PotenceTypeId) == true || clsQxPotenceTypeBL.IsExist(objQxPotenceTypeEN.PotenceTypeId) == true)
 {
     objQxPotenceTypeEN.PotenceTypeId = clsQxPotenceTypeBL.GetMaxStrIdByPrefix_S(objQxPotenceTypeEN.QxPrjId);
 }
string strPotenceTypeId = clsQxPotenceTypeBL.QxPotenceTypeDA.AddNewRecordBySQL2WithReturnKey(objQxPotenceTypeEN);
     objQxPotenceTypeEN.PotenceTypeId = strPotenceTypeId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPotenceTypeBL.ReFreshCache();

if (clsQxPotenceTypeBL.relatedActions != null)
{
clsQxPotenceTypeBL.relatedActions.UpdRelaTabDate(objQxPotenceTypeEN.PotenceTypeId, objQxPotenceTypeEN.UpdUserId);
}
return strPotenceTypeId;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000096)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objQxPotenceTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsQxPotenceTypeEN objQxPotenceTypeEN)
{
 if (string.IsNullOrEmpty(objQxPotenceTypeEN.PotenceTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQxPotenceTypeBL.IsExist(objQxPotenceTypeEN.PotenceTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQxPotenceTypeEN.PotenceTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (CheckUniqueness(objQxPotenceTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!权限类型名 = [{0}],项目Id = [{1}]的数据已经存在!(in clsQxPotenceTypeBL.AddNewRecordWithReturnKey)", objQxPotenceTypeEN.PotenceTypeName,objQxPotenceTypeEN.QxPrjId);
throw new Exception(strMsg);
}
try
{
string strKey = clsQxPotenceTypeBL.QxPotenceTypeDA.AddNewRecordBySQL2WithReturnKey(objQxPotenceTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPotenceTypeBL.ReFreshCache();

if (clsQxPotenceTypeBL.relatedActions != null)
{
clsQxPotenceTypeBL.relatedActions.UpdRelaTabDate(objQxPotenceTypeEN.PotenceTypeId, objQxPotenceTypeEN.UpdUserId);
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
 /// <param name = "objQxPotenceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPotenceTypeEN SetPotenceTypeId(this clsQxPotenceTypeEN objQxPotenceTypeEN, string strPotenceTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPotenceTypeId, 6, conQxPotenceType.PotenceTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPotenceTypeId, 6, conQxPotenceType.PotenceTypeId);
}
objQxPotenceTypeEN.PotenceTypeId = strPotenceTypeId; //权限类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPotenceTypeEN.dicFldComparisonOp.ContainsKey(conQxPotenceType.PotenceTypeId) == false)
{
objQxPotenceTypeEN.dicFldComparisonOp.Add(conQxPotenceType.PotenceTypeId, strComparisonOp);
}
else
{
objQxPotenceTypeEN.dicFldComparisonOp[conQxPotenceType.PotenceTypeId] = strComparisonOp;
}
}
return objQxPotenceTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPotenceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPotenceTypeEN SetPotenceTypeName(this clsQxPotenceTypeEN objQxPotenceTypeEN, string strPotenceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPotenceTypeName, conQxPotenceType.PotenceTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPotenceTypeName, 50, conQxPotenceType.PotenceTypeName);
}
objQxPotenceTypeEN.PotenceTypeName = strPotenceTypeName; //权限类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPotenceTypeEN.dicFldComparisonOp.ContainsKey(conQxPotenceType.PotenceTypeName) == false)
{
objQxPotenceTypeEN.dicFldComparisonOp.Add(conQxPotenceType.PotenceTypeName, strComparisonOp);
}
else
{
objQxPotenceTypeEN.dicFldComparisonOp[conQxPotenceType.PotenceTypeName] = strComparisonOp;
}
}
return objQxPotenceTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPotenceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPotenceTypeEN SetQxPrjId(this clsQxPotenceTypeEN objQxPotenceTypeEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, conQxPotenceType.QxPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQxPrjId, 4, conQxPotenceType.QxPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, conQxPotenceType.QxPrjId);
}
objQxPotenceTypeEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPotenceTypeEN.dicFldComparisonOp.ContainsKey(conQxPotenceType.QxPrjId) == false)
{
objQxPotenceTypeEN.dicFldComparisonOp.Add(conQxPotenceType.QxPrjId, strComparisonOp);
}
else
{
objQxPotenceTypeEN.dicFldComparisonOp[conQxPotenceType.QxPrjId] = strComparisonOp;
}
}
return objQxPotenceTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPotenceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPotenceTypeEN SetFuncModuleId(this clsQxPotenceTypeEN objQxPotenceTypeEN, string strFuncModuleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, conQxPotenceType.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, conQxPotenceType.FuncModuleId);
}
objQxPotenceTypeEN.FuncModuleId = strFuncModuleId; //模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPotenceTypeEN.dicFldComparisonOp.ContainsKey(conQxPotenceType.FuncModuleId) == false)
{
objQxPotenceTypeEN.dicFldComparisonOp.Add(conQxPotenceType.FuncModuleId, strComparisonOp);
}
else
{
objQxPotenceTypeEN.dicFldComparisonOp[conQxPotenceType.FuncModuleId] = strComparisonOp;
}
}
return objQxPotenceTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPotenceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPotenceTypeEN SetMenuId(this clsQxPotenceTypeEN objQxPotenceTypeEN, string strMenuId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuId, 8, conQxPotenceType.MenuId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMenuId, 8, conQxPotenceType.MenuId);
}
objQxPotenceTypeEN.MenuId = strMenuId; //菜单Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPotenceTypeEN.dicFldComparisonOp.ContainsKey(conQxPotenceType.MenuId) == false)
{
objQxPotenceTypeEN.dicFldComparisonOp.Add(conQxPotenceType.MenuId, strComparisonOp);
}
else
{
objQxPotenceTypeEN.dicFldComparisonOp[conQxPotenceType.MenuId] = strComparisonOp;
}
}
return objQxPotenceTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPotenceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPotenceTypeEN SetViewId(this clsQxPotenceTypeEN objQxPotenceTypeEN, string strViewId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewId, 8, conQxPotenceType.ViewId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strViewId, 8, conQxPotenceType.ViewId);
}
objQxPotenceTypeEN.ViewId = strViewId; //界面编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPotenceTypeEN.dicFldComparisonOp.ContainsKey(conQxPotenceType.ViewId) == false)
{
objQxPotenceTypeEN.dicFldComparisonOp.Add(conQxPotenceType.ViewId, strComparisonOp);
}
else
{
objQxPotenceTypeEN.dicFldComparisonOp[conQxPotenceType.ViewId] = strComparisonOp;
}
}
return objQxPotenceTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPotenceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPotenceTypeEN SetIsVisible(this clsQxPotenceTypeEN objQxPotenceTypeEN, bool bolIsVisible, string strComparisonOp="")
	{
objQxPotenceTypeEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPotenceTypeEN.dicFldComparisonOp.ContainsKey(conQxPotenceType.IsVisible) == false)
{
objQxPotenceTypeEN.dicFldComparisonOp.Add(conQxPotenceType.IsVisible, strComparisonOp);
}
else
{
objQxPotenceTypeEN.dicFldComparisonOp[conQxPotenceType.IsVisible] = strComparisonOp;
}
}
return objQxPotenceTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPotenceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPotenceTypeEN SetUpdDate(this clsQxPotenceTypeEN objQxPotenceTypeEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conQxPotenceType.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQxPotenceType.UpdDate);
}
objQxPotenceTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPotenceTypeEN.dicFldComparisonOp.ContainsKey(conQxPotenceType.UpdDate) == false)
{
objQxPotenceTypeEN.dicFldComparisonOp.Add(conQxPotenceType.UpdDate, strComparisonOp);
}
else
{
objQxPotenceTypeEN.dicFldComparisonOp[conQxPotenceType.UpdDate] = strComparisonOp;
}
}
return objQxPotenceTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPotenceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPotenceTypeEN SetUpdUserId(this clsQxPotenceTypeEN objQxPotenceTypeEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUserId, conQxPotenceType.UpdUserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conQxPotenceType.UpdUserId);
}
objQxPotenceTypeEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPotenceTypeEN.dicFldComparisonOp.ContainsKey(conQxPotenceType.UpdUserId) == false)
{
objQxPotenceTypeEN.dicFldComparisonOp.Add(conQxPotenceType.UpdUserId, strComparisonOp);
}
else
{
objQxPotenceTypeEN.dicFldComparisonOp[conQxPotenceType.UpdUserId] = strComparisonOp;
}
}
return objQxPotenceTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPotenceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPotenceTypeEN SetMemo(this clsQxPotenceTypeEN objQxPotenceTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQxPotenceType.Memo);
}
objQxPotenceTypeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPotenceTypeEN.dicFldComparisonOp.ContainsKey(conQxPotenceType.Memo) == false)
{
objQxPotenceTypeEN.dicFldComparisonOp.Add(conQxPotenceType.Memo, strComparisonOp);
}
else
{
objQxPotenceTypeEN.dicFldComparisonOp[conQxPotenceType.Memo] = strComparisonOp;
}
}
return objQxPotenceTypeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objQxPotenceTypeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsQxPotenceTypeEN objQxPotenceTypeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objQxPotenceTypeEN.CheckPropertyNew();
clsQxPotenceTypeEN objQxPotenceTypeCond = new clsQxPotenceTypeEN();
string strCondition = objQxPotenceTypeCond
.SetPotenceTypeId(objQxPotenceTypeEN.PotenceTypeId, "<>")
.SetPotenceTypeName(objQxPotenceTypeEN.PotenceTypeName, "=")
.SetQxPrjId(objQxPotenceTypeEN.QxPrjId, "=")
.GetCombineCondition();
objQxPotenceTypeEN._IsCheckProperty = true;
bool bolIsExist = clsQxPotenceTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(PotenceTypeName_QxPrjId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objQxPotenceTypeEN.Update();
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
 /// <param name = "objQxPotenceType">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsQxPotenceTypeEN objQxPotenceType)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsQxPotenceTypeEN objQxPotenceTypeCond = new clsQxPotenceTypeEN();
string strCondition = objQxPotenceTypeCond
.SetPotenceTypeName(objQxPotenceType.PotenceTypeName, "=")
.SetQxPrjId(objQxPotenceType.QxPrjId, "=")
.GetCombineCondition();
objQxPotenceType._IsCheckProperty = true;
bool bolIsExist = clsQxPotenceTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objQxPotenceType.PotenceTypeId = clsQxPotenceTypeBL.GetFirstID_S(strCondition);
objQxPotenceType.UpdateWithCondition(strCondition);
}
else
{
objQxPotenceType.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objQxPotenceTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxPotenceTypeEN objQxPotenceTypeEN)
{
 if (string.IsNullOrEmpty(objQxPotenceTypeEN.PotenceTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxPotenceTypeBL.QxPotenceTypeDA.UpdateBySql2(objQxPotenceTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPotenceTypeBL.ReFreshCache();

if (clsQxPotenceTypeBL.relatedActions != null)
{
clsQxPotenceTypeBL.relatedActions.UpdRelaTabDate(objQxPotenceTypeEN.PotenceTypeId, objQxPotenceTypeEN.UpdUserId);
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
 /// <param name = "objQxPotenceTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxPotenceTypeEN objQxPotenceTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objQxPotenceTypeEN.PotenceTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxPotenceTypeBL.QxPotenceTypeDA.UpdateBySql2(objQxPotenceTypeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPotenceTypeBL.ReFreshCache();

if (clsQxPotenceTypeBL.relatedActions != null)
{
clsQxPotenceTypeBL.relatedActions.UpdRelaTabDate(objQxPotenceTypeEN.PotenceTypeId, objQxPotenceTypeEN.UpdUserId);
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
 /// <param name = "objQxPotenceTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxPotenceTypeEN objQxPotenceTypeEN, string strWhereCond)
{
try
{
bool bolResult = clsQxPotenceTypeBL.QxPotenceTypeDA.UpdateBySqlWithCondition(objQxPotenceTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPotenceTypeBL.ReFreshCache();

if (clsQxPotenceTypeBL.relatedActions != null)
{
clsQxPotenceTypeBL.relatedActions.UpdRelaTabDate(objQxPotenceTypeEN.PotenceTypeId, objQxPotenceTypeEN.UpdUserId);
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
 /// <param name = "objQxPotenceTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxPotenceTypeEN objQxPotenceTypeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsQxPotenceTypeBL.QxPotenceTypeDA.UpdateBySqlWithConditionTransaction(objQxPotenceTypeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPotenceTypeBL.ReFreshCache();

if (clsQxPotenceTypeBL.relatedActions != null)
{
clsQxPotenceTypeBL.relatedActions.UpdRelaTabDate(objQxPotenceTypeEN.PotenceTypeId, objQxPotenceTypeEN.UpdUserId);
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
 /// <param name = "strPotenceTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsQxPotenceTypeEN objQxPotenceTypeEN)
{
try
{
int intRecNum = clsQxPotenceTypeBL.QxPotenceTypeDA.DelRecord(objQxPotenceTypeEN.PotenceTypeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPotenceTypeBL.ReFreshCache();

if (clsQxPotenceTypeBL.relatedActions != null)
{
clsQxPotenceTypeBL.relatedActions.UpdRelaTabDate(objQxPotenceTypeEN.PotenceTypeId, objQxPotenceTypeEN.UpdUserId);
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
 /// <param name = "objQxPotenceTypeENS">源对象</param>
 /// <param name = "objQxPotenceTypeENT">目标对象</param>
 public static void CopyTo(this clsQxPotenceTypeEN objQxPotenceTypeENS, clsQxPotenceTypeEN objQxPotenceTypeENT)
{
try
{
objQxPotenceTypeENT.PotenceTypeId = objQxPotenceTypeENS.PotenceTypeId; //权限类型Id
objQxPotenceTypeENT.PotenceTypeName = objQxPotenceTypeENS.PotenceTypeName; //权限类型名
objQxPotenceTypeENT.QxPrjId = objQxPotenceTypeENS.QxPrjId; //项目Id
objQxPotenceTypeENT.FuncModuleId = objQxPotenceTypeENS.FuncModuleId; //模块Id
objQxPotenceTypeENT.MenuId = objQxPotenceTypeENS.MenuId; //菜单Id
objQxPotenceTypeENT.ViewId = objQxPotenceTypeENS.ViewId; //界面编号
objQxPotenceTypeENT.IsVisible = objQxPotenceTypeENS.IsVisible; //是否显示
objQxPotenceTypeENT.UpdDate = objQxPotenceTypeENS.UpdDate; //修改日期
objQxPotenceTypeENT.UpdUserId = objQxPotenceTypeENS.UpdUserId; //修改用户Id
objQxPotenceTypeENT.Memo = objQxPotenceTypeENS.Memo; //备注
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
 /// <param name = "objQxPotenceTypeENS">源对象</param>
 /// <returns>目标对象=>clsQxPotenceTypeEN:objQxPotenceTypeENT</returns>
 public static clsQxPotenceTypeEN CopyTo(this clsQxPotenceTypeEN objQxPotenceTypeENS)
{
try
{
 clsQxPotenceTypeEN objQxPotenceTypeENT = new clsQxPotenceTypeEN()
{
PotenceTypeId = objQxPotenceTypeENS.PotenceTypeId, //权限类型Id
PotenceTypeName = objQxPotenceTypeENS.PotenceTypeName, //权限类型名
QxPrjId = objQxPotenceTypeENS.QxPrjId, //项目Id
FuncModuleId = objQxPotenceTypeENS.FuncModuleId, //模块Id
MenuId = objQxPotenceTypeENS.MenuId, //菜单Id
ViewId = objQxPotenceTypeENS.ViewId, //界面编号
IsVisible = objQxPotenceTypeENS.IsVisible, //是否显示
UpdDate = objQxPotenceTypeENS.UpdDate, //修改日期
UpdUserId = objQxPotenceTypeENS.UpdUserId, //修改用户Id
Memo = objQxPotenceTypeENS.Memo, //备注
};
 return objQxPotenceTypeENT;
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
public static void CheckPropertyNew(this clsQxPotenceTypeEN objQxPotenceTypeEN)
{
 clsQxPotenceTypeBL.QxPotenceTypeDA.CheckPropertyNew(objQxPotenceTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsQxPotenceTypeEN objQxPotenceTypeEN)
{
 clsQxPotenceTypeBL.QxPotenceTypeDA.CheckProperty4Condition(objQxPotenceTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQxPotenceTypeEN objQxPotenceTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQxPotenceTypeCond.IsUpdated(conQxPotenceType.PotenceTypeId) == true)
{
string strComparisonOpPotenceTypeId = objQxPotenceTypeCond.dicFldComparisonOp[conQxPotenceType.PotenceTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPotenceType.PotenceTypeId, objQxPotenceTypeCond.PotenceTypeId, strComparisonOpPotenceTypeId);
}
if (objQxPotenceTypeCond.IsUpdated(conQxPotenceType.PotenceTypeName) == true)
{
string strComparisonOpPotenceTypeName = objQxPotenceTypeCond.dicFldComparisonOp[conQxPotenceType.PotenceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPotenceType.PotenceTypeName, objQxPotenceTypeCond.PotenceTypeName, strComparisonOpPotenceTypeName);
}
if (objQxPotenceTypeCond.IsUpdated(conQxPotenceType.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objQxPotenceTypeCond.dicFldComparisonOp[conQxPotenceType.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPotenceType.QxPrjId, objQxPotenceTypeCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objQxPotenceTypeCond.IsUpdated(conQxPotenceType.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objQxPotenceTypeCond.dicFldComparisonOp[conQxPotenceType.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPotenceType.FuncModuleId, objQxPotenceTypeCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objQxPotenceTypeCond.IsUpdated(conQxPotenceType.MenuId) == true)
{
string strComparisonOpMenuId = objQxPotenceTypeCond.dicFldComparisonOp[conQxPotenceType.MenuId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPotenceType.MenuId, objQxPotenceTypeCond.MenuId, strComparisonOpMenuId);
}
if (objQxPotenceTypeCond.IsUpdated(conQxPotenceType.ViewId) == true)
{
string strComparisonOpViewId = objQxPotenceTypeCond.dicFldComparisonOp[conQxPotenceType.ViewId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPotenceType.ViewId, objQxPotenceTypeCond.ViewId, strComparisonOpViewId);
}
if (objQxPotenceTypeCond.IsUpdated(conQxPotenceType.IsVisible) == true)
{
if (objQxPotenceTypeCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQxPotenceType.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQxPotenceType.IsVisible);
}
}
if (objQxPotenceTypeCond.IsUpdated(conQxPotenceType.UpdDate) == true)
{
string strComparisonOpUpdDate = objQxPotenceTypeCond.dicFldComparisonOp[conQxPotenceType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPotenceType.UpdDate, objQxPotenceTypeCond.UpdDate, strComparisonOpUpdDate);
}
if (objQxPotenceTypeCond.IsUpdated(conQxPotenceType.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objQxPotenceTypeCond.dicFldComparisonOp[conQxPotenceType.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPotenceType.UpdUserId, objQxPotenceTypeCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objQxPotenceTypeCond.IsUpdated(conQxPotenceType.Memo) == true)
{
string strComparisonOpMemo = objQxPotenceTypeCond.dicFldComparisonOp[conQxPotenceType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPotenceType.Memo, objQxPotenceTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--QxPotenceType(权限类型), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:PotenceTypeName_QxPrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objQxPotenceTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsQxPotenceTypeEN objQxPotenceTypeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objQxPotenceTypeEN == null) return true;
if (objQxPotenceTypeEN.PotenceTypeId == null || objQxPotenceTypeEN.PotenceTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PotenceTypeName = '{0}'", objQxPotenceTypeEN.PotenceTypeName);
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxPotenceTypeEN.QxPrjId);
if (clsQxPotenceTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("PotenceTypeId !=  '{0}'", objQxPotenceTypeEN.PotenceTypeId);
 sbCondition.AppendFormat(" and PotenceTypeName = '{0}'", objQxPotenceTypeEN.PotenceTypeName);
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxPotenceTypeEN.QxPrjId);
if (clsQxPotenceTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--QxPotenceType(权限类型), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PotenceTypeName_QxPrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objQxPotenceTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsQxPotenceTypeEN objQxPotenceTypeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objQxPotenceTypeEN == null) return "";
if (objQxPotenceTypeEN.PotenceTypeId == null || objQxPotenceTypeEN.PotenceTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PotenceTypeName = '{0}'", objQxPotenceTypeEN.PotenceTypeName);
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxPotenceTypeEN.QxPrjId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("PotenceTypeId !=  '{0}'", objQxPotenceTypeEN.PotenceTypeId);
 sbCondition.AppendFormat(" and PotenceTypeName = '{0}'", objQxPotenceTypeEN.PotenceTypeName);
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxPotenceTypeEN.QxPrjId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_QxPotenceType
{
public virtual bool UpdRelaTabDate(string strPotenceTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 权限类型(QxPotenceType)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsQxPotenceTypeBL
{
public static RelatedActions_QxPotenceType relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "QxPotenceTypeListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "QxPotenceTypeList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsQxPotenceTypeEN> arrQxPotenceTypeObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsQxPotenceTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsQxPotenceTypeDA QxPotenceTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsQxPotenceTypeDA();
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
 public clsQxPotenceTypeBL()
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
if (string.IsNullOrEmpty(clsQxPotenceTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxPotenceTypeEN._ConnectString);
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
objDS = QxPotenceTypeDA.GetDataSet(strWhereCond);
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
objDS = QxPotenceTypeDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = QxPotenceTypeDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_QxPotenceType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = QxPotenceTypeDA.GetDataTable_QxPotenceType(strWhereCond);
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
objDT = QxPotenceTypeDA.GetDataTable(strWhereCond);
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
objDT = QxPotenceTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = QxPotenceTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = QxPotenceTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = QxPotenceTypeDA.GetDataTable_Top(objTopPara);
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
objDT = QxPotenceTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = QxPotenceTypeDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = QxPotenceTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = QxPotenceTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = QxPotenceTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = QxPotenceTypeDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = QxPotenceTypeDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = QxPotenceTypeDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
public static List<clsQxPotenceTypeEN> GetObjLstByPotenceTypeIdLst(List<string> arrPotenceTypeIdLst)
{
List<clsQxPotenceTypeEN> arrObjLst = new List<clsQxPotenceTypeEN>(); 
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
	clsQxPotenceTypeEN objQxPotenceTypeEN = new clsQxPotenceTypeEN();
try
{
objQxPotenceTypeEN.PotenceTypeId = objRow[conQxPotenceType.PotenceTypeId].ToString().Trim(); //权限类型Id
objQxPotenceTypeEN.PotenceTypeName = objRow[conQxPotenceType.PotenceTypeName].ToString().Trim(); //权限类型名
objQxPotenceTypeEN.QxPrjId = objRow[conQxPotenceType.QxPrjId].ToString().Trim(); //项目Id
objQxPotenceTypeEN.FuncModuleId = objRow[conQxPotenceType.FuncModuleId] == DBNull.Value ? null : objRow[conQxPotenceType.FuncModuleId].ToString().Trim(); //模块Id
objQxPotenceTypeEN.MenuId = objRow[conQxPotenceType.MenuId] == DBNull.Value ? null : objRow[conQxPotenceType.MenuId].ToString().Trim(); //菜单Id
objQxPotenceTypeEN.ViewId = objRow[conQxPotenceType.ViewId] == DBNull.Value ? null : objRow[conQxPotenceType.ViewId].ToString().Trim(); //界面编号
objQxPotenceTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conQxPotenceType.IsVisible].ToString().Trim()); //是否显示
objQxPotenceTypeEN.UpdDate = objRow[conQxPotenceType.UpdDate].ToString().Trim(); //修改日期
objQxPotenceTypeEN.UpdUserId = objRow[conQxPotenceType.UpdUserId].ToString().Trim(); //修改用户Id
objQxPotenceTypeEN.Memo = objRow[conQxPotenceType.Memo] == DBNull.Value ? null : objRow[conQxPotenceType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPotenceTypeEN.PotenceTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPotenceTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPotenceTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsQxPotenceTypeEN> GetObjLstByPotenceTypeIdLstCache(List<string> arrPotenceTypeIdLst)
{
string strKey = string.Format("{0}", clsQxPotenceTypeEN._CurrTabName);
List<clsQxPotenceTypeEN> arrQxPotenceTypeObjLstCache = GetObjLstCache();
IEnumerable <clsQxPotenceTypeEN> arrQxPotenceTypeObjLst_Sel =
arrQxPotenceTypeObjLstCache
.Where(x => arrPotenceTypeIdLst.Contains(x.PotenceTypeId));
return arrQxPotenceTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPotenceTypeEN> GetObjLst(string strWhereCond)
{
List<clsQxPotenceTypeEN> arrObjLst = new List<clsQxPotenceTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPotenceTypeEN objQxPotenceTypeEN = new clsQxPotenceTypeEN();
try
{
objQxPotenceTypeEN.PotenceTypeId = objRow[conQxPotenceType.PotenceTypeId].ToString().Trim(); //权限类型Id
objQxPotenceTypeEN.PotenceTypeName = objRow[conQxPotenceType.PotenceTypeName].ToString().Trim(); //权限类型名
objQxPotenceTypeEN.QxPrjId = objRow[conQxPotenceType.QxPrjId].ToString().Trim(); //项目Id
objQxPotenceTypeEN.FuncModuleId = objRow[conQxPotenceType.FuncModuleId] == DBNull.Value ? null : objRow[conQxPotenceType.FuncModuleId].ToString().Trim(); //模块Id
objQxPotenceTypeEN.MenuId = objRow[conQxPotenceType.MenuId] == DBNull.Value ? null : objRow[conQxPotenceType.MenuId].ToString().Trim(); //菜单Id
objQxPotenceTypeEN.ViewId = objRow[conQxPotenceType.ViewId] == DBNull.Value ? null : objRow[conQxPotenceType.ViewId].ToString().Trim(); //界面编号
objQxPotenceTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conQxPotenceType.IsVisible].ToString().Trim()); //是否显示
objQxPotenceTypeEN.UpdDate = objRow[conQxPotenceType.UpdDate].ToString().Trim(); //修改日期
objQxPotenceTypeEN.UpdUserId = objRow[conQxPotenceType.UpdUserId].ToString().Trim(); //修改用户Id
objQxPotenceTypeEN.Memo = objRow[conQxPotenceType.Memo] == DBNull.Value ? null : objRow[conQxPotenceType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPotenceTypeEN.PotenceTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPotenceTypeEN);
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
public static List<clsQxPotenceTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsQxPotenceTypeEN> arrObjLst = new List<clsQxPotenceTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPotenceTypeEN objQxPotenceTypeEN = new clsQxPotenceTypeEN();
try
{
objQxPotenceTypeEN.PotenceTypeId = objRow[conQxPotenceType.PotenceTypeId].ToString().Trim(); //权限类型Id
objQxPotenceTypeEN.PotenceTypeName = objRow[conQxPotenceType.PotenceTypeName].ToString().Trim(); //权限类型名
objQxPotenceTypeEN.QxPrjId = objRow[conQxPotenceType.QxPrjId].ToString().Trim(); //项目Id
objQxPotenceTypeEN.FuncModuleId = objRow[conQxPotenceType.FuncModuleId] == DBNull.Value ? null : objRow[conQxPotenceType.FuncModuleId].ToString().Trim(); //模块Id
objQxPotenceTypeEN.MenuId = objRow[conQxPotenceType.MenuId] == DBNull.Value ? null : objRow[conQxPotenceType.MenuId].ToString().Trim(); //菜单Id
objQxPotenceTypeEN.ViewId = objRow[conQxPotenceType.ViewId] == DBNull.Value ? null : objRow[conQxPotenceType.ViewId].ToString().Trim(); //界面编号
objQxPotenceTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conQxPotenceType.IsVisible].ToString().Trim()); //是否显示
objQxPotenceTypeEN.UpdDate = objRow[conQxPotenceType.UpdDate].ToString().Trim(); //修改日期
objQxPotenceTypeEN.UpdUserId = objRow[conQxPotenceType.UpdUserId].ToString().Trim(); //修改用户Id
objQxPotenceTypeEN.Memo = objRow[conQxPotenceType.Memo] == DBNull.Value ? null : objRow[conQxPotenceType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPotenceTypeEN.PotenceTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPotenceTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objQxPotenceTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsQxPotenceTypeEN> GetSubObjLstCache(clsQxPotenceTypeEN objQxPotenceTypeCond)
{
List<clsQxPotenceTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxPotenceTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxPotenceType.AttributeName)
{
if (objQxPotenceTypeCond.IsUpdated(strFldName) == false) continue;
if (objQxPotenceTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxPotenceTypeCond[strFldName].ToString());
}
else
{
if (objQxPotenceTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxPotenceTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxPotenceTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxPotenceTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxPotenceTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxPotenceTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxPotenceTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxPotenceTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxPotenceTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxPotenceTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxPotenceTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxPotenceTypeCond[strFldName]));
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
public static List<clsQxPotenceTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsQxPotenceTypeEN> arrObjLst = new List<clsQxPotenceTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPotenceTypeEN objQxPotenceTypeEN = new clsQxPotenceTypeEN();
try
{
objQxPotenceTypeEN.PotenceTypeId = objRow[conQxPotenceType.PotenceTypeId].ToString().Trim(); //权限类型Id
objQxPotenceTypeEN.PotenceTypeName = objRow[conQxPotenceType.PotenceTypeName].ToString().Trim(); //权限类型名
objQxPotenceTypeEN.QxPrjId = objRow[conQxPotenceType.QxPrjId].ToString().Trim(); //项目Id
objQxPotenceTypeEN.FuncModuleId = objRow[conQxPotenceType.FuncModuleId] == DBNull.Value ? null : objRow[conQxPotenceType.FuncModuleId].ToString().Trim(); //模块Id
objQxPotenceTypeEN.MenuId = objRow[conQxPotenceType.MenuId] == DBNull.Value ? null : objRow[conQxPotenceType.MenuId].ToString().Trim(); //菜单Id
objQxPotenceTypeEN.ViewId = objRow[conQxPotenceType.ViewId] == DBNull.Value ? null : objRow[conQxPotenceType.ViewId].ToString().Trim(); //界面编号
objQxPotenceTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conQxPotenceType.IsVisible].ToString().Trim()); //是否显示
objQxPotenceTypeEN.UpdDate = objRow[conQxPotenceType.UpdDate].ToString().Trim(); //修改日期
objQxPotenceTypeEN.UpdUserId = objRow[conQxPotenceType.UpdUserId].ToString().Trim(); //修改用户Id
objQxPotenceTypeEN.Memo = objRow[conQxPotenceType.Memo] == DBNull.Value ? null : objRow[conQxPotenceType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPotenceTypeEN.PotenceTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPotenceTypeEN);
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
public static List<clsQxPotenceTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsQxPotenceTypeEN> arrObjLst = new List<clsQxPotenceTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPotenceTypeEN objQxPotenceTypeEN = new clsQxPotenceTypeEN();
try
{
objQxPotenceTypeEN.PotenceTypeId = objRow[conQxPotenceType.PotenceTypeId].ToString().Trim(); //权限类型Id
objQxPotenceTypeEN.PotenceTypeName = objRow[conQxPotenceType.PotenceTypeName].ToString().Trim(); //权限类型名
objQxPotenceTypeEN.QxPrjId = objRow[conQxPotenceType.QxPrjId].ToString().Trim(); //项目Id
objQxPotenceTypeEN.FuncModuleId = objRow[conQxPotenceType.FuncModuleId] == DBNull.Value ? null : objRow[conQxPotenceType.FuncModuleId].ToString().Trim(); //模块Id
objQxPotenceTypeEN.MenuId = objRow[conQxPotenceType.MenuId] == DBNull.Value ? null : objRow[conQxPotenceType.MenuId].ToString().Trim(); //菜单Id
objQxPotenceTypeEN.ViewId = objRow[conQxPotenceType.ViewId] == DBNull.Value ? null : objRow[conQxPotenceType.ViewId].ToString().Trim(); //界面编号
objQxPotenceTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conQxPotenceType.IsVisible].ToString().Trim()); //是否显示
objQxPotenceTypeEN.UpdDate = objRow[conQxPotenceType.UpdDate].ToString().Trim(); //修改日期
objQxPotenceTypeEN.UpdUserId = objRow[conQxPotenceType.UpdUserId].ToString().Trim(); //修改用户Id
objQxPotenceTypeEN.Memo = objRow[conQxPotenceType.Memo] == DBNull.Value ? null : objRow[conQxPotenceType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPotenceTypeEN.PotenceTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPotenceTypeEN);
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
List<clsQxPotenceTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsQxPotenceTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPotenceTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsQxPotenceTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsQxPotenceTypeEN> arrObjLst = new List<clsQxPotenceTypeEN>(); 
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
	clsQxPotenceTypeEN objQxPotenceTypeEN = new clsQxPotenceTypeEN();
try
{
objQxPotenceTypeEN.PotenceTypeId = objRow[conQxPotenceType.PotenceTypeId].ToString().Trim(); //权限类型Id
objQxPotenceTypeEN.PotenceTypeName = objRow[conQxPotenceType.PotenceTypeName].ToString().Trim(); //权限类型名
objQxPotenceTypeEN.QxPrjId = objRow[conQxPotenceType.QxPrjId].ToString().Trim(); //项目Id
objQxPotenceTypeEN.FuncModuleId = objRow[conQxPotenceType.FuncModuleId] == DBNull.Value ? null : objRow[conQxPotenceType.FuncModuleId].ToString().Trim(); //模块Id
objQxPotenceTypeEN.MenuId = objRow[conQxPotenceType.MenuId] == DBNull.Value ? null : objRow[conQxPotenceType.MenuId].ToString().Trim(); //菜单Id
objQxPotenceTypeEN.ViewId = objRow[conQxPotenceType.ViewId] == DBNull.Value ? null : objRow[conQxPotenceType.ViewId].ToString().Trim(); //界面编号
objQxPotenceTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conQxPotenceType.IsVisible].ToString().Trim()); //是否显示
objQxPotenceTypeEN.UpdDate = objRow[conQxPotenceType.UpdDate].ToString().Trim(); //修改日期
objQxPotenceTypeEN.UpdUserId = objRow[conQxPotenceType.UpdUserId].ToString().Trim(); //修改用户Id
objQxPotenceTypeEN.Memo = objRow[conQxPotenceType.Memo] == DBNull.Value ? null : objRow[conQxPotenceType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPotenceTypeEN.PotenceTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPotenceTypeEN);
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
public static List<clsQxPotenceTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsQxPotenceTypeEN> arrObjLst = new List<clsQxPotenceTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPotenceTypeEN objQxPotenceTypeEN = new clsQxPotenceTypeEN();
try
{
objQxPotenceTypeEN.PotenceTypeId = objRow[conQxPotenceType.PotenceTypeId].ToString().Trim(); //权限类型Id
objQxPotenceTypeEN.PotenceTypeName = objRow[conQxPotenceType.PotenceTypeName].ToString().Trim(); //权限类型名
objQxPotenceTypeEN.QxPrjId = objRow[conQxPotenceType.QxPrjId].ToString().Trim(); //项目Id
objQxPotenceTypeEN.FuncModuleId = objRow[conQxPotenceType.FuncModuleId] == DBNull.Value ? null : objRow[conQxPotenceType.FuncModuleId].ToString().Trim(); //模块Id
objQxPotenceTypeEN.MenuId = objRow[conQxPotenceType.MenuId] == DBNull.Value ? null : objRow[conQxPotenceType.MenuId].ToString().Trim(); //菜单Id
objQxPotenceTypeEN.ViewId = objRow[conQxPotenceType.ViewId] == DBNull.Value ? null : objRow[conQxPotenceType.ViewId].ToString().Trim(); //界面编号
objQxPotenceTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conQxPotenceType.IsVisible].ToString().Trim()); //是否显示
objQxPotenceTypeEN.UpdDate = objRow[conQxPotenceType.UpdDate].ToString().Trim(); //修改日期
objQxPotenceTypeEN.UpdUserId = objRow[conQxPotenceType.UpdUserId].ToString().Trim(); //修改用户Id
objQxPotenceTypeEN.Memo = objRow[conQxPotenceType.Memo] == DBNull.Value ? null : objRow[conQxPotenceType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPotenceTypeEN.PotenceTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPotenceTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsQxPotenceTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsQxPotenceTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsQxPotenceTypeEN> arrObjLst = new List<clsQxPotenceTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPotenceTypeEN objQxPotenceTypeEN = new clsQxPotenceTypeEN();
try
{
objQxPotenceTypeEN.PotenceTypeId = objRow[conQxPotenceType.PotenceTypeId].ToString().Trim(); //权限类型Id
objQxPotenceTypeEN.PotenceTypeName = objRow[conQxPotenceType.PotenceTypeName].ToString().Trim(); //权限类型名
objQxPotenceTypeEN.QxPrjId = objRow[conQxPotenceType.QxPrjId].ToString().Trim(); //项目Id
objQxPotenceTypeEN.FuncModuleId = objRow[conQxPotenceType.FuncModuleId] == DBNull.Value ? null : objRow[conQxPotenceType.FuncModuleId].ToString().Trim(); //模块Id
objQxPotenceTypeEN.MenuId = objRow[conQxPotenceType.MenuId] == DBNull.Value ? null : objRow[conQxPotenceType.MenuId].ToString().Trim(); //菜单Id
objQxPotenceTypeEN.ViewId = objRow[conQxPotenceType.ViewId] == DBNull.Value ? null : objRow[conQxPotenceType.ViewId].ToString().Trim(); //界面编号
objQxPotenceTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conQxPotenceType.IsVisible].ToString().Trim()); //是否显示
objQxPotenceTypeEN.UpdDate = objRow[conQxPotenceType.UpdDate].ToString().Trim(); //修改日期
objQxPotenceTypeEN.UpdUserId = objRow[conQxPotenceType.UpdUserId].ToString().Trim(); //修改用户Id
objQxPotenceTypeEN.Memo = objRow[conQxPotenceType.Memo] == DBNull.Value ? null : objRow[conQxPotenceType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPotenceTypeEN.PotenceTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPotenceTypeEN);
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
public static List<clsQxPotenceTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsQxPotenceTypeEN> arrObjLst = new List<clsQxPotenceTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPotenceTypeEN objQxPotenceTypeEN = new clsQxPotenceTypeEN();
try
{
objQxPotenceTypeEN.PotenceTypeId = objRow[conQxPotenceType.PotenceTypeId].ToString().Trim(); //权限类型Id
objQxPotenceTypeEN.PotenceTypeName = objRow[conQxPotenceType.PotenceTypeName].ToString().Trim(); //权限类型名
objQxPotenceTypeEN.QxPrjId = objRow[conQxPotenceType.QxPrjId].ToString().Trim(); //项目Id
objQxPotenceTypeEN.FuncModuleId = objRow[conQxPotenceType.FuncModuleId] == DBNull.Value ? null : objRow[conQxPotenceType.FuncModuleId].ToString().Trim(); //模块Id
objQxPotenceTypeEN.MenuId = objRow[conQxPotenceType.MenuId] == DBNull.Value ? null : objRow[conQxPotenceType.MenuId].ToString().Trim(); //菜单Id
objQxPotenceTypeEN.ViewId = objRow[conQxPotenceType.ViewId] == DBNull.Value ? null : objRow[conQxPotenceType.ViewId].ToString().Trim(); //界面编号
objQxPotenceTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conQxPotenceType.IsVisible].ToString().Trim()); //是否显示
objQxPotenceTypeEN.UpdDate = objRow[conQxPotenceType.UpdDate].ToString().Trim(); //修改日期
objQxPotenceTypeEN.UpdUserId = objRow[conQxPotenceType.UpdUserId].ToString().Trim(); //修改用户Id
objQxPotenceTypeEN.Memo = objRow[conQxPotenceType.Memo] == DBNull.Value ? null : objRow[conQxPotenceType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPotenceTypeEN.PotenceTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPotenceTypeEN);
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
public static IEnumerable<clsQxPotenceTypeEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsQxPotenceTypeEN objQxPotenceTypeCond, string strOrderBy)
{
List<clsQxPotenceTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxPotenceTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxPotenceType.AttributeName)
{
if (objQxPotenceTypeCond.IsUpdated(strFldName) == false) continue;
if (objQxPotenceTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxPotenceTypeCond[strFldName].ToString());
}
else
{
if (objQxPotenceTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxPotenceTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxPotenceTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxPotenceTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxPotenceTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxPotenceTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxPotenceTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxPotenceTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxPotenceTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxPotenceTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxPotenceTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxPotenceTypeCond[strFldName]));
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
public static IEnumerable<clsQxPotenceTypeEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsQxPotenceTypeEN objQxPotenceTypeCond = JsonConvert.DeserializeObject<clsQxPotenceTypeEN>(objPagerPara.whereCond);
if (objQxPotenceTypeCond.sfFldComparisonOp == null)
{
objQxPotenceTypeCond.dicFldComparisonOp = null;
}
else
{
objQxPotenceTypeCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objQxPotenceTypeCond.sfFldComparisonOp);
}
clsQxPotenceTypeBL.SetUpdFlag(objQxPotenceTypeCond);
 try
{
CheckProperty4Condition(objQxPotenceTypeCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsQxPotenceTypeBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objQxPotenceTypeCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPotenceTypeEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsQxPotenceTypeEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsQxPotenceTypeEN> arrObjLst = new List<clsQxPotenceTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPotenceTypeEN objQxPotenceTypeEN = new clsQxPotenceTypeEN();
try
{
objQxPotenceTypeEN.PotenceTypeId = objRow[conQxPotenceType.PotenceTypeId].ToString().Trim(); //权限类型Id
objQxPotenceTypeEN.PotenceTypeName = objRow[conQxPotenceType.PotenceTypeName].ToString().Trim(); //权限类型名
objQxPotenceTypeEN.QxPrjId = objRow[conQxPotenceType.QxPrjId].ToString().Trim(); //项目Id
objQxPotenceTypeEN.FuncModuleId = objRow[conQxPotenceType.FuncModuleId] == DBNull.Value ? null : objRow[conQxPotenceType.FuncModuleId].ToString().Trim(); //模块Id
objQxPotenceTypeEN.MenuId = objRow[conQxPotenceType.MenuId] == DBNull.Value ? null : objRow[conQxPotenceType.MenuId].ToString().Trim(); //菜单Id
objQxPotenceTypeEN.ViewId = objRow[conQxPotenceType.ViewId] == DBNull.Value ? null : objRow[conQxPotenceType.ViewId].ToString().Trim(); //界面编号
objQxPotenceTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conQxPotenceType.IsVisible].ToString().Trim()); //是否显示
objQxPotenceTypeEN.UpdDate = objRow[conQxPotenceType.UpdDate].ToString().Trim(); //修改日期
objQxPotenceTypeEN.UpdUserId = objRow[conQxPotenceType.UpdUserId].ToString().Trim(); //修改用户Id
objQxPotenceTypeEN.Memo = objRow[conQxPotenceType.Memo] == DBNull.Value ? null : objRow[conQxPotenceType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPotenceTypeEN.PotenceTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPotenceTypeEN);
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
public static List<clsQxPotenceTypeEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsQxPotenceTypeEN> arrObjLst = new List<clsQxPotenceTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPotenceTypeEN objQxPotenceTypeEN = new clsQxPotenceTypeEN();
try
{
objQxPotenceTypeEN.PotenceTypeId = objRow[conQxPotenceType.PotenceTypeId].ToString().Trim(); //权限类型Id
objQxPotenceTypeEN.PotenceTypeName = objRow[conQxPotenceType.PotenceTypeName].ToString().Trim(); //权限类型名
objQxPotenceTypeEN.QxPrjId = objRow[conQxPotenceType.QxPrjId].ToString().Trim(); //项目Id
objQxPotenceTypeEN.FuncModuleId = objRow[conQxPotenceType.FuncModuleId] == DBNull.Value ? null : objRow[conQxPotenceType.FuncModuleId].ToString().Trim(); //模块Id
objQxPotenceTypeEN.MenuId = objRow[conQxPotenceType.MenuId] == DBNull.Value ? null : objRow[conQxPotenceType.MenuId].ToString().Trim(); //菜单Id
objQxPotenceTypeEN.ViewId = objRow[conQxPotenceType.ViewId] == DBNull.Value ? null : objRow[conQxPotenceType.ViewId].ToString().Trim(); //界面编号
objQxPotenceTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conQxPotenceType.IsVisible].ToString().Trim()); //是否显示
objQxPotenceTypeEN.UpdDate = objRow[conQxPotenceType.UpdDate].ToString().Trim(); //修改日期
objQxPotenceTypeEN.UpdUserId = objRow[conQxPotenceType.UpdUserId].ToString().Trim(); //修改用户Id
objQxPotenceTypeEN.Memo = objRow[conQxPotenceType.Memo] == DBNull.Value ? null : objRow[conQxPotenceType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPotenceTypeEN.PotenceTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPotenceTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPotenceTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsQxPotenceTypeEN> arrObjLst = new List<clsQxPotenceTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPotenceTypeEN objQxPotenceTypeEN = new clsQxPotenceTypeEN();
try
{
objQxPotenceTypeEN.PotenceTypeId = objRow[conQxPotenceType.PotenceTypeId].ToString().Trim(); //权限类型Id
objQxPotenceTypeEN.PotenceTypeName = objRow[conQxPotenceType.PotenceTypeName].ToString().Trim(); //权限类型名
objQxPotenceTypeEN.QxPrjId = objRow[conQxPotenceType.QxPrjId].ToString().Trim(); //项目Id
objQxPotenceTypeEN.FuncModuleId = objRow[conQxPotenceType.FuncModuleId] == DBNull.Value ? null : objRow[conQxPotenceType.FuncModuleId].ToString().Trim(); //模块Id
objQxPotenceTypeEN.MenuId = objRow[conQxPotenceType.MenuId] == DBNull.Value ? null : objRow[conQxPotenceType.MenuId].ToString().Trim(); //菜单Id
objQxPotenceTypeEN.ViewId = objRow[conQxPotenceType.ViewId] == DBNull.Value ? null : objRow[conQxPotenceType.ViewId].ToString().Trim(); //界面编号
objQxPotenceTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conQxPotenceType.IsVisible].ToString().Trim()); //是否显示
objQxPotenceTypeEN.UpdDate = objRow[conQxPotenceType.UpdDate].ToString().Trim(); //修改日期
objQxPotenceTypeEN.UpdUserId = objRow[conQxPotenceType.UpdUserId].ToString().Trim(); //修改用户Id
objQxPotenceTypeEN.Memo = objRow[conQxPotenceType.Memo] == DBNull.Value ? null : objRow[conQxPotenceType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPotenceTypeEN.PotenceTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPotenceTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objQxPotenceTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxPotenceType(ref clsQxPotenceTypeEN objQxPotenceTypeEN)
{
bool bolResult = QxPotenceTypeDA.GetQxPotenceType(ref objQxPotenceTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strPotenceTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxPotenceTypeEN GetObjByPotenceTypeId(string strPotenceTypeId)
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
clsQxPotenceTypeEN objQxPotenceTypeEN = QxPotenceTypeDA.GetObjByPotenceTypeId(strPotenceTypeId);
return objQxPotenceTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsQxPotenceTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsQxPotenceTypeEN objQxPotenceTypeEN = QxPotenceTypeDA.GetFirstObj(strWhereCond);
 return objQxPotenceTypeEN;
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
public static clsQxPotenceTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsQxPotenceTypeEN objQxPotenceTypeEN = QxPotenceTypeDA.GetObjByDataRow(objRow);
 return objQxPotenceTypeEN;
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
public static clsQxPotenceTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsQxPotenceTypeEN objQxPotenceTypeEN = QxPotenceTypeDA.GetObjByDataRow(objRow);
 return objQxPotenceTypeEN;
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
 /// <param name = "lstQxPotenceTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxPotenceTypeEN GetObjByPotenceTypeIdFromList(string strPotenceTypeId, List<clsQxPotenceTypeEN> lstQxPotenceTypeObjLst)
{
foreach (clsQxPotenceTypeEN objQxPotenceTypeEN in lstQxPotenceTypeObjLst)
{
if (objQxPotenceTypeEN.PotenceTypeId == strPotenceTypeId)
{
return objQxPotenceTypeEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetMaxStrIdByPrefix_S)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefix_S(string strPrefix) 
{
if (string.IsNullOrEmpty(strPrefix) == true)
{
var strMsg = string.Format("前缀不能为空.(from {0})",
clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
 string strMaxPotenceTypeId;
 try
 {
 strMaxPotenceTypeId = new clsQxPotenceTypeDA().GetMaxStrIdByPrefix(strPrefix);
 return strMaxPotenceTypeId;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000025)根据前缀获取最大关键字值出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

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
 strPotenceTypeId = new clsQxPotenceTypeDA().GetFirstID(strWhereCond);
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
 arrList = QxPotenceTypeDA.GetID(strWhereCond);
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
bool bolIsExist = QxPotenceTypeDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = QxPotenceTypeDA.IsExist(strPotenceTypeId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strPotenceTypeId">权限类型Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strPotenceTypeId, string strOpUser)
{
clsQxPotenceTypeEN objQxPotenceTypeEN = clsQxPotenceTypeBL.GetObjByPotenceTypeId(strPotenceTypeId);
objQxPotenceTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objQxPotenceTypeEN.UpdUserId = strOpUser;
return clsQxPotenceTypeBL.UpdateBySql2(objQxPotenceTypeEN);
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
 bolIsExist = clsQxPotenceTypeDA.IsExistTable();
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
 bolIsExist = QxPotenceTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objQxPotenceTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsQxPotenceTypeEN objQxPotenceTypeEN)
{
 if (string.IsNullOrEmpty(objQxPotenceTypeEN.PotenceTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQxPotenceTypeBL.IsExist(objQxPotenceTypeEN.PotenceTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQxPotenceTypeEN.PotenceTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (objQxPotenceTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!权限类型名 = [{0}],项目Id = [{1}]的数据已经存在!(in clsQxPotenceTypeBL.AddNewRecordBySql2)", objQxPotenceTypeEN.PotenceTypeName,objQxPotenceTypeEN.QxPrjId);
throw new Exception(strMsg);
}
try
{
bool bolResult = QxPotenceTypeDA.AddNewRecordBySQL2(objQxPotenceTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPotenceTypeBL.ReFreshCache();

if (clsQxPotenceTypeBL.relatedActions != null)
{
clsQxPotenceTypeBL.relatedActions.UpdRelaTabDate(objQxPotenceTypeEN.PotenceTypeId, objQxPotenceTypeEN.UpdUserId);
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
 /// <param name = "objQxPotenceTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsQxPotenceTypeEN objQxPotenceTypeEN)
{
 if (string.IsNullOrEmpty(objQxPotenceTypeEN.PotenceTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQxPotenceTypeBL.IsExist(objQxPotenceTypeEN.PotenceTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQxPotenceTypeEN.PotenceTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (objQxPotenceTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!权限类型名 = [{0}],项目Id = [{1}]的数据已经存在!(in clsQxPotenceTypeBL.AddNewRecordBySql2WithReturnKey)", objQxPotenceTypeEN.PotenceTypeName,objQxPotenceTypeEN.QxPrjId);
throw new Exception(strMsg);
}
try
{
string strKey = QxPotenceTypeDA.AddNewRecordBySQL2WithReturnKey(objQxPotenceTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPotenceTypeBL.ReFreshCache();

if (clsQxPotenceTypeBL.relatedActions != null)
{
clsQxPotenceTypeBL.relatedActions.UpdRelaTabDate(objQxPotenceTypeEN.PotenceTypeId, objQxPotenceTypeEN.UpdUserId);
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
 /// <param name = "strQxPotenceTypeObjXml">代表实体对象的XML串</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql_XML(string strQxPotenceTypeObjXml)
{
clsQxPotenceTypeEN objQxPotenceTypeEN = GetObjFromXmlStr(strQxPotenceTypeObjXml);
try
{
bool bolResult = QxPotenceTypeDA.AddNewRecordBySQL2(objQxPotenceTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPotenceTypeBL.ReFreshCache();

if (clsQxPotenceTypeBL.relatedActions != null)
{
clsQxPotenceTypeBL.relatedActions.UpdRelaTabDate(objQxPotenceTypeEN.PotenceTypeId, objQxPotenceTypeEN.UpdUserId);
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
 /// <param name = "objQxPotenceTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsQxPotenceTypeEN objQxPotenceTypeEN)
{
try
{
bool bolResult = QxPotenceTypeDA.Update(objQxPotenceTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPotenceTypeBL.ReFreshCache();

if (clsQxPotenceTypeBL.relatedActions != null)
{
clsQxPotenceTypeBL.relatedActions.UpdRelaTabDate(objQxPotenceTypeEN.PotenceTypeId, objQxPotenceTypeEN.UpdUserId);
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
 /// <param name = "objQxPotenceTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsQxPotenceTypeEN objQxPotenceTypeEN)
{
 if (string.IsNullOrEmpty(objQxPotenceTypeEN.PotenceTypeId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = QxPotenceTypeDA.UpdateBySql2(objQxPotenceTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPotenceTypeBL.ReFreshCache();

if (clsQxPotenceTypeBL.relatedActions != null)
{
clsQxPotenceTypeBL.relatedActions.UpdRelaTabDate(objQxPotenceTypeEN.PotenceTypeId, objQxPotenceTypeEN.UpdUserId);
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
 /// <param name = "strQxPotenceTypeObjXml">需要修改的对象,用XML来表示</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql_XML(string strQxPotenceTypeObjXml)
{
clsQxPotenceTypeEN objQxPotenceTypeEN = GetObjFromXmlStr(strQxPotenceTypeObjXml);
try
{
bool bolResult = QxPotenceTypeDA.UpdateBySql2(objQxPotenceTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPotenceTypeBL.ReFreshCache();

if (clsQxPotenceTypeBL.relatedActions != null)
{
clsQxPotenceTypeBL.relatedActions.UpdRelaTabDate(objQxPotenceTypeEN.PotenceTypeId, objQxPotenceTypeEN.UpdUserId);
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
 /// <param name = "strPotenceTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strPotenceTypeId)
{
try
{
 clsQxPotenceTypeEN objQxPotenceTypeEN = clsQxPotenceTypeBL.GetObjByPotenceTypeId(strPotenceTypeId);

if (clsQxPotenceTypeBL.relatedActions != null)
{
clsQxPotenceTypeBL.relatedActions.UpdRelaTabDate(objQxPotenceTypeEN.PotenceTypeId, objQxPotenceTypeEN.UpdUserId);
}
if (objQxPotenceTypeEN != null)
{
int intRecNum = QxPotenceTypeDA.DelRecord(strPotenceTypeId);
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
/// <param name="strPotenceTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strPotenceTypeId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
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
//删除与表:[QxPotenceType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conQxPotenceType.PotenceTypeId,
//strPotenceTypeId);
//        clsQxPotenceTypeBL.DelQxPotenceTypesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxPotenceTypeBL.DelRecord(strPotenceTypeId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxPotenceTypeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strPotenceTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strPotenceTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strPotenceTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsQxPotenceTypeBL.relatedActions != null)
{
clsQxPotenceTypeBL.relatedActions.UpdRelaTabDate(strPotenceTypeId, "UpdRelaTabDate");
}
bool bolResult = QxPotenceTypeDA.DelRecord(strPotenceTypeId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "strPotenceTypeId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strPotenceTypeId) 
{
try
{
if (clsQxPotenceTypeBL.relatedActions != null)
{
clsQxPotenceTypeBL.relatedActions.UpdRelaTabDate(strPotenceTypeId, "UpdRelaTabDate");
}
bool bolResult = QxPotenceTypeDA.DelRecordBySP(strPotenceTypeId);
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
 /// <param name = "arrPotenceTypeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelQxPotenceTypes(List<string> arrPotenceTypeIdLst)
{
if (arrPotenceTypeIdLst.Count == 0) return 0;
try
{
if (clsQxPotenceTypeBL.relatedActions != null)
{
foreach (var strPotenceTypeId in arrPotenceTypeIdLst)
{
clsQxPotenceTypeBL.relatedActions.UpdRelaTabDate(strPotenceTypeId, "UpdRelaTabDate");
}
}
int intDelRecNum = QxPotenceTypeDA.DelQxPotenceType(arrPotenceTypeIdLst);
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
public static int DelQxPotenceTypesByCond(string strWhereCond)
{
try
{
if (clsQxPotenceTypeBL.relatedActions != null)
{
List<string> arrPotenceTypeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strPotenceTypeId in arrPotenceTypeId)
{
clsQxPotenceTypeBL.relatedActions.UpdRelaTabDate(strPotenceTypeId, "UpdRelaTabDate");
}
}
int intRecNum = QxPotenceTypeDA.DelQxPotenceType(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[QxPotenceType]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strPotenceTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strPotenceTypeId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
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
//删除与表:[QxPotenceType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxPotenceTypeBL.DelRecord(strPotenceTypeId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxPotenceTypeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strPotenceTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objQxPotenceTypeENS">源对象</param>
 /// <param name = "objQxPotenceTypeENT">目标对象</param>
 public static void CopyTo(clsQxPotenceTypeEN objQxPotenceTypeENS, clsQxPotenceTypeEN objQxPotenceTypeENT)
{
try
{
objQxPotenceTypeENT.PotenceTypeId = objQxPotenceTypeENS.PotenceTypeId; //权限类型Id
objQxPotenceTypeENT.PotenceTypeName = objQxPotenceTypeENS.PotenceTypeName; //权限类型名
objQxPotenceTypeENT.QxPrjId = objQxPotenceTypeENS.QxPrjId; //项目Id
objQxPotenceTypeENT.FuncModuleId = objQxPotenceTypeENS.FuncModuleId; //模块Id
objQxPotenceTypeENT.MenuId = objQxPotenceTypeENS.MenuId; //菜单Id
objQxPotenceTypeENT.ViewId = objQxPotenceTypeENS.ViewId; //界面编号
objQxPotenceTypeENT.IsVisible = objQxPotenceTypeENS.IsVisible; //是否显示
objQxPotenceTypeENT.UpdDate = objQxPotenceTypeENS.UpdDate; //修改日期
objQxPotenceTypeENT.UpdUserId = objQxPotenceTypeENS.UpdUserId; //修改用户Id
objQxPotenceTypeENT.Memo = objQxPotenceTypeENS.Memo; //备注
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
 /// <param name = "objQxPotenceTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsQxPotenceTypeEN objQxPotenceTypeEN)
{
try
{
objQxPotenceTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objQxPotenceTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conQxPotenceType.PotenceTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPotenceTypeEN.PotenceTypeId = objQxPotenceTypeEN.PotenceTypeId; //权限类型Id
}
if (arrFldSet.Contains(conQxPotenceType.PotenceTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPotenceTypeEN.PotenceTypeName = objQxPotenceTypeEN.PotenceTypeName; //权限类型名
}
if (arrFldSet.Contains(conQxPotenceType.QxPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPotenceTypeEN.QxPrjId = objQxPotenceTypeEN.QxPrjId; //项目Id
}
if (arrFldSet.Contains(conQxPotenceType.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPotenceTypeEN.FuncModuleId = objQxPotenceTypeEN.FuncModuleId == "[null]" ? null :  objQxPotenceTypeEN.FuncModuleId; //模块Id
}
if (arrFldSet.Contains(conQxPotenceType.MenuId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPotenceTypeEN.MenuId = objQxPotenceTypeEN.MenuId == "[null]" ? null :  objQxPotenceTypeEN.MenuId; //菜单Id
}
if (arrFldSet.Contains(conQxPotenceType.ViewId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPotenceTypeEN.ViewId = objQxPotenceTypeEN.ViewId == "[null]" ? null :  objQxPotenceTypeEN.ViewId; //界面编号
}
if (arrFldSet.Contains(conQxPotenceType.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPotenceTypeEN.IsVisible = objQxPotenceTypeEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(conQxPotenceType.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPotenceTypeEN.UpdDate = objQxPotenceTypeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conQxPotenceType.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPotenceTypeEN.UpdUserId = objQxPotenceTypeEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conQxPotenceType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPotenceTypeEN.Memo = objQxPotenceTypeEN.Memo == "[null]" ? null :  objQxPotenceTypeEN.Memo; //备注
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
 /// <param name = "objQxPotenceTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsQxPotenceTypeEN objQxPotenceTypeEN)
{
try
{
if (objQxPotenceTypeEN.FuncModuleId == "[null]") objQxPotenceTypeEN.FuncModuleId = null; //模块Id
if (objQxPotenceTypeEN.MenuId == "[null]") objQxPotenceTypeEN.MenuId = null; //菜单Id
if (objQxPotenceTypeEN.ViewId == "[null]") objQxPotenceTypeEN.ViewId = null; //界面编号
if (objQxPotenceTypeEN.Memo == "[null]") objQxPotenceTypeEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsQxPotenceTypeEN objQxPotenceTypeEN)
{
 QxPotenceTypeDA.CheckPropertyNew(objQxPotenceTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsQxPotenceTypeEN objQxPotenceTypeEN)
{
 QxPotenceTypeDA.CheckProperty4Condition(objQxPotenceTypeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_PotenceTypeIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[权限类型]...","0");
List<clsQxPotenceTypeEN> arrQxPotenceTypeObjLst = GetAllQxPotenceTypeObjLstCache(); 
objDDL.DataValueField = conQxPotenceType.PotenceTypeId;
objDDL.DataTextField = conQxPotenceType.PotenceTypeName;
objDDL.DataSource = arrQxPotenceTypeObjLst;
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
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PotenceTypeId");
//if (arrQxPotenceTypeObjLstCache == null)
//{
//arrQxPotenceTypeObjLstCache = QxPotenceTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strPotenceTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxPotenceTypeEN GetObjByPotenceTypeIdCache(string strPotenceTypeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsQxPotenceTypeEN._CurrTabName);
List<clsQxPotenceTypeEN> arrQxPotenceTypeObjLstCache = GetObjLstCache();
IEnumerable <clsQxPotenceTypeEN> arrQxPotenceTypeObjLst_Sel =
arrQxPotenceTypeObjLstCache
.Where(x=> x.PotenceTypeId == strPotenceTypeId 
);
if (arrQxPotenceTypeObjLst_Sel.Count() == 0)
{
   clsQxPotenceTypeEN obj = clsQxPotenceTypeBL.GetObjByPotenceTypeId(strPotenceTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrQxPotenceTypeObjLst_Sel.First();
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
clsQxPotenceTypeEN objQxPotenceType = GetObjByPotenceTypeIdCache(strPotenceTypeId);
if (objQxPotenceType == null) return "";
return objQxPotenceType.PotenceTypeName;
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
clsQxPotenceTypeEN objQxPotenceType = GetObjByPotenceTypeIdCache(strPotenceTypeId);
if (objQxPotenceType == null) return "";
return objQxPotenceType.PotenceTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxPotenceTypeEN> GetAllQxPotenceTypeObjLstCache()
{
//获取缓存中的对象列表
List<clsQxPotenceTypeEN> arrQxPotenceTypeObjLstCache = GetObjLstCache(); 
return arrQxPotenceTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxPotenceTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsQxPotenceTypeEN._CurrTabName);
List<clsQxPotenceTypeEN> arrQxPotenceTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrQxPotenceTypeObjLstCache;
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
string strKey = string.Format("{0}", clsQxPotenceTypeEN._CurrTabName);
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
if (clsQxPotenceTypeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsQxPotenceTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsQxPotenceTypeBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--QxPotenceType(权限类型)
 /// 唯一性条件:PotenceTypeName_QxPrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQxPotenceTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsQxPotenceTypeEN objQxPotenceTypeEN)
{
//检测记录是否存在
string strResult = QxPotenceTypeDA.GetUniCondStr(objQxPotenceTypeEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2024-03-20
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstQxPotenceTypeObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsQxPotenceTypeEN> lstQxPotenceTypeObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstQxPotenceTypeObjLst, writer);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 序列化一个对象列表到XmlWriter
 /// 作者:pyf
 /// 日期:2024-03-20
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXML)
 /// </summary>
 /// <param name = "lstQxPotenceTypeObjLst">[clsQxPotenceTypeEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsQxPotenceTypeEN> lstQxPotenceTypeObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsQxPotenceTypeBL.listXmlNode);
writer.WriteStartElement(clsQxPotenceTypeBL.itemsXmlNode);
foreach (clsQxPotenceTypeEN objQxPotenceTypeEN in lstQxPotenceTypeObjLst)
{
clsQxPotenceTypeBL.SerializeXML(writer, objQxPotenceTypeEN);
}
writer.WriteEndElement();
writer.WriteEndElement();
return true;
}

 /// <summary>
 /// 把一个对象序列化到XML中
 /// 作者:pyf
 /// 日期:2024-03-20
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeXML)
 /// </summary>
 /// <param name = "writer">目标:序列化到的XmlWriter</param>
 /// <param name = "objQxPotenceTypeEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsQxPotenceTypeEN objQxPotenceTypeEN)
{
writer.WriteStartElement(clsQxPotenceTypeBL.itemXmlNode);
 
if (objQxPotenceTypeEN.PotenceTypeId != null)
{
writer.WriteElementString(conQxPotenceType.PotenceTypeId, objQxPotenceTypeEN.PotenceTypeId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPotenceTypeEN.PotenceTypeName != null)
{
writer.WriteElementString(conQxPotenceType.PotenceTypeName, objQxPotenceTypeEN.PotenceTypeName.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPotenceTypeEN.QxPrjId != null)
{
writer.WriteElementString(conQxPotenceType.QxPrjId, objQxPotenceTypeEN.QxPrjId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPotenceTypeEN.FuncModuleId != null)
{
writer.WriteElementString(conQxPotenceType.FuncModuleId, objQxPotenceTypeEN.FuncModuleId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPotenceTypeEN.MenuId != null)
{
writer.WriteElementString(conQxPotenceType.MenuId, objQxPotenceTypeEN.MenuId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPotenceTypeEN.ViewId != null)
{
writer.WriteElementString(conQxPotenceType.ViewId, objQxPotenceTypeEN.ViewId.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(conQxPotenceType.IsVisible, objQxPotenceTypeEN.IsVisible.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objQxPotenceTypeEN.UpdDate != null)
{
writer.WriteElementString(conQxPotenceType.UpdDate, objQxPotenceTypeEN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPotenceTypeEN.UpdUserId != null)
{
writer.WriteElementString(conQxPotenceType.UpdUserId, objQxPotenceTypeEN.UpdUserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPotenceTypeEN.Memo != null)
{
writer.WriteElementString(conQxPotenceType.Memo, objQxPotenceTypeEN.Memo.ToString(CultureInfo.InvariantCulture));
}
writer.WriteEndElement();
}

 /// <summary>
 /// 读XmlReader到一个对象
 /// 作者:pyf
 /// 日期:2024-03-20
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlReader)
 /// </summary>
 /// <param name = "reader">提供的数据源:XmlReader</param>
 /// <returns>返回的一个对象</returns>
public static clsQxPotenceTypeEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsQxPotenceTypeEN objQxPotenceTypeEN = new clsQxPotenceTypeEN();
reader.Read();
while (!(reader.Name == clsQxPotenceTypeBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(conQxPotenceType.PotenceTypeId))
{
objQxPotenceTypeEN.PotenceTypeId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPotenceType.PotenceTypeName))
{
objQxPotenceTypeEN.PotenceTypeName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPotenceType.QxPrjId))
{
objQxPotenceTypeEN.QxPrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPotenceType.FuncModuleId))
{
objQxPotenceTypeEN.FuncModuleId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPotenceType.MenuId))
{
objQxPotenceTypeEN.MenuId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPotenceType.ViewId))
{
objQxPotenceTypeEN.ViewId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPotenceType.IsVisible))
{
objQxPotenceTypeEN.IsVisible = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(conQxPotenceType.UpdDate))
{
objQxPotenceTypeEN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPotenceType.UpdUserId))
{
objQxPotenceTypeEN.UpdUserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPotenceType.Memo))
{
objQxPotenceTypeEN.Memo = reader.ReadElementContentAsString();
}
}
return objQxPotenceTypeEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strQxPotenceTypeObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsQxPotenceTypeEN GetObjFromXmlStr(string strQxPotenceTypeObjXmlStr)
{
clsQxPotenceTypeEN objQxPotenceTypeEN = new clsQxPotenceTypeEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strQxPotenceTypeObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsQxPotenceTypeBL.itemXmlNode))
{
objQxPotenceTypeEN = GetObjFromXml(reader);
return objQxPotenceTypeEN;
}
}
return objQxPotenceTypeEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2024-03-20
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objQxPotenceTypeEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsQxPotenceTypeEN objQxPotenceTypeEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objQxPotenceTypeEN);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2024-03-20
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strPotenceTypeId)
{
if (strInFldName != conQxPotenceType.PotenceTypeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conQxPotenceType.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conQxPotenceType.AttributeName));
throw new Exception(strMsg);
}
var objQxPotenceType = clsQxPotenceTypeBL.GetObjByPotenceTypeIdCache(strPotenceTypeId);
if (objQxPotenceType == null) return "";
return objQxPotenceType[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2024-03-20
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objQxPotenceTypeEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsQxPotenceTypeEN objQxPotenceTypeEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsQxPotenceTypeEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objQxPotenceTypeEN[strField]);
}
sbJSON.Remove(sbJSON.Length - 1, 1);
sbJSON.Append("}");
return sbJSON.ToString();
}

 /// <summary>
 /// 序列化一个对象列表到JSON串
 /// 作者:pyf
 /// 日期:2024-03-20
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToJSONStr)
 /// </summary>
 /// <param name = "lstQxPotenceTypeObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsQxPotenceTypeEN> lstQxPotenceTypeObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstQxPotenceTypeObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsQxPotenceTypeEN objQxPotenceTypeEN in lstQxPotenceTypeObjLst)
{
string strJSON_One = SerializeObjToJSON(objQxPotenceTypeEN);
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
int intRecCount = clsQxPotenceTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsQxPotenceTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsQxPotenceTypeDA.GetRecCount();
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
int intRecCount = clsQxPotenceTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objQxPotenceTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsQxPotenceTypeEN objQxPotenceTypeCond)
{
List<clsQxPotenceTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxPotenceTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxPotenceType.AttributeName)
{
if (objQxPotenceTypeCond.IsUpdated(strFldName) == false) continue;
if (objQxPotenceTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxPotenceTypeCond[strFldName].ToString());
}
else
{
if (objQxPotenceTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxPotenceTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxPotenceTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxPotenceTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxPotenceTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxPotenceTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxPotenceTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxPotenceTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxPotenceTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxPotenceTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxPotenceTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxPotenceTypeCond[strFldName]));
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
 List<string> arrList = clsQxPotenceTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = QxPotenceTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = QxPotenceTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = QxPotenceTypeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxPotenceTypeDA.SetFldValue(clsQxPotenceTypeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = QxPotenceTypeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxPotenceTypeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxPotenceTypeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxPotenceTypeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[QxPotenceType] "); 
 strCreateTabCode.Append(" ( "); 
 // /**权限类型Id*/ 
 strCreateTabCode.Append(" PotenceTypeId char(6) primary key, "); 
 // /**权限类型名*/ 
 strCreateTabCode.Append(" PotenceTypeName varchar(50) not Null, "); 
 // /**项目Id*/ 
 strCreateTabCode.Append(" QxPrjId char(4) not Null, "); 
 // /**模块Id*/ 
 strCreateTabCode.Append(" FuncModuleId char(4) Null, "); 
 // /**菜单Id*/ 
 strCreateTabCode.Append(" MenuId char(8) Null, "); 
 // /**界面编号*/ 
 strCreateTabCode.Append(" ViewId char(8) Null, "); 
 // /**是否显示*/ 
 strCreateTabCode.Append(" IsVisible bit Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) not Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) not Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**模块名*/ 
 strCreateTabCode.Append(" FuncModuleName varchar(30) Null, "); 
 // /**菜单名*/ 
 strCreateTabCode.Append(" MenuName varchar(50) Null, "); 
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
 /// 权限类型(QxPotenceType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4QxPotenceType : clsCommFun4BL
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
clsQxPotenceTypeBL.ReFreshThisCache();
}
}

}