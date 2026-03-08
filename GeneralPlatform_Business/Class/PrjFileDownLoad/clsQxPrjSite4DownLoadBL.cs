
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxPrjSite4DownLoadBL
 表名:QxPrjSite4DownLoad(00140055)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 17:44:32
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
public static class  clsQxPrjSite4DownLoadBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strPrjSiteId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxPrjSite4DownLoadEN GetObj(this K_PrjSiteId_QxPrjSite4DownLoad myKey)
{
clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN = clsQxPrjSite4DownLoadBL.QxPrjSite4DownLoadDA.GetObjByPrjSiteId(myKey.Value);
return objQxPrjSite4DownLoadEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQxPrjSite4DownLoadEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN)
{
if (CheckUniqueness(objQxPrjSite4DownLoadEN) == false)
{
var strMsg = string.Format("记录已经存在!工程站点名 = [{0}],项目Id = [{1}]的数据已经存在!(in clsQxPrjSite4DownLoadBL.AddNewRecord)", objQxPrjSite4DownLoadEN.PrjSiteName,objQxPrjSite4DownLoadEN.QxPrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQxPrjSite4DownLoadEN.PrjSiteId) == true || clsQxPrjSite4DownLoadBL.IsExist(objQxPrjSite4DownLoadEN.PrjSiteId) == true)
 {
     objQxPrjSite4DownLoadEN.PrjSiteId = clsQxPrjSite4DownLoadBL.GetMaxStrId_S();
 }
bool bolResult = clsQxPrjSite4DownLoadBL.QxPrjSite4DownLoadDA.AddNewRecordBySQL2(objQxPrjSite4DownLoadEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjSite4DownLoadBL.ReFreshCache();

if (clsQxPrjSite4DownLoadBL.relatedActions != null)
{
clsQxPrjSite4DownLoadBL.relatedActions.UpdRelaTabDate(objQxPrjSite4DownLoadEN.PrjSiteId, objQxPrjSite4DownLoadEN.UpdUserId);
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
public static bool AddRecordEx(this clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsQxPrjSite4DownLoadBL.IsExist(objQxPrjSite4DownLoadEN.PrjSiteId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objQxPrjSite4DownLoadEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objQxPrjSite4DownLoadEN.CheckUniqueness() == false)
{
strMsg = string.Format("(工程站点名(PrjSiteName)=[{0}],项目Id(QxPrjId)=[{1}])已经存在,不能重复!", objQxPrjSite4DownLoadEN.PrjSiteName, objQxPrjSite4DownLoadEN.QxPrjId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objQxPrjSite4DownLoadEN.PrjSiteId) == true || clsQxPrjSite4DownLoadBL.IsExist(objQxPrjSite4DownLoadEN.PrjSiteId) == true)
 {
     objQxPrjSite4DownLoadEN.PrjSiteId = clsQxPrjSite4DownLoadBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objQxPrjSite4DownLoadEN.AddNewRecord();
}
catch(Exception objException)
{
strMsg = "(errid:Busi000152)添加记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值。该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objQxPrjSite4DownLoadEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN)
{
if (CheckUniqueness(objQxPrjSite4DownLoadEN) == false)
{
var strMsg = string.Format("记录已经存在!工程站点名 = [{0}],项目Id = [{1}]的数据已经存在!(in clsQxPrjSite4DownLoadBL.AddNewRecordWithMaxId)", objQxPrjSite4DownLoadEN.PrjSiteName,objQxPrjSite4DownLoadEN.QxPrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQxPrjSite4DownLoadEN.PrjSiteId) == true || clsQxPrjSite4DownLoadBL.IsExist(objQxPrjSite4DownLoadEN.PrjSiteId) == true)
 {
     objQxPrjSite4DownLoadEN.PrjSiteId = clsQxPrjSite4DownLoadBL.GetMaxStrId_S();
 }
string strPrjSiteId = clsQxPrjSite4DownLoadBL.QxPrjSite4DownLoadDA.AddNewRecordBySQL2WithReturnKey(objQxPrjSite4DownLoadEN);
     objQxPrjSite4DownLoadEN.PrjSiteId = strPrjSiteId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjSite4DownLoadBL.ReFreshCache();

if (clsQxPrjSite4DownLoadBL.relatedActions != null)
{
clsQxPrjSite4DownLoadBL.relatedActions.UpdRelaTabDate(objQxPrjSite4DownLoadEN.PrjSiteId, objQxPrjSite4DownLoadEN.UpdUserId);
}
return strPrjSiteId;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000096)添加记录出错, {1}.(from {0})",
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
 /// <param name = "objQxPrjSite4DownLoadEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN)
{
if (CheckUniqueness(objQxPrjSite4DownLoadEN) == false)
{
var strMsg = string.Format("记录已经存在!工程站点名 = [{0}],项目Id = [{1}]的数据已经存在!(in clsQxPrjSite4DownLoadBL.AddNewRecordWithReturnKey)", objQxPrjSite4DownLoadEN.PrjSiteName,objQxPrjSite4DownLoadEN.QxPrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQxPrjSite4DownLoadEN.PrjSiteId) == true || clsQxPrjSite4DownLoadBL.IsExist(objQxPrjSite4DownLoadEN.PrjSiteId) == true)
 {
     objQxPrjSite4DownLoadEN.PrjSiteId = clsQxPrjSite4DownLoadBL.GetMaxStrId_S();
 }
string strKey = clsQxPrjSite4DownLoadBL.QxPrjSite4DownLoadDA.AddNewRecordBySQL2WithReturnKey(objQxPrjSite4DownLoadEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjSite4DownLoadBL.ReFreshCache();

if (clsQxPrjSite4DownLoadBL.relatedActions != null)
{
clsQxPrjSite4DownLoadBL.relatedActions.UpdRelaTabDate(objQxPrjSite4DownLoadEN.PrjSiteId, objQxPrjSite4DownLoadEN.UpdUserId);
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
 /// <param name = "objQxPrjSite4DownLoadEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjSite4DownLoadEN SetPrjSiteId(this clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN, string strPrjSiteId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjSiteId, 6, conQxPrjSite4DownLoad.PrjSiteId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjSiteId, 6, conQxPrjSite4DownLoad.PrjSiteId);
}
objQxPrjSite4DownLoadEN.PrjSiteId = strPrjSiteId; //工程站点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjSite4DownLoadEN.dicFldComparisonOp.ContainsKey(conQxPrjSite4DownLoad.PrjSiteId) == false)
{
objQxPrjSite4DownLoadEN.dicFldComparisonOp.Add(conQxPrjSite4DownLoad.PrjSiteId, strComparisonOp);
}
else
{
objQxPrjSite4DownLoadEN.dicFldComparisonOp[conQxPrjSite4DownLoad.PrjSiteId] = strComparisonOp;
}
}
return objQxPrjSite4DownLoadEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjSite4DownLoadEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjSite4DownLoadEN SetPrjSiteName(this clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN, string strPrjSiteName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjSiteName, conQxPrjSite4DownLoad.PrjSiteName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjSiteName, 50, conQxPrjSite4DownLoad.PrjSiteName);
}
objQxPrjSite4DownLoadEN.PrjSiteName = strPrjSiteName; //工程站点名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjSite4DownLoadEN.dicFldComparisonOp.ContainsKey(conQxPrjSite4DownLoad.PrjSiteName) == false)
{
objQxPrjSite4DownLoadEN.dicFldComparisonOp.Add(conQxPrjSite4DownLoad.PrjSiteName, strComparisonOp);
}
else
{
objQxPrjSite4DownLoadEN.dicFldComparisonOp[conQxPrjSite4DownLoad.PrjSiteName] = strComparisonOp;
}
}
return objQxPrjSite4DownLoadEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjSite4DownLoadEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjSite4DownLoadEN SetQxPrjId(this clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, conQxPrjSite4DownLoad.QxPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQxPrjId, 4, conQxPrjSite4DownLoad.QxPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, conQxPrjSite4DownLoad.QxPrjId);
}
objQxPrjSite4DownLoadEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjSite4DownLoadEN.dicFldComparisonOp.ContainsKey(conQxPrjSite4DownLoad.QxPrjId) == false)
{
objQxPrjSite4DownLoadEN.dicFldComparisonOp.Add(conQxPrjSite4DownLoad.QxPrjId, strComparisonOp);
}
else
{
objQxPrjSite4DownLoadEN.dicFldComparisonOp[conQxPrjSite4DownLoad.QxPrjId] = strComparisonOp;
}
}
return objQxPrjSite4DownLoadEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjSite4DownLoadEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjSite4DownLoadEN SetFtpServer(this clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN, string strFtpServer, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFtpServer, conQxPrjSite4DownLoad.FtpServer);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFtpServer, 50, conQxPrjSite4DownLoad.FtpServer);
}
objQxPrjSite4DownLoadEN.FtpServer = strFtpServer; //Ftp服务器
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjSite4DownLoadEN.dicFldComparisonOp.ContainsKey(conQxPrjSite4DownLoad.FtpServer) == false)
{
objQxPrjSite4DownLoadEN.dicFldComparisonOp.Add(conQxPrjSite4DownLoad.FtpServer, strComparisonOp);
}
else
{
objQxPrjSite4DownLoadEN.dicFldComparisonOp[conQxPrjSite4DownLoad.FtpServer] = strComparisonOp;
}
}
return objQxPrjSite4DownLoadEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjSite4DownLoadEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjSite4DownLoadEN SetFtpUserId(this clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN, string strFtpUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFtpUserId, conQxPrjSite4DownLoad.FtpUserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFtpUserId, 20, conQxPrjSite4DownLoad.FtpUserId);
}
objQxPrjSite4DownLoadEN.FtpUserId = strFtpUserId; //Ftp用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjSite4DownLoadEN.dicFldComparisonOp.ContainsKey(conQxPrjSite4DownLoad.FtpUserId) == false)
{
objQxPrjSite4DownLoadEN.dicFldComparisonOp.Add(conQxPrjSite4DownLoad.FtpUserId, strComparisonOp);
}
else
{
objQxPrjSite4DownLoadEN.dicFldComparisonOp[conQxPrjSite4DownLoad.FtpUserId] = strComparisonOp;
}
}
return objQxPrjSite4DownLoadEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjSite4DownLoadEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjSite4DownLoadEN SetFtpUserPassword(this clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN, string strFtpUserPassword, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFtpUserPassword, conQxPrjSite4DownLoad.FtpUserPassword);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFtpUserPassword, 50, conQxPrjSite4DownLoad.FtpUserPassword);
}
objQxPrjSite4DownLoadEN.FtpUserPassword = strFtpUserPassword; //Ftp用户口令
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjSite4DownLoadEN.dicFldComparisonOp.ContainsKey(conQxPrjSite4DownLoad.FtpUserPassword) == false)
{
objQxPrjSite4DownLoadEN.dicFldComparisonOp.Add(conQxPrjSite4DownLoad.FtpUserPassword, strComparisonOp);
}
else
{
objQxPrjSite4DownLoadEN.dicFldComparisonOp[conQxPrjSite4DownLoad.FtpUserPassword] = strComparisonOp;
}
}
return objQxPrjSite4DownLoadEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjSite4DownLoadEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjSite4DownLoadEN SetUpdDate(this clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conQxPrjSite4DownLoad.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQxPrjSite4DownLoad.UpdDate);
}
objQxPrjSite4DownLoadEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjSite4DownLoadEN.dicFldComparisonOp.ContainsKey(conQxPrjSite4DownLoad.UpdDate) == false)
{
objQxPrjSite4DownLoadEN.dicFldComparisonOp.Add(conQxPrjSite4DownLoad.UpdDate, strComparisonOp);
}
else
{
objQxPrjSite4DownLoadEN.dicFldComparisonOp[conQxPrjSite4DownLoad.UpdDate] = strComparisonOp;
}
}
return objQxPrjSite4DownLoadEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjSite4DownLoadEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjSite4DownLoadEN SetUpdUserId(this clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUserId, conQxPrjSite4DownLoad.UpdUserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conQxPrjSite4DownLoad.UpdUserId);
}
objQxPrjSite4DownLoadEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjSite4DownLoadEN.dicFldComparisonOp.ContainsKey(conQxPrjSite4DownLoad.UpdUserId) == false)
{
objQxPrjSite4DownLoadEN.dicFldComparisonOp.Add(conQxPrjSite4DownLoad.UpdUserId, strComparisonOp);
}
else
{
objQxPrjSite4DownLoadEN.dicFldComparisonOp[conQxPrjSite4DownLoad.UpdUserId] = strComparisonOp;
}
}
return objQxPrjSite4DownLoadEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjSite4DownLoadEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjSite4DownLoadEN SetMemo(this clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQxPrjSite4DownLoad.Memo);
}
objQxPrjSite4DownLoadEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjSite4DownLoadEN.dicFldComparisonOp.ContainsKey(conQxPrjSite4DownLoad.Memo) == false)
{
objQxPrjSite4DownLoadEN.dicFldComparisonOp.Add(conQxPrjSite4DownLoad.Memo, strComparisonOp);
}
else
{
objQxPrjSite4DownLoadEN.dicFldComparisonOp[conQxPrjSite4DownLoad.Memo] = strComparisonOp;
}
}
return objQxPrjSite4DownLoadEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objQxPrjSite4DownLoadEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objQxPrjSite4DownLoadEN.CheckPropertyNew();
clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadCond = new clsQxPrjSite4DownLoadEN();
string strCondition = objQxPrjSite4DownLoadCond
.SetPrjSiteId(objQxPrjSite4DownLoadEN.PrjSiteId, "<>")
.SetPrjSiteName(objQxPrjSite4DownLoadEN.PrjSiteName, "=")
.SetQxPrjId(objQxPrjSite4DownLoadEN.QxPrjId, "=")
.GetCombineCondition();
objQxPrjSite4DownLoadEN._IsCheckProperty = true;
bool bolIsExist = clsQxPrjSite4DownLoadBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(PrjSiteName_QxPrjId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objQxPrjSite4DownLoadEN.Update();
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
 /// <param name = "objQxPrjSite4DownLoad">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoad)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadCond = new clsQxPrjSite4DownLoadEN();
string strCondition = objQxPrjSite4DownLoadCond
.SetPrjSiteName(objQxPrjSite4DownLoad.PrjSiteName, "=")
.SetQxPrjId(objQxPrjSite4DownLoad.QxPrjId, "=")
.GetCombineCondition();
objQxPrjSite4DownLoad._IsCheckProperty = true;
bool bolIsExist = clsQxPrjSite4DownLoadBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objQxPrjSite4DownLoad.PrjSiteId = clsQxPrjSite4DownLoadBL.GetFirstID_S(strCondition);
objQxPrjSite4DownLoad.UpdateWithCondition(strCondition);
}
else
{
objQxPrjSite4DownLoad.PrjSiteId = clsQxPrjSite4DownLoadBL.GetMaxStrId_S();
objQxPrjSite4DownLoad.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objQxPrjSite4DownLoadEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN)
{
 if (string.IsNullOrEmpty(objQxPrjSite4DownLoadEN.PrjSiteId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxPrjSite4DownLoadBL.QxPrjSite4DownLoadDA.UpdateBySql2(objQxPrjSite4DownLoadEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjSite4DownLoadBL.ReFreshCache();

if (clsQxPrjSite4DownLoadBL.relatedActions != null)
{
clsQxPrjSite4DownLoadBL.relatedActions.UpdRelaTabDate(objQxPrjSite4DownLoadEN.PrjSiteId, objQxPrjSite4DownLoadEN.UpdUserId);
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
 /// <param name = "objQxPrjSite4DownLoadEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objQxPrjSite4DownLoadEN.PrjSiteId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxPrjSite4DownLoadBL.QxPrjSite4DownLoadDA.UpdateBySql2(objQxPrjSite4DownLoadEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjSite4DownLoadBL.ReFreshCache();

if (clsQxPrjSite4DownLoadBL.relatedActions != null)
{
clsQxPrjSite4DownLoadBL.relatedActions.UpdRelaTabDate(objQxPrjSite4DownLoadEN.PrjSiteId, objQxPrjSite4DownLoadEN.UpdUserId);
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
 /// <param name = "objQxPrjSite4DownLoadEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN, string strWhereCond)
{
try
{
bool bolResult = clsQxPrjSite4DownLoadBL.QxPrjSite4DownLoadDA.UpdateBySqlWithCondition(objQxPrjSite4DownLoadEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjSite4DownLoadBL.ReFreshCache();

if (clsQxPrjSite4DownLoadBL.relatedActions != null)
{
clsQxPrjSite4DownLoadBL.relatedActions.UpdRelaTabDate(objQxPrjSite4DownLoadEN.PrjSiteId, objQxPrjSite4DownLoadEN.UpdUserId);
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
 /// <param name = "objQxPrjSite4DownLoadEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsQxPrjSite4DownLoadBL.QxPrjSite4DownLoadDA.UpdateBySqlWithConditionTransaction(objQxPrjSite4DownLoadEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjSite4DownLoadBL.ReFreshCache();

if (clsQxPrjSite4DownLoadBL.relatedActions != null)
{
clsQxPrjSite4DownLoadBL.relatedActions.UpdRelaTabDate(objQxPrjSite4DownLoadEN.PrjSiteId, objQxPrjSite4DownLoadEN.UpdUserId);
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
 /// <param name = "strPrjSiteId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN)
{
try
{
int intRecNum = clsQxPrjSite4DownLoadBL.QxPrjSite4DownLoadDA.DelRecord(objQxPrjSite4DownLoadEN.PrjSiteId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjSite4DownLoadBL.ReFreshCache();

if (clsQxPrjSite4DownLoadBL.relatedActions != null)
{
clsQxPrjSite4DownLoadBL.relatedActions.UpdRelaTabDate(objQxPrjSite4DownLoadEN.PrjSiteId, objQxPrjSite4DownLoadEN.UpdUserId);
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
 /// <param name = "objQxPrjSite4DownLoadENS">源对象</param>
 /// <param name = "objQxPrjSite4DownLoadENT">目标对象</param>
 public static void CopyTo(this clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadENS, clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadENT)
{
try
{
objQxPrjSite4DownLoadENT.PrjSiteId = objQxPrjSite4DownLoadENS.PrjSiteId; //工程站点Id
objQxPrjSite4DownLoadENT.PrjSiteName = objQxPrjSite4DownLoadENS.PrjSiteName; //工程站点名
objQxPrjSite4DownLoadENT.QxPrjId = objQxPrjSite4DownLoadENS.QxPrjId; //项目Id
objQxPrjSite4DownLoadENT.FtpServer = objQxPrjSite4DownLoadENS.FtpServer; //Ftp服务器
objQxPrjSite4DownLoadENT.FtpUserId = objQxPrjSite4DownLoadENS.FtpUserId; //Ftp用户Id
objQxPrjSite4DownLoadENT.FtpUserPassword = objQxPrjSite4DownLoadENS.FtpUserPassword; //Ftp用户口令
objQxPrjSite4DownLoadENT.UpdDate = objQxPrjSite4DownLoadENS.UpdDate; //修改日期
objQxPrjSite4DownLoadENT.UpdUserId = objQxPrjSite4DownLoadENS.UpdUserId; //修改用户Id
objQxPrjSite4DownLoadENT.Memo = objQxPrjSite4DownLoadENS.Memo; //备注
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
 /// <param name = "objQxPrjSite4DownLoadENS">源对象</param>
 /// <returns>目标对象=>clsQxPrjSite4DownLoadEN:objQxPrjSite4DownLoadENT</returns>
 public static clsQxPrjSite4DownLoadEN CopyTo(this clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadENS)
{
try
{
 clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadENT = new clsQxPrjSite4DownLoadEN()
{
PrjSiteId = objQxPrjSite4DownLoadENS.PrjSiteId, //工程站点Id
PrjSiteName = objQxPrjSite4DownLoadENS.PrjSiteName, //工程站点名
QxPrjId = objQxPrjSite4DownLoadENS.QxPrjId, //项目Id
FtpServer = objQxPrjSite4DownLoadENS.FtpServer, //Ftp服务器
FtpUserId = objQxPrjSite4DownLoadENS.FtpUserId, //Ftp用户Id
FtpUserPassword = objQxPrjSite4DownLoadENS.FtpUserPassword, //Ftp用户口令
UpdDate = objQxPrjSite4DownLoadENS.UpdDate, //修改日期
UpdUserId = objQxPrjSite4DownLoadENS.UpdUserId, //修改用户Id
Memo = objQxPrjSite4DownLoadENS.Memo, //备注
};
 return objQxPrjSite4DownLoadENT;
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
public static void CheckPropertyNew(this clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN)
{
 clsQxPrjSite4DownLoadBL.QxPrjSite4DownLoadDA.CheckPropertyNew(objQxPrjSite4DownLoadEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN)
{
 clsQxPrjSite4DownLoadBL.QxPrjSite4DownLoadDA.CheckProperty4Condition(objQxPrjSite4DownLoadEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQxPrjSite4DownLoadCond.IsUpdated(conQxPrjSite4DownLoad.PrjSiteId) == true)
{
string strComparisonOpPrjSiteId = objQxPrjSite4DownLoadCond.dicFldComparisonOp[conQxPrjSite4DownLoad.PrjSiteId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjSite4DownLoad.PrjSiteId, objQxPrjSite4DownLoadCond.PrjSiteId, strComparisonOpPrjSiteId);
}
if (objQxPrjSite4DownLoadCond.IsUpdated(conQxPrjSite4DownLoad.PrjSiteName) == true)
{
string strComparisonOpPrjSiteName = objQxPrjSite4DownLoadCond.dicFldComparisonOp[conQxPrjSite4DownLoad.PrjSiteName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjSite4DownLoad.PrjSiteName, objQxPrjSite4DownLoadCond.PrjSiteName, strComparisonOpPrjSiteName);
}
if (objQxPrjSite4DownLoadCond.IsUpdated(conQxPrjSite4DownLoad.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objQxPrjSite4DownLoadCond.dicFldComparisonOp[conQxPrjSite4DownLoad.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjSite4DownLoad.QxPrjId, objQxPrjSite4DownLoadCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objQxPrjSite4DownLoadCond.IsUpdated(conQxPrjSite4DownLoad.FtpServer) == true)
{
string strComparisonOpFtpServer = objQxPrjSite4DownLoadCond.dicFldComparisonOp[conQxPrjSite4DownLoad.FtpServer];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjSite4DownLoad.FtpServer, objQxPrjSite4DownLoadCond.FtpServer, strComparisonOpFtpServer);
}
if (objQxPrjSite4DownLoadCond.IsUpdated(conQxPrjSite4DownLoad.FtpUserId) == true)
{
string strComparisonOpFtpUserId = objQxPrjSite4DownLoadCond.dicFldComparisonOp[conQxPrjSite4DownLoad.FtpUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjSite4DownLoad.FtpUserId, objQxPrjSite4DownLoadCond.FtpUserId, strComparisonOpFtpUserId);
}
if (objQxPrjSite4DownLoadCond.IsUpdated(conQxPrjSite4DownLoad.FtpUserPassword) == true)
{
string strComparisonOpFtpUserPassword = objQxPrjSite4DownLoadCond.dicFldComparisonOp[conQxPrjSite4DownLoad.FtpUserPassword];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjSite4DownLoad.FtpUserPassword, objQxPrjSite4DownLoadCond.FtpUserPassword, strComparisonOpFtpUserPassword);
}
if (objQxPrjSite4DownLoadCond.IsUpdated(conQxPrjSite4DownLoad.UpdDate) == true)
{
string strComparisonOpUpdDate = objQxPrjSite4DownLoadCond.dicFldComparisonOp[conQxPrjSite4DownLoad.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjSite4DownLoad.UpdDate, objQxPrjSite4DownLoadCond.UpdDate, strComparisonOpUpdDate);
}
if (objQxPrjSite4DownLoadCond.IsUpdated(conQxPrjSite4DownLoad.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objQxPrjSite4DownLoadCond.dicFldComparisonOp[conQxPrjSite4DownLoad.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjSite4DownLoad.UpdUserId, objQxPrjSite4DownLoadCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objQxPrjSite4DownLoadCond.IsUpdated(conQxPrjSite4DownLoad.Memo) == true)
{
string strComparisonOpMemo = objQxPrjSite4DownLoadCond.dicFldComparisonOp[conQxPrjSite4DownLoad.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjSite4DownLoad.Memo, objQxPrjSite4DownLoadCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--QxPrjSite4DownLoad(文件下载站点), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:PrjSiteName_QxPrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objQxPrjSite4DownLoadEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objQxPrjSite4DownLoadEN == null) return true;
if (objQxPrjSite4DownLoadEN.PrjSiteId == null || objQxPrjSite4DownLoadEN.PrjSiteId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjSiteName = '{0}'", objQxPrjSite4DownLoadEN.PrjSiteName);
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxPrjSite4DownLoadEN.QxPrjId);
if (clsQxPrjSite4DownLoadBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("PrjSiteId !=  '{0}'", objQxPrjSite4DownLoadEN.PrjSiteId);
 sbCondition.AppendFormat(" and PrjSiteName = '{0}'", objQxPrjSite4DownLoadEN.PrjSiteName);
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxPrjSite4DownLoadEN.QxPrjId);
if (clsQxPrjSite4DownLoadBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--QxPrjSite4DownLoad(文件下载站点), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PrjSiteName_QxPrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objQxPrjSite4DownLoadEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objQxPrjSite4DownLoadEN == null) return "";
if (objQxPrjSite4DownLoadEN.PrjSiteId == null || objQxPrjSite4DownLoadEN.PrjSiteId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjSiteName = '{0}'", objQxPrjSite4DownLoadEN.PrjSiteName);
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxPrjSite4DownLoadEN.QxPrjId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("PrjSiteId !=  '{0}'", objQxPrjSite4DownLoadEN.PrjSiteId);
 sbCondition.AppendFormat(" and PrjSiteName = '{0}'", objQxPrjSite4DownLoadEN.PrjSiteName);
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxPrjSite4DownLoadEN.QxPrjId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_QxPrjSite4DownLoad
{
public virtual bool UpdRelaTabDate(string strPrjSiteId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 文件下载站点(QxPrjSite4DownLoad)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsQxPrjSite4DownLoadBL
{
public static RelatedActions_QxPrjSite4DownLoad relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "QxPrjSite4DownLoadListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "QxPrjSite4DownLoadList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsQxPrjSite4DownLoadEN> arrQxPrjSite4DownLoadObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsQxPrjSite4DownLoadDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsQxPrjSite4DownLoadDA QxPrjSite4DownLoadDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsQxPrjSite4DownLoadDA();
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
 public clsQxPrjSite4DownLoadBL()
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
if (string.IsNullOrEmpty(clsQxPrjSite4DownLoadEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxPrjSite4DownLoadEN._ConnectString);
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
objDS = QxPrjSite4DownLoadDA.GetDataSet(strWhereCond);
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
objDS = QxPrjSite4DownLoadDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = QxPrjSite4DownLoadDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_QxPrjSite4DownLoad(string strWhereCond)
{
DataTable objDT;
try
{
objDT = QxPrjSite4DownLoadDA.GetDataTable_QxPrjSite4DownLoad(strWhereCond);
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
objDT = QxPrjSite4DownLoadDA.GetDataTable(strWhereCond);
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
objDT = QxPrjSite4DownLoadDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = QxPrjSite4DownLoadDA.GetDataTable(strWhereCond, strTabName);
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
objDT = QxPrjSite4DownLoadDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = QxPrjSite4DownLoadDA.GetDataTable_Top(objTopPara);
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
objDT = QxPrjSite4DownLoadDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = QxPrjSite4DownLoadDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = QxPrjSite4DownLoadDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = QxPrjSite4DownLoadDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = QxPrjSite4DownLoadDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = QxPrjSite4DownLoadDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = QxPrjSite4DownLoadDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = QxPrjSite4DownLoadDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
public static List<clsQxPrjSite4DownLoadEN> GetObjLstByPrjSiteIdLst(List<string> arrPrjSiteIdLst)
{
List<clsQxPrjSite4DownLoadEN> arrObjLst = new List<clsQxPrjSite4DownLoadEN>(); 
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
	clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN = new clsQxPrjSite4DownLoadEN();
try
{
objQxPrjSite4DownLoadEN.PrjSiteId = objRow[conQxPrjSite4DownLoad.PrjSiteId].ToString().Trim(); //工程站点Id
objQxPrjSite4DownLoadEN.PrjSiteName = objRow[conQxPrjSite4DownLoad.PrjSiteName].ToString().Trim(); //工程站点名
objQxPrjSite4DownLoadEN.QxPrjId = objRow[conQxPrjSite4DownLoad.QxPrjId].ToString().Trim(); //项目Id
objQxPrjSite4DownLoadEN.FtpServer = objRow[conQxPrjSite4DownLoad.FtpServer].ToString().Trim(); //Ftp服务器
objQxPrjSite4DownLoadEN.FtpUserId = objRow[conQxPrjSite4DownLoad.FtpUserId].ToString().Trim(); //Ftp用户Id
objQxPrjSite4DownLoadEN.FtpUserPassword = objRow[conQxPrjSite4DownLoad.FtpUserPassword].ToString().Trim(); //Ftp用户口令
objQxPrjSite4DownLoadEN.UpdDate = objRow[conQxPrjSite4DownLoad.UpdDate].ToString().Trim(); //修改日期
objQxPrjSite4DownLoadEN.UpdUserId = objRow[conQxPrjSite4DownLoad.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjSite4DownLoadEN.Memo = objRow[conQxPrjSite4DownLoad.Memo] == DBNull.Value ? null : objRow[conQxPrjSite4DownLoad.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjSite4DownLoadEN.PrjSiteId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjSite4DownLoadEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPrjSiteIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsQxPrjSite4DownLoadEN> GetObjLstByPrjSiteIdLstCache(List<string> arrPrjSiteIdLst)
{
string strKey = string.Format("{0}", clsQxPrjSite4DownLoadEN._CurrTabName);
List<clsQxPrjSite4DownLoadEN> arrQxPrjSite4DownLoadObjLstCache = GetObjLstCache();
IEnumerable <clsQxPrjSite4DownLoadEN> arrQxPrjSite4DownLoadObjLst_Sel =
arrQxPrjSite4DownLoadObjLstCache
.Where(x => arrPrjSiteIdLst.Contains(x.PrjSiteId));
return arrQxPrjSite4DownLoadObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPrjSite4DownLoadEN> GetObjLst(string strWhereCond)
{
List<clsQxPrjSite4DownLoadEN> arrObjLst = new List<clsQxPrjSite4DownLoadEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN = new clsQxPrjSite4DownLoadEN();
try
{
objQxPrjSite4DownLoadEN.PrjSiteId = objRow[conQxPrjSite4DownLoad.PrjSiteId].ToString().Trim(); //工程站点Id
objQxPrjSite4DownLoadEN.PrjSiteName = objRow[conQxPrjSite4DownLoad.PrjSiteName].ToString().Trim(); //工程站点名
objQxPrjSite4DownLoadEN.QxPrjId = objRow[conQxPrjSite4DownLoad.QxPrjId].ToString().Trim(); //项目Id
objQxPrjSite4DownLoadEN.FtpServer = objRow[conQxPrjSite4DownLoad.FtpServer].ToString().Trim(); //Ftp服务器
objQxPrjSite4DownLoadEN.FtpUserId = objRow[conQxPrjSite4DownLoad.FtpUserId].ToString().Trim(); //Ftp用户Id
objQxPrjSite4DownLoadEN.FtpUserPassword = objRow[conQxPrjSite4DownLoad.FtpUserPassword].ToString().Trim(); //Ftp用户口令
objQxPrjSite4DownLoadEN.UpdDate = objRow[conQxPrjSite4DownLoad.UpdDate].ToString().Trim(); //修改日期
objQxPrjSite4DownLoadEN.UpdUserId = objRow[conQxPrjSite4DownLoad.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjSite4DownLoadEN.Memo = objRow[conQxPrjSite4DownLoad.Memo] == DBNull.Value ? null : objRow[conQxPrjSite4DownLoad.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjSite4DownLoadEN.PrjSiteId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjSite4DownLoadEN);
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
public static List<clsQxPrjSite4DownLoadEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsQxPrjSite4DownLoadEN> arrObjLst = new List<clsQxPrjSite4DownLoadEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN = new clsQxPrjSite4DownLoadEN();
try
{
objQxPrjSite4DownLoadEN.PrjSiteId = objRow[conQxPrjSite4DownLoad.PrjSiteId].ToString().Trim(); //工程站点Id
objQxPrjSite4DownLoadEN.PrjSiteName = objRow[conQxPrjSite4DownLoad.PrjSiteName].ToString().Trim(); //工程站点名
objQxPrjSite4DownLoadEN.QxPrjId = objRow[conQxPrjSite4DownLoad.QxPrjId].ToString().Trim(); //项目Id
objQxPrjSite4DownLoadEN.FtpServer = objRow[conQxPrjSite4DownLoad.FtpServer].ToString().Trim(); //Ftp服务器
objQxPrjSite4DownLoadEN.FtpUserId = objRow[conQxPrjSite4DownLoad.FtpUserId].ToString().Trim(); //Ftp用户Id
objQxPrjSite4DownLoadEN.FtpUserPassword = objRow[conQxPrjSite4DownLoad.FtpUserPassword].ToString().Trim(); //Ftp用户口令
objQxPrjSite4DownLoadEN.UpdDate = objRow[conQxPrjSite4DownLoad.UpdDate].ToString().Trim(); //修改日期
objQxPrjSite4DownLoadEN.UpdUserId = objRow[conQxPrjSite4DownLoad.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjSite4DownLoadEN.Memo = objRow[conQxPrjSite4DownLoad.Memo] == DBNull.Value ? null : objRow[conQxPrjSite4DownLoad.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjSite4DownLoadEN.PrjSiteId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjSite4DownLoadEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objQxPrjSite4DownLoadCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsQxPrjSite4DownLoadEN> GetSubObjLstCache(clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadCond)
{
List<clsQxPrjSite4DownLoadEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxPrjSite4DownLoadEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxPrjSite4DownLoad.AttributeName)
{
if (objQxPrjSite4DownLoadCond.IsUpdated(strFldName) == false) continue;
if (objQxPrjSite4DownLoadCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxPrjSite4DownLoadCond[strFldName].ToString());
}
else
{
if (objQxPrjSite4DownLoadCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxPrjSite4DownLoadCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxPrjSite4DownLoadCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxPrjSite4DownLoadCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxPrjSite4DownLoadCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxPrjSite4DownLoadCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxPrjSite4DownLoadCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxPrjSite4DownLoadCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxPrjSite4DownLoadCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxPrjSite4DownLoadCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxPrjSite4DownLoadCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxPrjSite4DownLoadCond[strFldName]));
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
public static List<clsQxPrjSite4DownLoadEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsQxPrjSite4DownLoadEN> arrObjLst = new List<clsQxPrjSite4DownLoadEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN = new clsQxPrjSite4DownLoadEN();
try
{
objQxPrjSite4DownLoadEN.PrjSiteId = objRow[conQxPrjSite4DownLoad.PrjSiteId].ToString().Trim(); //工程站点Id
objQxPrjSite4DownLoadEN.PrjSiteName = objRow[conQxPrjSite4DownLoad.PrjSiteName].ToString().Trim(); //工程站点名
objQxPrjSite4DownLoadEN.QxPrjId = objRow[conQxPrjSite4DownLoad.QxPrjId].ToString().Trim(); //项目Id
objQxPrjSite4DownLoadEN.FtpServer = objRow[conQxPrjSite4DownLoad.FtpServer].ToString().Trim(); //Ftp服务器
objQxPrjSite4DownLoadEN.FtpUserId = objRow[conQxPrjSite4DownLoad.FtpUserId].ToString().Trim(); //Ftp用户Id
objQxPrjSite4DownLoadEN.FtpUserPassword = objRow[conQxPrjSite4DownLoad.FtpUserPassword].ToString().Trim(); //Ftp用户口令
objQxPrjSite4DownLoadEN.UpdDate = objRow[conQxPrjSite4DownLoad.UpdDate].ToString().Trim(); //修改日期
objQxPrjSite4DownLoadEN.UpdUserId = objRow[conQxPrjSite4DownLoad.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjSite4DownLoadEN.Memo = objRow[conQxPrjSite4DownLoad.Memo] == DBNull.Value ? null : objRow[conQxPrjSite4DownLoad.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjSite4DownLoadEN.PrjSiteId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjSite4DownLoadEN);
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
public static List<clsQxPrjSite4DownLoadEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsQxPrjSite4DownLoadEN> arrObjLst = new List<clsQxPrjSite4DownLoadEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN = new clsQxPrjSite4DownLoadEN();
try
{
objQxPrjSite4DownLoadEN.PrjSiteId = objRow[conQxPrjSite4DownLoad.PrjSiteId].ToString().Trim(); //工程站点Id
objQxPrjSite4DownLoadEN.PrjSiteName = objRow[conQxPrjSite4DownLoad.PrjSiteName].ToString().Trim(); //工程站点名
objQxPrjSite4DownLoadEN.QxPrjId = objRow[conQxPrjSite4DownLoad.QxPrjId].ToString().Trim(); //项目Id
objQxPrjSite4DownLoadEN.FtpServer = objRow[conQxPrjSite4DownLoad.FtpServer].ToString().Trim(); //Ftp服务器
objQxPrjSite4DownLoadEN.FtpUserId = objRow[conQxPrjSite4DownLoad.FtpUserId].ToString().Trim(); //Ftp用户Id
objQxPrjSite4DownLoadEN.FtpUserPassword = objRow[conQxPrjSite4DownLoad.FtpUserPassword].ToString().Trim(); //Ftp用户口令
objQxPrjSite4DownLoadEN.UpdDate = objRow[conQxPrjSite4DownLoad.UpdDate].ToString().Trim(); //修改日期
objQxPrjSite4DownLoadEN.UpdUserId = objRow[conQxPrjSite4DownLoad.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjSite4DownLoadEN.Memo = objRow[conQxPrjSite4DownLoad.Memo] == DBNull.Value ? null : objRow[conQxPrjSite4DownLoad.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjSite4DownLoadEN.PrjSiteId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjSite4DownLoadEN);
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
List<clsQxPrjSite4DownLoadEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsQxPrjSite4DownLoadEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPrjSite4DownLoadEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsQxPrjSite4DownLoadEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsQxPrjSite4DownLoadEN> arrObjLst = new List<clsQxPrjSite4DownLoadEN>(); 
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
	clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN = new clsQxPrjSite4DownLoadEN();
try
{
objQxPrjSite4DownLoadEN.PrjSiteId = objRow[conQxPrjSite4DownLoad.PrjSiteId].ToString().Trim(); //工程站点Id
objQxPrjSite4DownLoadEN.PrjSiteName = objRow[conQxPrjSite4DownLoad.PrjSiteName].ToString().Trim(); //工程站点名
objQxPrjSite4DownLoadEN.QxPrjId = objRow[conQxPrjSite4DownLoad.QxPrjId].ToString().Trim(); //项目Id
objQxPrjSite4DownLoadEN.FtpServer = objRow[conQxPrjSite4DownLoad.FtpServer].ToString().Trim(); //Ftp服务器
objQxPrjSite4DownLoadEN.FtpUserId = objRow[conQxPrjSite4DownLoad.FtpUserId].ToString().Trim(); //Ftp用户Id
objQxPrjSite4DownLoadEN.FtpUserPassword = objRow[conQxPrjSite4DownLoad.FtpUserPassword].ToString().Trim(); //Ftp用户口令
objQxPrjSite4DownLoadEN.UpdDate = objRow[conQxPrjSite4DownLoad.UpdDate].ToString().Trim(); //修改日期
objQxPrjSite4DownLoadEN.UpdUserId = objRow[conQxPrjSite4DownLoad.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjSite4DownLoadEN.Memo = objRow[conQxPrjSite4DownLoad.Memo] == DBNull.Value ? null : objRow[conQxPrjSite4DownLoad.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjSite4DownLoadEN.PrjSiteId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjSite4DownLoadEN);
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
public static List<clsQxPrjSite4DownLoadEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsQxPrjSite4DownLoadEN> arrObjLst = new List<clsQxPrjSite4DownLoadEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN = new clsQxPrjSite4DownLoadEN();
try
{
objQxPrjSite4DownLoadEN.PrjSiteId = objRow[conQxPrjSite4DownLoad.PrjSiteId].ToString().Trim(); //工程站点Id
objQxPrjSite4DownLoadEN.PrjSiteName = objRow[conQxPrjSite4DownLoad.PrjSiteName].ToString().Trim(); //工程站点名
objQxPrjSite4DownLoadEN.QxPrjId = objRow[conQxPrjSite4DownLoad.QxPrjId].ToString().Trim(); //项目Id
objQxPrjSite4DownLoadEN.FtpServer = objRow[conQxPrjSite4DownLoad.FtpServer].ToString().Trim(); //Ftp服务器
objQxPrjSite4DownLoadEN.FtpUserId = objRow[conQxPrjSite4DownLoad.FtpUserId].ToString().Trim(); //Ftp用户Id
objQxPrjSite4DownLoadEN.FtpUserPassword = objRow[conQxPrjSite4DownLoad.FtpUserPassword].ToString().Trim(); //Ftp用户口令
objQxPrjSite4DownLoadEN.UpdDate = objRow[conQxPrjSite4DownLoad.UpdDate].ToString().Trim(); //修改日期
objQxPrjSite4DownLoadEN.UpdUserId = objRow[conQxPrjSite4DownLoad.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjSite4DownLoadEN.Memo = objRow[conQxPrjSite4DownLoad.Memo] == DBNull.Value ? null : objRow[conQxPrjSite4DownLoad.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjSite4DownLoadEN.PrjSiteId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjSite4DownLoadEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsQxPrjSite4DownLoadEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsQxPrjSite4DownLoadEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsQxPrjSite4DownLoadEN> arrObjLst = new List<clsQxPrjSite4DownLoadEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN = new clsQxPrjSite4DownLoadEN();
try
{
objQxPrjSite4DownLoadEN.PrjSiteId = objRow[conQxPrjSite4DownLoad.PrjSiteId].ToString().Trim(); //工程站点Id
objQxPrjSite4DownLoadEN.PrjSiteName = objRow[conQxPrjSite4DownLoad.PrjSiteName].ToString().Trim(); //工程站点名
objQxPrjSite4DownLoadEN.QxPrjId = objRow[conQxPrjSite4DownLoad.QxPrjId].ToString().Trim(); //项目Id
objQxPrjSite4DownLoadEN.FtpServer = objRow[conQxPrjSite4DownLoad.FtpServer].ToString().Trim(); //Ftp服务器
objQxPrjSite4DownLoadEN.FtpUserId = objRow[conQxPrjSite4DownLoad.FtpUserId].ToString().Trim(); //Ftp用户Id
objQxPrjSite4DownLoadEN.FtpUserPassword = objRow[conQxPrjSite4DownLoad.FtpUserPassword].ToString().Trim(); //Ftp用户口令
objQxPrjSite4DownLoadEN.UpdDate = objRow[conQxPrjSite4DownLoad.UpdDate].ToString().Trim(); //修改日期
objQxPrjSite4DownLoadEN.UpdUserId = objRow[conQxPrjSite4DownLoad.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjSite4DownLoadEN.Memo = objRow[conQxPrjSite4DownLoad.Memo] == DBNull.Value ? null : objRow[conQxPrjSite4DownLoad.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjSite4DownLoadEN.PrjSiteId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjSite4DownLoadEN);
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
public static List<clsQxPrjSite4DownLoadEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsQxPrjSite4DownLoadEN> arrObjLst = new List<clsQxPrjSite4DownLoadEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN = new clsQxPrjSite4DownLoadEN();
try
{
objQxPrjSite4DownLoadEN.PrjSiteId = objRow[conQxPrjSite4DownLoad.PrjSiteId].ToString().Trim(); //工程站点Id
objQxPrjSite4DownLoadEN.PrjSiteName = objRow[conQxPrjSite4DownLoad.PrjSiteName].ToString().Trim(); //工程站点名
objQxPrjSite4DownLoadEN.QxPrjId = objRow[conQxPrjSite4DownLoad.QxPrjId].ToString().Trim(); //项目Id
objQxPrjSite4DownLoadEN.FtpServer = objRow[conQxPrjSite4DownLoad.FtpServer].ToString().Trim(); //Ftp服务器
objQxPrjSite4DownLoadEN.FtpUserId = objRow[conQxPrjSite4DownLoad.FtpUserId].ToString().Trim(); //Ftp用户Id
objQxPrjSite4DownLoadEN.FtpUserPassword = objRow[conQxPrjSite4DownLoad.FtpUserPassword].ToString().Trim(); //Ftp用户口令
objQxPrjSite4DownLoadEN.UpdDate = objRow[conQxPrjSite4DownLoad.UpdDate].ToString().Trim(); //修改日期
objQxPrjSite4DownLoadEN.UpdUserId = objRow[conQxPrjSite4DownLoad.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjSite4DownLoadEN.Memo = objRow[conQxPrjSite4DownLoad.Memo] == DBNull.Value ? null : objRow[conQxPrjSite4DownLoad.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjSite4DownLoadEN.PrjSiteId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjSite4DownLoadEN);
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
public static IEnumerable<clsQxPrjSite4DownLoadEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadCond, string strOrderBy)
{
List<clsQxPrjSite4DownLoadEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxPrjSite4DownLoadEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxPrjSite4DownLoad.AttributeName)
{
if (objQxPrjSite4DownLoadCond.IsUpdated(strFldName) == false) continue;
if (objQxPrjSite4DownLoadCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxPrjSite4DownLoadCond[strFldName].ToString());
}
else
{
if (objQxPrjSite4DownLoadCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxPrjSite4DownLoadCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxPrjSite4DownLoadCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxPrjSite4DownLoadCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxPrjSite4DownLoadCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxPrjSite4DownLoadCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxPrjSite4DownLoadCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxPrjSite4DownLoadCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxPrjSite4DownLoadCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxPrjSite4DownLoadCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxPrjSite4DownLoadCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxPrjSite4DownLoadCond[strFldName]));
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
public static IEnumerable<clsQxPrjSite4DownLoadEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadCond = JsonConvert.DeserializeObject<clsQxPrjSite4DownLoadEN>(objPagerPara.whereCond);
if (objQxPrjSite4DownLoadCond.sfFldComparisonOp == null)
{
objQxPrjSite4DownLoadCond.dicFldComparisonOp = null;
}
else
{
objQxPrjSite4DownLoadCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objQxPrjSite4DownLoadCond.sfFldComparisonOp);
}
clsQxPrjSite4DownLoadBL.SetUpdFlag(objQxPrjSite4DownLoadCond);
 try
{
CheckProperty4Condition(objQxPrjSite4DownLoadCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsQxPrjSite4DownLoadBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objQxPrjSite4DownLoadCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPrjSite4DownLoadEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsQxPrjSite4DownLoadEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsQxPrjSite4DownLoadEN> arrObjLst = new List<clsQxPrjSite4DownLoadEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN = new clsQxPrjSite4DownLoadEN();
try
{
objQxPrjSite4DownLoadEN.PrjSiteId = objRow[conQxPrjSite4DownLoad.PrjSiteId].ToString().Trim(); //工程站点Id
objQxPrjSite4DownLoadEN.PrjSiteName = objRow[conQxPrjSite4DownLoad.PrjSiteName].ToString().Trim(); //工程站点名
objQxPrjSite4DownLoadEN.QxPrjId = objRow[conQxPrjSite4DownLoad.QxPrjId].ToString().Trim(); //项目Id
objQxPrjSite4DownLoadEN.FtpServer = objRow[conQxPrjSite4DownLoad.FtpServer].ToString().Trim(); //Ftp服务器
objQxPrjSite4DownLoadEN.FtpUserId = objRow[conQxPrjSite4DownLoad.FtpUserId].ToString().Trim(); //Ftp用户Id
objQxPrjSite4DownLoadEN.FtpUserPassword = objRow[conQxPrjSite4DownLoad.FtpUserPassword].ToString().Trim(); //Ftp用户口令
objQxPrjSite4DownLoadEN.UpdDate = objRow[conQxPrjSite4DownLoad.UpdDate].ToString().Trim(); //修改日期
objQxPrjSite4DownLoadEN.UpdUserId = objRow[conQxPrjSite4DownLoad.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjSite4DownLoadEN.Memo = objRow[conQxPrjSite4DownLoad.Memo] == DBNull.Value ? null : objRow[conQxPrjSite4DownLoad.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjSite4DownLoadEN.PrjSiteId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjSite4DownLoadEN);
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
public static List<clsQxPrjSite4DownLoadEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsQxPrjSite4DownLoadEN> arrObjLst = new List<clsQxPrjSite4DownLoadEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN = new clsQxPrjSite4DownLoadEN();
try
{
objQxPrjSite4DownLoadEN.PrjSiteId = objRow[conQxPrjSite4DownLoad.PrjSiteId].ToString().Trim(); //工程站点Id
objQxPrjSite4DownLoadEN.PrjSiteName = objRow[conQxPrjSite4DownLoad.PrjSiteName].ToString().Trim(); //工程站点名
objQxPrjSite4DownLoadEN.QxPrjId = objRow[conQxPrjSite4DownLoad.QxPrjId].ToString().Trim(); //项目Id
objQxPrjSite4DownLoadEN.FtpServer = objRow[conQxPrjSite4DownLoad.FtpServer].ToString().Trim(); //Ftp服务器
objQxPrjSite4DownLoadEN.FtpUserId = objRow[conQxPrjSite4DownLoad.FtpUserId].ToString().Trim(); //Ftp用户Id
objQxPrjSite4DownLoadEN.FtpUserPassword = objRow[conQxPrjSite4DownLoad.FtpUserPassword].ToString().Trim(); //Ftp用户口令
objQxPrjSite4DownLoadEN.UpdDate = objRow[conQxPrjSite4DownLoad.UpdDate].ToString().Trim(); //修改日期
objQxPrjSite4DownLoadEN.UpdUserId = objRow[conQxPrjSite4DownLoad.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjSite4DownLoadEN.Memo = objRow[conQxPrjSite4DownLoad.Memo] == DBNull.Value ? null : objRow[conQxPrjSite4DownLoad.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjSite4DownLoadEN.PrjSiteId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjSite4DownLoadEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPrjSite4DownLoadEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsQxPrjSite4DownLoadEN> arrObjLst = new List<clsQxPrjSite4DownLoadEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN = new clsQxPrjSite4DownLoadEN();
try
{
objQxPrjSite4DownLoadEN.PrjSiteId = objRow[conQxPrjSite4DownLoad.PrjSiteId].ToString().Trim(); //工程站点Id
objQxPrjSite4DownLoadEN.PrjSiteName = objRow[conQxPrjSite4DownLoad.PrjSiteName].ToString().Trim(); //工程站点名
objQxPrjSite4DownLoadEN.QxPrjId = objRow[conQxPrjSite4DownLoad.QxPrjId].ToString().Trim(); //项目Id
objQxPrjSite4DownLoadEN.FtpServer = objRow[conQxPrjSite4DownLoad.FtpServer].ToString().Trim(); //Ftp服务器
objQxPrjSite4DownLoadEN.FtpUserId = objRow[conQxPrjSite4DownLoad.FtpUserId].ToString().Trim(); //Ftp用户Id
objQxPrjSite4DownLoadEN.FtpUserPassword = objRow[conQxPrjSite4DownLoad.FtpUserPassword].ToString().Trim(); //Ftp用户口令
objQxPrjSite4DownLoadEN.UpdDate = objRow[conQxPrjSite4DownLoad.UpdDate].ToString().Trim(); //修改日期
objQxPrjSite4DownLoadEN.UpdUserId = objRow[conQxPrjSite4DownLoad.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjSite4DownLoadEN.Memo = objRow[conQxPrjSite4DownLoad.Memo] == DBNull.Value ? null : objRow[conQxPrjSite4DownLoad.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjSite4DownLoadEN.PrjSiteId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjSite4DownLoadEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objQxPrjSite4DownLoadEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxPrjSite4DownLoad(ref clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN)
{
bool bolResult = QxPrjSite4DownLoadDA.GetQxPrjSite4DownLoad(ref objQxPrjSite4DownLoadEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strPrjSiteId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxPrjSite4DownLoadEN GetObjByPrjSiteId(string strPrjSiteId)
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
clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN = QxPrjSite4DownLoadDA.GetObjByPrjSiteId(strPrjSiteId);
return objQxPrjSite4DownLoadEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsQxPrjSite4DownLoadEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN = QxPrjSite4DownLoadDA.GetFirstObj(strWhereCond);
 return objQxPrjSite4DownLoadEN;
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
public static clsQxPrjSite4DownLoadEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN = QxPrjSite4DownLoadDA.GetObjByDataRow(objRow);
 return objQxPrjSite4DownLoadEN;
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
public static clsQxPrjSite4DownLoadEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN = QxPrjSite4DownLoadDA.GetObjByDataRow(objRow);
 return objQxPrjSite4DownLoadEN;
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
 /// <param name = "lstQxPrjSite4DownLoadObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxPrjSite4DownLoadEN GetObjByPrjSiteIdFromList(string strPrjSiteId, List<clsQxPrjSite4DownLoadEN> lstQxPrjSite4DownLoadObjLst)
{
foreach (clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN in lstQxPrjSite4DownLoadObjLst)
{
if (objQxPrjSite4DownLoadEN.PrjSiteId == strPrjSiteId)
{
return objQxPrjSite4DownLoadEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetMaxStrId_S)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId_S() 
{
 string strMaxPrjSiteId;
 try
 {
 strMaxPrjSiteId = clsQxPrjSite4DownLoadDA.GetMaxStrId();
 return strMaxPrjSiteId;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000024)获取最大关键字值出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

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
 strPrjSiteId = new clsQxPrjSite4DownLoadDA().GetFirstID(strWhereCond);
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
 arrList = QxPrjSite4DownLoadDA.GetID(strWhereCond);
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
bool bolIsExist = QxPrjSite4DownLoadDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = QxPrjSite4DownLoadDA.IsExist(strPrjSiteId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strPrjSiteId">工程站点Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strPrjSiteId, string strOpUser)
{
clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN = clsQxPrjSite4DownLoadBL.GetObjByPrjSiteId(strPrjSiteId);
objQxPrjSite4DownLoadEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objQxPrjSite4DownLoadEN.UpdUserId = strOpUser;
return clsQxPrjSite4DownLoadBL.UpdateBySql2(objQxPrjSite4DownLoadEN);
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
 bolIsExist = clsQxPrjSite4DownLoadDA.IsExistTable();
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
 bolIsExist = QxPrjSite4DownLoadDA.IsExistTable(strTabName);
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
 /// <param name = "objQxPrjSite4DownLoadEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN)
{
if (objQxPrjSite4DownLoadEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!工程站点名 = [{0}],项目Id = [{1}]的数据已经存在!(in clsQxPrjSite4DownLoadBL.AddNewRecordBySql2)", objQxPrjSite4DownLoadEN.PrjSiteName,objQxPrjSite4DownLoadEN.QxPrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQxPrjSite4DownLoadEN.PrjSiteId) == true || clsQxPrjSite4DownLoadBL.IsExist(objQxPrjSite4DownLoadEN.PrjSiteId) == true)
 {
     objQxPrjSite4DownLoadEN.PrjSiteId = clsQxPrjSite4DownLoadBL.GetMaxStrId_S();
 }
bool bolResult = QxPrjSite4DownLoadDA.AddNewRecordBySQL2(objQxPrjSite4DownLoadEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjSite4DownLoadBL.ReFreshCache();

if (clsQxPrjSite4DownLoadBL.relatedActions != null)
{
clsQxPrjSite4DownLoadBL.relatedActions.UpdRelaTabDate(objQxPrjSite4DownLoadEN.PrjSiteId, objQxPrjSite4DownLoadEN.UpdUserId);
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
 /// <param name = "objQxPrjSite4DownLoadEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN)
{
if (objQxPrjSite4DownLoadEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!工程站点名 = [{0}],项目Id = [{1}]的数据已经存在!(in clsQxPrjSite4DownLoadBL.AddNewRecordBySql2WithReturnKey)", objQxPrjSite4DownLoadEN.PrjSiteName,objQxPrjSite4DownLoadEN.QxPrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQxPrjSite4DownLoadEN.PrjSiteId) == true || clsQxPrjSite4DownLoadBL.IsExist(objQxPrjSite4DownLoadEN.PrjSiteId) == true)
 {
     objQxPrjSite4DownLoadEN.PrjSiteId = clsQxPrjSite4DownLoadBL.GetMaxStrId_S();
 }
string strKey = QxPrjSite4DownLoadDA.AddNewRecordBySQL2WithReturnKey(objQxPrjSite4DownLoadEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjSite4DownLoadBL.ReFreshCache();

if (clsQxPrjSite4DownLoadBL.relatedActions != null)
{
clsQxPrjSite4DownLoadBL.relatedActions.UpdRelaTabDate(objQxPrjSite4DownLoadEN.PrjSiteId, objQxPrjSite4DownLoadEN.UpdUserId);
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
 /// <param name = "strQxPrjSite4DownLoadObjXml">代表实体对象的XML串</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql_XML(string strQxPrjSite4DownLoadObjXml)
{
clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN = GetObjFromXmlStr(strQxPrjSite4DownLoadObjXml);
try
{
bool bolResult = QxPrjSite4DownLoadDA.AddNewRecordBySQL2(objQxPrjSite4DownLoadEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjSite4DownLoadBL.ReFreshCache();

if (clsQxPrjSite4DownLoadBL.relatedActions != null)
{
clsQxPrjSite4DownLoadBL.relatedActions.UpdRelaTabDate(objQxPrjSite4DownLoadEN.PrjSiteId, objQxPrjSite4DownLoadEN.UpdUserId);
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
 /// <param name = "objQxPrjSite4DownLoadEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN)
{
try
{
bool bolResult = QxPrjSite4DownLoadDA.Update(objQxPrjSite4DownLoadEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjSite4DownLoadBL.ReFreshCache();

if (clsQxPrjSite4DownLoadBL.relatedActions != null)
{
clsQxPrjSite4DownLoadBL.relatedActions.UpdRelaTabDate(objQxPrjSite4DownLoadEN.PrjSiteId, objQxPrjSite4DownLoadEN.UpdUserId);
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
 /// <param name = "objQxPrjSite4DownLoadEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN)
{
 if (string.IsNullOrEmpty(objQxPrjSite4DownLoadEN.PrjSiteId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = QxPrjSite4DownLoadDA.UpdateBySql2(objQxPrjSite4DownLoadEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjSite4DownLoadBL.ReFreshCache();

if (clsQxPrjSite4DownLoadBL.relatedActions != null)
{
clsQxPrjSite4DownLoadBL.relatedActions.UpdRelaTabDate(objQxPrjSite4DownLoadEN.PrjSiteId, objQxPrjSite4DownLoadEN.UpdUserId);
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
 /// <param name = "strQxPrjSite4DownLoadObjXml">需要修改的对象,用XML来表示</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql_XML(string strQxPrjSite4DownLoadObjXml)
{
clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN = GetObjFromXmlStr(strQxPrjSite4DownLoadObjXml);
try
{
bool bolResult = QxPrjSite4DownLoadDA.UpdateBySql2(objQxPrjSite4DownLoadEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjSite4DownLoadBL.ReFreshCache();

if (clsQxPrjSite4DownLoadBL.relatedActions != null)
{
clsQxPrjSite4DownLoadBL.relatedActions.UpdRelaTabDate(objQxPrjSite4DownLoadEN.PrjSiteId, objQxPrjSite4DownLoadEN.UpdUserId);
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
 /// <param name = "strPrjSiteId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strPrjSiteId)
{
try
{
 clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN = clsQxPrjSite4DownLoadBL.GetObjByPrjSiteId(strPrjSiteId);

if (clsQxPrjSite4DownLoadBL.relatedActions != null)
{
clsQxPrjSite4DownLoadBL.relatedActions.UpdRelaTabDate(objQxPrjSite4DownLoadEN.PrjSiteId, objQxPrjSite4DownLoadEN.UpdUserId);
}
if (objQxPrjSite4DownLoadEN != null)
{
int intRecNum = QxPrjSite4DownLoadDA.DelRecord(strPrjSiteId);
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
/// <param name="strPrjSiteId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strPrjSiteId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
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
//删除与表:[QxPrjSite4DownLoad]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conQxPrjSite4DownLoad.PrjSiteId,
//strPrjSiteId);
//        clsQxPrjSite4DownLoadBL.DelQxPrjSite4DownLoadsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxPrjSite4DownLoadBL.DelRecord(strPrjSiteId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxPrjSite4DownLoadBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strPrjSiteId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strPrjSiteId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strPrjSiteId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsQxPrjSite4DownLoadBL.relatedActions != null)
{
clsQxPrjSite4DownLoadBL.relatedActions.UpdRelaTabDate(strPrjSiteId, "UpdRelaTabDate");
}
bool bolResult = QxPrjSite4DownLoadDA.DelRecord(strPrjSiteId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "strPrjSiteId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strPrjSiteId) 
{
try
{
if (clsQxPrjSite4DownLoadBL.relatedActions != null)
{
clsQxPrjSite4DownLoadBL.relatedActions.UpdRelaTabDate(strPrjSiteId, "UpdRelaTabDate");
}
bool bolResult = QxPrjSite4DownLoadDA.DelRecordBySP(strPrjSiteId);
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
 /// <param name = "arrPrjSiteIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelQxPrjSite4DownLoads(List<string> arrPrjSiteIdLst)
{
if (arrPrjSiteIdLst.Count == 0) return 0;
try
{
if (clsQxPrjSite4DownLoadBL.relatedActions != null)
{
foreach (var strPrjSiteId in arrPrjSiteIdLst)
{
clsQxPrjSite4DownLoadBL.relatedActions.UpdRelaTabDate(strPrjSiteId, "UpdRelaTabDate");
}
}
int intDelRecNum = QxPrjSite4DownLoadDA.DelQxPrjSite4DownLoad(arrPrjSiteIdLst);
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
public static int DelQxPrjSite4DownLoadsByCond(string strWhereCond)
{
try
{
if (clsQxPrjSite4DownLoadBL.relatedActions != null)
{
List<string> arrPrjSiteId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strPrjSiteId in arrPrjSiteId)
{
clsQxPrjSite4DownLoadBL.relatedActions.UpdRelaTabDate(strPrjSiteId, "UpdRelaTabDate");
}
}
int intRecNum = QxPrjSite4DownLoadDA.DelQxPrjSite4DownLoad(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[QxPrjSite4DownLoad]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strPrjSiteId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strPrjSiteId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxPrjSite4DownLoadDA.GetSpecSQLObj();
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
//删除与表:[QxPrjSite4DownLoad]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxPrjSite4DownLoadBL.DelRecord(strPrjSiteId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxPrjSite4DownLoadBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strPrjSiteId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objQxPrjSite4DownLoadENS">源对象</param>
 /// <param name = "objQxPrjSite4DownLoadENT">目标对象</param>
 public static void CopyTo(clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadENS, clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadENT)
{
try
{
objQxPrjSite4DownLoadENT.PrjSiteId = objQxPrjSite4DownLoadENS.PrjSiteId; //工程站点Id
objQxPrjSite4DownLoadENT.PrjSiteName = objQxPrjSite4DownLoadENS.PrjSiteName; //工程站点名
objQxPrjSite4DownLoadENT.QxPrjId = objQxPrjSite4DownLoadENS.QxPrjId; //项目Id
objQxPrjSite4DownLoadENT.FtpServer = objQxPrjSite4DownLoadENS.FtpServer; //Ftp服务器
objQxPrjSite4DownLoadENT.FtpUserId = objQxPrjSite4DownLoadENS.FtpUserId; //Ftp用户Id
objQxPrjSite4DownLoadENT.FtpUserPassword = objQxPrjSite4DownLoadENS.FtpUserPassword; //Ftp用户口令
objQxPrjSite4DownLoadENT.UpdDate = objQxPrjSite4DownLoadENS.UpdDate; //修改日期
objQxPrjSite4DownLoadENT.UpdUserId = objQxPrjSite4DownLoadENS.UpdUserId; //修改用户Id
objQxPrjSite4DownLoadENT.Memo = objQxPrjSite4DownLoadENS.Memo; //备注
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
 /// <param name = "objQxPrjSite4DownLoadEN">源简化对象</param>
 public static void SetUpdFlag(clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN)
{
try
{
objQxPrjSite4DownLoadEN.ClearUpdateState();
   string strsfUpdFldSetStr = objQxPrjSite4DownLoadEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conQxPrjSite4DownLoad.PrjSiteId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjSite4DownLoadEN.PrjSiteId = objQxPrjSite4DownLoadEN.PrjSiteId; //工程站点Id
}
if (arrFldSet.Contains(conQxPrjSite4DownLoad.PrjSiteName, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjSite4DownLoadEN.PrjSiteName = objQxPrjSite4DownLoadEN.PrjSiteName; //工程站点名
}
if (arrFldSet.Contains(conQxPrjSite4DownLoad.QxPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjSite4DownLoadEN.QxPrjId = objQxPrjSite4DownLoadEN.QxPrjId; //项目Id
}
if (arrFldSet.Contains(conQxPrjSite4DownLoad.FtpServer, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjSite4DownLoadEN.FtpServer = objQxPrjSite4DownLoadEN.FtpServer; //Ftp服务器
}
if (arrFldSet.Contains(conQxPrjSite4DownLoad.FtpUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjSite4DownLoadEN.FtpUserId = objQxPrjSite4DownLoadEN.FtpUserId; //Ftp用户Id
}
if (arrFldSet.Contains(conQxPrjSite4DownLoad.FtpUserPassword, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjSite4DownLoadEN.FtpUserPassword = objQxPrjSite4DownLoadEN.FtpUserPassword; //Ftp用户口令
}
if (arrFldSet.Contains(conQxPrjSite4DownLoad.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjSite4DownLoadEN.UpdDate = objQxPrjSite4DownLoadEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conQxPrjSite4DownLoad.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjSite4DownLoadEN.UpdUserId = objQxPrjSite4DownLoadEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conQxPrjSite4DownLoad.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjSite4DownLoadEN.Memo = objQxPrjSite4DownLoadEN.Memo == "[null]" ? null :  objQxPrjSite4DownLoadEN.Memo; //备注
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
 /// <param name = "objQxPrjSite4DownLoadEN">源简化对象</param>
 public static void AccessFldValueNull(clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN)
{
try
{
if (objQxPrjSite4DownLoadEN.Memo == "[null]") objQxPrjSite4DownLoadEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN)
{
 QxPrjSite4DownLoadDA.CheckPropertyNew(objQxPrjSite4DownLoadEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN)
{
 QxPrjSite4DownLoadDA.CheckProperty4Condition(objQxPrjSite4DownLoadEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_PrjSiteId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conQxPrjSite4DownLoad.PrjSiteId); 
List<clsQxPrjSite4DownLoadEN> arrObjLst = clsQxPrjSite4DownLoadBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN = new clsQxPrjSite4DownLoadEN()
{
PrjSiteId = "0",
PrjSiteName = "选[文件下载站点]..."
};
arrObjLst.Insert(0, objQxPrjSite4DownLoadEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conQxPrjSite4DownLoad.PrjSiteId;
objComboBox.DisplayMember = conQxPrjSite4DownLoad.PrjSiteName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_PrjSiteId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[文件下载站点]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conQxPrjSite4DownLoad.PrjSiteId); 
IEnumerable<clsQxPrjSite4DownLoadEN> arrObjLst = clsQxPrjSite4DownLoadBL.GetObjLst(strCondition);
objDDL.DataValueField = conQxPrjSite4DownLoad.PrjSiteId;
objDDL.DataTextField = conQxPrjSite4DownLoad.PrjSiteName;
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
public static void BindDdl_PrjSiteIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[文件下载站点]...","0");
List<clsQxPrjSite4DownLoadEN> arrQxPrjSite4DownLoadObjLst = GetAllQxPrjSite4DownLoadObjLstCache(); 
objDDL.DataValueField = conQxPrjSite4DownLoad.PrjSiteId;
objDDL.DataTextField = conQxPrjSite4DownLoad.PrjSiteName;
objDDL.DataSource = arrQxPrjSite4DownLoadObjLst;
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
if (clsQxPrjSite4DownLoadBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxPrjSite4DownLoadBL没有刷新缓存机制(clsQxPrjSite4DownLoadBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PrjSiteId");
//if (arrQxPrjSite4DownLoadObjLstCache == null)
//{
//arrQxPrjSite4DownLoadObjLstCache = QxPrjSite4DownLoadDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strPrjSiteId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxPrjSite4DownLoadEN GetObjByPrjSiteIdCache(string strPrjSiteId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsQxPrjSite4DownLoadEN._CurrTabName);
List<clsQxPrjSite4DownLoadEN> arrQxPrjSite4DownLoadObjLstCache = GetObjLstCache();
IEnumerable <clsQxPrjSite4DownLoadEN> arrQxPrjSite4DownLoadObjLst_Sel =
arrQxPrjSite4DownLoadObjLstCache
.Where(x=> x.PrjSiteId == strPrjSiteId 
);
if (arrQxPrjSite4DownLoadObjLst_Sel.Count() == 0)
{
   clsQxPrjSite4DownLoadEN obj = clsQxPrjSite4DownLoadBL.GetObjByPrjSiteId(strPrjSiteId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrQxPrjSite4DownLoadObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strPrjSiteId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetPrjSiteNameByPrjSiteIdCache(string strPrjSiteId)
{
if (string.IsNullOrEmpty(strPrjSiteId) == true) return "";
//获取缓存中的对象列表
clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoad = GetObjByPrjSiteIdCache(strPrjSiteId);
if (objQxPrjSite4DownLoad == null) return "";
return objQxPrjSite4DownLoad.PrjSiteName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strPrjSiteId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByPrjSiteIdCache(string strPrjSiteId)
{
if (string.IsNullOrEmpty(strPrjSiteId) == true) return "";
//获取缓存中的对象列表
clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoad = GetObjByPrjSiteIdCache(strPrjSiteId);
if (objQxPrjSite4DownLoad == null) return "";
return objQxPrjSite4DownLoad.PrjSiteName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxPrjSite4DownLoadEN> GetAllQxPrjSite4DownLoadObjLstCache()
{
//获取缓存中的对象列表
List<clsQxPrjSite4DownLoadEN> arrQxPrjSite4DownLoadObjLstCache = GetObjLstCache(); 
return arrQxPrjSite4DownLoadObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxPrjSite4DownLoadEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsQxPrjSite4DownLoadEN._CurrTabName);
List<clsQxPrjSite4DownLoadEN> arrQxPrjSite4DownLoadObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrQxPrjSite4DownLoadObjLstCache;
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
string strKey = string.Format("{0}", clsQxPrjSite4DownLoadEN._CurrTabName);
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
if (clsQxPrjSite4DownLoadBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsQxPrjSite4DownLoadEN._CurrTabName);
CacheHelper.Remove(strKey);
clsQxPrjSite4DownLoadBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--QxPrjSite4DownLoad(文件下载站点)
 /// 唯一性条件:PrjSiteName_QxPrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQxPrjSite4DownLoadEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN)
{
//检测记录是否存在
string strResult = QxPrjSite4DownLoadDA.GetUniCondStr(objQxPrjSite4DownLoadEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstQxPrjSite4DownLoadObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsQxPrjSite4DownLoadEN> lstQxPrjSite4DownLoadObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstQxPrjSite4DownLoadObjLst, writer);
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
 /// <param name = "lstQxPrjSite4DownLoadObjLst">[clsQxPrjSite4DownLoadEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsQxPrjSite4DownLoadEN> lstQxPrjSite4DownLoadObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsQxPrjSite4DownLoadBL.listXmlNode);
writer.WriteStartElement(clsQxPrjSite4DownLoadBL.itemsXmlNode);
foreach (clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN in lstQxPrjSite4DownLoadObjLst)
{
clsQxPrjSite4DownLoadBL.SerializeXML(writer, objQxPrjSite4DownLoadEN);
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
 /// <param name = "objQxPrjSite4DownLoadEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN)
{
writer.WriteStartElement(clsQxPrjSite4DownLoadBL.itemXmlNode);
 
if (objQxPrjSite4DownLoadEN.PrjSiteId != null)
{
writer.WriteElementString(conQxPrjSite4DownLoad.PrjSiteId, objQxPrjSite4DownLoadEN.PrjSiteId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjSite4DownLoadEN.PrjSiteName != null)
{
writer.WriteElementString(conQxPrjSite4DownLoad.PrjSiteName, objQxPrjSite4DownLoadEN.PrjSiteName.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjSite4DownLoadEN.QxPrjId != null)
{
writer.WriteElementString(conQxPrjSite4DownLoad.QxPrjId, objQxPrjSite4DownLoadEN.QxPrjId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjSite4DownLoadEN.FtpServer != null)
{
writer.WriteElementString(conQxPrjSite4DownLoad.FtpServer, objQxPrjSite4DownLoadEN.FtpServer.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjSite4DownLoadEN.FtpUserId != null)
{
writer.WriteElementString(conQxPrjSite4DownLoad.FtpUserId, objQxPrjSite4DownLoadEN.FtpUserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjSite4DownLoadEN.FtpUserPassword != null)
{
writer.WriteElementString(conQxPrjSite4DownLoad.FtpUserPassword, objQxPrjSite4DownLoadEN.FtpUserPassword.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjSite4DownLoadEN.UpdDate != null)
{
writer.WriteElementString(conQxPrjSite4DownLoad.UpdDate, objQxPrjSite4DownLoadEN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjSite4DownLoadEN.UpdUserId != null)
{
writer.WriteElementString(conQxPrjSite4DownLoad.UpdUserId, objQxPrjSite4DownLoadEN.UpdUserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjSite4DownLoadEN.Memo != null)
{
writer.WriteElementString(conQxPrjSite4DownLoad.Memo, objQxPrjSite4DownLoadEN.Memo.ToString(CultureInfo.InvariantCulture));
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
public static clsQxPrjSite4DownLoadEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN = new clsQxPrjSite4DownLoadEN();
reader.Read();
while (!(reader.Name == clsQxPrjSite4DownLoadBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(conQxPrjSite4DownLoad.PrjSiteId))
{
objQxPrjSite4DownLoadEN.PrjSiteId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjSite4DownLoad.PrjSiteName))
{
objQxPrjSite4DownLoadEN.PrjSiteName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjSite4DownLoad.QxPrjId))
{
objQxPrjSite4DownLoadEN.QxPrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjSite4DownLoad.FtpServer))
{
objQxPrjSite4DownLoadEN.FtpServer = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjSite4DownLoad.FtpUserId))
{
objQxPrjSite4DownLoadEN.FtpUserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjSite4DownLoad.FtpUserPassword))
{
objQxPrjSite4DownLoadEN.FtpUserPassword = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjSite4DownLoad.UpdDate))
{
objQxPrjSite4DownLoadEN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjSite4DownLoad.UpdUserId))
{
objQxPrjSite4DownLoadEN.UpdUserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjSite4DownLoad.Memo))
{
objQxPrjSite4DownLoadEN.Memo = reader.ReadElementContentAsString();
}
}
return objQxPrjSite4DownLoadEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strQxPrjSite4DownLoadObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsQxPrjSite4DownLoadEN GetObjFromXmlStr(string strQxPrjSite4DownLoadObjXmlStr)
{
clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN = new clsQxPrjSite4DownLoadEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strQxPrjSite4DownLoadObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsQxPrjSite4DownLoadBL.itemXmlNode))
{
objQxPrjSite4DownLoadEN = GetObjFromXml(reader);
return objQxPrjSite4DownLoadEN;
}
}
return objQxPrjSite4DownLoadEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objQxPrjSite4DownLoadEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objQxPrjSite4DownLoadEN);
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
if (strInFldName != conQxPrjSite4DownLoad.PrjSiteId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conQxPrjSite4DownLoad.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conQxPrjSite4DownLoad.AttributeName));
throw new Exception(strMsg);
}
var objQxPrjSite4DownLoad = clsQxPrjSite4DownLoadBL.GetObjByPrjSiteIdCache(strPrjSiteId);
if (objQxPrjSite4DownLoad == null) return "";
return objQxPrjSite4DownLoad[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objQxPrjSite4DownLoadEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsQxPrjSite4DownLoadEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objQxPrjSite4DownLoadEN[strField]);
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
 /// <param name = "lstQxPrjSite4DownLoadObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsQxPrjSite4DownLoadEN> lstQxPrjSite4DownLoadObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstQxPrjSite4DownLoadObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN in lstQxPrjSite4DownLoadObjLst)
{
string strJSON_One = SerializeObjToJSON(objQxPrjSite4DownLoadEN);
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
int intRecCount = clsQxPrjSite4DownLoadDA.GetRecCount(strTabName);
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
int intRecCount = clsQxPrjSite4DownLoadDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsQxPrjSite4DownLoadDA.GetRecCount();
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
int intRecCount = clsQxPrjSite4DownLoadDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objQxPrjSite4DownLoadCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadCond)
{
List<clsQxPrjSite4DownLoadEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxPrjSite4DownLoadEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxPrjSite4DownLoad.AttributeName)
{
if (objQxPrjSite4DownLoadCond.IsUpdated(strFldName) == false) continue;
if (objQxPrjSite4DownLoadCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxPrjSite4DownLoadCond[strFldName].ToString());
}
else
{
if (objQxPrjSite4DownLoadCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxPrjSite4DownLoadCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxPrjSite4DownLoadCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxPrjSite4DownLoadCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxPrjSite4DownLoadCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxPrjSite4DownLoadCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxPrjSite4DownLoadCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxPrjSite4DownLoadCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxPrjSite4DownLoadCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxPrjSite4DownLoadCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxPrjSite4DownLoadCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxPrjSite4DownLoadCond[strFldName]));
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
 List<string> arrList = clsQxPrjSite4DownLoadDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = QxPrjSite4DownLoadDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = QxPrjSite4DownLoadDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = QxPrjSite4DownLoadDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxPrjSite4DownLoadDA.SetFldValue(clsQxPrjSite4DownLoadEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = QxPrjSite4DownLoadDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxPrjSite4DownLoadDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxPrjSite4DownLoadDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxPrjSite4DownLoadDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[QxPrjSite4DownLoad] "); 
 strCreateTabCode.Append(" ( "); 
 // /**工程站点Id*/ 
 strCreateTabCode.Append(" PrjSiteId char(6) primary key, "); 
 // /**工程站点名*/ 
 strCreateTabCode.Append(" PrjSiteName varchar(50) not Null, "); 
 // /**项目Id*/ 
 strCreateTabCode.Append(" QxPrjId char(4) not Null, "); 
 // /**Ftp服务器*/ 
 strCreateTabCode.Append(" FtpServer varchar(50) not Null, "); 
 // /**Ftp用户Id*/ 
 strCreateTabCode.Append(" FtpUserId varchar(20) not Null, "); 
 // /**Ftp用户口令*/ 
 strCreateTabCode.Append(" FtpUserPassword varchar(50) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) not Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) not Null, "); 
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
 /// 文件下载站点(QxPrjSite4DownLoad)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4QxPrjSite4DownLoad : clsCommFun4BL
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
clsQxPrjSite4DownLoadBL.ReFreshThisCache();
}
}

}