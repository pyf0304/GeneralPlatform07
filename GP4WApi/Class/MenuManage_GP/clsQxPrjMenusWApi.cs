
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxPrjMenusWApi
 表名:QxPrjMenus(00140004)
 * 版本:2024.03.19.1(服务器:WIN-SRV103-116)
 日期:2024/03/20 11:19:36
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
using GP4WApi;

namespace GeneralPlatform4WApi
{
/// <summary>
/// 静态类
/// </summary>
public static class  clsQxPrjMenusWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strMenuId">菜单Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusEN SetMenuId(this clsQxPrjMenusEN objQxPrjMenusEN, string strMenuId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMenuId, 8, conQxPrjMenus.MenuId);
clsCheckSql.CheckFieldForeignKey(strMenuId, 8, conQxPrjMenus.MenuId);
objQxPrjMenusEN.MenuId = strMenuId; //菜单Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusEN.dicFldComparisonOp.ContainsKey(conQxPrjMenus.MenuId) == false)
{
objQxPrjMenusEN.dicFldComparisonOp.Add(conQxPrjMenus.MenuId, strComparisonOp);
}
else
{
objQxPrjMenusEN.dicFldComparisonOp[conQxPrjMenus.MenuId] = strComparisonOp;
}
}
return objQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strMenuName">菜单名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusEN SetMenuName(this clsQxPrjMenusEN objQxPrjMenusEN, string strMenuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMenuName, conQxPrjMenus.MenuName);
clsCheckSql.CheckFieldLen(strMenuName, 50, conQxPrjMenus.MenuName);
objQxPrjMenusEN.MenuName = strMenuName; //菜单名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusEN.dicFldComparisonOp.ContainsKey(conQxPrjMenus.MenuName) == false)
{
objQxPrjMenusEN.dicFldComparisonOp.Add(conQxPrjMenus.MenuName, strComparisonOp);
}
else
{
objQxPrjMenusEN.dicFldComparisonOp[conQxPrjMenus.MenuName] = strComparisonOp;
}
}
return objQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strQxPrjId">项目Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusEN SetQxPrjId(this clsQxPrjMenusEN objQxPrjMenusEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, conQxPrjMenus.QxPrjId);
clsCheckSql.CheckFieldLen(strQxPrjId, 4, conQxPrjMenus.QxPrjId);
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, conQxPrjMenus.QxPrjId);
objQxPrjMenusEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusEN.dicFldComparisonOp.ContainsKey(conQxPrjMenus.QxPrjId) == false)
{
objQxPrjMenusEN.dicFldComparisonOp.Add(conQxPrjMenus.QxPrjId, strComparisonOp);
}
else
{
objQxPrjMenusEN.dicFldComparisonOp[conQxPrjMenus.QxPrjId] = strComparisonOp;
}
}
return objQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpMenuId">上级菜单Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusEN SetUpMenuId(this clsQxPrjMenusEN objQxPrjMenusEN, string strUpMenuId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpMenuId, conQxPrjMenus.UpMenuId);
clsCheckSql.CheckFieldLen(strUpMenuId, 8, conQxPrjMenus.UpMenuId);
clsCheckSql.CheckFieldForeignKey(strUpMenuId, 8, conQxPrjMenus.UpMenuId);
objQxPrjMenusEN.UpMenuId = strUpMenuId; //上级菜单Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusEN.dicFldComparisonOp.ContainsKey(conQxPrjMenus.UpMenuId) == false)
{
objQxPrjMenusEN.dicFldComparisonOp.Add(conQxPrjMenus.UpMenuId, strComparisonOp);
}
else
{
objQxPrjMenusEN.dicFldComparisonOp[conQxPrjMenus.UpMenuId] = strComparisonOp;
}
}
return objQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strLinkFile">链接文件</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusEN SetLinkFile(this clsQxPrjMenusEN objQxPrjMenusEN, string strLinkFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLinkFile, 500, conQxPrjMenus.LinkFile);
objQxPrjMenusEN.LinkFile = strLinkFile; //链接文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusEN.dicFldComparisonOp.ContainsKey(conQxPrjMenus.LinkFile) == false)
{
objQxPrjMenusEN.dicFldComparisonOp.Add(conQxPrjMenus.LinkFile, strComparisonOp);
}
else
{
objQxPrjMenusEN.dicFldComparisonOp[conQxPrjMenus.LinkFile] = strComparisonOp;
}
}
return objQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strqsParameters">qs参数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusEN SetqsParameters(this clsQxPrjMenusEN objQxPrjMenusEN, string strqsParameters, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strqsParameters, 200, conQxPrjMenus.qsParameters);
objQxPrjMenusEN.qsParameters = strqsParameters; //qs参数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusEN.dicFldComparisonOp.ContainsKey(conQxPrjMenus.qsParameters) == false)
{
objQxPrjMenusEN.dicFldComparisonOp.Add(conQxPrjMenus.qsParameters, strComparisonOp);
}
else
{
objQxPrjMenusEN.dicFldComparisonOp[conQxPrjMenus.qsParameters] = strComparisonOp;
}
}
return objQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusEN SetTabId(this clsQxPrjMenusEN objQxPrjMenusEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabId, 8, conQxPrjMenus.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, conQxPrjMenus.TabId);
objQxPrjMenusEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusEN.dicFldComparisonOp.ContainsKey(conQxPrjMenus.TabId) == false)
{
objQxPrjMenusEN.dicFldComparisonOp.Add(conQxPrjMenus.TabId, strComparisonOp);
}
else
{
objQxPrjMenusEN.dicFldComparisonOp[conQxPrjMenus.TabId] = strComparisonOp;
}
}
return objQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strImgFile">图像文件</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusEN SetImgFile(this clsQxPrjMenusEN objQxPrjMenusEN, string strImgFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strImgFile, 300, conQxPrjMenus.ImgFile);
objQxPrjMenusEN.ImgFile = strImgFile; //图像文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusEN.dicFldComparisonOp.ContainsKey(conQxPrjMenus.ImgFile) == false)
{
objQxPrjMenusEN.dicFldComparisonOp.Add(conQxPrjMenus.ImgFile, strComparisonOp);
}
else
{
objQxPrjMenusEN.dicFldComparisonOp[conQxPrjMenus.ImgFile] = strComparisonOp;
}
}
return objQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strRoleId">角色Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusEN SetRoleId(this clsQxPrjMenusEN objQxPrjMenusEN, string strRoleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRoleId, 8, conQxPrjMenus.RoleId);
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, conQxPrjMenus.RoleId);
objQxPrjMenusEN.RoleId = strRoleId; //角色Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusEN.dicFldComparisonOp.ContainsKey(conQxPrjMenus.RoleId) == false)
{
objQxPrjMenusEN.dicFldComparisonOp.Add(conQxPrjMenus.RoleId, strComparisonOp);
}
else
{
objQxPrjMenusEN.dicFldComparisonOp[conQxPrjMenus.RoleId] = strComparisonOp;
}
}
return objQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">排序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusEN SetOrderNum(this clsQxPrjMenusEN objQxPrjMenusEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, conQxPrjMenus.OrderNum);
objQxPrjMenusEN.OrderNum = intOrderNum; //排序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusEN.dicFldComparisonOp.ContainsKey(conQxPrjMenus.OrderNum) == false)
{
objQxPrjMenusEN.dicFldComparisonOp.Add(conQxPrjMenus.OrderNum, strComparisonOp);
}
else
{
objQxPrjMenusEN.dicFldComparisonOp[conQxPrjMenus.OrderNum] = strComparisonOp;
}
}
return objQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsLeafNode">是否叶子</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusEN SetIsLeafNode(this clsQxPrjMenusEN objQxPrjMenusEN, bool bolIsLeafNode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsLeafNode, conQxPrjMenus.IsLeafNode);
objQxPrjMenusEN.IsLeafNode = bolIsLeafNode; //是否叶子
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusEN.dicFldComparisonOp.ContainsKey(conQxPrjMenus.IsLeafNode) == false)
{
objQxPrjMenusEN.dicFldComparisonOp.Add(conQxPrjMenus.IsLeafNode, strComparisonOp);
}
else
{
objQxPrjMenusEN.dicFldComparisonOp[conQxPrjMenus.IsLeafNode] = strComparisonOp;
}
}
return objQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strMenuTitle">菜单标题</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusEN SetMenuTitle(this clsQxPrjMenusEN objQxPrjMenusEN, string strMenuTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMenuTitle, 50, conQxPrjMenus.MenuTitle);
objQxPrjMenusEN.MenuTitle = strMenuTitle; //菜单标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusEN.dicFldComparisonOp.ContainsKey(conQxPrjMenus.MenuTitle) == false)
{
objQxPrjMenusEN.dicFldComparisonOp.Add(conQxPrjMenus.MenuTitle, strComparisonOp);
}
else
{
objQxPrjMenusEN.dicFldComparisonOp[conQxPrjMenus.MenuTitle] = strComparisonOp;
}
}
return objQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strPageDispModeId">页面显示模式Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusEN SetPageDispModeId(this clsQxPrjMenusEN objQxPrjMenusEN, string strPageDispModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPageDispModeId, 2, conQxPrjMenus.PageDispModeId);
clsCheckSql.CheckFieldForeignKey(strPageDispModeId, 2, conQxPrjMenus.PageDispModeId);
objQxPrjMenusEN.PageDispModeId = strPageDispModeId; //页面显示模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusEN.dicFldComparisonOp.ContainsKey(conQxPrjMenus.PageDispModeId) == false)
{
objQxPrjMenusEN.dicFldComparisonOp.Add(conQxPrjMenus.PageDispModeId, strComparisonOp);
}
else
{
objQxPrjMenusEN.dicFldComparisonOp[conQxPrjMenus.PageDispModeId] = strComparisonOp;
}
}
return objQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusEN SetInUse(this clsQxPrjMenusEN objQxPrjMenusEN, bool bolInUse, string strComparisonOp="")
	{
objQxPrjMenusEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusEN.dicFldComparisonOp.ContainsKey(conQxPrjMenus.InUse) == false)
{
objQxPrjMenusEN.dicFldComparisonOp.Add(conQxPrjMenus.InUse, strComparisonOp);
}
else
{
objQxPrjMenusEN.dicFldComparisonOp[conQxPrjMenus.InUse] = strComparisonOp;
}
}
return objQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strMenuControlName">菜单控件名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusEN SetMenuControlName(this clsQxPrjMenusEN objQxPrjMenusEN, string strMenuControlName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMenuControlName, 100, conQxPrjMenus.MenuControlName);
objQxPrjMenusEN.MenuControlName = strMenuControlName; //菜单控件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusEN.dicFldComparisonOp.ContainsKey(conQxPrjMenus.MenuControlName) == false)
{
objQxPrjMenusEN.dicFldComparisonOp.Add(conQxPrjMenus.MenuControlName, strComparisonOp);
}
else
{
objQxPrjMenusEN.dicFldComparisonOp[conQxPrjMenus.MenuControlName] = strComparisonOp;
}
}
return objQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "intApplicationTypeId">应用程序类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusEN SetApplicationTypeId(this clsQxPrjMenusEN objQxPrjMenusEN, int intApplicationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intApplicationTypeId, conQxPrjMenus.ApplicationTypeId);
objQxPrjMenusEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusEN.dicFldComparisonOp.ContainsKey(conQxPrjMenus.ApplicationTypeId) == false)
{
objQxPrjMenusEN.dicFldComparisonOp.Add(conQxPrjMenus.ApplicationTypeId, strComparisonOp);
}
else
{
objQxPrjMenusEN.dicFldComparisonOp[conQxPrjMenus.ApplicationTypeId] = strComparisonOp;
}
}
return objQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusEN SetUpdDate(this clsQxPrjMenusEN objQxPrjMenusEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQxPrjMenus.UpdDate);
objQxPrjMenusEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusEN.dicFldComparisonOp.ContainsKey(conQxPrjMenus.UpdDate) == false)
{
objQxPrjMenusEN.dicFldComparisonOp.Add(conQxPrjMenus.UpdDate, strComparisonOp);
}
else
{
objQxPrjMenusEN.dicFldComparisonOp[conQxPrjMenus.UpdDate] = strComparisonOp;
}
}
return objQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusEN SetUpdUserId(this clsQxPrjMenusEN objQxPrjMenusEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conQxPrjMenus.UpdUserId);
objQxPrjMenusEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusEN.dicFldComparisonOp.ContainsKey(conQxPrjMenus.UpdUserId) == false)
{
objQxPrjMenusEN.dicFldComparisonOp.Add(conQxPrjMenus.UpdUserId, strComparisonOp);
}
else
{
objQxPrjMenusEN.dicFldComparisonOp[conQxPrjMenus.UpdUserId] = strComparisonOp;
}
}
return objQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">备注</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjMenusEN SetMemo(this clsQxPrjMenusEN objQxPrjMenusEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQxPrjMenus.Memo);
objQxPrjMenusEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjMenusEN.dicFldComparisonOp.ContainsKey(conQxPrjMenus.Memo) == false)
{
objQxPrjMenusEN.dicFldComparisonOp.Add(conQxPrjMenus.Memo, strComparisonOp);
}
else
{
objQxPrjMenusEN.dicFldComparisonOp[conQxPrjMenus.Memo] = strComparisonOp;
}
}
return objQxPrjMenusEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQxPrjMenusEN objQxPrjMenusCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQxPrjMenusCond.IsUpdated(conQxPrjMenus.MenuId) == true)
{
string strComparisonOpMenuId = objQxPrjMenusCond.dicFldComparisonOp[conQxPrjMenus.MenuId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenus.MenuId, objQxPrjMenusCond.MenuId, strComparisonOpMenuId);
}
if (objQxPrjMenusCond.IsUpdated(conQxPrjMenus.MenuName) == true)
{
string strComparisonOpMenuName = objQxPrjMenusCond.dicFldComparisonOp[conQxPrjMenus.MenuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenus.MenuName, objQxPrjMenusCond.MenuName, strComparisonOpMenuName);
}
if (objQxPrjMenusCond.IsUpdated(conQxPrjMenus.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objQxPrjMenusCond.dicFldComparisonOp[conQxPrjMenus.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenus.QxPrjId, objQxPrjMenusCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objQxPrjMenusCond.IsUpdated(conQxPrjMenus.UpMenuId) == true)
{
string strComparisonOpUpMenuId = objQxPrjMenusCond.dicFldComparisonOp[conQxPrjMenus.UpMenuId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenus.UpMenuId, objQxPrjMenusCond.UpMenuId, strComparisonOpUpMenuId);
}
if (objQxPrjMenusCond.IsUpdated(conQxPrjMenus.LinkFile) == true)
{
string strComparisonOpLinkFile = objQxPrjMenusCond.dicFldComparisonOp[conQxPrjMenus.LinkFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenus.LinkFile, objQxPrjMenusCond.LinkFile, strComparisonOpLinkFile);
}
if (objQxPrjMenusCond.IsUpdated(conQxPrjMenus.qsParameters) == true)
{
string strComparisonOpqsParameters = objQxPrjMenusCond.dicFldComparisonOp[conQxPrjMenus.qsParameters];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenus.qsParameters, objQxPrjMenusCond.qsParameters, strComparisonOpqsParameters);
}
if (objQxPrjMenusCond.IsUpdated(conQxPrjMenus.TabId) == true)
{
string strComparisonOpTabId = objQxPrjMenusCond.dicFldComparisonOp[conQxPrjMenus.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenus.TabId, objQxPrjMenusCond.TabId, strComparisonOpTabId);
}
if (objQxPrjMenusCond.IsUpdated(conQxPrjMenus.ImgFile) == true)
{
string strComparisonOpImgFile = objQxPrjMenusCond.dicFldComparisonOp[conQxPrjMenus.ImgFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenus.ImgFile, objQxPrjMenusCond.ImgFile, strComparisonOpImgFile);
}
if (objQxPrjMenusCond.IsUpdated(conQxPrjMenus.RoleId) == true)
{
string strComparisonOpRoleId = objQxPrjMenusCond.dicFldComparisonOp[conQxPrjMenus.RoleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenus.RoleId, objQxPrjMenusCond.RoleId, strComparisonOpRoleId);
}
if (objQxPrjMenusCond.IsUpdated(conQxPrjMenus.OrderNum) == true)
{
string strComparisonOpOrderNum = objQxPrjMenusCond.dicFldComparisonOp[conQxPrjMenus.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conQxPrjMenus.OrderNum, objQxPrjMenusCond.OrderNum, strComparisonOpOrderNum);
}
if (objQxPrjMenusCond.IsUpdated(conQxPrjMenus.IsLeafNode) == true)
{
if (objQxPrjMenusCond.IsLeafNode == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQxPrjMenus.IsLeafNode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQxPrjMenus.IsLeafNode);
}
}
if (objQxPrjMenusCond.IsUpdated(conQxPrjMenus.MenuTitle) == true)
{
string strComparisonOpMenuTitle = objQxPrjMenusCond.dicFldComparisonOp[conQxPrjMenus.MenuTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenus.MenuTitle, objQxPrjMenusCond.MenuTitle, strComparisonOpMenuTitle);
}
if (objQxPrjMenusCond.IsUpdated(conQxPrjMenus.PageDispModeId) == true)
{
string strComparisonOpPageDispModeId = objQxPrjMenusCond.dicFldComparisonOp[conQxPrjMenus.PageDispModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenus.PageDispModeId, objQxPrjMenusCond.PageDispModeId, strComparisonOpPageDispModeId);
}
if (objQxPrjMenusCond.IsUpdated(conQxPrjMenus.InUse) == true)
{
if (objQxPrjMenusCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQxPrjMenus.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQxPrjMenus.InUse);
}
}
if (objQxPrjMenusCond.IsUpdated(conQxPrjMenus.MenuControlName) == true)
{
string strComparisonOpMenuControlName = objQxPrjMenusCond.dicFldComparisonOp[conQxPrjMenus.MenuControlName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenus.MenuControlName, objQxPrjMenusCond.MenuControlName, strComparisonOpMenuControlName);
}
if (objQxPrjMenusCond.IsUpdated(conQxPrjMenus.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objQxPrjMenusCond.dicFldComparisonOp[conQxPrjMenus.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", conQxPrjMenus.ApplicationTypeId, objQxPrjMenusCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objQxPrjMenusCond.IsUpdated(conQxPrjMenus.UpdDate) == true)
{
string strComparisonOpUpdDate = objQxPrjMenusCond.dicFldComparisonOp[conQxPrjMenus.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenus.UpdDate, objQxPrjMenusCond.UpdDate, strComparisonOpUpdDate);
}
if (objQxPrjMenusCond.IsUpdated(conQxPrjMenus.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objQxPrjMenusCond.dicFldComparisonOp[conQxPrjMenus.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenus.UpdUserId, objQxPrjMenusCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objQxPrjMenusCond.IsUpdated(conQxPrjMenus.Memo) == true)
{
string strComparisonOpMemo = objQxPrjMenusCond.dicFldComparisonOp[conQxPrjMenus.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjMenus.Memo, objQxPrjMenusCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxPrjMenusEN objQxPrjMenusEN)
{
 if (string.IsNullOrEmpty(objQxPrjMenusEN.MenuId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objQxPrjMenusEN.sfUpdFldSetStr = objQxPrjMenusEN.getsfUpdFldSetStr();
clsQxPrjMenusWApi.CheckPropertyNew(objQxPrjMenusEN); 
bool bolResult = clsQxPrjMenusWApi.UpdateRecord(objQxPrjMenusEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjMenusWApi.ReFreshCache();
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
 /// 获取唯一性条件串--QxPrjMenus(工程菜单), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:MenuName_QxPrjId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsQxPrjMenusEN objQxPrjMenusEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objQxPrjMenusEN == null) return "";
if (objQxPrjMenusEN.MenuId == null || objQxPrjMenusEN.MenuId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and MenuName = '{0}'", objQxPrjMenusEN.MenuName);
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxPrjMenusEN.QxPrjId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("MenuId !=  '{0}'", objQxPrjMenusEN.MenuId);
 sbCondition.AppendFormat(" and MenuName = '{0}'", objQxPrjMenusEN.MenuName);
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxPrjMenusEN.QxPrjId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQxPrjMenusEN objQxPrjMenusEN)
{
 if (string.IsNullOrEmpty(objQxPrjMenusEN.MenuId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQxPrjMenusWApi.IsExist(objQxPrjMenusEN.MenuId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQxPrjMenusEN.MenuId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsQxPrjMenusWApi.CheckPropertyNew(objQxPrjMenusEN); 
bool bolResult = clsQxPrjMenusWApi.AddNewRecord(objQxPrjMenusEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjMenusWApi.ReFreshCache();
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
 /// <param name = "objQxPrjMenusEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsQxPrjMenusEN objQxPrjMenusEN)
{
try
{
clsQxPrjMenusWApi.CheckPropertyNew(objQxPrjMenusEN); 
string strMenuId = clsQxPrjMenusWApi.AddNewRecordWithMaxId(objQxPrjMenusEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjMenusWApi.ReFreshCache();
return strMenuId;
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
 /// <param name = "objQxPrjMenusEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxPrjMenusEN objQxPrjMenusEN, string strWhereCond)
{
try
{
clsQxPrjMenusWApi.CheckPropertyNew(objQxPrjMenusEN); 
bool bolResult = clsQxPrjMenusWApi.UpdateWithCondition(objQxPrjMenusEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjMenusWApi.ReFreshCache();
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
 /// 工程菜单(QxPrjMenus)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsQxPrjMenusWApi
{
private static readonly string mstrApiControllerName = "QxPrjMenusApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsQxPrjMenusWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_MenuId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[工程菜单]...","0");
List<clsQxPrjMenusEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="MenuId";
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

 /// <param name = "strQxPrjId"></param>
public static void BindCbo_MenuId(System.Windows.Forms.ComboBox objComboBox , string strQxPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conQxPrjMenus.MenuId); 
List<clsQxPrjMenusEN> arrObjLst = clsQxPrjMenusWApi.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.QxPrjId == strQxPrjId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsQxPrjMenusEN objQxPrjMenusEN = new clsQxPrjMenusEN()
{
MenuId = "0",
MenuName = "选[工程菜单]..."
};
arrObjLstSel.Insert(0, objQxPrjMenusEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conQxPrjMenus.MenuId;
objComboBox.DisplayMember = conQxPrjMenus.MenuName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

//该表下拉框功能不需要生成;

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsQxPrjMenusEN objQxPrjMenusEN)
{
if (!Object.Equals(null, objQxPrjMenusEN.MenuId) && GetStrLen(objQxPrjMenusEN.MenuId) > 8)
{
 throw new Exception("字段[菜单Id]的长度不能超过8!");
}
if (!Object.Equals(null, objQxPrjMenusEN.MenuName) && GetStrLen(objQxPrjMenusEN.MenuName) > 50)
{
 throw new Exception("字段[菜单名]的长度不能超过50!");
}
if (!Object.Equals(null, objQxPrjMenusEN.QxPrjId) && GetStrLen(objQxPrjMenusEN.QxPrjId) > 4)
{
 throw new Exception("字段[项目Id]的长度不能超过4!");
}
if (!Object.Equals(null, objQxPrjMenusEN.UpMenuId) && GetStrLen(objQxPrjMenusEN.UpMenuId) > 8)
{
 throw new Exception("字段[上级菜单Id]的长度不能超过8!");
}
if (!Object.Equals(null, objQxPrjMenusEN.LinkFile) && GetStrLen(objQxPrjMenusEN.LinkFile) > 500)
{
 throw new Exception("字段[链接文件]的长度不能超过500!");
}
if (!Object.Equals(null, objQxPrjMenusEN.qsParameters) && GetStrLen(objQxPrjMenusEN.qsParameters) > 200)
{
 throw new Exception("字段[qs参数]的长度不能超过200!");
}
if (!Object.Equals(null, objQxPrjMenusEN.TabId) && GetStrLen(objQxPrjMenusEN.TabId) > 8)
{
 throw new Exception("字段[表ID]的长度不能超过8!");
}
if (!Object.Equals(null, objQxPrjMenusEN.ImgFile) && GetStrLen(objQxPrjMenusEN.ImgFile) > 300)
{
 throw new Exception("字段[图像文件]的长度不能超过300!");
}
if (!Object.Equals(null, objQxPrjMenusEN.RoleId) && GetStrLen(objQxPrjMenusEN.RoleId) > 8)
{
 throw new Exception("字段[角色Id]的长度不能超过8!");
}
if (!Object.Equals(null, objQxPrjMenusEN.MenuTitle) && GetStrLen(objQxPrjMenusEN.MenuTitle) > 50)
{
 throw new Exception("字段[菜单标题]的长度不能超过50!");
}
if (!Object.Equals(null, objQxPrjMenusEN.PageDispModeId) && GetStrLen(objQxPrjMenusEN.PageDispModeId) > 2)
{
 throw new Exception("字段[页面显示模式Id]的长度不能超过2!");
}
if (!Object.Equals(null, objQxPrjMenusEN.MenuControlName) && GetStrLen(objQxPrjMenusEN.MenuControlName) > 100)
{
 throw new Exception("字段[菜单控件名]的长度不能超过100!");
}
if (!Object.Equals(null, objQxPrjMenusEN.UpdDate) && GetStrLen(objQxPrjMenusEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objQxPrjMenusEN.UpdUserId) && GetStrLen(objQxPrjMenusEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objQxPrjMenusEN.Memo) && GetStrLen(objQxPrjMenusEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objQxPrjMenusEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strMenuId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxPrjMenusEN GetObjByMenuId(string strMenuId)
{
string strAction = "GetObjByMenuId";
clsQxPrjMenusEN objQxPrjMenusEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strMenuId"] = strMenuId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objQxPrjMenusEN = JsonConvert.DeserializeObject<clsQxPrjMenusEN>(strJson);
return objQxPrjMenusEN;
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
public static clsQxPrjMenusEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsQxPrjMenusEN objQxPrjMenusEN;
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
objQxPrjMenusEN = JsonConvert.DeserializeObject<clsQxPrjMenusEN>(strJson);
return objQxPrjMenusEN;
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
 /// <param name = "strMenuId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxPrjMenusEN GetObjByMenuIdCache(string strMenuId)
{
if (string.IsNullOrEmpty(strMenuId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsQxPrjMenusEN._CurrTabName);
List<clsQxPrjMenusEN> arrQxPrjMenusObjLstCache = GetObjLstCache();
IEnumerable <clsQxPrjMenusEN> arrQxPrjMenusObjLst_Sel =
from objQxPrjMenusEN in arrQxPrjMenusObjLstCache
where objQxPrjMenusEN.MenuId == strMenuId 
select objQxPrjMenusEN;
if (arrQxPrjMenusObjLst_Sel.Count() == 0)
{
   clsQxPrjMenusEN obj = clsQxPrjMenusWApi.GetObjByMenuId(strMenuId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrQxPrjMenusObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strMenuId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetMenuNameByMenuIdCache(string strMenuId)
{
if (string.IsNullOrEmpty(strMenuId) == true) return "";
//初始化列表缓存
List<clsQxPrjMenusEN> arrQxPrjMenusObjLstCache = GetObjLstCache();
IEnumerable <clsQxPrjMenusEN> arrQxPrjMenusObjLst_Sel1 =
from objQxPrjMenusEN in arrQxPrjMenusObjLstCache
where objQxPrjMenusEN.MenuId == strMenuId 
select objQxPrjMenusEN;
List <clsQxPrjMenusEN> arrQxPrjMenusObjLst_Sel = new List<clsQxPrjMenusEN>();
foreach (clsQxPrjMenusEN obj in arrQxPrjMenusObjLst_Sel1)
{
arrQxPrjMenusObjLst_Sel.Add(obj);
}
if (arrQxPrjMenusObjLst_Sel.Count > 0)
{
return arrQxPrjMenusObjLst_Sel[0].MenuName;
}
string strErrMsgForGetObjById = string.Format("在QxPrjMenus对象缓存列表中,找不到记录[MenuId = {0}](函数:{1})", strMenuId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsQxPrjMenusBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strMenuId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByMenuIdCache(string strMenuId)
{
if (string.IsNullOrEmpty(strMenuId) == true) return "";
//初始化列表缓存
List<clsQxPrjMenusEN> arrQxPrjMenusObjLstCache = GetObjLstCache();
IEnumerable <clsQxPrjMenusEN> arrQxPrjMenusObjLst_Sel1 =
from objQxPrjMenusEN in arrQxPrjMenusObjLstCache
where objQxPrjMenusEN.MenuId == strMenuId 
select objQxPrjMenusEN;
List <clsQxPrjMenusEN> arrQxPrjMenusObjLst_Sel = new List<clsQxPrjMenusEN>();
foreach (clsQxPrjMenusEN obj in arrQxPrjMenusObjLst_Sel1)
{
arrQxPrjMenusObjLst_Sel.Add(obj);
}
if (arrQxPrjMenusObjLst_Sel.Count > 0)
{
return arrQxPrjMenusObjLst_Sel[0].MenuName;
}
string strErrMsgForGetObjById = string.Format("在QxPrjMenus对象缓存列表中,找不到记录的相关名称[MenuId = {0}](函数:{1})", strMenuId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsQxPrjMenusBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPrjMenusEN> GetObjLst(string strWhereCond)
{
 List<clsQxPrjMenusEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxPrjMenusEN>>(strJson);
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
 /// <param name = "arrMenuId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPrjMenusEN> GetObjLstByMenuIdLst(List<string> arrMenuId)
{
 List<clsQxPrjMenusEN> arrObjLst; 
string strAction = "GetObjLstByMenuIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMenuId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsQxPrjMenusEN>>(strJson);
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
 /// <param name = "arrMenuId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsQxPrjMenusEN> GetObjLstByMenuIdLstCache(List<string> arrMenuId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsQxPrjMenusEN._CurrTabName);
List<clsQxPrjMenusEN> arrQxPrjMenusObjLstCache = GetObjLstCache();
IEnumerable <clsQxPrjMenusEN> arrQxPrjMenusObjLst_Sel =
from objQxPrjMenusEN in arrQxPrjMenusObjLstCache
where arrMenuId.Contains(objQxPrjMenusEN.MenuId)
select objQxPrjMenusEN;
return arrQxPrjMenusObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPrjMenusEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsQxPrjMenusEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxPrjMenusEN>>(strJson);
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
public static List<clsQxPrjMenusEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsQxPrjMenusEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxPrjMenusEN>>(strJson);
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
public static List<clsQxPrjMenusEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsQxPrjMenusEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxPrjMenusEN>>(strJson);
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
public static List<clsQxPrjMenusEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsQxPrjMenusEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxPrjMenusEN>>(strJson);
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
public static int DelRecord(string strMenuId)
{
string strAction = "DelRecord";
try
{
 clsQxPrjMenusEN objQxPrjMenusEN = clsQxPrjMenusWApi.GetObjByMenuId(strMenuId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strMenuId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsQxPrjMenusWApi.ReFreshCache();
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
public static int DelQxPrjMenuss(List<string> arrMenuId)
{
string strAction = "DelQxPrjMenuss";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMenuId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsQxPrjMenusWApi.ReFreshCache();
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
public static int DelQxPrjMenussByCond(string strWhereCond)
{
string strAction = "DelQxPrjMenussByCond";
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
public static bool AddNewRecord(clsQxPrjMenusEN objQxPrjMenusEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxPrjMenusEN>(objQxPrjMenusEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjMenusWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsQxPrjMenusEN objQxPrjMenusEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxPrjMenusEN>(objQxPrjMenusEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjMenusWApi.ReFreshCache();
var strMenuId = (string)jobjReturn0["returnStr"];
return strMenuId;
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
public static bool UpdateRecord(clsQxPrjMenusEN objQxPrjMenusEN)
{
if (string.IsNullOrEmpty(objQxPrjMenusEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objQxPrjMenusEN.MenuId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxPrjMenusEN>(objQxPrjMenusEN);
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
 /// <param name = "objQxPrjMenusEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsQxPrjMenusEN objQxPrjMenusEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objQxPrjMenusEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objQxPrjMenusEN.MenuId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objQxPrjMenusEN.MenuId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxPrjMenusEN>(objQxPrjMenusEN);
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
public static bool IsExist(string strMenuId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strMenuId"] = strMenuId
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
 /// <param name = "objQxPrjMenusENS">源对象</param>
 /// <param name = "objQxPrjMenusENT">目标对象</param>
 public static void CopyTo(clsQxPrjMenusEN objQxPrjMenusENS, clsQxPrjMenusEN objQxPrjMenusENT)
{
try
{
objQxPrjMenusENT.MenuId = objQxPrjMenusENS.MenuId; //菜单Id
objQxPrjMenusENT.MenuName = objQxPrjMenusENS.MenuName; //菜单名
objQxPrjMenusENT.QxPrjId = objQxPrjMenusENS.QxPrjId; //项目Id
objQxPrjMenusENT.UpMenuId = objQxPrjMenusENS.UpMenuId; //上级菜单Id
objQxPrjMenusENT.LinkFile = objQxPrjMenusENS.LinkFile; //链接文件
objQxPrjMenusENT.qsParameters = objQxPrjMenusENS.qsParameters; //qs参数
objQxPrjMenusENT.TabId = objQxPrjMenusENS.TabId; //表ID
objQxPrjMenusENT.ImgFile = objQxPrjMenusENS.ImgFile; //图像文件
objQxPrjMenusENT.RoleId = objQxPrjMenusENS.RoleId; //角色Id
objQxPrjMenusENT.OrderNum = objQxPrjMenusENS.OrderNum; //排序号
objQxPrjMenusENT.IsLeafNode = objQxPrjMenusENS.IsLeafNode; //是否叶子
objQxPrjMenusENT.MenuTitle = objQxPrjMenusENS.MenuTitle; //菜单标题
objQxPrjMenusENT.PageDispModeId = objQxPrjMenusENS.PageDispModeId; //页面显示模式Id
objQxPrjMenusENT.InUse = objQxPrjMenusENS.InUse; //是否在用
objQxPrjMenusENT.MenuControlName = objQxPrjMenusENS.MenuControlName; //菜单控件名
objQxPrjMenusENT.ApplicationTypeId = objQxPrjMenusENS.ApplicationTypeId; //应用程序类型Id
objQxPrjMenusENT.UpdDate = objQxPrjMenusENS.UpdDate; //修改日期
objQxPrjMenusENT.UpdUserId = objQxPrjMenusENS.UpdUserId; //修改用户Id
objQxPrjMenusENT.Memo = objQxPrjMenusENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsQxPrjMenusEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsQxPrjMenusEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsQxPrjMenusEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsQxPrjMenusEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsQxPrjMenusEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsQxPrjMenusEN.AttributeName)
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
string strKey = string.Format("{0}", clsQxPrjMenusEN._CurrTabName);
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
if (clsQxPrjMenusWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsQxPrjMenusEN._CurrTabName);
CacheHelper.Remove(strKey);
clsQxPrjMenusWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxPrjMenusEN> GetObjLstCache()
{
//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsQxPrjMenusEN._CurrTabName;
List<clsQxPrjMenusEN> arrQxPrjMenusObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrQxPrjMenusObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsQxPrjMenusEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conQxPrjMenus.MenuId, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjMenus.MenuName, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjMenus.QxPrjId, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjMenus.UpMenuId, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjMenus.LinkFile, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjMenus.qsParameters, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjMenus.TabId, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjMenus.ImgFile, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjMenus.RoleId, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjMenus.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conQxPrjMenus.IsLeafNode, Type.GetType("System.Boolean"));
objDT.Columns.Add(conQxPrjMenus.MenuTitle, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjMenus.PageDispModeId, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjMenus.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(conQxPrjMenus.MenuControlName, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjMenus.ApplicationTypeId, Type.GetType("System.Int32"));
objDT.Columns.Add(conQxPrjMenus.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjMenus.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjMenus.Memo, Type.GetType("System.String"));
foreach (clsQxPrjMenusEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conQxPrjMenus.MenuId] = objInFor[conQxPrjMenus.MenuId];
objDR[conQxPrjMenus.MenuName] = objInFor[conQxPrjMenus.MenuName];
objDR[conQxPrjMenus.QxPrjId] = objInFor[conQxPrjMenus.QxPrjId];
objDR[conQxPrjMenus.UpMenuId] = objInFor[conQxPrjMenus.UpMenuId];
objDR[conQxPrjMenus.LinkFile] = objInFor[conQxPrjMenus.LinkFile];
objDR[conQxPrjMenus.qsParameters] = objInFor[conQxPrjMenus.qsParameters];
objDR[conQxPrjMenus.TabId] = objInFor[conQxPrjMenus.TabId];
objDR[conQxPrjMenus.ImgFile] = objInFor[conQxPrjMenus.ImgFile];
objDR[conQxPrjMenus.RoleId] = objInFor[conQxPrjMenus.RoleId];
objDR[conQxPrjMenus.OrderNum] = objInFor[conQxPrjMenus.OrderNum];
objDR[conQxPrjMenus.IsLeafNode] = objInFor[conQxPrjMenus.IsLeafNode];
objDR[conQxPrjMenus.MenuTitle] = objInFor[conQxPrjMenus.MenuTitle];
objDR[conQxPrjMenus.PageDispModeId] = objInFor[conQxPrjMenus.PageDispModeId];
objDR[conQxPrjMenus.InUse] = objInFor[conQxPrjMenus.InUse];
objDR[conQxPrjMenus.MenuControlName] = objInFor[conQxPrjMenus.MenuControlName];
objDR[conQxPrjMenus.ApplicationTypeId] = objInFor[conQxPrjMenus.ApplicationTypeId];
objDR[conQxPrjMenus.UpdDate] = objInFor[conQxPrjMenus.UpdDate];
objDR[conQxPrjMenus.UpdUserId] = objInFor[conQxPrjMenus.UpdUserId];
objDR[conQxPrjMenus.Memo] = objInFor[conQxPrjMenus.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 工程菜单(QxPrjMenus)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4QxPrjMenus : clsCommFun4BL
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
clsQxPrjMenusWApi.ReFreshThisCache();
}
}

}