
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPrjSite4DownLoadBL
 表名:vQxPrjSite4DownLoad(00140061)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 17:46:42
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
public static class  clsvQxPrjSite4DownLoadBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strPrjSiteId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxPrjSite4DownLoadEN GetObj(this K_PrjSiteId_vQxPrjSite4DownLoad myKey)
{
clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN = clsvQxPrjSite4DownLoadBL.vQxPrjSite4DownLoadDA.GetObjByPrjSiteId(myKey.Value);
return objvQxPrjSite4DownLoadEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjSite4DownLoadEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjSite4DownLoadEN SetPrjSiteId(this clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN, string strPrjSiteId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjSiteId, 6, convQxPrjSite4DownLoad.PrjSiteId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjSiteId, 6, convQxPrjSite4DownLoad.PrjSiteId);
}
objvQxPrjSite4DownLoadEN.PrjSiteId = strPrjSiteId; //工程站点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjSite4DownLoadEN.dicFldComparisonOp.ContainsKey(convQxPrjSite4DownLoad.PrjSiteId) == false)
{
objvQxPrjSite4DownLoadEN.dicFldComparisonOp.Add(convQxPrjSite4DownLoad.PrjSiteId, strComparisonOp);
}
else
{
objvQxPrjSite4DownLoadEN.dicFldComparisonOp[convQxPrjSite4DownLoad.PrjSiteId] = strComparisonOp;
}
}
return objvQxPrjSite4DownLoadEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjSite4DownLoadEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjSite4DownLoadEN SetPrjSiteName(this clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN, string strPrjSiteName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjSiteName, convQxPrjSite4DownLoad.PrjSiteName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjSiteName, 50, convQxPrjSite4DownLoad.PrjSiteName);
}
objvQxPrjSite4DownLoadEN.PrjSiteName = strPrjSiteName; //工程站点名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjSite4DownLoadEN.dicFldComparisonOp.ContainsKey(convQxPrjSite4DownLoad.PrjSiteName) == false)
{
objvQxPrjSite4DownLoadEN.dicFldComparisonOp.Add(convQxPrjSite4DownLoad.PrjSiteName, strComparisonOp);
}
else
{
objvQxPrjSite4DownLoadEN.dicFldComparisonOp[convQxPrjSite4DownLoad.PrjSiteName] = strComparisonOp;
}
}
return objvQxPrjSite4DownLoadEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjSite4DownLoadEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjSite4DownLoadEN SetQxPrjId(this clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, convQxPrjSite4DownLoad.QxPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxPrjSite4DownLoad.QxPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxPrjSite4DownLoad.QxPrjId);
}
objvQxPrjSite4DownLoadEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjSite4DownLoadEN.dicFldComparisonOp.ContainsKey(convQxPrjSite4DownLoad.QxPrjId) == false)
{
objvQxPrjSite4DownLoadEN.dicFldComparisonOp.Add(convQxPrjSite4DownLoad.QxPrjId, strComparisonOp);
}
else
{
objvQxPrjSite4DownLoadEN.dicFldComparisonOp[convQxPrjSite4DownLoad.QxPrjId] = strComparisonOp;
}
}
return objvQxPrjSite4DownLoadEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjSite4DownLoadEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjSite4DownLoadEN SetPrjName(this clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convQxPrjSite4DownLoad.PrjName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convQxPrjSite4DownLoad.PrjName);
}
objvQxPrjSite4DownLoadEN.PrjName = strPrjName; //工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjSite4DownLoadEN.dicFldComparisonOp.ContainsKey(convQxPrjSite4DownLoad.PrjName) == false)
{
objvQxPrjSite4DownLoadEN.dicFldComparisonOp.Add(convQxPrjSite4DownLoad.PrjName, strComparisonOp);
}
else
{
objvQxPrjSite4DownLoadEN.dicFldComparisonOp[convQxPrjSite4DownLoad.PrjName] = strComparisonOp;
}
}
return objvQxPrjSite4DownLoadEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjSite4DownLoadEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjSite4DownLoadEN SetFtpServer(this clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN, string strFtpServer, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFtpServer, convQxPrjSite4DownLoad.FtpServer);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFtpServer, 50, convQxPrjSite4DownLoad.FtpServer);
}
objvQxPrjSite4DownLoadEN.FtpServer = strFtpServer; //Ftp服务器
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjSite4DownLoadEN.dicFldComparisonOp.ContainsKey(convQxPrjSite4DownLoad.FtpServer) == false)
{
objvQxPrjSite4DownLoadEN.dicFldComparisonOp.Add(convQxPrjSite4DownLoad.FtpServer, strComparisonOp);
}
else
{
objvQxPrjSite4DownLoadEN.dicFldComparisonOp[convQxPrjSite4DownLoad.FtpServer] = strComparisonOp;
}
}
return objvQxPrjSite4DownLoadEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjSite4DownLoadEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjSite4DownLoadEN SetFtpUserId(this clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN, string strFtpUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFtpUserId, convQxPrjSite4DownLoad.FtpUserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFtpUserId, 20, convQxPrjSite4DownLoad.FtpUserId);
}
objvQxPrjSite4DownLoadEN.FtpUserId = strFtpUserId; //Ftp用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjSite4DownLoadEN.dicFldComparisonOp.ContainsKey(convQxPrjSite4DownLoad.FtpUserId) == false)
{
objvQxPrjSite4DownLoadEN.dicFldComparisonOp.Add(convQxPrjSite4DownLoad.FtpUserId, strComparisonOp);
}
else
{
objvQxPrjSite4DownLoadEN.dicFldComparisonOp[convQxPrjSite4DownLoad.FtpUserId] = strComparisonOp;
}
}
return objvQxPrjSite4DownLoadEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjSite4DownLoadEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjSite4DownLoadEN SetFtpUserPassword(this clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN, string strFtpUserPassword, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFtpUserPassword, convQxPrjSite4DownLoad.FtpUserPassword);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFtpUserPassword, 50, convQxPrjSite4DownLoad.FtpUserPassword);
}
objvQxPrjSite4DownLoadEN.FtpUserPassword = strFtpUserPassword; //Ftp用户口令
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjSite4DownLoadEN.dicFldComparisonOp.ContainsKey(convQxPrjSite4DownLoad.FtpUserPassword) == false)
{
objvQxPrjSite4DownLoadEN.dicFldComparisonOp.Add(convQxPrjSite4DownLoad.FtpUserPassword, strComparisonOp);
}
else
{
objvQxPrjSite4DownLoadEN.dicFldComparisonOp[convQxPrjSite4DownLoad.FtpUserPassword] = strComparisonOp;
}
}
return objvQxPrjSite4DownLoadEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjSite4DownLoadEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjSite4DownLoadEN SetUpdUserId(this clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUserId, convQxPrjSite4DownLoad.UpdUserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convQxPrjSite4DownLoad.UpdUserId);
}
objvQxPrjSite4DownLoadEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjSite4DownLoadEN.dicFldComparisonOp.ContainsKey(convQxPrjSite4DownLoad.UpdUserId) == false)
{
objvQxPrjSite4DownLoadEN.dicFldComparisonOp.Add(convQxPrjSite4DownLoad.UpdUserId, strComparisonOp);
}
else
{
objvQxPrjSite4DownLoadEN.dicFldComparisonOp[convQxPrjSite4DownLoad.UpdUserId] = strComparisonOp;
}
}
return objvQxPrjSite4DownLoadEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjSite4DownLoadEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjSite4DownLoadEN SetUpdDate(this clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQxPrjSite4DownLoad.UpdDate);
}
objvQxPrjSite4DownLoadEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjSite4DownLoadEN.dicFldComparisonOp.ContainsKey(convQxPrjSite4DownLoad.UpdDate) == false)
{
objvQxPrjSite4DownLoadEN.dicFldComparisonOp.Add(convQxPrjSite4DownLoad.UpdDate, strComparisonOp);
}
else
{
objvQxPrjSite4DownLoadEN.dicFldComparisonOp[convQxPrjSite4DownLoad.UpdDate] = strComparisonOp;
}
}
return objvQxPrjSite4DownLoadEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjSite4DownLoadEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjSite4DownLoadEN SetMemo(this clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxPrjSite4DownLoad.Memo);
}
objvQxPrjSite4DownLoadEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjSite4DownLoadEN.dicFldComparisonOp.ContainsKey(convQxPrjSite4DownLoad.Memo) == false)
{
objvQxPrjSite4DownLoadEN.dicFldComparisonOp.Add(convQxPrjSite4DownLoad.Memo, strComparisonOp);
}
else
{
objvQxPrjSite4DownLoadEN.dicFldComparisonOp[convQxPrjSite4DownLoad.Memo] = strComparisonOp;
}
}
return objvQxPrjSite4DownLoadEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvQxPrjSite4DownLoadENS">源对象</param>
 /// <param name = "objvQxPrjSite4DownLoadENT">目标对象</param>
 public static void CopyTo(this clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadENS, clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadENT)
{
try
{
objvQxPrjSite4DownLoadENT.PrjSiteId = objvQxPrjSite4DownLoadENS.PrjSiteId; //工程站点Id
objvQxPrjSite4DownLoadENT.PrjSiteName = objvQxPrjSite4DownLoadENS.PrjSiteName; //工程站点名
objvQxPrjSite4DownLoadENT.QxPrjId = objvQxPrjSite4DownLoadENS.QxPrjId; //项目Id
objvQxPrjSite4DownLoadENT.PrjName = objvQxPrjSite4DownLoadENS.PrjName; //工程名
objvQxPrjSite4DownLoadENT.FtpServer = objvQxPrjSite4DownLoadENS.FtpServer; //Ftp服务器
objvQxPrjSite4DownLoadENT.FtpUserId = objvQxPrjSite4DownLoadENS.FtpUserId; //Ftp用户Id
objvQxPrjSite4DownLoadENT.FtpUserPassword = objvQxPrjSite4DownLoadENS.FtpUserPassword; //Ftp用户口令
objvQxPrjSite4DownLoadENT.UpdUserId = objvQxPrjSite4DownLoadENS.UpdUserId; //修改用户Id
objvQxPrjSite4DownLoadENT.UpdDate = objvQxPrjSite4DownLoadENS.UpdDate; //修改日期
objvQxPrjSite4DownLoadENT.Memo = objvQxPrjSite4DownLoadENS.Memo; //备注
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
 /// <param name = "objvQxPrjSite4DownLoadENS">源对象</param>
 /// <returns>目标对象=>clsvQxPrjSite4DownLoadEN:objvQxPrjSite4DownLoadENT</returns>
 public static clsvQxPrjSite4DownLoadEN CopyTo(this clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadENS)
{
try
{
 clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadENT = new clsvQxPrjSite4DownLoadEN()
{
PrjSiteId = objvQxPrjSite4DownLoadENS.PrjSiteId, //工程站点Id
PrjSiteName = objvQxPrjSite4DownLoadENS.PrjSiteName, //工程站点名
QxPrjId = objvQxPrjSite4DownLoadENS.QxPrjId, //项目Id
PrjName = objvQxPrjSite4DownLoadENS.PrjName, //工程名
FtpServer = objvQxPrjSite4DownLoadENS.FtpServer, //Ftp服务器
FtpUserId = objvQxPrjSite4DownLoadENS.FtpUserId, //Ftp用户Id
FtpUserPassword = objvQxPrjSite4DownLoadENS.FtpUserPassword, //Ftp用户口令
UpdUserId = objvQxPrjSite4DownLoadENS.UpdUserId, //修改用户Id
UpdDate = objvQxPrjSite4DownLoadENS.UpdDate, //修改日期
Memo = objvQxPrjSite4DownLoadENS.Memo, //备注
};
 return objvQxPrjSite4DownLoadENT;
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
public static void CheckProperty4Condition(this clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN)
{
 clsvQxPrjSite4DownLoadBL.vQxPrjSite4DownLoadDA.CheckProperty4Condition(objvQxPrjSite4DownLoadEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQxPrjSite4DownLoadCond.IsUpdated(convQxPrjSite4DownLoad.PrjSiteId) == true)
{
string strComparisonOpPrjSiteId = objvQxPrjSite4DownLoadCond.dicFldComparisonOp[convQxPrjSite4DownLoad.PrjSiteId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjSite4DownLoad.PrjSiteId, objvQxPrjSite4DownLoadCond.PrjSiteId, strComparisonOpPrjSiteId);
}
if (objvQxPrjSite4DownLoadCond.IsUpdated(convQxPrjSite4DownLoad.PrjSiteName) == true)
{
string strComparisonOpPrjSiteName = objvQxPrjSite4DownLoadCond.dicFldComparisonOp[convQxPrjSite4DownLoad.PrjSiteName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjSite4DownLoad.PrjSiteName, objvQxPrjSite4DownLoadCond.PrjSiteName, strComparisonOpPrjSiteName);
}
if (objvQxPrjSite4DownLoadCond.IsUpdated(convQxPrjSite4DownLoad.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objvQxPrjSite4DownLoadCond.dicFldComparisonOp[convQxPrjSite4DownLoad.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjSite4DownLoad.QxPrjId, objvQxPrjSite4DownLoadCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objvQxPrjSite4DownLoadCond.IsUpdated(convQxPrjSite4DownLoad.PrjName) == true)
{
string strComparisonOpPrjName = objvQxPrjSite4DownLoadCond.dicFldComparisonOp[convQxPrjSite4DownLoad.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjSite4DownLoad.PrjName, objvQxPrjSite4DownLoadCond.PrjName, strComparisonOpPrjName);
}
if (objvQxPrjSite4DownLoadCond.IsUpdated(convQxPrjSite4DownLoad.FtpServer) == true)
{
string strComparisonOpFtpServer = objvQxPrjSite4DownLoadCond.dicFldComparisonOp[convQxPrjSite4DownLoad.FtpServer];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjSite4DownLoad.FtpServer, objvQxPrjSite4DownLoadCond.FtpServer, strComparisonOpFtpServer);
}
if (objvQxPrjSite4DownLoadCond.IsUpdated(convQxPrjSite4DownLoad.FtpUserId) == true)
{
string strComparisonOpFtpUserId = objvQxPrjSite4DownLoadCond.dicFldComparisonOp[convQxPrjSite4DownLoad.FtpUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjSite4DownLoad.FtpUserId, objvQxPrjSite4DownLoadCond.FtpUserId, strComparisonOpFtpUserId);
}
if (objvQxPrjSite4DownLoadCond.IsUpdated(convQxPrjSite4DownLoad.FtpUserPassword) == true)
{
string strComparisonOpFtpUserPassword = objvQxPrjSite4DownLoadCond.dicFldComparisonOp[convQxPrjSite4DownLoad.FtpUserPassword];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjSite4DownLoad.FtpUserPassword, objvQxPrjSite4DownLoadCond.FtpUserPassword, strComparisonOpFtpUserPassword);
}
if (objvQxPrjSite4DownLoadCond.IsUpdated(convQxPrjSite4DownLoad.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvQxPrjSite4DownLoadCond.dicFldComparisonOp[convQxPrjSite4DownLoad.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjSite4DownLoad.UpdUserId, objvQxPrjSite4DownLoadCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvQxPrjSite4DownLoadCond.IsUpdated(convQxPrjSite4DownLoad.UpdDate) == true)
{
string strComparisonOpUpdDate = objvQxPrjSite4DownLoadCond.dicFldComparisonOp[convQxPrjSite4DownLoad.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjSite4DownLoad.UpdDate, objvQxPrjSite4DownLoadCond.UpdDate, strComparisonOpUpdDate);
}
if (objvQxPrjSite4DownLoadCond.IsUpdated(convQxPrjSite4DownLoad.Memo) == true)
{
string strComparisonOpMemo = objvQxPrjSite4DownLoadCond.dicFldComparisonOp[convQxPrjSite4DownLoad.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjSite4DownLoad.Memo, objvQxPrjSite4DownLoadCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vQxPrjSite4DownLoad
{
public virtual bool UpdRelaTabDate(string strPrjSiteId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v文件下载站点(vQxPrjSite4DownLoad)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvQxPrjSite4DownLoadBL
{
public static RelatedActions_vQxPrjSite4DownLoad relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "vQxPrjSite4DownLoadListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "vQxPrjSite4DownLoadList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsvQxPrjSite4DownLoadEN> arrvQxPrjSite4DownLoadObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvQxPrjSite4DownLoadDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvQxPrjSite4DownLoadDA vQxPrjSite4DownLoadDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvQxPrjSite4DownLoadDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvQxPrjSite4DownLoadBL()
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
if (string.IsNullOrEmpty(clsvQxPrjSite4DownLoadEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxPrjSite4DownLoadEN._ConnectString);
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
objDS = vQxPrjSite4DownLoadDA.GetDataSet(strWhereCond);
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
objDS = vQxPrjSite4DownLoadDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = vQxPrjSite4DownLoadDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_vQxPrjSite4DownLoad(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQxPrjSite4DownLoadDA.GetDataTable_vQxPrjSite4DownLoad(strWhereCond);
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
objDT = vQxPrjSite4DownLoadDA.GetDataTable(strWhereCond);
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
objDT = vQxPrjSite4DownLoadDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vQxPrjSite4DownLoadDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vQxPrjSite4DownLoadDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vQxPrjSite4DownLoadDA.GetDataTable_Top(objTopPara);
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
objDT = vQxPrjSite4DownLoadDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vQxPrjSite4DownLoadDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = vQxPrjSite4DownLoadDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vQxPrjSite4DownLoadDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = vQxPrjSite4DownLoadDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = vQxPrjSite4DownLoadDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = vQxPrjSite4DownLoadDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = vQxPrjSite4DownLoadDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
 /// <param name = "arrPrjSiteIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvQxPrjSite4DownLoadEN> GetObjLstByPrjSiteIdLst(List<string> arrPrjSiteIdLst)
{
List<clsvQxPrjSite4DownLoadEN> arrObjLst = new List<clsvQxPrjSite4DownLoadEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrPrjSiteIdLst, true);
 string strWhereCond = string.Format("PrjSiteId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN = new clsvQxPrjSite4DownLoadEN();
try
{
objvQxPrjSite4DownLoadEN.PrjSiteId = objRow[convQxPrjSite4DownLoad.PrjSiteId].ToString().Trim(); //工程站点Id
objvQxPrjSite4DownLoadEN.PrjSiteName = objRow[convQxPrjSite4DownLoad.PrjSiteName].ToString().Trim(); //工程站点名
objvQxPrjSite4DownLoadEN.QxPrjId = objRow[convQxPrjSite4DownLoad.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjSite4DownLoadEN.PrjName = objRow[convQxPrjSite4DownLoad.PrjName].ToString().Trim(); //工程名
objvQxPrjSite4DownLoadEN.FtpServer = objRow[convQxPrjSite4DownLoad.FtpServer].ToString().Trim(); //Ftp服务器
objvQxPrjSite4DownLoadEN.FtpUserId = objRow[convQxPrjSite4DownLoad.FtpUserId].ToString().Trim(); //Ftp用户Id
objvQxPrjSite4DownLoadEN.FtpUserPassword = objRow[convQxPrjSite4DownLoad.FtpUserPassword].ToString().Trim(); //Ftp用户口令
objvQxPrjSite4DownLoadEN.UpdUserId = objRow[convQxPrjSite4DownLoad.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjSite4DownLoadEN.UpdDate = objRow[convQxPrjSite4DownLoad.UpdDate] == DBNull.Value ? null : objRow[convQxPrjSite4DownLoad.UpdDate].ToString().Trim(); //修改日期
objvQxPrjSite4DownLoadEN.Memo = objRow[convQxPrjSite4DownLoad.Memo] == DBNull.Value ? null : objRow[convQxPrjSite4DownLoad.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjSite4DownLoadEN.PrjSiteId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjSite4DownLoadEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPrjSiteIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvQxPrjSite4DownLoadEN> GetObjLstByPrjSiteIdLstCache(List<string> arrPrjSiteIdLst)
{
string strKey = string.Format("{0}", clsvQxPrjSite4DownLoadEN._CurrTabName);
List<clsvQxPrjSite4DownLoadEN> arrvQxPrjSite4DownLoadObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjSite4DownLoadEN> arrvQxPrjSite4DownLoadObjLst_Sel =
arrvQxPrjSite4DownLoadObjLstCache
.Where(x => arrPrjSiteIdLst.Contains(x.PrjSiteId));
return arrvQxPrjSite4DownLoadObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjSite4DownLoadEN> GetObjLst(string strWhereCond)
{
List<clsvQxPrjSite4DownLoadEN> arrObjLst = new List<clsvQxPrjSite4DownLoadEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN = new clsvQxPrjSite4DownLoadEN();
try
{
objvQxPrjSite4DownLoadEN.PrjSiteId = objRow[convQxPrjSite4DownLoad.PrjSiteId].ToString().Trim(); //工程站点Id
objvQxPrjSite4DownLoadEN.PrjSiteName = objRow[convQxPrjSite4DownLoad.PrjSiteName].ToString().Trim(); //工程站点名
objvQxPrjSite4DownLoadEN.QxPrjId = objRow[convQxPrjSite4DownLoad.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjSite4DownLoadEN.PrjName = objRow[convQxPrjSite4DownLoad.PrjName].ToString().Trim(); //工程名
objvQxPrjSite4DownLoadEN.FtpServer = objRow[convQxPrjSite4DownLoad.FtpServer].ToString().Trim(); //Ftp服务器
objvQxPrjSite4DownLoadEN.FtpUserId = objRow[convQxPrjSite4DownLoad.FtpUserId].ToString().Trim(); //Ftp用户Id
objvQxPrjSite4DownLoadEN.FtpUserPassword = objRow[convQxPrjSite4DownLoad.FtpUserPassword].ToString().Trim(); //Ftp用户口令
objvQxPrjSite4DownLoadEN.UpdUserId = objRow[convQxPrjSite4DownLoad.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjSite4DownLoadEN.UpdDate = objRow[convQxPrjSite4DownLoad.UpdDate] == DBNull.Value ? null : objRow[convQxPrjSite4DownLoad.UpdDate].ToString().Trim(); //修改日期
objvQxPrjSite4DownLoadEN.Memo = objRow[convQxPrjSite4DownLoad.Memo] == DBNull.Value ? null : objRow[convQxPrjSite4DownLoad.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjSite4DownLoadEN.PrjSiteId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjSite4DownLoadEN);
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
public static List<clsvQxPrjSite4DownLoadEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQxPrjSite4DownLoadEN> arrObjLst = new List<clsvQxPrjSite4DownLoadEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN = new clsvQxPrjSite4DownLoadEN();
try
{
objvQxPrjSite4DownLoadEN.PrjSiteId = objRow[convQxPrjSite4DownLoad.PrjSiteId].ToString().Trim(); //工程站点Id
objvQxPrjSite4DownLoadEN.PrjSiteName = objRow[convQxPrjSite4DownLoad.PrjSiteName].ToString().Trim(); //工程站点名
objvQxPrjSite4DownLoadEN.QxPrjId = objRow[convQxPrjSite4DownLoad.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjSite4DownLoadEN.PrjName = objRow[convQxPrjSite4DownLoad.PrjName].ToString().Trim(); //工程名
objvQxPrjSite4DownLoadEN.FtpServer = objRow[convQxPrjSite4DownLoad.FtpServer].ToString().Trim(); //Ftp服务器
objvQxPrjSite4DownLoadEN.FtpUserId = objRow[convQxPrjSite4DownLoad.FtpUserId].ToString().Trim(); //Ftp用户Id
objvQxPrjSite4DownLoadEN.FtpUserPassword = objRow[convQxPrjSite4DownLoad.FtpUserPassword].ToString().Trim(); //Ftp用户口令
objvQxPrjSite4DownLoadEN.UpdUserId = objRow[convQxPrjSite4DownLoad.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjSite4DownLoadEN.UpdDate = objRow[convQxPrjSite4DownLoad.UpdDate] == DBNull.Value ? null : objRow[convQxPrjSite4DownLoad.UpdDate].ToString().Trim(); //修改日期
objvQxPrjSite4DownLoadEN.Memo = objRow[convQxPrjSite4DownLoad.Memo] == DBNull.Value ? null : objRow[convQxPrjSite4DownLoad.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjSite4DownLoadEN.PrjSiteId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjSite4DownLoadEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvQxPrjSite4DownLoadCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvQxPrjSite4DownLoadEN> GetSubObjLstCache(clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadCond)
{
List<clsvQxPrjSite4DownLoadEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjSite4DownLoadEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxPrjSite4DownLoad.AttributeName)
{
if (objvQxPrjSite4DownLoadCond.IsUpdated(strFldName) == false) continue;
if (objvQxPrjSite4DownLoadCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjSite4DownLoadCond[strFldName].ToString());
}
else
{
if (objvQxPrjSite4DownLoadCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxPrjSite4DownLoadCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjSite4DownLoadCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxPrjSite4DownLoadCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxPrjSite4DownLoadCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxPrjSite4DownLoadCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxPrjSite4DownLoadCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxPrjSite4DownLoadCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxPrjSite4DownLoadCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxPrjSite4DownLoadCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxPrjSite4DownLoadCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxPrjSite4DownLoadCond[strFldName]));
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
public static List<clsvQxPrjSite4DownLoadEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvQxPrjSite4DownLoadEN> arrObjLst = new List<clsvQxPrjSite4DownLoadEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN = new clsvQxPrjSite4DownLoadEN();
try
{
objvQxPrjSite4DownLoadEN.PrjSiteId = objRow[convQxPrjSite4DownLoad.PrjSiteId].ToString().Trim(); //工程站点Id
objvQxPrjSite4DownLoadEN.PrjSiteName = objRow[convQxPrjSite4DownLoad.PrjSiteName].ToString().Trim(); //工程站点名
objvQxPrjSite4DownLoadEN.QxPrjId = objRow[convQxPrjSite4DownLoad.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjSite4DownLoadEN.PrjName = objRow[convQxPrjSite4DownLoad.PrjName].ToString().Trim(); //工程名
objvQxPrjSite4DownLoadEN.FtpServer = objRow[convQxPrjSite4DownLoad.FtpServer].ToString().Trim(); //Ftp服务器
objvQxPrjSite4DownLoadEN.FtpUserId = objRow[convQxPrjSite4DownLoad.FtpUserId].ToString().Trim(); //Ftp用户Id
objvQxPrjSite4DownLoadEN.FtpUserPassword = objRow[convQxPrjSite4DownLoad.FtpUserPassword].ToString().Trim(); //Ftp用户口令
objvQxPrjSite4DownLoadEN.UpdUserId = objRow[convQxPrjSite4DownLoad.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjSite4DownLoadEN.UpdDate = objRow[convQxPrjSite4DownLoad.UpdDate] == DBNull.Value ? null : objRow[convQxPrjSite4DownLoad.UpdDate].ToString().Trim(); //修改日期
objvQxPrjSite4DownLoadEN.Memo = objRow[convQxPrjSite4DownLoad.Memo] == DBNull.Value ? null : objRow[convQxPrjSite4DownLoad.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjSite4DownLoadEN.PrjSiteId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjSite4DownLoadEN);
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
public static List<clsvQxPrjSite4DownLoadEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvQxPrjSite4DownLoadEN> arrObjLst = new List<clsvQxPrjSite4DownLoadEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN = new clsvQxPrjSite4DownLoadEN();
try
{
objvQxPrjSite4DownLoadEN.PrjSiteId = objRow[convQxPrjSite4DownLoad.PrjSiteId].ToString().Trim(); //工程站点Id
objvQxPrjSite4DownLoadEN.PrjSiteName = objRow[convQxPrjSite4DownLoad.PrjSiteName].ToString().Trim(); //工程站点名
objvQxPrjSite4DownLoadEN.QxPrjId = objRow[convQxPrjSite4DownLoad.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjSite4DownLoadEN.PrjName = objRow[convQxPrjSite4DownLoad.PrjName].ToString().Trim(); //工程名
objvQxPrjSite4DownLoadEN.FtpServer = objRow[convQxPrjSite4DownLoad.FtpServer].ToString().Trim(); //Ftp服务器
objvQxPrjSite4DownLoadEN.FtpUserId = objRow[convQxPrjSite4DownLoad.FtpUserId].ToString().Trim(); //Ftp用户Id
objvQxPrjSite4DownLoadEN.FtpUserPassword = objRow[convQxPrjSite4DownLoad.FtpUserPassword].ToString().Trim(); //Ftp用户口令
objvQxPrjSite4DownLoadEN.UpdUserId = objRow[convQxPrjSite4DownLoad.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjSite4DownLoadEN.UpdDate = objRow[convQxPrjSite4DownLoad.UpdDate] == DBNull.Value ? null : objRow[convQxPrjSite4DownLoad.UpdDate].ToString().Trim(); //修改日期
objvQxPrjSite4DownLoadEN.Memo = objRow[convQxPrjSite4DownLoad.Memo] == DBNull.Value ? null : objRow[convQxPrjSite4DownLoad.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjSite4DownLoadEN.PrjSiteId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjSite4DownLoadEN);
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
List<clsvQxPrjSite4DownLoadEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvQxPrjSite4DownLoadEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjSite4DownLoadEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvQxPrjSite4DownLoadEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvQxPrjSite4DownLoadEN> arrObjLst = new List<clsvQxPrjSite4DownLoadEN>(); 
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
	clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN = new clsvQxPrjSite4DownLoadEN();
try
{
objvQxPrjSite4DownLoadEN.PrjSiteId = objRow[convQxPrjSite4DownLoad.PrjSiteId].ToString().Trim(); //工程站点Id
objvQxPrjSite4DownLoadEN.PrjSiteName = objRow[convQxPrjSite4DownLoad.PrjSiteName].ToString().Trim(); //工程站点名
objvQxPrjSite4DownLoadEN.QxPrjId = objRow[convQxPrjSite4DownLoad.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjSite4DownLoadEN.PrjName = objRow[convQxPrjSite4DownLoad.PrjName].ToString().Trim(); //工程名
objvQxPrjSite4DownLoadEN.FtpServer = objRow[convQxPrjSite4DownLoad.FtpServer].ToString().Trim(); //Ftp服务器
objvQxPrjSite4DownLoadEN.FtpUserId = objRow[convQxPrjSite4DownLoad.FtpUserId].ToString().Trim(); //Ftp用户Id
objvQxPrjSite4DownLoadEN.FtpUserPassword = objRow[convQxPrjSite4DownLoad.FtpUserPassword].ToString().Trim(); //Ftp用户口令
objvQxPrjSite4DownLoadEN.UpdUserId = objRow[convQxPrjSite4DownLoad.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjSite4DownLoadEN.UpdDate = objRow[convQxPrjSite4DownLoad.UpdDate] == DBNull.Value ? null : objRow[convQxPrjSite4DownLoad.UpdDate].ToString().Trim(); //修改日期
objvQxPrjSite4DownLoadEN.Memo = objRow[convQxPrjSite4DownLoad.Memo] == DBNull.Value ? null : objRow[convQxPrjSite4DownLoad.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjSite4DownLoadEN.PrjSiteId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjSite4DownLoadEN);
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
public static List<clsvQxPrjSite4DownLoadEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvQxPrjSite4DownLoadEN> arrObjLst = new List<clsvQxPrjSite4DownLoadEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN = new clsvQxPrjSite4DownLoadEN();
try
{
objvQxPrjSite4DownLoadEN.PrjSiteId = objRow[convQxPrjSite4DownLoad.PrjSiteId].ToString().Trim(); //工程站点Id
objvQxPrjSite4DownLoadEN.PrjSiteName = objRow[convQxPrjSite4DownLoad.PrjSiteName].ToString().Trim(); //工程站点名
objvQxPrjSite4DownLoadEN.QxPrjId = objRow[convQxPrjSite4DownLoad.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjSite4DownLoadEN.PrjName = objRow[convQxPrjSite4DownLoad.PrjName].ToString().Trim(); //工程名
objvQxPrjSite4DownLoadEN.FtpServer = objRow[convQxPrjSite4DownLoad.FtpServer].ToString().Trim(); //Ftp服务器
objvQxPrjSite4DownLoadEN.FtpUserId = objRow[convQxPrjSite4DownLoad.FtpUserId].ToString().Trim(); //Ftp用户Id
objvQxPrjSite4DownLoadEN.FtpUserPassword = objRow[convQxPrjSite4DownLoad.FtpUserPassword].ToString().Trim(); //Ftp用户口令
objvQxPrjSite4DownLoadEN.UpdUserId = objRow[convQxPrjSite4DownLoad.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjSite4DownLoadEN.UpdDate = objRow[convQxPrjSite4DownLoad.UpdDate] == DBNull.Value ? null : objRow[convQxPrjSite4DownLoad.UpdDate].ToString().Trim(); //修改日期
objvQxPrjSite4DownLoadEN.Memo = objRow[convQxPrjSite4DownLoad.Memo] == DBNull.Value ? null : objRow[convQxPrjSite4DownLoad.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjSite4DownLoadEN.PrjSiteId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjSite4DownLoadEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQxPrjSite4DownLoadEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvQxPrjSite4DownLoadEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvQxPrjSite4DownLoadEN> arrObjLst = new List<clsvQxPrjSite4DownLoadEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN = new clsvQxPrjSite4DownLoadEN();
try
{
objvQxPrjSite4DownLoadEN.PrjSiteId = objRow[convQxPrjSite4DownLoad.PrjSiteId].ToString().Trim(); //工程站点Id
objvQxPrjSite4DownLoadEN.PrjSiteName = objRow[convQxPrjSite4DownLoad.PrjSiteName].ToString().Trim(); //工程站点名
objvQxPrjSite4DownLoadEN.QxPrjId = objRow[convQxPrjSite4DownLoad.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjSite4DownLoadEN.PrjName = objRow[convQxPrjSite4DownLoad.PrjName].ToString().Trim(); //工程名
objvQxPrjSite4DownLoadEN.FtpServer = objRow[convQxPrjSite4DownLoad.FtpServer].ToString().Trim(); //Ftp服务器
objvQxPrjSite4DownLoadEN.FtpUserId = objRow[convQxPrjSite4DownLoad.FtpUserId].ToString().Trim(); //Ftp用户Id
objvQxPrjSite4DownLoadEN.FtpUserPassword = objRow[convQxPrjSite4DownLoad.FtpUserPassword].ToString().Trim(); //Ftp用户口令
objvQxPrjSite4DownLoadEN.UpdUserId = objRow[convQxPrjSite4DownLoad.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjSite4DownLoadEN.UpdDate = objRow[convQxPrjSite4DownLoad.UpdDate] == DBNull.Value ? null : objRow[convQxPrjSite4DownLoad.UpdDate].ToString().Trim(); //修改日期
objvQxPrjSite4DownLoadEN.Memo = objRow[convQxPrjSite4DownLoad.Memo] == DBNull.Value ? null : objRow[convQxPrjSite4DownLoad.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjSite4DownLoadEN.PrjSiteId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjSite4DownLoadEN);
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
public static List<clsvQxPrjSite4DownLoadEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvQxPrjSite4DownLoadEN> arrObjLst = new List<clsvQxPrjSite4DownLoadEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN = new clsvQxPrjSite4DownLoadEN();
try
{
objvQxPrjSite4DownLoadEN.PrjSiteId = objRow[convQxPrjSite4DownLoad.PrjSiteId].ToString().Trim(); //工程站点Id
objvQxPrjSite4DownLoadEN.PrjSiteName = objRow[convQxPrjSite4DownLoad.PrjSiteName].ToString().Trim(); //工程站点名
objvQxPrjSite4DownLoadEN.QxPrjId = objRow[convQxPrjSite4DownLoad.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjSite4DownLoadEN.PrjName = objRow[convQxPrjSite4DownLoad.PrjName].ToString().Trim(); //工程名
objvQxPrjSite4DownLoadEN.FtpServer = objRow[convQxPrjSite4DownLoad.FtpServer].ToString().Trim(); //Ftp服务器
objvQxPrjSite4DownLoadEN.FtpUserId = objRow[convQxPrjSite4DownLoad.FtpUserId].ToString().Trim(); //Ftp用户Id
objvQxPrjSite4DownLoadEN.FtpUserPassword = objRow[convQxPrjSite4DownLoad.FtpUserPassword].ToString().Trim(); //Ftp用户口令
objvQxPrjSite4DownLoadEN.UpdUserId = objRow[convQxPrjSite4DownLoad.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjSite4DownLoadEN.UpdDate = objRow[convQxPrjSite4DownLoad.UpdDate] == DBNull.Value ? null : objRow[convQxPrjSite4DownLoad.UpdDate].ToString().Trim(); //修改日期
objvQxPrjSite4DownLoadEN.Memo = objRow[convQxPrjSite4DownLoad.Memo] == DBNull.Value ? null : objRow[convQxPrjSite4DownLoad.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjSite4DownLoadEN.PrjSiteId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjSite4DownLoadEN);
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
public static IEnumerable<clsvQxPrjSite4DownLoadEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadCond, string strOrderBy)
{
List<clsvQxPrjSite4DownLoadEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjSite4DownLoadEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxPrjSite4DownLoad.AttributeName)
{
if (objvQxPrjSite4DownLoadCond.IsUpdated(strFldName) == false) continue;
if (objvQxPrjSite4DownLoadCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjSite4DownLoadCond[strFldName].ToString());
}
else
{
if (objvQxPrjSite4DownLoadCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxPrjSite4DownLoadCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjSite4DownLoadCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxPrjSite4DownLoadCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxPrjSite4DownLoadCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxPrjSite4DownLoadCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxPrjSite4DownLoadCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxPrjSite4DownLoadCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxPrjSite4DownLoadCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxPrjSite4DownLoadCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxPrjSite4DownLoadCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxPrjSite4DownLoadCond[strFldName]));
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
public static IEnumerable<clsvQxPrjSite4DownLoadEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadCond = JsonConvert.DeserializeObject<clsvQxPrjSite4DownLoadEN>(objPagerPara.whereCond);
if (objvQxPrjSite4DownLoadCond.sfFldComparisonOp == null)
{
objvQxPrjSite4DownLoadCond.dicFldComparisonOp = null;
}
else
{
objvQxPrjSite4DownLoadCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objvQxPrjSite4DownLoadCond.sfFldComparisonOp);
}
clsvQxPrjSite4DownLoadBL.SetUpdFlag(objvQxPrjSite4DownLoadCond);
 try
{
CheckProperty4Condition(objvQxPrjSite4DownLoadCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsvQxPrjSite4DownLoadBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objvQxPrjSite4DownLoadCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjSite4DownLoadEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsvQxPrjSite4DownLoadEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxPrjSite4DownLoadEN> arrObjLst = new List<clsvQxPrjSite4DownLoadEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN = new clsvQxPrjSite4DownLoadEN();
try
{
objvQxPrjSite4DownLoadEN.PrjSiteId = objRow[convQxPrjSite4DownLoad.PrjSiteId].ToString().Trim(); //工程站点Id
objvQxPrjSite4DownLoadEN.PrjSiteName = objRow[convQxPrjSite4DownLoad.PrjSiteName].ToString().Trim(); //工程站点名
objvQxPrjSite4DownLoadEN.QxPrjId = objRow[convQxPrjSite4DownLoad.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjSite4DownLoadEN.PrjName = objRow[convQxPrjSite4DownLoad.PrjName].ToString().Trim(); //工程名
objvQxPrjSite4DownLoadEN.FtpServer = objRow[convQxPrjSite4DownLoad.FtpServer].ToString().Trim(); //Ftp服务器
objvQxPrjSite4DownLoadEN.FtpUserId = objRow[convQxPrjSite4DownLoad.FtpUserId].ToString().Trim(); //Ftp用户Id
objvQxPrjSite4DownLoadEN.FtpUserPassword = objRow[convQxPrjSite4DownLoad.FtpUserPassword].ToString().Trim(); //Ftp用户口令
objvQxPrjSite4DownLoadEN.UpdUserId = objRow[convQxPrjSite4DownLoad.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjSite4DownLoadEN.UpdDate = objRow[convQxPrjSite4DownLoad.UpdDate] == DBNull.Value ? null : objRow[convQxPrjSite4DownLoad.UpdDate].ToString().Trim(); //修改日期
objvQxPrjSite4DownLoadEN.Memo = objRow[convQxPrjSite4DownLoad.Memo] == DBNull.Value ? null : objRow[convQxPrjSite4DownLoad.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjSite4DownLoadEN.PrjSiteId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjSite4DownLoadEN);
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
public static List<clsvQxPrjSite4DownLoadEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxPrjSite4DownLoadEN> arrObjLst = new List<clsvQxPrjSite4DownLoadEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN = new clsvQxPrjSite4DownLoadEN();
try
{
objvQxPrjSite4DownLoadEN.PrjSiteId = objRow[convQxPrjSite4DownLoad.PrjSiteId].ToString().Trim(); //工程站点Id
objvQxPrjSite4DownLoadEN.PrjSiteName = objRow[convQxPrjSite4DownLoad.PrjSiteName].ToString().Trim(); //工程站点名
objvQxPrjSite4DownLoadEN.QxPrjId = objRow[convQxPrjSite4DownLoad.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjSite4DownLoadEN.PrjName = objRow[convQxPrjSite4DownLoad.PrjName].ToString().Trim(); //工程名
objvQxPrjSite4DownLoadEN.FtpServer = objRow[convQxPrjSite4DownLoad.FtpServer].ToString().Trim(); //Ftp服务器
objvQxPrjSite4DownLoadEN.FtpUserId = objRow[convQxPrjSite4DownLoad.FtpUserId].ToString().Trim(); //Ftp用户Id
objvQxPrjSite4DownLoadEN.FtpUserPassword = objRow[convQxPrjSite4DownLoad.FtpUserPassword].ToString().Trim(); //Ftp用户口令
objvQxPrjSite4DownLoadEN.UpdUserId = objRow[convQxPrjSite4DownLoad.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjSite4DownLoadEN.UpdDate = objRow[convQxPrjSite4DownLoad.UpdDate] == DBNull.Value ? null : objRow[convQxPrjSite4DownLoad.UpdDate].ToString().Trim(); //修改日期
objvQxPrjSite4DownLoadEN.Memo = objRow[convQxPrjSite4DownLoad.Memo] == DBNull.Value ? null : objRow[convQxPrjSite4DownLoad.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjSite4DownLoadEN.PrjSiteId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjSite4DownLoadEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjSite4DownLoadEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvQxPrjSite4DownLoadEN> arrObjLst = new List<clsvQxPrjSite4DownLoadEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN = new clsvQxPrjSite4DownLoadEN();
try
{
objvQxPrjSite4DownLoadEN.PrjSiteId = objRow[convQxPrjSite4DownLoad.PrjSiteId].ToString().Trim(); //工程站点Id
objvQxPrjSite4DownLoadEN.PrjSiteName = objRow[convQxPrjSite4DownLoad.PrjSiteName].ToString().Trim(); //工程站点名
objvQxPrjSite4DownLoadEN.QxPrjId = objRow[convQxPrjSite4DownLoad.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjSite4DownLoadEN.PrjName = objRow[convQxPrjSite4DownLoad.PrjName].ToString().Trim(); //工程名
objvQxPrjSite4DownLoadEN.FtpServer = objRow[convQxPrjSite4DownLoad.FtpServer].ToString().Trim(); //Ftp服务器
objvQxPrjSite4DownLoadEN.FtpUserId = objRow[convQxPrjSite4DownLoad.FtpUserId].ToString().Trim(); //Ftp用户Id
objvQxPrjSite4DownLoadEN.FtpUserPassword = objRow[convQxPrjSite4DownLoad.FtpUserPassword].ToString().Trim(); //Ftp用户口令
objvQxPrjSite4DownLoadEN.UpdUserId = objRow[convQxPrjSite4DownLoad.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjSite4DownLoadEN.UpdDate = objRow[convQxPrjSite4DownLoad.UpdDate] == DBNull.Value ? null : objRow[convQxPrjSite4DownLoad.UpdDate].ToString().Trim(); //修改日期
objvQxPrjSite4DownLoadEN.Memo = objRow[convQxPrjSite4DownLoad.Memo] == DBNull.Value ? null : objRow[convQxPrjSite4DownLoad.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjSite4DownLoadEN.PrjSiteId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjSite4DownLoadEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvQxPrjSite4DownLoadEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxPrjSite4DownLoad(ref clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN)
{
bool bolResult = vQxPrjSite4DownLoadDA.GetvQxPrjSite4DownLoad(ref objvQxPrjSite4DownLoadEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strPrjSiteId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxPrjSite4DownLoadEN GetObjByPrjSiteId(string strPrjSiteId)
{
if (strPrjSiteId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strPrjSiteId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strPrjSiteId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strPrjSiteId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN = vQxPrjSite4DownLoadDA.GetObjByPrjSiteId(strPrjSiteId);
return objvQxPrjSite4DownLoadEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvQxPrjSite4DownLoadEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN = vQxPrjSite4DownLoadDA.GetFirstObj(strWhereCond);
 return objvQxPrjSite4DownLoadEN;
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
public static clsvQxPrjSite4DownLoadEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN = vQxPrjSite4DownLoadDA.GetObjByDataRow(objRow);
 return objvQxPrjSite4DownLoadEN;
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
public static clsvQxPrjSite4DownLoadEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN = vQxPrjSite4DownLoadDA.GetObjByDataRow(objRow);
 return objvQxPrjSite4DownLoadEN;
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
 /// <param name = "strPrjSiteId">所给的关键字</param>
 /// <param name = "lstvQxPrjSite4DownLoadObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxPrjSite4DownLoadEN GetObjByPrjSiteIdFromList(string strPrjSiteId, List<clsvQxPrjSite4DownLoadEN> lstvQxPrjSite4DownLoadObjLst)
{
foreach (clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN in lstvQxPrjSite4DownLoadObjLst)
{
if (objvQxPrjSite4DownLoadEN.PrjSiteId == strPrjSiteId)
{
return objvQxPrjSite4DownLoadEN;
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
 string strPrjSiteId;
 try
 {
 strPrjSiteId = new clsvQxPrjSite4DownLoadDA().GetFirstID(strWhereCond);
 return strPrjSiteId;
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
 arrList = vQxPrjSite4DownLoadDA.GetID(strWhereCond);
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
bool bolIsExist = vQxPrjSite4DownLoadDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strPrjSiteId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strPrjSiteId)
{
if (string.IsNullOrEmpty(strPrjSiteId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strPrjSiteId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vQxPrjSite4DownLoadDA.IsExist(strPrjSiteId);
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
 bolIsExist = clsvQxPrjSite4DownLoadDA.IsExistTable();
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
 bolIsExist = vQxPrjSite4DownLoadDA.IsExistTable(strTabName);
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
 /// <param name = "objvQxPrjSite4DownLoadENS">源对象</param>
 /// <param name = "objvQxPrjSite4DownLoadENT">目标对象</param>
 public static void CopyTo(clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadENS, clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadENT)
{
try
{
objvQxPrjSite4DownLoadENT.PrjSiteId = objvQxPrjSite4DownLoadENS.PrjSiteId; //工程站点Id
objvQxPrjSite4DownLoadENT.PrjSiteName = objvQxPrjSite4DownLoadENS.PrjSiteName; //工程站点名
objvQxPrjSite4DownLoadENT.QxPrjId = objvQxPrjSite4DownLoadENS.QxPrjId; //项目Id
objvQxPrjSite4DownLoadENT.PrjName = objvQxPrjSite4DownLoadENS.PrjName; //工程名
objvQxPrjSite4DownLoadENT.FtpServer = objvQxPrjSite4DownLoadENS.FtpServer; //Ftp服务器
objvQxPrjSite4DownLoadENT.FtpUserId = objvQxPrjSite4DownLoadENS.FtpUserId; //Ftp用户Id
objvQxPrjSite4DownLoadENT.FtpUserPassword = objvQxPrjSite4DownLoadENS.FtpUserPassword; //Ftp用户口令
objvQxPrjSite4DownLoadENT.UpdUserId = objvQxPrjSite4DownLoadENS.UpdUserId; //修改用户Id
objvQxPrjSite4DownLoadENT.UpdDate = objvQxPrjSite4DownLoadENS.UpdDate; //修改日期
objvQxPrjSite4DownLoadENT.Memo = objvQxPrjSite4DownLoadENS.Memo; //备注
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
 /// <param name = "objvQxPrjSite4DownLoadEN">源简化对象</param>
 public static void SetUpdFlag(clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN)
{
try
{
objvQxPrjSite4DownLoadEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvQxPrjSite4DownLoadEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convQxPrjSite4DownLoad.PrjSiteId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjSite4DownLoadEN.PrjSiteId = objvQxPrjSite4DownLoadEN.PrjSiteId; //工程站点Id
}
if (arrFldSet.Contains(convQxPrjSite4DownLoad.PrjSiteName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjSite4DownLoadEN.PrjSiteName = objvQxPrjSite4DownLoadEN.PrjSiteName; //工程站点名
}
if (arrFldSet.Contains(convQxPrjSite4DownLoad.QxPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjSite4DownLoadEN.QxPrjId = objvQxPrjSite4DownLoadEN.QxPrjId; //项目Id
}
if (arrFldSet.Contains(convQxPrjSite4DownLoad.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjSite4DownLoadEN.PrjName = objvQxPrjSite4DownLoadEN.PrjName; //工程名
}
if (arrFldSet.Contains(convQxPrjSite4DownLoad.FtpServer, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjSite4DownLoadEN.FtpServer = objvQxPrjSite4DownLoadEN.FtpServer; //Ftp服务器
}
if (arrFldSet.Contains(convQxPrjSite4DownLoad.FtpUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjSite4DownLoadEN.FtpUserId = objvQxPrjSite4DownLoadEN.FtpUserId; //Ftp用户Id
}
if (arrFldSet.Contains(convQxPrjSite4DownLoad.FtpUserPassword, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjSite4DownLoadEN.FtpUserPassword = objvQxPrjSite4DownLoadEN.FtpUserPassword; //Ftp用户口令
}
if (arrFldSet.Contains(convQxPrjSite4DownLoad.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjSite4DownLoadEN.UpdUserId = objvQxPrjSite4DownLoadEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convQxPrjSite4DownLoad.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjSite4DownLoadEN.UpdDate = objvQxPrjSite4DownLoadEN.UpdDate == "[null]" ? null :  objvQxPrjSite4DownLoadEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convQxPrjSite4DownLoad.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjSite4DownLoadEN.Memo = objvQxPrjSite4DownLoadEN.Memo == "[null]" ? null :  objvQxPrjSite4DownLoadEN.Memo; //备注
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
 /// <param name = "objvQxPrjSite4DownLoadEN">源简化对象</param>
 public static void AccessFldValueNull(clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN)
{
try
{
if (objvQxPrjSite4DownLoadEN.UpdDate == "[null]") objvQxPrjSite4DownLoadEN.UpdDate = null; //修改日期
if (objvQxPrjSite4DownLoadEN.Memo == "[null]") objvQxPrjSite4DownLoadEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN)
{
 vQxPrjSite4DownLoadDA.CheckProperty4Condition(objvQxPrjSite4DownLoadEN);
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
//string strWhereCond = string.Format("1 = 1 order by PrjSiteId");
//if (arrvQxPrjSite4DownLoadObjLstCache == null)
//{
//arrvQxPrjSite4DownLoadObjLstCache = vQxPrjSite4DownLoadDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strPrjSiteId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxPrjSite4DownLoadEN GetObjByPrjSiteIdCache(string strPrjSiteId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvQxPrjSite4DownLoadEN._CurrTabName);
List<clsvQxPrjSite4DownLoadEN> arrvQxPrjSite4DownLoadObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjSite4DownLoadEN> arrvQxPrjSite4DownLoadObjLst_Sel =
arrvQxPrjSite4DownLoadObjLstCache
.Where(x=> x.PrjSiteId == strPrjSiteId 
);
if (arrvQxPrjSite4DownLoadObjLst_Sel.Count() == 0)
{
   clsvQxPrjSite4DownLoadEN obj = clsvQxPrjSite4DownLoadBL.GetObjByPrjSiteId(strPrjSiteId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvQxPrjSite4DownLoadObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxPrjSite4DownLoadEN> GetAllvQxPrjSite4DownLoadObjLstCache()
{
//获取缓存中的对象列表
List<clsvQxPrjSite4DownLoadEN> arrvQxPrjSite4DownLoadObjLstCache = GetObjLstCache(); 
return arrvQxPrjSite4DownLoadObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxPrjSite4DownLoadEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvQxPrjSite4DownLoadEN._CurrTabName);
List<clsvQxPrjSite4DownLoadEN> arrvQxPrjSite4DownLoadObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQxPrjSite4DownLoadObjLstCache;
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
string strKey = string.Format("{0}", clsvQxPrjSite4DownLoadEN._CurrTabName);
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
 /// <param name = "lstvQxPrjSite4DownLoadObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsvQxPrjSite4DownLoadEN> lstvQxPrjSite4DownLoadObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstvQxPrjSite4DownLoadObjLst, writer);
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
 /// <param name = "lstvQxPrjSite4DownLoadObjLst">[clsvQxPrjSite4DownLoadEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsvQxPrjSite4DownLoadEN> lstvQxPrjSite4DownLoadObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsvQxPrjSite4DownLoadBL.listXmlNode);
writer.WriteStartElement(clsvQxPrjSite4DownLoadBL.itemsXmlNode);
foreach (clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN in lstvQxPrjSite4DownLoadObjLst)
{
clsvQxPrjSite4DownLoadBL.SerializeXML(writer, objvQxPrjSite4DownLoadEN);
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
 /// <param name = "objvQxPrjSite4DownLoadEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN)
{
writer.WriteStartElement(clsvQxPrjSite4DownLoadBL.itemXmlNode);
 
if (objvQxPrjSite4DownLoadEN.PrjSiteId != null)
{
writer.WriteElementString(convQxPrjSite4DownLoad.PrjSiteId, objvQxPrjSite4DownLoadEN.PrjSiteId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjSite4DownLoadEN.PrjSiteName != null)
{
writer.WriteElementString(convQxPrjSite4DownLoad.PrjSiteName, objvQxPrjSite4DownLoadEN.PrjSiteName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjSite4DownLoadEN.QxPrjId != null)
{
writer.WriteElementString(convQxPrjSite4DownLoad.QxPrjId, objvQxPrjSite4DownLoadEN.QxPrjId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjSite4DownLoadEN.PrjName != null)
{
writer.WriteElementString(convQxPrjSite4DownLoad.PrjName, objvQxPrjSite4DownLoadEN.PrjName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjSite4DownLoadEN.FtpServer != null)
{
writer.WriteElementString(convQxPrjSite4DownLoad.FtpServer, objvQxPrjSite4DownLoadEN.FtpServer.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjSite4DownLoadEN.FtpUserId != null)
{
writer.WriteElementString(convQxPrjSite4DownLoad.FtpUserId, objvQxPrjSite4DownLoadEN.FtpUserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjSite4DownLoadEN.FtpUserPassword != null)
{
writer.WriteElementString(convQxPrjSite4DownLoad.FtpUserPassword, objvQxPrjSite4DownLoadEN.FtpUserPassword.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjSite4DownLoadEN.UpdUserId != null)
{
writer.WriteElementString(convQxPrjSite4DownLoad.UpdUserId, objvQxPrjSite4DownLoadEN.UpdUserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjSite4DownLoadEN.UpdDate != null)
{
writer.WriteElementString(convQxPrjSite4DownLoad.UpdDate, objvQxPrjSite4DownLoadEN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjSite4DownLoadEN.Memo != null)
{
writer.WriteElementString(convQxPrjSite4DownLoad.Memo, objvQxPrjSite4DownLoadEN.Memo.ToString(CultureInfo.InvariantCulture));
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
public static clsvQxPrjSite4DownLoadEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN = new clsvQxPrjSite4DownLoadEN();
reader.Read();
while (!(reader.Name == clsvQxPrjSite4DownLoadBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(convQxPrjSite4DownLoad.PrjSiteId))
{
objvQxPrjSite4DownLoadEN.PrjSiteId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjSite4DownLoad.PrjSiteName))
{
objvQxPrjSite4DownLoadEN.PrjSiteName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjSite4DownLoad.QxPrjId))
{
objvQxPrjSite4DownLoadEN.QxPrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjSite4DownLoad.PrjName))
{
objvQxPrjSite4DownLoadEN.PrjName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjSite4DownLoad.FtpServer))
{
objvQxPrjSite4DownLoadEN.FtpServer = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjSite4DownLoad.FtpUserId))
{
objvQxPrjSite4DownLoadEN.FtpUserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjSite4DownLoad.FtpUserPassword))
{
objvQxPrjSite4DownLoadEN.FtpUserPassword = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjSite4DownLoad.UpdUserId))
{
objvQxPrjSite4DownLoadEN.UpdUserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjSite4DownLoad.UpdDate))
{
objvQxPrjSite4DownLoadEN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjSite4DownLoad.Memo))
{
objvQxPrjSite4DownLoadEN.Memo = reader.ReadElementContentAsString();
}
}
return objvQxPrjSite4DownLoadEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strvQxPrjSite4DownLoadObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsvQxPrjSite4DownLoadEN GetObjFromXmlStr(string strvQxPrjSite4DownLoadObjXmlStr)
{
clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN = new clsvQxPrjSite4DownLoadEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strvQxPrjSite4DownLoadObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsvQxPrjSite4DownLoadBL.itemXmlNode))
{
objvQxPrjSite4DownLoadEN = GetObjFromXml(reader);
return objvQxPrjSite4DownLoadEN;
}
}
return objvQxPrjSite4DownLoadEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objvQxPrjSite4DownLoadEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objvQxPrjSite4DownLoadEN);
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
public static string Func(string strInFldName, string strOutFldName, string strPrjSiteId)
{
if (strInFldName != convQxPrjSite4DownLoad.PrjSiteId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convQxPrjSite4DownLoad.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convQxPrjSite4DownLoad.AttributeName));
throw new Exception(strMsg);
}
var objvQxPrjSite4DownLoad = clsvQxPrjSite4DownLoadBL.GetObjByPrjSiteIdCache(strPrjSiteId);
if (objvQxPrjSite4DownLoad == null) return "";
return objvQxPrjSite4DownLoad[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objvQxPrjSite4DownLoadEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsvQxPrjSite4DownLoadEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objvQxPrjSite4DownLoadEN[strField]);
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
 /// <param name = "lstvQxPrjSite4DownLoadObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsvQxPrjSite4DownLoadEN> lstvQxPrjSite4DownLoadObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstvQxPrjSite4DownLoadObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN in lstvQxPrjSite4DownLoadObjLst)
{
string strJSON_One = SerializeObjToJSON(objvQxPrjSite4DownLoadEN);
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
int intRecCount = clsvQxPrjSite4DownLoadDA.GetRecCount(strTabName);
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
int intRecCount = clsvQxPrjSite4DownLoadDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvQxPrjSite4DownLoadDA.GetRecCount();
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
int intRecCount = clsvQxPrjSite4DownLoadDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvQxPrjSite4DownLoadCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadCond)
{
List<clsvQxPrjSite4DownLoadEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjSite4DownLoadEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxPrjSite4DownLoad.AttributeName)
{
if (objvQxPrjSite4DownLoadCond.IsUpdated(strFldName) == false) continue;
if (objvQxPrjSite4DownLoadCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjSite4DownLoadCond[strFldName].ToString());
}
else
{
if (objvQxPrjSite4DownLoadCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxPrjSite4DownLoadCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjSite4DownLoadCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxPrjSite4DownLoadCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxPrjSite4DownLoadCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxPrjSite4DownLoadCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxPrjSite4DownLoadCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxPrjSite4DownLoadCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxPrjSite4DownLoadCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxPrjSite4DownLoadCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxPrjSite4DownLoadCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxPrjSite4DownLoadCond[strFldName]));
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
 List<string> arrList = clsvQxPrjSite4DownLoadDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vQxPrjSite4DownLoadDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vQxPrjSite4DownLoadDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}