
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxApplicationTypeWApi
 表名:QxApplicationType(00140088)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 18:24:19
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:系统参数(SysPara)
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
public static class  clsQxApplicationTypeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "intApplicationTypeId">应用程序类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxApplicationTypeEN SetApplicationTypeId(this clsQxApplicationTypeEN objQxApplicationTypeEN, int intApplicationTypeId, string strComparisonOp="")
	{
objQxApplicationTypeEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxApplicationTypeEN.dicFldComparisonOp.ContainsKey(conQxApplicationType.ApplicationTypeId) == false)
{
objQxApplicationTypeEN.dicFldComparisonOp.Add(conQxApplicationType.ApplicationTypeId, strComparisonOp);
}
else
{
objQxApplicationTypeEN.dicFldComparisonOp[conQxApplicationType.ApplicationTypeId] = strComparisonOp;
}
}
return objQxApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strApplicationTypeName">应用程序类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxApplicationTypeEN SetApplicationTypeName(this clsQxApplicationTypeEN objQxApplicationTypeEN, string strApplicationTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strApplicationTypeName, conQxApplicationType.ApplicationTypeName);
clsCheckSql.CheckFieldLen(strApplicationTypeName, 30, conQxApplicationType.ApplicationTypeName);
objQxApplicationTypeEN.ApplicationTypeName = strApplicationTypeName; //应用程序类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxApplicationTypeEN.dicFldComparisonOp.ContainsKey(conQxApplicationType.ApplicationTypeName) == false)
{
objQxApplicationTypeEN.dicFldComparisonOp.Add(conQxApplicationType.ApplicationTypeName, strComparisonOp);
}
else
{
objQxApplicationTypeEN.dicFldComparisonOp[conQxApplicationType.ApplicationTypeName] = strComparisonOp;
}
}
return objQxApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strApplicationTypeENName">应用类型英文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxApplicationTypeEN SetApplicationTypeENName(this clsQxApplicationTypeEN objQxApplicationTypeEN, string strApplicationTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strApplicationTypeENName, conQxApplicationType.ApplicationTypeENName);
clsCheckSql.CheckFieldLen(strApplicationTypeENName, 30, conQxApplicationType.ApplicationTypeENName);
objQxApplicationTypeEN.ApplicationTypeENName = strApplicationTypeENName; //应用类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxApplicationTypeEN.dicFldComparisonOp.ContainsKey(conQxApplicationType.ApplicationTypeENName) == false)
{
objQxApplicationTypeEN.dicFldComparisonOp.Add(conQxApplicationType.ApplicationTypeENName, strComparisonOp);
}
else
{
objQxApplicationTypeEN.dicFldComparisonOp[conQxApplicationType.ApplicationTypeENName] = strComparisonOp;
}
}
return objQxApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeId">编程语言类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxApplicationTypeEN SetProgLangTypeId(this clsQxApplicationTypeEN objQxApplicationTypeEN, string strProgLangTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProgLangTypeId, 2, conQxApplicationType.ProgLangTypeId);
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId, 2, conQxApplicationType.ProgLangTypeId);
objQxApplicationTypeEN.ProgLangTypeId = strProgLangTypeId; //编程语言类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxApplicationTypeEN.dicFldComparisonOp.ContainsKey(conQxApplicationType.ProgLangTypeId) == false)
{
objQxApplicationTypeEN.dicFldComparisonOp.Add(conQxApplicationType.ProgLangTypeId, strComparisonOp);
}
else
{
objQxApplicationTypeEN.dicFldComparisonOp[conQxApplicationType.ProgLangTypeId] = strComparisonOp;
}
}
return objQxApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeId2">编程语言类型Id2</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxApplicationTypeEN SetProgLangTypeId2(this clsQxApplicationTypeEN objQxApplicationTypeEN, string strProgLangTypeId2, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProgLangTypeId2, 2, conQxApplicationType.ProgLangTypeId2);
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId2, 2, conQxApplicationType.ProgLangTypeId2);
objQxApplicationTypeEN.ProgLangTypeId2 = strProgLangTypeId2; //编程语言类型Id2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxApplicationTypeEN.dicFldComparisonOp.ContainsKey(conQxApplicationType.ProgLangTypeId2) == false)
{
objQxApplicationTypeEN.dicFldComparisonOp.Add(conQxApplicationType.ProgLangTypeId2, strComparisonOp);
}
else
{
objQxApplicationTypeEN.dicFldComparisonOp[conQxApplicationType.ProgLangTypeId2] = strComparisonOp;
}
}
return objQxApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeId3">编程语言类型Id3</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxApplicationTypeEN SetProgLangTypeId3(this clsQxApplicationTypeEN objQxApplicationTypeEN, string strProgLangTypeId3, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProgLangTypeId3, 2, conQxApplicationType.ProgLangTypeId3);
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId3, 2, conQxApplicationType.ProgLangTypeId3);
objQxApplicationTypeEN.ProgLangTypeId3 = strProgLangTypeId3; //编程语言类型Id3
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxApplicationTypeEN.dicFldComparisonOp.ContainsKey(conQxApplicationType.ProgLangTypeId3) == false)
{
objQxApplicationTypeEN.dicFldComparisonOp.Add(conQxApplicationType.ProgLangTypeId3, strComparisonOp);
}
else
{
objQxApplicationTypeEN.dicFldComparisonOp[conQxApplicationType.ProgLangTypeId3] = strComparisonOp;
}
}
return objQxApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeId4">编程语言类型Id4</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxApplicationTypeEN SetProgLangTypeId4(this clsQxApplicationTypeEN objQxApplicationTypeEN, string strProgLangTypeId4, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProgLangTypeId4, 2, conQxApplicationType.ProgLangTypeId4);
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId4, 2, conQxApplicationType.ProgLangTypeId4);
objQxApplicationTypeEN.ProgLangTypeId4 = strProgLangTypeId4; //编程语言类型Id4
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxApplicationTypeEN.dicFldComparisonOp.ContainsKey(conQxApplicationType.ProgLangTypeId4) == false)
{
objQxApplicationTypeEN.dicFldComparisonOp.Add(conQxApplicationType.ProgLangTypeId4, strComparisonOp);
}
else
{
objQxApplicationTypeEN.dicFldComparisonOp[conQxApplicationType.ProgLangTypeId4] = strComparisonOp;
}
}
return objQxApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeId5">编程语言类型Id5</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxApplicationTypeEN SetProgLangTypeId5(this clsQxApplicationTypeEN objQxApplicationTypeEN, string strProgLangTypeId5, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProgLangTypeId5, 2, conQxApplicationType.ProgLangTypeId5);
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId5, 2, conQxApplicationType.ProgLangTypeId5);
objQxApplicationTypeEN.ProgLangTypeId5 = strProgLangTypeId5; //编程语言类型Id5
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxApplicationTypeEN.dicFldComparisonOp.ContainsKey(conQxApplicationType.ProgLangTypeId5) == false)
{
objQxApplicationTypeEN.dicFldComparisonOp.Add(conQxApplicationType.ProgLangTypeId5, strComparisonOp);
}
else
{
objQxApplicationTypeEN.dicFldComparisonOp[conQxApplicationType.ProgLangTypeId5] = strComparisonOp;
}
}
return objQxApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsVisible">是否显示</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxApplicationTypeEN SetIsVisible(this clsQxApplicationTypeEN objQxApplicationTypeEN, bool bolIsVisible, string strComparisonOp="")
	{
objQxApplicationTypeEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxApplicationTypeEN.dicFldComparisonOp.ContainsKey(conQxApplicationType.IsVisible) == false)
{
objQxApplicationTypeEN.dicFldComparisonOp.Add(conQxApplicationType.IsVisible, strComparisonOp);
}
else
{
objQxApplicationTypeEN.dicFldComparisonOp[conQxApplicationType.IsVisible] = strComparisonOp;
}
}
return objQxApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">排序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxApplicationTypeEN SetOrderNum(this clsQxApplicationTypeEN objQxApplicationTypeEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, conQxApplicationType.OrderNum);
objQxApplicationTypeEN.OrderNum = intOrderNum; //排序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxApplicationTypeEN.dicFldComparisonOp.ContainsKey(conQxApplicationType.OrderNum) == false)
{
objQxApplicationTypeEN.dicFldComparisonOp.Add(conQxApplicationType.OrderNum, strComparisonOp);
}
else
{
objQxApplicationTypeEN.dicFldComparisonOp[conQxApplicationType.OrderNum] = strComparisonOp;
}
}
return objQxApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">备注</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxApplicationTypeEN SetMemo(this clsQxApplicationTypeEN objQxApplicationTypeEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQxApplicationType.Memo);
objQxApplicationTypeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxApplicationTypeEN.dicFldComparisonOp.ContainsKey(conQxApplicationType.Memo) == false)
{
objQxApplicationTypeEN.dicFldComparisonOp.Add(conQxApplicationType.Memo, strComparisonOp);
}
else
{
objQxApplicationTypeEN.dicFldComparisonOp[conQxApplicationType.Memo] = strComparisonOp;
}
}
return objQxApplicationTypeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQxApplicationTypeEN objQxApplicationTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQxApplicationTypeCond.IsUpdated(conQxApplicationType.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objQxApplicationTypeCond.dicFldComparisonOp[conQxApplicationType.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", conQxApplicationType.ApplicationTypeId, objQxApplicationTypeCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objQxApplicationTypeCond.IsUpdated(conQxApplicationType.ApplicationTypeName) == true)
{
string strComparisonOpApplicationTypeName = objQxApplicationTypeCond.dicFldComparisonOp[conQxApplicationType.ApplicationTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxApplicationType.ApplicationTypeName, objQxApplicationTypeCond.ApplicationTypeName, strComparisonOpApplicationTypeName);
}
if (objQxApplicationTypeCond.IsUpdated(conQxApplicationType.ApplicationTypeENName) == true)
{
string strComparisonOpApplicationTypeENName = objQxApplicationTypeCond.dicFldComparisonOp[conQxApplicationType.ApplicationTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxApplicationType.ApplicationTypeENName, objQxApplicationTypeCond.ApplicationTypeENName, strComparisonOpApplicationTypeENName);
}
if (objQxApplicationTypeCond.IsUpdated(conQxApplicationType.ProgLangTypeId) == true)
{
string strComparisonOpProgLangTypeId = objQxApplicationTypeCond.dicFldComparisonOp[conQxApplicationType.ProgLangTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxApplicationType.ProgLangTypeId, objQxApplicationTypeCond.ProgLangTypeId, strComparisonOpProgLangTypeId);
}
if (objQxApplicationTypeCond.IsUpdated(conQxApplicationType.ProgLangTypeId2) == true)
{
string strComparisonOpProgLangTypeId2 = objQxApplicationTypeCond.dicFldComparisonOp[conQxApplicationType.ProgLangTypeId2];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxApplicationType.ProgLangTypeId2, objQxApplicationTypeCond.ProgLangTypeId2, strComparisonOpProgLangTypeId2);
}
if (objQxApplicationTypeCond.IsUpdated(conQxApplicationType.ProgLangTypeId3) == true)
{
string strComparisonOpProgLangTypeId3 = objQxApplicationTypeCond.dicFldComparisonOp[conQxApplicationType.ProgLangTypeId3];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxApplicationType.ProgLangTypeId3, objQxApplicationTypeCond.ProgLangTypeId3, strComparisonOpProgLangTypeId3);
}
if (objQxApplicationTypeCond.IsUpdated(conQxApplicationType.ProgLangTypeId4) == true)
{
string strComparisonOpProgLangTypeId4 = objQxApplicationTypeCond.dicFldComparisonOp[conQxApplicationType.ProgLangTypeId4];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxApplicationType.ProgLangTypeId4, objQxApplicationTypeCond.ProgLangTypeId4, strComparisonOpProgLangTypeId4);
}
if (objQxApplicationTypeCond.IsUpdated(conQxApplicationType.ProgLangTypeId5) == true)
{
string strComparisonOpProgLangTypeId5 = objQxApplicationTypeCond.dicFldComparisonOp[conQxApplicationType.ProgLangTypeId5];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxApplicationType.ProgLangTypeId5, objQxApplicationTypeCond.ProgLangTypeId5, strComparisonOpProgLangTypeId5);
}
if (objQxApplicationTypeCond.IsUpdated(conQxApplicationType.IsVisible) == true)
{
if (objQxApplicationTypeCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQxApplicationType.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQxApplicationType.IsVisible);
}
}
if (objQxApplicationTypeCond.IsUpdated(conQxApplicationType.OrderNum) == true)
{
string strComparisonOpOrderNum = objQxApplicationTypeCond.dicFldComparisonOp[conQxApplicationType.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conQxApplicationType.OrderNum, objQxApplicationTypeCond.OrderNum, strComparisonOpOrderNum);
}
if (objQxApplicationTypeCond.IsUpdated(conQxApplicationType.Memo) == true)
{
string strComparisonOpMemo = objQxApplicationTypeCond.dicFldComparisonOp[conQxApplicationType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxApplicationType.Memo, objQxApplicationTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objQxApplicationTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxApplicationTypeEN objQxApplicationTypeEN)
{
 if (objQxApplicationTypeEN.ApplicationTypeId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objQxApplicationTypeEN.sfUpdFldSetStr = objQxApplicationTypeEN.getsfUpdFldSetStr();
clsQxApplicationTypeWApi.CheckPropertyNew(objQxApplicationTypeEN); 
bool bolResult = clsQxApplicationTypeWApi.UpdateRecord(objQxApplicationTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
 /// 获取唯一性条件串--QxApplicationType(应用程序类型), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ApplicationTypeName
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objQxApplicationTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsQxApplicationTypeEN objQxApplicationTypeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objQxApplicationTypeEN == null) return "";
if (objQxApplicationTypeEN.ApplicationTypeId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ApplicationTypeName = '{0}'", objQxApplicationTypeEN.ApplicationTypeName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ApplicationTypeId !=  {0}", objQxApplicationTypeEN.ApplicationTypeId);
 sbCondition.AppendFormat(" and ApplicationTypeName = '{0}'", objQxApplicationTypeEN.ApplicationTypeName);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQxApplicationTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQxApplicationTypeEN objQxApplicationTypeEN)
{
try
{
clsQxApplicationTypeWApi.CheckPropertyNew(objQxApplicationTypeEN); 
bool bolResult = clsQxApplicationTypeWApi.AddNewRecord(objQxApplicationTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxApplicationTypeWApi.ReFreshCache();
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
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objQxApplicationTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxApplicationTypeEN objQxApplicationTypeEN, string strWhereCond)
{
try
{
clsQxApplicationTypeWApi.CheckPropertyNew(objQxApplicationTypeEN); 
bool bolResult = clsQxApplicationTypeWApi.UpdateWithCondition(objQxApplicationTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxApplicationTypeWApi.ReFreshCache();
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
 /// 根据表内容设置enum列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GeneEnumConstList)
 /// </summary>
public enum enumQxApplicationType : int
{
}
 /// <summary>
 /// 应用程序类型(QxApplicationType)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsQxApplicationTypeWApi
{
private static readonly string mstrApiControllerName = "QxApplicationTypeApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsQxApplicationTypeWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_ApplicationTypeId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[应用程序类型]...","0");
List<clsQxApplicationTypeEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="ApplicationTypeId";
objDDL.DataTextField="ApplicationTypeName";
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

public static void BindCbo_ApplicationTypeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conQxApplicationType.ApplicationTypeId); 
List<clsQxApplicationTypeEN> arrObjLst = clsQxApplicationTypeWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsQxApplicationTypeEN objQxApplicationTypeEN = new clsQxApplicationTypeEN()
{
ApplicationTypeId = 0,
ApplicationTypeName = "选[应用程序类型]..."
};
arrObjLst.Insert(0, objQxApplicationTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conQxApplicationType.ApplicationTypeId;
objComboBox.DisplayMember = conQxApplicationType.ApplicationTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsQxApplicationTypeEN objQxApplicationTypeEN)
{
if (!Object.Equals(null, objQxApplicationTypeEN.ApplicationTypeName) && GetStrLen(objQxApplicationTypeEN.ApplicationTypeName) > 30)
{
 throw new Exception("字段[应用程序类型名称]的长度不能超过30!");
}
if (!Object.Equals(null, objQxApplicationTypeEN.ApplicationTypeENName) && GetStrLen(objQxApplicationTypeEN.ApplicationTypeENName) > 30)
{
 throw new Exception("字段[应用类型英文名]的长度不能超过30!");
}
if (!Object.Equals(null, objQxApplicationTypeEN.ProgLangTypeId) && GetStrLen(objQxApplicationTypeEN.ProgLangTypeId) > 2)
{
 throw new Exception("字段[编程语言类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objQxApplicationTypeEN.ProgLangTypeId2) && GetStrLen(objQxApplicationTypeEN.ProgLangTypeId2) > 2)
{
 throw new Exception("字段[编程语言类型Id2]的长度不能超过2!");
}
if (!Object.Equals(null, objQxApplicationTypeEN.ProgLangTypeId3) && GetStrLen(objQxApplicationTypeEN.ProgLangTypeId3) > 2)
{
 throw new Exception("字段[编程语言类型Id3]的长度不能超过2!");
}
if (!Object.Equals(null, objQxApplicationTypeEN.ProgLangTypeId4) && GetStrLen(objQxApplicationTypeEN.ProgLangTypeId4) > 2)
{
 throw new Exception("字段[编程语言类型Id4]的长度不能超过2!");
}
if (!Object.Equals(null, objQxApplicationTypeEN.ProgLangTypeId5) && GetStrLen(objQxApplicationTypeEN.ProgLangTypeId5) > 2)
{
 throw new Exception("字段[编程语言类型Id5]的长度不能超过2!");
}
if (!Object.Equals(null, objQxApplicationTypeEN.Memo) && GetStrLen(objQxApplicationTypeEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objQxApplicationTypeEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "intApplicationTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxApplicationTypeEN GetObjByApplicationTypeId(int intApplicationTypeId)
{
string strAction = "GetObjByApplicationTypeId";
clsQxApplicationTypeEN objQxApplicationTypeEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["intApplicationTypeId"] = intApplicationTypeId.ToString(),
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objQxApplicationTypeEN = JsonConvert.DeserializeObject<clsQxApplicationTypeEN>(strJson);
return objQxApplicationTypeEN;
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
public static int GetFirstID(string strWhereCond)
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
return int.Parse(strReturnStr);
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
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsQxApplicationTypeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsQxApplicationTypeEN objQxApplicationTypeEN;
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
objQxApplicationTypeEN = JsonConvert.DeserializeObject<clsQxApplicationTypeEN>(strJson);
return objQxApplicationTypeEN;
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
 /// <param name = "intApplicationTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxApplicationTypeEN GetObjByApplicationTypeIdCache(int intApplicationTypeId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsQxApplicationTypeEN._CurrTabName);
List<clsQxApplicationTypeEN> arrQxApplicationTypeObjLstCache = GetObjLstCache();
IEnumerable <clsQxApplicationTypeEN> arrQxApplicationTypeObjLst_Sel =
from objQxApplicationTypeEN in arrQxApplicationTypeObjLstCache
where objQxApplicationTypeEN.ApplicationTypeId == intApplicationTypeId 
select objQxApplicationTypeEN;
if (arrQxApplicationTypeObjLst_Sel.Count() == 0)
{
   clsQxApplicationTypeEN obj = clsQxApplicationTypeWApi.GetObjByApplicationTypeId(intApplicationTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrQxApplicationTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "intApplicationTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetApplicationTypeNameByApplicationTypeIdCache(int intApplicationTypeId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsQxApplicationTypeEN._CurrTabName);
List<clsQxApplicationTypeEN> arrQxApplicationTypeObjLstCache = GetObjLstCache();
IEnumerable <clsQxApplicationTypeEN> arrQxApplicationTypeObjLst_Sel1 =
from objQxApplicationTypeEN in arrQxApplicationTypeObjLstCache
where objQxApplicationTypeEN.ApplicationTypeId == intApplicationTypeId 
select objQxApplicationTypeEN;
List <clsQxApplicationTypeEN> arrQxApplicationTypeObjLst_Sel = new List<clsQxApplicationTypeEN>();
foreach (clsQxApplicationTypeEN obj in arrQxApplicationTypeObjLst_Sel1)
{
arrQxApplicationTypeObjLst_Sel.Add(obj);
}
if (arrQxApplicationTypeObjLst_Sel.Count > 0)
{
return arrQxApplicationTypeObjLst_Sel[0].ApplicationTypeName;
}
string strErrMsgForGetObjById = string.Format("在QxApplicationType对象缓存列表中,找不到记录[ApplicationTypeId = {0}](函数:{1})", intApplicationTypeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsQxApplicationTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "intApplicationTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByApplicationTypeIdCache(int intApplicationTypeId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsQxApplicationTypeEN._CurrTabName);
List<clsQxApplicationTypeEN> arrQxApplicationTypeObjLstCache = GetObjLstCache();
IEnumerable <clsQxApplicationTypeEN> arrQxApplicationTypeObjLst_Sel1 =
from objQxApplicationTypeEN in arrQxApplicationTypeObjLstCache
where objQxApplicationTypeEN.ApplicationTypeId == intApplicationTypeId 
select objQxApplicationTypeEN;
List <clsQxApplicationTypeEN> arrQxApplicationTypeObjLst_Sel = new List<clsQxApplicationTypeEN>();
foreach (clsQxApplicationTypeEN obj in arrQxApplicationTypeObjLst_Sel1)
{
arrQxApplicationTypeObjLst_Sel.Add(obj);
}
if (arrQxApplicationTypeObjLst_Sel.Count > 0)
{
return arrQxApplicationTypeObjLst_Sel[0].ApplicationTypeName;
}
string strErrMsgForGetObjById = string.Format("在QxApplicationType对象缓存列表中,找不到记录的相关名称[ApplicationTypeId = {0}](函数:{1})", intApplicationTypeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsQxApplicationTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxApplicationTypeEN> GetObjLst(string strWhereCond)
{
 List<clsQxApplicationTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxApplicationTypeEN>>(strJson);
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
 /// <param name = "arrApplicationTypeId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxApplicationTypeEN> GetObjLstByApplicationTypeIdLst(List<int> arrApplicationTypeId)
{
 List<clsQxApplicationTypeEN> arrObjLst; 
string strAction = "GetObjLstByApplicationTypeIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrApplicationTypeId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsQxApplicationTypeEN>>(strJson);
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
 /// <param name = "arrApplicationTypeId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsQxApplicationTypeEN> GetObjLstByApplicationTypeIdLstCache(List<int> arrApplicationTypeId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsQxApplicationTypeEN._CurrTabName);
List<clsQxApplicationTypeEN> arrQxApplicationTypeObjLstCache = GetObjLstCache();
IEnumerable <clsQxApplicationTypeEN> arrQxApplicationTypeObjLst_Sel =
from objQxApplicationTypeEN in arrQxApplicationTypeObjLstCache
where arrApplicationTypeId.Contains(objQxApplicationTypeEN.ApplicationTypeId)
select objQxApplicationTypeEN;
return arrQxApplicationTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxApplicationTypeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsQxApplicationTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxApplicationTypeEN>>(strJson);
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
public static List<clsQxApplicationTypeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsQxApplicationTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxApplicationTypeEN>>(strJson);
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
public static List<clsQxApplicationTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsQxApplicationTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxApplicationTypeEN>>(strJson);
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
public static List<clsQxApplicationTypeEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsQxApplicationTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxApplicationTypeEN>>(strJson);
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
public static int DelRecord(int intApplicationTypeId)
{
string strAction = "DelRecord";
try
{
 clsQxApplicationTypeEN objQxApplicationTypeEN = clsQxApplicationTypeWApi.GetObjByApplicationTypeId(intApplicationTypeId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, intApplicationTypeId.ToString(), out string strResult, out string strErrMsg) == true)
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
public static int DelQxApplicationTypes(List<string> arrApplicationTypeId)
{
string strAction = "DelQxApplicationTypes";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrApplicationTypeId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
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
 /// 根据条件删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelQxApplicationTypesByCond(string strWhereCond)
{
string strAction = "DelQxApplicationTypesByCond";
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
public static bool AddNewRecord(clsQxApplicationTypeEN objQxApplicationTypeEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxApplicationTypeEN>(objQxApplicationTypeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objQxApplicationTypeEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsQxApplicationTypeEN objQxApplicationTypeEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxApplicationTypeEN>(objQxApplicationTypeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsQxApplicationTypeEN objQxApplicationTypeEN)
{
if (string.IsNullOrEmpty(objQxApplicationTypeEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objQxApplicationTypeEN.ApplicationTypeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxApplicationTypeEN>(objQxApplicationTypeEN);
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
 /// <param name = "objQxApplicationTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsQxApplicationTypeEN objQxApplicationTypeEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objQxApplicationTypeEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objQxApplicationTypeEN.ApplicationTypeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objQxApplicationTypeEN.ApplicationTypeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxApplicationTypeEN>(objQxApplicationTypeEN);
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
public static bool IsExist(int intApplicationTypeId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["intApplicationTypeId"] = intApplicationTypeId.ToString()
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
 /// <param name = "objQxApplicationTypeENS">源对象</param>
 /// <param name = "objQxApplicationTypeENT">目标对象</param>
 public static void CopyTo(clsQxApplicationTypeEN objQxApplicationTypeENS, clsQxApplicationTypeEN objQxApplicationTypeENT)
{
try
{
objQxApplicationTypeENT.ApplicationTypeId = objQxApplicationTypeENS.ApplicationTypeId; //应用程序类型ID
objQxApplicationTypeENT.ApplicationTypeName = objQxApplicationTypeENS.ApplicationTypeName; //应用程序类型名称
objQxApplicationTypeENT.ApplicationTypeENName = objQxApplicationTypeENS.ApplicationTypeENName; //应用类型英文名
objQxApplicationTypeENT.ProgLangTypeId = objQxApplicationTypeENS.ProgLangTypeId; //编程语言类型Id
objQxApplicationTypeENT.ProgLangTypeId2 = objQxApplicationTypeENS.ProgLangTypeId2; //编程语言类型Id2
objQxApplicationTypeENT.ProgLangTypeId3 = objQxApplicationTypeENS.ProgLangTypeId3; //编程语言类型Id3
objQxApplicationTypeENT.ProgLangTypeId4 = objQxApplicationTypeENS.ProgLangTypeId4; //编程语言类型Id4
objQxApplicationTypeENT.ProgLangTypeId5 = objQxApplicationTypeENS.ProgLangTypeId5; //编程语言类型Id5
objQxApplicationTypeENT.IsVisible = objQxApplicationTypeENS.IsVisible; //是否显示
objQxApplicationTypeENT.OrderNum = objQxApplicationTypeENS.OrderNum; //排序号
objQxApplicationTypeENT.Memo = objQxApplicationTypeENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsQxApplicationTypeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsQxApplicationTypeEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsQxApplicationTypeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsQxApplicationTypeEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsQxApplicationTypeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsQxApplicationTypeEN.AttributeName)
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
string strKey = string.Format("{0}", clsQxApplicationTypeEN._CurrTabName);
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
if (clsQxApplicationTypeWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsQxApplicationTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsQxApplicationTypeWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxApplicationTypeEN> GetObjLstCache()
{
//初始化列表缓存
var strWhereCond = "";
var strKey = clsQxApplicationTypeEN._CurrTabName;
List<clsQxApplicationTypeEN> arrQxApplicationTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrQxApplicationTypeObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsQxApplicationTypeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conQxApplicationType.ApplicationTypeId, Type.GetType("System.Int32"));
objDT.Columns.Add(conQxApplicationType.ApplicationTypeName, Type.GetType("System.String"));
objDT.Columns.Add(conQxApplicationType.ApplicationTypeENName, Type.GetType("System.String"));
objDT.Columns.Add(conQxApplicationType.ProgLangTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conQxApplicationType.ProgLangTypeId2, Type.GetType("System.String"));
objDT.Columns.Add(conQxApplicationType.ProgLangTypeId3, Type.GetType("System.String"));
objDT.Columns.Add(conQxApplicationType.ProgLangTypeId4, Type.GetType("System.String"));
objDT.Columns.Add(conQxApplicationType.ProgLangTypeId5, Type.GetType("System.String"));
objDT.Columns.Add(conQxApplicationType.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(conQxApplicationType.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conQxApplicationType.Memo, Type.GetType("System.String"));
foreach (clsQxApplicationTypeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conQxApplicationType.ApplicationTypeId] = objInFor[conQxApplicationType.ApplicationTypeId];
objDR[conQxApplicationType.ApplicationTypeName] = objInFor[conQxApplicationType.ApplicationTypeName];
objDR[conQxApplicationType.ApplicationTypeENName] = objInFor[conQxApplicationType.ApplicationTypeENName];
objDR[conQxApplicationType.ProgLangTypeId] = objInFor[conQxApplicationType.ProgLangTypeId];
objDR[conQxApplicationType.ProgLangTypeId2] = objInFor[conQxApplicationType.ProgLangTypeId2];
objDR[conQxApplicationType.ProgLangTypeId3] = objInFor[conQxApplicationType.ProgLangTypeId3];
objDR[conQxApplicationType.ProgLangTypeId4] = objInFor[conQxApplicationType.ProgLangTypeId4];
objDR[conQxApplicationType.ProgLangTypeId5] = objInFor[conQxApplicationType.ProgLangTypeId5];
objDR[conQxApplicationType.IsVisible] = objInFor[conQxApplicationType.IsVisible];
objDR[conQxApplicationType.OrderNum] = objInFor[conQxApplicationType.OrderNum];
objDR[conQxApplicationType.Memo] = objInFor[conQxApplicationType.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 应用程序类型(QxApplicationType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4QxApplicationType : clsCommFun4BL
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
clsQxApplicationTypeWApi.ReFreshThisCache();
}
}

}