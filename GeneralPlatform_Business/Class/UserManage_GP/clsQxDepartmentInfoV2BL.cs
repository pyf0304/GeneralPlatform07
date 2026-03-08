
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxDepartmentInfoV2BL
 表名:QxDepartmentInfoV2(00140111)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:27:09
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
public static class  clsQxDepartmentInfoV2BL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "intDepartmentIdInt">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxDepartmentInfoV2EN GetObj(this K_DepartmentIdInt_QxDepartmentInfoV2 myKey)
{
clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN = clsQxDepartmentInfoV2BL.QxDepartmentInfoV2DA.GetObjByDepartmentIdInt(myKey.Value);
return objQxDepartmentInfoV2EN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQxDepartmentInfoV2EN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN)
{
if (CheckUniqueness(objQxDepartmentInfoV2EN) == false)
{
var strMsg = string.Format("记录已经存在!部门名 = [{0}]的数据已经存在!(in clsQxDepartmentInfoV2BL.AddNewRecord)", objQxDepartmentInfoV2EN.DepartmentName);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsQxDepartmentInfoV2BL.QxDepartmentInfoV2DA.AddNewRecordBySQL2(objQxDepartmentInfoV2EN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxDepartmentInfoV2BL.ReFreshCache();

if (clsQxDepartmentInfoV2BL.relatedActions != null)
{
clsQxDepartmentInfoV2BL.relatedActions.UpdRelaTabDate(objQxDepartmentInfoV2EN.DepartmentIdInt, "SetUpdDate");
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
public static bool AddRecordEx(this clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
try
{
 //2、检查传进去的对象属性是否合法
objQxDepartmentInfoV2EN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objQxDepartmentInfoV2EN.CheckUniqueness() == false)
{
strMsg = string.Format("(部门名(DepartmentName)=[{0}])已经存在,不能重复!", objQxDepartmentInfoV2EN.DepartmentName);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objQxDepartmentInfoV2EN.AddNewRecord();
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
 /// <param name = "objQxDepartmentInfoV2EN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN)
{
if (CheckUniqueness(objQxDepartmentInfoV2EN) == false)
{
var strMsg = string.Format("记录已经存在!部门名 = [{0}]的数据已经存在!(in clsQxDepartmentInfoV2BL.AddNewRecordWithReturnKey)", objQxDepartmentInfoV2EN.DepartmentName);
throw new Exception(strMsg);
}
try
{
string strKey = clsQxDepartmentInfoV2BL.QxDepartmentInfoV2DA.AddNewRecordBySQL2WithReturnKey(objQxDepartmentInfoV2EN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxDepartmentInfoV2BL.ReFreshCache();

if (clsQxDepartmentInfoV2BL.relatedActions != null)
{
clsQxDepartmentInfoV2BL.relatedActions.UpdRelaTabDate(objQxDepartmentInfoV2EN.DepartmentIdInt, "SetUpdDate");
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
 /// <param name = "objQxDepartmentInfoV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxDepartmentInfoV2EN SetDepartmentIdInt(this clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN, int intDepartmentIdInt, string strComparisonOp="")
	{
objQxDepartmentInfoV2EN.DepartmentIdInt = intDepartmentIdInt; //部门Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxDepartmentInfoV2EN.dicFldComparisonOp.ContainsKey(conQxDepartmentInfoV2.DepartmentIdInt) == false)
{
objQxDepartmentInfoV2EN.dicFldComparisonOp.Add(conQxDepartmentInfoV2.DepartmentIdInt, strComparisonOp);
}
else
{
objQxDepartmentInfoV2EN.dicFldComparisonOp[conQxDepartmentInfoV2.DepartmentIdInt] = strComparisonOp;
}
}
return objQxDepartmentInfoV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxDepartmentInfoV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxDepartmentInfoV2EN SetDepartmentName(this clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN, string strDepartmentName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentName, conQxDepartmentInfoV2.DepartmentName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentName, 100, conQxDepartmentInfoV2.DepartmentName);
}
objQxDepartmentInfoV2EN.DepartmentName = strDepartmentName; //部门名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxDepartmentInfoV2EN.dicFldComparisonOp.ContainsKey(conQxDepartmentInfoV2.DepartmentName) == false)
{
objQxDepartmentInfoV2EN.dicFldComparisonOp.Add(conQxDepartmentInfoV2.DepartmentName, strComparisonOp);
}
else
{
objQxDepartmentInfoV2EN.dicFldComparisonOp[conQxDepartmentInfoV2.DepartmentName] = strComparisonOp;
}
}
return objQxDepartmentInfoV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxDepartmentInfoV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxDepartmentInfoV2EN SetDepartmentAbbrName(this clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN, string strDepartmentAbbrName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentAbbrName, 8, conQxDepartmentInfoV2.DepartmentAbbrName);
}
objQxDepartmentInfoV2EN.DepartmentAbbrName = strDepartmentAbbrName; //名称缩写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxDepartmentInfoV2EN.dicFldComparisonOp.ContainsKey(conQxDepartmentInfoV2.DepartmentAbbrName) == false)
{
objQxDepartmentInfoV2EN.dicFldComparisonOp.Add(conQxDepartmentInfoV2.DepartmentAbbrName, strComparisonOp);
}
else
{
objQxDepartmentInfoV2EN.dicFldComparisonOp[conQxDepartmentInfoV2.DepartmentAbbrName] = strComparisonOp;
}
}
return objQxDepartmentInfoV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxDepartmentInfoV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxDepartmentInfoV2EN SetDepartmentTypeId(this clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN, string strDepartmentTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentTypeId, 2, conQxDepartmentInfoV2.DepartmentTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDepartmentTypeId, 2, conQxDepartmentInfoV2.DepartmentTypeId);
}
objQxDepartmentInfoV2EN.DepartmentTypeId = strDepartmentTypeId; //部门类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxDepartmentInfoV2EN.dicFldComparisonOp.ContainsKey(conQxDepartmentInfoV2.DepartmentTypeId) == false)
{
objQxDepartmentInfoV2EN.dicFldComparisonOp.Add(conQxDepartmentInfoV2.DepartmentTypeId, strComparisonOp);
}
else
{
objQxDepartmentInfoV2EN.dicFldComparisonOp[conQxDepartmentInfoV2.DepartmentTypeId] = strComparisonOp;
}
}
return objQxDepartmentInfoV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxDepartmentInfoV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxDepartmentInfoV2EN SetparentDepId(this clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN, int? intparentDepId, string strComparisonOp="")
	{
objQxDepartmentInfoV2EN.parentDepId = intparentDepId; //所属部门号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxDepartmentInfoV2EN.dicFldComparisonOp.ContainsKey(conQxDepartmentInfoV2.parentDepId) == false)
{
objQxDepartmentInfoV2EN.dicFldComparisonOp.Add(conQxDepartmentInfoV2.parentDepId, strComparisonOp);
}
else
{
objQxDepartmentInfoV2EN.dicFldComparisonOp[conQxDepartmentInfoV2.parentDepId] = strComparisonOp;
}
}
return objQxDepartmentInfoV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxDepartmentInfoV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxDepartmentInfoV2EN SetOrderNum(this clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN, int? intOrderNum, string strComparisonOp="")
	{
objQxDepartmentInfoV2EN.OrderNum = intOrderNum; //排序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxDepartmentInfoV2EN.dicFldComparisonOp.ContainsKey(conQxDepartmentInfoV2.OrderNum) == false)
{
objQxDepartmentInfoV2EN.dicFldComparisonOp.Add(conQxDepartmentInfoV2.OrderNum, strComparisonOp);
}
else
{
objQxDepartmentInfoV2EN.dicFldComparisonOp[conQxDepartmentInfoV2.OrderNum] = strComparisonOp;
}
}
return objQxDepartmentInfoV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxDepartmentInfoV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxDepartmentInfoV2EN SetInUse(this clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN, bool bolInUse, string strComparisonOp="")
	{
objQxDepartmentInfoV2EN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxDepartmentInfoV2EN.dicFldComparisonOp.ContainsKey(conQxDepartmentInfoV2.InUse) == false)
{
objQxDepartmentInfoV2EN.dicFldComparisonOp.Add(conQxDepartmentInfoV2.InUse, strComparisonOp);
}
else
{
objQxDepartmentInfoV2EN.dicFldComparisonOp[conQxDepartmentInfoV2.InUse] = strComparisonOp;
}
}
return objQxDepartmentInfoV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxDepartmentInfoV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxDepartmentInfoV2EN SetMemo(this clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQxDepartmentInfoV2.Memo);
}
objQxDepartmentInfoV2EN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxDepartmentInfoV2EN.dicFldComparisonOp.ContainsKey(conQxDepartmentInfoV2.Memo) == false)
{
objQxDepartmentInfoV2EN.dicFldComparisonOp.Add(conQxDepartmentInfoV2.Memo, strComparisonOp);
}
else
{
objQxDepartmentInfoV2EN.dicFldComparisonOp[conQxDepartmentInfoV2.Memo] = strComparisonOp;
}
}
return objQxDepartmentInfoV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxDepartmentInfoV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxDepartmentInfoV2EN SetCreateTime(this clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN, string strCreateTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateTime, 20, conQxDepartmentInfoV2.CreateTime);
}
objQxDepartmentInfoV2EN.CreateTime = strCreateTime; //建立时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxDepartmentInfoV2EN.dicFldComparisonOp.ContainsKey(conQxDepartmentInfoV2.CreateTime) == false)
{
objQxDepartmentInfoV2EN.dicFldComparisonOp.Add(conQxDepartmentInfoV2.CreateTime, strComparisonOp);
}
else
{
objQxDepartmentInfoV2EN.dicFldComparisonOp[conQxDepartmentInfoV2.CreateTime] = strComparisonOp;
}
}
return objQxDepartmentInfoV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxDepartmentInfoV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxDepartmentInfoV2EN SetupdateTime(this clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN, string strupdateTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strupdateTime, 20, conQxDepartmentInfoV2.updateTime);
}
objQxDepartmentInfoV2EN.updateTime = strupdateTime; //修改时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxDepartmentInfoV2EN.dicFldComparisonOp.ContainsKey(conQxDepartmentInfoV2.updateTime) == false)
{
objQxDepartmentInfoV2EN.dicFldComparisonOp.Add(conQxDepartmentInfoV2.updateTime, strComparisonOp);
}
else
{
objQxDepartmentInfoV2EN.dicFldComparisonOp[conQxDepartmentInfoV2.updateTime] = strComparisonOp;
}
}
return objQxDepartmentInfoV2EN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objQxDepartmentInfoV2EN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objQxDepartmentInfoV2EN.CheckPropertyNew();
clsQxDepartmentInfoV2EN objQxDepartmentInfoV2Cond = new clsQxDepartmentInfoV2EN();
string strCondition = objQxDepartmentInfoV2Cond
.SetDepartmentIdInt(objQxDepartmentInfoV2EN.DepartmentIdInt, "<>")
.SetDepartmentName(objQxDepartmentInfoV2EN.DepartmentName, "=")
.GetCombineCondition();
objQxDepartmentInfoV2EN._IsCheckProperty = true;
bool bolIsExist = clsQxDepartmentInfoV2BL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(DepartmentName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objQxDepartmentInfoV2EN.Update();
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
 /// <param name = "objQxDepartmentInfoV2">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsQxDepartmentInfoV2EN objQxDepartmentInfoV2)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsQxDepartmentInfoV2EN objQxDepartmentInfoV2Cond = new clsQxDepartmentInfoV2EN();
string strCondition = objQxDepartmentInfoV2Cond
.SetDepartmentName(objQxDepartmentInfoV2.DepartmentName, "=")
.GetCombineCondition();
objQxDepartmentInfoV2._IsCheckProperty = true;
bool bolIsExist = clsQxDepartmentInfoV2BL.IsExistRecord(strCondition);
if (bolIsExist)
{
objQxDepartmentInfoV2.DepartmentIdInt = clsQxDepartmentInfoV2BL.GetFirstID_S(strCondition);
objQxDepartmentInfoV2.UpdateWithCondition(strCondition);
}
else
{
objQxDepartmentInfoV2.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objQxDepartmentInfoV2EN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN)
{
 if (objQxDepartmentInfoV2EN.DepartmentIdInt == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxDepartmentInfoV2BL.QxDepartmentInfoV2DA.UpdateBySql2(objQxDepartmentInfoV2EN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxDepartmentInfoV2BL.ReFreshCache();

if (clsQxDepartmentInfoV2BL.relatedActions != null)
{
clsQxDepartmentInfoV2BL.relatedActions.UpdRelaTabDate(objQxDepartmentInfoV2EN.DepartmentIdInt, "SetUpdDate");
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
 /// <param name = "objQxDepartmentInfoV2EN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objQxDepartmentInfoV2EN.DepartmentIdInt == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxDepartmentInfoV2BL.QxDepartmentInfoV2DA.UpdateBySql2(objQxDepartmentInfoV2EN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxDepartmentInfoV2BL.ReFreshCache();

if (clsQxDepartmentInfoV2BL.relatedActions != null)
{
clsQxDepartmentInfoV2BL.relatedActions.UpdRelaTabDate(objQxDepartmentInfoV2EN.DepartmentIdInt, "SetUpdDate");
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
 /// <param name = "objQxDepartmentInfoV2EN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN, string strWhereCond)
{
try
{
bool bolResult = clsQxDepartmentInfoV2BL.QxDepartmentInfoV2DA.UpdateBySqlWithCondition(objQxDepartmentInfoV2EN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxDepartmentInfoV2BL.ReFreshCache();

if (clsQxDepartmentInfoV2BL.relatedActions != null)
{
clsQxDepartmentInfoV2BL.relatedActions.UpdRelaTabDate(objQxDepartmentInfoV2EN.DepartmentIdInt, "SetUpdDate");
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
 /// <param name = "objQxDepartmentInfoV2EN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsQxDepartmentInfoV2BL.QxDepartmentInfoV2DA.UpdateBySqlWithConditionTransaction(objQxDepartmentInfoV2EN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxDepartmentInfoV2BL.ReFreshCache();

if (clsQxDepartmentInfoV2BL.relatedActions != null)
{
clsQxDepartmentInfoV2BL.relatedActions.UpdRelaTabDate(objQxDepartmentInfoV2EN.DepartmentIdInt, "SetUpdDate");
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
 /// <param name = "intDepartmentIdInt">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN)
{
try
{
int intRecNum = clsQxDepartmentInfoV2BL.QxDepartmentInfoV2DA.DelRecord(objQxDepartmentInfoV2EN.DepartmentIdInt);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxDepartmentInfoV2BL.ReFreshCache();

if (clsQxDepartmentInfoV2BL.relatedActions != null)
{
clsQxDepartmentInfoV2BL.relatedActions.UpdRelaTabDate(objQxDepartmentInfoV2EN.DepartmentIdInt, "SetUpdDate");
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
 /// <param name = "objQxDepartmentInfoV2ENS">源对象</param>
 /// <param name = "objQxDepartmentInfoV2ENT">目标对象</param>
 public static void CopyTo(this clsQxDepartmentInfoV2EN objQxDepartmentInfoV2ENS, clsQxDepartmentInfoV2EN objQxDepartmentInfoV2ENT)
{
try
{
objQxDepartmentInfoV2ENT.DepartmentIdInt = objQxDepartmentInfoV2ENS.DepartmentIdInt; //部门Id
objQxDepartmentInfoV2ENT.DepartmentName = objQxDepartmentInfoV2ENS.DepartmentName; //部门名
objQxDepartmentInfoV2ENT.DepartmentAbbrName = objQxDepartmentInfoV2ENS.DepartmentAbbrName; //名称缩写
objQxDepartmentInfoV2ENT.DepartmentTypeId = objQxDepartmentInfoV2ENS.DepartmentTypeId; //部门类型ID
objQxDepartmentInfoV2ENT.parentDepId = objQxDepartmentInfoV2ENS.parentDepId; //所属部门号
objQxDepartmentInfoV2ENT.OrderNum = objQxDepartmentInfoV2ENS.OrderNum; //排序号
objQxDepartmentInfoV2ENT.InUse = objQxDepartmentInfoV2ENS.InUse; //是否在用
objQxDepartmentInfoV2ENT.Memo = objQxDepartmentInfoV2ENS.Memo; //备注
objQxDepartmentInfoV2ENT.CreateTime = objQxDepartmentInfoV2ENS.CreateTime; //建立时间
objQxDepartmentInfoV2ENT.updateTime = objQxDepartmentInfoV2ENS.updateTime; //修改时间
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
 /// <param name = "objQxDepartmentInfoV2ENS">源对象</param>
 /// <returns>目标对象=>clsQxDepartmentInfoV2EN:objQxDepartmentInfoV2ENT</returns>
 public static clsQxDepartmentInfoV2EN CopyTo(this clsQxDepartmentInfoV2EN objQxDepartmentInfoV2ENS)
{
try
{
 clsQxDepartmentInfoV2EN objQxDepartmentInfoV2ENT = new clsQxDepartmentInfoV2EN()
{
DepartmentIdInt = objQxDepartmentInfoV2ENS.DepartmentIdInt, //部门Id
DepartmentName = objQxDepartmentInfoV2ENS.DepartmentName, //部门名
DepartmentAbbrName = objQxDepartmentInfoV2ENS.DepartmentAbbrName, //名称缩写
DepartmentTypeId = objQxDepartmentInfoV2ENS.DepartmentTypeId, //部门类型ID
parentDepId = objQxDepartmentInfoV2ENS.parentDepId, //所属部门号
OrderNum = objQxDepartmentInfoV2ENS.OrderNum, //排序号
InUse = objQxDepartmentInfoV2ENS.InUse, //是否在用
Memo = objQxDepartmentInfoV2ENS.Memo, //备注
CreateTime = objQxDepartmentInfoV2ENS.CreateTime, //建立时间
updateTime = objQxDepartmentInfoV2ENS.updateTime, //修改时间
};
 return objQxDepartmentInfoV2ENT;
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
public static void CheckPropertyNew(this clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN)
{
 clsQxDepartmentInfoV2BL.QxDepartmentInfoV2DA.CheckPropertyNew(objQxDepartmentInfoV2EN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN)
{
 clsQxDepartmentInfoV2BL.QxDepartmentInfoV2DA.CheckProperty4Condition(objQxDepartmentInfoV2EN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQxDepartmentInfoV2EN objQxDepartmentInfoV2Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQxDepartmentInfoV2Cond.IsUpdated(conQxDepartmentInfoV2.DepartmentIdInt) == true)
{
string strComparisonOpDepartmentIdInt = objQxDepartmentInfoV2Cond.dicFldComparisonOp[conQxDepartmentInfoV2.DepartmentIdInt];
strWhereCond += string.Format(" And {0} {2} {1}", conQxDepartmentInfoV2.DepartmentIdInt, objQxDepartmentInfoV2Cond.DepartmentIdInt, strComparisonOpDepartmentIdInt);
}
if (objQxDepartmentInfoV2Cond.IsUpdated(conQxDepartmentInfoV2.DepartmentName) == true)
{
string strComparisonOpDepartmentName = objQxDepartmentInfoV2Cond.dicFldComparisonOp[conQxDepartmentInfoV2.DepartmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxDepartmentInfoV2.DepartmentName, objQxDepartmentInfoV2Cond.DepartmentName, strComparisonOpDepartmentName);
}
if (objQxDepartmentInfoV2Cond.IsUpdated(conQxDepartmentInfoV2.DepartmentAbbrName) == true)
{
string strComparisonOpDepartmentAbbrName = objQxDepartmentInfoV2Cond.dicFldComparisonOp[conQxDepartmentInfoV2.DepartmentAbbrName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxDepartmentInfoV2.DepartmentAbbrName, objQxDepartmentInfoV2Cond.DepartmentAbbrName, strComparisonOpDepartmentAbbrName);
}
if (objQxDepartmentInfoV2Cond.IsUpdated(conQxDepartmentInfoV2.DepartmentTypeId) == true)
{
string strComparisonOpDepartmentTypeId = objQxDepartmentInfoV2Cond.dicFldComparisonOp[conQxDepartmentInfoV2.DepartmentTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxDepartmentInfoV2.DepartmentTypeId, objQxDepartmentInfoV2Cond.DepartmentTypeId, strComparisonOpDepartmentTypeId);
}
if (objQxDepartmentInfoV2Cond.IsUpdated(conQxDepartmentInfoV2.parentDepId) == true)
{
string strComparisonOpparentDepId = objQxDepartmentInfoV2Cond.dicFldComparisonOp[conQxDepartmentInfoV2.parentDepId];
strWhereCond += string.Format(" And {0} {2} {1}", conQxDepartmentInfoV2.parentDepId, objQxDepartmentInfoV2Cond.parentDepId, strComparisonOpparentDepId);
}
if (objQxDepartmentInfoV2Cond.IsUpdated(conQxDepartmentInfoV2.OrderNum) == true)
{
string strComparisonOpOrderNum = objQxDepartmentInfoV2Cond.dicFldComparisonOp[conQxDepartmentInfoV2.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conQxDepartmentInfoV2.OrderNum, objQxDepartmentInfoV2Cond.OrderNum, strComparisonOpOrderNum);
}
if (objQxDepartmentInfoV2Cond.IsUpdated(conQxDepartmentInfoV2.InUse) == true)
{
if (objQxDepartmentInfoV2Cond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQxDepartmentInfoV2.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQxDepartmentInfoV2.InUse);
}
}
if (objQxDepartmentInfoV2Cond.IsUpdated(conQxDepartmentInfoV2.Memo) == true)
{
string strComparisonOpMemo = objQxDepartmentInfoV2Cond.dicFldComparisonOp[conQxDepartmentInfoV2.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxDepartmentInfoV2.Memo, objQxDepartmentInfoV2Cond.Memo, strComparisonOpMemo);
}
if (objQxDepartmentInfoV2Cond.IsUpdated(conQxDepartmentInfoV2.CreateTime) == true)
{
string strComparisonOpCreateTime = objQxDepartmentInfoV2Cond.dicFldComparisonOp[conQxDepartmentInfoV2.CreateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxDepartmentInfoV2.CreateTime, objQxDepartmentInfoV2Cond.CreateTime, strComparisonOpCreateTime);
}
if (objQxDepartmentInfoV2Cond.IsUpdated(conQxDepartmentInfoV2.updateTime) == true)
{
string strComparisonOpupdateTime = objQxDepartmentInfoV2Cond.dicFldComparisonOp[conQxDepartmentInfoV2.updateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxDepartmentInfoV2.updateTime, objQxDepartmentInfoV2Cond.updateTime, strComparisonOpupdateTime);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--QxDepartmentInfoV2(部门V2), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:DepartmentName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objQxDepartmentInfoV2EN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objQxDepartmentInfoV2EN == null) return true;
if (objQxDepartmentInfoV2EN.DepartmentIdInt == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and DepartmentName = '{0}'", objQxDepartmentInfoV2EN.DepartmentName);
if (clsQxDepartmentInfoV2BL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("DepartmentIdInt !=  {0}", objQxDepartmentInfoV2EN.DepartmentIdInt);
 sbCondition.AppendFormat(" and DepartmentName = '{0}'", objQxDepartmentInfoV2EN.DepartmentName);
if (clsQxDepartmentInfoV2BL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--QxDepartmentInfoV2(部门V2), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:DepartmentName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objQxDepartmentInfoV2EN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objQxDepartmentInfoV2EN == null) return "";
if (objQxDepartmentInfoV2EN.DepartmentIdInt == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and DepartmentName = '{0}'", objQxDepartmentInfoV2EN.DepartmentName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("DepartmentIdInt !=  {0}", objQxDepartmentInfoV2EN.DepartmentIdInt);
 sbCondition.AppendFormat(" and DepartmentName = '{0}'", objQxDepartmentInfoV2EN.DepartmentName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_QxDepartmentInfoV2
{
public virtual bool UpdRelaTabDate(int intDepartmentIdInt, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 部门V2(QxDepartmentInfoV2)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsQxDepartmentInfoV2BL
{
public static RelatedActions_QxDepartmentInfoV2 relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "QxDepartmentInfoV2ListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "QxDepartmentInfoV2List";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsQxDepartmentInfoV2EN> arrQxDepartmentInfoV2ObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsQxDepartmentInfoV2DA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsQxDepartmentInfoV2DA QxDepartmentInfoV2DA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsQxDepartmentInfoV2DA();
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
 public clsQxDepartmentInfoV2BL()
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
if (string.IsNullOrEmpty(clsQxDepartmentInfoV2EN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxDepartmentInfoV2EN._ConnectString);
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
objDS = QxDepartmentInfoV2DA.GetDataSet(strWhereCond);
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
objDS = QxDepartmentInfoV2DA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = QxDepartmentInfoV2DA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_QxDepartmentInfoV2(string strWhereCond)
{
DataTable objDT;
try
{
objDT = QxDepartmentInfoV2DA.GetDataTable_QxDepartmentInfoV2(strWhereCond);
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
objDT = QxDepartmentInfoV2DA.GetDataTable(strWhereCond);
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
objDT = QxDepartmentInfoV2DA.GetDataTable(strWhereCond, lstExclude);
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
objDT = QxDepartmentInfoV2DA.GetDataTable(strWhereCond, strTabName);
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
objDT = QxDepartmentInfoV2DA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = QxDepartmentInfoV2DA.GetDataTable_Top(objTopPara);
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
objDT = QxDepartmentInfoV2DA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = QxDepartmentInfoV2DA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = QxDepartmentInfoV2DA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = QxDepartmentInfoV2DA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = QxDepartmentInfoV2DA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = QxDepartmentInfoV2DA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = QxDepartmentInfoV2DA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = QxDepartmentInfoV2DA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
 /// <param name = "arrDepartmentIdIntLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsQxDepartmentInfoV2EN> GetObjLstByDepartmentIdIntLst(List<int> arrDepartmentIdIntLst)
{
List<clsQxDepartmentInfoV2EN> arrObjLst = new List<clsQxDepartmentInfoV2EN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrDepartmentIdIntLst);
 string strWhereCond = string.Format("DepartmentIdInt in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN = new clsQxDepartmentInfoV2EN();
try
{
objQxDepartmentInfoV2EN.DepartmentIdInt = Int32.Parse(objRow[conQxDepartmentInfoV2.DepartmentIdInt].ToString().Trim()); //部门Id
objQxDepartmentInfoV2EN.DepartmentName = objRow[conQxDepartmentInfoV2.DepartmentName].ToString().Trim(); //部门名
objQxDepartmentInfoV2EN.DepartmentAbbrName = objRow[conQxDepartmentInfoV2.DepartmentAbbrName] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.DepartmentAbbrName].ToString().Trim(); //名称缩写
objQxDepartmentInfoV2EN.DepartmentTypeId = objRow[conQxDepartmentInfoV2.DepartmentTypeId] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.DepartmentTypeId].ToString().Trim(); //部门类型ID
objQxDepartmentInfoV2EN.parentDepId = objRow[conQxDepartmentInfoV2.parentDepId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxDepartmentInfoV2.parentDepId].ToString().Trim()); //所属部门号
objQxDepartmentInfoV2EN.OrderNum = objRow[conQxDepartmentInfoV2.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxDepartmentInfoV2.OrderNum].ToString().Trim()); //排序号
objQxDepartmentInfoV2EN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxDepartmentInfoV2.InUse].ToString().Trim()); //是否在用
objQxDepartmentInfoV2EN.Memo = objRow[conQxDepartmentInfoV2.Memo] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.Memo].ToString().Trim(); //备注
objQxDepartmentInfoV2EN.CreateTime = objRow[conQxDepartmentInfoV2.CreateTime] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.CreateTime].ToString().Trim(); //建立时间
objQxDepartmentInfoV2EN.updateTime = objRow[conQxDepartmentInfoV2.updateTime] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.updateTime].ToString().Trim(); //修改时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxDepartmentInfoV2EN.DepartmentIdInt, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxDepartmentInfoV2EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrDepartmentIdIntLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsQxDepartmentInfoV2EN> GetObjLstByDepartmentIdIntLstCache(List<int> arrDepartmentIdIntLst)
{
string strKey = string.Format("{0}", clsQxDepartmentInfoV2EN._CurrTabName);
List<clsQxDepartmentInfoV2EN> arrQxDepartmentInfoV2ObjLstCache = GetObjLstCache();
IEnumerable <clsQxDepartmentInfoV2EN> arrQxDepartmentInfoV2ObjLst_Sel =
arrQxDepartmentInfoV2ObjLstCache
.Where(x => arrDepartmentIdIntLst.Contains(x.DepartmentIdInt));
return arrQxDepartmentInfoV2ObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxDepartmentInfoV2EN> GetObjLst(string strWhereCond)
{
List<clsQxDepartmentInfoV2EN> arrObjLst = new List<clsQxDepartmentInfoV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN = new clsQxDepartmentInfoV2EN();
try
{
objQxDepartmentInfoV2EN.DepartmentIdInt = Int32.Parse(objRow[conQxDepartmentInfoV2.DepartmentIdInt].ToString().Trim()); //部门Id
objQxDepartmentInfoV2EN.DepartmentName = objRow[conQxDepartmentInfoV2.DepartmentName].ToString().Trim(); //部门名
objQxDepartmentInfoV2EN.DepartmentAbbrName = objRow[conQxDepartmentInfoV2.DepartmentAbbrName] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.DepartmentAbbrName].ToString().Trim(); //名称缩写
objQxDepartmentInfoV2EN.DepartmentTypeId = objRow[conQxDepartmentInfoV2.DepartmentTypeId] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.DepartmentTypeId].ToString().Trim(); //部门类型ID
objQxDepartmentInfoV2EN.parentDepId = objRow[conQxDepartmentInfoV2.parentDepId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxDepartmentInfoV2.parentDepId].ToString().Trim()); //所属部门号
objQxDepartmentInfoV2EN.OrderNum = objRow[conQxDepartmentInfoV2.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxDepartmentInfoV2.OrderNum].ToString().Trim()); //排序号
objQxDepartmentInfoV2EN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxDepartmentInfoV2.InUse].ToString().Trim()); //是否在用
objQxDepartmentInfoV2EN.Memo = objRow[conQxDepartmentInfoV2.Memo] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.Memo].ToString().Trim(); //备注
objQxDepartmentInfoV2EN.CreateTime = objRow[conQxDepartmentInfoV2.CreateTime] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.CreateTime].ToString().Trim(); //建立时间
objQxDepartmentInfoV2EN.updateTime = objRow[conQxDepartmentInfoV2.updateTime] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.updateTime].ToString().Trim(); //修改时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxDepartmentInfoV2EN.DepartmentIdInt, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxDepartmentInfoV2EN);
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
public static List<clsQxDepartmentInfoV2EN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsQxDepartmentInfoV2EN> arrObjLst = new List<clsQxDepartmentInfoV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN = new clsQxDepartmentInfoV2EN();
try
{
objQxDepartmentInfoV2EN.DepartmentIdInt = Int32.Parse(objRow[conQxDepartmentInfoV2.DepartmentIdInt].ToString().Trim()); //部门Id
objQxDepartmentInfoV2EN.DepartmentName = objRow[conQxDepartmentInfoV2.DepartmentName].ToString().Trim(); //部门名
objQxDepartmentInfoV2EN.DepartmentAbbrName = objRow[conQxDepartmentInfoV2.DepartmentAbbrName] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.DepartmentAbbrName].ToString().Trim(); //名称缩写
objQxDepartmentInfoV2EN.DepartmentTypeId = objRow[conQxDepartmentInfoV2.DepartmentTypeId] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.DepartmentTypeId].ToString().Trim(); //部门类型ID
objQxDepartmentInfoV2EN.parentDepId = objRow[conQxDepartmentInfoV2.parentDepId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxDepartmentInfoV2.parentDepId].ToString().Trim()); //所属部门号
objQxDepartmentInfoV2EN.OrderNum = objRow[conQxDepartmentInfoV2.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxDepartmentInfoV2.OrderNum].ToString().Trim()); //排序号
objQxDepartmentInfoV2EN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxDepartmentInfoV2.InUse].ToString().Trim()); //是否在用
objQxDepartmentInfoV2EN.Memo = objRow[conQxDepartmentInfoV2.Memo] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.Memo].ToString().Trim(); //备注
objQxDepartmentInfoV2EN.CreateTime = objRow[conQxDepartmentInfoV2.CreateTime] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.CreateTime].ToString().Trim(); //建立时间
objQxDepartmentInfoV2EN.updateTime = objRow[conQxDepartmentInfoV2.updateTime] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.updateTime].ToString().Trim(); //修改时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxDepartmentInfoV2EN.DepartmentIdInt, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxDepartmentInfoV2EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objQxDepartmentInfoV2Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsQxDepartmentInfoV2EN> GetSubObjLstCache(clsQxDepartmentInfoV2EN objQxDepartmentInfoV2Cond)
{
List<clsQxDepartmentInfoV2EN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxDepartmentInfoV2EN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxDepartmentInfoV2.AttributeName)
{
if (objQxDepartmentInfoV2Cond.IsUpdated(strFldName) == false) continue;
if (objQxDepartmentInfoV2Cond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxDepartmentInfoV2Cond[strFldName].ToString());
}
else
{
if (objQxDepartmentInfoV2Cond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxDepartmentInfoV2Cond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxDepartmentInfoV2Cond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxDepartmentInfoV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxDepartmentInfoV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxDepartmentInfoV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxDepartmentInfoV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxDepartmentInfoV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxDepartmentInfoV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxDepartmentInfoV2Cond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxDepartmentInfoV2Cond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxDepartmentInfoV2Cond[strFldName]));
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
public static List<clsQxDepartmentInfoV2EN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsQxDepartmentInfoV2EN> arrObjLst = new List<clsQxDepartmentInfoV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN = new clsQxDepartmentInfoV2EN();
try
{
objQxDepartmentInfoV2EN.DepartmentIdInt = Int32.Parse(objRow[conQxDepartmentInfoV2.DepartmentIdInt].ToString().Trim()); //部门Id
objQxDepartmentInfoV2EN.DepartmentName = objRow[conQxDepartmentInfoV2.DepartmentName].ToString().Trim(); //部门名
objQxDepartmentInfoV2EN.DepartmentAbbrName = objRow[conQxDepartmentInfoV2.DepartmentAbbrName] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.DepartmentAbbrName].ToString().Trim(); //名称缩写
objQxDepartmentInfoV2EN.DepartmentTypeId = objRow[conQxDepartmentInfoV2.DepartmentTypeId] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.DepartmentTypeId].ToString().Trim(); //部门类型ID
objQxDepartmentInfoV2EN.parentDepId = objRow[conQxDepartmentInfoV2.parentDepId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxDepartmentInfoV2.parentDepId].ToString().Trim()); //所属部门号
objQxDepartmentInfoV2EN.OrderNum = objRow[conQxDepartmentInfoV2.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxDepartmentInfoV2.OrderNum].ToString().Trim()); //排序号
objQxDepartmentInfoV2EN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxDepartmentInfoV2.InUse].ToString().Trim()); //是否在用
objQxDepartmentInfoV2EN.Memo = objRow[conQxDepartmentInfoV2.Memo] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.Memo].ToString().Trim(); //备注
objQxDepartmentInfoV2EN.CreateTime = objRow[conQxDepartmentInfoV2.CreateTime] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.CreateTime].ToString().Trim(); //建立时间
objQxDepartmentInfoV2EN.updateTime = objRow[conQxDepartmentInfoV2.updateTime] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.updateTime].ToString().Trim(); //修改时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxDepartmentInfoV2EN.DepartmentIdInt, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxDepartmentInfoV2EN);
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
public static List<clsQxDepartmentInfoV2EN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsQxDepartmentInfoV2EN> arrObjLst = new List<clsQxDepartmentInfoV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN = new clsQxDepartmentInfoV2EN();
try
{
objQxDepartmentInfoV2EN.DepartmentIdInt = Int32.Parse(objRow[conQxDepartmentInfoV2.DepartmentIdInt].ToString().Trim()); //部门Id
objQxDepartmentInfoV2EN.DepartmentName = objRow[conQxDepartmentInfoV2.DepartmentName].ToString().Trim(); //部门名
objQxDepartmentInfoV2EN.DepartmentAbbrName = objRow[conQxDepartmentInfoV2.DepartmentAbbrName] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.DepartmentAbbrName].ToString().Trim(); //名称缩写
objQxDepartmentInfoV2EN.DepartmentTypeId = objRow[conQxDepartmentInfoV2.DepartmentTypeId] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.DepartmentTypeId].ToString().Trim(); //部门类型ID
objQxDepartmentInfoV2EN.parentDepId = objRow[conQxDepartmentInfoV2.parentDepId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxDepartmentInfoV2.parentDepId].ToString().Trim()); //所属部门号
objQxDepartmentInfoV2EN.OrderNum = objRow[conQxDepartmentInfoV2.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxDepartmentInfoV2.OrderNum].ToString().Trim()); //排序号
objQxDepartmentInfoV2EN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxDepartmentInfoV2.InUse].ToString().Trim()); //是否在用
objQxDepartmentInfoV2EN.Memo = objRow[conQxDepartmentInfoV2.Memo] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.Memo].ToString().Trim(); //备注
objQxDepartmentInfoV2EN.CreateTime = objRow[conQxDepartmentInfoV2.CreateTime] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.CreateTime].ToString().Trim(); //建立时间
objQxDepartmentInfoV2EN.updateTime = objRow[conQxDepartmentInfoV2.updateTime] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.updateTime].ToString().Trim(); //修改时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxDepartmentInfoV2EN.DepartmentIdInt, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxDepartmentInfoV2EN);
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
List<clsQxDepartmentInfoV2EN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsQxDepartmentInfoV2EN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxDepartmentInfoV2EN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsQxDepartmentInfoV2EN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsQxDepartmentInfoV2EN> arrObjLst = new List<clsQxDepartmentInfoV2EN>(); 
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
	clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN = new clsQxDepartmentInfoV2EN();
try
{
objQxDepartmentInfoV2EN.DepartmentIdInt = Int32.Parse(objRow[conQxDepartmentInfoV2.DepartmentIdInt].ToString().Trim()); //部门Id
objQxDepartmentInfoV2EN.DepartmentName = objRow[conQxDepartmentInfoV2.DepartmentName].ToString().Trim(); //部门名
objQxDepartmentInfoV2EN.DepartmentAbbrName = objRow[conQxDepartmentInfoV2.DepartmentAbbrName] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.DepartmentAbbrName].ToString().Trim(); //名称缩写
objQxDepartmentInfoV2EN.DepartmentTypeId = objRow[conQxDepartmentInfoV2.DepartmentTypeId] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.DepartmentTypeId].ToString().Trim(); //部门类型ID
objQxDepartmentInfoV2EN.parentDepId = objRow[conQxDepartmentInfoV2.parentDepId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxDepartmentInfoV2.parentDepId].ToString().Trim()); //所属部门号
objQxDepartmentInfoV2EN.OrderNum = objRow[conQxDepartmentInfoV2.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxDepartmentInfoV2.OrderNum].ToString().Trim()); //排序号
objQxDepartmentInfoV2EN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxDepartmentInfoV2.InUse].ToString().Trim()); //是否在用
objQxDepartmentInfoV2EN.Memo = objRow[conQxDepartmentInfoV2.Memo] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.Memo].ToString().Trim(); //备注
objQxDepartmentInfoV2EN.CreateTime = objRow[conQxDepartmentInfoV2.CreateTime] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.CreateTime].ToString().Trim(); //建立时间
objQxDepartmentInfoV2EN.updateTime = objRow[conQxDepartmentInfoV2.updateTime] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.updateTime].ToString().Trim(); //修改时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxDepartmentInfoV2EN.DepartmentIdInt, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxDepartmentInfoV2EN);
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
public static List<clsQxDepartmentInfoV2EN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsQxDepartmentInfoV2EN> arrObjLst = new List<clsQxDepartmentInfoV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN = new clsQxDepartmentInfoV2EN();
try
{
objQxDepartmentInfoV2EN.DepartmentIdInt = Int32.Parse(objRow[conQxDepartmentInfoV2.DepartmentIdInt].ToString().Trim()); //部门Id
objQxDepartmentInfoV2EN.DepartmentName = objRow[conQxDepartmentInfoV2.DepartmentName].ToString().Trim(); //部门名
objQxDepartmentInfoV2EN.DepartmentAbbrName = objRow[conQxDepartmentInfoV2.DepartmentAbbrName] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.DepartmentAbbrName].ToString().Trim(); //名称缩写
objQxDepartmentInfoV2EN.DepartmentTypeId = objRow[conQxDepartmentInfoV2.DepartmentTypeId] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.DepartmentTypeId].ToString().Trim(); //部门类型ID
objQxDepartmentInfoV2EN.parentDepId = objRow[conQxDepartmentInfoV2.parentDepId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxDepartmentInfoV2.parentDepId].ToString().Trim()); //所属部门号
objQxDepartmentInfoV2EN.OrderNum = objRow[conQxDepartmentInfoV2.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxDepartmentInfoV2.OrderNum].ToString().Trim()); //排序号
objQxDepartmentInfoV2EN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxDepartmentInfoV2.InUse].ToString().Trim()); //是否在用
objQxDepartmentInfoV2EN.Memo = objRow[conQxDepartmentInfoV2.Memo] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.Memo].ToString().Trim(); //备注
objQxDepartmentInfoV2EN.CreateTime = objRow[conQxDepartmentInfoV2.CreateTime] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.CreateTime].ToString().Trim(); //建立时间
objQxDepartmentInfoV2EN.updateTime = objRow[conQxDepartmentInfoV2.updateTime] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.updateTime].ToString().Trim(); //修改时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxDepartmentInfoV2EN.DepartmentIdInt, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxDepartmentInfoV2EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsQxDepartmentInfoV2EN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsQxDepartmentInfoV2EN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsQxDepartmentInfoV2EN> arrObjLst = new List<clsQxDepartmentInfoV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN = new clsQxDepartmentInfoV2EN();
try
{
objQxDepartmentInfoV2EN.DepartmentIdInt = Int32.Parse(objRow[conQxDepartmentInfoV2.DepartmentIdInt].ToString().Trim()); //部门Id
objQxDepartmentInfoV2EN.DepartmentName = objRow[conQxDepartmentInfoV2.DepartmentName].ToString().Trim(); //部门名
objQxDepartmentInfoV2EN.DepartmentAbbrName = objRow[conQxDepartmentInfoV2.DepartmentAbbrName] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.DepartmentAbbrName].ToString().Trim(); //名称缩写
objQxDepartmentInfoV2EN.DepartmentTypeId = objRow[conQxDepartmentInfoV2.DepartmentTypeId] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.DepartmentTypeId].ToString().Trim(); //部门类型ID
objQxDepartmentInfoV2EN.parentDepId = objRow[conQxDepartmentInfoV2.parentDepId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxDepartmentInfoV2.parentDepId].ToString().Trim()); //所属部门号
objQxDepartmentInfoV2EN.OrderNum = objRow[conQxDepartmentInfoV2.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxDepartmentInfoV2.OrderNum].ToString().Trim()); //排序号
objQxDepartmentInfoV2EN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxDepartmentInfoV2.InUse].ToString().Trim()); //是否在用
objQxDepartmentInfoV2EN.Memo = objRow[conQxDepartmentInfoV2.Memo] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.Memo].ToString().Trim(); //备注
objQxDepartmentInfoV2EN.CreateTime = objRow[conQxDepartmentInfoV2.CreateTime] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.CreateTime].ToString().Trim(); //建立时间
objQxDepartmentInfoV2EN.updateTime = objRow[conQxDepartmentInfoV2.updateTime] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.updateTime].ToString().Trim(); //修改时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxDepartmentInfoV2EN.DepartmentIdInt, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxDepartmentInfoV2EN);
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
public static List<clsQxDepartmentInfoV2EN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsQxDepartmentInfoV2EN> arrObjLst = new List<clsQxDepartmentInfoV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN = new clsQxDepartmentInfoV2EN();
try
{
objQxDepartmentInfoV2EN.DepartmentIdInt = Int32.Parse(objRow[conQxDepartmentInfoV2.DepartmentIdInt].ToString().Trim()); //部门Id
objQxDepartmentInfoV2EN.DepartmentName = objRow[conQxDepartmentInfoV2.DepartmentName].ToString().Trim(); //部门名
objQxDepartmentInfoV2EN.DepartmentAbbrName = objRow[conQxDepartmentInfoV2.DepartmentAbbrName] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.DepartmentAbbrName].ToString().Trim(); //名称缩写
objQxDepartmentInfoV2EN.DepartmentTypeId = objRow[conQxDepartmentInfoV2.DepartmentTypeId] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.DepartmentTypeId].ToString().Trim(); //部门类型ID
objQxDepartmentInfoV2EN.parentDepId = objRow[conQxDepartmentInfoV2.parentDepId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxDepartmentInfoV2.parentDepId].ToString().Trim()); //所属部门号
objQxDepartmentInfoV2EN.OrderNum = objRow[conQxDepartmentInfoV2.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxDepartmentInfoV2.OrderNum].ToString().Trim()); //排序号
objQxDepartmentInfoV2EN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxDepartmentInfoV2.InUse].ToString().Trim()); //是否在用
objQxDepartmentInfoV2EN.Memo = objRow[conQxDepartmentInfoV2.Memo] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.Memo].ToString().Trim(); //备注
objQxDepartmentInfoV2EN.CreateTime = objRow[conQxDepartmentInfoV2.CreateTime] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.CreateTime].ToString().Trim(); //建立时间
objQxDepartmentInfoV2EN.updateTime = objRow[conQxDepartmentInfoV2.updateTime] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.updateTime].ToString().Trim(); //修改时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxDepartmentInfoV2EN.DepartmentIdInt, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxDepartmentInfoV2EN);
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
public static IEnumerable<clsQxDepartmentInfoV2EN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsQxDepartmentInfoV2EN objQxDepartmentInfoV2Cond, string strOrderBy)
{
List<clsQxDepartmentInfoV2EN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxDepartmentInfoV2EN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxDepartmentInfoV2.AttributeName)
{
if (objQxDepartmentInfoV2Cond.IsUpdated(strFldName) == false) continue;
if (objQxDepartmentInfoV2Cond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxDepartmentInfoV2Cond[strFldName].ToString());
}
else
{
if (objQxDepartmentInfoV2Cond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxDepartmentInfoV2Cond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxDepartmentInfoV2Cond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxDepartmentInfoV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxDepartmentInfoV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxDepartmentInfoV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxDepartmentInfoV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxDepartmentInfoV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxDepartmentInfoV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxDepartmentInfoV2Cond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxDepartmentInfoV2Cond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxDepartmentInfoV2Cond[strFldName]));
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
public static IEnumerable<clsQxDepartmentInfoV2EN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsQxDepartmentInfoV2EN objQxDepartmentInfoV2Cond = JsonConvert.DeserializeObject<clsQxDepartmentInfoV2EN>(objPagerPara.whereCond);
if (objQxDepartmentInfoV2Cond.sfFldComparisonOp == null)
{
objQxDepartmentInfoV2Cond.dicFldComparisonOp = null;
}
else
{
objQxDepartmentInfoV2Cond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objQxDepartmentInfoV2Cond.sfFldComparisonOp);
}
clsQxDepartmentInfoV2BL.SetUpdFlag(objQxDepartmentInfoV2Cond);
 try
{
CheckProperty4Condition(objQxDepartmentInfoV2Cond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsQxDepartmentInfoV2BL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objQxDepartmentInfoV2Cond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxDepartmentInfoV2EN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsQxDepartmentInfoV2EN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsQxDepartmentInfoV2EN> arrObjLst = new List<clsQxDepartmentInfoV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN = new clsQxDepartmentInfoV2EN();
try
{
objQxDepartmentInfoV2EN.DepartmentIdInt = Int32.Parse(objRow[conQxDepartmentInfoV2.DepartmentIdInt].ToString().Trim()); //部门Id
objQxDepartmentInfoV2EN.DepartmentName = objRow[conQxDepartmentInfoV2.DepartmentName].ToString().Trim(); //部门名
objQxDepartmentInfoV2EN.DepartmentAbbrName = objRow[conQxDepartmentInfoV2.DepartmentAbbrName] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.DepartmentAbbrName].ToString().Trim(); //名称缩写
objQxDepartmentInfoV2EN.DepartmentTypeId = objRow[conQxDepartmentInfoV2.DepartmentTypeId] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.DepartmentTypeId].ToString().Trim(); //部门类型ID
objQxDepartmentInfoV2EN.parentDepId = objRow[conQxDepartmentInfoV2.parentDepId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxDepartmentInfoV2.parentDepId].ToString().Trim()); //所属部门号
objQxDepartmentInfoV2EN.OrderNum = objRow[conQxDepartmentInfoV2.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxDepartmentInfoV2.OrderNum].ToString().Trim()); //排序号
objQxDepartmentInfoV2EN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxDepartmentInfoV2.InUse].ToString().Trim()); //是否在用
objQxDepartmentInfoV2EN.Memo = objRow[conQxDepartmentInfoV2.Memo] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.Memo].ToString().Trim(); //备注
objQxDepartmentInfoV2EN.CreateTime = objRow[conQxDepartmentInfoV2.CreateTime] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.CreateTime].ToString().Trim(); //建立时间
objQxDepartmentInfoV2EN.updateTime = objRow[conQxDepartmentInfoV2.updateTime] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.updateTime].ToString().Trim(); //修改时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxDepartmentInfoV2EN.DepartmentIdInt, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxDepartmentInfoV2EN);
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
public static List<clsQxDepartmentInfoV2EN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsQxDepartmentInfoV2EN> arrObjLst = new List<clsQxDepartmentInfoV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN = new clsQxDepartmentInfoV2EN();
try
{
objQxDepartmentInfoV2EN.DepartmentIdInt = Int32.Parse(objRow[conQxDepartmentInfoV2.DepartmentIdInt].ToString().Trim()); //部门Id
objQxDepartmentInfoV2EN.DepartmentName = objRow[conQxDepartmentInfoV2.DepartmentName].ToString().Trim(); //部门名
objQxDepartmentInfoV2EN.DepartmentAbbrName = objRow[conQxDepartmentInfoV2.DepartmentAbbrName] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.DepartmentAbbrName].ToString().Trim(); //名称缩写
objQxDepartmentInfoV2EN.DepartmentTypeId = objRow[conQxDepartmentInfoV2.DepartmentTypeId] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.DepartmentTypeId].ToString().Trim(); //部门类型ID
objQxDepartmentInfoV2EN.parentDepId = objRow[conQxDepartmentInfoV2.parentDepId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxDepartmentInfoV2.parentDepId].ToString().Trim()); //所属部门号
objQxDepartmentInfoV2EN.OrderNum = objRow[conQxDepartmentInfoV2.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxDepartmentInfoV2.OrderNum].ToString().Trim()); //排序号
objQxDepartmentInfoV2EN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxDepartmentInfoV2.InUse].ToString().Trim()); //是否在用
objQxDepartmentInfoV2EN.Memo = objRow[conQxDepartmentInfoV2.Memo] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.Memo].ToString().Trim(); //备注
objQxDepartmentInfoV2EN.CreateTime = objRow[conQxDepartmentInfoV2.CreateTime] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.CreateTime].ToString().Trim(); //建立时间
objQxDepartmentInfoV2EN.updateTime = objRow[conQxDepartmentInfoV2.updateTime] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.updateTime].ToString().Trim(); //修改时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxDepartmentInfoV2EN.DepartmentIdInt, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxDepartmentInfoV2EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxDepartmentInfoV2EN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsQxDepartmentInfoV2EN> arrObjLst = new List<clsQxDepartmentInfoV2EN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN = new clsQxDepartmentInfoV2EN();
try
{
objQxDepartmentInfoV2EN.DepartmentIdInt = Int32.Parse(objRow[conQxDepartmentInfoV2.DepartmentIdInt].ToString().Trim()); //部门Id
objQxDepartmentInfoV2EN.DepartmentName = objRow[conQxDepartmentInfoV2.DepartmentName].ToString().Trim(); //部门名
objQxDepartmentInfoV2EN.DepartmentAbbrName = objRow[conQxDepartmentInfoV2.DepartmentAbbrName] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.DepartmentAbbrName].ToString().Trim(); //名称缩写
objQxDepartmentInfoV2EN.DepartmentTypeId = objRow[conQxDepartmentInfoV2.DepartmentTypeId] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.DepartmentTypeId].ToString().Trim(); //部门类型ID
objQxDepartmentInfoV2EN.parentDepId = objRow[conQxDepartmentInfoV2.parentDepId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxDepartmentInfoV2.parentDepId].ToString().Trim()); //所属部门号
objQxDepartmentInfoV2EN.OrderNum = objRow[conQxDepartmentInfoV2.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxDepartmentInfoV2.OrderNum].ToString().Trim()); //排序号
objQxDepartmentInfoV2EN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxDepartmentInfoV2.InUse].ToString().Trim()); //是否在用
objQxDepartmentInfoV2EN.Memo = objRow[conQxDepartmentInfoV2.Memo] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.Memo].ToString().Trim(); //备注
objQxDepartmentInfoV2EN.CreateTime = objRow[conQxDepartmentInfoV2.CreateTime] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.CreateTime].ToString().Trim(); //建立时间
objQxDepartmentInfoV2EN.updateTime = objRow[conQxDepartmentInfoV2.updateTime] == DBNull.Value ? null : objRow[conQxDepartmentInfoV2.updateTime].ToString().Trim(); //修改时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxDepartmentInfoV2EN.DepartmentIdInt, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxDepartmentInfoV2EN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objQxDepartmentInfoV2EN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxDepartmentInfoV2(ref clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN)
{
bool bolResult = QxDepartmentInfoV2DA.GetQxDepartmentInfoV2(ref objQxDepartmentInfoV2EN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "intDepartmentIdInt">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxDepartmentInfoV2EN GetObjByDepartmentIdInt(int intDepartmentIdInt)
{
clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN = QxDepartmentInfoV2DA.GetObjByDepartmentIdInt(intDepartmentIdInt);
return objQxDepartmentInfoV2EN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsQxDepartmentInfoV2EN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN = QxDepartmentInfoV2DA.GetFirstObj(strWhereCond);
 return objQxDepartmentInfoV2EN;
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
public static clsQxDepartmentInfoV2EN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN = QxDepartmentInfoV2DA.GetObjByDataRow(objRow);
 return objQxDepartmentInfoV2EN;
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
public static clsQxDepartmentInfoV2EN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN = QxDepartmentInfoV2DA.GetObjByDataRow(objRow);
 return objQxDepartmentInfoV2EN;
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
 /// <param name = "intDepartmentIdInt">所给的关键字</param>
 /// <param name = "lstQxDepartmentInfoV2ObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxDepartmentInfoV2EN GetObjByDepartmentIdIntFromList(int intDepartmentIdInt, List<clsQxDepartmentInfoV2EN> lstQxDepartmentInfoV2ObjLst)
{
foreach (clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN in lstQxDepartmentInfoV2ObjLst)
{
if (objQxDepartmentInfoV2EN.DepartmentIdInt == intDepartmentIdInt)
{
return objQxDepartmentInfoV2EN;
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
public static int GetFirstID_S(string strWhereCond) 
{
 int intDepartmentIdInt;
 try
 {
 intDepartmentIdInt = new clsQxDepartmentInfoV2DA().GetFirstID(strWhereCond);
 return intDepartmentIdInt;
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
 arrList = QxDepartmentInfoV2DA.GetID(strWhereCond);
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
bool bolIsExist = QxDepartmentInfoV2DA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "intDepartmentIdInt">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(int intDepartmentIdInt)
{
//检测记录是否存在
bool bolIsExist = QxDepartmentInfoV2DA.IsExist(intDepartmentIdInt);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "intDepartmentIdInt">部门Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(int intDepartmentIdInt, string strOpUser)
{
clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN = clsQxDepartmentInfoV2BL.GetObjByDepartmentIdInt(intDepartmentIdInt);
objQxDepartmentInfoV2EN.updateTime = clsDateTime.getTodayDateTimeStr(1);
return clsQxDepartmentInfoV2BL.UpdateBySql2(objQxDepartmentInfoV2EN);
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
 bolIsExist = clsQxDepartmentInfoV2DA.IsExistTable();
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
 bolIsExist = QxDepartmentInfoV2DA.IsExistTable(strTabName);
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
 /// <param name = "objQxDepartmentInfoV2EN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN)
{
if (objQxDepartmentInfoV2EN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!部门名 = [{0}]的数据已经存在!(in clsQxDepartmentInfoV2BL.AddNewRecordBySql2)", objQxDepartmentInfoV2EN.DepartmentName);
throw new Exception(strMsg);
}
try
{
bool bolResult = QxDepartmentInfoV2DA.AddNewRecordBySQL2(objQxDepartmentInfoV2EN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxDepartmentInfoV2BL.ReFreshCache();

if (clsQxDepartmentInfoV2BL.relatedActions != null)
{
clsQxDepartmentInfoV2BL.relatedActions.UpdRelaTabDate(objQxDepartmentInfoV2EN.DepartmentIdInt, "SetUpdDate");
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
 /// <param name = "objQxDepartmentInfoV2EN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN)
{
if (objQxDepartmentInfoV2EN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!部门名 = [{0}]的数据已经存在!(in clsQxDepartmentInfoV2BL.AddNewRecordBySql2WithReturnKey)", objQxDepartmentInfoV2EN.DepartmentName);
throw new Exception(strMsg);
}
try
{
string strKey = QxDepartmentInfoV2DA.AddNewRecordBySQL2WithReturnKey(objQxDepartmentInfoV2EN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxDepartmentInfoV2BL.ReFreshCache();

if (clsQxDepartmentInfoV2BL.relatedActions != null)
{
clsQxDepartmentInfoV2BL.relatedActions.UpdRelaTabDate(objQxDepartmentInfoV2EN.DepartmentIdInt, "SetUpdDate");
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
 /// <param name = "strQxDepartmentInfoV2ObjXml">代表实体对象的XML串</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql_XML(string strQxDepartmentInfoV2ObjXml)
{
clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN = GetObjFromXmlStr(strQxDepartmentInfoV2ObjXml);
try
{
bool bolResult = QxDepartmentInfoV2DA.AddNewRecordBySQL2(objQxDepartmentInfoV2EN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxDepartmentInfoV2BL.ReFreshCache();

if (clsQxDepartmentInfoV2BL.relatedActions != null)
{
clsQxDepartmentInfoV2BL.relatedActions.UpdRelaTabDate(objQxDepartmentInfoV2EN.DepartmentIdInt, "SetUpdDate");
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
 /// <param name = "objQxDepartmentInfoV2EN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN)
{
try
{
bool bolResult = QxDepartmentInfoV2DA.Update(objQxDepartmentInfoV2EN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxDepartmentInfoV2BL.ReFreshCache();

if (clsQxDepartmentInfoV2BL.relatedActions != null)
{
clsQxDepartmentInfoV2BL.relatedActions.UpdRelaTabDate(objQxDepartmentInfoV2EN.DepartmentIdInt, "SetUpdDate");
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
 /// <param name = "objQxDepartmentInfoV2EN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN)
{
 if (objQxDepartmentInfoV2EN.DepartmentIdInt == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = QxDepartmentInfoV2DA.UpdateBySql2(objQxDepartmentInfoV2EN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxDepartmentInfoV2BL.ReFreshCache();

if (clsQxDepartmentInfoV2BL.relatedActions != null)
{
clsQxDepartmentInfoV2BL.relatedActions.UpdRelaTabDate(objQxDepartmentInfoV2EN.DepartmentIdInt, "SetUpdDate");
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
 /// <param name = "strQxDepartmentInfoV2ObjXml">需要修改的对象,用XML来表示</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql_XML(string strQxDepartmentInfoV2ObjXml)
{
clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN = GetObjFromXmlStr(strQxDepartmentInfoV2ObjXml);
try
{
bool bolResult = QxDepartmentInfoV2DA.UpdateBySql2(objQxDepartmentInfoV2EN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxDepartmentInfoV2BL.ReFreshCache();

if (clsQxDepartmentInfoV2BL.relatedActions != null)
{
clsQxDepartmentInfoV2BL.relatedActions.UpdRelaTabDate(objQxDepartmentInfoV2EN.DepartmentIdInt, "SetUpdDate");
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
 /// <param name = "intDepartmentIdInt">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(int intDepartmentIdInt)
{
try
{
 clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN = clsQxDepartmentInfoV2BL.GetObjByDepartmentIdInt(intDepartmentIdInt);

if (clsQxDepartmentInfoV2BL.relatedActions != null)
{
clsQxDepartmentInfoV2BL.relatedActions.UpdRelaTabDate(objQxDepartmentInfoV2EN.DepartmentIdInt, "SetUpdDate");
}
if (objQxDepartmentInfoV2EN != null)
{
int intRecNum = QxDepartmentInfoV2DA.DelRecord(intDepartmentIdInt);
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
/// <param name="intDepartmentIdInt">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(int intDepartmentIdInt )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
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
//删除与表:[QxDepartmentInfoV2]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conQxDepartmentInfoV2.DepartmentIdInt,
//intDepartmentIdInt);
//        clsQxDepartmentInfoV2BL.DelQxDepartmentInfoV2sByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxDepartmentInfoV2BL.DelRecord(intDepartmentIdInt, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxDepartmentInfoV2BLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
intDepartmentIdInt, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "intDepartmentIdInt">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(int intDepartmentIdInt, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsQxDepartmentInfoV2BL.relatedActions != null)
{
clsQxDepartmentInfoV2BL.relatedActions.UpdRelaTabDate(intDepartmentIdInt, "UpdRelaTabDate");
}
bool bolResult = QxDepartmentInfoV2DA.DelRecord(intDepartmentIdInt,objSqlConnection,objSqlTransaction);
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
 /// <param name = "intDepartmentIdInt">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(int intDepartmentIdInt) 
{
try
{
if (clsQxDepartmentInfoV2BL.relatedActions != null)
{
clsQxDepartmentInfoV2BL.relatedActions.UpdRelaTabDate(intDepartmentIdInt, "UpdRelaTabDate");
}
bool bolResult = QxDepartmentInfoV2DA.DelRecordBySP(intDepartmentIdInt);
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
 /// <param name = "arrDepartmentIdIntLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelQxDepartmentInfoV2s(List<string> arrDepartmentIdIntLst)
{
if (arrDepartmentIdIntLst.Count == 0) return 0;
try
{
if (clsQxDepartmentInfoV2BL.relatedActions != null)
{
foreach (var strDepartmentIdInt in arrDepartmentIdIntLst)
{
int intDepartmentIdInt = int.Parse(strDepartmentIdInt);
clsQxDepartmentInfoV2BL.relatedActions.UpdRelaTabDate(intDepartmentIdInt, "UpdRelaTabDate");
}
}
int intDelRecNum = QxDepartmentInfoV2DA.DelQxDepartmentInfoV2(arrDepartmentIdIntLst);
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
public static int DelQxDepartmentInfoV2sByCond(string strWhereCond)
{
try
{
if (clsQxDepartmentInfoV2BL.relatedActions != null)
{
List<string> arrDepartmentIdInt = GetPrimaryKeyID_S(strWhereCond);
foreach (var strDepartmentIdInt in arrDepartmentIdInt)
{
int intDepartmentIdInt = int.Parse(strDepartmentIdInt);
clsQxDepartmentInfoV2BL.relatedActions.UpdRelaTabDate(intDepartmentIdInt, "UpdRelaTabDate");
}
}
int intRecNum = QxDepartmentInfoV2DA.DelQxDepartmentInfoV2(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[QxDepartmentInfoV2]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="intDepartmentIdInt">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(int intDepartmentIdInt)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxDepartmentInfoV2DA.GetSpecSQLObj();
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
//删除与表:[QxDepartmentInfoV2]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxDepartmentInfoV2BL.DelRecord(intDepartmentIdInt, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxDepartmentInfoV2BL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
intDepartmentIdInt, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objQxDepartmentInfoV2ENS">源对象</param>
 /// <param name = "objQxDepartmentInfoV2ENT">目标对象</param>
 public static void CopyTo(clsQxDepartmentInfoV2EN objQxDepartmentInfoV2ENS, clsQxDepartmentInfoV2EN objQxDepartmentInfoV2ENT)
{
try
{
objQxDepartmentInfoV2ENT.DepartmentIdInt = objQxDepartmentInfoV2ENS.DepartmentIdInt; //部门Id
objQxDepartmentInfoV2ENT.DepartmentName = objQxDepartmentInfoV2ENS.DepartmentName; //部门名
objQxDepartmentInfoV2ENT.DepartmentAbbrName = objQxDepartmentInfoV2ENS.DepartmentAbbrName; //名称缩写
objQxDepartmentInfoV2ENT.DepartmentTypeId = objQxDepartmentInfoV2ENS.DepartmentTypeId; //部门类型ID
objQxDepartmentInfoV2ENT.parentDepId = objQxDepartmentInfoV2ENS.parentDepId; //所属部门号
objQxDepartmentInfoV2ENT.OrderNum = objQxDepartmentInfoV2ENS.OrderNum; //排序号
objQxDepartmentInfoV2ENT.InUse = objQxDepartmentInfoV2ENS.InUse; //是否在用
objQxDepartmentInfoV2ENT.Memo = objQxDepartmentInfoV2ENS.Memo; //备注
objQxDepartmentInfoV2ENT.CreateTime = objQxDepartmentInfoV2ENS.CreateTime; //建立时间
objQxDepartmentInfoV2ENT.updateTime = objQxDepartmentInfoV2ENS.updateTime; //修改时间
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
 /// <param name = "objQxDepartmentInfoV2EN">源简化对象</param>
 public static void SetUpdFlag(clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN)
{
try
{
objQxDepartmentInfoV2EN.ClearUpdateState();
   string strsfUpdFldSetStr = objQxDepartmentInfoV2EN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conQxDepartmentInfoV2.DepartmentIdInt, new clsStrCompareIgnoreCase())  ==  true)
{
objQxDepartmentInfoV2EN.DepartmentIdInt = objQxDepartmentInfoV2EN.DepartmentIdInt; //部门Id
}
if (arrFldSet.Contains(conQxDepartmentInfoV2.DepartmentName, new clsStrCompareIgnoreCase())  ==  true)
{
objQxDepartmentInfoV2EN.DepartmentName = objQxDepartmentInfoV2EN.DepartmentName; //部门名
}
if (arrFldSet.Contains(conQxDepartmentInfoV2.DepartmentAbbrName, new clsStrCompareIgnoreCase())  ==  true)
{
objQxDepartmentInfoV2EN.DepartmentAbbrName = objQxDepartmentInfoV2EN.DepartmentAbbrName == "[null]" ? null :  objQxDepartmentInfoV2EN.DepartmentAbbrName; //名称缩写
}
if (arrFldSet.Contains(conQxDepartmentInfoV2.DepartmentTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxDepartmentInfoV2EN.DepartmentTypeId = objQxDepartmentInfoV2EN.DepartmentTypeId == "[null]" ? null :  objQxDepartmentInfoV2EN.DepartmentTypeId; //部门类型ID
}
if (arrFldSet.Contains(conQxDepartmentInfoV2.parentDepId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxDepartmentInfoV2EN.parentDepId = objQxDepartmentInfoV2EN.parentDepId; //所属部门号
}
if (arrFldSet.Contains(conQxDepartmentInfoV2.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objQxDepartmentInfoV2EN.OrderNum = objQxDepartmentInfoV2EN.OrderNum; //排序号
}
if (arrFldSet.Contains(conQxDepartmentInfoV2.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objQxDepartmentInfoV2EN.InUse = objQxDepartmentInfoV2EN.InUse; //是否在用
}
if (arrFldSet.Contains(conQxDepartmentInfoV2.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objQxDepartmentInfoV2EN.Memo = objQxDepartmentInfoV2EN.Memo == "[null]" ? null :  objQxDepartmentInfoV2EN.Memo; //备注
}
if (arrFldSet.Contains(conQxDepartmentInfoV2.CreateTime, new clsStrCompareIgnoreCase())  ==  true)
{
objQxDepartmentInfoV2EN.CreateTime = objQxDepartmentInfoV2EN.CreateTime == "[null]" ? null :  objQxDepartmentInfoV2EN.CreateTime; //建立时间
}
if (arrFldSet.Contains(conQxDepartmentInfoV2.updateTime, new clsStrCompareIgnoreCase())  ==  true)
{
objQxDepartmentInfoV2EN.updateTime = objQxDepartmentInfoV2EN.updateTime == "[null]" ? null :  objQxDepartmentInfoV2EN.updateTime; //修改时间
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
 /// <param name = "objQxDepartmentInfoV2EN">源简化对象</param>
 public static void AccessFldValueNull(clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN)
{
try
{
if (objQxDepartmentInfoV2EN.DepartmentAbbrName == "[null]") objQxDepartmentInfoV2EN.DepartmentAbbrName = null; //名称缩写
if (objQxDepartmentInfoV2EN.DepartmentTypeId == "[null]") objQxDepartmentInfoV2EN.DepartmentTypeId = null; //部门类型ID
if (objQxDepartmentInfoV2EN.Memo == "[null]") objQxDepartmentInfoV2EN.Memo = null; //备注
if (objQxDepartmentInfoV2EN.CreateTime == "[null]") objQxDepartmentInfoV2EN.CreateTime = null; //建立时间
if (objQxDepartmentInfoV2EN.updateTime == "[null]") objQxDepartmentInfoV2EN.updateTime = null; //修改时间
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
public static void CheckPropertyNew(clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN)
{
 QxDepartmentInfoV2DA.CheckPropertyNew(objQxDepartmentInfoV2EN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN)
{
 QxDepartmentInfoV2DA.CheckProperty4Condition(objQxDepartmentInfoV2EN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_DepartmentIdIntCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[部门V2]...","0");
List<clsQxDepartmentInfoV2EN> arrQxDepartmentInfoV2ObjLst = GetAllQxDepartmentInfoV2ObjLstCache(); 
arrQxDepartmentInfoV2ObjLst = arrQxDepartmentInfoV2ObjLst.OrderBy(x=>x.OrderNum).ToList(); 
objDDL.DataValueField = conQxDepartmentInfoV2.DepartmentIdInt;
objDDL.DataTextField = conQxDepartmentInfoV2.DepartmentName;
objDDL.DataSource = arrQxDepartmentInfoV2ObjLst;
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
if (clsQxDepartmentInfoV2BL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxDepartmentInfoV2BL没有刷新缓存机制(clsQxDepartmentInfoV2BL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by DepartmentIdInt");
//if (arrQxDepartmentInfoV2ObjLstCache == null)
//{
//arrQxDepartmentInfoV2ObjLstCache = QxDepartmentInfoV2DA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "intDepartmentIdInt">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxDepartmentInfoV2EN GetObjByDepartmentIdIntCache(int intDepartmentIdInt)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsQxDepartmentInfoV2EN._CurrTabName);
List<clsQxDepartmentInfoV2EN> arrQxDepartmentInfoV2ObjLstCache = GetObjLstCache();
IEnumerable <clsQxDepartmentInfoV2EN> arrQxDepartmentInfoV2ObjLst_Sel =
arrQxDepartmentInfoV2ObjLstCache
.Where(x=> x.DepartmentIdInt == intDepartmentIdInt 
);
if (arrQxDepartmentInfoV2ObjLst_Sel.Count() == 0)
{
   clsQxDepartmentInfoV2EN obj = clsQxDepartmentInfoV2BL.GetObjByDepartmentIdInt(intDepartmentIdInt);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrQxDepartmentInfoV2ObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "intDepartmentIdInt">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetDepartmentNameByDepartmentIdIntCache(int intDepartmentIdInt)
{
//获取缓存中的对象列表
clsQxDepartmentInfoV2EN objQxDepartmentInfoV2 = GetObjByDepartmentIdIntCache(intDepartmentIdInt);
if (objQxDepartmentInfoV2 == null) return "";
return objQxDepartmentInfoV2.DepartmentName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "intDepartmentIdInt">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByDepartmentIdIntCache(int intDepartmentIdInt)
{
//获取缓存中的对象列表
clsQxDepartmentInfoV2EN objQxDepartmentInfoV2 = GetObjByDepartmentIdIntCache(intDepartmentIdInt);
if (objQxDepartmentInfoV2 == null) return "";
return objQxDepartmentInfoV2.DepartmentName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxDepartmentInfoV2EN> GetAllQxDepartmentInfoV2ObjLstCache()
{
//获取缓存中的对象列表
List<clsQxDepartmentInfoV2EN> arrQxDepartmentInfoV2ObjLstCache = GetObjLstCache(); 
return arrQxDepartmentInfoV2ObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxDepartmentInfoV2EN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsQxDepartmentInfoV2EN._CurrTabName);
List<clsQxDepartmentInfoV2EN> arrQxDepartmentInfoV2ObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrQxDepartmentInfoV2ObjLstCache;
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
string strKey = string.Format("{0}", clsQxDepartmentInfoV2EN._CurrTabName);
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
if (clsQxDepartmentInfoV2BL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsQxDepartmentInfoV2EN._CurrTabName);
CacheHelper.Remove(strKey);
clsQxDepartmentInfoV2BL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--QxDepartmentInfoV2(部门V2)
 /// 唯一性条件:DepartmentName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQxDepartmentInfoV2EN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN)
{
//检测记录是否存在
string strResult = QxDepartmentInfoV2DA.GetUniCondStr(objQxDepartmentInfoV2EN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstQxDepartmentInfoV2ObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsQxDepartmentInfoV2EN> lstQxDepartmentInfoV2ObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstQxDepartmentInfoV2ObjLst, writer);
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
 /// <param name = "lstQxDepartmentInfoV2ObjLst">[clsQxDepartmentInfoV2EN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsQxDepartmentInfoV2EN> lstQxDepartmentInfoV2ObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsQxDepartmentInfoV2BL.listXmlNode);
writer.WriteStartElement(clsQxDepartmentInfoV2BL.itemsXmlNode);
foreach (clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN in lstQxDepartmentInfoV2ObjLst)
{
clsQxDepartmentInfoV2BL.SerializeXML(writer, objQxDepartmentInfoV2EN);
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
 /// <param name = "objQxDepartmentInfoV2EN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN)
{
writer.WriteStartElement(clsQxDepartmentInfoV2BL.itemXmlNode);
 
writer.WriteElementString(conQxDepartmentInfoV2.DepartmentIdInt, objQxDepartmentInfoV2EN.DepartmentIdInt.ToString(CultureInfo.InvariantCulture));
 
if (objQxDepartmentInfoV2EN.DepartmentName != null)
{
writer.WriteElementString(conQxDepartmentInfoV2.DepartmentName, objQxDepartmentInfoV2EN.DepartmentName.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxDepartmentInfoV2EN.DepartmentAbbrName != null)
{
writer.WriteElementString(conQxDepartmentInfoV2.DepartmentAbbrName, objQxDepartmentInfoV2EN.DepartmentAbbrName.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxDepartmentInfoV2EN.DepartmentTypeId != null)
{
writer.WriteElementString(conQxDepartmentInfoV2.DepartmentTypeId, objQxDepartmentInfoV2EN.DepartmentTypeId.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(conQxDepartmentInfoV2.parentDepId, objQxDepartmentInfoV2EN.parentDepId.ToString());
 
writer.WriteElementString(conQxDepartmentInfoV2.OrderNum, objQxDepartmentInfoV2EN.OrderNum.ToString());
 
writer.WriteElementString(conQxDepartmentInfoV2.InUse, objQxDepartmentInfoV2EN.InUse.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objQxDepartmentInfoV2EN.Memo != null)
{
writer.WriteElementString(conQxDepartmentInfoV2.Memo, objQxDepartmentInfoV2EN.Memo.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxDepartmentInfoV2EN.CreateTime != null)
{
writer.WriteElementString(conQxDepartmentInfoV2.CreateTime, objQxDepartmentInfoV2EN.CreateTime.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxDepartmentInfoV2EN.updateTime != null)
{
writer.WriteElementString(conQxDepartmentInfoV2.updateTime, objQxDepartmentInfoV2EN.updateTime.ToString(CultureInfo.InvariantCulture));
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
public static clsQxDepartmentInfoV2EN GetObjFromXml(System.Xml.XmlReader reader)
{
clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN = new clsQxDepartmentInfoV2EN();
reader.Read();
while (!(reader.Name == clsQxDepartmentInfoV2BL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(conQxDepartmentInfoV2.DepartmentIdInt))
{
objQxDepartmentInfoV2EN.DepartmentIdInt = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(conQxDepartmentInfoV2.DepartmentName))
{
objQxDepartmentInfoV2EN.DepartmentName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxDepartmentInfoV2.DepartmentAbbrName))
{
objQxDepartmentInfoV2EN.DepartmentAbbrName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxDepartmentInfoV2.DepartmentTypeId))
{
objQxDepartmentInfoV2EN.DepartmentTypeId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxDepartmentInfoV2.parentDepId))
{
objQxDepartmentInfoV2EN.parentDepId = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(conQxDepartmentInfoV2.OrderNum))
{
objQxDepartmentInfoV2EN.OrderNum = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(conQxDepartmentInfoV2.InUse))
{
objQxDepartmentInfoV2EN.InUse = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(conQxDepartmentInfoV2.Memo))
{
objQxDepartmentInfoV2EN.Memo = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxDepartmentInfoV2.CreateTime))
{
objQxDepartmentInfoV2EN.CreateTime = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxDepartmentInfoV2.updateTime))
{
objQxDepartmentInfoV2EN.updateTime = reader.ReadElementContentAsString();
}
}
return objQxDepartmentInfoV2EN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strQxDepartmentInfoV2ObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsQxDepartmentInfoV2EN GetObjFromXmlStr(string strQxDepartmentInfoV2ObjXmlStr)
{
clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN = new clsQxDepartmentInfoV2EN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strQxDepartmentInfoV2ObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsQxDepartmentInfoV2BL.itemXmlNode))
{
objQxDepartmentInfoV2EN = GetObjFromXml(reader);
return objQxDepartmentInfoV2EN;
}
}
return objQxDepartmentInfoV2EN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objQxDepartmentInfoV2EN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objQxDepartmentInfoV2EN);
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
public static string Func(string strInFldName, string strOutFldName, int intDepartmentIdInt)
{
if (strInFldName != conQxDepartmentInfoV2.DepartmentIdInt)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conQxDepartmentInfoV2.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conQxDepartmentInfoV2.AttributeName));
throw new Exception(strMsg);
}
var objQxDepartmentInfoV2 = clsQxDepartmentInfoV2BL.GetObjByDepartmentIdIntCache(intDepartmentIdInt);
if (objQxDepartmentInfoV2 == null) return "";
return objQxDepartmentInfoV2[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objQxDepartmentInfoV2EN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsQxDepartmentInfoV2EN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objQxDepartmentInfoV2EN[strField]);
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
 /// <param name = "lstQxDepartmentInfoV2ObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsQxDepartmentInfoV2EN> lstQxDepartmentInfoV2ObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstQxDepartmentInfoV2ObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN in lstQxDepartmentInfoV2ObjLst)
{
string strJSON_One = SerializeObjToJSON(objQxDepartmentInfoV2EN);
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
int intRecCount = clsQxDepartmentInfoV2DA.GetRecCount(strTabName);
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
int intRecCount = clsQxDepartmentInfoV2DA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsQxDepartmentInfoV2DA.GetRecCount();
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
int intRecCount = clsQxDepartmentInfoV2DA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objQxDepartmentInfoV2Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsQxDepartmentInfoV2EN objQxDepartmentInfoV2Cond)
{
List<clsQxDepartmentInfoV2EN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxDepartmentInfoV2EN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxDepartmentInfoV2.AttributeName)
{
if (objQxDepartmentInfoV2Cond.IsUpdated(strFldName) == false) continue;
if (objQxDepartmentInfoV2Cond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxDepartmentInfoV2Cond[strFldName].ToString());
}
else
{
if (objQxDepartmentInfoV2Cond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxDepartmentInfoV2Cond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxDepartmentInfoV2Cond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxDepartmentInfoV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxDepartmentInfoV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxDepartmentInfoV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxDepartmentInfoV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxDepartmentInfoV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxDepartmentInfoV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxDepartmentInfoV2Cond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxDepartmentInfoV2Cond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxDepartmentInfoV2Cond[strFldName]));
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
 List<string> arrList = clsQxDepartmentInfoV2DA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = QxDepartmentInfoV2DA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = QxDepartmentInfoV2DA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = QxDepartmentInfoV2DA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxDepartmentInfoV2DA.SetFldValue(clsQxDepartmentInfoV2EN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = QxDepartmentInfoV2DA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxDepartmentInfoV2DA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxDepartmentInfoV2DA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxDepartmentInfoV2DA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[QxDepartmentInfoV2] "); 
 strCreateTabCode.Append(" ( "); 
 // /**部门Id*/ 
 strCreateTabCode.Append(" DepartmentIdInt int primary key identity, "); 
 // /**部门名*/ 
 strCreateTabCode.Append(" DepartmentName varchar(100) not Null, "); 
 // /**名称缩写*/ 
 strCreateTabCode.Append(" DepartmentAbbrName varchar(8) Null, "); 
 // /**部门类型ID*/ 
 strCreateTabCode.Append(" DepartmentTypeId char(2) Null, "); 
 // /**所属部门号*/ 
 strCreateTabCode.Append(" parentDepId int Null, "); 
 // /**排序号*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**是否在用*/ 
 strCreateTabCode.Append(" InUse bit Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**建立时间*/ 
 strCreateTabCode.Append(" CreateTime varchar(20) Null, "); 
 // /**修改时间*/ 
 strCreateTabCode.Append(" updateTime varchar(20) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 数据同步


 #endregion 数据同步
}
 /// <summary>
 /// 部门V2(QxDepartmentInfoV2)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4QxDepartmentInfoV2 : clsCommFun4BL
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
clsQxDepartmentInfoV2BL.ReFreshThisCache();
}
}

}