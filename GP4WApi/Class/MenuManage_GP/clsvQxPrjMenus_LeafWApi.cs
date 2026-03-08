
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPrjMenus_LeafWApi
 表名:vQxPrjMenus_Leaf(00140085)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 18:31:36
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
public static class  clsvQxPrjMenus_LeafWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_LeafEN">需要设置字段值的实体对象</param>
 /// <param name = "strMenuIdLeaf">MenuId_Leaf</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_LeafEN SetMenuIdLeaf(this clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN, string strMenuIdLeaf, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMenuIdLeaf, 8, convQxPrjMenus_Leaf.MenuIdLeaf);
clsCheckSql.CheckFieldForeignKey(strMenuIdLeaf, 8, convQxPrjMenus_Leaf.MenuIdLeaf);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_LeafEN">需要设置字段值的实体对象</param>
 /// <param name = "strMenuName">菜单名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_LeafEN SetMenuName(this clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN, string strMenuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMenuName, convQxPrjMenus_Leaf.MenuName);
clsCheckSql.CheckFieldLen(strMenuName, 50, convQxPrjMenus_Leaf.MenuName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_LeafEN">需要设置字段值的实体对象</param>
 /// <param name = "strQxPrjId">项目Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_LeafEN SetQxPrjId(this clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxPrjMenus_Leaf.QxPrjId);
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxPrjMenus_Leaf.QxPrjId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_LeafEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_LeafEN SetPrjName(this clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjName, 30, convQxPrjMenus_Leaf.PrjName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_LeafEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpMenuId">上级菜单Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_LeafEN SetUpMenuId(this clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN, string strUpMenuId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpMenuId, 8, convQxPrjMenus_Leaf.UpMenuId);
clsCheckSql.CheckFieldForeignKey(strUpMenuId, 8, convQxPrjMenus_Leaf.UpMenuId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_LeafEN">需要设置字段值的实体对象</param>
 /// <param name = "strLinkFile">链接文件</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_LeafEN SetLinkFile(this clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN, string strLinkFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLinkFile, 500, convQxPrjMenus_Leaf.LinkFile);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_LeafEN">需要设置字段值的实体对象</param>
 /// <param name = "strqsParameters">qs参数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_LeafEN SetqsParameters(this clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN, string strqsParameters, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strqsParameters, 200, convQxPrjMenus_Leaf.qsParameters);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_LeafEN">需要设置字段值的实体对象</param>
 /// <param name = "strImgFile">图像文件</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_LeafEN SetImgFile(this clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN, string strImgFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strImgFile, 300, convQxPrjMenus_Leaf.ImgFile);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_LeafEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">排序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_LeafEN SetOrderNum(this clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN, int intOrderNum, string strComparisonOp="")
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_LeafEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsLeafNode">是否叶子</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_LeafEN">需要设置字段值的实体对象</param>
 /// <param name = "strMenuSetId">菜单集Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_LeafEN SetMenuSetId(this clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN, string strMenuSetId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMenuSetId, convQxPrjMenus_Leaf.MenuSetId);
clsCheckSql.CheckFieldLen(strMenuSetId, 4, convQxPrjMenus_Leaf.MenuSetId);
clsCheckSql.CheckFieldForeignKey(strMenuSetId, 4, convQxPrjMenus_Leaf.MenuSetId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_LeafEN">需要设置字段值的实体对象</param>
 /// <param name = "strMenuSetName">菜单集名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_LeafEN SetMenuSetName(this clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN, string strMenuSetName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMenuSetName, 50, convQxPrjMenus_Leaf.MenuSetName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_LeafEN">需要设置字段值的实体对象</param>
 /// <param name = "strMenuTitle">菜单标题</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_LeafEN SetMenuTitle(this clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN, string strMenuTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMenuTitle, 50, convQxPrjMenus_Leaf.MenuTitle);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_LeafEN">需要设置字段值的实体对象</param>
 /// <param name = "strPageDispModeId">页面显示模式Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_LeafEN SetPageDispModeId(this clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN, string strPageDispModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPageDispModeId, 2, convQxPrjMenus_Leaf.PageDispModeId);
clsCheckSql.CheckFieldForeignKey(strPageDispModeId, 2, convQxPrjMenus_Leaf.PageDispModeId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_LeafEN">需要设置字段值的实体对象</param>
 /// <param name = "strPageDispModeName">页面显示模式名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_LeafEN SetPageDispModeName(this clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN, string strPageDispModeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPageDispModeName, 50, convQxPrjMenus_Leaf.PageDispModeName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_LeafEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_LeafEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_LeafEN SetUpdDate(this clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQxPrjMenus_Leaf.UpdDate);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_LeafEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_LeafEN SetUpdUserId(this clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convQxPrjMenus_Leaf.UpdUserId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_LeafEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">备注</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_LeafEN SetMemo(this clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxPrjMenus_Leaf.Memo);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenus_LeafEN">需要设置字段值的实体对象</param>
 /// <param name = "strMenuControlName">MenuControlName</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenus_LeafEN SetMenuControlName(this clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN, string strMenuControlName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMenuControlName, 100, convQxPrjMenus_Leaf.MenuControlName);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
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
 /// v三层菜单(vQxPrjMenus_Leaf)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxPrjMenus_LeafWApi
{
private static readonly string mstrApiControllerName = "vQxPrjMenus_LeafApi";

 public clsvQxPrjMenus_LeafWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_MenuIdLeaf(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v三层菜单]...","0");
List<clsvQxPrjMenus_LeafEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="MenuIdLeaf";
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

public static void BindCbo_MenuIdLeaf(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convQxPrjMenus_Leaf.MenuIdLeaf); 
List<clsvQxPrjMenus_LeafEN> arrObjLst = clsvQxPrjMenus_LeafWApi.GetObjLst(strCondition);
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
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strMenuIdLeaf">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxPrjMenus_LeafEN GetObjByMenuIdLeaf(string strMenuIdLeaf)
{
string strAction = "GetObjByMenuIdLeaf";
clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strMenuIdLeaf"] = strMenuIdLeaf,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvQxPrjMenus_LeafEN = JsonConvert.DeserializeObject<clsvQxPrjMenus_LeafEN>(strJson);
return objvQxPrjMenus_LeafEN;
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
public static clsvQxPrjMenus_LeafEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN;
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
objvQxPrjMenus_LeafEN = JsonConvert.DeserializeObject<clsvQxPrjMenus_LeafEN>(strJson);
return objvQxPrjMenus_LeafEN;
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
//该表没有使用Cache,不需要生成[GetMenuNameByMenuIdLeafCache]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjMenus_LeafEN> GetObjLst(string strWhereCond)
{
 List<clsvQxPrjMenus_LeafEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjMenus_LeafEN>>(strJson);
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
 /// <param name = "arrMenuIdLeaf">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjMenus_LeafEN> GetObjLstByMenuIdLeafLst(List<string> arrMenuIdLeaf)
{
 List<clsvQxPrjMenus_LeafEN> arrObjLst; 
string strAction = "GetObjLstByMenuIdLeafLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMenuIdLeaf);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjMenus_LeafEN>>(strJson);
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
public static List<clsvQxPrjMenus_LeafEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvQxPrjMenus_LeafEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjMenus_LeafEN>>(strJson);
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
public static List<clsvQxPrjMenus_LeafEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvQxPrjMenus_LeafEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjMenus_LeafEN>>(strJson);
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
public static List<clsvQxPrjMenus_LeafEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvQxPrjMenus_LeafEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjMenus_LeafEN>>(strJson);
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
public static List<clsvQxPrjMenus_LeafEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvQxPrjMenus_LeafEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjMenus_LeafEN>>(strJson);
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
public static bool IsExist(string strMenuIdLeaf)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strMenuIdLeaf"] = strMenuIdLeaf
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
public static DataTable ToDataTable(List<clsvQxPrjMenus_LeafEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvQxPrjMenus_LeafEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvQxPrjMenus_LeafEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvQxPrjMenus_LeafEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvQxPrjMenus_LeafEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvQxPrjMenus_LeafEN.AttributeName)
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
//该表没有使用Cache,不需要生成[GetObjLstCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvQxPrjMenus_LeafEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convQxPrjMenus_Leaf.MenuIdLeaf, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus_Leaf.MenuName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus_Leaf.QxPrjId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus_Leaf.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus_Leaf.UpMenuId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus_Leaf.LinkFile, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus_Leaf.qsParameters, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus_Leaf.ImgFile, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus_Leaf.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convQxPrjMenus_Leaf.IsLeafNode, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQxPrjMenus_Leaf.MenuSetId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus_Leaf.MenuSetName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus_Leaf.MenuTitle, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus_Leaf.PageDispModeId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus_Leaf.PageDispModeName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus_Leaf.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQxPrjMenus_Leaf.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus_Leaf.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus_Leaf.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjMenus_Leaf.MenuControlName, Type.GetType("System.String"));
foreach (clsvQxPrjMenus_LeafEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convQxPrjMenus_Leaf.MenuIdLeaf] = objInFor[convQxPrjMenus_Leaf.MenuIdLeaf];
objDR[convQxPrjMenus_Leaf.MenuName] = objInFor[convQxPrjMenus_Leaf.MenuName];
objDR[convQxPrjMenus_Leaf.QxPrjId] = objInFor[convQxPrjMenus_Leaf.QxPrjId];
objDR[convQxPrjMenus_Leaf.PrjName] = objInFor[convQxPrjMenus_Leaf.PrjName];
objDR[convQxPrjMenus_Leaf.UpMenuId] = objInFor[convQxPrjMenus_Leaf.UpMenuId];
objDR[convQxPrjMenus_Leaf.LinkFile] = objInFor[convQxPrjMenus_Leaf.LinkFile];
objDR[convQxPrjMenus_Leaf.qsParameters] = objInFor[convQxPrjMenus_Leaf.qsParameters];
objDR[convQxPrjMenus_Leaf.ImgFile] = objInFor[convQxPrjMenus_Leaf.ImgFile];
objDR[convQxPrjMenus_Leaf.OrderNum] = objInFor[convQxPrjMenus_Leaf.OrderNum];
objDR[convQxPrjMenus_Leaf.IsLeafNode] = objInFor[convQxPrjMenus_Leaf.IsLeafNode];
objDR[convQxPrjMenus_Leaf.MenuSetId] = objInFor[convQxPrjMenus_Leaf.MenuSetId];
objDR[convQxPrjMenus_Leaf.MenuSetName] = objInFor[convQxPrjMenus_Leaf.MenuSetName];
objDR[convQxPrjMenus_Leaf.MenuTitle] = objInFor[convQxPrjMenus_Leaf.MenuTitle];
objDR[convQxPrjMenus_Leaf.PageDispModeId] = objInFor[convQxPrjMenus_Leaf.PageDispModeId];
objDR[convQxPrjMenus_Leaf.PageDispModeName] = objInFor[convQxPrjMenus_Leaf.PageDispModeName];
objDR[convQxPrjMenus_Leaf.InUse] = objInFor[convQxPrjMenus_Leaf.InUse];
objDR[convQxPrjMenus_Leaf.UpdDate] = objInFor[convQxPrjMenus_Leaf.UpdDate];
objDR[convQxPrjMenus_Leaf.UpdUserId] = objInFor[convQxPrjMenus_Leaf.UpdUserId];
objDR[convQxPrjMenus_Leaf.Memo] = objInFor[convQxPrjMenus_Leaf.Memo];
objDR[convQxPrjMenus_Leaf.MenuControlName] = objInFor[convQxPrjMenus_Leaf.MenuControlName];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}