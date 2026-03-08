
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxPrjMenusBL
 表名:QxPrjMenus(00140004)
 * 版本:2024.08.23.1(服务器:WIN-SRV103-116)
 日期:2024/08/29 09:31:52
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
public static class  clsQxPrjMenusBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strMenuId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxPrjMenusEN GetObj(this K_MenuId_QxPrjMenus myKey)
{
clsQxPrjMenusEN objQxPrjMenusEN = clsQxPrjMenusBL.QxPrjMenusDA.GetObjByMenuId(myKey.Value);
return objQxPrjMenusEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQxPrjMenusEN objQxPrjMenusEN)
{
 if (string.IsNullOrEmpty(objQxPrjMenusEN.MenuId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQxPrjMenusBL.IsExist(objQxPrjMenusEN.MenuId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQxPrjMenusEN.MenuId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (CheckUniqueness(objQxPrjMenusEN) == false)
{
var strMsg = string.Format("记录已经存在!菜单名 = [{0}],项目Id = [{1}]的数据已经存在!(in clsQxPrjMenusBL.AddNewRecord)", objQxPrjMenusEN.MenuName,objQxPrjMenusEN.QxPrjId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsQxPrjMenusBL.QxPrjMenusDA.AddNewRecordBySQL2(objQxPrjMenusEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjMenusBL.ReFreshCache(objQxPrjMenusEN.QxPrjId);

if (clsQxPrjMenusBL.relatedActions != null)
{
clsQxPrjMenusBL.relatedActions.UpdRelaTabDate(objQxPrjMenusEN.MenuId, objQxPrjMenusEN.UpdUserId);
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
public static bool AddRecordEx(this clsQxPrjMenusEN objQxPrjMenusEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsQxPrjMenusBL.IsExist(objQxPrjMenusEN.MenuId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objQxPrjMenusEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objQxPrjMenusEN.CheckUniqueness() == false)
{
strMsg = string.Format("(菜单名(MenuName)=[{0}],项目Id(QxPrjId)=[{1}])已经存在,不能重复!", objQxPrjMenusEN.MenuName, objQxPrjMenusEN.QxPrjId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objQxPrjMenusEN.AddNewRecord();
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
 /// <param name = "objQxPrjMenusEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsQxPrjMenusEN objQxPrjMenusEN)
{
if (CheckUniqueness(objQxPrjMenusEN) == false)
{
var strMsg = string.Format("记录已经存在!菜单名 = [{0}],项目Id = [{1}]的数据已经存在!(in clsQxPrjMenusBL.AddNewRecordWithMaxId)", objQxPrjMenusEN.MenuName,objQxPrjMenusEN.QxPrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQxPrjMenusEN.MenuId) == true || clsQxPrjMenusBL.IsExist(objQxPrjMenusEN.MenuId) == true)
 {
     objQxPrjMenusEN.MenuId = clsQxPrjMenusBL.GetMaxStrIdByPrefix_S(objQxPrjMenusEN.QxPrjId);
 }
string strMenuId = clsQxPrjMenusBL.QxPrjMenusDA.AddNewRecordBySQL2WithReturnKey(objQxPrjMenusEN);
     objQxPrjMenusEN.MenuId = strMenuId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjMenusBL.ReFreshCache(objQxPrjMenusEN.QxPrjId);

if (clsQxPrjMenusBL.relatedActions != null)
{
clsQxPrjMenusBL.relatedActions.UpdRelaTabDate(objQxPrjMenusEN.MenuId, objQxPrjMenusEN.UpdUserId);
}
return strMenuId;
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
 /// <param name = "objQxPrjMenusEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsQxPrjMenusEN objQxPrjMenusEN)
{
 if (string.IsNullOrEmpty(objQxPrjMenusEN.MenuId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQxPrjMenusBL.IsExist(objQxPrjMenusEN.MenuId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQxPrjMenusEN.MenuId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (CheckUniqueness(objQxPrjMenusEN) == false)
{
var strMsg = string.Format("记录已经存在!菜单名 = [{0}],项目Id = [{1}]的数据已经存在!(in clsQxPrjMenusBL.AddNewRecordWithReturnKey)", objQxPrjMenusEN.MenuName,objQxPrjMenusEN.QxPrjId);
throw new Exception(strMsg);
}
try
{
string strKey = clsQxPrjMenusBL.QxPrjMenusDA.AddNewRecordBySQL2WithReturnKey(objQxPrjMenusEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjMenusBL.ReFreshCache(objQxPrjMenusEN.QxPrjId);

if (clsQxPrjMenusBL.relatedActions != null)
{
clsQxPrjMenusBL.relatedActions.UpdRelaTabDate(objQxPrjMenusEN.MenuId, objQxPrjMenusEN.UpdUserId);
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
 /// <param name = "objQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusEN SetMenuId(this clsQxPrjMenusEN objQxPrjMenusEN, string strMenuId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuId, 8, conQxPrjMenus.MenuId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMenuId, 8, conQxPrjMenus.MenuId);
}
objQxPrjMenusEN.MenuId = strMenuId; //菜单Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusEN.dicFldComparisonOp.ContainsKey(conQxPrjMenus.MenuId) == false)
{
objQxPrjMenusEN.dicFldComparisonOp.Add(conQxPrjMenus.MenuId, strComparisonOp);
}
else
{
objQxPrjMenusEN.dicFldComparisonOp[conQxPrjMenus.MenuId] = strComparisonOp;
}
}
return objQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusEN SetMenuName(this clsQxPrjMenusEN objQxPrjMenusEN, string strMenuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMenuName, conQxPrjMenus.MenuName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuName, 50, conQxPrjMenus.MenuName);
}
objQxPrjMenusEN.MenuName = strMenuName; //菜单名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusEN.dicFldComparisonOp.ContainsKey(conQxPrjMenus.MenuName) == false)
{
objQxPrjMenusEN.dicFldComparisonOp.Add(conQxPrjMenus.MenuName, strComparisonOp);
}
else
{
objQxPrjMenusEN.dicFldComparisonOp[conQxPrjMenus.MenuName] = strComparisonOp;
}
}
return objQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusEN SetQxPrjId(this clsQxPrjMenusEN objQxPrjMenusEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, conQxPrjMenus.QxPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQxPrjId, 4, conQxPrjMenus.QxPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, conQxPrjMenus.QxPrjId);
}
objQxPrjMenusEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusEN.dicFldComparisonOp.ContainsKey(conQxPrjMenus.QxPrjId) == false)
{
objQxPrjMenusEN.dicFldComparisonOp.Add(conQxPrjMenus.QxPrjId, strComparisonOp);
}
else
{
objQxPrjMenusEN.dicFldComparisonOp[conQxPrjMenus.QxPrjId] = strComparisonOp;
}
}
return objQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusEN SetUpMenuId(this clsQxPrjMenusEN objQxPrjMenusEN, string strUpMenuId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpMenuId, conQxPrjMenus.UpMenuId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpMenuId, 8, conQxPrjMenus.UpMenuId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUpMenuId, 8, conQxPrjMenus.UpMenuId);
}
objQxPrjMenusEN.UpMenuId = strUpMenuId; //上级菜单Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusEN.dicFldComparisonOp.ContainsKey(conQxPrjMenus.UpMenuId) == false)
{
objQxPrjMenusEN.dicFldComparisonOp.Add(conQxPrjMenus.UpMenuId, strComparisonOp);
}
else
{
objQxPrjMenusEN.dicFldComparisonOp[conQxPrjMenus.UpMenuId] = strComparisonOp;
}
}
return objQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusEN SetLinkFile(this clsQxPrjMenusEN objQxPrjMenusEN, string strLinkFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLinkFile, 500, conQxPrjMenus.LinkFile);
}
objQxPrjMenusEN.LinkFile = strLinkFile; //链接文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusEN.dicFldComparisonOp.ContainsKey(conQxPrjMenus.LinkFile) == false)
{
objQxPrjMenusEN.dicFldComparisonOp.Add(conQxPrjMenus.LinkFile, strComparisonOp);
}
else
{
objQxPrjMenusEN.dicFldComparisonOp[conQxPrjMenus.LinkFile] = strComparisonOp;
}
}
return objQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusEN SetqsParameters(this clsQxPrjMenusEN objQxPrjMenusEN, string strqsParameters, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strqsParameters, 200, conQxPrjMenus.qsParameters);
}
objQxPrjMenusEN.qsParameters = strqsParameters; //qs参数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusEN.dicFldComparisonOp.ContainsKey(conQxPrjMenus.qsParameters) == false)
{
objQxPrjMenusEN.dicFldComparisonOp.Add(conQxPrjMenus.qsParameters, strComparisonOp);
}
else
{
objQxPrjMenusEN.dicFldComparisonOp[conQxPrjMenus.qsParameters] = strComparisonOp;
}
}
return objQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusEN SetTabId(this clsQxPrjMenusEN objQxPrjMenusEN, string strTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, conQxPrjMenus.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, conQxPrjMenus.TabId);
}
objQxPrjMenusEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusEN.dicFldComparisonOp.ContainsKey(conQxPrjMenus.TabId) == false)
{
objQxPrjMenusEN.dicFldComparisonOp.Add(conQxPrjMenus.TabId, strComparisonOp);
}
else
{
objQxPrjMenusEN.dicFldComparisonOp[conQxPrjMenus.TabId] = strComparisonOp;
}
}
return objQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusEN SetImgFile(this clsQxPrjMenusEN objQxPrjMenusEN, string strImgFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strImgFile, 300, conQxPrjMenus.ImgFile);
}
objQxPrjMenusEN.ImgFile = strImgFile; //图像文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusEN.dicFldComparisonOp.ContainsKey(conQxPrjMenus.ImgFile) == false)
{
objQxPrjMenusEN.dicFldComparisonOp.Add(conQxPrjMenus.ImgFile, strComparisonOp);
}
else
{
objQxPrjMenusEN.dicFldComparisonOp[conQxPrjMenus.ImgFile] = strComparisonOp;
}
}
return objQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusEN SetRoleId(this clsQxPrjMenusEN objQxPrjMenusEN, string strRoleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRoleId, 8, conQxPrjMenus.RoleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, conQxPrjMenus.RoleId);
}
objQxPrjMenusEN.RoleId = strRoleId; //角色Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusEN.dicFldComparisonOp.ContainsKey(conQxPrjMenus.RoleId) == false)
{
objQxPrjMenusEN.dicFldComparisonOp.Add(conQxPrjMenus.RoleId, strComparisonOp);
}
else
{
objQxPrjMenusEN.dicFldComparisonOp[conQxPrjMenus.RoleId] = strComparisonOp;
}
}
return objQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusEN SetOrderNum(this clsQxPrjMenusEN objQxPrjMenusEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, conQxPrjMenus.OrderNum);
objQxPrjMenusEN.OrderNum = intOrderNum; //排序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusEN.dicFldComparisonOp.ContainsKey(conQxPrjMenus.OrderNum) == false)
{
objQxPrjMenusEN.dicFldComparisonOp.Add(conQxPrjMenus.OrderNum, strComparisonOp);
}
else
{
objQxPrjMenusEN.dicFldComparisonOp[conQxPrjMenus.OrderNum] = strComparisonOp;
}
}
return objQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusEN SetIsLeafNode(this clsQxPrjMenusEN objQxPrjMenusEN, bool bolIsLeafNode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsLeafNode, conQxPrjMenus.IsLeafNode);
objQxPrjMenusEN.IsLeafNode = bolIsLeafNode; //是否叶子
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusEN.dicFldComparisonOp.ContainsKey(conQxPrjMenus.IsLeafNode) == false)
{
objQxPrjMenusEN.dicFldComparisonOp.Add(conQxPrjMenus.IsLeafNode, strComparisonOp);
}
else
{
objQxPrjMenusEN.dicFldComparisonOp[conQxPrjMenus.IsLeafNode] = strComparisonOp;
}
}
return objQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusEN SetMenuTitle(this clsQxPrjMenusEN objQxPrjMenusEN, string strMenuTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuTitle, 50, conQxPrjMenus.MenuTitle);
}
objQxPrjMenusEN.MenuTitle = strMenuTitle; //菜单标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusEN.dicFldComparisonOp.ContainsKey(conQxPrjMenus.MenuTitle) == false)
{
objQxPrjMenusEN.dicFldComparisonOp.Add(conQxPrjMenus.MenuTitle, strComparisonOp);
}
else
{
objQxPrjMenusEN.dicFldComparisonOp[conQxPrjMenus.MenuTitle] = strComparisonOp;
}
}
return objQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusEN SetPageDispModeId(this clsQxPrjMenusEN objQxPrjMenusEN, string strPageDispModeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPageDispModeId, 2, conQxPrjMenus.PageDispModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPageDispModeId, 2, conQxPrjMenus.PageDispModeId);
}
objQxPrjMenusEN.PageDispModeId = strPageDispModeId; //页面显示模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusEN.dicFldComparisonOp.ContainsKey(conQxPrjMenus.PageDispModeId) == false)
{
objQxPrjMenusEN.dicFldComparisonOp.Add(conQxPrjMenus.PageDispModeId, strComparisonOp);
}
else
{
objQxPrjMenusEN.dicFldComparisonOp[conQxPrjMenus.PageDispModeId] = strComparisonOp;
}
}
return objQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusEN SetInUse(this clsQxPrjMenusEN objQxPrjMenusEN, bool bolInUse, string strComparisonOp="")
	{
objQxPrjMenusEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusEN.dicFldComparisonOp.ContainsKey(conQxPrjMenus.InUse) == false)
{
objQxPrjMenusEN.dicFldComparisonOp.Add(conQxPrjMenus.InUse, strComparisonOp);
}
else
{
objQxPrjMenusEN.dicFldComparisonOp[conQxPrjMenus.InUse] = strComparisonOp;
}
}
return objQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusEN SetMenuControlName(this clsQxPrjMenusEN objQxPrjMenusEN, string strMenuControlName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuControlName, 100, conQxPrjMenus.MenuControlName);
}
objQxPrjMenusEN.MenuControlName = strMenuControlName; //菜单控件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusEN.dicFldComparisonOp.ContainsKey(conQxPrjMenus.MenuControlName) == false)
{
objQxPrjMenusEN.dicFldComparisonOp.Add(conQxPrjMenus.MenuControlName, strComparisonOp);
}
else
{
objQxPrjMenusEN.dicFldComparisonOp[conQxPrjMenus.MenuControlName] = strComparisonOp;
}
}
return objQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusEN SetApplicationTypeId(this clsQxPrjMenusEN objQxPrjMenusEN, int intApplicationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intApplicationTypeId, conQxPrjMenus.ApplicationTypeId);
objQxPrjMenusEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusEN.dicFldComparisonOp.ContainsKey(conQxPrjMenus.ApplicationTypeId) == false)
{
objQxPrjMenusEN.dicFldComparisonOp.Add(conQxPrjMenus.ApplicationTypeId, strComparisonOp);
}
else
{
objQxPrjMenusEN.dicFldComparisonOp[conQxPrjMenus.ApplicationTypeId] = strComparisonOp;
}
}
return objQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusEN SetUpdDate(this clsQxPrjMenusEN objQxPrjMenusEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQxPrjMenus.UpdDate);
}
objQxPrjMenusEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusEN.dicFldComparisonOp.ContainsKey(conQxPrjMenus.UpdDate) == false)
{
objQxPrjMenusEN.dicFldComparisonOp.Add(conQxPrjMenus.UpdDate, strComparisonOp);
}
else
{
objQxPrjMenusEN.dicFldComparisonOp[conQxPrjMenus.UpdDate] = strComparisonOp;
}
}
return objQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusEN SetUpdUserId(this clsQxPrjMenusEN objQxPrjMenusEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conQxPrjMenus.UpdUserId);
}
objQxPrjMenusEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusEN.dicFldComparisonOp.ContainsKey(conQxPrjMenus.UpdUserId) == false)
{
objQxPrjMenusEN.dicFldComparisonOp.Add(conQxPrjMenus.UpdUserId, strComparisonOp);
}
else
{
objQxPrjMenusEN.dicFldComparisonOp[conQxPrjMenus.UpdUserId] = strComparisonOp;
}
}
return objQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusEN SetMemo(this clsQxPrjMenusEN objQxPrjMenusEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQxPrjMenus.Memo);
}
objQxPrjMenusEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusEN.dicFldComparisonOp.ContainsKey(conQxPrjMenus.Memo) == false)
{
objQxPrjMenusEN.dicFldComparisonOp.Add(conQxPrjMenus.Memo, strComparisonOp);
}
else
{
objQxPrjMenusEN.dicFldComparisonOp[conQxPrjMenus.Memo] = strComparisonOp;
}
}
return objQxPrjMenusEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsQxPrjMenusEN objQxPrjMenusEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objQxPrjMenusEN.CheckPropertyNew();
clsQxPrjMenusEN objQxPrjMenusCond = new clsQxPrjMenusEN();
string strCondition = objQxPrjMenusCond
.SetMenuId(objQxPrjMenusEN.MenuId, "<>")
.SetMenuName(objQxPrjMenusEN.MenuName, "=")
.SetQxPrjId(objQxPrjMenusEN.QxPrjId, "=")
.GetCombineCondition();
objQxPrjMenusEN._IsCheckProperty = true;
bool bolIsExist = clsQxPrjMenusBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(MenuName_QxPrjId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objQxPrjMenusEN.Update();
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
 /// <param name = "objQxPrjMenus">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsQxPrjMenusEN objQxPrjMenus)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsQxPrjMenusEN objQxPrjMenusCond = new clsQxPrjMenusEN();
string strCondition = objQxPrjMenusCond
.SetMenuName(objQxPrjMenus.MenuName, "=")
.SetQxPrjId(objQxPrjMenus.QxPrjId, "=")
.GetCombineCondition();
objQxPrjMenus._IsCheckProperty = true;
bool bolIsExist = clsQxPrjMenusBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objQxPrjMenus.MenuId = clsQxPrjMenusBL.GetFirstID_S(strCondition);
objQxPrjMenus.UpdateWithCondition(strCondition);
}
else
{
objQxPrjMenus.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxPrjMenusEN objQxPrjMenusEN)
{
 if (string.IsNullOrEmpty(objQxPrjMenusEN.MenuId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxPrjMenusBL.QxPrjMenusDA.UpdateBySql2(objQxPrjMenusEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjMenusBL.ReFreshCache(objQxPrjMenusEN.QxPrjId);

if (clsQxPrjMenusBL.relatedActions != null)
{
clsQxPrjMenusBL.relatedActions.UpdRelaTabDate(objQxPrjMenusEN.MenuId, objQxPrjMenusEN.UpdUserId);
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
 /// <param name = "objQxPrjMenusEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxPrjMenusEN objQxPrjMenusEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objQxPrjMenusEN.MenuId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxPrjMenusBL.QxPrjMenusDA.UpdateBySql2(objQxPrjMenusEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjMenusBL.ReFreshCache(objQxPrjMenusEN.QxPrjId);

if (clsQxPrjMenusBL.relatedActions != null)
{
clsQxPrjMenusBL.relatedActions.UpdRelaTabDate(objQxPrjMenusEN.MenuId, objQxPrjMenusEN.UpdUserId);
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
 /// <param name = "objQxPrjMenusEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxPrjMenusEN objQxPrjMenusEN, string strWhereCond)
{
try
{
bool bolResult = clsQxPrjMenusBL.QxPrjMenusDA.UpdateBySqlWithCondition(objQxPrjMenusEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjMenusBL.ReFreshCache(objQxPrjMenusEN.QxPrjId);

if (clsQxPrjMenusBL.relatedActions != null)
{
clsQxPrjMenusBL.relatedActions.UpdRelaTabDate(objQxPrjMenusEN.MenuId, objQxPrjMenusEN.UpdUserId);
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
 /// <param name = "objQxPrjMenusEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxPrjMenusEN objQxPrjMenusEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsQxPrjMenusBL.QxPrjMenusDA.UpdateBySqlWithConditionTransaction(objQxPrjMenusEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjMenusBL.ReFreshCache(objQxPrjMenusEN.QxPrjId);

if (clsQxPrjMenusBL.relatedActions != null)
{
clsQxPrjMenusBL.relatedActions.UpdRelaTabDate(objQxPrjMenusEN.MenuId, objQxPrjMenusEN.UpdUserId);
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
 /// <param name = "strMenuId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsQxPrjMenusEN objQxPrjMenusEN)
{
try
{
int intRecNum = clsQxPrjMenusBL.QxPrjMenusDA.DelRecord(objQxPrjMenusEN.MenuId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjMenusBL.ReFreshCache(objQxPrjMenusEN.QxPrjId);

if (clsQxPrjMenusBL.relatedActions != null)
{
clsQxPrjMenusBL.relatedActions.UpdRelaTabDate(objQxPrjMenusEN.MenuId, objQxPrjMenusEN.UpdUserId);
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
 /// <param name = "objQxPrjMenusENS">源对象</param>
 /// <param name = "objQxPrjMenusENT">目标对象</param>
 public static void CopyTo(this clsQxPrjMenusEN objQxPrjMenusENS, clsQxPrjMenusEN objQxPrjMenusENT)
{
try
{
objQxPrjMenusENT.MenuId = objQxPrjMenusENS.MenuId; //菜单Id
objQxPrjMenusENT.MenuName = objQxPrjMenusENS.MenuName; //菜单名
objQxPrjMenusENT.QxPrjId = objQxPrjMenusENS.QxPrjId; //项目Id
objQxPrjMenusENT.UpMenuId = objQxPrjMenusENS.UpMenuId; //上级菜单Id
objQxPrjMenusENT.LinkFile = objQxPrjMenusENS.LinkFile; //链接文件
objQxPrjMenusENT.qsParameters = objQxPrjMenusENS.qsParameters; //qs参数
objQxPrjMenusENT.TabId = objQxPrjMenusENS.TabId; //表ID
objQxPrjMenusENT.ImgFile = objQxPrjMenusENS.ImgFile; //图像文件
objQxPrjMenusENT.RoleId = objQxPrjMenusENS.RoleId; //角色Id
objQxPrjMenusENT.OrderNum = objQxPrjMenusENS.OrderNum; //排序号
objQxPrjMenusENT.IsLeafNode = objQxPrjMenusENS.IsLeafNode; //是否叶子
objQxPrjMenusENT.MenuTitle = objQxPrjMenusENS.MenuTitle; //菜单标题
objQxPrjMenusENT.PageDispModeId = objQxPrjMenusENS.PageDispModeId; //页面显示模式Id
objQxPrjMenusENT.InUse = objQxPrjMenusENS.InUse; //是否在用
objQxPrjMenusENT.MenuControlName = objQxPrjMenusENS.MenuControlName; //菜单控件名
objQxPrjMenusENT.ApplicationTypeId = objQxPrjMenusENS.ApplicationTypeId; //应用程序类型Id
objQxPrjMenusENT.UpdDate = objQxPrjMenusENS.UpdDate; //修改日期
objQxPrjMenusENT.UpdUserId = objQxPrjMenusENS.UpdUserId; //修改用户Id
objQxPrjMenusENT.Memo = objQxPrjMenusENS.Memo; //备注
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
 /// <param name = "objQxPrjMenusENS">源对象</param>
 /// <returns>目标对象=>clsQxPrjMenusEN:objQxPrjMenusENT</returns>
 public static clsQxPrjMenusEN CopyTo(this clsQxPrjMenusEN objQxPrjMenusENS)
{
try
{
 clsQxPrjMenusEN objQxPrjMenusENT = new clsQxPrjMenusEN()
{
MenuId = objQxPrjMenusENS.MenuId, //菜单Id
MenuName = objQxPrjMenusENS.MenuName, //菜单名
QxPrjId = objQxPrjMenusENS.QxPrjId, //项目Id
UpMenuId = objQxPrjMenusENS.UpMenuId, //上级菜单Id
LinkFile = objQxPrjMenusENS.LinkFile, //链接文件
qsParameters = objQxPrjMenusENS.qsParameters, //qs参数
TabId = objQxPrjMenusENS.TabId, //表ID
ImgFile = objQxPrjMenusENS.ImgFile, //图像文件
RoleId = objQxPrjMenusENS.RoleId, //角色Id
OrderNum = objQxPrjMenusENS.OrderNum, //排序号
IsLeafNode = objQxPrjMenusENS.IsLeafNode, //是否叶子
MenuTitle = objQxPrjMenusENS.MenuTitle, //菜单标题
PageDispModeId = objQxPrjMenusENS.PageDispModeId, //页面显示模式Id
InUse = objQxPrjMenusENS.InUse, //是否在用
MenuControlName = objQxPrjMenusENS.MenuControlName, //菜单控件名
ApplicationTypeId = objQxPrjMenusENS.ApplicationTypeId, //应用程序类型Id
UpdDate = objQxPrjMenusENS.UpdDate, //修改日期
UpdUserId = objQxPrjMenusENS.UpdUserId, //修改用户Id
Memo = objQxPrjMenusENS.Memo, //备注
};
 return objQxPrjMenusENT;
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
public static void CheckPropertyNew(this clsQxPrjMenusEN objQxPrjMenusEN)
{
 clsQxPrjMenusBL.QxPrjMenusDA.CheckPropertyNew(objQxPrjMenusEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsQxPrjMenusEN objQxPrjMenusEN)
{
 clsQxPrjMenusBL.QxPrjMenusDA.CheckProperty4Condition(objQxPrjMenusEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQxPrjMenusEN objQxPrjMenusCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQxPrjMenusCond.IsUpdated(conQxPrjMenus.MenuId) == true)
{
string strComparisonOpMenuId = objQxPrjMenusCond.dicFldComparisonOp[conQxPrjMenus.MenuId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenus.MenuId, objQxPrjMenusCond.MenuId, strComparisonOpMenuId);
}
if (objQxPrjMenusCond.IsUpdated(conQxPrjMenus.MenuName) == true)
{
string strComparisonOpMenuName = objQxPrjMenusCond.dicFldComparisonOp[conQxPrjMenus.MenuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenus.MenuName, objQxPrjMenusCond.MenuName, strComparisonOpMenuName);
}
if (objQxPrjMenusCond.IsUpdated(conQxPrjMenus.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objQxPrjMenusCond.dicFldComparisonOp[conQxPrjMenus.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenus.QxPrjId, objQxPrjMenusCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objQxPrjMenusCond.IsUpdated(conQxPrjMenus.UpMenuId) == true)
{
string strComparisonOpUpMenuId = objQxPrjMenusCond.dicFldComparisonOp[conQxPrjMenus.UpMenuId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenus.UpMenuId, objQxPrjMenusCond.UpMenuId, strComparisonOpUpMenuId);
}
if (objQxPrjMenusCond.IsUpdated(conQxPrjMenus.LinkFile) == true)
{
string strComparisonOpLinkFile = objQxPrjMenusCond.dicFldComparisonOp[conQxPrjMenus.LinkFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenus.LinkFile, objQxPrjMenusCond.LinkFile, strComparisonOpLinkFile);
}
if (objQxPrjMenusCond.IsUpdated(conQxPrjMenus.qsParameters) == true)
{
string strComparisonOpqsParameters = objQxPrjMenusCond.dicFldComparisonOp[conQxPrjMenus.qsParameters];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenus.qsParameters, objQxPrjMenusCond.qsParameters, strComparisonOpqsParameters);
}
if (objQxPrjMenusCond.IsUpdated(conQxPrjMenus.TabId) == true)
{
string strComparisonOpTabId = objQxPrjMenusCond.dicFldComparisonOp[conQxPrjMenus.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenus.TabId, objQxPrjMenusCond.TabId, strComparisonOpTabId);
}
if (objQxPrjMenusCond.IsUpdated(conQxPrjMenus.ImgFile) == true)
{
string strComparisonOpImgFile = objQxPrjMenusCond.dicFldComparisonOp[conQxPrjMenus.ImgFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenus.ImgFile, objQxPrjMenusCond.ImgFile, strComparisonOpImgFile);
}
if (objQxPrjMenusCond.IsUpdated(conQxPrjMenus.RoleId) == true)
{
string strComparisonOpRoleId = objQxPrjMenusCond.dicFldComparisonOp[conQxPrjMenus.RoleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenus.RoleId, objQxPrjMenusCond.RoleId, strComparisonOpRoleId);
}
if (objQxPrjMenusCond.IsUpdated(conQxPrjMenus.OrderNum) == true)
{
string strComparisonOpOrderNum = objQxPrjMenusCond.dicFldComparisonOp[conQxPrjMenus.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conQxPrjMenus.OrderNum, objQxPrjMenusCond.OrderNum, strComparisonOpOrderNum);
}
if (objQxPrjMenusCond.IsUpdated(conQxPrjMenus.IsLeafNode) == true)
{
if (objQxPrjMenusCond.IsLeafNode == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQxPrjMenus.IsLeafNode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQxPrjMenus.IsLeafNode);
}
}
if (objQxPrjMenusCond.IsUpdated(conQxPrjMenus.MenuTitle) == true)
{
string strComparisonOpMenuTitle = objQxPrjMenusCond.dicFldComparisonOp[conQxPrjMenus.MenuTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenus.MenuTitle, objQxPrjMenusCond.MenuTitle, strComparisonOpMenuTitle);
}
if (objQxPrjMenusCond.IsUpdated(conQxPrjMenus.PageDispModeId) == true)
{
string strComparisonOpPageDispModeId = objQxPrjMenusCond.dicFldComparisonOp[conQxPrjMenus.PageDispModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenus.PageDispModeId, objQxPrjMenusCond.PageDispModeId, strComparisonOpPageDispModeId);
}
if (objQxPrjMenusCond.IsUpdated(conQxPrjMenus.InUse) == true)
{
if (objQxPrjMenusCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQxPrjMenus.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQxPrjMenus.InUse);
}
}
if (objQxPrjMenusCond.IsUpdated(conQxPrjMenus.MenuControlName) == true)
{
string strComparisonOpMenuControlName = objQxPrjMenusCond.dicFldComparisonOp[conQxPrjMenus.MenuControlName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenus.MenuControlName, objQxPrjMenusCond.MenuControlName, strComparisonOpMenuControlName);
}
if (objQxPrjMenusCond.IsUpdated(conQxPrjMenus.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objQxPrjMenusCond.dicFldComparisonOp[conQxPrjMenus.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", conQxPrjMenus.ApplicationTypeId, objQxPrjMenusCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objQxPrjMenusCond.IsUpdated(conQxPrjMenus.UpdDate) == true)
{
string strComparisonOpUpdDate = objQxPrjMenusCond.dicFldComparisonOp[conQxPrjMenus.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenus.UpdDate, objQxPrjMenusCond.UpdDate, strComparisonOpUpdDate);
}
if (objQxPrjMenusCond.IsUpdated(conQxPrjMenus.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objQxPrjMenusCond.dicFldComparisonOp[conQxPrjMenus.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenus.UpdUserId, objQxPrjMenusCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objQxPrjMenusCond.IsUpdated(conQxPrjMenus.Memo) == true)
{
string strComparisonOpMemo = objQxPrjMenusCond.dicFldComparisonOp[conQxPrjMenus.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenus.Memo, objQxPrjMenusCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--QxPrjMenus(工程菜单), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:MenuName_QxPrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsQxPrjMenusEN objQxPrjMenusEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objQxPrjMenusEN == null) return true;
if (objQxPrjMenusEN.MenuId == null || objQxPrjMenusEN.MenuId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and MenuName = '{0}'", objQxPrjMenusEN.MenuName);
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxPrjMenusEN.QxPrjId);
if (clsQxPrjMenusBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("MenuId !=  '{0}'", objQxPrjMenusEN.MenuId);
 sbCondition.AppendFormat(" and MenuName = '{0}'", objQxPrjMenusEN.MenuName);
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxPrjMenusEN.QxPrjId);
if (clsQxPrjMenusBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--QxPrjMenus(工程菜单), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:MenuName_QxPrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsQxPrjMenusEN objQxPrjMenusEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objQxPrjMenusEN == null) return "";
if (objQxPrjMenusEN.MenuId == null || objQxPrjMenusEN.MenuId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and MenuName = '{0}'", objQxPrjMenusEN.MenuName);
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxPrjMenusEN.QxPrjId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("MenuId !=  '{0}'", objQxPrjMenusEN.MenuId);
 sbCondition.AppendFormat(" and MenuName = '{0}'", objQxPrjMenusEN.MenuName);
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxPrjMenusEN.QxPrjId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_QxPrjMenus
{
public virtual bool UpdRelaTabDate(string strMenuId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 工程菜单(QxPrjMenus)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsQxPrjMenusBL
{
public static RelatedActions_QxPrjMenus relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "QxPrjMenusListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "QxPrjMenusList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsQxPrjMenusEN> arrQxPrjMenusObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsQxPrjMenusDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsQxPrjMenusDA QxPrjMenusDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsQxPrjMenusDA();
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
 public clsQxPrjMenusBL()
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
if (string.IsNullOrEmpty(clsQxPrjMenusEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxPrjMenusEN._ConnectString);
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
objDS = QxPrjMenusDA.GetDataSet(strWhereCond);
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
objDS = QxPrjMenusDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = QxPrjMenusDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_QxPrjMenus(string strWhereCond)
{
DataTable objDT;
try
{
objDT = QxPrjMenusDA.GetDataTable_QxPrjMenus(strWhereCond);
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
objDT = QxPrjMenusDA.GetDataTable(strWhereCond);
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
objDT = QxPrjMenusDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = QxPrjMenusDA.GetDataTable(strWhereCond, strTabName);
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
objDT = QxPrjMenusDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = QxPrjMenusDA.GetDataTable_Top(objTopPara);
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
objDT = QxPrjMenusDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = QxPrjMenusDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = QxPrjMenusDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = QxPrjMenusDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = QxPrjMenusDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = QxPrjMenusDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = QxPrjMenusDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = QxPrjMenusDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
 /// <param name = "arrMenuIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsQxPrjMenusEN> GetObjLstByMenuIdLst(List<string> arrMenuIdLst)
{
List<clsQxPrjMenusEN> arrObjLst = new List<clsQxPrjMenusEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMenuIdLst, true);
 string strWhereCond = string.Format("MenuId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjMenusEN objQxPrjMenusEN = new clsQxPrjMenusEN();
try
{
objQxPrjMenusEN.MenuId = objRow[conQxPrjMenus.MenuId].ToString().Trim(); //菜单Id
objQxPrjMenusEN.MenuName = objRow[conQxPrjMenus.MenuName].ToString().Trim(); //菜单名
objQxPrjMenusEN.QxPrjId = objRow[conQxPrjMenus.QxPrjId].ToString().Trim(); //项目Id
objQxPrjMenusEN.UpMenuId = objRow[conQxPrjMenus.UpMenuId].ToString().Trim(); //上级菜单Id
objQxPrjMenusEN.LinkFile = objRow[conQxPrjMenus.LinkFile] == DBNull.Value ? null : objRow[conQxPrjMenus.LinkFile].ToString().Trim(); //链接文件
objQxPrjMenusEN.qsParameters = objRow[conQxPrjMenus.qsParameters] == DBNull.Value ? null : objRow[conQxPrjMenus.qsParameters].ToString().Trim(); //qs参数
objQxPrjMenusEN.TabId = objRow[conQxPrjMenus.TabId] == DBNull.Value ? null : objRow[conQxPrjMenus.TabId].ToString().Trim(); //表ID
objQxPrjMenusEN.ImgFile = objRow[conQxPrjMenus.ImgFile] == DBNull.Value ? null : objRow[conQxPrjMenus.ImgFile].ToString().Trim(); //图像文件
objQxPrjMenusEN.RoleId = objRow[conQxPrjMenus.RoleId] == DBNull.Value ? null : objRow[conQxPrjMenus.RoleId].ToString().Trim(); //角色Id
objQxPrjMenusEN.OrderNum = Int32.Parse(objRow[conQxPrjMenus.OrderNum].ToString().Trim()); //排序号
objQxPrjMenusEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenus.IsLeafNode].ToString().Trim()); //是否叶子
objQxPrjMenusEN.MenuTitle = objRow[conQxPrjMenus.MenuTitle] == DBNull.Value ? null : objRow[conQxPrjMenus.MenuTitle].ToString().Trim(); //菜单标题
objQxPrjMenusEN.PageDispModeId = objRow[conQxPrjMenus.PageDispModeId] == DBNull.Value ? null : objRow[conQxPrjMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id
objQxPrjMenusEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenus.InUse].ToString().Trim()); //是否在用
objQxPrjMenusEN.MenuControlName = objRow[conQxPrjMenus.MenuControlName] == DBNull.Value ? null : objRow[conQxPrjMenus.MenuControlName].ToString().Trim(); //菜单控件名
objQxPrjMenusEN.ApplicationTypeId = Int32.Parse(objRow[conQxPrjMenus.ApplicationTypeId].ToString().Trim()); //应用程序类型Id
objQxPrjMenusEN.UpdDate = objRow[conQxPrjMenus.UpdDate] == DBNull.Value ? null : objRow[conQxPrjMenus.UpdDate].ToString().Trim(); //修改日期
objQxPrjMenusEN.UpdUserId = objRow[conQxPrjMenus.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjMenus.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjMenusEN.Memo = objRow[conQxPrjMenus.Memo] == DBNull.Value ? null : objRow[conQxPrjMenus.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjMenusEN.MenuId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjMenusEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMenuIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsQxPrjMenusEN> GetObjLstByMenuIdLstCache(List<string> arrMenuIdLst, string strQxPrjId)
{
string strKey = string.Format("{0}_{1}", clsQxPrjMenusEN._CurrTabName, strQxPrjId);
List<clsQxPrjMenusEN> arrQxPrjMenusObjLstCache = GetObjLstCache(strQxPrjId);
IEnumerable <clsQxPrjMenusEN> arrQxPrjMenusObjLst_Sel =
arrQxPrjMenusObjLstCache
.Where(x => arrMenuIdLst.Contains(x.MenuId));
return arrQxPrjMenusObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPrjMenusEN> GetObjLst(string strWhereCond)
{
List<clsQxPrjMenusEN> arrObjLst = new List<clsQxPrjMenusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjMenusEN objQxPrjMenusEN = new clsQxPrjMenusEN();
try
{
objQxPrjMenusEN.MenuId = objRow[conQxPrjMenus.MenuId].ToString().Trim(); //菜单Id
objQxPrjMenusEN.MenuName = objRow[conQxPrjMenus.MenuName].ToString().Trim(); //菜单名
objQxPrjMenusEN.QxPrjId = objRow[conQxPrjMenus.QxPrjId].ToString().Trim(); //项目Id
objQxPrjMenusEN.UpMenuId = objRow[conQxPrjMenus.UpMenuId].ToString().Trim(); //上级菜单Id
objQxPrjMenusEN.LinkFile = objRow[conQxPrjMenus.LinkFile] == DBNull.Value ? null : objRow[conQxPrjMenus.LinkFile].ToString().Trim(); //链接文件
objQxPrjMenusEN.qsParameters = objRow[conQxPrjMenus.qsParameters] == DBNull.Value ? null : objRow[conQxPrjMenus.qsParameters].ToString().Trim(); //qs参数
objQxPrjMenusEN.TabId = objRow[conQxPrjMenus.TabId] == DBNull.Value ? null : objRow[conQxPrjMenus.TabId].ToString().Trim(); //表ID
objQxPrjMenusEN.ImgFile = objRow[conQxPrjMenus.ImgFile] == DBNull.Value ? null : objRow[conQxPrjMenus.ImgFile].ToString().Trim(); //图像文件
objQxPrjMenusEN.RoleId = objRow[conQxPrjMenus.RoleId] == DBNull.Value ? null : objRow[conQxPrjMenus.RoleId].ToString().Trim(); //角色Id
objQxPrjMenusEN.OrderNum = Int32.Parse(objRow[conQxPrjMenus.OrderNum].ToString().Trim()); //排序号
objQxPrjMenusEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenus.IsLeafNode].ToString().Trim()); //是否叶子
objQxPrjMenusEN.MenuTitle = objRow[conQxPrjMenus.MenuTitle] == DBNull.Value ? null : objRow[conQxPrjMenus.MenuTitle].ToString().Trim(); //菜单标题
objQxPrjMenusEN.PageDispModeId = objRow[conQxPrjMenus.PageDispModeId] == DBNull.Value ? null : objRow[conQxPrjMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id
objQxPrjMenusEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenus.InUse].ToString().Trim()); //是否在用
objQxPrjMenusEN.MenuControlName = objRow[conQxPrjMenus.MenuControlName] == DBNull.Value ? null : objRow[conQxPrjMenus.MenuControlName].ToString().Trim(); //菜单控件名
objQxPrjMenusEN.ApplicationTypeId = Int32.Parse(objRow[conQxPrjMenus.ApplicationTypeId].ToString().Trim()); //应用程序类型Id
objQxPrjMenusEN.UpdDate = objRow[conQxPrjMenus.UpdDate] == DBNull.Value ? null : objRow[conQxPrjMenus.UpdDate].ToString().Trim(); //修改日期
objQxPrjMenusEN.UpdUserId = objRow[conQxPrjMenus.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjMenus.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjMenusEN.Memo = objRow[conQxPrjMenus.Memo] == DBNull.Value ? null : objRow[conQxPrjMenus.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjMenusEN.MenuId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjMenusEN);
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
public static List<clsQxPrjMenusEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsQxPrjMenusEN> arrObjLst = new List<clsQxPrjMenusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjMenusEN objQxPrjMenusEN = new clsQxPrjMenusEN();
try
{
objQxPrjMenusEN.MenuId = objRow[conQxPrjMenus.MenuId].ToString().Trim(); //菜单Id
objQxPrjMenusEN.MenuName = objRow[conQxPrjMenus.MenuName].ToString().Trim(); //菜单名
objQxPrjMenusEN.QxPrjId = objRow[conQxPrjMenus.QxPrjId].ToString().Trim(); //项目Id
objQxPrjMenusEN.UpMenuId = objRow[conQxPrjMenus.UpMenuId].ToString().Trim(); //上级菜单Id
objQxPrjMenusEN.LinkFile = objRow[conQxPrjMenus.LinkFile] == DBNull.Value ? null : objRow[conQxPrjMenus.LinkFile].ToString().Trim(); //链接文件
objQxPrjMenusEN.qsParameters = objRow[conQxPrjMenus.qsParameters] == DBNull.Value ? null : objRow[conQxPrjMenus.qsParameters].ToString().Trim(); //qs参数
objQxPrjMenusEN.TabId = objRow[conQxPrjMenus.TabId] == DBNull.Value ? null : objRow[conQxPrjMenus.TabId].ToString().Trim(); //表ID
objQxPrjMenusEN.ImgFile = objRow[conQxPrjMenus.ImgFile] == DBNull.Value ? null : objRow[conQxPrjMenus.ImgFile].ToString().Trim(); //图像文件
objQxPrjMenusEN.RoleId = objRow[conQxPrjMenus.RoleId] == DBNull.Value ? null : objRow[conQxPrjMenus.RoleId].ToString().Trim(); //角色Id
objQxPrjMenusEN.OrderNum = Int32.Parse(objRow[conQxPrjMenus.OrderNum].ToString().Trim()); //排序号
objQxPrjMenusEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenus.IsLeafNode].ToString().Trim()); //是否叶子
objQxPrjMenusEN.MenuTitle = objRow[conQxPrjMenus.MenuTitle] == DBNull.Value ? null : objRow[conQxPrjMenus.MenuTitle].ToString().Trim(); //菜单标题
objQxPrjMenusEN.PageDispModeId = objRow[conQxPrjMenus.PageDispModeId] == DBNull.Value ? null : objRow[conQxPrjMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id
objQxPrjMenusEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenus.InUse].ToString().Trim()); //是否在用
objQxPrjMenusEN.MenuControlName = objRow[conQxPrjMenus.MenuControlName] == DBNull.Value ? null : objRow[conQxPrjMenus.MenuControlName].ToString().Trim(); //菜单控件名
objQxPrjMenusEN.ApplicationTypeId = Int32.Parse(objRow[conQxPrjMenus.ApplicationTypeId].ToString().Trim()); //应用程序类型Id
objQxPrjMenusEN.UpdDate = objRow[conQxPrjMenus.UpdDate] == DBNull.Value ? null : objRow[conQxPrjMenus.UpdDate].ToString().Trim(); //修改日期
objQxPrjMenusEN.UpdUserId = objRow[conQxPrjMenus.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjMenus.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjMenusEN.Memo = objRow[conQxPrjMenus.Memo] == DBNull.Value ? null : objRow[conQxPrjMenus.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjMenusEN.MenuId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjMenusEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objQxPrjMenusCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsQxPrjMenusEN> GetSubObjLstCache(clsQxPrjMenusEN objQxPrjMenusCond)
{
 string strQxPrjId = objQxPrjMenusCond.QxPrjId;
 if (string.IsNullOrEmpty(strQxPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsQxPrjMenusBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsQxPrjMenusEN> arrObjLstCache = GetObjLstCache(strQxPrjId);
IEnumerable <clsQxPrjMenusEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxPrjMenus.AttributeName)
{
if (objQxPrjMenusCond.IsUpdated(strFldName) == false) continue;
if (objQxPrjMenusCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxPrjMenusCond[strFldName].ToString());
}
else
{
if (objQxPrjMenusCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxPrjMenusCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxPrjMenusCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxPrjMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxPrjMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxPrjMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxPrjMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxPrjMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxPrjMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxPrjMenusCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxPrjMenusCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxPrjMenusCond[strFldName]));
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
public static List<clsQxPrjMenusEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsQxPrjMenusEN> arrObjLst = new List<clsQxPrjMenusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjMenusEN objQxPrjMenusEN = new clsQxPrjMenusEN();
try
{
objQxPrjMenusEN.MenuId = objRow[conQxPrjMenus.MenuId].ToString().Trim(); //菜单Id
objQxPrjMenusEN.MenuName = objRow[conQxPrjMenus.MenuName].ToString().Trim(); //菜单名
objQxPrjMenusEN.QxPrjId = objRow[conQxPrjMenus.QxPrjId].ToString().Trim(); //项目Id
objQxPrjMenusEN.UpMenuId = objRow[conQxPrjMenus.UpMenuId].ToString().Trim(); //上级菜单Id
objQxPrjMenusEN.LinkFile = objRow[conQxPrjMenus.LinkFile] == DBNull.Value ? null : objRow[conQxPrjMenus.LinkFile].ToString().Trim(); //链接文件
objQxPrjMenusEN.qsParameters = objRow[conQxPrjMenus.qsParameters] == DBNull.Value ? null : objRow[conQxPrjMenus.qsParameters].ToString().Trim(); //qs参数
objQxPrjMenusEN.TabId = objRow[conQxPrjMenus.TabId] == DBNull.Value ? null : objRow[conQxPrjMenus.TabId].ToString().Trim(); //表ID
objQxPrjMenusEN.ImgFile = objRow[conQxPrjMenus.ImgFile] == DBNull.Value ? null : objRow[conQxPrjMenus.ImgFile].ToString().Trim(); //图像文件
objQxPrjMenusEN.RoleId = objRow[conQxPrjMenus.RoleId] == DBNull.Value ? null : objRow[conQxPrjMenus.RoleId].ToString().Trim(); //角色Id
objQxPrjMenusEN.OrderNum = Int32.Parse(objRow[conQxPrjMenus.OrderNum].ToString().Trim()); //排序号
objQxPrjMenusEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenus.IsLeafNode].ToString().Trim()); //是否叶子
objQxPrjMenusEN.MenuTitle = objRow[conQxPrjMenus.MenuTitle] == DBNull.Value ? null : objRow[conQxPrjMenus.MenuTitle].ToString().Trim(); //菜单标题
objQxPrjMenusEN.PageDispModeId = objRow[conQxPrjMenus.PageDispModeId] == DBNull.Value ? null : objRow[conQxPrjMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id
objQxPrjMenusEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenus.InUse].ToString().Trim()); //是否在用
objQxPrjMenusEN.MenuControlName = objRow[conQxPrjMenus.MenuControlName] == DBNull.Value ? null : objRow[conQxPrjMenus.MenuControlName].ToString().Trim(); //菜单控件名
objQxPrjMenusEN.ApplicationTypeId = Int32.Parse(objRow[conQxPrjMenus.ApplicationTypeId].ToString().Trim()); //应用程序类型Id
objQxPrjMenusEN.UpdDate = objRow[conQxPrjMenus.UpdDate] == DBNull.Value ? null : objRow[conQxPrjMenus.UpdDate].ToString().Trim(); //修改日期
objQxPrjMenusEN.UpdUserId = objRow[conQxPrjMenus.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjMenus.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjMenusEN.Memo = objRow[conQxPrjMenus.Memo] == DBNull.Value ? null : objRow[conQxPrjMenus.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjMenusEN.MenuId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjMenusEN);
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
public static List<clsQxPrjMenusEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsQxPrjMenusEN> arrObjLst = new List<clsQxPrjMenusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjMenusEN objQxPrjMenusEN = new clsQxPrjMenusEN();
try
{
objQxPrjMenusEN.MenuId = objRow[conQxPrjMenus.MenuId].ToString().Trim(); //菜单Id
objQxPrjMenusEN.MenuName = objRow[conQxPrjMenus.MenuName].ToString().Trim(); //菜单名
objQxPrjMenusEN.QxPrjId = objRow[conQxPrjMenus.QxPrjId].ToString().Trim(); //项目Id
objQxPrjMenusEN.UpMenuId = objRow[conQxPrjMenus.UpMenuId].ToString().Trim(); //上级菜单Id
objQxPrjMenusEN.LinkFile = objRow[conQxPrjMenus.LinkFile] == DBNull.Value ? null : objRow[conQxPrjMenus.LinkFile].ToString().Trim(); //链接文件
objQxPrjMenusEN.qsParameters = objRow[conQxPrjMenus.qsParameters] == DBNull.Value ? null : objRow[conQxPrjMenus.qsParameters].ToString().Trim(); //qs参数
objQxPrjMenusEN.TabId = objRow[conQxPrjMenus.TabId] == DBNull.Value ? null : objRow[conQxPrjMenus.TabId].ToString().Trim(); //表ID
objQxPrjMenusEN.ImgFile = objRow[conQxPrjMenus.ImgFile] == DBNull.Value ? null : objRow[conQxPrjMenus.ImgFile].ToString().Trim(); //图像文件
objQxPrjMenusEN.RoleId = objRow[conQxPrjMenus.RoleId] == DBNull.Value ? null : objRow[conQxPrjMenus.RoleId].ToString().Trim(); //角色Id
objQxPrjMenusEN.OrderNum = Int32.Parse(objRow[conQxPrjMenus.OrderNum].ToString().Trim()); //排序号
objQxPrjMenusEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenus.IsLeafNode].ToString().Trim()); //是否叶子
objQxPrjMenusEN.MenuTitle = objRow[conQxPrjMenus.MenuTitle] == DBNull.Value ? null : objRow[conQxPrjMenus.MenuTitle].ToString().Trim(); //菜单标题
objQxPrjMenusEN.PageDispModeId = objRow[conQxPrjMenus.PageDispModeId] == DBNull.Value ? null : objRow[conQxPrjMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id
objQxPrjMenusEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenus.InUse].ToString().Trim()); //是否在用
objQxPrjMenusEN.MenuControlName = objRow[conQxPrjMenus.MenuControlName] == DBNull.Value ? null : objRow[conQxPrjMenus.MenuControlName].ToString().Trim(); //菜单控件名
objQxPrjMenusEN.ApplicationTypeId = Int32.Parse(objRow[conQxPrjMenus.ApplicationTypeId].ToString().Trim()); //应用程序类型Id
objQxPrjMenusEN.UpdDate = objRow[conQxPrjMenus.UpdDate] == DBNull.Value ? null : objRow[conQxPrjMenus.UpdDate].ToString().Trim(); //修改日期
objQxPrjMenusEN.UpdUserId = objRow[conQxPrjMenus.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjMenus.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjMenusEN.Memo = objRow[conQxPrjMenus.Memo] == DBNull.Value ? null : objRow[conQxPrjMenus.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjMenusEN.MenuId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjMenusEN);
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
List<clsQxPrjMenusEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsQxPrjMenusEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPrjMenusEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsQxPrjMenusEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsQxPrjMenusEN> arrObjLst = new List<clsQxPrjMenusEN>(); 
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
	clsQxPrjMenusEN objQxPrjMenusEN = new clsQxPrjMenusEN();
try
{
objQxPrjMenusEN.MenuId = objRow[conQxPrjMenus.MenuId].ToString().Trim(); //菜单Id
objQxPrjMenusEN.MenuName = objRow[conQxPrjMenus.MenuName].ToString().Trim(); //菜单名
objQxPrjMenusEN.QxPrjId = objRow[conQxPrjMenus.QxPrjId].ToString().Trim(); //项目Id
objQxPrjMenusEN.UpMenuId = objRow[conQxPrjMenus.UpMenuId].ToString().Trim(); //上级菜单Id
objQxPrjMenusEN.LinkFile = objRow[conQxPrjMenus.LinkFile] == DBNull.Value ? null : objRow[conQxPrjMenus.LinkFile].ToString().Trim(); //链接文件
objQxPrjMenusEN.qsParameters = objRow[conQxPrjMenus.qsParameters] == DBNull.Value ? null : objRow[conQxPrjMenus.qsParameters].ToString().Trim(); //qs参数
objQxPrjMenusEN.TabId = objRow[conQxPrjMenus.TabId] == DBNull.Value ? null : objRow[conQxPrjMenus.TabId].ToString().Trim(); //表ID
objQxPrjMenusEN.ImgFile = objRow[conQxPrjMenus.ImgFile] == DBNull.Value ? null : objRow[conQxPrjMenus.ImgFile].ToString().Trim(); //图像文件
objQxPrjMenusEN.RoleId = objRow[conQxPrjMenus.RoleId] == DBNull.Value ? null : objRow[conQxPrjMenus.RoleId].ToString().Trim(); //角色Id
objQxPrjMenusEN.OrderNum = Int32.Parse(objRow[conQxPrjMenus.OrderNum].ToString().Trim()); //排序号
objQxPrjMenusEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenus.IsLeafNode].ToString().Trim()); //是否叶子
objQxPrjMenusEN.MenuTitle = objRow[conQxPrjMenus.MenuTitle] == DBNull.Value ? null : objRow[conQxPrjMenus.MenuTitle].ToString().Trim(); //菜单标题
objQxPrjMenusEN.PageDispModeId = objRow[conQxPrjMenus.PageDispModeId] == DBNull.Value ? null : objRow[conQxPrjMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id
objQxPrjMenusEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenus.InUse].ToString().Trim()); //是否在用
objQxPrjMenusEN.MenuControlName = objRow[conQxPrjMenus.MenuControlName] == DBNull.Value ? null : objRow[conQxPrjMenus.MenuControlName].ToString().Trim(); //菜单控件名
objQxPrjMenusEN.ApplicationTypeId = Int32.Parse(objRow[conQxPrjMenus.ApplicationTypeId].ToString().Trim()); //应用程序类型Id
objQxPrjMenusEN.UpdDate = objRow[conQxPrjMenus.UpdDate] == DBNull.Value ? null : objRow[conQxPrjMenus.UpdDate].ToString().Trim(); //修改日期
objQxPrjMenusEN.UpdUserId = objRow[conQxPrjMenus.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjMenus.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjMenusEN.Memo = objRow[conQxPrjMenus.Memo] == DBNull.Value ? null : objRow[conQxPrjMenus.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjMenusEN.MenuId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjMenusEN);
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
public static List<clsQxPrjMenusEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsQxPrjMenusEN> arrObjLst = new List<clsQxPrjMenusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjMenusEN objQxPrjMenusEN = new clsQxPrjMenusEN();
try
{
objQxPrjMenusEN.MenuId = objRow[conQxPrjMenus.MenuId].ToString().Trim(); //菜单Id
objQxPrjMenusEN.MenuName = objRow[conQxPrjMenus.MenuName].ToString().Trim(); //菜单名
objQxPrjMenusEN.QxPrjId = objRow[conQxPrjMenus.QxPrjId].ToString().Trim(); //项目Id
objQxPrjMenusEN.UpMenuId = objRow[conQxPrjMenus.UpMenuId].ToString().Trim(); //上级菜单Id
objQxPrjMenusEN.LinkFile = objRow[conQxPrjMenus.LinkFile] == DBNull.Value ? null : objRow[conQxPrjMenus.LinkFile].ToString().Trim(); //链接文件
objQxPrjMenusEN.qsParameters = objRow[conQxPrjMenus.qsParameters] == DBNull.Value ? null : objRow[conQxPrjMenus.qsParameters].ToString().Trim(); //qs参数
objQxPrjMenusEN.TabId = objRow[conQxPrjMenus.TabId] == DBNull.Value ? null : objRow[conQxPrjMenus.TabId].ToString().Trim(); //表ID
objQxPrjMenusEN.ImgFile = objRow[conQxPrjMenus.ImgFile] == DBNull.Value ? null : objRow[conQxPrjMenus.ImgFile].ToString().Trim(); //图像文件
objQxPrjMenusEN.RoleId = objRow[conQxPrjMenus.RoleId] == DBNull.Value ? null : objRow[conQxPrjMenus.RoleId].ToString().Trim(); //角色Id
objQxPrjMenusEN.OrderNum = Int32.Parse(objRow[conQxPrjMenus.OrderNum].ToString().Trim()); //排序号
objQxPrjMenusEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenus.IsLeafNode].ToString().Trim()); //是否叶子
objQxPrjMenusEN.MenuTitle = objRow[conQxPrjMenus.MenuTitle] == DBNull.Value ? null : objRow[conQxPrjMenus.MenuTitle].ToString().Trim(); //菜单标题
objQxPrjMenusEN.PageDispModeId = objRow[conQxPrjMenus.PageDispModeId] == DBNull.Value ? null : objRow[conQxPrjMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id
objQxPrjMenusEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenus.InUse].ToString().Trim()); //是否在用
objQxPrjMenusEN.MenuControlName = objRow[conQxPrjMenus.MenuControlName] == DBNull.Value ? null : objRow[conQxPrjMenus.MenuControlName].ToString().Trim(); //菜单控件名
objQxPrjMenusEN.ApplicationTypeId = Int32.Parse(objRow[conQxPrjMenus.ApplicationTypeId].ToString().Trim()); //应用程序类型Id
objQxPrjMenusEN.UpdDate = objRow[conQxPrjMenus.UpdDate] == DBNull.Value ? null : objRow[conQxPrjMenus.UpdDate].ToString().Trim(); //修改日期
objQxPrjMenusEN.UpdUserId = objRow[conQxPrjMenus.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjMenus.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjMenusEN.Memo = objRow[conQxPrjMenus.Memo] == DBNull.Value ? null : objRow[conQxPrjMenus.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjMenusEN.MenuId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjMenusEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsQxPrjMenusEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsQxPrjMenusEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsQxPrjMenusEN> arrObjLst = new List<clsQxPrjMenusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjMenusEN objQxPrjMenusEN = new clsQxPrjMenusEN();
try
{
objQxPrjMenusEN.MenuId = objRow[conQxPrjMenus.MenuId].ToString().Trim(); //菜单Id
objQxPrjMenusEN.MenuName = objRow[conQxPrjMenus.MenuName].ToString().Trim(); //菜单名
objQxPrjMenusEN.QxPrjId = objRow[conQxPrjMenus.QxPrjId].ToString().Trim(); //项目Id
objQxPrjMenusEN.UpMenuId = objRow[conQxPrjMenus.UpMenuId].ToString().Trim(); //上级菜单Id
objQxPrjMenusEN.LinkFile = objRow[conQxPrjMenus.LinkFile] == DBNull.Value ? null : objRow[conQxPrjMenus.LinkFile].ToString().Trim(); //链接文件
objQxPrjMenusEN.qsParameters = objRow[conQxPrjMenus.qsParameters] == DBNull.Value ? null : objRow[conQxPrjMenus.qsParameters].ToString().Trim(); //qs参数
objQxPrjMenusEN.TabId = objRow[conQxPrjMenus.TabId] == DBNull.Value ? null : objRow[conQxPrjMenus.TabId].ToString().Trim(); //表ID
objQxPrjMenusEN.ImgFile = objRow[conQxPrjMenus.ImgFile] == DBNull.Value ? null : objRow[conQxPrjMenus.ImgFile].ToString().Trim(); //图像文件
objQxPrjMenusEN.RoleId = objRow[conQxPrjMenus.RoleId] == DBNull.Value ? null : objRow[conQxPrjMenus.RoleId].ToString().Trim(); //角色Id
objQxPrjMenusEN.OrderNum = Int32.Parse(objRow[conQxPrjMenus.OrderNum].ToString().Trim()); //排序号
objQxPrjMenusEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenus.IsLeafNode].ToString().Trim()); //是否叶子
objQxPrjMenusEN.MenuTitle = objRow[conQxPrjMenus.MenuTitle] == DBNull.Value ? null : objRow[conQxPrjMenus.MenuTitle].ToString().Trim(); //菜单标题
objQxPrjMenusEN.PageDispModeId = objRow[conQxPrjMenus.PageDispModeId] == DBNull.Value ? null : objRow[conQxPrjMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id
objQxPrjMenusEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenus.InUse].ToString().Trim()); //是否在用
objQxPrjMenusEN.MenuControlName = objRow[conQxPrjMenus.MenuControlName] == DBNull.Value ? null : objRow[conQxPrjMenus.MenuControlName].ToString().Trim(); //菜单控件名
objQxPrjMenusEN.ApplicationTypeId = Int32.Parse(objRow[conQxPrjMenus.ApplicationTypeId].ToString().Trim()); //应用程序类型Id
objQxPrjMenusEN.UpdDate = objRow[conQxPrjMenus.UpdDate] == DBNull.Value ? null : objRow[conQxPrjMenus.UpdDate].ToString().Trim(); //修改日期
objQxPrjMenusEN.UpdUserId = objRow[conQxPrjMenus.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjMenus.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjMenusEN.Memo = objRow[conQxPrjMenus.Memo] == DBNull.Value ? null : objRow[conQxPrjMenus.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjMenusEN.MenuId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjMenusEN);
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
public static List<clsQxPrjMenusEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsQxPrjMenusEN> arrObjLst = new List<clsQxPrjMenusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjMenusEN objQxPrjMenusEN = new clsQxPrjMenusEN();
try
{
objQxPrjMenusEN.MenuId = objRow[conQxPrjMenus.MenuId].ToString().Trim(); //菜单Id
objQxPrjMenusEN.MenuName = objRow[conQxPrjMenus.MenuName].ToString().Trim(); //菜单名
objQxPrjMenusEN.QxPrjId = objRow[conQxPrjMenus.QxPrjId].ToString().Trim(); //项目Id
objQxPrjMenusEN.UpMenuId = objRow[conQxPrjMenus.UpMenuId].ToString().Trim(); //上级菜单Id
objQxPrjMenusEN.LinkFile = objRow[conQxPrjMenus.LinkFile] == DBNull.Value ? null : objRow[conQxPrjMenus.LinkFile].ToString().Trim(); //链接文件
objQxPrjMenusEN.qsParameters = objRow[conQxPrjMenus.qsParameters] == DBNull.Value ? null : objRow[conQxPrjMenus.qsParameters].ToString().Trim(); //qs参数
objQxPrjMenusEN.TabId = objRow[conQxPrjMenus.TabId] == DBNull.Value ? null : objRow[conQxPrjMenus.TabId].ToString().Trim(); //表ID
objQxPrjMenusEN.ImgFile = objRow[conQxPrjMenus.ImgFile] == DBNull.Value ? null : objRow[conQxPrjMenus.ImgFile].ToString().Trim(); //图像文件
objQxPrjMenusEN.RoleId = objRow[conQxPrjMenus.RoleId] == DBNull.Value ? null : objRow[conQxPrjMenus.RoleId].ToString().Trim(); //角色Id
objQxPrjMenusEN.OrderNum = Int32.Parse(objRow[conQxPrjMenus.OrderNum].ToString().Trim()); //排序号
objQxPrjMenusEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenus.IsLeafNode].ToString().Trim()); //是否叶子
objQxPrjMenusEN.MenuTitle = objRow[conQxPrjMenus.MenuTitle] == DBNull.Value ? null : objRow[conQxPrjMenus.MenuTitle].ToString().Trim(); //菜单标题
objQxPrjMenusEN.PageDispModeId = objRow[conQxPrjMenus.PageDispModeId] == DBNull.Value ? null : objRow[conQxPrjMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id
objQxPrjMenusEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenus.InUse].ToString().Trim()); //是否在用
objQxPrjMenusEN.MenuControlName = objRow[conQxPrjMenus.MenuControlName] == DBNull.Value ? null : objRow[conQxPrjMenus.MenuControlName].ToString().Trim(); //菜单控件名
objQxPrjMenusEN.ApplicationTypeId = Int32.Parse(objRow[conQxPrjMenus.ApplicationTypeId].ToString().Trim()); //应用程序类型Id
objQxPrjMenusEN.UpdDate = objRow[conQxPrjMenus.UpdDate] == DBNull.Value ? null : objRow[conQxPrjMenus.UpdDate].ToString().Trim(); //修改日期
objQxPrjMenusEN.UpdUserId = objRow[conQxPrjMenus.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjMenus.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjMenusEN.Memo = objRow[conQxPrjMenus.Memo] == DBNull.Value ? null : objRow[conQxPrjMenus.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjMenusEN.MenuId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjMenusEN);
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
public static IEnumerable<clsQxPrjMenusEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsQxPrjMenusEN objQxPrjMenusCond, string strOrderBy)
{
 string strQxPrjId = objQxPrjMenusCond.QxPrjId;
 if (string.IsNullOrEmpty(strQxPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000173)在表中,缓存分类字段值不能为空!(clsQxPrjMenusBL:GetObjLstByPagerCache)");
throw new Exception(strMsg);
}
List<clsQxPrjMenusEN> arrObjLstCache = GetObjLstCache(strQxPrjId);
IEnumerable <clsQxPrjMenusEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxPrjMenus.AttributeName)
{
if (objQxPrjMenusCond.IsUpdated(strFldName) == false) continue;
if (objQxPrjMenusCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxPrjMenusCond[strFldName].ToString());
}
else
{
if (objQxPrjMenusCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxPrjMenusCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxPrjMenusCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxPrjMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxPrjMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxPrjMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxPrjMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxPrjMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxPrjMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxPrjMenusCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxPrjMenusCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxPrjMenusCond[strFldName]));
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
public static IEnumerable<clsQxPrjMenusEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsQxPrjMenusEN objQxPrjMenusCond = JsonConvert.DeserializeObject<clsQxPrjMenusEN>(objPagerPara.whereCond);
if (objQxPrjMenusCond.sfFldComparisonOp == null)
{
objQxPrjMenusCond.dicFldComparisonOp = null;
}
else
{
objQxPrjMenusCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objQxPrjMenusCond.sfFldComparisonOp);
}
clsQxPrjMenusBL.SetUpdFlag(objQxPrjMenusCond);
 try
{
CheckProperty4Condition(objQxPrjMenusCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsQxPrjMenusBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objQxPrjMenusCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPrjMenusEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsQxPrjMenusEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsQxPrjMenusEN> arrObjLst = new List<clsQxPrjMenusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjMenusEN objQxPrjMenusEN = new clsQxPrjMenusEN();
try
{
objQxPrjMenusEN.MenuId = objRow[conQxPrjMenus.MenuId].ToString().Trim(); //菜单Id
objQxPrjMenusEN.MenuName = objRow[conQxPrjMenus.MenuName].ToString().Trim(); //菜单名
objQxPrjMenusEN.QxPrjId = objRow[conQxPrjMenus.QxPrjId].ToString().Trim(); //项目Id
objQxPrjMenusEN.UpMenuId = objRow[conQxPrjMenus.UpMenuId].ToString().Trim(); //上级菜单Id
objQxPrjMenusEN.LinkFile = objRow[conQxPrjMenus.LinkFile] == DBNull.Value ? null : objRow[conQxPrjMenus.LinkFile].ToString().Trim(); //链接文件
objQxPrjMenusEN.qsParameters = objRow[conQxPrjMenus.qsParameters] == DBNull.Value ? null : objRow[conQxPrjMenus.qsParameters].ToString().Trim(); //qs参数
objQxPrjMenusEN.TabId = objRow[conQxPrjMenus.TabId] == DBNull.Value ? null : objRow[conQxPrjMenus.TabId].ToString().Trim(); //表ID
objQxPrjMenusEN.ImgFile = objRow[conQxPrjMenus.ImgFile] == DBNull.Value ? null : objRow[conQxPrjMenus.ImgFile].ToString().Trim(); //图像文件
objQxPrjMenusEN.RoleId = objRow[conQxPrjMenus.RoleId] == DBNull.Value ? null : objRow[conQxPrjMenus.RoleId].ToString().Trim(); //角色Id
objQxPrjMenusEN.OrderNum = Int32.Parse(objRow[conQxPrjMenus.OrderNum].ToString().Trim()); //排序号
objQxPrjMenusEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenus.IsLeafNode].ToString().Trim()); //是否叶子
objQxPrjMenusEN.MenuTitle = objRow[conQxPrjMenus.MenuTitle] == DBNull.Value ? null : objRow[conQxPrjMenus.MenuTitle].ToString().Trim(); //菜单标题
objQxPrjMenusEN.PageDispModeId = objRow[conQxPrjMenus.PageDispModeId] == DBNull.Value ? null : objRow[conQxPrjMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id
objQxPrjMenusEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenus.InUse].ToString().Trim()); //是否在用
objQxPrjMenusEN.MenuControlName = objRow[conQxPrjMenus.MenuControlName] == DBNull.Value ? null : objRow[conQxPrjMenus.MenuControlName].ToString().Trim(); //菜单控件名
objQxPrjMenusEN.ApplicationTypeId = Int32.Parse(objRow[conQxPrjMenus.ApplicationTypeId].ToString().Trim()); //应用程序类型Id
objQxPrjMenusEN.UpdDate = objRow[conQxPrjMenus.UpdDate] == DBNull.Value ? null : objRow[conQxPrjMenus.UpdDate].ToString().Trim(); //修改日期
objQxPrjMenusEN.UpdUserId = objRow[conQxPrjMenus.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjMenus.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjMenusEN.Memo = objRow[conQxPrjMenus.Memo] == DBNull.Value ? null : objRow[conQxPrjMenus.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjMenusEN.MenuId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjMenusEN);
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
public static List<clsQxPrjMenusEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsQxPrjMenusEN> arrObjLst = new List<clsQxPrjMenusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjMenusEN objQxPrjMenusEN = new clsQxPrjMenusEN();
try
{
objQxPrjMenusEN.MenuId = objRow[conQxPrjMenus.MenuId].ToString().Trim(); //菜单Id
objQxPrjMenusEN.MenuName = objRow[conQxPrjMenus.MenuName].ToString().Trim(); //菜单名
objQxPrjMenusEN.QxPrjId = objRow[conQxPrjMenus.QxPrjId].ToString().Trim(); //项目Id
objQxPrjMenusEN.UpMenuId = objRow[conQxPrjMenus.UpMenuId].ToString().Trim(); //上级菜单Id
objQxPrjMenusEN.LinkFile = objRow[conQxPrjMenus.LinkFile] == DBNull.Value ? null : objRow[conQxPrjMenus.LinkFile].ToString().Trim(); //链接文件
objQxPrjMenusEN.qsParameters = objRow[conQxPrjMenus.qsParameters] == DBNull.Value ? null : objRow[conQxPrjMenus.qsParameters].ToString().Trim(); //qs参数
objQxPrjMenusEN.TabId = objRow[conQxPrjMenus.TabId] == DBNull.Value ? null : objRow[conQxPrjMenus.TabId].ToString().Trim(); //表ID
objQxPrjMenusEN.ImgFile = objRow[conQxPrjMenus.ImgFile] == DBNull.Value ? null : objRow[conQxPrjMenus.ImgFile].ToString().Trim(); //图像文件
objQxPrjMenusEN.RoleId = objRow[conQxPrjMenus.RoleId] == DBNull.Value ? null : objRow[conQxPrjMenus.RoleId].ToString().Trim(); //角色Id
objQxPrjMenusEN.OrderNum = Int32.Parse(objRow[conQxPrjMenus.OrderNum].ToString().Trim()); //排序号
objQxPrjMenusEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenus.IsLeafNode].ToString().Trim()); //是否叶子
objQxPrjMenusEN.MenuTitle = objRow[conQxPrjMenus.MenuTitle] == DBNull.Value ? null : objRow[conQxPrjMenus.MenuTitle].ToString().Trim(); //菜单标题
objQxPrjMenusEN.PageDispModeId = objRow[conQxPrjMenus.PageDispModeId] == DBNull.Value ? null : objRow[conQxPrjMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id
objQxPrjMenusEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenus.InUse].ToString().Trim()); //是否在用
objQxPrjMenusEN.MenuControlName = objRow[conQxPrjMenus.MenuControlName] == DBNull.Value ? null : objRow[conQxPrjMenus.MenuControlName].ToString().Trim(); //菜单控件名
objQxPrjMenusEN.ApplicationTypeId = Int32.Parse(objRow[conQxPrjMenus.ApplicationTypeId].ToString().Trim()); //应用程序类型Id
objQxPrjMenusEN.UpdDate = objRow[conQxPrjMenus.UpdDate] == DBNull.Value ? null : objRow[conQxPrjMenus.UpdDate].ToString().Trim(); //修改日期
objQxPrjMenusEN.UpdUserId = objRow[conQxPrjMenus.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjMenus.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjMenusEN.Memo = objRow[conQxPrjMenus.Memo] == DBNull.Value ? null : objRow[conQxPrjMenus.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjMenusEN.MenuId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjMenusEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPrjMenusEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsQxPrjMenusEN> arrObjLst = new List<clsQxPrjMenusEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjMenusEN objQxPrjMenusEN = new clsQxPrjMenusEN();
try
{
objQxPrjMenusEN.MenuId = objRow[conQxPrjMenus.MenuId].ToString().Trim(); //菜单Id
objQxPrjMenusEN.MenuName = objRow[conQxPrjMenus.MenuName].ToString().Trim(); //菜单名
objQxPrjMenusEN.QxPrjId = objRow[conQxPrjMenus.QxPrjId].ToString().Trim(); //项目Id
objQxPrjMenusEN.UpMenuId = objRow[conQxPrjMenus.UpMenuId].ToString().Trim(); //上级菜单Id
objQxPrjMenusEN.LinkFile = objRow[conQxPrjMenus.LinkFile] == DBNull.Value ? null : objRow[conQxPrjMenus.LinkFile].ToString().Trim(); //链接文件
objQxPrjMenusEN.qsParameters = objRow[conQxPrjMenus.qsParameters] == DBNull.Value ? null : objRow[conQxPrjMenus.qsParameters].ToString().Trim(); //qs参数
objQxPrjMenusEN.TabId = objRow[conQxPrjMenus.TabId] == DBNull.Value ? null : objRow[conQxPrjMenus.TabId].ToString().Trim(); //表ID
objQxPrjMenusEN.ImgFile = objRow[conQxPrjMenus.ImgFile] == DBNull.Value ? null : objRow[conQxPrjMenus.ImgFile].ToString().Trim(); //图像文件
objQxPrjMenusEN.RoleId = objRow[conQxPrjMenus.RoleId] == DBNull.Value ? null : objRow[conQxPrjMenus.RoleId].ToString().Trim(); //角色Id
objQxPrjMenusEN.OrderNum = Int32.Parse(objRow[conQxPrjMenus.OrderNum].ToString().Trim()); //排序号
objQxPrjMenusEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenus.IsLeafNode].ToString().Trim()); //是否叶子
objQxPrjMenusEN.MenuTitle = objRow[conQxPrjMenus.MenuTitle] == DBNull.Value ? null : objRow[conQxPrjMenus.MenuTitle].ToString().Trim(); //菜单标题
objQxPrjMenusEN.PageDispModeId = objRow[conQxPrjMenus.PageDispModeId] == DBNull.Value ? null : objRow[conQxPrjMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id
objQxPrjMenusEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenus.InUse].ToString().Trim()); //是否在用
objQxPrjMenusEN.MenuControlName = objRow[conQxPrjMenus.MenuControlName] == DBNull.Value ? null : objRow[conQxPrjMenus.MenuControlName].ToString().Trim(); //菜单控件名
objQxPrjMenusEN.ApplicationTypeId = Int32.Parse(objRow[conQxPrjMenus.ApplicationTypeId].ToString().Trim()); //应用程序类型Id
objQxPrjMenusEN.UpdDate = objRow[conQxPrjMenus.UpdDate] == DBNull.Value ? null : objRow[conQxPrjMenus.UpdDate].ToString().Trim(); //修改日期
objQxPrjMenusEN.UpdUserId = objRow[conQxPrjMenus.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjMenus.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjMenusEN.Memo = objRow[conQxPrjMenus.Memo] == DBNull.Value ? null : objRow[conQxPrjMenus.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjMenusEN.MenuId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjMenusEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxPrjMenus(ref clsQxPrjMenusEN objQxPrjMenusEN)
{
bool bolResult = QxPrjMenusDA.GetQxPrjMenus(ref objQxPrjMenusEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strMenuId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxPrjMenusEN GetObjByMenuId(string strMenuId)
{
if (strMenuId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strMenuId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strMenuId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strMenuId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsQxPrjMenusEN objQxPrjMenusEN = QxPrjMenusDA.GetObjByMenuId(strMenuId);
return objQxPrjMenusEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsQxPrjMenusEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsQxPrjMenusEN objQxPrjMenusEN = QxPrjMenusDA.GetFirstObj(strWhereCond);
 return objQxPrjMenusEN;
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
public static clsQxPrjMenusEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsQxPrjMenusEN objQxPrjMenusEN = QxPrjMenusDA.GetObjByDataRow(objRow);
 return objQxPrjMenusEN;
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
public static clsQxPrjMenusEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsQxPrjMenusEN objQxPrjMenusEN = QxPrjMenusDA.GetObjByDataRow(objRow);
 return objQxPrjMenusEN;
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
 /// <param name = "strMenuId">所给的关键字</param>
 /// <param name = "lstQxPrjMenusObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxPrjMenusEN GetObjByMenuIdFromList(string strMenuId, List<clsQxPrjMenusEN> lstQxPrjMenusObjLst)
{
foreach (clsQxPrjMenusEN objQxPrjMenusEN in lstQxPrjMenusObjLst)
{
if (objQxPrjMenusEN.MenuId == strMenuId)
{
return objQxPrjMenusEN;
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
 string strMaxMenuId;
 try
 {
 strMaxMenuId = new clsQxPrjMenusDA().GetMaxStrIdByPrefix(strPrefix);
 return strMaxMenuId;
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
 string strMenuId;
 try
 {
 strMenuId = new clsQxPrjMenusDA().GetFirstID(strWhereCond);
 return strMenuId;
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
 arrList = QxPrjMenusDA.GetID(strWhereCond);
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
bool bolIsExist = QxPrjMenusDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strMenuId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strMenuId)
{
if (string.IsNullOrEmpty(strMenuId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strMenuId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = QxPrjMenusDA.IsExist(strMenuId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strMenuId">菜单Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strMenuId, string strOpUser)
{
clsQxPrjMenusEN objQxPrjMenusEN = clsQxPrjMenusBL.GetObjByMenuId(strMenuId);
objQxPrjMenusEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objQxPrjMenusEN.UpdUserId = strOpUser;
return clsQxPrjMenusBL.UpdateBySql2(objQxPrjMenusEN);
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
 bolIsExist = clsQxPrjMenusDA.IsExistTable();
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
 bolIsExist = QxPrjMenusDA.IsExistTable(strTabName);
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
 /// <param name = "objQxPrjMenusEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsQxPrjMenusEN objQxPrjMenusEN)
{
 if (string.IsNullOrEmpty(objQxPrjMenusEN.MenuId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQxPrjMenusBL.IsExist(objQxPrjMenusEN.MenuId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQxPrjMenusEN.MenuId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (objQxPrjMenusEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!菜单名 = [{0}],项目Id = [{1}]的数据已经存在!(in clsQxPrjMenusBL.AddNewRecordBySql2)", objQxPrjMenusEN.MenuName,objQxPrjMenusEN.QxPrjId);
throw new Exception(strMsg);
}
try
{
bool bolResult = QxPrjMenusDA.AddNewRecordBySQL2(objQxPrjMenusEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjMenusBL.ReFreshCache(objQxPrjMenusEN.QxPrjId);

if (clsQxPrjMenusBL.relatedActions != null)
{
clsQxPrjMenusBL.relatedActions.UpdRelaTabDate(objQxPrjMenusEN.MenuId, objQxPrjMenusEN.UpdUserId);
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
 /// <param name = "objQxPrjMenusEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsQxPrjMenusEN objQxPrjMenusEN)
{
 if (string.IsNullOrEmpty(objQxPrjMenusEN.MenuId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQxPrjMenusBL.IsExist(objQxPrjMenusEN.MenuId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQxPrjMenusEN.MenuId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (objQxPrjMenusEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!菜单名 = [{0}],项目Id = [{1}]的数据已经存在!(in clsQxPrjMenusBL.AddNewRecordBySql2WithReturnKey)", objQxPrjMenusEN.MenuName,objQxPrjMenusEN.QxPrjId);
throw new Exception(strMsg);
}
try
{
string strKey = QxPrjMenusDA.AddNewRecordBySQL2WithReturnKey(objQxPrjMenusEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjMenusBL.ReFreshCache(objQxPrjMenusEN.QxPrjId);

if (clsQxPrjMenusBL.relatedActions != null)
{
clsQxPrjMenusBL.relatedActions.UpdRelaTabDate(objQxPrjMenusEN.MenuId, objQxPrjMenusEN.UpdUserId);
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
 /// <param name = "strQxPrjMenusObjXml">代表实体对象的XML串</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql_XML(string strQxPrjMenusObjXml)
{
clsQxPrjMenusEN objQxPrjMenusEN = GetObjFromXmlStr(strQxPrjMenusObjXml);
try
{
bool bolResult = QxPrjMenusDA.AddNewRecordBySQL2(objQxPrjMenusEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjMenusBL.ReFreshCache(objQxPrjMenusEN.QxPrjId);

if (clsQxPrjMenusBL.relatedActions != null)
{
clsQxPrjMenusBL.relatedActions.UpdRelaTabDate(objQxPrjMenusEN.MenuId, objQxPrjMenusEN.UpdUserId);
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
 /// <param name = "objQxPrjMenusEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsQxPrjMenusEN objQxPrjMenusEN)
{
try
{
bool bolResult = QxPrjMenusDA.Update(objQxPrjMenusEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjMenusBL.ReFreshCache(objQxPrjMenusEN.QxPrjId);

if (clsQxPrjMenusBL.relatedActions != null)
{
clsQxPrjMenusBL.relatedActions.UpdRelaTabDate(objQxPrjMenusEN.MenuId, objQxPrjMenusEN.UpdUserId);
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
 /// <param name = "objQxPrjMenusEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsQxPrjMenusEN objQxPrjMenusEN)
{
 if (string.IsNullOrEmpty(objQxPrjMenusEN.MenuId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = QxPrjMenusDA.UpdateBySql2(objQxPrjMenusEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjMenusBL.ReFreshCache(objQxPrjMenusEN.QxPrjId);

if (clsQxPrjMenusBL.relatedActions != null)
{
clsQxPrjMenusBL.relatedActions.UpdRelaTabDate(objQxPrjMenusEN.MenuId, objQxPrjMenusEN.UpdUserId);
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
 /// <param name = "strQxPrjMenusObjXml">需要修改的对象,用XML来表示</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql_XML(string strQxPrjMenusObjXml)
{
clsQxPrjMenusEN objQxPrjMenusEN = GetObjFromXmlStr(strQxPrjMenusObjXml);
try
{
bool bolResult = QxPrjMenusDA.UpdateBySql2(objQxPrjMenusEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjMenusBL.ReFreshCache(objQxPrjMenusEN.QxPrjId);

if (clsQxPrjMenusBL.relatedActions != null)
{
clsQxPrjMenusBL.relatedActions.UpdRelaTabDate(objQxPrjMenusEN.MenuId, objQxPrjMenusEN.UpdUserId);
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
 /// <param name = "strMenuId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strMenuId)
{
try
{
 clsQxPrjMenusEN objQxPrjMenusEN = clsQxPrjMenusBL.GetObjByMenuId(strMenuId);

if (clsQxPrjMenusBL.relatedActions != null)
{
clsQxPrjMenusBL.relatedActions.UpdRelaTabDate(objQxPrjMenusEN.MenuId, objQxPrjMenusEN.UpdUserId);
}
if (objQxPrjMenusEN != null)
{
int intRecNum = QxPrjMenusDA.DelRecord(strMenuId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objQxPrjMenusEN.QxPrjId);
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
/// <param name="strMenuId">表关键字</param>
 /// <param name = "strQxPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strMenuId , string strQxPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
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
//删除与表:[QxPrjMenus]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conQxPrjMenus.MenuId,
//strMenuId);
//        clsQxPrjMenusBL.DelQxPrjMenussByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxPrjMenusBL.DelRecord(strMenuId, strQxPrjId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxPrjMenusBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strMenuId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strMenuId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strMenuId, string strQxPrjId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsQxPrjMenusBL.relatedActions != null)
{
clsQxPrjMenusBL.relatedActions.UpdRelaTabDate(strMenuId, "UpdRelaTabDate");
}
bool bolResult = QxPrjMenusDA.DelRecord(strMenuId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "strMenuId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strMenuId, string strQxPrjId) 
{
try
{
if (clsQxPrjMenusBL.relatedActions != null)
{
clsQxPrjMenusBL.relatedActions.UpdRelaTabDate(strMenuId, "UpdRelaTabDate");
}
bool bolResult = QxPrjMenusDA.DelRecordBySP(strMenuId);
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
 /// <param name = "arrMenuIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelQxPrjMenuss(List<string> arrMenuIdLst)
{
if (arrMenuIdLst.Count == 0) return 0;
try
{
if (clsQxPrjMenusBL.relatedActions != null)
{
foreach (var strMenuId in arrMenuIdLst)
{
clsQxPrjMenusBL.relatedActions.UpdRelaTabDate(strMenuId, "UpdRelaTabDate");
}
}
 clsQxPrjMenusEN objQxPrjMenusEN = clsQxPrjMenusBL.GetObjByMenuId(arrMenuIdLst[0]);
int intDelRecNum = QxPrjMenusDA.DelQxPrjMenus(arrMenuIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objQxPrjMenusEN.QxPrjId);
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
public static int DelQxPrjMenussByCond(string strWhereCond)
{
try
{
if (clsQxPrjMenusBL.relatedActions != null)
{
List<string> arrMenuId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strMenuId in arrMenuId)
{
clsQxPrjMenusBL.relatedActions.UpdRelaTabDate(strMenuId, "UpdRelaTabDate");
}
}
List<string> arrQxPrjId = GetFldValue(conQxPrjMenus.QxPrjId, strWhereCond);
int intRecNum = QxPrjMenusDA.DelQxPrjMenus(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[QxPrjMenus]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strMenuId">表关键字</param>
 /// <param name = "strQxPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strMenuId, string strQxPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxPrjMenusDA.GetSpecSQLObj();
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
//删除与表:[QxPrjMenus]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxPrjMenusBL.DelRecord(strMenuId, strQxPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxPrjMenusBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strMenuId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objQxPrjMenusENS">源对象</param>
 /// <param name = "objQxPrjMenusENT">目标对象</param>
 public static void CopyTo(clsQxPrjMenusEN objQxPrjMenusENS, clsQxPrjMenusEN objQxPrjMenusENT)
{
try
{
objQxPrjMenusENT.MenuId = objQxPrjMenusENS.MenuId; //菜单Id
objQxPrjMenusENT.MenuName = objQxPrjMenusENS.MenuName; //菜单名
objQxPrjMenusENT.QxPrjId = objQxPrjMenusENS.QxPrjId; //项目Id
objQxPrjMenusENT.UpMenuId = objQxPrjMenusENS.UpMenuId; //上级菜单Id
objQxPrjMenusENT.LinkFile = objQxPrjMenusENS.LinkFile; //链接文件
objQxPrjMenusENT.qsParameters = objQxPrjMenusENS.qsParameters; //qs参数
objQxPrjMenusENT.TabId = objQxPrjMenusENS.TabId; //表ID
objQxPrjMenusENT.ImgFile = objQxPrjMenusENS.ImgFile; //图像文件
objQxPrjMenusENT.RoleId = objQxPrjMenusENS.RoleId; //角色Id
objQxPrjMenusENT.OrderNum = objQxPrjMenusENS.OrderNum; //排序号
objQxPrjMenusENT.IsLeafNode = objQxPrjMenusENS.IsLeafNode; //是否叶子
objQxPrjMenusENT.MenuTitle = objQxPrjMenusENS.MenuTitle; //菜单标题
objQxPrjMenusENT.PageDispModeId = objQxPrjMenusENS.PageDispModeId; //页面显示模式Id
objQxPrjMenusENT.InUse = objQxPrjMenusENS.InUse; //是否在用
objQxPrjMenusENT.MenuControlName = objQxPrjMenusENS.MenuControlName; //菜单控件名
objQxPrjMenusENT.ApplicationTypeId = objQxPrjMenusENS.ApplicationTypeId; //应用程序类型Id
objQxPrjMenusENT.UpdDate = objQxPrjMenusENS.UpdDate; //修改日期
objQxPrjMenusENT.UpdUserId = objQxPrjMenusENS.UpdUserId; //修改用户Id
objQxPrjMenusENT.Memo = objQxPrjMenusENS.Memo; //备注
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
 /// <param name = "objQxPrjMenusEN">源简化对象</param>
 public static void SetUpdFlag(clsQxPrjMenusEN objQxPrjMenusEN)
{
try
{
objQxPrjMenusEN.ClearUpdateState();
   string strsfUpdFldSetStr = objQxPrjMenusEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conQxPrjMenus.MenuId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenusEN.MenuId = objQxPrjMenusEN.MenuId; //菜单Id
}
if (arrFldSet.Contains(conQxPrjMenus.MenuName, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenusEN.MenuName = objQxPrjMenusEN.MenuName; //菜单名
}
if (arrFldSet.Contains(conQxPrjMenus.QxPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenusEN.QxPrjId = objQxPrjMenusEN.QxPrjId; //项目Id
}
if (arrFldSet.Contains(conQxPrjMenus.UpMenuId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenusEN.UpMenuId = objQxPrjMenusEN.UpMenuId; //上级菜单Id
}
if (arrFldSet.Contains(conQxPrjMenus.LinkFile, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenusEN.LinkFile = objQxPrjMenusEN.LinkFile == "[null]" ? null :  objQxPrjMenusEN.LinkFile; //链接文件
}
if (arrFldSet.Contains(conQxPrjMenus.qsParameters, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenusEN.qsParameters = objQxPrjMenusEN.qsParameters == "[null]" ? null :  objQxPrjMenusEN.qsParameters; //qs参数
}
if (arrFldSet.Contains(conQxPrjMenus.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenusEN.TabId = objQxPrjMenusEN.TabId == "[null]" ? null :  objQxPrjMenusEN.TabId; //表ID
}
if (arrFldSet.Contains(conQxPrjMenus.ImgFile, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenusEN.ImgFile = objQxPrjMenusEN.ImgFile == "[null]" ? null :  objQxPrjMenusEN.ImgFile; //图像文件
}
if (arrFldSet.Contains(conQxPrjMenus.RoleId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenusEN.RoleId = objQxPrjMenusEN.RoleId == "[null]" ? null :  objQxPrjMenusEN.RoleId; //角色Id
}
if (arrFldSet.Contains(conQxPrjMenus.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenusEN.OrderNum = objQxPrjMenusEN.OrderNum; //排序号
}
if (arrFldSet.Contains(conQxPrjMenus.IsLeafNode, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenusEN.IsLeafNode = objQxPrjMenusEN.IsLeafNode; //是否叶子
}
if (arrFldSet.Contains(conQxPrjMenus.MenuTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenusEN.MenuTitle = objQxPrjMenusEN.MenuTitle == "[null]" ? null :  objQxPrjMenusEN.MenuTitle; //菜单标题
}
if (arrFldSet.Contains(conQxPrjMenus.PageDispModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenusEN.PageDispModeId = objQxPrjMenusEN.PageDispModeId == "[null]" ? null :  objQxPrjMenusEN.PageDispModeId; //页面显示模式Id
}
if (arrFldSet.Contains(conQxPrjMenus.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenusEN.InUse = objQxPrjMenusEN.InUse; //是否在用
}
if (arrFldSet.Contains(conQxPrjMenus.MenuControlName, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenusEN.MenuControlName = objQxPrjMenusEN.MenuControlName == "[null]" ? null :  objQxPrjMenusEN.MenuControlName; //菜单控件名
}
if (arrFldSet.Contains(conQxPrjMenus.ApplicationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenusEN.ApplicationTypeId = objQxPrjMenusEN.ApplicationTypeId; //应用程序类型Id
}
if (arrFldSet.Contains(conQxPrjMenus.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenusEN.UpdDate = objQxPrjMenusEN.UpdDate == "[null]" ? null :  objQxPrjMenusEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conQxPrjMenus.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenusEN.UpdUserId = objQxPrjMenusEN.UpdUserId == "[null]" ? null :  objQxPrjMenusEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conQxPrjMenus.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenusEN.Memo = objQxPrjMenusEN.Memo == "[null]" ? null :  objQxPrjMenusEN.Memo; //备注
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
 /// <param name = "objQxPrjMenusEN">源简化对象</param>
 public static void AccessFldValueNull(clsQxPrjMenusEN objQxPrjMenusEN)
{
try
{
if (objQxPrjMenusEN.LinkFile == "[null]") objQxPrjMenusEN.LinkFile = null; //链接文件
if (objQxPrjMenusEN.qsParameters == "[null]") objQxPrjMenusEN.qsParameters = null; //qs参数
if (objQxPrjMenusEN.TabId == "[null]") objQxPrjMenusEN.TabId = null; //表ID
if (objQxPrjMenusEN.ImgFile == "[null]") objQxPrjMenusEN.ImgFile = null; //图像文件
if (objQxPrjMenusEN.RoleId == "[null]") objQxPrjMenusEN.RoleId = null; //角色Id
if (objQxPrjMenusEN.MenuTitle == "[null]") objQxPrjMenusEN.MenuTitle = null; //菜单标题
if (objQxPrjMenusEN.PageDispModeId == "[null]") objQxPrjMenusEN.PageDispModeId = null; //页面显示模式Id
if (objQxPrjMenusEN.MenuControlName == "[null]") objQxPrjMenusEN.MenuControlName = null; //菜单控件名
if (objQxPrjMenusEN.UpdDate == "[null]") objQxPrjMenusEN.UpdDate = null; //修改日期
if (objQxPrjMenusEN.UpdUserId == "[null]") objQxPrjMenusEN.UpdUserId = null; //修改用户Id
if (objQxPrjMenusEN.Memo == "[null]") objQxPrjMenusEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsQxPrjMenusEN objQxPrjMenusEN)
{
 QxPrjMenusDA.CheckPropertyNew(objQxPrjMenusEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsQxPrjMenusEN objQxPrjMenusEN)
{
 QxPrjMenusDA.CheckProperty4Condition(objQxPrjMenusEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strQxPrjId"></param>
public static void BindCbo_MenuId(System.Windows.Forms.ComboBox objComboBox , string strQxPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conQxPrjMenus.MenuId); 
List<clsQxPrjMenusEN> arrObjLst = clsQxPrjMenusBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.QxPrjId == strQxPrjId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsQxPrjMenusEN objQxPrjMenusEN = new clsQxPrjMenusEN()
{
MenuId = "0",
MenuName = "选[工程菜单]..."
};
arrObjLstSel.Insert(0, objQxPrjMenusEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conQxPrjMenus.MenuId;
objComboBox.DisplayMember = conQxPrjMenus.MenuName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strQxPrjId"></param>
public static void BindDdl_MenuId(System.Web.UI.WebControls.DropDownList objDDL , string strQxPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[工程菜单]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conQxPrjMenus.MenuId); 
IEnumerable<clsQxPrjMenusEN> arrObjLst = clsQxPrjMenusBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.QxPrjId == strQxPrjId).ToList();
objDDL.DataValueField = conQxPrjMenus.MenuId;
objDDL.DataTextField = conQxPrjMenus.MenuName;
objDDL.DataSource = arrObjLstSel;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_MenuIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strQxPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[工程菜单]...","0");
List<clsQxPrjMenusEN> arrQxPrjMenusObjLst = GetAllQxPrjMenusObjLstCache(strQxPrjId); 
objDDL.DataValueField = conQxPrjMenus.MenuId;
objDDL.DataTextField = conQxPrjMenus.MenuName;
objDDL.DataSource = arrQxPrjMenusObjLst;
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
if (clsQxPrjMenusBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxPrjMenusBL没有刷新缓存机制(clsQxPrjMenusBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by MenuId");
//if (arrQxPrjMenusObjLstCache == null)
//{
//arrQxPrjMenusObjLstCache = QxPrjMenusDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strMenuId">所给的关键字</param>
 /// <param name = "strQxPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxPrjMenusEN GetObjByMenuIdCache(string strMenuId, string strQxPrjId)
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
string strKey = string.Format("{0}_{1}", clsQxPrjMenusEN._CurrTabName, strQxPrjId);
List<clsQxPrjMenusEN> arrQxPrjMenusObjLstCache = GetObjLstCache(strQxPrjId);
IEnumerable <clsQxPrjMenusEN> arrQxPrjMenusObjLst_Sel =
arrQxPrjMenusObjLstCache
.Where(x=> x.MenuId == strMenuId 
);
if (arrQxPrjMenusObjLst_Sel.Count() == 0)
{
   clsQxPrjMenusEN obj = clsQxPrjMenusBL.GetObjByMenuId(strMenuId);
   if (obj != null)
 {
if (obj.QxPrjId == strQxPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strMenuId, strQxPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrQxPrjMenusObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strMenuId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetMenuNameByMenuIdCache(string strMenuId, string strQxPrjId)
{
if (string.IsNullOrEmpty(strMenuId) == true) return "";
//获取缓存中的对象列表
clsQxPrjMenusEN objQxPrjMenus = GetObjByMenuIdCache(strMenuId, strQxPrjId);
if (objQxPrjMenus == null) return "";
return objQxPrjMenus.MenuName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strMenuId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByMenuIdCache(string strMenuId, string strQxPrjId)
{
if (string.IsNullOrEmpty(strMenuId) == true) return "";
//获取缓存中的对象列表
clsQxPrjMenusEN objQxPrjMenus = GetObjByMenuIdCache(strMenuId, strQxPrjId);
if (objQxPrjMenus == null) return "";
return objQxPrjMenus.MenuName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxPrjMenusEN> GetAllQxPrjMenusObjLstCache(string strQxPrjId)
{
//获取缓存中的对象列表
List<clsQxPrjMenusEN> arrQxPrjMenusObjLstCache = GetObjLstCache(strQxPrjId); 
return arrQxPrjMenusObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxPrjMenusEN> GetObjLstCache(string strQxPrjId)
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
string strKey = string.Format("{0}_{1}", clsQxPrjMenusEN._CurrTabName, strQxPrjId);
string strCondition = string.Format("QxPrjId='{0}'", strQxPrjId);
List<clsQxPrjMenusEN> arrQxPrjMenusObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrQxPrjMenusObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsQxPrjMenusEN._CurrTabName, strQxPrjId);
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
if (clsQxPrjMenusBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsQxPrjMenusEN._CurrTabName, strQxPrjId);
CacheHelper.Remove(strKey);
clsQxPrjMenusBL.objCommFun4BL.ReFreshCache(strQxPrjId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--QxPrjMenus(工程菜单)
 /// 唯一性条件:MenuName_QxPrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsQxPrjMenusEN objQxPrjMenusEN)
{
//检测记录是否存在
string strResult = QxPrjMenusDA.GetUniCondStr(objQxPrjMenusEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2024-08-29
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstQxPrjMenusObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsQxPrjMenusEN> lstQxPrjMenusObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstQxPrjMenusObjLst, writer);
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
 /// <param name = "lstQxPrjMenusObjLst">[clsQxPrjMenusEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsQxPrjMenusEN> lstQxPrjMenusObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsQxPrjMenusBL.listXmlNode);
writer.WriteStartElement(clsQxPrjMenusBL.itemsXmlNode);
foreach (clsQxPrjMenusEN objQxPrjMenusEN in lstQxPrjMenusObjLst)
{
clsQxPrjMenusBL.SerializeXML(writer, objQxPrjMenusEN);
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
 /// <param name = "objQxPrjMenusEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsQxPrjMenusEN objQxPrjMenusEN)
{
writer.WriteStartElement(clsQxPrjMenusBL.itemXmlNode);
 
if (objQxPrjMenusEN.MenuId != null)
{
writer.WriteElementString(conQxPrjMenus.MenuId, objQxPrjMenusEN.MenuId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjMenusEN.MenuName != null)
{
writer.WriteElementString(conQxPrjMenus.MenuName, objQxPrjMenusEN.MenuName.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjMenusEN.QxPrjId != null)
{
writer.WriteElementString(conQxPrjMenus.QxPrjId, objQxPrjMenusEN.QxPrjId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjMenusEN.UpMenuId != null)
{
writer.WriteElementString(conQxPrjMenus.UpMenuId, objQxPrjMenusEN.UpMenuId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjMenusEN.LinkFile != null)
{
writer.WriteElementString(conQxPrjMenus.LinkFile, objQxPrjMenusEN.LinkFile.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjMenusEN.qsParameters != null)
{
writer.WriteElementString(conQxPrjMenus.qsParameters, objQxPrjMenusEN.qsParameters.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjMenusEN.TabId != null)
{
writer.WriteElementString(conQxPrjMenus.TabId, objQxPrjMenusEN.TabId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjMenusEN.ImgFile != null)
{
writer.WriteElementString(conQxPrjMenus.ImgFile, objQxPrjMenusEN.ImgFile.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjMenusEN.RoleId != null)
{
writer.WriteElementString(conQxPrjMenus.RoleId, objQxPrjMenusEN.RoleId.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(conQxPrjMenus.OrderNum, objQxPrjMenusEN.OrderNum.ToString(CultureInfo.InvariantCulture));
 
writer.WriteElementString(conQxPrjMenus.IsLeafNode, objQxPrjMenusEN.IsLeafNode.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objQxPrjMenusEN.MenuTitle != null)
{
writer.WriteElementString(conQxPrjMenus.MenuTitle, objQxPrjMenusEN.MenuTitle.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjMenusEN.PageDispModeId != null)
{
writer.WriteElementString(conQxPrjMenus.PageDispModeId, objQxPrjMenusEN.PageDispModeId.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(conQxPrjMenus.InUse, objQxPrjMenusEN.InUse.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objQxPrjMenusEN.MenuControlName != null)
{
writer.WriteElementString(conQxPrjMenus.MenuControlName, objQxPrjMenusEN.MenuControlName.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(conQxPrjMenus.ApplicationTypeId, objQxPrjMenusEN.ApplicationTypeId.ToString(CultureInfo.InvariantCulture));
 
if (objQxPrjMenusEN.UpdDate != null)
{
writer.WriteElementString(conQxPrjMenus.UpdDate, objQxPrjMenusEN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjMenusEN.UpdUserId != null)
{
writer.WriteElementString(conQxPrjMenus.UpdUserId, objQxPrjMenusEN.UpdUserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjMenusEN.Memo != null)
{
writer.WriteElementString(conQxPrjMenus.Memo, objQxPrjMenusEN.Memo.ToString(CultureInfo.InvariantCulture));
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
public static clsQxPrjMenusEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsQxPrjMenusEN objQxPrjMenusEN = new clsQxPrjMenusEN();
reader.Read();
while (!(reader.Name == clsQxPrjMenusBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(conQxPrjMenus.MenuId))
{
objQxPrjMenusEN.MenuId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjMenus.MenuName))
{
objQxPrjMenusEN.MenuName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjMenus.QxPrjId))
{
objQxPrjMenusEN.QxPrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjMenus.UpMenuId))
{
objQxPrjMenusEN.UpMenuId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjMenus.LinkFile))
{
objQxPrjMenusEN.LinkFile = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjMenus.qsParameters))
{
objQxPrjMenusEN.qsParameters = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjMenus.TabId))
{
objQxPrjMenusEN.TabId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjMenus.ImgFile))
{
objQxPrjMenusEN.ImgFile = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjMenus.RoleId))
{
objQxPrjMenusEN.RoleId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjMenus.OrderNum))
{
objQxPrjMenusEN.OrderNum = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(conQxPrjMenus.IsLeafNode))
{
objQxPrjMenusEN.IsLeafNode = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(conQxPrjMenus.MenuTitle))
{
objQxPrjMenusEN.MenuTitle = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjMenus.PageDispModeId))
{
objQxPrjMenusEN.PageDispModeId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjMenus.InUse))
{
objQxPrjMenusEN.InUse = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(conQxPrjMenus.MenuControlName))
{
objQxPrjMenusEN.MenuControlName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjMenus.ApplicationTypeId))
{
objQxPrjMenusEN.ApplicationTypeId = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(conQxPrjMenus.UpdDate))
{
objQxPrjMenusEN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjMenus.UpdUserId))
{
objQxPrjMenusEN.UpdUserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjMenus.Memo))
{
objQxPrjMenusEN.Memo = reader.ReadElementContentAsString();
}
}
return objQxPrjMenusEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strQxPrjMenusObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsQxPrjMenusEN GetObjFromXmlStr(string strQxPrjMenusObjXmlStr)
{
clsQxPrjMenusEN objQxPrjMenusEN = new clsQxPrjMenusEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strQxPrjMenusObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsQxPrjMenusBL.itemXmlNode))
{
objQxPrjMenusEN = GetObjFromXml(reader);
return objQxPrjMenusEN;
}
}
return objQxPrjMenusEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2024-08-29
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsQxPrjMenusEN objQxPrjMenusEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objQxPrjMenusEN);
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
 /// <param name = "strQxPrjId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strMenuId, string strQxPrjId)
{
if (strInFldName != conQxPrjMenus.MenuId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conQxPrjMenus.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conQxPrjMenus.AttributeName));
throw new Exception(strMsg);
}
var objQxPrjMenus = clsQxPrjMenusBL.GetObjByMenuIdCache(strMenuId, strQxPrjId);
if (objQxPrjMenus == null) return "";
return objQxPrjMenus[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2024-08-29
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsQxPrjMenusEN objQxPrjMenusEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsQxPrjMenusEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objQxPrjMenusEN[strField]);
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
 /// <param name = "lstQxPrjMenusObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsQxPrjMenusEN> lstQxPrjMenusObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstQxPrjMenusObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsQxPrjMenusEN objQxPrjMenusEN in lstQxPrjMenusObjLst)
{
string strJSON_One = SerializeObjToJSON(objQxPrjMenusEN);
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
int intRecCount = clsQxPrjMenusDA.GetRecCount(strTabName);
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
int intRecCount = clsQxPrjMenusDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsQxPrjMenusDA.GetRecCount();
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
int intRecCount = clsQxPrjMenusDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objQxPrjMenusCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsQxPrjMenusEN objQxPrjMenusCond)
{
 string strQxPrjId = objQxPrjMenusCond.QxPrjId;
 if (string.IsNullOrEmpty(strQxPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsQxPrjMenusBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsQxPrjMenusEN> arrObjLstCache = GetObjLstCache(strQxPrjId);
IEnumerable <clsQxPrjMenusEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxPrjMenus.AttributeName)
{
if (objQxPrjMenusCond.IsUpdated(strFldName) == false) continue;
if (objQxPrjMenusCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxPrjMenusCond[strFldName].ToString());
}
else
{
if (objQxPrjMenusCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxPrjMenusCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxPrjMenusCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxPrjMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxPrjMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxPrjMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxPrjMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxPrjMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxPrjMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxPrjMenusCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxPrjMenusCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxPrjMenusCond[strFldName]));
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
 List<string> arrList = clsQxPrjMenusDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = QxPrjMenusDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = QxPrjMenusDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = QxPrjMenusDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxPrjMenusDA.SetFldValue(clsQxPrjMenusEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = QxPrjMenusDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxPrjMenusDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxPrjMenusDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxPrjMenusDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[QxPrjMenus] "); 
 strCreateTabCode.Append(" ( "); 
 // /**菜单Id*/ 
 strCreateTabCode.Append(" MenuId char(8) primary key, "); 
 // /**菜单名*/ 
 strCreateTabCode.Append(" MenuName varchar(50) not Null, "); 
 // /**项目Id*/ 
 strCreateTabCode.Append(" QxPrjId char(4) not Null, "); 
 // /**上级菜单Id*/ 
 strCreateTabCode.Append(" UpMenuId char(8) not Null, "); 
 // /**链接文件*/ 
 strCreateTabCode.Append(" LinkFile varchar(500) Null, "); 
 // /**qs参数*/ 
 strCreateTabCode.Append(" qsParameters varchar(200) Null, "); 
 // /**表ID*/ 
 strCreateTabCode.Append(" TabId char(8) Null, "); 
 // /**图像文件*/ 
 strCreateTabCode.Append(" ImgFile varchar(300) Null, "); 
 // /**角色Id*/ 
 strCreateTabCode.Append(" RoleId char(8) Null, "); 
 // /**排序号*/ 
 strCreateTabCode.Append(" OrderNum int not Null, "); 
 // /**是否叶子*/ 
 strCreateTabCode.Append(" IsLeafNode bit not Null, "); 
 // /**菜单标题*/ 
 strCreateTabCode.Append(" MenuTitle varchar(50) Null, "); 
 // /**页面显示模式Id*/ 
 strCreateTabCode.Append(" PageDispModeId char(2) Null, "); 
 // /**是否在用*/ 
 strCreateTabCode.Append(" InUse bit Null, "); 
 // /**菜单控件名*/ 
 strCreateTabCode.Append(" MenuControlName varchar(100) Null, "); 
 // /**应用程序类型Id*/ 
 strCreateTabCode.Append(" ApplicationTypeId int not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**页面显示模式名称*/ 
 strCreateTabCode.Append(" PageDispModeName varchar(50) Null, "); 
 // /**菜单集名称*/ 
 strCreateTabCode.Append(" MenuSetName varchar(50) Null, "); 
 // /**上级菜单名*/ 
 strCreateTabCode.Append(" UpMenuName varchar(30) Null, "); 
 // /**上级菜单名*/ 
 strCreateTabCode.Append(" RoleNames varchar(30) Null, "); 
 // /**简化日期时间*/ 
 strCreateTabCode.Append(" DateTimeSim varchar(20) Null, "); 
 // /**菜单名*/ 
 strCreateTabCode.Append(" MenuNameEx varchar(50) not Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 数据同步


 #endregion 数据同步
}
 /// <summary>
 /// 工程菜单(QxPrjMenus)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4QxPrjMenus : clsCommFun4BLV2
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
clsQxPrjMenusBL.ReFreshThisCache(strQxPrjId);
}
}

}