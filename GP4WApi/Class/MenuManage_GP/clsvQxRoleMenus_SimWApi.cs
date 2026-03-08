
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxRoleMenus_SimWApi
 表名:vQxRoleMenus_Sim(00140073)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 18:32:08
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
public static class  clsvQxRoleMenus_SimWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenus_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">流水号</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenus_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strRoleId">角色Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenus_SimEN SetRoleId(this clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN, string strRoleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRoleId, convQxRoleMenus_Sim.RoleId);
clsCheckSql.CheckFieldLen(strRoleId, 8, convQxRoleMenus_Sim.RoleId);
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, convQxRoleMenus_Sim.RoleId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenus_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strQxPrjId">项目Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenus_SimEN SetQxPrjId(this clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, convQxRoleMenus_Sim.QxPrjId);
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxRoleMenus_Sim.QxPrjId);
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxRoleMenus_Sim.QxPrjId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenus_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strMenuId">菜单Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenus_SimEN SetMenuId(this clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN, string strMenuId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMenuId, convQxRoleMenus_Sim.MenuId);
clsCheckSql.CheckFieldLen(strMenuId, 8, convQxRoleMenus_Sim.MenuId);
clsCheckSql.CheckFieldForeignKey(strMenuId, 8, convQxRoleMenus_Sim.MenuId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenus_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strMenuName">菜单名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenus_SimEN SetMenuName(this clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN, string strMenuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMenuName, 50, convQxRoleMenus_Sim.MenuName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenus_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpMenuId">上级菜单Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenus_SimEN SetUpMenuId(this clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN, string strUpMenuId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpMenuId, 8, convQxRoleMenus_Sim.UpMenuId);
clsCheckSql.CheckFieldForeignKey(strUpMenuId, 8, convQxRoleMenus_Sim.UpMenuId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenus_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strLinkFile">链接文件</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenus_SimEN SetLinkFile(this clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN, string strLinkFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLinkFile, 500, convQxRoleMenus_Sim.LinkFile);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenus_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strqsParameters">qs参数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenus_SimEN SetqsParameters(this clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN, string strqsParameters, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strqsParameters, 200, convQxRoleMenus_Sim.qsParameters);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenus_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strImgFile">图像文件</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenus_SimEN SetImgFile(this clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN, string strImgFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strImgFile, 300, convQxRoleMenus_Sim.ImgFile);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenus_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">排序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenus_SimEN SetOrderNum(this clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN, int intOrderNum, string strComparisonOp="")
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenus_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsLeafNode">是否叶子</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenus_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strMenuSetId">菜单集Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenus_SimEN SetMenuSetId(this clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN, string strMenuSetId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMenuSetId, 4, convQxRoleMenus_Sim.MenuSetId);
clsCheckSql.CheckFieldForeignKey(strMenuSetId, 4, convQxRoleMenus_Sim.MenuSetId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenus_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strMenuTitle">菜单标题</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenus_SimEN SetMenuTitle(this clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN, string strMenuTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMenuTitle, 50, convQxRoleMenus_Sim.MenuTitle);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenus_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strPageDispModeId">页面显示模式Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenus_SimEN SetPageDispModeId(this clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN, string strPageDispModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPageDispModeId, 2, convQxRoleMenus_Sim.PageDispModeId);
clsCheckSql.CheckFieldForeignKey(strPageDispModeId, 2, convQxRoleMenus_Sim.PageDispModeId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenus_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRoleMenus_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpMenuName">上级菜单名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRoleMenus_SimEN SetUpMenuName(this clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN, string strUpMenuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpMenuName, 30, convQxRoleMenus_Sim.UpMenuName);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
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
 /// v角色菜单_Sim(vQxRoleMenus_Sim)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxRoleMenus_SimWApi
{
private static readonly string mstrApiControllerName = "vQxRoleMenus_SimApi";

 public clsvQxRoleMenus_SimWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxRoleMenus_SimEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN;
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
objvQxRoleMenus_SimEN = JsonConvert.DeserializeObject<clsvQxRoleMenus_SimEN>(strJson);
return objvQxRoleMenus_SimEN;
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
public static clsvQxRoleMenus_SimEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN;
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
objvQxRoleMenus_SimEN = JsonConvert.DeserializeObject<clsvQxRoleMenus_SimEN>(strJson);
return objvQxRoleMenus_SimEN;
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
public static List<clsvQxRoleMenus_SimEN> GetObjLst(string strWhereCond)
{
 List<clsvQxRoleMenus_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxRoleMenus_SimEN>>(strJson);
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
public static List<clsvQxRoleMenus_SimEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvQxRoleMenus_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxRoleMenus_SimEN>>(strJson);
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
public static List<clsvQxRoleMenus_SimEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvQxRoleMenus_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxRoleMenus_SimEN>>(strJson);
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
public static List<clsvQxRoleMenus_SimEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvQxRoleMenus_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxRoleMenus_SimEN>>(strJson);
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
public static List<clsvQxRoleMenus_SimEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvQxRoleMenus_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxRoleMenus_SimEN>>(strJson);
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
public static List<clsvQxRoleMenus_SimEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvQxRoleMenus_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxRoleMenus_SimEN>>(strJson);
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
public static DataTable ToDataTable(List<clsvQxRoleMenus_SimEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvQxRoleMenus_SimEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvQxRoleMenus_SimEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvQxRoleMenus_SimEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvQxRoleMenus_SimEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvQxRoleMenus_SimEN.AttributeName)
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
//该表没有使用Cache,不需要生成[GetObjLstCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvQxRoleMenus_SimEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convQxRoleMenus_Sim.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convQxRoleMenus_Sim.RoleId, Type.GetType("System.String"));
objDT.Columns.Add(convQxRoleMenus_Sim.QxPrjId, Type.GetType("System.String"));
objDT.Columns.Add(convQxRoleMenus_Sim.MenuId, Type.GetType("System.String"));
objDT.Columns.Add(convQxRoleMenus_Sim.MenuName, Type.GetType("System.String"));
objDT.Columns.Add(convQxRoleMenus_Sim.UpMenuId, Type.GetType("System.String"));
objDT.Columns.Add(convQxRoleMenus_Sim.LinkFile, Type.GetType("System.String"));
objDT.Columns.Add(convQxRoleMenus_Sim.qsParameters, Type.GetType("System.String"));
objDT.Columns.Add(convQxRoleMenus_Sim.ImgFile, Type.GetType("System.String"));
objDT.Columns.Add(convQxRoleMenus_Sim.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convQxRoleMenus_Sim.IsLeafNode, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQxRoleMenus_Sim.MenuSetId, Type.GetType("System.String"));
objDT.Columns.Add(convQxRoleMenus_Sim.MenuTitle, Type.GetType("System.String"));
objDT.Columns.Add(convQxRoleMenus_Sim.PageDispModeId, Type.GetType("System.String"));
objDT.Columns.Add(convQxRoleMenus_Sim.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQxRoleMenus_Sim.UpMenuName, Type.GetType("System.String"));
foreach (clsvQxRoleMenus_SimEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convQxRoleMenus_Sim.mId] = objInFor[convQxRoleMenus_Sim.mId];
objDR[convQxRoleMenus_Sim.RoleId] = objInFor[convQxRoleMenus_Sim.RoleId];
objDR[convQxRoleMenus_Sim.QxPrjId] = objInFor[convQxRoleMenus_Sim.QxPrjId];
objDR[convQxRoleMenus_Sim.MenuId] = objInFor[convQxRoleMenus_Sim.MenuId];
objDR[convQxRoleMenus_Sim.MenuName] = objInFor[convQxRoleMenus_Sim.MenuName];
objDR[convQxRoleMenus_Sim.UpMenuId] = objInFor[convQxRoleMenus_Sim.UpMenuId];
objDR[convQxRoleMenus_Sim.LinkFile] = objInFor[convQxRoleMenus_Sim.LinkFile];
objDR[convQxRoleMenus_Sim.qsParameters] = objInFor[convQxRoleMenus_Sim.qsParameters];
objDR[convQxRoleMenus_Sim.ImgFile] = objInFor[convQxRoleMenus_Sim.ImgFile];
objDR[convQxRoleMenus_Sim.OrderNum] = objInFor[convQxRoleMenus_Sim.OrderNum];
objDR[convQxRoleMenus_Sim.IsLeafNode] = objInFor[convQxRoleMenus_Sim.IsLeafNode];
objDR[convQxRoleMenus_Sim.MenuSetId] = objInFor[convQxRoleMenus_Sim.MenuSetId];
objDR[convQxRoleMenus_Sim.MenuTitle] = objInFor[convQxRoleMenus_Sim.MenuTitle];
objDR[convQxRoleMenus_Sim.PageDispModeId] = objInFor[convQxRoleMenus_Sim.PageDispModeId];
objDR[convQxRoleMenus_Sim.InUse] = objInFor[convQxRoleMenus_Sim.InUse];
objDR[convQxRoleMenus_Sim.UpMenuName] = objInFor[convQxRoleMenus_Sim.UpMenuName];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}