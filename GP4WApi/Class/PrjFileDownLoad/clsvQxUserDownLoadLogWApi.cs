
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUserDownLoadLogWApi
 表名:vQxUserDownLoadLog(00140062)
 * 版本:2023.12.26.1(服务器:WIN-SRV103-116)
 日期:2023/12/28 18:56:49
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:工程文件下载(PrjFileDownLoad)
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
public static class  clsvQxUserDownLoadLogWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserDownLoadLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserDownLoadLogId">用户下载日志Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserDownLoadLogEN SetUserDownLoadLogId(this clsvQxUserDownLoadLogEN objvQxUserDownLoadLogEN, string strUserDownLoadLogId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserDownLoadLogId, 8, convQxUserDownLoadLog.UserDownLoadLogId);
clsCheckSql.CheckFieldForeignKey(strUserDownLoadLogId, 8, convQxUserDownLoadLog.UserDownLoadLogId);
objvQxUserDownLoadLogEN.UserDownLoadLogId = strUserDownLoadLogId; //用户下载日志Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserDownLoadLogEN.dicFldComparisonOp.ContainsKey(convQxUserDownLoadLog.UserDownLoadLogId) == false)
{
objvQxUserDownLoadLogEN.dicFldComparisonOp.Add(convQxUserDownLoadLog.UserDownLoadLogId, strComparisonOp);
}
else
{
objvQxUserDownLoadLogEN.dicFldComparisonOp[convQxUserDownLoadLog.UserDownLoadLogId] = strComparisonOp;
}
}
return objvQxUserDownLoadLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserDownLoadLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjSiteId">工程站点Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserDownLoadLogEN SetPrjSiteId(this clsvQxUserDownLoadLogEN objvQxUserDownLoadLogEN, string strPrjSiteId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjSiteId, convQxUserDownLoadLog.PrjSiteId);
clsCheckSql.CheckFieldLen(strPrjSiteId, 6, convQxUserDownLoadLog.PrjSiteId);
clsCheckSql.CheckFieldForeignKey(strPrjSiteId, 6, convQxUserDownLoadLog.PrjSiteId);
objvQxUserDownLoadLogEN.PrjSiteId = strPrjSiteId; //工程站点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserDownLoadLogEN.dicFldComparisonOp.ContainsKey(convQxUserDownLoadLog.PrjSiteId) == false)
{
objvQxUserDownLoadLogEN.dicFldComparisonOp.Add(convQxUserDownLoadLog.PrjSiteId, strComparisonOp);
}
else
{
objvQxUserDownLoadLogEN.dicFldComparisonOp[convQxUserDownLoadLog.PrjSiteId] = strComparisonOp;
}
}
return objvQxUserDownLoadLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserDownLoadLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjSiteName">工程站点名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserDownLoadLogEN SetPrjSiteName(this clsvQxUserDownLoadLogEN objvQxUserDownLoadLogEN, string strPrjSiteName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjSiteName, convQxUserDownLoadLog.PrjSiteName);
clsCheckSql.CheckFieldLen(strPrjSiteName, 50, convQxUserDownLoadLog.PrjSiteName);
objvQxUserDownLoadLogEN.PrjSiteName = strPrjSiteName; //工程站点名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserDownLoadLogEN.dicFldComparisonOp.ContainsKey(convQxUserDownLoadLog.PrjSiteName) == false)
{
objvQxUserDownLoadLogEN.dicFldComparisonOp.Add(convQxUserDownLoadLog.PrjSiteName, strComparisonOp);
}
else
{
objvQxUserDownLoadLogEN.dicFldComparisonOp[convQxUserDownLoadLog.PrjSiteName] = strComparisonOp;
}
}
return objvQxUserDownLoadLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserDownLoadLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strQxPrjId">项目Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserDownLoadLogEN SetQxPrjId(this clsvQxUserDownLoadLogEN objvQxUserDownLoadLogEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, convQxUserDownLoadLog.QxPrjId);
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxUserDownLoadLog.QxPrjId);
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxUserDownLoadLog.QxPrjId);
objvQxUserDownLoadLogEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserDownLoadLogEN.dicFldComparisonOp.ContainsKey(convQxUserDownLoadLog.QxPrjId) == false)
{
objvQxUserDownLoadLogEN.dicFldComparisonOp.Add(convQxUserDownLoadLog.QxPrjId, strComparisonOp);
}
else
{
objvQxUserDownLoadLogEN.dicFldComparisonOp[convQxUserDownLoadLog.QxPrjId] = strComparisonOp;
}
}
return objvQxUserDownLoadLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserDownLoadLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserDownLoadLogEN SetPrjName(this clsvQxUserDownLoadLogEN objvQxUserDownLoadLogEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convQxUserDownLoadLog.PrjName);
clsCheckSql.CheckFieldLen(strPrjName, 30, convQxUserDownLoadLog.PrjName);
objvQxUserDownLoadLogEN.PrjName = strPrjName; //工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserDownLoadLogEN.dicFldComparisonOp.ContainsKey(convQxUserDownLoadLog.PrjName) == false)
{
objvQxUserDownLoadLogEN.dicFldComparisonOp.Add(convQxUserDownLoadLog.PrjName, strComparisonOp);
}
else
{
objvQxUserDownLoadLogEN.dicFldComparisonOp[convQxUserDownLoadLog.PrjName] = strComparisonOp;
}
}
return objvQxUserDownLoadLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserDownLoadLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserDownLoadLogEN SetUserId(this clsvQxUserDownLoadLogEN objvQxUserDownLoadLogEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convQxUserDownLoadLog.UserId);
clsCheckSql.CheckFieldLen(strUserId, 18, convQxUserDownLoadLog.UserId);
objvQxUserDownLoadLogEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserDownLoadLogEN.dicFldComparisonOp.ContainsKey(convQxUserDownLoadLog.UserId) == false)
{
objvQxUserDownLoadLogEN.dicFldComparisonOp.Add(convQxUserDownLoadLog.UserId, strComparisonOp);
}
else
{
objvQxUserDownLoadLogEN.dicFldComparisonOp[convQxUserDownLoadLog.UserId] = strComparisonOp;
}
}
return objvQxUserDownLoadLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserDownLoadLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strDownLownDate">下载日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserDownLoadLogEN SetDownLownDate(this clsvQxUserDownLoadLogEN objvQxUserDownLoadLogEN, string strDownLownDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDownLownDate, convQxUserDownLoadLog.DownLownDate);
clsCheckSql.CheckFieldLen(strDownLownDate, 20, convQxUserDownLoadLog.DownLownDate);
objvQxUserDownLoadLogEN.DownLownDate = strDownLownDate; //下载日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserDownLoadLogEN.dicFldComparisonOp.ContainsKey(convQxUserDownLoadLog.DownLownDate) == false)
{
objvQxUserDownLoadLogEN.dicFldComparisonOp.Add(convQxUserDownLoadLog.DownLownDate, strComparisonOp);
}
else
{
objvQxUserDownLoadLogEN.dicFldComparisonOp[convQxUserDownLoadLog.DownLownDate] = strComparisonOp;
}
}
return objvQxUserDownLoadLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserDownLoadLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strLogInfo">日志信息</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserDownLoadLogEN SetLogInfo(this clsvQxUserDownLoadLogEN objvQxUserDownLoadLogEN, string strLogInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strLogInfo, convQxUserDownLoadLog.LogInfo);
clsCheckSql.CheckFieldLen(strLogInfo, 500, convQxUserDownLoadLog.LogInfo);
objvQxUserDownLoadLogEN.LogInfo = strLogInfo; //日志信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserDownLoadLogEN.dicFldComparisonOp.ContainsKey(convQxUserDownLoadLog.LogInfo) == false)
{
objvQxUserDownLoadLogEN.dicFldComparisonOp.Add(convQxUserDownLoadLog.LogInfo, strComparisonOp);
}
else
{
objvQxUserDownLoadLogEN.dicFldComparisonOp[convQxUserDownLoadLog.LogInfo] = strComparisonOp;
}
}
return objvQxUserDownLoadLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserDownLoadLogEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsSuccess">是否成功</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserDownLoadLogEN SetIsSuccess(this clsvQxUserDownLoadLogEN objvQxUserDownLoadLogEN, bool bolIsSuccess, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsSuccess, convQxUserDownLoadLog.IsSuccess);
objvQxUserDownLoadLogEN.IsSuccess = bolIsSuccess; //是否成功
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserDownLoadLogEN.dicFldComparisonOp.ContainsKey(convQxUserDownLoadLog.IsSuccess) == false)
{
objvQxUserDownLoadLogEN.dicFldComparisonOp.Add(convQxUserDownLoadLog.IsSuccess, strComparisonOp);
}
else
{
objvQxUserDownLoadLogEN.dicFldComparisonOp[convQxUserDownLoadLog.IsSuccess] = strComparisonOp;
}
}
return objvQxUserDownLoadLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserDownLoadLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strFtpServer">Ftp服务器</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserDownLoadLogEN SetFtpServer(this clsvQxUserDownLoadLogEN objvQxUserDownLoadLogEN, string strFtpServer, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFtpServer, convQxUserDownLoadLog.FtpServer);
clsCheckSql.CheckFieldLen(strFtpServer, 50, convQxUserDownLoadLog.FtpServer);
objvQxUserDownLoadLogEN.FtpServer = strFtpServer; //Ftp服务器
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserDownLoadLogEN.dicFldComparisonOp.ContainsKey(convQxUserDownLoadLog.FtpServer) == false)
{
objvQxUserDownLoadLogEN.dicFldComparisonOp.Add(convQxUserDownLoadLog.FtpServer, strComparisonOp);
}
else
{
objvQxUserDownLoadLogEN.dicFldComparisonOp[convQxUserDownLoadLog.FtpServer] = strComparisonOp;
}
}
return objvQxUserDownLoadLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserDownLoadLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strFtpUserId">Ftp用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserDownLoadLogEN SetFtpUserId(this clsvQxUserDownLoadLogEN objvQxUserDownLoadLogEN, string strFtpUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFtpUserId, convQxUserDownLoadLog.FtpUserId);
clsCheckSql.CheckFieldLen(strFtpUserId, 20, convQxUserDownLoadLog.FtpUserId);
objvQxUserDownLoadLogEN.FtpUserId = strFtpUserId; //Ftp用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserDownLoadLogEN.dicFldComparisonOp.ContainsKey(convQxUserDownLoadLog.FtpUserId) == false)
{
objvQxUserDownLoadLogEN.dicFldComparisonOp.Add(convQxUserDownLoadLog.FtpUserId, strComparisonOp);
}
else
{
objvQxUserDownLoadLogEN.dicFldComparisonOp[convQxUserDownLoadLog.FtpUserId] = strComparisonOp;
}
}
return objvQxUserDownLoadLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserDownLoadLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strFtpUserPassword">Ftp用户口令</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserDownLoadLogEN SetFtpUserPassword(this clsvQxUserDownLoadLogEN objvQxUserDownLoadLogEN, string strFtpUserPassword, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFtpUserPassword, convQxUserDownLoadLog.FtpUserPassword);
clsCheckSql.CheckFieldLen(strFtpUserPassword, 50, convQxUserDownLoadLog.FtpUserPassword);
objvQxUserDownLoadLogEN.FtpUserPassword = strFtpUserPassword; //Ftp用户口令
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserDownLoadLogEN.dicFldComparisonOp.ContainsKey(convQxUserDownLoadLog.FtpUserPassword) == false)
{
objvQxUserDownLoadLogEN.dicFldComparisonOp.Add(convQxUserDownLoadLog.FtpUserPassword, strComparisonOp);
}
else
{
objvQxUserDownLoadLogEN.dicFldComparisonOp[convQxUserDownLoadLog.FtpUserPassword] = strComparisonOp;
}
}
return objvQxUserDownLoadLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserDownLoadLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">备注</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserDownLoadLogEN SetMemo(this clsvQxUserDownLoadLogEN objvQxUserDownLoadLogEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxUserDownLoadLog.Memo);
objvQxUserDownLoadLogEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserDownLoadLogEN.dicFldComparisonOp.ContainsKey(convQxUserDownLoadLog.Memo) == false)
{
objvQxUserDownLoadLogEN.dicFldComparisonOp.Add(convQxUserDownLoadLog.Memo, strComparisonOp);
}
else
{
objvQxUserDownLoadLogEN.dicFldComparisonOp[convQxUserDownLoadLog.Memo] = strComparisonOp;
}
}
return objvQxUserDownLoadLogEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQxUserDownLoadLogEN objvQxUserDownLoadLogCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQxUserDownLoadLogCond.IsUpdated(convQxUserDownLoadLog.UserDownLoadLogId) == true)
{
string strComparisonOpUserDownLoadLogId = objvQxUserDownLoadLogCond.dicFldComparisonOp[convQxUserDownLoadLog.UserDownLoadLogId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserDownLoadLog.UserDownLoadLogId, objvQxUserDownLoadLogCond.UserDownLoadLogId, strComparisonOpUserDownLoadLogId);
}
if (objvQxUserDownLoadLogCond.IsUpdated(convQxUserDownLoadLog.PrjSiteId) == true)
{
string strComparisonOpPrjSiteId = objvQxUserDownLoadLogCond.dicFldComparisonOp[convQxUserDownLoadLog.PrjSiteId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserDownLoadLog.PrjSiteId, objvQxUserDownLoadLogCond.PrjSiteId, strComparisonOpPrjSiteId);
}
if (objvQxUserDownLoadLogCond.IsUpdated(convQxUserDownLoadLog.PrjSiteName) == true)
{
string strComparisonOpPrjSiteName = objvQxUserDownLoadLogCond.dicFldComparisonOp[convQxUserDownLoadLog.PrjSiteName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserDownLoadLog.PrjSiteName, objvQxUserDownLoadLogCond.PrjSiteName, strComparisonOpPrjSiteName);
}
if (objvQxUserDownLoadLogCond.IsUpdated(convQxUserDownLoadLog.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objvQxUserDownLoadLogCond.dicFldComparisonOp[convQxUserDownLoadLog.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserDownLoadLog.QxPrjId, objvQxUserDownLoadLogCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objvQxUserDownLoadLogCond.IsUpdated(convQxUserDownLoadLog.PrjName) == true)
{
string strComparisonOpPrjName = objvQxUserDownLoadLogCond.dicFldComparisonOp[convQxUserDownLoadLog.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserDownLoadLog.PrjName, objvQxUserDownLoadLogCond.PrjName, strComparisonOpPrjName);
}
if (objvQxUserDownLoadLogCond.IsUpdated(convQxUserDownLoadLog.UserId) == true)
{
string strComparisonOpUserId = objvQxUserDownLoadLogCond.dicFldComparisonOp[convQxUserDownLoadLog.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserDownLoadLog.UserId, objvQxUserDownLoadLogCond.UserId, strComparisonOpUserId);
}
if (objvQxUserDownLoadLogCond.IsUpdated(convQxUserDownLoadLog.DownLownDate) == true)
{
string strComparisonOpDownLownDate = objvQxUserDownLoadLogCond.dicFldComparisonOp[convQxUserDownLoadLog.DownLownDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserDownLoadLog.DownLownDate, objvQxUserDownLoadLogCond.DownLownDate, strComparisonOpDownLownDate);
}
if (objvQxUserDownLoadLogCond.IsUpdated(convQxUserDownLoadLog.LogInfo) == true)
{
string strComparisonOpLogInfo = objvQxUserDownLoadLogCond.dicFldComparisonOp[convQxUserDownLoadLog.LogInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserDownLoadLog.LogInfo, objvQxUserDownLoadLogCond.LogInfo, strComparisonOpLogInfo);
}
if (objvQxUserDownLoadLogCond.IsUpdated(convQxUserDownLoadLog.IsSuccess) == true)
{
if (objvQxUserDownLoadLogCond.IsSuccess == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQxUserDownLoadLog.IsSuccess);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQxUserDownLoadLog.IsSuccess);
}
}
if (objvQxUserDownLoadLogCond.IsUpdated(convQxUserDownLoadLog.FtpServer) == true)
{
string strComparisonOpFtpServer = objvQxUserDownLoadLogCond.dicFldComparisonOp[convQxUserDownLoadLog.FtpServer];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserDownLoadLog.FtpServer, objvQxUserDownLoadLogCond.FtpServer, strComparisonOpFtpServer);
}
if (objvQxUserDownLoadLogCond.IsUpdated(convQxUserDownLoadLog.FtpUserId) == true)
{
string strComparisonOpFtpUserId = objvQxUserDownLoadLogCond.dicFldComparisonOp[convQxUserDownLoadLog.FtpUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserDownLoadLog.FtpUserId, objvQxUserDownLoadLogCond.FtpUserId, strComparisonOpFtpUserId);
}
if (objvQxUserDownLoadLogCond.IsUpdated(convQxUserDownLoadLog.FtpUserPassword) == true)
{
string strComparisonOpFtpUserPassword = objvQxUserDownLoadLogCond.dicFldComparisonOp[convQxUserDownLoadLog.FtpUserPassword];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserDownLoadLog.FtpUserPassword, objvQxUserDownLoadLogCond.FtpUserPassword, strComparisonOpFtpUserPassword);
}
if (objvQxUserDownLoadLogCond.IsUpdated(convQxUserDownLoadLog.Memo) == true)
{
string strComparisonOpMemo = objvQxUserDownLoadLogCond.dicFldComparisonOp[convQxUserDownLoadLog.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserDownLoadLog.Memo, objvQxUserDownLoadLogCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v用户下载日志(vQxUserDownLoadLog)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxUserDownLoadLogWApi
{
private static readonly string mstrApiControllerName = "vQxUserDownLoadLogApi";

 public clsvQxUserDownLoadLogWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strUserDownLoadLogId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxUserDownLoadLogEN GetObjByUserDownLoadLogId(string strUserDownLoadLogId)
{
string strAction = "GetObjByUserDownLoadLogId";
clsvQxUserDownLoadLogEN objvQxUserDownLoadLogEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strUserDownLoadLogId"] = strUserDownLoadLogId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvQxUserDownLoadLogEN = JsonConvert.DeserializeObject<clsvQxUserDownLoadLogEN>(strJson);
return objvQxUserDownLoadLogEN;
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
public static clsvQxUserDownLoadLogEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvQxUserDownLoadLogEN objvQxUserDownLoadLogEN;
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
objvQxUserDownLoadLogEN = JsonConvert.DeserializeObject<clsvQxUserDownLoadLogEN>(strJson);
return objvQxUserDownLoadLogEN;
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
public static List<clsvQxUserDownLoadLogEN> GetObjLst(string strWhereCond)
{
 List<clsvQxUserDownLoadLogEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserDownLoadLogEN>>(strJson);
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
 /// <param name = "arrUserDownLoadLogId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUserDownLoadLogEN> GetObjLstByUserDownLoadLogIdLst(List<string> arrUserDownLoadLogId)
{
 List<clsvQxUserDownLoadLogEN> arrObjLst; 
string strAction = "GetObjLstByUserDownLoadLogIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrUserDownLoadLogId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserDownLoadLogEN>>(strJson);
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
public static List<clsvQxUserDownLoadLogEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvQxUserDownLoadLogEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserDownLoadLogEN>>(strJson);
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
public static List<clsvQxUserDownLoadLogEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvQxUserDownLoadLogEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserDownLoadLogEN>>(strJson);
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
public static List<clsvQxUserDownLoadLogEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvQxUserDownLoadLogEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserDownLoadLogEN>>(strJson);
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
public static List<clsvQxUserDownLoadLogEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvQxUserDownLoadLogEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserDownLoadLogEN>>(strJson);
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
public static bool IsExist(string strUserDownLoadLogId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strUserDownLoadLogId"] = strUserDownLoadLogId
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objvQxUserDownLoadLogENS">源对象</param>
 /// <param name = "objvQxUserDownLoadLogENT">目标对象</param>
 public static void CopyTo(clsvQxUserDownLoadLogEN objvQxUserDownLoadLogENS, clsvQxUserDownLoadLogEN objvQxUserDownLoadLogENT)
{
try
{
objvQxUserDownLoadLogENT.UserDownLoadLogId = objvQxUserDownLoadLogENS.UserDownLoadLogId; //用户下载日志Id
objvQxUserDownLoadLogENT.PrjSiteId = objvQxUserDownLoadLogENS.PrjSiteId; //工程站点Id
objvQxUserDownLoadLogENT.PrjSiteName = objvQxUserDownLoadLogENS.PrjSiteName; //工程站点名
objvQxUserDownLoadLogENT.QxPrjId = objvQxUserDownLoadLogENS.QxPrjId; //项目Id
objvQxUserDownLoadLogENT.PrjName = objvQxUserDownLoadLogENS.PrjName; //工程名
objvQxUserDownLoadLogENT.UserId = objvQxUserDownLoadLogENS.UserId; //用户ID
objvQxUserDownLoadLogENT.DownLownDate = objvQxUserDownLoadLogENS.DownLownDate; //下载日期
objvQxUserDownLoadLogENT.LogInfo = objvQxUserDownLoadLogENS.LogInfo; //日志信息
objvQxUserDownLoadLogENT.IsSuccess = objvQxUserDownLoadLogENS.IsSuccess; //是否成功
objvQxUserDownLoadLogENT.FtpServer = objvQxUserDownLoadLogENS.FtpServer; //Ftp服务器
objvQxUserDownLoadLogENT.FtpUserId = objvQxUserDownLoadLogENS.FtpUserId; //Ftp用户Id
objvQxUserDownLoadLogENT.FtpUserPassword = objvQxUserDownLoadLogENS.FtpUserPassword; //Ftp用户口令
objvQxUserDownLoadLogENT.Memo = objvQxUserDownLoadLogENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvQxUserDownLoadLogEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvQxUserDownLoadLogEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvQxUserDownLoadLogEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvQxUserDownLoadLogEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvQxUserDownLoadLogEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvQxUserDownLoadLogEN.AttributeName)
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
string strKey = string.Format("{0}", clsvQxUserDownLoadLogEN._CurrTabName);
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
//该表没有使用Cache,不需要生成[GetObjLstCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
//该表没有使用Cache,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvQxUserDownLoadLogEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convQxUserDownLoadLog.UserDownLoadLogId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserDownLoadLog.PrjSiteId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserDownLoadLog.PrjSiteName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserDownLoadLog.QxPrjId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserDownLoadLog.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserDownLoadLog.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserDownLoadLog.DownLownDate, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserDownLoadLog.LogInfo, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserDownLoadLog.IsSuccess, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQxUserDownLoadLog.FtpServer, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserDownLoadLog.FtpUserId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserDownLoadLog.FtpUserPassword, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserDownLoadLog.Memo, Type.GetType("System.String"));
foreach (clsvQxUserDownLoadLogEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convQxUserDownLoadLog.UserDownLoadLogId] = objInFor[convQxUserDownLoadLog.UserDownLoadLogId];
objDR[convQxUserDownLoadLog.PrjSiteId] = objInFor[convQxUserDownLoadLog.PrjSiteId];
objDR[convQxUserDownLoadLog.PrjSiteName] = objInFor[convQxUserDownLoadLog.PrjSiteName];
objDR[convQxUserDownLoadLog.QxPrjId] = objInFor[convQxUserDownLoadLog.QxPrjId];
objDR[convQxUserDownLoadLog.PrjName] = objInFor[convQxUserDownLoadLog.PrjName];
objDR[convQxUserDownLoadLog.UserId] = objInFor[convQxUserDownLoadLog.UserId];
objDR[convQxUserDownLoadLog.DownLownDate] = objInFor[convQxUserDownLoadLog.DownLownDate];
objDR[convQxUserDownLoadLog.LogInfo] = objInFor[convQxUserDownLoadLog.LogInfo];
objDR[convQxUserDownLoadLog.IsSuccess] = objInFor[convQxUserDownLoadLog.IsSuccess];
objDR[convQxUserDownLoadLog.FtpServer] = objInFor[convQxUserDownLoadLog.FtpServer];
objDR[convQxUserDownLoadLog.FtpUserId] = objInFor[convQxUserDownLoadLog.FtpUserId];
objDR[convQxUserDownLoadLog.FtpUserPassword] = objInFor[convQxUserDownLoadLog.FtpUserPassword];
objDR[convQxUserDownLoadLog.Memo] = objInFor[convQxUserDownLoadLog.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}