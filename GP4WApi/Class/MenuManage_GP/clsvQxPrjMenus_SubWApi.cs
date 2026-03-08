
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPrjMenus_SubWApi
 表名:vQxPrjMenus_Sub(00140079)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 18:31:40
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
public static class  clsvQxPrjMenus_SubWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_SubEN">需要设置字段值的实体对象</param>
 /// <param name = "strMenuIdSub">MenuId_Sub</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_SubEN SetMenuIdSub(this clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN, string strMenuIdSub, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMenuIdSub, 8, convQxPrjMenus_Sub.MenuIdSub);
clsCheckSql.CheckFieldForeignKey(strMenuIdSub, 8, convQxPrjMenus_Sub.MenuIdSub);
objvQxPrjMenus_SubEN.MenuIdSub = strMenuIdSub; //MenuId_Sub
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_SubEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Sub.MenuIdSub) == false)
{
objvQxPrjMenus_SubEN.dicFldComparisonOp.Add(convQxPrjMenus_Sub.MenuIdSub, strComparisonOp);
}
else
{
objvQxPrjMenus_SubEN.dicFldComparisonOp[convQxPrjMenus_Sub.MenuIdSub] = strComparisonOp;
}
}
return objvQxPrjMenus_SubEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_SubEN">需要设置字段值的实体对象</param>
 /// <param name = "strMenuName">菜单名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_SubEN SetMenuName(this clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN, string strMenuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMenuName, convQxPrjMenus_Sub.MenuName);
clsCheckSql.CheckFieldLen(strMenuName, 50, convQxPrjMenus_Sub.MenuName);
objvQxPrjMenus_SubEN.MenuName = strMenuName; //菜单名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_SubEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Sub.MenuName) == false)
{
objvQxPrjMenus_SubEN.dicFldComparisonOp.Add(convQxPrjMenus_Sub.MenuName, strComparisonOp);
}
else
{
objvQxPrjMenus_SubEN.dicFldComparisonOp[convQxPrjMenus_Sub.MenuName] = strComparisonOp;
}
}
return objvQxPrjMenus_SubEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_SubEN">需要设置字段值的实体对象</param>
 /// <param name = "strQxPrjId">项目Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_SubEN SetQxPrjId(this clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxPrjMenus_Sub.QxPrjId);
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxPrjMenus_Sub.QxPrjId);
objvQxPrjMenus_SubEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_SubEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Sub.QxPrjId) == false)
{
objvQxPrjMenus_SubEN.dicFldComparisonOp.Add(convQxPrjMenus_Sub.QxPrjId, strComparisonOp);
}
else
{
objvQxPrjMenus_SubEN.dicFldComparisonOp[convQxPrjMenus_Sub.QxPrjId] = strComparisonOp;
}
}
return objvQxPrjMenus_SubEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_SubEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_SubEN SetPrjName(this clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjName, 30, convQxPrjMenus_Sub.PrjName);
objvQxPrjMenus_SubEN.PrjName = strPrjName; //工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_SubEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Sub.PrjName) == false)
{
objvQxPrjMenus_SubEN.dicFldComparisonOp.Add(convQxPrjMenus_Sub.PrjName, strComparisonOp);
}
else
{
objvQxPrjMenus_SubEN.dicFldComparisonOp[convQxPrjMenus_Sub.PrjName] = strComparisonOp;
}
}
return objvQxPrjMenus_SubEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_SubEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpMenuId">上级菜单Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_SubEN SetUpMenuId(this clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN, string strUpMenuId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpMenuId, 8, convQxPrjMenus_Sub.UpMenuId);
clsCheckSql.CheckFieldForeignKey(strUpMenuId, 8, convQxPrjMenus_Sub.UpMenuId);
objvQxPrjMenus_SubEN.UpMenuId = strUpMenuId; //上级菜单Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_SubEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Sub.UpMenuId) == false)
{
objvQxPrjMenus_SubEN.dicFldComparisonOp.Add(convQxPrjMenus_Sub.UpMenuId, strComparisonOp);
}
else
{
objvQxPrjMenus_SubEN.dicFldComparisonOp[convQxPrjMenus_Sub.UpMenuId] = strComparisonOp;
}
}
return objvQxPrjMenus_SubEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_SubEN">需要设置字段值的实体对象</param>
 /// <param name = "strLinkFile">链接文件</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_SubEN SetLinkFile(this clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN, string strLinkFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLinkFile, 500, convQxPrjMenus_Sub.LinkFile);
objvQxPrjMenus_SubEN.LinkFile = strLinkFile; //链接文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_SubEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Sub.LinkFile) == false)
{
objvQxPrjMenus_SubEN.dicFldComparisonOp.Add(convQxPrjMenus_Sub.LinkFile, strComparisonOp);
}
else
{
objvQxPrjMenus_SubEN.dicFldComparisonOp[convQxPrjMenus_Sub.LinkFile] = strComparisonOp;
}
}
return objvQxPrjMenus_SubEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_SubEN">需要设置字段值的实体对象</param>
 /// <param name = "strqsParameters">qs参数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_SubEN SetqsParameters(this clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN, string strqsParameters, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strqsParameters, 200, convQxPrjMenus_Sub.qsParameters);
objvQxPrjMenus_SubEN.qsParameters = strqsParameters; //qs参数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_SubEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Sub.qsParameters) == false)
{
objvQxPrjMenus_SubEN.dicFldComparisonOp.Add(convQxPrjMenus_Sub.qsParameters, strComparisonOp);
}
else
{
objvQxPrjMenus_SubEN.dicFldComparisonOp[convQxPrjMenus_Sub.qsParameters] = strComparisonOp;
}
}
return objvQxPrjMenus_SubEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_SubEN">需要设置字段值的实体对象</param>
 /// <param name = "strImgFile">图像文件</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_SubEN SetImgFile(this clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN, string strImgFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strImgFile, 300, convQxPrjMenus_Sub.ImgFile);
objvQxPrjMenus_SubEN.ImgFile = strImgFile; //图像文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_SubEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Sub.ImgFile) == false)
{
objvQxPrjMenus_SubEN.dicFldComparisonOp.Add(convQxPrjMenus_Sub.ImgFile, strComparisonOp);
}
else
{
objvQxPrjMenus_SubEN.dicFldComparisonOp[convQxPrjMenus_Sub.ImgFile] = strComparisonOp;
}
}
return objvQxPrjMenus_SubEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_SubEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">排序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_SubEN SetOrderNum(this clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN, int intOrderNum, string strComparisonOp="")
	{
objvQxPrjMenus_SubEN.OrderNum = intOrderNum; //排序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_SubEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Sub.OrderNum) == false)
{
objvQxPrjMenus_SubEN.dicFldComparisonOp.Add(convQxPrjMenus_Sub.OrderNum, strComparisonOp);
}
else
{
objvQxPrjMenus_SubEN.dicFldComparisonOp[convQxPrjMenus_Sub.OrderNum] = strComparisonOp;
}
}
return objvQxPrjMenus_SubEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_SubEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsLeafNode">是否叶子</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_SubEN SetIsLeafNode(this clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN, bool bolIsLeafNode, string strComparisonOp="")
	{
objvQxPrjMenus_SubEN.IsLeafNode = bolIsLeafNode; //是否叶子
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_SubEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Sub.IsLeafNode) == false)
{
objvQxPrjMenus_SubEN.dicFldComparisonOp.Add(convQxPrjMenus_Sub.IsLeafNode, strComparisonOp);
}
else
{
objvQxPrjMenus_SubEN.dicFldComparisonOp[convQxPrjMenus_Sub.IsLeafNode] = strComparisonOp;
}
}
return objvQxPrjMenus_SubEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_SubEN">需要设置字段值的实体对象</param>
 /// <param name = "strMenuSetId">菜单集Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_SubEN SetMenuSetId(this clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN, string strMenuSetId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMenuSetId, convQxPrjMenus_Sub.MenuSetId);
clsCheckSql.CheckFieldLen(strMenuSetId, 4, convQxPrjMenus_Sub.MenuSetId);
clsCheckSql.CheckFieldForeignKey(strMenuSetId, 4, convQxPrjMenus_Sub.MenuSetId);
objvQxPrjMenus_SubEN.MenuSetId = strMenuSetId; //菜单集Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_SubEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Sub.MenuSetId) == false)
{
objvQxPrjMenus_SubEN.dicFldComparisonOp.Add(convQxPrjMenus_Sub.MenuSetId, strComparisonOp);
}
else
{
objvQxPrjMenus_SubEN.dicFldComparisonOp[convQxPrjMenus_Sub.MenuSetId] = strComparisonOp;
}
}
return objvQxPrjMenus_SubEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_SubEN">需要设置字段值的实体对象</param>
 /// <param name = "strMenuSetName">菜单集名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_SubEN SetMenuSetName(this clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN, string strMenuSetName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMenuSetName, 50, convQxPrjMenus_Sub.MenuSetName);
objvQxPrjMenus_SubEN.MenuSetName = strMenuSetName; //菜单集名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_SubEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Sub.MenuSetName) == false)
{
objvQxPrjMenus_SubEN.dicFldComparisonOp.Add(convQxPrjMenus_Sub.MenuSetName, strComparisonOp);
}
else
{
objvQxPrjMenus_SubEN.dicFldComparisonOp[convQxPrjMenus_Sub.MenuSetName] = strComparisonOp;
}
}
return objvQxPrjMenus_SubEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_SubEN">需要设置字段值的实体对象</param>
 /// <param name = "strMenuTitle">菜单标题</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_SubEN SetMenuTitle(this clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN, string strMenuTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMenuTitle, 50, convQxPrjMenus_Sub.MenuTitle);
objvQxPrjMenus_SubEN.MenuTitle = strMenuTitle; //菜单标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_SubEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Sub.MenuTitle) == false)
{
objvQxPrjMenus_SubEN.dicFldComparisonOp.Add(convQxPrjMenus_Sub.MenuTitle, strComparisonOp);
}
else
{
objvQxPrjMenus_SubEN.dicFldComparisonOp[convQxPrjMenus_Sub.MenuTitle] = strComparisonOp;
}
}
return objvQxPrjMenus_SubEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_SubEN">需要设置字段值的实体对象</param>
 /// <param name = "strPageDispModeId">页面显示模式Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_SubEN SetPageDispModeId(this clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN, string strPageDispModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPageDispModeId, 2, convQxPrjMenus_Sub.PageDispModeId);
clsCheckSql.CheckFieldForeignKey(strPageDispModeId, 2, convQxPrjMenus_Sub.PageDispModeId);
objvQxPrjMenus_SubEN.PageDispModeId = strPageDispModeId; //页面显示模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_SubEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Sub.PageDispModeId) == false)
{
objvQxPrjMenus_SubEN.dicFldComparisonOp.Add(convQxPrjMenus_Sub.PageDispModeId, strComparisonOp);
}
else
{
objvQxPrjMenus_SubEN.dicFldComparisonOp[convQxPrjMenus_Sub.PageDispModeId] = strComparisonOp;
}
}
return objvQxPrjMenus_SubEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_SubEN">需要设置字段值的实体对象</param>
 /// <param name = "strPageDispModeName">页面显示模式名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_SubEN SetPageDispModeName(this clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN, string strPageDispModeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPageDispModeName, 50, convQxPrjMenus_Sub.PageDispModeName);
objvQxPrjMenus_SubEN.PageDispModeName = strPageDispModeName; //页面显示模式名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_SubEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Sub.PageDispModeName) == false)
{
objvQxPrjMenus_SubEN.dicFldComparisonOp.Add(convQxPrjMenus_Sub.PageDispModeName, strComparisonOp);
}
else
{
objvQxPrjMenus_SubEN.dicFldComparisonOp[convQxPrjMenus_Sub.PageDispModeName] = strComparisonOp;
}
}
return objvQxPrjMenus_SubEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_SubEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_SubEN SetInUse(this clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN, bool bolInUse, string strComparisonOp="")
	{
objvQxPrjMenus_SubEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_SubEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Sub.InUse) == false)
{
objvQxPrjMenus_SubEN.dicFldComparisonOp.Add(convQxPrjMenus_Sub.InUse, strComparisonOp);
}
else
{
objvQxPrjMenus_SubEN.dicFldComparisonOp[convQxPrjMenus_Sub.InUse] = strComparisonOp;
}
}
return objvQxPrjMenus_SubEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_SubEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_SubEN SetUpdDate(this clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQxPrjMenus_Sub.UpdDate);
objvQxPrjMenus_SubEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_SubEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Sub.UpdDate) == false)
{
objvQxPrjMenus_SubEN.dicFldComparisonOp.Add(convQxPrjMenus_Sub.UpdDate, strComparisonOp);
}
else
{
objvQxPrjMenus_SubEN.dicFldComparisonOp[convQxPrjMenus_Sub.UpdDate] = strComparisonOp;
}
}
return objvQxPrjMenus_SubEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_SubEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_SubEN SetUpdUserId(this clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convQxPrjMenus_Sub.UpdUserId);
objvQxPrjMenus_SubEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_SubEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Sub.UpdUserId) == false)
{
objvQxPrjMenus_SubEN.dicFldComparisonOp.Add(convQxPrjMenus_Sub.UpdUserId, strComparisonOp);
}
else
{
objvQxPrjMenus_SubEN.dicFldComparisonOp[convQxPrjMenus_Sub.UpdUserId] = strComparisonOp;
}
}
return objvQxPrjMenus_SubEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_SubEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">备注</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_SubEN SetMemo(this clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxPrjMenus_Sub.Memo);
objvQxPrjMenus_SubEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_SubEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Sub.Memo) == false)
{
objvQxPrjMenus_SubEN.dicFldComparisonOp.Add(convQxPrjMenus_Sub.Memo, strComparisonOp);
}
else
{
objvQxPrjMenus_SubEN.dicFldComparisonOp[convQxPrjMenus_Sub.Memo] = strComparisonOp;
}
}
return objvQxPrjMenus_SubEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_SubEN">需要设置字段值的实体对象</param>
 /// <param name = "strMenuControlName">MenuControlName</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_SubEN SetMenuControlName(this clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN, string strMenuControlName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMenuControlName, 100, convQxPrjMenus_Sub.MenuControlName);
objvQxPrjMenus_SubEN.MenuControlName = strMenuControlName; //MenuControlName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_SubEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Sub.MenuControlName) == false)
{
objvQxPrjMenus_SubEN.dicFldComparisonOp.Add(convQxPrjMenus_Sub.MenuControlName, strComparisonOp);
}
else
{
objvQxPrjMenus_SubEN.dicFldComparisonOp[convQxPrjMenus_Sub.MenuControlName] = strComparisonOp;
}
}
return objvQxPrjMenus_SubEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQxPrjMenus_SubEN objvQxPrjMenus_SubCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQxPrjMenus_SubCond.IsUpdated(convQxPrjMenus_Sub.MenuIdSub) == true)
{
string strComparisonOpMenuIdSub = objvQxPrjMenus_SubCond.dicFldComparisonOp[convQxPrjMenus_Sub.MenuIdSub];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus_Sub.MenuIdSub, objvQxPrjMenus_SubCond.MenuIdSub, strComparisonOpMenuIdSub);
}
if (objvQxPrjMenus_SubCond.IsUpdated(convQxPrjMenus_Sub.MenuName) == true)
{
string strComparisonOpMenuName = objvQxPrjMenus_SubCond.dicFldComparisonOp[convQxPrjMenus_Sub.MenuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus_Sub.MenuName, objvQxPrjMenus_SubCond.MenuName, strComparisonOpMenuName);
}
if (objvQxPrjMenus_SubCond.IsUpdated(convQxPrjMenus_Sub.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objvQxPrjMenus_SubCond.dicFldComparisonOp[convQxPrjMenus_Sub.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus_Sub.QxPrjId, objvQxPrjMenus_SubCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objvQxPrjMenus_SubCond.IsUpdated(convQxPrjMenus_Sub.PrjName) == true)
{
string strComparisonOpPrjName = objvQxPrjMenus_SubCond.dicFldComparisonOp[convQxPrjMenus_Sub.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus_Sub.PrjName, objvQxPrjMenus_SubCond.PrjName, strComparisonOpPrjName);
}
if (objvQxPrjMenus_SubCond.IsUpdated(convQxPrjMenus_Sub.UpMenuId) == true)
{
string strComparisonOpUpMenuId = objvQxPrjMenus_SubCond.dicFldComparisonOp[convQxPrjMenus_Sub.UpMenuId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus_Sub.UpMenuId, objvQxPrjMenus_SubCond.UpMenuId, strComparisonOpUpMenuId);
}
if (objvQxPrjMenus_SubCond.IsUpdated(convQxPrjMenus_Sub.LinkFile) == true)
{
string strComparisonOpLinkFile = objvQxPrjMenus_SubCond.dicFldComparisonOp[convQxPrjMenus_Sub.LinkFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus_Sub.LinkFile, objvQxPrjMenus_SubCond.LinkFile, strComparisonOpLinkFile);
}
if (objvQxPrjMenus_SubCond.IsUpdated(convQxPrjMenus_Sub.qsParameters) == true)
{
string strComparisonOpqsParameters = objvQxPrjMenus_SubCond.dicFldComparisonOp[convQxPrjMenus_Sub.qsParameters];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus_Sub.qsParameters, objvQxPrjMenus_SubCond.qsParameters, strComparisonOpqsParameters);
}
if (objvQxPrjMenus_SubCond.IsUpdated(convQxPrjMenus_Sub.ImgFile) == true)
{
string strComparisonOpImgFile = objvQxPrjMenus_SubCond.dicFldComparisonOp[convQxPrjMenus_Sub.ImgFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus_Sub.ImgFile, objvQxPrjMenus_SubCond.ImgFile, strComparisonOpImgFile);
}
if (objvQxPrjMenus_SubCond.IsUpdated(convQxPrjMenus_Sub.OrderNum) == true)
{
string strComparisonOpOrderNum = objvQxPrjMenus_SubCond.dicFldComparisonOp[convQxPrjMenus_Sub.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQxPrjMenus_Sub.OrderNum, objvQxPrjMenus_SubCond.OrderNum, strComparisonOpOrderNum);
}
if (objvQxPrjMenus_SubCond.IsUpdated(convQxPrjMenus_Sub.IsLeafNode) == true)
{
if (objvQxPrjMenus_SubCond.IsLeafNode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQxPrjMenus_Sub.IsLeafNode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQxPrjMenus_Sub.IsLeafNode);
}
}
if (objvQxPrjMenus_SubCond.IsUpdated(convQxPrjMenus_Sub.MenuSetId) == true)
{
string strComparisonOpMenuSetId = objvQxPrjMenus_SubCond.dicFldComparisonOp[convQxPrjMenus_Sub.MenuSetId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus_Sub.MenuSetId, objvQxPrjMenus_SubCond.MenuSetId, strComparisonOpMenuSetId);
}
if (objvQxPrjMenus_SubCond.IsUpdated(convQxPrjMenus_Sub.MenuSetName) == true)
{
string strComparisonOpMenuSetName = objvQxPrjMenus_SubCond.dicFldComparisonOp[convQxPrjMenus_Sub.MenuSetName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus_Sub.MenuSetName, objvQxPrjMenus_SubCond.MenuSetName, strComparisonOpMenuSetName);
}
if (objvQxPrjMenus_SubCond.IsUpdated(convQxPrjMenus_Sub.MenuTitle) == true)
{
string strComparisonOpMenuTitle = objvQxPrjMenus_SubCond.dicFldComparisonOp[convQxPrjMenus_Sub.MenuTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus_Sub.MenuTitle, objvQxPrjMenus_SubCond.MenuTitle, strComparisonOpMenuTitle);
}
if (objvQxPrjMenus_SubCond.IsUpdated(convQxPrjMenus_Sub.PageDispModeId) == true)
{
string strComparisonOpPageDispModeId = objvQxPrjMenus_SubCond.dicFldComparisonOp[convQxPrjMenus_Sub.PageDispModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus_Sub.PageDispModeId, objvQxPrjMenus_SubCond.PageDispModeId, strComparisonOpPageDispModeId);
}
if (objvQxPrjMenus_SubCond.IsUpdated(convQxPrjMenus_Sub.PageDispModeName) == true)
{
string strComparisonOpPageDispModeName = objvQxPrjMenus_SubCond.dicFldComparisonOp[convQxPrjMenus_Sub.PageDispModeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus_Sub.PageDispModeName, objvQxPrjMenus_SubCond.PageDispModeName, strComparisonOpPageDispModeName);
}
if (objvQxPrjMenus_SubCond.IsUpdated(convQxPrjMenus_Sub.InUse) == true)
{
if (objvQxPrjMenus_SubCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQxPrjMenus_Sub.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQxPrjMenus_Sub.InUse);
}
}
if (objvQxPrjMenus_SubCond.IsUpdated(convQxPrjMenus_Sub.UpdDate) == true)
{
string strComparisonOpUpdDate = objvQxPrjMenus_SubCond.dicFldComparisonOp[convQxPrjMenus_Sub.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus_Sub.UpdDate, objvQxPrjMenus_SubCond.UpdDate, strComparisonOpUpdDate);
}
if (objvQxPrjMenus_SubCond.IsUpdated(convQxPrjMenus_Sub.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvQxPrjMenus_SubCond.dicFldComparisonOp[convQxPrjMenus_Sub.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus_Sub.UpdUserId, objvQxPrjMenus_SubCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvQxPrjMenus_SubCond.IsUpdated(convQxPrjMenus_Sub.Memo) == true)
{
string strComparisonOpMemo = objvQxPrjMenus_SubCond.dicFldComparisonOp[convQxPrjMenus_Sub.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus_Sub.Memo, objvQxPrjMenus_SubCond.Memo, strComparisonOpMemo);
}
if (objvQxPrjMenus_SubCond.IsUpdated(convQxPrjMenus_Sub.MenuControlName) == true)
{
string strComparisonOpMenuControlName = objvQxPrjMenus_SubCond.dicFldComparisonOp[convQxPrjMenus_Sub.MenuControlName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus_Sub.MenuControlName, objvQxPrjMenus_SubCond.MenuControlName, strComparisonOpMenuControlName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v子层菜单(vQxPrjMenus_Sub)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxPrjMenus_SubWApi
{
private static readonly string mstrApiControllerName = "vQxPrjMenus_SubApi";

 public clsvQxPrjMenus_SubWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_MenuIdSub(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v子层菜单]...","0");
List<clsvQxPrjMenus_SubEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="MenuIdSub";
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

public static void BindCbo_MenuIdSub(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convQxPrjMenus_Sub.MenuIdSub); 
List<clsvQxPrjMenus_SubEN> arrObjLst = clsvQxPrjMenus_SubWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN = new clsvQxPrjMenus_SubEN()
{
MenuIdSub = "0",
MenuName = "选[v子层菜单]..."
};
arrObjLst.Insert(0, objvQxPrjMenus_SubEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convQxPrjMenus_Sub.MenuIdSub;
objComboBox.DisplayMember = convQxPrjMenus_Sub.MenuName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strMenuIdSub">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxPrjMenus_SubEN GetObjByMenuIdSub(string strMenuIdSub)
{
string strAction = "GetObjByMenuIdSub";
clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strMenuIdSub"] = strMenuIdSub,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvQxPrjMenus_SubEN = JsonConvert.DeserializeObject<clsvQxPrjMenus_SubEN>(strJson);
return objvQxPrjMenus_SubEN;
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
public static clsvQxPrjMenus_SubEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN;
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
objvQxPrjMenus_SubEN = JsonConvert.DeserializeObject<clsvQxPrjMenus_SubEN>(strJson);
return objvQxPrjMenus_SubEN;
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
//该表没有使用Cache,不需要生成[GetMenuNameByMenuIdSubCache]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjMenus_SubEN> GetObjLst(string strWhereCond)
{
 List<clsvQxPrjMenus_SubEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjMenus_SubEN>>(strJson);
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
 /// <param name = "arrMenuIdSub">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjMenus_SubEN> GetObjLstByMenuIdSubLst(List<string> arrMenuIdSub)
{
 List<clsvQxPrjMenus_SubEN> arrObjLst; 
string strAction = "GetObjLstByMenuIdSubLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMenuIdSub);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjMenus_SubEN>>(strJson);
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
public static List<clsvQxPrjMenus_SubEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvQxPrjMenus_SubEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjMenus_SubEN>>(strJson);
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
public static List<clsvQxPrjMenus_SubEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvQxPrjMenus_SubEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjMenus_SubEN>>(strJson);
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
public static List<clsvQxPrjMenus_SubEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvQxPrjMenus_SubEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjMenus_SubEN>>(strJson);
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
public static List<clsvQxPrjMenus_SubEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvQxPrjMenus_SubEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjMenus_SubEN>>(strJson);
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
public static bool IsExist(string strMenuIdSub)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strMenuIdSub"] = strMenuIdSub
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
 /// <param name = "objvQxPrjMenus_SubENS">源对象</param>
 /// <param name = "objvQxPrjMenus_SubENT">目标对象</param>
 public static void CopyTo(clsvQxPrjMenus_SubEN objvQxPrjMenus_SubENS, clsvQxPrjMenus_SubEN objvQxPrjMenus_SubENT)
{
try
{
objvQxPrjMenus_SubENT.MenuIdSub = objvQxPrjMenus_SubENS.MenuIdSub; //MenuId_Sub
objvQxPrjMenus_SubENT.MenuName = objvQxPrjMenus_SubENS.MenuName; //菜单名
objvQxPrjMenus_SubENT.QxPrjId = objvQxPrjMenus_SubENS.QxPrjId; //项目Id
objvQxPrjMenus_SubENT.PrjName = objvQxPrjMenus_SubENS.PrjName; //工程名
objvQxPrjMenus_SubENT.UpMenuId = objvQxPrjMenus_SubENS.UpMenuId; //上级菜单Id
objvQxPrjMenus_SubENT.LinkFile = objvQxPrjMenus_SubENS.LinkFile; //链接文件
objvQxPrjMenus_SubENT.qsParameters = objvQxPrjMenus_SubENS.qsParameters; //qs参数
objvQxPrjMenus_SubENT.ImgFile = objvQxPrjMenus_SubENS.ImgFile; //图像文件
objvQxPrjMenus_SubENT.OrderNum = objvQxPrjMenus_SubENS.OrderNum; //排序号
objvQxPrjMenus_SubENT.IsLeafNode = objvQxPrjMenus_SubENS.IsLeafNode; //是否叶子
objvQxPrjMenus_SubENT.MenuSetId = objvQxPrjMenus_SubENS.MenuSetId; //菜单集Id
objvQxPrjMenus_SubENT.MenuSetName = objvQxPrjMenus_SubENS.MenuSetName; //菜单集名称
objvQxPrjMenus_SubENT.MenuTitle = objvQxPrjMenus_SubENS.MenuTitle; //菜单标题
objvQxPrjMenus_SubENT.PageDispModeId = objvQxPrjMenus_SubENS.PageDispModeId; //页面显示模式Id
objvQxPrjMenus_SubENT.PageDispModeName = objvQxPrjMenus_SubENS.PageDispModeName; //页面显示模式名称
objvQxPrjMenus_SubENT.InUse = objvQxPrjMenus_SubENS.InUse; //是否在用
objvQxPrjMenus_SubENT.UpdDate = objvQxPrjMenus_SubENS.UpdDate; //修改日期
objvQxPrjMenus_SubENT.UpdUserId = objvQxPrjMenus_SubENS.UpdUserId; //修改用户Id
objvQxPrjMenus_SubENT.Memo = objvQxPrjMenus_SubENS.Memo; //备注
objvQxPrjMenus_SubENT.MenuControlName = objvQxPrjMenus_SubENS.MenuControlName; //MenuControlName
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
public static DataTable ToDataTable(List<clsvQxPrjMenus_SubEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvQxPrjMenus_SubEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvQxPrjMenus_SubEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvQxPrjMenus_SubEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvQxPrjMenus_SubEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvQxPrjMenus_SubEN.AttributeName)
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
string strKey = string.Format("{0}", clsvQxPrjMenus_SubEN._CurrTabName);
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
public static DataTable GetDataTableByObjLst(List<clsvQxPrjMenus_SubEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convQxPrjMenus_Sub.MenuIdSub, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus_Sub.MenuName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus_Sub.QxPrjId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus_Sub.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus_Sub.UpMenuId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus_Sub.LinkFile, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus_Sub.qsParameters, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus_Sub.ImgFile, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus_Sub.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convQxPrjMenus_Sub.IsLeafNode, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQxPrjMenus_Sub.MenuSetId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus_Sub.MenuSetName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus_Sub.MenuTitle, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus_Sub.PageDispModeId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus_Sub.PageDispModeName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus_Sub.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQxPrjMenus_Sub.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus_Sub.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus_Sub.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus_Sub.MenuControlName, Type.GetType("System.String"));
foreach (clsvQxPrjMenus_SubEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convQxPrjMenus_Sub.MenuIdSub] = objInFor[convQxPrjMenus_Sub.MenuIdSub];
objDR[convQxPrjMenus_Sub.MenuName] = objInFor[convQxPrjMenus_Sub.MenuName];
objDR[convQxPrjMenus_Sub.QxPrjId] = objInFor[convQxPrjMenus_Sub.QxPrjId];
objDR[convQxPrjMenus_Sub.PrjName] = objInFor[convQxPrjMenus_Sub.PrjName];
objDR[convQxPrjMenus_Sub.UpMenuId] = objInFor[convQxPrjMenus_Sub.UpMenuId];
objDR[convQxPrjMenus_Sub.LinkFile] = objInFor[convQxPrjMenus_Sub.LinkFile];
objDR[convQxPrjMenus_Sub.qsParameters] = objInFor[convQxPrjMenus_Sub.qsParameters];
objDR[convQxPrjMenus_Sub.ImgFile] = objInFor[convQxPrjMenus_Sub.ImgFile];
objDR[convQxPrjMenus_Sub.OrderNum] = objInFor[convQxPrjMenus_Sub.OrderNum];
objDR[convQxPrjMenus_Sub.IsLeafNode] = objInFor[convQxPrjMenus_Sub.IsLeafNode];
objDR[convQxPrjMenus_Sub.MenuSetId] = objInFor[convQxPrjMenus_Sub.MenuSetId];
objDR[convQxPrjMenus_Sub.MenuSetName] = objInFor[convQxPrjMenus_Sub.MenuSetName];
objDR[convQxPrjMenus_Sub.MenuTitle] = objInFor[convQxPrjMenus_Sub.MenuTitle];
objDR[convQxPrjMenus_Sub.PageDispModeId] = objInFor[convQxPrjMenus_Sub.PageDispModeId];
objDR[convQxPrjMenus_Sub.PageDispModeName] = objInFor[convQxPrjMenus_Sub.PageDispModeName];
objDR[convQxPrjMenus_Sub.InUse] = objInFor[convQxPrjMenus_Sub.InUse];
objDR[convQxPrjMenus_Sub.UpdDate] = objInFor[convQxPrjMenus_Sub.UpdDate];
objDR[convQxPrjMenus_Sub.UpdUserId] = objInFor[convQxPrjMenus_Sub.UpdUserId];
objDR[convQxPrjMenus_Sub.Memo] = objInFor[convQxPrjMenus_Sub.Memo];
objDR[convQxPrjMenus_Sub.MenuControlName] = objInFor[convQxPrjMenus_Sub.MenuControlName];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}