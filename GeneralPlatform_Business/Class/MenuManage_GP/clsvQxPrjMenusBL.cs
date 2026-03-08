
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPrjMenusBL
 表名:vQxPrjMenus(00140046)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:33:18
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:菜单管理(MenuManage_GP)
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
public static class  clsvQxPrjMenusBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strMenuId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxPrjMenusEN GetObj(this K_MenuId_vQxPrjMenus myKey)
{
clsvQxPrjMenusEN objvQxPrjMenusEN = clsvQxPrjMenusBL.vQxPrjMenusDA.GetObjByMenuId(myKey.Value);
return objvQxPrjMenusEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetMenuId(this clsvQxPrjMenusEN objvQxPrjMenusEN, string strMenuId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuId, 8, convQxPrjMenus.MenuId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMenuId, 8, convQxPrjMenus.MenuId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetMenuName(this clsvQxPrjMenusEN objvQxPrjMenusEN, string strMenuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMenuName, convQxPrjMenus.MenuName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuName, 50, convQxPrjMenus.MenuName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetQxPrjId(this clsvQxPrjMenusEN objvQxPrjMenusEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, convQxPrjMenus.QxPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxPrjMenus.QxPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxPrjMenus.QxPrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetPrjName(this clsvQxPrjMenusEN objvQxPrjMenusEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convQxPrjMenus.PrjName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convQxPrjMenus.PrjName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetUpMenuId(this clsvQxPrjMenusEN objvQxPrjMenusEN, string strUpMenuId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpMenuId, 8, convQxPrjMenus.UpMenuId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUpMenuId, 8, convQxPrjMenus.UpMenuId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetLinkFile(this clsvQxPrjMenusEN objvQxPrjMenusEN, string strLinkFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLinkFile, 500, convQxPrjMenus.LinkFile);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetqsParameters(this clsvQxPrjMenusEN objvQxPrjMenusEN, string strqsParameters, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strqsParameters, 200, convQxPrjMenus.qsParameters);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetTabId(this clsvQxPrjMenusEN objvQxPrjMenusEN, string strTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, convQxPrjMenus.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convQxPrjMenus.TabId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetTabName(this clsvQxPrjMenusEN objvQxPrjMenusEN, string strTabName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabName, 100, convQxPrjMenus.TabName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetImgFile(this clsvQxPrjMenusEN objvQxPrjMenusEN, string strImgFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strImgFile, 300, convQxPrjMenus.ImgFile);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetRoleId(this clsvQxPrjMenusEN objvQxPrjMenusEN, string strRoleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRoleId, 8, convQxPrjMenus.RoleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, convQxPrjMenus.RoleId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetRoleName(this clsvQxPrjMenusEN objvQxPrjMenusEN, string strRoleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRoleName, convQxPrjMenus.RoleName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRoleName, 50, convQxPrjMenus.RoleName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetOrderNum(this clsvQxPrjMenusEN objvQxPrjMenusEN, int? intOrderNum, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetMenuSetId(this clsvQxPrjMenusEN objvQxPrjMenusEN, string strMenuSetId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMenuSetId, convQxPrjMenus.MenuSetId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuSetId, 4, convQxPrjMenus.MenuSetId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMenuSetId, 4, convQxPrjMenus.MenuSetId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetMenuSetName(this clsvQxPrjMenusEN objvQxPrjMenusEN, string strMenuSetName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuSetName, 50, convQxPrjMenus.MenuSetName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetMenuTitle(this clsvQxPrjMenusEN objvQxPrjMenusEN, string strMenuTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuTitle, 50, convQxPrjMenus.MenuTitle);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetPageDispModeId(this clsvQxPrjMenusEN objvQxPrjMenusEN, string strPageDispModeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPageDispModeId, 2, convQxPrjMenus.PageDispModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPageDispModeId, 2, convQxPrjMenus.PageDispModeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetPageDispModeName(this clsvQxPrjMenusEN objvQxPrjMenusEN, string strPageDispModeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPageDispModeName, 50, convQxPrjMenus.PageDispModeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetMenuControlName(this clsvQxPrjMenusEN objvQxPrjMenusEN, string strMenuControlName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuControlName, 100, convQxPrjMenus.MenuControlName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetApplicationTypeName(this clsvQxPrjMenusEN objvQxPrjMenusEN, string strApplicationTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strApplicationTypeName, 30, convQxPrjMenus.ApplicationTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetUpdDate(this clsvQxPrjMenusEN objvQxPrjMenusEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQxPrjMenus.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetUpdUserId(this clsvQxPrjMenusEN objvQxPrjMenusEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convQxPrjMenus.UpdUserId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetMemo(this clsvQxPrjMenusEN objvQxPrjMenusEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxPrjMenus.Memo);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetUpMenuName(this clsvQxPrjMenusEN objvQxPrjMenusEN, string strUpMenuName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpMenuName, 30, convQxPrjMenus.UpMenuName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetSubMenusNum(this clsvQxPrjMenusEN objvQxPrjMenusEN, int? intSubMenusNum, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenusEN SetRoleNum(this clsvQxPrjMenusEN objvQxPrjMenusEN, int? intRoleNum, string strComparisonOp="")
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvQxPrjMenusENS">源对象</param>
 /// <param name = "objvQxPrjMenusENT">目标对象</param>
 public static void CopyTo(this clsvQxPrjMenusEN objvQxPrjMenusENS, clsvQxPrjMenusEN objvQxPrjMenusENT)
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
 /// <param name = "objvQxPrjMenusENS">源对象</param>
 /// <returns>目标对象=>clsvQxPrjMenusEN:objvQxPrjMenusENT</returns>
 public static clsvQxPrjMenusEN CopyTo(this clsvQxPrjMenusEN objvQxPrjMenusENS)
{
try
{
 clsvQxPrjMenusEN objvQxPrjMenusENT = new clsvQxPrjMenusEN()
{
MenuId = objvQxPrjMenusENS.MenuId, //菜单Id
MenuName = objvQxPrjMenusENS.MenuName, //菜单名
QxPrjId = objvQxPrjMenusENS.QxPrjId, //项目Id
PrjName = objvQxPrjMenusENS.PrjName, //工程名
UpMenuId = objvQxPrjMenusENS.UpMenuId, //上级菜单Id
LinkFile = objvQxPrjMenusENS.LinkFile, //链接文件
qsParameters = objvQxPrjMenusENS.qsParameters, //qs参数
TabId = objvQxPrjMenusENS.TabId, //表ID
TabName = objvQxPrjMenusENS.TabName, //TabName
ImgFile = objvQxPrjMenusENS.ImgFile, //图像文件
RoleId = objvQxPrjMenusENS.RoleId, //角色Id
RoleName = objvQxPrjMenusENS.RoleName, //角色名称
OrderNum = objvQxPrjMenusENS.OrderNum, //排序号
IsLeafNode = objvQxPrjMenusENS.IsLeafNode, //是否叶子
MenuSetId = objvQxPrjMenusENS.MenuSetId, //菜单集Id
MenuSetName = objvQxPrjMenusENS.MenuSetName, //菜单集名称
MenuTitle = objvQxPrjMenusENS.MenuTitle, //菜单标题
PageDispModeId = objvQxPrjMenusENS.PageDispModeId, //页面显示模式Id
PageDispModeName = objvQxPrjMenusENS.PageDispModeName, //页面显示模式名称
InUse = objvQxPrjMenusENS.InUse, //是否在用
MenuControlName = objvQxPrjMenusENS.MenuControlName, //MenuControlName
ApplicationTypeId = objvQxPrjMenusENS.ApplicationTypeId, //应用程序类型ID
ApplicationTypeName = objvQxPrjMenusENS.ApplicationTypeName, //应用程序类型名称
UpdDate = objvQxPrjMenusENS.UpdDate, //修改日期
UpdUserId = objvQxPrjMenusENS.UpdUserId, //修改用户Id
Memo = objvQxPrjMenusENS.Memo, //备注
UpMenuName = objvQxPrjMenusENS.UpMenuName, //上级菜单名
SubMenusNum = objvQxPrjMenusENS.SubMenusNum, //子菜单数
RoleNum = objvQxPrjMenusENS.RoleNum, //角色数
};
 return objvQxPrjMenusENT;
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
public static void CheckProperty4Condition(this clsvQxPrjMenusEN objvQxPrjMenusEN)
{
 clsvQxPrjMenusBL.vQxPrjMenusDA.CheckProperty4Condition(objvQxPrjMenusEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vQxPrjMenus
{
public virtual bool UpdRelaTabDate(string strMenuId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v工程菜单(vQxPrjMenus)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvQxPrjMenusBL
{
public static RelatedActions_vQxPrjMenus relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "vQxPrjMenusListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "vQxPrjMenusList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsvQxPrjMenusEN> arrvQxPrjMenusObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvQxPrjMenusDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvQxPrjMenusDA vQxPrjMenusDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvQxPrjMenusDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvQxPrjMenusBL()
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
if (string.IsNullOrEmpty(clsvQxPrjMenusEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxPrjMenusEN._ConnectString);
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
objDS = vQxPrjMenusDA.GetDataSet(strWhereCond);
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
objDS = vQxPrjMenusDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = vQxPrjMenusDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_vQxPrjMenus(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQxPrjMenusDA.GetDataTable_vQxPrjMenus(strWhereCond);
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
objDT = vQxPrjMenusDA.GetDataTable(strWhereCond);
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
objDT = vQxPrjMenusDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vQxPrjMenusDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vQxPrjMenusDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vQxPrjMenusDA.GetDataTable_Top(objTopPara);
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
objDT = vQxPrjMenusDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vQxPrjMenusDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = vQxPrjMenusDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vQxPrjMenusDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = vQxPrjMenusDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = vQxPrjMenusDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = vQxPrjMenusDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = vQxPrjMenusDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
 /// <param name = "arrMenuIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvQxPrjMenusEN> GetObjLstByMenuIdLst(List<string> arrMenuIdLst)
{
List<clsvQxPrjMenusEN> arrObjLst = new List<clsvQxPrjMenusEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMenuIdLst, true);
 string strWhereCond = string.Format("MenuId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenusEN objvQxPrjMenusEN = new clsvQxPrjMenusEN();
try
{
objvQxPrjMenusEN.MenuId = objRow[convQxPrjMenus.MenuId].ToString().Trim(); //菜单Id
objvQxPrjMenusEN.MenuName = objRow[convQxPrjMenus.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenusEN.QxPrjId = objRow[convQxPrjMenus.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenusEN.PrjName = objRow[convQxPrjMenus.PrjName].ToString().Trim(); //工程名
objvQxPrjMenusEN.UpMenuId = objRow[convQxPrjMenus.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenusEN.LinkFile = objRow[convQxPrjMenus.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenusEN.qsParameters = objRow[convQxPrjMenus.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenusEN.TabId = objRow[convQxPrjMenus.TabId] == DBNull.Value ? null : objRow[convQxPrjMenus.TabId].ToString().Trim(); //表ID
objvQxPrjMenusEN.TabName = objRow[convQxPrjMenus.TabName] == DBNull.Value ? null : objRow[convQxPrjMenus.TabName].ToString().Trim(); //TabName
objvQxPrjMenusEN.ImgFile = objRow[convQxPrjMenus.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenusEN.RoleId = objRow[convQxPrjMenus.RoleId] == DBNull.Value ? null : objRow[convQxPrjMenus.RoleId].ToString().Trim(); //角色Id
objvQxPrjMenusEN.RoleName = objRow[convQxPrjMenus.RoleName].ToString().Trim(); //角色名称
objvQxPrjMenusEN.OrderNum = objRow[convQxPrjMenus.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenusEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenusEN.MenuSetId = objRow[convQxPrjMenus.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenusEN.MenuSetName = objRow[convQxPrjMenus.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenusEN.MenuTitle = objRow[convQxPrjMenus.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenusEN.PageDispModeId = objRow[convQxPrjMenus.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenusEN.PageDispModeName = objRow[convQxPrjMenus.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenusEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus.InUse].ToString().Trim()); //是否在用
objvQxPrjMenusEN.MenuControlName = objRow[convQxPrjMenus.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuControlName].ToString().Trim(); //MenuControlName
objvQxPrjMenusEN.ApplicationTypeId = Int32.Parse(objRow[convQxPrjMenus.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvQxPrjMenusEN.ApplicationTypeName = objRow[convQxPrjMenus.ApplicationTypeName] == DBNull.Value ? null : objRow[convQxPrjMenus.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvQxPrjMenusEN.UpdDate = objRow[convQxPrjMenus.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenusEN.UpdUserId = objRow[convQxPrjMenus.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenusEN.Memo = objRow[convQxPrjMenus.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus.Memo].ToString().Trim(); //备注
objvQxPrjMenusEN.UpMenuName = objRow[convQxPrjMenus.UpMenuName] == DBNull.Value ? null : objRow[convQxPrjMenus.UpMenuName].ToString().Trim(); //上级菜单名
objvQxPrjMenusEN.SubMenusNum = objRow[convQxPrjMenus.SubMenusNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus.SubMenusNum].ToString().Trim()); //子菜单数
objvQxPrjMenusEN.RoleNum = objRow[convQxPrjMenus.RoleNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus.RoleNum].ToString().Trim()); //角色数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenusEN.MenuId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenusEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMenuIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvQxPrjMenusEN> GetObjLstByMenuIdLstCache(List<string> arrMenuIdLst)
{
string strKey = string.Format("{0}", clsvQxPrjMenusEN._CurrTabName);
List<clsvQxPrjMenusEN> arrvQxPrjMenusObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjMenusEN> arrvQxPrjMenusObjLst_Sel =
arrvQxPrjMenusObjLstCache
.Where(x => arrMenuIdLst.Contains(x.MenuId));
return arrvQxPrjMenusObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjMenusEN> GetObjLst(string strWhereCond)
{
List<clsvQxPrjMenusEN> arrObjLst = new List<clsvQxPrjMenusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenusEN objvQxPrjMenusEN = new clsvQxPrjMenusEN();
try
{
objvQxPrjMenusEN.MenuId = objRow[convQxPrjMenus.MenuId].ToString().Trim(); //菜单Id
objvQxPrjMenusEN.MenuName = objRow[convQxPrjMenus.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenusEN.QxPrjId = objRow[convQxPrjMenus.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenusEN.PrjName = objRow[convQxPrjMenus.PrjName].ToString().Trim(); //工程名
objvQxPrjMenusEN.UpMenuId = objRow[convQxPrjMenus.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenusEN.LinkFile = objRow[convQxPrjMenus.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenusEN.qsParameters = objRow[convQxPrjMenus.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenusEN.TabId = objRow[convQxPrjMenus.TabId] == DBNull.Value ? null : objRow[convQxPrjMenus.TabId].ToString().Trim(); //表ID
objvQxPrjMenusEN.TabName = objRow[convQxPrjMenus.TabName] == DBNull.Value ? null : objRow[convQxPrjMenus.TabName].ToString().Trim(); //TabName
objvQxPrjMenusEN.ImgFile = objRow[convQxPrjMenus.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenusEN.RoleId = objRow[convQxPrjMenus.RoleId] == DBNull.Value ? null : objRow[convQxPrjMenus.RoleId].ToString().Trim(); //角色Id
objvQxPrjMenusEN.RoleName = objRow[convQxPrjMenus.RoleName].ToString().Trim(); //角色名称
objvQxPrjMenusEN.OrderNum = objRow[convQxPrjMenus.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenusEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenusEN.MenuSetId = objRow[convQxPrjMenus.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenusEN.MenuSetName = objRow[convQxPrjMenus.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenusEN.MenuTitle = objRow[convQxPrjMenus.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenusEN.PageDispModeId = objRow[convQxPrjMenus.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenusEN.PageDispModeName = objRow[convQxPrjMenus.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenusEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus.InUse].ToString().Trim()); //是否在用
objvQxPrjMenusEN.MenuControlName = objRow[convQxPrjMenus.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuControlName].ToString().Trim(); //MenuControlName
objvQxPrjMenusEN.ApplicationTypeId = Int32.Parse(objRow[convQxPrjMenus.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvQxPrjMenusEN.ApplicationTypeName = objRow[convQxPrjMenus.ApplicationTypeName] == DBNull.Value ? null : objRow[convQxPrjMenus.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvQxPrjMenusEN.UpdDate = objRow[convQxPrjMenus.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenusEN.UpdUserId = objRow[convQxPrjMenus.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenusEN.Memo = objRow[convQxPrjMenus.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus.Memo].ToString().Trim(); //备注
objvQxPrjMenusEN.UpMenuName = objRow[convQxPrjMenus.UpMenuName] == DBNull.Value ? null : objRow[convQxPrjMenus.UpMenuName].ToString().Trim(); //上级菜单名
objvQxPrjMenusEN.SubMenusNum = objRow[convQxPrjMenus.SubMenusNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus.SubMenusNum].ToString().Trim()); //子菜单数
objvQxPrjMenusEN.RoleNum = objRow[convQxPrjMenus.RoleNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus.RoleNum].ToString().Trim()); //角色数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenusEN.MenuId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenusEN);
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
public static List<clsvQxPrjMenusEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQxPrjMenusEN> arrObjLst = new List<clsvQxPrjMenusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenusEN objvQxPrjMenusEN = new clsvQxPrjMenusEN();
try
{
objvQxPrjMenusEN.MenuId = objRow[convQxPrjMenus.MenuId].ToString().Trim(); //菜单Id
objvQxPrjMenusEN.MenuName = objRow[convQxPrjMenus.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenusEN.QxPrjId = objRow[convQxPrjMenus.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenusEN.PrjName = objRow[convQxPrjMenus.PrjName].ToString().Trim(); //工程名
objvQxPrjMenusEN.UpMenuId = objRow[convQxPrjMenus.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenusEN.LinkFile = objRow[convQxPrjMenus.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenusEN.qsParameters = objRow[convQxPrjMenus.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenusEN.TabId = objRow[convQxPrjMenus.TabId] == DBNull.Value ? null : objRow[convQxPrjMenus.TabId].ToString().Trim(); //表ID
objvQxPrjMenusEN.TabName = objRow[convQxPrjMenus.TabName] == DBNull.Value ? null : objRow[convQxPrjMenus.TabName].ToString().Trim(); //TabName
objvQxPrjMenusEN.ImgFile = objRow[convQxPrjMenus.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenusEN.RoleId = objRow[convQxPrjMenus.RoleId] == DBNull.Value ? null : objRow[convQxPrjMenus.RoleId].ToString().Trim(); //角色Id
objvQxPrjMenusEN.RoleName = objRow[convQxPrjMenus.RoleName].ToString().Trim(); //角色名称
objvQxPrjMenusEN.OrderNum = objRow[convQxPrjMenus.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenusEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenusEN.MenuSetId = objRow[convQxPrjMenus.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenusEN.MenuSetName = objRow[convQxPrjMenus.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenusEN.MenuTitle = objRow[convQxPrjMenus.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenusEN.PageDispModeId = objRow[convQxPrjMenus.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenusEN.PageDispModeName = objRow[convQxPrjMenus.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenusEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus.InUse].ToString().Trim()); //是否在用
objvQxPrjMenusEN.MenuControlName = objRow[convQxPrjMenus.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuControlName].ToString().Trim(); //MenuControlName
objvQxPrjMenusEN.ApplicationTypeId = Int32.Parse(objRow[convQxPrjMenus.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvQxPrjMenusEN.ApplicationTypeName = objRow[convQxPrjMenus.ApplicationTypeName] == DBNull.Value ? null : objRow[convQxPrjMenus.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvQxPrjMenusEN.UpdDate = objRow[convQxPrjMenus.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenusEN.UpdUserId = objRow[convQxPrjMenus.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenusEN.Memo = objRow[convQxPrjMenus.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus.Memo].ToString().Trim(); //备注
objvQxPrjMenusEN.UpMenuName = objRow[convQxPrjMenus.UpMenuName] == DBNull.Value ? null : objRow[convQxPrjMenus.UpMenuName].ToString().Trim(); //上级菜单名
objvQxPrjMenusEN.SubMenusNum = objRow[convQxPrjMenus.SubMenusNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus.SubMenusNum].ToString().Trim()); //子菜单数
objvQxPrjMenusEN.RoleNum = objRow[convQxPrjMenus.RoleNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus.RoleNum].ToString().Trim()); //角色数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenusEN.MenuId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenusEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvQxPrjMenusCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvQxPrjMenusEN> GetSubObjLstCache(clsvQxPrjMenusEN objvQxPrjMenusCond)
{
List<clsvQxPrjMenusEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjMenusEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxPrjMenus.AttributeName)
{
if (objvQxPrjMenusCond.IsUpdated(strFldName) == false) continue;
if (objvQxPrjMenusCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjMenusCond[strFldName].ToString());
}
else
{
if (objvQxPrjMenusCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxPrjMenusCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjMenusCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxPrjMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxPrjMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxPrjMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxPrjMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxPrjMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxPrjMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxPrjMenusCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxPrjMenusCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxPrjMenusCond[strFldName]));
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
public static List<clsvQxPrjMenusEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvQxPrjMenusEN> arrObjLst = new List<clsvQxPrjMenusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenusEN objvQxPrjMenusEN = new clsvQxPrjMenusEN();
try
{
objvQxPrjMenusEN.MenuId = objRow[convQxPrjMenus.MenuId].ToString().Trim(); //菜单Id
objvQxPrjMenusEN.MenuName = objRow[convQxPrjMenus.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenusEN.QxPrjId = objRow[convQxPrjMenus.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenusEN.PrjName = objRow[convQxPrjMenus.PrjName].ToString().Trim(); //工程名
objvQxPrjMenusEN.UpMenuId = objRow[convQxPrjMenus.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenusEN.LinkFile = objRow[convQxPrjMenus.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenusEN.qsParameters = objRow[convQxPrjMenus.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenusEN.TabId = objRow[convQxPrjMenus.TabId] == DBNull.Value ? null : objRow[convQxPrjMenus.TabId].ToString().Trim(); //表ID
objvQxPrjMenusEN.TabName = objRow[convQxPrjMenus.TabName] == DBNull.Value ? null : objRow[convQxPrjMenus.TabName].ToString().Trim(); //TabName
objvQxPrjMenusEN.ImgFile = objRow[convQxPrjMenus.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenusEN.RoleId = objRow[convQxPrjMenus.RoleId] == DBNull.Value ? null : objRow[convQxPrjMenus.RoleId].ToString().Trim(); //角色Id
objvQxPrjMenusEN.RoleName = objRow[convQxPrjMenus.RoleName].ToString().Trim(); //角色名称
objvQxPrjMenusEN.OrderNum = objRow[convQxPrjMenus.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenusEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenusEN.MenuSetId = objRow[convQxPrjMenus.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenusEN.MenuSetName = objRow[convQxPrjMenus.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenusEN.MenuTitle = objRow[convQxPrjMenus.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenusEN.PageDispModeId = objRow[convQxPrjMenus.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenusEN.PageDispModeName = objRow[convQxPrjMenus.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenusEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus.InUse].ToString().Trim()); //是否在用
objvQxPrjMenusEN.MenuControlName = objRow[convQxPrjMenus.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuControlName].ToString().Trim(); //MenuControlName
objvQxPrjMenusEN.ApplicationTypeId = Int32.Parse(objRow[convQxPrjMenus.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvQxPrjMenusEN.ApplicationTypeName = objRow[convQxPrjMenus.ApplicationTypeName] == DBNull.Value ? null : objRow[convQxPrjMenus.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvQxPrjMenusEN.UpdDate = objRow[convQxPrjMenus.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenusEN.UpdUserId = objRow[convQxPrjMenus.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenusEN.Memo = objRow[convQxPrjMenus.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus.Memo].ToString().Trim(); //备注
objvQxPrjMenusEN.UpMenuName = objRow[convQxPrjMenus.UpMenuName] == DBNull.Value ? null : objRow[convQxPrjMenus.UpMenuName].ToString().Trim(); //上级菜单名
objvQxPrjMenusEN.SubMenusNum = objRow[convQxPrjMenus.SubMenusNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus.SubMenusNum].ToString().Trim()); //子菜单数
objvQxPrjMenusEN.RoleNum = objRow[convQxPrjMenus.RoleNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus.RoleNum].ToString().Trim()); //角色数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenusEN.MenuId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenusEN);
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
public static List<clsvQxPrjMenusEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvQxPrjMenusEN> arrObjLst = new List<clsvQxPrjMenusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenusEN objvQxPrjMenusEN = new clsvQxPrjMenusEN();
try
{
objvQxPrjMenusEN.MenuId = objRow[convQxPrjMenus.MenuId].ToString().Trim(); //菜单Id
objvQxPrjMenusEN.MenuName = objRow[convQxPrjMenus.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenusEN.QxPrjId = objRow[convQxPrjMenus.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenusEN.PrjName = objRow[convQxPrjMenus.PrjName].ToString().Trim(); //工程名
objvQxPrjMenusEN.UpMenuId = objRow[convQxPrjMenus.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenusEN.LinkFile = objRow[convQxPrjMenus.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenusEN.qsParameters = objRow[convQxPrjMenus.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenusEN.TabId = objRow[convQxPrjMenus.TabId] == DBNull.Value ? null : objRow[convQxPrjMenus.TabId].ToString().Trim(); //表ID
objvQxPrjMenusEN.TabName = objRow[convQxPrjMenus.TabName] == DBNull.Value ? null : objRow[convQxPrjMenus.TabName].ToString().Trim(); //TabName
objvQxPrjMenusEN.ImgFile = objRow[convQxPrjMenus.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenusEN.RoleId = objRow[convQxPrjMenus.RoleId] == DBNull.Value ? null : objRow[convQxPrjMenus.RoleId].ToString().Trim(); //角色Id
objvQxPrjMenusEN.RoleName = objRow[convQxPrjMenus.RoleName].ToString().Trim(); //角色名称
objvQxPrjMenusEN.OrderNum = objRow[convQxPrjMenus.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenusEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenusEN.MenuSetId = objRow[convQxPrjMenus.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenusEN.MenuSetName = objRow[convQxPrjMenus.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenusEN.MenuTitle = objRow[convQxPrjMenus.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenusEN.PageDispModeId = objRow[convQxPrjMenus.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenusEN.PageDispModeName = objRow[convQxPrjMenus.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenusEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus.InUse].ToString().Trim()); //是否在用
objvQxPrjMenusEN.MenuControlName = objRow[convQxPrjMenus.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuControlName].ToString().Trim(); //MenuControlName
objvQxPrjMenusEN.ApplicationTypeId = Int32.Parse(objRow[convQxPrjMenus.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvQxPrjMenusEN.ApplicationTypeName = objRow[convQxPrjMenus.ApplicationTypeName] == DBNull.Value ? null : objRow[convQxPrjMenus.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvQxPrjMenusEN.UpdDate = objRow[convQxPrjMenus.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenusEN.UpdUserId = objRow[convQxPrjMenus.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenusEN.Memo = objRow[convQxPrjMenus.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus.Memo].ToString().Trim(); //备注
objvQxPrjMenusEN.UpMenuName = objRow[convQxPrjMenus.UpMenuName] == DBNull.Value ? null : objRow[convQxPrjMenus.UpMenuName].ToString().Trim(); //上级菜单名
objvQxPrjMenusEN.SubMenusNum = objRow[convQxPrjMenus.SubMenusNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus.SubMenusNum].ToString().Trim()); //子菜单数
objvQxPrjMenusEN.RoleNum = objRow[convQxPrjMenus.RoleNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus.RoleNum].ToString().Trim()); //角色数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenusEN.MenuId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenusEN);
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
List<clsvQxPrjMenusEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvQxPrjMenusEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjMenusEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvQxPrjMenusEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvQxPrjMenusEN> arrObjLst = new List<clsvQxPrjMenusEN>(); 
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
	clsvQxPrjMenusEN objvQxPrjMenusEN = new clsvQxPrjMenusEN();
try
{
objvQxPrjMenusEN.MenuId = objRow[convQxPrjMenus.MenuId].ToString().Trim(); //菜单Id
objvQxPrjMenusEN.MenuName = objRow[convQxPrjMenus.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenusEN.QxPrjId = objRow[convQxPrjMenus.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenusEN.PrjName = objRow[convQxPrjMenus.PrjName].ToString().Trim(); //工程名
objvQxPrjMenusEN.UpMenuId = objRow[convQxPrjMenus.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenusEN.LinkFile = objRow[convQxPrjMenus.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenusEN.qsParameters = objRow[convQxPrjMenus.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenusEN.TabId = objRow[convQxPrjMenus.TabId] == DBNull.Value ? null : objRow[convQxPrjMenus.TabId].ToString().Trim(); //表ID
objvQxPrjMenusEN.TabName = objRow[convQxPrjMenus.TabName] == DBNull.Value ? null : objRow[convQxPrjMenus.TabName].ToString().Trim(); //TabName
objvQxPrjMenusEN.ImgFile = objRow[convQxPrjMenus.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenusEN.RoleId = objRow[convQxPrjMenus.RoleId] == DBNull.Value ? null : objRow[convQxPrjMenus.RoleId].ToString().Trim(); //角色Id
objvQxPrjMenusEN.RoleName = objRow[convQxPrjMenus.RoleName].ToString().Trim(); //角色名称
objvQxPrjMenusEN.OrderNum = objRow[convQxPrjMenus.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenusEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenusEN.MenuSetId = objRow[convQxPrjMenus.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenusEN.MenuSetName = objRow[convQxPrjMenus.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenusEN.MenuTitle = objRow[convQxPrjMenus.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenusEN.PageDispModeId = objRow[convQxPrjMenus.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenusEN.PageDispModeName = objRow[convQxPrjMenus.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenusEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus.InUse].ToString().Trim()); //是否在用
objvQxPrjMenusEN.MenuControlName = objRow[convQxPrjMenus.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuControlName].ToString().Trim(); //MenuControlName
objvQxPrjMenusEN.ApplicationTypeId = Int32.Parse(objRow[convQxPrjMenus.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvQxPrjMenusEN.ApplicationTypeName = objRow[convQxPrjMenus.ApplicationTypeName] == DBNull.Value ? null : objRow[convQxPrjMenus.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvQxPrjMenusEN.UpdDate = objRow[convQxPrjMenus.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenusEN.UpdUserId = objRow[convQxPrjMenus.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenusEN.Memo = objRow[convQxPrjMenus.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus.Memo].ToString().Trim(); //备注
objvQxPrjMenusEN.UpMenuName = objRow[convQxPrjMenus.UpMenuName] == DBNull.Value ? null : objRow[convQxPrjMenus.UpMenuName].ToString().Trim(); //上级菜单名
objvQxPrjMenusEN.SubMenusNum = objRow[convQxPrjMenus.SubMenusNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus.SubMenusNum].ToString().Trim()); //子菜单数
objvQxPrjMenusEN.RoleNum = objRow[convQxPrjMenus.RoleNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus.RoleNum].ToString().Trim()); //角色数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenusEN.MenuId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenusEN);
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
public static List<clsvQxPrjMenusEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvQxPrjMenusEN> arrObjLst = new List<clsvQxPrjMenusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenusEN objvQxPrjMenusEN = new clsvQxPrjMenusEN();
try
{
objvQxPrjMenusEN.MenuId = objRow[convQxPrjMenus.MenuId].ToString().Trim(); //菜单Id
objvQxPrjMenusEN.MenuName = objRow[convQxPrjMenus.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenusEN.QxPrjId = objRow[convQxPrjMenus.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenusEN.PrjName = objRow[convQxPrjMenus.PrjName].ToString().Trim(); //工程名
objvQxPrjMenusEN.UpMenuId = objRow[convQxPrjMenus.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenusEN.LinkFile = objRow[convQxPrjMenus.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenusEN.qsParameters = objRow[convQxPrjMenus.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenusEN.TabId = objRow[convQxPrjMenus.TabId] == DBNull.Value ? null : objRow[convQxPrjMenus.TabId].ToString().Trim(); //表ID
objvQxPrjMenusEN.TabName = objRow[convQxPrjMenus.TabName] == DBNull.Value ? null : objRow[convQxPrjMenus.TabName].ToString().Trim(); //TabName
objvQxPrjMenusEN.ImgFile = objRow[convQxPrjMenus.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenusEN.RoleId = objRow[convQxPrjMenus.RoleId] == DBNull.Value ? null : objRow[convQxPrjMenus.RoleId].ToString().Trim(); //角色Id
objvQxPrjMenusEN.RoleName = objRow[convQxPrjMenus.RoleName].ToString().Trim(); //角色名称
objvQxPrjMenusEN.OrderNum = objRow[convQxPrjMenus.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenusEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenusEN.MenuSetId = objRow[convQxPrjMenus.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenusEN.MenuSetName = objRow[convQxPrjMenus.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenusEN.MenuTitle = objRow[convQxPrjMenus.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenusEN.PageDispModeId = objRow[convQxPrjMenus.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenusEN.PageDispModeName = objRow[convQxPrjMenus.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenusEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus.InUse].ToString().Trim()); //是否在用
objvQxPrjMenusEN.MenuControlName = objRow[convQxPrjMenus.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuControlName].ToString().Trim(); //MenuControlName
objvQxPrjMenusEN.ApplicationTypeId = Int32.Parse(objRow[convQxPrjMenus.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvQxPrjMenusEN.ApplicationTypeName = objRow[convQxPrjMenus.ApplicationTypeName] == DBNull.Value ? null : objRow[convQxPrjMenus.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvQxPrjMenusEN.UpdDate = objRow[convQxPrjMenus.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenusEN.UpdUserId = objRow[convQxPrjMenus.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenusEN.Memo = objRow[convQxPrjMenus.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus.Memo].ToString().Trim(); //备注
objvQxPrjMenusEN.UpMenuName = objRow[convQxPrjMenus.UpMenuName] == DBNull.Value ? null : objRow[convQxPrjMenus.UpMenuName].ToString().Trim(); //上级菜单名
objvQxPrjMenusEN.SubMenusNum = objRow[convQxPrjMenus.SubMenusNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus.SubMenusNum].ToString().Trim()); //子菜单数
objvQxPrjMenusEN.RoleNum = objRow[convQxPrjMenus.RoleNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus.RoleNum].ToString().Trim()); //角色数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenusEN.MenuId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenusEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQxPrjMenusEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvQxPrjMenusEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvQxPrjMenusEN> arrObjLst = new List<clsvQxPrjMenusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenusEN objvQxPrjMenusEN = new clsvQxPrjMenusEN();
try
{
objvQxPrjMenusEN.MenuId = objRow[convQxPrjMenus.MenuId].ToString().Trim(); //菜单Id
objvQxPrjMenusEN.MenuName = objRow[convQxPrjMenus.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenusEN.QxPrjId = objRow[convQxPrjMenus.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenusEN.PrjName = objRow[convQxPrjMenus.PrjName].ToString().Trim(); //工程名
objvQxPrjMenusEN.UpMenuId = objRow[convQxPrjMenus.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenusEN.LinkFile = objRow[convQxPrjMenus.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenusEN.qsParameters = objRow[convQxPrjMenus.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenusEN.TabId = objRow[convQxPrjMenus.TabId] == DBNull.Value ? null : objRow[convQxPrjMenus.TabId].ToString().Trim(); //表ID
objvQxPrjMenusEN.TabName = objRow[convQxPrjMenus.TabName] == DBNull.Value ? null : objRow[convQxPrjMenus.TabName].ToString().Trim(); //TabName
objvQxPrjMenusEN.ImgFile = objRow[convQxPrjMenus.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenusEN.RoleId = objRow[convQxPrjMenus.RoleId] == DBNull.Value ? null : objRow[convQxPrjMenus.RoleId].ToString().Trim(); //角色Id
objvQxPrjMenusEN.RoleName = objRow[convQxPrjMenus.RoleName].ToString().Trim(); //角色名称
objvQxPrjMenusEN.OrderNum = objRow[convQxPrjMenus.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenusEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenusEN.MenuSetId = objRow[convQxPrjMenus.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenusEN.MenuSetName = objRow[convQxPrjMenus.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenusEN.MenuTitle = objRow[convQxPrjMenus.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenusEN.PageDispModeId = objRow[convQxPrjMenus.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenusEN.PageDispModeName = objRow[convQxPrjMenus.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenusEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus.InUse].ToString().Trim()); //是否在用
objvQxPrjMenusEN.MenuControlName = objRow[convQxPrjMenus.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuControlName].ToString().Trim(); //MenuControlName
objvQxPrjMenusEN.ApplicationTypeId = Int32.Parse(objRow[convQxPrjMenus.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvQxPrjMenusEN.ApplicationTypeName = objRow[convQxPrjMenus.ApplicationTypeName] == DBNull.Value ? null : objRow[convQxPrjMenus.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvQxPrjMenusEN.UpdDate = objRow[convQxPrjMenus.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenusEN.UpdUserId = objRow[convQxPrjMenus.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenusEN.Memo = objRow[convQxPrjMenus.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus.Memo].ToString().Trim(); //备注
objvQxPrjMenusEN.UpMenuName = objRow[convQxPrjMenus.UpMenuName] == DBNull.Value ? null : objRow[convQxPrjMenus.UpMenuName].ToString().Trim(); //上级菜单名
objvQxPrjMenusEN.SubMenusNum = objRow[convQxPrjMenus.SubMenusNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus.SubMenusNum].ToString().Trim()); //子菜单数
objvQxPrjMenusEN.RoleNum = objRow[convQxPrjMenus.RoleNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus.RoleNum].ToString().Trim()); //角色数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenusEN.MenuId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenusEN);
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
public static List<clsvQxPrjMenusEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvQxPrjMenusEN> arrObjLst = new List<clsvQxPrjMenusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenusEN objvQxPrjMenusEN = new clsvQxPrjMenusEN();
try
{
objvQxPrjMenusEN.MenuId = objRow[convQxPrjMenus.MenuId].ToString().Trim(); //菜单Id
objvQxPrjMenusEN.MenuName = objRow[convQxPrjMenus.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenusEN.QxPrjId = objRow[convQxPrjMenus.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenusEN.PrjName = objRow[convQxPrjMenus.PrjName].ToString().Trim(); //工程名
objvQxPrjMenusEN.UpMenuId = objRow[convQxPrjMenus.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenusEN.LinkFile = objRow[convQxPrjMenus.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenusEN.qsParameters = objRow[convQxPrjMenus.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenusEN.TabId = objRow[convQxPrjMenus.TabId] == DBNull.Value ? null : objRow[convQxPrjMenus.TabId].ToString().Trim(); //表ID
objvQxPrjMenusEN.TabName = objRow[convQxPrjMenus.TabName] == DBNull.Value ? null : objRow[convQxPrjMenus.TabName].ToString().Trim(); //TabName
objvQxPrjMenusEN.ImgFile = objRow[convQxPrjMenus.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenusEN.RoleId = objRow[convQxPrjMenus.RoleId] == DBNull.Value ? null : objRow[convQxPrjMenus.RoleId].ToString().Trim(); //角色Id
objvQxPrjMenusEN.RoleName = objRow[convQxPrjMenus.RoleName].ToString().Trim(); //角色名称
objvQxPrjMenusEN.OrderNum = objRow[convQxPrjMenus.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenusEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenusEN.MenuSetId = objRow[convQxPrjMenus.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenusEN.MenuSetName = objRow[convQxPrjMenus.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenusEN.MenuTitle = objRow[convQxPrjMenus.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenusEN.PageDispModeId = objRow[convQxPrjMenus.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenusEN.PageDispModeName = objRow[convQxPrjMenus.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenusEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus.InUse].ToString().Trim()); //是否在用
objvQxPrjMenusEN.MenuControlName = objRow[convQxPrjMenus.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuControlName].ToString().Trim(); //MenuControlName
objvQxPrjMenusEN.ApplicationTypeId = Int32.Parse(objRow[convQxPrjMenus.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvQxPrjMenusEN.ApplicationTypeName = objRow[convQxPrjMenus.ApplicationTypeName] == DBNull.Value ? null : objRow[convQxPrjMenus.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvQxPrjMenusEN.UpdDate = objRow[convQxPrjMenus.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenusEN.UpdUserId = objRow[convQxPrjMenus.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenusEN.Memo = objRow[convQxPrjMenus.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus.Memo].ToString().Trim(); //备注
objvQxPrjMenusEN.UpMenuName = objRow[convQxPrjMenus.UpMenuName] == DBNull.Value ? null : objRow[convQxPrjMenus.UpMenuName].ToString().Trim(); //上级菜单名
objvQxPrjMenusEN.SubMenusNum = objRow[convQxPrjMenus.SubMenusNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus.SubMenusNum].ToString().Trim()); //子菜单数
objvQxPrjMenusEN.RoleNum = objRow[convQxPrjMenus.RoleNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus.RoleNum].ToString().Trim()); //角色数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenusEN.MenuId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenusEN);
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
public static IEnumerable<clsvQxPrjMenusEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsvQxPrjMenusEN objvQxPrjMenusCond, string strOrderBy)
{
List<clsvQxPrjMenusEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjMenusEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxPrjMenus.AttributeName)
{
if (objvQxPrjMenusCond.IsUpdated(strFldName) == false) continue;
if (objvQxPrjMenusCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjMenusCond[strFldName].ToString());
}
else
{
if (objvQxPrjMenusCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxPrjMenusCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjMenusCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxPrjMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxPrjMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxPrjMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxPrjMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxPrjMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxPrjMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxPrjMenusCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxPrjMenusCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxPrjMenusCond[strFldName]));
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
public static IEnumerable<clsvQxPrjMenusEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsvQxPrjMenusEN objvQxPrjMenusCond = JsonConvert.DeserializeObject<clsvQxPrjMenusEN>(objPagerPara.whereCond);
if (objvQxPrjMenusCond.sfFldComparisonOp == null)
{
objvQxPrjMenusCond.dicFldComparisonOp = null;
}
else
{
objvQxPrjMenusCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objvQxPrjMenusCond.sfFldComparisonOp);
}
clsvQxPrjMenusBL.SetUpdFlag(objvQxPrjMenusCond);
 try
{
CheckProperty4Condition(objvQxPrjMenusCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsvQxPrjMenusBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objvQxPrjMenusCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjMenusEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsvQxPrjMenusEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxPrjMenusEN> arrObjLst = new List<clsvQxPrjMenusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenusEN objvQxPrjMenusEN = new clsvQxPrjMenusEN();
try
{
objvQxPrjMenusEN.MenuId = objRow[convQxPrjMenus.MenuId].ToString().Trim(); //菜单Id
objvQxPrjMenusEN.MenuName = objRow[convQxPrjMenus.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenusEN.QxPrjId = objRow[convQxPrjMenus.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenusEN.PrjName = objRow[convQxPrjMenus.PrjName].ToString().Trim(); //工程名
objvQxPrjMenusEN.UpMenuId = objRow[convQxPrjMenus.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenusEN.LinkFile = objRow[convQxPrjMenus.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenusEN.qsParameters = objRow[convQxPrjMenus.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenusEN.TabId = objRow[convQxPrjMenus.TabId] == DBNull.Value ? null : objRow[convQxPrjMenus.TabId].ToString().Trim(); //表ID
objvQxPrjMenusEN.TabName = objRow[convQxPrjMenus.TabName] == DBNull.Value ? null : objRow[convQxPrjMenus.TabName].ToString().Trim(); //TabName
objvQxPrjMenusEN.ImgFile = objRow[convQxPrjMenus.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenusEN.RoleId = objRow[convQxPrjMenus.RoleId] == DBNull.Value ? null : objRow[convQxPrjMenus.RoleId].ToString().Trim(); //角色Id
objvQxPrjMenusEN.RoleName = objRow[convQxPrjMenus.RoleName].ToString().Trim(); //角色名称
objvQxPrjMenusEN.OrderNum = objRow[convQxPrjMenus.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenusEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenusEN.MenuSetId = objRow[convQxPrjMenus.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenusEN.MenuSetName = objRow[convQxPrjMenus.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenusEN.MenuTitle = objRow[convQxPrjMenus.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenusEN.PageDispModeId = objRow[convQxPrjMenus.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenusEN.PageDispModeName = objRow[convQxPrjMenus.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenusEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus.InUse].ToString().Trim()); //是否在用
objvQxPrjMenusEN.MenuControlName = objRow[convQxPrjMenus.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuControlName].ToString().Trim(); //MenuControlName
objvQxPrjMenusEN.ApplicationTypeId = Int32.Parse(objRow[convQxPrjMenus.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvQxPrjMenusEN.ApplicationTypeName = objRow[convQxPrjMenus.ApplicationTypeName] == DBNull.Value ? null : objRow[convQxPrjMenus.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvQxPrjMenusEN.UpdDate = objRow[convQxPrjMenus.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenusEN.UpdUserId = objRow[convQxPrjMenus.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenusEN.Memo = objRow[convQxPrjMenus.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus.Memo].ToString().Trim(); //备注
objvQxPrjMenusEN.UpMenuName = objRow[convQxPrjMenus.UpMenuName] == DBNull.Value ? null : objRow[convQxPrjMenus.UpMenuName].ToString().Trim(); //上级菜单名
objvQxPrjMenusEN.SubMenusNum = objRow[convQxPrjMenus.SubMenusNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus.SubMenusNum].ToString().Trim()); //子菜单数
objvQxPrjMenusEN.RoleNum = objRow[convQxPrjMenus.RoleNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus.RoleNum].ToString().Trim()); //角色数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenusEN.MenuId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenusEN);
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
public static List<clsvQxPrjMenusEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxPrjMenusEN> arrObjLst = new List<clsvQxPrjMenusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenusEN objvQxPrjMenusEN = new clsvQxPrjMenusEN();
try
{
objvQxPrjMenusEN.MenuId = objRow[convQxPrjMenus.MenuId].ToString().Trim(); //菜单Id
objvQxPrjMenusEN.MenuName = objRow[convQxPrjMenus.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenusEN.QxPrjId = objRow[convQxPrjMenus.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenusEN.PrjName = objRow[convQxPrjMenus.PrjName].ToString().Trim(); //工程名
objvQxPrjMenusEN.UpMenuId = objRow[convQxPrjMenus.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenusEN.LinkFile = objRow[convQxPrjMenus.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenusEN.qsParameters = objRow[convQxPrjMenus.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenusEN.TabId = objRow[convQxPrjMenus.TabId] == DBNull.Value ? null : objRow[convQxPrjMenus.TabId].ToString().Trim(); //表ID
objvQxPrjMenusEN.TabName = objRow[convQxPrjMenus.TabName] == DBNull.Value ? null : objRow[convQxPrjMenus.TabName].ToString().Trim(); //TabName
objvQxPrjMenusEN.ImgFile = objRow[convQxPrjMenus.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenusEN.RoleId = objRow[convQxPrjMenus.RoleId] == DBNull.Value ? null : objRow[convQxPrjMenus.RoleId].ToString().Trim(); //角色Id
objvQxPrjMenusEN.RoleName = objRow[convQxPrjMenus.RoleName].ToString().Trim(); //角色名称
objvQxPrjMenusEN.OrderNum = objRow[convQxPrjMenus.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenusEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenusEN.MenuSetId = objRow[convQxPrjMenus.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenusEN.MenuSetName = objRow[convQxPrjMenus.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenusEN.MenuTitle = objRow[convQxPrjMenus.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenusEN.PageDispModeId = objRow[convQxPrjMenus.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenusEN.PageDispModeName = objRow[convQxPrjMenus.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenusEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus.InUse].ToString().Trim()); //是否在用
objvQxPrjMenusEN.MenuControlName = objRow[convQxPrjMenus.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuControlName].ToString().Trim(); //MenuControlName
objvQxPrjMenusEN.ApplicationTypeId = Int32.Parse(objRow[convQxPrjMenus.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvQxPrjMenusEN.ApplicationTypeName = objRow[convQxPrjMenus.ApplicationTypeName] == DBNull.Value ? null : objRow[convQxPrjMenus.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvQxPrjMenusEN.UpdDate = objRow[convQxPrjMenus.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenusEN.UpdUserId = objRow[convQxPrjMenus.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenusEN.Memo = objRow[convQxPrjMenus.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus.Memo].ToString().Trim(); //备注
objvQxPrjMenusEN.UpMenuName = objRow[convQxPrjMenus.UpMenuName] == DBNull.Value ? null : objRow[convQxPrjMenus.UpMenuName].ToString().Trim(); //上级菜单名
objvQxPrjMenusEN.SubMenusNum = objRow[convQxPrjMenus.SubMenusNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus.SubMenusNum].ToString().Trim()); //子菜单数
objvQxPrjMenusEN.RoleNum = objRow[convQxPrjMenus.RoleNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus.RoleNum].ToString().Trim()); //角色数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenusEN.MenuId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenusEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjMenusEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvQxPrjMenusEN> arrObjLst = new List<clsvQxPrjMenusEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenusEN objvQxPrjMenusEN = new clsvQxPrjMenusEN();
try
{
objvQxPrjMenusEN.MenuId = objRow[convQxPrjMenus.MenuId].ToString().Trim(); //菜单Id
objvQxPrjMenusEN.MenuName = objRow[convQxPrjMenus.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenusEN.QxPrjId = objRow[convQxPrjMenus.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenusEN.PrjName = objRow[convQxPrjMenus.PrjName].ToString().Trim(); //工程名
objvQxPrjMenusEN.UpMenuId = objRow[convQxPrjMenus.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenusEN.LinkFile = objRow[convQxPrjMenus.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenusEN.qsParameters = objRow[convQxPrjMenus.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenusEN.TabId = objRow[convQxPrjMenus.TabId] == DBNull.Value ? null : objRow[convQxPrjMenus.TabId].ToString().Trim(); //表ID
objvQxPrjMenusEN.TabName = objRow[convQxPrjMenus.TabName] == DBNull.Value ? null : objRow[convQxPrjMenus.TabName].ToString().Trim(); //TabName
objvQxPrjMenusEN.ImgFile = objRow[convQxPrjMenus.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenusEN.RoleId = objRow[convQxPrjMenus.RoleId] == DBNull.Value ? null : objRow[convQxPrjMenus.RoleId].ToString().Trim(); //角色Id
objvQxPrjMenusEN.RoleName = objRow[convQxPrjMenus.RoleName].ToString().Trim(); //角色名称
objvQxPrjMenusEN.OrderNum = objRow[convQxPrjMenus.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenusEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenusEN.MenuSetId = objRow[convQxPrjMenus.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenusEN.MenuSetName = objRow[convQxPrjMenus.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenusEN.MenuTitle = objRow[convQxPrjMenus.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenusEN.PageDispModeId = objRow[convQxPrjMenus.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenusEN.PageDispModeName = objRow[convQxPrjMenus.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenusEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus.InUse].ToString().Trim()); //是否在用
objvQxPrjMenusEN.MenuControlName = objRow[convQxPrjMenus.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus.MenuControlName].ToString().Trim(); //MenuControlName
objvQxPrjMenusEN.ApplicationTypeId = Int32.Parse(objRow[convQxPrjMenus.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvQxPrjMenusEN.ApplicationTypeName = objRow[convQxPrjMenus.ApplicationTypeName] == DBNull.Value ? null : objRow[convQxPrjMenus.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvQxPrjMenusEN.UpdDate = objRow[convQxPrjMenus.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenusEN.UpdUserId = objRow[convQxPrjMenus.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenusEN.Memo = objRow[convQxPrjMenus.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus.Memo].ToString().Trim(); //备注
objvQxPrjMenusEN.UpMenuName = objRow[convQxPrjMenus.UpMenuName] == DBNull.Value ? null : objRow[convQxPrjMenus.UpMenuName].ToString().Trim(); //上级菜单名
objvQxPrjMenusEN.SubMenusNum = objRow[convQxPrjMenus.SubMenusNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus.SubMenusNum].ToString().Trim()); //子菜单数
objvQxPrjMenusEN.RoleNum = objRow[convQxPrjMenus.RoleNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus.RoleNum].ToString().Trim()); //角色数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenusEN.MenuId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenusEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxPrjMenus(ref clsvQxPrjMenusEN objvQxPrjMenusEN)
{
bool bolResult = vQxPrjMenusDA.GetvQxPrjMenus(ref objvQxPrjMenusEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strMenuId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxPrjMenusEN GetObjByMenuId(string strMenuId)
{
if (strMenuId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strMenuId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strMenuId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strMenuId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvQxPrjMenusEN objvQxPrjMenusEN = vQxPrjMenusDA.GetObjByMenuId(strMenuId);
return objvQxPrjMenusEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvQxPrjMenusEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvQxPrjMenusEN objvQxPrjMenusEN = vQxPrjMenusDA.GetFirstObj(strWhereCond);
 return objvQxPrjMenusEN;
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
public static clsvQxPrjMenusEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvQxPrjMenusEN objvQxPrjMenusEN = vQxPrjMenusDA.GetObjByDataRow(objRow);
 return objvQxPrjMenusEN;
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
public static clsvQxPrjMenusEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvQxPrjMenusEN objvQxPrjMenusEN = vQxPrjMenusDA.GetObjByDataRow(objRow);
 return objvQxPrjMenusEN;
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
 /// <param name = "strMenuId">所给的关键字</param>
 /// <param name = "lstvQxPrjMenusObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxPrjMenusEN GetObjByMenuIdFromList(string strMenuId, List<clsvQxPrjMenusEN> lstvQxPrjMenusObjLst)
{
foreach (clsvQxPrjMenusEN objvQxPrjMenusEN in lstvQxPrjMenusObjLst)
{
if (objvQxPrjMenusEN.MenuId == strMenuId)
{
return objvQxPrjMenusEN;
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
 string strMenuId;
 try
 {
 strMenuId = new clsvQxPrjMenusDA().GetFirstID(strWhereCond);
 return strMenuId;
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
 arrList = vQxPrjMenusDA.GetID(strWhereCond);
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
bool bolIsExist = vQxPrjMenusDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strMenuId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strMenuId)
{
if (string.IsNullOrEmpty(strMenuId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strMenuId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vQxPrjMenusDA.IsExist(strMenuId);
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
 bolIsExist = clsvQxPrjMenusDA.IsExistTable();
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
 bolIsExist = vQxPrjMenusDA.IsExistTable(strTabName);
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
 /// <param name = "objvQxPrjMenusEN">源简化对象</param>
 public static void SetUpdFlag(clsvQxPrjMenusEN objvQxPrjMenusEN)
{
try
{
objvQxPrjMenusEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvQxPrjMenusEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convQxPrjMenus.MenuId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenusEN.MenuId = objvQxPrjMenusEN.MenuId; //菜单Id
}
if (arrFldSet.Contains(convQxPrjMenus.MenuName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenusEN.MenuName = objvQxPrjMenusEN.MenuName; //菜单名
}
if (arrFldSet.Contains(convQxPrjMenus.QxPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenusEN.QxPrjId = objvQxPrjMenusEN.QxPrjId; //项目Id
}
if (arrFldSet.Contains(convQxPrjMenus.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenusEN.PrjName = objvQxPrjMenusEN.PrjName; //工程名
}
if (arrFldSet.Contains(convQxPrjMenus.UpMenuId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenusEN.UpMenuId = objvQxPrjMenusEN.UpMenuId == "[null]" ? null :  objvQxPrjMenusEN.UpMenuId; //上级菜单Id
}
if (arrFldSet.Contains(convQxPrjMenus.LinkFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenusEN.LinkFile = objvQxPrjMenusEN.LinkFile == "[null]" ? null :  objvQxPrjMenusEN.LinkFile; //链接文件
}
if (arrFldSet.Contains(convQxPrjMenus.qsParameters, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenusEN.qsParameters = objvQxPrjMenusEN.qsParameters == "[null]" ? null :  objvQxPrjMenusEN.qsParameters; //qs参数
}
if (arrFldSet.Contains(convQxPrjMenus.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenusEN.TabId = objvQxPrjMenusEN.TabId == "[null]" ? null :  objvQxPrjMenusEN.TabId; //表ID
}
if (arrFldSet.Contains(convQxPrjMenus.TabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenusEN.TabName = objvQxPrjMenusEN.TabName == "[null]" ? null :  objvQxPrjMenusEN.TabName; //TabName
}
if (arrFldSet.Contains(convQxPrjMenus.ImgFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenusEN.ImgFile = objvQxPrjMenusEN.ImgFile == "[null]" ? null :  objvQxPrjMenusEN.ImgFile; //图像文件
}
if (arrFldSet.Contains(convQxPrjMenus.RoleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenusEN.RoleId = objvQxPrjMenusEN.RoleId == "[null]" ? null :  objvQxPrjMenusEN.RoleId; //角色Id
}
if (arrFldSet.Contains(convQxPrjMenus.RoleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenusEN.RoleName = objvQxPrjMenusEN.RoleName; //角色名称
}
if (arrFldSet.Contains(convQxPrjMenus.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenusEN.OrderNum = objvQxPrjMenusEN.OrderNum; //排序号
}
if (arrFldSet.Contains(convQxPrjMenus.IsLeafNode, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenusEN.IsLeafNode = objvQxPrjMenusEN.IsLeafNode; //是否叶子
}
if (arrFldSet.Contains(convQxPrjMenus.MenuSetId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenusEN.MenuSetId = objvQxPrjMenusEN.MenuSetId; //菜单集Id
}
if (arrFldSet.Contains(convQxPrjMenus.MenuSetName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenusEN.MenuSetName = objvQxPrjMenusEN.MenuSetName == "[null]" ? null :  objvQxPrjMenusEN.MenuSetName; //菜单集名称
}
if (arrFldSet.Contains(convQxPrjMenus.MenuTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenusEN.MenuTitle = objvQxPrjMenusEN.MenuTitle == "[null]" ? null :  objvQxPrjMenusEN.MenuTitle; //菜单标题
}
if (arrFldSet.Contains(convQxPrjMenus.PageDispModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenusEN.PageDispModeId = objvQxPrjMenusEN.PageDispModeId == "[null]" ? null :  objvQxPrjMenusEN.PageDispModeId; //页面显示模式Id
}
if (arrFldSet.Contains(convQxPrjMenus.PageDispModeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenusEN.PageDispModeName = objvQxPrjMenusEN.PageDispModeName == "[null]" ? null :  objvQxPrjMenusEN.PageDispModeName; //页面显示模式名称
}
if (arrFldSet.Contains(convQxPrjMenus.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenusEN.InUse = objvQxPrjMenusEN.InUse; //是否在用
}
if (arrFldSet.Contains(convQxPrjMenus.MenuControlName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenusEN.MenuControlName = objvQxPrjMenusEN.MenuControlName == "[null]" ? null :  objvQxPrjMenusEN.MenuControlName; //MenuControlName
}
if (arrFldSet.Contains(convQxPrjMenus.ApplicationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenusEN.ApplicationTypeId = objvQxPrjMenusEN.ApplicationTypeId; //应用程序类型ID
}
if (arrFldSet.Contains(convQxPrjMenus.ApplicationTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenusEN.ApplicationTypeName = objvQxPrjMenusEN.ApplicationTypeName == "[null]" ? null :  objvQxPrjMenusEN.ApplicationTypeName; //应用程序类型名称
}
if (arrFldSet.Contains(convQxPrjMenus.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenusEN.UpdDate = objvQxPrjMenusEN.UpdDate == "[null]" ? null :  objvQxPrjMenusEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convQxPrjMenus.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenusEN.UpdUserId = objvQxPrjMenusEN.UpdUserId == "[null]" ? null :  objvQxPrjMenusEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convQxPrjMenus.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenusEN.Memo = objvQxPrjMenusEN.Memo == "[null]" ? null :  objvQxPrjMenusEN.Memo; //备注
}
if (arrFldSet.Contains(convQxPrjMenus.UpMenuName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenusEN.UpMenuName = objvQxPrjMenusEN.UpMenuName == "[null]" ? null :  objvQxPrjMenusEN.UpMenuName; //上级菜单名
}
if (arrFldSet.Contains(convQxPrjMenus.SubMenusNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenusEN.SubMenusNum = objvQxPrjMenusEN.SubMenusNum; //子菜单数
}
if (arrFldSet.Contains(convQxPrjMenus.RoleNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenusEN.RoleNum = objvQxPrjMenusEN.RoleNum; //角色数
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
 /// <param name = "objvQxPrjMenusEN">源简化对象</param>
 public static void AccessFldValueNull(clsvQxPrjMenusEN objvQxPrjMenusEN)
{
try
{
if (objvQxPrjMenusEN.UpMenuId == "[null]") objvQxPrjMenusEN.UpMenuId = null; //上级菜单Id
if (objvQxPrjMenusEN.LinkFile == "[null]") objvQxPrjMenusEN.LinkFile = null; //链接文件
if (objvQxPrjMenusEN.qsParameters == "[null]") objvQxPrjMenusEN.qsParameters = null; //qs参数
if (objvQxPrjMenusEN.TabId == "[null]") objvQxPrjMenusEN.TabId = null; //表ID
if (objvQxPrjMenusEN.TabName == "[null]") objvQxPrjMenusEN.TabName = null; //TabName
if (objvQxPrjMenusEN.ImgFile == "[null]") objvQxPrjMenusEN.ImgFile = null; //图像文件
if (objvQxPrjMenusEN.RoleId == "[null]") objvQxPrjMenusEN.RoleId = null; //角色Id
if (objvQxPrjMenusEN.MenuSetName == "[null]") objvQxPrjMenusEN.MenuSetName = null; //菜单集名称
if (objvQxPrjMenusEN.MenuTitle == "[null]") objvQxPrjMenusEN.MenuTitle = null; //菜单标题
if (objvQxPrjMenusEN.PageDispModeId == "[null]") objvQxPrjMenusEN.PageDispModeId = null; //页面显示模式Id
if (objvQxPrjMenusEN.PageDispModeName == "[null]") objvQxPrjMenusEN.PageDispModeName = null; //页面显示模式名称
if (objvQxPrjMenusEN.MenuControlName == "[null]") objvQxPrjMenusEN.MenuControlName = null; //MenuControlName
if (objvQxPrjMenusEN.ApplicationTypeName == "[null]") objvQxPrjMenusEN.ApplicationTypeName = null; //应用程序类型名称
if (objvQxPrjMenusEN.UpdDate == "[null]") objvQxPrjMenusEN.UpdDate = null; //修改日期
if (objvQxPrjMenusEN.UpdUserId == "[null]") objvQxPrjMenusEN.UpdUserId = null; //修改用户Id
if (objvQxPrjMenusEN.Memo == "[null]") objvQxPrjMenusEN.Memo = null; //备注
if (objvQxPrjMenusEN.UpMenuName == "[null]") objvQxPrjMenusEN.UpMenuName = null; //上级菜单名
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
public static void CheckProperty4Condition(clsvQxPrjMenusEN objvQxPrjMenusEN)
{
 vQxPrjMenusDA.CheckProperty4Condition(objvQxPrjMenusEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_MenuId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convQxPrjMenus.MenuId); 
List<clsvQxPrjMenusEN> arrObjLst = clsvQxPrjMenusBL.GetObjLst(strCondition);
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
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_MenuId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v工程菜单]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convQxPrjMenus.MenuId); 
IEnumerable<clsvQxPrjMenusEN> arrObjLst = clsvQxPrjMenusBL.GetObjLst(strCondition);
objDDL.DataValueField = convQxPrjMenus.MenuId;
objDDL.DataTextField = convQxPrjMenus.MenuName;
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
public static void BindDdl_MenuIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v工程菜单]...","0");
List<clsvQxPrjMenusEN> arrvQxPrjMenusObjLst = GetAllvQxPrjMenusObjLstCache(); 
objDDL.DataValueField = convQxPrjMenus.MenuId;
objDDL.DataTextField = convQxPrjMenus.MenuName;
objDDL.DataSource = arrvQxPrjMenusObjLst;
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
if (clsQxPrjMenusBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxPrjMenusBL没有刷新缓存机制(clsQxPrjMenusBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxProjectsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxProjectsBL没有刷新缓存机制(clsQxProjectsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxRolesBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxRolesBL没有刷新缓存机制(clsQxRolesBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxPageDispModeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxPageDispModeBL没有刷新缓存机制(clsQxPageDispModeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxPrjMenuSetBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxPrjMenuSetBL没有刷新缓存机制(clsQxPrjMenuSetBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxApplicationTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxApplicationTypeBL没有刷新缓存机制(clsQxApplicationTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxPrjTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxPrjTabBL没有刷新缓存机制(clsQxPrjTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by MenuId");
//if (arrvQxPrjMenusObjLstCache == null)
//{
//arrvQxPrjMenusObjLstCache = vQxPrjMenusDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strMenuId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxPrjMenusEN GetObjByMenuIdCache(string strMenuId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvQxPrjMenusEN._CurrTabName);
List<clsvQxPrjMenusEN> arrvQxPrjMenusObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjMenusEN> arrvQxPrjMenusObjLst_Sel =
arrvQxPrjMenusObjLstCache
.Where(x=> x.MenuId == strMenuId 
);
if (arrvQxPrjMenusObjLst_Sel.Count() == 0)
{
   clsvQxPrjMenusEN obj = clsvQxPrjMenusBL.GetObjByMenuId(strMenuId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvQxPrjMenusObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strMenuId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetMenuNameByMenuIdCache(string strMenuId)
{
if (string.IsNullOrEmpty(strMenuId) == true) return "";
//获取缓存中的对象列表
clsvQxPrjMenusEN objvQxPrjMenus = GetObjByMenuIdCache(strMenuId);
if (objvQxPrjMenus == null) return "";
return objvQxPrjMenus.MenuName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strMenuId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByMenuIdCache(string strMenuId)
{
if (string.IsNullOrEmpty(strMenuId) == true) return "";
//获取缓存中的对象列表
clsvQxPrjMenusEN objvQxPrjMenus = GetObjByMenuIdCache(strMenuId);
if (objvQxPrjMenus == null) return "";
return objvQxPrjMenus.MenuName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxPrjMenusEN> GetAllvQxPrjMenusObjLstCache()
{
//获取缓存中的对象列表
List<clsvQxPrjMenusEN> arrvQxPrjMenusObjLstCache = GetObjLstCache(); 
return arrvQxPrjMenusObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxPrjMenusEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvQxPrjMenusEN._CurrTabName);
List<clsvQxPrjMenusEN> arrvQxPrjMenusObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQxPrjMenusObjLstCache;
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


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstvQxPrjMenusObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsvQxPrjMenusEN> lstvQxPrjMenusObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstvQxPrjMenusObjLst, writer);
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
 /// <param name = "lstvQxPrjMenusObjLst">[clsvQxPrjMenusEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsvQxPrjMenusEN> lstvQxPrjMenusObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsvQxPrjMenusBL.listXmlNode);
writer.WriteStartElement(clsvQxPrjMenusBL.itemsXmlNode);
foreach (clsvQxPrjMenusEN objvQxPrjMenusEN in lstvQxPrjMenusObjLst)
{
clsvQxPrjMenusBL.SerializeXML(writer, objvQxPrjMenusEN);
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
 /// <param name = "objvQxPrjMenusEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsvQxPrjMenusEN objvQxPrjMenusEN)
{
writer.WriteStartElement(clsvQxPrjMenusBL.itemXmlNode);
 
if (objvQxPrjMenusEN.MenuId != null)
{
writer.WriteElementString(convQxPrjMenus.MenuId, objvQxPrjMenusEN.MenuId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenusEN.MenuName != null)
{
writer.WriteElementString(convQxPrjMenus.MenuName, objvQxPrjMenusEN.MenuName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenusEN.QxPrjId != null)
{
writer.WriteElementString(convQxPrjMenus.QxPrjId, objvQxPrjMenusEN.QxPrjId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenusEN.PrjName != null)
{
writer.WriteElementString(convQxPrjMenus.PrjName, objvQxPrjMenusEN.PrjName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenusEN.UpMenuId != null)
{
writer.WriteElementString(convQxPrjMenus.UpMenuId, objvQxPrjMenusEN.UpMenuId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenusEN.LinkFile != null)
{
writer.WriteElementString(convQxPrjMenus.LinkFile, objvQxPrjMenusEN.LinkFile.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenusEN.qsParameters != null)
{
writer.WriteElementString(convQxPrjMenus.qsParameters, objvQxPrjMenusEN.qsParameters.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenusEN.TabId != null)
{
writer.WriteElementString(convQxPrjMenus.TabId, objvQxPrjMenusEN.TabId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenusEN.TabName != null)
{
writer.WriteElementString(convQxPrjMenus.TabName, objvQxPrjMenusEN.TabName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenusEN.ImgFile != null)
{
writer.WriteElementString(convQxPrjMenus.ImgFile, objvQxPrjMenusEN.ImgFile.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenusEN.RoleId != null)
{
writer.WriteElementString(convQxPrjMenus.RoleId, objvQxPrjMenusEN.RoleId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenusEN.RoleName != null)
{
writer.WriteElementString(convQxPrjMenus.RoleName, objvQxPrjMenusEN.RoleName.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convQxPrjMenus.OrderNum, objvQxPrjMenusEN.OrderNum.ToString());
 
writer.WriteElementString(convQxPrjMenus.IsLeafNode, objvQxPrjMenusEN.IsLeafNode.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objvQxPrjMenusEN.MenuSetId != null)
{
writer.WriteElementString(convQxPrjMenus.MenuSetId, objvQxPrjMenusEN.MenuSetId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenusEN.MenuSetName != null)
{
writer.WriteElementString(convQxPrjMenus.MenuSetName, objvQxPrjMenusEN.MenuSetName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenusEN.MenuTitle != null)
{
writer.WriteElementString(convQxPrjMenus.MenuTitle, objvQxPrjMenusEN.MenuTitle.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenusEN.PageDispModeId != null)
{
writer.WriteElementString(convQxPrjMenus.PageDispModeId, objvQxPrjMenusEN.PageDispModeId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenusEN.PageDispModeName != null)
{
writer.WriteElementString(convQxPrjMenus.PageDispModeName, objvQxPrjMenusEN.PageDispModeName.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convQxPrjMenus.InUse, objvQxPrjMenusEN.InUse.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objvQxPrjMenusEN.MenuControlName != null)
{
writer.WriteElementString(convQxPrjMenus.MenuControlName, objvQxPrjMenusEN.MenuControlName.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convQxPrjMenus.ApplicationTypeId, objvQxPrjMenusEN.ApplicationTypeId.ToString(CultureInfo.InvariantCulture));
 
if (objvQxPrjMenusEN.ApplicationTypeName != null)
{
writer.WriteElementString(convQxPrjMenus.ApplicationTypeName, objvQxPrjMenusEN.ApplicationTypeName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenusEN.UpdDate != null)
{
writer.WriteElementString(convQxPrjMenus.UpdDate, objvQxPrjMenusEN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenusEN.UpdUserId != null)
{
writer.WriteElementString(convQxPrjMenus.UpdUserId, objvQxPrjMenusEN.UpdUserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenusEN.Memo != null)
{
writer.WriteElementString(convQxPrjMenus.Memo, objvQxPrjMenusEN.Memo.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenusEN.UpMenuName != null)
{
writer.WriteElementString(convQxPrjMenus.UpMenuName, objvQxPrjMenusEN.UpMenuName.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convQxPrjMenus.SubMenusNum, objvQxPrjMenusEN.SubMenusNum.ToString());
 
writer.WriteElementString(convQxPrjMenus.RoleNum, objvQxPrjMenusEN.RoleNum.ToString());
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
public static clsvQxPrjMenusEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsvQxPrjMenusEN objvQxPrjMenusEN = new clsvQxPrjMenusEN();
reader.Read();
while (!(reader.Name == clsvQxPrjMenusBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(convQxPrjMenus.MenuId))
{
objvQxPrjMenusEN.MenuId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus.MenuName))
{
objvQxPrjMenusEN.MenuName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus.QxPrjId))
{
objvQxPrjMenusEN.QxPrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus.PrjName))
{
objvQxPrjMenusEN.PrjName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus.UpMenuId))
{
objvQxPrjMenusEN.UpMenuId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus.LinkFile))
{
objvQxPrjMenusEN.LinkFile = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus.qsParameters))
{
objvQxPrjMenusEN.qsParameters = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus.TabId))
{
objvQxPrjMenusEN.TabId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus.TabName))
{
objvQxPrjMenusEN.TabName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus.ImgFile))
{
objvQxPrjMenusEN.ImgFile = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus.RoleId))
{
objvQxPrjMenusEN.RoleId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus.RoleName))
{
objvQxPrjMenusEN.RoleName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus.OrderNum))
{
objvQxPrjMenusEN.OrderNum = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(convQxPrjMenus.IsLeafNode))
{
objvQxPrjMenusEN.IsLeafNode = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(convQxPrjMenus.MenuSetId))
{
objvQxPrjMenusEN.MenuSetId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus.MenuSetName))
{
objvQxPrjMenusEN.MenuSetName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus.MenuTitle))
{
objvQxPrjMenusEN.MenuTitle = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus.PageDispModeId))
{
objvQxPrjMenusEN.PageDispModeId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus.PageDispModeName))
{
objvQxPrjMenusEN.PageDispModeName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus.InUse))
{
objvQxPrjMenusEN.InUse = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(convQxPrjMenus.MenuControlName))
{
objvQxPrjMenusEN.MenuControlName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus.ApplicationTypeId))
{
objvQxPrjMenusEN.ApplicationTypeId = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(convQxPrjMenus.ApplicationTypeName))
{
objvQxPrjMenusEN.ApplicationTypeName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus.UpdDate))
{
objvQxPrjMenusEN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus.UpdUserId))
{
objvQxPrjMenusEN.UpdUserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus.Memo))
{
objvQxPrjMenusEN.Memo = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus.UpMenuName))
{
objvQxPrjMenusEN.UpMenuName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus.SubMenusNum))
{
objvQxPrjMenusEN.SubMenusNum = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(convQxPrjMenus.RoleNum))
{
objvQxPrjMenusEN.RoleNum = reader.ReadElementContentAsInt();
}
}
return objvQxPrjMenusEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strvQxPrjMenusObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsvQxPrjMenusEN GetObjFromXmlStr(string strvQxPrjMenusObjXmlStr)
{
clsvQxPrjMenusEN objvQxPrjMenusEN = new clsvQxPrjMenusEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strvQxPrjMenusObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsvQxPrjMenusBL.itemXmlNode))
{
objvQxPrjMenusEN = GetObjFromXml(reader);
return objvQxPrjMenusEN;
}
}
return objvQxPrjMenusEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsvQxPrjMenusEN objvQxPrjMenusEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objvQxPrjMenusEN);
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
public static string Func(string strInFldName, string strOutFldName, string strMenuId)
{
if (strInFldName != convQxPrjMenus.MenuId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convQxPrjMenus.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convQxPrjMenus.AttributeName));
throw new Exception(strMsg);
}
var objvQxPrjMenus = clsvQxPrjMenusBL.GetObjByMenuIdCache(strMenuId);
if (objvQxPrjMenus == null) return "";
return objvQxPrjMenus[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsvQxPrjMenusEN objvQxPrjMenusEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsvQxPrjMenusEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objvQxPrjMenusEN[strField]);
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
 /// <param name = "lstvQxPrjMenusObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsvQxPrjMenusEN> lstvQxPrjMenusObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstvQxPrjMenusObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsvQxPrjMenusEN objvQxPrjMenusEN in lstvQxPrjMenusObjLst)
{
string strJSON_One = SerializeObjToJSON(objvQxPrjMenusEN);
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
int intRecCount = clsvQxPrjMenusDA.GetRecCount(strTabName);
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
int intRecCount = clsvQxPrjMenusDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvQxPrjMenusDA.GetRecCount();
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
int intRecCount = clsvQxPrjMenusDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvQxPrjMenusCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvQxPrjMenusEN objvQxPrjMenusCond)
{
List<clsvQxPrjMenusEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjMenusEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxPrjMenus.AttributeName)
{
if (objvQxPrjMenusCond.IsUpdated(strFldName) == false) continue;
if (objvQxPrjMenusCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjMenusCond[strFldName].ToString());
}
else
{
if (objvQxPrjMenusCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxPrjMenusCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjMenusCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxPrjMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxPrjMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxPrjMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxPrjMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxPrjMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxPrjMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxPrjMenusCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxPrjMenusCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxPrjMenusCond[strFldName]));
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
 List<string> arrList = clsvQxPrjMenusDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vQxPrjMenusDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vQxPrjMenusDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}