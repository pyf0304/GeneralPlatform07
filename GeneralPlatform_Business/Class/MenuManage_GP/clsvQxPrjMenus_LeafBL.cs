
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPrjMenus_LeafBL
 表名:vQxPrjMenus_Leaf(00140085)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:33:29
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
public static class  clsvQxPrjMenus_LeafBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strMenuIdLeaf">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxPrjMenus_LeafEN GetObj(this K_MenuIdLeaf_vQxPrjMenus_Leaf myKey)
{
clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN = clsvQxPrjMenus_LeafBL.vQxPrjMenus_LeafDA.GetObjByMenuIdLeaf(myKey.Value);
return objvQxPrjMenus_LeafEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_LeafEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_LeafEN SetMenuIdLeaf(this clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN, string strMenuIdLeaf, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuIdLeaf, 8, convQxPrjMenus_Leaf.MenuIdLeaf);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMenuIdLeaf, 8, convQxPrjMenus_Leaf.MenuIdLeaf);
}
objvQxPrjMenus_LeafEN.MenuIdLeaf = strMenuIdLeaf; //MenuId_Leaf
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_LeafEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Leaf.MenuIdLeaf) == false)
{
objvQxPrjMenus_LeafEN.dicFldComparisonOp.Add(convQxPrjMenus_Leaf.MenuIdLeaf, strComparisonOp);
}
else
{
objvQxPrjMenus_LeafEN.dicFldComparisonOp[convQxPrjMenus_Leaf.MenuIdLeaf] = strComparisonOp;
}
}
return objvQxPrjMenus_LeafEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_LeafEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_LeafEN SetMenuName(this clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN, string strMenuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMenuName, convQxPrjMenus_Leaf.MenuName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuName, 50, convQxPrjMenus_Leaf.MenuName);
}
objvQxPrjMenus_LeafEN.MenuName = strMenuName; //菜单名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_LeafEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Leaf.MenuName) == false)
{
objvQxPrjMenus_LeafEN.dicFldComparisonOp.Add(convQxPrjMenus_Leaf.MenuName, strComparisonOp);
}
else
{
objvQxPrjMenus_LeafEN.dicFldComparisonOp[convQxPrjMenus_Leaf.MenuName] = strComparisonOp;
}
}
return objvQxPrjMenus_LeafEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_LeafEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_LeafEN SetQxPrjId(this clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN, string strQxPrjId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxPrjMenus_Leaf.QxPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxPrjMenus_Leaf.QxPrjId);
}
objvQxPrjMenus_LeafEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_LeafEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Leaf.QxPrjId) == false)
{
objvQxPrjMenus_LeafEN.dicFldComparisonOp.Add(convQxPrjMenus_Leaf.QxPrjId, strComparisonOp);
}
else
{
objvQxPrjMenus_LeafEN.dicFldComparisonOp[convQxPrjMenus_Leaf.QxPrjId] = strComparisonOp;
}
}
return objvQxPrjMenus_LeafEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_LeafEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_LeafEN SetPrjName(this clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN, string strPrjName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convQxPrjMenus_Leaf.PrjName);
}
objvQxPrjMenus_LeafEN.PrjName = strPrjName; //工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_LeafEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Leaf.PrjName) == false)
{
objvQxPrjMenus_LeafEN.dicFldComparisonOp.Add(convQxPrjMenus_Leaf.PrjName, strComparisonOp);
}
else
{
objvQxPrjMenus_LeafEN.dicFldComparisonOp[convQxPrjMenus_Leaf.PrjName] = strComparisonOp;
}
}
return objvQxPrjMenus_LeafEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_LeafEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_LeafEN SetUpMenuId(this clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN, string strUpMenuId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpMenuId, 8, convQxPrjMenus_Leaf.UpMenuId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUpMenuId, 8, convQxPrjMenus_Leaf.UpMenuId);
}
objvQxPrjMenus_LeafEN.UpMenuId = strUpMenuId; //上级菜单Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_LeafEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Leaf.UpMenuId) == false)
{
objvQxPrjMenus_LeafEN.dicFldComparisonOp.Add(convQxPrjMenus_Leaf.UpMenuId, strComparisonOp);
}
else
{
objvQxPrjMenus_LeafEN.dicFldComparisonOp[convQxPrjMenus_Leaf.UpMenuId] = strComparisonOp;
}
}
return objvQxPrjMenus_LeafEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_LeafEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_LeafEN SetLinkFile(this clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN, string strLinkFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLinkFile, 500, convQxPrjMenus_Leaf.LinkFile);
}
objvQxPrjMenus_LeafEN.LinkFile = strLinkFile; //链接文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_LeafEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Leaf.LinkFile) == false)
{
objvQxPrjMenus_LeafEN.dicFldComparisonOp.Add(convQxPrjMenus_Leaf.LinkFile, strComparisonOp);
}
else
{
objvQxPrjMenus_LeafEN.dicFldComparisonOp[convQxPrjMenus_Leaf.LinkFile] = strComparisonOp;
}
}
return objvQxPrjMenus_LeafEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_LeafEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_LeafEN SetqsParameters(this clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN, string strqsParameters, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strqsParameters, 200, convQxPrjMenus_Leaf.qsParameters);
}
objvQxPrjMenus_LeafEN.qsParameters = strqsParameters; //qs参数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_LeafEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Leaf.qsParameters) == false)
{
objvQxPrjMenus_LeafEN.dicFldComparisonOp.Add(convQxPrjMenus_Leaf.qsParameters, strComparisonOp);
}
else
{
objvQxPrjMenus_LeafEN.dicFldComparisonOp[convQxPrjMenus_Leaf.qsParameters] = strComparisonOp;
}
}
return objvQxPrjMenus_LeafEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_LeafEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_LeafEN SetImgFile(this clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN, string strImgFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strImgFile, 300, convQxPrjMenus_Leaf.ImgFile);
}
objvQxPrjMenus_LeafEN.ImgFile = strImgFile; //图像文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_LeafEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Leaf.ImgFile) == false)
{
objvQxPrjMenus_LeafEN.dicFldComparisonOp.Add(convQxPrjMenus_Leaf.ImgFile, strComparisonOp);
}
else
{
objvQxPrjMenus_LeafEN.dicFldComparisonOp[convQxPrjMenus_Leaf.ImgFile] = strComparisonOp;
}
}
return objvQxPrjMenus_LeafEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_LeafEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_LeafEN SetOrderNum(this clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN, int? intOrderNum, string strComparisonOp="")
	{
objvQxPrjMenus_LeafEN.OrderNum = intOrderNum; //排序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_LeafEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Leaf.OrderNum) == false)
{
objvQxPrjMenus_LeafEN.dicFldComparisonOp.Add(convQxPrjMenus_Leaf.OrderNum, strComparisonOp);
}
else
{
objvQxPrjMenus_LeafEN.dicFldComparisonOp[convQxPrjMenus_Leaf.OrderNum] = strComparisonOp;
}
}
return objvQxPrjMenus_LeafEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_LeafEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_LeafEN SetIsLeafNode(this clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN, bool bolIsLeafNode, string strComparisonOp="")
	{
objvQxPrjMenus_LeafEN.IsLeafNode = bolIsLeafNode; //是否叶子
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_LeafEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Leaf.IsLeafNode) == false)
{
objvQxPrjMenus_LeafEN.dicFldComparisonOp.Add(convQxPrjMenus_Leaf.IsLeafNode, strComparisonOp);
}
else
{
objvQxPrjMenus_LeafEN.dicFldComparisonOp[convQxPrjMenus_Leaf.IsLeafNode] = strComparisonOp;
}
}
return objvQxPrjMenus_LeafEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_LeafEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_LeafEN SetMenuSetId(this clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN, string strMenuSetId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMenuSetId, convQxPrjMenus_Leaf.MenuSetId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuSetId, 4, convQxPrjMenus_Leaf.MenuSetId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMenuSetId, 4, convQxPrjMenus_Leaf.MenuSetId);
}
objvQxPrjMenus_LeafEN.MenuSetId = strMenuSetId; //菜单集Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_LeafEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Leaf.MenuSetId) == false)
{
objvQxPrjMenus_LeafEN.dicFldComparisonOp.Add(convQxPrjMenus_Leaf.MenuSetId, strComparisonOp);
}
else
{
objvQxPrjMenus_LeafEN.dicFldComparisonOp[convQxPrjMenus_Leaf.MenuSetId] = strComparisonOp;
}
}
return objvQxPrjMenus_LeafEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_LeafEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_LeafEN SetMenuSetName(this clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN, string strMenuSetName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuSetName, 50, convQxPrjMenus_Leaf.MenuSetName);
}
objvQxPrjMenus_LeafEN.MenuSetName = strMenuSetName; //菜单集名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_LeafEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Leaf.MenuSetName) == false)
{
objvQxPrjMenus_LeafEN.dicFldComparisonOp.Add(convQxPrjMenus_Leaf.MenuSetName, strComparisonOp);
}
else
{
objvQxPrjMenus_LeafEN.dicFldComparisonOp[convQxPrjMenus_Leaf.MenuSetName] = strComparisonOp;
}
}
return objvQxPrjMenus_LeafEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_LeafEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_LeafEN SetMenuTitle(this clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN, string strMenuTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuTitle, 50, convQxPrjMenus_Leaf.MenuTitle);
}
objvQxPrjMenus_LeafEN.MenuTitle = strMenuTitle; //菜单标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_LeafEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Leaf.MenuTitle) == false)
{
objvQxPrjMenus_LeafEN.dicFldComparisonOp.Add(convQxPrjMenus_Leaf.MenuTitle, strComparisonOp);
}
else
{
objvQxPrjMenus_LeafEN.dicFldComparisonOp[convQxPrjMenus_Leaf.MenuTitle] = strComparisonOp;
}
}
return objvQxPrjMenus_LeafEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_LeafEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_LeafEN SetPageDispModeId(this clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN, string strPageDispModeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPageDispModeId, 2, convQxPrjMenus_Leaf.PageDispModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPageDispModeId, 2, convQxPrjMenus_Leaf.PageDispModeId);
}
objvQxPrjMenus_LeafEN.PageDispModeId = strPageDispModeId; //页面显示模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_LeafEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Leaf.PageDispModeId) == false)
{
objvQxPrjMenus_LeafEN.dicFldComparisonOp.Add(convQxPrjMenus_Leaf.PageDispModeId, strComparisonOp);
}
else
{
objvQxPrjMenus_LeafEN.dicFldComparisonOp[convQxPrjMenus_Leaf.PageDispModeId] = strComparisonOp;
}
}
return objvQxPrjMenus_LeafEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_LeafEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_LeafEN SetPageDispModeName(this clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN, string strPageDispModeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPageDispModeName, 50, convQxPrjMenus_Leaf.PageDispModeName);
}
objvQxPrjMenus_LeafEN.PageDispModeName = strPageDispModeName; //页面显示模式名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_LeafEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Leaf.PageDispModeName) == false)
{
objvQxPrjMenus_LeafEN.dicFldComparisonOp.Add(convQxPrjMenus_Leaf.PageDispModeName, strComparisonOp);
}
else
{
objvQxPrjMenus_LeafEN.dicFldComparisonOp[convQxPrjMenus_Leaf.PageDispModeName] = strComparisonOp;
}
}
return objvQxPrjMenus_LeafEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_LeafEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_LeafEN SetInUse(this clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN, bool bolInUse, string strComparisonOp="")
	{
objvQxPrjMenus_LeafEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_LeafEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Leaf.InUse) == false)
{
objvQxPrjMenus_LeafEN.dicFldComparisonOp.Add(convQxPrjMenus_Leaf.InUse, strComparisonOp);
}
else
{
objvQxPrjMenus_LeafEN.dicFldComparisonOp[convQxPrjMenus_Leaf.InUse] = strComparisonOp;
}
}
return objvQxPrjMenus_LeafEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_LeafEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_LeafEN SetUpdDate(this clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQxPrjMenus_Leaf.UpdDate);
}
objvQxPrjMenus_LeafEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_LeafEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Leaf.UpdDate) == false)
{
objvQxPrjMenus_LeafEN.dicFldComparisonOp.Add(convQxPrjMenus_Leaf.UpdDate, strComparisonOp);
}
else
{
objvQxPrjMenus_LeafEN.dicFldComparisonOp[convQxPrjMenus_Leaf.UpdDate] = strComparisonOp;
}
}
return objvQxPrjMenus_LeafEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_LeafEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_LeafEN SetUpdUserId(this clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convQxPrjMenus_Leaf.UpdUserId);
}
objvQxPrjMenus_LeafEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_LeafEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Leaf.UpdUserId) == false)
{
objvQxPrjMenus_LeafEN.dicFldComparisonOp.Add(convQxPrjMenus_Leaf.UpdUserId, strComparisonOp);
}
else
{
objvQxPrjMenus_LeafEN.dicFldComparisonOp[convQxPrjMenus_Leaf.UpdUserId] = strComparisonOp;
}
}
return objvQxPrjMenus_LeafEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_LeafEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_LeafEN SetMemo(this clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxPrjMenus_Leaf.Memo);
}
objvQxPrjMenus_LeafEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_LeafEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Leaf.Memo) == false)
{
objvQxPrjMenus_LeafEN.dicFldComparisonOp.Add(convQxPrjMenus_Leaf.Memo, strComparisonOp);
}
else
{
objvQxPrjMenus_LeafEN.dicFldComparisonOp[convQxPrjMenus_Leaf.Memo] = strComparisonOp;
}
}
return objvQxPrjMenus_LeafEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_LeafEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_LeafEN SetMenuControlName(this clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN, string strMenuControlName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuControlName, 100, convQxPrjMenus_Leaf.MenuControlName);
}
objvQxPrjMenus_LeafEN.MenuControlName = strMenuControlName; //MenuControlName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenus_LeafEN.dicFldComparisonOp.ContainsKey(convQxPrjMenus_Leaf.MenuControlName) == false)
{
objvQxPrjMenus_LeafEN.dicFldComparisonOp.Add(convQxPrjMenus_Leaf.MenuControlName, strComparisonOp);
}
else
{
objvQxPrjMenus_LeafEN.dicFldComparisonOp[convQxPrjMenus_Leaf.MenuControlName] = strComparisonOp;
}
}
return objvQxPrjMenus_LeafEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvQxPrjMenus_LeafENS">源对象</param>
 /// <param name = "objvQxPrjMenus_LeafENT">目标对象</param>
 public static void CopyTo(this clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafENS, clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafENT)
{
try
{
objvQxPrjMenus_LeafENT.MenuIdLeaf = objvQxPrjMenus_LeafENS.MenuIdLeaf; //MenuId_Leaf
objvQxPrjMenus_LeafENT.MenuName = objvQxPrjMenus_LeafENS.MenuName; //菜单名
objvQxPrjMenus_LeafENT.QxPrjId = objvQxPrjMenus_LeafENS.QxPrjId; //项目Id
objvQxPrjMenus_LeafENT.PrjName = objvQxPrjMenus_LeafENS.PrjName; //工程名
objvQxPrjMenus_LeafENT.UpMenuId = objvQxPrjMenus_LeafENS.UpMenuId; //上级菜单Id
objvQxPrjMenus_LeafENT.LinkFile = objvQxPrjMenus_LeafENS.LinkFile; //链接文件
objvQxPrjMenus_LeafENT.qsParameters = objvQxPrjMenus_LeafENS.qsParameters; //qs参数
objvQxPrjMenus_LeafENT.ImgFile = objvQxPrjMenus_LeafENS.ImgFile; //图像文件
objvQxPrjMenus_LeafENT.OrderNum = objvQxPrjMenus_LeafENS.OrderNum; //排序号
objvQxPrjMenus_LeafENT.IsLeafNode = objvQxPrjMenus_LeafENS.IsLeafNode; //是否叶子
objvQxPrjMenus_LeafENT.MenuSetId = objvQxPrjMenus_LeafENS.MenuSetId; //菜单集Id
objvQxPrjMenus_LeafENT.MenuSetName = objvQxPrjMenus_LeafENS.MenuSetName; //菜单集名称
objvQxPrjMenus_LeafENT.MenuTitle = objvQxPrjMenus_LeafENS.MenuTitle; //菜单标题
objvQxPrjMenus_LeafENT.PageDispModeId = objvQxPrjMenus_LeafENS.PageDispModeId; //页面显示模式Id
objvQxPrjMenus_LeafENT.PageDispModeName = objvQxPrjMenus_LeafENS.PageDispModeName; //页面显示模式名称
objvQxPrjMenus_LeafENT.InUse = objvQxPrjMenus_LeafENS.InUse; //是否在用
objvQxPrjMenus_LeafENT.UpdDate = objvQxPrjMenus_LeafENS.UpdDate; //修改日期
objvQxPrjMenus_LeafENT.UpdUserId = objvQxPrjMenus_LeafENS.UpdUserId; //修改用户Id
objvQxPrjMenus_LeafENT.Memo = objvQxPrjMenus_LeafENS.Memo; //备注
objvQxPrjMenus_LeafENT.MenuControlName = objvQxPrjMenus_LeafENS.MenuControlName; //MenuControlName
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
 /// <param name = "objvQxPrjMenus_LeafENS">源对象</param>
 /// <returns>目标对象=>clsvQxPrjMenus_LeafEN:objvQxPrjMenus_LeafENT</returns>
 public static clsvQxPrjMenus_LeafEN CopyTo(this clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafENS)
{
try
{
 clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafENT = new clsvQxPrjMenus_LeafEN()
{
MenuIdLeaf = objvQxPrjMenus_LeafENS.MenuIdLeaf, //MenuId_Leaf
MenuName = objvQxPrjMenus_LeafENS.MenuName, //菜单名
QxPrjId = objvQxPrjMenus_LeafENS.QxPrjId, //项目Id
PrjName = objvQxPrjMenus_LeafENS.PrjName, //工程名
UpMenuId = objvQxPrjMenus_LeafENS.UpMenuId, //上级菜单Id
LinkFile = objvQxPrjMenus_LeafENS.LinkFile, //链接文件
qsParameters = objvQxPrjMenus_LeafENS.qsParameters, //qs参数
ImgFile = objvQxPrjMenus_LeafENS.ImgFile, //图像文件
OrderNum = objvQxPrjMenus_LeafENS.OrderNum, //排序号
IsLeafNode = objvQxPrjMenus_LeafENS.IsLeafNode, //是否叶子
MenuSetId = objvQxPrjMenus_LeafENS.MenuSetId, //菜单集Id
MenuSetName = objvQxPrjMenus_LeafENS.MenuSetName, //菜单集名称
MenuTitle = objvQxPrjMenus_LeafENS.MenuTitle, //菜单标题
PageDispModeId = objvQxPrjMenus_LeafENS.PageDispModeId, //页面显示模式Id
PageDispModeName = objvQxPrjMenus_LeafENS.PageDispModeName, //页面显示模式名称
InUse = objvQxPrjMenus_LeafENS.InUse, //是否在用
UpdDate = objvQxPrjMenus_LeafENS.UpdDate, //修改日期
UpdUserId = objvQxPrjMenus_LeafENS.UpdUserId, //修改用户Id
Memo = objvQxPrjMenus_LeafENS.Memo, //备注
MenuControlName = objvQxPrjMenus_LeafENS.MenuControlName, //MenuControlName
};
 return objvQxPrjMenus_LeafENT;
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
public static void CheckProperty4Condition(this clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN)
{
 clsvQxPrjMenus_LeafBL.vQxPrjMenus_LeafDA.CheckProperty4Condition(objvQxPrjMenus_LeafEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQxPrjMenus_LeafCond.IsUpdated(convQxPrjMenus_Leaf.MenuIdLeaf) == true)
{
string strComparisonOpMenuIdLeaf = objvQxPrjMenus_LeafCond.dicFldComparisonOp[convQxPrjMenus_Leaf.MenuIdLeaf];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus_Leaf.MenuIdLeaf, objvQxPrjMenus_LeafCond.MenuIdLeaf, strComparisonOpMenuIdLeaf);
}
if (objvQxPrjMenus_LeafCond.IsUpdated(convQxPrjMenus_Leaf.MenuName) == true)
{
string strComparisonOpMenuName = objvQxPrjMenus_LeafCond.dicFldComparisonOp[convQxPrjMenus_Leaf.MenuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus_Leaf.MenuName, objvQxPrjMenus_LeafCond.MenuName, strComparisonOpMenuName);
}
if (objvQxPrjMenus_LeafCond.IsUpdated(convQxPrjMenus_Leaf.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objvQxPrjMenus_LeafCond.dicFldComparisonOp[convQxPrjMenus_Leaf.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus_Leaf.QxPrjId, objvQxPrjMenus_LeafCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objvQxPrjMenus_LeafCond.IsUpdated(convQxPrjMenus_Leaf.PrjName) == true)
{
string strComparisonOpPrjName = objvQxPrjMenus_LeafCond.dicFldComparisonOp[convQxPrjMenus_Leaf.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus_Leaf.PrjName, objvQxPrjMenus_LeafCond.PrjName, strComparisonOpPrjName);
}
if (objvQxPrjMenus_LeafCond.IsUpdated(convQxPrjMenus_Leaf.UpMenuId) == true)
{
string strComparisonOpUpMenuId = objvQxPrjMenus_LeafCond.dicFldComparisonOp[convQxPrjMenus_Leaf.UpMenuId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus_Leaf.UpMenuId, objvQxPrjMenus_LeafCond.UpMenuId, strComparisonOpUpMenuId);
}
if (objvQxPrjMenus_LeafCond.IsUpdated(convQxPrjMenus_Leaf.LinkFile) == true)
{
string strComparisonOpLinkFile = objvQxPrjMenus_LeafCond.dicFldComparisonOp[convQxPrjMenus_Leaf.LinkFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus_Leaf.LinkFile, objvQxPrjMenus_LeafCond.LinkFile, strComparisonOpLinkFile);
}
if (objvQxPrjMenus_LeafCond.IsUpdated(convQxPrjMenus_Leaf.qsParameters) == true)
{
string strComparisonOpqsParameters = objvQxPrjMenus_LeafCond.dicFldComparisonOp[convQxPrjMenus_Leaf.qsParameters];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus_Leaf.qsParameters, objvQxPrjMenus_LeafCond.qsParameters, strComparisonOpqsParameters);
}
if (objvQxPrjMenus_LeafCond.IsUpdated(convQxPrjMenus_Leaf.ImgFile) == true)
{
string strComparisonOpImgFile = objvQxPrjMenus_LeafCond.dicFldComparisonOp[convQxPrjMenus_Leaf.ImgFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus_Leaf.ImgFile, objvQxPrjMenus_LeafCond.ImgFile, strComparisonOpImgFile);
}
if (objvQxPrjMenus_LeafCond.IsUpdated(convQxPrjMenus_Leaf.OrderNum) == true)
{
string strComparisonOpOrderNum = objvQxPrjMenus_LeafCond.dicFldComparisonOp[convQxPrjMenus_Leaf.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQxPrjMenus_Leaf.OrderNum, objvQxPrjMenus_LeafCond.OrderNum, strComparisonOpOrderNum);
}
if (objvQxPrjMenus_LeafCond.IsUpdated(convQxPrjMenus_Leaf.IsLeafNode) == true)
{
if (objvQxPrjMenus_LeafCond.IsLeafNode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQxPrjMenus_Leaf.IsLeafNode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQxPrjMenus_Leaf.IsLeafNode);
}
}
if (objvQxPrjMenus_LeafCond.IsUpdated(convQxPrjMenus_Leaf.MenuSetId) == true)
{
string strComparisonOpMenuSetId = objvQxPrjMenus_LeafCond.dicFldComparisonOp[convQxPrjMenus_Leaf.MenuSetId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus_Leaf.MenuSetId, objvQxPrjMenus_LeafCond.MenuSetId, strComparisonOpMenuSetId);
}
if (objvQxPrjMenus_LeafCond.IsUpdated(convQxPrjMenus_Leaf.MenuSetName) == true)
{
string strComparisonOpMenuSetName = objvQxPrjMenus_LeafCond.dicFldComparisonOp[convQxPrjMenus_Leaf.MenuSetName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus_Leaf.MenuSetName, objvQxPrjMenus_LeafCond.MenuSetName, strComparisonOpMenuSetName);
}
if (objvQxPrjMenus_LeafCond.IsUpdated(convQxPrjMenus_Leaf.MenuTitle) == true)
{
string strComparisonOpMenuTitle = objvQxPrjMenus_LeafCond.dicFldComparisonOp[convQxPrjMenus_Leaf.MenuTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus_Leaf.MenuTitle, objvQxPrjMenus_LeafCond.MenuTitle, strComparisonOpMenuTitle);
}
if (objvQxPrjMenus_LeafCond.IsUpdated(convQxPrjMenus_Leaf.PageDispModeId) == true)
{
string strComparisonOpPageDispModeId = objvQxPrjMenus_LeafCond.dicFldComparisonOp[convQxPrjMenus_Leaf.PageDispModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus_Leaf.PageDispModeId, objvQxPrjMenus_LeafCond.PageDispModeId, strComparisonOpPageDispModeId);
}
if (objvQxPrjMenus_LeafCond.IsUpdated(convQxPrjMenus_Leaf.PageDispModeName) == true)
{
string strComparisonOpPageDispModeName = objvQxPrjMenus_LeafCond.dicFldComparisonOp[convQxPrjMenus_Leaf.PageDispModeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus_Leaf.PageDispModeName, objvQxPrjMenus_LeafCond.PageDispModeName, strComparisonOpPageDispModeName);
}
if (objvQxPrjMenus_LeafCond.IsUpdated(convQxPrjMenus_Leaf.InUse) == true)
{
if (objvQxPrjMenus_LeafCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQxPrjMenus_Leaf.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQxPrjMenus_Leaf.InUse);
}
}
if (objvQxPrjMenus_LeafCond.IsUpdated(convQxPrjMenus_Leaf.UpdDate) == true)
{
string strComparisonOpUpdDate = objvQxPrjMenus_LeafCond.dicFldComparisonOp[convQxPrjMenus_Leaf.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus_Leaf.UpdDate, objvQxPrjMenus_LeafCond.UpdDate, strComparisonOpUpdDate);
}
if (objvQxPrjMenus_LeafCond.IsUpdated(convQxPrjMenus_Leaf.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvQxPrjMenus_LeafCond.dicFldComparisonOp[convQxPrjMenus_Leaf.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus_Leaf.UpdUserId, objvQxPrjMenus_LeafCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvQxPrjMenus_LeafCond.IsUpdated(convQxPrjMenus_Leaf.Memo) == true)
{
string strComparisonOpMemo = objvQxPrjMenus_LeafCond.dicFldComparisonOp[convQxPrjMenus_Leaf.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus_Leaf.Memo, objvQxPrjMenus_LeafCond.Memo, strComparisonOpMemo);
}
if (objvQxPrjMenus_LeafCond.IsUpdated(convQxPrjMenus_Leaf.MenuControlName) == true)
{
string strComparisonOpMenuControlName = objvQxPrjMenus_LeafCond.dicFldComparisonOp[convQxPrjMenus_Leaf.MenuControlName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenus_Leaf.MenuControlName, objvQxPrjMenus_LeafCond.MenuControlName, strComparisonOpMenuControlName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vQxPrjMenus_Leaf
{
public virtual bool UpdRelaTabDate(string strMenuIdLeaf, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v三层菜单(vQxPrjMenus_Leaf)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvQxPrjMenus_LeafBL
{
public static RelatedActions_vQxPrjMenus_Leaf relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "vQxPrjMenus_LeafListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "vQxPrjMenus_LeafList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsvQxPrjMenus_LeafEN> arrvQxPrjMenus_LeafObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvQxPrjMenus_LeafDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvQxPrjMenus_LeafDA vQxPrjMenus_LeafDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvQxPrjMenus_LeafDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvQxPrjMenus_LeafBL()
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
if (string.IsNullOrEmpty(clsvQxPrjMenus_LeafEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxPrjMenus_LeafEN._ConnectString);
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
objDS = vQxPrjMenus_LeafDA.GetDataSet(strWhereCond);
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
objDS = vQxPrjMenus_LeafDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = vQxPrjMenus_LeafDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_vQxPrjMenus_Leaf(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQxPrjMenus_LeafDA.GetDataTable_vQxPrjMenus_Leaf(strWhereCond);
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
objDT = vQxPrjMenus_LeafDA.GetDataTable(strWhereCond);
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
objDT = vQxPrjMenus_LeafDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vQxPrjMenus_LeafDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vQxPrjMenus_LeafDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vQxPrjMenus_LeafDA.GetDataTable_Top(objTopPara);
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
objDT = vQxPrjMenus_LeafDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vQxPrjMenus_LeafDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = vQxPrjMenus_LeafDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vQxPrjMenus_LeafDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = vQxPrjMenus_LeafDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = vQxPrjMenus_LeafDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = vQxPrjMenus_LeafDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = vQxPrjMenus_LeafDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
 /// <param name = "arrMenuIdLeafLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvQxPrjMenus_LeafEN> GetObjLstByMenuIdLeafLst(List<string> arrMenuIdLeafLst)
{
List<clsvQxPrjMenus_LeafEN> arrObjLst = new List<clsvQxPrjMenus_LeafEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMenuIdLeafLst, true);
 string strWhereCond = string.Format("MenuIdLeaf in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN = new clsvQxPrjMenus_LeafEN();
try
{
objvQxPrjMenus_LeafEN.MenuIdLeaf = objRow[convQxPrjMenus_Leaf.MenuIdLeaf].ToString().Trim(); //MenuId_Leaf
objvQxPrjMenus_LeafEN.MenuName = objRow[convQxPrjMenus_Leaf.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenus_LeafEN.QxPrjId = objRow[convQxPrjMenus_Leaf.QxPrjId] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenus_LeafEN.PrjName = objRow[convQxPrjMenus_Leaf.PrjName] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.PrjName].ToString().Trim(); //工程名
objvQxPrjMenus_LeafEN.UpMenuId = objRow[convQxPrjMenus_Leaf.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenus_LeafEN.LinkFile = objRow[convQxPrjMenus_Leaf.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenus_LeafEN.qsParameters = objRow[convQxPrjMenus_Leaf.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenus_LeafEN.ImgFile = objRow[convQxPrjMenus_Leaf.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenus_LeafEN.OrderNum = objRow[convQxPrjMenus_Leaf.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus_Leaf.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenus_LeafEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Leaf.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenus_LeafEN.MenuSetId = objRow[convQxPrjMenus_Leaf.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenus_LeafEN.MenuSetName = objRow[convQxPrjMenus_Leaf.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenus_LeafEN.MenuTitle = objRow[convQxPrjMenus_Leaf.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenus_LeafEN.PageDispModeId = objRow[convQxPrjMenus_Leaf.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenus_LeafEN.PageDispModeName = objRow[convQxPrjMenus_Leaf.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenus_LeafEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Leaf.InUse].ToString().Trim()); //是否在用
objvQxPrjMenus_LeafEN.UpdDate = objRow[convQxPrjMenus_Leaf.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenus_LeafEN.UpdUserId = objRow[convQxPrjMenus_Leaf.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenus_LeafEN.Memo = objRow[convQxPrjMenus_Leaf.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.Memo].ToString().Trim(); //备注
objvQxPrjMenus_LeafEN.MenuControlName = objRow[convQxPrjMenus_Leaf.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.MenuControlName].ToString().Trim(); //MenuControlName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenus_LeafEN.MenuIdLeaf, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenus_LeafEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMenuIdLeafLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvQxPrjMenus_LeafEN> GetObjLstByMenuIdLeafLstCache(List<string> arrMenuIdLeafLst)
{
string strKey = string.Format("{0}", clsvQxPrjMenus_LeafEN._CurrTabName);
List<clsvQxPrjMenus_LeafEN> arrvQxPrjMenus_LeafObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjMenus_LeafEN> arrvQxPrjMenus_LeafObjLst_Sel =
arrvQxPrjMenus_LeafObjLstCache
.Where(x => arrMenuIdLeafLst.Contains(x.MenuIdLeaf));
return arrvQxPrjMenus_LeafObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjMenus_LeafEN> GetObjLst(string strWhereCond)
{
List<clsvQxPrjMenus_LeafEN> arrObjLst = new List<clsvQxPrjMenus_LeafEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN = new clsvQxPrjMenus_LeafEN();
try
{
objvQxPrjMenus_LeafEN.MenuIdLeaf = objRow[convQxPrjMenus_Leaf.MenuIdLeaf].ToString().Trim(); //MenuId_Leaf
objvQxPrjMenus_LeafEN.MenuName = objRow[convQxPrjMenus_Leaf.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenus_LeafEN.QxPrjId = objRow[convQxPrjMenus_Leaf.QxPrjId] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenus_LeafEN.PrjName = objRow[convQxPrjMenus_Leaf.PrjName] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.PrjName].ToString().Trim(); //工程名
objvQxPrjMenus_LeafEN.UpMenuId = objRow[convQxPrjMenus_Leaf.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenus_LeafEN.LinkFile = objRow[convQxPrjMenus_Leaf.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenus_LeafEN.qsParameters = objRow[convQxPrjMenus_Leaf.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenus_LeafEN.ImgFile = objRow[convQxPrjMenus_Leaf.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenus_LeafEN.OrderNum = objRow[convQxPrjMenus_Leaf.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus_Leaf.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenus_LeafEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Leaf.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenus_LeafEN.MenuSetId = objRow[convQxPrjMenus_Leaf.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenus_LeafEN.MenuSetName = objRow[convQxPrjMenus_Leaf.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenus_LeafEN.MenuTitle = objRow[convQxPrjMenus_Leaf.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenus_LeafEN.PageDispModeId = objRow[convQxPrjMenus_Leaf.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenus_LeafEN.PageDispModeName = objRow[convQxPrjMenus_Leaf.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenus_LeafEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Leaf.InUse].ToString().Trim()); //是否在用
objvQxPrjMenus_LeafEN.UpdDate = objRow[convQxPrjMenus_Leaf.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenus_LeafEN.UpdUserId = objRow[convQxPrjMenus_Leaf.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenus_LeafEN.Memo = objRow[convQxPrjMenus_Leaf.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.Memo].ToString().Trim(); //备注
objvQxPrjMenus_LeafEN.MenuControlName = objRow[convQxPrjMenus_Leaf.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.MenuControlName].ToString().Trim(); //MenuControlName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenus_LeafEN.MenuIdLeaf, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenus_LeafEN);
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
public static List<clsvQxPrjMenus_LeafEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQxPrjMenus_LeafEN> arrObjLst = new List<clsvQxPrjMenus_LeafEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN = new clsvQxPrjMenus_LeafEN();
try
{
objvQxPrjMenus_LeafEN.MenuIdLeaf = objRow[convQxPrjMenus_Leaf.MenuIdLeaf].ToString().Trim(); //MenuId_Leaf
objvQxPrjMenus_LeafEN.MenuName = objRow[convQxPrjMenus_Leaf.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenus_LeafEN.QxPrjId = objRow[convQxPrjMenus_Leaf.QxPrjId] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenus_LeafEN.PrjName = objRow[convQxPrjMenus_Leaf.PrjName] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.PrjName].ToString().Trim(); //工程名
objvQxPrjMenus_LeafEN.UpMenuId = objRow[convQxPrjMenus_Leaf.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenus_LeafEN.LinkFile = objRow[convQxPrjMenus_Leaf.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenus_LeafEN.qsParameters = objRow[convQxPrjMenus_Leaf.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenus_LeafEN.ImgFile = objRow[convQxPrjMenus_Leaf.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenus_LeafEN.OrderNum = objRow[convQxPrjMenus_Leaf.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus_Leaf.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenus_LeafEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Leaf.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenus_LeafEN.MenuSetId = objRow[convQxPrjMenus_Leaf.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenus_LeafEN.MenuSetName = objRow[convQxPrjMenus_Leaf.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenus_LeafEN.MenuTitle = objRow[convQxPrjMenus_Leaf.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenus_LeafEN.PageDispModeId = objRow[convQxPrjMenus_Leaf.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenus_LeafEN.PageDispModeName = objRow[convQxPrjMenus_Leaf.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenus_LeafEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Leaf.InUse].ToString().Trim()); //是否在用
objvQxPrjMenus_LeafEN.UpdDate = objRow[convQxPrjMenus_Leaf.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenus_LeafEN.UpdUserId = objRow[convQxPrjMenus_Leaf.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenus_LeafEN.Memo = objRow[convQxPrjMenus_Leaf.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.Memo].ToString().Trim(); //备注
objvQxPrjMenus_LeafEN.MenuControlName = objRow[convQxPrjMenus_Leaf.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.MenuControlName].ToString().Trim(); //MenuControlName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenus_LeafEN.MenuIdLeaf, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenus_LeafEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvQxPrjMenus_LeafCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvQxPrjMenus_LeafEN> GetSubObjLstCache(clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafCond)
{
List<clsvQxPrjMenus_LeafEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjMenus_LeafEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxPrjMenus_Leaf.AttributeName)
{
if (objvQxPrjMenus_LeafCond.IsUpdated(strFldName) == false) continue;
if (objvQxPrjMenus_LeafCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjMenus_LeafCond[strFldName].ToString());
}
else
{
if (objvQxPrjMenus_LeafCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxPrjMenus_LeafCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjMenus_LeafCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxPrjMenus_LeafCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxPrjMenus_LeafCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxPrjMenus_LeafCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxPrjMenus_LeafCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxPrjMenus_LeafCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxPrjMenus_LeafCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxPrjMenus_LeafCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxPrjMenus_LeafCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxPrjMenus_LeafCond[strFldName]));
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
public static List<clsvQxPrjMenus_LeafEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvQxPrjMenus_LeafEN> arrObjLst = new List<clsvQxPrjMenus_LeafEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN = new clsvQxPrjMenus_LeafEN();
try
{
objvQxPrjMenus_LeafEN.MenuIdLeaf = objRow[convQxPrjMenus_Leaf.MenuIdLeaf].ToString().Trim(); //MenuId_Leaf
objvQxPrjMenus_LeafEN.MenuName = objRow[convQxPrjMenus_Leaf.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenus_LeafEN.QxPrjId = objRow[convQxPrjMenus_Leaf.QxPrjId] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenus_LeafEN.PrjName = objRow[convQxPrjMenus_Leaf.PrjName] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.PrjName].ToString().Trim(); //工程名
objvQxPrjMenus_LeafEN.UpMenuId = objRow[convQxPrjMenus_Leaf.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenus_LeafEN.LinkFile = objRow[convQxPrjMenus_Leaf.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenus_LeafEN.qsParameters = objRow[convQxPrjMenus_Leaf.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenus_LeafEN.ImgFile = objRow[convQxPrjMenus_Leaf.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenus_LeafEN.OrderNum = objRow[convQxPrjMenus_Leaf.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus_Leaf.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenus_LeafEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Leaf.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenus_LeafEN.MenuSetId = objRow[convQxPrjMenus_Leaf.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenus_LeafEN.MenuSetName = objRow[convQxPrjMenus_Leaf.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenus_LeafEN.MenuTitle = objRow[convQxPrjMenus_Leaf.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenus_LeafEN.PageDispModeId = objRow[convQxPrjMenus_Leaf.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenus_LeafEN.PageDispModeName = objRow[convQxPrjMenus_Leaf.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenus_LeafEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Leaf.InUse].ToString().Trim()); //是否在用
objvQxPrjMenus_LeafEN.UpdDate = objRow[convQxPrjMenus_Leaf.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenus_LeafEN.UpdUserId = objRow[convQxPrjMenus_Leaf.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenus_LeafEN.Memo = objRow[convQxPrjMenus_Leaf.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.Memo].ToString().Trim(); //备注
objvQxPrjMenus_LeafEN.MenuControlName = objRow[convQxPrjMenus_Leaf.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.MenuControlName].ToString().Trim(); //MenuControlName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenus_LeafEN.MenuIdLeaf, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenus_LeafEN);
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
public static List<clsvQxPrjMenus_LeafEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvQxPrjMenus_LeafEN> arrObjLst = new List<clsvQxPrjMenus_LeafEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN = new clsvQxPrjMenus_LeafEN();
try
{
objvQxPrjMenus_LeafEN.MenuIdLeaf = objRow[convQxPrjMenus_Leaf.MenuIdLeaf].ToString().Trim(); //MenuId_Leaf
objvQxPrjMenus_LeafEN.MenuName = objRow[convQxPrjMenus_Leaf.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenus_LeafEN.QxPrjId = objRow[convQxPrjMenus_Leaf.QxPrjId] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenus_LeafEN.PrjName = objRow[convQxPrjMenus_Leaf.PrjName] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.PrjName].ToString().Trim(); //工程名
objvQxPrjMenus_LeafEN.UpMenuId = objRow[convQxPrjMenus_Leaf.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenus_LeafEN.LinkFile = objRow[convQxPrjMenus_Leaf.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenus_LeafEN.qsParameters = objRow[convQxPrjMenus_Leaf.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenus_LeafEN.ImgFile = objRow[convQxPrjMenus_Leaf.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenus_LeafEN.OrderNum = objRow[convQxPrjMenus_Leaf.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus_Leaf.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenus_LeafEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Leaf.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenus_LeafEN.MenuSetId = objRow[convQxPrjMenus_Leaf.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenus_LeafEN.MenuSetName = objRow[convQxPrjMenus_Leaf.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenus_LeafEN.MenuTitle = objRow[convQxPrjMenus_Leaf.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenus_LeafEN.PageDispModeId = objRow[convQxPrjMenus_Leaf.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenus_LeafEN.PageDispModeName = objRow[convQxPrjMenus_Leaf.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenus_LeafEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Leaf.InUse].ToString().Trim()); //是否在用
objvQxPrjMenus_LeafEN.UpdDate = objRow[convQxPrjMenus_Leaf.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenus_LeafEN.UpdUserId = objRow[convQxPrjMenus_Leaf.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenus_LeafEN.Memo = objRow[convQxPrjMenus_Leaf.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.Memo].ToString().Trim(); //备注
objvQxPrjMenus_LeafEN.MenuControlName = objRow[convQxPrjMenus_Leaf.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.MenuControlName].ToString().Trim(); //MenuControlName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenus_LeafEN.MenuIdLeaf, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenus_LeafEN);
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
List<clsvQxPrjMenus_LeafEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvQxPrjMenus_LeafEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjMenus_LeafEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvQxPrjMenus_LeafEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvQxPrjMenus_LeafEN> arrObjLst = new List<clsvQxPrjMenus_LeafEN>(); 
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
	clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN = new clsvQxPrjMenus_LeafEN();
try
{
objvQxPrjMenus_LeafEN.MenuIdLeaf = objRow[convQxPrjMenus_Leaf.MenuIdLeaf].ToString().Trim(); //MenuId_Leaf
objvQxPrjMenus_LeafEN.MenuName = objRow[convQxPrjMenus_Leaf.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenus_LeafEN.QxPrjId = objRow[convQxPrjMenus_Leaf.QxPrjId] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenus_LeafEN.PrjName = objRow[convQxPrjMenus_Leaf.PrjName] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.PrjName].ToString().Trim(); //工程名
objvQxPrjMenus_LeafEN.UpMenuId = objRow[convQxPrjMenus_Leaf.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenus_LeafEN.LinkFile = objRow[convQxPrjMenus_Leaf.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenus_LeafEN.qsParameters = objRow[convQxPrjMenus_Leaf.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenus_LeafEN.ImgFile = objRow[convQxPrjMenus_Leaf.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenus_LeafEN.OrderNum = objRow[convQxPrjMenus_Leaf.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus_Leaf.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenus_LeafEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Leaf.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenus_LeafEN.MenuSetId = objRow[convQxPrjMenus_Leaf.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenus_LeafEN.MenuSetName = objRow[convQxPrjMenus_Leaf.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenus_LeafEN.MenuTitle = objRow[convQxPrjMenus_Leaf.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenus_LeafEN.PageDispModeId = objRow[convQxPrjMenus_Leaf.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenus_LeafEN.PageDispModeName = objRow[convQxPrjMenus_Leaf.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenus_LeafEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Leaf.InUse].ToString().Trim()); //是否在用
objvQxPrjMenus_LeafEN.UpdDate = objRow[convQxPrjMenus_Leaf.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenus_LeafEN.UpdUserId = objRow[convQxPrjMenus_Leaf.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenus_LeafEN.Memo = objRow[convQxPrjMenus_Leaf.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.Memo].ToString().Trim(); //备注
objvQxPrjMenus_LeafEN.MenuControlName = objRow[convQxPrjMenus_Leaf.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.MenuControlName].ToString().Trim(); //MenuControlName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenus_LeafEN.MenuIdLeaf, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenus_LeafEN);
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
public static List<clsvQxPrjMenus_LeafEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvQxPrjMenus_LeafEN> arrObjLst = new List<clsvQxPrjMenus_LeafEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN = new clsvQxPrjMenus_LeafEN();
try
{
objvQxPrjMenus_LeafEN.MenuIdLeaf = objRow[convQxPrjMenus_Leaf.MenuIdLeaf].ToString().Trim(); //MenuId_Leaf
objvQxPrjMenus_LeafEN.MenuName = objRow[convQxPrjMenus_Leaf.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenus_LeafEN.QxPrjId = objRow[convQxPrjMenus_Leaf.QxPrjId] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenus_LeafEN.PrjName = objRow[convQxPrjMenus_Leaf.PrjName] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.PrjName].ToString().Trim(); //工程名
objvQxPrjMenus_LeafEN.UpMenuId = objRow[convQxPrjMenus_Leaf.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenus_LeafEN.LinkFile = objRow[convQxPrjMenus_Leaf.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenus_LeafEN.qsParameters = objRow[convQxPrjMenus_Leaf.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenus_LeafEN.ImgFile = objRow[convQxPrjMenus_Leaf.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenus_LeafEN.OrderNum = objRow[convQxPrjMenus_Leaf.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus_Leaf.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenus_LeafEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Leaf.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenus_LeafEN.MenuSetId = objRow[convQxPrjMenus_Leaf.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenus_LeafEN.MenuSetName = objRow[convQxPrjMenus_Leaf.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenus_LeafEN.MenuTitle = objRow[convQxPrjMenus_Leaf.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenus_LeafEN.PageDispModeId = objRow[convQxPrjMenus_Leaf.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenus_LeafEN.PageDispModeName = objRow[convQxPrjMenus_Leaf.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenus_LeafEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Leaf.InUse].ToString().Trim()); //是否在用
objvQxPrjMenus_LeafEN.UpdDate = objRow[convQxPrjMenus_Leaf.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenus_LeafEN.UpdUserId = objRow[convQxPrjMenus_Leaf.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenus_LeafEN.Memo = objRow[convQxPrjMenus_Leaf.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.Memo].ToString().Trim(); //备注
objvQxPrjMenus_LeafEN.MenuControlName = objRow[convQxPrjMenus_Leaf.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.MenuControlName].ToString().Trim(); //MenuControlName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenus_LeafEN.MenuIdLeaf, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenus_LeafEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQxPrjMenus_LeafEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvQxPrjMenus_LeafEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvQxPrjMenus_LeafEN> arrObjLst = new List<clsvQxPrjMenus_LeafEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN = new clsvQxPrjMenus_LeafEN();
try
{
objvQxPrjMenus_LeafEN.MenuIdLeaf = objRow[convQxPrjMenus_Leaf.MenuIdLeaf].ToString().Trim(); //MenuId_Leaf
objvQxPrjMenus_LeafEN.MenuName = objRow[convQxPrjMenus_Leaf.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenus_LeafEN.QxPrjId = objRow[convQxPrjMenus_Leaf.QxPrjId] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenus_LeafEN.PrjName = objRow[convQxPrjMenus_Leaf.PrjName] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.PrjName].ToString().Trim(); //工程名
objvQxPrjMenus_LeafEN.UpMenuId = objRow[convQxPrjMenus_Leaf.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenus_LeafEN.LinkFile = objRow[convQxPrjMenus_Leaf.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenus_LeafEN.qsParameters = objRow[convQxPrjMenus_Leaf.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenus_LeafEN.ImgFile = objRow[convQxPrjMenus_Leaf.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenus_LeafEN.OrderNum = objRow[convQxPrjMenus_Leaf.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus_Leaf.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenus_LeafEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Leaf.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenus_LeafEN.MenuSetId = objRow[convQxPrjMenus_Leaf.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenus_LeafEN.MenuSetName = objRow[convQxPrjMenus_Leaf.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenus_LeafEN.MenuTitle = objRow[convQxPrjMenus_Leaf.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenus_LeafEN.PageDispModeId = objRow[convQxPrjMenus_Leaf.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenus_LeafEN.PageDispModeName = objRow[convQxPrjMenus_Leaf.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenus_LeafEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Leaf.InUse].ToString().Trim()); //是否在用
objvQxPrjMenus_LeafEN.UpdDate = objRow[convQxPrjMenus_Leaf.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenus_LeafEN.UpdUserId = objRow[convQxPrjMenus_Leaf.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenus_LeafEN.Memo = objRow[convQxPrjMenus_Leaf.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.Memo].ToString().Trim(); //备注
objvQxPrjMenus_LeafEN.MenuControlName = objRow[convQxPrjMenus_Leaf.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.MenuControlName].ToString().Trim(); //MenuControlName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenus_LeafEN.MenuIdLeaf, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenus_LeafEN);
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
public static List<clsvQxPrjMenus_LeafEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvQxPrjMenus_LeafEN> arrObjLst = new List<clsvQxPrjMenus_LeafEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN = new clsvQxPrjMenus_LeafEN();
try
{
objvQxPrjMenus_LeafEN.MenuIdLeaf = objRow[convQxPrjMenus_Leaf.MenuIdLeaf].ToString().Trim(); //MenuId_Leaf
objvQxPrjMenus_LeafEN.MenuName = objRow[convQxPrjMenus_Leaf.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenus_LeafEN.QxPrjId = objRow[convQxPrjMenus_Leaf.QxPrjId] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenus_LeafEN.PrjName = objRow[convQxPrjMenus_Leaf.PrjName] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.PrjName].ToString().Trim(); //工程名
objvQxPrjMenus_LeafEN.UpMenuId = objRow[convQxPrjMenus_Leaf.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenus_LeafEN.LinkFile = objRow[convQxPrjMenus_Leaf.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenus_LeafEN.qsParameters = objRow[convQxPrjMenus_Leaf.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenus_LeafEN.ImgFile = objRow[convQxPrjMenus_Leaf.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenus_LeafEN.OrderNum = objRow[convQxPrjMenus_Leaf.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus_Leaf.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenus_LeafEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Leaf.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenus_LeafEN.MenuSetId = objRow[convQxPrjMenus_Leaf.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenus_LeafEN.MenuSetName = objRow[convQxPrjMenus_Leaf.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenus_LeafEN.MenuTitle = objRow[convQxPrjMenus_Leaf.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenus_LeafEN.PageDispModeId = objRow[convQxPrjMenus_Leaf.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenus_LeafEN.PageDispModeName = objRow[convQxPrjMenus_Leaf.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenus_LeafEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Leaf.InUse].ToString().Trim()); //是否在用
objvQxPrjMenus_LeafEN.UpdDate = objRow[convQxPrjMenus_Leaf.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenus_LeafEN.UpdUserId = objRow[convQxPrjMenus_Leaf.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenus_LeafEN.Memo = objRow[convQxPrjMenus_Leaf.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.Memo].ToString().Trim(); //备注
objvQxPrjMenus_LeafEN.MenuControlName = objRow[convQxPrjMenus_Leaf.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.MenuControlName].ToString().Trim(); //MenuControlName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenus_LeafEN.MenuIdLeaf, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenus_LeafEN);
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
public static IEnumerable<clsvQxPrjMenus_LeafEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafCond, string strOrderBy)
{
List<clsvQxPrjMenus_LeafEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjMenus_LeafEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxPrjMenus_Leaf.AttributeName)
{
if (objvQxPrjMenus_LeafCond.IsUpdated(strFldName) == false) continue;
if (objvQxPrjMenus_LeafCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjMenus_LeafCond[strFldName].ToString());
}
else
{
if (objvQxPrjMenus_LeafCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxPrjMenus_LeafCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjMenus_LeafCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxPrjMenus_LeafCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxPrjMenus_LeafCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxPrjMenus_LeafCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxPrjMenus_LeafCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxPrjMenus_LeafCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxPrjMenus_LeafCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxPrjMenus_LeafCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxPrjMenus_LeafCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxPrjMenus_LeafCond[strFldName]));
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
public static IEnumerable<clsvQxPrjMenus_LeafEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafCond = JsonConvert.DeserializeObject<clsvQxPrjMenus_LeafEN>(objPagerPara.whereCond);
if (objvQxPrjMenus_LeafCond.sfFldComparisonOp == null)
{
objvQxPrjMenus_LeafCond.dicFldComparisonOp = null;
}
else
{
objvQxPrjMenus_LeafCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objvQxPrjMenus_LeafCond.sfFldComparisonOp);
}
clsvQxPrjMenus_LeafBL.SetUpdFlag(objvQxPrjMenus_LeafCond);
 try
{
CheckProperty4Condition(objvQxPrjMenus_LeafCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsvQxPrjMenus_LeafBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objvQxPrjMenus_LeafCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjMenus_LeafEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsvQxPrjMenus_LeafEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxPrjMenus_LeafEN> arrObjLst = new List<clsvQxPrjMenus_LeafEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN = new clsvQxPrjMenus_LeafEN();
try
{
objvQxPrjMenus_LeafEN.MenuIdLeaf = objRow[convQxPrjMenus_Leaf.MenuIdLeaf].ToString().Trim(); //MenuId_Leaf
objvQxPrjMenus_LeafEN.MenuName = objRow[convQxPrjMenus_Leaf.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenus_LeafEN.QxPrjId = objRow[convQxPrjMenus_Leaf.QxPrjId] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenus_LeafEN.PrjName = objRow[convQxPrjMenus_Leaf.PrjName] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.PrjName].ToString().Trim(); //工程名
objvQxPrjMenus_LeafEN.UpMenuId = objRow[convQxPrjMenus_Leaf.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenus_LeafEN.LinkFile = objRow[convQxPrjMenus_Leaf.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenus_LeafEN.qsParameters = objRow[convQxPrjMenus_Leaf.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenus_LeafEN.ImgFile = objRow[convQxPrjMenus_Leaf.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenus_LeafEN.OrderNum = objRow[convQxPrjMenus_Leaf.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus_Leaf.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenus_LeafEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Leaf.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenus_LeafEN.MenuSetId = objRow[convQxPrjMenus_Leaf.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenus_LeafEN.MenuSetName = objRow[convQxPrjMenus_Leaf.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenus_LeafEN.MenuTitle = objRow[convQxPrjMenus_Leaf.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenus_LeafEN.PageDispModeId = objRow[convQxPrjMenus_Leaf.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenus_LeafEN.PageDispModeName = objRow[convQxPrjMenus_Leaf.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenus_LeafEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Leaf.InUse].ToString().Trim()); //是否在用
objvQxPrjMenus_LeafEN.UpdDate = objRow[convQxPrjMenus_Leaf.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenus_LeafEN.UpdUserId = objRow[convQxPrjMenus_Leaf.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenus_LeafEN.Memo = objRow[convQxPrjMenus_Leaf.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.Memo].ToString().Trim(); //备注
objvQxPrjMenus_LeafEN.MenuControlName = objRow[convQxPrjMenus_Leaf.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.MenuControlName].ToString().Trim(); //MenuControlName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenus_LeafEN.MenuIdLeaf, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenus_LeafEN);
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
public static List<clsvQxPrjMenus_LeafEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxPrjMenus_LeafEN> arrObjLst = new List<clsvQxPrjMenus_LeafEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN = new clsvQxPrjMenus_LeafEN();
try
{
objvQxPrjMenus_LeafEN.MenuIdLeaf = objRow[convQxPrjMenus_Leaf.MenuIdLeaf].ToString().Trim(); //MenuId_Leaf
objvQxPrjMenus_LeafEN.MenuName = objRow[convQxPrjMenus_Leaf.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenus_LeafEN.QxPrjId = objRow[convQxPrjMenus_Leaf.QxPrjId] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenus_LeafEN.PrjName = objRow[convQxPrjMenus_Leaf.PrjName] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.PrjName].ToString().Trim(); //工程名
objvQxPrjMenus_LeafEN.UpMenuId = objRow[convQxPrjMenus_Leaf.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenus_LeafEN.LinkFile = objRow[convQxPrjMenus_Leaf.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenus_LeafEN.qsParameters = objRow[convQxPrjMenus_Leaf.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenus_LeafEN.ImgFile = objRow[convQxPrjMenus_Leaf.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenus_LeafEN.OrderNum = objRow[convQxPrjMenus_Leaf.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus_Leaf.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenus_LeafEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Leaf.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenus_LeafEN.MenuSetId = objRow[convQxPrjMenus_Leaf.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenus_LeafEN.MenuSetName = objRow[convQxPrjMenus_Leaf.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenus_LeafEN.MenuTitle = objRow[convQxPrjMenus_Leaf.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenus_LeafEN.PageDispModeId = objRow[convQxPrjMenus_Leaf.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenus_LeafEN.PageDispModeName = objRow[convQxPrjMenus_Leaf.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenus_LeafEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Leaf.InUse].ToString().Trim()); //是否在用
objvQxPrjMenus_LeafEN.UpdDate = objRow[convQxPrjMenus_Leaf.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenus_LeafEN.UpdUserId = objRow[convQxPrjMenus_Leaf.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenus_LeafEN.Memo = objRow[convQxPrjMenus_Leaf.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.Memo].ToString().Trim(); //备注
objvQxPrjMenus_LeafEN.MenuControlName = objRow[convQxPrjMenus_Leaf.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.MenuControlName].ToString().Trim(); //MenuControlName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenus_LeafEN.MenuIdLeaf, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenus_LeafEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjMenus_LeafEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvQxPrjMenus_LeafEN> arrObjLst = new List<clsvQxPrjMenus_LeafEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN = new clsvQxPrjMenus_LeafEN();
try
{
objvQxPrjMenus_LeafEN.MenuIdLeaf = objRow[convQxPrjMenus_Leaf.MenuIdLeaf].ToString().Trim(); //MenuId_Leaf
objvQxPrjMenus_LeafEN.MenuName = objRow[convQxPrjMenus_Leaf.MenuName].ToString().Trim(); //菜单名
objvQxPrjMenus_LeafEN.QxPrjId = objRow[convQxPrjMenus_Leaf.QxPrjId] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenus_LeafEN.PrjName = objRow[convQxPrjMenus_Leaf.PrjName] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.PrjName].ToString().Trim(); //工程名
objvQxPrjMenus_LeafEN.UpMenuId = objRow[convQxPrjMenus_Leaf.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjMenus_LeafEN.LinkFile = objRow[convQxPrjMenus_Leaf.LinkFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.LinkFile].ToString().Trim(); //链接文件
objvQxPrjMenus_LeafEN.qsParameters = objRow[convQxPrjMenus_Leaf.qsParameters] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.qsParameters].ToString().Trim(); //qs参数
objvQxPrjMenus_LeafEN.ImgFile = objRow[convQxPrjMenus_Leaf.ImgFile] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.ImgFile].ToString().Trim(); //图像文件
objvQxPrjMenus_LeafEN.OrderNum = objRow[convQxPrjMenus_Leaf.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjMenus_Leaf.OrderNum].ToString().Trim()); //排序号
objvQxPrjMenus_LeafEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Leaf.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjMenus_LeafEN.MenuSetId = objRow[convQxPrjMenus_Leaf.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenus_LeafEN.MenuSetName = objRow[convQxPrjMenus_Leaf.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenus_LeafEN.MenuTitle = objRow[convQxPrjMenus_Leaf.MenuTitle] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.MenuTitle].ToString().Trim(); //菜单标题
objvQxPrjMenus_LeafEN.PageDispModeId = objRow[convQxPrjMenus_Leaf.PageDispModeId] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvQxPrjMenus_LeafEN.PageDispModeName = objRow[convQxPrjMenus_Leaf.PageDispModeName] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvQxPrjMenus_LeafEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenus_Leaf.InUse].ToString().Trim()); //是否在用
objvQxPrjMenus_LeafEN.UpdDate = objRow[convQxPrjMenus_Leaf.UpdDate] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.UpdDate].ToString().Trim(); //修改日期
objvQxPrjMenus_LeafEN.UpdUserId = objRow[convQxPrjMenus_Leaf.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjMenus_LeafEN.Memo = objRow[convQxPrjMenus_Leaf.Memo] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.Memo].ToString().Trim(); //备注
objvQxPrjMenus_LeafEN.MenuControlName = objRow[convQxPrjMenus_Leaf.MenuControlName] == DBNull.Value ? null : objRow[convQxPrjMenus_Leaf.MenuControlName].ToString().Trim(); //MenuControlName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenus_LeafEN.MenuIdLeaf, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenus_LeafEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvQxPrjMenus_LeafEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxPrjMenus_Leaf(ref clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN)
{
bool bolResult = vQxPrjMenus_LeafDA.GetvQxPrjMenus_Leaf(ref objvQxPrjMenus_LeafEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strMenuIdLeaf">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxPrjMenus_LeafEN GetObjByMenuIdLeaf(string strMenuIdLeaf)
{
if (strMenuIdLeaf.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strMenuIdLeaf]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strMenuIdLeaf) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strMenuIdLeaf]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN = vQxPrjMenus_LeafDA.GetObjByMenuIdLeaf(strMenuIdLeaf);
return objvQxPrjMenus_LeafEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvQxPrjMenus_LeafEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN = vQxPrjMenus_LeafDA.GetFirstObj(strWhereCond);
 return objvQxPrjMenus_LeafEN;
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
public static clsvQxPrjMenus_LeafEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN = vQxPrjMenus_LeafDA.GetObjByDataRow(objRow);
 return objvQxPrjMenus_LeafEN;
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
public static clsvQxPrjMenus_LeafEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN = vQxPrjMenus_LeafDA.GetObjByDataRow(objRow);
 return objvQxPrjMenus_LeafEN;
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
 /// <param name = "strMenuIdLeaf">所给的关键字</param>
 /// <param name = "lstvQxPrjMenus_LeafObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxPrjMenus_LeafEN GetObjByMenuIdLeafFromList(string strMenuIdLeaf, List<clsvQxPrjMenus_LeafEN> lstvQxPrjMenus_LeafObjLst)
{
foreach (clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN in lstvQxPrjMenus_LeafObjLst)
{
if (objvQxPrjMenus_LeafEN.MenuIdLeaf == strMenuIdLeaf)
{
return objvQxPrjMenus_LeafEN;
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
 string strMenuIdLeaf;
 try
 {
 strMenuIdLeaf = new clsvQxPrjMenus_LeafDA().GetFirstID(strWhereCond);
 return strMenuIdLeaf;
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
 arrList = vQxPrjMenus_LeafDA.GetID(strWhereCond);
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
bool bolIsExist = vQxPrjMenus_LeafDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strMenuIdLeaf">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strMenuIdLeaf)
{
if (string.IsNullOrEmpty(strMenuIdLeaf) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strMenuIdLeaf]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vQxPrjMenus_LeafDA.IsExist(strMenuIdLeaf);
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
 bolIsExist = clsvQxPrjMenus_LeafDA.IsExistTable();
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
 bolIsExist = vQxPrjMenus_LeafDA.IsExistTable(strTabName);
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
 /// <param name = "objvQxPrjMenus_LeafENS">源对象</param>
 /// <param name = "objvQxPrjMenus_LeafENT">目标对象</param>
 public static void CopyTo(clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafENS, clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafENT)
{
try
{
objvQxPrjMenus_LeafENT.MenuIdLeaf = objvQxPrjMenus_LeafENS.MenuIdLeaf; //MenuId_Leaf
objvQxPrjMenus_LeafENT.MenuName = objvQxPrjMenus_LeafENS.MenuName; //菜单名
objvQxPrjMenus_LeafENT.QxPrjId = objvQxPrjMenus_LeafENS.QxPrjId; //项目Id
objvQxPrjMenus_LeafENT.PrjName = objvQxPrjMenus_LeafENS.PrjName; //工程名
objvQxPrjMenus_LeafENT.UpMenuId = objvQxPrjMenus_LeafENS.UpMenuId; //上级菜单Id
objvQxPrjMenus_LeafENT.LinkFile = objvQxPrjMenus_LeafENS.LinkFile; //链接文件
objvQxPrjMenus_LeafENT.qsParameters = objvQxPrjMenus_LeafENS.qsParameters; //qs参数
objvQxPrjMenus_LeafENT.ImgFile = objvQxPrjMenus_LeafENS.ImgFile; //图像文件
objvQxPrjMenus_LeafENT.OrderNum = objvQxPrjMenus_LeafENS.OrderNum; //排序号
objvQxPrjMenus_LeafENT.IsLeafNode = objvQxPrjMenus_LeafENS.IsLeafNode; //是否叶子
objvQxPrjMenus_LeafENT.MenuSetId = objvQxPrjMenus_LeafENS.MenuSetId; //菜单集Id
objvQxPrjMenus_LeafENT.MenuSetName = objvQxPrjMenus_LeafENS.MenuSetName; //菜单集名称
objvQxPrjMenus_LeafENT.MenuTitle = objvQxPrjMenus_LeafENS.MenuTitle; //菜单标题
objvQxPrjMenus_LeafENT.PageDispModeId = objvQxPrjMenus_LeafENS.PageDispModeId; //页面显示模式Id
objvQxPrjMenus_LeafENT.PageDispModeName = objvQxPrjMenus_LeafENS.PageDispModeName; //页面显示模式名称
objvQxPrjMenus_LeafENT.InUse = objvQxPrjMenus_LeafENS.InUse; //是否在用
objvQxPrjMenus_LeafENT.UpdDate = objvQxPrjMenus_LeafENS.UpdDate; //修改日期
objvQxPrjMenus_LeafENT.UpdUserId = objvQxPrjMenus_LeafENS.UpdUserId; //修改用户Id
objvQxPrjMenus_LeafENT.Memo = objvQxPrjMenus_LeafENS.Memo; //备注
objvQxPrjMenus_LeafENT.MenuControlName = objvQxPrjMenus_LeafENS.MenuControlName; //MenuControlName
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
 /// <param name = "objvQxPrjMenus_LeafEN">源简化对象</param>
 public static void SetUpdFlag(clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN)
{
try
{
objvQxPrjMenus_LeafEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvQxPrjMenus_LeafEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convQxPrjMenus_Leaf.MenuIdLeaf, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_LeafEN.MenuIdLeaf = objvQxPrjMenus_LeafEN.MenuIdLeaf; //MenuId_Leaf
}
if (arrFldSet.Contains(convQxPrjMenus_Leaf.MenuName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_LeafEN.MenuName = objvQxPrjMenus_LeafEN.MenuName; //菜单名
}
if (arrFldSet.Contains(convQxPrjMenus_Leaf.QxPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_LeafEN.QxPrjId = objvQxPrjMenus_LeafEN.QxPrjId == "[null]" ? null :  objvQxPrjMenus_LeafEN.QxPrjId; //项目Id
}
if (arrFldSet.Contains(convQxPrjMenus_Leaf.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_LeafEN.PrjName = objvQxPrjMenus_LeafEN.PrjName == "[null]" ? null :  objvQxPrjMenus_LeafEN.PrjName; //工程名
}
if (arrFldSet.Contains(convQxPrjMenus_Leaf.UpMenuId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_LeafEN.UpMenuId = objvQxPrjMenus_LeafEN.UpMenuId == "[null]" ? null :  objvQxPrjMenus_LeafEN.UpMenuId; //上级菜单Id
}
if (arrFldSet.Contains(convQxPrjMenus_Leaf.LinkFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_LeafEN.LinkFile = objvQxPrjMenus_LeafEN.LinkFile == "[null]" ? null :  objvQxPrjMenus_LeafEN.LinkFile; //链接文件
}
if (arrFldSet.Contains(convQxPrjMenus_Leaf.qsParameters, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_LeafEN.qsParameters = objvQxPrjMenus_LeafEN.qsParameters == "[null]" ? null :  objvQxPrjMenus_LeafEN.qsParameters; //qs参数
}
if (arrFldSet.Contains(convQxPrjMenus_Leaf.ImgFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_LeafEN.ImgFile = objvQxPrjMenus_LeafEN.ImgFile == "[null]" ? null :  objvQxPrjMenus_LeafEN.ImgFile; //图像文件
}
if (arrFldSet.Contains(convQxPrjMenus_Leaf.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_LeafEN.OrderNum = objvQxPrjMenus_LeafEN.OrderNum; //排序号
}
if (arrFldSet.Contains(convQxPrjMenus_Leaf.IsLeafNode, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_LeafEN.IsLeafNode = objvQxPrjMenus_LeafEN.IsLeafNode; //是否叶子
}
if (arrFldSet.Contains(convQxPrjMenus_Leaf.MenuSetId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_LeafEN.MenuSetId = objvQxPrjMenus_LeafEN.MenuSetId; //菜单集Id
}
if (arrFldSet.Contains(convQxPrjMenus_Leaf.MenuSetName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_LeafEN.MenuSetName = objvQxPrjMenus_LeafEN.MenuSetName == "[null]" ? null :  objvQxPrjMenus_LeafEN.MenuSetName; //菜单集名称
}
if (arrFldSet.Contains(convQxPrjMenus_Leaf.MenuTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_LeafEN.MenuTitle = objvQxPrjMenus_LeafEN.MenuTitle == "[null]" ? null :  objvQxPrjMenus_LeafEN.MenuTitle; //菜单标题
}
if (arrFldSet.Contains(convQxPrjMenus_Leaf.PageDispModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_LeafEN.PageDispModeId = objvQxPrjMenus_LeafEN.PageDispModeId == "[null]" ? null :  objvQxPrjMenus_LeafEN.PageDispModeId; //页面显示模式Id
}
if (arrFldSet.Contains(convQxPrjMenus_Leaf.PageDispModeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_LeafEN.PageDispModeName = objvQxPrjMenus_LeafEN.PageDispModeName == "[null]" ? null :  objvQxPrjMenus_LeafEN.PageDispModeName; //页面显示模式名称
}
if (arrFldSet.Contains(convQxPrjMenus_Leaf.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_LeafEN.InUse = objvQxPrjMenus_LeafEN.InUse; //是否在用
}
if (arrFldSet.Contains(convQxPrjMenus_Leaf.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_LeafEN.UpdDate = objvQxPrjMenus_LeafEN.UpdDate == "[null]" ? null :  objvQxPrjMenus_LeafEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convQxPrjMenus_Leaf.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_LeafEN.UpdUserId = objvQxPrjMenus_LeafEN.UpdUserId == "[null]" ? null :  objvQxPrjMenus_LeafEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convQxPrjMenus_Leaf.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_LeafEN.Memo = objvQxPrjMenus_LeafEN.Memo == "[null]" ? null :  objvQxPrjMenus_LeafEN.Memo; //备注
}
if (arrFldSet.Contains(convQxPrjMenus_Leaf.MenuControlName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenus_LeafEN.MenuControlName = objvQxPrjMenus_LeafEN.MenuControlName == "[null]" ? null :  objvQxPrjMenus_LeafEN.MenuControlName; //MenuControlName
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
 /// <param name = "objvQxPrjMenus_LeafEN">源简化对象</param>
 public static void AccessFldValueNull(clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN)
{
try
{
if (objvQxPrjMenus_LeafEN.QxPrjId == "[null]") objvQxPrjMenus_LeafEN.QxPrjId = null; //项目Id
if (objvQxPrjMenus_LeafEN.PrjName == "[null]") objvQxPrjMenus_LeafEN.PrjName = null; //工程名
if (objvQxPrjMenus_LeafEN.UpMenuId == "[null]") objvQxPrjMenus_LeafEN.UpMenuId = null; //上级菜单Id
if (objvQxPrjMenus_LeafEN.LinkFile == "[null]") objvQxPrjMenus_LeafEN.LinkFile = null; //链接文件
if (objvQxPrjMenus_LeafEN.qsParameters == "[null]") objvQxPrjMenus_LeafEN.qsParameters = null; //qs参数
if (objvQxPrjMenus_LeafEN.ImgFile == "[null]") objvQxPrjMenus_LeafEN.ImgFile = null; //图像文件
if (objvQxPrjMenus_LeafEN.MenuSetName == "[null]") objvQxPrjMenus_LeafEN.MenuSetName = null; //菜单集名称
if (objvQxPrjMenus_LeafEN.MenuTitle == "[null]") objvQxPrjMenus_LeafEN.MenuTitle = null; //菜单标题
if (objvQxPrjMenus_LeafEN.PageDispModeId == "[null]") objvQxPrjMenus_LeafEN.PageDispModeId = null; //页面显示模式Id
if (objvQxPrjMenus_LeafEN.PageDispModeName == "[null]") objvQxPrjMenus_LeafEN.PageDispModeName = null; //页面显示模式名称
if (objvQxPrjMenus_LeafEN.UpdDate == "[null]") objvQxPrjMenus_LeafEN.UpdDate = null; //修改日期
if (objvQxPrjMenus_LeafEN.UpdUserId == "[null]") objvQxPrjMenus_LeafEN.UpdUserId = null; //修改用户Id
if (objvQxPrjMenus_LeafEN.Memo == "[null]") objvQxPrjMenus_LeafEN.Memo = null; //备注
if (objvQxPrjMenus_LeafEN.MenuControlName == "[null]") objvQxPrjMenus_LeafEN.MenuControlName = null; //MenuControlName
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
public static void CheckProperty4Condition(clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN)
{
 vQxPrjMenus_LeafDA.CheckProperty4Condition(objvQxPrjMenus_LeafEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_MenuIdLeaf(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convQxPrjMenus_Leaf.MenuIdLeaf); 
List<clsvQxPrjMenus_LeafEN> arrObjLst = clsvQxPrjMenus_LeafBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN = new clsvQxPrjMenus_LeafEN()
{
MenuIdLeaf = "0",
MenuName = "选[v三层菜单]..."
};
arrObjLst.Insert(0, objvQxPrjMenus_LeafEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convQxPrjMenus_Leaf.MenuIdLeaf;
objComboBox.DisplayMember = convQxPrjMenus_Leaf.MenuName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_MenuIdLeaf(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v三层菜单]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convQxPrjMenus_Leaf.MenuIdLeaf); 
IEnumerable<clsvQxPrjMenus_LeafEN> arrObjLst = clsvQxPrjMenus_LeafBL.GetObjLst(strCondition);
objDDL.DataValueField = convQxPrjMenus_Leaf.MenuIdLeaf;
objDDL.DataTextField = convQxPrjMenus_Leaf.MenuName;
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
public static void BindDdl_MenuIdLeafCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v三层菜单]...","0");
List<clsvQxPrjMenus_LeafEN> arrvQxPrjMenus_LeafObjLst = GetAllvQxPrjMenus_LeafObjLstCache(); 
objDDL.DataValueField = convQxPrjMenus_Leaf.MenuIdLeaf;
objDDL.DataTextField = convQxPrjMenus_Leaf.MenuName;
objDDL.DataSource = arrvQxPrjMenus_LeafObjLst;
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
//string strWhereCond = string.Format("1 = 1 order by MenuIdLeaf");
//if (arrvQxPrjMenus_LeafObjLstCache == null)
//{
//arrvQxPrjMenus_LeafObjLstCache = vQxPrjMenus_LeafDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strMenuIdLeaf">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxPrjMenus_LeafEN GetObjByMenuIdLeafCache(string strMenuIdLeaf)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvQxPrjMenus_LeafEN._CurrTabName);
List<clsvQxPrjMenus_LeafEN> arrvQxPrjMenus_LeafObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjMenus_LeafEN> arrvQxPrjMenus_LeafObjLst_Sel =
arrvQxPrjMenus_LeafObjLstCache
.Where(x=> x.MenuIdLeaf == strMenuIdLeaf 
);
if (arrvQxPrjMenus_LeafObjLst_Sel.Count() == 0)
{
   clsvQxPrjMenus_LeafEN obj = clsvQxPrjMenus_LeafBL.GetObjByMenuIdLeaf(strMenuIdLeaf);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvQxPrjMenus_LeafObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strMenuIdLeaf">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetMenuNameByMenuIdLeafCache(string strMenuIdLeaf)
{
if (string.IsNullOrEmpty(strMenuIdLeaf) == true) return "";
//获取缓存中的对象列表
clsvQxPrjMenus_LeafEN objvQxPrjMenus_Leaf = GetObjByMenuIdLeafCache(strMenuIdLeaf);
if (objvQxPrjMenus_Leaf == null) return "";
return objvQxPrjMenus_Leaf.MenuName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strMenuIdLeaf">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByMenuIdLeafCache(string strMenuIdLeaf)
{
if (string.IsNullOrEmpty(strMenuIdLeaf) == true) return "";
//获取缓存中的对象列表
clsvQxPrjMenus_LeafEN objvQxPrjMenus_Leaf = GetObjByMenuIdLeafCache(strMenuIdLeaf);
if (objvQxPrjMenus_Leaf == null) return "";
return objvQxPrjMenus_Leaf.MenuName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxPrjMenus_LeafEN> GetAllvQxPrjMenus_LeafObjLstCache()
{
//获取缓存中的对象列表
List<clsvQxPrjMenus_LeafEN> arrvQxPrjMenus_LeafObjLstCache = GetObjLstCache(); 
return arrvQxPrjMenus_LeafObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxPrjMenus_LeafEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvQxPrjMenus_LeafEN._CurrTabName);
List<clsvQxPrjMenus_LeafEN> arrvQxPrjMenus_LeafObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQxPrjMenus_LeafObjLstCache;
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
string strKey = string.Format("{0}", clsvQxPrjMenus_LeafEN._CurrTabName);
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
 /// <param name = "lstvQxPrjMenus_LeafObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsvQxPrjMenus_LeafEN> lstvQxPrjMenus_LeafObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstvQxPrjMenus_LeafObjLst, writer);
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
 /// <param name = "lstvQxPrjMenus_LeafObjLst">[clsvQxPrjMenus_LeafEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsvQxPrjMenus_LeafEN> lstvQxPrjMenus_LeafObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsvQxPrjMenus_LeafBL.listXmlNode);
writer.WriteStartElement(clsvQxPrjMenus_LeafBL.itemsXmlNode);
foreach (clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN in lstvQxPrjMenus_LeafObjLst)
{
clsvQxPrjMenus_LeafBL.SerializeXML(writer, objvQxPrjMenus_LeafEN);
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
 /// <param name = "objvQxPrjMenus_LeafEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN)
{
writer.WriteStartElement(clsvQxPrjMenus_LeafBL.itemXmlNode);
 
if (objvQxPrjMenus_LeafEN.MenuIdLeaf != null)
{
writer.WriteElementString(convQxPrjMenus_Leaf.MenuIdLeaf, objvQxPrjMenus_LeafEN.MenuIdLeaf.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenus_LeafEN.MenuName != null)
{
writer.WriteElementString(convQxPrjMenus_Leaf.MenuName, objvQxPrjMenus_LeafEN.MenuName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenus_LeafEN.QxPrjId != null)
{
writer.WriteElementString(convQxPrjMenus_Leaf.QxPrjId, objvQxPrjMenus_LeafEN.QxPrjId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenus_LeafEN.PrjName != null)
{
writer.WriteElementString(convQxPrjMenus_Leaf.PrjName, objvQxPrjMenus_LeafEN.PrjName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenus_LeafEN.UpMenuId != null)
{
writer.WriteElementString(convQxPrjMenus_Leaf.UpMenuId, objvQxPrjMenus_LeafEN.UpMenuId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenus_LeafEN.LinkFile != null)
{
writer.WriteElementString(convQxPrjMenus_Leaf.LinkFile, objvQxPrjMenus_LeafEN.LinkFile.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenus_LeafEN.qsParameters != null)
{
writer.WriteElementString(convQxPrjMenus_Leaf.qsParameters, objvQxPrjMenus_LeafEN.qsParameters.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenus_LeafEN.ImgFile != null)
{
writer.WriteElementString(convQxPrjMenus_Leaf.ImgFile, objvQxPrjMenus_LeafEN.ImgFile.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convQxPrjMenus_Leaf.OrderNum, objvQxPrjMenus_LeafEN.OrderNum.ToString());
 
writer.WriteElementString(convQxPrjMenus_Leaf.IsLeafNode, objvQxPrjMenus_LeafEN.IsLeafNode.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objvQxPrjMenus_LeafEN.MenuSetId != null)
{
writer.WriteElementString(convQxPrjMenus_Leaf.MenuSetId, objvQxPrjMenus_LeafEN.MenuSetId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenus_LeafEN.MenuSetName != null)
{
writer.WriteElementString(convQxPrjMenus_Leaf.MenuSetName, objvQxPrjMenus_LeafEN.MenuSetName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenus_LeafEN.MenuTitle != null)
{
writer.WriteElementString(convQxPrjMenus_Leaf.MenuTitle, objvQxPrjMenus_LeafEN.MenuTitle.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenus_LeafEN.PageDispModeId != null)
{
writer.WriteElementString(convQxPrjMenus_Leaf.PageDispModeId, objvQxPrjMenus_LeafEN.PageDispModeId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenus_LeafEN.PageDispModeName != null)
{
writer.WriteElementString(convQxPrjMenus_Leaf.PageDispModeName, objvQxPrjMenus_LeafEN.PageDispModeName.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convQxPrjMenus_Leaf.InUse, objvQxPrjMenus_LeafEN.InUse.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objvQxPrjMenus_LeafEN.UpdDate != null)
{
writer.WriteElementString(convQxPrjMenus_Leaf.UpdDate, objvQxPrjMenus_LeafEN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenus_LeafEN.UpdUserId != null)
{
writer.WriteElementString(convQxPrjMenus_Leaf.UpdUserId, objvQxPrjMenus_LeafEN.UpdUserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenus_LeafEN.Memo != null)
{
writer.WriteElementString(convQxPrjMenus_Leaf.Memo, objvQxPrjMenus_LeafEN.Memo.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenus_LeafEN.MenuControlName != null)
{
writer.WriteElementString(convQxPrjMenus_Leaf.MenuControlName, objvQxPrjMenus_LeafEN.MenuControlName.ToString(CultureInfo.InvariantCulture));
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
public static clsvQxPrjMenus_LeafEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN = new clsvQxPrjMenus_LeafEN();
reader.Read();
while (!(reader.Name == clsvQxPrjMenus_LeafBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(convQxPrjMenus_Leaf.MenuIdLeaf))
{
objvQxPrjMenus_LeafEN.MenuIdLeaf = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus_Leaf.MenuName))
{
objvQxPrjMenus_LeafEN.MenuName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus_Leaf.QxPrjId))
{
objvQxPrjMenus_LeafEN.QxPrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus_Leaf.PrjName))
{
objvQxPrjMenus_LeafEN.PrjName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus_Leaf.UpMenuId))
{
objvQxPrjMenus_LeafEN.UpMenuId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus_Leaf.LinkFile))
{
objvQxPrjMenus_LeafEN.LinkFile = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus_Leaf.qsParameters))
{
objvQxPrjMenus_LeafEN.qsParameters = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus_Leaf.ImgFile))
{
objvQxPrjMenus_LeafEN.ImgFile = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus_Leaf.OrderNum))
{
objvQxPrjMenus_LeafEN.OrderNum = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(convQxPrjMenus_Leaf.IsLeafNode))
{
objvQxPrjMenus_LeafEN.IsLeafNode = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(convQxPrjMenus_Leaf.MenuSetId))
{
objvQxPrjMenus_LeafEN.MenuSetId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus_Leaf.MenuSetName))
{
objvQxPrjMenus_LeafEN.MenuSetName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus_Leaf.MenuTitle))
{
objvQxPrjMenus_LeafEN.MenuTitle = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus_Leaf.PageDispModeId))
{
objvQxPrjMenus_LeafEN.PageDispModeId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus_Leaf.PageDispModeName))
{
objvQxPrjMenus_LeafEN.PageDispModeName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus_Leaf.InUse))
{
objvQxPrjMenus_LeafEN.InUse = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(convQxPrjMenus_Leaf.UpdDate))
{
objvQxPrjMenus_LeafEN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus_Leaf.UpdUserId))
{
objvQxPrjMenus_LeafEN.UpdUserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus_Leaf.Memo))
{
objvQxPrjMenus_LeafEN.Memo = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenus_Leaf.MenuControlName))
{
objvQxPrjMenus_LeafEN.MenuControlName = reader.ReadElementContentAsString();
}
}
return objvQxPrjMenus_LeafEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strvQxPrjMenus_LeafObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsvQxPrjMenus_LeafEN GetObjFromXmlStr(string strvQxPrjMenus_LeafObjXmlStr)
{
clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN = new clsvQxPrjMenus_LeafEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strvQxPrjMenus_LeafObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsvQxPrjMenus_LeafBL.itemXmlNode))
{
objvQxPrjMenus_LeafEN = GetObjFromXml(reader);
return objvQxPrjMenus_LeafEN;
}
}
return objvQxPrjMenus_LeafEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objvQxPrjMenus_LeafEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objvQxPrjMenus_LeafEN);
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
public static string Func(string strInFldName, string strOutFldName, string strMenuIdLeaf)
{
if (strInFldName != convQxPrjMenus_Leaf.MenuIdLeaf)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convQxPrjMenus_Leaf.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convQxPrjMenus_Leaf.AttributeName));
throw new Exception(strMsg);
}
var objvQxPrjMenus_Leaf = clsvQxPrjMenus_LeafBL.GetObjByMenuIdLeafCache(strMenuIdLeaf);
if (objvQxPrjMenus_Leaf == null) return "";
return objvQxPrjMenus_Leaf[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objvQxPrjMenus_LeafEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsvQxPrjMenus_LeafEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objvQxPrjMenus_LeafEN[strField]);
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
 /// <param name = "lstvQxPrjMenus_LeafObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsvQxPrjMenus_LeafEN> lstvQxPrjMenus_LeafObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstvQxPrjMenus_LeafObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN in lstvQxPrjMenus_LeafObjLst)
{
string strJSON_One = SerializeObjToJSON(objvQxPrjMenus_LeafEN);
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
int intRecCount = clsvQxPrjMenus_LeafDA.GetRecCount(strTabName);
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
int intRecCount = clsvQxPrjMenus_LeafDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvQxPrjMenus_LeafDA.GetRecCount();
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
int intRecCount = clsvQxPrjMenus_LeafDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvQxPrjMenus_LeafCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafCond)
{
List<clsvQxPrjMenus_LeafEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjMenus_LeafEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxPrjMenus_Leaf.AttributeName)
{
if (objvQxPrjMenus_LeafCond.IsUpdated(strFldName) == false) continue;
if (objvQxPrjMenus_LeafCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjMenus_LeafCond[strFldName].ToString());
}
else
{
if (objvQxPrjMenus_LeafCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxPrjMenus_LeafCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjMenus_LeafCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxPrjMenus_LeafCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxPrjMenus_LeafCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxPrjMenus_LeafCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxPrjMenus_LeafCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxPrjMenus_LeafCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxPrjMenus_LeafCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxPrjMenus_LeafCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxPrjMenus_LeafCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxPrjMenus_LeafCond[strFldName]));
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
 List<string> arrList = clsvQxPrjMenus_LeafDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vQxPrjMenus_LeafDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vQxPrjMenus_LeafDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}