
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxViewInfoWApi
 表名:vQxViewInfo(00140029)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 18:32:16
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:界面管理(InterfaceMan)
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
public static class  clsvQxViewInfoWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewId">界面编号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxViewInfoEN SetViewId(this clsvQxViewInfoEN objvQxViewInfoEN, string strViewId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewId, 8, convQxViewInfo.ViewId);
clsCheckSql.CheckFieldForeignKey(strViewId, 8, convQxViewInfo.ViewId);
objvQxViewInfoEN.ViewId = strViewId; //界面编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxViewInfoEN.dicFldComparisonOp.ContainsKey(convQxViewInfo.ViewId) == false)
{
objvQxViewInfoEN.dicFldComparisonOp.Add(convQxViewInfo.ViewId, strComparisonOp);
}
else
{
objvQxViewInfoEN.dicFldComparisonOp[convQxViewInfo.ViewId] = strComparisonOp;
}
}
return objvQxViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewName">界面名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxViewInfoEN SetViewName(this clsvQxViewInfoEN objvQxViewInfoEN, string strViewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewName, convQxViewInfo.ViewName);
clsCheckSql.CheckFieldLen(strViewName, 100, convQxViewInfo.ViewName);
objvQxViewInfoEN.ViewName = strViewName; //界面名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxViewInfoEN.dicFldComparisonOp.ContainsKey(convQxViewInfo.ViewName) == false)
{
objvQxViewInfoEN.dicFldComparisonOp.Add(convQxViewInfo.ViewName, strComparisonOp);
}
else
{
objvQxViewInfoEN.dicFldComparisonOp[convQxViewInfo.ViewName] = strComparisonOp;
}
}
return objvQxViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewCnName">界面中文名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxViewInfoEN SetViewCnName(this clsvQxViewInfoEN objvQxViewInfoEN, string strViewCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewCnName, convQxViewInfo.ViewCnName);
clsCheckSql.CheckFieldLen(strViewCnName, 50, convQxViewInfo.ViewCnName);
objvQxViewInfoEN.ViewCnName = strViewCnName; //界面中文名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxViewInfoEN.dicFldComparisonOp.ContainsKey(convQxViewInfo.ViewCnName) == false)
{
objvQxViewInfoEN.dicFldComparisonOp.Add(convQxViewInfo.ViewCnName, strComparisonOp);
}
else
{
objvQxViewInfoEN.dicFldComparisonOp[convQxViewInfo.ViewCnName] = strComparisonOp;
}
}
return objvQxViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strFileName">文件名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxViewInfoEN SetFileName(this clsvQxViewInfoEN objvQxViewInfoEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFileName, convQxViewInfo.FileName);
clsCheckSql.CheckFieldLen(strFileName, 500, convQxViewInfo.FileName);
objvQxViewInfoEN.FileName = strFileName; //文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxViewInfoEN.dicFldComparisonOp.ContainsKey(convQxViewInfo.FileName) == false)
{
objvQxViewInfoEN.dicFldComparisonOp.Add(convQxViewInfo.FileName, strComparisonOp);
}
else
{
objvQxViewInfoEN.dicFldComparisonOp[convQxViewInfo.FileName] = strComparisonOp;
}
}
return objvQxViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strFilePath">文件路径</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxViewInfoEN SetFilePath(this clsvQxViewInfoEN objvQxViewInfoEN, string strFilePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFilePath, convQxViewInfo.FilePath);
clsCheckSql.CheckFieldLen(strFilePath, 500, convQxViewInfo.FilePath);
objvQxViewInfoEN.FilePath = strFilePath; //文件路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxViewInfoEN.dicFldComparisonOp.ContainsKey(convQxViewInfo.FilePath) == false)
{
objvQxViewInfoEN.dicFldComparisonOp.Add(convQxViewInfo.FilePath, strComparisonOp);
}
else
{
objvQxViewInfoEN.dicFldComparisonOp[convQxViewInfo.FilePath] = strComparisonOp;
}
}
return objvQxViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strDefaMenuName">缺省菜单名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxViewInfoEN SetDefaMenuName(this clsvQxViewInfoEN objvQxViewInfoEN, string strDefaMenuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDefaMenuName, convQxViewInfo.DefaMenuName);
clsCheckSql.CheckFieldLen(strDefaMenuName, 50, convQxViewInfo.DefaMenuName);
objvQxViewInfoEN.DefaMenuName = strDefaMenuName; //缺省菜单名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxViewInfoEN.dicFldComparisonOp.ContainsKey(convQxViewInfo.DefaMenuName) == false)
{
objvQxViewInfoEN.dicFldComparisonOp.Add(convQxViewInfo.DefaMenuName, strComparisonOp);
}
else
{
objvQxViewInfoEN.dicFldComparisonOp[convQxViewInfo.DefaMenuName] = strComparisonOp;
}
}
return objvQxViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewTypeCode">界面类型码</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxViewInfoEN SetViewTypeCode(this clsvQxViewInfoEN objvQxViewInfoEN, string strViewTypeCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewTypeCode, convQxViewInfo.ViewTypeCode);
clsCheckSql.CheckFieldLen(strViewTypeCode, 4, convQxViewInfo.ViewTypeCode);
clsCheckSql.CheckFieldForeignKey(strViewTypeCode, 4, convQxViewInfo.ViewTypeCode);
objvQxViewInfoEN.ViewTypeCode = strViewTypeCode; //界面类型码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxViewInfoEN.dicFldComparisonOp.ContainsKey(convQxViewInfo.ViewTypeCode) == false)
{
objvQxViewInfoEN.dicFldComparisonOp.Add(convQxViewInfo.ViewTypeCode, strComparisonOp);
}
else
{
objvQxViewInfoEN.dicFldComparisonOp[convQxViewInfo.ViewTypeCode] = strComparisonOp;
}
}
return objvQxViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataBaseName">数据库名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxViewInfoEN SetDataBaseName(this clsvQxViewInfoEN objvQxViewInfoEN, string strDataBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataBaseName, 30, convQxViewInfo.DataBaseName);
objvQxViewInfoEN.DataBaseName = strDataBaseName; //数据库名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxViewInfoEN.dicFldComparisonOp.ContainsKey(convQxViewInfo.DataBaseName) == false)
{
objvQxViewInfoEN.dicFldComparisonOp.Add(convQxViewInfo.DataBaseName, strComparisonOp);
}
else
{
objvQxViewInfoEN.dicFldComparisonOp[convQxViewInfo.DataBaseName] = strComparisonOp;
}
}
return objvQxViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strQxPrjId">项目Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxViewInfoEN SetQxPrjId(this clsvQxViewInfoEN objvQxViewInfoEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, convQxViewInfo.QxPrjId);
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxViewInfo.QxPrjId);
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxViewInfo.QxPrjId);
objvQxViewInfoEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxViewInfoEN.dicFldComparisonOp.ContainsKey(convQxViewInfo.QxPrjId) == false)
{
objvQxViewInfoEN.dicFldComparisonOp.Add(convQxViewInfo.QxPrjId, strComparisonOp);
}
else
{
objvQxViewInfoEN.dicFldComparisonOp[convQxViewInfo.QxPrjId] = strComparisonOp;
}
}
return objvQxViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxViewInfoEN SetPrjName(this clsvQxViewInfoEN objvQxViewInfoEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convQxViewInfo.PrjName);
clsCheckSql.CheckFieldLen(strPrjName, 30, convQxViewInfo.PrjName);
objvQxViewInfoEN.PrjName = strPrjName; //工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxViewInfoEN.dicFldComparisonOp.ContainsKey(convQxViewInfo.PrjName) == false)
{
objvQxViewInfoEN.dicFldComparisonOp.Add(convQxViewInfo.PrjName, strComparisonOp);
}
else
{
objvQxViewInfoEN.dicFldComparisonOp[convQxViewInfo.PrjName] = strComparisonOp;
}
}
return objvQxViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewFunction">界面功能</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxViewInfoEN SetViewFunction(this clsvQxViewInfoEN objvQxViewInfoEN, string strViewFunction, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewFunction, 100, convQxViewInfo.ViewFunction);
objvQxViewInfoEN.ViewFunction = strViewFunction; //界面功能
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxViewInfoEN.dicFldComparisonOp.ContainsKey(convQxViewInfo.ViewFunction) == false)
{
objvQxViewInfoEN.dicFldComparisonOp.Add(convQxViewInfo.ViewFunction, strComparisonOp);
}
else
{
objvQxViewInfoEN.dicFldComparisonOp[convQxViewInfo.ViewFunction] = strComparisonOp;
}
}
return objvQxViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewDetail">界面详细信息</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxViewInfoEN SetViewDetail(this clsvQxViewInfoEN objvQxViewInfoEN, string strViewDetail, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewDetail, 1000, convQxViewInfo.ViewDetail);
objvQxViewInfoEN.ViewDetail = strViewDetail; //界面详细信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxViewInfoEN.dicFldComparisonOp.ContainsKey(convQxViewInfo.ViewDetail) == false)
{
objvQxViewInfoEN.dicFldComparisonOp.Add(convQxViewInfo.ViewDetail, strComparisonOp);
}
else
{
objvQxViewInfoEN.dicFldComparisonOp[convQxViewInfo.ViewDetail] = strComparisonOp;
}
}
return objvQxViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strModuleId">模块号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxViewInfoEN SetModuleId(this clsvQxViewInfoEN objvQxViewInfoEN, string strModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strModuleId, convQxViewInfo.ModuleId);
clsCheckSql.CheckFieldLen(strModuleId, 6, convQxViewInfo.ModuleId);
clsCheckSql.CheckFieldForeignKey(strModuleId, 6, convQxViewInfo.ModuleId);
objvQxViewInfoEN.ModuleId = strModuleId; //模块号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxViewInfoEN.dicFldComparisonOp.ContainsKey(convQxViewInfo.ModuleId) == false)
{
objvQxViewInfoEN.dicFldComparisonOp.Add(convQxViewInfo.ModuleId, strComparisonOp);
}
else
{
objvQxViewInfoEN.dicFldComparisonOp[convQxViewInfo.ModuleId] = strComparisonOp;
}
}
return objvQxViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strModuleName">模块名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxViewInfoEN SetModuleName(this clsvQxViewInfoEN objvQxViewInfoEN, string strModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strModuleName, convQxViewInfo.ModuleName);
clsCheckSql.CheckFieldLen(strModuleName, 100, convQxViewInfo.ModuleName);
objvQxViewInfoEN.ModuleName = strModuleName; //模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxViewInfoEN.dicFldComparisonOp.ContainsKey(convQxViewInfo.ModuleName) == false)
{
objvQxViewInfoEN.dicFldComparisonOp.Add(convQxViewInfo.ModuleName, strComparisonOp);
}
else
{
objvQxViewInfoEN.dicFldComparisonOp[convQxViewInfo.ModuleName] = strComparisonOp;
}
}
return objvQxViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxViewInfoEN SetUpdDate(this clsvQxViewInfoEN objvQxViewInfoEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQxViewInfo.UpdDate);
objvQxViewInfoEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxViewInfoEN.dicFldComparisonOp.ContainsKey(convQxViewInfo.UpdDate) == false)
{
objvQxViewInfoEN.dicFldComparisonOp.Add(convQxViewInfo.UpdDate, strComparisonOp);
}
else
{
objvQxViewInfoEN.dicFldComparisonOp[convQxViewInfo.UpdDate] = strComparisonOp;
}
}
return objvQxViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxViewInfoEN SetUpdUserId(this clsvQxViewInfoEN objvQxViewInfoEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convQxViewInfo.UpdUserId);
objvQxViewInfoEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxViewInfoEN.dicFldComparisonOp.ContainsKey(convQxViewInfo.UpdUserId) == false)
{
objvQxViewInfoEN.dicFldComparisonOp.Add(convQxViewInfo.UpdUserId, strComparisonOp);
}
else
{
objvQxViewInfoEN.dicFldComparisonOp[convQxViewInfo.UpdUserId] = strComparisonOp;
}
}
return objvQxViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">备注</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxViewInfoEN SetMemo(this clsvQxViewInfoEN objvQxViewInfoEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxViewInfo.Memo);
objvQxViewInfoEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxViewInfoEN.dicFldComparisonOp.ContainsKey(convQxViewInfo.Memo) == false)
{
objvQxViewInfoEN.dicFldComparisonOp.Add(convQxViewInfo.Memo, strComparisonOp);
}
else
{
objvQxViewInfoEN.dicFldComparisonOp[convQxViewInfo.Memo] = strComparisonOp;
}
}
return objvQxViewInfoEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQxViewInfoEN objvQxViewInfoCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQxViewInfoCond.IsUpdated(convQxViewInfo.ViewId) == true)
{
string strComparisonOpViewId = objvQxViewInfoCond.dicFldComparisonOp[convQxViewInfo.ViewId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxViewInfo.ViewId, objvQxViewInfoCond.ViewId, strComparisonOpViewId);
}
if (objvQxViewInfoCond.IsUpdated(convQxViewInfo.ViewName) == true)
{
string strComparisonOpViewName = objvQxViewInfoCond.dicFldComparisonOp[convQxViewInfo.ViewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxViewInfo.ViewName, objvQxViewInfoCond.ViewName, strComparisonOpViewName);
}
if (objvQxViewInfoCond.IsUpdated(convQxViewInfo.ViewCnName) == true)
{
string strComparisonOpViewCnName = objvQxViewInfoCond.dicFldComparisonOp[convQxViewInfo.ViewCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxViewInfo.ViewCnName, objvQxViewInfoCond.ViewCnName, strComparisonOpViewCnName);
}
if (objvQxViewInfoCond.IsUpdated(convQxViewInfo.FileName) == true)
{
string strComparisonOpFileName = objvQxViewInfoCond.dicFldComparisonOp[convQxViewInfo.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxViewInfo.FileName, objvQxViewInfoCond.FileName, strComparisonOpFileName);
}
if (objvQxViewInfoCond.IsUpdated(convQxViewInfo.FilePath) == true)
{
string strComparisonOpFilePath = objvQxViewInfoCond.dicFldComparisonOp[convQxViewInfo.FilePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxViewInfo.FilePath, objvQxViewInfoCond.FilePath, strComparisonOpFilePath);
}
if (objvQxViewInfoCond.IsUpdated(convQxViewInfo.DefaMenuName) == true)
{
string strComparisonOpDefaMenuName = objvQxViewInfoCond.dicFldComparisonOp[convQxViewInfo.DefaMenuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxViewInfo.DefaMenuName, objvQxViewInfoCond.DefaMenuName, strComparisonOpDefaMenuName);
}
if (objvQxViewInfoCond.IsUpdated(convQxViewInfo.ViewTypeCode) == true)
{
string strComparisonOpViewTypeCode = objvQxViewInfoCond.dicFldComparisonOp[convQxViewInfo.ViewTypeCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxViewInfo.ViewTypeCode, objvQxViewInfoCond.ViewTypeCode, strComparisonOpViewTypeCode);
}
if (objvQxViewInfoCond.IsUpdated(convQxViewInfo.DataBaseName) == true)
{
string strComparisonOpDataBaseName = objvQxViewInfoCond.dicFldComparisonOp[convQxViewInfo.DataBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxViewInfo.DataBaseName, objvQxViewInfoCond.DataBaseName, strComparisonOpDataBaseName);
}
if (objvQxViewInfoCond.IsUpdated(convQxViewInfo.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objvQxViewInfoCond.dicFldComparisonOp[convQxViewInfo.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxViewInfo.QxPrjId, objvQxViewInfoCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objvQxViewInfoCond.IsUpdated(convQxViewInfo.PrjName) == true)
{
string strComparisonOpPrjName = objvQxViewInfoCond.dicFldComparisonOp[convQxViewInfo.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxViewInfo.PrjName, objvQxViewInfoCond.PrjName, strComparisonOpPrjName);
}
if (objvQxViewInfoCond.IsUpdated(convQxViewInfo.ViewFunction) == true)
{
string strComparisonOpViewFunction = objvQxViewInfoCond.dicFldComparisonOp[convQxViewInfo.ViewFunction];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxViewInfo.ViewFunction, objvQxViewInfoCond.ViewFunction, strComparisonOpViewFunction);
}
if (objvQxViewInfoCond.IsUpdated(convQxViewInfo.ViewDetail) == true)
{
string strComparisonOpViewDetail = objvQxViewInfoCond.dicFldComparisonOp[convQxViewInfo.ViewDetail];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxViewInfo.ViewDetail, objvQxViewInfoCond.ViewDetail, strComparisonOpViewDetail);
}
if (objvQxViewInfoCond.IsUpdated(convQxViewInfo.ModuleId) == true)
{
string strComparisonOpModuleId = objvQxViewInfoCond.dicFldComparisonOp[convQxViewInfo.ModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxViewInfo.ModuleId, objvQxViewInfoCond.ModuleId, strComparisonOpModuleId);
}
if (objvQxViewInfoCond.IsUpdated(convQxViewInfo.ModuleName) == true)
{
string strComparisonOpModuleName = objvQxViewInfoCond.dicFldComparisonOp[convQxViewInfo.ModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxViewInfo.ModuleName, objvQxViewInfoCond.ModuleName, strComparisonOpModuleName);
}
if (objvQxViewInfoCond.IsUpdated(convQxViewInfo.UpdDate) == true)
{
string strComparisonOpUpdDate = objvQxViewInfoCond.dicFldComparisonOp[convQxViewInfo.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxViewInfo.UpdDate, objvQxViewInfoCond.UpdDate, strComparisonOpUpdDate);
}
if (objvQxViewInfoCond.IsUpdated(convQxViewInfo.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvQxViewInfoCond.dicFldComparisonOp[convQxViewInfo.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxViewInfo.UpdUserId, objvQxViewInfoCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvQxViewInfoCond.IsUpdated(convQxViewInfo.Memo) == true)
{
string strComparisonOpMemo = objvQxViewInfoCond.dicFldComparisonOp[convQxViewInfo.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxViewInfo.Memo, objvQxViewInfoCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v界面信息(vQxViewInfo)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxViewInfoWApi
{
private static readonly string mstrApiControllerName = "vQxViewInfoApi";

 public clsvQxViewInfoWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_ViewId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v界面信息]...","0");
List<clsvQxViewInfoEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="ViewId";
objDDL.DataTextField="ViewName";
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

public static void BindCbo_ViewId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convQxViewInfo.ViewId); 
List<clsvQxViewInfoEN> arrObjLst = clsvQxViewInfoWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvQxViewInfoEN objvQxViewInfoEN = new clsvQxViewInfoEN()
{
ViewId = "0",
ViewName = "选[v界面信息]..."
};
arrObjLst.Insert(0, objvQxViewInfoEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convQxViewInfo.ViewId;
objComboBox.DisplayMember = convQxViewInfo.ViewName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strViewId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxViewInfoEN GetObjByViewId(string strViewId)
{
string strAction = "GetObjByViewId";
clsvQxViewInfoEN objvQxViewInfoEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strViewId"] = strViewId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvQxViewInfoEN = JsonConvert.DeserializeObject<clsvQxViewInfoEN>(strJson);
return objvQxViewInfoEN;
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
public static clsvQxViewInfoEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvQxViewInfoEN objvQxViewInfoEN;
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
objvQxViewInfoEN = JsonConvert.DeserializeObject<clsvQxViewInfoEN>(strJson);
return objvQxViewInfoEN;
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
//该表没有使用Cache,不需要生成[GetViewNameByViewIdCache]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxViewInfoEN> GetObjLst(string strWhereCond)
{
 List<clsvQxViewInfoEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxViewInfoEN>>(strJson);
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
 /// <param name = "arrViewId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxViewInfoEN> GetObjLstByViewIdLst(List<string> arrViewId)
{
 List<clsvQxViewInfoEN> arrObjLst; 
string strAction = "GetObjLstByViewIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrViewId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxViewInfoEN>>(strJson);
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
public static List<clsvQxViewInfoEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvQxViewInfoEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxViewInfoEN>>(strJson);
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
public static List<clsvQxViewInfoEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvQxViewInfoEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxViewInfoEN>>(strJson);
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
public static List<clsvQxViewInfoEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvQxViewInfoEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxViewInfoEN>>(strJson);
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
public static List<clsvQxViewInfoEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvQxViewInfoEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxViewInfoEN>>(strJson);
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
public static bool IsExist(string strViewId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strViewId"] = strViewId
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
 /// <param name = "objvQxViewInfoENS">源对象</param>
 /// <param name = "objvQxViewInfoENT">目标对象</param>
 public static void CopyTo(clsvQxViewInfoEN objvQxViewInfoENS, clsvQxViewInfoEN objvQxViewInfoENT)
{
try
{
objvQxViewInfoENT.ViewId = objvQxViewInfoENS.ViewId; //界面编号
objvQxViewInfoENT.ViewName = objvQxViewInfoENS.ViewName; //界面名称
objvQxViewInfoENT.ViewCnName = objvQxViewInfoENS.ViewCnName; //界面中文名称
objvQxViewInfoENT.FileName = objvQxViewInfoENS.FileName; //文件名
objvQxViewInfoENT.FilePath = objvQxViewInfoENS.FilePath; //文件路径
objvQxViewInfoENT.DefaMenuName = objvQxViewInfoENS.DefaMenuName; //缺省菜单名
objvQxViewInfoENT.ViewTypeCode = objvQxViewInfoENS.ViewTypeCode; //界面类型码
objvQxViewInfoENT.DataBaseName = objvQxViewInfoENS.DataBaseName; //数据库名称
objvQxViewInfoENT.QxPrjId = objvQxViewInfoENS.QxPrjId; //项目Id
objvQxViewInfoENT.PrjName = objvQxViewInfoENS.PrjName; //工程名
objvQxViewInfoENT.ViewFunction = objvQxViewInfoENS.ViewFunction; //界面功能
objvQxViewInfoENT.ViewDetail = objvQxViewInfoENS.ViewDetail; //界面详细信息
objvQxViewInfoENT.ModuleId = objvQxViewInfoENS.ModuleId; //模块号
objvQxViewInfoENT.ModuleName = objvQxViewInfoENS.ModuleName; //模块名称
objvQxViewInfoENT.UpdDate = objvQxViewInfoENS.UpdDate; //修改日期
objvQxViewInfoENT.UpdUserId = objvQxViewInfoENS.UpdUserId; //修改用户Id
objvQxViewInfoENT.Memo = objvQxViewInfoENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvQxViewInfoEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvQxViewInfoEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvQxViewInfoEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvQxViewInfoEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvQxViewInfoEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvQxViewInfoEN.AttributeName)
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
string strKey = string.Format("{0}", clsvQxViewInfoEN._CurrTabName);
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
public static DataTable GetDataTableByObjLst(List<clsvQxViewInfoEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convQxViewInfo.ViewId, Type.GetType("System.String"));
objDT.Columns.Add(convQxViewInfo.ViewName, Type.GetType("System.String"));
objDT.Columns.Add(convQxViewInfo.ViewCnName, Type.GetType("System.String"));
objDT.Columns.Add(convQxViewInfo.FileName, Type.GetType("System.String"));
objDT.Columns.Add(convQxViewInfo.FilePath, Type.GetType("System.String"));
objDT.Columns.Add(convQxViewInfo.DefaMenuName, Type.GetType("System.String"));
objDT.Columns.Add(convQxViewInfo.ViewTypeCode, Type.GetType("System.String"));
objDT.Columns.Add(convQxViewInfo.DataBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convQxViewInfo.QxPrjId, Type.GetType("System.String"));
objDT.Columns.Add(convQxViewInfo.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convQxViewInfo.ViewFunction, Type.GetType("System.String"));
objDT.Columns.Add(convQxViewInfo.ViewDetail, Type.GetType("System.String"));
objDT.Columns.Add(convQxViewInfo.ModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convQxViewInfo.ModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convQxViewInfo.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convQxViewInfo.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convQxViewInfo.Memo, Type.GetType("System.String"));
foreach (clsvQxViewInfoEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convQxViewInfo.ViewId] = objInFor[convQxViewInfo.ViewId];
objDR[convQxViewInfo.ViewName] = objInFor[convQxViewInfo.ViewName];
objDR[convQxViewInfo.ViewCnName] = objInFor[convQxViewInfo.ViewCnName];
objDR[convQxViewInfo.FileName] = objInFor[convQxViewInfo.FileName];
objDR[convQxViewInfo.FilePath] = objInFor[convQxViewInfo.FilePath];
objDR[convQxViewInfo.DefaMenuName] = objInFor[convQxViewInfo.DefaMenuName];
objDR[convQxViewInfo.ViewTypeCode] = objInFor[convQxViewInfo.ViewTypeCode];
objDR[convQxViewInfo.DataBaseName] = objInFor[convQxViewInfo.DataBaseName];
objDR[convQxViewInfo.QxPrjId] = objInFor[convQxViewInfo.QxPrjId];
objDR[convQxViewInfo.PrjName] = objInFor[convQxViewInfo.PrjName];
objDR[convQxViewInfo.ViewFunction] = objInFor[convQxViewInfo.ViewFunction];
objDR[convQxViewInfo.ViewDetail] = objInFor[convQxViewInfo.ViewDetail];
objDR[convQxViewInfo.ModuleId] = objInFor[convQxViewInfo.ModuleId];
objDR[convQxViewInfo.ModuleName] = objInFor[convQxViewInfo.ModuleName];
objDR[convQxViewInfo.UpdDate] = objInFor[convQxViewInfo.UpdDate];
objDR[convQxViewInfo.UpdUserId] = objInFor[convQxViewInfo.UpdUserId];
objDR[convQxViewInfo.Memo] = objInFor[convQxViewInfo.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}