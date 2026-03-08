
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPrjSite4DownLoadWApi
 表名:vQxPrjSite4DownLoad(00140061)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 18:30:43
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

namespace GP4WApi
{
/// <summary>
/// 静态类
/// </summary>
public static class  clsvQxPrjSite4DownLoadWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjSite4DownLoadEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjSiteId">工程站点Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjSite4DownLoadEN SetPrjSiteId(this clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN, string strPrjSiteId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjSiteId, 6, convQxPrjSite4DownLoad.PrjSiteId);
clsCheckSql.CheckFieldForeignKey(strPrjSiteId, 6, convQxPrjSite4DownLoad.PrjSiteId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjSite4DownLoadEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjSiteName">工程站点名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjSite4DownLoadEN SetPrjSiteName(this clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN, string strPrjSiteName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjSiteName, convQxPrjSite4DownLoad.PrjSiteName);
clsCheckSql.CheckFieldLen(strPrjSiteName, 50, convQxPrjSite4DownLoad.PrjSiteName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjSite4DownLoadEN">需要设置字段值的实体对象</param>
 /// <param name = "strQxPrjId">项目Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjSite4DownLoadEN SetQxPrjId(this clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, convQxPrjSite4DownLoad.QxPrjId);
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxPrjSite4DownLoad.QxPrjId);
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxPrjSite4DownLoad.QxPrjId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjSite4DownLoadEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjSite4DownLoadEN SetPrjName(this clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convQxPrjSite4DownLoad.PrjName);
clsCheckSql.CheckFieldLen(strPrjName, 30, convQxPrjSite4DownLoad.PrjName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjSite4DownLoadEN">需要设置字段值的实体对象</param>
 /// <param name = "strFtpServer">Ftp服务器</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjSite4DownLoadEN SetFtpServer(this clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN, string strFtpServer, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFtpServer, convQxPrjSite4DownLoad.FtpServer);
clsCheckSql.CheckFieldLen(strFtpServer, 50, convQxPrjSite4DownLoad.FtpServer);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjSite4DownLoadEN">需要设置字段值的实体对象</param>
 /// <param name = "strFtpUserId">Ftp用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjSite4DownLoadEN SetFtpUserId(this clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN, string strFtpUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFtpUserId, convQxPrjSite4DownLoad.FtpUserId);
clsCheckSql.CheckFieldLen(strFtpUserId, 20, convQxPrjSite4DownLoad.FtpUserId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjSite4DownLoadEN">需要设置字段值的实体对象</param>
 /// <param name = "strFtpUserPassword">Ftp用户口令</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjSite4DownLoadEN SetFtpUserPassword(this clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN, string strFtpUserPassword, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFtpUserPassword, convQxPrjSite4DownLoad.FtpUserPassword);
clsCheckSql.CheckFieldLen(strFtpUserPassword, 50, convQxPrjSite4DownLoad.FtpUserPassword);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjSite4DownLoadEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjSite4DownLoadEN SetUpdUserId(this clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUserId, convQxPrjSite4DownLoad.UpdUserId);
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convQxPrjSite4DownLoad.UpdUserId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjSite4DownLoadEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjSite4DownLoadEN SetUpdDate(this clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQxPrjSite4DownLoad.UpdDate);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjSite4DownLoadEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">备注</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjSite4DownLoadEN SetMemo(this clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxPrjSite4DownLoad.Memo);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
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
 /// v文件下载站点(vQxPrjSite4DownLoad)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxPrjSite4DownLoadWApi
{
private static readonly string mstrApiControllerName = "vQxPrjSite4DownLoadApi";

 public clsvQxPrjSite4DownLoadWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strPrjSiteId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxPrjSite4DownLoadEN GetObjByPrjSiteId(string strPrjSiteId)
{
string strAction = "GetObjByPrjSiteId";
clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strPrjSiteId"] = strPrjSiteId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvQxPrjSite4DownLoadEN = JsonConvert.DeserializeObject<clsvQxPrjSite4DownLoadEN>(strJson);
return objvQxPrjSite4DownLoadEN;
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
public static clsvQxPrjSite4DownLoadEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN;
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
objvQxPrjSite4DownLoadEN = JsonConvert.DeserializeObject<clsvQxPrjSite4DownLoadEN>(strJson);
return objvQxPrjSite4DownLoadEN;
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
public static List<clsvQxPrjSite4DownLoadEN> GetObjLst(string strWhereCond)
{
 List<clsvQxPrjSite4DownLoadEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjSite4DownLoadEN>>(strJson);
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
 /// <param name = "arrPrjSiteId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjSite4DownLoadEN> GetObjLstByPrjSiteIdLst(List<string> arrPrjSiteId)
{
 List<clsvQxPrjSite4DownLoadEN> arrObjLst; 
string strAction = "GetObjLstByPrjSiteIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPrjSiteId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjSite4DownLoadEN>>(strJson);
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
public static List<clsvQxPrjSite4DownLoadEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvQxPrjSite4DownLoadEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjSite4DownLoadEN>>(strJson);
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
public static List<clsvQxPrjSite4DownLoadEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvQxPrjSite4DownLoadEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjSite4DownLoadEN>>(strJson);
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
public static List<clsvQxPrjSite4DownLoadEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvQxPrjSite4DownLoadEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjSite4DownLoadEN>>(strJson);
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
public static List<clsvQxPrjSite4DownLoadEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvQxPrjSite4DownLoadEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjSite4DownLoadEN>>(strJson);
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
public static bool IsExist(string strPrjSiteId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strPrjSiteId"] = strPrjSiteId
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
public static DataTable ToDataTable(List<clsvQxPrjSite4DownLoadEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvQxPrjSite4DownLoadEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvQxPrjSite4DownLoadEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvQxPrjSite4DownLoadEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvQxPrjSite4DownLoadEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvQxPrjSite4DownLoadEN.AttributeName)
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
//该表没有使用Cache,不需要生成[GetObjLstCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvQxPrjSite4DownLoadEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convQxPrjSite4DownLoad.PrjSiteId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjSite4DownLoad.PrjSiteName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjSite4DownLoad.QxPrjId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjSite4DownLoad.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjSite4DownLoad.FtpServer, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjSite4DownLoad.FtpUserId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjSite4DownLoad.FtpUserPassword, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjSite4DownLoad.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjSite4DownLoad.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjSite4DownLoad.Memo, Type.GetType("System.String"));
foreach (clsvQxPrjSite4DownLoadEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convQxPrjSite4DownLoad.PrjSiteId] = objInFor[convQxPrjSite4DownLoad.PrjSiteId];
objDR[convQxPrjSite4DownLoad.PrjSiteName] = objInFor[convQxPrjSite4DownLoad.PrjSiteName];
objDR[convQxPrjSite4DownLoad.QxPrjId] = objInFor[convQxPrjSite4DownLoad.QxPrjId];
objDR[convQxPrjSite4DownLoad.PrjName] = objInFor[convQxPrjSite4DownLoad.PrjName];
objDR[convQxPrjSite4DownLoad.FtpServer] = objInFor[convQxPrjSite4DownLoad.FtpServer];
objDR[convQxPrjSite4DownLoad.FtpUserId] = objInFor[convQxPrjSite4DownLoad.FtpUserId];
objDR[convQxPrjSite4DownLoad.FtpUserPassword] = objInFor[convQxPrjSite4DownLoad.FtpUserPassword];
objDR[convQxPrjSite4DownLoad.UpdUserId] = objInFor[convQxPrjSite4DownLoad.UpdUserId];
objDR[convQxPrjSite4DownLoad.UpdDate] = objInFor[convQxPrjSite4DownLoad.UpdDate];
objDR[convQxPrjSite4DownLoad.Memo] = objInFor[convQxPrjSite4DownLoad.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}