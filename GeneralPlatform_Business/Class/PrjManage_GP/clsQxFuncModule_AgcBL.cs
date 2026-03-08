
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxFuncModule_AgcBL
 表名:QxFuncModule_Agc(00140101)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:28:11
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:工程管理(PrjManage_GP)
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
public static class  clsQxFuncModule_AgcBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strFuncModuleAgcId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxFuncModule_AgcEN GetObj(this K_FuncModuleAgcId_QxFuncModule_Agc myKey)
{
clsQxFuncModule_AgcEN objQxFuncModule_AgcEN = clsQxFuncModule_AgcBL.QxFuncModule_AgcDA.GetObjByFuncModuleAgcId(myKey.Value);
return objQxFuncModule_AgcEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQxFuncModule_AgcEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQxFuncModule_AgcEN objQxFuncModule_AgcEN)
{
 if (string.IsNullOrEmpty(objQxFuncModule_AgcEN.FuncModuleAgcId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQxFuncModule_AgcBL.IsExist(objQxFuncModule_AgcEN.FuncModuleAgcId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQxFuncModule_AgcEN.FuncModuleAgcId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsQxFuncModule_AgcBL.QxFuncModule_AgcDA.AddNewRecordBySQL2(objQxFuncModule_AgcEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxFuncModule_AgcBL.ReFreshCache();

if (clsQxFuncModule_AgcBL.relatedActions != null)
{
clsQxFuncModule_AgcBL.relatedActions.UpdRelaTabDate(objQxFuncModule_AgcEN.FuncModuleAgcId, objQxFuncModule_AgcEN.UpdUser);
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
public static bool AddRecordEx(this clsQxFuncModule_AgcEN objQxFuncModule_AgcEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsQxFuncModule_AgcBL.IsExist(objQxFuncModule_AgcEN.FuncModuleAgcId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objQxFuncModule_AgcEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objQxFuncModule_AgcEN.AddNewRecord();
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
 /// <param name = "objQxFuncModule_AgcEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsQxFuncModule_AgcEN objQxFuncModule_AgcEN)
{
 if (string.IsNullOrEmpty(objQxFuncModule_AgcEN.FuncModuleAgcId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQxFuncModule_AgcBL.IsExist(objQxFuncModule_AgcEN.FuncModuleAgcId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQxFuncModule_AgcEN.FuncModuleAgcId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsQxFuncModule_AgcBL.QxFuncModule_AgcDA.AddNewRecordBySQL2WithReturnKey(objQxFuncModule_AgcEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxFuncModule_AgcBL.ReFreshCache();

if (clsQxFuncModule_AgcBL.relatedActions != null)
{
clsQxFuncModule_AgcBL.relatedActions.UpdRelaTabDate(objQxFuncModule_AgcEN.FuncModuleAgcId, objQxFuncModule_AgcEN.UpdUser);
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
 /// <param name = "objQxFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxFuncModule_AgcEN SetFuncModuleAgcId(this clsQxFuncModule_AgcEN objQxFuncModule_AgcEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, conQxFuncModule_Agc.FuncModuleAgcId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, conQxFuncModule_Agc.FuncModuleAgcId);
}
objQxFuncModule_AgcEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(conQxFuncModule_Agc.FuncModuleAgcId) == false)
{
objQxFuncModule_AgcEN.dicFldComparisonOp.Add(conQxFuncModule_Agc.FuncModuleAgcId, strComparisonOp);
}
else
{
objQxFuncModule_AgcEN.dicFldComparisonOp[conQxFuncModule_Agc.FuncModuleAgcId] = strComparisonOp;
}
}
return objQxFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxFuncModule_AgcEN SetFuncModuleName(this clsQxFuncModule_AgcEN objQxFuncModule_AgcEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleName, conQxFuncModule_Agc.FuncModuleName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, conQxFuncModule_Agc.FuncModuleName);
}
objQxFuncModule_AgcEN.FuncModuleName = strFuncModuleName; //模块名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(conQxFuncModule_Agc.FuncModuleName) == false)
{
objQxFuncModule_AgcEN.dicFldComparisonOp.Add(conQxFuncModule_Agc.FuncModuleName, strComparisonOp);
}
else
{
objQxFuncModule_AgcEN.dicFldComparisonOp[conQxFuncModule_Agc.FuncModuleName] = strComparisonOp;
}
}
return objQxFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxFuncModule_AgcEN SetFuncModuleEnName(this clsQxFuncModule_AgcEN objQxFuncModule_AgcEN, string strFuncModuleEnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleEnName, 30, conQxFuncModule_Agc.FuncModuleEnName);
}
objQxFuncModule_AgcEN.FuncModuleEnName = strFuncModuleEnName; //模块英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(conQxFuncModule_Agc.FuncModuleEnName) == false)
{
objQxFuncModule_AgcEN.dicFldComparisonOp.Add(conQxFuncModule_Agc.FuncModuleEnName, strComparisonOp);
}
else
{
objQxFuncModule_AgcEN.dicFldComparisonOp[conQxFuncModule_Agc.FuncModuleEnName] = strComparisonOp;
}
}
return objQxFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxFuncModule_AgcEN SetFuncModuleNameSim(this clsQxFuncModule_AgcEN objQxFuncModule_AgcEN, string strFuncModuleNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleNameSim, 30, conQxFuncModule_Agc.FuncModuleNameSim);
}
objQxFuncModule_AgcEN.FuncModuleNameSim = strFuncModuleNameSim; //模块名_Sim
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(conQxFuncModule_Agc.FuncModuleNameSim) == false)
{
objQxFuncModule_AgcEN.dicFldComparisonOp.Add(conQxFuncModule_Agc.FuncModuleNameSim, strComparisonOp);
}
else
{
objQxFuncModule_AgcEN.dicFldComparisonOp[conQxFuncModule_Agc.FuncModuleNameSim] = strComparisonOp;
}
}
return objQxFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxFuncModule_AgcEN SetQxPrjId(this clsQxFuncModule_AgcEN objQxFuncModule_AgcEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, conQxFuncModule_Agc.QxPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQxPrjId, 4, conQxFuncModule_Agc.QxPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, conQxFuncModule_Agc.QxPrjId);
}
objQxFuncModule_AgcEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(conQxFuncModule_Agc.QxPrjId) == false)
{
objQxFuncModule_AgcEN.dicFldComparisonOp.Add(conQxFuncModule_Agc.QxPrjId, strComparisonOp);
}
else
{
objQxFuncModule_AgcEN.dicFldComparisonOp[conQxFuncModule_Agc.QxPrjId] = strComparisonOp;
}
}
return objQxFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxFuncModule_AgcEN SetOrderNum(this clsQxFuncModule_AgcEN objQxFuncModule_AgcEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, conQxFuncModule_Agc.OrderNum);
objQxFuncModule_AgcEN.OrderNum = intOrderNum; //排序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(conQxFuncModule_Agc.OrderNum) == false)
{
objQxFuncModule_AgcEN.dicFldComparisonOp.Add(conQxFuncModule_Agc.OrderNum, strComparisonOp);
}
else
{
objQxFuncModule_AgcEN.dicFldComparisonOp[conQxFuncModule_Agc.OrderNum] = strComparisonOp;
}
}
return objQxFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxFuncModule_AgcEN SetUseStateId(this clsQxFuncModule_AgcEN objQxFuncModule_AgcEN, string strUseStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUseStateId, conQxFuncModule_Agc.UseStateId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUseStateId, 4, conQxFuncModule_Agc.UseStateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUseStateId, 4, conQxFuncModule_Agc.UseStateId);
}
objQxFuncModule_AgcEN.UseStateId = strUseStateId; //UseStateId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(conQxFuncModule_Agc.UseStateId) == false)
{
objQxFuncModule_AgcEN.dicFldComparisonOp.Add(conQxFuncModule_Agc.UseStateId, strComparisonOp);
}
else
{
objQxFuncModule_AgcEN.dicFldComparisonOp[conQxFuncModule_Agc.UseStateId] = strComparisonOp;
}
}
return objQxFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxFuncModule_AgcEN SetUpdUser(this clsQxFuncModule_AgcEN objQxFuncModule_AgcEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 18, conQxFuncModule_Agc.UpdUser);
}
objQxFuncModule_AgcEN.UpdUser = strUpdUser; //修改用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(conQxFuncModule_Agc.UpdUser) == false)
{
objQxFuncModule_AgcEN.dicFldComparisonOp.Add(conQxFuncModule_Agc.UpdUser, strComparisonOp);
}
else
{
objQxFuncModule_AgcEN.dicFldComparisonOp[conQxFuncModule_Agc.UpdUser] = strComparisonOp;
}
}
return objQxFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxFuncModule_AgcEN SetUpdDate(this clsQxFuncModule_AgcEN objQxFuncModule_AgcEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQxFuncModule_Agc.UpdDate);
}
objQxFuncModule_AgcEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(conQxFuncModule_Agc.UpdDate) == false)
{
objQxFuncModule_AgcEN.dicFldComparisonOp.Add(conQxFuncModule_Agc.UpdDate, strComparisonOp);
}
else
{
objQxFuncModule_AgcEN.dicFldComparisonOp[conQxFuncModule_Agc.UpdDate] = strComparisonOp;
}
}
return objQxFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxFuncModule_AgcEN SetMemo(this clsQxFuncModule_AgcEN objQxFuncModule_AgcEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQxFuncModule_Agc.Memo);
}
objQxFuncModule_AgcEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(conQxFuncModule_Agc.Memo) == false)
{
objQxFuncModule_AgcEN.dicFldComparisonOp.Add(conQxFuncModule_Agc.Memo, strComparisonOp);
}
else
{
objQxFuncModule_AgcEN.dicFldComparisonOp[conQxFuncModule_Agc.Memo] = strComparisonOp;
}
}
return objQxFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxFuncModule_AgcEN SetSynchDate(this clsQxFuncModule_AgcEN objQxFuncModule_AgcEN, string strSynchDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSynchDate, 14, conQxFuncModule_Agc.SynchDate);
}
objQxFuncModule_AgcEN.SynchDate = strSynchDate; //同步日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(conQxFuncModule_Agc.SynchDate) == false)
{
objQxFuncModule_AgcEN.dicFldComparisonOp.Add(conQxFuncModule_Agc.SynchDate, strComparisonOp);
}
else
{
objQxFuncModule_AgcEN.dicFldComparisonOp[conQxFuncModule_Agc.SynchDate] = strComparisonOp;
}
}
return objQxFuncModule_AgcEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objQxFuncModule_AgcEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsQxFuncModule_AgcEN objQxFuncModule_AgcEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objQxFuncModule_AgcEN.CheckPropertyNew();
clsQxFuncModule_AgcEN objQxFuncModule_AgcCond = new clsQxFuncModule_AgcEN();
string strCondition = objQxFuncModule_AgcCond
.SetFuncModuleAgcId(objQxFuncModule_AgcEN.FuncModuleAgcId, "=")
.GetCombineCondition();
objQxFuncModule_AgcEN._IsCheckProperty = true;
bool bolIsExist = clsQxFuncModule_AgcBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objQxFuncModule_AgcEN.Update();
}
catch(Exception objException)
{
strMsg = "修改记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objQxFuncModule_AgcEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxFuncModule_AgcEN objQxFuncModule_AgcEN)
{
 if (string.IsNullOrEmpty(objQxFuncModule_AgcEN.FuncModuleAgcId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxFuncModule_AgcBL.QxFuncModule_AgcDA.UpdateBySql2(objQxFuncModule_AgcEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxFuncModule_AgcBL.ReFreshCache();

if (clsQxFuncModule_AgcBL.relatedActions != null)
{
clsQxFuncModule_AgcBL.relatedActions.UpdRelaTabDate(objQxFuncModule_AgcEN.FuncModuleAgcId, objQxFuncModule_AgcEN.UpdUser);
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
 /// <param name = "objQxFuncModule_AgcEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxFuncModule_AgcEN objQxFuncModule_AgcEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objQxFuncModule_AgcEN.FuncModuleAgcId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxFuncModule_AgcBL.QxFuncModule_AgcDA.UpdateBySql2(objQxFuncModule_AgcEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxFuncModule_AgcBL.ReFreshCache();

if (clsQxFuncModule_AgcBL.relatedActions != null)
{
clsQxFuncModule_AgcBL.relatedActions.UpdRelaTabDate(objQxFuncModule_AgcEN.FuncModuleAgcId, objQxFuncModule_AgcEN.UpdUser);
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
 /// <param name = "objQxFuncModule_AgcEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxFuncModule_AgcEN objQxFuncModule_AgcEN, string strWhereCond)
{
try
{
bool bolResult = clsQxFuncModule_AgcBL.QxFuncModule_AgcDA.UpdateBySqlWithCondition(objQxFuncModule_AgcEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxFuncModule_AgcBL.ReFreshCache();

if (clsQxFuncModule_AgcBL.relatedActions != null)
{
clsQxFuncModule_AgcBL.relatedActions.UpdRelaTabDate(objQxFuncModule_AgcEN.FuncModuleAgcId, objQxFuncModule_AgcEN.UpdUser);
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
 /// <param name = "objQxFuncModule_AgcEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxFuncModule_AgcEN objQxFuncModule_AgcEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsQxFuncModule_AgcBL.QxFuncModule_AgcDA.UpdateBySqlWithConditionTransaction(objQxFuncModule_AgcEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxFuncModule_AgcBL.ReFreshCache();

if (clsQxFuncModule_AgcBL.relatedActions != null)
{
clsQxFuncModule_AgcBL.relatedActions.UpdRelaTabDate(objQxFuncModule_AgcEN.FuncModuleAgcId, objQxFuncModule_AgcEN.UpdUser);
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
 /// <param name = "strFuncModuleAgcId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsQxFuncModule_AgcEN objQxFuncModule_AgcEN)
{
try
{
int intRecNum = clsQxFuncModule_AgcBL.QxFuncModule_AgcDA.DelRecord(objQxFuncModule_AgcEN.FuncModuleAgcId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxFuncModule_AgcBL.ReFreshCache();

if (clsQxFuncModule_AgcBL.relatedActions != null)
{
clsQxFuncModule_AgcBL.relatedActions.UpdRelaTabDate(objQxFuncModule_AgcEN.FuncModuleAgcId, objQxFuncModule_AgcEN.UpdUser);
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
 /// <param name = "objQxFuncModule_AgcENS">源对象</param>
 /// <param name = "objQxFuncModule_AgcENT">目标对象</param>
 public static void CopyTo(this clsQxFuncModule_AgcEN objQxFuncModule_AgcENS, clsQxFuncModule_AgcEN objQxFuncModule_AgcENT)
{
try
{
objQxFuncModule_AgcENT.FuncModuleAgcId = objQxFuncModule_AgcENS.FuncModuleAgcId; //功能模块Id
objQxFuncModule_AgcENT.FuncModuleName = objQxFuncModule_AgcENS.FuncModuleName; //模块名
objQxFuncModule_AgcENT.FuncModuleEnName = objQxFuncModule_AgcENS.FuncModuleEnName; //模块英文名
objQxFuncModule_AgcENT.FuncModuleNameSim = objQxFuncModule_AgcENS.FuncModuleNameSim; //模块名_Sim
objQxFuncModule_AgcENT.QxPrjId = objQxFuncModule_AgcENS.QxPrjId; //项目Id
objQxFuncModule_AgcENT.OrderNum = objQxFuncModule_AgcENS.OrderNum; //排序号
objQxFuncModule_AgcENT.UseStateId = objQxFuncModule_AgcENS.UseStateId; //UseStateId
objQxFuncModule_AgcENT.UpdUser = objQxFuncModule_AgcENS.UpdUser; //修改用户
objQxFuncModule_AgcENT.UpdDate = objQxFuncModule_AgcENS.UpdDate; //修改日期
objQxFuncModule_AgcENT.Memo = objQxFuncModule_AgcENS.Memo; //备注
objQxFuncModule_AgcENT.SynchDate = objQxFuncModule_AgcENS.SynchDate; //同步日期
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
 /// <param name = "objQxFuncModule_AgcENS">源对象</param>
 /// <returns>目标对象=>clsQxFuncModule_AgcEN:objQxFuncModule_AgcENT</returns>
 public static clsQxFuncModule_AgcEN CopyTo(this clsQxFuncModule_AgcEN objQxFuncModule_AgcENS)
{
try
{
 clsQxFuncModule_AgcEN objQxFuncModule_AgcENT = new clsQxFuncModule_AgcEN()
{
FuncModuleAgcId = objQxFuncModule_AgcENS.FuncModuleAgcId, //功能模块Id
FuncModuleName = objQxFuncModule_AgcENS.FuncModuleName, //模块名
FuncModuleEnName = objQxFuncModule_AgcENS.FuncModuleEnName, //模块英文名
FuncModuleNameSim = objQxFuncModule_AgcENS.FuncModuleNameSim, //模块名_Sim
QxPrjId = objQxFuncModule_AgcENS.QxPrjId, //项目Id
OrderNum = objQxFuncModule_AgcENS.OrderNum, //排序号
UseStateId = objQxFuncModule_AgcENS.UseStateId, //UseStateId
UpdUser = objQxFuncModule_AgcENS.UpdUser, //修改用户
UpdDate = objQxFuncModule_AgcENS.UpdDate, //修改日期
Memo = objQxFuncModule_AgcENS.Memo, //备注
SynchDate = objQxFuncModule_AgcENS.SynchDate, //同步日期
};
 return objQxFuncModule_AgcENT;
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
public static void CheckPropertyNew(this clsQxFuncModule_AgcEN objQxFuncModule_AgcEN)
{
 clsQxFuncModule_AgcBL.QxFuncModule_AgcDA.CheckPropertyNew(objQxFuncModule_AgcEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsQxFuncModule_AgcEN objQxFuncModule_AgcEN)
{
 clsQxFuncModule_AgcBL.QxFuncModule_AgcDA.CheckProperty4Condition(objQxFuncModule_AgcEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQxFuncModule_AgcEN objQxFuncModule_AgcCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQxFuncModule_AgcCond.IsUpdated(conQxFuncModule_Agc.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objQxFuncModule_AgcCond.dicFldComparisonOp[conQxFuncModule_Agc.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxFuncModule_Agc.FuncModuleAgcId, objQxFuncModule_AgcCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objQxFuncModule_AgcCond.IsUpdated(conQxFuncModule_Agc.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objQxFuncModule_AgcCond.dicFldComparisonOp[conQxFuncModule_Agc.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxFuncModule_Agc.FuncModuleName, objQxFuncModule_AgcCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objQxFuncModule_AgcCond.IsUpdated(conQxFuncModule_Agc.FuncModuleEnName) == true)
{
string strComparisonOpFuncModuleEnName = objQxFuncModule_AgcCond.dicFldComparisonOp[conQxFuncModule_Agc.FuncModuleEnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxFuncModule_Agc.FuncModuleEnName, objQxFuncModule_AgcCond.FuncModuleEnName, strComparisonOpFuncModuleEnName);
}
if (objQxFuncModule_AgcCond.IsUpdated(conQxFuncModule_Agc.FuncModuleNameSim) == true)
{
string strComparisonOpFuncModuleNameSim = objQxFuncModule_AgcCond.dicFldComparisonOp[conQxFuncModule_Agc.FuncModuleNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxFuncModule_Agc.FuncModuleNameSim, objQxFuncModule_AgcCond.FuncModuleNameSim, strComparisonOpFuncModuleNameSim);
}
if (objQxFuncModule_AgcCond.IsUpdated(conQxFuncModule_Agc.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objQxFuncModule_AgcCond.dicFldComparisonOp[conQxFuncModule_Agc.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxFuncModule_Agc.QxPrjId, objQxFuncModule_AgcCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objQxFuncModule_AgcCond.IsUpdated(conQxFuncModule_Agc.OrderNum) == true)
{
string strComparisonOpOrderNum = objQxFuncModule_AgcCond.dicFldComparisonOp[conQxFuncModule_Agc.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conQxFuncModule_Agc.OrderNum, objQxFuncModule_AgcCond.OrderNum, strComparisonOpOrderNum);
}
if (objQxFuncModule_AgcCond.IsUpdated(conQxFuncModule_Agc.UseStateId) == true)
{
string strComparisonOpUseStateId = objQxFuncModule_AgcCond.dicFldComparisonOp[conQxFuncModule_Agc.UseStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxFuncModule_Agc.UseStateId, objQxFuncModule_AgcCond.UseStateId, strComparisonOpUseStateId);
}
if (objQxFuncModule_AgcCond.IsUpdated(conQxFuncModule_Agc.UpdUser) == true)
{
string strComparisonOpUpdUser = objQxFuncModule_AgcCond.dicFldComparisonOp[conQxFuncModule_Agc.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxFuncModule_Agc.UpdUser, objQxFuncModule_AgcCond.UpdUser, strComparisonOpUpdUser);
}
if (objQxFuncModule_AgcCond.IsUpdated(conQxFuncModule_Agc.UpdDate) == true)
{
string strComparisonOpUpdDate = objQxFuncModule_AgcCond.dicFldComparisonOp[conQxFuncModule_Agc.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxFuncModule_Agc.UpdDate, objQxFuncModule_AgcCond.UpdDate, strComparisonOpUpdDate);
}
if (objQxFuncModule_AgcCond.IsUpdated(conQxFuncModule_Agc.Memo) == true)
{
string strComparisonOpMemo = objQxFuncModule_AgcCond.dicFldComparisonOp[conQxFuncModule_Agc.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxFuncModule_Agc.Memo, objQxFuncModule_AgcCond.Memo, strComparisonOpMemo);
}
if (objQxFuncModule_AgcCond.IsUpdated(conQxFuncModule_Agc.SynchDate) == true)
{
string strComparisonOpSynchDate = objQxFuncModule_AgcCond.dicFldComparisonOp[conQxFuncModule_Agc.SynchDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxFuncModule_Agc.SynchDate, objQxFuncModule_AgcCond.SynchDate, strComparisonOpSynchDate);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_QxFuncModule_Agc
{
public virtual bool UpdRelaTabDate(string strFuncModuleAgcId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 功能模块_Agc(QxFuncModule_Agc)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsQxFuncModule_AgcBL
{
public static RelatedActions_QxFuncModule_Agc relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "QxFuncModule_AgcListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "QxFuncModule_AgcList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsQxFuncModule_AgcEN> arrQxFuncModule_AgcObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsQxFuncModule_AgcDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsQxFuncModule_AgcDA QxFuncModule_AgcDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsQxFuncModule_AgcDA();
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
 public clsQxFuncModule_AgcBL()
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
if (string.IsNullOrEmpty(clsQxFuncModule_AgcEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxFuncModule_AgcEN._ConnectString);
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
objDS = QxFuncModule_AgcDA.GetDataSet(strWhereCond);
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
objDS = QxFuncModule_AgcDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = QxFuncModule_AgcDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_QxFuncModule_Agc(string strWhereCond)
{
DataTable objDT;
try
{
objDT = QxFuncModule_AgcDA.GetDataTable_QxFuncModule_Agc(strWhereCond);
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
objDT = QxFuncModule_AgcDA.GetDataTable(strWhereCond);
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
objDT = QxFuncModule_AgcDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = QxFuncModule_AgcDA.GetDataTable(strWhereCond, strTabName);
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
objDT = QxFuncModule_AgcDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = QxFuncModule_AgcDA.GetDataTable_Top(objTopPara);
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
objDT = QxFuncModule_AgcDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = QxFuncModule_AgcDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = QxFuncModule_AgcDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = QxFuncModule_AgcDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = QxFuncModule_AgcDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = QxFuncModule_AgcDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = QxFuncModule_AgcDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = QxFuncModule_AgcDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
 /// <param name = "arrFuncModuleAgcIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsQxFuncModule_AgcEN> GetObjLstByFuncModuleAgcIdLst(List<string> arrFuncModuleAgcIdLst)
{
List<clsQxFuncModule_AgcEN> arrObjLst = new List<clsQxFuncModule_AgcEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrFuncModuleAgcIdLst, true);
 string strWhereCond = string.Format("FuncModuleAgcId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxFuncModule_AgcEN objQxFuncModule_AgcEN = new clsQxFuncModule_AgcEN();
try
{
objQxFuncModule_AgcEN.FuncModuleAgcId = objRow[conQxFuncModule_Agc.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objQxFuncModule_AgcEN.FuncModuleName = objRow[conQxFuncModule_Agc.FuncModuleName].ToString().Trim(); //模块名
objQxFuncModule_AgcEN.FuncModuleEnName = objRow[conQxFuncModule_Agc.FuncModuleEnName] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.FuncModuleEnName].ToString().Trim(); //模块英文名
objQxFuncModule_AgcEN.FuncModuleNameSim = objRow[conQxFuncModule_Agc.FuncModuleNameSim] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objQxFuncModule_AgcEN.QxPrjId = objRow[conQxFuncModule_Agc.QxPrjId].ToString().Trim(); //项目Id
objQxFuncModule_AgcEN.OrderNum = Int32.Parse(objRow[conQxFuncModule_Agc.OrderNum].ToString().Trim()); //排序号
objQxFuncModule_AgcEN.UseStateId = objRow[conQxFuncModule_Agc.UseStateId].ToString().Trim(); //UseStateId
objQxFuncModule_AgcEN.UpdUser = objRow[conQxFuncModule_Agc.UpdUser] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.UpdUser].ToString().Trim(); //修改用户
objQxFuncModule_AgcEN.UpdDate = objRow[conQxFuncModule_Agc.UpdDate] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.UpdDate].ToString().Trim(); //修改日期
objQxFuncModule_AgcEN.Memo = objRow[conQxFuncModule_Agc.Memo] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.Memo].ToString().Trim(); //备注
objQxFuncModule_AgcEN.SynchDate = objRow[conQxFuncModule_Agc.SynchDate] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.SynchDate].ToString().Trim(); //同步日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxFuncModule_AgcEN.FuncModuleAgcId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxFuncModule_AgcEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrFuncModuleAgcIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsQxFuncModule_AgcEN> GetObjLstByFuncModuleAgcIdLstCache(List<string> arrFuncModuleAgcIdLst)
{
string strKey = string.Format("{0}", clsQxFuncModule_AgcEN._CurrTabName);
List<clsQxFuncModule_AgcEN> arrQxFuncModule_AgcObjLstCache = GetObjLstCache();
IEnumerable <clsQxFuncModule_AgcEN> arrQxFuncModule_AgcObjLst_Sel =
arrQxFuncModule_AgcObjLstCache
.Where(x => arrFuncModuleAgcIdLst.Contains(x.FuncModuleAgcId));
return arrQxFuncModule_AgcObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxFuncModule_AgcEN> GetObjLst(string strWhereCond)
{
List<clsQxFuncModule_AgcEN> arrObjLst = new List<clsQxFuncModule_AgcEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxFuncModule_AgcEN objQxFuncModule_AgcEN = new clsQxFuncModule_AgcEN();
try
{
objQxFuncModule_AgcEN.FuncModuleAgcId = objRow[conQxFuncModule_Agc.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objQxFuncModule_AgcEN.FuncModuleName = objRow[conQxFuncModule_Agc.FuncModuleName].ToString().Trim(); //模块名
objQxFuncModule_AgcEN.FuncModuleEnName = objRow[conQxFuncModule_Agc.FuncModuleEnName] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.FuncModuleEnName].ToString().Trim(); //模块英文名
objQxFuncModule_AgcEN.FuncModuleNameSim = objRow[conQxFuncModule_Agc.FuncModuleNameSim] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objQxFuncModule_AgcEN.QxPrjId = objRow[conQxFuncModule_Agc.QxPrjId].ToString().Trim(); //项目Id
objQxFuncModule_AgcEN.OrderNum = Int32.Parse(objRow[conQxFuncModule_Agc.OrderNum].ToString().Trim()); //排序号
objQxFuncModule_AgcEN.UseStateId = objRow[conQxFuncModule_Agc.UseStateId].ToString().Trim(); //UseStateId
objQxFuncModule_AgcEN.UpdUser = objRow[conQxFuncModule_Agc.UpdUser] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.UpdUser].ToString().Trim(); //修改用户
objQxFuncModule_AgcEN.UpdDate = objRow[conQxFuncModule_Agc.UpdDate] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.UpdDate].ToString().Trim(); //修改日期
objQxFuncModule_AgcEN.Memo = objRow[conQxFuncModule_Agc.Memo] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.Memo].ToString().Trim(); //备注
objQxFuncModule_AgcEN.SynchDate = objRow[conQxFuncModule_Agc.SynchDate] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.SynchDate].ToString().Trim(); //同步日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxFuncModule_AgcEN.FuncModuleAgcId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxFuncModule_AgcEN);
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
public static List<clsQxFuncModule_AgcEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsQxFuncModule_AgcEN> arrObjLst = new List<clsQxFuncModule_AgcEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxFuncModule_AgcEN objQxFuncModule_AgcEN = new clsQxFuncModule_AgcEN();
try
{
objQxFuncModule_AgcEN.FuncModuleAgcId = objRow[conQxFuncModule_Agc.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objQxFuncModule_AgcEN.FuncModuleName = objRow[conQxFuncModule_Agc.FuncModuleName].ToString().Trim(); //模块名
objQxFuncModule_AgcEN.FuncModuleEnName = objRow[conQxFuncModule_Agc.FuncModuleEnName] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.FuncModuleEnName].ToString().Trim(); //模块英文名
objQxFuncModule_AgcEN.FuncModuleNameSim = objRow[conQxFuncModule_Agc.FuncModuleNameSim] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objQxFuncModule_AgcEN.QxPrjId = objRow[conQxFuncModule_Agc.QxPrjId].ToString().Trim(); //项目Id
objQxFuncModule_AgcEN.OrderNum = Int32.Parse(objRow[conQxFuncModule_Agc.OrderNum].ToString().Trim()); //排序号
objQxFuncModule_AgcEN.UseStateId = objRow[conQxFuncModule_Agc.UseStateId].ToString().Trim(); //UseStateId
objQxFuncModule_AgcEN.UpdUser = objRow[conQxFuncModule_Agc.UpdUser] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.UpdUser].ToString().Trim(); //修改用户
objQxFuncModule_AgcEN.UpdDate = objRow[conQxFuncModule_Agc.UpdDate] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.UpdDate].ToString().Trim(); //修改日期
objQxFuncModule_AgcEN.Memo = objRow[conQxFuncModule_Agc.Memo] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.Memo].ToString().Trim(); //备注
objQxFuncModule_AgcEN.SynchDate = objRow[conQxFuncModule_Agc.SynchDate] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.SynchDate].ToString().Trim(); //同步日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxFuncModule_AgcEN.FuncModuleAgcId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxFuncModule_AgcEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objQxFuncModule_AgcCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsQxFuncModule_AgcEN> GetSubObjLstCache(clsQxFuncModule_AgcEN objQxFuncModule_AgcCond)
{
List<clsQxFuncModule_AgcEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxFuncModule_AgcEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxFuncModule_Agc.AttributeName)
{
if (objQxFuncModule_AgcCond.IsUpdated(strFldName) == false) continue;
if (objQxFuncModule_AgcCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxFuncModule_AgcCond[strFldName].ToString());
}
else
{
if (objQxFuncModule_AgcCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxFuncModule_AgcCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxFuncModule_AgcCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxFuncModule_AgcCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxFuncModule_AgcCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxFuncModule_AgcCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxFuncModule_AgcCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxFuncModule_AgcCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxFuncModule_AgcCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxFuncModule_AgcCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxFuncModule_AgcCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxFuncModule_AgcCond[strFldName]));
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
public static List<clsQxFuncModule_AgcEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsQxFuncModule_AgcEN> arrObjLst = new List<clsQxFuncModule_AgcEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxFuncModule_AgcEN objQxFuncModule_AgcEN = new clsQxFuncModule_AgcEN();
try
{
objQxFuncModule_AgcEN.FuncModuleAgcId = objRow[conQxFuncModule_Agc.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objQxFuncModule_AgcEN.FuncModuleName = objRow[conQxFuncModule_Agc.FuncModuleName].ToString().Trim(); //模块名
objQxFuncModule_AgcEN.FuncModuleEnName = objRow[conQxFuncModule_Agc.FuncModuleEnName] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.FuncModuleEnName].ToString().Trim(); //模块英文名
objQxFuncModule_AgcEN.FuncModuleNameSim = objRow[conQxFuncModule_Agc.FuncModuleNameSim] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objQxFuncModule_AgcEN.QxPrjId = objRow[conQxFuncModule_Agc.QxPrjId].ToString().Trim(); //项目Id
objQxFuncModule_AgcEN.OrderNum = Int32.Parse(objRow[conQxFuncModule_Agc.OrderNum].ToString().Trim()); //排序号
objQxFuncModule_AgcEN.UseStateId = objRow[conQxFuncModule_Agc.UseStateId].ToString().Trim(); //UseStateId
objQxFuncModule_AgcEN.UpdUser = objRow[conQxFuncModule_Agc.UpdUser] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.UpdUser].ToString().Trim(); //修改用户
objQxFuncModule_AgcEN.UpdDate = objRow[conQxFuncModule_Agc.UpdDate] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.UpdDate].ToString().Trim(); //修改日期
objQxFuncModule_AgcEN.Memo = objRow[conQxFuncModule_Agc.Memo] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.Memo].ToString().Trim(); //备注
objQxFuncModule_AgcEN.SynchDate = objRow[conQxFuncModule_Agc.SynchDate] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.SynchDate].ToString().Trim(); //同步日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxFuncModule_AgcEN.FuncModuleAgcId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxFuncModule_AgcEN);
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
public static List<clsQxFuncModule_AgcEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsQxFuncModule_AgcEN> arrObjLst = new List<clsQxFuncModule_AgcEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxFuncModule_AgcEN objQxFuncModule_AgcEN = new clsQxFuncModule_AgcEN();
try
{
objQxFuncModule_AgcEN.FuncModuleAgcId = objRow[conQxFuncModule_Agc.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objQxFuncModule_AgcEN.FuncModuleName = objRow[conQxFuncModule_Agc.FuncModuleName].ToString().Trim(); //模块名
objQxFuncModule_AgcEN.FuncModuleEnName = objRow[conQxFuncModule_Agc.FuncModuleEnName] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.FuncModuleEnName].ToString().Trim(); //模块英文名
objQxFuncModule_AgcEN.FuncModuleNameSim = objRow[conQxFuncModule_Agc.FuncModuleNameSim] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objQxFuncModule_AgcEN.QxPrjId = objRow[conQxFuncModule_Agc.QxPrjId].ToString().Trim(); //项目Id
objQxFuncModule_AgcEN.OrderNum = Int32.Parse(objRow[conQxFuncModule_Agc.OrderNum].ToString().Trim()); //排序号
objQxFuncModule_AgcEN.UseStateId = objRow[conQxFuncModule_Agc.UseStateId].ToString().Trim(); //UseStateId
objQxFuncModule_AgcEN.UpdUser = objRow[conQxFuncModule_Agc.UpdUser] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.UpdUser].ToString().Trim(); //修改用户
objQxFuncModule_AgcEN.UpdDate = objRow[conQxFuncModule_Agc.UpdDate] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.UpdDate].ToString().Trim(); //修改日期
objQxFuncModule_AgcEN.Memo = objRow[conQxFuncModule_Agc.Memo] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.Memo].ToString().Trim(); //备注
objQxFuncModule_AgcEN.SynchDate = objRow[conQxFuncModule_Agc.SynchDate] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.SynchDate].ToString().Trim(); //同步日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxFuncModule_AgcEN.FuncModuleAgcId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxFuncModule_AgcEN);
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
List<clsQxFuncModule_AgcEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsQxFuncModule_AgcEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxFuncModule_AgcEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsQxFuncModule_AgcEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsQxFuncModule_AgcEN> arrObjLst = new List<clsQxFuncModule_AgcEN>(); 
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
	clsQxFuncModule_AgcEN objQxFuncModule_AgcEN = new clsQxFuncModule_AgcEN();
try
{
objQxFuncModule_AgcEN.FuncModuleAgcId = objRow[conQxFuncModule_Agc.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objQxFuncModule_AgcEN.FuncModuleName = objRow[conQxFuncModule_Agc.FuncModuleName].ToString().Trim(); //模块名
objQxFuncModule_AgcEN.FuncModuleEnName = objRow[conQxFuncModule_Agc.FuncModuleEnName] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.FuncModuleEnName].ToString().Trim(); //模块英文名
objQxFuncModule_AgcEN.FuncModuleNameSim = objRow[conQxFuncModule_Agc.FuncModuleNameSim] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objQxFuncModule_AgcEN.QxPrjId = objRow[conQxFuncModule_Agc.QxPrjId].ToString().Trim(); //项目Id
objQxFuncModule_AgcEN.OrderNum = Int32.Parse(objRow[conQxFuncModule_Agc.OrderNum].ToString().Trim()); //排序号
objQxFuncModule_AgcEN.UseStateId = objRow[conQxFuncModule_Agc.UseStateId].ToString().Trim(); //UseStateId
objQxFuncModule_AgcEN.UpdUser = objRow[conQxFuncModule_Agc.UpdUser] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.UpdUser].ToString().Trim(); //修改用户
objQxFuncModule_AgcEN.UpdDate = objRow[conQxFuncModule_Agc.UpdDate] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.UpdDate].ToString().Trim(); //修改日期
objQxFuncModule_AgcEN.Memo = objRow[conQxFuncModule_Agc.Memo] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.Memo].ToString().Trim(); //备注
objQxFuncModule_AgcEN.SynchDate = objRow[conQxFuncModule_Agc.SynchDate] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.SynchDate].ToString().Trim(); //同步日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxFuncModule_AgcEN.FuncModuleAgcId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxFuncModule_AgcEN);
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
public static List<clsQxFuncModule_AgcEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsQxFuncModule_AgcEN> arrObjLst = new List<clsQxFuncModule_AgcEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxFuncModule_AgcEN objQxFuncModule_AgcEN = new clsQxFuncModule_AgcEN();
try
{
objQxFuncModule_AgcEN.FuncModuleAgcId = objRow[conQxFuncModule_Agc.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objQxFuncModule_AgcEN.FuncModuleName = objRow[conQxFuncModule_Agc.FuncModuleName].ToString().Trim(); //模块名
objQxFuncModule_AgcEN.FuncModuleEnName = objRow[conQxFuncModule_Agc.FuncModuleEnName] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.FuncModuleEnName].ToString().Trim(); //模块英文名
objQxFuncModule_AgcEN.FuncModuleNameSim = objRow[conQxFuncModule_Agc.FuncModuleNameSim] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objQxFuncModule_AgcEN.QxPrjId = objRow[conQxFuncModule_Agc.QxPrjId].ToString().Trim(); //项目Id
objQxFuncModule_AgcEN.OrderNum = Int32.Parse(objRow[conQxFuncModule_Agc.OrderNum].ToString().Trim()); //排序号
objQxFuncModule_AgcEN.UseStateId = objRow[conQxFuncModule_Agc.UseStateId].ToString().Trim(); //UseStateId
objQxFuncModule_AgcEN.UpdUser = objRow[conQxFuncModule_Agc.UpdUser] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.UpdUser].ToString().Trim(); //修改用户
objQxFuncModule_AgcEN.UpdDate = objRow[conQxFuncModule_Agc.UpdDate] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.UpdDate].ToString().Trim(); //修改日期
objQxFuncModule_AgcEN.Memo = objRow[conQxFuncModule_Agc.Memo] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.Memo].ToString().Trim(); //备注
objQxFuncModule_AgcEN.SynchDate = objRow[conQxFuncModule_Agc.SynchDate] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.SynchDate].ToString().Trim(); //同步日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxFuncModule_AgcEN.FuncModuleAgcId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxFuncModule_AgcEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsQxFuncModule_AgcEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsQxFuncModule_AgcEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsQxFuncModule_AgcEN> arrObjLst = new List<clsQxFuncModule_AgcEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxFuncModule_AgcEN objQxFuncModule_AgcEN = new clsQxFuncModule_AgcEN();
try
{
objQxFuncModule_AgcEN.FuncModuleAgcId = objRow[conQxFuncModule_Agc.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objQxFuncModule_AgcEN.FuncModuleName = objRow[conQxFuncModule_Agc.FuncModuleName].ToString().Trim(); //模块名
objQxFuncModule_AgcEN.FuncModuleEnName = objRow[conQxFuncModule_Agc.FuncModuleEnName] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.FuncModuleEnName].ToString().Trim(); //模块英文名
objQxFuncModule_AgcEN.FuncModuleNameSim = objRow[conQxFuncModule_Agc.FuncModuleNameSim] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objQxFuncModule_AgcEN.QxPrjId = objRow[conQxFuncModule_Agc.QxPrjId].ToString().Trim(); //项目Id
objQxFuncModule_AgcEN.OrderNum = Int32.Parse(objRow[conQxFuncModule_Agc.OrderNum].ToString().Trim()); //排序号
objQxFuncModule_AgcEN.UseStateId = objRow[conQxFuncModule_Agc.UseStateId].ToString().Trim(); //UseStateId
objQxFuncModule_AgcEN.UpdUser = objRow[conQxFuncModule_Agc.UpdUser] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.UpdUser].ToString().Trim(); //修改用户
objQxFuncModule_AgcEN.UpdDate = objRow[conQxFuncModule_Agc.UpdDate] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.UpdDate].ToString().Trim(); //修改日期
objQxFuncModule_AgcEN.Memo = objRow[conQxFuncModule_Agc.Memo] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.Memo].ToString().Trim(); //备注
objQxFuncModule_AgcEN.SynchDate = objRow[conQxFuncModule_Agc.SynchDate] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.SynchDate].ToString().Trim(); //同步日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxFuncModule_AgcEN.FuncModuleAgcId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxFuncModule_AgcEN);
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
public static List<clsQxFuncModule_AgcEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsQxFuncModule_AgcEN> arrObjLst = new List<clsQxFuncModule_AgcEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxFuncModule_AgcEN objQxFuncModule_AgcEN = new clsQxFuncModule_AgcEN();
try
{
objQxFuncModule_AgcEN.FuncModuleAgcId = objRow[conQxFuncModule_Agc.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objQxFuncModule_AgcEN.FuncModuleName = objRow[conQxFuncModule_Agc.FuncModuleName].ToString().Trim(); //模块名
objQxFuncModule_AgcEN.FuncModuleEnName = objRow[conQxFuncModule_Agc.FuncModuleEnName] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.FuncModuleEnName].ToString().Trim(); //模块英文名
objQxFuncModule_AgcEN.FuncModuleNameSim = objRow[conQxFuncModule_Agc.FuncModuleNameSim] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objQxFuncModule_AgcEN.QxPrjId = objRow[conQxFuncModule_Agc.QxPrjId].ToString().Trim(); //项目Id
objQxFuncModule_AgcEN.OrderNum = Int32.Parse(objRow[conQxFuncModule_Agc.OrderNum].ToString().Trim()); //排序号
objQxFuncModule_AgcEN.UseStateId = objRow[conQxFuncModule_Agc.UseStateId].ToString().Trim(); //UseStateId
objQxFuncModule_AgcEN.UpdUser = objRow[conQxFuncModule_Agc.UpdUser] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.UpdUser].ToString().Trim(); //修改用户
objQxFuncModule_AgcEN.UpdDate = objRow[conQxFuncModule_Agc.UpdDate] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.UpdDate].ToString().Trim(); //修改日期
objQxFuncModule_AgcEN.Memo = objRow[conQxFuncModule_Agc.Memo] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.Memo].ToString().Trim(); //备注
objQxFuncModule_AgcEN.SynchDate = objRow[conQxFuncModule_Agc.SynchDate] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.SynchDate].ToString().Trim(); //同步日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxFuncModule_AgcEN.FuncModuleAgcId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxFuncModule_AgcEN);
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
public static IEnumerable<clsQxFuncModule_AgcEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsQxFuncModule_AgcEN objQxFuncModule_AgcCond, string strOrderBy)
{
List<clsQxFuncModule_AgcEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxFuncModule_AgcEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxFuncModule_Agc.AttributeName)
{
if (objQxFuncModule_AgcCond.IsUpdated(strFldName) == false) continue;
if (objQxFuncModule_AgcCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxFuncModule_AgcCond[strFldName].ToString());
}
else
{
if (objQxFuncModule_AgcCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxFuncModule_AgcCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxFuncModule_AgcCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxFuncModule_AgcCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxFuncModule_AgcCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxFuncModule_AgcCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxFuncModule_AgcCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxFuncModule_AgcCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxFuncModule_AgcCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxFuncModule_AgcCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxFuncModule_AgcCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxFuncModule_AgcCond[strFldName]));
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
public static IEnumerable<clsQxFuncModule_AgcEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsQxFuncModule_AgcEN objQxFuncModule_AgcCond = JsonConvert.DeserializeObject<clsQxFuncModule_AgcEN>(objPagerPara.whereCond);
if (objQxFuncModule_AgcCond.sfFldComparisonOp == null)
{
objQxFuncModule_AgcCond.dicFldComparisonOp = null;
}
else
{
objQxFuncModule_AgcCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objQxFuncModule_AgcCond.sfFldComparisonOp);
}
clsQxFuncModule_AgcBL.SetUpdFlag(objQxFuncModule_AgcCond);
 try
{
CheckProperty4Condition(objQxFuncModule_AgcCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsQxFuncModule_AgcBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objQxFuncModule_AgcCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxFuncModule_AgcEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsQxFuncModule_AgcEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsQxFuncModule_AgcEN> arrObjLst = new List<clsQxFuncModule_AgcEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxFuncModule_AgcEN objQxFuncModule_AgcEN = new clsQxFuncModule_AgcEN();
try
{
objQxFuncModule_AgcEN.FuncModuleAgcId = objRow[conQxFuncModule_Agc.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objQxFuncModule_AgcEN.FuncModuleName = objRow[conQxFuncModule_Agc.FuncModuleName].ToString().Trim(); //模块名
objQxFuncModule_AgcEN.FuncModuleEnName = objRow[conQxFuncModule_Agc.FuncModuleEnName] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.FuncModuleEnName].ToString().Trim(); //模块英文名
objQxFuncModule_AgcEN.FuncModuleNameSim = objRow[conQxFuncModule_Agc.FuncModuleNameSim] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objQxFuncModule_AgcEN.QxPrjId = objRow[conQxFuncModule_Agc.QxPrjId].ToString().Trim(); //项目Id
objQxFuncModule_AgcEN.OrderNum = Int32.Parse(objRow[conQxFuncModule_Agc.OrderNum].ToString().Trim()); //排序号
objQxFuncModule_AgcEN.UseStateId = objRow[conQxFuncModule_Agc.UseStateId].ToString().Trim(); //UseStateId
objQxFuncModule_AgcEN.UpdUser = objRow[conQxFuncModule_Agc.UpdUser] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.UpdUser].ToString().Trim(); //修改用户
objQxFuncModule_AgcEN.UpdDate = objRow[conQxFuncModule_Agc.UpdDate] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.UpdDate].ToString().Trim(); //修改日期
objQxFuncModule_AgcEN.Memo = objRow[conQxFuncModule_Agc.Memo] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.Memo].ToString().Trim(); //备注
objQxFuncModule_AgcEN.SynchDate = objRow[conQxFuncModule_Agc.SynchDate] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.SynchDate].ToString().Trim(); //同步日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxFuncModule_AgcEN.FuncModuleAgcId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxFuncModule_AgcEN);
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
public static List<clsQxFuncModule_AgcEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsQxFuncModule_AgcEN> arrObjLst = new List<clsQxFuncModule_AgcEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxFuncModule_AgcEN objQxFuncModule_AgcEN = new clsQxFuncModule_AgcEN();
try
{
objQxFuncModule_AgcEN.FuncModuleAgcId = objRow[conQxFuncModule_Agc.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objQxFuncModule_AgcEN.FuncModuleName = objRow[conQxFuncModule_Agc.FuncModuleName].ToString().Trim(); //模块名
objQxFuncModule_AgcEN.FuncModuleEnName = objRow[conQxFuncModule_Agc.FuncModuleEnName] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.FuncModuleEnName].ToString().Trim(); //模块英文名
objQxFuncModule_AgcEN.FuncModuleNameSim = objRow[conQxFuncModule_Agc.FuncModuleNameSim] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objQxFuncModule_AgcEN.QxPrjId = objRow[conQxFuncModule_Agc.QxPrjId].ToString().Trim(); //项目Id
objQxFuncModule_AgcEN.OrderNum = Int32.Parse(objRow[conQxFuncModule_Agc.OrderNum].ToString().Trim()); //排序号
objQxFuncModule_AgcEN.UseStateId = objRow[conQxFuncModule_Agc.UseStateId].ToString().Trim(); //UseStateId
objQxFuncModule_AgcEN.UpdUser = objRow[conQxFuncModule_Agc.UpdUser] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.UpdUser].ToString().Trim(); //修改用户
objQxFuncModule_AgcEN.UpdDate = objRow[conQxFuncModule_Agc.UpdDate] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.UpdDate].ToString().Trim(); //修改日期
objQxFuncModule_AgcEN.Memo = objRow[conQxFuncModule_Agc.Memo] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.Memo].ToString().Trim(); //备注
objQxFuncModule_AgcEN.SynchDate = objRow[conQxFuncModule_Agc.SynchDate] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.SynchDate].ToString().Trim(); //同步日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxFuncModule_AgcEN.FuncModuleAgcId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxFuncModule_AgcEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxFuncModule_AgcEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsQxFuncModule_AgcEN> arrObjLst = new List<clsQxFuncModule_AgcEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxFuncModule_AgcEN objQxFuncModule_AgcEN = new clsQxFuncModule_AgcEN();
try
{
objQxFuncModule_AgcEN.FuncModuleAgcId = objRow[conQxFuncModule_Agc.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objQxFuncModule_AgcEN.FuncModuleName = objRow[conQxFuncModule_Agc.FuncModuleName].ToString().Trim(); //模块名
objQxFuncModule_AgcEN.FuncModuleEnName = objRow[conQxFuncModule_Agc.FuncModuleEnName] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.FuncModuleEnName].ToString().Trim(); //模块英文名
objQxFuncModule_AgcEN.FuncModuleNameSim = objRow[conQxFuncModule_Agc.FuncModuleNameSim] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objQxFuncModule_AgcEN.QxPrjId = objRow[conQxFuncModule_Agc.QxPrjId].ToString().Trim(); //项目Id
objQxFuncModule_AgcEN.OrderNum = Int32.Parse(objRow[conQxFuncModule_Agc.OrderNum].ToString().Trim()); //排序号
objQxFuncModule_AgcEN.UseStateId = objRow[conQxFuncModule_Agc.UseStateId].ToString().Trim(); //UseStateId
objQxFuncModule_AgcEN.UpdUser = objRow[conQxFuncModule_Agc.UpdUser] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.UpdUser].ToString().Trim(); //修改用户
objQxFuncModule_AgcEN.UpdDate = objRow[conQxFuncModule_Agc.UpdDate] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.UpdDate].ToString().Trim(); //修改日期
objQxFuncModule_AgcEN.Memo = objRow[conQxFuncModule_Agc.Memo] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.Memo].ToString().Trim(); //备注
objQxFuncModule_AgcEN.SynchDate = objRow[conQxFuncModule_Agc.SynchDate] == DBNull.Value ? null : objRow[conQxFuncModule_Agc.SynchDate].ToString().Trim(); //同步日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxFuncModule_AgcEN.FuncModuleAgcId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxFuncModule_AgcEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objQxFuncModule_AgcEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxFuncModule_Agc(ref clsQxFuncModule_AgcEN objQxFuncModule_AgcEN)
{
bool bolResult = QxFuncModule_AgcDA.GetQxFuncModule_Agc(ref objQxFuncModule_AgcEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strFuncModuleAgcId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxFuncModule_AgcEN GetObjByFuncModuleAgcId(string strFuncModuleAgcId)
{
if (strFuncModuleAgcId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strFuncModuleAgcId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strFuncModuleAgcId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strFuncModuleAgcId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsQxFuncModule_AgcEN objQxFuncModule_AgcEN = QxFuncModule_AgcDA.GetObjByFuncModuleAgcId(strFuncModuleAgcId);
return objQxFuncModule_AgcEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsQxFuncModule_AgcEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsQxFuncModule_AgcEN objQxFuncModule_AgcEN = QxFuncModule_AgcDA.GetFirstObj(strWhereCond);
 return objQxFuncModule_AgcEN;
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
public static clsQxFuncModule_AgcEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsQxFuncModule_AgcEN objQxFuncModule_AgcEN = QxFuncModule_AgcDA.GetObjByDataRow(objRow);
 return objQxFuncModule_AgcEN;
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
public static clsQxFuncModule_AgcEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsQxFuncModule_AgcEN objQxFuncModule_AgcEN = QxFuncModule_AgcDA.GetObjByDataRow(objRow);
 return objQxFuncModule_AgcEN;
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
 /// <param name = "strFuncModuleAgcId">所给的关键字</param>
 /// <param name = "lstQxFuncModule_AgcObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxFuncModule_AgcEN GetObjByFuncModuleAgcIdFromList(string strFuncModuleAgcId, List<clsQxFuncModule_AgcEN> lstQxFuncModule_AgcObjLst)
{
foreach (clsQxFuncModule_AgcEN objQxFuncModule_AgcEN in lstQxFuncModule_AgcObjLst)
{
if (objQxFuncModule_AgcEN.FuncModuleAgcId == strFuncModuleAgcId)
{
return objQxFuncModule_AgcEN;
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
 string strFuncModuleAgcId;
 try
 {
 strFuncModuleAgcId = new clsQxFuncModule_AgcDA().GetFirstID(strWhereCond);
 return strFuncModuleAgcId;
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
 arrList = QxFuncModule_AgcDA.GetID(strWhereCond);
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
bool bolIsExist = QxFuncModule_AgcDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strFuncModuleAgcId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strFuncModuleAgcId)
{
if (string.IsNullOrEmpty(strFuncModuleAgcId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strFuncModuleAgcId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = QxFuncModule_AgcDA.IsExist(strFuncModuleAgcId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strFuncModuleAgcId">功能模块Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strFuncModuleAgcId, string strOpUser)
{
clsQxFuncModule_AgcEN objQxFuncModule_AgcEN = clsQxFuncModule_AgcBL.GetObjByFuncModuleAgcId(strFuncModuleAgcId);
objQxFuncModule_AgcEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objQxFuncModule_AgcEN.UpdUser = strOpUser;
return clsQxFuncModule_AgcBL.UpdateBySql2(objQxFuncModule_AgcEN);
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
 bolIsExist = clsQxFuncModule_AgcDA.IsExistTable();
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
 bolIsExist = QxFuncModule_AgcDA.IsExistTable(strTabName);
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
 /// <param name = "objQxFuncModule_AgcEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsQxFuncModule_AgcEN objQxFuncModule_AgcEN)
{
 if (string.IsNullOrEmpty(objQxFuncModule_AgcEN.FuncModuleAgcId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQxFuncModule_AgcBL.IsExist(objQxFuncModule_AgcEN.FuncModuleAgcId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQxFuncModule_AgcEN.FuncModuleAgcId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = QxFuncModule_AgcDA.AddNewRecordBySQL2(objQxFuncModule_AgcEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxFuncModule_AgcBL.ReFreshCache();

if (clsQxFuncModule_AgcBL.relatedActions != null)
{
clsQxFuncModule_AgcBL.relatedActions.UpdRelaTabDate(objQxFuncModule_AgcEN.FuncModuleAgcId, objQxFuncModule_AgcEN.UpdUser);
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
 /// <param name = "objQxFuncModule_AgcEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsQxFuncModule_AgcEN objQxFuncModule_AgcEN)
{
 if (string.IsNullOrEmpty(objQxFuncModule_AgcEN.FuncModuleAgcId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQxFuncModule_AgcBL.IsExist(objQxFuncModule_AgcEN.FuncModuleAgcId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQxFuncModule_AgcEN.FuncModuleAgcId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = QxFuncModule_AgcDA.AddNewRecordBySQL2WithReturnKey(objQxFuncModule_AgcEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxFuncModule_AgcBL.ReFreshCache();

if (clsQxFuncModule_AgcBL.relatedActions != null)
{
clsQxFuncModule_AgcBL.relatedActions.UpdRelaTabDate(objQxFuncModule_AgcEN.FuncModuleAgcId, objQxFuncModule_AgcEN.UpdUser);
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
 /// <param name = "strQxFuncModule_AgcObjXml">代表实体对象的XML串</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql_XML(string strQxFuncModule_AgcObjXml)
{
clsQxFuncModule_AgcEN objQxFuncModule_AgcEN = GetObjFromXmlStr(strQxFuncModule_AgcObjXml);
try
{
bool bolResult = QxFuncModule_AgcDA.AddNewRecordBySQL2(objQxFuncModule_AgcEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxFuncModule_AgcBL.ReFreshCache();

if (clsQxFuncModule_AgcBL.relatedActions != null)
{
clsQxFuncModule_AgcBL.relatedActions.UpdRelaTabDate(objQxFuncModule_AgcEN.FuncModuleAgcId, objQxFuncModule_AgcEN.UpdUser);
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
 /// <param name = "objQxFuncModule_AgcEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsQxFuncModule_AgcEN objQxFuncModule_AgcEN)
{
try
{
bool bolResult = QxFuncModule_AgcDA.Update(objQxFuncModule_AgcEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxFuncModule_AgcBL.ReFreshCache();

if (clsQxFuncModule_AgcBL.relatedActions != null)
{
clsQxFuncModule_AgcBL.relatedActions.UpdRelaTabDate(objQxFuncModule_AgcEN.FuncModuleAgcId, objQxFuncModule_AgcEN.UpdUser);
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
 /// <param name = "objQxFuncModule_AgcEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsQxFuncModule_AgcEN objQxFuncModule_AgcEN)
{
 if (string.IsNullOrEmpty(objQxFuncModule_AgcEN.FuncModuleAgcId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = QxFuncModule_AgcDA.UpdateBySql2(objQxFuncModule_AgcEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxFuncModule_AgcBL.ReFreshCache();

if (clsQxFuncModule_AgcBL.relatedActions != null)
{
clsQxFuncModule_AgcBL.relatedActions.UpdRelaTabDate(objQxFuncModule_AgcEN.FuncModuleAgcId, objQxFuncModule_AgcEN.UpdUser);
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
 /// <param name = "strQxFuncModule_AgcObjXml">需要修改的对象,用XML来表示</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql_XML(string strQxFuncModule_AgcObjXml)
{
clsQxFuncModule_AgcEN objQxFuncModule_AgcEN = GetObjFromXmlStr(strQxFuncModule_AgcObjXml);
try
{
bool bolResult = QxFuncModule_AgcDA.UpdateBySql2(objQxFuncModule_AgcEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxFuncModule_AgcBL.ReFreshCache();

if (clsQxFuncModule_AgcBL.relatedActions != null)
{
clsQxFuncModule_AgcBL.relatedActions.UpdRelaTabDate(objQxFuncModule_AgcEN.FuncModuleAgcId, objQxFuncModule_AgcEN.UpdUser);
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
 /// <param name = "strFuncModuleAgcId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strFuncModuleAgcId)
{
try
{
 clsQxFuncModule_AgcEN objQxFuncModule_AgcEN = clsQxFuncModule_AgcBL.GetObjByFuncModuleAgcId(strFuncModuleAgcId);

if (clsQxFuncModule_AgcBL.relatedActions != null)
{
clsQxFuncModule_AgcBL.relatedActions.UpdRelaTabDate(objQxFuncModule_AgcEN.FuncModuleAgcId, objQxFuncModule_AgcEN.UpdUser);
}
if (objQxFuncModule_AgcEN != null)
{
int intRecNum = QxFuncModule_AgcDA.DelRecord(strFuncModuleAgcId);
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
/// <param name="strFuncModuleAgcId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strFuncModuleAgcId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
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
//删除与表:[QxFuncModule_Agc]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conQxFuncModule_Agc.FuncModuleAgcId,
//strFuncModuleAgcId);
//        clsQxFuncModule_AgcBL.DelQxFuncModule_AgcsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxFuncModule_AgcBL.DelRecord(strFuncModuleAgcId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxFuncModule_AgcBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strFuncModuleAgcId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strFuncModuleAgcId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strFuncModuleAgcId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsQxFuncModule_AgcBL.relatedActions != null)
{
clsQxFuncModule_AgcBL.relatedActions.UpdRelaTabDate(strFuncModuleAgcId, "UpdRelaTabDate");
}
bool bolResult = QxFuncModule_AgcDA.DelRecord(strFuncModuleAgcId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "strFuncModuleAgcId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strFuncModuleAgcId) 
{
try
{
if (clsQxFuncModule_AgcBL.relatedActions != null)
{
clsQxFuncModule_AgcBL.relatedActions.UpdRelaTabDate(strFuncModuleAgcId, "UpdRelaTabDate");
}
bool bolResult = QxFuncModule_AgcDA.DelRecordBySP(strFuncModuleAgcId);
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
 /// <param name = "arrFuncModuleAgcIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelQxFuncModule_Agcs(List<string> arrFuncModuleAgcIdLst)
{
if (arrFuncModuleAgcIdLst.Count == 0) return 0;
try
{
if (clsQxFuncModule_AgcBL.relatedActions != null)
{
foreach (var strFuncModuleAgcId in arrFuncModuleAgcIdLst)
{
clsQxFuncModule_AgcBL.relatedActions.UpdRelaTabDate(strFuncModuleAgcId, "UpdRelaTabDate");
}
}
int intDelRecNum = QxFuncModule_AgcDA.DelQxFuncModule_Agc(arrFuncModuleAgcIdLst);
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
public static int DelQxFuncModule_AgcsByCond(string strWhereCond)
{
try
{
if (clsQxFuncModule_AgcBL.relatedActions != null)
{
List<string> arrFuncModuleAgcId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strFuncModuleAgcId in arrFuncModuleAgcId)
{
clsQxFuncModule_AgcBL.relatedActions.UpdRelaTabDate(strFuncModuleAgcId, "UpdRelaTabDate");
}
}
int intRecNum = QxFuncModule_AgcDA.DelQxFuncModule_Agc(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[QxFuncModule_Agc]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strFuncModuleAgcId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strFuncModuleAgcId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
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
//删除与表:[QxFuncModule_Agc]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxFuncModule_AgcBL.DelRecord(strFuncModuleAgcId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxFuncModule_AgcBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strFuncModuleAgcId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objQxFuncModule_AgcENS">源对象</param>
 /// <param name = "objQxFuncModule_AgcENT">目标对象</param>
 public static void CopyTo(clsQxFuncModule_AgcEN objQxFuncModule_AgcENS, clsQxFuncModule_AgcEN objQxFuncModule_AgcENT)
{
try
{
objQxFuncModule_AgcENT.FuncModuleAgcId = objQxFuncModule_AgcENS.FuncModuleAgcId; //功能模块Id
objQxFuncModule_AgcENT.FuncModuleName = objQxFuncModule_AgcENS.FuncModuleName; //模块名
objQxFuncModule_AgcENT.FuncModuleEnName = objQxFuncModule_AgcENS.FuncModuleEnName; //模块英文名
objQxFuncModule_AgcENT.FuncModuleNameSim = objQxFuncModule_AgcENS.FuncModuleNameSim; //模块名_Sim
objQxFuncModule_AgcENT.QxPrjId = objQxFuncModule_AgcENS.QxPrjId; //项目Id
objQxFuncModule_AgcENT.OrderNum = objQxFuncModule_AgcENS.OrderNum; //排序号
objQxFuncModule_AgcENT.UseStateId = objQxFuncModule_AgcENS.UseStateId; //UseStateId
objQxFuncModule_AgcENT.UpdUser = objQxFuncModule_AgcENS.UpdUser; //修改用户
objQxFuncModule_AgcENT.UpdDate = objQxFuncModule_AgcENS.UpdDate; //修改日期
objQxFuncModule_AgcENT.Memo = objQxFuncModule_AgcENS.Memo; //备注
objQxFuncModule_AgcENT.SynchDate = objQxFuncModule_AgcENS.SynchDate; //同步日期
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
 /// <param name = "objQxFuncModule_AgcEN">源简化对象</param>
 public static void SetUpdFlag(clsQxFuncModule_AgcEN objQxFuncModule_AgcEN)
{
try
{
objQxFuncModule_AgcEN.ClearUpdateState();
   string strsfUpdFldSetStr = objQxFuncModule_AgcEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conQxFuncModule_Agc.FuncModuleAgcId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxFuncModule_AgcEN.FuncModuleAgcId = objQxFuncModule_AgcEN.FuncModuleAgcId; //功能模块Id
}
if (arrFldSet.Contains(conQxFuncModule_Agc.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objQxFuncModule_AgcEN.FuncModuleName = objQxFuncModule_AgcEN.FuncModuleName; //模块名
}
if (arrFldSet.Contains(conQxFuncModule_Agc.FuncModuleEnName, new clsStrCompareIgnoreCase())  ==  true)
{
objQxFuncModule_AgcEN.FuncModuleEnName = objQxFuncModule_AgcEN.FuncModuleEnName == "[null]" ? null :  objQxFuncModule_AgcEN.FuncModuleEnName; //模块英文名
}
if (arrFldSet.Contains(conQxFuncModule_Agc.FuncModuleNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objQxFuncModule_AgcEN.FuncModuleNameSim = objQxFuncModule_AgcEN.FuncModuleNameSim == "[null]" ? null :  objQxFuncModule_AgcEN.FuncModuleNameSim; //模块名_Sim
}
if (arrFldSet.Contains(conQxFuncModule_Agc.QxPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxFuncModule_AgcEN.QxPrjId = objQxFuncModule_AgcEN.QxPrjId; //项目Id
}
if (arrFldSet.Contains(conQxFuncModule_Agc.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objQxFuncModule_AgcEN.OrderNum = objQxFuncModule_AgcEN.OrderNum; //排序号
}
if (arrFldSet.Contains(conQxFuncModule_Agc.UseStateId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxFuncModule_AgcEN.UseStateId = objQxFuncModule_AgcEN.UseStateId; //UseStateId
}
if (arrFldSet.Contains(conQxFuncModule_Agc.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objQxFuncModule_AgcEN.UpdUser = objQxFuncModule_AgcEN.UpdUser == "[null]" ? null :  objQxFuncModule_AgcEN.UpdUser; //修改用户
}
if (arrFldSet.Contains(conQxFuncModule_Agc.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objQxFuncModule_AgcEN.UpdDate = objQxFuncModule_AgcEN.UpdDate == "[null]" ? null :  objQxFuncModule_AgcEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conQxFuncModule_Agc.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objQxFuncModule_AgcEN.Memo = objQxFuncModule_AgcEN.Memo == "[null]" ? null :  objQxFuncModule_AgcEN.Memo; //备注
}
if (arrFldSet.Contains(conQxFuncModule_Agc.SynchDate, new clsStrCompareIgnoreCase())  ==  true)
{
objQxFuncModule_AgcEN.SynchDate = objQxFuncModule_AgcEN.SynchDate == "[null]" ? null :  objQxFuncModule_AgcEN.SynchDate; //同步日期
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
 /// <param name = "objQxFuncModule_AgcEN">源简化对象</param>
 public static void AccessFldValueNull(clsQxFuncModule_AgcEN objQxFuncModule_AgcEN)
{
try
{
if (objQxFuncModule_AgcEN.FuncModuleEnName == "[null]") objQxFuncModule_AgcEN.FuncModuleEnName = null; //模块英文名
if (objQxFuncModule_AgcEN.FuncModuleNameSim == "[null]") objQxFuncModule_AgcEN.FuncModuleNameSim = null; //模块名_Sim
if (objQxFuncModule_AgcEN.UpdUser == "[null]") objQxFuncModule_AgcEN.UpdUser = null; //修改用户
if (objQxFuncModule_AgcEN.UpdDate == "[null]") objQxFuncModule_AgcEN.UpdDate = null; //修改日期
if (objQxFuncModule_AgcEN.Memo == "[null]") objQxFuncModule_AgcEN.Memo = null; //备注
if (objQxFuncModule_AgcEN.SynchDate == "[null]") objQxFuncModule_AgcEN.SynchDate = null; //同步日期
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
public static void CheckPropertyNew(clsQxFuncModule_AgcEN objQxFuncModule_AgcEN)
{
 QxFuncModule_AgcDA.CheckPropertyNew(objQxFuncModule_AgcEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsQxFuncModule_AgcEN objQxFuncModule_AgcEN)
{
 QxFuncModule_AgcDA.CheckProperty4Condition(objQxFuncModule_AgcEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_FuncModuleAgcId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conQxFuncModule_Agc.FuncModuleAgcId); 
List<clsQxFuncModule_AgcEN> arrObjLst = clsQxFuncModule_AgcBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsQxFuncModule_AgcEN objQxFuncModule_AgcEN = new clsQxFuncModule_AgcEN()
{
FuncModuleAgcId = "0",
FuncModuleName = "选[功能模块_Agc]..."
};
arrObjLst.Insert(0, objQxFuncModule_AgcEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conQxFuncModule_Agc.FuncModuleAgcId;
objComboBox.DisplayMember = conQxFuncModule_Agc.FuncModuleName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_FuncModuleAgcId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[功能模块_Agc]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conQxFuncModule_Agc.FuncModuleAgcId); 
IEnumerable<clsQxFuncModule_AgcEN> arrObjLst = clsQxFuncModule_AgcBL.GetObjLst(strCondition);
objDDL.DataValueField = conQxFuncModule_Agc.FuncModuleAgcId;
objDDL.DataTextField = conQxFuncModule_Agc.FuncModuleName;
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
public static void BindDdl_FuncModuleAgcIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[功能模块_Agc]...","0");
List<clsQxFuncModule_AgcEN> arrQxFuncModule_AgcObjLst = GetAllQxFuncModule_AgcObjLstCache(); 
arrQxFuncModule_AgcObjLst = arrQxFuncModule_AgcObjLst.OrderBy(x=>x.OrderNum).ToList(); 
objDDL.DataValueField = conQxFuncModule_Agc.FuncModuleAgcId;
objDDL.DataTextField = conQxFuncModule_Agc.FuncModuleName;
objDDL.DataSource = arrQxFuncModule_AgcObjLst;
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
if (clsQxFuncModule_AgcBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxFuncModule_AgcBL没有刷新缓存机制(clsQxFuncModule_AgcBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by FuncModuleAgcId");
//if (arrQxFuncModule_AgcObjLstCache == null)
//{
//arrQxFuncModule_AgcObjLstCache = QxFuncModule_AgcDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strFuncModuleAgcId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxFuncModule_AgcEN GetObjByFuncModuleAgcIdCache(string strFuncModuleAgcId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsQxFuncModule_AgcEN._CurrTabName);
List<clsQxFuncModule_AgcEN> arrQxFuncModule_AgcObjLstCache = GetObjLstCache();
IEnumerable <clsQxFuncModule_AgcEN> arrQxFuncModule_AgcObjLst_Sel =
arrQxFuncModule_AgcObjLstCache
.Where(x=> x.FuncModuleAgcId == strFuncModuleAgcId 
);
if (arrQxFuncModule_AgcObjLst_Sel.Count() == 0)
{
   clsQxFuncModule_AgcEN obj = clsQxFuncModule_AgcBL.GetObjByFuncModuleAgcId(strFuncModuleAgcId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrQxFuncModule_AgcObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFuncModuleAgcId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetFuncModuleNameByFuncModuleAgcIdCache(string strFuncModuleAgcId)
{
if (string.IsNullOrEmpty(strFuncModuleAgcId) == true) return "";
//获取缓存中的对象列表
clsQxFuncModule_AgcEN objQxFuncModule_Agc = GetObjByFuncModuleAgcIdCache(strFuncModuleAgcId);
if (objQxFuncModule_Agc == null) return "";
return objQxFuncModule_Agc.FuncModuleName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFuncModuleAgcId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByFuncModuleAgcIdCache(string strFuncModuleAgcId)
{
if (string.IsNullOrEmpty(strFuncModuleAgcId) == true) return "";
//获取缓存中的对象列表
clsQxFuncModule_AgcEN objQxFuncModule_Agc = GetObjByFuncModuleAgcIdCache(strFuncModuleAgcId);
if (objQxFuncModule_Agc == null) return "";
return objQxFuncModule_Agc.FuncModuleName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxFuncModule_AgcEN> GetAllQxFuncModule_AgcObjLstCache()
{
//获取缓存中的对象列表
List<clsQxFuncModule_AgcEN> arrQxFuncModule_AgcObjLstCache = GetObjLstCache(); 
return arrQxFuncModule_AgcObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxFuncModule_AgcEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsQxFuncModule_AgcEN._CurrTabName);
List<clsQxFuncModule_AgcEN> arrQxFuncModule_AgcObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrQxFuncModule_AgcObjLstCache;
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
string strKey = string.Format("{0}", clsQxFuncModule_AgcEN._CurrTabName);
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
if (clsQxFuncModule_AgcBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsQxFuncModule_AgcEN._CurrTabName);
CacheHelper.Remove(strKey);
clsQxFuncModule_AgcBL.objCommFun4BL.ReFreshCache();
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
 /// <param name = "lstQxFuncModule_AgcObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsQxFuncModule_AgcEN> lstQxFuncModule_AgcObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstQxFuncModule_AgcObjLst, writer);
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
 /// <param name = "lstQxFuncModule_AgcObjLst">[clsQxFuncModule_AgcEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsQxFuncModule_AgcEN> lstQxFuncModule_AgcObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsQxFuncModule_AgcBL.listXmlNode);
writer.WriteStartElement(clsQxFuncModule_AgcBL.itemsXmlNode);
foreach (clsQxFuncModule_AgcEN objQxFuncModule_AgcEN in lstQxFuncModule_AgcObjLst)
{
clsQxFuncModule_AgcBL.SerializeXML(writer, objQxFuncModule_AgcEN);
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
 /// <param name = "objQxFuncModule_AgcEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsQxFuncModule_AgcEN objQxFuncModule_AgcEN)
{
writer.WriteStartElement(clsQxFuncModule_AgcBL.itemXmlNode);
 
if (objQxFuncModule_AgcEN.FuncModuleAgcId != null)
{
writer.WriteElementString(conQxFuncModule_Agc.FuncModuleAgcId, objQxFuncModule_AgcEN.FuncModuleAgcId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxFuncModule_AgcEN.FuncModuleName != null)
{
writer.WriteElementString(conQxFuncModule_Agc.FuncModuleName, objQxFuncModule_AgcEN.FuncModuleName.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxFuncModule_AgcEN.FuncModuleEnName != null)
{
writer.WriteElementString(conQxFuncModule_Agc.FuncModuleEnName, objQxFuncModule_AgcEN.FuncModuleEnName.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxFuncModule_AgcEN.FuncModuleNameSim != null)
{
writer.WriteElementString(conQxFuncModule_Agc.FuncModuleNameSim, objQxFuncModule_AgcEN.FuncModuleNameSim.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxFuncModule_AgcEN.QxPrjId != null)
{
writer.WriteElementString(conQxFuncModule_Agc.QxPrjId, objQxFuncModule_AgcEN.QxPrjId.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(conQxFuncModule_Agc.OrderNum, objQxFuncModule_AgcEN.OrderNum.ToString(CultureInfo.InvariantCulture));
 
if (objQxFuncModule_AgcEN.UseStateId != null)
{
writer.WriteElementString(conQxFuncModule_Agc.UseStateId, objQxFuncModule_AgcEN.UseStateId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxFuncModule_AgcEN.UpdUser != null)
{
writer.WriteElementString(conQxFuncModule_Agc.UpdUser, objQxFuncModule_AgcEN.UpdUser.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxFuncModule_AgcEN.UpdDate != null)
{
writer.WriteElementString(conQxFuncModule_Agc.UpdDate, objQxFuncModule_AgcEN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxFuncModule_AgcEN.Memo != null)
{
writer.WriteElementString(conQxFuncModule_Agc.Memo, objQxFuncModule_AgcEN.Memo.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxFuncModule_AgcEN.SynchDate != null)
{
writer.WriteElementString(conQxFuncModule_Agc.SynchDate, objQxFuncModule_AgcEN.SynchDate.ToString(CultureInfo.InvariantCulture));
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
public static clsQxFuncModule_AgcEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsQxFuncModule_AgcEN objQxFuncModule_AgcEN = new clsQxFuncModule_AgcEN();
reader.Read();
while (!(reader.Name == clsQxFuncModule_AgcBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(conQxFuncModule_Agc.FuncModuleAgcId))
{
objQxFuncModule_AgcEN.FuncModuleAgcId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxFuncModule_Agc.FuncModuleName))
{
objQxFuncModule_AgcEN.FuncModuleName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxFuncModule_Agc.FuncModuleEnName))
{
objQxFuncModule_AgcEN.FuncModuleEnName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxFuncModule_Agc.FuncModuleNameSim))
{
objQxFuncModule_AgcEN.FuncModuleNameSim = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxFuncModule_Agc.QxPrjId))
{
objQxFuncModule_AgcEN.QxPrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxFuncModule_Agc.OrderNum))
{
objQxFuncModule_AgcEN.OrderNum = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(conQxFuncModule_Agc.UseStateId))
{
objQxFuncModule_AgcEN.UseStateId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxFuncModule_Agc.UpdUser))
{
objQxFuncModule_AgcEN.UpdUser = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxFuncModule_Agc.UpdDate))
{
objQxFuncModule_AgcEN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxFuncModule_Agc.Memo))
{
objQxFuncModule_AgcEN.Memo = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxFuncModule_Agc.SynchDate))
{
objQxFuncModule_AgcEN.SynchDate = reader.ReadElementContentAsString();
}
}
return objQxFuncModule_AgcEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strQxFuncModule_AgcObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsQxFuncModule_AgcEN GetObjFromXmlStr(string strQxFuncModule_AgcObjXmlStr)
{
clsQxFuncModule_AgcEN objQxFuncModule_AgcEN = new clsQxFuncModule_AgcEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strQxFuncModule_AgcObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsQxFuncModule_AgcBL.itemXmlNode))
{
objQxFuncModule_AgcEN = GetObjFromXml(reader);
return objQxFuncModule_AgcEN;
}
}
return objQxFuncModule_AgcEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objQxFuncModule_AgcEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsQxFuncModule_AgcEN objQxFuncModule_AgcEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objQxFuncModule_AgcEN);
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
public static string Func(string strInFldName, string strOutFldName, string strFuncModuleAgcId)
{
if (strInFldName != conQxFuncModule_Agc.FuncModuleAgcId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conQxFuncModule_Agc.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conQxFuncModule_Agc.AttributeName));
throw new Exception(strMsg);
}
var objQxFuncModule_Agc = clsQxFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(strFuncModuleAgcId);
if (objQxFuncModule_Agc == null) return "";
return objQxFuncModule_Agc[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objQxFuncModule_AgcEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsQxFuncModule_AgcEN objQxFuncModule_AgcEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsQxFuncModule_AgcEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objQxFuncModule_AgcEN[strField]);
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
 /// <param name = "lstQxFuncModule_AgcObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsQxFuncModule_AgcEN> lstQxFuncModule_AgcObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstQxFuncModule_AgcObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsQxFuncModule_AgcEN objQxFuncModule_AgcEN in lstQxFuncModule_AgcObjLst)
{
string strJSON_One = SerializeObjToJSON(objQxFuncModule_AgcEN);
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
int intRecCount = clsQxFuncModule_AgcDA.GetRecCount(strTabName);
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
int intRecCount = clsQxFuncModule_AgcDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsQxFuncModule_AgcDA.GetRecCount();
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
int intRecCount = clsQxFuncModule_AgcDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objQxFuncModule_AgcCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsQxFuncModule_AgcEN objQxFuncModule_AgcCond)
{
List<clsQxFuncModule_AgcEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxFuncModule_AgcEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxFuncModule_Agc.AttributeName)
{
if (objQxFuncModule_AgcCond.IsUpdated(strFldName) == false) continue;
if (objQxFuncModule_AgcCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxFuncModule_AgcCond[strFldName].ToString());
}
else
{
if (objQxFuncModule_AgcCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxFuncModule_AgcCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxFuncModule_AgcCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxFuncModule_AgcCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxFuncModule_AgcCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxFuncModule_AgcCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxFuncModule_AgcCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxFuncModule_AgcCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxFuncModule_AgcCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxFuncModule_AgcCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxFuncModule_AgcCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxFuncModule_AgcCond[strFldName]));
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
 List<string> arrList = clsQxFuncModule_AgcDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = QxFuncModule_AgcDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = QxFuncModule_AgcDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = QxFuncModule_AgcDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxFuncModule_AgcDA.SetFldValue(clsQxFuncModule_AgcEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = QxFuncModule_AgcDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxFuncModule_AgcDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxFuncModule_AgcDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxFuncModule_AgcDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[QxFuncModule_Agc] "); 
 strCreateTabCode.Append(" ( "); 
 // /**功能模块Id*/ 
 strCreateTabCode.Append(" FuncModuleAgcId char(8) primary key, "); 
 // /**模块名*/ 
 strCreateTabCode.Append(" FuncModuleName varchar(30) not Null, "); 
 // /**模块英文名*/ 
 strCreateTabCode.Append(" FuncModuleEnName varchar(30) Null, "); 
 // /**模块名_Sim*/ 
 strCreateTabCode.Append(" FuncModuleNameSim varchar(30) Null, "); 
 // /**项目Id*/ 
 strCreateTabCode.Append(" QxPrjId char(4) not Null, "); 
 // /**排序号*/ 
 strCreateTabCode.Append(" OrderNum int not Null, "); 
 // /**UseStateId*/ 
 strCreateTabCode.Append(" UseStateId char(4) not Null, "); 
 // /**修改用户*/ 
 strCreateTabCode.Append(" UpdUser varchar(18) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**同步日期*/ 
 strCreateTabCode.Append(" SynchDate varchar(14) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 数据同步


 #endregion 数据同步


 #region 排序相关函数

/// <summary>
/// 重新排序。根据分类字段：QxPrjId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ReOrder)
/// </summary>
/// <param name="strQxPrjId">分类字段</param>
/// <returns></returns>
public static bool ReOrder(string strQxPrjId)
{
try
{
string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conQxFuncModule_Agc.QxPrjId, strQxPrjId);
 strCondition += string.Format(" order by OrderNum ");
List<clsQxFuncModule_AgcEN> arrQxFuncModule_AgcObjList = new clsQxFuncModule_AgcDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsQxFuncModule_AgcEN objQxFuncModule_Agc in arrQxFuncModule_AgcObjList)
{
objQxFuncModule_Agc.OrderNum = intIndex;
UpdateBySql2(objQxFuncModule_Agc);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("重序出错, {0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 调整所给关键字记录的序号。根据分类字段：QxPrjId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_AdjustOrderNum)
/// </summary>
/// <param name="strDirect">方向：用"Up","Down"表示</param>
/// <param name="strFuncModuleAgcId">所给的关键字</param>
/// <param name="strQxPrjId">分类字段</param>
/// <returns>是否成功?</returns>
public static bool AdjustOrderNum(string strDirect, string strFuncModuleAgcId, string strQxPrjId)
{
try
{
//操作步骤：
//1、根据所给定的关键字[FuncModuleAgcId],获取相应的序号[OrderNum]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//   3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字FuncModuleAgcId
//5、把当前关键字FuncModuleAgcId所对应记录的序号加(减)1
//6、把下(上)一个序号关键字FuncModuleAgcId所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
string strPrevFuncModuleAgcId = "";    //上一条序号的关键字FuncModuleAgcId
string strNextFuncModuleAgcId = "";    //下一条序号的关键字FuncModuleAgcId
int intTabRecNum;       //当前表中字段的记录数
StringBuilder sbCondition = new StringBuilder();
//1、根据所给定的关键字[FuncModuleAgcId],获取相应的序号[OrderNum]。

clsQxFuncModule_AgcEN objQxFuncModule_Agc = clsQxFuncModule_AgcBL.GetObjByFuncModuleAgcId(strFuncModuleAgcId);

intOrderNum = objQxFuncModule_Agc.OrderNum;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conQxFuncModule_Agc.QxPrjId, strQxPrjId);
intTabRecNum = clsQxFuncModule_AgcBL.GetRecCountByCond(clsQxFuncModule_AgcEN._CurrTabName, strCondition);    //获取当前表的记录数
switch (strDirect)
{
case "UP":
case "Up":
case "up":
//3、如果是末端序号,就退出；
//  3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	     即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
if (intOrderNum <= 1)
{
strMsg = string.Format("已经是第一条记录,不能再上移.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//		3.2 如果不是,即如果是向下移动,就判断当前序号是否“小于”当前表中的字段数,
//		    即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//		    如果是向上移动,就判断当前序号是否“大于”1,
//		    即不是最开始一个记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
sbCondition.AppendFormat(" {0} = {1} ", conQxFuncModule_Agc.OrderNum, intOrderNum - 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conQxFuncModule_Agc.QxPrjId, strQxPrjId);
//4、获取上一个序号字段的关键字FuncModuleAgcId
strPrevFuncModuleAgcId = clsQxFuncModule_AgcBL.GetFirstID_S(sbCondition.ToString());
if (string.IsNullOrEmpty(strPrevFuncModuleAgcId) == true)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字FuncModuleAgcId所对应记录的序号减1
//6、把下(上)一个序号关键字FuncModuleAgcId所对应的记录序号加1
clsQxFuncModule_AgcBL.SetFldValue(clsQxFuncModule_AgcEN._CurrTabName, conQxFuncModule_Agc.OrderNum,
 	 	intOrderNum - 1,
  	 	string.Format("{0} = '{1}'", conQxFuncModule_Agc.FuncModuleAgcId, strFuncModuleAgcId));
clsQxFuncModule_AgcBL.SetFldValue(clsQxFuncModule_AgcEN._CurrTabName, conQxFuncModule_Agc.OrderNum,
 	 	intPrevOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conQxFuncModule_Agc.FuncModuleAgcId, strPrevFuncModuleAgcId));
break;
case "DOWN":
case "Down":
case "down":
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
if (intOrderNum >= intTabRecNum)    //如果当前序号大于表记录数
{
strMsg = string.Format("已经是最后一条记录,不能再下移.(from {0})", clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
}

//4、获取下一个序号字段的关键字FuncModuleAgcId
sbCondition.AppendFormat(" {0} = {1} ", conQxFuncModule_Agc.OrderNum, intOrderNum + 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conQxFuncModule_Agc.QxPrjId, strQxPrjId);

strNextFuncModuleAgcId = clsQxFuncModule_AgcBL.GetFirstID_S(sbCondition.ToString());
if (string.IsNullOrEmpty(strNextFuncModuleAgcId) == true)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字FuncModuleAgcId所对应记录的序号加1
//6、把下(上)一个序号关键字FuncModuleAgcId所对应的记录序号减1
clsQxFuncModule_AgcBL.SetFldValue(clsQxFuncModule_AgcEN._CurrTabName, conQxFuncModule_Agc.OrderNum,
 	 	intOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conQxFuncModule_Agc.FuncModuleAgcId, strFuncModuleAgcId));
clsQxFuncModule_AgcBL.SetFldValue(clsQxFuncModule_AgcEN._CurrTabName, conQxFuncModule_Agc.OrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conQxFuncModule_Agc.FuncModuleAgcId, strNextFuncModuleAgcId));
break;
default:
strMsg = string.Format("方向参数出错!strDirect=[{0}]({1})",
 	 	strDirect,
 	 	clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
return true;
}
catch (Exception objException)
{
string strMsg = string.Format("调整记录次序出错!错误:[{0}]({1})",
 	 	objException.Message,
 	 	clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：QxPrjId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoBottom)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoBottom(List<string> arrKeyId, string strQxPrjId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", conQxFuncModule_Agc.FuncModuleAgcId, strKeyList);
List<clsQxFuncModule_AgcEN> arrQxFuncModule_AgcLst = GetObjLst(strCondition);
foreach (clsQxFuncModule_AgcEN objQxFuncModule_Agc in arrQxFuncModule_AgcLst)
{
objQxFuncModule_Agc.OrderNum = objQxFuncModule_Agc.OrderNum + 10000;
UpdateBySql2(objQxFuncModule_Agc);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conQxFuncModule_Agc.QxPrjId, strQxPrjId);
 strCondition += string.Format(" order by OrderNum ");
List<clsQxFuncModule_AgcEN> arrQxFuncModule_AgcObjList = new clsQxFuncModule_AgcDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsQxFuncModule_AgcEN objQxFuncModule_Agc in arrQxFuncModule_AgcObjList)
{
objQxFuncModule_Agc.OrderNum = intIndex;
UpdateBySql2(objQxFuncModule_Agc);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错, {0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：QxPrjId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoTop)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <param name="strQxPrjId">分类字段</param>
/// <returns></returns>
public static bool GoTop(List<string> arrKeyId, string strQxPrjId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", conQxFuncModule_Agc.FuncModuleAgcId, strKeyList);
List<clsQxFuncModule_AgcEN> arrQxFuncModule_AgcLst = GetObjLst(strCondition);
foreach (clsQxFuncModule_AgcEN objQxFuncModule_Agc in arrQxFuncModule_AgcLst)
{
objQxFuncModule_Agc.OrderNum = objQxFuncModule_Agc.OrderNum - 10000;
UpdateBySql2(objQxFuncModule_Agc);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conQxFuncModule_Agc.QxPrjId, strQxPrjId);
 strCondition += string.Format(" order by OrderNum ");
List<clsQxFuncModule_AgcEN> arrQxFuncModule_AgcObjList = new clsQxFuncModule_AgcDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsQxFuncModule_AgcEN objQxFuncModule_Agc in arrQxFuncModule_AgcObjList)
{
objQxFuncModule_Agc.OrderNum = intIndex;
UpdateBySql2(objQxFuncModule_Agc);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错,{0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}


 #endregion 排序相关函数
}
 /// <summary>
 /// 功能模块_Agc(QxFuncModule_Agc)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4QxFuncModule_Agc : clsCommFun4BL
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
clsQxFuncModule_AgcBL.ReFreshThisCache();
}
}

}