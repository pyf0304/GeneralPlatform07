
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUsersBL
 表名:QxUsers(00140015)
 * 版本:2024.03.19.1(服务器:WIN-SRV103-116)
 日期:2024/03/20 11:14:06
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
public static class  clsQxUsersBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strUserId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxUsersEN GetObj(this K_UserId_QxUsers myKey)
{
clsQxUsersEN objQxUsersEN = clsQxUsersBL.QxUsersDA.GetObjByUserId(myKey.Value);
return objQxUsersEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQxUsersEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQxUsersEN objQxUsersEN)
{
 if (string.IsNullOrEmpty(objQxUsersEN.UserId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQxUsersBL.IsExist(objQxUsersEN.UserId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQxUsersEN.UserId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsQxUsersBL.QxUsersDA.AddNewRecordBySQL2(objQxUsersEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsersBL.ReFreshCache();

if (clsQxUsersBL.relatedActions != null)
{
clsQxUsersBL.relatedActions.UpdRelaTabDate(objQxUsersEN.UserId, objQxUsersEN.UpdUser);
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
public static bool AddRecordEx(this clsQxUsersEN objQxUsersEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsQxUsersBL.IsExist(objQxUsersEN.UserId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objQxUsersEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objQxUsersEN.AddNewRecord();
}
catch(Exception objException)
{
strMsg = "(errid:Busi000152)添加记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true;
}

 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithTransaction)
 /// </summary>
 /// <param name = "objQxUsersEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQxUsersEN objQxUsersEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objQxUsersEN.UserId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空.(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQxUsersBL.IsExist(objQxUsersEN.UserId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQxUsersEN.UserId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsQxUsersBL.QxUsersDA.AddNewRecordBySQL2(objQxUsersEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsersBL.ReFreshCache();

if (clsQxUsersBL.relatedActions != null)
{
clsQxUsersBL.relatedActions.UpdRelaTabDate(objQxUsersEN.UserId, objQxUsersEN.UpdUser);
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000086)添加记录出错!(带事务处理), {1}.({0})",
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
 /// <param name = "objQxUsersEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsQxUsersEN objQxUsersEN)
{
 if (string.IsNullOrEmpty(objQxUsersEN.UserId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQxUsersBL.IsExist(objQxUsersEN.UserId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQxUsersEN.UserId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsQxUsersBL.QxUsersDA.AddNewRecordBySQL2WithReturnKey(objQxUsersEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsersBL.ReFreshCache();

if (clsQxUsersBL.relatedActions != null)
{
clsQxUsersBL.relatedActions.UpdRelaTabDate(objQxUsersEN.UserId, objQxUsersEN.UpdUser);
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
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersEN SetUserId(this clsQxUsersEN objQxUsersEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conQxUsers.UserId);
}
objQxUsersEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.UserId) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.UserId, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.UserId] = strComparisonOp;
}
}
return objQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersEN SetUserName(this clsQxUsersEN objQxUsersEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, conQxUsers.UserName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, conQxUsers.UserName);
}
objQxUsersEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.UserName) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.UserName, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.UserName] = strComparisonOp;
}
}
return objQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersEN SetDepartmentId(this clsQxUsersEN objQxUsersEN, string strDepartmentId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentId, 8, conQxUsers.DepartmentId);
}
objQxUsersEN.DepartmentId = strDepartmentId; //部门Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.DepartmentId) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.DepartmentId, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.DepartmentId] = strComparisonOp;
}
}
return objQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersEN SetUserStateId(this clsQxUsersEN objQxUsersEN, string strUserStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserStateId, conQxUsers.UserStateId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserStateId, 2, conQxUsers.UserStateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserStateId, 2, conQxUsers.UserStateId);
}
objQxUsersEN.UserStateId = strUserStateId; //用户状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.UserStateId) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.UserStateId, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.UserStateId] = strComparisonOp;
}
}
return objQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersEN SetPassword(this clsQxUsersEN objQxUsersEN, string strPassword, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPassword, conQxUsers.Password);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPassword, 20, conQxUsers.Password);
}
objQxUsersEN.Password = strPassword; //口令
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.Password) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.Password, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.Password] = strComparisonOp;
}
}
return objQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersEN SetEffitiveBeginDate(this clsQxUsersEN objQxUsersEN, string strEffitiveBeginDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEffitiveBeginDate, 14, conQxUsers.EffitiveBeginDate);
}
objQxUsersEN.EffitiveBeginDate = strEffitiveBeginDate; //有效开始日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.EffitiveBeginDate) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.EffitiveBeginDate, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.EffitiveBeginDate] = strComparisonOp;
}
}
return objQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersEN SetEffitiveEndDate(this clsQxUsersEN objQxUsersEN, string strEffitiveEndDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEffitiveEndDate, 14, conQxUsers.EffitiveEndDate);
}
objQxUsersEN.EffitiveEndDate = strEffitiveEndDate; //有效结束日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.EffitiveEndDate) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.EffitiveEndDate, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.EffitiveEndDate] = strComparisonOp;
}
}
return objQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersEN SetStuTeacherId(this clsQxUsersEN objQxUsersEN, string strStuTeacherId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuTeacherId, 20, conQxUsers.StuTeacherId);
}
objQxUsersEN.StuTeacherId = strStuTeacherId; //学工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.StuTeacherId) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.StuTeacherId, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.StuTeacherId] = strComparisonOp;
}
}
return objQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersEN SetIdentityId(this clsQxUsersEN objQxUsersEN, string strIdentityId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdentityId, 2, conQxUsers.IdentityId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdentityId, 2, conQxUsers.IdentityId);
}
objQxUsersEN.IdentityId = strIdentityId; //身份编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.IdentityId) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.IdentityId, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.IdentityId] = strComparisonOp;
}
}
return objQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersEN SetIsArchive(this clsQxUsersEN objQxUsersEN, bool bolIsArchive, string strComparisonOp="")
	{
objQxUsersEN.IsArchive = bolIsArchive; //是否存档
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.IsArchive) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.IsArchive, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.IsArchive] = strComparisonOp;
}
}
return objQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersEN SetOpenId(this clsQxUsersEN objQxUsersEN, string strOpenId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOpenId, 50, conQxUsers.OpenId);
}
objQxUsersEN.OpenId = strOpenId; //微信openid
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.OpenId) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.OpenId, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.OpenId] = strComparisonOp;
}
}
return objQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersEN SetEmail(this clsQxUsersEN objQxUsersEN, string strEmail, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEmail, 100, conQxUsers.Email);
}
objQxUsersEN.Email = strEmail; //邮箱
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.Email) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.Email, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.Email] = strComparisonOp;
}
}
return objQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersEN SetPhoneNumber(this clsQxUsersEN objQxUsersEN, string strPhoneNumber, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPhoneNumber, 15, conQxUsers.PhoneNumber);
}
objQxUsersEN.PhoneNumber = strPhoneNumber; //电话号码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.PhoneNumber) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.PhoneNumber, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.PhoneNumber] = strComparisonOp;
}
}
return objQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersEN SetIsSynch(this clsQxUsersEN objQxUsersEN, bool bolIsSynch, string strComparisonOp="")
	{
objQxUsersEN.IsSynch = bolIsSynch; //是否同步
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.IsSynch) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.IsSynch, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.IsSynch] = strComparisonOp;
}
}
return objQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersEN SetSynchDate(this clsQxUsersEN objQxUsersEN, string strSynchDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSynchDate, 30, conQxUsers.SynchDate);
}
objQxUsersEN.SynchDate = strSynchDate; //同步日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.SynchDate) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.SynchDate, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.SynchDate] = strComparisonOp;
}
}
return objQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersEN SetDetailInfoTab(this clsQxUsersEN objQxUsersEN, string strDetailInfoTab, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDetailInfoTab, 30, conQxUsers.DetailInfoTab);
}
objQxUsersEN.DetailInfoTab = strDetailInfoTab; //详细信息表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.DetailInfoTab) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.DetailInfoTab, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.DetailInfoTab] = strComparisonOp;
}
}
return objQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersEN SetIdGradeBase(this clsQxUsersEN objQxUsersEN, string strIdGradeBase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdGradeBase, 4, conQxUsers.IdGradeBase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdGradeBase, 4, conQxUsers.IdGradeBase);
}
objQxUsersEN.IdGradeBase = strIdGradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.IdGradeBase) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.IdGradeBase, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.IdGradeBase] = strComparisonOp;
}
}
return objQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersEN SetIdSchool(this clsQxUsersEN objQxUsersEN, string strIdSchool, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSchool, 4, conQxUsers.IdSchool);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSchool, 4, conQxUsers.IdSchool);
}
objQxUsersEN.IdSchool = strIdSchool; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.IdSchool) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.IdSchool, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.IdSchool] = strComparisonOp;
}
}
return objQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersEN SetIdXzCollege(this clsQxUsersEN objQxUsersEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, conQxUsers.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, conQxUsers.IdXzCollege);
}
objQxUsersEN.IdXzCollege = strIdXzCollege; //学院Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.IdXzCollege) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.IdXzCollege, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.IdXzCollege] = strComparisonOp;
}
}
return objQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersEN SetUpdDate(this clsQxUsersEN objQxUsersEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQxUsers.UpdDate);
}
objQxUsersEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.UpdDate) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.UpdDate, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.UpdDate] = strComparisonOp;
}
}
return objQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersEN SetUpdUser(this clsQxUsersEN objQxUsersEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conQxUsers.UpdUser);
}
objQxUsersEN.UpdUser = strUpdUser; //修改用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.UpdUser) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.UpdUser, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.UpdUser] = strComparisonOp;
}
}
return objQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersEN SetMemo(this clsQxUsersEN objQxUsersEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQxUsers.Memo);
}
objQxUsersEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsersEN.dicFldComparisonOp.ContainsKey(conQxUsers.Memo) == false)
{
objQxUsersEN.dicFldComparisonOp.Add(conQxUsers.Memo, strComparisonOp);
}
else
{
objQxUsersEN.dicFldComparisonOp[conQxUsers.Memo] = strComparisonOp;
}
}
return objQxUsersEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objQxUsersEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsQxUsersEN objQxUsersEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objQxUsersEN.CheckPropertyNew();
clsQxUsersEN objQxUsersCond = new clsQxUsersEN();
string strCondition = objQxUsersCond
.SetUserId(objQxUsersEN.UserId, "=")
.GetCombineCondition();
objQxUsersEN._IsCheckProperty = true;
bool bolIsExist = clsQxUsersBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objQxUsersEN.Update();
}
catch(Exception objException)
{
strMsg = "修改记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objQxUsersEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxUsersEN objQxUsersEN)
{
 if (string.IsNullOrEmpty(objQxUsersEN.UserId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxUsersBL.QxUsersDA.UpdateBySql2(objQxUsersEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsersBL.ReFreshCache();

if (clsQxUsersBL.relatedActions != null)
{
clsQxUsersBL.relatedActions.UpdRelaTabDate(objQxUsersEN.UserId, objQxUsersEN.UpdUser);
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateBySql2WithTransaction_S)
 /// </summary>
 /// <param name = "objQxUsersEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(this clsQxUsersEN objQxUsersEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objQxUsersEN.UserId) == true)
 {
string strMsg = string.Format("(errid:Busi000066)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxUsersBL.QxUsersDA.UpdateBySql2(objQxUsersEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsersBL.ReFreshCache();

if (clsQxUsersBL.relatedActions != null)
{
clsQxUsersBL.relatedActions.UpdRelaTabDate(objQxUsersEN.UserId, objQxUsersEN.UpdUser);
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000035)修改记录出错,{1}.(带事务处理)(from {0})\r\n",
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
 /// <param name = "objQxUsersEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxUsersEN objQxUsersEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objQxUsersEN.UserId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxUsersBL.QxUsersDA.UpdateBySql2(objQxUsersEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsersBL.ReFreshCache();

if (clsQxUsersBL.relatedActions != null)
{
clsQxUsersBL.relatedActions.UpdRelaTabDate(objQxUsersEN.UserId, objQxUsersEN.UpdUser);
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
 /// <param name = "objQxUsersEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxUsersEN objQxUsersEN, string strWhereCond)
{
try
{
bool bolResult = clsQxUsersBL.QxUsersDA.UpdateBySqlWithCondition(objQxUsersEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsersBL.ReFreshCache();

if (clsQxUsersBL.relatedActions != null)
{
clsQxUsersBL.relatedActions.UpdRelaTabDate(objQxUsersEN.UserId, objQxUsersEN.UpdUser);
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
 /// <param name = "objQxUsersEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxUsersEN objQxUsersEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsQxUsersBL.QxUsersDA.UpdateBySqlWithConditionTransaction(objQxUsersEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsersBL.ReFreshCache();

if (clsQxUsersBL.relatedActions != null)
{
clsQxUsersBL.relatedActions.UpdRelaTabDate(objQxUsersEN.UserId, objQxUsersEN.UpdUser);
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
 /// <param name = "strUserId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsQxUsersEN objQxUsersEN)
{
try
{
int intRecNum = clsQxUsersBL.QxUsersDA.DelRecord(objQxUsersEN.UserId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsersBL.ReFreshCache();

if (clsQxUsersBL.relatedActions != null)
{
clsQxUsersBL.relatedActions.UpdRelaTabDate(objQxUsersEN.UserId, objQxUsersEN.UpdUser);
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
 /// <param name = "objQxUsersENS">源对象</param>
 /// <param name = "objQxUsersENT">目标对象</param>
 public static void CopyTo(this clsQxUsersEN objQxUsersENS, clsQxUsersEN objQxUsersENT)
{
try
{
objQxUsersENT.UserId = objQxUsersENS.UserId; //用户ID
objQxUsersENT.UserName = objQxUsersENS.UserName; //用户名
objQxUsersENT.DepartmentId = objQxUsersENS.DepartmentId; //部门Id
objQxUsersENT.UserStateId = objQxUsersENS.UserStateId; //用户状态Id
objQxUsersENT.Password = objQxUsersENS.Password; //口令
objQxUsersENT.EffitiveBeginDate = objQxUsersENS.EffitiveBeginDate; //有效开始日期
objQxUsersENT.EffitiveEndDate = objQxUsersENS.EffitiveEndDate; //有效结束日期
objQxUsersENT.StuTeacherId = objQxUsersENS.StuTeacherId; //学工号
objQxUsersENT.IdentityId = objQxUsersENS.IdentityId; //身份编号
objQxUsersENT.IsArchive = objQxUsersENS.IsArchive; //是否存档
objQxUsersENT.OpenId = objQxUsersENS.OpenId; //微信openid
objQxUsersENT.Email = objQxUsersENS.Email; //邮箱
objQxUsersENT.PhoneNumber = objQxUsersENS.PhoneNumber; //电话号码
objQxUsersENT.IsSynch = objQxUsersENS.IsSynch; //是否同步
objQxUsersENT.SynchDate = objQxUsersENS.SynchDate; //同步日期
objQxUsersENT.DetailInfoTab = objQxUsersENS.DetailInfoTab; //详细信息表
objQxUsersENT.IdGradeBase = objQxUsersENS.IdGradeBase; //年级流水号
objQxUsersENT.IdSchool = objQxUsersENS.IdSchool; //学校流水号
objQxUsersENT.IdXzCollege = objQxUsersENS.IdXzCollege; //学院Id
objQxUsersENT.UpdDate = objQxUsersENS.UpdDate; //修改日期
objQxUsersENT.UpdUser = objQxUsersENS.UpdUser; //修改用户
objQxUsersENT.Memo = objQxUsersENS.Memo; //备注
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
 /// <param name = "objQxUsersENS">源对象</param>
 /// <returns>目标对象=>clsQxUsersEN:objQxUsersENT</returns>
 public static clsQxUsersEN CopyTo(this clsQxUsersEN objQxUsersENS)
{
try
{
 clsQxUsersEN objQxUsersENT = new clsQxUsersEN()
{
UserId = objQxUsersENS.UserId, //用户ID
UserName = objQxUsersENS.UserName, //用户名
DepartmentId = objQxUsersENS.DepartmentId, //部门Id
UserStateId = objQxUsersENS.UserStateId, //用户状态Id
Password = objQxUsersENS.Password, //口令
EffitiveBeginDate = objQxUsersENS.EffitiveBeginDate, //有效开始日期
EffitiveEndDate = objQxUsersENS.EffitiveEndDate, //有效结束日期
StuTeacherId = objQxUsersENS.StuTeacherId, //学工号
IdentityId = objQxUsersENS.IdentityId, //身份编号
IsArchive = objQxUsersENS.IsArchive, //是否存档
OpenId = objQxUsersENS.OpenId, //微信openid
Email = objQxUsersENS.Email, //邮箱
PhoneNumber = objQxUsersENS.PhoneNumber, //电话号码
IsSynch = objQxUsersENS.IsSynch, //是否同步
SynchDate = objQxUsersENS.SynchDate, //同步日期
DetailInfoTab = objQxUsersENS.DetailInfoTab, //详细信息表
IdGradeBase = objQxUsersENS.IdGradeBase, //年级流水号
IdSchool = objQxUsersENS.IdSchool, //学校流水号
IdXzCollege = objQxUsersENS.IdXzCollege, //学院Id
UpdDate = objQxUsersENS.UpdDate, //修改日期
UpdUser = objQxUsersENS.UpdUser, //修改用户
Memo = objQxUsersENS.Memo, //备注
};
 return objQxUsersENT;
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
public static void CheckPropertyNew(this clsQxUsersEN objQxUsersEN)
{
 clsQxUsersBL.QxUsersDA.CheckPropertyNew(objQxUsersEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsQxUsersEN objQxUsersEN)
{
 clsQxUsersBL.QxUsersDA.CheckProperty4Condition(objQxUsersEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQxUsersEN objQxUsersCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQxUsersCond.IsUpdated(conQxUsers.UserId) == true)
{
string strComparisonOpUserId = objQxUsersCond.dicFldComparisonOp[conQxUsers.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers.UserId, objQxUsersCond.UserId, strComparisonOpUserId);
}
if (objQxUsersCond.IsUpdated(conQxUsers.UserName) == true)
{
string strComparisonOpUserName = objQxUsersCond.dicFldComparisonOp[conQxUsers.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers.UserName, objQxUsersCond.UserName, strComparisonOpUserName);
}
if (objQxUsersCond.IsUpdated(conQxUsers.DepartmentId) == true)
{
string strComparisonOpDepartmentId = objQxUsersCond.dicFldComparisonOp[conQxUsers.DepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers.DepartmentId, objQxUsersCond.DepartmentId, strComparisonOpDepartmentId);
}
if (objQxUsersCond.IsUpdated(conQxUsers.UserStateId) == true)
{
string strComparisonOpUserStateId = objQxUsersCond.dicFldComparisonOp[conQxUsers.UserStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers.UserStateId, objQxUsersCond.UserStateId, strComparisonOpUserStateId);
}
if (objQxUsersCond.IsUpdated(conQxUsers.Password) == true)
{
string strComparisonOpPassword = objQxUsersCond.dicFldComparisonOp[conQxUsers.Password];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers.Password, objQxUsersCond.Password, strComparisonOpPassword);
}
if (objQxUsersCond.IsUpdated(conQxUsers.EffitiveBeginDate) == true)
{
string strComparisonOpEffitiveBeginDate = objQxUsersCond.dicFldComparisonOp[conQxUsers.EffitiveBeginDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers.EffitiveBeginDate, objQxUsersCond.EffitiveBeginDate, strComparisonOpEffitiveBeginDate);
}
if (objQxUsersCond.IsUpdated(conQxUsers.EffitiveEndDate) == true)
{
string strComparisonOpEffitiveEndDate = objQxUsersCond.dicFldComparisonOp[conQxUsers.EffitiveEndDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers.EffitiveEndDate, objQxUsersCond.EffitiveEndDate, strComparisonOpEffitiveEndDate);
}
if (objQxUsersCond.IsUpdated(conQxUsers.StuTeacherId) == true)
{
string strComparisonOpStuTeacherId = objQxUsersCond.dicFldComparisonOp[conQxUsers.StuTeacherId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers.StuTeacherId, objQxUsersCond.StuTeacherId, strComparisonOpStuTeacherId);
}
if (objQxUsersCond.IsUpdated(conQxUsers.IdentityId) == true)
{
string strComparisonOpIdentityId = objQxUsersCond.dicFldComparisonOp[conQxUsers.IdentityId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers.IdentityId, objQxUsersCond.IdentityId, strComparisonOpIdentityId);
}
if (objQxUsersCond.IsUpdated(conQxUsers.IsArchive) == true)
{
if (objQxUsersCond.IsArchive == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQxUsers.IsArchive);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQxUsers.IsArchive);
}
}
if (objQxUsersCond.IsUpdated(conQxUsers.OpenId) == true)
{
string strComparisonOpOpenId = objQxUsersCond.dicFldComparisonOp[conQxUsers.OpenId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers.OpenId, objQxUsersCond.OpenId, strComparisonOpOpenId);
}
if (objQxUsersCond.IsUpdated(conQxUsers.Email) == true)
{
string strComparisonOpEmail = objQxUsersCond.dicFldComparisonOp[conQxUsers.Email];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers.Email, objQxUsersCond.Email, strComparisonOpEmail);
}
if (objQxUsersCond.IsUpdated(conQxUsers.PhoneNumber) == true)
{
string strComparisonOpPhoneNumber = objQxUsersCond.dicFldComparisonOp[conQxUsers.PhoneNumber];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers.PhoneNumber, objQxUsersCond.PhoneNumber, strComparisonOpPhoneNumber);
}
if (objQxUsersCond.IsUpdated(conQxUsers.IsSynch) == true)
{
if (objQxUsersCond.IsSynch == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQxUsers.IsSynch);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQxUsers.IsSynch);
}
}
if (objQxUsersCond.IsUpdated(conQxUsers.SynchDate) == true)
{
string strComparisonOpSynchDate = objQxUsersCond.dicFldComparisonOp[conQxUsers.SynchDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers.SynchDate, objQxUsersCond.SynchDate, strComparisonOpSynchDate);
}
if (objQxUsersCond.IsUpdated(conQxUsers.DetailInfoTab) == true)
{
string strComparisonOpDetailInfoTab = objQxUsersCond.dicFldComparisonOp[conQxUsers.DetailInfoTab];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers.DetailInfoTab, objQxUsersCond.DetailInfoTab, strComparisonOpDetailInfoTab);
}
if (objQxUsersCond.IsUpdated(conQxUsers.IdGradeBase) == true)
{
string strComparisonOpIdGradeBase = objQxUsersCond.dicFldComparisonOp[conQxUsers.IdGradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers.IdGradeBase, objQxUsersCond.IdGradeBase, strComparisonOpIdGradeBase);
}
if (objQxUsersCond.IsUpdated(conQxUsers.IdSchool) == true)
{
string strComparisonOpIdSchool = objQxUsersCond.dicFldComparisonOp[conQxUsers.IdSchool];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers.IdSchool, objQxUsersCond.IdSchool, strComparisonOpIdSchool);
}
if (objQxUsersCond.IsUpdated(conQxUsers.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objQxUsersCond.dicFldComparisonOp[conQxUsers.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers.IdXzCollege, objQxUsersCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objQxUsersCond.IsUpdated(conQxUsers.UpdDate) == true)
{
string strComparisonOpUpdDate = objQxUsersCond.dicFldComparisonOp[conQxUsers.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers.UpdDate, objQxUsersCond.UpdDate, strComparisonOpUpdDate);
}
if (objQxUsersCond.IsUpdated(conQxUsers.UpdUser) == true)
{
string strComparisonOpUpdUser = objQxUsersCond.dicFldComparisonOp[conQxUsers.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers.UpdUser, objQxUsersCond.UpdUser, strComparisonOpUpdUser);
}
if (objQxUsersCond.IsUpdated(conQxUsers.Memo) == true)
{
string strComparisonOpMemo = objQxUsersCond.dicFldComparisonOp[conQxUsers.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers.Memo, objQxUsersCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_QxUsers
{
public virtual bool UpdRelaTabDate(string strUserId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 用户(QxUsers)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsQxUsersBL
{
public static RelatedActions_QxUsers relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "QxUsersListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "QxUsersList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsQxUsersEN> arrQxUsersObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsQxUsersDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsQxUsersDA QxUsersDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsQxUsersDA();
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
 public clsQxUsersBL()
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
if (string.IsNullOrEmpty(clsQxUsersEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxUsersEN._ConnectString);
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
objDS = QxUsersDA.GetDataSet(strWhereCond);
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
objDS = QxUsersDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = QxUsersDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_QxUsers(string strWhereCond)
{
DataTable objDT;
try
{
objDT = QxUsersDA.GetDataTable_QxUsers(strWhereCond);
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
objDT = QxUsersDA.GetDataTable(strWhereCond);
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
objDT = QxUsersDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = QxUsersDA.GetDataTable(strWhereCond, strTabName);
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
objDT = QxUsersDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = QxUsersDA.GetDataTable_Top(objTopPara);
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
objDT = QxUsersDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = QxUsersDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = QxUsersDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = QxUsersDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = QxUsersDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = QxUsersDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = QxUsersDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = QxUsersDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
 /// <param name = "arrUserIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsQxUsersEN> GetObjLstByUserIdLst(List<string> arrUserIdLst)
{
List<clsQxUsersEN> arrObjLst = new List<clsQxUsersEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrUserIdLst, true);
 string strWhereCond = string.Format("UserId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsersEN objQxUsersEN = new clsQxUsersEN();
try
{
objQxUsersEN.UserId = objRow[conQxUsers.UserId].ToString().Trim(); //用户ID
objQxUsersEN.UserName = objRow[conQxUsers.UserName].ToString().Trim(); //用户名
objQxUsersEN.DepartmentId = objRow[conQxUsers.DepartmentId] == DBNull.Value ? null : objRow[conQxUsers.DepartmentId].ToString().Trim(); //部门Id
objQxUsersEN.UserStateId = objRow[conQxUsers.UserStateId].ToString().Trim(); //用户状态Id
objQxUsersEN.Password = objRow[conQxUsers.Password].ToString().Trim(); //口令
objQxUsersEN.EffitiveBeginDate = objRow[conQxUsers.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objQxUsersEN.EffitiveEndDate = objRow[conQxUsers.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objQxUsersEN.StuTeacherId = objRow[conQxUsers.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsers.StuTeacherId].ToString().Trim(); //学工号
objQxUsersEN.IdentityId = objRow[conQxUsers.IdentityId] == DBNull.Value ? null : objRow[conQxUsers.IdentityId].ToString().Trim(); //身份编号
objQxUsersEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers.IsArchive].ToString().Trim()); //是否存档
objQxUsersEN.OpenId = objRow[conQxUsers.OpenId] == DBNull.Value ? null : objRow[conQxUsers.OpenId].ToString().Trim(); //微信openid
objQxUsersEN.Email = objRow[conQxUsers.Email] == DBNull.Value ? null : objRow[conQxUsers.Email].ToString().Trim(); //邮箱
objQxUsersEN.PhoneNumber = objRow[conQxUsers.PhoneNumber] == DBNull.Value ? null : objRow[conQxUsers.PhoneNumber].ToString().Trim(); //电话号码
objQxUsersEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers.IsSynch].ToString().Trim()); //是否同步
objQxUsersEN.SynchDate = objRow[conQxUsers.SynchDate] == DBNull.Value ? null : objRow[conQxUsers.SynchDate].ToString().Trim(); //同步日期
objQxUsersEN.DetailInfoTab = objRow[conQxUsers.DetailInfoTab] == DBNull.Value ? null : objRow[conQxUsers.DetailInfoTab].ToString().Trim(); //详细信息表
objQxUsersEN.IdGradeBase = objRow[conQxUsers.IdGradeBase] == DBNull.Value ? null : objRow[conQxUsers.IdGradeBase].ToString().Trim(); //年级流水号
objQxUsersEN.IdSchool = objRow[conQxUsers.IdSchool] == DBNull.Value ? null : objRow[conQxUsers.IdSchool].ToString().Trim(); //学校流水号
objQxUsersEN.IdXzCollege = objRow[conQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[conQxUsers.IdXzCollege].ToString().Trim(); //学院Id
objQxUsersEN.UpdDate = objRow[conQxUsers.UpdDate] == DBNull.Value ? null : objRow[conQxUsers.UpdDate].ToString().Trim(); //修改日期
objQxUsersEN.UpdUser = objRow[conQxUsers.UpdUser] == DBNull.Value ? null : objRow[conQxUsers.UpdUser].ToString().Trim(); //修改用户
objQxUsersEN.Memo = objRow[conQxUsers.Memo] == DBNull.Value ? null : objRow[conQxUsers.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUsersEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrUserIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsQxUsersEN> GetObjLstByUserIdLstCache(List<string> arrUserIdLst)
{
string strKey = string.Format("{0}", clsQxUsersEN._CurrTabName);
List<clsQxUsersEN> arrQxUsersObjLstCache = GetObjLstCache();
IEnumerable <clsQxUsersEN> arrQxUsersObjLst_Sel =
arrQxUsersObjLstCache
.Where(x => arrUserIdLst.Contains(x.UserId));
return arrQxUsersObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUsersEN> GetObjLst(string strWhereCond)
{
List<clsQxUsersEN> arrObjLst = new List<clsQxUsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsersEN objQxUsersEN = new clsQxUsersEN();
try
{
objQxUsersEN.UserId = objRow[conQxUsers.UserId].ToString().Trim(); //用户ID
objQxUsersEN.UserName = objRow[conQxUsers.UserName].ToString().Trim(); //用户名
objQxUsersEN.DepartmentId = objRow[conQxUsers.DepartmentId] == DBNull.Value ? null : objRow[conQxUsers.DepartmentId].ToString().Trim(); //部门Id
objQxUsersEN.UserStateId = objRow[conQxUsers.UserStateId].ToString().Trim(); //用户状态Id
objQxUsersEN.Password = objRow[conQxUsers.Password].ToString().Trim(); //口令
objQxUsersEN.EffitiveBeginDate = objRow[conQxUsers.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objQxUsersEN.EffitiveEndDate = objRow[conQxUsers.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objQxUsersEN.StuTeacherId = objRow[conQxUsers.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsers.StuTeacherId].ToString().Trim(); //学工号
objQxUsersEN.IdentityId = objRow[conQxUsers.IdentityId] == DBNull.Value ? null : objRow[conQxUsers.IdentityId].ToString().Trim(); //身份编号
objQxUsersEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers.IsArchive].ToString().Trim()); //是否存档
objQxUsersEN.OpenId = objRow[conQxUsers.OpenId] == DBNull.Value ? null : objRow[conQxUsers.OpenId].ToString().Trim(); //微信openid
objQxUsersEN.Email = objRow[conQxUsers.Email] == DBNull.Value ? null : objRow[conQxUsers.Email].ToString().Trim(); //邮箱
objQxUsersEN.PhoneNumber = objRow[conQxUsers.PhoneNumber] == DBNull.Value ? null : objRow[conQxUsers.PhoneNumber].ToString().Trim(); //电话号码
objQxUsersEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers.IsSynch].ToString().Trim()); //是否同步
objQxUsersEN.SynchDate = objRow[conQxUsers.SynchDate] == DBNull.Value ? null : objRow[conQxUsers.SynchDate].ToString().Trim(); //同步日期
objQxUsersEN.DetailInfoTab = objRow[conQxUsers.DetailInfoTab] == DBNull.Value ? null : objRow[conQxUsers.DetailInfoTab].ToString().Trim(); //详细信息表
objQxUsersEN.IdGradeBase = objRow[conQxUsers.IdGradeBase] == DBNull.Value ? null : objRow[conQxUsers.IdGradeBase].ToString().Trim(); //年级流水号
objQxUsersEN.IdSchool = objRow[conQxUsers.IdSchool] == DBNull.Value ? null : objRow[conQxUsers.IdSchool].ToString().Trim(); //学校流水号
objQxUsersEN.IdXzCollege = objRow[conQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[conQxUsers.IdXzCollege].ToString().Trim(); //学院Id
objQxUsersEN.UpdDate = objRow[conQxUsers.UpdDate] == DBNull.Value ? null : objRow[conQxUsers.UpdDate].ToString().Trim(); //修改日期
objQxUsersEN.UpdUser = objRow[conQxUsers.UpdUser] == DBNull.Value ? null : objRow[conQxUsers.UpdUser].ToString().Trim(); //修改用户
objQxUsersEN.Memo = objRow[conQxUsers.Memo] == DBNull.Value ? null : objRow[conQxUsers.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUsersEN);
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
public static List<clsQxUsersEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsQxUsersEN> arrObjLst = new List<clsQxUsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsersEN objQxUsersEN = new clsQxUsersEN();
try
{
objQxUsersEN.UserId = objRow[conQxUsers.UserId].ToString().Trim(); //用户ID
objQxUsersEN.UserName = objRow[conQxUsers.UserName].ToString().Trim(); //用户名
objQxUsersEN.DepartmentId = objRow[conQxUsers.DepartmentId] == DBNull.Value ? null : objRow[conQxUsers.DepartmentId].ToString().Trim(); //部门Id
objQxUsersEN.UserStateId = objRow[conQxUsers.UserStateId].ToString().Trim(); //用户状态Id
objQxUsersEN.Password = objRow[conQxUsers.Password].ToString().Trim(); //口令
objQxUsersEN.EffitiveBeginDate = objRow[conQxUsers.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objQxUsersEN.EffitiveEndDate = objRow[conQxUsers.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objQxUsersEN.StuTeacherId = objRow[conQxUsers.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsers.StuTeacherId].ToString().Trim(); //学工号
objQxUsersEN.IdentityId = objRow[conQxUsers.IdentityId] == DBNull.Value ? null : objRow[conQxUsers.IdentityId].ToString().Trim(); //身份编号
objQxUsersEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers.IsArchive].ToString().Trim()); //是否存档
objQxUsersEN.OpenId = objRow[conQxUsers.OpenId] == DBNull.Value ? null : objRow[conQxUsers.OpenId].ToString().Trim(); //微信openid
objQxUsersEN.Email = objRow[conQxUsers.Email] == DBNull.Value ? null : objRow[conQxUsers.Email].ToString().Trim(); //邮箱
objQxUsersEN.PhoneNumber = objRow[conQxUsers.PhoneNumber] == DBNull.Value ? null : objRow[conQxUsers.PhoneNumber].ToString().Trim(); //电话号码
objQxUsersEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers.IsSynch].ToString().Trim()); //是否同步
objQxUsersEN.SynchDate = objRow[conQxUsers.SynchDate] == DBNull.Value ? null : objRow[conQxUsers.SynchDate].ToString().Trim(); //同步日期
objQxUsersEN.DetailInfoTab = objRow[conQxUsers.DetailInfoTab] == DBNull.Value ? null : objRow[conQxUsers.DetailInfoTab].ToString().Trim(); //详细信息表
objQxUsersEN.IdGradeBase = objRow[conQxUsers.IdGradeBase] == DBNull.Value ? null : objRow[conQxUsers.IdGradeBase].ToString().Trim(); //年级流水号
objQxUsersEN.IdSchool = objRow[conQxUsers.IdSchool] == DBNull.Value ? null : objRow[conQxUsers.IdSchool].ToString().Trim(); //学校流水号
objQxUsersEN.IdXzCollege = objRow[conQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[conQxUsers.IdXzCollege].ToString().Trim(); //学院Id
objQxUsersEN.UpdDate = objRow[conQxUsers.UpdDate] == DBNull.Value ? null : objRow[conQxUsers.UpdDate].ToString().Trim(); //修改日期
objQxUsersEN.UpdUser = objRow[conQxUsers.UpdUser] == DBNull.Value ? null : objRow[conQxUsers.UpdUser].ToString().Trim(); //修改用户
objQxUsersEN.Memo = objRow[conQxUsers.Memo] == DBNull.Value ? null : objRow[conQxUsers.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUsersEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objQxUsersCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsQxUsersEN> GetSubObjLstCache(clsQxUsersEN objQxUsersCond)
{
List<clsQxUsersEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxUsersEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxUsers.AttributeName)
{
if (objQxUsersCond.IsUpdated(strFldName) == false) continue;
if (objQxUsersCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUsersCond[strFldName].ToString());
}
else
{
if (objQxUsersCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxUsersCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUsersCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxUsersCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxUsersCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxUsersCond[strFldName]));
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
public static List<clsQxUsersEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsQxUsersEN> arrObjLst = new List<clsQxUsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsersEN objQxUsersEN = new clsQxUsersEN();
try
{
objQxUsersEN.UserId = objRow[conQxUsers.UserId].ToString().Trim(); //用户ID
objQxUsersEN.UserName = objRow[conQxUsers.UserName].ToString().Trim(); //用户名
objQxUsersEN.DepartmentId = objRow[conQxUsers.DepartmentId] == DBNull.Value ? null : objRow[conQxUsers.DepartmentId].ToString().Trim(); //部门Id
objQxUsersEN.UserStateId = objRow[conQxUsers.UserStateId].ToString().Trim(); //用户状态Id
objQxUsersEN.Password = objRow[conQxUsers.Password].ToString().Trim(); //口令
objQxUsersEN.EffitiveBeginDate = objRow[conQxUsers.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objQxUsersEN.EffitiveEndDate = objRow[conQxUsers.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objQxUsersEN.StuTeacherId = objRow[conQxUsers.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsers.StuTeacherId].ToString().Trim(); //学工号
objQxUsersEN.IdentityId = objRow[conQxUsers.IdentityId] == DBNull.Value ? null : objRow[conQxUsers.IdentityId].ToString().Trim(); //身份编号
objQxUsersEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers.IsArchive].ToString().Trim()); //是否存档
objQxUsersEN.OpenId = objRow[conQxUsers.OpenId] == DBNull.Value ? null : objRow[conQxUsers.OpenId].ToString().Trim(); //微信openid
objQxUsersEN.Email = objRow[conQxUsers.Email] == DBNull.Value ? null : objRow[conQxUsers.Email].ToString().Trim(); //邮箱
objQxUsersEN.PhoneNumber = objRow[conQxUsers.PhoneNumber] == DBNull.Value ? null : objRow[conQxUsers.PhoneNumber].ToString().Trim(); //电话号码
objQxUsersEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers.IsSynch].ToString().Trim()); //是否同步
objQxUsersEN.SynchDate = objRow[conQxUsers.SynchDate] == DBNull.Value ? null : objRow[conQxUsers.SynchDate].ToString().Trim(); //同步日期
objQxUsersEN.DetailInfoTab = objRow[conQxUsers.DetailInfoTab] == DBNull.Value ? null : objRow[conQxUsers.DetailInfoTab].ToString().Trim(); //详细信息表
objQxUsersEN.IdGradeBase = objRow[conQxUsers.IdGradeBase] == DBNull.Value ? null : objRow[conQxUsers.IdGradeBase].ToString().Trim(); //年级流水号
objQxUsersEN.IdSchool = objRow[conQxUsers.IdSchool] == DBNull.Value ? null : objRow[conQxUsers.IdSchool].ToString().Trim(); //学校流水号
objQxUsersEN.IdXzCollege = objRow[conQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[conQxUsers.IdXzCollege].ToString().Trim(); //学院Id
objQxUsersEN.UpdDate = objRow[conQxUsers.UpdDate] == DBNull.Value ? null : objRow[conQxUsers.UpdDate].ToString().Trim(); //修改日期
objQxUsersEN.UpdUser = objRow[conQxUsers.UpdUser] == DBNull.Value ? null : objRow[conQxUsers.UpdUser].ToString().Trim(); //修改用户
objQxUsersEN.Memo = objRow[conQxUsers.Memo] == DBNull.Value ? null : objRow[conQxUsers.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUsersEN);
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
public static List<clsQxUsersEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsQxUsersEN> arrObjLst = new List<clsQxUsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsersEN objQxUsersEN = new clsQxUsersEN();
try
{
objQxUsersEN.UserId = objRow[conQxUsers.UserId].ToString().Trim(); //用户ID
objQxUsersEN.UserName = objRow[conQxUsers.UserName].ToString().Trim(); //用户名
objQxUsersEN.DepartmentId = objRow[conQxUsers.DepartmentId] == DBNull.Value ? null : objRow[conQxUsers.DepartmentId].ToString().Trim(); //部门Id
objQxUsersEN.UserStateId = objRow[conQxUsers.UserStateId].ToString().Trim(); //用户状态Id
objQxUsersEN.Password = objRow[conQxUsers.Password].ToString().Trim(); //口令
objQxUsersEN.EffitiveBeginDate = objRow[conQxUsers.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objQxUsersEN.EffitiveEndDate = objRow[conQxUsers.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objQxUsersEN.StuTeacherId = objRow[conQxUsers.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsers.StuTeacherId].ToString().Trim(); //学工号
objQxUsersEN.IdentityId = objRow[conQxUsers.IdentityId] == DBNull.Value ? null : objRow[conQxUsers.IdentityId].ToString().Trim(); //身份编号
objQxUsersEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers.IsArchive].ToString().Trim()); //是否存档
objQxUsersEN.OpenId = objRow[conQxUsers.OpenId] == DBNull.Value ? null : objRow[conQxUsers.OpenId].ToString().Trim(); //微信openid
objQxUsersEN.Email = objRow[conQxUsers.Email] == DBNull.Value ? null : objRow[conQxUsers.Email].ToString().Trim(); //邮箱
objQxUsersEN.PhoneNumber = objRow[conQxUsers.PhoneNumber] == DBNull.Value ? null : objRow[conQxUsers.PhoneNumber].ToString().Trim(); //电话号码
objQxUsersEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers.IsSynch].ToString().Trim()); //是否同步
objQxUsersEN.SynchDate = objRow[conQxUsers.SynchDate] == DBNull.Value ? null : objRow[conQxUsers.SynchDate].ToString().Trim(); //同步日期
objQxUsersEN.DetailInfoTab = objRow[conQxUsers.DetailInfoTab] == DBNull.Value ? null : objRow[conQxUsers.DetailInfoTab].ToString().Trim(); //详细信息表
objQxUsersEN.IdGradeBase = objRow[conQxUsers.IdGradeBase] == DBNull.Value ? null : objRow[conQxUsers.IdGradeBase].ToString().Trim(); //年级流水号
objQxUsersEN.IdSchool = objRow[conQxUsers.IdSchool] == DBNull.Value ? null : objRow[conQxUsers.IdSchool].ToString().Trim(); //学校流水号
objQxUsersEN.IdXzCollege = objRow[conQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[conQxUsers.IdXzCollege].ToString().Trim(); //学院Id
objQxUsersEN.UpdDate = objRow[conQxUsers.UpdDate] == DBNull.Value ? null : objRow[conQxUsers.UpdDate].ToString().Trim(); //修改日期
objQxUsersEN.UpdUser = objRow[conQxUsers.UpdUser] == DBNull.Value ? null : objRow[conQxUsers.UpdUser].ToString().Trim(); //修改用户
objQxUsersEN.Memo = objRow[conQxUsers.Memo] == DBNull.Value ? null : objRow[conQxUsers.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUsersEN);
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
List<clsQxUsersEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsQxUsersEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUsersEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsQxUsersEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsQxUsersEN> arrObjLst = new List<clsQxUsersEN>(); 
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
	clsQxUsersEN objQxUsersEN = new clsQxUsersEN();
try
{
objQxUsersEN.UserId = objRow[conQxUsers.UserId].ToString().Trim(); //用户ID
objQxUsersEN.UserName = objRow[conQxUsers.UserName].ToString().Trim(); //用户名
objQxUsersEN.DepartmentId = objRow[conQxUsers.DepartmentId] == DBNull.Value ? null : objRow[conQxUsers.DepartmentId].ToString().Trim(); //部门Id
objQxUsersEN.UserStateId = objRow[conQxUsers.UserStateId].ToString().Trim(); //用户状态Id
objQxUsersEN.Password = objRow[conQxUsers.Password].ToString().Trim(); //口令
objQxUsersEN.EffitiveBeginDate = objRow[conQxUsers.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objQxUsersEN.EffitiveEndDate = objRow[conQxUsers.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objQxUsersEN.StuTeacherId = objRow[conQxUsers.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsers.StuTeacherId].ToString().Trim(); //学工号
objQxUsersEN.IdentityId = objRow[conQxUsers.IdentityId] == DBNull.Value ? null : objRow[conQxUsers.IdentityId].ToString().Trim(); //身份编号
objQxUsersEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers.IsArchive].ToString().Trim()); //是否存档
objQxUsersEN.OpenId = objRow[conQxUsers.OpenId] == DBNull.Value ? null : objRow[conQxUsers.OpenId].ToString().Trim(); //微信openid
objQxUsersEN.Email = objRow[conQxUsers.Email] == DBNull.Value ? null : objRow[conQxUsers.Email].ToString().Trim(); //邮箱
objQxUsersEN.PhoneNumber = objRow[conQxUsers.PhoneNumber] == DBNull.Value ? null : objRow[conQxUsers.PhoneNumber].ToString().Trim(); //电话号码
objQxUsersEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers.IsSynch].ToString().Trim()); //是否同步
objQxUsersEN.SynchDate = objRow[conQxUsers.SynchDate] == DBNull.Value ? null : objRow[conQxUsers.SynchDate].ToString().Trim(); //同步日期
objQxUsersEN.DetailInfoTab = objRow[conQxUsers.DetailInfoTab] == DBNull.Value ? null : objRow[conQxUsers.DetailInfoTab].ToString().Trim(); //详细信息表
objQxUsersEN.IdGradeBase = objRow[conQxUsers.IdGradeBase] == DBNull.Value ? null : objRow[conQxUsers.IdGradeBase].ToString().Trim(); //年级流水号
objQxUsersEN.IdSchool = objRow[conQxUsers.IdSchool] == DBNull.Value ? null : objRow[conQxUsers.IdSchool].ToString().Trim(); //学校流水号
objQxUsersEN.IdXzCollege = objRow[conQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[conQxUsers.IdXzCollege].ToString().Trim(); //学院Id
objQxUsersEN.UpdDate = objRow[conQxUsers.UpdDate] == DBNull.Value ? null : objRow[conQxUsers.UpdDate].ToString().Trim(); //修改日期
objQxUsersEN.UpdUser = objRow[conQxUsers.UpdUser] == DBNull.Value ? null : objRow[conQxUsers.UpdUser].ToString().Trim(); //修改用户
objQxUsersEN.Memo = objRow[conQxUsers.Memo] == DBNull.Value ? null : objRow[conQxUsers.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUsersEN);
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
public static List<clsQxUsersEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsQxUsersEN> arrObjLst = new List<clsQxUsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsersEN objQxUsersEN = new clsQxUsersEN();
try
{
objQxUsersEN.UserId = objRow[conQxUsers.UserId].ToString().Trim(); //用户ID
objQxUsersEN.UserName = objRow[conQxUsers.UserName].ToString().Trim(); //用户名
objQxUsersEN.DepartmentId = objRow[conQxUsers.DepartmentId] == DBNull.Value ? null : objRow[conQxUsers.DepartmentId].ToString().Trim(); //部门Id
objQxUsersEN.UserStateId = objRow[conQxUsers.UserStateId].ToString().Trim(); //用户状态Id
objQxUsersEN.Password = objRow[conQxUsers.Password].ToString().Trim(); //口令
objQxUsersEN.EffitiveBeginDate = objRow[conQxUsers.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objQxUsersEN.EffitiveEndDate = objRow[conQxUsers.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objQxUsersEN.StuTeacherId = objRow[conQxUsers.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsers.StuTeacherId].ToString().Trim(); //学工号
objQxUsersEN.IdentityId = objRow[conQxUsers.IdentityId] == DBNull.Value ? null : objRow[conQxUsers.IdentityId].ToString().Trim(); //身份编号
objQxUsersEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers.IsArchive].ToString().Trim()); //是否存档
objQxUsersEN.OpenId = objRow[conQxUsers.OpenId] == DBNull.Value ? null : objRow[conQxUsers.OpenId].ToString().Trim(); //微信openid
objQxUsersEN.Email = objRow[conQxUsers.Email] == DBNull.Value ? null : objRow[conQxUsers.Email].ToString().Trim(); //邮箱
objQxUsersEN.PhoneNumber = objRow[conQxUsers.PhoneNumber] == DBNull.Value ? null : objRow[conQxUsers.PhoneNumber].ToString().Trim(); //电话号码
objQxUsersEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers.IsSynch].ToString().Trim()); //是否同步
objQxUsersEN.SynchDate = objRow[conQxUsers.SynchDate] == DBNull.Value ? null : objRow[conQxUsers.SynchDate].ToString().Trim(); //同步日期
objQxUsersEN.DetailInfoTab = objRow[conQxUsers.DetailInfoTab] == DBNull.Value ? null : objRow[conQxUsers.DetailInfoTab].ToString().Trim(); //详细信息表
objQxUsersEN.IdGradeBase = objRow[conQxUsers.IdGradeBase] == DBNull.Value ? null : objRow[conQxUsers.IdGradeBase].ToString().Trim(); //年级流水号
objQxUsersEN.IdSchool = objRow[conQxUsers.IdSchool] == DBNull.Value ? null : objRow[conQxUsers.IdSchool].ToString().Trim(); //学校流水号
objQxUsersEN.IdXzCollege = objRow[conQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[conQxUsers.IdXzCollege].ToString().Trim(); //学院Id
objQxUsersEN.UpdDate = objRow[conQxUsers.UpdDate] == DBNull.Value ? null : objRow[conQxUsers.UpdDate].ToString().Trim(); //修改日期
objQxUsersEN.UpdUser = objRow[conQxUsers.UpdUser] == DBNull.Value ? null : objRow[conQxUsers.UpdUser].ToString().Trim(); //修改用户
objQxUsersEN.Memo = objRow[conQxUsers.Memo] == DBNull.Value ? null : objRow[conQxUsers.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUsersEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsQxUsersEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsQxUsersEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsQxUsersEN> arrObjLst = new List<clsQxUsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsersEN objQxUsersEN = new clsQxUsersEN();
try
{
objQxUsersEN.UserId = objRow[conQxUsers.UserId].ToString().Trim(); //用户ID
objQxUsersEN.UserName = objRow[conQxUsers.UserName].ToString().Trim(); //用户名
objQxUsersEN.DepartmentId = objRow[conQxUsers.DepartmentId] == DBNull.Value ? null : objRow[conQxUsers.DepartmentId].ToString().Trim(); //部门Id
objQxUsersEN.UserStateId = objRow[conQxUsers.UserStateId].ToString().Trim(); //用户状态Id
objQxUsersEN.Password = objRow[conQxUsers.Password].ToString().Trim(); //口令
objQxUsersEN.EffitiveBeginDate = objRow[conQxUsers.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objQxUsersEN.EffitiveEndDate = objRow[conQxUsers.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objQxUsersEN.StuTeacherId = objRow[conQxUsers.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsers.StuTeacherId].ToString().Trim(); //学工号
objQxUsersEN.IdentityId = objRow[conQxUsers.IdentityId] == DBNull.Value ? null : objRow[conQxUsers.IdentityId].ToString().Trim(); //身份编号
objQxUsersEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers.IsArchive].ToString().Trim()); //是否存档
objQxUsersEN.OpenId = objRow[conQxUsers.OpenId] == DBNull.Value ? null : objRow[conQxUsers.OpenId].ToString().Trim(); //微信openid
objQxUsersEN.Email = objRow[conQxUsers.Email] == DBNull.Value ? null : objRow[conQxUsers.Email].ToString().Trim(); //邮箱
objQxUsersEN.PhoneNumber = objRow[conQxUsers.PhoneNumber] == DBNull.Value ? null : objRow[conQxUsers.PhoneNumber].ToString().Trim(); //电话号码
objQxUsersEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers.IsSynch].ToString().Trim()); //是否同步
objQxUsersEN.SynchDate = objRow[conQxUsers.SynchDate] == DBNull.Value ? null : objRow[conQxUsers.SynchDate].ToString().Trim(); //同步日期
objQxUsersEN.DetailInfoTab = objRow[conQxUsers.DetailInfoTab] == DBNull.Value ? null : objRow[conQxUsers.DetailInfoTab].ToString().Trim(); //详细信息表
objQxUsersEN.IdGradeBase = objRow[conQxUsers.IdGradeBase] == DBNull.Value ? null : objRow[conQxUsers.IdGradeBase].ToString().Trim(); //年级流水号
objQxUsersEN.IdSchool = objRow[conQxUsers.IdSchool] == DBNull.Value ? null : objRow[conQxUsers.IdSchool].ToString().Trim(); //学校流水号
objQxUsersEN.IdXzCollege = objRow[conQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[conQxUsers.IdXzCollege].ToString().Trim(); //学院Id
objQxUsersEN.UpdDate = objRow[conQxUsers.UpdDate] == DBNull.Value ? null : objRow[conQxUsers.UpdDate].ToString().Trim(); //修改日期
objQxUsersEN.UpdUser = objRow[conQxUsers.UpdUser] == DBNull.Value ? null : objRow[conQxUsers.UpdUser].ToString().Trim(); //修改用户
objQxUsersEN.Memo = objRow[conQxUsers.Memo] == DBNull.Value ? null : objRow[conQxUsers.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUsersEN);
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
public static List<clsQxUsersEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsQxUsersEN> arrObjLst = new List<clsQxUsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsersEN objQxUsersEN = new clsQxUsersEN();
try
{
objQxUsersEN.UserId = objRow[conQxUsers.UserId].ToString().Trim(); //用户ID
objQxUsersEN.UserName = objRow[conQxUsers.UserName].ToString().Trim(); //用户名
objQxUsersEN.DepartmentId = objRow[conQxUsers.DepartmentId] == DBNull.Value ? null : objRow[conQxUsers.DepartmentId].ToString().Trim(); //部门Id
objQxUsersEN.UserStateId = objRow[conQxUsers.UserStateId].ToString().Trim(); //用户状态Id
objQxUsersEN.Password = objRow[conQxUsers.Password].ToString().Trim(); //口令
objQxUsersEN.EffitiveBeginDate = objRow[conQxUsers.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objQxUsersEN.EffitiveEndDate = objRow[conQxUsers.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objQxUsersEN.StuTeacherId = objRow[conQxUsers.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsers.StuTeacherId].ToString().Trim(); //学工号
objQxUsersEN.IdentityId = objRow[conQxUsers.IdentityId] == DBNull.Value ? null : objRow[conQxUsers.IdentityId].ToString().Trim(); //身份编号
objQxUsersEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers.IsArchive].ToString().Trim()); //是否存档
objQxUsersEN.OpenId = objRow[conQxUsers.OpenId] == DBNull.Value ? null : objRow[conQxUsers.OpenId].ToString().Trim(); //微信openid
objQxUsersEN.Email = objRow[conQxUsers.Email] == DBNull.Value ? null : objRow[conQxUsers.Email].ToString().Trim(); //邮箱
objQxUsersEN.PhoneNumber = objRow[conQxUsers.PhoneNumber] == DBNull.Value ? null : objRow[conQxUsers.PhoneNumber].ToString().Trim(); //电话号码
objQxUsersEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers.IsSynch].ToString().Trim()); //是否同步
objQxUsersEN.SynchDate = objRow[conQxUsers.SynchDate] == DBNull.Value ? null : objRow[conQxUsers.SynchDate].ToString().Trim(); //同步日期
objQxUsersEN.DetailInfoTab = objRow[conQxUsers.DetailInfoTab] == DBNull.Value ? null : objRow[conQxUsers.DetailInfoTab].ToString().Trim(); //详细信息表
objQxUsersEN.IdGradeBase = objRow[conQxUsers.IdGradeBase] == DBNull.Value ? null : objRow[conQxUsers.IdGradeBase].ToString().Trim(); //年级流水号
objQxUsersEN.IdSchool = objRow[conQxUsers.IdSchool] == DBNull.Value ? null : objRow[conQxUsers.IdSchool].ToString().Trim(); //学校流水号
objQxUsersEN.IdXzCollege = objRow[conQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[conQxUsers.IdXzCollege].ToString().Trim(); //学院Id
objQxUsersEN.UpdDate = objRow[conQxUsers.UpdDate] == DBNull.Value ? null : objRow[conQxUsers.UpdDate].ToString().Trim(); //修改日期
objQxUsersEN.UpdUser = objRow[conQxUsers.UpdUser] == DBNull.Value ? null : objRow[conQxUsers.UpdUser].ToString().Trim(); //修改用户
objQxUsersEN.Memo = objRow[conQxUsers.Memo] == DBNull.Value ? null : objRow[conQxUsers.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUsersEN);
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
public static IEnumerable<clsQxUsersEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsQxUsersEN objQxUsersCond, string strOrderBy)
{
List<clsQxUsersEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxUsersEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxUsers.AttributeName)
{
if (objQxUsersCond.IsUpdated(strFldName) == false) continue;
if (objQxUsersCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUsersCond[strFldName].ToString());
}
else
{
if (objQxUsersCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxUsersCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUsersCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxUsersCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxUsersCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxUsersCond[strFldName]));
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
public static IEnumerable<clsQxUsersEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsQxUsersEN objQxUsersCond = JsonConvert.DeserializeObject<clsQxUsersEN>(objPagerPara.whereCond);
if (objQxUsersCond.sfFldComparisonOp == null)
{
objQxUsersCond.dicFldComparisonOp = null;
}
else
{
objQxUsersCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objQxUsersCond.sfFldComparisonOp);
}
clsQxUsersBL.SetUpdFlag(objQxUsersCond);
 try
{
CheckProperty4Condition(objQxUsersCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsQxUsersBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objQxUsersCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUsersEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsQxUsersEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsQxUsersEN> arrObjLst = new List<clsQxUsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsersEN objQxUsersEN = new clsQxUsersEN();
try
{
objQxUsersEN.UserId = objRow[conQxUsers.UserId].ToString().Trim(); //用户ID
objQxUsersEN.UserName = objRow[conQxUsers.UserName].ToString().Trim(); //用户名
objQxUsersEN.DepartmentId = objRow[conQxUsers.DepartmentId] == DBNull.Value ? null : objRow[conQxUsers.DepartmentId].ToString().Trim(); //部门Id
objQxUsersEN.UserStateId = objRow[conQxUsers.UserStateId].ToString().Trim(); //用户状态Id
objQxUsersEN.Password = objRow[conQxUsers.Password].ToString().Trim(); //口令
objQxUsersEN.EffitiveBeginDate = objRow[conQxUsers.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objQxUsersEN.EffitiveEndDate = objRow[conQxUsers.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objQxUsersEN.StuTeacherId = objRow[conQxUsers.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsers.StuTeacherId].ToString().Trim(); //学工号
objQxUsersEN.IdentityId = objRow[conQxUsers.IdentityId] == DBNull.Value ? null : objRow[conQxUsers.IdentityId].ToString().Trim(); //身份编号
objQxUsersEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers.IsArchive].ToString().Trim()); //是否存档
objQxUsersEN.OpenId = objRow[conQxUsers.OpenId] == DBNull.Value ? null : objRow[conQxUsers.OpenId].ToString().Trim(); //微信openid
objQxUsersEN.Email = objRow[conQxUsers.Email] == DBNull.Value ? null : objRow[conQxUsers.Email].ToString().Trim(); //邮箱
objQxUsersEN.PhoneNumber = objRow[conQxUsers.PhoneNumber] == DBNull.Value ? null : objRow[conQxUsers.PhoneNumber].ToString().Trim(); //电话号码
objQxUsersEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers.IsSynch].ToString().Trim()); //是否同步
objQxUsersEN.SynchDate = objRow[conQxUsers.SynchDate] == DBNull.Value ? null : objRow[conQxUsers.SynchDate].ToString().Trim(); //同步日期
objQxUsersEN.DetailInfoTab = objRow[conQxUsers.DetailInfoTab] == DBNull.Value ? null : objRow[conQxUsers.DetailInfoTab].ToString().Trim(); //详细信息表
objQxUsersEN.IdGradeBase = objRow[conQxUsers.IdGradeBase] == DBNull.Value ? null : objRow[conQxUsers.IdGradeBase].ToString().Trim(); //年级流水号
objQxUsersEN.IdSchool = objRow[conQxUsers.IdSchool] == DBNull.Value ? null : objRow[conQxUsers.IdSchool].ToString().Trim(); //学校流水号
objQxUsersEN.IdXzCollege = objRow[conQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[conQxUsers.IdXzCollege].ToString().Trim(); //学院Id
objQxUsersEN.UpdDate = objRow[conQxUsers.UpdDate] == DBNull.Value ? null : objRow[conQxUsers.UpdDate].ToString().Trim(); //修改日期
objQxUsersEN.UpdUser = objRow[conQxUsers.UpdUser] == DBNull.Value ? null : objRow[conQxUsers.UpdUser].ToString().Trim(); //修改用户
objQxUsersEN.Memo = objRow[conQxUsers.Memo] == DBNull.Value ? null : objRow[conQxUsers.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUsersEN);
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
public static List<clsQxUsersEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsQxUsersEN> arrObjLst = new List<clsQxUsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsersEN objQxUsersEN = new clsQxUsersEN();
try
{
objQxUsersEN.UserId = objRow[conQxUsers.UserId].ToString().Trim(); //用户ID
objQxUsersEN.UserName = objRow[conQxUsers.UserName].ToString().Trim(); //用户名
objQxUsersEN.DepartmentId = objRow[conQxUsers.DepartmentId] == DBNull.Value ? null : objRow[conQxUsers.DepartmentId].ToString().Trim(); //部门Id
objQxUsersEN.UserStateId = objRow[conQxUsers.UserStateId].ToString().Trim(); //用户状态Id
objQxUsersEN.Password = objRow[conQxUsers.Password].ToString().Trim(); //口令
objQxUsersEN.EffitiveBeginDate = objRow[conQxUsers.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objQxUsersEN.EffitiveEndDate = objRow[conQxUsers.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objQxUsersEN.StuTeacherId = objRow[conQxUsers.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsers.StuTeacherId].ToString().Trim(); //学工号
objQxUsersEN.IdentityId = objRow[conQxUsers.IdentityId] == DBNull.Value ? null : objRow[conQxUsers.IdentityId].ToString().Trim(); //身份编号
objQxUsersEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers.IsArchive].ToString().Trim()); //是否存档
objQxUsersEN.OpenId = objRow[conQxUsers.OpenId] == DBNull.Value ? null : objRow[conQxUsers.OpenId].ToString().Trim(); //微信openid
objQxUsersEN.Email = objRow[conQxUsers.Email] == DBNull.Value ? null : objRow[conQxUsers.Email].ToString().Trim(); //邮箱
objQxUsersEN.PhoneNumber = objRow[conQxUsers.PhoneNumber] == DBNull.Value ? null : objRow[conQxUsers.PhoneNumber].ToString().Trim(); //电话号码
objQxUsersEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers.IsSynch].ToString().Trim()); //是否同步
objQxUsersEN.SynchDate = objRow[conQxUsers.SynchDate] == DBNull.Value ? null : objRow[conQxUsers.SynchDate].ToString().Trim(); //同步日期
objQxUsersEN.DetailInfoTab = objRow[conQxUsers.DetailInfoTab] == DBNull.Value ? null : objRow[conQxUsers.DetailInfoTab].ToString().Trim(); //详细信息表
objQxUsersEN.IdGradeBase = objRow[conQxUsers.IdGradeBase] == DBNull.Value ? null : objRow[conQxUsers.IdGradeBase].ToString().Trim(); //年级流水号
objQxUsersEN.IdSchool = objRow[conQxUsers.IdSchool] == DBNull.Value ? null : objRow[conQxUsers.IdSchool].ToString().Trim(); //学校流水号
objQxUsersEN.IdXzCollege = objRow[conQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[conQxUsers.IdXzCollege].ToString().Trim(); //学院Id
objQxUsersEN.UpdDate = objRow[conQxUsers.UpdDate] == DBNull.Value ? null : objRow[conQxUsers.UpdDate].ToString().Trim(); //修改日期
objQxUsersEN.UpdUser = objRow[conQxUsers.UpdUser] == DBNull.Value ? null : objRow[conQxUsers.UpdUser].ToString().Trim(); //修改用户
objQxUsersEN.Memo = objRow[conQxUsers.Memo] == DBNull.Value ? null : objRow[conQxUsers.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUsersEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUsersEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsQxUsersEN> arrObjLst = new List<clsQxUsersEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsersEN objQxUsersEN = new clsQxUsersEN();
try
{
objQxUsersEN.UserId = objRow[conQxUsers.UserId].ToString().Trim(); //用户ID
objQxUsersEN.UserName = objRow[conQxUsers.UserName].ToString().Trim(); //用户名
objQxUsersEN.DepartmentId = objRow[conQxUsers.DepartmentId] == DBNull.Value ? null : objRow[conQxUsers.DepartmentId].ToString().Trim(); //部门Id
objQxUsersEN.UserStateId = objRow[conQxUsers.UserStateId].ToString().Trim(); //用户状态Id
objQxUsersEN.Password = objRow[conQxUsers.Password].ToString().Trim(); //口令
objQxUsersEN.EffitiveBeginDate = objRow[conQxUsers.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objQxUsersEN.EffitiveEndDate = objRow[conQxUsers.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objQxUsersEN.StuTeacherId = objRow[conQxUsers.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsers.StuTeacherId].ToString().Trim(); //学工号
objQxUsersEN.IdentityId = objRow[conQxUsers.IdentityId] == DBNull.Value ? null : objRow[conQxUsers.IdentityId].ToString().Trim(); //身份编号
objQxUsersEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers.IsArchive].ToString().Trim()); //是否存档
objQxUsersEN.OpenId = objRow[conQxUsers.OpenId] == DBNull.Value ? null : objRow[conQxUsers.OpenId].ToString().Trim(); //微信openid
objQxUsersEN.Email = objRow[conQxUsers.Email] == DBNull.Value ? null : objRow[conQxUsers.Email].ToString().Trim(); //邮箱
objQxUsersEN.PhoneNumber = objRow[conQxUsers.PhoneNumber] == DBNull.Value ? null : objRow[conQxUsers.PhoneNumber].ToString().Trim(); //电话号码
objQxUsersEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers.IsSynch].ToString().Trim()); //是否同步
objQxUsersEN.SynchDate = objRow[conQxUsers.SynchDate] == DBNull.Value ? null : objRow[conQxUsers.SynchDate].ToString().Trim(); //同步日期
objQxUsersEN.DetailInfoTab = objRow[conQxUsers.DetailInfoTab] == DBNull.Value ? null : objRow[conQxUsers.DetailInfoTab].ToString().Trim(); //详细信息表
objQxUsersEN.IdGradeBase = objRow[conQxUsers.IdGradeBase] == DBNull.Value ? null : objRow[conQxUsers.IdGradeBase].ToString().Trim(); //年级流水号
objQxUsersEN.IdSchool = objRow[conQxUsers.IdSchool] == DBNull.Value ? null : objRow[conQxUsers.IdSchool].ToString().Trim(); //学校流水号
objQxUsersEN.IdXzCollege = objRow[conQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[conQxUsers.IdXzCollege].ToString().Trim(); //学院Id
objQxUsersEN.UpdDate = objRow[conQxUsers.UpdDate] == DBNull.Value ? null : objRow[conQxUsers.UpdDate].ToString().Trim(); //修改日期
objQxUsersEN.UpdUser = objRow[conQxUsers.UpdUser] == DBNull.Value ? null : objRow[conQxUsers.UpdUser].ToString().Trim(); //修改用户
objQxUsersEN.Memo = objRow[conQxUsers.Memo] == DBNull.Value ? null : objRow[conQxUsers.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUsersEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objQxUsersEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxUsers(ref clsQxUsersEN objQxUsersEN)
{
bool bolResult = QxUsersDA.GetQxUsers(ref objQxUsersEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strUserId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxUsersEN GetObjByUserId(string strUserId)
{
if (strUserId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strUserId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strUserId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strUserId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsQxUsersEN objQxUsersEN = QxUsersDA.GetObjByUserId(strUserId);
return objQxUsersEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsQxUsersEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsQxUsersEN objQxUsersEN = QxUsersDA.GetFirstObj(strWhereCond);
 return objQxUsersEN;
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
public static clsQxUsersEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsQxUsersEN objQxUsersEN = QxUsersDA.GetObjByDataRow(objRow);
 return objQxUsersEN;
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
public static clsQxUsersEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsQxUsersEN objQxUsersEN = QxUsersDA.GetObjByDataRow(objRow);
 return objQxUsersEN;
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
 /// <param name = "strUserId">所给的关键字</param>
 /// <param name = "lstQxUsersObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxUsersEN GetObjByUserIdFromList(string strUserId, List<clsQxUsersEN> lstQxUsersObjLst)
{
foreach (clsQxUsersEN objQxUsersEN in lstQxUsersObjLst)
{
if (objQxUsersEN.UserId == strUserId)
{
return objQxUsersEN;
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
public static string GetFirstID_S(string strWhereCond) 
{
 string strUserId;
 try
 {
 strUserId = new clsQxUsersDA().GetFirstID(strWhereCond);
 return strUserId;
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
 arrList = QxUsersDA.GetID(strWhereCond);
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
bool bolIsExist = QxUsersDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strUserId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strUserId)
{
if (string.IsNullOrEmpty(strUserId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strUserId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = QxUsersDA.IsExist(strUserId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strUserId">用户ID</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strUserId, string strOpUser)
{
clsQxUsersEN objQxUsersEN = clsQxUsersBL.GetObjByUserId(strUserId);
objQxUsersEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objQxUsersEN.UpdUser = strOpUser;
return clsQxUsersBL.UpdateBySql2(objQxUsersEN);
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
 bolIsExist = clsQxUsersDA.IsExistTable();
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
 bolIsExist = QxUsersDA.IsExistTable(strTabName);
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
 /// <param name = "objQxUsersEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsQxUsersEN objQxUsersEN)
{
 if (string.IsNullOrEmpty(objQxUsersEN.UserId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQxUsersBL.IsExist(objQxUsersEN.UserId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQxUsersEN.UserId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = QxUsersDA.AddNewRecordBySQL2(objQxUsersEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsersBL.ReFreshCache();

if (clsQxUsersBL.relatedActions != null)
{
clsQxUsersBL.relatedActions.UpdRelaTabDate(objQxUsersEN.UserId, objQxUsersEN.UpdUser);
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
 /// <param name = "objQxUsersEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsQxUsersEN objQxUsersEN)
{
 if (string.IsNullOrEmpty(objQxUsersEN.UserId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQxUsersBL.IsExist(objQxUsersEN.UserId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQxUsersEN.UserId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = QxUsersDA.AddNewRecordBySQL2WithReturnKey(objQxUsersEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsersBL.ReFreshCache();

if (clsQxUsersBL.relatedActions != null)
{
clsQxUsersBL.relatedActions.UpdRelaTabDate(objQxUsersEN.UserId, objQxUsersEN.UpdUser);
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
 /// <param name = "strQxUsersObjXml">代表实体对象的XML串</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql_XML(string strQxUsersObjXml)
{
clsQxUsersEN objQxUsersEN = GetObjFromXmlStr(strQxUsersObjXml);
try
{
bool bolResult = QxUsersDA.AddNewRecordBySQL2(objQxUsersEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsersBL.ReFreshCache();

if (clsQxUsersBL.relatedActions != null)
{
clsQxUsersBL.relatedActions.UpdRelaTabDate(objQxUsersEN.UserId, objQxUsersEN.UpdUser);
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
 /// <param name = "objQxUsersEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsQxUsersEN objQxUsersEN)
{
try
{
bool bolResult = QxUsersDA.Update(objQxUsersEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsersBL.ReFreshCache();

if (clsQxUsersBL.relatedActions != null)
{
clsQxUsersBL.relatedActions.UpdRelaTabDate(objQxUsersEN.UserId, objQxUsersEN.UpdUser);
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
 /// <param name = "objQxUsersEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsQxUsersEN objQxUsersEN)
{
 if (string.IsNullOrEmpty(objQxUsersEN.UserId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = QxUsersDA.UpdateBySql2(objQxUsersEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsersBL.ReFreshCache();

if (clsQxUsersBL.relatedActions != null)
{
clsQxUsersBL.relatedActions.UpdRelaTabDate(objQxUsersEN.UserId, objQxUsersEN.UpdUser);
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
 /// <param name = "strQxUsersObjXml">需要修改的对象,用XML来表示</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql_XML(string strQxUsersObjXml)
{
clsQxUsersEN objQxUsersEN = GetObjFromXmlStr(strQxUsersObjXml);
try
{
bool bolResult = QxUsersDA.UpdateBySql2(objQxUsersEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsersBL.ReFreshCache();

if (clsQxUsersBL.relatedActions != null)
{
clsQxUsersBL.relatedActions.UpdRelaTabDate(objQxUsersEN.UserId, objQxUsersEN.UpdUser);
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
 /// <param name = "strUserId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strUserId)
{
try
{
 clsQxUsersEN objQxUsersEN = clsQxUsersBL.GetObjByUserId(strUserId);

if (clsQxUsersBL.relatedActions != null)
{
clsQxUsersBL.relatedActions.UpdRelaTabDate(objQxUsersEN.UserId, objQxUsersEN.UpdUser);
}
if (objQxUsersEN != null)
{
int intRecNum = QxUsersDA.DelRecord(strUserId);
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
/// <param name="strUserId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strUserId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxUsersDA.GetSpecSQLObj();
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
//删除与表:[QxUsers]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conQxUsers.UserId,
//strUserId);
//        clsQxUsersBL.DelQxUserssByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxUsersBL.DelRecord(strUserId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxUsersBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strUserId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strUserId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strUserId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsQxUsersBL.relatedActions != null)
{
clsQxUsersBL.relatedActions.UpdRelaTabDate(strUserId, "UpdRelaTabDate");
}
bool bolResult = QxUsersDA.DelRecord(strUserId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "strUserId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strUserId) 
{
try
{
if (clsQxUsersBL.relatedActions != null)
{
clsQxUsersBL.relatedActions.UpdRelaTabDate(strUserId, "UpdRelaTabDate");
}
bool bolResult = QxUsersDA.DelRecordBySP(strUserId);
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
 /// <param name = "arrUserIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelQxUserss(List<string> arrUserIdLst)
{
if (arrUserIdLst.Count == 0) return 0;
try
{
if (clsQxUsersBL.relatedActions != null)
{
foreach (var strUserId in arrUserIdLst)
{
clsQxUsersBL.relatedActions.UpdRelaTabDate(strUserId, "UpdRelaTabDate");
}
}
int intDelRecNum = QxUsersDA.DelQxUsers(arrUserIdLst);
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
public static int DelQxUserssByCond(string strWhereCond)
{
try
{
if (clsQxUsersBL.relatedActions != null)
{
List<string> arrUserId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strUserId in arrUserId)
{
clsQxUsersBL.relatedActions.UpdRelaTabDate(strUserId, "UpdRelaTabDate");
}
}
int intRecNum = QxUsersDA.DelQxUsers(strWhereCond);
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
 /// 功能:删除满足条件的多条记录.(带事务处理)
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelMultiRecordByCondWithTransaction)
 /// </summary>
 /// <param name = "strWhereCond">需要删除的记录条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回是否删除成功。</returns>
public static bool DelQxUserssByCondWithTransaction_S(string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsQxUsersBL.relatedActions != null)
{
List<string> arrUserId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strUserId in arrUserId)
{
clsQxUsersBL.relatedActions.UpdRelaTabDate(strUserId, "UpdRelaTabDate");
}
}
bool bolResult = QxUsersDA.DelQxUsersWithTransaction_S(strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000044)删除带条件表记录出错!(同时处理事务)(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
/// 扩展删除记录,即同时删除多个表的记录,需要基于原子性的事务处理
/// 这里仅仅是演示函数,使用时请复制到扩展类:[QxUsers]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strUserId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strUserId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxUsersDA.GetSpecSQLObj();
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
//删除与表:[QxUsers]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxUsersBL.DelRecord(strUserId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxUsersBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strUserId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objQxUsersENS">源对象</param>
 /// <param name = "objQxUsersENT">目标对象</param>
 public static void CopyTo(clsQxUsersEN objQxUsersENS, clsQxUsersEN objQxUsersENT)
{
try
{
objQxUsersENT.UserId = objQxUsersENS.UserId; //用户ID
objQxUsersENT.UserName = objQxUsersENS.UserName; //用户名
objQxUsersENT.DepartmentId = objQxUsersENS.DepartmentId; //部门Id
objQxUsersENT.UserStateId = objQxUsersENS.UserStateId; //用户状态Id
objQxUsersENT.Password = objQxUsersENS.Password; //口令
objQxUsersENT.EffitiveBeginDate = objQxUsersENS.EffitiveBeginDate; //有效开始日期
objQxUsersENT.EffitiveEndDate = objQxUsersENS.EffitiveEndDate; //有效结束日期
objQxUsersENT.StuTeacherId = objQxUsersENS.StuTeacherId; //学工号
objQxUsersENT.IdentityId = objQxUsersENS.IdentityId; //身份编号
objQxUsersENT.IsArchive = objQxUsersENS.IsArchive; //是否存档
objQxUsersENT.OpenId = objQxUsersENS.OpenId; //微信openid
objQxUsersENT.Email = objQxUsersENS.Email; //邮箱
objQxUsersENT.PhoneNumber = objQxUsersENS.PhoneNumber; //电话号码
objQxUsersENT.IsSynch = objQxUsersENS.IsSynch; //是否同步
objQxUsersENT.SynchDate = objQxUsersENS.SynchDate; //同步日期
objQxUsersENT.DetailInfoTab = objQxUsersENS.DetailInfoTab; //详细信息表
objQxUsersENT.IdGradeBase = objQxUsersENS.IdGradeBase; //年级流水号
objQxUsersENT.IdSchool = objQxUsersENS.IdSchool; //学校流水号
objQxUsersENT.IdXzCollege = objQxUsersENS.IdXzCollege; //学院Id
objQxUsersENT.UpdDate = objQxUsersENS.UpdDate; //修改日期
objQxUsersENT.UpdUser = objQxUsersENS.UpdUser; //修改用户
objQxUsersENT.Memo = objQxUsersENS.Memo; //备注
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
 /// <param name = "objQxUsersEN">源简化对象</param>
 public static void SetUpdFlag(clsQxUsersEN objQxUsersEN)
{
try
{
objQxUsersEN.ClearUpdateState();
   string strsfUpdFldSetStr = objQxUsersEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conQxUsers.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsersEN.UserId = objQxUsersEN.UserId; //用户ID
}
if (arrFldSet.Contains(conQxUsers.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsersEN.UserName = objQxUsersEN.UserName; //用户名
}
if (arrFldSet.Contains(conQxUsers.DepartmentId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsersEN.DepartmentId = objQxUsersEN.DepartmentId == "[null]" ? null :  objQxUsersEN.DepartmentId; //部门Id
}
if (arrFldSet.Contains(conQxUsers.UserStateId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsersEN.UserStateId = objQxUsersEN.UserStateId; //用户状态Id
}
if (arrFldSet.Contains(conQxUsers.Password, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsersEN.Password = objQxUsersEN.Password; //口令
}
if (arrFldSet.Contains(conQxUsers.EffitiveBeginDate, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsersEN.EffitiveBeginDate = objQxUsersEN.EffitiveBeginDate == "[null]" ? null :  objQxUsersEN.EffitiveBeginDate; //有效开始日期
}
if (arrFldSet.Contains(conQxUsers.EffitiveEndDate, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsersEN.EffitiveEndDate = objQxUsersEN.EffitiveEndDate == "[null]" ? null :  objQxUsersEN.EffitiveEndDate; //有效结束日期
}
if (arrFldSet.Contains(conQxUsers.StuTeacherId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsersEN.StuTeacherId = objQxUsersEN.StuTeacherId == "[null]" ? null :  objQxUsersEN.StuTeacherId; //学工号
}
if (arrFldSet.Contains(conQxUsers.IdentityId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsersEN.IdentityId = objQxUsersEN.IdentityId == "[null]" ? null :  objQxUsersEN.IdentityId; //身份编号
}
if (arrFldSet.Contains(conQxUsers.IsArchive, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsersEN.IsArchive = objQxUsersEN.IsArchive; //是否存档
}
if (arrFldSet.Contains(conQxUsers.OpenId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsersEN.OpenId = objQxUsersEN.OpenId == "[null]" ? null :  objQxUsersEN.OpenId; //微信openid
}
if (arrFldSet.Contains(conQxUsers.Email, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsersEN.Email = objQxUsersEN.Email == "[null]" ? null :  objQxUsersEN.Email; //邮箱
}
if (arrFldSet.Contains(conQxUsers.PhoneNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsersEN.PhoneNumber = objQxUsersEN.PhoneNumber == "[null]" ? null :  objQxUsersEN.PhoneNumber; //电话号码
}
if (arrFldSet.Contains(conQxUsers.IsSynch, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsersEN.IsSynch = objQxUsersEN.IsSynch; //是否同步
}
if (arrFldSet.Contains(conQxUsers.SynchDate, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsersEN.SynchDate = objQxUsersEN.SynchDate == "[null]" ? null :  objQxUsersEN.SynchDate; //同步日期
}
if (arrFldSet.Contains(conQxUsers.DetailInfoTab, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsersEN.DetailInfoTab = objQxUsersEN.DetailInfoTab == "[null]" ? null :  objQxUsersEN.DetailInfoTab; //详细信息表
}
if (arrFldSet.Contains(conQxUsers.IdGradeBase, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsersEN.IdGradeBase = objQxUsersEN.IdGradeBase == "[null]" ? null :  objQxUsersEN.IdGradeBase; //年级流水号
}
if (arrFldSet.Contains(conQxUsers.IdSchool, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsersEN.IdSchool = objQxUsersEN.IdSchool == "[null]" ? null :  objQxUsersEN.IdSchool; //学校流水号
}
if (arrFldSet.Contains(conQxUsers.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsersEN.IdXzCollege = objQxUsersEN.IdXzCollege == "[null]" ? null :  objQxUsersEN.IdXzCollege; //学院Id
}
if (arrFldSet.Contains(conQxUsers.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsersEN.UpdDate = objQxUsersEN.UpdDate == "[null]" ? null :  objQxUsersEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conQxUsers.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsersEN.UpdUser = objQxUsersEN.UpdUser == "[null]" ? null :  objQxUsersEN.UpdUser; //修改用户
}
if (arrFldSet.Contains(conQxUsers.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsersEN.Memo = objQxUsersEN.Memo == "[null]" ? null :  objQxUsersEN.Memo; //备注
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
 /// <param name = "objQxUsersEN">源简化对象</param>
 public static void AccessFldValueNull(clsQxUsersEN objQxUsersEN)
{
try
{
if (objQxUsersEN.DepartmentId == "[null]") objQxUsersEN.DepartmentId = null; //部门Id
if (objQxUsersEN.EffitiveBeginDate == "[null]") objQxUsersEN.EffitiveBeginDate = null; //有效开始日期
if (objQxUsersEN.EffitiveEndDate == "[null]") objQxUsersEN.EffitiveEndDate = null; //有效结束日期
if (objQxUsersEN.StuTeacherId == "[null]") objQxUsersEN.StuTeacherId = null; //学工号
if (objQxUsersEN.IdentityId == "[null]") objQxUsersEN.IdentityId = null; //身份编号
if (objQxUsersEN.OpenId == "[null]") objQxUsersEN.OpenId = null; //微信openid
if (objQxUsersEN.Email == "[null]") objQxUsersEN.Email = null; //邮箱
if (objQxUsersEN.PhoneNumber == "[null]") objQxUsersEN.PhoneNumber = null; //电话号码
if (objQxUsersEN.SynchDate == "[null]") objQxUsersEN.SynchDate = null; //同步日期
if (objQxUsersEN.DetailInfoTab == "[null]") objQxUsersEN.DetailInfoTab = null; //详细信息表
if (objQxUsersEN.IdGradeBase == "[null]") objQxUsersEN.IdGradeBase = null; //年级流水号
if (objQxUsersEN.IdSchool == "[null]") objQxUsersEN.IdSchool = null; //学校流水号
if (objQxUsersEN.IdXzCollege == "[null]") objQxUsersEN.IdXzCollege = null; //学院Id
if (objQxUsersEN.UpdDate == "[null]") objQxUsersEN.UpdDate = null; //修改日期
if (objQxUsersEN.UpdUser == "[null]") objQxUsersEN.UpdUser = null; //修改用户
if (objQxUsersEN.Memo == "[null]") objQxUsersEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsQxUsersEN objQxUsersEN)
{
 QxUsersDA.CheckPropertyNew(objQxUsersEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsQxUsersEN objQxUsersEN)
{
 QxUsersDA.CheckProperty4Condition(objQxUsersEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_UserId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conQxUsers.UserId); 
List<clsQxUsersEN> arrObjLst = clsQxUsersBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsQxUsersEN objQxUsersEN = new clsQxUsersEN()
{
UserId = "0",
UserName = "选[用户]..."
};
arrObjLst.Insert(0, objQxUsersEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conQxUsers.UserId;
objComboBox.DisplayMember = conQxUsers.UserName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_UserId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[用户]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conQxUsers.UserId); 
IEnumerable<clsQxUsersEN> arrObjLst = clsQxUsersBL.GetObjLst(strCondition);
objDDL.DataValueField = conQxUsers.UserId;
objDDL.DataTextField = conQxUsers.UserName;
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_UserIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[用户]...","0");
List<clsQxUsersEN> arrQxUsersObjLst = GetAllQxUsersObjLstCache(); 
objDDL.DataValueField = conQxUsers.UserId;
objDDL.DataTextField = conQxUsers.UserName;
objDDL.DataSource = arrQxUsersObjLst;
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
if (clsQxUsersBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxUsersBL没有刷新缓存机制(clsQxUsersBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by UserId");
//if (arrQxUsersObjLstCache == null)
//{
//arrQxUsersObjLstCache = QxUsersDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strUserId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxUsersEN GetObjByUserIdCache(string strUserId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsQxUsersEN._CurrTabName);
List<clsQxUsersEN> arrQxUsersObjLstCache = GetObjLstCache();
IEnumerable <clsQxUsersEN> arrQxUsersObjLst_Sel =
arrQxUsersObjLstCache
.Where(x=> x.UserId == strUserId 
);
if (arrQxUsersObjLst_Sel.Count() == 0)
{
   clsQxUsersEN obj = clsQxUsersBL.GetObjByUserId(strUserId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrQxUsersObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strUserId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetUserNameByUserIdCache(string strUserId)
{
if (string.IsNullOrEmpty(strUserId) == true) return "";
//获取缓存中的对象列表
clsQxUsersEN objQxUsers = GetObjByUserIdCache(strUserId);
if (objQxUsers == null) return "";
return objQxUsers.UserName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strUserId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByUserIdCache(string strUserId)
{
if (string.IsNullOrEmpty(strUserId) == true) return "";
//获取缓存中的对象列表
clsQxUsersEN objQxUsers = GetObjByUserIdCache(strUserId);
if (objQxUsers == null) return "";
return objQxUsers.UserName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxUsersEN> GetAllQxUsersObjLstCache()
{
//获取缓存中的对象列表
List<clsQxUsersEN> arrQxUsersObjLstCache = GetObjLstCache(); 
return arrQxUsersObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxUsersEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsQxUsersEN._CurrTabName);
List<clsQxUsersEN> arrQxUsersObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrQxUsersObjLstCache;
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
string strKey = string.Format("{0}", clsQxUsersEN._CurrTabName);
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
if (clsQxUsersBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsQxUsersEN._CurrTabName);
CacheHelper.Remove(strKey);
clsQxUsersBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2024-03-20
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstQxUsersObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsQxUsersEN> lstQxUsersObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstQxUsersObjLst, writer);
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
 /// <param name = "lstQxUsersObjLst">[clsQxUsersEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsQxUsersEN> lstQxUsersObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsQxUsersBL.listXmlNode);
writer.WriteStartElement(clsQxUsersBL.itemsXmlNode);
foreach (clsQxUsersEN objQxUsersEN in lstQxUsersObjLst)
{
clsQxUsersBL.SerializeXML(writer, objQxUsersEN);
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
 /// <param name = "objQxUsersEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsQxUsersEN objQxUsersEN)
{
writer.WriteStartElement(clsQxUsersBL.itemXmlNode);
 
if (objQxUsersEN.UserId != null)
{
writer.WriteElementString(conQxUsers.UserId, objQxUsersEN.UserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUsersEN.UserName != null)
{
writer.WriteElementString(conQxUsers.UserName, objQxUsersEN.UserName.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUsersEN.DepartmentId != null)
{
writer.WriteElementString(conQxUsers.DepartmentId, objQxUsersEN.DepartmentId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUsersEN.UserStateId != null)
{
writer.WriteElementString(conQxUsers.UserStateId, objQxUsersEN.UserStateId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUsersEN.Password != null)
{
writer.WriteElementString(conQxUsers.Password, objQxUsersEN.Password.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUsersEN.EffitiveBeginDate != null)
{
writer.WriteElementString(conQxUsers.EffitiveBeginDate, objQxUsersEN.EffitiveBeginDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUsersEN.EffitiveEndDate != null)
{
writer.WriteElementString(conQxUsers.EffitiveEndDate, objQxUsersEN.EffitiveEndDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUsersEN.StuTeacherId != null)
{
writer.WriteElementString(conQxUsers.StuTeacherId, objQxUsersEN.StuTeacherId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUsersEN.IdentityId != null)
{
writer.WriteElementString(conQxUsers.IdentityId, objQxUsersEN.IdentityId.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(conQxUsers.IsArchive, objQxUsersEN.IsArchive.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objQxUsersEN.OpenId != null)
{
writer.WriteElementString(conQxUsers.OpenId, objQxUsersEN.OpenId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUsersEN.Email != null)
{
writer.WriteElementString(conQxUsers.Email, objQxUsersEN.Email.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUsersEN.PhoneNumber != null)
{
writer.WriteElementString(conQxUsers.PhoneNumber, objQxUsersEN.PhoneNumber.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(conQxUsers.IsSynch, objQxUsersEN.IsSynch.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objQxUsersEN.SynchDate != null)
{
writer.WriteElementString(conQxUsers.SynchDate, objQxUsersEN.SynchDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUsersEN.DetailInfoTab != null)
{
writer.WriteElementString(conQxUsers.DetailInfoTab, objQxUsersEN.DetailInfoTab.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUsersEN.IdGradeBase != null)
{
writer.WriteElementString(conQxUsers.IdGradeBase, objQxUsersEN.IdGradeBase.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUsersEN.IdSchool != null)
{
writer.WriteElementString(conQxUsers.IdSchool, objQxUsersEN.IdSchool.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUsersEN.IdXzCollege != null)
{
writer.WriteElementString(conQxUsers.IdXzCollege, objQxUsersEN.IdXzCollege.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUsersEN.UpdDate != null)
{
writer.WriteElementString(conQxUsers.UpdDate, objQxUsersEN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUsersEN.UpdUser != null)
{
writer.WriteElementString(conQxUsers.UpdUser, objQxUsersEN.UpdUser.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUsersEN.Memo != null)
{
writer.WriteElementString(conQxUsers.Memo, objQxUsersEN.Memo.ToString(CultureInfo.InvariantCulture));
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
public static clsQxUsersEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsQxUsersEN objQxUsersEN = new clsQxUsersEN();
reader.Read();
while (!(reader.Name == clsQxUsersBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(conQxUsers.UserId))
{
objQxUsersEN.UserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsers.UserName))
{
objQxUsersEN.UserName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsers.DepartmentId))
{
objQxUsersEN.DepartmentId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsers.UserStateId))
{
objQxUsersEN.UserStateId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsers.Password))
{
objQxUsersEN.Password = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsers.EffitiveBeginDate))
{
objQxUsersEN.EffitiveBeginDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsers.EffitiveEndDate))
{
objQxUsersEN.EffitiveEndDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsers.StuTeacherId))
{
objQxUsersEN.StuTeacherId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsers.IdentityId))
{
objQxUsersEN.IdentityId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsers.IsArchive))
{
objQxUsersEN.IsArchive = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(conQxUsers.OpenId))
{
objQxUsersEN.OpenId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsers.Email))
{
objQxUsersEN.Email = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsers.PhoneNumber))
{
objQxUsersEN.PhoneNumber = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsers.IsSynch))
{
objQxUsersEN.IsSynch = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(conQxUsers.SynchDate))
{
objQxUsersEN.SynchDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsers.DetailInfoTab))
{
objQxUsersEN.DetailInfoTab = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsers.IdGradeBase))
{
objQxUsersEN.IdGradeBase = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsers.IdSchool))
{
objQxUsersEN.IdSchool = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsers.IdXzCollege))
{
objQxUsersEN.IdXzCollege = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsers.UpdDate))
{
objQxUsersEN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsers.UpdUser))
{
objQxUsersEN.UpdUser = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsers.Memo))
{
objQxUsersEN.Memo = reader.ReadElementContentAsString();
}
}
return objQxUsersEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strQxUsersObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsQxUsersEN GetObjFromXmlStr(string strQxUsersObjXmlStr)
{
clsQxUsersEN objQxUsersEN = new clsQxUsersEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strQxUsersObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsQxUsersBL.itemXmlNode))
{
objQxUsersEN = GetObjFromXml(reader);
return objQxUsersEN;
}
}
return objQxUsersEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2024-03-20
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objQxUsersEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsQxUsersEN objQxUsersEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objQxUsersEN);
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
public static string Func(string strInFldName, string strOutFldName, string strUserId)
{
if (strInFldName != conQxUsers.UserId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conQxUsers.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conQxUsers.AttributeName));
throw new Exception(strMsg);
}
var objQxUsers = clsQxUsersBL.GetObjByUserIdCache(strUserId);
if (objQxUsers == null) return "";
return objQxUsers[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2024-03-20
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objQxUsersEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsQxUsersEN objQxUsersEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsQxUsersEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objQxUsersEN[strField]);
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
 /// <param name = "lstQxUsersObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsQxUsersEN> lstQxUsersObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstQxUsersObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsQxUsersEN objQxUsersEN in lstQxUsersObjLst)
{
string strJSON_One = SerializeObjToJSON(objQxUsersEN);
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
int intRecCount = clsQxUsersDA.GetRecCount(strTabName);
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
int intRecCount = clsQxUsersDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsQxUsersDA.GetRecCount();
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
int intRecCount = clsQxUsersDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objQxUsersCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsQxUsersEN objQxUsersCond)
{
List<clsQxUsersEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxUsersEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxUsers.AttributeName)
{
if (objQxUsersCond.IsUpdated(strFldName) == false) continue;
if (objQxUsersCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUsersCond[strFldName].ToString());
}
else
{
if (objQxUsersCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxUsersCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUsersCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxUsersCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxUsersCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxUsersCond[strFldName]));
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
 List<string> arrList = clsQxUsersDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = QxUsersDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = QxUsersDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = QxUsersDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxUsersDA.SetFldValue(clsQxUsersEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = QxUsersDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxUsersDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxUsersDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxUsersDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[QxUsers] "); 
 strCreateTabCode.Append(" ( "); 
 // /**用户ID*/ 
 strCreateTabCode.Append(" UserId varchar(18) primary key, "); 
 // /**用户名*/ 
 strCreateTabCode.Append(" UserName varchar(30) not Null, "); 
 // /**部门Id*/ 
 strCreateTabCode.Append(" DepartmentId varchar(8) Null, "); 
 // /**用户状态Id*/ 
 strCreateTabCode.Append(" UserStateId char(2) not Null, "); 
 // /**口令*/ 
 strCreateTabCode.Append(" Password varchar(20) not Null, "); 
 // /**有效开始日期*/ 
 strCreateTabCode.Append(" EffitiveBeginDate varchar(14) Null, "); 
 // /**有效结束日期*/ 
 strCreateTabCode.Append(" EffitiveEndDate varchar(14) Null, "); 
 // /**学工号*/ 
 strCreateTabCode.Append(" StuTeacherId varchar(20) Null, "); 
 // /**身份编号*/ 
 strCreateTabCode.Append(" IdentityId char(2) Null, "); 
 // /**是否存档*/ 
 strCreateTabCode.Append(" IsArchive bit Null, "); 
 // /**微信openid*/ 
 strCreateTabCode.Append(" OpenId varchar(50) Null, "); 
 // /**邮箱*/ 
 strCreateTabCode.Append(" Email varchar(100) Null, "); 
 // /**电话号码*/ 
 strCreateTabCode.Append(" PhoneNumber varchar(15) Null, "); 
 // /**是否同步*/ 
 strCreateTabCode.Append(" IsSynch bit Null, "); 
 // /**同步日期*/ 
 strCreateTabCode.Append(" SynchDate varchar(30) Null, "); 
 // /**详细信息表*/ 
 strCreateTabCode.Append(" DetailInfoTab varchar(30) Null, "); 
 // /**年级流水号*/ 
 strCreateTabCode.Append(" IdGradeBase char(4) Null, "); 
 // /**学校流水号*/ 
 strCreateTabCode.Append(" IdSchool char(4) Null, "); 
 // /**学院Id*/ 
 strCreateTabCode.Append(" IdXzCollege char(4) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改用户*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**部门名*/ 
 strCreateTabCode.Append(" DepartmentName varchar(100) Null, "); 
 // /**部门类型ID*/ 
 strCreateTabCode.Append(" DepartmentTypeId char(2) Null, "); 
 // /**部门类型名*/ 
 strCreateTabCode.Append(" DepartmentTypeName varchar(50) Null, "); 
 // /**用户名*/ 
 strCreateTabCode.Append(" DuUserName varchar(30) not Null, "); 
 // /**用户状态名*/ 
 strCreateTabCode.Append(" UserStateName varchar(20) Null, "); 
 // /**身份描述*/ 
 strCreateTabCode.Append(" IdentityDesc varchar(20) Null, "); 
 // /**学院名*/ 
 strCreateTabCode.Append(" CollegeName varchar(100) Null, "); 
 // /**学校名称*/ 
 strCreateTabCode.Append(" SchoolName varchar(50) Null, "); 
 // /**年级名称*/ 
 strCreateTabCode.Append(" GradeBaseName varchar(20) Null, "); 
 // /**上级菜单名*/ 
 strCreateTabCode.Append(" RoleNames varchar(30) Null, "); 
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
 /// 用户(QxUsers)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4QxUsers : clsCommFun4BL
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
clsQxUsersBL.ReFreshThisCache();
}
}

}