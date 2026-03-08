
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxPrjMenusV2BL
 表名:QxPrjMenusV2(00140112)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:29:18
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
public static class  clsQxPrjMenusV2BL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "intid">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxPrjMenusV2EN GetObj(this K_id_QxPrjMenusV2 myKey)
{
clsQxPrjMenusV2EN objQxPrjMenusV2EN = clsQxPrjMenusV2BL.QxPrjMenusV2DA.GetObjByid(myKey.Value);
return objQxPrjMenusV2EN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQxPrjMenusV2EN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQxPrjMenusV2EN objQxPrjMenusV2EN)
{
if (CheckUniqueness(objQxPrjMenusV2EN) == false)
{
var strMsg = string.Format("记录已经存在!菜单名 = [{0}],项目Id = [{1}],菜单集Id = [{2}]的数据已经存在!(in clsQxPrjMenusV2BL.AddNewRecord)", objQxPrjMenusV2EN.MenuName,objQxPrjMenusV2EN.QxPrjId,objQxPrjMenusV2EN.MenuSetId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsQxPrjMenusV2BL.QxPrjMenusV2DA.AddNewRecordBySQL2(objQxPrjMenusV2EN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjMenusV2BL.ReFreshCache(objQxPrjMenusV2EN.QxPrjId);

if (clsQxPrjMenusV2BL.relatedActions != null)
{
clsQxPrjMenusV2BL.relatedActions.UpdRelaTabDate(objQxPrjMenusV2EN.id, objQxPrjMenusV2EN.UpdUserId);
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
public static bool AddRecordEx(this clsQxPrjMenusV2EN objQxPrjMenusV2EN)
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
objQxPrjMenusV2EN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objQxPrjMenusV2EN.CheckUniqueness() == false)
{
strMsg = string.Format("(菜单名(MenuName)=[{0}],项目Id(QxPrjId)=[{1}],菜单集Id(MenuSetId)=[{2}])已经存在,不能重复!", objQxPrjMenusV2EN.MenuName, objQxPrjMenusV2EN.QxPrjId, objQxPrjMenusV2EN.MenuSetId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objQxPrjMenusV2EN.AddNewRecord();
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
 /// <param name = "objQxPrjMenusV2EN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsQxPrjMenusV2EN objQxPrjMenusV2EN)
{
if (CheckUniqueness(objQxPrjMenusV2EN) == false)
{
var strMsg = string.Format("记录已经存在!菜单名 = [{0}],项目Id = [{1}],菜单集Id = [{2}]的数据已经存在!(in clsQxPrjMenusV2BL.AddNewRecordWithReturnKey)", objQxPrjMenusV2EN.MenuName,objQxPrjMenusV2EN.QxPrjId,objQxPrjMenusV2EN.MenuSetId);
throw new Exception(strMsg);
}
try
{
string strKey = clsQxPrjMenusV2BL.QxPrjMenusV2DA.AddNewRecordBySQL2WithReturnKey(objQxPrjMenusV2EN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjMenusV2BL.ReFreshCache(objQxPrjMenusV2EN.QxPrjId);

if (clsQxPrjMenusV2BL.relatedActions != null)
{
clsQxPrjMenusV2BL.relatedActions.UpdRelaTabDate(objQxPrjMenusV2EN.id, objQxPrjMenusV2EN.UpdUserId);
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
 /// <param name = "objQxPrjMenusV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusV2EN SetcreatedAt(this clsQxPrjMenusV2EN objQxPrjMenusV2EN, string strcreatedAt, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strcreatedAt, 20, conQxPrjMenusV2.createdAt);
}
objQxPrjMenusV2EN.createdAt = strcreatedAt; //建立时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusV2EN.dicFldComparisonOp.ContainsKey(conQxPrjMenusV2.createdAt) == false)
{
objQxPrjMenusV2EN.dicFldComparisonOp.Add(conQxPrjMenusV2.createdAt, strComparisonOp);
}
else
{
objQxPrjMenusV2EN.dicFldComparisonOp[conQxPrjMenusV2.createdAt] = strComparisonOp;
}
}
return objQxPrjMenusV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusV2EN SetupdatedAt(this clsQxPrjMenusV2EN objQxPrjMenusV2EN, string strupdatedAt, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strupdatedAt, 20, conQxPrjMenusV2.updatedAt);
}
objQxPrjMenusV2EN.updatedAt = strupdatedAt; //修改时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusV2EN.dicFldComparisonOp.ContainsKey(conQxPrjMenusV2.updatedAt) == false)
{
objQxPrjMenusV2EN.dicFldComparisonOp.Add(conQxPrjMenusV2.updatedAt, strComparisonOp);
}
else
{
objQxPrjMenusV2EN.dicFldComparisonOp[conQxPrjMenusV2.updatedAt] = strComparisonOp;
}
}
return objQxPrjMenusV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusV2EN Setid(this clsQxPrjMenusV2EN objQxPrjMenusV2EN, int intid, string strComparisonOp="")
	{
objQxPrjMenusV2EN.id = intid; //id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusV2EN.dicFldComparisonOp.ContainsKey(conQxPrjMenusV2.id) == false)
{
objQxPrjMenusV2EN.dicFldComparisonOp.Add(conQxPrjMenusV2.id, strComparisonOp);
}
else
{
objQxPrjMenusV2EN.dicFldComparisonOp[conQxPrjMenusV2.id] = strComparisonOp;
}
}
return objQxPrjMenusV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusV2EN SetparentMenuId(this clsQxPrjMenusV2EN objQxPrjMenusV2EN, int? intparentMenuId, string strComparisonOp="")
	{
objQxPrjMenusV2EN.parentMenuId = intparentMenuId; //上级菜单Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusV2EN.dicFldComparisonOp.ContainsKey(conQxPrjMenusV2.parentMenuId) == false)
{
objQxPrjMenusV2EN.dicFldComparisonOp.Add(conQxPrjMenusV2.parentMenuId, strComparisonOp);
}
else
{
objQxPrjMenusV2EN.dicFldComparisonOp[conQxPrjMenusV2.parentMenuId] = strComparisonOp;
}
}
return objQxPrjMenusV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusV2EN SetMenuName(this clsQxPrjMenusV2EN objQxPrjMenusV2EN, string strMenuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMenuName, conQxPrjMenusV2.MenuName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuName, 50, conQxPrjMenusV2.MenuName);
}
objQxPrjMenusV2EN.MenuName = strMenuName; //菜单名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusV2EN.dicFldComparisonOp.ContainsKey(conQxPrjMenusV2.MenuName) == false)
{
objQxPrjMenusV2EN.dicFldComparisonOp.Add(conQxPrjMenusV2.MenuName, strComparisonOp);
}
else
{
objQxPrjMenusV2EN.dicFldComparisonOp[conQxPrjMenusV2.MenuName] = strComparisonOp;
}
}
return objQxPrjMenusV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusV2EN Setrouter(this clsQxPrjMenusV2EN objQxPrjMenusV2EN, string strrouter, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strrouter, 500, conQxPrjMenusV2.router);
}
objQxPrjMenusV2EN.router = strrouter; //链接文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusV2EN.dicFldComparisonOp.ContainsKey(conQxPrjMenusV2.router) == false)
{
objQxPrjMenusV2EN.dicFldComparisonOp.Add(conQxPrjMenusV2.router, strComparisonOp);
}
else
{
objQxPrjMenusV2EN.dicFldComparisonOp[conQxPrjMenusV2.router] = strComparisonOp;
}
}
return objQxPrjMenusV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusV2EN Setperms(this clsQxPrjMenusV2EN objQxPrjMenusV2EN, string strperms, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strperms, 500, conQxPrjMenusV2.perms);
}
objQxPrjMenusV2EN.perms = strperms; //链接文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusV2EN.dicFldComparisonOp.ContainsKey(conQxPrjMenusV2.perms) == false)
{
objQxPrjMenusV2EN.dicFldComparisonOp.Add(conQxPrjMenusV2.perms, strComparisonOp);
}
else
{
objQxPrjMenusV2EN.dicFldComparisonOp[conQxPrjMenusV2.perms] = strComparisonOp;
}
}
return objQxPrjMenusV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusV2EN Settype(this clsQxPrjMenusV2EN objQxPrjMenusV2EN, int inttype, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(inttype, conQxPrjMenusV2.type);
objQxPrjMenusV2EN.type = inttype; //排序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusV2EN.dicFldComparisonOp.ContainsKey(conQxPrjMenusV2.type) == false)
{
objQxPrjMenusV2EN.dicFldComparisonOp.Add(conQxPrjMenusV2.type, strComparisonOp);
}
else
{
objQxPrjMenusV2EN.dicFldComparisonOp[conQxPrjMenusV2.type] = strComparisonOp;
}
}
return objQxPrjMenusV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusV2EN Seticon(this clsQxPrjMenusV2EN objQxPrjMenusV2EN, string stricon, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(stricon, 500, conQxPrjMenusV2.icon);
}
objQxPrjMenusV2EN.icon = stricon; //链接文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusV2EN.dicFldComparisonOp.ContainsKey(conQxPrjMenusV2.icon) == false)
{
objQxPrjMenusV2EN.dicFldComparisonOp.Add(conQxPrjMenusV2.icon, strComparisonOp);
}
else
{
objQxPrjMenusV2EN.dicFldComparisonOp[conQxPrjMenusV2.icon] = strComparisonOp;
}
}
return objQxPrjMenusV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusV2EN SetOrderNum(this clsQxPrjMenusV2EN objQxPrjMenusV2EN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, conQxPrjMenusV2.OrderNum);
objQxPrjMenusV2EN.OrderNum = intOrderNum; //排序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusV2EN.dicFldComparisonOp.ContainsKey(conQxPrjMenusV2.OrderNum) == false)
{
objQxPrjMenusV2EN.dicFldComparisonOp.Add(conQxPrjMenusV2.OrderNum, strComparisonOp);
}
else
{
objQxPrjMenusV2EN.dicFldComparisonOp[conQxPrjMenusV2.OrderNum] = strComparisonOp;
}
}
return objQxPrjMenusV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusV2EN SetviewPath(this clsQxPrjMenusV2EN objQxPrjMenusV2EN, string strviewPath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strviewPath, 300, conQxPrjMenusV2.viewPath);
}
objQxPrjMenusV2EN.viewPath = strviewPath; //图像文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusV2EN.dicFldComparisonOp.ContainsKey(conQxPrjMenusV2.viewPath) == false)
{
objQxPrjMenusV2EN.dicFldComparisonOp.Add(conQxPrjMenusV2.viewPath, strComparisonOp);
}
else
{
objQxPrjMenusV2EN.dicFldComparisonOp[conQxPrjMenusV2.viewPath] = strComparisonOp;
}
}
return objQxPrjMenusV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusV2EN Setkeepalive(this clsQxPrjMenusV2EN objQxPrjMenusV2EN, bool bolkeepalive, string strComparisonOp="")
	{
objQxPrjMenusV2EN.keepalive = bolkeepalive; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusV2EN.dicFldComparisonOp.ContainsKey(conQxPrjMenusV2.keepalive) == false)
{
objQxPrjMenusV2EN.dicFldComparisonOp.Add(conQxPrjMenusV2.keepalive, strComparisonOp);
}
else
{
objQxPrjMenusV2EN.dicFldComparisonOp[conQxPrjMenusV2.keepalive] = strComparisonOp;
}
}
return objQxPrjMenusV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusV2EN SetisShow(this clsQxPrjMenusV2EN objQxPrjMenusV2EN, bool bolisShow, string strComparisonOp="")
	{
objQxPrjMenusV2EN.isShow = bolisShow; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusV2EN.dicFldComparisonOp.ContainsKey(conQxPrjMenusV2.isShow) == false)
{
objQxPrjMenusV2EN.dicFldComparisonOp.Add(conQxPrjMenusV2.isShow, strComparisonOp);
}
else
{
objQxPrjMenusV2EN.dicFldComparisonOp[conQxPrjMenusV2.isShow] = strComparisonOp;
}
}
return objQxPrjMenusV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusV2EN SetisExt(this clsQxPrjMenusV2EN objQxPrjMenusV2EN, bool bolisExt, string strComparisonOp="")
	{
objQxPrjMenusV2EN.isExt = bolisExt; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusV2EN.dicFldComparisonOp.ContainsKey(conQxPrjMenusV2.isExt) == false)
{
objQxPrjMenusV2EN.dicFldComparisonOp.Add(conQxPrjMenusV2.isExt, strComparisonOp);
}
else
{
objQxPrjMenusV2EN.dicFldComparisonOp[conQxPrjMenusV2.isExt] = strComparisonOp;
}
}
return objQxPrjMenusV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusV2EN SetopenMode(this clsQxPrjMenusV2EN objQxPrjMenusV2EN, int intopenMode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intopenMode, conQxPrjMenusV2.openMode);
objQxPrjMenusV2EN.openMode = intopenMode; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusV2EN.dicFldComparisonOp.ContainsKey(conQxPrjMenusV2.openMode) == false)
{
objQxPrjMenusV2EN.dicFldComparisonOp.Add(conQxPrjMenusV2.openMode, strComparisonOp);
}
else
{
objQxPrjMenusV2EN.dicFldComparisonOp[conQxPrjMenusV2.openMode] = strComparisonOp;
}
}
return objQxPrjMenusV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusV2EN SetQxPrjId(this clsQxPrjMenusV2EN objQxPrjMenusV2EN, string strQxPrjId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQxPrjId, 4, conQxPrjMenusV2.QxPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, conQxPrjMenusV2.QxPrjId);
}
objQxPrjMenusV2EN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusV2EN.dicFldComparisonOp.ContainsKey(conQxPrjMenusV2.QxPrjId) == false)
{
objQxPrjMenusV2EN.dicFldComparisonOp.Add(conQxPrjMenusV2.QxPrjId, strComparisonOp);
}
else
{
objQxPrjMenusV2EN.dicFldComparisonOp[conQxPrjMenusV2.QxPrjId] = strComparisonOp;
}
}
return objQxPrjMenusV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusV2EN SetUpdUserId(this clsQxPrjMenusV2EN objQxPrjMenusV2EN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conQxPrjMenusV2.UpdUserId);
}
objQxPrjMenusV2EN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusV2EN.dicFldComparisonOp.ContainsKey(conQxPrjMenusV2.UpdUserId) == false)
{
objQxPrjMenusV2EN.dicFldComparisonOp.Add(conQxPrjMenusV2.UpdUserId, strComparisonOp);
}
else
{
objQxPrjMenusV2EN.dicFldComparisonOp[conQxPrjMenusV2.UpdUserId] = strComparisonOp;
}
}
return objQxPrjMenusV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusV2EN SetMemo(this clsQxPrjMenusV2EN objQxPrjMenusV2EN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQxPrjMenusV2.Memo);
}
objQxPrjMenusV2EN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusV2EN.dicFldComparisonOp.ContainsKey(conQxPrjMenusV2.Memo) == false)
{
objQxPrjMenusV2EN.dicFldComparisonOp.Add(conQxPrjMenusV2.Memo, strComparisonOp);
}
else
{
objQxPrjMenusV2EN.dicFldComparisonOp[conQxPrjMenusV2.Memo] = strComparisonOp;
}
}
return objQxPrjMenusV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusV2EN SetLinkFile(this clsQxPrjMenusV2EN objQxPrjMenusV2EN, string strLinkFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLinkFile, 500, conQxPrjMenusV2.LinkFile);
}
objQxPrjMenusV2EN.LinkFile = strLinkFile; //链接文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusV2EN.dicFldComparisonOp.ContainsKey(conQxPrjMenusV2.LinkFile) == false)
{
objQxPrjMenusV2EN.dicFldComparisonOp.Add(conQxPrjMenusV2.LinkFile, strComparisonOp);
}
else
{
objQxPrjMenusV2EN.dicFldComparisonOp[conQxPrjMenusV2.LinkFile] = strComparisonOp;
}
}
return objQxPrjMenusV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusV2EN SetUpdDate(this clsQxPrjMenusV2EN objQxPrjMenusV2EN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQxPrjMenusV2.UpdDate);
}
objQxPrjMenusV2EN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusV2EN.dicFldComparisonOp.ContainsKey(conQxPrjMenusV2.UpdDate) == false)
{
objQxPrjMenusV2EN.dicFldComparisonOp.Add(conQxPrjMenusV2.UpdDate, strComparisonOp);
}
else
{
objQxPrjMenusV2EN.dicFldComparisonOp[conQxPrjMenusV2.UpdDate] = strComparisonOp;
}
}
return objQxPrjMenusV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusV2EN SetMenuControlName(this clsQxPrjMenusV2EN objQxPrjMenusV2EN, string strMenuControlName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuControlName, 100, conQxPrjMenusV2.MenuControlName);
}
objQxPrjMenusV2EN.MenuControlName = strMenuControlName; //MenuControlName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusV2EN.dicFldComparisonOp.ContainsKey(conQxPrjMenusV2.MenuControlName) == false)
{
objQxPrjMenusV2EN.dicFldComparisonOp.Add(conQxPrjMenusV2.MenuControlName, strComparisonOp);
}
else
{
objQxPrjMenusV2EN.dicFldComparisonOp[conQxPrjMenusV2.MenuControlName] = strComparisonOp;
}
}
return objQxPrjMenusV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusV2EN SetApplicationTypeId(this clsQxPrjMenusV2EN objQxPrjMenusV2EN, int? intApplicationTypeId, string strComparisonOp="")
	{
objQxPrjMenusV2EN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusV2EN.dicFldComparisonOp.ContainsKey(conQxPrjMenusV2.ApplicationTypeId) == false)
{
objQxPrjMenusV2EN.dicFldComparisonOp.Add(conQxPrjMenusV2.ApplicationTypeId, strComparisonOp);
}
else
{
objQxPrjMenusV2EN.dicFldComparisonOp[conQxPrjMenusV2.ApplicationTypeId] = strComparisonOp;
}
}
return objQxPrjMenusV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusV2EN SetMenuTitle(this clsQxPrjMenusV2EN objQxPrjMenusV2EN, string strMenuTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuTitle, 50, conQxPrjMenusV2.MenuTitle);
}
objQxPrjMenusV2EN.MenuTitle = strMenuTitle; //菜单标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusV2EN.dicFldComparisonOp.ContainsKey(conQxPrjMenusV2.MenuTitle) == false)
{
objQxPrjMenusV2EN.dicFldComparisonOp.Add(conQxPrjMenusV2.MenuTitle, strComparisonOp);
}
else
{
objQxPrjMenusV2EN.dicFldComparisonOp[conQxPrjMenusV2.MenuTitle] = strComparisonOp;
}
}
return objQxPrjMenusV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusV2EN SetPageDispModeId(this clsQxPrjMenusV2EN objQxPrjMenusV2EN, string strPageDispModeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPageDispModeId, 2, conQxPrjMenusV2.PageDispModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPageDispModeId, 2, conQxPrjMenusV2.PageDispModeId);
}
objQxPrjMenusV2EN.PageDispModeId = strPageDispModeId; //页面显示模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusV2EN.dicFldComparisonOp.ContainsKey(conQxPrjMenusV2.PageDispModeId) == false)
{
objQxPrjMenusV2EN.dicFldComparisonOp.Add(conQxPrjMenusV2.PageDispModeId, strComparisonOp);
}
else
{
objQxPrjMenusV2EN.dicFldComparisonOp[conQxPrjMenusV2.PageDispModeId] = strComparisonOp;
}
}
return objQxPrjMenusV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusV2EN SetInUse(this clsQxPrjMenusV2EN objQxPrjMenusV2EN, bool bolInUse, string strComparisonOp="")
	{
objQxPrjMenusV2EN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusV2EN.dicFldComparisonOp.ContainsKey(conQxPrjMenusV2.InUse) == false)
{
objQxPrjMenusV2EN.dicFldComparisonOp.Add(conQxPrjMenusV2.InUse, strComparisonOp);
}
else
{
objQxPrjMenusV2EN.dicFldComparisonOp[conQxPrjMenusV2.InUse] = strComparisonOp;
}
}
return objQxPrjMenusV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusV2EN SetqsParameters(this clsQxPrjMenusV2EN objQxPrjMenusV2EN, string strqsParameters, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strqsParameters, 200, conQxPrjMenusV2.qsParameters);
}
objQxPrjMenusV2EN.qsParameters = strqsParameters; //qs参数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusV2EN.dicFldComparisonOp.ContainsKey(conQxPrjMenusV2.qsParameters) == false)
{
objQxPrjMenusV2EN.dicFldComparisonOp.Add(conQxPrjMenusV2.qsParameters, strComparisonOp);
}
else
{
objQxPrjMenusV2EN.dicFldComparisonOp[conQxPrjMenusV2.qsParameters] = strComparisonOp;
}
}
return objQxPrjMenusV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusV2EN SetImgFile(this clsQxPrjMenusV2EN objQxPrjMenusV2EN, string strImgFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strImgFile, 300, conQxPrjMenusV2.ImgFile);
}
objQxPrjMenusV2EN.ImgFile = strImgFile; //图像文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusV2EN.dicFldComparisonOp.ContainsKey(conQxPrjMenusV2.ImgFile) == false)
{
objQxPrjMenusV2EN.dicFldComparisonOp.Add(conQxPrjMenusV2.ImgFile, strComparisonOp);
}
else
{
objQxPrjMenusV2EN.dicFldComparisonOp[conQxPrjMenusV2.ImgFile] = strComparisonOp;
}
}
return objQxPrjMenusV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusV2EN SetTabId(this clsQxPrjMenusV2EN objQxPrjMenusV2EN, string strTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, conQxPrjMenusV2.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, conQxPrjMenusV2.TabId);
}
objQxPrjMenusV2EN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusV2EN.dicFldComparisonOp.ContainsKey(conQxPrjMenusV2.TabId) == false)
{
objQxPrjMenusV2EN.dicFldComparisonOp.Add(conQxPrjMenusV2.TabId, strComparisonOp);
}
else
{
objQxPrjMenusV2EN.dicFldComparisonOp[conQxPrjMenusV2.TabId] = strComparisonOp;
}
}
return objQxPrjMenusV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusV2EN SetRoleId(this clsQxPrjMenusV2EN objQxPrjMenusV2EN, string strRoleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRoleId, 8, conQxPrjMenusV2.RoleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, conQxPrjMenusV2.RoleId);
}
objQxPrjMenusV2EN.RoleId = strRoleId; //角色Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusV2EN.dicFldComparisonOp.ContainsKey(conQxPrjMenusV2.RoleId) == false)
{
objQxPrjMenusV2EN.dicFldComparisonOp.Add(conQxPrjMenusV2.RoleId, strComparisonOp);
}
else
{
objQxPrjMenusV2EN.dicFldComparisonOp[conQxPrjMenusV2.RoleId] = strComparisonOp;
}
}
return objQxPrjMenusV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusV2EN SetIsLeafNode(this clsQxPrjMenusV2EN objQxPrjMenusV2EN, bool bolIsLeafNode, string strComparisonOp="")
	{
objQxPrjMenusV2EN.IsLeafNode = bolIsLeafNode; //是否叶子
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusV2EN.dicFldComparisonOp.ContainsKey(conQxPrjMenusV2.IsLeafNode) == false)
{
objQxPrjMenusV2EN.dicFldComparisonOp.Add(conQxPrjMenusV2.IsLeafNode, strComparisonOp);
}
else
{
objQxPrjMenusV2EN.dicFldComparisonOp[conQxPrjMenusV2.IsLeafNode] = strComparisonOp;
}
}
return objQxPrjMenusV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusV2EN SetMenuSetId(this clsQxPrjMenusV2EN objQxPrjMenusV2EN, string strMenuSetId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuSetId, 4, conQxPrjMenusV2.MenuSetId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMenuSetId, 4, conQxPrjMenusV2.MenuSetId);
}
objQxPrjMenusV2EN.MenuSetId = strMenuSetId; //菜单集Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusV2EN.dicFldComparisonOp.ContainsKey(conQxPrjMenusV2.MenuSetId) == false)
{
objQxPrjMenusV2EN.dicFldComparisonOp.Add(conQxPrjMenusV2.MenuSetId, strComparisonOp);
}
else
{
objQxPrjMenusV2EN.dicFldComparisonOp[conQxPrjMenusV2.MenuSetId] = strComparisonOp;
}
}
return objQxPrjMenusV2EN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objQxPrjMenusV2EN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsQxPrjMenusV2EN objQxPrjMenusV2EN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objQxPrjMenusV2EN.CheckPropertyNew();
clsQxPrjMenusV2EN objQxPrjMenusV2Cond = new clsQxPrjMenusV2EN();
string strCondition = objQxPrjMenusV2Cond
.Setid(objQxPrjMenusV2EN.id, "<>")
.SetMenuName(objQxPrjMenusV2EN.MenuName, "=")
.SetQxPrjId(objQxPrjMenusV2EN.QxPrjId, "=")
.SetMenuSetId(objQxPrjMenusV2EN.MenuSetId, "=")
.GetCombineCondition();
objQxPrjMenusV2EN._IsCheckProperty = true;
bool bolIsExist = clsQxPrjMenusV2BL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(MenuName_QxPrjId_MenuSetId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objQxPrjMenusV2EN.Update();
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
 /// <param name = "objQxPrjMenusV2">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsQxPrjMenusV2EN objQxPrjMenusV2)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsQxPrjMenusV2EN objQxPrjMenusV2Cond = new clsQxPrjMenusV2EN();
string strCondition = objQxPrjMenusV2Cond
.SetMenuName(objQxPrjMenusV2.MenuName, "=")
.SetQxPrjId(objQxPrjMenusV2.QxPrjId, "=")
.SetMenuSetId(objQxPrjMenusV2.MenuSetId, "=")
.GetCombineCondition();
objQxPrjMenusV2._IsCheckProperty = true;
bool bolIsExist = clsQxPrjMenusV2BL.IsExistRecord(strCondition);
if (bolIsExist)
{
objQxPrjMenusV2.id = clsQxPrjMenusV2BL.GetFirstID_S(strCondition);
objQxPrjMenusV2.UpdateWithCondition(strCondition);
}
else
{
objQxPrjMenusV2.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objQxPrjMenusV2EN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxPrjMenusV2EN objQxPrjMenusV2EN)
{
 if (objQxPrjMenusV2EN.id == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxPrjMenusV2BL.QxPrjMenusV2DA.UpdateBySql2(objQxPrjMenusV2EN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjMenusV2BL.ReFreshCache(objQxPrjMenusV2EN.QxPrjId);

if (clsQxPrjMenusV2BL.relatedActions != null)
{
clsQxPrjMenusV2BL.relatedActions.UpdRelaTabDate(objQxPrjMenusV2EN.id, objQxPrjMenusV2EN.UpdUserId);
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
 /// <param name = "objQxPrjMenusV2EN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxPrjMenusV2EN objQxPrjMenusV2EN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objQxPrjMenusV2EN.id == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxPrjMenusV2BL.QxPrjMenusV2DA.UpdateBySql2(objQxPrjMenusV2EN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjMenusV2BL.ReFreshCache(objQxPrjMenusV2EN.QxPrjId);

if (clsQxPrjMenusV2BL.relatedActions != null)
{
clsQxPrjMenusV2BL.relatedActions.UpdRelaTabDate(objQxPrjMenusV2EN.id, objQxPrjMenusV2EN.UpdUserId);
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
 /// <param name = "objQxPrjMenusV2EN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxPrjMenusV2EN objQxPrjMenusV2EN, string strWhereCond)
{
try
{
bool bolResult = clsQxPrjMenusV2BL.QxPrjMenusV2DA.UpdateBySqlWithCondition(objQxPrjMenusV2EN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjMenusV2BL.ReFreshCache(objQxPrjMenusV2EN.QxPrjId);

if (clsQxPrjMenusV2BL.relatedActions != null)
{
clsQxPrjMenusV2BL.relatedActions.UpdRelaTabDate(objQxPrjMenusV2EN.id, objQxPrjMenusV2EN.UpdUserId);
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
 /// <param name = "objQxPrjMenusV2EN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxPrjMenusV2EN objQxPrjMenusV2EN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsQxPrjMenusV2BL.QxPrjMenusV2DA.UpdateBySqlWithConditionTransaction(objQxPrjMenusV2EN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjMenusV2BL.ReFreshCache(objQxPrjMenusV2EN.QxPrjId);

if (clsQxPrjMenusV2BL.relatedActions != null)
{
clsQxPrjMenusV2BL.relatedActions.UpdRelaTabDate(objQxPrjMenusV2EN.id, objQxPrjMenusV2EN.UpdUserId);
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
 /// <param name = "intid">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsQxPrjMenusV2EN objQxPrjMenusV2EN)
{
try
{
int intRecNum = clsQxPrjMenusV2BL.QxPrjMenusV2DA.DelRecord(objQxPrjMenusV2EN.id);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjMenusV2BL.ReFreshCache(objQxPrjMenusV2EN.QxPrjId);

if (clsQxPrjMenusV2BL.relatedActions != null)
{
clsQxPrjMenusV2BL.relatedActions.UpdRelaTabDate(objQxPrjMenusV2EN.id, objQxPrjMenusV2EN.UpdUserId);
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
 /// <param name = "objQxPrjMenusV2ENS">源对象</param>
 /// <param name = "objQxPrjMenusV2ENT">目标对象</param>
 public static void CopyTo(this clsQxPrjMenusV2EN objQxPrjMenusV2ENS, clsQxPrjMenusV2EN objQxPrjMenusV2ENT)
{
try
{
objQxPrjMenusV2ENT.createdAt = objQxPrjMenusV2ENS.createdAt; //建立时间
objQxPrjMenusV2ENT.updatedAt = objQxPrjMenusV2ENS.updatedAt; //修改时间
objQxPrjMenusV2ENT.id = objQxPrjMenusV2ENS.id; //id
objQxPrjMenusV2ENT.parentMenuId = objQxPrjMenusV2ENS.parentMenuId; //上级菜单Id
objQxPrjMenusV2ENT.MenuName = objQxPrjMenusV2ENS.MenuName; //菜单名
objQxPrjMenusV2ENT.router = objQxPrjMenusV2ENS.router; //链接文件
objQxPrjMenusV2ENT.perms = objQxPrjMenusV2ENS.perms; //链接文件
objQxPrjMenusV2ENT.type = objQxPrjMenusV2ENS.type; //排序号
objQxPrjMenusV2ENT.icon = objQxPrjMenusV2ENS.icon; //链接文件
objQxPrjMenusV2ENT.OrderNum = objQxPrjMenusV2ENS.OrderNum; //排序号
objQxPrjMenusV2ENT.viewPath = objQxPrjMenusV2ENS.viewPath; //图像文件
objQxPrjMenusV2ENT.keepalive = objQxPrjMenusV2ENS.keepalive; //是否在用
objQxPrjMenusV2ENT.isShow = objQxPrjMenusV2ENS.isShow; //是否在用
objQxPrjMenusV2ENT.isExt = objQxPrjMenusV2ENS.isExt; //是否在用
objQxPrjMenusV2ENT.openMode = objQxPrjMenusV2ENS.openMode; //应用程序类型ID
objQxPrjMenusV2ENT.QxPrjId = objQxPrjMenusV2ENS.QxPrjId; //项目Id
objQxPrjMenusV2ENT.UpdUserId = objQxPrjMenusV2ENS.UpdUserId; //修改用户Id
objQxPrjMenusV2ENT.Memo = objQxPrjMenusV2ENS.Memo; //备注
objQxPrjMenusV2ENT.LinkFile = objQxPrjMenusV2ENS.LinkFile; //链接文件
objQxPrjMenusV2ENT.UpdDate = objQxPrjMenusV2ENS.UpdDate; //修改日期
objQxPrjMenusV2ENT.MenuControlName = objQxPrjMenusV2ENS.MenuControlName; //MenuControlName
objQxPrjMenusV2ENT.ApplicationTypeId = objQxPrjMenusV2ENS.ApplicationTypeId; //应用程序类型ID
objQxPrjMenusV2ENT.MenuTitle = objQxPrjMenusV2ENS.MenuTitle; //菜单标题
objQxPrjMenusV2ENT.PageDispModeId = objQxPrjMenusV2ENS.PageDispModeId; //页面显示模式Id
objQxPrjMenusV2ENT.InUse = objQxPrjMenusV2ENS.InUse; //是否在用
objQxPrjMenusV2ENT.qsParameters = objQxPrjMenusV2ENS.qsParameters; //qs参数
objQxPrjMenusV2ENT.ImgFile = objQxPrjMenusV2ENS.ImgFile; //图像文件
objQxPrjMenusV2ENT.TabId = objQxPrjMenusV2ENS.TabId; //表ID
objQxPrjMenusV2ENT.RoleId = objQxPrjMenusV2ENS.RoleId; //角色Id
objQxPrjMenusV2ENT.IsLeafNode = objQxPrjMenusV2ENS.IsLeafNode; //是否叶子
objQxPrjMenusV2ENT.MenuSetId = objQxPrjMenusV2ENS.MenuSetId; //菜单集Id
objQxPrjMenusV2ENT.MenuIdOld = objQxPrjMenusV2ENS.MenuIdOld; //MenuIdOld
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
 /// <param name = "objQxPrjMenusV2ENS">源对象</param>
 /// <returns>目标对象=>clsQxPrjMenusV2EN:objQxPrjMenusV2ENT</returns>
 public static clsQxPrjMenusV2EN CopyTo(this clsQxPrjMenusV2EN objQxPrjMenusV2ENS)
{
try
{
 clsQxPrjMenusV2EN objQxPrjMenusV2ENT = new clsQxPrjMenusV2EN()
{
createdAt = objQxPrjMenusV2ENS.createdAt, //建立时间
updatedAt = objQxPrjMenusV2ENS.updatedAt, //修改时间
id = objQxPrjMenusV2ENS.id, //id
parentMenuId = objQxPrjMenusV2ENS.parentMenuId, //上级菜单Id
MenuName = objQxPrjMenusV2ENS.MenuName, //菜单名
router = objQxPrjMenusV2ENS.router, //链接文件
perms = objQxPrjMenusV2ENS.perms, //链接文件
type = objQxPrjMenusV2ENS.type, //排序号
icon = objQxPrjMenusV2ENS.icon, //链接文件
OrderNum = objQxPrjMenusV2ENS.OrderNum, //排序号
viewPath = objQxPrjMenusV2ENS.viewPath, //图像文件
keepalive = objQxPrjMenusV2ENS.keepalive, //是否在用
isShow = objQxPrjMenusV2ENS.isShow, //是否在用
isExt = objQxPrjMenusV2ENS.isExt, //是否在用
openMode = objQxPrjMenusV2ENS.openMode, //应用程序类型ID
QxPrjId = objQxPrjMenusV2ENS.QxPrjId, //项目Id
UpdUserId = objQxPrjMenusV2ENS.UpdUserId, //修改用户Id
Memo = objQxPrjMenusV2ENS.Memo, //备注
LinkFile = objQxPrjMenusV2ENS.LinkFile, //链接文件
UpdDate = objQxPrjMenusV2ENS.UpdDate, //修改日期
MenuControlName = objQxPrjMenusV2ENS.MenuControlName, //MenuControlName
ApplicationTypeId = objQxPrjMenusV2ENS.ApplicationTypeId, //应用程序类型ID
MenuTitle = objQxPrjMenusV2ENS.MenuTitle, //菜单标题
PageDispModeId = objQxPrjMenusV2ENS.PageDispModeId, //页面显示模式Id
InUse = objQxPrjMenusV2ENS.InUse, //是否在用
qsParameters = objQxPrjMenusV2ENS.qsParameters, //qs参数
ImgFile = objQxPrjMenusV2ENS.ImgFile, //图像文件
TabId = objQxPrjMenusV2ENS.TabId, //表ID
RoleId = objQxPrjMenusV2ENS.RoleId, //角色Id
IsLeafNode = objQxPrjMenusV2ENS.IsLeafNode, //是否叶子
MenuSetId = objQxPrjMenusV2ENS.MenuSetId, //菜单集Id
MenuIdOld = objQxPrjMenusV2ENS.MenuIdOld, //MenuIdOld
};
 return objQxPrjMenusV2ENT;
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
public static void CheckPropertyNew(this clsQxPrjMenusV2EN objQxPrjMenusV2EN)
{
 clsQxPrjMenusV2BL.QxPrjMenusV2DA.CheckPropertyNew(objQxPrjMenusV2EN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsQxPrjMenusV2EN objQxPrjMenusV2EN)
{
 clsQxPrjMenusV2BL.QxPrjMenusV2DA.CheckProperty4Condition(objQxPrjMenusV2EN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQxPrjMenusV2EN objQxPrjMenusV2Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQxPrjMenusV2Cond.IsUpdated(conQxPrjMenusV2.createdAt) == true)
{
string strComparisonOpcreatedAt = objQxPrjMenusV2Cond.dicFldComparisonOp[conQxPrjMenusV2.createdAt];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenusV2.createdAt, objQxPrjMenusV2Cond.createdAt, strComparisonOpcreatedAt);
}
if (objQxPrjMenusV2Cond.IsUpdated(conQxPrjMenusV2.updatedAt) == true)
{
string strComparisonOpupdatedAt = objQxPrjMenusV2Cond.dicFldComparisonOp[conQxPrjMenusV2.updatedAt];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenusV2.updatedAt, objQxPrjMenusV2Cond.updatedAt, strComparisonOpupdatedAt);
}
if (objQxPrjMenusV2Cond.IsUpdated(conQxPrjMenusV2.id) == true)
{
string strComparisonOpid = objQxPrjMenusV2Cond.dicFldComparisonOp[conQxPrjMenusV2.id];
strWhereCond += string.Format(" And {0} {2} {1}", conQxPrjMenusV2.id, objQxPrjMenusV2Cond.id, strComparisonOpid);
}
if (objQxPrjMenusV2Cond.IsUpdated(conQxPrjMenusV2.parentMenuId) == true)
{
string strComparisonOpparentMenuId = objQxPrjMenusV2Cond.dicFldComparisonOp[conQxPrjMenusV2.parentMenuId];
strWhereCond += string.Format(" And {0} {2} {1}", conQxPrjMenusV2.parentMenuId, objQxPrjMenusV2Cond.parentMenuId, strComparisonOpparentMenuId);
}
if (objQxPrjMenusV2Cond.IsUpdated(conQxPrjMenusV2.MenuName) == true)
{
string strComparisonOpMenuName = objQxPrjMenusV2Cond.dicFldComparisonOp[conQxPrjMenusV2.MenuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenusV2.MenuName, objQxPrjMenusV2Cond.MenuName, strComparisonOpMenuName);
}
if (objQxPrjMenusV2Cond.IsUpdated(conQxPrjMenusV2.router) == true)
{
string strComparisonOprouter = objQxPrjMenusV2Cond.dicFldComparisonOp[conQxPrjMenusV2.router];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenusV2.router, objQxPrjMenusV2Cond.router, strComparisonOprouter);
}
if (objQxPrjMenusV2Cond.IsUpdated(conQxPrjMenusV2.perms) == true)
{
string strComparisonOpperms = objQxPrjMenusV2Cond.dicFldComparisonOp[conQxPrjMenusV2.perms];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenusV2.perms, objQxPrjMenusV2Cond.perms, strComparisonOpperms);
}
if (objQxPrjMenusV2Cond.IsUpdated(conQxPrjMenusV2.type) == true)
{
string strComparisonOptype = objQxPrjMenusV2Cond.dicFldComparisonOp[conQxPrjMenusV2.type];
strWhereCond += string.Format(" And {0} {2} {1}", conQxPrjMenusV2.type, objQxPrjMenusV2Cond.type, strComparisonOptype);
}
if (objQxPrjMenusV2Cond.IsUpdated(conQxPrjMenusV2.icon) == true)
{
string strComparisonOpicon = objQxPrjMenusV2Cond.dicFldComparisonOp[conQxPrjMenusV2.icon];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenusV2.icon, objQxPrjMenusV2Cond.icon, strComparisonOpicon);
}
if (objQxPrjMenusV2Cond.IsUpdated(conQxPrjMenusV2.OrderNum) == true)
{
string strComparisonOpOrderNum = objQxPrjMenusV2Cond.dicFldComparisonOp[conQxPrjMenusV2.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conQxPrjMenusV2.OrderNum, objQxPrjMenusV2Cond.OrderNum, strComparisonOpOrderNum);
}
if (objQxPrjMenusV2Cond.IsUpdated(conQxPrjMenusV2.viewPath) == true)
{
string strComparisonOpviewPath = objQxPrjMenusV2Cond.dicFldComparisonOp[conQxPrjMenusV2.viewPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenusV2.viewPath, objQxPrjMenusV2Cond.viewPath, strComparisonOpviewPath);
}
if (objQxPrjMenusV2Cond.IsUpdated(conQxPrjMenusV2.keepalive) == true)
{
if (objQxPrjMenusV2Cond.keepalive == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQxPrjMenusV2.keepalive);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQxPrjMenusV2.keepalive);
}
}
if (objQxPrjMenusV2Cond.IsUpdated(conQxPrjMenusV2.isShow) == true)
{
if (objQxPrjMenusV2Cond.isShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQxPrjMenusV2.isShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQxPrjMenusV2.isShow);
}
}
if (objQxPrjMenusV2Cond.IsUpdated(conQxPrjMenusV2.isExt) == true)
{
if (objQxPrjMenusV2Cond.isExt == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQxPrjMenusV2.isExt);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQxPrjMenusV2.isExt);
}
}
if (objQxPrjMenusV2Cond.IsUpdated(conQxPrjMenusV2.openMode) == true)
{
string strComparisonOpopenMode = objQxPrjMenusV2Cond.dicFldComparisonOp[conQxPrjMenusV2.openMode];
strWhereCond += string.Format(" And {0} {2} {1}", conQxPrjMenusV2.openMode, objQxPrjMenusV2Cond.openMode, strComparisonOpopenMode);
}
if (objQxPrjMenusV2Cond.IsUpdated(conQxPrjMenusV2.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objQxPrjMenusV2Cond.dicFldComparisonOp[conQxPrjMenusV2.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenusV2.QxPrjId, objQxPrjMenusV2Cond.QxPrjId, strComparisonOpQxPrjId);
}
if (objQxPrjMenusV2Cond.IsUpdated(conQxPrjMenusV2.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objQxPrjMenusV2Cond.dicFldComparisonOp[conQxPrjMenusV2.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenusV2.UpdUserId, objQxPrjMenusV2Cond.UpdUserId, strComparisonOpUpdUserId);
}
if (objQxPrjMenusV2Cond.IsUpdated(conQxPrjMenusV2.Memo) == true)
{
string strComparisonOpMemo = objQxPrjMenusV2Cond.dicFldComparisonOp[conQxPrjMenusV2.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenusV2.Memo, objQxPrjMenusV2Cond.Memo, strComparisonOpMemo);
}
if (objQxPrjMenusV2Cond.IsUpdated(conQxPrjMenusV2.LinkFile) == true)
{
string strComparisonOpLinkFile = objQxPrjMenusV2Cond.dicFldComparisonOp[conQxPrjMenusV2.LinkFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenusV2.LinkFile, objQxPrjMenusV2Cond.LinkFile, strComparisonOpLinkFile);
}
if (objQxPrjMenusV2Cond.IsUpdated(conQxPrjMenusV2.UpdDate) == true)
{
string strComparisonOpUpdDate = objQxPrjMenusV2Cond.dicFldComparisonOp[conQxPrjMenusV2.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenusV2.UpdDate, objQxPrjMenusV2Cond.UpdDate, strComparisonOpUpdDate);
}
if (objQxPrjMenusV2Cond.IsUpdated(conQxPrjMenusV2.MenuControlName) == true)
{
string strComparisonOpMenuControlName = objQxPrjMenusV2Cond.dicFldComparisonOp[conQxPrjMenusV2.MenuControlName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenusV2.MenuControlName, objQxPrjMenusV2Cond.MenuControlName, strComparisonOpMenuControlName);
}
if (objQxPrjMenusV2Cond.IsUpdated(conQxPrjMenusV2.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objQxPrjMenusV2Cond.dicFldComparisonOp[conQxPrjMenusV2.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", conQxPrjMenusV2.ApplicationTypeId, objQxPrjMenusV2Cond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objQxPrjMenusV2Cond.IsUpdated(conQxPrjMenusV2.MenuTitle) == true)
{
string strComparisonOpMenuTitle = objQxPrjMenusV2Cond.dicFldComparisonOp[conQxPrjMenusV2.MenuTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenusV2.MenuTitle, objQxPrjMenusV2Cond.MenuTitle, strComparisonOpMenuTitle);
}
if (objQxPrjMenusV2Cond.IsUpdated(conQxPrjMenusV2.PageDispModeId) == true)
{
string strComparisonOpPageDispModeId = objQxPrjMenusV2Cond.dicFldComparisonOp[conQxPrjMenusV2.PageDispModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenusV2.PageDispModeId, objQxPrjMenusV2Cond.PageDispModeId, strComparisonOpPageDispModeId);
}
if (objQxPrjMenusV2Cond.IsUpdated(conQxPrjMenusV2.InUse) == true)
{
if (objQxPrjMenusV2Cond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQxPrjMenusV2.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQxPrjMenusV2.InUse);
}
}
if (objQxPrjMenusV2Cond.IsUpdated(conQxPrjMenusV2.qsParameters) == true)
{
string strComparisonOpqsParameters = objQxPrjMenusV2Cond.dicFldComparisonOp[conQxPrjMenusV2.qsParameters];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenusV2.qsParameters, objQxPrjMenusV2Cond.qsParameters, strComparisonOpqsParameters);
}
if (objQxPrjMenusV2Cond.IsUpdated(conQxPrjMenusV2.ImgFile) == true)
{
string strComparisonOpImgFile = objQxPrjMenusV2Cond.dicFldComparisonOp[conQxPrjMenusV2.ImgFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenusV2.ImgFile, objQxPrjMenusV2Cond.ImgFile, strComparisonOpImgFile);
}
if (objQxPrjMenusV2Cond.IsUpdated(conQxPrjMenusV2.TabId) == true)
{
string strComparisonOpTabId = objQxPrjMenusV2Cond.dicFldComparisonOp[conQxPrjMenusV2.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenusV2.TabId, objQxPrjMenusV2Cond.TabId, strComparisonOpTabId);
}
if (objQxPrjMenusV2Cond.IsUpdated(conQxPrjMenusV2.RoleId) == true)
{
string strComparisonOpRoleId = objQxPrjMenusV2Cond.dicFldComparisonOp[conQxPrjMenusV2.RoleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenusV2.RoleId, objQxPrjMenusV2Cond.RoleId, strComparisonOpRoleId);
}
if (objQxPrjMenusV2Cond.IsUpdated(conQxPrjMenusV2.IsLeafNode) == true)
{
if (objQxPrjMenusV2Cond.IsLeafNode == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQxPrjMenusV2.IsLeafNode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQxPrjMenusV2.IsLeafNode);
}
}
if (objQxPrjMenusV2Cond.IsUpdated(conQxPrjMenusV2.MenuSetId) == true)
{
string strComparisonOpMenuSetId = objQxPrjMenusV2Cond.dicFldComparisonOp[conQxPrjMenusV2.MenuSetId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenusV2.MenuSetId, objQxPrjMenusV2Cond.MenuSetId, strComparisonOpMenuSetId);
}
if (objQxPrjMenusV2Cond.IsUpdated(conQxPrjMenusV2.MenuIdOld) == true)
{
string strComparisonOpMenuIdOld = objQxPrjMenusV2Cond.dicFldComparisonOp[conQxPrjMenusV2.MenuIdOld];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenusV2.MenuIdOld, objQxPrjMenusV2Cond.MenuIdOld, strComparisonOpMenuIdOld);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--QxPrjMenusV2(工程菜单V2), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:MenuName_QxPrjId_MenuSetId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objQxPrjMenusV2EN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsQxPrjMenusV2EN objQxPrjMenusV2EN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objQxPrjMenusV2EN == null) return true;
if (objQxPrjMenusV2EN.id == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and MenuName = '{0}'", objQxPrjMenusV2EN.MenuName);
 if (objQxPrjMenusV2EN.QxPrjId == null)
{
 sbCondition.AppendFormat(" and QxPrjId is null", objQxPrjMenusV2EN.QxPrjId);
}
else
{
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxPrjMenusV2EN.QxPrjId);
}
 if (objQxPrjMenusV2EN.MenuSetId == null)
{
 sbCondition.AppendFormat(" and MenuSetId is null", objQxPrjMenusV2EN.MenuSetId);
}
else
{
 sbCondition.AppendFormat(" and MenuSetId = '{0}'", objQxPrjMenusV2EN.MenuSetId);
}
if (clsQxPrjMenusV2BL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("id !=  {0}", objQxPrjMenusV2EN.id);
 sbCondition.AppendFormat(" and MenuName = '{0}'", objQxPrjMenusV2EN.MenuName);
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxPrjMenusV2EN.QxPrjId);
 sbCondition.AppendFormat(" and MenuSetId = '{0}'", objQxPrjMenusV2EN.MenuSetId);
if (clsQxPrjMenusV2BL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--QxPrjMenusV2(工程菜单V2), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:MenuName_QxPrjId_MenuSetId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objQxPrjMenusV2EN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsQxPrjMenusV2EN objQxPrjMenusV2EN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objQxPrjMenusV2EN == null) return "";
if (objQxPrjMenusV2EN.id == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and MenuName = '{0}'", objQxPrjMenusV2EN.MenuName);
 if (objQxPrjMenusV2EN.QxPrjId == null)
{
 sbCondition.AppendFormat(" and QxPrjId is null", objQxPrjMenusV2EN.QxPrjId);
}
else
{
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxPrjMenusV2EN.QxPrjId);
}
 if (objQxPrjMenusV2EN.MenuSetId == null)
{
 sbCondition.AppendFormat(" and MenuSetId is null", objQxPrjMenusV2EN.MenuSetId);
}
else
{
 sbCondition.AppendFormat(" and MenuSetId = '{0}'", objQxPrjMenusV2EN.MenuSetId);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("id !=  {0}", objQxPrjMenusV2EN.id);
 sbCondition.AppendFormat(" and MenuName = '{0}'", objQxPrjMenusV2EN.MenuName);
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxPrjMenusV2EN.QxPrjId);
 sbCondition.AppendFormat(" and MenuSetId = '{0}'", objQxPrjMenusV2EN.MenuSetId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_QxPrjMenusV2
{
public virtual bool UpdRelaTabDate(int intid, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 工程菜单V2(QxPrjMenusV2)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsQxPrjMenusV2BL
{
public static RelatedActions_QxPrjMenusV2 relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "QxPrjMenusV2ListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "QxPrjMenusV2List";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsQxPrjMenusV2EN> arrQxPrjMenusV2ObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsQxPrjMenusV2DA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsQxPrjMenusV2DA QxPrjMenusV2DA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsQxPrjMenusV2DA();
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
 public clsQxPrjMenusV2BL()
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
if (string.IsNullOrEmpty(clsQxPrjMenusV2EN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxPrjMenusV2EN._ConnectString);
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
objDS = QxPrjMenusV2DA.GetDataSet(strWhereCond);
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
objDS = QxPrjMenusV2DA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = QxPrjMenusV2DA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_QxPrjMenusV2(string strWhereCond)
{
DataTable objDT;
try
{
objDT = QxPrjMenusV2DA.GetDataTable_QxPrjMenusV2(strWhereCond);
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
objDT = QxPrjMenusV2DA.GetDataTable(strWhereCond);
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
objDT = QxPrjMenusV2DA.GetDataTable(strWhereCond, lstExclude);
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
objDT = QxPrjMenusV2DA.GetDataTable(strWhereCond, strTabName);
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
objDT = QxPrjMenusV2DA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = QxPrjMenusV2DA.GetDataTable_Top(objTopPara);
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
objDT = QxPrjMenusV2DA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = QxPrjMenusV2DA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = QxPrjMenusV2DA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = QxPrjMenusV2DA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = QxPrjMenusV2DA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = QxPrjMenusV2DA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = QxPrjMenusV2DA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = QxPrjMenusV2DA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
 /// <param name = "arrIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsQxPrjMenusV2EN> GetObjLstByIdLst(List<int> arrIdLst)
{
List<clsQxPrjMenusV2EN> arrObjLst = new List<clsQxPrjMenusV2EN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdLst);
 string strWhereCond = string.Format("id in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjMenusV2EN objQxPrjMenusV2EN = new clsQxPrjMenusV2EN();
try
{
objQxPrjMenusV2EN.createdAt = objRow[conQxPrjMenusV2.createdAt] == DBNull.Value ? null : objRow[conQxPrjMenusV2.createdAt].ToString().Trim(); //建立时间
objQxPrjMenusV2EN.updatedAt = objRow[conQxPrjMenusV2.updatedAt] == DBNull.Value ? null : objRow[conQxPrjMenusV2.updatedAt].ToString().Trim(); //修改时间
objQxPrjMenusV2EN.id = Int32.Parse(objRow[conQxPrjMenusV2.id].ToString().Trim()); //id
objQxPrjMenusV2EN.parentMenuId = objRow[conQxPrjMenusV2.parentMenuId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxPrjMenusV2.parentMenuId].ToString().Trim()); //上级菜单Id
objQxPrjMenusV2EN.MenuName = objRow[conQxPrjMenusV2.MenuName].ToString().Trim(); //菜单名
objQxPrjMenusV2EN.router = objRow[conQxPrjMenusV2.router] == DBNull.Value ? null : objRow[conQxPrjMenusV2.router].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.perms = objRow[conQxPrjMenusV2.perms] == DBNull.Value ? null : objRow[conQxPrjMenusV2.perms].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.type = Int32.Parse(objRow[conQxPrjMenusV2.type].ToString().Trim()); //排序号
objQxPrjMenusV2EN.icon = objRow[conQxPrjMenusV2.icon] == DBNull.Value ? null : objRow[conQxPrjMenusV2.icon].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.OrderNum = Int32.Parse(objRow[conQxPrjMenusV2.OrderNum].ToString().Trim()); //排序号
objQxPrjMenusV2EN.viewPath = objRow[conQxPrjMenusV2.viewPath] == DBNull.Value ? null : objRow[conQxPrjMenusV2.viewPath].ToString().Trim(); //图像文件
objQxPrjMenusV2EN.keepalive = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.keepalive].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.isShow = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.isShow].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.isExt = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.isExt].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.openMode = Int32.Parse(objRow[conQxPrjMenusV2.openMode].ToString().Trim()); //应用程序类型ID
objQxPrjMenusV2EN.QxPrjId = objRow[conQxPrjMenusV2.QxPrjId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.QxPrjId].ToString().Trim(); //项目Id
objQxPrjMenusV2EN.UpdUserId = objRow[conQxPrjMenusV2.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjMenusV2EN.Memo = objRow[conQxPrjMenusV2.Memo] == DBNull.Value ? null : objRow[conQxPrjMenusV2.Memo].ToString().Trim(); //备注
objQxPrjMenusV2EN.LinkFile = objRow[conQxPrjMenusV2.LinkFile] == DBNull.Value ? null : objRow[conQxPrjMenusV2.LinkFile].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.UpdDate = objRow[conQxPrjMenusV2.UpdDate] == DBNull.Value ? null : objRow[conQxPrjMenusV2.UpdDate].ToString().Trim(); //修改日期
objQxPrjMenusV2EN.MenuControlName = objRow[conQxPrjMenusV2.MenuControlName] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuControlName].ToString().Trim(); //MenuControlName
objQxPrjMenusV2EN.ApplicationTypeId = objRow[conQxPrjMenusV2.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxPrjMenusV2.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objQxPrjMenusV2EN.MenuTitle = objRow[conQxPrjMenusV2.MenuTitle] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuTitle].ToString().Trim(); //菜单标题
objQxPrjMenusV2EN.PageDispModeId = objRow[conQxPrjMenusV2.PageDispModeId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.PageDispModeId].ToString().Trim(); //页面显示模式Id
objQxPrjMenusV2EN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.InUse].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.qsParameters = objRow[conQxPrjMenusV2.qsParameters] == DBNull.Value ? null : objRow[conQxPrjMenusV2.qsParameters].ToString().Trim(); //qs参数
objQxPrjMenusV2EN.ImgFile = objRow[conQxPrjMenusV2.ImgFile] == DBNull.Value ? null : objRow[conQxPrjMenusV2.ImgFile].ToString().Trim(); //图像文件
objQxPrjMenusV2EN.TabId = objRow[conQxPrjMenusV2.TabId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.TabId].ToString().Trim(); //表ID
objQxPrjMenusV2EN.RoleId = objRow[conQxPrjMenusV2.RoleId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.RoleId].ToString().Trim(); //角色Id
objQxPrjMenusV2EN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.IsLeafNode].ToString().Trim()); //是否叶子
objQxPrjMenusV2EN.MenuSetId = objRow[conQxPrjMenusV2.MenuSetId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuSetId].ToString().Trim(); //菜单集Id
objQxPrjMenusV2EN.MenuIdOld = objRow[conQxPrjMenusV2.MenuIdOld] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuIdOld].ToString().Trim(); //MenuIdOld
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjMenusV2EN.id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjMenusV2EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsQxPrjMenusV2EN> GetObjLstByIdLstCache(List<int> arrIdLst, string strQxPrjId)
{
string strKey = string.Format("{0}_{1}", clsQxPrjMenusV2EN._CurrTabName, strQxPrjId);
List<clsQxPrjMenusV2EN> arrQxPrjMenusV2ObjLstCache = GetObjLstCache(strQxPrjId);
IEnumerable <clsQxPrjMenusV2EN> arrQxPrjMenusV2ObjLst_Sel =
arrQxPrjMenusV2ObjLstCache
.Where(x => arrIdLst.Contains(x.id));
return arrQxPrjMenusV2ObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPrjMenusV2EN> GetObjLst(string strWhereCond)
{
List<clsQxPrjMenusV2EN> arrObjLst = new List<clsQxPrjMenusV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjMenusV2EN objQxPrjMenusV2EN = new clsQxPrjMenusV2EN();
try
{
objQxPrjMenusV2EN.createdAt = objRow[conQxPrjMenusV2.createdAt] == DBNull.Value ? null : objRow[conQxPrjMenusV2.createdAt].ToString().Trim(); //建立时间
objQxPrjMenusV2EN.updatedAt = objRow[conQxPrjMenusV2.updatedAt] == DBNull.Value ? null : objRow[conQxPrjMenusV2.updatedAt].ToString().Trim(); //修改时间
objQxPrjMenusV2EN.id = Int32.Parse(objRow[conQxPrjMenusV2.id].ToString().Trim()); //id
objQxPrjMenusV2EN.parentMenuId = objRow[conQxPrjMenusV2.parentMenuId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxPrjMenusV2.parentMenuId].ToString().Trim()); //上级菜单Id
objQxPrjMenusV2EN.MenuName = objRow[conQxPrjMenusV2.MenuName].ToString().Trim(); //菜单名
objQxPrjMenusV2EN.router = objRow[conQxPrjMenusV2.router] == DBNull.Value ? null : objRow[conQxPrjMenusV2.router].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.perms = objRow[conQxPrjMenusV2.perms] == DBNull.Value ? null : objRow[conQxPrjMenusV2.perms].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.type = Int32.Parse(objRow[conQxPrjMenusV2.type].ToString().Trim()); //排序号
objQxPrjMenusV2EN.icon = objRow[conQxPrjMenusV2.icon] == DBNull.Value ? null : objRow[conQxPrjMenusV2.icon].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.OrderNum = Int32.Parse(objRow[conQxPrjMenusV2.OrderNum].ToString().Trim()); //排序号
objQxPrjMenusV2EN.viewPath = objRow[conQxPrjMenusV2.viewPath] == DBNull.Value ? null : objRow[conQxPrjMenusV2.viewPath].ToString().Trim(); //图像文件
objQxPrjMenusV2EN.keepalive = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.keepalive].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.isShow = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.isShow].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.isExt = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.isExt].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.openMode = Int32.Parse(objRow[conQxPrjMenusV2.openMode].ToString().Trim()); //应用程序类型ID
objQxPrjMenusV2EN.QxPrjId = objRow[conQxPrjMenusV2.QxPrjId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.QxPrjId].ToString().Trim(); //项目Id
objQxPrjMenusV2EN.UpdUserId = objRow[conQxPrjMenusV2.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjMenusV2EN.Memo = objRow[conQxPrjMenusV2.Memo] == DBNull.Value ? null : objRow[conQxPrjMenusV2.Memo].ToString().Trim(); //备注
objQxPrjMenusV2EN.LinkFile = objRow[conQxPrjMenusV2.LinkFile] == DBNull.Value ? null : objRow[conQxPrjMenusV2.LinkFile].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.UpdDate = objRow[conQxPrjMenusV2.UpdDate] == DBNull.Value ? null : objRow[conQxPrjMenusV2.UpdDate].ToString().Trim(); //修改日期
objQxPrjMenusV2EN.MenuControlName = objRow[conQxPrjMenusV2.MenuControlName] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuControlName].ToString().Trim(); //MenuControlName
objQxPrjMenusV2EN.ApplicationTypeId = objRow[conQxPrjMenusV2.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxPrjMenusV2.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objQxPrjMenusV2EN.MenuTitle = objRow[conQxPrjMenusV2.MenuTitle] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuTitle].ToString().Trim(); //菜单标题
objQxPrjMenusV2EN.PageDispModeId = objRow[conQxPrjMenusV2.PageDispModeId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.PageDispModeId].ToString().Trim(); //页面显示模式Id
objQxPrjMenusV2EN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.InUse].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.qsParameters = objRow[conQxPrjMenusV2.qsParameters] == DBNull.Value ? null : objRow[conQxPrjMenusV2.qsParameters].ToString().Trim(); //qs参数
objQxPrjMenusV2EN.ImgFile = objRow[conQxPrjMenusV2.ImgFile] == DBNull.Value ? null : objRow[conQxPrjMenusV2.ImgFile].ToString().Trim(); //图像文件
objQxPrjMenusV2EN.TabId = objRow[conQxPrjMenusV2.TabId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.TabId].ToString().Trim(); //表ID
objQxPrjMenusV2EN.RoleId = objRow[conQxPrjMenusV2.RoleId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.RoleId].ToString().Trim(); //角色Id
objQxPrjMenusV2EN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.IsLeafNode].ToString().Trim()); //是否叶子
objQxPrjMenusV2EN.MenuSetId = objRow[conQxPrjMenusV2.MenuSetId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuSetId].ToString().Trim(); //菜单集Id
objQxPrjMenusV2EN.MenuIdOld = objRow[conQxPrjMenusV2.MenuIdOld] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuIdOld].ToString().Trim(); //MenuIdOld
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjMenusV2EN.id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjMenusV2EN);
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
public static List<clsQxPrjMenusV2EN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsQxPrjMenusV2EN> arrObjLst = new List<clsQxPrjMenusV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjMenusV2EN objQxPrjMenusV2EN = new clsQxPrjMenusV2EN();
try
{
objQxPrjMenusV2EN.createdAt = objRow[conQxPrjMenusV2.createdAt] == DBNull.Value ? null : objRow[conQxPrjMenusV2.createdAt].ToString().Trim(); //建立时间
objQxPrjMenusV2EN.updatedAt = objRow[conQxPrjMenusV2.updatedAt] == DBNull.Value ? null : objRow[conQxPrjMenusV2.updatedAt].ToString().Trim(); //修改时间
objQxPrjMenusV2EN.id = Int32.Parse(objRow[conQxPrjMenusV2.id].ToString().Trim()); //id
objQxPrjMenusV2EN.parentMenuId = objRow[conQxPrjMenusV2.parentMenuId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxPrjMenusV2.parentMenuId].ToString().Trim()); //上级菜单Id
objQxPrjMenusV2EN.MenuName = objRow[conQxPrjMenusV2.MenuName].ToString().Trim(); //菜单名
objQxPrjMenusV2EN.router = objRow[conQxPrjMenusV2.router] == DBNull.Value ? null : objRow[conQxPrjMenusV2.router].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.perms = objRow[conQxPrjMenusV2.perms] == DBNull.Value ? null : objRow[conQxPrjMenusV2.perms].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.type = Int32.Parse(objRow[conQxPrjMenusV2.type].ToString().Trim()); //排序号
objQxPrjMenusV2EN.icon = objRow[conQxPrjMenusV2.icon] == DBNull.Value ? null : objRow[conQxPrjMenusV2.icon].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.OrderNum = Int32.Parse(objRow[conQxPrjMenusV2.OrderNum].ToString().Trim()); //排序号
objQxPrjMenusV2EN.viewPath = objRow[conQxPrjMenusV2.viewPath] == DBNull.Value ? null : objRow[conQxPrjMenusV2.viewPath].ToString().Trim(); //图像文件
objQxPrjMenusV2EN.keepalive = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.keepalive].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.isShow = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.isShow].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.isExt = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.isExt].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.openMode = Int32.Parse(objRow[conQxPrjMenusV2.openMode].ToString().Trim()); //应用程序类型ID
objQxPrjMenusV2EN.QxPrjId = objRow[conQxPrjMenusV2.QxPrjId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.QxPrjId].ToString().Trim(); //项目Id
objQxPrjMenusV2EN.UpdUserId = objRow[conQxPrjMenusV2.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjMenusV2EN.Memo = objRow[conQxPrjMenusV2.Memo] == DBNull.Value ? null : objRow[conQxPrjMenusV2.Memo].ToString().Trim(); //备注
objQxPrjMenusV2EN.LinkFile = objRow[conQxPrjMenusV2.LinkFile] == DBNull.Value ? null : objRow[conQxPrjMenusV2.LinkFile].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.UpdDate = objRow[conQxPrjMenusV2.UpdDate] == DBNull.Value ? null : objRow[conQxPrjMenusV2.UpdDate].ToString().Trim(); //修改日期
objQxPrjMenusV2EN.MenuControlName = objRow[conQxPrjMenusV2.MenuControlName] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuControlName].ToString().Trim(); //MenuControlName
objQxPrjMenusV2EN.ApplicationTypeId = objRow[conQxPrjMenusV2.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxPrjMenusV2.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objQxPrjMenusV2EN.MenuTitle = objRow[conQxPrjMenusV2.MenuTitle] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuTitle].ToString().Trim(); //菜单标题
objQxPrjMenusV2EN.PageDispModeId = objRow[conQxPrjMenusV2.PageDispModeId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.PageDispModeId].ToString().Trim(); //页面显示模式Id
objQxPrjMenusV2EN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.InUse].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.qsParameters = objRow[conQxPrjMenusV2.qsParameters] == DBNull.Value ? null : objRow[conQxPrjMenusV2.qsParameters].ToString().Trim(); //qs参数
objQxPrjMenusV2EN.ImgFile = objRow[conQxPrjMenusV2.ImgFile] == DBNull.Value ? null : objRow[conQxPrjMenusV2.ImgFile].ToString().Trim(); //图像文件
objQxPrjMenusV2EN.TabId = objRow[conQxPrjMenusV2.TabId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.TabId].ToString().Trim(); //表ID
objQxPrjMenusV2EN.RoleId = objRow[conQxPrjMenusV2.RoleId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.RoleId].ToString().Trim(); //角色Id
objQxPrjMenusV2EN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.IsLeafNode].ToString().Trim()); //是否叶子
objQxPrjMenusV2EN.MenuSetId = objRow[conQxPrjMenusV2.MenuSetId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuSetId].ToString().Trim(); //菜单集Id
objQxPrjMenusV2EN.MenuIdOld = objRow[conQxPrjMenusV2.MenuIdOld] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuIdOld].ToString().Trim(); //MenuIdOld
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjMenusV2EN.id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjMenusV2EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objQxPrjMenusV2Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsQxPrjMenusV2EN> GetSubObjLstCache(clsQxPrjMenusV2EN objQxPrjMenusV2Cond)
{
 string strQxPrjId = objQxPrjMenusV2Cond.QxPrjId;
 if (string.IsNullOrEmpty(strQxPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsQxPrjMenusV2BL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsQxPrjMenusV2EN> arrObjLstCache = GetObjLstCache(strQxPrjId);
IEnumerable <clsQxPrjMenusV2EN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxPrjMenusV2.AttributeName)
{
if (objQxPrjMenusV2Cond.IsUpdated(strFldName) == false) continue;
if (objQxPrjMenusV2Cond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxPrjMenusV2Cond[strFldName].ToString());
}
else
{
if (objQxPrjMenusV2Cond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxPrjMenusV2Cond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxPrjMenusV2Cond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxPrjMenusV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxPrjMenusV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxPrjMenusV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxPrjMenusV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxPrjMenusV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxPrjMenusV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxPrjMenusV2Cond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxPrjMenusV2Cond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxPrjMenusV2Cond[strFldName]));
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
public static List<clsQxPrjMenusV2EN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsQxPrjMenusV2EN> arrObjLst = new List<clsQxPrjMenusV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjMenusV2EN objQxPrjMenusV2EN = new clsQxPrjMenusV2EN();
try
{
objQxPrjMenusV2EN.createdAt = objRow[conQxPrjMenusV2.createdAt] == DBNull.Value ? null : objRow[conQxPrjMenusV2.createdAt].ToString().Trim(); //建立时间
objQxPrjMenusV2EN.updatedAt = objRow[conQxPrjMenusV2.updatedAt] == DBNull.Value ? null : objRow[conQxPrjMenusV2.updatedAt].ToString().Trim(); //修改时间
objQxPrjMenusV2EN.id = Int32.Parse(objRow[conQxPrjMenusV2.id].ToString().Trim()); //id
objQxPrjMenusV2EN.parentMenuId = objRow[conQxPrjMenusV2.parentMenuId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxPrjMenusV2.parentMenuId].ToString().Trim()); //上级菜单Id
objQxPrjMenusV2EN.MenuName = objRow[conQxPrjMenusV2.MenuName].ToString().Trim(); //菜单名
objQxPrjMenusV2EN.router = objRow[conQxPrjMenusV2.router] == DBNull.Value ? null : objRow[conQxPrjMenusV2.router].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.perms = objRow[conQxPrjMenusV2.perms] == DBNull.Value ? null : objRow[conQxPrjMenusV2.perms].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.type = Int32.Parse(objRow[conQxPrjMenusV2.type].ToString().Trim()); //排序号
objQxPrjMenusV2EN.icon = objRow[conQxPrjMenusV2.icon] == DBNull.Value ? null : objRow[conQxPrjMenusV2.icon].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.OrderNum = Int32.Parse(objRow[conQxPrjMenusV2.OrderNum].ToString().Trim()); //排序号
objQxPrjMenusV2EN.viewPath = objRow[conQxPrjMenusV2.viewPath] == DBNull.Value ? null : objRow[conQxPrjMenusV2.viewPath].ToString().Trim(); //图像文件
objQxPrjMenusV2EN.keepalive = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.keepalive].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.isShow = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.isShow].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.isExt = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.isExt].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.openMode = Int32.Parse(objRow[conQxPrjMenusV2.openMode].ToString().Trim()); //应用程序类型ID
objQxPrjMenusV2EN.QxPrjId = objRow[conQxPrjMenusV2.QxPrjId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.QxPrjId].ToString().Trim(); //项目Id
objQxPrjMenusV2EN.UpdUserId = objRow[conQxPrjMenusV2.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjMenusV2EN.Memo = objRow[conQxPrjMenusV2.Memo] == DBNull.Value ? null : objRow[conQxPrjMenusV2.Memo].ToString().Trim(); //备注
objQxPrjMenusV2EN.LinkFile = objRow[conQxPrjMenusV2.LinkFile] == DBNull.Value ? null : objRow[conQxPrjMenusV2.LinkFile].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.UpdDate = objRow[conQxPrjMenusV2.UpdDate] == DBNull.Value ? null : objRow[conQxPrjMenusV2.UpdDate].ToString().Trim(); //修改日期
objQxPrjMenusV2EN.MenuControlName = objRow[conQxPrjMenusV2.MenuControlName] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuControlName].ToString().Trim(); //MenuControlName
objQxPrjMenusV2EN.ApplicationTypeId = objRow[conQxPrjMenusV2.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxPrjMenusV2.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objQxPrjMenusV2EN.MenuTitle = objRow[conQxPrjMenusV2.MenuTitle] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuTitle].ToString().Trim(); //菜单标题
objQxPrjMenusV2EN.PageDispModeId = objRow[conQxPrjMenusV2.PageDispModeId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.PageDispModeId].ToString().Trim(); //页面显示模式Id
objQxPrjMenusV2EN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.InUse].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.qsParameters = objRow[conQxPrjMenusV2.qsParameters] == DBNull.Value ? null : objRow[conQxPrjMenusV2.qsParameters].ToString().Trim(); //qs参数
objQxPrjMenusV2EN.ImgFile = objRow[conQxPrjMenusV2.ImgFile] == DBNull.Value ? null : objRow[conQxPrjMenusV2.ImgFile].ToString().Trim(); //图像文件
objQxPrjMenusV2EN.TabId = objRow[conQxPrjMenusV2.TabId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.TabId].ToString().Trim(); //表ID
objQxPrjMenusV2EN.RoleId = objRow[conQxPrjMenusV2.RoleId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.RoleId].ToString().Trim(); //角色Id
objQxPrjMenusV2EN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.IsLeafNode].ToString().Trim()); //是否叶子
objQxPrjMenusV2EN.MenuSetId = objRow[conQxPrjMenusV2.MenuSetId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuSetId].ToString().Trim(); //菜单集Id
objQxPrjMenusV2EN.MenuIdOld = objRow[conQxPrjMenusV2.MenuIdOld] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuIdOld].ToString().Trim(); //MenuIdOld
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjMenusV2EN.id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjMenusV2EN);
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
public static List<clsQxPrjMenusV2EN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsQxPrjMenusV2EN> arrObjLst = new List<clsQxPrjMenusV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjMenusV2EN objQxPrjMenusV2EN = new clsQxPrjMenusV2EN();
try
{
objQxPrjMenusV2EN.createdAt = objRow[conQxPrjMenusV2.createdAt] == DBNull.Value ? null : objRow[conQxPrjMenusV2.createdAt].ToString().Trim(); //建立时间
objQxPrjMenusV2EN.updatedAt = objRow[conQxPrjMenusV2.updatedAt] == DBNull.Value ? null : objRow[conQxPrjMenusV2.updatedAt].ToString().Trim(); //修改时间
objQxPrjMenusV2EN.id = Int32.Parse(objRow[conQxPrjMenusV2.id].ToString().Trim()); //id
objQxPrjMenusV2EN.parentMenuId = objRow[conQxPrjMenusV2.parentMenuId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxPrjMenusV2.parentMenuId].ToString().Trim()); //上级菜单Id
objQxPrjMenusV2EN.MenuName = objRow[conQxPrjMenusV2.MenuName].ToString().Trim(); //菜单名
objQxPrjMenusV2EN.router = objRow[conQxPrjMenusV2.router] == DBNull.Value ? null : objRow[conQxPrjMenusV2.router].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.perms = objRow[conQxPrjMenusV2.perms] == DBNull.Value ? null : objRow[conQxPrjMenusV2.perms].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.type = Int32.Parse(objRow[conQxPrjMenusV2.type].ToString().Trim()); //排序号
objQxPrjMenusV2EN.icon = objRow[conQxPrjMenusV2.icon] == DBNull.Value ? null : objRow[conQxPrjMenusV2.icon].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.OrderNum = Int32.Parse(objRow[conQxPrjMenusV2.OrderNum].ToString().Trim()); //排序号
objQxPrjMenusV2EN.viewPath = objRow[conQxPrjMenusV2.viewPath] == DBNull.Value ? null : objRow[conQxPrjMenusV2.viewPath].ToString().Trim(); //图像文件
objQxPrjMenusV2EN.keepalive = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.keepalive].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.isShow = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.isShow].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.isExt = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.isExt].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.openMode = Int32.Parse(objRow[conQxPrjMenusV2.openMode].ToString().Trim()); //应用程序类型ID
objQxPrjMenusV2EN.QxPrjId = objRow[conQxPrjMenusV2.QxPrjId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.QxPrjId].ToString().Trim(); //项目Id
objQxPrjMenusV2EN.UpdUserId = objRow[conQxPrjMenusV2.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjMenusV2EN.Memo = objRow[conQxPrjMenusV2.Memo] == DBNull.Value ? null : objRow[conQxPrjMenusV2.Memo].ToString().Trim(); //备注
objQxPrjMenusV2EN.LinkFile = objRow[conQxPrjMenusV2.LinkFile] == DBNull.Value ? null : objRow[conQxPrjMenusV2.LinkFile].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.UpdDate = objRow[conQxPrjMenusV2.UpdDate] == DBNull.Value ? null : objRow[conQxPrjMenusV2.UpdDate].ToString().Trim(); //修改日期
objQxPrjMenusV2EN.MenuControlName = objRow[conQxPrjMenusV2.MenuControlName] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuControlName].ToString().Trim(); //MenuControlName
objQxPrjMenusV2EN.ApplicationTypeId = objRow[conQxPrjMenusV2.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxPrjMenusV2.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objQxPrjMenusV2EN.MenuTitle = objRow[conQxPrjMenusV2.MenuTitle] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuTitle].ToString().Trim(); //菜单标题
objQxPrjMenusV2EN.PageDispModeId = objRow[conQxPrjMenusV2.PageDispModeId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.PageDispModeId].ToString().Trim(); //页面显示模式Id
objQxPrjMenusV2EN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.InUse].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.qsParameters = objRow[conQxPrjMenusV2.qsParameters] == DBNull.Value ? null : objRow[conQxPrjMenusV2.qsParameters].ToString().Trim(); //qs参数
objQxPrjMenusV2EN.ImgFile = objRow[conQxPrjMenusV2.ImgFile] == DBNull.Value ? null : objRow[conQxPrjMenusV2.ImgFile].ToString().Trim(); //图像文件
objQxPrjMenusV2EN.TabId = objRow[conQxPrjMenusV2.TabId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.TabId].ToString().Trim(); //表ID
objQxPrjMenusV2EN.RoleId = objRow[conQxPrjMenusV2.RoleId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.RoleId].ToString().Trim(); //角色Id
objQxPrjMenusV2EN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.IsLeafNode].ToString().Trim()); //是否叶子
objQxPrjMenusV2EN.MenuSetId = objRow[conQxPrjMenusV2.MenuSetId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuSetId].ToString().Trim(); //菜单集Id
objQxPrjMenusV2EN.MenuIdOld = objRow[conQxPrjMenusV2.MenuIdOld] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuIdOld].ToString().Trim(); //MenuIdOld
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjMenusV2EN.id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjMenusV2EN);
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
List<clsQxPrjMenusV2EN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsQxPrjMenusV2EN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPrjMenusV2EN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsQxPrjMenusV2EN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsQxPrjMenusV2EN> arrObjLst = new List<clsQxPrjMenusV2EN>(); 
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
	clsQxPrjMenusV2EN objQxPrjMenusV2EN = new clsQxPrjMenusV2EN();
try
{
objQxPrjMenusV2EN.createdAt = objRow[conQxPrjMenusV2.createdAt] == DBNull.Value ? null : objRow[conQxPrjMenusV2.createdAt].ToString().Trim(); //建立时间
objQxPrjMenusV2EN.updatedAt = objRow[conQxPrjMenusV2.updatedAt] == DBNull.Value ? null : objRow[conQxPrjMenusV2.updatedAt].ToString().Trim(); //修改时间
objQxPrjMenusV2EN.id = Int32.Parse(objRow[conQxPrjMenusV2.id].ToString().Trim()); //id
objQxPrjMenusV2EN.parentMenuId = objRow[conQxPrjMenusV2.parentMenuId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxPrjMenusV2.parentMenuId].ToString().Trim()); //上级菜单Id
objQxPrjMenusV2EN.MenuName = objRow[conQxPrjMenusV2.MenuName].ToString().Trim(); //菜单名
objQxPrjMenusV2EN.router = objRow[conQxPrjMenusV2.router] == DBNull.Value ? null : objRow[conQxPrjMenusV2.router].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.perms = objRow[conQxPrjMenusV2.perms] == DBNull.Value ? null : objRow[conQxPrjMenusV2.perms].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.type = Int32.Parse(objRow[conQxPrjMenusV2.type].ToString().Trim()); //排序号
objQxPrjMenusV2EN.icon = objRow[conQxPrjMenusV2.icon] == DBNull.Value ? null : objRow[conQxPrjMenusV2.icon].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.OrderNum = Int32.Parse(objRow[conQxPrjMenusV2.OrderNum].ToString().Trim()); //排序号
objQxPrjMenusV2EN.viewPath = objRow[conQxPrjMenusV2.viewPath] == DBNull.Value ? null : objRow[conQxPrjMenusV2.viewPath].ToString().Trim(); //图像文件
objQxPrjMenusV2EN.keepalive = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.keepalive].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.isShow = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.isShow].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.isExt = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.isExt].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.openMode = Int32.Parse(objRow[conQxPrjMenusV2.openMode].ToString().Trim()); //应用程序类型ID
objQxPrjMenusV2EN.QxPrjId = objRow[conQxPrjMenusV2.QxPrjId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.QxPrjId].ToString().Trim(); //项目Id
objQxPrjMenusV2EN.UpdUserId = objRow[conQxPrjMenusV2.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjMenusV2EN.Memo = objRow[conQxPrjMenusV2.Memo] == DBNull.Value ? null : objRow[conQxPrjMenusV2.Memo].ToString().Trim(); //备注
objQxPrjMenusV2EN.LinkFile = objRow[conQxPrjMenusV2.LinkFile] == DBNull.Value ? null : objRow[conQxPrjMenusV2.LinkFile].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.UpdDate = objRow[conQxPrjMenusV2.UpdDate] == DBNull.Value ? null : objRow[conQxPrjMenusV2.UpdDate].ToString().Trim(); //修改日期
objQxPrjMenusV2EN.MenuControlName = objRow[conQxPrjMenusV2.MenuControlName] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuControlName].ToString().Trim(); //MenuControlName
objQxPrjMenusV2EN.ApplicationTypeId = objRow[conQxPrjMenusV2.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxPrjMenusV2.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objQxPrjMenusV2EN.MenuTitle = objRow[conQxPrjMenusV2.MenuTitle] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuTitle].ToString().Trim(); //菜单标题
objQxPrjMenusV2EN.PageDispModeId = objRow[conQxPrjMenusV2.PageDispModeId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.PageDispModeId].ToString().Trim(); //页面显示模式Id
objQxPrjMenusV2EN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.InUse].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.qsParameters = objRow[conQxPrjMenusV2.qsParameters] == DBNull.Value ? null : objRow[conQxPrjMenusV2.qsParameters].ToString().Trim(); //qs参数
objQxPrjMenusV2EN.ImgFile = objRow[conQxPrjMenusV2.ImgFile] == DBNull.Value ? null : objRow[conQxPrjMenusV2.ImgFile].ToString().Trim(); //图像文件
objQxPrjMenusV2EN.TabId = objRow[conQxPrjMenusV2.TabId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.TabId].ToString().Trim(); //表ID
objQxPrjMenusV2EN.RoleId = objRow[conQxPrjMenusV2.RoleId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.RoleId].ToString().Trim(); //角色Id
objQxPrjMenusV2EN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.IsLeafNode].ToString().Trim()); //是否叶子
objQxPrjMenusV2EN.MenuSetId = objRow[conQxPrjMenusV2.MenuSetId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuSetId].ToString().Trim(); //菜单集Id
objQxPrjMenusV2EN.MenuIdOld = objRow[conQxPrjMenusV2.MenuIdOld] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuIdOld].ToString().Trim(); //MenuIdOld
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjMenusV2EN.id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjMenusV2EN);
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
public static List<clsQxPrjMenusV2EN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsQxPrjMenusV2EN> arrObjLst = new List<clsQxPrjMenusV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjMenusV2EN objQxPrjMenusV2EN = new clsQxPrjMenusV2EN();
try
{
objQxPrjMenusV2EN.createdAt = objRow[conQxPrjMenusV2.createdAt] == DBNull.Value ? null : objRow[conQxPrjMenusV2.createdAt].ToString().Trim(); //建立时间
objQxPrjMenusV2EN.updatedAt = objRow[conQxPrjMenusV2.updatedAt] == DBNull.Value ? null : objRow[conQxPrjMenusV2.updatedAt].ToString().Trim(); //修改时间
objQxPrjMenusV2EN.id = Int32.Parse(objRow[conQxPrjMenusV2.id].ToString().Trim()); //id
objQxPrjMenusV2EN.parentMenuId = objRow[conQxPrjMenusV2.parentMenuId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxPrjMenusV2.parentMenuId].ToString().Trim()); //上级菜单Id
objQxPrjMenusV2EN.MenuName = objRow[conQxPrjMenusV2.MenuName].ToString().Trim(); //菜单名
objQxPrjMenusV2EN.router = objRow[conQxPrjMenusV2.router] == DBNull.Value ? null : objRow[conQxPrjMenusV2.router].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.perms = objRow[conQxPrjMenusV2.perms] == DBNull.Value ? null : objRow[conQxPrjMenusV2.perms].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.type = Int32.Parse(objRow[conQxPrjMenusV2.type].ToString().Trim()); //排序号
objQxPrjMenusV2EN.icon = objRow[conQxPrjMenusV2.icon] == DBNull.Value ? null : objRow[conQxPrjMenusV2.icon].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.OrderNum = Int32.Parse(objRow[conQxPrjMenusV2.OrderNum].ToString().Trim()); //排序号
objQxPrjMenusV2EN.viewPath = objRow[conQxPrjMenusV2.viewPath] == DBNull.Value ? null : objRow[conQxPrjMenusV2.viewPath].ToString().Trim(); //图像文件
objQxPrjMenusV2EN.keepalive = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.keepalive].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.isShow = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.isShow].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.isExt = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.isExt].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.openMode = Int32.Parse(objRow[conQxPrjMenusV2.openMode].ToString().Trim()); //应用程序类型ID
objQxPrjMenusV2EN.QxPrjId = objRow[conQxPrjMenusV2.QxPrjId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.QxPrjId].ToString().Trim(); //项目Id
objQxPrjMenusV2EN.UpdUserId = objRow[conQxPrjMenusV2.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjMenusV2EN.Memo = objRow[conQxPrjMenusV2.Memo] == DBNull.Value ? null : objRow[conQxPrjMenusV2.Memo].ToString().Trim(); //备注
objQxPrjMenusV2EN.LinkFile = objRow[conQxPrjMenusV2.LinkFile] == DBNull.Value ? null : objRow[conQxPrjMenusV2.LinkFile].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.UpdDate = objRow[conQxPrjMenusV2.UpdDate] == DBNull.Value ? null : objRow[conQxPrjMenusV2.UpdDate].ToString().Trim(); //修改日期
objQxPrjMenusV2EN.MenuControlName = objRow[conQxPrjMenusV2.MenuControlName] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuControlName].ToString().Trim(); //MenuControlName
objQxPrjMenusV2EN.ApplicationTypeId = objRow[conQxPrjMenusV2.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxPrjMenusV2.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objQxPrjMenusV2EN.MenuTitle = objRow[conQxPrjMenusV2.MenuTitle] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuTitle].ToString().Trim(); //菜单标题
objQxPrjMenusV2EN.PageDispModeId = objRow[conQxPrjMenusV2.PageDispModeId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.PageDispModeId].ToString().Trim(); //页面显示模式Id
objQxPrjMenusV2EN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.InUse].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.qsParameters = objRow[conQxPrjMenusV2.qsParameters] == DBNull.Value ? null : objRow[conQxPrjMenusV2.qsParameters].ToString().Trim(); //qs参数
objQxPrjMenusV2EN.ImgFile = objRow[conQxPrjMenusV2.ImgFile] == DBNull.Value ? null : objRow[conQxPrjMenusV2.ImgFile].ToString().Trim(); //图像文件
objQxPrjMenusV2EN.TabId = objRow[conQxPrjMenusV2.TabId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.TabId].ToString().Trim(); //表ID
objQxPrjMenusV2EN.RoleId = objRow[conQxPrjMenusV2.RoleId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.RoleId].ToString().Trim(); //角色Id
objQxPrjMenusV2EN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.IsLeafNode].ToString().Trim()); //是否叶子
objQxPrjMenusV2EN.MenuSetId = objRow[conQxPrjMenusV2.MenuSetId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuSetId].ToString().Trim(); //菜单集Id
objQxPrjMenusV2EN.MenuIdOld = objRow[conQxPrjMenusV2.MenuIdOld] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuIdOld].ToString().Trim(); //MenuIdOld
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjMenusV2EN.id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjMenusV2EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsQxPrjMenusV2EN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsQxPrjMenusV2EN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsQxPrjMenusV2EN> arrObjLst = new List<clsQxPrjMenusV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjMenusV2EN objQxPrjMenusV2EN = new clsQxPrjMenusV2EN();
try
{
objQxPrjMenusV2EN.createdAt = objRow[conQxPrjMenusV2.createdAt] == DBNull.Value ? null : objRow[conQxPrjMenusV2.createdAt].ToString().Trim(); //建立时间
objQxPrjMenusV2EN.updatedAt = objRow[conQxPrjMenusV2.updatedAt] == DBNull.Value ? null : objRow[conQxPrjMenusV2.updatedAt].ToString().Trim(); //修改时间
objQxPrjMenusV2EN.id = Int32.Parse(objRow[conQxPrjMenusV2.id].ToString().Trim()); //id
objQxPrjMenusV2EN.parentMenuId = objRow[conQxPrjMenusV2.parentMenuId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxPrjMenusV2.parentMenuId].ToString().Trim()); //上级菜单Id
objQxPrjMenusV2EN.MenuName = objRow[conQxPrjMenusV2.MenuName].ToString().Trim(); //菜单名
objQxPrjMenusV2EN.router = objRow[conQxPrjMenusV2.router] == DBNull.Value ? null : objRow[conQxPrjMenusV2.router].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.perms = objRow[conQxPrjMenusV2.perms] == DBNull.Value ? null : objRow[conQxPrjMenusV2.perms].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.type = Int32.Parse(objRow[conQxPrjMenusV2.type].ToString().Trim()); //排序号
objQxPrjMenusV2EN.icon = objRow[conQxPrjMenusV2.icon] == DBNull.Value ? null : objRow[conQxPrjMenusV2.icon].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.OrderNum = Int32.Parse(objRow[conQxPrjMenusV2.OrderNum].ToString().Trim()); //排序号
objQxPrjMenusV2EN.viewPath = objRow[conQxPrjMenusV2.viewPath] == DBNull.Value ? null : objRow[conQxPrjMenusV2.viewPath].ToString().Trim(); //图像文件
objQxPrjMenusV2EN.keepalive = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.keepalive].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.isShow = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.isShow].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.isExt = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.isExt].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.openMode = Int32.Parse(objRow[conQxPrjMenusV2.openMode].ToString().Trim()); //应用程序类型ID
objQxPrjMenusV2EN.QxPrjId = objRow[conQxPrjMenusV2.QxPrjId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.QxPrjId].ToString().Trim(); //项目Id
objQxPrjMenusV2EN.UpdUserId = objRow[conQxPrjMenusV2.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjMenusV2EN.Memo = objRow[conQxPrjMenusV2.Memo] == DBNull.Value ? null : objRow[conQxPrjMenusV2.Memo].ToString().Trim(); //备注
objQxPrjMenusV2EN.LinkFile = objRow[conQxPrjMenusV2.LinkFile] == DBNull.Value ? null : objRow[conQxPrjMenusV2.LinkFile].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.UpdDate = objRow[conQxPrjMenusV2.UpdDate] == DBNull.Value ? null : objRow[conQxPrjMenusV2.UpdDate].ToString().Trim(); //修改日期
objQxPrjMenusV2EN.MenuControlName = objRow[conQxPrjMenusV2.MenuControlName] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuControlName].ToString().Trim(); //MenuControlName
objQxPrjMenusV2EN.ApplicationTypeId = objRow[conQxPrjMenusV2.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxPrjMenusV2.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objQxPrjMenusV2EN.MenuTitle = objRow[conQxPrjMenusV2.MenuTitle] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuTitle].ToString().Trim(); //菜单标题
objQxPrjMenusV2EN.PageDispModeId = objRow[conQxPrjMenusV2.PageDispModeId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.PageDispModeId].ToString().Trim(); //页面显示模式Id
objQxPrjMenusV2EN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.InUse].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.qsParameters = objRow[conQxPrjMenusV2.qsParameters] == DBNull.Value ? null : objRow[conQxPrjMenusV2.qsParameters].ToString().Trim(); //qs参数
objQxPrjMenusV2EN.ImgFile = objRow[conQxPrjMenusV2.ImgFile] == DBNull.Value ? null : objRow[conQxPrjMenusV2.ImgFile].ToString().Trim(); //图像文件
objQxPrjMenusV2EN.TabId = objRow[conQxPrjMenusV2.TabId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.TabId].ToString().Trim(); //表ID
objQxPrjMenusV2EN.RoleId = objRow[conQxPrjMenusV2.RoleId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.RoleId].ToString().Trim(); //角色Id
objQxPrjMenusV2EN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.IsLeafNode].ToString().Trim()); //是否叶子
objQxPrjMenusV2EN.MenuSetId = objRow[conQxPrjMenusV2.MenuSetId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuSetId].ToString().Trim(); //菜单集Id
objQxPrjMenusV2EN.MenuIdOld = objRow[conQxPrjMenusV2.MenuIdOld] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuIdOld].ToString().Trim(); //MenuIdOld
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjMenusV2EN.id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjMenusV2EN);
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
public static List<clsQxPrjMenusV2EN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsQxPrjMenusV2EN> arrObjLst = new List<clsQxPrjMenusV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjMenusV2EN objQxPrjMenusV2EN = new clsQxPrjMenusV2EN();
try
{
objQxPrjMenusV2EN.createdAt = objRow[conQxPrjMenusV2.createdAt] == DBNull.Value ? null : objRow[conQxPrjMenusV2.createdAt].ToString().Trim(); //建立时间
objQxPrjMenusV2EN.updatedAt = objRow[conQxPrjMenusV2.updatedAt] == DBNull.Value ? null : objRow[conQxPrjMenusV2.updatedAt].ToString().Trim(); //修改时间
objQxPrjMenusV2EN.id = Int32.Parse(objRow[conQxPrjMenusV2.id].ToString().Trim()); //id
objQxPrjMenusV2EN.parentMenuId = objRow[conQxPrjMenusV2.parentMenuId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxPrjMenusV2.parentMenuId].ToString().Trim()); //上级菜单Id
objQxPrjMenusV2EN.MenuName = objRow[conQxPrjMenusV2.MenuName].ToString().Trim(); //菜单名
objQxPrjMenusV2EN.router = objRow[conQxPrjMenusV2.router] == DBNull.Value ? null : objRow[conQxPrjMenusV2.router].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.perms = objRow[conQxPrjMenusV2.perms] == DBNull.Value ? null : objRow[conQxPrjMenusV2.perms].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.type = Int32.Parse(objRow[conQxPrjMenusV2.type].ToString().Trim()); //排序号
objQxPrjMenusV2EN.icon = objRow[conQxPrjMenusV2.icon] == DBNull.Value ? null : objRow[conQxPrjMenusV2.icon].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.OrderNum = Int32.Parse(objRow[conQxPrjMenusV2.OrderNum].ToString().Trim()); //排序号
objQxPrjMenusV2EN.viewPath = objRow[conQxPrjMenusV2.viewPath] == DBNull.Value ? null : objRow[conQxPrjMenusV2.viewPath].ToString().Trim(); //图像文件
objQxPrjMenusV2EN.keepalive = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.keepalive].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.isShow = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.isShow].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.isExt = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.isExt].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.openMode = Int32.Parse(objRow[conQxPrjMenusV2.openMode].ToString().Trim()); //应用程序类型ID
objQxPrjMenusV2EN.QxPrjId = objRow[conQxPrjMenusV2.QxPrjId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.QxPrjId].ToString().Trim(); //项目Id
objQxPrjMenusV2EN.UpdUserId = objRow[conQxPrjMenusV2.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjMenusV2EN.Memo = objRow[conQxPrjMenusV2.Memo] == DBNull.Value ? null : objRow[conQxPrjMenusV2.Memo].ToString().Trim(); //备注
objQxPrjMenusV2EN.LinkFile = objRow[conQxPrjMenusV2.LinkFile] == DBNull.Value ? null : objRow[conQxPrjMenusV2.LinkFile].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.UpdDate = objRow[conQxPrjMenusV2.UpdDate] == DBNull.Value ? null : objRow[conQxPrjMenusV2.UpdDate].ToString().Trim(); //修改日期
objQxPrjMenusV2EN.MenuControlName = objRow[conQxPrjMenusV2.MenuControlName] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuControlName].ToString().Trim(); //MenuControlName
objQxPrjMenusV2EN.ApplicationTypeId = objRow[conQxPrjMenusV2.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxPrjMenusV2.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objQxPrjMenusV2EN.MenuTitle = objRow[conQxPrjMenusV2.MenuTitle] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuTitle].ToString().Trim(); //菜单标题
objQxPrjMenusV2EN.PageDispModeId = objRow[conQxPrjMenusV2.PageDispModeId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.PageDispModeId].ToString().Trim(); //页面显示模式Id
objQxPrjMenusV2EN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.InUse].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.qsParameters = objRow[conQxPrjMenusV2.qsParameters] == DBNull.Value ? null : objRow[conQxPrjMenusV2.qsParameters].ToString().Trim(); //qs参数
objQxPrjMenusV2EN.ImgFile = objRow[conQxPrjMenusV2.ImgFile] == DBNull.Value ? null : objRow[conQxPrjMenusV2.ImgFile].ToString().Trim(); //图像文件
objQxPrjMenusV2EN.TabId = objRow[conQxPrjMenusV2.TabId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.TabId].ToString().Trim(); //表ID
objQxPrjMenusV2EN.RoleId = objRow[conQxPrjMenusV2.RoleId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.RoleId].ToString().Trim(); //角色Id
objQxPrjMenusV2EN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.IsLeafNode].ToString().Trim()); //是否叶子
objQxPrjMenusV2EN.MenuSetId = objRow[conQxPrjMenusV2.MenuSetId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuSetId].ToString().Trim(); //菜单集Id
objQxPrjMenusV2EN.MenuIdOld = objRow[conQxPrjMenusV2.MenuIdOld] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuIdOld].ToString().Trim(); //MenuIdOld
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjMenusV2EN.id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjMenusV2EN);
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
public static IEnumerable<clsQxPrjMenusV2EN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsQxPrjMenusV2EN objQxPrjMenusV2Cond, string strOrderBy)
{
 string strQxPrjId = objQxPrjMenusV2Cond.QxPrjId;
 if (string.IsNullOrEmpty(strQxPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000173)在表中,缓存分类字段值不能为空!(clsQxPrjMenusV2BL:GetObjLstByPagerCache)");
throw new Exception(strMsg);
}
List<clsQxPrjMenusV2EN> arrObjLstCache = GetObjLstCache(strQxPrjId);
IEnumerable <clsQxPrjMenusV2EN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxPrjMenusV2.AttributeName)
{
if (objQxPrjMenusV2Cond.IsUpdated(strFldName) == false) continue;
if (objQxPrjMenusV2Cond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxPrjMenusV2Cond[strFldName].ToString());
}
else
{
if (objQxPrjMenusV2Cond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxPrjMenusV2Cond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxPrjMenusV2Cond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxPrjMenusV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxPrjMenusV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxPrjMenusV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxPrjMenusV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxPrjMenusV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxPrjMenusV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxPrjMenusV2Cond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxPrjMenusV2Cond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxPrjMenusV2Cond[strFldName]));
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
public static IEnumerable<clsQxPrjMenusV2EN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsQxPrjMenusV2EN objQxPrjMenusV2Cond = JsonConvert.DeserializeObject<clsQxPrjMenusV2EN>(objPagerPara.whereCond);
if (objQxPrjMenusV2Cond.sfFldComparisonOp == null)
{
objQxPrjMenusV2Cond.dicFldComparisonOp = null;
}
else
{
objQxPrjMenusV2Cond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objQxPrjMenusV2Cond.sfFldComparisonOp);
}
clsQxPrjMenusV2BL.SetUpdFlag(objQxPrjMenusV2Cond);
 try
{
CheckProperty4Condition(objQxPrjMenusV2Cond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsQxPrjMenusV2BL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objQxPrjMenusV2Cond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPrjMenusV2EN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsQxPrjMenusV2EN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsQxPrjMenusV2EN> arrObjLst = new List<clsQxPrjMenusV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjMenusV2EN objQxPrjMenusV2EN = new clsQxPrjMenusV2EN();
try
{
objQxPrjMenusV2EN.createdAt = objRow[conQxPrjMenusV2.createdAt] == DBNull.Value ? null : objRow[conQxPrjMenusV2.createdAt].ToString().Trim(); //建立时间
objQxPrjMenusV2EN.updatedAt = objRow[conQxPrjMenusV2.updatedAt] == DBNull.Value ? null : objRow[conQxPrjMenusV2.updatedAt].ToString().Trim(); //修改时间
objQxPrjMenusV2EN.id = Int32.Parse(objRow[conQxPrjMenusV2.id].ToString().Trim()); //id
objQxPrjMenusV2EN.parentMenuId = objRow[conQxPrjMenusV2.parentMenuId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxPrjMenusV2.parentMenuId].ToString().Trim()); //上级菜单Id
objQxPrjMenusV2EN.MenuName = objRow[conQxPrjMenusV2.MenuName].ToString().Trim(); //菜单名
objQxPrjMenusV2EN.router = objRow[conQxPrjMenusV2.router] == DBNull.Value ? null : objRow[conQxPrjMenusV2.router].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.perms = objRow[conQxPrjMenusV2.perms] == DBNull.Value ? null : objRow[conQxPrjMenusV2.perms].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.type = Int32.Parse(objRow[conQxPrjMenusV2.type].ToString().Trim()); //排序号
objQxPrjMenusV2EN.icon = objRow[conQxPrjMenusV2.icon] == DBNull.Value ? null : objRow[conQxPrjMenusV2.icon].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.OrderNum = Int32.Parse(objRow[conQxPrjMenusV2.OrderNum].ToString().Trim()); //排序号
objQxPrjMenusV2EN.viewPath = objRow[conQxPrjMenusV2.viewPath] == DBNull.Value ? null : objRow[conQxPrjMenusV2.viewPath].ToString().Trim(); //图像文件
objQxPrjMenusV2EN.keepalive = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.keepalive].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.isShow = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.isShow].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.isExt = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.isExt].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.openMode = Int32.Parse(objRow[conQxPrjMenusV2.openMode].ToString().Trim()); //应用程序类型ID
objQxPrjMenusV2EN.QxPrjId = objRow[conQxPrjMenusV2.QxPrjId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.QxPrjId].ToString().Trim(); //项目Id
objQxPrjMenusV2EN.UpdUserId = objRow[conQxPrjMenusV2.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjMenusV2EN.Memo = objRow[conQxPrjMenusV2.Memo] == DBNull.Value ? null : objRow[conQxPrjMenusV2.Memo].ToString().Trim(); //备注
objQxPrjMenusV2EN.LinkFile = objRow[conQxPrjMenusV2.LinkFile] == DBNull.Value ? null : objRow[conQxPrjMenusV2.LinkFile].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.UpdDate = objRow[conQxPrjMenusV2.UpdDate] == DBNull.Value ? null : objRow[conQxPrjMenusV2.UpdDate].ToString().Trim(); //修改日期
objQxPrjMenusV2EN.MenuControlName = objRow[conQxPrjMenusV2.MenuControlName] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuControlName].ToString().Trim(); //MenuControlName
objQxPrjMenusV2EN.ApplicationTypeId = objRow[conQxPrjMenusV2.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxPrjMenusV2.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objQxPrjMenusV2EN.MenuTitle = objRow[conQxPrjMenusV2.MenuTitle] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuTitle].ToString().Trim(); //菜单标题
objQxPrjMenusV2EN.PageDispModeId = objRow[conQxPrjMenusV2.PageDispModeId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.PageDispModeId].ToString().Trim(); //页面显示模式Id
objQxPrjMenusV2EN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.InUse].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.qsParameters = objRow[conQxPrjMenusV2.qsParameters] == DBNull.Value ? null : objRow[conQxPrjMenusV2.qsParameters].ToString().Trim(); //qs参数
objQxPrjMenusV2EN.ImgFile = objRow[conQxPrjMenusV2.ImgFile] == DBNull.Value ? null : objRow[conQxPrjMenusV2.ImgFile].ToString().Trim(); //图像文件
objQxPrjMenusV2EN.TabId = objRow[conQxPrjMenusV2.TabId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.TabId].ToString().Trim(); //表ID
objQxPrjMenusV2EN.RoleId = objRow[conQxPrjMenusV2.RoleId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.RoleId].ToString().Trim(); //角色Id
objQxPrjMenusV2EN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.IsLeafNode].ToString().Trim()); //是否叶子
objQxPrjMenusV2EN.MenuSetId = objRow[conQxPrjMenusV2.MenuSetId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuSetId].ToString().Trim(); //菜单集Id
objQxPrjMenusV2EN.MenuIdOld = objRow[conQxPrjMenusV2.MenuIdOld] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuIdOld].ToString().Trim(); //MenuIdOld
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjMenusV2EN.id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjMenusV2EN);
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
public static List<clsQxPrjMenusV2EN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsQxPrjMenusV2EN> arrObjLst = new List<clsQxPrjMenusV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjMenusV2EN objQxPrjMenusV2EN = new clsQxPrjMenusV2EN();
try
{
objQxPrjMenusV2EN.createdAt = objRow[conQxPrjMenusV2.createdAt] == DBNull.Value ? null : objRow[conQxPrjMenusV2.createdAt].ToString().Trim(); //建立时间
objQxPrjMenusV2EN.updatedAt = objRow[conQxPrjMenusV2.updatedAt] == DBNull.Value ? null : objRow[conQxPrjMenusV2.updatedAt].ToString().Trim(); //修改时间
objQxPrjMenusV2EN.id = Int32.Parse(objRow[conQxPrjMenusV2.id].ToString().Trim()); //id
objQxPrjMenusV2EN.parentMenuId = objRow[conQxPrjMenusV2.parentMenuId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxPrjMenusV2.parentMenuId].ToString().Trim()); //上级菜单Id
objQxPrjMenusV2EN.MenuName = objRow[conQxPrjMenusV2.MenuName].ToString().Trim(); //菜单名
objQxPrjMenusV2EN.router = objRow[conQxPrjMenusV2.router] == DBNull.Value ? null : objRow[conQxPrjMenusV2.router].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.perms = objRow[conQxPrjMenusV2.perms] == DBNull.Value ? null : objRow[conQxPrjMenusV2.perms].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.type = Int32.Parse(objRow[conQxPrjMenusV2.type].ToString().Trim()); //排序号
objQxPrjMenusV2EN.icon = objRow[conQxPrjMenusV2.icon] == DBNull.Value ? null : objRow[conQxPrjMenusV2.icon].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.OrderNum = Int32.Parse(objRow[conQxPrjMenusV2.OrderNum].ToString().Trim()); //排序号
objQxPrjMenusV2EN.viewPath = objRow[conQxPrjMenusV2.viewPath] == DBNull.Value ? null : objRow[conQxPrjMenusV2.viewPath].ToString().Trim(); //图像文件
objQxPrjMenusV2EN.keepalive = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.keepalive].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.isShow = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.isShow].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.isExt = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.isExt].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.openMode = Int32.Parse(objRow[conQxPrjMenusV2.openMode].ToString().Trim()); //应用程序类型ID
objQxPrjMenusV2EN.QxPrjId = objRow[conQxPrjMenusV2.QxPrjId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.QxPrjId].ToString().Trim(); //项目Id
objQxPrjMenusV2EN.UpdUserId = objRow[conQxPrjMenusV2.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjMenusV2EN.Memo = objRow[conQxPrjMenusV2.Memo] == DBNull.Value ? null : objRow[conQxPrjMenusV2.Memo].ToString().Trim(); //备注
objQxPrjMenusV2EN.LinkFile = objRow[conQxPrjMenusV2.LinkFile] == DBNull.Value ? null : objRow[conQxPrjMenusV2.LinkFile].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.UpdDate = objRow[conQxPrjMenusV2.UpdDate] == DBNull.Value ? null : objRow[conQxPrjMenusV2.UpdDate].ToString().Trim(); //修改日期
objQxPrjMenusV2EN.MenuControlName = objRow[conQxPrjMenusV2.MenuControlName] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuControlName].ToString().Trim(); //MenuControlName
objQxPrjMenusV2EN.ApplicationTypeId = objRow[conQxPrjMenusV2.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxPrjMenusV2.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objQxPrjMenusV2EN.MenuTitle = objRow[conQxPrjMenusV2.MenuTitle] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuTitle].ToString().Trim(); //菜单标题
objQxPrjMenusV2EN.PageDispModeId = objRow[conQxPrjMenusV2.PageDispModeId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.PageDispModeId].ToString().Trim(); //页面显示模式Id
objQxPrjMenusV2EN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.InUse].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.qsParameters = objRow[conQxPrjMenusV2.qsParameters] == DBNull.Value ? null : objRow[conQxPrjMenusV2.qsParameters].ToString().Trim(); //qs参数
objQxPrjMenusV2EN.ImgFile = objRow[conQxPrjMenusV2.ImgFile] == DBNull.Value ? null : objRow[conQxPrjMenusV2.ImgFile].ToString().Trim(); //图像文件
objQxPrjMenusV2EN.TabId = objRow[conQxPrjMenusV2.TabId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.TabId].ToString().Trim(); //表ID
objQxPrjMenusV2EN.RoleId = objRow[conQxPrjMenusV2.RoleId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.RoleId].ToString().Trim(); //角色Id
objQxPrjMenusV2EN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.IsLeafNode].ToString().Trim()); //是否叶子
objQxPrjMenusV2EN.MenuSetId = objRow[conQxPrjMenusV2.MenuSetId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuSetId].ToString().Trim(); //菜单集Id
objQxPrjMenusV2EN.MenuIdOld = objRow[conQxPrjMenusV2.MenuIdOld] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuIdOld].ToString().Trim(); //MenuIdOld
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjMenusV2EN.id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjMenusV2EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPrjMenusV2EN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsQxPrjMenusV2EN> arrObjLst = new List<clsQxPrjMenusV2EN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjMenusV2EN objQxPrjMenusV2EN = new clsQxPrjMenusV2EN();
try
{
objQxPrjMenusV2EN.createdAt = objRow[conQxPrjMenusV2.createdAt] == DBNull.Value ? null : objRow[conQxPrjMenusV2.createdAt].ToString().Trim(); //建立时间
objQxPrjMenusV2EN.updatedAt = objRow[conQxPrjMenusV2.updatedAt] == DBNull.Value ? null : objRow[conQxPrjMenusV2.updatedAt].ToString().Trim(); //修改时间
objQxPrjMenusV2EN.id = Int32.Parse(objRow[conQxPrjMenusV2.id].ToString().Trim()); //id
objQxPrjMenusV2EN.parentMenuId = objRow[conQxPrjMenusV2.parentMenuId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxPrjMenusV2.parentMenuId].ToString().Trim()); //上级菜单Id
objQxPrjMenusV2EN.MenuName = objRow[conQxPrjMenusV2.MenuName].ToString().Trim(); //菜单名
objQxPrjMenusV2EN.router = objRow[conQxPrjMenusV2.router] == DBNull.Value ? null : objRow[conQxPrjMenusV2.router].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.perms = objRow[conQxPrjMenusV2.perms] == DBNull.Value ? null : objRow[conQxPrjMenusV2.perms].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.type = Int32.Parse(objRow[conQxPrjMenusV2.type].ToString().Trim()); //排序号
objQxPrjMenusV2EN.icon = objRow[conQxPrjMenusV2.icon] == DBNull.Value ? null : objRow[conQxPrjMenusV2.icon].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.OrderNum = Int32.Parse(objRow[conQxPrjMenusV2.OrderNum].ToString().Trim()); //排序号
objQxPrjMenusV2EN.viewPath = objRow[conQxPrjMenusV2.viewPath] == DBNull.Value ? null : objRow[conQxPrjMenusV2.viewPath].ToString().Trim(); //图像文件
objQxPrjMenusV2EN.keepalive = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.keepalive].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.isShow = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.isShow].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.isExt = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.isExt].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.openMode = Int32.Parse(objRow[conQxPrjMenusV2.openMode].ToString().Trim()); //应用程序类型ID
objQxPrjMenusV2EN.QxPrjId = objRow[conQxPrjMenusV2.QxPrjId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.QxPrjId].ToString().Trim(); //项目Id
objQxPrjMenusV2EN.UpdUserId = objRow[conQxPrjMenusV2.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjMenusV2EN.Memo = objRow[conQxPrjMenusV2.Memo] == DBNull.Value ? null : objRow[conQxPrjMenusV2.Memo].ToString().Trim(); //备注
objQxPrjMenusV2EN.LinkFile = objRow[conQxPrjMenusV2.LinkFile] == DBNull.Value ? null : objRow[conQxPrjMenusV2.LinkFile].ToString().Trim(); //链接文件
objQxPrjMenusV2EN.UpdDate = objRow[conQxPrjMenusV2.UpdDate] == DBNull.Value ? null : objRow[conQxPrjMenusV2.UpdDate].ToString().Trim(); //修改日期
objQxPrjMenusV2EN.MenuControlName = objRow[conQxPrjMenusV2.MenuControlName] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuControlName].ToString().Trim(); //MenuControlName
objQxPrjMenusV2EN.ApplicationTypeId = objRow[conQxPrjMenusV2.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxPrjMenusV2.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objQxPrjMenusV2EN.MenuTitle = objRow[conQxPrjMenusV2.MenuTitle] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuTitle].ToString().Trim(); //菜单标题
objQxPrjMenusV2EN.PageDispModeId = objRow[conQxPrjMenusV2.PageDispModeId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.PageDispModeId].ToString().Trim(); //页面显示模式Id
objQxPrjMenusV2EN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.InUse].ToString().Trim()); //是否在用
objQxPrjMenusV2EN.qsParameters = objRow[conQxPrjMenusV2.qsParameters] == DBNull.Value ? null : objRow[conQxPrjMenusV2.qsParameters].ToString().Trim(); //qs参数
objQxPrjMenusV2EN.ImgFile = objRow[conQxPrjMenusV2.ImgFile] == DBNull.Value ? null : objRow[conQxPrjMenusV2.ImgFile].ToString().Trim(); //图像文件
objQxPrjMenusV2EN.TabId = objRow[conQxPrjMenusV2.TabId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.TabId].ToString().Trim(); //表ID
objQxPrjMenusV2EN.RoleId = objRow[conQxPrjMenusV2.RoleId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.RoleId].ToString().Trim(); //角色Id
objQxPrjMenusV2EN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjMenusV2.IsLeafNode].ToString().Trim()); //是否叶子
objQxPrjMenusV2EN.MenuSetId = objRow[conQxPrjMenusV2.MenuSetId] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuSetId].ToString().Trim(); //菜单集Id
objQxPrjMenusV2EN.MenuIdOld = objRow[conQxPrjMenusV2.MenuIdOld] == DBNull.Value ? null : objRow[conQxPrjMenusV2.MenuIdOld].ToString().Trim(); //MenuIdOld
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjMenusV2EN.id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjMenusV2EN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objQxPrjMenusV2EN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxPrjMenusV2(ref clsQxPrjMenusV2EN objQxPrjMenusV2EN)
{
bool bolResult = QxPrjMenusV2DA.GetQxPrjMenusV2(ref objQxPrjMenusV2EN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "intid">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxPrjMenusV2EN GetObjByid(int intid)
{
clsQxPrjMenusV2EN objQxPrjMenusV2EN = QxPrjMenusV2DA.GetObjByid(intid);
return objQxPrjMenusV2EN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsQxPrjMenusV2EN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsQxPrjMenusV2EN objQxPrjMenusV2EN = QxPrjMenusV2DA.GetFirstObj(strWhereCond);
 return objQxPrjMenusV2EN;
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
public static clsQxPrjMenusV2EN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsQxPrjMenusV2EN objQxPrjMenusV2EN = QxPrjMenusV2DA.GetObjByDataRow(objRow);
 return objQxPrjMenusV2EN;
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
public static clsQxPrjMenusV2EN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsQxPrjMenusV2EN objQxPrjMenusV2EN = QxPrjMenusV2DA.GetObjByDataRow(objRow);
 return objQxPrjMenusV2EN;
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
 /// <param name = "intid">所给的关键字</param>
 /// <param name = "lstQxPrjMenusV2ObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxPrjMenusV2EN GetObjByidFromList(int intid, List<clsQxPrjMenusV2EN> lstQxPrjMenusV2ObjLst)
{
foreach (clsQxPrjMenusV2EN objQxPrjMenusV2EN in lstQxPrjMenusV2ObjLst)
{
if (objQxPrjMenusV2EN.id == intid)
{
return objQxPrjMenusV2EN;
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
 int intid;
 try
 {
 intid = new clsQxPrjMenusV2DA().GetFirstID(strWhereCond);
 return intid;
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
 arrList = QxPrjMenusV2DA.GetID(strWhereCond);
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
bool bolIsExist = QxPrjMenusV2DA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "intid">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(int intid)
{
//检测记录是否存在
bool bolIsExist = QxPrjMenusV2DA.IsExist(intid);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "intid">id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(int intid, string strOpUser)
{
clsQxPrjMenusV2EN objQxPrjMenusV2EN = clsQxPrjMenusV2BL.GetObjByid(intid);
objQxPrjMenusV2EN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objQxPrjMenusV2EN.UpdUserId = strOpUser;
return clsQxPrjMenusV2BL.UpdateBySql2(objQxPrjMenusV2EN);
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
 bolIsExist = clsQxPrjMenusV2DA.IsExistTable();
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
 bolIsExist = QxPrjMenusV2DA.IsExistTable(strTabName);
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
 /// <param name = "objQxPrjMenusV2EN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsQxPrjMenusV2EN objQxPrjMenusV2EN)
{
if (objQxPrjMenusV2EN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!菜单名 = [{0}],项目Id = [{1}],菜单集Id = [{2}]的数据已经存在!(in clsQxPrjMenusV2BL.AddNewRecordBySql2)", objQxPrjMenusV2EN.MenuName,objQxPrjMenusV2EN.QxPrjId,objQxPrjMenusV2EN.MenuSetId);
throw new Exception(strMsg);
}
try
{
bool bolResult = QxPrjMenusV2DA.AddNewRecordBySQL2(objQxPrjMenusV2EN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjMenusV2BL.ReFreshCache(objQxPrjMenusV2EN.QxPrjId);

if (clsQxPrjMenusV2BL.relatedActions != null)
{
clsQxPrjMenusV2BL.relatedActions.UpdRelaTabDate(objQxPrjMenusV2EN.id, objQxPrjMenusV2EN.UpdUserId);
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
 /// <param name = "objQxPrjMenusV2EN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsQxPrjMenusV2EN objQxPrjMenusV2EN)
{
if (objQxPrjMenusV2EN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!菜单名 = [{0}],项目Id = [{1}],菜单集Id = [{2}]的数据已经存在!(in clsQxPrjMenusV2BL.AddNewRecordBySql2WithReturnKey)", objQxPrjMenusV2EN.MenuName,objQxPrjMenusV2EN.QxPrjId,objQxPrjMenusV2EN.MenuSetId);
throw new Exception(strMsg);
}
try
{
string strKey = QxPrjMenusV2DA.AddNewRecordBySQL2WithReturnKey(objQxPrjMenusV2EN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjMenusV2BL.ReFreshCache(objQxPrjMenusV2EN.QxPrjId);

if (clsQxPrjMenusV2BL.relatedActions != null)
{
clsQxPrjMenusV2BL.relatedActions.UpdRelaTabDate(objQxPrjMenusV2EN.id, objQxPrjMenusV2EN.UpdUserId);
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
 /// <param name = "strQxPrjMenusV2ObjXml">代表实体对象的XML串</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql_XML(string strQxPrjMenusV2ObjXml)
{
clsQxPrjMenusV2EN objQxPrjMenusV2EN = GetObjFromXmlStr(strQxPrjMenusV2ObjXml);
try
{
bool bolResult = QxPrjMenusV2DA.AddNewRecordBySQL2(objQxPrjMenusV2EN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjMenusV2BL.ReFreshCache(objQxPrjMenusV2EN.QxPrjId);

if (clsQxPrjMenusV2BL.relatedActions != null)
{
clsQxPrjMenusV2BL.relatedActions.UpdRelaTabDate(objQxPrjMenusV2EN.id, objQxPrjMenusV2EN.UpdUserId);
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
 /// <param name = "objQxPrjMenusV2EN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsQxPrjMenusV2EN objQxPrjMenusV2EN)
{
try
{
bool bolResult = QxPrjMenusV2DA.Update(objQxPrjMenusV2EN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjMenusV2BL.ReFreshCache(objQxPrjMenusV2EN.QxPrjId);

if (clsQxPrjMenusV2BL.relatedActions != null)
{
clsQxPrjMenusV2BL.relatedActions.UpdRelaTabDate(objQxPrjMenusV2EN.id, objQxPrjMenusV2EN.UpdUserId);
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
 /// <param name = "objQxPrjMenusV2EN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsQxPrjMenusV2EN objQxPrjMenusV2EN)
{
 if (objQxPrjMenusV2EN.id == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = QxPrjMenusV2DA.UpdateBySql2(objQxPrjMenusV2EN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjMenusV2BL.ReFreshCache(objQxPrjMenusV2EN.QxPrjId);

if (clsQxPrjMenusV2BL.relatedActions != null)
{
clsQxPrjMenusV2BL.relatedActions.UpdRelaTabDate(objQxPrjMenusV2EN.id, objQxPrjMenusV2EN.UpdUserId);
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
 /// <param name = "strQxPrjMenusV2ObjXml">需要修改的对象,用XML来表示</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql_XML(string strQxPrjMenusV2ObjXml)
{
clsQxPrjMenusV2EN objQxPrjMenusV2EN = GetObjFromXmlStr(strQxPrjMenusV2ObjXml);
try
{
bool bolResult = QxPrjMenusV2DA.UpdateBySql2(objQxPrjMenusV2EN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjMenusV2BL.ReFreshCache(objQxPrjMenusV2EN.QxPrjId);

if (clsQxPrjMenusV2BL.relatedActions != null)
{
clsQxPrjMenusV2BL.relatedActions.UpdRelaTabDate(objQxPrjMenusV2EN.id, objQxPrjMenusV2EN.UpdUserId);
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
 /// <param name = "intid">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(int intid)
{
try
{
 clsQxPrjMenusV2EN objQxPrjMenusV2EN = clsQxPrjMenusV2BL.GetObjByid(intid);

if (clsQxPrjMenusV2BL.relatedActions != null)
{
clsQxPrjMenusV2BL.relatedActions.UpdRelaTabDate(objQxPrjMenusV2EN.id, objQxPrjMenusV2EN.UpdUserId);
}
if (objQxPrjMenusV2EN != null)
{
int intRecNum = QxPrjMenusV2DA.DelRecord(intid);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objQxPrjMenusV2EN.QxPrjId);
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
/// <param name="intid">表关键字</param>
 /// <param name = "strQxPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(int intid , string strQxPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
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
//删除与表:[QxPrjMenusV2]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conQxPrjMenusV2.id,
//intid);
//        clsQxPrjMenusV2BL.DelQxPrjMenusV2sByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxPrjMenusV2BL.DelRecord(intid, strQxPrjId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxPrjMenusV2BLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
intid, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "intid">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(int intid, string strQxPrjId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsQxPrjMenusV2BL.relatedActions != null)
{
clsQxPrjMenusV2BL.relatedActions.UpdRelaTabDate(intid, "UpdRelaTabDate");
}
bool bolResult = QxPrjMenusV2DA.DelRecord(intid,objSqlConnection,objSqlTransaction);
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
 /// <param name = "intid">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(int intid, string strQxPrjId) 
{
try
{
if (clsQxPrjMenusV2BL.relatedActions != null)
{
clsQxPrjMenusV2BL.relatedActions.UpdRelaTabDate(intid, "UpdRelaTabDate");
}
bool bolResult = QxPrjMenusV2DA.DelRecordBySP(intid);
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
 /// <param name = "arridLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelQxPrjMenusV2s(List<string> arridLst)
{
if (arridLst.Count == 0) return 0;
try
{
if (clsQxPrjMenusV2BL.relatedActions != null)
{
foreach (var strid in arridLst)
{
int intid = int.Parse(strid);
clsQxPrjMenusV2BL.relatedActions.UpdRelaTabDate(intid, "UpdRelaTabDate");
}
}
 clsQxPrjMenusV2EN objQxPrjMenusV2EN = clsQxPrjMenusV2BL.GetObjByid(int.Parse(arridLst[0]));
int intDelRecNum = QxPrjMenusV2DA.DelQxPrjMenusV2(arridLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objQxPrjMenusV2EN.QxPrjId);
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
public static int DelQxPrjMenusV2sByCond(string strWhereCond)
{
try
{
if (clsQxPrjMenusV2BL.relatedActions != null)
{
List<string> arrid = GetPrimaryKeyID_S(strWhereCond);
foreach (var strid in arrid)
{
int intid = int.Parse(strid);
clsQxPrjMenusV2BL.relatedActions.UpdRelaTabDate(intid, "UpdRelaTabDate");
}
}
List<string> arrQxPrjId = GetFldValue(conQxPrjMenusV2.QxPrjId, strWhereCond);
int intRecNum = QxPrjMenusV2DA.DelQxPrjMenusV2(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[QxPrjMenusV2]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="intid">表关键字</param>
 /// <param name = "strQxPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(int intid, string strQxPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxPrjMenusV2DA.GetSpecSQLObj();
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
//删除与表:[QxPrjMenusV2]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxPrjMenusV2BL.DelRecord(intid, strQxPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxPrjMenusV2BL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
intid, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objQxPrjMenusV2ENS">源对象</param>
 /// <param name = "objQxPrjMenusV2ENT">目标对象</param>
 public static void CopyTo(clsQxPrjMenusV2EN objQxPrjMenusV2ENS, clsQxPrjMenusV2EN objQxPrjMenusV2ENT)
{
try
{
objQxPrjMenusV2ENT.createdAt = objQxPrjMenusV2ENS.createdAt; //建立时间
objQxPrjMenusV2ENT.updatedAt = objQxPrjMenusV2ENS.updatedAt; //修改时间
objQxPrjMenusV2ENT.id = objQxPrjMenusV2ENS.id; //id
objQxPrjMenusV2ENT.parentMenuId = objQxPrjMenusV2ENS.parentMenuId; //上级菜单Id
objQxPrjMenusV2ENT.MenuName = objQxPrjMenusV2ENS.MenuName; //菜单名
objQxPrjMenusV2ENT.router = objQxPrjMenusV2ENS.router; //链接文件
objQxPrjMenusV2ENT.perms = objQxPrjMenusV2ENS.perms; //链接文件
objQxPrjMenusV2ENT.type = objQxPrjMenusV2ENS.type; //排序号
objQxPrjMenusV2ENT.icon = objQxPrjMenusV2ENS.icon; //链接文件
objQxPrjMenusV2ENT.OrderNum = objQxPrjMenusV2ENS.OrderNum; //排序号
objQxPrjMenusV2ENT.viewPath = objQxPrjMenusV2ENS.viewPath; //图像文件
objQxPrjMenusV2ENT.keepalive = objQxPrjMenusV2ENS.keepalive; //是否在用
objQxPrjMenusV2ENT.isShow = objQxPrjMenusV2ENS.isShow; //是否在用
objQxPrjMenusV2ENT.isExt = objQxPrjMenusV2ENS.isExt; //是否在用
objQxPrjMenusV2ENT.openMode = objQxPrjMenusV2ENS.openMode; //应用程序类型ID
objQxPrjMenusV2ENT.QxPrjId = objQxPrjMenusV2ENS.QxPrjId; //项目Id
objQxPrjMenusV2ENT.UpdUserId = objQxPrjMenusV2ENS.UpdUserId; //修改用户Id
objQxPrjMenusV2ENT.Memo = objQxPrjMenusV2ENS.Memo; //备注
objQxPrjMenusV2ENT.LinkFile = objQxPrjMenusV2ENS.LinkFile; //链接文件
objQxPrjMenusV2ENT.UpdDate = objQxPrjMenusV2ENS.UpdDate; //修改日期
objQxPrjMenusV2ENT.MenuControlName = objQxPrjMenusV2ENS.MenuControlName; //MenuControlName
objQxPrjMenusV2ENT.ApplicationTypeId = objQxPrjMenusV2ENS.ApplicationTypeId; //应用程序类型ID
objQxPrjMenusV2ENT.MenuTitle = objQxPrjMenusV2ENS.MenuTitle; //菜单标题
objQxPrjMenusV2ENT.PageDispModeId = objQxPrjMenusV2ENS.PageDispModeId; //页面显示模式Id
objQxPrjMenusV2ENT.InUse = objQxPrjMenusV2ENS.InUse; //是否在用
objQxPrjMenusV2ENT.qsParameters = objQxPrjMenusV2ENS.qsParameters; //qs参数
objQxPrjMenusV2ENT.ImgFile = objQxPrjMenusV2ENS.ImgFile; //图像文件
objQxPrjMenusV2ENT.TabId = objQxPrjMenusV2ENS.TabId; //表ID
objQxPrjMenusV2ENT.RoleId = objQxPrjMenusV2ENS.RoleId; //角色Id
objQxPrjMenusV2ENT.IsLeafNode = objQxPrjMenusV2ENS.IsLeafNode; //是否叶子
objQxPrjMenusV2ENT.MenuSetId = objQxPrjMenusV2ENS.MenuSetId; //菜单集Id
objQxPrjMenusV2ENT.MenuIdOld = objQxPrjMenusV2ENS.MenuIdOld; //MenuIdOld
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
 /// <param name = "objQxPrjMenusV2EN">源简化对象</param>
 public static void SetUpdFlag(clsQxPrjMenusV2EN objQxPrjMenusV2EN)
{
try
{
objQxPrjMenusV2EN.ClearUpdateState();
   string strsfUpdFldSetStr = objQxPrjMenusV2EN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conQxPrjMenusV2.createdAt, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenusV2EN.createdAt = objQxPrjMenusV2EN.createdAt == "[null]" ? null :  objQxPrjMenusV2EN.createdAt; //建立时间
}
if (arrFldSet.Contains(conQxPrjMenusV2.updatedAt, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenusV2EN.updatedAt = objQxPrjMenusV2EN.updatedAt == "[null]" ? null :  objQxPrjMenusV2EN.updatedAt; //修改时间
}
if (arrFldSet.Contains(conQxPrjMenusV2.id, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenusV2EN.id = objQxPrjMenusV2EN.id; //id
}
if (arrFldSet.Contains(conQxPrjMenusV2.parentMenuId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenusV2EN.parentMenuId = objQxPrjMenusV2EN.parentMenuId; //上级菜单Id
}
if (arrFldSet.Contains(conQxPrjMenusV2.MenuName, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenusV2EN.MenuName = objQxPrjMenusV2EN.MenuName; //菜单名
}
if (arrFldSet.Contains(conQxPrjMenusV2.router, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenusV2EN.router = objQxPrjMenusV2EN.router == "[null]" ? null :  objQxPrjMenusV2EN.router; //链接文件
}
if (arrFldSet.Contains(conQxPrjMenusV2.perms, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenusV2EN.perms = objQxPrjMenusV2EN.perms == "[null]" ? null :  objQxPrjMenusV2EN.perms; //链接文件
}
if (arrFldSet.Contains(conQxPrjMenusV2.type, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenusV2EN.type = objQxPrjMenusV2EN.type; //排序号
}
if (arrFldSet.Contains(conQxPrjMenusV2.icon, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenusV2EN.icon = objQxPrjMenusV2EN.icon == "[null]" ? null :  objQxPrjMenusV2EN.icon; //链接文件
}
if (arrFldSet.Contains(conQxPrjMenusV2.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenusV2EN.OrderNum = objQxPrjMenusV2EN.OrderNum; //排序号
}
if (arrFldSet.Contains(conQxPrjMenusV2.viewPath, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenusV2EN.viewPath = objQxPrjMenusV2EN.viewPath == "[null]" ? null :  objQxPrjMenusV2EN.viewPath; //图像文件
}
if (arrFldSet.Contains(conQxPrjMenusV2.keepalive, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenusV2EN.keepalive = objQxPrjMenusV2EN.keepalive; //是否在用
}
if (arrFldSet.Contains(conQxPrjMenusV2.isShow, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenusV2EN.isShow = objQxPrjMenusV2EN.isShow; //是否在用
}
if (arrFldSet.Contains(conQxPrjMenusV2.isExt, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenusV2EN.isExt = objQxPrjMenusV2EN.isExt; //是否在用
}
if (arrFldSet.Contains(conQxPrjMenusV2.openMode, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenusV2EN.openMode = objQxPrjMenusV2EN.openMode; //应用程序类型ID
}
if (arrFldSet.Contains(conQxPrjMenusV2.QxPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenusV2EN.QxPrjId = objQxPrjMenusV2EN.QxPrjId == "[null]" ? null :  objQxPrjMenusV2EN.QxPrjId; //项目Id
}
if (arrFldSet.Contains(conQxPrjMenusV2.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenusV2EN.UpdUserId = objQxPrjMenusV2EN.UpdUserId == "[null]" ? null :  objQxPrjMenusV2EN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conQxPrjMenusV2.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenusV2EN.Memo = objQxPrjMenusV2EN.Memo == "[null]" ? null :  objQxPrjMenusV2EN.Memo; //备注
}
if (arrFldSet.Contains(conQxPrjMenusV2.LinkFile, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenusV2EN.LinkFile = objQxPrjMenusV2EN.LinkFile == "[null]" ? null :  objQxPrjMenusV2EN.LinkFile; //链接文件
}
if (arrFldSet.Contains(conQxPrjMenusV2.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenusV2EN.UpdDate = objQxPrjMenusV2EN.UpdDate == "[null]" ? null :  objQxPrjMenusV2EN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conQxPrjMenusV2.MenuControlName, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenusV2EN.MenuControlName = objQxPrjMenusV2EN.MenuControlName == "[null]" ? null :  objQxPrjMenusV2EN.MenuControlName; //MenuControlName
}
if (arrFldSet.Contains(conQxPrjMenusV2.ApplicationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenusV2EN.ApplicationTypeId = objQxPrjMenusV2EN.ApplicationTypeId; //应用程序类型ID
}
if (arrFldSet.Contains(conQxPrjMenusV2.MenuTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenusV2EN.MenuTitle = objQxPrjMenusV2EN.MenuTitle == "[null]" ? null :  objQxPrjMenusV2EN.MenuTitle; //菜单标题
}
if (arrFldSet.Contains(conQxPrjMenusV2.PageDispModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenusV2EN.PageDispModeId = objQxPrjMenusV2EN.PageDispModeId == "[null]" ? null :  objQxPrjMenusV2EN.PageDispModeId; //页面显示模式Id
}
if (arrFldSet.Contains(conQxPrjMenusV2.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenusV2EN.InUse = objQxPrjMenusV2EN.InUse; //是否在用
}
if (arrFldSet.Contains(conQxPrjMenusV2.qsParameters, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenusV2EN.qsParameters = objQxPrjMenusV2EN.qsParameters == "[null]" ? null :  objQxPrjMenusV2EN.qsParameters; //qs参数
}
if (arrFldSet.Contains(conQxPrjMenusV2.ImgFile, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenusV2EN.ImgFile = objQxPrjMenusV2EN.ImgFile == "[null]" ? null :  objQxPrjMenusV2EN.ImgFile; //图像文件
}
if (arrFldSet.Contains(conQxPrjMenusV2.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenusV2EN.TabId = objQxPrjMenusV2EN.TabId == "[null]" ? null :  objQxPrjMenusV2EN.TabId; //表ID
}
if (arrFldSet.Contains(conQxPrjMenusV2.RoleId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenusV2EN.RoleId = objQxPrjMenusV2EN.RoleId == "[null]" ? null :  objQxPrjMenusV2EN.RoleId; //角色Id
}
if (arrFldSet.Contains(conQxPrjMenusV2.IsLeafNode, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenusV2EN.IsLeafNode = objQxPrjMenusV2EN.IsLeafNode; //是否叶子
}
if (arrFldSet.Contains(conQxPrjMenusV2.MenuSetId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenusV2EN.MenuSetId = objQxPrjMenusV2EN.MenuSetId == "[null]" ? null :  objQxPrjMenusV2EN.MenuSetId; //菜单集Id
}
if (arrFldSet.Contains(conQxPrjMenusV2.MenuIdOld, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjMenusV2EN.MenuIdOld = objQxPrjMenusV2EN.MenuIdOld == "[null]" ? null :  objQxPrjMenusV2EN.MenuIdOld; //MenuIdOld
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
 /// <param name = "objQxPrjMenusV2EN">源简化对象</param>
 public static void AccessFldValueNull(clsQxPrjMenusV2EN objQxPrjMenusV2EN)
{
try
{
if (objQxPrjMenusV2EN.createdAt == "[null]") objQxPrjMenusV2EN.createdAt = null; //建立时间
if (objQxPrjMenusV2EN.updatedAt == "[null]") objQxPrjMenusV2EN.updatedAt = null; //修改时间
if (objQxPrjMenusV2EN.router == "[null]") objQxPrjMenusV2EN.router = null; //链接文件
if (objQxPrjMenusV2EN.perms == "[null]") objQxPrjMenusV2EN.perms = null; //链接文件
if (objQxPrjMenusV2EN.icon == "[null]") objQxPrjMenusV2EN.icon = null; //链接文件
if (objQxPrjMenusV2EN.viewPath == "[null]") objQxPrjMenusV2EN.viewPath = null; //图像文件
if (objQxPrjMenusV2EN.QxPrjId == "[null]") objQxPrjMenusV2EN.QxPrjId = null; //项目Id
if (objQxPrjMenusV2EN.UpdUserId == "[null]") objQxPrjMenusV2EN.UpdUserId = null; //修改用户Id
if (objQxPrjMenusV2EN.Memo == "[null]") objQxPrjMenusV2EN.Memo = null; //备注
if (objQxPrjMenusV2EN.LinkFile == "[null]") objQxPrjMenusV2EN.LinkFile = null; //链接文件
if (objQxPrjMenusV2EN.UpdDate == "[null]") objQxPrjMenusV2EN.UpdDate = null; //修改日期
if (objQxPrjMenusV2EN.MenuControlName == "[null]") objQxPrjMenusV2EN.MenuControlName = null; //MenuControlName
if (objQxPrjMenusV2EN.MenuTitle == "[null]") objQxPrjMenusV2EN.MenuTitle = null; //菜单标题
if (objQxPrjMenusV2EN.PageDispModeId == "[null]") objQxPrjMenusV2EN.PageDispModeId = null; //页面显示模式Id
if (objQxPrjMenusV2EN.qsParameters == "[null]") objQxPrjMenusV2EN.qsParameters = null; //qs参数
if (objQxPrjMenusV2EN.ImgFile == "[null]") objQxPrjMenusV2EN.ImgFile = null; //图像文件
if (objQxPrjMenusV2EN.TabId == "[null]") objQxPrjMenusV2EN.TabId = null; //表ID
if (objQxPrjMenusV2EN.RoleId == "[null]") objQxPrjMenusV2EN.RoleId = null; //角色Id
if (objQxPrjMenusV2EN.MenuSetId == "[null]") objQxPrjMenusV2EN.MenuSetId = null; //菜单集Id
if (objQxPrjMenusV2EN.MenuIdOld == "[null]") objQxPrjMenusV2EN.MenuIdOld = null; //MenuIdOld
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
public static void CheckPropertyNew(clsQxPrjMenusV2EN objQxPrjMenusV2EN)
{
 QxPrjMenusV2DA.CheckPropertyNew(objQxPrjMenusV2EN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsQxPrjMenusV2EN objQxPrjMenusV2EN)
{
 QxPrjMenusV2DA.CheckProperty4Condition(objQxPrjMenusV2EN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_idCache(System.Web.UI.WebControls.DropDownList objDDL, string strQxPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[工程菜单V2]...","0");
List<clsQxPrjMenusV2EN> arrQxPrjMenusV2ObjLst = GetAllQxPrjMenusV2ObjLstCache(strQxPrjId); 
objDDL.DataValueField = conQxPrjMenusV2.id;
objDDL.DataTextField = conQxPrjMenusV2.MenuName;
objDDL.DataSource = arrQxPrjMenusV2ObjLst;
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
if (clsQxPrjMenusV2BL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxPrjMenusV2BL没有刷新缓存机制(clsQxPrjMenusV2BL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id");
//if (arrQxPrjMenusV2ObjLstCache == null)
//{
//arrQxPrjMenusV2ObjLstCache = QxPrjMenusV2DA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "intid">所给的关键字</param>
 /// <param name = "strQxPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxPrjMenusV2EN GetObjByidCache(int intid, string strQxPrjId)
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
string strKey = string.Format("{0}_{1}", clsQxPrjMenusV2EN._CurrTabName, strQxPrjId);
List<clsQxPrjMenusV2EN> arrQxPrjMenusV2ObjLstCache = GetObjLstCache(strQxPrjId);
IEnumerable <clsQxPrjMenusV2EN> arrQxPrjMenusV2ObjLst_Sel =
arrQxPrjMenusV2ObjLstCache
.Where(x=> x.id == intid 
);
if (arrQxPrjMenusV2ObjLst_Sel.Count() == 0)
{
   clsQxPrjMenusV2EN obj = clsQxPrjMenusV2BL.GetObjByid(intid);
   if (obj != null)
 {
if (obj.QxPrjId == strQxPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", intid, strQxPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrQxPrjMenusV2ObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "intid">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetMenuNameByidCache(int intid, string strQxPrjId)
{
//获取缓存中的对象列表
clsQxPrjMenusV2EN objQxPrjMenusV2 = GetObjByidCache(intid, strQxPrjId);
if (objQxPrjMenusV2 == null) return "";
return objQxPrjMenusV2.MenuName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "intid">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByidCache(int intid, string strQxPrjId)
{
//获取缓存中的对象列表
clsQxPrjMenusV2EN objQxPrjMenusV2 = GetObjByidCache(intid, strQxPrjId);
if (objQxPrjMenusV2 == null) return "";
return objQxPrjMenusV2.MenuName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxPrjMenusV2EN> GetAllQxPrjMenusV2ObjLstCache(string strQxPrjId)
{
//获取缓存中的对象列表
List<clsQxPrjMenusV2EN> arrQxPrjMenusV2ObjLstCache = GetObjLstCache(strQxPrjId); 
return arrQxPrjMenusV2ObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxPrjMenusV2EN> GetObjLstCache(string strQxPrjId)
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
string strKey = string.Format("{0}_{1}", clsQxPrjMenusV2EN._CurrTabName, strQxPrjId);
string strCondition = string.Format("QxPrjId='{0}'", strQxPrjId);
List<clsQxPrjMenusV2EN> arrQxPrjMenusV2ObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrQxPrjMenusV2ObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsQxPrjMenusV2EN._CurrTabName, strQxPrjId);
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
if (clsQxPrjMenusV2BL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsQxPrjMenusV2EN._CurrTabName, strQxPrjId);
CacheHelper.Remove(strKey);
clsQxPrjMenusV2BL.objCommFun4BL.ReFreshCache(strQxPrjId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--QxPrjMenusV2(工程菜单V2)
 /// 唯一性条件:MenuName_QxPrjId_MenuSetId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQxPrjMenusV2EN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsQxPrjMenusV2EN objQxPrjMenusV2EN)
{
//检测记录是否存在
string strResult = QxPrjMenusV2DA.GetUniCondStr(objQxPrjMenusV2EN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstQxPrjMenusV2ObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsQxPrjMenusV2EN> lstQxPrjMenusV2ObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstQxPrjMenusV2ObjLst, writer);
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
 /// <param name = "lstQxPrjMenusV2ObjLst">[clsQxPrjMenusV2EN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsQxPrjMenusV2EN> lstQxPrjMenusV2ObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsQxPrjMenusV2BL.listXmlNode);
writer.WriteStartElement(clsQxPrjMenusV2BL.itemsXmlNode);
foreach (clsQxPrjMenusV2EN objQxPrjMenusV2EN in lstQxPrjMenusV2ObjLst)
{
clsQxPrjMenusV2BL.SerializeXML(writer, objQxPrjMenusV2EN);
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
 /// <param name = "objQxPrjMenusV2EN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsQxPrjMenusV2EN objQxPrjMenusV2EN)
{
writer.WriteStartElement(clsQxPrjMenusV2BL.itemXmlNode);
 
if (objQxPrjMenusV2EN.createdAt != null)
{
writer.WriteElementString(conQxPrjMenusV2.createdAt, objQxPrjMenusV2EN.createdAt.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjMenusV2EN.updatedAt != null)
{
writer.WriteElementString(conQxPrjMenusV2.updatedAt, objQxPrjMenusV2EN.updatedAt.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(conQxPrjMenusV2.id, objQxPrjMenusV2EN.id.ToString(CultureInfo.InvariantCulture));
 
writer.WriteElementString(conQxPrjMenusV2.parentMenuId, objQxPrjMenusV2EN.parentMenuId.ToString());
 
if (objQxPrjMenusV2EN.MenuName != null)
{
writer.WriteElementString(conQxPrjMenusV2.MenuName, objQxPrjMenusV2EN.MenuName.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjMenusV2EN.router != null)
{
writer.WriteElementString(conQxPrjMenusV2.router, objQxPrjMenusV2EN.router.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjMenusV2EN.perms != null)
{
writer.WriteElementString(conQxPrjMenusV2.perms, objQxPrjMenusV2EN.perms.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(conQxPrjMenusV2.type, objQxPrjMenusV2EN.type.ToString(CultureInfo.InvariantCulture));
 
if (objQxPrjMenusV2EN.icon != null)
{
writer.WriteElementString(conQxPrjMenusV2.icon, objQxPrjMenusV2EN.icon.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(conQxPrjMenusV2.OrderNum, objQxPrjMenusV2EN.OrderNum.ToString(CultureInfo.InvariantCulture));
 
if (objQxPrjMenusV2EN.viewPath != null)
{
writer.WriteElementString(conQxPrjMenusV2.viewPath, objQxPrjMenusV2EN.viewPath.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(conQxPrjMenusV2.keepalive, objQxPrjMenusV2EN.keepalive.ToString().ToLower(CultureInfo.InvariantCulture));
 
writer.WriteElementString(conQxPrjMenusV2.isShow, objQxPrjMenusV2EN.isShow.ToString().ToLower(CultureInfo.InvariantCulture));
 
writer.WriteElementString(conQxPrjMenusV2.isExt, objQxPrjMenusV2EN.isExt.ToString().ToLower(CultureInfo.InvariantCulture));
 
writer.WriteElementString(conQxPrjMenusV2.openMode, objQxPrjMenusV2EN.openMode.ToString(CultureInfo.InvariantCulture));
 
if (objQxPrjMenusV2EN.QxPrjId != null)
{
writer.WriteElementString(conQxPrjMenusV2.QxPrjId, objQxPrjMenusV2EN.QxPrjId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjMenusV2EN.UpdUserId != null)
{
writer.WriteElementString(conQxPrjMenusV2.UpdUserId, objQxPrjMenusV2EN.UpdUserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjMenusV2EN.Memo != null)
{
writer.WriteElementString(conQxPrjMenusV2.Memo, objQxPrjMenusV2EN.Memo.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjMenusV2EN.LinkFile != null)
{
writer.WriteElementString(conQxPrjMenusV2.LinkFile, objQxPrjMenusV2EN.LinkFile.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjMenusV2EN.UpdDate != null)
{
writer.WriteElementString(conQxPrjMenusV2.UpdDate, objQxPrjMenusV2EN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjMenusV2EN.MenuControlName != null)
{
writer.WriteElementString(conQxPrjMenusV2.MenuControlName, objQxPrjMenusV2EN.MenuControlName.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(conQxPrjMenusV2.ApplicationTypeId, objQxPrjMenusV2EN.ApplicationTypeId.ToString());
 
if (objQxPrjMenusV2EN.MenuTitle != null)
{
writer.WriteElementString(conQxPrjMenusV2.MenuTitle, objQxPrjMenusV2EN.MenuTitle.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjMenusV2EN.PageDispModeId != null)
{
writer.WriteElementString(conQxPrjMenusV2.PageDispModeId, objQxPrjMenusV2EN.PageDispModeId.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(conQxPrjMenusV2.InUse, objQxPrjMenusV2EN.InUse.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objQxPrjMenusV2EN.qsParameters != null)
{
writer.WriteElementString(conQxPrjMenusV2.qsParameters, objQxPrjMenusV2EN.qsParameters.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjMenusV2EN.ImgFile != null)
{
writer.WriteElementString(conQxPrjMenusV2.ImgFile, objQxPrjMenusV2EN.ImgFile.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjMenusV2EN.TabId != null)
{
writer.WriteElementString(conQxPrjMenusV2.TabId, objQxPrjMenusV2EN.TabId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjMenusV2EN.RoleId != null)
{
writer.WriteElementString(conQxPrjMenusV2.RoleId, objQxPrjMenusV2EN.RoleId.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(conQxPrjMenusV2.IsLeafNode, objQxPrjMenusV2EN.IsLeafNode.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objQxPrjMenusV2EN.MenuSetId != null)
{
writer.WriteElementString(conQxPrjMenusV2.MenuSetId, objQxPrjMenusV2EN.MenuSetId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjMenusV2EN.MenuIdOld != null)
{
writer.WriteElementString(conQxPrjMenusV2.MenuIdOld, objQxPrjMenusV2EN.MenuIdOld.ToString(CultureInfo.InvariantCulture));
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
public static clsQxPrjMenusV2EN GetObjFromXml(System.Xml.XmlReader reader)
{
clsQxPrjMenusV2EN objQxPrjMenusV2EN = new clsQxPrjMenusV2EN();
reader.Read();
while (!(reader.Name == clsQxPrjMenusV2BL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(conQxPrjMenusV2.createdAt))
{
objQxPrjMenusV2EN.createdAt = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjMenusV2.updatedAt))
{
objQxPrjMenusV2EN.updatedAt = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjMenusV2.id))
{
objQxPrjMenusV2EN.id = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(conQxPrjMenusV2.parentMenuId))
{
objQxPrjMenusV2EN.parentMenuId = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(conQxPrjMenusV2.MenuName))
{
objQxPrjMenusV2EN.MenuName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjMenusV2.router))
{
objQxPrjMenusV2EN.router = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjMenusV2.perms))
{
objQxPrjMenusV2EN.perms = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjMenusV2.type))
{
objQxPrjMenusV2EN.type = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(conQxPrjMenusV2.icon))
{
objQxPrjMenusV2EN.icon = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjMenusV2.OrderNum))
{
objQxPrjMenusV2EN.OrderNum = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(conQxPrjMenusV2.viewPath))
{
objQxPrjMenusV2EN.viewPath = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjMenusV2.keepalive))
{
objQxPrjMenusV2EN.keepalive = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(conQxPrjMenusV2.isShow))
{
objQxPrjMenusV2EN.isShow = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(conQxPrjMenusV2.isExt))
{
objQxPrjMenusV2EN.isExt = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(conQxPrjMenusV2.openMode))
{
objQxPrjMenusV2EN.openMode = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(conQxPrjMenusV2.QxPrjId))
{
objQxPrjMenusV2EN.QxPrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjMenusV2.UpdUserId))
{
objQxPrjMenusV2EN.UpdUserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjMenusV2.Memo))
{
objQxPrjMenusV2EN.Memo = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjMenusV2.LinkFile))
{
objQxPrjMenusV2EN.LinkFile = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjMenusV2.UpdDate))
{
objQxPrjMenusV2EN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjMenusV2.MenuControlName))
{
objQxPrjMenusV2EN.MenuControlName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjMenusV2.ApplicationTypeId))
{
objQxPrjMenusV2EN.ApplicationTypeId = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(conQxPrjMenusV2.MenuTitle))
{
objQxPrjMenusV2EN.MenuTitle = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjMenusV2.PageDispModeId))
{
objQxPrjMenusV2EN.PageDispModeId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjMenusV2.InUse))
{
objQxPrjMenusV2EN.InUse = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(conQxPrjMenusV2.qsParameters))
{
objQxPrjMenusV2EN.qsParameters = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjMenusV2.ImgFile))
{
objQxPrjMenusV2EN.ImgFile = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjMenusV2.TabId))
{
objQxPrjMenusV2EN.TabId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjMenusV2.RoleId))
{
objQxPrjMenusV2EN.RoleId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjMenusV2.IsLeafNode))
{
objQxPrjMenusV2EN.IsLeafNode = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(conQxPrjMenusV2.MenuSetId))
{
objQxPrjMenusV2EN.MenuSetId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjMenusV2.MenuIdOld))
{
objQxPrjMenusV2EN.MenuIdOld = reader.ReadElementContentAsString();
}
}
return objQxPrjMenusV2EN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strQxPrjMenusV2ObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsQxPrjMenusV2EN GetObjFromXmlStr(string strQxPrjMenusV2ObjXmlStr)
{
clsQxPrjMenusV2EN objQxPrjMenusV2EN = new clsQxPrjMenusV2EN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strQxPrjMenusV2ObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsQxPrjMenusV2BL.itemXmlNode))
{
objQxPrjMenusV2EN = GetObjFromXml(reader);
return objQxPrjMenusV2EN;
}
}
return objQxPrjMenusV2EN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objQxPrjMenusV2EN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsQxPrjMenusV2EN objQxPrjMenusV2EN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objQxPrjMenusV2EN);
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
public static string Func(string strInFldName, string strOutFldName, int intid, string strQxPrjId)
{
if (strInFldName != conQxPrjMenusV2.id)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conQxPrjMenusV2.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conQxPrjMenusV2.AttributeName));
throw new Exception(strMsg);
}
var objQxPrjMenusV2 = clsQxPrjMenusV2BL.GetObjByidCache(intid, strQxPrjId);
if (objQxPrjMenusV2 == null) return "";
return objQxPrjMenusV2[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objQxPrjMenusV2EN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsQxPrjMenusV2EN objQxPrjMenusV2EN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsQxPrjMenusV2EN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objQxPrjMenusV2EN[strField]);
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
 /// <param name = "lstQxPrjMenusV2ObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsQxPrjMenusV2EN> lstQxPrjMenusV2ObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstQxPrjMenusV2ObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsQxPrjMenusV2EN objQxPrjMenusV2EN in lstQxPrjMenusV2ObjLst)
{
string strJSON_One = SerializeObjToJSON(objQxPrjMenusV2EN);
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
int intRecCount = clsQxPrjMenusV2DA.GetRecCount(strTabName);
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
int intRecCount = clsQxPrjMenusV2DA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsQxPrjMenusV2DA.GetRecCount();
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
int intRecCount = clsQxPrjMenusV2DA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objQxPrjMenusV2Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsQxPrjMenusV2EN objQxPrjMenusV2Cond)
{
 string strQxPrjId = objQxPrjMenusV2Cond.QxPrjId;
 if (string.IsNullOrEmpty(strQxPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsQxPrjMenusV2BL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsQxPrjMenusV2EN> arrObjLstCache = GetObjLstCache(strQxPrjId);
IEnumerable <clsQxPrjMenusV2EN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxPrjMenusV2.AttributeName)
{
if (objQxPrjMenusV2Cond.IsUpdated(strFldName) == false) continue;
if (objQxPrjMenusV2Cond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxPrjMenusV2Cond[strFldName].ToString());
}
else
{
if (objQxPrjMenusV2Cond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxPrjMenusV2Cond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxPrjMenusV2Cond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxPrjMenusV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxPrjMenusV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxPrjMenusV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxPrjMenusV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxPrjMenusV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxPrjMenusV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxPrjMenusV2Cond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxPrjMenusV2Cond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxPrjMenusV2Cond[strFldName]));
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
 List<string> arrList = clsQxPrjMenusV2DA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = QxPrjMenusV2DA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = QxPrjMenusV2DA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = QxPrjMenusV2DA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxPrjMenusV2DA.SetFldValue(clsQxPrjMenusV2EN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = QxPrjMenusV2DA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxPrjMenusV2DA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxPrjMenusV2DA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxPrjMenusV2DA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[QxPrjMenusV2] "); 
 strCreateTabCode.Append(" ( "); 
 // /**建立时间*/ 
 strCreateTabCode.Append(" createdAt varchar(20) Null, "); 
 // /**修改时间*/ 
 strCreateTabCode.Append(" updatedAt varchar(20) Null, "); 
 // /**id*/ 
 strCreateTabCode.Append(" id int primary key identity, "); 
 // /**上级菜单Id*/ 
 strCreateTabCode.Append(" parentMenuId int Null, "); 
 // /**菜单名*/ 
 strCreateTabCode.Append(" MenuName varchar(50) not Null, "); 
 // /**链接文件*/ 
 strCreateTabCode.Append(" router varchar(500) Null, "); 
 // /**链接文件*/ 
 strCreateTabCode.Append(" perms varchar(500) Null, "); 
 // /**排序号*/ 
 strCreateTabCode.Append(" type int not Null, "); 
 // /**链接文件*/ 
 strCreateTabCode.Append(" icon varchar(500) Null, "); 
 // /**排序号*/ 
 strCreateTabCode.Append(" OrderNum int not Null, "); 
 // /**图像文件*/ 
 strCreateTabCode.Append(" viewPath varchar(300) Null, "); 
 // /**是否在用*/ 
 strCreateTabCode.Append(" keepalive bit Null, "); 
 // /**是否在用*/ 
 strCreateTabCode.Append(" isShow bit Null, "); 
 // /**是否在用*/ 
 strCreateTabCode.Append(" isExt bit Null, "); 
 // /**应用程序类型ID*/ 
 strCreateTabCode.Append(" openMode int not Null, "); 
 // /**项目Id*/ 
 strCreateTabCode.Append(" QxPrjId char(4) Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**链接文件*/ 
 strCreateTabCode.Append(" LinkFile varchar(500) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**MenuControlName*/ 
 strCreateTabCode.Append(" MenuControlName varchar(100) Null, "); 
 // /**应用程序类型ID*/ 
 strCreateTabCode.Append(" ApplicationTypeId int Null, "); 
 // /**菜单标题*/ 
 strCreateTabCode.Append(" MenuTitle varchar(50) Null, "); 
 // /**页面显示模式Id*/ 
 strCreateTabCode.Append(" PageDispModeId char(2) Null, "); 
 // /**是否在用*/ 
 strCreateTabCode.Append(" InUse bit Null, "); 
 // /**qs参数*/ 
 strCreateTabCode.Append(" qsParameters varchar(200) Null, "); 
 // /**图像文件*/ 
 strCreateTabCode.Append(" ImgFile varchar(300) Null, "); 
 // /**表ID*/ 
 strCreateTabCode.Append(" TabId char(8) Null, "); 
 // /**角色Id*/ 
 strCreateTabCode.Append(" RoleId char(8) Null, "); 
 // /**是否叶子*/ 
 strCreateTabCode.Append(" IsLeafNode bit Null, "); 
 // /**菜单集Id*/ 
 strCreateTabCode.Append(" MenuSetId char(4) Null, "); 
 // /**MenuIdOld*/ 
 strCreateTabCode.Append(" MenuIdOld char(8) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 数据同步


 #endregion 数据同步
}
 /// <summary>
 /// 工程菜单V2(QxPrjMenusV2)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4QxPrjMenusV2 : clsCommFun4BLV2
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
clsQxPrjMenusV2BL.ReFreshThisCache(strQxPrjId);
}
}

}