
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxRoleMenus_SimBL
 表名:vQxRoleMenus_Sim(00140073)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:35:07
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
public static class  clsvQxRoleMenus_SimBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxRoleMenus_SimEN GetObj(this K_mId_vQxRoleMenus_Sim myKey)
{
clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN = clsvQxRoleMenus_SimBL.vQxRoleMenus_SimDA.GetObjBymId(myKey.Value);
return objvQxRoleMenus_SimEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenus_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenus_SimEN SetmId(this clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN, long lngmId, string strComparisonOp="")
	{
objvQxRoleMenus_SimEN.mId = lngmId; //流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRoleMenus_SimEN.dicFldComparisonOp.ContainsKey(convQxRoleMenus_Sim.mId) == false)
{
objvQxRoleMenus_SimEN.dicFldComparisonOp.Add(convQxRoleMenus_Sim.mId, strComparisonOp);
}
else
{
objvQxRoleMenus_SimEN.dicFldComparisonOp[convQxRoleMenus_Sim.mId] = strComparisonOp;
}
}
return objvQxRoleMenus_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenus_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenus_SimEN SetRoleId(this clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN, string strRoleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRoleId, convQxRoleMenus_Sim.RoleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRoleId, 8, convQxRoleMenus_Sim.RoleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, convQxRoleMenus_Sim.RoleId);
}
objvQxRoleMenus_SimEN.RoleId = strRoleId; //角色Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRoleMenus_SimEN.dicFldComparisonOp.ContainsKey(convQxRoleMenus_Sim.RoleId) == false)
{
objvQxRoleMenus_SimEN.dicFldComparisonOp.Add(convQxRoleMenus_Sim.RoleId, strComparisonOp);
}
else
{
objvQxRoleMenus_SimEN.dicFldComparisonOp[convQxRoleMenus_Sim.RoleId] = strComparisonOp;
}
}
return objvQxRoleMenus_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenus_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenus_SimEN SetQxPrjId(this clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, convQxRoleMenus_Sim.QxPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxRoleMenus_Sim.QxPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxRoleMenus_Sim.QxPrjId);
}
objvQxRoleMenus_SimEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRoleMenus_SimEN.dicFldComparisonOp.ContainsKey(convQxRoleMenus_Sim.QxPrjId) == false)
{
objvQxRoleMenus_SimEN.dicFldComparisonOp.Add(convQxRoleMenus_Sim.QxPrjId, strComparisonOp);
}
else
{
objvQxRoleMenus_SimEN.dicFldComparisonOp[convQxRoleMenus_Sim.QxPrjId] = strComparisonOp;
}
}
return objvQxRoleMenus_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenus_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenus_SimEN SetMenuId(this clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN, string strMenuId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMenuId, convQxRoleMenus_Sim.MenuId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuId, 8, convQxRoleMenus_Sim.MenuId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMenuId, 8, convQxRoleMenus_Sim.MenuId);
}
objvQxRoleMenus_SimEN.MenuId = strMenuId; //菜单Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRoleMenus_SimEN.dicFldComparisonOp.ContainsKey(convQxRoleMenus_Sim.MenuId) == false)
{
objvQxRoleMenus_SimEN.dicFldComparisonOp.Add(convQxRoleMenus_Sim.MenuId, strComparisonOp);
}
else
{
objvQxRoleMenus_SimEN.dicFldComparisonOp[convQxRoleMenus_Sim.MenuId] = strComparisonOp;
}
}
return objvQxRoleMenus_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenus_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenus_SimEN SetMenuName(this clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN, string strMenuName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuName, 50, convQxRoleMenus_Sim.MenuName);
}
objvQxRoleMenus_SimEN.MenuName = strMenuName; //菜单名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRoleMenus_SimEN.dicFldComparisonOp.ContainsKey(convQxRoleMenus_Sim.MenuName) == false)
{
objvQxRoleMenus_SimEN.dicFldComparisonOp.Add(convQxRoleMenus_Sim.MenuName, strComparisonOp);
}
else
{
objvQxRoleMenus_SimEN.dicFldComparisonOp[convQxRoleMenus_Sim.MenuName] = strComparisonOp;
}
}
return objvQxRoleMenus_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenus_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenus_SimEN SetUpMenuId(this clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN, string strUpMenuId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpMenuId, 8, convQxRoleMenus_Sim.UpMenuId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUpMenuId, 8, convQxRoleMenus_Sim.UpMenuId);
}
objvQxRoleMenus_SimEN.UpMenuId = strUpMenuId; //上级菜单Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRoleMenus_SimEN.dicFldComparisonOp.ContainsKey(convQxRoleMenus_Sim.UpMenuId) == false)
{
objvQxRoleMenus_SimEN.dicFldComparisonOp.Add(convQxRoleMenus_Sim.UpMenuId, strComparisonOp);
}
else
{
objvQxRoleMenus_SimEN.dicFldComparisonOp[convQxRoleMenus_Sim.UpMenuId] = strComparisonOp;
}
}
return objvQxRoleMenus_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenus_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenus_SimEN SetLinkFile(this clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN, string strLinkFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLinkFile, 500, convQxRoleMenus_Sim.LinkFile);
}
objvQxRoleMenus_SimEN.LinkFile = strLinkFile; //链接文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRoleMenus_SimEN.dicFldComparisonOp.ContainsKey(convQxRoleMenus_Sim.LinkFile) == false)
{
objvQxRoleMenus_SimEN.dicFldComparisonOp.Add(convQxRoleMenus_Sim.LinkFile, strComparisonOp);
}
else
{
objvQxRoleMenus_SimEN.dicFldComparisonOp[convQxRoleMenus_Sim.LinkFile] = strComparisonOp;
}
}
return objvQxRoleMenus_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenus_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenus_SimEN SetqsParameters(this clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN, string strqsParameters, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strqsParameters, 200, convQxRoleMenus_Sim.qsParameters);
}
objvQxRoleMenus_SimEN.qsParameters = strqsParameters; //qs参数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRoleMenus_SimEN.dicFldComparisonOp.ContainsKey(convQxRoleMenus_Sim.qsParameters) == false)
{
objvQxRoleMenus_SimEN.dicFldComparisonOp.Add(convQxRoleMenus_Sim.qsParameters, strComparisonOp);
}
else
{
objvQxRoleMenus_SimEN.dicFldComparisonOp[convQxRoleMenus_Sim.qsParameters] = strComparisonOp;
}
}
return objvQxRoleMenus_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenus_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenus_SimEN SetImgFile(this clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN, string strImgFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strImgFile, 300, convQxRoleMenus_Sim.ImgFile);
}
objvQxRoleMenus_SimEN.ImgFile = strImgFile; //图像文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRoleMenus_SimEN.dicFldComparisonOp.ContainsKey(convQxRoleMenus_Sim.ImgFile) == false)
{
objvQxRoleMenus_SimEN.dicFldComparisonOp.Add(convQxRoleMenus_Sim.ImgFile, strComparisonOp);
}
else
{
objvQxRoleMenus_SimEN.dicFldComparisonOp[convQxRoleMenus_Sim.ImgFile] = strComparisonOp;
}
}
return objvQxRoleMenus_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenus_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenus_SimEN SetOrderNum(this clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN, int? intOrderNum, string strComparisonOp="")
	{
objvQxRoleMenus_SimEN.OrderNum = intOrderNum; //排序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRoleMenus_SimEN.dicFldComparisonOp.ContainsKey(convQxRoleMenus_Sim.OrderNum) == false)
{
objvQxRoleMenus_SimEN.dicFldComparisonOp.Add(convQxRoleMenus_Sim.OrderNum, strComparisonOp);
}
else
{
objvQxRoleMenus_SimEN.dicFldComparisonOp[convQxRoleMenus_Sim.OrderNum] = strComparisonOp;
}
}
return objvQxRoleMenus_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenus_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenus_SimEN SetIsLeafNode(this clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN, bool bolIsLeafNode, string strComparisonOp="")
	{
objvQxRoleMenus_SimEN.IsLeafNode = bolIsLeafNode; //是否叶子
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRoleMenus_SimEN.dicFldComparisonOp.ContainsKey(convQxRoleMenus_Sim.IsLeafNode) == false)
{
objvQxRoleMenus_SimEN.dicFldComparisonOp.Add(convQxRoleMenus_Sim.IsLeafNode, strComparisonOp);
}
else
{
objvQxRoleMenus_SimEN.dicFldComparisonOp[convQxRoleMenus_Sim.IsLeafNode] = strComparisonOp;
}
}
return objvQxRoleMenus_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenus_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenus_SimEN SetMenuSetId(this clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN, string strMenuSetId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuSetId, 4, convQxRoleMenus_Sim.MenuSetId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMenuSetId, 4, convQxRoleMenus_Sim.MenuSetId);
}
objvQxRoleMenus_SimEN.MenuSetId = strMenuSetId; //菜单集Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRoleMenus_SimEN.dicFldComparisonOp.ContainsKey(convQxRoleMenus_Sim.MenuSetId) == false)
{
objvQxRoleMenus_SimEN.dicFldComparisonOp.Add(convQxRoleMenus_Sim.MenuSetId, strComparisonOp);
}
else
{
objvQxRoleMenus_SimEN.dicFldComparisonOp[convQxRoleMenus_Sim.MenuSetId] = strComparisonOp;
}
}
return objvQxRoleMenus_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenus_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenus_SimEN SetMenuTitle(this clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN, string strMenuTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuTitle, 50, convQxRoleMenus_Sim.MenuTitle);
}
objvQxRoleMenus_SimEN.MenuTitle = strMenuTitle; //菜单标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRoleMenus_SimEN.dicFldComparisonOp.ContainsKey(convQxRoleMenus_Sim.MenuTitle) == false)
{
objvQxRoleMenus_SimEN.dicFldComparisonOp.Add(convQxRoleMenus_Sim.MenuTitle, strComparisonOp);
}
else
{
objvQxRoleMenus_SimEN.dicFldComparisonOp[convQxRoleMenus_Sim.MenuTitle] = strComparisonOp;
}
}
return objvQxRoleMenus_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenus_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenus_SimEN SetPageDispModeId(this clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN, string strPageDispModeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPageDispModeId, 2, convQxRoleMenus_Sim.PageDispModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPageDispModeId, 2, convQxRoleMenus_Sim.PageDispModeId);
}
objvQxRoleMenus_SimEN.PageDispModeId = strPageDispModeId; //页面显示模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRoleMenus_SimEN.dicFldComparisonOp.ContainsKey(convQxRoleMenus_Sim.PageDispModeId) == false)
{
objvQxRoleMenus_SimEN.dicFldComparisonOp.Add(convQxRoleMenus_Sim.PageDispModeId, strComparisonOp);
}
else
{
objvQxRoleMenus_SimEN.dicFldComparisonOp[convQxRoleMenus_Sim.PageDispModeId] = strComparisonOp;
}
}
return objvQxRoleMenus_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenus_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenus_SimEN SetInUse(this clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN, bool bolInUse, string strComparisonOp="")
	{
objvQxRoleMenus_SimEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRoleMenus_SimEN.dicFldComparisonOp.ContainsKey(convQxRoleMenus_Sim.InUse) == false)
{
objvQxRoleMenus_SimEN.dicFldComparisonOp.Add(convQxRoleMenus_Sim.InUse, strComparisonOp);
}
else
{
objvQxRoleMenus_SimEN.dicFldComparisonOp[convQxRoleMenus_Sim.InUse] = strComparisonOp;
}
}
return objvQxRoleMenus_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenus_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenus_SimEN SetUpMenuName(this clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN, string strUpMenuName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpMenuName, 30, convQxRoleMenus_Sim.UpMenuName);
}
objvQxRoleMenus_SimEN.UpMenuName = strUpMenuName; //上级菜单名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRoleMenus_SimEN.dicFldComparisonOp.ContainsKey(convQxRoleMenus_Sim.UpMenuName) == false)
{
objvQxRoleMenus_SimEN.dicFldComparisonOp.Add(convQxRoleMenus_Sim.UpMenuName, strComparisonOp);
}
else
{
objvQxRoleMenus_SimEN.dicFldComparisonOp[convQxRoleMenus_Sim.UpMenuName] = strComparisonOp;
}
}
return objvQxRoleMenus_SimEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvQxRoleMenus_SimENS">源对象</param>
 /// <param name = "objvQxRoleMenus_SimENT">目标对象</param>
 public static void CopyTo(this clsvQxRoleMenus_SimEN objvQxRoleMenus_SimENS, clsvQxRoleMenus_SimEN objvQxRoleMenus_SimENT)
{
try
{
objvQxRoleMenus_SimENT.mId = objvQxRoleMenus_SimENS.mId; //流水号
objvQxRoleMenus_SimENT.RoleId = objvQxRoleMenus_SimENS.RoleId; //角色Id
objvQxRoleMenus_SimENT.QxPrjId = objvQxRoleMenus_SimENS.QxPrjId; //项目Id
objvQxRoleMenus_SimENT.MenuId = objvQxRoleMenus_SimENS.MenuId; //菜单Id
objvQxRoleMenus_SimENT.MenuName = objvQxRoleMenus_SimENS.MenuName; //菜单名
objvQxRoleMenus_SimENT.UpMenuId = objvQxRoleMenus_SimENS.UpMenuId; //上级菜单Id
objvQxRoleMenus_SimENT.LinkFile = objvQxRoleMenus_SimENS.LinkFile; //链接文件
objvQxRoleMenus_SimENT.qsParameters = objvQxRoleMenus_SimENS.qsParameters; //qs参数
objvQxRoleMenus_SimENT.ImgFile = objvQxRoleMenus_SimENS.ImgFile; //图像文件
objvQxRoleMenus_SimENT.OrderNum = objvQxRoleMenus_SimENS.OrderNum; //排序号
objvQxRoleMenus_SimENT.IsLeafNode = objvQxRoleMenus_SimENS.IsLeafNode; //是否叶子
objvQxRoleMenus_SimENT.MenuSetId = objvQxRoleMenus_SimENS.MenuSetId; //菜单集Id
objvQxRoleMenus_SimENT.MenuTitle = objvQxRoleMenus_SimENS.MenuTitle; //菜单标题
objvQxRoleMenus_SimENT.PageDispModeId = objvQxRoleMenus_SimENS.PageDispModeId; //页面显示模式Id
objvQxRoleMenus_SimENT.InUse = objvQxRoleMenus_SimENS.InUse; //是否在用
objvQxRoleMenus_SimENT.UpMenuName = objvQxRoleMenus_SimENS.UpMenuName; //上级菜单名
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
 /// <param name = "objvQxRoleMenus_SimENS">源对象</param>
 /// <returns>目标对象=>clsvQxRoleMenus_SimEN:objvQxRoleMenus_SimENT</returns>
 public static clsvQxRoleMenus_SimEN CopyTo(this clsvQxRoleMenus_SimEN objvQxRoleMenus_SimENS)
{
try
{
 clsvQxRoleMenus_SimEN objvQxRoleMenus_SimENT = new clsvQxRoleMenus_SimEN()
{
mId = objvQxRoleMenus_SimENS.mId, //流水号
RoleId = objvQxRoleMenus_SimENS.RoleId, //角色Id
QxPrjId = objvQxRoleMenus_SimENS.QxPrjId, //项目Id
MenuId = objvQxRoleMenus_SimENS.MenuId, //菜单Id
MenuName = objvQxRoleMenus_SimENS.MenuName, //菜单名
UpMenuId = objvQxRoleMenus_SimENS.UpMenuId, //上级菜单Id
LinkFile = objvQxRoleMenus_SimENS.LinkFile, //链接文件
qsParameters = objvQxRoleMenus_SimENS.qsParameters, //qs参数
ImgFile = objvQxRoleMenus_SimENS.ImgFile, //图像文件
OrderNum = objvQxRoleMenus_SimENS.OrderNum, //排序号
IsLeafNode = objvQxRoleMenus_SimENS.IsLeafNode, //是否叶子
MenuSetId = objvQxRoleMenus_SimENS.MenuSetId, //菜单集Id
MenuTitle = objvQxRoleMenus_SimENS.MenuTitle, //菜单标题
PageDispModeId = objvQxRoleMenus_SimENS.PageDispModeId, //页面显示模式Id
InUse = objvQxRoleMenus_SimENS.InUse, //是否在用
UpMenuName = objvQxRoleMenus_SimENS.UpMenuName, //上级菜单名
};
 return objvQxRoleMenus_SimENT;
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
public static void CheckProperty4Condition(this clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN)
{
 clsvQxRoleMenus_SimBL.vQxRoleMenus_SimDA.CheckProperty4Condition(objvQxRoleMenus_SimEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQxRoleMenus_SimEN objvQxRoleMenus_SimCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQxRoleMenus_SimCond.IsUpdated(convQxRoleMenus_Sim.mId) == true)
{
string strComparisonOpmId = objvQxRoleMenus_SimCond.dicFldComparisonOp[convQxRoleMenus_Sim.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convQxRoleMenus_Sim.mId, objvQxRoleMenus_SimCond.mId, strComparisonOpmId);
}
if (objvQxRoleMenus_SimCond.IsUpdated(convQxRoleMenus_Sim.RoleId) == true)
{
string strComparisonOpRoleId = objvQxRoleMenus_SimCond.dicFldComparisonOp[convQxRoleMenus_Sim.RoleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRoleMenus_Sim.RoleId, objvQxRoleMenus_SimCond.RoleId, strComparisonOpRoleId);
}
if (objvQxRoleMenus_SimCond.IsUpdated(convQxRoleMenus_Sim.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objvQxRoleMenus_SimCond.dicFldComparisonOp[convQxRoleMenus_Sim.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRoleMenus_Sim.QxPrjId, objvQxRoleMenus_SimCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objvQxRoleMenus_SimCond.IsUpdated(convQxRoleMenus_Sim.MenuId) == true)
{
string strComparisonOpMenuId = objvQxRoleMenus_SimCond.dicFldComparisonOp[convQxRoleMenus_Sim.MenuId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRoleMenus_Sim.MenuId, objvQxRoleMenus_SimCond.MenuId, strComparisonOpMenuId);
}
if (objvQxRoleMenus_SimCond.IsUpdated(convQxRoleMenus_Sim.MenuName) == true)
{
string strComparisonOpMenuName = objvQxRoleMenus_SimCond.dicFldComparisonOp[convQxRoleMenus_Sim.MenuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRoleMenus_Sim.MenuName, objvQxRoleMenus_SimCond.MenuName, strComparisonOpMenuName);
}
if (objvQxRoleMenus_SimCond.IsUpdated(convQxRoleMenus_Sim.UpMenuId) == true)
{
string strComparisonOpUpMenuId = objvQxRoleMenus_SimCond.dicFldComparisonOp[convQxRoleMenus_Sim.UpMenuId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRoleMenus_Sim.UpMenuId, objvQxRoleMenus_SimCond.UpMenuId, strComparisonOpUpMenuId);
}
if (objvQxRoleMenus_SimCond.IsUpdated(convQxRoleMenus_Sim.LinkFile) == true)
{
string strComparisonOpLinkFile = objvQxRoleMenus_SimCond.dicFldComparisonOp[convQxRoleMenus_Sim.LinkFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRoleMenus_Sim.LinkFile, objvQxRoleMenus_SimCond.LinkFile, strComparisonOpLinkFile);
}
if (objvQxRoleMenus_SimCond.IsUpdated(convQxRoleMenus_Sim.qsParameters) == true)
{
string strComparisonOpqsParameters = objvQxRoleMenus_SimCond.dicFldComparisonOp[convQxRoleMenus_Sim.qsParameters];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRoleMenus_Sim.qsParameters, objvQxRoleMenus_SimCond.qsParameters, strComparisonOpqsParameters);
}
if (objvQxRoleMenus_SimCond.IsUpdated(convQxRoleMenus_Sim.ImgFile) == true)
{
string strComparisonOpImgFile = objvQxRoleMenus_SimCond.dicFldComparisonOp[convQxRoleMenus_Sim.ImgFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRoleMenus_Sim.ImgFile, objvQxRoleMenus_SimCond.ImgFile, strComparisonOpImgFile);
}
if (objvQxRoleMenus_SimCond.IsUpdated(convQxRoleMenus_Sim.OrderNum) == true)
{
string strComparisonOpOrderNum = objvQxRoleMenus_SimCond.dicFldComparisonOp[convQxRoleMenus_Sim.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQxRoleMenus_Sim.OrderNum, objvQxRoleMenus_SimCond.OrderNum, strComparisonOpOrderNum);
}
if (objvQxRoleMenus_SimCond.IsUpdated(convQxRoleMenus_Sim.IsLeafNode) == true)
{
if (objvQxRoleMenus_SimCond.IsLeafNode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQxRoleMenus_Sim.IsLeafNode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQxRoleMenus_Sim.IsLeafNode);
}
}
if (objvQxRoleMenus_SimCond.IsUpdated(convQxRoleMenus_Sim.MenuSetId) == true)
{
string strComparisonOpMenuSetId = objvQxRoleMenus_SimCond.dicFldComparisonOp[convQxRoleMenus_Sim.MenuSetId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRoleMenus_Sim.MenuSetId, objvQxRoleMenus_SimCond.MenuSetId, strComparisonOpMenuSetId);
}
if (objvQxRoleMenus_SimCond.IsUpdated(convQxRoleMenus_Sim.MenuTitle) == true)
{
string strComparisonOpMenuTitle = objvQxRoleMenus_SimCond.dicFldComparisonOp[convQxRoleMenus_Sim.MenuTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRoleMenus_Sim.MenuTitle, objvQxRoleMenus_SimCond.MenuTitle, strComparisonOpMenuTitle);
}
if (objvQxRoleMenus_SimCond.IsUpdated(convQxRoleMenus_Sim.PageDispModeId) == true)
{
string strComparisonOpPageDispModeId = objvQxRoleMenus_SimCond.dicFldComparisonOp[convQxRoleMenus_Sim.PageDispModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRoleMenus_Sim.PageDispModeId, objvQxRoleMenus_SimCond.PageDispModeId, strComparisonOpPageDispModeId);
}
if (objvQxRoleMenus_SimCond.IsUpdated(convQxRoleMenus_Sim.InUse) == true)
{
if (objvQxRoleMenus_SimCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQxRoleMenus_Sim.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQxRoleMenus_Sim.InUse);
}
}
if (objvQxRoleMenus_SimCond.IsUpdated(convQxRoleMenus_Sim.UpMenuName) == true)
{
string strComparisonOpUpMenuName = objvQxRoleMenus_SimCond.dicFldComparisonOp[convQxRoleMenus_Sim.UpMenuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRoleMenus_Sim.UpMenuName, objvQxRoleMenus_SimCond.UpMenuName, strComparisonOpUpMenuName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vQxRoleMenus_Sim
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v角色菜单_Sim(vQxRoleMenus_Sim)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvQxRoleMenus_SimBL
{
public static RelatedActions_vQxRoleMenus_Sim relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "vQxRoleMenus_SimListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "vQxRoleMenus_SimList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsvQxRoleMenus_SimEN> arrvQxRoleMenus_SimObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvQxRoleMenus_SimDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvQxRoleMenus_SimDA vQxRoleMenus_SimDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvQxRoleMenus_SimDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvQxRoleMenus_SimBL()
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
if (string.IsNullOrEmpty(clsvQxRoleMenus_SimEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxRoleMenus_SimEN._ConnectString);
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
objDS = vQxRoleMenus_SimDA.GetDataSet(strWhereCond);
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
objDS = vQxRoleMenus_SimDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = vQxRoleMenus_SimDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_vQxRoleMenus_Sim(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQxRoleMenus_SimDA.GetDataTable_vQxRoleMenus_Sim(strWhereCond);
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
objDT = vQxRoleMenus_SimDA.GetDataTable(strWhereCond);
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
objDT = vQxRoleMenus_SimDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vQxRoleMenus_SimDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vQxRoleMenus_SimDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vQxRoleMenus_SimDA.GetDataTable_Top(objTopPara);
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
objDT = vQxRoleMenus_SimDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vQxRoleMenus_SimDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = vQxRoleMenus_SimDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vQxRoleMenus_SimDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = vQxRoleMenus_SimDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = vQxRoleMenus_SimDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = vQxRoleMenus_SimDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = vQxRoleMenus_SimDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
public static List<clsvQxRoleMenus_SimEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvQxRoleMenus_SimEN> arrObjLst = new List<clsvQxRoleMenus_SimEN>(); 
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
	clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN = new clsvQxRoleMenus_SimEN();
try
{
objvQxRoleMenus_SimEN.mId = Int32.Parse(objRow[convQxRoleMenus_Sim.mId].ToString().Trim()); //流水号
objvQxRoleMenus_SimEN.RoleId = objRow[convQxRoleMenus_Sim.RoleId].ToString().Trim(); //角色Id
objvQxRoleMenus_SimEN.QxPrjId = objRow[convQxRoleMenus_Sim.QxPrjId].ToString().Trim(); //项目Id
objvQxRoleMenus_SimEN.MenuId = objRow[convQxRoleMenus_Sim.MenuId].ToString().Trim(); //菜单Id
objvQxRoleMenus_SimEN.MenuName = objRow[convQxRoleMenus_Sim.MenuName] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuName].ToString().Trim(); //菜单名
objvQxRoleMenus_SimEN.UpMenuId = objRow[convQxRoleMenus_Sim.UpMenuId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxRoleMenus_SimEN.LinkFile = objRow[convQxRoleMenus_Sim.LinkFile] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.LinkFile].ToString().Trim(); //链接文件
objvQxRoleMenus_SimEN.qsParameters = objRow[convQxRoleMenus_Sim.qsParameters] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.qsParameters].ToString().Trim(); //qs参数
objvQxRoleMenus_SimEN.ImgFile = objRow[convQxRoleMenus_Sim.ImgFile] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.ImgFile].ToString().Trim(); //图像文件
objvQxRoleMenus_SimEN.OrderNum = objRow[convQxRoleMenus_Sim.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRoleMenus_Sim.OrderNum].ToString().Trim()); //排序号
objvQxRoleMenus_SimEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus_Sim.IsLeafNode].ToString().Trim()); //是否叶子
objvQxRoleMenus_SimEN.MenuSetId = objRow[convQxRoleMenus_Sim.MenuSetId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuSetId].ToString().Trim(); //菜单集Id
objvQxRoleMenus_SimEN.MenuTitle = objRow[convQxRoleMenus_Sim.MenuTitle] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuTitle].ToString().Trim(); //菜单标题
objvQxRoleMenus_SimEN.PageDispModeId = objRow[convQxRoleMenus_Sim.PageDispModeId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxRoleMenus_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus_Sim.InUse].ToString().Trim()); //是否在用
objvQxRoleMenus_SimEN.UpMenuName = objRow[convQxRoleMenus_Sim.UpMenuName] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.UpMenuName].ToString().Trim(); //上级菜单名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRoleMenus_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRoleMenus_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvQxRoleMenus_SimEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvQxRoleMenus_SimEN._CurrTabName);
List<clsvQxRoleMenus_SimEN> arrvQxRoleMenus_SimObjLstCache = GetObjLstCache();
IEnumerable <clsvQxRoleMenus_SimEN> arrvQxRoleMenus_SimObjLst_Sel =
arrvQxRoleMenus_SimObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvQxRoleMenus_SimObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxRoleMenus_SimEN> GetObjLst(string strWhereCond)
{
List<clsvQxRoleMenus_SimEN> arrObjLst = new List<clsvQxRoleMenus_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN = new clsvQxRoleMenus_SimEN();
try
{
objvQxRoleMenus_SimEN.mId = Int32.Parse(objRow[convQxRoleMenus_Sim.mId].ToString().Trim()); //流水号
objvQxRoleMenus_SimEN.RoleId = objRow[convQxRoleMenus_Sim.RoleId].ToString().Trim(); //角色Id
objvQxRoleMenus_SimEN.QxPrjId = objRow[convQxRoleMenus_Sim.QxPrjId].ToString().Trim(); //项目Id
objvQxRoleMenus_SimEN.MenuId = objRow[convQxRoleMenus_Sim.MenuId].ToString().Trim(); //菜单Id
objvQxRoleMenus_SimEN.MenuName = objRow[convQxRoleMenus_Sim.MenuName] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuName].ToString().Trim(); //菜单名
objvQxRoleMenus_SimEN.UpMenuId = objRow[convQxRoleMenus_Sim.UpMenuId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxRoleMenus_SimEN.LinkFile = objRow[convQxRoleMenus_Sim.LinkFile] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.LinkFile].ToString().Trim(); //链接文件
objvQxRoleMenus_SimEN.qsParameters = objRow[convQxRoleMenus_Sim.qsParameters] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.qsParameters].ToString().Trim(); //qs参数
objvQxRoleMenus_SimEN.ImgFile = objRow[convQxRoleMenus_Sim.ImgFile] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.ImgFile].ToString().Trim(); //图像文件
objvQxRoleMenus_SimEN.OrderNum = objRow[convQxRoleMenus_Sim.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRoleMenus_Sim.OrderNum].ToString().Trim()); //排序号
objvQxRoleMenus_SimEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus_Sim.IsLeafNode].ToString().Trim()); //是否叶子
objvQxRoleMenus_SimEN.MenuSetId = objRow[convQxRoleMenus_Sim.MenuSetId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuSetId].ToString().Trim(); //菜单集Id
objvQxRoleMenus_SimEN.MenuTitle = objRow[convQxRoleMenus_Sim.MenuTitle] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuTitle].ToString().Trim(); //菜单标题
objvQxRoleMenus_SimEN.PageDispModeId = objRow[convQxRoleMenus_Sim.PageDispModeId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxRoleMenus_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus_Sim.InUse].ToString().Trim()); //是否在用
objvQxRoleMenus_SimEN.UpMenuName = objRow[convQxRoleMenus_Sim.UpMenuName] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.UpMenuName].ToString().Trim(); //上级菜单名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRoleMenus_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRoleMenus_SimEN);
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
public static List<clsvQxRoleMenus_SimEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQxRoleMenus_SimEN> arrObjLst = new List<clsvQxRoleMenus_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN = new clsvQxRoleMenus_SimEN();
try
{
objvQxRoleMenus_SimEN.mId = Int32.Parse(objRow[convQxRoleMenus_Sim.mId].ToString().Trim()); //流水号
objvQxRoleMenus_SimEN.RoleId = objRow[convQxRoleMenus_Sim.RoleId].ToString().Trim(); //角色Id
objvQxRoleMenus_SimEN.QxPrjId = objRow[convQxRoleMenus_Sim.QxPrjId].ToString().Trim(); //项目Id
objvQxRoleMenus_SimEN.MenuId = objRow[convQxRoleMenus_Sim.MenuId].ToString().Trim(); //菜单Id
objvQxRoleMenus_SimEN.MenuName = objRow[convQxRoleMenus_Sim.MenuName] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuName].ToString().Trim(); //菜单名
objvQxRoleMenus_SimEN.UpMenuId = objRow[convQxRoleMenus_Sim.UpMenuId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxRoleMenus_SimEN.LinkFile = objRow[convQxRoleMenus_Sim.LinkFile] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.LinkFile].ToString().Trim(); //链接文件
objvQxRoleMenus_SimEN.qsParameters = objRow[convQxRoleMenus_Sim.qsParameters] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.qsParameters].ToString().Trim(); //qs参数
objvQxRoleMenus_SimEN.ImgFile = objRow[convQxRoleMenus_Sim.ImgFile] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.ImgFile].ToString().Trim(); //图像文件
objvQxRoleMenus_SimEN.OrderNum = objRow[convQxRoleMenus_Sim.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRoleMenus_Sim.OrderNum].ToString().Trim()); //排序号
objvQxRoleMenus_SimEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus_Sim.IsLeafNode].ToString().Trim()); //是否叶子
objvQxRoleMenus_SimEN.MenuSetId = objRow[convQxRoleMenus_Sim.MenuSetId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuSetId].ToString().Trim(); //菜单集Id
objvQxRoleMenus_SimEN.MenuTitle = objRow[convQxRoleMenus_Sim.MenuTitle] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuTitle].ToString().Trim(); //菜单标题
objvQxRoleMenus_SimEN.PageDispModeId = objRow[convQxRoleMenus_Sim.PageDispModeId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxRoleMenus_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus_Sim.InUse].ToString().Trim()); //是否在用
objvQxRoleMenus_SimEN.UpMenuName = objRow[convQxRoleMenus_Sim.UpMenuName] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.UpMenuName].ToString().Trim(); //上级菜单名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRoleMenus_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRoleMenus_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvQxRoleMenus_SimCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvQxRoleMenus_SimEN> GetSubObjLstCache(clsvQxRoleMenus_SimEN objvQxRoleMenus_SimCond)
{
List<clsvQxRoleMenus_SimEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxRoleMenus_SimEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxRoleMenus_Sim.AttributeName)
{
if (objvQxRoleMenus_SimCond.IsUpdated(strFldName) == false) continue;
if (objvQxRoleMenus_SimCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxRoleMenus_SimCond[strFldName].ToString());
}
else
{
if (objvQxRoleMenus_SimCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxRoleMenus_SimCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxRoleMenus_SimCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxRoleMenus_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxRoleMenus_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxRoleMenus_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxRoleMenus_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxRoleMenus_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxRoleMenus_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxRoleMenus_SimCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxRoleMenus_SimCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxRoleMenus_SimCond[strFldName]));
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
public static List<clsvQxRoleMenus_SimEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvQxRoleMenus_SimEN> arrObjLst = new List<clsvQxRoleMenus_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN = new clsvQxRoleMenus_SimEN();
try
{
objvQxRoleMenus_SimEN.mId = Int32.Parse(objRow[convQxRoleMenus_Sim.mId].ToString().Trim()); //流水号
objvQxRoleMenus_SimEN.RoleId = objRow[convQxRoleMenus_Sim.RoleId].ToString().Trim(); //角色Id
objvQxRoleMenus_SimEN.QxPrjId = objRow[convQxRoleMenus_Sim.QxPrjId].ToString().Trim(); //项目Id
objvQxRoleMenus_SimEN.MenuId = objRow[convQxRoleMenus_Sim.MenuId].ToString().Trim(); //菜单Id
objvQxRoleMenus_SimEN.MenuName = objRow[convQxRoleMenus_Sim.MenuName] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuName].ToString().Trim(); //菜单名
objvQxRoleMenus_SimEN.UpMenuId = objRow[convQxRoleMenus_Sim.UpMenuId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxRoleMenus_SimEN.LinkFile = objRow[convQxRoleMenus_Sim.LinkFile] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.LinkFile].ToString().Trim(); //链接文件
objvQxRoleMenus_SimEN.qsParameters = objRow[convQxRoleMenus_Sim.qsParameters] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.qsParameters].ToString().Trim(); //qs参数
objvQxRoleMenus_SimEN.ImgFile = objRow[convQxRoleMenus_Sim.ImgFile] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.ImgFile].ToString().Trim(); //图像文件
objvQxRoleMenus_SimEN.OrderNum = objRow[convQxRoleMenus_Sim.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRoleMenus_Sim.OrderNum].ToString().Trim()); //排序号
objvQxRoleMenus_SimEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus_Sim.IsLeafNode].ToString().Trim()); //是否叶子
objvQxRoleMenus_SimEN.MenuSetId = objRow[convQxRoleMenus_Sim.MenuSetId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuSetId].ToString().Trim(); //菜单集Id
objvQxRoleMenus_SimEN.MenuTitle = objRow[convQxRoleMenus_Sim.MenuTitle] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuTitle].ToString().Trim(); //菜单标题
objvQxRoleMenus_SimEN.PageDispModeId = objRow[convQxRoleMenus_Sim.PageDispModeId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxRoleMenus_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus_Sim.InUse].ToString().Trim()); //是否在用
objvQxRoleMenus_SimEN.UpMenuName = objRow[convQxRoleMenus_Sim.UpMenuName] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.UpMenuName].ToString().Trim(); //上级菜单名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRoleMenus_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRoleMenus_SimEN);
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
public static List<clsvQxRoleMenus_SimEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvQxRoleMenus_SimEN> arrObjLst = new List<clsvQxRoleMenus_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN = new clsvQxRoleMenus_SimEN();
try
{
objvQxRoleMenus_SimEN.mId = Int32.Parse(objRow[convQxRoleMenus_Sim.mId].ToString().Trim()); //流水号
objvQxRoleMenus_SimEN.RoleId = objRow[convQxRoleMenus_Sim.RoleId].ToString().Trim(); //角色Id
objvQxRoleMenus_SimEN.QxPrjId = objRow[convQxRoleMenus_Sim.QxPrjId].ToString().Trim(); //项目Id
objvQxRoleMenus_SimEN.MenuId = objRow[convQxRoleMenus_Sim.MenuId].ToString().Trim(); //菜单Id
objvQxRoleMenus_SimEN.MenuName = objRow[convQxRoleMenus_Sim.MenuName] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuName].ToString().Trim(); //菜单名
objvQxRoleMenus_SimEN.UpMenuId = objRow[convQxRoleMenus_Sim.UpMenuId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxRoleMenus_SimEN.LinkFile = objRow[convQxRoleMenus_Sim.LinkFile] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.LinkFile].ToString().Trim(); //链接文件
objvQxRoleMenus_SimEN.qsParameters = objRow[convQxRoleMenus_Sim.qsParameters] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.qsParameters].ToString().Trim(); //qs参数
objvQxRoleMenus_SimEN.ImgFile = objRow[convQxRoleMenus_Sim.ImgFile] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.ImgFile].ToString().Trim(); //图像文件
objvQxRoleMenus_SimEN.OrderNum = objRow[convQxRoleMenus_Sim.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRoleMenus_Sim.OrderNum].ToString().Trim()); //排序号
objvQxRoleMenus_SimEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus_Sim.IsLeafNode].ToString().Trim()); //是否叶子
objvQxRoleMenus_SimEN.MenuSetId = objRow[convQxRoleMenus_Sim.MenuSetId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuSetId].ToString().Trim(); //菜单集Id
objvQxRoleMenus_SimEN.MenuTitle = objRow[convQxRoleMenus_Sim.MenuTitle] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuTitle].ToString().Trim(); //菜单标题
objvQxRoleMenus_SimEN.PageDispModeId = objRow[convQxRoleMenus_Sim.PageDispModeId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxRoleMenus_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus_Sim.InUse].ToString().Trim()); //是否在用
objvQxRoleMenus_SimEN.UpMenuName = objRow[convQxRoleMenus_Sim.UpMenuName] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.UpMenuName].ToString().Trim(); //上级菜单名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRoleMenus_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRoleMenus_SimEN);
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
List<clsvQxRoleMenus_SimEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvQxRoleMenus_SimEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxRoleMenus_SimEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvQxRoleMenus_SimEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvQxRoleMenus_SimEN> arrObjLst = new List<clsvQxRoleMenus_SimEN>(); 
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
	clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN = new clsvQxRoleMenus_SimEN();
try
{
objvQxRoleMenus_SimEN.mId = Int32.Parse(objRow[convQxRoleMenus_Sim.mId].ToString().Trim()); //流水号
objvQxRoleMenus_SimEN.RoleId = objRow[convQxRoleMenus_Sim.RoleId].ToString().Trim(); //角色Id
objvQxRoleMenus_SimEN.QxPrjId = objRow[convQxRoleMenus_Sim.QxPrjId].ToString().Trim(); //项目Id
objvQxRoleMenus_SimEN.MenuId = objRow[convQxRoleMenus_Sim.MenuId].ToString().Trim(); //菜单Id
objvQxRoleMenus_SimEN.MenuName = objRow[convQxRoleMenus_Sim.MenuName] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuName].ToString().Trim(); //菜单名
objvQxRoleMenus_SimEN.UpMenuId = objRow[convQxRoleMenus_Sim.UpMenuId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxRoleMenus_SimEN.LinkFile = objRow[convQxRoleMenus_Sim.LinkFile] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.LinkFile].ToString().Trim(); //链接文件
objvQxRoleMenus_SimEN.qsParameters = objRow[convQxRoleMenus_Sim.qsParameters] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.qsParameters].ToString().Trim(); //qs参数
objvQxRoleMenus_SimEN.ImgFile = objRow[convQxRoleMenus_Sim.ImgFile] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.ImgFile].ToString().Trim(); //图像文件
objvQxRoleMenus_SimEN.OrderNum = objRow[convQxRoleMenus_Sim.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRoleMenus_Sim.OrderNum].ToString().Trim()); //排序号
objvQxRoleMenus_SimEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus_Sim.IsLeafNode].ToString().Trim()); //是否叶子
objvQxRoleMenus_SimEN.MenuSetId = objRow[convQxRoleMenus_Sim.MenuSetId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuSetId].ToString().Trim(); //菜单集Id
objvQxRoleMenus_SimEN.MenuTitle = objRow[convQxRoleMenus_Sim.MenuTitle] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuTitle].ToString().Trim(); //菜单标题
objvQxRoleMenus_SimEN.PageDispModeId = objRow[convQxRoleMenus_Sim.PageDispModeId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxRoleMenus_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus_Sim.InUse].ToString().Trim()); //是否在用
objvQxRoleMenus_SimEN.UpMenuName = objRow[convQxRoleMenus_Sim.UpMenuName] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.UpMenuName].ToString().Trim(); //上级菜单名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRoleMenus_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRoleMenus_SimEN);
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
public static List<clsvQxRoleMenus_SimEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvQxRoleMenus_SimEN> arrObjLst = new List<clsvQxRoleMenus_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN = new clsvQxRoleMenus_SimEN();
try
{
objvQxRoleMenus_SimEN.mId = Int32.Parse(objRow[convQxRoleMenus_Sim.mId].ToString().Trim()); //流水号
objvQxRoleMenus_SimEN.RoleId = objRow[convQxRoleMenus_Sim.RoleId].ToString().Trim(); //角色Id
objvQxRoleMenus_SimEN.QxPrjId = objRow[convQxRoleMenus_Sim.QxPrjId].ToString().Trim(); //项目Id
objvQxRoleMenus_SimEN.MenuId = objRow[convQxRoleMenus_Sim.MenuId].ToString().Trim(); //菜单Id
objvQxRoleMenus_SimEN.MenuName = objRow[convQxRoleMenus_Sim.MenuName] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuName].ToString().Trim(); //菜单名
objvQxRoleMenus_SimEN.UpMenuId = objRow[convQxRoleMenus_Sim.UpMenuId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxRoleMenus_SimEN.LinkFile = objRow[convQxRoleMenus_Sim.LinkFile] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.LinkFile].ToString().Trim(); //链接文件
objvQxRoleMenus_SimEN.qsParameters = objRow[convQxRoleMenus_Sim.qsParameters] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.qsParameters].ToString().Trim(); //qs参数
objvQxRoleMenus_SimEN.ImgFile = objRow[convQxRoleMenus_Sim.ImgFile] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.ImgFile].ToString().Trim(); //图像文件
objvQxRoleMenus_SimEN.OrderNum = objRow[convQxRoleMenus_Sim.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRoleMenus_Sim.OrderNum].ToString().Trim()); //排序号
objvQxRoleMenus_SimEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus_Sim.IsLeafNode].ToString().Trim()); //是否叶子
objvQxRoleMenus_SimEN.MenuSetId = objRow[convQxRoleMenus_Sim.MenuSetId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuSetId].ToString().Trim(); //菜单集Id
objvQxRoleMenus_SimEN.MenuTitle = objRow[convQxRoleMenus_Sim.MenuTitle] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuTitle].ToString().Trim(); //菜单标题
objvQxRoleMenus_SimEN.PageDispModeId = objRow[convQxRoleMenus_Sim.PageDispModeId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxRoleMenus_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus_Sim.InUse].ToString().Trim()); //是否在用
objvQxRoleMenus_SimEN.UpMenuName = objRow[convQxRoleMenus_Sim.UpMenuName] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.UpMenuName].ToString().Trim(); //上级菜单名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRoleMenus_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRoleMenus_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQxRoleMenus_SimEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvQxRoleMenus_SimEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvQxRoleMenus_SimEN> arrObjLst = new List<clsvQxRoleMenus_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN = new clsvQxRoleMenus_SimEN();
try
{
objvQxRoleMenus_SimEN.mId = Int32.Parse(objRow[convQxRoleMenus_Sim.mId].ToString().Trim()); //流水号
objvQxRoleMenus_SimEN.RoleId = objRow[convQxRoleMenus_Sim.RoleId].ToString().Trim(); //角色Id
objvQxRoleMenus_SimEN.QxPrjId = objRow[convQxRoleMenus_Sim.QxPrjId].ToString().Trim(); //项目Id
objvQxRoleMenus_SimEN.MenuId = objRow[convQxRoleMenus_Sim.MenuId].ToString().Trim(); //菜单Id
objvQxRoleMenus_SimEN.MenuName = objRow[convQxRoleMenus_Sim.MenuName] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuName].ToString().Trim(); //菜单名
objvQxRoleMenus_SimEN.UpMenuId = objRow[convQxRoleMenus_Sim.UpMenuId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxRoleMenus_SimEN.LinkFile = objRow[convQxRoleMenus_Sim.LinkFile] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.LinkFile].ToString().Trim(); //链接文件
objvQxRoleMenus_SimEN.qsParameters = objRow[convQxRoleMenus_Sim.qsParameters] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.qsParameters].ToString().Trim(); //qs参数
objvQxRoleMenus_SimEN.ImgFile = objRow[convQxRoleMenus_Sim.ImgFile] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.ImgFile].ToString().Trim(); //图像文件
objvQxRoleMenus_SimEN.OrderNum = objRow[convQxRoleMenus_Sim.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRoleMenus_Sim.OrderNum].ToString().Trim()); //排序号
objvQxRoleMenus_SimEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus_Sim.IsLeafNode].ToString().Trim()); //是否叶子
objvQxRoleMenus_SimEN.MenuSetId = objRow[convQxRoleMenus_Sim.MenuSetId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuSetId].ToString().Trim(); //菜单集Id
objvQxRoleMenus_SimEN.MenuTitle = objRow[convQxRoleMenus_Sim.MenuTitle] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuTitle].ToString().Trim(); //菜单标题
objvQxRoleMenus_SimEN.PageDispModeId = objRow[convQxRoleMenus_Sim.PageDispModeId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxRoleMenus_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus_Sim.InUse].ToString().Trim()); //是否在用
objvQxRoleMenus_SimEN.UpMenuName = objRow[convQxRoleMenus_Sim.UpMenuName] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.UpMenuName].ToString().Trim(); //上级菜单名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRoleMenus_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRoleMenus_SimEN);
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
public static List<clsvQxRoleMenus_SimEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvQxRoleMenus_SimEN> arrObjLst = new List<clsvQxRoleMenus_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN = new clsvQxRoleMenus_SimEN();
try
{
objvQxRoleMenus_SimEN.mId = Int32.Parse(objRow[convQxRoleMenus_Sim.mId].ToString().Trim()); //流水号
objvQxRoleMenus_SimEN.RoleId = objRow[convQxRoleMenus_Sim.RoleId].ToString().Trim(); //角色Id
objvQxRoleMenus_SimEN.QxPrjId = objRow[convQxRoleMenus_Sim.QxPrjId].ToString().Trim(); //项目Id
objvQxRoleMenus_SimEN.MenuId = objRow[convQxRoleMenus_Sim.MenuId].ToString().Trim(); //菜单Id
objvQxRoleMenus_SimEN.MenuName = objRow[convQxRoleMenus_Sim.MenuName] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuName].ToString().Trim(); //菜单名
objvQxRoleMenus_SimEN.UpMenuId = objRow[convQxRoleMenus_Sim.UpMenuId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxRoleMenus_SimEN.LinkFile = objRow[convQxRoleMenus_Sim.LinkFile] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.LinkFile].ToString().Trim(); //链接文件
objvQxRoleMenus_SimEN.qsParameters = objRow[convQxRoleMenus_Sim.qsParameters] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.qsParameters].ToString().Trim(); //qs参数
objvQxRoleMenus_SimEN.ImgFile = objRow[convQxRoleMenus_Sim.ImgFile] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.ImgFile].ToString().Trim(); //图像文件
objvQxRoleMenus_SimEN.OrderNum = objRow[convQxRoleMenus_Sim.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRoleMenus_Sim.OrderNum].ToString().Trim()); //排序号
objvQxRoleMenus_SimEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus_Sim.IsLeafNode].ToString().Trim()); //是否叶子
objvQxRoleMenus_SimEN.MenuSetId = objRow[convQxRoleMenus_Sim.MenuSetId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuSetId].ToString().Trim(); //菜单集Id
objvQxRoleMenus_SimEN.MenuTitle = objRow[convQxRoleMenus_Sim.MenuTitle] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuTitle].ToString().Trim(); //菜单标题
objvQxRoleMenus_SimEN.PageDispModeId = objRow[convQxRoleMenus_Sim.PageDispModeId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxRoleMenus_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus_Sim.InUse].ToString().Trim()); //是否在用
objvQxRoleMenus_SimEN.UpMenuName = objRow[convQxRoleMenus_Sim.UpMenuName] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.UpMenuName].ToString().Trim(); //上级菜单名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRoleMenus_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRoleMenus_SimEN);
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
public static IEnumerable<clsvQxRoleMenus_SimEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsvQxRoleMenus_SimEN objvQxRoleMenus_SimCond, string strOrderBy)
{
List<clsvQxRoleMenus_SimEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxRoleMenus_SimEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxRoleMenus_Sim.AttributeName)
{
if (objvQxRoleMenus_SimCond.IsUpdated(strFldName) == false) continue;
if (objvQxRoleMenus_SimCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxRoleMenus_SimCond[strFldName].ToString());
}
else
{
if (objvQxRoleMenus_SimCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxRoleMenus_SimCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxRoleMenus_SimCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxRoleMenus_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxRoleMenus_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxRoleMenus_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxRoleMenus_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxRoleMenus_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxRoleMenus_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxRoleMenus_SimCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxRoleMenus_SimCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxRoleMenus_SimCond[strFldName]));
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
public static IEnumerable<clsvQxRoleMenus_SimEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsvQxRoleMenus_SimEN objvQxRoleMenus_SimCond = JsonConvert.DeserializeObject<clsvQxRoleMenus_SimEN>(objPagerPara.whereCond);
if (objvQxRoleMenus_SimCond.sfFldComparisonOp == null)
{
objvQxRoleMenus_SimCond.dicFldComparisonOp = null;
}
else
{
objvQxRoleMenus_SimCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objvQxRoleMenus_SimCond.sfFldComparisonOp);
}
clsvQxRoleMenus_SimBL.SetUpdFlag(objvQxRoleMenus_SimCond);
 try
{
CheckProperty4Condition(objvQxRoleMenus_SimCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsvQxRoleMenus_SimBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objvQxRoleMenus_SimCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxRoleMenus_SimEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsvQxRoleMenus_SimEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxRoleMenus_SimEN> arrObjLst = new List<clsvQxRoleMenus_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN = new clsvQxRoleMenus_SimEN();
try
{
objvQxRoleMenus_SimEN.mId = Int32.Parse(objRow[convQxRoleMenus_Sim.mId].ToString().Trim()); //流水号
objvQxRoleMenus_SimEN.RoleId = objRow[convQxRoleMenus_Sim.RoleId].ToString().Trim(); //角色Id
objvQxRoleMenus_SimEN.QxPrjId = objRow[convQxRoleMenus_Sim.QxPrjId].ToString().Trim(); //项目Id
objvQxRoleMenus_SimEN.MenuId = objRow[convQxRoleMenus_Sim.MenuId].ToString().Trim(); //菜单Id
objvQxRoleMenus_SimEN.MenuName = objRow[convQxRoleMenus_Sim.MenuName] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuName].ToString().Trim(); //菜单名
objvQxRoleMenus_SimEN.UpMenuId = objRow[convQxRoleMenus_Sim.UpMenuId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxRoleMenus_SimEN.LinkFile = objRow[convQxRoleMenus_Sim.LinkFile] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.LinkFile].ToString().Trim(); //链接文件
objvQxRoleMenus_SimEN.qsParameters = objRow[convQxRoleMenus_Sim.qsParameters] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.qsParameters].ToString().Trim(); //qs参数
objvQxRoleMenus_SimEN.ImgFile = objRow[convQxRoleMenus_Sim.ImgFile] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.ImgFile].ToString().Trim(); //图像文件
objvQxRoleMenus_SimEN.OrderNum = objRow[convQxRoleMenus_Sim.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRoleMenus_Sim.OrderNum].ToString().Trim()); //排序号
objvQxRoleMenus_SimEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus_Sim.IsLeafNode].ToString().Trim()); //是否叶子
objvQxRoleMenus_SimEN.MenuSetId = objRow[convQxRoleMenus_Sim.MenuSetId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuSetId].ToString().Trim(); //菜单集Id
objvQxRoleMenus_SimEN.MenuTitle = objRow[convQxRoleMenus_Sim.MenuTitle] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuTitle].ToString().Trim(); //菜单标题
objvQxRoleMenus_SimEN.PageDispModeId = objRow[convQxRoleMenus_Sim.PageDispModeId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxRoleMenus_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus_Sim.InUse].ToString().Trim()); //是否在用
objvQxRoleMenus_SimEN.UpMenuName = objRow[convQxRoleMenus_Sim.UpMenuName] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.UpMenuName].ToString().Trim(); //上级菜单名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRoleMenus_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRoleMenus_SimEN);
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
public static List<clsvQxRoleMenus_SimEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxRoleMenus_SimEN> arrObjLst = new List<clsvQxRoleMenus_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN = new clsvQxRoleMenus_SimEN();
try
{
objvQxRoleMenus_SimEN.mId = Int32.Parse(objRow[convQxRoleMenus_Sim.mId].ToString().Trim()); //流水号
objvQxRoleMenus_SimEN.RoleId = objRow[convQxRoleMenus_Sim.RoleId].ToString().Trim(); //角色Id
objvQxRoleMenus_SimEN.QxPrjId = objRow[convQxRoleMenus_Sim.QxPrjId].ToString().Trim(); //项目Id
objvQxRoleMenus_SimEN.MenuId = objRow[convQxRoleMenus_Sim.MenuId].ToString().Trim(); //菜单Id
objvQxRoleMenus_SimEN.MenuName = objRow[convQxRoleMenus_Sim.MenuName] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuName].ToString().Trim(); //菜单名
objvQxRoleMenus_SimEN.UpMenuId = objRow[convQxRoleMenus_Sim.UpMenuId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxRoleMenus_SimEN.LinkFile = objRow[convQxRoleMenus_Sim.LinkFile] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.LinkFile].ToString().Trim(); //链接文件
objvQxRoleMenus_SimEN.qsParameters = objRow[convQxRoleMenus_Sim.qsParameters] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.qsParameters].ToString().Trim(); //qs参数
objvQxRoleMenus_SimEN.ImgFile = objRow[convQxRoleMenus_Sim.ImgFile] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.ImgFile].ToString().Trim(); //图像文件
objvQxRoleMenus_SimEN.OrderNum = objRow[convQxRoleMenus_Sim.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRoleMenus_Sim.OrderNum].ToString().Trim()); //排序号
objvQxRoleMenus_SimEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus_Sim.IsLeafNode].ToString().Trim()); //是否叶子
objvQxRoleMenus_SimEN.MenuSetId = objRow[convQxRoleMenus_Sim.MenuSetId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuSetId].ToString().Trim(); //菜单集Id
objvQxRoleMenus_SimEN.MenuTitle = objRow[convQxRoleMenus_Sim.MenuTitle] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuTitle].ToString().Trim(); //菜单标题
objvQxRoleMenus_SimEN.PageDispModeId = objRow[convQxRoleMenus_Sim.PageDispModeId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxRoleMenus_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus_Sim.InUse].ToString().Trim()); //是否在用
objvQxRoleMenus_SimEN.UpMenuName = objRow[convQxRoleMenus_Sim.UpMenuName] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.UpMenuName].ToString().Trim(); //上级菜单名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRoleMenus_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRoleMenus_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxRoleMenus_SimEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvQxRoleMenus_SimEN> arrObjLst = new List<clsvQxRoleMenus_SimEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN = new clsvQxRoleMenus_SimEN();
try
{
objvQxRoleMenus_SimEN.mId = Int32.Parse(objRow[convQxRoleMenus_Sim.mId].ToString().Trim()); //流水号
objvQxRoleMenus_SimEN.RoleId = objRow[convQxRoleMenus_Sim.RoleId].ToString().Trim(); //角色Id
objvQxRoleMenus_SimEN.QxPrjId = objRow[convQxRoleMenus_Sim.QxPrjId].ToString().Trim(); //项目Id
objvQxRoleMenus_SimEN.MenuId = objRow[convQxRoleMenus_Sim.MenuId].ToString().Trim(); //菜单Id
objvQxRoleMenus_SimEN.MenuName = objRow[convQxRoleMenus_Sim.MenuName] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuName].ToString().Trim(); //菜单名
objvQxRoleMenus_SimEN.UpMenuId = objRow[convQxRoleMenus_Sim.UpMenuId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxRoleMenus_SimEN.LinkFile = objRow[convQxRoleMenus_Sim.LinkFile] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.LinkFile].ToString().Trim(); //链接文件
objvQxRoleMenus_SimEN.qsParameters = objRow[convQxRoleMenus_Sim.qsParameters] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.qsParameters].ToString().Trim(); //qs参数
objvQxRoleMenus_SimEN.ImgFile = objRow[convQxRoleMenus_Sim.ImgFile] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.ImgFile].ToString().Trim(); //图像文件
objvQxRoleMenus_SimEN.OrderNum = objRow[convQxRoleMenus_Sim.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRoleMenus_Sim.OrderNum].ToString().Trim()); //排序号
objvQxRoleMenus_SimEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus_Sim.IsLeafNode].ToString().Trim()); //是否叶子
objvQxRoleMenus_SimEN.MenuSetId = objRow[convQxRoleMenus_Sim.MenuSetId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuSetId].ToString().Trim(); //菜单集Id
objvQxRoleMenus_SimEN.MenuTitle = objRow[convQxRoleMenus_Sim.MenuTitle] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.MenuTitle].ToString().Trim(); //菜单标题
objvQxRoleMenus_SimEN.PageDispModeId = objRow[convQxRoleMenus_Sim.PageDispModeId] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxRoleMenus_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxRoleMenus_Sim.InUse].ToString().Trim()); //是否在用
objvQxRoleMenus_SimEN.UpMenuName = objRow[convQxRoleMenus_Sim.UpMenuName] == DBNull.Value ? null : objRow[convQxRoleMenus_Sim.UpMenuName].ToString().Trim(); //上级菜单名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRoleMenus_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRoleMenus_SimEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvQxRoleMenus_SimEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxRoleMenus_Sim(ref clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN)
{
bool bolResult = vQxRoleMenus_SimDA.GetvQxRoleMenus_Sim(ref objvQxRoleMenus_SimEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxRoleMenus_SimEN GetObjBymId(long lngmId)
{
clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN = vQxRoleMenus_SimDA.GetObjBymId(lngmId);
return objvQxRoleMenus_SimEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvQxRoleMenus_SimEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN = vQxRoleMenus_SimDA.GetFirstObj(strWhereCond);
 return objvQxRoleMenus_SimEN;
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
public static clsvQxRoleMenus_SimEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN = vQxRoleMenus_SimDA.GetObjByDataRow(objRow);
 return objvQxRoleMenus_SimEN;
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
public static clsvQxRoleMenus_SimEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN = vQxRoleMenus_SimDA.GetObjByDataRow(objRow);
 return objvQxRoleMenus_SimEN;
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
 /// <param name = "lstvQxRoleMenus_SimObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxRoleMenus_SimEN GetObjBymIdFromList(long lngmId, List<clsvQxRoleMenus_SimEN> lstvQxRoleMenus_SimObjLst)
{
foreach (clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN in lstvQxRoleMenus_SimObjLst)
{
if (objvQxRoleMenus_SimEN.mId == lngmId)
{
return objvQxRoleMenus_SimEN;
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
 lngmId = new clsvQxRoleMenus_SimDA().GetFirstID(strWhereCond);
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
 arrList = vQxRoleMenus_SimDA.GetID(strWhereCond);
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
bool bolIsExist = vQxRoleMenus_SimDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vQxRoleMenus_SimDA.IsExist(lngmId);
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
 bolIsExist = clsvQxRoleMenus_SimDA.IsExistTable();
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
 bolIsExist = vQxRoleMenus_SimDA.IsExistTable(strTabName);
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
 /// <param name = "objvQxRoleMenus_SimENS">源对象</param>
 /// <param name = "objvQxRoleMenus_SimENT">目标对象</param>
 public static void CopyTo(clsvQxRoleMenus_SimEN objvQxRoleMenus_SimENS, clsvQxRoleMenus_SimEN objvQxRoleMenus_SimENT)
{
try
{
objvQxRoleMenus_SimENT.mId = objvQxRoleMenus_SimENS.mId; //流水号
objvQxRoleMenus_SimENT.RoleId = objvQxRoleMenus_SimENS.RoleId; //角色Id
objvQxRoleMenus_SimENT.QxPrjId = objvQxRoleMenus_SimENS.QxPrjId; //项目Id
objvQxRoleMenus_SimENT.MenuId = objvQxRoleMenus_SimENS.MenuId; //菜单Id
objvQxRoleMenus_SimENT.MenuName = objvQxRoleMenus_SimENS.MenuName; //菜单名
objvQxRoleMenus_SimENT.UpMenuId = objvQxRoleMenus_SimENS.UpMenuId; //上级菜单Id
objvQxRoleMenus_SimENT.LinkFile = objvQxRoleMenus_SimENS.LinkFile; //链接文件
objvQxRoleMenus_SimENT.qsParameters = objvQxRoleMenus_SimENS.qsParameters; //qs参数
objvQxRoleMenus_SimENT.ImgFile = objvQxRoleMenus_SimENS.ImgFile; //图像文件
objvQxRoleMenus_SimENT.OrderNum = objvQxRoleMenus_SimENS.OrderNum; //排序号
objvQxRoleMenus_SimENT.IsLeafNode = objvQxRoleMenus_SimENS.IsLeafNode; //是否叶子
objvQxRoleMenus_SimENT.MenuSetId = objvQxRoleMenus_SimENS.MenuSetId; //菜单集Id
objvQxRoleMenus_SimENT.MenuTitle = objvQxRoleMenus_SimENS.MenuTitle; //菜单标题
objvQxRoleMenus_SimENT.PageDispModeId = objvQxRoleMenus_SimENS.PageDispModeId; //页面显示模式Id
objvQxRoleMenus_SimENT.InUse = objvQxRoleMenus_SimENS.InUse; //是否在用
objvQxRoleMenus_SimENT.UpMenuName = objvQxRoleMenus_SimENS.UpMenuName; //上级菜单名
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
 /// <param name = "objvQxRoleMenus_SimEN">源简化对象</param>
 public static void SetUpdFlag(clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN)
{
try
{
objvQxRoleMenus_SimEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvQxRoleMenus_SimEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convQxRoleMenus_Sim.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRoleMenus_SimEN.mId = objvQxRoleMenus_SimEN.mId; //流水号
}
if (arrFldSet.Contains(convQxRoleMenus_Sim.RoleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRoleMenus_SimEN.RoleId = objvQxRoleMenus_SimEN.RoleId; //角色Id
}
if (arrFldSet.Contains(convQxRoleMenus_Sim.QxPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRoleMenus_SimEN.QxPrjId = objvQxRoleMenus_SimEN.QxPrjId; //项目Id
}
if (arrFldSet.Contains(convQxRoleMenus_Sim.MenuId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRoleMenus_SimEN.MenuId = objvQxRoleMenus_SimEN.MenuId; //菜单Id
}
if (arrFldSet.Contains(convQxRoleMenus_Sim.MenuName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRoleMenus_SimEN.MenuName = objvQxRoleMenus_SimEN.MenuName == "[null]" ? null :  objvQxRoleMenus_SimEN.MenuName; //菜单名
}
if (arrFldSet.Contains(convQxRoleMenus_Sim.UpMenuId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRoleMenus_SimEN.UpMenuId = objvQxRoleMenus_SimEN.UpMenuId == "[null]" ? null :  objvQxRoleMenus_SimEN.UpMenuId; //上级菜单Id
}
if (arrFldSet.Contains(convQxRoleMenus_Sim.LinkFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRoleMenus_SimEN.LinkFile = objvQxRoleMenus_SimEN.LinkFile == "[null]" ? null :  objvQxRoleMenus_SimEN.LinkFile; //链接文件
}
if (arrFldSet.Contains(convQxRoleMenus_Sim.qsParameters, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRoleMenus_SimEN.qsParameters = objvQxRoleMenus_SimEN.qsParameters == "[null]" ? null :  objvQxRoleMenus_SimEN.qsParameters; //qs参数
}
if (arrFldSet.Contains(convQxRoleMenus_Sim.ImgFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRoleMenus_SimEN.ImgFile = objvQxRoleMenus_SimEN.ImgFile == "[null]" ? null :  objvQxRoleMenus_SimEN.ImgFile; //图像文件
}
if (arrFldSet.Contains(convQxRoleMenus_Sim.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRoleMenus_SimEN.OrderNum = objvQxRoleMenus_SimEN.OrderNum; //排序号
}
if (arrFldSet.Contains(convQxRoleMenus_Sim.IsLeafNode, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRoleMenus_SimEN.IsLeafNode = objvQxRoleMenus_SimEN.IsLeafNode; //是否叶子
}
if (arrFldSet.Contains(convQxRoleMenus_Sim.MenuSetId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRoleMenus_SimEN.MenuSetId = objvQxRoleMenus_SimEN.MenuSetId == "[null]" ? null :  objvQxRoleMenus_SimEN.MenuSetId; //菜单集Id
}
if (arrFldSet.Contains(convQxRoleMenus_Sim.MenuTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRoleMenus_SimEN.MenuTitle = objvQxRoleMenus_SimEN.MenuTitle == "[null]" ? null :  objvQxRoleMenus_SimEN.MenuTitle; //菜单标题
}
if (arrFldSet.Contains(convQxRoleMenus_Sim.PageDispModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRoleMenus_SimEN.PageDispModeId = objvQxRoleMenus_SimEN.PageDispModeId == "[null]" ? null :  objvQxRoleMenus_SimEN.PageDispModeId; //页面显示模式Id
}
if (arrFldSet.Contains(convQxRoleMenus_Sim.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRoleMenus_SimEN.InUse = objvQxRoleMenus_SimEN.InUse; //是否在用
}
if (arrFldSet.Contains(convQxRoleMenus_Sim.UpMenuName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRoleMenus_SimEN.UpMenuName = objvQxRoleMenus_SimEN.UpMenuName == "[null]" ? null :  objvQxRoleMenus_SimEN.UpMenuName; //上级菜单名
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
 /// <param name = "objvQxRoleMenus_SimEN">源简化对象</param>
 public static void AccessFldValueNull(clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN)
{
try
{
if (objvQxRoleMenus_SimEN.MenuName == "[null]") objvQxRoleMenus_SimEN.MenuName = null; //菜单名
if (objvQxRoleMenus_SimEN.UpMenuId == "[null]") objvQxRoleMenus_SimEN.UpMenuId = null; //上级菜单Id
if (objvQxRoleMenus_SimEN.LinkFile == "[null]") objvQxRoleMenus_SimEN.LinkFile = null; //链接文件
if (objvQxRoleMenus_SimEN.qsParameters == "[null]") objvQxRoleMenus_SimEN.qsParameters = null; //qs参数
if (objvQxRoleMenus_SimEN.ImgFile == "[null]") objvQxRoleMenus_SimEN.ImgFile = null; //图像文件
if (objvQxRoleMenus_SimEN.MenuSetId == "[null]") objvQxRoleMenus_SimEN.MenuSetId = null; //菜单集Id
if (objvQxRoleMenus_SimEN.MenuTitle == "[null]") objvQxRoleMenus_SimEN.MenuTitle = null; //菜单标题
if (objvQxRoleMenus_SimEN.PageDispModeId == "[null]") objvQxRoleMenus_SimEN.PageDispModeId = null; //页面显示模式Id
if (objvQxRoleMenus_SimEN.UpMenuName == "[null]") objvQxRoleMenus_SimEN.UpMenuName = null; //上级菜单名
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
public static void CheckProperty4Condition(clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN)
{
 vQxRoleMenus_SimDA.CheckProperty4Condition(objvQxRoleMenus_SimEN);
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
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvQxRoleMenus_SimObjLstCache == null)
//{
//arrvQxRoleMenus_SimObjLstCache = vQxRoleMenus_SimDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxRoleMenus_SimEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvQxRoleMenus_SimEN._CurrTabName);
List<clsvQxRoleMenus_SimEN> arrvQxRoleMenus_SimObjLstCache = GetObjLstCache();
IEnumerable <clsvQxRoleMenus_SimEN> arrvQxRoleMenus_SimObjLst_Sel =
arrvQxRoleMenus_SimObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvQxRoleMenus_SimObjLst_Sel.Count() == 0)
{
   clsvQxRoleMenus_SimEN obj = clsvQxRoleMenus_SimBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvQxRoleMenus_SimObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxRoleMenus_SimEN> GetAllvQxRoleMenus_SimObjLstCache()
{
//获取缓存中的对象列表
List<clsvQxRoleMenus_SimEN> arrvQxRoleMenus_SimObjLstCache = GetObjLstCache(); 
return arrvQxRoleMenus_SimObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxRoleMenus_SimEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvQxRoleMenus_SimEN._CurrTabName);
List<clsvQxRoleMenus_SimEN> arrvQxRoleMenus_SimObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQxRoleMenus_SimObjLstCache;
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
string strKey = string.Format("{0}", clsvQxRoleMenus_SimEN._CurrTabName);
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
 /// <param name = "lstvQxRoleMenus_SimObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsvQxRoleMenus_SimEN> lstvQxRoleMenus_SimObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstvQxRoleMenus_SimObjLst, writer);
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
 /// <param name = "lstvQxRoleMenus_SimObjLst">[clsvQxRoleMenus_SimEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsvQxRoleMenus_SimEN> lstvQxRoleMenus_SimObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsvQxRoleMenus_SimBL.listXmlNode);
writer.WriteStartElement(clsvQxRoleMenus_SimBL.itemsXmlNode);
foreach (clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN in lstvQxRoleMenus_SimObjLst)
{
clsvQxRoleMenus_SimBL.SerializeXML(writer, objvQxRoleMenus_SimEN);
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
 /// <param name = "objvQxRoleMenus_SimEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN)
{
writer.WriteStartElement(clsvQxRoleMenus_SimBL.itemXmlNode);
 
writer.WriteElementString(convQxRoleMenus_Sim.mId, objvQxRoleMenus_SimEN.mId.ToString(CultureInfo.InvariantCulture));
 
if (objvQxRoleMenus_SimEN.RoleId != null)
{
writer.WriteElementString(convQxRoleMenus_Sim.RoleId, objvQxRoleMenus_SimEN.RoleId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxRoleMenus_SimEN.QxPrjId != null)
{
writer.WriteElementString(convQxRoleMenus_Sim.QxPrjId, objvQxRoleMenus_SimEN.QxPrjId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxRoleMenus_SimEN.MenuId != null)
{
writer.WriteElementString(convQxRoleMenus_Sim.MenuId, objvQxRoleMenus_SimEN.MenuId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxRoleMenus_SimEN.MenuName != null)
{
writer.WriteElementString(convQxRoleMenus_Sim.MenuName, objvQxRoleMenus_SimEN.MenuName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxRoleMenus_SimEN.UpMenuId != null)
{
writer.WriteElementString(convQxRoleMenus_Sim.UpMenuId, objvQxRoleMenus_SimEN.UpMenuId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxRoleMenus_SimEN.LinkFile != null)
{
writer.WriteElementString(convQxRoleMenus_Sim.LinkFile, objvQxRoleMenus_SimEN.LinkFile.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxRoleMenus_SimEN.qsParameters != null)
{
writer.WriteElementString(convQxRoleMenus_Sim.qsParameters, objvQxRoleMenus_SimEN.qsParameters.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxRoleMenus_SimEN.ImgFile != null)
{
writer.WriteElementString(convQxRoleMenus_Sim.ImgFile, objvQxRoleMenus_SimEN.ImgFile.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convQxRoleMenus_Sim.OrderNum, objvQxRoleMenus_SimEN.OrderNum.ToString());
 
writer.WriteElementString(convQxRoleMenus_Sim.IsLeafNode, objvQxRoleMenus_SimEN.IsLeafNode.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objvQxRoleMenus_SimEN.MenuSetId != null)
{
writer.WriteElementString(convQxRoleMenus_Sim.MenuSetId, objvQxRoleMenus_SimEN.MenuSetId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxRoleMenus_SimEN.MenuTitle != null)
{
writer.WriteElementString(convQxRoleMenus_Sim.MenuTitle, objvQxRoleMenus_SimEN.MenuTitle.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxRoleMenus_SimEN.PageDispModeId != null)
{
writer.WriteElementString(convQxRoleMenus_Sim.PageDispModeId, objvQxRoleMenus_SimEN.PageDispModeId.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convQxRoleMenus_Sim.InUse, objvQxRoleMenus_SimEN.InUse.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objvQxRoleMenus_SimEN.UpMenuName != null)
{
writer.WriteElementString(convQxRoleMenus_Sim.UpMenuName, objvQxRoleMenus_SimEN.UpMenuName.ToString(CultureInfo.InvariantCulture));
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
public static clsvQxRoleMenus_SimEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN = new clsvQxRoleMenus_SimEN();
reader.Read();
while (!(reader.Name == clsvQxRoleMenus_SimBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(convQxRoleMenus_Sim.mId))
{
objvQxRoleMenus_SimEN.mId = reader.ReadElementContentAsLong();
}
if (reader.IsStartElement(convQxRoleMenus_Sim.RoleId))
{
objvQxRoleMenus_SimEN.RoleId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxRoleMenus_Sim.QxPrjId))
{
objvQxRoleMenus_SimEN.QxPrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxRoleMenus_Sim.MenuId))
{
objvQxRoleMenus_SimEN.MenuId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxRoleMenus_Sim.MenuName))
{
objvQxRoleMenus_SimEN.MenuName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxRoleMenus_Sim.UpMenuId))
{
objvQxRoleMenus_SimEN.UpMenuId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxRoleMenus_Sim.LinkFile))
{
objvQxRoleMenus_SimEN.LinkFile = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxRoleMenus_Sim.qsParameters))
{
objvQxRoleMenus_SimEN.qsParameters = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxRoleMenus_Sim.ImgFile))
{
objvQxRoleMenus_SimEN.ImgFile = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxRoleMenus_Sim.OrderNum))
{
objvQxRoleMenus_SimEN.OrderNum = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(convQxRoleMenus_Sim.IsLeafNode))
{
objvQxRoleMenus_SimEN.IsLeafNode = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(convQxRoleMenus_Sim.MenuSetId))
{
objvQxRoleMenus_SimEN.MenuSetId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxRoleMenus_Sim.MenuTitle))
{
objvQxRoleMenus_SimEN.MenuTitle = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxRoleMenus_Sim.PageDispModeId))
{
objvQxRoleMenus_SimEN.PageDispModeId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxRoleMenus_Sim.InUse))
{
objvQxRoleMenus_SimEN.InUse = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(convQxRoleMenus_Sim.UpMenuName))
{
objvQxRoleMenus_SimEN.UpMenuName = reader.ReadElementContentAsString();
}
}
return objvQxRoleMenus_SimEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strvQxRoleMenus_SimObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsvQxRoleMenus_SimEN GetObjFromXmlStr(string strvQxRoleMenus_SimObjXmlStr)
{
clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN = new clsvQxRoleMenus_SimEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strvQxRoleMenus_SimObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsvQxRoleMenus_SimBL.itemXmlNode))
{
objvQxRoleMenus_SimEN = GetObjFromXml(reader);
return objvQxRoleMenus_SimEN;
}
}
return objvQxRoleMenus_SimEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objvQxRoleMenus_SimEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objvQxRoleMenus_SimEN);
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
if (strInFldName != convQxRoleMenus_Sim.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convQxRoleMenus_Sim.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convQxRoleMenus_Sim.AttributeName));
throw new Exception(strMsg);
}
var objvQxRoleMenus_Sim = clsvQxRoleMenus_SimBL.GetObjBymIdCache(lngmId);
if (objvQxRoleMenus_Sim == null) return "";
return objvQxRoleMenus_Sim[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objvQxRoleMenus_SimEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsvQxRoleMenus_SimEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objvQxRoleMenus_SimEN[strField]);
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
 /// <param name = "lstvQxRoleMenus_SimObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsvQxRoleMenus_SimEN> lstvQxRoleMenus_SimObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstvQxRoleMenus_SimObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN in lstvQxRoleMenus_SimObjLst)
{
string strJSON_One = SerializeObjToJSON(objvQxRoleMenus_SimEN);
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
int intRecCount = clsvQxRoleMenus_SimDA.GetRecCount(strTabName);
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
int intRecCount = clsvQxRoleMenus_SimDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvQxRoleMenus_SimDA.GetRecCount();
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
int intRecCount = clsvQxRoleMenus_SimDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvQxRoleMenus_SimCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvQxRoleMenus_SimEN objvQxRoleMenus_SimCond)
{
List<clsvQxRoleMenus_SimEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxRoleMenus_SimEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxRoleMenus_Sim.AttributeName)
{
if (objvQxRoleMenus_SimCond.IsUpdated(strFldName) == false) continue;
if (objvQxRoleMenus_SimCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxRoleMenus_SimCond[strFldName].ToString());
}
else
{
if (objvQxRoleMenus_SimCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxRoleMenus_SimCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxRoleMenus_SimCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxRoleMenus_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxRoleMenus_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxRoleMenus_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxRoleMenus_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxRoleMenus_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxRoleMenus_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxRoleMenus_SimCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxRoleMenus_SimCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxRoleMenus_SimCond[strFldName]));
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
 List<string> arrList = clsvQxRoleMenus_SimDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vQxRoleMenus_SimDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vQxRoleMenus_SimDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}