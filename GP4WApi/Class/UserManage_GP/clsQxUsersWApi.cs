
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUsersWApi
 表名:QxUsers(00140015)
 * 版本:2024.03.19.1(服务器:WIN-SRV103-116)
 日期:2024/03/20 11:19:54
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:用户管理(UserManage_GP)
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
public static class  clsQxUsersWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersEN SetUserId(this clsQxUsersEN objQxUsersEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 18, conQxUsers.UserId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserName">用户名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersEN SetUserName(this clsQxUsersEN objQxUsersEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, conQxUsers.UserName);
clsCheckSql.CheckFieldLen(strUserName, 30, conQxUsers.UserName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strDepartmentId">部门Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersEN SetDepartmentId(this clsQxUsersEN objQxUsersEN, string strDepartmentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDepartmentId, 8, conQxUsers.DepartmentId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserStateId">用户状态Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersEN SetUserStateId(this clsQxUsersEN objQxUsersEN, string strUserStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserStateId, conQxUsers.UserStateId);
clsCheckSql.CheckFieldLen(strUserStateId, 2, conQxUsers.UserStateId);
clsCheckSql.CheckFieldForeignKey(strUserStateId, 2, conQxUsers.UserStateId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strPassword">口令</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersEN SetPassword(this clsQxUsersEN objQxUsersEN, string strPassword, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPassword, conQxUsers.Password);
clsCheckSql.CheckFieldLen(strPassword, 20, conQxUsers.Password);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strEffitiveBeginDate">有效开始日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersEN SetEffitiveBeginDate(this clsQxUsersEN objQxUsersEN, string strEffitiveBeginDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEffitiveBeginDate, 14, conQxUsers.EffitiveBeginDate);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strEffitiveEndDate">有效结束日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersEN SetEffitiveEndDate(this clsQxUsersEN objQxUsersEN, string strEffitiveEndDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEffitiveEndDate, 14, conQxUsers.EffitiveEndDate);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strStuTeacherId">学工号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersEN SetStuTeacherId(this clsQxUsersEN objQxUsersEN, string strStuTeacherId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuTeacherId, 20, conQxUsers.StuTeacherId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strIdentityId">身份编号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersEN SetIdentityId(this clsQxUsersEN objQxUsersEN, string strIdentityId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIdentityId, 2, conQxUsers.IdentityId);
clsCheckSql.CheckFieldForeignKey(strIdentityId, 2, conQxUsers.IdentityId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsArchive">是否存档</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strOpenId">微信openid</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersEN SetOpenId(this clsQxUsersEN objQxUsersEN, string strOpenId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOpenId, 50, conQxUsers.OpenId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strEmail">邮箱</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersEN SetEmail(this clsQxUsersEN objQxUsersEN, string strEmail, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEmail, 100, conQxUsers.Email);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strPhoneNumber">电话号码</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersEN SetPhoneNumber(this clsQxUsersEN objQxUsersEN, string strPhoneNumber, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPhoneNumber, 15, conQxUsers.PhoneNumber);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsSynch">是否同步</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strSynchDate">同步日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersEN SetSynchDate(this clsQxUsersEN objQxUsersEN, string strSynchDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSynchDate, 30, conQxUsers.SynchDate);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strDetailInfoTab">详细信息表</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersEN SetDetailInfoTab(this clsQxUsersEN objQxUsersEN, string strDetailInfoTab, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDetailInfoTab, 30, conQxUsers.DetailInfoTab);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strIdGradeBase">年级流水号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersEN SetIdGradeBase(this clsQxUsersEN objQxUsersEN, string strIdGradeBase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIdGradeBase, 4, conQxUsers.IdGradeBase);
clsCheckSql.CheckFieldForeignKey(strIdGradeBase, 4, conQxUsers.IdGradeBase);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strIdSchool">学校流水号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersEN SetIdSchool(this clsQxUsersEN objQxUsersEN, string strIdSchool, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIdSchool, 4, conQxUsers.IdSchool);
clsCheckSql.CheckFieldForeignKey(strIdSchool, 4, conQxUsers.IdSchool);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strIdXzCollege">学院Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersEN SetIdXzCollege(this clsQxUsersEN objQxUsersEN, string strIdXzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, conQxUsers.IdXzCollege);
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, conQxUsers.IdXzCollege);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersEN SetUpdDate(this clsQxUsersEN objQxUsersEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQxUsers.UpdDate);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改用户</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersEN SetUpdUser(this clsQxUsersEN objQxUsersEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conQxUsers.UpdUser);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">备注</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersEN SetMemo(this clsQxUsersEN objQxUsersEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQxUsers.Memo);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
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

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objQxUsersEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxUsersEN objQxUsersEN)
{
 if (string.IsNullOrEmpty(objQxUsersEN.UserId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objQxUsersEN.sfUpdFldSetStr = objQxUsersEN.getsfUpdFldSetStr();
clsQxUsersWApi.CheckPropertyNew(objQxUsersEN); 
bool bolResult = clsQxUsersWApi.UpdateRecord(objQxUsersEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsersWApi.ReFreshCache();
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
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
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
 if (clsQxUsersWApi.IsExist(objQxUsersEN.UserId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQxUsersEN.UserId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsQxUsersWApi.CheckPropertyNew(objQxUsersEN); 
bool bolResult = clsQxUsersWApi.AddNewRecord(objQxUsersEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsersWApi.ReFreshCache();
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
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值. 该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objQxUsersEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsQxUsersEN objQxUsersEN)
{
try
{
clsQxUsersWApi.CheckPropertyNew(objQxUsersEN); 
string strUserId = clsQxUsersWApi.AddNewRecordWithMaxId(objQxUsersEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsersWApi.ReFreshCache();
return strUserId;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000009)添加记录出错, {1}.(from {0})",
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
 /// <param name = "objQxUsersEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxUsersEN objQxUsersEN, string strWhereCond)
{
try
{
clsQxUsersWApi.CheckPropertyNew(objQxUsersEN); 
bool bolResult = clsQxUsersWApi.UpdateWithCondition(objQxUsersEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsersWApi.ReFreshCache();
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
 /// 用户(QxUsers)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsQxUsersWApi
{
private static readonly string mstrApiControllerName = "QxUsersApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsQxUsersWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_UserId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[用户]...","0");
List<clsQxUsersEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="UserId";
objDDL.DataTextField="UserName";
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_UserId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conQxUsers.UserId); 
List<clsQxUsersEN> arrObjLst = clsQxUsersWApi.GetObjLst(strCondition);
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
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsQxUsersEN objQxUsersEN)
{
if (!Object.Equals(null, objQxUsersEN.UserId) && GetStrLen(objQxUsersEN.UserId) > 18)
{
 throw new Exception("字段[用户ID]的长度不能超过18!");
}
if (!Object.Equals(null, objQxUsersEN.UserName) && GetStrLen(objQxUsersEN.UserName) > 30)
{
 throw new Exception("字段[用户名]的长度不能超过30!");
}
if (!Object.Equals(null, objQxUsersEN.DepartmentId) && GetStrLen(objQxUsersEN.DepartmentId) > 8)
{
 throw new Exception("字段[部门Id]的长度不能超过8!");
}
if (!Object.Equals(null, objQxUsersEN.UserStateId) && GetStrLen(objQxUsersEN.UserStateId) > 2)
{
 throw new Exception("字段[用户状态Id]的长度不能超过2!");
}
if (!Object.Equals(null, objQxUsersEN.Password) && GetStrLen(objQxUsersEN.Password) > 20)
{
 throw new Exception("字段[口令]的长度不能超过20!");
}
if (!Object.Equals(null, objQxUsersEN.EffitiveBeginDate) && GetStrLen(objQxUsersEN.EffitiveBeginDate) > 14)
{
 throw new Exception("字段[有效开始日期]的长度不能超过14!");
}
if (!Object.Equals(null, objQxUsersEN.EffitiveEndDate) && GetStrLen(objQxUsersEN.EffitiveEndDate) > 14)
{
 throw new Exception("字段[有效结束日期]的长度不能超过14!");
}
if (!Object.Equals(null, objQxUsersEN.StuTeacherId) && GetStrLen(objQxUsersEN.StuTeacherId) > 20)
{
 throw new Exception("字段[学工号]的长度不能超过20!");
}
if (!Object.Equals(null, objQxUsersEN.IdentityId) && GetStrLen(objQxUsersEN.IdentityId) > 2)
{
 throw new Exception("字段[身份编号]的长度不能超过2!");
}
if (!Object.Equals(null, objQxUsersEN.OpenId) && GetStrLen(objQxUsersEN.OpenId) > 50)
{
 throw new Exception("字段[微信openid]的长度不能超过50!");
}
if (!Object.Equals(null, objQxUsersEN.Email) && GetStrLen(objQxUsersEN.Email) > 100)
{
 throw new Exception("字段[邮箱]的长度不能超过100!");
}
if (!Object.Equals(null, objQxUsersEN.PhoneNumber) && GetStrLen(objQxUsersEN.PhoneNumber) > 15)
{
 throw new Exception("字段[电话号码]的长度不能超过15!");
}
if (!Object.Equals(null, objQxUsersEN.SynchDate) && GetStrLen(objQxUsersEN.SynchDate) > 30)
{
 throw new Exception("字段[同步日期]的长度不能超过30!");
}
if (!Object.Equals(null, objQxUsersEN.DetailInfoTab) && GetStrLen(objQxUsersEN.DetailInfoTab) > 30)
{
 throw new Exception("字段[详细信息表]的长度不能超过30!");
}
if (!Object.Equals(null, objQxUsersEN.IdGradeBase) && GetStrLen(objQxUsersEN.IdGradeBase) > 4)
{
 throw new Exception("字段[年级流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objQxUsersEN.IdSchool) && GetStrLen(objQxUsersEN.IdSchool) > 4)
{
 throw new Exception("字段[学校流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objQxUsersEN.IdXzCollege) && GetStrLen(objQxUsersEN.IdXzCollege) > 4)
{
 throw new Exception("字段[学院Id]的长度不能超过4!");
}
if (!Object.Equals(null, objQxUsersEN.UpdDate) && GetStrLen(objQxUsersEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objQxUsersEN.UpdUser) && GetStrLen(objQxUsersEN.UpdUser) > 20)
{
 throw new Exception("字段[修改用户]的长度不能超过20!");
}
if (!Object.Equals(null, objQxUsersEN.Memo) && GetStrLen(objQxUsersEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objQxUsersEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strUserId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxUsersEN GetObjByUserId(string strUserId)
{
string strAction = "GetObjByUserId";
clsQxUsersEN objQxUsersEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strUserId"] = strUserId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objQxUsersEN = JsonConvert.DeserializeObject<clsQxUsersEN>(strJson);
return objQxUsersEN;
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
public static string GetFirstID(string strWhereCond)
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
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsQxUsersEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsQxUsersEN objQxUsersEN;
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
objQxUsersEN = JsonConvert.DeserializeObject<clsQxUsersEN>(strJson);
return objQxUsersEN;
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
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strUserId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxUsersEN GetObjByUserIdCache(string strUserId)
{
if (string.IsNullOrEmpty(strUserId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsQxUsersEN._CurrTabName);
List<clsQxUsersEN> arrQxUsersObjLstCache = GetObjLstCache();
IEnumerable <clsQxUsersEN> arrQxUsersObjLst_Sel =
from objQxUsersEN in arrQxUsersObjLstCache
where objQxUsersEN.UserId == strUserId 
select objQxUsersEN;
if (arrQxUsersObjLst_Sel.Count() == 0)
{
   clsQxUsersEN obj = clsQxUsersWApi.GetObjByUserId(strUserId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrQxUsersObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strUserId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetUserNameByUserIdCache(string strUserId)
{
if (string.IsNullOrEmpty(strUserId) == true) return "";
//初始化列表缓存
List<clsQxUsersEN> arrQxUsersObjLstCache = GetObjLstCache();
IEnumerable <clsQxUsersEN> arrQxUsersObjLst_Sel1 =
from objQxUsersEN in arrQxUsersObjLstCache
where objQxUsersEN.UserId == strUserId 
select objQxUsersEN;
List <clsQxUsersEN> arrQxUsersObjLst_Sel = new List<clsQxUsersEN>();
foreach (clsQxUsersEN obj in arrQxUsersObjLst_Sel1)
{
arrQxUsersObjLst_Sel.Add(obj);
}
if (arrQxUsersObjLst_Sel.Count > 0)
{
return arrQxUsersObjLst_Sel[0].UserName;
}
string strErrMsgForGetObjById = string.Format("在QxUsers对象缓存列表中,找不到记录[UserId = {0}](函数:{1})", strUserId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsQxUsersBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strUserId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByUserIdCache(string strUserId)
{
if (string.IsNullOrEmpty(strUserId) == true) return "";
//初始化列表缓存
List<clsQxUsersEN> arrQxUsersObjLstCache = GetObjLstCache();
IEnumerable <clsQxUsersEN> arrQxUsersObjLst_Sel1 =
from objQxUsersEN in arrQxUsersObjLstCache
where objQxUsersEN.UserId == strUserId 
select objQxUsersEN;
List <clsQxUsersEN> arrQxUsersObjLst_Sel = new List<clsQxUsersEN>();
foreach (clsQxUsersEN obj in arrQxUsersObjLst_Sel1)
{
arrQxUsersObjLst_Sel.Add(obj);
}
if (arrQxUsersObjLst_Sel.Count > 0)
{
return arrQxUsersObjLst_Sel[0].UserName;
}
string strErrMsgForGetObjById = string.Format("在QxUsers对象缓存列表中,找不到记录的相关名称[UserId = {0}](函数:{1})", strUserId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsQxUsersBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUsersEN> GetObjLst(string strWhereCond)
{
 List<clsQxUsersEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxUsersEN>>(strJson);
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
 /// <param name = "arrUserId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUsersEN> GetObjLstByUserIdLst(List<string> arrUserId)
{
 List<clsQxUsersEN> arrObjLst; 
string strAction = "GetObjLstByUserIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrUserId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsQxUsersEN>>(strJson);
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

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrUserId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsQxUsersEN> GetObjLstByUserIdLstCache(List<string> arrUserId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsQxUsersEN._CurrTabName);
List<clsQxUsersEN> arrQxUsersObjLstCache = GetObjLstCache();
IEnumerable <clsQxUsersEN> arrQxUsersObjLst_Sel =
from objQxUsersEN in arrQxUsersObjLstCache
where arrUserId.Contains(objQxUsersEN.UserId)
select objQxUsersEN;
return arrQxUsersObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUsersEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsQxUsersEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxUsersEN>>(strJson);
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
public static List<clsQxUsersEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsQxUsersEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxUsersEN>>(strJson);
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
public static List<clsQxUsersEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsQxUsersEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxUsersEN>>(strJson);
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
public static List<clsQxUsersEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsQxUsersEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxUsersEN>>(strJson);
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
public static int DelRecord(string strUserId)
{
string strAction = "DelRecord";
try
{
 clsQxUsersEN objQxUsersEN = clsQxUsersWApi.GetObjByUserId(strUserId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strUserId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsQxUsersWApi.ReFreshCache();
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
public static int DelQxUserss(List<string> arrUserId)
{
string strAction = "DelQxUserss";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrUserId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsQxUsersWApi.ReFreshCache();
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
public static int DelQxUserssByCond(string strWhereCond)
{
string strAction = "DelQxUserssByCond";
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
public static bool AddNewRecord(clsQxUsersEN objQxUsersEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxUsersEN>(objQxUsersEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsersWApi.ReFreshCache();
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
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithMaxId)
 /// </summary>
 /// <returns>新建记录的关键字</returns>
public static string AddNewRecordWithMaxId(clsQxUsersEN objQxUsersEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxUsersEN>(objQxUsersEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsersWApi.ReFreshCache();
var strUserId = (string)jobjReturn0["returnStr"];
return strUserId;
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
public static bool UpdateRecord(clsQxUsersEN objQxUsersEN)
{
if (string.IsNullOrEmpty(objQxUsersEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objQxUsersEN.UserId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxUsersEN>(objQxUsersEN);
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
 /// <param name = "objQxUsersEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsQxUsersEN objQxUsersEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objQxUsersEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objQxUsersEN.UserId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objQxUsersEN.UserId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxUsersEN>(objQxUsersEN);
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
public static bool IsExist(string strUserId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strUserId"] = strUserId
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
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId()
{
string strAction = "GetMaxStrId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
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
string strMsg = string.Format("获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefix(string strPrefix)
{
//检测记录是否存在
string strAction = "GetMaxStrIdByPrefix";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
{"strPrefix", strPrefix}
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
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
string strMsg = string.Format("根据前缀获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
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
public static DataTable ToDataTable(List<clsQxUsersEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsQxUsersEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsQxUsersEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsQxUsersEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsQxUsersEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsQxUsersEN.AttributeName)
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
if (clsQxUsersWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsQxUsersEN._CurrTabName);
CacheHelper.Remove(strKey);
clsQxUsersWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxUsersEN> GetObjLstCache()
{
//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsQxUsersEN._CurrTabName;
List<clsQxUsersEN> arrQxUsersObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrQxUsersObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsQxUsersEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conQxUsers.UserId, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers.UserName, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers.DepartmentId, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers.UserStateId, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers.Password, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers.EffitiveBeginDate, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers.EffitiveEndDate, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers.StuTeacherId, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers.IdentityId, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers.IsArchive, Type.GetType("System.Boolean"));
objDT.Columns.Add(conQxUsers.OpenId, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers.Email, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers.PhoneNumber, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers.IsSynch, Type.GetType("System.Boolean"));
objDT.Columns.Add(conQxUsers.SynchDate, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers.DetailInfoTab, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers.IdGradeBase, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers.IdSchool, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers.IdXzCollege, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsers.Memo, Type.GetType("System.String"));
foreach (clsQxUsersEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conQxUsers.UserId] = objInFor[conQxUsers.UserId];
objDR[conQxUsers.UserName] = objInFor[conQxUsers.UserName];
objDR[conQxUsers.DepartmentId] = objInFor[conQxUsers.DepartmentId];
objDR[conQxUsers.UserStateId] = objInFor[conQxUsers.UserStateId];
objDR[conQxUsers.Password] = objInFor[conQxUsers.Password];
objDR[conQxUsers.EffitiveBeginDate] = objInFor[conQxUsers.EffitiveBeginDate];
objDR[conQxUsers.EffitiveEndDate] = objInFor[conQxUsers.EffitiveEndDate];
objDR[conQxUsers.StuTeacherId] = objInFor[conQxUsers.StuTeacherId];
objDR[conQxUsers.IdentityId] = objInFor[conQxUsers.IdentityId];
objDR[conQxUsers.IsArchive] = objInFor[conQxUsers.IsArchive];
objDR[conQxUsers.OpenId] = objInFor[conQxUsers.OpenId];
objDR[conQxUsers.Email] = objInFor[conQxUsers.Email];
objDR[conQxUsers.PhoneNumber] = objInFor[conQxUsers.PhoneNumber];
objDR[conQxUsers.IsSynch] = objInFor[conQxUsers.IsSynch];
objDR[conQxUsers.SynchDate] = objInFor[conQxUsers.SynchDate];
objDR[conQxUsers.DetailInfoTab] = objInFor[conQxUsers.DetailInfoTab];
objDR[conQxUsers.IdGradeBase] = objInFor[conQxUsers.IdGradeBase];
objDR[conQxUsers.IdSchool] = objInFor[conQxUsers.IdSchool];
objDR[conQxUsers.IdXzCollege] = objInFor[conQxUsers.IdXzCollege];
objDR[conQxUsers.UpdDate] = objInFor[conQxUsers.UpdDate];
objDR[conQxUsers.UpdUser] = objInFor[conQxUsers.UpdUser];
objDR[conQxUsers.Memo] = objInFor[conQxUsers.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 用户(QxUsers)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4QxUsers : clsCommFun4BL
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
clsQxUsersWApi.ReFreshThisCache();
}
}

}