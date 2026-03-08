
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUserDownLoadDetailLogBL
 表名:vQxUserDownLoadDetailLog(00140063)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 17:47:38
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:工程文件下载(PrjFileDownLoad)
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
public static class  clsvQxUserDownLoadDetailLogBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxUserDownLoadDetailLogEN GetObj(this K_mId_vQxUserDownLoadDetailLog myKey)
{
clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN = clsvQxUserDownLoadDetailLogBL.vQxUserDownLoadDetailLogDA.GetObjBymId(myKey.Value);
return objvQxUserDownLoadDetailLogEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserDownLoadDetailLogEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserDownLoadDetailLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserDownLoadDetailLogEN SetUserDownLoadLogId(this clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN, string strUserDownLoadLogId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserDownLoadLogId, convQxUserDownLoadDetailLog.UserDownLoadLogId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserDownLoadLogId, 8, convQxUserDownLoadDetailLog.UserDownLoadLogId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserDownLoadLogId, 8, convQxUserDownLoadDetailLog.UserDownLoadLogId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserDownLoadDetailLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserDownLoadDetailLogEN SetPrjSiteId(this clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN, string strPrjSiteId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjSiteId, convQxUserDownLoadDetailLog.PrjSiteId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjSiteId, 6, convQxUserDownLoadDetailLog.PrjSiteId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjSiteId, 6, convQxUserDownLoadDetailLog.PrjSiteId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserDownLoadDetailLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserDownLoadDetailLogEN SetPrjSiteName(this clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN, string strPrjSiteName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjSiteName, convQxUserDownLoadDetailLog.PrjSiteName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjSiteName, 50, convQxUserDownLoadDetailLog.PrjSiteName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserDownLoadDetailLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserDownLoadDetailLogEN SetQxPrjId(this clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, convQxUserDownLoadDetailLog.QxPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxUserDownLoadDetailLog.QxPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxUserDownLoadDetailLog.QxPrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserDownLoadDetailLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserDownLoadDetailLogEN SetPrjName(this clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convQxUserDownLoadDetailLog.PrjName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convQxUserDownLoadDetailLog.PrjName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserDownLoadDetailLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserDownLoadDetailLogEN SetUserId(this clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convQxUserDownLoadDetailLog.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convQxUserDownLoadDetailLog.UserId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserDownLoadDetailLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserDownLoadDetailLogEN SetFileName(this clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFileName, convQxUserDownLoadDetailLog.FileName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileName, 500, convQxUserDownLoadDetailLog.FileName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserDownLoadDetailLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserDownLoadDetailLogEN SetVersion(this clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN, string strVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVersion, convQxUserDownLoadDetailLog.Version);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVersion, 30, convQxUserDownLoadDetailLog.Version);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserDownLoadDetailLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserDownLoadDetailLogEN SetDownLownDate(this clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN, string strDownLownDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDownLownDate, convQxUserDownLoadDetailLog.DownLownDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDownLownDate, 20, convQxUserDownLoadDetailLog.DownLownDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserDownLoadDetailLogEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserDownLoadDetailLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserDownLoadDetailLogEN SetLogInfo(this clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN, string strLogInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strLogInfo, convQxUserDownLoadDetailLog.LogInfo);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLogInfo, 500, convQxUserDownLoadDetailLog.LogInfo);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserDownLoadDetailLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserDownLoadDetailLogEN SetFtpServer(this clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN, string strFtpServer, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFtpServer, convQxUserDownLoadDetailLog.FtpServer);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFtpServer, 50, convQxUserDownLoadDetailLog.FtpServer);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserDownLoadDetailLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserDownLoadDetailLogEN SetFtpUserId(this clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN, string strFtpUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFtpUserId, convQxUserDownLoadDetailLog.FtpUserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFtpUserId, 20, convQxUserDownLoadDetailLog.FtpUserId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserDownLoadDetailLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserDownLoadDetailLogEN SetFtpUserPassword(this clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN, string strFtpUserPassword, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFtpUserPassword, convQxUserDownLoadDetailLog.FtpUserPassword);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFtpUserPassword, 50, convQxUserDownLoadDetailLog.FtpUserPassword);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserDownLoadDetailLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserDownLoadDetailLogEN SetMemo(this clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxUserDownLoadDetailLog.Memo);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvQxUserDownLoadDetailLogENS">源对象</param>
 /// <param name = "objvQxUserDownLoadDetailLogENT">目标对象</param>
 public static void CopyTo(this clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogENS, clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogENT)
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
 /// <param name = "objvQxUserDownLoadDetailLogENS">源对象</param>
 /// <returns>目标对象=>clsvQxUserDownLoadDetailLogEN:objvQxUserDownLoadDetailLogENT</returns>
 public static clsvQxUserDownLoadDetailLogEN CopyTo(this clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogENS)
{
try
{
 clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogENT = new clsvQxUserDownLoadDetailLogEN()
{
mId = objvQxUserDownLoadDetailLogENS.mId, //流水号
UserDownLoadLogId = objvQxUserDownLoadDetailLogENS.UserDownLoadLogId, //用户下载日志Id
PrjSiteId = objvQxUserDownLoadDetailLogENS.PrjSiteId, //工程站点Id
PrjSiteName = objvQxUserDownLoadDetailLogENS.PrjSiteName, //工程站点名
QxPrjId = objvQxUserDownLoadDetailLogENS.QxPrjId, //项目Id
PrjName = objvQxUserDownLoadDetailLogENS.PrjName, //工程名
UserId = objvQxUserDownLoadDetailLogENS.UserId, //用户ID
FileName = objvQxUserDownLoadDetailLogENS.FileName, //文件名
Version = objvQxUserDownLoadDetailLogENS.Version, //版本
DownLownDate = objvQxUserDownLoadDetailLogENS.DownLownDate, //下载日期
IsSuccess = objvQxUserDownLoadDetailLogENS.IsSuccess, //是否成功
LogInfo = objvQxUserDownLoadDetailLogENS.LogInfo, //日志信息
FtpServer = objvQxUserDownLoadDetailLogENS.FtpServer, //Ftp服务器
FtpUserId = objvQxUserDownLoadDetailLogENS.FtpUserId, //Ftp用户Id
FtpUserPassword = objvQxUserDownLoadDetailLogENS.FtpUserPassword, //Ftp用户口令
Memo = objvQxUserDownLoadDetailLogENS.Memo, //备注
};
 return objvQxUserDownLoadDetailLogENT;
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
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN)
{
 clsvQxUserDownLoadDetailLogBL.vQxUserDownLoadDetailLogDA.CheckProperty4Condition(objvQxUserDownLoadDetailLogEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vQxUserDownLoadDetailLog
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v用户下载日志细节(vQxUserDownLoadDetailLog)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvQxUserDownLoadDetailLogBL
{
public static RelatedActions_vQxUserDownLoadDetailLog relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "vQxUserDownLoadDetailLogListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "vQxUserDownLoadDetailLogList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsvQxUserDownLoadDetailLogEN> arrvQxUserDownLoadDetailLogObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvQxUserDownLoadDetailLogDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvQxUserDownLoadDetailLogDA vQxUserDownLoadDetailLogDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvQxUserDownLoadDetailLogDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvQxUserDownLoadDetailLogBL()
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
if (string.IsNullOrEmpty(clsvQxUserDownLoadDetailLogEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxUserDownLoadDetailLogEN._ConnectString);
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
objDS = vQxUserDownLoadDetailLogDA.GetDataSet(strWhereCond);
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
objDS = vQxUserDownLoadDetailLogDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = vQxUserDownLoadDetailLogDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_vQxUserDownLoadDetailLog(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQxUserDownLoadDetailLogDA.GetDataTable_vQxUserDownLoadDetailLog(strWhereCond);
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
objDT = vQxUserDownLoadDetailLogDA.GetDataTable(strWhereCond);
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
objDT = vQxUserDownLoadDetailLogDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vQxUserDownLoadDetailLogDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vQxUserDownLoadDetailLogDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vQxUserDownLoadDetailLogDA.GetDataTable_Top(objTopPara);
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
objDT = vQxUserDownLoadDetailLogDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vQxUserDownLoadDetailLogDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = vQxUserDownLoadDetailLogDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vQxUserDownLoadDetailLogDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = vQxUserDownLoadDetailLogDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = vQxUserDownLoadDetailLogDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = vQxUserDownLoadDetailLogDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = vQxUserDownLoadDetailLogDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
public static List<clsvQxUserDownLoadDetailLogEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvQxUserDownLoadDetailLogEN> arrObjLst = new List<clsvQxUserDownLoadDetailLogEN>(); 
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
	clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN = new clsvQxUserDownLoadDetailLogEN();
try
{
objvQxUserDownLoadDetailLogEN.mId = Int32.Parse(objRow[convQxUserDownLoadDetailLog.mId].ToString().Trim()); //流水号
objvQxUserDownLoadDetailLogEN.UserDownLoadLogId = objRow[convQxUserDownLoadDetailLog.UserDownLoadLogId].ToString().Trim(); //用户下载日志Id
objvQxUserDownLoadDetailLogEN.PrjSiteId = objRow[convQxUserDownLoadDetailLog.PrjSiteId].ToString().Trim(); //工程站点Id
objvQxUserDownLoadDetailLogEN.PrjSiteName = objRow[convQxUserDownLoadDetailLog.PrjSiteName].ToString().Trim(); //工程站点名
objvQxUserDownLoadDetailLogEN.QxPrjId = objRow[convQxUserDownLoadDetailLog.QxPrjId].ToString().Trim(); //项目Id
objvQxUserDownLoadDetailLogEN.PrjName = objRow[convQxUserDownLoadDetailLog.PrjName].ToString().Trim(); //工程名
objvQxUserDownLoadDetailLogEN.UserId = objRow[convQxUserDownLoadDetailLog.UserId].ToString().Trim(); //用户ID
objvQxUserDownLoadDetailLogEN.FileName = objRow[convQxUserDownLoadDetailLog.FileName].ToString().Trim(); //文件名
objvQxUserDownLoadDetailLogEN.Version = objRow[convQxUserDownLoadDetailLog.Version].ToString().Trim(); //版本
objvQxUserDownLoadDetailLogEN.DownLownDate = objRow[convQxUserDownLoadDetailLog.DownLownDate].ToString().Trim(); //下载日期
objvQxUserDownLoadDetailLogEN.IsSuccess = clsEntityBase2.TransNullToBool_S(objRow[convQxUserDownLoadDetailLog.IsSuccess].ToString().Trim()); //是否成功
objvQxUserDownLoadDetailLogEN.LogInfo = objRow[convQxUserDownLoadDetailLog.LogInfo].ToString().Trim(); //日志信息
objvQxUserDownLoadDetailLogEN.FtpServer = objRow[convQxUserDownLoadDetailLog.FtpServer].ToString().Trim(); //Ftp服务器
objvQxUserDownLoadDetailLogEN.FtpUserId = objRow[convQxUserDownLoadDetailLog.FtpUserId].ToString().Trim(); //Ftp用户Id
objvQxUserDownLoadDetailLogEN.FtpUserPassword = objRow[convQxUserDownLoadDetailLog.FtpUserPassword].ToString().Trim(); //Ftp用户口令
objvQxUserDownLoadDetailLogEN.Memo = objRow[convQxUserDownLoadDetailLog.Memo] == DBNull.Value ? null : objRow[convQxUserDownLoadDetailLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserDownLoadDetailLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserDownLoadDetailLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvQxUserDownLoadDetailLogEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvQxUserDownLoadDetailLogEN._CurrTabName);
List<clsvQxUserDownLoadDetailLogEN> arrvQxUserDownLoadDetailLogObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUserDownLoadDetailLogEN> arrvQxUserDownLoadDetailLogObjLst_Sel =
arrvQxUserDownLoadDetailLogObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvQxUserDownLoadDetailLogObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUserDownLoadDetailLogEN> GetObjLst(string strWhereCond)
{
List<clsvQxUserDownLoadDetailLogEN> arrObjLst = new List<clsvQxUserDownLoadDetailLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN = new clsvQxUserDownLoadDetailLogEN();
try
{
objvQxUserDownLoadDetailLogEN.mId = Int32.Parse(objRow[convQxUserDownLoadDetailLog.mId].ToString().Trim()); //流水号
objvQxUserDownLoadDetailLogEN.UserDownLoadLogId = objRow[convQxUserDownLoadDetailLog.UserDownLoadLogId].ToString().Trim(); //用户下载日志Id
objvQxUserDownLoadDetailLogEN.PrjSiteId = objRow[convQxUserDownLoadDetailLog.PrjSiteId].ToString().Trim(); //工程站点Id
objvQxUserDownLoadDetailLogEN.PrjSiteName = objRow[convQxUserDownLoadDetailLog.PrjSiteName].ToString().Trim(); //工程站点名
objvQxUserDownLoadDetailLogEN.QxPrjId = objRow[convQxUserDownLoadDetailLog.QxPrjId].ToString().Trim(); //项目Id
objvQxUserDownLoadDetailLogEN.PrjName = objRow[convQxUserDownLoadDetailLog.PrjName].ToString().Trim(); //工程名
objvQxUserDownLoadDetailLogEN.UserId = objRow[convQxUserDownLoadDetailLog.UserId].ToString().Trim(); //用户ID
objvQxUserDownLoadDetailLogEN.FileName = objRow[convQxUserDownLoadDetailLog.FileName].ToString().Trim(); //文件名
objvQxUserDownLoadDetailLogEN.Version = objRow[convQxUserDownLoadDetailLog.Version].ToString().Trim(); //版本
objvQxUserDownLoadDetailLogEN.DownLownDate = objRow[convQxUserDownLoadDetailLog.DownLownDate].ToString().Trim(); //下载日期
objvQxUserDownLoadDetailLogEN.IsSuccess = clsEntityBase2.TransNullToBool_S(objRow[convQxUserDownLoadDetailLog.IsSuccess].ToString().Trim()); //是否成功
objvQxUserDownLoadDetailLogEN.LogInfo = objRow[convQxUserDownLoadDetailLog.LogInfo].ToString().Trim(); //日志信息
objvQxUserDownLoadDetailLogEN.FtpServer = objRow[convQxUserDownLoadDetailLog.FtpServer].ToString().Trim(); //Ftp服务器
objvQxUserDownLoadDetailLogEN.FtpUserId = objRow[convQxUserDownLoadDetailLog.FtpUserId].ToString().Trim(); //Ftp用户Id
objvQxUserDownLoadDetailLogEN.FtpUserPassword = objRow[convQxUserDownLoadDetailLog.FtpUserPassword].ToString().Trim(); //Ftp用户口令
objvQxUserDownLoadDetailLogEN.Memo = objRow[convQxUserDownLoadDetailLog.Memo] == DBNull.Value ? null : objRow[convQxUserDownLoadDetailLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserDownLoadDetailLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserDownLoadDetailLogEN);
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
public static List<clsvQxUserDownLoadDetailLogEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQxUserDownLoadDetailLogEN> arrObjLst = new List<clsvQxUserDownLoadDetailLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN = new clsvQxUserDownLoadDetailLogEN();
try
{
objvQxUserDownLoadDetailLogEN.mId = Int32.Parse(objRow[convQxUserDownLoadDetailLog.mId].ToString().Trim()); //流水号
objvQxUserDownLoadDetailLogEN.UserDownLoadLogId = objRow[convQxUserDownLoadDetailLog.UserDownLoadLogId].ToString().Trim(); //用户下载日志Id
objvQxUserDownLoadDetailLogEN.PrjSiteId = objRow[convQxUserDownLoadDetailLog.PrjSiteId].ToString().Trim(); //工程站点Id
objvQxUserDownLoadDetailLogEN.PrjSiteName = objRow[convQxUserDownLoadDetailLog.PrjSiteName].ToString().Trim(); //工程站点名
objvQxUserDownLoadDetailLogEN.QxPrjId = objRow[convQxUserDownLoadDetailLog.QxPrjId].ToString().Trim(); //项目Id
objvQxUserDownLoadDetailLogEN.PrjName = objRow[convQxUserDownLoadDetailLog.PrjName].ToString().Trim(); //工程名
objvQxUserDownLoadDetailLogEN.UserId = objRow[convQxUserDownLoadDetailLog.UserId].ToString().Trim(); //用户ID
objvQxUserDownLoadDetailLogEN.FileName = objRow[convQxUserDownLoadDetailLog.FileName].ToString().Trim(); //文件名
objvQxUserDownLoadDetailLogEN.Version = objRow[convQxUserDownLoadDetailLog.Version].ToString().Trim(); //版本
objvQxUserDownLoadDetailLogEN.DownLownDate = objRow[convQxUserDownLoadDetailLog.DownLownDate].ToString().Trim(); //下载日期
objvQxUserDownLoadDetailLogEN.IsSuccess = clsEntityBase2.TransNullToBool_S(objRow[convQxUserDownLoadDetailLog.IsSuccess].ToString().Trim()); //是否成功
objvQxUserDownLoadDetailLogEN.LogInfo = objRow[convQxUserDownLoadDetailLog.LogInfo].ToString().Trim(); //日志信息
objvQxUserDownLoadDetailLogEN.FtpServer = objRow[convQxUserDownLoadDetailLog.FtpServer].ToString().Trim(); //Ftp服务器
objvQxUserDownLoadDetailLogEN.FtpUserId = objRow[convQxUserDownLoadDetailLog.FtpUserId].ToString().Trim(); //Ftp用户Id
objvQxUserDownLoadDetailLogEN.FtpUserPassword = objRow[convQxUserDownLoadDetailLog.FtpUserPassword].ToString().Trim(); //Ftp用户口令
objvQxUserDownLoadDetailLogEN.Memo = objRow[convQxUserDownLoadDetailLog.Memo] == DBNull.Value ? null : objRow[convQxUserDownLoadDetailLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserDownLoadDetailLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserDownLoadDetailLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvQxUserDownLoadDetailLogCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvQxUserDownLoadDetailLogEN> GetSubObjLstCache(clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogCond)
{
List<clsvQxUserDownLoadDetailLogEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUserDownLoadDetailLogEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxUserDownLoadDetailLog.AttributeName)
{
if (objvQxUserDownLoadDetailLogCond.IsUpdated(strFldName) == false) continue;
if (objvQxUserDownLoadDetailLogCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUserDownLoadDetailLogCond[strFldName].ToString());
}
else
{
if (objvQxUserDownLoadDetailLogCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxUserDownLoadDetailLogCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUserDownLoadDetailLogCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxUserDownLoadDetailLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxUserDownLoadDetailLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxUserDownLoadDetailLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxUserDownLoadDetailLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxUserDownLoadDetailLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxUserDownLoadDetailLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxUserDownLoadDetailLogCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxUserDownLoadDetailLogCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxUserDownLoadDetailLogCond[strFldName]));
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
public static List<clsvQxUserDownLoadDetailLogEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvQxUserDownLoadDetailLogEN> arrObjLst = new List<clsvQxUserDownLoadDetailLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN = new clsvQxUserDownLoadDetailLogEN();
try
{
objvQxUserDownLoadDetailLogEN.mId = Int32.Parse(objRow[convQxUserDownLoadDetailLog.mId].ToString().Trim()); //流水号
objvQxUserDownLoadDetailLogEN.UserDownLoadLogId = objRow[convQxUserDownLoadDetailLog.UserDownLoadLogId].ToString().Trim(); //用户下载日志Id
objvQxUserDownLoadDetailLogEN.PrjSiteId = objRow[convQxUserDownLoadDetailLog.PrjSiteId].ToString().Trim(); //工程站点Id
objvQxUserDownLoadDetailLogEN.PrjSiteName = objRow[convQxUserDownLoadDetailLog.PrjSiteName].ToString().Trim(); //工程站点名
objvQxUserDownLoadDetailLogEN.QxPrjId = objRow[convQxUserDownLoadDetailLog.QxPrjId].ToString().Trim(); //项目Id
objvQxUserDownLoadDetailLogEN.PrjName = objRow[convQxUserDownLoadDetailLog.PrjName].ToString().Trim(); //工程名
objvQxUserDownLoadDetailLogEN.UserId = objRow[convQxUserDownLoadDetailLog.UserId].ToString().Trim(); //用户ID
objvQxUserDownLoadDetailLogEN.FileName = objRow[convQxUserDownLoadDetailLog.FileName].ToString().Trim(); //文件名
objvQxUserDownLoadDetailLogEN.Version = objRow[convQxUserDownLoadDetailLog.Version].ToString().Trim(); //版本
objvQxUserDownLoadDetailLogEN.DownLownDate = objRow[convQxUserDownLoadDetailLog.DownLownDate].ToString().Trim(); //下载日期
objvQxUserDownLoadDetailLogEN.IsSuccess = clsEntityBase2.TransNullToBool_S(objRow[convQxUserDownLoadDetailLog.IsSuccess].ToString().Trim()); //是否成功
objvQxUserDownLoadDetailLogEN.LogInfo = objRow[convQxUserDownLoadDetailLog.LogInfo].ToString().Trim(); //日志信息
objvQxUserDownLoadDetailLogEN.FtpServer = objRow[convQxUserDownLoadDetailLog.FtpServer].ToString().Trim(); //Ftp服务器
objvQxUserDownLoadDetailLogEN.FtpUserId = objRow[convQxUserDownLoadDetailLog.FtpUserId].ToString().Trim(); //Ftp用户Id
objvQxUserDownLoadDetailLogEN.FtpUserPassword = objRow[convQxUserDownLoadDetailLog.FtpUserPassword].ToString().Trim(); //Ftp用户口令
objvQxUserDownLoadDetailLogEN.Memo = objRow[convQxUserDownLoadDetailLog.Memo] == DBNull.Value ? null : objRow[convQxUserDownLoadDetailLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserDownLoadDetailLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserDownLoadDetailLogEN);
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
public static List<clsvQxUserDownLoadDetailLogEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvQxUserDownLoadDetailLogEN> arrObjLst = new List<clsvQxUserDownLoadDetailLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN = new clsvQxUserDownLoadDetailLogEN();
try
{
objvQxUserDownLoadDetailLogEN.mId = Int32.Parse(objRow[convQxUserDownLoadDetailLog.mId].ToString().Trim()); //流水号
objvQxUserDownLoadDetailLogEN.UserDownLoadLogId = objRow[convQxUserDownLoadDetailLog.UserDownLoadLogId].ToString().Trim(); //用户下载日志Id
objvQxUserDownLoadDetailLogEN.PrjSiteId = objRow[convQxUserDownLoadDetailLog.PrjSiteId].ToString().Trim(); //工程站点Id
objvQxUserDownLoadDetailLogEN.PrjSiteName = objRow[convQxUserDownLoadDetailLog.PrjSiteName].ToString().Trim(); //工程站点名
objvQxUserDownLoadDetailLogEN.QxPrjId = objRow[convQxUserDownLoadDetailLog.QxPrjId].ToString().Trim(); //项目Id
objvQxUserDownLoadDetailLogEN.PrjName = objRow[convQxUserDownLoadDetailLog.PrjName].ToString().Trim(); //工程名
objvQxUserDownLoadDetailLogEN.UserId = objRow[convQxUserDownLoadDetailLog.UserId].ToString().Trim(); //用户ID
objvQxUserDownLoadDetailLogEN.FileName = objRow[convQxUserDownLoadDetailLog.FileName].ToString().Trim(); //文件名
objvQxUserDownLoadDetailLogEN.Version = objRow[convQxUserDownLoadDetailLog.Version].ToString().Trim(); //版本
objvQxUserDownLoadDetailLogEN.DownLownDate = objRow[convQxUserDownLoadDetailLog.DownLownDate].ToString().Trim(); //下载日期
objvQxUserDownLoadDetailLogEN.IsSuccess = clsEntityBase2.TransNullToBool_S(objRow[convQxUserDownLoadDetailLog.IsSuccess].ToString().Trim()); //是否成功
objvQxUserDownLoadDetailLogEN.LogInfo = objRow[convQxUserDownLoadDetailLog.LogInfo].ToString().Trim(); //日志信息
objvQxUserDownLoadDetailLogEN.FtpServer = objRow[convQxUserDownLoadDetailLog.FtpServer].ToString().Trim(); //Ftp服务器
objvQxUserDownLoadDetailLogEN.FtpUserId = objRow[convQxUserDownLoadDetailLog.FtpUserId].ToString().Trim(); //Ftp用户Id
objvQxUserDownLoadDetailLogEN.FtpUserPassword = objRow[convQxUserDownLoadDetailLog.FtpUserPassword].ToString().Trim(); //Ftp用户口令
objvQxUserDownLoadDetailLogEN.Memo = objRow[convQxUserDownLoadDetailLog.Memo] == DBNull.Value ? null : objRow[convQxUserDownLoadDetailLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserDownLoadDetailLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserDownLoadDetailLogEN);
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
List<clsvQxUserDownLoadDetailLogEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvQxUserDownLoadDetailLogEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUserDownLoadDetailLogEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvQxUserDownLoadDetailLogEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvQxUserDownLoadDetailLogEN> arrObjLst = new List<clsvQxUserDownLoadDetailLogEN>(); 
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
	clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN = new clsvQxUserDownLoadDetailLogEN();
try
{
objvQxUserDownLoadDetailLogEN.mId = Int32.Parse(objRow[convQxUserDownLoadDetailLog.mId].ToString().Trim()); //流水号
objvQxUserDownLoadDetailLogEN.UserDownLoadLogId = objRow[convQxUserDownLoadDetailLog.UserDownLoadLogId].ToString().Trim(); //用户下载日志Id
objvQxUserDownLoadDetailLogEN.PrjSiteId = objRow[convQxUserDownLoadDetailLog.PrjSiteId].ToString().Trim(); //工程站点Id
objvQxUserDownLoadDetailLogEN.PrjSiteName = objRow[convQxUserDownLoadDetailLog.PrjSiteName].ToString().Trim(); //工程站点名
objvQxUserDownLoadDetailLogEN.QxPrjId = objRow[convQxUserDownLoadDetailLog.QxPrjId].ToString().Trim(); //项目Id
objvQxUserDownLoadDetailLogEN.PrjName = objRow[convQxUserDownLoadDetailLog.PrjName].ToString().Trim(); //工程名
objvQxUserDownLoadDetailLogEN.UserId = objRow[convQxUserDownLoadDetailLog.UserId].ToString().Trim(); //用户ID
objvQxUserDownLoadDetailLogEN.FileName = objRow[convQxUserDownLoadDetailLog.FileName].ToString().Trim(); //文件名
objvQxUserDownLoadDetailLogEN.Version = objRow[convQxUserDownLoadDetailLog.Version].ToString().Trim(); //版本
objvQxUserDownLoadDetailLogEN.DownLownDate = objRow[convQxUserDownLoadDetailLog.DownLownDate].ToString().Trim(); //下载日期
objvQxUserDownLoadDetailLogEN.IsSuccess = clsEntityBase2.TransNullToBool_S(objRow[convQxUserDownLoadDetailLog.IsSuccess].ToString().Trim()); //是否成功
objvQxUserDownLoadDetailLogEN.LogInfo = objRow[convQxUserDownLoadDetailLog.LogInfo].ToString().Trim(); //日志信息
objvQxUserDownLoadDetailLogEN.FtpServer = objRow[convQxUserDownLoadDetailLog.FtpServer].ToString().Trim(); //Ftp服务器
objvQxUserDownLoadDetailLogEN.FtpUserId = objRow[convQxUserDownLoadDetailLog.FtpUserId].ToString().Trim(); //Ftp用户Id
objvQxUserDownLoadDetailLogEN.FtpUserPassword = objRow[convQxUserDownLoadDetailLog.FtpUserPassword].ToString().Trim(); //Ftp用户口令
objvQxUserDownLoadDetailLogEN.Memo = objRow[convQxUserDownLoadDetailLog.Memo] == DBNull.Value ? null : objRow[convQxUserDownLoadDetailLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserDownLoadDetailLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserDownLoadDetailLogEN);
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
public static List<clsvQxUserDownLoadDetailLogEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvQxUserDownLoadDetailLogEN> arrObjLst = new List<clsvQxUserDownLoadDetailLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN = new clsvQxUserDownLoadDetailLogEN();
try
{
objvQxUserDownLoadDetailLogEN.mId = Int32.Parse(objRow[convQxUserDownLoadDetailLog.mId].ToString().Trim()); //流水号
objvQxUserDownLoadDetailLogEN.UserDownLoadLogId = objRow[convQxUserDownLoadDetailLog.UserDownLoadLogId].ToString().Trim(); //用户下载日志Id
objvQxUserDownLoadDetailLogEN.PrjSiteId = objRow[convQxUserDownLoadDetailLog.PrjSiteId].ToString().Trim(); //工程站点Id
objvQxUserDownLoadDetailLogEN.PrjSiteName = objRow[convQxUserDownLoadDetailLog.PrjSiteName].ToString().Trim(); //工程站点名
objvQxUserDownLoadDetailLogEN.QxPrjId = objRow[convQxUserDownLoadDetailLog.QxPrjId].ToString().Trim(); //项目Id
objvQxUserDownLoadDetailLogEN.PrjName = objRow[convQxUserDownLoadDetailLog.PrjName].ToString().Trim(); //工程名
objvQxUserDownLoadDetailLogEN.UserId = objRow[convQxUserDownLoadDetailLog.UserId].ToString().Trim(); //用户ID
objvQxUserDownLoadDetailLogEN.FileName = objRow[convQxUserDownLoadDetailLog.FileName].ToString().Trim(); //文件名
objvQxUserDownLoadDetailLogEN.Version = objRow[convQxUserDownLoadDetailLog.Version].ToString().Trim(); //版本
objvQxUserDownLoadDetailLogEN.DownLownDate = objRow[convQxUserDownLoadDetailLog.DownLownDate].ToString().Trim(); //下载日期
objvQxUserDownLoadDetailLogEN.IsSuccess = clsEntityBase2.TransNullToBool_S(objRow[convQxUserDownLoadDetailLog.IsSuccess].ToString().Trim()); //是否成功
objvQxUserDownLoadDetailLogEN.LogInfo = objRow[convQxUserDownLoadDetailLog.LogInfo].ToString().Trim(); //日志信息
objvQxUserDownLoadDetailLogEN.FtpServer = objRow[convQxUserDownLoadDetailLog.FtpServer].ToString().Trim(); //Ftp服务器
objvQxUserDownLoadDetailLogEN.FtpUserId = objRow[convQxUserDownLoadDetailLog.FtpUserId].ToString().Trim(); //Ftp用户Id
objvQxUserDownLoadDetailLogEN.FtpUserPassword = objRow[convQxUserDownLoadDetailLog.FtpUserPassword].ToString().Trim(); //Ftp用户口令
objvQxUserDownLoadDetailLogEN.Memo = objRow[convQxUserDownLoadDetailLog.Memo] == DBNull.Value ? null : objRow[convQxUserDownLoadDetailLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserDownLoadDetailLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserDownLoadDetailLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQxUserDownLoadDetailLogEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvQxUserDownLoadDetailLogEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvQxUserDownLoadDetailLogEN> arrObjLst = new List<clsvQxUserDownLoadDetailLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN = new clsvQxUserDownLoadDetailLogEN();
try
{
objvQxUserDownLoadDetailLogEN.mId = Int32.Parse(objRow[convQxUserDownLoadDetailLog.mId].ToString().Trim()); //流水号
objvQxUserDownLoadDetailLogEN.UserDownLoadLogId = objRow[convQxUserDownLoadDetailLog.UserDownLoadLogId].ToString().Trim(); //用户下载日志Id
objvQxUserDownLoadDetailLogEN.PrjSiteId = objRow[convQxUserDownLoadDetailLog.PrjSiteId].ToString().Trim(); //工程站点Id
objvQxUserDownLoadDetailLogEN.PrjSiteName = objRow[convQxUserDownLoadDetailLog.PrjSiteName].ToString().Trim(); //工程站点名
objvQxUserDownLoadDetailLogEN.QxPrjId = objRow[convQxUserDownLoadDetailLog.QxPrjId].ToString().Trim(); //项目Id
objvQxUserDownLoadDetailLogEN.PrjName = objRow[convQxUserDownLoadDetailLog.PrjName].ToString().Trim(); //工程名
objvQxUserDownLoadDetailLogEN.UserId = objRow[convQxUserDownLoadDetailLog.UserId].ToString().Trim(); //用户ID
objvQxUserDownLoadDetailLogEN.FileName = objRow[convQxUserDownLoadDetailLog.FileName].ToString().Trim(); //文件名
objvQxUserDownLoadDetailLogEN.Version = objRow[convQxUserDownLoadDetailLog.Version].ToString().Trim(); //版本
objvQxUserDownLoadDetailLogEN.DownLownDate = objRow[convQxUserDownLoadDetailLog.DownLownDate].ToString().Trim(); //下载日期
objvQxUserDownLoadDetailLogEN.IsSuccess = clsEntityBase2.TransNullToBool_S(objRow[convQxUserDownLoadDetailLog.IsSuccess].ToString().Trim()); //是否成功
objvQxUserDownLoadDetailLogEN.LogInfo = objRow[convQxUserDownLoadDetailLog.LogInfo].ToString().Trim(); //日志信息
objvQxUserDownLoadDetailLogEN.FtpServer = objRow[convQxUserDownLoadDetailLog.FtpServer].ToString().Trim(); //Ftp服务器
objvQxUserDownLoadDetailLogEN.FtpUserId = objRow[convQxUserDownLoadDetailLog.FtpUserId].ToString().Trim(); //Ftp用户Id
objvQxUserDownLoadDetailLogEN.FtpUserPassword = objRow[convQxUserDownLoadDetailLog.FtpUserPassword].ToString().Trim(); //Ftp用户口令
objvQxUserDownLoadDetailLogEN.Memo = objRow[convQxUserDownLoadDetailLog.Memo] == DBNull.Value ? null : objRow[convQxUserDownLoadDetailLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserDownLoadDetailLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserDownLoadDetailLogEN);
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
public static List<clsvQxUserDownLoadDetailLogEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvQxUserDownLoadDetailLogEN> arrObjLst = new List<clsvQxUserDownLoadDetailLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN = new clsvQxUserDownLoadDetailLogEN();
try
{
objvQxUserDownLoadDetailLogEN.mId = Int32.Parse(objRow[convQxUserDownLoadDetailLog.mId].ToString().Trim()); //流水号
objvQxUserDownLoadDetailLogEN.UserDownLoadLogId = objRow[convQxUserDownLoadDetailLog.UserDownLoadLogId].ToString().Trim(); //用户下载日志Id
objvQxUserDownLoadDetailLogEN.PrjSiteId = objRow[convQxUserDownLoadDetailLog.PrjSiteId].ToString().Trim(); //工程站点Id
objvQxUserDownLoadDetailLogEN.PrjSiteName = objRow[convQxUserDownLoadDetailLog.PrjSiteName].ToString().Trim(); //工程站点名
objvQxUserDownLoadDetailLogEN.QxPrjId = objRow[convQxUserDownLoadDetailLog.QxPrjId].ToString().Trim(); //项目Id
objvQxUserDownLoadDetailLogEN.PrjName = objRow[convQxUserDownLoadDetailLog.PrjName].ToString().Trim(); //工程名
objvQxUserDownLoadDetailLogEN.UserId = objRow[convQxUserDownLoadDetailLog.UserId].ToString().Trim(); //用户ID
objvQxUserDownLoadDetailLogEN.FileName = objRow[convQxUserDownLoadDetailLog.FileName].ToString().Trim(); //文件名
objvQxUserDownLoadDetailLogEN.Version = objRow[convQxUserDownLoadDetailLog.Version].ToString().Trim(); //版本
objvQxUserDownLoadDetailLogEN.DownLownDate = objRow[convQxUserDownLoadDetailLog.DownLownDate].ToString().Trim(); //下载日期
objvQxUserDownLoadDetailLogEN.IsSuccess = clsEntityBase2.TransNullToBool_S(objRow[convQxUserDownLoadDetailLog.IsSuccess].ToString().Trim()); //是否成功
objvQxUserDownLoadDetailLogEN.LogInfo = objRow[convQxUserDownLoadDetailLog.LogInfo].ToString().Trim(); //日志信息
objvQxUserDownLoadDetailLogEN.FtpServer = objRow[convQxUserDownLoadDetailLog.FtpServer].ToString().Trim(); //Ftp服务器
objvQxUserDownLoadDetailLogEN.FtpUserId = objRow[convQxUserDownLoadDetailLog.FtpUserId].ToString().Trim(); //Ftp用户Id
objvQxUserDownLoadDetailLogEN.FtpUserPassword = objRow[convQxUserDownLoadDetailLog.FtpUserPassword].ToString().Trim(); //Ftp用户口令
objvQxUserDownLoadDetailLogEN.Memo = objRow[convQxUserDownLoadDetailLog.Memo] == DBNull.Value ? null : objRow[convQxUserDownLoadDetailLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserDownLoadDetailLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserDownLoadDetailLogEN);
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
public static IEnumerable<clsvQxUserDownLoadDetailLogEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogCond, string strOrderBy)
{
List<clsvQxUserDownLoadDetailLogEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUserDownLoadDetailLogEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxUserDownLoadDetailLog.AttributeName)
{
if (objvQxUserDownLoadDetailLogCond.IsUpdated(strFldName) == false) continue;
if (objvQxUserDownLoadDetailLogCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUserDownLoadDetailLogCond[strFldName].ToString());
}
else
{
if (objvQxUserDownLoadDetailLogCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxUserDownLoadDetailLogCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUserDownLoadDetailLogCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxUserDownLoadDetailLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxUserDownLoadDetailLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxUserDownLoadDetailLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxUserDownLoadDetailLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxUserDownLoadDetailLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxUserDownLoadDetailLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxUserDownLoadDetailLogCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxUserDownLoadDetailLogCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxUserDownLoadDetailLogCond[strFldName]));
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
public static IEnumerable<clsvQxUserDownLoadDetailLogEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogCond = JsonConvert.DeserializeObject<clsvQxUserDownLoadDetailLogEN>(objPagerPara.whereCond);
if (objvQxUserDownLoadDetailLogCond.sfFldComparisonOp == null)
{
objvQxUserDownLoadDetailLogCond.dicFldComparisonOp = null;
}
else
{
objvQxUserDownLoadDetailLogCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objvQxUserDownLoadDetailLogCond.sfFldComparisonOp);
}
clsvQxUserDownLoadDetailLogBL.SetUpdFlag(objvQxUserDownLoadDetailLogCond);
 try
{
CheckProperty4Condition(objvQxUserDownLoadDetailLogCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsvQxUserDownLoadDetailLogBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objvQxUserDownLoadDetailLogCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUserDownLoadDetailLogEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsvQxUserDownLoadDetailLogEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxUserDownLoadDetailLogEN> arrObjLst = new List<clsvQxUserDownLoadDetailLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN = new clsvQxUserDownLoadDetailLogEN();
try
{
objvQxUserDownLoadDetailLogEN.mId = Int32.Parse(objRow[convQxUserDownLoadDetailLog.mId].ToString().Trim()); //流水号
objvQxUserDownLoadDetailLogEN.UserDownLoadLogId = objRow[convQxUserDownLoadDetailLog.UserDownLoadLogId].ToString().Trim(); //用户下载日志Id
objvQxUserDownLoadDetailLogEN.PrjSiteId = objRow[convQxUserDownLoadDetailLog.PrjSiteId].ToString().Trim(); //工程站点Id
objvQxUserDownLoadDetailLogEN.PrjSiteName = objRow[convQxUserDownLoadDetailLog.PrjSiteName].ToString().Trim(); //工程站点名
objvQxUserDownLoadDetailLogEN.QxPrjId = objRow[convQxUserDownLoadDetailLog.QxPrjId].ToString().Trim(); //项目Id
objvQxUserDownLoadDetailLogEN.PrjName = objRow[convQxUserDownLoadDetailLog.PrjName].ToString().Trim(); //工程名
objvQxUserDownLoadDetailLogEN.UserId = objRow[convQxUserDownLoadDetailLog.UserId].ToString().Trim(); //用户ID
objvQxUserDownLoadDetailLogEN.FileName = objRow[convQxUserDownLoadDetailLog.FileName].ToString().Trim(); //文件名
objvQxUserDownLoadDetailLogEN.Version = objRow[convQxUserDownLoadDetailLog.Version].ToString().Trim(); //版本
objvQxUserDownLoadDetailLogEN.DownLownDate = objRow[convQxUserDownLoadDetailLog.DownLownDate].ToString().Trim(); //下载日期
objvQxUserDownLoadDetailLogEN.IsSuccess = clsEntityBase2.TransNullToBool_S(objRow[convQxUserDownLoadDetailLog.IsSuccess].ToString().Trim()); //是否成功
objvQxUserDownLoadDetailLogEN.LogInfo = objRow[convQxUserDownLoadDetailLog.LogInfo].ToString().Trim(); //日志信息
objvQxUserDownLoadDetailLogEN.FtpServer = objRow[convQxUserDownLoadDetailLog.FtpServer].ToString().Trim(); //Ftp服务器
objvQxUserDownLoadDetailLogEN.FtpUserId = objRow[convQxUserDownLoadDetailLog.FtpUserId].ToString().Trim(); //Ftp用户Id
objvQxUserDownLoadDetailLogEN.FtpUserPassword = objRow[convQxUserDownLoadDetailLog.FtpUserPassword].ToString().Trim(); //Ftp用户口令
objvQxUserDownLoadDetailLogEN.Memo = objRow[convQxUserDownLoadDetailLog.Memo] == DBNull.Value ? null : objRow[convQxUserDownLoadDetailLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserDownLoadDetailLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserDownLoadDetailLogEN);
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
public static List<clsvQxUserDownLoadDetailLogEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxUserDownLoadDetailLogEN> arrObjLst = new List<clsvQxUserDownLoadDetailLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN = new clsvQxUserDownLoadDetailLogEN();
try
{
objvQxUserDownLoadDetailLogEN.mId = Int32.Parse(objRow[convQxUserDownLoadDetailLog.mId].ToString().Trim()); //流水号
objvQxUserDownLoadDetailLogEN.UserDownLoadLogId = objRow[convQxUserDownLoadDetailLog.UserDownLoadLogId].ToString().Trim(); //用户下载日志Id
objvQxUserDownLoadDetailLogEN.PrjSiteId = objRow[convQxUserDownLoadDetailLog.PrjSiteId].ToString().Trim(); //工程站点Id
objvQxUserDownLoadDetailLogEN.PrjSiteName = objRow[convQxUserDownLoadDetailLog.PrjSiteName].ToString().Trim(); //工程站点名
objvQxUserDownLoadDetailLogEN.QxPrjId = objRow[convQxUserDownLoadDetailLog.QxPrjId].ToString().Trim(); //项目Id
objvQxUserDownLoadDetailLogEN.PrjName = objRow[convQxUserDownLoadDetailLog.PrjName].ToString().Trim(); //工程名
objvQxUserDownLoadDetailLogEN.UserId = objRow[convQxUserDownLoadDetailLog.UserId].ToString().Trim(); //用户ID
objvQxUserDownLoadDetailLogEN.FileName = objRow[convQxUserDownLoadDetailLog.FileName].ToString().Trim(); //文件名
objvQxUserDownLoadDetailLogEN.Version = objRow[convQxUserDownLoadDetailLog.Version].ToString().Trim(); //版本
objvQxUserDownLoadDetailLogEN.DownLownDate = objRow[convQxUserDownLoadDetailLog.DownLownDate].ToString().Trim(); //下载日期
objvQxUserDownLoadDetailLogEN.IsSuccess = clsEntityBase2.TransNullToBool_S(objRow[convQxUserDownLoadDetailLog.IsSuccess].ToString().Trim()); //是否成功
objvQxUserDownLoadDetailLogEN.LogInfo = objRow[convQxUserDownLoadDetailLog.LogInfo].ToString().Trim(); //日志信息
objvQxUserDownLoadDetailLogEN.FtpServer = objRow[convQxUserDownLoadDetailLog.FtpServer].ToString().Trim(); //Ftp服务器
objvQxUserDownLoadDetailLogEN.FtpUserId = objRow[convQxUserDownLoadDetailLog.FtpUserId].ToString().Trim(); //Ftp用户Id
objvQxUserDownLoadDetailLogEN.FtpUserPassword = objRow[convQxUserDownLoadDetailLog.FtpUserPassword].ToString().Trim(); //Ftp用户口令
objvQxUserDownLoadDetailLogEN.Memo = objRow[convQxUserDownLoadDetailLog.Memo] == DBNull.Value ? null : objRow[convQxUserDownLoadDetailLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserDownLoadDetailLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserDownLoadDetailLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUserDownLoadDetailLogEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvQxUserDownLoadDetailLogEN> arrObjLst = new List<clsvQxUserDownLoadDetailLogEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN = new clsvQxUserDownLoadDetailLogEN();
try
{
objvQxUserDownLoadDetailLogEN.mId = Int32.Parse(objRow[convQxUserDownLoadDetailLog.mId].ToString().Trim()); //流水号
objvQxUserDownLoadDetailLogEN.UserDownLoadLogId = objRow[convQxUserDownLoadDetailLog.UserDownLoadLogId].ToString().Trim(); //用户下载日志Id
objvQxUserDownLoadDetailLogEN.PrjSiteId = objRow[convQxUserDownLoadDetailLog.PrjSiteId].ToString().Trim(); //工程站点Id
objvQxUserDownLoadDetailLogEN.PrjSiteName = objRow[convQxUserDownLoadDetailLog.PrjSiteName].ToString().Trim(); //工程站点名
objvQxUserDownLoadDetailLogEN.QxPrjId = objRow[convQxUserDownLoadDetailLog.QxPrjId].ToString().Trim(); //项目Id
objvQxUserDownLoadDetailLogEN.PrjName = objRow[convQxUserDownLoadDetailLog.PrjName].ToString().Trim(); //工程名
objvQxUserDownLoadDetailLogEN.UserId = objRow[convQxUserDownLoadDetailLog.UserId].ToString().Trim(); //用户ID
objvQxUserDownLoadDetailLogEN.FileName = objRow[convQxUserDownLoadDetailLog.FileName].ToString().Trim(); //文件名
objvQxUserDownLoadDetailLogEN.Version = objRow[convQxUserDownLoadDetailLog.Version].ToString().Trim(); //版本
objvQxUserDownLoadDetailLogEN.DownLownDate = objRow[convQxUserDownLoadDetailLog.DownLownDate].ToString().Trim(); //下载日期
objvQxUserDownLoadDetailLogEN.IsSuccess = clsEntityBase2.TransNullToBool_S(objRow[convQxUserDownLoadDetailLog.IsSuccess].ToString().Trim()); //是否成功
objvQxUserDownLoadDetailLogEN.LogInfo = objRow[convQxUserDownLoadDetailLog.LogInfo].ToString().Trim(); //日志信息
objvQxUserDownLoadDetailLogEN.FtpServer = objRow[convQxUserDownLoadDetailLog.FtpServer].ToString().Trim(); //Ftp服务器
objvQxUserDownLoadDetailLogEN.FtpUserId = objRow[convQxUserDownLoadDetailLog.FtpUserId].ToString().Trim(); //Ftp用户Id
objvQxUserDownLoadDetailLogEN.FtpUserPassword = objRow[convQxUserDownLoadDetailLog.FtpUserPassword].ToString().Trim(); //Ftp用户口令
objvQxUserDownLoadDetailLogEN.Memo = objRow[convQxUserDownLoadDetailLog.Memo] == DBNull.Value ? null : objRow[convQxUserDownLoadDetailLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserDownLoadDetailLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserDownLoadDetailLogEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvQxUserDownLoadDetailLogEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxUserDownLoadDetailLog(ref clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN)
{
bool bolResult = vQxUserDownLoadDetailLogDA.GetvQxUserDownLoadDetailLog(ref objvQxUserDownLoadDetailLogEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxUserDownLoadDetailLogEN GetObjBymId(long lngmId)
{
clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN = vQxUserDownLoadDetailLogDA.GetObjBymId(lngmId);
return objvQxUserDownLoadDetailLogEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvQxUserDownLoadDetailLogEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN = vQxUserDownLoadDetailLogDA.GetFirstObj(strWhereCond);
 return objvQxUserDownLoadDetailLogEN;
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
public static clsvQxUserDownLoadDetailLogEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN = vQxUserDownLoadDetailLogDA.GetObjByDataRow(objRow);
 return objvQxUserDownLoadDetailLogEN;
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
public static clsvQxUserDownLoadDetailLogEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN = vQxUserDownLoadDetailLogDA.GetObjByDataRow(objRow);
 return objvQxUserDownLoadDetailLogEN;
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
 /// <param name = "lstvQxUserDownLoadDetailLogObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxUserDownLoadDetailLogEN GetObjBymIdFromList(long lngmId, List<clsvQxUserDownLoadDetailLogEN> lstvQxUserDownLoadDetailLogObjLst)
{
foreach (clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN in lstvQxUserDownLoadDetailLogObjLst)
{
if (objvQxUserDownLoadDetailLogEN.mId == lngmId)
{
return objvQxUserDownLoadDetailLogEN;
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
 lngmId = new clsvQxUserDownLoadDetailLogDA().GetFirstID(strWhereCond);
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
 arrList = vQxUserDownLoadDetailLogDA.GetID(strWhereCond);
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
bool bolIsExist = vQxUserDownLoadDetailLogDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vQxUserDownLoadDetailLogDA.IsExist(lngmId);
return bolIsExist;
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
 bolIsExist = clsvQxUserDownLoadDetailLogDA.IsExistTable();
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
 bolIsExist = vQxUserDownLoadDetailLogDA.IsExistTable(strTabName);
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


 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CopyObj_S)
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
 /// <param name = "objvQxUserDownLoadDetailLogEN">源简化对象</param>
 public static void SetUpdFlag(clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN)
{
try
{
objvQxUserDownLoadDetailLogEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvQxUserDownLoadDetailLogEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convQxUserDownLoadDetailLog.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserDownLoadDetailLogEN.mId = objvQxUserDownLoadDetailLogEN.mId; //流水号
}
if (arrFldSet.Contains(convQxUserDownLoadDetailLog.UserDownLoadLogId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserDownLoadDetailLogEN.UserDownLoadLogId = objvQxUserDownLoadDetailLogEN.UserDownLoadLogId; //用户下载日志Id
}
if (arrFldSet.Contains(convQxUserDownLoadDetailLog.PrjSiteId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserDownLoadDetailLogEN.PrjSiteId = objvQxUserDownLoadDetailLogEN.PrjSiteId; //工程站点Id
}
if (arrFldSet.Contains(convQxUserDownLoadDetailLog.PrjSiteName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserDownLoadDetailLogEN.PrjSiteName = objvQxUserDownLoadDetailLogEN.PrjSiteName; //工程站点名
}
if (arrFldSet.Contains(convQxUserDownLoadDetailLog.QxPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserDownLoadDetailLogEN.QxPrjId = objvQxUserDownLoadDetailLogEN.QxPrjId; //项目Id
}
if (arrFldSet.Contains(convQxUserDownLoadDetailLog.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserDownLoadDetailLogEN.PrjName = objvQxUserDownLoadDetailLogEN.PrjName; //工程名
}
if (arrFldSet.Contains(convQxUserDownLoadDetailLog.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserDownLoadDetailLogEN.UserId = objvQxUserDownLoadDetailLogEN.UserId; //用户ID
}
if (arrFldSet.Contains(convQxUserDownLoadDetailLog.FileName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserDownLoadDetailLogEN.FileName = objvQxUserDownLoadDetailLogEN.FileName; //文件名
}
if (arrFldSet.Contains(convQxUserDownLoadDetailLog.Version, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserDownLoadDetailLogEN.Version = objvQxUserDownLoadDetailLogEN.Version; //版本
}
if (arrFldSet.Contains(convQxUserDownLoadDetailLog.DownLownDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserDownLoadDetailLogEN.DownLownDate = objvQxUserDownLoadDetailLogEN.DownLownDate; //下载日期
}
if (arrFldSet.Contains(convQxUserDownLoadDetailLog.IsSuccess, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserDownLoadDetailLogEN.IsSuccess = objvQxUserDownLoadDetailLogEN.IsSuccess; //是否成功
}
if (arrFldSet.Contains(convQxUserDownLoadDetailLog.LogInfo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserDownLoadDetailLogEN.LogInfo = objvQxUserDownLoadDetailLogEN.LogInfo; //日志信息
}
if (arrFldSet.Contains(convQxUserDownLoadDetailLog.FtpServer, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserDownLoadDetailLogEN.FtpServer = objvQxUserDownLoadDetailLogEN.FtpServer; //Ftp服务器
}
if (arrFldSet.Contains(convQxUserDownLoadDetailLog.FtpUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserDownLoadDetailLogEN.FtpUserId = objvQxUserDownLoadDetailLogEN.FtpUserId; //Ftp用户Id
}
if (arrFldSet.Contains(convQxUserDownLoadDetailLog.FtpUserPassword, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserDownLoadDetailLogEN.FtpUserPassword = objvQxUserDownLoadDetailLogEN.FtpUserPassword; //Ftp用户口令
}
if (arrFldSet.Contains(convQxUserDownLoadDetailLog.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserDownLoadDetailLogEN.Memo = objvQxUserDownLoadDetailLogEN.Memo == "[null]" ? null :  objvQxUserDownLoadDetailLogEN.Memo; //备注
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
 /// <param name = "objvQxUserDownLoadDetailLogEN">源简化对象</param>
 public static void AccessFldValueNull(clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN)
{
try
{
if (objvQxUserDownLoadDetailLogEN.Memo == "[null]") objvQxUserDownLoadDetailLogEN.Memo = null; //备注
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
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN)
{
 vQxUserDownLoadDetailLogDA.CheckProperty4Condition(objvQxUserDownLoadDetailLogEN);
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
if (clsQxUserDownLoadDetailLogBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxUserDownLoadDetailLogBL没有刷新缓存机制(clsQxUserDownLoadDetailLogBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxUserDownLoadLogBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxUserDownLoadLogBL没有刷新缓存机制(clsQxUserDownLoadLogBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxProjectsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxProjectsBL没有刷新缓存机制(clsQxProjectsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxPrjSite4DownLoadBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxPrjSite4DownLoadBL没有刷新缓存机制(clsQxPrjSite4DownLoadBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvQxUserDownLoadDetailLogObjLstCache == null)
//{
//arrvQxUserDownLoadDetailLogObjLstCache = vQxUserDownLoadDetailLogDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxUserDownLoadDetailLogEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvQxUserDownLoadDetailLogEN._CurrTabName);
List<clsvQxUserDownLoadDetailLogEN> arrvQxUserDownLoadDetailLogObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUserDownLoadDetailLogEN> arrvQxUserDownLoadDetailLogObjLst_Sel =
arrvQxUserDownLoadDetailLogObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvQxUserDownLoadDetailLogObjLst_Sel.Count() == 0)
{
   clsvQxUserDownLoadDetailLogEN obj = clsvQxUserDownLoadDetailLogBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvQxUserDownLoadDetailLogObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxUserDownLoadDetailLogEN> GetAllvQxUserDownLoadDetailLogObjLstCache()
{
//获取缓存中的对象列表
List<clsvQxUserDownLoadDetailLogEN> arrvQxUserDownLoadDetailLogObjLstCache = GetObjLstCache(); 
return arrvQxUserDownLoadDetailLogObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxUserDownLoadDetailLogEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvQxUserDownLoadDetailLogEN._CurrTabName);
List<clsvQxUserDownLoadDetailLogEN> arrvQxUserDownLoadDetailLogObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQxUserDownLoadDetailLogObjLstCache;
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


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstvQxUserDownLoadDetailLogObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsvQxUserDownLoadDetailLogEN> lstvQxUserDownLoadDetailLogObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstvQxUserDownLoadDetailLogObjLst, writer);
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
 /// <param name = "lstvQxUserDownLoadDetailLogObjLst">[clsvQxUserDownLoadDetailLogEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsvQxUserDownLoadDetailLogEN> lstvQxUserDownLoadDetailLogObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsvQxUserDownLoadDetailLogBL.listXmlNode);
writer.WriteStartElement(clsvQxUserDownLoadDetailLogBL.itemsXmlNode);
foreach (clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN in lstvQxUserDownLoadDetailLogObjLst)
{
clsvQxUserDownLoadDetailLogBL.SerializeXML(writer, objvQxUserDownLoadDetailLogEN);
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
 /// <param name = "objvQxUserDownLoadDetailLogEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN)
{
writer.WriteStartElement(clsvQxUserDownLoadDetailLogBL.itemXmlNode);
 
writer.WriteElementString(convQxUserDownLoadDetailLog.mId, objvQxUserDownLoadDetailLogEN.mId.ToString(CultureInfo.InvariantCulture));
 
if (objvQxUserDownLoadDetailLogEN.UserDownLoadLogId != null)
{
writer.WriteElementString(convQxUserDownLoadDetailLog.UserDownLoadLogId, objvQxUserDownLoadDetailLogEN.UserDownLoadLogId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserDownLoadDetailLogEN.PrjSiteId != null)
{
writer.WriteElementString(convQxUserDownLoadDetailLog.PrjSiteId, objvQxUserDownLoadDetailLogEN.PrjSiteId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserDownLoadDetailLogEN.PrjSiteName != null)
{
writer.WriteElementString(convQxUserDownLoadDetailLog.PrjSiteName, objvQxUserDownLoadDetailLogEN.PrjSiteName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserDownLoadDetailLogEN.QxPrjId != null)
{
writer.WriteElementString(convQxUserDownLoadDetailLog.QxPrjId, objvQxUserDownLoadDetailLogEN.QxPrjId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserDownLoadDetailLogEN.PrjName != null)
{
writer.WriteElementString(convQxUserDownLoadDetailLog.PrjName, objvQxUserDownLoadDetailLogEN.PrjName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserDownLoadDetailLogEN.UserId != null)
{
writer.WriteElementString(convQxUserDownLoadDetailLog.UserId, objvQxUserDownLoadDetailLogEN.UserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserDownLoadDetailLogEN.FileName != null)
{
writer.WriteElementString(convQxUserDownLoadDetailLog.FileName, objvQxUserDownLoadDetailLogEN.FileName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserDownLoadDetailLogEN.Version != null)
{
writer.WriteElementString(convQxUserDownLoadDetailLog.Version, objvQxUserDownLoadDetailLogEN.Version.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserDownLoadDetailLogEN.DownLownDate != null)
{
writer.WriteElementString(convQxUserDownLoadDetailLog.DownLownDate, objvQxUserDownLoadDetailLogEN.DownLownDate.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convQxUserDownLoadDetailLog.IsSuccess, objvQxUserDownLoadDetailLogEN.IsSuccess.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objvQxUserDownLoadDetailLogEN.LogInfo != null)
{
writer.WriteElementString(convQxUserDownLoadDetailLog.LogInfo, objvQxUserDownLoadDetailLogEN.LogInfo.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserDownLoadDetailLogEN.FtpServer != null)
{
writer.WriteElementString(convQxUserDownLoadDetailLog.FtpServer, objvQxUserDownLoadDetailLogEN.FtpServer.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserDownLoadDetailLogEN.FtpUserId != null)
{
writer.WriteElementString(convQxUserDownLoadDetailLog.FtpUserId, objvQxUserDownLoadDetailLogEN.FtpUserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserDownLoadDetailLogEN.FtpUserPassword != null)
{
writer.WriteElementString(convQxUserDownLoadDetailLog.FtpUserPassword, objvQxUserDownLoadDetailLogEN.FtpUserPassword.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserDownLoadDetailLogEN.Memo != null)
{
writer.WriteElementString(convQxUserDownLoadDetailLog.Memo, objvQxUserDownLoadDetailLogEN.Memo.ToString(CultureInfo.InvariantCulture));
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
public static clsvQxUserDownLoadDetailLogEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN = new clsvQxUserDownLoadDetailLogEN();
reader.Read();
while (!(reader.Name == clsvQxUserDownLoadDetailLogBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(convQxUserDownLoadDetailLog.mId))
{
objvQxUserDownLoadDetailLogEN.mId = reader.ReadElementContentAsLong();
}
if (reader.IsStartElement(convQxUserDownLoadDetailLog.UserDownLoadLogId))
{
objvQxUserDownLoadDetailLogEN.UserDownLoadLogId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserDownLoadDetailLog.PrjSiteId))
{
objvQxUserDownLoadDetailLogEN.PrjSiteId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserDownLoadDetailLog.PrjSiteName))
{
objvQxUserDownLoadDetailLogEN.PrjSiteName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserDownLoadDetailLog.QxPrjId))
{
objvQxUserDownLoadDetailLogEN.QxPrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserDownLoadDetailLog.PrjName))
{
objvQxUserDownLoadDetailLogEN.PrjName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserDownLoadDetailLog.UserId))
{
objvQxUserDownLoadDetailLogEN.UserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserDownLoadDetailLog.FileName))
{
objvQxUserDownLoadDetailLogEN.FileName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserDownLoadDetailLog.Version))
{
objvQxUserDownLoadDetailLogEN.Version = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserDownLoadDetailLog.DownLownDate))
{
objvQxUserDownLoadDetailLogEN.DownLownDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserDownLoadDetailLog.IsSuccess))
{
objvQxUserDownLoadDetailLogEN.IsSuccess = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(convQxUserDownLoadDetailLog.LogInfo))
{
objvQxUserDownLoadDetailLogEN.LogInfo = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserDownLoadDetailLog.FtpServer))
{
objvQxUserDownLoadDetailLogEN.FtpServer = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserDownLoadDetailLog.FtpUserId))
{
objvQxUserDownLoadDetailLogEN.FtpUserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserDownLoadDetailLog.FtpUserPassword))
{
objvQxUserDownLoadDetailLogEN.FtpUserPassword = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserDownLoadDetailLog.Memo))
{
objvQxUserDownLoadDetailLogEN.Memo = reader.ReadElementContentAsString();
}
}
return objvQxUserDownLoadDetailLogEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strvQxUserDownLoadDetailLogObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsvQxUserDownLoadDetailLogEN GetObjFromXmlStr(string strvQxUserDownLoadDetailLogObjXmlStr)
{
clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN = new clsvQxUserDownLoadDetailLogEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strvQxUserDownLoadDetailLogObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsvQxUserDownLoadDetailLogBL.itemXmlNode))
{
objvQxUserDownLoadDetailLogEN = GetObjFromXml(reader);
return objvQxUserDownLoadDetailLogEN;
}
}
return objvQxUserDownLoadDetailLogEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objvQxUserDownLoadDetailLogEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objvQxUserDownLoadDetailLogEN);
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
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != convQxUserDownLoadDetailLog.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convQxUserDownLoadDetailLog.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convQxUserDownLoadDetailLog.AttributeName));
throw new Exception(strMsg);
}
var objvQxUserDownLoadDetailLog = clsvQxUserDownLoadDetailLogBL.GetObjBymIdCache(lngmId);
if (objvQxUserDownLoadDetailLog == null) return "";
return objvQxUserDownLoadDetailLog[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objvQxUserDownLoadDetailLogEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsvQxUserDownLoadDetailLogEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objvQxUserDownLoadDetailLogEN[strField]);
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
 /// <param name = "lstvQxUserDownLoadDetailLogObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsvQxUserDownLoadDetailLogEN> lstvQxUserDownLoadDetailLogObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstvQxUserDownLoadDetailLogObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogEN in lstvQxUserDownLoadDetailLogObjLst)
{
string strJSON_One = SerializeObjToJSON(objvQxUserDownLoadDetailLogEN);
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
int intRecCount = clsvQxUserDownLoadDetailLogDA.GetRecCount(strTabName);
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
int intRecCount = clsvQxUserDownLoadDetailLogDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvQxUserDownLoadDetailLogDA.GetRecCount();
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
int intRecCount = clsvQxUserDownLoadDetailLogDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvQxUserDownLoadDetailLogCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvQxUserDownLoadDetailLogEN objvQxUserDownLoadDetailLogCond)
{
List<clsvQxUserDownLoadDetailLogEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUserDownLoadDetailLogEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxUserDownLoadDetailLog.AttributeName)
{
if (objvQxUserDownLoadDetailLogCond.IsUpdated(strFldName) == false) continue;
if (objvQxUserDownLoadDetailLogCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUserDownLoadDetailLogCond[strFldName].ToString());
}
else
{
if (objvQxUserDownLoadDetailLogCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxUserDownLoadDetailLogCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUserDownLoadDetailLogCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxUserDownLoadDetailLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxUserDownLoadDetailLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxUserDownLoadDetailLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxUserDownLoadDetailLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxUserDownLoadDetailLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxUserDownLoadDetailLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxUserDownLoadDetailLogCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxUserDownLoadDetailLogCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxUserDownLoadDetailLogCond[strFldName]));
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
 List<string> arrList = clsvQxUserDownLoadDetailLogDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vQxUserDownLoadDetailLogDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vQxUserDownLoadDetailLogDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}