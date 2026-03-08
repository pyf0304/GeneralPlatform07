
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxRoleMenusWApi
 表名:vQxRoleMenus(00140034)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 18:31:21
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
public static class  clsvQxRoleMenusWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">流水号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenusEN SetmId(this clsvQxRoleMenusEN objvQxRoleMenusEN, long lngmId, string strComparisonOp="")
	{
objvQxRoleMenusEN.mId = lngmId; //流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRoleMenusEN.dicFldComparisonOp.ContainsKey(convQxRoleMenus.mId) == false)
{
objvQxRoleMenusEN.dicFldComparisonOp.Add(convQxRoleMenus.mId, strComparisonOp);
}
else
{
objvQxRoleMenusEN.dicFldComparisonOp[convQxRoleMenus.mId] = strComparisonOp;
}
}
return objvQxRoleMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strRoleId">角色Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenusEN SetRoleId(this clsvQxRoleMenusEN objvQxRoleMenusEN, string strRoleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRoleId, 8, convQxRoleMenus.RoleId);
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, convQxRoleMenus.RoleId);
objvQxRoleMenusEN.RoleId = strRoleId; //角色Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRoleMenusEN.dicFldComparisonOp.ContainsKey(convQxRoleMenus.RoleId) == false)
{
objvQxRoleMenusEN.dicFldComparisonOp.Add(convQxRoleMenus.RoleId, strComparisonOp);
}
else
{
objvQxRoleMenusEN.dicFldComparisonOp[convQxRoleMenus.RoleId] = strComparisonOp;
}
}
return objvQxRoleMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strRoleName">角色名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenusEN SetRoleName(this clsvQxRoleMenusEN objvQxRoleMenusEN, string strRoleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRoleName, convQxRoleMenus.RoleName);
clsCheckSql.CheckFieldLen(strRoleName, 50, convQxRoleMenus.RoleName);
objvQxRoleMenusEN.RoleName = strRoleName; //角色名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRoleMenusEN.dicFldComparisonOp.ContainsKey(convQxRoleMenus.RoleName) == false)
{
objvQxRoleMenusEN.dicFldComparisonOp.Add(convQxRoleMenus.RoleName, strComparisonOp);
}
else
{
objvQxRoleMenusEN.dicFldComparisonOp[convQxRoleMenus.RoleName] = strComparisonOp;
}
}
return objvQxRoleMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strQxPrjId">项目Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenusEN SetQxPrjId(this clsvQxRoleMenusEN objvQxRoleMenusEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, convQxRoleMenus.QxPrjId);
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxRoleMenus.QxPrjId);
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxRoleMenus.QxPrjId);
objvQxRoleMenusEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRoleMenusEN.dicFldComparisonOp.ContainsKey(convQxRoleMenus.QxPrjId) == false)
{
objvQxRoleMenusEN.dicFldComparisonOp.Add(convQxRoleMenus.QxPrjId, strComparisonOp);
}
else
{
objvQxRoleMenusEN.dicFldComparisonOp[convQxRoleMenus.QxPrjId] = strComparisonOp;
}
}
return objvQxRoleMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strMenuId">菜单Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenusEN SetMenuId(this clsvQxRoleMenusEN objvQxRoleMenusEN, string strMenuId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMenuId, convQxRoleMenus.MenuId);
clsCheckSql.CheckFieldLen(strMenuId, 8, convQxRoleMenus.MenuId);
clsCheckSql.CheckFieldForeignKey(strMenuId, 8, convQxRoleMenus.MenuId);
objvQxRoleMenusEN.MenuId = strMenuId; //菜单Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRoleMenusEN.dicFldComparisonOp.ContainsKey(convQxRoleMenus.MenuId) == false)
{
objvQxRoleMenusEN.dicFldComparisonOp.Add(convQxRoleMenus.MenuId, strComparisonOp);
}
else
{
objvQxRoleMenusEN.dicFldComparisonOp[convQxRoleMenus.MenuId] = strComparisonOp;
}
}
return objvQxRoleMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strMenuName">菜单名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenusEN SetMenuName(this clsvQxRoleMenusEN objvQxRoleMenusEN, string strMenuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMenuName, convQxRoleMenus.MenuName);
clsCheckSql.CheckFieldLen(strMenuName, 50, convQxRoleMenus.MenuName);
objvQxRoleMenusEN.MenuName = strMenuName; //菜单名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRoleMenusEN.dicFldComparisonOp.ContainsKey(convQxRoleMenus.MenuName) == false)
{
objvQxRoleMenusEN.dicFldComparisonOp.Add(convQxRoleMenus.MenuName, strComparisonOp);
}
else
{
objvQxRoleMenusEN.dicFldComparisonOp[convQxRoleMenus.MenuName] = strComparisonOp;
}
}
return objvQxRoleMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenusEN SetPrjName(this clsvQxRoleMenusEN objvQxRoleMenusEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjName, 30, convQxRoleMenus.PrjName);
objvQxRoleMenusEN.PrjName = strPrjName; //工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRoleMenusEN.dicFldComparisonOp.ContainsKey(convQxRoleMenus.PrjName) == false)
{
objvQxRoleMenusEN.dicFldComparisonOp.Add(convQxRoleMenus.PrjName, strComparisonOp);
}
else
{
objvQxRoleMenusEN.dicFldComparisonOp[convQxRoleMenus.PrjName] = strComparisonOp;
}
}
return objvQxRoleMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpMenuId">上级菜单Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenusEN SetUpMenuId(this clsvQxRoleMenusEN objvQxRoleMenusEN, string strUpMenuId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpMenuId, 8, convQxRoleMenus.UpMenuId);
clsCheckSql.CheckFieldForeignKey(strUpMenuId, 8, convQxRoleMenus.UpMenuId);
objvQxRoleMenusEN.UpMenuId = strUpMenuId; //上级菜单Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRoleMenusEN.dicFldComparisonOp.ContainsKey(convQxRoleMenus.UpMenuId) == false)
{
objvQxRoleMenusEN.dicFldComparisonOp.Add(convQxRoleMenus.UpMenuId, strComparisonOp);
}
else
{
objvQxRoleMenusEN.dicFldComparisonOp[convQxRoleMenus.UpMenuId] = strComparisonOp;
}
}
return objvQxRoleMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strLinkFile">链接文件</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenusEN SetLinkFile(this clsvQxRoleMenusEN objvQxRoleMenusEN, string strLinkFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLinkFile, 500, convQxRoleMenus.LinkFile);
objvQxRoleMenusEN.LinkFile = strLinkFile; //链接文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRoleMenusEN.dicFldComparisonOp.ContainsKey(convQxRoleMenus.LinkFile) == false)
{
objvQxRoleMenusEN.dicFldComparisonOp.Add(convQxRoleMenus.LinkFile, strComparisonOp);
}
else
{
objvQxRoleMenusEN.dicFldComparisonOp[convQxRoleMenus.LinkFile] = strComparisonOp;
}
}
return objvQxRoleMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strqsParameters">qs参数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenusEN SetqsParameters(this clsvQxRoleMenusEN objvQxRoleMenusEN, string strqsParameters, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strqsParameters, 200, convQxRoleMenus.qsParameters);
objvQxRoleMenusEN.qsParameters = strqsParameters; //qs参数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRoleMenusEN.dicFldComparisonOp.ContainsKey(convQxRoleMenus.qsParameters) == false)
{
objvQxRoleMenusEN.dicFldComparisonOp.Add(convQxRoleMenus.qsParameters, strComparisonOp);
}
else
{
objvQxRoleMenusEN.dicFldComparisonOp[convQxRoleMenus.qsParameters] = strComparisonOp;
}
}
return objvQxRoleMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strImgFile">图像文件</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenusEN SetImgFile(this clsvQxRoleMenusEN objvQxRoleMenusEN, string strImgFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strImgFile, 300, convQxRoleMenus.ImgFile);
objvQxRoleMenusEN.ImgFile = strImgFile; //图像文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRoleMenusEN.dicFldComparisonOp.ContainsKey(convQxRoleMenus.ImgFile) == false)
{
objvQxRoleMenusEN.dicFldComparisonOp.Add(convQxRoleMenus.ImgFile, strComparisonOp);
}
else
{
objvQxRoleMenusEN.dicFldComparisonOp[convQxRoleMenus.ImgFile] = strComparisonOp;
}
}
return objvQxRoleMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">排序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenusEN SetOrderNum(this clsvQxRoleMenusEN objvQxRoleMenusEN, int intOrderNum, string strComparisonOp="")
	{
objvQxRoleMenusEN.OrderNum = intOrderNum; //排序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRoleMenusEN.dicFldComparisonOp.ContainsKey(convQxRoleMenus.OrderNum) == false)
{
objvQxRoleMenusEN.dicFldComparisonOp.Add(convQxRoleMenus.OrderNum, strComparisonOp);
}
else
{
objvQxRoleMenusEN.dicFldComparisonOp[convQxRoleMenus.OrderNum] = strComparisonOp;
}
}
return objvQxRoleMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsLeafNode">是否叶子</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenusEN SetIsLeafNode(this clsvQxRoleMenusEN objvQxRoleMenusEN, bool bolIsLeafNode, string strComparisonOp="")
	{
objvQxRoleMenusEN.IsLeafNode = bolIsLeafNode; //是否叶子
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRoleMenusEN.dicFldComparisonOp.ContainsKey(convQxRoleMenus.IsLeafNode) == false)
{
objvQxRoleMenusEN.dicFldComparisonOp.Add(convQxRoleMenus.IsLeafNode, strComparisonOp);
}
else
{
objvQxRoleMenusEN.dicFldComparisonOp[convQxRoleMenus.IsLeafNode] = strComparisonOp;
}
}
return objvQxRoleMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strMenuSetId">菜单集Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenusEN SetMenuSetId(this clsvQxRoleMenusEN objvQxRoleMenusEN, string strMenuSetId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMenuSetId, 4, convQxRoleMenus.MenuSetId);
clsCheckSql.CheckFieldForeignKey(strMenuSetId, 4, convQxRoleMenus.MenuSetId);
objvQxRoleMenusEN.MenuSetId = strMenuSetId; //菜单集Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRoleMenusEN.dicFldComparisonOp.ContainsKey(convQxRoleMenus.MenuSetId) == false)
{
objvQxRoleMenusEN.dicFldComparisonOp.Add(convQxRoleMenus.MenuSetId, strComparisonOp);
}
else
{
objvQxRoleMenusEN.dicFldComparisonOp[convQxRoleMenus.MenuSetId] = strComparisonOp;
}
}
return objvQxRoleMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strMenuSetName">菜单集名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenusEN SetMenuSetName(this clsvQxRoleMenusEN objvQxRoleMenusEN, string strMenuSetName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMenuSetName, 50, convQxRoleMenus.MenuSetName);
objvQxRoleMenusEN.MenuSetName = strMenuSetName; //菜单集名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRoleMenusEN.dicFldComparisonOp.ContainsKey(convQxRoleMenus.MenuSetName) == false)
{
objvQxRoleMenusEN.dicFldComparisonOp.Add(convQxRoleMenus.MenuSetName, strComparisonOp);
}
else
{
objvQxRoleMenusEN.dicFldComparisonOp[convQxRoleMenus.MenuSetName] = strComparisonOp;
}
}
return objvQxRoleMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strMenuTitle">菜单标题</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenusEN SetMenuTitle(this clsvQxRoleMenusEN objvQxRoleMenusEN, string strMenuTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMenuTitle, 50, convQxRoleMenus.MenuTitle);
objvQxRoleMenusEN.MenuTitle = strMenuTitle; //菜单标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRoleMenusEN.dicFldComparisonOp.ContainsKey(convQxRoleMenus.MenuTitle) == false)
{
objvQxRoleMenusEN.dicFldComparisonOp.Add(convQxRoleMenus.MenuTitle, strComparisonOp);
}
else
{
objvQxRoleMenusEN.dicFldComparisonOp[convQxRoleMenus.MenuTitle] = strComparisonOp;
}
}
return objvQxRoleMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strPageDispModeId">页面显示模式Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenusEN SetPageDispModeId(this clsvQxRoleMenusEN objvQxRoleMenusEN, string strPageDispModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPageDispModeId, 2, convQxRoleMenus.PageDispModeId);
clsCheckSql.CheckFieldForeignKey(strPageDispModeId, 2, convQxRoleMenus.PageDispModeId);
objvQxRoleMenusEN.PageDispModeId = strPageDispModeId; //页面显示模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRoleMenusEN.dicFldComparisonOp.ContainsKey(convQxRoleMenus.PageDispModeId) == false)
{
objvQxRoleMenusEN.dicFldComparisonOp.Add(convQxRoleMenus.PageDispModeId, strComparisonOp);
}
else
{
objvQxRoleMenusEN.dicFldComparisonOp[convQxRoleMenus.PageDispModeId] = strComparisonOp;
}
}
return objvQxRoleMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strPageDispModeName">页面显示模式名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenusEN SetPageDispModeName(this clsvQxRoleMenusEN objvQxRoleMenusEN, string strPageDispModeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPageDispModeName, 50, convQxRoleMenus.PageDispModeName);
objvQxRoleMenusEN.PageDispModeName = strPageDispModeName; //页面显示模式名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRoleMenusEN.dicFldComparisonOp.ContainsKey(convQxRoleMenus.PageDispModeName) == false)
{
objvQxRoleMenusEN.dicFldComparisonOp.Add(convQxRoleMenus.PageDispModeName, strComparisonOp);
}
else
{
objvQxRoleMenusEN.dicFldComparisonOp[convQxRoleMenus.PageDispModeName] = strComparisonOp;
}
}
return objvQxRoleMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenusEN SetInUse(this clsvQxRoleMenusEN objvQxRoleMenusEN, bool bolInUse, string strComparisonOp="")
	{
objvQxRoleMenusEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRoleMenusEN.dicFldComparisonOp.ContainsKey(convQxRoleMenus.InUse) == false)
{
objvQxRoleMenusEN.dicFldComparisonOp.Add(convQxRoleMenus.InUse, strComparisonOp);
}
else
{
objvQxRoleMenusEN.dicFldComparisonOp[convQxRoleMenus.InUse] = strComparisonOp;
}
}
return objvQxRoleMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpMenuName">上级菜单名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenusEN SetUpMenuName(this clsvQxRoleMenusEN objvQxRoleMenusEN, string strUpMenuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpMenuName, 30, convQxRoleMenus.UpMenuName);
objvQxRoleMenusEN.UpMenuName = strUpMenuName; //上级菜单名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRoleMenusEN.dicFldComparisonOp.ContainsKey(convQxRoleMenus.UpMenuName) == false)
{
objvQxRoleMenusEN.dicFldComparisonOp.Add(convQxRoleMenus.UpMenuName, strComparisonOp);
}
else
{
objvQxRoleMenusEN.dicFldComparisonOp[convQxRoleMenus.UpMenuName] = strComparisonOp;
}
}
return objvQxRoleMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "intRoleNum">角色数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenusEN SetRoleNum(this clsvQxRoleMenusEN objvQxRoleMenusEN, int intRoleNum, string strComparisonOp="")
	{
objvQxRoleMenusEN.RoleNum = intRoleNum; //角色数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRoleMenusEN.dicFldComparisonOp.ContainsKey(convQxRoleMenus.RoleNum) == false)
{
objvQxRoleMenusEN.dicFldComparisonOp.Add(convQxRoleMenus.RoleNum, strComparisonOp);
}
else
{
objvQxRoleMenusEN.dicFldComparisonOp[convQxRoleMenus.RoleNum] = strComparisonOp;
}
}
return objvQxRoleMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsDisp">是否显示</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenusEN SetIsDisp(this clsvQxRoleMenusEN objvQxRoleMenusEN, bool bolIsDisp, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsDisp, convQxRoleMenus.IsDisp);
objvQxRoleMenusEN.IsDisp = bolIsDisp; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRoleMenusEN.dicFldComparisonOp.ContainsKey(convQxRoleMenus.IsDisp) == false)
{
objvQxRoleMenusEN.dicFldComparisonOp.Add(convQxRoleMenus.IsDisp, strComparisonOp);
}
else
{
objvQxRoleMenusEN.dicFldComparisonOp[convQxRoleMenus.IsDisp] = strComparisonOp;
}
}
return objvQxRoleMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenusEN SetUpdDate(this clsvQxRoleMenusEN objvQxRoleMenusEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convQxRoleMenus.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQxRoleMenus.UpdDate);
objvQxRoleMenusEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRoleMenusEN.dicFldComparisonOp.ContainsKey(convQxRoleMenus.UpdDate) == false)
{
objvQxRoleMenusEN.dicFldComparisonOp.Add(convQxRoleMenus.UpdDate, strComparisonOp);
}
else
{
objvQxRoleMenusEN.dicFldComparisonOp[convQxRoleMenus.UpdDate] = strComparisonOp;
}
}
return objvQxRoleMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenusEN SetUpdUserId(this clsvQxRoleMenusEN objvQxRoleMenusEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUserId, convQxRoleMenus.UpdUserId);
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convQxRoleMenus.UpdUserId);
objvQxRoleMenusEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRoleMenusEN.dicFldComparisonOp.ContainsKey(convQxRoleMenus.UpdUserId) == false)
{
objvQxRoleMenusEN.dicFldComparisonOp.Add(convQxRoleMenus.UpdUserId, strComparisonOp);
}
else
{
objvQxRoleMenusEN.dicFldComparisonOp[convQxRoleMenus.UpdUserId] = strComparisonOp;
}
}
return objvQxRoleMenusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">备注</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenusEN SetMemo(this clsvQxRoleMenusEN objvQxRoleMenusEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxRoleMenus.Memo);
objvQxRoleMenusEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRoleMenusEN.dicFldComparisonOp.ContainsKey(convQxRoleMenus.Memo) == false)
{
objvQxRoleMenusEN.dicFldComparisonOp.Add(convQxRoleMenus.Memo, strComparisonOp);
}
else
{
objvQxRoleMenusEN.dicFldComparisonOp[convQxRoleMenus.Memo] = strComparisonOp;
}
}
return objvQxRoleMenusEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQxRoleMenusEN objvQxRoleMenusCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQxRoleMenusCond.IsUpdated(convQxRoleMenus.mId) == true)
{
string strComparisonOpmId = objvQxRoleMenusCond.dicFldComparisonOp[convQxRoleMenus.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convQxRoleMenus.mId, objvQxRoleMenusCond.mId, strComparisonOpmId);
}
if (objvQxRoleMenusCond.IsUpdated(convQxRoleMenus.RoleId) == true)
{
string strComparisonOpRoleId = objvQxRoleMenusCond.dicFldComparisonOp[convQxRoleMenus.RoleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRoleMenus.RoleId, objvQxRoleMenusCond.RoleId, strComparisonOpRoleId);
}
if (objvQxRoleMenusCond.IsUpdated(convQxRoleMenus.RoleName) == true)
{
string strComparisonOpRoleName = objvQxRoleMenusCond.dicFldComparisonOp[convQxRoleMenus.RoleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRoleMenus.RoleName, objvQxRoleMenusCond.RoleName, strComparisonOpRoleName);
}
if (objvQxRoleMenusCond.IsUpdated(convQxRoleMenus.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objvQxRoleMenusCond.dicFldComparisonOp[convQxRoleMenus.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRoleMenus.QxPrjId, objvQxRoleMenusCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objvQxRoleMenusCond.IsUpdated(convQxRoleMenus.MenuId) == true)
{
string strComparisonOpMenuId = objvQxRoleMenusCond.dicFldComparisonOp[convQxRoleMenus.MenuId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRoleMenus.MenuId, objvQxRoleMenusCond.MenuId, strComparisonOpMenuId);
}
if (objvQxRoleMenusCond.IsUpdated(convQxRoleMenus.MenuName) == true)
{
string strComparisonOpMenuName = objvQxRoleMenusCond.dicFldComparisonOp[convQxRoleMenus.MenuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRoleMenus.MenuName, objvQxRoleMenusCond.MenuName, strComparisonOpMenuName);
}
if (objvQxRoleMenusCond.IsUpdated(convQxRoleMenus.PrjName) == true)
{
string strComparisonOpPrjName = objvQxRoleMenusCond.dicFldComparisonOp[convQxRoleMenus.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRoleMenus.PrjName, objvQxRoleMenusCond.PrjName, strComparisonOpPrjName);
}
if (objvQxRoleMenusCond.IsUpdated(convQxRoleMenus.UpMenuId) == true)
{
string strComparisonOpUpMenuId = objvQxRoleMenusCond.dicFldComparisonOp[convQxRoleMenus.UpMenuId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRoleMenus.UpMenuId, objvQxRoleMenusCond.UpMenuId, strComparisonOpUpMenuId);
}
if (objvQxRoleMenusCond.IsUpdated(convQxRoleMenus.LinkFile) == true)
{
string strComparisonOpLinkFile = objvQxRoleMenusCond.dicFldComparisonOp[convQxRoleMenus.LinkFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRoleMenus.LinkFile, objvQxRoleMenusCond.LinkFile, strComparisonOpLinkFile);
}
if (objvQxRoleMenusCond.IsUpdated(convQxRoleMenus.qsParameters) == true)
{
string strComparisonOpqsParameters = objvQxRoleMenusCond.dicFldComparisonOp[convQxRoleMenus.qsParameters];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRoleMenus.qsParameters, objvQxRoleMenusCond.qsParameters, strComparisonOpqsParameters);
}
if (objvQxRoleMenusCond.IsUpdated(convQxRoleMenus.ImgFile) == true)
{
string strComparisonOpImgFile = objvQxRoleMenusCond.dicFldComparisonOp[convQxRoleMenus.ImgFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRoleMenus.ImgFile, objvQxRoleMenusCond.ImgFile, strComparisonOpImgFile);
}
if (objvQxRoleMenusCond.IsUpdated(convQxRoleMenus.OrderNum) == true)
{
string strComparisonOpOrderNum = objvQxRoleMenusCond.dicFldComparisonOp[convQxRoleMenus.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQxRoleMenus.OrderNum, objvQxRoleMenusCond.OrderNum, strComparisonOpOrderNum);
}
if (objvQxRoleMenusCond.IsUpdated(convQxRoleMenus.IsLeafNode) == true)
{
if (objvQxRoleMenusCond.IsLeafNode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQxRoleMenus.IsLeafNode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQxRoleMenus.IsLeafNode);
}
}
if (objvQxRoleMenusCond.IsUpdated(convQxRoleMenus.MenuSetId) == true)
{
string strComparisonOpMenuSetId = objvQxRoleMenusCond.dicFldComparisonOp[convQxRoleMenus.MenuSetId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRoleMenus.MenuSetId, objvQxRoleMenusCond.MenuSetId, strComparisonOpMenuSetId);
}
if (objvQxRoleMenusCond.IsUpdated(convQxRoleMenus.MenuSetName) == true)
{
string strComparisonOpMenuSetName = objvQxRoleMenusCond.dicFldComparisonOp[convQxRoleMenus.MenuSetName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRoleMenus.MenuSetName, objvQxRoleMenusCond.MenuSetName, strComparisonOpMenuSetName);
}
if (objvQxRoleMenusCond.IsUpdated(convQxRoleMenus.MenuTitle) == true)
{
string strComparisonOpMenuTitle = objvQxRoleMenusCond.dicFldComparisonOp[convQxRoleMenus.MenuTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRoleMenus.MenuTitle, objvQxRoleMenusCond.MenuTitle, strComparisonOpMenuTitle);
}
if (objvQxRoleMenusCond.IsUpdated(convQxRoleMenus.PageDispModeId) == true)
{
string strComparisonOpPageDispModeId = objvQxRoleMenusCond.dicFldComparisonOp[convQxRoleMenus.PageDispModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRoleMenus.PageDispModeId, objvQxRoleMenusCond.PageDispModeId, strComparisonOpPageDispModeId);
}
if (objvQxRoleMenusCond.IsUpdated(convQxRoleMenus.PageDispModeName) == true)
{
string strComparisonOpPageDispModeName = objvQxRoleMenusCond.dicFldComparisonOp[convQxRoleMenus.PageDispModeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRoleMenus.PageDispModeName, objvQxRoleMenusCond.PageDispModeName, strComparisonOpPageDispModeName);
}
if (objvQxRoleMenusCond.IsUpdated(convQxRoleMenus.InUse) == true)
{
if (objvQxRoleMenusCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQxRoleMenus.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQxRoleMenus.InUse);
}
}
if (objvQxRoleMenusCond.IsUpdated(convQxRoleMenus.UpMenuName) == true)
{
string strComparisonOpUpMenuName = objvQxRoleMenusCond.dicFldComparisonOp[convQxRoleMenus.UpMenuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRoleMenus.UpMenuName, objvQxRoleMenusCond.UpMenuName, strComparisonOpUpMenuName);
}
if (objvQxRoleMenusCond.IsUpdated(convQxRoleMenus.RoleNum) == true)
{
string strComparisonOpRoleNum = objvQxRoleMenusCond.dicFldComparisonOp[convQxRoleMenus.RoleNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQxRoleMenus.RoleNum, objvQxRoleMenusCond.RoleNum, strComparisonOpRoleNum);
}
if (objvQxRoleMenusCond.IsUpdated(convQxRoleMenus.IsDisp) == true)
{
if (objvQxRoleMenusCond.IsDisp == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQxRoleMenus.IsDisp);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQxRoleMenus.IsDisp);
}
}
if (objvQxRoleMenusCond.IsUpdated(convQxRoleMenus.UpdDate) == true)
{
string strComparisonOpUpdDate = objvQxRoleMenusCond.dicFldComparisonOp[convQxRoleMenus.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRoleMenus.UpdDate, objvQxRoleMenusCond.UpdDate, strComparisonOpUpdDate);
}
if (objvQxRoleMenusCond.IsUpdated(convQxRoleMenus.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvQxRoleMenusCond.dicFldComparisonOp[convQxRoleMenus.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRoleMenus.UpdUserId, objvQxRoleMenusCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvQxRoleMenusCond.IsUpdated(convQxRoleMenus.Memo) == true)
{
string strComparisonOpMemo = objvQxRoleMenusCond.dicFldComparisonOp[convQxRoleMenus.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRoleMenus.Memo, objvQxRoleMenusCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v角色菜单(vQxRoleMenus)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxRoleMenusWApi
{
private static readonly string mstrApiControllerName = "vQxRoleMenusApi";

 public clsvQxRoleMenusWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxRoleMenusEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
clsvQxRoleMenusEN objvQxRoleMenusEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngmId"] = lngmId.ToString(),
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvQxRoleMenusEN = JsonConvert.DeserializeObject<clsvQxRoleMenusEN>(strJson);
return objvQxRoleMenusEN;
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
public static long GetFirstID(string strWhereCond)
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
return long.Parse(strReturnStr);
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
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsvQxRoleMenusEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvQxRoleMenusEN objvQxRoleMenusEN;
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
objvQxRoleMenusEN = JsonConvert.DeserializeObject<clsvQxRoleMenusEN>(strJson);
return objvQxRoleMenusEN;
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

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxRoleMenusEN> GetObjLst(string strWhereCond)
{
 List<clsvQxRoleMenusEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxRoleMenusEN>>(strJson);
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
 /// <param name = "arrMId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxRoleMenusEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvQxRoleMenusEN> arrObjLst; 
string strAction = "GetObjLstByMIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxRoleMenusEN>>(strJson);
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
public static List<clsvQxRoleMenusEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvQxRoleMenusEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxRoleMenusEN>>(strJson);
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
public static List<clsvQxRoleMenusEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvQxRoleMenusEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxRoleMenusEN>>(strJson);
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
public static List<clsvQxRoleMenusEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvQxRoleMenusEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxRoleMenusEN>>(strJson);
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
public static List<clsvQxRoleMenusEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvQxRoleMenusEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxRoleMenusEN>>(strJson);
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
public static bool IsExist(long lngmId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngmId"] = lngmId.ToString()
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
 /// <param name = "objvQxRoleMenusENS">源对象</param>
 /// <param name = "objvQxRoleMenusENT">目标对象</param>
 public static void CopyTo(clsvQxRoleMenusEN objvQxRoleMenusENS, clsvQxRoleMenusEN objvQxRoleMenusENT)
{
try
{
objvQxRoleMenusENT.mId = objvQxRoleMenusENS.mId; //流水号
objvQxRoleMenusENT.RoleId = objvQxRoleMenusENS.RoleId; //角色Id
objvQxRoleMenusENT.RoleName = objvQxRoleMenusENS.RoleName; //角色名称
objvQxRoleMenusENT.QxPrjId = objvQxRoleMenusENS.QxPrjId; //项目Id
objvQxRoleMenusENT.MenuId = objvQxRoleMenusENS.MenuId; //菜单Id
objvQxRoleMenusENT.MenuName = objvQxRoleMenusENS.MenuName; //菜单名
objvQxRoleMenusENT.PrjName = objvQxRoleMenusENS.PrjName; //工程名
objvQxRoleMenusENT.UpMenuId = objvQxRoleMenusENS.UpMenuId; //上级菜单Id
objvQxRoleMenusENT.LinkFile = objvQxRoleMenusENS.LinkFile; //链接文件
objvQxRoleMenusENT.qsParameters = objvQxRoleMenusENS.qsParameters; //qs参数
objvQxRoleMenusENT.ImgFile = objvQxRoleMenusENS.ImgFile; //图像文件
objvQxRoleMenusENT.OrderNum = objvQxRoleMenusENS.OrderNum; //排序号
objvQxRoleMenusENT.IsLeafNode = objvQxRoleMenusENS.IsLeafNode; //是否叶子
objvQxRoleMenusENT.MenuSetId = objvQxRoleMenusENS.MenuSetId; //菜单集Id
objvQxRoleMenusENT.MenuSetName = objvQxRoleMenusENS.MenuSetName; //菜单集名称
objvQxRoleMenusENT.MenuTitle = objvQxRoleMenusENS.MenuTitle; //菜单标题
objvQxRoleMenusENT.PageDispModeId = objvQxRoleMenusENS.PageDispModeId; //页面显示模式Id
objvQxRoleMenusENT.PageDispModeName = objvQxRoleMenusENS.PageDispModeName; //页面显示模式名称
objvQxRoleMenusENT.InUse = objvQxRoleMenusENS.InUse; //是否在用
objvQxRoleMenusENT.UpMenuName = objvQxRoleMenusENS.UpMenuName; //上级菜单名
objvQxRoleMenusENT.RoleNum = objvQxRoleMenusENS.RoleNum; //角色数
objvQxRoleMenusENT.IsDisp = objvQxRoleMenusENS.IsDisp; //是否显示
objvQxRoleMenusENT.UpdDate = objvQxRoleMenusENS.UpdDate; //修改日期
objvQxRoleMenusENT.UpdUserId = objvQxRoleMenusENS.UpdUserId; //修改用户Id
objvQxRoleMenusENT.Memo = objvQxRoleMenusENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvQxRoleMenusEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvQxRoleMenusEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvQxRoleMenusEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvQxRoleMenusEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvQxRoleMenusEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvQxRoleMenusEN.AttributeName)
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
string strKey = string.Format("{0}", clsvQxRoleMenusEN._CurrTabName);
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
public static DataTable GetDataTableByObjLst(List<clsvQxRoleMenusEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convQxRoleMenus.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convQxRoleMenus.RoleId, Type.GetType("System.String"));
objDT.Columns.Add(convQxRoleMenus.RoleName, Type.GetType("System.String"));
objDT.Columns.Add(convQxRoleMenus.QxPrjId, Type.GetType("System.String"));
objDT.Columns.Add(convQxRoleMenus.MenuId, Type.GetType("System.String"));
objDT.Columns.Add(convQxRoleMenus.MenuName, Type.GetType("System.String"));
objDT.Columns.Add(convQxRoleMenus.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convQxRoleMenus.UpMenuId, Type.GetType("System.String"));
objDT.Columns.Add(convQxRoleMenus.LinkFile, Type.GetType("System.String"));
objDT.Columns.Add(convQxRoleMenus.qsParameters, Type.GetType("System.String"));
objDT.Columns.Add(convQxRoleMenus.ImgFile, Type.GetType("System.String"));
objDT.Columns.Add(convQxRoleMenus.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convQxRoleMenus.IsLeafNode, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQxRoleMenus.MenuSetId, Type.GetType("System.String"));
objDT.Columns.Add(convQxRoleMenus.MenuSetName, Type.GetType("System.String"));
objDT.Columns.Add(convQxRoleMenus.MenuTitle, Type.GetType("System.String"));
objDT.Columns.Add(convQxRoleMenus.PageDispModeId, Type.GetType("System.String"));
objDT.Columns.Add(convQxRoleMenus.PageDispModeName, Type.GetType("System.String"));
objDT.Columns.Add(convQxRoleMenus.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQxRoleMenus.UpMenuName, Type.GetType("System.String"));
objDT.Columns.Add(convQxRoleMenus.RoleNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convQxRoleMenus.IsDisp, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQxRoleMenus.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convQxRoleMenus.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convQxRoleMenus.Memo, Type.GetType("System.String"));
foreach (clsvQxRoleMenusEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convQxRoleMenus.mId] = objInFor[convQxRoleMenus.mId];
objDR[convQxRoleMenus.RoleId] = objInFor[convQxRoleMenus.RoleId];
objDR[convQxRoleMenus.RoleName] = objInFor[convQxRoleMenus.RoleName];
objDR[convQxRoleMenus.QxPrjId] = objInFor[convQxRoleMenus.QxPrjId];
objDR[convQxRoleMenus.MenuId] = objInFor[convQxRoleMenus.MenuId];
objDR[convQxRoleMenus.MenuName] = objInFor[convQxRoleMenus.MenuName];
objDR[convQxRoleMenus.PrjName] = objInFor[convQxRoleMenus.PrjName];
objDR[convQxRoleMenus.UpMenuId] = objInFor[convQxRoleMenus.UpMenuId];
objDR[convQxRoleMenus.LinkFile] = objInFor[convQxRoleMenus.LinkFile];
objDR[convQxRoleMenus.qsParameters] = objInFor[convQxRoleMenus.qsParameters];
objDR[convQxRoleMenus.ImgFile] = objInFor[convQxRoleMenus.ImgFile];
objDR[convQxRoleMenus.OrderNum] = objInFor[convQxRoleMenus.OrderNum];
objDR[convQxRoleMenus.IsLeafNode] = objInFor[convQxRoleMenus.IsLeafNode];
objDR[convQxRoleMenus.MenuSetId] = objInFor[convQxRoleMenus.MenuSetId];
objDR[convQxRoleMenus.MenuSetName] = objInFor[convQxRoleMenus.MenuSetName];
objDR[convQxRoleMenus.MenuTitle] = objInFor[convQxRoleMenus.MenuTitle];
objDR[convQxRoleMenus.PageDispModeId] = objInFor[convQxRoleMenus.PageDispModeId];
objDR[convQxRoleMenus.PageDispModeName] = objInFor[convQxRoleMenus.PageDispModeName];
objDR[convQxRoleMenus.InUse] = objInFor[convQxRoleMenus.InUse];
objDR[convQxRoleMenus.UpMenuName] = objInFor[convQxRoleMenus.UpMenuName];
objDR[convQxRoleMenus.RoleNum] = objInFor[convQxRoleMenus.RoleNum];
objDR[convQxRoleMenus.IsDisp] = objInFor[convQxRoleMenus.IsDisp];
objDR[convQxRoleMenus.UpdDate] = objInFor[convQxRoleMenus.UpdDate];
objDR[convQxRoleMenus.UpdUserId] = objInFor[convQxRoleMenus.UpdUserId];
objDR[convQxRoleMenus.Memo] = objInFor[convQxRoleMenus.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}