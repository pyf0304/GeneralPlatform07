
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPrjMenus_UpWApi
 表名:vQxPrjMenus_Up(00140080)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 18:31:43
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:菜单管理(MenuManage_GP)
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
public static class  clsvQxPrjMenus_UpWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_UpEN">需要设置字段值的实体对象</param>
 /// <param name = "strMenuIdUp">MenuId_Up</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_UpEN SetMenuIdUp(this clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN, string strMenuIdUp, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMenuIdUp, 8, convQxPrjMenus_Up.MenuIdUp);
clsCheckSql.CheckFieldForeignKey(strMenuIdUp, 8, convQxPrjMenus_Up.MenuIdUp);
objvQxPrjMenus_UpEN.MenuIdUp = strMenuIdUp; //MenuId_Up
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_UpEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Up.MenuIdUp) == false)
{
objvQxPrjMenus_UpEN.dicFldComparisonOp.Add(convQxPrjMenus_Up.MenuIdUp, strComparisonOp);
}
else
{
objvQxPrjMenus_UpEN.dicFldComparisonOp[convQxPrjMenus_Up.MenuIdUp] = strComparisonOp;
}
}
return objvQxPrjMenus_UpEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_UpEN">需要设置字段值的实体对象</param>
 /// <param name = "strMenuName">菜单名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_UpEN SetMenuName(this clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN, string strMenuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMenuName, convQxPrjMenus_Up.MenuName);
clsCheckSql.CheckFieldLen(strMenuName, 50, convQxPrjMenus_Up.MenuName);
objvQxPrjMenus_UpEN.MenuName = strMenuName; //菜单名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_UpEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Up.MenuName) == false)
{
objvQxPrjMenus_UpEN.dicFldComparisonOp.Add(convQxPrjMenus_Up.MenuName, strComparisonOp);
}
else
{
objvQxPrjMenus_UpEN.dicFldComparisonOp[convQxPrjMenus_Up.MenuName] = strComparisonOp;
}
}
return objvQxPrjMenus_UpEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_UpEN">需要设置字段值的实体对象</param>
 /// <param name = "strQxPrjId">项目Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_UpEN SetQxPrjId(this clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxPrjMenus_Up.QxPrjId);
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxPrjMenus_Up.QxPrjId);
objvQxPrjMenus_UpEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_UpEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Up.QxPrjId) == false)
{
objvQxPrjMenus_UpEN.dicFldComparisonOp.Add(convQxPrjMenus_Up.QxPrjId, strComparisonOp);
}
else
{
objvQxPrjMenus_UpEN.dicFldComparisonOp[convQxPrjMenus_Up.QxPrjId] = strComparisonOp;
}
}
return objvQxPrjMenus_UpEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_UpEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_UpEN SetPrjName(this clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjName, 30, convQxPrjMenus_Up.PrjName);
objvQxPrjMenus_UpEN.PrjName = strPrjName; //工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_UpEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Up.PrjName) == false)
{
objvQxPrjMenus_UpEN.dicFldComparisonOp.Add(convQxPrjMenus_Up.PrjName, strComparisonOp);
}
else
{
objvQxPrjMenus_UpEN.dicFldComparisonOp[convQxPrjMenus_Up.PrjName] = strComparisonOp;
}
}
return objvQxPrjMenus_UpEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_UpEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpMenuId">上级菜单Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_UpEN SetUpMenuId(this clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN, string strUpMenuId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpMenuId, 8, convQxPrjMenus_Up.UpMenuId);
clsCheckSql.CheckFieldForeignKey(strUpMenuId, 8, convQxPrjMenus_Up.UpMenuId);
objvQxPrjMenus_UpEN.UpMenuId = strUpMenuId; //上级菜单Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_UpEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Up.UpMenuId) == false)
{
objvQxPrjMenus_UpEN.dicFldComparisonOp.Add(convQxPrjMenus_Up.UpMenuId, strComparisonOp);
}
else
{
objvQxPrjMenus_UpEN.dicFldComparisonOp[convQxPrjMenus_Up.UpMenuId] = strComparisonOp;
}
}
return objvQxPrjMenus_UpEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_UpEN">需要设置字段值的实体对象</param>
 /// <param name = "strLinkFile">链接文件</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_UpEN SetLinkFile(this clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN, string strLinkFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLinkFile, 500, convQxPrjMenus_Up.LinkFile);
objvQxPrjMenus_UpEN.LinkFile = strLinkFile; //链接文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_UpEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Up.LinkFile) == false)
{
objvQxPrjMenus_UpEN.dicFldComparisonOp.Add(convQxPrjMenus_Up.LinkFile, strComparisonOp);
}
else
{
objvQxPrjMenus_UpEN.dicFldComparisonOp[convQxPrjMenus_Up.LinkFile] = strComparisonOp;
}
}
return objvQxPrjMenus_UpEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_UpEN">需要设置字段值的实体对象</param>
 /// <param name = "strqsParameters">qs参数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_UpEN SetqsParameters(this clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN, string strqsParameters, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strqsParameters, 200, convQxPrjMenus_Up.qsParameters);
objvQxPrjMenus_UpEN.qsParameters = strqsParameters; //qs参数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_UpEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Up.qsParameters) == false)
{
objvQxPrjMenus_UpEN.dicFldComparisonOp.Add(convQxPrjMenus_Up.qsParameters, strComparisonOp);
}
else
{
objvQxPrjMenus_UpEN.dicFldComparisonOp[convQxPrjMenus_Up.qsParameters] = strComparisonOp;
}
}
return objvQxPrjMenus_UpEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_UpEN">需要设置字段值的实体对象</param>
 /// <param name = "strImgFile">图像文件</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_UpEN SetImgFile(this clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN, string strImgFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strImgFile, 300, convQxPrjMenus_Up.ImgFile);
objvQxPrjMenus_UpEN.ImgFile = strImgFile; //图像文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_UpEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Up.ImgFile) == false)
{
objvQxPrjMenus_UpEN.dicFldComparisonOp.Add(convQxPrjMenus_Up.ImgFile, strComparisonOp);
}
else
{
objvQxPrjMenus_UpEN.dicFldComparisonOp[convQxPrjMenus_Up.ImgFile] = strComparisonOp;
}
}
return objvQxPrjMenus_UpEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_UpEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">排序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_UpEN SetOrderNum(this clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN, int intOrderNum, string strComparisonOp="")
	{
objvQxPrjMenus_UpEN.OrderNum = intOrderNum; //排序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_UpEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Up.OrderNum) == false)
{
objvQxPrjMenus_UpEN.dicFldComparisonOp.Add(convQxPrjMenus_Up.OrderNum, strComparisonOp);
}
else
{
objvQxPrjMenus_UpEN.dicFldComparisonOp[convQxPrjMenus_Up.OrderNum] = strComparisonOp;
}
}
return objvQxPrjMenus_UpEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_UpEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsLeafNode">是否叶子</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_UpEN SetIsLeafNode(this clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN, bool bolIsLeafNode, string strComparisonOp="")
	{
objvQxPrjMenus_UpEN.IsLeafNode = bolIsLeafNode; //是否叶子
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_UpEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Up.IsLeafNode) == false)
{
objvQxPrjMenus_UpEN.dicFldComparisonOp.Add(convQxPrjMenus_Up.IsLeafNode, strComparisonOp);
}
else
{
objvQxPrjMenus_UpEN.dicFldComparisonOp[convQxPrjMenus_Up.IsLeafNode] = strComparisonOp;
}
}
return objvQxPrjMenus_UpEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_UpEN">需要设置字段值的实体对象</param>
 /// <param name = "strMenuSetId">菜单集Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_UpEN SetMenuSetId(this clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN, string strMenuSetId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMenuSetId, convQxPrjMenus_Up.MenuSetId);
clsCheckSql.CheckFieldLen(strMenuSetId, 4, convQxPrjMenus_Up.MenuSetId);
clsCheckSql.CheckFieldForeignKey(strMenuSetId, 4, convQxPrjMenus_Up.MenuSetId);
objvQxPrjMenus_UpEN.MenuSetId = strMenuSetId; //菜单集Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_UpEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Up.MenuSetId) == false)
{
objvQxPrjMenus_UpEN.dicFldComparisonOp.Add(convQxPrjMenus_Up.MenuSetId, strComparisonOp);
}
else
{
objvQxPrjMenus_UpEN.dicFldComparisonOp[convQxPrjMenus_Up.MenuSetId] = strComparisonOp;
}
}
return objvQxPrjMenus_UpEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_UpEN">需要设置字段值的实体对象</param>
 /// <param name = "strMenuSetName">菜单集名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_UpEN SetMenuSetName(this clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN, string strMenuSetName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMenuSetName, 50, convQxPrjMenus_Up.MenuSetName);
objvQxPrjMenus_UpEN.MenuSetName = strMenuSetName; //菜单集名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_UpEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Up.MenuSetName) == false)
{
objvQxPrjMenus_UpEN.dicFldComparisonOp.Add(convQxPrjMenus_Up.MenuSetName, strComparisonOp);
}
else
{
objvQxPrjMenus_UpEN.dicFldComparisonOp[convQxPrjMenus_Up.MenuSetName] = strComparisonOp;
}
}
return objvQxPrjMenus_UpEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_UpEN">需要设置字段值的实体对象</param>
 /// <param name = "strMenuTitle">菜单标题</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_UpEN SetMenuTitle(this clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN, string strMenuTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMenuTitle, 50, convQxPrjMenus_Up.MenuTitle);
objvQxPrjMenus_UpEN.MenuTitle = strMenuTitle; //菜单标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_UpEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Up.MenuTitle) == false)
{
objvQxPrjMenus_UpEN.dicFldComparisonOp.Add(convQxPrjMenus_Up.MenuTitle, strComparisonOp);
}
else
{
objvQxPrjMenus_UpEN.dicFldComparisonOp[convQxPrjMenus_Up.MenuTitle] = strComparisonOp;
}
}
return objvQxPrjMenus_UpEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_UpEN">需要设置字段值的实体对象</param>
 /// <param name = "strPageDispModeId">页面显示模式Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_UpEN SetPageDispModeId(this clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN, string strPageDispModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPageDispModeId, 2, convQxPrjMenus_Up.PageDispModeId);
clsCheckSql.CheckFieldForeignKey(strPageDispModeId, 2, convQxPrjMenus_Up.PageDispModeId);
objvQxPrjMenus_UpEN.PageDispModeId = strPageDispModeId; //页面显示模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_UpEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Up.PageDispModeId) == false)
{
objvQxPrjMenus_UpEN.dicFldComparisonOp.Add(convQxPrjMenus_Up.PageDispModeId, strComparisonOp);
}
else
{
objvQxPrjMenus_UpEN.dicFldComparisonOp[convQxPrjMenus_Up.PageDispModeId] = strComparisonOp;
}
}
return objvQxPrjMenus_UpEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_UpEN">需要设置字段值的实体对象</param>
 /// <param name = "strPageDispModeName">页面显示模式名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_UpEN SetPageDispModeName(this clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN, string strPageDispModeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPageDispModeName, 50, convQxPrjMenus_Up.PageDispModeName);
objvQxPrjMenus_UpEN.PageDispModeName = strPageDispModeName; //页面显示模式名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_UpEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Up.PageDispModeName) == false)
{
objvQxPrjMenus_UpEN.dicFldComparisonOp.Add(convQxPrjMenus_Up.PageDispModeName, strComparisonOp);
}
else
{
objvQxPrjMenus_UpEN.dicFldComparisonOp[convQxPrjMenus_Up.PageDispModeName] = strComparisonOp;
}
}
return objvQxPrjMenus_UpEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_UpEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_UpEN SetInUse(this clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN, bool bolInUse, string strComparisonOp="")
	{
objvQxPrjMenus_UpEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_UpEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Up.InUse) == false)
{
objvQxPrjMenus_UpEN.dicFldComparisonOp.Add(convQxPrjMenus_Up.InUse, strComparisonOp);
}
else
{
objvQxPrjMenus_UpEN.dicFldComparisonOp[convQxPrjMenus_Up.InUse] = strComparisonOp;
}
}
return objvQxPrjMenus_UpEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_UpEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_UpEN SetUpdDate(this clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQxPrjMenus_Up.UpdDate);
objvQxPrjMenus_UpEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_UpEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Up.UpdDate) == false)
{
objvQxPrjMenus_UpEN.dicFldComparisonOp.Add(convQxPrjMenus_Up.UpdDate, strComparisonOp);
}
else
{
objvQxPrjMenus_UpEN.dicFldComparisonOp[convQxPrjMenus_Up.UpdDate] = strComparisonOp;
}
}
return objvQxPrjMenus_UpEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_UpEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_UpEN SetUpdUserId(this clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convQxPrjMenus_Up.UpdUserId);
objvQxPrjMenus_UpEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_UpEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Up.UpdUserId) == false)
{
objvQxPrjMenus_UpEN.dicFldComparisonOp.Add(convQxPrjMenus_Up.UpdUserId, strComparisonOp);
}
else
{
objvQxPrjMenus_UpEN.dicFldComparisonOp[convQxPrjMenus_Up.UpdUserId] = strComparisonOp;
}
}
return objvQxPrjMenus_UpEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_UpEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">备注</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_UpEN SetMemo(this clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxPrjMenus_Up.Memo);
objvQxPrjMenus_UpEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_UpEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Up.Memo) == false)
{
objvQxPrjMenus_UpEN.dicFldComparisonOp.Add(convQxPrjMenus_Up.Memo, strComparisonOp);
}
else
{
objvQxPrjMenus_UpEN.dicFldComparisonOp[convQxPrjMenus_Up.Memo] = strComparisonOp;
}
}
return objvQxPrjMenus_UpEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_UpEN">需要设置字段值的实体对象</param>
 /// <param name = "strMenuControlName">MenuControlName</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_UpEN SetMenuControlName(this clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN, string strMenuControlName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMenuControlName, 100, convQxPrjMenus_Up.MenuControlName);
objvQxPrjMenus_UpEN.MenuControlName = strMenuControlName; //MenuControlName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_UpEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Up.MenuControlName) == false)
{
objvQxPrjMenus_UpEN.dicFldComparisonOp.Add(convQxPrjMenus_Up.MenuControlName, strComparisonOp);
}
else
{
objvQxPrjMenus_UpEN.dicFldComparisonOp[convQxPrjMenus_Up.MenuControlName] = strComparisonOp;
}
}
return objvQxPrjMenus_UpEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQxPrjMenus_UpEN objvQxPrjMenus_UpCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQxPrjMenus_UpCond.IsUpdated(convQxPrjMenus_Up.MenuIdUp) == true)
{
string strComparisonOpMenuIdUp = objvQxPrjMenus_UpCond.dicFldComparisonOp[convQxPrjMenus_Up.MenuIdUp];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus_Up.MenuIdUp, objvQxPrjMenus_UpCond.MenuIdUp, strComparisonOpMenuIdUp);
}
if (objvQxPrjMenus_UpCond.IsUpdated(convQxPrjMenus_Up.MenuName) == true)
{
string strComparisonOpMenuName = objvQxPrjMenus_UpCond.dicFldComparisonOp[convQxPrjMenus_Up.MenuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus_Up.MenuName, objvQxPrjMenus_UpCond.MenuName, strComparisonOpMenuName);
}
if (objvQxPrjMenus_UpCond.IsUpdated(convQxPrjMenus_Up.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objvQxPrjMenus_UpCond.dicFldComparisonOp[convQxPrjMenus_Up.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus_Up.QxPrjId, objvQxPrjMenus_UpCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objvQxPrjMenus_UpCond.IsUpdated(convQxPrjMenus_Up.PrjName) == true)
{
string strComparisonOpPrjName = objvQxPrjMenus_UpCond.dicFldComparisonOp[convQxPrjMenus_Up.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus_Up.PrjName, objvQxPrjMenus_UpCond.PrjName, strComparisonOpPrjName);
}
if (objvQxPrjMenus_UpCond.IsUpdated(convQxPrjMenus_Up.UpMenuId) == true)
{
string strComparisonOpUpMenuId = objvQxPrjMenus_UpCond.dicFldComparisonOp[convQxPrjMenus_Up.UpMenuId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus_Up.UpMenuId, objvQxPrjMenus_UpCond.UpMenuId, strComparisonOpUpMenuId);
}
if (objvQxPrjMenus_UpCond.IsUpdated(convQxPrjMenus_Up.LinkFile) == true)
{
string strComparisonOpLinkFile = objvQxPrjMenus_UpCond.dicFldComparisonOp[convQxPrjMenus_Up.LinkFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus_Up.LinkFile, objvQxPrjMenus_UpCond.LinkFile, strComparisonOpLinkFile);
}
if (objvQxPrjMenus_UpCond.IsUpdated(convQxPrjMenus_Up.qsParameters) == true)
{
string strComparisonOpqsParameters = objvQxPrjMenus_UpCond.dicFldComparisonOp[convQxPrjMenus_Up.qsParameters];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus_Up.qsParameters, objvQxPrjMenus_UpCond.qsParameters, strComparisonOpqsParameters);
}
if (objvQxPrjMenus_UpCond.IsUpdated(convQxPrjMenus_Up.ImgFile) == true)
{
string strComparisonOpImgFile = objvQxPrjMenus_UpCond.dicFldComparisonOp[convQxPrjMenus_Up.ImgFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus_Up.ImgFile, objvQxPrjMenus_UpCond.ImgFile, strComparisonOpImgFile);
}
if (objvQxPrjMenus_UpCond.IsUpdated(convQxPrjMenus_Up.OrderNum) == true)
{
string strComparisonOpOrderNum = objvQxPrjMenus_UpCond.dicFldComparisonOp[convQxPrjMenus_Up.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQxPrjMenus_Up.OrderNum, objvQxPrjMenus_UpCond.OrderNum, strComparisonOpOrderNum);
}
if (objvQxPrjMenus_UpCond.IsUpdated(convQxPrjMenus_Up.IsLeafNode) == true)
{
if (objvQxPrjMenus_UpCond.IsLeafNode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQxPrjMenus_Up.IsLeafNode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQxPrjMenus_Up.IsLeafNode);
}
}
if (objvQxPrjMenus_UpCond.IsUpdated(convQxPrjMenus_Up.MenuSetId) == true)
{
string strComparisonOpMenuSetId = objvQxPrjMenus_UpCond.dicFldComparisonOp[convQxPrjMenus_Up.MenuSetId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus_Up.MenuSetId, objvQxPrjMenus_UpCond.MenuSetId, strComparisonOpMenuSetId);
}
if (objvQxPrjMenus_UpCond.IsUpdated(convQxPrjMenus_Up.MenuSetName) == true)
{
string strComparisonOpMenuSetName = objvQxPrjMenus_UpCond.dicFldComparisonOp[convQxPrjMenus_Up.MenuSetName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus_Up.MenuSetName, objvQxPrjMenus_UpCond.MenuSetName, strComparisonOpMenuSetName);
}
if (objvQxPrjMenus_UpCond.IsUpdated(convQxPrjMenus_Up.MenuTitle) == true)
{
string strComparisonOpMenuTitle = objvQxPrjMenus_UpCond.dicFldComparisonOp[convQxPrjMenus_Up.MenuTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus_Up.MenuTitle, objvQxPrjMenus_UpCond.MenuTitle, strComparisonOpMenuTitle);
}
if (objvQxPrjMenus_UpCond.IsUpdated(convQxPrjMenus_Up.PageDispModeId) == true)
{
string strComparisonOpPageDispModeId = objvQxPrjMenus_UpCond.dicFldComparisonOp[convQxPrjMenus_Up.PageDispModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus_Up.PageDispModeId, objvQxPrjMenus_UpCond.PageDispModeId, strComparisonOpPageDispModeId);
}
if (objvQxPrjMenus_UpCond.IsUpdated(convQxPrjMenus_Up.PageDispModeName) == true)
{
string strComparisonOpPageDispModeName = objvQxPrjMenus_UpCond.dicFldComparisonOp[convQxPrjMenus_Up.PageDispModeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus_Up.PageDispModeName, objvQxPrjMenus_UpCond.PageDispModeName, strComparisonOpPageDispModeName);
}
if (objvQxPrjMenus_UpCond.IsUpdated(convQxPrjMenus_Up.InUse) == true)
{
if (objvQxPrjMenus_UpCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQxPrjMenus_Up.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQxPrjMenus_Up.InUse);
}
}
if (objvQxPrjMenus_UpCond.IsUpdated(convQxPrjMenus_Up.UpdDate) == true)
{
string strComparisonOpUpdDate = objvQxPrjMenus_UpCond.dicFldComparisonOp[convQxPrjMenus_Up.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus_Up.UpdDate, objvQxPrjMenus_UpCond.UpdDate, strComparisonOpUpdDate);
}
if (objvQxPrjMenus_UpCond.IsUpdated(convQxPrjMenus_Up.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvQxPrjMenus_UpCond.dicFldComparisonOp[convQxPrjMenus_Up.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus_Up.UpdUserId, objvQxPrjMenus_UpCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvQxPrjMenus_UpCond.IsUpdated(convQxPrjMenus_Up.Memo) == true)
{
string strComparisonOpMemo = objvQxPrjMenus_UpCond.dicFldComparisonOp[convQxPrjMenus_Up.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus_Up.Memo, objvQxPrjMenus_UpCond.Memo, strComparisonOpMemo);
}
if (objvQxPrjMenus_UpCond.IsUpdated(convQxPrjMenus_Up.MenuControlName) == true)
{
string strComparisonOpMenuControlName = objvQxPrjMenus_UpCond.dicFldComparisonOp[convQxPrjMenus_Up.MenuControlName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus_Up.MenuControlName, objvQxPrjMenus_UpCond.MenuControlName, strComparisonOpMenuControlName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v顶层菜单(vQxPrjMenus_Up)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxPrjMenus_UpWApi
{
private static readonly string mstrApiControllerName = "vQxPrjMenus_UpApi";

 public clsvQxPrjMenus_UpWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_MenuIdUp(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v顶层菜单]...","0");
List<clsvQxPrjMenus_UpEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="MenuIdUp";
objDDL.DataTextField="MenuName";
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

public static void BindCbo_MenuIdUp(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convQxPrjMenus_Up.MenuIdUp); 
List<clsvQxPrjMenus_UpEN> arrObjLst = clsvQxPrjMenus_UpWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN = new clsvQxPrjMenus_UpEN()
{
MenuIdUp = "0",
MenuName = "选[v顶层菜单]..."
};
arrObjLst.Insert(0, objvQxPrjMenus_UpEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convQxPrjMenus_Up.MenuIdUp;
objComboBox.DisplayMember = convQxPrjMenus_Up.MenuName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strMenuIdUp">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxPrjMenus_UpEN GetObjByMenuIdUp(string strMenuIdUp)
{
string strAction = "GetObjByMenuIdUp";
clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strMenuIdUp"] = strMenuIdUp,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvQxPrjMenus_UpEN = JsonConvert.DeserializeObject<clsvQxPrjMenus_UpEN>(strJson);
return objvQxPrjMenus_UpEN;
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
public static clsvQxPrjMenus_UpEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN;
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
objvQxPrjMenus_UpEN = JsonConvert.DeserializeObject<clsvQxPrjMenus_UpEN>(strJson);
return objvQxPrjMenus_UpEN;
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
//该表没有使用Cache,不需要生成[GetMenuNameByMenuIdUpCache]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjMenus_UpEN> GetObjLst(string strWhereCond)
{
 List<clsvQxPrjMenus_UpEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjMenus_UpEN>>(strJson);
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
 /// <param name = "arrMenuIdUp">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjMenus_UpEN> GetObjLstByMenuIdUpLst(List<string> arrMenuIdUp)
{
 List<clsvQxPrjMenus_UpEN> arrObjLst; 
string strAction = "GetObjLstByMenuIdUpLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMenuIdUp);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjMenus_UpEN>>(strJson);
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
public static List<clsvQxPrjMenus_UpEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvQxPrjMenus_UpEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjMenus_UpEN>>(strJson);
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
public static List<clsvQxPrjMenus_UpEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvQxPrjMenus_UpEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjMenus_UpEN>>(strJson);
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
public static List<clsvQxPrjMenus_UpEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvQxPrjMenus_UpEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjMenus_UpEN>>(strJson);
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
public static List<clsvQxPrjMenus_UpEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvQxPrjMenus_UpEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjMenus_UpEN>>(strJson);
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
public static bool IsExist(string strMenuIdUp)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strMenuIdUp"] = strMenuIdUp
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
 /// <param name = "objvQxPrjMenus_UpENS">源对象</param>
 /// <param name = "objvQxPrjMenus_UpENT">目标对象</param>
 public static void CopyTo(clsvQxPrjMenus_UpEN objvQxPrjMenus_UpENS, clsvQxPrjMenus_UpEN objvQxPrjMenus_UpENT)
{
try
{
objvQxPrjMenus_UpENT.MenuIdUp = objvQxPrjMenus_UpENS.MenuIdUp; //MenuId_Up
objvQxPrjMenus_UpENT.MenuName = objvQxPrjMenus_UpENS.MenuName; //菜单名
objvQxPrjMenus_UpENT.QxPrjId = objvQxPrjMenus_UpENS.QxPrjId; //项目Id
objvQxPrjMenus_UpENT.PrjName = objvQxPrjMenus_UpENS.PrjName; //工程名
objvQxPrjMenus_UpENT.UpMenuId = objvQxPrjMenus_UpENS.UpMenuId; //上级菜单Id
objvQxPrjMenus_UpENT.LinkFile = objvQxPrjMenus_UpENS.LinkFile; //链接文件
objvQxPrjMenus_UpENT.qsParameters = objvQxPrjMenus_UpENS.qsParameters; //qs参数
objvQxPrjMenus_UpENT.ImgFile = objvQxPrjMenus_UpENS.ImgFile; //图像文件
objvQxPrjMenus_UpENT.OrderNum = objvQxPrjMenus_UpENS.OrderNum; //排序号
objvQxPrjMenus_UpENT.IsLeafNode = objvQxPrjMenus_UpENS.IsLeafNode; //是否叶子
objvQxPrjMenus_UpENT.MenuSetId = objvQxPrjMenus_UpENS.MenuSetId; //菜单集Id
objvQxPrjMenus_UpENT.MenuSetName = objvQxPrjMenus_UpENS.MenuSetName; //菜单集名称
objvQxPrjMenus_UpENT.MenuTitle = objvQxPrjMenus_UpENS.MenuTitle; //菜单标题
objvQxPrjMenus_UpENT.PageDispModeId = objvQxPrjMenus_UpENS.PageDispModeId; //页面显示模式Id
objvQxPrjMenus_UpENT.PageDispModeName = objvQxPrjMenus_UpENS.PageDispModeName; //页面显示模式名称
objvQxPrjMenus_UpENT.InUse = objvQxPrjMenus_UpENS.InUse; //是否在用
objvQxPrjMenus_UpENT.UpdDate = objvQxPrjMenus_UpENS.UpdDate; //修改日期
objvQxPrjMenus_UpENT.UpdUserId = objvQxPrjMenus_UpENS.UpdUserId; //修改用户Id
objvQxPrjMenus_UpENT.Memo = objvQxPrjMenus_UpENS.Memo; //备注
objvQxPrjMenus_UpENT.MenuControlName = objvQxPrjMenus_UpENS.MenuControlName; //MenuControlName
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
public static DataTable ToDataTable(List<clsvQxPrjMenus_UpEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvQxPrjMenus_UpEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvQxPrjMenus_UpEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvQxPrjMenus_UpEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvQxPrjMenus_UpEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvQxPrjMenus_UpEN.AttributeName)
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
string strKey = string.Format("{0}", clsvQxPrjMenus_UpEN._CurrTabName);
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
public static DataTable GetDataTableByObjLst(List<clsvQxPrjMenus_UpEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convQxPrjMenus_Up.MenuIdUp, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus_Up.MenuName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus_Up.QxPrjId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus_Up.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus_Up.UpMenuId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus_Up.LinkFile, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus_Up.qsParameters, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus_Up.ImgFile, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus_Up.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convQxPrjMenus_Up.IsLeafNode, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQxPrjMenus_Up.MenuSetId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus_Up.MenuSetName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus_Up.MenuTitle, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus_Up.PageDispModeId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus_Up.PageDispModeName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus_Up.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQxPrjMenus_Up.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus_Up.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus_Up.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus_Up.MenuControlName, Type.GetType("System.String"));
foreach (clsvQxPrjMenus_UpEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convQxPrjMenus_Up.MenuIdUp] = objInFor[convQxPrjMenus_Up.MenuIdUp];
objDR[convQxPrjMenus_Up.MenuName] = objInFor[convQxPrjMenus_Up.MenuName];
objDR[convQxPrjMenus_Up.QxPrjId] = objInFor[convQxPrjMenus_Up.QxPrjId];
objDR[convQxPrjMenus_Up.PrjName] = objInFor[convQxPrjMenus_Up.PrjName];
objDR[convQxPrjMenus_Up.UpMenuId] = objInFor[convQxPrjMenus_Up.UpMenuId];
objDR[convQxPrjMenus_Up.LinkFile] = objInFor[convQxPrjMenus_Up.LinkFile];
objDR[convQxPrjMenus_Up.qsParameters] = objInFor[convQxPrjMenus_Up.qsParameters];
objDR[convQxPrjMenus_Up.ImgFile] = objInFor[convQxPrjMenus_Up.ImgFile];
objDR[convQxPrjMenus_Up.OrderNum] = objInFor[convQxPrjMenus_Up.OrderNum];
objDR[convQxPrjMenus_Up.IsLeafNode] = objInFor[convQxPrjMenus_Up.IsLeafNode];
objDR[convQxPrjMenus_Up.MenuSetId] = objInFor[convQxPrjMenus_Up.MenuSetId];
objDR[convQxPrjMenus_Up.MenuSetName] = objInFor[convQxPrjMenus_Up.MenuSetName];
objDR[convQxPrjMenus_Up.MenuTitle] = objInFor[convQxPrjMenus_Up.MenuTitle];
objDR[convQxPrjMenus_Up.PageDispModeId] = objInFor[convQxPrjMenus_Up.PageDispModeId];
objDR[convQxPrjMenus_Up.PageDispModeName] = objInFor[convQxPrjMenus_Up.PageDispModeName];
objDR[convQxPrjMenus_Up.InUse] = objInFor[convQxPrjMenus_Up.InUse];
objDR[convQxPrjMenus_Up.UpdDate] = objInFor[convQxPrjMenus_Up.UpdDate];
objDR[convQxPrjMenus_Up.UpdUserId] = objInFor[convQxPrjMenus_Up.UpdUserId];
objDR[convQxPrjMenus_Up.Memo] = objInFor[convQxPrjMenus_Up.Memo];
objDR[convQxPrjMenus_Up.MenuControlName] = objInFor[convQxPrjMenus_Up.MenuControlName];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}