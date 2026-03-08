
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxPrjTabBL
 表名:QxPrjTab(00140096)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 17:44:48
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:字段、表维护(Table_Field)
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
public static class  clsQxPrjTabBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strTabId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxPrjTabEN GetObj(this K_TabId_QxPrjTab myKey)
{
clsQxPrjTabEN objQxPrjTabEN = clsQxPrjTabBL.QxPrjTabDA.GetObjByTabId(myKey.Value);
return objQxPrjTabEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQxPrjTabEN objQxPrjTabEN)
{
 if (string.IsNullOrEmpty(objQxPrjTabEN.TabId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQxPrjTabBL.IsExist(objQxPrjTabEN.TabId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQxPrjTabEN.TabId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (CheckUniqueness(objQxPrjTabEN) == false)
{
var strMsg = string.Format("记录已经存在!TabName = [{0}],项目Id = [{1}]的数据已经存在!(in clsQxPrjTabBL.AddNewRecord)", objQxPrjTabEN.TabName,objQxPrjTabEN.QxPrjId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsQxPrjTabBL.QxPrjTabDA.AddNewRecordBySQL2(objQxPrjTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjTabBL.ReFreshCache();

if (clsQxPrjTabBL.relatedActions != null)
{
clsQxPrjTabBL.relatedActions.UpdRelaTabDate(objQxPrjTabEN.TabId, objQxPrjTabEN.UpdUserId);
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
public static bool AddRecordEx(this clsQxPrjTabEN objQxPrjTabEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsQxPrjTabBL.IsExist(objQxPrjTabEN.TabId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objQxPrjTabEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objQxPrjTabEN.CheckUniqueness() == false)
{
strMsg = string.Format("(TabName(TabName)=[{0}],项目Id(QxPrjId)=[{1}])已经存在,不能重复!", objQxPrjTabEN.TabName, objQxPrjTabEN.QxPrjId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objQxPrjTabEN.AddNewRecord();
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
 /// <param name = "objQxPrjTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsQxPrjTabEN objQxPrjTabEN)
{
if (CheckUniqueness(objQxPrjTabEN) == false)
{
var strMsg = string.Format("记录已经存在!TabName = [{0}],项目Id = [{1}]的数据已经存在!(in clsQxPrjTabBL.AddNewRecordWithMaxId)", objQxPrjTabEN.TabName,objQxPrjTabEN.QxPrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQxPrjTabEN.TabId) == true || clsQxPrjTabBL.IsExist(objQxPrjTabEN.TabId) == true)
 {
     objQxPrjTabEN.TabId = clsQxPrjTabBL.GetMaxStrIdByPrefix_S(objQxPrjTabEN.QxPrjId);
 }
string strTabId = clsQxPrjTabBL.QxPrjTabDA.AddNewRecordBySQL2WithReturnKey(objQxPrjTabEN);
     objQxPrjTabEN.TabId = strTabId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjTabBL.ReFreshCache();

if (clsQxPrjTabBL.relatedActions != null)
{
clsQxPrjTabBL.relatedActions.UpdRelaTabDate(objQxPrjTabEN.TabId, objQxPrjTabEN.UpdUserId);
}
return strTabId;
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
 /// <param name = "objQxPrjTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsQxPrjTabEN objQxPrjTabEN)
{
 if (string.IsNullOrEmpty(objQxPrjTabEN.TabId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQxPrjTabBL.IsExist(objQxPrjTabEN.TabId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQxPrjTabEN.TabId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (CheckUniqueness(objQxPrjTabEN) == false)
{
var strMsg = string.Format("记录已经存在!TabName = [{0}],项目Id = [{1}]的数据已经存在!(in clsQxPrjTabBL.AddNewRecordWithReturnKey)", objQxPrjTabEN.TabName,objQxPrjTabEN.QxPrjId);
throw new Exception(strMsg);
}
try
{
string strKey = clsQxPrjTabBL.QxPrjTabDA.AddNewRecordBySQL2WithReturnKey(objQxPrjTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjTabBL.ReFreshCache();

if (clsQxPrjTabBL.relatedActions != null)
{
clsQxPrjTabBL.relatedActions.UpdRelaTabDate(objQxPrjTabEN.TabId, objQxPrjTabEN.UpdUserId);
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
 /// <param name = "objQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjTabEN SetTabId(this clsQxPrjTabEN objQxPrjTabEN, string strTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, conQxPrjTab.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, conQxPrjTab.TabId);
}
objQxPrjTabEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjTabEN.dicFldComparisonOp.ContainsKey(conQxPrjTab.TabId) == false)
{
objQxPrjTabEN.dicFldComparisonOp.Add(conQxPrjTab.TabId, strComparisonOp);
}
else
{
objQxPrjTabEN.dicFldComparisonOp[conQxPrjTab.TabId] = strComparisonOp;
}
}
return objQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjTabEN SetTabName(this clsQxPrjTabEN objQxPrjTabEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, conQxPrjTab.TabName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabName, 100, conQxPrjTab.TabName);
}
objQxPrjTabEN.TabName = strTabName; //TabName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjTabEN.dicFldComparisonOp.ContainsKey(conQxPrjTab.TabName) == false)
{
objQxPrjTabEN.dicFldComparisonOp.Add(conQxPrjTab.TabName, strComparisonOp);
}
else
{
objQxPrjTabEN.dicFldComparisonOp[conQxPrjTab.TabName] = strComparisonOp;
}
}
return objQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjTabEN SetTabCnName(this clsQxPrjTabEN objQxPrjTabEN, string strTabCnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabCnName, 200, conQxPrjTab.TabCnName);
}
objQxPrjTabEN.TabCnName = strTabCnName; //表中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjTabEN.dicFldComparisonOp.ContainsKey(conQxPrjTab.TabCnName) == false)
{
objQxPrjTabEN.dicFldComparisonOp.Add(conQxPrjTab.TabCnName, strComparisonOp);
}
else
{
objQxPrjTabEN.dicFldComparisonOp[conQxPrjTab.TabCnName] = strComparisonOp;
}
}
return objQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjTabEN SetQxPrjId(this clsQxPrjTabEN objQxPrjTabEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, conQxPrjTab.QxPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQxPrjId, 4, conQxPrjTab.QxPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, conQxPrjTab.QxPrjId);
}
objQxPrjTabEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjTabEN.dicFldComparisonOp.ContainsKey(conQxPrjTab.QxPrjId) == false)
{
objQxPrjTabEN.dicFldComparisonOp.Add(conQxPrjTab.QxPrjId, strComparisonOp);
}
else
{
objQxPrjTabEN.dicFldComparisonOp[conQxPrjTab.QxPrjId] = strComparisonOp;
}
}
return objQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjTabEN SetSQLDSTypeId(this clsQxPrjTabEN objQxPrjTabEN, string strSQLDSTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSQLDSTypeId, 2, conQxPrjTab.SQLDSTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSQLDSTypeId, 2, conQxPrjTab.SQLDSTypeId);
}
objQxPrjTabEN.SQLDSTypeId = strSQLDSTypeId; //数据源类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjTabEN.dicFldComparisonOp.ContainsKey(conQxPrjTab.SQLDSTypeId) == false)
{
objQxPrjTabEN.dicFldComparisonOp.Add(conQxPrjTab.SQLDSTypeId, strComparisonOp);
}
else
{
objQxPrjTabEN.dicFldComparisonOp[conQxPrjTab.SQLDSTypeId] = strComparisonOp;
}
}
return objQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjTabEN SetTabStateId(this clsQxPrjTabEN objQxPrjTabEN, string strTabStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabStateId, conQxPrjTab.TabStateId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabStateId, 2, conQxPrjTab.TabStateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabStateId, 2, conQxPrjTab.TabStateId);
}
objQxPrjTabEN.TabStateId = strTabStateId; //表状态ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjTabEN.dicFldComparisonOp.ContainsKey(conQxPrjTab.TabStateId) == false)
{
objQxPrjTabEN.dicFldComparisonOp.Add(conQxPrjTab.TabStateId, strComparisonOp);
}
else
{
objQxPrjTabEN.dicFldComparisonOp[conQxPrjTab.TabStateId] = strComparisonOp;
}
}
return objQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjTabEN SetIsParaTab(this clsQxPrjTabEN objQxPrjTabEN, bool bolIsParaTab, string strComparisonOp="")
	{
objQxPrjTabEN.IsParaTab = bolIsParaTab; //是否参数表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjTabEN.dicFldComparisonOp.ContainsKey(conQxPrjTab.IsParaTab) == false)
{
objQxPrjTabEN.dicFldComparisonOp.Add(conQxPrjTab.IsParaTab, strComparisonOp);
}
else
{
objQxPrjTabEN.dicFldComparisonOp[conQxPrjTab.IsParaTab] = strComparisonOp;
}
}
return objQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjTabEN SetFuncModuleAgcId(this clsQxPrjTabEN objQxPrjTabEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, conQxPrjTab.FuncModuleAgcId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, conQxPrjTab.FuncModuleAgcId);
}
objQxPrjTabEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjTabEN.dicFldComparisonOp.ContainsKey(conQxPrjTab.FuncModuleAgcId) == false)
{
objQxPrjTabEN.dicFldComparisonOp.Add(conQxPrjTab.FuncModuleAgcId, strComparisonOp);
}
else
{
objQxPrjTabEN.dicFldComparisonOp[conQxPrjTab.FuncModuleAgcId] = strComparisonOp;
}
}
return objQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjTabEN SetOwner(this clsQxPrjTabEN objQxPrjTabEN, string strOwner, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwner, 50, conQxPrjTab.Owner);
}
objQxPrjTabEN.Owner = strOwner; //拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjTabEN.dicFldComparisonOp.ContainsKey(conQxPrjTab.Owner) == false)
{
objQxPrjTabEN.dicFldComparisonOp.Add(conQxPrjTab.Owner, strComparisonOp);
}
else
{
objQxPrjTabEN.dicFldComparisonOp[conQxPrjTab.Owner] = strComparisonOp;
}
}
return objQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjTabEN SetKeyword(this clsQxPrjTabEN objQxPrjTabEN, string strKeyword, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyword, 50, conQxPrjTab.Keyword);
}
objQxPrjTabEN.Keyword = strKeyword; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjTabEN.dicFldComparisonOp.ContainsKey(conQxPrjTab.Keyword) == false)
{
objQxPrjTabEN.dicFldComparisonOp.Add(conQxPrjTab.Keyword, strComparisonOp);
}
else
{
objQxPrjTabEN.dicFldComparisonOp[conQxPrjTab.Keyword] = strComparisonOp;
}
}
return objQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjTabEN SetTabTypeId(this clsQxPrjTabEN objQxPrjTabEN, string strTabTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabTypeId, conQxPrjTab.TabTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabTypeId, 4, conQxPrjTab.TabTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabTypeId, 4, conQxPrjTab.TabTypeId);
}
objQxPrjTabEN.TabTypeId = strTabTypeId; //表类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjTabEN.dicFldComparisonOp.ContainsKey(conQxPrjTab.TabTypeId) == false)
{
objQxPrjTabEN.dicFldComparisonOp.Add(conQxPrjTab.TabTypeId, strComparisonOp);
}
else
{
objQxPrjTabEN.dicFldComparisonOp[conQxPrjTab.TabTypeId] = strComparisonOp;
}
}
return objQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjTabEN SetRelaViewId(this clsQxPrjTabEN objQxPrjTabEN, string strRelaViewId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRelaViewId, 8, conQxPrjTab.RelaViewId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRelaViewId, 8, conQxPrjTab.RelaViewId);
}
objQxPrjTabEN.RelaViewId = strRelaViewId; //RelaViewId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjTabEN.dicFldComparisonOp.ContainsKey(conQxPrjTab.RelaViewId) == false)
{
objQxPrjTabEN.dicFldComparisonOp.Add(conQxPrjTab.RelaViewId, strComparisonOp);
}
else
{
objQxPrjTabEN.dicFldComparisonOp[conQxPrjTab.RelaViewId] = strComparisonOp;
}
}
return objQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjTabEN SetPrimaryTypeId(this clsQxPrjTabEN objQxPrjTabEN, string strPrimaryTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrimaryTypeId, 2, conQxPrjTab.PrimaryTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrimaryTypeId, 2, conQxPrjTab.PrimaryTypeId);
}
objQxPrjTabEN.PrimaryTypeId = strPrimaryTypeId; //主键类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjTabEN.dicFldComparisonOp.ContainsKey(conQxPrjTab.PrimaryTypeId) == false)
{
objQxPrjTabEN.dicFldComparisonOp.Add(conQxPrjTab.PrimaryTypeId, strComparisonOp);
}
else
{
objQxPrjTabEN.dicFldComparisonOp[conQxPrjTab.PrimaryTypeId] = strComparisonOp;
}
}
return objQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjTabEN SetPrimaryTypeName(this clsQxPrjTabEN objQxPrjTabEN, string strPrimaryTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrimaryTypeName, 30, conQxPrjTab.PrimaryTypeName);
}
objQxPrjTabEN.PrimaryTypeName = strPrimaryTypeName; //主键类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjTabEN.dicFldComparisonOp.ContainsKey(conQxPrjTab.PrimaryTypeName) == false)
{
objQxPrjTabEN.dicFldComparisonOp.Add(conQxPrjTab.PrimaryTypeName, strComparisonOp);
}
else
{
objQxPrjTabEN.dicFldComparisonOp[conQxPrjTab.PrimaryTypeName] = strComparisonOp;
}
}
return objQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjTabEN SetKeyFldId(this clsQxPrjTabEN objQxPrjTabEN, string strKeyFldId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyFldId, 8, conQxPrjTab.KeyFldId);
}
objQxPrjTabEN.KeyFldId = strKeyFldId; //关键字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjTabEN.dicFldComparisonOp.ContainsKey(conQxPrjTab.KeyFldId) == false)
{
objQxPrjTabEN.dicFldComparisonOp.Add(conQxPrjTab.KeyFldId, strComparisonOp);
}
else
{
objQxPrjTabEN.dicFldComparisonOp[conQxPrjTab.KeyFldId] = strComparisonOp;
}
}
return objQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjTabEN SetKeyFldName(this clsQxPrjTabEN objQxPrjTabEN, string strKeyFldName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyFldName, 50, conQxPrjTab.KeyFldName);
}
objQxPrjTabEN.KeyFldName = strKeyFldName; //关键字段名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjTabEN.dicFldComparisonOp.ContainsKey(conQxPrjTab.KeyFldName) == false)
{
objQxPrjTabEN.dicFldComparisonOp.Add(conQxPrjTab.KeyFldName, strComparisonOp);
}
else
{
objQxPrjTabEN.dicFldComparisonOp[conQxPrjTab.KeyFldName] = strComparisonOp;
}
}
return objQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjTabEN SetUpdUserId(this clsQxPrjTabEN objQxPrjTabEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conQxPrjTab.UpdUserId);
}
objQxPrjTabEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjTabEN.dicFldComparisonOp.ContainsKey(conQxPrjTab.UpdUserId) == false)
{
objQxPrjTabEN.dicFldComparisonOp.Add(conQxPrjTab.UpdUserId, strComparisonOp);
}
else
{
objQxPrjTabEN.dicFldComparisonOp[conQxPrjTab.UpdUserId] = strComparisonOp;
}
}
return objQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjTabEN SetUpdDate(this clsQxPrjTabEN objQxPrjTabEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQxPrjTab.UpdDate);
}
objQxPrjTabEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjTabEN.dicFldComparisonOp.ContainsKey(conQxPrjTab.UpdDate) == false)
{
objQxPrjTabEN.dicFldComparisonOp.Add(conQxPrjTab.UpdDate, strComparisonOp);
}
else
{
objQxPrjTabEN.dicFldComparisonOp[conQxPrjTab.UpdDate] = strComparisonOp;
}
}
return objQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjTabEN SetMemo(this clsQxPrjTabEN objQxPrjTabEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQxPrjTab.Memo);
}
objQxPrjTabEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjTabEN.dicFldComparisonOp.ContainsKey(conQxPrjTab.Memo) == false)
{
objQxPrjTabEN.dicFldComparisonOp.Add(conQxPrjTab.Memo, strComparisonOp);
}
else
{
objQxPrjTabEN.dicFldComparisonOp[conQxPrjTab.Memo] = strComparisonOp;
}
}
return objQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjTabEN SetSynchDate(this clsQxPrjTabEN objQxPrjTabEN, string strSynchDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSynchDate, 14, conQxPrjTab.SynchDate);
}
objQxPrjTabEN.SynchDate = strSynchDate; //同步日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjTabEN.dicFldComparisonOp.ContainsKey(conQxPrjTab.SynchDate) == false)
{
objQxPrjTabEN.dicFldComparisonOp.Add(conQxPrjTab.SynchDate, strComparisonOp);
}
else
{
objQxPrjTabEN.dicFldComparisonOp[conQxPrjTab.SynchDate] = strComparisonOp;
}
}
return objQxPrjTabEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsQxPrjTabEN objQxPrjTabEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objQxPrjTabEN.CheckPropertyNew();
clsQxPrjTabEN objQxPrjTabCond = new clsQxPrjTabEN();
string strCondition = objQxPrjTabCond
.SetTabId(objQxPrjTabEN.TabId, "<>")
.SetTabName(objQxPrjTabEN.TabName, "=")
.SetQxPrjId(objQxPrjTabEN.QxPrjId, "=")
.GetCombineCondition();
objQxPrjTabEN._IsCheckProperty = true;
bool bolIsExist = clsQxPrjTabBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(TabName_QxPrjId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objQxPrjTabEN.Update();
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
 /// <param name = "objQxPrjTab">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsQxPrjTabEN objQxPrjTab)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsQxPrjTabEN objQxPrjTabCond = new clsQxPrjTabEN();
string strCondition = objQxPrjTabCond
.SetTabName(objQxPrjTab.TabName, "=")
.SetQxPrjId(objQxPrjTab.QxPrjId, "=")
.GetCombineCondition();
objQxPrjTab._IsCheckProperty = true;
bool bolIsExist = clsQxPrjTabBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objQxPrjTab.TabId = clsQxPrjTabBL.GetFirstID_S(strCondition);
objQxPrjTab.UpdateWithCondition(strCondition);
}
else
{
objQxPrjTab.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxPrjTabEN objQxPrjTabEN)
{
 if (string.IsNullOrEmpty(objQxPrjTabEN.TabId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxPrjTabBL.QxPrjTabDA.UpdateBySql2(objQxPrjTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjTabBL.ReFreshCache();

if (clsQxPrjTabBL.relatedActions != null)
{
clsQxPrjTabBL.relatedActions.UpdRelaTabDate(objQxPrjTabEN.TabId, objQxPrjTabEN.UpdUserId);
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
 /// <param name = "objQxPrjTabEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxPrjTabEN objQxPrjTabEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objQxPrjTabEN.TabId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxPrjTabBL.QxPrjTabDA.UpdateBySql2(objQxPrjTabEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjTabBL.ReFreshCache();

if (clsQxPrjTabBL.relatedActions != null)
{
clsQxPrjTabBL.relatedActions.UpdRelaTabDate(objQxPrjTabEN.TabId, objQxPrjTabEN.UpdUserId);
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
 /// <param name = "objQxPrjTabEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxPrjTabEN objQxPrjTabEN, string strWhereCond)
{
try
{
bool bolResult = clsQxPrjTabBL.QxPrjTabDA.UpdateBySqlWithCondition(objQxPrjTabEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjTabBL.ReFreshCache();

if (clsQxPrjTabBL.relatedActions != null)
{
clsQxPrjTabBL.relatedActions.UpdRelaTabDate(objQxPrjTabEN.TabId, objQxPrjTabEN.UpdUserId);
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
 /// <param name = "objQxPrjTabEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxPrjTabEN objQxPrjTabEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsQxPrjTabBL.QxPrjTabDA.UpdateBySqlWithConditionTransaction(objQxPrjTabEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjTabBL.ReFreshCache();

if (clsQxPrjTabBL.relatedActions != null)
{
clsQxPrjTabBL.relatedActions.UpdRelaTabDate(objQxPrjTabEN.TabId, objQxPrjTabEN.UpdUserId);
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
 /// <param name = "strTabId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsQxPrjTabEN objQxPrjTabEN)
{
try
{
int intRecNum = clsQxPrjTabBL.QxPrjTabDA.DelRecord(objQxPrjTabEN.TabId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjTabBL.ReFreshCache();

if (clsQxPrjTabBL.relatedActions != null)
{
clsQxPrjTabBL.relatedActions.UpdRelaTabDate(objQxPrjTabEN.TabId, objQxPrjTabEN.UpdUserId);
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
 /// <param name = "objQxPrjTabENS">源对象</param>
 /// <param name = "objQxPrjTabENT">目标对象</param>
 public static void CopyTo(this clsQxPrjTabEN objQxPrjTabENS, clsQxPrjTabEN objQxPrjTabENT)
{
try
{
objQxPrjTabENT.TabId = objQxPrjTabENS.TabId; //表ID
objQxPrjTabENT.TabName = objQxPrjTabENS.TabName; //TabName
objQxPrjTabENT.TabCnName = objQxPrjTabENS.TabCnName; //表中文名
objQxPrjTabENT.QxPrjId = objQxPrjTabENS.QxPrjId; //项目Id
objQxPrjTabENT.SQLDSTypeId = objQxPrjTabENS.SQLDSTypeId; //数据源类型
objQxPrjTabENT.TabStateId = objQxPrjTabENS.TabStateId; //表状态ID
objQxPrjTabENT.IsParaTab = objQxPrjTabENS.IsParaTab; //是否参数表
objQxPrjTabENT.FuncModuleAgcId = objQxPrjTabENS.FuncModuleAgcId; //功能模块Id
objQxPrjTabENT.Owner = objQxPrjTabENS.Owner; //拥有者
objQxPrjTabENT.Keyword = objQxPrjTabENS.Keyword; //关键字
objQxPrjTabENT.TabTypeId = objQxPrjTabENS.TabTypeId; //表类型Id
objQxPrjTabENT.RelaViewId = objQxPrjTabENS.RelaViewId; //RelaViewId
objQxPrjTabENT.PrimaryTypeId = objQxPrjTabENS.PrimaryTypeId; //主键类型ID
objQxPrjTabENT.PrimaryTypeName = objQxPrjTabENS.PrimaryTypeName; //主键类型名
objQxPrjTabENT.KeyFldId = objQxPrjTabENS.KeyFldId; //关键字段Id
objQxPrjTabENT.KeyFldName = objQxPrjTabENS.KeyFldName; //关键字段名
objQxPrjTabENT.UpdUserId = objQxPrjTabENS.UpdUserId; //修改用户Id
objQxPrjTabENT.UpdDate = objQxPrjTabENS.UpdDate; //修改日期
objQxPrjTabENT.Memo = objQxPrjTabENS.Memo; //备注
objQxPrjTabENT.SynchDate = objQxPrjTabENS.SynchDate; //同步日期
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
 /// <param name = "objQxPrjTabENS">源对象</param>
 /// <returns>目标对象=>clsQxPrjTabEN:objQxPrjTabENT</returns>
 public static clsQxPrjTabEN CopyTo(this clsQxPrjTabEN objQxPrjTabENS)
{
try
{
 clsQxPrjTabEN objQxPrjTabENT = new clsQxPrjTabEN()
{
TabId = objQxPrjTabENS.TabId, //表ID
TabName = objQxPrjTabENS.TabName, //TabName
TabCnName = objQxPrjTabENS.TabCnName, //表中文名
QxPrjId = objQxPrjTabENS.QxPrjId, //项目Id
SQLDSTypeId = objQxPrjTabENS.SQLDSTypeId, //数据源类型
TabStateId = objQxPrjTabENS.TabStateId, //表状态ID
IsParaTab = objQxPrjTabENS.IsParaTab, //是否参数表
FuncModuleAgcId = objQxPrjTabENS.FuncModuleAgcId, //功能模块Id
Owner = objQxPrjTabENS.Owner, //拥有者
Keyword = objQxPrjTabENS.Keyword, //关键字
TabTypeId = objQxPrjTabENS.TabTypeId, //表类型Id
RelaViewId = objQxPrjTabENS.RelaViewId, //RelaViewId
PrimaryTypeId = objQxPrjTabENS.PrimaryTypeId, //主键类型ID
PrimaryTypeName = objQxPrjTabENS.PrimaryTypeName, //主键类型名
KeyFldId = objQxPrjTabENS.KeyFldId, //关键字段Id
KeyFldName = objQxPrjTabENS.KeyFldName, //关键字段名
UpdUserId = objQxPrjTabENS.UpdUserId, //修改用户Id
UpdDate = objQxPrjTabENS.UpdDate, //修改日期
Memo = objQxPrjTabENS.Memo, //备注
SynchDate = objQxPrjTabENS.SynchDate, //同步日期
};
 return objQxPrjTabENT;
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
public static void CheckPropertyNew(this clsQxPrjTabEN objQxPrjTabEN)
{
 clsQxPrjTabBL.QxPrjTabDA.CheckPropertyNew(objQxPrjTabEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsQxPrjTabEN objQxPrjTabEN)
{
 clsQxPrjTabBL.QxPrjTabDA.CheckProperty4Condition(objQxPrjTabEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQxPrjTabEN objQxPrjTabCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQxPrjTabCond.IsUpdated(conQxPrjTab.TabId) == true)
{
string strComparisonOpTabId = objQxPrjTabCond.dicFldComparisonOp[conQxPrjTab.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjTab.TabId, objQxPrjTabCond.TabId, strComparisonOpTabId);
}
if (objQxPrjTabCond.IsUpdated(conQxPrjTab.TabName) == true)
{
string strComparisonOpTabName = objQxPrjTabCond.dicFldComparisonOp[conQxPrjTab.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjTab.TabName, objQxPrjTabCond.TabName, strComparisonOpTabName);
}
if (objQxPrjTabCond.IsUpdated(conQxPrjTab.TabCnName) == true)
{
string strComparisonOpTabCnName = objQxPrjTabCond.dicFldComparisonOp[conQxPrjTab.TabCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjTab.TabCnName, objQxPrjTabCond.TabCnName, strComparisonOpTabCnName);
}
if (objQxPrjTabCond.IsUpdated(conQxPrjTab.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objQxPrjTabCond.dicFldComparisonOp[conQxPrjTab.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjTab.QxPrjId, objQxPrjTabCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objQxPrjTabCond.IsUpdated(conQxPrjTab.SQLDSTypeId) == true)
{
string strComparisonOpSQLDSTypeId = objQxPrjTabCond.dicFldComparisonOp[conQxPrjTab.SQLDSTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjTab.SQLDSTypeId, objQxPrjTabCond.SQLDSTypeId, strComparisonOpSQLDSTypeId);
}
if (objQxPrjTabCond.IsUpdated(conQxPrjTab.TabStateId) == true)
{
string strComparisonOpTabStateId = objQxPrjTabCond.dicFldComparisonOp[conQxPrjTab.TabStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjTab.TabStateId, objQxPrjTabCond.TabStateId, strComparisonOpTabStateId);
}
if (objQxPrjTabCond.IsUpdated(conQxPrjTab.IsParaTab) == true)
{
if (objQxPrjTabCond.IsParaTab == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQxPrjTab.IsParaTab);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQxPrjTab.IsParaTab);
}
}
if (objQxPrjTabCond.IsUpdated(conQxPrjTab.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objQxPrjTabCond.dicFldComparisonOp[conQxPrjTab.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjTab.FuncModuleAgcId, objQxPrjTabCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objQxPrjTabCond.IsUpdated(conQxPrjTab.Owner) == true)
{
string strComparisonOpOwner = objQxPrjTabCond.dicFldComparisonOp[conQxPrjTab.Owner];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjTab.Owner, objQxPrjTabCond.Owner, strComparisonOpOwner);
}
if (objQxPrjTabCond.IsUpdated(conQxPrjTab.Keyword) == true)
{
string strComparisonOpKeyword = objQxPrjTabCond.dicFldComparisonOp[conQxPrjTab.Keyword];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjTab.Keyword, objQxPrjTabCond.Keyword, strComparisonOpKeyword);
}
if (objQxPrjTabCond.IsUpdated(conQxPrjTab.TabTypeId) == true)
{
string strComparisonOpTabTypeId = objQxPrjTabCond.dicFldComparisonOp[conQxPrjTab.TabTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjTab.TabTypeId, objQxPrjTabCond.TabTypeId, strComparisonOpTabTypeId);
}
if (objQxPrjTabCond.IsUpdated(conQxPrjTab.RelaViewId) == true)
{
string strComparisonOpRelaViewId = objQxPrjTabCond.dicFldComparisonOp[conQxPrjTab.RelaViewId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjTab.RelaViewId, objQxPrjTabCond.RelaViewId, strComparisonOpRelaViewId);
}
if (objQxPrjTabCond.IsUpdated(conQxPrjTab.PrimaryTypeId) == true)
{
string strComparisonOpPrimaryTypeId = objQxPrjTabCond.dicFldComparisonOp[conQxPrjTab.PrimaryTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjTab.PrimaryTypeId, objQxPrjTabCond.PrimaryTypeId, strComparisonOpPrimaryTypeId);
}
if (objQxPrjTabCond.IsUpdated(conQxPrjTab.PrimaryTypeName) == true)
{
string strComparisonOpPrimaryTypeName = objQxPrjTabCond.dicFldComparisonOp[conQxPrjTab.PrimaryTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjTab.PrimaryTypeName, objQxPrjTabCond.PrimaryTypeName, strComparisonOpPrimaryTypeName);
}
if (objQxPrjTabCond.IsUpdated(conQxPrjTab.KeyFldId) == true)
{
string strComparisonOpKeyFldId = objQxPrjTabCond.dicFldComparisonOp[conQxPrjTab.KeyFldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjTab.KeyFldId, objQxPrjTabCond.KeyFldId, strComparisonOpKeyFldId);
}
if (objQxPrjTabCond.IsUpdated(conQxPrjTab.KeyFldName) == true)
{
string strComparisonOpKeyFldName = objQxPrjTabCond.dicFldComparisonOp[conQxPrjTab.KeyFldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjTab.KeyFldName, objQxPrjTabCond.KeyFldName, strComparisonOpKeyFldName);
}
if (objQxPrjTabCond.IsUpdated(conQxPrjTab.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objQxPrjTabCond.dicFldComparisonOp[conQxPrjTab.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjTab.UpdUserId, objQxPrjTabCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objQxPrjTabCond.IsUpdated(conQxPrjTab.UpdDate) == true)
{
string strComparisonOpUpdDate = objQxPrjTabCond.dicFldComparisonOp[conQxPrjTab.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjTab.UpdDate, objQxPrjTabCond.UpdDate, strComparisonOpUpdDate);
}
if (objQxPrjTabCond.IsUpdated(conQxPrjTab.Memo) == true)
{
string strComparisonOpMemo = objQxPrjTabCond.dicFldComparisonOp[conQxPrjTab.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjTab.Memo, objQxPrjTabCond.Memo, strComparisonOpMemo);
}
if (objQxPrjTabCond.IsUpdated(conQxPrjTab.SynchDate) == true)
{
string strComparisonOpSynchDate = objQxPrjTabCond.dicFldComparisonOp[conQxPrjTab.SynchDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjTab.SynchDate, objQxPrjTabCond.SynchDate, strComparisonOpSynchDate);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--QxPrjTab(工程表), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:TabName_QxPrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objQxPrjTabEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsQxPrjTabEN objQxPrjTabEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objQxPrjTabEN == null) return true;
if (objQxPrjTabEN.TabId == null || objQxPrjTabEN.TabId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TabName = '{0}'", objQxPrjTabEN.TabName);
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxPrjTabEN.QxPrjId);
if (clsQxPrjTabBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("TabId !=  '{0}'", objQxPrjTabEN.TabId);
 sbCondition.AppendFormat(" and TabName = '{0}'", objQxPrjTabEN.TabName);
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxPrjTabEN.QxPrjId);
if (clsQxPrjTabBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--QxPrjTab(工程表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:TabName_QxPrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objQxPrjTabEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsQxPrjTabEN objQxPrjTabEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objQxPrjTabEN == null) return "";
if (objQxPrjTabEN.TabId == null || objQxPrjTabEN.TabId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TabName = '{0}'", objQxPrjTabEN.TabName);
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxPrjTabEN.QxPrjId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("TabId !=  '{0}'", objQxPrjTabEN.TabId);
 sbCondition.AppendFormat(" and TabName = '{0}'", objQxPrjTabEN.TabName);
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxPrjTabEN.QxPrjId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_QxPrjTab
{
public virtual bool UpdRelaTabDate(string strTabId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 工程表(QxPrjTab)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsQxPrjTabBL
{
public static RelatedActions_QxPrjTab relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "QxPrjTabListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "QxPrjTabList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsQxPrjTabEN> arrQxPrjTabObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsQxPrjTabDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsQxPrjTabDA QxPrjTabDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsQxPrjTabDA();
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
 public clsQxPrjTabBL()
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
if (string.IsNullOrEmpty(clsQxPrjTabEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxPrjTabEN._ConnectString);
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
objDS = QxPrjTabDA.GetDataSet(strWhereCond);
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
objDS = QxPrjTabDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = QxPrjTabDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_QxPrjTab(string strWhereCond)
{
DataTable objDT;
try
{
objDT = QxPrjTabDA.GetDataTable_QxPrjTab(strWhereCond);
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
objDT = QxPrjTabDA.GetDataTable(strWhereCond);
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
objDT = QxPrjTabDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = QxPrjTabDA.GetDataTable(strWhereCond, strTabName);
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
objDT = QxPrjTabDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = QxPrjTabDA.GetDataTable_Top(objTopPara);
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
objDT = QxPrjTabDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = QxPrjTabDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = QxPrjTabDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = QxPrjTabDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = QxPrjTabDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = QxPrjTabDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = QxPrjTabDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = QxPrjTabDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
 /// <param name = "arrTabIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsQxPrjTabEN> GetObjLstByTabIdLst(List<string> arrTabIdLst)
{
List<clsQxPrjTabEN> arrObjLst = new List<clsQxPrjTabEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrTabIdLst, true);
 string strWhereCond = string.Format("TabId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjTabEN objQxPrjTabEN = new clsQxPrjTabEN();
try
{
objQxPrjTabEN.TabId = objRow[conQxPrjTab.TabId].ToString().Trim(); //表ID
objQxPrjTabEN.TabName = objRow[conQxPrjTab.TabName].ToString().Trim(); //TabName
objQxPrjTabEN.TabCnName = objRow[conQxPrjTab.TabCnName] == DBNull.Value ? null : objRow[conQxPrjTab.TabCnName].ToString().Trim(); //表中文名
objQxPrjTabEN.QxPrjId = objRow[conQxPrjTab.QxPrjId].ToString().Trim(); //项目Id
objQxPrjTabEN.SQLDSTypeId = objRow[conQxPrjTab.SQLDSTypeId] == DBNull.Value ? null : objRow[conQxPrjTab.SQLDSTypeId].ToString().Trim(); //数据源类型
objQxPrjTabEN.TabStateId = objRow[conQxPrjTab.TabStateId].ToString().Trim(); //表状态ID
objQxPrjTabEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objQxPrjTabEN.FuncModuleAgcId = objRow[conQxPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[conQxPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objQxPrjTabEN.Owner = objRow[conQxPrjTab.Owner] == DBNull.Value ? null : objRow[conQxPrjTab.Owner].ToString().Trim(); //拥有者
objQxPrjTabEN.Keyword = objRow[conQxPrjTab.Keyword] == DBNull.Value ? null : objRow[conQxPrjTab.Keyword].ToString().Trim(); //关键字
objQxPrjTabEN.TabTypeId = objRow[conQxPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objQxPrjTabEN.RelaViewId = objRow[conQxPrjTab.RelaViewId] == DBNull.Value ? null : objRow[conQxPrjTab.RelaViewId].ToString().Trim(); //RelaViewId
objQxPrjTabEN.PrimaryTypeId = objRow[conQxPrjTab.PrimaryTypeId] == DBNull.Value ? null : objRow[conQxPrjTab.PrimaryTypeId].ToString().Trim(); //主键类型ID
objQxPrjTabEN.PrimaryTypeName = objRow[conQxPrjTab.PrimaryTypeName] == DBNull.Value ? null : objRow[conQxPrjTab.PrimaryTypeName].ToString().Trim(); //主键类型名
objQxPrjTabEN.KeyFldId = objRow[conQxPrjTab.KeyFldId] == DBNull.Value ? null : objRow[conQxPrjTab.KeyFldId].ToString().Trim(); //关键字段Id
objQxPrjTabEN.KeyFldName = objRow[conQxPrjTab.KeyFldName] == DBNull.Value ? null : objRow[conQxPrjTab.KeyFldName].ToString().Trim(); //关键字段名
objQxPrjTabEN.UpdUserId = objRow[conQxPrjTab.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjTabEN.UpdDate = objRow[conQxPrjTab.UpdDate] == DBNull.Value ? null : objRow[conQxPrjTab.UpdDate].ToString().Trim(); //修改日期
objQxPrjTabEN.Memo = objRow[conQxPrjTab.Memo] == DBNull.Value ? null : objRow[conQxPrjTab.Memo].ToString().Trim(); //备注
objQxPrjTabEN.SynchDate = objRow[conQxPrjTab.SynchDate] == DBNull.Value ? null : objRow[conQxPrjTab.SynchDate].ToString().Trim(); //同步日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjTabEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrTabIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsQxPrjTabEN> GetObjLstByTabIdLstCache(List<string> arrTabIdLst)
{
string strKey = string.Format("{0}", clsQxPrjTabEN._CurrTabName);
List<clsQxPrjTabEN> arrQxPrjTabObjLstCache = GetObjLstCache();
IEnumerable <clsQxPrjTabEN> arrQxPrjTabObjLst_Sel =
arrQxPrjTabObjLstCache
.Where(x => arrTabIdLst.Contains(x.TabId));
return arrQxPrjTabObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPrjTabEN> GetObjLst(string strWhereCond)
{
List<clsQxPrjTabEN> arrObjLst = new List<clsQxPrjTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjTabEN objQxPrjTabEN = new clsQxPrjTabEN();
try
{
objQxPrjTabEN.TabId = objRow[conQxPrjTab.TabId].ToString().Trim(); //表ID
objQxPrjTabEN.TabName = objRow[conQxPrjTab.TabName].ToString().Trim(); //TabName
objQxPrjTabEN.TabCnName = objRow[conQxPrjTab.TabCnName] == DBNull.Value ? null : objRow[conQxPrjTab.TabCnName].ToString().Trim(); //表中文名
objQxPrjTabEN.QxPrjId = objRow[conQxPrjTab.QxPrjId].ToString().Trim(); //项目Id
objQxPrjTabEN.SQLDSTypeId = objRow[conQxPrjTab.SQLDSTypeId] == DBNull.Value ? null : objRow[conQxPrjTab.SQLDSTypeId].ToString().Trim(); //数据源类型
objQxPrjTabEN.TabStateId = objRow[conQxPrjTab.TabStateId].ToString().Trim(); //表状态ID
objQxPrjTabEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objQxPrjTabEN.FuncModuleAgcId = objRow[conQxPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[conQxPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objQxPrjTabEN.Owner = objRow[conQxPrjTab.Owner] == DBNull.Value ? null : objRow[conQxPrjTab.Owner].ToString().Trim(); //拥有者
objQxPrjTabEN.Keyword = objRow[conQxPrjTab.Keyword] == DBNull.Value ? null : objRow[conQxPrjTab.Keyword].ToString().Trim(); //关键字
objQxPrjTabEN.TabTypeId = objRow[conQxPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objQxPrjTabEN.RelaViewId = objRow[conQxPrjTab.RelaViewId] == DBNull.Value ? null : objRow[conQxPrjTab.RelaViewId].ToString().Trim(); //RelaViewId
objQxPrjTabEN.PrimaryTypeId = objRow[conQxPrjTab.PrimaryTypeId] == DBNull.Value ? null : objRow[conQxPrjTab.PrimaryTypeId].ToString().Trim(); //主键类型ID
objQxPrjTabEN.PrimaryTypeName = objRow[conQxPrjTab.PrimaryTypeName] == DBNull.Value ? null : objRow[conQxPrjTab.PrimaryTypeName].ToString().Trim(); //主键类型名
objQxPrjTabEN.KeyFldId = objRow[conQxPrjTab.KeyFldId] == DBNull.Value ? null : objRow[conQxPrjTab.KeyFldId].ToString().Trim(); //关键字段Id
objQxPrjTabEN.KeyFldName = objRow[conQxPrjTab.KeyFldName] == DBNull.Value ? null : objRow[conQxPrjTab.KeyFldName].ToString().Trim(); //关键字段名
objQxPrjTabEN.UpdUserId = objRow[conQxPrjTab.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjTabEN.UpdDate = objRow[conQxPrjTab.UpdDate] == DBNull.Value ? null : objRow[conQxPrjTab.UpdDate].ToString().Trim(); //修改日期
objQxPrjTabEN.Memo = objRow[conQxPrjTab.Memo] == DBNull.Value ? null : objRow[conQxPrjTab.Memo].ToString().Trim(); //备注
objQxPrjTabEN.SynchDate = objRow[conQxPrjTab.SynchDate] == DBNull.Value ? null : objRow[conQxPrjTab.SynchDate].ToString().Trim(); //同步日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjTabEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjTabEN);
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
public static List<clsQxPrjTabEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsQxPrjTabEN> arrObjLst = new List<clsQxPrjTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjTabEN objQxPrjTabEN = new clsQxPrjTabEN();
try
{
objQxPrjTabEN.TabId = objRow[conQxPrjTab.TabId].ToString().Trim(); //表ID
objQxPrjTabEN.TabName = objRow[conQxPrjTab.TabName].ToString().Trim(); //TabName
objQxPrjTabEN.TabCnName = objRow[conQxPrjTab.TabCnName] == DBNull.Value ? null : objRow[conQxPrjTab.TabCnName].ToString().Trim(); //表中文名
objQxPrjTabEN.QxPrjId = objRow[conQxPrjTab.QxPrjId].ToString().Trim(); //项目Id
objQxPrjTabEN.SQLDSTypeId = objRow[conQxPrjTab.SQLDSTypeId] == DBNull.Value ? null : objRow[conQxPrjTab.SQLDSTypeId].ToString().Trim(); //数据源类型
objQxPrjTabEN.TabStateId = objRow[conQxPrjTab.TabStateId].ToString().Trim(); //表状态ID
objQxPrjTabEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objQxPrjTabEN.FuncModuleAgcId = objRow[conQxPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[conQxPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objQxPrjTabEN.Owner = objRow[conQxPrjTab.Owner] == DBNull.Value ? null : objRow[conQxPrjTab.Owner].ToString().Trim(); //拥有者
objQxPrjTabEN.Keyword = objRow[conQxPrjTab.Keyword] == DBNull.Value ? null : objRow[conQxPrjTab.Keyword].ToString().Trim(); //关键字
objQxPrjTabEN.TabTypeId = objRow[conQxPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objQxPrjTabEN.RelaViewId = objRow[conQxPrjTab.RelaViewId] == DBNull.Value ? null : objRow[conQxPrjTab.RelaViewId].ToString().Trim(); //RelaViewId
objQxPrjTabEN.PrimaryTypeId = objRow[conQxPrjTab.PrimaryTypeId] == DBNull.Value ? null : objRow[conQxPrjTab.PrimaryTypeId].ToString().Trim(); //主键类型ID
objQxPrjTabEN.PrimaryTypeName = objRow[conQxPrjTab.PrimaryTypeName] == DBNull.Value ? null : objRow[conQxPrjTab.PrimaryTypeName].ToString().Trim(); //主键类型名
objQxPrjTabEN.KeyFldId = objRow[conQxPrjTab.KeyFldId] == DBNull.Value ? null : objRow[conQxPrjTab.KeyFldId].ToString().Trim(); //关键字段Id
objQxPrjTabEN.KeyFldName = objRow[conQxPrjTab.KeyFldName] == DBNull.Value ? null : objRow[conQxPrjTab.KeyFldName].ToString().Trim(); //关键字段名
objQxPrjTabEN.UpdUserId = objRow[conQxPrjTab.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjTabEN.UpdDate = objRow[conQxPrjTab.UpdDate] == DBNull.Value ? null : objRow[conQxPrjTab.UpdDate].ToString().Trim(); //修改日期
objQxPrjTabEN.Memo = objRow[conQxPrjTab.Memo] == DBNull.Value ? null : objRow[conQxPrjTab.Memo].ToString().Trim(); //备注
objQxPrjTabEN.SynchDate = objRow[conQxPrjTab.SynchDate] == DBNull.Value ? null : objRow[conQxPrjTab.SynchDate].ToString().Trim(); //同步日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjTabEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objQxPrjTabCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsQxPrjTabEN> GetSubObjLstCache(clsQxPrjTabEN objQxPrjTabCond)
{
List<clsQxPrjTabEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxPrjTabEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxPrjTab.AttributeName)
{
if (objQxPrjTabCond.IsUpdated(strFldName) == false) continue;
if (objQxPrjTabCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxPrjTabCond[strFldName].ToString());
}
else
{
if (objQxPrjTabCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxPrjTabCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxPrjTabCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxPrjTabCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxPrjTabCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxPrjTabCond[strFldName]));
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
public static List<clsQxPrjTabEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsQxPrjTabEN> arrObjLst = new List<clsQxPrjTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjTabEN objQxPrjTabEN = new clsQxPrjTabEN();
try
{
objQxPrjTabEN.TabId = objRow[conQxPrjTab.TabId].ToString().Trim(); //表ID
objQxPrjTabEN.TabName = objRow[conQxPrjTab.TabName].ToString().Trim(); //TabName
objQxPrjTabEN.TabCnName = objRow[conQxPrjTab.TabCnName] == DBNull.Value ? null : objRow[conQxPrjTab.TabCnName].ToString().Trim(); //表中文名
objQxPrjTabEN.QxPrjId = objRow[conQxPrjTab.QxPrjId].ToString().Trim(); //项目Id
objQxPrjTabEN.SQLDSTypeId = objRow[conQxPrjTab.SQLDSTypeId] == DBNull.Value ? null : objRow[conQxPrjTab.SQLDSTypeId].ToString().Trim(); //数据源类型
objQxPrjTabEN.TabStateId = objRow[conQxPrjTab.TabStateId].ToString().Trim(); //表状态ID
objQxPrjTabEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objQxPrjTabEN.FuncModuleAgcId = objRow[conQxPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[conQxPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objQxPrjTabEN.Owner = objRow[conQxPrjTab.Owner] == DBNull.Value ? null : objRow[conQxPrjTab.Owner].ToString().Trim(); //拥有者
objQxPrjTabEN.Keyword = objRow[conQxPrjTab.Keyword] == DBNull.Value ? null : objRow[conQxPrjTab.Keyword].ToString().Trim(); //关键字
objQxPrjTabEN.TabTypeId = objRow[conQxPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objQxPrjTabEN.RelaViewId = objRow[conQxPrjTab.RelaViewId] == DBNull.Value ? null : objRow[conQxPrjTab.RelaViewId].ToString().Trim(); //RelaViewId
objQxPrjTabEN.PrimaryTypeId = objRow[conQxPrjTab.PrimaryTypeId] == DBNull.Value ? null : objRow[conQxPrjTab.PrimaryTypeId].ToString().Trim(); //主键类型ID
objQxPrjTabEN.PrimaryTypeName = objRow[conQxPrjTab.PrimaryTypeName] == DBNull.Value ? null : objRow[conQxPrjTab.PrimaryTypeName].ToString().Trim(); //主键类型名
objQxPrjTabEN.KeyFldId = objRow[conQxPrjTab.KeyFldId] == DBNull.Value ? null : objRow[conQxPrjTab.KeyFldId].ToString().Trim(); //关键字段Id
objQxPrjTabEN.KeyFldName = objRow[conQxPrjTab.KeyFldName] == DBNull.Value ? null : objRow[conQxPrjTab.KeyFldName].ToString().Trim(); //关键字段名
objQxPrjTabEN.UpdUserId = objRow[conQxPrjTab.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjTabEN.UpdDate = objRow[conQxPrjTab.UpdDate] == DBNull.Value ? null : objRow[conQxPrjTab.UpdDate].ToString().Trim(); //修改日期
objQxPrjTabEN.Memo = objRow[conQxPrjTab.Memo] == DBNull.Value ? null : objRow[conQxPrjTab.Memo].ToString().Trim(); //备注
objQxPrjTabEN.SynchDate = objRow[conQxPrjTab.SynchDate] == DBNull.Value ? null : objRow[conQxPrjTab.SynchDate].ToString().Trim(); //同步日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjTabEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjTabEN);
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
public static List<clsQxPrjTabEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsQxPrjTabEN> arrObjLst = new List<clsQxPrjTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjTabEN objQxPrjTabEN = new clsQxPrjTabEN();
try
{
objQxPrjTabEN.TabId = objRow[conQxPrjTab.TabId].ToString().Trim(); //表ID
objQxPrjTabEN.TabName = objRow[conQxPrjTab.TabName].ToString().Trim(); //TabName
objQxPrjTabEN.TabCnName = objRow[conQxPrjTab.TabCnName] == DBNull.Value ? null : objRow[conQxPrjTab.TabCnName].ToString().Trim(); //表中文名
objQxPrjTabEN.QxPrjId = objRow[conQxPrjTab.QxPrjId].ToString().Trim(); //项目Id
objQxPrjTabEN.SQLDSTypeId = objRow[conQxPrjTab.SQLDSTypeId] == DBNull.Value ? null : objRow[conQxPrjTab.SQLDSTypeId].ToString().Trim(); //数据源类型
objQxPrjTabEN.TabStateId = objRow[conQxPrjTab.TabStateId].ToString().Trim(); //表状态ID
objQxPrjTabEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objQxPrjTabEN.FuncModuleAgcId = objRow[conQxPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[conQxPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objQxPrjTabEN.Owner = objRow[conQxPrjTab.Owner] == DBNull.Value ? null : objRow[conQxPrjTab.Owner].ToString().Trim(); //拥有者
objQxPrjTabEN.Keyword = objRow[conQxPrjTab.Keyword] == DBNull.Value ? null : objRow[conQxPrjTab.Keyword].ToString().Trim(); //关键字
objQxPrjTabEN.TabTypeId = objRow[conQxPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objQxPrjTabEN.RelaViewId = objRow[conQxPrjTab.RelaViewId] == DBNull.Value ? null : objRow[conQxPrjTab.RelaViewId].ToString().Trim(); //RelaViewId
objQxPrjTabEN.PrimaryTypeId = objRow[conQxPrjTab.PrimaryTypeId] == DBNull.Value ? null : objRow[conQxPrjTab.PrimaryTypeId].ToString().Trim(); //主键类型ID
objQxPrjTabEN.PrimaryTypeName = objRow[conQxPrjTab.PrimaryTypeName] == DBNull.Value ? null : objRow[conQxPrjTab.PrimaryTypeName].ToString().Trim(); //主键类型名
objQxPrjTabEN.KeyFldId = objRow[conQxPrjTab.KeyFldId] == DBNull.Value ? null : objRow[conQxPrjTab.KeyFldId].ToString().Trim(); //关键字段Id
objQxPrjTabEN.KeyFldName = objRow[conQxPrjTab.KeyFldName] == DBNull.Value ? null : objRow[conQxPrjTab.KeyFldName].ToString().Trim(); //关键字段名
objQxPrjTabEN.UpdUserId = objRow[conQxPrjTab.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjTabEN.UpdDate = objRow[conQxPrjTab.UpdDate] == DBNull.Value ? null : objRow[conQxPrjTab.UpdDate].ToString().Trim(); //修改日期
objQxPrjTabEN.Memo = objRow[conQxPrjTab.Memo] == DBNull.Value ? null : objRow[conQxPrjTab.Memo].ToString().Trim(); //备注
objQxPrjTabEN.SynchDate = objRow[conQxPrjTab.SynchDate] == DBNull.Value ? null : objRow[conQxPrjTab.SynchDate].ToString().Trim(); //同步日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjTabEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjTabEN);
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
List<clsQxPrjTabEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsQxPrjTabEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPrjTabEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsQxPrjTabEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsQxPrjTabEN> arrObjLst = new List<clsQxPrjTabEN>(); 
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
	clsQxPrjTabEN objQxPrjTabEN = new clsQxPrjTabEN();
try
{
objQxPrjTabEN.TabId = objRow[conQxPrjTab.TabId].ToString().Trim(); //表ID
objQxPrjTabEN.TabName = objRow[conQxPrjTab.TabName].ToString().Trim(); //TabName
objQxPrjTabEN.TabCnName = objRow[conQxPrjTab.TabCnName] == DBNull.Value ? null : objRow[conQxPrjTab.TabCnName].ToString().Trim(); //表中文名
objQxPrjTabEN.QxPrjId = objRow[conQxPrjTab.QxPrjId].ToString().Trim(); //项目Id
objQxPrjTabEN.SQLDSTypeId = objRow[conQxPrjTab.SQLDSTypeId] == DBNull.Value ? null : objRow[conQxPrjTab.SQLDSTypeId].ToString().Trim(); //数据源类型
objQxPrjTabEN.TabStateId = objRow[conQxPrjTab.TabStateId].ToString().Trim(); //表状态ID
objQxPrjTabEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objQxPrjTabEN.FuncModuleAgcId = objRow[conQxPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[conQxPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objQxPrjTabEN.Owner = objRow[conQxPrjTab.Owner] == DBNull.Value ? null : objRow[conQxPrjTab.Owner].ToString().Trim(); //拥有者
objQxPrjTabEN.Keyword = objRow[conQxPrjTab.Keyword] == DBNull.Value ? null : objRow[conQxPrjTab.Keyword].ToString().Trim(); //关键字
objQxPrjTabEN.TabTypeId = objRow[conQxPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objQxPrjTabEN.RelaViewId = objRow[conQxPrjTab.RelaViewId] == DBNull.Value ? null : objRow[conQxPrjTab.RelaViewId].ToString().Trim(); //RelaViewId
objQxPrjTabEN.PrimaryTypeId = objRow[conQxPrjTab.PrimaryTypeId] == DBNull.Value ? null : objRow[conQxPrjTab.PrimaryTypeId].ToString().Trim(); //主键类型ID
objQxPrjTabEN.PrimaryTypeName = objRow[conQxPrjTab.PrimaryTypeName] == DBNull.Value ? null : objRow[conQxPrjTab.PrimaryTypeName].ToString().Trim(); //主键类型名
objQxPrjTabEN.KeyFldId = objRow[conQxPrjTab.KeyFldId] == DBNull.Value ? null : objRow[conQxPrjTab.KeyFldId].ToString().Trim(); //关键字段Id
objQxPrjTabEN.KeyFldName = objRow[conQxPrjTab.KeyFldName] == DBNull.Value ? null : objRow[conQxPrjTab.KeyFldName].ToString().Trim(); //关键字段名
objQxPrjTabEN.UpdUserId = objRow[conQxPrjTab.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjTabEN.UpdDate = objRow[conQxPrjTab.UpdDate] == DBNull.Value ? null : objRow[conQxPrjTab.UpdDate].ToString().Trim(); //修改日期
objQxPrjTabEN.Memo = objRow[conQxPrjTab.Memo] == DBNull.Value ? null : objRow[conQxPrjTab.Memo].ToString().Trim(); //备注
objQxPrjTabEN.SynchDate = objRow[conQxPrjTab.SynchDate] == DBNull.Value ? null : objRow[conQxPrjTab.SynchDate].ToString().Trim(); //同步日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjTabEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjTabEN);
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
public static List<clsQxPrjTabEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsQxPrjTabEN> arrObjLst = new List<clsQxPrjTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjTabEN objQxPrjTabEN = new clsQxPrjTabEN();
try
{
objQxPrjTabEN.TabId = objRow[conQxPrjTab.TabId].ToString().Trim(); //表ID
objQxPrjTabEN.TabName = objRow[conQxPrjTab.TabName].ToString().Trim(); //TabName
objQxPrjTabEN.TabCnName = objRow[conQxPrjTab.TabCnName] == DBNull.Value ? null : objRow[conQxPrjTab.TabCnName].ToString().Trim(); //表中文名
objQxPrjTabEN.QxPrjId = objRow[conQxPrjTab.QxPrjId].ToString().Trim(); //项目Id
objQxPrjTabEN.SQLDSTypeId = objRow[conQxPrjTab.SQLDSTypeId] == DBNull.Value ? null : objRow[conQxPrjTab.SQLDSTypeId].ToString().Trim(); //数据源类型
objQxPrjTabEN.TabStateId = objRow[conQxPrjTab.TabStateId].ToString().Trim(); //表状态ID
objQxPrjTabEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objQxPrjTabEN.FuncModuleAgcId = objRow[conQxPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[conQxPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objQxPrjTabEN.Owner = objRow[conQxPrjTab.Owner] == DBNull.Value ? null : objRow[conQxPrjTab.Owner].ToString().Trim(); //拥有者
objQxPrjTabEN.Keyword = objRow[conQxPrjTab.Keyword] == DBNull.Value ? null : objRow[conQxPrjTab.Keyword].ToString().Trim(); //关键字
objQxPrjTabEN.TabTypeId = objRow[conQxPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objQxPrjTabEN.RelaViewId = objRow[conQxPrjTab.RelaViewId] == DBNull.Value ? null : objRow[conQxPrjTab.RelaViewId].ToString().Trim(); //RelaViewId
objQxPrjTabEN.PrimaryTypeId = objRow[conQxPrjTab.PrimaryTypeId] == DBNull.Value ? null : objRow[conQxPrjTab.PrimaryTypeId].ToString().Trim(); //主键类型ID
objQxPrjTabEN.PrimaryTypeName = objRow[conQxPrjTab.PrimaryTypeName] == DBNull.Value ? null : objRow[conQxPrjTab.PrimaryTypeName].ToString().Trim(); //主键类型名
objQxPrjTabEN.KeyFldId = objRow[conQxPrjTab.KeyFldId] == DBNull.Value ? null : objRow[conQxPrjTab.KeyFldId].ToString().Trim(); //关键字段Id
objQxPrjTabEN.KeyFldName = objRow[conQxPrjTab.KeyFldName] == DBNull.Value ? null : objRow[conQxPrjTab.KeyFldName].ToString().Trim(); //关键字段名
objQxPrjTabEN.UpdUserId = objRow[conQxPrjTab.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjTabEN.UpdDate = objRow[conQxPrjTab.UpdDate] == DBNull.Value ? null : objRow[conQxPrjTab.UpdDate].ToString().Trim(); //修改日期
objQxPrjTabEN.Memo = objRow[conQxPrjTab.Memo] == DBNull.Value ? null : objRow[conQxPrjTab.Memo].ToString().Trim(); //备注
objQxPrjTabEN.SynchDate = objRow[conQxPrjTab.SynchDate] == DBNull.Value ? null : objRow[conQxPrjTab.SynchDate].ToString().Trim(); //同步日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjTabEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsQxPrjTabEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsQxPrjTabEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsQxPrjTabEN> arrObjLst = new List<clsQxPrjTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjTabEN objQxPrjTabEN = new clsQxPrjTabEN();
try
{
objQxPrjTabEN.TabId = objRow[conQxPrjTab.TabId].ToString().Trim(); //表ID
objQxPrjTabEN.TabName = objRow[conQxPrjTab.TabName].ToString().Trim(); //TabName
objQxPrjTabEN.TabCnName = objRow[conQxPrjTab.TabCnName] == DBNull.Value ? null : objRow[conQxPrjTab.TabCnName].ToString().Trim(); //表中文名
objQxPrjTabEN.QxPrjId = objRow[conQxPrjTab.QxPrjId].ToString().Trim(); //项目Id
objQxPrjTabEN.SQLDSTypeId = objRow[conQxPrjTab.SQLDSTypeId] == DBNull.Value ? null : objRow[conQxPrjTab.SQLDSTypeId].ToString().Trim(); //数据源类型
objQxPrjTabEN.TabStateId = objRow[conQxPrjTab.TabStateId].ToString().Trim(); //表状态ID
objQxPrjTabEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objQxPrjTabEN.FuncModuleAgcId = objRow[conQxPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[conQxPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objQxPrjTabEN.Owner = objRow[conQxPrjTab.Owner] == DBNull.Value ? null : objRow[conQxPrjTab.Owner].ToString().Trim(); //拥有者
objQxPrjTabEN.Keyword = objRow[conQxPrjTab.Keyword] == DBNull.Value ? null : objRow[conQxPrjTab.Keyword].ToString().Trim(); //关键字
objQxPrjTabEN.TabTypeId = objRow[conQxPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objQxPrjTabEN.RelaViewId = objRow[conQxPrjTab.RelaViewId] == DBNull.Value ? null : objRow[conQxPrjTab.RelaViewId].ToString().Trim(); //RelaViewId
objQxPrjTabEN.PrimaryTypeId = objRow[conQxPrjTab.PrimaryTypeId] == DBNull.Value ? null : objRow[conQxPrjTab.PrimaryTypeId].ToString().Trim(); //主键类型ID
objQxPrjTabEN.PrimaryTypeName = objRow[conQxPrjTab.PrimaryTypeName] == DBNull.Value ? null : objRow[conQxPrjTab.PrimaryTypeName].ToString().Trim(); //主键类型名
objQxPrjTabEN.KeyFldId = objRow[conQxPrjTab.KeyFldId] == DBNull.Value ? null : objRow[conQxPrjTab.KeyFldId].ToString().Trim(); //关键字段Id
objQxPrjTabEN.KeyFldName = objRow[conQxPrjTab.KeyFldName] == DBNull.Value ? null : objRow[conQxPrjTab.KeyFldName].ToString().Trim(); //关键字段名
objQxPrjTabEN.UpdUserId = objRow[conQxPrjTab.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjTabEN.UpdDate = objRow[conQxPrjTab.UpdDate] == DBNull.Value ? null : objRow[conQxPrjTab.UpdDate].ToString().Trim(); //修改日期
objQxPrjTabEN.Memo = objRow[conQxPrjTab.Memo] == DBNull.Value ? null : objRow[conQxPrjTab.Memo].ToString().Trim(); //备注
objQxPrjTabEN.SynchDate = objRow[conQxPrjTab.SynchDate] == DBNull.Value ? null : objRow[conQxPrjTab.SynchDate].ToString().Trim(); //同步日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjTabEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjTabEN);
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
public static List<clsQxPrjTabEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsQxPrjTabEN> arrObjLst = new List<clsQxPrjTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjTabEN objQxPrjTabEN = new clsQxPrjTabEN();
try
{
objQxPrjTabEN.TabId = objRow[conQxPrjTab.TabId].ToString().Trim(); //表ID
objQxPrjTabEN.TabName = objRow[conQxPrjTab.TabName].ToString().Trim(); //TabName
objQxPrjTabEN.TabCnName = objRow[conQxPrjTab.TabCnName] == DBNull.Value ? null : objRow[conQxPrjTab.TabCnName].ToString().Trim(); //表中文名
objQxPrjTabEN.QxPrjId = objRow[conQxPrjTab.QxPrjId].ToString().Trim(); //项目Id
objQxPrjTabEN.SQLDSTypeId = objRow[conQxPrjTab.SQLDSTypeId] == DBNull.Value ? null : objRow[conQxPrjTab.SQLDSTypeId].ToString().Trim(); //数据源类型
objQxPrjTabEN.TabStateId = objRow[conQxPrjTab.TabStateId].ToString().Trim(); //表状态ID
objQxPrjTabEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objQxPrjTabEN.FuncModuleAgcId = objRow[conQxPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[conQxPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objQxPrjTabEN.Owner = objRow[conQxPrjTab.Owner] == DBNull.Value ? null : objRow[conQxPrjTab.Owner].ToString().Trim(); //拥有者
objQxPrjTabEN.Keyword = objRow[conQxPrjTab.Keyword] == DBNull.Value ? null : objRow[conQxPrjTab.Keyword].ToString().Trim(); //关键字
objQxPrjTabEN.TabTypeId = objRow[conQxPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objQxPrjTabEN.RelaViewId = objRow[conQxPrjTab.RelaViewId] == DBNull.Value ? null : objRow[conQxPrjTab.RelaViewId].ToString().Trim(); //RelaViewId
objQxPrjTabEN.PrimaryTypeId = objRow[conQxPrjTab.PrimaryTypeId] == DBNull.Value ? null : objRow[conQxPrjTab.PrimaryTypeId].ToString().Trim(); //主键类型ID
objQxPrjTabEN.PrimaryTypeName = objRow[conQxPrjTab.PrimaryTypeName] == DBNull.Value ? null : objRow[conQxPrjTab.PrimaryTypeName].ToString().Trim(); //主键类型名
objQxPrjTabEN.KeyFldId = objRow[conQxPrjTab.KeyFldId] == DBNull.Value ? null : objRow[conQxPrjTab.KeyFldId].ToString().Trim(); //关键字段Id
objQxPrjTabEN.KeyFldName = objRow[conQxPrjTab.KeyFldName] == DBNull.Value ? null : objRow[conQxPrjTab.KeyFldName].ToString().Trim(); //关键字段名
objQxPrjTabEN.UpdUserId = objRow[conQxPrjTab.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjTabEN.UpdDate = objRow[conQxPrjTab.UpdDate] == DBNull.Value ? null : objRow[conQxPrjTab.UpdDate].ToString().Trim(); //修改日期
objQxPrjTabEN.Memo = objRow[conQxPrjTab.Memo] == DBNull.Value ? null : objRow[conQxPrjTab.Memo].ToString().Trim(); //备注
objQxPrjTabEN.SynchDate = objRow[conQxPrjTab.SynchDate] == DBNull.Value ? null : objRow[conQxPrjTab.SynchDate].ToString().Trim(); //同步日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjTabEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjTabEN);
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
public static IEnumerable<clsQxPrjTabEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsQxPrjTabEN objQxPrjTabCond, string strOrderBy)
{
List<clsQxPrjTabEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxPrjTabEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxPrjTab.AttributeName)
{
if (objQxPrjTabCond.IsUpdated(strFldName) == false) continue;
if (objQxPrjTabCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxPrjTabCond[strFldName].ToString());
}
else
{
if (objQxPrjTabCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxPrjTabCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxPrjTabCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxPrjTabCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxPrjTabCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxPrjTabCond[strFldName]));
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
public static IEnumerable<clsQxPrjTabEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsQxPrjTabEN objQxPrjTabCond = JsonConvert.DeserializeObject<clsQxPrjTabEN>(objPagerPara.whereCond);
if (objQxPrjTabCond.sfFldComparisonOp == null)
{
objQxPrjTabCond.dicFldComparisonOp = null;
}
else
{
objQxPrjTabCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objQxPrjTabCond.sfFldComparisonOp);
}
clsQxPrjTabBL.SetUpdFlag(objQxPrjTabCond);
 try
{
CheckProperty4Condition(objQxPrjTabCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsQxPrjTabBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objQxPrjTabCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPrjTabEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsQxPrjTabEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsQxPrjTabEN> arrObjLst = new List<clsQxPrjTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjTabEN objQxPrjTabEN = new clsQxPrjTabEN();
try
{
objQxPrjTabEN.TabId = objRow[conQxPrjTab.TabId].ToString().Trim(); //表ID
objQxPrjTabEN.TabName = objRow[conQxPrjTab.TabName].ToString().Trim(); //TabName
objQxPrjTabEN.TabCnName = objRow[conQxPrjTab.TabCnName] == DBNull.Value ? null : objRow[conQxPrjTab.TabCnName].ToString().Trim(); //表中文名
objQxPrjTabEN.QxPrjId = objRow[conQxPrjTab.QxPrjId].ToString().Trim(); //项目Id
objQxPrjTabEN.SQLDSTypeId = objRow[conQxPrjTab.SQLDSTypeId] == DBNull.Value ? null : objRow[conQxPrjTab.SQLDSTypeId].ToString().Trim(); //数据源类型
objQxPrjTabEN.TabStateId = objRow[conQxPrjTab.TabStateId].ToString().Trim(); //表状态ID
objQxPrjTabEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objQxPrjTabEN.FuncModuleAgcId = objRow[conQxPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[conQxPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objQxPrjTabEN.Owner = objRow[conQxPrjTab.Owner] == DBNull.Value ? null : objRow[conQxPrjTab.Owner].ToString().Trim(); //拥有者
objQxPrjTabEN.Keyword = objRow[conQxPrjTab.Keyword] == DBNull.Value ? null : objRow[conQxPrjTab.Keyword].ToString().Trim(); //关键字
objQxPrjTabEN.TabTypeId = objRow[conQxPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objQxPrjTabEN.RelaViewId = objRow[conQxPrjTab.RelaViewId] == DBNull.Value ? null : objRow[conQxPrjTab.RelaViewId].ToString().Trim(); //RelaViewId
objQxPrjTabEN.PrimaryTypeId = objRow[conQxPrjTab.PrimaryTypeId] == DBNull.Value ? null : objRow[conQxPrjTab.PrimaryTypeId].ToString().Trim(); //主键类型ID
objQxPrjTabEN.PrimaryTypeName = objRow[conQxPrjTab.PrimaryTypeName] == DBNull.Value ? null : objRow[conQxPrjTab.PrimaryTypeName].ToString().Trim(); //主键类型名
objQxPrjTabEN.KeyFldId = objRow[conQxPrjTab.KeyFldId] == DBNull.Value ? null : objRow[conQxPrjTab.KeyFldId].ToString().Trim(); //关键字段Id
objQxPrjTabEN.KeyFldName = objRow[conQxPrjTab.KeyFldName] == DBNull.Value ? null : objRow[conQxPrjTab.KeyFldName].ToString().Trim(); //关键字段名
objQxPrjTabEN.UpdUserId = objRow[conQxPrjTab.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjTabEN.UpdDate = objRow[conQxPrjTab.UpdDate] == DBNull.Value ? null : objRow[conQxPrjTab.UpdDate].ToString().Trim(); //修改日期
objQxPrjTabEN.Memo = objRow[conQxPrjTab.Memo] == DBNull.Value ? null : objRow[conQxPrjTab.Memo].ToString().Trim(); //备注
objQxPrjTabEN.SynchDate = objRow[conQxPrjTab.SynchDate] == DBNull.Value ? null : objRow[conQxPrjTab.SynchDate].ToString().Trim(); //同步日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjTabEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjTabEN);
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
public static List<clsQxPrjTabEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsQxPrjTabEN> arrObjLst = new List<clsQxPrjTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjTabEN objQxPrjTabEN = new clsQxPrjTabEN();
try
{
objQxPrjTabEN.TabId = objRow[conQxPrjTab.TabId].ToString().Trim(); //表ID
objQxPrjTabEN.TabName = objRow[conQxPrjTab.TabName].ToString().Trim(); //TabName
objQxPrjTabEN.TabCnName = objRow[conQxPrjTab.TabCnName] == DBNull.Value ? null : objRow[conQxPrjTab.TabCnName].ToString().Trim(); //表中文名
objQxPrjTabEN.QxPrjId = objRow[conQxPrjTab.QxPrjId].ToString().Trim(); //项目Id
objQxPrjTabEN.SQLDSTypeId = objRow[conQxPrjTab.SQLDSTypeId] == DBNull.Value ? null : objRow[conQxPrjTab.SQLDSTypeId].ToString().Trim(); //数据源类型
objQxPrjTabEN.TabStateId = objRow[conQxPrjTab.TabStateId].ToString().Trim(); //表状态ID
objQxPrjTabEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objQxPrjTabEN.FuncModuleAgcId = objRow[conQxPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[conQxPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objQxPrjTabEN.Owner = objRow[conQxPrjTab.Owner] == DBNull.Value ? null : objRow[conQxPrjTab.Owner].ToString().Trim(); //拥有者
objQxPrjTabEN.Keyword = objRow[conQxPrjTab.Keyword] == DBNull.Value ? null : objRow[conQxPrjTab.Keyword].ToString().Trim(); //关键字
objQxPrjTabEN.TabTypeId = objRow[conQxPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objQxPrjTabEN.RelaViewId = objRow[conQxPrjTab.RelaViewId] == DBNull.Value ? null : objRow[conQxPrjTab.RelaViewId].ToString().Trim(); //RelaViewId
objQxPrjTabEN.PrimaryTypeId = objRow[conQxPrjTab.PrimaryTypeId] == DBNull.Value ? null : objRow[conQxPrjTab.PrimaryTypeId].ToString().Trim(); //主键类型ID
objQxPrjTabEN.PrimaryTypeName = objRow[conQxPrjTab.PrimaryTypeName] == DBNull.Value ? null : objRow[conQxPrjTab.PrimaryTypeName].ToString().Trim(); //主键类型名
objQxPrjTabEN.KeyFldId = objRow[conQxPrjTab.KeyFldId] == DBNull.Value ? null : objRow[conQxPrjTab.KeyFldId].ToString().Trim(); //关键字段Id
objQxPrjTabEN.KeyFldName = objRow[conQxPrjTab.KeyFldName] == DBNull.Value ? null : objRow[conQxPrjTab.KeyFldName].ToString().Trim(); //关键字段名
objQxPrjTabEN.UpdUserId = objRow[conQxPrjTab.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjTabEN.UpdDate = objRow[conQxPrjTab.UpdDate] == DBNull.Value ? null : objRow[conQxPrjTab.UpdDate].ToString().Trim(); //修改日期
objQxPrjTabEN.Memo = objRow[conQxPrjTab.Memo] == DBNull.Value ? null : objRow[conQxPrjTab.Memo].ToString().Trim(); //备注
objQxPrjTabEN.SynchDate = objRow[conQxPrjTab.SynchDate] == DBNull.Value ? null : objRow[conQxPrjTab.SynchDate].ToString().Trim(); //同步日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjTabEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPrjTabEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsQxPrjTabEN> arrObjLst = new List<clsQxPrjTabEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjTabEN objQxPrjTabEN = new clsQxPrjTabEN();
try
{
objQxPrjTabEN.TabId = objRow[conQxPrjTab.TabId].ToString().Trim(); //表ID
objQxPrjTabEN.TabName = objRow[conQxPrjTab.TabName].ToString().Trim(); //TabName
objQxPrjTabEN.TabCnName = objRow[conQxPrjTab.TabCnName] == DBNull.Value ? null : objRow[conQxPrjTab.TabCnName].ToString().Trim(); //表中文名
objQxPrjTabEN.QxPrjId = objRow[conQxPrjTab.QxPrjId].ToString().Trim(); //项目Id
objQxPrjTabEN.SQLDSTypeId = objRow[conQxPrjTab.SQLDSTypeId] == DBNull.Value ? null : objRow[conQxPrjTab.SQLDSTypeId].ToString().Trim(); //数据源类型
objQxPrjTabEN.TabStateId = objRow[conQxPrjTab.TabStateId].ToString().Trim(); //表状态ID
objQxPrjTabEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[conQxPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objQxPrjTabEN.FuncModuleAgcId = objRow[conQxPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[conQxPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objQxPrjTabEN.Owner = objRow[conQxPrjTab.Owner] == DBNull.Value ? null : objRow[conQxPrjTab.Owner].ToString().Trim(); //拥有者
objQxPrjTabEN.Keyword = objRow[conQxPrjTab.Keyword] == DBNull.Value ? null : objRow[conQxPrjTab.Keyword].ToString().Trim(); //关键字
objQxPrjTabEN.TabTypeId = objRow[conQxPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objQxPrjTabEN.RelaViewId = objRow[conQxPrjTab.RelaViewId] == DBNull.Value ? null : objRow[conQxPrjTab.RelaViewId].ToString().Trim(); //RelaViewId
objQxPrjTabEN.PrimaryTypeId = objRow[conQxPrjTab.PrimaryTypeId] == DBNull.Value ? null : objRow[conQxPrjTab.PrimaryTypeId].ToString().Trim(); //主键类型ID
objQxPrjTabEN.PrimaryTypeName = objRow[conQxPrjTab.PrimaryTypeName] == DBNull.Value ? null : objRow[conQxPrjTab.PrimaryTypeName].ToString().Trim(); //主键类型名
objQxPrjTabEN.KeyFldId = objRow[conQxPrjTab.KeyFldId] == DBNull.Value ? null : objRow[conQxPrjTab.KeyFldId].ToString().Trim(); //关键字段Id
objQxPrjTabEN.KeyFldName = objRow[conQxPrjTab.KeyFldName] == DBNull.Value ? null : objRow[conQxPrjTab.KeyFldName].ToString().Trim(); //关键字段名
objQxPrjTabEN.UpdUserId = objRow[conQxPrjTab.UpdUserId] == DBNull.Value ? null : objRow[conQxPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objQxPrjTabEN.UpdDate = objRow[conQxPrjTab.UpdDate] == DBNull.Value ? null : objRow[conQxPrjTab.UpdDate].ToString().Trim(); //修改日期
objQxPrjTabEN.Memo = objRow[conQxPrjTab.Memo] == DBNull.Value ? null : objRow[conQxPrjTab.Memo].ToString().Trim(); //备注
objQxPrjTabEN.SynchDate = objRow[conQxPrjTab.SynchDate] == DBNull.Value ? null : objRow[conQxPrjTab.SynchDate].ToString().Trim(); //同步日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjTabEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjTabEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objQxPrjTabEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxPrjTab(ref clsQxPrjTabEN objQxPrjTabEN)
{
bool bolResult = QxPrjTabDA.GetQxPrjTab(ref objQxPrjTabEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strTabId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxPrjTabEN GetObjByTabId(string strTabId)
{
if (strTabId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strTabId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strTabId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strTabId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsQxPrjTabEN objQxPrjTabEN = QxPrjTabDA.GetObjByTabId(strTabId);
return objQxPrjTabEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsQxPrjTabEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsQxPrjTabEN objQxPrjTabEN = QxPrjTabDA.GetFirstObj(strWhereCond);
 return objQxPrjTabEN;
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
public static clsQxPrjTabEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsQxPrjTabEN objQxPrjTabEN = QxPrjTabDA.GetObjByDataRow(objRow);
 return objQxPrjTabEN;
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
public static clsQxPrjTabEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsQxPrjTabEN objQxPrjTabEN = QxPrjTabDA.GetObjByDataRow(objRow);
 return objQxPrjTabEN;
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
 /// <param name = "strTabId">所给的关键字</param>
 /// <param name = "lstQxPrjTabObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxPrjTabEN GetObjByTabIdFromList(string strTabId, List<clsQxPrjTabEN> lstQxPrjTabObjLst)
{
foreach (clsQxPrjTabEN objQxPrjTabEN in lstQxPrjTabObjLst)
{
if (objQxPrjTabEN.TabId == strTabId)
{
return objQxPrjTabEN;
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
 string strMaxTabId;
 try
 {
 strMaxTabId = new clsQxPrjTabDA().GetMaxStrIdByPrefix(strPrefix);
 return strMaxTabId;
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
 string strTabId;
 try
 {
 strTabId = new clsQxPrjTabDA().GetFirstID(strWhereCond);
 return strTabId;
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
 arrList = QxPrjTabDA.GetID(strWhereCond);
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
bool bolIsExist = QxPrjTabDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strTabId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strTabId)
{
if (string.IsNullOrEmpty(strTabId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strTabId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = QxPrjTabDA.IsExist(strTabId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strTabId">表ID</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strTabId, string strOpUser)
{
clsQxPrjTabEN objQxPrjTabEN = clsQxPrjTabBL.GetObjByTabId(strTabId);
objQxPrjTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objQxPrjTabEN.UpdUserId = strOpUser;
return clsQxPrjTabBL.UpdateBySql2(objQxPrjTabEN);
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
 bolIsExist = clsQxPrjTabDA.IsExistTable();
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
 bolIsExist = QxPrjTabDA.IsExistTable(strTabName);
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
 /// <param name = "objQxPrjTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsQxPrjTabEN objQxPrjTabEN)
{
 if (string.IsNullOrEmpty(objQxPrjTabEN.TabId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQxPrjTabBL.IsExist(objQxPrjTabEN.TabId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQxPrjTabEN.TabId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (objQxPrjTabEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!TabName = [{0}],项目Id = [{1}]的数据已经存在!(in clsQxPrjTabBL.AddNewRecordBySql2)", objQxPrjTabEN.TabName,objQxPrjTabEN.QxPrjId);
throw new Exception(strMsg);
}
try
{
bool bolResult = QxPrjTabDA.AddNewRecordBySQL2(objQxPrjTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjTabBL.ReFreshCache();

if (clsQxPrjTabBL.relatedActions != null)
{
clsQxPrjTabBL.relatedActions.UpdRelaTabDate(objQxPrjTabEN.TabId, objQxPrjTabEN.UpdUserId);
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
 /// <param name = "objQxPrjTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsQxPrjTabEN objQxPrjTabEN)
{
 if (string.IsNullOrEmpty(objQxPrjTabEN.TabId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQxPrjTabBL.IsExist(objQxPrjTabEN.TabId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQxPrjTabEN.TabId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (objQxPrjTabEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!TabName = [{0}],项目Id = [{1}]的数据已经存在!(in clsQxPrjTabBL.AddNewRecordBySql2WithReturnKey)", objQxPrjTabEN.TabName,objQxPrjTabEN.QxPrjId);
throw new Exception(strMsg);
}
try
{
string strKey = QxPrjTabDA.AddNewRecordBySQL2WithReturnKey(objQxPrjTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjTabBL.ReFreshCache();

if (clsQxPrjTabBL.relatedActions != null)
{
clsQxPrjTabBL.relatedActions.UpdRelaTabDate(objQxPrjTabEN.TabId, objQxPrjTabEN.UpdUserId);
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
 /// <param name = "strQxPrjTabObjXml">代表实体对象的XML串</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql_XML(string strQxPrjTabObjXml)
{
clsQxPrjTabEN objQxPrjTabEN = GetObjFromXmlStr(strQxPrjTabObjXml);
try
{
bool bolResult = QxPrjTabDA.AddNewRecordBySQL2(objQxPrjTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjTabBL.ReFreshCache();

if (clsQxPrjTabBL.relatedActions != null)
{
clsQxPrjTabBL.relatedActions.UpdRelaTabDate(objQxPrjTabEN.TabId, objQxPrjTabEN.UpdUserId);
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
 /// <param name = "objQxPrjTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsQxPrjTabEN objQxPrjTabEN)
{
try
{
bool bolResult = QxPrjTabDA.Update(objQxPrjTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjTabBL.ReFreshCache();

if (clsQxPrjTabBL.relatedActions != null)
{
clsQxPrjTabBL.relatedActions.UpdRelaTabDate(objQxPrjTabEN.TabId, objQxPrjTabEN.UpdUserId);
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
 /// <param name = "objQxPrjTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsQxPrjTabEN objQxPrjTabEN)
{
 if (string.IsNullOrEmpty(objQxPrjTabEN.TabId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = QxPrjTabDA.UpdateBySql2(objQxPrjTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjTabBL.ReFreshCache();

if (clsQxPrjTabBL.relatedActions != null)
{
clsQxPrjTabBL.relatedActions.UpdRelaTabDate(objQxPrjTabEN.TabId, objQxPrjTabEN.UpdUserId);
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
 /// <param name = "strQxPrjTabObjXml">需要修改的对象,用XML来表示</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql_XML(string strQxPrjTabObjXml)
{
clsQxPrjTabEN objQxPrjTabEN = GetObjFromXmlStr(strQxPrjTabObjXml);
try
{
bool bolResult = QxPrjTabDA.UpdateBySql2(objQxPrjTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjTabBL.ReFreshCache();

if (clsQxPrjTabBL.relatedActions != null)
{
clsQxPrjTabBL.relatedActions.UpdRelaTabDate(objQxPrjTabEN.TabId, objQxPrjTabEN.UpdUserId);
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
 /// <param name = "strTabId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strTabId)
{
try
{
 clsQxPrjTabEN objQxPrjTabEN = clsQxPrjTabBL.GetObjByTabId(strTabId);

if (clsQxPrjTabBL.relatedActions != null)
{
clsQxPrjTabBL.relatedActions.UpdRelaTabDate(objQxPrjTabEN.TabId, objQxPrjTabEN.UpdUserId);
}
if (objQxPrjTabEN != null)
{
int intRecNum = QxPrjTabDA.DelRecord(strTabId);
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
/// <param name="strTabId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strTabId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxPrjTabDA.GetSpecSQLObj();
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
//删除与表:[QxPrjTab]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conQxPrjTab.TabId,
//strTabId);
//        clsQxPrjTabBL.DelQxPrjTabsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxPrjTabBL.DelRecord(strTabId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxPrjTabBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strTabId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strTabId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strTabId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsQxPrjTabBL.relatedActions != null)
{
clsQxPrjTabBL.relatedActions.UpdRelaTabDate(strTabId, "UpdRelaTabDate");
}
bool bolResult = QxPrjTabDA.DelRecord(strTabId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "strTabId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strTabId) 
{
try
{
if (clsQxPrjTabBL.relatedActions != null)
{
clsQxPrjTabBL.relatedActions.UpdRelaTabDate(strTabId, "UpdRelaTabDate");
}
bool bolResult = QxPrjTabDA.DelRecordBySP(strTabId);
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
 /// <param name = "arrTabIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelQxPrjTabs(List<string> arrTabIdLst)
{
if (arrTabIdLst.Count == 0) return 0;
try
{
if (clsQxPrjTabBL.relatedActions != null)
{
foreach (var strTabId in arrTabIdLst)
{
clsQxPrjTabBL.relatedActions.UpdRelaTabDate(strTabId, "UpdRelaTabDate");
}
}
int intDelRecNum = QxPrjTabDA.DelQxPrjTab(arrTabIdLst);
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
public static int DelQxPrjTabsByCond(string strWhereCond)
{
try
{
if (clsQxPrjTabBL.relatedActions != null)
{
List<string> arrTabId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strTabId in arrTabId)
{
clsQxPrjTabBL.relatedActions.UpdRelaTabDate(strTabId, "UpdRelaTabDate");
}
}
int intRecNum = QxPrjTabDA.DelQxPrjTab(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[QxPrjTab]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strTabId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strTabId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxPrjTabDA.GetSpecSQLObj();
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
//删除与表:[QxPrjTab]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxPrjTabBL.DelRecord(strTabId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxPrjTabBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strTabId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objQxPrjTabENS">源对象</param>
 /// <param name = "objQxPrjTabENT">目标对象</param>
 public static void CopyTo(clsQxPrjTabEN objQxPrjTabENS, clsQxPrjTabEN objQxPrjTabENT)
{
try
{
objQxPrjTabENT.TabId = objQxPrjTabENS.TabId; //表ID
objQxPrjTabENT.TabName = objQxPrjTabENS.TabName; //TabName
objQxPrjTabENT.TabCnName = objQxPrjTabENS.TabCnName; //表中文名
objQxPrjTabENT.QxPrjId = objQxPrjTabENS.QxPrjId; //项目Id
objQxPrjTabENT.SQLDSTypeId = objQxPrjTabENS.SQLDSTypeId; //数据源类型
objQxPrjTabENT.TabStateId = objQxPrjTabENS.TabStateId; //表状态ID
objQxPrjTabENT.IsParaTab = objQxPrjTabENS.IsParaTab; //是否参数表
objQxPrjTabENT.FuncModuleAgcId = objQxPrjTabENS.FuncModuleAgcId; //功能模块Id
objQxPrjTabENT.Owner = objQxPrjTabENS.Owner; //拥有者
objQxPrjTabENT.Keyword = objQxPrjTabENS.Keyword; //关键字
objQxPrjTabENT.TabTypeId = objQxPrjTabENS.TabTypeId; //表类型Id
objQxPrjTabENT.RelaViewId = objQxPrjTabENS.RelaViewId; //RelaViewId
objQxPrjTabENT.PrimaryTypeId = objQxPrjTabENS.PrimaryTypeId; //主键类型ID
objQxPrjTabENT.PrimaryTypeName = objQxPrjTabENS.PrimaryTypeName; //主键类型名
objQxPrjTabENT.KeyFldId = objQxPrjTabENS.KeyFldId; //关键字段Id
objQxPrjTabENT.KeyFldName = objQxPrjTabENS.KeyFldName; //关键字段名
objQxPrjTabENT.UpdUserId = objQxPrjTabENS.UpdUserId; //修改用户Id
objQxPrjTabENT.UpdDate = objQxPrjTabENS.UpdDate; //修改日期
objQxPrjTabENT.Memo = objQxPrjTabENS.Memo; //备注
objQxPrjTabENT.SynchDate = objQxPrjTabENS.SynchDate; //同步日期
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
 /// <param name = "objQxPrjTabEN">源简化对象</param>
 public static void SetUpdFlag(clsQxPrjTabEN objQxPrjTabEN)
{
try
{
objQxPrjTabEN.ClearUpdateState();
   string strsfUpdFldSetStr = objQxPrjTabEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conQxPrjTab.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjTabEN.TabId = objQxPrjTabEN.TabId; //表ID
}
if (arrFldSet.Contains(conQxPrjTab.TabName, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjTabEN.TabName = objQxPrjTabEN.TabName; //TabName
}
if (arrFldSet.Contains(conQxPrjTab.TabCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjTabEN.TabCnName = objQxPrjTabEN.TabCnName == "[null]" ? null :  objQxPrjTabEN.TabCnName; //表中文名
}
if (arrFldSet.Contains(conQxPrjTab.QxPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjTabEN.QxPrjId = objQxPrjTabEN.QxPrjId; //项目Id
}
if (arrFldSet.Contains(conQxPrjTab.SQLDSTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjTabEN.SQLDSTypeId = objQxPrjTabEN.SQLDSTypeId == "[null]" ? null :  objQxPrjTabEN.SQLDSTypeId; //数据源类型
}
if (arrFldSet.Contains(conQxPrjTab.TabStateId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjTabEN.TabStateId = objQxPrjTabEN.TabStateId; //表状态ID
}
if (arrFldSet.Contains(conQxPrjTab.IsParaTab, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjTabEN.IsParaTab = objQxPrjTabEN.IsParaTab; //是否参数表
}
if (arrFldSet.Contains(conQxPrjTab.FuncModuleAgcId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjTabEN.FuncModuleAgcId = objQxPrjTabEN.FuncModuleAgcId == "[null]" ? null :  objQxPrjTabEN.FuncModuleAgcId; //功能模块Id
}
if (arrFldSet.Contains(conQxPrjTab.Owner, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjTabEN.Owner = objQxPrjTabEN.Owner == "[null]" ? null :  objQxPrjTabEN.Owner; //拥有者
}
if (arrFldSet.Contains(conQxPrjTab.Keyword, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjTabEN.Keyword = objQxPrjTabEN.Keyword == "[null]" ? null :  objQxPrjTabEN.Keyword; //关键字
}
if (arrFldSet.Contains(conQxPrjTab.TabTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjTabEN.TabTypeId = objQxPrjTabEN.TabTypeId; //表类型Id
}
if (arrFldSet.Contains(conQxPrjTab.RelaViewId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjTabEN.RelaViewId = objQxPrjTabEN.RelaViewId == "[null]" ? null :  objQxPrjTabEN.RelaViewId; //RelaViewId
}
if (arrFldSet.Contains(conQxPrjTab.PrimaryTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjTabEN.PrimaryTypeId = objQxPrjTabEN.PrimaryTypeId == "[null]" ? null :  objQxPrjTabEN.PrimaryTypeId; //主键类型ID
}
if (arrFldSet.Contains(conQxPrjTab.PrimaryTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjTabEN.PrimaryTypeName = objQxPrjTabEN.PrimaryTypeName == "[null]" ? null :  objQxPrjTabEN.PrimaryTypeName; //主键类型名
}
if (arrFldSet.Contains(conQxPrjTab.KeyFldId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjTabEN.KeyFldId = objQxPrjTabEN.KeyFldId == "[null]" ? null :  objQxPrjTabEN.KeyFldId; //关键字段Id
}
if (arrFldSet.Contains(conQxPrjTab.KeyFldName, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjTabEN.KeyFldName = objQxPrjTabEN.KeyFldName == "[null]" ? null :  objQxPrjTabEN.KeyFldName; //关键字段名
}
if (arrFldSet.Contains(conQxPrjTab.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjTabEN.UpdUserId = objQxPrjTabEN.UpdUserId == "[null]" ? null :  objQxPrjTabEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conQxPrjTab.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjTabEN.UpdDate = objQxPrjTabEN.UpdDate == "[null]" ? null :  objQxPrjTabEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conQxPrjTab.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjTabEN.Memo = objQxPrjTabEN.Memo == "[null]" ? null :  objQxPrjTabEN.Memo; //备注
}
if (arrFldSet.Contains(conQxPrjTab.SynchDate, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjTabEN.SynchDate = objQxPrjTabEN.SynchDate == "[null]" ? null :  objQxPrjTabEN.SynchDate; //同步日期
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
 /// <param name = "objQxPrjTabEN">源简化对象</param>
 public static void AccessFldValueNull(clsQxPrjTabEN objQxPrjTabEN)
{
try
{
if (objQxPrjTabEN.TabCnName == "[null]") objQxPrjTabEN.TabCnName = null; //表中文名
if (objQxPrjTabEN.SQLDSTypeId == "[null]") objQxPrjTabEN.SQLDSTypeId = null; //数据源类型
if (objQxPrjTabEN.FuncModuleAgcId == "[null]") objQxPrjTabEN.FuncModuleAgcId = null; //功能模块Id
if (objQxPrjTabEN.Owner == "[null]") objQxPrjTabEN.Owner = null; //拥有者
if (objQxPrjTabEN.Keyword == "[null]") objQxPrjTabEN.Keyword = null; //关键字
if (objQxPrjTabEN.RelaViewId == "[null]") objQxPrjTabEN.RelaViewId = null; //RelaViewId
if (objQxPrjTabEN.PrimaryTypeId == "[null]") objQxPrjTabEN.PrimaryTypeId = null; //主键类型ID
if (objQxPrjTabEN.PrimaryTypeName == "[null]") objQxPrjTabEN.PrimaryTypeName = null; //主键类型名
if (objQxPrjTabEN.KeyFldId == "[null]") objQxPrjTabEN.KeyFldId = null; //关键字段Id
if (objQxPrjTabEN.KeyFldName == "[null]") objQxPrjTabEN.KeyFldName = null; //关键字段名
if (objQxPrjTabEN.UpdUserId == "[null]") objQxPrjTabEN.UpdUserId = null; //修改用户Id
if (objQxPrjTabEN.UpdDate == "[null]") objQxPrjTabEN.UpdDate = null; //修改日期
if (objQxPrjTabEN.Memo == "[null]") objQxPrjTabEN.Memo = null; //备注
if (objQxPrjTabEN.SynchDate == "[null]") objQxPrjTabEN.SynchDate = null; //同步日期
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
public static void CheckPropertyNew(clsQxPrjTabEN objQxPrjTabEN)
{
 QxPrjTabDA.CheckPropertyNew(objQxPrjTabEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsQxPrjTabEN objQxPrjTabEN)
{
 QxPrjTabDA.CheckProperty4Condition(objQxPrjTabEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_TabId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conQxPrjTab.TabId); 
List<clsQxPrjTabEN> arrObjLst = clsQxPrjTabBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsQxPrjTabEN objQxPrjTabEN = new clsQxPrjTabEN()
{
TabId = "0",
TabName = "选[工程表]..."
};
arrObjLst.Insert(0, objQxPrjTabEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conQxPrjTab.TabId;
objComboBox.DisplayMember = conQxPrjTab.TabName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_TabId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[工程表]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conQxPrjTab.TabId); 
IEnumerable<clsQxPrjTabEN> arrObjLst = clsQxPrjTabBL.GetObjLst(strCondition);
objDDL.DataValueField = conQxPrjTab.TabId;
objDDL.DataTextField = conQxPrjTab.TabName;
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
public static void BindDdl_TabIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[工程表]...","0");
List<clsQxPrjTabEN> arrQxPrjTabObjLst = GetAllQxPrjTabObjLstCache(); 
objDDL.DataValueField = conQxPrjTab.TabId;
objDDL.DataTextField = conQxPrjTab.TabName;
objDDL.DataSource = arrQxPrjTabObjLst;
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
if (clsQxPrjTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxPrjTabBL没有刷新缓存机制(clsQxPrjTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by TabId");
//if (arrQxPrjTabObjLstCache == null)
//{
//arrQxPrjTabObjLstCache = QxPrjTabDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strTabId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxPrjTabEN GetObjByTabIdCache(string strTabId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsQxPrjTabEN._CurrTabName);
List<clsQxPrjTabEN> arrQxPrjTabObjLstCache = GetObjLstCache();
IEnumerable <clsQxPrjTabEN> arrQxPrjTabObjLst_Sel =
arrQxPrjTabObjLstCache
.Where(x=> x.TabId == strTabId 
);
if (arrQxPrjTabObjLst_Sel.Count() == 0)
{
   clsQxPrjTabEN obj = clsQxPrjTabBL.GetObjByTabId(strTabId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrQxPrjTabObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strTabId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetTabNameByTabIdCache(string strTabId)
{
if (string.IsNullOrEmpty(strTabId) == true) return "";
//获取缓存中的对象列表
clsQxPrjTabEN objQxPrjTab = GetObjByTabIdCache(strTabId);
if (objQxPrjTab == null) return "";
return objQxPrjTab.TabName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strTabId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByTabIdCache(string strTabId)
{
if (string.IsNullOrEmpty(strTabId) == true) return "";
//获取缓存中的对象列表
clsQxPrjTabEN objQxPrjTab = GetObjByTabIdCache(strTabId);
if (objQxPrjTab == null) return "";
return objQxPrjTab.TabName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxPrjTabEN> GetAllQxPrjTabObjLstCache()
{
//获取缓存中的对象列表
List<clsQxPrjTabEN> arrQxPrjTabObjLstCache = GetObjLstCache(); 
return arrQxPrjTabObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxPrjTabEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsQxPrjTabEN._CurrTabName);
List<clsQxPrjTabEN> arrQxPrjTabObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrQxPrjTabObjLstCache;
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
string strKey = string.Format("{0}", clsQxPrjTabEN._CurrTabName);
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
if (clsQxPrjTabBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsQxPrjTabEN._CurrTabName);
CacheHelper.Remove(strKey);
clsQxPrjTabBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--QxPrjTab(工程表)
 /// 唯一性条件:TabName_QxPrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQxPrjTabEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsQxPrjTabEN objQxPrjTabEN)
{
//检测记录是否存在
string strResult = QxPrjTabDA.GetUniCondStr(objQxPrjTabEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstQxPrjTabObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsQxPrjTabEN> lstQxPrjTabObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstQxPrjTabObjLst, writer);
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
 /// <param name = "lstQxPrjTabObjLst">[clsQxPrjTabEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsQxPrjTabEN> lstQxPrjTabObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsQxPrjTabBL.listXmlNode);
writer.WriteStartElement(clsQxPrjTabBL.itemsXmlNode);
foreach (clsQxPrjTabEN objQxPrjTabEN in lstQxPrjTabObjLst)
{
clsQxPrjTabBL.SerializeXML(writer, objQxPrjTabEN);
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
 /// <param name = "objQxPrjTabEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsQxPrjTabEN objQxPrjTabEN)
{
writer.WriteStartElement(clsQxPrjTabBL.itemXmlNode);
 
if (objQxPrjTabEN.TabId != null)
{
writer.WriteElementString(conQxPrjTab.TabId, objQxPrjTabEN.TabId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjTabEN.TabName != null)
{
writer.WriteElementString(conQxPrjTab.TabName, objQxPrjTabEN.TabName.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjTabEN.TabCnName != null)
{
writer.WriteElementString(conQxPrjTab.TabCnName, objQxPrjTabEN.TabCnName.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjTabEN.QxPrjId != null)
{
writer.WriteElementString(conQxPrjTab.QxPrjId, objQxPrjTabEN.QxPrjId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjTabEN.SQLDSTypeId != null)
{
writer.WriteElementString(conQxPrjTab.SQLDSTypeId, objQxPrjTabEN.SQLDSTypeId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjTabEN.TabStateId != null)
{
writer.WriteElementString(conQxPrjTab.TabStateId, objQxPrjTabEN.TabStateId.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(conQxPrjTab.IsParaTab, objQxPrjTabEN.IsParaTab.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objQxPrjTabEN.FuncModuleAgcId != null)
{
writer.WriteElementString(conQxPrjTab.FuncModuleAgcId, objQxPrjTabEN.FuncModuleAgcId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjTabEN.Owner != null)
{
writer.WriteElementString(conQxPrjTab.Owner, objQxPrjTabEN.Owner.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjTabEN.Keyword != null)
{
writer.WriteElementString(conQxPrjTab.Keyword, objQxPrjTabEN.Keyword.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjTabEN.TabTypeId != null)
{
writer.WriteElementString(conQxPrjTab.TabTypeId, objQxPrjTabEN.TabTypeId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjTabEN.RelaViewId != null)
{
writer.WriteElementString(conQxPrjTab.RelaViewId, objQxPrjTabEN.RelaViewId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjTabEN.PrimaryTypeId != null)
{
writer.WriteElementString(conQxPrjTab.PrimaryTypeId, objQxPrjTabEN.PrimaryTypeId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjTabEN.PrimaryTypeName != null)
{
writer.WriteElementString(conQxPrjTab.PrimaryTypeName, objQxPrjTabEN.PrimaryTypeName.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjTabEN.KeyFldId != null)
{
writer.WriteElementString(conQxPrjTab.KeyFldId, objQxPrjTabEN.KeyFldId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjTabEN.KeyFldName != null)
{
writer.WriteElementString(conQxPrjTab.KeyFldName, objQxPrjTabEN.KeyFldName.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjTabEN.UpdUserId != null)
{
writer.WriteElementString(conQxPrjTab.UpdUserId, objQxPrjTabEN.UpdUserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjTabEN.UpdDate != null)
{
writer.WriteElementString(conQxPrjTab.UpdDate, objQxPrjTabEN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjTabEN.Memo != null)
{
writer.WriteElementString(conQxPrjTab.Memo, objQxPrjTabEN.Memo.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjTabEN.SynchDate != null)
{
writer.WriteElementString(conQxPrjTab.SynchDate, objQxPrjTabEN.SynchDate.ToString(CultureInfo.InvariantCulture));
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
public static clsQxPrjTabEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsQxPrjTabEN objQxPrjTabEN = new clsQxPrjTabEN();
reader.Read();
while (!(reader.Name == clsQxPrjTabBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(conQxPrjTab.TabId))
{
objQxPrjTabEN.TabId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjTab.TabName))
{
objQxPrjTabEN.TabName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjTab.TabCnName))
{
objQxPrjTabEN.TabCnName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjTab.QxPrjId))
{
objQxPrjTabEN.QxPrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjTab.SQLDSTypeId))
{
objQxPrjTabEN.SQLDSTypeId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjTab.TabStateId))
{
objQxPrjTabEN.TabStateId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjTab.IsParaTab))
{
objQxPrjTabEN.IsParaTab = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(conQxPrjTab.FuncModuleAgcId))
{
objQxPrjTabEN.FuncModuleAgcId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjTab.Owner))
{
objQxPrjTabEN.Owner = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjTab.Keyword))
{
objQxPrjTabEN.Keyword = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjTab.TabTypeId))
{
objQxPrjTabEN.TabTypeId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjTab.RelaViewId))
{
objQxPrjTabEN.RelaViewId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjTab.PrimaryTypeId))
{
objQxPrjTabEN.PrimaryTypeId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjTab.PrimaryTypeName))
{
objQxPrjTabEN.PrimaryTypeName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjTab.KeyFldId))
{
objQxPrjTabEN.KeyFldId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjTab.KeyFldName))
{
objQxPrjTabEN.KeyFldName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjTab.UpdUserId))
{
objQxPrjTabEN.UpdUserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjTab.UpdDate))
{
objQxPrjTabEN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjTab.Memo))
{
objQxPrjTabEN.Memo = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjTab.SynchDate))
{
objQxPrjTabEN.SynchDate = reader.ReadElementContentAsString();
}
}
return objQxPrjTabEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strQxPrjTabObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsQxPrjTabEN GetObjFromXmlStr(string strQxPrjTabObjXmlStr)
{
clsQxPrjTabEN objQxPrjTabEN = new clsQxPrjTabEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strQxPrjTabObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsQxPrjTabBL.itemXmlNode))
{
objQxPrjTabEN = GetObjFromXml(reader);
return objQxPrjTabEN;
}
}
return objQxPrjTabEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsQxPrjTabEN objQxPrjTabEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objQxPrjTabEN);
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
public static string Func(string strInFldName, string strOutFldName, string strTabId)
{
if (strInFldName != conQxPrjTab.TabId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conQxPrjTab.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conQxPrjTab.AttributeName));
throw new Exception(strMsg);
}
var objQxPrjTab = clsQxPrjTabBL.GetObjByTabIdCache(strTabId);
if (objQxPrjTab == null) return "";
return objQxPrjTab[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsQxPrjTabEN objQxPrjTabEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsQxPrjTabEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objQxPrjTabEN[strField]);
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
 /// <param name = "lstQxPrjTabObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsQxPrjTabEN> lstQxPrjTabObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstQxPrjTabObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsQxPrjTabEN objQxPrjTabEN in lstQxPrjTabObjLst)
{
string strJSON_One = SerializeObjToJSON(objQxPrjTabEN);
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
int intRecCount = clsQxPrjTabDA.GetRecCount(strTabName);
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
int intRecCount = clsQxPrjTabDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsQxPrjTabDA.GetRecCount();
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
int intRecCount = clsQxPrjTabDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objQxPrjTabCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsQxPrjTabEN objQxPrjTabCond)
{
List<clsQxPrjTabEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxPrjTabEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxPrjTab.AttributeName)
{
if (objQxPrjTabCond.IsUpdated(strFldName) == false) continue;
if (objQxPrjTabCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxPrjTabCond[strFldName].ToString());
}
else
{
if (objQxPrjTabCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxPrjTabCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxPrjTabCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxPrjTabCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxPrjTabCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxPrjTabCond[strFldName]));
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
 List<string> arrList = clsQxPrjTabDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = QxPrjTabDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = QxPrjTabDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = QxPrjTabDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxPrjTabDA.SetFldValue(clsQxPrjTabEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = QxPrjTabDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxPrjTabDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxPrjTabDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxPrjTabDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[QxPrjTab] "); 
 strCreateTabCode.Append(" ( "); 
 // /**表ID*/ 
 strCreateTabCode.Append(" TabId char(8) primary key, "); 
 // /**TabName*/ 
 strCreateTabCode.Append(" TabName varchar(100) not Null, "); 
 // /**表中文名*/ 
 strCreateTabCode.Append(" TabCnName varchar(200) Null, "); 
 // /**项目Id*/ 
 strCreateTabCode.Append(" QxPrjId char(4) not Null, "); 
 // /**数据源类型*/ 
 strCreateTabCode.Append(" SQLDSTypeId char(2) Null, "); 
 // /**表状态ID*/ 
 strCreateTabCode.Append(" TabStateId char(2) not Null, "); 
 // /**是否参数表*/ 
 strCreateTabCode.Append(" IsParaTab bit Null, "); 
 // /**功能模块Id*/ 
 strCreateTabCode.Append(" FuncModuleAgcId char(8) Null, "); 
 // /**拥有者*/ 
 strCreateTabCode.Append(" Owner varchar(50) Null, "); 
 // /**关键字*/ 
 strCreateTabCode.Append(" Keyword varchar(50) Null, "); 
 // /**表类型Id*/ 
 strCreateTabCode.Append(" TabTypeId char(4) not Null, "); 
 // /**RelaViewId*/ 
 strCreateTabCode.Append(" RelaViewId char(8) Null, "); 
 // /**主键类型ID*/ 
 strCreateTabCode.Append(" PrimaryTypeId char(2) Null, "); 
 // /**主键类型名*/ 
 strCreateTabCode.Append(" PrimaryTypeName varchar(30) Null, "); 
 // /**关键字段Id*/ 
 strCreateTabCode.Append(" KeyFldId varchar(8) Null, "); 
 // /**关键字段名*/ 
 strCreateTabCode.Append(" KeyFldName varchar(50) Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**同步日期*/ 
 strCreateTabCode.Append(" SynchDate varchar(14) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 数据同步


 #endregion 数据同步
}
 /// <summary>
 /// 工程表(QxPrjTab)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4QxPrjTab : clsCommFun4BL
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
clsQxPrjTabBL.ReFreshThisCache();
}
}

}