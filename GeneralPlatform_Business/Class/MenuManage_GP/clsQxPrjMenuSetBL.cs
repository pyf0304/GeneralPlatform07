
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxPrjMenuSetBL
 表名:QxPrjMenuSet(00140045)
 * 版本:2024.01.01.1(服务器:WIN-SRV103-116)
 日期:2024/01/06 12:56:03
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
public static class  clsQxPrjMenuSetBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strMenuSetId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxPrjMenuSetEN GetObj(this K_MenuSetId_QxPrjMenuSet myKey)
{
clsQxPrjMenuSetEN objQxPrjMenuSetEN = clsQxPrjMenuSetBL.QxPrjMenuSetDA.GetObjByMenuSetId(myKey.Value);
return objQxPrjMenuSetEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQxPrjMenuSetEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQxPrjMenuSetEN objQxPrjMenuSetEN)
{
if (CheckUniqueness(objQxPrjMenuSetEN) == false)
{
var strMsg = string.Format("记录已经存在!菜单集名称 = [{0}],项目Id = [{1}]的数据已经存在!(in clsQxPrjMenuSetBL.AddNewRecord)", objQxPrjMenuSetEN.MenuSetName,objQxPrjMenuSetEN.QxPrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQxPrjMenuSetEN.MenuSetId) == true || clsQxPrjMenuSetBL.IsExist(objQxPrjMenuSetEN.MenuSetId) == true)
 {
     objQxPrjMenuSetEN.MenuSetId = clsQxPrjMenuSetBL.GetMaxStrId_S();
 }
bool bolResult = clsQxPrjMenuSetBL.QxPrjMenuSetDA.AddNewRecordBySQL2(objQxPrjMenuSetEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjMenuSetBL.ReFreshCache();

if (clsQxPrjMenuSetBL.relatedActions != null)
{
clsQxPrjMenuSetBL.relatedActions.UpdRelaTabDate(objQxPrjMenuSetEN.MenuSetId, objQxPrjMenuSetEN.UpdUser);
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
public static bool AddRecordEx(this clsQxPrjMenuSetEN objQxPrjMenuSetEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsQxPrjMenuSetBL.IsExist(objQxPrjMenuSetEN.MenuSetId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objQxPrjMenuSetEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objQxPrjMenuSetEN.CheckUniqueness() == false)
{
strMsg = string.Format("(菜单集名称(MenuSetName)=[{0}],项目Id(QxPrjId)=[{1}])已经存在,不能重复!", objQxPrjMenuSetEN.MenuSetName, objQxPrjMenuSetEN.QxPrjId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objQxPrjMenuSetEN.MenuSetId) == true || clsQxPrjMenuSetBL.IsExist(objQxPrjMenuSetEN.MenuSetId) == true)
 {
     objQxPrjMenuSetEN.MenuSetId = clsQxPrjMenuSetBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objQxPrjMenuSetEN.AddNewRecord();
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
 /// <param name = "objQxPrjMenuSetEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsQxPrjMenuSetEN objQxPrjMenuSetEN)
{
if (CheckUniqueness(objQxPrjMenuSetEN) == false)
{
var strMsg = string.Format("记录已经存在!菜单集名称 = [{0}],项目Id = [{1}]的数据已经存在!(in clsQxPrjMenuSetBL.AddNewRecordWithMaxId)", objQxPrjMenuSetEN.MenuSetName,objQxPrjMenuSetEN.QxPrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQxPrjMenuSetEN.MenuSetId) == true || clsQxPrjMenuSetBL.IsExist(objQxPrjMenuSetEN.MenuSetId) == true)
 {
     objQxPrjMenuSetEN.MenuSetId = clsQxPrjMenuSetBL.GetMaxStrId_S();
 }
string strMenuSetId = clsQxPrjMenuSetBL.QxPrjMenuSetDA.AddNewRecordBySQL2WithReturnKey(objQxPrjMenuSetEN);
     objQxPrjMenuSetEN.MenuSetId = strMenuSetId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjMenuSetBL.ReFreshCache();

if (clsQxPrjMenuSetBL.relatedActions != null)
{
clsQxPrjMenuSetBL.relatedActions.UpdRelaTabDate(objQxPrjMenuSetEN.MenuSetId, objQxPrjMenuSetEN.UpdUser);
}
return strMenuSetId;
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
 /// <param name = "objQxPrjMenuSetEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsQxPrjMenuSetEN objQxPrjMenuSetEN)
{
if (CheckUniqueness(objQxPrjMenuSetEN) == false)
{
var strMsg = string.Format("记录已经存在!菜单集名称 = [{0}],项目Id = [{1}]的数据已经存在!(in clsQxPrjMenuSetBL.AddNewRecordWithReturnKey)", objQxPrjMenuSetEN.MenuSetName,objQxPrjMenuSetEN.QxPrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQxPrjMenuSetEN.MenuSetId) == true || clsQxPrjMenuSetBL.IsExist(objQxPrjMenuSetEN.MenuSetId) == true)
 {
     objQxPrjMenuSetEN.MenuSetId = clsQxPrjMenuSetBL.GetMaxStrId_S();
 }
string strKey = clsQxPrjMenuSetBL.QxPrjMenuSetDA.AddNewRecordBySQL2WithReturnKey(objQxPrjMenuSetEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjMenuSetBL.ReFreshCache();

if (clsQxPrjMenuSetBL.relatedActions != null)
{
clsQxPrjMenuSetBL.relatedActions.UpdRelaTabDate(objQxPrjMenuSetEN.MenuSetId, objQxPrjMenuSetEN.UpdUser);
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
 /// <param name = "objQxPrjMenuSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenuSetEN SetMenuSetId(this clsQxPrjMenuSetEN objQxPrjMenuSetEN, string strMenuSetId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuSetId, 4, conQxPrjMenuSet.MenuSetId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMenuSetId, 4, conQxPrjMenuSet.MenuSetId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenuSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenuSetEN SetMenuSetName(this clsQxPrjMenuSetEN objQxPrjMenuSetEN, string strMenuSetName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMenuSetName, conQxPrjMenuSet.MenuSetName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuSetName, 50, conQxPrjMenuSet.MenuSetName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenuSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenuSetEN SetMenuSetENName(this clsQxPrjMenuSetEN objQxPrjMenuSetEN, string strMenuSetENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuSetENName, 50, conQxPrjMenuSet.MenuSetENName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenuSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenuSetEN SetQxPrjId(this clsQxPrjMenuSetEN objQxPrjMenuSetEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, conQxPrjMenuSet.QxPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQxPrjId, 4, conQxPrjMenuSet.QxPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, conQxPrjMenuSet.QxPrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenuSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenuSetEN SetCmPrjId(this clsQxPrjMenuSetEN objQxPrjMenuSetEN, string strCmPrjId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmPrjId, 6, conQxPrjMenuSet.CmPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCmPrjId, 6, conQxPrjMenuSet.CmPrjId);
}
objQxPrjMenuSetEN.CmPrjId = strCmPrjId; //Cm项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenuSetEN.dicFldComparisonOp.ContainsKey(conQxPrjMenuSet.CmPrjId) == false)
{
objQxPrjMenuSetEN.dicFldComparisonOp.Add(conQxPrjMenuSet.CmPrjId, strComparisonOp);
}
else
{
objQxPrjMenuSetEN.dicFldComparisonOp[conQxPrjMenuSet.CmPrjId] = strComparisonOp;
}
}
return objQxPrjMenuSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenuSetEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenuSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenuSetEN SetUpdDate(this clsQxPrjMenuSetEN objQxPrjMenuSetEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conQxPrjMenuSet.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQxPrjMenuSet.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenuSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenuSetEN SetUpdUser(this clsQxPrjMenuSetEN objQxPrjMenuSetEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conQxPrjMenuSet.UpdUser);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenuSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenuSetEN SetMemo(this clsQxPrjMenuSetEN objQxPrjMenuSetEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQxPrjMenuSet.Memo);
}
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
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objQxPrjMenuSetEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsQxPrjMenuSetEN objQxPrjMenuSetEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objQxPrjMenuSetEN.CheckPropertyNew();
clsQxPrjMenuSetEN objQxPrjMenuSetCond = new clsQxPrjMenuSetEN();
string strCondition = objQxPrjMenuSetCond
.SetMenuSetId(objQxPrjMenuSetEN.MenuSetId, "<>")
.SetMenuSetName(objQxPrjMenuSetEN.MenuSetName, "=")
.SetQxPrjId(objQxPrjMenuSetEN.QxPrjId, "=")
.GetCombineCondition();
objQxPrjMenuSetEN._IsCheckProperty = true;
bool bolIsExist = clsQxPrjMenuSetBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(MenuSetName_QxPrjId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objQxPrjMenuSetEN.Update();
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
 /// <param name = "objQxPrjMenuSet">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsQxPrjMenuSetEN objQxPrjMenuSet)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsQxPrjMenuSetEN objQxPrjMenuSetCond = new clsQxPrjMenuSetEN();
string strCondition = objQxPrjMenuSetCond
.SetMenuSetName(objQxPrjMenuSet.MenuSetName, "=")
.SetQxPrjId(objQxPrjMenuSet.QxPrjId, "=")
.GetCombineCondition();
objQxPrjMenuSet._IsCheckProperty = true;
bool bolIsExist = clsQxPrjMenuSetBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objQxPrjMenuSet.MenuSetId = clsQxPrjMenuSetBL.GetFirstID_S(strCondition);
objQxPrjMenuSet.UpdateWithCondition(strCondition);
}
else
{
objQxPrjMenuSet.MenuSetId = clsQxPrjMenuSetBL.GetMaxStrId_S();
objQxPrjMenuSet.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objQxPrjMenuSetEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxPrjMenuSetEN objQxPrjMenuSetEN)
{
 if (string.IsNullOrEmpty(objQxPrjMenuSetEN.MenuSetId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxPrjMenuSetBL.QxPrjMenuSetDA.UpdateBySql2(objQxPrjMenuSetEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjMenuSetBL.ReFreshCache();

if (clsQxPrjMenuSetBL.relatedActions != null)
{
clsQxPrjMenuSetBL.relatedActions.UpdRelaTabDate(objQxPrjMenuSetEN.MenuSetId, objQxPrjMenuSetEN.UpdUser);
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
 /// <param name = "objQxPrjMenuSetEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxPrjMenuSetEN objQxPrjMenuSetEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objQxPrjMenuSetEN.MenuSetId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxPrjMenuSetBL.QxPrjMenuSetDA.UpdateBySql2(objQxPrjMenuSetEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjMenuSetBL.ReFreshCache();

if (clsQxPrjMenuSetBL.relatedActions != null)
{
clsQxPrjMenuSetBL.relatedActions.UpdRelaTabDate(objQxPrjMenuSetEN.MenuSetId, objQxPrjMenuSetEN.UpdUser);
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
 /// <param name = "objQxPrjMenuSetEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxPrjMenuSetEN objQxPrjMenuSetEN, string strWhereCond)
{
try
{
bool bolResult = clsQxPrjMenuSetBL.QxPrjMenuSetDA.UpdateBySqlWithCondition(objQxPrjMenuSetEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjMenuSetBL.ReFreshCache();

if (clsQxPrjMenuSetBL.relatedActions != null)
{
clsQxPrjMenuSetBL.relatedActions.UpdRelaTabDate(objQxPrjMenuSetEN.MenuSetId, objQxPrjMenuSetEN.UpdUser);
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
 /// <param name = "objQxPrjMenuSetEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxPrjMenuSetEN objQxPrjMenuSetEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsQxPrjMenuSetBL.QxPrjMenuSetDA.UpdateBySqlWithConditionTransaction(objQxPrjMenuSetEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjMenuSetBL.ReFreshCache();

if (clsQxPrjMenuSetBL.relatedActions != null)
{
clsQxPrjMenuSetBL.relatedActions.UpdRelaTabDate(objQxPrjMenuSetEN.MenuSetId, objQxPrjMenuSetEN.UpdUser);
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
 /// <param name = "strMenuSetId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsQxPrjMenuSetEN objQxPrjMenuSetEN)
{
try
{
int intRecNum = clsQxPrjMenuSetBL.QxPrjMenuSetDA.DelRecord(objQxPrjMenuSetEN.MenuSetId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjMenuSetBL.ReFreshCache();

if (clsQxPrjMenuSetBL.relatedActions != null)
{
clsQxPrjMenuSetBL.relatedActions.UpdRelaTabDate(objQxPrjMenuSetEN.MenuSetId, objQxPrjMenuSetEN.UpdUser);
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
 /// <param name = "objQxPrjMenuSetENS">源对象</param>
 /// <param name = "objQxPrjMenuSetENT">目标对象</param>
 public static void CopyTo(this clsQxPrjMenuSetEN objQxPrjMenuSetENS, clsQxPrjMenuSetEN objQxPrjMenuSetENT)
{
try
{
objQxPrjMenuSetENT.MenuSetId = objQxPrjMenuSetENS.MenuSetId; //菜单集Id
objQxPrjMenuSetENT.MenuSetName = objQxPrjMenuSetENS.MenuSetName; //菜单集名称
objQxPrjMenuSetENT.MenuSetENName = objQxPrjMenuSetENS.MenuSetENName; //菜单集英文名
objQxPrjMenuSetENT.QxPrjId = objQxPrjMenuSetENS.QxPrjId; //项目Id
objQxPrjMenuSetENT.CmPrjId = objQxPrjMenuSetENS.CmPrjId; //Cm项目Id
objQxPrjMenuSetENT.IsDefault = objQxPrjMenuSetENS.IsDefault; //是否默认
objQxPrjMenuSetENT.UpdDate = objQxPrjMenuSetENS.UpdDate; //修改日期
objQxPrjMenuSetENT.UpdUser = objQxPrjMenuSetENS.UpdUser; //修改用户
objQxPrjMenuSetENT.Memo = objQxPrjMenuSetENS.Memo; //备注
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
 /// <param name = "objQxPrjMenuSetENS">源对象</param>
 /// <returns>目标对象=>clsQxPrjMenuSetEN:objQxPrjMenuSetENT</returns>
 public static clsQxPrjMenuSetEN CopyTo(this clsQxPrjMenuSetEN objQxPrjMenuSetENS)
{
try
{
 clsQxPrjMenuSetEN objQxPrjMenuSetENT = new clsQxPrjMenuSetEN()
{
MenuSetId = objQxPrjMenuSetENS.MenuSetId, //菜单集Id
MenuSetName = objQxPrjMenuSetENS.MenuSetName, //菜单集名称
MenuSetENName = objQxPrjMenuSetENS.MenuSetENName, //菜单集英文名
QxPrjId = objQxPrjMenuSetENS.QxPrjId, //项目Id
CmPrjId = objQxPrjMenuSetENS.CmPrjId, //Cm项目Id
IsDefault = objQxPrjMenuSetENS.IsDefault, //是否默认
UpdDate = objQxPrjMenuSetENS.UpdDate, //修改日期
UpdUser = objQxPrjMenuSetENS.UpdUser, //修改用户
Memo = objQxPrjMenuSetENS.Memo, //备注
};
 return objQxPrjMenuSetENT;
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
public static void CheckPropertyNew(this clsQxPrjMenuSetEN objQxPrjMenuSetEN)
{
 clsQxPrjMenuSetBL.QxPrjMenuSetDA.CheckPropertyNew(objQxPrjMenuSetEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsQxPrjMenuSetEN objQxPrjMenuSetEN)
{
 clsQxPrjMenuSetBL.QxPrjMenuSetDA.CheckProperty4Condition(objQxPrjMenuSetEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
if (objQxPrjMenuSetCond.IsUpdated(conQxPrjMenuSet.CmPrjId) == true)
{
string strComparisonOpCmPrjId = objQxPrjMenuSetCond.dicFldComparisonOp[conQxPrjMenuSet.CmPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenuSet.CmPrjId, objQxPrjMenuSetCond.CmPrjId, strComparisonOpCmPrjId);
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
 /// 检查唯一性(Uniqueness)--QxPrjMenuSet(菜单集), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:MenuSetName_QxPrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objQxPrjMenuSetEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsQxPrjMenuSetEN objQxPrjMenuSetEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objQxPrjMenuSetEN == null) return true;
if (objQxPrjMenuSetEN.MenuSetId == null || objQxPrjMenuSetEN.MenuSetId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and MenuSetName = '{0}'", objQxPrjMenuSetEN.MenuSetName);
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxPrjMenuSetEN.QxPrjId);
if (clsQxPrjMenuSetBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("MenuSetId !=  '{0}'", objQxPrjMenuSetEN.MenuSetId);
 sbCondition.AppendFormat(" and MenuSetName = '{0}'", objQxPrjMenuSetEN.MenuSetName);
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxPrjMenuSetEN.QxPrjId);
if (clsQxPrjMenuSetBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--QxPrjMenuSet(菜单集), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:MenuSetName_QxPrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objQxPrjMenuSetEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsQxPrjMenuSetEN objQxPrjMenuSetEN)
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
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_QxPrjMenuSet
{
public virtual bool UpdRelaTabDate(string strMenuSetId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 根据表内容设置enum列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GeneEnumConstList)
 /// </summary>
public class enumQxPrjMenuSet
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
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsQxPrjMenuSetBL
{
public static RelatedActions_QxPrjMenuSet relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "QxPrjMenuSetListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "QxPrjMenuSetList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsQxPrjMenuSetEN> arrQxPrjMenuSetObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsQxPrjMenuSetDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsQxPrjMenuSetDA QxPrjMenuSetDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsQxPrjMenuSetDA();
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
 public clsQxPrjMenuSetBL()
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
if (string.IsNullOrEmpty(clsQxPrjMenuSetEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxPrjMenuSetEN._ConnectString);
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
objDS = QxPrjMenuSetDA.GetDataSet(strWhereCond);
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
objDS = QxPrjMenuSetDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = QxPrjMenuSetDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_QxPrjMenuSet(string strWhereCond)
{
DataTable objDT;
try
{
objDT = QxPrjMenuSetDA.GetDataTable_QxPrjMenuSet(strWhereCond);
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
objDT = QxPrjMenuSetDA.GetDataTable(strWhereCond);
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
objDT = QxPrjMenuSetDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = QxPrjMenuSetDA.GetDataTable(strWhereCond, strTabName);
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
objDT = QxPrjMenuSetDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = QxPrjMenuSetDA.GetDataTable_Top(objTopPara);
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
objDT = QxPrjMenuSetDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = QxPrjMenuSetDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = QxPrjMenuSetDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = QxPrjMenuSetDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = QxPrjMenuSetDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = QxPrjMenuSetDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = QxPrjMenuSetDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = QxPrjMenuSetDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
 /// <param name = "arrMenuSetIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsQxPrjMenuSetEN> GetObjLstByMenuSetIdLst(List<string> arrMenuSetIdLst)
{
List<clsQxPrjMenuSetEN> arrObjLst = new List<clsQxPrjMenuSetEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMenuSetIdLst, true);
 string strWhereCond = string.Format("MenuSetId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjMenuSetEN objQxPrjMenuSetEN = new clsQxPrjMenuSetEN();
try
{
objQxPrjMenuSetEN.MenuSetId = objRow[conQxPrjMenuSet.MenuSetId].ToString().Trim(); //菜单集Id
objQxPrjMenuSetEN.MenuSetName = objRow[conQxPrjMenuSet.MenuSetName].ToString().Trim(); //菜单集名称
objQxPrjMenuSetEN.MenuSetENName = objRow[conQxPrjMenuSet.MenuSetENName] == DBNull.Value ? null : objRow[conQxPrjMenuSet.MenuSetENName].ToString().Trim(); //菜单集英文名
objQxPrjMenuSetEN.QxPrjId = objRow[conQxPrjMenuSet.QxPrjId].ToString().Trim(); //项目Id
objQxPrjMenuSetEN.CmPrjId = objRow[conQxPrjMenuSet.CmPrjId] == DBNull.Value ? null : objRow[conQxPrjMenuSet.CmPrjId].ToString().Trim(); //Cm项目Id
objQxPrjMenuSetEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenuSet.IsDefault].ToString().Trim()); //是否默认
objQxPrjMenuSetEN.UpdDate = objRow[conQxPrjMenuSet.UpdDate].ToString().Trim(); //修改日期
objQxPrjMenuSetEN.UpdUser = objRow[conQxPrjMenuSet.UpdUser] == DBNull.Value ? null : objRow[conQxPrjMenuSet.UpdUser].ToString().Trim(); //修改用户
objQxPrjMenuSetEN.Memo = objRow[conQxPrjMenuSet.Memo] == DBNull.Value ? null : objRow[conQxPrjMenuSet.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjMenuSetEN.MenuSetId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjMenuSetEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMenuSetIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsQxPrjMenuSetEN> GetObjLstByMenuSetIdLstCache(List<string> arrMenuSetIdLst)
{
string strKey = string.Format("{0}", clsQxPrjMenuSetEN._CurrTabName);
List<clsQxPrjMenuSetEN> arrQxPrjMenuSetObjLstCache = GetObjLstCache();
IEnumerable <clsQxPrjMenuSetEN> arrQxPrjMenuSetObjLst_Sel =
arrQxPrjMenuSetObjLstCache
.Where(x => arrMenuSetIdLst.Contains(x.MenuSetId));
return arrQxPrjMenuSetObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPrjMenuSetEN> GetObjLst(string strWhereCond)
{
List<clsQxPrjMenuSetEN> arrObjLst = new List<clsQxPrjMenuSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjMenuSetEN objQxPrjMenuSetEN = new clsQxPrjMenuSetEN();
try
{
objQxPrjMenuSetEN.MenuSetId = objRow[conQxPrjMenuSet.MenuSetId].ToString().Trim(); //菜单集Id
objQxPrjMenuSetEN.MenuSetName = objRow[conQxPrjMenuSet.MenuSetName].ToString().Trim(); //菜单集名称
objQxPrjMenuSetEN.MenuSetENName = objRow[conQxPrjMenuSet.MenuSetENName] == DBNull.Value ? null : objRow[conQxPrjMenuSet.MenuSetENName].ToString().Trim(); //菜单集英文名
objQxPrjMenuSetEN.QxPrjId = objRow[conQxPrjMenuSet.QxPrjId].ToString().Trim(); //项目Id
objQxPrjMenuSetEN.CmPrjId = objRow[conQxPrjMenuSet.CmPrjId] == DBNull.Value ? null : objRow[conQxPrjMenuSet.CmPrjId].ToString().Trim(); //Cm项目Id
objQxPrjMenuSetEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenuSet.IsDefault].ToString().Trim()); //是否默认
objQxPrjMenuSetEN.UpdDate = objRow[conQxPrjMenuSet.UpdDate].ToString().Trim(); //修改日期
objQxPrjMenuSetEN.UpdUser = objRow[conQxPrjMenuSet.UpdUser] == DBNull.Value ? null : objRow[conQxPrjMenuSet.UpdUser].ToString().Trim(); //修改用户
objQxPrjMenuSetEN.Memo = objRow[conQxPrjMenuSet.Memo] == DBNull.Value ? null : objRow[conQxPrjMenuSet.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjMenuSetEN.MenuSetId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjMenuSetEN);
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
public static List<clsQxPrjMenuSetEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsQxPrjMenuSetEN> arrObjLst = new List<clsQxPrjMenuSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjMenuSetEN objQxPrjMenuSetEN = new clsQxPrjMenuSetEN();
try
{
objQxPrjMenuSetEN.MenuSetId = objRow[conQxPrjMenuSet.MenuSetId].ToString().Trim(); //菜单集Id
objQxPrjMenuSetEN.MenuSetName = objRow[conQxPrjMenuSet.MenuSetName].ToString().Trim(); //菜单集名称
objQxPrjMenuSetEN.MenuSetENName = objRow[conQxPrjMenuSet.MenuSetENName] == DBNull.Value ? null : objRow[conQxPrjMenuSet.MenuSetENName].ToString().Trim(); //菜单集英文名
objQxPrjMenuSetEN.QxPrjId = objRow[conQxPrjMenuSet.QxPrjId].ToString().Trim(); //项目Id
objQxPrjMenuSetEN.CmPrjId = objRow[conQxPrjMenuSet.CmPrjId] == DBNull.Value ? null : objRow[conQxPrjMenuSet.CmPrjId].ToString().Trim(); //Cm项目Id
objQxPrjMenuSetEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenuSet.IsDefault].ToString().Trim()); //是否默认
objQxPrjMenuSetEN.UpdDate = objRow[conQxPrjMenuSet.UpdDate].ToString().Trim(); //修改日期
objQxPrjMenuSetEN.UpdUser = objRow[conQxPrjMenuSet.UpdUser] == DBNull.Value ? null : objRow[conQxPrjMenuSet.UpdUser].ToString().Trim(); //修改用户
objQxPrjMenuSetEN.Memo = objRow[conQxPrjMenuSet.Memo] == DBNull.Value ? null : objRow[conQxPrjMenuSet.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjMenuSetEN.MenuSetId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjMenuSetEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objQxPrjMenuSetCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsQxPrjMenuSetEN> GetSubObjLstCache(clsQxPrjMenuSetEN objQxPrjMenuSetCond)
{
List<clsQxPrjMenuSetEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxPrjMenuSetEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxPrjMenuSet.AttributeName)
{
if (objQxPrjMenuSetCond.IsUpdated(strFldName) == false) continue;
if (objQxPrjMenuSetCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxPrjMenuSetCond[strFldName].ToString());
}
else
{
if (objQxPrjMenuSetCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxPrjMenuSetCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxPrjMenuSetCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxPrjMenuSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxPrjMenuSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxPrjMenuSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxPrjMenuSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxPrjMenuSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxPrjMenuSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxPrjMenuSetCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxPrjMenuSetCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxPrjMenuSetCond[strFldName]));
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
public static List<clsQxPrjMenuSetEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsQxPrjMenuSetEN> arrObjLst = new List<clsQxPrjMenuSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjMenuSetEN objQxPrjMenuSetEN = new clsQxPrjMenuSetEN();
try
{
objQxPrjMenuSetEN.MenuSetId = objRow[conQxPrjMenuSet.MenuSetId].ToString().Trim(); //菜单集Id
objQxPrjMenuSetEN.MenuSetName = objRow[conQxPrjMenuSet.MenuSetName].ToString().Trim(); //菜单集名称
objQxPrjMenuSetEN.MenuSetENName = objRow[conQxPrjMenuSet.MenuSetENName] == DBNull.Value ? null : objRow[conQxPrjMenuSet.MenuSetENName].ToString().Trim(); //菜单集英文名
objQxPrjMenuSetEN.QxPrjId = objRow[conQxPrjMenuSet.QxPrjId].ToString().Trim(); //项目Id
objQxPrjMenuSetEN.CmPrjId = objRow[conQxPrjMenuSet.CmPrjId] == DBNull.Value ? null : objRow[conQxPrjMenuSet.CmPrjId].ToString().Trim(); //Cm项目Id
objQxPrjMenuSetEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenuSet.IsDefault].ToString().Trim()); //是否默认
objQxPrjMenuSetEN.UpdDate = objRow[conQxPrjMenuSet.UpdDate].ToString().Trim(); //修改日期
objQxPrjMenuSetEN.UpdUser = objRow[conQxPrjMenuSet.UpdUser] == DBNull.Value ? null : objRow[conQxPrjMenuSet.UpdUser].ToString().Trim(); //修改用户
objQxPrjMenuSetEN.Memo = objRow[conQxPrjMenuSet.Memo] == DBNull.Value ? null : objRow[conQxPrjMenuSet.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjMenuSetEN.MenuSetId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjMenuSetEN);
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
public static List<clsQxPrjMenuSetEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsQxPrjMenuSetEN> arrObjLst = new List<clsQxPrjMenuSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjMenuSetEN objQxPrjMenuSetEN = new clsQxPrjMenuSetEN();
try
{
objQxPrjMenuSetEN.MenuSetId = objRow[conQxPrjMenuSet.MenuSetId].ToString().Trim(); //菜单集Id
objQxPrjMenuSetEN.MenuSetName = objRow[conQxPrjMenuSet.MenuSetName].ToString().Trim(); //菜单集名称
objQxPrjMenuSetEN.MenuSetENName = objRow[conQxPrjMenuSet.MenuSetENName] == DBNull.Value ? null : objRow[conQxPrjMenuSet.MenuSetENName].ToString().Trim(); //菜单集英文名
objQxPrjMenuSetEN.QxPrjId = objRow[conQxPrjMenuSet.QxPrjId].ToString().Trim(); //项目Id
objQxPrjMenuSetEN.CmPrjId = objRow[conQxPrjMenuSet.CmPrjId] == DBNull.Value ? null : objRow[conQxPrjMenuSet.CmPrjId].ToString().Trim(); //Cm项目Id
objQxPrjMenuSetEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenuSet.IsDefault].ToString().Trim()); //是否默认
objQxPrjMenuSetEN.UpdDate = objRow[conQxPrjMenuSet.UpdDate].ToString().Trim(); //修改日期
objQxPrjMenuSetEN.UpdUser = objRow[conQxPrjMenuSet.UpdUser] == DBNull.Value ? null : objRow[conQxPrjMenuSet.UpdUser].ToString().Trim(); //修改用户
objQxPrjMenuSetEN.Memo = objRow[conQxPrjMenuSet.Memo] == DBNull.Value ? null : objRow[conQxPrjMenuSet.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjMenuSetEN.MenuSetId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjMenuSetEN);
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
List<clsQxPrjMenuSetEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsQxPrjMenuSetEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPrjMenuSetEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsQxPrjMenuSetEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsQxPrjMenuSetEN> arrObjLst = new List<clsQxPrjMenuSetEN>(); 
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
	clsQxPrjMenuSetEN objQxPrjMenuSetEN = new clsQxPrjMenuSetEN();
try
{
objQxPrjMenuSetEN.MenuSetId = objRow[conQxPrjMenuSet.MenuSetId].ToString().Trim(); //菜单集Id
objQxPrjMenuSetEN.MenuSetName = objRow[conQxPrjMenuSet.MenuSetName].ToString().Trim(); //菜单集名称
objQxPrjMenuSetEN.MenuSetENName = objRow[conQxPrjMenuSet.MenuSetENName] == DBNull.Value ? null : objRow[conQxPrjMenuSet.MenuSetENName].ToString().Trim(); //菜单集英文名
objQxPrjMenuSetEN.QxPrjId = objRow[conQxPrjMenuSet.QxPrjId].ToString().Trim(); //项目Id
objQxPrjMenuSetEN.CmPrjId = objRow[conQxPrjMenuSet.CmPrjId] == DBNull.Value ? null : objRow[conQxPrjMenuSet.CmPrjId].ToString().Trim(); //Cm项目Id
objQxPrjMenuSetEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenuSet.IsDefault].ToString().Trim()); //是否默认
objQxPrjMenuSetEN.UpdDate = objRow[conQxPrjMenuSet.UpdDate].ToString().Trim(); //修改日期
objQxPrjMenuSetEN.UpdUser = objRow[conQxPrjMenuSet.UpdUser] == DBNull.Value ? null : objRow[conQxPrjMenuSet.UpdUser].ToString().Trim(); //修改用户
objQxPrjMenuSetEN.Memo = objRow[conQxPrjMenuSet.Memo] == DBNull.Value ? null : objRow[conQxPrjMenuSet.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjMenuSetEN.MenuSetId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjMenuSetEN);
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
public static List<clsQxPrjMenuSetEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsQxPrjMenuSetEN> arrObjLst = new List<clsQxPrjMenuSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjMenuSetEN objQxPrjMenuSetEN = new clsQxPrjMenuSetEN();
try
{
objQxPrjMenuSetEN.MenuSetId = objRow[conQxPrjMenuSet.MenuSetId].ToString().Trim(); //菜单集Id
objQxPrjMenuSetEN.MenuSetName = objRow[conQxPrjMenuSet.MenuSetName].ToString().Trim(); //菜单集名称
objQxPrjMenuSetEN.MenuSetENName = objRow[conQxPrjMenuSet.MenuSetENName] == DBNull.Value ? null : objRow[conQxPrjMenuSet.MenuSetENName].ToString().Trim(); //菜单集英文名
objQxPrjMenuSetEN.QxPrjId = objRow[conQxPrjMenuSet.QxPrjId].ToString().Trim(); //项目Id
objQxPrjMenuSetEN.CmPrjId = objRow[conQxPrjMenuSet.CmPrjId] == DBNull.Value ? null : objRow[conQxPrjMenuSet.CmPrjId].ToString().Trim(); //Cm项目Id
objQxPrjMenuSetEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenuSet.IsDefault].ToString().Trim()); //是否默认
objQxPrjMenuSetEN.UpdDate = objRow[conQxPrjMenuSet.UpdDate].ToString().Trim(); //修改日期
objQxPrjMenuSetEN.UpdUser = objRow[conQxPrjMenuSet.UpdUser] == DBNull.Value ? null : objRow[conQxPrjMenuSet.UpdUser].ToString().Trim(); //修改用户
objQxPrjMenuSetEN.Memo = objRow[conQxPrjMenuSet.Memo] == DBNull.Value ? null : objRow[conQxPrjMenuSet.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjMenuSetEN.MenuSetId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjMenuSetEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsQxPrjMenuSetEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsQxPrjMenuSetEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsQxPrjMenuSetEN> arrObjLst = new List<clsQxPrjMenuSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjMenuSetEN objQxPrjMenuSetEN = new clsQxPrjMenuSetEN();
try
{
objQxPrjMenuSetEN.MenuSetId = objRow[conQxPrjMenuSet.MenuSetId].ToString().Trim(); //菜单集Id
objQxPrjMenuSetEN.MenuSetName = objRow[conQxPrjMenuSet.MenuSetName].ToString().Trim(); //菜单集名称
objQxPrjMenuSetEN.MenuSetENName = objRow[conQxPrjMenuSet.MenuSetENName] == DBNull.Value ? null : objRow[conQxPrjMenuSet.MenuSetENName].ToString().Trim(); //菜单集英文名
objQxPrjMenuSetEN.QxPrjId = objRow[conQxPrjMenuSet.QxPrjId].ToString().Trim(); //项目Id
objQxPrjMenuSetEN.CmPrjId = objRow[conQxPrjMenuSet.CmPrjId] == DBNull.Value ? null : objRow[conQxPrjMenuSet.CmPrjId].ToString().Trim(); //Cm项目Id
objQxPrjMenuSetEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenuSet.IsDefault].ToString().Trim()); //是否默认
objQxPrjMenuSetEN.UpdDate = objRow[conQxPrjMenuSet.UpdDate].ToString().Trim(); //修改日期
objQxPrjMenuSetEN.UpdUser = objRow[conQxPrjMenuSet.UpdUser] == DBNull.Value ? null : objRow[conQxPrjMenuSet.UpdUser].ToString().Trim(); //修改用户
objQxPrjMenuSetEN.Memo = objRow[conQxPrjMenuSet.Memo] == DBNull.Value ? null : objRow[conQxPrjMenuSet.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjMenuSetEN.MenuSetId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjMenuSetEN);
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
public static List<clsQxPrjMenuSetEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsQxPrjMenuSetEN> arrObjLst = new List<clsQxPrjMenuSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjMenuSetEN objQxPrjMenuSetEN = new clsQxPrjMenuSetEN();
try
{
objQxPrjMenuSetEN.MenuSetId = objRow[conQxPrjMenuSet.MenuSetId].ToString().Trim(); //菜单集Id
objQxPrjMenuSetEN.MenuSetName = objRow[conQxPrjMenuSet.MenuSetName].ToString().Trim(); //菜单集名称
objQxPrjMenuSetEN.MenuSetENName = objRow[conQxPrjMenuSet.MenuSetENName] == DBNull.Value ? null : objRow[conQxPrjMenuSet.MenuSetENName].ToString().Trim(); //菜单集英文名
objQxPrjMenuSetEN.QxPrjId = objRow[conQxPrjMenuSet.QxPrjId].ToString().Trim(); //项目Id
objQxPrjMenuSetEN.CmPrjId = objRow[conQxPrjMenuSet.CmPrjId] == DBNull.Value ? null : objRow[conQxPrjMenuSet.CmPrjId].ToString().Trim(); //Cm项目Id
objQxPrjMenuSetEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenuSet.IsDefault].ToString().Trim()); //是否默认
objQxPrjMenuSetEN.UpdDate = objRow[conQxPrjMenuSet.UpdDate].ToString().Trim(); //修改日期
objQxPrjMenuSetEN.UpdUser = objRow[conQxPrjMenuSet.UpdUser] == DBNull.Value ? null : objRow[conQxPrjMenuSet.UpdUser].ToString().Trim(); //修改用户
objQxPrjMenuSetEN.Memo = objRow[conQxPrjMenuSet.Memo] == DBNull.Value ? null : objRow[conQxPrjMenuSet.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjMenuSetEN.MenuSetId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjMenuSetEN);
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
public static IEnumerable<clsQxPrjMenuSetEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsQxPrjMenuSetEN objQxPrjMenuSetCond, string strOrderBy)
{
List<clsQxPrjMenuSetEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxPrjMenuSetEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxPrjMenuSet.AttributeName)
{
if (objQxPrjMenuSetCond.IsUpdated(strFldName) == false) continue;
if (objQxPrjMenuSetCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxPrjMenuSetCond[strFldName].ToString());
}
else
{
if (objQxPrjMenuSetCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxPrjMenuSetCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxPrjMenuSetCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxPrjMenuSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxPrjMenuSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxPrjMenuSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxPrjMenuSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxPrjMenuSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxPrjMenuSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxPrjMenuSetCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxPrjMenuSetCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxPrjMenuSetCond[strFldName]));
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
public static IEnumerable<clsQxPrjMenuSetEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsQxPrjMenuSetEN objQxPrjMenuSetCond = JsonConvert.DeserializeObject<clsQxPrjMenuSetEN>(objPagerPara.whereCond);
if (objQxPrjMenuSetCond.sfFldComparisonOp == null)
{
objQxPrjMenuSetCond.dicFldComparisonOp = null;
}
else
{
objQxPrjMenuSetCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objQxPrjMenuSetCond.sfFldComparisonOp);
}
clsQxPrjMenuSetBL.SetUpdFlag(objQxPrjMenuSetCond);
 try
{
CheckProperty4Condition(objQxPrjMenuSetCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsQxPrjMenuSetBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objQxPrjMenuSetCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPrjMenuSetEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsQxPrjMenuSetEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsQxPrjMenuSetEN> arrObjLst = new List<clsQxPrjMenuSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjMenuSetEN objQxPrjMenuSetEN = new clsQxPrjMenuSetEN();
try
{
objQxPrjMenuSetEN.MenuSetId = objRow[conQxPrjMenuSet.MenuSetId].ToString().Trim(); //菜单集Id
objQxPrjMenuSetEN.MenuSetName = objRow[conQxPrjMenuSet.MenuSetName].ToString().Trim(); //菜单集名称
objQxPrjMenuSetEN.MenuSetENName = objRow[conQxPrjMenuSet.MenuSetENName] == DBNull.Value ? null : objRow[conQxPrjMenuSet.MenuSetENName].ToString().Trim(); //菜单集英文名
objQxPrjMenuSetEN.QxPrjId = objRow[conQxPrjMenuSet.QxPrjId].ToString().Trim(); //项目Id
objQxPrjMenuSetEN.CmPrjId = objRow[conQxPrjMenuSet.CmPrjId] == DBNull.Value ? null : objRow[conQxPrjMenuSet.CmPrjId].ToString().Trim(); //Cm项目Id
objQxPrjMenuSetEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenuSet.IsDefault].ToString().Trim()); //是否默认
objQxPrjMenuSetEN.UpdDate = objRow[conQxPrjMenuSet.UpdDate].ToString().Trim(); //修改日期
objQxPrjMenuSetEN.UpdUser = objRow[conQxPrjMenuSet.UpdUser] == DBNull.Value ? null : objRow[conQxPrjMenuSet.UpdUser].ToString().Trim(); //修改用户
objQxPrjMenuSetEN.Memo = objRow[conQxPrjMenuSet.Memo] == DBNull.Value ? null : objRow[conQxPrjMenuSet.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjMenuSetEN.MenuSetId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjMenuSetEN);
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
public static List<clsQxPrjMenuSetEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsQxPrjMenuSetEN> arrObjLst = new List<clsQxPrjMenuSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjMenuSetEN objQxPrjMenuSetEN = new clsQxPrjMenuSetEN();
try
{
objQxPrjMenuSetEN.MenuSetId = objRow[conQxPrjMenuSet.MenuSetId].ToString().Trim(); //菜单集Id
objQxPrjMenuSetEN.MenuSetName = objRow[conQxPrjMenuSet.MenuSetName].ToString().Trim(); //菜单集名称
objQxPrjMenuSetEN.MenuSetENName = objRow[conQxPrjMenuSet.MenuSetENName] == DBNull.Value ? null : objRow[conQxPrjMenuSet.MenuSetENName].ToString().Trim(); //菜单集英文名
objQxPrjMenuSetEN.QxPrjId = objRow[conQxPrjMenuSet.QxPrjId].ToString().Trim(); //项目Id
objQxPrjMenuSetEN.CmPrjId = objRow[conQxPrjMenuSet.CmPrjId] == DBNull.Value ? null : objRow[conQxPrjMenuSet.CmPrjId].ToString().Trim(); //Cm项目Id
objQxPrjMenuSetEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenuSet.IsDefault].ToString().Trim()); //是否默认
objQxPrjMenuSetEN.UpdDate = objRow[conQxPrjMenuSet.UpdDate].ToString().Trim(); //修改日期
objQxPrjMenuSetEN.UpdUser = objRow[conQxPrjMenuSet.UpdUser] == DBNull.Value ? null : objRow[conQxPrjMenuSet.UpdUser].ToString().Trim(); //修改用户
objQxPrjMenuSetEN.Memo = objRow[conQxPrjMenuSet.Memo] == DBNull.Value ? null : objRow[conQxPrjMenuSet.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjMenuSetEN.MenuSetId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjMenuSetEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPrjMenuSetEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsQxPrjMenuSetEN> arrObjLst = new List<clsQxPrjMenuSetEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjMenuSetEN objQxPrjMenuSetEN = new clsQxPrjMenuSetEN();
try
{
objQxPrjMenuSetEN.MenuSetId = objRow[conQxPrjMenuSet.MenuSetId].ToString().Trim(); //菜单集Id
objQxPrjMenuSetEN.MenuSetName = objRow[conQxPrjMenuSet.MenuSetName].ToString().Trim(); //菜单集名称
objQxPrjMenuSetEN.MenuSetENName = objRow[conQxPrjMenuSet.MenuSetENName] == DBNull.Value ? null : objRow[conQxPrjMenuSet.MenuSetENName].ToString().Trim(); //菜单集英文名
objQxPrjMenuSetEN.QxPrjId = objRow[conQxPrjMenuSet.QxPrjId].ToString().Trim(); //项目Id
objQxPrjMenuSetEN.CmPrjId = objRow[conQxPrjMenuSet.CmPrjId] == DBNull.Value ? null : objRow[conQxPrjMenuSet.CmPrjId].ToString().Trim(); //Cm项目Id
objQxPrjMenuSetEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenuSet.IsDefault].ToString().Trim()); //是否默认
objQxPrjMenuSetEN.UpdDate = objRow[conQxPrjMenuSet.UpdDate].ToString().Trim(); //修改日期
objQxPrjMenuSetEN.UpdUser = objRow[conQxPrjMenuSet.UpdUser] == DBNull.Value ? null : objRow[conQxPrjMenuSet.UpdUser].ToString().Trim(); //修改用户
objQxPrjMenuSetEN.Memo = objRow[conQxPrjMenuSet.Memo] == DBNull.Value ? null : objRow[conQxPrjMenuSet.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjMenuSetEN.MenuSetId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjMenuSetEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objQxPrjMenuSetEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxPrjMenuSet(ref clsQxPrjMenuSetEN objQxPrjMenuSetEN)
{
bool bolResult = QxPrjMenuSetDA.GetQxPrjMenuSet(ref objQxPrjMenuSetEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strMenuSetId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxPrjMenuSetEN GetObjByMenuSetId(string strMenuSetId)
{
if (strMenuSetId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strMenuSetId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strMenuSetId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strMenuSetId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsQxPrjMenuSetEN objQxPrjMenuSetEN = QxPrjMenuSetDA.GetObjByMenuSetId(strMenuSetId);
return objQxPrjMenuSetEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsQxPrjMenuSetEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsQxPrjMenuSetEN objQxPrjMenuSetEN = QxPrjMenuSetDA.GetFirstObj(strWhereCond);
 return objQxPrjMenuSetEN;
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
public static clsQxPrjMenuSetEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsQxPrjMenuSetEN objQxPrjMenuSetEN = QxPrjMenuSetDA.GetObjByDataRow(objRow);
 return objQxPrjMenuSetEN;
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
public static clsQxPrjMenuSetEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsQxPrjMenuSetEN objQxPrjMenuSetEN = QxPrjMenuSetDA.GetObjByDataRow(objRow);
 return objQxPrjMenuSetEN;
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
 /// <param name = "strMenuSetId">所给的关键字</param>
 /// <param name = "lstQxPrjMenuSetObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxPrjMenuSetEN GetObjByMenuSetIdFromList(string strMenuSetId, List<clsQxPrjMenuSetEN> lstQxPrjMenuSetObjLst)
{
foreach (clsQxPrjMenuSetEN objQxPrjMenuSetEN in lstQxPrjMenuSetObjLst)
{
if (objQxPrjMenuSetEN.MenuSetId == strMenuSetId)
{
return objQxPrjMenuSetEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetMaxStrId_S)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId_S() 
{
 string strMaxMenuSetId;
 try
 {
 strMaxMenuSetId = clsQxPrjMenuSetDA.GetMaxStrId();
 return strMaxMenuSetId;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000024)获取最大关键字值出错, {1}.(from {0})",
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
 string strMenuSetId;
 try
 {
 strMenuSetId = new clsQxPrjMenuSetDA().GetFirstID(strWhereCond);
 return strMenuSetId;
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
 arrList = QxPrjMenuSetDA.GetID(strWhereCond);
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
bool bolIsExist = QxPrjMenuSetDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strMenuSetId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strMenuSetId)
{
if (string.IsNullOrEmpty(strMenuSetId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strMenuSetId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = QxPrjMenuSetDA.IsExist(strMenuSetId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strMenuSetId">菜单集Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strMenuSetId, string strOpUser)
{
clsQxPrjMenuSetEN objQxPrjMenuSetEN = clsQxPrjMenuSetBL.GetObjByMenuSetId(strMenuSetId);
objQxPrjMenuSetEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objQxPrjMenuSetEN.UpdUser = strOpUser;
return clsQxPrjMenuSetBL.UpdateBySql2(objQxPrjMenuSetEN);
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
 bolIsExist = clsQxPrjMenuSetDA.IsExistTable();
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
 bolIsExist = QxPrjMenuSetDA.IsExistTable(strTabName);
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
 /// <param name = "objQxPrjMenuSetEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsQxPrjMenuSetEN objQxPrjMenuSetEN)
{
if (objQxPrjMenuSetEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!菜单集名称 = [{0}],项目Id = [{1}]的数据已经存在!(in clsQxPrjMenuSetBL.AddNewRecordBySql2)", objQxPrjMenuSetEN.MenuSetName,objQxPrjMenuSetEN.QxPrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQxPrjMenuSetEN.MenuSetId) == true || clsQxPrjMenuSetBL.IsExist(objQxPrjMenuSetEN.MenuSetId) == true)
 {
     objQxPrjMenuSetEN.MenuSetId = clsQxPrjMenuSetBL.GetMaxStrId_S();
 }
bool bolResult = QxPrjMenuSetDA.AddNewRecordBySQL2(objQxPrjMenuSetEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjMenuSetBL.ReFreshCache();

if (clsQxPrjMenuSetBL.relatedActions != null)
{
clsQxPrjMenuSetBL.relatedActions.UpdRelaTabDate(objQxPrjMenuSetEN.MenuSetId, objQxPrjMenuSetEN.UpdUser);
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
 /// <param name = "objQxPrjMenuSetEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsQxPrjMenuSetEN objQxPrjMenuSetEN)
{
if (objQxPrjMenuSetEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!菜单集名称 = [{0}],项目Id = [{1}]的数据已经存在!(in clsQxPrjMenuSetBL.AddNewRecordBySql2WithReturnKey)", objQxPrjMenuSetEN.MenuSetName,objQxPrjMenuSetEN.QxPrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQxPrjMenuSetEN.MenuSetId) == true || clsQxPrjMenuSetBL.IsExist(objQxPrjMenuSetEN.MenuSetId) == true)
 {
     objQxPrjMenuSetEN.MenuSetId = clsQxPrjMenuSetBL.GetMaxStrId_S();
 }
string strKey = QxPrjMenuSetDA.AddNewRecordBySQL2WithReturnKey(objQxPrjMenuSetEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjMenuSetBL.ReFreshCache();

if (clsQxPrjMenuSetBL.relatedActions != null)
{
clsQxPrjMenuSetBL.relatedActions.UpdRelaTabDate(objQxPrjMenuSetEN.MenuSetId, objQxPrjMenuSetEN.UpdUser);
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
 /// <param name = "strQxPrjMenuSetObjXml">代表实体对象的XML串</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql_XML(string strQxPrjMenuSetObjXml)
{
clsQxPrjMenuSetEN objQxPrjMenuSetEN = GetObjFromXmlStr(strQxPrjMenuSetObjXml);
try
{
bool bolResult = QxPrjMenuSetDA.AddNewRecordBySQL2(objQxPrjMenuSetEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjMenuSetBL.ReFreshCache();

if (clsQxPrjMenuSetBL.relatedActions != null)
{
clsQxPrjMenuSetBL.relatedActions.UpdRelaTabDate(objQxPrjMenuSetEN.MenuSetId, objQxPrjMenuSetEN.UpdUser);
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
 /// <param name = "objQxPrjMenuSetEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsQxPrjMenuSetEN objQxPrjMenuSetEN)
{
try
{
bool bolResult = QxPrjMenuSetDA.Update(objQxPrjMenuSetEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjMenuSetBL.ReFreshCache();

if (clsQxPrjMenuSetBL.relatedActions != null)
{
clsQxPrjMenuSetBL.relatedActions.UpdRelaTabDate(objQxPrjMenuSetEN.MenuSetId, objQxPrjMenuSetEN.UpdUser);
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
 /// <param name = "objQxPrjMenuSetEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsQxPrjMenuSetEN objQxPrjMenuSetEN)
{
 if (string.IsNullOrEmpty(objQxPrjMenuSetEN.MenuSetId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = QxPrjMenuSetDA.UpdateBySql2(objQxPrjMenuSetEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjMenuSetBL.ReFreshCache();

if (clsQxPrjMenuSetBL.relatedActions != null)
{
clsQxPrjMenuSetBL.relatedActions.UpdRelaTabDate(objQxPrjMenuSetEN.MenuSetId, objQxPrjMenuSetEN.UpdUser);
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
 /// <param name = "strQxPrjMenuSetObjXml">需要修改的对象,用XML来表示</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql_XML(string strQxPrjMenuSetObjXml)
{
clsQxPrjMenuSetEN objQxPrjMenuSetEN = GetObjFromXmlStr(strQxPrjMenuSetObjXml);
try
{
bool bolResult = QxPrjMenuSetDA.UpdateBySql2(objQxPrjMenuSetEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjMenuSetBL.ReFreshCache();

if (clsQxPrjMenuSetBL.relatedActions != null)
{
clsQxPrjMenuSetBL.relatedActions.UpdRelaTabDate(objQxPrjMenuSetEN.MenuSetId, objQxPrjMenuSetEN.UpdUser);
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
 /// <param name = "strMenuSetId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strMenuSetId)
{
try
{
 clsQxPrjMenuSetEN objQxPrjMenuSetEN = clsQxPrjMenuSetBL.GetObjByMenuSetId(strMenuSetId);

if (clsQxPrjMenuSetBL.relatedActions != null)
{
clsQxPrjMenuSetBL.relatedActions.UpdRelaTabDate(objQxPrjMenuSetEN.MenuSetId, objQxPrjMenuSetEN.UpdUser);
}
if (objQxPrjMenuSetEN != null)
{
int intRecNum = QxPrjMenuSetDA.DelRecord(strMenuSetId);
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
/// <param name="strMenuSetId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strMenuSetId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxPrjMenuSetDA.GetSpecSQLObj();
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
//删除与表:[QxPrjMenuSet]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conQxPrjMenuSet.MenuSetId,
//strMenuSetId);
//        clsQxPrjMenuSetBL.DelQxPrjMenuSetsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxPrjMenuSetBL.DelRecord(strMenuSetId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxPrjMenuSetBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strMenuSetId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strMenuSetId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strMenuSetId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsQxPrjMenuSetBL.relatedActions != null)
{
clsQxPrjMenuSetBL.relatedActions.UpdRelaTabDate(strMenuSetId, "UpdRelaTabDate");
}
bool bolResult = QxPrjMenuSetDA.DelRecord(strMenuSetId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "strMenuSetId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strMenuSetId) 
{
try
{
if (clsQxPrjMenuSetBL.relatedActions != null)
{
clsQxPrjMenuSetBL.relatedActions.UpdRelaTabDate(strMenuSetId, "UpdRelaTabDate");
}
bool bolResult = QxPrjMenuSetDA.DelRecordBySP(strMenuSetId);
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
 /// <param name = "arrMenuSetIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelQxPrjMenuSets(List<string> arrMenuSetIdLst)
{
if (arrMenuSetIdLst.Count == 0) return 0;
try
{
if (clsQxPrjMenuSetBL.relatedActions != null)
{
foreach (var strMenuSetId in arrMenuSetIdLst)
{
clsQxPrjMenuSetBL.relatedActions.UpdRelaTabDate(strMenuSetId, "UpdRelaTabDate");
}
}
int intDelRecNum = QxPrjMenuSetDA.DelQxPrjMenuSet(arrMenuSetIdLst);
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
public static int DelQxPrjMenuSetsByCond(string strWhereCond)
{
try
{
if (clsQxPrjMenuSetBL.relatedActions != null)
{
List<string> arrMenuSetId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strMenuSetId in arrMenuSetId)
{
clsQxPrjMenuSetBL.relatedActions.UpdRelaTabDate(strMenuSetId, "UpdRelaTabDate");
}
}
int intRecNum = QxPrjMenuSetDA.DelQxPrjMenuSet(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[QxPrjMenuSet]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strMenuSetId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strMenuSetId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxPrjMenuSetDA.GetSpecSQLObj();
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
//删除与表:[QxPrjMenuSet]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxPrjMenuSetBL.DelRecord(strMenuSetId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxPrjMenuSetBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strMenuSetId, clsStackTrace.GetCurrClassFunction());
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
objQxPrjMenuSetENT.CmPrjId = objQxPrjMenuSetENS.CmPrjId; //Cm项目Id
objQxPrjMenuSetENT.IsDefault = objQxPrjMenuSetENS.IsDefault; //是否默认
objQxPrjMenuSetENT.UpdDate = objQxPrjMenuSetENS.UpdDate; //修改日期
objQxPrjMenuSetENT.UpdUser = objQxPrjMenuSetENS.UpdUser; //修改用户
objQxPrjMenuSetENT.Memo = objQxPrjMenuSetENS.Memo; //备注
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
 /// <param name = "objQxPrjMenuSetEN">源简化对象</param>
 public static void SetUpdFlag(clsQxPrjMenuSetEN objQxPrjMenuSetEN)
{
try
{
objQxPrjMenuSetEN.ClearUpdateState();
   string strsfUpdFldSetStr = objQxPrjMenuSetEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conQxPrjMenuSet.MenuSetId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenuSetEN.MenuSetId = objQxPrjMenuSetEN.MenuSetId; //菜单集Id
}
if (arrFldSet.Contains(conQxPrjMenuSet.MenuSetName, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenuSetEN.MenuSetName = objQxPrjMenuSetEN.MenuSetName; //菜单集名称
}
if (arrFldSet.Contains(conQxPrjMenuSet.MenuSetENName, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenuSetEN.MenuSetENName = objQxPrjMenuSetEN.MenuSetENName == "[null]" ? null :  objQxPrjMenuSetEN.MenuSetENName; //菜单集英文名
}
if (arrFldSet.Contains(conQxPrjMenuSet.QxPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenuSetEN.QxPrjId = objQxPrjMenuSetEN.QxPrjId; //项目Id
}
if (arrFldSet.Contains(conQxPrjMenuSet.CmPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenuSetEN.CmPrjId = objQxPrjMenuSetEN.CmPrjId == "[null]" ? null :  objQxPrjMenuSetEN.CmPrjId; //Cm项目Id
}
if (arrFldSet.Contains(conQxPrjMenuSet.IsDefault, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenuSetEN.IsDefault = objQxPrjMenuSetEN.IsDefault; //是否默认
}
if (arrFldSet.Contains(conQxPrjMenuSet.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenuSetEN.UpdDate = objQxPrjMenuSetEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conQxPrjMenuSet.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenuSetEN.UpdUser = objQxPrjMenuSetEN.UpdUser == "[null]" ? null :  objQxPrjMenuSetEN.UpdUser; //修改用户
}
if (arrFldSet.Contains(conQxPrjMenuSet.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenuSetEN.Memo = objQxPrjMenuSetEN.Memo == "[null]" ? null :  objQxPrjMenuSetEN.Memo; //备注
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
 /// <param name = "objQxPrjMenuSetEN">源简化对象</param>
 public static void AccessFldValueNull(clsQxPrjMenuSetEN objQxPrjMenuSetEN)
{
try
{
if (objQxPrjMenuSetEN.MenuSetENName == "[null]") objQxPrjMenuSetEN.MenuSetENName = null; //菜单集英文名
if (objQxPrjMenuSetEN.CmPrjId == "[null]") objQxPrjMenuSetEN.CmPrjId = null; //Cm项目Id
if (objQxPrjMenuSetEN.UpdUser == "[null]") objQxPrjMenuSetEN.UpdUser = null; //修改用户
if (objQxPrjMenuSetEN.Memo == "[null]") objQxPrjMenuSetEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsQxPrjMenuSetEN objQxPrjMenuSetEN)
{
 QxPrjMenuSetDA.CheckPropertyNew(objQxPrjMenuSetEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsQxPrjMenuSetEN objQxPrjMenuSetEN)
{
 QxPrjMenuSetDA.CheckProperty4Condition(objQxPrjMenuSetEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_MenuSetIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[菜单集]...","0");
List<clsQxPrjMenuSetEN> arrQxPrjMenuSetObjLst = GetAllQxPrjMenuSetObjLstCache(); 
objDDL.DataValueField = conQxPrjMenuSet.MenuSetId;
objDDL.DataTextField = conQxPrjMenuSet.MenuSetName;
objDDL.DataSource = arrQxPrjMenuSetObjLst;
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
if (clsQxPrjMenuSetBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxPrjMenuSetBL没有刷新缓存机制(clsQxPrjMenuSetBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by MenuSetId");
//if (arrQxPrjMenuSetObjLstCache == null)
//{
//arrQxPrjMenuSetObjLstCache = QxPrjMenuSetDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strMenuSetId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxPrjMenuSetEN GetObjByMenuSetIdCache(string strMenuSetId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsQxPrjMenuSetEN._CurrTabName);
List<clsQxPrjMenuSetEN> arrQxPrjMenuSetObjLstCache = GetObjLstCache();
IEnumerable <clsQxPrjMenuSetEN> arrQxPrjMenuSetObjLst_Sel =
arrQxPrjMenuSetObjLstCache
.Where(x=> x.MenuSetId == strMenuSetId 
);
if (arrQxPrjMenuSetObjLst_Sel.Count() == 0)
{
   clsQxPrjMenuSetEN obj = clsQxPrjMenuSetBL.GetObjByMenuSetId(strMenuSetId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrQxPrjMenuSetObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strMenuSetId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetMenuSetNameByMenuSetIdCache(string strMenuSetId)
{
if (string.IsNullOrEmpty(strMenuSetId) == true) return "";
//获取缓存中的对象列表
clsQxPrjMenuSetEN objQxPrjMenuSet = GetObjByMenuSetIdCache(strMenuSetId);
if (objQxPrjMenuSet == null) return "";
return objQxPrjMenuSet.MenuSetName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strMenuSetId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByMenuSetIdCache(string strMenuSetId)
{
if (string.IsNullOrEmpty(strMenuSetId) == true) return "";
//获取缓存中的对象列表
clsQxPrjMenuSetEN objQxPrjMenuSet = GetObjByMenuSetIdCache(strMenuSetId);
if (objQxPrjMenuSet == null) return "";
return objQxPrjMenuSet.MenuSetName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxPrjMenuSetEN> GetAllQxPrjMenuSetObjLstCache()
{
//获取缓存中的对象列表
List<clsQxPrjMenuSetEN> arrQxPrjMenuSetObjLstCache = GetObjLstCache(); 
return arrQxPrjMenuSetObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxPrjMenuSetEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsQxPrjMenuSetEN._CurrTabName);
List<clsQxPrjMenuSetEN> arrQxPrjMenuSetObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrQxPrjMenuSetObjLstCache;
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsQxPrjMenuSetBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsQxPrjMenuSetEN._CurrTabName);
CacheHelper.Remove(strKey);
clsQxPrjMenuSetBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--QxPrjMenuSet(菜单集)
 /// 唯一性条件:MenuSetName_QxPrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQxPrjMenuSetEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsQxPrjMenuSetEN objQxPrjMenuSetEN)
{
//检测记录是否存在
string strResult = QxPrjMenuSetDA.GetUniCondStr(objQxPrjMenuSetEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2024-01-06
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstQxPrjMenuSetObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsQxPrjMenuSetEN> lstQxPrjMenuSetObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstQxPrjMenuSetObjLst, writer);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 序列化一个对象列表到XmlWriter
 /// 作者:pyf
 /// 日期:2024-01-06
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXML)
 /// </summary>
 /// <param name = "lstQxPrjMenuSetObjLst">[clsQxPrjMenuSetEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsQxPrjMenuSetEN> lstQxPrjMenuSetObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsQxPrjMenuSetBL.listXmlNode);
writer.WriteStartElement(clsQxPrjMenuSetBL.itemsXmlNode);
foreach (clsQxPrjMenuSetEN objQxPrjMenuSetEN in lstQxPrjMenuSetObjLst)
{
clsQxPrjMenuSetBL.SerializeXML(writer, objQxPrjMenuSetEN);
}
writer.WriteEndElement();
writer.WriteEndElement();
return true;
}

 /// <summary>
 /// 把一个对象序列化到XML中
 /// 作者:pyf
 /// 日期:2024-01-06
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeXML)
 /// </summary>
 /// <param name = "writer">目标:序列化到的XmlWriter</param>
 /// <param name = "objQxPrjMenuSetEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsQxPrjMenuSetEN objQxPrjMenuSetEN)
{
writer.WriteStartElement(clsQxPrjMenuSetBL.itemXmlNode);
 
if (objQxPrjMenuSetEN.MenuSetId != null)
{
writer.WriteElementString(conQxPrjMenuSet.MenuSetId, objQxPrjMenuSetEN.MenuSetId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjMenuSetEN.MenuSetName != null)
{
writer.WriteElementString(conQxPrjMenuSet.MenuSetName, objQxPrjMenuSetEN.MenuSetName.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjMenuSetEN.MenuSetENName != null)
{
writer.WriteElementString(conQxPrjMenuSet.MenuSetENName, objQxPrjMenuSetEN.MenuSetENName.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjMenuSetEN.QxPrjId != null)
{
writer.WriteElementString(conQxPrjMenuSet.QxPrjId, objQxPrjMenuSetEN.QxPrjId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjMenuSetEN.CmPrjId != null)
{
writer.WriteElementString(conQxPrjMenuSet.CmPrjId, objQxPrjMenuSetEN.CmPrjId.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(conQxPrjMenuSet.IsDefault, objQxPrjMenuSetEN.IsDefault.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objQxPrjMenuSetEN.UpdDate != null)
{
writer.WriteElementString(conQxPrjMenuSet.UpdDate, objQxPrjMenuSetEN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjMenuSetEN.UpdUser != null)
{
writer.WriteElementString(conQxPrjMenuSet.UpdUser, objQxPrjMenuSetEN.UpdUser.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjMenuSetEN.Memo != null)
{
writer.WriteElementString(conQxPrjMenuSet.Memo, objQxPrjMenuSetEN.Memo.ToString(CultureInfo.InvariantCulture));
}
writer.WriteEndElement();
}

 /// <summary>
 /// 读XmlReader到一个对象
 /// 作者:pyf
 /// 日期:2024-01-06
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlReader)
 /// </summary>
 /// <param name = "reader">提供的数据源:XmlReader</param>
 /// <returns>返回的一个对象</returns>
public static clsQxPrjMenuSetEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsQxPrjMenuSetEN objQxPrjMenuSetEN = new clsQxPrjMenuSetEN();
reader.Read();
while (!(reader.Name == clsQxPrjMenuSetBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(conQxPrjMenuSet.MenuSetId))
{
objQxPrjMenuSetEN.MenuSetId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjMenuSet.MenuSetName))
{
objQxPrjMenuSetEN.MenuSetName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjMenuSet.MenuSetENName))
{
objQxPrjMenuSetEN.MenuSetENName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjMenuSet.QxPrjId))
{
objQxPrjMenuSetEN.QxPrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjMenuSet.CmPrjId))
{
objQxPrjMenuSetEN.CmPrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjMenuSet.IsDefault))
{
objQxPrjMenuSetEN.IsDefault = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(conQxPrjMenuSet.UpdDate))
{
objQxPrjMenuSetEN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjMenuSet.UpdUser))
{
objQxPrjMenuSetEN.UpdUser = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjMenuSet.Memo))
{
objQxPrjMenuSetEN.Memo = reader.ReadElementContentAsString();
}
}
return objQxPrjMenuSetEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strQxPrjMenuSetObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsQxPrjMenuSetEN GetObjFromXmlStr(string strQxPrjMenuSetObjXmlStr)
{
clsQxPrjMenuSetEN objQxPrjMenuSetEN = new clsQxPrjMenuSetEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strQxPrjMenuSetObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsQxPrjMenuSetBL.itemXmlNode))
{
objQxPrjMenuSetEN = GetObjFromXml(reader);
return objQxPrjMenuSetEN;
}
}
return objQxPrjMenuSetEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2024-01-06
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objQxPrjMenuSetEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsQxPrjMenuSetEN objQxPrjMenuSetEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objQxPrjMenuSetEN);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2024-01-06
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strMenuSetId)
{
if (strInFldName != conQxPrjMenuSet.MenuSetId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conQxPrjMenuSet.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conQxPrjMenuSet.AttributeName));
throw new Exception(strMsg);
}
var objQxPrjMenuSet = clsQxPrjMenuSetBL.GetObjByMenuSetIdCache(strMenuSetId);
if (objQxPrjMenuSet == null) return "";
return objQxPrjMenuSet[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2024-01-06
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objQxPrjMenuSetEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsQxPrjMenuSetEN objQxPrjMenuSetEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsQxPrjMenuSetEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objQxPrjMenuSetEN[strField]);
}
sbJSON.Remove(sbJSON.Length - 1, 1);
sbJSON.Append("}");
return sbJSON.ToString();
}

 /// <summary>
 /// 序列化一个对象列表到JSON串
 /// 作者:pyf
 /// 日期:2024-01-06
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToJSONStr)
 /// </summary>
 /// <param name = "lstQxPrjMenuSetObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsQxPrjMenuSetEN> lstQxPrjMenuSetObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstQxPrjMenuSetObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsQxPrjMenuSetEN objQxPrjMenuSetEN in lstQxPrjMenuSetObjLst)
{
string strJSON_One = SerializeObjToJSON(objQxPrjMenuSetEN);
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
int intRecCount = clsQxPrjMenuSetDA.GetRecCount(strTabName);
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
int intRecCount = clsQxPrjMenuSetDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsQxPrjMenuSetDA.GetRecCount();
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
int intRecCount = clsQxPrjMenuSetDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objQxPrjMenuSetCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsQxPrjMenuSetEN objQxPrjMenuSetCond)
{
List<clsQxPrjMenuSetEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxPrjMenuSetEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxPrjMenuSet.AttributeName)
{
if (objQxPrjMenuSetCond.IsUpdated(strFldName) == false) continue;
if (objQxPrjMenuSetCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxPrjMenuSetCond[strFldName].ToString());
}
else
{
if (objQxPrjMenuSetCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxPrjMenuSetCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxPrjMenuSetCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxPrjMenuSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxPrjMenuSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxPrjMenuSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxPrjMenuSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxPrjMenuSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxPrjMenuSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxPrjMenuSetCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxPrjMenuSetCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxPrjMenuSetCond[strFldName]));
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
 List<string> arrList = clsQxPrjMenuSetDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = QxPrjMenuSetDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = QxPrjMenuSetDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = QxPrjMenuSetDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxPrjMenuSetDA.SetFldValue(clsQxPrjMenuSetEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = QxPrjMenuSetDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxPrjMenuSetDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxPrjMenuSetDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxPrjMenuSetDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[QxPrjMenuSet] "); 
 strCreateTabCode.Append(" ( "); 
 // /**菜单集Id*/ 
 strCreateTabCode.Append(" MenuSetId char(4) primary key, "); 
 // /**菜单集名称*/ 
 strCreateTabCode.Append(" MenuSetName varchar(50) not Null, "); 
 // /**菜单集英文名*/ 
 strCreateTabCode.Append(" MenuSetENName varchar(50) Null, "); 
 // /**项目Id*/ 
 strCreateTabCode.Append(" QxPrjId char(4) not Null, "); 
 // /**Cm项目Id*/ 
 strCreateTabCode.Append(" CmPrjId char(6) Null, "); 
 // /**是否默认*/ 
 strCreateTabCode.Append(" IsDefault bit not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) not Null, "); 
 // /**修改用户*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
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
 /// 菜单集(QxPrjMenuSet)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4QxPrjMenuSet : clsCommFun4BL
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
clsQxPrjMenuSetBL.ReFreshThisCache();
}
}

}