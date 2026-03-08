
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsXzGradeBaseBL
 表名:XzGradeBase(00140043)
 * 版本:2024.02.03.1(服务器:WIN-SRV103-116)
 日期:2024/02/18 11:39:55
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:用户管理(UserManage_GP)
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
public static class  clsXzGradeBaseBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdGradeBase">表关键字</param>
 /// <returns>表对象</returns>
public static clsXzGradeBaseEN GetObj(this K_IdGradeBase_XzGradeBase myKey)
{
clsXzGradeBaseEN objXzGradeBaseEN = clsXzGradeBaseBL.XzGradeBaseDA.GetObjByIdGradeBase(myKey.Value);
return objXzGradeBaseEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsXzGradeBaseEN objXzGradeBaseEN)
{
 if (string.IsNullOrEmpty(objXzGradeBaseEN.IdGradeBase) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsXzGradeBaseBL.IsExist(objXzGradeBaseEN.IdGradeBase) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objXzGradeBaseEN.IdGradeBase, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsXzGradeBaseBL.XzGradeBaseDA.AddNewRecordBySQL2(objXzGradeBaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzGradeBaseBL.ReFreshCache();

if (clsXzGradeBaseBL.relatedActions != null)
{
clsXzGradeBaseBL.relatedActions.UpdRelaTabDate(objXzGradeBaseEN.IdGradeBase, "SetUpdDate");
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
public static bool AddRecordEx(this clsXzGradeBaseEN objXzGradeBaseEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsXzGradeBaseBL.IsExist(objXzGradeBaseEN.IdGradeBase))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objXzGradeBaseEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objXzGradeBaseEN.AddNewRecord();
}
catch(Exception objException)
{
strMsg = "(errid:Busi000152)添加记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsXzGradeBaseEN objXzGradeBaseEN)
{
 if (string.IsNullOrEmpty(objXzGradeBaseEN.IdGradeBase) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsXzGradeBaseBL.IsExist(objXzGradeBaseEN.IdGradeBase) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objXzGradeBaseEN.IdGradeBase, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsXzGradeBaseBL.XzGradeBaseDA.AddNewRecordBySQL2WithReturnKey(objXzGradeBaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzGradeBaseBL.ReFreshCache();

if (clsXzGradeBaseBL.relatedActions != null)
{
clsXzGradeBaseBL.relatedActions.UpdRelaTabDate(objXzGradeBaseEN.IdGradeBase, "SetUpdDate");
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
 /// <param name = "objXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzGradeBaseEN SetIdGradeBase(this clsXzGradeBaseEN objXzGradeBaseEN, string strIdGradeBase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdGradeBase, 4, conXzGradeBase.IdGradeBase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdGradeBase, 4, conXzGradeBase.IdGradeBase);
}
objXzGradeBaseEN.IdGradeBase = strIdGradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzGradeBaseEN.dicFldComparisonOp.ContainsKey(conXzGradeBase.IdGradeBase) == false)
{
objXzGradeBaseEN.dicFldComparisonOp.Add(conXzGradeBase.IdGradeBase, strComparisonOp);
}
else
{
objXzGradeBaseEN.dicFldComparisonOp[conXzGradeBase.IdGradeBase] = strComparisonOp;
}
}
return objXzGradeBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzGradeBaseEN SetGradeBaseId(this clsXzGradeBaseEN objXzGradeBaseEN, string strGradeBaseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGradeBaseId, conXzGradeBase.GradeBaseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGradeBaseId, 4, conXzGradeBase.GradeBaseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGradeBaseId, 4, conXzGradeBase.GradeBaseId);
}
objXzGradeBaseEN.GradeBaseId = strGradeBaseId; //年级代号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzGradeBaseEN.dicFldComparisonOp.ContainsKey(conXzGradeBase.GradeBaseId) == false)
{
objXzGradeBaseEN.dicFldComparisonOp.Add(conXzGradeBase.GradeBaseId, strComparisonOp);
}
else
{
objXzGradeBaseEN.dicFldComparisonOp[conXzGradeBase.GradeBaseId] = strComparisonOp;
}
}
return objXzGradeBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzGradeBaseEN SetGradeBaseName(this clsXzGradeBaseEN objXzGradeBaseEN, string strGradeBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGradeBaseName, conXzGradeBase.GradeBaseName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGradeBaseName, 20, conXzGradeBase.GradeBaseName);
}
objXzGradeBaseEN.GradeBaseName = strGradeBaseName; //年级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzGradeBaseEN.dicFldComparisonOp.ContainsKey(conXzGradeBase.GradeBaseName) == false)
{
objXzGradeBaseEN.dicFldComparisonOp.Add(conXzGradeBase.GradeBaseName, strComparisonOp);
}
else
{
objXzGradeBaseEN.dicFldComparisonOp[conXzGradeBase.GradeBaseName] = strComparisonOp;
}
}
return objXzGradeBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzGradeBaseEN SetSchoolYear(this clsXzGradeBaseEN objXzGradeBaseEN, string strSchoolYear, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolYear, conXzGradeBase.SchoolYear);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolYear, 10, conXzGradeBase.SchoolYear);
}
objXzGradeBaseEN.SchoolYear = strSchoolYear; //学年
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzGradeBaseEN.dicFldComparisonOp.ContainsKey(conXzGradeBase.SchoolYear) == false)
{
objXzGradeBaseEN.dicFldComparisonOp.Add(conXzGradeBase.SchoolYear, strComparisonOp);
}
else
{
objXzGradeBaseEN.dicFldComparisonOp[conXzGradeBase.SchoolYear] = strComparisonOp;
}
}
return objXzGradeBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzGradeBaseEN SetSchoolTerm(this clsXzGradeBaseEN objXzGradeBaseEN, string strSchoolTerm, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolTerm, conXzGradeBase.SchoolTerm);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, conXzGradeBase.SchoolTerm);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, conXzGradeBase.SchoolTerm);
}
objXzGradeBaseEN.SchoolTerm = strSchoolTerm; //学期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzGradeBaseEN.dicFldComparisonOp.ContainsKey(conXzGradeBase.SchoolTerm) == false)
{
objXzGradeBaseEN.dicFldComparisonOp.Add(conXzGradeBase.SchoolTerm, strComparisonOp);
}
else
{
objXzGradeBaseEN.dicFldComparisonOp[conXzGradeBase.SchoolTerm] = strComparisonOp;
}
}
return objXzGradeBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzGradeBaseEN SetEnterSchoolDate(this clsXzGradeBaseEN objXzGradeBaseEN, string strEnterSchoolDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEnterSchoolDate, 8, conXzGradeBase.EnterSchoolDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strEnterSchoolDate, 8, conXzGradeBase.EnterSchoolDate);
}
objXzGradeBaseEN.EnterSchoolDate = strEnterSchoolDate; //进校日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzGradeBaseEN.dicFldComparisonOp.ContainsKey(conXzGradeBase.EnterSchoolDate) == false)
{
objXzGradeBaseEN.dicFldComparisonOp.Add(conXzGradeBase.EnterSchoolDate, strComparisonOp);
}
else
{
objXzGradeBaseEN.dicFldComparisonOp[conXzGradeBase.EnterSchoolDate] = strComparisonOp;
}
}
return objXzGradeBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzGradeBaseEN SetCurrentTermSeq(this clsXzGradeBaseEN objXzGradeBaseEN, int? intCurrentTermSeq, string strComparisonOp="")
	{
objXzGradeBaseEN.CurrentTermSeq = intCurrentTermSeq; //当前学期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzGradeBaseEN.dicFldComparisonOp.ContainsKey(conXzGradeBase.CurrentTermSeq) == false)
{
objXzGradeBaseEN.dicFldComparisonOp.Add(conXzGradeBase.CurrentTermSeq, strComparisonOp);
}
else
{
objXzGradeBaseEN.dicFldComparisonOp[conXzGradeBase.CurrentTermSeq] = strComparisonOp;
}
}
return objXzGradeBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzGradeBaseEN SetExecPlanTermIndex(this clsXzGradeBaseEN objXzGradeBaseEN, int? intExecPlanTermIndex, string strComparisonOp="")
	{
objXzGradeBaseEN.ExecPlanTermIndex = intExecPlanTermIndex; //生成执行计划学期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzGradeBaseEN.dicFldComparisonOp.ContainsKey(conXzGradeBase.ExecPlanTermIndex) == false)
{
objXzGradeBaseEN.dicFldComparisonOp.Add(conXzGradeBase.ExecPlanTermIndex, strComparisonOp);
}
else
{
objXzGradeBaseEN.dicFldComparisonOp[conXzGradeBase.ExecPlanTermIndex] = strComparisonOp;
}
}
return objXzGradeBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzGradeBaseEN SetSetEPTermIndexDate(this clsXzGradeBaseEN objXzGradeBaseEN, string strSetEPTermIndexDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSetEPTermIndexDate, 8, conXzGradeBase.SetEPTermIndexDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSetEPTermIndexDate, 8, conXzGradeBase.SetEPTermIndexDate);
}
objXzGradeBaseEN.SetEPTermIndexDate = strSetEPTermIndexDate; //设定执行计划学期日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzGradeBaseEN.dicFldComparisonOp.ContainsKey(conXzGradeBase.SetEPTermIndexDate) == false)
{
objXzGradeBaseEN.dicFldComparisonOp.Add(conXzGradeBase.SetEPTermIndexDate, strComparisonOp);
}
else
{
objXzGradeBaseEN.dicFldComparisonOp[conXzGradeBase.SetEPTermIndexDate] = strComparisonOp;
}
}
return objXzGradeBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzGradeBaseEN SetIsOffed(this clsXzGradeBaseEN objXzGradeBaseEN, bool bolIsOffed, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsOffed, conXzGradeBase.IsOffed);
objXzGradeBaseEN.IsOffed = bolIsOffed; //是否毕业
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzGradeBaseEN.dicFldComparisonOp.ContainsKey(conXzGradeBase.IsOffed) == false)
{
objXzGradeBaseEN.dicFldComparisonOp.Add(conXzGradeBase.IsOffed, strComparisonOp);
}
else
{
objXzGradeBaseEN.dicFldComparisonOp[conXzGradeBase.IsOffed] = strComparisonOp;
}
}
return objXzGradeBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzGradeBaseEN SetModifyDate(this clsXzGradeBaseEN objXzGradeBaseEN, string strModifyDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strModifyDate, 20, conXzGradeBase.ModifyDate);
}
objXzGradeBaseEN.ModifyDate = strModifyDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzGradeBaseEN.dicFldComparisonOp.ContainsKey(conXzGradeBase.ModifyDate) == false)
{
objXzGradeBaseEN.dicFldComparisonOp.Add(conXzGradeBase.ModifyDate, strComparisonOp);
}
else
{
objXzGradeBaseEN.dicFldComparisonOp[conXzGradeBase.ModifyDate] = strComparisonOp;
}
}
return objXzGradeBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzGradeBaseEN SetModifyUserId(this clsXzGradeBaseEN objXzGradeBaseEN, string strModifyUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strModifyUserId, 18, conXzGradeBase.ModifyUserId);
}
objXzGradeBaseEN.ModifyUserId = strModifyUserId; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzGradeBaseEN.dicFldComparisonOp.ContainsKey(conXzGradeBase.ModifyUserId) == false)
{
objXzGradeBaseEN.dicFldComparisonOp.Add(conXzGradeBase.ModifyUserId, strComparisonOp);
}
else
{
objXzGradeBaseEN.dicFldComparisonOp[conXzGradeBase.ModifyUserId] = strComparisonOp;
}
}
return objXzGradeBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzGradeBaseEN SetGradeIndex(this clsXzGradeBaseEN objXzGradeBaseEN, int? intGradeIndex, string strComparisonOp="")
	{
objXzGradeBaseEN.GradeIndex = intGradeIndex; //年级序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzGradeBaseEN.dicFldComparisonOp.ContainsKey(conXzGradeBase.GradeIndex) == false)
{
objXzGradeBaseEN.dicFldComparisonOp.Add(conXzGradeBase.GradeIndex, strComparisonOp);
}
else
{
objXzGradeBaseEN.dicFldComparisonOp[conXzGradeBase.GradeIndex] = strComparisonOp;
}
}
return objXzGradeBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzGradeBaseEN SetBeginYearMonth(this clsXzGradeBaseEN objXzGradeBaseEN, string strBeginYearMonth, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strBeginYearMonth, 8, conXzGradeBase.BeginYearMonth);
}
objXzGradeBaseEN.BeginYearMonth = strBeginYearMonth; //开始年月
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzGradeBaseEN.dicFldComparisonOp.ContainsKey(conXzGradeBase.BeginYearMonth) == false)
{
objXzGradeBaseEN.dicFldComparisonOp.Add(conXzGradeBase.BeginYearMonth, strComparisonOp);
}
else
{
objXzGradeBaseEN.dicFldComparisonOp[conXzGradeBase.BeginYearMonth] = strComparisonOp;
}
}
return objXzGradeBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzGradeBaseEN SetEndYearMonth(this clsXzGradeBaseEN objXzGradeBaseEN, string strEndYearMonth, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEndYearMonth, 8, conXzGradeBase.EndYearMonth);
}
objXzGradeBaseEN.EndYearMonth = strEndYearMonth; //结束年月
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzGradeBaseEN.dicFldComparisonOp.ContainsKey(conXzGradeBase.EndYearMonth) == false)
{
objXzGradeBaseEN.dicFldComparisonOp.Add(conXzGradeBase.EndYearMonth, strComparisonOp);
}
else
{
objXzGradeBaseEN.dicFldComparisonOp[conXzGradeBase.EndYearMonth] = strComparisonOp;
}
}
return objXzGradeBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzGradeBaseEN SetAllowUpBaseInfo(this clsXzGradeBaseEN objXzGradeBaseEN, bool bolAllowUpBaseInfo, string strComparisonOp="")
	{
objXzGradeBaseEN.AllowUpBaseInfo = bolAllowUpBaseInfo; //允许修改基本信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzGradeBaseEN.dicFldComparisonOp.ContainsKey(conXzGradeBase.AllowUpBaseInfo) == false)
{
objXzGradeBaseEN.dicFldComparisonOp.Add(conXzGradeBase.AllowUpBaseInfo, strComparisonOp);
}
else
{
objXzGradeBaseEN.dicFldComparisonOp[conXzGradeBase.AllowUpBaseInfo] = strComparisonOp;
}
}
return objXzGradeBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzGradeBaseEN SetGradeBaseNameA(this clsXzGradeBaseEN objXzGradeBaseEN, string strGradeBaseNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGradeBaseNameA, 10, conXzGradeBase.GradeBaseNameA);
}
objXzGradeBaseEN.GradeBaseNameA = strGradeBaseNameA; //GradeBaseNameA
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzGradeBaseEN.dicFldComparisonOp.ContainsKey(conXzGradeBase.GradeBaseNameA) == false)
{
objXzGradeBaseEN.dicFldComparisonOp.Add(conXzGradeBase.GradeBaseNameA, strComparisonOp);
}
else
{
objXzGradeBaseEN.dicFldComparisonOp[conXzGradeBase.GradeBaseNameA] = strComparisonOp;
}
}
return objXzGradeBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzGradeBaseEN SetIsVisible(this clsXzGradeBaseEN objXzGradeBaseEN, bool bolIsVisible, string strComparisonOp="")
	{
objXzGradeBaseEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzGradeBaseEN.dicFldComparisonOp.ContainsKey(conXzGradeBase.IsVisible) == false)
{
objXzGradeBaseEN.dicFldComparisonOp.Add(conXzGradeBase.IsVisible, strComparisonOp);
}
else
{
objXzGradeBaseEN.dicFldComparisonOp[conXzGradeBase.IsVisible] = strComparisonOp;
}
}
return objXzGradeBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzGradeBaseEN SetIdStudyLevel(this clsXzGradeBaseEN objXzGradeBaseEN, string strIdStudyLevel, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudyLevel, 4, conXzGradeBase.IdStudyLevel);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudyLevel, 4, conXzGradeBase.IdStudyLevel);
}
objXzGradeBaseEN.IdStudyLevel = strIdStudyLevel; //IdStudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzGradeBaseEN.dicFldComparisonOp.ContainsKey(conXzGradeBase.IdStudyLevel) == false)
{
objXzGradeBaseEN.dicFldComparisonOp.Add(conXzGradeBase.IdStudyLevel, strComparisonOp);
}
else
{
objXzGradeBaseEN.dicFldComparisonOp[conXzGradeBase.IdStudyLevel] = strComparisonOp;
}
}
return objXzGradeBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzGradeBaseEN SetPointCalcVersionId(this clsXzGradeBaseEN objXzGradeBaseEN, string strPointCalcVersionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPointCalcVersionId, 2, conXzGradeBase.PointCalcVersionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPointCalcVersionId, 2, conXzGradeBase.PointCalcVersionId);
}
objXzGradeBaseEN.PointCalcVersionId = strPointCalcVersionId; //PointCalcVersionId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzGradeBaseEN.dicFldComparisonOp.ContainsKey(conXzGradeBase.PointCalcVersionId) == false)
{
objXzGradeBaseEN.dicFldComparisonOp.Add(conXzGradeBase.PointCalcVersionId, strComparisonOp);
}
else
{
objXzGradeBaseEN.dicFldComparisonOp[conXzGradeBase.PointCalcVersionId] = strComparisonOp;
}
}
return objXzGradeBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzGradeBaseEN SetPrefix(this clsXzGradeBaseEN objXzGradeBaseEN, string strPrefix, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrefix, 3, conXzGradeBase.Prefix);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrefix, 3, conXzGradeBase.Prefix);
}
objXzGradeBaseEN.Prefix = strPrefix; //Prefix
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzGradeBaseEN.dicFldComparisonOp.ContainsKey(conXzGradeBase.Prefix) == false)
{
objXzGradeBaseEN.dicFldComparisonOp.Add(conXzGradeBase.Prefix, strComparisonOp);
}
else
{
objXzGradeBaseEN.dicFldComparisonOp[conXzGradeBase.Prefix] = strComparisonOp;
}
}
return objXzGradeBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzGradeBaseEN SetMemo(this clsXzGradeBaseEN objXzGradeBaseEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conXzGradeBase.Memo);
}
objXzGradeBaseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzGradeBaseEN.dicFldComparisonOp.ContainsKey(conXzGradeBase.Memo) == false)
{
objXzGradeBaseEN.dicFldComparisonOp.Add(conXzGradeBase.Memo, strComparisonOp);
}
else
{
objXzGradeBaseEN.dicFldComparisonOp[conXzGradeBase.Memo] = strComparisonOp;
}
}
return objXzGradeBaseEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsXzGradeBaseEN objXzGradeBaseEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objXzGradeBaseEN.CheckPropertyNew();
clsXzGradeBaseEN objXzGradeBaseCond = new clsXzGradeBaseEN();
string strCondition = objXzGradeBaseCond
.SetIdGradeBase(objXzGradeBaseEN.IdGradeBase, "=")
.GetCombineCondition();
objXzGradeBaseEN._IsCheckProperty = true;
bool bolIsExist = clsXzGradeBaseBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objXzGradeBaseEN.Update();
}
catch(Exception objException)
{
strMsg = "修改记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsXzGradeBaseEN objXzGradeBaseEN)
{
 if (string.IsNullOrEmpty(objXzGradeBaseEN.IdGradeBase) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsXzGradeBaseBL.XzGradeBaseDA.UpdateBySql2(objXzGradeBaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzGradeBaseBL.ReFreshCache();

if (clsXzGradeBaseBL.relatedActions != null)
{
clsXzGradeBaseBL.relatedActions.UpdRelaTabDate(objXzGradeBaseEN.IdGradeBase, "SetUpdDate");
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
 /// <param name = "objXzGradeBaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsXzGradeBaseEN objXzGradeBaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objXzGradeBaseEN.IdGradeBase) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsXzGradeBaseBL.XzGradeBaseDA.UpdateBySql2(objXzGradeBaseEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzGradeBaseBL.ReFreshCache();

if (clsXzGradeBaseBL.relatedActions != null)
{
clsXzGradeBaseBL.relatedActions.UpdRelaTabDate(objXzGradeBaseEN.IdGradeBase, "SetUpdDate");
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
 /// <param name = "objXzGradeBaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsXzGradeBaseEN objXzGradeBaseEN, string strWhereCond)
{
try
{
bool bolResult = clsXzGradeBaseBL.XzGradeBaseDA.UpdateBySqlWithCondition(objXzGradeBaseEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzGradeBaseBL.ReFreshCache();

if (clsXzGradeBaseBL.relatedActions != null)
{
clsXzGradeBaseBL.relatedActions.UpdRelaTabDate(objXzGradeBaseEN.IdGradeBase, "SetUpdDate");
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
 /// <param name = "objXzGradeBaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsXzGradeBaseEN objXzGradeBaseEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsXzGradeBaseBL.XzGradeBaseDA.UpdateBySqlWithConditionTransaction(objXzGradeBaseEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzGradeBaseBL.ReFreshCache();

if (clsXzGradeBaseBL.relatedActions != null)
{
clsXzGradeBaseBL.relatedActions.UpdRelaTabDate(objXzGradeBaseEN.IdGradeBase, "SetUpdDate");
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
 /// <param name = "strIdGradeBase">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsXzGradeBaseEN objXzGradeBaseEN)
{
try
{
int intRecNum = clsXzGradeBaseBL.XzGradeBaseDA.DelRecord(objXzGradeBaseEN.IdGradeBase);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzGradeBaseBL.ReFreshCache();

if (clsXzGradeBaseBL.relatedActions != null)
{
clsXzGradeBaseBL.relatedActions.UpdRelaTabDate(objXzGradeBaseEN.IdGradeBase, "SetUpdDate");
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
 /// <param name = "objXzGradeBaseENS">源对象</param>
 /// <param name = "objXzGradeBaseENT">目标对象</param>
 public static void CopyTo(this clsXzGradeBaseEN objXzGradeBaseENS, clsXzGradeBaseEN objXzGradeBaseENT)
{
try
{
objXzGradeBaseENT.IdGradeBase = objXzGradeBaseENS.IdGradeBase; //年级流水号
objXzGradeBaseENT.GradeBaseId = objXzGradeBaseENS.GradeBaseId; //年级代号
objXzGradeBaseENT.GradeBaseName = objXzGradeBaseENS.GradeBaseName; //年级名称
objXzGradeBaseENT.SchoolYear = objXzGradeBaseENS.SchoolYear; //学年
objXzGradeBaseENT.SchoolTerm = objXzGradeBaseENS.SchoolTerm; //学期
objXzGradeBaseENT.EnterSchoolDate = objXzGradeBaseENS.EnterSchoolDate; //进校日期
objXzGradeBaseENT.CurrentTermSeq = objXzGradeBaseENS.CurrentTermSeq; //当前学期
objXzGradeBaseENT.ExecPlanTermIndex = objXzGradeBaseENS.ExecPlanTermIndex; //生成执行计划学期
objXzGradeBaseENT.SetEPTermIndexDate = objXzGradeBaseENS.SetEPTermIndexDate; //设定执行计划学期日期
objXzGradeBaseENT.IsOffed = objXzGradeBaseENS.IsOffed; //是否毕业
objXzGradeBaseENT.ModifyDate = objXzGradeBaseENS.ModifyDate; //修改日期
objXzGradeBaseENT.ModifyUserId = objXzGradeBaseENS.ModifyUserId; //修改人
objXzGradeBaseENT.GradeIndex = objXzGradeBaseENS.GradeIndex; //年级序号
objXzGradeBaseENT.BeginYearMonth = objXzGradeBaseENS.BeginYearMonth; //开始年月
objXzGradeBaseENT.EndYearMonth = objXzGradeBaseENS.EndYearMonth; //结束年月
objXzGradeBaseENT.AllowUpBaseInfo = objXzGradeBaseENS.AllowUpBaseInfo; //允许修改基本信息
objXzGradeBaseENT.GradeBaseNameA = objXzGradeBaseENS.GradeBaseNameA; //GradeBaseNameA
objXzGradeBaseENT.IsVisible = objXzGradeBaseENS.IsVisible; //是否显示
objXzGradeBaseENT.IdStudyLevel = objXzGradeBaseENS.IdStudyLevel; //IdStudyLevel
objXzGradeBaseENT.PointCalcVersionId = objXzGradeBaseENS.PointCalcVersionId; //PointCalcVersionId
objXzGradeBaseENT.Prefix = objXzGradeBaseENS.Prefix; //Prefix
objXzGradeBaseENT.Memo = objXzGradeBaseENS.Memo; //备注
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
 /// <param name = "objXzGradeBaseENS">源对象</param>
 /// <returns>目标对象=>clsXzGradeBaseEN:objXzGradeBaseENT</returns>
 public static clsXzGradeBaseEN CopyTo(this clsXzGradeBaseEN objXzGradeBaseENS)
{
try
{
 clsXzGradeBaseEN objXzGradeBaseENT = new clsXzGradeBaseEN()
{
IdGradeBase = objXzGradeBaseENS.IdGradeBase, //年级流水号
GradeBaseId = objXzGradeBaseENS.GradeBaseId, //年级代号
GradeBaseName = objXzGradeBaseENS.GradeBaseName, //年级名称
SchoolYear = objXzGradeBaseENS.SchoolYear, //学年
SchoolTerm = objXzGradeBaseENS.SchoolTerm, //学期
EnterSchoolDate = objXzGradeBaseENS.EnterSchoolDate, //进校日期
CurrentTermSeq = objXzGradeBaseENS.CurrentTermSeq, //当前学期
ExecPlanTermIndex = objXzGradeBaseENS.ExecPlanTermIndex, //生成执行计划学期
SetEPTermIndexDate = objXzGradeBaseENS.SetEPTermIndexDate, //设定执行计划学期日期
IsOffed = objXzGradeBaseENS.IsOffed, //是否毕业
ModifyDate = objXzGradeBaseENS.ModifyDate, //修改日期
ModifyUserId = objXzGradeBaseENS.ModifyUserId, //修改人
GradeIndex = objXzGradeBaseENS.GradeIndex, //年级序号
BeginYearMonth = objXzGradeBaseENS.BeginYearMonth, //开始年月
EndYearMonth = objXzGradeBaseENS.EndYearMonth, //结束年月
AllowUpBaseInfo = objXzGradeBaseENS.AllowUpBaseInfo, //允许修改基本信息
GradeBaseNameA = objXzGradeBaseENS.GradeBaseNameA, //GradeBaseNameA
IsVisible = objXzGradeBaseENS.IsVisible, //是否显示
IdStudyLevel = objXzGradeBaseENS.IdStudyLevel, //IdStudyLevel
PointCalcVersionId = objXzGradeBaseENS.PointCalcVersionId, //PointCalcVersionId
Prefix = objXzGradeBaseENS.Prefix, //Prefix
Memo = objXzGradeBaseENS.Memo, //备注
};
 return objXzGradeBaseENT;
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
public static void CheckPropertyNew(this clsXzGradeBaseEN objXzGradeBaseEN)
{
 clsXzGradeBaseBL.XzGradeBaseDA.CheckPropertyNew(objXzGradeBaseEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsXzGradeBaseEN objXzGradeBaseEN)
{
 clsXzGradeBaseBL.XzGradeBaseDA.CheckProperty4Condition(objXzGradeBaseEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsXzGradeBaseEN objXzGradeBaseCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objXzGradeBaseCond.IsUpdated(conXzGradeBase.IdGradeBase) == true)
{
string strComparisonOpIdGradeBase = objXzGradeBaseCond.dicFldComparisonOp[conXzGradeBase.IdGradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzGradeBase.IdGradeBase, objXzGradeBaseCond.IdGradeBase, strComparisonOpIdGradeBase);
}
if (objXzGradeBaseCond.IsUpdated(conXzGradeBase.GradeBaseId) == true)
{
string strComparisonOpGradeBaseId = objXzGradeBaseCond.dicFldComparisonOp[conXzGradeBase.GradeBaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzGradeBase.GradeBaseId, objXzGradeBaseCond.GradeBaseId, strComparisonOpGradeBaseId);
}
if (objXzGradeBaseCond.IsUpdated(conXzGradeBase.GradeBaseName) == true)
{
string strComparisonOpGradeBaseName = objXzGradeBaseCond.dicFldComparisonOp[conXzGradeBase.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzGradeBase.GradeBaseName, objXzGradeBaseCond.GradeBaseName, strComparisonOpGradeBaseName);
}
if (objXzGradeBaseCond.IsUpdated(conXzGradeBase.SchoolYear) == true)
{
string strComparisonOpSchoolYear = objXzGradeBaseCond.dicFldComparisonOp[conXzGradeBase.SchoolYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzGradeBase.SchoolYear, objXzGradeBaseCond.SchoolYear, strComparisonOpSchoolYear);
}
if (objXzGradeBaseCond.IsUpdated(conXzGradeBase.SchoolTerm) == true)
{
string strComparisonOpSchoolTerm = objXzGradeBaseCond.dicFldComparisonOp[conXzGradeBase.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzGradeBase.SchoolTerm, objXzGradeBaseCond.SchoolTerm, strComparisonOpSchoolTerm);
}
if (objXzGradeBaseCond.IsUpdated(conXzGradeBase.EnterSchoolDate) == true)
{
string strComparisonOpEnterSchoolDate = objXzGradeBaseCond.dicFldComparisonOp[conXzGradeBase.EnterSchoolDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzGradeBase.EnterSchoolDate, objXzGradeBaseCond.EnterSchoolDate, strComparisonOpEnterSchoolDate);
}
if (objXzGradeBaseCond.IsUpdated(conXzGradeBase.CurrentTermSeq) == true)
{
string strComparisonOpCurrentTermSeq = objXzGradeBaseCond.dicFldComparisonOp[conXzGradeBase.CurrentTermSeq];
strWhereCond += string.Format(" And {0} {2} {1}", conXzGradeBase.CurrentTermSeq, objXzGradeBaseCond.CurrentTermSeq, strComparisonOpCurrentTermSeq);
}
if (objXzGradeBaseCond.IsUpdated(conXzGradeBase.ExecPlanTermIndex) == true)
{
string strComparisonOpExecPlanTermIndex = objXzGradeBaseCond.dicFldComparisonOp[conXzGradeBase.ExecPlanTermIndex];
strWhereCond += string.Format(" And {0} {2} {1}", conXzGradeBase.ExecPlanTermIndex, objXzGradeBaseCond.ExecPlanTermIndex, strComparisonOpExecPlanTermIndex);
}
if (objXzGradeBaseCond.IsUpdated(conXzGradeBase.SetEPTermIndexDate) == true)
{
string strComparisonOpSetEPTermIndexDate = objXzGradeBaseCond.dicFldComparisonOp[conXzGradeBase.SetEPTermIndexDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzGradeBase.SetEPTermIndexDate, objXzGradeBaseCond.SetEPTermIndexDate, strComparisonOpSetEPTermIndexDate);
}
if (objXzGradeBaseCond.IsUpdated(conXzGradeBase.IsOffed) == true)
{
if (objXzGradeBaseCond.IsOffed == true)
{
strWhereCond += string.Format(" And {0} = '1'", conXzGradeBase.IsOffed);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conXzGradeBase.IsOffed);
}
}
if (objXzGradeBaseCond.IsUpdated(conXzGradeBase.ModifyDate) == true)
{
string strComparisonOpModifyDate = objXzGradeBaseCond.dicFldComparisonOp[conXzGradeBase.ModifyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzGradeBase.ModifyDate, objXzGradeBaseCond.ModifyDate, strComparisonOpModifyDate);
}
if (objXzGradeBaseCond.IsUpdated(conXzGradeBase.ModifyUserId) == true)
{
string strComparisonOpModifyUserId = objXzGradeBaseCond.dicFldComparisonOp[conXzGradeBase.ModifyUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzGradeBase.ModifyUserId, objXzGradeBaseCond.ModifyUserId, strComparisonOpModifyUserId);
}
if (objXzGradeBaseCond.IsUpdated(conXzGradeBase.GradeIndex) == true)
{
string strComparisonOpGradeIndex = objXzGradeBaseCond.dicFldComparisonOp[conXzGradeBase.GradeIndex];
strWhereCond += string.Format(" And {0} {2} {1}", conXzGradeBase.GradeIndex, objXzGradeBaseCond.GradeIndex, strComparisonOpGradeIndex);
}
if (objXzGradeBaseCond.IsUpdated(conXzGradeBase.BeginYearMonth) == true)
{
string strComparisonOpBeginYearMonth = objXzGradeBaseCond.dicFldComparisonOp[conXzGradeBase.BeginYearMonth];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzGradeBase.BeginYearMonth, objXzGradeBaseCond.BeginYearMonth, strComparisonOpBeginYearMonth);
}
if (objXzGradeBaseCond.IsUpdated(conXzGradeBase.EndYearMonth) == true)
{
string strComparisonOpEndYearMonth = objXzGradeBaseCond.dicFldComparisonOp[conXzGradeBase.EndYearMonth];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzGradeBase.EndYearMonth, objXzGradeBaseCond.EndYearMonth, strComparisonOpEndYearMonth);
}
if (objXzGradeBaseCond.IsUpdated(conXzGradeBase.AllowUpBaseInfo) == true)
{
if (objXzGradeBaseCond.AllowUpBaseInfo == true)
{
strWhereCond += string.Format(" And {0} = '1'", conXzGradeBase.AllowUpBaseInfo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conXzGradeBase.AllowUpBaseInfo);
}
}
if (objXzGradeBaseCond.IsUpdated(conXzGradeBase.GradeBaseNameA) == true)
{
string strComparisonOpGradeBaseNameA = objXzGradeBaseCond.dicFldComparisonOp[conXzGradeBase.GradeBaseNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzGradeBase.GradeBaseNameA, objXzGradeBaseCond.GradeBaseNameA, strComparisonOpGradeBaseNameA);
}
if (objXzGradeBaseCond.IsUpdated(conXzGradeBase.IsVisible) == true)
{
if (objXzGradeBaseCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conXzGradeBase.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conXzGradeBase.IsVisible);
}
}
if (objXzGradeBaseCond.IsUpdated(conXzGradeBase.IdStudyLevel) == true)
{
string strComparisonOpIdStudyLevel = objXzGradeBaseCond.dicFldComparisonOp[conXzGradeBase.IdStudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzGradeBase.IdStudyLevel, objXzGradeBaseCond.IdStudyLevel, strComparisonOpIdStudyLevel);
}
if (objXzGradeBaseCond.IsUpdated(conXzGradeBase.PointCalcVersionId) == true)
{
string strComparisonOpPointCalcVersionId = objXzGradeBaseCond.dicFldComparisonOp[conXzGradeBase.PointCalcVersionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzGradeBase.PointCalcVersionId, objXzGradeBaseCond.PointCalcVersionId, strComparisonOpPointCalcVersionId);
}
if (objXzGradeBaseCond.IsUpdated(conXzGradeBase.Prefix) == true)
{
string strComparisonOpPrefix = objXzGradeBaseCond.dicFldComparisonOp[conXzGradeBase.Prefix];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzGradeBase.Prefix, objXzGradeBaseCond.Prefix, strComparisonOpPrefix);
}
if (objXzGradeBaseCond.IsUpdated(conXzGradeBase.Memo) == true)
{
string strComparisonOpMemo = objXzGradeBaseCond.dicFldComparisonOp[conXzGradeBase.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzGradeBase.Memo, objXzGradeBaseCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_XzGradeBase
{
public virtual bool UpdRelaTabDate(string strIdGradeBase, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 年级(XzGradeBase)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsXzGradeBaseBL
{
public static RelatedActions_XzGradeBase relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "XzGradeBaseListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "XzGradeBaseList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsXzGradeBaseEN> arrXzGradeBaseObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsXzGradeBaseDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsXzGradeBaseDA XzGradeBaseDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsXzGradeBaseDA();
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
 public clsXzGradeBaseBL()
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
if (string.IsNullOrEmpty(clsXzGradeBaseEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsXzGradeBaseEN._ConnectString);
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
objDS = XzGradeBaseDA.GetDataSet(strWhereCond);
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
objDS = XzGradeBaseDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = XzGradeBaseDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_XzGradeBase(string strWhereCond)
{
DataTable objDT;
try
{
objDT = XzGradeBaseDA.GetDataTable_XzGradeBase(strWhereCond);
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
objDT = XzGradeBaseDA.GetDataTable(strWhereCond);
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
objDT = XzGradeBaseDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = XzGradeBaseDA.GetDataTable(strWhereCond, strTabName);
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
objDT = XzGradeBaseDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = XzGradeBaseDA.GetDataTable_Top(objTopPara);
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
objDT = XzGradeBaseDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = XzGradeBaseDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = XzGradeBaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = XzGradeBaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = XzGradeBaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = XzGradeBaseDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = XzGradeBaseDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = XzGradeBaseDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
 /// <param name = "arrIdGradeBaseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsXzGradeBaseEN> GetObjLstByIdGradeBaseLst(List<string> arrIdGradeBaseLst)
{
List<clsXzGradeBaseEN> arrObjLst = new List<clsXzGradeBaseEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdGradeBaseLst, true);
 string strWhereCond = string.Format("IdGradeBase in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzGradeBaseEN objXzGradeBaseEN = new clsXzGradeBaseEN();
try
{
objXzGradeBaseEN.IdGradeBase = objRow[conXzGradeBase.IdGradeBase].ToString().Trim(); //年级流水号
objXzGradeBaseEN.GradeBaseId = objRow[conXzGradeBase.GradeBaseId].ToString().Trim(); //年级代号
objXzGradeBaseEN.GradeBaseName = objRow[conXzGradeBase.GradeBaseName].ToString().Trim(); //年级名称
objXzGradeBaseEN.SchoolYear = objRow[conXzGradeBase.SchoolYear].ToString().Trim(); //学年
objXzGradeBaseEN.SchoolTerm = objRow[conXzGradeBase.SchoolTerm].ToString().Trim(); //学期
objXzGradeBaseEN.EnterSchoolDate = objRow[conXzGradeBase.EnterSchoolDate] == DBNull.Value ? null : objRow[conXzGradeBase.EnterSchoolDate].ToString().Trim(); //进校日期
objXzGradeBaseEN.CurrentTermSeq = objRow[conXzGradeBase.CurrentTermSeq] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzGradeBase.CurrentTermSeq].ToString().Trim()); //当前学期
objXzGradeBaseEN.ExecPlanTermIndex = objRow[conXzGradeBase.ExecPlanTermIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzGradeBase.ExecPlanTermIndex].ToString().Trim()); //生成执行计划学期
objXzGradeBaseEN.SetEPTermIndexDate = objRow[conXzGradeBase.SetEPTermIndexDate] == DBNull.Value ? null : objRow[conXzGradeBase.SetEPTermIndexDate].ToString().Trim(); //设定执行计划学期日期
objXzGradeBaseEN.IsOffed = clsEntityBase2.TransNullToBool_S(objRow[conXzGradeBase.IsOffed].ToString().Trim()); //是否毕业
objXzGradeBaseEN.ModifyDate = objRow[conXzGradeBase.ModifyDate] == DBNull.Value ? null : objRow[conXzGradeBase.ModifyDate].ToString().Trim(); //修改日期
objXzGradeBaseEN.ModifyUserId = objRow[conXzGradeBase.ModifyUserId] == DBNull.Value ? null : objRow[conXzGradeBase.ModifyUserId].ToString().Trim(); //修改人
objXzGradeBaseEN.GradeIndex = objRow[conXzGradeBase.GradeIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzGradeBase.GradeIndex].ToString().Trim()); //年级序号
objXzGradeBaseEN.BeginYearMonth = objRow[conXzGradeBase.BeginYearMonth] == DBNull.Value ? null : objRow[conXzGradeBase.BeginYearMonth].ToString().Trim(); //开始年月
objXzGradeBaseEN.EndYearMonth = objRow[conXzGradeBase.EndYearMonth] == DBNull.Value ? null : objRow[conXzGradeBase.EndYearMonth].ToString().Trim(); //结束年月
objXzGradeBaseEN.AllowUpBaseInfo = clsEntityBase2.TransNullToBool_S(objRow[conXzGradeBase.AllowUpBaseInfo].ToString().Trim()); //允许修改基本信息
objXzGradeBaseEN.GradeBaseNameA = objRow[conXzGradeBase.GradeBaseNameA] == DBNull.Value ? null : objRow[conXzGradeBase.GradeBaseNameA].ToString().Trim(); //GradeBaseNameA
objXzGradeBaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzGradeBase.IsVisible].ToString().Trim()); //是否显示
objXzGradeBaseEN.IdStudyLevel = objRow[conXzGradeBase.IdStudyLevel] == DBNull.Value ? null : objRow[conXzGradeBase.IdStudyLevel].ToString().Trim(); //IdStudyLevel
objXzGradeBaseEN.PointCalcVersionId = objRow[conXzGradeBase.PointCalcVersionId] == DBNull.Value ? null : objRow[conXzGradeBase.PointCalcVersionId].ToString().Trim(); //PointCalcVersionId
objXzGradeBaseEN.Prefix = objRow[conXzGradeBase.Prefix] == DBNull.Value ? null : objRow[conXzGradeBase.Prefix].ToString().Trim(); //Prefix
objXzGradeBaseEN.Memo = objRow[conXzGradeBase.Memo] == DBNull.Value ? null : objRow[conXzGradeBase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzGradeBaseEN.IdGradeBase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzGradeBaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdGradeBaseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsXzGradeBaseEN> GetObjLstByIdGradeBaseLstCache(List<string> arrIdGradeBaseLst)
{
string strKey = string.Format("{0}", clsXzGradeBaseEN._CurrTabName);
List<clsXzGradeBaseEN> arrXzGradeBaseObjLstCache = GetObjLstCache();
IEnumerable <clsXzGradeBaseEN> arrXzGradeBaseObjLst_Sel =
arrXzGradeBaseObjLstCache
.Where(x => arrIdGradeBaseLst.Contains(x.IdGradeBase));
return arrXzGradeBaseObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzGradeBaseEN> GetObjLst(string strWhereCond)
{
List<clsXzGradeBaseEN> arrObjLst = new List<clsXzGradeBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzGradeBaseEN objXzGradeBaseEN = new clsXzGradeBaseEN();
try
{
objXzGradeBaseEN.IdGradeBase = objRow[conXzGradeBase.IdGradeBase].ToString().Trim(); //年级流水号
objXzGradeBaseEN.GradeBaseId = objRow[conXzGradeBase.GradeBaseId].ToString().Trim(); //年级代号
objXzGradeBaseEN.GradeBaseName = objRow[conXzGradeBase.GradeBaseName].ToString().Trim(); //年级名称
objXzGradeBaseEN.SchoolYear = objRow[conXzGradeBase.SchoolYear].ToString().Trim(); //学年
objXzGradeBaseEN.SchoolTerm = objRow[conXzGradeBase.SchoolTerm].ToString().Trim(); //学期
objXzGradeBaseEN.EnterSchoolDate = objRow[conXzGradeBase.EnterSchoolDate] == DBNull.Value ? null : objRow[conXzGradeBase.EnterSchoolDate].ToString().Trim(); //进校日期
objXzGradeBaseEN.CurrentTermSeq = objRow[conXzGradeBase.CurrentTermSeq] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzGradeBase.CurrentTermSeq].ToString().Trim()); //当前学期
objXzGradeBaseEN.ExecPlanTermIndex = objRow[conXzGradeBase.ExecPlanTermIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzGradeBase.ExecPlanTermIndex].ToString().Trim()); //生成执行计划学期
objXzGradeBaseEN.SetEPTermIndexDate = objRow[conXzGradeBase.SetEPTermIndexDate] == DBNull.Value ? null : objRow[conXzGradeBase.SetEPTermIndexDate].ToString().Trim(); //设定执行计划学期日期
objXzGradeBaseEN.IsOffed = clsEntityBase2.TransNullToBool_S(objRow[conXzGradeBase.IsOffed].ToString().Trim()); //是否毕业
objXzGradeBaseEN.ModifyDate = objRow[conXzGradeBase.ModifyDate] == DBNull.Value ? null : objRow[conXzGradeBase.ModifyDate].ToString().Trim(); //修改日期
objXzGradeBaseEN.ModifyUserId = objRow[conXzGradeBase.ModifyUserId] == DBNull.Value ? null : objRow[conXzGradeBase.ModifyUserId].ToString().Trim(); //修改人
objXzGradeBaseEN.GradeIndex = objRow[conXzGradeBase.GradeIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzGradeBase.GradeIndex].ToString().Trim()); //年级序号
objXzGradeBaseEN.BeginYearMonth = objRow[conXzGradeBase.BeginYearMonth] == DBNull.Value ? null : objRow[conXzGradeBase.BeginYearMonth].ToString().Trim(); //开始年月
objXzGradeBaseEN.EndYearMonth = objRow[conXzGradeBase.EndYearMonth] == DBNull.Value ? null : objRow[conXzGradeBase.EndYearMonth].ToString().Trim(); //结束年月
objXzGradeBaseEN.AllowUpBaseInfo = clsEntityBase2.TransNullToBool_S(objRow[conXzGradeBase.AllowUpBaseInfo].ToString().Trim()); //允许修改基本信息
objXzGradeBaseEN.GradeBaseNameA = objRow[conXzGradeBase.GradeBaseNameA] == DBNull.Value ? null : objRow[conXzGradeBase.GradeBaseNameA].ToString().Trim(); //GradeBaseNameA
objXzGradeBaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzGradeBase.IsVisible].ToString().Trim()); //是否显示
objXzGradeBaseEN.IdStudyLevel = objRow[conXzGradeBase.IdStudyLevel] == DBNull.Value ? null : objRow[conXzGradeBase.IdStudyLevel].ToString().Trim(); //IdStudyLevel
objXzGradeBaseEN.PointCalcVersionId = objRow[conXzGradeBase.PointCalcVersionId] == DBNull.Value ? null : objRow[conXzGradeBase.PointCalcVersionId].ToString().Trim(); //PointCalcVersionId
objXzGradeBaseEN.Prefix = objRow[conXzGradeBase.Prefix] == DBNull.Value ? null : objRow[conXzGradeBase.Prefix].ToString().Trim(); //Prefix
objXzGradeBaseEN.Memo = objRow[conXzGradeBase.Memo] == DBNull.Value ? null : objRow[conXzGradeBase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzGradeBaseEN.IdGradeBase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzGradeBaseEN);
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
public static List<clsXzGradeBaseEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsXzGradeBaseEN> arrObjLst = new List<clsXzGradeBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzGradeBaseEN objXzGradeBaseEN = new clsXzGradeBaseEN();
try
{
objXzGradeBaseEN.IdGradeBase = objRow[conXzGradeBase.IdGradeBase].ToString().Trim(); //年级流水号
objXzGradeBaseEN.GradeBaseId = objRow[conXzGradeBase.GradeBaseId].ToString().Trim(); //年级代号
objXzGradeBaseEN.GradeBaseName = objRow[conXzGradeBase.GradeBaseName].ToString().Trim(); //年级名称
objXzGradeBaseEN.SchoolYear = objRow[conXzGradeBase.SchoolYear].ToString().Trim(); //学年
objXzGradeBaseEN.SchoolTerm = objRow[conXzGradeBase.SchoolTerm].ToString().Trim(); //学期
objXzGradeBaseEN.EnterSchoolDate = objRow[conXzGradeBase.EnterSchoolDate] == DBNull.Value ? null : objRow[conXzGradeBase.EnterSchoolDate].ToString().Trim(); //进校日期
objXzGradeBaseEN.CurrentTermSeq = objRow[conXzGradeBase.CurrentTermSeq] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzGradeBase.CurrentTermSeq].ToString().Trim()); //当前学期
objXzGradeBaseEN.ExecPlanTermIndex = objRow[conXzGradeBase.ExecPlanTermIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzGradeBase.ExecPlanTermIndex].ToString().Trim()); //生成执行计划学期
objXzGradeBaseEN.SetEPTermIndexDate = objRow[conXzGradeBase.SetEPTermIndexDate] == DBNull.Value ? null : objRow[conXzGradeBase.SetEPTermIndexDate].ToString().Trim(); //设定执行计划学期日期
objXzGradeBaseEN.IsOffed = clsEntityBase2.TransNullToBool_S(objRow[conXzGradeBase.IsOffed].ToString().Trim()); //是否毕业
objXzGradeBaseEN.ModifyDate = objRow[conXzGradeBase.ModifyDate] == DBNull.Value ? null : objRow[conXzGradeBase.ModifyDate].ToString().Trim(); //修改日期
objXzGradeBaseEN.ModifyUserId = objRow[conXzGradeBase.ModifyUserId] == DBNull.Value ? null : objRow[conXzGradeBase.ModifyUserId].ToString().Trim(); //修改人
objXzGradeBaseEN.GradeIndex = objRow[conXzGradeBase.GradeIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzGradeBase.GradeIndex].ToString().Trim()); //年级序号
objXzGradeBaseEN.BeginYearMonth = objRow[conXzGradeBase.BeginYearMonth] == DBNull.Value ? null : objRow[conXzGradeBase.BeginYearMonth].ToString().Trim(); //开始年月
objXzGradeBaseEN.EndYearMonth = objRow[conXzGradeBase.EndYearMonth] == DBNull.Value ? null : objRow[conXzGradeBase.EndYearMonth].ToString().Trim(); //结束年月
objXzGradeBaseEN.AllowUpBaseInfo = clsEntityBase2.TransNullToBool_S(objRow[conXzGradeBase.AllowUpBaseInfo].ToString().Trim()); //允许修改基本信息
objXzGradeBaseEN.GradeBaseNameA = objRow[conXzGradeBase.GradeBaseNameA] == DBNull.Value ? null : objRow[conXzGradeBase.GradeBaseNameA].ToString().Trim(); //GradeBaseNameA
objXzGradeBaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzGradeBase.IsVisible].ToString().Trim()); //是否显示
objXzGradeBaseEN.IdStudyLevel = objRow[conXzGradeBase.IdStudyLevel] == DBNull.Value ? null : objRow[conXzGradeBase.IdStudyLevel].ToString().Trim(); //IdStudyLevel
objXzGradeBaseEN.PointCalcVersionId = objRow[conXzGradeBase.PointCalcVersionId] == DBNull.Value ? null : objRow[conXzGradeBase.PointCalcVersionId].ToString().Trim(); //PointCalcVersionId
objXzGradeBaseEN.Prefix = objRow[conXzGradeBase.Prefix] == DBNull.Value ? null : objRow[conXzGradeBase.Prefix].ToString().Trim(); //Prefix
objXzGradeBaseEN.Memo = objRow[conXzGradeBase.Memo] == DBNull.Value ? null : objRow[conXzGradeBase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzGradeBaseEN.IdGradeBase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzGradeBaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objXzGradeBaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsXzGradeBaseEN> GetSubObjLstCache(clsXzGradeBaseEN objXzGradeBaseCond)
{
List<clsXzGradeBaseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsXzGradeBaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conXzGradeBase.AttributeName)
{
if (objXzGradeBaseCond.IsUpdated(strFldName) == false) continue;
if (objXzGradeBaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objXzGradeBaseCond[strFldName].ToString());
}
else
{
if (objXzGradeBaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objXzGradeBaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objXzGradeBaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objXzGradeBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objXzGradeBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objXzGradeBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objXzGradeBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objXzGradeBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objXzGradeBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objXzGradeBaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objXzGradeBaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objXzGradeBaseCond[strFldName]));
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
public static List<clsXzGradeBaseEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsXzGradeBaseEN> arrObjLst = new List<clsXzGradeBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzGradeBaseEN objXzGradeBaseEN = new clsXzGradeBaseEN();
try
{
objXzGradeBaseEN.IdGradeBase = objRow[conXzGradeBase.IdGradeBase].ToString().Trim(); //年级流水号
objXzGradeBaseEN.GradeBaseId = objRow[conXzGradeBase.GradeBaseId].ToString().Trim(); //年级代号
objXzGradeBaseEN.GradeBaseName = objRow[conXzGradeBase.GradeBaseName].ToString().Trim(); //年级名称
objXzGradeBaseEN.SchoolYear = objRow[conXzGradeBase.SchoolYear].ToString().Trim(); //学年
objXzGradeBaseEN.SchoolTerm = objRow[conXzGradeBase.SchoolTerm].ToString().Trim(); //学期
objXzGradeBaseEN.EnterSchoolDate = objRow[conXzGradeBase.EnterSchoolDate] == DBNull.Value ? null : objRow[conXzGradeBase.EnterSchoolDate].ToString().Trim(); //进校日期
objXzGradeBaseEN.CurrentTermSeq = objRow[conXzGradeBase.CurrentTermSeq] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzGradeBase.CurrentTermSeq].ToString().Trim()); //当前学期
objXzGradeBaseEN.ExecPlanTermIndex = objRow[conXzGradeBase.ExecPlanTermIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzGradeBase.ExecPlanTermIndex].ToString().Trim()); //生成执行计划学期
objXzGradeBaseEN.SetEPTermIndexDate = objRow[conXzGradeBase.SetEPTermIndexDate] == DBNull.Value ? null : objRow[conXzGradeBase.SetEPTermIndexDate].ToString().Trim(); //设定执行计划学期日期
objXzGradeBaseEN.IsOffed = clsEntityBase2.TransNullToBool_S(objRow[conXzGradeBase.IsOffed].ToString().Trim()); //是否毕业
objXzGradeBaseEN.ModifyDate = objRow[conXzGradeBase.ModifyDate] == DBNull.Value ? null : objRow[conXzGradeBase.ModifyDate].ToString().Trim(); //修改日期
objXzGradeBaseEN.ModifyUserId = objRow[conXzGradeBase.ModifyUserId] == DBNull.Value ? null : objRow[conXzGradeBase.ModifyUserId].ToString().Trim(); //修改人
objXzGradeBaseEN.GradeIndex = objRow[conXzGradeBase.GradeIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzGradeBase.GradeIndex].ToString().Trim()); //年级序号
objXzGradeBaseEN.BeginYearMonth = objRow[conXzGradeBase.BeginYearMonth] == DBNull.Value ? null : objRow[conXzGradeBase.BeginYearMonth].ToString().Trim(); //开始年月
objXzGradeBaseEN.EndYearMonth = objRow[conXzGradeBase.EndYearMonth] == DBNull.Value ? null : objRow[conXzGradeBase.EndYearMonth].ToString().Trim(); //结束年月
objXzGradeBaseEN.AllowUpBaseInfo = clsEntityBase2.TransNullToBool_S(objRow[conXzGradeBase.AllowUpBaseInfo].ToString().Trim()); //允许修改基本信息
objXzGradeBaseEN.GradeBaseNameA = objRow[conXzGradeBase.GradeBaseNameA] == DBNull.Value ? null : objRow[conXzGradeBase.GradeBaseNameA].ToString().Trim(); //GradeBaseNameA
objXzGradeBaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzGradeBase.IsVisible].ToString().Trim()); //是否显示
objXzGradeBaseEN.IdStudyLevel = objRow[conXzGradeBase.IdStudyLevel] == DBNull.Value ? null : objRow[conXzGradeBase.IdStudyLevel].ToString().Trim(); //IdStudyLevel
objXzGradeBaseEN.PointCalcVersionId = objRow[conXzGradeBase.PointCalcVersionId] == DBNull.Value ? null : objRow[conXzGradeBase.PointCalcVersionId].ToString().Trim(); //PointCalcVersionId
objXzGradeBaseEN.Prefix = objRow[conXzGradeBase.Prefix] == DBNull.Value ? null : objRow[conXzGradeBase.Prefix].ToString().Trim(); //Prefix
objXzGradeBaseEN.Memo = objRow[conXzGradeBase.Memo] == DBNull.Value ? null : objRow[conXzGradeBase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzGradeBaseEN.IdGradeBase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzGradeBaseEN);
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
public static List<clsXzGradeBaseEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsXzGradeBaseEN> arrObjLst = new List<clsXzGradeBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzGradeBaseEN objXzGradeBaseEN = new clsXzGradeBaseEN();
try
{
objXzGradeBaseEN.IdGradeBase = objRow[conXzGradeBase.IdGradeBase].ToString().Trim(); //年级流水号
objXzGradeBaseEN.GradeBaseId = objRow[conXzGradeBase.GradeBaseId].ToString().Trim(); //年级代号
objXzGradeBaseEN.GradeBaseName = objRow[conXzGradeBase.GradeBaseName].ToString().Trim(); //年级名称
objXzGradeBaseEN.SchoolYear = objRow[conXzGradeBase.SchoolYear].ToString().Trim(); //学年
objXzGradeBaseEN.SchoolTerm = objRow[conXzGradeBase.SchoolTerm].ToString().Trim(); //学期
objXzGradeBaseEN.EnterSchoolDate = objRow[conXzGradeBase.EnterSchoolDate] == DBNull.Value ? null : objRow[conXzGradeBase.EnterSchoolDate].ToString().Trim(); //进校日期
objXzGradeBaseEN.CurrentTermSeq = objRow[conXzGradeBase.CurrentTermSeq] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzGradeBase.CurrentTermSeq].ToString().Trim()); //当前学期
objXzGradeBaseEN.ExecPlanTermIndex = objRow[conXzGradeBase.ExecPlanTermIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzGradeBase.ExecPlanTermIndex].ToString().Trim()); //生成执行计划学期
objXzGradeBaseEN.SetEPTermIndexDate = objRow[conXzGradeBase.SetEPTermIndexDate] == DBNull.Value ? null : objRow[conXzGradeBase.SetEPTermIndexDate].ToString().Trim(); //设定执行计划学期日期
objXzGradeBaseEN.IsOffed = clsEntityBase2.TransNullToBool_S(objRow[conXzGradeBase.IsOffed].ToString().Trim()); //是否毕业
objXzGradeBaseEN.ModifyDate = objRow[conXzGradeBase.ModifyDate] == DBNull.Value ? null : objRow[conXzGradeBase.ModifyDate].ToString().Trim(); //修改日期
objXzGradeBaseEN.ModifyUserId = objRow[conXzGradeBase.ModifyUserId] == DBNull.Value ? null : objRow[conXzGradeBase.ModifyUserId].ToString().Trim(); //修改人
objXzGradeBaseEN.GradeIndex = objRow[conXzGradeBase.GradeIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzGradeBase.GradeIndex].ToString().Trim()); //年级序号
objXzGradeBaseEN.BeginYearMonth = objRow[conXzGradeBase.BeginYearMonth] == DBNull.Value ? null : objRow[conXzGradeBase.BeginYearMonth].ToString().Trim(); //开始年月
objXzGradeBaseEN.EndYearMonth = objRow[conXzGradeBase.EndYearMonth] == DBNull.Value ? null : objRow[conXzGradeBase.EndYearMonth].ToString().Trim(); //结束年月
objXzGradeBaseEN.AllowUpBaseInfo = clsEntityBase2.TransNullToBool_S(objRow[conXzGradeBase.AllowUpBaseInfo].ToString().Trim()); //允许修改基本信息
objXzGradeBaseEN.GradeBaseNameA = objRow[conXzGradeBase.GradeBaseNameA] == DBNull.Value ? null : objRow[conXzGradeBase.GradeBaseNameA].ToString().Trim(); //GradeBaseNameA
objXzGradeBaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzGradeBase.IsVisible].ToString().Trim()); //是否显示
objXzGradeBaseEN.IdStudyLevel = objRow[conXzGradeBase.IdStudyLevel] == DBNull.Value ? null : objRow[conXzGradeBase.IdStudyLevel].ToString().Trim(); //IdStudyLevel
objXzGradeBaseEN.PointCalcVersionId = objRow[conXzGradeBase.PointCalcVersionId] == DBNull.Value ? null : objRow[conXzGradeBase.PointCalcVersionId].ToString().Trim(); //PointCalcVersionId
objXzGradeBaseEN.Prefix = objRow[conXzGradeBase.Prefix] == DBNull.Value ? null : objRow[conXzGradeBase.Prefix].ToString().Trim(); //Prefix
objXzGradeBaseEN.Memo = objRow[conXzGradeBase.Memo] == DBNull.Value ? null : objRow[conXzGradeBase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzGradeBaseEN.IdGradeBase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzGradeBaseEN);
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
List<clsXzGradeBaseEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsXzGradeBaseEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzGradeBaseEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsXzGradeBaseEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsXzGradeBaseEN> arrObjLst = new List<clsXzGradeBaseEN>(); 
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
	clsXzGradeBaseEN objXzGradeBaseEN = new clsXzGradeBaseEN();
try
{
objXzGradeBaseEN.IdGradeBase = objRow[conXzGradeBase.IdGradeBase].ToString().Trim(); //年级流水号
objXzGradeBaseEN.GradeBaseId = objRow[conXzGradeBase.GradeBaseId].ToString().Trim(); //年级代号
objXzGradeBaseEN.GradeBaseName = objRow[conXzGradeBase.GradeBaseName].ToString().Trim(); //年级名称
objXzGradeBaseEN.SchoolYear = objRow[conXzGradeBase.SchoolYear].ToString().Trim(); //学年
objXzGradeBaseEN.SchoolTerm = objRow[conXzGradeBase.SchoolTerm].ToString().Trim(); //学期
objXzGradeBaseEN.EnterSchoolDate = objRow[conXzGradeBase.EnterSchoolDate] == DBNull.Value ? null : objRow[conXzGradeBase.EnterSchoolDate].ToString().Trim(); //进校日期
objXzGradeBaseEN.CurrentTermSeq = objRow[conXzGradeBase.CurrentTermSeq] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzGradeBase.CurrentTermSeq].ToString().Trim()); //当前学期
objXzGradeBaseEN.ExecPlanTermIndex = objRow[conXzGradeBase.ExecPlanTermIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzGradeBase.ExecPlanTermIndex].ToString().Trim()); //生成执行计划学期
objXzGradeBaseEN.SetEPTermIndexDate = objRow[conXzGradeBase.SetEPTermIndexDate] == DBNull.Value ? null : objRow[conXzGradeBase.SetEPTermIndexDate].ToString().Trim(); //设定执行计划学期日期
objXzGradeBaseEN.IsOffed = clsEntityBase2.TransNullToBool_S(objRow[conXzGradeBase.IsOffed].ToString().Trim()); //是否毕业
objXzGradeBaseEN.ModifyDate = objRow[conXzGradeBase.ModifyDate] == DBNull.Value ? null : objRow[conXzGradeBase.ModifyDate].ToString().Trim(); //修改日期
objXzGradeBaseEN.ModifyUserId = objRow[conXzGradeBase.ModifyUserId] == DBNull.Value ? null : objRow[conXzGradeBase.ModifyUserId].ToString().Trim(); //修改人
objXzGradeBaseEN.GradeIndex = objRow[conXzGradeBase.GradeIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzGradeBase.GradeIndex].ToString().Trim()); //年级序号
objXzGradeBaseEN.BeginYearMonth = objRow[conXzGradeBase.BeginYearMonth] == DBNull.Value ? null : objRow[conXzGradeBase.BeginYearMonth].ToString().Trim(); //开始年月
objXzGradeBaseEN.EndYearMonth = objRow[conXzGradeBase.EndYearMonth] == DBNull.Value ? null : objRow[conXzGradeBase.EndYearMonth].ToString().Trim(); //结束年月
objXzGradeBaseEN.AllowUpBaseInfo = clsEntityBase2.TransNullToBool_S(objRow[conXzGradeBase.AllowUpBaseInfo].ToString().Trim()); //允许修改基本信息
objXzGradeBaseEN.GradeBaseNameA = objRow[conXzGradeBase.GradeBaseNameA] == DBNull.Value ? null : objRow[conXzGradeBase.GradeBaseNameA].ToString().Trim(); //GradeBaseNameA
objXzGradeBaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzGradeBase.IsVisible].ToString().Trim()); //是否显示
objXzGradeBaseEN.IdStudyLevel = objRow[conXzGradeBase.IdStudyLevel] == DBNull.Value ? null : objRow[conXzGradeBase.IdStudyLevel].ToString().Trim(); //IdStudyLevel
objXzGradeBaseEN.PointCalcVersionId = objRow[conXzGradeBase.PointCalcVersionId] == DBNull.Value ? null : objRow[conXzGradeBase.PointCalcVersionId].ToString().Trim(); //PointCalcVersionId
objXzGradeBaseEN.Prefix = objRow[conXzGradeBase.Prefix] == DBNull.Value ? null : objRow[conXzGradeBase.Prefix].ToString().Trim(); //Prefix
objXzGradeBaseEN.Memo = objRow[conXzGradeBase.Memo] == DBNull.Value ? null : objRow[conXzGradeBase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzGradeBaseEN.IdGradeBase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzGradeBaseEN);
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
public static List<clsXzGradeBaseEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsXzGradeBaseEN> arrObjLst = new List<clsXzGradeBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzGradeBaseEN objXzGradeBaseEN = new clsXzGradeBaseEN();
try
{
objXzGradeBaseEN.IdGradeBase = objRow[conXzGradeBase.IdGradeBase].ToString().Trim(); //年级流水号
objXzGradeBaseEN.GradeBaseId = objRow[conXzGradeBase.GradeBaseId].ToString().Trim(); //年级代号
objXzGradeBaseEN.GradeBaseName = objRow[conXzGradeBase.GradeBaseName].ToString().Trim(); //年级名称
objXzGradeBaseEN.SchoolYear = objRow[conXzGradeBase.SchoolYear].ToString().Trim(); //学年
objXzGradeBaseEN.SchoolTerm = objRow[conXzGradeBase.SchoolTerm].ToString().Trim(); //学期
objXzGradeBaseEN.EnterSchoolDate = objRow[conXzGradeBase.EnterSchoolDate] == DBNull.Value ? null : objRow[conXzGradeBase.EnterSchoolDate].ToString().Trim(); //进校日期
objXzGradeBaseEN.CurrentTermSeq = objRow[conXzGradeBase.CurrentTermSeq] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzGradeBase.CurrentTermSeq].ToString().Trim()); //当前学期
objXzGradeBaseEN.ExecPlanTermIndex = objRow[conXzGradeBase.ExecPlanTermIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzGradeBase.ExecPlanTermIndex].ToString().Trim()); //生成执行计划学期
objXzGradeBaseEN.SetEPTermIndexDate = objRow[conXzGradeBase.SetEPTermIndexDate] == DBNull.Value ? null : objRow[conXzGradeBase.SetEPTermIndexDate].ToString().Trim(); //设定执行计划学期日期
objXzGradeBaseEN.IsOffed = clsEntityBase2.TransNullToBool_S(objRow[conXzGradeBase.IsOffed].ToString().Trim()); //是否毕业
objXzGradeBaseEN.ModifyDate = objRow[conXzGradeBase.ModifyDate] == DBNull.Value ? null : objRow[conXzGradeBase.ModifyDate].ToString().Trim(); //修改日期
objXzGradeBaseEN.ModifyUserId = objRow[conXzGradeBase.ModifyUserId] == DBNull.Value ? null : objRow[conXzGradeBase.ModifyUserId].ToString().Trim(); //修改人
objXzGradeBaseEN.GradeIndex = objRow[conXzGradeBase.GradeIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzGradeBase.GradeIndex].ToString().Trim()); //年级序号
objXzGradeBaseEN.BeginYearMonth = objRow[conXzGradeBase.BeginYearMonth] == DBNull.Value ? null : objRow[conXzGradeBase.BeginYearMonth].ToString().Trim(); //开始年月
objXzGradeBaseEN.EndYearMonth = objRow[conXzGradeBase.EndYearMonth] == DBNull.Value ? null : objRow[conXzGradeBase.EndYearMonth].ToString().Trim(); //结束年月
objXzGradeBaseEN.AllowUpBaseInfo = clsEntityBase2.TransNullToBool_S(objRow[conXzGradeBase.AllowUpBaseInfo].ToString().Trim()); //允许修改基本信息
objXzGradeBaseEN.GradeBaseNameA = objRow[conXzGradeBase.GradeBaseNameA] == DBNull.Value ? null : objRow[conXzGradeBase.GradeBaseNameA].ToString().Trim(); //GradeBaseNameA
objXzGradeBaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzGradeBase.IsVisible].ToString().Trim()); //是否显示
objXzGradeBaseEN.IdStudyLevel = objRow[conXzGradeBase.IdStudyLevel] == DBNull.Value ? null : objRow[conXzGradeBase.IdStudyLevel].ToString().Trim(); //IdStudyLevel
objXzGradeBaseEN.PointCalcVersionId = objRow[conXzGradeBase.PointCalcVersionId] == DBNull.Value ? null : objRow[conXzGradeBase.PointCalcVersionId].ToString().Trim(); //PointCalcVersionId
objXzGradeBaseEN.Prefix = objRow[conXzGradeBase.Prefix] == DBNull.Value ? null : objRow[conXzGradeBase.Prefix].ToString().Trim(); //Prefix
objXzGradeBaseEN.Memo = objRow[conXzGradeBase.Memo] == DBNull.Value ? null : objRow[conXzGradeBase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzGradeBaseEN.IdGradeBase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzGradeBaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsXzGradeBaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsXzGradeBaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsXzGradeBaseEN> arrObjLst = new List<clsXzGradeBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzGradeBaseEN objXzGradeBaseEN = new clsXzGradeBaseEN();
try
{
objXzGradeBaseEN.IdGradeBase = objRow[conXzGradeBase.IdGradeBase].ToString().Trim(); //年级流水号
objXzGradeBaseEN.GradeBaseId = objRow[conXzGradeBase.GradeBaseId].ToString().Trim(); //年级代号
objXzGradeBaseEN.GradeBaseName = objRow[conXzGradeBase.GradeBaseName].ToString().Trim(); //年级名称
objXzGradeBaseEN.SchoolYear = objRow[conXzGradeBase.SchoolYear].ToString().Trim(); //学年
objXzGradeBaseEN.SchoolTerm = objRow[conXzGradeBase.SchoolTerm].ToString().Trim(); //学期
objXzGradeBaseEN.EnterSchoolDate = objRow[conXzGradeBase.EnterSchoolDate] == DBNull.Value ? null : objRow[conXzGradeBase.EnterSchoolDate].ToString().Trim(); //进校日期
objXzGradeBaseEN.CurrentTermSeq = objRow[conXzGradeBase.CurrentTermSeq] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzGradeBase.CurrentTermSeq].ToString().Trim()); //当前学期
objXzGradeBaseEN.ExecPlanTermIndex = objRow[conXzGradeBase.ExecPlanTermIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzGradeBase.ExecPlanTermIndex].ToString().Trim()); //生成执行计划学期
objXzGradeBaseEN.SetEPTermIndexDate = objRow[conXzGradeBase.SetEPTermIndexDate] == DBNull.Value ? null : objRow[conXzGradeBase.SetEPTermIndexDate].ToString().Trim(); //设定执行计划学期日期
objXzGradeBaseEN.IsOffed = clsEntityBase2.TransNullToBool_S(objRow[conXzGradeBase.IsOffed].ToString().Trim()); //是否毕业
objXzGradeBaseEN.ModifyDate = objRow[conXzGradeBase.ModifyDate] == DBNull.Value ? null : objRow[conXzGradeBase.ModifyDate].ToString().Trim(); //修改日期
objXzGradeBaseEN.ModifyUserId = objRow[conXzGradeBase.ModifyUserId] == DBNull.Value ? null : objRow[conXzGradeBase.ModifyUserId].ToString().Trim(); //修改人
objXzGradeBaseEN.GradeIndex = objRow[conXzGradeBase.GradeIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzGradeBase.GradeIndex].ToString().Trim()); //年级序号
objXzGradeBaseEN.BeginYearMonth = objRow[conXzGradeBase.BeginYearMonth] == DBNull.Value ? null : objRow[conXzGradeBase.BeginYearMonth].ToString().Trim(); //开始年月
objXzGradeBaseEN.EndYearMonth = objRow[conXzGradeBase.EndYearMonth] == DBNull.Value ? null : objRow[conXzGradeBase.EndYearMonth].ToString().Trim(); //结束年月
objXzGradeBaseEN.AllowUpBaseInfo = clsEntityBase2.TransNullToBool_S(objRow[conXzGradeBase.AllowUpBaseInfo].ToString().Trim()); //允许修改基本信息
objXzGradeBaseEN.GradeBaseNameA = objRow[conXzGradeBase.GradeBaseNameA] == DBNull.Value ? null : objRow[conXzGradeBase.GradeBaseNameA].ToString().Trim(); //GradeBaseNameA
objXzGradeBaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzGradeBase.IsVisible].ToString().Trim()); //是否显示
objXzGradeBaseEN.IdStudyLevel = objRow[conXzGradeBase.IdStudyLevel] == DBNull.Value ? null : objRow[conXzGradeBase.IdStudyLevel].ToString().Trim(); //IdStudyLevel
objXzGradeBaseEN.PointCalcVersionId = objRow[conXzGradeBase.PointCalcVersionId] == DBNull.Value ? null : objRow[conXzGradeBase.PointCalcVersionId].ToString().Trim(); //PointCalcVersionId
objXzGradeBaseEN.Prefix = objRow[conXzGradeBase.Prefix] == DBNull.Value ? null : objRow[conXzGradeBase.Prefix].ToString().Trim(); //Prefix
objXzGradeBaseEN.Memo = objRow[conXzGradeBase.Memo] == DBNull.Value ? null : objRow[conXzGradeBase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzGradeBaseEN.IdGradeBase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzGradeBaseEN);
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
public static List<clsXzGradeBaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsXzGradeBaseEN> arrObjLst = new List<clsXzGradeBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzGradeBaseEN objXzGradeBaseEN = new clsXzGradeBaseEN();
try
{
objXzGradeBaseEN.IdGradeBase = objRow[conXzGradeBase.IdGradeBase].ToString().Trim(); //年级流水号
objXzGradeBaseEN.GradeBaseId = objRow[conXzGradeBase.GradeBaseId].ToString().Trim(); //年级代号
objXzGradeBaseEN.GradeBaseName = objRow[conXzGradeBase.GradeBaseName].ToString().Trim(); //年级名称
objXzGradeBaseEN.SchoolYear = objRow[conXzGradeBase.SchoolYear].ToString().Trim(); //学年
objXzGradeBaseEN.SchoolTerm = objRow[conXzGradeBase.SchoolTerm].ToString().Trim(); //学期
objXzGradeBaseEN.EnterSchoolDate = objRow[conXzGradeBase.EnterSchoolDate] == DBNull.Value ? null : objRow[conXzGradeBase.EnterSchoolDate].ToString().Trim(); //进校日期
objXzGradeBaseEN.CurrentTermSeq = objRow[conXzGradeBase.CurrentTermSeq] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzGradeBase.CurrentTermSeq].ToString().Trim()); //当前学期
objXzGradeBaseEN.ExecPlanTermIndex = objRow[conXzGradeBase.ExecPlanTermIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzGradeBase.ExecPlanTermIndex].ToString().Trim()); //生成执行计划学期
objXzGradeBaseEN.SetEPTermIndexDate = objRow[conXzGradeBase.SetEPTermIndexDate] == DBNull.Value ? null : objRow[conXzGradeBase.SetEPTermIndexDate].ToString().Trim(); //设定执行计划学期日期
objXzGradeBaseEN.IsOffed = clsEntityBase2.TransNullToBool_S(objRow[conXzGradeBase.IsOffed].ToString().Trim()); //是否毕业
objXzGradeBaseEN.ModifyDate = objRow[conXzGradeBase.ModifyDate] == DBNull.Value ? null : objRow[conXzGradeBase.ModifyDate].ToString().Trim(); //修改日期
objXzGradeBaseEN.ModifyUserId = objRow[conXzGradeBase.ModifyUserId] == DBNull.Value ? null : objRow[conXzGradeBase.ModifyUserId].ToString().Trim(); //修改人
objXzGradeBaseEN.GradeIndex = objRow[conXzGradeBase.GradeIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzGradeBase.GradeIndex].ToString().Trim()); //年级序号
objXzGradeBaseEN.BeginYearMonth = objRow[conXzGradeBase.BeginYearMonth] == DBNull.Value ? null : objRow[conXzGradeBase.BeginYearMonth].ToString().Trim(); //开始年月
objXzGradeBaseEN.EndYearMonth = objRow[conXzGradeBase.EndYearMonth] == DBNull.Value ? null : objRow[conXzGradeBase.EndYearMonth].ToString().Trim(); //结束年月
objXzGradeBaseEN.AllowUpBaseInfo = clsEntityBase2.TransNullToBool_S(objRow[conXzGradeBase.AllowUpBaseInfo].ToString().Trim()); //允许修改基本信息
objXzGradeBaseEN.GradeBaseNameA = objRow[conXzGradeBase.GradeBaseNameA] == DBNull.Value ? null : objRow[conXzGradeBase.GradeBaseNameA].ToString().Trim(); //GradeBaseNameA
objXzGradeBaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzGradeBase.IsVisible].ToString().Trim()); //是否显示
objXzGradeBaseEN.IdStudyLevel = objRow[conXzGradeBase.IdStudyLevel] == DBNull.Value ? null : objRow[conXzGradeBase.IdStudyLevel].ToString().Trim(); //IdStudyLevel
objXzGradeBaseEN.PointCalcVersionId = objRow[conXzGradeBase.PointCalcVersionId] == DBNull.Value ? null : objRow[conXzGradeBase.PointCalcVersionId].ToString().Trim(); //PointCalcVersionId
objXzGradeBaseEN.Prefix = objRow[conXzGradeBase.Prefix] == DBNull.Value ? null : objRow[conXzGradeBase.Prefix].ToString().Trim(); //Prefix
objXzGradeBaseEN.Memo = objRow[conXzGradeBase.Memo] == DBNull.Value ? null : objRow[conXzGradeBase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzGradeBaseEN.IdGradeBase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzGradeBaseEN);
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
public static IEnumerable<clsXzGradeBaseEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsXzGradeBaseEN objXzGradeBaseCond, string strOrderBy)
{
List<clsXzGradeBaseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsXzGradeBaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conXzGradeBase.AttributeName)
{
if (objXzGradeBaseCond.IsUpdated(strFldName) == false) continue;
if (objXzGradeBaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objXzGradeBaseCond[strFldName].ToString());
}
else
{
if (objXzGradeBaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objXzGradeBaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objXzGradeBaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objXzGradeBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objXzGradeBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objXzGradeBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objXzGradeBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objXzGradeBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objXzGradeBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objXzGradeBaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objXzGradeBaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objXzGradeBaseCond[strFldName]));
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
public static IEnumerable<clsXzGradeBaseEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsXzGradeBaseEN objXzGradeBaseCond = JsonConvert.DeserializeObject<clsXzGradeBaseEN>(objPagerPara.whereCond);
if (objXzGradeBaseCond.sfFldComparisonOp == null)
{
objXzGradeBaseCond.dicFldComparisonOp = null;
}
else
{
objXzGradeBaseCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objXzGradeBaseCond.sfFldComparisonOp);
}
clsXzGradeBaseBL.SetUpdFlag(objXzGradeBaseCond);
 try
{
CheckProperty4Condition(objXzGradeBaseCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsXzGradeBaseBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objXzGradeBaseCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzGradeBaseEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsXzGradeBaseEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsXzGradeBaseEN> arrObjLst = new List<clsXzGradeBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzGradeBaseEN objXzGradeBaseEN = new clsXzGradeBaseEN();
try
{
objXzGradeBaseEN.IdGradeBase = objRow[conXzGradeBase.IdGradeBase].ToString().Trim(); //年级流水号
objXzGradeBaseEN.GradeBaseId = objRow[conXzGradeBase.GradeBaseId].ToString().Trim(); //年级代号
objXzGradeBaseEN.GradeBaseName = objRow[conXzGradeBase.GradeBaseName].ToString().Trim(); //年级名称
objXzGradeBaseEN.SchoolYear = objRow[conXzGradeBase.SchoolYear].ToString().Trim(); //学年
objXzGradeBaseEN.SchoolTerm = objRow[conXzGradeBase.SchoolTerm].ToString().Trim(); //学期
objXzGradeBaseEN.EnterSchoolDate = objRow[conXzGradeBase.EnterSchoolDate] == DBNull.Value ? null : objRow[conXzGradeBase.EnterSchoolDate].ToString().Trim(); //进校日期
objXzGradeBaseEN.CurrentTermSeq = objRow[conXzGradeBase.CurrentTermSeq] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzGradeBase.CurrentTermSeq].ToString().Trim()); //当前学期
objXzGradeBaseEN.ExecPlanTermIndex = objRow[conXzGradeBase.ExecPlanTermIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzGradeBase.ExecPlanTermIndex].ToString().Trim()); //生成执行计划学期
objXzGradeBaseEN.SetEPTermIndexDate = objRow[conXzGradeBase.SetEPTermIndexDate] == DBNull.Value ? null : objRow[conXzGradeBase.SetEPTermIndexDate].ToString().Trim(); //设定执行计划学期日期
objXzGradeBaseEN.IsOffed = clsEntityBase2.TransNullToBool_S(objRow[conXzGradeBase.IsOffed].ToString().Trim()); //是否毕业
objXzGradeBaseEN.ModifyDate = objRow[conXzGradeBase.ModifyDate] == DBNull.Value ? null : objRow[conXzGradeBase.ModifyDate].ToString().Trim(); //修改日期
objXzGradeBaseEN.ModifyUserId = objRow[conXzGradeBase.ModifyUserId] == DBNull.Value ? null : objRow[conXzGradeBase.ModifyUserId].ToString().Trim(); //修改人
objXzGradeBaseEN.GradeIndex = objRow[conXzGradeBase.GradeIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzGradeBase.GradeIndex].ToString().Trim()); //年级序号
objXzGradeBaseEN.BeginYearMonth = objRow[conXzGradeBase.BeginYearMonth] == DBNull.Value ? null : objRow[conXzGradeBase.BeginYearMonth].ToString().Trim(); //开始年月
objXzGradeBaseEN.EndYearMonth = objRow[conXzGradeBase.EndYearMonth] == DBNull.Value ? null : objRow[conXzGradeBase.EndYearMonth].ToString().Trim(); //结束年月
objXzGradeBaseEN.AllowUpBaseInfo = clsEntityBase2.TransNullToBool_S(objRow[conXzGradeBase.AllowUpBaseInfo].ToString().Trim()); //允许修改基本信息
objXzGradeBaseEN.GradeBaseNameA = objRow[conXzGradeBase.GradeBaseNameA] == DBNull.Value ? null : objRow[conXzGradeBase.GradeBaseNameA].ToString().Trim(); //GradeBaseNameA
objXzGradeBaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzGradeBase.IsVisible].ToString().Trim()); //是否显示
objXzGradeBaseEN.IdStudyLevel = objRow[conXzGradeBase.IdStudyLevel] == DBNull.Value ? null : objRow[conXzGradeBase.IdStudyLevel].ToString().Trim(); //IdStudyLevel
objXzGradeBaseEN.PointCalcVersionId = objRow[conXzGradeBase.PointCalcVersionId] == DBNull.Value ? null : objRow[conXzGradeBase.PointCalcVersionId].ToString().Trim(); //PointCalcVersionId
objXzGradeBaseEN.Prefix = objRow[conXzGradeBase.Prefix] == DBNull.Value ? null : objRow[conXzGradeBase.Prefix].ToString().Trim(); //Prefix
objXzGradeBaseEN.Memo = objRow[conXzGradeBase.Memo] == DBNull.Value ? null : objRow[conXzGradeBase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzGradeBaseEN.IdGradeBase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzGradeBaseEN);
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
public static List<clsXzGradeBaseEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsXzGradeBaseEN> arrObjLst = new List<clsXzGradeBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzGradeBaseEN objXzGradeBaseEN = new clsXzGradeBaseEN();
try
{
objXzGradeBaseEN.IdGradeBase = objRow[conXzGradeBase.IdGradeBase].ToString().Trim(); //年级流水号
objXzGradeBaseEN.GradeBaseId = objRow[conXzGradeBase.GradeBaseId].ToString().Trim(); //年级代号
objXzGradeBaseEN.GradeBaseName = objRow[conXzGradeBase.GradeBaseName].ToString().Trim(); //年级名称
objXzGradeBaseEN.SchoolYear = objRow[conXzGradeBase.SchoolYear].ToString().Trim(); //学年
objXzGradeBaseEN.SchoolTerm = objRow[conXzGradeBase.SchoolTerm].ToString().Trim(); //学期
objXzGradeBaseEN.EnterSchoolDate = objRow[conXzGradeBase.EnterSchoolDate] == DBNull.Value ? null : objRow[conXzGradeBase.EnterSchoolDate].ToString().Trim(); //进校日期
objXzGradeBaseEN.CurrentTermSeq = objRow[conXzGradeBase.CurrentTermSeq] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzGradeBase.CurrentTermSeq].ToString().Trim()); //当前学期
objXzGradeBaseEN.ExecPlanTermIndex = objRow[conXzGradeBase.ExecPlanTermIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzGradeBase.ExecPlanTermIndex].ToString().Trim()); //生成执行计划学期
objXzGradeBaseEN.SetEPTermIndexDate = objRow[conXzGradeBase.SetEPTermIndexDate] == DBNull.Value ? null : objRow[conXzGradeBase.SetEPTermIndexDate].ToString().Trim(); //设定执行计划学期日期
objXzGradeBaseEN.IsOffed = clsEntityBase2.TransNullToBool_S(objRow[conXzGradeBase.IsOffed].ToString().Trim()); //是否毕业
objXzGradeBaseEN.ModifyDate = objRow[conXzGradeBase.ModifyDate] == DBNull.Value ? null : objRow[conXzGradeBase.ModifyDate].ToString().Trim(); //修改日期
objXzGradeBaseEN.ModifyUserId = objRow[conXzGradeBase.ModifyUserId] == DBNull.Value ? null : objRow[conXzGradeBase.ModifyUserId].ToString().Trim(); //修改人
objXzGradeBaseEN.GradeIndex = objRow[conXzGradeBase.GradeIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzGradeBase.GradeIndex].ToString().Trim()); //年级序号
objXzGradeBaseEN.BeginYearMonth = objRow[conXzGradeBase.BeginYearMonth] == DBNull.Value ? null : objRow[conXzGradeBase.BeginYearMonth].ToString().Trim(); //开始年月
objXzGradeBaseEN.EndYearMonth = objRow[conXzGradeBase.EndYearMonth] == DBNull.Value ? null : objRow[conXzGradeBase.EndYearMonth].ToString().Trim(); //结束年月
objXzGradeBaseEN.AllowUpBaseInfo = clsEntityBase2.TransNullToBool_S(objRow[conXzGradeBase.AllowUpBaseInfo].ToString().Trim()); //允许修改基本信息
objXzGradeBaseEN.GradeBaseNameA = objRow[conXzGradeBase.GradeBaseNameA] == DBNull.Value ? null : objRow[conXzGradeBase.GradeBaseNameA].ToString().Trim(); //GradeBaseNameA
objXzGradeBaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzGradeBase.IsVisible].ToString().Trim()); //是否显示
objXzGradeBaseEN.IdStudyLevel = objRow[conXzGradeBase.IdStudyLevel] == DBNull.Value ? null : objRow[conXzGradeBase.IdStudyLevel].ToString().Trim(); //IdStudyLevel
objXzGradeBaseEN.PointCalcVersionId = objRow[conXzGradeBase.PointCalcVersionId] == DBNull.Value ? null : objRow[conXzGradeBase.PointCalcVersionId].ToString().Trim(); //PointCalcVersionId
objXzGradeBaseEN.Prefix = objRow[conXzGradeBase.Prefix] == DBNull.Value ? null : objRow[conXzGradeBase.Prefix].ToString().Trim(); //Prefix
objXzGradeBaseEN.Memo = objRow[conXzGradeBase.Memo] == DBNull.Value ? null : objRow[conXzGradeBase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzGradeBaseEN.IdGradeBase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzGradeBaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzGradeBaseEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsXzGradeBaseEN> arrObjLst = new List<clsXzGradeBaseEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzGradeBaseEN objXzGradeBaseEN = new clsXzGradeBaseEN();
try
{
objXzGradeBaseEN.IdGradeBase = objRow[conXzGradeBase.IdGradeBase].ToString().Trim(); //年级流水号
objXzGradeBaseEN.GradeBaseId = objRow[conXzGradeBase.GradeBaseId].ToString().Trim(); //年级代号
objXzGradeBaseEN.GradeBaseName = objRow[conXzGradeBase.GradeBaseName].ToString().Trim(); //年级名称
objXzGradeBaseEN.SchoolYear = objRow[conXzGradeBase.SchoolYear].ToString().Trim(); //学年
objXzGradeBaseEN.SchoolTerm = objRow[conXzGradeBase.SchoolTerm].ToString().Trim(); //学期
objXzGradeBaseEN.EnterSchoolDate = objRow[conXzGradeBase.EnterSchoolDate] == DBNull.Value ? null : objRow[conXzGradeBase.EnterSchoolDate].ToString().Trim(); //进校日期
objXzGradeBaseEN.CurrentTermSeq = objRow[conXzGradeBase.CurrentTermSeq] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzGradeBase.CurrentTermSeq].ToString().Trim()); //当前学期
objXzGradeBaseEN.ExecPlanTermIndex = objRow[conXzGradeBase.ExecPlanTermIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzGradeBase.ExecPlanTermIndex].ToString().Trim()); //生成执行计划学期
objXzGradeBaseEN.SetEPTermIndexDate = objRow[conXzGradeBase.SetEPTermIndexDate] == DBNull.Value ? null : objRow[conXzGradeBase.SetEPTermIndexDate].ToString().Trim(); //设定执行计划学期日期
objXzGradeBaseEN.IsOffed = clsEntityBase2.TransNullToBool_S(objRow[conXzGradeBase.IsOffed].ToString().Trim()); //是否毕业
objXzGradeBaseEN.ModifyDate = objRow[conXzGradeBase.ModifyDate] == DBNull.Value ? null : objRow[conXzGradeBase.ModifyDate].ToString().Trim(); //修改日期
objXzGradeBaseEN.ModifyUserId = objRow[conXzGradeBase.ModifyUserId] == DBNull.Value ? null : objRow[conXzGradeBase.ModifyUserId].ToString().Trim(); //修改人
objXzGradeBaseEN.GradeIndex = objRow[conXzGradeBase.GradeIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzGradeBase.GradeIndex].ToString().Trim()); //年级序号
objXzGradeBaseEN.BeginYearMonth = objRow[conXzGradeBase.BeginYearMonth] == DBNull.Value ? null : objRow[conXzGradeBase.BeginYearMonth].ToString().Trim(); //开始年月
objXzGradeBaseEN.EndYearMonth = objRow[conXzGradeBase.EndYearMonth] == DBNull.Value ? null : objRow[conXzGradeBase.EndYearMonth].ToString().Trim(); //结束年月
objXzGradeBaseEN.AllowUpBaseInfo = clsEntityBase2.TransNullToBool_S(objRow[conXzGradeBase.AllowUpBaseInfo].ToString().Trim()); //允许修改基本信息
objXzGradeBaseEN.GradeBaseNameA = objRow[conXzGradeBase.GradeBaseNameA] == DBNull.Value ? null : objRow[conXzGradeBase.GradeBaseNameA].ToString().Trim(); //GradeBaseNameA
objXzGradeBaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzGradeBase.IsVisible].ToString().Trim()); //是否显示
objXzGradeBaseEN.IdStudyLevel = objRow[conXzGradeBase.IdStudyLevel] == DBNull.Value ? null : objRow[conXzGradeBase.IdStudyLevel].ToString().Trim(); //IdStudyLevel
objXzGradeBaseEN.PointCalcVersionId = objRow[conXzGradeBase.PointCalcVersionId] == DBNull.Value ? null : objRow[conXzGradeBase.PointCalcVersionId].ToString().Trim(); //PointCalcVersionId
objXzGradeBaseEN.Prefix = objRow[conXzGradeBase.Prefix] == DBNull.Value ? null : objRow[conXzGradeBase.Prefix].ToString().Trim(); //Prefix
objXzGradeBaseEN.Memo = objRow[conXzGradeBase.Memo] == DBNull.Value ? null : objRow[conXzGradeBase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzGradeBaseEN.IdGradeBase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzGradeBaseEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetXzGradeBase(ref clsXzGradeBaseEN objXzGradeBaseEN)
{
bool bolResult = XzGradeBaseDA.GetXzGradeBase(ref objXzGradeBaseEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdGradeBase">表关键字</param>
 /// <returns>表对象</returns>
public static clsXzGradeBaseEN GetObjByIdGradeBase(string strIdGradeBase)
{
if (strIdGradeBase.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdGradeBase]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdGradeBase) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdGradeBase]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsXzGradeBaseEN objXzGradeBaseEN = XzGradeBaseDA.GetObjByIdGradeBase(strIdGradeBase);
return objXzGradeBaseEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsXzGradeBaseEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsXzGradeBaseEN objXzGradeBaseEN = XzGradeBaseDA.GetFirstObj(strWhereCond);
 return objXzGradeBaseEN;
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
public static clsXzGradeBaseEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsXzGradeBaseEN objXzGradeBaseEN = XzGradeBaseDA.GetObjByDataRow(objRow);
 return objXzGradeBaseEN;
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
public static clsXzGradeBaseEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsXzGradeBaseEN objXzGradeBaseEN = XzGradeBaseDA.GetObjByDataRow(objRow);
 return objXzGradeBaseEN;
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
 /// <param name = "strIdGradeBase">所给的关键字</param>
 /// <param name = "lstXzGradeBaseObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsXzGradeBaseEN GetObjByIdGradeBaseFromList(string strIdGradeBase, List<clsXzGradeBaseEN> lstXzGradeBaseObjLst)
{
foreach (clsXzGradeBaseEN objXzGradeBaseEN in lstXzGradeBaseObjLst)
{
if (objXzGradeBaseEN.IdGradeBase == strIdGradeBase)
{
return objXzGradeBaseEN;
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
 string strIdGradeBase;
 try
 {
 strIdGradeBase = new clsXzGradeBaseDA().GetFirstID(strWhereCond);
 return strIdGradeBase;
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
 arrList = XzGradeBaseDA.GetID(strWhereCond);
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
bool bolIsExist = XzGradeBaseDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdGradeBase">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdGradeBase)
{
if (string.IsNullOrEmpty(strIdGradeBase) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdGradeBase]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = XzGradeBaseDA.IsExist(strIdGradeBase);
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
 bolIsExist = clsXzGradeBaseDA.IsExistTable();
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
 bolIsExist = XzGradeBaseDA.IsExistTable(strTabName);
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
 /// <param name = "objXzGradeBaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsXzGradeBaseEN objXzGradeBaseEN)
{
 if (string.IsNullOrEmpty(objXzGradeBaseEN.IdGradeBase) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsXzGradeBaseBL.IsExist(objXzGradeBaseEN.IdGradeBase) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objXzGradeBaseEN.IdGradeBase, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = XzGradeBaseDA.AddNewRecordBySQL2(objXzGradeBaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzGradeBaseBL.ReFreshCache();

if (clsXzGradeBaseBL.relatedActions != null)
{
clsXzGradeBaseBL.relatedActions.UpdRelaTabDate(objXzGradeBaseEN.IdGradeBase, "SetUpdDate");
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
 /// <param name = "objXzGradeBaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsXzGradeBaseEN objXzGradeBaseEN)
{
 if (string.IsNullOrEmpty(objXzGradeBaseEN.IdGradeBase) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsXzGradeBaseBL.IsExist(objXzGradeBaseEN.IdGradeBase) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objXzGradeBaseEN.IdGradeBase, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = XzGradeBaseDA.AddNewRecordBySQL2WithReturnKey(objXzGradeBaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzGradeBaseBL.ReFreshCache();

if (clsXzGradeBaseBL.relatedActions != null)
{
clsXzGradeBaseBL.relatedActions.UpdRelaTabDate(objXzGradeBaseEN.IdGradeBase, "SetUpdDate");
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
 /// <param name = "strXzGradeBaseObjXml">代表实体对象的XML串</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql_XML(string strXzGradeBaseObjXml)
{
clsXzGradeBaseEN objXzGradeBaseEN = GetObjFromXmlStr(strXzGradeBaseObjXml);
try
{
bool bolResult = XzGradeBaseDA.AddNewRecordBySQL2(objXzGradeBaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzGradeBaseBL.ReFreshCache();

if (clsXzGradeBaseBL.relatedActions != null)
{
clsXzGradeBaseBL.relatedActions.UpdRelaTabDate(objXzGradeBaseEN.IdGradeBase, "SetUpdDate");
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
 /// <param name = "objXzGradeBaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsXzGradeBaseEN objXzGradeBaseEN)
{
try
{
bool bolResult = XzGradeBaseDA.Update(objXzGradeBaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzGradeBaseBL.ReFreshCache();

if (clsXzGradeBaseBL.relatedActions != null)
{
clsXzGradeBaseBL.relatedActions.UpdRelaTabDate(objXzGradeBaseEN.IdGradeBase, "SetUpdDate");
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
 /// <param name = "objXzGradeBaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsXzGradeBaseEN objXzGradeBaseEN)
{
 if (string.IsNullOrEmpty(objXzGradeBaseEN.IdGradeBase) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = XzGradeBaseDA.UpdateBySql2(objXzGradeBaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzGradeBaseBL.ReFreshCache();

if (clsXzGradeBaseBL.relatedActions != null)
{
clsXzGradeBaseBL.relatedActions.UpdRelaTabDate(objXzGradeBaseEN.IdGradeBase, "SetUpdDate");
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
 /// <param name = "strXzGradeBaseObjXml">需要修改的对象,用XML来表示</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql_XML(string strXzGradeBaseObjXml)
{
clsXzGradeBaseEN objXzGradeBaseEN = GetObjFromXmlStr(strXzGradeBaseObjXml);
try
{
bool bolResult = XzGradeBaseDA.UpdateBySql2(objXzGradeBaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzGradeBaseBL.ReFreshCache();

if (clsXzGradeBaseBL.relatedActions != null)
{
clsXzGradeBaseBL.relatedActions.UpdRelaTabDate(objXzGradeBaseEN.IdGradeBase, "SetUpdDate");
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
 /// <param name = "strIdGradeBase">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strIdGradeBase)
{
try
{
 clsXzGradeBaseEN objXzGradeBaseEN = clsXzGradeBaseBL.GetObjByIdGradeBase(strIdGradeBase);

if (clsXzGradeBaseBL.relatedActions != null)
{
clsXzGradeBaseBL.relatedActions.UpdRelaTabDate(objXzGradeBaseEN.IdGradeBase, "SetUpdDate");
}
if (objXzGradeBaseEN != null)
{
int intRecNum = XzGradeBaseDA.DelRecord(strIdGradeBase);
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
/// <param name="strIdGradeBase">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strIdGradeBase )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
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
//删除与表:[XzGradeBase]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conXzGradeBase.IdGradeBase,
//strIdGradeBase);
//        clsXzGradeBaseBL.DelXzGradeBasesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsXzGradeBaseBL.DelRecord(strIdGradeBase, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsXzGradeBaseBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdGradeBase, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strIdGradeBase">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strIdGradeBase, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsXzGradeBaseBL.relatedActions != null)
{
clsXzGradeBaseBL.relatedActions.UpdRelaTabDate(strIdGradeBase, "UpdRelaTabDate");
}
bool bolResult = XzGradeBaseDA.DelRecord(strIdGradeBase,objSqlConnection,objSqlTransaction);
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
 /// <param name = "strIdGradeBase">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strIdGradeBase) 
{
try
{
if (clsXzGradeBaseBL.relatedActions != null)
{
clsXzGradeBaseBL.relatedActions.UpdRelaTabDate(strIdGradeBase, "UpdRelaTabDate");
}
bool bolResult = XzGradeBaseDA.DelRecordBySP(strIdGradeBase);
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
 /// <param name = "arrIdGradeBaseLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelXzGradeBases(List<string> arrIdGradeBaseLst)
{
if (arrIdGradeBaseLst.Count == 0) return 0;
try
{
if (clsXzGradeBaseBL.relatedActions != null)
{
foreach (var strIdGradeBase in arrIdGradeBaseLst)
{
clsXzGradeBaseBL.relatedActions.UpdRelaTabDate(strIdGradeBase, "UpdRelaTabDate");
}
}
int intDelRecNum = XzGradeBaseDA.DelXzGradeBase(arrIdGradeBaseLst);
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
public static int DelXzGradeBasesByCond(string strWhereCond)
{
try
{
if (clsXzGradeBaseBL.relatedActions != null)
{
List<string> arrIdGradeBase = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdGradeBase in arrIdGradeBase)
{
clsXzGradeBaseBL.relatedActions.UpdRelaTabDate(strIdGradeBase, "UpdRelaTabDate");
}
}
int intRecNum = XzGradeBaseDA.DelXzGradeBase(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[XzGradeBase]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strIdGradeBase">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strIdGradeBase)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsXzGradeBaseDA.GetSpecSQLObj();
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
//删除与表:[XzGradeBase]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsXzGradeBaseBL.DelRecord(strIdGradeBase, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsXzGradeBaseBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdGradeBase, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objXzGradeBaseENS">源对象</param>
 /// <param name = "objXzGradeBaseENT">目标对象</param>
 public static void CopyTo(clsXzGradeBaseEN objXzGradeBaseENS, clsXzGradeBaseEN objXzGradeBaseENT)
{
try
{
objXzGradeBaseENT.IdGradeBase = objXzGradeBaseENS.IdGradeBase; //年级流水号
objXzGradeBaseENT.GradeBaseId = objXzGradeBaseENS.GradeBaseId; //年级代号
objXzGradeBaseENT.GradeBaseName = objXzGradeBaseENS.GradeBaseName; //年级名称
objXzGradeBaseENT.SchoolYear = objXzGradeBaseENS.SchoolYear; //学年
objXzGradeBaseENT.SchoolTerm = objXzGradeBaseENS.SchoolTerm; //学期
objXzGradeBaseENT.EnterSchoolDate = objXzGradeBaseENS.EnterSchoolDate; //进校日期
objXzGradeBaseENT.CurrentTermSeq = objXzGradeBaseENS.CurrentTermSeq; //当前学期
objXzGradeBaseENT.ExecPlanTermIndex = objXzGradeBaseENS.ExecPlanTermIndex; //生成执行计划学期
objXzGradeBaseENT.SetEPTermIndexDate = objXzGradeBaseENS.SetEPTermIndexDate; //设定执行计划学期日期
objXzGradeBaseENT.IsOffed = objXzGradeBaseENS.IsOffed; //是否毕业
objXzGradeBaseENT.ModifyDate = objXzGradeBaseENS.ModifyDate; //修改日期
objXzGradeBaseENT.ModifyUserId = objXzGradeBaseENS.ModifyUserId; //修改人
objXzGradeBaseENT.GradeIndex = objXzGradeBaseENS.GradeIndex; //年级序号
objXzGradeBaseENT.BeginYearMonth = objXzGradeBaseENS.BeginYearMonth; //开始年月
objXzGradeBaseENT.EndYearMonth = objXzGradeBaseENS.EndYearMonth; //结束年月
objXzGradeBaseENT.AllowUpBaseInfo = objXzGradeBaseENS.AllowUpBaseInfo; //允许修改基本信息
objXzGradeBaseENT.GradeBaseNameA = objXzGradeBaseENS.GradeBaseNameA; //GradeBaseNameA
objXzGradeBaseENT.IsVisible = objXzGradeBaseENS.IsVisible; //是否显示
objXzGradeBaseENT.IdStudyLevel = objXzGradeBaseENS.IdStudyLevel; //IdStudyLevel
objXzGradeBaseENT.PointCalcVersionId = objXzGradeBaseENS.PointCalcVersionId; //PointCalcVersionId
objXzGradeBaseENT.Prefix = objXzGradeBaseENS.Prefix; //Prefix
objXzGradeBaseENT.Memo = objXzGradeBaseENS.Memo; //备注
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
 /// <param name = "objXzGradeBaseEN">源简化对象</param>
 public static void SetUpdFlag(clsXzGradeBaseEN objXzGradeBaseEN)
{
try
{
objXzGradeBaseEN.ClearUpdateState();
   string strsfUpdFldSetStr = objXzGradeBaseEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conXzGradeBase.IdGradeBase, new clsStrCompareIgnoreCase())  ==  true)
{
objXzGradeBaseEN.IdGradeBase = objXzGradeBaseEN.IdGradeBase; //年级流水号
}
if (arrFldSet.Contains(conXzGradeBase.GradeBaseId, new clsStrCompareIgnoreCase())  ==  true)
{
objXzGradeBaseEN.GradeBaseId = objXzGradeBaseEN.GradeBaseId; //年级代号
}
if (arrFldSet.Contains(conXzGradeBase.GradeBaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objXzGradeBaseEN.GradeBaseName = objXzGradeBaseEN.GradeBaseName; //年级名称
}
if (arrFldSet.Contains(conXzGradeBase.SchoolYear, new clsStrCompareIgnoreCase())  ==  true)
{
objXzGradeBaseEN.SchoolYear = objXzGradeBaseEN.SchoolYear; //学年
}
if (arrFldSet.Contains(conXzGradeBase.SchoolTerm, new clsStrCompareIgnoreCase())  ==  true)
{
objXzGradeBaseEN.SchoolTerm = objXzGradeBaseEN.SchoolTerm; //学期
}
if (arrFldSet.Contains(conXzGradeBase.EnterSchoolDate, new clsStrCompareIgnoreCase())  ==  true)
{
objXzGradeBaseEN.EnterSchoolDate = objXzGradeBaseEN.EnterSchoolDate == "[null]" ? null :  objXzGradeBaseEN.EnterSchoolDate; //进校日期
}
if (arrFldSet.Contains(conXzGradeBase.CurrentTermSeq, new clsStrCompareIgnoreCase())  ==  true)
{
objXzGradeBaseEN.CurrentTermSeq = objXzGradeBaseEN.CurrentTermSeq; //当前学期
}
if (arrFldSet.Contains(conXzGradeBase.ExecPlanTermIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objXzGradeBaseEN.ExecPlanTermIndex = objXzGradeBaseEN.ExecPlanTermIndex; //生成执行计划学期
}
if (arrFldSet.Contains(conXzGradeBase.SetEPTermIndexDate, new clsStrCompareIgnoreCase())  ==  true)
{
objXzGradeBaseEN.SetEPTermIndexDate = objXzGradeBaseEN.SetEPTermIndexDate == "[null]" ? null :  objXzGradeBaseEN.SetEPTermIndexDate; //设定执行计划学期日期
}
if (arrFldSet.Contains(conXzGradeBase.IsOffed, new clsStrCompareIgnoreCase())  ==  true)
{
objXzGradeBaseEN.IsOffed = objXzGradeBaseEN.IsOffed; //是否毕业
}
if (arrFldSet.Contains(conXzGradeBase.ModifyDate, new clsStrCompareIgnoreCase())  ==  true)
{
objXzGradeBaseEN.ModifyDate = objXzGradeBaseEN.ModifyDate == "[null]" ? null :  objXzGradeBaseEN.ModifyDate; //修改日期
}
if (arrFldSet.Contains(conXzGradeBase.ModifyUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objXzGradeBaseEN.ModifyUserId = objXzGradeBaseEN.ModifyUserId == "[null]" ? null :  objXzGradeBaseEN.ModifyUserId; //修改人
}
if (arrFldSet.Contains(conXzGradeBase.GradeIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objXzGradeBaseEN.GradeIndex = objXzGradeBaseEN.GradeIndex; //年级序号
}
if (arrFldSet.Contains(conXzGradeBase.BeginYearMonth, new clsStrCompareIgnoreCase())  ==  true)
{
objXzGradeBaseEN.BeginYearMonth = objXzGradeBaseEN.BeginYearMonth == "[null]" ? null :  objXzGradeBaseEN.BeginYearMonth; //开始年月
}
if (arrFldSet.Contains(conXzGradeBase.EndYearMonth, new clsStrCompareIgnoreCase())  ==  true)
{
objXzGradeBaseEN.EndYearMonth = objXzGradeBaseEN.EndYearMonth == "[null]" ? null :  objXzGradeBaseEN.EndYearMonth; //结束年月
}
if (arrFldSet.Contains(conXzGradeBase.AllowUpBaseInfo, new clsStrCompareIgnoreCase())  ==  true)
{
objXzGradeBaseEN.AllowUpBaseInfo = objXzGradeBaseEN.AllowUpBaseInfo; //允许修改基本信息
}
if (arrFldSet.Contains(conXzGradeBase.GradeBaseNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objXzGradeBaseEN.GradeBaseNameA = objXzGradeBaseEN.GradeBaseNameA == "[null]" ? null :  objXzGradeBaseEN.GradeBaseNameA; //GradeBaseNameA
}
if (arrFldSet.Contains(conXzGradeBase.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objXzGradeBaseEN.IsVisible = objXzGradeBaseEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(conXzGradeBase.IdStudyLevel, new clsStrCompareIgnoreCase())  ==  true)
{
objXzGradeBaseEN.IdStudyLevel = objXzGradeBaseEN.IdStudyLevel == "[null]" ? null :  objXzGradeBaseEN.IdStudyLevel; //IdStudyLevel
}
if (arrFldSet.Contains(conXzGradeBase.PointCalcVersionId, new clsStrCompareIgnoreCase())  ==  true)
{
objXzGradeBaseEN.PointCalcVersionId = objXzGradeBaseEN.PointCalcVersionId == "[null]" ? null :  objXzGradeBaseEN.PointCalcVersionId; //PointCalcVersionId
}
if (arrFldSet.Contains(conXzGradeBase.Prefix, new clsStrCompareIgnoreCase())  ==  true)
{
objXzGradeBaseEN.Prefix = objXzGradeBaseEN.Prefix == "[null]" ? null :  objXzGradeBaseEN.Prefix; //Prefix
}
if (arrFldSet.Contains(conXzGradeBase.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objXzGradeBaseEN.Memo = objXzGradeBaseEN.Memo == "[null]" ? null :  objXzGradeBaseEN.Memo; //备注
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
 /// <param name = "objXzGradeBaseEN">源简化对象</param>
 public static void AccessFldValueNull(clsXzGradeBaseEN objXzGradeBaseEN)
{
try
{
if (objXzGradeBaseEN.EnterSchoolDate == "[null]") objXzGradeBaseEN.EnterSchoolDate = null; //进校日期
if (objXzGradeBaseEN.SetEPTermIndexDate == "[null]") objXzGradeBaseEN.SetEPTermIndexDate = null; //设定执行计划学期日期
if (objXzGradeBaseEN.ModifyDate == "[null]") objXzGradeBaseEN.ModifyDate = null; //修改日期
if (objXzGradeBaseEN.ModifyUserId == "[null]") objXzGradeBaseEN.ModifyUserId = null; //修改人
if (objXzGradeBaseEN.BeginYearMonth == "[null]") objXzGradeBaseEN.BeginYearMonth = null; //开始年月
if (objXzGradeBaseEN.EndYearMonth == "[null]") objXzGradeBaseEN.EndYearMonth = null; //结束年月
if (objXzGradeBaseEN.GradeBaseNameA == "[null]") objXzGradeBaseEN.GradeBaseNameA = null; //GradeBaseNameA
if (objXzGradeBaseEN.IdStudyLevel == "[null]") objXzGradeBaseEN.IdStudyLevel = null; //IdStudyLevel
if (objXzGradeBaseEN.PointCalcVersionId == "[null]") objXzGradeBaseEN.PointCalcVersionId = null; //PointCalcVersionId
if (objXzGradeBaseEN.Prefix == "[null]") objXzGradeBaseEN.Prefix = null; //Prefix
if (objXzGradeBaseEN.Memo == "[null]") objXzGradeBaseEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsXzGradeBaseEN objXzGradeBaseEN)
{
 XzGradeBaseDA.CheckPropertyNew(objXzGradeBaseEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsXzGradeBaseEN objXzGradeBaseEN)
{
 XzGradeBaseDA.CheckProperty4Condition(objXzGradeBaseEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_IdGradeBaseCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[年级]...","0");
List<clsXzGradeBaseEN> arrXzGradeBaseObjLst = GetAllXzGradeBaseObjLstCache(); 
objDDL.DataValueField = conXzGradeBase.IdGradeBase;
objDDL.DataTextField = conXzGradeBase.GradeBaseName;
objDDL.DataSource = arrXzGradeBaseObjLst;
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
if (clsXzGradeBaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGradeBaseBL没有刷新缓存机制(clsXzGradeBaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdGradeBase");
//if (arrXzGradeBaseObjLstCache == null)
//{
//arrXzGradeBaseObjLstCache = XzGradeBaseDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdGradeBase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsXzGradeBaseEN GetObjByIdGradeBaseCache(string strIdGradeBase)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsXzGradeBaseEN._CurrTabName);
List<clsXzGradeBaseEN> arrXzGradeBaseObjLstCache = GetObjLstCache();
IEnumerable <clsXzGradeBaseEN> arrXzGradeBaseObjLst_Sel =
arrXzGradeBaseObjLstCache
.Where(x=> x.IdGradeBase == strIdGradeBase 
);
if (arrXzGradeBaseObjLst_Sel.Count() == 0)
{
   clsXzGradeBaseEN obj = clsXzGradeBaseBL.GetObjByIdGradeBase(strIdGradeBase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrXzGradeBaseObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdGradeBase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetGradeBaseNameByIdGradeBaseCache(string strIdGradeBase)
{
if (string.IsNullOrEmpty(strIdGradeBase) == true) return "";
//获取缓存中的对象列表
clsXzGradeBaseEN objXzGradeBase = GetObjByIdGradeBaseCache(strIdGradeBase);
if (objXzGradeBase == null) return "";
return objXzGradeBase.GradeBaseName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdGradeBase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByIdGradeBaseCache(string strIdGradeBase)
{
if (string.IsNullOrEmpty(strIdGradeBase) == true) return "";
//获取缓存中的对象列表
clsXzGradeBaseEN objXzGradeBase = GetObjByIdGradeBaseCache(strIdGradeBase);
if (objXzGradeBase == null) return "";
return objXzGradeBase.GradeBaseName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsXzGradeBaseEN> GetAllXzGradeBaseObjLstCache()
{
//获取缓存中的对象列表
List<clsXzGradeBaseEN> arrXzGradeBaseObjLstCache = GetObjLstCache(); 
return arrXzGradeBaseObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsXzGradeBaseEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsXzGradeBaseEN._CurrTabName);
List<clsXzGradeBaseEN> arrXzGradeBaseObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrXzGradeBaseObjLstCache;
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
string strKey = string.Format("{0}", clsXzGradeBaseEN._CurrTabName);
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
if (clsXzGradeBaseBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsXzGradeBaseEN._CurrTabName);
CacheHelper.Remove(strKey);
clsXzGradeBaseBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2024-02-18
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstXzGradeBaseObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsXzGradeBaseEN> lstXzGradeBaseObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstXzGradeBaseObjLst, writer);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 序列化一个对象列表到XmlWriter
 /// 作者:pyf
 /// 日期:2024-02-18
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXML)
 /// </summary>
 /// <param name = "lstXzGradeBaseObjLst">[clsXzGradeBaseEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsXzGradeBaseEN> lstXzGradeBaseObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsXzGradeBaseBL.listXmlNode);
writer.WriteStartElement(clsXzGradeBaseBL.itemsXmlNode);
foreach (clsXzGradeBaseEN objXzGradeBaseEN in lstXzGradeBaseObjLst)
{
clsXzGradeBaseBL.SerializeXML(writer, objXzGradeBaseEN);
}
writer.WriteEndElement();
writer.WriteEndElement();
return true;
}

 /// <summary>
 /// 把一个对象序列化到XML中
 /// 作者:pyf
 /// 日期:2024-02-18
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeXML)
 /// </summary>
 /// <param name = "writer">目标:序列化到的XmlWriter</param>
 /// <param name = "objXzGradeBaseEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsXzGradeBaseEN objXzGradeBaseEN)
{
writer.WriteStartElement(clsXzGradeBaseBL.itemXmlNode);
 
if (objXzGradeBaseEN.IdGradeBase != null)
{
writer.WriteElementString(conXzGradeBase.IdGradeBase, objXzGradeBaseEN.IdGradeBase.ToString(CultureInfo.InvariantCulture));
}
 
if (objXzGradeBaseEN.GradeBaseId != null)
{
writer.WriteElementString(conXzGradeBase.GradeBaseId, objXzGradeBaseEN.GradeBaseId.ToString(CultureInfo.InvariantCulture));
}
 
if (objXzGradeBaseEN.GradeBaseName != null)
{
writer.WriteElementString(conXzGradeBase.GradeBaseName, objXzGradeBaseEN.GradeBaseName.ToString(CultureInfo.InvariantCulture));
}
 
if (objXzGradeBaseEN.SchoolYear != null)
{
writer.WriteElementString(conXzGradeBase.SchoolYear, objXzGradeBaseEN.SchoolYear.ToString(CultureInfo.InvariantCulture));
}
 
if (objXzGradeBaseEN.SchoolTerm != null)
{
writer.WriteElementString(conXzGradeBase.SchoolTerm, objXzGradeBaseEN.SchoolTerm.ToString(CultureInfo.InvariantCulture));
}
 
if (objXzGradeBaseEN.EnterSchoolDate != null)
{
writer.WriteElementString(conXzGradeBase.EnterSchoolDate, objXzGradeBaseEN.EnterSchoolDate.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(conXzGradeBase.CurrentTermSeq, objXzGradeBaseEN.CurrentTermSeq.ToString());
 
writer.WriteElementString(conXzGradeBase.ExecPlanTermIndex, objXzGradeBaseEN.ExecPlanTermIndex.ToString());
 
if (objXzGradeBaseEN.SetEPTermIndexDate != null)
{
writer.WriteElementString(conXzGradeBase.SetEPTermIndexDate, objXzGradeBaseEN.SetEPTermIndexDate.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(conXzGradeBase.IsOffed, objXzGradeBaseEN.IsOffed.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objXzGradeBaseEN.ModifyDate != null)
{
writer.WriteElementString(conXzGradeBase.ModifyDate, objXzGradeBaseEN.ModifyDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objXzGradeBaseEN.ModifyUserId != null)
{
writer.WriteElementString(conXzGradeBase.ModifyUserId, objXzGradeBaseEN.ModifyUserId.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(conXzGradeBase.GradeIndex, objXzGradeBaseEN.GradeIndex.ToString());
 
if (objXzGradeBaseEN.BeginYearMonth != null)
{
writer.WriteElementString(conXzGradeBase.BeginYearMonth, objXzGradeBaseEN.BeginYearMonth.ToString(CultureInfo.InvariantCulture));
}
 
if (objXzGradeBaseEN.EndYearMonth != null)
{
writer.WriteElementString(conXzGradeBase.EndYearMonth, objXzGradeBaseEN.EndYearMonth.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(conXzGradeBase.AllowUpBaseInfo, objXzGradeBaseEN.AllowUpBaseInfo.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objXzGradeBaseEN.GradeBaseNameA != null)
{
writer.WriteElementString(conXzGradeBase.GradeBaseNameA, objXzGradeBaseEN.GradeBaseNameA.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(conXzGradeBase.IsVisible, objXzGradeBaseEN.IsVisible.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objXzGradeBaseEN.IdStudyLevel != null)
{
writer.WriteElementString(conXzGradeBase.IdStudyLevel, objXzGradeBaseEN.IdStudyLevel.ToString(CultureInfo.InvariantCulture));
}
 
if (objXzGradeBaseEN.PointCalcVersionId != null)
{
writer.WriteElementString(conXzGradeBase.PointCalcVersionId, objXzGradeBaseEN.PointCalcVersionId.ToString(CultureInfo.InvariantCulture));
}
 
if (objXzGradeBaseEN.Prefix != null)
{
writer.WriteElementString(conXzGradeBase.Prefix, objXzGradeBaseEN.Prefix.ToString(CultureInfo.InvariantCulture));
}
 
if (objXzGradeBaseEN.Memo != null)
{
writer.WriteElementString(conXzGradeBase.Memo, objXzGradeBaseEN.Memo.ToString(CultureInfo.InvariantCulture));
}
writer.WriteEndElement();
}

 /// <summary>
 /// 读XmlReader到一个对象
 /// 作者:pyf
 /// 日期:2024-02-18
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlReader)
 /// </summary>
 /// <param name = "reader">提供的数据源:XmlReader</param>
 /// <returns>返回的一个对象</returns>
public static clsXzGradeBaseEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsXzGradeBaseEN objXzGradeBaseEN = new clsXzGradeBaseEN();
reader.Read();
while (!(reader.Name == clsXzGradeBaseBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(conXzGradeBase.IdGradeBase))
{
objXzGradeBaseEN.IdGradeBase = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conXzGradeBase.GradeBaseId))
{
objXzGradeBaseEN.GradeBaseId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conXzGradeBase.GradeBaseName))
{
objXzGradeBaseEN.GradeBaseName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conXzGradeBase.SchoolYear))
{
objXzGradeBaseEN.SchoolYear = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conXzGradeBase.SchoolTerm))
{
objXzGradeBaseEN.SchoolTerm = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conXzGradeBase.EnterSchoolDate))
{
objXzGradeBaseEN.EnterSchoolDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conXzGradeBase.CurrentTermSeq))
{
objXzGradeBaseEN.CurrentTermSeq = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(conXzGradeBase.ExecPlanTermIndex))
{
objXzGradeBaseEN.ExecPlanTermIndex = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(conXzGradeBase.SetEPTermIndexDate))
{
objXzGradeBaseEN.SetEPTermIndexDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conXzGradeBase.IsOffed))
{
objXzGradeBaseEN.IsOffed = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(conXzGradeBase.ModifyDate))
{
objXzGradeBaseEN.ModifyDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conXzGradeBase.ModifyUserId))
{
objXzGradeBaseEN.ModifyUserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conXzGradeBase.GradeIndex))
{
objXzGradeBaseEN.GradeIndex = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(conXzGradeBase.BeginYearMonth))
{
objXzGradeBaseEN.BeginYearMonth = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conXzGradeBase.EndYearMonth))
{
objXzGradeBaseEN.EndYearMonth = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conXzGradeBase.AllowUpBaseInfo))
{
objXzGradeBaseEN.AllowUpBaseInfo = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(conXzGradeBase.GradeBaseNameA))
{
objXzGradeBaseEN.GradeBaseNameA = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conXzGradeBase.IsVisible))
{
objXzGradeBaseEN.IsVisible = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(conXzGradeBase.IdStudyLevel))
{
objXzGradeBaseEN.IdStudyLevel = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conXzGradeBase.PointCalcVersionId))
{
objXzGradeBaseEN.PointCalcVersionId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conXzGradeBase.Prefix))
{
objXzGradeBaseEN.Prefix = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conXzGradeBase.Memo))
{
objXzGradeBaseEN.Memo = reader.ReadElementContentAsString();
}
}
return objXzGradeBaseEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strXzGradeBaseObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsXzGradeBaseEN GetObjFromXmlStr(string strXzGradeBaseObjXmlStr)
{
clsXzGradeBaseEN objXzGradeBaseEN = new clsXzGradeBaseEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strXzGradeBaseObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsXzGradeBaseBL.itemXmlNode))
{
objXzGradeBaseEN = GetObjFromXml(reader);
return objXzGradeBaseEN;
}
}
return objXzGradeBaseEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2024-02-18
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsXzGradeBaseEN objXzGradeBaseEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objXzGradeBaseEN);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2024-02-18
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strIdGradeBase)
{
if (strInFldName != conXzGradeBase.IdGradeBase)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conXzGradeBase.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conXzGradeBase.AttributeName));
throw new Exception(strMsg);
}
var objXzGradeBase = clsXzGradeBaseBL.GetObjByIdGradeBaseCache(strIdGradeBase);
if (objXzGradeBase == null) return "";
return objXzGradeBase[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2024-02-18
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsXzGradeBaseEN objXzGradeBaseEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsXzGradeBaseEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objXzGradeBaseEN[strField]);
}
sbJSON.Remove(sbJSON.Length - 1, 1);
sbJSON.Append("}");
return sbJSON.ToString();
}

 /// <summary>
 /// 序列化一个对象列表到JSON串
 /// 作者:pyf
 /// 日期:2024-02-18
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToJSONStr)
 /// </summary>
 /// <param name = "lstXzGradeBaseObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsXzGradeBaseEN> lstXzGradeBaseObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstXzGradeBaseObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsXzGradeBaseEN objXzGradeBaseEN in lstXzGradeBaseObjLst)
{
string strJSON_One = SerializeObjToJSON(objXzGradeBaseEN);
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
int intRecCount = clsXzGradeBaseDA.GetRecCount(strTabName);
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
int intRecCount = clsXzGradeBaseDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsXzGradeBaseDA.GetRecCount();
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
int intRecCount = clsXzGradeBaseDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objXzGradeBaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsXzGradeBaseEN objXzGradeBaseCond)
{
List<clsXzGradeBaseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsXzGradeBaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conXzGradeBase.AttributeName)
{
if (objXzGradeBaseCond.IsUpdated(strFldName) == false) continue;
if (objXzGradeBaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objXzGradeBaseCond[strFldName].ToString());
}
else
{
if (objXzGradeBaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objXzGradeBaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objXzGradeBaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objXzGradeBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objXzGradeBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objXzGradeBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objXzGradeBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objXzGradeBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objXzGradeBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objXzGradeBaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objXzGradeBaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objXzGradeBaseCond[strFldName]));
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
 List<string> arrList = clsXzGradeBaseDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = XzGradeBaseDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = XzGradeBaseDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = XzGradeBaseDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsXzGradeBaseDA.SetFldValue(clsXzGradeBaseEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = XzGradeBaseDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsXzGradeBaseDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsXzGradeBaseDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsXzGradeBaseDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[XzGradeBase] "); 
 strCreateTabCode.Append(" ( "); 
 // /**年级流水号*/ 
 strCreateTabCode.Append(" IdGradeBase char(4) primary key, "); 
 // /**年级代号*/ 
 strCreateTabCode.Append(" GradeBaseId char(4) not Null, "); 
 // /**年级名称*/ 
 strCreateTabCode.Append(" GradeBaseName varchar(20) not Null, "); 
 // /**学年*/ 
 strCreateTabCode.Append(" SchoolYear varchar(10) not Null, "); 
 // /**学期*/ 
 strCreateTabCode.Append(" SchoolTerm char(1) not Null, "); 
 // /**进校日期*/ 
 strCreateTabCode.Append(" EnterSchoolDate char(8) Null, "); 
 // /**当前学期*/ 
 strCreateTabCode.Append(" CurrentTermSeq int Null, "); 
 // /**生成执行计划学期*/ 
 strCreateTabCode.Append(" ExecPlanTermIndex int Null, "); 
 // /**设定执行计划学期日期*/ 
 strCreateTabCode.Append(" SetEPTermIndexDate char(8) Null, "); 
 // /**是否毕业*/ 
 strCreateTabCode.Append(" IsOffed bit not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" ModifyDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" ModifyUserId varchar(18) Null, "); 
 // /**年级序号*/ 
 strCreateTabCode.Append(" GradeIndex int Null, "); 
 // /**开始年月*/ 
 strCreateTabCode.Append(" BeginYearMonth varchar(8) Null, "); 
 // /**结束年月*/ 
 strCreateTabCode.Append(" EndYearMonth varchar(8) Null, "); 
 // /**允许修改基本信息*/ 
 strCreateTabCode.Append(" AllowUpBaseInfo bit Null, "); 
 // /**GradeBaseNameA*/ 
 strCreateTabCode.Append(" GradeBaseNameA varchar(10) Null, "); 
 // /**是否显示*/ 
 strCreateTabCode.Append(" IsVisible bit Null, "); 
 // /**IdStudyLevel*/ 
 strCreateTabCode.Append(" IdStudyLevel char(4) Null, "); 
 // /**PointCalcVersionId*/ 
 strCreateTabCode.Append(" PointCalcVersionId char(2) Null, "); 
 // /**Prefix*/ 
 strCreateTabCode.Append(" Prefix char(3) Null, "); 
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
 /// 年级(XzGradeBase)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4XzGradeBase : clsCommFun4BL
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
clsXzGradeBaseBL.ReFreshThisCache();
}
}

}