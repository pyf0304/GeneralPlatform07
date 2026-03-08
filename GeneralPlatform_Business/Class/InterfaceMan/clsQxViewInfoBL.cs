
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxViewInfoBL
 表名:QxViewInfo(00140017)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:23:30
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:界面管理(InterfaceMan)
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
public static class  clsQxViewInfoBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strViewId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxViewInfoEN GetObj(this K_ViewId_QxViewInfo myKey)
{
clsQxViewInfoEN objQxViewInfoEN = clsQxViewInfoBL.QxViewInfoDA.GetObjByViewId(myKey.Value);
return objQxViewInfoEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQxViewInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQxViewInfoEN objQxViewInfoEN)
{
 if (string.IsNullOrEmpty(objQxViewInfoEN.ViewId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQxViewInfoBL.IsExist(objQxViewInfoEN.ViewId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQxViewInfoEN.ViewId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (CheckUniqueness(objQxViewInfoEN) == false)
{
var strMsg = string.Format("记录已经存在!界面名称 = [{0}],项目Id = [{1}]的数据已经存在!(in clsQxViewInfoBL.AddNewRecord)", objQxViewInfoEN.ViewName,objQxViewInfoEN.QxPrjId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsQxViewInfoBL.QxViewInfoDA.AddNewRecordBySQL2(objQxViewInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxViewInfoBL.ReFreshCache();

if (clsQxViewInfoBL.relatedActions != null)
{
clsQxViewInfoBL.relatedActions.UpdRelaTabDate(objQxViewInfoEN.ViewId, objQxViewInfoEN.UpdUserId);
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
public static bool AddRecordEx(this clsQxViewInfoEN objQxViewInfoEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsQxViewInfoBL.IsExist(objQxViewInfoEN.ViewId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objQxViewInfoEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objQxViewInfoEN.CheckUniqueness() == false)
{
strMsg = string.Format("(界面名称(ViewName)=[{0}],项目Id(QxPrjId)=[{1}])已经存在,不能重复!", objQxViewInfoEN.ViewName, objQxViewInfoEN.QxPrjId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objQxViewInfoEN.AddNewRecord();
}
catch(Exception objException)
{
strMsg = "(errid:Busi000152)添加记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true;
}

 // 表:QxViewInfo的主键是前缀自增,但该表中没有一个相关的前缀字段。请检查!(In AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithMaxId)

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objQxViewInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsQxViewInfoEN objQxViewInfoEN)
{
 if (string.IsNullOrEmpty(objQxViewInfoEN.ViewId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQxViewInfoBL.IsExist(objQxViewInfoEN.ViewId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQxViewInfoEN.ViewId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (CheckUniqueness(objQxViewInfoEN) == false)
{
var strMsg = string.Format("记录已经存在!界面名称 = [{0}],项目Id = [{1}]的数据已经存在!(in clsQxViewInfoBL.AddNewRecordWithReturnKey)", objQxViewInfoEN.ViewName,objQxViewInfoEN.QxPrjId);
throw new Exception(strMsg);
}
try
{
string strKey = clsQxViewInfoBL.QxViewInfoDA.AddNewRecordBySQL2WithReturnKey(objQxViewInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxViewInfoBL.ReFreshCache();

if (clsQxViewInfoBL.relatedActions != null)
{
clsQxViewInfoBL.relatedActions.UpdRelaTabDate(objQxViewInfoEN.ViewId, objQxViewInfoEN.UpdUserId);
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
 /// <param name = "objQxViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxViewInfoEN SetViewId(this clsQxViewInfoEN objQxViewInfoEN, string strViewId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewId, 8, conQxViewInfo.ViewId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strViewId, 8, conQxViewInfo.ViewId);
}
objQxViewInfoEN.ViewId = strViewId; //界面编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxViewInfoEN.dicFldComparisonOp.ContainsKey(conQxViewInfo.ViewId) == false)
{
objQxViewInfoEN.dicFldComparisonOp.Add(conQxViewInfo.ViewId, strComparisonOp);
}
else
{
objQxViewInfoEN.dicFldComparisonOp[conQxViewInfo.ViewId] = strComparisonOp;
}
}
return objQxViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxViewInfoEN SetViewName(this clsQxViewInfoEN objQxViewInfoEN, string strViewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewName, conQxViewInfo.ViewName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewName, 100, conQxViewInfo.ViewName);
}
objQxViewInfoEN.ViewName = strViewName; //界面名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxViewInfoEN.dicFldComparisonOp.ContainsKey(conQxViewInfo.ViewName) == false)
{
objQxViewInfoEN.dicFldComparisonOp.Add(conQxViewInfo.ViewName, strComparisonOp);
}
else
{
objQxViewInfoEN.dicFldComparisonOp[conQxViewInfo.ViewName] = strComparisonOp;
}
}
return objQxViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxViewInfoEN SetViewCnName(this clsQxViewInfoEN objQxViewInfoEN, string strViewCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewCnName, conQxViewInfo.ViewCnName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewCnName, 50, conQxViewInfo.ViewCnName);
}
objQxViewInfoEN.ViewCnName = strViewCnName; //界面中文名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxViewInfoEN.dicFldComparisonOp.ContainsKey(conQxViewInfo.ViewCnName) == false)
{
objQxViewInfoEN.dicFldComparisonOp.Add(conQxViewInfo.ViewCnName, strComparisonOp);
}
else
{
objQxViewInfoEN.dicFldComparisonOp[conQxViewInfo.ViewCnName] = strComparisonOp;
}
}
return objQxViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxViewInfoEN SetFileName(this clsQxViewInfoEN objQxViewInfoEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFileName, conQxViewInfo.FileName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileName, 500, conQxViewInfo.FileName);
}
objQxViewInfoEN.FileName = strFileName; //文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxViewInfoEN.dicFldComparisonOp.ContainsKey(conQxViewInfo.FileName) == false)
{
objQxViewInfoEN.dicFldComparisonOp.Add(conQxViewInfo.FileName, strComparisonOp);
}
else
{
objQxViewInfoEN.dicFldComparisonOp[conQxViewInfo.FileName] = strComparisonOp;
}
}
return objQxViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxViewInfoEN SetFilePath(this clsQxViewInfoEN objQxViewInfoEN, string strFilePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFilePath, conQxViewInfo.FilePath);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFilePath, 500, conQxViewInfo.FilePath);
}
objQxViewInfoEN.FilePath = strFilePath; //文件路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxViewInfoEN.dicFldComparisonOp.ContainsKey(conQxViewInfo.FilePath) == false)
{
objQxViewInfoEN.dicFldComparisonOp.Add(conQxViewInfo.FilePath, strComparisonOp);
}
else
{
objQxViewInfoEN.dicFldComparisonOp[conQxViewInfo.FilePath] = strComparisonOp;
}
}
return objQxViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxViewInfoEN SetDefaMenuName(this clsQxViewInfoEN objQxViewInfoEN, string strDefaMenuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDefaMenuName, conQxViewInfo.DefaMenuName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDefaMenuName, 50, conQxViewInfo.DefaMenuName);
}
objQxViewInfoEN.DefaMenuName = strDefaMenuName; //缺省菜单名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxViewInfoEN.dicFldComparisonOp.ContainsKey(conQxViewInfo.DefaMenuName) == false)
{
objQxViewInfoEN.dicFldComparisonOp.Add(conQxViewInfo.DefaMenuName, strComparisonOp);
}
else
{
objQxViewInfoEN.dicFldComparisonOp[conQxViewInfo.DefaMenuName] = strComparisonOp;
}
}
return objQxViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxViewInfoEN SetViewTypeCode(this clsQxViewInfoEN objQxViewInfoEN, string strViewTypeCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewTypeCode, conQxViewInfo.ViewTypeCode);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewTypeCode, 4, conQxViewInfo.ViewTypeCode);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strViewTypeCode, 4, conQxViewInfo.ViewTypeCode);
}
objQxViewInfoEN.ViewTypeCode = strViewTypeCode; //界面类型码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxViewInfoEN.dicFldComparisonOp.ContainsKey(conQxViewInfo.ViewTypeCode) == false)
{
objQxViewInfoEN.dicFldComparisonOp.Add(conQxViewInfo.ViewTypeCode, strComparisonOp);
}
else
{
objQxViewInfoEN.dicFldComparisonOp[conQxViewInfo.ViewTypeCode] = strComparisonOp;
}
}
return objQxViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxViewInfoEN SetDataBaseName(this clsQxViewInfoEN objQxViewInfoEN, string strDataBaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataBaseName, 30, conQxViewInfo.DataBaseName);
}
objQxViewInfoEN.DataBaseName = strDataBaseName; //数据库名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxViewInfoEN.dicFldComparisonOp.ContainsKey(conQxViewInfo.DataBaseName) == false)
{
objQxViewInfoEN.dicFldComparisonOp.Add(conQxViewInfo.DataBaseName, strComparisonOp);
}
else
{
objQxViewInfoEN.dicFldComparisonOp[conQxViewInfo.DataBaseName] = strComparisonOp;
}
}
return objQxViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxViewInfoEN SetQxPrjId(this clsQxViewInfoEN objQxViewInfoEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, conQxViewInfo.QxPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQxPrjId, 4, conQxViewInfo.QxPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, conQxViewInfo.QxPrjId);
}
objQxViewInfoEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxViewInfoEN.dicFldComparisonOp.ContainsKey(conQxViewInfo.QxPrjId) == false)
{
objQxViewInfoEN.dicFldComparisonOp.Add(conQxViewInfo.QxPrjId, strComparisonOp);
}
else
{
objQxViewInfoEN.dicFldComparisonOp[conQxViewInfo.QxPrjId] = strComparisonOp;
}
}
return objQxViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxViewInfoEN SetViewFunction(this clsQxViewInfoEN objQxViewInfoEN, string strViewFunction, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewFunction, 100, conQxViewInfo.ViewFunction);
}
objQxViewInfoEN.ViewFunction = strViewFunction; //界面功能
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxViewInfoEN.dicFldComparisonOp.ContainsKey(conQxViewInfo.ViewFunction) == false)
{
objQxViewInfoEN.dicFldComparisonOp.Add(conQxViewInfo.ViewFunction, strComparisonOp);
}
else
{
objQxViewInfoEN.dicFldComparisonOp[conQxViewInfo.ViewFunction] = strComparisonOp;
}
}
return objQxViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxViewInfoEN SetViewDetail(this clsQxViewInfoEN objQxViewInfoEN, string strViewDetail, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewDetail, 1000, conQxViewInfo.ViewDetail);
}
objQxViewInfoEN.ViewDetail = strViewDetail; //界面详细信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxViewInfoEN.dicFldComparisonOp.ContainsKey(conQxViewInfo.ViewDetail) == false)
{
objQxViewInfoEN.dicFldComparisonOp.Add(conQxViewInfo.ViewDetail, strComparisonOp);
}
else
{
objQxViewInfoEN.dicFldComparisonOp[conQxViewInfo.ViewDetail] = strComparisonOp;
}
}
return objQxViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxViewInfoEN SetModuleId(this clsQxViewInfoEN objQxViewInfoEN, string strModuleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strModuleId, 6, conQxViewInfo.ModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strModuleId, 6, conQxViewInfo.ModuleId);
}
objQxViewInfoEN.ModuleId = strModuleId; //模块号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxViewInfoEN.dicFldComparisonOp.ContainsKey(conQxViewInfo.ModuleId) == false)
{
objQxViewInfoEN.dicFldComparisonOp.Add(conQxViewInfo.ModuleId, strComparisonOp);
}
else
{
objQxViewInfoEN.dicFldComparisonOp[conQxViewInfo.ModuleId] = strComparisonOp;
}
}
return objQxViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxViewInfoEN SetUpdDate(this clsQxViewInfoEN objQxViewInfoEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQxViewInfo.UpdDate);
}
objQxViewInfoEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxViewInfoEN.dicFldComparisonOp.ContainsKey(conQxViewInfo.UpdDate) == false)
{
objQxViewInfoEN.dicFldComparisonOp.Add(conQxViewInfo.UpdDate, strComparisonOp);
}
else
{
objQxViewInfoEN.dicFldComparisonOp[conQxViewInfo.UpdDate] = strComparisonOp;
}
}
return objQxViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxViewInfoEN SetUpdUserId(this clsQxViewInfoEN objQxViewInfoEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conQxViewInfo.UpdUserId);
}
objQxViewInfoEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxViewInfoEN.dicFldComparisonOp.ContainsKey(conQxViewInfo.UpdUserId) == false)
{
objQxViewInfoEN.dicFldComparisonOp.Add(conQxViewInfo.UpdUserId, strComparisonOp);
}
else
{
objQxViewInfoEN.dicFldComparisonOp[conQxViewInfo.UpdUserId] = strComparisonOp;
}
}
return objQxViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxViewInfoEN SetMemo(this clsQxViewInfoEN objQxViewInfoEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQxViewInfo.Memo);
}
objQxViewInfoEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxViewInfoEN.dicFldComparisonOp.ContainsKey(conQxViewInfo.Memo) == false)
{
objQxViewInfoEN.dicFldComparisonOp.Add(conQxViewInfo.Memo, strComparisonOp);
}
else
{
objQxViewInfoEN.dicFldComparisonOp[conQxViewInfo.Memo] = strComparisonOp;
}
}
return objQxViewInfoEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objQxViewInfoEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsQxViewInfoEN objQxViewInfoEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objQxViewInfoEN.CheckPropertyNew();
clsQxViewInfoEN objQxViewInfoCond = new clsQxViewInfoEN();
string strCondition = objQxViewInfoCond
.SetViewId(objQxViewInfoEN.ViewId, "<>")
.SetViewName(objQxViewInfoEN.ViewName, "=")
.SetQxPrjId(objQxViewInfoEN.QxPrjId, "=")
.GetCombineCondition();
objQxViewInfoEN._IsCheckProperty = true;
bool bolIsExist = clsQxViewInfoBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(ViewName_QxPrjId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objQxViewInfoEN.Update();
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
 /// <param name = "objQxViewInfo">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsQxViewInfoEN objQxViewInfo)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsQxViewInfoEN objQxViewInfoCond = new clsQxViewInfoEN();
string strCondition = objQxViewInfoCond
.SetViewName(objQxViewInfo.ViewName, "=")
.SetQxPrjId(objQxViewInfo.QxPrjId, "=")
.GetCombineCondition();
objQxViewInfo._IsCheckProperty = true;
bool bolIsExist = clsQxViewInfoBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objQxViewInfo.ViewId = clsQxViewInfoBL.GetFirstID_S(strCondition);
objQxViewInfo.UpdateWithCondition(strCondition);
}
else
{
objQxViewInfo.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objQxViewInfoEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxViewInfoEN objQxViewInfoEN)
{
 if (string.IsNullOrEmpty(objQxViewInfoEN.ViewId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxViewInfoBL.QxViewInfoDA.UpdateBySql2(objQxViewInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxViewInfoBL.ReFreshCache();

if (clsQxViewInfoBL.relatedActions != null)
{
clsQxViewInfoBL.relatedActions.UpdRelaTabDate(objQxViewInfoEN.ViewId, objQxViewInfoEN.UpdUserId);
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
 /// <param name = "objQxViewInfoEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxViewInfoEN objQxViewInfoEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objQxViewInfoEN.ViewId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxViewInfoBL.QxViewInfoDA.UpdateBySql2(objQxViewInfoEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxViewInfoBL.ReFreshCache();

if (clsQxViewInfoBL.relatedActions != null)
{
clsQxViewInfoBL.relatedActions.UpdRelaTabDate(objQxViewInfoEN.ViewId, objQxViewInfoEN.UpdUserId);
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
 /// <param name = "objQxViewInfoEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxViewInfoEN objQxViewInfoEN, string strWhereCond)
{
try
{
bool bolResult = clsQxViewInfoBL.QxViewInfoDA.UpdateBySqlWithCondition(objQxViewInfoEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxViewInfoBL.ReFreshCache();

if (clsQxViewInfoBL.relatedActions != null)
{
clsQxViewInfoBL.relatedActions.UpdRelaTabDate(objQxViewInfoEN.ViewId, objQxViewInfoEN.UpdUserId);
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
 /// <param name = "objQxViewInfoEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxViewInfoEN objQxViewInfoEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsQxViewInfoBL.QxViewInfoDA.UpdateBySqlWithConditionTransaction(objQxViewInfoEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxViewInfoBL.ReFreshCache();

if (clsQxViewInfoBL.relatedActions != null)
{
clsQxViewInfoBL.relatedActions.UpdRelaTabDate(objQxViewInfoEN.ViewId, objQxViewInfoEN.UpdUserId);
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
 /// <param name = "strViewId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsQxViewInfoEN objQxViewInfoEN)
{
try
{
int intRecNum = clsQxViewInfoBL.QxViewInfoDA.DelRecord(objQxViewInfoEN.ViewId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxViewInfoBL.ReFreshCache();

if (clsQxViewInfoBL.relatedActions != null)
{
clsQxViewInfoBL.relatedActions.UpdRelaTabDate(objQxViewInfoEN.ViewId, objQxViewInfoEN.UpdUserId);
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
 /// <param name = "objQxViewInfoENS">源对象</param>
 /// <param name = "objQxViewInfoENT">目标对象</param>
 public static void CopyTo(this clsQxViewInfoEN objQxViewInfoENS, clsQxViewInfoEN objQxViewInfoENT)
{
try
{
objQxViewInfoENT.ViewId = objQxViewInfoENS.ViewId; //界面编号
objQxViewInfoENT.ViewName = objQxViewInfoENS.ViewName; //界面名称
objQxViewInfoENT.ViewCnName = objQxViewInfoENS.ViewCnName; //界面中文名称
objQxViewInfoENT.FileName = objQxViewInfoENS.FileName; //文件名
objQxViewInfoENT.FilePath = objQxViewInfoENS.FilePath; //文件路径
objQxViewInfoENT.DefaMenuName = objQxViewInfoENS.DefaMenuName; //缺省菜单名
objQxViewInfoENT.ViewTypeCode = objQxViewInfoENS.ViewTypeCode; //界面类型码
objQxViewInfoENT.DataBaseName = objQxViewInfoENS.DataBaseName; //数据库名称
objQxViewInfoENT.QxPrjId = objQxViewInfoENS.QxPrjId; //项目Id
objQxViewInfoENT.ViewFunction = objQxViewInfoENS.ViewFunction; //界面功能
objQxViewInfoENT.ViewDetail = objQxViewInfoENS.ViewDetail; //界面详细信息
objQxViewInfoENT.ModuleId = objQxViewInfoENS.ModuleId; //模块号
objQxViewInfoENT.UpdDate = objQxViewInfoENS.UpdDate; //修改日期
objQxViewInfoENT.UpdUserId = objQxViewInfoENS.UpdUserId; //修改用户Id
objQxViewInfoENT.Memo = objQxViewInfoENS.Memo; //备注
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
 /// <param name = "objQxViewInfoENS">源对象</param>
 /// <returns>目标对象=>clsQxViewInfoEN:objQxViewInfoENT</returns>
 public static clsQxViewInfoEN CopyTo(this clsQxViewInfoEN objQxViewInfoENS)
{
try
{
 clsQxViewInfoEN objQxViewInfoENT = new clsQxViewInfoEN()
{
ViewId = objQxViewInfoENS.ViewId, //界面编号
ViewName = objQxViewInfoENS.ViewName, //界面名称
ViewCnName = objQxViewInfoENS.ViewCnName, //界面中文名称
FileName = objQxViewInfoENS.FileName, //文件名
FilePath = objQxViewInfoENS.FilePath, //文件路径
DefaMenuName = objQxViewInfoENS.DefaMenuName, //缺省菜单名
ViewTypeCode = objQxViewInfoENS.ViewTypeCode, //界面类型码
DataBaseName = objQxViewInfoENS.DataBaseName, //数据库名称
QxPrjId = objQxViewInfoENS.QxPrjId, //项目Id
ViewFunction = objQxViewInfoENS.ViewFunction, //界面功能
ViewDetail = objQxViewInfoENS.ViewDetail, //界面详细信息
ModuleId = objQxViewInfoENS.ModuleId, //模块号
UpdDate = objQxViewInfoENS.UpdDate, //修改日期
UpdUserId = objQxViewInfoENS.UpdUserId, //修改用户Id
Memo = objQxViewInfoENS.Memo, //备注
};
 return objQxViewInfoENT;
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
public static void CheckPropertyNew(this clsQxViewInfoEN objQxViewInfoEN)
{
 clsQxViewInfoBL.QxViewInfoDA.CheckPropertyNew(objQxViewInfoEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsQxViewInfoEN objQxViewInfoEN)
{
 clsQxViewInfoBL.QxViewInfoDA.CheckProperty4Condition(objQxViewInfoEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQxViewInfoEN objQxViewInfoCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQxViewInfoCond.IsUpdated(conQxViewInfo.ViewId) == true)
{
string strComparisonOpViewId = objQxViewInfoCond.dicFldComparisonOp[conQxViewInfo.ViewId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxViewInfo.ViewId, objQxViewInfoCond.ViewId, strComparisonOpViewId);
}
if (objQxViewInfoCond.IsUpdated(conQxViewInfo.ViewName) == true)
{
string strComparisonOpViewName = objQxViewInfoCond.dicFldComparisonOp[conQxViewInfo.ViewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxViewInfo.ViewName, objQxViewInfoCond.ViewName, strComparisonOpViewName);
}
if (objQxViewInfoCond.IsUpdated(conQxViewInfo.ViewCnName) == true)
{
string strComparisonOpViewCnName = objQxViewInfoCond.dicFldComparisonOp[conQxViewInfo.ViewCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxViewInfo.ViewCnName, objQxViewInfoCond.ViewCnName, strComparisonOpViewCnName);
}
if (objQxViewInfoCond.IsUpdated(conQxViewInfo.FileName) == true)
{
string strComparisonOpFileName = objQxViewInfoCond.dicFldComparisonOp[conQxViewInfo.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxViewInfo.FileName, objQxViewInfoCond.FileName, strComparisonOpFileName);
}
if (objQxViewInfoCond.IsUpdated(conQxViewInfo.FilePath) == true)
{
string strComparisonOpFilePath = objQxViewInfoCond.dicFldComparisonOp[conQxViewInfo.FilePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxViewInfo.FilePath, objQxViewInfoCond.FilePath, strComparisonOpFilePath);
}
if (objQxViewInfoCond.IsUpdated(conQxViewInfo.DefaMenuName) == true)
{
string strComparisonOpDefaMenuName = objQxViewInfoCond.dicFldComparisonOp[conQxViewInfo.DefaMenuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxViewInfo.DefaMenuName, objQxViewInfoCond.DefaMenuName, strComparisonOpDefaMenuName);
}
if (objQxViewInfoCond.IsUpdated(conQxViewInfo.ViewTypeCode) == true)
{
string strComparisonOpViewTypeCode = objQxViewInfoCond.dicFldComparisonOp[conQxViewInfo.ViewTypeCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxViewInfo.ViewTypeCode, objQxViewInfoCond.ViewTypeCode, strComparisonOpViewTypeCode);
}
if (objQxViewInfoCond.IsUpdated(conQxViewInfo.DataBaseName) == true)
{
string strComparisonOpDataBaseName = objQxViewInfoCond.dicFldComparisonOp[conQxViewInfo.DataBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxViewInfo.DataBaseName, objQxViewInfoCond.DataBaseName, strComparisonOpDataBaseName);
}
if (objQxViewInfoCond.IsUpdated(conQxViewInfo.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objQxViewInfoCond.dicFldComparisonOp[conQxViewInfo.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxViewInfo.QxPrjId, objQxViewInfoCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objQxViewInfoCond.IsUpdated(conQxViewInfo.ViewFunction) == true)
{
string strComparisonOpViewFunction = objQxViewInfoCond.dicFldComparisonOp[conQxViewInfo.ViewFunction];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxViewInfo.ViewFunction, objQxViewInfoCond.ViewFunction, strComparisonOpViewFunction);
}
if (objQxViewInfoCond.IsUpdated(conQxViewInfo.ViewDetail) == true)
{
string strComparisonOpViewDetail = objQxViewInfoCond.dicFldComparisonOp[conQxViewInfo.ViewDetail];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxViewInfo.ViewDetail, objQxViewInfoCond.ViewDetail, strComparisonOpViewDetail);
}
if (objQxViewInfoCond.IsUpdated(conQxViewInfo.ModuleId) == true)
{
string strComparisonOpModuleId = objQxViewInfoCond.dicFldComparisonOp[conQxViewInfo.ModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxViewInfo.ModuleId, objQxViewInfoCond.ModuleId, strComparisonOpModuleId);
}
if (objQxViewInfoCond.IsUpdated(conQxViewInfo.UpdDate) == true)
{
string strComparisonOpUpdDate = objQxViewInfoCond.dicFldComparisonOp[conQxViewInfo.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxViewInfo.UpdDate, objQxViewInfoCond.UpdDate, strComparisonOpUpdDate);
}
if (objQxViewInfoCond.IsUpdated(conQxViewInfo.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objQxViewInfoCond.dicFldComparisonOp[conQxViewInfo.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxViewInfo.UpdUserId, objQxViewInfoCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objQxViewInfoCond.IsUpdated(conQxViewInfo.Memo) == true)
{
string strComparisonOpMemo = objQxViewInfoCond.dicFldComparisonOp[conQxViewInfo.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxViewInfo.Memo, objQxViewInfoCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--QxViewInfo(界面), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:ViewName_QxPrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objQxViewInfoEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsQxViewInfoEN objQxViewInfoEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objQxViewInfoEN == null) return true;
if (objQxViewInfoEN.ViewId == null || objQxViewInfoEN.ViewId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ViewName = '{0}'", objQxViewInfoEN.ViewName);
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxViewInfoEN.QxPrjId);
if (clsQxViewInfoBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("ViewId !=  '{0}'", objQxViewInfoEN.ViewId);
 sbCondition.AppendFormat(" and ViewName = '{0}'", objQxViewInfoEN.ViewName);
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxViewInfoEN.QxPrjId);
if (clsQxViewInfoBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--QxViewInfo(界面), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ViewName_QxPrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objQxViewInfoEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsQxViewInfoEN objQxViewInfoEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objQxViewInfoEN == null) return "";
if (objQxViewInfoEN.ViewId == null || objQxViewInfoEN.ViewId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ViewName = '{0}'", objQxViewInfoEN.ViewName);
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxViewInfoEN.QxPrjId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ViewId !=  '{0}'", objQxViewInfoEN.ViewId);
 sbCondition.AppendFormat(" and ViewName = '{0}'", objQxViewInfoEN.ViewName);
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxViewInfoEN.QxPrjId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_QxViewInfo
{
public virtual bool UpdRelaTabDate(string strViewId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 界面(QxViewInfo)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsQxViewInfoBL
{
public static RelatedActions_QxViewInfo relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "QxViewInfoListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "QxViewInfoList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsQxViewInfoEN> arrQxViewInfoObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsQxViewInfoDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsQxViewInfoDA QxViewInfoDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsQxViewInfoDA();
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
 public clsQxViewInfoBL()
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
if (string.IsNullOrEmpty(clsQxViewInfoEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxViewInfoEN._ConnectString);
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
objDS = QxViewInfoDA.GetDataSet(strWhereCond);
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
objDS = QxViewInfoDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = QxViewInfoDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_QxViewInfo(string strWhereCond)
{
DataTable objDT;
try
{
objDT = QxViewInfoDA.GetDataTable_QxViewInfo(strWhereCond);
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
objDT = QxViewInfoDA.GetDataTable(strWhereCond);
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
objDT = QxViewInfoDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = QxViewInfoDA.GetDataTable(strWhereCond, strTabName);
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
objDT = QxViewInfoDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = QxViewInfoDA.GetDataTable_Top(objTopPara);
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
objDT = QxViewInfoDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = QxViewInfoDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = QxViewInfoDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = QxViewInfoDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = QxViewInfoDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = QxViewInfoDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = QxViewInfoDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = QxViewInfoDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
 /// <param name = "arrViewIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsQxViewInfoEN> GetObjLstByViewIdLst(List<string> arrViewIdLst)
{
List<clsQxViewInfoEN> arrObjLst = new List<clsQxViewInfoEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrViewIdLst, true);
 string strWhereCond = string.Format("ViewId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxViewInfoEN objQxViewInfoEN = new clsQxViewInfoEN();
try
{
objQxViewInfoEN.ViewId = objRow[conQxViewInfo.ViewId].ToString().Trim(); //界面编号
objQxViewInfoEN.ViewName = objRow[conQxViewInfo.ViewName].ToString().Trim(); //界面名称
objQxViewInfoEN.ViewCnName = objRow[conQxViewInfo.ViewCnName].ToString().Trim(); //界面中文名称
objQxViewInfoEN.FileName = objRow[conQxViewInfo.FileName].ToString().Trim(); //文件名
objQxViewInfoEN.FilePath = objRow[conQxViewInfo.FilePath].ToString().Trim(); //文件路径
objQxViewInfoEN.DefaMenuName = objRow[conQxViewInfo.DefaMenuName].ToString().Trim(); //缺省菜单名
objQxViewInfoEN.ViewTypeCode = objRow[conQxViewInfo.ViewTypeCode].ToString().Trim(); //界面类型码
objQxViewInfoEN.DataBaseName = objRow[conQxViewInfo.DataBaseName] == DBNull.Value ? null : objRow[conQxViewInfo.DataBaseName].ToString().Trim(); //数据库名称
objQxViewInfoEN.QxPrjId = objRow[conQxViewInfo.QxPrjId].ToString().Trim(); //项目Id
objQxViewInfoEN.ViewFunction = objRow[conQxViewInfo.ViewFunction] == DBNull.Value ? null : objRow[conQxViewInfo.ViewFunction].ToString().Trim(); //界面功能
objQxViewInfoEN.ViewDetail = objRow[conQxViewInfo.ViewDetail] == DBNull.Value ? null : objRow[conQxViewInfo.ViewDetail].ToString().Trim(); //界面详细信息
objQxViewInfoEN.ModuleId = objRow[conQxViewInfo.ModuleId] == DBNull.Value ? null : objRow[conQxViewInfo.ModuleId].ToString().Trim(); //模块号
objQxViewInfoEN.UpdDate = objRow[conQxViewInfo.UpdDate] == DBNull.Value ? null : objRow[conQxViewInfo.UpdDate].ToString().Trim(); //修改日期
objQxViewInfoEN.UpdUserId = objRow[conQxViewInfo.UpdUserId] == DBNull.Value ? null : objRow[conQxViewInfo.UpdUserId].ToString().Trim(); //修改用户Id
objQxViewInfoEN.Memo = objRow[conQxViewInfo.Memo] == DBNull.Value ? null : objRow[conQxViewInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxViewInfoEN.ViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxViewInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrViewIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsQxViewInfoEN> GetObjLstByViewIdLstCache(List<string> arrViewIdLst)
{
string strKey = string.Format("{0}", clsQxViewInfoEN._CurrTabName);
List<clsQxViewInfoEN> arrQxViewInfoObjLstCache = GetObjLstCache();
IEnumerable <clsQxViewInfoEN> arrQxViewInfoObjLst_Sel =
arrQxViewInfoObjLstCache
.Where(x => arrViewIdLst.Contains(x.ViewId));
return arrQxViewInfoObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxViewInfoEN> GetObjLst(string strWhereCond)
{
List<clsQxViewInfoEN> arrObjLst = new List<clsQxViewInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxViewInfoEN objQxViewInfoEN = new clsQxViewInfoEN();
try
{
objQxViewInfoEN.ViewId = objRow[conQxViewInfo.ViewId].ToString().Trim(); //界面编号
objQxViewInfoEN.ViewName = objRow[conQxViewInfo.ViewName].ToString().Trim(); //界面名称
objQxViewInfoEN.ViewCnName = objRow[conQxViewInfo.ViewCnName].ToString().Trim(); //界面中文名称
objQxViewInfoEN.FileName = objRow[conQxViewInfo.FileName].ToString().Trim(); //文件名
objQxViewInfoEN.FilePath = objRow[conQxViewInfo.FilePath].ToString().Trim(); //文件路径
objQxViewInfoEN.DefaMenuName = objRow[conQxViewInfo.DefaMenuName].ToString().Trim(); //缺省菜单名
objQxViewInfoEN.ViewTypeCode = objRow[conQxViewInfo.ViewTypeCode].ToString().Trim(); //界面类型码
objQxViewInfoEN.DataBaseName = objRow[conQxViewInfo.DataBaseName] == DBNull.Value ? null : objRow[conQxViewInfo.DataBaseName].ToString().Trim(); //数据库名称
objQxViewInfoEN.QxPrjId = objRow[conQxViewInfo.QxPrjId].ToString().Trim(); //项目Id
objQxViewInfoEN.ViewFunction = objRow[conQxViewInfo.ViewFunction] == DBNull.Value ? null : objRow[conQxViewInfo.ViewFunction].ToString().Trim(); //界面功能
objQxViewInfoEN.ViewDetail = objRow[conQxViewInfo.ViewDetail] == DBNull.Value ? null : objRow[conQxViewInfo.ViewDetail].ToString().Trim(); //界面详细信息
objQxViewInfoEN.ModuleId = objRow[conQxViewInfo.ModuleId] == DBNull.Value ? null : objRow[conQxViewInfo.ModuleId].ToString().Trim(); //模块号
objQxViewInfoEN.UpdDate = objRow[conQxViewInfo.UpdDate] == DBNull.Value ? null : objRow[conQxViewInfo.UpdDate].ToString().Trim(); //修改日期
objQxViewInfoEN.UpdUserId = objRow[conQxViewInfo.UpdUserId] == DBNull.Value ? null : objRow[conQxViewInfo.UpdUserId].ToString().Trim(); //修改用户Id
objQxViewInfoEN.Memo = objRow[conQxViewInfo.Memo] == DBNull.Value ? null : objRow[conQxViewInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxViewInfoEN.ViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxViewInfoEN);
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
public static List<clsQxViewInfoEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsQxViewInfoEN> arrObjLst = new List<clsQxViewInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxViewInfoEN objQxViewInfoEN = new clsQxViewInfoEN();
try
{
objQxViewInfoEN.ViewId = objRow[conQxViewInfo.ViewId].ToString().Trim(); //界面编号
objQxViewInfoEN.ViewName = objRow[conQxViewInfo.ViewName].ToString().Trim(); //界面名称
objQxViewInfoEN.ViewCnName = objRow[conQxViewInfo.ViewCnName].ToString().Trim(); //界面中文名称
objQxViewInfoEN.FileName = objRow[conQxViewInfo.FileName].ToString().Trim(); //文件名
objQxViewInfoEN.FilePath = objRow[conQxViewInfo.FilePath].ToString().Trim(); //文件路径
objQxViewInfoEN.DefaMenuName = objRow[conQxViewInfo.DefaMenuName].ToString().Trim(); //缺省菜单名
objQxViewInfoEN.ViewTypeCode = objRow[conQxViewInfo.ViewTypeCode].ToString().Trim(); //界面类型码
objQxViewInfoEN.DataBaseName = objRow[conQxViewInfo.DataBaseName] == DBNull.Value ? null : objRow[conQxViewInfo.DataBaseName].ToString().Trim(); //数据库名称
objQxViewInfoEN.QxPrjId = objRow[conQxViewInfo.QxPrjId].ToString().Trim(); //项目Id
objQxViewInfoEN.ViewFunction = objRow[conQxViewInfo.ViewFunction] == DBNull.Value ? null : objRow[conQxViewInfo.ViewFunction].ToString().Trim(); //界面功能
objQxViewInfoEN.ViewDetail = objRow[conQxViewInfo.ViewDetail] == DBNull.Value ? null : objRow[conQxViewInfo.ViewDetail].ToString().Trim(); //界面详细信息
objQxViewInfoEN.ModuleId = objRow[conQxViewInfo.ModuleId] == DBNull.Value ? null : objRow[conQxViewInfo.ModuleId].ToString().Trim(); //模块号
objQxViewInfoEN.UpdDate = objRow[conQxViewInfo.UpdDate] == DBNull.Value ? null : objRow[conQxViewInfo.UpdDate].ToString().Trim(); //修改日期
objQxViewInfoEN.UpdUserId = objRow[conQxViewInfo.UpdUserId] == DBNull.Value ? null : objRow[conQxViewInfo.UpdUserId].ToString().Trim(); //修改用户Id
objQxViewInfoEN.Memo = objRow[conQxViewInfo.Memo] == DBNull.Value ? null : objRow[conQxViewInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxViewInfoEN.ViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxViewInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objQxViewInfoCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsQxViewInfoEN> GetSubObjLstCache(clsQxViewInfoEN objQxViewInfoCond)
{
List<clsQxViewInfoEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxViewInfoEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxViewInfo.AttributeName)
{
if (objQxViewInfoCond.IsUpdated(strFldName) == false) continue;
if (objQxViewInfoCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxViewInfoCond[strFldName].ToString());
}
else
{
if (objQxViewInfoCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxViewInfoCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxViewInfoCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxViewInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxViewInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxViewInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxViewInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxViewInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxViewInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxViewInfoCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxViewInfoCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxViewInfoCond[strFldName]));
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
public static List<clsQxViewInfoEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsQxViewInfoEN> arrObjLst = new List<clsQxViewInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxViewInfoEN objQxViewInfoEN = new clsQxViewInfoEN();
try
{
objQxViewInfoEN.ViewId = objRow[conQxViewInfo.ViewId].ToString().Trim(); //界面编号
objQxViewInfoEN.ViewName = objRow[conQxViewInfo.ViewName].ToString().Trim(); //界面名称
objQxViewInfoEN.ViewCnName = objRow[conQxViewInfo.ViewCnName].ToString().Trim(); //界面中文名称
objQxViewInfoEN.FileName = objRow[conQxViewInfo.FileName].ToString().Trim(); //文件名
objQxViewInfoEN.FilePath = objRow[conQxViewInfo.FilePath].ToString().Trim(); //文件路径
objQxViewInfoEN.DefaMenuName = objRow[conQxViewInfo.DefaMenuName].ToString().Trim(); //缺省菜单名
objQxViewInfoEN.ViewTypeCode = objRow[conQxViewInfo.ViewTypeCode].ToString().Trim(); //界面类型码
objQxViewInfoEN.DataBaseName = objRow[conQxViewInfo.DataBaseName] == DBNull.Value ? null : objRow[conQxViewInfo.DataBaseName].ToString().Trim(); //数据库名称
objQxViewInfoEN.QxPrjId = objRow[conQxViewInfo.QxPrjId].ToString().Trim(); //项目Id
objQxViewInfoEN.ViewFunction = objRow[conQxViewInfo.ViewFunction] == DBNull.Value ? null : objRow[conQxViewInfo.ViewFunction].ToString().Trim(); //界面功能
objQxViewInfoEN.ViewDetail = objRow[conQxViewInfo.ViewDetail] == DBNull.Value ? null : objRow[conQxViewInfo.ViewDetail].ToString().Trim(); //界面详细信息
objQxViewInfoEN.ModuleId = objRow[conQxViewInfo.ModuleId] == DBNull.Value ? null : objRow[conQxViewInfo.ModuleId].ToString().Trim(); //模块号
objQxViewInfoEN.UpdDate = objRow[conQxViewInfo.UpdDate] == DBNull.Value ? null : objRow[conQxViewInfo.UpdDate].ToString().Trim(); //修改日期
objQxViewInfoEN.UpdUserId = objRow[conQxViewInfo.UpdUserId] == DBNull.Value ? null : objRow[conQxViewInfo.UpdUserId].ToString().Trim(); //修改用户Id
objQxViewInfoEN.Memo = objRow[conQxViewInfo.Memo] == DBNull.Value ? null : objRow[conQxViewInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxViewInfoEN.ViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxViewInfoEN);
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
public static List<clsQxViewInfoEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsQxViewInfoEN> arrObjLst = new List<clsQxViewInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxViewInfoEN objQxViewInfoEN = new clsQxViewInfoEN();
try
{
objQxViewInfoEN.ViewId = objRow[conQxViewInfo.ViewId].ToString().Trim(); //界面编号
objQxViewInfoEN.ViewName = objRow[conQxViewInfo.ViewName].ToString().Trim(); //界面名称
objQxViewInfoEN.ViewCnName = objRow[conQxViewInfo.ViewCnName].ToString().Trim(); //界面中文名称
objQxViewInfoEN.FileName = objRow[conQxViewInfo.FileName].ToString().Trim(); //文件名
objQxViewInfoEN.FilePath = objRow[conQxViewInfo.FilePath].ToString().Trim(); //文件路径
objQxViewInfoEN.DefaMenuName = objRow[conQxViewInfo.DefaMenuName].ToString().Trim(); //缺省菜单名
objQxViewInfoEN.ViewTypeCode = objRow[conQxViewInfo.ViewTypeCode].ToString().Trim(); //界面类型码
objQxViewInfoEN.DataBaseName = objRow[conQxViewInfo.DataBaseName] == DBNull.Value ? null : objRow[conQxViewInfo.DataBaseName].ToString().Trim(); //数据库名称
objQxViewInfoEN.QxPrjId = objRow[conQxViewInfo.QxPrjId].ToString().Trim(); //项目Id
objQxViewInfoEN.ViewFunction = objRow[conQxViewInfo.ViewFunction] == DBNull.Value ? null : objRow[conQxViewInfo.ViewFunction].ToString().Trim(); //界面功能
objQxViewInfoEN.ViewDetail = objRow[conQxViewInfo.ViewDetail] == DBNull.Value ? null : objRow[conQxViewInfo.ViewDetail].ToString().Trim(); //界面详细信息
objQxViewInfoEN.ModuleId = objRow[conQxViewInfo.ModuleId] == DBNull.Value ? null : objRow[conQxViewInfo.ModuleId].ToString().Trim(); //模块号
objQxViewInfoEN.UpdDate = objRow[conQxViewInfo.UpdDate] == DBNull.Value ? null : objRow[conQxViewInfo.UpdDate].ToString().Trim(); //修改日期
objQxViewInfoEN.UpdUserId = objRow[conQxViewInfo.UpdUserId] == DBNull.Value ? null : objRow[conQxViewInfo.UpdUserId].ToString().Trim(); //修改用户Id
objQxViewInfoEN.Memo = objRow[conQxViewInfo.Memo] == DBNull.Value ? null : objRow[conQxViewInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxViewInfoEN.ViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxViewInfoEN);
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
List<clsQxViewInfoEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsQxViewInfoEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxViewInfoEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsQxViewInfoEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsQxViewInfoEN> arrObjLst = new List<clsQxViewInfoEN>(); 
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
	clsQxViewInfoEN objQxViewInfoEN = new clsQxViewInfoEN();
try
{
objQxViewInfoEN.ViewId = objRow[conQxViewInfo.ViewId].ToString().Trim(); //界面编号
objQxViewInfoEN.ViewName = objRow[conQxViewInfo.ViewName].ToString().Trim(); //界面名称
objQxViewInfoEN.ViewCnName = objRow[conQxViewInfo.ViewCnName].ToString().Trim(); //界面中文名称
objQxViewInfoEN.FileName = objRow[conQxViewInfo.FileName].ToString().Trim(); //文件名
objQxViewInfoEN.FilePath = objRow[conQxViewInfo.FilePath].ToString().Trim(); //文件路径
objQxViewInfoEN.DefaMenuName = objRow[conQxViewInfo.DefaMenuName].ToString().Trim(); //缺省菜单名
objQxViewInfoEN.ViewTypeCode = objRow[conQxViewInfo.ViewTypeCode].ToString().Trim(); //界面类型码
objQxViewInfoEN.DataBaseName = objRow[conQxViewInfo.DataBaseName] == DBNull.Value ? null : objRow[conQxViewInfo.DataBaseName].ToString().Trim(); //数据库名称
objQxViewInfoEN.QxPrjId = objRow[conQxViewInfo.QxPrjId].ToString().Trim(); //项目Id
objQxViewInfoEN.ViewFunction = objRow[conQxViewInfo.ViewFunction] == DBNull.Value ? null : objRow[conQxViewInfo.ViewFunction].ToString().Trim(); //界面功能
objQxViewInfoEN.ViewDetail = objRow[conQxViewInfo.ViewDetail] == DBNull.Value ? null : objRow[conQxViewInfo.ViewDetail].ToString().Trim(); //界面详细信息
objQxViewInfoEN.ModuleId = objRow[conQxViewInfo.ModuleId] == DBNull.Value ? null : objRow[conQxViewInfo.ModuleId].ToString().Trim(); //模块号
objQxViewInfoEN.UpdDate = objRow[conQxViewInfo.UpdDate] == DBNull.Value ? null : objRow[conQxViewInfo.UpdDate].ToString().Trim(); //修改日期
objQxViewInfoEN.UpdUserId = objRow[conQxViewInfo.UpdUserId] == DBNull.Value ? null : objRow[conQxViewInfo.UpdUserId].ToString().Trim(); //修改用户Id
objQxViewInfoEN.Memo = objRow[conQxViewInfo.Memo] == DBNull.Value ? null : objRow[conQxViewInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxViewInfoEN.ViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxViewInfoEN);
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
public static List<clsQxViewInfoEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsQxViewInfoEN> arrObjLst = new List<clsQxViewInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxViewInfoEN objQxViewInfoEN = new clsQxViewInfoEN();
try
{
objQxViewInfoEN.ViewId = objRow[conQxViewInfo.ViewId].ToString().Trim(); //界面编号
objQxViewInfoEN.ViewName = objRow[conQxViewInfo.ViewName].ToString().Trim(); //界面名称
objQxViewInfoEN.ViewCnName = objRow[conQxViewInfo.ViewCnName].ToString().Trim(); //界面中文名称
objQxViewInfoEN.FileName = objRow[conQxViewInfo.FileName].ToString().Trim(); //文件名
objQxViewInfoEN.FilePath = objRow[conQxViewInfo.FilePath].ToString().Trim(); //文件路径
objQxViewInfoEN.DefaMenuName = objRow[conQxViewInfo.DefaMenuName].ToString().Trim(); //缺省菜单名
objQxViewInfoEN.ViewTypeCode = objRow[conQxViewInfo.ViewTypeCode].ToString().Trim(); //界面类型码
objQxViewInfoEN.DataBaseName = objRow[conQxViewInfo.DataBaseName] == DBNull.Value ? null : objRow[conQxViewInfo.DataBaseName].ToString().Trim(); //数据库名称
objQxViewInfoEN.QxPrjId = objRow[conQxViewInfo.QxPrjId].ToString().Trim(); //项目Id
objQxViewInfoEN.ViewFunction = objRow[conQxViewInfo.ViewFunction] == DBNull.Value ? null : objRow[conQxViewInfo.ViewFunction].ToString().Trim(); //界面功能
objQxViewInfoEN.ViewDetail = objRow[conQxViewInfo.ViewDetail] == DBNull.Value ? null : objRow[conQxViewInfo.ViewDetail].ToString().Trim(); //界面详细信息
objQxViewInfoEN.ModuleId = objRow[conQxViewInfo.ModuleId] == DBNull.Value ? null : objRow[conQxViewInfo.ModuleId].ToString().Trim(); //模块号
objQxViewInfoEN.UpdDate = objRow[conQxViewInfo.UpdDate] == DBNull.Value ? null : objRow[conQxViewInfo.UpdDate].ToString().Trim(); //修改日期
objQxViewInfoEN.UpdUserId = objRow[conQxViewInfo.UpdUserId] == DBNull.Value ? null : objRow[conQxViewInfo.UpdUserId].ToString().Trim(); //修改用户Id
objQxViewInfoEN.Memo = objRow[conQxViewInfo.Memo] == DBNull.Value ? null : objRow[conQxViewInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxViewInfoEN.ViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxViewInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsQxViewInfoEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsQxViewInfoEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsQxViewInfoEN> arrObjLst = new List<clsQxViewInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxViewInfoEN objQxViewInfoEN = new clsQxViewInfoEN();
try
{
objQxViewInfoEN.ViewId = objRow[conQxViewInfo.ViewId].ToString().Trim(); //界面编号
objQxViewInfoEN.ViewName = objRow[conQxViewInfo.ViewName].ToString().Trim(); //界面名称
objQxViewInfoEN.ViewCnName = objRow[conQxViewInfo.ViewCnName].ToString().Trim(); //界面中文名称
objQxViewInfoEN.FileName = objRow[conQxViewInfo.FileName].ToString().Trim(); //文件名
objQxViewInfoEN.FilePath = objRow[conQxViewInfo.FilePath].ToString().Trim(); //文件路径
objQxViewInfoEN.DefaMenuName = objRow[conQxViewInfo.DefaMenuName].ToString().Trim(); //缺省菜单名
objQxViewInfoEN.ViewTypeCode = objRow[conQxViewInfo.ViewTypeCode].ToString().Trim(); //界面类型码
objQxViewInfoEN.DataBaseName = objRow[conQxViewInfo.DataBaseName] == DBNull.Value ? null : objRow[conQxViewInfo.DataBaseName].ToString().Trim(); //数据库名称
objQxViewInfoEN.QxPrjId = objRow[conQxViewInfo.QxPrjId].ToString().Trim(); //项目Id
objQxViewInfoEN.ViewFunction = objRow[conQxViewInfo.ViewFunction] == DBNull.Value ? null : objRow[conQxViewInfo.ViewFunction].ToString().Trim(); //界面功能
objQxViewInfoEN.ViewDetail = objRow[conQxViewInfo.ViewDetail] == DBNull.Value ? null : objRow[conQxViewInfo.ViewDetail].ToString().Trim(); //界面详细信息
objQxViewInfoEN.ModuleId = objRow[conQxViewInfo.ModuleId] == DBNull.Value ? null : objRow[conQxViewInfo.ModuleId].ToString().Trim(); //模块号
objQxViewInfoEN.UpdDate = objRow[conQxViewInfo.UpdDate] == DBNull.Value ? null : objRow[conQxViewInfo.UpdDate].ToString().Trim(); //修改日期
objQxViewInfoEN.UpdUserId = objRow[conQxViewInfo.UpdUserId] == DBNull.Value ? null : objRow[conQxViewInfo.UpdUserId].ToString().Trim(); //修改用户Id
objQxViewInfoEN.Memo = objRow[conQxViewInfo.Memo] == DBNull.Value ? null : objRow[conQxViewInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxViewInfoEN.ViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxViewInfoEN);
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
public static List<clsQxViewInfoEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsQxViewInfoEN> arrObjLst = new List<clsQxViewInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxViewInfoEN objQxViewInfoEN = new clsQxViewInfoEN();
try
{
objQxViewInfoEN.ViewId = objRow[conQxViewInfo.ViewId].ToString().Trim(); //界面编号
objQxViewInfoEN.ViewName = objRow[conQxViewInfo.ViewName].ToString().Trim(); //界面名称
objQxViewInfoEN.ViewCnName = objRow[conQxViewInfo.ViewCnName].ToString().Trim(); //界面中文名称
objQxViewInfoEN.FileName = objRow[conQxViewInfo.FileName].ToString().Trim(); //文件名
objQxViewInfoEN.FilePath = objRow[conQxViewInfo.FilePath].ToString().Trim(); //文件路径
objQxViewInfoEN.DefaMenuName = objRow[conQxViewInfo.DefaMenuName].ToString().Trim(); //缺省菜单名
objQxViewInfoEN.ViewTypeCode = objRow[conQxViewInfo.ViewTypeCode].ToString().Trim(); //界面类型码
objQxViewInfoEN.DataBaseName = objRow[conQxViewInfo.DataBaseName] == DBNull.Value ? null : objRow[conQxViewInfo.DataBaseName].ToString().Trim(); //数据库名称
objQxViewInfoEN.QxPrjId = objRow[conQxViewInfo.QxPrjId].ToString().Trim(); //项目Id
objQxViewInfoEN.ViewFunction = objRow[conQxViewInfo.ViewFunction] == DBNull.Value ? null : objRow[conQxViewInfo.ViewFunction].ToString().Trim(); //界面功能
objQxViewInfoEN.ViewDetail = objRow[conQxViewInfo.ViewDetail] == DBNull.Value ? null : objRow[conQxViewInfo.ViewDetail].ToString().Trim(); //界面详细信息
objQxViewInfoEN.ModuleId = objRow[conQxViewInfo.ModuleId] == DBNull.Value ? null : objRow[conQxViewInfo.ModuleId].ToString().Trim(); //模块号
objQxViewInfoEN.UpdDate = objRow[conQxViewInfo.UpdDate] == DBNull.Value ? null : objRow[conQxViewInfo.UpdDate].ToString().Trim(); //修改日期
objQxViewInfoEN.UpdUserId = objRow[conQxViewInfo.UpdUserId] == DBNull.Value ? null : objRow[conQxViewInfo.UpdUserId].ToString().Trim(); //修改用户Id
objQxViewInfoEN.Memo = objRow[conQxViewInfo.Memo] == DBNull.Value ? null : objRow[conQxViewInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxViewInfoEN.ViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxViewInfoEN);
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
public static IEnumerable<clsQxViewInfoEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsQxViewInfoEN objQxViewInfoCond, string strOrderBy)
{
List<clsQxViewInfoEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxViewInfoEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxViewInfo.AttributeName)
{
if (objQxViewInfoCond.IsUpdated(strFldName) == false) continue;
if (objQxViewInfoCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxViewInfoCond[strFldName].ToString());
}
else
{
if (objQxViewInfoCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxViewInfoCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxViewInfoCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxViewInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxViewInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxViewInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxViewInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxViewInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxViewInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxViewInfoCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxViewInfoCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxViewInfoCond[strFldName]));
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
public static IEnumerable<clsQxViewInfoEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsQxViewInfoEN objQxViewInfoCond = JsonConvert.DeserializeObject<clsQxViewInfoEN>(objPagerPara.whereCond);
if (objQxViewInfoCond.sfFldComparisonOp == null)
{
objQxViewInfoCond.dicFldComparisonOp = null;
}
else
{
objQxViewInfoCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objQxViewInfoCond.sfFldComparisonOp);
}
clsQxViewInfoBL.SetUpdFlag(objQxViewInfoCond);
 try
{
CheckProperty4Condition(objQxViewInfoCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsQxViewInfoBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objQxViewInfoCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxViewInfoEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsQxViewInfoEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsQxViewInfoEN> arrObjLst = new List<clsQxViewInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxViewInfoEN objQxViewInfoEN = new clsQxViewInfoEN();
try
{
objQxViewInfoEN.ViewId = objRow[conQxViewInfo.ViewId].ToString().Trim(); //界面编号
objQxViewInfoEN.ViewName = objRow[conQxViewInfo.ViewName].ToString().Trim(); //界面名称
objQxViewInfoEN.ViewCnName = objRow[conQxViewInfo.ViewCnName].ToString().Trim(); //界面中文名称
objQxViewInfoEN.FileName = objRow[conQxViewInfo.FileName].ToString().Trim(); //文件名
objQxViewInfoEN.FilePath = objRow[conQxViewInfo.FilePath].ToString().Trim(); //文件路径
objQxViewInfoEN.DefaMenuName = objRow[conQxViewInfo.DefaMenuName].ToString().Trim(); //缺省菜单名
objQxViewInfoEN.ViewTypeCode = objRow[conQxViewInfo.ViewTypeCode].ToString().Trim(); //界面类型码
objQxViewInfoEN.DataBaseName = objRow[conQxViewInfo.DataBaseName] == DBNull.Value ? null : objRow[conQxViewInfo.DataBaseName].ToString().Trim(); //数据库名称
objQxViewInfoEN.QxPrjId = objRow[conQxViewInfo.QxPrjId].ToString().Trim(); //项目Id
objQxViewInfoEN.ViewFunction = objRow[conQxViewInfo.ViewFunction] == DBNull.Value ? null : objRow[conQxViewInfo.ViewFunction].ToString().Trim(); //界面功能
objQxViewInfoEN.ViewDetail = objRow[conQxViewInfo.ViewDetail] == DBNull.Value ? null : objRow[conQxViewInfo.ViewDetail].ToString().Trim(); //界面详细信息
objQxViewInfoEN.ModuleId = objRow[conQxViewInfo.ModuleId] == DBNull.Value ? null : objRow[conQxViewInfo.ModuleId].ToString().Trim(); //模块号
objQxViewInfoEN.UpdDate = objRow[conQxViewInfo.UpdDate] == DBNull.Value ? null : objRow[conQxViewInfo.UpdDate].ToString().Trim(); //修改日期
objQxViewInfoEN.UpdUserId = objRow[conQxViewInfo.UpdUserId] == DBNull.Value ? null : objRow[conQxViewInfo.UpdUserId].ToString().Trim(); //修改用户Id
objQxViewInfoEN.Memo = objRow[conQxViewInfo.Memo] == DBNull.Value ? null : objRow[conQxViewInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxViewInfoEN.ViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxViewInfoEN);
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
public static List<clsQxViewInfoEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsQxViewInfoEN> arrObjLst = new List<clsQxViewInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxViewInfoEN objQxViewInfoEN = new clsQxViewInfoEN();
try
{
objQxViewInfoEN.ViewId = objRow[conQxViewInfo.ViewId].ToString().Trim(); //界面编号
objQxViewInfoEN.ViewName = objRow[conQxViewInfo.ViewName].ToString().Trim(); //界面名称
objQxViewInfoEN.ViewCnName = objRow[conQxViewInfo.ViewCnName].ToString().Trim(); //界面中文名称
objQxViewInfoEN.FileName = objRow[conQxViewInfo.FileName].ToString().Trim(); //文件名
objQxViewInfoEN.FilePath = objRow[conQxViewInfo.FilePath].ToString().Trim(); //文件路径
objQxViewInfoEN.DefaMenuName = objRow[conQxViewInfo.DefaMenuName].ToString().Trim(); //缺省菜单名
objQxViewInfoEN.ViewTypeCode = objRow[conQxViewInfo.ViewTypeCode].ToString().Trim(); //界面类型码
objQxViewInfoEN.DataBaseName = objRow[conQxViewInfo.DataBaseName] == DBNull.Value ? null : objRow[conQxViewInfo.DataBaseName].ToString().Trim(); //数据库名称
objQxViewInfoEN.QxPrjId = objRow[conQxViewInfo.QxPrjId].ToString().Trim(); //项目Id
objQxViewInfoEN.ViewFunction = objRow[conQxViewInfo.ViewFunction] == DBNull.Value ? null : objRow[conQxViewInfo.ViewFunction].ToString().Trim(); //界面功能
objQxViewInfoEN.ViewDetail = objRow[conQxViewInfo.ViewDetail] == DBNull.Value ? null : objRow[conQxViewInfo.ViewDetail].ToString().Trim(); //界面详细信息
objQxViewInfoEN.ModuleId = objRow[conQxViewInfo.ModuleId] == DBNull.Value ? null : objRow[conQxViewInfo.ModuleId].ToString().Trim(); //模块号
objQxViewInfoEN.UpdDate = objRow[conQxViewInfo.UpdDate] == DBNull.Value ? null : objRow[conQxViewInfo.UpdDate].ToString().Trim(); //修改日期
objQxViewInfoEN.UpdUserId = objRow[conQxViewInfo.UpdUserId] == DBNull.Value ? null : objRow[conQxViewInfo.UpdUserId].ToString().Trim(); //修改用户Id
objQxViewInfoEN.Memo = objRow[conQxViewInfo.Memo] == DBNull.Value ? null : objRow[conQxViewInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxViewInfoEN.ViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxViewInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxViewInfoEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsQxViewInfoEN> arrObjLst = new List<clsQxViewInfoEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxViewInfoEN objQxViewInfoEN = new clsQxViewInfoEN();
try
{
objQxViewInfoEN.ViewId = objRow[conQxViewInfo.ViewId].ToString().Trim(); //界面编号
objQxViewInfoEN.ViewName = objRow[conQxViewInfo.ViewName].ToString().Trim(); //界面名称
objQxViewInfoEN.ViewCnName = objRow[conQxViewInfo.ViewCnName].ToString().Trim(); //界面中文名称
objQxViewInfoEN.FileName = objRow[conQxViewInfo.FileName].ToString().Trim(); //文件名
objQxViewInfoEN.FilePath = objRow[conQxViewInfo.FilePath].ToString().Trim(); //文件路径
objQxViewInfoEN.DefaMenuName = objRow[conQxViewInfo.DefaMenuName].ToString().Trim(); //缺省菜单名
objQxViewInfoEN.ViewTypeCode = objRow[conQxViewInfo.ViewTypeCode].ToString().Trim(); //界面类型码
objQxViewInfoEN.DataBaseName = objRow[conQxViewInfo.DataBaseName] == DBNull.Value ? null : objRow[conQxViewInfo.DataBaseName].ToString().Trim(); //数据库名称
objQxViewInfoEN.QxPrjId = objRow[conQxViewInfo.QxPrjId].ToString().Trim(); //项目Id
objQxViewInfoEN.ViewFunction = objRow[conQxViewInfo.ViewFunction] == DBNull.Value ? null : objRow[conQxViewInfo.ViewFunction].ToString().Trim(); //界面功能
objQxViewInfoEN.ViewDetail = objRow[conQxViewInfo.ViewDetail] == DBNull.Value ? null : objRow[conQxViewInfo.ViewDetail].ToString().Trim(); //界面详细信息
objQxViewInfoEN.ModuleId = objRow[conQxViewInfo.ModuleId] == DBNull.Value ? null : objRow[conQxViewInfo.ModuleId].ToString().Trim(); //模块号
objQxViewInfoEN.UpdDate = objRow[conQxViewInfo.UpdDate] == DBNull.Value ? null : objRow[conQxViewInfo.UpdDate].ToString().Trim(); //修改日期
objQxViewInfoEN.UpdUserId = objRow[conQxViewInfo.UpdUserId] == DBNull.Value ? null : objRow[conQxViewInfo.UpdUserId].ToString().Trim(); //修改用户Id
objQxViewInfoEN.Memo = objRow[conQxViewInfo.Memo] == DBNull.Value ? null : objRow[conQxViewInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxViewInfoEN.ViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxViewInfoEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objQxViewInfoEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxViewInfo(ref clsQxViewInfoEN objQxViewInfoEN)
{
bool bolResult = QxViewInfoDA.GetQxViewInfo(ref objQxViewInfoEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strViewId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxViewInfoEN GetObjByViewId(string strViewId)
{
if (strViewId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strViewId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strViewId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strViewId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsQxViewInfoEN objQxViewInfoEN = QxViewInfoDA.GetObjByViewId(strViewId);
return objQxViewInfoEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsQxViewInfoEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsQxViewInfoEN objQxViewInfoEN = QxViewInfoDA.GetFirstObj(strWhereCond);
 return objQxViewInfoEN;
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
public static clsQxViewInfoEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsQxViewInfoEN objQxViewInfoEN = QxViewInfoDA.GetObjByDataRow(objRow);
 return objQxViewInfoEN;
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
public static clsQxViewInfoEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsQxViewInfoEN objQxViewInfoEN = QxViewInfoDA.GetObjByDataRow(objRow);
 return objQxViewInfoEN;
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
 /// <param name = "strViewId">所给的关键字</param>
 /// <param name = "lstQxViewInfoObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxViewInfoEN GetObjByViewIdFromList(string strViewId, List<clsQxViewInfoEN> lstQxViewInfoObjLst)
{
foreach (clsQxViewInfoEN objQxViewInfoEN in lstQxViewInfoObjLst)
{
if (objQxViewInfoEN.ViewId == strViewId)
{
return objQxViewInfoEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetMaxStrIdByPrefix_S)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefix_S(string strPrefix) 
{
if (string.IsNullOrEmpty(strPrefix) == true)
{
var strMsg = string.Format("前缀不能为空.(from {0})",
clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
 string strMaxViewId;
 try
 {
 strMaxViewId = new clsQxViewInfoDA().GetMaxStrIdByPrefix(strPrefix);
 return strMaxViewId;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000025)根据前缀获取最大关键字值出错, {1}.(from {0})",
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
 string strViewId;
 try
 {
 strViewId = new clsQxViewInfoDA().GetFirstID(strWhereCond);
 return strViewId;
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
 arrList = QxViewInfoDA.GetID(strWhereCond);
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
bool bolIsExist = QxViewInfoDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strViewId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strViewId)
{
if (string.IsNullOrEmpty(strViewId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strViewId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = QxViewInfoDA.IsExist(strViewId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strViewId">界面编号</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strViewId, string strOpUser)
{
clsQxViewInfoEN objQxViewInfoEN = clsQxViewInfoBL.GetObjByViewId(strViewId);
objQxViewInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objQxViewInfoEN.UpdUserId = strOpUser;
return clsQxViewInfoBL.UpdateBySql2(objQxViewInfoEN);
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
 bolIsExist = clsQxViewInfoDA.IsExistTable();
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
 bolIsExist = QxViewInfoDA.IsExistTable(strTabName);
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
 /// <param name = "objQxViewInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsQxViewInfoEN objQxViewInfoEN)
{
 if (string.IsNullOrEmpty(objQxViewInfoEN.ViewId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQxViewInfoBL.IsExist(objQxViewInfoEN.ViewId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQxViewInfoEN.ViewId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (objQxViewInfoEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!界面名称 = [{0}],项目Id = [{1}]的数据已经存在!(in clsQxViewInfoBL.AddNewRecordBySql2)", objQxViewInfoEN.ViewName,objQxViewInfoEN.QxPrjId);
throw new Exception(strMsg);
}
try
{
bool bolResult = QxViewInfoDA.AddNewRecordBySQL2(objQxViewInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxViewInfoBL.ReFreshCache();

if (clsQxViewInfoBL.relatedActions != null)
{
clsQxViewInfoBL.relatedActions.UpdRelaTabDate(objQxViewInfoEN.ViewId, objQxViewInfoEN.UpdUserId);
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
 /// <param name = "objQxViewInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsQxViewInfoEN objQxViewInfoEN)
{
 if (string.IsNullOrEmpty(objQxViewInfoEN.ViewId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQxViewInfoBL.IsExist(objQxViewInfoEN.ViewId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQxViewInfoEN.ViewId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (objQxViewInfoEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!界面名称 = [{0}],项目Id = [{1}]的数据已经存在!(in clsQxViewInfoBL.AddNewRecordBySql2WithReturnKey)", objQxViewInfoEN.ViewName,objQxViewInfoEN.QxPrjId);
throw new Exception(strMsg);
}
try
{
string strKey = QxViewInfoDA.AddNewRecordBySQL2WithReturnKey(objQxViewInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxViewInfoBL.ReFreshCache();

if (clsQxViewInfoBL.relatedActions != null)
{
clsQxViewInfoBL.relatedActions.UpdRelaTabDate(objQxViewInfoEN.ViewId, objQxViewInfoEN.UpdUserId);
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
 /// <param name = "strQxViewInfoObjXml">代表实体对象的XML串</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql_XML(string strQxViewInfoObjXml)
{
clsQxViewInfoEN objQxViewInfoEN = GetObjFromXmlStr(strQxViewInfoObjXml);
try
{
bool bolResult = QxViewInfoDA.AddNewRecordBySQL2(objQxViewInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxViewInfoBL.ReFreshCache();

if (clsQxViewInfoBL.relatedActions != null)
{
clsQxViewInfoBL.relatedActions.UpdRelaTabDate(objQxViewInfoEN.ViewId, objQxViewInfoEN.UpdUserId);
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
 /// <param name = "objQxViewInfoEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsQxViewInfoEN objQxViewInfoEN)
{
try
{
bool bolResult = QxViewInfoDA.Update(objQxViewInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxViewInfoBL.ReFreshCache();

if (clsQxViewInfoBL.relatedActions != null)
{
clsQxViewInfoBL.relatedActions.UpdRelaTabDate(objQxViewInfoEN.ViewId, objQxViewInfoEN.UpdUserId);
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
 /// <param name = "objQxViewInfoEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsQxViewInfoEN objQxViewInfoEN)
{
 if (string.IsNullOrEmpty(objQxViewInfoEN.ViewId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = QxViewInfoDA.UpdateBySql2(objQxViewInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxViewInfoBL.ReFreshCache();

if (clsQxViewInfoBL.relatedActions != null)
{
clsQxViewInfoBL.relatedActions.UpdRelaTabDate(objQxViewInfoEN.ViewId, objQxViewInfoEN.UpdUserId);
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
 /// <param name = "strQxViewInfoObjXml">需要修改的对象,用XML来表示</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql_XML(string strQxViewInfoObjXml)
{
clsQxViewInfoEN objQxViewInfoEN = GetObjFromXmlStr(strQxViewInfoObjXml);
try
{
bool bolResult = QxViewInfoDA.UpdateBySql2(objQxViewInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxViewInfoBL.ReFreshCache();

if (clsQxViewInfoBL.relatedActions != null)
{
clsQxViewInfoBL.relatedActions.UpdRelaTabDate(objQxViewInfoEN.ViewId, objQxViewInfoEN.UpdUserId);
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
 /// <param name = "strViewId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strViewId)
{
try
{
 clsQxViewInfoEN objQxViewInfoEN = clsQxViewInfoBL.GetObjByViewId(strViewId);

if (clsQxViewInfoBL.relatedActions != null)
{
clsQxViewInfoBL.relatedActions.UpdRelaTabDate(objQxViewInfoEN.ViewId, objQxViewInfoEN.UpdUserId);
}
if (objQxViewInfoEN != null)
{
int intRecNum = QxViewInfoDA.DelRecord(strViewId);
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
/// <param name="strViewId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strViewId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxViewInfoDA.GetSpecSQLObj();
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
//删除与表:[QxViewInfo]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conQxViewInfo.ViewId,
//strViewId);
//        clsQxViewInfoBL.DelQxViewInfosByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxViewInfoBL.DelRecord(strViewId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxViewInfoBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strViewId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strViewId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strViewId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsQxViewInfoBL.relatedActions != null)
{
clsQxViewInfoBL.relatedActions.UpdRelaTabDate(strViewId, "UpdRelaTabDate");
}
bool bolResult = QxViewInfoDA.DelRecord(strViewId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "strViewId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strViewId) 
{
try
{
if (clsQxViewInfoBL.relatedActions != null)
{
clsQxViewInfoBL.relatedActions.UpdRelaTabDate(strViewId, "UpdRelaTabDate");
}
bool bolResult = QxViewInfoDA.DelRecordBySP(strViewId);
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
 /// <param name = "arrViewIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelQxViewInfos(List<string> arrViewIdLst)
{
if (arrViewIdLst.Count == 0) return 0;
try
{
if (clsQxViewInfoBL.relatedActions != null)
{
foreach (var strViewId in arrViewIdLst)
{
clsQxViewInfoBL.relatedActions.UpdRelaTabDate(strViewId, "UpdRelaTabDate");
}
}
int intDelRecNum = QxViewInfoDA.DelQxViewInfo(arrViewIdLst);
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
public static int DelQxViewInfosByCond(string strWhereCond)
{
try
{
if (clsQxViewInfoBL.relatedActions != null)
{
List<string> arrViewId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strViewId in arrViewId)
{
clsQxViewInfoBL.relatedActions.UpdRelaTabDate(strViewId, "UpdRelaTabDate");
}
}
int intRecNum = QxViewInfoDA.DelQxViewInfo(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[QxViewInfo]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strViewId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strViewId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxViewInfoDA.GetSpecSQLObj();
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
//删除与表:[QxViewInfo]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxViewInfoBL.DelRecord(strViewId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxViewInfoBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strViewId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objQxViewInfoENS">源对象</param>
 /// <param name = "objQxViewInfoENT">目标对象</param>
 public static void CopyTo(clsQxViewInfoEN objQxViewInfoENS, clsQxViewInfoEN objQxViewInfoENT)
{
try
{
objQxViewInfoENT.ViewId = objQxViewInfoENS.ViewId; //界面编号
objQxViewInfoENT.ViewName = objQxViewInfoENS.ViewName; //界面名称
objQxViewInfoENT.ViewCnName = objQxViewInfoENS.ViewCnName; //界面中文名称
objQxViewInfoENT.FileName = objQxViewInfoENS.FileName; //文件名
objQxViewInfoENT.FilePath = objQxViewInfoENS.FilePath; //文件路径
objQxViewInfoENT.DefaMenuName = objQxViewInfoENS.DefaMenuName; //缺省菜单名
objQxViewInfoENT.ViewTypeCode = objQxViewInfoENS.ViewTypeCode; //界面类型码
objQxViewInfoENT.DataBaseName = objQxViewInfoENS.DataBaseName; //数据库名称
objQxViewInfoENT.QxPrjId = objQxViewInfoENS.QxPrjId; //项目Id
objQxViewInfoENT.ViewFunction = objQxViewInfoENS.ViewFunction; //界面功能
objQxViewInfoENT.ViewDetail = objQxViewInfoENS.ViewDetail; //界面详细信息
objQxViewInfoENT.ModuleId = objQxViewInfoENS.ModuleId; //模块号
objQxViewInfoENT.UpdDate = objQxViewInfoENS.UpdDate; //修改日期
objQxViewInfoENT.UpdUserId = objQxViewInfoENS.UpdUserId; //修改用户Id
objQxViewInfoENT.Memo = objQxViewInfoENS.Memo; //备注
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
 /// <param name = "objQxViewInfoEN">源简化对象</param>
 public static void SetUpdFlag(clsQxViewInfoEN objQxViewInfoEN)
{
try
{
objQxViewInfoEN.ClearUpdateState();
   string strsfUpdFldSetStr = objQxViewInfoEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conQxViewInfo.ViewId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxViewInfoEN.ViewId = objQxViewInfoEN.ViewId; //界面编号
}
if (arrFldSet.Contains(conQxViewInfo.ViewName, new clsStrCompareIgnoreCase())  ==  true)
{
objQxViewInfoEN.ViewName = objQxViewInfoEN.ViewName; //界面名称
}
if (arrFldSet.Contains(conQxViewInfo.ViewCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objQxViewInfoEN.ViewCnName = objQxViewInfoEN.ViewCnName; //界面中文名称
}
if (arrFldSet.Contains(conQxViewInfo.FileName, new clsStrCompareIgnoreCase())  ==  true)
{
objQxViewInfoEN.FileName = objQxViewInfoEN.FileName; //文件名
}
if (arrFldSet.Contains(conQxViewInfo.FilePath, new clsStrCompareIgnoreCase())  ==  true)
{
objQxViewInfoEN.FilePath = objQxViewInfoEN.FilePath; //文件路径
}
if (arrFldSet.Contains(conQxViewInfo.DefaMenuName, new clsStrCompareIgnoreCase())  ==  true)
{
objQxViewInfoEN.DefaMenuName = objQxViewInfoEN.DefaMenuName; //缺省菜单名
}
if (arrFldSet.Contains(conQxViewInfo.ViewTypeCode, new clsStrCompareIgnoreCase())  ==  true)
{
objQxViewInfoEN.ViewTypeCode = objQxViewInfoEN.ViewTypeCode; //界面类型码
}
if (arrFldSet.Contains(conQxViewInfo.DataBaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objQxViewInfoEN.DataBaseName = objQxViewInfoEN.DataBaseName == "[null]" ? null :  objQxViewInfoEN.DataBaseName; //数据库名称
}
if (arrFldSet.Contains(conQxViewInfo.QxPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxViewInfoEN.QxPrjId = objQxViewInfoEN.QxPrjId; //项目Id
}
if (arrFldSet.Contains(conQxViewInfo.ViewFunction, new clsStrCompareIgnoreCase())  ==  true)
{
objQxViewInfoEN.ViewFunction = objQxViewInfoEN.ViewFunction == "[null]" ? null :  objQxViewInfoEN.ViewFunction; //界面功能
}
if (arrFldSet.Contains(conQxViewInfo.ViewDetail, new clsStrCompareIgnoreCase())  ==  true)
{
objQxViewInfoEN.ViewDetail = objQxViewInfoEN.ViewDetail == "[null]" ? null :  objQxViewInfoEN.ViewDetail; //界面详细信息
}
if (arrFldSet.Contains(conQxViewInfo.ModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxViewInfoEN.ModuleId = objQxViewInfoEN.ModuleId == "[null]" ? null :  objQxViewInfoEN.ModuleId; //模块号
}
if (arrFldSet.Contains(conQxViewInfo.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objQxViewInfoEN.UpdDate = objQxViewInfoEN.UpdDate == "[null]" ? null :  objQxViewInfoEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conQxViewInfo.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxViewInfoEN.UpdUserId = objQxViewInfoEN.UpdUserId == "[null]" ? null :  objQxViewInfoEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conQxViewInfo.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objQxViewInfoEN.Memo = objQxViewInfoEN.Memo == "[null]" ? null :  objQxViewInfoEN.Memo; //备注
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
 /// <param name = "objQxViewInfoEN">源简化对象</param>
 public static void AccessFldValueNull(clsQxViewInfoEN objQxViewInfoEN)
{
try
{
if (objQxViewInfoEN.DataBaseName == "[null]") objQxViewInfoEN.DataBaseName = null; //数据库名称
if (objQxViewInfoEN.ViewFunction == "[null]") objQxViewInfoEN.ViewFunction = null; //界面功能
if (objQxViewInfoEN.ViewDetail == "[null]") objQxViewInfoEN.ViewDetail = null; //界面详细信息
if (objQxViewInfoEN.ModuleId == "[null]") objQxViewInfoEN.ModuleId = null; //模块号
if (objQxViewInfoEN.UpdDate == "[null]") objQxViewInfoEN.UpdDate = null; //修改日期
if (objQxViewInfoEN.UpdUserId == "[null]") objQxViewInfoEN.UpdUserId = null; //修改用户Id
if (objQxViewInfoEN.Memo == "[null]") objQxViewInfoEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsQxViewInfoEN objQxViewInfoEN)
{
 QxViewInfoDA.CheckPropertyNew(objQxViewInfoEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsQxViewInfoEN objQxViewInfoEN)
{
 QxViewInfoDA.CheckProperty4Condition(objQxViewInfoEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_ViewId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conQxViewInfo.ViewId); 
List<clsQxViewInfoEN> arrObjLst = clsQxViewInfoBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsQxViewInfoEN objQxViewInfoEN = new clsQxViewInfoEN()
{
ViewId = "0",
ViewName = "选[界面]..."
};
arrObjLst.Insert(0, objQxViewInfoEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conQxViewInfo.ViewId;
objComboBox.DisplayMember = conQxViewInfo.ViewName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_ViewId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[界面]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conQxViewInfo.ViewId); 
IEnumerable<clsQxViewInfoEN> arrObjLst = clsQxViewInfoBL.GetObjLst(strCondition);
objDDL.DataValueField = conQxViewInfo.ViewId;
objDDL.DataTextField = conQxViewInfo.ViewName;
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
public static void BindDdl_ViewIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[界面]...","0");
List<clsQxViewInfoEN> arrQxViewInfoObjLst = GetAllQxViewInfoObjLstCache(); 
objDDL.DataValueField = conQxViewInfo.ViewId;
objDDL.DataTextField = conQxViewInfo.ViewName;
objDDL.DataSource = arrQxViewInfoObjLst;
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
if (clsQxViewInfoBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxViewInfoBL没有刷新缓存机制(clsQxViewInfoBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ViewId");
//if (arrQxViewInfoObjLstCache == null)
//{
//arrQxViewInfoObjLstCache = QxViewInfoDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strViewId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxViewInfoEN GetObjByViewIdCache(string strViewId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsQxViewInfoEN._CurrTabName);
List<clsQxViewInfoEN> arrQxViewInfoObjLstCache = GetObjLstCache();
IEnumerable <clsQxViewInfoEN> arrQxViewInfoObjLst_Sel =
arrQxViewInfoObjLstCache
.Where(x=> x.ViewId == strViewId 
);
if (arrQxViewInfoObjLst_Sel.Count() == 0)
{
   clsQxViewInfoEN obj = clsQxViewInfoBL.GetObjByViewId(strViewId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrQxViewInfoObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strViewId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetViewNameByViewIdCache(string strViewId)
{
if (string.IsNullOrEmpty(strViewId) == true) return "";
//获取缓存中的对象列表
clsQxViewInfoEN objQxViewInfo = GetObjByViewIdCache(strViewId);
if (objQxViewInfo == null) return "";
return objQxViewInfo.ViewName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strViewId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByViewIdCache(string strViewId)
{
if (string.IsNullOrEmpty(strViewId) == true) return "";
//获取缓存中的对象列表
clsQxViewInfoEN objQxViewInfo = GetObjByViewIdCache(strViewId);
if (objQxViewInfo == null) return "";
return objQxViewInfo.ViewName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxViewInfoEN> GetAllQxViewInfoObjLstCache()
{
//获取缓存中的对象列表
List<clsQxViewInfoEN> arrQxViewInfoObjLstCache = GetObjLstCache(); 
return arrQxViewInfoObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxViewInfoEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsQxViewInfoEN._CurrTabName);
List<clsQxViewInfoEN> arrQxViewInfoObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrQxViewInfoObjLstCache;
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
string strKey = string.Format("{0}", clsQxViewInfoEN._CurrTabName);
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
if (clsQxViewInfoBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsQxViewInfoEN._CurrTabName);
CacheHelper.Remove(strKey);
clsQxViewInfoBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--QxViewInfo(界面)
 /// 唯一性条件:ViewName_QxPrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQxViewInfoEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsQxViewInfoEN objQxViewInfoEN)
{
//检测记录是否存在
string strResult = QxViewInfoDA.GetUniCondStr(objQxViewInfoEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstQxViewInfoObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsQxViewInfoEN> lstQxViewInfoObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstQxViewInfoObjLst, writer);
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
 /// <param name = "lstQxViewInfoObjLst">[clsQxViewInfoEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsQxViewInfoEN> lstQxViewInfoObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsQxViewInfoBL.listXmlNode);
writer.WriteStartElement(clsQxViewInfoBL.itemsXmlNode);
foreach (clsQxViewInfoEN objQxViewInfoEN in lstQxViewInfoObjLst)
{
clsQxViewInfoBL.SerializeXML(writer, objQxViewInfoEN);
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
 /// <param name = "objQxViewInfoEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsQxViewInfoEN objQxViewInfoEN)
{
writer.WriteStartElement(clsQxViewInfoBL.itemXmlNode);
 
if (objQxViewInfoEN.ViewId != null)
{
writer.WriteElementString(conQxViewInfo.ViewId, objQxViewInfoEN.ViewId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxViewInfoEN.ViewName != null)
{
writer.WriteElementString(conQxViewInfo.ViewName, objQxViewInfoEN.ViewName.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxViewInfoEN.ViewCnName != null)
{
writer.WriteElementString(conQxViewInfo.ViewCnName, objQxViewInfoEN.ViewCnName.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxViewInfoEN.FileName != null)
{
writer.WriteElementString(conQxViewInfo.FileName, objQxViewInfoEN.FileName.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxViewInfoEN.FilePath != null)
{
writer.WriteElementString(conQxViewInfo.FilePath, objQxViewInfoEN.FilePath.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxViewInfoEN.DefaMenuName != null)
{
writer.WriteElementString(conQxViewInfo.DefaMenuName, objQxViewInfoEN.DefaMenuName.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxViewInfoEN.ViewTypeCode != null)
{
writer.WriteElementString(conQxViewInfo.ViewTypeCode, objQxViewInfoEN.ViewTypeCode.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxViewInfoEN.DataBaseName != null)
{
writer.WriteElementString(conQxViewInfo.DataBaseName, objQxViewInfoEN.DataBaseName.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxViewInfoEN.QxPrjId != null)
{
writer.WriteElementString(conQxViewInfo.QxPrjId, objQxViewInfoEN.QxPrjId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxViewInfoEN.ViewFunction != null)
{
writer.WriteElementString(conQxViewInfo.ViewFunction, objQxViewInfoEN.ViewFunction.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxViewInfoEN.ViewDetail != null)
{
writer.WriteElementString(conQxViewInfo.ViewDetail, objQxViewInfoEN.ViewDetail.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxViewInfoEN.ModuleId != null)
{
writer.WriteElementString(conQxViewInfo.ModuleId, objQxViewInfoEN.ModuleId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxViewInfoEN.UpdDate != null)
{
writer.WriteElementString(conQxViewInfo.UpdDate, objQxViewInfoEN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxViewInfoEN.UpdUserId != null)
{
writer.WriteElementString(conQxViewInfo.UpdUserId, objQxViewInfoEN.UpdUserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxViewInfoEN.Memo != null)
{
writer.WriteElementString(conQxViewInfo.Memo, objQxViewInfoEN.Memo.ToString(CultureInfo.InvariantCulture));
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
public static clsQxViewInfoEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsQxViewInfoEN objQxViewInfoEN = new clsQxViewInfoEN();
reader.Read();
while (!(reader.Name == clsQxViewInfoBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(conQxViewInfo.ViewId))
{
objQxViewInfoEN.ViewId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxViewInfo.ViewName))
{
objQxViewInfoEN.ViewName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxViewInfo.ViewCnName))
{
objQxViewInfoEN.ViewCnName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxViewInfo.FileName))
{
objQxViewInfoEN.FileName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxViewInfo.FilePath))
{
objQxViewInfoEN.FilePath = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxViewInfo.DefaMenuName))
{
objQxViewInfoEN.DefaMenuName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxViewInfo.ViewTypeCode))
{
objQxViewInfoEN.ViewTypeCode = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxViewInfo.DataBaseName))
{
objQxViewInfoEN.DataBaseName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxViewInfo.QxPrjId))
{
objQxViewInfoEN.QxPrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxViewInfo.ViewFunction))
{
objQxViewInfoEN.ViewFunction = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxViewInfo.ViewDetail))
{
objQxViewInfoEN.ViewDetail = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxViewInfo.ModuleId))
{
objQxViewInfoEN.ModuleId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxViewInfo.UpdDate))
{
objQxViewInfoEN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxViewInfo.UpdUserId))
{
objQxViewInfoEN.UpdUserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxViewInfo.Memo))
{
objQxViewInfoEN.Memo = reader.ReadElementContentAsString();
}
}
return objQxViewInfoEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strQxViewInfoObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsQxViewInfoEN GetObjFromXmlStr(string strQxViewInfoObjXmlStr)
{
clsQxViewInfoEN objQxViewInfoEN = new clsQxViewInfoEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strQxViewInfoObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsQxViewInfoBL.itemXmlNode))
{
objQxViewInfoEN = GetObjFromXml(reader);
return objQxViewInfoEN;
}
}
return objQxViewInfoEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objQxViewInfoEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsQxViewInfoEN objQxViewInfoEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objQxViewInfoEN);
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
public static string Func(string strInFldName, string strOutFldName, string strViewId)
{
if (strInFldName != conQxViewInfo.ViewId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conQxViewInfo.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conQxViewInfo.AttributeName));
throw new Exception(strMsg);
}
var objQxViewInfo = clsQxViewInfoBL.GetObjByViewIdCache(strViewId);
if (objQxViewInfo == null) return "";
return objQxViewInfo[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objQxViewInfoEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsQxViewInfoEN objQxViewInfoEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsQxViewInfoEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objQxViewInfoEN[strField]);
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
 /// <param name = "lstQxViewInfoObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsQxViewInfoEN> lstQxViewInfoObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstQxViewInfoObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsQxViewInfoEN objQxViewInfoEN in lstQxViewInfoObjLst)
{
string strJSON_One = SerializeObjToJSON(objQxViewInfoEN);
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
int intRecCount = clsQxViewInfoDA.GetRecCount(strTabName);
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
int intRecCount = clsQxViewInfoDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsQxViewInfoDA.GetRecCount();
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
int intRecCount = clsQxViewInfoDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objQxViewInfoCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsQxViewInfoEN objQxViewInfoCond)
{
List<clsQxViewInfoEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxViewInfoEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxViewInfo.AttributeName)
{
if (objQxViewInfoCond.IsUpdated(strFldName) == false) continue;
if (objQxViewInfoCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxViewInfoCond[strFldName].ToString());
}
else
{
if (objQxViewInfoCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxViewInfoCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxViewInfoCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxViewInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxViewInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxViewInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxViewInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxViewInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxViewInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxViewInfoCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxViewInfoCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxViewInfoCond[strFldName]));
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
 List<string> arrList = clsQxViewInfoDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = QxViewInfoDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = QxViewInfoDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = QxViewInfoDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxViewInfoDA.SetFldValue(clsQxViewInfoEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = QxViewInfoDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxViewInfoDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxViewInfoDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxViewInfoDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[QxViewInfo] "); 
 strCreateTabCode.Append(" ( "); 
 // /**界面编号*/ 
 strCreateTabCode.Append(" ViewId char(8) primary key, "); 
 // /**界面名称*/ 
 strCreateTabCode.Append(" ViewName varchar(100) not Null, "); 
 // /**界面中文名称*/ 
 strCreateTabCode.Append(" ViewCnName varchar(50) not Null, "); 
 // /**文件名*/ 
 strCreateTabCode.Append(" FileName varchar(500) not Null, "); 
 // /**文件路径*/ 
 strCreateTabCode.Append(" FilePath varchar(500) not Null, "); 
 // /**缺省菜单名*/ 
 strCreateTabCode.Append(" DefaMenuName varchar(50) not Null, "); 
 // /**界面类型码*/ 
 strCreateTabCode.Append(" ViewTypeCode char(4) not Null, "); 
 // /**数据库名称*/ 
 strCreateTabCode.Append(" DataBaseName varchar(30) Null, "); 
 // /**项目Id*/ 
 strCreateTabCode.Append(" QxPrjId char(4) not Null, "); 
 // /**界面功能*/ 
 strCreateTabCode.Append(" ViewFunction varchar(100) Null, "); 
 // /**界面详细信息*/ 
 strCreateTabCode.Append(" ViewDetail varchar(1000) Null, "); 
 // /**模块号*/ 
 strCreateTabCode.Append(" ModuleId char(6) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) Null, "); 
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
 /// 界面(QxViewInfo)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4QxViewInfo : clsCommFun4BL
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
clsQxViewInfoBL.ReFreshThisCache();
}
}

}