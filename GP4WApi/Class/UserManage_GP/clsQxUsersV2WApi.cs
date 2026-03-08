
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUsersV2WApi
 表名:QxUsersV2(00140110)
 * 版本:2023.12.26.1(服务器:WIN-SRV103-116)
 日期:2023/12/28 18:57:49
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
public static class  clsQxUsersV2WApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strCreateTime">建立时间</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersV2EN SetCreateTime(this clsQxUsersV2EN objQxUsersV2EN, string strCreateTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCreateTime, 20, conQxUsersV2.CreateTime);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strupdateTime">修改时间</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersV2EN SetupdateTime(this clsQxUsersV2EN objQxUsersV2EN, string strupdateTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strupdateTime, 20, conQxUsersV2.updateTime);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要设置字段值的实体对象</param>
 /// <param name = "intid">id</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要设置字段值的实体对象</param>
 /// <param name = "intDepartmentIdInt">部门Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersV2EN SetDepartmentIdInt(this clsQxUsersV2EN objQxUsersV2EN, int intDepartmentIdInt, string strComparisonOp="")
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strname">姓名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersV2EN Setname(this clsQxUsersV2EN objQxUsersV2EN, string strname, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strname, conQxUsersV2.name);
clsCheckSql.CheckFieldLen(strname, 30, conQxUsersV2.name);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strUserName">用户名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersV2EN SetUserName(this clsQxUsersV2EN objQxUsersV2EN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, conQxUsersV2.UserName);
clsCheckSql.CheckFieldLen(strUserName, 30, conQxUsersV2.UserName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strPassword">口令</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersV2EN SetPassword(this clsQxUsersV2EN objQxUsersV2EN, string strPassword, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPassword, conQxUsersV2.Password);
clsCheckSql.CheckFieldLen(strPassword, 20, conQxUsersV2.Password);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strpsalt">密码盐值</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersV2EN Setpsalt(this clsQxUsersV2EN objQxUsersV2EN, string strpsalt, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strpsalt, 20, conQxUsersV2.psalt);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strnickName">呢称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersV2EN SetnickName(this clsQxUsersV2EN objQxUsersV2EN, string strnickName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strnickName, 100, conQxUsersV2.nickName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strheadImg">头像</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersV2EN SetheadImg(this clsQxUsersV2EN objQxUsersV2EN, string strheadImg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strheadImg, 100, conQxUsersV2.headImg);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strEmail">邮箱</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersV2EN SetEmail(this clsQxUsersV2EN objQxUsersV2EN, string strEmail, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEmail, 100, conQxUsersV2.Email);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strphone">电话号码</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersV2EN Setphone(this clsQxUsersV2EN objQxUsersV2EN, string strphone, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strphone, conQxUsersV2.phone);
clsCheckSql.CheckFieldLen(strphone, 15, conQxUsersV2.phone);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strremark">备注</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersV2EN Setremark(this clsQxUsersV2EN objQxUsersV2EN, string strremark, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strremark, 1000, conQxUsersV2.remark);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要设置字段值的实体对象</param>
 /// <param name = "intstatus">用户状态Id</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strOpenId">微信openid</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersV2EN SetOpenId(this clsQxUsersV2EN objQxUsersV2EN, string strOpenId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOpenId, 50, conQxUsersV2.OpenId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改用户</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersV2EN SetUpdUser(this clsQxUsersV2EN objQxUsersV2EN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conQxUsersV2.UpdUser);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsArchive">是否存档</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strIdentityId">身份编号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersV2EN SetIdentityId(this clsQxUsersV2EN objQxUsersV2EN, string strIdentityId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIdentityId, 2, conQxUsersV2.IdentityId);
clsCheckSql.CheckFieldForeignKey(strIdentityId, 2, conQxUsersV2.IdentityId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strStuTeacherId">学工号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersV2EN SetStuTeacherId(this clsQxUsersV2EN objQxUsersV2EN, string strStuTeacherId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuTeacherId, 20, conQxUsersV2.StuTeacherId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strEffitiveBeginDate">有效开始日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersV2EN SetEffitiveBeginDate(this clsQxUsersV2EN objQxUsersV2EN, string strEffitiveBeginDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEffitiveBeginDate, 14, conQxUsersV2.EffitiveBeginDate);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strEffitiveEndDate">有效结束日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersV2EN SetEffitiveEndDate(this clsQxUsersV2EN objQxUsersV2EN, string strEffitiveEndDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEffitiveEndDate, 14, conQxUsersV2.EffitiveEndDate);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersV2EN SetUserId(this clsQxUsersV2EN objQxUsersV2EN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, conQxUsersV2.UserId);
clsCheckSql.CheckFieldLen(strUserId, 18, conQxUsersV2.UserId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strEffectiveDate">有效日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsersV2EN SetEffectiveDate(this clsQxUsersV2EN objQxUsersV2EN, string strEffectiveDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEffectiveDate, 8, conQxUsersV2.EffectiveDate);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
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
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxUsersV2EN objQxUsersV2EN)
{
 if (objQxUsersV2EN.id == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objQxUsersV2EN.sfUpdFldSetStr = objQxUsersV2EN.getsfUpdFldSetStr();
clsQxUsersV2WApi.CheckPropertyNew(objQxUsersV2EN); 
bool bolResult = clsQxUsersV2WApi.UpdateRecord(objQxUsersV2EN);
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
 /// 获取唯一性条件串--QxUsersV2(用户V2), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:name_phone
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objQxUsersV2EN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsQxUsersV2EN objQxUsersV2EN)
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

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQxUsersV2EN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQxUsersV2EN objQxUsersV2EN)
{
try
{
clsQxUsersV2WApi.CheckPropertyNew(objQxUsersV2EN); 
bool bolResult = clsQxUsersV2WApi.AddNewRecord(objQxUsersV2EN);
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
 /// <param name = "objQxUsersV2EN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxUsersV2EN objQxUsersV2EN, string strWhereCond)
{
try
{
clsQxUsersV2WApi.CheckPropertyNew(objQxUsersV2EN); 
bool bolResult = clsQxUsersV2WApi.UpdateWithCondition(objQxUsersV2EN, strWhereCond);
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
 /// 用户V2(QxUsersV2)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsQxUsersV2WApi
{
private static readonly string mstrApiControllerName = "QxUsersV2Api";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsQxUsersV2WApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_id(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[用户V2]...","0");
List<clsQxUsersV2EN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="id";
objDDL.DataTextField="UserName";
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsQxUsersV2EN objQxUsersV2EN)
{
if (!Object.Equals(null, objQxUsersV2EN.CreateTime) && GetStrLen(objQxUsersV2EN.CreateTime) > 20)
{
 throw new Exception("字段[建立时间]的长度不能超过20!");
}
if (!Object.Equals(null, objQxUsersV2EN.updateTime) && GetStrLen(objQxUsersV2EN.updateTime) > 20)
{
 throw new Exception("字段[修改时间]的长度不能超过20!");
}
if (!Object.Equals(null, objQxUsersV2EN.name) && GetStrLen(objQxUsersV2EN.name) > 30)
{
 throw new Exception("字段[姓名]的长度不能超过30!");
}
if (!Object.Equals(null, objQxUsersV2EN.UserName) && GetStrLen(objQxUsersV2EN.UserName) > 30)
{
 throw new Exception("字段[用户名]的长度不能超过30!");
}
if (!Object.Equals(null, objQxUsersV2EN.Password) && GetStrLen(objQxUsersV2EN.Password) > 20)
{
 throw new Exception("字段[口令]的长度不能超过20!");
}
if (!Object.Equals(null, objQxUsersV2EN.psalt) && GetStrLen(objQxUsersV2EN.psalt) > 20)
{
 throw new Exception("字段[密码盐值]的长度不能超过20!");
}
if (!Object.Equals(null, objQxUsersV2EN.nickName) && GetStrLen(objQxUsersV2EN.nickName) > 100)
{
 throw new Exception("字段[呢称]的长度不能超过100!");
}
if (!Object.Equals(null, objQxUsersV2EN.headImg) && GetStrLen(objQxUsersV2EN.headImg) > 100)
{
 throw new Exception("字段[头像]的长度不能超过100!");
}
if (!Object.Equals(null, objQxUsersV2EN.Email) && GetStrLen(objQxUsersV2EN.Email) > 100)
{
 throw new Exception("字段[邮箱]的长度不能超过100!");
}
if (!Object.Equals(null, objQxUsersV2EN.phone) && GetStrLen(objQxUsersV2EN.phone) > 15)
{
 throw new Exception("字段[电话号码]的长度不能超过15!");
}
if (!Object.Equals(null, objQxUsersV2EN.remark) && GetStrLen(objQxUsersV2EN.remark) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
if (!Object.Equals(null, objQxUsersV2EN.OpenId) && GetStrLen(objQxUsersV2EN.OpenId) > 50)
{
 throw new Exception("字段[微信openid]的长度不能超过50!");
}
if (!Object.Equals(null, objQxUsersV2EN.UpdUser) && GetStrLen(objQxUsersV2EN.UpdUser) > 20)
{
 throw new Exception("字段[修改用户]的长度不能超过20!");
}
if (!Object.Equals(null, objQxUsersV2EN.IdentityId) && GetStrLen(objQxUsersV2EN.IdentityId) > 2)
{
 throw new Exception("字段[身份编号]的长度不能超过2!");
}
if (!Object.Equals(null, objQxUsersV2EN.StuTeacherId) && GetStrLen(objQxUsersV2EN.StuTeacherId) > 20)
{
 throw new Exception("字段[学工号]的长度不能超过20!");
}
if (!Object.Equals(null, objQxUsersV2EN.EffitiveBeginDate) && GetStrLen(objQxUsersV2EN.EffitiveBeginDate) > 14)
{
 throw new Exception("字段[有效开始日期]的长度不能超过14!");
}
if (!Object.Equals(null, objQxUsersV2EN.EffitiveEndDate) && GetStrLen(objQxUsersV2EN.EffitiveEndDate) > 14)
{
 throw new Exception("字段[有效结束日期]的长度不能超过14!");
}
if (!Object.Equals(null, objQxUsersV2EN.UserId) && GetStrLen(objQxUsersV2EN.UserId) > 18)
{
 throw new Exception("字段[用户ID]的长度不能超过18!");
}
if (!Object.Equals(null, objQxUsersV2EN.EffectiveDate) && GetStrLen(objQxUsersV2EN.EffectiveDate) > 8)
{
 throw new Exception("字段[有效日期]的长度不能超过8!");
}
 objQxUsersV2EN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "intid">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxUsersV2EN GetObjByid(int intid)
{
string strAction = "GetObjByid";
clsQxUsersV2EN objQxUsersV2EN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["intid"] = intid.ToString(),
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objQxUsersV2EN = JsonConvert.DeserializeObject<clsQxUsersV2EN>(strJson);
return objQxUsersV2EN;
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
public static int GetFirstID(string strWhereCond)
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
return int.Parse(strReturnStr);
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
public static clsQxUsersV2EN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsQxUsersV2EN objQxUsersV2EN;
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
objQxUsersV2EN = JsonConvert.DeserializeObject<clsQxUsersV2EN>(strJson);
return objQxUsersV2EN;
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
//该表没有使用Cache,不需要生成[GetUserNameByidCache]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUsersV2EN> GetObjLst(string strWhereCond)
{
 List<clsQxUsersV2EN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxUsersV2EN>>(strJson);
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
 /// <param name = "arrId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUsersV2EN> GetObjLstByIdLst(List<int> arrId)
{
 List<clsQxUsersV2EN> arrObjLst; 
string strAction = "GetObjLstByIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsQxUsersV2EN>>(strJson);
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
public static List<clsQxUsersV2EN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsQxUsersV2EN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxUsersV2EN>>(strJson);
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
public static List<clsQxUsersV2EN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsQxUsersV2EN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxUsersV2EN>>(strJson);
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
public static List<clsQxUsersV2EN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsQxUsersV2EN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxUsersV2EN>>(strJson);
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
public static List<clsQxUsersV2EN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsQxUsersV2EN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxUsersV2EN>>(strJson);
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
public static int DelRecord(int intid)
{
string strAction = "DelRecord";
try
{
 clsQxUsersV2EN objQxUsersV2EN = clsQxUsersV2WApi.GetObjByid(intid);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, intid.ToString(), out string strResult, out string strErrMsg) == true)
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
public static int DelQxUsersV2s(List<string> arrid)
{
string strAction = "DelQxUsersV2s";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrid);
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
public static int DelQxUsersV2sByCond(string strWhereCond)
{
string strAction = "DelQxUsersV2sByCond";
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
public static bool AddNewRecord(clsQxUsersV2EN objQxUsersV2EN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxUsersV2EN>(objQxUsersV2EN);
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
 /// <param name = "objQxUsersV2EN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsQxUsersV2EN objQxUsersV2EN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxUsersV2EN>(objQxUsersV2EN);
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
public static bool UpdateRecord(clsQxUsersV2EN objQxUsersV2EN)
{
if (string.IsNullOrEmpty(objQxUsersV2EN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objQxUsersV2EN.id, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxUsersV2EN>(objQxUsersV2EN);
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
 /// <param name = "objQxUsersV2EN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsQxUsersV2EN objQxUsersV2EN, string strWhereCond)
{
if (string.IsNullOrEmpty(objQxUsersV2EN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objQxUsersV2EN.id, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objQxUsersV2EN.id, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxUsersV2EN>(objQxUsersV2EN);
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
public static bool IsExist(int intid)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["intid"] = intid.ToString()
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
public static DataTable ToDataTable(List<clsQxUsersV2EN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsQxUsersV2EN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsQxUsersV2EN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsQxUsersV2EN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsQxUsersV2EN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsQxUsersV2EN.AttributeName)
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
if (clsQxUsersV2WApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsQxUsersV2EN._CurrTabName);
CacheHelper.Remove(strKey);
clsQxUsersV2WApi.objCommFun4WApi.ReFreshCache();
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
public static DataTable GetDataTableByObjLst(List<clsQxUsersV2EN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conQxUsersV2.CreateTime, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsersV2.updateTime, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsersV2.id, Type.GetType("System.Int32"));
objDT.Columns.Add(conQxUsersV2.DepartmentIdInt, Type.GetType("System.Int32"));
objDT.Columns.Add(conQxUsersV2.name, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsersV2.UserName, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsersV2.Password, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsersV2.psalt, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsersV2.nickName, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsersV2.headImg, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsersV2.Email, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsersV2.phone, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsersV2.remark, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsersV2.status, Type.GetType("System.Int32"));
objDT.Columns.Add(conQxUsersV2.OpenId, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsersV2.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsersV2.IsArchive, Type.GetType("System.Boolean"));
objDT.Columns.Add(conQxUsersV2.IdentityId, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsersV2.StuTeacherId, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsersV2.EffitiveBeginDate, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsersV2.EffitiveEndDate, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsersV2.UserId, Type.GetType("System.String"));
objDT.Columns.Add(conQxUsersV2.EffectiveDate, Type.GetType("System.String"));
foreach (clsQxUsersV2EN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conQxUsersV2.CreateTime] = objInFor[conQxUsersV2.CreateTime];
objDR[conQxUsersV2.updateTime] = objInFor[conQxUsersV2.updateTime];
objDR[conQxUsersV2.id] = objInFor[conQxUsersV2.id];
objDR[conQxUsersV2.DepartmentIdInt] = objInFor[conQxUsersV2.DepartmentIdInt];
objDR[conQxUsersV2.name] = objInFor[conQxUsersV2.name];
objDR[conQxUsersV2.UserName] = objInFor[conQxUsersV2.UserName];
objDR[conQxUsersV2.Password] = objInFor[conQxUsersV2.Password];
objDR[conQxUsersV2.psalt] = objInFor[conQxUsersV2.psalt];
objDR[conQxUsersV2.nickName] = objInFor[conQxUsersV2.nickName];
objDR[conQxUsersV2.headImg] = objInFor[conQxUsersV2.headImg];
objDR[conQxUsersV2.Email] = objInFor[conQxUsersV2.Email];
objDR[conQxUsersV2.phone] = objInFor[conQxUsersV2.phone];
objDR[conQxUsersV2.remark] = objInFor[conQxUsersV2.remark];
objDR[conQxUsersV2.status] = objInFor[conQxUsersV2.status];
objDR[conQxUsersV2.OpenId] = objInFor[conQxUsersV2.OpenId];
objDR[conQxUsersV2.UpdUser] = objInFor[conQxUsersV2.UpdUser];
objDR[conQxUsersV2.IsArchive] = objInFor[conQxUsersV2.IsArchive];
objDR[conQxUsersV2.IdentityId] = objInFor[conQxUsersV2.IdentityId];
objDR[conQxUsersV2.StuTeacherId] = objInFor[conQxUsersV2.StuTeacherId];
objDR[conQxUsersV2.EffitiveBeginDate] = objInFor[conQxUsersV2.EffitiveBeginDate];
objDR[conQxUsersV2.EffitiveEndDate] = objInFor[conQxUsersV2.EffitiveEndDate];
objDR[conQxUsersV2.UserId] = objInFor[conQxUsersV2.UserId];
objDR[conQxUsersV2.EffectiveDate] = objInFor[conQxUsersV2.EffectiveDate];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 用户V2(QxUsersV2)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4QxUsersV2 : clsCommFun4BL
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
clsQxUsersV2WApi.ReFreshThisCache();
}
}

}