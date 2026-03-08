
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxViewInfoWApi
 表名:QxViewInfo(00140017)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 18:22:44
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
public static class  clsQxViewInfoWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewId">界面编号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxViewInfoEN SetViewId(this clsQxViewInfoEN objQxViewInfoEN, string strViewId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewId, 8, conQxViewInfo.ViewId);
clsCheckSql.CheckFieldForeignKey(strViewId, 8, conQxViewInfo.ViewId);
objQxViewInfoEN.ViewId = strViewId; //界面编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxViewInfoEN.dicFldComparisonOp.ContainsKey(conQxViewInfo.ViewId) == false)
{
objQxViewInfoEN.dicFldComparisonOp.Add(conQxViewInfo.ViewId, strComparisonOp);
}
else
{
objQxViewInfoEN.dicFldComparisonOp[conQxViewInfo.ViewId] = strComparisonOp;
}
}
return objQxViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewName">界面名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxViewInfoEN SetViewName(this clsQxViewInfoEN objQxViewInfoEN, string strViewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewName, conQxViewInfo.ViewName);
clsCheckSql.CheckFieldLen(strViewName, 100, conQxViewInfo.ViewName);
objQxViewInfoEN.ViewName = strViewName; //界面名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxViewInfoEN.dicFldComparisonOp.ContainsKey(conQxViewInfo.ViewName) == false)
{
objQxViewInfoEN.dicFldComparisonOp.Add(conQxViewInfo.ViewName, strComparisonOp);
}
else
{
objQxViewInfoEN.dicFldComparisonOp[conQxViewInfo.ViewName] = strComparisonOp;
}
}
return objQxViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewCnName">界面中文名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxViewInfoEN SetViewCnName(this clsQxViewInfoEN objQxViewInfoEN, string strViewCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewCnName, conQxViewInfo.ViewCnName);
clsCheckSql.CheckFieldLen(strViewCnName, 50, conQxViewInfo.ViewCnName);
objQxViewInfoEN.ViewCnName = strViewCnName; //界面中文名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxViewInfoEN.dicFldComparisonOp.ContainsKey(conQxViewInfo.ViewCnName) == false)
{
objQxViewInfoEN.dicFldComparisonOp.Add(conQxViewInfo.ViewCnName, strComparisonOp);
}
else
{
objQxViewInfoEN.dicFldComparisonOp[conQxViewInfo.ViewCnName] = strComparisonOp;
}
}
return objQxViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strFileName">文件名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxViewInfoEN SetFileName(this clsQxViewInfoEN objQxViewInfoEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFileName, conQxViewInfo.FileName);
clsCheckSql.CheckFieldLen(strFileName, 500, conQxViewInfo.FileName);
objQxViewInfoEN.FileName = strFileName; //文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxViewInfoEN.dicFldComparisonOp.ContainsKey(conQxViewInfo.FileName) == false)
{
objQxViewInfoEN.dicFldComparisonOp.Add(conQxViewInfo.FileName, strComparisonOp);
}
else
{
objQxViewInfoEN.dicFldComparisonOp[conQxViewInfo.FileName] = strComparisonOp;
}
}
return objQxViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strFilePath">文件路径</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxViewInfoEN SetFilePath(this clsQxViewInfoEN objQxViewInfoEN, string strFilePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFilePath, conQxViewInfo.FilePath);
clsCheckSql.CheckFieldLen(strFilePath, 500, conQxViewInfo.FilePath);
objQxViewInfoEN.FilePath = strFilePath; //文件路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxViewInfoEN.dicFldComparisonOp.ContainsKey(conQxViewInfo.FilePath) == false)
{
objQxViewInfoEN.dicFldComparisonOp.Add(conQxViewInfo.FilePath, strComparisonOp);
}
else
{
objQxViewInfoEN.dicFldComparisonOp[conQxViewInfo.FilePath] = strComparisonOp;
}
}
return objQxViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strDefaMenuName">缺省菜单名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxViewInfoEN SetDefaMenuName(this clsQxViewInfoEN objQxViewInfoEN, string strDefaMenuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDefaMenuName, conQxViewInfo.DefaMenuName);
clsCheckSql.CheckFieldLen(strDefaMenuName, 50, conQxViewInfo.DefaMenuName);
objQxViewInfoEN.DefaMenuName = strDefaMenuName; //缺省菜单名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxViewInfoEN.dicFldComparisonOp.ContainsKey(conQxViewInfo.DefaMenuName) == false)
{
objQxViewInfoEN.dicFldComparisonOp.Add(conQxViewInfo.DefaMenuName, strComparisonOp);
}
else
{
objQxViewInfoEN.dicFldComparisonOp[conQxViewInfo.DefaMenuName] = strComparisonOp;
}
}
return objQxViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewTypeCode">界面类型码</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxViewInfoEN SetViewTypeCode(this clsQxViewInfoEN objQxViewInfoEN, string strViewTypeCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewTypeCode, conQxViewInfo.ViewTypeCode);
clsCheckSql.CheckFieldLen(strViewTypeCode, 4, conQxViewInfo.ViewTypeCode);
clsCheckSql.CheckFieldForeignKey(strViewTypeCode, 4, conQxViewInfo.ViewTypeCode);
objQxViewInfoEN.ViewTypeCode = strViewTypeCode; //界面类型码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxViewInfoEN.dicFldComparisonOp.ContainsKey(conQxViewInfo.ViewTypeCode) == false)
{
objQxViewInfoEN.dicFldComparisonOp.Add(conQxViewInfo.ViewTypeCode, strComparisonOp);
}
else
{
objQxViewInfoEN.dicFldComparisonOp[conQxViewInfo.ViewTypeCode] = strComparisonOp;
}
}
return objQxViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataBaseName">数据库名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxViewInfoEN SetDataBaseName(this clsQxViewInfoEN objQxViewInfoEN, string strDataBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataBaseName, 30, conQxViewInfo.DataBaseName);
objQxViewInfoEN.DataBaseName = strDataBaseName; //数据库名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxViewInfoEN.dicFldComparisonOp.ContainsKey(conQxViewInfo.DataBaseName) == false)
{
objQxViewInfoEN.dicFldComparisonOp.Add(conQxViewInfo.DataBaseName, strComparisonOp);
}
else
{
objQxViewInfoEN.dicFldComparisonOp[conQxViewInfo.DataBaseName] = strComparisonOp;
}
}
return objQxViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strQxPrjId">项目Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxViewInfoEN SetQxPrjId(this clsQxViewInfoEN objQxViewInfoEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, conQxViewInfo.QxPrjId);
clsCheckSql.CheckFieldLen(strQxPrjId, 4, conQxViewInfo.QxPrjId);
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, conQxViewInfo.QxPrjId);
objQxViewInfoEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxViewInfoEN.dicFldComparisonOp.ContainsKey(conQxViewInfo.QxPrjId) == false)
{
objQxViewInfoEN.dicFldComparisonOp.Add(conQxViewInfo.QxPrjId, strComparisonOp);
}
else
{
objQxViewInfoEN.dicFldComparisonOp[conQxViewInfo.QxPrjId] = strComparisonOp;
}
}
return objQxViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewFunction">界面功能</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxViewInfoEN SetViewFunction(this clsQxViewInfoEN objQxViewInfoEN, string strViewFunction, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewFunction, 100, conQxViewInfo.ViewFunction);
objQxViewInfoEN.ViewFunction = strViewFunction; //界面功能
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxViewInfoEN.dicFldComparisonOp.ContainsKey(conQxViewInfo.ViewFunction) == false)
{
objQxViewInfoEN.dicFldComparisonOp.Add(conQxViewInfo.ViewFunction, strComparisonOp);
}
else
{
objQxViewInfoEN.dicFldComparisonOp[conQxViewInfo.ViewFunction] = strComparisonOp;
}
}
return objQxViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewDetail">界面详细信息</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxViewInfoEN SetViewDetail(this clsQxViewInfoEN objQxViewInfoEN, string strViewDetail, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewDetail, 1000, conQxViewInfo.ViewDetail);
objQxViewInfoEN.ViewDetail = strViewDetail; //界面详细信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxViewInfoEN.dicFldComparisonOp.ContainsKey(conQxViewInfo.ViewDetail) == false)
{
objQxViewInfoEN.dicFldComparisonOp.Add(conQxViewInfo.ViewDetail, strComparisonOp);
}
else
{
objQxViewInfoEN.dicFldComparisonOp[conQxViewInfo.ViewDetail] = strComparisonOp;
}
}
return objQxViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strModuleId">模块号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxViewInfoEN SetModuleId(this clsQxViewInfoEN objQxViewInfoEN, string strModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModuleId, 6, conQxViewInfo.ModuleId);
clsCheckSql.CheckFieldForeignKey(strModuleId, 6, conQxViewInfo.ModuleId);
objQxViewInfoEN.ModuleId = strModuleId; //模块号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxViewInfoEN.dicFldComparisonOp.ContainsKey(conQxViewInfo.ModuleId) == false)
{
objQxViewInfoEN.dicFldComparisonOp.Add(conQxViewInfo.ModuleId, strComparisonOp);
}
else
{
objQxViewInfoEN.dicFldComparisonOp[conQxViewInfo.ModuleId] = strComparisonOp;
}
}
return objQxViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxViewInfoEN SetUpdDate(this clsQxViewInfoEN objQxViewInfoEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQxViewInfo.UpdDate);
objQxViewInfoEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxViewInfoEN.dicFldComparisonOp.ContainsKey(conQxViewInfo.UpdDate) == false)
{
objQxViewInfoEN.dicFldComparisonOp.Add(conQxViewInfo.UpdDate, strComparisonOp);
}
else
{
objQxViewInfoEN.dicFldComparisonOp[conQxViewInfo.UpdDate] = strComparisonOp;
}
}
return objQxViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxViewInfoEN SetUpdUserId(this clsQxViewInfoEN objQxViewInfoEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conQxViewInfo.UpdUserId);
objQxViewInfoEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxViewInfoEN.dicFldComparisonOp.ContainsKey(conQxViewInfo.UpdUserId) == false)
{
objQxViewInfoEN.dicFldComparisonOp.Add(conQxViewInfo.UpdUserId, strComparisonOp);
}
else
{
objQxViewInfoEN.dicFldComparisonOp[conQxViewInfo.UpdUserId] = strComparisonOp;
}
}
return objQxViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">备注</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxViewInfoEN SetMemo(this clsQxViewInfoEN objQxViewInfoEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQxViewInfo.Memo);
objQxViewInfoEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxViewInfoEN.dicFldComparisonOp.ContainsKey(conQxViewInfo.Memo) == false)
{
objQxViewInfoEN.dicFldComparisonOp.Add(conQxViewInfo.Memo, strComparisonOp);
}
else
{
objQxViewInfoEN.dicFldComparisonOp[conQxViewInfo.Memo] = strComparisonOp;
}
}
return objQxViewInfoEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQxViewInfoEN objQxViewInfoCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQxViewInfoCond.IsUpdated(conQxViewInfo.ViewId) == true)
{
string strComparisonOpViewId = objQxViewInfoCond.dicFldComparisonOp[conQxViewInfo.ViewId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxViewInfo.ViewId, objQxViewInfoCond.ViewId, strComparisonOpViewId);
}
if (objQxViewInfoCond.IsUpdated(conQxViewInfo.ViewName) == true)
{
string strComparisonOpViewName = objQxViewInfoCond.dicFldComparisonOp[conQxViewInfo.ViewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxViewInfo.ViewName, objQxViewInfoCond.ViewName, strComparisonOpViewName);
}
if (objQxViewInfoCond.IsUpdated(conQxViewInfo.ViewCnName) == true)
{
string strComparisonOpViewCnName = objQxViewInfoCond.dicFldComparisonOp[conQxViewInfo.ViewCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxViewInfo.ViewCnName, objQxViewInfoCond.ViewCnName, strComparisonOpViewCnName);
}
if (objQxViewInfoCond.IsUpdated(conQxViewInfo.FileName) == true)
{
string strComparisonOpFileName = objQxViewInfoCond.dicFldComparisonOp[conQxViewInfo.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxViewInfo.FileName, objQxViewInfoCond.FileName, strComparisonOpFileName);
}
if (objQxViewInfoCond.IsUpdated(conQxViewInfo.FilePath) == true)
{
string strComparisonOpFilePath = objQxViewInfoCond.dicFldComparisonOp[conQxViewInfo.FilePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxViewInfo.FilePath, objQxViewInfoCond.FilePath, strComparisonOpFilePath);
}
if (objQxViewInfoCond.IsUpdated(conQxViewInfo.DefaMenuName) == true)
{
string strComparisonOpDefaMenuName = objQxViewInfoCond.dicFldComparisonOp[conQxViewInfo.DefaMenuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxViewInfo.DefaMenuName, objQxViewInfoCond.DefaMenuName, strComparisonOpDefaMenuName);
}
if (objQxViewInfoCond.IsUpdated(conQxViewInfo.ViewTypeCode) == true)
{
string strComparisonOpViewTypeCode = objQxViewInfoCond.dicFldComparisonOp[conQxViewInfo.ViewTypeCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxViewInfo.ViewTypeCode, objQxViewInfoCond.ViewTypeCode, strComparisonOpViewTypeCode);
}
if (objQxViewInfoCond.IsUpdated(conQxViewInfo.DataBaseName) == true)
{
string strComparisonOpDataBaseName = objQxViewInfoCond.dicFldComparisonOp[conQxViewInfo.DataBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxViewInfo.DataBaseName, objQxViewInfoCond.DataBaseName, strComparisonOpDataBaseName);
}
if (objQxViewInfoCond.IsUpdated(conQxViewInfo.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objQxViewInfoCond.dicFldComparisonOp[conQxViewInfo.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxViewInfo.QxPrjId, objQxViewInfoCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objQxViewInfoCond.IsUpdated(conQxViewInfo.ViewFunction) == true)
{
string strComparisonOpViewFunction = objQxViewInfoCond.dicFldComparisonOp[conQxViewInfo.ViewFunction];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxViewInfo.ViewFunction, objQxViewInfoCond.ViewFunction, strComparisonOpViewFunction);
}
if (objQxViewInfoCond.IsUpdated(conQxViewInfo.ViewDetail) == true)
{
string strComparisonOpViewDetail = objQxViewInfoCond.dicFldComparisonOp[conQxViewInfo.ViewDetail];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxViewInfo.ViewDetail, objQxViewInfoCond.ViewDetail, strComparisonOpViewDetail);
}
if (objQxViewInfoCond.IsUpdated(conQxViewInfo.ModuleId) == true)
{
string strComparisonOpModuleId = objQxViewInfoCond.dicFldComparisonOp[conQxViewInfo.ModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxViewInfo.ModuleId, objQxViewInfoCond.ModuleId, strComparisonOpModuleId);
}
if (objQxViewInfoCond.IsUpdated(conQxViewInfo.UpdDate) == true)
{
string strComparisonOpUpdDate = objQxViewInfoCond.dicFldComparisonOp[conQxViewInfo.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxViewInfo.UpdDate, objQxViewInfoCond.UpdDate, strComparisonOpUpdDate);
}
if (objQxViewInfoCond.IsUpdated(conQxViewInfo.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objQxViewInfoCond.dicFldComparisonOp[conQxViewInfo.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxViewInfo.UpdUserId, objQxViewInfoCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objQxViewInfoCond.IsUpdated(conQxViewInfo.Memo) == true)
{
string strComparisonOpMemo = objQxViewInfoCond.dicFldComparisonOp[conQxViewInfo.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxViewInfo.Memo, objQxViewInfoCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objQxViewInfoEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxViewInfoEN objQxViewInfoEN)
{
 if (string.IsNullOrEmpty(objQxViewInfoEN.ViewId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objQxViewInfoEN.sfUpdFldSetStr = objQxViewInfoEN.getsfUpdFldSetStr();
clsQxViewInfoWApi.CheckPropertyNew(objQxViewInfoEN); 
bool bolResult = clsQxViewInfoWApi.UpdateRecord(objQxViewInfoEN);
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
 /// 获取唯一性条件串--QxViewInfo(界面), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ViewName_QxPrjId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objQxViewInfoEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsQxViewInfoEN objQxViewInfoEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objQxViewInfoEN == null) return "";
if (objQxViewInfoEN.ViewId == null || objQxViewInfoEN.ViewId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ViewName = '{0}'", objQxViewInfoEN.ViewName);
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxViewInfoEN.QxPrjId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ViewId !=  '{0}'", objQxViewInfoEN.ViewId);
 sbCondition.AppendFormat(" and ViewName = '{0}'", objQxViewInfoEN.ViewName);
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxViewInfoEN.QxPrjId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQxViewInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQxViewInfoEN objQxViewInfoEN)
{
 if (string.IsNullOrEmpty(objQxViewInfoEN.ViewId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQxViewInfoWApi.IsExist(objQxViewInfoEN.ViewId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQxViewInfoEN.ViewId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsQxViewInfoWApi.CheckPropertyNew(objQxViewInfoEN); 
bool bolResult = clsQxViewInfoWApi.AddNewRecord(objQxViewInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxViewInfoWApi.ReFreshCache();
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
 /// <param name = "objQxViewInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsQxViewInfoEN objQxViewInfoEN)
{
try
{
clsQxViewInfoWApi.CheckPropertyNew(objQxViewInfoEN); 
string strViewId = clsQxViewInfoWApi.AddNewRecordWithMaxId(objQxViewInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxViewInfoWApi.ReFreshCache();
return strViewId;
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
 /// <param name = "objQxViewInfoEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxViewInfoEN objQxViewInfoEN, string strWhereCond)
{
try
{
clsQxViewInfoWApi.CheckPropertyNew(objQxViewInfoEN); 
bool bolResult = clsQxViewInfoWApi.UpdateWithCondition(objQxViewInfoEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxViewInfoWApi.ReFreshCache();
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
 /// 界面(QxViewInfo)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsQxViewInfoWApi
{
private static readonly string mstrApiControllerName = "QxViewInfoApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsQxViewInfoWApi()
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[界面]...","0");
List<clsQxViewInfoEN> arrObjLst = GetObjLst("1=1");
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
string strCondition = string.Format("1 =1 Order By {0}", conQxViewInfo.ViewId); 
List<clsQxViewInfoEN> arrObjLst = clsQxViewInfoWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsQxViewInfoEN objQxViewInfoEN = new clsQxViewInfoEN()
{
ViewId = "0",
ViewName = "选[界面]..."
};
arrObjLst.Insert(0, objQxViewInfoEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conQxViewInfo.ViewId;
objComboBox.DisplayMember = conQxViewInfo.ViewName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsQxViewInfoEN objQxViewInfoEN)
{
if (!Object.Equals(null, objQxViewInfoEN.ViewId) && GetStrLen(objQxViewInfoEN.ViewId) > 8)
{
 throw new Exception("字段[界面编号]的长度不能超过8!");
}
if (!Object.Equals(null, objQxViewInfoEN.ViewName) && GetStrLen(objQxViewInfoEN.ViewName) > 100)
{
 throw new Exception("字段[界面名称]的长度不能超过100!");
}
if (!Object.Equals(null, objQxViewInfoEN.ViewCnName) && GetStrLen(objQxViewInfoEN.ViewCnName) > 50)
{
 throw new Exception("字段[界面中文名称]的长度不能超过50!");
}
if (!Object.Equals(null, objQxViewInfoEN.FileName) && GetStrLen(objQxViewInfoEN.FileName) > 500)
{
 throw new Exception("字段[文件名]的长度不能超过500!");
}
if (!Object.Equals(null, objQxViewInfoEN.FilePath) && GetStrLen(objQxViewInfoEN.FilePath) > 500)
{
 throw new Exception("字段[文件路径]的长度不能超过500!");
}
if (!Object.Equals(null, objQxViewInfoEN.DefaMenuName) && GetStrLen(objQxViewInfoEN.DefaMenuName) > 50)
{
 throw new Exception("字段[缺省菜单名]的长度不能超过50!");
}
if (!Object.Equals(null, objQxViewInfoEN.ViewTypeCode) && GetStrLen(objQxViewInfoEN.ViewTypeCode) > 4)
{
 throw new Exception("字段[界面类型码]的长度不能超过4!");
}
if (!Object.Equals(null, objQxViewInfoEN.DataBaseName) && GetStrLen(objQxViewInfoEN.DataBaseName) > 30)
{
 throw new Exception("字段[数据库名称]的长度不能超过30!");
}
if (!Object.Equals(null, objQxViewInfoEN.QxPrjId) && GetStrLen(objQxViewInfoEN.QxPrjId) > 4)
{
 throw new Exception("字段[项目Id]的长度不能超过4!");
}
if (!Object.Equals(null, objQxViewInfoEN.ViewFunction) && GetStrLen(objQxViewInfoEN.ViewFunction) > 100)
{
 throw new Exception("字段[界面功能]的长度不能超过100!");
}
if (!Object.Equals(null, objQxViewInfoEN.ViewDetail) && GetStrLen(objQxViewInfoEN.ViewDetail) > 1000)
{
 throw new Exception("字段[界面详细信息]的长度不能超过1000!");
}
if (!Object.Equals(null, objQxViewInfoEN.ModuleId) && GetStrLen(objQxViewInfoEN.ModuleId) > 6)
{
 throw new Exception("字段[模块号]的长度不能超过6!");
}
if (!Object.Equals(null, objQxViewInfoEN.UpdDate) && GetStrLen(objQxViewInfoEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objQxViewInfoEN.UpdUserId) && GetStrLen(objQxViewInfoEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objQxViewInfoEN.Memo) && GetStrLen(objQxViewInfoEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objQxViewInfoEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strViewId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxViewInfoEN GetObjByViewId(string strViewId)
{
string strAction = "GetObjByViewId";
clsQxViewInfoEN objQxViewInfoEN;
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
objQxViewInfoEN = JsonConvert.DeserializeObject<clsQxViewInfoEN>(strJson);
return objQxViewInfoEN;
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
public static clsQxViewInfoEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsQxViewInfoEN objQxViewInfoEN;
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
objQxViewInfoEN = JsonConvert.DeserializeObject<clsQxViewInfoEN>(strJson);
return objQxViewInfoEN;
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
public static List<clsQxViewInfoEN> GetObjLst(string strWhereCond)
{
 List<clsQxViewInfoEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxViewInfoEN>>(strJson);
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
public static List<clsQxViewInfoEN> GetObjLstByViewIdLst(List<string> arrViewId)
{
 List<clsQxViewInfoEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxViewInfoEN>>(strJson);
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
public static List<clsQxViewInfoEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsQxViewInfoEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxViewInfoEN>>(strJson);
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
public static List<clsQxViewInfoEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsQxViewInfoEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxViewInfoEN>>(strJson);
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
public static List<clsQxViewInfoEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsQxViewInfoEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxViewInfoEN>>(strJson);
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
public static List<clsQxViewInfoEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsQxViewInfoEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxViewInfoEN>>(strJson);
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
public static int DelRecord(string strViewId)
{
string strAction = "DelRecord";
try
{
 clsQxViewInfoEN objQxViewInfoEN = clsQxViewInfoWApi.GetObjByViewId(strViewId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strViewId.ToString(), out string strResult, out string strErrMsg) == true)
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
public static int DelQxViewInfos(List<string> arrViewId)
{
string strAction = "DelQxViewInfos";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrViewId);
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
public static int DelQxViewInfosByCond(string strWhereCond)
{
string strAction = "DelQxViewInfosByCond";
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
public static bool AddNewRecord(clsQxViewInfoEN objQxViewInfoEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxViewInfoEN>(objQxViewInfoEN);
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
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithMaxId)
 /// </summary>
 /// <returns>新建记录的关键字</returns>
public static string AddNewRecordWithMaxId(clsQxViewInfoEN objQxViewInfoEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxViewInfoEN>(objQxViewInfoEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
var strViewId = (string)jobjReturn0["returnStr"];
return strViewId;
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
public static bool UpdateRecord(clsQxViewInfoEN objQxViewInfoEN)
{
if (string.IsNullOrEmpty(objQxViewInfoEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objQxViewInfoEN.ViewId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxViewInfoEN>(objQxViewInfoEN);
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
 /// <param name = "objQxViewInfoEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsQxViewInfoEN objQxViewInfoEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objQxViewInfoEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objQxViewInfoEN.ViewId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objQxViewInfoEN.ViewId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxViewInfoEN>(objQxViewInfoEN);
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
 /// <param name = "objQxViewInfoENS">源对象</param>
 /// <param name = "objQxViewInfoENT">目标对象</param>
 public static void CopyTo(clsQxViewInfoEN objQxViewInfoENS, clsQxViewInfoEN objQxViewInfoENT)
{
try
{
objQxViewInfoENT.ViewId = objQxViewInfoENS.ViewId; //界面编号
objQxViewInfoENT.ViewName = objQxViewInfoENS.ViewName; //界面名称
objQxViewInfoENT.ViewCnName = objQxViewInfoENS.ViewCnName; //界面中文名称
objQxViewInfoENT.FileName = objQxViewInfoENS.FileName; //文件名
objQxViewInfoENT.FilePath = objQxViewInfoENS.FilePath; //文件路径
objQxViewInfoENT.DefaMenuName = objQxViewInfoENS.DefaMenuName; //缺省菜单名
objQxViewInfoENT.ViewTypeCode = objQxViewInfoENS.ViewTypeCode; //界面类型码
objQxViewInfoENT.DataBaseName = objQxViewInfoENS.DataBaseName; //数据库名称
objQxViewInfoENT.QxPrjId = objQxViewInfoENS.QxPrjId; //项目Id
objQxViewInfoENT.ViewFunction = objQxViewInfoENS.ViewFunction; //界面功能
objQxViewInfoENT.ViewDetail = objQxViewInfoENS.ViewDetail; //界面详细信息
objQxViewInfoENT.ModuleId = objQxViewInfoENS.ModuleId; //模块号
objQxViewInfoENT.UpdDate = objQxViewInfoENS.UpdDate; //修改日期
objQxViewInfoENT.UpdUserId = objQxViewInfoENS.UpdUserId; //修改用户Id
objQxViewInfoENT.Memo = objQxViewInfoENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsQxViewInfoEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsQxViewInfoEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsQxViewInfoEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsQxViewInfoEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsQxViewInfoEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsQxViewInfoEN.AttributeName)
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
string strKey = string.Format("{0}", clsQxViewInfoEN._CurrTabName);
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
if (clsQxViewInfoWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsQxViewInfoEN._CurrTabName);
CacheHelper.Remove(strKey);
clsQxViewInfoWApi.objCommFun4WApi.ReFreshCache();
}
}
//该表没有使用Cache,不需要生成[GetObjLstCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsQxViewInfoEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conQxViewInfo.ViewId, Type.GetType("System.String"));
objDT.Columns.Add(conQxViewInfo.ViewName, Type.GetType("System.String"));
objDT.Columns.Add(conQxViewInfo.ViewCnName, Type.GetType("System.String"));
objDT.Columns.Add(conQxViewInfo.FileName, Type.GetType("System.String"));
objDT.Columns.Add(conQxViewInfo.FilePath, Type.GetType("System.String"));
objDT.Columns.Add(conQxViewInfo.DefaMenuName, Type.GetType("System.String"));
objDT.Columns.Add(conQxViewInfo.ViewTypeCode, Type.GetType("System.String"));
objDT.Columns.Add(conQxViewInfo.DataBaseName, Type.GetType("System.String"));
objDT.Columns.Add(conQxViewInfo.QxPrjId, Type.GetType("System.String"));
objDT.Columns.Add(conQxViewInfo.ViewFunction, Type.GetType("System.String"));
objDT.Columns.Add(conQxViewInfo.ViewDetail, Type.GetType("System.String"));
objDT.Columns.Add(conQxViewInfo.ModuleId, Type.GetType("System.String"));
objDT.Columns.Add(conQxViewInfo.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conQxViewInfo.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conQxViewInfo.Memo, Type.GetType("System.String"));
foreach (clsQxViewInfoEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conQxViewInfo.ViewId] = objInFor[conQxViewInfo.ViewId];
objDR[conQxViewInfo.ViewName] = objInFor[conQxViewInfo.ViewName];
objDR[conQxViewInfo.ViewCnName] = objInFor[conQxViewInfo.ViewCnName];
objDR[conQxViewInfo.FileName] = objInFor[conQxViewInfo.FileName];
objDR[conQxViewInfo.FilePath] = objInFor[conQxViewInfo.FilePath];
objDR[conQxViewInfo.DefaMenuName] = objInFor[conQxViewInfo.DefaMenuName];
objDR[conQxViewInfo.ViewTypeCode] = objInFor[conQxViewInfo.ViewTypeCode];
objDR[conQxViewInfo.DataBaseName] = objInFor[conQxViewInfo.DataBaseName];
objDR[conQxViewInfo.QxPrjId] = objInFor[conQxViewInfo.QxPrjId];
objDR[conQxViewInfo.ViewFunction] = objInFor[conQxViewInfo.ViewFunction];
objDR[conQxViewInfo.ViewDetail] = objInFor[conQxViewInfo.ViewDetail];
objDR[conQxViewInfo.ModuleId] = objInFor[conQxViewInfo.ModuleId];
objDR[conQxViewInfo.UpdDate] = objInFor[conQxViewInfo.UpdDate];
objDR[conQxViewInfo.UpdUserId] = objInFor[conQxViewInfo.UpdUserId];
objDR[conQxViewInfo.Memo] = objInFor[conQxViewInfo.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 界面(QxViewInfo)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4QxViewInfo : clsCommFun4BL
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
clsQxViewInfoWApi.ReFreshThisCache();
}
}

}