
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxPrjDataBaseBL
 表名:QxPrjDataBase(00140039)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:28:53
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:工程管理(PrjManage_GP)
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
public static class  clsQxPrjDataBaseBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strQxPrjDataBaseId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxPrjDataBaseEN GetObj(this K_QxPrjDataBaseId_QxPrjDataBase myKey)
{
clsQxPrjDataBaseEN objQxPrjDataBaseEN = clsQxPrjDataBaseBL.QxPrjDataBaseDA.GetObjByQxPrjDataBaseId(myKey.Value);
return objQxPrjDataBaseEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQxPrjDataBaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQxPrjDataBaseEN objQxPrjDataBaseEN)
{
if (CheckUniqueness(objQxPrjDataBaseEN) == false)
{
var strMsg = string.Format("记录已经存在!项目数据库名 = [{0}]的数据已经存在!(in clsQxPrjDataBaseBL.AddNewRecord)", objQxPrjDataBaseEN.PrjDataBaseName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQxPrjDataBaseEN.QxPrjDataBaseId) == true || clsQxPrjDataBaseBL.IsExist(objQxPrjDataBaseEN.QxPrjDataBaseId) == true)
 {
     objQxPrjDataBaseEN.QxPrjDataBaseId = clsQxPrjDataBaseBL.GetMaxStrId_S();
 }
bool bolResult = clsQxPrjDataBaseBL.QxPrjDataBaseDA.AddNewRecordBySQL2(objQxPrjDataBaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjDataBaseBL.ReFreshCache();

if (clsQxPrjDataBaseBL.relatedActions != null)
{
clsQxPrjDataBaseBL.relatedActions.UpdRelaTabDate(objQxPrjDataBaseEN.QxPrjDataBaseId, "SetUpdDate");
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
public static bool AddRecordEx(this clsQxPrjDataBaseEN objQxPrjDataBaseEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsQxPrjDataBaseBL.IsExist(objQxPrjDataBaseEN.QxPrjDataBaseId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objQxPrjDataBaseEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objQxPrjDataBaseEN.CheckUniqueness() == false)
{
strMsg = string.Format("(项目数据库名(PrjDataBaseName)=[{0}])已经存在,不能重复!", objQxPrjDataBaseEN.PrjDataBaseName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objQxPrjDataBaseEN.QxPrjDataBaseId) == true || clsQxPrjDataBaseBL.IsExist(objQxPrjDataBaseEN.QxPrjDataBaseId) == true)
 {
     objQxPrjDataBaseEN.QxPrjDataBaseId = clsQxPrjDataBaseBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objQxPrjDataBaseEN.AddNewRecord();
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
 /// <param name = "objQxPrjDataBaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsQxPrjDataBaseEN objQxPrjDataBaseEN)
{
if (CheckUniqueness(objQxPrjDataBaseEN) == false)
{
var strMsg = string.Format("记录已经存在!项目数据库名 = [{0}]的数据已经存在!(in clsQxPrjDataBaseBL.AddNewRecordWithMaxId)", objQxPrjDataBaseEN.PrjDataBaseName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQxPrjDataBaseEN.QxPrjDataBaseId) == true || clsQxPrjDataBaseBL.IsExist(objQxPrjDataBaseEN.QxPrjDataBaseId) == true)
 {
     objQxPrjDataBaseEN.QxPrjDataBaseId = clsQxPrjDataBaseBL.GetMaxStrId_S();
 }
string strQxPrjDataBaseId = clsQxPrjDataBaseBL.QxPrjDataBaseDA.AddNewRecordBySQL2WithReturnKey(objQxPrjDataBaseEN);
     objQxPrjDataBaseEN.QxPrjDataBaseId = strQxPrjDataBaseId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjDataBaseBL.ReFreshCache();

if (clsQxPrjDataBaseBL.relatedActions != null)
{
clsQxPrjDataBaseBL.relatedActions.UpdRelaTabDate(objQxPrjDataBaseEN.QxPrjDataBaseId, "SetUpdDate");
}
return strQxPrjDataBaseId;
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
 /// <param name = "objQxPrjDataBaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsQxPrjDataBaseEN objQxPrjDataBaseEN)
{
if (CheckUniqueness(objQxPrjDataBaseEN) == false)
{
var strMsg = string.Format("记录已经存在!项目数据库名 = [{0}]的数据已经存在!(in clsQxPrjDataBaseBL.AddNewRecordWithReturnKey)", objQxPrjDataBaseEN.PrjDataBaseName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQxPrjDataBaseEN.QxPrjDataBaseId) == true || clsQxPrjDataBaseBL.IsExist(objQxPrjDataBaseEN.QxPrjDataBaseId) == true)
 {
     objQxPrjDataBaseEN.QxPrjDataBaseId = clsQxPrjDataBaseBL.GetMaxStrId_S();
 }
string strKey = clsQxPrjDataBaseBL.QxPrjDataBaseDA.AddNewRecordBySQL2WithReturnKey(objQxPrjDataBaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjDataBaseBL.ReFreshCache();

if (clsQxPrjDataBaseBL.relatedActions != null)
{
clsQxPrjDataBaseBL.relatedActions.UpdRelaTabDate(objQxPrjDataBaseEN.QxPrjDataBaseId, "SetUpdDate");
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
 /// <param name = "objQxPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjDataBaseEN SetQxPrjDataBaseId(this clsQxPrjDataBaseEN objQxPrjDataBaseEN, string strQxPrjDataBaseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQxPrjDataBaseId, 4, conQxPrjDataBase.QxPrjDataBaseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQxPrjDataBaseId, 4, conQxPrjDataBase.QxPrjDataBaseId);
}
objQxPrjDataBaseEN.QxPrjDataBaseId = strQxPrjDataBaseId; //项目数据库Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjDataBaseEN.dicFldComparisonOp.ContainsKey(conQxPrjDataBase.QxPrjDataBaseId) == false)
{
objQxPrjDataBaseEN.dicFldComparisonOp.Add(conQxPrjDataBase.QxPrjDataBaseId, strComparisonOp);
}
else
{
objQxPrjDataBaseEN.dicFldComparisonOp[conQxPrjDataBase.QxPrjDataBaseId] = strComparisonOp;
}
}
return objQxPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjDataBaseEN SetPrjDataBaseName(this clsQxPrjDataBaseEN objQxPrjDataBaseEN, string strPrjDataBaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjDataBaseName, 50, conQxPrjDataBase.PrjDataBaseName);
}
objQxPrjDataBaseEN.PrjDataBaseName = strPrjDataBaseName; //项目数据库名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjDataBaseEN.dicFldComparisonOp.ContainsKey(conQxPrjDataBase.PrjDataBaseName) == false)
{
objQxPrjDataBaseEN.dicFldComparisonOp.Add(conQxPrjDataBase.PrjDataBaseName, strComparisonOp);
}
else
{
objQxPrjDataBaseEN.dicFldComparisonOp[conQxPrjDataBase.PrjDataBaseName] = strComparisonOp;
}
}
return objQxPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjDataBaseEN SetDataBaseName(this clsQxPrjDataBaseEN objQxPrjDataBaseEN, string strDataBaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataBaseName, 30, conQxPrjDataBase.DataBaseName);
}
objQxPrjDataBaseEN.DataBaseName = strDataBaseName; //数据库名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjDataBaseEN.dicFldComparisonOp.ContainsKey(conQxPrjDataBase.DataBaseName) == false)
{
objQxPrjDataBaseEN.dicFldComparisonOp.Add(conQxPrjDataBase.DataBaseName, strComparisonOp);
}
else
{
objQxPrjDataBaseEN.dicFldComparisonOp[conQxPrjDataBase.DataBaseName] = strComparisonOp;
}
}
return objQxPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjDataBaseEN SetDatabaseOwner(this clsQxPrjDataBaseEN objQxPrjDataBaseEN, string strDatabaseOwner, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDatabaseOwner, 30, conQxPrjDataBase.DatabaseOwner);
}
objQxPrjDataBaseEN.DatabaseOwner = strDatabaseOwner; //数据库拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjDataBaseEN.dicFldComparisonOp.ContainsKey(conQxPrjDataBase.DatabaseOwner) == false)
{
objQxPrjDataBaseEN.dicFldComparisonOp.Add(conQxPrjDataBase.DatabaseOwner, strComparisonOp);
}
else
{
objQxPrjDataBaseEN.dicFldComparisonOp[conQxPrjDataBase.DatabaseOwner] = strComparisonOp;
}
}
return objQxPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjDataBaseEN SetDataBasePwd(this clsQxPrjDataBaseEN objQxPrjDataBaseEN, string strDataBasePwd, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataBasePwd, 20, conQxPrjDataBase.DataBasePwd);
}
objQxPrjDataBaseEN.DataBasePwd = strDataBasePwd; //数据库用户口令
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjDataBaseEN.dicFldComparisonOp.ContainsKey(conQxPrjDataBase.DataBasePwd) == false)
{
objQxPrjDataBaseEN.dicFldComparisonOp.Add(conQxPrjDataBase.DataBasePwd, strComparisonOp);
}
else
{
objQxPrjDataBaseEN.dicFldComparisonOp[conQxPrjDataBase.DataBasePwd] = strComparisonOp;
}
}
return objQxPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjDataBaseEN SetDataBaseTypeId(this clsQxPrjDataBaseEN objQxPrjDataBaseEN, string strDataBaseTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataBaseTypeId, 2, conQxPrjDataBase.DataBaseTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDataBaseTypeId, 2, conQxPrjDataBase.DataBaseTypeId);
}
objQxPrjDataBaseEN.DataBaseTypeId = strDataBaseTypeId; //数据库类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjDataBaseEN.dicFldComparisonOp.ContainsKey(conQxPrjDataBase.DataBaseTypeId) == false)
{
objQxPrjDataBaseEN.dicFldComparisonOp.Add(conQxPrjDataBase.DataBaseTypeId, strComparisonOp);
}
else
{
objQxPrjDataBaseEN.dicFldComparisonOp[conQxPrjDataBase.DataBaseTypeId] = strComparisonOp;
}
}
return objQxPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjDataBaseEN SetDataBaseUserId(this clsQxPrjDataBaseEN objQxPrjDataBaseEN, string strDataBaseUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataBaseUserId, 18, conQxPrjDataBase.DataBaseUserId);
}
objQxPrjDataBaseEN.DataBaseUserId = strDataBaseUserId; //数据库用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjDataBaseEN.dicFldComparisonOp.ContainsKey(conQxPrjDataBase.DataBaseUserId) == false)
{
objQxPrjDataBaseEN.dicFldComparisonOp.Add(conQxPrjDataBase.DataBaseUserId, strComparisonOp);
}
else
{
objQxPrjDataBaseEN.dicFldComparisonOp[conQxPrjDataBase.DataBaseUserId] = strComparisonOp;
}
}
return objQxPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjDataBaseEN SetIpAddress(this clsQxPrjDataBaseEN objQxPrjDataBaseEN, string strIpAddress, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIpAddress, 23, conQxPrjDataBase.IpAddress);
}
objQxPrjDataBaseEN.IpAddress = strIpAddress; //IP地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjDataBaseEN.dicFldComparisonOp.ContainsKey(conQxPrjDataBase.IpAddress) == false)
{
objQxPrjDataBaseEN.dicFldComparisonOp.Add(conQxPrjDataBase.IpAddress, strComparisonOp);
}
else
{
objQxPrjDataBaseEN.dicFldComparisonOp[conQxPrjDataBase.IpAddress] = strComparisonOp;
}
}
return objQxPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjDataBaseEN SetSID(this clsQxPrjDataBaseEN objQxPrjDataBaseEN, string strSID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSID, 30, conQxPrjDataBase.SID);
}
objQxPrjDataBaseEN.SID = strSID; //SID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjDataBaseEN.dicFldComparisonOp.ContainsKey(conQxPrjDataBase.SID) == false)
{
objQxPrjDataBaseEN.dicFldComparisonOp.Add(conQxPrjDataBase.SID, strComparisonOp);
}
else
{
objQxPrjDataBaseEN.dicFldComparisonOp[conQxPrjDataBase.SID] = strComparisonOp;
}
}
return objQxPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjDataBaseEN SetTableSpace(this clsQxPrjDataBaseEN objQxPrjDataBaseEN, string strTableSpace, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTableSpace, 30, conQxPrjDataBase.TableSpace);
}
objQxPrjDataBaseEN.TableSpace = strTableSpace; //表空间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjDataBaseEN.dicFldComparisonOp.ContainsKey(conQxPrjDataBase.TableSpace) == false)
{
objQxPrjDataBaseEN.dicFldComparisonOp.Add(conQxPrjDataBase.TableSpace, strComparisonOp);
}
else
{
objQxPrjDataBaseEN.dicFldComparisonOp[conQxPrjDataBase.TableSpace] = strComparisonOp;
}
}
return objQxPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjDataBaseEN SetUserId(this clsQxPrjDataBaseEN objQxPrjDataBaseEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conQxPrjDataBase.UserId);
}
objQxPrjDataBaseEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjDataBaseEN.dicFldComparisonOp.ContainsKey(conQxPrjDataBase.UserId) == false)
{
objQxPrjDataBaseEN.dicFldComparisonOp.Add(conQxPrjDataBase.UserId, strComparisonOp);
}
else
{
objQxPrjDataBaseEN.dicFldComparisonOp[conQxPrjDataBase.UserId] = strComparisonOp;
}
}
return objQxPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjDataBaseEN SetUpdDate(this clsQxPrjDataBaseEN objQxPrjDataBaseEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQxPrjDataBase.UpdDate);
}
objQxPrjDataBaseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjDataBaseEN.dicFldComparisonOp.ContainsKey(conQxPrjDataBase.UpdDate) == false)
{
objQxPrjDataBaseEN.dicFldComparisonOp.Add(conQxPrjDataBase.UpdDate, strComparisonOp);
}
else
{
objQxPrjDataBaseEN.dicFldComparisonOp[conQxPrjDataBase.UpdDate] = strComparisonOp;
}
}
return objQxPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjDataBaseEN SetMemo(this clsQxPrjDataBaseEN objQxPrjDataBaseEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQxPrjDataBase.Memo);
}
objQxPrjDataBaseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjDataBaseEN.dicFldComparisonOp.ContainsKey(conQxPrjDataBase.Memo) == false)
{
objQxPrjDataBaseEN.dicFldComparisonOp.Add(conQxPrjDataBase.Memo, strComparisonOp);
}
else
{
objQxPrjDataBaseEN.dicFldComparisonOp[conQxPrjDataBase.Memo] = strComparisonOp;
}
}
return objQxPrjDataBaseEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objQxPrjDataBaseEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsQxPrjDataBaseEN objQxPrjDataBaseEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objQxPrjDataBaseEN.CheckPropertyNew();
clsQxPrjDataBaseEN objQxPrjDataBaseCond = new clsQxPrjDataBaseEN();
string strCondition = objQxPrjDataBaseCond
.SetQxPrjDataBaseId(objQxPrjDataBaseEN.QxPrjDataBaseId, "<>")
.SetPrjDataBaseName(objQxPrjDataBaseEN.PrjDataBaseName, "=")
.GetCombineCondition();
objQxPrjDataBaseEN._IsCheckProperty = true;
bool bolIsExist = clsQxPrjDataBaseBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(PrjDataBaseName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objQxPrjDataBaseEN.Update();
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
 /// <param name = "objQxPrjDataBase">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsQxPrjDataBaseEN objQxPrjDataBase)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsQxPrjDataBaseEN objQxPrjDataBaseCond = new clsQxPrjDataBaseEN();
string strCondition = objQxPrjDataBaseCond
.SetPrjDataBaseName(objQxPrjDataBase.PrjDataBaseName, "=")
.GetCombineCondition();
objQxPrjDataBase._IsCheckProperty = true;
bool bolIsExist = clsQxPrjDataBaseBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objQxPrjDataBase.QxPrjDataBaseId = clsQxPrjDataBaseBL.GetFirstID_S(strCondition);
objQxPrjDataBase.UpdateWithCondition(strCondition);
}
else
{
objQxPrjDataBase.QxPrjDataBaseId = clsQxPrjDataBaseBL.GetMaxStrId_S();
objQxPrjDataBase.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objQxPrjDataBaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxPrjDataBaseEN objQxPrjDataBaseEN)
{
 if (string.IsNullOrEmpty(objQxPrjDataBaseEN.QxPrjDataBaseId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxPrjDataBaseBL.QxPrjDataBaseDA.UpdateBySql2(objQxPrjDataBaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjDataBaseBL.ReFreshCache();

if (clsQxPrjDataBaseBL.relatedActions != null)
{
clsQxPrjDataBaseBL.relatedActions.UpdRelaTabDate(objQxPrjDataBaseEN.QxPrjDataBaseId, "SetUpdDate");
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
 /// <param name = "objQxPrjDataBaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxPrjDataBaseEN objQxPrjDataBaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objQxPrjDataBaseEN.QxPrjDataBaseId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxPrjDataBaseBL.QxPrjDataBaseDA.UpdateBySql2(objQxPrjDataBaseEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjDataBaseBL.ReFreshCache();

if (clsQxPrjDataBaseBL.relatedActions != null)
{
clsQxPrjDataBaseBL.relatedActions.UpdRelaTabDate(objQxPrjDataBaseEN.QxPrjDataBaseId, "SetUpdDate");
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
 /// <param name = "objQxPrjDataBaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxPrjDataBaseEN objQxPrjDataBaseEN, string strWhereCond)
{
try
{
bool bolResult = clsQxPrjDataBaseBL.QxPrjDataBaseDA.UpdateBySqlWithCondition(objQxPrjDataBaseEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjDataBaseBL.ReFreshCache();

if (clsQxPrjDataBaseBL.relatedActions != null)
{
clsQxPrjDataBaseBL.relatedActions.UpdRelaTabDate(objQxPrjDataBaseEN.QxPrjDataBaseId, "SetUpdDate");
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
 /// <param name = "objQxPrjDataBaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxPrjDataBaseEN objQxPrjDataBaseEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsQxPrjDataBaseBL.QxPrjDataBaseDA.UpdateBySqlWithConditionTransaction(objQxPrjDataBaseEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjDataBaseBL.ReFreshCache();

if (clsQxPrjDataBaseBL.relatedActions != null)
{
clsQxPrjDataBaseBL.relatedActions.UpdRelaTabDate(objQxPrjDataBaseEN.QxPrjDataBaseId, "SetUpdDate");
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
 /// <param name = "strQxPrjDataBaseId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsQxPrjDataBaseEN objQxPrjDataBaseEN)
{
try
{
int intRecNum = clsQxPrjDataBaseBL.QxPrjDataBaseDA.DelRecord(objQxPrjDataBaseEN.QxPrjDataBaseId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjDataBaseBL.ReFreshCache();

if (clsQxPrjDataBaseBL.relatedActions != null)
{
clsQxPrjDataBaseBL.relatedActions.UpdRelaTabDate(objQxPrjDataBaseEN.QxPrjDataBaseId, "SetUpdDate");
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
 /// <param name = "objQxPrjDataBaseENS">源对象</param>
 /// <param name = "objQxPrjDataBaseENT">目标对象</param>
 public static void CopyTo(this clsQxPrjDataBaseEN objQxPrjDataBaseENS, clsQxPrjDataBaseEN objQxPrjDataBaseENT)
{
try
{
objQxPrjDataBaseENT.QxPrjDataBaseId = objQxPrjDataBaseENS.QxPrjDataBaseId; //项目数据库Id
objQxPrjDataBaseENT.PrjDataBaseName = objQxPrjDataBaseENS.PrjDataBaseName; //项目数据库名
objQxPrjDataBaseENT.DataBaseName = objQxPrjDataBaseENS.DataBaseName; //数据库名称
objQxPrjDataBaseENT.DatabaseOwner = objQxPrjDataBaseENS.DatabaseOwner; //数据库拥有者
objQxPrjDataBaseENT.DataBasePwd = objQxPrjDataBaseENS.DataBasePwd; //数据库用户口令
objQxPrjDataBaseENT.DataBaseTypeId = objQxPrjDataBaseENS.DataBaseTypeId; //数据库类型ID
objQxPrjDataBaseENT.DataBaseUserId = objQxPrjDataBaseENS.DataBaseUserId; //数据库用户Id
objQxPrjDataBaseENT.IpAddress = objQxPrjDataBaseENS.IpAddress; //IP地址
objQxPrjDataBaseENT.SID = objQxPrjDataBaseENS.SID; //SID
objQxPrjDataBaseENT.TableSpace = objQxPrjDataBaseENS.TableSpace; //表空间
objQxPrjDataBaseENT.UserId = objQxPrjDataBaseENS.UserId; //用户ID
objQxPrjDataBaseENT.UpdDate = objQxPrjDataBaseENS.UpdDate; //修改日期
objQxPrjDataBaseENT.Memo = objQxPrjDataBaseENS.Memo; //备注
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
 /// <param name = "objQxPrjDataBaseENS">源对象</param>
 /// <returns>目标对象=>clsQxPrjDataBaseEN:objQxPrjDataBaseENT</returns>
 public static clsQxPrjDataBaseEN CopyTo(this clsQxPrjDataBaseEN objQxPrjDataBaseENS)
{
try
{
 clsQxPrjDataBaseEN objQxPrjDataBaseENT = new clsQxPrjDataBaseEN()
{
QxPrjDataBaseId = objQxPrjDataBaseENS.QxPrjDataBaseId, //项目数据库Id
PrjDataBaseName = objQxPrjDataBaseENS.PrjDataBaseName, //项目数据库名
DataBaseName = objQxPrjDataBaseENS.DataBaseName, //数据库名称
DatabaseOwner = objQxPrjDataBaseENS.DatabaseOwner, //数据库拥有者
DataBasePwd = objQxPrjDataBaseENS.DataBasePwd, //数据库用户口令
DataBaseTypeId = objQxPrjDataBaseENS.DataBaseTypeId, //数据库类型ID
DataBaseUserId = objQxPrjDataBaseENS.DataBaseUserId, //数据库用户Id
IpAddress = objQxPrjDataBaseENS.IpAddress, //IP地址
SID = objQxPrjDataBaseENS.SID, //SID
TableSpace = objQxPrjDataBaseENS.TableSpace, //表空间
UserId = objQxPrjDataBaseENS.UserId, //用户ID
UpdDate = objQxPrjDataBaseENS.UpdDate, //修改日期
Memo = objQxPrjDataBaseENS.Memo, //备注
};
 return objQxPrjDataBaseENT;
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
public static void CheckPropertyNew(this clsQxPrjDataBaseEN objQxPrjDataBaseEN)
{
 clsQxPrjDataBaseBL.QxPrjDataBaseDA.CheckPropertyNew(objQxPrjDataBaseEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsQxPrjDataBaseEN objQxPrjDataBaseEN)
{
 clsQxPrjDataBaseBL.QxPrjDataBaseDA.CheckProperty4Condition(objQxPrjDataBaseEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQxPrjDataBaseEN objQxPrjDataBaseCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQxPrjDataBaseCond.IsUpdated(conQxPrjDataBase.QxPrjDataBaseId) == true)
{
string strComparisonOpQxPrjDataBaseId = objQxPrjDataBaseCond.dicFldComparisonOp[conQxPrjDataBase.QxPrjDataBaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjDataBase.QxPrjDataBaseId, objQxPrjDataBaseCond.QxPrjDataBaseId, strComparisonOpQxPrjDataBaseId);
}
if (objQxPrjDataBaseCond.IsUpdated(conQxPrjDataBase.PrjDataBaseName) == true)
{
string strComparisonOpPrjDataBaseName = objQxPrjDataBaseCond.dicFldComparisonOp[conQxPrjDataBase.PrjDataBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjDataBase.PrjDataBaseName, objQxPrjDataBaseCond.PrjDataBaseName, strComparisonOpPrjDataBaseName);
}
if (objQxPrjDataBaseCond.IsUpdated(conQxPrjDataBase.DataBaseName) == true)
{
string strComparisonOpDataBaseName = objQxPrjDataBaseCond.dicFldComparisonOp[conQxPrjDataBase.DataBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjDataBase.DataBaseName, objQxPrjDataBaseCond.DataBaseName, strComparisonOpDataBaseName);
}
if (objQxPrjDataBaseCond.IsUpdated(conQxPrjDataBase.DatabaseOwner) == true)
{
string strComparisonOpDatabaseOwner = objQxPrjDataBaseCond.dicFldComparisonOp[conQxPrjDataBase.DatabaseOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjDataBase.DatabaseOwner, objQxPrjDataBaseCond.DatabaseOwner, strComparisonOpDatabaseOwner);
}
if (objQxPrjDataBaseCond.IsUpdated(conQxPrjDataBase.DataBasePwd) == true)
{
string strComparisonOpDataBasePwd = objQxPrjDataBaseCond.dicFldComparisonOp[conQxPrjDataBase.DataBasePwd];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjDataBase.DataBasePwd, objQxPrjDataBaseCond.DataBasePwd, strComparisonOpDataBasePwd);
}
if (objQxPrjDataBaseCond.IsUpdated(conQxPrjDataBase.DataBaseTypeId) == true)
{
string strComparisonOpDataBaseTypeId = objQxPrjDataBaseCond.dicFldComparisonOp[conQxPrjDataBase.DataBaseTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjDataBase.DataBaseTypeId, objQxPrjDataBaseCond.DataBaseTypeId, strComparisonOpDataBaseTypeId);
}
if (objQxPrjDataBaseCond.IsUpdated(conQxPrjDataBase.DataBaseUserId) == true)
{
string strComparisonOpDataBaseUserId = objQxPrjDataBaseCond.dicFldComparisonOp[conQxPrjDataBase.DataBaseUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjDataBase.DataBaseUserId, objQxPrjDataBaseCond.DataBaseUserId, strComparisonOpDataBaseUserId);
}
if (objQxPrjDataBaseCond.IsUpdated(conQxPrjDataBase.IpAddress) == true)
{
string strComparisonOpIpAddress = objQxPrjDataBaseCond.dicFldComparisonOp[conQxPrjDataBase.IpAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjDataBase.IpAddress, objQxPrjDataBaseCond.IpAddress, strComparisonOpIpAddress);
}
if (objQxPrjDataBaseCond.IsUpdated(conQxPrjDataBase.SID) == true)
{
string strComparisonOpSID = objQxPrjDataBaseCond.dicFldComparisonOp[conQxPrjDataBase.SID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjDataBase.SID, objQxPrjDataBaseCond.SID, strComparisonOpSID);
}
if (objQxPrjDataBaseCond.IsUpdated(conQxPrjDataBase.TableSpace) == true)
{
string strComparisonOpTableSpace = objQxPrjDataBaseCond.dicFldComparisonOp[conQxPrjDataBase.TableSpace];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjDataBase.TableSpace, objQxPrjDataBaseCond.TableSpace, strComparisonOpTableSpace);
}
if (objQxPrjDataBaseCond.IsUpdated(conQxPrjDataBase.UserId) == true)
{
string strComparisonOpUserId = objQxPrjDataBaseCond.dicFldComparisonOp[conQxPrjDataBase.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjDataBase.UserId, objQxPrjDataBaseCond.UserId, strComparisonOpUserId);
}
if (objQxPrjDataBaseCond.IsUpdated(conQxPrjDataBase.UpdDate) == true)
{
string strComparisonOpUpdDate = objQxPrjDataBaseCond.dicFldComparisonOp[conQxPrjDataBase.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjDataBase.UpdDate, objQxPrjDataBaseCond.UpdDate, strComparisonOpUpdDate);
}
if (objQxPrjDataBaseCond.IsUpdated(conQxPrjDataBase.Memo) == true)
{
string strComparisonOpMemo = objQxPrjDataBaseCond.dicFldComparisonOp[conQxPrjDataBase.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjDataBase.Memo, objQxPrjDataBaseCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--QxPrjDataBase(数据库对象), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:PrjDataBaseName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objQxPrjDataBaseEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsQxPrjDataBaseEN objQxPrjDataBaseEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objQxPrjDataBaseEN == null) return true;
if (objQxPrjDataBaseEN.QxPrjDataBaseId == null || objQxPrjDataBaseEN.QxPrjDataBaseId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objQxPrjDataBaseEN.PrjDataBaseName == null)
{
 sbCondition.AppendFormat(" and PrjDataBaseName is null", objQxPrjDataBaseEN.PrjDataBaseName);
}
else
{
 sbCondition.AppendFormat(" and PrjDataBaseName = '{0}'", objQxPrjDataBaseEN.PrjDataBaseName);
}
if (clsQxPrjDataBaseBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("QxPrjDataBaseId !=  '{0}'", objQxPrjDataBaseEN.QxPrjDataBaseId);
 sbCondition.AppendFormat(" and PrjDataBaseName = '{0}'", objQxPrjDataBaseEN.PrjDataBaseName);
if (clsQxPrjDataBaseBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--QxPrjDataBase(数据库对象), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PrjDataBaseName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objQxPrjDataBaseEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsQxPrjDataBaseEN objQxPrjDataBaseEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objQxPrjDataBaseEN == null) return "";
if (objQxPrjDataBaseEN.QxPrjDataBaseId == null || objQxPrjDataBaseEN.QxPrjDataBaseId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objQxPrjDataBaseEN.PrjDataBaseName == null)
{
 sbCondition.AppendFormat(" and PrjDataBaseName is null", objQxPrjDataBaseEN.PrjDataBaseName);
}
else
{
 sbCondition.AppendFormat(" and PrjDataBaseName = '{0}'", objQxPrjDataBaseEN.PrjDataBaseName);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("QxPrjDataBaseId !=  '{0}'", objQxPrjDataBaseEN.QxPrjDataBaseId);
 sbCondition.AppendFormat(" and PrjDataBaseName = '{0}'", objQxPrjDataBaseEN.PrjDataBaseName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_QxPrjDataBase
{
public virtual bool UpdRelaTabDate(string strQxPrjDataBaseId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 数据库对象(QxPrjDataBase)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsQxPrjDataBaseBL
{
public static RelatedActions_QxPrjDataBase relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "QxPrjDataBaseListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "QxPrjDataBaseList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsQxPrjDataBaseEN> arrQxPrjDataBaseObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsQxPrjDataBaseDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsQxPrjDataBaseDA QxPrjDataBaseDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsQxPrjDataBaseDA();
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
 public clsQxPrjDataBaseBL()
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
if (string.IsNullOrEmpty(clsQxPrjDataBaseEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxPrjDataBaseEN._ConnectString);
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
objDS = QxPrjDataBaseDA.GetDataSet(strWhereCond);
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
objDS = QxPrjDataBaseDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = QxPrjDataBaseDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_QxPrjDataBase(string strWhereCond)
{
DataTable objDT;
try
{
objDT = QxPrjDataBaseDA.GetDataTable_QxPrjDataBase(strWhereCond);
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
objDT = QxPrjDataBaseDA.GetDataTable(strWhereCond);
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
objDT = QxPrjDataBaseDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = QxPrjDataBaseDA.GetDataTable(strWhereCond, strTabName);
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
objDT = QxPrjDataBaseDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = QxPrjDataBaseDA.GetDataTable_Top(objTopPara);
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
objDT = QxPrjDataBaseDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = QxPrjDataBaseDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = QxPrjDataBaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = QxPrjDataBaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = QxPrjDataBaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = QxPrjDataBaseDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = QxPrjDataBaseDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = QxPrjDataBaseDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
 /// <param name = "arrQxPrjDataBaseIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsQxPrjDataBaseEN> GetObjLstByQxPrjDataBaseIdLst(List<string> arrQxPrjDataBaseIdLst)
{
List<clsQxPrjDataBaseEN> arrObjLst = new List<clsQxPrjDataBaseEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrQxPrjDataBaseIdLst, true);
 string strWhereCond = string.Format("QxPrjDataBaseId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjDataBaseEN objQxPrjDataBaseEN = new clsQxPrjDataBaseEN();
try
{
objQxPrjDataBaseEN.QxPrjDataBaseId = objRow[conQxPrjDataBase.QxPrjDataBaseId].ToString().Trim(); //项目数据库Id
objQxPrjDataBaseEN.PrjDataBaseName = objRow[conQxPrjDataBase.PrjDataBaseName] == DBNull.Value ? null : objRow[conQxPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objQxPrjDataBaseEN.DataBaseName = objRow[conQxPrjDataBase.DataBaseName] == DBNull.Value ? null : objRow[conQxPrjDataBase.DataBaseName].ToString().Trim(); //数据库名称
objQxPrjDataBaseEN.DatabaseOwner = objRow[conQxPrjDataBase.DatabaseOwner] == DBNull.Value ? null : objRow[conQxPrjDataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objQxPrjDataBaseEN.DataBasePwd = objRow[conQxPrjDataBase.DataBasePwd] == DBNull.Value ? null : objRow[conQxPrjDataBase.DataBasePwd].ToString().Trim(); //数据库用户口令
objQxPrjDataBaseEN.DataBaseTypeId = objRow[conQxPrjDataBase.DataBaseTypeId] == DBNull.Value ? null : objRow[conQxPrjDataBase.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objQxPrjDataBaseEN.DataBaseUserId = objRow[conQxPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[conQxPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库用户Id
objQxPrjDataBaseEN.IpAddress = objRow[conQxPrjDataBase.IpAddress] == DBNull.Value ? null : objRow[conQxPrjDataBase.IpAddress].ToString().Trim(); //IP地址
objQxPrjDataBaseEN.SID = objRow[conQxPrjDataBase.SID] == DBNull.Value ? null : objRow[conQxPrjDataBase.SID].ToString().Trim(); //SID
objQxPrjDataBaseEN.TableSpace = objRow[conQxPrjDataBase.TableSpace] == DBNull.Value ? null : objRow[conQxPrjDataBase.TableSpace].ToString().Trim(); //表空间
objQxPrjDataBaseEN.UserId = objRow[conQxPrjDataBase.UserId] == DBNull.Value ? null : objRow[conQxPrjDataBase.UserId].ToString().Trim(); //用户ID
objQxPrjDataBaseEN.UpdDate = objRow[conQxPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[conQxPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objQxPrjDataBaseEN.Memo = objRow[conQxPrjDataBase.Memo] == DBNull.Value ? null : objRow[conQxPrjDataBase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjDataBaseEN.QxPrjDataBaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjDataBaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrQxPrjDataBaseIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsQxPrjDataBaseEN> GetObjLstByQxPrjDataBaseIdLstCache(List<string> arrQxPrjDataBaseIdLst)
{
string strKey = string.Format("{0}", clsQxPrjDataBaseEN._CurrTabName);
List<clsQxPrjDataBaseEN> arrQxPrjDataBaseObjLstCache = GetObjLstCache();
IEnumerable <clsQxPrjDataBaseEN> arrQxPrjDataBaseObjLst_Sel =
arrQxPrjDataBaseObjLstCache
.Where(x => arrQxPrjDataBaseIdLst.Contains(x.QxPrjDataBaseId));
return arrQxPrjDataBaseObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPrjDataBaseEN> GetObjLst(string strWhereCond)
{
List<clsQxPrjDataBaseEN> arrObjLst = new List<clsQxPrjDataBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjDataBaseEN objQxPrjDataBaseEN = new clsQxPrjDataBaseEN();
try
{
objQxPrjDataBaseEN.QxPrjDataBaseId = objRow[conQxPrjDataBase.QxPrjDataBaseId].ToString().Trim(); //项目数据库Id
objQxPrjDataBaseEN.PrjDataBaseName = objRow[conQxPrjDataBase.PrjDataBaseName] == DBNull.Value ? null : objRow[conQxPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objQxPrjDataBaseEN.DataBaseName = objRow[conQxPrjDataBase.DataBaseName] == DBNull.Value ? null : objRow[conQxPrjDataBase.DataBaseName].ToString().Trim(); //数据库名称
objQxPrjDataBaseEN.DatabaseOwner = objRow[conQxPrjDataBase.DatabaseOwner] == DBNull.Value ? null : objRow[conQxPrjDataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objQxPrjDataBaseEN.DataBasePwd = objRow[conQxPrjDataBase.DataBasePwd] == DBNull.Value ? null : objRow[conQxPrjDataBase.DataBasePwd].ToString().Trim(); //数据库用户口令
objQxPrjDataBaseEN.DataBaseTypeId = objRow[conQxPrjDataBase.DataBaseTypeId] == DBNull.Value ? null : objRow[conQxPrjDataBase.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objQxPrjDataBaseEN.DataBaseUserId = objRow[conQxPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[conQxPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库用户Id
objQxPrjDataBaseEN.IpAddress = objRow[conQxPrjDataBase.IpAddress] == DBNull.Value ? null : objRow[conQxPrjDataBase.IpAddress].ToString().Trim(); //IP地址
objQxPrjDataBaseEN.SID = objRow[conQxPrjDataBase.SID] == DBNull.Value ? null : objRow[conQxPrjDataBase.SID].ToString().Trim(); //SID
objQxPrjDataBaseEN.TableSpace = objRow[conQxPrjDataBase.TableSpace] == DBNull.Value ? null : objRow[conQxPrjDataBase.TableSpace].ToString().Trim(); //表空间
objQxPrjDataBaseEN.UserId = objRow[conQxPrjDataBase.UserId] == DBNull.Value ? null : objRow[conQxPrjDataBase.UserId].ToString().Trim(); //用户ID
objQxPrjDataBaseEN.UpdDate = objRow[conQxPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[conQxPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objQxPrjDataBaseEN.Memo = objRow[conQxPrjDataBase.Memo] == DBNull.Value ? null : objRow[conQxPrjDataBase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjDataBaseEN.QxPrjDataBaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjDataBaseEN);
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
public static List<clsQxPrjDataBaseEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsQxPrjDataBaseEN> arrObjLst = new List<clsQxPrjDataBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjDataBaseEN objQxPrjDataBaseEN = new clsQxPrjDataBaseEN();
try
{
objQxPrjDataBaseEN.QxPrjDataBaseId = objRow[conQxPrjDataBase.QxPrjDataBaseId].ToString().Trim(); //项目数据库Id
objQxPrjDataBaseEN.PrjDataBaseName = objRow[conQxPrjDataBase.PrjDataBaseName] == DBNull.Value ? null : objRow[conQxPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objQxPrjDataBaseEN.DataBaseName = objRow[conQxPrjDataBase.DataBaseName] == DBNull.Value ? null : objRow[conQxPrjDataBase.DataBaseName].ToString().Trim(); //数据库名称
objQxPrjDataBaseEN.DatabaseOwner = objRow[conQxPrjDataBase.DatabaseOwner] == DBNull.Value ? null : objRow[conQxPrjDataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objQxPrjDataBaseEN.DataBasePwd = objRow[conQxPrjDataBase.DataBasePwd] == DBNull.Value ? null : objRow[conQxPrjDataBase.DataBasePwd].ToString().Trim(); //数据库用户口令
objQxPrjDataBaseEN.DataBaseTypeId = objRow[conQxPrjDataBase.DataBaseTypeId] == DBNull.Value ? null : objRow[conQxPrjDataBase.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objQxPrjDataBaseEN.DataBaseUserId = objRow[conQxPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[conQxPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库用户Id
objQxPrjDataBaseEN.IpAddress = objRow[conQxPrjDataBase.IpAddress] == DBNull.Value ? null : objRow[conQxPrjDataBase.IpAddress].ToString().Trim(); //IP地址
objQxPrjDataBaseEN.SID = objRow[conQxPrjDataBase.SID] == DBNull.Value ? null : objRow[conQxPrjDataBase.SID].ToString().Trim(); //SID
objQxPrjDataBaseEN.TableSpace = objRow[conQxPrjDataBase.TableSpace] == DBNull.Value ? null : objRow[conQxPrjDataBase.TableSpace].ToString().Trim(); //表空间
objQxPrjDataBaseEN.UserId = objRow[conQxPrjDataBase.UserId] == DBNull.Value ? null : objRow[conQxPrjDataBase.UserId].ToString().Trim(); //用户ID
objQxPrjDataBaseEN.UpdDate = objRow[conQxPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[conQxPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objQxPrjDataBaseEN.Memo = objRow[conQxPrjDataBase.Memo] == DBNull.Value ? null : objRow[conQxPrjDataBase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjDataBaseEN.QxPrjDataBaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjDataBaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objQxPrjDataBaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsQxPrjDataBaseEN> GetSubObjLstCache(clsQxPrjDataBaseEN objQxPrjDataBaseCond)
{
List<clsQxPrjDataBaseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxPrjDataBaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxPrjDataBase.AttributeName)
{
if (objQxPrjDataBaseCond.IsUpdated(strFldName) == false) continue;
if (objQxPrjDataBaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxPrjDataBaseCond[strFldName].ToString());
}
else
{
if (objQxPrjDataBaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxPrjDataBaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxPrjDataBaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxPrjDataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxPrjDataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxPrjDataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxPrjDataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxPrjDataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxPrjDataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxPrjDataBaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxPrjDataBaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxPrjDataBaseCond[strFldName]));
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
public static List<clsQxPrjDataBaseEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsQxPrjDataBaseEN> arrObjLst = new List<clsQxPrjDataBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjDataBaseEN objQxPrjDataBaseEN = new clsQxPrjDataBaseEN();
try
{
objQxPrjDataBaseEN.QxPrjDataBaseId = objRow[conQxPrjDataBase.QxPrjDataBaseId].ToString().Trim(); //项目数据库Id
objQxPrjDataBaseEN.PrjDataBaseName = objRow[conQxPrjDataBase.PrjDataBaseName] == DBNull.Value ? null : objRow[conQxPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objQxPrjDataBaseEN.DataBaseName = objRow[conQxPrjDataBase.DataBaseName] == DBNull.Value ? null : objRow[conQxPrjDataBase.DataBaseName].ToString().Trim(); //数据库名称
objQxPrjDataBaseEN.DatabaseOwner = objRow[conQxPrjDataBase.DatabaseOwner] == DBNull.Value ? null : objRow[conQxPrjDataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objQxPrjDataBaseEN.DataBasePwd = objRow[conQxPrjDataBase.DataBasePwd] == DBNull.Value ? null : objRow[conQxPrjDataBase.DataBasePwd].ToString().Trim(); //数据库用户口令
objQxPrjDataBaseEN.DataBaseTypeId = objRow[conQxPrjDataBase.DataBaseTypeId] == DBNull.Value ? null : objRow[conQxPrjDataBase.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objQxPrjDataBaseEN.DataBaseUserId = objRow[conQxPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[conQxPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库用户Id
objQxPrjDataBaseEN.IpAddress = objRow[conQxPrjDataBase.IpAddress] == DBNull.Value ? null : objRow[conQxPrjDataBase.IpAddress].ToString().Trim(); //IP地址
objQxPrjDataBaseEN.SID = objRow[conQxPrjDataBase.SID] == DBNull.Value ? null : objRow[conQxPrjDataBase.SID].ToString().Trim(); //SID
objQxPrjDataBaseEN.TableSpace = objRow[conQxPrjDataBase.TableSpace] == DBNull.Value ? null : objRow[conQxPrjDataBase.TableSpace].ToString().Trim(); //表空间
objQxPrjDataBaseEN.UserId = objRow[conQxPrjDataBase.UserId] == DBNull.Value ? null : objRow[conQxPrjDataBase.UserId].ToString().Trim(); //用户ID
objQxPrjDataBaseEN.UpdDate = objRow[conQxPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[conQxPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objQxPrjDataBaseEN.Memo = objRow[conQxPrjDataBase.Memo] == DBNull.Value ? null : objRow[conQxPrjDataBase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjDataBaseEN.QxPrjDataBaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjDataBaseEN);
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
public static List<clsQxPrjDataBaseEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsQxPrjDataBaseEN> arrObjLst = new List<clsQxPrjDataBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjDataBaseEN objQxPrjDataBaseEN = new clsQxPrjDataBaseEN();
try
{
objQxPrjDataBaseEN.QxPrjDataBaseId = objRow[conQxPrjDataBase.QxPrjDataBaseId].ToString().Trim(); //项目数据库Id
objQxPrjDataBaseEN.PrjDataBaseName = objRow[conQxPrjDataBase.PrjDataBaseName] == DBNull.Value ? null : objRow[conQxPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objQxPrjDataBaseEN.DataBaseName = objRow[conQxPrjDataBase.DataBaseName] == DBNull.Value ? null : objRow[conQxPrjDataBase.DataBaseName].ToString().Trim(); //数据库名称
objQxPrjDataBaseEN.DatabaseOwner = objRow[conQxPrjDataBase.DatabaseOwner] == DBNull.Value ? null : objRow[conQxPrjDataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objQxPrjDataBaseEN.DataBasePwd = objRow[conQxPrjDataBase.DataBasePwd] == DBNull.Value ? null : objRow[conQxPrjDataBase.DataBasePwd].ToString().Trim(); //数据库用户口令
objQxPrjDataBaseEN.DataBaseTypeId = objRow[conQxPrjDataBase.DataBaseTypeId] == DBNull.Value ? null : objRow[conQxPrjDataBase.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objQxPrjDataBaseEN.DataBaseUserId = objRow[conQxPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[conQxPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库用户Id
objQxPrjDataBaseEN.IpAddress = objRow[conQxPrjDataBase.IpAddress] == DBNull.Value ? null : objRow[conQxPrjDataBase.IpAddress].ToString().Trim(); //IP地址
objQxPrjDataBaseEN.SID = objRow[conQxPrjDataBase.SID] == DBNull.Value ? null : objRow[conQxPrjDataBase.SID].ToString().Trim(); //SID
objQxPrjDataBaseEN.TableSpace = objRow[conQxPrjDataBase.TableSpace] == DBNull.Value ? null : objRow[conQxPrjDataBase.TableSpace].ToString().Trim(); //表空间
objQxPrjDataBaseEN.UserId = objRow[conQxPrjDataBase.UserId] == DBNull.Value ? null : objRow[conQxPrjDataBase.UserId].ToString().Trim(); //用户ID
objQxPrjDataBaseEN.UpdDate = objRow[conQxPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[conQxPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objQxPrjDataBaseEN.Memo = objRow[conQxPrjDataBase.Memo] == DBNull.Value ? null : objRow[conQxPrjDataBase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjDataBaseEN.QxPrjDataBaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjDataBaseEN);
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
List<clsQxPrjDataBaseEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsQxPrjDataBaseEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPrjDataBaseEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsQxPrjDataBaseEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsQxPrjDataBaseEN> arrObjLst = new List<clsQxPrjDataBaseEN>(); 
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
	clsQxPrjDataBaseEN objQxPrjDataBaseEN = new clsQxPrjDataBaseEN();
try
{
objQxPrjDataBaseEN.QxPrjDataBaseId = objRow[conQxPrjDataBase.QxPrjDataBaseId].ToString().Trim(); //项目数据库Id
objQxPrjDataBaseEN.PrjDataBaseName = objRow[conQxPrjDataBase.PrjDataBaseName] == DBNull.Value ? null : objRow[conQxPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objQxPrjDataBaseEN.DataBaseName = objRow[conQxPrjDataBase.DataBaseName] == DBNull.Value ? null : objRow[conQxPrjDataBase.DataBaseName].ToString().Trim(); //数据库名称
objQxPrjDataBaseEN.DatabaseOwner = objRow[conQxPrjDataBase.DatabaseOwner] == DBNull.Value ? null : objRow[conQxPrjDataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objQxPrjDataBaseEN.DataBasePwd = objRow[conQxPrjDataBase.DataBasePwd] == DBNull.Value ? null : objRow[conQxPrjDataBase.DataBasePwd].ToString().Trim(); //数据库用户口令
objQxPrjDataBaseEN.DataBaseTypeId = objRow[conQxPrjDataBase.DataBaseTypeId] == DBNull.Value ? null : objRow[conQxPrjDataBase.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objQxPrjDataBaseEN.DataBaseUserId = objRow[conQxPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[conQxPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库用户Id
objQxPrjDataBaseEN.IpAddress = objRow[conQxPrjDataBase.IpAddress] == DBNull.Value ? null : objRow[conQxPrjDataBase.IpAddress].ToString().Trim(); //IP地址
objQxPrjDataBaseEN.SID = objRow[conQxPrjDataBase.SID] == DBNull.Value ? null : objRow[conQxPrjDataBase.SID].ToString().Trim(); //SID
objQxPrjDataBaseEN.TableSpace = objRow[conQxPrjDataBase.TableSpace] == DBNull.Value ? null : objRow[conQxPrjDataBase.TableSpace].ToString().Trim(); //表空间
objQxPrjDataBaseEN.UserId = objRow[conQxPrjDataBase.UserId] == DBNull.Value ? null : objRow[conQxPrjDataBase.UserId].ToString().Trim(); //用户ID
objQxPrjDataBaseEN.UpdDate = objRow[conQxPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[conQxPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objQxPrjDataBaseEN.Memo = objRow[conQxPrjDataBase.Memo] == DBNull.Value ? null : objRow[conQxPrjDataBase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjDataBaseEN.QxPrjDataBaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjDataBaseEN);
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
public static List<clsQxPrjDataBaseEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsQxPrjDataBaseEN> arrObjLst = new List<clsQxPrjDataBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjDataBaseEN objQxPrjDataBaseEN = new clsQxPrjDataBaseEN();
try
{
objQxPrjDataBaseEN.QxPrjDataBaseId = objRow[conQxPrjDataBase.QxPrjDataBaseId].ToString().Trim(); //项目数据库Id
objQxPrjDataBaseEN.PrjDataBaseName = objRow[conQxPrjDataBase.PrjDataBaseName] == DBNull.Value ? null : objRow[conQxPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objQxPrjDataBaseEN.DataBaseName = objRow[conQxPrjDataBase.DataBaseName] == DBNull.Value ? null : objRow[conQxPrjDataBase.DataBaseName].ToString().Trim(); //数据库名称
objQxPrjDataBaseEN.DatabaseOwner = objRow[conQxPrjDataBase.DatabaseOwner] == DBNull.Value ? null : objRow[conQxPrjDataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objQxPrjDataBaseEN.DataBasePwd = objRow[conQxPrjDataBase.DataBasePwd] == DBNull.Value ? null : objRow[conQxPrjDataBase.DataBasePwd].ToString().Trim(); //数据库用户口令
objQxPrjDataBaseEN.DataBaseTypeId = objRow[conQxPrjDataBase.DataBaseTypeId] == DBNull.Value ? null : objRow[conQxPrjDataBase.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objQxPrjDataBaseEN.DataBaseUserId = objRow[conQxPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[conQxPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库用户Id
objQxPrjDataBaseEN.IpAddress = objRow[conQxPrjDataBase.IpAddress] == DBNull.Value ? null : objRow[conQxPrjDataBase.IpAddress].ToString().Trim(); //IP地址
objQxPrjDataBaseEN.SID = objRow[conQxPrjDataBase.SID] == DBNull.Value ? null : objRow[conQxPrjDataBase.SID].ToString().Trim(); //SID
objQxPrjDataBaseEN.TableSpace = objRow[conQxPrjDataBase.TableSpace] == DBNull.Value ? null : objRow[conQxPrjDataBase.TableSpace].ToString().Trim(); //表空间
objQxPrjDataBaseEN.UserId = objRow[conQxPrjDataBase.UserId] == DBNull.Value ? null : objRow[conQxPrjDataBase.UserId].ToString().Trim(); //用户ID
objQxPrjDataBaseEN.UpdDate = objRow[conQxPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[conQxPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objQxPrjDataBaseEN.Memo = objRow[conQxPrjDataBase.Memo] == DBNull.Value ? null : objRow[conQxPrjDataBase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjDataBaseEN.QxPrjDataBaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjDataBaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsQxPrjDataBaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsQxPrjDataBaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsQxPrjDataBaseEN> arrObjLst = new List<clsQxPrjDataBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjDataBaseEN objQxPrjDataBaseEN = new clsQxPrjDataBaseEN();
try
{
objQxPrjDataBaseEN.QxPrjDataBaseId = objRow[conQxPrjDataBase.QxPrjDataBaseId].ToString().Trim(); //项目数据库Id
objQxPrjDataBaseEN.PrjDataBaseName = objRow[conQxPrjDataBase.PrjDataBaseName] == DBNull.Value ? null : objRow[conQxPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objQxPrjDataBaseEN.DataBaseName = objRow[conQxPrjDataBase.DataBaseName] == DBNull.Value ? null : objRow[conQxPrjDataBase.DataBaseName].ToString().Trim(); //数据库名称
objQxPrjDataBaseEN.DatabaseOwner = objRow[conQxPrjDataBase.DatabaseOwner] == DBNull.Value ? null : objRow[conQxPrjDataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objQxPrjDataBaseEN.DataBasePwd = objRow[conQxPrjDataBase.DataBasePwd] == DBNull.Value ? null : objRow[conQxPrjDataBase.DataBasePwd].ToString().Trim(); //数据库用户口令
objQxPrjDataBaseEN.DataBaseTypeId = objRow[conQxPrjDataBase.DataBaseTypeId] == DBNull.Value ? null : objRow[conQxPrjDataBase.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objQxPrjDataBaseEN.DataBaseUserId = objRow[conQxPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[conQxPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库用户Id
objQxPrjDataBaseEN.IpAddress = objRow[conQxPrjDataBase.IpAddress] == DBNull.Value ? null : objRow[conQxPrjDataBase.IpAddress].ToString().Trim(); //IP地址
objQxPrjDataBaseEN.SID = objRow[conQxPrjDataBase.SID] == DBNull.Value ? null : objRow[conQxPrjDataBase.SID].ToString().Trim(); //SID
objQxPrjDataBaseEN.TableSpace = objRow[conQxPrjDataBase.TableSpace] == DBNull.Value ? null : objRow[conQxPrjDataBase.TableSpace].ToString().Trim(); //表空间
objQxPrjDataBaseEN.UserId = objRow[conQxPrjDataBase.UserId] == DBNull.Value ? null : objRow[conQxPrjDataBase.UserId].ToString().Trim(); //用户ID
objQxPrjDataBaseEN.UpdDate = objRow[conQxPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[conQxPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objQxPrjDataBaseEN.Memo = objRow[conQxPrjDataBase.Memo] == DBNull.Value ? null : objRow[conQxPrjDataBase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjDataBaseEN.QxPrjDataBaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjDataBaseEN);
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
public static List<clsQxPrjDataBaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsQxPrjDataBaseEN> arrObjLst = new List<clsQxPrjDataBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjDataBaseEN objQxPrjDataBaseEN = new clsQxPrjDataBaseEN();
try
{
objQxPrjDataBaseEN.QxPrjDataBaseId = objRow[conQxPrjDataBase.QxPrjDataBaseId].ToString().Trim(); //项目数据库Id
objQxPrjDataBaseEN.PrjDataBaseName = objRow[conQxPrjDataBase.PrjDataBaseName] == DBNull.Value ? null : objRow[conQxPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objQxPrjDataBaseEN.DataBaseName = objRow[conQxPrjDataBase.DataBaseName] == DBNull.Value ? null : objRow[conQxPrjDataBase.DataBaseName].ToString().Trim(); //数据库名称
objQxPrjDataBaseEN.DatabaseOwner = objRow[conQxPrjDataBase.DatabaseOwner] == DBNull.Value ? null : objRow[conQxPrjDataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objQxPrjDataBaseEN.DataBasePwd = objRow[conQxPrjDataBase.DataBasePwd] == DBNull.Value ? null : objRow[conQxPrjDataBase.DataBasePwd].ToString().Trim(); //数据库用户口令
objQxPrjDataBaseEN.DataBaseTypeId = objRow[conQxPrjDataBase.DataBaseTypeId] == DBNull.Value ? null : objRow[conQxPrjDataBase.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objQxPrjDataBaseEN.DataBaseUserId = objRow[conQxPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[conQxPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库用户Id
objQxPrjDataBaseEN.IpAddress = objRow[conQxPrjDataBase.IpAddress] == DBNull.Value ? null : objRow[conQxPrjDataBase.IpAddress].ToString().Trim(); //IP地址
objQxPrjDataBaseEN.SID = objRow[conQxPrjDataBase.SID] == DBNull.Value ? null : objRow[conQxPrjDataBase.SID].ToString().Trim(); //SID
objQxPrjDataBaseEN.TableSpace = objRow[conQxPrjDataBase.TableSpace] == DBNull.Value ? null : objRow[conQxPrjDataBase.TableSpace].ToString().Trim(); //表空间
objQxPrjDataBaseEN.UserId = objRow[conQxPrjDataBase.UserId] == DBNull.Value ? null : objRow[conQxPrjDataBase.UserId].ToString().Trim(); //用户ID
objQxPrjDataBaseEN.UpdDate = objRow[conQxPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[conQxPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objQxPrjDataBaseEN.Memo = objRow[conQxPrjDataBase.Memo] == DBNull.Value ? null : objRow[conQxPrjDataBase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjDataBaseEN.QxPrjDataBaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjDataBaseEN);
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
public static IEnumerable<clsQxPrjDataBaseEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsQxPrjDataBaseEN objQxPrjDataBaseCond, string strOrderBy)
{
List<clsQxPrjDataBaseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxPrjDataBaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxPrjDataBase.AttributeName)
{
if (objQxPrjDataBaseCond.IsUpdated(strFldName) == false) continue;
if (objQxPrjDataBaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxPrjDataBaseCond[strFldName].ToString());
}
else
{
if (objQxPrjDataBaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxPrjDataBaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxPrjDataBaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxPrjDataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxPrjDataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxPrjDataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxPrjDataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxPrjDataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxPrjDataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxPrjDataBaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxPrjDataBaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxPrjDataBaseCond[strFldName]));
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
public static IEnumerable<clsQxPrjDataBaseEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsQxPrjDataBaseEN objQxPrjDataBaseCond = JsonConvert.DeserializeObject<clsQxPrjDataBaseEN>(objPagerPara.whereCond);
if (objQxPrjDataBaseCond.sfFldComparisonOp == null)
{
objQxPrjDataBaseCond.dicFldComparisonOp = null;
}
else
{
objQxPrjDataBaseCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objQxPrjDataBaseCond.sfFldComparisonOp);
}
clsQxPrjDataBaseBL.SetUpdFlag(objQxPrjDataBaseCond);
 try
{
CheckProperty4Condition(objQxPrjDataBaseCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsQxPrjDataBaseBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objQxPrjDataBaseCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPrjDataBaseEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsQxPrjDataBaseEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsQxPrjDataBaseEN> arrObjLst = new List<clsQxPrjDataBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjDataBaseEN objQxPrjDataBaseEN = new clsQxPrjDataBaseEN();
try
{
objQxPrjDataBaseEN.QxPrjDataBaseId = objRow[conQxPrjDataBase.QxPrjDataBaseId].ToString().Trim(); //项目数据库Id
objQxPrjDataBaseEN.PrjDataBaseName = objRow[conQxPrjDataBase.PrjDataBaseName] == DBNull.Value ? null : objRow[conQxPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objQxPrjDataBaseEN.DataBaseName = objRow[conQxPrjDataBase.DataBaseName] == DBNull.Value ? null : objRow[conQxPrjDataBase.DataBaseName].ToString().Trim(); //数据库名称
objQxPrjDataBaseEN.DatabaseOwner = objRow[conQxPrjDataBase.DatabaseOwner] == DBNull.Value ? null : objRow[conQxPrjDataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objQxPrjDataBaseEN.DataBasePwd = objRow[conQxPrjDataBase.DataBasePwd] == DBNull.Value ? null : objRow[conQxPrjDataBase.DataBasePwd].ToString().Trim(); //数据库用户口令
objQxPrjDataBaseEN.DataBaseTypeId = objRow[conQxPrjDataBase.DataBaseTypeId] == DBNull.Value ? null : objRow[conQxPrjDataBase.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objQxPrjDataBaseEN.DataBaseUserId = objRow[conQxPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[conQxPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库用户Id
objQxPrjDataBaseEN.IpAddress = objRow[conQxPrjDataBase.IpAddress] == DBNull.Value ? null : objRow[conQxPrjDataBase.IpAddress].ToString().Trim(); //IP地址
objQxPrjDataBaseEN.SID = objRow[conQxPrjDataBase.SID] == DBNull.Value ? null : objRow[conQxPrjDataBase.SID].ToString().Trim(); //SID
objQxPrjDataBaseEN.TableSpace = objRow[conQxPrjDataBase.TableSpace] == DBNull.Value ? null : objRow[conQxPrjDataBase.TableSpace].ToString().Trim(); //表空间
objQxPrjDataBaseEN.UserId = objRow[conQxPrjDataBase.UserId] == DBNull.Value ? null : objRow[conQxPrjDataBase.UserId].ToString().Trim(); //用户ID
objQxPrjDataBaseEN.UpdDate = objRow[conQxPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[conQxPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objQxPrjDataBaseEN.Memo = objRow[conQxPrjDataBase.Memo] == DBNull.Value ? null : objRow[conQxPrjDataBase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjDataBaseEN.QxPrjDataBaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjDataBaseEN);
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
public static List<clsQxPrjDataBaseEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsQxPrjDataBaseEN> arrObjLst = new List<clsQxPrjDataBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjDataBaseEN objQxPrjDataBaseEN = new clsQxPrjDataBaseEN();
try
{
objQxPrjDataBaseEN.QxPrjDataBaseId = objRow[conQxPrjDataBase.QxPrjDataBaseId].ToString().Trim(); //项目数据库Id
objQxPrjDataBaseEN.PrjDataBaseName = objRow[conQxPrjDataBase.PrjDataBaseName] == DBNull.Value ? null : objRow[conQxPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objQxPrjDataBaseEN.DataBaseName = objRow[conQxPrjDataBase.DataBaseName] == DBNull.Value ? null : objRow[conQxPrjDataBase.DataBaseName].ToString().Trim(); //数据库名称
objQxPrjDataBaseEN.DatabaseOwner = objRow[conQxPrjDataBase.DatabaseOwner] == DBNull.Value ? null : objRow[conQxPrjDataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objQxPrjDataBaseEN.DataBasePwd = objRow[conQxPrjDataBase.DataBasePwd] == DBNull.Value ? null : objRow[conQxPrjDataBase.DataBasePwd].ToString().Trim(); //数据库用户口令
objQxPrjDataBaseEN.DataBaseTypeId = objRow[conQxPrjDataBase.DataBaseTypeId] == DBNull.Value ? null : objRow[conQxPrjDataBase.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objQxPrjDataBaseEN.DataBaseUserId = objRow[conQxPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[conQxPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库用户Id
objQxPrjDataBaseEN.IpAddress = objRow[conQxPrjDataBase.IpAddress] == DBNull.Value ? null : objRow[conQxPrjDataBase.IpAddress].ToString().Trim(); //IP地址
objQxPrjDataBaseEN.SID = objRow[conQxPrjDataBase.SID] == DBNull.Value ? null : objRow[conQxPrjDataBase.SID].ToString().Trim(); //SID
objQxPrjDataBaseEN.TableSpace = objRow[conQxPrjDataBase.TableSpace] == DBNull.Value ? null : objRow[conQxPrjDataBase.TableSpace].ToString().Trim(); //表空间
objQxPrjDataBaseEN.UserId = objRow[conQxPrjDataBase.UserId] == DBNull.Value ? null : objRow[conQxPrjDataBase.UserId].ToString().Trim(); //用户ID
objQxPrjDataBaseEN.UpdDate = objRow[conQxPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[conQxPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objQxPrjDataBaseEN.Memo = objRow[conQxPrjDataBase.Memo] == DBNull.Value ? null : objRow[conQxPrjDataBase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjDataBaseEN.QxPrjDataBaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjDataBaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPrjDataBaseEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsQxPrjDataBaseEN> arrObjLst = new List<clsQxPrjDataBaseEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjDataBaseEN objQxPrjDataBaseEN = new clsQxPrjDataBaseEN();
try
{
objQxPrjDataBaseEN.QxPrjDataBaseId = objRow[conQxPrjDataBase.QxPrjDataBaseId].ToString().Trim(); //项目数据库Id
objQxPrjDataBaseEN.PrjDataBaseName = objRow[conQxPrjDataBase.PrjDataBaseName] == DBNull.Value ? null : objRow[conQxPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objQxPrjDataBaseEN.DataBaseName = objRow[conQxPrjDataBase.DataBaseName] == DBNull.Value ? null : objRow[conQxPrjDataBase.DataBaseName].ToString().Trim(); //数据库名称
objQxPrjDataBaseEN.DatabaseOwner = objRow[conQxPrjDataBase.DatabaseOwner] == DBNull.Value ? null : objRow[conQxPrjDataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objQxPrjDataBaseEN.DataBasePwd = objRow[conQxPrjDataBase.DataBasePwd] == DBNull.Value ? null : objRow[conQxPrjDataBase.DataBasePwd].ToString().Trim(); //数据库用户口令
objQxPrjDataBaseEN.DataBaseTypeId = objRow[conQxPrjDataBase.DataBaseTypeId] == DBNull.Value ? null : objRow[conQxPrjDataBase.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objQxPrjDataBaseEN.DataBaseUserId = objRow[conQxPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[conQxPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库用户Id
objQxPrjDataBaseEN.IpAddress = objRow[conQxPrjDataBase.IpAddress] == DBNull.Value ? null : objRow[conQxPrjDataBase.IpAddress].ToString().Trim(); //IP地址
objQxPrjDataBaseEN.SID = objRow[conQxPrjDataBase.SID] == DBNull.Value ? null : objRow[conQxPrjDataBase.SID].ToString().Trim(); //SID
objQxPrjDataBaseEN.TableSpace = objRow[conQxPrjDataBase.TableSpace] == DBNull.Value ? null : objRow[conQxPrjDataBase.TableSpace].ToString().Trim(); //表空间
objQxPrjDataBaseEN.UserId = objRow[conQxPrjDataBase.UserId] == DBNull.Value ? null : objRow[conQxPrjDataBase.UserId].ToString().Trim(); //用户ID
objQxPrjDataBaseEN.UpdDate = objRow[conQxPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[conQxPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objQxPrjDataBaseEN.Memo = objRow[conQxPrjDataBase.Memo] == DBNull.Value ? null : objRow[conQxPrjDataBase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjDataBaseEN.QxPrjDataBaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjDataBaseEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objQxPrjDataBaseEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxPrjDataBase(ref clsQxPrjDataBaseEN objQxPrjDataBaseEN)
{
bool bolResult = QxPrjDataBaseDA.GetQxPrjDataBase(ref objQxPrjDataBaseEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strQxPrjDataBaseId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxPrjDataBaseEN GetObjByQxPrjDataBaseId(string strQxPrjDataBaseId)
{
if (strQxPrjDataBaseId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strQxPrjDataBaseId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strQxPrjDataBaseId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strQxPrjDataBaseId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsQxPrjDataBaseEN objQxPrjDataBaseEN = QxPrjDataBaseDA.GetObjByQxPrjDataBaseId(strQxPrjDataBaseId);
return objQxPrjDataBaseEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsQxPrjDataBaseEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsQxPrjDataBaseEN objQxPrjDataBaseEN = QxPrjDataBaseDA.GetFirstObj(strWhereCond);
 return objQxPrjDataBaseEN;
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
public static clsQxPrjDataBaseEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsQxPrjDataBaseEN objQxPrjDataBaseEN = QxPrjDataBaseDA.GetObjByDataRow(objRow);
 return objQxPrjDataBaseEN;
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
public static clsQxPrjDataBaseEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsQxPrjDataBaseEN objQxPrjDataBaseEN = QxPrjDataBaseDA.GetObjByDataRow(objRow);
 return objQxPrjDataBaseEN;
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
 /// <param name = "strQxPrjDataBaseId">所给的关键字</param>
 /// <param name = "lstQxPrjDataBaseObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxPrjDataBaseEN GetObjByQxPrjDataBaseIdFromList(string strQxPrjDataBaseId, List<clsQxPrjDataBaseEN> lstQxPrjDataBaseObjLst)
{
foreach (clsQxPrjDataBaseEN objQxPrjDataBaseEN in lstQxPrjDataBaseObjLst)
{
if (objQxPrjDataBaseEN.QxPrjDataBaseId == strQxPrjDataBaseId)
{
return objQxPrjDataBaseEN;
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
 string strMaxQxPrjDataBaseId;
 try
 {
 strMaxQxPrjDataBaseId = clsQxPrjDataBaseDA.GetMaxStrId();
 return strMaxQxPrjDataBaseId;
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
 string strQxPrjDataBaseId;
 try
 {
 strQxPrjDataBaseId = new clsQxPrjDataBaseDA().GetFirstID(strWhereCond);
 return strQxPrjDataBaseId;
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
 arrList = QxPrjDataBaseDA.GetID(strWhereCond);
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
bool bolIsExist = QxPrjDataBaseDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strQxPrjDataBaseId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strQxPrjDataBaseId)
{
if (string.IsNullOrEmpty(strQxPrjDataBaseId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strQxPrjDataBaseId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = QxPrjDataBaseDA.IsExist(strQxPrjDataBaseId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strQxPrjDataBaseId">项目数据库Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strQxPrjDataBaseId, string strOpUser)
{
clsQxPrjDataBaseEN objQxPrjDataBaseEN = clsQxPrjDataBaseBL.GetObjByQxPrjDataBaseId(strQxPrjDataBaseId);
objQxPrjDataBaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
return clsQxPrjDataBaseBL.UpdateBySql2(objQxPrjDataBaseEN);
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
 bolIsExist = clsQxPrjDataBaseDA.IsExistTable();
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
 bolIsExist = QxPrjDataBaseDA.IsExistTable(strTabName);
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
 /// <param name = "objQxPrjDataBaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsQxPrjDataBaseEN objQxPrjDataBaseEN)
{
if (objQxPrjDataBaseEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!项目数据库名 = [{0}]的数据已经存在!(in clsQxPrjDataBaseBL.AddNewRecordBySql2)", objQxPrjDataBaseEN.PrjDataBaseName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQxPrjDataBaseEN.QxPrjDataBaseId) == true || clsQxPrjDataBaseBL.IsExist(objQxPrjDataBaseEN.QxPrjDataBaseId) == true)
 {
     objQxPrjDataBaseEN.QxPrjDataBaseId = clsQxPrjDataBaseBL.GetMaxStrId_S();
 }
bool bolResult = QxPrjDataBaseDA.AddNewRecordBySQL2(objQxPrjDataBaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjDataBaseBL.ReFreshCache();

if (clsQxPrjDataBaseBL.relatedActions != null)
{
clsQxPrjDataBaseBL.relatedActions.UpdRelaTabDate(objQxPrjDataBaseEN.QxPrjDataBaseId, "SetUpdDate");
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
 /// <param name = "objQxPrjDataBaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsQxPrjDataBaseEN objQxPrjDataBaseEN)
{
if (objQxPrjDataBaseEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!项目数据库名 = [{0}]的数据已经存在!(in clsQxPrjDataBaseBL.AddNewRecordBySql2WithReturnKey)", objQxPrjDataBaseEN.PrjDataBaseName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQxPrjDataBaseEN.QxPrjDataBaseId) == true || clsQxPrjDataBaseBL.IsExist(objQxPrjDataBaseEN.QxPrjDataBaseId) == true)
 {
     objQxPrjDataBaseEN.QxPrjDataBaseId = clsQxPrjDataBaseBL.GetMaxStrId_S();
 }
string strKey = QxPrjDataBaseDA.AddNewRecordBySQL2WithReturnKey(objQxPrjDataBaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjDataBaseBL.ReFreshCache();

if (clsQxPrjDataBaseBL.relatedActions != null)
{
clsQxPrjDataBaseBL.relatedActions.UpdRelaTabDate(objQxPrjDataBaseEN.QxPrjDataBaseId, "SetUpdDate");
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
 /// <param name = "strQxPrjDataBaseObjXml">代表实体对象的XML串</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql_XML(string strQxPrjDataBaseObjXml)
{
clsQxPrjDataBaseEN objQxPrjDataBaseEN = GetObjFromXmlStr(strQxPrjDataBaseObjXml);
try
{
bool bolResult = QxPrjDataBaseDA.AddNewRecordBySQL2(objQxPrjDataBaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjDataBaseBL.ReFreshCache();

if (clsQxPrjDataBaseBL.relatedActions != null)
{
clsQxPrjDataBaseBL.relatedActions.UpdRelaTabDate(objQxPrjDataBaseEN.QxPrjDataBaseId, "SetUpdDate");
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
 /// <param name = "objQxPrjDataBaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsQxPrjDataBaseEN objQxPrjDataBaseEN)
{
try
{
bool bolResult = QxPrjDataBaseDA.Update(objQxPrjDataBaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjDataBaseBL.ReFreshCache();

if (clsQxPrjDataBaseBL.relatedActions != null)
{
clsQxPrjDataBaseBL.relatedActions.UpdRelaTabDate(objQxPrjDataBaseEN.QxPrjDataBaseId, "SetUpdDate");
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
 /// <param name = "objQxPrjDataBaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsQxPrjDataBaseEN objQxPrjDataBaseEN)
{
 if (string.IsNullOrEmpty(objQxPrjDataBaseEN.QxPrjDataBaseId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = QxPrjDataBaseDA.UpdateBySql2(objQxPrjDataBaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjDataBaseBL.ReFreshCache();

if (clsQxPrjDataBaseBL.relatedActions != null)
{
clsQxPrjDataBaseBL.relatedActions.UpdRelaTabDate(objQxPrjDataBaseEN.QxPrjDataBaseId, "SetUpdDate");
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
 /// <param name = "strQxPrjDataBaseObjXml">需要修改的对象,用XML来表示</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql_XML(string strQxPrjDataBaseObjXml)
{
clsQxPrjDataBaseEN objQxPrjDataBaseEN = GetObjFromXmlStr(strQxPrjDataBaseObjXml);
try
{
bool bolResult = QxPrjDataBaseDA.UpdateBySql2(objQxPrjDataBaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjDataBaseBL.ReFreshCache();

if (clsQxPrjDataBaseBL.relatedActions != null)
{
clsQxPrjDataBaseBL.relatedActions.UpdRelaTabDate(objQxPrjDataBaseEN.QxPrjDataBaseId, "SetUpdDate");
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
 /// <param name = "strQxPrjDataBaseId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strQxPrjDataBaseId)
{
try
{
 clsQxPrjDataBaseEN objQxPrjDataBaseEN = clsQxPrjDataBaseBL.GetObjByQxPrjDataBaseId(strQxPrjDataBaseId);

if (clsQxPrjDataBaseBL.relatedActions != null)
{
clsQxPrjDataBaseBL.relatedActions.UpdRelaTabDate(objQxPrjDataBaseEN.QxPrjDataBaseId, "SetUpdDate");
}
if (objQxPrjDataBaseEN != null)
{
int intRecNum = QxPrjDataBaseDA.DelRecord(strQxPrjDataBaseId);
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
/// <param name="strQxPrjDataBaseId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strQxPrjDataBaseId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxPrjDataBaseDA.GetSpecSQLObj();
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
//删除与表:[QxPrjDataBase]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conQxPrjDataBase.QxPrjDataBaseId,
//strQxPrjDataBaseId);
//        clsQxPrjDataBaseBL.DelQxPrjDataBasesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxPrjDataBaseBL.DelRecord(strQxPrjDataBaseId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxPrjDataBaseBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strQxPrjDataBaseId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strQxPrjDataBaseId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strQxPrjDataBaseId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsQxPrjDataBaseBL.relatedActions != null)
{
clsQxPrjDataBaseBL.relatedActions.UpdRelaTabDate(strQxPrjDataBaseId, "UpdRelaTabDate");
}
bool bolResult = QxPrjDataBaseDA.DelRecord(strQxPrjDataBaseId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "strQxPrjDataBaseId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strQxPrjDataBaseId) 
{
try
{
if (clsQxPrjDataBaseBL.relatedActions != null)
{
clsQxPrjDataBaseBL.relatedActions.UpdRelaTabDate(strQxPrjDataBaseId, "UpdRelaTabDate");
}
bool bolResult = QxPrjDataBaseDA.DelRecordBySP(strQxPrjDataBaseId);
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
 /// <param name = "arrQxPrjDataBaseIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelQxPrjDataBases(List<string> arrQxPrjDataBaseIdLst)
{
if (arrQxPrjDataBaseIdLst.Count == 0) return 0;
try
{
if (clsQxPrjDataBaseBL.relatedActions != null)
{
foreach (var strQxPrjDataBaseId in arrQxPrjDataBaseIdLst)
{
clsQxPrjDataBaseBL.relatedActions.UpdRelaTabDate(strQxPrjDataBaseId, "UpdRelaTabDate");
}
}
int intDelRecNum = QxPrjDataBaseDA.DelQxPrjDataBase(arrQxPrjDataBaseIdLst);
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
public static int DelQxPrjDataBasesByCond(string strWhereCond)
{
try
{
if (clsQxPrjDataBaseBL.relatedActions != null)
{
List<string> arrQxPrjDataBaseId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strQxPrjDataBaseId in arrQxPrjDataBaseId)
{
clsQxPrjDataBaseBL.relatedActions.UpdRelaTabDate(strQxPrjDataBaseId, "UpdRelaTabDate");
}
}
int intRecNum = QxPrjDataBaseDA.DelQxPrjDataBase(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[QxPrjDataBase]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strQxPrjDataBaseId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strQxPrjDataBaseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxPrjDataBaseDA.GetSpecSQLObj();
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
//删除与表:[QxPrjDataBase]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxPrjDataBaseBL.DelRecord(strQxPrjDataBaseId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxPrjDataBaseBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strQxPrjDataBaseId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objQxPrjDataBaseENS">源对象</param>
 /// <param name = "objQxPrjDataBaseENT">目标对象</param>
 public static void CopyTo(clsQxPrjDataBaseEN objQxPrjDataBaseENS, clsQxPrjDataBaseEN objQxPrjDataBaseENT)
{
try
{
objQxPrjDataBaseENT.QxPrjDataBaseId = objQxPrjDataBaseENS.QxPrjDataBaseId; //项目数据库Id
objQxPrjDataBaseENT.PrjDataBaseName = objQxPrjDataBaseENS.PrjDataBaseName; //项目数据库名
objQxPrjDataBaseENT.DataBaseName = objQxPrjDataBaseENS.DataBaseName; //数据库名称
objQxPrjDataBaseENT.DatabaseOwner = objQxPrjDataBaseENS.DatabaseOwner; //数据库拥有者
objQxPrjDataBaseENT.DataBasePwd = objQxPrjDataBaseENS.DataBasePwd; //数据库用户口令
objQxPrjDataBaseENT.DataBaseTypeId = objQxPrjDataBaseENS.DataBaseTypeId; //数据库类型ID
objQxPrjDataBaseENT.DataBaseUserId = objQxPrjDataBaseENS.DataBaseUserId; //数据库用户Id
objQxPrjDataBaseENT.IpAddress = objQxPrjDataBaseENS.IpAddress; //IP地址
objQxPrjDataBaseENT.SID = objQxPrjDataBaseENS.SID; //SID
objQxPrjDataBaseENT.TableSpace = objQxPrjDataBaseENS.TableSpace; //表空间
objQxPrjDataBaseENT.UserId = objQxPrjDataBaseENS.UserId; //用户ID
objQxPrjDataBaseENT.UpdDate = objQxPrjDataBaseENS.UpdDate; //修改日期
objQxPrjDataBaseENT.Memo = objQxPrjDataBaseENS.Memo; //备注
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
 /// <param name = "objQxPrjDataBaseEN">源简化对象</param>
 public static void SetUpdFlag(clsQxPrjDataBaseEN objQxPrjDataBaseEN)
{
try
{
objQxPrjDataBaseEN.ClearUpdateState();
   string strsfUpdFldSetStr = objQxPrjDataBaseEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conQxPrjDataBase.QxPrjDataBaseId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjDataBaseEN.QxPrjDataBaseId = objQxPrjDataBaseEN.QxPrjDataBaseId; //项目数据库Id
}
if (arrFldSet.Contains(conQxPrjDataBase.PrjDataBaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjDataBaseEN.PrjDataBaseName = objQxPrjDataBaseEN.PrjDataBaseName == "[null]" ? null :  objQxPrjDataBaseEN.PrjDataBaseName; //项目数据库名
}
if (arrFldSet.Contains(conQxPrjDataBase.DataBaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjDataBaseEN.DataBaseName = objQxPrjDataBaseEN.DataBaseName == "[null]" ? null :  objQxPrjDataBaseEN.DataBaseName; //数据库名称
}
if (arrFldSet.Contains(conQxPrjDataBase.DatabaseOwner, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjDataBaseEN.DatabaseOwner = objQxPrjDataBaseEN.DatabaseOwner == "[null]" ? null :  objQxPrjDataBaseEN.DatabaseOwner; //数据库拥有者
}
if (arrFldSet.Contains(conQxPrjDataBase.DataBasePwd, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjDataBaseEN.DataBasePwd = objQxPrjDataBaseEN.DataBasePwd == "[null]" ? null :  objQxPrjDataBaseEN.DataBasePwd; //数据库用户口令
}
if (arrFldSet.Contains(conQxPrjDataBase.DataBaseTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjDataBaseEN.DataBaseTypeId = objQxPrjDataBaseEN.DataBaseTypeId == "[null]" ? null :  objQxPrjDataBaseEN.DataBaseTypeId; //数据库类型ID
}
if (arrFldSet.Contains(conQxPrjDataBase.DataBaseUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjDataBaseEN.DataBaseUserId = objQxPrjDataBaseEN.DataBaseUserId == "[null]" ? null :  objQxPrjDataBaseEN.DataBaseUserId; //数据库用户Id
}
if (arrFldSet.Contains(conQxPrjDataBase.IpAddress, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjDataBaseEN.IpAddress = objQxPrjDataBaseEN.IpAddress == "[null]" ? null :  objQxPrjDataBaseEN.IpAddress; //IP地址
}
if (arrFldSet.Contains(conQxPrjDataBase.SID, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjDataBaseEN.SID = objQxPrjDataBaseEN.SID == "[null]" ? null :  objQxPrjDataBaseEN.SID; //SID
}
if (arrFldSet.Contains(conQxPrjDataBase.TableSpace, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjDataBaseEN.TableSpace = objQxPrjDataBaseEN.TableSpace == "[null]" ? null :  objQxPrjDataBaseEN.TableSpace; //表空间
}
if (arrFldSet.Contains(conQxPrjDataBase.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjDataBaseEN.UserId = objQxPrjDataBaseEN.UserId == "[null]" ? null :  objQxPrjDataBaseEN.UserId; //用户ID
}
if (arrFldSet.Contains(conQxPrjDataBase.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjDataBaseEN.UpdDate = objQxPrjDataBaseEN.UpdDate == "[null]" ? null :  objQxPrjDataBaseEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conQxPrjDataBase.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjDataBaseEN.Memo = objQxPrjDataBaseEN.Memo == "[null]" ? null :  objQxPrjDataBaseEN.Memo; //备注
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
 /// <param name = "objQxPrjDataBaseEN">源简化对象</param>
 public static void AccessFldValueNull(clsQxPrjDataBaseEN objQxPrjDataBaseEN)
{
try
{
if (objQxPrjDataBaseEN.PrjDataBaseName == "[null]") objQxPrjDataBaseEN.PrjDataBaseName = null; //项目数据库名
if (objQxPrjDataBaseEN.DataBaseName == "[null]") objQxPrjDataBaseEN.DataBaseName = null; //数据库名称
if (objQxPrjDataBaseEN.DatabaseOwner == "[null]") objQxPrjDataBaseEN.DatabaseOwner = null; //数据库拥有者
if (objQxPrjDataBaseEN.DataBasePwd == "[null]") objQxPrjDataBaseEN.DataBasePwd = null; //数据库用户口令
if (objQxPrjDataBaseEN.DataBaseTypeId == "[null]") objQxPrjDataBaseEN.DataBaseTypeId = null; //数据库类型ID
if (objQxPrjDataBaseEN.DataBaseUserId == "[null]") objQxPrjDataBaseEN.DataBaseUserId = null; //数据库用户Id
if (objQxPrjDataBaseEN.IpAddress == "[null]") objQxPrjDataBaseEN.IpAddress = null; //IP地址
if (objQxPrjDataBaseEN.SID == "[null]") objQxPrjDataBaseEN.SID = null; //SID
if (objQxPrjDataBaseEN.TableSpace == "[null]") objQxPrjDataBaseEN.TableSpace = null; //表空间
if (objQxPrjDataBaseEN.UserId == "[null]") objQxPrjDataBaseEN.UserId = null; //用户ID
if (objQxPrjDataBaseEN.UpdDate == "[null]") objQxPrjDataBaseEN.UpdDate = null; //修改日期
if (objQxPrjDataBaseEN.Memo == "[null]") objQxPrjDataBaseEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsQxPrjDataBaseEN objQxPrjDataBaseEN)
{
 QxPrjDataBaseDA.CheckPropertyNew(objQxPrjDataBaseEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsQxPrjDataBaseEN objQxPrjDataBaseEN)
{
 QxPrjDataBaseDA.CheckProperty4Condition(objQxPrjDataBaseEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_QxPrjDataBaseId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conQxPrjDataBase.QxPrjDataBaseId); 
List<clsQxPrjDataBaseEN> arrObjLst = clsQxPrjDataBaseBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsQxPrjDataBaseEN objQxPrjDataBaseEN = new clsQxPrjDataBaseEN()
{
QxPrjDataBaseId = "0",
PrjDataBaseName = "选[数据库对象]..."
};
arrObjLst.Insert(0, objQxPrjDataBaseEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conQxPrjDataBase.QxPrjDataBaseId;
objComboBox.DisplayMember = conQxPrjDataBase.PrjDataBaseName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_QxPrjDataBaseId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[数据库对象]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conQxPrjDataBase.QxPrjDataBaseId); 
IEnumerable<clsQxPrjDataBaseEN> arrObjLst = clsQxPrjDataBaseBL.GetObjLst(strCondition);
objDDL.DataValueField = conQxPrjDataBase.QxPrjDataBaseId;
objDDL.DataTextField = conQxPrjDataBase.PrjDataBaseName;
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
public static void BindDdl_QxPrjDataBaseIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[数据库对象]...","0");
List<clsQxPrjDataBaseEN> arrQxPrjDataBaseObjLst = GetAllQxPrjDataBaseObjLstCache(); 
objDDL.DataValueField = conQxPrjDataBase.QxPrjDataBaseId;
objDDL.DataTextField = conQxPrjDataBase.PrjDataBaseName;
objDDL.DataSource = arrQxPrjDataBaseObjLst;
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
if (clsQxPrjDataBaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxPrjDataBaseBL没有刷新缓存机制(clsQxPrjDataBaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by QxPrjDataBaseId");
//if (arrQxPrjDataBaseObjLstCache == null)
//{
//arrQxPrjDataBaseObjLstCache = QxPrjDataBaseDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strQxPrjDataBaseId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxPrjDataBaseEN GetObjByQxPrjDataBaseIdCache(string strQxPrjDataBaseId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsQxPrjDataBaseEN._CurrTabName);
List<clsQxPrjDataBaseEN> arrQxPrjDataBaseObjLstCache = GetObjLstCache();
IEnumerable <clsQxPrjDataBaseEN> arrQxPrjDataBaseObjLst_Sel =
arrQxPrjDataBaseObjLstCache
.Where(x=> x.QxPrjDataBaseId == strQxPrjDataBaseId 
);
if (arrQxPrjDataBaseObjLst_Sel.Count() == 0)
{
   clsQxPrjDataBaseEN obj = clsQxPrjDataBaseBL.GetObjByQxPrjDataBaseId(strQxPrjDataBaseId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrQxPrjDataBaseObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strQxPrjDataBaseId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetPrjDataBaseNameByQxPrjDataBaseIdCache(string strQxPrjDataBaseId)
{
if (string.IsNullOrEmpty(strQxPrjDataBaseId) == true) return "";
//获取缓存中的对象列表
clsQxPrjDataBaseEN objQxPrjDataBase = GetObjByQxPrjDataBaseIdCache(strQxPrjDataBaseId);
if (objQxPrjDataBase == null) return "";
return objQxPrjDataBase.PrjDataBaseName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strQxPrjDataBaseId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByQxPrjDataBaseIdCache(string strQxPrjDataBaseId)
{
if (string.IsNullOrEmpty(strQxPrjDataBaseId) == true) return "";
//获取缓存中的对象列表
clsQxPrjDataBaseEN objQxPrjDataBase = GetObjByQxPrjDataBaseIdCache(strQxPrjDataBaseId);
if (objQxPrjDataBase == null) return "";
return objQxPrjDataBase.PrjDataBaseName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxPrjDataBaseEN> GetAllQxPrjDataBaseObjLstCache()
{
//获取缓存中的对象列表
List<clsQxPrjDataBaseEN> arrQxPrjDataBaseObjLstCache = GetObjLstCache(); 
return arrQxPrjDataBaseObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxPrjDataBaseEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsQxPrjDataBaseEN._CurrTabName);
List<clsQxPrjDataBaseEN> arrQxPrjDataBaseObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrQxPrjDataBaseObjLstCache;
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
string strKey = string.Format("{0}", clsQxPrjDataBaseEN._CurrTabName);
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
if (clsQxPrjDataBaseBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsQxPrjDataBaseEN._CurrTabName);
CacheHelper.Remove(strKey);
clsQxPrjDataBaseBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--QxPrjDataBase(数据库对象)
 /// 唯一性条件:PrjDataBaseName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQxPrjDataBaseEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsQxPrjDataBaseEN objQxPrjDataBaseEN)
{
//检测记录是否存在
string strResult = QxPrjDataBaseDA.GetUniCondStr(objQxPrjDataBaseEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstQxPrjDataBaseObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsQxPrjDataBaseEN> lstQxPrjDataBaseObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstQxPrjDataBaseObjLst, writer);
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
 /// <param name = "lstQxPrjDataBaseObjLst">[clsQxPrjDataBaseEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsQxPrjDataBaseEN> lstQxPrjDataBaseObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsQxPrjDataBaseBL.listXmlNode);
writer.WriteStartElement(clsQxPrjDataBaseBL.itemsXmlNode);
foreach (clsQxPrjDataBaseEN objQxPrjDataBaseEN in lstQxPrjDataBaseObjLst)
{
clsQxPrjDataBaseBL.SerializeXML(writer, objQxPrjDataBaseEN);
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
 /// <param name = "objQxPrjDataBaseEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsQxPrjDataBaseEN objQxPrjDataBaseEN)
{
writer.WriteStartElement(clsQxPrjDataBaseBL.itemXmlNode);
 
if (objQxPrjDataBaseEN.QxPrjDataBaseId != null)
{
writer.WriteElementString(conQxPrjDataBase.QxPrjDataBaseId, objQxPrjDataBaseEN.QxPrjDataBaseId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjDataBaseEN.PrjDataBaseName != null)
{
writer.WriteElementString(conQxPrjDataBase.PrjDataBaseName, objQxPrjDataBaseEN.PrjDataBaseName.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjDataBaseEN.DataBaseName != null)
{
writer.WriteElementString(conQxPrjDataBase.DataBaseName, objQxPrjDataBaseEN.DataBaseName.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjDataBaseEN.DatabaseOwner != null)
{
writer.WriteElementString(conQxPrjDataBase.DatabaseOwner, objQxPrjDataBaseEN.DatabaseOwner.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjDataBaseEN.DataBasePwd != null)
{
writer.WriteElementString(conQxPrjDataBase.DataBasePwd, objQxPrjDataBaseEN.DataBasePwd.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjDataBaseEN.DataBaseTypeId != null)
{
writer.WriteElementString(conQxPrjDataBase.DataBaseTypeId, objQxPrjDataBaseEN.DataBaseTypeId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjDataBaseEN.DataBaseUserId != null)
{
writer.WriteElementString(conQxPrjDataBase.DataBaseUserId, objQxPrjDataBaseEN.DataBaseUserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjDataBaseEN.IpAddress != null)
{
writer.WriteElementString(conQxPrjDataBase.IpAddress, objQxPrjDataBaseEN.IpAddress.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjDataBaseEN.SID != null)
{
writer.WriteElementString(conQxPrjDataBase.SID, objQxPrjDataBaseEN.SID.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjDataBaseEN.TableSpace != null)
{
writer.WriteElementString(conQxPrjDataBase.TableSpace, objQxPrjDataBaseEN.TableSpace.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjDataBaseEN.UserId != null)
{
writer.WriteElementString(conQxPrjDataBase.UserId, objQxPrjDataBaseEN.UserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjDataBaseEN.UpdDate != null)
{
writer.WriteElementString(conQxPrjDataBase.UpdDate, objQxPrjDataBaseEN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjDataBaseEN.Memo != null)
{
writer.WriteElementString(conQxPrjDataBase.Memo, objQxPrjDataBaseEN.Memo.ToString(CultureInfo.InvariantCulture));
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
public static clsQxPrjDataBaseEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsQxPrjDataBaseEN objQxPrjDataBaseEN = new clsQxPrjDataBaseEN();
reader.Read();
while (!(reader.Name == clsQxPrjDataBaseBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(conQxPrjDataBase.QxPrjDataBaseId))
{
objQxPrjDataBaseEN.QxPrjDataBaseId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjDataBase.PrjDataBaseName))
{
objQxPrjDataBaseEN.PrjDataBaseName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjDataBase.DataBaseName))
{
objQxPrjDataBaseEN.DataBaseName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjDataBase.DatabaseOwner))
{
objQxPrjDataBaseEN.DatabaseOwner = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjDataBase.DataBasePwd))
{
objQxPrjDataBaseEN.DataBasePwd = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjDataBase.DataBaseTypeId))
{
objQxPrjDataBaseEN.DataBaseTypeId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjDataBase.DataBaseUserId))
{
objQxPrjDataBaseEN.DataBaseUserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjDataBase.IpAddress))
{
objQxPrjDataBaseEN.IpAddress = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjDataBase.SID))
{
objQxPrjDataBaseEN.SID = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjDataBase.TableSpace))
{
objQxPrjDataBaseEN.TableSpace = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjDataBase.UserId))
{
objQxPrjDataBaseEN.UserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjDataBase.UpdDate))
{
objQxPrjDataBaseEN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjDataBase.Memo))
{
objQxPrjDataBaseEN.Memo = reader.ReadElementContentAsString();
}
}
return objQxPrjDataBaseEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strQxPrjDataBaseObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsQxPrjDataBaseEN GetObjFromXmlStr(string strQxPrjDataBaseObjXmlStr)
{
clsQxPrjDataBaseEN objQxPrjDataBaseEN = new clsQxPrjDataBaseEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strQxPrjDataBaseObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsQxPrjDataBaseBL.itemXmlNode))
{
objQxPrjDataBaseEN = GetObjFromXml(reader);
return objQxPrjDataBaseEN;
}
}
return objQxPrjDataBaseEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objQxPrjDataBaseEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsQxPrjDataBaseEN objQxPrjDataBaseEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objQxPrjDataBaseEN);
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
public static string Func(string strInFldName, string strOutFldName, string strQxPrjDataBaseId)
{
if (strInFldName != conQxPrjDataBase.QxPrjDataBaseId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conQxPrjDataBase.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conQxPrjDataBase.AttributeName));
throw new Exception(strMsg);
}
var objQxPrjDataBase = clsQxPrjDataBaseBL.GetObjByQxPrjDataBaseIdCache(strQxPrjDataBaseId);
if (objQxPrjDataBase == null) return "";
return objQxPrjDataBase[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objQxPrjDataBaseEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsQxPrjDataBaseEN objQxPrjDataBaseEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsQxPrjDataBaseEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objQxPrjDataBaseEN[strField]);
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
 /// <param name = "lstQxPrjDataBaseObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsQxPrjDataBaseEN> lstQxPrjDataBaseObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstQxPrjDataBaseObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsQxPrjDataBaseEN objQxPrjDataBaseEN in lstQxPrjDataBaseObjLst)
{
string strJSON_One = SerializeObjToJSON(objQxPrjDataBaseEN);
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
int intRecCount = clsQxPrjDataBaseDA.GetRecCount(strTabName);
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
int intRecCount = clsQxPrjDataBaseDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsQxPrjDataBaseDA.GetRecCount();
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
int intRecCount = clsQxPrjDataBaseDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objQxPrjDataBaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsQxPrjDataBaseEN objQxPrjDataBaseCond)
{
List<clsQxPrjDataBaseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxPrjDataBaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxPrjDataBase.AttributeName)
{
if (objQxPrjDataBaseCond.IsUpdated(strFldName) == false) continue;
if (objQxPrjDataBaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxPrjDataBaseCond[strFldName].ToString());
}
else
{
if (objQxPrjDataBaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxPrjDataBaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxPrjDataBaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxPrjDataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxPrjDataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxPrjDataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxPrjDataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxPrjDataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxPrjDataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxPrjDataBaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxPrjDataBaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxPrjDataBaseCond[strFldName]));
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
 List<string> arrList = clsQxPrjDataBaseDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = QxPrjDataBaseDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = QxPrjDataBaseDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = QxPrjDataBaseDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxPrjDataBaseDA.SetFldValue(clsQxPrjDataBaseEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = QxPrjDataBaseDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxPrjDataBaseDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxPrjDataBaseDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxPrjDataBaseDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[QxPrjDataBase] "); 
 strCreateTabCode.Append(" ( "); 
 // /**项目数据库Id*/ 
 strCreateTabCode.Append(" QxPrjDataBaseId char(4) primary key, "); 
 // /**项目数据库名*/ 
 strCreateTabCode.Append(" PrjDataBaseName varchar(50) Null, "); 
 // /**数据库名称*/ 
 strCreateTabCode.Append(" DataBaseName varchar(30) Null, "); 
 // /**数据库拥有者*/ 
 strCreateTabCode.Append(" DatabaseOwner varchar(30) Null, "); 
 // /**数据库用户口令*/ 
 strCreateTabCode.Append(" DataBasePwd varchar(20) Null, "); 
 // /**数据库类型ID*/ 
 strCreateTabCode.Append(" DataBaseTypeId char(2) Null, "); 
 // /**数据库用户Id*/ 
 strCreateTabCode.Append(" DataBaseUserId varchar(18) Null, "); 
 // /**IP地址*/ 
 strCreateTabCode.Append(" IpAddress varchar(23) Null, "); 
 // /**SID*/ 
 strCreateTabCode.Append(" SID varchar(30) Null, "); 
 // /**表空间*/ 
 strCreateTabCode.Append(" TableSpace varchar(30) Null, "); 
 // /**用户ID*/ 
 strCreateTabCode.Append(" UserId varchar(18) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
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
 /// 数据库对象(QxPrjDataBase)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4QxPrjDataBase : clsCommFun4BL
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
clsQxPrjDataBaseBL.ReFreshThisCache();
}
}

}