
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxDepartmentInfoByUserNumBL
 表名:vQxDepartmentInfoByUserNum(00140082)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:24:35
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
public static class  clsvQxDepartmentInfoByUserNumBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strDepartmentId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxDepartmentInfoByUserNumEN GetObj(this K_DepartmentId_vQxDepartmentInfoByUserNum myKey)
{
clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN = clsvQxDepartmentInfoByUserNumBL.vQxDepartmentInfoByUserNumDA.GetObjByDepartmentId(myKey.Value);
return objvQxDepartmentInfoByUserNumEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoByUserNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxDepartmentInfoByUserNumEN SetDepartmentId(this clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN, string strDepartmentId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentId, 8, convQxDepartmentInfoByUserNum.DepartmentId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoByUserNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxDepartmentInfoByUserNumEN SetDepartmentName(this clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN, string strDepartmentName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentName, convQxDepartmentInfoByUserNum.DepartmentName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentName, 100, convQxDepartmentInfoByUserNum.DepartmentName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoByUserNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxDepartmentInfoByUserNumEN SetDepartmentAbbrName(this clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN, string strDepartmentAbbrName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentAbbrName, 8, convQxDepartmentInfoByUserNum.DepartmentAbbrName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoByUserNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxDepartmentInfoByUserNumEN SetDepartmentTypeId(this clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN, string strDepartmentTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentTypeId, 2, convQxDepartmentInfoByUserNum.DepartmentTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDepartmentTypeId, 2, convQxDepartmentInfoByUserNum.DepartmentTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoByUserNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxDepartmentInfoByUserNumEN SetDepartmentTypeName(this clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN, string strDepartmentTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentTypeName, 50, convQxDepartmentInfoByUserNum.DepartmentTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoByUserNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxDepartmentInfoByUserNumEN SetUpDepartmentId(this clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN, string strUpDepartmentId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpDepartmentId, 6, convQxDepartmentInfoByUserNum.UpDepartmentId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoByUserNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxDepartmentInfoByUserNumEN SetOrderNum(this clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN, int? intOrderNum, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoByUserNumEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoByUserNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxDepartmentInfoByUserNumEN SetMemo(this clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxDepartmentInfoByUserNum.Memo);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoByUserNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxDepartmentInfoByUserNumEN SetUserNum(this clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN, int? intUserNum, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoByUserNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxDepartmentInfoByUserNumEN SetUpDepartmentName(this clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN, string strUpDepartmentName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpDepartmentName, 100, convQxDepartmentInfoByUserNum.UpDepartmentName);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoByUserNumENS">源对象</param>
 /// <param name = "objvQxDepartmentInfoByUserNumENT">目标对象</param>
 public static void CopyTo(this clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumENS, clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumENT)
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
 /// <param name = "objvQxDepartmentInfoByUserNumENS">源对象</param>
 /// <returns>目标对象=>clsvQxDepartmentInfoByUserNumEN:objvQxDepartmentInfoByUserNumENT</returns>
 public static clsvQxDepartmentInfoByUserNumEN CopyTo(this clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumENS)
{
try
{
 clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumENT = new clsvQxDepartmentInfoByUserNumEN()
{
DepartmentId = objvQxDepartmentInfoByUserNumENS.DepartmentId, //部门Id
DepartmentName = objvQxDepartmentInfoByUserNumENS.DepartmentName, //部门名
DepartmentAbbrName = objvQxDepartmentInfoByUserNumENS.DepartmentAbbrName, //名称缩写
DepartmentTypeId = objvQxDepartmentInfoByUserNumENS.DepartmentTypeId, //部门类型ID
DepartmentTypeName = objvQxDepartmentInfoByUserNumENS.DepartmentTypeName, //部门类型名
UpDepartmentId = objvQxDepartmentInfoByUserNumENS.UpDepartmentId, //所属部门号
OrderNum = objvQxDepartmentInfoByUserNumENS.OrderNum, //排序号
InUse = objvQxDepartmentInfoByUserNumENS.InUse, //是否在用
Memo = objvQxDepartmentInfoByUserNumENS.Memo, //备注
UserNum = objvQxDepartmentInfoByUserNumENS.UserNum, //用户数
UpDepartmentName = objvQxDepartmentInfoByUserNumENS.UpDepartmentName, //上级部门
};
 return objvQxDepartmentInfoByUserNumENT;
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
public static void CheckProperty4Condition(this clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN)
{
 clsvQxDepartmentInfoByUserNumBL.vQxDepartmentInfoByUserNumDA.CheckProperty4Condition(objvQxDepartmentInfoByUserNumEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vQxDepartmentInfoByUserNum
{
public virtual bool UpdRelaTabDate(string strDepartmentId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v部门信息By用户数(vQxDepartmentInfoByUserNum)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvQxDepartmentInfoByUserNumBL
{
public static RelatedActions_vQxDepartmentInfoByUserNum relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "vQxDepartmentInfoByUserNumListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "vQxDepartmentInfoByUserNumList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsvQxDepartmentInfoByUserNumEN> arrvQxDepartmentInfoByUserNumObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvQxDepartmentInfoByUserNumDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvQxDepartmentInfoByUserNumDA vQxDepartmentInfoByUserNumDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvQxDepartmentInfoByUserNumDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvQxDepartmentInfoByUserNumBL()
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
if (string.IsNullOrEmpty(clsvQxDepartmentInfoByUserNumEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxDepartmentInfoByUserNumEN._ConnectString);
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
objDS = vQxDepartmentInfoByUserNumDA.GetDataSet(strWhereCond);
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
objDS = vQxDepartmentInfoByUserNumDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = vQxDepartmentInfoByUserNumDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_vQxDepartmentInfoByUserNum(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQxDepartmentInfoByUserNumDA.GetDataTable_vQxDepartmentInfoByUserNum(strWhereCond);
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
objDT = vQxDepartmentInfoByUserNumDA.GetDataTable(strWhereCond);
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
objDT = vQxDepartmentInfoByUserNumDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vQxDepartmentInfoByUserNumDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vQxDepartmentInfoByUserNumDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vQxDepartmentInfoByUserNumDA.GetDataTable_Top(objTopPara);
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
objDT = vQxDepartmentInfoByUserNumDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vQxDepartmentInfoByUserNumDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = vQxDepartmentInfoByUserNumDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vQxDepartmentInfoByUserNumDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = vQxDepartmentInfoByUserNumDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = vQxDepartmentInfoByUserNumDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = vQxDepartmentInfoByUserNumDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = vQxDepartmentInfoByUserNumDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
public static List<clsvQxDepartmentInfoByUserNumEN> GetObjLstByDepartmentIdLst(List<string> arrDepartmentIdLst)
{
List<clsvQxDepartmentInfoByUserNumEN> arrObjLst = new List<clsvQxDepartmentInfoByUserNumEN>(); 
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
	clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN = new clsvQxDepartmentInfoByUserNumEN();
try
{
objvQxDepartmentInfoByUserNumEN.DepartmentId = objRow[convQxDepartmentInfoByUserNum.DepartmentId].ToString().Trim(); //部门Id
objvQxDepartmentInfoByUserNumEN.DepartmentName = objRow[convQxDepartmentInfoByUserNum.DepartmentName].ToString().Trim(); //部门名
objvQxDepartmentInfoByUserNumEN.DepartmentAbbrName = objRow[convQxDepartmentInfoByUserNum.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxDepartmentInfoByUserNumEN.DepartmentTypeId = objRow[convQxDepartmentInfoByUserNum.DepartmentTypeId] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxDepartmentInfoByUserNumEN.DepartmentTypeName = objRow[convQxDepartmentInfoByUserNum.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxDepartmentInfoByUserNumEN.UpDepartmentId = objRow[convQxDepartmentInfoByUserNum.UpDepartmentId] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxDepartmentInfoByUserNumEN.OrderNum = objRow[convQxDepartmentInfoByUserNum.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxDepartmentInfoByUserNum.OrderNum].ToString().Trim()); //排序号
objvQxDepartmentInfoByUserNumEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxDepartmentInfoByUserNum.InUse].ToString().Trim()); //是否在用
objvQxDepartmentInfoByUserNumEN.Memo = objRow[convQxDepartmentInfoByUserNum.Memo] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.Memo].ToString().Trim(); //备注
objvQxDepartmentInfoByUserNumEN.UserNum = objRow[convQxDepartmentInfoByUserNum.UserNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxDepartmentInfoByUserNum.UserNum].ToString().Trim()); //用户数
objvQxDepartmentInfoByUserNumEN.UpDepartmentName = objRow[convQxDepartmentInfoByUserNum.UpDepartmentName] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.UpDepartmentName].ToString().Trim(); //上级部门
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxDepartmentInfoByUserNumEN.DepartmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxDepartmentInfoByUserNumEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrDepartmentIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvQxDepartmentInfoByUserNumEN> GetObjLstByDepartmentIdLstCache(List<string> arrDepartmentIdLst)
{
string strKey = string.Format("{0}", clsvQxDepartmentInfoByUserNumEN._CurrTabName);
List<clsvQxDepartmentInfoByUserNumEN> arrvQxDepartmentInfoByUserNumObjLstCache = GetObjLstCache();
IEnumerable <clsvQxDepartmentInfoByUserNumEN> arrvQxDepartmentInfoByUserNumObjLst_Sel =
arrvQxDepartmentInfoByUserNumObjLstCache
.Where(x => arrDepartmentIdLst.Contains(x.DepartmentId));
return arrvQxDepartmentInfoByUserNumObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxDepartmentInfoByUserNumEN> GetObjLst(string strWhereCond)
{
List<clsvQxDepartmentInfoByUserNumEN> arrObjLst = new List<clsvQxDepartmentInfoByUserNumEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN = new clsvQxDepartmentInfoByUserNumEN();
try
{
objvQxDepartmentInfoByUserNumEN.DepartmentId = objRow[convQxDepartmentInfoByUserNum.DepartmentId].ToString().Trim(); //部门Id
objvQxDepartmentInfoByUserNumEN.DepartmentName = objRow[convQxDepartmentInfoByUserNum.DepartmentName].ToString().Trim(); //部门名
objvQxDepartmentInfoByUserNumEN.DepartmentAbbrName = objRow[convQxDepartmentInfoByUserNum.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxDepartmentInfoByUserNumEN.DepartmentTypeId = objRow[convQxDepartmentInfoByUserNum.DepartmentTypeId] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxDepartmentInfoByUserNumEN.DepartmentTypeName = objRow[convQxDepartmentInfoByUserNum.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxDepartmentInfoByUserNumEN.UpDepartmentId = objRow[convQxDepartmentInfoByUserNum.UpDepartmentId] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxDepartmentInfoByUserNumEN.OrderNum = objRow[convQxDepartmentInfoByUserNum.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxDepartmentInfoByUserNum.OrderNum].ToString().Trim()); //排序号
objvQxDepartmentInfoByUserNumEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxDepartmentInfoByUserNum.InUse].ToString().Trim()); //是否在用
objvQxDepartmentInfoByUserNumEN.Memo = objRow[convQxDepartmentInfoByUserNum.Memo] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.Memo].ToString().Trim(); //备注
objvQxDepartmentInfoByUserNumEN.UserNum = objRow[convQxDepartmentInfoByUserNum.UserNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxDepartmentInfoByUserNum.UserNum].ToString().Trim()); //用户数
objvQxDepartmentInfoByUserNumEN.UpDepartmentName = objRow[convQxDepartmentInfoByUserNum.UpDepartmentName] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.UpDepartmentName].ToString().Trim(); //上级部门
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxDepartmentInfoByUserNumEN.DepartmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxDepartmentInfoByUserNumEN);
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
public static List<clsvQxDepartmentInfoByUserNumEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQxDepartmentInfoByUserNumEN> arrObjLst = new List<clsvQxDepartmentInfoByUserNumEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN = new clsvQxDepartmentInfoByUserNumEN();
try
{
objvQxDepartmentInfoByUserNumEN.DepartmentId = objRow[convQxDepartmentInfoByUserNum.DepartmentId].ToString().Trim(); //部门Id
objvQxDepartmentInfoByUserNumEN.DepartmentName = objRow[convQxDepartmentInfoByUserNum.DepartmentName].ToString().Trim(); //部门名
objvQxDepartmentInfoByUserNumEN.DepartmentAbbrName = objRow[convQxDepartmentInfoByUserNum.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxDepartmentInfoByUserNumEN.DepartmentTypeId = objRow[convQxDepartmentInfoByUserNum.DepartmentTypeId] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxDepartmentInfoByUserNumEN.DepartmentTypeName = objRow[convQxDepartmentInfoByUserNum.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxDepartmentInfoByUserNumEN.UpDepartmentId = objRow[convQxDepartmentInfoByUserNum.UpDepartmentId] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxDepartmentInfoByUserNumEN.OrderNum = objRow[convQxDepartmentInfoByUserNum.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxDepartmentInfoByUserNum.OrderNum].ToString().Trim()); //排序号
objvQxDepartmentInfoByUserNumEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxDepartmentInfoByUserNum.InUse].ToString().Trim()); //是否在用
objvQxDepartmentInfoByUserNumEN.Memo = objRow[convQxDepartmentInfoByUserNum.Memo] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.Memo].ToString().Trim(); //备注
objvQxDepartmentInfoByUserNumEN.UserNum = objRow[convQxDepartmentInfoByUserNum.UserNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxDepartmentInfoByUserNum.UserNum].ToString().Trim()); //用户数
objvQxDepartmentInfoByUserNumEN.UpDepartmentName = objRow[convQxDepartmentInfoByUserNum.UpDepartmentName] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.UpDepartmentName].ToString().Trim(); //上级部门
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxDepartmentInfoByUserNumEN.DepartmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxDepartmentInfoByUserNumEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoByUserNumCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvQxDepartmentInfoByUserNumEN> GetSubObjLstCache(clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumCond)
{
List<clsvQxDepartmentInfoByUserNumEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxDepartmentInfoByUserNumEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxDepartmentInfoByUserNum.AttributeName)
{
if (objvQxDepartmentInfoByUserNumCond.IsUpdated(strFldName) == false) continue;
if (objvQxDepartmentInfoByUserNumCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxDepartmentInfoByUserNumCond[strFldName].ToString());
}
else
{
if (objvQxDepartmentInfoByUserNumCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxDepartmentInfoByUserNumCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxDepartmentInfoByUserNumCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxDepartmentInfoByUserNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxDepartmentInfoByUserNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxDepartmentInfoByUserNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxDepartmentInfoByUserNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxDepartmentInfoByUserNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxDepartmentInfoByUserNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxDepartmentInfoByUserNumCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxDepartmentInfoByUserNumCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxDepartmentInfoByUserNumCond[strFldName]));
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
public static List<clsvQxDepartmentInfoByUserNumEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvQxDepartmentInfoByUserNumEN> arrObjLst = new List<clsvQxDepartmentInfoByUserNumEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN = new clsvQxDepartmentInfoByUserNumEN();
try
{
objvQxDepartmentInfoByUserNumEN.DepartmentId = objRow[convQxDepartmentInfoByUserNum.DepartmentId].ToString().Trim(); //部门Id
objvQxDepartmentInfoByUserNumEN.DepartmentName = objRow[convQxDepartmentInfoByUserNum.DepartmentName].ToString().Trim(); //部门名
objvQxDepartmentInfoByUserNumEN.DepartmentAbbrName = objRow[convQxDepartmentInfoByUserNum.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxDepartmentInfoByUserNumEN.DepartmentTypeId = objRow[convQxDepartmentInfoByUserNum.DepartmentTypeId] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxDepartmentInfoByUserNumEN.DepartmentTypeName = objRow[convQxDepartmentInfoByUserNum.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxDepartmentInfoByUserNumEN.UpDepartmentId = objRow[convQxDepartmentInfoByUserNum.UpDepartmentId] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxDepartmentInfoByUserNumEN.OrderNum = objRow[convQxDepartmentInfoByUserNum.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxDepartmentInfoByUserNum.OrderNum].ToString().Trim()); //排序号
objvQxDepartmentInfoByUserNumEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxDepartmentInfoByUserNum.InUse].ToString().Trim()); //是否在用
objvQxDepartmentInfoByUserNumEN.Memo = objRow[convQxDepartmentInfoByUserNum.Memo] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.Memo].ToString().Trim(); //备注
objvQxDepartmentInfoByUserNumEN.UserNum = objRow[convQxDepartmentInfoByUserNum.UserNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxDepartmentInfoByUserNum.UserNum].ToString().Trim()); //用户数
objvQxDepartmentInfoByUserNumEN.UpDepartmentName = objRow[convQxDepartmentInfoByUserNum.UpDepartmentName] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.UpDepartmentName].ToString().Trim(); //上级部门
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxDepartmentInfoByUserNumEN.DepartmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxDepartmentInfoByUserNumEN);
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
public static List<clsvQxDepartmentInfoByUserNumEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvQxDepartmentInfoByUserNumEN> arrObjLst = new List<clsvQxDepartmentInfoByUserNumEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN = new clsvQxDepartmentInfoByUserNumEN();
try
{
objvQxDepartmentInfoByUserNumEN.DepartmentId = objRow[convQxDepartmentInfoByUserNum.DepartmentId].ToString().Trim(); //部门Id
objvQxDepartmentInfoByUserNumEN.DepartmentName = objRow[convQxDepartmentInfoByUserNum.DepartmentName].ToString().Trim(); //部门名
objvQxDepartmentInfoByUserNumEN.DepartmentAbbrName = objRow[convQxDepartmentInfoByUserNum.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxDepartmentInfoByUserNumEN.DepartmentTypeId = objRow[convQxDepartmentInfoByUserNum.DepartmentTypeId] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxDepartmentInfoByUserNumEN.DepartmentTypeName = objRow[convQxDepartmentInfoByUserNum.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxDepartmentInfoByUserNumEN.UpDepartmentId = objRow[convQxDepartmentInfoByUserNum.UpDepartmentId] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxDepartmentInfoByUserNumEN.OrderNum = objRow[convQxDepartmentInfoByUserNum.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxDepartmentInfoByUserNum.OrderNum].ToString().Trim()); //排序号
objvQxDepartmentInfoByUserNumEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxDepartmentInfoByUserNum.InUse].ToString().Trim()); //是否在用
objvQxDepartmentInfoByUserNumEN.Memo = objRow[convQxDepartmentInfoByUserNum.Memo] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.Memo].ToString().Trim(); //备注
objvQxDepartmentInfoByUserNumEN.UserNum = objRow[convQxDepartmentInfoByUserNum.UserNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxDepartmentInfoByUserNum.UserNum].ToString().Trim()); //用户数
objvQxDepartmentInfoByUserNumEN.UpDepartmentName = objRow[convQxDepartmentInfoByUserNum.UpDepartmentName] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.UpDepartmentName].ToString().Trim(); //上级部门
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxDepartmentInfoByUserNumEN.DepartmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxDepartmentInfoByUserNumEN);
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
List<clsvQxDepartmentInfoByUserNumEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvQxDepartmentInfoByUserNumEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxDepartmentInfoByUserNumEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvQxDepartmentInfoByUserNumEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvQxDepartmentInfoByUserNumEN> arrObjLst = new List<clsvQxDepartmentInfoByUserNumEN>(); 
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
	clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN = new clsvQxDepartmentInfoByUserNumEN();
try
{
objvQxDepartmentInfoByUserNumEN.DepartmentId = objRow[convQxDepartmentInfoByUserNum.DepartmentId].ToString().Trim(); //部门Id
objvQxDepartmentInfoByUserNumEN.DepartmentName = objRow[convQxDepartmentInfoByUserNum.DepartmentName].ToString().Trim(); //部门名
objvQxDepartmentInfoByUserNumEN.DepartmentAbbrName = objRow[convQxDepartmentInfoByUserNum.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxDepartmentInfoByUserNumEN.DepartmentTypeId = objRow[convQxDepartmentInfoByUserNum.DepartmentTypeId] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxDepartmentInfoByUserNumEN.DepartmentTypeName = objRow[convQxDepartmentInfoByUserNum.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxDepartmentInfoByUserNumEN.UpDepartmentId = objRow[convQxDepartmentInfoByUserNum.UpDepartmentId] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxDepartmentInfoByUserNumEN.OrderNum = objRow[convQxDepartmentInfoByUserNum.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxDepartmentInfoByUserNum.OrderNum].ToString().Trim()); //排序号
objvQxDepartmentInfoByUserNumEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxDepartmentInfoByUserNum.InUse].ToString().Trim()); //是否在用
objvQxDepartmentInfoByUserNumEN.Memo = objRow[convQxDepartmentInfoByUserNum.Memo] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.Memo].ToString().Trim(); //备注
objvQxDepartmentInfoByUserNumEN.UserNum = objRow[convQxDepartmentInfoByUserNum.UserNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxDepartmentInfoByUserNum.UserNum].ToString().Trim()); //用户数
objvQxDepartmentInfoByUserNumEN.UpDepartmentName = objRow[convQxDepartmentInfoByUserNum.UpDepartmentName] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.UpDepartmentName].ToString().Trim(); //上级部门
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxDepartmentInfoByUserNumEN.DepartmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxDepartmentInfoByUserNumEN);
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
public static List<clsvQxDepartmentInfoByUserNumEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvQxDepartmentInfoByUserNumEN> arrObjLst = new List<clsvQxDepartmentInfoByUserNumEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN = new clsvQxDepartmentInfoByUserNumEN();
try
{
objvQxDepartmentInfoByUserNumEN.DepartmentId = objRow[convQxDepartmentInfoByUserNum.DepartmentId].ToString().Trim(); //部门Id
objvQxDepartmentInfoByUserNumEN.DepartmentName = objRow[convQxDepartmentInfoByUserNum.DepartmentName].ToString().Trim(); //部门名
objvQxDepartmentInfoByUserNumEN.DepartmentAbbrName = objRow[convQxDepartmentInfoByUserNum.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxDepartmentInfoByUserNumEN.DepartmentTypeId = objRow[convQxDepartmentInfoByUserNum.DepartmentTypeId] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxDepartmentInfoByUserNumEN.DepartmentTypeName = objRow[convQxDepartmentInfoByUserNum.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxDepartmentInfoByUserNumEN.UpDepartmentId = objRow[convQxDepartmentInfoByUserNum.UpDepartmentId] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxDepartmentInfoByUserNumEN.OrderNum = objRow[convQxDepartmentInfoByUserNum.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxDepartmentInfoByUserNum.OrderNum].ToString().Trim()); //排序号
objvQxDepartmentInfoByUserNumEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxDepartmentInfoByUserNum.InUse].ToString().Trim()); //是否在用
objvQxDepartmentInfoByUserNumEN.Memo = objRow[convQxDepartmentInfoByUserNum.Memo] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.Memo].ToString().Trim(); //备注
objvQxDepartmentInfoByUserNumEN.UserNum = objRow[convQxDepartmentInfoByUserNum.UserNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxDepartmentInfoByUserNum.UserNum].ToString().Trim()); //用户数
objvQxDepartmentInfoByUserNumEN.UpDepartmentName = objRow[convQxDepartmentInfoByUserNum.UpDepartmentName] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.UpDepartmentName].ToString().Trim(); //上级部门
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxDepartmentInfoByUserNumEN.DepartmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxDepartmentInfoByUserNumEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQxDepartmentInfoByUserNumEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvQxDepartmentInfoByUserNumEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvQxDepartmentInfoByUserNumEN> arrObjLst = new List<clsvQxDepartmentInfoByUserNumEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN = new clsvQxDepartmentInfoByUserNumEN();
try
{
objvQxDepartmentInfoByUserNumEN.DepartmentId = objRow[convQxDepartmentInfoByUserNum.DepartmentId].ToString().Trim(); //部门Id
objvQxDepartmentInfoByUserNumEN.DepartmentName = objRow[convQxDepartmentInfoByUserNum.DepartmentName].ToString().Trim(); //部门名
objvQxDepartmentInfoByUserNumEN.DepartmentAbbrName = objRow[convQxDepartmentInfoByUserNum.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxDepartmentInfoByUserNumEN.DepartmentTypeId = objRow[convQxDepartmentInfoByUserNum.DepartmentTypeId] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxDepartmentInfoByUserNumEN.DepartmentTypeName = objRow[convQxDepartmentInfoByUserNum.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxDepartmentInfoByUserNumEN.UpDepartmentId = objRow[convQxDepartmentInfoByUserNum.UpDepartmentId] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxDepartmentInfoByUserNumEN.OrderNum = objRow[convQxDepartmentInfoByUserNum.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxDepartmentInfoByUserNum.OrderNum].ToString().Trim()); //排序号
objvQxDepartmentInfoByUserNumEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxDepartmentInfoByUserNum.InUse].ToString().Trim()); //是否在用
objvQxDepartmentInfoByUserNumEN.Memo = objRow[convQxDepartmentInfoByUserNum.Memo] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.Memo].ToString().Trim(); //备注
objvQxDepartmentInfoByUserNumEN.UserNum = objRow[convQxDepartmentInfoByUserNum.UserNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxDepartmentInfoByUserNum.UserNum].ToString().Trim()); //用户数
objvQxDepartmentInfoByUserNumEN.UpDepartmentName = objRow[convQxDepartmentInfoByUserNum.UpDepartmentName] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.UpDepartmentName].ToString().Trim(); //上级部门
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxDepartmentInfoByUserNumEN.DepartmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxDepartmentInfoByUserNumEN);
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
public static List<clsvQxDepartmentInfoByUserNumEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvQxDepartmentInfoByUserNumEN> arrObjLst = new List<clsvQxDepartmentInfoByUserNumEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN = new clsvQxDepartmentInfoByUserNumEN();
try
{
objvQxDepartmentInfoByUserNumEN.DepartmentId = objRow[convQxDepartmentInfoByUserNum.DepartmentId].ToString().Trim(); //部门Id
objvQxDepartmentInfoByUserNumEN.DepartmentName = objRow[convQxDepartmentInfoByUserNum.DepartmentName].ToString().Trim(); //部门名
objvQxDepartmentInfoByUserNumEN.DepartmentAbbrName = objRow[convQxDepartmentInfoByUserNum.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxDepartmentInfoByUserNumEN.DepartmentTypeId = objRow[convQxDepartmentInfoByUserNum.DepartmentTypeId] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxDepartmentInfoByUserNumEN.DepartmentTypeName = objRow[convQxDepartmentInfoByUserNum.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxDepartmentInfoByUserNumEN.UpDepartmentId = objRow[convQxDepartmentInfoByUserNum.UpDepartmentId] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxDepartmentInfoByUserNumEN.OrderNum = objRow[convQxDepartmentInfoByUserNum.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxDepartmentInfoByUserNum.OrderNum].ToString().Trim()); //排序号
objvQxDepartmentInfoByUserNumEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxDepartmentInfoByUserNum.InUse].ToString().Trim()); //是否在用
objvQxDepartmentInfoByUserNumEN.Memo = objRow[convQxDepartmentInfoByUserNum.Memo] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.Memo].ToString().Trim(); //备注
objvQxDepartmentInfoByUserNumEN.UserNum = objRow[convQxDepartmentInfoByUserNum.UserNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxDepartmentInfoByUserNum.UserNum].ToString().Trim()); //用户数
objvQxDepartmentInfoByUserNumEN.UpDepartmentName = objRow[convQxDepartmentInfoByUserNum.UpDepartmentName] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.UpDepartmentName].ToString().Trim(); //上级部门
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxDepartmentInfoByUserNumEN.DepartmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxDepartmentInfoByUserNumEN);
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
public static IEnumerable<clsvQxDepartmentInfoByUserNumEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumCond, string strOrderBy)
{
List<clsvQxDepartmentInfoByUserNumEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxDepartmentInfoByUserNumEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxDepartmentInfoByUserNum.AttributeName)
{
if (objvQxDepartmentInfoByUserNumCond.IsUpdated(strFldName) == false) continue;
if (objvQxDepartmentInfoByUserNumCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxDepartmentInfoByUserNumCond[strFldName].ToString());
}
else
{
if (objvQxDepartmentInfoByUserNumCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxDepartmentInfoByUserNumCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxDepartmentInfoByUserNumCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxDepartmentInfoByUserNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxDepartmentInfoByUserNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxDepartmentInfoByUserNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxDepartmentInfoByUserNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxDepartmentInfoByUserNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxDepartmentInfoByUserNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxDepartmentInfoByUserNumCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxDepartmentInfoByUserNumCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxDepartmentInfoByUserNumCond[strFldName]));
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
public static IEnumerable<clsvQxDepartmentInfoByUserNumEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumCond = JsonConvert.DeserializeObject<clsvQxDepartmentInfoByUserNumEN>(objPagerPara.whereCond);
if (objvQxDepartmentInfoByUserNumCond.sfFldComparisonOp == null)
{
objvQxDepartmentInfoByUserNumCond.dicFldComparisonOp = null;
}
else
{
objvQxDepartmentInfoByUserNumCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objvQxDepartmentInfoByUserNumCond.sfFldComparisonOp);
}
clsvQxDepartmentInfoByUserNumBL.SetUpdFlag(objvQxDepartmentInfoByUserNumCond);
 try
{
CheckProperty4Condition(objvQxDepartmentInfoByUserNumCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsvQxDepartmentInfoByUserNumBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objvQxDepartmentInfoByUserNumCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxDepartmentInfoByUserNumEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsvQxDepartmentInfoByUserNumEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxDepartmentInfoByUserNumEN> arrObjLst = new List<clsvQxDepartmentInfoByUserNumEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN = new clsvQxDepartmentInfoByUserNumEN();
try
{
objvQxDepartmentInfoByUserNumEN.DepartmentId = objRow[convQxDepartmentInfoByUserNum.DepartmentId].ToString().Trim(); //部门Id
objvQxDepartmentInfoByUserNumEN.DepartmentName = objRow[convQxDepartmentInfoByUserNum.DepartmentName].ToString().Trim(); //部门名
objvQxDepartmentInfoByUserNumEN.DepartmentAbbrName = objRow[convQxDepartmentInfoByUserNum.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxDepartmentInfoByUserNumEN.DepartmentTypeId = objRow[convQxDepartmentInfoByUserNum.DepartmentTypeId] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxDepartmentInfoByUserNumEN.DepartmentTypeName = objRow[convQxDepartmentInfoByUserNum.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxDepartmentInfoByUserNumEN.UpDepartmentId = objRow[convQxDepartmentInfoByUserNum.UpDepartmentId] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxDepartmentInfoByUserNumEN.OrderNum = objRow[convQxDepartmentInfoByUserNum.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxDepartmentInfoByUserNum.OrderNum].ToString().Trim()); //排序号
objvQxDepartmentInfoByUserNumEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxDepartmentInfoByUserNum.InUse].ToString().Trim()); //是否在用
objvQxDepartmentInfoByUserNumEN.Memo = objRow[convQxDepartmentInfoByUserNum.Memo] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.Memo].ToString().Trim(); //备注
objvQxDepartmentInfoByUserNumEN.UserNum = objRow[convQxDepartmentInfoByUserNum.UserNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxDepartmentInfoByUserNum.UserNum].ToString().Trim()); //用户数
objvQxDepartmentInfoByUserNumEN.UpDepartmentName = objRow[convQxDepartmentInfoByUserNum.UpDepartmentName] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.UpDepartmentName].ToString().Trim(); //上级部门
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxDepartmentInfoByUserNumEN.DepartmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxDepartmentInfoByUserNumEN);
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
public static List<clsvQxDepartmentInfoByUserNumEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxDepartmentInfoByUserNumEN> arrObjLst = new List<clsvQxDepartmentInfoByUserNumEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN = new clsvQxDepartmentInfoByUserNumEN();
try
{
objvQxDepartmentInfoByUserNumEN.DepartmentId = objRow[convQxDepartmentInfoByUserNum.DepartmentId].ToString().Trim(); //部门Id
objvQxDepartmentInfoByUserNumEN.DepartmentName = objRow[convQxDepartmentInfoByUserNum.DepartmentName].ToString().Trim(); //部门名
objvQxDepartmentInfoByUserNumEN.DepartmentAbbrName = objRow[convQxDepartmentInfoByUserNum.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxDepartmentInfoByUserNumEN.DepartmentTypeId = objRow[convQxDepartmentInfoByUserNum.DepartmentTypeId] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxDepartmentInfoByUserNumEN.DepartmentTypeName = objRow[convQxDepartmentInfoByUserNum.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxDepartmentInfoByUserNumEN.UpDepartmentId = objRow[convQxDepartmentInfoByUserNum.UpDepartmentId] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxDepartmentInfoByUserNumEN.OrderNum = objRow[convQxDepartmentInfoByUserNum.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxDepartmentInfoByUserNum.OrderNum].ToString().Trim()); //排序号
objvQxDepartmentInfoByUserNumEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxDepartmentInfoByUserNum.InUse].ToString().Trim()); //是否在用
objvQxDepartmentInfoByUserNumEN.Memo = objRow[convQxDepartmentInfoByUserNum.Memo] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.Memo].ToString().Trim(); //备注
objvQxDepartmentInfoByUserNumEN.UserNum = objRow[convQxDepartmentInfoByUserNum.UserNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxDepartmentInfoByUserNum.UserNum].ToString().Trim()); //用户数
objvQxDepartmentInfoByUserNumEN.UpDepartmentName = objRow[convQxDepartmentInfoByUserNum.UpDepartmentName] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.UpDepartmentName].ToString().Trim(); //上级部门
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxDepartmentInfoByUserNumEN.DepartmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxDepartmentInfoByUserNumEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxDepartmentInfoByUserNumEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvQxDepartmentInfoByUserNumEN> arrObjLst = new List<clsvQxDepartmentInfoByUserNumEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN = new clsvQxDepartmentInfoByUserNumEN();
try
{
objvQxDepartmentInfoByUserNumEN.DepartmentId = objRow[convQxDepartmentInfoByUserNum.DepartmentId].ToString().Trim(); //部门Id
objvQxDepartmentInfoByUserNumEN.DepartmentName = objRow[convQxDepartmentInfoByUserNum.DepartmentName].ToString().Trim(); //部门名
objvQxDepartmentInfoByUserNumEN.DepartmentAbbrName = objRow[convQxDepartmentInfoByUserNum.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxDepartmentInfoByUserNumEN.DepartmentTypeId = objRow[convQxDepartmentInfoByUserNum.DepartmentTypeId] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxDepartmentInfoByUserNumEN.DepartmentTypeName = objRow[convQxDepartmentInfoByUserNum.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxDepartmentInfoByUserNumEN.UpDepartmentId = objRow[convQxDepartmentInfoByUserNum.UpDepartmentId] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxDepartmentInfoByUserNumEN.OrderNum = objRow[convQxDepartmentInfoByUserNum.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxDepartmentInfoByUserNum.OrderNum].ToString().Trim()); //排序号
objvQxDepartmentInfoByUserNumEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxDepartmentInfoByUserNum.InUse].ToString().Trim()); //是否在用
objvQxDepartmentInfoByUserNumEN.Memo = objRow[convQxDepartmentInfoByUserNum.Memo] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.Memo].ToString().Trim(); //备注
objvQxDepartmentInfoByUserNumEN.UserNum = objRow[convQxDepartmentInfoByUserNum.UserNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxDepartmentInfoByUserNum.UserNum].ToString().Trim()); //用户数
objvQxDepartmentInfoByUserNumEN.UpDepartmentName = objRow[convQxDepartmentInfoByUserNum.UpDepartmentName] == DBNull.Value ? null : objRow[convQxDepartmentInfoByUserNum.UpDepartmentName].ToString().Trim(); //上级部门
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxDepartmentInfoByUserNumEN.DepartmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxDepartmentInfoByUserNumEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoByUserNumEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxDepartmentInfoByUserNum(ref clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN)
{
bool bolResult = vQxDepartmentInfoByUserNumDA.GetvQxDepartmentInfoByUserNum(ref objvQxDepartmentInfoByUserNumEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strDepartmentId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxDepartmentInfoByUserNumEN GetObjByDepartmentId(string strDepartmentId)
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
clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN = vQxDepartmentInfoByUserNumDA.GetObjByDepartmentId(strDepartmentId);
return objvQxDepartmentInfoByUserNumEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvQxDepartmentInfoByUserNumEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN = vQxDepartmentInfoByUserNumDA.GetFirstObj(strWhereCond);
 return objvQxDepartmentInfoByUserNumEN;
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
public static clsvQxDepartmentInfoByUserNumEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN = vQxDepartmentInfoByUserNumDA.GetObjByDataRow(objRow);
 return objvQxDepartmentInfoByUserNumEN;
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
public static clsvQxDepartmentInfoByUserNumEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN = vQxDepartmentInfoByUserNumDA.GetObjByDataRow(objRow);
 return objvQxDepartmentInfoByUserNumEN;
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
 /// <param name = "lstvQxDepartmentInfoByUserNumObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxDepartmentInfoByUserNumEN GetObjByDepartmentIdFromList(string strDepartmentId, List<clsvQxDepartmentInfoByUserNumEN> lstvQxDepartmentInfoByUserNumObjLst)
{
foreach (clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN in lstvQxDepartmentInfoByUserNumObjLst)
{
if (objvQxDepartmentInfoByUserNumEN.DepartmentId == strDepartmentId)
{
return objvQxDepartmentInfoByUserNumEN;
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
 strDepartmentId = new clsvQxDepartmentInfoByUserNumDA().GetFirstID(strWhereCond);
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
 arrList = vQxDepartmentInfoByUserNumDA.GetID(strWhereCond);
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
bool bolIsExist = vQxDepartmentInfoByUserNumDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vQxDepartmentInfoByUserNumDA.IsExist(strDepartmentId);
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
 bolIsExist = clsvQxDepartmentInfoByUserNumDA.IsExistTable();
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
 bolIsExist = vQxDepartmentInfoByUserNumDA.IsExistTable(strTabName);
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
 /// <param name = "objvQxDepartmentInfoByUserNumEN">源简化对象</param>
 public static void SetUpdFlag(clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN)
{
try
{
objvQxDepartmentInfoByUserNumEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvQxDepartmentInfoByUserNumEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convQxDepartmentInfoByUserNum.DepartmentId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxDepartmentInfoByUserNumEN.DepartmentId = objvQxDepartmentInfoByUserNumEN.DepartmentId; //部门Id
}
if (arrFldSet.Contains(convQxDepartmentInfoByUserNum.DepartmentName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxDepartmentInfoByUserNumEN.DepartmentName = objvQxDepartmentInfoByUserNumEN.DepartmentName; //部门名
}
if (arrFldSet.Contains(convQxDepartmentInfoByUserNum.DepartmentAbbrName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxDepartmentInfoByUserNumEN.DepartmentAbbrName = objvQxDepartmentInfoByUserNumEN.DepartmentAbbrName == "[null]" ? null :  objvQxDepartmentInfoByUserNumEN.DepartmentAbbrName; //名称缩写
}
if (arrFldSet.Contains(convQxDepartmentInfoByUserNum.DepartmentTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxDepartmentInfoByUserNumEN.DepartmentTypeId = objvQxDepartmentInfoByUserNumEN.DepartmentTypeId == "[null]" ? null :  objvQxDepartmentInfoByUserNumEN.DepartmentTypeId; //部门类型ID
}
if (arrFldSet.Contains(convQxDepartmentInfoByUserNum.DepartmentTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxDepartmentInfoByUserNumEN.DepartmentTypeName = objvQxDepartmentInfoByUserNumEN.DepartmentTypeName == "[null]" ? null :  objvQxDepartmentInfoByUserNumEN.DepartmentTypeName; //部门类型名
}
if (arrFldSet.Contains(convQxDepartmentInfoByUserNum.UpDepartmentId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxDepartmentInfoByUserNumEN.UpDepartmentId = objvQxDepartmentInfoByUserNumEN.UpDepartmentId == "[null]" ? null :  objvQxDepartmentInfoByUserNumEN.UpDepartmentId; //所属部门号
}
if (arrFldSet.Contains(convQxDepartmentInfoByUserNum.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxDepartmentInfoByUserNumEN.OrderNum = objvQxDepartmentInfoByUserNumEN.OrderNum; //排序号
}
if (arrFldSet.Contains(convQxDepartmentInfoByUserNum.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxDepartmentInfoByUserNumEN.InUse = objvQxDepartmentInfoByUserNumEN.InUse; //是否在用
}
if (arrFldSet.Contains(convQxDepartmentInfoByUserNum.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxDepartmentInfoByUserNumEN.Memo = objvQxDepartmentInfoByUserNumEN.Memo == "[null]" ? null :  objvQxDepartmentInfoByUserNumEN.Memo; //备注
}
if (arrFldSet.Contains(convQxDepartmentInfoByUserNum.UserNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxDepartmentInfoByUserNumEN.UserNum = objvQxDepartmentInfoByUserNumEN.UserNum; //用户数
}
if (arrFldSet.Contains(convQxDepartmentInfoByUserNum.UpDepartmentName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxDepartmentInfoByUserNumEN.UpDepartmentName = objvQxDepartmentInfoByUserNumEN.UpDepartmentName == "[null]" ? null :  objvQxDepartmentInfoByUserNumEN.UpDepartmentName; //上级部门
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
 /// <param name = "objvQxDepartmentInfoByUserNumEN">源简化对象</param>
 public static void AccessFldValueNull(clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN)
{
try
{
if (objvQxDepartmentInfoByUserNumEN.DepartmentAbbrName == "[null]") objvQxDepartmentInfoByUserNumEN.DepartmentAbbrName = null; //名称缩写
if (objvQxDepartmentInfoByUserNumEN.DepartmentTypeId == "[null]") objvQxDepartmentInfoByUserNumEN.DepartmentTypeId = null; //部门类型ID
if (objvQxDepartmentInfoByUserNumEN.DepartmentTypeName == "[null]") objvQxDepartmentInfoByUserNumEN.DepartmentTypeName = null; //部门类型名
if (objvQxDepartmentInfoByUserNumEN.UpDepartmentId == "[null]") objvQxDepartmentInfoByUserNumEN.UpDepartmentId = null; //所属部门号
if (objvQxDepartmentInfoByUserNumEN.Memo == "[null]") objvQxDepartmentInfoByUserNumEN.Memo = null; //备注
if (objvQxDepartmentInfoByUserNumEN.UpDepartmentName == "[null]") objvQxDepartmentInfoByUserNumEN.UpDepartmentName = null; //上级部门
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
public static void CheckProperty4Condition(clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN)
{
 vQxDepartmentInfoByUserNumDA.CheckProperty4Condition(objvQxDepartmentInfoByUserNumEN);
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
string strCondition = string.Format("1 =1 Order By {0}", convQxDepartmentInfoByUserNum.DepartmentId); 
List<clsvQxDepartmentInfoByUserNumEN> arrObjLst = clsvQxDepartmentInfoByUserNumBL.GetObjLst(strCondition);
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
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_DepartmentId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v部门信息By用户数]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convQxDepartmentInfoByUserNum.DepartmentId); 
IEnumerable<clsvQxDepartmentInfoByUserNumEN> arrObjLst = clsvQxDepartmentInfoByUserNumBL.GetObjLst(strCondition);
objDDL.DataValueField = convQxDepartmentInfoByUserNum.DepartmentId;
objDDL.DataTextField = convQxDepartmentInfoByUserNum.DepartmentName;
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v部门信息By用户数]...","0");
List<clsvQxDepartmentInfoByUserNumEN> arrvQxDepartmentInfoByUserNumObjLst = GetAllvQxDepartmentInfoByUserNumObjLstCache(); 
objDDL.DataValueField = convQxDepartmentInfoByUserNum.DepartmentId;
objDDL.DataTextField = convQxDepartmentInfoByUserNum.DepartmentName;
objDDL.DataSource = arrvQxDepartmentInfoByUserNumObjLst;
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
//if (arrvQxDepartmentInfoByUserNumObjLstCache == null)
//{
//arrvQxDepartmentInfoByUserNumObjLstCache = vQxDepartmentInfoByUserNumDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strDepartmentId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxDepartmentInfoByUserNumEN GetObjByDepartmentIdCache(string strDepartmentId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvQxDepartmentInfoByUserNumEN._CurrTabName);
List<clsvQxDepartmentInfoByUserNumEN> arrvQxDepartmentInfoByUserNumObjLstCache = GetObjLstCache();
IEnumerable <clsvQxDepartmentInfoByUserNumEN> arrvQxDepartmentInfoByUserNumObjLst_Sel =
arrvQxDepartmentInfoByUserNumObjLstCache
.Where(x=> x.DepartmentId == strDepartmentId 
);
if (arrvQxDepartmentInfoByUserNumObjLst_Sel.Count() == 0)
{
   clsvQxDepartmentInfoByUserNumEN obj = clsvQxDepartmentInfoByUserNumBL.GetObjByDepartmentId(strDepartmentId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvQxDepartmentInfoByUserNumObjLst_Sel.First();
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
clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNum = GetObjByDepartmentIdCache(strDepartmentId);
if (objvQxDepartmentInfoByUserNum == null) return "";
return objvQxDepartmentInfoByUserNum.DepartmentName;
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
clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNum = GetObjByDepartmentIdCache(strDepartmentId);
if (objvQxDepartmentInfoByUserNum == null) return "";
return objvQxDepartmentInfoByUserNum.DepartmentName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxDepartmentInfoByUserNumEN> GetAllvQxDepartmentInfoByUserNumObjLstCache()
{
//获取缓存中的对象列表
List<clsvQxDepartmentInfoByUserNumEN> arrvQxDepartmentInfoByUserNumObjLstCache = GetObjLstCache(); 
return arrvQxDepartmentInfoByUserNumObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxDepartmentInfoByUserNumEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvQxDepartmentInfoByUserNumEN._CurrTabName);
List<clsvQxDepartmentInfoByUserNumEN> arrvQxDepartmentInfoByUserNumObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQxDepartmentInfoByUserNumObjLstCache;
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


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstvQxDepartmentInfoByUserNumObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsvQxDepartmentInfoByUserNumEN> lstvQxDepartmentInfoByUserNumObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstvQxDepartmentInfoByUserNumObjLst, writer);
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
 /// <param name = "lstvQxDepartmentInfoByUserNumObjLst">[clsvQxDepartmentInfoByUserNumEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsvQxDepartmentInfoByUserNumEN> lstvQxDepartmentInfoByUserNumObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsvQxDepartmentInfoByUserNumBL.listXmlNode);
writer.WriteStartElement(clsvQxDepartmentInfoByUserNumBL.itemsXmlNode);
foreach (clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN in lstvQxDepartmentInfoByUserNumObjLst)
{
clsvQxDepartmentInfoByUserNumBL.SerializeXML(writer, objvQxDepartmentInfoByUserNumEN);
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
 /// <param name = "objvQxDepartmentInfoByUserNumEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN)
{
writer.WriteStartElement(clsvQxDepartmentInfoByUserNumBL.itemXmlNode);
 
if (objvQxDepartmentInfoByUserNumEN.DepartmentId != null)
{
writer.WriteElementString(convQxDepartmentInfoByUserNum.DepartmentId, objvQxDepartmentInfoByUserNumEN.DepartmentId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxDepartmentInfoByUserNumEN.DepartmentName != null)
{
writer.WriteElementString(convQxDepartmentInfoByUserNum.DepartmentName, objvQxDepartmentInfoByUserNumEN.DepartmentName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxDepartmentInfoByUserNumEN.DepartmentAbbrName != null)
{
writer.WriteElementString(convQxDepartmentInfoByUserNum.DepartmentAbbrName, objvQxDepartmentInfoByUserNumEN.DepartmentAbbrName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxDepartmentInfoByUserNumEN.DepartmentTypeId != null)
{
writer.WriteElementString(convQxDepartmentInfoByUserNum.DepartmentTypeId, objvQxDepartmentInfoByUserNumEN.DepartmentTypeId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxDepartmentInfoByUserNumEN.DepartmentTypeName != null)
{
writer.WriteElementString(convQxDepartmentInfoByUserNum.DepartmentTypeName, objvQxDepartmentInfoByUserNumEN.DepartmentTypeName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxDepartmentInfoByUserNumEN.UpDepartmentId != null)
{
writer.WriteElementString(convQxDepartmentInfoByUserNum.UpDepartmentId, objvQxDepartmentInfoByUserNumEN.UpDepartmentId.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convQxDepartmentInfoByUserNum.OrderNum, objvQxDepartmentInfoByUserNumEN.OrderNum.ToString());
 
writer.WriteElementString(convQxDepartmentInfoByUserNum.InUse, objvQxDepartmentInfoByUserNumEN.InUse.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objvQxDepartmentInfoByUserNumEN.Memo != null)
{
writer.WriteElementString(convQxDepartmentInfoByUserNum.Memo, objvQxDepartmentInfoByUserNumEN.Memo.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convQxDepartmentInfoByUserNum.UserNum, objvQxDepartmentInfoByUserNumEN.UserNum.ToString());
 
if (objvQxDepartmentInfoByUserNumEN.UpDepartmentName != null)
{
writer.WriteElementString(convQxDepartmentInfoByUserNum.UpDepartmentName, objvQxDepartmentInfoByUserNumEN.UpDepartmentName.ToString(CultureInfo.InvariantCulture));
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
public static clsvQxDepartmentInfoByUserNumEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN = new clsvQxDepartmentInfoByUserNumEN();
reader.Read();
while (!(reader.Name == clsvQxDepartmentInfoByUserNumBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(convQxDepartmentInfoByUserNum.DepartmentId))
{
objvQxDepartmentInfoByUserNumEN.DepartmentId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxDepartmentInfoByUserNum.DepartmentName))
{
objvQxDepartmentInfoByUserNumEN.DepartmentName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxDepartmentInfoByUserNum.DepartmentAbbrName))
{
objvQxDepartmentInfoByUserNumEN.DepartmentAbbrName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxDepartmentInfoByUserNum.DepartmentTypeId))
{
objvQxDepartmentInfoByUserNumEN.DepartmentTypeId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxDepartmentInfoByUserNum.DepartmentTypeName))
{
objvQxDepartmentInfoByUserNumEN.DepartmentTypeName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxDepartmentInfoByUserNum.UpDepartmentId))
{
objvQxDepartmentInfoByUserNumEN.UpDepartmentId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxDepartmentInfoByUserNum.OrderNum))
{
objvQxDepartmentInfoByUserNumEN.OrderNum = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(convQxDepartmentInfoByUserNum.InUse))
{
objvQxDepartmentInfoByUserNumEN.InUse = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(convQxDepartmentInfoByUserNum.Memo))
{
objvQxDepartmentInfoByUserNumEN.Memo = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxDepartmentInfoByUserNum.UserNum))
{
objvQxDepartmentInfoByUserNumEN.UserNum = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(convQxDepartmentInfoByUserNum.UpDepartmentName))
{
objvQxDepartmentInfoByUserNumEN.UpDepartmentName = reader.ReadElementContentAsString();
}
}
return objvQxDepartmentInfoByUserNumEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strvQxDepartmentInfoByUserNumObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsvQxDepartmentInfoByUserNumEN GetObjFromXmlStr(string strvQxDepartmentInfoByUserNumObjXmlStr)
{
clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN = new clsvQxDepartmentInfoByUserNumEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strvQxDepartmentInfoByUserNumObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsvQxDepartmentInfoByUserNumBL.itemXmlNode))
{
objvQxDepartmentInfoByUserNumEN = GetObjFromXml(reader);
return objvQxDepartmentInfoByUserNumEN;
}
}
return objvQxDepartmentInfoByUserNumEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoByUserNumEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objvQxDepartmentInfoByUserNumEN);
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
if (strInFldName != convQxDepartmentInfoByUserNum.DepartmentId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convQxDepartmentInfoByUserNum.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convQxDepartmentInfoByUserNum.AttributeName));
throw new Exception(strMsg);
}
var objvQxDepartmentInfoByUserNum = clsvQxDepartmentInfoByUserNumBL.GetObjByDepartmentIdCache(strDepartmentId);
if (objvQxDepartmentInfoByUserNum == null) return "";
return objvQxDepartmentInfoByUserNum[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoByUserNumEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsvQxDepartmentInfoByUserNumEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objvQxDepartmentInfoByUserNumEN[strField]);
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
 /// <param name = "lstvQxDepartmentInfoByUserNumObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsvQxDepartmentInfoByUserNumEN> lstvQxDepartmentInfoByUserNumObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstvQxDepartmentInfoByUserNumObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN in lstvQxDepartmentInfoByUserNumObjLst)
{
string strJSON_One = SerializeObjToJSON(objvQxDepartmentInfoByUserNumEN);
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
int intRecCount = clsvQxDepartmentInfoByUserNumDA.GetRecCount(strTabName);
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
int intRecCount = clsvQxDepartmentInfoByUserNumDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvQxDepartmentInfoByUserNumDA.GetRecCount();
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
int intRecCount = clsvQxDepartmentInfoByUserNumDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoByUserNumCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumCond)
{
List<clsvQxDepartmentInfoByUserNumEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxDepartmentInfoByUserNumEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxDepartmentInfoByUserNum.AttributeName)
{
if (objvQxDepartmentInfoByUserNumCond.IsUpdated(strFldName) == false) continue;
if (objvQxDepartmentInfoByUserNumCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxDepartmentInfoByUserNumCond[strFldName].ToString());
}
else
{
if (objvQxDepartmentInfoByUserNumCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxDepartmentInfoByUserNumCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxDepartmentInfoByUserNumCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxDepartmentInfoByUserNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxDepartmentInfoByUserNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxDepartmentInfoByUserNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxDepartmentInfoByUserNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxDepartmentInfoByUserNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxDepartmentInfoByUserNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxDepartmentInfoByUserNumCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxDepartmentInfoByUserNumCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxDepartmentInfoByUserNumCond[strFldName]));
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
 List<string> arrList = clsvQxDepartmentInfoByUserNumDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vQxDepartmentInfoByUserNumDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vQxDepartmentInfoByUserNumDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}