
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxDepartmentInfoByUserNumWApi
 表名:vQxDepartmentInfoByUserNum(00140082)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 18:34:01
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

namespace GP4WApi
{
/// <summary>
/// 静态类
/// </summary>
public static class  clsvQxDepartmentInfoByUserNumWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoByUserNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strDepartmentId">部门Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxDepartmentInfoByUserNumEN SetDepartmentId(this clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN, string strDepartmentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDepartmentId, 8, convQxDepartmentInfoByUserNum.DepartmentId);
objvQxDepartmentInfoByUserNumEN.DepartmentId = strDepartmentId; //部门Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxDepartmentInfoByUserNumEN.dicFldComparisonOp.ContainsKey(convQxDepartmentInfoByUserNum.DepartmentId) == false)
{
objvQxDepartmentInfoByUserNumEN.dicFldComparisonOp.Add(convQxDepartmentInfoByUserNum.DepartmentId, strComparisonOp);
}
else
{
objvQxDepartmentInfoByUserNumEN.dicFldComparisonOp[convQxDepartmentInfoByUserNum.DepartmentId] = strComparisonOp;
}
}
return objvQxDepartmentInfoByUserNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoByUserNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strDepartmentName">部门名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxDepartmentInfoByUserNumEN SetDepartmentName(this clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN, string strDepartmentName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentName, convQxDepartmentInfoByUserNum.DepartmentName);
clsCheckSql.CheckFieldLen(strDepartmentName, 100, convQxDepartmentInfoByUserNum.DepartmentName);
objvQxDepartmentInfoByUserNumEN.DepartmentName = strDepartmentName; //部门名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxDepartmentInfoByUserNumEN.dicFldComparisonOp.ContainsKey(convQxDepartmentInfoByUserNum.DepartmentName) == false)
{
objvQxDepartmentInfoByUserNumEN.dicFldComparisonOp.Add(convQxDepartmentInfoByUserNum.DepartmentName, strComparisonOp);
}
else
{
objvQxDepartmentInfoByUserNumEN.dicFldComparisonOp[convQxDepartmentInfoByUserNum.DepartmentName] = strComparisonOp;
}
}
return objvQxDepartmentInfoByUserNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoByUserNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strDepartmentAbbrName">名称缩写</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxDepartmentInfoByUserNumEN SetDepartmentAbbrName(this clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN, string strDepartmentAbbrName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDepartmentAbbrName, 8, convQxDepartmentInfoByUserNum.DepartmentAbbrName);
objvQxDepartmentInfoByUserNumEN.DepartmentAbbrName = strDepartmentAbbrName; //名称缩写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxDepartmentInfoByUserNumEN.dicFldComparisonOp.ContainsKey(convQxDepartmentInfoByUserNum.DepartmentAbbrName) == false)
{
objvQxDepartmentInfoByUserNumEN.dicFldComparisonOp.Add(convQxDepartmentInfoByUserNum.DepartmentAbbrName, strComparisonOp);
}
else
{
objvQxDepartmentInfoByUserNumEN.dicFldComparisonOp[convQxDepartmentInfoByUserNum.DepartmentAbbrName] = strComparisonOp;
}
}
return objvQxDepartmentInfoByUserNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoByUserNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strDepartmentTypeId">部门类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxDepartmentInfoByUserNumEN SetDepartmentTypeId(this clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN, string strDepartmentTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDepartmentTypeId, 2, convQxDepartmentInfoByUserNum.DepartmentTypeId);
clsCheckSql.CheckFieldForeignKey(strDepartmentTypeId, 2, convQxDepartmentInfoByUserNum.DepartmentTypeId);
objvQxDepartmentInfoByUserNumEN.DepartmentTypeId = strDepartmentTypeId; //部门类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxDepartmentInfoByUserNumEN.dicFldComparisonOp.ContainsKey(convQxDepartmentInfoByUserNum.DepartmentTypeId) == false)
{
objvQxDepartmentInfoByUserNumEN.dicFldComparisonOp.Add(convQxDepartmentInfoByUserNum.DepartmentTypeId, strComparisonOp);
}
else
{
objvQxDepartmentInfoByUserNumEN.dicFldComparisonOp[convQxDepartmentInfoByUserNum.DepartmentTypeId] = strComparisonOp;
}
}
return objvQxDepartmentInfoByUserNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoByUserNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strDepartmentTypeName">部门类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxDepartmentInfoByUserNumEN SetDepartmentTypeName(this clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN, string strDepartmentTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDepartmentTypeName, 50, convQxDepartmentInfoByUserNum.DepartmentTypeName);
objvQxDepartmentInfoByUserNumEN.DepartmentTypeName = strDepartmentTypeName; //部门类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxDepartmentInfoByUserNumEN.dicFldComparisonOp.ContainsKey(convQxDepartmentInfoByUserNum.DepartmentTypeName) == false)
{
objvQxDepartmentInfoByUserNumEN.dicFldComparisonOp.Add(convQxDepartmentInfoByUserNum.DepartmentTypeName, strComparisonOp);
}
else
{
objvQxDepartmentInfoByUserNumEN.dicFldComparisonOp[convQxDepartmentInfoByUserNum.DepartmentTypeName] = strComparisonOp;
}
}
return objvQxDepartmentInfoByUserNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoByUserNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpDepartmentId">所属部门号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxDepartmentInfoByUserNumEN SetUpDepartmentId(this clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN, string strUpDepartmentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpDepartmentId, 6, convQxDepartmentInfoByUserNum.UpDepartmentId);
objvQxDepartmentInfoByUserNumEN.UpDepartmentId = strUpDepartmentId; //所属部门号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxDepartmentInfoByUserNumEN.dicFldComparisonOp.ContainsKey(convQxDepartmentInfoByUserNum.UpDepartmentId) == false)
{
objvQxDepartmentInfoByUserNumEN.dicFldComparisonOp.Add(convQxDepartmentInfoByUserNum.UpDepartmentId, strComparisonOp);
}
else
{
objvQxDepartmentInfoByUserNumEN.dicFldComparisonOp[convQxDepartmentInfoByUserNum.UpDepartmentId] = strComparisonOp;
}
}
return objvQxDepartmentInfoByUserNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoByUserNumEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">排序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxDepartmentInfoByUserNumEN SetOrderNum(this clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN, int intOrderNum, string strComparisonOp="")
	{
objvQxDepartmentInfoByUserNumEN.OrderNum = intOrderNum; //排序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxDepartmentInfoByUserNumEN.dicFldComparisonOp.ContainsKey(convQxDepartmentInfoByUserNum.OrderNum) == false)
{
objvQxDepartmentInfoByUserNumEN.dicFldComparisonOp.Add(convQxDepartmentInfoByUserNum.OrderNum, strComparisonOp);
}
else
{
objvQxDepartmentInfoByUserNumEN.dicFldComparisonOp[convQxDepartmentInfoByUserNum.OrderNum] = strComparisonOp;
}
}
return objvQxDepartmentInfoByUserNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoByUserNumEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxDepartmentInfoByUserNumEN SetInUse(this clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN, bool bolInUse, string strComparisonOp="")
	{
objvQxDepartmentInfoByUserNumEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxDepartmentInfoByUserNumEN.dicFldComparisonOp.ContainsKey(convQxDepartmentInfoByUserNum.InUse) == false)
{
objvQxDepartmentInfoByUserNumEN.dicFldComparisonOp.Add(convQxDepartmentInfoByUserNum.InUse, strComparisonOp);
}
else
{
objvQxDepartmentInfoByUserNumEN.dicFldComparisonOp[convQxDepartmentInfoByUserNum.InUse] = strComparisonOp;
}
}
return objvQxDepartmentInfoByUserNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoByUserNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">备注</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxDepartmentInfoByUserNumEN SetMemo(this clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxDepartmentInfoByUserNum.Memo);
objvQxDepartmentInfoByUserNumEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxDepartmentInfoByUserNumEN.dicFldComparisonOp.ContainsKey(convQxDepartmentInfoByUserNum.Memo) == false)
{
objvQxDepartmentInfoByUserNumEN.dicFldComparisonOp.Add(convQxDepartmentInfoByUserNum.Memo, strComparisonOp);
}
else
{
objvQxDepartmentInfoByUserNumEN.dicFldComparisonOp[convQxDepartmentInfoByUserNum.Memo] = strComparisonOp;
}
}
return objvQxDepartmentInfoByUserNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoByUserNumEN">需要设置字段值的实体对象</param>
 /// <param name = "intUserNum">用户数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxDepartmentInfoByUserNumEN SetUserNum(this clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN, int intUserNum, string strComparisonOp="")
	{
objvQxDepartmentInfoByUserNumEN.UserNum = intUserNum; //用户数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxDepartmentInfoByUserNumEN.dicFldComparisonOp.ContainsKey(convQxDepartmentInfoByUserNum.UserNum) == false)
{
objvQxDepartmentInfoByUserNumEN.dicFldComparisonOp.Add(convQxDepartmentInfoByUserNum.UserNum, strComparisonOp);
}
else
{
objvQxDepartmentInfoByUserNumEN.dicFldComparisonOp[convQxDepartmentInfoByUserNum.UserNum] = strComparisonOp;
}
}
return objvQxDepartmentInfoByUserNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoByUserNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpDepartmentName">上级部门</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxDepartmentInfoByUserNumEN SetUpDepartmentName(this clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN, string strUpDepartmentName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpDepartmentName, 100, convQxDepartmentInfoByUserNum.UpDepartmentName);
objvQxDepartmentInfoByUserNumEN.UpDepartmentName = strUpDepartmentName; //上级部门
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxDepartmentInfoByUserNumEN.dicFldComparisonOp.ContainsKey(convQxDepartmentInfoByUserNum.UpDepartmentName) == false)
{
objvQxDepartmentInfoByUserNumEN.dicFldComparisonOp.Add(convQxDepartmentInfoByUserNum.UpDepartmentName, strComparisonOp);
}
else
{
objvQxDepartmentInfoByUserNumEN.dicFldComparisonOp[convQxDepartmentInfoByUserNum.UpDepartmentName] = strComparisonOp;
}
}
return objvQxDepartmentInfoByUserNumEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQxDepartmentInfoByUserNumCond.IsUpdated(convQxDepartmentInfoByUserNum.DepartmentId) == true)
{
string strComparisonOpDepartmentId = objvQxDepartmentInfoByUserNumCond.dicFldComparisonOp[convQxDepartmentInfoByUserNum.DepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxDepartmentInfoByUserNum.DepartmentId, objvQxDepartmentInfoByUserNumCond.DepartmentId, strComparisonOpDepartmentId);
}
if (objvQxDepartmentInfoByUserNumCond.IsUpdated(convQxDepartmentInfoByUserNum.DepartmentName) == true)
{
string strComparisonOpDepartmentName = objvQxDepartmentInfoByUserNumCond.dicFldComparisonOp[convQxDepartmentInfoByUserNum.DepartmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxDepartmentInfoByUserNum.DepartmentName, objvQxDepartmentInfoByUserNumCond.DepartmentName, strComparisonOpDepartmentName);
}
if (objvQxDepartmentInfoByUserNumCond.IsUpdated(convQxDepartmentInfoByUserNum.DepartmentAbbrName) == true)
{
string strComparisonOpDepartmentAbbrName = objvQxDepartmentInfoByUserNumCond.dicFldComparisonOp[convQxDepartmentInfoByUserNum.DepartmentAbbrName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxDepartmentInfoByUserNum.DepartmentAbbrName, objvQxDepartmentInfoByUserNumCond.DepartmentAbbrName, strComparisonOpDepartmentAbbrName);
}
if (objvQxDepartmentInfoByUserNumCond.IsUpdated(convQxDepartmentInfoByUserNum.DepartmentTypeId) == true)
{
string strComparisonOpDepartmentTypeId = objvQxDepartmentInfoByUserNumCond.dicFldComparisonOp[convQxDepartmentInfoByUserNum.DepartmentTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxDepartmentInfoByUserNum.DepartmentTypeId, objvQxDepartmentInfoByUserNumCond.DepartmentTypeId, strComparisonOpDepartmentTypeId);
}
if (objvQxDepartmentInfoByUserNumCond.IsUpdated(convQxDepartmentInfoByUserNum.DepartmentTypeName) == true)
{
string strComparisonOpDepartmentTypeName = objvQxDepartmentInfoByUserNumCond.dicFldComparisonOp[convQxDepartmentInfoByUserNum.DepartmentTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxDepartmentInfoByUserNum.DepartmentTypeName, objvQxDepartmentInfoByUserNumCond.DepartmentTypeName, strComparisonOpDepartmentTypeName);
}
if (objvQxDepartmentInfoByUserNumCond.IsUpdated(convQxDepartmentInfoByUserNum.UpDepartmentId) == true)
{
string strComparisonOpUpDepartmentId = objvQxDepartmentInfoByUserNumCond.dicFldComparisonOp[convQxDepartmentInfoByUserNum.UpDepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxDepartmentInfoByUserNum.UpDepartmentId, objvQxDepartmentInfoByUserNumCond.UpDepartmentId, strComparisonOpUpDepartmentId);
}
if (objvQxDepartmentInfoByUserNumCond.IsUpdated(convQxDepartmentInfoByUserNum.OrderNum) == true)
{
string strComparisonOpOrderNum = objvQxDepartmentInfoByUserNumCond.dicFldComparisonOp[convQxDepartmentInfoByUserNum.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQxDepartmentInfoByUserNum.OrderNum, objvQxDepartmentInfoByUserNumCond.OrderNum, strComparisonOpOrderNum);
}
if (objvQxDepartmentInfoByUserNumCond.IsUpdated(convQxDepartmentInfoByUserNum.InUse) == true)
{
if (objvQxDepartmentInfoByUserNumCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQxDepartmentInfoByUserNum.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQxDepartmentInfoByUserNum.InUse);
}
}
if (objvQxDepartmentInfoByUserNumCond.IsUpdated(convQxDepartmentInfoByUserNum.Memo) == true)
{
string strComparisonOpMemo = objvQxDepartmentInfoByUserNumCond.dicFldComparisonOp[convQxDepartmentInfoByUserNum.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxDepartmentInfoByUserNum.Memo, objvQxDepartmentInfoByUserNumCond.Memo, strComparisonOpMemo);
}
if (objvQxDepartmentInfoByUserNumCond.IsUpdated(convQxDepartmentInfoByUserNum.UserNum) == true)
{
string strComparisonOpUserNum = objvQxDepartmentInfoByUserNumCond.dicFldComparisonOp[convQxDepartmentInfoByUserNum.UserNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQxDepartmentInfoByUserNum.UserNum, objvQxDepartmentInfoByUserNumCond.UserNum, strComparisonOpUserNum);
}
if (objvQxDepartmentInfoByUserNumCond.IsUpdated(convQxDepartmentInfoByUserNum.UpDepartmentName) == true)
{
string strComparisonOpUpDepartmentName = objvQxDepartmentInfoByUserNumCond.dicFldComparisonOp[convQxDepartmentInfoByUserNum.UpDepartmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxDepartmentInfoByUserNum.UpDepartmentName, objvQxDepartmentInfoByUserNumCond.UpDepartmentName, strComparisonOpUpDepartmentName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v部门信息By用户数(vQxDepartmentInfoByUserNum)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxDepartmentInfoByUserNumWApi
{
private static readonly string mstrApiControllerName = "vQxDepartmentInfoByUserNumApi";

 public clsvQxDepartmentInfoByUserNumWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_DepartmentId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v部门信息By用户数]...","0");
List<clsvQxDepartmentInfoByUserNumEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="DepartmentId";
objDDL.DataTextField="DepartmentName";
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

public static void BindCbo_DepartmentId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convQxDepartmentInfoByUserNum.DepartmentId); 
List<clsvQxDepartmentInfoByUserNumEN> arrObjLst = clsvQxDepartmentInfoByUserNumWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN = new clsvQxDepartmentInfoByUserNumEN()
{
DepartmentId = "0",
DepartmentName = "选[v部门信息By用户数]..."
};
arrObjLst.Insert(0, objvQxDepartmentInfoByUserNumEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convQxDepartmentInfoByUserNum.DepartmentId;
objComboBox.DisplayMember = convQxDepartmentInfoByUserNum.DepartmentName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strDepartmentId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxDepartmentInfoByUserNumEN GetObjByDepartmentId(string strDepartmentId)
{
string strAction = "GetObjByDepartmentId";
clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strDepartmentId"] = strDepartmentId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvQxDepartmentInfoByUserNumEN = JsonConvert.DeserializeObject<clsvQxDepartmentInfoByUserNumEN>(strJson);
return objvQxDepartmentInfoByUserNumEN;
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
public static clsvQxDepartmentInfoByUserNumEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN;
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
objvQxDepartmentInfoByUserNumEN = JsonConvert.DeserializeObject<clsvQxDepartmentInfoByUserNumEN>(strJson);
return objvQxDepartmentInfoByUserNumEN;
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
//该表没有使用Cache,不需要生成[GetDepartmentNameByDepartmentIdCache]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxDepartmentInfoByUserNumEN> GetObjLst(string strWhereCond)
{
 List<clsvQxDepartmentInfoByUserNumEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxDepartmentInfoByUserNumEN>>(strJson);
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
 /// <param name = "arrDepartmentId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxDepartmentInfoByUserNumEN> GetObjLstByDepartmentIdLst(List<string> arrDepartmentId)
{
 List<clsvQxDepartmentInfoByUserNumEN> arrObjLst; 
string strAction = "GetObjLstByDepartmentIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrDepartmentId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxDepartmentInfoByUserNumEN>>(strJson);
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
public static List<clsvQxDepartmentInfoByUserNumEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvQxDepartmentInfoByUserNumEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxDepartmentInfoByUserNumEN>>(strJson);
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
public static List<clsvQxDepartmentInfoByUserNumEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvQxDepartmentInfoByUserNumEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxDepartmentInfoByUserNumEN>>(strJson);
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
public static List<clsvQxDepartmentInfoByUserNumEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvQxDepartmentInfoByUserNumEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxDepartmentInfoByUserNumEN>>(strJson);
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
public static List<clsvQxDepartmentInfoByUserNumEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvQxDepartmentInfoByUserNumEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxDepartmentInfoByUserNumEN>>(strJson);
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
public static bool IsExist(string strDepartmentId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strDepartmentId"] = strDepartmentId
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
 /// <param name = "objvQxDepartmentInfoByUserNumENS">源对象</param>
 /// <param name = "objvQxDepartmentInfoByUserNumENT">目标对象</param>
 public static void CopyTo(clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumENS, clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumENT)
{
try
{
objvQxDepartmentInfoByUserNumENT.DepartmentId = objvQxDepartmentInfoByUserNumENS.DepartmentId; //部门Id
objvQxDepartmentInfoByUserNumENT.DepartmentName = objvQxDepartmentInfoByUserNumENS.DepartmentName; //部门名
objvQxDepartmentInfoByUserNumENT.DepartmentAbbrName = objvQxDepartmentInfoByUserNumENS.DepartmentAbbrName; //名称缩写
objvQxDepartmentInfoByUserNumENT.DepartmentTypeId = objvQxDepartmentInfoByUserNumENS.DepartmentTypeId; //部门类型ID
objvQxDepartmentInfoByUserNumENT.DepartmentTypeName = objvQxDepartmentInfoByUserNumENS.DepartmentTypeName; //部门类型名
objvQxDepartmentInfoByUserNumENT.UpDepartmentId = objvQxDepartmentInfoByUserNumENS.UpDepartmentId; //所属部门号
objvQxDepartmentInfoByUserNumENT.OrderNum = objvQxDepartmentInfoByUserNumENS.OrderNum; //排序号
objvQxDepartmentInfoByUserNumENT.InUse = objvQxDepartmentInfoByUserNumENS.InUse; //是否在用
objvQxDepartmentInfoByUserNumENT.Memo = objvQxDepartmentInfoByUserNumENS.Memo; //备注
objvQxDepartmentInfoByUserNumENT.UserNum = objvQxDepartmentInfoByUserNumENS.UserNum; //用户数
objvQxDepartmentInfoByUserNumENT.UpDepartmentName = objvQxDepartmentInfoByUserNumENS.UpDepartmentName; //上级部门
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
public static DataTable ToDataTable(List<clsvQxDepartmentInfoByUserNumEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvQxDepartmentInfoByUserNumEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvQxDepartmentInfoByUserNumEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvQxDepartmentInfoByUserNumEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvQxDepartmentInfoByUserNumEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvQxDepartmentInfoByUserNumEN.AttributeName)
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
string strKey = string.Format("{0}", clsvQxDepartmentInfoByUserNumEN._CurrTabName);
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
public static DataTable GetDataTableByObjLst(List<clsvQxDepartmentInfoByUserNumEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convQxDepartmentInfoByUserNum.DepartmentId, Type.GetType("System.String"));
objDT.Columns.Add(convQxDepartmentInfoByUserNum.DepartmentName, Type.GetType("System.String"));
objDT.Columns.Add(convQxDepartmentInfoByUserNum.DepartmentAbbrName, Type.GetType("System.String"));
objDT.Columns.Add(convQxDepartmentInfoByUserNum.DepartmentTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convQxDepartmentInfoByUserNum.DepartmentTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convQxDepartmentInfoByUserNum.UpDepartmentId, Type.GetType("System.String"));
objDT.Columns.Add(convQxDepartmentInfoByUserNum.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convQxDepartmentInfoByUserNum.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQxDepartmentInfoByUserNum.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convQxDepartmentInfoByUserNum.UserNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convQxDepartmentInfoByUserNum.UpDepartmentName, Type.GetType("System.String"));
foreach (clsvQxDepartmentInfoByUserNumEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convQxDepartmentInfoByUserNum.DepartmentId] = objInFor[convQxDepartmentInfoByUserNum.DepartmentId];
objDR[convQxDepartmentInfoByUserNum.DepartmentName] = objInFor[convQxDepartmentInfoByUserNum.DepartmentName];
objDR[convQxDepartmentInfoByUserNum.DepartmentAbbrName] = objInFor[convQxDepartmentInfoByUserNum.DepartmentAbbrName];
objDR[convQxDepartmentInfoByUserNum.DepartmentTypeId] = objInFor[convQxDepartmentInfoByUserNum.DepartmentTypeId];
objDR[convQxDepartmentInfoByUserNum.DepartmentTypeName] = objInFor[convQxDepartmentInfoByUserNum.DepartmentTypeName];
objDR[convQxDepartmentInfoByUserNum.UpDepartmentId] = objInFor[convQxDepartmentInfoByUserNum.UpDepartmentId];
objDR[convQxDepartmentInfoByUserNum.OrderNum] = objInFor[convQxDepartmentInfoByUserNum.OrderNum];
objDR[convQxDepartmentInfoByUserNum.InUse] = objInFor[convQxDepartmentInfoByUserNum.InUse];
objDR[convQxDepartmentInfoByUserNum.Memo] = objInFor[convQxDepartmentInfoByUserNum.Memo];
objDR[convQxDepartmentInfoByUserNum.UserNum] = objInFor[convQxDepartmentInfoByUserNum.UserNum];
objDR[convQxDepartmentInfoByUserNum.UpDepartmentName] = objInFor[convQxDepartmentInfoByUserNum.UpDepartmentName];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}