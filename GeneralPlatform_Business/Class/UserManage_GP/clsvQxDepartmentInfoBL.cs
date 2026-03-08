
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxDepartmentInfoBL
 表名:vQxDepartmentInfo(00140035)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:32:18
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
public static class  clsvQxDepartmentInfoBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strDepartmentId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxDepartmentInfoEN GetObj(this K_DepartmentId_vQxDepartmentInfo myKey)
{
clsvQxDepartmentInfoEN objvQxDepartmentInfoEN = clsvQxDepartmentInfoBL.vQxDepartmentInfoDA.GetObjByDepartmentId(myKey.Value);
return objvQxDepartmentInfoEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxDepartmentInfoEN SetDepartmentId(this clsvQxDepartmentInfoEN objvQxDepartmentInfoEN, string strDepartmentId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentId, 8, convQxDepartmentInfo.DepartmentId);
}
objvQxDepartmentInfoEN.DepartmentId = strDepartmentId; //部门Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxDepartmentInfoEN.dicFldComparisonOp.ContainsKey(convQxDepartmentInfo.DepartmentId) == false)
{
objvQxDepartmentInfoEN.dicFldComparisonOp.Add(convQxDepartmentInfo.DepartmentId, strComparisonOp);
}
else
{
objvQxDepartmentInfoEN.dicFldComparisonOp[convQxDepartmentInfo.DepartmentId] = strComparisonOp;
}
}
return objvQxDepartmentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxDepartmentInfoEN SetDepartmentName(this clsvQxDepartmentInfoEN objvQxDepartmentInfoEN, string strDepartmentName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentName, convQxDepartmentInfo.DepartmentName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentName, 100, convQxDepartmentInfo.DepartmentName);
}
objvQxDepartmentInfoEN.DepartmentName = strDepartmentName; //部门名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxDepartmentInfoEN.dicFldComparisonOp.ContainsKey(convQxDepartmentInfo.DepartmentName) == false)
{
objvQxDepartmentInfoEN.dicFldComparisonOp.Add(convQxDepartmentInfo.DepartmentName, strComparisonOp);
}
else
{
objvQxDepartmentInfoEN.dicFldComparisonOp[convQxDepartmentInfo.DepartmentName] = strComparisonOp;
}
}
return objvQxDepartmentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxDepartmentInfoEN SetDepartmentAbbrName(this clsvQxDepartmentInfoEN objvQxDepartmentInfoEN, string strDepartmentAbbrName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentAbbrName, 8, convQxDepartmentInfo.DepartmentAbbrName);
}
objvQxDepartmentInfoEN.DepartmentAbbrName = strDepartmentAbbrName; //名称缩写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxDepartmentInfoEN.dicFldComparisonOp.ContainsKey(convQxDepartmentInfo.DepartmentAbbrName) == false)
{
objvQxDepartmentInfoEN.dicFldComparisonOp.Add(convQxDepartmentInfo.DepartmentAbbrName, strComparisonOp);
}
else
{
objvQxDepartmentInfoEN.dicFldComparisonOp[convQxDepartmentInfo.DepartmentAbbrName] = strComparisonOp;
}
}
return objvQxDepartmentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxDepartmentInfoEN SetDepartmentTypeId(this clsvQxDepartmentInfoEN objvQxDepartmentInfoEN, string strDepartmentTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentTypeId, convQxDepartmentInfo.DepartmentTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentTypeId, 2, convQxDepartmentInfo.DepartmentTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDepartmentTypeId, 2, convQxDepartmentInfo.DepartmentTypeId);
}
objvQxDepartmentInfoEN.DepartmentTypeId = strDepartmentTypeId; //部门类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxDepartmentInfoEN.dicFldComparisonOp.ContainsKey(convQxDepartmentInfo.DepartmentTypeId) == false)
{
objvQxDepartmentInfoEN.dicFldComparisonOp.Add(convQxDepartmentInfo.DepartmentTypeId, strComparisonOp);
}
else
{
objvQxDepartmentInfoEN.dicFldComparisonOp[convQxDepartmentInfo.DepartmentTypeId] = strComparisonOp;
}
}
return objvQxDepartmentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxDepartmentInfoEN SetDepartmentTypeName(this clsvQxDepartmentInfoEN objvQxDepartmentInfoEN, string strDepartmentTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentTypeName, 50, convQxDepartmentInfo.DepartmentTypeName);
}
objvQxDepartmentInfoEN.DepartmentTypeName = strDepartmentTypeName; //部门类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxDepartmentInfoEN.dicFldComparisonOp.ContainsKey(convQxDepartmentInfo.DepartmentTypeName) == false)
{
objvQxDepartmentInfoEN.dicFldComparisonOp.Add(convQxDepartmentInfo.DepartmentTypeName, strComparisonOp);
}
else
{
objvQxDepartmentInfoEN.dicFldComparisonOp[convQxDepartmentInfo.DepartmentTypeName] = strComparisonOp;
}
}
return objvQxDepartmentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxDepartmentInfoEN SetUpDepartmentId(this clsvQxDepartmentInfoEN objvQxDepartmentInfoEN, string strUpDepartmentId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpDepartmentId, 6, convQxDepartmentInfo.UpDepartmentId);
}
objvQxDepartmentInfoEN.UpDepartmentId = strUpDepartmentId; //所属部门号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxDepartmentInfoEN.dicFldComparisonOp.ContainsKey(convQxDepartmentInfo.UpDepartmentId) == false)
{
objvQxDepartmentInfoEN.dicFldComparisonOp.Add(convQxDepartmentInfo.UpDepartmentId, strComparisonOp);
}
else
{
objvQxDepartmentInfoEN.dicFldComparisonOp[convQxDepartmentInfo.UpDepartmentId] = strComparisonOp;
}
}
return objvQxDepartmentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxDepartmentInfoEN SetOrderNum(this clsvQxDepartmentInfoEN objvQxDepartmentInfoEN, int? intOrderNum, string strComparisonOp="")
	{
objvQxDepartmentInfoEN.OrderNum = intOrderNum; //排序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxDepartmentInfoEN.dicFldComparisonOp.ContainsKey(convQxDepartmentInfo.OrderNum) == false)
{
objvQxDepartmentInfoEN.dicFldComparisonOp.Add(convQxDepartmentInfo.OrderNum, strComparisonOp);
}
else
{
objvQxDepartmentInfoEN.dicFldComparisonOp[convQxDepartmentInfo.OrderNum] = strComparisonOp;
}
}
return objvQxDepartmentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxDepartmentInfoEN SetInUse(this clsvQxDepartmentInfoEN objvQxDepartmentInfoEN, bool bolInUse, string strComparisonOp="")
	{
objvQxDepartmentInfoEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxDepartmentInfoEN.dicFldComparisonOp.ContainsKey(convQxDepartmentInfo.InUse) == false)
{
objvQxDepartmentInfoEN.dicFldComparisonOp.Add(convQxDepartmentInfo.InUse, strComparisonOp);
}
else
{
objvQxDepartmentInfoEN.dicFldComparisonOp[convQxDepartmentInfo.InUse] = strComparisonOp;
}
}
return objvQxDepartmentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxDepartmentInfoEN SetMemo(this clsvQxDepartmentInfoEN objvQxDepartmentInfoEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxDepartmentInfo.Memo);
}
objvQxDepartmentInfoEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxDepartmentInfoEN.dicFldComparisonOp.ContainsKey(convQxDepartmentInfo.Memo) == false)
{
objvQxDepartmentInfoEN.dicFldComparisonOp.Add(convQxDepartmentInfo.Memo, strComparisonOp);
}
else
{
objvQxDepartmentInfoEN.dicFldComparisonOp[convQxDepartmentInfo.Memo] = strComparisonOp;
}
}
return objvQxDepartmentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxDepartmentInfoEN SetUserNum(this clsvQxDepartmentInfoEN objvQxDepartmentInfoEN, int? intUserNum, string strComparisonOp="")
	{
objvQxDepartmentInfoEN.UserNum = intUserNum; //用户数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxDepartmentInfoEN.dicFldComparisonOp.ContainsKey(convQxDepartmentInfo.UserNum) == false)
{
objvQxDepartmentInfoEN.dicFldComparisonOp.Add(convQxDepartmentInfo.UserNum, strComparisonOp);
}
else
{
objvQxDepartmentInfoEN.dicFldComparisonOp[convQxDepartmentInfo.UserNum] = strComparisonOp;
}
}
return objvQxDepartmentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxDepartmentInfoEN SetUpDepartmentName(this clsvQxDepartmentInfoEN objvQxDepartmentInfoEN, string strUpDepartmentName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpDepartmentName, 100, convQxDepartmentInfo.UpDepartmentName);
}
objvQxDepartmentInfoEN.UpDepartmentName = strUpDepartmentName; //上级部门
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxDepartmentInfoEN.dicFldComparisonOp.ContainsKey(convQxDepartmentInfo.UpDepartmentName) == false)
{
objvQxDepartmentInfoEN.dicFldComparisonOp.Add(convQxDepartmentInfo.UpDepartmentName, strComparisonOp);
}
else
{
objvQxDepartmentInfoEN.dicFldComparisonOp[convQxDepartmentInfo.UpDepartmentName] = strComparisonOp;
}
}
return objvQxDepartmentInfoEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoENS">源对象</param>
 /// <param name = "objvQxDepartmentInfoENT">目标对象</param>
 public static void CopyTo(this clsvQxDepartmentInfoEN objvQxDepartmentInfoENS, clsvQxDepartmentInfoEN objvQxDepartmentInfoENT)
{
try
{
objvQxDepartmentInfoENT.DepartmentId = objvQxDepartmentInfoENS.DepartmentId; //部门Id
objvQxDepartmentInfoENT.DepartmentName = objvQxDepartmentInfoENS.DepartmentName; //部门名
objvQxDepartmentInfoENT.DepartmentAbbrName = objvQxDepartmentInfoENS.DepartmentAbbrName; //名称缩写
objvQxDepartmentInfoENT.DepartmentTypeId = objvQxDepartmentInfoENS.DepartmentTypeId; //部门类型ID
objvQxDepartmentInfoENT.DepartmentTypeName = objvQxDepartmentInfoENS.DepartmentTypeName; //部门类型名
objvQxDepartmentInfoENT.UpDepartmentId = objvQxDepartmentInfoENS.UpDepartmentId; //所属部门号
objvQxDepartmentInfoENT.OrderNum = objvQxDepartmentInfoENS.OrderNum; //排序号
objvQxDepartmentInfoENT.InUse = objvQxDepartmentInfoENS.InUse; //是否在用
objvQxDepartmentInfoENT.Memo = objvQxDepartmentInfoENS.Memo; //备注
objvQxDepartmentInfoENT.UserNum = objvQxDepartmentInfoENS.UserNum; //用户数
objvQxDepartmentInfoENT.UpDepartmentName = objvQxDepartmentInfoENS.UpDepartmentName; //上级部门
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
 /// <param name = "objvQxDepartmentInfoENS">源对象</param>
 /// <returns>目标对象=>clsvQxDepartmentInfoEN:objvQxDepartmentInfoENT</returns>
 public static clsvQxDepartmentInfoEN CopyTo(this clsvQxDepartmentInfoEN objvQxDepartmentInfoENS)
{
try
{
 clsvQxDepartmentInfoEN objvQxDepartmentInfoENT = new clsvQxDepartmentInfoEN()
{
DepartmentId = objvQxDepartmentInfoENS.DepartmentId, //部门Id
DepartmentName = objvQxDepartmentInfoENS.DepartmentName, //部门名
DepartmentAbbrName = objvQxDepartmentInfoENS.DepartmentAbbrName, //名称缩写
DepartmentTypeId = objvQxDepartmentInfoENS.DepartmentTypeId, //部门类型ID
DepartmentTypeName = objvQxDepartmentInfoENS.DepartmentTypeName, //部门类型名
UpDepartmentId = objvQxDepartmentInfoENS.UpDepartmentId, //所属部门号
OrderNum = objvQxDepartmentInfoENS.OrderNum, //排序号
InUse = objvQxDepartmentInfoENS.InUse, //是否在用
Memo = objvQxDepartmentInfoENS.Memo, //备注
UserNum = objvQxDepartmentInfoENS.UserNum, //用户数
UpDepartmentName = objvQxDepartmentInfoENS.UpDepartmentName, //上级部门
};
 return objvQxDepartmentInfoENT;
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
public static void CheckProperty4Condition(this clsvQxDepartmentInfoEN objvQxDepartmentInfoEN)
{
 clsvQxDepartmentInfoBL.vQxDepartmentInfoDA.CheckProperty4Condition(objvQxDepartmentInfoEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQxDepartmentInfoEN objvQxDepartmentInfoCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQxDepartmentInfoCond.IsUpdated(convQxDepartmentInfo.DepartmentId) == true)
{
string strComparisonOpDepartmentId = objvQxDepartmentInfoCond.dicFldComparisonOp[convQxDepartmentInfo.DepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxDepartmentInfo.DepartmentId, objvQxDepartmentInfoCond.DepartmentId, strComparisonOpDepartmentId);
}
if (objvQxDepartmentInfoCond.IsUpdated(convQxDepartmentInfo.DepartmentName) == true)
{
string strComparisonOpDepartmentName = objvQxDepartmentInfoCond.dicFldComparisonOp[convQxDepartmentInfo.DepartmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxDepartmentInfo.DepartmentName, objvQxDepartmentInfoCond.DepartmentName, strComparisonOpDepartmentName);
}
if (objvQxDepartmentInfoCond.IsUpdated(convQxDepartmentInfo.DepartmentAbbrName) == true)
{
string strComparisonOpDepartmentAbbrName = objvQxDepartmentInfoCond.dicFldComparisonOp[convQxDepartmentInfo.DepartmentAbbrName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxDepartmentInfo.DepartmentAbbrName, objvQxDepartmentInfoCond.DepartmentAbbrName, strComparisonOpDepartmentAbbrName);
}
if (objvQxDepartmentInfoCond.IsUpdated(convQxDepartmentInfo.DepartmentTypeId) == true)
{
string strComparisonOpDepartmentTypeId = objvQxDepartmentInfoCond.dicFldComparisonOp[convQxDepartmentInfo.DepartmentTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxDepartmentInfo.DepartmentTypeId, objvQxDepartmentInfoCond.DepartmentTypeId, strComparisonOpDepartmentTypeId);
}
if (objvQxDepartmentInfoCond.IsUpdated(convQxDepartmentInfo.DepartmentTypeName) == true)
{
string strComparisonOpDepartmentTypeName = objvQxDepartmentInfoCond.dicFldComparisonOp[convQxDepartmentInfo.DepartmentTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxDepartmentInfo.DepartmentTypeName, objvQxDepartmentInfoCond.DepartmentTypeName, strComparisonOpDepartmentTypeName);
}
if (objvQxDepartmentInfoCond.IsUpdated(convQxDepartmentInfo.UpDepartmentId) == true)
{
string strComparisonOpUpDepartmentId = objvQxDepartmentInfoCond.dicFldComparisonOp[convQxDepartmentInfo.UpDepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxDepartmentInfo.UpDepartmentId, objvQxDepartmentInfoCond.UpDepartmentId, strComparisonOpUpDepartmentId);
}
if (objvQxDepartmentInfoCond.IsUpdated(convQxDepartmentInfo.OrderNum) == true)
{
string strComparisonOpOrderNum = objvQxDepartmentInfoCond.dicFldComparisonOp[convQxDepartmentInfo.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQxDepartmentInfo.OrderNum, objvQxDepartmentInfoCond.OrderNum, strComparisonOpOrderNum);
}
if (objvQxDepartmentInfoCond.IsUpdated(convQxDepartmentInfo.InUse) == true)
{
if (objvQxDepartmentInfoCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQxDepartmentInfo.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQxDepartmentInfo.InUse);
}
}
if (objvQxDepartmentInfoCond.IsUpdated(convQxDepartmentInfo.Memo) == true)
{
string strComparisonOpMemo = objvQxDepartmentInfoCond.dicFldComparisonOp[convQxDepartmentInfo.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxDepartmentInfo.Memo, objvQxDepartmentInfoCond.Memo, strComparisonOpMemo);
}
if (objvQxDepartmentInfoCond.IsUpdated(convQxDepartmentInfo.UserNum) == true)
{
string strComparisonOpUserNum = objvQxDepartmentInfoCond.dicFldComparisonOp[convQxDepartmentInfo.UserNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQxDepartmentInfo.UserNum, objvQxDepartmentInfoCond.UserNum, strComparisonOpUserNum);
}
if (objvQxDepartmentInfoCond.IsUpdated(convQxDepartmentInfo.UpDepartmentName) == true)
{
string strComparisonOpUpDepartmentName = objvQxDepartmentInfoCond.dicFldComparisonOp[convQxDepartmentInfo.UpDepartmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxDepartmentInfo.UpDepartmentName, objvQxDepartmentInfoCond.UpDepartmentName, strComparisonOpUpDepartmentName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vQxDepartmentInfo
{
public virtual bool UpdRelaTabDate(string strDepartmentId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v部门(vQxDepartmentInfo)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvQxDepartmentInfoBL
{
public static RelatedActions_vQxDepartmentInfo relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "vQxDepartmentInfoListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "vQxDepartmentInfoList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsvQxDepartmentInfoEN> arrvQxDepartmentInfoObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvQxDepartmentInfoDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvQxDepartmentInfoDA vQxDepartmentInfoDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvQxDepartmentInfoDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvQxDepartmentInfoBL()
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
if (string.IsNullOrEmpty(clsvQxDepartmentInfoEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxDepartmentInfoEN._ConnectString);
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
objDS = vQxDepartmentInfoDA.GetDataSet(strWhereCond);
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
objDS = vQxDepartmentInfoDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = vQxDepartmentInfoDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_vQxDepartmentInfo(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQxDepartmentInfoDA.GetDataTable_vQxDepartmentInfo(strWhereCond);
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
objDT = vQxDepartmentInfoDA.GetDataTable(strWhereCond);
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
objDT = vQxDepartmentInfoDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vQxDepartmentInfoDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vQxDepartmentInfoDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vQxDepartmentInfoDA.GetDataTable_Top(objTopPara);
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
objDT = vQxDepartmentInfoDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vQxDepartmentInfoDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = vQxDepartmentInfoDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vQxDepartmentInfoDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = vQxDepartmentInfoDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = vQxDepartmentInfoDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = vQxDepartmentInfoDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = vQxDepartmentInfoDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
 /// <param name = "arrDepartmentIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvQxDepartmentInfoEN> GetObjLstByDepartmentIdLst(List<string> arrDepartmentIdLst)
{
List<clsvQxDepartmentInfoEN> arrObjLst = new List<clsvQxDepartmentInfoEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrDepartmentIdLst, true);
 string strWhereCond = string.Format("DepartmentId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxDepartmentInfoEN objvQxDepartmentInfoEN = new clsvQxDepartmentInfoEN();
try
{
objvQxDepartmentInfoEN.DepartmentId = objRow[convQxDepartmentInfo.DepartmentId].ToString().Trim(); //部门Id
objvQxDepartmentInfoEN.DepartmentName = objRow[convQxDepartmentInfo.DepartmentName].ToString().Trim(); //部门名
objvQxDepartmentInfoEN.DepartmentAbbrName = objRow[convQxDepartmentInfo.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxDepartmentInfo.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxDepartmentInfoEN.DepartmentTypeId = objRow[convQxDepartmentInfo.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxDepartmentInfoEN.DepartmentTypeName = objRow[convQxDepartmentInfo.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxDepartmentInfo.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxDepartmentInfoEN.UpDepartmentId = objRow[convQxDepartmentInfo.UpDepartmentId] == DBNull.Value ? null : objRow[convQxDepartmentInfo.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxDepartmentInfoEN.OrderNum = objRow[convQxDepartmentInfo.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxDepartmentInfo.OrderNum].ToString().Trim()); //排序号
objvQxDepartmentInfoEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxDepartmentInfo.InUse].ToString().Trim()); //是否在用
objvQxDepartmentInfoEN.Memo = objRow[convQxDepartmentInfo.Memo] == DBNull.Value ? null : objRow[convQxDepartmentInfo.Memo].ToString().Trim(); //备注
objvQxDepartmentInfoEN.UserNum = objRow[convQxDepartmentInfo.UserNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxDepartmentInfo.UserNum].ToString().Trim()); //用户数
objvQxDepartmentInfoEN.UpDepartmentName = objRow[convQxDepartmentInfo.UpDepartmentName] == DBNull.Value ? null : objRow[convQxDepartmentInfo.UpDepartmentName].ToString().Trim(); //上级部门
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxDepartmentInfoEN.DepartmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxDepartmentInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrDepartmentIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvQxDepartmentInfoEN> GetObjLstByDepartmentIdLstCache(List<string> arrDepartmentIdLst)
{
string strKey = string.Format("{0}", clsvQxDepartmentInfoEN._CurrTabName);
List<clsvQxDepartmentInfoEN> arrvQxDepartmentInfoObjLstCache = GetObjLstCache();
IEnumerable <clsvQxDepartmentInfoEN> arrvQxDepartmentInfoObjLst_Sel =
arrvQxDepartmentInfoObjLstCache
.Where(x => arrDepartmentIdLst.Contains(x.DepartmentId));
return arrvQxDepartmentInfoObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxDepartmentInfoEN> GetObjLst(string strWhereCond)
{
List<clsvQxDepartmentInfoEN> arrObjLst = new List<clsvQxDepartmentInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxDepartmentInfoEN objvQxDepartmentInfoEN = new clsvQxDepartmentInfoEN();
try
{
objvQxDepartmentInfoEN.DepartmentId = objRow[convQxDepartmentInfo.DepartmentId].ToString().Trim(); //部门Id
objvQxDepartmentInfoEN.DepartmentName = objRow[convQxDepartmentInfo.DepartmentName].ToString().Trim(); //部门名
objvQxDepartmentInfoEN.DepartmentAbbrName = objRow[convQxDepartmentInfo.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxDepartmentInfo.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxDepartmentInfoEN.DepartmentTypeId = objRow[convQxDepartmentInfo.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxDepartmentInfoEN.DepartmentTypeName = objRow[convQxDepartmentInfo.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxDepartmentInfo.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxDepartmentInfoEN.UpDepartmentId = objRow[convQxDepartmentInfo.UpDepartmentId] == DBNull.Value ? null : objRow[convQxDepartmentInfo.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxDepartmentInfoEN.OrderNum = objRow[convQxDepartmentInfo.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxDepartmentInfo.OrderNum].ToString().Trim()); //排序号
objvQxDepartmentInfoEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxDepartmentInfo.InUse].ToString().Trim()); //是否在用
objvQxDepartmentInfoEN.Memo = objRow[convQxDepartmentInfo.Memo] == DBNull.Value ? null : objRow[convQxDepartmentInfo.Memo].ToString().Trim(); //备注
objvQxDepartmentInfoEN.UserNum = objRow[convQxDepartmentInfo.UserNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxDepartmentInfo.UserNum].ToString().Trim()); //用户数
objvQxDepartmentInfoEN.UpDepartmentName = objRow[convQxDepartmentInfo.UpDepartmentName] == DBNull.Value ? null : objRow[convQxDepartmentInfo.UpDepartmentName].ToString().Trim(); //上级部门
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxDepartmentInfoEN.DepartmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxDepartmentInfoEN);
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
public static List<clsvQxDepartmentInfoEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQxDepartmentInfoEN> arrObjLst = new List<clsvQxDepartmentInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxDepartmentInfoEN objvQxDepartmentInfoEN = new clsvQxDepartmentInfoEN();
try
{
objvQxDepartmentInfoEN.DepartmentId = objRow[convQxDepartmentInfo.DepartmentId].ToString().Trim(); //部门Id
objvQxDepartmentInfoEN.DepartmentName = objRow[convQxDepartmentInfo.DepartmentName].ToString().Trim(); //部门名
objvQxDepartmentInfoEN.DepartmentAbbrName = objRow[convQxDepartmentInfo.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxDepartmentInfo.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxDepartmentInfoEN.DepartmentTypeId = objRow[convQxDepartmentInfo.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxDepartmentInfoEN.DepartmentTypeName = objRow[convQxDepartmentInfo.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxDepartmentInfo.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxDepartmentInfoEN.UpDepartmentId = objRow[convQxDepartmentInfo.UpDepartmentId] == DBNull.Value ? null : objRow[convQxDepartmentInfo.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxDepartmentInfoEN.OrderNum = objRow[convQxDepartmentInfo.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxDepartmentInfo.OrderNum].ToString().Trim()); //排序号
objvQxDepartmentInfoEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxDepartmentInfo.InUse].ToString().Trim()); //是否在用
objvQxDepartmentInfoEN.Memo = objRow[convQxDepartmentInfo.Memo] == DBNull.Value ? null : objRow[convQxDepartmentInfo.Memo].ToString().Trim(); //备注
objvQxDepartmentInfoEN.UserNum = objRow[convQxDepartmentInfo.UserNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxDepartmentInfo.UserNum].ToString().Trim()); //用户数
objvQxDepartmentInfoEN.UpDepartmentName = objRow[convQxDepartmentInfo.UpDepartmentName] == DBNull.Value ? null : objRow[convQxDepartmentInfo.UpDepartmentName].ToString().Trim(); //上级部门
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxDepartmentInfoEN.DepartmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxDepartmentInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvQxDepartmentInfoEN> GetSubObjLstCache(clsvQxDepartmentInfoEN objvQxDepartmentInfoCond)
{
List<clsvQxDepartmentInfoEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxDepartmentInfoEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxDepartmentInfo.AttributeName)
{
if (objvQxDepartmentInfoCond.IsUpdated(strFldName) == false) continue;
if (objvQxDepartmentInfoCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxDepartmentInfoCond[strFldName].ToString());
}
else
{
if (objvQxDepartmentInfoCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxDepartmentInfoCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxDepartmentInfoCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxDepartmentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxDepartmentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxDepartmentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxDepartmentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxDepartmentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxDepartmentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxDepartmentInfoCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxDepartmentInfoCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxDepartmentInfoCond[strFldName]));
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
public static List<clsvQxDepartmentInfoEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvQxDepartmentInfoEN> arrObjLst = new List<clsvQxDepartmentInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxDepartmentInfoEN objvQxDepartmentInfoEN = new clsvQxDepartmentInfoEN();
try
{
objvQxDepartmentInfoEN.DepartmentId = objRow[convQxDepartmentInfo.DepartmentId].ToString().Trim(); //部门Id
objvQxDepartmentInfoEN.DepartmentName = objRow[convQxDepartmentInfo.DepartmentName].ToString().Trim(); //部门名
objvQxDepartmentInfoEN.DepartmentAbbrName = objRow[convQxDepartmentInfo.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxDepartmentInfo.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxDepartmentInfoEN.DepartmentTypeId = objRow[convQxDepartmentInfo.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxDepartmentInfoEN.DepartmentTypeName = objRow[convQxDepartmentInfo.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxDepartmentInfo.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxDepartmentInfoEN.UpDepartmentId = objRow[convQxDepartmentInfo.UpDepartmentId] == DBNull.Value ? null : objRow[convQxDepartmentInfo.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxDepartmentInfoEN.OrderNum = objRow[convQxDepartmentInfo.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxDepartmentInfo.OrderNum].ToString().Trim()); //排序号
objvQxDepartmentInfoEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxDepartmentInfo.InUse].ToString().Trim()); //是否在用
objvQxDepartmentInfoEN.Memo = objRow[convQxDepartmentInfo.Memo] == DBNull.Value ? null : objRow[convQxDepartmentInfo.Memo].ToString().Trim(); //备注
objvQxDepartmentInfoEN.UserNum = objRow[convQxDepartmentInfo.UserNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxDepartmentInfo.UserNum].ToString().Trim()); //用户数
objvQxDepartmentInfoEN.UpDepartmentName = objRow[convQxDepartmentInfo.UpDepartmentName] == DBNull.Value ? null : objRow[convQxDepartmentInfo.UpDepartmentName].ToString().Trim(); //上级部门
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxDepartmentInfoEN.DepartmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxDepartmentInfoEN);
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
public static List<clsvQxDepartmentInfoEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvQxDepartmentInfoEN> arrObjLst = new List<clsvQxDepartmentInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxDepartmentInfoEN objvQxDepartmentInfoEN = new clsvQxDepartmentInfoEN();
try
{
objvQxDepartmentInfoEN.DepartmentId = objRow[convQxDepartmentInfo.DepartmentId].ToString().Trim(); //部门Id
objvQxDepartmentInfoEN.DepartmentName = objRow[convQxDepartmentInfo.DepartmentName].ToString().Trim(); //部门名
objvQxDepartmentInfoEN.DepartmentAbbrName = objRow[convQxDepartmentInfo.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxDepartmentInfo.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxDepartmentInfoEN.DepartmentTypeId = objRow[convQxDepartmentInfo.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxDepartmentInfoEN.DepartmentTypeName = objRow[convQxDepartmentInfo.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxDepartmentInfo.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxDepartmentInfoEN.UpDepartmentId = objRow[convQxDepartmentInfo.UpDepartmentId] == DBNull.Value ? null : objRow[convQxDepartmentInfo.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxDepartmentInfoEN.OrderNum = objRow[convQxDepartmentInfo.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxDepartmentInfo.OrderNum].ToString().Trim()); //排序号
objvQxDepartmentInfoEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxDepartmentInfo.InUse].ToString().Trim()); //是否在用
objvQxDepartmentInfoEN.Memo = objRow[convQxDepartmentInfo.Memo] == DBNull.Value ? null : objRow[convQxDepartmentInfo.Memo].ToString().Trim(); //备注
objvQxDepartmentInfoEN.UserNum = objRow[convQxDepartmentInfo.UserNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxDepartmentInfo.UserNum].ToString().Trim()); //用户数
objvQxDepartmentInfoEN.UpDepartmentName = objRow[convQxDepartmentInfo.UpDepartmentName] == DBNull.Value ? null : objRow[convQxDepartmentInfo.UpDepartmentName].ToString().Trim(); //上级部门
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxDepartmentInfoEN.DepartmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxDepartmentInfoEN);
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
List<clsvQxDepartmentInfoEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvQxDepartmentInfoEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxDepartmentInfoEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvQxDepartmentInfoEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvQxDepartmentInfoEN> arrObjLst = new List<clsvQxDepartmentInfoEN>(); 
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
	clsvQxDepartmentInfoEN objvQxDepartmentInfoEN = new clsvQxDepartmentInfoEN();
try
{
objvQxDepartmentInfoEN.DepartmentId = objRow[convQxDepartmentInfo.DepartmentId].ToString().Trim(); //部门Id
objvQxDepartmentInfoEN.DepartmentName = objRow[convQxDepartmentInfo.DepartmentName].ToString().Trim(); //部门名
objvQxDepartmentInfoEN.DepartmentAbbrName = objRow[convQxDepartmentInfo.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxDepartmentInfo.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxDepartmentInfoEN.DepartmentTypeId = objRow[convQxDepartmentInfo.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxDepartmentInfoEN.DepartmentTypeName = objRow[convQxDepartmentInfo.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxDepartmentInfo.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxDepartmentInfoEN.UpDepartmentId = objRow[convQxDepartmentInfo.UpDepartmentId] == DBNull.Value ? null : objRow[convQxDepartmentInfo.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxDepartmentInfoEN.OrderNum = objRow[convQxDepartmentInfo.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxDepartmentInfo.OrderNum].ToString().Trim()); //排序号
objvQxDepartmentInfoEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxDepartmentInfo.InUse].ToString().Trim()); //是否在用
objvQxDepartmentInfoEN.Memo = objRow[convQxDepartmentInfo.Memo] == DBNull.Value ? null : objRow[convQxDepartmentInfo.Memo].ToString().Trim(); //备注
objvQxDepartmentInfoEN.UserNum = objRow[convQxDepartmentInfo.UserNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxDepartmentInfo.UserNum].ToString().Trim()); //用户数
objvQxDepartmentInfoEN.UpDepartmentName = objRow[convQxDepartmentInfo.UpDepartmentName] == DBNull.Value ? null : objRow[convQxDepartmentInfo.UpDepartmentName].ToString().Trim(); //上级部门
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxDepartmentInfoEN.DepartmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxDepartmentInfoEN);
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
public static List<clsvQxDepartmentInfoEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvQxDepartmentInfoEN> arrObjLst = new List<clsvQxDepartmentInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxDepartmentInfoEN objvQxDepartmentInfoEN = new clsvQxDepartmentInfoEN();
try
{
objvQxDepartmentInfoEN.DepartmentId = objRow[convQxDepartmentInfo.DepartmentId].ToString().Trim(); //部门Id
objvQxDepartmentInfoEN.DepartmentName = objRow[convQxDepartmentInfo.DepartmentName].ToString().Trim(); //部门名
objvQxDepartmentInfoEN.DepartmentAbbrName = objRow[convQxDepartmentInfo.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxDepartmentInfo.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxDepartmentInfoEN.DepartmentTypeId = objRow[convQxDepartmentInfo.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxDepartmentInfoEN.DepartmentTypeName = objRow[convQxDepartmentInfo.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxDepartmentInfo.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxDepartmentInfoEN.UpDepartmentId = objRow[convQxDepartmentInfo.UpDepartmentId] == DBNull.Value ? null : objRow[convQxDepartmentInfo.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxDepartmentInfoEN.OrderNum = objRow[convQxDepartmentInfo.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxDepartmentInfo.OrderNum].ToString().Trim()); //排序号
objvQxDepartmentInfoEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxDepartmentInfo.InUse].ToString().Trim()); //是否在用
objvQxDepartmentInfoEN.Memo = objRow[convQxDepartmentInfo.Memo] == DBNull.Value ? null : objRow[convQxDepartmentInfo.Memo].ToString().Trim(); //备注
objvQxDepartmentInfoEN.UserNum = objRow[convQxDepartmentInfo.UserNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxDepartmentInfo.UserNum].ToString().Trim()); //用户数
objvQxDepartmentInfoEN.UpDepartmentName = objRow[convQxDepartmentInfo.UpDepartmentName] == DBNull.Value ? null : objRow[convQxDepartmentInfo.UpDepartmentName].ToString().Trim(); //上级部门
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxDepartmentInfoEN.DepartmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxDepartmentInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQxDepartmentInfoEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvQxDepartmentInfoEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvQxDepartmentInfoEN> arrObjLst = new List<clsvQxDepartmentInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxDepartmentInfoEN objvQxDepartmentInfoEN = new clsvQxDepartmentInfoEN();
try
{
objvQxDepartmentInfoEN.DepartmentId = objRow[convQxDepartmentInfo.DepartmentId].ToString().Trim(); //部门Id
objvQxDepartmentInfoEN.DepartmentName = objRow[convQxDepartmentInfo.DepartmentName].ToString().Trim(); //部门名
objvQxDepartmentInfoEN.DepartmentAbbrName = objRow[convQxDepartmentInfo.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxDepartmentInfo.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxDepartmentInfoEN.DepartmentTypeId = objRow[convQxDepartmentInfo.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxDepartmentInfoEN.DepartmentTypeName = objRow[convQxDepartmentInfo.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxDepartmentInfo.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxDepartmentInfoEN.UpDepartmentId = objRow[convQxDepartmentInfo.UpDepartmentId] == DBNull.Value ? null : objRow[convQxDepartmentInfo.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxDepartmentInfoEN.OrderNum = objRow[convQxDepartmentInfo.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxDepartmentInfo.OrderNum].ToString().Trim()); //排序号
objvQxDepartmentInfoEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxDepartmentInfo.InUse].ToString().Trim()); //是否在用
objvQxDepartmentInfoEN.Memo = objRow[convQxDepartmentInfo.Memo] == DBNull.Value ? null : objRow[convQxDepartmentInfo.Memo].ToString().Trim(); //备注
objvQxDepartmentInfoEN.UserNum = objRow[convQxDepartmentInfo.UserNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxDepartmentInfo.UserNum].ToString().Trim()); //用户数
objvQxDepartmentInfoEN.UpDepartmentName = objRow[convQxDepartmentInfo.UpDepartmentName] == DBNull.Value ? null : objRow[convQxDepartmentInfo.UpDepartmentName].ToString().Trim(); //上级部门
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxDepartmentInfoEN.DepartmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxDepartmentInfoEN);
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
public static List<clsvQxDepartmentInfoEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvQxDepartmentInfoEN> arrObjLst = new List<clsvQxDepartmentInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxDepartmentInfoEN objvQxDepartmentInfoEN = new clsvQxDepartmentInfoEN();
try
{
objvQxDepartmentInfoEN.DepartmentId = objRow[convQxDepartmentInfo.DepartmentId].ToString().Trim(); //部门Id
objvQxDepartmentInfoEN.DepartmentName = objRow[convQxDepartmentInfo.DepartmentName].ToString().Trim(); //部门名
objvQxDepartmentInfoEN.DepartmentAbbrName = objRow[convQxDepartmentInfo.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxDepartmentInfo.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxDepartmentInfoEN.DepartmentTypeId = objRow[convQxDepartmentInfo.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxDepartmentInfoEN.DepartmentTypeName = objRow[convQxDepartmentInfo.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxDepartmentInfo.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxDepartmentInfoEN.UpDepartmentId = objRow[convQxDepartmentInfo.UpDepartmentId] == DBNull.Value ? null : objRow[convQxDepartmentInfo.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxDepartmentInfoEN.OrderNum = objRow[convQxDepartmentInfo.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxDepartmentInfo.OrderNum].ToString().Trim()); //排序号
objvQxDepartmentInfoEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxDepartmentInfo.InUse].ToString().Trim()); //是否在用
objvQxDepartmentInfoEN.Memo = objRow[convQxDepartmentInfo.Memo] == DBNull.Value ? null : objRow[convQxDepartmentInfo.Memo].ToString().Trim(); //备注
objvQxDepartmentInfoEN.UserNum = objRow[convQxDepartmentInfo.UserNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxDepartmentInfo.UserNum].ToString().Trim()); //用户数
objvQxDepartmentInfoEN.UpDepartmentName = objRow[convQxDepartmentInfo.UpDepartmentName] == DBNull.Value ? null : objRow[convQxDepartmentInfo.UpDepartmentName].ToString().Trim(); //上级部门
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxDepartmentInfoEN.DepartmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxDepartmentInfoEN);
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
public static IEnumerable<clsvQxDepartmentInfoEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsvQxDepartmentInfoEN objvQxDepartmentInfoCond, string strOrderBy)
{
List<clsvQxDepartmentInfoEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxDepartmentInfoEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxDepartmentInfo.AttributeName)
{
if (objvQxDepartmentInfoCond.IsUpdated(strFldName) == false) continue;
if (objvQxDepartmentInfoCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxDepartmentInfoCond[strFldName].ToString());
}
else
{
if (objvQxDepartmentInfoCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxDepartmentInfoCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxDepartmentInfoCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxDepartmentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxDepartmentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxDepartmentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxDepartmentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxDepartmentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxDepartmentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxDepartmentInfoCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxDepartmentInfoCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxDepartmentInfoCond[strFldName]));
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
public static IEnumerable<clsvQxDepartmentInfoEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsvQxDepartmentInfoEN objvQxDepartmentInfoCond = JsonConvert.DeserializeObject<clsvQxDepartmentInfoEN>(objPagerPara.whereCond);
if (objvQxDepartmentInfoCond.sfFldComparisonOp == null)
{
objvQxDepartmentInfoCond.dicFldComparisonOp = null;
}
else
{
objvQxDepartmentInfoCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objvQxDepartmentInfoCond.sfFldComparisonOp);
}
clsvQxDepartmentInfoBL.SetUpdFlag(objvQxDepartmentInfoCond);
 try
{
CheckProperty4Condition(objvQxDepartmentInfoCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsvQxDepartmentInfoBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objvQxDepartmentInfoCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxDepartmentInfoEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsvQxDepartmentInfoEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxDepartmentInfoEN> arrObjLst = new List<clsvQxDepartmentInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxDepartmentInfoEN objvQxDepartmentInfoEN = new clsvQxDepartmentInfoEN();
try
{
objvQxDepartmentInfoEN.DepartmentId = objRow[convQxDepartmentInfo.DepartmentId].ToString().Trim(); //部门Id
objvQxDepartmentInfoEN.DepartmentName = objRow[convQxDepartmentInfo.DepartmentName].ToString().Trim(); //部门名
objvQxDepartmentInfoEN.DepartmentAbbrName = objRow[convQxDepartmentInfo.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxDepartmentInfo.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxDepartmentInfoEN.DepartmentTypeId = objRow[convQxDepartmentInfo.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxDepartmentInfoEN.DepartmentTypeName = objRow[convQxDepartmentInfo.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxDepartmentInfo.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxDepartmentInfoEN.UpDepartmentId = objRow[convQxDepartmentInfo.UpDepartmentId] == DBNull.Value ? null : objRow[convQxDepartmentInfo.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxDepartmentInfoEN.OrderNum = objRow[convQxDepartmentInfo.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxDepartmentInfo.OrderNum].ToString().Trim()); //排序号
objvQxDepartmentInfoEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxDepartmentInfo.InUse].ToString().Trim()); //是否在用
objvQxDepartmentInfoEN.Memo = objRow[convQxDepartmentInfo.Memo] == DBNull.Value ? null : objRow[convQxDepartmentInfo.Memo].ToString().Trim(); //备注
objvQxDepartmentInfoEN.UserNum = objRow[convQxDepartmentInfo.UserNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxDepartmentInfo.UserNum].ToString().Trim()); //用户数
objvQxDepartmentInfoEN.UpDepartmentName = objRow[convQxDepartmentInfo.UpDepartmentName] == DBNull.Value ? null : objRow[convQxDepartmentInfo.UpDepartmentName].ToString().Trim(); //上级部门
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxDepartmentInfoEN.DepartmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxDepartmentInfoEN);
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
public static List<clsvQxDepartmentInfoEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxDepartmentInfoEN> arrObjLst = new List<clsvQxDepartmentInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxDepartmentInfoEN objvQxDepartmentInfoEN = new clsvQxDepartmentInfoEN();
try
{
objvQxDepartmentInfoEN.DepartmentId = objRow[convQxDepartmentInfo.DepartmentId].ToString().Trim(); //部门Id
objvQxDepartmentInfoEN.DepartmentName = objRow[convQxDepartmentInfo.DepartmentName].ToString().Trim(); //部门名
objvQxDepartmentInfoEN.DepartmentAbbrName = objRow[convQxDepartmentInfo.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxDepartmentInfo.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxDepartmentInfoEN.DepartmentTypeId = objRow[convQxDepartmentInfo.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxDepartmentInfoEN.DepartmentTypeName = objRow[convQxDepartmentInfo.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxDepartmentInfo.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxDepartmentInfoEN.UpDepartmentId = objRow[convQxDepartmentInfo.UpDepartmentId] == DBNull.Value ? null : objRow[convQxDepartmentInfo.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxDepartmentInfoEN.OrderNum = objRow[convQxDepartmentInfo.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxDepartmentInfo.OrderNum].ToString().Trim()); //排序号
objvQxDepartmentInfoEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxDepartmentInfo.InUse].ToString().Trim()); //是否在用
objvQxDepartmentInfoEN.Memo = objRow[convQxDepartmentInfo.Memo] == DBNull.Value ? null : objRow[convQxDepartmentInfo.Memo].ToString().Trim(); //备注
objvQxDepartmentInfoEN.UserNum = objRow[convQxDepartmentInfo.UserNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxDepartmentInfo.UserNum].ToString().Trim()); //用户数
objvQxDepartmentInfoEN.UpDepartmentName = objRow[convQxDepartmentInfo.UpDepartmentName] == DBNull.Value ? null : objRow[convQxDepartmentInfo.UpDepartmentName].ToString().Trim(); //上级部门
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxDepartmentInfoEN.DepartmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxDepartmentInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxDepartmentInfoEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvQxDepartmentInfoEN> arrObjLst = new List<clsvQxDepartmentInfoEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxDepartmentInfoEN objvQxDepartmentInfoEN = new clsvQxDepartmentInfoEN();
try
{
objvQxDepartmentInfoEN.DepartmentId = objRow[convQxDepartmentInfo.DepartmentId].ToString().Trim(); //部门Id
objvQxDepartmentInfoEN.DepartmentName = objRow[convQxDepartmentInfo.DepartmentName].ToString().Trim(); //部门名
objvQxDepartmentInfoEN.DepartmentAbbrName = objRow[convQxDepartmentInfo.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxDepartmentInfo.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxDepartmentInfoEN.DepartmentTypeId = objRow[convQxDepartmentInfo.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxDepartmentInfoEN.DepartmentTypeName = objRow[convQxDepartmentInfo.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxDepartmentInfo.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxDepartmentInfoEN.UpDepartmentId = objRow[convQxDepartmentInfo.UpDepartmentId] == DBNull.Value ? null : objRow[convQxDepartmentInfo.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxDepartmentInfoEN.OrderNum = objRow[convQxDepartmentInfo.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxDepartmentInfo.OrderNum].ToString().Trim()); //排序号
objvQxDepartmentInfoEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxDepartmentInfo.InUse].ToString().Trim()); //是否在用
objvQxDepartmentInfoEN.Memo = objRow[convQxDepartmentInfo.Memo] == DBNull.Value ? null : objRow[convQxDepartmentInfo.Memo].ToString().Trim(); //备注
objvQxDepartmentInfoEN.UserNum = objRow[convQxDepartmentInfo.UserNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxDepartmentInfo.UserNum].ToString().Trim()); //用户数
objvQxDepartmentInfoEN.UpDepartmentName = objRow[convQxDepartmentInfo.UpDepartmentName] == DBNull.Value ? null : objRow[convQxDepartmentInfo.UpDepartmentName].ToString().Trim(); //上级部门
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxDepartmentInfoEN.DepartmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxDepartmentInfoEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxDepartmentInfo(ref clsvQxDepartmentInfoEN objvQxDepartmentInfoEN)
{
bool bolResult = vQxDepartmentInfoDA.GetvQxDepartmentInfo(ref objvQxDepartmentInfoEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strDepartmentId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxDepartmentInfoEN GetObjByDepartmentId(string strDepartmentId)
{
if (strDepartmentId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strDepartmentId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strDepartmentId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strDepartmentId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvQxDepartmentInfoEN objvQxDepartmentInfoEN = vQxDepartmentInfoDA.GetObjByDepartmentId(strDepartmentId);
return objvQxDepartmentInfoEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvQxDepartmentInfoEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvQxDepartmentInfoEN objvQxDepartmentInfoEN = vQxDepartmentInfoDA.GetFirstObj(strWhereCond);
 return objvQxDepartmentInfoEN;
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
public static clsvQxDepartmentInfoEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvQxDepartmentInfoEN objvQxDepartmentInfoEN = vQxDepartmentInfoDA.GetObjByDataRow(objRow);
 return objvQxDepartmentInfoEN;
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
public static clsvQxDepartmentInfoEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvQxDepartmentInfoEN objvQxDepartmentInfoEN = vQxDepartmentInfoDA.GetObjByDataRow(objRow);
 return objvQxDepartmentInfoEN;
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
 /// <param name = "strDepartmentId">所给的关键字</param>
 /// <param name = "lstvQxDepartmentInfoObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxDepartmentInfoEN GetObjByDepartmentIdFromList(string strDepartmentId, List<clsvQxDepartmentInfoEN> lstvQxDepartmentInfoObjLst)
{
foreach (clsvQxDepartmentInfoEN objvQxDepartmentInfoEN in lstvQxDepartmentInfoObjLst)
{
if (objvQxDepartmentInfoEN.DepartmentId == strDepartmentId)
{
return objvQxDepartmentInfoEN;
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
 string strDepartmentId;
 try
 {
 strDepartmentId = new clsvQxDepartmentInfoDA().GetFirstID(strWhereCond);
 return strDepartmentId;
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
 arrList = vQxDepartmentInfoDA.GetID(strWhereCond);
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
bool bolIsExist = vQxDepartmentInfoDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strDepartmentId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strDepartmentId)
{
if (string.IsNullOrEmpty(strDepartmentId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strDepartmentId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vQxDepartmentInfoDA.IsExist(strDepartmentId);
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
 bolIsExist = clsvQxDepartmentInfoDA.IsExistTable();
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
 bolIsExist = vQxDepartmentInfoDA.IsExistTable(strTabName);
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
 /// <param name = "objvQxDepartmentInfoENS">源对象</param>
 /// <param name = "objvQxDepartmentInfoENT">目标对象</param>
 public static void CopyTo(clsvQxDepartmentInfoEN objvQxDepartmentInfoENS, clsvQxDepartmentInfoEN objvQxDepartmentInfoENT)
{
try
{
objvQxDepartmentInfoENT.DepartmentId = objvQxDepartmentInfoENS.DepartmentId; //部门Id
objvQxDepartmentInfoENT.DepartmentName = objvQxDepartmentInfoENS.DepartmentName; //部门名
objvQxDepartmentInfoENT.DepartmentAbbrName = objvQxDepartmentInfoENS.DepartmentAbbrName; //名称缩写
objvQxDepartmentInfoENT.DepartmentTypeId = objvQxDepartmentInfoENS.DepartmentTypeId; //部门类型ID
objvQxDepartmentInfoENT.DepartmentTypeName = objvQxDepartmentInfoENS.DepartmentTypeName; //部门类型名
objvQxDepartmentInfoENT.UpDepartmentId = objvQxDepartmentInfoENS.UpDepartmentId; //所属部门号
objvQxDepartmentInfoENT.OrderNum = objvQxDepartmentInfoENS.OrderNum; //排序号
objvQxDepartmentInfoENT.InUse = objvQxDepartmentInfoENS.InUse; //是否在用
objvQxDepartmentInfoENT.Memo = objvQxDepartmentInfoENS.Memo; //备注
objvQxDepartmentInfoENT.UserNum = objvQxDepartmentInfoENS.UserNum; //用户数
objvQxDepartmentInfoENT.UpDepartmentName = objvQxDepartmentInfoENS.UpDepartmentName; //上级部门
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
 /// <param name = "objvQxDepartmentInfoEN">源简化对象</param>
 public static void SetUpdFlag(clsvQxDepartmentInfoEN objvQxDepartmentInfoEN)
{
try
{
objvQxDepartmentInfoEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvQxDepartmentInfoEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convQxDepartmentInfo.DepartmentId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxDepartmentInfoEN.DepartmentId = objvQxDepartmentInfoEN.DepartmentId; //部门Id
}
if (arrFldSet.Contains(convQxDepartmentInfo.DepartmentName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxDepartmentInfoEN.DepartmentName = objvQxDepartmentInfoEN.DepartmentName; //部门名
}
if (arrFldSet.Contains(convQxDepartmentInfo.DepartmentAbbrName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxDepartmentInfoEN.DepartmentAbbrName = objvQxDepartmentInfoEN.DepartmentAbbrName == "[null]" ? null :  objvQxDepartmentInfoEN.DepartmentAbbrName; //名称缩写
}
if (arrFldSet.Contains(convQxDepartmentInfo.DepartmentTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxDepartmentInfoEN.DepartmentTypeId = objvQxDepartmentInfoEN.DepartmentTypeId; //部门类型ID
}
if (arrFldSet.Contains(convQxDepartmentInfo.DepartmentTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxDepartmentInfoEN.DepartmentTypeName = objvQxDepartmentInfoEN.DepartmentTypeName == "[null]" ? null :  objvQxDepartmentInfoEN.DepartmentTypeName; //部门类型名
}
if (arrFldSet.Contains(convQxDepartmentInfo.UpDepartmentId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxDepartmentInfoEN.UpDepartmentId = objvQxDepartmentInfoEN.UpDepartmentId == "[null]" ? null :  objvQxDepartmentInfoEN.UpDepartmentId; //所属部门号
}
if (arrFldSet.Contains(convQxDepartmentInfo.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxDepartmentInfoEN.OrderNum = objvQxDepartmentInfoEN.OrderNum; //排序号
}
if (arrFldSet.Contains(convQxDepartmentInfo.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxDepartmentInfoEN.InUse = objvQxDepartmentInfoEN.InUse; //是否在用
}
if (arrFldSet.Contains(convQxDepartmentInfo.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxDepartmentInfoEN.Memo = objvQxDepartmentInfoEN.Memo == "[null]" ? null :  objvQxDepartmentInfoEN.Memo; //备注
}
if (arrFldSet.Contains(convQxDepartmentInfo.UserNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxDepartmentInfoEN.UserNum = objvQxDepartmentInfoEN.UserNum; //用户数
}
if (arrFldSet.Contains(convQxDepartmentInfo.UpDepartmentName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxDepartmentInfoEN.UpDepartmentName = objvQxDepartmentInfoEN.UpDepartmentName == "[null]" ? null :  objvQxDepartmentInfoEN.UpDepartmentName; //上级部门
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
 /// <param name = "objvQxDepartmentInfoEN">源简化对象</param>
 public static void AccessFldValueNull(clsvQxDepartmentInfoEN objvQxDepartmentInfoEN)
{
try
{
if (objvQxDepartmentInfoEN.DepartmentAbbrName == "[null]") objvQxDepartmentInfoEN.DepartmentAbbrName = null; //名称缩写
if (objvQxDepartmentInfoEN.DepartmentTypeName == "[null]") objvQxDepartmentInfoEN.DepartmentTypeName = null; //部门类型名
if (objvQxDepartmentInfoEN.UpDepartmentId == "[null]") objvQxDepartmentInfoEN.UpDepartmentId = null; //所属部门号
if (objvQxDepartmentInfoEN.Memo == "[null]") objvQxDepartmentInfoEN.Memo = null; //备注
if (objvQxDepartmentInfoEN.UpDepartmentName == "[null]") objvQxDepartmentInfoEN.UpDepartmentName = null; //上级部门
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
public static void CheckProperty4Condition(clsvQxDepartmentInfoEN objvQxDepartmentInfoEN)
{
 vQxDepartmentInfoDA.CheckProperty4Condition(objvQxDepartmentInfoEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_DepartmentId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convQxDepartmentInfo.DepartmentId); 
List<clsvQxDepartmentInfoEN> arrObjLst = clsvQxDepartmentInfoBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvQxDepartmentInfoEN objvQxDepartmentInfoEN = new clsvQxDepartmentInfoEN()
{
DepartmentId = "0",
DepartmentName = "选[v部门]..."
};
arrObjLst.Insert(0, objvQxDepartmentInfoEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convQxDepartmentInfo.DepartmentId;
objComboBox.DisplayMember = convQxDepartmentInfo.DepartmentName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_DepartmentId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v部门]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convQxDepartmentInfo.DepartmentId); 
IEnumerable<clsvQxDepartmentInfoEN> arrObjLst = clsvQxDepartmentInfoBL.GetObjLst(strCondition);
objDDL.DataValueField = convQxDepartmentInfo.DepartmentId;
objDDL.DataTextField = convQxDepartmentInfo.DepartmentName;
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
public static void BindDdl_DepartmentIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v部门]...","0");
List<clsvQxDepartmentInfoEN> arrvQxDepartmentInfoObjLst = GetAllvQxDepartmentInfoObjLstCache(); 
objDDL.DataValueField = convQxDepartmentInfo.DepartmentId;
objDDL.DataTextField = convQxDepartmentInfo.DepartmentName;
objDDL.DataSource = arrvQxDepartmentInfoObjLst;
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
if (clsQxDepartmentInfoBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxDepartmentInfoBL没有刷新缓存机制(clsQxDepartmentInfoBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxDepartmentTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxDepartmentTypeBL没有刷新缓存机制(clsQxDepartmentTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by DepartmentId");
//if (arrvQxDepartmentInfoObjLstCache == null)
//{
//arrvQxDepartmentInfoObjLstCache = vQxDepartmentInfoDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strDepartmentId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxDepartmentInfoEN GetObjByDepartmentIdCache(string strDepartmentId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvQxDepartmentInfoEN._CurrTabName);
List<clsvQxDepartmentInfoEN> arrvQxDepartmentInfoObjLstCache = GetObjLstCache();
IEnumerable <clsvQxDepartmentInfoEN> arrvQxDepartmentInfoObjLst_Sel =
arrvQxDepartmentInfoObjLstCache
.Where(x=> x.DepartmentId == strDepartmentId 
);
if (arrvQxDepartmentInfoObjLst_Sel.Count() == 0)
{
   clsvQxDepartmentInfoEN obj = clsvQxDepartmentInfoBL.GetObjByDepartmentId(strDepartmentId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvQxDepartmentInfoObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strDepartmentId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetDepartmentNameByDepartmentIdCache(string strDepartmentId)
{
if (string.IsNullOrEmpty(strDepartmentId) == true) return "";
//获取缓存中的对象列表
clsvQxDepartmentInfoEN objvQxDepartmentInfo = GetObjByDepartmentIdCache(strDepartmentId);
if (objvQxDepartmentInfo == null) return "";
return objvQxDepartmentInfo.DepartmentName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strDepartmentId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByDepartmentIdCache(string strDepartmentId)
{
if (string.IsNullOrEmpty(strDepartmentId) == true) return "";
//获取缓存中的对象列表
clsvQxDepartmentInfoEN objvQxDepartmentInfo = GetObjByDepartmentIdCache(strDepartmentId);
if (objvQxDepartmentInfo == null) return "";
return objvQxDepartmentInfo.DepartmentName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxDepartmentInfoEN> GetAllvQxDepartmentInfoObjLstCache()
{
//获取缓存中的对象列表
List<clsvQxDepartmentInfoEN> arrvQxDepartmentInfoObjLstCache = GetObjLstCache(); 
return arrvQxDepartmentInfoObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxDepartmentInfoEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvQxDepartmentInfoEN._CurrTabName);
List<clsvQxDepartmentInfoEN> arrvQxDepartmentInfoObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQxDepartmentInfoObjLstCache;
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
string strKey = string.Format("{0}", clsvQxDepartmentInfoEN._CurrTabName);
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
 /// <param name = "lstvQxDepartmentInfoObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsvQxDepartmentInfoEN> lstvQxDepartmentInfoObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstvQxDepartmentInfoObjLst, writer);
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
 /// <param name = "lstvQxDepartmentInfoObjLst">[clsvQxDepartmentInfoEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsvQxDepartmentInfoEN> lstvQxDepartmentInfoObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsvQxDepartmentInfoBL.listXmlNode);
writer.WriteStartElement(clsvQxDepartmentInfoBL.itemsXmlNode);
foreach (clsvQxDepartmentInfoEN objvQxDepartmentInfoEN in lstvQxDepartmentInfoObjLst)
{
clsvQxDepartmentInfoBL.SerializeXML(writer, objvQxDepartmentInfoEN);
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
 /// <param name = "objvQxDepartmentInfoEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsvQxDepartmentInfoEN objvQxDepartmentInfoEN)
{
writer.WriteStartElement(clsvQxDepartmentInfoBL.itemXmlNode);
 
if (objvQxDepartmentInfoEN.DepartmentId != null)
{
writer.WriteElementString(convQxDepartmentInfo.DepartmentId, objvQxDepartmentInfoEN.DepartmentId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxDepartmentInfoEN.DepartmentName != null)
{
writer.WriteElementString(convQxDepartmentInfo.DepartmentName, objvQxDepartmentInfoEN.DepartmentName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxDepartmentInfoEN.DepartmentAbbrName != null)
{
writer.WriteElementString(convQxDepartmentInfo.DepartmentAbbrName, objvQxDepartmentInfoEN.DepartmentAbbrName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxDepartmentInfoEN.DepartmentTypeId != null)
{
writer.WriteElementString(convQxDepartmentInfo.DepartmentTypeId, objvQxDepartmentInfoEN.DepartmentTypeId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxDepartmentInfoEN.DepartmentTypeName != null)
{
writer.WriteElementString(convQxDepartmentInfo.DepartmentTypeName, objvQxDepartmentInfoEN.DepartmentTypeName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxDepartmentInfoEN.UpDepartmentId != null)
{
writer.WriteElementString(convQxDepartmentInfo.UpDepartmentId, objvQxDepartmentInfoEN.UpDepartmentId.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convQxDepartmentInfo.OrderNum, objvQxDepartmentInfoEN.OrderNum.ToString());
 
writer.WriteElementString(convQxDepartmentInfo.InUse, objvQxDepartmentInfoEN.InUse.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objvQxDepartmentInfoEN.Memo != null)
{
writer.WriteElementString(convQxDepartmentInfo.Memo, objvQxDepartmentInfoEN.Memo.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convQxDepartmentInfo.UserNum, objvQxDepartmentInfoEN.UserNum.ToString());
 
if (objvQxDepartmentInfoEN.UpDepartmentName != null)
{
writer.WriteElementString(convQxDepartmentInfo.UpDepartmentName, objvQxDepartmentInfoEN.UpDepartmentName.ToString(CultureInfo.InvariantCulture));
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
public static clsvQxDepartmentInfoEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsvQxDepartmentInfoEN objvQxDepartmentInfoEN = new clsvQxDepartmentInfoEN();
reader.Read();
while (!(reader.Name == clsvQxDepartmentInfoBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(convQxDepartmentInfo.DepartmentId))
{
objvQxDepartmentInfoEN.DepartmentId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxDepartmentInfo.DepartmentName))
{
objvQxDepartmentInfoEN.DepartmentName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxDepartmentInfo.DepartmentAbbrName))
{
objvQxDepartmentInfoEN.DepartmentAbbrName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxDepartmentInfo.DepartmentTypeId))
{
objvQxDepartmentInfoEN.DepartmentTypeId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxDepartmentInfo.DepartmentTypeName))
{
objvQxDepartmentInfoEN.DepartmentTypeName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxDepartmentInfo.UpDepartmentId))
{
objvQxDepartmentInfoEN.UpDepartmentId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxDepartmentInfo.OrderNum))
{
objvQxDepartmentInfoEN.OrderNum = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(convQxDepartmentInfo.InUse))
{
objvQxDepartmentInfoEN.InUse = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(convQxDepartmentInfo.Memo))
{
objvQxDepartmentInfoEN.Memo = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxDepartmentInfo.UserNum))
{
objvQxDepartmentInfoEN.UserNum = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(convQxDepartmentInfo.UpDepartmentName))
{
objvQxDepartmentInfoEN.UpDepartmentName = reader.ReadElementContentAsString();
}
}
return objvQxDepartmentInfoEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strvQxDepartmentInfoObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsvQxDepartmentInfoEN GetObjFromXmlStr(string strvQxDepartmentInfoObjXmlStr)
{
clsvQxDepartmentInfoEN objvQxDepartmentInfoEN = new clsvQxDepartmentInfoEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strvQxDepartmentInfoObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsvQxDepartmentInfoBL.itemXmlNode))
{
objvQxDepartmentInfoEN = GetObjFromXml(reader);
return objvQxDepartmentInfoEN;
}
}
return objvQxDepartmentInfoEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsvQxDepartmentInfoEN objvQxDepartmentInfoEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objvQxDepartmentInfoEN);
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
public static string Func(string strInFldName, string strOutFldName, string strDepartmentId)
{
if (strInFldName != convQxDepartmentInfo.DepartmentId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convQxDepartmentInfo.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convQxDepartmentInfo.AttributeName));
throw new Exception(strMsg);
}
var objvQxDepartmentInfo = clsvQxDepartmentInfoBL.GetObjByDepartmentIdCache(strDepartmentId);
if (objvQxDepartmentInfo == null) return "";
return objvQxDepartmentInfo[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsvQxDepartmentInfoEN objvQxDepartmentInfoEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsvQxDepartmentInfoEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objvQxDepartmentInfoEN[strField]);
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
 /// <param name = "lstvQxDepartmentInfoObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsvQxDepartmentInfoEN> lstvQxDepartmentInfoObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstvQxDepartmentInfoObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsvQxDepartmentInfoEN objvQxDepartmentInfoEN in lstvQxDepartmentInfoObjLst)
{
string strJSON_One = SerializeObjToJSON(objvQxDepartmentInfoEN);
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
int intRecCount = clsvQxDepartmentInfoDA.GetRecCount(strTabName);
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
int intRecCount = clsvQxDepartmentInfoDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvQxDepartmentInfoDA.GetRecCount();
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
int intRecCount = clsvQxDepartmentInfoDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvQxDepartmentInfoEN objvQxDepartmentInfoCond)
{
List<clsvQxDepartmentInfoEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxDepartmentInfoEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxDepartmentInfo.AttributeName)
{
if (objvQxDepartmentInfoCond.IsUpdated(strFldName) == false) continue;
if (objvQxDepartmentInfoCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxDepartmentInfoCond[strFldName].ToString());
}
else
{
if (objvQxDepartmentInfoCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxDepartmentInfoCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxDepartmentInfoCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxDepartmentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxDepartmentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxDepartmentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxDepartmentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxDepartmentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxDepartmentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxDepartmentInfoCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxDepartmentInfoCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxDepartmentInfoCond[strFldName]));
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
 List<string> arrList = clsvQxDepartmentInfoDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vQxDepartmentInfoDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vQxDepartmentInfoDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}