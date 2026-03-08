
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPrjMenus_SubBL
 表名:vQxPrjMenus_Sub(00140079)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:33:42
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
public static class  clsvQxPrjMenus_SubBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strMenuIdSub">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxPrjMenus_SubEN GetObj(this K_MenuIdSub_vQxPrjMenus_Sub myKey)
{
clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN = clsvQxPrjMenus_SubBL.vQxPrjMenus_SubDA.GetObjByMenuIdSub(myKey.Value);
return objvQxPrjMenus_SubEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_SubEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_SubEN SetMenuIdSub(this clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN, string strMenuIdSub, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuIdSub, 8, convQxPrjMenus_Sub.MenuIdSub);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMenuIdSub, 8, convQxPrjMenus_Sub.MenuIdSub);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_SubEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_SubEN SetMenuName(this clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN, string strMenuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMenuName, convQxPrjMenus_Sub.MenuName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuName, 50, convQxPrjMenus_Sub.MenuName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_SubEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_SubEN SetQxPrjId(this clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN, string strQxPrjId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxPrjMenus_Sub.QxPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxPrjMenus_Sub.QxPrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_SubEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_SubEN SetPrjName(this clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN, string strPrjName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convQxPrjMenus_Sub.PrjName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_SubEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_SubEN SetUpMenuId(this clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN, string strUpMenuId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpMenuId, 8, convQxPrjMenus_Sub.UpMenuId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUpMenuId, 8, convQxPrjMenus_Sub.UpMenuId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_SubEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_SubEN SetLinkFile(this clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN, string strLinkFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLinkFile, 500, convQxPrjMenus_Sub.LinkFile);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_SubEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_SubEN SetqsParameters(this clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN, string strqsParameters, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strqsParameters, 200, convQxPrjMenus_Sub.qsParameters);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_SubEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_SubEN SetImgFile(this clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN, string strImgFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strImgFile, 300, convQxPrjMenus_Sub.ImgFile);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_SubEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_SubEN SetOrderNum(this clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN, int? intOrderNum, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_SubEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_SubEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_SubEN SetMenuSetId(this clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN, string strMenuSetId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMenuSetId, convQxPrjMenus_Sub.MenuSetId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuSetId, 4, convQxPrjMenus_Sub.MenuSetId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMenuSetId, 4, convQxPrjMenus_Sub.MenuSetId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_SubEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_SubEN SetMenuSetName(this clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN, string strMenuSetName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuSetName, 50, convQxPrjMenus_Sub.MenuSetName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_SubEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_SubEN SetMenuTitle(this clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN, string strMenuTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuTitle, 50, convQxPrjMenus_Sub.MenuTitle);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_SubEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_SubEN SetPageDispModeId(this clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN, string strPageDispModeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPageDispModeId, 2, convQxPrjMenus_Sub.PageDispModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPageDispModeId, 2, convQxPrjMenus_Sub.PageDispModeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_SubEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_SubEN SetPageDispModeName(this clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN, string strPageDispModeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPageDispModeName, 50, convQxPrjMenus_Sub.PageDispModeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_SubEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_SubEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_SubEN SetUpdDate(this clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQxPrjMenus_Sub.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_SubEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_SubEN SetUpdUserId(this clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convQxPrjMenus_Sub.UpdUserId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_SubEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_SubEN SetMemo(this clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxPrjMenus_Sub.Memo);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_SubEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_SubEN SetMenuControlName(this clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN, string strMenuControlName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuControlName, 100, convQxPrjMenus_Sub.MenuControlName);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvQxPrjMenus_SubENS">源对象</param>
 /// <param name = "objvQxPrjMenus_SubENT">目标对象</param>
 public static void CopyTo(this clsvQxPrjMenus_SubEN objvQxPrjMenus_SubENS, clsvQxPrjMenus_SubEN objvQxPrjMenus_SubENT)
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
 /// <param name = "objvQxPrjMenus_SubENS">源对象</param>
 /// <returns>目标对象=>clsvQxPrjMenus_SubEN:objvQxPrjMenus_SubENT</returns>
 public static clsvQxPrjMenus_SubEN CopyTo(this clsvQxPrjMenus_SubEN objvQxPrjMenus_SubENS)
{
try
{
 clsvQxPrjMenus_SubEN objvQxPrjMenus_SubENT = new clsvQxPrjMenus_SubEN()
{
MenuIdSub = objvQxPrjMenus_SubENS.MenuIdSub, //MenuId_Sub
MenuName = objvQxPrjMenus_SubENS.MenuName, //菜单名
QxPrjId = objvQxPrjMenus_SubENS.QxPrjId, //项目Id
PrjName = objvQxPrjMenus_SubENS.PrjName, //工程名
UpMenuId = objvQxPrjMenus_SubENS.UpMenuId, //上级菜单Id
LinkFile = objvQxPrjMenus_SubENS.LinkFile, //链接文件
qsParameters = objvQxPrjMenus_SubENS.qsParameters, //qs参数
ImgFile = objvQxPrjMenus_SubENS.ImgFile, //图像文件
OrderNum = objvQxPrjMenus_SubENS.OrderNum, //排序号
IsLeafNode = objvQxPrjMenus_SubENS.IsLeafNode, //是否叶子
MenuSetId = objvQxPrjMenus_SubENS.MenuSetId, //菜单集Id
MenuSetName = objvQxPrjMenus_SubENS.MenuSetName, //菜单集名称
MenuTitle = objvQxPrjMenus_SubENS.MenuTitle, //菜单标题
PageDispModeId = objvQxPrjMenus_SubENS.PageDispModeId, //页面显示模式Id
PageDispModeName = objvQxPrjMenus_SubENS.PageDispModeName, //页面显示模式名称
InUse = objvQxPrjMenus_SubENS.InUse, //是否在用
UpdDate = objvQxPrjMenus_SubENS.UpdDate, //修改日期
UpdUserId = objvQxPrjMenus_SubENS.UpdUserId, //修改用户Id
Memo = objvQxPrjMenus_SubENS.Memo, //备注
MenuControlName = objvQxPrjMenus_SubENS.MenuControlName, //MenuControlName
};
 return objvQxPrjMenus_SubENT;
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
public static void CheckProperty4Condition(this clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN)
{
 clsvQxPrjMenus_SubBL.vQxPrjMenus_SubDA.CheckProperty4Condition(objvQxPrjMenus_SubEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vQxPrjMenus_Sub
{
public virtual bool UpdRelaTabDate(string strMenuIdSub, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v子层菜单(vQxPrjMenus_Sub)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvQxPrjMenus_SubBL
{
public static RelatedActions_vQxPrjMenus_Sub relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "vQxPrjMenus_SubListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "vQxPrjMenus_SubList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsvQxPrjMenus_SubEN> arrvQxPrjMenus_SubObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvQxPrjMenus_SubDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvQxPrjMenus_SubDA vQxPrjMenus_SubDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvQxPrjMenus_SubDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvQxPrjMenus_SubBL()
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
if (string.IsNullOrEmpty(clsvQxPrjMenus_SubEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxPrjMenus_SubEN._ConnectString);
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
objDS = vQxPrjMenus_SubDA.GetDataSet(strWhereCond);
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
objDS = vQxPrjMenus_SubDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = vQxPrjMenus_SubDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_vQxPrjMenus_Sub(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQxPrjMenus_SubDA.GetDataTable_vQxPrjMenus_Sub(strWhereCond);
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
objDT = vQxPrjMenus_SubDA.GetDataTable(strWhereCond);
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
objDT = vQxPrjMenus_SubDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vQxPrjMenus_SubDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vQxPrjMenus_SubDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vQxPrjMenus_SubDA.GetDataTable_Top(objTopPara);
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
objDT = vQxPrjMenus_SubDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vQxPrjMenus_SubDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = vQxPrjMenus_SubDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vQxPrjMenus_SubDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = vQxPrjMenus_SubDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = vQxPrjMenus_SubDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = vQxPrjMenus_SubDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = vQxPrjMenus_SubDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
 /// <param name = "arrMenuIdSubLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvQxPrjMenus_SubEN> GetObjLstByMenuIdSubLst(List<string> arrMenuIdSubLst)
{
List<clsvQxPrjMenus_SubEN> arrObjLst = new List<clsvQxPrjMenus_SubEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMenuIdSubLst, true);
 string strWhereCond = string.Format("MenuIdSub in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN = new clsvQxPrjMenus_SubEN();
try
{
objvQxPrjMenus_SubEN.MenuIdSub = objRow[convQxPrjMenus_Sub.MenuIdSub].ToString().Trim(); //MenuId_Sub
objvQxPrjMenus_SubEN.MenuName = objRow[convQxPrjMenus_Sub.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenus_SubEN.QxPrjId = objRow[convQxPrjMenus_Sub.QxPrjId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenus_SubEN.PrjName = objRow[convQxPrjMenus_Sub.PrjName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PrjName].ToString().Trim(); //工程名
objvQxPrjMenus_SubEN.UpMenuId = objRow[convQxPrjMenus_Sub.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenus_SubEN.LinkFile = objRow[convQxPrjMenus_Sub.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenus_SubEN.qsParameters = objRow[convQxPrjMenus_Sub.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenus_SubEN.ImgFile = objRow[convQxPrjMenus_Sub.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenus_SubEN.OrderNum = objRow[convQxPrjMenus_Sub.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus_Sub.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenus_SubEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Sub.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenus_SubEN.MenuSetId = objRow[convQxPrjMenus_Sub.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenus_SubEN.MenuSetName = objRow[convQxPrjMenus_Sub.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenus_SubEN.MenuTitle = objRow[convQxPrjMenus_Sub.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenus_SubEN.PageDispModeId = objRow[convQxPrjMenus_Sub.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenus_SubEN.PageDispModeName = objRow[convQxPrjMenus_Sub.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenus_SubEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Sub.InUse].ToString().Trim()); //是否在用
objvQxPrjMenus_SubEN.UpdDate = objRow[convQxPrjMenus_Sub.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenus_SubEN.UpdUserId = objRow[convQxPrjMenus_Sub.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenus_SubEN.Memo = objRow[convQxPrjMenus_Sub.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.Memo].ToString().Trim(); //备注
objvQxPrjMenus_SubEN.MenuControlName = objRow[convQxPrjMenus_Sub.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuControlName].ToString().Trim(); //MenuControlName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenus_SubEN.MenuIdSub, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenus_SubEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMenuIdSubLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvQxPrjMenus_SubEN> GetObjLstByMenuIdSubLstCache(List<string> arrMenuIdSubLst)
{
string strKey = string.Format("{0}", clsvQxPrjMenus_SubEN._CurrTabName);
List<clsvQxPrjMenus_SubEN> arrvQxPrjMenus_SubObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjMenus_SubEN> arrvQxPrjMenus_SubObjLst_Sel =
arrvQxPrjMenus_SubObjLstCache
.Where(x => arrMenuIdSubLst.Contains(x.MenuIdSub));
return arrvQxPrjMenus_SubObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjMenus_SubEN> GetObjLst(string strWhereCond)
{
List<clsvQxPrjMenus_SubEN> arrObjLst = new List<clsvQxPrjMenus_SubEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN = new clsvQxPrjMenus_SubEN();
try
{
objvQxPrjMenus_SubEN.MenuIdSub = objRow[convQxPrjMenus_Sub.MenuIdSub].ToString().Trim(); //MenuId_Sub
objvQxPrjMenus_SubEN.MenuName = objRow[convQxPrjMenus_Sub.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenus_SubEN.QxPrjId = objRow[convQxPrjMenus_Sub.QxPrjId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenus_SubEN.PrjName = objRow[convQxPrjMenus_Sub.PrjName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PrjName].ToString().Trim(); //工程名
objvQxPrjMenus_SubEN.UpMenuId = objRow[convQxPrjMenus_Sub.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenus_SubEN.LinkFile = objRow[convQxPrjMenus_Sub.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenus_SubEN.qsParameters = objRow[convQxPrjMenus_Sub.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenus_SubEN.ImgFile = objRow[convQxPrjMenus_Sub.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenus_SubEN.OrderNum = objRow[convQxPrjMenus_Sub.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus_Sub.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenus_SubEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Sub.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenus_SubEN.MenuSetId = objRow[convQxPrjMenus_Sub.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenus_SubEN.MenuSetName = objRow[convQxPrjMenus_Sub.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenus_SubEN.MenuTitle = objRow[convQxPrjMenus_Sub.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenus_SubEN.PageDispModeId = objRow[convQxPrjMenus_Sub.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenus_SubEN.PageDispModeName = objRow[convQxPrjMenus_Sub.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenus_SubEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Sub.InUse].ToString().Trim()); //是否在用
objvQxPrjMenus_SubEN.UpdDate = objRow[convQxPrjMenus_Sub.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenus_SubEN.UpdUserId = objRow[convQxPrjMenus_Sub.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenus_SubEN.Memo = objRow[convQxPrjMenus_Sub.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.Memo].ToString().Trim(); //备注
objvQxPrjMenus_SubEN.MenuControlName = objRow[convQxPrjMenus_Sub.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuControlName].ToString().Trim(); //MenuControlName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenus_SubEN.MenuIdSub, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenus_SubEN);
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
public static List<clsvQxPrjMenus_SubEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQxPrjMenus_SubEN> arrObjLst = new List<clsvQxPrjMenus_SubEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN = new clsvQxPrjMenus_SubEN();
try
{
objvQxPrjMenus_SubEN.MenuIdSub = objRow[convQxPrjMenus_Sub.MenuIdSub].ToString().Trim(); //MenuId_Sub
objvQxPrjMenus_SubEN.MenuName = objRow[convQxPrjMenus_Sub.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenus_SubEN.QxPrjId = objRow[convQxPrjMenus_Sub.QxPrjId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenus_SubEN.PrjName = objRow[convQxPrjMenus_Sub.PrjName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PrjName].ToString().Trim(); //工程名
objvQxPrjMenus_SubEN.UpMenuId = objRow[convQxPrjMenus_Sub.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenus_SubEN.LinkFile = objRow[convQxPrjMenus_Sub.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenus_SubEN.qsParameters = objRow[convQxPrjMenus_Sub.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenus_SubEN.ImgFile = objRow[convQxPrjMenus_Sub.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenus_SubEN.OrderNum = objRow[convQxPrjMenus_Sub.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus_Sub.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenus_SubEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Sub.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenus_SubEN.MenuSetId = objRow[convQxPrjMenus_Sub.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenus_SubEN.MenuSetName = objRow[convQxPrjMenus_Sub.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenus_SubEN.MenuTitle = objRow[convQxPrjMenus_Sub.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenus_SubEN.PageDispModeId = objRow[convQxPrjMenus_Sub.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenus_SubEN.PageDispModeName = objRow[convQxPrjMenus_Sub.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenus_SubEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Sub.InUse].ToString().Trim()); //是否在用
objvQxPrjMenus_SubEN.UpdDate = objRow[convQxPrjMenus_Sub.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenus_SubEN.UpdUserId = objRow[convQxPrjMenus_Sub.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenus_SubEN.Memo = objRow[convQxPrjMenus_Sub.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.Memo].ToString().Trim(); //备注
objvQxPrjMenus_SubEN.MenuControlName = objRow[convQxPrjMenus_Sub.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuControlName].ToString().Trim(); //MenuControlName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenus_SubEN.MenuIdSub, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenus_SubEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvQxPrjMenus_SubCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvQxPrjMenus_SubEN> GetSubObjLstCache(clsvQxPrjMenus_SubEN objvQxPrjMenus_SubCond)
{
List<clsvQxPrjMenus_SubEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjMenus_SubEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxPrjMenus_Sub.AttributeName)
{
if (objvQxPrjMenus_SubCond.IsUpdated(strFldName) == false) continue;
if (objvQxPrjMenus_SubCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjMenus_SubCond[strFldName].ToString());
}
else
{
if (objvQxPrjMenus_SubCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxPrjMenus_SubCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjMenus_SubCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxPrjMenus_SubCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxPrjMenus_SubCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxPrjMenus_SubCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxPrjMenus_SubCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxPrjMenus_SubCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxPrjMenus_SubCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxPrjMenus_SubCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxPrjMenus_SubCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxPrjMenus_SubCond[strFldName]));
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
public static List<clsvQxPrjMenus_SubEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvQxPrjMenus_SubEN> arrObjLst = new List<clsvQxPrjMenus_SubEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN = new clsvQxPrjMenus_SubEN();
try
{
objvQxPrjMenus_SubEN.MenuIdSub = objRow[convQxPrjMenus_Sub.MenuIdSub].ToString().Trim(); //MenuId_Sub
objvQxPrjMenus_SubEN.MenuName = objRow[convQxPrjMenus_Sub.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenus_SubEN.QxPrjId = objRow[convQxPrjMenus_Sub.QxPrjId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenus_SubEN.PrjName = objRow[convQxPrjMenus_Sub.PrjName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PrjName].ToString().Trim(); //工程名
objvQxPrjMenus_SubEN.UpMenuId = objRow[convQxPrjMenus_Sub.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenus_SubEN.LinkFile = objRow[convQxPrjMenus_Sub.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenus_SubEN.qsParameters = objRow[convQxPrjMenus_Sub.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenus_SubEN.ImgFile = objRow[convQxPrjMenus_Sub.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenus_SubEN.OrderNum = objRow[convQxPrjMenus_Sub.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus_Sub.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenus_SubEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Sub.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenus_SubEN.MenuSetId = objRow[convQxPrjMenus_Sub.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenus_SubEN.MenuSetName = objRow[convQxPrjMenus_Sub.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenus_SubEN.MenuTitle = objRow[convQxPrjMenus_Sub.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenus_SubEN.PageDispModeId = objRow[convQxPrjMenus_Sub.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenus_SubEN.PageDispModeName = objRow[convQxPrjMenus_Sub.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenus_SubEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Sub.InUse].ToString().Trim()); //是否在用
objvQxPrjMenus_SubEN.UpdDate = objRow[convQxPrjMenus_Sub.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenus_SubEN.UpdUserId = objRow[convQxPrjMenus_Sub.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenus_SubEN.Memo = objRow[convQxPrjMenus_Sub.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.Memo].ToString().Trim(); //备注
objvQxPrjMenus_SubEN.MenuControlName = objRow[convQxPrjMenus_Sub.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuControlName].ToString().Trim(); //MenuControlName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenus_SubEN.MenuIdSub, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenus_SubEN);
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
public static List<clsvQxPrjMenus_SubEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvQxPrjMenus_SubEN> arrObjLst = new List<clsvQxPrjMenus_SubEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN = new clsvQxPrjMenus_SubEN();
try
{
objvQxPrjMenus_SubEN.MenuIdSub = objRow[convQxPrjMenus_Sub.MenuIdSub].ToString().Trim(); //MenuId_Sub
objvQxPrjMenus_SubEN.MenuName = objRow[convQxPrjMenus_Sub.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenus_SubEN.QxPrjId = objRow[convQxPrjMenus_Sub.QxPrjId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenus_SubEN.PrjName = objRow[convQxPrjMenus_Sub.PrjName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PrjName].ToString().Trim(); //工程名
objvQxPrjMenus_SubEN.UpMenuId = objRow[convQxPrjMenus_Sub.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenus_SubEN.LinkFile = objRow[convQxPrjMenus_Sub.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenus_SubEN.qsParameters = objRow[convQxPrjMenus_Sub.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenus_SubEN.ImgFile = objRow[convQxPrjMenus_Sub.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenus_SubEN.OrderNum = objRow[convQxPrjMenus_Sub.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus_Sub.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenus_SubEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Sub.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenus_SubEN.MenuSetId = objRow[convQxPrjMenus_Sub.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenus_SubEN.MenuSetName = objRow[convQxPrjMenus_Sub.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenus_SubEN.MenuTitle = objRow[convQxPrjMenus_Sub.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenus_SubEN.PageDispModeId = objRow[convQxPrjMenus_Sub.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenus_SubEN.PageDispModeName = objRow[convQxPrjMenus_Sub.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenus_SubEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Sub.InUse].ToString().Trim()); //是否在用
objvQxPrjMenus_SubEN.UpdDate = objRow[convQxPrjMenus_Sub.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenus_SubEN.UpdUserId = objRow[convQxPrjMenus_Sub.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenus_SubEN.Memo = objRow[convQxPrjMenus_Sub.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.Memo].ToString().Trim(); //备注
objvQxPrjMenus_SubEN.MenuControlName = objRow[convQxPrjMenus_Sub.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuControlName].ToString().Trim(); //MenuControlName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenus_SubEN.MenuIdSub, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenus_SubEN);
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
List<clsvQxPrjMenus_SubEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvQxPrjMenus_SubEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjMenus_SubEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvQxPrjMenus_SubEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvQxPrjMenus_SubEN> arrObjLst = new List<clsvQxPrjMenus_SubEN>(); 
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
	clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN = new clsvQxPrjMenus_SubEN();
try
{
objvQxPrjMenus_SubEN.MenuIdSub = objRow[convQxPrjMenus_Sub.MenuIdSub].ToString().Trim(); //MenuId_Sub
objvQxPrjMenus_SubEN.MenuName = objRow[convQxPrjMenus_Sub.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenus_SubEN.QxPrjId = objRow[convQxPrjMenus_Sub.QxPrjId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenus_SubEN.PrjName = objRow[convQxPrjMenus_Sub.PrjName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PrjName].ToString().Trim(); //工程名
objvQxPrjMenus_SubEN.UpMenuId = objRow[convQxPrjMenus_Sub.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenus_SubEN.LinkFile = objRow[convQxPrjMenus_Sub.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenus_SubEN.qsParameters = objRow[convQxPrjMenus_Sub.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenus_SubEN.ImgFile = objRow[convQxPrjMenus_Sub.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenus_SubEN.OrderNum = objRow[convQxPrjMenus_Sub.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus_Sub.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenus_SubEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Sub.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenus_SubEN.MenuSetId = objRow[convQxPrjMenus_Sub.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenus_SubEN.MenuSetName = objRow[convQxPrjMenus_Sub.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenus_SubEN.MenuTitle = objRow[convQxPrjMenus_Sub.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenus_SubEN.PageDispModeId = objRow[convQxPrjMenus_Sub.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenus_SubEN.PageDispModeName = objRow[convQxPrjMenus_Sub.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenus_SubEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Sub.InUse].ToString().Trim()); //是否在用
objvQxPrjMenus_SubEN.UpdDate = objRow[convQxPrjMenus_Sub.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenus_SubEN.UpdUserId = objRow[convQxPrjMenus_Sub.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenus_SubEN.Memo = objRow[convQxPrjMenus_Sub.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.Memo].ToString().Trim(); //备注
objvQxPrjMenus_SubEN.MenuControlName = objRow[convQxPrjMenus_Sub.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuControlName].ToString().Trim(); //MenuControlName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenus_SubEN.MenuIdSub, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenus_SubEN);
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
public static List<clsvQxPrjMenus_SubEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvQxPrjMenus_SubEN> arrObjLst = new List<clsvQxPrjMenus_SubEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN = new clsvQxPrjMenus_SubEN();
try
{
objvQxPrjMenus_SubEN.MenuIdSub = objRow[convQxPrjMenus_Sub.MenuIdSub].ToString().Trim(); //MenuId_Sub
objvQxPrjMenus_SubEN.MenuName = objRow[convQxPrjMenus_Sub.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenus_SubEN.QxPrjId = objRow[convQxPrjMenus_Sub.QxPrjId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenus_SubEN.PrjName = objRow[convQxPrjMenus_Sub.PrjName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PrjName].ToString().Trim(); //工程名
objvQxPrjMenus_SubEN.UpMenuId = objRow[convQxPrjMenus_Sub.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenus_SubEN.LinkFile = objRow[convQxPrjMenus_Sub.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenus_SubEN.qsParameters = objRow[convQxPrjMenus_Sub.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenus_SubEN.ImgFile = objRow[convQxPrjMenus_Sub.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenus_SubEN.OrderNum = objRow[convQxPrjMenus_Sub.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus_Sub.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenus_SubEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Sub.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenus_SubEN.MenuSetId = objRow[convQxPrjMenus_Sub.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenus_SubEN.MenuSetName = objRow[convQxPrjMenus_Sub.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenus_SubEN.MenuTitle = objRow[convQxPrjMenus_Sub.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenus_SubEN.PageDispModeId = objRow[convQxPrjMenus_Sub.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenus_SubEN.PageDispModeName = objRow[convQxPrjMenus_Sub.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenus_SubEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Sub.InUse].ToString().Trim()); //是否在用
objvQxPrjMenus_SubEN.UpdDate = objRow[convQxPrjMenus_Sub.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenus_SubEN.UpdUserId = objRow[convQxPrjMenus_Sub.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenus_SubEN.Memo = objRow[convQxPrjMenus_Sub.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.Memo].ToString().Trim(); //备注
objvQxPrjMenus_SubEN.MenuControlName = objRow[convQxPrjMenus_Sub.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuControlName].ToString().Trim(); //MenuControlName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenus_SubEN.MenuIdSub, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenus_SubEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQxPrjMenus_SubEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvQxPrjMenus_SubEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvQxPrjMenus_SubEN> arrObjLst = new List<clsvQxPrjMenus_SubEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN = new clsvQxPrjMenus_SubEN();
try
{
objvQxPrjMenus_SubEN.MenuIdSub = objRow[convQxPrjMenus_Sub.MenuIdSub].ToString().Trim(); //MenuId_Sub
objvQxPrjMenus_SubEN.MenuName = objRow[convQxPrjMenus_Sub.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenus_SubEN.QxPrjId = objRow[convQxPrjMenus_Sub.QxPrjId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenus_SubEN.PrjName = objRow[convQxPrjMenus_Sub.PrjName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PrjName].ToString().Trim(); //工程名
objvQxPrjMenus_SubEN.UpMenuId = objRow[convQxPrjMenus_Sub.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenus_SubEN.LinkFile = objRow[convQxPrjMenus_Sub.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenus_SubEN.qsParameters = objRow[convQxPrjMenus_Sub.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenus_SubEN.ImgFile = objRow[convQxPrjMenus_Sub.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenus_SubEN.OrderNum = objRow[convQxPrjMenus_Sub.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus_Sub.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenus_SubEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Sub.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenus_SubEN.MenuSetId = objRow[convQxPrjMenus_Sub.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenus_SubEN.MenuSetName = objRow[convQxPrjMenus_Sub.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenus_SubEN.MenuTitle = objRow[convQxPrjMenus_Sub.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenus_SubEN.PageDispModeId = objRow[convQxPrjMenus_Sub.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenus_SubEN.PageDispModeName = objRow[convQxPrjMenus_Sub.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenus_SubEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Sub.InUse].ToString().Trim()); //是否在用
objvQxPrjMenus_SubEN.UpdDate = objRow[convQxPrjMenus_Sub.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenus_SubEN.UpdUserId = objRow[convQxPrjMenus_Sub.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenus_SubEN.Memo = objRow[convQxPrjMenus_Sub.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.Memo].ToString().Trim(); //备注
objvQxPrjMenus_SubEN.MenuControlName = objRow[convQxPrjMenus_Sub.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuControlName].ToString().Trim(); //MenuControlName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenus_SubEN.MenuIdSub, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenus_SubEN);
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
public static List<clsvQxPrjMenus_SubEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvQxPrjMenus_SubEN> arrObjLst = new List<clsvQxPrjMenus_SubEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN = new clsvQxPrjMenus_SubEN();
try
{
objvQxPrjMenus_SubEN.MenuIdSub = objRow[convQxPrjMenus_Sub.MenuIdSub].ToString().Trim(); //MenuId_Sub
objvQxPrjMenus_SubEN.MenuName = objRow[convQxPrjMenus_Sub.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenus_SubEN.QxPrjId = objRow[convQxPrjMenus_Sub.QxPrjId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenus_SubEN.PrjName = objRow[convQxPrjMenus_Sub.PrjName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PrjName].ToString().Trim(); //工程名
objvQxPrjMenus_SubEN.UpMenuId = objRow[convQxPrjMenus_Sub.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenus_SubEN.LinkFile = objRow[convQxPrjMenus_Sub.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenus_SubEN.qsParameters = objRow[convQxPrjMenus_Sub.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenus_SubEN.ImgFile = objRow[convQxPrjMenus_Sub.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenus_SubEN.OrderNum = objRow[convQxPrjMenus_Sub.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus_Sub.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenus_SubEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Sub.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenus_SubEN.MenuSetId = objRow[convQxPrjMenus_Sub.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenus_SubEN.MenuSetName = objRow[convQxPrjMenus_Sub.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenus_SubEN.MenuTitle = objRow[convQxPrjMenus_Sub.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenus_SubEN.PageDispModeId = objRow[convQxPrjMenus_Sub.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenus_SubEN.PageDispModeName = objRow[convQxPrjMenus_Sub.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenus_SubEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Sub.InUse].ToString().Trim()); //是否在用
objvQxPrjMenus_SubEN.UpdDate = objRow[convQxPrjMenus_Sub.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenus_SubEN.UpdUserId = objRow[convQxPrjMenus_Sub.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenus_SubEN.Memo = objRow[convQxPrjMenus_Sub.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.Memo].ToString().Trim(); //备注
objvQxPrjMenus_SubEN.MenuControlName = objRow[convQxPrjMenus_Sub.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuControlName].ToString().Trim(); //MenuControlName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenus_SubEN.MenuIdSub, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenus_SubEN);
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
public static IEnumerable<clsvQxPrjMenus_SubEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsvQxPrjMenus_SubEN objvQxPrjMenus_SubCond, string strOrderBy)
{
List<clsvQxPrjMenus_SubEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjMenus_SubEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxPrjMenus_Sub.AttributeName)
{
if (objvQxPrjMenus_SubCond.IsUpdated(strFldName) == false) continue;
if (objvQxPrjMenus_SubCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjMenus_SubCond[strFldName].ToString());
}
else
{
if (objvQxPrjMenus_SubCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxPrjMenus_SubCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjMenus_SubCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxPrjMenus_SubCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxPrjMenus_SubCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxPrjMenus_SubCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxPrjMenus_SubCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxPrjMenus_SubCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxPrjMenus_SubCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxPrjMenus_SubCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxPrjMenus_SubCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxPrjMenus_SubCond[strFldName]));
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
public static IEnumerable<clsvQxPrjMenus_SubEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsvQxPrjMenus_SubEN objvQxPrjMenus_SubCond = JsonConvert.DeserializeObject<clsvQxPrjMenus_SubEN>(objPagerPara.whereCond);
if (objvQxPrjMenus_SubCond.sfFldComparisonOp == null)
{
objvQxPrjMenus_SubCond.dicFldComparisonOp = null;
}
else
{
objvQxPrjMenus_SubCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objvQxPrjMenus_SubCond.sfFldComparisonOp);
}
clsvQxPrjMenus_SubBL.SetUpdFlag(objvQxPrjMenus_SubCond);
 try
{
CheckProperty4Condition(objvQxPrjMenus_SubCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsvQxPrjMenus_SubBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objvQxPrjMenus_SubCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjMenus_SubEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsvQxPrjMenus_SubEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxPrjMenus_SubEN> arrObjLst = new List<clsvQxPrjMenus_SubEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN = new clsvQxPrjMenus_SubEN();
try
{
objvQxPrjMenus_SubEN.MenuIdSub = objRow[convQxPrjMenus_Sub.MenuIdSub].ToString().Trim(); //MenuId_Sub
objvQxPrjMenus_SubEN.MenuName = objRow[convQxPrjMenus_Sub.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenus_SubEN.QxPrjId = objRow[convQxPrjMenus_Sub.QxPrjId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenus_SubEN.PrjName = objRow[convQxPrjMenus_Sub.PrjName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PrjName].ToString().Trim(); //工程名
objvQxPrjMenus_SubEN.UpMenuId = objRow[convQxPrjMenus_Sub.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenus_SubEN.LinkFile = objRow[convQxPrjMenus_Sub.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenus_SubEN.qsParameters = objRow[convQxPrjMenus_Sub.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenus_SubEN.ImgFile = objRow[convQxPrjMenus_Sub.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenus_SubEN.OrderNum = objRow[convQxPrjMenus_Sub.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus_Sub.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenus_SubEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Sub.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenus_SubEN.MenuSetId = objRow[convQxPrjMenus_Sub.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenus_SubEN.MenuSetName = objRow[convQxPrjMenus_Sub.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenus_SubEN.MenuTitle = objRow[convQxPrjMenus_Sub.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenus_SubEN.PageDispModeId = objRow[convQxPrjMenus_Sub.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenus_SubEN.PageDispModeName = objRow[convQxPrjMenus_Sub.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenus_SubEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Sub.InUse].ToString().Trim()); //是否在用
objvQxPrjMenus_SubEN.UpdDate = objRow[convQxPrjMenus_Sub.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenus_SubEN.UpdUserId = objRow[convQxPrjMenus_Sub.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenus_SubEN.Memo = objRow[convQxPrjMenus_Sub.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.Memo].ToString().Trim(); //备注
objvQxPrjMenus_SubEN.MenuControlName = objRow[convQxPrjMenus_Sub.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuControlName].ToString().Trim(); //MenuControlName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenus_SubEN.MenuIdSub, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenus_SubEN);
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
public static List<clsvQxPrjMenus_SubEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxPrjMenus_SubEN> arrObjLst = new List<clsvQxPrjMenus_SubEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN = new clsvQxPrjMenus_SubEN();
try
{
objvQxPrjMenus_SubEN.MenuIdSub = objRow[convQxPrjMenus_Sub.MenuIdSub].ToString().Trim(); //MenuId_Sub
objvQxPrjMenus_SubEN.MenuName = objRow[convQxPrjMenus_Sub.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenus_SubEN.QxPrjId = objRow[convQxPrjMenus_Sub.QxPrjId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenus_SubEN.PrjName = objRow[convQxPrjMenus_Sub.PrjName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PrjName].ToString().Trim(); //工程名
objvQxPrjMenus_SubEN.UpMenuId = objRow[convQxPrjMenus_Sub.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenus_SubEN.LinkFile = objRow[convQxPrjMenus_Sub.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenus_SubEN.qsParameters = objRow[convQxPrjMenus_Sub.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenus_SubEN.ImgFile = objRow[convQxPrjMenus_Sub.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenus_SubEN.OrderNum = objRow[convQxPrjMenus_Sub.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus_Sub.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenus_SubEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Sub.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenus_SubEN.MenuSetId = objRow[convQxPrjMenus_Sub.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenus_SubEN.MenuSetName = objRow[convQxPrjMenus_Sub.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenus_SubEN.MenuTitle = objRow[convQxPrjMenus_Sub.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenus_SubEN.PageDispModeId = objRow[convQxPrjMenus_Sub.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenus_SubEN.PageDispModeName = objRow[convQxPrjMenus_Sub.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenus_SubEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Sub.InUse].ToString().Trim()); //是否在用
objvQxPrjMenus_SubEN.UpdDate = objRow[convQxPrjMenus_Sub.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenus_SubEN.UpdUserId = objRow[convQxPrjMenus_Sub.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenus_SubEN.Memo = objRow[convQxPrjMenus_Sub.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.Memo].ToString().Trim(); //备注
objvQxPrjMenus_SubEN.MenuControlName = objRow[convQxPrjMenus_Sub.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuControlName].ToString().Trim(); //MenuControlName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenus_SubEN.MenuIdSub, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenus_SubEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjMenus_SubEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvQxPrjMenus_SubEN> arrObjLst = new List<clsvQxPrjMenus_SubEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN = new clsvQxPrjMenus_SubEN();
try
{
objvQxPrjMenus_SubEN.MenuIdSub = objRow[convQxPrjMenus_Sub.MenuIdSub].ToString().Trim(); //MenuId_Sub
objvQxPrjMenus_SubEN.MenuName = objRow[convQxPrjMenus_Sub.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenus_SubEN.QxPrjId = objRow[convQxPrjMenus_Sub.QxPrjId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenus_SubEN.PrjName = objRow[convQxPrjMenus_Sub.PrjName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PrjName].ToString().Trim(); //工程名
objvQxPrjMenus_SubEN.UpMenuId = objRow[convQxPrjMenus_Sub.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenus_SubEN.LinkFile = objRow[convQxPrjMenus_Sub.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenus_SubEN.qsParameters = objRow[convQxPrjMenus_Sub.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenus_SubEN.ImgFile = objRow[convQxPrjMenus_Sub.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenus_SubEN.OrderNum = objRow[convQxPrjMenus_Sub.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus_Sub.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenus_SubEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Sub.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenus_SubEN.MenuSetId = objRow[convQxPrjMenus_Sub.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenus_SubEN.MenuSetName = objRow[convQxPrjMenus_Sub.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenus_SubEN.MenuTitle = objRow[convQxPrjMenus_Sub.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenus_SubEN.PageDispModeId = objRow[convQxPrjMenus_Sub.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenus_SubEN.PageDispModeName = objRow[convQxPrjMenus_Sub.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenus_SubEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Sub.InUse].ToString().Trim()); //是否在用
objvQxPrjMenus_SubEN.UpdDate = objRow[convQxPrjMenus_Sub.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenus_SubEN.UpdUserId = objRow[convQxPrjMenus_Sub.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenus_SubEN.Memo = objRow[convQxPrjMenus_Sub.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.Memo].ToString().Trim(); //备注
objvQxPrjMenus_SubEN.MenuControlName = objRow[convQxPrjMenus_Sub.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus_Sub.MenuControlName].ToString().Trim(); //MenuControlName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenus_SubEN.MenuIdSub, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenus_SubEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvQxPrjMenus_SubEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxPrjMenus_Sub(ref clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN)
{
bool bolResult = vQxPrjMenus_SubDA.GetvQxPrjMenus_Sub(ref objvQxPrjMenus_SubEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strMenuIdSub">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxPrjMenus_SubEN GetObjByMenuIdSub(string strMenuIdSub)
{
if (strMenuIdSub.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strMenuIdSub]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strMenuIdSub) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strMenuIdSub]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN = vQxPrjMenus_SubDA.GetObjByMenuIdSub(strMenuIdSub);
return objvQxPrjMenus_SubEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvQxPrjMenus_SubEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN = vQxPrjMenus_SubDA.GetFirstObj(strWhereCond);
 return objvQxPrjMenus_SubEN;
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
public static clsvQxPrjMenus_SubEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN = vQxPrjMenus_SubDA.GetObjByDataRow(objRow);
 return objvQxPrjMenus_SubEN;
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
public static clsvQxPrjMenus_SubEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN = vQxPrjMenus_SubDA.GetObjByDataRow(objRow);
 return objvQxPrjMenus_SubEN;
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
 /// <param name = "strMenuIdSub">所给的关键字</param>
 /// <param name = "lstvQxPrjMenus_SubObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxPrjMenus_SubEN GetObjByMenuIdSubFromList(string strMenuIdSub, List<clsvQxPrjMenus_SubEN> lstvQxPrjMenus_SubObjLst)
{
foreach (clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN in lstvQxPrjMenus_SubObjLst)
{
if (objvQxPrjMenus_SubEN.MenuIdSub == strMenuIdSub)
{
return objvQxPrjMenus_SubEN;
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
 string strMenuIdSub;
 try
 {
 strMenuIdSub = new clsvQxPrjMenus_SubDA().GetFirstID(strWhereCond);
 return strMenuIdSub;
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
 arrList = vQxPrjMenus_SubDA.GetID(strWhereCond);
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
bool bolIsExist = vQxPrjMenus_SubDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strMenuIdSub">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strMenuIdSub)
{
if (string.IsNullOrEmpty(strMenuIdSub) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strMenuIdSub]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vQxPrjMenus_SubDA.IsExist(strMenuIdSub);
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
 bolIsExist = clsvQxPrjMenus_SubDA.IsExistTable();
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
 bolIsExist = vQxPrjMenus_SubDA.IsExistTable(strTabName);
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
 /// <param name = "objvQxPrjMenus_SubEN">源简化对象</param>
 public static void SetUpdFlag(clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN)
{
try
{
objvQxPrjMenus_SubEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvQxPrjMenus_SubEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convQxPrjMenus_Sub.MenuIdSub, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_SubEN.MenuIdSub = objvQxPrjMenus_SubEN.MenuIdSub; //MenuId_Sub
}
if (arrFldSet.Contains(convQxPrjMenus_Sub.MenuName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_SubEN.MenuName = objvQxPrjMenus_SubEN.MenuName; //菜单名
}
if (arrFldSet.Contains(convQxPrjMenus_Sub.QxPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_SubEN.QxPrjId = objvQxPrjMenus_SubEN.QxPrjId == "[null]" ? null :  objvQxPrjMenus_SubEN.QxPrjId; //项目Id
}
if (arrFldSet.Contains(convQxPrjMenus_Sub.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_SubEN.PrjName = objvQxPrjMenus_SubEN.PrjName == "[null]" ? null :  objvQxPrjMenus_SubEN.PrjName; //工程名
}
if (arrFldSet.Contains(convQxPrjMenus_Sub.UpMenuId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_SubEN.UpMenuId = objvQxPrjMenus_SubEN.UpMenuId == "[null]" ? null :  objvQxPrjMenus_SubEN.UpMenuId; //上级菜单Id
}
if (arrFldSet.Contains(convQxPrjMenus_Sub.LinkFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_SubEN.LinkFile = objvQxPrjMenus_SubEN.LinkFile == "[null]" ? null :  objvQxPrjMenus_SubEN.LinkFile; //链接文件
}
if (arrFldSet.Contains(convQxPrjMenus_Sub.qsParameters, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_SubEN.qsParameters = objvQxPrjMenus_SubEN.qsParameters == "[null]" ? null :  objvQxPrjMenus_SubEN.qsParameters; //qs参数
}
if (arrFldSet.Contains(convQxPrjMenus_Sub.ImgFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_SubEN.ImgFile = objvQxPrjMenus_SubEN.ImgFile == "[null]" ? null :  objvQxPrjMenus_SubEN.ImgFile; //图像文件
}
if (arrFldSet.Contains(convQxPrjMenus_Sub.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_SubEN.OrderNum = objvQxPrjMenus_SubEN.OrderNum; //排序号
}
if (arrFldSet.Contains(convQxPrjMenus_Sub.IsLeafNode, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_SubEN.IsLeafNode = objvQxPrjMenus_SubEN.IsLeafNode; //是否叶子
}
if (arrFldSet.Contains(convQxPrjMenus_Sub.MenuSetId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_SubEN.MenuSetId = objvQxPrjMenus_SubEN.MenuSetId; //菜单集Id
}
if (arrFldSet.Contains(convQxPrjMenus_Sub.MenuSetName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_SubEN.MenuSetName = objvQxPrjMenus_SubEN.MenuSetName == "[null]" ? null :  objvQxPrjMenus_SubEN.MenuSetName; //菜单集名称
}
if (arrFldSet.Contains(convQxPrjMenus_Sub.MenuTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_SubEN.MenuTitle = objvQxPrjMenus_SubEN.MenuTitle == "[null]" ? null :  objvQxPrjMenus_SubEN.MenuTitle; //菜单标题
}
if (arrFldSet.Contains(convQxPrjMenus_Sub.PageDispModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_SubEN.PageDispModeId = objvQxPrjMenus_SubEN.PageDispModeId == "[null]" ? null :  objvQxPrjMenus_SubEN.PageDispModeId; //页面显示模式Id
}
if (arrFldSet.Contains(convQxPrjMenus_Sub.PageDispModeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_SubEN.PageDispModeName = objvQxPrjMenus_SubEN.PageDispModeName == "[null]" ? null :  objvQxPrjMenus_SubEN.PageDispModeName; //页面显示模式名称
}
if (arrFldSet.Contains(convQxPrjMenus_Sub.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_SubEN.InUse = objvQxPrjMenus_SubEN.InUse; //是否在用
}
if (arrFldSet.Contains(convQxPrjMenus_Sub.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_SubEN.UpdDate = objvQxPrjMenus_SubEN.UpdDate == "[null]" ? null :  objvQxPrjMenus_SubEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convQxPrjMenus_Sub.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_SubEN.UpdUserId = objvQxPrjMenus_SubEN.UpdUserId == "[null]" ? null :  objvQxPrjMenus_SubEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convQxPrjMenus_Sub.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_SubEN.Memo = objvQxPrjMenus_SubEN.Memo == "[null]" ? null :  objvQxPrjMenus_SubEN.Memo; //备注
}
if (arrFldSet.Contains(convQxPrjMenus_Sub.MenuControlName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_SubEN.MenuControlName = objvQxPrjMenus_SubEN.MenuControlName == "[null]" ? null :  objvQxPrjMenus_SubEN.MenuControlName; //MenuControlName
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
 /// <param name = "objvQxPrjMenus_SubEN">源简化对象</param>
 public static void AccessFldValueNull(clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN)
{
try
{
if (objvQxPrjMenus_SubEN.QxPrjId == "[null]") objvQxPrjMenus_SubEN.QxPrjId = null; //项目Id
if (objvQxPrjMenus_SubEN.PrjName == "[null]") objvQxPrjMenus_SubEN.PrjName = null; //工程名
if (objvQxPrjMenus_SubEN.UpMenuId == "[null]") objvQxPrjMenus_SubEN.UpMenuId = null; //上级菜单Id
if (objvQxPrjMenus_SubEN.LinkFile == "[null]") objvQxPrjMenus_SubEN.LinkFile = null; //链接文件
if (objvQxPrjMenus_SubEN.qsParameters == "[null]") objvQxPrjMenus_SubEN.qsParameters = null; //qs参数
if (objvQxPrjMenus_SubEN.ImgFile == "[null]") objvQxPrjMenus_SubEN.ImgFile = null; //图像文件
if (objvQxPrjMenus_SubEN.MenuSetName == "[null]") objvQxPrjMenus_SubEN.MenuSetName = null; //菜单集名称
if (objvQxPrjMenus_SubEN.MenuTitle == "[null]") objvQxPrjMenus_SubEN.MenuTitle = null; //菜单标题
if (objvQxPrjMenus_SubEN.PageDispModeId == "[null]") objvQxPrjMenus_SubEN.PageDispModeId = null; //页面显示模式Id
if (objvQxPrjMenus_SubEN.PageDispModeName == "[null]") objvQxPrjMenus_SubEN.PageDispModeName = null; //页面显示模式名称
if (objvQxPrjMenus_SubEN.UpdDate == "[null]") objvQxPrjMenus_SubEN.UpdDate = null; //修改日期
if (objvQxPrjMenus_SubEN.UpdUserId == "[null]") objvQxPrjMenus_SubEN.UpdUserId = null; //修改用户Id
if (objvQxPrjMenus_SubEN.Memo == "[null]") objvQxPrjMenus_SubEN.Memo = null; //备注
if (objvQxPrjMenus_SubEN.MenuControlName == "[null]") objvQxPrjMenus_SubEN.MenuControlName = null; //MenuControlName
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
public static void CheckProperty4Condition(clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN)
{
 vQxPrjMenus_SubDA.CheckProperty4Condition(objvQxPrjMenus_SubEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_MenuIdSub(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convQxPrjMenus_Sub.MenuIdSub); 
List<clsvQxPrjMenus_SubEN> arrObjLst = clsvQxPrjMenus_SubBL.GetObjLst(strCondition);
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
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_MenuIdSub(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v子层菜单]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convQxPrjMenus_Sub.MenuIdSub); 
IEnumerable<clsvQxPrjMenus_SubEN> arrObjLst = clsvQxPrjMenus_SubBL.GetObjLst(strCondition);
objDDL.DataValueField = convQxPrjMenus_Sub.MenuIdSub;
objDDL.DataTextField = convQxPrjMenus_Sub.MenuName;
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
public static void BindDdl_MenuIdSubCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v子层菜单]...","0");
List<clsvQxPrjMenus_SubEN> arrvQxPrjMenus_SubObjLst = GetAllvQxPrjMenus_SubObjLstCache(); 
objDDL.DataValueField = convQxPrjMenus_Sub.MenuIdSub;
objDDL.DataTextField = convQxPrjMenus_Sub.MenuName;
objDDL.DataSource = arrvQxPrjMenus_SubObjLst;
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
//string strWhereCond = string.Format("1 = 1 order by MenuIdSub");
//if (arrvQxPrjMenus_SubObjLstCache == null)
//{
//arrvQxPrjMenus_SubObjLstCache = vQxPrjMenus_SubDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strMenuIdSub">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxPrjMenus_SubEN GetObjByMenuIdSubCache(string strMenuIdSub)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvQxPrjMenus_SubEN._CurrTabName);
List<clsvQxPrjMenus_SubEN> arrvQxPrjMenus_SubObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjMenus_SubEN> arrvQxPrjMenus_SubObjLst_Sel =
arrvQxPrjMenus_SubObjLstCache
.Where(x=> x.MenuIdSub == strMenuIdSub 
);
if (arrvQxPrjMenus_SubObjLst_Sel.Count() == 0)
{
   clsvQxPrjMenus_SubEN obj = clsvQxPrjMenus_SubBL.GetObjByMenuIdSub(strMenuIdSub);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvQxPrjMenus_SubObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strMenuIdSub">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetMenuNameByMenuIdSubCache(string strMenuIdSub)
{
if (string.IsNullOrEmpty(strMenuIdSub) == true) return "";
//获取缓存中的对象列表
clsvQxPrjMenus_SubEN objvQxPrjMenus_Sub = GetObjByMenuIdSubCache(strMenuIdSub);
if (objvQxPrjMenus_Sub == null) return "";
return objvQxPrjMenus_Sub.MenuName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strMenuIdSub">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByMenuIdSubCache(string strMenuIdSub)
{
if (string.IsNullOrEmpty(strMenuIdSub) == true) return "";
//获取缓存中的对象列表
clsvQxPrjMenus_SubEN objvQxPrjMenus_Sub = GetObjByMenuIdSubCache(strMenuIdSub);
if (objvQxPrjMenus_Sub == null) return "";
return objvQxPrjMenus_Sub.MenuName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxPrjMenus_SubEN> GetAllvQxPrjMenus_SubObjLstCache()
{
//获取缓存中的对象列表
List<clsvQxPrjMenus_SubEN> arrvQxPrjMenus_SubObjLstCache = GetObjLstCache(); 
return arrvQxPrjMenus_SubObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxPrjMenus_SubEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvQxPrjMenus_SubEN._CurrTabName);
List<clsvQxPrjMenus_SubEN> arrvQxPrjMenus_SubObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQxPrjMenus_SubObjLstCache;
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


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstvQxPrjMenus_SubObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsvQxPrjMenus_SubEN> lstvQxPrjMenus_SubObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstvQxPrjMenus_SubObjLst, writer);
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
 /// <param name = "lstvQxPrjMenus_SubObjLst">[clsvQxPrjMenus_SubEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsvQxPrjMenus_SubEN> lstvQxPrjMenus_SubObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsvQxPrjMenus_SubBL.listXmlNode);
writer.WriteStartElement(clsvQxPrjMenus_SubBL.itemsXmlNode);
foreach (clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN in lstvQxPrjMenus_SubObjLst)
{
clsvQxPrjMenus_SubBL.SerializeXML(writer, objvQxPrjMenus_SubEN);
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
 /// <param name = "objvQxPrjMenus_SubEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN)
{
writer.WriteStartElement(clsvQxPrjMenus_SubBL.itemXmlNode);
 
if (objvQxPrjMenus_SubEN.MenuIdSub != null)
{
writer.WriteElementString(convQxPrjMenus_Sub.MenuIdSub, objvQxPrjMenus_SubEN.MenuIdSub.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenus_SubEN.MenuName != null)
{
writer.WriteElementString(convQxPrjMenus_Sub.MenuName, objvQxPrjMenus_SubEN.MenuName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenus_SubEN.QxPrjId != null)
{
writer.WriteElementString(convQxPrjMenus_Sub.QxPrjId, objvQxPrjMenus_SubEN.QxPrjId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenus_SubEN.PrjName != null)
{
writer.WriteElementString(convQxPrjMenus_Sub.PrjName, objvQxPrjMenus_SubEN.PrjName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenus_SubEN.UpMenuId != null)
{
writer.WriteElementString(convQxPrjMenus_Sub.UpMenuId, objvQxPrjMenus_SubEN.UpMenuId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenus_SubEN.LinkFile != null)
{
writer.WriteElementString(convQxPrjMenus_Sub.LinkFile, objvQxPrjMenus_SubEN.LinkFile.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenus_SubEN.qsParameters != null)
{
writer.WriteElementString(convQxPrjMenus_Sub.qsParameters, objvQxPrjMenus_SubEN.qsParameters.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenus_SubEN.ImgFile != null)
{
writer.WriteElementString(convQxPrjMenus_Sub.ImgFile, objvQxPrjMenus_SubEN.ImgFile.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convQxPrjMenus_Sub.OrderNum, objvQxPrjMenus_SubEN.OrderNum.ToString());
 
writer.WriteElementString(convQxPrjMenus_Sub.IsLeafNode, objvQxPrjMenus_SubEN.IsLeafNode.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objvQxPrjMenus_SubEN.MenuSetId != null)
{
writer.WriteElementString(convQxPrjMenus_Sub.MenuSetId, objvQxPrjMenus_SubEN.MenuSetId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenus_SubEN.MenuSetName != null)
{
writer.WriteElementString(convQxPrjMenus_Sub.MenuSetName, objvQxPrjMenus_SubEN.MenuSetName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenus_SubEN.MenuTitle != null)
{
writer.WriteElementString(convQxPrjMenus_Sub.MenuTitle, objvQxPrjMenus_SubEN.MenuTitle.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenus_SubEN.PageDispModeId != null)
{
writer.WriteElementString(convQxPrjMenus_Sub.PageDispModeId, objvQxPrjMenus_SubEN.PageDispModeId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenus_SubEN.PageDispModeName != null)
{
writer.WriteElementString(convQxPrjMenus_Sub.PageDispModeName, objvQxPrjMenus_SubEN.PageDispModeName.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convQxPrjMenus_Sub.InUse, objvQxPrjMenus_SubEN.InUse.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objvQxPrjMenus_SubEN.UpdDate != null)
{
writer.WriteElementString(convQxPrjMenus_Sub.UpdDate, objvQxPrjMenus_SubEN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenus_SubEN.UpdUserId != null)
{
writer.WriteElementString(convQxPrjMenus_Sub.UpdUserId, objvQxPrjMenus_SubEN.UpdUserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenus_SubEN.Memo != null)
{
writer.WriteElementString(convQxPrjMenus_Sub.Memo, objvQxPrjMenus_SubEN.Memo.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenus_SubEN.MenuControlName != null)
{
writer.WriteElementString(convQxPrjMenus_Sub.MenuControlName, objvQxPrjMenus_SubEN.MenuControlName.ToString(CultureInfo.InvariantCulture));
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
public static clsvQxPrjMenus_SubEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN = new clsvQxPrjMenus_SubEN();
reader.Read();
while (!(reader.Name == clsvQxPrjMenus_SubBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(convQxPrjMenus_Sub.MenuIdSub))
{
objvQxPrjMenus_SubEN.MenuIdSub = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus_Sub.MenuName))
{
objvQxPrjMenus_SubEN.MenuName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus_Sub.QxPrjId))
{
objvQxPrjMenus_SubEN.QxPrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus_Sub.PrjName))
{
objvQxPrjMenus_SubEN.PrjName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus_Sub.UpMenuId))
{
objvQxPrjMenus_SubEN.UpMenuId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus_Sub.LinkFile))
{
objvQxPrjMenus_SubEN.LinkFile = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus_Sub.qsParameters))
{
objvQxPrjMenus_SubEN.qsParameters = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus_Sub.ImgFile))
{
objvQxPrjMenus_SubEN.ImgFile = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus_Sub.OrderNum))
{
objvQxPrjMenus_SubEN.OrderNum = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(convQxPrjMenus_Sub.IsLeafNode))
{
objvQxPrjMenus_SubEN.IsLeafNode = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(convQxPrjMenus_Sub.MenuSetId))
{
objvQxPrjMenus_SubEN.MenuSetId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus_Sub.MenuSetName))
{
objvQxPrjMenus_SubEN.MenuSetName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus_Sub.MenuTitle))
{
objvQxPrjMenus_SubEN.MenuTitle = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus_Sub.PageDispModeId))
{
objvQxPrjMenus_SubEN.PageDispModeId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus_Sub.PageDispModeName))
{
objvQxPrjMenus_SubEN.PageDispModeName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus_Sub.InUse))
{
objvQxPrjMenus_SubEN.InUse = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(convQxPrjMenus_Sub.UpdDate))
{
objvQxPrjMenus_SubEN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus_Sub.UpdUserId))
{
objvQxPrjMenus_SubEN.UpdUserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus_Sub.Memo))
{
objvQxPrjMenus_SubEN.Memo = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus_Sub.MenuControlName))
{
objvQxPrjMenus_SubEN.MenuControlName = reader.ReadElementContentAsString();
}
}
return objvQxPrjMenus_SubEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strvQxPrjMenus_SubObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsvQxPrjMenus_SubEN GetObjFromXmlStr(string strvQxPrjMenus_SubObjXmlStr)
{
clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN = new clsvQxPrjMenus_SubEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strvQxPrjMenus_SubObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsvQxPrjMenus_SubBL.itemXmlNode))
{
objvQxPrjMenus_SubEN = GetObjFromXml(reader);
return objvQxPrjMenus_SubEN;
}
}
return objvQxPrjMenus_SubEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objvQxPrjMenus_SubEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objvQxPrjMenus_SubEN);
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
public static string Func(string strInFldName, string strOutFldName, string strMenuIdSub)
{
if (strInFldName != convQxPrjMenus_Sub.MenuIdSub)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convQxPrjMenus_Sub.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convQxPrjMenus_Sub.AttributeName));
throw new Exception(strMsg);
}
var objvQxPrjMenus_Sub = clsvQxPrjMenus_SubBL.GetObjByMenuIdSubCache(strMenuIdSub);
if (objvQxPrjMenus_Sub == null) return "";
return objvQxPrjMenus_Sub[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objvQxPrjMenus_SubEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsvQxPrjMenus_SubEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objvQxPrjMenus_SubEN[strField]);
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
 /// <param name = "lstvQxPrjMenus_SubObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsvQxPrjMenus_SubEN> lstvQxPrjMenus_SubObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstvQxPrjMenus_SubObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN in lstvQxPrjMenus_SubObjLst)
{
string strJSON_One = SerializeObjToJSON(objvQxPrjMenus_SubEN);
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
int intRecCount = clsvQxPrjMenus_SubDA.GetRecCount(strTabName);
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
int intRecCount = clsvQxPrjMenus_SubDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvQxPrjMenus_SubDA.GetRecCount();
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
int intRecCount = clsvQxPrjMenus_SubDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvQxPrjMenus_SubCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvQxPrjMenus_SubEN objvQxPrjMenus_SubCond)
{
List<clsvQxPrjMenus_SubEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjMenus_SubEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxPrjMenus_Sub.AttributeName)
{
if (objvQxPrjMenus_SubCond.IsUpdated(strFldName) == false) continue;
if (objvQxPrjMenus_SubCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjMenus_SubCond[strFldName].ToString());
}
else
{
if (objvQxPrjMenus_SubCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxPrjMenus_SubCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjMenus_SubCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxPrjMenus_SubCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxPrjMenus_SubCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxPrjMenus_SubCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxPrjMenus_SubCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxPrjMenus_SubCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxPrjMenus_SubCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxPrjMenus_SubCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxPrjMenus_SubCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxPrjMenus_SubCond[strFldName]));
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
 List<string> arrList = clsvQxPrjMenus_SubDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vQxPrjMenus_SubDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vQxPrjMenus_SubDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}