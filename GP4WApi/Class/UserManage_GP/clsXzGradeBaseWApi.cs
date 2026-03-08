
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsXzGradeBaseWApi
 表名:XzGradeBase(00140043)
 * 版本:2024.03.19.1(服务器:WIN-SRV103-116)
 日期:2024/03/20 11:20:21
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:用户管理(UserManage_GP)
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
public static class  clsXzGradeBaseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strIdGradeBase">年级流水号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzGradeBaseEN SetIdGradeBase(this clsXzGradeBaseEN objXzGradeBaseEN, string strIdGradeBase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIdGradeBase, 4, conXzGradeBase.IdGradeBase);
clsCheckSql.CheckFieldForeignKey(strIdGradeBase, 4, conXzGradeBase.IdGradeBase);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strGradeBaseId">年级代号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzGradeBaseEN SetGradeBaseId(this clsXzGradeBaseEN objXzGradeBaseEN, string strGradeBaseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGradeBaseId, conXzGradeBase.GradeBaseId);
clsCheckSql.CheckFieldLen(strGradeBaseId, 4, conXzGradeBase.GradeBaseId);
clsCheckSql.CheckFieldForeignKey(strGradeBaseId, 4, conXzGradeBase.GradeBaseId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strGradeBaseName">年级名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzGradeBaseEN SetGradeBaseName(this clsXzGradeBaseEN objXzGradeBaseEN, string strGradeBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGradeBaseName, conXzGradeBase.GradeBaseName);
clsCheckSql.CheckFieldLen(strGradeBaseName, 20, conXzGradeBase.GradeBaseName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strSchoolYear">学年</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzGradeBaseEN SetSchoolYear(this clsXzGradeBaseEN objXzGradeBaseEN, string strSchoolYear, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolYear, conXzGradeBase.SchoolYear);
clsCheckSql.CheckFieldLen(strSchoolYear, 10, conXzGradeBase.SchoolYear);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strSchoolTerm">学期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzGradeBaseEN SetSchoolTerm(this clsXzGradeBaseEN objXzGradeBaseEN, string strSchoolTerm, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolTerm, conXzGradeBase.SchoolTerm);
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, conXzGradeBase.SchoolTerm);
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, conXzGradeBase.SchoolTerm);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strEnterSchoolDate">进校日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzGradeBaseEN SetEnterSchoolDate(this clsXzGradeBaseEN objXzGradeBaseEN, string strEnterSchoolDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEnterSchoolDate, 8, conXzGradeBase.EnterSchoolDate);
clsCheckSql.CheckFieldForeignKey(strEnterSchoolDate, 8, conXzGradeBase.EnterSchoolDate);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "intCurrentTermSeq">当前学期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzGradeBaseEN SetCurrentTermSeq(this clsXzGradeBaseEN objXzGradeBaseEN, int intCurrentTermSeq, string strComparisonOp="")
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "intExecPlanTermIndex">生成执行计划学期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzGradeBaseEN SetExecPlanTermIndex(this clsXzGradeBaseEN objXzGradeBaseEN, int intExecPlanTermIndex, string strComparisonOp="")
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strSetEPTermIndexDate">设定执行计划学期日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzGradeBaseEN SetSetEPTermIndexDate(this clsXzGradeBaseEN objXzGradeBaseEN, string strSetEPTermIndexDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSetEPTermIndexDate, 8, conXzGradeBase.SetEPTermIndexDate);
clsCheckSql.CheckFieldForeignKey(strSetEPTermIndexDate, 8, conXzGradeBase.SetEPTermIndexDate);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsOffed">是否毕业</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strModifyDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzGradeBaseEN SetModifyDate(this clsXzGradeBaseEN objXzGradeBaseEN, string strModifyDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModifyDate, 20, conXzGradeBase.ModifyDate);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strModifyUserId">修改人</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzGradeBaseEN SetModifyUserId(this clsXzGradeBaseEN objXzGradeBaseEN, string strModifyUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModifyUserId, 18, conXzGradeBase.ModifyUserId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "intGradeIndex">年级序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzGradeBaseEN SetGradeIndex(this clsXzGradeBaseEN objXzGradeBaseEN, int intGradeIndex, string strComparisonOp="")
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strBeginYearMonth">开始年月</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzGradeBaseEN SetBeginYearMonth(this clsXzGradeBaseEN objXzGradeBaseEN, string strBeginYearMonth, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strBeginYearMonth, 8, conXzGradeBase.BeginYearMonth);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strEndYearMonth">结束年月</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzGradeBaseEN SetEndYearMonth(this clsXzGradeBaseEN objXzGradeBaseEN, string strEndYearMonth, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEndYearMonth, 8, conXzGradeBase.EndYearMonth);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "bolAllowUpBaseInfo">允许修改基本信息</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strGradeBaseNameA">GradeBaseNameA</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzGradeBaseEN SetGradeBaseNameA(this clsXzGradeBaseEN objXzGradeBaseEN, string strGradeBaseNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGradeBaseNameA, 10, conXzGradeBase.GradeBaseNameA);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsVisible">是否显示</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strIdStudyLevel">IdStudyLevel</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzGradeBaseEN SetIdStudyLevel(this clsXzGradeBaseEN objXzGradeBaseEN, string strIdStudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIdStudyLevel, 4, conXzGradeBase.IdStudyLevel);
clsCheckSql.CheckFieldForeignKey(strIdStudyLevel, 4, conXzGradeBase.IdStudyLevel);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strPointCalcVersionId">PointCalcVersionId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzGradeBaseEN SetPointCalcVersionId(this clsXzGradeBaseEN objXzGradeBaseEN, string strPointCalcVersionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPointCalcVersionId, 2, conXzGradeBase.PointCalcVersionId);
clsCheckSql.CheckFieldForeignKey(strPointCalcVersionId, 2, conXzGradeBase.PointCalcVersionId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrefix">Prefix</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzGradeBaseEN SetPrefix(this clsXzGradeBaseEN objXzGradeBaseEN, string strPrefix, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrefix, 3, conXzGradeBase.Prefix);
clsCheckSql.CheckFieldForeignKey(strPrefix, 3, conXzGradeBase.Prefix);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">备注</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzGradeBaseEN SetMemo(this clsXzGradeBaseEN objXzGradeBaseEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conXzGradeBase.Memo);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
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

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsXzGradeBaseEN objXzGradeBaseEN)
{
 if (string.IsNullOrEmpty(objXzGradeBaseEN.IdGradeBase) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objXzGradeBaseEN.sfUpdFldSetStr = objXzGradeBaseEN.getsfUpdFldSetStr();
clsXzGradeBaseWApi.CheckPropertyNew(objXzGradeBaseEN); 
bool bolResult = clsXzGradeBaseWApi.UpdateRecord(objXzGradeBaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzGradeBaseWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000004)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
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
 if (clsXzGradeBaseWApi.IsExist(objXzGradeBaseEN.IdGradeBase) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objXzGradeBaseEN.IdGradeBase, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsXzGradeBaseWApi.CheckPropertyNew(objXzGradeBaseEN); 
bool bolResult = clsXzGradeBaseWApi.AddNewRecord(objXzGradeBaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzGradeBaseWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000008)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值. 该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsXzGradeBaseEN objXzGradeBaseEN)
{
try
{
clsXzGradeBaseWApi.CheckPropertyNew(objXzGradeBaseEN); 
string strIdGradeBase = clsXzGradeBaseWApi.AddNewRecordWithMaxId(objXzGradeBaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzGradeBaseWApi.ReFreshCache();
return strIdGradeBase;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000009)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsXzGradeBaseEN objXzGradeBaseEN, string strWhereCond)
{
try
{
clsXzGradeBaseWApi.CheckPropertyNew(objXzGradeBaseEN); 
bool bolResult = clsXzGradeBaseWApi.UpdateWithCondition(objXzGradeBaseEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzGradeBaseWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000007)根据条件修改记录出错, {1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// 年级(XzGradeBase)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsXzGradeBaseWApi
{
private static readonly string mstrApiControllerName = "XzGradeBaseApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsXzGradeBaseWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_IdGradeBase(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[年级]...","0");
List<clsXzGradeBaseEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="IdGradeBase";
objDDL.DataTextField="GradeBaseName";
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_IdGradeBase(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conXzGradeBase.IdGradeBase); 
List<clsXzGradeBaseEN> arrObjLst = clsXzGradeBaseWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsXzGradeBaseEN objXzGradeBaseEN = new clsXzGradeBaseEN()
{
IdGradeBase = "0",
GradeBaseName = "选[年级]..."
};
arrObjLst.Insert(0, objXzGradeBaseEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conXzGradeBase.IdGradeBase;
objComboBox.DisplayMember = conXzGradeBase.GradeBaseName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsXzGradeBaseEN objXzGradeBaseEN)
{
if (!Object.Equals(null, objXzGradeBaseEN.IdGradeBase) && GetStrLen(objXzGradeBaseEN.IdGradeBase) > 4)
{
 throw new Exception("字段[年级流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objXzGradeBaseEN.GradeBaseId) && GetStrLen(objXzGradeBaseEN.GradeBaseId) > 4)
{
 throw new Exception("字段[年级代号]的长度不能超过4!");
}
if (!Object.Equals(null, objXzGradeBaseEN.GradeBaseName) && GetStrLen(objXzGradeBaseEN.GradeBaseName) > 20)
{
 throw new Exception("字段[年级名称]的长度不能超过20!");
}
if (!Object.Equals(null, objXzGradeBaseEN.SchoolYear) && GetStrLen(objXzGradeBaseEN.SchoolYear) > 10)
{
 throw new Exception("字段[学年]的长度不能超过10!");
}
if (!Object.Equals(null, objXzGradeBaseEN.SchoolTerm) && GetStrLen(objXzGradeBaseEN.SchoolTerm) > 1)
{
 throw new Exception("字段[学期]的长度不能超过1!");
}
if (!Object.Equals(null, objXzGradeBaseEN.EnterSchoolDate) && GetStrLen(objXzGradeBaseEN.EnterSchoolDate) > 8)
{
 throw new Exception("字段[进校日期]的长度不能超过8!");
}
if (!Object.Equals(null, objXzGradeBaseEN.SetEPTermIndexDate) && GetStrLen(objXzGradeBaseEN.SetEPTermIndexDate) > 8)
{
 throw new Exception("字段[设定执行计划学期日期]的长度不能超过8!");
}
if (!Object.Equals(null, objXzGradeBaseEN.ModifyDate) && GetStrLen(objXzGradeBaseEN.ModifyDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objXzGradeBaseEN.ModifyUserId) && GetStrLen(objXzGradeBaseEN.ModifyUserId) > 18)
{
 throw new Exception("字段[修改人]的长度不能超过18!");
}
if (!Object.Equals(null, objXzGradeBaseEN.BeginYearMonth) && GetStrLen(objXzGradeBaseEN.BeginYearMonth) > 8)
{
 throw new Exception("字段[开始年月]的长度不能超过8!");
}
if (!Object.Equals(null, objXzGradeBaseEN.EndYearMonth) && GetStrLen(objXzGradeBaseEN.EndYearMonth) > 8)
{
 throw new Exception("字段[结束年月]的长度不能超过8!");
}
if (!Object.Equals(null, objXzGradeBaseEN.GradeBaseNameA) && GetStrLen(objXzGradeBaseEN.GradeBaseNameA) > 10)
{
 throw new Exception("字段[GradeBaseNameA]的长度不能超过10!");
}
if (!Object.Equals(null, objXzGradeBaseEN.IdStudyLevel) && GetStrLen(objXzGradeBaseEN.IdStudyLevel) > 4)
{
 throw new Exception("字段[IdStudyLevel]的长度不能超过4!");
}
if (!Object.Equals(null, objXzGradeBaseEN.PointCalcVersionId) && GetStrLen(objXzGradeBaseEN.PointCalcVersionId) > 2)
{
 throw new Exception("字段[PointCalcVersionId]的长度不能超过2!");
}
if (!Object.Equals(null, objXzGradeBaseEN.Prefix) && GetStrLen(objXzGradeBaseEN.Prefix) > 3)
{
 throw new Exception("字段[Prefix]的长度不能超过3!");
}
if (!Object.Equals(null, objXzGradeBaseEN.Memo) && GetStrLen(objXzGradeBaseEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objXzGradeBaseEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdGradeBase">表关键字</param>
 /// <returns>表对象</returns>
public static clsXzGradeBaseEN GetObjByIdGradeBase(string strIdGradeBase)
{
string strAction = "GetObjByIdGradeBase";
clsXzGradeBaseEN objXzGradeBaseEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strIdGradeBase"] = strIdGradeBase,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objXzGradeBaseEN = JsonConvert.DeserializeObject<clsXzGradeBaseEN>(strJson);
return objXzGradeBaseEN;
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
public static clsXzGradeBaseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsXzGradeBaseEN objXzGradeBaseEN;
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
objXzGradeBaseEN = JsonConvert.DeserializeObject<clsXzGradeBaseEN>(strJson);
return objXzGradeBaseEN;
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
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdGradeBase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsXzGradeBaseEN GetObjByIdGradeBaseCache(string strIdGradeBase)
{
if (string.IsNullOrEmpty(strIdGradeBase) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsXzGradeBaseEN._CurrTabName);
List<clsXzGradeBaseEN> arrXzGradeBaseObjLstCache = GetObjLstCache();
IEnumerable <clsXzGradeBaseEN> arrXzGradeBaseObjLst_Sel =
from objXzGradeBaseEN in arrXzGradeBaseObjLstCache
where objXzGradeBaseEN.IdGradeBase == strIdGradeBase 
select objXzGradeBaseEN;
if (arrXzGradeBaseObjLst_Sel.Count() == 0)
{
   clsXzGradeBaseEN obj = clsXzGradeBaseWApi.GetObjByIdGradeBase(strIdGradeBase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrXzGradeBaseObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdGradeBase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetGradeBaseNameByIdGradeBaseCache(string strIdGradeBase)
{
if (string.IsNullOrEmpty(strIdGradeBase) == true) return "";
//初始化列表缓存
List<clsXzGradeBaseEN> arrXzGradeBaseObjLstCache = GetObjLstCache();
IEnumerable <clsXzGradeBaseEN> arrXzGradeBaseObjLst_Sel1 =
from objXzGradeBaseEN in arrXzGradeBaseObjLstCache
where objXzGradeBaseEN.IdGradeBase == strIdGradeBase 
select objXzGradeBaseEN;
List <clsXzGradeBaseEN> arrXzGradeBaseObjLst_Sel = new List<clsXzGradeBaseEN>();
foreach (clsXzGradeBaseEN obj in arrXzGradeBaseObjLst_Sel1)
{
arrXzGradeBaseObjLst_Sel.Add(obj);
}
if (arrXzGradeBaseObjLst_Sel.Count > 0)
{
return arrXzGradeBaseObjLst_Sel[0].GradeBaseName;
}
string strErrMsgForGetObjById = string.Format("在XzGradeBase对象缓存列表中,找不到记录[IdGradeBase = {0}](函数:{1})", strIdGradeBase, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsXzGradeBaseBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdGradeBase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByIdGradeBaseCache(string strIdGradeBase)
{
if (string.IsNullOrEmpty(strIdGradeBase) == true) return "";
//初始化列表缓存
List<clsXzGradeBaseEN> arrXzGradeBaseObjLstCache = GetObjLstCache();
IEnumerable <clsXzGradeBaseEN> arrXzGradeBaseObjLst_Sel1 =
from objXzGradeBaseEN in arrXzGradeBaseObjLstCache
where objXzGradeBaseEN.IdGradeBase == strIdGradeBase 
select objXzGradeBaseEN;
List <clsXzGradeBaseEN> arrXzGradeBaseObjLst_Sel = new List<clsXzGradeBaseEN>();
foreach (clsXzGradeBaseEN obj in arrXzGradeBaseObjLst_Sel1)
{
arrXzGradeBaseObjLst_Sel.Add(obj);
}
if (arrXzGradeBaseObjLst_Sel.Count > 0)
{
return arrXzGradeBaseObjLst_Sel[0].GradeBaseName;
}
string strErrMsgForGetObjById = string.Format("在XzGradeBase对象缓存列表中,找不到记录的相关名称[IdGradeBase = {0}](函数:{1})", strIdGradeBase, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsXzGradeBaseBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzGradeBaseEN> GetObjLst(string strWhereCond)
{
 List<clsXzGradeBaseEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsXzGradeBaseEN>>(strJson);
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
 /// <param name = "arrIdGradeBase">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzGradeBaseEN> GetObjLstByIdGradeBaseLst(List<string> arrIdGradeBase)
{
 List<clsXzGradeBaseEN> arrObjLst; 
string strAction = "GetObjLstByIdGradeBaseLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrIdGradeBase);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsXzGradeBaseEN>>(strJson);
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

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdGradeBase">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsXzGradeBaseEN> GetObjLstByIdGradeBaseLstCache(List<string> arrIdGradeBase)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsXzGradeBaseEN._CurrTabName);
List<clsXzGradeBaseEN> arrXzGradeBaseObjLstCache = GetObjLstCache();
IEnumerable <clsXzGradeBaseEN> arrXzGradeBaseObjLst_Sel =
from objXzGradeBaseEN in arrXzGradeBaseObjLstCache
where arrIdGradeBase.Contains(objXzGradeBaseEN.IdGradeBase)
select objXzGradeBaseEN;
return arrXzGradeBaseObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzGradeBaseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsXzGradeBaseEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsXzGradeBaseEN>>(strJson);
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
public static List<clsXzGradeBaseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsXzGradeBaseEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsXzGradeBaseEN>>(strJson);
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
public static List<clsXzGradeBaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsXzGradeBaseEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsXzGradeBaseEN>>(strJson);
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
public static List<clsXzGradeBaseEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsXzGradeBaseEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsXzGradeBaseEN>>(strJson);
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
 /// 根据关键字删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecord(string strIdGradeBase)
{
string strAction = "DelRecord";
try
{
 clsXzGradeBaseEN objXzGradeBaseEN = clsXzGradeBaseWApi.GetObjByIdGradeBase(strIdGradeBase);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strIdGradeBase.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsXzGradeBaseWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecords)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecords(string strKeyIdLst)
{
string strAction = "DelRecords";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strKeyIdLst, out string strResult, out string strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelXzGradeBases(List<string> arrIdGradeBase)
{
string strAction = "DelXzGradeBases";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrIdGradeBase);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsXzGradeBaseWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelXzGradeBasesByCond(string strWhereCond)
{
string strAction = "DelXzGradeBasesByCond";
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool AddNewRecord(clsXzGradeBaseEN objXzGradeBaseEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsXzGradeBaseEN>(objXzGradeBaseEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzGradeBaseWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithMaxId)
 /// </summary>
 /// <returns>新建记录的关键字</returns>
public static string AddNewRecordWithMaxId(clsXzGradeBaseEN objXzGradeBaseEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsXzGradeBaseEN>(objXzGradeBaseEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzGradeBaseWApi.ReFreshCache();
var strIdGradeBase = (string)jobjReturn0["returnStr"];
return strIdGradeBase;
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsXzGradeBaseEN objXzGradeBaseEN)
{
if (string.IsNullOrEmpty(objXzGradeBaseEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objXzGradeBaseEN.IdGradeBase, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsXzGradeBaseEN>(objXzGradeBaseEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateWithCondition)
 /// </summary>
 /// <param name = "objXzGradeBaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsXzGradeBaseEN objXzGradeBaseEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objXzGradeBaseEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objXzGradeBaseEN.IdGradeBase, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objXzGradeBaseEN.IdGradeBase, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsXzGradeBaseEN>(objXzGradeBaseEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
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
public static bool IsExist(string strIdGradeBase)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strIdGradeBase"] = strIdGradeBase
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
 /// 根据条件设置字段值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_funSetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int SetFldValue(string strFldName, string strValue, string strWhereCond)
{
string strAction = "SetFldValue";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strValue"] = strValue,
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
string strMsg = string.Format("根据条件设置字段值,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId()
{
string strAction = "GetMaxStrId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
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
string strMsg = string.Format("获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefix(string strPrefix)
{
//检测记录是否存在
string strAction = "GetMaxStrIdByPrefix";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
{"strPrefix", strPrefix}
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
string strMsg = string.Format("根据前缀获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取字符串长度,其中汉字为2个字节,英文为1个字节
 /// (AutoGCLib.clsGeneCodeBase:GengetStrLen)
 /// </summary>
 /// <param name = "strTemp">给定的原字符串</param>
 /// <returns>返回字符串长度</returns>
public static int GetStrLen(string strTemp)
{
int len ;
byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
len = sarr.Length;//will output as 3+3*2 = 9
return len;
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
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
public static DataTable ToDataTable(List<clsXzGradeBaseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsXzGradeBaseEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsXzGradeBaseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsXzGradeBaseEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsXzGradeBaseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsXzGradeBaseEN.AttributeName)
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsXzGradeBaseWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsXzGradeBaseEN._CurrTabName);
CacheHelper.Remove(strKey);
clsXzGradeBaseWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsXzGradeBaseEN> GetObjLstCache()
{
//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsXzGradeBaseEN._CurrTabName;
List<clsXzGradeBaseEN> arrXzGradeBaseObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrXzGradeBaseObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsXzGradeBaseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conXzGradeBase.IdGradeBase, Type.GetType("System.String"));
objDT.Columns.Add(conXzGradeBase.GradeBaseId, Type.GetType("System.String"));
objDT.Columns.Add(conXzGradeBase.GradeBaseName, Type.GetType("System.String"));
objDT.Columns.Add(conXzGradeBase.SchoolYear, Type.GetType("System.String"));
objDT.Columns.Add(conXzGradeBase.SchoolTerm, Type.GetType("System.String"));
objDT.Columns.Add(conXzGradeBase.EnterSchoolDate, Type.GetType("System.String"));
objDT.Columns.Add(conXzGradeBase.CurrentTermSeq, Type.GetType("System.Int32"));
objDT.Columns.Add(conXzGradeBase.ExecPlanTermIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(conXzGradeBase.SetEPTermIndexDate, Type.GetType("System.String"));
objDT.Columns.Add(conXzGradeBase.IsOffed, Type.GetType("System.Boolean"));
objDT.Columns.Add(conXzGradeBase.ModifyDate, Type.GetType("System.String"));
objDT.Columns.Add(conXzGradeBase.ModifyUserId, Type.GetType("System.String"));
objDT.Columns.Add(conXzGradeBase.GradeIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(conXzGradeBase.BeginYearMonth, Type.GetType("System.String"));
objDT.Columns.Add(conXzGradeBase.EndYearMonth, Type.GetType("System.String"));
objDT.Columns.Add(conXzGradeBase.AllowUpBaseInfo, Type.GetType("System.Boolean"));
objDT.Columns.Add(conXzGradeBase.GradeBaseNameA, Type.GetType("System.String"));
objDT.Columns.Add(conXzGradeBase.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(conXzGradeBase.IdStudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(conXzGradeBase.PointCalcVersionId, Type.GetType("System.String"));
objDT.Columns.Add(conXzGradeBase.Prefix, Type.GetType("System.String"));
objDT.Columns.Add(conXzGradeBase.Memo, Type.GetType("System.String"));
foreach (clsXzGradeBaseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conXzGradeBase.IdGradeBase] = objInFor[conXzGradeBase.IdGradeBase];
objDR[conXzGradeBase.GradeBaseId] = objInFor[conXzGradeBase.GradeBaseId];
objDR[conXzGradeBase.GradeBaseName] = objInFor[conXzGradeBase.GradeBaseName];
objDR[conXzGradeBase.SchoolYear] = objInFor[conXzGradeBase.SchoolYear];
objDR[conXzGradeBase.SchoolTerm] = objInFor[conXzGradeBase.SchoolTerm];
objDR[conXzGradeBase.EnterSchoolDate] = objInFor[conXzGradeBase.EnterSchoolDate];
objDR[conXzGradeBase.CurrentTermSeq] = objInFor[conXzGradeBase.CurrentTermSeq];
objDR[conXzGradeBase.ExecPlanTermIndex] = objInFor[conXzGradeBase.ExecPlanTermIndex];
objDR[conXzGradeBase.SetEPTermIndexDate] = objInFor[conXzGradeBase.SetEPTermIndexDate];
objDR[conXzGradeBase.IsOffed] = objInFor[conXzGradeBase.IsOffed];
objDR[conXzGradeBase.ModifyDate] = objInFor[conXzGradeBase.ModifyDate];
objDR[conXzGradeBase.ModifyUserId] = objInFor[conXzGradeBase.ModifyUserId];
objDR[conXzGradeBase.GradeIndex] = objInFor[conXzGradeBase.GradeIndex];
objDR[conXzGradeBase.BeginYearMonth] = objInFor[conXzGradeBase.BeginYearMonth];
objDR[conXzGradeBase.EndYearMonth] = objInFor[conXzGradeBase.EndYearMonth];
objDR[conXzGradeBase.AllowUpBaseInfo] = objInFor[conXzGradeBase.AllowUpBaseInfo];
objDR[conXzGradeBase.GradeBaseNameA] = objInFor[conXzGradeBase.GradeBaseNameA];
objDR[conXzGradeBase.IsVisible] = objInFor[conXzGradeBase.IsVisible];
objDR[conXzGradeBase.IdStudyLevel] = objInFor[conXzGradeBase.IdStudyLevel];
objDR[conXzGradeBase.PointCalcVersionId] = objInFor[conXzGradeBase.PointCalcVersionId];
objDR[conXzGradeBase.Prefix] = objInFor[conXzGradeBase.Prefix];
objDR[conXzGradeBase.Memo] = objInFor[conXzGradeBase.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 年级(XzGradeBase)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4XzGradeBase : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
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
clsXzGradeBaseWApi.ReFreshThisCache();
}
}

}