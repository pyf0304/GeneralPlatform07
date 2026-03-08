
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxRoleMenusBL
 表名:vQxRoleMenus(00140034)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 17:47:19
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
public static class  clsvQxRoleMenusBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxRoleMenusEN GetObj(this K_mId_vQxRoleMenus myKey)
{
clsvQxRoleMenusEN objvQxRoleMenusEN = clsvQxRoleMenusBL.vQxRoleMenusDA.GetObjBymId(myKey.Value);
return objvQxRoleMenusEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenusEN SetRoleId(this clsvQxRoleMenusEN objvQxRoleMenusEN, string strRoleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRoleId, 8, convQxRoleMenus.RoleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, convQxRoleMenus.RoleId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenusEN SetRoleName(this clsvQxRoleMenusEN objvQxRoleMenusEN, string strRoleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRoleName, convQxRoleMenus.RoleName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRoleName, 50, convQxRoleMenus.RoleName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenusEN SetQxPrjId(this clsvQxRoleMenusEN objvQxRoleMenusEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, convQxRoleMenus.QxPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxRoleMenus.QxPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxRoleMenus.QxPrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenusEN SetMenuId(this clsvQxRoleMenusEN objvQxRoleMenusEN, string strMenuId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMenuId, convQxRoleMenus.MenuId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuId, 8, convQxRoleMenus.MenuId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMenuId, 8, convQxRoleMenus.MenuId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenusEN SetMenuName(this clsvQxRoleMenusEN objvQxRoleMenusEN, string strMenuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMenuName, convQxRoleMenus.MenuName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuName, 50, convQxRoleMenus.MenuName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenusEN SetPrjName(this clsvQxRoleMenusEN objvQxRoleMenusEN, string strPrjName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convQxRoleMenus.PrjName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenusEN SetUpMenuId(this clsvQxRoleMenusEN objvQxRoleMenusEN, string strUpMenuId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpMenuId, 8, convQxRoleMenus.UpMenuId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUpMenuId, 8, convQxRoleMenus.UpMenuId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenusEN SetLinkFile(this clsvQxRoleMenusEN objvQxRoleMenusEN, string strLinkFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLinkFile, 500, convQxRoleMenus.LinkFile);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenusEN SetqsParameters(this clsvQxRoleMenusEN objvQxRoleMenusEN, string strqsParameters, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strqsParameters, 200, convQxRoleMenus.qsParameters);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenusEN SetImgFile(this clsvQxRoleMenusEN objvQxRoleMenusEN, string strImgFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strImgFile, 300, convQxRoleMenus.ImgFile);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenusEN SetOrderNum(this clsvQxRoleMenusEN objvQxRoleMenusEN, int? intOrderNum, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenusEN SetMenuSetId(this clsvQxRoleMenusEN objvQxRoleMenusEN, string strMenuSetId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuSetId, 4, convQxRoleMenus.MenuSetId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMenuSetId, 4, convQxRoleMenus.MenuSetId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenusEN SetMenuSetName(this clsvQxRoleMenusEN objvQxRoleMenusEN, string strMenuSetName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuSetName, 50, convQxRoleMenus.MenuSetName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenusEN SetMenuTitle(this clsvQxRoleMenusEN objvQxRoleMenusEN, string strMenuTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuTitle, 50, convQxRoleMenus.MenuTitle);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenusEN SetPageDispModeId(this clsvQxRoleMenusEN objvQxRoleMenusEN, string strPageDispModeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPageDispModeId, 2, convQxRoleMenus.PageDispModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPageDispModeId, 2, convQxRoleMenus.PageDispModeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenusEN SetPageDispModeName(this clsvQxRoleMenusEN objvQxRoleMenusEN, string strPageDispModeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPageDispModeName, 50, convQxRoleMenus.PageDispModeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenusEN SetUpMenuName(this clsvQxRoleMenusEN objvQxRoleMenusEN, string strUpMenuName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpMenuName, 30, convQxRoleMenus.UpMenuName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenusEN SetRoleNum(this clsvQxRoleMenusEN objvQxRoleMenusEN, int? intRoleNum, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenusEN SetUpdDate(this clsvQxRoleMenusEN objvQxRoleMenusEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convQxRoleMenus.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQxRoleMenus.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenusEN SetUpdUserId(this clsvQxRoleMenusEN objvQxRoleMenusEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUserId, convQxRoleMenus.UpdUserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convQxRoleMenus.UpdUserId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenusEN SetMemo(this clsvQxRoleMenusEN objvQxRoleMenusEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxRoleMenus.Memo);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvQxRoleMenusENS">源对象</param>
 /// <param name = "objvQxRoleMenusENT">目标对象</param>
 public static void CopyTo(this clsvQxRoleMenusEN objvQxRoleMenusENS, clsvQxRoleMenusEN objvQxRoleMenusENT)
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
 /// <param name = "objvQxRoleMenusENS">源对象</param>
 /// <returns>目标对象=>clsvQxRoleMenusEN:objvQxRoleMenusENT</returns>
 public static clsvQxRoleMenusEN CopyTo(this clsvQxRoleMenusEN objvQxRoleMenusENS)
{
try
{
 clsvQxRoleMenusEN objvQxRoleMenusENT = new clsvQxRoleMenusEN()
{
mId = objvQxRoleMenusENS.mId, //流水号
RoleId = objvQxRoleMenusENS.RoleId, //角色Id
RoleName = objvQxRoleMenusENS.RoleName, //角色名称
QxPrjId = objvQxRoleMenusENS.QxPrjId, //项目Id
MenuId = objvQxRoleMenusENS.MenuId, //菜单Id
MenuName = objvQxRoleMenusENS.MenuName, //菜单名
PrjName = objvQxRoleMenusENS.PrjName, //工程名
UpMenuId = objvQxRoleMenusENS.UpMenuId, //上级菜单Id
LinkFile = objvQxRoleMenusENS.LinkFile, //链接文件
qsParameters = objvQxRoleMenusENS.qsParameters, //qs参数
ImgFile = objvQxRoleMenusENS.ImgFile, //图像文件
OrderNum = objvQxRoleMenusENS.OrderNum, //排序号
IsLeafNode = objvQxRoleMenusENS.IsLeafNode, //是否叶子
MenuSetId = objvQxRoleMenusENS.MenuSetId, //菜单集Id
MenuSetName = objvQxRoleMenusENS.MenuSetName, //菜单集名称
MenuTitle = objvQxRoleMenusENS.MenuTitle, //菜单标题
PageDispModeId = objvQxRoleMenusENS.PageDispModeId, //页面显示模式Id
PageDispModeName = objvQxRoleMenusENS.PageDispModeName, //页面显示模式名称
InUse = objvQxRoleMenusENS.InUse, //是否在用
UpMenuName = objvQxRoleMenusENS.UpMenuName, //上级菜单名
RoleNum = objvQxRoleMenusENS.RoleNum, //角色数
IsDisp = objvQxRoleMenusENS.IsDisp, //是否显示
UpdDate = objvQxRoleMenusENS.UpdDate, //修改日期
UpdUserId = objvQxRoleMenusENS.UpdUserId, //修改用户Id
Memo = objvQxRoleMenusENS.Memo, //备注
};
 return objvQxRoleMenusENT;
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
public static void CheckProperty4Condition(this clsvQxRoleMenusEN objvQxRoleMenusEN)
{
 clsvQxRoleMenusBL.vQxRoleMenusDA.CheckProperty4Condition(objvQxRoleMenusEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vQxRoleMenus
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v角色菜单(vQxRoleMenus)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvQxRoleMenusBL
{
public static RelatedActions_vQxRoleMenus relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "vQxRoleMenusListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "vQxRoleMenusList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsvQxRoleMenusEN> arrvQxRoleMenusObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvQxRoleMenusDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvQxRoleMenusDA vQxRoleMenusDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvQxRoleMenusDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvQxRoleMenusBL()
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
if (string.IsNullOrEmpty(clsvQxRoleMenusEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxRoleMenusEN._ConnectString);
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
objDS = vQxRoleMenusDA.GetDataSet(strWhereCond);
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
objDS = vQxRoleMenusDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = vQxRoleMenusDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_vQxRoleMenus(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQxRoleMenusDA.GetDataTable_vQxRoleMenus(strWhereCond);
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
objDT = vQxRoleMenusDA.GetDataTable(strWhereCond);
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
objDT = vQxRoleMenusDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vQxRoleMenusDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vQxRoleMenusDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vQxRoleMenusDA.GetDataTable_Top(objTopPara);
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
objDT = vQxRoleMenusDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vQxRoleMenusDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = vQxRoleMenusDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vQxRoleMenusDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = vQxRoleMenusDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = vQxRoleMenusDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = vQxRoleMenusDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = vQxRoleMenusDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
public static List<clsvQxRoleMenusEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvQxRoleMenusEN> arrObjLst = new List<clsvQxRoleMenusEN>(); 
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
	clsvQxRoleMenusEN objvQxRoleMenusEN = new clsvQxRoleMenusEN();
try
{
objvQxRoleMenusEN.mId = Int32.Parse(objRow[convQxRoleMenus.mId].ToString().Trim()); //流水号
objvQxRoleMenusEN.RoleId = objRow[convQxRoleMenus.RoleId] == DBNull.Value ? null : objRow[convQxRoleMenus.RoleId].ToString().Trim(); //角色Id
objvQxRoleMenusEN.RoleName = objRow[convQxRoleMenus.RoleName].ToString().Trim(); //角色名称
objvQxRoleMenusEN.QxPrjId = objRow[convQxRoleMenus.QxPrjId].ToString().Trim(); //项目Id
objvQxRoleMenusEN.MenuId = objRow[convQxRoleMenus.MenuId].ToString().Trim(); //菜单Id
objvQxRoleMenusEN.MenuName = objRow[convQxRoleMenus.MenuName].ToString().Trim(); //菜单名
objvQxRoleMenusEN.PrjName = objRow[convQxRoleMenus.PrjName] == DBNull.Value ? null : objRow[convQxRoleMenus.PrjName].ToString().Trim(); //工程名
objvQxRoleMenusEN.UpMenuId = objRow[convQxRoleMenus.UpMenuId] == DBNull.Value ? null : objRow[convQxRoleMenus.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxRoleMenusEN.LinkFile = objRow[convQxRoleMenus.LinkFile] == DBNull.Value ? null : objRow[convQxRoleMenus.LinkFile].ToString().Trim(); //链接文件
objvQxRoleMenusEN.qsParameters = objRow[convQxRoleMenus.qsParameters] == DBNull.Value ? null : objRow[convQxRoleMenus.qsParameters].ToString().Trim(); //qs参数
objvQxRoleMenusEN.ImgFile = objRow[convQxRoleMenus.ImgFile] == DBNull.Value ? null : objRow[convQxRoleMenus.ImgFile].ToString().Trim(); //图像文件
objvQxRoleMenusEN.OrderNum = objRow[convQxRoleMenus.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRoleMenus.OrderNum].ToString().Trim()); //排序号
objvQxRoleMenusEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus.IsLeafNode].ToString().Trim()); //是否叶子
objvQxRoleMenusEN.MenuSetId = objRow[convQxRoleMenus.MenuSetId] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuSetId].ToString().Trim(); //菜单集Id
objvQxRoleMenusEN.MenuSetName = objRow[convQxRoleMenus.MenuSetName] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuSetName].ToString().Trim(); //菜单集名称
objvQxRoleMenusEN.MenuTitle = objRow[convQxRoleMenus.MenuTitle] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuTitle].ToString().Trim(); //菜单标题
objvQxRoleMenusEN.PageDispModeId = objRow[convQxRoleMenus.PageDispModeId] == DBNull.Value ? null : objRow[convQxRoleMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxRoleMenusEN.PageDispModeName = objRow[convQxRoleMenus.PageDispModeName] == DBNull.Value ? null : objRow[convQxRoleMenus.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxRoleMenusEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus.InUse].ToString().Trim()); //是否在用
objvQxRoleMenusEN.UpMenuName = objRow[convQxRoleMenus.UpMenuName] == DBNull.Value ? null : objRow[convQxRoleMenus.UpMenuName].ToString().Trim(); //上级菜单名
objvQxRoleMenusEN.RoleNum = objRow[convQxRoleMenus.RoleNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRoleMenus.RoleNum].ToString().Trim()); //角色数
objvQxRoleMenusEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus.IsDisp].ToString().Trim()); //是否显示
objvQxRoleMenusEN.UpdDate = objRow[convQxRoleMenus.UpdDate].ToString().Trim(); //修改日期
objvQxRoleMenusEN.UpdUserId = objRow[convQxRoleMenus.UpdUserId].ToString().Trim(); //修改用户Id
objvQxRoleMenusEN.Memo = objRow[convQxRoleMenus.Memo] == DBNull.Value ? null : objRow[convQxRoleMenus.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRoleMenusEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRoleMenusEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvQxRoleMenusEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvQxRoleMenusEN._CurrTabName);
List<clsvQxRoleMenusEN> arrvQxRoleMenusObjLstCache = GetObjLstCache();
IEnumerable <clsvQxRoleMenusEN> arrvQxRoleMenusObjLst_Sel =
arrvQxRoleMenusObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvQxRoleMenusObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxRoleMenusEN> GetObjLst(string strWhereCond)
{
List<clsvQxRoleMenusEN> arrObjLst = new List<clsvQxRoleMenusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRoleMenusEN objvQxRoleMenusEN = new clsvQxRoleMenusEN();
try
{
objvQxRoleMenusEN.mId = Int32.Parse(objRow[convQxRoleMenus.mId].ToString().Trim()); //流水号
objvQxRoleMenusEN.RoleId = objRow[convQxRoleMenus.RoleId] == DBNull.Value ? null : objRow[convQxRoleMenus.RoleId].ToString().Trim(); //角色Id
objvQxRoleMenusEN.RoleName = objRow[convQxRoleMenus.RoleName].ToString().Trim(); //角色名称
objvQxRoleMenusEN.QxPrjId = objRow[convQxRoleMenus.QxPrjId].ToString().Trim(); //项目Id
objvQxRoleMenusEN.MenuId = objRow[convQxRoleMenus.MenuId].ToString().Trim(); //菜单Id
objvQxRoleMenusEN.MenuName = objRow[convQxRoleMenus.MenuName].ToString().Trim(); //菜单名
objvQxRoleMenusEN.PrjName = objRow[convQxRoleMenus.PrjName] == DBNull.Value ? null : objRow[convQxRoleMenus.PrjName].ToString().Trim(); //工程名
objvQxRoleMenusEN.UpMenuId = objRow[convQxRoleMenus.UpMenuId] == DBNull.Value ? null : objRow[convQxRoleMenus.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxRoleMenusEN.LinkFile = objRow[convQxRoleMenus.LinkFile] == DBNull.Value ? null : objRow[convQxRoleMenus.LinkFile].ToString().Trim(); //链接文件
objvQxRoleMenusEN.qsParameters = objRow[convQxRoleMenus.qsParameters] == DBNull.Value ? null : objRow[convQxRoleMenus.qsParameters].ToString().Trim(); //qs参数
objvQxRoleMenusEN.ImgFile = objRow[convQxRoleMenus.ImgFile] == DBNull.Value ? null : objRow[convQxRoleMenus.ImgFile].ToString().Trim(); //图像文件
objvQxRoleMenusEN.OrderNum = objRow[convQxRoleMenus.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRoleMenus.OrderNum].ToString().Trim()); //排序号
objvQxRoleMenusEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus.IsLeafNode].ToString().Trim()); //是否叶子
objvQxRoleMenusEN.MenuSetId = objRow[convQxRoleMenus.MenuSetId] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuSetId].ToString().Trim(); //菜单集Id
objvQxRoleMenusEN.MenuSetName = objRow[convQxRoleMenus.MenuSetName] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuSetName].ToString().Trim(); //菜单集名称
objvQxRoleMenusEN.MenuTitle = objRow[convQxRoleMenus.MenuTitle] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuTitle].ToString().Trim(); //菜单标题
objvQxRoleMenusEN.PageDispModeId = objRow[convQxRoleMenus.PageDispModeId] == DBNull.Value ? null : objRow[convQxRoleMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxRoleMenusEN.PageDispModeName = objRow[convQxRoleMenus.PageDispModeName] == DBNull.Value ? null : objRow[convQxRoleMenus.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxRoleMenusEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus.InUse].ToString().Trim()); //是否在用
objvQxRoleMenusEN.UpMenuName = objRow[convQxRoleMenus.UpMenuName] == DBNull.Value ? null : objRow[convQxRoleMenus.UpMenuName].ToString().Trim(); //上级菜单名
objvQxRoleMenusEN.RoleNum = objRow[convQxRoleMenus.RoleNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRoleMenus.RoleNum].ToString().Trim()); //角色数
objvQxRoleMenusEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus.IsDisp].ToString().Trim()); //是否显示
objvQxRoleMenusEN.UpdDate = objRow[convQxRoleMenus.UpdDate].ToString().Trim(); //修改日期
objvQxRoleMenusEN.UpdUserId = objRow[convQxRoleMenus.UpdUserId].ToString().Trim(); //修改用户Id
objvQxRoleMenusEN.Memo = objRow[convQxRoleMenus.Memo] == DBNull.Value ? null : objRow[convQxRoleMenus.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRoleMenusEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRoleMenusEN);
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
public static List<clsvQxRoleMenusEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQxRoleMenusEN> arrObjLst = new List<clsvQxRoleMenusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRoleMenusEN objvQxRoleMenusEN = new clsvQxRoleMenusEN();
try
{
objvQxRoleMenusEN.mId = Int32.Parse(objRow[convQxRoleMenus.mId].ToString().Trim()); //流水号
objvQxRoleMenusEN.RoleId = objRow[convQxRoleMenus.RoleId] == DBNull.Value ? null : objRow[convQxRoleMenus.RoleId].ToString().Trim(); //角色Id
objvQxRoleMenusEN.RoleName = objRow[convQxRoleMenus.RoleName].ToString().Trim(); //角色名称
objvQxRoleMenusEN.QxPrjId = objRow[convQxRoleMenus.QxPrjId].ToString().Trim(); //项目Id
objvQxRoleMenusEN.MenuId = objRow[convQxRoleMenus.MenuId].ToString().Trim(); //菜单Id
objvQxRoleMenusEN.MenuName = objRow[convQxRoleMenus.MenuName].ToString().Trim(); //菜单名
objvQxRoleMenusEN.PrjName = objRow[convQxRoleMenus.PrjName] == DBNull.Value ? null : objRow[convQxRoleMenus.PrjName].ToString().Trim(); //工程名
objvQxRoleMenusEN.UpMenuId = objRow[convQxRoleMenus.UpMenuId] == DBNull.Value ? null : objRow[convQxRoleMenus.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxRoleMenusEN.LinkFile = objRow[convQxRoleMenus.LinkFile] == DBNull.Value ? null : objRow[convQxRoleMenus.LinkFile].ToString().Trim(); //链接文件
objvQxRoleMenusEN.qsParameters = objRow[convQxRoleMenus.qsParameters] == DBNull.Value ? null : objRow[convQxRoleMenus.qsParameters].ToString().Trim(); //qs参数
objvQxRoleMenusEN.ImgFile = objRow[convQxRoleMenus.ImgFile] == DBNull.Value ? null : objRow[convQxRoleMenus.ImgFile].ToString().Trim(); //图像文件
objvQxRoleMenusEN.OrderNum = objRow[convQxRoleMenus.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRoleMenus.OrderNum].ToString().Trim()); //排序号
objvQxRoleMenusEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus.IsLeafNode].ToString().Trim()); //是否叶子
objvQxRoleMenusEN.MenuSetId = objRow[convQxRoleMenus.MenuSetId] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuSetId].ToString().Trim(); //菜单集Id
objvQxRoleMenusEN.MenuSetName = objRow[convQxRoleMenus.MenuSetName] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuSetName].ToString().Trim(); //菜单集名称
objvQxRoleMenusEN.MenuTitle = objRow[convQxRoleMenus.MenuTitle] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuTitle].ToString().Trim(); //菜单标题
objvQxRoleMenusEN.PageDispModeId = objRow[convQxRoleMenus.PageDispModeId] == DBNull.Value ? null : objRow[convQxRoleMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxRoleMenusEN.PageDispModeName = objRow[convQxRoleMenus.PageDispModeName] == DBNull.Value ? null : objRow[convQxRoleMenus.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxRoleMenusEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus.InUse].ToString().Trim()); //是否在用
objvQxRoleMenusEN.UpMenuName = objRow[convQxRoleMenus.UpMenuName] == DBNull.Value ? null : objRow[convQxRoleMenus.UpMenuName].ToString().Trim(); //上级菜单名
objvQxRoleMenusEN.RoleNum = objRow[convQxRoleMenus.RoleNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRoleMenus.RoleNum].ToString().Trim()); //角色数
objvQxRoleMenusEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus.IsDisp].ToString().Trim()); //是否显示
objvQxRoleMenusEN.UpdDate = objRow[convQxRoleMenus.UpdDate].ToString().Trim(); //修改日期
objvQxRoleMenusEN.UpdUserId = objRow[convQxRoleMenus.UpdUserId].ToString().Trim(); //修改用户Id
objvQxRoleMenusEN.Memo = objRow[convQxRoleMenus.Memo] == DBNull.Value ? null : objRow[convQxRoleMenus.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRoleMenusEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRoleMenusEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvQxRoleMenusCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvQxRoleMenusEN> GetSubObjLstCache(clsvQxRoleMenusEN objvQxRoleMenusCond)
{
List<clsvQxRoleMenusEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxRoleMenusEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxRoleMenus.AttributeName)
{
if (objvQxRoleMenusCond.IsUpdated(strFldName) == false) continue;
if (objvQxRoleMenusCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxRoleMenusCond[strFldName].ToString());
}
else
{
if (objvQxRoleMenusCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxRoleMenusCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxRoleMenusCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxRoleMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxRoleMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxRoleMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxRoleMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxRoleMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxRoleMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxRoleMenusCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxRoleMenusCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxRoleMenusCond[strFldName]));
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
public static List<clsvQxRoleMenusEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvQxRoleMenusEN> arrObjLst = new List<clsvQxRoleMenusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRoleMenusEN objvQxRoleMenusEN = new clsvQxRoleMenusEN();
try
{
objvQxRoleMenusEN.mId = Int32.Parse(objRow[convQxRoleMenus.mId].ToString().Trim()); //流水号
objvQxRoleMenusEN.RoleId = objRow[convQxRoleMenus.RoleId] == DBNull.Value ? null : objRow[convQxRoleMenus.RoleId].ToString().Trim(); //角色Id
objvQxRoleMenusEN.RoleName = objRow[convQxRoleMenus.RoleName].ToString().Trim(); //角色名称
objvQxRoleMenusEN.QxPrjId = objRow[convQxRoleMenus.QxPrjId].ToString().Trim(); //项目Id
objvQxRoleMenusEN.MenuId = objRow[convQxRoleMenus.MenuId].ToString().Trim(); //菜单Id
objvQxRoleMenusEN.MenuName = objRow[convQxRoleMenus.MenuName].ToString().Trim(); //菜单名
objvQxRoleMenusEN.PrjName = objRow[convQxRoleMenus.PrjName] == DBNull.Value ? null : objRow[convQxRoleMenus.PrjName].ToString().Trim(); //工程名
objvQxRoleMenusEN.UpMenuId = objRow[convQxRoleMenus.UpMenuId] == DBNull.Value ? null : objRow[convQxRoleMenus.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxRoleMenusEN.LinkFile = objRow[convQxRoleMenus.LinkFile] == DBNull.Value ? null : objRow[convQxRoleMenus.LinkFile].ToString().Trim(); //链接文件
objvQxRoleMenusEN.qsParameters = objRow[convQxRoleMenus.qsParameters] == DBNull.Value ? null : objRow[convQxRoleMenus.qsParameters].ToString().Trim(); //qs参数
objvQxRoleMenusEN.ImgFile = objRow[convQxRoleMenus.ImgFile] == DBNull.Value ? null : objRow[convQxRoleMenus.ImgFile].ToString().Trim(); //图像文件
objvQxRoleMenusEN.OrderNum = objRow[convQxRoleMenus.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRoleMenus.OrderNum].ToString().Trim()); //排序号
objvQxRoleMenusEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus.IsLeafNode].ToString().Trim()); //是否叶子
objvQxRoleMenusEN.MenuSetId = objRow[convQxRoleMenus.MenuSetId] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuSetId].ToString().Trim(); //菜单集Id
objvQxRoleMenusEN.MenuSetName = objRow[convQxRoleMenus.MenuSetName] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuSetName].ToString().Trim(); //菜单集名称
objvQxRoleMenusEN.MenuTitle = objRow[convQxRoleMenus.MenuTitle] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuTitle].ToString().Trim(); //菜单标题
objvQxRoleMenusEN.PageDispModeId = objRow[convQxRoleMenus.PageDispModeId] == DBNull.Value ? null : objRow[convQxRoleMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxRoleMenusEN.PageDispModeName = objRow[convQxRoleMenus.PageDispModeName] == DBNull.Value ? null : objRow[convQxRoleMenus.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxRoleMenusEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus.InUse].ToString().Trim()); //是否在用
objvQxRoleMenusEN.UpMenuName = objRow[convQxRoleMenus.UpMenuName] == DBNull.Value ? null : objRow[convQxRoleMenus.UpMenuName].ToString().Trim(); //上级菜单名
objvQxRoleMenusEN.RoleNum = objRow[convQxRoleMenus.RoleNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRoleMenus.RoleNum].ToString().Trim()); //角色数
objvQxRoleMenusEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus.IsDisp].ToString().Trim()); //是否显示
objvQxRoleMenusEN.UpdDate = objRow[convQxRoleMenus.UpdDate].ToString().Trim(); //修改日期
objvQxRoleMenusEN.UpdUserId = objRow[convQxRoleMenus.UpdUserId].ToString().Trim(); //修改用户Id
objvQxRoleMenusEN.Memo = objRow[convQxRoleMenus.Memo] == DBNull.Value ? null : objRow[convQxRoleMenus.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRoleMenusEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRoleMenusEN);
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
public static List<clsvQxRoleMenusEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvQxRoleMenusEN> arrObjLst = new List<clsvQxRoleMenusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRoleMenusEN objvQxRoleMenusEN = new clsvQxRoleMenusEN();
try
{
objvQxRoleMenusEN.mId = Int32.Parse(objRow[convQxRoleMenus.mId].ToString().Trim()); //流水号
objvQxRoleMenusEN.RoleId = objRow[convQxRoleMenus.RoleId] == DBNull.Value ? null : objRow[convQxRoleMenus.RoleId].ToString().Trim(); //角色Id
objvQxRoleMenusEN.RoleName = objRow[convQxRoleMenus.RoleName].ToString().Trim(); //角色名称
objvQxRoleMenusEN.QxPrjId = objRow[convQxRoleMenus.QxPrjId].ToString().Trim(); //项目Id
objvQxRoleMenusEN.MenuId = objRow[convQxRoleMenus.MenuId].ToString().Trim(); //菜单Id
objvQxRoleMenusEN.MenuName = objRow[convQxRoleMenus.MenuName].ToString().Trim(); //菜单名
objvQxRoleMenusEN.PrjName = objRow[convQxRoleMenus.PrjName] == DBNull.Value ? null : objRow[convQxRoleMenus.PrjName].ToString().Trim(); //工程名
objvQxRoleMenusEN.UpMenuId = objRow[convQxRoleMenus.UpMenuId] == DBNull.Value ? null : objRow[convQxRoleMenus.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxRoleMenusEN.LinkFile = objRow[convQxRoleMenus.LinkFile] == DBNull.Value ? null : objRow[convQxRoleMenus.LinkFile].ToString().Trim(); //链接文件
objvQxRoleMenusEN.qsParameters = objRow[convQxRoleMenus.qsParameters] == DBNull.Value ? null : objRow[convQxRoleMenus.qsParameters].ToString().Trim(); //qs参数
objvQxRoleMenusEN.ImgFile = objRow[convQxRoleMenus.ImgFile] == DBNull.Value ? null : objRow[convQxRoleMenus.ImgFile].ToString().Trim(); //图像文件
objvQxRoleMenusEN.OrderNum = objRow[convQxRoleMenus.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRoleMenus.OrderNum].ToString().Trim()); //排序号
objvQxRoleMenusEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus.IsLeafNode].ToString().Trim()); //是否叶子
objvQxRoleMenusEN.MenuSetId = objRow[convQxRoleMenus.MenuSetId] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuSetId].ToString().Trim(); //菜单集Id
objvQxRoleMenusEN.MenuSetName = objRow[convQxRoleMenus.MenuSetName] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuSetName].ToString().Trim(); //菜单集名称
objvQxRoleMenusEN.MenuTitle = objRow[convQxRoleMenus.MenuTitle] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuTitle].ToString().Trim(); //菜单标题
objvQxRoleMenusEN.PageDispModeId = objRow[convQxRoleMenus.PageDispModeId] == DBNull.Value ? null : objRow[convQxRoleMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxRoleMenusEN.PageDispModeName = objRow[convQxRoleMenus.PageDispModeName] == DBNull.Value ? null : objRow[convQxRoleMenus.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxRoleMenusEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus.InUse].ToString().Trim()); //是否在用
objvQxRoleMenusEN.UpMenuName = objRow[convQxRoleMenus.UpMenuName] == DBNull.Value ? null : objRow[convQxRoleMenus.UpMenuName].ToString().Trim(); //上级菜单名
objvQxRoleMenusEN.RoleNum = objRow[convQxRoleMenus.RoleNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRoleMenus.RoleNum].ToString().Trim()); //角色数
objvQxRoleMenusEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus.IsDisp].ToString().Trim()); //是否显示
objvQxRoleMenusEN.UpdDate = objRow[convQxRoleMenus.UpdDate].ToString().Trim(); //修改日期
objvQxRoleMenusEN.UpdUserId = objRow[convQxRoleMenus.UpdUserId].ToString().Trim(); //修改用户Id
objvQxRoleMenusEN.Memo = objRow[convQxRoleMenus.Memo] == DBNull.Value ? null : objRow[convQxRoleMenus.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRoleMenusEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRoleMenusEN);
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
List<clsvQxRoleMenusEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvQxRoleMenusEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxRoleMenusEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvQxRoleMenusEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvQxRoleMenusEN> arrObjLst = new List<clsvQxRoleMenusEN>(); 
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
	clsvQxRoleMenusEN objvQxRoleMenusEN = new clsvQxRoleMenusEN();
try
{
objvQxRoleMenusEN.mId = Int32.Parse(objRow[convQxRoleMenus.mId].ToString().Trim()); //流水号
objvQxRoleMenusEN.RoleId = objRow[convQxRoleMenus.RoleId] == DBNull.Value ? null : objRow[convQxRoleMenus.RoleId].ToString().Trim(); //角色Id
objvQxRoleMenusEN.RoleName = objRow[convQxRoleMenus.RoleName].ToString().Trim(); //角色名称
objvQxRoleMenusEN.QxPrjId = objRow[convQxRoleMenus.QxPrjId].ToString().Trim(); //项目Id
objvQxRoleMenusEN.MenuId = objRow[convQxRoleMenus.MenuId].ToString().Trim(); //菜单Id
objvQxRoleMenusEN.MenuName = objRow[convQxRoleMenus.MenuName].ToString().Trim(); //菜单名
objvQxRoleMenusEN.PrjName = objRow[convQxRoleMenus.PrjName] == DBNull.Value ? null : objRow[convQxRoleMenus.PrjName].ToString().Trim(); //工程名
objvQxRoleMenusEN.UpMenuId = objRow[convQxRoleMenus.UpMenuId] == DBNull.Value ? null : objRow[convQxRoleMenus.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxRoleMenusEN.LinkFile = objRow[convQxRoleMenus.LinkFile] == DBNull.Value ? null : objRow[convQxRoleMenus.LinkFile].ToString().Trim(); //链接文件
objvQxRoleMenusEN.qsParameters = objRow[convQxRoleMenus.qsParameters] == DBNull.Value ? null : objRow[convQxRoleMenus.qsParameters].ToString().Trim(); //qs参数
objvQxRoleMenusEN.ImgFile = objRow[convQxRoleMenus.ImgFile] == DBNull.Value ? null : objRow[convQxRoleMenus.ImgFile].ToString().Trim(); //图像文件
objvQxRoleMenusEN.OrderNum = objRow[convQxRoleMenus.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRoleMenus.OrderNum].ToString().Trim()); //排序号
objvQxRoleMenusEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus.IsLeafNode].ToString().Trim()); //是否叶子
objvQxRoleMenusEN.MenuSetId = objRow[convQxRoleMenus.MenuSetId] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuSetId].ToString().Trim(); //菜单集Id
objvQxRoleMenusEN.MenuSetName = objRow[convQxRoleMenus.MenuSetName] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuSetName].ToString().Trim(); //菜单集名称
objvQxRoleMenusEN.MenuTitle = objRow[convQxRoleMenus.MenuTitle] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuTitle].ToString().Trim(); //菜单标题
objvQxRoleMenusEN.PageDispModeId = objRow[convQxRoleMenus.PageDispModeId] == DBNull.Value ? null : objRow[convQxRoleMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxRoleMenusEN.PageDispModeName = objRow[convQxRoleMenus.PageDispModeName] == DBNull.Value ? null : objRow[convQxRoleMenus.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxRoleMenusEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus.InUse].ToString().Trim()); //是否在用
objvQxRoleMenusEN.UpMenuName = objRow[convQxRoleMenus.UpMenuName] == DBNull.Value ? null : objRow[convQxRoleMenus.UpMenuName].ToString().Trim(); //上级菜单名
objvQxRoleMenusEN.RoleNum = objRow[convQxRoleMenus.RoleNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRoleMenus.RoleNum].ToString().Trim()); //角色数
objvQxRoleMenusEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus.IsDisp].ToString().Trim()); //是否显示
objvQxRoleMenusEN.UpdDate = objRow[convQxRoleMenus.UpdDate].ToString().Trim(); //修改日期
objvQxRoleMenusEN.UpdUserId = objRow[convQxRoleMenus.UpdUserId].ToString().Trim(); //修改用户Id
objvQxRoleMenusEN.Memo = objRow[convQxRoleMenus.Memo] == DBNull.Value ? null : objRow[convQxRoleMenus.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRoleMenusEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRoleMenusEN);
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
public static List<clsvQxRoleMenusEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvQxRoleMenusEN> arrObjLst = new List<clsvQxRoleMenusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRoleMenusEN objvQxRoleMenusEN = new clsvQxRoleMenusEN();
try
{
objvQxRoleMenusEN.mId = Int32.Parse(objRow[convQxRoleMenus.mId].ToString().Trim()); //流水号
objvQxRoleMenusEN.RoleId = objRow[convQxRoleMenus.RoleId] == DBNull.Value ? null : objRow[convQxRoleMenus.RoleId].ToString().Trim(); //角色Id
objvQxRoleMenusEN.RoleName = objRow[convQxRoleMenus.RoleName].ToString().Trim(); //角色名称
objvQxRoleMenusEN.QxPrjId = objRow[convQxRoleMenus.QxPrjId].ToString().Trim(); //项目Id
objvQxRoleMenusEN.MenuId = objRow[convQxRoleMenus.MenuId].ToString().Trim(); //菜单Id
objvQxRoleMenusEN.MenuName = objRow[convQxRoleMenus.MenuName].ToString().Trim(); //菜单名
objvQxRoleMenusEN.PrjName = objRow[convQxRoleMenus.PrjName] == DBNull.Value ? null : objRow[convQxRoleMenus.PrjName].ToString().Trim(); //工程名
objvQxRoleMenusEN.UpMenuId = objRow[convQxRoleMenus.UpMenuId] == DBNull.Value ? null : objRow[convQxRoleMenus.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxRoleMenusEN.LinkFile = objRow[convQxRoleMenus.LinkFile] == DBNull.Value ? null : objRow[convQxRoleMenus.LinkFile].ToString().Trim(); //链接文件
objvQxRoleMenusEN.qsParameters = objRow[convQxRoleMenus.qsParameters] == DBNull.Value ? null : objRow[convQxRoleMenus.qsParameters].ToString().Trim(); //qs参数
objvQxRoleMenusEN.ImgFile = objRow[convQxRoleMenus.ImgFile] == DBNull.Value ? null : objRow[convQxRoleMenus.ImgFile].ToString().Trim(); //图像文件
objvQxRoleMenusEN.OrderNum = objRow[convQxRoleMenus.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRoleMenus.OrderNum].ToString().Trim()); //排序号
objvQxRoleMenusEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus.IsLeafNode].ToString().Trim()); //是否叶子
objvQxRoleMenusEN.MenuSetId = objRow[convQxRoleMenus.MenuSetId] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuSetId].ToString().Trim(); //菜单集Id
objvQxRoleMenusEN.MenuSetName = objRow[convQxRoleMenus.MenuSetName] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuSetName].ToString().Trim(); //菜单集名称
objvQxRoleMenusEN.MenuTitle = objRow[convQxRoleMenus.MenuTitle] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuTitle].ToString().Trim(); //菜单标题
objvQxRoleMenusEN.PageDispModeId = objRow[convQxRoleMenus.PageDispModeId] == DBNull.Value ? null : objRow[convQxRoleMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxRoleMenusEN.PageDispModeName = objRow[convQxRoleMenus.PageDispModeName] == DBNull.Value ? null : objRow[convQxRoleMenus.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxRoleMenusEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus.InUse].ToString().Trim()); //是否在用
objvQxRoleMenusEN.UpMenuName = objRow[convQxRoleMenus.UpMenuName] == DBNull.Value ? null : objRow[convQxRoleMenus.UpMenuName].ToString().Trim(); //上级菜单名
objvQxRoleMenusEN.RoleNum = objRow[convQxRoleMenus.RoleNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRoleMenus.RoleNum].ToString().Trim()); //角色数
objvQxRoleMenusEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus.IsDisp].ToString().Trim()); //是否显示
objvQxRoleMenusEN.UpdDate = objRow[convQxRoleMenus.UpdDate].ToString().Trim(); //修改日期
objvQxRoleMenusEN.UpdUserId = objRow[convQxRoleMenus.UpdUserId].ToString().Trim(); //修改用户Id
objvQxRoleMenusEN.Memo = objRow[convQxRoleMenus.Memo] == DBNull.Value ? null : objRow[convQxRoleMenus.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRoleMenusEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRoleMenusEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQxRoleMenusEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvQxRoleMenusEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvQxRoleMenusEN> arrObjLst = new List<clsvQxRoleMenusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRoleMenusEN objvQxRoleMenusEN = new clsvQxRoleMenusEN();
try
{
objvQxRoleMenusEN.mId = Int32.Parse(objRow[convQxRoleMenus.mId].ToString().Trim()); //流水号
objvQxRoleMenusEN.RoleId = objRow[convQxRoleMenus.RoleId] == DBNull.Value ? null : objRow[convQxRoleMenus.RoleId].ToString().Trim(); //角色Id
objvQxRoleMenusEN.RoleName = objRow[convQxRoleMenus.RoleName].ToString().Trim(); //角色名称
objvQxRoleMenusEN.QxPrjId = objRow[convQxRoleMenus.QxPrjId].ToString().Trim(); //项目Id
objvQxRoleMenusEN.MenuId = objRow[convQxRoleMenus.MenuId].ToString().Trim(); //菜单Id
objvQxRoleMenusEN.MenuName = objRow[convQxRoleMenus.MenuName].ToString().Trim(); //菜单名
objvQxRoleMenusEN.PrjName = objRow[convQxRoleMenus.PrjName] == DBNull.Value ? null : objRow[convQxRoleMenus.PrjName].ToString().Trim(); //工程名
objvQxRoleMenusEN.UpMenuId = objRow[convQxRoleMenus.UpMenuId] == DBNull.Value ? null : objRow[convQxRoleMenus.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxRoleMenusEN.LinkFile = objRow[convQxRoleMenus.LinkFile] == DBNull.Value ? null : objRow[convQxRoleMenus.LinkFile].ToString().Trim(); //链接文件
objvQxRoleMenusEN.qsParameters = objRow[convQxRoleMenus.qsParameters] == DBNull.Value ? null : objRow[convQxRoleMenus.qsParameters].ToString().Trim(); //qs参数
objvQxRoleMenusEN.ImgFile = objRow[convQxRoleMenus.ImgFile] == DBNull.Value ? null : objRow[convQxRoleMenus.ImgFile].ToString().Trim(); //图像文件
objvQxRoleMenusEN.OrderNum = objRow[convQxRoleMenus.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRoleMenus.OrderNum].ToString().Trim()); //排序号
objvQxRoleMenusEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus.IsLeafNode].ToString().Trim()); //是否叶子
objvQxRoleMenusEN.MenuSetId = objRow[convQxRoleMenus.MenuSetId] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuSetId].ToString().Trim(); //菜单集Id
objvQxRoleMenusEN.MenuSetName = objRow[convQxRoleMenus.MenuSetName] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuSetName].ToString().Trim(); //菜单集名称
objvQxRoleMenusEN.MenuTitle = objRow[convQxRoleMenus.MenuTitle] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuTitle].ToString().Trim(); //菜单标题
objvQxRoleMenusEN.PageDispModeId = objRow[convQxRoleMenus.PageDispModeId] == DBNull.Value ? null : objRow[convQxRoleMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxRoleMenusEN.PageDispModeName = objRow[convQxRoleMenus.PageDispModeName] == DBNull.Value ? null : objRow[convQxRoleMenus.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxRoleMenusEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus.InUse].ToString().Trim()); //是否在用
objvQxRoleMenusEN.UpMenuName = objRow[convQxRoleMenus.UpMenuName] == DBNull.Value ? null : objRow[convQxRoleMenus.UpMenuName].ToString().Trim(); //上级菜单名
objvQxRoleMenusEN.RoleNum = objRow[convQxRoleMenus.RoleNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRoleMenus.RoleNum].ToString().Trim()); //角色数
objvQxRoleMenusEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus.IsDisp].ToString().Trim()); //是否显示
objvQxRoleMenusEN.UpdDate = objRow[convQxRoleMenus.UpdDate].ToString().Trim(); //修改日期
objvQxRoleMenusEN.UpdUserId = objRow[convQxRoleMenus.UpdUserId].ToString().Trim(); //修改用户Id
objvQxRoleMenusEN.Memo = objRow[convQxRoleMenus.Memo] == DBNull.Value ? null : objRow[convQxRoleMenus.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRoleMenusEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRoleMenusEN);
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
public static List<clsvQxRoleMenusEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvQxRoleMenusEN> arrObjLst = new List<clsvQxRoleMenusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRoleMenusEN objvQxRoleMenusEN = new clsvQxRoleMenusEN();
try
{
objvQxRoleMenusEN.mId = Int32.Parse(objRow[convQxRoleMenus.mId].ToString().Trim()); //流水号
objvQxRoleMenusEN.RoleId = objRow[convQxRoleMenus.RoleId] == DBNull.Value ? null : objRow[convQxRoleMenus.RoleId].ToString().Trim(); //角色Id
objvQxRoleMenusEN.RoleName = objRow[convQxRoleMenus.RoleName].ToString().Trim(); //角色名称
objvQxRoleMenusEN.QxPrjId = objRow[convQxRoleMenus.QxPrjId].ToString().Trim(); //项目Id
objvQxRoleMenusEN.MenuId = objRow[convQxRoleMenus.MenuId].ToString().Trim(); //菜单Id
objvQxRoleMenusEN.MenuName = objRow[convQxRoleMenus.MenuName].ToString().Trim(); //菜单名
objvQxRoleMenusEN.PrjName = objRow[convQxRoleMenus.PrjName] == DBNull.Value ? null : objRow[convQxRoleMenus.PrjName].ToString().Trim(); //工程名
objvQxRoleMenusEN.UpMenuId = objRow[convQxRoleMenus.UpMenuId] == DBNull.Value ? null : objRow[convQxRoleMenus.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxRoleMenusEN.LinkFile = objRow[convQxRoleMenus.LinkFile] == DBNull.Value ? null : objRow[convQxRoleMenus.LinkFile].ToString().Trim(); //链接文件
objvQxRoleMenusEN.qsParameters = objRow[convQxRoleMenus.qsParameters] == DBNull.Value ? null : objRow[convQxRoleMenus.qsParameters].ToString().Trim(); //qs参数
objvQxRoleMenusEN.ImgFile = objRow[convQxRoleMenus.ImgFile] == DBNull.Value ? null : objRow[convQxRoleMenus.ImgFile].ToString().Trim(); //图像文件
objvQxRoleMenusEN.OrderNum = objRow[convQxRoleMenus.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRoleMenus.OrderNum].ToString().Trim()); //排序号
objvQxRoleMenusEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus.IsLeafNode].ToString().Trim()); //是否叶子
objvQxRoleMenusEN.MenuSetId = objRow[convQxRoleMenus.MenuSetId] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuSetId].ToString().Trim(); //菜单集Id
objvQxRoleMenusEN.MenuSetName = objRow[convQxRoleMenus.MenuSetName] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuSetName].ToString().Trim(); //菜单集名称
objvQxRoleMenusEN.MenuTitle = objRow[convQxRoleMenus.MenuTitle] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuTitle].ToString().Trim(); //菜单标题
objvQxRoleMenusEN.PageDispModeId = objRow[convQxRoleMenus.PageDispModeId] == DBNull.Value ? null : objRow[convQxRoleMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxRoleMenusEN.PageDispModeName = objRow[convQxRoleMenus.PageDispModeName] == DBNull.Value ? null : objRow[convQxRoleMenus.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxRoleMenusEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus.InUse].ToString().Trim()); //是否在用
objvQxRoleMenusEN.UpMenuName = objRow[convQxRoleMenus.UpMenuName] == DBNull.Value ? null : objRow[convQxRoleMenus.UpMenuName].ToString().Trim(); //上级菜单名
objvQxRoleMenusEN.RoleNum = objRow[convQxRoleMenus.RoleNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRoleMenus.RoleNum].ToString().Trim()); //角色数
objvQxRoleMenusEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus.IsDisp].ToString().Trim()); //是否显示
objvQxRoleMenusEN.UpdDate = objRow[convQxRoleMenus.UpdDate].ToString().Trim(); //修改日期
objvQxRoleMenusEN.UpdUserId = objRow[convQxRoleMenus.UpdUserId].ToString().Trim(); //修改用户Id
objvQxRoleMenusEN.Memo = objRow[convQxRoleMenus.Memo] == DBNull.Value ? null : objRow[convQxRoleMenus.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRoleMenusEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRoleMenusEN);
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
public static IEnumerable<clsvQxRoleMenusEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsvQxRoleMenusEN objvQxRoleMenusCond, string strOrderBy)
{
List<clsvQxRoleMenusEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxRoleMenusEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxRoleMenus.AttributeName)
{
if (objvQxRoleMenusCond.IsUpdated(strFldName) == false) continue;
if (objvQxRoleMenusCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxRoleMenusCond[strFldName].ToString());
}
else
{
if (objvQxRoleMenusCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxRoleMenusCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxRoleMenusCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxRoleMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxRoleMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxRoleMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxRoleMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxRoleMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxRoleMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxRoleMenusCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxRoleMenusCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxRoleMenusCond[strFldName]));
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
public static IEnumerable<clsvQxRoleMenusEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsvQxRoleMenusEN objvQxRoleMenusCond = JsonConvert.DeserializeObject<clsvQxRoleMenusEN>(objPagerPara.whereCond);
if (objvQxRoleMenusCond.sfFldComparisonOp == null)
{
objvQxRoleMenusCond.dicFldComparisonOp = null;
}
else
{
objvQxRoleMenusCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objvQxRoleMenusCond.sfFldComparisonOp);
}
clsvQxRoleMenusBL.SetUpdFlag(objvQxRoleMenusCond);
 try
{
CheckProperty4Condition(objvQxRoleMenusCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsvQxRoleMenusBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objvQxRoleMenusCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxRoleMenusEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsvQxRoleMenusEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxRoleMenusEN> arrObjLst = new List<clsvQxRoleMenusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRoleMenusEN objvQxRoleMenusEN = new clsvQxRoleMenusEN();
try
{
objvQxRoleMenusEN.mId = Int32.Parse(objRow[convQxRoleMenus.mId].ToString().Trim()); //流水号
objvQxRoleMenusEN.RoleId = objRow[convQxRoleMenus.RoleId] == DBNull.Value ? null : objRow[convQxRoleMenus.RoleId].ToString().Trim(); //角色Id
objvQxRoleMenusEN.RoleName = objRow[convQxRoleMenus.RoleName].ToString().Trim(); //角色名称
objvQxRoleMenusEN.QxPrjId = objRow[convQxRoleMenus.QxPrjId].ToString().Trim(); //项目Id
objvQxRoleMenusEN.MenuId = objRow[convQxRoleMenus.MenuId].ToString().Trim(); //菜单Id
objvQxRoleMenusEN.MenuName = objRow[convQxRoleMenus.MenuName].ToString().Trim(); //菜单名
objvQxRoleMenusEN.PrjName = objRow[convQxRoleMenus.PrjName] == DBNull.Value ? null : objRow[convQxRoleMenus.PrjName].ToString().Trim(); //工程名
objvQxRoleMenusEN.UpMenuId = objRow[convQxRoleMenus.UpMenuId] == DBNull.Value ? null : objRow[convQxRoleMenus.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxRoleMenusEN.LinkFile = objRow[convQxRoleMenus.LinkFile] == DBNull.Value ? null : objRow[convQxRoleMenus.LinkFile].ToString().Trim(); //链接文件
objvQxRoleMenusEN.qsParameters = objRow[convQxRoleMenus.qsParameters] == DBNull.Value ? null : objRow[convQxRoleMenus.qsParameters].ToString().Trim(); //qs参数
objvQxRoleMenusEN.ImgFile = objRow[convQxRoleMenus.ImgFile] == DBNull.Value ? null : objRow[convQxRoleMenus.ImgFile].ToString().Trim(); //图像文件
objvQxRoleMenusEN.OrderNum = objRow[convQxRoleMenus.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRoleMenus.OrderNum].ToString().Trim()); //排序号
objvQxRoleMenusEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus.IsLeafNode].ToString().Trim()); //是否叶子
objvQxRoleMenusEN.MenuSetId = objRow[convQxRoleMenus.MenuSetId] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuSetId].ToString().Trim(); //菜单集Id
objvQxRoleMenusEN.MenuSetName = objRow[convQxRoleMenus.MenuSetName] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuSetName].ToString().Trim(); //菜单集名称
objvQxRoleMenusEN.MenuTitle = objRow[convQxRoleMenus.MenuTitle] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuTitle].ToString().Trim(); //菜单标题
objvQxRoleMenusEN.PageDispModeId = objRow[convQxRoleMenus.PageDispModeId] == DBNull.Value ? null : objRow[convQxRoleMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxRoleMenusEN.PageDispModeName = objRow[convQxRoleMenus.PageDispModeName] == DBNull.Value ? null : objRow[convQxRoleMenus.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxRoleMenusEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus.InUse].ToString().Trim()); //是否在用
objvQxRoleMenusEN.UpMenuName = objRow[convQxRoleMenus.UpMenuName] == DBNull.Value ? null : objRow[convQxRoleMenus.UpMenuName].ToString().Trim(); //上级菜单名
objvQxRoleMenusEN.RoleNum = objRow[convQxRoleMenus.RoleNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRoleMenus.RoleNum].ToString().Trim()); //角色数
objvQxRoleMenusEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus.IsDisp].ToString().Trim()); //是否显示
objvQxRoleMenusEN.UpdDate = objRow[convQxRoleMenus.UpdDate].ToString().Trim(); //修改日期
objvQxRoleMenusEN.UpdUserId = objRow[convQxRoleMenus.UpdUserId].ToString().Trim(); //修改用户Id
objvQxRoleMenusEN.Memo = objRow[convQxRoleMenus.Memo] == DBNull.Value ? null : objRow[convQxRoleMenus.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRoleMenusEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRoleMenusEN);
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
public static List<clsvQxRoleMenusEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxRoleMenusEN> arrObjLst = new List<clsvQxRoleMenusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRoleMenusEN objvQxRoleMenusEN = new clsvQxRoleMenusEN();
try
{
objvQxRoleMenusEN.mId = Int32.Parse(objRow[convQxRoleMenus.mId].ToString().Trim()); //流水号
objvQxRoleMenusEN.RoleId = objRow[convQxRoleMenus.RoleId] == DBNull.Value ? null : objRow[convQxRoleMenus.RoleId].ToString().Trim(); //角色Id
objvQxRoleMenusEN.RoleName = objRow[convQxRoleMenus.RoleName].ToString().Trim(); //角色名称
objvQxRoleMenusEN.QxPrjId = objRow[convQxRoleMenus.QxPrjId].ToString().Trim(); //项目Id
objvQxRoleMenusEN.MenuId = objRow[convQxRoleMenus.MenuId].ToString().Trim(); //菜单Id
objvQxRoleMenusEN.MenuName = objRow[convQxRoleMenus.MenuName].ToString().Trim(); //菜单名
objvQxRoleMenusEN.PrjName = objRow[convQxRoleMenus.PrjName] == DBNull.Value ? null : objRow[convQxRoleMenus.PrjName].ToString().Trim(); //工程名
objvQxRoleMenusEN.UpMenuId = objRow[convQxRoleMenus.UpMenuId] == DBNull.Value ? null : objRow[convQxRoleMenus.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxRoleMenusEN.LinkFile = objRow[convQxRoleMenus.LinkFile] == DBNull.Value ? null : objRow[convQxRoleMenus.LinkFile].ToString().Trim(); //链接文件
objvQxRoleMenusEN.qsParameters = objRow[convQxRoleMenus.qsParameters] == DBNull.Value ? null : objRow[convQxRoleMenus.qsParameters].ToString().Trim(); //qs参数
objvQxRoleMenusEN.ImgFile = objRow[convQxRoleMenus.ImgFile] == DBNull.Value ? null : objRow[convQxRoleMenus.ImgFile].ToString().Trim(); //图像文件
objvQxRoleMenusEN.OrderNum = objRow[convQxRoleMenus.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRoleMenus.OrderNum].ToString().Trim()); //排序号
objvQxRoleMenusEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus.IsLeafNode].ToString().Trim()); //是否叶子
objvQxRoleMenusEN.MenuSetId = objRow[convQxRoleMenus.MenuSetId] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuSetId].ToString().Trim(); //菜单集Id
objvQxRoleMenusEN.MenuSetName = objRow[convQxRoleMenus.MenuSetName] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuSetName].ToString().Trim(); //菜单集名称
objvQxRoleMenusEN.MenuTitle = objRow[convQxRoleMenus.MenuTitle] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuTitle].ToString().Trim(); //菜单标题
objvQxRoleMenusEN.PageDispModeId = objRow[convQxRoleMenus.PageDispModeId] == DBNull.Value ? null : objRow[convQxRoleMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxRoleMenusEN.PageDispModeName = objRow[convQxRoleMenus.PageDispModeName] == DBNull.Value ? null : objRow[convQxRoleMenus.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxRoleMenusEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus.InUse].ToString().Trim()); //是否在用
objvQxRoleMenusEN.UpMenuName = objRow[convQxRoleMenus.UpMenuName] == DBNull.Value ? null : objRow[convQxRoleMenus.UpMenuName].ToString().Trim(); //上级菜单名
objvQxRoleMenusEN.RoleNum = objRow[convQxRoleMenus.RoleNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRoleMenus.RoleNum].ToString().Trim()); //角色数
objvQxRoleMenusEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus.IsDisp].ToString().Trim()); //是否显示
objvQxRoleMenusEN.UpdDate = objRow[convQxRoleMenus.UpdDate].ToString().Trim(); //修改日期
objvQxRoleMenusEN.UpdUserId = objRow[convQxRoleMenus.UpdUserId].ToString().Trim(); //修改用户Id
objvQxRoleMenusEN.Memo = objRow[convQxRoleMenus.Memo] == DBNull.Value ? null : objRow[convQxRoleMenus.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRoleMenusEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRoleMenusEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxRoleMenusEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvQxRoleMenusEN> arrObjLst = new List<clsvQxRoleMenusEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRoleMenusEN objvQxRoleMenusEN = new clsvQxRoleMenusEN();
try
{
objvQxRoleMenusEN.mId = Int32.Parse(objRow[convQxRoleMenus.mId].ToString().Trim()); //流水号
objvQxRoleMenusEN.RoleId = objRow[convQxRoleMenus.RoleId] == DBNull.Value ? null : objRow[convQxRoleMenus.RoleId].ToString().Trim(); //角色Id
objvQxRoleMenusEN.RoleName = objRow[convQxRoleMenus.RoleName].ToString().Trim(); //角色名称
objvQxRoleMenusEN.QxPrjId = objRow[convQxRoleMenus.QxPrjId].ToString().Trim(); //项目Id
objvQxRoleMenusEN.MenuId = objRow[convQxRoleMenus.MenuId].ToString().Trim(); //菜单Id
objvQxRoleMenusEN.MenuName = objRow[convQxRoleMenus.MenuName].ToString().Trim(); //菜单名
objvQxRoleMenusEN.PrjName = objRow[convQxRoleMenus.PrjName] == DBNull.Value ? null : objRow[convQxRoleMenus.PrjName].ToString().Trim(); //工程名
objvQxRoleMenusEN.UpMenuId = objRow[convQxRoleMenus.UpMenuId] == DBNull.Value ? null : objRow[convQxRoleMenus.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxRoleMenusEN.LinkFile = objRow[convQxRoleMenus.LinkFile] == DBNull.Value ? null : objRow[convQxRoleMenus.LinkFile].ToString().Trim(); //链接文件
objvQxRoleMenusEN.qsParameters = objRow[convQxRoleMenus.qsParameters] == DBNull.Value ? null : objRow[convQxRoleMenus.qsParameters].ToString().Trim(); //qs参数
objvQxRoleMenusEN.ImgFile = objRow[convQxRoleMenus.ImgFile] == DBNull.Value ? null : objRow[convQxRoleMenus.ImgFile].ToString().Trim(); //图像文件
objvQxRoleMenusEN.OrderNum = objRow[convQxRoleMenus.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRoleMenus.OrderNum].ToString().Trim()); //排序号
objvQxRoleMenusEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus.IsLeafNode].ToString().Trim()); //是否叶子
objvQxRoleMenusEN.MenuSetId = objRow[convQxRoleMenus.MenuSetId] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuSetId].ToString().Trim(); //菜单集Id
objvQxRoleMenusEN.MenuSetName = objRow[convQxRoleMenus.MenuSetName] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuSetName].ToString().Trim(); //菜单集名称
objvQxRoleMenusEN.MenuTitle = objRow[convQxRoleMenus.MenuTitle] == DBNull.Value ? null : objRow[convQxRoleMenus.MenuTitle].ToString().Trim(); //菜单标题
objvQxRoleMenusEN.PageDispModeId = objRow[convQxRoleMenus.PageDispModeId] == DBNull.Value ? null : objRow[convQxRoleMenus.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxRoleMenusEN.PageDispModeName = objRow[convQxRoleMenus.PageDispModeName] == DBNull.Value ? null : objRow[convQxRoleMenus.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxRoleMenusEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus.InUse].ToString().Trim()); //是否在用
objvQxRoleMenusEN.UpMenuName = objRow[convQxRoleMenus.UpMenuName] == DBNull.Value ? null : objRow[convQxRoleMenus.UpMenuName].ToString().Trim(); //上级菜单名
objvQxRoleMenusEN.RoleNum = objRow[convQxRoleMenus.RoleNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRoleMenus.RoleNum].ToString().Trim()); //角色数
objvQxRoleMenusEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus.IsDisp].ToString().Trim()); //是否显示
objvQxRoleMenusEN.UpdDate = objRow[convQxRoleMenus.UpdDate].ToString().Trim(); //修改日期
objvQxRoleMenusEN.UpdUserId = objRow[convQxRoleMenus.UpdUserId].ToString().Trim(); //修改用户Id
objvQxRoleMenusEN.Memo = objRow[convQxRoleMenus.Memo] == DBNull.Value ? null : objRow[convQxRoleMenus.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRoleMenusEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRoleMenusEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxRoleMenus(ref clsvQxRoleMenusEN objvQxRoleMenusEN)
{
bool bolResult = vQxRoleMenusDA.GetvQxRoleMenus(ref objvQxRoleMenusEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxRoleMenusEN GetObjBymId(long lngmId)
{
clsvQxRoleMenusEN objvQxRoleMenusEN = vQxRoleMenusDA.GetObjBymId(lngmId);
return objvQxRoleMenusEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvQxRoleMenusEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvQxRoleMenusEN objvQxRoleMenusEN = vQxRoleMenusDA.GetFirstObj(strWhereCond);
 return objvQxRoleMenusEN;
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
public static clsvQxRoleMenusEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvQxRoleMenusEN objvQxRoleMenusEN = vQxRoleMenusDA.GetObjByDataRow(objRow);
 return objvQxRoleMenusEN;
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
public static clsvQxRoleMenusEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvQxRoleMenusEN objvQxRoleMenusEN = vQxRoleMenusDA.GetObjByDataRow(objRow);
 return objvQxRoleMenusEN;
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
 /// <param name = "lstvQxRoleMenusObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxRoleMenusEN GetObjBymIdFromList(long lngmId, List<clsvQxRoleMenusEN> lstvQxRoleMenusObjLst)
{
foreach (clsvQxRoleMenusEN objvQxRoleMenusEN in lstvQxRoleMenusObjLst)
{
if (objvQxRoleMenusEN.mId == lngmId)
{
return objvQxRoleMenusEN;
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
 lngmId = new clsvQxRoleMenusDA().GetFirstID(strWhereCond);
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
 arrList = vQxRoleMenusDA.GetID(strWhereCond);
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
bool bolIsExist = vQxRoleMenusDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vQxRoleMenusDA.IsExist(lngmId);
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
 bolIsExist = clsvQxRoleMenusDA.IsExistTable();
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
 bolIsExist = vQxRoleMenusDA.IsExistTable(strTabName);
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
 /// <param name = "objvQxRoleMenusEN">源简化对象</param>
 public static void SetUpdFlag(clsvQxRoleMenusEN objvQxRoleMenusEN)
{
try
{
objvQxRoleMenusEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvQxRoleMenusEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convQxRoleMenus.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRoleMenusEN.mId = objvQxRoleMenusEN.mId; //流水号
}
if (arrFldSet.Contains(convQxRoleMenus.RoleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRoleMenusEN.RoleId = objvQxRoleMenusEN.RoleId == "[null]" ? null :  objvQxRoleMenusEN.RoleId; //角色Id
}
if (arrFldSet.Contains(convQxRoleMenus.RoleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRoleMenusEN.RoleName = objvQxRoleMenusEN.RoleName; //角色名称
}
if (arrFldSet.Contains(convQxRoleMenus.QxPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRoleMenusEN.QxPrjId = objvQxRoleMenusEN.QxPrjId; //项目Id
}
if (arrFldSet.Contains(convQxRoleMenus.MenuId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRoleMenusEN.MenuId = objvQxRoleMenusEN.MenuId; //菜单Id
}
if (arrFldSet.Contains(convQxRoleMenus.MenuName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRoleMenusEN.MenuName = objvQxRoleMenusEN.MenuName; //菜单名
}
if (arrFldSet.Contains(convQxRoleMenus.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRoleMenusEN.PrjName = objvQxRoleMenusEN.PrjName == "[null]" ? null :  objvQxRoleMenusEN.PrjName; //工程名
}
if (arrFldSet.Contains(convQxRoleMenus.UpMenuId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRoleMenusEN.UpMenuId = objvQxRoleMenusEN.UpMenuId == "[null]" ? null :  objvQxRoleMenusEN.UpMenuId; //上级菜单Id
}
if (arrFldSet.Contains(convQxRoleMenus.LinkFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRoleMenusEN.LinkFile = objvQxRoleMenusEN.LinkFile == "[null]" ? null :  objvQxRoleMenusEN.LinkFile; //链接文件
}
if (arrFldSet.Contains(convQxRoleMenus.qsParameters, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRoleMenusEN.qsParameters = objvQxRoleMenusEN.qsParameters == "[null]" ? null :  objvQxRoleMenusEN.qsParameters; //qs参数
}
if (arrFldSet.Contains(convQxRoleMenus.ImgFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRoleMenusEN.ImgFile = objvQxRoleMenusEN.ImgFile == "[null]" ? null :  objvQxRoleMenusEN.ImgFile; //图像文件
}
if (arrFldSet.Contains(convQxRoleMenus.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRoleMenusEN.OrderNum = objvQxRoleMenusEN.OrderNum; //排序号
}
if (arrFldSet.Contains(convQxRoleMenus.IsLeafNode, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRoleMenusEN.IsLeafNode = objvQxRoleMenusEN.IsLeafNode; //是否叶子
}
if (arrFldSet.Contains(convQxRoleMenus.MenuSetId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRoleMenusEN.MenuSetId = objvQxRoleMenusEN.MenuSetId == "[null]" ? null :  objvQxRoleMenusEN.MenuSetId; //菜单集Id
}
if (arrFldSet.Contains(convQxRoleMenus.MenuSetName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRoleMenusEN.MenuSetName = objvQxRoleMenusEN.MenuSetName == "[null]" ? null :  objvQxRoleMenusEN.MenuSetName; //菜单集名称
}
if (arrFldSet.Contains(convQxRoleMenus.MenuTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRoleMenusEN.MenuTitle = objvQxRoleMenusEN.MenuTitle == "[null]" ? null :  objvQxRoleMenusEN.MenuTitle; //菜单标题
}
if (arrFldSet.Contains(convQxRoleMenus.PageDispModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRoleMenusEN.PageDispModeId = objvQxRoleMenusEN.PageDispModeId == "[null]" ? null :  objvQxRoleMenusEN.PageDispModeId; //页面显示模式Id
}
if (arrFldSet.Contains(convQxRoleMenus.PageDispModeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRoleMenusEN.PageDispModeName = objvQxRoleMenusEN.PageDispModeName == "[null]" ? null :  objvQxRoleMenusEN.PageDispModeName; //页面显示模式名称
}
if (arrFldSet.Contains(convQxRoleMenus.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRoleMenusEN.InUse = objvQxRoleMenusEN.InUse; //是否在用
}
if (arrFldSet.Contains(convQxRoleMenus.UpMenuName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRoleMenusEN.UpMenuName = objvQxRoleMenusEN.UpMenuName == "[null]" ? null :  objvQxRoleMenusEN.UpMenuName; //上级菜单名
}
if (arrFldSet.Contains(convQxRoleMenus.RoleNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRoleMenusEN.RoleNum = objvQxRoleMenusEN.RoleNum; //角色数
}
if (arrFldSet.Contains(convQxRoleMenus.IsDisp, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRoleMenusEN.IsDisp = objvQxRoleMenusEN.IsDisp; //是否显示
}
if (arrFldSet.Contains(convQxRoleMenus.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRoleMenusEN.UpdDate = objvQxRoleMenusEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convQxRoleMenus.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRoleMenusEN.UpdUserId = objvQxRoleMenusEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convQxRoleMenus.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRoleMenusEN.Memo = objvQxRoleMenusEN.Memo == "[null]" ? null :  objvQxRoleMenusEN.Memo; //备注
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
 /// <param name = "objvQxRoleMenusEN">源简化对象</param>
 public static void AccessFldValueNull(clsvQxRoleMenusEN objvQxRoleMenusEN)
{
try
{
if (objvQxRoleMenusEN.RoleId == "[null]") objvQxRoleMenusEN.RoleId = null; //角色Id
if (objvQxRoleMenusEN.PrjName == "[null]") objvQxRoleMenusEN.PrjName = null; //工程名
if (objvQxRoleMenusEN.UpMenuId == "[null]") objvQxRoleMenusEN.UpMenuId = null; //上级菜单Id
if (objvQxRoleMenusEN.LinkFile == "[null]") objvQxRoleMenusEN.LinkFile = null; //链接文件
if (objvQxRoleMenusEN.qsParameters == "[null]") objvQxRoleMenusEN.qsParameters = null; //qs参数
if (objvQxRoleMenusEN.ImgFile == "[null]") objvQxRoleMenusEN.ImgFile = null; //图像文件
if (objvQxRoleMenusEN.MenuSetId == "[null]") objvQxRoleMenusEN.MenuSetId = null; //菜单集Id
if (objvQxRoleMenusEN.MenuSetName == "[null]") objvQxRoleMenusEN.MenuSetName = null; //菜单集名称
if (objvQxRoleMenusEN.MenuTitle == "[null]") objvQxRoleMenusEN.MenuTitle = null; //菜单标题
if (objvQxRoleMenusEN.PageDispModeId == "[null]") objvQxRoleMenusEN.PageDispModeId = null; //页面显示模式Id
if (objvQxRoleMenusEN.PageDispModeName == "[null]") objvQxRoleMenusEN.PageDispModeName = null; //页面显示模式名称
if (objvQxRoleMenusEN.UpMenuName == "[null]") objvQxRoleMenusEN.UpMenuName = null; //上级菜单名
if (objvQxRoleMenusEN.Memo == "[null]") objvQxRoleMenusEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvQxRoleMenusEN objvQxRoleMenusEN)
{
 vQxRoleMenusDA.CheckProperty4Condition(objvQxRoleMenusEN);
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
if (clsQxRoleMenusBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxRoleMenusBL没有刷新缓存机制(clsQxRoleMenusBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxRolesBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxRolesBL没有刷新缓存机制(clsQxRolesBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
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
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvQxRoleMenusObjLstCache == null)
//{
//arrvQxRoleMenusObjLstCache = vQxRoleMenusDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxRoleMenusEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvQxRoleMenusEN._CurrTabName);
List<clsvQxRoleMenusEN> arrvQxRoleMenusObjLstCache = GetObjLstCache();
IEnumerable <clsvQxRoleMenusEN> arrvQxRoleMenusObjLst_Sel =
arrvQxRoleMenusObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvQxRoleMenusObjLst_Sel.Count() == 0)
{
   clsvQxRoleMenusEN obj = clsvQxRoleMenusBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvQxRoleMenusObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxRoleMenusEN> GetAllvQxRoleMenusObjLstCache()
{
//获取缓存中的对象列表
List<clsvQxRoleMenusEN> arrvQxRoleMenusObjLstCache = GetObjLstCache(); 
return arrvQxRoleMenusObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxRoleMenusEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvQxRoleMenusEN._CurrTabName);
List<clsvQxRoleMenusEN> arrvQxRoleMenusObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQxRoleMenusObjLstCache;
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


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstvQxRoleMenusObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsvQxRoleMenusEN> lstvQxRoleMenusObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstvQxRoleMenusObjLst, writer);
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
 /// <param name = "lstvQxRoleMenusObjLst">[clsvQxRoleMenusEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsvQxRoleMenusEN> lstvQxRoleMenusObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsvQxRoleMenusBL.listXmlNode);
writer.WriteStartElement(clsvQxRoleMenusBL.itemsXmlNode);
foreach (clsvQxRoleMenusEN objvQxRoleMenusEN in lstvQxRoleMenusObjLst)
{
clsvQxRoleMenusBL.SerializeXML(writer, objvQxRoleMenusEN);
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
 /// <param name = "objvQxRoleMenusEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsvQxRoleMenusEN objvQxRoleMenusEN)
{
writer.WriteStartElement(clsvQxRoleMenusBL.itemXmlNode);
 
writer.WriteElementString(convQxRoleMenus.mId, objvQxRoleMenusEN.mId.ToString(CultureInfo.InvariantCulture));
 
if (objvQxRoleMenusEN.RoleId != null)
{
writer.WriteElementString(convQxRoleMenus.RoleId, objvQxRoleMenusEN.RoleId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxRoleMenusEN.RoleName != null)
{
writer.WriteElementString(convQxRoleMenus.RoleName, objvQxRoleMenusEN.RoleName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxRoleMenusEN.QxPrjId != null)
{
writer.WriteElementString(convQxRoleMenus.QxPrjId, objvQxRoleMenusEN.QxPrjId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxRoleMenusEN.MenuId != null)
{
writer.WriteElementString(convQxRoleMenus.MenuId, objvQxRoleMenusEN.MenuId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxRoleMenusEN.MenuName != null)
{
writer.WriteElementString(convQxRoleMenus.MenuName, objvQxRoleMenusEN.MenuName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxRoleMenusEN.PrjName != null)
{
writer.WriteElementString(convQxRoleMenus.PrjName, objvQxRoleMenusEN.PrjName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxRoleMenusEN.UpMenuId != null)
{
writer.WriteElementString(convQxRoleMenus.UpMenuId, objvQxRoleMenusEN.UpMenuId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxRoleMenusEN.LinkFile != null)
{
writer.WriteElementString(convQxRoleMenus.LinkFile, objvQxRoleMenusEN.LinkFile.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxRoleMenusEN.qsParameters != null)
{
writer.WriteElementString(convQxRoleMenus.qsParameters, objvQxRoleMenusEN.qsParameters.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxRoleMenusEN.ImgFile != null)
{
writer.WriteElementString(convQxRoleMenus.ImgFile, objvQxRoleMenusEN.ImgFile.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convQxRoleMenus.OrderNum, objvQxRoleMenusEN.OrderNum.ToString());
 
writer.WriteElementString(convQxRoleMenus.IsLeafNode, objvQxRoleMenusEN.IsLeafNode.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objvQxRoleMenusEN.MenuSetId != null)
{
writer.WriteElementString(convQxRoleMenus.MenuSetId, objvQxRoleMenusEN.MenuSetId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxRoleMenusEN.MenuSetName != null)
{
writer.WriteElementString(convQxRoleMenus.MenuSetName, objvQxRoleMenusEN.MenuSetName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxRoleMenusEN.MenuTitle != null)
{
writer.WriteElementString(convQxRoleMenus.MenuTitle, objvQxRoleMenusEN.MenuTitle.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxRoleMenusEN.PageDispModeId != null)
{
writer.WriteElementString(convQxRoleMenus.PageDispModeId, objvQxRoleMenusEN.PageDispModeId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxRoleMenusEN.PageDispModeName != null)
{
writer.WriteElementString(convQxRoleMenus.PageDispModeName, objvQxRoleMenusEN.PageDispModeName.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convQxRoleMenus.InUse, objvQxRoleMenusEN.InUse.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objvQxRoleMenusEN.UpMenuName != null)
{
writer.WriteElementString(convQxRoleMenus.UpMenuName, objvQxRoleMenusEN.UpMenuName.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convQxRoleMenus.RoleNum, objvQxRoleMenusEN.RoleNum.ToString());
 
writer.WriteElementString(convQxRoleMenus.IsDisp, objvQxRoleMenusEN.IsDisp.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objvQxRoleMenusEN.UpdDate != null)
{
writer.WriteElementString(convQxRoleMenus.UpdDate, objvQxRoleMenusEN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxRoleMenusEN.UpdUserId != null)
{
writer.WriteElementString(convQxRoleMenus.UpdUserId, objvQxRoleMenusEN.UpdUserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxRoleMenusEN.Memo != null)
{
writer.WriteElementString(convQxRoleMenus.Memo, objvQxRoleMenusEN.Memo.ToString(CultureInfo.InvariantCulture));
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
public static clsvQxRoleMenusEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsvQxRoleMenusEN objvQxRoleMenusEN = new clsvQxRoleMenusEN();
reader.Read();
while (!(reader.Name == clsvQxRoleMenusBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(convQxRoleMenus.mId))
{
objvQxRoleMenusEN.mId = reader.ReadElementContentAsLong();
}
if (reader.IsStartElement(convQxRoleMenus.RoleId))
{
objvQxRoleMenusEN.RoleId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxRoleMenus.RoleName))
{
objvQxRoleMenusEN.RoleName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxRoleMenus.QxPrjId))
{
objvQxRoleMenusEN.QxPrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxRoleMenus.MenuId))
{
objvQxRoleMenusEN.MenuId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxRoleMenus.MenuName))
{
objvQxRoleMenusEN.MenuName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxRoleMenus.PrjName))
{
objvQxRoleMenusEN.PrjName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxRoleMenus.UpMenuId))
{
objvQxRoleMenusEN.UpMenuId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxRoleMenus.LinkFile))
{
objvQxRoleMenusEN.LinkFile = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxRoleMenus.qsParameters))
{
objvQxRoleMenusEN.qsParameters = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxRoleMenus.ImgFile))
{
objvQxRoleMenusEN.ImgFile = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxRoleMenus.OrderNum))
{
objvQxRoleMenusEN.OrderNum = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(convQxRoleMenus.IsLeafNode))
{
objvQxRoleMenusEN.IsLeafNode = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(convQxRoleMenus.MenuSetId))
{
objvQxRoleMenusEN.MenuSetId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxRoleMenus.MenuSetName))
{
objvQxRoleMenusEN.MenuSetName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxRoleMenus.MenuTitle))
{
objvQxRoleMenusEN.MenuTitle = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxRoleMenus.PageDispModeId))
{
objvQxRoleMenusEN.PageDispModeId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxRoleMenus.PageDispModeName))
{
objvQxRoleMenusEN.PageDispModeName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxRoleMenus.InUse))
{
objvQxRoleMenusEN.InUse = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(convQxRoleMenus.UpMenuName))
{
objvQxRoleMenusEN.UpMenuName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxRoleMenus.RoleNum))
{
objvQxRoleMenusEN.RoleNum = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(convQxRoleMenus.IsDisp))
{
objvQxRoleMenusEN.IsDisp = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(convQxRoleMenus.UpdDate))
{
objvQxRoleMenusEN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxRoleMenus.UpdUserId))
{
objvQxRoleMenusEN.UpdUserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxRoleMenus.Memo))
{
objvQxRoleMenusEN.Memo = reader.ReadElementContentAsString();
}
}
return objvQxRoleMenusEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strvQxRoleMenusObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsvQxRoleMenusEN GetObjFromXmlStr(string strvQxRoleMenusObjXmlStr)
{
clsvQxRoleMenusEN objvQxRoleMenusEN = new clsvQxRoleMenusEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strvQxRoleMenusObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsvQxRoleMenusBL.itemXmlNode))
{
objvQxRoleMenusEN = GetObjFromXml(reader);
return objvQxRoleMenusEN;
}
}
return objvQxRoleMenusEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsvQxRoleMenusEN objvQxRoleMenusEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objvQxRoleMenusEN);
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
if (strInFldName != convQxRoleMenus.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convQxRoleMenus.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convQxRoleMenus.AttributeName));
throw new Exception(strMsg);
}
var objvQxRoleMenus = clsvQxRoleMenusBL.GetObjBymIdCache(lngmId);
if (objvQxRoleMenus == null) return "";
return objvQxRoleMenus[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsvQxRoleMenusEN objvQxRoleMenusEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsvQxRoleMenusEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objvQxRoleMenusEN[strField]);
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
 /// <param name = "lstvQxRoleMenusObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsvQxRoleMenusEN> lstvQxRoleMenusObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstvQxRoleMenusObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsvQxRoleMenusEN objvQxRoleMenusEN in lstvQxRoleMenusObjLst)
{
string strJSON_One = SerializeObjToJSON(objvQxRoleMenusEN);
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
int intRecCount = clsvQxRoleMenusDA.GetRecCount(strTabName);
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
int intRecCount = clsvQxRoleMenusDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvQxRoleMenusDA.GetRecCount();
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
int intRecCount = clsvQxRoleMenusDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvQxRoleMenusCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvQxRoleMenusEN objvQxRoleMenusCond)
{
List<clsvQxRoleMenusEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxRoleMenusEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxRoleMenus.AttributeName)
{
if (objvQxRoleMenusCond.IsUpdated(strFldName) == false) continue;
if (objvQxRoleMenusCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxRoleMenusCond[strFldName].ToString());
}
else
{
if (objvQxRoleMenusCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxRoleMenusCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxRoleMenusCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxRoleMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxRoleMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxRoleMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxRoleMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxRoleMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxRoleMenusCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxRoleMenusCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxRoleMenusCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxRoleMenusCond[strFldName]));
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
 List<string> arrList = clsvQxRoleMenusDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vQxRoleMenusDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vQxRoleMenusDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}