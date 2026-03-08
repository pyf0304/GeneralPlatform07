
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUsers4SynchWApi
 表名:QxUsers4Synch(00140089)
 * 版本:2023.12.26.1(服务器:WIN-SRV103-116)
 日期:2023/12/28 18:57:46
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:数据同步(DataSynch)
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
public static class  clsQxUsers4SynchWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">流水号</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strIpAddress">IP地址</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsers4SynchEN SetIpAddress(this clsQxUsers4SynchEN objQxUsers4SynchEN, string strIpAddress, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIpAddress, 23, conQxUsers4Synch.IpAddress);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsers4SynchEN SetUserId(this clsQxUsers4SynchEN objQxUsers4SynchEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, conQxUsers4Synch.UserId);
clsCheckSql.CheckFieldLen(strUserId, 18, conQxUsers4Synch.UserId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserName">用户名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsers4SynchEN SetUserName(this clsQxUsers4SynchEN objQxUsers4SynchEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, conQxUsers4Synch.UserName);
clsCheckSql.CheckFieldLen(strUserName, 30, conQxUsers4Synch.UserName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserStateId">用户状态Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsers4SynchEN SetUserStateId(this clsQxUsers4SynchEN objQxUsers4SynchEN, string strUserStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserStateId, conQxUsers4Synch.UserStateId);
clsCheckSql.CheckFieldLen(strUserStateId, 2, conQxUsers4Synch.UserStateId);
clsCheckSql.CheckFieldForeignKey(strUserStateId, 2, conQxUsers4Synch.UserStateId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strOpenId">微信openid</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsers4SynchEN SetOpenId(this clsQxUsers4SynchEN objQxUsers4SynchEN, string strOpenId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOpenId, 50, conQxUsers4Synch.OpenId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strIdentityId">身份编号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsers4SynchEN SetIdentityId(this clsQxUsers4SynchEN objQxUsers4SynchEN, string strIdentityId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIdentityId, 2, conQxUsers4Synch.IdentityId);
clsCheckSql.CheckFieldForeignKey(strIdentityId, 2, conQxUsers4Synch.IdentityId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strStuTeacherId">学工号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsers4SynchEN SetStuTeacherId(this clsQxUsers4SynchEN objQxUsers4SynchEN, string strStuTeacherId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuTeacherId, 20, conQxUsers4Synch.StuTeacherId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strPassword">口令</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsers4SynchEN SetPassword(this clsQxUsers4SynchEN objQxUsers4SynchEN, string strPassword, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPassword, conQxUsers4Synch.Password);
clsCheckSql.CheckFieldLen(strPassword, 20, conQxUsers4Synch.Password);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strPhoneNumber">电话号码</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsers4SynchEN SetPhoneNumber(this clsQxUsers4SynchEN objQxUsers4SynchEN, string strPhoneNumber, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPhoneNumber, 15, conQxUsers4Synch.PhoneNumber);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strDepartmentId">部门Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsers4SynchEN SetDepartmentId(this clsQxUsers4SynchEN objQxUsers4SynchEN, string strDepartmentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDepartmentId, 8, conQxUsers4Synch.DepartmentId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strIdXzCollege">IdXzCollege</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsers4SynchEN SetIdXzCollege(this clsQxUsers4SynchEN objQxUsers4SynchEN, string strIdXzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, conQxUsers4Synch.IdXzCollege);
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, conQxUsers4Synch.IdXzCollege);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strEffitiveBeginDate">有效开始日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsers4SynchEN SetEffitiveBeginDate(this clsQxUsers4SynchEN objQxUsers4SynchEN, string strEffitiveBeginDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEffitiveBeginDate, 14, conQxUsers4Synch.EffitiveBeginDate);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strEffitiveEndDate">有效结束日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsers4SynchEN SetEffitiveEndDate(this clsQxUsers4SynchEN objQxUsers4SynchEN, string strEffitiveEndDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEffitiveEndDate, 14, conQxUsers4Synch.EffitiveEndDate);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strEmail">邮箱</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsers4SynchEN SetEmail(this clsQxUsers4SynchEN objQxUsers4SynchEN, string strEmail, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEmail, 100, conQxUsers4Synch.Email);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsArchive">是否存档</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsAccessSynch">是否处理同步</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strAccessSynchDate">处理同步日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsers4SynchEN SetAccessSynchDate(this clsQxUsers4SynchEN objQxUsers4SynchEN, string strAccessSynchDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAccessSynchDate, 14, conQxUsers4Synch.AccessSynchDate);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsExistUserInCurr">当前是否存在用户</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsSamePwd">是否相同密码</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsers4SynchEN SetUpdDate(this clsQxUsers4SynchEN objQxUsers4SynchEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQxUsers4Synch.UpdDate);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改用户</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsers4SynchEN SetUpdUser(this clsQxUsers4SynchEN objQxUsers4SynchEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conQxUsers4Synch.UpdUser);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">备注</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsers4SynchEN SetMemo(this clsQxUsers4SynchEN objQxUsers4SynchEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQxUsers4Synch.Memo);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
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
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxUsers4SynchEN objQxUsers4SynchEN)
{
 if (objQxUsers4SynchEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objQxUsers4SynchEN.sfUpdFldSetStr = objQxUsers4SynchEN.getsfUpdFldSetStr();
clsQxUsers4SynchWApi.CheckPropertyNew(objQxUsers4SynchEN); 
bool bolResult = clsQxUsers4SynchWApi.UpdateRecord(objQxUsers4SynchEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
 /// 获取唯一性条件串--QxUsers4Synch(用户4同步), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:IpAddress_UserId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsQxUsers4SynchEN objQxUsers4SynchEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objQxUsers4SynchEN == null) return "";
if (objQxUsers4SynchEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IpAddress = '{0}'", objQxUsers4SynchEN.IpAddress);
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

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQxUsers4SynchEN objQxUsers4SynchEN)
{
try
{
clsQxUsers4SynchWApi.CheckPropertyNew(objQxUsers4SynchEN); 
bool bolResult = clsQxUsers4SynchWApi.AddNewRecord(objQxUsers4SynchEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
 /// <param name = "objQxUsers4SynchEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxUsers4SynchEN objQxUsers4SynchEN, string strWhereCond)
{
try
{
clsQxUsers4SynchWApi.CheckPropertyNew(objQxUsers4SynchEN); 
bool bolResult = clsQxUsers4SynchWApi.UpdateWithCondition(objQxUsers4SynchEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
 /// 用户4同步(QxUsers4Synch)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsQxUsers4SynchWApi
{
private static readonly string mstrApiControllerName = "QxUsers4SynchApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsQxUsers4SynchWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsQxUsers4SynchEN objQxUsers4SynchEN)
{
if (!Object.Equals(null, objQxUsers4SynchEN.IpAddress) && GetStrLen(objQxUsers4SynchEN.IpAddress) > 23)
{
 throw new Exception("字段[IP地址]的长度不能超过23!");
}
if (!Object.Equals(null, objQxUsers4SynchEN.UserId) && GetStrLen(objQxUsers4SynchEN.UserId) > 18)
{
 throw new Exception("字段[用户ID]的长度不能超过18!");
}
if (!Object.Equals(null, objQxUsers4SynchEN.UserName) && GetStrLen(objQxUsers4SynchEN.UserName) > 30)
{
 throw new Exception("字段[用户名]的长度不能超过30!");
}
if (!Object.Equals(null, objQxUsers4SynchEN.UserStateId) && GetStrLen(objQxUsers4SynchEN.UserStateId) > 2)
{
 throw new Exception("字段[用户状态Id]的长度不能超过2!");
}
if (!Object.Equals(null, objQxUsers4SynchEN.OpenId) && GetStrLen(objQxUsers4SynchEN.OpenId) > 50)
{
 throw new Exception("字段[微信openid]的长度不能超过50!");
}
if (!Object.Equals(null, objQxUsers4SynchEN.IdentityId) && GetStrLen(objQxUsers4SynchEN.IdentityId) > 2)
{
 throw new Exception("字段[身份编号]的长度不能超过2!");
}
if (!Object.Equals(null, objQxUsers4SynchEN.StuTeacherId) && GetStrLen(objQxUsers4SynchEN.StuTeacherId) > 20)
{
 throw new Exception("字段[学工号]的长度不能超过20!");
}
if (!Object.Equals(null, objQxUsers4SynchEN.Password) && GetStrLen(objQxUsers4SynchEN.Password) > 20)
{
 throw new Exception("字段[口令]的长度不能超过20!");
}
if (!Object.Equals(null, objQxUsers4SynchEN.PhoneNumber) && GetStrLen(objQxUsers4SynchEN.PhoneNumber) > 15)
{
 throw new Exception("字段[电话号码]的长度不能超过15!");
}
if (!Object.Equals(null, objQxUsers4SynchEN.DepartmentId) && GetStrLen(objQxUsers4SynchEN.DepartmentId) > 8)
{
 throw new Exception("字段[部门Id]的长度不能超过8!");
}
if (!Object.Equals(null, objQxUsers4SynchEN.IdXzCollege) && GetStrLen(objQxUsers4SynchEN.IdXzCollege) > 4)
{
 throw new Exception("字段[IdXzCollege]的长度不能超过4!");
}
if (!Object.Equals(null, objQxUsers4SynchEN.EffitiveBeginDate) && GetStrLen(objQxUsers4SynchEN.EffitiveBeginDate) > 14)
{
 throw new Exception("字段[有效开始日期]的长度不能超过14!");
}
if (!Object.Equals(null, objQxUsers4SynchEN.EffitiveEndDate) && GetStrLen(objQxUsers4SynchEN.EffitiveEndDate) > 14)
{
 throw new Exception("字段[有效结束日期]的长度不能超过14!");
}
if (!Object.Equals(null, objQxUsers4SynchEN.Email) && GetStrLen(objQxUsers4SynchEN.Email) > 100)
{
 throw new Exception("字段[邮箱]的长度不能超过100!");
}
if (!Object.Equals(null, objQxUsers4SynchEN.AccessSynchDate) && GetStrLen(objQxUsers4SynchEN.AccessSynchDate) > 14)
{
 throw new Exception("字段[处理同步日期]的长度不能超过14!");
}
if (!Object.Equals(null, objQxUsers4SynchEN.UpdDate) && GetStrLen(objQxUsers4SynchEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objQxUsers4SynchEN.UpdUser) && GetStrLen(objQxUsers4SynchEN.UpdUser) > 20)
{
 throw new Exception("字段[修改用户]的长度不能超过20!");
}
if (!Object.Equals(null, objQxUsers4SynchEN.Memo) && GetStrLen(objQxUsers4SynchEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objQxUsers4SynchEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxUsers4SynchEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
clsQxUsers4SynchEN objQxUsers4SynchEN;
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
objQxUsers4SynchEN = JsonConvert.DeserializeObject<clsQxUsers4SynchEN>(strJson);
return objQxUsers4SynchEN;
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
public static clsQxUsers4SynchEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsQxUsers4SynchEN objQxUsers4SynchEN;
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
objQxUsers4SynchEN = JsonConvert.DeserializeObject<clsQxUsers4SynchEN>(strJson);
return objQxUsers4SynchEN;
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
//该表没有使用Cache,不需要生成[GetObjByKeyLstCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyCache)

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUsers4SynchEN> GetObjLst(string strWhereCond)
{
 List<clsQxUsers4SynchEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxUsers4SynchEN>>(strJson);
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
public static List<clsQxUsers4SynchEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsQxUsers4SynchEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxUsers4SynchEN>>(strJson);
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
//该表没有使用Cache,不需要生成[GetObjLstByKeyLstsCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLstCache)

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUsers4SynchEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsQxUsers4SynchEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxUsers4SynchEN>>(strJson);
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
public static List<clsQxUsers4SynchEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsQxUsers4SynchEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxUsers4SynchEN>>(strJson);
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
public static List<clsQxUsers4SynchEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsQxUsers4SynchEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxUsers4SynchEN>>(strJson);
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
public static List<clsQxUsers4SynchEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsQxUsers4SynchEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxUsers4SynchEN>>(strJson);
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
 clsQxUsers4SynchEN objQxUsers4SynchEN = clsQxUsers4SynchWApi.GetObjBymId(lngmId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngmId.ToString(), out string strResult, out string strErrMsg) == true)
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
public static int DelQxUsers4Synchs(List<string> arrmId)
{
string strAction = "DelQxUsers4Synchs";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrmId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
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
 /// 根据条件删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelQxUsers4SynchsByCond(string strWhereCond)
{
string strAction = "DelQxUsers4SynchsByCond";
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
public static bool AddNewRecord(clsQxUsers4SynchEN objQxUsers4SynchEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxUsers4SynchEN>(objQxUsers4SynchEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
 /// <param name = "objQxUsers4SynchEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsQxUsers4SynchEN objQxUsers4SynchEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxUsers4SynchEN>(objQxUsers4SynchEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
public static bool UpdateRecord(clsQxUsers4SynchEN objQxUsers4SynchEN)
{
if (string.IsNullOrEmpty(objQxUsers4SynchEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objQxUsers4SynchEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxUsers4SynchEN>(objQxUsers4SynchEN);
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
 /// <param name = "objQxUsers4SynchEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsQxUsers4SynchEN objQxUsers4SynchEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objQxUsers4SynchEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objQxUsers4SynchEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objQxUsers4SynchEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxUsers4SynchEN>(objQxUsers4SynchEN);
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
public static DataTable ToDataTable(List<clsQxUsers4SynchEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsQxUsers4SynchEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsQxUsers4SynchEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsQxUsers4SynchEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsQxUsers4SynchEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsQxUsers4SynchEN.AttributeName)
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsQxUsers4SynchWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsQxUsers4SynchEN._CurrTabName);
CacheHelper.Remove(strKey);
clsQxUsers4SynchWApi.objCommFun4WApi.ReFreshCache();
}
}
//该表没有使用Cache,不需要生成[GetObjLstCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
//该表没有使用Cache,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsQxUsers4SynchEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conQxUsers4Synch.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(conQxUsers4Synch.IpAddress, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers4Synch.UserId, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers4Synch.UserName, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers4Synch.UserStateId, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers4Synch.OpenId, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers4Synch.IdentityId, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers4Synch.StuTeacherId, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers4Synch.Password, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers4Synch.PhoneNumber, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers4Synch.DepartmentId, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers4Synch.IdXzCollege, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers4Synch.EffitiveBeginDate, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers4Synch.EffitiveEndDate, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers4Synch.Email, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers4Synch.IsArchive, Type.GetType("System.Boolean"));
objDT.Columns.Add(conQxUsers4Synch.IsAccessSynch, Type.GetType("System.Boolean"));
objDT.Columns.Add(conQxUsers4Synch.AccessSynchDate, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers4Synch.IsExistUserInCurr, Type.GetType("System.Boolean"));
objDT.Columns.Add(conQxUsers4Synch.IsSamePwd, Type.GetType("System.Boolean"));
objDT.Columns.Add(conQxUsers4Synch.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers4Synch.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers4Synch.Memo, Type.GetType("System.String"));
foreach (clsQxUsers4SynchEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conQxUsers4Synch.mId] = objInFor[conQxUsers4Synch.mId];
objDR[conQxUsers4Synch.IpAddress] = objInFor[conQxUsers4Synch.IpAddress];
objDR[conQxUsers4Synch.UserId] = objInFor[conQxUsers4Synch.UserId];
objDR[conQxUsers4Synch.UserName] = objInFor[conQxUsers4Synch.UserName];
objDR[conQxUsers4Synch.UserStateId] = objInFor[conQxUsers4Synch.UserStateId];
objDR[conQxUsers4Synch.OpenId] = objInFor[conQxUsers4Synch.OpenId];
objDR[conQxUsers4Synch.IdentityId] = objInFor[conQxUsers4Synch.IdentityId];
objDR[conQxUsers4Synch.StuTeacherId] = objInFor[conQxUsers4Synch.StuTeacherId];
objDR[conQxUsers4Synch.Password] = objInFor[conQxUsers4Synch.Password];
objDR[conQxUsers4Synch.PhoneNumber] = objInFor[conQxUsers4Synch.PhoneNumber];
objDR[conQxUsers4Synch.DepartmentId] = objInFor[conQxUsers4Synch.DepartmentId];
objDR[conQxUsers4Synch.IdXzCollege] = objInFor[conQxUsers4Synch.IdXzCollege];
objDR[conQxUsers4Synch.EffitiveBeginDate] = objInFor[conQxUsers4Synch.EffitiveBeginDate];
objDR[conQxUsers4Synch.EffitiveEndDate] = objInFor[conQxUsers4Synch.EffitiveEndDate];
objDR[conQxUsers4Synch.Email] = objInFor[conQxUsers4Synch.Email];
objDR[conQxUsers4Synch.IsArchive] = objInFor[conQxUsers4Synch.IsArchive];
objDR[conQxUsers4Synch.IsAccessSynch] = objInFor[conQxUsers4Synch.IsAccessSynch];
objDR[conQxUsers4Synch.AccessSynchDate] = objInFor[conQxUsers4Synch.AccessSynchDate];
objDR[conQxUsers4Synch.IsExistUserInCurr] = objInFor[conQxUsers4Synch.IsExistUserInCurr];
objDR[conQxUsers4Synch.IsSamePwd] = objInFor[conQxUsers4Synch.IsSamePwd];
objDR[conQxUsers4Synch.UpdDate] = objInFor[conQxUsers4Synch.UpdDate];
objDR[conQxUsers4Synch.UpdUser] = objInFor[conQxUsers4Synch.UpdUser];
objDR[conQxUsers4Synch.Memo] = objInFor[conQxUsers4Synch.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 用户4同步(QxUsers4Synch)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4QxUsers4Synch : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
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
clsQxUsers4SynchWApi.ReFreshThisCache();
}
}

}