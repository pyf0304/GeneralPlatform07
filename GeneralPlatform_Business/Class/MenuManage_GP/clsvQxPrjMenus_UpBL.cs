
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPrjMenus_UpBL
 表名:vQxPrjMenus_Up(00140080)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:34:15
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
public static class  clsvQxPrjMenus_UpBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strMenuIdUp">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxPrjMenus_UpEN GetObj(this K_MenuIdUp_vQxPrjMenus_Up myKey)
{
clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN = clsvQxPrjMenus_UpBL.vQxPrjMenus_UpDA.GetObjByMenuIdUp(myKey.Value);
return objvQxPrjMenus_UpEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_UpEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_UpEN SetMenuIdUp(this clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN, string strMenuIdUp, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuIdUp, 8, convQxPrjMenus_Up.MenuIdUp);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMenuIdUp, 8, convQxPrjMenus_Up.MenuIdUp);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_UpEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_UpEN SetMenuName(this clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN, string strMenuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMenuName, convQxPrjMenus_Up.MenuName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuName, 50, convQxPrjMenus_Up.MenuName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_UpEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_UpEN SetQxPrjId(this clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN, string strQxPrjId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxPrjMenus_Up.QxPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxPrjMenus_Up.QxPrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_UpEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_UpEN SetPrjName(this clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN, string strPrjName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convQxPrjMenus_Up.PrjName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_UpEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_UpEN SetUpMenuId(this clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN, string strUpMenuId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpMenuId, 8, convQxPrjMenus_Up.UpMenuId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUpMenuId, 8, convQxPrjMenus_Up.UpMenuId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_UpEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_UpEN SetLinkFile(this clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN, string strLinkFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLinkFile, 500, convQxPrjMenus_Up.LinkFile);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_UpEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_UpEN SetqsParameters(this clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN, string strqsParameters, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strqsParameters, 200, convQxPrjMenus_Up.qsParameters);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_UpEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_UpEN SetImgFile(this clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN, string strImgFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strImgFile, 300, convQxPrjMenus_Up.ImgFile);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_UpEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_UpEN SetOrderNum(this clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN, int? intOrderNum, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_UpEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_UpEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_UpEN SetMenuSetId(this clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN, string strMenuSetId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMenuSetId, convQxPrjMenus_Up.MenuSetId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuSetId, 4, convQxPrjMenus_Up.MenuSetId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMenuSetId, 4, convQxPrjMenus_Up.MenuSetId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_UpEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_UpEN SetMenuSetName(this clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN, string strMenuSetName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuSetName, 50, convQxPrjMenus_Up.MenuSetName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_UpEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_UpEN SetMenuTitle(this clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN, string strMenuTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuTitle, 50, convQxPrjMenus_Up.MenuTitle);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_UpEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_UpEN SetPageDispModeId(this clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN, string strPageDispModeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPageDispModeId, 2, convQxPrjMenus_Up.PageDispModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPageDispModeId, 2, convQxPrjMenus_Up.PageDispModeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_UpEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_UpEN SetPageDispModeName(this clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN, string strPageDispModeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPageDispModeName, 50, convQxPrjMenus_Up.PageDispModeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_UpEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_UpEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_UpEN SetUpdDate(this clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQxPrjMenus_Up.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_UpEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_UpEN SetUpdUserId(this clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convQxPrjMenus_Up.UpdUserId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_UpEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_UpEN SetMemo(this clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxPrjMenus_Up.Memo);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_UpEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_UpEN SetMenuControlName(this clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN, string strMenuControlName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuControlName, 100, convQxPrjMenus_Up.MenuControlName);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvQxPrjMenus_UpENS">源对象</param>
 /// <param name = "objvQxPrjMenus_UpENT">目标对象</param>
 public static void CopyTo(this clsvQxPrjMenus_UpEN objvQxPrjMenus_UpENS, clsvQxPrjMenus_UpEN objvQxPrjMenus_UpENT)
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
 /// <param name = "objvQxPrjMenus_UpENS">源对象</param>
 /// <returns>目标对象=>clsvQxPrjMenus_UpEN:objvQxPrjMenus_UpENT</returns>
 public static clsvQxPrjMenus_UpEN CopyTo(this clsvQxPrjMenus_UpEN objvQxPrjMenus_UpENS)
{
try
{
 clsvQxPrjMenus_UpEN objvQxPrjMenus_UpENT = new clsvQxPrjMenus_UpEN()
{
MenuIdUp = objvQxPrjMenus_UpENS.MenuIdUp, //MenuId_Up
MenuName = objvQxPrjMenus_UpENS.MenuName, //菜单名
QxPrjId = objvQxPrjMenus_UpENS.QxPrjId, //项目Id
PrjName = objvQxPrjMenus_UpENS.PrjName, //工程名
UpMenuId = objvQxPrjMenus_UpENS.UpMenuId, //上级菜单Id
LinkFile = objvQxPrjMenus_UpENS.LinkFile, //链接文件
qsParameters = objvQxPrjMenus_UpENS.qsParameters, //qs参数
ImgFile = objvQxPrjMenus_UpENS.ImgFile, //图像文件
OrderNum = objvQxPrjMenus_UpENS.OrderNum, //排序号
IsLeafNode = objvQxPrjMenus_UpENS.IsLeafNode, //是否叶子
MenuSetId = objvQxPrjMenus_UpENS.MenuSetId, //菜单集Id
MenuSetName = objvQxPrjMenus_UpENS.MenuSetName, //菜单集名称
MenuTitle = objvQxPrjMenus_UpENS.MenuTitle, //菜单标题
PageDispModeId = objvQxPrjMenus_UpENS.PageDispModeId, //页面显示模式Id
PageDispModeName = objvQxPrjMenus_UpENS.PageDispModeName, //页面显示模式名称
InUse = objvQxPrjMenus_UpENS.InUse, //是否在用
UpdDate = objvQxPrjMenus_UpENS.UpdDate, //修改日期
UpdUserId = objvQxPrjMenus_UpENS.UpdUserId, //修改用户Id
Memo = objvQxPrjMenus_UpENS.Memo, //备注
MenuControlName = objvQxPrjMenus_UpENS.MenuControlName, //MenuControlName
};
 return objvQxPrjMenus_UpENT;
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
public static void CheckProperty4Condition(this clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN)
{
 clsvQxPrjMenus_UpBL.vQxPrjMenus_UpDA.CheckProperty4Condition(objvQxPrjMenus_UpEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vQxPrjMenus_Up
{
public virtual bool UpdRelaTabDate(string strMenuIdUp, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v顶层菜单(vQxPrjMenus_Up)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvQxPrjMenus_UpBL
{
public static RelatedActions_vQxPrjMenus_Up relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "vQxPrjMenus_UpListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "vQxPrjMenus_UpList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsvQxPrjMenus_UpEN> arrvQxPrjMenus_UpObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvQxPrjMenus_UpDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvQxPrjMenus_UpDA vQxPrjMenus_UpDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvQxPrjMenus_UpDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvQxPrjMenus_UpBL()
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
if (string.IsNullOrEmpty(clsvQxPrjMenus_UpEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxPrjMenus_UpEN._ConnectString);
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
objDS = vQxPrjMenus_UpDA.GetDataSet(strWhereCond);
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
objDS = vQxPrjMenus_UpDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = vQxPrjMenus_UpDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_vQxPrjMenus_Up(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQxPrjMenus_UpDA.GetDataTable_vQxPrjMenus_Up(strWhereCond);
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
objDT = vQxPrjMenus_UpDA.GetDataTable(strWhereCond);
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
objDT = vQxPrjMenus_UpDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vQxPrjMenus_UpDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vQxPrjMenus_UpDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vQxPrjMenus_UpDA.GetDataTable_Top(objTopPara);
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
objDT = vQxPrjMenus_UpDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vQxPrjMenus_UpDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = vQxPrjMenus_UpDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vQxPrjMenus_UpDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = vQxPrjMenus_UpDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = vQxPrjMenus_UpDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = vQxPrjMenus_UpDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = vQxPrjMenus_UpDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
 /// <param name = "arrMenuIdUpLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvQxPrjMenus_UpEN> GetObjLstByMenuIdUpLst(List<string> arrMenuIdUpLst)
{
List<clsvQxPrjMenus_UpEN> arrObjLst = new List<clsvQxPrjMenus_UpEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMenuIdUpLst, true);
 string strWhereCond = string.Format("MenuIdUp in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN = new clsvQxPrjMenus_UpEN();
try
{
objvQxPrjMenus_UpEN.MenuIdUp = objRow[convQxPrjMenus_Up.MenuIdUp].ToString().Trim(); //MenuId_Up
objvQxPrjMenus_UpEN.MenuName = objRow[convQxPrjMenus_Up.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenus_UpEN.QxPrjId = objRow[convQxPrjMenus_Up.QxPrjId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenus_UpEN.PrjName = objRow[convQxPrjMenus_Up.PrjName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PrjName].ToString().Trim(); //工程名
objvQxPrjMenus_UpEN.UpMenuId = objRow[convQxPrjMenus_Up.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenus_UpEN.LinkFile = objRow[convQxPrjMenus_Up.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenus_UpEN.qsParameters = objRow[convQxPrjMenus_Up.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenus_UpEN.ImgFile = objRow[convQxPrjMenus_Up.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenus_UpEN.OrderNum = objRow[convQxPrjMenus_Up.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus_Up.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenus_UpEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Up.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenus_UpEN.MenuSetId = objRow[convQxPrjMenus_Up.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenus_UpEN.MenuSetName = objRow[convQxPrjMenus_Up.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenus_UpEN.MenuTitle = objRow[convQxPrjMenus_Up.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenus_UpEN.PageDispModeId = objRow[convQxPrjMenus_Up.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenus_UpEN.PageDispModeName = objRow[convQxPrjMenus_Up.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenus_UpEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Up.InUse].ToString().Trim()); //是否在用
objvQxPrjMenus_UpEN.UpdDate = objRow[convQxPrjMenus_Up.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenus_UpEN.UpdUserId = objRow[convQxPrjMenus_Up.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenus_UpEN.Memo = objRow[convQxPrjMenus_Up.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.Memo].ToString().Trim(); //备注
objvQxPrjMenus_UpEN.MenuControlName = objRow[convQxPrjMenus_Up.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuControlName].ToString().Trim(); //MenuControlName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenus_UpEN.MenuIdUp, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenus_UpEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMenuIdUpLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvQxPrjMenus_UpEN> GetObjLstByMenuIdUpLstCache(List<string> arrMenuIdUpLst)
{
string strKey = string.Format("{0}", clsvQxPrjMenus_UpEN._CurrTabName);
List<clsvQxPrjMenus_UpEN> arrvQxPrjMenus_UpObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjMenus_UpEN> arrvQxPrjMenus_UpObjLst_Sel =
arrvQxPrjMenus_UpObjLstCache
.Where(x => arrMenuIdUpLst.Contains(x.MenuIdUp));
return arrvQxPrjMenus_UpObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjMenus_UpEN> GetObjLst(string strWhereCond)
{
List<clsvQxPrjMenus_UpEN> arrObjLst = new List<clsvQxPrjMenus_UpEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN = new clsvQxPrjMenus_UpEN();
try
{
objvQxPrjMenus_UpEN.MenuIdUp = objRow[convQxPrjMenus_Up.MenuIdUp].ToString().Trim(); //MenuId_Up
objvQxPrjMenus_UpEN.MenuName = objRow[convQxPrjMenus_Up.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenus_UpEN.QxPrjId = objRow[convQxPrjMenus_Up.QxPrjId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenus_UpEN.PrjName = objRow[convQxPrjMenus_Up.PrjName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PrjName].ToString().Trim(); //工程名
objvQxPrjMenus_UpEN.UpMenuId = objRow[convQxPrjMenus_Up.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenus_UpEN.LinkFile = objRow[convQxPrjMenus_Up.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenus_UpEN.qsParameters = objRow[convQxPrjMenus_Up.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenus_UpEN.ImgFile = objRow[convQxPrjMenus_Up.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenus_UpEN.OrderNum = objRow[convQxPrjMenus_Up.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus_Up.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenus_UpEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Up.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenus_UpEN.MenuSetId = objRow[convQxPrjMenus_Up.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenus_UpEN.MenuSetName = objRow[convQxPrjMenus_Up.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenus_UpEN.MenuTitle = objRow[convQxPrjMenus_Up.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenus_UpEN.PageDispModeId = objRow[convQxPrjMenus_Up.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenus_UpEN.PageDispModeName = objRow[convQxPrjMenus_Up.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenus_UpEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Up.InUse].ToString().Trim()); //是否在用
objvQxPrjMenus_UpEN.UpdDate = objRow[convQxPrjMenus_Up.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenus_UpEN.UpdUserId = objRow[convQxPrjMenus_Up.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenus_UpEN.Memo = objRow[convQxPrjMenus_Up.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.Memo].ToString().Trim(); //备注
objvQxPrjMenus_UpEN.MenuControlName = objRow[convQxPrjMenus_Up.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuControlName].ToString().Trim(); //MenuControlName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenus_UpEN.MenuIdUp, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenus_UpEN);
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
public static List<clsvQxPrjMenus_UpEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQxPrjMenus_UpEN> arrObjLst = new List<clsvQxPrjMenus_UpEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN = new clsvQxPrjMenus_UpEN();
try
{
objvQxPrjMenus_UpEN.MenuIdUp = objRow[convQxPrjMenus_Up.MenuIdUp].ToString().Trim(); //MenuId_Up
objvQxPrjMenus_UpEN.MenuName = objRow[convQxPrjMenus_Up.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenus_UpEN.QxPrjId = objRow[convQxPrjMenus_Up.QxPrjId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenus_UpEN.PrjName = objRow[convQxPrjMenus_Up.PrjName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PrjName].ToString().Trim(); //工程名
objvQxPrjMenus_UpEN.UpMenuId = objRow[convQxPrjMenus_Up.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenus_UpEN.LinkFile = objRow[convQxPrjMenus_Up.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenus_UpEN.qsParameters = objRow[convQxPrjMenus_Up.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenus_UpEN.ImgFile = objRow[convQxPrjMenus_Up.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenus_UpEN.OrderNum = objRow[convQxPrjMenus_Up.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus_Up.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenus_UpEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Up.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenus_UpEN.MenuSetId = objRow[convQxPrjMenus_Up.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenus_UpEN.MenuSetName = objRow[convQxPrjMenus_Up.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenus_UpEN.MenuTitle = objRow[convQxPrjMenus_Up.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenus_UpEN.PageDispModeId = objRow[convQxPrjMenus_Up.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenus_UpEN.PageDispModeName = objRow[convQxPrjMenus_Up.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenus_UpEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Up.InUse].ToString().Trim()); //是否在用
objvQxPrjMenus_UpEN.UpdDate = objRow[convQxPrjMenus_Up.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenus_UpEN.UpdUserId = objRow[convQxPrjMenus_Up.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenus_UpEN.Memo = objRow[convQxPrjMenus_Up.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.Memo].ToString().Trim(); //备注
objvQxPrjMenus_UpEN.MenuControlName = objRow[convQxPrjMenus_Up.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuControlName].ToString().Trim(); //MenuControlName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenus_UpEN.MenuIdUp, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenus_UpEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvQxPrjMenus_UpCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvQxPrjMenus_UpEN> GetSubObjLstCache(clsvQxPrjMenus_UpEN objvQxPrjMenus_UpCond)
{
List<clsvQxPrjMenus_UpEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjMenus_UpEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxPrjMenus_Up.AttributeName)
{
if (objvQxPrjMenus_UpCond.IsUpdated(strFldName) == false) continue;
if (objvQxPrjMenus_UpCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjMenus_UpCond[strFldName].ToString());
}
else
{
if (objvQxPrjMenus_UpCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxPrjMenus_UpCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjMenus_UpCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxPrjMenus_UpCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxPrjMenus_UpCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxPrjMenus_UpCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxPrjMenus_UpCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxPrjMenus_UpCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxPrjMenus_UpCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxPrjMenus_UpCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxPrjMenus_UpCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxPrjMenus_UpCond[strFldName]));
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
public static List<clsvQxPrjMenus_UpEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvQxPrjMenus_UpEN> arrObjLst = new List<clsvQxPrjMenus_UpEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN = new clsvQxPrjMenus_UpEN();
try
{
objvQxPrjMenus_UpEN.MenuIdUp = objRow[convQxPrjMenus_Up.MenuIdUp].ToString().Trim(); //MenuId_Up
objvQxPrjMenus_UpEN.MenuName = objRow[convQxPrjMenus_Up.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenus_UpEN.QxPrjId = objRow[convQxPrjMenus_Up.QxPrjId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenus_UpEN.PrjName = objRow[convQxPrjMenus_Up.PrjName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PrjName].ToString().Trim(); //工程名
objvQxPrjMenus_UpEN.UpMenuId = objRow[convQxPrjMenus_Up.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenus_UpEN.LinkFile = objRow[convQxPrjMenus_Up.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenus_UpEN.qsParameters = objRow[convQxPrjMenus_Up.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenus_UpEN.ImgFile = objRow[convQxPrjMenus_Up.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenus_UpEN.OrderNum = objRow[convQxPrjMenus_Up.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus_Up.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenus_UpEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Up.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenus_UpEN.MenuSetId = objRow[convQxPrjMenus_Up.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenus_UpEN.MenuSetName = objRow[convQxPrjMenus_Up.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenus_UpEN.MenuTitle = objRow[convQxPrjMenus_Up.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenus_UpEN.PageDispModeId = objRow[convQxPrjMenus_Up.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenus_UpEN.PageDispModeName = objRow[convQxPrjMenus_Up.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenus_UpEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Up.InUse].ToString().Trim()); //是否在用
objvQxPrjMenus_UpEN.UpdDate = objRow[convQxPrjMenus_Up.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenus_UpEN.UpdUserId = objRow[convQxPrjMenus_Up.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenus_UpEN.Memo = objRow[convQxPrjMenus_Up.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.Memo].ToString().Trim(); //备注
objvQxPrjMenus_UpEN.MenuControlName = objRow[convQxPrjMenus_Up.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuControlName].ToString().Trim(); //MenuControlName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenus_UpEN.MenuIdUp, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenus_UpEN);
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
public static List<clsvQxPrjMenus_UpEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvQxPrjMenus_UpEN> arrObjLst = new List<clsvQxPrjMenus_UpEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN = new clsvQxPrjMenus_UpEN();
try
{
objvQxPrjMenus_UpEN.MenuIdUp = objRow[convQxPrjMenus_Up.MenuIdUp].ToString().Trim(); //MenuId_Up
objvQxPrjMenus_UpEN.MenuName = objRow[convQxPrjMenus_Up.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenus_UpEN.QxPrjId = objRow[convQxPrjMenus_Up.QxPrjId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenus_UpEN.PrjName = objRow[convQxPrjMenus_Up.PrjName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PrjName].ToString().Trim(); //工程名
objvQxPrjMenus_UpEN.UpMenuId = objRow[convQxPrjMenus_Up.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenus_UpEN.LinkFile = objRow[convQxPrjMenus_Up.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenus_UpEN.qsParameters = objRow[convQxPrjMenus_Up.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenus_UpEN.ImgFile = objRow[convQxPrjMenus_Up.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenus_UpEN.OrderNum = objRow[convQxPrjMenus_Up.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus_Up.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenus_UpEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Up.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenus_UpEN.MenuSetId = objRow[convQxPrjMenus_Up.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenus_UpEN.MenuSetName = objRow[convQxPrjMenus_Up.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenus_UpEN.MenuTitle = objRow[convQxPrjMenus_Up.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenus_UpEN.PageDispModeId = objRow[convQxPrjMenus_Up.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenus_UpEN.PageDispModeName = objRow[convQxPrjMenus_Up.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenus_UpEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Up.InUse].ToString().Trim()); //是否在用
objvQxPrjMenus_UpEN.UpdDate = objRow[convQxPrjMenus_Up.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenus_UpEN.UpdUserId = objRow[convQxPrjMenus_Up.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenus_UpEN.Memo = objRow[convQxPrjMenus_Up.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.Memo].ToString().Trim(); //备注
objvQxPrjMenus_UpEN.MenuControlName = objRow[convQxPrjMenus_Up.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuControlName].ToString().Trim(); //MenuControlName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenus_UpEN.MenuIdUp, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenus_UpEN);
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
List<clsvQxPrjMenus_UpEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvQxPrjMenus_UpEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjMenus_UpEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvQxPrjMenus_UpEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvQxPrjMenus_UpEN> arrObjLst = new List<clsvQxPrjMenus_UpEN>(); 
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
	clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN = new clsvQxPrjMenus_UpEN();
try
{
objvQxPrjMenus_UpEN.MenuIdUp = objRow[convQxPrjMenus_Up.MenuIdUp].ToString().Trim(); //MenuId_Up
objvQxPrjMenus_UpEN.MenuName = objRow[convQxPrjMenus_Up.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenus_UpEN.QxPrjId = objRow[convQxPrjMenus_Up.QxPrjId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenus_UpEN.PrjName = objRow[convQxPrjMenus_Up.PrjName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PrjName].ToString().Trim(); //工程名
objvQxPrjMenus_UpEN.UpMenuId = objRow[convQxPrjMenus_Up.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenus_UpEN.LinkFile = objRow[convQxPrjMenus_Up.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenus_UpEN.qsParameters = objRow[convQxPrjMenus_Up.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenus_UpEN.ImgFile = objRow[convQxPrjMenus_Up.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenus_UpEN.OrderNum = objRow[convQxPrjMenus_Up.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus_Up.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenus_UpEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Up.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenus_UpEN.MenuSetId = objRow[convQxPrjMenus_Up.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenus_UpEN.MenuSetName = objRow[convQxPrjMenus_Up.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenus_UpEN.MenuTitle = objRow[convQxPrjMenus_Up.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenus_UpEN.PageDispModeId = objRow[convQxPrjMenus_Up.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenus_UpEN.PageDispModeName = objRow[convQxPrjMenus_Up.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenus_UpEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Up.InUse].ToString().Trim()); //是否在用
objvQxPrjMenus_UpEN.UpdDate = objRow[convQxPrjMenus_Up.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenus_UpEN.UpdUserId = objRow[convQxPrjMenus_Up.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenus_UpEN.Memo = objRow[convQxPrjMenus_Up.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.Memo].ToString().Trim(); //备注
objvQxPrjMenus_UpEN.MenuControlName = objRow[convQxPrjMenus_Up.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuControlName].ToString().Trim(); //MenuControlName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenus_UpEN.MenuIdUp, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenus_UpEN);
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
public static List<clsvQxPrjMenus_UpEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvQxPrjMenus_UpEN> arrObjLst = new List<clsvQxPrjMenus_UpEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN = new clsvQxPrjMenus_UpEN();
try
{
objvQxPrjMenus_UpEN.MenuIdUp = objRow[convQxPrjMenus_Up.MenuIdUp].ToString().Trim(); //MenuId_Up
objvQxPrjMenus_UpEN.MenuName = objRow[convQxPrjMenus_Up.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenus_UpEN.QxPrjId = objRow[convQxPrjMenus_Up.QxPrjId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenus_UpEN.PrjName = objRow[convQxPrjMenus_Up.PrjName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PrjName].ToString().Trim(); //工程名
objvQxPrjMenus_UpEN.UpMenuId = objRow[convQxPrjMenus_Up.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenus_UpEN.LinkFile = objRow[convQxPrjMenus_Up.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenus_UpEN.qsParameters = objRow[convQxPrjMenus_Up.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenus_UpEN.ImgFile = objRow[convQxPrjMenus_Up.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenus_UpEN.OrderNum = objRow[convQxPrjMenus_Up.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus_Up.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenus_UpEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Up.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenus_UpEN.MenuSetId = objRow[convQxPrjMenus_Up.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenus_UpEN.MenuSetName = objRow[convQxPrjMenus_Up.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenus_UpEN.MenuTitle = objRow[convQxPrjMenus_Up.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenus_UpEN.PageDispModeId = objRow[convQxPrjMenus_Up.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenus_UpEN.PageDispModeName = objRow[convQxPrjMenus_Up.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenus_UpEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Up.InUse].ToString().Trim()); //是否在用
objvQxPrjMenus_UpEN.UpdDate = objRow[convQxPrjMenus_Up.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenus_UpEN.UpdUserId = objRow[convQxPrjMenus_Up.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenus_UpEN.Memo = objRow[convQxPrjMenus_Up.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.Memo].ToString().Trim(); //备注
objvQxPrjMenus_UpEN.MenuControlName = objRow[convQxPrjMenus_Up.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuControlName].ToString().Trim(); //MenuControlName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenus_UpEN.MenuIdUp, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenus_UpEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQxPrjMenus_UpEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvQxPrjMenus_UpEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvQxPrjMenus_UpEN> arrObjLst = new List<clsvQxPrjMenus_UpEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN = new clsvQxPrjMenus_UpEN();
try
{
objvQxPrjMenus_UpEN.MenuIdUp = objRow[convQxPrjMenus_Up.MenuIdUp].ToString().Trim(); //MenuId_Up
objvQxPrjMenus_UpEN.MenuName = objRow[convQxPrjMenus_Up.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenus_UpEN.QxPrjId = objRow[convQxPrjMenus_Up.QxPrjId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenus_UpEN.PrjName = objRow[convQxPrjMenus_Up.PrjName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PrjName].ToString().Trim(); //工程名
objvQxPrjMenus_UpEN.UpMenuId = objRow[convQxPrjMenus_Up.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenus_UpEN.LinkFile = objRow[convQxPrjMenus_Up.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenus_UpEN.qsParameters = objRow[convQxPrjMenus_Up.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenus_UpEN.ImgFile = objRow[convQxPrjMenus_Up.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenus_UpEN.OrderNum = objRow[convQxPrjMenus_Up.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus_Up.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenus_UpEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Up.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenus_UpEN.MenuSetId = objRow[convQxPrjMenus_Up.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenus_UpEN.MenuSetName = objRow[convQxPrjMenus_Up.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenus_UpEN.MenuTitle = objRow[convQxPrjMenus_Up.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenus_UpEN.PageDispModeId = objRow[convQxPrjMenus_Up.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenus_UpEN.PageDispModeName = objRow[convQxPrjMenus_Up.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenus_UpEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Up.InUse].ToString().Trim()); //是否在用
objvQxPrjMenus_UpEN.UpdDate = objRow[convQxPrjMenus_Up.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenus_UpEN.UpdUserId = objRow[convQxPrjMenus_Up.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenus_UpEN.Memo = objRow[convQxPrjMenus_Up.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.Memo].ToString().Trim(); //备注
objvQxPrjMenus_UpEN.MenuControlName = objRow[convQxPrjMenus_Up.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuControlName].ToString().Trim(); //MenuControlName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenus_UpEN.MenuIdUp, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenus_UpEN);
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
public static List<clsvQxPrjMenus_UpEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvQxPrjMenus_UpEN> arrObjLst = new List<clsvQxPrjMenus_UpEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN = new clsvQxPrjMenus_UpEN();
try
{
objvQxPrjMenus_UpEN.MenuIdUp = objRow[convQxPrjMenus_Up.MenuIdUp].ToString().Trim(); //MenuId_Up
objvQxPrjMenus_UpEN.MenuName = objRow[convQxPrjMenus_Up.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenus_UpEN.QxPrjId = objRow[convQxPrjMenus_Up.QxPrjId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenus_UpEN.PrjName = objRow[convQxPrjMenus_Up.PrjName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PrjName].ToString().Trim(); //工程名
objvQxPrjMenus_UpEN.UpMenuId = objRow[convQxPrjMenus_Up.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenus_UpEN.LinkFile = objRow[convQxPrjMenus_Up.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenus_UpEN.qsParameters = objRow[convQxPrjMenus_Up.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenus_UpEN.ImgFile = objRow[convQxPrjMenus_Up.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenus_UpEN.OrderNum = objRow[convQxPrjMenus_Up.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus_Up.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenus_UpEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Up.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenus_UpEN.MenuSetId = objRow[convQxPrjMenus_Up.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenus_UpEN.MenuSetName = objRow[convQxPrjMenus_Up.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenus_UpEN.MenuTitle = objRow[convQxPrjMenus_Up.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenus_UpEN.PageDispModeId = objRow[convQxPrjMenus_Up.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenus_UpEN.PageDispModeName = objRow[convQxPrjMenus_Up.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenus_UpEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Up.InUse].ToString().Trim()); //是否在用
objvQxPrjMenus_UpEN.UpdDate = objRow[convQxPrjMenus_Up.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenus_UpEN.UpdUserId = objRow[convQxPrjMenus_Up.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenus_UpEN.Memo = objRow[convQxPrjMenus_Up.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.Memo].ToString().Trim(); //备注
objvQxPrjMenus_UpEN.MenuControlName = objRow[convQxPrjMenus_Up.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuControlName].ToString().Trim(); //MenuControlName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenus_UpEN.MenuIdUp, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenus_UpEN);
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
public static IEnumerable<clsvQxPrjMenus_UpEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsvQxPrjMenus_UpEN objvQxPrjMenus_UpCond, string strOrderBy)
{
List<clsvQxPrjMenus_UpEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjMenus_UpEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxPrjMenus_Up.AttributeName)
{
if (objvQxPrjMenus_UpCond.IsUpdated(strFldName) == false) continue;
if (objvQxPrjMenus_UpCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjMenus_UpCond[strFldName].ToString());
}
else
{
if (objvQxPrjMenus_UpCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxPrjMenus_UpCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjMenus_UpCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxPrjMenus_UpCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxPrjMenus_UpCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxPrjMenus_UpCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxPrjMenus_UpCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxPrjMenus_UpCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxPrjMenus_UpCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxPrjMenus_UpCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxPrjMenus_UpCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxPrjMenus_UpCond[strFldName]));
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
public static IEnumerable<clsvQxPrjMenus_UpEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsvQxPrjMenus_UpEN objvQxPrjMenus_UpCond = JsonConvert.DeserializeObject<clsvQxPrjMenus_UpEN>(objPagerPara.whereCond);
if (objvQxPrjMenus_UpCond.sfFldComparisonOp == null)
{
objvQxPrjMenus_UpCond.dicFldComparisonOp = null;
}
else
{
objvQxPrjMenus_UpCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objvQxPrjMenus_UpCond.sfFldComparisonOp);
}
clsvQxPrjMenus_UpBL.SetUpdFlag(objvQxPrjMenus_UpCond);
 try
{
CheckProperty4Condition(objvQxPrjMenus_UpCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsvQxPrjMenus_UpBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objvQxPrjMenus_UpCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjMenus_UpEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsvQxPrjMenus_UpEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxPrjMenus_UpEN> arrObjLst = new List<clsvQxPrjMenus_UpEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN = new clsvQxPrjMenus_UpEN();
try
{
objvQxPrjMenus_UpEN.MenuIdUp = objRow[convQxPrjMenus_Up.MenuIdUp].ToString().Trim(); //MenuId_Up
objvQxPrjMenus_UpEN.MenuName = objRow[convQxPrjMenus_Up.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenus_UpEN.QxPrjId = objRow[convQxPrjMenus_Up.QxPrjId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenus_UpEN.PrjName = objRow[convQxPrjMenus_Up.PrjName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PrjName].ToString().Trim(); //工程名
objvQxPrjMenus_UpEN.UpMenuId = objRow[convQxPrjMenus_Up.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenus_UpEN.LinkFile = objRow[convQxPrjMenus_Up.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenus_UpEN.qsParameters = objRow[convQxPrjMenus_Up.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenus_UpEN.ImgFile = objRow[convQxPrjMenus_Up.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenus_UpEN.OrderNum = objRow[convQxPrjMenus_Up.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus_Up.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenus_UpEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Up.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenus_UpEN.MenuSetId = objRow[convQxPrjMenus_Up.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenus_UpEN.MenuSetName = objRow[convQxPrjMenus_Up.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenus_UpEN.MenuTitle = objRow[convQxPrjMenus_Up.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenus_UpEN.PageDispModeId = objRow[convQxPrjMenus_Up.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenus_UpEN.PageDispModeName = objRow[convQxPrjMenus_Up.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenus_UpEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Up.InUse].ToString().Trim()); //是否在用
objvQxPrjMenus_UpEN.UpdDate = objRow[convQxPrjMenus_Up.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenus_UpEN.UpdUserId = objRow[convQxPrjMenus_Up.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenus_UpEN.Memo = objRow[convQxPrjMenus_Up.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.Memo].ToString().Trim(); //备注
objvQxPrjMenus_UpEN.MenuControlName = objRow[convQxPrjMenus_Up.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuControlName].ToString().Trim(); //MenuControlName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenus_UpEN.MenuIdUp, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenus_UpEN);
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
public static List<clsvQxPrjMenus_UpEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxPrjMenus_UpEN> arrObjLst = new List<clsvQxPrjMenus_UpEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN = new clsvQxPrjMenus_UpEN();
try
{
objvQxPrjMenus_UpEN.MenuIdUp = objRow[convQxPrjMenus_Up.MenuIdUp].ToString().Trim(); //MenuId_Up
objvQxPrjMenus_UpEN.MenuName = objRow[convQxPrjMenus_Up.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenus_UpEN.QxPrjId = objRow[convQxPrjMenus_Up.QxPrjId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenus_UpEN.PrjName = objRow[convQxPrjMenus_Up.PrjName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PrjName].ToString().Trim(); //工程名
objvQxPrjMenus_UpEN.UpMenuId = objRow[convQxPrjMenus_Up.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenus_UpEN.LinkFile = objRow[convQxPrjMenus_Up.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenus_UpEN.qsParameters = objRow[convQxPrjMenus_Up.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenus_UpEN.ImgFile = objRow[convQxPrjMenus_Up.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenus_UpEN.OrderNum = objRow[convQxPrjMenus_Up.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus_Up.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenus_UpEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Up.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenus_UpEN.MenuSetId = objRow[convQxPrjMenus_Up.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenus_UpEN.MenuSetName = objRow[convQxPrjMenus_Up.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenus_UpEN.MenuTitle = objRow[convQxPrjMenus_Up.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenus_UpEN.PageDispModeId = objRow[convQxPrjMenus_Up.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenus_UpEN.PageDispModeName = objRow[convQxPrjMenus_Up.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenus_UpEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Up.InUse].ToString().Trim()); //是否在用
objvQxPrjMenus_UpEN.UpdDate = objRow[convQxPrjMenus_Up.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenus_UpEN.UpdUserId = objRow[convQxPrjMenus_Up.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenus_UpEN.Memo = objRow[convQxPrjMenus_Up.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.Memo].ToString().Trim(); //备注
objvQxPrjMenus_UpEN.MenuControlName = objRow[convQxPrjMenus_Up.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuControlName].ToString().Trim(); //MenuControlName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenus_UpEN.MenuIdUp, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenus_UpEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjMenus_UpEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvQxPrjMenus_UpEN> arrObjLst = new List<clsvQxPrjMenus_UpEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN = new clsvQxPrjMenus_UpEN();
try
{
objvQxPrjMenus_UpEN.MenuIdUp = objRow[convQxPrjMenus_Up.MenuIdUp].ToString().Trim(); //MenuId_Up
objvQxPrjMenus_UpEN.MenuName = objRow[convQxPrjMenus_Up.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenus_UpEN.QxPrjId = objRow[convQxPrjMenus_Up.QxPrjId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenus_UpEN.PrjName = objRow[convQxPrjMenus_Up.PrjName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PrjName].ToString().Trim(); //工程名
objvQxPrjMenus_UpEN.UpMenuId = objRow[convQxPrjMenus_Up.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenus_UpEN.LinkFile = objRow[convQxPrjMenus_Up.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenus_UpEN.qsParameters = objRow[convQxPrjMenus_Up.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenus_UpEN.ImgFile = objRow[convQxPrjMenus_Up.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenus_UpEN.OrderNum = objRow[convQxPrjMenus_Up.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus_Up.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenus_UpEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Up.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenus_UpEN.MenuSetId = objRow[convQxPrjMenus_Up.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenus_UpEN.MenuSetName = objRow[convQxPrjMenus_Up.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenus_UpEN.MenuTitle = objRow[convQxPrjMenus_Up.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenus_UpEN.PageDispModeId = objRow[convQxPrjMenus_Up.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenus_UpEN.PageDispModeName = objRow[convQxPrjMenus_Up.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenus_UpEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Up.InUse].ToString().Trim()); //是否在用
objvQxPrjMenus_UpEN.UpdDate = objRow[convQxPrjMenus_Up.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenus_UpEN.UpdUserId = objRow[convQxPrjMenus_Up.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenus_UpEN.Memo = objRow[convQxPrjMenus_Up.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.Memo].ToString().Trim(); //备注
objvQxPrjMenus_UpEN.MenuControlName = objRow[convQxPrjMenus_Up.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus_Up.MenuControlName].ToString().Trim(); //MenuControlName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenus_UpEN.MenuIdUp, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenus_UpEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvQxPrjMenus_UpEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxPrjMenus_Up(ref clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN)
{
bool bolResult = vQxPrjMenus_UpDA.GetvQxPrjMenus_Up(ref objvQxPrjMenus_UpEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strMenuIdUp">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxPrjMenus_UpEN GetObjByMenuIdUp(string strMenuIdUp)
{
if (strMenuIdUp.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strMenuIdUp]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strMenuIdUp) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strMenuIdUp]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN = vQxPrjMenus_UpDA.GetObjByMenuIdUp(strMenuIdUp);
return objvQxPrjMenus_UpEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvQxPrjMenus_UpEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN = vQxPrjMenus_UpDA.GetFirstObj(strWhereCond);
 return objvQxPrjMenus_UpEN;
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
public static clsvQxPrjMenus_UpEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN = vQxPrjMenus_UpDA.GetObjByDataRow(objRow);
 return objvQxPrjMenus_UpEN;
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
public static clsvQxPrjMenus_UpEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN = vQxPrjMenus_UpDA.GetObjByDataRow(objRow);
 return objvQxPrjMenus_UpEN;
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
 /// <param name = "strMenuIdUp">所给的关键字</param>
 /// <param name = "lstvQxPrjMenus_UpObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxPrjMenus_UpEN GetObjByMenuIdUpFromList(string strMenuIdUp, List<clsvQxPrjMenus_UpEN> lstvQxPrjMenus_UpObjLst)
{
foreach (clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN in lstvQxPrjMenus_UpObjLst)
{
if (objvQxPrjMenus_UpEN.MenuIdUp == strMenuIdUp)
{
return objvQxPrjMenus_UpEN;
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
 string strMenuIdUp;
 try
 {
 strMenuIdUp = new clsvQxPrjMenus_UpDA().GetFirstID(strWhereCond);
 return strMenuIdUp;
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
 arrList = vQxPrjMenus_UpDA.GetID(strWhereCond);
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
bool bolIsExist = vQxPrjMenus_UpDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strMenuIdUp">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strMenuIdUp)
{
if (string.IsNullOrEmpty(strMenuIdUp) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strMenuIdUp]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vQxPrjMenus_UpDA.IsExist(strMenuIdUp);
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
 bolIsExist = clsvQxPrjMenus_UpDA.IsExistTable();
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
 bolIsExist = vQxPrjMenus_UpDA.IsExistTable(strTabName);
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
 /// <param name = "objvQxPrjMenus_UpEN">源简化对象</param>
 public static void SetUpdFlag(clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN)
{
try
{
objvQxPrjMenus_UpEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvQxPrjMenus_UpEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convQxPrjMenus_Up.MenuIdUp, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_UpEN.MenuIdUp = objvQxPrjMenus_UpEN.MenuIdUp; //MenuId_Up
}
if (arrFldSet.Contains(convQxPrjMenus_Up.MenuName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_UpEN.MenuName = objvQxPrjMenus_UpEN.MenuName; //菜单名
}
if (arrFldSet.Contains(convQxPrjMenus_Up.QxPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_UpEN.QxPrjId = objvQxPrjMenus_UpEN.QxPrjId == "[null]" ? null :  objvQxPrjMenus_UpEN.QxPrjId; //项目Id
}
if (arrFldSet.Contains(convQxPrjMenus_Up.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_UpEN.PrjName = objvQxPrjMenus_UpEN.PrjName == "[null]" ? null :  objvQxPrjMenus_UpEN.PrjName; //工程名
}
if (arrFldSet.Contains(convQxPrjMenus_Up.UpMenuId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_UpEN.UpMenuId = objvQxPrjMenus_UpEN.UpMenuId == "[null]" ? null :  objvQxPrjMenus_UpEN.UpMenuId; //上级菜单Id
}
if (arrFldSet.Contains(convQxPrjMenus_Up.LinkFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_UpEN.LinkFile = objvQxPrjMenus_UpEN.LinkFile == "[null]" ? null :  objvQxPrjMenus_UpEN.LinkFile; //链接文件
}
if (arrFldSet.Contains(convQxPrjMenus_Up.qsParameters, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_UpEN.qsParameters = objvQxPrjMenus_UpEN.qsParameters == "[null]" ? null :  objvQxPrjMenus_UpEN.qsParameters; //qs参数
}
if (arrFldSet.Contains(convQxPrjMenus_Up.ImgFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_UpEN.ImgFile = objvQxPrjMenus_UpEN.ImgFile == "[null]" ? null :  objvQxPrjMenus_UpEN.ImgFile; //图像文件
}
if (arrFldSet.Contains(convQxPrjMenus_Up.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_UpEN.OrderNum = objvQxPrjMenus_UpEN.OrderNum; //排序号
}
if (arrFldSet.Contains(convQxPrjMenus_Up.IsLeafNode, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_UpEN.IsLeafNode = objvQxPrjMenus_UpEN.IsLeafNode; //是否叶子
}
if (arrFldSet.Contains(convQxPrjMenus_Up.MenuSetId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_UpEN.MenuSetId = objvQxPrjMenus_UpEN.MenuSetId; //菜单集Id
}
if (arrFldSet.Contains(convQxPrjMenus_Up.MenuSetName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_UpEN.MenuSetName = objvQxPrjMenus_UpEN.MenuSetName == "[null]" ? null :  objvQxPrjMenus_UpEN.MenuSetName; //菜单集名称
}
if (arrFldSet.Contains(convQxPrjMenus_Up.MenuTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_UpEN.MenuTitle = objvQxPrjMenus_UpEN.MenuTitle == "[null]" ? null :  objvQxPrjMenus_UpEN.MenuTitle; //菜单标题
}
if (arrFldSet.Contains(convQxPrjMenus_Up.PageDispModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_UpEN.PageDispModeId = objvQxPrjMenus_UpEN.PageDispModeId == "[null]" ? null :  objvQxPrjMenus_UpEN.PageDispModeId; //页面显示模式Id
}
if (arrFldSet.Contains(convQxPrjMenus_Up.PageDispModeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_UpEN.PageDispModeName = objvQxPrjMenus_UpEN.PageDispModeName == "[null]" ? null :  objvQxPrjMenus_UpEN.PageDispModeName; //页面显示模式名称
}
if (arrFldSet.Contains(convQxPrjMenus_Up.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_UpEN.InUse = objvQxPrjMenus_UpEN.InUse; //是否在用
}
if (arrFldSet.Contains(convQxPrjMenus_Up.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_UpEN.UpdDate = objvQxPrjMenus_UpEN.UpdDate == "[null]" ? null :  objvQxPrjMenus_UpEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convQxPrjMenus_Up.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_UpEN.UpdUserId = objvQxPrjMenus_UpEN.UpdUserId == "[null]" ? null :  objvQxPrjMenus_UpEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convQxPrjMenus_Up.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_UpEN.Memo = objvQxPrjMenus_UpEN.Memo == "[null]" ? null :  objvQxPrjMenus_UpEN.Memo; //备注
}
if (arrFldSet.Contains(convQxPrjMenus_Up.MenuControlName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_UpEN.MenuControlName = objvQxPrjMenus_UpEN.MenuControlName == "[null]" ? null :  objvQxPrjMenus_UpEN.MenuControlName; //MenuControlName
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
 /// <param name = "objvQxPrjMenus_UpEN">源简化对象</param>
 public static void AccessFldValueNull(clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN)
{
try
{
if (objvQxPrjMenus_UpEN.QxPrjId == "[null]") objvQxPrjMenus_UpEN.QxPrjId = null; //项目Id
if (objvQxPrjMenus_UpEN.PrjName == "[null]") objvQxPrjMenus_UpEN.PrjName = null; //工程名
if (objvQxPrjMenus_UpEN.UpMenuId == "[null]") objvQxPrjMenus_UpEN.UpMenuId = null; //上级菜单Id
if (objvQxPrjMenus_UpEN.LinkFile == "[null]") objvQxPrjMenus_UpEN.LinkFile = null; //链接文件
if (objvQxPrjMenus_UpEN.qsParameters == "[null]") objvQxPrjMenus_UpEN.qsParameters = null; //qs参数
if (objvQxPrjMenus_UpEN.ImgFile == "[null]") objvQxPrjMenus_UpEN.ImgFile = null; //图像文件
if (objvQxPrjMenus_UpEN.MenuSetName == "[null]") objvQxPrjMenus_UpEN.MenuSetName = null; //菜单集名称
if (objvQxPrjMenus_UpEN.MenuTitle == "[null]") objvQxPrjMenus_UpEN.MenuTitle = null; //菜单标题
if (objvQxPrjMenus_UpEN.PageDispModeId == "[null]") objvQxPrjMenus_UpEN.PageDispModeId = null; //页面显示模式Id
if (objvQxPrjMenus_UpEN.PageDispModeName == "[null]") objvQxPrjMenus_UpEN.PageDispModeName = null; //页面显示模式名称
if (objvQxPrjMenus_UpEN.UpdDate == "[null]") objvQxPrjMenus_UpEN.UpdDate = null; //修改日期
if (objvQxPrjMenus_UpEN.UpdUserId == "[null]") objvQxPrjMenus_UpEN.UpdUserId = null; //修改用户Id
if (objvQxPrjMenus_UpEN.Memo == "[null]") objvQxPrjMenus_UpEN.Memo = null; //备注
if (objvQxPrjMenus_UpEN.MenuControlName == "[null]") objvQxPrjMenus_UpEN.MenuControlName = null; //MenuControlName
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
public static void CheckProperty4Condition(clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN)
{
 vQxPrjMenus_UpDA.CheckProperty4Condition(objvQxPrjMenus_UpEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_MenuIdUp(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convQxPrjMenus_Up.MenuIdUp); 
List<clsvQxPrjMenus_UpEN> arrObjLst = clsvQxPrjMenus_UpBL.GetObjLst(strCondition);
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
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_MenuIdUp(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v顶层菜单]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convQxPrjMenus_Up.MenuIdUp); 
IEnumerable<clsvQxPrjMenus_UpEN> arrObjLst = clsvQxPrjMenus_UpBL.GetObjLst(strCondition);
objDDL.DataValueField = convQxPrjMenus_Up.MenuIdUp;
objDDL.DataTextField = convQxPrjMenus_Up.MenuName;
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
public static void BindDdl_MenuIdUpCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v顶层菜单]...","0");
List<clsvQxPrjMenus_UpEN> arrvQxPrjMenus_UpObjLst = GetAllvQxPrjMenus_UpObjLstCache(); 
objDDL.DataValueField = convQxPrjMenus_Up.MenuIdUp;
objDDL.DataTextField = convQxPrjMenus_Up.MenuName;
objDDL.DataSource = arrvQxPrjMenus_UpObjLst;
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
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by MenuIdUp");
//if (arrvQxPrjMenus_UpObjLstCache == null)
//{
//arrvQxPrjMenus_UpObjLstCache = vQxPrjMenus_UpDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strMenuIdUp">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxPrjMenus_UpEN GetObjByMenuIdUpCache(string strMenuIdUp)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvQxPrjMenus_UpEN._CurrTabName);
List<clsvQxPrjMenus_UpEN> arrvQxPrjMenus_UpObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjMenus_UpEN> arrvQxPrjMenus_UpObjLst_Sel =
arrvQxPrjMenus_UpObjLstCache
.Where(x=> x.MenuIdUp == strMenuIdUp 
);
if (arrvQxPrjMenus_UpObjLst_Sel.Count() == 0)
{
   clsvQxPrjMenus_UpEN obj = clsvQxPrjMenus_UpBL.GetObjByMenuIdUp(strMenuIdUp);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvQxPrjMenus_UpObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strMenuIdUp">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetMenuNameByMenuIdUpCache(string strMenuIdUp)
{
if (string.IsNullOrEmpty(strMenuIdUp) == true) return "";
//获取缓存中的对象列表
clsvQxPrjMenus_UpEN objvQxPrjMenus_Up = GetObjByMenuIdUpCache(strMenuIdUp);
if (objvQxPrjMenus_Up == null) return "";
return objvQxPrjMenus_Up.MenuName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strMenuIdUp">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByMenuIdUpCache(string strMenuIdUp)
{
if (string.IsNullOrEmpty(strMenuIdUp) == true) return "";
//获取缓存中的对象列表
clsvQxPrjMenus_UpEN objvQxPrjMenus_Up = GetObjByMenuIdUpCache(strMenuIdUp);
if (objvQxPrjMenus_Up == null) return "";
return objvQxPrjMenus_Up.MenuName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxPrjMenus_UpEN> GetAllvQxPrjMenus_UpObjLstCache()
{
//获取缓存中的对象列表
List<clsvQxPrjMenus_UpEN> arrvQxPrjMenus_UpObjLstCache = GetObjLstCache(); 
return arrvQxPrjMenus_UpObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxPrjMenus_UpEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvQxPrjMenus_UpEN._CurrTabName);
List<clsvQxPrjMenus_UpEN> arrvQxPrjMenus_UpObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQxPrjMenus_UpObjLstCache;
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


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstvQxPrjMenus_UpObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsvQxPrjMenus_UpEN> lstvQxPrjMenus_UpObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstvQxPrjMenus_UpObjLst, writer);
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
 /// <param name = "lstvQxPrjMenus_UpObjLst">[clsvQxPrjMenus_UpEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsvQxPrjMenus_UpEN> lstvQxPrjMenus_UpObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsvQxPrjMenus_UpBL.listXmlNode);
writer.WriteStartElement(clsvQxPrjMenus_UpBL.itemsXmlNode);
foreach (clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN in lstvQxPrjMenus_UpObjLst)
{
clsvQxPrjMenus_UpBL.SerializeXML(writer, objvQxPrjMenus_UpEN);
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
 /// <param name = "objvQxPrjMenus_UpEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN)
{
writer.WriteStartElement(clsvQxPrjMenus_UpBL.itemXmlNode);
 
if (objvQxPrjMenus_UpEN.MenuIdUp != null)
{
writer.WriteElementString(convQxPrjMenus_Up.MenuIdUp, objvQxPrjMenus_UpEN.MenuIdUp.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenus_UpEN.MenuName != null)
{
writer.WriteElementString(convQxPrjMenus_Up.MenuName, objvQxPrjMenus_UpEN.MenuName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenus_UpEN.QxPrjId != null)
{
writer.WriteElementString(convQxPrjMenus_Up.QxPrjId, objvQxPrjMenus_UpEN.QxPrjId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenus_UpEN.PrjName != null)
{
writer.WriteElementString(convQxPrjMenus_Up.PrjName, objvQxPrjMenus_UpEN.PrjName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenus_UpEN.UpMenuId != null)
{
writer.WriteElementString(convQxPrjMenus_Up.UpMenuId, objvQxPrjMenus_UpEN.UpMenuId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenus_UpEN.LinkFile != null)
{
writer.WriteElementString(convQxPrjMenus_Up.LinkFile, objvQxPrjMenus_UpEN.LinkFile.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenus_UpEN.qsParameters != null)
{
writer.WriteElementString(convQxPrjMenus_Up.qsParameters, objvQxPrjMenus_UpEN.qsParameters.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenus_UpEN.ImgFile != null)
{
writer.WriteElementString(convQxPrjMenus_Up.ImgFile, objvQxPrjMenus_UpEN.ImgFile.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convQxPrjMenus_Up.OrderNum, objvQxPrjMenus_UpEN.OrderNum.ToString());
 
writer.WriteElementString(convQxPrjMenus_Up.IsLeafNode, objvQxPrjMenus_UpEN.IsLeafNode.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objvQxPrjMenus_UpEN.MenuSetId != null)
{
writer.WriteElementString(convQxPrjMenus_Up.MenuSetId, objvQxPrjMenus_UpEN.MenuSetId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenus_UpEN.MenuSetName != null)
{
writer.WriteElementString(convQxPrjMenus_Up.MenuSetName, objvQxPrjMenus_UpEN.MenuSetName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenus_UpEN.MenuTitle != null)
{
writer.WriteElementString(convQxPrjMenus_Up.MenuTitle, objvQxPrjMenus_UpEN.MenuTitle.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenus_UpEN.PageDispModeId != null)
{
writer.WriteElementString(convQxPrjMenus_Up.PageDispModeId, objvQxPrjMenus_UpEN.PageDispModeId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenus_UpEN.PageDispModeName != null)
{
writer.WriteElementString(convQxPrjMenus_Up.PageDispModeName, objvQxPrjMenus_UpEN.PageDispModeName.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convQxPrjMenus_Up.InUse, objvQxPrjMenus_UpEN.InUse.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objvQxPrjMenus_UpEN.UpdDate != null)
{
writer.WriteElementString(convQxPrjMenus_Up.UpdDate, objvQxPrjMenus_UpEN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenus_UpEN.UpdUserId != null)
{
writer.WriteElementString(convQxPrjMenus_Up.UpdUserId, objvQxPrjMenus_UpEN.UpdUserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenus_UpEN.Memo != null)
{
writer.WriteElementString(convQxPrjMenus_Up.Memo, objvQxPrjMenus_UpEN.Memo.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenus_UpEN.MenuControlName != null)
{
writer.WriteElementString(convQxPrjMenus_Up.MenuControlName, objvQxPrjMenus_UpEN.MenuControlName.ToString(CultureInfo.InvariantCulture));
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
public static clsvQxPrjMenus_UpEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN = new clsvQxPrjMenus_UpEN();
reader.Read();
while (!(reader.Name == clsvQxPrjMenus_UpBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(convQxPrjMenus_Up.MenuIdUp))
{
objvQxPrjMenus_UpEN.MenuIdUp = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus_Up.MenuName))
{
objvQxPrjMenus_UpEN.MenuName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus_Up.QxPrjId))
{
objvQxPrjMenus_UpEN.QxPrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus_Up.PrjName))
{
objvQxPrjMenus_UpEN.PrjName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus_Up.UpMenuId))
{
objvQxPrjMenus_UpEN.UpMenuId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus_Up.LinkFile))
{
objvQxPrjMenus_UpEN.LinkFile = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus_Up.qsParameters))
{
objvQxPrjMenus_UpEN.qsParameters = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus_Up.ImgFile))
{
objvQxPrjMenus_UpEN.ImgFile = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus_Up.OrderNum))
{
objvQxPrjMenus_UpEN.OrderNum = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(convQxPrjMenus_Up.IsLeafNode))
{
objvQxPrjMenus_UpEN.IsLeafNode = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(convQxPrjMenus_Up.MenuSetId))
{
objvQxPrjMenus_UpEN.MenuSetId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus_Up.MenuSetName))
{
objvQxPrjMenus_UpEN.MenuSetName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus_Up.MenuTitle))
{
objvQxPrjMenus_UpEN.MenuTitle = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus_Up.PageDispModeId))
{
objvQxPrjMenus_UpEN.PageDispModeId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus_Up.PageDispModeName))
{
objvQxPrjMenus_UpEN.PageDispModeName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus_Up.InUse))
{
objvQxPrjMenus_UpEN.InUse = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(convQxPrjMenus_Up.UpdDate))
{
objvQxPrjMenus_UpEN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus_Up.UpdUserId))
{
objvQxPrjMenus_UpEN.UpdUserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus_Up.Memo))
{
objvQxPrjMenus_UpEN.Memo = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus_Up.MenuControlName))
{
objvQxPrjMenus_UpEN.MenuControlName = reader.ReadElementContentAsString();
}
}
return objvQxPrjMenus_UpEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strvQxPrjMenus_UpObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsvQxPrjMenus_UpEN GetObjFromXmlStr(string strvQxPrjMenus_UpObjXmlStr)
{
clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN = new clsvQxPrjMenus_UpEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strvQxPrjMenus_UpObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsvQxPrjMenus_UpBL.itemXmlNode))
{
objvQxPrjMenus_UpEN = GetObjFromXml(reader);
return objvQxPrjMenus_UpEN;
}
}
return objvQxPrjMenus_UpEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objvQxPrjMenus_UpEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objvQxPrjMenus_UpEN);
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
public static string Func(string strInFldName, string strOutFldName, string strMenuIdUp)
{
if (strInFldName != convQxPrjMenus_Up.MenuIdUp)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convQxPrjMenus_Up.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convQxPrjMenus_Up.AttributeName));
throw new Exception(strMsg);
}
var objvQxPrjMenus_Up = clsvQxPrjMenus_UpBL.GetObjByMenuIdUpCache(strMenuIdUp);
if (objvQxPrjMenus_Up == null) return "";
return objvQxPrjMenus_Up[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objvQxPrjMenus_UpEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsvQxPrjMenus_UpEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objvQxPrjMenus_UpEN[strField]);
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
 /// <param name = "lstvQxPrjMenus_UpObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsvQxPrjMenus_UpEN> lstvQxPrjMenus_UpObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstvQxPrjMenus_UpObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN in lstvQxPrjMenus_UpObjLst)
{
string strJSON_One = SerializeObjToJSON(objvQxPrjMenus_UpEN);
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
int intRecCount = clsvQxPrjMenus_UpDA.GetRecCount(strTabName);
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
int intRecCount = clsvQxPrjMenus_UpDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvQxPrjMenus_UpDA.GetRecCount();
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
int intRecCount = clsvQxPrjMenus_UpDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvQxPrjMenus_UpCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvQxPrjMenus_UpEN objvQxPrjMenus_UpCond)
{
List<clsvQxPrjMenus_UpEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjMenus_UpEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxPrjMenus_Up.AttributeName)
{
if (objvQxPrjMenus_UpCond.IsUpdated(strFldName) == false) continue;
if (objvQxPrjMenus_UpCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjMenus_UpCond[strFldName].ToString());
}
else
{
if (objvQxPrjMenus_UpCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxPrjMenus_UpCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjMenus_UpCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxPrjMenus_UpCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxPrjMenus_UpCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxPrjMenus_UpCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxPrjMenus_UpCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxPrjMenus_UpCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxPrjMenus_UpCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxPrjMenus_UpCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxPrjMenus_UpCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxPrjMenus_UpCond[strFldName]));
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
 List<string> arrList = clsvQxPrjMenus_UpDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vQxPrjMenus_UpDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vQxPrjMenus_UpDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}