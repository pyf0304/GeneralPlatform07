
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUserDownLoadDetailLogWApi
 表名:vQxUserDownLoadDetailLog(00140063)
 * 版本:2023.12.26.1(服务器:WIN-SRV103-116)
 日期:2023/12/28 18:56:47
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
public static class  clsvQxUserDownLoadDetailLogWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserDownLoadDetailLogEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">流水号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserDownLoadDetailLogEN SetmId(this clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN, long lngmId, string strComparisonOp="")
	{
objvQxUserDownLoadDetailLogEN.mId = lngmId; //流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserDownLoadDetailLogEN.dicFldComparisonOp.ContainsKey(convQxUserDownLoadDetailLog.mId) == false)
{
objvQxUserDownLoadDetailLogEN.dicFldComparisonOp.Add(convQxUserDownLoadDetailLog.mId, strComparisonOp);
}
else
{
objvQxUserDownLoadDetailLogEN.dicFldComparisonOp[convQxUserDownLoadDetailLog.mId] = strComparisonOp;
}
}
return objvQxUserDownLoadDetailLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserDownLoadDetailLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserDownLoadLogId">用户下载日志Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserDownLoadDetailLogEN SetUserDownLoadLogId(this clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN, string strUserDownLoadLogId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserDownLoadLogId, convQxUserDownLoadDetailLog.UserDownLoadLogId);
clsCheckSql.CheckFieldLen(strUserDownLoadLogId, 8, convQxUserDownLoadDetailLog.UserDownLoadLogId);
clsCheckSql.CheckFieldForeignKey(strUserDownLoadLogId, 8, convQxUserDownLoadDetailLog.UserDownLoadLogId);
objvQxUserDownLoadDetailLogEN.UserDownLoadLogId = strUserDownLoadLogId; //用户下载日志Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserDownLoadDetailLogEN.dicFldComparisonOp.ContainsKey(convQxUserDownLoadDetailLog.UserDownLoadLogId) == false)
{
objvQxUserDownLoadDetailLogEN.dicFldComparisonOp.Add(convQxUserDownLoadDetailLog.UserDownLoadLogId, strComparisonOp);
}
else
{
objvQxUserDownLoadDetailLogEN.dicFldComparisonOp[convQxUserDownLoadDetailLog.UserDownLoadLogId] = strComparisonOp;
}
}
return objvQxUserDownLoadDetailLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserDownLoadDetailLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjSiteId">工程站点Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserDownLoadDetailLogEN SetPrjSiteId(this clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN, string strPrjSiteId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjSiteId, convQxUserDownLoadDetailLog.PrjSiteId);
clsCheckSql.CheckFieldLen(strPrjSiteId, 6, convQxUserDownLoadDetailLog.PrjSiteId);
clsCheckSql.CheckFieldForeignKey(strPrjSiteId, 6, convQxUserDownLoadDetailLog.PrjSiteId);
objvQxUserDownLoadDetailLogEN.PrjSiteId = strPrjSiteId; //工程站点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserDownLoadDetailLogEN.dicFldComparisonOp.ContainsKey(convQxUserDownLoadDetailLog.PrjSiteId) == false)
{
objvQxUserDownLoadDetailLogEN.dicFldComparisonOp.Add(convQxUserDownLoadDetailLog.PrjSiteId, strComparisonOp);
}
else
{
objvQxUserDownLoadDetailLogEN.dicFldComparisonOp[convQxUserDownLoadDetailLog.PrjSiteId] = strComparisonOp;
}
}
return objvQxUserDownLoadDetailLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserDownLoadDetailLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjSiteName">工程站点名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserDownLoadDetailLogEN SetPrjSiteName(this clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN, string strPrjSiteName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjSiteName, convQxUserDownLoadDetailLog.PrjSiteName);
clsCheckSql.CheckFieldLen(strPrjSiteName, 50, convQxUserDownLoadDetailLog.PrjSiteName);
objvQxUserDownLoadDetailLogEN.PrjSiteName = strPrjSiteName; //工程站点名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserDownLoadDetailLogEN.dicFldComparisonOp.ContainsKey(convQxUserDownLoadDetailLog.PrjSiteName) == false)
{
objvQxUserDownLoadDetailLogEN.dicFldComparisonOp.Add(convQxUserDownLoadDetailLog.PrjSiteName, strComparisonOp);
}
else
{
objvQxUserDownLoadDetailLogEN.dicFldComparisonOp[convQxUserDownLoadDetailLog.PrjSiteName] = strComparisonOp;
}
}
return objvQxUserDownLoadDetailLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserDownLoadDetailLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strQxPrjId">项目Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserDownLoadDetailLogEN SetQxPrjId(this clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, convQxUserDownLoadDetailLog.QxPrjId);
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxUserDownLoadDetailLog.QxPrjId);
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxUserDownLoadDetailLog.QxPrjId);
objvQxUserDownLoadDetailLogEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserDownLoadDetailLogEN.dicFldComparisonOp.ContainsKey(convQxUserDownLoadDetailLog.QxPrjId) == false)
{
objvQxUserDownLoadDetailLogEN.dicFldComparisonOp.Add(convQxUserDownLoadDetailLog.QxPrjId, strComparisonOp);
}
else
{
objvQxUserDownLoadDetailLogEN.dicFldComparisonOp[convQxUserDownLoadDetailLog.QxPrjId] = strComparisonOp;
}
}
return objvQxUserDownLoadDetailLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserDownLoadDetailLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserDownLoadDetailLogEN SetPrjName(this clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convQxUserDownLoadDetailLog.PrjName);
clsCheckSql.CheckFieldLen(strPrjName, 30, convQxUserDownLoadDetailLog.PrjName);
objvQxUserDownLoadDetailLogEN.PrjName = strPrjName; //工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserDownLoadDetailLogEN.dicFldComparisonOp.ContainsKey(convQxUserDownLoadDetailLog.PrjName) == false)
{
objvQxUserDownLoadDetailLogEN.dicFldComparisonOp.Add(convQxUserDownLoadDetailLog.PrjName, strComparisonOp);
}
else
{
objvQxUserDownLoadDetailLogEN.dicFldComparisonOp[convQxUserDownLoadDetailLog.PrjName] = strComparisonOp;
}
}
return objvQxUserDownLoadDetailLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserDownLoadDetailLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserDownLoadDetailLogEN SetUserId(this clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convQxUserDownLoadDetailLog.UserId);
clsCheckSql.CheckFieldLen(strUserId, 18, convQxUserDownLoadDetailLog.UserId);
objvQxUserDownLoadDetailLogEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserDownLoadDetailLogEN.dicFldComparisonOp.ContainsKey(convQxUserDownLoadDetailLog.UserId) == false)
{
objvQxUserDownLoadDetailLogEN.dicFldComparisonOp.Add(convQxUserDownLoadDetailLog.UserId, strComparisonOp);
}
else
{
objvQxUserDownLoadDetailLogEN.dicFldComparisonOp[convQxUserDownLoadDetailLog.UserId] = strComparisonOp;
}
}
return objvQxUserDownLoadDetailLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserDownLoadDetailLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strFileName">文件名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserDownLoadDetailLogEN SetFileName(this clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFileName, convQxUserDownLoadDetailLog.FileName);
clsCheckSql.CheckFieldLen(strFileName, 500, convQxUserDownLoadDetailLog.FileName);
objvQxUserDownLoadDetailLogEN.FileName = strFileName; //文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserDownLoadDetailLogEN.dicFldComparisonOp.ContainsKey(convQxUserDownLoadDetailLog.FileName) == false)
{
objvQxUserDownLoadDetailLogEN.dicFldComparisonOp.Add(convQxUserDownLoadDetailLog.FileName, strComparisonOp);
}
else
{
objvQxUserDownLoadDetailLogEN.dicFldComparisonOp[convQxUserDownLoadDetailLog.FileName] = strComparisonOp;
}
}
return objvQxUserDownLoadDetailLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserDownLoadDetailLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strVersion">版本</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserDownLoadDetailLogEN SetVersion(this clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN, string strVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVersion, convQxUserDownLoadDetailLog.Version);
clsCheckSql.CheckFieldLen(strVersion, 30, convQxUserDownLoadDetailLog.Version);
objvQxUserDownLoadDetailLogEN.Version = strVersion; //版本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserDownLoadDetailLogEN.dicFldComparisonOp.ContainsKey(convQxUserDownLoadDetailLog.Version) == false)
{
objvQxUserDownLoadDetailLogEN.dicFldComparisonOp.Add(convQxUserDownLoadDetailLog.Version, strComparisonOp);
}
else
{
objvQxUserDownLoadDetailLogEN.dicFldComparisonOp[convQxUserDownLoadDetailLog.Version] = strComparisonOp;
}
}
return objvQxUserDownLoadDetailLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserDownLoadDetailLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strDownLownDate">下载日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserDownLoadDetailLogEN SetDownLownDate(this clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN, string strDownLownDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDownLownDate, convQxUserDownLoadDetailLog.DownLownDate);
clsCheckSql.CheckFieldLen(strDownLownDate, 20, convQxUserDownLoadDetailLog.DownLownDate);
objvQxUserDownLoadDetailLogEN.DownLownDate = strDownLownDate; //下载日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserDownLoadDetailLogEN.dicFldComparisonOp.ContainsKey(convQxUserDownLoadDetailLog.DownLownDate) == false)
{
objvQxUserDownLoadDetailLogEN.dicFldComparisonOp.Add(convQxUserDownLoadDetailLog.DownLownDate, strComparisonOp);
}
else
{
objvQxUserDownLoadDetailLogEN.dicFldComparisonOp[convQxUserDownLoadDetailLog.DownLownDate] = strComparisonOp;
}
}
return objvQxUserDownLoadDetailLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserDownLoadDetailLogEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsSuccess">是否成功</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserDownLoadDetailLogEN SetIsSuccess(this clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN, bool bolIsSuccess, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsSuccess, convQxUserDownLoadDetailLog.IsSuccess);
objvQxUserDownLoadDetailLogEN.IsSuccess = bolIsSuccess; //是否成功
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserDownLoadDetailLogEN.dicFldComparisonOp.ContainsKey(convQxUserDownLoadDetailLog.IsSuccess) == false)
{
objvQxUserDownLoadDetailLogEN.dicFldComparisonOp.Add(convQxUserDownLoadDetailLog.IsSuccess, strComparisonOp);
}
else
{
objvQxUserDownLoadDetailLogEN.dicFldComparisonOp[convQxUserDownLoadDetailLog.IsSuccess] = strComparisonOp;
}
}
return objvQxUserDownLoadDetailLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserDownLoadDetailLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strLogInfo">日志信息</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserDownLoadDetailLogEN SetLogInfo(this clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN, string strLogInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strLogInfo, convQxUserDownLoadDetailLog.LogInfo);
clsCheckSql.CheckFieldLen(strLogInfo, 500, convQxUserDownLoadDetailLog.LogInfo);
objvQxUserDownLoadDetailLogEN.LogInfo = strLogInfo; //日志信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserDownLoadDetailLogEN.dicFldComparisonOp.ContainsKey(convQxUserDownLoadDetailLog.LogInfo) == false)
{
objvQxUserDownLoadDetailLogEN.dicFldComparisonOp.Add(convQxUserDownLoadDetailLog.LogInfo, strComparisonOp);
}
else
{
objvQxUserDownLoadDetailLogEN.dicFldComparisonOp[convQxUserDownLoadDetailLog.LogInfo] = strComparisonOp;
}
}
return objvQxUserDownLoadDetailLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserDownLoadDetailLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strFtpServer">Ftp服务器</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserDownLoadDetailLogEN SetFtpServer(this clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN, string strFtpServer, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFtpServer, convQxUserDownLoadDetailLog.FtpServer);
clsCheckSql.CheckFieldLen(strFtpServer, 50, convQxUserDownLoadDetailLog.FtpServer);
objvQxUserDownLoadDetailLogEN.FtpServer = strFtpServer; //Ftp服务器
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserDownLoadDetailLogEN.dicFldComparisonOp.ContainsKey(convQxUserDownLoadDetailLog.FtpServer) == false)
{
objvQxUserDownLoadDetailLogEN.dicFldComparisonOp.Add(convQxUserDownLoadDetailLog.FtpServer, strComparisonOp);
}
else
{
objvQxUserDownLoadDetailLogEN.dicFldComparisonOp[convQxUserDownLoadDetailLog.FtpServer] = strComparisonOp;
}
}
return objvQxUserDownLoadDetailLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserDownLoadDetailLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strFtpUserId">Ftp用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserDownLoadDetailLogEN SetFtpUserId(this clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN, string strFtpUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFtpUserId, convQxUserDownLoadDetailLog.FtpUserId);
clsCheckSql.CheckFieldLen(strFtpUserId, 20, convQxUserDownLoadDetailLog.FtpUserId);
objvQxUserDownLoadDetailLogEN.FtpUserId = strFtpUserId; //Ftp用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserDownLoadDetailLogEN.dicFldComparisonOp.ContainsKey(convQxUserDownLoadDetailLog.FtpUserId) == false)
{
objvQxUserDownLoadDetailLogEN.dicFldComparisonOp.Add(convQxUserDownLoadDetailLog.FtpUserId, strComparisonOp);
}
else
{
objvQxUserDownLoadDetailLogEN.dicFldComparisonOp[convQxUserDownLoadDetailLog.FtpUserId] = strComparisonOp;
}
}
return objvQxUserDownLoadDetailLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserDownLoadDetailLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strFtpUserPassword">Ftp用户口令</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserDownLoadDetailLogEN SetFtpUserPassword(this clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN, string strFtpUserPassword, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFtpUserPassword, convQxUserDownLoadDetailLog.FtpUserPassword);
clsCheckSql.CheckFieldLen(strFtpUserPassword, 50, convQxUserDownLoadDetailLog.FtpUserPassword);
objvQxUserDownLoadDetailLogEN.FtpUserPassword = strFtpUserPassword; //Ftp用户口令
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserDownLoadDetailLogEN.dicFldComparisonOp.ContainsKey(convQxUserDownLoadDetailLog.FtpUserPassword) == false)
{
objvQxUserDownLoadDetailLogEN.dicFldComparisonOp.Add(convQxUserDownLoadDetailLog.FtpUserPassword, strComparisonOp);
}
else
{
objvQxUserDownLoadDetailLogEN.dicFldComparisonOp[convQxUserDownLoadDetailLog.FtpUserPassword] = strComparisonOp;
}
}
return objvQxUserDownLoadDetailLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserDownLoadDetailLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">备注</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserDownLoadDetailLogEN SetMemo(this clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxUserDownLoadDetailLog.Memo);
objvQxUserDownLoadDetailLogEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserDownLoadDetailLogEN.dicFldComparisonOp.ContainsKey(convQxUserDownLoadDetailLog.Memo) == false)
{
objvQxUserDownLoadDetailLogEN.dicFldComparisonOp.Add(convQxUserDownLoadDetailLog.Memo, strComparisonOp);
}
else
{
objvQxUserDownLoadDetailLogEN.dicFldComparisonOp[convQxUserDownLoadDetailLog.Memo] = strComparisonOp;
}
}
return objvQxUserDownLoadDetailLogEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQxUserDownLoadDetailLogCond.IsUpdated(convQxUserDownLoadDetailLog.mId) == true)
{
string strComparisonOpmId = objvQxUserDownLoadDetailLogCond.dicFldComparisonOp[convQxUserDownLoadDetailLog.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convQxUserDownLoadDetailLog.mId, objvQxUserDownLoadDetailLogCond.mId, strComparisonOpmId);
}
if (objvQxUserDownLoadDetailLogCond.IsUpdated(convQxUserDownLoadDetailLog.UserDownLoadLogId) == true)
{
string strComparisonOpUserDownLoadLogId = objvQxUserDownLoadDetailLogCond.dicFldComparisonOp[convQxUserDownLoadDetailLog.UserDownLoadLogId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserDownLoadDetailLog.UserDownLoadLogId, objvQxUserDownLoadDetailLogCond.UserDownLoadLogId, strComparisonOpUserDownLoadLogId);
}
if (objvQxUserDownLoadDetailLogCond.IsUpdated(convQxUserDownLoadDetailLog.PrjSiteId) == true)
{
string strComparisonOpPrjSiteId = objvQxUserDownLoadDetailLogCond.dicFldComparisonOp[convQxUserDownLoadDetailLog.PrjSiteId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserDownLoadDetailLog.PrjSiteId, objvQxUserDownLoadDetailLogCond.PrjSiteId, strComparisonOpPrjSiteId);
}
if (objvQxUserDownLoadDetailLogCond.IsUpdated(convQxUserDownLoadDetailLog.PrjSiteName) == true)
{
string strComparisonOpPrjSiteName = objvQxUserDownLoadDetailLogCond.dicFldComparisonOp[convQxUserDownLoadDetailLog.PrjSiteName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserDownLoadDetailLog.PrjSiteName, objvQxUserDownLoadDetailLogCond.PrjSiteName, strComparisonOpPrjSiteName);
}
if (objvQxUserDownLoadDetailLogCond.IsUpdated(convQxUserDownLoadDetailLog.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objvQxUserDownLoadDetailLogCond.dicFldComparisonOp[convQxUserDownLoadDetailLog.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserDownLoadDetailLog.QxPrjId, objvQxUserDownLoadDetailLogCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objvQxUserDownLoadDetailLogCond.IsUpdated(convQxUserDownLoadDetailLog.PrjName) == true)
{
string strComparisonOpPrjName = objvQxUserDownLoadDetailLogCond.dicFldComparisonOp[convQxUserDownLoadDetailLog.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserDownLoadDetailLog.PrjName, objvQxUserDownLoadDetailLogCond.PrjName, strComparisonOpPrjName);
}
if (objvQxUserDownLoadDetailLogCond.IsUpdated(convQxUserDownLoadDetailLog.UserId) == true)
{
string strComparisonOpUserId = objvQxUserDownLoadDetailLogCond.dicFldComparisonOp[convQxUserDownLoadDetailLog.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserDownLoadDetailLog.UserId, objvQxUserDownLoadDetailLogCond.UserId, strComparisonOpUserId);
}
if (objvQxUserDownLoadDetailLogCond.IsUpdated(convQxUserDownLoadDetailLog.FileName) == true)
{
string strComparisonOpFileName = objvQxUserDownLoadDetailLogCond.dicFldComparisonOp[convQxUserDownLoadDetailLog.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserDownLoadDetailLog.FileName, objvQxUserDownLoadDetailLogCond.FileName, strComparisonOpFileName);
}
if (objvQxUserDownLoadDetailLogCond.IsUpdated(convQxUserDownLoadDetailLog.Version) == true)
{
string strComparisonOpVersion = objvQxUserDownLoadDetailLogCond.dicFldComparisonOp[convQxUserDownLoadDetailLog.Version];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserDownLoadDetailLog.Version, objvQxUserDownLoadDetailLogCond.Version, strComparisonOpVersion);
}
if (objvQxUserDownLoadDetailLogCond.IsUpdated(convQxUserDownLoadDetailLog.DownLownDate) == true)
{
string strComparisonOpDownLownDate = objvQxUserDownLoadDetailLogCond.dicFldComparisonOp[convQxUserDownLoadDetailLog.DownLownDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserDownLoadDetailLog.DownLownDate, objvQxUserDownLoadDetailLogCond.DownLownDate, strComparisonOpDownLownDate);
}
if (objvQxUserDownLoadDetailLogCond.IsUpdated(convQxUserDownLoadDetailLog.IsSuccess) == true)
{
if (objvQxUserDownLoadDetailLogCond.IsSuccess == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQxUserDownLoadDetailLog.IsSuccess);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQxUserDownLoadDetailLog.IsSuccess);
}
}
if (objvQxUserDownLoadDetailLogCond.IsUpdated(convQxUserDownLoadDetailLog.LogInfo) == true)
{
string strComparisonOpLogInfo = objvQxUserDownLoadDetailLogCond.dicFldComparisonOp[convQxUserDownLoadDetailLog.LogInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserDownLoadDetailLog.LogInfo, objvQxUserDownLoadDetailLogCond.LogInfo, strComparisonOpLogInfo);
}
if (objvQxUserDownLoadDetailLogCond.IsUpdated(convQxUserDownLoadDetailLog.FtpServer) == true)
{
string strComparisonOpFtpServer = objvQxUserDownLoadDetailLogCond.dicFldComparisonOp[convQxUserDownLoadDetailLog.FtpServer];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserDownLoadDetailLog.FtpServer, objvQxUserDownLoadDetailLogCond.FtpServer, strComparisonOpFtpServer);
}
if (objvQxUserDownLoadDetailLogCond.IsUpdated(convQxUserDownLoadDetailLog.FtpUserId) == true)
{
string strComparisonOpFtpUserId = objvQxUserDownLoadDetailLogCond.dicFldComparisonOp[convQxUserDownLoadDetailLog.FtpUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserDownLoadDetailLog.FtpUserId, objvQxUserDownLoadDetailLogCond.FtpUserId, strComparisonOpFtpUserId);
}
if (objvQxUserDownLoadDetailLogCond.IsUpdated(convQxUserDownLoadDetailLog.FtpUserPassword) == true)
{
string strComparisonOpFtpUserPassword = objvQxUserDownLoadDetailLogCond.dicFldComparisonOp[convQxUserDownLoadDetailLog.FtpUserPassword];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserDownLoadDetailLog.FtpUserPassword, objvQxUserDownLoadDetailLogCond.FtpUserPassword, strComparisonOpFtpUserPassword);
}
if (objvQxUserDownLoadDetailLogCond.IsUpdated(convQxUserDownLoadDetailLog.Memo) == true)
{
string strComparisonOpMemo = objvQxUserDownLoadDetailLogCond.dicFldComparisonOp[convQxUserDownLoadDetailLog.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserDownLoadDetailLog.Memo, objvQxUserDownLoadDetailLogCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v用户下载日志细节(vQxUserDownLoadDetailLog)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxUserDownLoadDetailLogWApi
{
private static readonly string mstrApiControllerName = "vQxUserDownLoadDetailLogApi";

 public clsvQxUserDownLoadDetailLogWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxUserDownLoadDetailLogEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN;
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
objvQxUserDownLoadDetailLogEN = JsonConvert.DeserializeObject<clsvQxUserDownLoadDetailLogEN>(strJson);
return objvQxUserDownLoadDetailLogEN;
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
public static clsvQxUserDownLoadDetailLogEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN;
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
objvQxUserDownLoadDetailLogEN = JsonConvert.DeserializeObject<clsvQxUserDownLoadDetailLogEN>(strJson);
return objvQxUserDownLoadDetailLogEN;
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
public static List<clsvQxUserDownLoadDetailLogEN> GetObjLst(string strWhereCond)
{
 List<clsvQxUserDownLoadDetailLogEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserDownLoadDetailLogEN>>(strJson);
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
public static List<clsvQxUserDownLoadDetailLogEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvQxUserDownLoadDetailLogEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserDownLoadDetailLogEN>>(strJson);
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
public static List<clsvQxUserDownLoadDetailLogEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvQxUserDownLoadDetailLogEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserDownLoadDetailLogEN>>(strJson);
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
public static List<clsvQxUserDownLoadDetailLogEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvQxUserDownLoadDetailLogEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserDownLoadDetailLogEN>>(strJson);
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
public static List<clsvQxUserDownLoadDetailLogEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvQxUserDownLoadDetailLogEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserDownLoadDetailLogEN>>(strJson);
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
public static List<clsvQxUserDownLoadDetailLogEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvQxUserDownLoadDetailLogEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserDownLoadDetailLogEN>>(strJson);
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objvQxUserDownLoadDetailLogENS">源对象</param>
 /// <param name = "objvQxUserDownLoadDetailLogENT">目标对象</param>
 public static void CopyTo(clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogENS, clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogENT)
{
try
{
objvQxUserDownLoadDetailLogENT.mId = objvQxUserDownLoadDetailLogENS.mId; //流水号
objvQxUserDownLoadDetailLogENT.UserDownLoadLogId = objvQxUserDownLoadDetailLogENS.UserDownLoadLogId; //用户下载日志Id
objvQxUserDownLoadDetailLogENT.PrjSiteId = objvQxUserDownLoadDetailLogENS.PrjSiteId; //工程站点Id
objvQxUserDownLoadDetailLogENT.PrjSiteName = objvQxUserDownLoadDetailLogENS.PrjSiteName; //工程站点名
objvQxUserDownLoadDetailLogENT.QxPrjId = objvQxUserDownLoadDetailLogENS.QxPrjId; //项目Id
objvQxUserDownLoadDetailLogENT.PrjName = objvQxUserDownLoadDetailLogENS.PrjName; //工程名
objvQxUserDownLoadDetailLogENT.UserId = objvQxUserDownLoadDetailLogENS.UserId; //用户ID
objvQxUserDownLoadDetailLogENT.FileName = objvQxUserDownLoadDetailLogENS.FileName; //文件名
objvQxUserDownLoadDetailLogENT.Version = objvQxUserDownLoadDetailLogENS.Version; //版本
objvQxUserDownLoadDetailLogENT.DownLownDate = objvQxUserDownLoadDetailLogENS.DownLownDate; //下载日期
objvQxUserDownLoadDetailLogENT.IsSuccess = objvQxUserDownLoadDetailLogENS.IsSuccess; //是否成功
objvQxUserDownLoadDetailLogENT.LogInfo = objvQxUserDownLoadDetailLogENS.LogInfo; //日志信息
objvQxUserDownLoadDetailLogENT.FtpServer = objvQxUserDownLoadDetailLogENS.FtpServer; //Ftp服务器
objvQxUserDownLoadDetailLogENT.FtpUserId = objvQxUserDownLoadDetailLogENS.FtpUserId; //Ftp用户Id
objvQxUserDownLoadDetailLogENT.FtpUserPassword = objvQxUserDownLoadDetailLogENS.FtpUserPassword; //Ftp用户口令
objvQxUserDownLoadDetailLogENT.Memo = objvQxUserDownLoadDetailLogENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvQxUserDownLoadDetailLogEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvQxUserDownLoadDetailLogEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvQxUserDownLoadDetailLogEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvQxUserDownLoadDetailLogEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvQxUserDownLoadDetailLogEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvQxUserDownLoadDetailLogEN.AttributeName)
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
string strKey = string.Format("{0}", clsvQxUserDownLoadDetailLogEN._CurrTabName);
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
public static DataTable GetDataTableByObjLst(List<clsvQxUserDownLoadDetailLogEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convQxUserDownLoadDetailLog.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convQxUserDownLoadDetailLog.UserDownLoadLogId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserDownLoadDetailLog.PrjSiteId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserDownLoadDetailLog.PrjSiteName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserDownLoadDetailLog.QxPrjId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserDownLoadDetailLog.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserDownLoadDetailLog.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserDownLoadDetailLog.FileName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserDownLoadDetailLog.Version, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserDownLoadDetailLog.DownLownDate, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserDownLoadDetailLog.IsSuccess, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQxUserDownLoadDetailLog.LogInfo, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserDownLoadDetailLog.FtpServer, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserDownLoadDetailLog.FtpUserId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserDownLoadDetailLog.FtpUserPassword, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserDownLoadDetailLog.Memo, Type.GetType("System.String"));
foreach (clsvQxUserDownLoadDetailLogEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convQxUserDownLoadDetailLog.mId] = objInFor[convQxUserDownLoadDetailLog.mId];
objDR[convQxUserDownLoadDetailLog.UserDownLoadLogId] = objInFor[convQxUserDownLoadDetailLog.UserDownLoadLogId];
objDR[convQxUserDownLoadDetailLog.PrjSiteId] = objInFor[convQxUserDownLoadDetailLog.PrjSiteId];
objDR[convQxUserDownLoadDetailLog.PrjSiteName] = objInFor[convQxUserDownLoadDetailLog.PrjSiteName];
objDR[convQxUserDownLoadDetailLog.QxPrjId] = objInFor[convQxUserDownLoadDetailLog.QxPrjId];
objDR[convQxUserDownLoadDetailLog.PrjName] = objInFor[convQxUserDownLoadDetailLog.PrjName];
objDR[convQxUserDownLoadDetailLog.UserId] = objInFor[convQxUserDownLoadDetailLog.UserId];
objDR[convQxUserDownLoadDetailLog.FileName] = objInFor[convQxUserDownLoadDetailLog.FileName];
objDR[convQxUserDownLoadDetailLog.Version] = objInFor[convQxUserDownLoadDetailLog.Version];
objDR[convQxUserDownLoadDetailLog.DownLownDate] = objInFor[convQxUserDownLoadDetailLog.DownLownDate];
objDR[convQxUserDownLoadDetailLog.IsSuccess] = objInFor[convQxUserDownLoadDetailLog.IsSuccess];
objDR[convQxUserDownLoadDetailLog.LogInfo] = objInFor[convQxUserDownLoadDetailLog.LogInfo];
objDR[convQxUserDownLoadDetailLog.FtpServer] = objInFor[convQxUserDownLoadDetailLog.FtpServer];
objDR[convQxUserDownLoadDetailLog.FtpUserId] = objInFor[convQxUserDownLoadDetailLog.FtpUserId];
objDR[convQxUserDownLoadDetailLog.FtpUserPassword] = objInFor[convQxUserDownLoadDetailLog.FtpUserPassword];
objDR[convQxUserDownLoadDetailLog.Memo] = objInFor[convQxUserDownLoadDetailLog.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}