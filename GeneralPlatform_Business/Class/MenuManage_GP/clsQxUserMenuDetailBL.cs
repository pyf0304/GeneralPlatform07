
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUserMenuDetailBL
 表名:QxUserMenuDetail(00140011)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:22:11
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
public static class  clsQxUserMenuDetailBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxUserMenuDetailEN GetObj(this K_mId_QxUserMenuDetail myKey)
{
clsQxUserMenuDetailEN objQxUserMenuDetailEN = clsQxUserMenuDetailBL.QxUserMenuDetailDA.GetObjBymId(myKey.Value);
return objQxUserMenuDetailEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQxUserMenuDetailEN objQxUserMenuDetailEN)
{
if (CheckUniqueness(objQxUserMenuDetailEN) == false)
{
var strMsg = string.Format("记录已经存在!用户ID = [{0}],菜单Id = [{1}]的数据已经存在!(in clsQxUserMenuDetailBL.AddNewRecord)", objQxUserMenuDetailEN.UserId,objQxUserMenuDetailEN.MenuId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsQxUserMenuDetailBL.QxUserMenuDetailDA.AddNewRecordBySQL2(objQxUserMenuDetailEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserMenuDetailBL.ReFreshCache();

if (clsQxUserMenuDetailBL.relatedActions != null)
{
clsQxUserMenuDetailBL.relatedActions.UpdRelaTabDate(objQxUserMenuDetailEN.mId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000082)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 插入记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddRecordEx)
 /// </summary>
 /// <returns>插入记录是否成功？</returns>
public static bool AddRecordEx(this clsQxUserMenuDetailEN objQxUserMenuDetailEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
try
{
 //2、检查传进去的对象属性是否合法
objQxUserMenuDetailEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objQxUserMenuDetailEN.CheckUniqueness() == false)
{
strMsg = string.Format("(用户ID(UserId)=[{0}],菜单Id(MenuId)=[{1}])已经存在,不能重复!", objQxUserMenuDetailEN.UserId, objQxUserMenuDetailEN.MenuId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objQxUserMenuDetailEN.AddNewRecord();
}
catch(Exception objException)
{
strMsg = "(errid:Busi000152)添加记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsQxUserMenuDetailEN objQxUserMenuDetailEN)
{
if (CheckUniqueness(objQxUserMenuDetailEN) == false)
{
var strMsg = string.Format("记录已经存在!用户ID = [{0}],菜单Id = [{1}]的数据已经存在!(in clsQxUserMenuDetailBL.AddNewRecordWithReturnKey)", objQxUserMenuDetailEN.UserId,objQxUserMenuDetailEN.MenuId);
throw new Exception(strMsg);
}
try
{
string strKey = clsQxUserMenuDetailBL.QxUserMenuDetailDA.AddNewRecordBySQL2WithReturnKey(objQxUserMenuDetailEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserMenuDetailBL.ReFreshCache();

if (clsQxUserMenuDetailBL.relatedActions != null)
{
clsQxUserMenuDetailBL.relatedActions.UpdRelaTabDate(objQxUserMenuDetailEN.mId, "SetUpdDate");
}
return strKey;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000091)带返回值的添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserMenuDetailEN SetMenuId(this clsQxUserMenuDetailEN objQxUserMenuDetailEN, string strMenuId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMenuId, conQxUserMenuDetail.MenuId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuId, 8, conQxUserMenuDetail.MenuId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMenuId, 8, conQxUserMenuDetail.MenuId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserMenuDetailEN SetMenuName(this clsQxUserMenuDetailEN objQxUserMenuDetailEN, string strMenuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMenuName, conQxUserMenuDetail.MenuName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuName, 50, conQxUserMenuDetail.MenuName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserMenuDetailEN SetUpMenuId(this clsQxUserMenuDetailEN objQxUserMenuDetailEN, string strUpMenuId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpMenuId, 8, conQxUserMenuDetail.UpMenuId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUpMenuId, 8, conQxUserMenuDetail.UpMenuId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserMenuDetailEN SetLinkFile(this clsQxUserMenuDetailEN objQxUserMenuDetailEN, string strLinkFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLinkFile, 500, conQxUserMenuDetail.LinkFile);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserMenuDetailEN SetImgFile(this clsQxUserMenuDetailEN objQxUserMenuDetailEN, string strImgFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strImgFile, 300, conQxUserMenuDetail.ImgFile);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserMenuDetailEN SetUserId(this clsQxUserMenuDetailEN objQxUserMenuDetailEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, conQxUserMenuDetail.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conQxUserMenuDetail.UserId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserMenuDetailEN SetQxPrjId(this clsQxUserMenuDetailEN objQxUserMenuDetailEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, conQxUserMenuDetail.QxPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQxPrjId, 4, conQxUserMenuDetail.QxPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, conQxUserMenuDetail.QxPrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserMenuDetailEN SetMemo(this clsQxUserMenuDetailEN objQxUserMenuDetailEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQxUserMenuDetail.Memo);
}
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
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsQxUserMenuDetailEN objQxUserMenuDetailEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objQxUserMenuDetailEN.CheckPropertyNew();
clsQxUserMenuDetailEN objQxUserMenuDetailCond = new clsQxUserMenuDetailEN();
string strCondition = objQxUserMenuDetailCond
.SetmId(objQxUserMenuDetailEN.mId, "<>")
.SetUserId(objQxUserMenuDetailEN.UserId, "=")
.SetMenuId(objQxUserMenuDetailEN.MenuId, "=")
.GetCombineCondition();
objQxUserMenuDetailEN._IsCheckProperty = true;
bool bolIsExist = clsQxUserMenuDetailBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(UserId_MenuId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objQxUserMenuDetailEN.Update();
}
catch(Exception objException)
{
strMsg = "修改记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true; 
}

 /// <summary>
 /// 编辑记录存盘到数据表中。如果存在相关记录就修改,不存在就添加
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_EditRecordEx)
 /// </summary>
 /// <param name = "objQxUserMenuDetail">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsQxUserMenuDetailEN objQxUserMenuDetail)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsQxUserMenuDetailEN objQxUserMenuDetailCond = new clsQxUserMenuDetailEN();
string strCondition = objQxUserMenuDetailCond
.SetUserId(objQxUserMenuDetail.UserId, "=")
.SetMenuId(objQxUserMenuDetail.MenuId, "=")
.GetCombineCondition();
objQxUserMenuDetail._IsCheckProperty = true;
bool bolIsExist = clsQxUserMenuDetailBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objQxUserMenuDetail.mId = clsQxUserMenuDetailBL.GetFirstID_S(strCondition);
objQxUserMenuDetail.UpdateWithCondition(strCondition);
}
else
{
objQxUserMenuDetail.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxUserMenuDetailEN objQxUserMenuDetailEN)
{
 if (objQxUserMenuDetailEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxUserMenuDetailBL.QxUserMenuDetailDA.UpdateBySql2(objQxUserMenuDetailEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserMenuDetailBL.ReFreshCache();

if (clsQxUserMenuDetailBL.relatedActions != null)
{
clsQxUserMenuDetailBL.relatedActions.UpdRelaTabDate(objQxUserMenuDetailEN.mId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000083)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式.(带事务处理)
 /// /// 优点:1、能够处理字段中的单撇问题；
 /// /// 2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库;
 /// /// 3、支持事务处理.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateWithTransaction)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxUserMenuDetailEN objQxUserMenuDetailEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objQxUserMenuDetailEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxUserMenuDetailBL.QxUserMenuDetailDA.UpdateBySql2(objQxUserMenuDetailEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserMenuDetailBL.ReFreshCache();

if (clsQxUserMenuDetailBL.relatedActions != null)
{
clsQxUserMenuDetailBL.relatedActions.UpdRelaTabDate(objQxUserMenuDetailEN.mId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000088)修改记录出错,{1}.(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxUserMenuDetailEN objQxUserMenuDetailEN, string strWhereCond)
{
try
{
bool bolResult = clsQxUserMenuDetailBL.QxUserMenuDetailDA.UpdateBySqlWithCondition(objQxUserMenuDetailEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserMenuDetailBL.ReFreshCache();

if (clsQxUserMenuDetailBL.relatedActions != null)
{
clsQxUserMenuDetailBL.relatedActions.UpdRelaTabDate(objQxUserMenuDetailEN.mId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000089)根据条件修改记录出错, {1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录.(带事务处理)
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateWithConditionTransaction)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxUserMenuDetailEN objQxUserMenuDetailEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsQxUserMenuDetailBL.QxUserMenuDetailDA.UpdateBySqlWithConditionTransaction(objQxUserMenuDetailEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserMenuDetailBL.ReFreshCache();

if (clsQxUserMenuDetailBL.relatedActions != null)
{
clsQxUserMenuDetailBL.relatedActions.UpdRelaTabDate(objQxUserMenuDetailEN.mId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000090)根据条件修改记录出错!(带事务处理),{1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Delete)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsQxUserMenuDetailEN objQxUserMenuDetailEN)
{
try
{
int intRecNum = clsQxUserMenuDetailBL.QxUserMenuDetailDA.DelRecord(objQxUserMenuDetailEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserMenuDetailBL.ReFreshCache();

if (clsQxUserMenuDetailBL.relatedActions != null)
{
clsQxUserMenuDetailBL.relatedActions.UpdRelaTabDate(objQxUserMenuDetailEN.mId, "SetUpdDate");
}
return intRecNum;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000084)根据关键字删除记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objQxUserMenuDetailENS">源对象</param>
 /// <param name = "objQxUserMenuDetailENT">目标对象</param>
 public static void CopyTo(this clsQxUserMenuDetailEN objQxUserMenuDetailENS, clsQxUserMenuDetailEN objQxUserMenuDetailENT)
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
 /// <param name = "objQxUserMenuDetailENS">源对象</param>
 /// <returns>目标对象=>clsQxUserMenuDetailEN:objQxUserMenuDetailENT</returns>
 public static clsQxUserMenuDetailEN CopyTo(this clsQxUserMenuDetailEN objQxUserMenuDetailENS)
{
try
{
 clsQxUserMenuDetailEN objQxUserMenuDetailENT = new clsQxUserMenuDetailEN()
{
mId = objQxUserMenuDetailENS.mId, //流水号
MenuId = objQxUserMenuDetailENS.MenuId, //菜单Id
MenuName = objQxUserMenuDetailENS.MenuName, //菜单名
IsDisp = objQxUserMenuDetailENS.IsDisp, //是否显示
UpMenuId = objQxUserMenuDetailENS.UpMenuId, //上级菜单Id
LinkFile = objQxUserMenuDetailENS.LinkFile, //链接文件
ImgFile = objQxUserMenuDetailENS.ImgFile, //图像文件
IsCustomMenu = objQxUserMenuDetailENS.IsCustomMenu, //是否定制菜单
UserId = objQxUserMenuDetailENS.UserId, //用户ID
QxPrjId = objQxUserMenuDetailENS.QxPrjId, //项目Id
OrderNum = objQxUserMenuDetailENS.OrderNum, //排序号
Memo = objQxUserMenuDetailENS.Memo, //备注
};
 return objQxUserMenuDetailENT;
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
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(this clsQxUserMenuDetailEN objQxUserMenuDetailEN)
{
 clsQxUserMenuDetailBL.QxUserMenuDetailDA.CheckPropertyNew(objQxUserMenuDetailEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsQxUserMenuDetailEN objQxUserMenuDetailEN)
{
 clsQxUserMenuDetailBL.QxUserMenuDetailDA.CheckProperty4Condition(objQxUserMenuDetailEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// 检查唯一性(Uniqueness)--QxUserMenuDetail(用户菜单), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:UserId_MenuId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsQxUserMenuDetailEN objQxUserMenuDetailEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objQxUserMenuDetailEN == null) return true;
if (objQxUserMenuDetailEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and UserId = '{0}'", objQxUserMenuDetailEN.UserId);
 sbCondition.AppendFormat(" and MenuId = '{0}'", objQxUserMenuDetailEN.MenuId);
if (clsQxUserMenuDetailBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objQxUserMenuDetailEN.mId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objQxUserMenuDetailEN.UserId);
 sbCondition.AppendFormat(" and MenuId = '{0}'", objQxUserMenuDetailEN.MenuId);
if (clsQxUserMenuDetailBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
return bolIsUniqueness;
}

 /// <summary>
 /// 获取唯一性条件串--QxUserMenuDetail(用户菜单), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:UserId_MenuId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsQxUserMenuDetailEN objQxUserMenuDetailEN)
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
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_QxUserMenuDetail
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 用户菜单(QxUserMenuDetail)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsQxUserMenuDetailBL
{
public static RelatedActions_QxUserMenuDetail relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "QxUserMenuDetailListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "QxUserMenuDetailList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsQxUserMenuDetailEN> arrQxUserMenuDetailObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsQxUserMenuDetailDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsQxUserMenuDetailDA QxUserMenuDetailDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsQxUserMenuDetailDA();
}
return uniqueInstance;
}
}

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsQxUserMenuDetailBL()
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
if (string.IsNullOrEmpty(clsQxUserMenuDetailEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxUserMenuDetailEN._ConnectString);
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
objDS = QxUserMenuDetailDA.GetDataSet(strWhereCond);
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
objDS = QxUserMenuDetailDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = QxUserMenuDetailDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_QxUserMenuDetail(string strWhereCond)
{
DataTable objDT;
try
{
objDT = QxUserMenuDetailDA.GetDataTable_QxUserMenuDetail(strWhereCond);
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
objDT = QxUserMenuDetailDA.GetDataTable(strWhereCond);
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
objDT = QxUserMenuDetailDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = QxUserMenuDetailDA.GetDataTable(strWhereCond, strTabName);
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
objDT = QxUserMenuDetailDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = QxUserMenuDetailDA.GetDataTable_Top(objTopPara);
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
objDT = QxUserMenuDetailDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = QxUserMenuDetailDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = QxUserMenuDetailDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = QxUserMenuDetailDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = QxUserMenuDetailDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = QxUserMenuDetailDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = QxUserMenuDetailDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = QxUserMenuDetailDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
public static List<clsQxUserMenuDetailEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsQxUserMenuDetailEN> arrObjLst = new List<clsQxUserMenuDetailEN>(); 
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
	clsQxUserMenuDetailEN objQxUserMenuDetailEN = new clsQxUserMenuDetailEN();
try
{
objQxUserMenuDetailEN.mId = Int32.Parse(objRow[conQxUserMenuDetail.mId].ToString().Trim()); //流水号
objQxUserMenuDetailEN.MenuId = objRow[conQxUserMenuDetail.MenuId].ToString().Trim(); //菜单Id
objQxUserMenuDetailEN.MenuName = objRow[conQxUserMenuDetail.MenuName].ToString().Trim(); //菜单名
objQxUserMenuDetailEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[conQxUserMenuDetail.IsDisp].ToString().Trim()); //是否显示
objQxUserMenuDetailEN.UpMenuId = objRow[conQxUserMenuDetail.UpMenuId] == DBNull.Value ? null : objRow[conQxUserMenuDetail.UpMenuId].ToString().Trim(); //上级菜单Id
objQxUserMenuDetailEN.LinkFile = objRow[conQxUserMenuDetail.LinkFile] == DBNull.Value ? null : objRow[conQxUserMenuDetail.LinkFile].ToString().Trim(); //链接文件
objQxUserMenuDetailEN.ImgFile = objRow[conQxUserMenuDetail.ImgFile] == DBNull.Value ? null : objRow[conQxUserMenuDetail.ImgFile].ToString().Trim(); //图像文件
objQxUserMenuDetailEN.IsCustomMenu = clsEntityBase2.TransNullToBool_S(objRow[conQxUserMenuDetail.IsCustomMenu].ToString().Trim()); //是否定制菜单
objQxUserMenuDetailEN.UserId = objRow[conQxUserMenuDetail.UserId].ToString().Trim(); //用户ID
objQxUserMenuDetailEN.QxPrjId = objRow[conQxUserMenuDetail.QxPrjId].ToString().Trim(); //项目Id
objQxUserMenuDetailEN.OrderNum = Int32.Parse(objRow[conQxUserMenuDetail.OrderNum].ToString().Trim()); //排序号
objQxUserMenuDetailEN.Memo = objRow[conQxUserMenuDetail.Memo] == DBNull.Value ? null : objRow[conQxUserMenuDetail.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserMenuDetailEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserMenuDetailEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsQxUserMenuDetailEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsQxUserMenuDetailEN._CurrTabName);
List<clsQxUserMenuDetailEN> arrQxUserMenuDetailObjLstCache = GetObjLstCache();
IEnumerable <clsQxUserMenuDetailEN> arrQxUserMenuDetailObjLst_Sel =
arrQxUserMenuDetailObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrQxUserMenuDetailObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUserMenuDetailEN> GetObjLst(string strWhereCond)
{
List<clsQxUserMenuDetailEN> arrObjLst = new List<clsQxUserMenuDetailEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserMenuDetailEN objQxUserMenuDetailEN = new clsQxUserMenuDetailEN();
try
{
objQxUserMenuDetailEN.mId = Int32.Parse(objRow[conQxUserMenuDetail.mId].ToString().Trim()); //流水号
objQxUserMenuDetailEN.MenuId = objRow[conQxUserMenuDetail.MenuId].ToString().Trim(); //菜单Id
objQxUserMenuDetailEN.MenuName = objRow[conQxUserMenuDetail.MenuName].ToString().Trim(); //菜单名
objQxUserMenuDetailEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[conQxUserMenuDetail.IsDisp].ToString().Trim()); //是否显示
objQxUserMenuDetailEN.UpMenuId = objRow[conQxUserMenuDetail.UpMenuId] == DBNull.Value ? null : objRow[conQxUserMenuDetail.UpMenuId].ToString().Trim(); //上级菜单Id
objQxUserMenuDetailEN.LinkFile = objRow[conQxUserMenuDetail.LinkFile] == DBNull.Value ? null : objRow[conQxUserMenuDetail.LinkFile].ToString().Trim(); //链接文件
objQxUserMenuDetailEN.ImgFile = objRow[conQxUserMenuDetail.ImgFile] == DBNull.Value ? null : objRow[conQxUserMenuDetail.ImgFile].ToString().Trim(); //图像文件
objQxUserMenuDetailEN.IsCustomMenu = clsEntityBase2.TransNullToBool_S(objRow[conQxUserMenuDetail.IsCustomMenu].ToString().Trim()); //是否定制菜单
objQxUserMenuDetailEN.UserId = objRow[conQxUserMenuDetail.UserId].ToString().Trim(); //用户ID
objQxUserMenuDetailEN.QxPrjId = objRow[conQxUserMenuDetail.QxPrjId].ToString().Trim(); //项目Id
objQxUserMenuDetailEN.OrderNum = Int32.Parse(objRow[conQxUserMenuDetail.OrderNum].ToString().Trim()); //排序号
objQxUserMenuDetailEN.Memo = objRow[conQxUserMenuDetail.Memo] == DBNull.Value ? null : objRow[conQxUserMenuDetail.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserMenuDetailEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserMenuDetailEN);
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
public static List<clsQxUserMenuDetailEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsQxUserMenuDetailEN> arrObjLst = new List<clsQxUserMenuDetailEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserMenuDetailEN objQxUserMenuDetailEN = new clsQxUserMenuDetailEN();
try
{
objQxUserMenuDetailEN.mId = Int32.Parse(objRow[conQxUserMenuDetail.mId].ToString().Trim()); //流水号
objQxUserMenuDetailEN.MenuId = objRow[conQxUserMenuDetail.MenuId].ToString().Trim(); //菜单Id
objQxUserMenuDetailEN.MenuName = objRow[conQxUserMenuDetail.MenuName].ToString().Trim(); //菜单名
objQxUserMenuDetailEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[conQxUserMenuDetail.IsDisp].ToString().Trim()); //是否显示
objQxUserMenuDetailEN.UpMenuId = objRow[conQxUserMenuDetail.UpMenuId] == DBNull.Value ? null : objRow[conQxUserMenuDetail.UpMenuId].ToString().Trim(); //上级菜单Id
objQxUserMenuDetailEN.LinkFile = objRow[conQxUserMenuDetail.LinkFile] == DBNull.Value ? null : objRow[conQxUserMenuDetail.LinkFile].ToString().Trim(); //链接文件
objQxUserMenuDetailEN.ImgFile = objRow[conQxUserMenuDetail.ImgFile] == DBNull.Value ? null : objRow[conQxUserMenuDetail.ImgFile].ToString().Trim(); //图像文件
objQxUserMenuDetailEN.IsCustomMenu = clsEntityBase2.TransNullToBool_S(objRow[conQxUserMenuDetail.IsCustomMenu].ToString().Trim()); //是否定制菜单
objQxUserMenuDetailEN.UserId = objRow[conQxUserMenuDetail.UserId].ToString().Trim(); //用户ID
objQxUserMenuDetailEN.QxPrjId = objRow[conQxUserMenuDetail.QxPrjId].ToString().Trim(); //项目Id
objQxUserMenuDetailEN.OrderNum = Int32.Parse(objRow[conQxUserMenuDetail.OrderNum].ToString().Trim()); //排序号
objQxUserMenuDetailEN.Memo = objRow[conQxUserMenuDetail.Memo] == DBNull.Value ? null : objRow[conQxUserMenuDetail.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserMenuDetailEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserMenuDetailEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objQxUserMenuDetailCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsQxUserMenuDetailEN> GetSubObjLstCache(clsQxUserMenuDetailEN objQxUserMenuDetailCond)
{
List<clsQxUserMenuDetailEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxUserMenuDetailEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxUserMenuDetail.AttributeName)
{
if (objQxUserMenuDetailCond.IsUpdated(strFldName) == false) continue;
if (objQxUserMenuDetailCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUserMenuDetailCond[strFldName].ToString());
}
else
{
if (objQxUserMenuDetailCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxUserMenuDetailCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUserMenuDetailCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxUserMenuDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxUserMenuDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxUserMenuDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxUserMenuDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxUserMenuDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxUserMenuDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxUserMenuDetailCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxUserMenuDetailCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxUserMenuDetailCond[strFldName]));
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
public static List<clsQxUserMenuDetailEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsQxUserMenuDetailEN> arrObjLst = new List<clsQxUserMenuDetailEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserMenuDetailEN objQxUserMenuDetailEN = new clsQxUserMenuDetailEN();
try
{
objQxUserMenuDetailEN.mId = Int32.Parse(objRow[conQxUserMenuDetail.mId].ToString().Trim()); //流水号
objQxUserMenuDetailEN.MenuId = objRow[conQxUserMenuDetail.MenuId].ToString().Trim(); //菜单Id
objQxUserMenuDetailEN.MenuName = objRow[conQxUserMenuDetail.MenuName].ToString().Trim(); //菜单名
objQxUserMenuDetailEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[conQxUserMenuDetail.IsDisp].ToString().Trim()); //是否显示
objQxUserMenuDetailEN.UpMenuId = objRow[conQxUserMenuDetail.UpMenuId] == DBNull.Value ? null : objRow[conQxUserMenuDetail.UpMenuId].ToString().Trim(); //上级菜单Id
objQxUserMenuDetailEN.LinkFile = objRow[conQxUserMenuDetail.LinkFile] == DBNull.Value ? null : objRow[conQxUserMenuDetail.LinkFile].ToString().Trim(); //链接文件
objQxUserMenuDetailEN.ImgFile = objRow[conQxUserMenuDetail.ImgFile] == DBNull.Value ? null : objRow[conQxUserMenuDetail.ImgFile].ToString().Trim(); //图像文件
objQxUserMenuDetailEN.IsCustomMenu = clsEntityBase2.TransNullToBool_S(objRow[conQxUserMenuDetail.IsCustomMenu].ToString().Trim()); //是否定制菜单
objQxUserMenuDetailEN.UserId = objRow[conQxUserMenuDetail.UserId].ToString().Trim(); //用户ID
objQxUserMenuDetailEN.QxPrjId = objRow[conQxUserMenuDetail.QxPrjId].ToString().Trim(); //项目Id
objQxUserMenuDetailEN.OrderNum = Int32.Parse(objRow[conQxUserMenuDetail.OrderNum].ToString().Trim()); //排序号
objQxUserMenuDetailEN.Memo = objRow[conQxUserMenuDetail.Memo] == DBNull.Value ? null : objRow[conQxUserMenuDetail.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserMenuDetailEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserMenuDetailEN);
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
public static List<clsQxUserMenuDetailEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsQxUserMenuDetailEN> arrObjLst = new List<clsQxUserMenuDetailEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserMenuDetailEN objQxUserMenuDetailEN = new clsQxUserMenuDetailEN();
try
{
objQxUserMenuDetailEN.mId = Int32.Parse(objRow[conQxUserMenuDetail.mId].ToString().Trim()); //流水号
objQxUserMenuDetailEN.MenuId = objRow[conQxUserMenuDetail.MenuId].ToString().Trim(); //菜单Id
objQxUserMenuDetailEN.MenuName = objRow[conQxUserMenuDetail.MenuName].ToString().Trim(); //菜单名
objQxUserMenuDetailEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[conQxUserMenuDetail.IsDisp].ToString().Trim()); //是否显示
objQxUserMenuDetailEN.UpMenuId = objRow[conQxUserMenuDetail.UpMenuId] == DBNull.Value ? null : objRow[conQxUserMenuDetail.UpMenuId].ToString().Trim(); //上级菜单Id
objQxUserMenuDetailEN.LinkFile = objRow[conQxUserMenuDetail.LinkFile] == DBNull.Value ? null : objRow[conQxUserMenuDetail.LinkFile].ToString().Trim(); //链接文件
objQxUserMenuDetailEN.ImgFile = objRow[conQxUserMenuDetail.ImgFile] == DBNull.Value ? null : objRow[conQxUserMenuDetail.ImgFile].ToString().Trim(); //图像文件
objQxUserMenuDetailEN.IsCustomMenu = clsEntityBase2.TransNullToBool_S(objRow[conQxUserMenuDetail.IsCustomMenu].ToString().Trim()); //是否定制菜单
objQxUserMenuDetailEN.UserId = objRow[conQxUserMenuDetail.UserId].ToString().Trim(); //用户ID
objQxUserMenuDetailEN.QxPrjId = objRow[conQxUserMenuDetail.QxPrjId].ToString().Trim(); //项目Id
objQxUserMenuDetailEN.OrderNum = Int32.Parse(objRow[conQxUserMenuDetail.OrderNum].ToString().Trim()); //排序号
objQxUserMenuDetailEN.Memo = objRow[conQxUserMenuDetail.Memo] == DBNull.Value ? null : objRow[conQxUserMenuDetail.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserMenuDetailEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserMenuDetailEN);
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
List<clsQxUserMenuDetailEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsQxUserMenuDetailEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUserMenuDetailEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsQxUserMenuDetailEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsQxUserMenuDetailEN> arrObjLst = new List<clsQxUserMenuDetailEN>(); 
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
	clsQxUserMenuDetailEN objQxUserMenuDetailEN = new clsQxUserMenuDetailEN();
try
{
objQxUserMenuDetailEN.mId = Int32.Parse(objRow[conQxUserMenuDetail.mId].ToString().Trim()); //流水号
objQxUserMenuDetailEN.MenuId = objRow[conQxUserMenuDetail.MenuId].ToString().Trim(); //菜单Id
objQxUserMenuDetailEN.MenuName = objRow[conQxUserMenuDetail.MenuName].ToString().Trim(); //菜单名
objQxUserMenuDetailEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[conQxUserMenuDetail.IsDisp].ToString().Trim()); //是否显示
objQxUserMenuDetailEN.UpMenuId = objRow[conQxUserMenuDetail.UpMenuId] == DBNull.Value ? null : objRow[conQxUserMenuDetail.UpMenuId].ToString().Trim(); //上级菜单Id
objQxUserMenuDetailEN.LinkFile = objRow[conQxUserMenuDetail.LinkFile] == DBNull.Value ? null : objRow[conQxUserMenuDetail.LinkFile].ToString().Trim(); //链接文件
objQxUserMenuDetailEN.ImgFile = objRow[conQxUserMenuDetail.ImgFile] == DBNull.Value ? null : objRow[conQxUserMenuDetail.ImgFile].ToString().Trim(); //图像文件
objQxUserMenuDetailEN.IsCustomMenu = clsEntityBase2.TransNullToBool_S(objRow[conQxUserMenuDetail.IsCustomMenu].ToString().Trim()); //是否定制菜单
objQxUserMenuDetailEN.UserId = objRow[conQxUserMenuDetail.UserId].ToString().Trim(); //用户ID
objQxUserMenuDetailEN.QxPrjId = objRow[conQxUserMenuDetail.QxPrjId].ToString().Trim(); //项目Id
objQxUserMenuDetailEN.OrderNum = Int32.Parse(objRow[conQxUserMenuDetail.OrderNum].ToString().Trim()); //排序号
objQxUserMenuDetailEN.Memo = objRow[conQxUserMenuDetail.Memo] == DBNull.Value ? null : objRow[conQxUserMenuDetail.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserMenuDetailEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserMenuDetailEN);
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
public static List<clsQxUserMenuDetailEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsQxUserMenuDetailEN> arrObjLst = new List<clsQxUserMenuDetailEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserMenuDetailEN objQxUserMenuDetailEN = new clsQxUserMenuDetailEN();
try
{
objQxUserMenuDetailEN.mId = Int32.Parse(objRow[conQxUserMenuDetail.mId].ToString().Trim()); //流水号
objQxUserMenuDetailEN.MenuId = objRow[conQxUserMenuDetail.MenuId].ToString().Trim(); //菜单Id
objQxUserMenuDetailEN.MenuName = objRow[conQxUserMenuDetail.MenuName].ToString().Trim(); //菜单名
objQxUserMenuDetailEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[conQxUserMenuDetail.IsDisp].ToString().Trim()); //是否显示
objQxUserMenuDetailEN.UpMenuId = objRow[conQxUserMenuDetail.UpMenuId] == DBNull.Value ? null : objRow[conQxUserMenuDetail.UpMenuId].ToString().Trim(); //上级菜单Id
objQxUserMenuDetailEN.LinkFile = objRow[conQxUserMenuDetail.LinkFile] == DBNull.Value ? null : objRow[conQxUserMenuDetail.LinkFile].ToString().Trim(); //链接文件
objQxUserMenuDetailEN.ImgFile = objRow[conQxUserMenuDetail.ImgFile] == DBNull.Value ? null : objRow[conQxUserMenuDetail.ImgFile].ToString().Trim(); //图像文件
objQxUserMenuDetailEN.IsCustomMenu = clsEntityBase2.TransNullToBool_S(objRow[conQxUserMenuDetail.IsCustomMenu].ToString().Trim()); //是否定制菜单
objQxUserMenuDetailEN.UserId = objRow[conQxUserMenuDetail.UserId].ToString().Trim(); //用户ID
objQxUserMenuDetailEN.QxPrjId = objRow[conQxUserMenuDetail.QxPrjId].ToString().Trim(); //项目Id
objQxUserMenuDetailEN.OrderNum = Int32.Parse(objRow[conQxUserMenuDetail.OrderNum].ToString().Trim()); //排序号
objQxUserMenuDetailEN.Memo = objRow[conQxUserMenuDetail.Memo] == DBNull.Value ? null : objRow[conQxUserMenuDetail.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserMenuDetailEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserMenuDetailEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsQxUserMenuDetailEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsQxUserMenuDetailEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsQxUserMenuDetailEN> arrObjLst = new List<clsQxUserMenuDetailEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserMenuDetailEN objQxUserMenuDetailEN = new clsQxUserMenuDetailEN();
try
{
objQxUserMenuDetailEN.mId = Int32.Parse(objRow[conQxUserMenuDetail.mId].ToString().Trim()); //流水号
objQxUserMenuDetailEN.MenuId = objRow[conQxUserMenuDetail.MenuId].ToString().Trim(); //菜单Id
objQxUserMenuDetailEN.MenuName = objRow[conQxUserMenuDetail.MenuName].ToString().Trim(); //菜单名
objQxUserMenuDetailEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[conQxUserMenuDetail.IsDisp].ToString().Trim()); //是否显示
objQxUserMenuDetailEN.UpMenuId = objRow[conQxUserMenuDetail.UpMenuId] == DBNull.Value ? null : objRow[conQxUserMenuDetail.UpMenuId].ToString().Trim(); //上级菜单Id
objQxUserMenuDetailEN.LinkFile = objRow[conQxUserMenuDetail.LinkFile] == DBNull.Value ? null : objRow[conQxUserMenuDetail.LinkFile].ToString().Trim(); //链接文件
objQxUserMenuDetailEN.ImgFile = objRow[conQxUserMenuDetail.ImgFile] == DBNull.Value ? null : objRow[conQxUserMenuDetail.ImgFile].ToString().Trim(); //图像文件
objQxUserMenuDetailEN.IsCustomMenu = clsEntityBase2.TransNullToBool_S(objRow[conQxUserMenuDetail.IsCustomMenu].ToString().Trim()); //是否定制菜单
objQxUserMenuDetailEN.UserId = objRow[conQxUserMenuDetail.UserId].ToString().Trim(); //用户ID
objQxUserMenuDetailEN.QxPrjId = objRow[conQxUserMenuDetail.QxPrjId].ToString().Trim(); //项目Id
objQxUserMenuDetailEN.OrderNum = Int32.Parse(objRow[conQxUserMenuDetail.OrderNum].ToString().Trim()); //排序号
objQxUserMenuDetailEN.Memo = objRow[conQxUserMenuDetail.Memo] == DBNull.Value ? null : objRow[conQxUserMenuDetail.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserMenuDetailEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserMenuDetailEN);
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
public static List<clsQxUserMenuDetailEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsQxUserMenuDetailEN> arrObjLst = new List<clsQxUserMenuDetailEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserMenuDetailEN objQxUserMenuDetailEN = new clsQxUserMenuDetailEN();
try
{
objQxUserMenuDetailEN.mId = Int32.Parse(objRow[conQxUserMenuDetail.mId].ToString().Trim()); //流水号
objQxUserMenuDetailEN.MenuId = objRow[conQxUserMenuDetail.MenuId].ToString().Trim(); //菜单Id
objQxUserMenuDetailEN.MenuName = objRow[conQxUserMenuDetail.MenuName].ToString().Trim(); //菜单名
objQxUserMenuDetailEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[conQxUserMenuDetail.IsDisp].ToString().Trim()); //是否显示
objQxUserMenuDetailEN.UpMenuId = objRow[conQxUserMenuDetail.UpMenuId] == DBNull.Value ? null : objRow[conQxUserMenuDetail.UpMenuId].ToString().Trim(); //上级菜单Id
objQxUserMenuDetailEN.LinkFile = objRow[conQxUserMenuDetail.LinkFile] == DBNull.Value ? null : objRow[conQxUserMenuDetail.LinkFile].ToString().Trim(); //链接文件
objQxUserMenuDetailEN.ImgFile = objRow[conQxUserMenuDetail.ImgFile] == DBNull.Value ? null : objRow[conQxUserMenuDetail.ImgFile].ToString().Trim(); //图像文件
objQxUserMenuDetailEN.IsCustomMenu = clsEntityBase2.TransNullToBool_S(objRow[conQxUserMenuDetail.IsCustomMenu].ToString().Trim()); //是否定制菜单
objQxUserMenuDetailEN.UserId = objRow[conQxUserMenuDetail.UserId].ToString().Trim(); //用户ID
objQxUserMenuDetailEN.QxPrjId = objRow[conQxUserMenuDetail.QxPrjId].ToString().Trim(); //项目Id
objQxUserMenuDetailEN.OrderNum = Int32.Parse(objRow[conQxUserMenuDetail.OrderNum].ToString().Trim()); //排序号
objQxUserMenuDetailEN.Memo = objRow[conQxUserMenuDetail.Memo] == DBNull.Value ? null : objRow[conQxUserMenuDetail.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserMenuDetailEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserMenuDetailEN);
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
public static IEnumerable<clsQxUserMenuDetailEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsQxUserMenuDetailEN objQxUserMenuDetailCond, string strOrderBy)
{
List<clsQxUserMenuDetailEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxUserMenuDetailEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxUserMenuDetail.AttributeName)
{
if (objQxUserMenuDetailCond.IsUpdated(strFldName) == false) continue;
if (objQxUserMenuDetailCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUserMenuDetailCond[strFldName].ToString());
}
else
{
if (objQxUserMenuDetailCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxUserMenuDetailCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUserMenuDetailCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxUserMenuDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxUserMenuDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxUserMenuDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxUserMenuDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxUserMenuDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxUserMenuDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxUserMenuDetailCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxUserMenuDetailCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxUserMenuDetailCond[strFldName]));
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
public static IEnumerable<clsQxUserMenuDetailEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsQxUserMenuDetailEN objQxUserMenuDetailCond = JsonConvert.DeserializeObject<clsQxUserMenuDetailEN>(objPagerPara.whereCond);
if (objQxUserMenuDetailCond.sfFldComparisonOp == null)
{
objQxUserMenuDetailCond.dicFldComparisonOp = null;
}
else
{
objQxUserMenuDetailCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objQxUserMenuDetailCond.sfFldComparisonOp);
}
clsQxUserMenuDetailBL.SetUpdFlag(objQxUserMenuDetailCond);
 try
{
CheckProperty4Condition(objQxUserMenuDetailCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsQxUserMenuDetailBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objQxUserMenuDetailCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUserMenuDetailEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsQxUserMenuDetailEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsQxUserMenuDetailEN> arrObjLst = new List<clsQxUserMenuDetailEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserMenuDetailEN objQxUserMenuDetailEN = new clsQxUserMenuDetailEN();
try
{
objQxUserMenuDetailEN.mId = Int32.Parse(objRow[conQxUserMenuDetail.mId].ToString().Trim()); //流水号
objQxUserMenuDetailEN.MenuId = objRow[conQxUserMenuDetail.MenuId].ToString().Trim(); //菜单Id
objQxUserMenuDetailEN.MenuName = objRow[conQxUserMenuDetail.MenuName].ToString().Trim(); //菜单名
objQxUserMenuDetailEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[conQxUserMenuDetail.IsDisp].ToString().Trim()); //是否显示
objQxUserMenuDetailEN.UpMenuId = objRow[conQxUserMenuDetail.UpMenuId] == DBNull.Value ? null : objRow[conQxUserMenuDetail.UpMenuId].ToString().Trim(); //上级菜单Id
objQxUserMenuDetailEN.LinkFile = objRow[conQxUserMenuDetail.LinkFile] == DBNull.Value ? null : objRow[conQxUserMenuDetail.LinkFile].ToString().Trim(); //链接文件
objQxUserMenuDetailEN.ImgFile = objRow[conQxUserMenuDetail.ImgFile] == DBNull.Value ? null : objRow[conQxUserMenuDetail.ImgFile].ToString().Trim(); //图像文件
objQxUserMenuDetailEN.IsCustomMenu = clsEntityBase2.TransNullToBool_S(objRow[conQxUserMenuDetail.IsCustomMenu].ToString().Trim()); //是否定制菜单
objQxUserMenuDetailEN.UserId = objRow[conQxUserMenuDetail.UserId].ToString().Trim(); //用户ID
objQxUserMenuDetailEN.QxPrjId = objRow[conQxUserMenuDetail.QxPrjId].ToString().Trim(); //项目Id
objQxUserMenuDetailEN.OrderNum = Int32.Parse(objRow[conQxUserMenuDetail.OrderNum].ToString().Trim()); //排序号
objQxUserMenuDetailEN.Memo = objRow[conQxUserMenuDetail.Memo] == DBNull.Value ? null : objRow[conQxUserMenuDetail.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserMenuDetailEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserMenuDetailEN);
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
public static List<clsQxUserMenuDetailEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsQxUserMenuDetailEN> arrObjLst = new List<clsQxUserMenuDetailEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserMenuDetailEN objQxUserMenuDetailEN = new clsQxUserMenuDetailEN();
try
{
objQxUserMenuDetailEN.mId = Int32.Parse(objRow[conQxUserMenuDetail.mId].ToString().Trim()); //流水号
objQxUserMenuDetailEN.MenuId = objRow[conQxUserMenuDetail.MenuId].ToString().Trim(); //菜单Id
objQxUserMenuDetailEN.MenuName = objRow[conQxUserMenuDetail.MenuName].ToString().Trim(); //菜单名
objQxUserMenuDetailEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[conQxUserMenuDetail.IsDisp].ToString().Trim()); //是否显示
objQxUserMenuDetailEN.UpMenuId = objRow[conQxUserMenuDetail.UpMenuId] == DBNull.Value ? null : objRow[conQxUserMenuDetail.UpMenuId].ToString().Trim(); //上级菜单Id
objQxUserMenuDetailEN.LinkFile = objRow[conQxUserMenuDetail.LinkFile] == DBNull.Value ? null : objRow[conQxUserMenuDetail.LinkFile].ToString().Trim(); //链接文件
objQxUserMenuDetailEN.ImgFile = objRow[conQxUserMenuDetail.ImgFile] == DBNull.Value ? null : objRow[conQxUserMenuDetail.ImgFile].ToString().Trim(); //图像文件
objQxUserMenuDetailEN.IsCustomMenu = clsEntityBase2.TransNullToBool_S(objRow[conQxUserMenuDetail.IsCustomMenu].ToString().Trim()); //是否定制菜单
objQxUserMenuDetailEN.UserId = objRow[conQxUserMenuDetail.UserId].ToString().Trim(); //用户ID
objQxUserMenuDetailEN.QxPrjId = objRow[conQxUserMenuDetail.QxPrjId].ToString().Trim(); //项目Id
objQxUserMenuDetailEN.OrderNum = Int32.Parse(objRow[conQxUserMenuDetail.OrderNum].ToString().Trim()); //排序号
objQxUserMenuDetailEN.Memo = objRow[conQxUserMenuDetail.Memo] == DBNull.Value ? null : objRow[conQxUserMenuDetail.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserMenuDetailEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserMenuDetailEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUserMenuDetailEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsQxUserMenuDetailEN> arrObjLst = new List<clsQxUserMenuDetailEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserMenuDetailEN objQxUserMenuDetailEN = new clsQxUserMenuDetailEN();
try
{
objQxUserMenuDetailEN.mId = Int32.Parse(objRow[conQxUserMenuDetail.mId].ToString().Trim()); //流水号
objQxUserMenuDetailEN.MenuId = objRow[conQxUserMenuDetail.MenuId].ToString().Trim(); //菜单Id
objQxUserMenuDetailEN.MenuName = objRow[conQxUserMenuDetail.MenuName].ToString().Trim(); //菜单名
objQxUserMenuDetailEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[conQxUserMenuDetail.IsDisp].ToString().Trim()); //是否显示
objQxUserMenuDetailEN.UpMenuId = objRow[conQxUserMenuDetail.UpMenuId] == DBNull.Value ? null : objRow[conQxUserMenuDetail.UpMenuId].ToString().Trim(); //上级菜单Id
objQxUserMenuDetailEN.LinkFile = objRow[conQxUserMenuDetail.LinkFile] == DBNull.Value ? null : objRow[conQxUserMenuDetail.LinkFile].ToString().Trim(); //链接文件
objQxUserMenuDetailEN.ImgFile = objRow[conQxUserMenuDetail.ImgFile] == DBNull.Value ? null : objRow[conQxUserMenuDetail.ImgFile].ToString().Trim(); //图像文件
objQxUserMenuDetailEN.IsCustomMenu = clsEntityBase2.TransNullToBool_S(objRow[conQxUserMenuDetail.IsCustomMenu].ToString().Trim()); //是否定制菜单
objQxUserMenuDetailEN.UserId = objRow[conQxUserMenuDetail.UserId].ToString().Trim(); //用户ID
objQxUserMenuDetailEN.QxPrjId = objRow[conQxUserMenuDetail.QxPrjId].ToString().Trim(); //项目Id
objQxUserMenuDetailEN.OrderNum = Int32.Parse(objRow[conQxUserMenuDetail.OrderNum].ToString().Trim()); //排序号
objQxUserMenuDetailEN.Memo = objRow[conQxUserMenuDetail.Memo] == DBNull.Value ? null : objRow[conQxUserMenuDetail.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserMenuDetailEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserMenuDetailEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxUserMenuDetail(ref clsQxUserMenuDetailEN objQxUserMenuDetailEN)
{
bool bolResult = QxUserMenuDetailDA.GetQxUserMenuDetail(ref objQxUserMenuDetailEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxUserMenuDetailEN GetObjBymId(long lngmId)
{
clsQxUserMenuDetailEN objQxUserMenuDetailEN = QxUserMenuDetailDA.GetObjBymId(lngmId);
return objQxUserMenuDetailEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsQxUserMenuDetailEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsQxUserMenuDetailEN objQxUserMenuDetailEN = QxUserMenuDetailDA.GetFirstObj(strWhereCond);
 return objQxUserMenuDetailEN;
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
public static clsQxUserMenuDetailEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsQxUserMenuDetailEN objQxUserMenuDetailEN = QxUserMenuDetailDA.GetObjByDataRow(objRow);
 return objQxUserMenuDetailEN;
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
public static clsQxUserMenuDetailEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsQxUserMenuDetailEN objQxUserMenuDetailEN = QxUserMenuDetailDA.GetObjByDataRow(objRow);
 return objQxUserMenuDetailEN;
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
 /// <param name = "lstQxUserMenuDetailObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxUserMenuDetailEN GetObjBymIdFromList(long lngmId, List<clsQxUserMenuDetailEN> lstQxUserMenuDetailObjLst)
{
foreach (clsQxUserMenuDetailEN objQxUserMenuDetailEN in lstQxUserMenuDetailObjLst)
{
if (objQxUserMenuDetailEN.mId == lngmId)
{
return objQxUserMenuDetailEN;
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
 lngmId = new clsQxUserMenuDetailDA().GetFirstID(strWhereCond);
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
 arrList = QxUserMenuDetailDA.GetID(strWhereCond);
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
bool bolIsExist = QxUserMenuDetailDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = QxUserMenuDetailDA.IsExist(lngmId);
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
 bolIsExist = clsQxUserMenuDetailDA.IsExistTable();
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
 bolIsExist = QxUserMenuDetailDA.IsExistTable(strTabName);
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


 #region 添加记录

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AddNewRecordBySql2)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsQxUserMenuDetailEN objQxUserMenuDetailEN)
{
if (objQxUserMenuDetailEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!用户ID = [{0}],菜单Id = [{1}]的数据已经存在!(in clsQxUserMenuDetailBL.AddNewRecordBySql2)", objQxUserMenuDetailEN.UserId,objQxUserMenuDetailEN.MenuId);
throw new Exception(strMsg);
}
try
{
bool bolResult = QxUserMenuDetailDA.AddNewRecordBySQL2(objQxUserMenuDetailEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserMenuDetailBL.ReFreshCache();

if (clsQxUserMenuDetailBL.relatedActions != null)
{
clsQxUserMenuDetailBL.relatedActions.UpdRelaTabDate(objQxUserMenuDetailEN.mId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000030)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AddNewRecordBySql2WithReturnKey)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsQxUserMenuDetailEN objQxUserMenuDetailEN)
{
if (objQxUserMenuDetailEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!用户ID = [{0}],菜单Id = [{1}]的数据已经存在!(in clsQxUserMenuDetailBL.AddNewRecordBySql2WithReturnKey)", objQxUserMenuDetailEN.UserId,objQxUserMenuDetailEN.MenuId);
throw new Exception(strMsg);
}
try
{
string strKey = QxUserMenuDetailDA.AddNewRecordBySQL2WithReturnKey(objQxUserMenuDetailEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserMenuDetailBL.ReFreshCache();

if (clsQxUserMenuDetailBL.relatedActions != null)
{
clsQxUserMenuDetailBL.relatedActions.UpdRelaTabDate(objQxUserMenuDetailEN.mId, "SetUpdDate");
}
return strKey;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000049)带返回值的添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,数据来源为代表实体对象的XML串
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、使用XML串来源来插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AddNewRecordBySql_XML)
 /// </summary>
 /// <param name = "strQxUserMenuDetailObjXml">代表实体对象的XML串</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql_XML(string strQxUserMenuDetailObjXml)
{
clsQxUserMenuDetailEN objQxUserMenuDetailEN = GetObjFromXmlStr(strQxUserMenuDetailObjXml);
try
{
bool bolResult = QxUserMenuDetailDA.AddNewRecordBySQL2(objQxUserMenuDetailEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserMenuDetailBL.ReFreshCache();

if (clsQxUserMenuDetailBL.relatedActions != null)
{
clsQxUserMenuDetailBL.relatedActions.UpdRelaTabDate(objQxUserMenuDetailEN.mId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000032)添加记录出错!(使用XML), {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 添加记录


 #region 修改记录

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Update)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsQxUserMenuDetailEN objQxUserMenuDetailEN)
{
try
{
bool bolResult = QxUserMenuDetailDA.Update(objQxUserMenuDetailEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserMenuDetailBL.ReFreshCache();

if (clsQxUserMenuDetailBL.relatedActions != null)
{
clsQxUserMenuDetailBL.relatedActions.UpdRelaTabDate(objQxUserMenuDetailEN.mId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000033)修改记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_UpdateBySql2)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsQxUserMenuDetailEN objQxUserMenuDetailEN)
{
 if (objQxUserMenuDetailEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = QxUserMenuDetailDA.UpdateBySql2(objQxUserMenuDetailEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserMenuDetailBL.ReFreshCache();

if (clsQxUserMenuDetailBL.relatedActions != null)
{
clsQxUserMenuDetailBL.relatedActions.UpdRelaTabDate(objQxUserMenuDetailEN.mId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000034)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式提供XML串来代表实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_UpdateBySql_XML)
 /// </summary>
 /// <param name = "strQxUserMenuDetailObjXml">需要修改的对象,用XML来表示</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql_XML(string strQxUserMenuDetailObjXml)
{
clsQxUserMenuDetailEN objQxUserMenuDetailEN = GetObjFromXmlStr(strQxUserMenuDetailObjXml);
try
{
bool bolResult = QxUserMenuDetailDA.UpdateBySql2(objQxUserMenuDetailEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserMenuDetailBL.ReFreshCache();

if (clsQxUserMenuDetailBL.relatedActions != null)
{
clsQxUserMenuDetailBL.relatedActions.UpdRelaTabDate(objQxUserMenuDetailEN.mId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000038)修改记录(UpdateBySql_XML)出错,{1}.!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 修改记录


 #region 删除记录

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngmId)
{
try
{
 clsQxUserMenuDetailEN objQxUserMenuDetailEN = clsQxUserMenuDetailBL.GetObjBymId(lngmId);

if (clsQxUserMenuDetailBL.relatedActions != null)
{
clsQxUserMenuDetailBL.relatedActions.UpdRelaTabDate(objQxUserMenuDetailEN.mId, "SetUpdDate");
}
if (objQxUserMenuDetailEN != null)
{
int intRecNum = QxUserMenuDetailDA.DelRecord(lngmId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return intRecNum;
}
            else
{
return 0;
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000039)根据关键字删除记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
/// 扩展删除记录,即同时删除多个表的记录,需要基于原子性的事务处理
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordEx)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngmId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
//删除TeacherInfo本表中与当前对象有关的记录
SqlConnection objConnection = null;
SqlTransaction objSqlTransaction = null;
  try
{
//获取连接对象
objConnection = objSQL.getConnectObj(objSQL.ConnectionString);
//获取该连接对象中的事务
objSqlTransaction = objConnection.BeginTransaction();
//
//删除与表:[QxUserMenuDetail]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conQxUserMenuDetail.mId,
//lngmId);
//        clsQxUserMenuDetailBL.DelQxUserMenuDetailsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxUserMenuDetailBL.DelRecord(lngmId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxUserMenuDetailBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngmId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);
if (objSqlTransaction != null)
{
objSqlTransaction.Rollback();
}
throw new Exception(strMsg);
        }
finally
{
objConnection.Close();
}
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordWithTransaction_S)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngmId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsQxUserMenuDetailBL.relatedActions != null)
{
clsQxUserMenuDetailBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = QxUserMenuDetailDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000040)根据关键字删除记录出错!(使用事务),{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:删除关键字所指定的记录,通过存储过程(SP)来删除。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordBySP_S)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngmId) 
{
try
{
if (clsQxUserMenuDetailBL.relatedActions != null)
{
clsQxUserMenuDetailBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = QxUserMenuDetailDA.DelRecordBySP(lngmId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000041)通过存储过程删除记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelMultiRecord)
 /// </summary>
 /// <param name = "arrmIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelQxUserMenuDetails(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsQxUserMenuDetailBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsQxUserMenuDetailBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intDelRecNum = QxUserMenuDetailDA.DelQxUserMenuDetail(arrmIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return intDelRecNum;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000042)删除多关键字记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelMultiRecordByCond)
 /// </summary>
 /// <param name = "strWhereCond">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public static int DelQxUserMenuDetailsByCond(string strWhereCond)
{
try
{
if (clsQxUserMenuDetailBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsQxUserMenuDetailBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum = QxUserMenuDetailDA.DelQxUserMenuDetail(strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return intRecNum;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000043)删除带条件表记录出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
/// 扩展删除记录,即同时删除多个表的记录,需要基于原子性的事务处理
/// 这里仅仅是演示函数,使用时请复制到扩展类:[QxUserMenuDetail]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxUserMenuDetailDA.GetSpecSQLObj();
//删除TeacherInfo本表中与当前对象有关的记录
SqlConnection objConnection = null;
SqlTransaction objSqlTransaction = null;
  try
{
//获取连接对象
objConnection = objSQL.getConnectObj(objSQL.ConnectionString);
//获取该连接对象中的事务
objSqlTransaction = objConnection.BeginTransaction();
//
//删除与表:[QxUserMenuDetail]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxUserMenuDetailBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxUserMenuDetailBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngmId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);
if (objSqlTransaction != null)
{
objSqlTransaction.Rollback();
}
throw new Exception(strMsg);
        }
finally
{
objConnection.Close();
}
}


 #endregion 删除记录


 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CopyObj_S)
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
 /// <param name = "objQxUserMenuDetailEN">源简化对象</param>
 public static void SetUpdFlag(clsQxUserMenuDetailEN objQxUserMenuDetailEN)
{
try
{
objQxUserMenuDetailEN.ClearUpdateState();
   string strsfUpdFldSetStr = objQxUserMenuDetailEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conQxUserMenuDetail.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserMenuDetailEN.mId = objQxUserMenuDetailEN.mId; //流水号
}
if (arrFldSet.Contains(conQxUserMenuDetail.MenuId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserMenuDetailEN.MenuId = objQxUserMenuDetailEN.MenuId; //菜单Id
}
if (arrFldSet.Contains(conQxUserMenuDetail.MenuName, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserMenuDetailEN.MenuName = objQxUserMenuDetailEN.MenuName; //菜单名
}
if (arrFldSet.Contains(conQxUserMenuDetail.IsDisp, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserMenuDetailEN.IsDisp = objQxUserMenuDetailEN.IsDisp; //是否显示
}
if (arrFldSet.Contains(conQxUserMenuDetail.UpMenuId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserMenuDetailEN.UpMenuId = objQxUserMenuDetailEN.UpMenuId == "[null]" ? null :  objQxUserMenuDetailEN.UpMenuId; //上级菜单Id
}
if (arrFldSet.Contains(conQxUserMenuDetail.LinkFile, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserMenuDetailEN.LinkFile = objQxUserMenuDetailEN.LinkFile == "[null]" ? null :  objQxUserMenuDetailEN.LinkFile; //链接文件
}
if (arrFldSet.Contains(conQxUserMenuDetail.ImgFile, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserMenuDetailEN.ImgFile = objQxUserMenuDetailEN.ImgFile == "[null]" ? null :  objQxUserMenuDetailEN.ImgFile; //图像文件
}
if (arrFldSet.Contains(conQxUserMenuDetail.IsCustomMenu, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserMenuDetailEN.IsCustomMenu = objQxUserMenuDetailEN.IsCustomMenu; //是否定制菜单
}
if (arrFldSet.Contains(conQxUserMenuDetail.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserMenuDetailEN.UserId = objQxUserMenuDetailEN.UserId; //用户ID
}
if (arrFldSet.Contains(conQxUserMenuDetail.QxPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserMenuDetailEN.QxPrjId = objQxUserMenuDetailEN.QxPrjId; //项目Id
}
if (arrFldSet.Contains(conQxUserMenuDetail.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserMenuDetailEN.OrderNum = objQxUserMenuDetailEN.OrderNum; //排序号
}
if (arrFldSet.Contains(conQxUserMenuDetail.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserMenuDetailEN.Memo = objQxUserMenuDetailEN.Memo == "[null]" ? null :  objQxUserMenuDetailEN.Memo; //备注
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
 /// <param name = "objQxUserMenuDetailEN">源简化对象</param>
 public static void AccessFldValueNull(clsQxUserMenuDetailEN objQxUserMenuDetailEN)
{
try
{
if (objQxUserMenuDetailEN.UpMenuId == "[null]") objQxUserMenuDetailEN.UpMenuId = null; //上级菜单Id
if (objQxUserMenuDetailEN.LinkFile == "[null]") objQxUserMenuDetailEN.LinkFile = null; //链接文件
if (objQxUserMenuDetailEN.ImgFile == "[null]") objQxUserMenuDetailEN.ImgFile = null; //图像文件
if (objQxUserMenuDetailEN.Memo == "[null]") objQxUserMenuDetailEN.Memo = null; //备注
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
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsQxUserMenuDetailEN objQxUserMenuDetailEN)
{
 QxUserMenuDetailDA.CheckPropertyNew(objQxUserMenuDetailEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsQxUserMenuDetailEN objQxUserMenuDetailEN)
{
 QxUserMenuDetailDA.CheckProperty4Condition(objQxUserMenuDetailEN);
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
if (clsQxUserMenuDetailBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxUserMenuDetailBL没有刷新缓存机制(clsQxUserMenuDetailBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrQxUserMenuDetailObjLstCache == null)
//{
//arrQxUserMenuDetailObjLstCache = QxUserMenuDetailDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxUserMenuDetailEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsQxUserMenuDetailEN._CurrTabName);
List<clsQxUserMenuDetailEN> arrQxUserMenuDetailObjLstCache = GetObjLstCache();
IEnumerable <clsQxUserMenuDetailEN> arrQxUserMenuDetailObjLst_Sel =
arrQxUserMenuDetailObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrQxUserMenuDetailObjLst_Sel.Count() == 0)
{
   clsQxUserMenuDetailEN obj = clsQxUserMenuDetailBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrQxUserMenuDetailObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxUserMenuDetailEN> GetAllQxUserMenuDetailObjLstCache()
{
//获取缓存中的对象列表
List<clsQxUserMenuDetailEN> arrQxUserMenuDetailObjLstCache = GetObjLstCache(); 
return arrQxUserMenuDetailObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxUserMenuDetailEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsQxUserMenuDetailEN._CurrTabName);
List<clsQxUserMenuDetailEN> arrQxUserMenuDetailObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrQxUserMenuDetailObjLstCache;
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsQxUserMenuDetailBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsQxUserMenuDetailEN._CurrTabName);
CacheHelper.Remove(strKey);
clsQxUserMenuDetailBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--QxUserMenuDetail(用户菜单)
 /// 唯一性条件:UserId_MenuId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsQxUserMenuDetailEN objQxUserMenuDetailEN)
{
//检测记录是否存在
string strResult = QxUserMenuDetailDA.GetUniCondStr(objQxUserMenuDetailEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstQxUserMenuDetailObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsQxUserMenuDetailEN> lstQxUserMenuDetailObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstQxUserMenuDetailObjLst, writer);
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
 /// <param name = "lstQxUserMenuDetailObjLst">[clsQxUserMenuDetailEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsQxUserMenuDetailEN> lstQxUserMenuDetailObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsQxUserMenuDetailBL.listXmlNode);
writer.WriteStartElement(clsQxUserMenuDetailBL.itemsXmlNode);
foreach (clsQxUserMenuDetailEN objQxUserMenuDetailEN in lstQxUserMenuDetailObjLst)
{
clsQxUserMenuDetailBL.SerializeXML(writer, objQxUserMenuDetailEN);
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
 /// <param name = "objQxUserMenuDetailEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsQxUserMenuDetailEN objQxUserMenuDetailEN)
{
writer.WriteStartElement(clsQxUserMenuDetailBL.itemXmlNode);
 
writer.WriteElementString(conQxUserMenuDetail.mId, objQxUserMenuDetailEN.mId.ToString(CultureInfo.InvariantCulture));
 
if (objQxUserMenuDetailEN.MenuId != null)
{
writer.WriteElementString(conQxUserMenuDetail.MenuId, objQxUserMenuDetailEN.MenuId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUserMenuDetailEN.MenuName != null)
{
writer.WriteElementString(conQxUserMenuDetail.MenuName, objQxUserMenuDetailEN.MenuName.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(conQxUserMenuDetail.IsDisp, objQxUserMenuDetailEN.IsDisp.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objQxUserMenuDetailEN.UpMenuId != null)
{
writer.WriteElementString(conQxUserMenuDetail.UpMenuId, objQxUserMenuDetailEN.UpMenuId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUserMenuDetailEN.LinkFile != null)
{
writer.WriteElementString(conQxUserMenuDetail.LinkFile, objQxUserMenuDetailEN.LinkFile.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUserMenuDetailEN.ImgFile != null)
{
writer.WriteElementString(conQxUserMenuDetail.ImgFile, objQxUserMenuDetailEN.ImgFile.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(conQxUserMenuDetail.IsCustomMenu, objQxUserMenuDetailEN.IsCustomMenu.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objQxUserMenuDetailEN.UserId != null)
{
writer.WriteElementString(conQxUserMenuDetail.UserId, objQxUserMenuDetailEN.UserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUserMenuDetailEN.QxPrjId != null)
{
writer.WriteElementString(conQxUserMenuDetail.QxPrjId, objQxUserMenuDetailEN.QxPrjId.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(conQxUserMenuDetail.OrderNum, objQxUserMenuDetailEN.OrderNum.ToString(CultureInfo.InvariantCulture));
 
if (objQxUserMenuDetailEN.Memo != null)
{
writer.WriteElementString(conQxUserMenuDetail.Memo, objQxUserMenuDetailEN.Memo.ToString(CultureInfo.InvariantCulture));
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
public static clsQxUserMenuDetailEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsQxUserMenuDetailEN objQxUserMenuDetailEN = new clsQxUserMenuDetailEN();
reader.Read();
while (!(reader.Name == clsQxUserMenuDetailBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(conQxUserMenuDetail.mId))
{
objQxUserMenuDetailEN.mId = reader.ReadElementContentAsLong();
}
if (reader.IsStartElement(conQxUserMenuDetail.MenuId))
{
objQxUserMenuDetailEN.MenuId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUserMenuDetail.MenuName))
{
objQxUserMenuDetailEN.MenuName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUserMenuDetail.IsDisp))
{
objQxUserMenuDetailEN.IsDisp = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(conQxUserMenuDetail.UpMenuId))
{
objQxUserMenuDetailEN.UpMenuId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUserMenuDetail.LinkFile))
{
objQxUserMenuDetailEN.LinkFile = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUserMenuDetail.ImgFile))
{
objQxUserMenuDetailEN.ImgFile = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUserMenuDetail.IsCustomMenu))
{
objQxUserMenuDetailEN.IsCustomMenu = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(conQxUserMenuDetail.UserId))
{
objQxUserMenuDetailEN.UserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUserMenuDetail.QxPrjId))
{
objQxUserMenuDetailEN.QxPrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUserMenuDetail.OrderNum))
{
objQxUserMenuDetailEN.OrderNum = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(conQxUserMenuDetail.Memo))
{
objQxUserMenuDetailEN.Memo = reader.ReadElementContentAsString();
}
}
return objQxUserMenuDetailEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strQxUserMenuDetailObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsQxUserMenuDetailEN GetObjFromXmlStr(string strQxUserMenuDetailObjXmlStr)
{
clsQxUserMenuDetailEN objQxUserMenuDetailEN = new clsQxUserMenuDetailEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strQxUserMenuDetailObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsQxUserMenuDetailBL.itemXmlNode))
{
objQxUserMenuDetailEN = GetObjFromXml(reader);
return objQxUserMenuDetailEN;
}
}
return objQxUserMenuDetailEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsQxUserMenuDetailEN objQxUserMenuDetailEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objQxUserMenuDetailEN);
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
if (strInFldName != conQxUserMenuDetail.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conQxUserMenuDetail.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conQxUserMenuDetail.AttributeName));
throw new Exception(strMsg);
}
var objQxUserMenuDetail = clsQxUserMenuDetailBL.GetObjBymIdCache(lngmId);
if (objQxUserMenuDetail == null) return "";
return objQxUserMenuDetail[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objQxUserMenuDetailEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsQxUserMenuDetailEN objQxUserMenuDetailEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsQxUserMenuDetailEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objQxUserMenuDetailEN[strField]);
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
 /// <param name = "lstQxUserMenuDetailObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsQxUserMenuDetailEN> lstQxUserMenuDetailObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstQxUserMenuDetailObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsQxUserMenuDetailEN objQxUserMenuDetailEN in lstQxUserMenuDetailObjLst)
{
string strJSON_One = SerializeObjToJSON(objQxUserMenuDetailEN);
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
int intRecCount = clsQxUserMenuDetailDA.GetRecCount(strTabName);
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
int intRecCount = clsQxUserMenuDetailDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsQxUserMenuDetailDA.GetRecCount();
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
int intRecCount = clsQxUserMenuDetailDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objQxUserMenuDetailCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsQxUserMenuDetailEN objQxUserMenuDetailCond)
{
List<clsQxUserMenuDetailEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxUserMenuDetailEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxUserMenuDetail.AttributeName)
{
if (objQxUserMenuDetailCond.IsUpdated(strFldName) == false) continue;
if (objQxUserMenuDetailCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUserMenuDetailCond[strFldName].ToString());
}
else
{
if (objQxUserMenuDetailCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxUserMenuDetailCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUserMenuDetailCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxUserMenuDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxUserMenuDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxUserMenuDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxUserMenuDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxUserMenuDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxUserMenuDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxUserMenuDetailCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxUserMenuDetailCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxUserMenuDetailCond[strFldName]));
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
 List<string> arrList = clsQxUserMenuDetailDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = QxUserMenuDetailDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = QxUserMenuDetailDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 /// <summary>
 /// 功能:设置当前表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4String)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public int SetFldValue(string strFldName, string strValue, string strWhereCond) 
{
int intRecCount = QxUserMenuDetailDA.SetFldValue(strFldName, strValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}


 /// <summary>
 /// 功能:设置当前表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Float)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "fltValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public int SetFldValue(string strFldName, float fltValue, string strWhereCond) 
{
int intRecCount = clsQxUserMenuDetailDA.SetFldValue(clsQxUserMenuDetailEN._CurrTabName, strFldName, fltValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置当前表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Int)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "intValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public int SetFldValue(string strFldName, int intValue, string strWhereCond) 
{
int intRecCount = QxUserMenuDetailDA.SetFldValue( strFldName, intValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4String_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue(string strTabName, string strFldName, string strValue, string strWhereCond) 
{
int intRecCount = clsQxUserMenuDetailDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Int_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue(string strTabName, string strFldName, int intValue, string strWhereCond) 
{
int intRecCount = clsQxUserMenuDetailDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Float_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue(string strTabName, string strFldName, float fltValue, string strWhereCond) 
{
int intRecCount = clsQxUserMenuDetailDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}



 #endregion 表操作常用函数


 #region 表操作

 /// <summary>
 /// 功能:获取建立表的代码
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GenSQLCode4CreateTab)
 /// </summary>
 /// <returns>建立表的代码</returns>
public static string GetCode4CreateTable() 
{
 StringBuilder strCreateTabCode = new StringBuilder();
  strCreateTabCode.Append("CREATE table [dbo].[QxUserMenuDetail] "); 
 strCreateTabCode.Append(" ( "); 
 // /**流水号*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**菜单Id*/ 
 strCreateTabCode.Append(" MenuId char(8) not Null, "); 
 // /**菜单名*/ 
 strCreateTabCode.Append(" MenuName varchar(50) not Null, "); 
 // /**是否显示*/ 
 strCreateTabCode.Append(" IsDisp bit not Null, "); 
 // /**上级菜单Id*/ 
 strCreateTabCode.Append(" UpMenuId char(8) Null, "); 
 // /**链接文件*/ 
 strCreateTabCode.Append(" LinkFile varchar(500) Null, "); 
 // /**图像文件*/ 
 strCreateTabCode.Append(" ImgFile varchar(300) Null, "); 
 // /**是否定制菜单*/ 
 strCreateTabCode.Append(" IsCustomMenu bit not Null, "); 
 // /**用户ID*/ 
 strCreateTabCode.Append(" UserId varchar(18) not Null, "); 
 // /**项目Id*/ 
 strCreateTabCode.Append(" QxPrjId char(4) not Null, "); 
 // /**排序号*/ 
 strCreateTabCode.Append(" OrderNum int not Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 数据同步


 #endregion 数据同步
}
 /// <summary>
 /// 用户菜单(QxUserMenuDetail)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4QxUserMenuDetail : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4BL4CSharp:Gen_4CFBL_ReFreshCache)
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
clsQxUserMenuDetailBL.ReFreshThisCache();
}
}

}