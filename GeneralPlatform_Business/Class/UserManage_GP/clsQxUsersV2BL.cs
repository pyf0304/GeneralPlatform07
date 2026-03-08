
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUsersV2BL
 表名:QxUsersV2(00140110)
 * 版本:2023.12.26.1(服务器:WIN-SRV103-116)
 日期:2023/12/28 19:01:20
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:用户管理(UserManage_GP)
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
public static class  clsQxUsersV2BL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "intid">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxUsersV2EN GetObj(this K_id_QxUsersV2 myKey)
{
clsQxUsersV2EN objQxUsersV2EN = clsQxUsersV2BL.QxUsersV2DA.GetObjByid(myKey.Value);
return objQxUsersV2EN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQxUsersV2EN objQxUsersV2EN)
{
if (CheckUniqueness(objQxUsersV2EN) == false)
{
var strMsg = string.Format("记录已经存在!姓名 = [{0}],电话号码 = [{1}]的数据已经存在!(in clsQxUsersV2BL.AddNewRecord)", objQxUsersV2EN.name,objQxUsersV2EN.phone);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsQxUsersV2BL.QxUsersV2DA.AddNewRecordBySQL2(objQxUsersV2EN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsersV2BL.ReFreshCache();

if (clsQxUsersV2BL.relatedActions != null)
{
clsQxUsersV2BL.relatedActions.UpdRelaTabDate(objQxUsersV2EN.id, objQxUsersV2EN.UpdUser);
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
public static bool AddRecordEx(this clsQxUsersV2EN objQxUsersV2EN)
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
objQxUsersV2EN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objQxUsersV2EN.CheckUniqueness() == false)
{
strMsg = string.Format("(姓名(name)=[{0}],电话号码(phone)=[{1}])已经存在,不能重复!", objQxUsersV2EN.name, objQxUsersV2EN.phone);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objQxUsersV2EN.AddNewRecord();
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
 /// <param name = "objQxUsersV2EN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsQxUsersV2EN objQxUsersV2EN)
{
if (CheckUniqueness(objQxUsersV2EN) == false)
{
var strMsg = string.Format("记录已经存在!姓名 = [{0}],电话号码 = [{1}]的数据已经存在!(in clsQxUsersV2BL.AddNewRecordWithReturnKey)", objQxUsersV2EN.name,objQxUsersV2EN.phone);
throw new Exception(strMsg);
}
try
{
string strKey = clsQxUsersV2BL.QxUsersV2DA.AddNewRecordBySQL2WithReturnKey(objQxUsersV2EN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsersV2BL.ReFreshCache();

if (clsQxUsersV2BL.relatedActions != null)
{
clsQxUsersV2BL.relatedActions.UpdRelaTabDate(objQxUsersV2EN.id, objQxUsersV2EN.UpdUser);
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
 /// <param name = "objQxUsersV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersV2EN SetCreateTime(this clsQxUsersV2EN objQxUsersV2EN, string strCreateTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateTime, 20, conQxUsersV2.CreateTime);
}
objQxUsersV2EN.CreateTime = strCreateTime; //建立时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersV2EN.dicFldComparisonOp.ContainsKey(conQxUsersV2.CreateTime) == false)
{
objQxUsersV2EN.dicFldComparisonOp.Add(conQxUsersV2.CreateTime, strComparisonOp);
}
else
{
objQxUsersV2EN.dicFldComparisonOp[conQxUsersV2.CreateTime] = strComparisonOp;
}
}
return objQxUsersV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersV2EN SetupdateTime(this clsQxUsersV2EN objQxUsersV2EN, string strupdateTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strupdateTime, 20, conQxUsersV2.updateTime);
}
objQxUsersV2EN.updateTime = strupdateTime; //修改时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersV2EN.dicFldComparisonOp.ContainsKey(conQxUsersV2.updateTime) == false)
{
objQxUsersV2EN.dicFldComparisonOp.Add(conQxUsersV2.updateTime, strComparisonOp);
}
else
{
objQxUsersV2EN.dicFldComparisonOp[conQxUsersV2.updateTime] = strComparisonOp;
}
}
return objQxUsersV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersV2EN Setid(this clsQxUsersV2EN objQxUsersV2EN, int intid, string strComparisonOp="")
	{
objQxUsersV2EN.id = intid; //id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersV2EN.dicFldComparisonOp.ContainsKey(conQxUsersV2.id) == false)
{
objQxUsersV2EN.dicFldComparisonOp.Add(conQxUsersV2.id, strComparisonOp);
}
else
{
objQxUsersV2EN.dicFldComparisonOp[conQxUsersV2.id] = strComparisonOp;
}
}
return objQxUsersV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersV2EN SetDepartmentIdInt(this clsQxUsersV2EN objQxUsersV2EN, int? intDepartmentIdInt, string strComparisonOp="")
	{
objQxUsersV2EN.DepartmentIdInt = intDepartmentIdInt; //部门Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersV2EN.dicFldComparisonOp.ContainsKey(conQxUsersV2.DepartmentIdInt) == false)
{
objQxUsersV2EN.dicFldComparisonOp.Add(conQxUsersV2.DepartmentIdInt, strComparisonOp);
}
else
{
objQxUsersV2EN.dicFldComparisonOp[conQxUsersV2.DepartmentIdInt] = strComparisonOp;
}
}
return objQxUsersV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersV2EN Setname(this clsQxUsersV2EN objQxUsersV2EN, string strname, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strname, conQxUsersV2.name);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strname, 30, conQxUsersV2.name);
}
objQxUsersV2EN.name = strname; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersV2EN.dicFldComparisonOp.ContainsKey(conQxUsersV2.name) == false)
{
objQxUsersV2EN.dicFldComparisonOp.Add(conQxUsersV2.name, strComparisonOp);
}
else
{
objQxUsersV2EN.dicFldComparisonOp[conQxUsersV2.name] = strComparisonOp;
}
}
return objQxUsersV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersV2EN SetUserName(this clsQxUsersV2EN objQxUsersV2EN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, conQxUsersV2.UserName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, conQxUsersV2.UserName);
}
objQxUsersV2EN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersV2EN.dicFldComparisonOp.ContainsKey(conQxUsersV2.UserName) == false)
{
objQxUsersV2EN.dicFldComparisonOp.Add(conQxUsersV2.UserName, strComparisonOp);
}
else
{
objQxUsersV2EN.dicFldComparisonOp[conQxUsersV2.UserName] = strComparisonOp;
}
}
return objQxUsersV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersV2EN SetPassword(this clsQxUsersV2EN objQxUsersV2EN, string strPassword, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPassword, conQxUsersV2.Password);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPassword, 20, conQxUsersV2.Password);
}
objQxUsersV2EN.Password = strPassword; //口令
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersV2EN.dicFldComparisonOp.ContainsKey(conQxUsersV2.Password) == false)
{
objQxUsersV2EN.dicFldComparisonOp.Add(conQxUsersV2.Password, strComparisonOp);
}
else
{
objQxUsersV2EN.dicFldComparisonOp[conQxUsersV2.Password] = strComparisonOp;
}
}
return objQxUsersV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersV2EN Setpsalt(this clsQxUsersV2EN objQxUsersV2EN, string strpsalt, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strpsalt, 20, conQxUsersV2.psalt);
}
objQxUsersV2EN.psalt = strpsalt; //密码盐值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersV2EN.dicFldComparisonOp.ContainsKey(conQxUsersV2.psalt) == false)
{
objQxUsersV2EN.dicFldComparisonOp.Add(conQxUsersV2.psalt, strComparisonOp);
}
else
{
objQxUsersV2EN.dicFldComparisonOp[conQxUsersV2.psalt] = strComparisonOp;
}
}
return objQxUsersV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersV2EN SetnickName(this clsQxUsersV2EN objQxUsersV2EN, string strnickName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strnickName, 100, conQxUsersV2.nickName);
}
objQxUsersV2EN.nickName = strnickName; //呢称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersV2EN.dicFldComparisonOp.ContainsKey(conQxUsersV2.nickName) == false)
{
objQxUsersV2EN.dicFldComparisonOp.Add(conQxUsersV2.nickName, strComparisonOp);
}
else
{
objQxUsersV2EN.dicFldComparisonOp[conQxUsersV2.nickName] = strComparisonOp;
}
}
return objQxUsersV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersV2EN SetheadImg(this clsQxUsersV2EN objQxUsersV2EN, string strheadImg, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strheadImg, 100, conQxUsersV2.headImg);
}
objQxUsersV2EN.headImg = strheadImg; //头像
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersV2EN.dicFldComparisonOp.ContainsKey(conQxUsersV2.headImg) == false)
{
objQxUsersV2EN.dicFldComparisonOp.Add(conQxUsersV2.headImg, strComparisonOp);
}
else
{
objQxUsersV2EN.dicFldComparisonOp[conQxUsersV2.headImg] = strComparisonOp;
}
}
return objQxUsersV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersV2EN SetEmail(this clsQxUsersV2EN objQxUsersV2EN, string strEmail, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEmail, 100, conQxUsersV2.Email);
}
objQxUsersV2EN.Email = strEmail; //邮箱
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersV2EN.dicFldComparisonOp.ContainsKey(conQxUsersV2.Email) == false)
{
objQxUsersV2EN.dicFldComparisonOp.Add(conQxUsersV2.Email, strComparisonOp);
}
else
{
objQxUsersV2EN.dicFldComparisonOp[conQxUsersV2.Email] = strComparisonOp;
}
}
return objQxUsersV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersV2EN Setphone(this clsQxUsersV2EN objQxUsersV2EN, string strphone, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strphone, conQxUsersV2.phone);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strphone, 15, conQxUsersV2.phone);
}
objQxUsersV2EN.phone = strphone; //电话号码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersV2EN.dicFldComparisonOp.ContainsKey(conQxUsersV2.phone) == false)
{
objQxUsersV2EN.dicFldComparisonOp.Add(conQxUsersV2.phone, strComparisonOp);
}
else
{
objQxUsersV2EN.dicFldComparisonOp[conQxUsersV2.phone] = strComparisonOp;
}
}
return objQxUsersV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersV2EN Setremark(this clsQxUsersV2EN objQxUsersV2EN, string strremark, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strremark, 1000, conQxUsersV2.remark);
}
objQxUsersV2EN.remark = strremark; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersV2EN.dicFldComparisonOp.ContainsKey(conQxUsersV2.remark) == false)
{
objQxUsersV2EN.dicFldComparisonOp.Add(conQxUsersV2.remark, strComparisonOp);
}
else
{
objQxUsersV2EN.dicFldComparisonOp[conQxUsersV2.remark] = strComparisonOp;
}
}
return objQxUsersV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersV2EN Setstatus(this clsQxUsersV2EN objQxUsersV2EN, int intstatus, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intstatus, conQxUsersV2.status);
objQxUsersV2EN.status = intstatus; //用户状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersV2EN.dicFldComparisonOp.ContainsKey(conQxUsersV2.status) == false)
{
objQxUsersV2EN.dicFldComparisonOp.Add(conQxUsersV2.status, strComparisonOp);
}
else
{
objQxUsersV2EN.dicFldComparisonOp[conQxUsersV2.status] = strComparisonOp;
}
}
return objQxUsersV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersV2EN SetOpenId(this clsQxUsersV2EN objQxUsersV2EN, string strOpenId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOpenId, 50, conQxUsersV2.OpenId);
}
objQxUsersV2EN.OpenId = strOpenId; //微信openid
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersV2EN.dicFldComparisonOp.ContainsKey(conQxUsersV2.OpenId) == false)
{
objQxUsersV2EN.dicFldComparisonOp.Add(conQxUsersV2.OpenId, strComparisonOp);
}
else
{
objQxUsersV2EN.dicFldComparisonOp[conQxUsersV2.OpenId] = strComparisonOp;
}
}
return objQxUsersV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersV2EN SetUpdUser(this clsQxUsersV2EN objQxUsersV2EN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conQxUsersV2.UpdUser);
}
objQxUsersV2EN.UpdUser = strUpdUser; //修改用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersV2EN.dicFldComparisonOp.ContainsKey(conQxUsersV2.UpdUser) == false)
{
objQxUsersV2EN.dicFldComparisonOp.Add(conQxUsersV2.UpdUser, strComparisonOp);
}
else
{
objQxUsersV2EN.dicFldComparisonOp[conQxUsersV2.UpdUser] = strComparisonOp;
}
}
return objQxUsersV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersV2EN SetIsArchive(this clsQxUsersV2EN objQxUsersV2EN, bool bolIsArchive, string strComparisonOp="")
	{
objQxUsersV2EN.IsArchive = bolIsArchive; //是否存档
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersV2EN.dicFldComparisonOp.ContainsKey(conQxUsersV2.IsArchive) == false)
{
objQxUsersV2EN.dicFldComparisonOp.Add(conQxUsersV2.IsArchive, strComparisonOp);
}
else
{
objQxUsersV2EN.dicFldComparisonOp[conQxUsersV2.IsArchive] = strComparisonOp;
}
}
return objQxUsersV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersV2EN SetIdentityId(this clsQxUsersV2EN objQxUsersV2EN, string strIdentityId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdentityId, 2, conQxUsersV2.IdentityId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdentityId, 2, conQxUsersV2.IdentityId);
}
objQxUsersV2EN.IdentityId = strIdentityId; //身份编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersV2EN.dicFldComparisonOp.ContainsKey(conQxUsersV2.IdentityId) == false)
{
objQxUsersV2EN.dicFldComparisonOp.Add(conQxUsersV2.IdentityId, strComparisonOp);
}
else
{
objQxUsersV2EN.dicFldComparisonOp[conQxUsersV2.IdentityId] = strComparisonOp;
}
}
return objQxUsersV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersV2EN SetStuTeacherId(this clsQxUsersV2EN objQxUsersV2EN, string strStuTeacherId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuTeacherId, 20, conQxUsersV2.StuTeacherId);
}
objQxUsersV2EN.StuTeacherId = strStuTeacherId; //学工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersV2EN.dicFldComparisonOp.ContainsKey(conQxUsersV2.StuTeacherId) == false)
{
objQxUsersV2EN.dicFldComparisonOp.Add(conQxUsersV2.StuTeacherId, strComparisonOp);
}
else
{
objQxUsersV2EN.dicFldComparisonOp[conQxUsersV2.StuTeacherId] = strComparisonOp;
}
}
return objQxUsersV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersV2EN SetEffitiveBeginDate(this clsQxUsersV2EN objQxUsersV2EN, string strEffitiveBeginDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEffitiveBeginDate, 14, conQxUsersV2.EffitiveBeginDate);
}
objQxUsersV2EN.EffitiveBeginDate = strEffitiveBeginDate; //有效开始日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersV2EN.dicFldComparisonOp.ContainsKey(conQxUsersV2.EffitiveBeginDate) == false)
{
objQxUsersV2EN.dicFldComparisonOp.Add(conQxUsersV2.EffitiveBeginDate, strComparisonOp);
}
else
{
objQxUsersV2EN.dicFldComparisonOp[conQxUsersV2.EffitiveBeginDate] = strComparisonOp;
}
}
return objQxUsersV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersV2EN SetEffitiveEndDate(this clsQxUsersV2EN objQxUsersV2EN, string strEffitiveEndDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEffitiveEndDate, 14, conQxUsersV2.EffitiveEndDate);
}
objQxUsersV2EN.EffitiveEndDate = strEffitiveEndDate; //有效结束日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersV2EN.dicFldComparisonOp.ContainsKey(conQxUsersV2.EffitiveEndDate) == false)
{
objQxUsersV2EN.dicFldComparisonOp.Add(conQxUsersV2.EffitiveEndDate, strComparisonOp);
}
else
{
objQxUsersV2EN.dicFldComparisonOp[conQxUsersV2.EffitiveEndDate] = strComparisonOp;
}
}
return objQxUsersV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersV2EN SetUserId(this clsQxUsersV2EN objQxUsersV2EN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, conQxUsersV2.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conQxUsersV2.UserId);
}
objQxUsersV2EN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersV2EN.dicFldComparisonOp.ContainsKey(conQxUsersV2.UserId) == false)
{
objQxUsersV2EN.dicFldComparisonOp.Add(conQxUsersV2.UserId, strComparisonOp);
}
else
{
objQxUsersV2EN.dicFldComparisonOp[conQxUsersV2.UserId] = strComparisonOp;
}
}
return objQxUsersV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersV2EN SetEffectiveDate(this clsQxUsersV2EN objQxUsersV2EN, string strEffectiveDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEffectiveDate, 8, conQxUsersV2.EffectiveDate);
}
objQxUsersV2EN.EffectiveDate = strEffectiveDate; //有效日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersV2EN.dicFldComparisonOp.ContainsKey(conQxUsersV2.EffectiveDate) == false)
{
objQxUsersV2EN.dicFldComparisonOp.Add(conQxUsersV2.EffectiveDate, strComparisonOp);
}
else
{
objQxUsersV2EN.dicFldComparisonOp[conQxUsersV2.EffectiveDate] = strComparisonOp;
}
}
return objQxUsersV2EN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsQxUsersV2EN objQxUsersV2EN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objQxUsersV2EN.CheckPropertyNew();
clsQxUsersV2EN objQxUsersV2Cond = new clsQxUsersV2EN();
string strCondition = objQxUsersV2Cond
.Setid(objQxUsersV2EN.id, "<>")
.Setname(objQxUsersV2EN.name, "=")
.Setphone(objQxUsersV2EN.phone, "=")
.GetCombineCondition();
objQxUsersV2EN._IsCheckProperty = true;
bool bolIsExist = clsQxUsersV2BL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(name_phone)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objQxUsersV2EN.Update();
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
 /// <param name = "objQxUsersV2">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsQxUsersV2EN objQxUsersV2)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsQxUsersV2EN objQxUsersV2Cond = new clsQxUsersV2EN();
string strCondition = objQxUsersV2Cond
.Setname(objQxUsersV2.name, "=")
.Setphone(objQxUsersV2.phone, "=")
.GetCombineCondition();
objQxUsersV2._IsCheckProperty = true;
bool bolIsExist = clsQxUsersV2BL.IsExistRecord(strCondition);
if (bolIsExist)
{
objQxUsersV2.id = clsQxUsersV2BL.GetFirstID_S(strCondition);
objQxUsersV2.UpdateWithCondition(strCondition);
}
else
{
objQxUsersV2.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxUsersV2EN objQxUsersV2EN)
{
 if (objQxUsersV2EN.id == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxUsersV2BL.QxUsersV2DA.UpdateBySql2(objQxUsersV2EN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsersV2BL.ReFreshCache();

if (clsQxUsersV2BL.relatedActions != null)
{
clsQxUsersV2BL.relatedActions.UpdRelaTabDate(objQxUsersV2EN.id, objQxUsersV2EN.UpdUser);
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
 /// <param name = "objQxUsersV2EN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxUsersV2EN objQxUsersV2EN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objQxUsersV2EN.id == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxUsersV2BL.QxUsersV2DA.UpdateBySql2(objQxUsersV2EN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsersV2BL.ReFreshCache();

if (clsQxUsersV2BL.relatedActions != null)
{
clsQxUsersV2BL.relatedActions.UpdRelaTabDate(objQxUsersV2EN.id, objQxUsersV2EN.UpdUser);
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
 /// <param name = "objQxUsersV2EN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxUsersV2EN objQxUsersV2EN, string strWhereCond)
{
try
{
bool bolResult = clsQxUsersV2BL.QxUsersV2DA.UpdateBySqlWithCondition(objQxUsersV2EN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsersV2BL.ReFreshCache();

if (clsQxUsersV2BL.relatedActions != null)
{
clsQxUsersV2BL.relatedActions.UpdRelaTabDate(objQxUsersV2EN.id, objQxUsersV2EN.UpdUser);
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
 /// <param name = "objQxUsersV2EN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxUsersV2EN objQxUsersV2EN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsQxUsersV2BL.QxUsersV2DA.UpdateBySqlWithConditionTransaction(objQxUsersV2EN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsersV2BL.ReFreshCache();

if (clsQxUsersV2BL.relatedActions != null)
{
clsQxUsersV2BL.relatedActions.UpdRelaTabDate(objQxUsersV2EN.id, objQxUsersV2EN.UpdUser);
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
public static int Delete(this clsQxUsersV2EN objQxUsersV2EN)
{
try
{
int intRecNum = clsQxUsersV2BL.QxUsersV2DA.DelRecord(objQxUsersV2EN.id);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsersV2BL.ReFreshCache();

if (clsQxUsersV2BL.relatedActions != null)
{
clsQxUsersV2BL.relatedActions.UpdRelaTabDate(objQxUsersV2EN.id, objQxUsersV2EN.UpdUser);
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
 /// <param name = "objQxUsersV2ENS">源对象</param>
 /// <param name = "objQxUsersV2ENT">目标对象</param>
 public static void CopyTo(this clsQxUsersV2EN objQxUsersV2ENS, clsQxUsersV2EN objQxUsersV2ENT)
{
try
{
objQxUsersV2ENT.CreateTime = objQxUsersV2ENS.CreateTime; //建立时间
objQxUsersV2ENT.updateTime = objQxUsersV2ENS.updateTime; //修改时间
objQxUsersV2ENT.id = objQxUsersV2ENS.id; //id
objQxUsersV2ENT.DepartmentIdInt = objQxUsersV2ENS.DepartmentIdInt; //部门Id
objQxUsersV2ENT.name = objQxUsersV2ENS.name; //姓名
objQxUsersV2ENT.UserName = objQxUsersV2ENS.UserName; //用户名
objQxUsersV2ENT.Password = objQxUsersV2ENS.Password; //口令
objQxUsersV2ENT.psalt = objQxUsersV2ENS.psalt; //密码盐值
objQxUsersV2ENT.nickName = objQxUsersV2ENS.nickName; //呢称
objQxUsersV2ENT.headImg = objQxUsersV2ENS.headImg; //头像
objQxUsersV2ENT.Email = objQxUsersV2ENS.Email; //邮箱
objQxUsersV2ENT.phone = objQxUsersV2ENS.phone; //电话号码
objQxUsersV2ENT.remark = objQxUsersV2ENS.remark; //备注
objQxUsersV2ENT.status = objQxUsersV2ENS.status; //用户状态Id
objQxUsersV2ENT.OpenId = objQxUsersV2ENS.OpenId; //微信openid
objQxUsersV2ENT.UpdUser = objQxUsersV2ENS.UpdUser; //修改用户
objQxUsersV2ENT.IsArchive = objQxUsersV2ENS.IsArchive; //是否存档
objQxUsersV2ENT.IdentityId = objQxUsersV2ENS.IdentityId; //身份编号
objQxUsersV2ENT.StuTeacherId = objQxUsersV2ENS.StuTeacherId; //学工号
objQxUsersV2ENT.EffitiveBeginDate = objQxUsersV2ENS.EffitiveBeginDate; //有效开始日期
objQxUsersV2ENT.EffitiveEndDate = objQxUsersV2ENS.EffitiveEndDate; //有效结束日期
objQxUsersV2ENT.UserId = objQxUsersV2ENS.UserId; //用户ID
objQxUsersV2ENT.EffectiveDate = objQxUsersV2ENS.EffectiveDate; //有效日期
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
 /// <param name = "objQxUsersV2ENS">源对象</param>
 /// <returns>目标对象=>clsQxUsersV2EN:objQxUsersV2ENT</returns>
 public static clsQxUsersV2EN CopyTo(this clsQxUsersV2EN objQxUsersV2ENS)
{
try
{
 clsQxUsersV2EN objQxUsersV2ENT = new clsQxUsersV2EN()
{
CreateTime = objQxUsersV2ENS.CreateTime, //建立时间
updateTime = objQxUsersV2ENS.updateTime, //修改时间
id = objQxUsersV2ENS.id, //id
DepartmentIdInt = objQxUsersV2ENS.DepartmentIdInt, //部门Id
name = objQxUsersV2ENS.name, //姓名
UserName = objQxUsersV2ENS.UserName, //用户名
Password = objQxUsersV2ENS.Password, //口令
psalt = objQxUsersV2ENS.psalt, //密码盐值
nickName = objQxUsersV2ENS.nickName, //呢称
headImg = objQxUsersV2ENS.headImg, //头像
Email = objQxUsersV2ENS.Email, //邮箱
phone = objQxUsersV2ENS.phone, //电话号码
remark = objQxUsersV2ENS.remark, //备注
status = objQxUsersV2ENS.status, //用户状态Id
OpenId = objQxUsersV2ENS.OpenId, //微信openid
UpdUser = objQxUsersV2ENS.UpdUser, //修改用户
IsArchive = objQxUsersV2ENS.IsArchive, //是否存档
IdentityId = objQxUsersV2ENS.IdentityId, //身份编号
StuTeacherId = objQxUsersV2ENS.StuTeacherId, //学工号
EffitiveBeginDate = objQxUsersV2ENS.EffitiveBeginDate, //有效开始日期
EffitiveEndDate = objQxUsersV2ENS.EffitiveEndDate, //有效结束日期
UserId = objQxUsersV2ENS.UserId, //用户ID
EffectiveDate = objQxUsersV2ENS.EffectiveDate, //有效日期
};
 return objQxUsersV2ENT;
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
public static void CheckPropertyNew(this clsQxUsersV2EN objQxUsersV2EN)
{
 clsQxUsersV2BL.QxUsersV2DA.CheckPropertyNew(objQxUsersV2EN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsQxUsersV2EN objQxUsersV2EN)
{
 clsQxUsersV2BL.QxUsersV2DA.CheckProperty4Condition(objQxUsersV2EN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQxUsersV2EN objQxUsersV2Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQxUsersV2Cond.IsUpdated(conQxUsersV2.CreateTime) == true)
{
string strComparisonOpCreateTime = objQxUsersV2Cond.dicFldComparisonOp[conQxUsersV2.CreateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsersV2.CreateTime, objQxUsersV2Cond.CreateTime, strComparisonOpCreateTime);
}
if (objQxUsersV2Cond.IsUpdated(conQxUsersV2.updateTime) == true)
{
string strComparisonOpupdateTime = objQxUsersV2Cond.dicFldComparisonOp[conQxUsersV2.updateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsersV2.updateTime, objQxUsersV2Cond.updateTime, strComparisonOpupdateTime);
}
if (objQxUsersV2Cond.IsUpdated(conQxUsersV2.id) == true)
{
string strComparisonOpid = objQxUsersV2Cond.dicFldComparisonOp[conQxUsersV2.id];
strWhereCond += string.Format(" And {0} {2} {1}", conQxUsersV2.id, objQxUsersV2Cond.id, strComparisonOpid);
}
if (objQxUsersV2Cond.IsUpdated(conQxUsersV2.DepartmentIdInt) == true)
{
string strComparisonOpDepartmentIdInt = objQxUsersV2Cond.dicFldComparisonOp[conQxUsersV2.DepartmentIdInt];
strWhereCond += string.Format(" And {0} {2} {1}", conQxUsersV2.DepartmentIdInt, objQxUsersV2Cond.DepartmentIdInt, strComparisonOpDepartmentIdInt);
}
if (objQxUsersV2Cond.IsUpdated(conQxUsersV2.name) == true)
{
string strComparisonOpname = objQxUsersV2Cond.dicFldComparisonOp[conQxUsersV2.name];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsersV2.name, objQxUsersV2Cond.name, strComparisonOpname);
}
if (objQxUsersV2Cond.IsUpdated(conQxUsersV2.UserName) == true)
{
string strComparisonOpUserName = objQxUsersV2Cond.dicFldComparisonOp[conQxUsersV2.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsersV2.UserName, objQxUsersV2Cond.UserName, strComparisonOpUserName);
}
if (objQxUsersV2Cond.IsUpdated(conQxUsersV2.Password) == true)
{
string strComparisonOpPassword = objQxUsersV2Cond.dicFldComparisonOp[conQxUsersV2.Password];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsersV2.Password, objQxUsersV2Cond.Password, strComparisonOpPassword);
}
if (objQxUsersV2Cond.IsUpdated(conQxUsersV2.psalt) == true)
{
string strComparisonOppsalt = objQxUsersV2Cond.dicFldComparisonOp[conQxUsersV2.psalt];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsersV2.psalt, objQxUsersV2Cond.psalt, strComparisonOppsalt);
}
if (objQxUsersV2Cond.IsUpdated(conQxUsersV2.nickName) == true)
{
string strComparisonOpnickName = objQxUsersV2Cond.dicFldComparisonOp[conQxUsersV2.nickName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsersV2.nickName, objQxUsersV2Cond.nickName, strComparisonOpnickName);
}
if (objQxUsersV2Cond.IsUpdated(conQxUsersV2.headImg) == true)
{
string strComparisonOpheadImg = objQxUsersV2Cond.dicFldComparisonOp[conQxUsersV2.headImg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsersV2.headImg, objQxUsersV2Cond.headImg, strComparisonOpheadImg);
}
if (objQxUsersV2Cond.IsUpdated(conQxUsersV2.Email) == true)
{
string strComparisonOpEmail = objQxUsersV2Cond.dicFldComparisonOp[conQxUsersV2.Email];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsersV2.Email, objQxUsersV2Cond.Email, strComparisonOpEmail);
}
if (objQxUsersV2Cond.IsUpdated(conQxUsersV2.phone) == true)
{
string strComparisonOpphone = objQxUsersV2Cond.dicFldComparisonOp[conQxUsersV2.phone];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsersV2.phone, objQxUsersV2Cond.phone, strComparisonOpphone);
}
if (objQxUsersV2Cond.IsUpdated(conQxUsersV2.remark) == true)
{
string strComparisonOpremark = objQxUsersV2Cond.dicFldComparisonOp[conQxUsersV2.remark];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsersV2.remark, objQxUsersV2Cond.remark, strComparisonOpremark);
}
if (objQxUsersV2Cond.IsUpdated(conQxUsersV2.status) == true)
{
string strComparisonOpstatus = objQxUsersV2Cond.dicFldComparisonOp[conQxUsersV2.status];
strWhereCond += string.Format(" And {0} {2} {1}", conQxUsersV2.status, objQxUsersV2Cond.status, strComparisonOpstatus);
}
if (objQxUsersV2Cond.IsUpdated(conQxUsersV2.OpenId) == true)
{
string strComparisonOpOpenId = objQxUsersV2Cond.dicFldComparisonOp[conQxUsersV2.OpenId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsersV2.OpenId, objQxUsersV2Cond.OpenId, strComparisonOpOpenId);
}
if (objQxUsersV2Cond.IsUpdated(conQxUsersV2.UpdUser) == true)
{
string strComparisonOpUpdUser = objQxUsersV2Cond.dicFldComparisonOp[conQxUsersV2.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsersV2.UpdUser, objQxUsersV2Cond.UpdUser, strComparisonOpUpdUser);
}
if (objQxUsersV2Cond.IsUpdated(conQxUsersV2.IsArchive) == true)
{
if (objQxUsersV2Cond.IsArchive == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQxUsersV2.IsArchive);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQxUsersV2.IsArchive);
}
}
if (objQxUsersV2Cond.IsUpdated(conQxUsersV2.IdentityId) == true)
{
string strComparisonOpIdentityId = objQxUsersV2Cond.dicFldComparisonOp[conQxUsersV2.IdentityId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsersV2.IdentityId, objQxUsersV2Cond.IdentityId, strComparisonOpIdentityId);
}
if (objQxUsersV2Cond.IsUpdated(conQxUsersV2.StuTeacherId) == true)
{
string strComparisonOpStuTeacherId = objQxUsersV2Cond.dicFldComparisonOp[conQxUsersV2.StuTeacherId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsersV2.StuTeacherId, objQxUsersV2Cond.StuTeacherId, strComparisonOpStuTeacherId);
}
if (objQxUsersV2Cond.IsUpdated(conQxUsersV2.EffitiveBeginDate) == true)
{
string strComparisonOpEffitiveBeginDate = objQxUsersV2Cond.dicFldComparisonOp[conQxUsersV2.EffitiveBeginDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsersV2.EffitiveBeginDate, objQxUsersV2Cond.EffitiveBeginDate, strComparisonOpEffitiveBeginDate);
}
if (objQxUsersV2Cond.IsUpdated(conQxUsersV2.EffitiveEndDate) == true)
{
string strComparisonOpEffitiveEndDate = objQxUsersV2Cond.dicFldComparisonOp[conQxUsersV2.EffitiveEndDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsersV2.EffitiveEndDate, objQxUsersV2Cond.EffitiveEndDate, strComparisonOpEffitiveEndDate);
}
if (objQxUsersV2Cond.IsUpdated(conQxUsersV2.UserId) == true)
{
string strComparisonOpUserId = objQxUsersV2Cond.dicFldComparisonOp[conQxUsersV2.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsersV2.UserId, objQxUsersV2Cond.UserId, strComparisonOpUserId);
}
if (objQxUsersV2Cond.IsUpdated(conQxUsersV2.EffectiveDate) == true)
{
string strComparisonOpEffectiveDate = objQxUsersV2Cond.dicFldComparisonOp[conQxUsersV2.EffectiveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsersV2.EffectiveDate, objQxUsersV2Cond.EffectiveDate, strComparisonOpEffectiveDate);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--QxUsersV2(用户V2), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:name_phone
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objQxUsersV2EN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsQxUsersV2EN objQxUsersV2EN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objQxUsersV2EN == null) return true;
if (objQxUsersV2EN.id == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and name = '{0}'", objQxUsersV2EN.name);
 sbCondition.AppendFormat(" and phone = '{0}'", objQxUsersV2EN.phone);
if (clsQxUsersV2BL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("id !=  {0}", objQxUsersV2EN.id);
 sbCondition.AppendFormat(" and name = '{0}'", objQxUsersV2EN.name);
 sbCondition.AppendFormat(" and phone = '{0}'", objQxUsersV2EN.phone);
if (clsQxUsersV2BL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--QxUsersV2(用户V2), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:name_phone
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objQxUsersV2EN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsQxUsersV2EN objQxUsersV2EN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objQxUsersV2EN == null) return "";
if (objQxUsersV2EN.id == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and name = '{0}'", objQxUsersV2EN.name);
 sbCondition.AppendFormat(" and phone = '{0}'", objQxUsersV2EN.phone);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("id !=  {0}", objQxUsersV2EN.id);
 sbCondition.AppendFormat(" and name = '{0}'", objQxUsersV2EN.name);
 sbCondition.AppendFormat(" and phone = '{0}'", objQxUsersV2EN.phone);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_QxUsersV2
{
public virtual bool UpdRelaTabDate(int intid, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 用户V2(QxUsersV2)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsQxUsersV2BL
{
public static RelatedActions_QxUsersV2 relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "QxUsersV2ListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "QxUsersV2List";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsQxUsersV2EN> arrQxUsersV2ObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsQxUsersV2DA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsQxUsersV2DA QxUsersV2DA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsQxUsersV2DA();
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
 public clsQxUsersV2BL()
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
if (string.IsNullOrEmpty(clsQxUsersV2EN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxUsersV2EN._ConnectString);
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
objDS = QxUsersV2DA.GetDataSet(strWhereCond);
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
objDS = QxUsersV2DA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = QxUsersV2DA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_QxUsersV2(string strWhereCond)
{
DataTable objDT;
try
{
objDT = QxUsersV2DA.GetDataTable_QxUsersV2(strWhereCond);
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
objDT = QxUsersV2DA.GetDataTable(strWhereCond);
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
objDT = QxUsersV2DA.GetDataTable(strWhereCond, lstExclude);
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
objDT = QxUsersV2DA.GetDataTable(strWhereCond, strTabName);
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
objDT = QxUsersV2DA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = QxUsersV2DA.GetDataTable_Top(objTopPara);
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
objDT = QxUsersV2DA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = QxUsersV2DA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = QxUsersV2DA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = QxUsersV2DA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = QxUsersV2DA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = QxUsersV2DA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = QxUsersV2DA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = QxUsersV2DA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
public static List<clsQxUsersV2EN> GetObjLstByIdLst(List<int> arrIdLst)
{
List<clsQxUsersV2EN> arrObjLst = new List<clsQxUsersV2EN>(); 
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
	clsQxUsersV2EN objQxUsersV2EN = new clsQxUsersV2EN();
try
{
objQxUsersV2EN.CreateTime = objRow[conQxUsersV2.CreateTime] == DBNull.Value ? null : objRow[conQxUsersV2.CreateTime].ToString().Trim(); //建立时间
objQxUsersV2EN.updateTime = objRow[conQxUsersV2.updateTime] == DBNull.Value ? null : objRow[conQxUsersV2.updateTime].ToString().Trim(); //修改时间
objQxUsersV2EN.id = Int32.Parse(objRow[conQxUsersV2.id].ToString().Trim()); //id
objQxUsersV2EN.DepartmentIdInt = objRow[conQxUsersV2.DepartmentIdInt] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxUsersV2.DepartmentIdInt].ToString().Trim()); //部门Id
objQxUsersV2EN.name = objRow[conQxUsersV2.name].ToString().Trim(); //姓名
objQxUsersV2EN.UserName = objRow[conQxUsersV2.UserName].ToString().Trim(); //用户名
objQxUsersV2EN.Password = objRow[conQxUsersV2.Password].ToString().Trim(); //口令
objQxUsersV2EN.psalt = objRow[conQxUsersV2.psalt] == DBNull.Value ? null : objRow[conQxUsersV2.psalt].ToString().Trim(); //密码盐值
objQxUsersV2EN.nickName = objRow[conQxUsersV2.nickName] == DBNull.Value ? null : objRow[conQxUsersV2.nickName].ToString().Trim(); //呢称
objQxUsersV2EN.headImg = objRow[conQxUsersV2.headImg] == DBNull.Value ? null : objRow[conQxUsersV2.headImg].ToString().Trim(); //头像
objQxUsersV2EN.Email = objRow[conQxUsersV2.Email] == DBNull.Value ? null : objRow[conQxUsersV2.Email].ToString().Trim(); //邮箱
objQxUsersV2EN.phone = objRow[conQxUsersV2.phone].ToString().Trim(); //电话号码
objQxUsersV2EN.remark = objRow[conQxUsersV2.remark] == DBNull.Value ? null : objRow[conQxUsersV2.remark].ToString().Trim(); //备注
objQxUsersV2EN.status = Int32.Parse(objRow[conQxUsersV2.status].ToString().Trim()); //用户状态Id
objQxUsersV2EN.OpenId = objRow[conQxUsersV2.OpenId] == DBNull.Value ? null : objRow[conQxUsersV2.OpenId].ToString().Trim(); //微信openid
objQxUsersV2EN.UpdUser = objRow[conQxUsersV2.UpdUser] == DBNull.Value ? null : objRow[conQxUsersV2.UpdUser].ToString().Trim(); //修改用户
objQxUsersV2EN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conQxUsersV2.IsArchive].ToString().Trim()); //是否存档
objQxUsersV2EN.IdentityId = objRow[conQxUsersV2.IdentityId] == DBNull.Value ? null : objRow[conQxUsersV2.IdentityId].ToString().Trim(); //身份编号
objQxUsersV2EN.StuTeacherId = objRow[conQxUsersV2.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsersV2.StuTeacherId].ToString().Trim(); //学工号
objQxUsersV2EN.EffitiveBeginDate = objRow[conQxUsersV2.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objQxUsersV2EN.EffitiveEndDate = objRow[conQxUsersV2.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffitiveEndDate].ToString().Trim(); //有效结束日期
objQxUsersV2EN.UserId = objRow[conQxUsersV2.UserId].ToString().Trim(); //用户ID
objQxUsersV2EN.EffectiveDate = objRow[conQxUsersV2.EffectiveDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffectiveDate].ToString().Trim(); //有效日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUsersV2EN.id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUsersV2EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsQxUsersV2EN> GetObjLstByIdLstCache(List<int> arrIdLst)
{
string strKey = string.Format("{0}", clsQxUsersV2EN._CurrTabName);
List<clsQxUsersV2EN> arrQxUsersV2ObjLstCache = GetObjLstCache();
IEnumerable <clsQxUsersV2EN> arrQxUsersV2ObjLst_Sel =
arrQxUsersV2ObjLstCache
.Where(x => arrIdLst.Contains(x.id));
return arrQxUsersV2ObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUsersV2EN> GetObjLst(string strWhereCond)
{
List<clsQxUsersV2EN> arrObjLst = new List<clsQxUsersV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsersV2EN objQxUsersV2EN = new clsQxUsersV2EN();
try
{
objQxUsersV2EN.CreateTime = objRow[conQxUsersV2.CreateTime] == DBNull.Value ? null : objRow[conQxUsersV2.CreateTime].ToString().Trim(); //建立时间
objQxUsersV2EN.updateTime = objRow[conQxUsersV2.updateTime] == DBNull.Value ? null : objRow[conQxUsersV2.updateTime].ToString().Trim(); //修改时间
objQxUsersV2EN.id = Int32.Parse(objRow[conQxUsersV2.id].ToString().Trim()); //id
objQxUsersV2EN.DepartmentIdInt = objRow[conQxUsersV2.DepartmentIdInt] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxUsersV2.DepartmentIdInt].ToString().Trim()); //部门Id
objQxUsersV2EN.name = objRow[conQxUsersV2.name].ToString().Trim(); //姓名
objQxUsersV2EN.UserName = objRow[conQxUsersV2.UserName].ToString().Trim(); //用户名
objQxUsersV2EN.Password = objRow[conQxUsersV2.Password].ToString().Trim(); //口令
objQxUsersV2EN.psalt = objRow[conQxUsersV2.psalt] == DBNull.Value ? null : objRow[conQxUsersV2.psalt].ToString().Trim(); //密码盐值
objQxUsersV2EN.nickName = objRow[conQxUsersV2.nickName] == DBNull.Value ? null : objRow[conQxUsersV2.nickName].ToString().Trim(); //呢称
objQxUsersV2EN.headImg = objRow[conQxUsersV2.headImg] == DBNull.Value ? null : objRow[conQxUsersV2.headImg].ToString().Trim(); //头像
objQxUsersV2EN.Email = objRow[conQxUsersV2.Email] == DBNull.Value ? null : objRow[conQxUsersV2.Email].ToString().Trim(); //邮箱
objQxUsersV2EN.phone = objRow[conQxUsersV2.phone].ToString().Trim(); //电话号码
objQxUsersV2EN.remark = objRow[conQxUsersV2.remark] == DBNull.Value ? null : objRow[conQxUsersV2.remark].ToString().Trim(); //备注
objQxUsersV2EN.status = Int32.Parse(objRow[conQxUsersV2.status].ToString().Trim()); //用户状态Id
objQxUsersV2EN.OpenId = objRow[conQxUsersV2.OpenId] == DBNull.Value ? null : objRow[conQxUsersV2.OpenId].ToString().Trim(); //微信openid
objQxUsersV2EN.UpdUser = objRow[conQxUsersV2.UpdUser] == DBNull.Value ? null : objRow[conQxUsersV2.UpdUser].ToString().Trim(); //修改用户
objQxUsersV2EN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conQxUsersV2.IsArchive].ToString().Trim()); //是否存档
objQxUsersV2EN.IdentityId = objRow[conQxUsersV2.IdentityId] == DBNull.Value ? null : objRow[conQxUsersV2.IdentityId].ToString().Trim(); //身份编号
objQxUsersV2EN.StuTeacherId = objRow[conQxUsersV2.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsersV2.StuTeacherId].ToString().Trim(); //学工号
objQxUsersV2EN.EffitiveBeginDate = objRow[conQxUsersV2.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objQxUsersV2EN.EffitiveEndDate = objRow[conQxUsersV2.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffitiveEndDate].ToString().Trim(); //有效结束日期
objQxUsersV2EN.UserId = objRow[conQxUsersV2.UserId].ToString().Trim(); //用户ID
objQxUsersV2EN.EffectiveDate = objRow[conQxUsersV2.EffectiveDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffectiveDate].ToString().Trim(); //有效日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUsersV2EN.id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUsersV2EN);
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
public static List<clsQxUsersV2EN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsQxUsersV2EN> arrObjLst = new List<clsQxUsersV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsersV2EN objQxUsersV2EN = new clsQxUsersV2EN();
try
{
objQxUsersV2EN.CreateTime = objRow[conQxUsersV2.CreateTime] == DBNull.Value ? null : objRow[conQxUsersV2.CreateTime].ToString().Trim(); //建立时间
objQxUsersV2EN.updateTime = objRow[conQxUsersV2.updateTime] == DBNull.Value ? null : objRow[conQxUsersV2.updateTime].ToString().Trim(); //修改时间
objQxUsersV2EN.id = Int32.Parse(objRow[conQxUsersV2.id].ToString().Trim()); //id
objQxUsersV2EN.DepartmentIdInt = objRow[conQxUsersV2.DepartmentIdInt] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxUsersV2.DepartmentIdInt].ToString().Trim()); //部门Id
objQxUsersV2EN.name = objRow[conQxUsersV2.name].ToString().Trim(); //姓名
objQxUsersV2EN.UserName = objRow[conQxUsersV2.UserName].ToString().Trim(); //用户名
objQxUsersV2EN.Password = objRow[conQxUsersV2.Password].ToString().Trim(); //口令
objQxUsersV2EN.psalt = objRow[conQxUsersV2.psalt] == DBNull.Value ? null : objRow[conQxUsersV2.psalt].ToString().Trim(); //密码盐值
objQxUsersV2EN.nickName = objRow[conQxUsersV2.nickName] == DBNull.Value ? null : objRow[conQxUsersV2.nickName].ToString().Trim(); //呢称
objQxUsersV2EN.headImg = objRow[conQxUsersV2.headImg] == DBNull.Value ? null : objRow[conQxUsersV2.headImg].ToString().Trim(); //头像
objQxUsersV2EN.Email = objRow[conQxUsersV2.Email] == DBNull.Value ? null : objRow[conQxUsersV2.Email].ToString().Trim(); //邮箱
objQxUsersV2EN.phone = objRow[conQxUsersV2.phone].ToString().Trim(); //电话号码
objQxUsersV2EN.remark = objRow[conQxUsersV2.remark] == DBNull.Value ? null : objRow[conQxUsersV2.remark].ToString().Trim(); //备注
objQxUsersV2EN.status = Int32.Parse(objRow[conQxUsersV2.status].ToString().Trim()); //用户状态Id
objQxUsersV2EN.OpenId = objRow[conQxUsersV2.OpenId] == DBNull.Value ? null : objRow[conQxUsersV2.OpenId].ToString().Trim(); //微信openid
objQxUsersV2EN.UpdUser = objRow[conQxUsersV2.UpdUser] == DBNull.Value ? null : objRow[conQxUsersV2.UpdUser].ToString().Trim(); //修改用户
objQxUsersV2EN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conQxUsersV2.IsArchive].ToString().Trim()); //是否存档
objQxUsersV2EN.IdentityId = objRow[conQxUsersV2.IdentityId] == DBNull.Value ? null : objRow[conQxUsersV2.IdentityId].ToString().Trim(); //身份编号
objQxUsersV2EN.StuTeacherId = objRow[conQxUsersV2.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsersV2.StuTeacherId].ToString().Trim(); //学工号
objQxUsersV2EN.EffitiveBeginDate = objRow[conQxUsersV2.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objQxUsersV2EN.EffitiveEndDate = objRow[conQxUsersV2.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffitiveEndDate].ToString().Trim(); //有效结束日期
objQxUsersV2EN.UserId = objRow[conQxUsersV2.UserId].ToString().Trim(); //用户ID
objQxUsersV2EN.EffectiveDate = objRow[conQxUsersV2.EffectiveDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffectiveDate].ToString().Trim(); //有效日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUsersV2EN.id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUsersV2EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objQxUsersV2Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsQxUsersV2EN> GetSubObjLstCache(clsQxUsersV2EN objQxUsersV2Cond)
{
List<clsQxUsersV2EN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxUsersV2EN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxUsersV2.AttributeName)
{
if (objQxUsersV2Cond.IsUpdated(strFldName) == false) continue;
if (objQxUsersV2Cond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUsersV2Cond[strFldName].ToString());
}
else
{
if (objQxUsersV2Cond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxUsersV2Cond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUsersV2Cond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxUsersV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxUsersV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxUsersV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxUsersV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxUsersV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxUsersV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxUsersV2Cond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxUsersV2Cond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxUsersV2Cond[strFldName]));
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
public static List<clsQxUsersV2EN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsQxUsersV2EN> arrObjLst = new List<clsQxUsersV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsersV2EN objQxUsersV2EN = new clsQxUsersV2EN();
try
{
objQxUsersV2EN.CreateTime = objRow[conQxUsersV2.CreateTime] == DBNull.Value ? null : objRow[conQxUsersV2.CreateTime].ToString().Trim(); //建立时间
objQxUsersV2EN.updateTime = objRow[conQxUsersV2.updateTime] == DBNull.Value ? null : objRow[conQxUsersV2.updateTime].ToString().Trim(); //修改时间
objQxUsersV2EN.id = Int32.Parse(objRow[conQxUsersV2.id].ToString().Trim()); //id
objQxUsersV2EN.DepartmentIdInt = objRow[conQxUsersV2.DepartmentIdInt] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxUsersV2.DepartmentIdInt].ToString().Trim()); //部门Id
objQxUsersV2EN.name = objRow[conQxUsersV2.name].ToString().Trim(); //姓名
objQxUsersV2EN.UserName = objRow[conQxUsersV2.UserName].ToString().Trim(); //用户名
objQxUsersV2EN.Password = objRow[conQxUsersV2.Password].ToString().Trim(); //口令
objQxUsersV2EN.psalt = objRow[conQxUsersV2.psalt] == DBNull.Value ? null : objRow[conQxUsersV2.psalt].ToString().Trim(); //密码盐值
objQxUsersV2EN.nickName = objRow[conQxUsersV2.nickName] == DBNull.Value ? null : objRow[conQxUsersV2.nickName].ToString().Trim(); //呢称
objQxUsersV2EN.headImg = objRow[conQxUsersV2.headImg] == DBNull.Value ? null : objRow[conQxUsersV2.headImg].ToString().Trim(); //头像
objQxUsersV2EN.Email = objRow[conQxUsersV2.Email] == DBNull.Value ? null : objRow[conQxUsersV2.Email].ToString().Trim(); //邮箱
objQxUsersV2EN.phone = objRow[conQxUsersV2.phone].ToString().Trim(); //电话号码
objQxUsersV2EN.remark = objRow[conQxUsersV2.remark] == DBNull.Value ? null : objRow[conQxUsersV2.remark].ToString().Trim(); //备注
objQxUsersV2EN.status = Int32.Parse(objRow[conQxUsersV2.status].ToString().Trim()); //用户状态Id
objQxUsersV2EN.OpenId = objRow[conQxUsersV2.OpenId] == DBNull.Value ? null : objRow[conQxUsersV2.OpenId].ToString().Trim(); //微信openid
objQxUsersV2EN.UpdUser = objRow[conQxUsersV2.UpdUser] == DBNull.Value ? null : objRow[conQxUsersV2.UpdUser].ToString().Trim(); //修改用户
objQxUsersV2EN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conQxUsersV2.IsArchive].ToString().Trim()); //是否存档
objQxUsersV2EN.IdentityId = objRow[conQxUsersV2.IdentityId] == DBNull.Value ? null : objRow[conQxUsersV2.IdentityId].ToString().Trim(); //身份编号
objQxUsersV2EN.StuTeacherId = objRow[conQxUsersV2.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsersV2.StuTeacherId].ToString().Trim(); //学工号
objQxUsersV2EN.EffitiveBeginDate = objRow[conQxUsersV2.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objQxUsersV2EN.EffitiveEndDate = objRow[conQxUsersV2.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffitiveEndDate].ToString().Trim(); //有效结束日期
objQxUsersV2EN.UserId = objRow[conQxUsersV2.UserId].ToString().Trim(); //用户ID
objQxUsersV2EN.EffectiveDate = objRow[conQxUsersV2.EffectiveDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffectiveDate].ToString().Trim(); //有效日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUsersV2EN.id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUsersV2EN);
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
public static List<clsQxUsersV2EN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsQxUsersV2EN> arrObjLst = new List<clsQxUsersV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsersV2EN objQxUsersV2EN = new clsQxUsersV2EN();
try
{
objQxUsersV2EN.CreateTime = objRow[conQxUsersV2.CreateTime] == DBNull.Value ? null : objRow[conQxUsersV2.CreateTime].ToString().Trim(); //建立时间
objQxUsersV2EN.updateTime = objRow[conQxUsersV2.updateTime] == DBNull.Value ? null : objRow[conQxUsersV2.updateTime].ToString().Trim(); //修改时间
objQxUsersV2EN.id = Int32.Parse(objRow[conQxUsersV2.id].ToString().Trim()); //id
objQxUsersV2EN.DepartmentIdInt = objRow[conQxUsersV2.DepartmentIdInt] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxUsersV2.DepartmentIdInt].ToString().Trim()); //部门Id
objQxUsersV2EN.name = objRow[conQxUsersV2.name].ToString().Trim(); //姓名
objQxUsersV2EN.UserName = objRow[conQxUsersV2.UserName].ToString().Trim(); //用户名
objQxUsersV2EN.Password = objRow[conQxUsersV2.Password].ToString().Trim(); //口令
objQxUsersV2EN.psalt = objRow[conQxUsersV2.psalt] == DBNull.Value ? null : objRow[conQxUsersV2.psalt].ToString().Trim(); //密码盐值
objQxUsersV2EN.nickName = objRow[conQxUsersV2.nickName] == DBNull.Value ? null : objRow[conQxUsersV2.nickName].ToString().Trim(); //呢称
objQxUsersV2EN.headImg = objRow[conQxUsersV2.headImg] == DBNull.Value ? null : objRow[conQxUsersV2.headImg].ToString().Trim(); //头像
objQxUsersV2EN.Email = objRow[conQxUsersV2.Email] == DBNull.Value ? null : objRow[conQxUsersV2.Email].ToString().Trim(); //邮箱
objQxUsersV2EN.phone = objRow[conQxUsersV2.phone].ToString().Trim(); //电话号码
objQxUsersV2EN.remark = objRow[conQxUsersV2.remark] == DBNull.Value ? null : objRow[conQxUsersV2.remark].ToString().Trim(); //备注
objQxUsersV2EN.status = Int32.Parse(objRow[conQxUsersV2.status].ToString().Trim()); //用户状态Id
objQxUsersV2EN.OpenId = objRow[conQxUsersV2.OpenId] == DBNull.Value ? null : objRow[conQxUsersV2.OpenId].ToString().Trim(); //微信openid
objQxUsersV2EN.UpdUser = objRow[conQxUsersV2.UpdUser] == DBNull.Value ? null : objRow[conQxUsersV2.UpdUser].ToString().Trim(); //修改用户
objQxUsersV2EN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conQxUsersV2.IsArchive].ToString().Trim()); //是否存档
objQxUsersV2EN.IdentityId = objRow[conQxUsersV2.IdentityId] == DBNull.Value ? null : objRow[conQxUsersV2.IdentityId].ToString().Trim(); //身份编号
objQxUsersV2EN.StuTeacherId = objRow[conQxUsersV2.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsersV2.StuTeacherId].ToString().Trim(); //学工号
objQxUsersV2EN.EffitiveBeginDate = objRow[conQxUsersV2.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objQxUsersV2EN.EffitiveEndDate = objRow[conQxUsersV2.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffitiveEndDate].ToString().Trim(); //有效结束日期
objQxUsersV2EN.UserId = objRow[conQxUsersV2.UserId].ToString().Trim(); //用户ID
objQxUsersV2EN.EffectiveDate = objRow[conQxUsersV2.EffectiveDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffectiveDate].ToString().Trim(); //有效日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUsersV2EN.id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUsersV2EN);
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
List<clsQxUsersV2EN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsQxUsersV2EN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUsersV2EN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsQxUsersV2EN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsQxUsersV2EN> arrObjLst = new List<clsQxUsersV2EN>(); 
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
	clsQxUsersV2EN objQxUsersV2EN = new clsQxUsersV2EN();
try
{
objQxUsersV2EN.CreateTime = objRow[conQxUsersV2.CreateTime] == DBNull.Value ? null : objRow[conQxUsersV2.CreateTime].ToString().Trim(); //建立时间
objQxUsersV2EN.updateTime = objRow[conQxUsersV2.updateTime] == DBNull.Value ? null : objRow[conQxUsersV2.updateTime].ToString().Trim(); //修改时间
objQxUsersV2EN.id = Int32.Parse(objRow[conQxUsersV2.id].ToString().Trim()); //id
objQxUsersV2EN.DepartmentIdInt = objRow[conQxUsersV2.DepartmentIdInt] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxUsersV2.DepartmentIdInt].ToString().Trim()); //部门Id
objQxUsersV2EN.name = objRow[conQxUsersV2.name].ToString().Trim(); //姓名
objQxUsersV2EN.UserName = objRow[conQxUsersV2.UserName].ToString().Trim(); //用户名
objQxUsersV2EN.Password = objRow[conQxUsersV2.Password].ToString().Trim(); //口令
objQxUsersV2EN.psalt = objRow[conQxUsersV2.psalt] == DBNull.Value ? null : objRow[conQxUsersV2.psalt].ToString().Trim(); //密码盐值
objQxUsersV2EN.nickName = objRow[conQxUsersV2.nickName] == DBNull.Value ? null : objRow[conQxUsersV2.nickName].ToString().Trim(); //呢称
objQxUsersV2EN.headImg = objRow[conQxUsersV2.headImg] == DBNull.Value ? null : objRow[conQxUsersV2.headImg].ToString().Trim(); //头像
objQxUsersV2EN.Email = objRow[conQxUsersV2.Email] == DBNull.Value ? null : objRow[conQxUsersV2.Email].ToString().Trim(); //邮箱
objQxUsersV2EN.phone = objRow[conQxUsersV2.phone].ToString().Trim(); //电话号码
objQxUsersV2EN.remark = objRow[conQxUsersV2.remark] == DBNull.Value ? null : objRow[conQxUsersV2.remark].ToString().Trim(); //备注
objQxUsersV2EN.status = Int32.Parse(objRow[conQxUsersV2.status].ToString().Trim()); //用户状态Id
objQxUsersV2EN.OpenId = objRow[conQxUsersV2.OpenId] == DBNull.Value ? null : objRow[conQxUsersV2.OpenId].ToString().Trim(); //微信openid
objQxUsersV2EN.UpdUser = objRow[conQxUsersV2.UpdUser] == DBNull.Value ? null : objRow[conQxUsersV2.UpdUser].ToString().Trim(); //修改用户
objQxUsersV2EN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conQxUsersV2.IsArchive].ToString().Trim()); //是否存档
objQxUsersV2EN.IdentityId = objRow[conQxUsersV2.IdentityId] == DBNull.Value ? null : objRow[conQxUsersV2.IdentityId].ToString().Trim(); //身份编号
objQxUsersV2EN.StuTeacherId = objRow[conQxUsersV2.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsersV2.StuTeacherId].ToString().Trim(); //学工号
objQxUsersV2EN.EffitiveBeginDate = objRow[conQxUsersV2.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objQxUsersV2EN.EffitiveEndDate = objRow[conQxUsersV2.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffitiveEndDate].ToString().Trim(); //有效结束日期
objQxUsersV2EN.UserId = objRow[conQxUsersV2.UserId].ToString().Trim(); //用户ID
objQxUsersV2EN.EffectiveDate = objRow[conQxUsersV2.EffectiveDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffectiveDate].ToString().Trim(); //有效日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUsersV2EN.id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUsersV2EN);
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
public static List<clsQxUsersV2EN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsQxUsersV2EN> arrObjLst = new List<clsQxUsersV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsersV2EN objQxUsersV2EN = new clsQxUsersV2EN();
try
{
objQxUsersV2EN.CreateTime = objRow[conQxUsersV2.CreateTime] == DBNull.Value ? null : objRow[conQxUsersV2.CreateTime].ToString().Trim(); //建立时间
objQxUsersV2EN.updateTime = objRow[conQxUsersV2.updateTime] == DBNull.Value ? null : objRow[conQxUsersV2.updateTime].ToString().Trim(); //修改时间
objQxUsersV2EN.id = Int32.Parse(objRow[conQxUsersV2.id].ToString().Trim()); //id
objQxUsersV2EN.DepartmentIdInt = objRow[conQxUsersV2.DepartmentIdInt] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxUsersV2.DepartmentIdInt].ToString().Trim()); //部门Id
objQxUsersV2EN.name = objRow[conQxUsersV2.name].ToString().Trim(); //姓名
objQxUsersV2EN.UserName = objRow[conQxUsersV2.UserName].ToString().Trim(); //用户名
objQxUsersV2EN.Password = objRow[conQxUsersV2.Password].ToString().Trim(); //口令
objQxUsersV2EN.psalt = objRow[conQxUsersV2.psalt] == DBNull.Value ? null : objRow[conQxUsersV2.psalt].ToString().Trim(); //密码盐值
objQxUsersV2EN.nickName = objRow[conQxUsersV2.nickName] == DBNull.Value ? null : objRow[conQxUsersV2.nickName].ToString().Trim(); //呢称
objQxUsersV2EN.headImg = objRow[conQxUsersV2.headImg] == DBNull.Value ? null : objRow[conQxUsersV2.headImg].ToString().Trim(); //头像
objQxUsersV2EN.Email = objRow[conQxUsersV2.Email] == DBNull.Value ? null : objRow[conQxUsersV2.Email].ToString().Trim(); //邮箱
objQxUsersV2EN.phone = objRow[conQxUsersV2.phone].ToString().Trim(); //电话号码
objQxUsersV2EN.remark = objRow[conQxUsersV2.remark] == DBNull.Value ? null : objRow[conQxUsersV2.remark].ToString().Trim(); //备注
objQxUsersV2EN.status = Int32.Parse(objRow[conQxUsersV2.status].ToString().Trim()); //用户状态Id
objQxUsersV2EN.OpenId = objRow[conQxUsersV2.OpenId] == DBNull.Value ? null : objRow[conQxUsersV2.OpenId].ToString().Trim(); //微信openid
objQxUsersV2EN.UpdUser = objRow[conQxUsersV2.UpdUser] == DBNull.Value ? null : objRow[conQxUsersV2.UpdUser].ToString().Trim(); //修改用户
objQxUsersV2EN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conQxUsersV2.IsArchive].ToString().Trim()); //是否存档
objQxUsersV2EN.IdentityId = objRow[conQxUsersV2.IdentityId] == DBNull.Value ? null : objRow[conQxUsersV2.IdentityId].ToString().Trim(); //身份编号
objQxUsersV2EN.StuTeacherId = objRow[conQxUsersV2.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsersV2.StuTeacherId].ToString().Trim(); //学工号
objQxUsersV2EN.EffitiveBeginDate = objRow[conQxUsersV2.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objQxUsersV2EN.EffitiveEndDate = objRow[conQxUsersV2.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffitiveEndDate].ToString().Trim(); //有效结束日期
objQxUsersV2EN.UserId = objRow[conQxUsersV2.UserId].ToString().Trim(); //用户ID
objQxUsersV2EN.EffectiveDate = objRow[conQxUsersV2.EffectiveDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffectiveDate].ToString().Trim(); //有效日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUsersV2EN.id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUsersV2EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsQxUsersV2EN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsQxUsersV2EN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsQxUsersV2EN> arrObjLst = new List<clsQxUsersV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsersV2EN objQxUsersV2EN = new clsQxUsersV2EN();
try
{
objQxUsersV2EN.CreateTime = objRow[conQxUsersV2.CreateTime] == DBNull.Value ? null : objRow[conQxUsersV2.CreateTime].ToString().Trim(); //建立时间
objQxUsersV2EN.updateTime = objRow[conQxUsersV2.updateTime] == DBNull.Value ? null : objRow[conQxUsersV2.updateTime].ToString().Trim(); //修改时间
objQxUsersV2EN.id = Int32.Parse(objRow[conQxUsersV2.id].ToString().Trim()); //id
objQxUsersV2EN.DepartmentIdInt = objRow[conQxUsersV2.DepartmentIdInt] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxUsersV2.DepartmentIdInt].ToString().Trim()); //部门Id
objQxUsersV2EN.name = objRow[conQxUsersV2.name].ToString().Trim(); //姓名
objQxUsersV2EN.UserName = objRow[conQxUsersV2.UserName].ToString().Trim(); //用户名
objQxUsersV2EN.Password = objRow[conQxUsersV2.Password].ToString().Trim(); //口令
objQxUsersV2EN.psalt = objRow[conQxUsersV2.psalt] == DBNull.Value ? null : objRow[conQxUsersV2.psalt].ToString().Trim(); //密码盐值
objQxUsersV2EN.nickName = objRow[conQxUsersV2.nickName] == DBNull.Value ? null : objRow[conQxUsersV2.nickName].ToString().Trim(); //呢称
objQxUsersV2EN.headImg = objRow[conQxUsersV2.headImg] == DBNull.Value ? null : objRow[conQxUsersV2.headImg].ToString().Trim(); //头像
objQxUsersV2EN.Email = objRow[conQxUsersV2.Email] == DBNull.Value ? null : objRow[conQxUsersV2.Email].ToString().Trim(); //邮箱
objQxUsersV2EN.phone = objRow[conQxUsersV2.phone].ToString().Trim(); //电话号码
objQxUsersV2EN.remark = objRow[conQxUsersV2.remark] == DBNull.Value ? null : objRow[conQxUsersV2.remark].ToString().Trim(); //备注
objQxUsersV2EN.status = Int32.Parse(objRow[conQxUsersV2.status].ToString().Trim()); //用户状态Id
objQxUsersV2EN.OpenId = objRow[conQxUsersV2.OpenId] == DBNull.Value ? null : objRow[conQxUsersV2.OpenId].ToString().Trim(); //微信openid
objQxUsersV2EN.UpdUser = objRow[conQxUsersV2.UpdUser] == DBNull.Value ? null : objRow[conQxUsersV2.UpdUser].ToString().Trim(); //修改用户
objQxUsersV2EN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conQxUsersV2.IsArchive].ToString().Trim()); //是否存档
objQxUsersV2EN.IdentityId = objRow[conQxUsersV2.IdentityId] == DBNull.Value ? null : objRow[conQxUsersV2.IdentityId].ToString().Trim(); //身份编号
objQxUsersV2EN.StuTeacherId = objRow[conQxUsersV2.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsersV2.StuTeacherId].ToString().Trim(); //学工号
objQxUsersV2EN.EffitiveBeginDate = objRow[conQxUsersV2.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objQxUsersV2EN.EffitiveEndDate = objRow[conQxUsersV2.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffitiveEndDate].ToString().Trim(); //有效结束日期
objQxUsersV2EN.UserId = objRow[conQxUsersV2.UserId].ToString().Trim(); //用户ID
objQxUsersV2EN.EffectiveDate = objRow[conQxUsersV2.EffectiveDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffectiveDate].ToString().Trim(); //有效日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUsersV2EN.id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUsersV2EN);
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
public static List<clsQxUsersV2EN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsQxUsersV2EN> arrObjLst = new List<clsQxUsersV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsersV2EN objQxUsersV2EN = new clsQxUsersV2EN();
try
{
objQxUsersV2EN.CreateTime = objRow[conQxUsersV2.CreateTime] == DBNull.Value ? null : objRow[conQxUsersV2.CreateTime].ToString().Trim(); //建立时间
objQxUsersV2EN.updateTime = objRow[conQxUsersV2.updateTime] == DBNull.Value ? null : objRow[conQxUsersV2.updateTime].ToString().Trim(); //修改时间
objQxUsersV2EN.id = Int32.Parse(objRow[conQxUsersV2.id].ToString().Trim()); //id
objQxUsersV2EN.DepartmentIdInt = objRow[conQxUsersV2.DepartmentIdInt] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxUsersV2.DepartmentIdInt].ToString().Trim()); //部门Id
objQxUsersV2EN.name = objRow[conQxUsersV2.name].ToString().Trim(); //姓名
objQxUsersV2EN.UserName = objRow[conQxUsersV2.UserName].ToString().Trim(); //用户名
objQxUsersV2EN.Password = objRow[conQxUsersV2.Password].ToString().Trim(); //口令
objQxUsersV2EN.psalt = objRow[conQxUsersV2.psalt] == DBNull.Value ? null : objRow[conQxUsersV2.psalt].ToString().Trim(); //密码盐值
objQxUsersV2EN.nickName = objRow[conQxUsersV2.nickName] == DBNull.Value ? null : objRow[conQxUsersV2.nickName].ToString().Trim(); //呢称
objQxUsersV2EN.headImg = objRow[conQxUsersV2.headImg] == DBNull.Value ? null : objRow[conQxUsersV2.headImg].ToString().Trim(); //头像
objQxUsersV2EN.Email = objRow[conQxUsersV2.Email] == DBNull.Value ? null : objRow[conQxUsersV2.Email].ToString().Trim(); //邮箱
objQxUsersV2EN.phone = objRow[conQxUsersV2.phone].ToString().Trim(); //电话号码
objQxUsersV2EN.remark = objRow[conQxUsersV2.remark] == DBNull.Value ? null : objRow[conQxUsersV2.remark].ToString().Trim(); //备注
objQxUsersV2EN.status = Int32.Parse(objRow[conQxUsersV2.status].ToString().Trim()); //用户状态Id
objQxUsersV2EN.OpenId = objRow[conQxUsersV2.OpenId] == DBNull.Value ? null : objRow[conQxUsersV2.OpenId].ToString().Trim(); //微信openid
objQxUsersV2EN.UpdUser = objRow[conQxUsersV2.UpdUser] == DBNull.Value ? null : objRow[conQxUsersV2.UpdUser].ToString().Trim(); //修改用户
objQxUsersV2EN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conQxUsersV2.IsArchive].ToString().Trim()); //是否存档
objQxUsersV2EN.IdentityId = objRow[conQxUsersV2.IdentityId] == DBNull.Value ? null : objRow[conQxUsersV2.IdentityId].ToString().Trim(); //身份编号
objQxUsersV2EN.StuTeacherId = objRow[conQxUsersV2.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsersV2.StuTeacherId].ToString().Trim(); //学工号
objQxUsersV2EN.EffitiveBeginDate = objRow[conQxUsersV2.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objQxUsersV2EN.EffitiveEndDate = objRow[conQxUsersV2.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffitiveEndDate].ToString().Trim(); //有效结束日期
objQxUsersV2EN.UserId = objRow[conQxUsersV2.UserId].ToString().Trim(); //用户ID
objQxUsersV2EN.EffectiveDate = objRow[conQxUsersV2.EffectiveDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffectiveDate].ToString().Trim(); //有效日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUsersV2EN.id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUsersV2EN);
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
public static IEnumerable<clsQxUsersV2EN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsQxUsersV2EN objQxUsersV2Cond, string strOrderBy)
{
List<clsQxUsersV2EN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxUsersV2EN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxUsersV2.AttributeName)
{
if (objQxUsersV2Cond.IsUpdated(strFldName) == false) continue;
if (objQxUsersV2Cond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUsersV2Cond[strFldName].ToString());
}
else
{
if (objQxUsersV2Cond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxUsersV2Cond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUsersV2Cond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxUsersV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxUsersV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxUsersV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxUsersV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxUsersV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxUsersV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxUsersV2Cond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxUsersV2Cond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxUsersV2Cond[strFldName]));
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
public static IEnumerable<clsQxUsersV2EN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsQxUsersV2EN objQxUsersV2Cond = JsonConvert.DeserializeObject<clsQxUsersV2EN>(objPagerPara.whereCond);
if (objQxUsersV2Cond.sfFldComparisonOp == null)
{
objQxUsersV2Cond.dicFldComparisonOp = null;
}
else
{
objQxUsersV2Cond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objQxUsersV2Cond.sfFldComparisonOp);
}
clsQxUsersV2BL.SetUpdFlag(objQxUsersV2Cond);
 try
{
CheckProperty4Condition(objQxUsersV2Cond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsQxUsersV2BL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objQxUsersV2Cond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUsersV2EN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsQxUsersV2EN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsQxUsersV2EN> arrObjLst = new List<clsQxUsersV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsersV2EN objQxUsersV2EN = new clsQxUsersV2EN();
try
{
objQxUsersV2EN.CreateTime = objRow[conQxUsersV2.CreateTime] == DBNull.Value ? null : objRow[conQxUsersV2.CreateTime].ToString().Trim(); //建立时间
objQxUsersV2EN.updateTime = objRow[conQxUsersV2.updateTime] == DBNull.Value ? null : objRow[conQxUsersV2.updateTime].ToString().Trim(); //修改时间
objQxUsersV2EN.id = Int32.Parse(objRow[conQxUsersV2.id].ToString().Trim()); //id
objQxUsersV2EN.DepartmentIdInt = objRow[conQxUsersV2.DepartmentIdInt] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxUsersV2.DepartmentIdInt].ToString().Trim()); //部门Id
objQxUsersV2EN.name = objRow[conQxUsersV2.name].ToString().Trim(); //姓名
objQxUsersV2EN.UserName = objRow[conQxUsersV2.UserName].ToString().Trim(); //用户名
objQxUsersV2EN.Password = objRow[conQxUsersV2.Password].ToString().Trim(); //口令
objQxUsersV2EN.psalt = objRow[conQxUsersV2.psalt] == DBNull.Value ? null : objRow[conQxUsersV2.psalt].ToString().Trim(); //密码盐值
objQxUsersV2EN.nickName = objRow[conQxUsersV2.nickName] == DBNull.Value ? null : objRow[conQxUsersV2.nickName].ToString().Trim(); //呢称
objQxUsersV2EN.headImg = objRow[conQxUsersV2.headImg] == DBNull.Value ? null : objRow[conQxUsersV2.headImg].ToString().Trim(); //头像
objQxUsersV2EN.Email = objRow[conQxUsersV2.Email] == DBNull.Value ? null : objRow[conQxUsersV2.Email].ToString().Trim(); //邮箱
objQxUsersV2EN.phone = objRow[conQxUsersV2.phone].ToString().Trim(); //电话号码
objQxUsersV2EN.remark = objRow[conQxUsersV2.remark] == DBNull.Value ? null : objRow[conQxUsersV2.remark].ToString().Trim(); //备注
objQxUsersV2EN.status = Int32.Parse(objRow[conQxUsersV2.status].ToString().Trim()); //用户状态Id
objQxUsersV2EN.OpenId = objRow[conQxUsersV2.OpenId] == DBNull.Value ? null : objRow[conQxUsersV2.OpenId].ToString().Trim(); //微信openid
objQxUsersV2EN.UpdUser = objRow[conQxUsersV2.UpdUser] == DBNull.Value ? null : objRow[conQxUsersV2.UpdUser].ToString().Trim(); //修改用户
objQxUsersV2EN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conQxUsersV2.IsArchive].ToString().Trim()); //是否存档
objQxUsersV2EN.IdentityId = objRow[conQxUsersV2.IdentityId] == DBNull.Value ? null : objRow[conQxUsersV2.IdentityId].ToString().Trim(); //身份编号
objQxUsersV2EN.StuTeacherId = objRow[conQxUsersV2.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsersV2.StuTeacherId].ToString().Trim(); //学工号
objQxUsersV2EN.EffitiveBeginDate = objRow[conQxUsersV2.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objQxUsersV2EN.EffitiveEndDate = objRow[conQxUsersV2.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffitiveEndDate].ToString().Trim(); //有效结束日期
objQxUsersV2EN.UserId = objRow[conQxUsersV2.UserId].ToString().Trim(); //用户ID
objQxUsersV2EN.EffectiveDate = objRow[conQxUsersV2.EffectiveDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffectiveDate].ToString().Trim(); //有效日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUsersV2EN.id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUsersV2EN);
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
public static List<clsQxUsersV2EN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsQxUsersV2EN> arrObjLst = new List<clsQxUsersV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsersV2EN objQxUsersV2EN = new clsQxUsersV2EN();
try
{
objQxUsersV2EN.CreateTime = objRow[conQxUsersV2.CreateTime] == DBNull.Value ? null : objRow[conQxUsersV2.CreateTime].ToString().Trim(); //建立时间
objQxUsersV2EN.updateTime = objRow[conQxUsersV2.updateTime] == DBNull.Value ? null : objRow[conQxUsersV2.updateTime].ToString().Trim(); //修改时间
objQxUsersV2EN.id = Int32.Parse(objRow[conQxUsersV2.id].ToString().Trim()); //id
objQxUsersV2EN.DepartmentIdInt = objRow[conQxUsersV2.DepartmentIdInt] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxUsersV2.DepartmentIdInt].ToString().Trim()); //部门Id
objQxUsersV2EN.name = objRow[conQxUsersV2.name].ToString().Trim(); //姓名
objQxUsersV2EN.UserName = objRow[conQxUsersV2.UserName].ToString().Trim(); //用户名
objQxUsersV2EN.Password = objRow[conQxUsersV2.Password].ToString().Trim(); //口令
objQxUsersV2EN.psalt = objRow[conQxUsersV2.psalt] == DBNull.Value ? null : objRow[conQxUsersV2.psalt].ToString().Trim(); //密码盐值
objQxUsersV2EN.nickName = objRow[conQxUsersV2.nickName] == DBNull.Value ? null : objRow[conQxUsersV2.nickName].ToString().Trim(); //呢称
objQxUsersV2EN.headImg = objRow[conQxUsersV2.headImg] == DBNull.Value ? null : objRow[conQxUsersV2.headImg].ToString().Trim(); //头像
objQxUsersV2EN.Email = objRow[conQxUsersV2.Email] == DBNull.Value ? null : objRow[conQxUsersV2.Email].ToString().Trim(); //邮箱
objQxUsersV2EN.phone = objRow[conQxUsersV2.phone].ToString().Trim(); //电话号码
objQxUsersV2EN.remark = objRow[conQxUsersV2.remark] == DBNull.Value ? null : objRow[conQxUsersV2.remark].ToString().Trim(); //备注
objQxUsersV2EN.status = Int32.Parse(objRow[conQxUsersV2.status].ToString().Trim()); //用户状态Id
objQxUsersV2EN.OpenId = objRow[conQxUsersV2.OpenId] == DBNull.Value ? null : objRow[conQxUsersV2.OpenId].ToString().Trim(); //微信openid
objQxUsersV2EN.UpdUser = objRow[conQxUsersV2.UpdUser] == DBNull.Value ? null : objRow[conQxUsersV2.UpdUser].ToString().Trim(); //修改用户
objQxUsersV2EN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conQxUsersV2.IsArchive].ToString().Trim()); //是否存档
objQxUsersV2EN.IdentityId = objRow[conQxUsersV2.IdentityId] == DBNull.Value ? null : objRow[conQxUsersV2.IdentityId].ToString().Trim(); //身份编号
objQxUsersV2EN.StuTeacherId = objRow[conQxUsersV2.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsersV2.StuTeacherId].ToString().Trim(); //学工号
objQxUsersV2EN.EffitiveBeginDate = objRow[conQxUsersV2.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objQxUsersV2EN.EffitiveEndDate = objRow[conQxUsersV2.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffitiveEndDate].ToString().Trim(); //有效结束日期
objQxUsersV2EN.UserId = objRow[conQxUsersV2.UserId].ToString().Trim(); //用户ID
objQxUsersV2EN.EffectiveDate = objRow[conQxUsersV2.EffectiveDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffectiveDate].ToString().Trim(); //有效日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUsersV2EN.id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUsersV2EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUsersV2EN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsQxUsersV2EN> arrObjLst = new List<clsQxUsersV2EN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsersV2EN objQxUsersV2EN = new clsQxUsersV2EN();
try
{
objQxUsersV2EN.CreateTime = objRow[conQxUsersV2.CreateTime] == DBNull.Value ? null : objRow[conQxUsersV2.CreateTime].ToString().Trim(); //建立时间
objQxUsersV2EN.updateTime = objRow[conQxUsersV2.updateTime] == DBNull.Value ? null : objRow[conQxUsersV2.updateTime].ToString().Trim(); //修改时间
objQxUsersV2EN.id = Int32.Parse(objRow[conQxUsersV2.id].ToString().Trim()); //id
objQxUsersV2EN.DepartmentIdInt = objRow[conQxUsersV2.DepartmentIdInt] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxUsersV2.DepartmentIdInt].ToString().Trim()); //部门Id
objQxUsersV2EN.name = objRow[conQxUsersV2.name].ToString().Trim(); //姓名
objQxUsersV2EN.UserName = objRow[conQxUsersV2.UserName].ToString().Trim(); //用户名
objQxUsersV2EN.Password = objRow[conQxUsersV2.Password].ToString().Trim(); //口令
objQxUsersV2EN.psalt = objRow[conQxUsersV2.psalt] == DBNull.Value ? null : objRow[conQxUsersV2.psalt].ToString().Trim(); //密码盐值
objQxUsersV2EN.nickName = objRow[conQxUsersV2.nickName] == DBNull.Value ? null : objRow[conQxUsersV2.nickName].ToString().Trim(); //呢称
objQxUsersV2EN.headImg = objRow[conQxUsersV2.headImg] == DBNull.Value ? null : objRow[conQxUsersV2.headImg].ToString().Trim(); //头像
objQxUsersV2EN.Email = objRow[conQxUsersV2.Email] == DBNull.Value ? null : objRow[conQxUsersV2.Email].ToString().Trim(); //邮箱
objQxUsersV2EN.phone = objRow[conQxUsersV2.phone].ToString().Trim(); //电话号码
objQxUsersV2EN.remark = objRow[conQxUsersV2.remark] == DBNull.Value ? null : objRow[conQxUsersV2.remark].ToString().Trim(); //备注
objQxUsersV2EN.status = Int32.Parse(objRow[conQxUsersV2.status].ToString().Trim()); //用户状态Id
objQxUsersV2EN.OpenId = objRow[conQxUsersV2.OpenId] == DBNull.Value ? null : objRow[conQxUsersV2.OpenId].ToString().Trim(); //微信openid
objQxUsersV2EN.UpdUser = objRow[conQxUsersV2.UpdUser] == DBNull.Value ? null : objRow[conQxUsersV2.UpdUser].ToString().Trim(); //修改用户
objQxUsersV2EN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conQxUsersV2.IsArchive].ToString().Trim()); //是否存档
objQxUsersV2EN.IdentityId = objRow[conQxUsersV2.IdentityId] == DBNull.Value ? null : objRow[conQxUsersV2.IdentityId].ToString().Trim(); //身份编号
objQxUsersV2EN.StuTeacherId = objRow[conQxUsersV2.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsersV2.StuTeacherId].ToString().Trim(); //学工号
objQxUsersV2EN.EffitiveBeginDate = objRow[conQxUsersV2.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objQxUsersV2EN.EffitiveEndDate = objRow[conQxUsersV2.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffitiveEndDate].ToString().Trim(); //有效结束日期
objQxUsersV2EN.UserId = objRow[conQxUsersV2.UserId].ToString().Trim(); //用户ID
objQxUsersV2EN.EffectiveDate = objRow[conQxUsersV2.EffectiveDate] == DBNull.Value ? null : objRow[conQxUsersV2.EffectiveDate].ToString().Trim(); //有效日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUsersV2EN.id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUsersV2EN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objQxUsersV2EN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxUsersV2(ref clsQxUsersV2EN objQxUsersV2EN)
{
bool bolResult = QxUsersV2DA.GetQxUsersV2(ref objQxUsersV2EN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "intid">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxUsersV2EN GetObjByid(int intid)
{
clsQxUsersV2EN objQxUsersV2EN = QxUsersV2DA.GetObjByid(intid);
return objQxUsersV2EN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsQxUsersV2EN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsQxUsersV2EN objQxUsersV2EN = QxUsersV2DA.GetFirstObj(strWhereCond);
 return objQxUsersV2EN;
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
public static clsQxUsersV2EN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsQxUsersV2EN objQxUsersV2EN = QxUsersV2DA.GetObjByDataRow(objRow);
 return objQxUsersV2EN;
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
public static clsQxUsersV2EN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsQxUsersV2EN objQxUsersV2EN = QxUsersV2DA.GetObjByDataRow(objRow);
 return objQxUsersV2EN;
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
 /// <param name = "lstQxUsersV2ObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxUsersV2EN GetObjByidFromList(int intid, List<clsQxUsersV2EN> lstQxUsersV2ObjLst)
{
foreach (clsQxUsersV2EN objQxUsersV2EN in lstQxUsersV2ObjLst)
{
if (objQxUsersV2EN.id == intid)
{
return objQxUsersV2EN;
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
 intid = new clsQxUsersV2DA().GetFirstID(strWhereCond);
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
 arrList = QxUsersV2DA.GetID(strWhereCond);
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
bool bolIsExist = QxUsersV2DA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = QxUsersV2DA.IsExist(intid);
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
clsQxUsersV2EN objQxUsersV2EN = clsQxUsersV2BL.GetObjByid(intid);
objQxUsersV2EN.updateTime = clsDateTime.getTodayDateTimeStr(1);
objQxUsersV2EN.UpdUser = strOpUser;
return clsQxUsersV2BL.UpdateBySql2(objQxUsersV2EN);
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
 bolIsExist = clsQxUsersV2DA.IsExistTable();
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
 bolIsExist = QxUsersV2DA.IsExistTable(strTabName);
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
 /// <param name = "objQxUsersV2EN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsQxUsersV2EN objQxUsersV2EN)
{
if (objQxUsersV2EN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!姓名 = [{0}],电话号码 = [{1}]的数据已经存在!(in clsQxUsersV2BL.AddNewRecordBySql2)", objQxUsersV2EN.name,objQxUsersV2EN.phone);
throw new Exception(strMsg);
}
try
{
bool bolResult = QxUsersV2DA.AddNewRecordBySQL2(objQxUsersV2EN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsersV2BL.ReFreshCache();

if (clsQxUsersV2BL.relatedActions != null)
{
clsQxUsersV2BL.relatedActions.UpdRelaTabDate(objQxUsersV2EN.id, objQxUsersV2EN.UpdUser);
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
 /// <param name = "objQxUsersV2EN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsQxUsersV2EN objQxUsersV2EN)
{
if (objQxUsersV2EN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!姓名 = [{0}],电话号码 = [{1}]的数据已经存在!(in clsQxUsersV2BL.AddNewRecordBySql2WithReturnKey)", objQxUsersV2EN.name,objQxUsersV2EN.phone);
throw new Exception(strMsg);
}
try
{
string strKey = QxUsersV2DA.AddNewRecordBySQL2WithReturnKey(objQxUsersV2EN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsersV2BL.ReFreshCache();

if (clsQxUsersV2BL.relatedActions != null)
{
clsQxUsersV2BL.relatedActions.UpdRelaTabDate(objQxUsersV2EN.id, objQxUsersV2EN.UpdUser);
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
 /// <param name = "strQxUsersV2ObjXml">代表实体对象的XML串</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql_XML(string strQxUsersV2ObjXml)
{
clsQxUsersV2EN objQxUsersV2EN = GetObjFromXmlStr(strQxUsersV2ObjXml);
try
{
bool bolResult = QxUsersV2DA.AddNewRecordBySQL2(objQxUsersV2EN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsersV2BL.ReFreshCache();

if (clsQxUsersV2BL.relatedActions != null)
{
clsQxUsersV2BL.relatedActions.UpdRelaTabDate(objQxUsersV2EN.id, objQxUsersV2EN.UpdUser);
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
 /// <param name = "objQxUsersV2EN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsQxUsersV2EN objQxUsersV2EN)
{
try
{
bool bolResult = QxUsersV2DA.Update(objQxUsersV2EN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsersV2BL.ReFreshCache();

if (clsQxUsersV2BL.relatedActions != null)
{
clsQxUsersV2BL.relatedActions.UpdRelaTabDate(objQxUsersV2EN.id, objQxUsersV2EN.UpdUser);
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
 /// <param name = "objQxUsersV2EN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsQxUsersV2EN objQxUsersV2EN)
{
 if (objQxUsersV2EN.id == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = QxUsersV2DA.UpdateBySql2(objQxUsersV2EN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsersV2BL.ReFreshCache();

if (clsQxUsersV2BL.relatedActions != null)
{
clsQxUsersV2BL.relatedActions.UpdRelaTabDate(objQxUsersV2EN.id, objQxUsersV2EN.UpdUser);
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
 /// <param name = "strQxUsersV2ObjXml">需要修改的对象,用XML来表示</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql_XML(string strQxUsersV2ObjXml)
{
clsQxUsersV2EN objQxUsersV2EN = GetObjFromXmlStr(strQxUsersV2ObjXml);
try
{
bool bolResult = QxUsersV2DA.UpdateBySql2(objQxUsersV2EN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsersV2BL.ReFreshCache();

if (clsQxUsersV2BL.relatedActions != null)
{
clsQxUsersV2BL.relatedActions.UpdRelaTabDate(objQxUsersV2EN.id, objQxUsersV2EN.UpdUser);
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
 clsQxUsersV2EN objQxUsersV2EN = clsQxUsersV2BL.GetObjByid(intid);

if (clsQxUsersV2BL.relatedActions != null)
{
clsQxUsersV2BL.relatedActions.UpdRelaTabDate(objQxUsersV2EN.id, objQxUsersV2EN.UpdUser);
}
if (objQxUsersV2EN != null)
{
int intRecNum = QxUsersV2DA.DelRecord(intid);
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
/// <param name="intid">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(int intid )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxUsersV2DA.GetSpecSQLObj();
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
//删除与表:[QxUsersV2]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conQxUsersV2.id,
//intid);
//        clsQxUsersV2BL.DelQxUsersV2sByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxUsersV2BL.DelRecord(intid, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxUsersV2BLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
public static bool DelRecord(int intid, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsQxUsersV2BL.relatedActions != null)
{
clsQxUsersV2BL.relatedActions.UpdRelaTabDate(intid, "UpdRelaTabDate");
}
bool bolResult = QxUsersV2DA.DelRecord(intid,objSqlConnection,objSqlTransaction);
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
 /// <param name = "intid">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(int intid) 
{
try
{
if (clsQxUsersV2BL.relatedActions != null)
{
clsQxUsersV2BL.relatedActions.UpdRelaTabDate(intid, "UpdRelaTabDate");
}
bool bolResult = QxUsersV2DA.DelRecordBySP(intid);
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
 /// <param name = "arridLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelQxUsersV2s(List<string> arridLst)
{
if (arridLst.Count == 0) return 0;
try
{
if (clsQxUsersV2BL.relatedActions != null)
{
foreach (var strid in arridLst)
{
int intid = int.Parse(strid);
clsQxUsersV2BL.relatedActions.UpdRelaTabDate(intid, "UpdRelaTabDate");
}
}
int intDelRecNum = QxUsersV2DA.DelQxUsersV2(arridLst);
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
public static int DelQxUsersV2sByCond(string strWhereCond)
{
try
{
if (clsQxUsersV2BL.relatedActions != null)
{
List<string> arrid = GetPrimaryKeyID_S(strWhereCond);
foreach (var strid in arrid)
{
int intid = int.Parse(strid);
clsQxUsersV2BL.relatedActions.UpdRelaTabDate(intid, "UpdRelaTabDate");
}
}
int intRecNum = QxUsersV2DA.DelQxUsersV2(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[QxUsersV2]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="intid">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(int intid)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxUsersV2DA.GetSpecSQLObj();
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
//删除与表:[QxUsersV2]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxUsersV2BL.DelRecord(intid, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxUsersV2BL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objQxUsersV2ENS">源对象</param>
 /// <param name = "objQxUsersV2ENT">目标对象</param>
 public static void CopyTo(clsQxUsersV2EN objQxUsersV2ENS, clsQxUsersV2EN objQxUsersV2ENT)
{
try
{
objQxUsersV2ENT.CreateTime = objQxUsersV2ENS.CreateTime; //建立时间
objQxUsersV2ENT.updateTime = objQxUsersV2ENS.updateTime; //修改时间
objQxUsersV2ENT.id = objQxUsersV2ENS.id; //id
objQxUsersV2ENT.DepartmentIdInt = objQxUsersV2ENS.DepartmentIdInt; //部门Id
objQxUsersV2ENT.name = objQxUsersV2ENS.name; //姓名
objQxUsersV2ENT.UserName = objQxUsersV2ENS.UserName; //用户名
objQxUsersV2ENT.Password = objQxUsersV2ENS.Password; //口令
objQxUsersV2ENT.psalt = objQxUsersV2ENS.psalt; //密码盐值
objQxUsersV2ENT.nickName = objQxUsersV2ENS.nickName; //呢称
objQxUsersV2ENT.headImg = objQxUsersV2ENS.headImg; //头像
objQxUsersV2ENT.Email = objQxUsersV2ENS.Email; //邮箱
objQxUsersV2ENT.phone = objQxUsersV2ENS.phone; //电话号码
objQxUsersV2ENT.remark = objQxUsersV2ENS.remark; //备注
objQxUsersV2ENT.status = objQxUsersV2ENS.status; //用户状态Id
objQxUsersV2ENT.OpenId = objQxUsersV2ENS.OpenId; //微信openid
objQxUsersV2ENT.UpdUser = objQxUsersV2ENS.UpdUser; //修改用户
objQxUsersV2ENT.IsArchive = objQxUsersV2ENS.IsArchive; //是否存档
objQxUsersV2ENT.IdentityId = objQxUsersV2ENS.IdentityId; //身份编号
objQxUsersV2ENT.StuTeacherId = objQxUsersV2ENS.StuTeacherId; //学工号
objQxUsersV2ENT.EffitiveBeginDate = objQxUsersV2ENS.EffitiveBeginDate; //有效开始日期
objQxUsersV2ENT.EffitiveEndDate = objQxUsersV2ENS.EffitiveEndDate; //有效结束日期
objQxUsersV2ENT.UserId = objQxUsersV2ENS.UserId; //用户ID
objQxUsersV2ENT.EffectiveDate = objQxUsersV2ENS.EffectiveDate; //有效日期
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
 /// <param name = "objQxUsersV2EN">源简化对象</param>
 public static void SetUpdFlag(clsQxUsersV2EN objQxUsersV2EN)
{
try
{
objQxUsersV2EN.ClearUpdateState();
   string strsfUpdFldSetStr = objQxUsersV2EN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conQxUsersV2.CreateTime, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsersV2EN.CreateTime = objQxUsersV2EN.CreateTime == "[null]" ? null :  objQxUsersV2EN.CreateTime; //建立时间
}
if (arrFldSet.Contains(conQxUsersV2.updateTime, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsersV2EN.updateTime = objQxUsersV2EN.updateTime == "[null]" ? null :  objQxUsersV2EN.updateTime; //修改时间
}
if (arrFldSet.Contains(conQxUsersV2.id, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsersV2EN.id = objQxUsersV2EN.id; //id
}
if (arrFldSet.Contains(conQxUsersV2.DepartmentIdInt, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsersV2EN.DepartmentIdInt = objQxUsersV2EN.DepartmentIdInt; //部门Id
}
if (arrFldSet.Contains(conQxUsersV2.name, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsersV2EN.name = objQxUsersV2EN.name; //姓名
}
if (arrFldSet.Contains(conQxUsersV2.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsersV2EN.UserName = objQxUsersV2EN.UserName; //用户名
}
if (arrFldSet.Contains(conQxUsersV2.Password, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsersV2EN.Password = objQxUsersV2EN.Password; //口令
}
if (arrFldSet.Contains(conQxUsersV2.psalt, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsersV2EN.psalt = objQxUsersV2EN.psalt == "[null]" ? null :  objQxUsersV2EN.psalt; //密码盐值
}
if (arrFldSet.Contains(conQxUsersV2.nickName, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsersV2EN.nickName = objQxUsersV2EN.nickName == "[null]" ? null :  objQxUsersV2EN.nickName; //呢称
}
if (arrFldSet.Contains(conQxUsersV2.headImg, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsersV2EN.headImg = objQxUsersV2EN.headImg == "[null]" ? null :  objQxUsersV2EN.headImg; //头像
}
if (arrFldSet.Contains(conQxUsersV2.Email, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsersV2EN.Email = objQxUsersV2EN.Email == "[null]" ? null :  objQxUsersV2EN.Email; //邮箱
}
if (arrFldSet.Contains(conQxUsersV2.phone, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsersV2EN.phone = objQxUsersV2EN.phone; //电话号码
}
if (arrFldSet.Contains(conQxUsersV2.remark, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsersV2EN.remark = objQxUsersV2EN.remark == "[null]" ? null :  objQxUsersV2EN.remark; //备注
}
if (arrFldSet.Contains(conQxUsersV2.status, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsersV2EN.status = objQxUsersV2EN.status; //用户状态Id
}
if (arrFldSet.Contains(conQxUsersV2.OpenId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsersV2EN.OpenId = objQxUsersV2EN.OpenId == "[null]" ? null :  objQxUsersV2EN.OpenId; //微信openid
}
if (arrFldSet.Contains(conQxUsersV2.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsersV2EN.UpdUser = objQxUsersV2EN.UpdUser == "[null]" ? null :  objQxUsersV2EN.UpdUser; //修改用户
}
if (arrFldSet.Contains(conQxUsersV2.IsArchive, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsersV2EN.IsArchive = objQxUsersV2EN.IsArchive; //是否存档
}
if (arrFldSet.Contains(conQxUsersV2.IdentityId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsersV2EN.IdentityId = objQxUsersV2EN.IdentityId == "[null]" ? null :  objQxUsersV2EN.IdentityId; //身份编号
}
if (arrFldSet.Contains(conQxUsersV2.StuTeacherId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsersV2EN.StuTeacherId = objQxUsersV2EN.StuTeacherId == "[null]" ? null :  objQxUsersV2EN.StuTeacherId; //学工号
}
if (arrFldSet.Contains(conQxUsersV2.EffitiveBeginDate, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsersV2EN.EffitiveBeginDate = objQxUsersV2EN.EffitiveBeginDate == "[null]" ? null :  objQxUsersV2EN.EffitiveBeginDate; //有效开始日期
}
if (arrFldSet.Contains(conQxUsersV2.EffitiveEndDate, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsersV2EN.EffitiveEndDate = objQxUsersV2EN.EffitiveEndDate == "[null]" ? null :  objQxUsersV2EN.EffitiveEndDate; //有效结束日期
}
if (arrFldSet.Contains(conQxUsersV2.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsersV2EN.UserId = objQxUsersV2EN.UserId; //用户ID
}
if (arrFldSet.Contains(conQxUsersV2.EffectiveDate, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsersV2EN.EffectiveDate = objQxUsersV2EN.EffectiveDate == "[null]" ? null :  objQxUsersV2EN.EffectiveDate; //有效日期
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
 /// <param name = "objQxUsersV2EN">源简化对象</param>
 public static void AccessFldValueNull(clsQxUsersV2EN objQxUsersV2EN)
{
try
{
if (objQxUsersV2EN.CreateTime == "[null]") objQxUsersV2EN.CreateTime = null; //建立时间
if (objQxUsersV2EN.updateTime == "[null]") objQxUsersV2EN.updateTime = null; //修改时间
if (objQxUsersV2EN.psalt == "[null]") objQxUsersV2EN.psalt = null; //密码盐值
if (objQxUsersV2EN.nickName == "[null]") objQxUsersV2EN.nickName = null; //呢称
if (objQxUsersV2EN.headImg == "[null]") objQxUsersV2EN.headImg = null; //头像
if (objQxUsersV2EN.Email == "[null]") objQxUsersV2EN.Email = null; //邮箱
if (objQxUsersV2EN.remark == "[null]") objQxUsersV2EN.remark = null; //备注
if (objQxUsersV2EN.OpenId == "[null]") objQxUsersV2EN.OpenId = null; //微信openid
if (objQxUsersV2EN.UpdUser == "[null]") objQxUsersV2EN.UpdUser = null; //修改用户
if (objQxUsersV2EN.IdentityId == "[null]") objQxUsersV2EN.IdentityId = null; //身份编号
if (objQxUsersV2EN.StuTeacherId == "[null]") objQxUsersV2EN.StuTeacherId = null; //学工号
if (objQxUsersV2EN.EffitiveBeginDate == "[null]") objQxUsersV2EN.EffitiveBeginDate = null; //有效开始日期
if (objQxUsersV2EN.EffitiveEndDate == "[null]") objQxUsersV2EN.EffitiveEndDate = null; //有效结束日期
if (objQxUsersV2EN.EffectiveDate == "[null]") objQxUsersV2EN.EffectiveDate = null; //有效日期
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
public static void CheckPropertyNew(clsQxUsersV2EN objQxUsersV2EN)
{
 QxUsersV2DA.CheckPropertyNew(objQxUsersV2EN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsQxUsersV2EN objQxUsersV2EN)
{
 QxUsersV2DA.CheckProperty4Condition(objQxUsersV2EN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_idCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[用户V2]...","0");
List<clsQxUsersV2EN> arrQxUsersV2ObjLst = GetAllQxUsersV2ObjLstCache(); 
objDDL.DataValueField = conQxUsersV2.id;
objDDL.DataTextField = conQxUsersV2.name;
objDDL.DataSource = arrQxUsersV2ObjLst;
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
if (clsQxUsersV2BL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxUsersV2BL没有刷新缓存机制(clsQxUsersV2BL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id");
//if (arrQxUsersV2ObjLstCache == null)
//{
//arrQxUsersV2ObjLstCache = QxUsersV2DA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "intid">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxUsersV2EN GetObjByidCache(int intid)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsQxUsersV2EN._CurrTabName);
List<clsQxUsersV2EN> arrQxUsersV2ObjLstCache = GetObjLstCache();
IEnumerable <clsQxUsersV2EN> arrQxUsersV2ObjLst_Sel =
arrQxUsersV2ObjLstCache
.Where(x=> x.id == intid 
);
if (arrQxUsersV2ObjLst_Sel.Count() == 0)
{
   clsQxUsersV2EN obj = clsQxUsersV2BL.GetObjByid(intid);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrQxUsersV2ObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "intid">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetUserNameByidCache(int intid)
{
//获取缓存中的对象列表
clsQxUsersV2EN objQxUsersV2 = GetObjByidCache(intid);
if (objQxUsersV2 == null) return "";
return objQxUsersV2.UserName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "intid">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByidCache(int intid)
{
//获取缓存中的对象列表
clsQxUsersV2EN objQxUsersV2 = GetObjByidCache(intid);
if (objQxUsersV2 == null) return "";
return objQxUsersV2.UserName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxUsersV2EN> GetAllQxUsersV2ObjLstCache()
{
//获取缓存中的对象列表
List<clsQxUsersV2EN> arrQxUsersV2ObjLstCache = GetObjLstCache(); 
return arrQxUsersV2ObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxUsersV2EN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsQxUsersV2EN._CurrTabName);
List<clsQxUsersV2EN> arrQxUsersV2ObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrQxUsersV2ObjLstCache;
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
string strKey = string.Format("{0}", clsQxUsersV2EN._CurrTabName);
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
if (clsQxUsersV2BL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsQxUsersV2EN._CurrTabName);
CacheHelper.Remove(strKey);
clsQxUsersV2BL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--QxUsersV2(用户V2)
 /// 唯一性条件:name_phone
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQxUsersV2EN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsQxUsersV2EN objQxUsersV2EN)
{
//检测记录是否存在
string strResult = QxUsersV2DA.GetUniCondStr(objQxUsersV2EN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-12-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstQxUsersV2ObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsQxUsersV2EN> lstQxUsersV2ObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstQxUsersV2ObjLst, writer);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 序列化一个对象列表到XmlWriter
 /// 作者:pyf
 /// 日期:2023-12-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXML)
 /// </summary>
 /// <param name = "lstQxUsersV2ObjLst">[clsQxUsersV2EN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsQxUsersV2EN> lstQxUsersV2ObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsQxUsersV2BL.listXmlNode);
writer.WriteStartElement(clsQxUsersV2BL.itemsXmlNode);
foreach (clsQxUsersV2EN objQxUsersV2EN in lstQxUsersV2ObjLst)
{
clsQxUsersV2BL.SerializeXML(writer, objQxUsersV2EN);
}
writer.WriteEndElement();
writer.WriteEndElement();
return true;
}

 /// <summary>
 /// 把一个对象序列化到XML中
 /// 作者:pyf
 /// 日期:2023-12-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeXML)
 /// </summary>
 /// <param name = "writer">目标:序列化到的XmlWriter</param>
 /// <param name = "objQxUsersV2EN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsQxUsersV2EN objQxUsersV2EN)
{
writer.WriteStartElement(clsQxUsersV2BL.itemXmlNode);
 
if (objQxUsersV2EN.CreateTime != null)
{
writer.WriteElementString(conQxUsersV2.CreateTime, objQxUsersV2EN.CreateTime.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUsersV2EN.updateTime != null)
{
writer.WriteElementString(conQxUsersV2.updateTime, objQxUsersV2EN.updateTime.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(conQxUsersV2.id, objQxUsersV2EN.id.ToString(CultureInfo.InvariantCulture));
 
writer.WriteElementString(conQxUsersV2.DepartmentIdInt, objQxUsersV2EN.DepartmentIdInt.ToString());
 
if (objQxUsersV2EN.name != null)
{
writer.WriteElementString(conQxUsersV2.name, objQxUsersV2EN.name.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUsersV2EN.UserName != null)
{
writer.WriteElementString(conQxUsersV2.UserName, objQxUsersV2EN.UserName.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUsersV2EN.Password != null)
{
writer.WriteElementString(conQxUsersV2.Password, objQxUsersV2EN.Password.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUsersV2EN.psalt != null)
{
writer.WriteElementString(conQxUsersV2.psalt, objQxUsersV2EN.psalt.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUsersV2EN.nickName != null)
{
writer.WriteElementString(conQxUsersV2.nickName, objQxUsersV2EN.nickName.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUsersV2EN.headImg != null)
{
writer.WriteElementString(conQxUsersV2.headImg, objQxUsersV2EN.headImg.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUsersV2EN.Email != null)
{
writer.WriteElementString(conQxUsersV2.Email, objQxUsersV2EN.Email.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUsersV2EN.phone != null)
{
writer.WriteElementString(conQxUsersV2.phone, objQxUsersV2EN.phone.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUsersV2EN.remark != null)
{
writer.WriteElementString(conQxUsersV2.remark, objQxUsersV2EN.remark.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(conQxUsersV2.status, objQxUsersV2EN.status.ToString(CultureInfo.InvariantCulture));
 
if (objQxUsersV2EN.OpenId != null)
{
writer.WriteElementString(conQxUsersV2.OpenId, objQxUsersV2EN.OpenId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUsersV2EN.UpdUser != null)
{
writer.WriteElementString(conQxUsersV2.UpdUser, objQxUsersV2EN.UpdUser.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(conQxUsersV2.IsArchive, objQxUsersV2EN.IsArchive.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objQxUsersV2EN.IdentityId != null)
{
writer.WriteElementString(conQxUsersV2.IdentityId, objQxUsersV2EN.IdentityId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUsersV2EN.StuTeacherId != null)
{
writer.WriteElementString(conQxUsersV2.StuTeacherId, objQxUsersV2EN.StuTeacherId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUsersV2EN.EffitiveBeginDate != null)
{
writer.WriteElementString(conQxUsersV2.EffitiveBeginDate, objQxUsersV2EN.EffitiveBeginDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUsersV2EN.EffitiveEndDate != null)
{
writer.WriteElementString(conQxUsersV2.EffitiveEndDate, objQxUsersV2EN.EffitiveEndDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUsersV2EN.UserId != null)
{
writer.WriteElementString(conQxUsersV2.UserId, objQxUsersV2EN.UserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUsersV2EN.EffectiveDate != null)
{
writer.WriteElementString(conQxUsersV2.EffectiveDate, objQxUsersV2EN.EffectiveDate.ToString(CultureInfo.InvariantCulture));
}
writer.WriteEndElement();
}

 /// <summary>
 /// 读XmlReader到一个对象
 /// 作者:pyf
 /// 日期:2023-12-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlReader)
 /// </summary>
 /// <param name = "reader">提供的数据源:XmlReader</param>
 /// <returns>返回的一个对象</returns>
public static clsQxUsersV2EN GetObjFromXml(System.Xml.XmlReader reader)
{
clsQxUsersV2EN objQxUsersV2EN = new clsQxUsersV2EN();
reader.Read();
while (!(reader.Name == clsQxUsersV2BL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(conQxUsersV2.CreateTime))
{
objQxUsersV2EN.CreateTime = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsersV2.updateTime))
{
objQxUsersV2EN.updateTime = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsersV2.id))
{
objQxUsersV2EN.id = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(conQxUsersV2.DepartmentIdInt))
{
objQxUsersV2EN.DepartmentIdInt = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(conQxUsersV2.name))
{
objQxUsersV2EN.name = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsersV2.UserName))
{
objQxUsersV2EN.UserName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsersV2.Password))
{
objQxUsersV2EN.Password = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsersV2.psalt))
{
objQxUsersV2EN.psalt = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsersV2.nickName))
{
objQxUsersV2EN.nickName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsersV2.headImg))
{
objQxUsersV2EN.headImg = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsersV2.Email))
{
objQxUsersV2EN.Email = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsersV2.phone))
{
objQxUsersV2EN.phone = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsersV2.remark))
{
objQxUsersV2EN.remark = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsersV2.status))
{
objQxUsersV2EN.status = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(conQxUsersV2.OpenId))
{
objQxUsersV2EN.OpenId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsersV2.UpdUser))
{
objQxUsersV2EN.UpdUser = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsersV2.IsArchive))
{
objQxUsersV2EN.IsArchive = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(conQxUsersV2.IdentityId))
{
objQxUsersV2EN.IdentityId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsersV2.StuTeacherId))
{
objQxUsersV2EN.StuTeacherId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsersV2.EffitiveBeginDate))
{
objQxUsersV2EN.EffitiveBeginDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsersV2.EffitiveEndDate))
{
objQxUsersV2EN.EffitiveEndDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsersV2.UserId))
{
objQxUsersV2EN.UserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsersV2.EffectiveDate))
{
objQxUsersV2EN.EffectiveDate = reader.ReadElementContentAsString();
}
}
return objQxUsersV2EN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strQxUsersV2ObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsQxUsersV2EN GetObjFromXmlStr(string strQxUsersV2ObjXmlStr)
{
clsQxUsersV2EN objQxUsersV2EN = new clsQxUsersV2EN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strQxUsersV2ObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsQxUsersV2BL.itemXmlNode))
{
objQxUsersV2EN = GetObjFromXml(reader);
return objQxUsersV2EN;
}
}
return objQxUsersV2EN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-12-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsQxUsersV2EN objQxUsersV2EN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objQxUsersV2EN);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-12-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, int intid)
{
if (strInFldName != conQxUsersV2.id)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conQxUsersV2.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conQxUsersV2.AttributeName));
throw new Exception(strMsg);
}
var objQxUsersV2 = clsQxUsersV2BL.GetObjByidCache(intid);
if (objQxUsersV2 == null) return "";
return objQxUsersV2[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-12-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsQxUsersV2EN objQxUsersV2EN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsQxUsersV2EN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objQxUsersV2EN[strField]);
}
sbJSON.Remove(sbJSON.Length - 1, 1);
sbJSON.Append("}");
return sbJSON.ToString();
}

 /// <summary>
 /// 序列化一个对象列表到JSON串
 /// 作者:pyf
 /// 日期:2023-12-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToJSONStr)
 /// </summary>
 /// <param name = "lstQxUsersV2ObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsQxUsersV2EN> lstQxUsersV2ObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstQxUsersV2ObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsQxUsersV2EN objQxUsersV2EN in lstQxUsersV2ObjLst)
{
string strJSON_One = SerializeObjToJSON(objQxUsersV2EN);
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
int intRecCount = clsQxUsersV2DA.GetRecCount(strTabName);
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
int intRecCount = clsQxUsersV2DA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsQxUsersV2DA.GetRecCount();
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
int intRecCount = clsQxUsersV2DA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objQxUsersV2Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsQxUsersV2EN objQxUsersV2Cond)
{
List<clsQxUsersV2EN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxUsersV2EN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxUsersV2.AttributeName)
{
if (objQxUsersV2Cond.IsUpdated(strFldName) == false) continue;
if (objQxUsersV2Cond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUsersV2Cond[strFldName].ToString());
}
else
{
if (objQxUsersV2Cond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxUsersV2Cond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUsersV2Cond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxUsersV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxUsersV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxUsersV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxUsersV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxUsersV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxUsersV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxUsersV2Cond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxUsersV2Cond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxUsersV2Cond[strFldName]));
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
 List<string> arrList = clsQxUsersV2DA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = QxUsersV2DA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = QxUsersV2DA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = QxUsersV2DA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxUsersV2DA.SetFldValue(clsQxUsersV2EN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = QxUsersV2DA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxUsersV2DA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxUsersV2DA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxUsersV2DA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[QxUsersV2] "); 
 strCreateTabCode.Append(" ( "); 
 // /**建立时间*/ 
 strCreateTabCode.Append(" CreateTime varchar(20) Null, "); 
 // /**修改时间*/ 
 strCreateTabCode.Append(" updateTime varchar(20) Null, "); 
 // /**id*/ 
 strCreateTabCode.Append(" id int primary key identity, "); 
 // /**部门Id*/ 
 strCreateTabCode.Append(" DepartmentIdInt int Null, "); 
 // /**姓名*/ 
 strCreateTabCode.Append(" name varchar(30) not Null, "); 
 // /**用户名*/ 
 strCreateTabCode.Append(" UserName varchar(30) not Null, "); 
 // /**口令*/ 
 strCreateTabCode.Append(" Password varchar(20) not Null, "); 
 // /**密码盐值*/ 
 strCreateTabCode.Append(" psalt varchar(20) Null, "); 
 // /**呢称*/ 
 strCreateTabCode.Append(" nickName varchar(100) Null, "); 
 // /**头像*/ 
 strCreateTabCode.Append(" headImg varchar(100) Null, "); 
 // /**邮箱*/ 
 strCreateTabCode.Append(" Email varchar(100) Null, "); 
 // /**电话号码*/ 
 strCreateTabCode.Append(" phone varchar(15) not Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" remark varchar(1000) Null, "); 
 // /**用户状态Id*/ 
 strCreateTabCode.Append(" status int not Null, "); 
 // /**微信openid*/ 
 strCreateTabCode.Append(" OpenId varchar(50) Null, "); 
 // /**修改用户*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**是否存档*/ 
 strCreateTabCode.Append(" IsArchive bit Null, "); 
 // /**身份编号*/ 
 strCreateTabCode.Append(" IdentityId char(2) Null, "); 
 // /**学工号*/ 
 strCreateTabCode.Append(" StuTeacherId varchar(20) Null, "); 
 // /**有效开始日期*/ 
 strCreateTabCode.Append(" EffitiveBeginDate varchar(14) Null, "); 
 // /**有效结束日期*/ 
 strCreateTabCode.Append(" EffitiveEndDate varchar(14) Null, "); 
 // /**用户ID*/ 
 strCreateTabCode.Append(" UserId varchar(18) not Null, "); 
 // /**有效日期*/ 
 strCreateTabCode.Append(" EffectiveDate varchar(8) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 数据同步


 #endregion 数据同步
}
 /// <summary>
 /// 用户V2(QxUsersV2)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4QxUsersV2 : clsCommFun4BL
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
clsQxUsersV2BL.ReFreshThisCache();
}
}

}