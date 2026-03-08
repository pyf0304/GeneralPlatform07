
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUsers4SynchBL
 表名:QxUsers4Synch(00140089)
 * 版本:2023.12.26.1(服务器:WIN-SRV103-116)
 日期:2023/12/28 19:01:04
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:数据同步(DataSynch)
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
public static class  clsQxUsers4SynchBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxUsers4SynchEN GetObj(this K_mId_QxUsers4Synch myKey)
{
clsQxUsers4SynchEN objQxUsers4SynchEN = clsQxUsers4SynchBL.QxUsers4SynchDA.GetObjBymId(myKey.Value);
return objQxUsers4SynchEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQxUsers4SynchEN objQxUsers4SynchEN)
{
if (CheckUniqueness(objQxUsers4SynchEN) == false)
{
var strMsg = string.Format("记录已经存在!IP地址 = [{0}],用户ID = [{1}]的数据已经存在!(in clsQxUsers4SynchBL.AddNewRecord)", objQxUsers4SynchEN.IpAddress,objQxUsers4SynchEN.UserId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsQxUsers4SynchBL.QxUsers4SynchDA.AddNewRecordBySQL2(objQxUsers4SynchEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsers4SynchBL.ReFreshCache();

if (clsQxUsers4SynchBL.relatedActions != null)
{
clsQxUsers4SynchBL.relatedActions.UpdRelaTabDate(objQxUsers4SynchEN.mId, objQxUsers4SynchEN.UpdUser);
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
public static bool AddRecordEx(this clsQxUsers4SynchEN objQxUsers4SynchEN)
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
objQxUsers4SynchEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objQxUsers4SynchEN.CheckUniqueness() == false)
{
strMsg = string.Format("(IP地址(IpAddress)=[{0}],用户ID(UserId)=[{1}])已经存在,不能重复!", objQxUsers4SynchEN.IpAddress, objQxUsers4SynchEN.UserId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objQxUsers4SynchEN.AddNewRecord();
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
 /// <param name = "objQxUsers4SynchEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsQxUsers4SynchEN objQxUsers4SynchEN)
{
if (CheckUniqueness(objQxUsers4SynchEN) == false)
{
var strMsg = string.Format("记录已经存在!IP地址 = [{0}],用户ID = [{1}]的数据已经存在!(in clsQxUsers4SynchBL.AddNewRecordWithReturnKey)", objQxUsers4SynchEN.IpAddress,objQxUsers4SynchEN.UserId);
throw new Exception(strMsg);
}
try
{
string strKey = clsQxUsers4SynchBL.QxUsers4SynchDA.AddNewRecordBySQL2WithReturnKey(objQxUsers4SynchEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsers4SynchBL.ReFreshCache();

if (clsQxUsers4SynchBL.relatedActions != null)
{
clsQxUsers4SynchBL.relatedActions.UpdRelaTabDate(objQxUsers4SynchEN.mId, objQxUsers4SynchEN.UpdUser);
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
 /// <param name = "objQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsers4SynchEN SetmId(this clsQxUsers4SynchEN objQxUsers4SynchEN, long lngmId, string strComparisonOp="")
	{
objQxUsers4SynchEN.mId = lngmId; //流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsers4SynchEN.dicFldComparisonOp.ContainsKey(conQxUsers4Synch.mId) == false)
{
objQxUsers4SynchEN.dicFldComparisonOp.Add(conQxUsers4Synch.mId, strComparisonOp);
}
else
{
objQxUsers4SynchEN.dicFldComparisonOp[conQxUsers4Synch.mId] = strComparisonOp;
}
}
return objQxUsers4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsers4SynchEN SetIpAddress(this clsQxUsers4SynchEN objQxUsers4SynchEN, string strIpAddress, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIpAddress, 23, conQxUsers4Synch.IpAddress);
}
objQxUsers4SynchEN.IpAddress = strIpAddress; //IP地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsers4SynchEN.dicFldComparisonOp.ContainsKey(conQxUsers4Synch.IpAddress) == false)
{
objQxUsers4SynchEN.dicFldComparisonOp.Add(conQxUsers4Synch.IpAddress, strComparisonOp);
}
else
{
objQxUsers4SynchEN.dicFldComparisonOp[conQxUsers4Synch.IpAddress] = strComparisonOp;
}
}
return objQxUsers4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsers4SynchEN SetUserId(this clsQxUsers4SynchEN objQxUsers4SynchEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, conQxUsers4Synch.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conQxUsers4Synch.UserId);
}
objQxUsers4SynchEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsers4SynchEN.dicFldComparisonOp.ContainsKey(conQxUsers4Synch.UserId) == false)
{
objQxUsers4SynchEN.dicFldComparisonOp.Add(conQxUsers4Synch.UserId, strComparisonOp);
}
else
{
objQxUsers4SynchEN.dicFldComparisonOp[conQxUsers4Synch.UserId] = strComparisonOp;
}
}
return objQxUsers4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsers4SynchEN SetUserName(this clsQxUsers4SynchEN objQxUsers4SynchEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, conQxUsers4Synch.UserName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, conQxUsers4Synch.UserName);
}
objQxUsers4SynchEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsers4SynchEN.dicFldComparisonOp.ContainsKey(conQxUsers4Synch.UserName) == false)
{
objQxUsers4SynchEN.dicFldComparisonOp.Add(conQxUsers4Synch.UserName, strComparisonOp);
}
else
{
objQxUsers4SynchEN.dicFldComparisonOp[conQxUsers4Synch.UserName] = strComparisonOp;
}
}
return objQxUsers4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsers4SynchEN SetUserStateId(this clsQxUsers4SynchEN objQxUsers4SynchEN, string strUserStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserStateId, conQxUsers4Synch.UserStateId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserStateId, 2, conQxUsers4Synch.UserStateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserStateId, 2, conQxUsers4Synch.UserStateId);
}
objQxUsers4SynchEN.UserStateId = strUserStateId; //用户状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsers4SynchEN.dicFldComparisonOp.ContainsKey(conQxUsers4Synch.UserStateId) == false)
{
objQxUsers4SynchEN.dicFldComparisonOp.Add(conQxUsers4Synch.UserStateId, strComparisonOp);
}
else
{
objQxUsers4SynchEN.dicFldComparisonOp[conQxUsers4Synch.UserStateId] = strComparisonOp;
}
}
return objQxUsers4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsers4SynchEN SetOpenId(this clsQxUsers4SynchEN objQxUsers4SynchEN, string strOpenId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOpenId, 50, conQxUsers4Synch.OpenId);
}
objQxUsers4SynchEN.OpenId = strOpenId; //微信openid
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsers4SynchEN.dicFldComparisonOp.ContainsKey(conQxUsers4Synch.OpenId) == false)
{
objQxUsers4SynchEN.dicFldComparisonOp.Add(conQxUsers4Synch.OpenId, strComparisonOp);
}
else
{
objQxUsers4SynchEN.dicFldComparisonOp[conQxUsers4Synch.OpenId] = strComparisonOp;
}
}
return objQxUsers4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsers4SynchEN SetIdentityId(this clsQxUsers4SynchEN objQxUsers4SynchEN, string strIdentityId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdentityId, 2, conQxUsers4Synch.IdentityId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdentityId, 2, conQxUsers4Synch.IdentityId);
}
objQxUsers4SynchEN.IdentityId = strIdentityId; //身份编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsers4SynchEN.dicFldComparisonOp.ContainsKey(conQxUsers4Synch.IdentityId) == false)
{
objQxUsers4SynchEN.dicFldComparisonOp.Add(conQxUsers4Synch.IdentityId, strComparisonOp);
}
else
{
objQxUsers4SynchEN.dicFldComparisonOp[conQxUsers4Synch.IdentityId] = strComparisonOp;
}
}
return objQxUsers4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsers4SynchEN SetStuTeacherId(this clsQxUsers4SynchEN objQxUsers4SynchEN, string strStuTeacherId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuTeacherId, 20, conQxUsers4Synch.StuTeacherId);
}
objQxUsers4SynchEN.StuTeacherId = strStuTeacherId; //学工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsers4SynchEN.dicFldComparisonOp.ContainsKey(conQxUsers4Synch.StuTeacherId) == false)
{
objQxUsers4SynchEN.dicFldComparisonOp.Add(conQxUsers4Synch.StuTeacherId, strComparisonOp);
}
else
{
objQxUsers4SynchEN.dicFldComparisonOp[conQxUsers4Synch.StuTeacherId] = strComparisonOp;
}
}
return objQxUsers4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsers4SynchEN SetPassword(this clsQxUsers4SynchEN objQxUsers4SynchEN, string strPassword, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPassword, conQxUsers4Synch.Password);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPassword, 20, conQxUsers4Synch.Password);
}
objQxUsers4SynchEN.Password = strPassword; //口令
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsers4SynchEN.dicFldComparisonOp.ContainsKey(conQxUsers4Synch.Password) == false)
{
objQxUsers4SynchEN.dicFldComparisonOp.Add(conQxUsers4Synch.Password, strComparisonOp);
}
else
{
objQxUsers4SynchEN.dicFldComparisonOp[conQxUsers4Synch.Password] = strComparisonOp;
}
}
return objQxUsers4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsers4SynchEN SetPhoneNumber(this clsQxUsers4SynchEN objQxUsers4SynchEN, string strPhoneNumber, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPhoneNumber, 15, conQxUsers4Synch.PhoneNumber);
}
objQxUsers4SynchEN.PhoneNumber = strPhoneNumber; //电话号码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsers4SynchEN.dicFldComparisonOp.ContainsKey(conQxUsers4Synch.PhoneNumber) == false)
{
objQxUsers4SynchEN.dicFldComparisonOp.Add(conQxUsers4Synch.PhoneNumber, strComparisonOp);
}
else
{
objQxUsers4SynchEN.dicFldComparisonOp[conQxUsers4Synch.PhoneNumber] = strComparisonOp;
}
}
return objQxUsers4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsers4SynchEN SetDepartmentId(this clsQxUsers4SynchEN objQxUsers4SynchEN, string strDepartmentId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentId, 8, conQxUsers4Synch.DepartmentId);
}
objQxUsers4SynchEN.DepartmentId = strDepartmentId; //部门Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsers4SynchEN.dicFldComparisonOp.ContainsKey(conQxUsers4Synch.DepartmentId) == false)
{
objQxUsers4SynchEN.dicFldComparisonOp.Add(conQxUsers4Synch.DepartmentId, strComparisonOp);
}
else
{
objQxUsers4SynchEN.dicFldComparisonOp[conQxUsers4Synch.DepartmentId] = strComparisonOp;
}
}
return objQxUsers4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsers4SynchEN SetIdXzCollege(this clsQxUsers4SynchEN objQxUsers4SynchEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, conQxUsers4Synch.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, conQxUsers4Synch.IdXzCollege);
}
objQxUsers4SynchEN.IdXzCollege = strIdXzCollege; //IdXzCollege
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsers4SynchEN.dicFldComparisonOp.ContainsKey(conQxUsers4Synch.IdXzCollege) == false)
{
objQxUsers4SynchEN.dicFldComparisonOp.Add(conQxUsers4Synch.IdXzCollege, strComparisonOp);
}
else
{
objQxUsers4SynchEN.dicFldComparisonOp[conQxUsers4Synch.IdXzCollege] = strComparisonOp;
}
}
return objQxUsers4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsers4SynchEN SetEffitiveBeginDate(this clsQxUsers4SynchEN objQxUsers4SynchEN, string strEffitiveBeginDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEffitiveBeginDate, 14, conQxUsers4Synch.EffitiveBeginDate);
}
objQxUsers4SynchEN.EffitiveBeginDate = strEffitiveBeginDate; //有效开始日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsers4SynchEN.dicFldComparisonOp.ContainsKey(conQxUsers4Synch.EffitiveBeginDate) == false)
{
objQxUsers4SynchEN.dicFldComparisonOp.Add(conQxUsers4Synch.EffitiveBeginDate, strComparisonOp);
}
else
{
objQxUsers4SynchEN.dicFldComparisonOp[conQxUsers4Synch.EffitiveBeginDate] = strComparisonOp;
}
}
return objQxUsers4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsers4SynchEN SetEffitiveEndDate(this clsQxUsers4SynchEN objQxUsers4SynchEN, string strEffitiveEndDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEffitiveEndDate, 14, conQxUsers4Synch.EffitiveEndDate);
}
objQxUsers4SynchEN.EffitiveEndDate = strEffitiveEndDate; //有效结束日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsers4SynchEN.dicFldComparisonOp.ContainsKey(conQxUsers4Synch.EffitiveEndDate) == false)
{
objQxUsers4SynchEN.dicFldComparisonOp.Add(conQxUsers4Synch.EffitiveEndDate, strComparisonOp);
}
else
{
objQxUsers4SynchEN.dicFldComparisonOp[conQxUsers4Synch.EffitiveEndDate] = strComparisonOp;
}
}
return objQxUsers4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsers4SynchEN SetEmail(this clsQxUsers4SynchEN objQxUsers4SynchEN, string strEmail, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEmail, 100, conQxUsers4Synch.Email);
}
objQxUsers4SynchEN.Email = strEmail; //邮箱
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsers4SynchEN.dicFldComparisonOp.ContainsKey(conQxUsers4Synch.Email) == false)
{
objQxUsers4SynchEN.dicFldComparisonOp.Add(conQxUsers4Synch.Email, strComparisonOp);
}
else
{
objQxUsers4SynchEN.dicFldComparisonOp[conQxUsers4Synch.Email] = strComparisonOp;
}
}
return objQxUsers4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsers4SynchEN SetIsArchive(this clsQxUsers4SynchEN objQxUsers4SynchEN, bool bolIsArchive, string strComparisonOp="")
	{
objQxUsers4SynchEN.IsArchive = bolIsArchive; //是否存档
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsers4SynchEN.dicFldComparisonOp.ContainsKey(conQxUsers4Synch.IsArchive) == false)
{
objQxUsers4SynchEN.dicFldComparisonOp.Add(conQxUsers4Synch.IsArchive, strComparisonOp);
}
else
{
objQxUsers4SynchEN.dicFldComparisonOp[conQxUsers4Synch.IsArchive] = strComparisonOp;
}
}
return objQxUsers4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsers4SynchEN SetIsAccessSynch(this clsQxUsers4SynchEN objQxUsers4SynchEN, bool bolIsAccessSynch, string strComparisonOp="")
	{
objQxUsers4SynchEN.IsAccessSynch = bolIsAccessSynch; //是否处理同步
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsers4SynchEN.dicFldComparisonOp.ContainsKey(conQxUsers4Synch.IsAccessSynch) == false)
{
objQxUsers4SynchEN.dicFldComparisonOp.Add(conQxUsers4Synch.IsAccessSynch, strComparisonOp);
}
else
{
objQxUsers4SynchEN.dicFldComparisonOp[conQxUsers4Synch.IsAccessSynch] = strComparisonOp;
}
}
return objQxUsers4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsers4SynchEN SetAccessSynchDate(this clsQxUsers4SynchEN objQxUsers4SynchEN, string strAccessSynchDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAccessSynchDate, 14, conQxUsers4Synch.AccessSynchDate);
}
objQxUsers4SynchEN.AccessSynchDate = strAccessSynchDate; //处理同步日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsers4SynchEN.dicFldComparisonOp.ContainsKey(conQxUsers4Synch.AccessSynchDate) == false)
{
objQxUsers4SynchEN.dicFldComparisonOp.Add(conQxUsers4Synch.AccessSynchDate, strComparisonOp);
}
else
{
objQxUsers4SynchEN.dicFldComparisonOp[conQxUsers4Synch.AccessSynchDate] = strComparisonOp;
}
}
return objQxUsers4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsers4SynchEN SetIsExistUserInCurr(this clsQxUsers4SynchEN objQxUsers4SynchEN, bool bolIsExistUserInCurr, string strComparisonOp="")
	{
objQxUsers4SynchEN.IsExistUserInCurr = bolIsExistUserInCurr; //当前是否存在用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsers4SynchEN.dicFldComparisonOp.ContainsKey(conQxUsers4Synch.IsExistUserInCurr) == false)
{
objQxUsers4SynchEN.dicFldComparisonOp.Add(conQxUsers4Synch.IsExistUserInCurr, strComparisonOp);
}
else
{
objQxUsers4SynchEN.dicFldComparisonOp[conQxUsers4Synch.IsExistUserInCurr] = strComparisonOp;
}
}
return objQxUsers4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsers4SynchEN SetIsSamePwd(this clsQxUsers4SynchEN objQxUsers4SynchEN, bool bolIsSamePwd, string strComparisonOp="")
	{
objQxUsers4SynchEN.IsSamePwd = bolIsSamePwd; //是否相同密码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsers4SynchEN.dicFldComparisonOp.ContainsKey(conQxUsers4Synch.IsSamePwd) == false)
{
objQxUsers4SynchEN.dicFldComparisonOp.Add(conQxUsers4Synch.IsSamePwd, strComparisonOp);
}
else
{
objQxUsers4SynchEN.dicFldComparisonOp[conQxUsers4Synch.IsSamePwd] = strComparisonOp;
}
}
return objQxUsers4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsers4SynchEN SetUpdDate(this clsQxUsers4SynchEN objQxUsers4SynchEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQxUsers4Synch.UpdDate);
}
objQxUsers4SynchEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsers4SynchEN.dicFldComparisonOp.ContainsKey(conQxUsers4Synch.UpdDate) == false)
{
objQxUsers4SynchEN.dicFldComparisonOp.Add(conQxUsers4Synch.UpdDate, strComparisonOp);
}
else
{
objQxUsers4SynchEN.dicFldComparisonOp[conQxUsers4Synch.UpdDate] = strComparisonOp;
}
}
return objQxUsers4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsers4SynchEN SetUpdUser(this clsQxUsers4SynchEN objQxUsers4SynchEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conQxUsers4Synch.UpdUser);
}
objQxUsers4SynchEN.UpdUser = strUpdUser; //修改用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsers4SynchEN.dicFldComparisonOp.ContainsKey(conQxUsers4Synch.UpdUser) == false)
{
objQxUsers4SynchEN.dicFldComparisonOp.Add(conQxUsers4Synch.UpdUser, strComparisonOp);
}
else
{
objQxUsers4SynchEN.dicFldComparisonOp[conQxUsers4Synch.UpdUser] = strComparisonOp;
}
}
return objQxUsers4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsers4SynchEN SetMemo(this clsQxUsers4SynchEN objQxUsers4SynchEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQxUsers4Synch.Memo);
}
objQxUsers4SynchEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsers4SynchEN.dicFldComparisonOp.ContainsKey(conQxUsers4Synch.Memo) == false)
{
objQxUsers4SynchEN.dicFldComparisonOp.Add(conQxUsers4Synch.Memo, strComparisonOp);
}
else
{
objQxUsers4SynchEN.dicFldComparisonOp[conQxUsers4Synch.Memo] = strComparisonOp;
}
}
return objQxUsers4SynchEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsQxUsers4SynchEN objQxUsers4SynchEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objQxUsers4SynchEN.CheckPropertyNew();
clsQxUsers4SynchEN objQxUsers4SynchCond = new clsQxUsers4SynchEN();
string strCondition = objQxUsers4SynchCond
.SetmId(objQxUsers4SynchEN.mId, "<>")
.SetIpAddress(objQxUsers4SynchEN.IpAddress, "=")
.SetUserId(objQxUsers4SynchEN.UserId, "=")
.GetCombineCondition();
objQxUsers4SynchEN._IsCheckProperty = true;
bool bolIsExist = clsQxUsers4SynchBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(IpAddress_UserId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objQxUsers4SynchEN.Update();
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
 /// <param name = "objQxUsers4Synch">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsQxUsers4SynchEN objQxUsers4Synch)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsQxUsers4SynchEN objQxUsers4SynchCond = new clsQxUsers4SynchEN();
string strCondition = objQxUsers4SynchCond
.SetIpAddress(objQxUsers4Synch.IpAddress, "=")
.SetUserId(objQxUsers4Synch.UserId, "=")
.GetCombineCondition();
objQxUsers4Synch._IsCheckProperty = true;
bool bolIsExist = clsQxUsers4SynchBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objQxUsers4Synch.mId = clsQxUsers4SynchBL.GetFirstID_S(strCondition);
objQxUsers4Synch.UpdateWithCondition(strCondition);
}
else
{
objQxUsers4Synch.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxUsers4SynchEN objQxUsers4SynchEN)
{
 if (objQxUsers4SynchEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxUsers4SynchBL.QxUsers4SynchDA.UpdateBySql2(objQxUsers4SynchEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsers4SynchBL.ReFreshCache();

if (clsQxUsers4SynchBL.relatedActions != null)
{
clsQxUsers4SynchBL.relatedActions.UpdRelaTabDate(objQxUsers4SynchEN.mId, objQxUsers4SynchEN.UpdUser);
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
 /// <param name = "objQxUsers4SynchEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxUsers4SynchEN objQxUsers4SynchEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objQxUsers4SynchEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxUsers4SynchBL.QxUsers4SynchDA.UpdateBySql2(objQxUsers4SynchEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsers4SynchBL.ReFreshCache();

if (clsQxUsers4SynchBL.relatedActions != null)
{
clsQxUsers4SynchBL.relatedActions.UpdRelaTabDate(objQxUsers4SynchEN.mId, objQxUsers4SynchEN.UpdUser);
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
 /// <param name = "objQxUsers4SynchEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxUsers4SynchEN objQxUsers4SynchEN, string strWhereCond)
{
try
{
bool bolResult = clsQxUsers4SynchBL.QxUsers4SynchDA.UpdateBySqlWithCondition(objQxUsers4SynchEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsers4SynchBL.ReFreshCache();

if (clsQxUsers4SynchBL.relatedActions != null)
{
clsQxUsers4SynchBL.relatedActions.UpdRelaTabDate(objQxUsers4SynchEN.mId, objQxUsers4SynchEN.UpdUser);
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
 /// <param name = "objQxUsers4SynchEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxUsers4SynchEN objQxUsers4SynchEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsQxUsers4SynchBL.QxUsers4SynchDA.UpdateBySqlWithConditionTransaction(objQxUsers4SynchEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsers4SynchBL.ReFreshCache();

if (clsQxUsers4SynchBL.relatedActions != null)
{
clsQxUsers4SynchBL.relatedActions.UpdRelaTabDate(objQxUsers4SynchEN.mId, objQxUsers4SynchEN.UpdUser);
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
public static int Delete(this clsQxUsers4SynchEN objQxUsers4SynchEN)
{
try
{
int intRecNum = clsQxUsers4SynchBL.QxUsers4SynchDA.DelRecord(objQxUsers4SynchEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsers4SynchBL.ReFreshCache();

if (clsQxUsers4SynchBL.relatedActions != null)
{
clsQxUsers4SynchBL.relatedActions.UpdRelaTabDate(objQxUsers4SynchEN.mId, objQxUsers4SynchEN.UpdUser);
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
 /// <param name = "objQxUsers4SynchENS">源对象</param>
 /// <param name = "objQxUsers4SynchENT">目标对象</param>
 public static void CopyTo(this clsQxUsers4SynchEN objQxUsers4SynchENS, clsQxUsers4SynchEN objQxUsers4SynchENT)
{
try
{
objQxUsers4SynchENT.mId = objQxUsers4SynchENS.mId; //流水号
objQxUsers4SynchENT.IpAddress = objQxUsers4SynchENS.IpAddress; //IP地址
objQxUsers4SynchENT.UserId = objQxUsers4SynchENS.UserId; //用户ID
objQxUsers4SynchENT.UserName = objQxUsers4SynchENS.UserName; //用户名
objQxUsers4SynchENT.UserStateId = objQxUsers4SynchENS.UserStateId; //用户状态Id
objQxUsers4SynchENT.OpenId = objQxUsers4SynchENS.OpenId; //微信openid
objQxUsers4SynchENT.IdentityId = objQxUsers4SynchENS.IdentityId; //身份编号
objQxUsers4SynchENT.StuTeacherId = objQxUsers4SynchENS.StuTeacherId; //学工号
objQxUsers4SynchENT.Password = objQxUsers4SynchENS.Password; //口令
objQxUsers4SynchENT.PhoneNumber = objQxUsers4SynchENS.PhoneNumber; //电话号码
objQxUsers4SynchENT.DepartmentId = objQxUsers4SynchENS.DepartmentId; //部门Id
objQxUsers4SynchENT.IdXzCollege = objQxUsers4SynchENS.IdXzCollege; //IdXzCollege
objQxUsers4SynchENT.EffitiveBeginDate = objQxUsers4SynchENS.EffitiveBeginDate; //有效开始日期
objQxUsers4SynchENT.EffitiveEndDate = objQxUsers4SynchENS.EffitiveEndDate; //有效结束日期
objQxUsers4SynchENT.Email = objQxUsers4SynchENS.Email; //邮箱
objQxUsers4SynchENT.IsArchive = objQxUsers4SynchENS.IsArchive; //是否存档
objQxUsers4SynchENT.IsAccessSynch = objQxUsers4SynchENS.IsAccessSynch; //是否处理同步
objQxUsers4SynchENT.AccessSynchDate = objQxUsers4SynchENS.AccessSynchDate; //处理同步日期
objQxUsers4SynchENT.IsExistUserInCurr = objQxUsers4SynchENS.IsExistUserInCurr; //当前是否存在用户
objQxUsers4SynchENT.IsSamePwd = objQxUsers4SynchENS.IsSamePwd; //是否相同密码
objQxUsers4SynchENT.UpdDate = objQxUsers4SynchENS.UpdDate; //修改日期
objQxUsers4SynchENT.UpdUser = objQxUsers4SynchENS.UpdUser; //修改用户
objQxUsers4SynchENT.Memo = objQxUsers4SynchENS.Memo; //备注
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
 /// <param name = "objQxUsers4SynchENS">源对象</param>
 /// <returns>目标对象=>clsQxUsers4SynchEN:objQxUsers4SynchENT</returns>
 public static clsQxUsers4SynchEN CopyTo(this clsQxUsers4SynchEN objQxUsers4SynchENS)
{
try
{
 clsQxUsers4SynchEN objQxUsers4SynchENT = new clsQxUsers4SynchEN()
{
mId = objQxUsers4SynchENS.mId, //流水号
IpAddress = objQxUsers4SynchENS.IpAddress, //IP地址
UserId = objQxUsers4SynchENS.UserId, //用户ID
UserName = objQxUsers4SynchENS.UserName, //用户名
UserStateId = objQxUsers4SynchENS.UserStateId, //用户状态Id
OpenId = objQxUsers4SynchENS.OpenId, //微信openid
IdentityId = objQxUsers4SynchENS.IdentityId, //身份编号
StuTeacherId = objQxUsers4SynchENS.StuTeacherId, //学工号
Password = objQxUsers4SynchENS.Password, //口令
PhoneNumber = objQxUsers4SynchENS.PhoneNumber, //电话号码
DepartmentId = objQxUsers4SynchENS.DepartmentId, //部门Id
IdXzCollege = objQxUsers4SynchENS.IdXzCollege, //IdXzCollege
EffitiveBeginDate = objQxUsers4SynchENS.EffitiveBeginDate, //有效开始日期
EffitiveEndDate = objQxUsers4SynchENS.EffitiveEndDate, //有效结束日期
Email = objQxUsers4SynchENS.Email, //邮箱
IsArchive = objQxUsers4SynchENS.IsArchive, //是否存档
IsAccessSynch = objQxUsers4SynchENS.IsAccessSynch, //是否处理同步
AccessSynchDate = objQxUsers4SynchENS.AccessSynchDate, //处理同步日期
IsExistUserInCurr = objQxUsers4SynchENS.IsExistUserInCurr, //当前是否存在用户
IsSamePwd = objQxUsers4SynchENS.IsSamePwd, //是否相同密码
UpdDate = objQxUsers4SynchENS.UpdDate, //修改日期
UpdUser = objQxUsers4SynchENS.UpdUser, //修改用户
Memo = objQxUsers4SynchENS.Memo, //备注
};
 return objQxUsers4SynchENT;
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
public static void CheckPropertyNew(this clsQxUsers4SynchEN objQxUsers4SynchEN)
{
 clsQxUsers4SynchBL.QxUsers4SynchDA.CheckPropertyNew(objQxUsers4SynchEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsQxUsers4SynchEN objQxUsers4SynchEN)
{
 clsQxUsers4SynchBL.QxUsers4SynchDA.CheckProperty4Condition(objQxUsers4SynchEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQxUsers4SynchEN objQxUsers4SynchCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQxUsers4SynchCond.IsUpdated(conQxUsers4Synch.mId) == true)
{
string strComparisonOpmId = objQxUsers4SynchCond.dicFldComparisonOp[conQxUsers4Synch.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conQxUsers4Synch.mId, objQxUsers4SynchCond.mId, strComparisonOpmId);
}
if (objQxUsers4SynchCond.IsUpdated(conQxUsers4Synch.IpAddress) == true)
{
string strComparisonOpIpAddress = objQxUsers4SynchCond.dicFldComparisonOp[conQxUsers4Synch.IpAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers4Synch.IpAddress, objQxUsers4SynchCond.IpAddress, strComparisonOpIpAddress);
}
if (objQxUsers4SynchCond.IsUpdated(conQxUsers4Synch.UserId) == true)
{
string strComparisonOpUserId = objQxUsers4SynchCond.dicFldComparisonOp[conQxUsers4Synch.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers4Synch.UserId, objQxUsers4SynchCond.UserId, strComparisonOpUserId);
}
if (objQxUsers4SynchCond.IsUpdated(conQxUsers4Synch.UserName) == true)
{
string strComparisonOpUserName = objQxUsers4SynchCond.dicFldComparisonOp[conQxUsers4Synch.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers4Synch.UserName, objQxUsers4SynchCond.UserName, strComparisonOpUserName);
}
if (objQxUsers4SynchCond.IsUpdated(conQxUsers4Synch.UserStateId) == true)
{
string strComparisonOpUserStateId = objQxUsers4SynchCond.dicFldComparisonOp[conQxUsers4Synch.UserStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers4Synch.UserStateId, objQxUsers4SynchCond.UserStateId, strComparisonOpUserStateId);
}
if (objQxUsers4SynchCond.IsUpdated(conQxUsers4Synch.OpenId) == true)
{
string strComparisonOpOpenId = objQxUsers4SynchCond.dicFldComparisonOp[conQxUsers4Synch.OpenId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers4Synch.OpenId, objQxUsers4SynchCond.OpenId, strComparisonOpOpenId);
}
if (objQxUsers4SynchCond.IsUpdated(conQxUsers4Synch.IdentityId) == true)
{
string strComparisonOpIdentityId = objQxUsers4SynchCond.dicFldComparisonOp[conQxUsers4Synch.IdentityId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers4Synch.IdentityId, objQxUsers4SynchCond.IdentityId, strComparisonOpIdentityId);
}
if (objQxUsers4SynchCond.IsUpdated(conQxUsers4Synch.StuTeacherId) == true)
{
string strComparisonOpStuTeacherId = objQxUsers4SynchCond.dicFldComparisonOp[conQxUsers4Synch.StuTeacherId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers4Synch.StuTeacherId, objQxUsers4SynchCond.StuTeacherId, strComparisonOpStuTeacherId);
}
if (objQxUsers4SynchCond.IsUpdated(conQxUsers4Synch.Password) == true)
{
string strComparisonOpPassword = objQxUsers4SynchCond.dicFldComparisonOp[conQxUsers4Synch.Password];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers4Synch.Password, objQxUsers4SynchCond.Password, strComparisonOpPassword);
}
if (objQxUsers4SynchCond.IsUpdated(conQxUsers4Synch.PhoneNumber) == true)
{
string strComparisonOpPhoneNumber = objQxUsers4SynchCond.dicFldComparisonOp[conQxUsers4Synch.PhoneNumber];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers4Synch.PhoneNumber, objQxUsers4SynchCond.PhoneNumber, strComparisonOpPhoneNumber);
}
if (objQxUsers4SynchCond.IsUpdated(conQxUsers4Synch.DepartmentId) == true)
{
string strComparisonOpDepartmentId = objQxUsers4SynchCond.dicFldComparisonOp[conQxUsers4Synch.DepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers4Synch.DepartmentId, objQxUsers4SynchCond.DepartmentId, strComparisonOpDepartmentId);
}
if (objQxUsers4SynchCond.IsUpdated(conQxUsers4Synch.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objQxUsers4SynchCond.dicFldComparisonOp[conQxUsers4Synch.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers4Synch.IdXzCollege, objQxUsers4SynchCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objQxUsers4SynchCond.IsUpdated(conQxUsers4Synch.EffitiveBeginDate) == true)
{
string strComparisonOpEffitiveBeginDate = objQxUsers4SynchCond.dicFldComparisonOp[conQxUsers4Synch.EffitiveBeginDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers4Synch.EffitiveBeginDate, objQxUsers4SynchCond.EffitiveBeginDate, strComparisonOpEffitiveBeginDate);
}
if (objQxUsers4SynchCond.IsUpdated(conQxUsers4Synch.EffitiveEndDate) == true)
{
string strComparisonOpEffitiveEndDate = objQxUsers4SynchCond.dicFldComparisonOp[conQxUsers4Synch.EffitiveEndDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers4Synch.EffitiveEndDate, objQxUsers4SynchCond.EffitiveEndDate, strComparisonOpEffitiveEndDate);
}
if (objQxUsers4SynchCond.IsUpdated(conQxUsers4Synch.Email) == true)
{
string strComparisonOpEmail = objQxUsers4SynchCond.dicFldComparisonOp[conQxUsers4Synch.Email];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers4Synch.Email, objQxUsers4SynchCond.Email, strComparisonOpEmail);
}
if (objQxUsers4SynchCond.IsUpdated(conQxUsers4Synch.IsArchive) == true)
{
if (objQxUsers4SynchCond.IsArchive == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQxUsers4Synch.IsArchive);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQxUsers4Synch.IsArchive);
}
}
if (objQxUsers4SynchCond.IsUpdated(conQxUsers4Synch.IsAccessSynch) == true)
{
if (objQxUsers4SynchCond.IsAccessSynch == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQxUsers4Synch.IsAccessSynch);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQxUsers4Synch.IsAccessSynch);
}
}
if (objQxUsers4SynchCond.IsUpdated(conQxUsers4Synch.AccessSynchDate) == true)
{
string strComparisonOpAccessSynchDate = objQxUsers4SynchCond.dicFldComparisonOp[conQxUsers4Synch.AccessSynchDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers4Synch.AccessSynchDate, objQxUsers4SynchCond.AccessSynchDate, strComparisonOpAccessSynchDate);
}
if (objQxUsers4SynchCond.IsUpdated(conQxUsers4Synch.IsExistUserInCurr) == true)
{
if (objQxUsers4SynchCond.IsExistUserInCurr == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQxUsers4Synch.IsExistUserInCurr);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQxUsers4Synch.IsExistUserInCurr);
}
}
if (objQxUsers4SynchCond.IsUpdated(conQxUsers4Synch.IsSamePwd) == true)
{
if (objQxUsers4SynchCond.IsSamePwd == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQxUsers4Synch.IsSamePwd);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQxUsers4Synch.IsSamePwd);
}
}
if (objQxUsers4SynchCond.IsUpdated(conQxUsers4Synch.UpdDate) == true)
{
string strComparisonOpUpdDate = objQxUsers4SynchCond.dicFldComparisonOp[conQxUsers4Synch.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers4Synch.UpdDate, objQxUsers4SynchCond.UpdDate, strComparisonOpUpdDate);
}
if (objQxUsers4SynchCond.IsUpdated(conQxUsers4Synch.UpdUser) == true)
{
string strComparisonOpUpdUser = objQxUsers4SynchCond.dicFldComparisonOp[conQxUsers4Synch.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers4Synch.UpdUser, objQxUsers4SynchCond.UpdUser, strComparisonOpUpdUser);
}
if (objQxUsers4SynchCond.IsUpdated(conQxUsers4Synch.Memo) == true)
{
string strComparisonOpMemo = objQxUsers4SynchCond.dicFldComparisonOp[conQxUsers4Synch.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers4Synch.Memo, objQxUsers4SynchCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--QxUsers4Synch(用户4同步), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:IpAddress_UserId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsQxUsers4SynchEN objQxUsers4SynchEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objQxUsers4SynchEN == null) return true;
if (objQxUsers4SynchEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objQxUsers4SynchEN.IpAddress == null)
{
 sbCondition.AppendFormat(" and IpAddress is null", objQxUsers4SynchEN.IpAddress);
}
else
{
 sbCondition.AppendFormat(" and IpAddress = '{0}'", objQxUsers4SynchEN.IpAddress);
}
 sbCondition.AppendFormat(" and UserId = '{0}'", objQxUsers4SynchEN.UserId);
if (clsQxUsers4SynchBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objQxUsers4SynchEN.mId);
 sbCondition.AppendFormat(" and IpAddress = '{0}'", objQxUsers4SynchEN.IpAddress);
 sbCondition.AppendFormat(" and UserId = '{0}'", objQxUsers4SynchEN.UserId);
if (clsQxUsers4SynchBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--QxUsers4Synch(用户4同步), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:IpAddress_UserId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsQxUsers4SynchEN objQxUsers4SynchEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objQxUsers4SynchEN == null) return "";
if (objQxUsers4SynchEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objQxUsers4SynchEN.IpAddress == null)
{
 sbCondition.AppendFormat(" and IpAddress is null", objQxUsers4SynchEN.IpAddress);
}
else
{
 sbCondition.AppendFormat(" and IpAddress = '{0}'", objQxUsers4SynchEN.IpAddress);
}
 sbCondition.AppendFormat(" and UserId = '{0}'", objQxUsers4SynchEN.UserId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objQxUsers4SynchEN.mId);
 sbCondition.AppendFormat(" and IpAddress = '{0}'", objQxUsers4SynchEN.IpAddress);
 sbCondition.AppendFormat(" and UserId = '{0}'", objQxUsers4SynchEN.UserId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_QxUsers4Synch
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 用户4同步(QxUsers4Synch)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsQxUsers4SynchBL
{
public static RelatedActions_QxUsers4Synch relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "QxUsers4SynchListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "QxUsers4SynchList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsQxUsers4SynchEN> arrQxUsers4SynchObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsQxUsers4SynchDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsQxUsers4SynchDA QxUsers4SynchDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsQxUsers4SynchDA();
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
 public clsQxUsers4SynchBL()
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
if (string.IsNullOrEmpty(clsQxUsers4SynchEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxUsers4SynchEN._ConnectString);
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
objDS = QxUsers4SynchDA.GetDataSet(strWhereCond);
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
objDS = QxUsers4SynchDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = QxUsers4SynchDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_QxUsers4Synch(string strWhereCond)
{
DataTable objDT;
try
{
objDT = QxUsers4SynchDA.GetDataTable_QxUsers4Synch(strWhereCond);
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
objDT = QxUsers4SynchDA.GetDataTable(strWhereCond);
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
objDT = QxUsers4SynchDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = QxUsers4SynchDA.GetDataTable(strWhereCond, strTabName);
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
objDT = QxUsers4SynchDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = QxUsers4SynchDA.GetDataTable_Top(objTopPara);
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
objDT = QxUsers4SynchDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = QxUsers4SynchDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = QxUsers4SynchDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = QxUsers4SynchDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = QxUsers4SynchDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = QxUsers4SynchDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = QxUsers4SynchDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = QxUsers4SynchDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
public static List<clsQxUsers4SynchEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsQxUsers4SynchEN> arrObjLst = new List<clsQxUsers4SynchEN>(); 
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
	clsQxUsers4SynchEN objQxUsers4SynchEN = new clsQxUsers4SynchEN();
try
{
objQxUsers4SynchEN.mId = Int32.Parse(objRow[conQxUsers4Synch.mId].ToString().Trim()); //流水号
objQxUsers4SynchEN.IpAddress = objRow[conQxUsers4Synch.IpAddress] == DBNull.Value ? null : objRow[conQxUsers4Synch.IpAddress].ToString().Trim(); //IP地址
objQxUsers4SynchEN.UserId = objRow[conQxUsers4Synch.UserId].ToString().Trim(); //用户ID
objQxUsers4SynchEN.UserName = objRow[conQxUsers4Synch.UserName].ToString().Trim(); //用户名
objQxUsers4SynchEN.UserStateId = objRow[conQxUsers4Synch.UserStateId].ToString().Trim(); //用户状态Id
objQxUsers4SynchEN.OpenId = objRow[conQxUsers4Synch.OpenId] == DBNull.Value ? null : objRow[conQxUsers4Synch.OpenId].ToString().Trim(); //微信openid
objQxUsers4SynchEN.IdentityId = objRow[conQxUsers4Synch.IdentityId] == DBNull.Value ? null : objRow[conQxUsers4Synch.IdentityId].ToString().Trim(); //身份编号
objQxUsers4SynchEN.StuTeacherId = objRow[conQxUsers4Synch.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsers4Synch.StuTeacherId].ToString().Trim(); //学工号
objQxUsers4SynchEN.Password = objRow[conQxUsers4Synch.Password].ToString().Trim(); //口令
objQxUsers4SynchEN.PhoneNumber = objRow[conQxUsers4Synch.PhoneNumber] == DBNull.Value ? null : objRow[conQxUsers4Synch.PhoneNumber].ToString().Trim(); //电话号码
objQxUsers4SynchEN.DepartmentId = objRow[conQxUsers4Synch.DepartmentId] == DBNull.Value ? null : objRow[conQxUsers4Synch.DepartmentId].ToString().Trim(); //部门Id
objQxUsers4SynchEN.IdXzCollege = objRow[conQxUsers4Synch.IdXzCollege] == DBNull.Value ? null : objRow[conQxUsers4Synch.IdXzCollege].ToString().Trim(); //IdXzCollege
objQxUsers4SynchEN.EffitiveBeginDate = objRow[conQxUsers4Synch.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objQxUsers4SynchEN.EffitiveEndDate = objRow[conQxUsers4Synch.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.EffitiveEndDate].ToString().Trim(); //有效结束日期
objQxUsers4SynchEN.Email = objRow[conQxUsers4Synch.Email] == DBNull.Value ? null : objRow[conQxUsers4Synch.Email].ToString().Trim(); //邮箱
objQxUsers4SynchEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers4Synch.IsArchive].ToString().Trim()); //是否存档
objQxUsers4SynchEN.IsAccessSynch = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步
objQxUsers4SynchEN.AccessSynchDate = objRow[conQxUsers4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期
objQxUsers4SynchEN.IsExistUserInCurr = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers4Synch.IsExistUserInCurr].ToString().Trim()); //当前是否存在用户
objQxUsers4SynchEN.IsSamePwd = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers4Synch.IsSamePwd].ToString().Trim()); //是否相同密码
objQxUsers4SynchEN.UpdDate = objRow[conQxUsers4Synch.UpdDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.UpdDate].ToString().Trim(); //修改日期
objQxUsers4SynchEN.UpdUser = objRow[conQxUsers4Synch.UpdUser] == DBNull.Value ? null : objRow[conQxUsers4Synch.UpdUser].ToString().Trim(); //修改用户
objQxUsers4SynchEN.Memo = objRow[conQxUsers4Synch.Memo] == DBNull.Value ? null : objRow[conQxUsers4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUsers4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUsers4SynchEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsQxUsers4SynchEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsQxUsers4SynchEN._CurrTabName);
List<clsQxUsers4SynchEN> arrQxUsers4SynchObjLstCache = GetObjLstCache();
IEnumerable <clsQxUsers4SynchEN> arrQxUsers4SynchObjLst_Sel =
arrQxUsers4SynchObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrQxUsers4SynchObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUsers4SynchEN> GetObjLst(string strWhereCond)
{
List<clsQxUsers4SynchEN> arrObjLst = new List<clsQxUsers4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsers4SynchEN objQxUsers4SynchEN = new clsQxUsers4SynchEN();
try
{
objQxUsers4SynchEN.mId = Int32.Parse(objRow[conQxUsers4Synch.mId].ToString().Trim()); //流水号
objQxUsers4SynchEN.IpAddress = objRow[conQxUsers4Synch.IpAddress] == DBNull.Value ? null : objRow[conQxUsers4Synch.IpAddress].ToString().Trim(); //IP地址
objQxUsers4SynchEN.UserId = objRow[conQxUsers4Synch.UserId].ToString().Trim(); //用户ID
objQxUsers4SynchEN.UserName = objRow[conQxUsers4Synch.UserName].ToString().Trim(); //用户名
objQxUsers4SynchEN.UserStateId = objRow[conQxUsers4Synch.UserStateId].ToString().Trim(); //用户状态Id
objQxUsers4SynchEN.OpenId = objRow[conQxUsers4Synch.OpenId] == DBNull.Value ? null : objRow[conQxUsers4Synch.OpenId].ToString().Trim(); //微信openid
objQxUsers4SynchEN.IdentityId = objRow[conQxUsers4Synch.IdentityId] == DBNull.Value ? null : objRow[conQxUsers4Synch.IdentityId].ToString().Trim(); //身份编号
objQxUsers4SynchEN.StuTeacherId = objRow[conQxUsers4Synch.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsers4Synch.StuTeacherId].ToString().Trim(); //学工号
objQxUsers4SynchEN.Password = objRow[conQxUsers4Synch.Password].ToString().Trim(); //口令
objQxUsers4SynchEN.PhoneNumber = objRow[conQxUsers4Synch.PhoneNumber] == DBNull.Value ? null : objRow[conQxUsers4Synch.PhoneNumber].ToString().Trim(); //电话号码
objQxUsers4SynchEN.DepartmentId = objRow[conQxUsers4Synch.DepartmentId] == DBNull.Value ? null : objRow[conQxUsers4Synch.DepartmentId].ToString().Trim(); //部门Id
objQxUsers4SynchEN.IdXzCollege = objRow[conQxUsers4Synch.IdXzCollege] == DBNull.Value ? null : objRow[conQxUsers4Synch.IdXzCollege].ToString().Trim(); //IdXzCollege
objQxUsers4SynchEN.EffitiveBeginDate = objRow[conQxUsers4Synch.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objQxUsers4SynchEN.EffitiveEndDate = objRow[conQxUsers4Synch.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.EffitiveEndDate].ToString().Trim(); //有效结束日期
objQxUsers4SynchEN.Email = objRow[conQxUsers4Synch.Email] == DBNull.Value ? null : objRow[conQxUsers4Synch.Email].ToString().Trim(); //邮箱
objQxUsers4SynchEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers4Synch.IsArchive].ToString().Trim()); //是否存档
objQxUsers4SynchEN.IsAccessSynch = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步
objQxUsers4SynchEN.AccessSynchDate = objRow[conQxUsers4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期
objQxUsers4SynchEN.IsExistUserInCurr = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers4Synch.IsExistUserInCurr].ToString().Trim()); //当前是否存在用户
objQxUsers4SynchEN.IsSamePwd = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers4Synch.IsSamePwd].ToString().Trim()); //是否相同密码
objQxUsers4SynchEN.UpdDate = objRow[conQxUsers4Synch.UpdDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.UpdDate].ToString().Trim(); //修改日期
objQxUsers4SynchEN.UpdUser = objRow[conQxUsers4Synch.UpdUser] == DBNull.Value ? null : objRow[conQxUsers4Synch.UpdUser].ToString().Trim(); //修改用户
objQxUsers4SynchEN.Memo = objRow[conQxUsers4Synch.Memo] == DBNull.Value ? null : objRow[conQxUsers4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUsers4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUsers4SynchEN);
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
public static List<clsQxUsers4SynchEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsQxUsers4SynchEN> arrObjLst = new List<clsQxUsers4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsers4SynchEN objQxUsers4SynchEN = new clsQxUsers4SynchEN();
try
{
objQxUsers4SynchEN.mId = Int32.Parse(objRow[conQxUsers4Synch.mId].ToString().Trim()); //流水号
objQxUsers4SynchEN.IpAddress = objRow[conQxUsers4Synch.IpAddress] == DBNull.Value ? null : objRow[conQxUsers4Synch.IpAddress].ToString().Trim(); //IP地址
objQxUsers4SynchEN.UserId = objRow[conQxUsers4Synch.UserId].ToString().Trim(); //用户ID
objQxUsers4SynchEN.UserName = objRow[conQxUsers4Synch.UserName].ToString().Trim(); //用户名
objQxUsers4SynchEN.UserStateId = objRow[conQxUsers4Synch.UserStateId].ToString().Trim(); //用户状态Id
objQxUsers4SynchEN.OpenId = objRow[conQxUsers4Synch.OpenId] == DBNull.Value ? null : objRow[conQxUsers4Synch.OpenId].ToString().Trim(); //微信openid
objQxUsers4SynchEN.IdentityId = objRow[conQxUsers4Synch.IdentityId] == DBNull.Value ? null : objRow[conQxUsers4Synch.IdentityId].ToString().Trim(); //身份编号
objQxUsers4SynchEN.StuTeacherId = objRow[conQxUsers4Synch.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsers4Synch.StuTeacherId].ToString().Trim(); //学工号
objQxUsers4SynchEN.Password = objRow[conQxUsers4Synch.Password].ToString().Trim(); //口令
objQxUsers4SynchEN.PhoneNumber = objRow[conQxUsers4Synch.PhoneNumber] == DBNull.Value ? null : objRow[conQxUsers4Synch.PhoneNumber].ToString().Trim(); //电话号码
objQxUsers4SynchEN.DepartmentId = objRow[conQxUsers4Synch.DepartmentId] == DBNull.Value ? null : objRow[conQxUsers4Synch.DepartmentId].ToString().Trim(); //部门Id
objQxUsers4SynchEN.IdXzCollege = objRow[conQxUsers4Synch.IdXzCollege] == DBNull.Value ? null : objRow[conQxUsers4Synch.IdXzCollege].ToString().Trim(); //IdXzCollege
objQxUsers4SynchEN.EffitiveBeginDate = objRow[conQxUsers4Synch.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objQxUsers4SynchEN.EffitiveEndDate = objRow[conQxUsers4Synch.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.EffitiveEndDate].ToString().Trim(); //有效结束日期
objQxUsers4SynchEN.Email = objRow[conQxUsers4Synch.Email] == DBNull.Value ? null : objRow[conQxUsers4Synch.Email].ToString().Trim(); //邮箱
objQxUsers4SynchEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers4Synch.IsArchive].ToString().Trim()); //是否存档
objQxUsers4SynchEN.IsAccessSynch = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步
objQxUsers4SynchEN.AccessSynchDate = objRow[conQxUsers4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期
objQxUsers4SynchEN.IsExistUserInCurr = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers4Synch.IsExistUserInCurr].ToString().Trim()); //当前是否存在用户
objQxUsers4SynchEN.IsSamePwd = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers4Synch.IsSamePwd].ToString().Trim()); //是否相同密码
objQxUsers4SynchEN.UpdDate = objRow[conQxUsers4Synch.UpdDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.UpdDate].ToString().Trim(); //修改日期
objQxUsers4SynchEN.UpdUser = objRow[conQxUsers4Synch.UpdUser] == DBNull.Value ? null : objRow[conQxUsers4Synch.UpdUser].ToString().Trim(); //修改用户
objQxUsers4SynchEN.Memo = objRow[conQxUsers4Synch.Memo] == DBNull.Value ? null : objRow[conQxUsers4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUsers4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUsers4SynchEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objQxUsers4SynchCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsQxUsers4SynchEN> GetSubObjLstCache(clsQxUsers4SynchEN objQxUsers4SynchCond)
{
List<clsQxUsers4SynchEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxUsers4SynchEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxUsers4Synch.AttributeName)
{
if (objQxUsers4SynchCond.IsUpdated(strFldName) == false) continue;
if (objQxUsers4SynchCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUsers4SynchCond[strFldName].ToString());
}
else
{
if (objQxUsers4SynchCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxUsers4SynchCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUsers4SynchCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxUsers4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxUsers4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxUsers4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxUsers4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxUsers4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxUsers4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxUsers4SynchCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxUsers4SynchCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxUsers4SynchCond[strFldName]));
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
public static List<clsQxUsers4SynchEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsQxUsers4SynchEN> arrObjLst = new List<clsQxUsers4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsers4SynchEN objQxUsers4SynchEN = new clsQxUsers4SynchEN();
try
{
objQxUsers4SynchEN.mId = Int32.Parse(objRow[conQxUsers4Synch.mId].ToString().Trim()); //流水号
objQxUsers4SynchEN.IpAddress = objRow[conQxUsers4Synch.IpAddress] == DBNull.Value ? null : objRow[conQxUsers4Synch.IpAddress].ToString().Trim(); //IP地址
objQxUsers4SynchEN.UserId = objRow[conQxUsers4Synch.UserId].ToString().Trim(); //用户ID
objQxUsers4SynchEN.UserName = objRow[conQxUsers4Synch.UserName].ToString().Trim(); //用户名
objQxUsers4SynchEN.UserStateId = objRow[conQxUsers4Synch.UserStateId].ToString().Trim(); //用户状态Id
objQxUsers4SynchEN.OpenId = objRow[conQxUsers4Synch.OpenId] == DBNull.Value ? null : objRow[conQxUsers4Synch.OpenId].ToString().Trim(); //微信openid
objQxUsers4SynchEN.IdentityId = objRow[conQxUsers4Synch.IdentityId] == DBNull.Value ? null : objRow[conQxUsers4Synch.IdentityId].ToString().Trim(); //身份编号
objQxUsers4SynchEN.StuTeacherId = objRow[conQxUsers4Synch.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsers4Synch.StuTeacherId].ToString().Trim(); //学工号
objQxUsers4SynchEN.Password = objRow[conQxUsers4Synch.Password].ToString().Trim(); //口令
objQxUsers4SynchEN.PhoneNumber = objRow[conQxUsers4Synch.PhoneNumber] == DBNull.Value ? null : objRow[conQxUsers4Synch.PhoneNumber].ToString().Trim(); //电话号码
objQxUsers4SynchEN.DepartmentId = objRow[conQxUsers4Synch.DepartmentId] == DBNull.Value ? null : objRow[conQxUsers4Synch.DepartmentId].ToString().Trim(); //部门Id
objQxUsers4SynchEN.IdXzCollege = objRow[conQxUsers4Synch.IdXzCollege] == DBNull.Value ? null : objRow[conQxUsers4Synch.IdXzCollege].ToString().Trim(); //IdXzCollege
objQxUsers4SynchEN.EffitiveBeginDate = objRow[conQxUsers4Synch.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objQxUsers4SynchEN.EffitiveEndDate = objRow[conQxUsers4Synch.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.EffitiveEndDate].ToString().Trim(); //有效结束日期
objQxUsers4SynchEN.Email = objRow[conQxUsers4Synch.Email] == DBNull.Value ? null : objRow[conQxUsers4Synch.Email].ToString().Trim(); //邮箱
objQxUsers4SynchEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers4Synch.IsArchive].ToString().Trim()); //是否存档
objQxUsers4SynchEN.IsAccessSynch = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步
objQxUsers4SynchEN.AccessSynchDate = objRow[conQxUsers4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期
objQxUsers4SynchEN.IsExistUserInCurr = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers4Synch.IsExistUserInCurr].ToString().Trim()); //当前是否存在用户
objQxUsers4SynchEN.IsSamePwd = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers4Synch.IsSamePwd].ToString().Trim()); //是否相同密码
objQxUsers4SynchEN.UpdDate = objRow[conQxUsers4Synch.UpdDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.UpdDate].ToString().Trim(); //修改日期
objQxUsers4SynchEN.UpdUser = objRow[conQxUsers4Synch.UpdUser] == DBNull.Value ? null : objRow[conQxUsers4Synch.UpdUser].ToString().Trim(); //修改用户
objQxUsers4SynchEN.Memo = objRow[conQxUsers4Synch.Memo] == DBNull.Value ? null : objRow[conQxUsers4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUsers4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUsers4SynchEN);
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
public static List<clsQxUsers4SynchEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsQxUsers4SynchEN> arrObjLst = new List<clsQxUsers4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsers4SynchEN objQxUsers4SynchEN = new clsQxUsers4SynchEN();
try
{
objQxUsers4SynchEN.mId = Int32.Parse(objRow[conQxUsers4Synch.mId].ToString().Trim()); //流水号
objQxUsers4SynchEN.IpAddress = objRow[conQxUsers4Synch.IpAddress] == DBNull.Value ? null : objRow[conQxUsers4Synch.IpAddress].ToString().Trim(); //IP地址
objQxUsers4SynchEN.UserId = objRow[conQxUsers4Synch.UserId].ToString().Trim(); //用户ID
objQxUsers4SynchEN.UserName = objRow[conQxUsers4Synch.UserName].ToString().Trim(); //用户名
objQxUsers4SynchEN.UserStateId = objRow[conQxUsers4Synch.UserStateId].ToString().Trim(); //用户状态Id
objQxUsers4SynchEN.OpenId = objRow[conQxUsers4Synch.OpenId] == DBNull.Value ? null : objRow[conQxUsers4Synch.OpenId].ToString().Trim(); //微信openid
objQxUsers4SynchEN.IdentityId = objRow[conQxUsers4Synch.IdentityId] == DBNull.Value ? null : objRow[conQxUsers4Synch.IdentityId].ToString().Trim(); //身份编号
objQxUsers4SynchEN.StuTeacherId = objRow[conQxUsers4Synch.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsers4Synch.StuTeacherId].ToString().Trim(); //学工号
objQxUsers4SynchEN.Password = objRow[conQxUsers4Synch.Password].ToString().Trim(); //口令
objQxUsers4SynchEN.PhoneNumber = objRow[conQxUsers4Synch.PhoneNumber] == DBNull.Value ? null : objRow[conQxUsers4Synch.PhoneNumber].ToString().Trim(); //电话号码
objQxUsers4SynchEN.DepartmentId = objRow[conQxUsers4Synch.DepartmentId] == DBNull.Value ? null : objRow[conQxUsers4Synch.DepartmentId].ToString().Trim(); //部门Id
objQxUsers4SynchEN.IdXzCollege = objRow[conQxUsers4Synch.IdXzCollege] == DBNull.Value ? null : objRow[conQxUsers4Synch.IdXzCollege].ToString().Trim(); //IdXzCollege
objQxUsers4SynchEN.EffitiveBeginDate = objRow[conQxUsers4Synch.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objQxUsers4SynchEN.EffitiveEndDate = objRow[conQxUsers4Synch.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.EffitiveEndDate].ToString().Trim(); //有效结束日期
objQxUsers4SynchEN.Email = objRow[conQxUsers4Synch.Email] == DBNull.Value ? null : objRow[conQxUsers4Synch.Email].ToString().Trim(); //邮箱
objQxUsers4SynchEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers4Synch.IsArchive].ToString().Trim()); //是否存档
objQxUsers4SynchEN.IsAccessSynch = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步
objQxUsers4SynchEN.AccessSynchDate = objRow[conQxUsers4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期
objQxUsers4SynchEN.IsExistUserInCurr = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers4Synch.IsExistUserInCurr].ToString().Trim()); //当前是否存在用户
objQxUsers4SynchEN.IsSamePwd = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers4Synch.IsSamePwd].ToString().Trim()); //是否相同密码
objQxUsers4SynchEN.UpdDate = objRow[conQxUsers4Synch.UpdDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.UpdDate].ToString().Trim(); //修改日期
objQxUsers4SynchEN.UpdUser = objRow[conQxUsers4Synch.UpdUser] == DBNull.Value ? null : objRow[conQxUsers4Synch.UpdUser].ToString().Trim(); //修改用户
objQxUsers4SynchEN.Memo = objRow[conQxUsers4Synch.Memo] == DBNull.Value ? null : objRow[conQxUsers4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUsers4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUsers4SynchEN);
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
List<clsQxUsers4SynchEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsQxUsers4SynchEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUsers4SynchEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsQxUsers4SynchEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsQxUsers4SynchEN> arrObjLst = new List<clsQxUsers4SynchEN>(); 
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
	clsQxUsers4SynchEN objQxUsers4SynchEN = new clsQxUsers4SynchEN();
try
{
objQxUsers4SynchEN.mId = Int32.Parse(objRow[conQxUsers4Synch.mId].ToString().Trim()); //流水号
objQxUsers4SynchEN.IpAddress = objRow[conQxUsers4Synch.IpAddress] == DBNull.Value ? null : objRow[conQxUsers4Synch.IpAddress].ToString().Trim(); //IP地址
objQxUsers4SynchEN.UserId = objRow[conQxUsers4Synch.UserId].ToString().Trim(); //用户ID
objQxUsers4SynchEN.UserName = objRow[conQxUsers4Synch.UserName].ToString().Trim(); //用户名
objQxUsers4SynchEN.UserStateId = objRow[conQxUsers4Synch.UserStateId].ToString().Trim(); //用户状态Id
objQxUsers4SynchEN.OpenId = objRow[conQxUsers4Synch.OpenId] == DBNull.Value ? null : objRow[conQxUsers4Synch.OpenId].ToString().Trim(); //微信openid
objQxUsers4SynchEN.IdentityId = objRow[conQxUsers4Synch.IdentityId] == DBNull.Value ? null : objRow[conQxUsers4Synch.IdentityId].ToString().Trim(); //身份编号
objQxUsers4SynchEN.StuTeacherId = objRow[conQxUsers4Synch.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsers4Synch.StuTeacherId].ToString().Trim(); //学工号
objQxUsers4SynchEN.Password = objRow[conQxUsers4Synch.Password].ToString().Trim(); //口令
objQxUsers4SynchEN.PhoneNumber = objRow[conQxUsers4Synch.PhoneNumber] == DBNull.Value ? null : objRow[conQxUsers4Synch.PhoneNumber].ToString().Trim(); //电话号码
objQxUsers4SynchEN.DepartmentId = objRow[conQxUsers4Synch.DepartmentId] == DBNull.Value ? null : objRow[conQxUsers4Synch.DepartmentId].ToString().Trim(); //部门Id
objQxUsers4SynchEN.IdXzCollege = objRow[conQxUsers4Synch.IdXzCollege] == DBNull.Value ? null : objRow[conQxUsers4Synch.IdXzCollege].ToString().Trim(); //IdXzCollege
objQxUsers4SynchEN.EffitiveBeginDate = objRow[conQxUsers4Synch.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objQxUsers4SynchEN.EffitiveEndDate = objRow[conQxUsers4Synch.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.EffitiveEndDate].ToString().Trim(); //有效结束日期
objQxUsers4SynchEN.Email = objRow[conQxUsers4Synch.Email] == DBNull.Value ? null : objRow[conQxUsers4Synch.Email].ToString().Trim(); //邮箱
objQxUsers4SynchEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers4Synch.IsArchive].ToString().Trim()); //是否存档
objQxUsers4SynchEN.IsAccessSynch = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步
objQxUsers4SynchEN.AccessSynchDate = objRow[conQxUsers4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期
objQxUsers4SynchEN.IsExistUserInCurr = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers4Synch.IsExistUserInCurr].ToString().Trim()); //当前是否存在用户
objQxUsers4SynchEN.IsSamePwd = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers4Synch.IsSamePwd].ToString().Trim()); //是否相同密码
objQxUsers4SynchEN.UpdDate = objRow[conQxUsers4Synch.UpdDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.UpdDate].ToString().Trim(); //修改日期
objQxUsers4SynchEN.UpdUser = objRow[conQxUsers4Synch.UpdUser] == DBNull.Value ? null : objRow[conQxUsers4Synch.UpdUser].ToString().Trim(); //修改用户
objQxUsers4SynchEN.Memo = objRow[conQxUsers4Synch.Memo] == DBNull.Value ? null : objRow[conQxUsers4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUsers4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUsers4SynchEN);
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
public static List<clsQxUsers4SynchEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsQxUsers4SynchEN> arrObjLst = new List<clsQxUsers4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsers4SynchEN objQxUsers4SynchEN = new clsQxUsers4SynchEN();
try
{
objQxUsers4SynchEN.mId = Int32.Parse(objRow[conQxUsers4Synch.mId].ToString().Trim()); //流水号
objQxUsers4SynchEN.IpAddress = objRow[conQxUsers4Synch.IpAddress] == DBNull.Value ? null : objRow[conQxUsers4Synch.IpAddress].ToString().Trim(); //IP地址
objQxUsers4SynchEN.UserId = objRow[conQxUsers4Synch.UserId].ToString().Trim(); //用户ID
objQxUsers4SynchEN.UserName = objRow[conQxUsers4Synch.UserName].ToString().Trim(); //用户名
objQxUsers4SynchEN.UserStateId = objRow[conQxUsers4Synch.UserStateId].ToString().Trim(); //用户状态Id
objQxUsers4SynchEN.OpenId = objRow[conQxUsers4Synch.OpenId] == DBNull.Value ? null : objRow[conQxUsers4Synch.OpenId].ToString().Trim(); //微信openid
objQxUsers4SynchEN.IdentityId = objRow[conQxUsers4Synch.IdentityId] == DBNull.Value ? null : objRow[conQxUsers4Synch.IdentityId].ToString().Trim(); //身份编号
objQxUsers4SynchEN.StuTeacherId = objRow[conQxUsers4Synch.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsers4Synch.StuTeacherId].ToString().Trim(); //学工号
objQxUsers4SynchEN.Password = objRow[conQxUsers4Synch.Password].ToString().Trim(); //口令
objQxUsers4SynchEN.PhoneNumber = objRow[conQxUsers4Synch.PhoneNumber] == DBNull.Value ? null : objRow[conQxUsers4Synch.PhoneNumber].ToString().Trim(); //电话号码
objQxUsers4SynchEN.DepartmentId = objRow[conQxUsers4Synch.DepartmentId] == DBNull.Value ? null : objRow[conQxUsers4Synch.DepartmentId].ToString().Trim(); //部门Id
objQxUsers4SynchEN.IdXzCollege = objRow[conQxUsers4Synch.IdXzCollege] == DBNull.Value ? null : objRow[conQxUsers4Synch.IdXzCollege].ToString().Trim(); //IdXzCollege
objQxUsers4SynchEN.EffitiveBeginDate = objRow[conQxUsers4Synch.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objQxUsers4SynchEN.EffitiveEndDate = objRow[conQxUsers4Synch.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.EffitiveEndDate].ToString().Trim(); //有效结束日期
objQxUsers4SynchEN.Email = objRow[conQxUsers4Synch.Email] == DBNull.Value ? null : objRow[conQxUsers4Synch.Email].ToString().Trim(); //邮箱
objQxUsers4SynchEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers4Synch.IsArchive].ToString().Trim()); //是否存档
objQxUsers4SynchEN.IsAccessSynch = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步
objQxUsers4SynchEN.AccessSynchDate = objRow[conQxUsers4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期
objQxUsers4SynchEN.IsExistUserInCurr = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers4Synch.IsExistUserInCurr].ToString().Trim()); //当前是否存在用户
objQxUsers4SynchEN.IsSamePwd = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers4Synch.IsSamePwd].ToString().Trim()); //是否相同密码
objQxUsers4SynchEN.UpdDate = objRow[conQxUsers4Synch.UpdDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.UpdDate].ToString().Trim(); //修改日期
objQxUsers4SynchEN.UpdUser = objRow[conQxUsers4Synch.UpdUser] == DBNull.Value ? null : objRow[conQxUsers4Synch.UpdUser].ToString().Trim(); //修改用户
objQxUsers4SynchEN.Memo = objRow[conQxUsers4Synch.Memo] == DBNull.Value ? null : objRow[conQxUsers4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUsers4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUsers4SynchEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsQxUsers4SynchEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsQxUsers4SynchEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsQxUsers4SynchEN> arrObjLst = new List<clsQxUsers4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsers4SynchEN objQxUsers4SynchEN = new clsQxUsers4SynchEN();
try
{
objQxUsers4SynchEN.mId = Int32.Parse(objRow[conQxUsers4Synch.mId].ToString().Trim()); //流水号
objQxUsers4SynchEN.IpAddress = objRow[conQxUsers4Synch.IpAddress] == DBNull.Value ? null : objRow[conQxUsers4Synch.IpAddress].ToString().Trim(); //IP地址
objQxUsers4SynchEN.UserId = objRow[conQxUsers4Synch.UserId].ToString().Trim(); //用户ID
objQxUsers4SynchEN.UserName = objRow[conQxUsers4Synch.UserName].ToString().Trim(); //用户名
objQxUsers4SynchEN.UserStateId = objRow[conQxUsers4Synch.UserStateId].ToString().Trim(); //用户状态Id
objQxUsers4SynchEN.OpenId = objRow[conQxUsers4Synch.OpenId] == DBNull.Value ? null : objRow[conQxUsers4Synch.OpenId].ToString().Trim(); //微信openid
objQxUsers4SynchEN.IdentityId = objRow[conQxUsers4Synch.IdentityId] == DBNull.Value ? null : objRow[conQxUsers4Synch.IdentityId].ToString().Trim(); //身份编号
objQxUsers4SynchEN.StuTeacherId = objRow[conQxUsers4Synch.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsers4Synch.StuTeacherId].ToString().Trim(); //学工号
objQxUsers4SynchEN.Password = objRow[conQxUsers4Synch.Password].ToString().Trim(); //口令
objQxUsers4SynchEN.PhoneNumber = objRow[conQxUsers4Synch.PhoneNumber] == DBNull.Value ? null : objRow[conQxUsers4Synch.PhoneNumber].ToString().Trim(); //电话号码
objQxUsers4SynchEN.DepartmentId = objRow[conQxUsers4Synch.DepartmentId] == DBNull.Value ? null : objRow[conQxUsers4Synch.DepartmentId].ToString().Trim(); //部门Id
objQxUsers4SynchEN.IdXzCollege = objRow[conQxUsers4Synch.IdXzCollege] == DBNull.Value ? null : objRow[conQxUsers4Synch.IdXzCollege].ToString().Trim(); //IdXzCollege
objQxUsers4SynchEN.EffitiveBeginDate = objRow[conQxUsers4Synch.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objQxUsers4SynchEN.EffitiveEndDate = objRow[conQxUsers4Synch.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.EffitiveEndDate].ToString().Trim(); //有效结束日期
objQxUsers4SynchEN.Email = objRow[conQxUsers4Synch.Email] == DBNull.Value ? null : objRow[conQxUsers4Synch.Email].ToString().Trim(); //邮箱
objQxUsers4SynchEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers4Synch.IsArchive].ToString().Trim()); //是否存档
objQxUsers4SynchEN.IsAccessSynch = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步
objQxUsers4SynchEN.AccessSynchDate = objRow[conQxUsers4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期
objQxUsers4SynchEN.IsExistUserInCurr = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers4Synch.IsExistUserInCurr].ToString().Trim()); //当前是否存在用户
objQxUsers4SynchEN.IsSamePwd = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers4Synch.IsSamePwd].ToString().Trim()); //是否相同密码
objQxUsers4SynchEN.UpdDate = objRow[conQxUsers4Synch.UpdDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.UpdDate].ToString().Trim(); //修改日期
objQxUsers4SynchEN.UpdUser = objRow[conQxUsers4Synch.UpdUser] == DBNull.Value ? null : objRow[conQxUsers4Synch.UpdUser].ToString().Trim(); //修改用户
objQxUsers4SynchEN.Memo = objRow[conQxUsers4Synch.Memo] == DBNull.Value ? null : objRow[conQxUsers4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUsers4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUsers4SynchEN);
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
public static List<clsQxUsers4SynchEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsQxUsers4SynchEN> arrObjLst = new List<clsQxUsers4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsers4SynchEN objQxUsers4SynchEN = new clsQxUsers4SynchEN();
try
{
objQxUsers4SynchEN.mId = Int32.Parse(objRow[conQxUsers4Synch.mId].ToString().Trim()); //流水号
objQxUsers4SynchEN.IpAddress = objRow[conQxUsers4Synch.IpAddress] == DBNull.Value ? null : objRow[conQxUsers4Synch.IpAddress].ToString().Trim(); //IP地址
objQxUsers4SynchEN.UserId = objRow[conQxUsers4Synch.UserId].ToString().Trim(); //用户ID
objQxUsers4SynchEN.UserName = objRow[conQxUsers4Synch.UserName].ToString().Trim(); //用户名
objQxUsers4SynchEN.UserStateId = objRow[conQxUsers4Synch.UserStateId].ToString().Trim(); //用户状态Id
objQxUsers4SynchEN.OpenId = objRow[conQxUsers4Synch.OpenId] == DBNull.Value ? null : objRow[conQxUsers4Synch.OpenId].ToString().Trim(); //微信openid
objQxUsers4SynchEN.IdentityId = objRow[conQxUsers4Synch.IdentityId] == DBNull.Value ? null : objRow[conQxUsers4Synch.IdentityId].ToString().Trim(); //身份编号
objQxUsers4SynchEN.StuTeacherId = objRow[conQxUsers4Synch.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsers4Synch.StuTeacherId].ToString().Trim(); //学工号
objQxUsers4SynchEN.Password = objRow[conQxUsers4Synch.Password].ToString().Trim(); //口令
objQxUsers4SynchEN.PhoneNumber = objRow[conQxUsers4Synch.PhoneNumber] == DBNull.Value ? null : objRow[conQxUsers4Synch.PhoneNumber].ToString().Trim(); //电话号码
objQxUsers4SynchEN.DepartmentId = objRow[conQxUsers4Synch.DepartmentId] == DBNull.Value ? null : objRow[conQxUsers4Synch.DepartmentId].ToString().Trim(); //部门Id
objQxUsers4SynchEN.IdXzCollege = objRow[conQxUsers4Synch.IdXzCollege] == DBNull.Value ? null : objRow[conQxUsers4Synch.IdXzCollege].ToString().Trim(); //IdXzCollege
objQxUsers4SynchEN.EffitiveBeginDate = objRow[conQxUsers4Synch.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objQxUsers4SynchEN.EffitiveEndDate = objRow[conQxUsers4Synch.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.EffitiveEndDate].ToString().Trim(); //有效结束日期
objQxUsers4SynchEN.Email = objRow[conQxUsers4Synch.Email] == DBNull.Value ? null : objRow[conQxUsers4Synch.Email].ToString().Trim(); //邮箱
objQxUsers4SynchEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers4Synch.IsArchive].ToString().Trim()); //是否存档
objQxUsers4SynchEN.IsAccessSynch = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步
objQxUsers4SynchEN.AccessSynchDate = objRow[conQxUsers4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期
objQxUsers4SynchEN.IsExistUserInCurr = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers4Synch.IsExistUserInCurr].ToString().Trim()); //当前是否存在用户
objQxUsers4SynchEN.IsSamePwd = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers4Synch.IsSamePwd].ToString().Trim()); //是否相同密码
objQxUsers4SynchEN.UpdDate = objRow[conQxUsers4Synch.UpdDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.UpdDate].ToString().Trim(); //修改日期
objQxUsers4SynchEN.UpdUser = objRow[conQxUsers4Synch.UpdUser] == DBNull.Value ? null : objRow[conQxUsers4Synch.UpdUser].ToString().Trim(); //修改用户
objQxUsers4SynchEN.Memo = objRow[conQxUsers4Synch.Memo] == DBNull.Value ? null : objRow[conQxUsers4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUsers4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUsers4SynchEN);
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
public static IEnumerable<clsQxUsers4SynchEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsQxUsers4SynchEN objQxUsers4SynchCond, string strOrderBy)
{
List<clsQxUsers4SynchEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxUsers4SynchEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxUsers4Synch.AttributeName)
{
if (objQxUsers4SynchCond.IsUpdated(strFldName) == false) continue;
if (objQxUsers4SynchCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUsers4SynchCond[strFldName].ToString());
}
else
{
if (objQxUsers4SynchCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxUsers4SynchCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUsers4SynchCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxUsers4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxUsers4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxUsers4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxUsers4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxUsers4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxUsers4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxUsers4SynchCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxUsers4SynchCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxUsers4SynchCond[strFldName]));
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
public static IEnumerable<clsQxUsers4SynchEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsQxUsers4SynchEN objQxUsers4SynchCond = JsonConvert.DeserializeObject<clsQxUsers4SynchEN>(objPagerPara.whereCond);
if (objQxUsers4SynchCond.sfFldComparisonOp == null)
{
objQxUsers4SynchCond.dicFldComparisonOp = null;
}
else
{
objQxUsers4SynchCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objQxUsers4SynchCond.sfFldComparisonOp);
}
clsQxUsers4SynchBL.SetUpdFlag(objQxUsers4SynchCond);
 try
{
CheckProperty4Condition(objQxUsers4SynchCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsQxUsers4SynchBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objQxUsers4SynchCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUsers4SynchEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsQxUsers4SynchEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsQxUsers4SynchEN> arrObjLst = new List<clsQxUsers4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsers4SynchEN objQxUsers4SynchEN = new clsQxUsers4SynchEN();
try
{
objQxUsers4SynchEN.mId = Int32.Parse(objRow[conQxUsers4Synch.mId].ToString().Trim()); //流水号
objQxUsers4SynchEN.IpAddress = objRow[conQxUsers4Synch.IpAddress] == DBNull.Value ? null : objRow[conQxUsers4Synch.IpAddress].ToString().Trim(); //IP地址
objQxUsers4SynchEN.UserId = objRow[conQxUsers4Synch.UserId].ToString().Trim(); //用户ID
objQxUsers4SynchEN.UserName = objRow[conQxUsers4Synch.UserName].ToString().Trim(); //用户名
objQxUsers4SynchEN.UserStateId = objRow[conQxUsers4Synch.UserStateId].ToString().Trim(); //用户状态Id
objQxUsers4SynchEN.OpenId = objRow[conQxUsers4Synch.OpenId] == DBNull.Value ? null : objRow[conQxUsers4Synch.OpenId].ToString().Trim(); //微信openid
objQxUsers4SynchEN.IdentityId = objRow[conQxUsers4Synch.IdentityId] == DBNull.Value ? null : objRow[conQxUsers4Synch.IdentityId].ToString().Trim(); //身份编号
objQxUsers4SynchEN.StuTeacherId = objRow[conQxUsers4Synch.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsers4Synch.StuTeacherId].ToString().Trim(); //学工号
objQxUsers4SynchEN.Password = objRow[conQxUsers4Synch.Password].ToString().Trim(); //口令
objQxUsers4SynchEN.PhoneNumber = objRow[conQxUsers4Synch.PhoneNumber] == DBNull.Value ? null : objRow[conQxUsers4Synch.PhoneNumber].ToString().Trim(); //电话号码
objQxUsers4SynchEN.DepartmentId = objRow[conQxUsers4Synch.DepartmentId] == DBNull.Value ? null : objRow[conQxUsers4Synch.DepartmentId].ToString().Trim(); //部门Id
objQxUsers4SynchEN.IdXzCollege = objRow[conQxUsers4Synch.IdXzCollege] == DBNull.Value ? null : objRow[conQxUsers4Synch.IdXzCollege].ToString().Trim(); //IdXzCollege
objQxUsers4SynchEN.EffitiveBeginDate = objRow[conQxUsers4Synch.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objQxUsers4SynchEN.EffitiveEndDate = objRow[conQxUsers4Synch.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.EffitiveEndDate].ToString().Trim(); //有效结束日期
objQxUsers4SynchEN.Email = objRow[conQxUsers4Synch.Email] == DBNull.Value ? null : objRow[conQxUsers4Synch.Email].ToString().Trim(); //邮箱
objQxUsers4SynchEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers4Synch.IsArchive].ToString().Trim()); //是否存档
objQxUsers4SynchEN.IsAccessSynch = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步
objQxUsers4SynchEN.AccessSynchDate = objRow[conQxUsers4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期
objQxUsers4SynchEN.IsExistUserInCurr = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers4Synch.IsExistUserInCurr].ToString().Trim()); //当前是否存在用户
objQxUsers4SynchEN.IsSamePwd = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers4Synch.IsSamePwd].ToString().Trim()); //是否相同密码
objQxUsers4SynchEN.UpdDate = objRow[conQxUsers4Synch.UpdDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.UpdDate].ToString().Trim(); //修改日期
objQxUsers4SynchEN.UpdUser = objRow[conQxUsers4Synch.UpdUser] == DBNull.Value ? null : objRow[conQxUsers4Synch.UpdUser].ToString().Trim(); //修改用户
objQxUsers4SynchEN.Memo = objRow[conQxUsers4Synch.Memo] == DBNull.Value ? null : objRow[conQxUsers4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUsers4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUsers4SynchEN);
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
public static List<clsQxUsers4SynchEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsQxUsers4SynchEN> arrObjLst = new List<clsQxUsers4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsers4SynchEN objQxUsers4SynchEN = new clsQxUsers4SynchEN();
try
{
objQxUsers4SynchEN.mId = Int32.Parse(objRow[conQxUsers4Synch.mId].ToString().Trim()); //流水号
objQxUsers4SynchEN.IpAddress = objRow[conQxUsers4Synch.IpAddress] == DBNull.Value ? null : objRow[conQxUsers4Synch.IpAddress].ToString().Trim(); //IP地址
objQxUsers4SynchEN.UserId = objRow[conQxUsers4Synch.UserId].ToString().Trim(); //用户ID
objQxUsers4SynchEN.UserName = objRow[conQxUsers4Synch.UserName].ToString().Trim(); //用户名
objQxUsers4SynchEN.UserStateId = objRow[conQxUsers4Synch.UserStateId].ToString().Trim(); //用户状态Id
objQxUsers4SynchEN.OpenId = objRow[conQxUsers4Synch.OpenId] == DBNull.Value ? null : objRow[conQxUsers4Synch.OpenId].ToString().Trim(); //微信openid
objQxUsers4SynchEN.IdentityId = objRow[conQxUsers4Synch.IdentityId] == DBNull.Value ? null : objRow[conQxUsers4Synch.IdentityId].ToString().Trim(); //身份编号
objQxUsers4SynchEN.StuTeacherId = objRow[conQxUsers4Synch.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsers4Synch.StuTeacherId].ToString().Trim(); //学工号
objQxUsers4SynchEN.Password = objRow[conQxUsers4Synch.Password].ToString().Trim(); //口令
objQxUsers4SynchEN.PhoneNumber = objRow[conQxUsers4Synch.PhoneNumber] == DBNull.Value ? null : objRow[conQxUsers4Synch.PhoneNumber].ToString().Trim(); //电话号码
objQxUsers4SynchEN.DepartmentId = objRow[conQxUsers4Synch.DepartmentId] == DBNull.Value ? null : objRow[conQxUsers4Synch.DepartmentId].ToString().Trim(); //部门Id
objQxUsers4SynchEN.IdXzCollege = objRow[conQxUsers4Synch.IdXzCollege] == DBNull.Value ? null : objRow[conQxUsers4Synch.IdXzCollege].ToString().Trim(); //IdXzCollege
objQxUsers4SynchEN.EffitiveBeginDate = objRow[conQxUsers4Synch.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objQxUsers4SynchEN.EffitiveEndDate = objRow[conQxUsers4Synch.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.EffitiveEndDate].ToString().Trim(); //有效结束日期
objQxUsers4SynchEN.Email = objRow[conQxUsers4Synch.Email] == DBNull.Value ? null : objRow[conQxUsers4Synch.Email].ToString().Trim(); //邮箱
objQxUsers4SynchEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers4Synch.IsArchive].ToString().Trim()); //是否存档
objQxUsers4SynchEN.IsAccessSynch = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步
objQxUsers4SynchEN.AccessSynchDate = objRow[conQxUsers4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期
objQxUsers4SynchEN.IsExistUserInCurr = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers4Synch.IsExistUserInCurr].ToString().Trim()); //当前是否存在用户
objQxUsers4SynchEN.IsSamePwd = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers4Synch.IsSamePwd].ToString().Trim()); //是否相同密码
objQxUsers4SynchEN.UpdDate = objRow[conQxUsers4Synch.UpdDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.UpdDate].ToString().Trim(); //修改日期
objQxUsers4SynchEN.UpdUser = objRow[conQxUsers4Synch.UpdUser] == DBNull.Value ? null : objRow[conQxUsers4Synch.UpdUser].ToString().Trim(); //修改用户
objQxUsers4SynchEN.Memo = objRow[conQxUsers4Synch.Memo] == DBNull.Value ? null : objRow[conQxUsers4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUsers4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUsers4SynchEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUsers4SynchEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsQxUsers4SynchEN> arrObjLst = new List<clsQxUsers4SynchEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsers4SynchEN objQxUsers4SynchEN = new clsQxUsers4SynchEN();
try
{
objQxUsers4SynchEN.mId = Int32.Parse(objRow[conQxUsers4Synch.mId].ToString().Trim()); //流水号
objQxUsers4SynchEN.IpAddress = objRow[conQxUsers4Synch.IpAddress] == DBNull.Value ? null : objRow[conQxUsers4Synch.IpAddress].ToString().Trim(); //IP地址
objQxUsers4SynchEN.UserId = objRow[conQxUsers4Synch.UserId].ToString().Trim(); //用户ID
objQxUsers4SynchEN.UserName = objRow[conQxUsers4Synch.UserName].ToString().Trim(); //用户名
objQxUsers4SynchEN.UserStateId = objRow[conQxUsers4Synch.UserStateId].ToString().Trim(); //用户状态Id
objQxUsers4SynchEN.OpenId = objRow[conQxUsers4Synch.OpenId] == DBNull.Value ? null : objRow[conQxUsers4Synch.OpenId].ToString().Trim(); //微信openid
objQxUsers4SynchEN.IdentityId = objRow[conQxUsers4Synch.IdentityId] == DBNull.Value ? null : objRow[conQxUsers4Synch.IdentityId].ToString().Trim(); //身份编号
objQxUsers4SynchEN.StuTeacherId = objRow[conQxUsers4Synch.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsers4Synch.StuTeacherId].ToString().Trim(); //学工号
objQxUsers4SynchEN.Password = objRow[conQxUsers4Synch.Password].ToString().Trim(); //口令
objQxUsers4SynchEN.PhoneNumber = objRow[conQxUsers4Synch.PhoneNumber] == DBNull.Value ? null : objRow[conQxUsers4Synch.PhoneNumber].ToString().Trim(); //电话号码
objQxUsers4SynchEN.DepartmentId = objRow[conQxUsers4Synch.DepartmentId] == DBNull.Value ? null : objRow[conQxUsers4Synch.DepartmentId].ToString().Trim(); //部门Id
objQxUsers4SynchEN.IdXzCollege = objRow[conQxUsers4Synch.IdXzCollege] == DBNull.Value ? null : objRow[conQxUsers4Synch.IdXzCollege].ToString().Trim(); //IdXzCollege
objQxUsers4SynchEN.EffitiveBeginDate = objRow[conQxUsers4Synch.EffitiveBeginDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objQxUsers4SynchEN.EffitiveEndDate = objRow[conQxUsers4Synch.EffitiveEndDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.EffitiveEndDate].ToString().Trim(); //有效结束日期
objQxUsers4SynchEN.Email = objRow[conQxUsers4Synch.Email] == DBNull.Value ? null : objRow[conQxUsers4Synch.Email].ToString().Trim(); //邮箱
objQxUsers4SynchEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers4Synch.IsArchive].ToString().Trim()); //是否存档
objQxUsers4SynchEN.IsAccessSynch = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步
objQxUsers4SynchEN.AccessSynchDate = objRow[conQxUsers4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期
objQxUsers4SynchEN.IsExistUserInCurr = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers4Synch.IsExistUserInCurr].ToString().Trim()); //当前是否存在用户
objQxUsers4SynchEN.IsSamePwd = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers4Synch.IsSamePwd].ToString().Trim()); //是否相同密码
objQxUsers4SynchEN.UpdDate = objRow[conQxUsers4Synch.UpdDate] == DBNull.Value ? null : objRow[conQxUsers4Synch.UpdDate].ToString().Trim(); //修改日期
objQxUsers4SynchEN.UpdUser = objRow[conQxUsers4Synch.UpdUser] == DBNull.Value ? null : objRow[conQxUsers4Synch.UpdUser].ToString().Trim(); //修改用户
objQxUsers4SynchEN.Memo = objRow[conQxUsers4Synch.Memo] == DBNull.Value ? null : objRow[conQxUsers4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUsers4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUsers4SynchEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxUsers4Synch(ref clsQxUsers4SynchEN objQxUsers4SynchEN)
{
bool bolResult = QxUsers4SynchDA.GetQxUsers4Synch(ref objQxUsers4SynchEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxUsers4SynchEN GetObjBymId(long lngmId)
{
clsQxUsers4SynchEN objQxUsers4SynchEN = QxUsers4SynchDA.GetObjBymId(lngmId);
return objQxUsers4SynchEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsQxUsers4SynchEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsQxUsers4SynchEN objQxUsers4SynchEN = QxUsers4SynchDA.GetFirstObj(strWhereCond);
 return objQxUsers4SynchEN;
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
public static clsQxUsers4SynchEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsQxUsers4SynchEN objQxUsers4SynchEN = QxUsers4SynchDA.GetObjByDataRow(objRow);
 return objQxUsers4SynchEN;
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
public static clsQxUsers4SynchEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsQxUsers4SynchEN objQxUsers4SynchEN = QxUsers4SynchDA.GetObjByDataRow(objRow);
 return objQxUsers4SynchEN;
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
 /// <param name = "lstQxUsers4SynchObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxUsers4SynchEN GetObjBymIdFromList(long lngmId, List<clsQxUsers4SynchEN> lstQxUsers4SynchObjLst)
{
foreach (clsQxUsers4SynchEN objQxUsers4SynchEN in lstQxUsers4SynchObjLst)
{
if (objQxUsers4SynchEN.mId == lngmId)
{
return objQxUsers4SynchEN;
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
 lngmId = new clsQxUsers4SynchDA().GetFirstID(strWhereCond);
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
 arrList = QxUsers4SynchDA.GetID(strWhereCond);
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
bool bolIsExist = QxUsers4SynchDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = QxUsers4SynchDA.IsExist(lngmId);
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
clsQxUsers4SynchEN objQxUsers4SynchEN = clsQxUsers4SynchBL.GetObjBymId(lngmId);
objQxUsers4SynchEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objQxUsers4SynchEN.UpdUser = strOpUser;
return clsQxUsers4SynchBL.UpdateBySql2(objQxUsers4SynchEN);
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
 bolIsExist = clsQxUsers4SynchDA.IsExistTable();
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
 bolIsExist = QxUsers4SynchDA.IsExistTable(strTabName);
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
 /// <param name = "objQxUsers4SynchEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsQxUsers4SynchEN objQxUsers4SynchEN)
{
if (objQxUsers4SynchEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!IP地址 = [{0}],用户ID = [{1}]的数据已经存在!(in clsQxUsers4SynchBL.AddNewRecordBySql2)", objQxUsers4SynchEN.IpAddress,objQxUsers4SynchEN.UserId);
throw new Exception(strMsg);
}
try
{
bool bolResult = QxUsers4SynchDA.AddNewRecordBySQL2(objQxUsers4SynchEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsers4SynchBL.ReFreshCache();

if (clsQxUsers4SynchBL.relatedActions != null)
{
clsQxUsers4SynchBL.relatedActions.UpdRelaTabDate(objQxUsers4SynchEN.mId, objQxUsers4SynchEN.UpdUser);
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
 /// <param name = "objQxUsers4SynchEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsQxUsers4SynchEN objQxUsers4SynchEN)
{
if (objQxUsers4SynchEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!IP地址 = [{0}],用户ID = [{1}]的数据已经存在!(in clsQxUsers4SynchBL.AddNewRecordBySql2WithReturnKey)", objQxUsers4SynchEN.IpAddress,objQxUsers4SynchEN.UserId);
throw new Exception(strMsg);
}
try
{
string strKey = QxUsers4SynchDA.AddNewRecordBySQL2WithReturnKey(objQxUsers4SynchEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsers4SynchBL.ReFreshCache();

if (clsQxUsers4SynchBL.relatedActions != null)
{
clsQxUsers4SynchBL.relatedActions.UpdRelaTabDate(objQxUsers4SynchEN.mId, objQxUsers4SynchEN.UpdUser);
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
 /// <param name = "strQxUsers4SynchObjXml">代表实体对象的XML串</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql_XML(string strQxUsers4SynchObjXml)
{
clsQxUsers4SynchEN objQxUsers4SynchEN = GetObjFromXmlStr(strQxUsers4SynchObjXml);
try
{
bool bolResult = QxUsers4SynchDA.AddNewRecordBySQL2(objQxUsers4SynchEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsers4SynchBL.ReFreshCache();

if (clsQxUsers4SynchBL.relatedActions != null)
{
clsQxUsers4SynchBL.relatedActions.UpdRelaTabDate(objQxUsers4SynchEN.mId, objQxUsers4SynchEN.UpdUser);
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
 /// <param name = "objQxUsers4SynchEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsQxUsers4SynchEN objQxUsers4SynchEN)
{
try
{
bool bolResult = QxUsers4SynchDA.Update(objQxUsers4SynchEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsers4SynchBL.ReFreshCache();

if (clsQxUsers4SynchBL.relatedActions != null)
{
clsQxUsers4SynchBL.relatedActions.UpdRelaTabDate(objQxUsers4SynchEN.mId, objQxUsers4SynchEN.UpdUser);
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
 /// <param name = "objQxUsers4SynchEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsQxUsers4SynchEN objQxUsers4SynchEN)
{
 if (objQxUsers4SynchEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = QxUsers4SynchDA.UpdateBySql2(objQxUsers4SynchEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsers4SynchBL.ReFreshCache();

if (clsQxUsers4SynchBL.relatedActions != null)
{
clsQxUsers4SynchBL.relatedActions.UpdRelaTabDate(objQxUsers4SynchEN.mId, objQxUsers4SynchEN.UpdUser);
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
 /// <param name = "strQxUsers4SynchObjXml">需要修改的对象,用XML来表示</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql_XML(string strQxUsers4SynchObjXml)
{
clsQxUsers4SynchEN objQxUsers4SynchEN = GetObjFromXmlStr(strQxUsers4SynchObjXml);
try
{
bool bolResult = QxUsers4SynchDA.UpdateBySql2(objQxUsers4SynchEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsers4SynchBL.ReFreshCache();

if (clsQxUsers4SynchBL.relatedActions != null)
{
clsQxUsers4SynchBL.relatedActions.UpdRelaTabDate(objQxUsers4SynchEN.mId, objQxUsers4SynchEN.UpdUser);
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
 clsQxUsers4SynchEN objQxUsers4SynchEN = clsQxUsers4SynchBL.GetObjBymId(lngmId);

if (clsQxUsers4SynchBL.relatedActions != null)
{
clsQxUsers4SynchBL.relatedActions.UpdRelaTabDate(objQxUsers4SynchEN.mId, objQxUsers4SynchEN.UpdUser);
}
if (objQxUsers4SynchEN != null)
{
int intRecNum = QxUsers4SynchDA.DelRecord(lngmId);
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
objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
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
//删除与表:[QxUsers4Synch]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conQxUsers4Synch.mId,
//lngmId);
//        clsQxUsers4SynchBL.DelQxUsers4SynchsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxUsers4SynchBL.DelRecord(lngmId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxUsers4SynchBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clsQxUsers4SynchBL.relatedActions != null)
{
clsQxUsers4SynchBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = QxUsers4SynchDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
if (clsQxUsers4SynchBL.relatedActions != null)
{
clsQxUsers4SynchBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = QxUsers4SynchDA.DelRecordBySP(lngmId);
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
public static int DelQxUsers4Synchs(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsQxUsers4SynchBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsQxUsers4SynchBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intDelRecNum = QxUsers4SynchDA.DelQxUsers4Synch(arrmIdLst);
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
public static int DelQxUsers4SynchsByCond(string strWhereCond)
{
try
{
if (clsQxUsers4SynchBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsQxUsers4SynchBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum = QxUsers4SynchDA.DelQxUsers4Synch(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[QxUsers4Synch]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
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
//删除与表:[QxUsers4Synch]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxUsers4SynchBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxUsers4SynchBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objQxUsers4SynchENS">源对象</param>
 /// <param name = "objQxUsers4SynchENT">目标对象</param>
 public static void CopyTo(clsQxUsers4SynchEN objQxUsers4SynchENS, clsQxUsers4SynchEN objQxUsers4SynchENT)
{
try
{
objQxUsers4SynchENT.mId = objQxUsers4SynchENS.mId; //流水号
objQxUsers4SynchENT.IpAddress = objQxUsers4SynchENS.IpAddress; //IP地址
objQxUsers4SynchENT.UserId = objQxUsers4SynchENS.UserId; //用户ID
objQxUsers4SynchENT.UserName = objQxUsers4SynchENS.UserName; //用户名
objQxUsers4SynchENT.UserStateId = objQxUsers4SynchENS.UserStateId; //用户状态Id
objQxUsers4SynchENT.OpenId = objQxUsers4SynchENS.OpenId; //微信openid
objQxUsers4SynchENT.IdentityId = objQxUsers4SynchENS.IdentityId; //身份编号
objQxUsers4SynchENT.StuTeacherId = objQxUsers4SynchENS.StuTeacherId; //学工号
objQxUsers4SynchENT.Password = objQxUsers4SynchENS.Password; //口令
objQxUsers4SynchENT.PhoneNumber = objQxUsers4SynchENS.PhoneNumber; //电话号码
objQxUsers4SynchENT.DepartmentId = objQxUsers4SynchENS.DepartmentId; //部门Id
objQxUsers4SynchENT.IdXzCollege = objQxUsers4SynchENS.IdXzCollege; //IdXzCollege
objQxUsers4SynchENT.EffitiveBeginDate = objQxUsers4SynchENS.EffitiveBeginDate; //有效开始日期
objQxUsers4SynchENT.EffitiveEndDate = objQxUsers4SynchENS.EffitiveEndDate; //有效结束日期
objQxUsers4SynchENT.Email = objQxUsers4SynchENS.Email; //邮箱
objQxUsers4SynchENT.IsArchive = objQxUsers4SynchENS.IsArchive; //是否存档
objQxUsers4SynchENT.IsAccessSynch = objQxUsers4SynchENS.IsAccessSynch; //是否处理同步
objQxUsers4SynchENT.AccessSynchDate = objQxUsers4SynchENS.AccessSynchDate; //处理同步日期
objQxUsers4SynchENT.IsExistUserInCurr = objQxUsers4SynchENS.IsExistUserInCurr; //当前是否存在用户
objQxUsers4SynchENT.IsSamePwd = objQxUsers4SynchENS.IsSamePwd; //是否相同密码
objQxUsers4SynchENT.UpdDate = objQxUsers4SynchENS.UpdDate; //修改日期
objQxUsers4SynchENT.UpdUser = objQxUsers4SynchENS.UpdUser; //修改用户
objQxUsers4SynchENT.Memo = objQxUsers4SynchENS.Memo; //备注
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
 /// <param name = "objQxUsers4SynchEN">源简化对象</param>
 public static void SetUpdFlag(clsQxUsers4SynchEN objQxUsers4SynchEN)
{
try
{
objQxUsers4SynchEN.ClearUpdateState();
   string strsfUpdFldSetStr = objQxUsers4SynchEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conQxUsers4Synch.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsers4SynchEN.mId = objQxUsers4SynchEN.mId; //流水号
}
if (arrFldSet.Contains(conQxUsers4Synch.IpAddress, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsers4SynchEN.IpAddress = objQxUsers4SynchEN.IpAddress == "[null]" ? null :  objQxUsers4SynchEN.IpAddress; //IP地址
}
if (arrFldSet.Contains(conQxUsers4Synch.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsers4SynchEN.UserId = objQxUsers4SynchEN.UserId; //用户ID
}
if (arrFldSet.Contains(conQxUsers4Synch.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsers4SynchEN.UserName = objQxUsers4SynchEN.UserName; //用户名
}
if (arrFldSet.Contains(conQxUsers4Synch.UserStateId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsers4SynchEN.UserStateId = objQxUsers4SynchEN.UserStateId; //用户状态Id
}
if (arrFldSet.Contains(conQxUsers4Synch.OpenId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsers4SynchEN.OpenId = objQxUsers4SynchEN.OpenId == "[null]" ? null :  objQxUsers4SynchEN.OpenId; //微信openid
}
if (arrFldSet.Contains(conQxUsers4Synch.IdentityId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsers4SynchEN.IdentityId = objQxUsers4SynchEN.IdentityId == "[null]" ? null :  objQxUsers4SynchEN.IdentityId; //身份编号
}
if (arrFldSet.Contains(conQxUsers4Synch.StuTeacherId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsers4SynchEN.StuTeacherId = objQxUsers4SynchEN.StuTeacherId == "[null]" ? null :  objQxUsers4SynchEN.StuTeacherId; //学工号
}
if (arrFldSet.Contains(conQxUsers4Synch.Password, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsers4SynchEN.Password = objQxUsers4SynchEN.Password; //口令
}
if (arrFldSet.Contains(conQxUsers4Synch.PhoneNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsers4SynchEN.PhoneNumber = objQxUsers4SynchEN.PhoneNumber == "[null]" ? null :  objQxUsers4SynchEN.PhoneNumber; //电话号码
}
if (arrFldSet.Contains(conQxUsers4Synch.DepartmentId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsers4SynchEN.DepartmentId = objQxUsers4SynchEN.DepartmentId == "[null]" ? null :  objQxUsers4SynchEN.DepartmentId; //部门Id
}
if (arrFldSet.Contains(conQxUsers4Synch.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsers4SynchEN.IdXzCollege = objQxUsers4SynchEN.IdXzCollege == "[null]" ? null :  objQxUsers4SynchEN.IdXzCollege; //IdXzCollege
}
if (arrFldSet.Contains(conQxUsers4Synch.EffitiveBeginDate, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsers4SynchEN.EffitiveBeginDate = objQxUsers4SynchEN.EffitiveBeginDate == "[null]" ? null :  objQxUsers4SynchEN.EffitiveBeginDate; //有效开始日期
}
if (arrFldSet.Contains(conQxUsers4Synch.EffitiveEndDate, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsers4SynchEN.EffitiveEndDate = objQxUsers4SynchEN.EffitiveEndDate == "[null]" ? null :  objQxUsers4SynchEN.EffitiveEndDate; //有效结束日期
}
if (arrFldSet.Contains(conQxUsers4Synch.Email, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsers4SynchEN.Email = objQxUsers4SynchEN.Email == "[null]" ? null :  objQxUsers4SynchEN.Email; //邮箱
}
if (arrFldSet.Contains(conQxUsers4Synch.IsArchive, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsers4SynchEN.IsArchive = objQxUsers4SynchEN.IsArchive; //是否存档
}
if (arrFldSet.Contains(conQxUsers4Synch.IsAccessSynch, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsers4SynchEN.IsAccessSynch = objQxUsers4SynchEN.IsAccessSynch; //是否处理同步
}
if (arrFldSet.Contains(conQxUsers4Synch.AccessSynchDate, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsers4SynchEN.AccessSynchDate = objQxUsers4SynchEN.AccessSynchDate == "[null]" ? null :  objQxUsers4SynchEN.AccessSynchDate; //处理同步日期
}
if (arrFldSet.Contains(conQxUsers4Synch.IsExistUserInCurr, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsers4SynchEN.IsExistUserInCurr = objQxUsers4SynchEN.IsExistUserInCurr; //当前是否存在用户
}
if (arrFldSet.Contains(conQxUsers4Synch.IsSamePwd, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsers4SynchEN.IsSamePwd = objQxUsers4SynchEN.IsSamePwd; //是否相同密码
}
if (arrFldSet.Contains(conQxUsers4Synch.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsers4SynchEN.UpdDate = objQxUsers4SynchEN.UpdDate == "[null]" ? null :  objQxUsers4SynchEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conQxUsers4Synch.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsers4SynchEN.UpdUser = objQxUsers4SynchEN.UpdUser == "[null]" ? null :  objQxUsers4SynchEN.UpdUser; //修改用户
}
if (arrFldSet.Contains(conQxUsers4Synch.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsers4SynchEN.Memo = objQxUsers4SynchEN.Memo == "[null]" ? null :  objQxUsers4SynchEN.Memo; //备注
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
 /// <param name = "objQxUsers4SynchEN">源简化对象</param>
 public static void AccessFldValueNull(clsQxUsers4SynchEN objQxUsers4SynchEN)
{
try
{
if (objQxUsers4SynchEN.IpAddress == "[null]") objQxUsers4SynchEN.IpAddress = null; //IP地址
if (objQxUsers4SynchEN.OpenId == "[null]") objQxUsers4SynchEN.OpenId = null; //微信openid
if (objQxUsers4SynchEN.IdentityId == "[null]") objQxUsers4SynchEN.IdentityId = null; //身份编号
if (objQxUsers4SynchEN.StuTeacherId == "[null]") objQxUsers4SynchEN.StuTeacherId = null; //学工号
if (objQxUsers4SynchEN.PhoneNumber == "[null]") objQxUsers4SynchEN.PhoneNumber = null; //电话号码
if (objQxUsers4SynchEN.DepartmentId == "[null]") objQxUsers4SynchEN.DepartmentId = null; //部门Id
if (objQxUsers4SynchEN.IdXzCollege == "[null]") objQxUsers4SynchEN.IdXzCollege = null; //IdXzCollege
if (objQxUsers4SynchEN.EffitiveBeginDate == "[null]") objQxUsers4SynchEN.EffitiveBeginDate = null; //有效开始日期
if (objQxUsers4SynchEN.EffitiveEndDate == "[null]") objQxUsers4SynchEN.EffitiveEndDate = null; //有效结束日期
if (objQxUsers4SynchEN.Email == "[null]") objQxUsers4SynchEN.Email = null; //邮箱
if (objQxUsers4SynchEN.AccessSynchDate == "[null]") objQxUsers4SynchEN.AccessSynchDate = null; //处理同步日期
if (objQxUsers4SynchEN.UpdDate == "[null]") objQxUsers4SynchEN.UpdDate = null; //修改日期
if (objQxUsers4SynchEN.UpdUser == "[null]") objQxUsers4SynchEN.UpdUser = null; //修改用户
if (objQxUsers4SynchEN.Memo == "[null]") objQxUsers4SynchEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsQxUsers4SynchEN objQxUsers4SynchEN)
{
 QxUsers4SynchDA.CheckPropertyNew(objQxUsers4SynchEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsQxUsers4SynchEN objQxUsers4SynchEN)
{
 QxUsers4SynchDA.CheckProperty4Condition(objQxUsers4SynchEN);
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
if (clsQxUsers4SynchBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxUsers4SynchBL没有刷新缓存机制(clsQxUsers4SynchBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrQxUsers4SynchObjLstCache == null)
//{
//arrQxUsers4SynchObjLstCache = QxUsers4SynchDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxUsers4SynchEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsQxUsers4SynchEN._CurrTabName);
List<clsQxUsers4SynchEN> arrQxUsers4SynchObjLstCache = GetObjLstCache();
IEnumerable <clsQxUsers4SynchEN> arrQxUsers4SynchObjLst_Sel =
arrQxUsers4SynchObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrQxUsers4SynchObjLst_Sel.Count() == 0)
{
   clsQxUsers4SynchEN obj = clsQxUsers4SynchBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrQxUsers4SynchObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxUsers4SynchEN> GetAllQxUsers4SynchObjLstCache()
{
//获取缓存中的对象列表
List<clsQxUsers4SynchEN> arrQxUsers4SynchObjLstCache = GetObjLstCache(); 
return arrQxUsers4SynchObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxUsers4SynchEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsQxUsers4SynchEN._CurrTabName);
List<clsQxUsers4SynchEN> arrQxUsers4SynchObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrQxUsers4SynchObjLstCache;
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
string strKey = string.Format("{0}", clsQxUsers4SynchEN._CurrTabName);
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
if (clsQxUsers4SynchBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsQxUsers4SynchEN._CurrTabName);
CacheHelper.Remove(strKey);
clsQxUsers4SynchBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--QxUsers4Synch(用户4同步)
 /// 唯一性条件:IpAddress_UserId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsQxUsers4SynchEN objQxUsers4SynchEN)
{
//检测记录是否存在
string strResult = QxUsers4SynchDA.GetUniCondStr(objQxUsers4SynchEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-12-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstQxUsers4SynchObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsQxUsers4SynchEN> lstQxUsers4SynchObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstQxUsers4SynchObjLst, writer);
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
 /// <param name = "lstQxUsers4SynchObjLst">[clsQxUsers4SynchEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsQxUsers4SynchEN> lstQxUsers4SynchObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsQxUsers4SynchBL.listXmlNode);
writer.WriteStartElement(clsQxUsers4SynchBL.itemsXmlNode);
foreach (clsQxUsers4SynchEN objQxUsers4SynchEN in lstQxUsers4SynchObjLst)
{
clsQxUsers4SynchBL.SerializeXML(writer, objQxUsers4SynchEN);
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
 /// <param name = "objQxUsers4SynchEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsQxUsers4SynchEN objQxUsers4SynchEN)
{
writer.WriteStartElement(clsQxUsers4SynchBL.itemXmlNode);
 
writer.WriteElementString(conQxUsers4Synch.mId, objQxUsers4SynchEN.mId.ToString(CultureInfo.InvariantCulture));
 
if (objQxUsers4SynchEN.IpAddress != null)
{
writer.WriteElementString(conQxUsers4Synch.IpAddress, objQxUsers4SynchEN.IpAddress.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUsers4SynchEN.UserId != null)
{
writer.WriteElementString(conQxUsers4Synch.UserId, objQxUsers4SynchEN.UserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUsers4SynchEN.UserName != null)
{
writer.WriteElementString(conQxUsers4Synch.UserName, objQxUsers4SynchEN.UserName.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUsers4SynchEN.UserStateId != null)
{
writer.WriteElementString(conQxUsers4Synch.UserStateId, objQxUsers4SynchEN.UserStateId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUsers4SynchEN.OpenId != null)
{
writer.WriteElementString(conQxUsers4Synch.OpenId, objQxUsers4SynchEN.OpenId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUsers4SynchEN.IdentityId != null)
{
writer.WriteElementString(conQxUsers4Synch.IdentityId, objQxUsers4SynchEN.IdentityId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUsers4SynchEN.StuTeacherId != null)
{
writer.WriteElementString(conQxUsers4Synch.StuTeacherId, objQxUsers4SynchEN.StuTeacherId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUsers4SynchEN.Password != null)
{
writer.WriteElementString(conQxUsers4Synch.Password, objQxUsers4SynchEN.Password.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUsers4SynchEN.PhoneNumber != null)
{
writer.WriteElementString(conQxUsers4Synch.PhoneNumber, objQxUsers4SynchEN.PhoneNumber.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUsers4SynchEN.DepartmentId != null)
{
writer.WriteElementString(conQxUsers4Synch.DepartmentId, objQxUsers4SynchEN.DepartmentId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUsers4SynchEN.IdXzCollege != null)
{
writer.WriteElementString(conQxUsers4Synch.IdXzCollege, objQxUsers4SynchEN.IdXzCollege.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUsers4SynchEN.EffitiveBeginDate != null)
{
writer.WriteElementString(conQxUsers4Synch.EffitiveBeginDate, objQxUsers4SynchEN.EffitiveBeginDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUsers4SynchEN.EffitiveEndDate != null)
{
writer.WriteElementString(conQxUsers4Synch.EffitiveEndDate, objQxUsers4SynchEN.EffitiveEndDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUsers4SynchEN.Email != null)
{
writer.WriteElementString(conQxUsers4Synch.Email, objQxUsers4SynchEN.Email.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(conQxUsers4Synch.IsArchive, objQxUsers4SynchEN.IsArchive.ToString().ToLower(CultureInfo.InvariantCulture));
 
writer.WriteElementString(conQxUsers4Synch.IsAccessSynch, objQxUsers4SynchEN.IsAccessSynch.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objQxUsers4SynchEN.AccessSynchDate != null)
{
writer.WriteElementString(conQxUsers4Synch.AccessSynchDate, objQxUsers4SynchEN.AccessSynchDate.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(conQxUsers4Synch.IsExistUserInCurr, objQxUsers4SynchEN.IsExistUserInCurr.ToString().ToLower(CultureInfo.InvariantCulture));
 
writer.WriteElementString(conQxUsers4Synch.IsSamePwd, objQxUsers4SynchEN.IsSamePwd.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objQxUsers4SynchEN.UpdDate != null)
{
writer.WriteElementString(conQxUsers4Synch.UpdDate, objQxUsers4SynchEN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUsers4SynchEN.UpdUser != null)
{
writer.WriteElementString(conQxUsers4Synch.UpdUser, objQxUsers4SynchEN.UpdUser.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUsers4SynchEN.Memo != null)
{
writer.WriteElementString(conQxUsers4Synch.Memo, objQxUsers4SynchEN.Memo.ToString(CultureInfo.InvariantCulture));
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
public static clsQxUsers4SynchEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsQxUsers4SynchEN objQxUsers4SynchEN = new clsQxUsers4SynchEN();
reader.Read();
while (!(reader.Name == clsQxUsers4SynchBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(conQxUsers4Synch.mId))
{
objQxUsers4SynchEN.mId = reader.ReadElementContentAsLong();
}
if (reader.IsStartElement(conQxUsers4Synch.IpAddress))
{
objQxUsers4SynchEN.IpAddress = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsers4Synch.UserId))
{
objQxUsers4SynchEN.UserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsers4Synch.UserName))
{
objQxUsers4SynchEN.UserName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsers4Synch.UserStateId))
{
objQxUsers4SynchEN.UserStateId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsers4Synch.OpenId))
{
objQxUsers4SynchEN.OpenId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsers4Synch.IdentityId))
{
objQxUsers4SynchEN.IdentityId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsers4Synch.StuTeacherId))
{
objQxUsers4SynchEN.StuTeacherId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsers4Synch.Password))
{
objQxUsers4SynchEN.Password = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsers4Synch.PhoneNumber))
{
objQxUsers4SynchEN.PhoneNumber = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsers4Synch.DepartmentId))
{
objQxUsers4SynchEN.DepartmentId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsers4Synch.IdXzCollege))
{
objQxUsers4SynchEN.IdXzCollege = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsers4Synch.EffitiveBeginDate))
{
objQxUsers4SynchEN.EffitiveBeginDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsers4Synch.EffitiveEndDate))
{
objQxUsers4SynchEN.EffitiveEndDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsers4Synch.Email))
{
objQxUsers4SynchEN.Email = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsers4Synch.IsArchive))
{
objQxUsers4SynchEN.IsArchive = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(conQxUsers4Synch.IsAccessSynch))
{
objQxUsers4SynchEN.IsAccessSynch = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(conQxUsers4Synch.AccessSynchDate))
{
objQxUsers4SynchEN.AccessSynchDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsers4Synch.IsExistUserInCurr))
{
objQxUsers4SynchEN.IsExistUserInCurr = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(conQxUsers4Synch.IsSamePwd))
{
objQxUsers4SynchEN.IsSamePwd = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(conQxUsers4Synch.UpdDate))
{
objQxUsers4SynchEN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsers4Synch.UpdUser))
{
objQxUsers4SynchEN.UpdUser = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsers4Synch.Memo))
{
objQxUsers4SynchEN.Memo = reader.ReadElementContentAsString();
}
}
return objQxUsers4SynchEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strQxUsers4SynchObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsQxUsers4SynchEN GetObjFromXmlStr(string strQxUsers4SynchObjXmlStr)
{
clsQxUsers4SynchEN objQxUsers4SynchEN = new clsQxUsers4SynchEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strQxUsers4SynchObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsQxUsers4SynchBL.itemXmlNode))
{
objQxUsers4SynchEN = GetObjFromXml(reader);
return objQxUsers4SynchEN;
}
}
return objQxUsers4SynchEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-12-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsQxUsers4SynchEN objQxUsers4SynchEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objQxUsers4SynchEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != conQxUsers4Synch.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conQxUsers4Synch.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conQxUsers4Synch.AttributeName));
throw new Exception(strMsg);
}
var objQxUsers4Synch = clsQxUsers4SynchBL.GetObjBymIdCache(lngmId);
if (objQxUsers4Synch == null) return "";
return objQxUsers4Synch[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-12-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsQxUsers4SynchEN objQxUsers4SynchEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsQxUsers4SynchEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objQxUsers4SynchEN[strField]);
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
 /// <param name = "lstQxUsers4SynchObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsQxUsers4SynchEN> lstQxUsers4SynchObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstQxUsers4SynchObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsQxUsers4SynchEN objQxUsers4SynchEN in lstQxUsers4SynchObjLst)
{
string strJSON_One = SerializeObjToJSON(objQxUsers4SynchEN);
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
int intRecCount = clsQxUsers4SynchDA.GetRecCount(strTabName);
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
int intRecCount = clsQxUsers4SynchDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsQxUsers4SynchDA.GetRecCount();
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
int intRecCount = clsQxUsers4SynchDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objQxUsers4SynchCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsQxUsers4SynchEN objQxUsers4SynchCond)
{
List<clsQxUsers4SynchEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxUsers4SynchEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxUsers4Synch.AttributeName)
{
if (objQxUsers4SynchCond.IsUpdated(strFldName) == false) continue;
if (objQxUsers4SynchCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUsers4SynchCond[strFldName].ToString());
}
else
{
if (objQxUsers4SynchCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxUsers4SynchCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUsers4SynchCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxUsers4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxUsers4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxUsers4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxUsers4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxUsers4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxUsers4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxUsers4SynchCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxUsers4SynchCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxUsers4SynchCond[strFldName]));
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
 List<string> arrList = clsQxUsers4SynchDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = QxUsers4SynchDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = QxUsers4SynchDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = QxUsers4SynchDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxUsers4SynchDA.SetFldValue(clsQxUsers4SynchEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = QxUsers4SynchDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxUsers4SynchDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxUsers4SynchDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxUsers4SynchDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[QxUsers4Synch] "); 
 strCreateTabCode.Append(" ( "); 
 // /**流水号*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**IP地址*/ 
 strCreateTabCode.Append(" IpAddress varchar(23) Null, "); 
 // /**用户ID*/ 
 strCreateTabCode.Append(" UserId varchar(18) not Null, "); 
 // /**用户名*/ 
 strCreateTabCode.Append(" UserName varchar(30) not Null, "); 
 // /**用户状态Id*/ 
 strCreateTabCode.Append(" UserStateId char(2) not Null, "); 
 // /**微信openid*/ 
 strCreateTabCode.Append(" OpenId varchar(50) Null, "); 
 // /**身份编号*/ 
 strCreateTabCode.Append(" IdentityId char(2) Null, "); 
 // /**学工号*/ 
 strCreateTabCode.Append(" StuTeacherId varchar(20) Null, "); 
 // /**口令*/ 
 strCreateTabCode.Append(" Password varchar(20) not Null, "); 
 // /**电话号码*/ 
 strCreateTabCode.Append(" PhoneNumber varchar(15) Null, "); 
 // /**部门Id*/ 
 strCreateTabCode.Append(" DepartmentId varchar(8) Null, "); 
 // /**IdXzCollege*/ 
 strCreateTabCode.Append(" IdXzCollege char(4) Null, "); 
 // /**有效开始日期*/ 
 strCreateTabCode.Append(" EffitiveBeginDate varchar(14) Null, "); 
 // /**有效结束日期*/ 
 strCreateTabCode.Append(" EffitiveEndDate varchar(14) Null, "); 
 // /**邮箱*/ 
 strCreateTabCode.Append(" Email varchar(100) Null, "); 
 // /**是否存档*/ 
 strCreateTabCode.Append(" IsArchive bit Null, "); 
 // /**是否处理同步*/ 
 strCreateTabCode.Append(" IsAccessSynch bit Null, "); 
 // /**处理同步日期*/ 
 strCreateTabCode.Append(" AccessSynchDate varchar(14) Null, "); 
 // /**当前是否存在用户*/ 
 strCreateTabCode.Append(" IsExistUserInCurr bit Null, "); 
 // /**是否相同密码*/ 
 strCreateTabCode.Append(" IsSamePwd bit Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
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
 /// 用户4同步(QxUsers4Synch)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4QxUsers4Synch : clsCommFun4BL
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
clsQxUsers4SynchBL.ReFreshThisCache();
}
}

}