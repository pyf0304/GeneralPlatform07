
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvExportExcel4UsersBL
 表名:vExportExcel4Users(00140068)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:29:30
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:系统设置(SystemSet)
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
public static class  clsvExportExcel4UsersBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvExportExcel4UsersEN GetObj(this K_mId_vExportExcel4Users myKey)
{
clsvExportExcel4UsersEN objvExportExcel4UsersEN = clsvExportExcel4UsersBL.vExportExcel4UsersDA.GetObjBymId(myKey.Value);
return objvExportExcel4UsersEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExportExcel4UsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvExportExcel4UsersEN SetmId(this clsvExportExcel4UsersEN objvExportExcel4UsersEN, long lngmId, string strComparisonOp="")
	{
objvExportExcel4UsersEN.mId = lngmId; //流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExportExcel4UsersEN.dicFldComparisonOp.ContainsKey(convExportExcel4Users.mId) == false)
{
objvExportExcel4UsersEN.dicFldComparisonOp.Add(convExportExcel4Users.mId, strComparisonOp);
}
else
{
objvExportExcel4UsersEN.dicFldComparisonOp[convExportExcel4Users.mId] = strComparisonOp;
}
}
return objvExportExcel4UsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExportExcel4UsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvExportExcel4UsersEN SetIdExportExcel4Users(this clsvExportExcel4UsersEN objvExportExcel4UsersEN, string strIdExportExcel4Users, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdExportExcel4Users, 8, convExportExcel4Users.IdExportExcel4Users);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdExportExcel4Users, 8, convExportExcel4Users.IdExportExcel4Users);
}
objvExportExcel4UsersEN.IdExportExcel4Users = strIdExportExcel4Users; //导出Excel用户字段流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExportExcel4UsersEN.dicFldComparisonOp.ContainsKey(convExportExcel4Users.IdExportExcel4Users) == false)
{
objvExportExcel4UsersEN.dicFldComparisonOp.Add(convExportExcel4Users.IdExportExcel4Users, strComparisonOp);
}
else
{
objvExportExcel4UsersEN.dicFldComparisonOp[convExportExcel4Users.IdExportExcel4Users] = strComparisonOp;
}
}
return objvExportExcel4UsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExportExcel4UsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvExportExcel4UsersEN SetViewName(this clsvExportExcel4UsersEN objvExportExcel4UsersEN, string strViewName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewName, 100, convExportExcel4Users.ViewName);
}
objvExportExcel4UsersEN.ViewName = strViewName; //界面名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExportExcel4UsersEN.dicFldComparisonOp.ContainsKey(convExportExcel4Users.ViewName) == false)
{
objvExportExcel4UsersEN.dicFldComparisonOp.Add(convExportExcel4Users.ViewName, strComparisonOp);
}
else
{
objvExportExcel4UsersEN.dicFldComparisonOp[convExportExcel4Users.ViewName] = strComparisonOp;
}
}
return objvExportExcel4UsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExportExcel4UsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvExportExcel4UsersEN SetTabName(this clsvExportExcel4UsersEN objvExportExcel4UsersEN, string strTabName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabName, 100, convExportExcel4Users.TabName);
}
objvExportExcel4UsersEN.TabName = strTabName; //TabName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExportExcel4UsersEN.dicFldComparisonOp.ContainsKey(convExportExcel4Users.TabName) == false)
{
objvExportExcel4UsersEN.dicFldComparisonOp.Add(convExportExcel4Users.TabName, strComparisonOp);
}
else
{
objvExportExcel4UsersEN.dicFldComparisonOp[convExportExcel4Users.TabName] = strComparisonOp;
}
}
return objvExportExcel4UsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExportExcel4UsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvExportExcel4UsersEN SetIsDefaultUser(this clsvExportExcel4UsersEN objvExportExcel4UsersEN, bool bolIsDefaultUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsDefaultUser, convExportExcel4Users.IsDefaultUser);
objvExportExcel4UsersEN.IsDefaultUser = bolIsDefaultUser; //是否缺省用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExportExcel4UsersEN.dicFldComparisonOp.ContainsKey(convExportExcel4Users.IsDefaultUser) == false)
{
objvExportExcel4UsersEN.dicFldComparisonOp.Add(convExportExcel4Users.IsDefaultUser, strComparisonOp);
}
else
{
objvExportExcel4UsersEN.dicFldComparisonOp[convExportExcel4Users.IsDefaultUser] = strComparisonOp;
}
}
return objvExportExcel4UsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExportExcel4UsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvExportExcel4UsersEN SetUserId(this clsvExportExcel4UsersEN objvExportExcel4UsersEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convExportExcel4Users.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convExportExcel4Users.UserId);
}
objvExportExcel4UsersEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExportExcel4UsersEN.dicFldComparisonOp.ContainsKey(convExportExcel4Users.UserId) == false)
{
objvExportExcel4UsersEN.dicFldComparisonOp.Add(convExportExcel4Users.UserId, strComparisonOp);
}
else
{
objvExportExcel4UsersEN.dicFldComparisonOp[convExportExcel4Users.UserId] = strComparisonOp;
}
}
return objvExportExcel4UsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExportExcel4UsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvExportExcel4UsersEN SetUserName(this clsvExportExcel4UsersEN objvExportExcel4UsersEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convExportExcel4Users.UserName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convExportExcel4Users.UserName);
}
objvExportExcel4UsersEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExportExcel4UsersEN.dicFldComparisonOp.ContainsKey(convExportExcel4Users.UserName) == false)
{
objvExportExcel4UsersEN.dicFldComparisonOp.Add(convExportExcel4Users.UserName, strComparisonOp);
}
else
{
objvExportExcel4UsersEN.dicFldComparisonOp[convExportExcel4Users.UserName] = strComparisonOp;
}
}
return objvExportExcel4UsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExportExcel4UsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvExportExcel4UsersEN SetExportFileName(this clsvExportExcel4UsersEN objvExportExcel4UsersEN, string strExportFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strExportFileName, convExportExcel4Users.ExportFileName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExportFileName, 100, convExportExcel4Users.ExportFileName);
}
objvExportExcel4UsersEN.ExportFileName = strExportFileName; //导出文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExportExcel4UsersEN.dicFldComparisonOp.ContainsKey(convExportExcel4Users.ExportFileName) == false)
{
objvExportExcel4UsersEN.dicFldComparisonOp.Add(convExportExcel4Users.ExportFileName, strComparisonOp);
}
else
{
objvExportExcel4UsersEN.dicFldComparisonOp[convExportExcel4Users.ExportFileName] = strComparisonOp;
}
}
return objvExportExcel4UsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExportExcel4UsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvExportExcel4UsersEN SetFieldName(this clsvExportExcel4UsersEN objvExportExcel4UsersEN, string strFieldName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFieldName, 50, convExportExcel4Users.FieldName);
}
objvExportExcel4UsersEN.FieldName = strFieldName; //字段名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExportExcel4UsersEN.dicFldComparisonOp.ContainsKey(convExportExcel4Users.FieldName) == false)
{
objvExportExcel4UsersEN.dicFldComparisonOp.Add(convExportExcel4Users.FieldName, strComparisonOp);
}
else
{
objvExportExcel4UsersEN.dicFldComparisonOp[convExportExcel4Users.FieldName] = strComparisonOp;
}
}
return objvExportExcel4UsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExportExcel4UsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvExportExcel4UsersEN SetFieldCnName(this clsvExportExcel4UsersEN objvExportExcel4UsersEN, string strFieldCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFieldCnName, convExportExcel4Users.FieldCnName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFieldCnName, 50, convExportExcel4Users.FieldCnName);
}
objvExportExcel4UsersEN.FieldCnName = strFieldCnName; //字段中文名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExportExcel4UsersEN.dicFldComparisonOp.ContainsKey(convExportExcel4Users.FieldCnName) == false)
{
objvExportExcel4UsersEN.dicFldComparisonOp.Add(convExportExcel4Users.FieldCnName, strComparisonOp);
}
else
{
objvExportExcel4UsersEN.dicFldComparisonOp[convExportExcel4Users.FieldCnName] = strComparisonOp;
}
}
return objvExportExcel4UsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExportExcel4UsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvExportExcel4UsersEN SetIsExport(this clsvExportExcel4UsersEN objvExportExcel4UsersEN, bool bolIsExport, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsExport, convExportExcel4Users.IsExport);
objvExportExcel4UsersEN.IsExport = bolIsExport; //是否导出
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExportExcel4UsersEN.dicFldComparisonOp.ContainsKey(convExportExcel4Users.IsExport) == false)
{
objvExportExcel4UsersEN.dicFldComparisonOp.Add(convExportExcel4Users.IsExport, strComparisonOp);
}
else
{
objvExportExcel4UsersEN.dicFldComparisonOp[convExportExcel4Users.IsExport] = strComparisonOp;
}
}
return objvExportExcel4UsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExportExcel4UsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvExportExcel4UsersEN SetOrderNum(this clsvExportExcel4UsersEN objvExportExcel4UsersEN, int? intOrderNum, string strComparisonOp="")
	{
objvExportExcel4UsersEN.OrderNum = intOrderNum; //排序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExportExcel4UsersEN.dicFldComparisonOp.ContainsKey(convExportExcel4Users.OrderNum) == false)
{
objvExportExcel4UsersEN.dicFldComparisonOp.Add(convExportExcel4Users.OrderNum, strComparisonOp);
}
else
{
objvExportExcel4UsersEN.dicFldComparisonOp[convExportExcel4Users.OrderNum] = strComparisonOp;
}
}
return objvExportExcel4UsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExportExcel4UsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvExportExcel4UsersEN SetUpdDate(this clsvExportExcel4UsersEN objvExportExcel4UsersEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convExportExcel4Users.UpdDate);
}
objvExportExcel4UsersEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExportExcel4UsersEN.dicFldComparisonOp.ContainsKey(convExportExcel4Users.UpdDate) == false)
{
objvExportExcel4UsersEN.dicFldComparisonOp.Add(convExportExcel4Users.UpdDate, strComparisonOp);
}
else
{
objvExportExcel4UsersEN.dicFldComparisonOp[convExportExcel4Users.UpdDate] = strComparisonOp;
}
}
return objvExportExcel4UsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExportExcel4UsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvExportExcel4UsersEN SetUpdUserId(this clsvExportExcel4UsersEN objvExportExcel4UsersEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convExportExcel4Users.UpdUserId);
}
objvExportExcel4UsersEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExportExcel4UsersEN.dicFldComparisonOp.ContainsKey(convExportExcel4Users.UpdUserId) == false)
{
objvExportExcel4UsersEN.dicFldComparisonOp.Add(convExportExcel4Users.UpdUserId, strComparisonOp);
}
else
{
objvExportExcel4UsersEN.dicFldComparisonOp[convExportExcel4Users.UpdUserId] = strComparisonOp;
}
}
return objvExportExcel4UsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExportExcel4UsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvExportExcel4UsersEN SetMemo(this clsvExportExcel4UsersEN objvExportExcel4UsersEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convExportExcel4Users.Memo);
}
objvExportExcel4UsersEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExportExcel4UsersEN.dicFldComparisonOp.ContainsKey(convExportExcel4Users.Memo) == false)
{
objvExportExcel4UsersEN.dicFldComparisonOp.Add(convExportExcel4Users.Memo, strComparisonOp);
}
else
{
objvExportExcel4UsersEN.dicFldComparisonOp[convExportExcel4Users.Memo] = strComparisonOp;
}
}
return objvExportExcel4UsersEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvExportExcel4UsersENS">源对象</param>
 /// <param name = "objvExportExcel4UsersENT">目标对象</param>
 public static void CopyTo(this clsvExportExcel4UsersEN objvExportExcel4UsersENS, clsvExportExcel4UsersEN objvExportExcel4UsersENT)
{
try
{
objvExportExcel4UsersENT.mId = objvExportExcel4UsersENS.mId; //流水号
objvExportExcel4UsersENT.IdExportExcel4Users = objvExportExcel4UsersENS.IdExportExcel4Users; //导出Excel用户字段流水号
objvExportExcel4UsersENT.ViewName = objvExportExcel4UsersENS.ViewName; //界面名称
objvExportExcel4UsersENT.TabName = objvExportExcel4UsersENS.TabName; //TabName
objvExportExcel4UsersENT.IsDefaultUser = objvExportExcel4UsersENS.IsDefaultUser; //是否缺省用户
objvExportExcel4UsersENT.UserId = objvExportExcel4UsersENS.UserId; //用户ID
objvExportExcel4UsersENT.UserName = objvExportExcel4UsersENS.UserName; //用户名
objvExportExcel4UsersENT.ExportFileName = objvExportExcel4UsersENS.ExportFileName; //导出文件名
objvExportExcel4UsersENT.FieldName = objvExportExcel4UsersENS.FieldName; //字段名
objvExportExcel4UsersENT.FieldCnName = objvExportExcel4UsersENS.FieldCnName; //字段中文名称
objvExportExcel4UsersENT.IsExport = objvExportExcel4UsersENS.IsExport; //是否导出
objvExportExcel4UsersENT.OrderNum = objvExportExcel4UsersENS.OrderNum; //排序号
objvExportExcel4UsersENT.UpdDate = objvExportExcel4UsersENS.UpdDate; //修改日期
objvExportExcel4UsersENT.UpdUserId = objvExportExcel4UsersENS.UpdUserId; //修改用户Id
objvExportExcel4UsersENT.Memo = objvExportExcel4UsersENS.Memo; //备注
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
 /// <param name = "objvExportExcel4UsersENS">源对象</param>
 /// <returns>目标对象=>clsvExportExcel4UsersEN:objvExportExcel4UsersENT</returns>
 public static clsvExportExcel4UsersEN CopyTo(this clsvExportExcel4UsersEN objvExportExcel4UsersENS)
{
try
{
 clsvExportExcel4UsersEN objvExportExcel4UsersENT = new clsvExportExcel4UsersEN()
{
mId = objvExportExcel4UsersENS.mId, //流水号
IdExportExcel4Users = objvExportExcel4UsersENS.IdExportExcel4Users, //导出Excel用户字段流水号
ViewName = objvExportExcel4UsersENS.ViewName, //界面名称
TabName = objvExportExcel4UsersENS.TabName, //TabName
IsDefaultUser = objvExportExcel4UsersENS.IsDefaultUser, //是否缺省用户
UserId = objvExportExcel4UsersENS.UserId, //用户ID
UserName = objvExportExcel4UsersENS.UserName, //用户名
ExportFileName = objvExportExcel4UsersENS.ExportFileName, //导出文件名
FieldName = objvExportExcel4UsersENS.FieldName, //字段名
FieldCnName = objvExportExcel4UsersENS.FieldCnName, //字段中文名称
IsExport = objvExportExcel4UsersENS.IsExport, //是否导出
OrderNum = objvExportExcel4UsersENS.OrderNum, //排序号
UpdDate = objvExportExcel4UsersENS.UpdDate, //修改日期
UpdUserId = objvExportExcel4UsersENS.UpdUserId, //修改用户Id
Memo = objvExportExcel4UsersENS.Memo, //备注
};
 return objvExportExcel4UsersENT;
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
public static void CheckProperty4Condition(this clsvExportExcel4UsersEN objvExportExcel4UsersEN)
{
 clsvExportExcel4UsersBL.vExportExcel4UsersDA.CheckProperty4Condition(objvExportExcel4UsersEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvExportExcel4UsersEN objvExportExcel4UsersCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvExportExcel4UsersCond.IsUpdated(convExportExcel4Users.mId) == true)
{
string strComparisonOpmId = objvExportExcel4UsersCond.dicFldComparisonOp[convExportExcel4Users.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convExportExcel4Users.mId, objvExportExcel4UsersCond.mId, strComparisonOpmId);
}
if (objvExportExcel4UsersCond.IsUpdated(convExportExcel4Users.IdExportExcel4Users) == true)
{
string strComparisonOpIdExportExcel4Users = objvExportExcel4UsersCond.dicFldComparisonOp[convExportExcel4Users.IdExportExcel4Users];
strWhereCond += string.Format(" And {0} {2} '{1}'", convExportExcel4Users.IdExportExcel4Users, objvExportExcel4UsersCond.IdExportExcel4Users, strComparisonOpIdExportExcel4Users);
}
if (objvExportExcel4UsersCond.IsUpdated(convExportExcel4Users.ViewName) == true)
{
string strComparisonOpViewName = objvExportExcel4UsersCond.dicFldComparisonOp[convExportExcel4Users.ViewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convExportExcel4Users.ViewName, objvExportExcel4UsersCond.ViewName, strComparisonOpViewName);
}
if (objvExportExcel4UsersCond.IsUpdated(convExportExcel4Users.TabName) == true)
{
string strComparisonOpTabName = objvExportExcel4UsersCond.dicFldComparisonOp[convExportExcel4Users.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convExportExcel4Users.TabName, objvExportExcel4UsersCond.TabName, strComparisonOpTabName);
}
if (objvExportExcel4UsersCond.IsUpdated(convExportExcel4Users.IsDefaultUser) == true)
{
if (objvExportExcel4UsersCond.IsDefaultUser == true)
{
strWhereCond += string.Format(" And {0} = '1'", convExportExcel4Users.IsDefaultUser);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convExportExcel4Users.IsDefaultUser);
}
}
if (objvExportExcel4UsersCond.IsUpdated(convExportExcel4Users.UserId) == true)
{
string strComparisonOpUserId = objvExportExcel4UsersCond.dicFldComparisonOp[convExportExcel4Users.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convExportExcel4Users.UserId, objvExportExcel4UsersCond.UserId, strComparisonOpUserId);
}
if (objvExportExcel4UsersCond.IsUpdated(convExportExcel4Users.UserName) == true)
{
string strComparisonOpUserName = objvExportExcel4UsersCond.dicFldComparisonOp[convExportExcel4Users.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convExportExcel4Users.UserName, objvExportExcel4UsersCond.UserName, strComparisonOpUserName);
}
if (objvExportExcel4UsersCond.IsUpdated(convExportExcel4Users.ExportFileName) == true)
{
string strComparisonOpExportFileName = objvExportExcel4UsersCond.dicFldComparisonOp[convExportExcel4Users.ExportFileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convExportExcel4Users.ExportFileName, objvExportExcel4UsersCond.ExportFileName, strComparisonOpExportFileName);
}
if (objvExportExcel4UsersCond.IsUpdated(convExportExcel4Users.FieldName) == true)
{
string strComparisonOpFieldName = objvExportExcel4UsersCond.dicFldComparisonOp[convExportExcel4Users.FieldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convExportExcel4Users.FieldName, objvExportExcel4UsersCond.FieldName, strComparisonOpFieldName);
}
if (objvExportExcel4UsersCond.IsUpdated(convExportExcel4Users.FieldCnName) == true)
{
string strComparisonOpFieldCnName = objvExportExcel4UsersCond.dicFldComparisonOp[convExportExcel4Users.FieldCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convExportExcel4Users.FieldCnName, objvExportExcel4UsersCond.FieldCnName, strComparisonOpFieldCnName);
}
if (objvExportExcel4UsersCond.IsUpdated(convExportExcel4Users.IsExport) == true)
{
if (objvExportExcel4UsersCond.IsExport == true)
{
strWhereCond += string.Format(" And {0} = '1'", convExportExcel4Users.IsExport);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convExportExcel4Users.IsExport);
}
}
if (objvExportExcel4UsersCond.IsUpdated(convExportExcel4Users.OrderNum) == true)
{
string strComparisonOpOrderNum = objvExportExcel4UsersCond.dicFldComparisonOp[convExportExcel4Users.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convExportExcel4Users.OrderNum, objvExportExcel4UsersCond.OrderNum, strComparisonOpOrderNum);
}
if (objvExportExcel4UsersCond.IsUpdated(convExportExcel4Users.UpdDate) == true)
{
string strComparisonOpUpdDate = objvExportExcel4UsersCond.dicFldComparisonOp[convExportExcel4Users.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convExportExcel4Users.UpdDate, objvExportExcel4UsersCond.UpdDate, strComparisonOpUpdDate);
}
if (objvExportExcel4UsersCond.IsUpdated(convExportExcel4Users.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvExportExcel4UsersCond.dicFldComparisonOp[convExportExcel4Users.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convExportExcel4Users.UpdUserId, objvExportExcel4UsersCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvExportExcel4UsersCond.IsUpdated(convExportExcel4Users.Memo) == true)
{
string strComparisonOpMemo = objvExportExcel4UsersCond.dicFldComparisonOp[convExportExcel4Users.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convExportExcel4Users.Memo, objvExportExcel4UsersCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vExportExcel4Users
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v导出Excel用户字段(vExportExcel4Users)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvExportExcel4UsersBL
{
public static RelatedActions_vExportExcel4Users relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "vExportExcel4UsersListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "vExportExcel4UsersList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsvExportExcel4UsersEN> arrvExportExcel4UsersObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvExportExcel4UsersDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvExportExcel4UsersDA vExportExcel4UsersDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvExportExcel4UsersDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvExportExcel4UsersBL()
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
if (string.IsNullOrEmpty(clsvExportExcel4UsersEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvExportExcel4UsersEN._ConnectString);
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
objDS = vExportExcel4UsersDA.GetDataSet(strWhereCond);
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
objDS = vExportExcel4UsersDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = vExportExcel4UsersDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_vExportExcel4Users(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vExportExcel4UsersDA.GetDataTable_vExportExcel4Users(strWhereCond);
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
objDT = vExportExcel4UsersDA.GetDataTable(strWhereCond);
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
objDT = vExportExcel4UsersDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vExportExcel4UsersDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vExportExcel4UsersDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vExportExcel4UsersDA.GetDataTable_Top(objTopPara);
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
objDT = vExportExcel4UsersDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vExportExcel4UsersDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = vExportExcel4UsersDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vExportExcel4UsersDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = vExportExcel4UsersDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = vExportExcel4UsersDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = vExportExcel4UsersDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = vExportExcel4UsersDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvExportExcel4UsersEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvExportExcel4UsersEN> arrObjLst = new List<clsvExportExcel4UsersEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMIdLst);
 string strWhereCond = string.Format("mId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvExportExcel4UsersEN objvExportExcel4UsersEN = new clsvExportExcel4UsersEN();
try
{
objvExportExcel4UsersEN.mId = Int32.Parse(objRow[convExportExcel4Users.mId].ToString().Trim()); //流水号
objvExportExcel4UsersEN.IdExportExcel4Users = objRow[convExportExcel4Users.IdExportExcel4Users] == DBNull.Value ? null : objRow[convExportExcel4Users.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objvExportExcel4UsersEN.ViewName = objRow[convExportExcel4Users.ViewName] == DBNull.Value ? null : objRow[convExportExcel4Users.ViewName].ToString().Trim(); //界面名称
objvExportExcel4UsersEN.TabName = objRow[convExportExcel4Users.TabName] == DBNull.Value ? null : objRow[convExportExcel4Users.TabName].ToString().Trim(); //TabName
objvExportExcel4UsersEN.IsDefaultUser = clsEntityBase2.TransNullToBool_S(objRow[convExportExcel4Users.IsDefaultUser].ToString().Trim()); //是否缺省用户
objvExportExcel4UsersEN.UserId = objRow[convExportExcel4Users.UserId].ToString().Trim(); //用户ID
objvExportExcel4UsersEN.UserName = objRow[convExportExcel4Users.UserName].ToString().Trim(); //用户名
objvExportExcel4UsersEN.ExportFileName = objRow[convExportExcel4Users.ExportFileName].ToString().Trim(); //导出文件名
objvExportExcel4UsersEN.FieldName = objRow[convExportExcel4Users.FieldName] == DBNull.Value ? null : objRow[convExportExcel4Users.FieldName].ToString().Trim(); //字段名
objvExportExcel4UsersEN.FieldCnName = objRow[convExportExcel4Users.FieldCnName].ToString().Trim(); //字段中文名称
objvExportExcel4UsersEN.IsExport = clsEntityBase2.TransNullToBool_S(objRow[convExportExcel4Users.IsExport].ToString().Trim()); //是否导出
objvExportExcel4UsersEN.OrderNum = objRow[convExportExcel4Users.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convExportExcel4Users.OrderNum].ToString().Trim()); //排序号
objvExportExcel4UsersEN.UpdDate = objRow[convExportExcel4Users.UpdDate] == DBNull.Value ? null : objRow[convExportExcel4Users.UpdDate].ToString().Trim(); //修改日期
objvExportExcel4UsersEN.UpdUserId = objRow[convExportExcel4Users.UpdUserId] == DBNull.Value ? null : objRow[convExportExcel4Users.UpdUserId].ToString().Trim(); //修改用户Id
objvExportExcel4UsersEN.Memo = objRow[convExportExcel4Users.Memo] == DBNull.Value ? null : objRow[convExportExcel4Users.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvExportExcel4UsersEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvExportExcel4UsersEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvExportExcel4UsersEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvExportExcel4UsersEN._CurrTabName);
List<clsvExportExcel4UsersEN> arrvExportExcel4UsersObjLstCache = GetObjLstCache();
IEnumerable <clsvExportExcel4UsersEN> arrvExportExcel4UsersObjLst_Sel =
arrvExportExcel4UsersObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvExportExcel4UsersObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvExportExcel4UsersEN> GetObjLst(string strWhereCond)
{
List<clsvExportExcel4UsersEN> arrObjLst = new List<clsvExportExcel4UsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvExportExcel4UsersEN objvExportExcel4UsersEN = new clsvExportExcel4UsersEN();
try
{
objvExportExcel4UsersEN.mId = Int32.Parse(objRow[convExportExcel4Users.mId].ToString().Trim()); //流水号
objvExportExcel4UsersEN.IdExportExcel4Users = objRow[convExportExcel4Users.IdExportExcel4Users] == DBNull.Value ? null : objRow[convExportExcel4Users.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objvExportExcel4UsersEN.ViewName = objRow[convExportExcel4Users.ViewName] == DBNull.Value ? null : objRow[convExportExcel4Users.ViewName].ToString().Trim(); //界面名称
objvExportExcel4UsersEN.TabName = objRow[convExportExcel4Users.TabName] == DBNull.Value ? null : objRow[convExportExcel4Users.TabName].ToString().Trim(); //TabName
objvExportExcel4UsersEN.IsDefaultUser = clsEntityBase2.TransNullToBool_S(objRow[convExportExcel4Users.IsDefaultUser].ToString().Trim()); //是否缺省用户
objvExportExcel4UsersEN.UserId = objRow[convExportExcel4Users.UserId].ToString().Trim(); //用户ID
objvExportExcel4UsersEN.UserName = objRow[convExportExcel4Users.UserName].ToString().Trim(); //用户名
objvExportExcel4UsersEN.ExportFileName = objRow[convExportExcel4Users.ExportFileName].ToString().Trim(); //导出文件名
objvExportExcel4UsersEN.FieldName = objRow[convExportExcel4Users.FieldName] == DBNull.Value ? null : objRow[convExportExcel4Users.FieldName].ToString().Trim(); //字段名
objvExportExcel4UsersEN.FieldCnName = objRow[convExportExcel4Users.FieldCnName].ToString().Trim(); //字段中文名称
objvExportExcel4UsersEN.IsExport = clsEntityBase2.TransNullToBool_S(objRow[convExportExcel4Users.IsExport].ToString().Trim()); //是否导出
objvExportExcel4UsersEN.OrderNum = objRow[convExportExcel4Users.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convExportExcel4Users.OrderNum].ToString().Trim()); //排序号
objvExportExcel4UsersEN.UpdDate = objRow[convExportExcel4Users.UpdDate] == DBNull.Value ? null : objRow[convExportExcel4Users.UpdDate].ToString().Trim(); //修改日期
objvExportExcel4UsersEN.UpdUserId = objRow[convExportExcel4Users.UpdUserId] == DBNull.Value ? null : objRow[convExportExcel4Users.UpdUserId].ToString().Trim(); //修改用户Id
objvExportExcel4UsersEN.Memo = objRow[convExportExcel4Users.Memo] == DBNull.Value ? null : objRow[convExportExcel4Users.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvExportExcel4UsersEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvExportExcel4UsersEN);
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
public static List<clsvExportExcel4UsersEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvExportExcel4UsersEN> arrObjLst = new List<clsvExportExcel4UsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvExportExcel4UsersEN objvExportExcel4UsersEN = new clsvExportExcel4UsersEN();
try
{
objvExportExcel4UsersEN.mId = Int32.Parse(objRow[convExportExcel4Users.mId].ToString().Trim()); //流水号
objvExportExcel4UsersEN.IdExportExcel4Users = objRow[convExportExcel4Users.IdExportExcel4Users] == DBNull.Value ? null : objRow[convExportExcel4Users.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objvExportExcel4UsersEN.ViewName = objRow[convExportExcel4Users.ViewName] == DBNull.Value ? null : objRow[convExportExcel4Users.ViewName].ToString().Trim(); //界面名称
objvExportExcel4UsersEN.TabName = objRow[convExportExcel4Users.TabName] == DBNull.Value ? null : objRow[convExportExcel4Users.TabName].ToString().Trim(); //TabName
objvExportExcel4UsersEN.IsDefaultUser = clsEntityBase2.TransNullToBool_S(objRow[convExportExcel4Users.IsDefaultUser].ToString().Trim()); //是否缺省用户
objvExportExcel4UsersEN.UserId = objRow[convExportExcel4Users.UserId].ToString().Trim(); //用户ID
objvExportExcel4UsersEN.UserName = objRow[convExportExcel4Users.UserName].ToString().Trim(); //用户名
objvExportExcel4UsersEN.ExportFileName = objRow[convExportExcel4Users.ExportFileName].ToString().Trim(); //导出文件名
objvExportExcel4UsersEN.FieldName = objRow[convExportExcel4Users.FieldName] == DBNull.Value ? null : objRow[convExportExcel4Users.FieldName].ToString().Trim(); //字段名
objvExportExcel4UsersEN.FieldCnName = objRow[convExportExcel4Users.FieldCnName].ToString().Trim(); //字段中文名称
objvExportExcel4UsersEN.IsExport = clsEntityBase2.TransNullToBool_S(objRow[convExportExcel4Users.IsExport].ToString().Trim()); //是否导出
objvExportExcel4UsersEN.OrderNum = objRow[convExportExcel4Users.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convExportExcel4Users.OrderNum].ToString().Trim()); //排序号
objvExportExcel4UsersEN.UpdDate = objRow[convExportExcel4Users.UpdDate] == DBNull.Value ? null : objRow[convExportExcel4Users.UpdDate].ToString().Trim(); //修改日期
objvExportExcel4UsersEN.UpdUserId = objRow[convExportExcel4Users.UpdUserId] == DBNull.Value ? null : objRow[convExportExcel4Users.UpdUserId].ToString().Trim(); //修改用户Id
objvExportExcel4UsersEN.Memo = objRow[convExportExcel4Users.Memo] == DBNull.Value ? null : objRow[convExportExcel4Users.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvExportExcel4UsersEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvExportExcel4UsersEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvExportExcel4UsersCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvExportExcel4UsersEN> GetSubObjLstCache(clsvExportExcel4UsersEN objvExportExcel4UsersCond)
{
List<clsvExportExcel4UsersEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvExportExcel4UsersEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convExportExcel4Users.AttributeName)
{
if (objvExportExcel4UsersCond.IsUpdated(strFldName) == false) continue;
if (objvExportExcel4UsersCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvExportExcel4UsersCond[strFldName].ToString());
}
else
{
if (objvExportExcel4UsersCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvExportExcel4UsersCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvExportExcel4UsersCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvExportExcel4UsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvExportExcel4UsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvExportExcel4UsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvExportExcel4UsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvExportExcel4UsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvExportExcel4UsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvExportExcel4UsersCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvExportExcel4UsersCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvExportExcel4UsersCond[strFldName]));
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
public static List<clsvExportExcel4UsersEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvExportExcel4UsersEN> arrObjLst = new List<clsvExportExcel4UsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvExportExcel4UsersEN objvExportExcel4UsersEN = new clsvExportExcel4UsersEN();
try
{
objvExportExcel4UsersEN.mId = Int32.Parse(objRow[convExportExcel4Users.mId].ToString().Trim()); //流水号
objvExportExcel4UsersEN.IdExportExcel4Users = objRow[convExportExcel4Users.IdExportExcel4Users] == DBNull.Value ? null : objRow[convExportExcel4Users.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objvExportExcel4UsersEN.ViewName = objRow[convExportExcel4Users.ViewName] == DBNull.Value ? null : objRow[convExportExcel4Users.ViewName].ToString().Trim(); //界面名称
objvExportExcel4UsersEN.TabName = objRow[convExportExcel4Users.TabName] == DBNull.Value ? null : objRow[convExportExcel4Users.TabName].ToString().Trim(); //TabName
objvExportExcel4UsersEN.IsDefaultUser = clsEntityBase2.TransNullToBool_S(objRow[convExportExcel4Users.IsDefaultUser].ToString().Trim()); //是否缺省用户
objvExportExcel4UsersEN.UserId = objRow[convExportExcel4Users.UserId].ToString().Trim(); //用户ID
objvExportExcel4UsersEN.UserName = objRow[convExportExcel4Users.UserName].ToString().Trim(); //用户名
objvExportExcel4UsersEN.ExportFileName = objRow[convExportExcel4Users.ExportFileName].ToString().Trim(); //导出文件名
objvExportExcel4UsersEN.FieldName = objRow[convExportExcel4Users.FieldName] == DBNull.Value ? null : objRow[convExportExcel4Users.FieldName].ToString().Trim(); //字段名
objvExportExcel4UsersEN.FieldCnName = objRow[convExportExcel4Users.FieldCnName].ToString().Trim(); //字段中文名称
objvExportExcel4UsersEN.IsExport = clsEntityBase2.TransNullToBool_S(objRow[convExportExcel4Users.IsExport].ToString().Trim()); //是否导出
objvExportExcel4UsersEN.OrderNum = objRow[convExportExcel4Users.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convExportExcel4Users.OrderNum].ToString().Trim()); //排序号
objvExportExcel4UsersEN.UpdDate = objRow[convExportExcel4Users.UpdDate] == DBNull.Value ? null : objRow[convExportExcel4Users.UpdDate].ToString().Trim(); //修改日期
objvExportExcel4UsersEN.UpdUserId = objRow[convExportExcel4Users.UpdUserId] == DBNull.Value ? null : objRow[convExportExcel4Users.UpdUserId].ToString().Trim(); //修改用户Id
objvExportExcel4UsersEN.Memo = objRow[convExportExcel4Users.Memo] == DBNull.Value ? null : objRow[convExportExcel4Users.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvExportExcel4UsersEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvExportExcel4UsersEN);
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
public static List<clsvExportExcel4UsersEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvExportExcel4UsersEN> arrObjLst = new List<clsvExportExcel4UsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvExportExcel4UsersEN objvExportExcel4UsersEN = new clsvExportExcel4UsersEN();
try
{
objvExportExcel4UsersEN.mId = Int32.Parse(objRow[convExportExcel4Users.mId].ToString().Trim()); //流水号
objvExportExcel4UsersEN.IdExportExcel4Users = objRow[convExportExcel4Users.IdExportExcel4Users] == DBNull.Value ? null : objRow[convExportExcel4Users.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objvExportExcel4UsersEN.ViewName = objRow[convExportExcel4Users.ViewName] == DBNull.Value ? null : objRow[convExportExcel4Users.ViewName].ToString().Trim(); //界面名称
objvExportExcel4UsersEN.TabName = objRow[convExportExcel4Users.TabName] == DBNull.Value ? null : objRow[convExportExcel4Users.TabName].ToString().Trim(); //TabName
objvExportExcel4UsersEN.IsDefaultUser = clsEntityBase2.TransNullToBool_S(objRow[convExportExcel4Users.IsDefaultUser].ToString().Trim()); //是否缺省用户
objvExportExcel4UsersEN.UserId = objRow[convExportExcel4Users.UserId].ToString().Trim(); //用户ID
objvExportExcel4UsersEN.UserName = objRow[convExportExcel4Users.UserName].ToString().Trim(); //用户名
objvExportExcel4UsersEN.ExportFileName = objRow[convExportExcel4Users.ExportFileName].ToString().Trim(); //导出文件名
objvExportExcel4UsersEN.FieldName = objRow[convExportExcel4Users.FieldName] == DBNull.Value ? null : objRow[convExportExcel4Users.FieldName].ToString().Trim(); //字段名
objvExportExcel4UsersEN.FieldCnName = objRow[convExportExcel4Users.FieldCnName].ToString().Trim(); //字段中文名称
objvExportExcel4UsersEN.IsExport = clsEntityBase2.TransNullToBool_S(objRow[convExportExcel4Users.IsExport].ToString().Trim()); //是否导出
objvExportExcel4UsersEN.OrderNum = objRow[convExportExcel4Users.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convExportExcel4Users.OrderNum].ToString().Trim()); //排序号
objvExportExcel4UsersEN.UpdDate = objRow[convExportExcel4Users.UpdDate] == DBNull.Value ? null : objRow[convExportExcel4Users.UpdDate].ToString().Trim(); //修改日期
objvExportExcel4UsersEN.UpdUserId = objRow[convExportExcel4Users.UpdUserId] == DBNull.Value ? null : objRow[convExportExcel4Users.UpdUserId].ToString().Trim(); //修改用户Id
objvExportExcel4UsersEN.Memo = objRow[convExportExcel4Users.Memo] == DBNull.Value ? null : objRow[convExportExcel4Users.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvExportExcel4UsersEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvExportExcel4UsersEN);
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
List<clsvExportExcel4UsersEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvExportExcel4UsersEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvExportExcel4UsersEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvExportExcel4UsersEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvExportExcel4UsersEN> arrObjLst = new List<clsvExportExcel4UsersEN>(); 
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
	clsvExportExcel4UsersEN objvExportExcel4UsersEN = new clsvExportExcel4UsersEN();
try
{
objvExportExcel4UsersEN.mId = Int32.Parse(objRow[convExportExcel4Users.mId].ToString().Trim()); //流水号
objvExportExcel4UsersEN.IdExportExcel4Users = objRow[convExportExcel4Users.IdExportExcel4Users] == DBNull.Value ? null : objRow[convExportExcel4Users.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objvExportExcel4UsersEN.ViewName = objRow[convExportExcel4Users.ViewName] == DBNull.Value ? null : objRow[convExportExcel4Users.ViewName].ToString().Trim(); //界面名称
objvExportExcel4UsersEN.TabName = objRow[convExportExcel4Users.TabName] == DBNull.Value ? null : objRow[convExportExcel4Users.TabName].ToString().Trim(); //TabName
objvExportExcel4UsersEN.IsDefaultUser = clsEntityBase2.TransNullToBool_S(objRow[convExportExcel4Users.IsDefaultUser].ToString().Trim()); //是否缺省用户
objvExportExcel4UsersEN.UserId = objRow[convExportExcel4Users.UserId].ToString().Trim(); //用户ID
objvExportExcel4UsersEN.UserName = objRow[convExportExcel4Users.UserName].ToString().Trim(); //用户名
objvExportExcel4UsersEN.ExportFileName = objRow[convExportExcel4Users.ExportFileName].ToString().Trim(); //导出文件名
objvExportExcel4UsersEN.FieldName = objRow[convExportExcel4Users.FieldName] == DBNull.Value ? null : objRow[convExportExcel4Users.FieldName].ToString().Trim(); //字段名
objvExportExcel4UsersEN.FieldCnName = objRow[convExportExcel4Users.FieldCnName].ToString().Trim(); //字段中文名称
objvExportExcel4UsersEN.IsExport = clsEntityBase2.TransNullToBool_S(objRow[convExportExcel4Users.IsExport].ToString().Trim()); //是否导出
objvExportExcel4UsersEN.OrderNum = objRow[convExportExcel4Users.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convExportExcel4Users.OrderNum].ToString().Trim()); //排序号
objvExportExcel4UsersEN.UpdDate = objRow[convExportExcel4Users.UpdDate] == DBNull.Value ? null : objRow[convExportExcel4Users.UpdDate].ToString().Trim(); //修改日期
objvExportExcel4UsersEN.UpdUserId = objRow[convExportExcel4Users.UpdUserId] == DBNull.Value ? null : objRow[convExportExcel4Users.UpdUserId].ToString().Trim(); //修改用户Id
objvExportExcel4UsersEN.Memo = objRow[convExportExcel4Users.Memo] == DBNull.Value ? null : objRow[convExportExcel4Users.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvExportExcel4UsersEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvExportExcel4UsersEN);
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
public static List<clsvExportExcel4UsersEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvExportExcel4UsersEN> arrObjLst = new List<clsvExportExcel4UsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvExportExcel4UsersEN objvExportExcel4UsersEN = new clsvExportExcel4UsersEN();
try
{
objvExportExcel4UsersEN.mId = Int32.Parse(objRow[convExportExcel4Users.mId].ToString().Trim()); //流水号
objvExportExcel4UsersEN.IdExportExcel4Users = objRow[convExportExcel4Users.IdExportExcel4Users] == DBNull.Value ? null : objRow[convExportExcel4Users.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objvExportExcel4UsersEN.ViewName = objRow[convExportExcel4Users.ViewName] == DBNull.Value ? null : objRow[convExportExcel4Users.ViewName].ToString().Trim(); //界面名称
objvExportExcel4UsersEN.TabName = objRow[convExportExcel4Users.TabName] == DBNull.Value ? null : objRow[convExportExcel4Users.TabName].ToString().Trim(); //TabName
objvExportExcel4UsersEN.IsDefaultUser = clsEntityBase2.TransNullToBool_S(objRow[convExportExcel4Users.IsDefaultUser].ToString().Trim()); //是否缺省用户
objvExportExcel4UsersEN.UserId = objRow[convExportExcel4Users.UserId].ToString().Trim(); //用户ID
objvExportExcel4UsersEN.UserName = objRow[convExportExcel4Users.UserName].ToString().Trim(); //用户名
objvExportExcel4UsersEN.ExportFileName = objRow[convExportExcel4Users.ExportFileName].ToString().Trim(); //导出文件名
objvExportExcel4UsersEN.FieldName = objRow[convExportExcel4Users.FieldName] == DBNull.Value ? null : objRow[convExportExcel4Users.FieldName].ToString().Trim(); //字段名
objvExportExcel4UsersEN.FieldCnName = objRow[convExportExcel4Users.FieldCnName].ToString().Trim(); //字段中文名称
objvExportExcel4UsersEN.IsExport = clsEntityBase2.TransNullToBool_S(objRow[convExportExcel4Users.IsExport].ToString().Trim()); //是否导出
objvExportExcel4UsersEN.OrderNum = objRow[convExportExcel4Users.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convExportExcel4Users.OrderNum].ToString().Trim()); //排序号
objvExportExcel4UsersEN.UpdDate = objRow[convExportExcel4Users.UpdDate] == DBNull.Value ? null : objRow[convExportExcel4Users.UpdDate].ToString().Trim(); //修改日期
objvExportExcel4UsersEN.UpdUserId = objRow[convExportExcel4Users.UpdUserId] == DBNull.Value ? null : objRow[convExportExcel4Users.UpdUserId].ToString().Trim(); //修改用户Id
objvExportExcel4UsersEN.Memo = objRow[convExportExcel4Users.Memo] == DBNull.Value ? null : objRow[convExportExcel4Users.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvExportExcel4UsersEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvExportExcel4UsersEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvExportExcel4UsersEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvExportExcel4UsersEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvExportExcel4UsersEN> arrObjLst = new List<clsvExportExcel4UsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvExportExcel4UsersEN objvExportExcel4UsersEN = new clsvExportExcel4UsersEN();
try
{
objvExportExcel4UsersEN.mId = Int32.Parse(objRow[convExportExcel4Users.mId].ToString().Trim()); //流水号
objvExportExcel4UsersEN.IdExportExcel4Users = objRow[convExportExcel4Users.IdExportExcel4Users] == DBNull.Value ? null : objRow[convExportExcel4Users.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objvExportExcel4UsersEN.ViewName = objRow[convExportExcel4Users.ViewName] == DBNull.Value ? null : objRow[convExportExcel4Users.ViewName].ToString().Trim(); //界面名称
objvExportExcel4UsersEN.TabName = objRow[convExportExcel4Users.TabName] == DBNull.Value ? null : objRow[convExportExcel4Users.TabName].ToString().Trim(); //TabName
objvExportExcel4UsersEN.IsDefaultUser = clsEntityBase2.TransNullToBool_S(objRow[convExportExcel4Users.IsDefaultUser].ToString().Trim()); //是否缺省用户
objvExportExcel4UsersEN.UserId = objRow[convExportExcel4Users.UserId].ToString().Trim(); //用户ID
objvExportExcel4UsersEN.UserName = objRow[convExportExcel4Users.UserName].ToString().Trim(); //用户名
objvExportExcel4UsersEN.ExportFileName = objRow[convExportExcel4Users.ExportFileName].ToString().Trim(); //导出文件名
objvExportExcel4UsersEN.FieldName = objRow[convExportExcel4Users.FieldName] == DBNull.Value ? null : objRow[convExportExcel4Users.FieldName].ToString().Trim(); //字段名
objvExportExcel4UsersEN.FieldCnName = objRow[convExportExcel4Users.FieldCnName].ToString().Trim(); //字段中文名称
objvExportExcel4UsersEN.IsExport = clsEntityBase2.TransNullToBool_S(objRow[convExportExcel4Users.IsExport].ToString().Trim()); //是否导出
objvExportExcel4UsersEN.OrderNum = objRow[convExportExcel4Users.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convExportExcel4Users.OrderNum].ToString().Trim()); //排序号
objvExportExcel4UsersEN.UpdDate = objRow[convExportExcel4Users.UpdDate] == DBNull.Value ? null : objRow[convExportExcel4Users.UpdDate].ToString().Trim(); //修改日期
objvExportExcel4UsersEN.UpdUserId = objRow[convExportExcel4Users.UpdUserId] == DBNull.Value ? null : objRow[convExportExcel4Users.UpdUserId].ToString().Trim(); //修改用户Id
objvExportExcel4UsersEN.Memo = objRow[convExportExcel4Users.Memo] == DBNull.Value ? null : objRow[convExportExcel4Users.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvExportExcel4UsersEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvExportExcel4UsersEN);
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
public static List<clsvExportExcel4UsersEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvExportExcel4UsersEN> arrObjLst = new List<clsvExportExcel4UsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvExportExcel4UsersEN objvExportExcel4UsersEN = new clsvExportExcel4UsersEN();
try
{
objvExportExcel4UsersEN.mId = Int32.Parse(objRow[convExportExcel4Users.mId].ToString().Trim()); //流水号
objvExportExcel4UsersEN.IdExportExcel4Users = objRow[convExportExcel4Users.IdExportExcel4Users] == DBNull.Value ? null : objRow[convExportExcel4Users.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objvExportExcel4UsersEN.ViewName = objRow[convExportExcel4Users.ViewName] == DBNull.Value ? null : objRow[convExportExcel4Users.ViewName].ToString().Trim(); //界面名称
objvExportExcel4UsersEN.TabName = objRow[convExportExcel4Users.TabName] == DBNull.Value ? null : objRow[convExportExcel4Users.TabName].ToString().Trim(); //TabName
objvExportExcel4UsersEN.IsDefaultUser = clsEntityBase2.TransNullToBool_S(objRow[convExportExcel4Users.IsDefaultUser].ToString().Trim()); //是否缺省用户
objvExportExcel4UsersEN.UserId = objRow[convExportExcel4Users.UserId].ToString().Trim(); //用户ID
objvExportExcel4UsersEN.UserName = objRow[convExportExcel4Users.UserName].ToString().Trim(); //用户名
objvExportExcel4UsersEN.ExportFileName = objRow[convExportExcel4Users.ExportFileName].ToString().Trim(); //导出文件名
objvExportExcel4UsersEN.FieldName = objRow[convExportExcel4Users.FieldName] == DBNull.Value ? null : objRow[convExportExcel4Users.FieldName].ToString().Trim(); //字段名
objvExportExcel4UsersEN.FieldCnName = objRow[convExportExcel4Users.FieldCnName].ToString().Trim(); //字段中文名称
objvExportExcel4UsersEN.IsExport = clsEntityBase2.TransNullToBool_S(objRow[convExportExcel4Users.IsExport].ToString().Trim()); //是否导出
objvExportExcel4UsersEN.OrderNum = objRow[convExportExcel4Users.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convExportExcel4Users.OrderNum].ToString().Trim()); //排序号
objvExportExcel4UsersEN.UpdDate = objRow[convExportExcel4Users.UpdDate] == DBNull.Value ? null : objRow[convExportExcel4Users.UpdDate].ToString().Trim(); //修改日期
objvExportExcel4UsersEN.UpdUserId = objRow[convExportExcel4Users.UpdUserId] == DBNull.Value ? null : objRow[convExportExcel4Users.UpdUserId].ToString().Trim(); //修改用户Id
objvExportExcel4UsersEN.Memo = objRow[convExportExcel4Users.Memo] == DBNull.Value ? null : objRow[convExportExcel4Users.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvExportExcel4UsersEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvExportExcel4UsersEN);
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
public static IEnumerable<clsvExportExcel4UsersEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsvExportExcel4UsersEN objvExportExcel4UsersCond, string strOrderBy)
{
List<clsvExportExcel4UsersEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvExportExcel4UsersEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convExportExcel4Users.AttributeName)
{
if (objvExportExcel4UsersCond.IsUpdated(strFldName) == false) continue;
if (objvExportExcel4UsersCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvExportExcel4UsersCond[strFldName].ToString());
}
else
{
if (objvExportExcel4UsersCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvExportExcel4UsersCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvExportExcel4UsersCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvExportExcel4UsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvExportExcel4UsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvExportExcel4UsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvExportExcel4UsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvExportExcel4UsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvExportExcel4UsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvExportExcel4UsersCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvExportExcel4UsersCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvExportExcel4UsersCond[strFldName]));
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
public static IEnumerable<clsvExportExcel4UsersEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsvExportExcel4UsersEN objvExportExcel4UsersCond = JsonConvert.DeserializeObject<clsvExportExcel4UsersEN>(objPagerPara.whereCond);
if (objvExportExcel4UsersCond.sfFldComparisonOp == null)
{
objvExportExcel4UsersCond.dicFldComparisonOp = null;
}
else
{
objvExportExcel4UsersCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objvExportExcel4UsersCond.sfFldComparisonOp);
}
clsvExportExcel4UsersBL.SetUpdFlag(objvExportExcel4UsersCond);
 try
{
CheckProperty4Condition(objvExportExcel4UsersCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsvExportExcel4UsersBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objvExportExcel4UsersCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvExportExcel4UsersEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsvExportExcel4UsersEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvExportExcel4UsersEN> arrObjLst = new List<clsvExportExcel4UsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvExportExcel4UsersEN objvExportExcel4UsersEN = new clsvExportExcel4UsersEN();
try
{
objvExportExcel4UsersEN.mId = Int32.Parse(objRow[convExportExcel4Users.mId].ToString().Trim()); //流水号
objvExportExcel4UsersEN.IdExportExcel4Users = objRow[convExportExcel4Users.IdExportExcel4Users] == DBNull.Value ? null : objRow[convExportExcel4Users.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objvExportExcel4UsersEN.ViewName = objRow[convExportExcel4Users.ViewName] == DBNull.Value ? null : objRow[convExportExcel4Users.ViewName].ToString().Trim(); //界面名称
objvExportExcel4UsersEN.TabName = objRow[convExportExcel4Users.TabName] == DBNull.Value ? null : objRow[convExportExcel4Users.TabName].ToString().Trim(); //TabName
objvExportExcel4UsersEN.IsDefaultUser = clsEntityBase2.TransNullToBool_S(objRow[convExportExcel4Users.IsDefaultUser].ToString().Trim()); //是否缺省用户
objvExportExcel4UsersEN.UserId = objRow[convExportExcel4Users.UserId].ToString().Trim(); //用户ID
objvExportExcel4UsersEN.UserName = objRow[convExportExcel4Users.UserName].ToString().Trim(); //用户名
objvExportExcel4UsersEN.ExportFileName = objRow[convExportExcel4Users.ExportFileName].ToString().Trim(); //导出文件名
objvExportExcel4UsersEN.FieldName = objRow[convExportExcel4Users.FieldName] == DBNull.Value ? null : objRow[convExportExcel4Users.FieldName].ToString().Trim(); //字段名
objvExportExcel4UsersEN.FieldCnName = objRow[convExportExcel4Users.FieldCnName].ToString().Trim(); //字段中文名称
objvExportExcel4UsersEN.IsExport = clsEntityBase2.TransNullToBool_S(objRow[convExportExcel4Users.IsExport].ToString().Trim()); //是否导出
objvExportExcel4UsersEN.OrderNum = objRow[convExportExcel4Users.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convExportExcel4Users.OrderNum].ToString().Trim()); //排序号
objvExportExcel4UsersEN.UpdDate = objRow[convExportExcel4Users.UpdDate] == DBNull.Value ? null : objRow[convExportExcel4Users.UpdDate].ToString().Trim(); //修改日期
objvExportExcel4UsersEN.UpdUserId = objRow[convExportExcel4Users.UpdUserId] == DBNull.Value ? null : objRow[convExportExcel4Users.UpdUserId].ToString().Trim(); //修改用户Id
objvExportExcel4UsersEN.Memo = objRow[convExportExcel4Users.Memo] == DBNull.Value ? null : objRow[convExportExcel4Users.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvExportExcel4UsersEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvExportExcel4UsersEN);
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
public static List<clsvExportExcel4UsersEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvExportExcel4UsersEN> arrObjLst = new List<clsvExportExcel4UsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvExportExcel4UsersEN objvExportExcel4UsersEN = new clsvExportExcel4UsersEN();
try
{
objvExportExcel4UsersEN.mId = Int32.Parse(objRow[convExportExcel4Users.mId].ToString().Trim()); //流水号
objvExportExcel4UsersEN.IdExportExcel4Users = objRow[convExportExcel4Users.IdExportExcel4Users] == DBNull.Value ? null : objRow[convExportExcel4Users.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objvExportExcel4UsersEN.ViewName = objRow[convExportExcel4Users.ViewName] == DBNull.Value ? null : objRow[convExportExcel4Users.ViewName].ToString().Trim(); //界面名称
objvExportExcel4UsersEN.TabName = objRow[convExportExcel4Users.TabName] == DBNull.Value ? null : objRow[convExportExcel4Users.TabName].ToString().Trim(); //TabName
objvExportExcel4UsersEN.IsDefaultUser = clsEntityBase2.TransNullToBool_S(objRow[convExportExcel4Users.IsDefaultUser].ToString().Trim()); //是否缺省用户
objvExportExcel4UsersEN.UserId = objRow[convExportExcel4Users.UserId].ToString().Trim(); //用户ID
objvExportExcel4UsersEN.UserName = objRow[convExportExcel4Users.UserName].ToString().Trim(); //用户名
objvExportExcel4UsersEN.ExportFileName = objRow[convExportExcel4Users.ExportFileName].ToString().Trim(); //导出文件名
objvExportExcel4UsersEN.FieldName = objRow[convExportExcel4Users.FieldName] == DBNull.Value ? null : objRow[convExportExcel4Users.FieldName].ToString().Trim(); //字段名
objvExportExcel4UsersEN.FieldCnName = objRow[convExportExcel4Users.FieldCnName].ToString().Trim(); //字段中文名称
objvExportExcel4UsersEN.IsExport = clsEntityBase2.TransNullToBool_S(objRow[convExportExcel4Users.IsExport].ToString().Trim()); //是否导出
objvExportExcel4UsersEN.OrderNum = objRow[convExportExcel4Users.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convExportExcel4Users.OrderNum].ToString().Trim()); //排序号
objvExportExcel4UsersEN.UpdDate = objRow[convExportExcel4Users.UpdDate] == DBNull.Value ? null : objRow[convExportExcel4Users.UpdDate].ToString().Trim(); //修改日期
objvExportExcel4UsersEN.UpdUserId = objRow[convExportExcel4Users.UpdUserId] == DBNull.Value ? null : objRow[convExportExcel4Users.UpdUserId].ToString().Trim(); //修改用户Id
objvExportExcel4UsersEN.Memo = objRow[convExportExcel4Users.Memo] == DBNull.Value ? null : objRow[convExportExcel4Users.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvExportExcel4UsersEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvExportExcel4UsersEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvExportExcel4UsersEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvExportExcel4UsersEN> arrObjLst = new List<clsvExportExcel4UsersEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvExportExcel4UsersEN objvExportExcel4UsersEN = new clsvExportExcel4UsersEN();
try
{
objvExportExcel4UsersEN.mId = Int32.Parse(objRow[convExportExcel4Users.mId].ToString().Trim()); //流水号
objvExportExcel4UsersEN.IdExportExcel4Users = objRow[convExportExcel4Users.IdExportExcel4Users] == DBNull.Value ? null : objRow[convExportExcel4Users.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objvExportExcel4UsersEN.ViewName = objRow[convExportExcel4Users.ViewName] == DBNull.Value ? null : objRow[convExportExcel4Users.ViewName].ToString().Trim(); //界面名称
objvExportExcel4UsersEN.TabName = objRow[convExportExcel4Users.TabName] == DBNull.Value ? null : objRow[convExportExcel4Users.TabName].ToString().Trim(); //TabName
objvExportExcel4UsersEN.IsDefaultUser = clsEntityBase2.TransNullToBool_S(objRow[convExportExcel4Users.IsDefaultUser].ToString().Trim()); //是否缺省用户
objvExportExcel4UsersEN.UserId = objRow[convExportExcel4Users.UserId].ToString().Trim(); //用户ID
objvExportExcel4UsersEN.UserName = objRow[convExportExcel4Users.UserName].ToString().Trim(); //用户名
objvExportExcel4UsersEN.ExportFileName = objRow[convExportExcel4Users.ExportFileName].ToString().Trim(); //导出文件名
objvExportExcel4UsersEN.FieldName = objRow[convExportExcel4Users.FieldName] == DBNull.Value ? null : objRow[convExportExcel4Users.FieldName].ToString().Trim(); //字段名
objvExportExcel4UsersEN.FieldCnName = objRow[convExportExcel4Users.FieldCnName].ToString().Trim(); //字段中文名称
objvExportExcel4UsersEN.IsExport = clsEntityBase2.TransNullToBool_S(objRow[convExportExcel4Users.IsExport].ToString().Trim()); //是否导出
objvExportExcel4UsersEN.OrderNum = objRow[convExportExcel4Users.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convExportExcel4Users.OrderNum].ToString().Trim()); //排序号
objvExportExcel4UsersEN.UpdDate = objRow[convExportExcel4Users.UpdDate] == DBNull.Value ? null : objRow[convExportExcel4Users.UpdDate].ToString().Trim(); //修改日期
objvExportExcel4UsersEN.UpdUserId = objRow[convExportExcel4Users.UpdUserId] == DBNull.Value ? null : objRow[convExportExcel4Users.UpdUserId].ToString().Trim(); //修改用户Id
objvExportExcel4UsersEN.Memo = objRow[convExportExcel4Users.Memo] == DBNull.Value ? null : objRow[convExportExcel4Users.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvExportExcel4UsersEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvExportExcel4UsersEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvExportExcel4UsersEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvExportExcel4Users(ref clsvExportExcel4UsersEN objvExportExcel4UsersEN)
{
bool bolResult = vExportExcel4UsersDA.GetvExportExcel4Users(ref objvExportExcel4UsersEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvExportExcel4UsersEN GetObjBymId(long lngmId)
{
clsvExportExcel4UsersEN objvExportExcel4UsersEN = vExportExcel4UsersDA.GetObjBymId(lngmId);
return objvExportExcel4UsersEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvExportExcel4UsersEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvExportExcel4UsersEN objvExportExcel4UsersEN = vExportExcel4UsersDA.GetFirstObj(strWhereCond);
 return objvExportExcel4UsersEN;
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
public static clsvExportExcel4UsersEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvExportExcel4UsersEN objvExportExcel4UsersEN = vExportExcel4UsersDA.GetObjByDataRow(objRow);
 return objvExportExcel4UsersEN;
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
public static clsvExportExcel4UsersEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvExportExcel4UsersEN objvExportExcel4UsersEN = vExportExcel4UsersDA.GetObjByDataRow(objRow);
 return objvExportExcel4UsersEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "lstvExportExcel4UsersObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvExportExcel4UsersEN GetObjBymIdFromList(long lngmId, List<clsvExportExcel4UsersEN> lstvExportExcel4UsersObjLst)
{
foreach (clsvExportExcel4UsersEN objvExportExcel4UsersEN in lstvExportExcel4UsersObjLst)
{
if (objvExportExcel4UsersEN.mId == lngmId)
{
return objvExportExcel4UsersEN;
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
public static long GetFirstID_S(string strWhereCond) 
{
 long lngmId;
 try
 {
 lngmId = new clsvExportExcel4UsersDA().GetFirstID(strWhereCond);
 return lngmId;
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
 arrList = vExportExcel4UsersDA.GetID(strWhereCond);
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
bool bolIsExist = vExportExcel4UsersDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngmId)
{
//检测记录是否存在
bool bolIsExist = vExportExcel4UsersDA.IsExist(lngmId);
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
 bolIsExist = clsvExportExcel4UsersDA.IsExistTable();
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
 bolIsExist = vExportExcel4UsersDA.IsExistTable(strTabName);
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
 /// <param name = "objvExportExcel4UsersENS">源对象</param>
 /// <param name = "objvExportExcel4UsersENT">目标对象</param>
 public static void CopyTo(clsvExportExcel4UsersEN objvExportExcel4UsersENS, clsvExportExcel4UsersEN objvExportExcel4UsersENT)
{
try
{
objvExportExcel4UsersENT.mId = objvExportExcel4UsersENS.mId; //流水号
objvExportExcel4UsersENT.IdExportExcel4Users = objvExportExcel4UsersENS.IdExportExcel4Users; //导出Excel用户字段流水号
objvExportExcel4UsersENT.ViewName = objvExportExcel4UsersENS.ViewName; //界面名称
objvExportExcel4UsersENT.TabName = objvExportExcel4UsersENS.TabName; //TabName
objvExportExcel4UsersENT.IsDefaultUser = objvExportExcel4UsersENS.IsDefaultUser; //是否缺省用户
objvExportExcel4UsersENT.UserId = objvExportExcel4UsersENS.UserId; //用户ID
objvExportExcel4UsersENT.UserName = objvExportExcel4UsersENS.UserName; //用户名
objvExportExcel4UsersENT.ExportFileName = objvExportExcel4UsersENS.ExportFileName; //导出文件名
objvExportExcel4UsersENT.FieldName = objvExportExcel4UsersENS.FieldName; //字段名
objvExportExcel4UsersENT.FieldCnName = objvExportExcel4UsersENS.FieldCnName; //字段中文名称
objvExportExcel4UsersENT.IsExport = objvExportExcel4UsersENS.IsExport; //是否导出
objvExportExcel4UsersENT.OrderNum = objvExportExcel4UsersENS.OrderNum; //排序号
objvExportExcel4UsersENT.UpdDate = objvExportExcel4UsersENS.UpdDate; //修改日期
objvExportExcel4UsersENT.UpdUserId = objvExportExcel4UsersENS.UpdUserId; //修改用户Id
objvExportExcel4UsersENT.Memo = objvExportExcel4UsersENS.Memo; //备注
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
 /// <param name = "objvExportExcel4UsersEN">源简化对象</param>
 public static void SetUpdFlag(clsvExportExcel4UsersEN objvExportExcel4UsersEN)
{
try
{
objvExportExcel4UsersEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvExportExcel4UsersEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convExportExcel4Users.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvExportExcel4UsersEN.mId = objvExportExcel4UsersEN.mId; //流水号
}
if (arrFldSet.Contains(convExportExcel4Users.IdExportExcel4Users, new clsStrCompareIgnoreCase())  ==  true)
{
objvExportExcel4UsersEN.IdExportExcel4Users = objvExportExcel4UsersEN.IdExportExcel4Users == "[null]" ? null :  objvExportExcel4UsersEN.IdExportExcel4Users; //导出Excel用户字段流水号
}
if (arrFldSet.Contains(convExportExcel4Users.ViewName, new clsStrCompareIgnoreCase())  ==  true)
{
objvExportExcel4UsersEN.ViewName = objvExportExcel4UsersEN.ViewName == "[null]" ? null :  objvExportExcel4UsersEN.ViewName; //界面名称
}
if (arrFldSet.Contains(convExportExcel4Users.TabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvExportExcel4UsersEN.TabName = objvExportExcel4UsersEN.TabName == "[null]" ? null :  objvExportExcel4UsersEN.TabName; //TabName
}
if (arrFldSet.Contains(convExportExcel4Users.IsDefaultUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvExportExcel4UsersEN.IsDefaultUser = objvExportExcel4UsersEN.IsDefaultUser; //是否缺省用户
}
if (arrFldSet.Contains(convExportExcel4Users.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvExportExcel4UsersEN.UserId = objvExportExcel4UsersEN.UserId; //用户ID
}
if (arrFldSet.Contains(convExportExcel4Users.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvExportExcel4UsersEN.UserName = objvExportExcel4UsersEN.UserName; //用户名
}
if (arrFldSet.Contains(convExportExcel4Users.ExportFileName, new clsStrCompareIgnoreCase())  ==  true)
{
objvExportExcel4UsersEN.ExportFileName = objvExportExcel4UsersEN.ExportFileName; //导出文件名
}
if (arrFldSet.Contains(convExportExcel4Users.FieldName, new clsStrCompareIgnoreCase())  ==  true)
{
objvExportExcel4UsersEN.FieldName = objvExportExcel4UsersEN.FieldName == "[null]" ? null :  objvExportExcel4UsersEN.FieldName; //字段名
}
if (arrFldSet.Contains(convExportExcel4Users.FieldCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvExportExcel4UsersEN.FieldCnName = objvExportExcel4UsersEN.FieldCnName; //字段中文名称
}
if (arrFldSet.Contains(convExportExcel4Users.IsExport, new clsStrCompareIgnoreCase())  ==  true)
{
objvExportExcel4UsersEN.IsExport = objvExportExcel4UsersEN.IsExport; //是否导出
}
if (arrFldSet.Contains(convExportExcel4Users.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvExportExcel4UsersEN.OrderNum = objvExportExcel4UsersEN.OrderNum; //排序号
}
if (arrFldSet.Contains(convExportExcel4Users.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvExportExcel4UsersEN.UpdDate = objvExportExcel4UsersEN.UpdDate == "[null]" ? null :  objvExportExcel4UsersEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convExportExcel4Users.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvExportExcel4UsersEN.UpdUserId = objvExportExcel4UsersEN.UpdUserId == "[null]" ? null :  objvExportExcel4UsersEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convExportExcel4Users.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvExportExcel4UsersEN.Memo = objvExportExcel4UsersEN.Memo == "[null]" ? null :  objvExportExcel4UsersEN.Memo; //备注
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
 /// <param name = "objvExportExcel4UsersEN">源简化对象</param>
 public static void AccessFldValueNull(clsvExportExcel4UsersEN objvExportExcel4UsersEN)
{
try
{
if (objvExportExcel4UsersEN.IdExportExcel4Users == "[null]") objvExportExcel4UsersEN.IdExportExcel4Users = null; //导出Excel用户字段流水号
if (objvExportExcel4UsersEN.ViewName == "[null]") objvExportExcel4UsersEN.ViewName = null; //界面名称
if (objvExportExcel4UsersEN.TabName == "[null]") objvExportExcel4UsersEN.TabName = null; //TabName
if (objvExportExcel4UsersEN.FieldName == "[null]") objvExportExcel4UsersEN.FieldName = null; //字段名
if (objvExportExcel4UsersEN.UpdDate == "[null]") objvExportExcel4UsersEN.UpdDate = null; //修改日期
if (objvExportExcel4UsersEN.UpdUserId == "[null]") objvExportExcel4UsersEN.UpdUserId = null; //修改用户Id
if (objvExportExcel4UsersEN.Memo == "[null]") objvExportExcel4UsersEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvExportExcel4UsersEN objvExportExcel4UsersEN)
{
 vExportExcel4UsersDA.CheckProperty4Condition(objvExportExcel4UsersEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框


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
if (clsExportExcel4UsersBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsExportExcel4UsersBL没有刷新缓存机制(clsExportExcel4UsersBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxUsersBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxUsersBL没有刷新缓存机制(clsQxUsersBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsExportExcelSetBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsExportExcelSetBL没有刷新缓存机制(clsExportExcelSetBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvExportExcel4UsersObjLstCache == null)
//{
//arrvExportExcel4UsersObjLstCache = vExportExcel4UsersDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvExportExcel4UsersEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvExportExcel4UsersEN._CurrTabName);
List<clsvExportExcel4UsersEN> arrvExportExcel4UsersObjLstCache = GetObjLstCache();
IEnumerable <clsvExportExcel4UsersEN> arrvExportExcel4UsersObjLst_Sel =
arrvExportExcel4UsersObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvExportExcel4UsersObjLst_Sel.Count() == 0)
{
   clsvExportExcel4UsersEN obj = clsvExportExcel4UsersBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvExportExcel4UsersObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvExportExcel4UsersEN> GetAllvExportExcel4UsersObjLstCache()
{
//获取缓存中的对象列表
List<clsvExportExcel4UsersEN> arrvExportExcel4UsersObjLstCache = GetObjLstCache(); 
return arrvExportExcel4UsersObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvExportExcel4UsersEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvExportExcel4UsersEN._CurrTabName);
List<clsvExportExcel4UsersEN> arrvExportExcel4UsersObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvExportExcel4UsersObjLstCache;
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
string strKey = string.Format("{0}", clsvExportExcel4UsersEN._CurrTabName);
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
 /// <param name = "lstvExportExcel4UsersObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsvExportExcel4UsersEN> lstvExportExcel4UsersObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstvExportExcel4UsersObjLst, writer);
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
 /// <param name = "lstvExportExcel4UsersObjLst">[clsvExportExcel4UsersEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsvExportExcel4UsersEN> lstvExportExcel4UsersObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsvExportExcel4UsersBL.listXmlNode);
writer.WriteStartElement(clsvExportExcel4UsersBL.itemsXmlNode);
foreach (clsvExportExcel4UsersEN objvExportExcel4UsersEN in lstvExportExcel4UsersObjLst)
{
clsvExportExcel4UsersBL.SerializeXML(writer, objvExportExcel4UsersEN);
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
 /// <param name = "objvExportExcel4UsersEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsvExportExcel4UsersEN objvExportExcel4UsersEN)
{
writer.WriteStartElement(clsvExportExcel4UsersBL.itemXmlNode);
 
writer.WriteElementString(convExportExcel4Users.mId, objvExportExcel4UsersEN.mId.ToString(CultureInfo.InvariantCulture));
 
if (objvExportExcel4UsersEN.IdExportExcel4Users != null)
{
writer.WriteElementString(convExportExcel4Users.IdExportExcel4Users, objvExportExcel4UsersEN.IdExportExcel4Users.ToString(CultureInfo.InvariantCulture));
}
 
if (objvExportExcel4UsersEN.ViewName != null)
{
writer.WriteElementString(convExportExcel4Users.ViewName, objvExportExcel4UsersEN.ViewName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvExportExcel4UsersEN.TabName != null)
{
writer.WriteElementString(convExportExcel4Users.TabName, objvExportExcel4UsersEN.TabName.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convExportExcel4Users.IsDefaultUser, objvExportExcel4UsersEN.IsDefaultUser.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objvExportExcel4UsersEN.UserId != null)
{
writer.WriteElementString(convExportExcel4Users.UserId, objvExportExcel4UsersEN.UserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvExportExcel4UsersEN.UserName != null)
{
writer.WriteElementString(convExportExcel4Users.UserName, objvExportExcel4UsersEN.UserName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvExportExcel4UsersEN.ExportFileName != null)
{
writer.WriteElementString(convExportExcel4Users.ExportFileName, objvExportExcel4UsersEN.ExportFileName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvExportExcel4UsersEN.FieldName != null)
{
writer.WriteElementString(convExportExcel4Users.FieldName, objvExportExcel4UsersEN.FieldName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvExportExcel4UsersEN.FieldCnName != null)
{
writer.WriteElementString(convExportExcel4Users.FieldCnName, objvExportExcel4UsersEN.FieldCnName.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convExportExcel4Users.IsExport, objvExportExcel4UsersEN.IsExport.ToString().ToLower(CultureInfo.InvariantCulture));
 
writer.WriteElementString(convExportExcel4Users.OrderNum, objvExportExcel4UsersEN.OrderNum.ToString());
 
if (objvExportExcel4UsersEN.UpdDate != null)
{
writer.WriteElementString(convExportExcel4Users.UpdDate, objvExportExcel4UsersEN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objvExportExcel4UsersEN.UpdUserId != null)
{
writer.WriteElementString(convExportExcel4Users.UpdUserId, objvExportExcel4UsersEN.UpdUserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvExportExcel4UsersEN.Memo != null)
{
writer.WriteElementString(convExportExcel4Users.Memo, objvExportExcel4UsersEN.Memo.ToString(CultureInfo.InvariantCulture));
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
public static clsvExportExcel4UsersEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsvExportExcel4UsersEN objvExportExcel4UsersEN = new clsvExportExcel4UsersEN();
reader.Read();
while (!(reader.Name == clsvExportExcel4UsersBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(convExportExcel4Users.mId))
{
objvExportExcel4UsersEN.mId = reader.ReadElementContentAsLong();
}
if (reader.IsStartElement(convExportExcel4Users.IdExportExcel4Users))
{
objvExportExcel4UsersEN.IdExportExcel4Users = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convExportExcel4Users.ViewName))
{
objvExportExcel4UsersEN.ViewName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convExportExcel4Users.TabName))
{
objvExportExcel4UsersEN.TabName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convExportExcel4Users.IsDefaultUser))
{
objvExportExcel4UsersEN.IsDefaultUser = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(convExportExcel4Users.UserId))
{
objvExportExcel4UsersEN.UserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convExportExcel4Users.UserName))
{
objvExportExcel4UsersEN.UserName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convExportExcel4Users.ExportFileName))
{
objvExportExcel4UsersEN.ExportFileName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convExportExcel4Users.FieldName))
{
objvExportExcel4UsersEN.FieldName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convExportExcel4Users.FieldCnName))
{
objvExportExcel4UsersEN.FieldCnName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convExportExcel4Users.IsExport))
{
objvExportExcel4UsersEN.IsExport = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(convExportExcel4Users.OrderNum))
{
objvExportExcel4UsersEN.OrderNum = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(convExportExcel4Users.UpdDate))
{
objvExportExcel4UsersEN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convExportExcel4Users.UpdUserId))
{
objvExportExcel4UsersEN.UpdUserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convExportExcel4Users.Memo))
{
objvExportExcel4UsersEN.Memo = reader.ReadElementContentAsString();
}
}
return objvExportExcel4UsersEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strvExportExcel4UsersObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsvExportExcel4UsersEN GetObjFromXmlStr(string strvExportExcel4UsersObjXmlStr)
{
clsvExportExcel4UsersEN objvExportExcel4UsersEN = new clsvExportExcel4UsersEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strvExportExcel4UsersObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsvExportExcel4UsersBL.itemXmlNode))
{
objvExportExcel4UsersEN = GetObjFromXml(reader);
return objvExportExcel4UsersEN;
}
}
return objvExportExcel4UsersEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objvExportExcel4UsersEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsvExportExcel4UsersEN objvExportExcel4UsersEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objvExportExcel4UsersEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != convExportExcel4Users.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convExportExcel4Users.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convExportExcel4Users.AttributeName));
throw new Exception(strMsg);
}
var objvExportExcel4Users = clsvExportExcel4UsersBL.GetObjBymIdCache(lngmId);
if (objvExportExcel4Users == null) return "";
return objvExportExcel4Users[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objvExportExcel4UsersEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsvExportExcel4UsersEN objvExportExcel4UsersEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsvExportExcel4UsersEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objvExportExcel4UsersEN[strField]);
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
 /// <param name = "lstvExportExcel4UsersObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsvExportExcel4UsersEN> lstvExportExcel4UsersObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstvExportExcel4UsersObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsvExportExcel4UsersEN objvExportExcel4UsersEN in lstvExportExcel4UsersObjLst)
{
string strJSON_One = SerializeObjToJSON(objvExportExcel4UsersEN);
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
int intRecCount = clsvExportExcel4UsersDA.GetRecCount(strTabName);
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
int intRecCount = clsvExportExcel4UsersDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvExportExcel4UsersDA.GetRecCount();
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
int intRecCount = clsvExportExcel4UsersDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvExportExcel4UsersCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvExportExcel4UsersEN objvExportExcel4UsersCond)
{
List<clsvExportExcel4UsersEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvExportExcel4UsersEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convExportExcel4Users.AttributeName)
{
if (objvExportExcel4UsersCond.IsUpdated(strFldName) == false) continue;
if (objvExportExcel4UsersCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvExportExcel4UsersCond[strFldName].ToString());
}
else
{
if (objvExportExcel4UsersCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvExportExcel4UsersCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvExportExcel4UsersCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvExportExcel4UsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvExportExcel4UsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvExportExcel4UsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvExportExcel4UsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvExportExcel4UsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvExportExcel4UsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvExportExcel4UsersCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvExportExcel4UsersCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvExportExcel4UsersCond[strFldName]));
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
 List<string> arrList = clsvExportExcel4UsersDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vExportExcel4UsersDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vExportExcel4UsersDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}