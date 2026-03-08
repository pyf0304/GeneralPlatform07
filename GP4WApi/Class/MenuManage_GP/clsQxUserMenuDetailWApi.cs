
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUserMenuDetailWApi
 表名:QxUserMenuDetail(00140011)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 18:23:12
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
public static class  clsQxUserMenuDetailWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">流水号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserMenuDetailEN SetmId(this clsQxUserMenuDetailEN objQxUserMenuDetailEN, long lngmId, string strComparisonOp="")
	{
objQxUserMenuDetailEN.mId = lngmId; //流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserMenuDetailEN.dicFldComparisonOp.ContainsKey(conQxUserMenuDetail.mId) == false)
{
objQxUserMenuDetailEN.dicFldComparisonOp.Add(conQxUserMenuDetail.mId, strComparisonOp);
}
else
{
objQxUserMenuDetailEN.dicFldComparisonOp[conQxUserMenuDetail.mId] = strComparisonOp;
}
}
return objQxUserMenuDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strMenuId">菜单Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserMenuDetailEN SetMenuId(this clsQxUserMenuDetailEN objQxUserMenuDetailEN, string strMenuId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMenuId, conQxUserMenuDetail.MenuId);
clsCheckSql.CheckFieldLen(strMenuId, 8, conQxUserMenuDetail.MenuId);
clsCheckSql.CheckFieldForeignKey(strMenuId, 8, conQxUserMenuDetail.MenuId);
objQxUserMenuDetailEN.MenuId = strMenuId; //菜单Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserMenuDetailEN.dicFldComparisonOp.ContainsKey(conQxUserMenuDetail.MenuId) == false)
{
objQxUserMenuDetailEN.dicFldComparisonOp.Add(conQxUserMenuDetail.MenuId, strComparisonOp);
}
else
{
objQxUserMenuDetailEN.dicFldComparisonOp[conQxUserMenuDetail.MenuId] = strComparisonOp;
}
}
return objQxUserMenuDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strMenuName">菜单名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserMenuDetailEN SetMenuName(this clsQxUserMenuDetailEN objQxUserMenuDetailEN, string strMenuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMenuName, conQxUserMenuDetail.MenuName);
clsCheckSql.CheckFieldLen(strMenuName, 50, conQxUserMenuDetail.MenuName);
objQxUserMenuDetailEN.MenuName = strMenuName; //菜单名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserMenuDetailEN.dicFldComparisonOp.ContainsKey(conQxUserMenuDetail.MenuName) == false)
{
objQxUserMenuDetailEN.dicFldComparisonOp.Add(conQxUserMenuDetail.MenuName, strComparisonOp);
}
else
{
objQxUserMenuDetailEN.dicFldComparisonOp[conQxUserMenuDetail.MenuName] = strComparisonOp;
}
}
return objQxUserMenuDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsDisp">是否显示</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserMenuDetailEN SetIsDisp(this clsQxUserMenuDetailEN objQxUserMenuDetailEN, bool bolIsDisp, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsDisp, conQxUserMenuDetail.IsDisp);
objQxUserMenuDetailEN.IsDisp = bolIsDisp; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserMenuDetailEN.dicFldComparisonOp.ContainsKey(conQxUserMenuDetail.IsDisp) == false)
{
objQxUserMenuDetailEN.dicFldComparisonOp.Add(conQxUserMenuDetail.IsDisp, strComparisonOp);
}
else
{
objQxUserMenuDetailEN.dicFldComparisonOp[conQxUserMenuDetail.IsDisp] = strComparisonOp;
}
}
return objQxUserMenuDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpMenuId">上级菜单Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserMenuDetailEN SetUpMenuId(this clsQxUserMenuDetailEN objQxUserMenuDetailEN, string strUpMenuId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpMenuId, 8, conQxUserMenuDetail.UpMenuId);
clsCheckSql.CheckFieldForeignKey(strUpMenuId, 8, conQxUserMenuDetail.UpMenuId);
objQxUserMenuDetailEN.UpMenuId = strUpMenuId; //上级菜单Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserMenuDetailEN.dicFldComparisonOp.ContainsKey(conQxUserMenuDetail.UpMenuId) == false)
{
objQxUserMenuDetailEN.dicFldComparisonOp.Add(conQxUserMenuDetail.UpMenuId, strComparisonOp);
}
else
{
objQxUserMenuDetailEN.dicFldComparisonOp[conQxUserMenuDetail.UpMenuId] = strComparisonOp;
}
}
return objQxUserMenuDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strLinkFile">链接文件</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserMenuDetailEN SetLinkFile(this clsQxUserMenuDetailEN objQxUserMenuDetailEN, string strLinkFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLinkFile, 500, conQxUserMenuDetail.LinkFile);
objQxUserMenuDetailEN.LinkFile = strLinkFile; //链接文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserMenuDetailEN.dicFldComparisonOp.ContainsKey(conQxUserMenuDetail.LinkFile) == false)
{
objQxUserMenuDetailEN.dicFldComparisonOp.Add(conQxUserMenuDetail.LinkFile, strComparisonOp);
}
else
{
objQxUserMenuDetailEN.dicFldComparisonOp[conQxUserMenuDetail.LinkFile] = strComparisonOp;
}
}
return objQxUserMenuDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strImgFile">图像文件</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserMenuDetailEN SetImgFile(this clsQxUserMenuDetailEN objQxUserMenuDetailEN, string strImgFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strImgFile, 300, conQxUserMenuDetail.ImgFile);
objQxUserMenuDetailEN.ImgFile = strImgFile; //图像文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserMenuDetailEN.dicFldComparisonOp.ContainsKey(conQxUserMenuDetail.ImgFile) == false)
{
objQxUserMenuDetailEN.dicFldComparisonOp.Add(conQxUserMenuDetail.ImgFile, strComparisonOp);
}
else
{
objQxUserMenuDetailEN.dicFldComparisonOp[conQxUserMenuDetail.ImgFile] = strComparisonOp;
}
}
return objQxUserMenuDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsCustomMenu">是否定制菜单</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserMenuDetailEN SetIsCustomMenu(this clsQxUserMenuDetailEN objQxUserMenuDetailEN, bool bolIsCustomMenu, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsCustomMenu, conQxUserMenuDetail.IsCustomMenu);
objQxUserMenuDetailEN.IsCustomMenu = bolIsCustomMenu; //是否定制菜单
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserMenuDetailEN.dicFldComparisonOp.ContainsKey(conQxUserMenuDetail.IsCustomMenu) == false)
{
objQxUserMenuDetailEN.dicFldComparisonOp.Add(conQxUserMenuDetail.IsCustomMenu, strComparisonOp);
}
else
{
objQxUserMenuDetailEN.dicFldComparisonOp[conQxUserMenuDetail.IsCustomMenu] = strComparisonOp;
}
}
return objQxUserMenuDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserMenuDetailEN SetUserId(this clsQxUserMenuDetailEN objQxUserMenuDetailEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, conQxUserMenuDetail.UserId);
clsCheckSql.CheckFieldLen(strUserId, 18, conQxUserMenuDetail.UserId);
objQxUserMenuDetailEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserMenuDetailEN.dicFldComparisonOp.ContainsKey(conQxUserMenuDetail.UserId) == false)
{
objQxUserMenuDetailEN.dicFldComparisonOp.Add(conQxUserMenuDetail.UserId, strComparisonOp);
}
else
{
objQxUserMenuDetailEN.dicFldComparisonOp[conQxUserMenuDetail.UserId] = strComparisonOp;
}
}
return objQxUserMenuDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strQxPrjId">项目Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserMenuDetailEN SetQxPrjId(this clsQxUserMenuDetailEN objQxUserMenuDetailEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, conQxUserMenuDetail.QxPrjId);
clsCheckSql.CheckFieldLen(strQxPrjId, 4, conQxUserMenuDetail.QxPrjId);
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, conQxUserMenuDetail.QxPrjId);
objQxUserMenuDetailEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserMenuDetailEN.dicFldComparisonOp.ContainsKey(conQxUserMenuDetail.QxPrjId) == false)
{
objQxUserMenuDetailEN.dicFldComparisonOp.Add(conQxUserMenuDetail.QxPrjId, strComparisonOp);
}
else
{
objQxUserMenuDetailEN.dicFldComparisonOp[conQxUserMenuDetail.QxPrjId] = strComparisonOp;
}
}
return objQxUserMenuDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">排序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserMenuDetailEN SetOrderNum(this clsQxUserMenuDetailEN objQxUserMenuDetailEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, conQxUserMenuDetail.OrderNum);
objQxUserMenuDetailEN.OrderNum = intOrderNum; //排序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserMenuDetailEN.dicFldComparisonOp.ContainsKey(conQxUserMenuDetail.OrderNum) == false)
{
objQxUserMenuDetailEN.dicFldComparisonOp.Add(conQxUserMenuDetail.OrderNum, strComparisonOp);
}
else
{
objQxUserMenuDetailEN.dicFldComparisonOp[conQxUserMenuDetail.OrderNum] = strComparisonOp;
}
}
return objQxUserMenuDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">备注</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserMenuDetailEN SetMemo(this clsQxUserMenuDetailEN objQxUserMenuDetailEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQxUserMenuDetail.Memo);
objQxUserMenuDetailEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserMenuDetailEN.dicFldComparisonOp.ContainsKey(conQxUserMenuDetail.Memo) == false)
{
objQxUserMenuDetailEN.dicFldComparisonOp.Add(conQxUserMenuDetail.Memo, strComparisonOp);
}
else
{
objQxUserMenuDetailEN.dicFldComparisonOp[conQxUserMenuDetail.Memo] = strComparisonOp;
}
}
return objQxUserMenuDetailEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQxUserMenuDetailEN objQxUserMenuDetailCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQxUserMenuDetailCond.IsUpdated(conQxUserMenuDetail.mId) == true)
{
string strComparisonOpmId = objQxUserMenuDetailCond.dicFldComparisonOp[conQxUserMenuDetail.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conQxUserMenuDetail.mId, objQxUserMenuDetailCond.mId, strComparisonOpmId);
}
if (objQxUserMenuDetailCond.IsUpdated(conQxUserMenuDetail.MenuId) == true)
{
string strComparisonOpMenuId = objQxUserMenuDetailCond.dicFldComparisonOp[conQxUserMenuDetail.MenuId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserMenuDetail.MenuId, objQxUserMenuDetailCond.MenuId, strComparisonOpMenuId);
}
if (objQxUserMenuDetailCond.IsUpdated(conQxUserMenuDetail.MenuName) == true)
{
string strComparisonOpMenuName = objQxUserMenuDetailCond.dicFldComparisonOp[conQxUserMenuDetail.MenuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserMenuDetail.MenuName, objQxUserMenuDetailCond.MenuName, strComparisonOpMenuName);
}
if (objQxUserMenuDetailCond.IsUpdated(conQxUserMenuDetail.IsDisp) == true)
{
if (objQxUserMenuDetailCond.IsDisp == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQxUserMenuDetail.IsDisp);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQxUserMenuDetail.IsDisp);
}
}
if (objQxUserMenuDetailCond.IsUpdated(conQxUserMenuDetail.UpMenuId) == true)
{
string strComparisonOpUpMenuId = objQxUserMenuDetailCond.dicFldComparisonOp[conQxUserMenuDetail.UpMenuId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserMenuDetail.UpMenuId, objQxUserMenuDetailCond.UpMenuId, strComparisonOpUpMenuId);
}
if (objQxUserMenuDetailCond.IsUpdated(conQxUserMenuDetail.LinkFile) == true)
{
string strComparisonOpLinkFile = objQxUserMenuDetailCond.dicFldComparisonOp[conQxUserMenuDetail.LinkFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserMenuDetail.LinkFile, objQxUserMenuDetailCond.LinkFile, strComparisonOpLinkFile);
}
if (objQxUserMenuDetailCond.IsUpdated(conQxUserMenuDetail.ImgFile) == true)
{
string strComparisonOpImgFile = objQxUserMenuDetailCond.dicFldComparisonOp[conQxUserMenuDetail.ImgFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserMenuDetail.ImgFile, objQxUserMenuDetailCond.ImgFile, strComparisonOpImgFile);
}
if (objQxUserMenuDetailCond.IsUpdated(conQxUserMenuDetail.IsCustomMenu) == true)
{
if (objQxUserMenuDetailCond.IsCustomMenu == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQxUserMenuDetail.IsCustomMenu);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQxUserMenuDetail.IsCustomMenu);
}
}
if (objQxUserMenuDetailCond.IsUpdated(conQxUserMenuDetail.UserId) == true)
{
string strComparisonOpUserId = objQxUserMenuDetailCond.dicFldComparisonOp[conQxUserMenuDetail.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserMenuDetail.UserId, objQxUserMenuDetailCond.UserId, strComparisonOpUserId);
}
if (objQxUserMenuDetailCond.IsUpdated(conQxUserMenuDetail.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objQxUserMenuDetailCond.dicFldComparisonOp[conQxUserMenuDetail.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserMenuDetail.QxPrjId, objQxUserMenuDetailCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objQxUserMenuDetailCond.IsUpdated(conQxUserMenuDetail.OrderNum) == true)
{
string strComparisonOpOrderNum = objQxUserMenuDetailCond.dicFldComparisonOp[conQxUserMenuDetail.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conQxUserMenuDetail.OrderNum, objQxUserMenuDetailCond.OrderNum, strComparisonOpOrderNum);
}
if (objQxUserMenuDetailCond.IsUpdated(conQxUserMenuDetail.Memo) == true)
{
string strComparisonOpMemo = objQxUserMenuDetailCond.dicFldComparisonOp[conQxUserMenuDetail.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserMenuDetail.Memo, objQxUserMenuDetailCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxUserMenuDetailEN objQxUserMenuDetailEN)
{
 if (objQxUserMenuDetailEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objQxUserMenuDetailEN.sfUpdFldSetStr = objQxUserMenuDetailEN.getsfUpdFldSetStr();
clsQxUserMenuDetailWApi.CheckPropertyNew(objQxUserMenuDetailEN); 
bool bolResult = clsQxUserMenuDetailWApi.UpdateRecord(objQxUserMenuDetailEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000004)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 获取唯一性条件串--QxUserMenuDetail(用户菜单), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:UserId_MenuId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsQxUserMenuDetailEN objQxUserMenuDetailEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objQxUserMenuDetailEN == null) return "";
if (objQxUserMenuDetailEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and UserId = '{0}'", objQxUserMenuDetailEN.UserId);
 sbCondition.AppendFormat(" and MenuId = '{0}'", objQxUserMenuDetailEN.MenuId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objQxUserMenuDetailEN.mId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objQxUserMenuDetailEN.UserId);
 sbCondition.AppendFormat(" and MenuId = '{0}'", objQxUserMenuDetailEN.MenuId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQxUserMenuDetailEN objQxUserMenuDetailEN)
{
try
{
clsQxUserMenuDetailWApi.CheckPropertyNew(objQxUserMenuDetailEN); 
bool bolResult = clsQxUserMenuDetailWApi.AddNewRecord(objQxUserMenuDetailEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserMenuDetailWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000008)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxUserMenuDetailEN objQxUserMenuDetailEN, string strWhereCond)
{
try
{
clsQxUserMenuDetailWApi.CheckPropertyNew(objQxUserMenuDetailEN); 
bool bolResult = clsQxUserMenuDetailWApi.UpdateWithCondition(objQxUserMenuDetailEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserMenuDetailWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000007)根据条件修改记录出错, {1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// 用户菜单(QxUserMenuDetail)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsQxUserMenuDetailWApi
{
private static readonly string mstrApiControllerName = "QxUserMenuDetailApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsQxUserMenuDetailWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsQxUserMenuDetailEN objQxUserMenuDetailEN)
{
if (!Object.Equals(null, objQxUserMenuDetailEN.MenuId) && GetStrLen(objQxUserMenuDetailEN.MenuId) > 8)
{
 throw new Exception("字段[菜单Id]的长度不能超过8!");
}
if (!Object.Equals(null, objQxUserMenuDetailEN.MenuName) && GetStrLen(objQxUserMenuDetailEN.MenuName) > 50)
{
 throw new Exception("字段[菜单名]的长度不能超过50!");
}
if (!Object.Equals(null, objQxUserMenuDetailEN.UpMenuId) && GetStrLen(objQxUserMenuDetailEN.UpMenuId) > 8)
{
 throw new Exception("字段[上级菜单Id]的长度不能超过8!");
}
if (!Object.Equals(null, objQxUserMenuDetailEN.LinkFile) && GetStrLen(objQxUserMenuDetailEN.LinkFile) > 500)
{
 throw new Exception("字段[链接文件]的长度不能超过500!");
}
if (!Object.Equals(null, objQxUserMenuDetailEN.ImgFile) && GetStrLen(objQxUserMenuDetailEN.ImgFile) > 300)
{
 throw new Exception("字段[图像文件]的长度不能超过300!");
}
if (!Object.Equals(null, objQxUserMenuDetailEN.UserId) && GetStrLen(objQxUserMenuDetailEN.UserId) > 18)
{
 throw new Exception("字段[用户ID]的长度不能超过18!");
}
if (!Object.Equals(null, objQxUserMenuDetailEN.QxPrjId) && GetStrLen(objQxUserMenuDetailEN.QxPrjId) > 4)
{
 throw new Exception("字段[项目Id]的长度不能超过4!");
}
if (!Object.Equals(null, objQxUserMenuDetailEN.Memo) && GetStrLen(objQxUserMenuDetailEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objQxUserMenuDetailEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxUserMenuDetailEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
clsQxUserMenuDetailEN objQxUserMenuDetailEN;
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
objQxUserMenuDetailEN = JsonConvert.DeserializeObject<clsQxUserMenuDetailEN>(strJson);
return objQxUserMenuDetailEN;
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
public static clsQxUserMenuDetailEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsQxUserMenuDetailEN objQxUserMenuDetailEN;
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
objQxUserMenuDetailEN = JsonConvert.DeserializeObject<clsQxUserMenuDetailEN>(strJson);
return objQxUserMenuDetailEN;
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
public static List<clsQxUserMenuDetailEN> GetObjLst(string strWhereCond)
{
 List<clsQxUserMenuDetailEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxUserMenuDetailEN>>(strJson);
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
public static List<clsQxUserMenuDetailEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsQxUserMenuDetailEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxUserMenuDetailEN>>(strJson);
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
public static List<clsQxUserMenuDetailEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsQxUserMenuDetailEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxUserMenuDetailEN>>(strJson);
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
public static List<clsQxUserMenuDetailEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsQxUserMenuDetailEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxUserMenuDetailEN>>(strJson);
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
public static List<clsQxUserMenuDetailEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsQxUserMenuDetailEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxUserMenuDetailEN>>(strJson);
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
public static List<clsQxUserMenuDetailEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsQxUserMenuDetailEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxUserMenuDetailEN>>(strJson);
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
 /// 根据关键字删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecord(long lngmId)
{
string strAction = "DelRecord";
try
{
 clsQxUserMenuDetailEN objQxUserMenuDetailEN = clsQxUserMenuDetailWApi.GetObjBymId(lngmId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngmId.ToString(), out string strResult, out string strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecords)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecords(string strKeyIdLst)
{
string strAction = "DelRecords";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strKeyIdLst, out string strResult, out string strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelQxUserMenuDetails(List<string> arrmId)
{
string strAction = "DelQxUserMenuDetails";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrmId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelQxUserMenuDetailsByCond(string strWhereCond)
{
string strAction = "DelQxUserMenuDetailsByCond";
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool AddNewRecord(clsQxUserMenuDetailEN objQxUserMenuDetailEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxUserMenuDetailEN>(objQxUserMenuDetailEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsQxUserMenuDetailEN objQxUserMenuDetailEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxUserMenuDetailEN>(objQxUserMenuDetailEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsQxUserMenuDetailEN objQxUserMenuDetailEN)
{
if (string.IsNullOrEmpty(objQxUserMenuDetailEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objQxUserMenuDetailEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxUserMenuDetailEN>(objQxUserMenuDetailEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateWithCondition)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsQxUserMenuDetailEN objQxUserMenuDetailEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objQxUserMenuDetailEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objQxUserMenuDetailEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objQxUserMenuDetailEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxUserMenuDetailEN>(objQxUserMenuDetailEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
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
 /// 根据条件设置字段值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_funSetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int SetFldValue(string strFldName, string strValue, string strWhereCond)
{
string strAction = "SetFldValue";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strValue"] = strValue,
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
string strMsg = string.Format("根据条件设置字段值,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取字符串长度,其中汉字为2个字节,英文为1个字节
 /// (AutoGCLib.clsGeneCodeBase:GengetStrLen)
 /// </summary>
 /// <param name = "strTemp">给定的原字符串</param>
 /// <returns>返回字符串长度</returns>
public static int GetStrLen(string strTemp)
{
int len ;
byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
len = sarr.Length;//will output as 3+3*2 = 9
return len;
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objQxUserMenuDetailENS">源对象</param>
 /// <param name = "objQxUserMenuDetailENT">目标对象</param>
 public static void CopyTo(clsQxUserMenuDetailEN objQxUserMenuDetailENS, clsQxUserMenuDetailEN objQxUserMenuDetailENT)
{
try
{
objQxUserMenuDetailENT.mId = objQxUserMenuDetailENS.mId; //流水号
objQxUserMenuDetailENT.MenuId = objQxUserMenuDetailENS.MenuId; //菜单Id
objQxUserMenuDetailENT.MenuName = objQxUserMenuDetailENS.MenuName; //菜单名
objQxUserMenuDetailENT.IsDisp = objQxUserMenuDetailENS.IsDisp; //是否显示
objQxUserMenuDetailENT.UpMenuId = objQxUserMenuDetailENS.UpMenuId; //上级菜单Id
objQxUserMenuDetailENT.LinkFile = objQxUserMenuDetailENS.LinkFile; //链接文件
objQxUserMenuDetailENT.ImgFile = objQxUserMenuDetailENS.ImgFile; //图像文件
objQxUserMenuDetailENT.IsCustomMenu = objQxUserMenuDetailENS.IsCustomMenu; //是否定制菜单
objQxUserMenuDetailENT.UserId = objQxUserMenuDetailENS.UserId; //用户ID
objQxUserMenuDetailENT.QxPrjId = objQxUserMenuDetailENS.QxPrjId; //项目Id
objQxUserMenuDetailENT.OrderNum = objQxUserMenuDetailENS.OrderNum; //排序号
objQxUserMenuDetailENT.Memo = objQxUserMenuDetailENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsQxUserMenuDetailEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsQxUserMenuDetailEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsQxUserMenuDetailEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsQxUserMenuDetailEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsQxUserMenuDetailEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsQxUserMenuDetailEN.AttributeName)
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
string strKey = string.Format("{0}", clsQxUserMenuDetailEN._CurrTabName);
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

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsQxUserMenuDetailWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsQxUserMenuDetailEN._CurrTabName);
CacheHelper.Remove(strKey);
clsQxUserMenuDetailWApi.objCommFun4WApi.ReFreshCache();
}
}
//该表没有使用Cache,不需要生成[GetObjLstCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsQxUserMenuDetailEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conQxUserMenuDetail.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(conQxUserMenuDetail.MenuId, Type.GetType("System.String"));
objDT.Columns.Add(conQxUserMenuDetail.MenuName, Type.GetType("System.String"));
objDT.Columns.Add(conQxUserMenuDetail.IsDisp, Type.GetType("System.Boolean"));
objDT.Columns.Add(conQxUserMenuDetail.UpMenuId, Type.GetType("System.String"));
objDT.Columns.Add(conQxUserMenuDetail.LinkFile, Type.GetType("System.String"));
objDT.Columns.Add(conQxUserMenuDetail.ImgFile, Type.GetType("System.String"));
objDT.Columns.Add(conQxUserMenuDetail.IsCustomMenu, Type.GetType("System.Boolean"));
objDT.Columns.Add(conQxUserMenuDetail.UserId, Type.GetType("System.String"));
objDT.Columns.Add(conQxUserMenuDetail.QxPrjId, Type.GetType("System.String"));
objDT.Columns.Add(conQxUserMenuDetail.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conQxUserMenuDetail.Memo, Type.GetType("System.String"));
foreach (clsQxUserMenuDetailEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conQxUserMenuDetail.mId] = objInFor[conQxUserMenuDetail.mId];
objDR[conQxUserMenuDetail.MenuId] = objInFor[conQxUserMenuDetail.MenuId];
objDR[conQxUserMenuDetail.MenuName] = objInFor[conQxUserMenuDetail.MenuName];
objDR[conQxUserMenuDetail.IsDisp] = objInFor[conQxUserMenuDetail.IsDisp];
objDR[conQxUserMenuDetail.UpMenuId] = objInFor[conQxUserMenuDetail.UpMenuId];
objDR[conQxUserMenuDetail.LinkFile] = objInFor[conQxUserMenuDetail.LinkFile];
objDR[conQxUserMenuDetail.ImgFile] = objInFor[conQxUserMenuDetail.ImgFile];
objDR[conQxUserMenuDetail.IsCustomMenu] = objInFor[conQxUserMenuDetail.IsCustomMenu];
objDR[conQxUserMenuDetail.UserId] = objInFor[conQxUserMenuDetail.UserId];
objDR[conQxUserMenuDetail.QxPrjId] = objInFor[conQxUserMenuDetail.QxPrjId];
objDR[conQxUserMenuDetail.OrderNum] = objInFor[conQxUserMenuDetail.OrderNum];
objDR[conQxUserMenuDetail.Memo] = objInFor[conQxUserMenuDetail.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 用户菜单(QxUserMenuDetail)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4QxUserMenuDetail : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache()
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == false)
{
strMsg = string.Format("刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3));
clsSysParaEN.objLog.WriteDebugLog(strMsg);
return;
}
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserMenuDetailWApi.ReFreshThisCache();
}
}

}