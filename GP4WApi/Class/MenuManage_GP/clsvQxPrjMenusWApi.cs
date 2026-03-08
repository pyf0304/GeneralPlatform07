
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPrjMenusWApi
 表名:vQxPrjMenus(00140046)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 18:31:11
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
public static class  clsvQxPrjMenusWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strMenuId">菜单Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetMenuId(this clsvQxPrjMenusEN objvQxPrjMenusEN, string strMenuId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMenuId, 8, convQxPrjMenus.MenuId);
clsCheckSql.CheckFieldForeignKey(strMenuId, 8, convQxPrjMenus.MenuId);
objvQxPrjMenusEN.MenuId = strMenuId; //菜单Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenusEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus.MenuId) == false)
{
objvQxPrjMenusEN.dicFldComparisonOp.Add(convQxPrjMenus.MenuId, strComparisonOp);
}
else
{
objvQxPrjMenusEN.dicFldComparisonOp[convQxPrjMenus.MenuId] = strComparisonOp;
}
}
return objvQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strMenuName">菜单名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetMenuName(this clsvQxPrjMenusEN objvQxPrjMenusEN, string strMenuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMenuName, convQxPrjMenus.MenuName);
clsCheckSql.CheckFieldLen(strMenuName, 50, convQxPrjMenus.MenuName);
objvQxPrjMenusEN.MenuName = strMenuName; //菜单名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenusEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus.MenuName) == false)
{
objvQxPrjMenusEN.dicFldComparisonOp.Add(convQxPrjMenus.MenuName, strComparisonOp);
}
else
{
objvQxPrjMenusEN.dicFldComparisonOp[convQxPrjMenus.MenuName] = strComparisonOp;
}
}
return objvQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strQxPrjId">项目Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetQxPrjId(this clsvQxPrjMenusEN objvQxPrjMenusEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, convQxPrjMenus.QxPrjId);
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxPrjMenus.QxPrjId);
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxPrjMenus.QxPrjId);
objvQxPrjMenusEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenusEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus.QxPrjId) == false)
{
objvQxPrjMenusEN.dicFldComparisonOp.Add(convQxPrjMenus.QxPrjId, strComparisonOp);
}
else
{
objvQxPrjMenusEN.dicFldComparisonOp[convQxPrjMenus.QxPrjId] = strComparisonOp;
}
}
return objvQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetPrjName(this clsvQxPrjMenusEN objvQxPrjMenusEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convQxPrjMenus.PrjName);
clsCheckSql.CheckFieldLen(strPrjName, 30, convQxPrjMenus.PrjName);
objvQxPrjMenusEN.PrjName = strPrjName; //工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenusEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus.PrjName) == false)
{
objvQxPrjMenusEN.dicFldComparisonOp.Add(convQxPrjMenus.PrjName, strComparisonOp);
}
else
{
objvQxPrjMenusEN.dicFldComparisonOp[convQxPrjMenus.PrjName] = strComparisonOp;
}
}
return objvQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpMenuId">上级菜单Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetUpMenuId(this clsvQxPrjMenusEN objvQxPrjMenusEN, string strUpMenuId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpMenuId, 8, convQxPrjMenus.UpMenuId);
clsCheckSql.CheckFieldForeignKey(strUpMenuId, 8, convQxPrjMenus.UpMenuId);
objvQxPrjMenusEN.UpMenuId = strUpMenuId; //上级菜单Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenusEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus.UpMenuId) == false)
{
objvQxPrjMenusEN.dicFldComparisonOp.Add(convQxPrjMenus.UpMenuId, strComparisonOp);
}
else
{
objvQxPrjMenusEN.dicFldComparisonOp[convQxPrjMenus.UpMenuId] = strComparisonOp;
}
}
return objvQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strLinkFile">链接文件</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetLinkFile(this clsvQxPrjMenusEN objvQxPrjMenusEN, string strLinkFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLinkFile, 500, convQxPrjMenus.LinkFile);
objvQxPrjMenusEN.LinkFile = strLinkFile; //链接文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenusEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus.LinkFile) == false)
{
objvQxPrjMenusEN.dicFldComparisonOp.Add(convQxPrjMenus.LinkFile, strComparisonOp);
}
else
{
objvQxPrjMenusEN.dicFldComparisonOp[convQxPrjMenus.LinkFile] = strComparisonOp;
}
}
return objvQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strqsParameters">qs参数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetqsParameters(this clsvQxPrjMenusEN objvQxPrjMenusEN, string strqsParameters, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strqsParameters, 200, convQxPrjMenus.qsParameters);
objvQxPrjMenusEN.qsParameters = strqsParameters; //qs参数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenusEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus.qsParameters) == false)
{
objvQxPrjMenusEN.dicFldComparisonOp.Add(convQxPrjMenus.qsParameters, strComparisonOp);
}
else
{
objvQxPrjMenusEN.dicFldComparisonOp[convQxPrjMenus.qsParameters] = strComparisonOp;
}
}
return objvQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetTabId(this clsvQxPrjMenusEN objvQxPrjMenusEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabId, 8, convQxPrjMenus.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convQxPrjMenus.TabId);
objvQxPrjMenusEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenusEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus.TabId) == false)
{
objvQxPrjMenusEN.dicFldComparisonOp.Add(convQxPrjMenus.TabId, strComparisonOp);
}
else
{
objvQxPrjMenusEN.dicFldComparisonOp[convQxPrjMenus.TabId] = strComparisonOp;
}
}
return objvQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabName">TabName</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetTabName(this clsvQxPrjMenusEN objvQxPrjMenusEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabName, 100, convQxPrjMenus.TabName);
objvQxPrjMenusEN.TabName = strTabName; //TabName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenusEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus.TabName) == false)
{
objvQxPrjMenusEN.dicFldComparisonOp.Add(convQxPrjMenus.TabName, strComparisonOp);
}
else
{
objvQxPrjMenusEN.dicFldComparisonOp[convQxPrjMenus.TabName] = strComparisonOp;
}
}
return objvQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strImgFile">图像文件</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetImgFile(this clsvQxPrjMenusEN objvQxPrjMenusEN, string strImgFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strImgFile, 300, convQxPrjMenus.ImgFile);
objvQxPrjMenusEN.ImgFile = strImgFile; //图像文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenusEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus.ImgFile) == false)
{
objvQxPrjMenusEN.dicFldComparisonOp.Add(convQxPrjMenus.ImgFile, strComparisonOp);
}
else
{
objvQxPrjMenusEN.dicFldComparisonOp[convQxPrjMenus.ImgFile] = strComparisonOp;
}
}
return objvQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strRoleId">角色Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetRoleId(this clsvQxPrjMenusEN objvQxPrjMenusEN, string strRoleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRoleId, 8, convQxPrjMenus.RoleId);
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, convQxPrjMenus.RoleId);
objvQxPrjMenusEN.RoleId = strRoleId; //角色Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenusEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus.RoleId) == false)
{
objvQxPrjMenusEN.dicFldComparisonOp.Add(convQxPrjMenus.RoleId, strComparisonOp);
}
else
{
objvQxPrjMenusEN.dicFldComparisonOp[convQxPrjMenus.RoleId] = strComparisonOp;
}
}
return objvQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strRoleName">角色名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetRoleName(this clsvQxPrjMenusEN objvQxPrjMenusEN, string strRoleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRoleName, convQxPrjMenus.RoleName);
clsCheckSql.CheckFieldLen(strRoleName, 50, convQxPrjMenus.RoleName);
objvQxPrjMenusEN.RoleName = strRoleName; //角色名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenusEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus.RoleName) == false)
{
objvQxPrjMenusEN.dicFldComparisonOp.Add(convQxPrjMenus.RoleName, strComparisonOp);
}
else
{
objvQxPrjMenusEN.dicFldComparisonOp[convQxPrjMenus.RoleName] = strComparisonOp;
}
}
return objvQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">排序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetOrderNum(this clsvQxPrjMenusEN objvQxPrjMenusEN, int intOrderNum, string strComparisonOp="")
	{
objvQxPrjMenusEN.OrderNum = intOrderNum; //排序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenusEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus.OrderNum) == false)
{
objvQxPrjMenusEN.dicFldComparisonOp.Add(convQxPrjMenus.OrderNum, strComparisonOp);
}
else
{
objvQxPrjMenusEN.dicFldComparisonOp[convQxPrjMenus.OrderNum] = strComparisonOp;
}
}
return objvQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsLeafNode">是否叶子</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetIsLeafNode(this clsvQxPrjMenusEN objvQxPrjMenusEN, bool bolIsLeafNode, string strComparisonOp="")
	{
objvQxPrjMenusEN.IsLeafNode = bolIsLeafNode; //是否叶子
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenusEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus.IsLeafNode) == false)
{
objvQxPrjMenusEN.dicFldComparisonOp.Add(convQxPrjMenus.IsLeafNode, strComparisonOp);
}
else
{
objvQxPrjMenusEN.dicFldComparisonOp[convQxPrjMenus.IsLeafNode] = strComparisonOp;
}
}
return objvQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strMenuSetId">菜单集Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetMenuSetId(this clsvQxPrjMenusEN objvQxPrjMenusEN, string strMenuSetId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMenuSetId, convQxPrjMenus.MenuSetId);
clsCheckSql.CheckFieldLen(strMenuSetId, 4, convQxPrjMenus.MenuSetId);
clsCheckSql.CheckFieldForeignKey(strMenuSetId, 4, convQxPrjMenus.MenuSetId);
objvQxPrjMenusEN.MenuSetId = strMenuSetId; //菜单集Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenusEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus.MenuSetId) == false)
{
objvQxPrjMenusEN.dicFldComparisonOp.Add(convQxPrjMenus.MenuSetId, strComparisonOp);
}
else
{
objvQxPrjMenusEN.dicFldComparisonOp[convQxPrjMenus.MenuSetId] = strComparisonOp;
}
}
return objvQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strMenuSetName">菜单集名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetMenuSetName(this clsvQxPrjMenusEN objvQxPrjMenusEN, string strMenuSetName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMenuSetName, 50, convQxPrjMenus.MenuSetName);
objvQxPrjMenusEN.MenuSetName = strMenuSetName; //菜单集名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenusEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus.MenuSetName) == false)
{
objvQxPrjMenusEN.dicFldComparisonOp.Add(convQxPrjMenus.MenuSetName, strComparisonOp);
}
else
{
objvQxPrjMenusEN.dicFldComparisonOp[convQxPrjMenus.MenuSetName] = strComparisonOp;
}
}
return objvQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strMenuTitle">菜单标题</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetMenuTitle(this clsvQxPrjMenusEN objvQxPrjMenusEN, string strMenuTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMenuTitle, 50, convQxPrjMenus.MenuTitle);
objvQxPrjMenusEN.MenuTitle = strMenuTitle; //菜单标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenusEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus.MenuTitle) == false)
{
objvQxPrjMenusEN.dicFldComparisonOp.Add(convQxPrjMenus.MenuTitle, strComparisonOp);
}
else
{
objvQxPrjMenusEN.dicFldComparisonOp[convQxPrjMenus.MenuTitle] = strComparisonOp;
}
}
return objvQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strPageDispModeId">页面显示模式Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetPageDispModeId(this clsvQxPrjMenusEN objvQxPrjMenusEN, string strPageDispModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPageDispModeId, 2, convQxPrjMenus.PageDispModeId);
clsCheckSql.CheckFieldForeignKey(strPageDispModeId, 2, convQxPrjMenus.PageDispModeId);
objvQxPrjMenusEN.PageDispModeId = strPageDispModeId; //页面显示模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenusEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus.PageDispModeId) == false)
{
objvQxPrjMenusEN.dicFldComparisonOp.Add(convQxPrjMenus.PageDispModeId, strComparisonOp);
}
else
{
objvQxPrjMenusEN.dicFldComparisonOp[convQxPrjMenus.PageDispModeId] = strComparisonOp;
}
}
return objvQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strPageDispModeName">页面显示模式名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetPageDispModeName(this clsvQxPrjMenusEN objvQxPrjMenusEN, string strPageDispModeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPageDispModeName, 50, convQxPrjMenus.PageDispModeName);
objvQxPrjMenusEN.PageDispModeName = strPageDispModeName; //页面显示模式名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenusEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus.PageDispModeName) == false)
{
objvQxPrjMenusEN.dicFldComparisonOp.Add(convQxPrjMenus.PageDispModeName, strComparisonOp);
}
else
{
objvQxPrjMenusEN.dicFldComparisonOp[convQxPrjMenus.PageDispModeName] = strComparisonOp;
}
}
return objvQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetInUse(this clsvQxPrjMenusEN objvQxPrjMenusEN, bool bolInUse, string strComparisonOp="")
	{
objvQxPrjMenusEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenusEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus.InUse) == false)
{
objvQxPrjMenusEN.dicFldComparisonOp.Add(convQxPrjMenus.InUse, strComparisonOp);
}
else
{
objvQxPrjMenusEN.dicFldComparisonOp[convQxPrjMenus.InUse] = strComparisonOp;
}
}
return objvQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strMenuControlName">MenuControlName</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetMenuControlName(this clsvQxPrjMenusEN objvQxPrjMenusEN, string strMenuControlName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMenuControlName, 100, convQxPrjMenus.MenuControlName);
objvQxPrjMenusEN.MenuControlName = strMenuControlName; //MenuControlName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenusEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus.MenuControlName) == false)
{
objvQxPrjMenusEN.dicFldComparisonOp.Add(convQxPrjMenus.MenuControlName, strComparisonOp);
}
else
{
objvQxPrjMenusEN.dicFldComparisonOp[convQxPrjMenus.MenuControlName] = strComparisonOp;
}
}
return objvQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "intApplicationTypeId">应用程序类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetApplicationTypeId(this clsvQxPrjMenusEN objvQxPrjMenusEN, int intApplicationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intApplicationTypeId, convQxPrjMenus.ApplicationTypeId);
objvQxPrjMenusEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenusEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus.ApplicationTypeId) == false)
{
objvQxPrjMenusEN.dicFldComparisonOp.Add(convQxPrjMenus.ApplicationTypeId, strComparisonOp);
}
else
{
objvQxPrjMenusEN.dicFldComparisonOp[convQxPrjMenus.ApplicationTypeId] = strComparisonOp;
}
}
return objvQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strApplicationTypeName">应用程序类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetApplicationTypeName(this clsvQxPrjMenusEN objvQxPrjMenusEN, string strApplicationTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strApplicationTypeName, 30, convQxPrjMenus.ApplicationTypeName);
objvQxPrjMenusEN.ApplicationTypeName = strApplicationTypeName; //应用程序类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenusEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus.ApplicationTypeName) == false)
{
objvQxPrjMenusEN.dicFldComparisonOp.Add(convQxPrjMenus.ApplicationTypeName, strComparisonOp);
}
else
{
objvQxPrjMenusEN.dicFldComparisonOp[convQxPrjMenus.ApplicationTypeName] = strComparisonOp;
}
}
return objvQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetUpdDate(this clsvQxPrjMenusEN objvQxPrjMenusEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQxPrjMenus.UpdDate);
objvQxPrjMenusEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenusEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus.UpdDate) == false)
{
objvQxPrjMenusEN.dicFldComparisonOp.Add(convQxPrjMenus.UpdDate, strComparisonOp);
}
else
{
objvQxPrjMenusEN.dicFldComparisonOp[convQxPrjMenus.UpdDate] = strComparisonOp;
}
}
return objvQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetUpdUserId(this clsvQxPrjMenusEN objvQxPrjMenusEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convQxPrjMenus.UpdUserId);
objvQxPrjMenusEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenusEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus.UpdUserId) == false)
{
objvQxPrjMenusEN.dicFldComparisonOp.Add(convQxPrjMenus.UpdUserId, strComparisonOp);
}
else
{
objvQxPrjMenusEN.dicFldComparisonOp[convQxPrjMenus.UpdUserId] = strComparisonOp;
}
}
return objvQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">备注</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetMemo(this clsvQxPrjMenusEN objvQxPrjMenusEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxPrjMenus.Memo);
objvQxPrjMenusEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenusEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus.Memo) == false)
{
objvQxPrjMenusEN.dicFldComparisonOp.Add(convQxPrjMenus.Memo, strComparisonOp);
}
else
{
objvQxPrjMenusEN.dicFldComparisonOp[convQxPrjMenus.Memo] = strComparisonOp;
}
}
return objvQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpMenuName">上级菜单名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetUpMenuName(this clsvQxPrjMenusEN objvQxPrjMenusEN, string strUpMenuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpMenuName, 30, convQxPrjMenus.UpMenuName);
objvQxPrjMenusEN.UpMenuName = strUpMenuName; //上级菜单名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenusEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus.UpMenuName) == false)
{
objvQxPrjMenusEN.dicFldComparisonOp.Add(convQxPrjMenus.UpMenuName, strComparisonOp);
}
else
{
objvQxPrjMenusEN.dicFldComparisonOp[convQxPrjMenus.UpMenuName] = strComparisonOp;
}
}
return objvQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "intSubMenusNum">子菜单数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetSubMenusNum(this clsvQxPrjMenusEN objvQxPrjMenusEN, int intSubMenusNum, string strComparisonOp="")
	{
objvQxPrjMenusEN.SubMenusNum = intSubMenusNum; //子菜单数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenusEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus.SubMenusNum) == false)
{
objvQxPrjMenusEN.dicFldComparisonOp.Add(convQxPrjMenus.SubMenusNum, strComparisonOp);
}
else
{
objvQxPrjMenusEN.dicFldComparisonOp[convQxPrjMenus.SubMenusNum] = strComparisonOp;
}
}
return objvQxPrjMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "intRoleNum">角色数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetRoleNum(this clsvQxPrjMenusEN objvQxPrjMenusEN, int intRoleNum, string strComparisonOp="")
	{
objvQxPrjMenusEN.RoleNum = intRoleNum; //角色数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenusEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus.RoleNum) == false)
{
objvQxPrjMenusEN.dicFldComparisonOp.Add(convQxPrjMenus.RoleNum, strComparisonOp);
}
else
{
objvQxPrjMenusEN.dicFldComparisonOp[convQxPrjMenus.RoleNum] = strComparisonOp;
}
}
return objvQxPrjMenusEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQxPrjMenusEN objvQxPrjMenusCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQxPrjMenusCond.IsUpdated(convQxPrjMenus.MenuId) == true)
{
string strComparisonOpMenuId = objvQxPrjMenusCond.dicFldComparisonOp[convQxPrjMenus.MenuId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus.MenuId, objvQxPrjMenusCond.MenuId, strComparisonOpMenuId);
}
if (objvQxPrjMenusCond.IsUpdated(convQxPrjMenus.MenuName) == true)
{
string strComparisonOpMenuName = objvQxPrjMenusCond.dicFldComparisonOp[convQxPrjMenus.MenuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus.MenuName, objvQxPrjMenusCond.MenuName, strComparisonOpMenuName);
}
if (objvQxPrjMenusCond.IsUpdated(convQxPrjMenus.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objvQxPrjMenusCond.dicFldComparisonOp[convQxPrjMenus.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus.QxPrjId, objvQxPrjMenusCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objvQxPrjMenusCond.IsUpdated(convQxPrjMenus.PrjName) == true)
{
string strComparisonOpPrjName = objvQxPrjMenusCond.dicFldComparisonOp[convQxPrjMenus.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus.PrjName, objvQxPrjMenusCond.PrjName, strComparisonOpPrjName);
}
if (objvQxPrjMenusCond.IsUpdated(convQxPrjMenus.UpMenuId) == true)
{
string strComparisonOpUpMenuId = objvQxPrjMenusCond.dicFldComparisonOp[convQxPrjMenus.UpMenuId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus.UpMenuId, objvQxPrjMenusCond.UpMenuId, strComparisonOpUpMenuId);
}
if (objvQxPrjMenusCond.IsUpdated(convQxPrjMenus.LinkFile) == true)
{
string strComparisonOpLinkFile = objvQxPrjMenusCond.dicFldComparisonOp[convQxPrjMenus.LinkFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus.LinkFile, objvQxPrjMenusCond.LinkFile, strComparisonOpLinkFile);
}
if (objvQxPrjMenusCond.IsUpdated(convQxPrjMenus.qsParameters) == true)
{
string strComparisonOpqsParameters = objvQxPrjMenusCond.dicFldComparisonOp[convQxPrjMenus.qsParameters];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus.qsParameters, objvQxPrjMenusCond.qsParameters, strComparisonOpqsParameters);
}
if (objvQxPrjMenusCond.IsUpdated(convQxPrjMenus.TabId) == true)
{
string strComparisonOpTabId = objvQxPrjMenusCond.dicFldComparisonOp[convQxPrjMenus.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus.TabId, objvQxPrjMenusCond.TabId, strComparisonOpTabId);
}
if (objvQxPrjMenusCond.IsUpdated(convQxPrjMenus.TabName) == true)
{
string strComparisonOpTabName = objvQxPrjMenusCond.dicFldComparisonOp[convQxPrjMenus.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus.TabName, objvQxPrjMenusCond.TabName, strComparisonOpTabName);
}
if (objvQxPrjMenusCond.IsUpdated(convQxPrjMenus.ImgFile) == true)
{
string strComparisonOpImgFile = objvQxPrjMenusCond.dicFldComparisonOp[convQxPrjMenus.ImgFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus.ImgFile, objvQxPrjMenusCond.ImgFile, strComparisonOpImgFile);
}
if (objvQxPrjMenusCond.IsUpdated(convQxPrjMenus.RoleId) == true)
{
string strComparisonOpRoleId = objvQxPrjMenusCond.dicFldComparisonOp[convQxPrjMenus.RoleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus.RoleId, objvQxPrjMenusCond.RoleId, strComparisonOpRoleId);
}
if (objvQxPrjMenusCond.IsUpdated(convQxPrjMenus.RoleName) == true)
{
string strComparisonOpRoleName = objvQxPrjMenusCond.dicFldComparisonOp[convQxPrjMenus.RoleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus.RoleName, objvQxPrjMenusCond.RoleName, strComparisonOpRoleName);
}
if (objvQxPrjMenusCond.IsUpdated(convQxPrjMenus.OrderNum) == true)
{
string strComparisonOpOrderNum = objvQxPrjMenusCond.dicFldComparisonOp[convQxPrjMenus.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQxPrjMenus.OrderNum, objvQxPrjMenusCond.OrderNum, strComparisonOpOrderNum);
}
if (objvQxPrjMenusCond.IsUpdated(convQxPrjMenus.IsLeafNode) == true)
{
if (objvQxPrjMenusCond.IsLeafNode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQxPrjMenus.IsLeafNode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQxPrjMenus.IsLeafNode);
}
}
if (objvQxPrjMenusCond.IsUpdated(convQxPrjMenus.MenuSetId) == true)
{
string strComparisonOpMenuSetId = objvQxPrjMenusCond.dicFldComparisonOp[convQxPrjMenus.MenuSetId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus.MenuSetId, objvQxPrjMenusCond.MenuSetId, strComparisonOpMenuSetId);
}
if (objvQxPrjMenusCond.IsUpdated(convQxPrjMenus.MenuSetName) == true)
{
string strComparisonOpMenuSetName = objvQxPrjMenusCond.dicFldComparisonOp[convQxPrjMenus.MenuSetName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus.MenuSetName, objvQxPrjMenusCond.MenuSetName, strComparisonOpMenuSetName);
}
if (objvQxPrjMenusCond.IsUpdated(convQxPrjMenus.MenuTitle) == true)
{
string strComparisonOpMenuTitle = objvQxPrjMenusCond.dicFldComparisonOp[convQxPrjMenus.MenuTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus.MenuTitle, objvQxPrjMenusCond.MenuTitle, strComparisonOpMenuTitle);
}
if (objvQxPrjMenusCond.IsUpdated(convQxPrjMenus.PageDispModeId) == true)
{
string strComparisonOpPageDispModeId = objvQxPrjMenusCond.dicFldComparisonOp[convQxPrjMenus.PageDispModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus.PageDispModeId, objvQxPrjMenusCond.PageDispModeId, strComparisonOpPageDispModeId);
}
if (objvQxPrjMenusCond.IsUpdated(convQxPrjMenus.PageDispModeName) == true)
{
string strComparisonOpPageDispModeName = objvQxPrjMenusCond.dicFldComparisonOp[convQxPrjMenus.PageDispModeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus.PageDispModeName, objvQxPrjMenusCond.PageDispModeName, strComparisonOpPageDispModeName);
}
if (objvQxPrjMenusCond.IsUpdated(convQxPrjMenus.InUse) == true)
{
if (objvQxPrjMenusCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQxPrjMenus.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQxPrjMenus.InUse);
}
}
if (objvQxPrjMenusCond.IsUpdated(convQxPrjMenus.MenuControlName) == true)
{
string strComparisonOpMenuControlName = objvQxPrjMenusCond.dicFldComparisonOp[convQxPrjMenus.MenuControlName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus.MenuControlName, objvQxPrjMenusCond.MenuControlName, strComparisonOpMenuControlName);
}
if (objvQxPrjMenusCond.IsUpdated(convQxPrjMenus.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objvQxPrjMenusCond.dicFldComparisonOp[convQxPrjMenus.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", convQxPrjMenus.ApplicationTypeId, objvQxPrjMenusCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objvQxPrjMenusCond.IsUpdated(convQxPrjMenus.ApplicationTypeName) == true)
{
string strComparisonOpApplicationTypeName = objvQxPrjMenusCond.dicFldComparisonOp[convQxPrjMenus.ApplicationTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus.ApplicationTypeName, objvQxPrjMenusCond.ApplicationTypeName, strComparisonOpApplicationTypeName);
}
if (objvQxPrjMenusCond.IsUpdated(convQxPrjMenus.UpdDate) == true)
{
string strComparisonOpUpdDate = objvQxPrjMenusCond.dicFldComparisonOp[convQxPrjMenus.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus.UpdDate, objvQxPrjMenusCond.UpdDate, strComparisonOpUpdDate);
}
if (objvQxPrjMenusCond.IsUpdated(convQxPrjMenus.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvQxPrjMenusCond.dicFldComparisonOp[convQxPrjMenus.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus.UpdUserId, objvQxPrjMenusCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvQxPrjMenusCond.IsUpdated(convQxPrjMenus.Memo) == true)
{
string strComparisonOpMemo = objvQxPrjMenusCond.dicFldComparisonOp[convQxPrjMenus.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus.Memo, objvQxPrjMenusCond.Memo, strComparisonOpMemo);
}
if (objvQxPrjMenusCond.IsUpdated(convQxPrjMenus.UpMenuName) == true)
{
string strComparisonOpUpMenuName = objvQxPrjMenusCond.dicFldComparisonOp[convQxPrjMenus.UpMenuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus.UpMenuName, objvQxPrjMenusCond.UpMenuName, strComparisonOpUpMenuName);
}
if (objvQxPrjMenusCond.IsUpdated(convQxPrjMenus.SubMenusNum) == true)
{
string strComparisonOpSubMenusNum = objvQxPrjMenusCond.dicFldComparisonOp[convQxPrjMenus.SubMenusNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQxPrjMenus.SubMenusNum, objvQxPrjMenusCond.SubMenusNum, strComparisonOpSubMenusNum);
}
if (objvQxPrjMenusCond.IsUpdated(convQxPrjMenus.RoleNum) == true)
{
string strComparisonOpRoleNum = objvQxPrjMenusCond.dicFldComparisonOp[convQxPrjMenus.RoleNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQxPrjMenus.RoleNum, objvQxPrjMenusCond.RoleNum, strComparisonOpRoleNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v工程菜单(vQxPrjMenus)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxPrjMenusWApi
{
private static readonly string mstrApiControllerName = "vQxPrjMenusApi";

 public clsvQxPrjMenusWApi()
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v工程菜单]...","0");
List<clsvQxPrjMenusEN> arrObjLst = GetObjLst("1=1");
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

public static void BindCbo_MenuId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convQxPrjMenus.MenuId); 
List<clsvQxPrjMenusEN> arrObjLst = clsvQxPrjMenusWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvQxPrjMenusEN objvQxPrjMenusEN = new clsvQxPrjMenusEN()
{
MenuId = "0",
MenuName = "选[v工程菜单]..."
};
arrObjLst.Insert(0, objvQxPrjMenusEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convQxPrjMenus.MenuId;
objComboBox.DisplayMember = convQxPrjMenus.MenuName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strMenuId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxPrjMenusEN GetObjByMenuId(string strMenuId)
{
string strAction = "GetObjByMenuId";
clsvQxPrjMenusEN objvQxPrjMenusEN;
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
objvQxPrjMenusEN = JsonConvert.DeserializeObject<clsvQxPrjMenusEN>(strJson);
return objvQxPrjMenusEN;
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
public static clsvQxPrjMenusEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvQxPrjMenusEN objvQxPrjMenusEN;
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
objvQxPrjMenusEN = JsonConvert.DeserializeObject<clsvQxPrjMenusEN>(strJson);
return objvQxPrjMenusEN;
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
//该表没有使用Cache,不需要生成[GetMenuNameByMenuIdCache]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjMenusEN> GetObjLst(string strWhereCond)
{
 List<clsvQxPrjMenusEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjMenusEN>>(strJson);
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
public static List<clsvQxPrjMenusEN> GetObjLstByMenuIdLst(List<string> arrMenuId)
{
 List<clsvQxPrjMenusEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjMenusEN>>(strJson);
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
public static List<clsvQxPrjMenusEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvQxPrjMenusEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjMenusEN>>(strJson);
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
public static List<clsvQxPrjMenusEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvQxPrjMenusEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjMenusEN>>(strJson);
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
public static List<clsvQxPrjMenusEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvQxPrjMenusEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjMenusEN>>(strJson);
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
public static List<clsvQxPrjMenusEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvQxPrjMenusEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjMenusEN>>(strJson);
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objvQxPrjMenusENS">源对象</param>
 /// <param name = "objvQxPrjMenusENT">目标对象</param>
 public static void CopyTo(clsvQxPrjMenusEN objvQxPrjMenusENS, clsvQxPrjMenusEN objvQxPrjMenusENT)
{
try
{
objvQxPrjMenusENT.MenuId = objvQxPrjMenusENS.MenuId; //菜单Id
objvQxPrjMenusENT.MenuName = objvQxPrjMenusENS.MenuName; //菜单名
objvQxPrjMenusENT.QxPrjId = objvQxPrjMenusENS.QxPrjId; //项目Id
objvQxPrjMenusENT.PrjName = objvQxPrjMenusENS.PrjName; //工程名
objvQxPrjMenusENT.UpMenuId = objvQxPrjMenusENS.UpMenuId; //上级菜单Id
objvQxPrjMenusENT.LinkFile = objvQxPrjMenusENS.LinkFile; //链接文件
objvQxPrjMenusENT.qsParameters = objvQxPrjMenusENS.qsParameters; //qs参数
objvQxPrjMenusENT.TabId = objvQxPrjMenusENS.TabId; //表ID
objvQxPrjMenusENT.TabName = objvQxPrjMenusENS.TabName; //TabName
objvQxPrjMenusENT.ImgFile = objvQxPrjMenusENS.ImgFile; //图像文件
objvQxPrjMenusENT.RoleId = objvQxPrjMenusENS.RoleId; //角色Id
objvQxPrjMenusENT.RoleName = objvQxPrjMenusENS.RoleName; //角色名称
objvQxPrjMenusENT.OrderNum = objvQxPrjMenusENS.OrderNum; //排序号
objvQxPrjMenusENT.IsLeafNode = objvQxPrjMenusENS.IsLeafNode; //是否叶子
objvQxPrjMenusENT.MenuSetId = objvQxPrjMenusENS.MenuSetId; //菜单集Id
objvQxPrjMenusENT.MenuSetName = objvQxPrjMenusENS.MenuSetName; //菜单集名称
objvQxPrjMenusENT.MenuTitle = objvQxPrjMenusENS.MenuTitle; //菜单标题
objvQxPrjMenusENT.PageDispModeId = objvQxPrjMenusENS.PageDispModeId; //页面显示模式Id
objvQxPrjMenusENT.PageDispModeName = objvQxPrjMenusENS.PageDispModeName; //页面显示模式名称
objvQxPrjMenusENT.InUse = objvQxPrjMenusENS.InUse; //是否在用
objvQxPrjMenusENT.MenuControlName = objvQxPrjMenusENS.MenuControlName; //MenuControlName
objvQxPrjMenusENT.ApplicationTypeId = objvQxPrjMenusENS.ApplicationTypeId; //应用程序类型ID
objvQxPrjMenusENT.ApplicationTypeName = objvQxPrjMenusENS.ApplicationTypeName; //应用程序类型名称
objvQxPrjMenusENT.UpdDate = objvQxPrjMenusENS.UpdDate; //修改日期
objvQxPrjMenusENT.UpdUserId = objvQxPrjMenusENS.UpdUserId; //修改用户Id
objvQxPrjMenusENT.Memo = objvQxPrjMenusENS.Memo; //备注
objvQxPrjMenusENT.UpMenuName = objvQxPrjMenusENS.UpMenuName; //上级菜单名
objvQxPrjMenusENT.SubMenusNum = objvQxPrjMenusENS.SubMenusNum; //子菜单数
objvQxPrjMenusENT.RoleNum = objvQxPrjMenusENS.RoleNum; //角色数
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
public static DataTable ToDataTable(List<clsvQxPrjMenusEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvQxPrjMenusEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvQxPrjMenusEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvQxPrjMenusEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvQxPrjMenusEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvQxPrjMenusEN.AttributeName)
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
string strKey = string.Format("{0}", clsvQxPrjMenusEN._CurrTabName);
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
public static DataTable GetDataTableByObjLst(List<clsvQxPrjMenusEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convQxPrjMenus.MenuId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus.MenuName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus.QxPrjId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus.UpMenuId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus.LinkFile, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus.qsParameters, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus.TabId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus.TabName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus.ImgFile, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus.RoleId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus.RoleName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convQxPrjMenus.IsLeafNode, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQxPrjMenus.MenuSetId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus.MenuSetName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus.MenuTitle, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus.PageDispModeId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus.PageDispModeName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQxPrjMenus.MenuControlName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus.ApplicationTypeId, Type.GetType("System.Int32"));
objDT.Columns.Add(convQxPrjMenus.ApplicationTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus.UpMenuName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus.SubMenusNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convQxPrjMenus.RoleNum, Type.GetType("System.Int32"));
foreach (clsvQxPrjMenusEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convQxPrjMenus.MenuId] = objInFor[convQxPrjMenus.MenuId];
objDR[convQxPrjMenus.MenuName] = objInFor[convQxPrjMenus.MenuName];
objDR[convQxPrjMenus.QxPrjId] = objInFor[convQxPrjMenus.QxPrjId];
objDR[convQxPrjMenus.PrjName] = objInFor[convQxPrjMenus.PrjName];
objDR[convQxPrjMenus.UpMenuId] = objInFor[convQxPrjMenus.UpMenuId];
objDR[convQxPrjMenus.LinkFile] = objInFor[convQxPrjMenus.LinkFile];
objDR[convQxPrjMenus.qsParameters] = objInFor[convQxPrjMenus.qsParameters];
objDR[convQxPrjMenus.TabId] = objInFor[convQxPrjMenus.TabId];
objDR[convQxPrjMenus.TabName] = objInFor[convQxPrjMenus.TabName];
objDR[convQxPrjMenus.ImgFile] = objInFor[convQxPrjMenus.ImgFile];
objDR[convQxPrjMenus.RoleId] = objInFor[convQxPrjMenus.RoleId];
objDR[convQxPrjMenus.RoleName] = objInFor[convQxPrjMenus.RoleName];
objDR[convQxPrjMenus.OrderNum] = objInFor[convQxPrjMenus.OrderNum];
objDR[convQxPrjMenus.IsLeafNode] = objInFor[convQxPrjMenus.IsLeafNode];
objDR[convQxPrjMenus.MenuSetId] = objInFor[convQxPrjMenus.MenuSetId];
objDR[convQxPrjMenus.MenuSetName] = objInFor[convQxPrjMenus.MenuSetName];
objDR[convQxPrjMenus.MenuTitle] = objInFor[convQxPrjMenus.MenuTitle];
objDR[convQxPrjMenus.PageDispModeId] = objInFor[convQxPrjMenus.PageDispModeId];
objDR[convQxPrjMenus.PageDispModeName] = objInFor[convQxPrjMenus.PageDispModeName];
objDR[convQxPrjMenus.InUse] = objInFor[convQxPrjMenus.InUse];
objDR[convQxPrjMenus.MenuControlName] = objInFor[convQxPrjMenus.MenuControlName];
objDR[convQxPrjMenus.ApplicationTypeId] = objInFor[convQxPrjMenus.ApplicationTypeId];
objDR[convQxPrjMenus.ApplicationTypeName] = objInFor[convQxPrjMenus.ApplicationTypeName];
objDR[convQxPrjMenus.UpdDate] = objInFor[convQxPrjMenus.UpdDate];
objDR[convQxPrjMenus.UpdUserId] = objInFor[convQxPrjMenus.UpdUserId];
objDR[convQxPrjMenus.Memo] = objInFor[convQxPrjMenus.Memo];
objDR[convQxPrjMenus.UpMenuName] = objInFor[convQxPrjMenus.UpMenuName];
objDR[convQxPrjMenus.SubMenusNum] = objInFor[convQxPrjMenus.SubMenusNum];
objDR[convQxPrjMenus.RoleNum] = objInFor[convQxPrjMenus.RoleNum];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}