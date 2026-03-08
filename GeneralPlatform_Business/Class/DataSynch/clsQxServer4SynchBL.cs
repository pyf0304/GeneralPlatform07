
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxServer4SynchBL
 表名:QxServer4Synch(00140091)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:08:55
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
public static class  clsQxServer4SynchBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strServerId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxServer4SynchEN GetObj(this K_ServerId_QxServer4Synch myKey)
{
clsQxServer4SynchEN objQxServer4SynchEN = clsQxServer4SynchBL.QxServer4SynchDA.GetObjByServerId(myKey.Value);
return objQxServer4SynchEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQxServer4SynchEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQxServer4SynchEN objQxServer4SynchEN)
{
if (CheckUniqueness(objQxServer4SynchEN) == false)
{
var strMsg = string.Format("记录已经存在!服务器名 = [{0}]的数据已经存在!(in clsQxServer4SynchBL.AddNewRecord)", objQxServer4SynchEN.ServerName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQxServer4SynchEN.ServerId) == true || clsQxServer4SynchBL.IsExist(objQxServer4SynchEN.ServerId) == true)
 {
     objQxServer4SynchEN.ServerId = clsQxServer4SynchBL.GetMaxStrId_S();
 }
bool bolResult = clsQxServer4SynchBL.QxServer4SynchDA.AddNewRecordBySQL2(objQxServer4SynchEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxServer4SynchBL.ReFreshCache();

if (clsQxServer4SynchBL.relatedActions != null)
{
clsQxServer4SynchBL.relatedActions.UpdRelaTabDate(objQxServer4SynchEN.ServerId, objQxServer4SynchEN.UpdUser);
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
public static bool AddRecordEx(this clsQxServer4SynchEN objQxServer4SynchEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsQxServer4SynchBL.IsExist(objQxServer4SynchEN.ServerId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objQxServer4SynchEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objQxServer4SynchEN.CheckUniqueness() == false)
{
strMsg = string.Format("(服务器名(ServerName)=[{0}])已经存在,不能重复!", objQxServer4SynchEN.ServerName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objQxServer4SynchEN.ServerId) == true || clsQxServer4SynchBL.IsExist(objQxServer4SynchEN.ServerId) == true)
 {
     objQxServer4SynchEN.ServerId = clsQxServer4SynchBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objQxServer4SynchEN.AddNewRecord();
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
 /// <param name = "objQxServer4SynchEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsQxServer4SynchEN objQxServer4SynchEN)
{
if (CheckUniqueness(objQxServer4SynchEN) == false)
{
var strMsg = string.Format("记录已经存在!服务器名 = [{0}]的数据已经存在!(in clsQxServer4SynchBL.AddNewRecordWithMaxId)", objQxServer4SynchEN.ServerName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQxServer4SynchEN.ServerId) == true || clsQxServer4SynchBL.IsExist(objQxServer4SynchEN.ServerId) == true)
 {
     objQxServer4SynchEN.ServerId = clsQxServer4SynchBL.GetMaxStrId_S();
 }
string strServerId = clsQxServer4SynchBL.QxServer4SynchDA.AddNewRecordBySQL2WithReturnKey(objQxServer4SynchEN);
     objQxServer4SynchEN.ServerId = strServerId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxServer4SynchBL.ReFreshCache();

if (clsQxServer4SynchBL.relatedActions != null)
{
clsQxServer4SynchBL.relatedActions.UpdRelaTabDate(objQxServer4SynchEN.ServerId, objQxServer4SynchEN.UpdUser);
}
return strServerId;
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
 /// <param name = "objQxServer4SynchEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsQxServer4SynchEN objQxServer4SynchEN)
{
if (CheckUniqueness(objQxServer4SynchEN) == false)
{
var strMsg = string.Format("记录已经存在!服务器名 = [{0}]的数据已经存在!(in clsQxServer4SynchBL.AddNewRecordWithReturnKey)", objQxServer4SynchEN.ServerName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQxServer4SynchEN.ServerId) == true || clsQxServer4SynchBL.IsExist(objQxServer4SynchEN.ServerId) == true)
 {
     objQxServer4SynchEN.ServerId = clsQxServer4SynchBL.GetMaxStrId_S();
 }
string strKey = clsQxServer4SynchBL.QxServer4SynchDA.AddNewRecordBySQL2WithReturnKey(objQxServer4SynchEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxServer4SynchBL.ReFreshCache();

if (clsQxServer4SynchBL.relatedActions != null)
{
clsQxServer4SynchBL.relatedActions.UpdRelaTabDate(objQxServer4SynchEN.ServerId, objQxServer4SynchEN.UpdUser);
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
 /// <param name = "objQxServer4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxServer4SynchEN SetServerId(this clsQxServer4SynchEN objQxServer4SynchEN, string strServerId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strServerId, 4, conQxServer4Synch.ServerId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strServerId, 4, conQxServer4Synch.ServerId);
}
objQxServer4SynchEN.ServerId = strServerId; //服务器Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxServer4SynchEN.dicFldComparisonOp.ContainsKey(conQxServer4Synch.ServerId) == false)
{
objQxServer4SynchEN.dicFldComparisonOp.Add(conQxServer4Synch.ServerId, strComparisonOp);
}
else
{
objQxServer4SynchEN.dicFldComparisonOp[conQxServer4Synch.ServerId] = strComparisonOp;
}
}
return objQxServer4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxServer4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxServer4SynchEN SetServerName(this clsQxServer4SynchEN objQxServer4SynchEN, string strServerName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strServerName, 50, conQxServer4Synch.ServerName);
}
objQxServer4SynchEN.ServerName = strServerName; //服务器名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxServer4SynchEN.dicFldComparisonOp.ContainsKey(conQxServer4Synch.ServerName) == false)
{
objQxServer4SynchEN.dicFldComparisonOp.Add(conQxServer4Synch.ServerName, strComparisonOp);
}
else
{
objQxServer4SynchEN.dicFldComparisonOp[conQxServer4Synch.ServerName] = strComparisonOp;
}
}
return objQxServer4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxServer4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxServer4SynchEN SetIpAddress(this clsQxServer4SynchEN objQxServer4SynchEN, string strIpAddress, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIpAddress, conQxServer4Synch.IpAddress);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIpAddress, 23, conQxServer4Synch.IpAddress);
}
objQxServer4SynchEN.IpAddress = strIpAddress; //IP地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxServer4SynchEN.dicFldComparisonOp.ContainsKey(conQxServer4Synch.IpAddress) == false)
{
objQxServer4SynchEN.dicFldComparisonOp.Add(conQxServer4Synch.IpAddress, strComparisonOp);
}
else
{
objQxServer4SynchEN.dicFldComparisonOp[conQxServer4Synch.IpAddress] = strComparisonOp;
}
}
return objQxServer4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxServer4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxServer4SynchEN SetWebApiAddress(this clsQxServer4SynchEN objQxServer4SynchEN, string strWebApiAddress, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWebApiAddress, conQxServer4Synch.WebApiAddress);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWebApiAddress, 50, conQxServer4Synch.WebApiAddress);
}
objQxServer4SynchEN.WebApiAddress = strWebApiAddress; //WApi地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxServer4SynchEN.dicFldComparisonOp.ContainsKey(conQxServer4Synch.WebApiAddress) == false)
{
objQxServer4SynchEN.dicFldComparisonOp.Add(conQxServer4Synch.WebApiAddress, strComparisonOp);
}
else
{
objQxServer4SynchEN.dicFldComparisonOp[conQxServer4Synch.WebApiAddress] = strComparisonOp;
}
}
return objQxServer4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxServer4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxServer4SynchEN SetIsSelf(this clsQxServer4SynchEN objQxServer4SynchEN, bool bolIsSelf, string strComparisonOp="")
	{
objQxServer4SynchEN.IsSelf = bolIsSelf; //是否当前服务器
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxServer4SynchEN.dicFldComparisonOp.ContainsKey(conQxServer4Synch.IsSelf) == false)
{
objQxServer4SynchEN.dicFldComparisonOp.Add(conQxServer4Synch.IsSelf, strComparisonOp);
}
else
{
objQxServer4SynchEN.dicFldComparisonOp[conQxServer4Synch.IsSelf] = strComparisonOp;
}
}
return objQxServer4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxServer4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxServer4SynchEN SetInUse(this clsQxServer4SynchEN objQxServer4SynchEN, bool bolInUse, string strComparisonOp="")
	{
objQxServer4SynchEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxServer4SynchEN.dicFldComparisonOp.ContainsKey(conQxServer4Synch.InUse) == false)
{
objQxServer4SynchEN.dicFldComparisonOp.Add(conQxServer4Synch.InUse, strComparisonOp);
}
else
{
objQxServer4SynchEN.dicFldComparisonOp[conQxServer4Synch.InUse] = strComparisonOp;
}
}
return objQxServer4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxServer4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxServer4SynchEN SetUpdDate(this clsQxServer4SynchEN objQxServer4SynchEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQxServer4Synch.UpdDate);
}
objQxServer4SynchEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxServer4SynchEN.dicFldComparisonOp.ContainsKey(conQxServer4Synch.UpdDate) == false)
{
objQxServer4SynchEN.dicFldComparisonOp.Add(conQxServer4Synch.UpdDate, strComparisonOp);
}
else
{
objQxServer4SynchEN.dicFldComparisonOp[conQxServer4Synch.UpdDate] = strComparisonOp;
}
}
return objQxServer4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxServer4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxServer4SynchEN SetUpdUser(this clsQxServer4SynchEN objQxServer4SynchEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 18, conQxServer4Synch.UpdUser);
}
objQxServer4SynchEN.UpdUser = strUpdUser; //修改用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxServer4SynchEN.dicFldComparisonOp.ContainsKey(conQxServer4Synch.UpdUser) == false)
{
objQxServer4SynchEN.dicFldComparisonOp.Add(conQxServer4Synch.UpdUser, strComparisonOp);
}
else
{
objQxServer4SynchEN.dicFldComparisonOp[conQxServer4Synch.UpdUser] = strComparisonOp;
}
}
return objQxServer4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxServer4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxServer4SynchEN SetMemo(this clsQxServer4SynchEN objQxServer4SynchEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQxServer4Synch.Memo);
}
objQxServer4SynchEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxServer4SynchEN.dicFldComparisonOp.ContainsKey(conQxServer4Synch.Memo) == false)
{
objQxServer4SynchEN.dicFldComparisonOp.Add(conQxServer4Synch.Memo, strComparisonOp);
}
else
{
objQxServer4SynchEN.dicFldComparisonOp[conQxServer4Synch.Memo] = strComparisonOp;
}
}
return objQxServer4SynchEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objQxServer4SynchEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsQxServer4SynchEN objQxServer4SynchEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objQxServer4SynchEN.CheckPropertyNew();
clsQxServer4SynchEN objQxServer4SynchCond = new clsQxServer4SynchEN();
string strCondition = objQxServer4SynchCond
.SetServerId(objQxServer4SynchEN.ServerId, "<>")
.SetServerName(objQxServer4SynchEN.ServerName, "=")
.GetCombineCondition();
objQxServer4SynchEN._IsCheckProperty = true;
bool bolIsExist = clsQxServer4SynchBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(ServerName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objQxServer4SynchEN.Update();
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
 /// <param name = "objQxServer4Synch">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsQxServer4SynchEN objQxServer4Synch)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsQxServer4SynchEN objQxServer4SynchCond = new clsQxServer4SynchEN();
string strCondition = objQxServer4SynchCond
.SetServerName(objQxServer4Synch.ServerName, "=")
.GetCombineCondition();
objQxServer4Synch._IsCheckProperty = true;
bool bolIsExist = clsQxServer4SynchBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objQxServer4Synch.ServerId = clsQxServer4SynchBL.GetFirstID_S(strCondition);
objQxServer4Synch.UpdateWithCondition(strCondition);
}
else
{
objQxServer4Synch.ServerId = clsQxServer4SynchBL.GetMaxStrId_S();
objQxServer4Synch.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objQxServer4SynchEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxServer4SynchEN objQxServer4SynchEN)
{
 if (string.IsNullOrEmpty(objQxServer4SynchEN.ServerId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxServer4SynchBL.QxServer4SynchDA.UpdateBySql2(objQxServer4SynchEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxServer4SynchBL.ReFreshCache();

if (clsQxServer4SynchBL.relatedActions != null)
{
clsQxServer4SynchBL.relatedActions.UpdRelaTabDate(objQxServer4SynchEN.ServerId, objQxServer4SynchEN.UpdUser);
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
 /// <param name = "objQxServer4SynchEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxServer4SynchEN objQxServer4SynchEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objQxServer4SynchEN.ServerId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxServer4SynchBL.QxServer4SynchDA.UpdateBySql2(objQxServer4SynchEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxServer4SynchBL.ReFreshCache();

if (clsQxServer4SynchBL.relatedActions != null)
{
clsQxServer4SynchBL.relatedActions.UpdRelaTabDate(objQxServer4SynchEN.ServerId, objQxServer4SynchEN.UpdUser);
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
 /// <param name = "objQxServer4SynchEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxServer4SynchEN objQxServer4SynchEN, string strWhereCond)
{
try
{
bool bolResult = clsQxServer4SynchBL.QxServer4SynchDA.UpdateBySqlWithCondition(objQxServer4SynchEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxServer4SynchBL.ReFreshCache();

if (clsQxServer4SynchBL.relatedActions != null)
{
clsQxServer4SynchBL.relatedActions.UpdRelaTabDate(objQxServer4SynchEN.ServerId, objQxServer4SynchEN.UpdUser);
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
 /// <param name = "objQxServer4SynchEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxServer4SynchEN objQxServer4SynchEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsQxServer4SynchBL.QxServer4SynchDA.UpdateBySqlWithConditionTransaction(objQxServer4SynchEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxServer4SynchBL.ReFreshCache();

if (clsQxServer4SynchBL.relatedActions != null)
{
clsQxServer4SynchBL.relatedActions.UpdRelaTabDate(objQxServer4SynchEN.ServerId, objQxServer4SynchEN.UpdUser);
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
 /// <param name = "strServerId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsQxServer4SynchEN objQxServer4SynchEN)
{
try
{
int intRecNum = clsQxServer4SynchBL.QxServer4SynchDA.DelRecord(objQxServer4SynchEN.ServerId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxServer4SynchBL.ReFreshCache();

if (clsQxServer4SynchBL.relatedActions != null)
{
clsQxServer4SynchBL.relatedActions.UpdRelaTabDate(objQxServer4SynchEN.ServerId, objQxServer4SynchEN.UpdUser);
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
 /// <param name = "objQxServer4SynchENS">源对象</param>
 /// <param name = "objQxServer4SynchENT">目标对象</param>
 public static void CopyTo(this clsQxServer4SynchEN objQxServer4SynchENS, clsQxServer4SynchEN objQxServer4SynchENT)
{
try
{
objQxServer4SynchENT.ServerId = objQxServer4SynchENS.ServerId; //服务器Id
objQxServer4SynchENT.ServerName = objQxServer4SynchENS.ServerName; //服务器名
objQxServer4SynchENT.IpAddress = objQxServer4SynchENS.IpAddress; //IP地址
objQxServer4SynchENT.WebApiAddress = objQxServer4SynchENS.WebApiAddress; //WApi地址
objQxServer4SynchENT.IsSelf = objQxServer4SynchENS.IsSelf; //是否当前服务器
objQxServer4SynchENT.InUse = objQxServer4SynchENS.InUse; //是否在用
objQxServer4SynchENT.UpdDate = objQxServer4SynchENS.UpdDate; //修改日期
objQxServer4SynchENT.UpdUser = objQxServer4SynchENS.UpdUser; //修改用户
objQxServer4SynchENT.Memo = objQxServer4SynchENS.Memo; //备注
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
 /// <param name = "objQxServer4SynchENS">源对象</param>
 /// <returns>目标对象=>clsQxServer4SynchEN:objQxServer4SynchENT</returns>
 public static clsQxServer4SynchEN CopyTo(this clsQxServer4SynchEN objQxServer4SynchENS)
{
try
{
 clsQxServer4SynchEN objQxServer4SynchENT = new clsQxServer4SynchEN()
{
ServerId = objQxServer4SynchENS.ServerId, //服务器Id
ServerName = objQxServer4SynchENS.ServerName, //服务器名
IpAddress = objQxServer4SynchENS.IpAddress, //IP地址
WebApiAddress = objQxServer4SynchENS.WebApiAddress, //WApi地址
IsSelf = objQxServer4SynchENS.IsSelf, //是否当前服务器
InUse = objQxServer4SynchENS.InUse, //是否在用
UpdDate = objQxServer4SynchENS.UpdDate, //修改日期
UpdUser = objQxServer4SynchENS.UpdUser, //修改用户
Memo = objQxServer4SynchENS.Memo, //备注
};
 return objQxServer4SynchENT;
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
public static void CheckPropertyNew(this clsQxServer4SynchEN objQxServer4SynchEN)
{
 clsQxServer4SynchBL.QxServer4SynchDA.CheckPropertyNew(objQxServer4SynchEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsQxServer4SynchEN objQxServer4SynchEN)
{
 clsQxServer4SynchBL.QxServer4SynchDA.CheckProperty4Condition(objQxServer4SynchEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQxServer4SynchEN objQxServer4SynchCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQxServer4SynchCond.IsUpdated(conQxServer4Synch.ServerId) == true)
{
string strComparisonOpServerId = objQxServer4SynchCond.dicFldComparisonOp[conQxServer4Synch.ServerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxServer4Synch.ServerId, objQxServer4SynchCond.ServerId, strComparisonOpServerId);
}
if (objQxServer4SynchCond.IsUpdated(conQxServer4Synch.ServerName) == true)
{
string strComparisonOpServerName = objQxServer4SynchCond.dicFldComparisonOp[conQxServer4Synch.ServerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxServer4Synch.ServerName, objQxServer4SynchCond.ServerName, strComparisonOpServerName);
}
if (objQxServer4SynchCond.IsUpdated(conQxServer4Synch.IpAddress) == true)
{
string strComparisonOpIpAddress = objQxServer4SynchCond.dicFldComparisonOp[conQxServer4Synch.IpAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxServer4Synch.IpAddress, objQxServer4SynchCond.IpAddress, strComparisonOpIpAddress);
}
if (objQxServer4SynchCond.IsUpdated(conQxServer4Synch.WebApiAddress) == true)
{
string strComparisonOpWebApiAddress = objQxServer4SynchCond.dicFldComparisonOp[conQxServer4Synch.WebApiAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxServer4Synch.WebApiAddress, objQxServer4SynchCond.WebApiAddress, strComparisonOpWebApiAddress);
}
if (objQxServer4SynchCond.IsUpdated(conQxServer4Synch.IsSelf) == true)
{
if (objQxServer4SynchCond.IsSelf == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQxServer4Synch.IsSelf);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQxServer4Synch.IsSelf);
}
}
if (objQxServer4SynchCond.IsUpdated(conQxServer4Synch.InUse) == true)
{
if (objQxServer4SynchCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQxServer4Synch.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQxServer4Synch.InUse);
}
}
if (objQxServer4SynchCond.IsUpdated(conQxServer4Synch.UpdDate) == true)
{
string strComparisonOpUpdDate = objQxServer4SynchCond.dicFldComparisonOp[conQxServer4Synch.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxServer4Synch.UpdDate, objQxServer4SynchCond.UpdDate, strComparisonOpUpdDate);
}
if (objQxServer4SynchCond.IsUpdated(conQxServer4Synch.UpdUser) == true)
{
string strComparisonOpUpdUser = objQxServer4SynchCond.dicFldComparisonOp[conQxServer4Synch.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxServer4Synch.UpdUser, objQxServer4SynchCond.UpdUser, strComparisonOpUpdUser);
}
if (objQxServer4SynchCond.IsUpdated(conQxServer4Synch.Memo) == true)
{
string strComparisonOpMemo = objQxServer4SynchCond.dicFldComparisonOp[conQxServer4Synch.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxServer4Synch.Memo, objQxServer4SynchCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--QxServer4Synch(同步服务器), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:ServerName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objQxServer4SynchEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsQxServer4SynchEN objQxServer4SynchEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objQxServer4SynchEN == null) return true;
if (objQxServer4SynchEN.ServerId == null || objQxServer4SynchEN.ServerId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objQxServer4SynchEN.ServerName == null)
{
 sbCondition.AppendFormat(" and ServerName is null", objQxServer4SynchEN.ServerName);
}
else
{
 sbCondition.AppendFormat(" and ServerName = '{0}'", objQxServer4SynchEN.ServerName);
}
if (clsQxServer4SynchBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("ServerId !=  '{0}'", objQxServer4SynchEN.ServerId);
 sbCondition.AppendFormat(" and ServerName = '{0}'", objQxServer4SynchEN.ServerName);
if (clsQxServer4SynchBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--QxServer4Synch(同步服务器), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ServerName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objQxServer4SynchEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsQxServer4SynchEN objQxServer4SynchEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objQxServer4SynchEN == null) return "";
if (objQxServer4SynchEN.ServerId == null || objQxServer4SynchEN.ServerId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objQxServer4SynchEN.ServerName == null)
{
 sbCondition.AppendFormat(" and ServerName is null", objQxServer4SynchEN.ServerName);
}
else
{
 sbCondition.AppendFormat(" and ServerName = '{0}'", objQxServer4SynchEN.ServerName);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ServerId !=  '{0}'", objQxServer4SynchEN.ServerId);
 sbCondition.AppendFormat(" and ServerName = '{0}'", objQxServer4SynchEN.ServerName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_QxServer4Synch
{
public virtual bool UpdRelaTabDate(string strServerId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 同步服务器(QxServer4Synch)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsQxServer4SynchBL
{
public static RelatedActions_QxServer4Synch relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "QxServer4SynchListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "QxServer4SynchList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsQxServer4SynchEN> arrQxServer4SynchObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsQxServer4SynchDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsQxServer4SynchDA QxServer4SynchDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsQxServer4SynchDA();
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
 public clsQxServer4SynchBL()
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
if (string.IsNullOrEmpty(clsQxServer4SynchEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxServer4SynchEN._ConnectString);
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
objDS = QxServer4SynchDA.GetDataSet(strWhereCond);
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
objDS = QxServer4SynchDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = QxServer4SynchDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_QxServer4Synch(string strWhereCond)
{
DataTable objDT;
try
{
objDT = QxServer4SynchDA.GetDataTable_QxServer4Synch(strWhereCond);
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
objDT = QxServer4SynchDA.GetDataTable(strWhereCond);
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
objDT = QxServer4SynchDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = QxServer4SynchDA.GetDataTable(strWhereCond, strTabName);
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
objDT = QxServer4SynchDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = QxServer4SynchDA.GetDataTable_Top(objTopPara);
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
objDT = QxServer4SynchDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = QxServer4SynchDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = QxServer4SynchDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = QxServer4SynchDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = QxServer4SynchDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = QxServer4SynchDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = QxServer4SynchDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = QxServer4SynchDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
 /// <param name = "arrServerIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsQxServer4SynchEN> GetObjLstByServerIdLst(List<string> arrServerIdLst)
{
List<clsQxServer4SynchEN> arrObjLst = new List<clsQxServer4SynchEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrServerIdLst, true);
 string strWhereCond = string.Format("ServerId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxServer4SynchEN objQxServer4SynchEN = new clsQxServer4SynchEN();
try
{
objQxServer4SynchEN.ServerId = objRow[conQxServer4Synch.ServerId].ToString().Trim(); //服务器Id
objQxServer4SynchEN.ServerName = objRow[conQxServer4Synch.ServerName] == DBNull.Value ? null : objRow[conQxServer4Synch.ServerName].ToString().Trim(); //服务器名
objQxServer4SynchEN.IpAddress = objRow[conQxServer4Synch.IpAddress].ToString().Trim(); //IP地址
objQxServer4SynchEN.WebApiAddress = objRow[conQxServer4Synch.WebApiAddress].ToString().Trim(); //WApi地址
objQxServer4SynchEN.IsSelf = clsEntityBase2.TransNullToBool_S(objRow[conQxServer4Synch.IsSelf].ToString().Trim()); //是否当前服务器
objQxServer4SynchEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxServer4Synch.InUse].ToString().Trim()); //是否在用
objQxServer4SynchEN.UpdDate = objRow[conQxServer4Synch.UpdDate] == DBNull.Value ? null : objRow[conQxServer4Synch.UpdDate].ToString().Trim(); //修改日期
objQxServer4SynchEN.UpdUser = objRow[conQxServer4Synch.UpdUser] == DBNull.Value ? null : objRow[conQxServer4Synch.UpdUser].ToString().Trim(); //修改用户
objQxServer4SynchEN.Memo = objRow[conQxServer4Synch.Memo] == DBNull.Value ? null : objRow[conQxServer4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxServer4SynchEN.ServerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxServer4SynchEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrServerIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsQxServer4SynchEN> GetObjLstByServerIdLstCache(List<string> arrServerIdLst)
{
string strKey = string.Format("{0}", clsQxServer4SynchEN._CurrTabName);
List<clsQxServer4SynchEN> arrQxServer4SynchObjLstCache = GetObjLstCache();
IEnumerable <clsQxServer4SynchEN> arrQxServer4SynchObjLst_Sel =
arrQxServer4SynchObjLstCache
.Where(x => arrServerIdLst.Contains(x.ServerId));
return arrQxServer4SynchObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxServer4SynchEN> GetObjLst(string strWhereCond)
{
List<clsQxServer4SynchEN> arrObjLst = new List<clsQxServer4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxServer4SynchEN objQxServer4SynchEN = new clsQxServer4SynchEN();
try
{
objQxServer4SynchEN.ServerId = objRow[conQxServer4Synch.ServerId].ToString().Trim(); //服务器Id
objQxServer4SynchEN.ServerName = objRow[conQxServer4Synch.ServerName] == DBNull.Value ? null : objRow[conQxServer4Synch.ServerName].ToString().Trim(); //服务器名
objQxServer4SynchEN.IpAddress = objRow[conQxServer4Synch.IpAddress].ToString().Trim(); //IP地址
objQxServer4SynchEN.WebApiAddress = objRow[conQxServer4Synch.WebApiAddress].ToString().Trim(); //WApi地址
objQxServer4SynchEN.IsSelf = clsEntityBase2.TransNullToBool_S(objRow[conQxServer4Synch.IsSelf].ToString().Trim()); //是否当前服务器
objQxServer4SynchEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxServer4Synch.InUse].ToString().Trim()); //是否在用
objQxServer4SynchEN.UpdDate = objRow[conQxServer4Synch.UpdDate] == DBNull.Value ? null : objRow[conQxServer4Synch.UpdDate].ToString().Trim(); //修改日期
objQxServer4SynchEN.UpdUser = objRow[conQxServer4Synch.UpdUser] == DBNull.Value ? null : objRow[conQxServer4Synch.UpdUser].ToString().Trim(); //修改用户
objQxServer4SynchEN.Memo = objRow[conQxServer4Synch.Memo] == DBNull.Value ? null : objRow[conQxServer4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxServer4SynchEN.ServerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxServer4SynchEN);
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
public static List<clsQxServer4SynchEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsQxServer4SynchEN> arrObjLst = new List<clsQxServer4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxServer4SynchEN objQxServer4SynchEN = new clsQxServer4SynchEN();
try
{
objQxServer4SynchEN.ServerId = objRow[conQxServer4Synch.ServerId].ToString().Trim(); //服务器Id
objQxServer4SynchEN.ServerName = objRow[conQxServer4Synch.ServerName] == DBNull.Value ? null : objRow[conQxServer4Synch.ServerName].ToString().Trim(); //服务器名
objQxServer4SynchEN.IpAddress = objRow[conQxServer4Synch.IpAddress].ToString().Trim(); //IP地址
objQxServer4SynchEN.WebApiAddress = objRow[conQxServer4Synch.WebApiAddress].ToString().Trim(); //WApi地址
objQxServer4SynchEN.IsSelf = clsEntityBase2.TransNullToBool_S(objRow[conQxServer4Synch.IsSelf].ToString().Trim()); //是否当前服务器
objQxServer4SynchEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxServer4Synch.InUse].ToString().Trim()); //是否在用
objQxServer4SynchEN.UpdDate = objRow[conQxServer4Synch.UpdDate] == DBNull.Value ? null : objRow[conQxServer4Synch.UpdDate].ToString().Trim(); //修改日期
objQxServer4SynchEN.UpdUser = objRow[conQxServer4Synch.UpdUser] == DBNull.Value ? null : objRow[conQxServer4Synch.UpdUser].ToString().Trim(); //修改用户
objQxServer4SynchEN.Memo = objRow[conQxServer4Synch.Memo] == DBNull.Value ? null : objRow[conQxServer4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxServer4SynchEN.ServerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxServer4SynchEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objQxServer4SynchCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsQxServer4SynchEN> GetSubObjLstCache(clsQxServer4SynchEN objQxServer4SynchCond)
{
List<clsQxServer4SynchEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxServer4SynchEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxServer4Synch.AttributeName)
{
if (objQxServer4SynchCond.IsUpdated(strFldName) == false) continue;
if (objQxServer4SynchCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxServer4SynchCond[strFldName].ToString());
}
else
{
if (objQxServer4SynchCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxServer4SynchCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxServer4SynchCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxServer4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxServer4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxServer4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxServer4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxServer4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxServer4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxServer4SynchCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxServer4SynchCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxServer4SynchCond[strFldName]));
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
public static List<clsQxServer4SynchEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsQxServer4SynchEN> arrObjLst = new List<clsQxServer4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxServer4SynchEN objQxServer4SynchEN = new clsQxServer4SynchEN();
try
{
objQxServer4SynchEN.ServerId = objRow[conQxServer4Synch.ServerId].ToString().Trim(); //服务器Id
objQxServer4SynchEN.ServerName = objRow[conQxServer4Synch.ServerName] == DBNull.Value ? null : objRow[conQxServer4Synch.ServerName].ToString().Trim(); //服务器名
objQxServer4SynchEN.IpAddress = objRow[conQxServer4Synch.IpAddress].ToString().Trim(); //IP地址
objQxServer4SynchEN.WebApiAddress = objRow[conQxServer4Synch.WebApiAddress].ToString().Trim(); //WApi地址
objQxServer4SynchEN.IsSelf = clsEntityBase2.TransNullToBool_S(objRow[conQxServer4Synch.IsSelf].ToString().Trim()); //是否当前服务器
objQxServer4SynchEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxServer4Synch.InUse].ToString().Trim()); //是否在用
objQxServer4SynchEN.UpdDate = objRow[conQxServer4Synch.UpdDate] == DBNull.Value ? null : objRow[conQxServer4Synch.UpdDate].ToString().Trim(); //修改日期
objQxServer4SynchEN.UpdUser = objRow[conQxServer4Synch.UpdUser] == DBNull.Value ? null : objRow[conQxServer4Synch.UpdUser].ToString().Trim(); //修改用户
objQxServer4SynchEN.Memo = objRow[conQxServer4Synch.Memo] == DBNull.Value ? null : objRow[conQxServer4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxServer4SynchEN.ServerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxServer4SynchEN);
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
public static List<clsQxServer4SynchEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsQxServer4SynchEN> arrObjLst = new List<clsQxServer4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxServer4SynchEN objQxServer4SynchEN = new clsQxServer4SynchEN();
try
{
objQxServer4SynchEN.ServerId = objRow[conQxServer4Synch.ServerId].ToString().Trim(); //服务器Id
objQxServer4SynchEN.ServerName = objRow[conQxServer4Synch.ServerName] == DBNull.Value ? null : objRow[conQxServer4Synch.ServerName].ToString().Trim(); //服务器名
objQxServer4SynchEN.IpAddress = objRow[conQxServer4Synch.IpAddress].ToString().Trim(); //IP地址
objQxServer4SynchEN.WebApiAddress = objRow[conQxServer4Synch.WebApiAddress].ToString().Trim(); //WApi地址
objQxServer4SynchEN.IsSelf = clsEntityBase2.TransNullToBool_S(objRow[conQxServer4Synch.IsSelf].ToString().Trim()); //是否当前服务器
objQxServer4SynchEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxServer4Synch.InUse].ToString().Trim()); //是否在用
objQxServer4SynchEN.UpdDate = objRow[conQxServer4Synch.UpdDate] == DBNull.Value ? null : objRow[conQxServer4Synch.UpdDate].ToString().Trim(); //修改日期
objQxServer4SynchEN.UpdUser = objRow[conQxServer4Synch.UpdUser] == DBNull.Value ? null : objRow[conQxServer4Synch.UpdUser].ToString().Trim(); //修改用户
objQxServer4SynchEN.Memo = objRow[conQxServer4Synch.Memo] == DBNull.Value ? null : objRow[conQxServer4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxServer4SynchEN.ServerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxServer4SynchEN);
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
List<clsQxServer4SynchEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsQxServer4SynchEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxServer4SynchEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsQxServer4SynchEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsQxServer4SynchEN> arrObjLst = new List<clsQxServer4SynchEN>(); 
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
	clsQxServer4SynchEN objQxServer4SynchEN = new clsQxServer4SynchEN();
try
{
objQxServer4SynchEN.ServerId = objRow[conQxServer4Synch.ServerId].ToString().Trim(); //服务器Id
objQxServer4SynchEN.ServerName = objRow[conQxServer4Synch.ServerName] == DBNull.Value ? null : objRow[conQxServer4Synch.ServerName].ToString().Trim(); //服务器名
objQxServer4SynchEN.IpAddress = objRow[conQxServer4Synch.IpAddress].ToString().Trim(); //IP地址
objQxServer4SynchEN.WebApiAddress = objRow[conQxServer4Synch.WebApiAddress].ToString().Trim(); //WApi地址
objQxServer4SynchEN.IsSelf = clsEntityBase2.TransNullToBool_S(objRow[conQxServer4Synch.IsSelf].ToString().Trim()); //是否当前服务器
objQxServer4SynchEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxServer4Synch.InUse].ToString().Trim()); //是否在用
objQxServer4SynchEN.UpdDate = objRow[conQxServer4Synch.UpdDate] == DBNull.Value ? null : objRow[conQxServer4Synch.UpdDate].ToString().Trim(); //修改日期
objQxServer4SynchEN.UpdUser = objRow[conQxServer4Synch.UpdUser] == DBNull.Value ? null : objRow[conQxServer4Synch.UpdUser].ToString().Trim(); //修改用户
objQxServer4SynchEN.Memo = objRow[conQxServer4Synch.Memo] == DBNull.Value ? null : objRow[conQxServer4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxServer4SynchEN.ServerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxServer4SynchEN);
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
public static List<clsQxServer4SynchEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsQxServer4SynchEN> arrObjLst = new List<clsQxServer4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxServer4SynchEN objQxServer4SynchEN = new clsQxServer4SynchEN();
try
{
objQxServer4SynchEN.ServerId = objRow[conQxServer4Synch.ServerId].ToString().Trim(); //服务器Id
objQxServer4SynchEN.ServerName = objRow[conQxServer4Synch.ServerName] == DBNull.Value ? null : objRow[conQxServer4Synch.ServerName].ToString().Trim(); //服务器名
objQxServer4SynchEN.IpAddress = objRow[conQxServer4Synch.IpAddress].ToString().Trim(); //IP地址
objQxServer4SynchEN.WebApiAddress = objRow[conQxServer4Synch.WebApiAddress].ToString().Trim(); //WApi地址
objQxServer4SynchEN.IsSelf = clsEntityBase2.TransNullToBool_S(objRow[conQxServer4Synch.IsSelf].ToString().Trim()); //是否当前服务器
objQxServer4SynchEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxServer4Synch.InUse].ToString().Trim()); //是否在用
objQxServer4SynchEN.UpdDate = objRow[conQxServer4Synch.UpdDate] == DBNull.Value ? null : objRow[conQxServer4Synch.UpdDate].ToString().Trim(); //修改日期
objQxServer4SynchEN.UpdUser = objRow[conQxServer4Synch.UpdUser] == DBNull.Value ? null : objRow[conQxServer4Synch.UpdUser].ToString().Trim(); //修改用户
objQxServer4SynchEN.Memo = objRow[conQxServer4Synch.Memo] == DBNull.Value ? null : objRow[conQxServer4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxServer4SynchEN.ServerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxServer4SynchEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsQxServer4SynchEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsQxServer4SynchEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsQxServer4SynchEN> arrObjLst = new List<clsQxServer4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxServer4SynchEN objQxServer4SynchEN = new clsQxServer4SynchEN();
try
{
objQxServer4SynchEN.ServerId = objRow[conQxServer4Synch.ServerId].ToString().Trim(); //服务器Id
objQxServer4SynchEN.ServerName = objRow[conQxServer4Synch.ServerName] == DBNull.Value ? null : objRow[conQxServer4Synch.ServerName].ToString().Trim(); //服务器名
objQxServer4SynchEN.IpAddress = objRow[conQxServer4Synch.IpAddress].ToString().Trim(); //IP地址
objQxServer4SynchEN.WebApiAddress = objRow[conQxServer4Synch.WebApiAddress].ToString().Trim(); //WApi地址
objQxServer4SynchEN.IsSelf = clsEntityBase2.TransNullToBool_S(objRow[conQxServer4Synch.IsSelf].ToString().Trim()); //是否当前服务器
objQxServer4SynchEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxServer4Synch.InUse].ToString().Trim()); //是否在用
objQxServer4SynchEN.UpdDate = objRow[conQxServer4Synch.UpdDate] == DBNull.Value ? null : objRow[conQxServer4Synch.UpdDate].ToString().Trim(); //修改日期
objQxServer4SynchEN.UpdUser = objRow[conQxServer4Synch.UpdUser] == DBNull.Value ? null : objRow[conQxServer4Synch.UpdUser].ToString().Trim(); //修改用户
objQxServer4SynchEN.Memo = objRow[conQxServer4Synch.Memo] == DBNull.Value ? null : objRow[conQxServer4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxServer4SynchEN.ServerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxServer4SynchEN);
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
public static List<clsQxServer4SynchEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsQxServer4SynchEN> arrObjLst = new List<clsQxServer4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxServer4SynchEN objQxServer4SynchEN = new clsQxServer4SynchEN();
try
{
objQxServer4SynchEN.ServerId = objRow[conQxServer4Synch.ServerId].ToString().Trim(); //服务器Id
objQxServer4SynchEN.ServerName = objRow[conQxServer4Synch.ServerName] == DBNull.Value ? null : objRow[conQxServer4Synch.ServerName].ToString().Trim(); //服务器名
objQxServer4SynchEN.IpAddress = objRow[conQxServer4Synch.IpAddress].ToString().Trim(); //IP地址
objQxServer4SynchEN.WebApiAddress = objRow[conQxServer4Synch.WebApiAddress].ToString().Trim(); //WApi地址
objQxServer4SynchEN.IsSelf = clsEntityBase2.TransNullToBool_S(objRow[conQxServer4Synch.IsSelf].ToString().Trim()); //是否当前服务器
objQxServer4SynchEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxServer4Synch.InUse].ToString().Trim()); //是否在用
objQxServer4SynchEN.UpdDate = objRow[conQxServer4Synch.UpdDate] == DBNull.Value ? null : objRow[conQxServer4Synch.UpdDate].ToString().Trim(); //修改日期
objQxServer4SynchEN.UpdUser = objRow[conQxServer4Synch.UpdUser] == DBNull.Value ? null : objRow[conQxServer4Synch.UpdUser].ToString().Trim(); //修改用户
objQxServer4SynchEN.Memo = objRow[conQxServer4Synch.Memo] == DBNull.Value ? null : objRow[conQxServer4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxServer4SynchEN.ServerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxServer4SynchEN);
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
public static IEnumerable<clsQxServer4SynchEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsQxServer4SynchEN objQxServer4SynchCond, string strOrderBy)
{
List<clsQxServer4SynchEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxServer4SynchEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxServer4Synch.AttributeName)
{
if (objQxServer4SynchCond.IsUpdated(strFldName) == false) continue;
if (objQxServer4SynchCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxServer4SynchCond[strFldName].ToString());
}
else
{
if (objQxServer4SynchCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxServer4SynchCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxServer4SynchCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxServer4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxServer4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxServer4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxServer4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxServer4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxServer4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxServer4SynchCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxServer4SynchCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxServer4SynchCond[strFldName]));
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
public static IEnumerable<clsQxServer4SynchEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsQxServer4SynchEN objQxServer4SynchCond = JsonConvert.DeserializeObject<clsQxServer4SynchEN>(objPagerPara.whereCond);
if (objQxServer4SynchCond.sfFldComparisonOp == null)
{
objQxServer4SynchCond.dicFldComparisonOp = null;
}
else
{
objQxServer4SynchCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objQxServer4SynchCond.sfFldComparisonOp);
}
clsQxServer4SynchBL.SetUpdFlag(objQxServer4SynchCond);
 try
{
CheckProperty4Condition(objQxServer4SynchCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsQxServer4SynchBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objQxServer4SynchCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxServer4SynchEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsQxServer4SynchEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsQxServer4SynchEN> arrObjLst = new List<clsQxServer4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxServer4SynchEN objQxServer4SynchEN = new clsQxServer4SynchEN();
try
{
objQxServer4SynchEN.ServerId = objRow[conQxServer4Synch.ServerId].ToString().Trim(); //服务器Id
objQxServer4SynchEN.ServerName = objRow[conQxServer4Synch.ServerName] == DBNull.Value ? null : objRow[conQxServer4Synch.ServerName].ToString().Trim(); //服务器名
objQxServer4SynchEN.IpAddress = objRow[conQxServer4Synch.IpAddress].ToString().Trim(); //IP地址
objQxServer4SynchEN.WebApiAddress = objRow[conQxServer4Synch.WebApiAddress].ToString().Trim(); //WApi地址
objQxServer4SynchEN.IsSelf = clsEntityBase2.TransNullToBool_S(objRow[conQxServer4Synch.IsSelf].ToString().Trim()); //是否当前服务器
objQxServer4SynchEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxServer4Synch.InUse].ToString().Trim()); //是否在用
objQxServer4SynchEN.UpdDate = objRow[conQxServer4Synch.UpdDate] == DBNull.Value ? null : objRow[conQxServer4Synch.UpdDate].ToString().Trim(); //修改日期
objQxServer4SynchEN.UpdUser = objRow[conQxServer4Synch.UpdUser] == DBNull.Value ? null : objRow[conQxServer4Synch.UpdUser].ToString().Trim(); //修改用户
objQxServer4SynchEN.Memo = objRow[conQxServer4Synch.Memo] == DBNull.Value ? null : objRow[conQxServer4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxServer4SynchEN.ServerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxServer4SynchEN);
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
public static List<clsQxServer4SynchEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsQxServer4SynchEN> arrObjLst = new List<clsQxServer4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxServer4SynchEN objQxServer4SynchEN = new clsQxServer4SynchEN();
try
{
objQxServer4SynchEN.ServerId = objRow[conQxServer4Synch.ServerId].ToString().Trim(); //服务器Id
objQxServer4SynchEN.ServerName = objRow[conQxServer4Synch.ServerName] == DBNull.Value ? null : objRow[conQxServer4Synch.ServerName].ToString().Trim(); //服务器名
objQxServer4SynchEN.IpAddress = objRow[conQxServer4Synch.IpAddress].ToString().Trim(); //IP地址
objQxServer4SynchEN.WebApiAddress = objRow[conQxServer4Synch.WebApiAddress].ToString().Trim(); //WApi地址
objQxServer4SynchEN.IsSelf = clsEntityBase2.TransNullToBool_S(objRow[conQxServer4Synch.IsSelf].ToString().Trim()); //是否当前服务器
objQxServer4SynchEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxServer4Synch.InUse].ToString().Trim()); //是否在用
objQxServer4SynchEN.UpdDate = objRow[conQxServer4Synch.UpdDate] == DBNull.Value ? null : objRow[conQxServer4Synch.UpdDate].ToString().Trim(); //修改日期
objQxServer4SynchEN.UpdUser = objRow[conQxServer4Synch.UpdUser] == DBNull.Value ? null : objRow[conQxServer4Synch.UpdUser].ToString().Trim(); //修改用户
objQxServer4SynchEN.Memo = objRow[conQxServer4Synch.Memo] == DBNull.Value ? null : objRow[conQxServer4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxServer4SynchEN.ServerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxServer4SynchEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxServer4SynchEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsQxServer4SynchEN> arrObjLst = new List<clsQxServer4SynchEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxServer4SynchEN objQxServer4SynchEN = new clsQxServer4SynchEN();
try
{
objQxServer4SynchEN.ServerId = objRow[conQxServer4Synch.ServerId].ToString().Trim(); //服务器Id
objQxServer4SynchEN.ServerName = objRow[conQxServer4Synch.ServerName] == DBNull.Value ? null : objRow[conQxServer4Synch.ServerName].ToString().Trim(); //服务器名
objQxServer4SynchEN.IpAddress = objRow[conQxServer4Synch.IpAddress].ToString().Trim(); //IP地址
objQxServer4SynchEN.WebApiAddress = objRow[conQxServer4Synch.WebApiAddress].ToString().Trim(); //WApi地址
objQxServer4SynchEN.IsSelf = clsEntityBase2.TransNullToBool_S(objRow[conQxServer4Synch.IsSelf].ToString().Trim()); //是否当前服务器
objQxServer4SynchEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxServer4Synch.InUse].ToString().Trim()); //是否在用
objQxServer4SynchEN.UpdDate = objRow[conQxServer4Synch.UpdDate] == DBNull.Value ? null : objRow[conQxServer4Synch.UpdDate].ToString().Trim(); //修改日期
objQxServer4SynchEN.UpdUser = objRow[conQxServer4Synch.UpdUser] == DBNull.Value ? null : objRow[conQxServer4Synch.UpdUser].ToString().Trim(); //修改用户
objQxServer4SynchEN.Memo = objRow[conQxServer4Synch.Memo] == DBNull.Value ? null : objRow[conQxServer4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxServer4SynchEN.ServerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxServer4SynchEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objQxServer4SynchEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxServer4Synch(ref clsQxServer4SynchEN objQxServer4SynchEN)
{
bool bolResult = QxServer4SynchDA.GetQxServer4Synch(ref objQxServer4SynchEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strServerId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxServer4SynchEN GetObjByServerId(string strServerId)
{
if (strServerId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strServerId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strServerId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strServerId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsQxServer4SynchEN objQxServer4SynchEN = QxServer4SynchDA.GetObjByServerId(strServerId);
return objQxServer4SynchEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsQxServer4SynchEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsQxServer4SynchEN objQxServer4SynchEN = QxServer4SynchDA.GetFirstObj(strWhereCond);
 return objQxServer4SynchEN;
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
public static clsQxServer4SynchEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsQxServer4SynchEN objQxServer4SynchEN = QxServer4SynchDA.GetObjByDataRow(objRow);
 return objQxServer4SynchEN;
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
public static clsQxServer4SynchEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsQxServer4SynchEN objQxServer4SynchEN = QxServer4SynchDA.GetObjByDataRow(objRow);
 return objQxServer4SynchEN;
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
 /// <param name = "strServerId">所给的关键字</param>
 /// <param name = "lstQxServer4SynchObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxServer4SynchEN GetObjByServerIdFromList(string strServerId, List<clsQxServer4SynchEN> lstQxServer4SynchObjLst)
{
foreach (clsQxServer4SynchEN objQxServer4SynchEN in lstQxServer4SynchObjLst)
{
if (objQxServer4SynchEN.ServerId == strServerId)
{
return objQxServer4SynchEN;
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
 string strMaxServerId;
 try
 {
 strMaxServerId = clsQxServer4SynchDA.GetMaxStrId();
 return strMaxServerId;
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
 string strServerId;
 try
 {
 strServerId = new clsQxServer4SynchDA().GetFirstID(strWhereCond);
 return strServerId;
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
 arrList = QxServer4SynchDA.GetID(strWhereCond);
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
bool bolIsExist = QxServer4SynchDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strServerId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strServerId)
{
if (string.IsNullOrEmpty(strServerId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strServerId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = QxServer4SynchDA.IsExist(strServerId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strServerId">服务器Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strServerId, string strOpUser)
{
clsQxServer4SynchEN objQxServer4SynchEN = clsQxServer4SynchBL.GetObjByServerId(strServerId);
objQxServer4SynchEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objQxServer4SynchEN.UpdUser = strOpUser;
return clsQxServer4SynchBL.UpdateBySql2(objQxServer4SynchEN);
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
 bolIsExist = clsQxServer4SynchDA.IsExistTable();
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
 bolIsExist = QxServer4SynchDA.IsExistTable(strTabName);
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
 /// <param name = "objQxServer4SynchEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsQxServer4SynchEN objQxServer4SynchEN)
{
if (objQxServer4SynchEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!服务器名 = [{0}]的数据已经存在!(in clsQxServer4SynchBL.AddNewRecordBySql2)", objQxServer4SynchEN.ServerName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQxServer4SynchEN.ServerId) == true || clsQxServer4SynchBL.IsExist(objQxServer4SynchEN.ServerId) == true)
 {
     objQxServer4SynchEN.ServerId = clsQxServer4SynchBL.GetMaxStrId_S();
 }
bool bolResult = QxServer4SynchDA.AddNewRecordBySQL2(objQxServer4SynchEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxServer4SynchBL.ReFreshCache();

if (clsQxServer4SynchBL.relatedActions != null)
{
clsQxServer4SynchBL.relatedActions.UpdRelaTabDate(objQxServer4SynchEN.ServerId, objQxServer4SynchEN.UpdUser);
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
 /// <param name = "objQxServer4SynchEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsQxServer4SynchEN objQxServer4SynchEN)
{
if (objQxServer4SynchEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!服务器名 = [{0}]的数据已经存在!(in clsQxServer4SynchBL.AddNewRecordBySql2WithReturnKey)", objQxServer4SynchEN.ServerName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQxServer4SynchEN.ServerId) == true || clsQxServer4SynchBL.IsExist(objQxServer4SynchEN.ServerId) == true)
 {
     objQxServer4SynchEN.ServerId = clsQxServer4SynchBL.GetMaxStrId_S();
 }
string strKey = QxServer4SynchDA.AddNewRecordBySQL2WithReturnKey(objQxServer4SynchEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxServer4SynchBL.ReFreshCache();

if (clsQxServer4SynchBL.relatedActions != null)
{
clsQxServer4SynchBL.relatedActions.UpdRelaTabDate(objQxServer4SynchEN.ServerId, objQxServer4SynchEN.UpdUser);
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
 /// <param name = "strQxServer4SynchObjXml">代表实体对象的XML串</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql_XML(string strQxServer4SynchObjXml)
{
clsQxServer4SynchEN objQxServer4SynchEN = GetObjFromXmlStr(strQxServer4SynchObjXml);
try
{
bool bolResult = QxServer4SynchDA.AddNewRecordBySQL2(objQxServer4SynchEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxServer4SynchBL.ReFreshCache();

if (clsQxServer4SynchBL.relatedActions != null)
{
clsQxServer4SynchBL.relatedActions.UpdRelaTabDate(objQxServer4SynchEN.ServerId, objQxServer4SynchEN.UpdUser);
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
 /// <param name = "objQxServer4SynchEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsQxServer4SynchEN objQxServer4SynchEN)
{
try
{
bool bolResult = QxServer4SynchDA.Update(objQxServer4SynchEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxServer4SynchBL.ReFreshCache();

if (clsQxServer4SynchBL.relatedActions != null)
{
clsQxServer4SynchBL.relatedActions.UpdRelaTabDate(objQxServer4SynchEN.ServerId, objQxServer4SynchEN.UpdUser);
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
 /// <param name = "objQxServer4SynchEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsQxServer4SynchEN objQxServer4SynchEN)
{
 if (string.IsNullOrEmpty(objQxServer4SynchEN.ServerId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = QxServer4SynchDA.UpdateBySql2(objQxServer4SynchEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxServer4SynchBL.ReFreshCache();

if (clsQxServer4SynchBL.relatedActions != null)
{
clsQxServer4SynchBL.relatedActions.UpdRelaTabDate(objQxServer4SynchEN.ServerId, objQxServer4SynchEN.UpdUser);
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
 /// <param name = "strQxServer4SynchObjXml">需要修改的对象,用XML来表示</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql_XML(string strQxServer4SynchObjXml)
{
clsQxServer4SynchEN objQxServer4SynchEN = GetObjFromXmlStr(strQxServer4SynchObjXml);
try
{
bool bolResult = QxServer4SynchDA.UpdateBySql2(objQxServer4SynchEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxServer4SynchBL.ReFreshCache();

if (clsQxServer4SynchBL.relatedActions != null)
{
clsQxServer4SynchBL.relatedActions.UpdRelaTabDate(objQxServer4SynchEN.ServerId, objQxServer4SynchEN.UpdUser);
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
 /// <param name = "strServerId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strServerId)
{
try
{
 clsQxServer4SynchEN objQxServer4SynchEN = clsQxServer4SynchBL.GetObjByServerId(strServerId);

if (clsQxServer4SynchBL.relatedActions != null)
{
clsQxServer4SynchBL.relatedActions.UpdRelaTabDate(objQxServer4SynchEN.ServerId, objQxServer4SynchEN.UpdUser);
}
if (objQxServer4SynchEN != null)
{
int intRecNum = QxServer4SynchDA.DelRecord(strServerId);
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
/// <param name="strServerId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strServerId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
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
//删除与表:[QxServer4Synch]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conQxServer4Synch.ServerId,
//strServerId);
//        clsQxServer4SynchBL.DelQxServer4SynchsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxServer4SynchBL.DelRecord(strServerId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxServer4SynchBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strServerId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strServerId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strServerId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsQxServer4SynchBL.relatedActions != null)
{
clsQxServer4SynchBL.relatedActions.UpdRelaTabDate(strServerId, "UpdRelaTabDate");
}
bool bolResult = QxServer4SynchDA.DelRecord(strServerId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "strServerId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strServerId) 
{
try
{
if (clsQxServer4SynchBL.relatedActions != null)
{
clsQxServer4SynchBL.relatedActions.UpdRelaTabDate(strServerId, "UpdRelaTabDate");
}
bool bolResult = QxServer4SynchDA.DelRecordBySP(strServerId);
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
 /// <param name = "arrServerIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelQxServer4Synchs(List<string> arrServerIdLst)
{
if (arrServerIdLst.Count == 0) return 0;
try
{
if (clsQxServer4SynchBL.relatedActions != null)
{
foreach (var strServerId in arrServerIdLst)
{
clsQxServer4SynchBL.relatedActions.UpdRelaTabDate(strServerId, "UpdRelaTabDate");
}
}
int intDelRecNum = QxServer4SynchDA.DelQxServer4Synch(arrServerIdLst);
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
public static int DelQxServer4SynchsByCond(string strWhereCond)
{
try
{
if (clsQxServer4SynchBL.relatedActions != null)
{
List<string> arrServerId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strServerId in arrServerId)
{
clsQxServer4SynchBL.relatedActions.UpdRelaTabDate(strServerId, "UpdRelaTabDate");
}
}
int intRecNum = QxServer4SynchDA.DelQxServer4Synch(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[QxServer4Synch]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strServerId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strServerId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxServer4SynchDA.GetSpecSQLObj();
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
//删除与表:[QxServer4Synch]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxServer4SynchBL.DelRecord(strServerId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxServer4SynchBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strServerId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objQxServer4SynchENS">源对象</param>
 /// <param name = "objQxServer4SynchENT">目标对象</param>
 public static void CopyTo(clsQxServer4SynchEN objQxServer4SynchENS, clsQxServer4SynchEN objQxServer4SynchENT)
{
try
{
objQxServer4SynchENT.ServerId = objQxServer4SynchENS.ServerId; //服务器Id
objQxServer4SynchENT.ServerName = objQxServer4SynchENS.ServerName; //服务器名
objQxServer4SynchENT.IpAddress = objQxServer4SynchENS.IpAddress; //IP地址
objQxServer4SynchENT.WebApiAddress = objQxServer4SynchENS.WebApiAddress; //WApi地址
objQxServer4SynchENT.IsSelf = objQxServer4SynchENS.IsSelf; //是否当前服务器
objQxServer4SynchENT.InUse = objQxServer4SynchENS.InUse; //是否在用
objQxServer4SynchENT.UpdDate = objQxServer4SynchENS.UpdDate; //修改日期
objQxServer4SynchENT.UpdUser = objQxServer4SynchENS.UpdUser; //修改用户
objQxServer4SynchENT.Memo = objQxServer4SynchENS.Memo; //备注
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
 /// <param name = "objQxServer4SynchEN">源简化对象</param>
 public static void SetUpdFlag(clsQxServer4SynchEN objQxServer4SynchEN)
{
try
{
objQxServer4SynchEN.ClearUpdateState();
   string strsfUpdFldSetStr = objQxServer4SynchEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conQxServer4Synch.ServerId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxServer4SynchEN.ServerId = objQxServer4SynchEN.ServerId; //服务器Id
}
if (arrFldSet.Contains(conQxServer4Synch.ServerName, new clsStrCompareIgnoreCase())  ==  true)
{
objQxServer4SynchEN.ServerName = objQxServer4SynchEN.ServerName == "[null]" ? null :  objQxServer4SynchEN.ServerName; //服务器名
}
if (arrFldSet.Contains(conQxServer4Synch.IpAddress, new clsStrCompareIgnoreCase())  ==  true)
{
objQxServer4SynchEN.IpAddress = objQxServer4SynchEN.IpAddress; //IP地址
}
if (arrFldSet.Contains(conQxServer4Synch.WebApiAddress, new clsStrCompareIgnoreCase())  ==  true)
{
objQxServer4SynchEN.WebApiAddress = objQxServer4SynchEN.WebApiAddress; //WApi地址
}
if (arrFldSet.Contains(conQxServer4Synch.IsSelf, new clsStrCompareIgnoreCase())  ==  true)
{
objQxServer4SynchEN.IsSelf = objQxServer4SynchEN.IsSelf; //是否当前服务器
}
if (arrFldSet.Contains(conQxServer4Synch.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objQxServer4SynchEN.InUse = objQxServer4SynchEN.InUse; //是否在用
}
if (arrFldSet.Contains(conQxServer4Synch.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objQxServer4SynchEN.UpdDate = objQxServer4SynchEN.UpdDate == "[null]" ? null :  objQxServer4SynchEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conQxServer4Synch.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objQxServer4SynchEN.UpdUser = objQxServer4SynchEN.UpdUser == "[null]" ? null :  objQxServer4SynchEN.UpdUser; //修改用户
}
if (arrFldSet.Contains(conQxServer4Synch.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objQxServer4SynchEN.Memo = objQxServer4SynchEN.Memo == "[null]" ? null :  objQxServer4SynchEN.Memo; //备注
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
 /// <param name = "objQxServer4SynchEN">源简化对象</param>
 public static void AccessFldValueNull(clsQxServer4SynchEN objQxServer4SynchEN)
{
try
{
if (objQxServer4SynchEN.ServerName == "[null]") objQxServer4SynchEN.ServerName = null; //服务器名
if (objQxServer4SynchEN.UpdDate == "[null]") objQxServer4SynchEN.UpdDate = null; //修改日期
if (objQxServer4SynchEN.UpdUser == "[null]") objQxServer4SynchEN.UpdUser = null; //修改用户
if (objQxServer4SynchEN.Memo == "[null]") objQxServer4SynchEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsQxServer4SynchEN objQxServer4SynchEN)
{
 QxServer4SynchDA.CheckPropertyNew(objQxServer4SynchEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsQxServer4SynchEN objQxServer4SynchEN)
{
 QxServer4SynchDA.CheckProperty4Condition(objQxServer4SynchEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_ServerId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conQxServer4Synch.ServerId); 
List<clsQxServer4SynchEN> arrObjLst = clsQxServer4SynchBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsQxServer4SynchEN objQxServer4SynchEN = new clsQxServer4SynchEN()
{
ServerId = "0",
ServerName = "选[同步服务器]..."
};
arrObjLst.Insert(0, objQxServer4SynchEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conQxServer4Synch.ServerId;
objComboBox.DisplayMember = conQxServer4Synch.ServerName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_ServerId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[同步服务器]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conQxServer4Synch.ServerId); 
IEnumerable<clsQxServer4SynchEN> arrObjLst = clsQxServer4SynchBL.GetObjLst(strCondition);
objDDL.DataValueField = conQxServer4Synch.ServerId;
objDDL.DataTextField = conQxServer4Synch.ServerName;
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
public static void BindDdl_ServerIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[同步服务器]...","0");
List<clsQxServer4SynchEN> arrQxServer4SynchObjLst = GetAllQxServer4SynchObjLstCache(); 
objDDL.DataValueField = conQxServer4Synch.ServerId;
objDDL.DataTextField = conQxServer4Synch.ServerName;
objDDL.DataSource = arrQxServer4SynchObjLst;
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
if (clsQxServer4SynchBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxServer4SynchBL没有刷新缓存机制(clsQxServer4SynchBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ServerId");
//if (arrQxServer4SynchObjLstCache == null)
//{
//arrQxServer4SynchObjLstCache = QxServer4SynchDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strServerId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxServer4SynchEN GetObjByServerIdCache(string strServerId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsQxServer4SynchEN._CurrTabName);
List<clsQxServer4SynchEN> arrQxServer4SynchObjLstCache = GetObjLstCache();
IEnumerable <clsQxServer4SynchEN> arrQxServer4SynchObjLst_Sel =
arrQxServer4SynchObjLstCache
.Where(x=> x.ServerId == strServerId 
);
if (arrQxServer4SynchObjLst_Sel.Count() == 0)
{
   clsQxServer4SynchEN obj = clsQxServer4SynchBL.GetObjByServerId(strServerId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrQxServer4SynchObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strServerId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetServerNameByServerIdCache(string strServerId)
{
if (string.IsNullOrEmpty(strServerId) == true) return "";
//获取缓存中的对象列表
clsQxServer4SynchEN objQxServer4Synch = GetObjByServerIdCache(strServerId);
if (objQxServer4Synch == null) return "";
return objQxServer4Synch.ServerName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strServerId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByServerIdCache(string strServerId)
{
if (string.IsNullOrEmpty(strServerId) == true) return "";
//获取缓存中的对象列表
clsQxServer4SynchEN objQxServer4Synch = GetObjByServerIdCache(strServerId);
if (objQxServer4Synch == null) return "";
return objQxServer4Synch.ServerName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxServer4SynchEN> GetAllQxServer4SynchObjLstCache()
{
//获取缓存中的对象列表
List<clsQxServer4SynchEN> arrQxServer4SynchObjLstCache = GetObjLstCache(); 
return arrQxServer4SynchObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxServer4SynchEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsQxServer4SynchEN._CurrTabName);
List<clsQxServer4SynchEN> arrQxServer4SynchObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrQxServer4SynchObjLstCache;
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
string strKey = string.Format("{0}", clsQxServer4SynchEN._CurrTabName);
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
if (clsQxServer4SynchBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsQxServer4SynchEN._CurrTabName);
CacheHelper.Remove(strKey);
clsQxServer4SynchBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--QxServer4Synch(同步服务器)
 /// 唯一性条件:ServerName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQxServer4SynchEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsQxServer4SynchEN objQxServer4SynchEN)
{
//检测记录是否存在
string strResult = QxServer4SynchDA.GetUniCondStr(objQxServer4SynchEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstQxServer4SynchObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsQxServer4SynchEN> lstQxServer4SynchObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstQxServer4SynchObjLst, writer);
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
 /// <param name = "lstQxServer4SynchObjLst">[clsQxServer4SynchEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsQxServer4SynchEN> lstQxServer4SynchObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsQxServer4SynchBL.listXmlNode);
writer.WriteStartElement(clsQxServer4SynchBL.itemsXmlNode);
foreach (clsQxServer4SynchEN objQxServer4SynchEN in lstQxServer4SynchObjLst)
{
clsQxServer4SynchBL.SerializeXML(writer, objQxServer4SynchEN);
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
 /// <param name = "objQxServer4SynchEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsQxServer4SynchEN objQxServer4SynchEN)
{
writer.WriteStartElement(clsQxServer4SynchBL.itemXmlNode);
 
if (objQxServer4SynchEN.ServerId != null)
{
writer.WriteElementString(conQxServer4Synch.ServerId, objQxServer4SynchEN.ServerId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxServer4SynchEN.ServerName != null)
{
writer.WriteElementString(conQxServer4Synch.ServerName, objQxServer4SynchEN.ServerName.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxServer4SynchEN.IpAddress != null)
{
writer.WriteElementString(conQxServer4Synch.IpAddress, objQxServer4SynchEN.IpAddress.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxServer4SynchEN.WebApiAddress != null)
{
writer.WriteElementString(conQxServer4Synch.WebApiAddress, objQxServer4SynchEN.WebApiAddress.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(conQxServer4Synch.IsSelf, objQxServer4SynchEN.IsSelf.ToString().ToLower(CultureInfo.InvariantCulture));
 
writer.WriteElementString(conQxServer4Synch.InUse, objQxServer4SynchEN.InUse.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objQxServer4SynchEN.UpdDate != null)
{
writer.WriteElementString(conQxServer4Synch.UpdDate, objQxServer4SynchEN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxServer4SynchEN.UpdUser != null)
{
writer.WriteElementString(conQxServer4Synch.UpdUser, objQxServer4SynchEN.UpdUser.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxServer4SynchEN.Memo != null)
{
writer.WriteElementString(conQxServer4Synch.Memo, objQxServer4SynchEN.Memo.ToString(CultureInfo.InvariantCulture));
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
public static clsQxServer4SynchEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsQxServer4SynchEN objQxServer4SynchEN = new clsQxServer4SynchEN();
reader.Read();
while (!(reader.Name == clsQxServer4SynchBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(conQxServer4Synch.ServerId))
{
objQxServer4SynchEN.ServerId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxServer4Synch.ServerName))
{
objQxServer4SynchEN.ServerName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxServer4Synch.IpAddress))
{
objQxServer4SynchEN.IpAddress = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxServer4Synch.WebApiAddress))
{
objQxServer4SynchEN.WebApiAddress = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxServer4Synch.IsSelf))
{
objQxServer4SynchEN.IsSelf = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(conQxServer4Synch.InUse))
{
objQxServer4SynchEN.InUse = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(conQxServer4Synch.UpdDate))
{
objQxServer4SynchEN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxServer4Synch.UpdUser))
{
objQxServer4SynchEN.UpdUser = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxServer4Synch.Memo))
{
objQxServer4SynchEN.Memo = reader.ReadElementContentAsString();
}
}
return objQxServer4SynchEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strQxServer4SynchObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsQxServer4SynchEN GetObjFromXmlStr(string strQxServer4SynchObjXmlStr)
{
clsQxServer4SynchEN objQxServer4SynchEN = new clsQxServer4SynchEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strQxServer4SynchObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsQxServer4SynchBL.itemXmlNode))
{
objQxServer4SynchEN = GetObjFromXml(reader);
return objQxServer4SynchEN;
}
}
return objQxServer4SynchEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objQxServer4SynchEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsQxServer4SynchEN objQxServer4SynchEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objQxServer4SynchEN);
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
public static string Func(string strInFldName, string strOutFldName, string strServerId)
{
if (strInFldName != conQxServer4Synch.ServerId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conQxServer4Synch.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conQxServer4Synch.AttributeName));
throw new Exception(strMsg);
}
var objQxServer4Synch = clsQxServer4SynchBL.GetObjByServerIdCache(strServerId);
if (objQxServer4Synch == null) return "";
return objQxServer4Synch[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objQxServer4SynchEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsQxServer4SynchEN objQxServer4SynchEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsQxServer4SynchEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objQxServer4SynchEN[strField]);
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
 /// <param name = "lstQxServer4SynchObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsQxServer4SynchEN> lstQxServer4SynchObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstQxServer4SynchObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsQxServer4SynchEN objQxServer4SynchEN in lstQxServer4SynchObjLst)
{
string strJSON_One = SerializeObjToJSON(objQxServer4SynchEN);
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
int intRecCount = clsQxServer4SynchDA.GetRecCount(strTabName);
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
int intRecCount = clsQxServer4SynchDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsQxServer4SynchDA.GetRecCount();
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
int intRecCount = clsQxServer4SynchDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objQxServer4SynchCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsQxServer4SynchEN objQxServer4SynchCond)
{
List<clsQxServer4SynchEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxServer4SynchEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxServer4Synch.AttributeName)
{
if (objQxServer4SynchCond.IsUpdated(strFldName) == false) continue;
if (objQxServer4SynchCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxServer4SynchCond[strFldName].ToString());
}
else
{
if (objQxServer4SynchCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxServer4SynchCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxServer4SynchCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxServer4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxServer4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxServer4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxServer4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxServer4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxServer4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxServer4SynchCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxServer4SynchCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxServer4SynchCond[strFldName]));
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
 List<string> arrList = clsQxServer4SynchDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = QxServer4SynchDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = QxServer4SynchDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = QxServer4SynchDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxServer4SynchDA.SetFldValue(clsQxServer4SynchEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = QxServer4SynchDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxServer4SynchDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxServer4SynchDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxServer4SynchDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[QxServer4Synch] "); 
 strCreateTabCode.Append(" ( "); 
 // /**服务器Id*/ 
 strCreateTabCode.Append(" ServerId char(4) primary key, "); 
 // /**服务器名*/ 
 strCreateTabCode.Append(" ServerName varchar(50) Null, "); 
 // /**IP地址*/ 
 strCreateTabCode.Append(" IpAddress varchar(23) not Null, "); 
 // /**WApi地址*/ 
 strCreateTabCode.Append(" WebApiAddress varchar(50) not Null, "); 
 // /**是否当前服务器*/ 
 strCreateTabCode.Append(" IsSelf bit Null, "); 
 // /**是否在用*/ 
 strCreateTabCode.Append(" InUse bit Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改用户*/ 
 strCreateTabCode.Append(" UpdUser varchar(18) Null, "); 
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
 /// 同步服务器(QxServer4Synch)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4QxServer4Synch : clsCommFun4BL
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
clsQxServer4SynchBL.ReFreshThisCache();
}
}

}