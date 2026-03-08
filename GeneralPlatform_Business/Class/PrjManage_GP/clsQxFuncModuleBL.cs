
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxFuncModuleBL
 表名:QxFuncModule(00140086)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:27:33
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
public static class  clsQxFuncModuleBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strFuncModuleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxFuncModuleEN GetObj(this K_FuncModuleId_QxFuncModule myKey)
{
clsQxFuncModuleEN objQxFuncModuleEN = clsQxFuncModuleBL.QxFuncModuleDA.GetObjByFuncModuleId(myKey.Value);
return objQxFuncModuleEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQxFuncModuleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQxFuncModuleEN objQxFuncModuleEN)
{
 if (string.IsNullOrEmpty(objQxFuncModuleEN.FuncModuleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQxFuncModuleBL.IsExist(objQxFuncModuleEN.FuncModuleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQxFuncModuleEN.FuncModuleId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsQxFuncModuleBL.QxFuncModuleDA.AddNewRecordBySQL2(objQxFuncModuleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxFuncModuleBL.ReFreshCache();

if (clsQxFuncModuleBL.relatedActions != null)
{
clsQxFuncModuleBL.relatedActions.UpdRelaTabDate(objQxFuncModuleEN.FuncModuleId, objQxFuncModuleEN.UpdUser);
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
public static bool AddRecordEx(this clsQxFuncModuleEN objQxFuncModuleEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsQxFuncModuleBL.IsExist(objQxFuncModuleEN.FuncModuleId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objQxFuncModuleEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objQxFuncModuleEN.AddNewRecord();
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
 /// <param name = "objQxFuncModuleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsQxFuncModuleEN objQxFuncModuleEN)
{
 if (string.IsNullOrEmpty(objQxFuncModuleEN.FuncModuleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQxFuncModuleBL.IsExist(objQxFuncModuleEN.FuncModuleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQxFuncModuleEN.FuncModuleId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsQxFuncModuleBL.QxFuncModuleDA.AddNewRecordBySQL2WithReturnKey(objQxFuncModuleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxFuncModuleBL.ReFreshCache();

if (clsQxFuncModuleBL.relatedActions != null)
{
clsQxFuncModuleBL.relatedActions.UpdRelaTabDate(objQxFuncModuleEN.FuncModuleId, objQxFuncModuleEN.UpdUser);
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
 /// <param name = "objQxFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxFuncModuleEN SetFuncModuleId(this clsQxFuncModuleEN objQxFuncModuleEN, string strFuncModuleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, conQxFuncModule.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, conQxFuncModule.FuncModuleId);
}
objQxFuncModuleEN.FuncModuleId = strFuncModuleId; //模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxFuncModuleEN.dicFldComparisonOp.ContainsKey(conQxFuncModule.FuncModuleId) == false)
{
objQxFuncModuleEN.dicFldComparisonOp.Add(conQxFuncModule.FuncModuleId, strComparisonOp);
}
else
{
objQxFuncModuleEN.dicFldComparisonOp[conQxFuncModule.FuncModuleId] = strComparisonOp;
}
}
return objQxFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxFuncModuleEN SetFuncModuleName(this clsQxFuncModuleEN objQxFuncModuleEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleName, conQxFuncModule.FuncModuleName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, conQxFuncModule.FuncModuleName);
}
objQxFuncModuleEN.FuncModuleName = strFuncModuleName; //模块名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxFuncModuleEN.dicFldComparisonOp.ContainsKey(conQxFuncModule.FuncModuleName) == false)
{
objQxFuncModuleEN.dicFldComparisonOp.Add(conQxFuncModule.FuncModuleName, strComparisonOp);
}
else
{
objQxFuncModuleEN.dicFldComparisonOp[conQxFuncModule.FuncModuleName] = strComparisonOp;
}
}
return objQxFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxFuncModuleEN SetFuncModuleNameSim(this clsQxFuncModuleEN objQxFuncModuleEN, string strFuncModuleNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleNameSim, 30, conQxFuncModule.FuncModuleNameSim);
}
objQxFuncModuleEN.FuncModuleNameSim = strFuncModuleNameSim; //模块名_Sim
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxFuncModuleEN.dicFldComparisonOp.ContainsKey(conQxFuncModule.FuncModuleNameSim) == false)
{
objQxFuncModuleEN.dicFldComparisonOp.Add(conQxFuncModule.FuncModuleNameSim, strComparisonOp);
}
else
{
objQxFuncModuleEN.dicFldComparisonOp[conQxFuncModule.FuncModuleNameSim] = strComparisonOp;
}
}
return objQxFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxFuncModuleEN SetFuncModuleEnName(this clsQxFuncModuleEN objQxFuncModuleEN, string strFuncModuleEnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleEnName, 30, conQxFuncModule.FuncModuleEnName);
}
objQxFuncModuleEN.FuncModuleEnName = strFuncModuleEnName; //模块英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxFuncModuleEN.dicFldComparisonOp.ContainsKey(conQxFuncModule.FuncModuleEnName) == false)
{
objQxFuncModuleEN.dicFldComparisonOp.Add(conQxFuncModule.FuncModuleEnName, strComparisonOp);
}
else
{
objQxFuncModuleEN.dicFldComparisonOp[conQxFuncModule.FuncModuleEnName] = strComparisonOp;
}
}
return objQxFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxFuncModuleEN SetOrderNum(this clsQxFuncModuleEN objQxFuncModuleEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, conQxFuncModule.OrderNum);
objQxFuncModuleEN.OrderNum = intOrderNum; //排序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxFuncModuleEN.dicFldComparisonOp.ContainsKey(conQxFuncModule.OrderNum) == false)
{
objQxFuncModuleEN.dicFldComparisonOp.Add(conQxFuncModule.OrderNum, strComparisonOp);
}
else
{
objQxFuncModuleEN.dicFldComparisonOp[conQxFuncModule.OrderNum] = strComparisonOp;
}
}
return objQxFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxFuncModuleEN SetInUse(this clsQxFuncModuleEN objQxFuncModuleEN, bool bolInUse, string strComparisonOp="")
	{
objQxFuncModuleEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxFuncModuleEN.dicFldComparisonOp.ContainsKey(conQxFuncModule.InUse) == false)
{
objQxFuncModuleEN.dicFldComparisonOp.Add(conQxFuncModule.InUse, strComparisonOp);
}
else
{
objQxFuncModuleEN.dicFldComparisonOp[conQxFuncModule.InUse] = strComparisonOp;
}
}
return objQxFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxFuncModuleEN SetQxPrjId(this clsQxFuncModuleEN objQxFuncModuleEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, conQxFuncModule.QxPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQxPrjId, 4, conQxFuncModule.QxPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, conQxFuncModule.QxPrjId);
}
objQxFuncModuleEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxFuncModuleEN.dicFldComparisonOp.ContainsKey(conQxFuncModule.QxPrjId) == false)
{
objQxFuncModuleEN.dicFldComparisonOp.Add(conQxFuncModule.QxPrjId, strComparisonOp);
}
else
{
objQxFuncModuleEN.dicFldComparisonOp[conQxFuncModule.QxPrjId] = strComparisonOp;
}
}
return objQxFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxFuncModuleEN SetUpdDate(this clsQxFuncModuleEN objQxFuncModuleEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQxFuncModule.UpdDate);
}
objQxFuncModuleEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxFuncModuleEN.dicFldComparisonOp.ContainsKey(conQxFuncModule.UpdDate) == false)
{
objQxFuncModuleEN.dicFldComparisonOp.Add(conQxFuncModule.UpdDate, strComparisonOp);
}
else
{
objQxFuncModuleEN.dicFldComparisonOp[conQxFuncModule.UpdDate] = strComparisonOp;
}
}
return objQxFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxFuncModuleEN SetUpdUser(this clsQxFuncModuleEN objQxFuncModuleEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 18, conQxFuncModule.UpdUser);
}
objQxFuncModuleEN.UpdUser = strUpdUser; //修改用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxFuncModuleEN.dicFldComparisonOp.ContainsKey(conQxFuncModule.UpdUser) == false)
{
objQxFuncModuleEN.dicFldComparisonOp.Add(conQxFuncModule.UpdUser, strComparisonOp);
}
else
{
objQxFuncModuleEN.dicFldComparisonOp[conQxFuncModule.UpdUser] = strComparisonOp;
}
}
return objQxFuncModuleEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objQxFuncModuleEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsQxFuncModuleEN objQxFuncModuleEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objQxFuncModuleEN.CheckPropertyNew();
clsQxFuncModuleEN objQxFuncModuleCond = new clsQxFuncModuleEN();
string strCondition = objQxFuncModuleCond
.SetFuncModuleId(objQxFuncModuleEN.FuncModuleId, "=")
.GetCombineCondition();
objQxFuncModuleEN._IsCheckProperty = true;
bool bolIsExist = clsQxFuncModuleBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objQxFuncModuleEN.Update();
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
 /// <param name = "objQxFuncModuleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxFuncModuleEN objQxFuncModuleEN)
{
 if (string.IsNullOrEmpty(objQxFuncModuleEN.FuncModuleId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxFuncModuleBL.QxFuncModuleDA.UpdateBySql2(objQxFuncModuleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxFuncModuleBL.ReFreshCache();

if (clsQxFuncModuleBL.relatedActions != null)
{
clsQxFuncModuleBL.relatedActions.UpdRelaTabDate(objQxFuncModuleEN.FuncModuleId, objQxFuncModuleEN.UpdUser);
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
 /// <param name = "objQxFuncModuleEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxFuncModuleEN objQxFuncModuleEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objQxFuncModuleEN.FuncModuleId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxFuncModuleBL.QxFuncModuleDA.UpdateBySql2(objQxFuncModuleEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxFuncModuleBL.ReFreshCache();

if (clsQxFuncModuleBL.relatedActions != null)
{
clsQxFuncModuleBL.relatedActions.UpdRelaTabDate(objQxFuncModuleEN.FuncModuleId, objQxFuncModuleEN.UpdUser);
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
 /// <param name = "objQxFuncModuleEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxFuncModuleEN objQxFuncModuleEN, string strWhereCond)
{
try
{
bool bolResult = clsQxFuncModuleBL.QxFuncModuleDA.UpdateBySqlWithCondition(objQxFuncModuleEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxFuncModuleBL.ReFreshCache();

if (clsQxFuncModuleBL.relatedActions != null)
{
clsQxFuncModuleBL.relatedActions.UpdRelaTabDate(objQxFuncModuleEN.FuncModuleId, objQxFuncModuleEN.UpdUser);
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
 /// <param name = "objQxFuncModuleEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxFuncModuleEN objQxFuncModuleEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsQxFuncModuleBL.QxFuncModuleDA.UpdateBySqlWithConditionTransaction(objQxFuncModuleEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxFuncModuleBL.ReFreshCache();

if (clsQxFuncModuleBL.relatedActions != null)
{
clsQxFuncModuleBL.relatedActions.UpdRelaTabDate(objQxFuncModuleEN.FuncModuleId, objQxFuncModuleEN.UpdUser);
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
 /// <param name = "strFuncModuleId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsQxFuncModuleEN objQxFuncModuleEN)
{
try
{
int intRecNum = clsQxFuncModuleBL.QxFuncModuleDA.DelRecord(objQxFuncModuleEN.FuncModuleId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxFuncModuleBL.ReFreshCache();

if (clsQxFuncModuleBL.relatedActions != null)
{
clsQxFuncModuleBL.relatedActions.UpdRelaTabDate(objQxFuncModuleEN.FuncModuleId, objQxFuncModuleEN.UpdUser);
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
 /// <param name = "objQxFuncModuleENS">源对象</param>
 /// <param name = "objQxFuncModuleENT">目标对象</param>
 public static void CopyTo(this clsQxFuncModuleEN objQxFuncModuleENS, clsQxFuncModuleEN objQxFuncModuleENT)
{
try
{
objQxFuncModuleENT.FuncModuleId = objQxFuncModuleENS.FuncModuleId; //模块Id
objQxFuncModuleENT.FuncModuleName = objQxFuncModuleENS.FuncModuleName; //模块名
objQxFuncModuleENT.FuncModuleNameSim = objQxFuncModuleENS.FuncModuleNameSim; //模块名_Sim
objQxFuncModuleENT.FuncModuleEnName = objQxFuncModuleENS.FuncModuleEnName; //模块英文名
objQxFuncModuleENT.OrderNum = objQxFuncModuleENS.OrderNum; //排序号
objQxFuncModuleENT.InUse = objQxFuncModuleENS.InUse; //是否在用
objQxFuncModuleENT.QxPrjId = objQxFuncModuleENS.QxPrjId; //项目Id
objQxFuncModuleENT.UpdDate = objQxFuncModuleENS.UpdDate; //修改日期
objQxFuncModuleENT.UpdUser = objQxFuncModuleENS.UpdUser; //修改用户
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
 /// <param name = "objQxFuncModuleENS">源对象</param>
 /// <returns>目标对象=>clsQxFuncModuleEN:objQxFuncModuleENT</returns>
 public static clsQxFuncModuleEN CopyTo(this clsQxFuncModuleEN objQxFuncModuleENS)
{
try
{
 clsQxFuncModuleEN objQxFuncModuleENT = new clsQxFuncModuleEN()
{
FuncModuleId = objQxFuncModuleENS.FuncModuleId, //模块Id
FuncModuleName = objQxFuncModuleENS.FuncModuleName, //模块名
FuncModuleNameSim = objQxFuncModuleENS.FuncModuleNameSim, //模块名_Sim
FuncModuleEnName = objQxFuncModuleENS.FuncModuleEnName, //模块英文名
OrderNum = objQxFuncModuleENS.OrderNum, //排序号
InUse = objQxFuncModuleENS.InUse, //是否在用
QxPrjId = objQxFuncModuleENS.QxPrjId, //项目Id
UpdDate = objQxFuncModuleENS.UpdDate, //修改日期
UpdUser = objQxFuncModuleENS.UpdUser, //修改用户
};
 return objQxFuncModuleENT;
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
public static void CheckPropertyNew(this clsQxFuncModuleEN objQxFuncModuleEN)
{
 clsQxFuncModuleBL.QxFuncModuleDA.CheckPropertyNew(objQxFuncModuleEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsQxFuncModuleEN objQxFuncModuleEN)
{
 clsQxFuncModuleBL.QxFuncModuleDA.CheckProperty4Condition(objQxFuncModuleEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQxFuncModuleEN objQxFuncModuleCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQxFuncModuleCond.IsUpdated(conQxFuncModule.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objQxFuncModuleCond.dicFldComparisonOp[conQxFuncModule.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxFuncModule.FuncModuleId, objQxFuncModuleCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objQxFuncModuleCond.IsUpdated(conQxFuncModule.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objQxFuncModuleCond.dicFldComparisonOp[conQxFuncModule.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxFuncModule.FuncModuleName, objQxFuncModuleCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objQxFuncModuleCond.IsUpdated(conQxFuncModule.FuncModuleNameSim) == true)
{
string strComparisonOpFuncModuleNameSim = objQxFuncModuleCond.dicFldComparisonOp[conQxFuncModule.FuncModuleNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxFuncModule.FuncModuleNameSim, objQxFuncModuleCond.FuncModuleNameSim, strComparisonOpFuncModuleNameSim);
}
if (objQxFuncModuleCond.IsUpdated(conQxFuncModule.FuncModuleEnName) == true)
{
string strComparisonOpFuncModuleEnName = objQxFuncModuleCond.dicFldComparisonOp[conQxFuncModule.FuncModuleEnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxFuncModule.FuncModuleEnName, objQxFuncModuleCond.FuncModuleEnName, strComparisonOpFuncModuleEnName);
}
if (objQxFuncModuleCond.IsUpdated(conQxFuncModule.OrderNum) == true)
{
string strComparisonOpOrderNum = objQxFuncModuleCond.dicFldComparisonOp[conQxFuncModule.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conQxFuncModule.OrderNum, objQxFuncModuleCond.OrderNum, strComparisonOpOrderNum);
}
if (objQxFuncModuleCond.IsUpdated(conQxFuncModule.InUse) == true)
{
if (objQxFuncModuleCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQxFuncModule.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQxFuncModule.InUse);
}
}
if (objQxFuncModuleCond.IsUpdated(conQxFuncModule.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objQxFuncModuleCond.dicFldComparisonOp[conQxFuncModule.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxFuncModule.QxPrjId, objQxFuncModuleCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objQxFuncModuleCond.IsUpdated(conQxFuncModule.UpdDate) == true)
{
string strComparisonOpUpdDate = objQxFuncModuleCond.dicFldComparisonOp[conQxFuncModule.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxFuncModule.UpdDate, objQxFuncModuleCond.UpdDate, strComparisonOpUpdDate);
}
if (objQxFuncModuleCond.IsUpdated(conQxFuncModule.UpdUser) == true)
{
string strComparisonOpUpdUser = objQxFuncModuleCond.dicFldComparisonOp[conQxFuncModule.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxFuncModule.UpdUser, objQxFuncModuleCond.UpdUser, strComparisonOpUpdUser);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_QxFuncModule
{
public virtual bool UpdRelaTabDate(string strFuncModuleId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 功能模块(QxFuncModule)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsQxFuncModuleBL
{
public static RelatedActions_QxFuncModule relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "QxFuncModuleListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "QxFuncModuleList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsQxFuncModuleEN> arrQxFuncModuleObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsQxFuncModuleDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsQxFuncModuleDA QxFuncModuleDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsQxFuncModuleDA();
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
 public clsQxFuncModuleBL()
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
if (string.IsNullOrEmpty(clsQxFuncModuleEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxFuncModuleEN._ConnectString);
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
objDS = QxFuncModuleDA.GetDataSet(strWhereCond);
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
objDS = QxFuncModuleDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = QxFuncModuleDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_QxFuncModule(string strWhereCond)
{
DataTable objDT;
try
{
objDT = QxFuncModuleDA.GetDataTable_QxFuncModule(strWhereCond);
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
objDT = QxFuncModuleDA.GetDataTable(strWhereCond);
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
objDT = QxFuncModuleDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = QxFuncModuleDA.GetDataTable(strWhereCond, strTabName);
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
objDT = QxFuncModuleDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = QxFuncModuleDA.GetDataTable_Top(objTopPara);
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
objDT = QxFuncModuleDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = QxFuncModuleDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = QxFuncModuleDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = QxFuncModuleDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = QxFuncModuleDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = QxFuncModuleDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = QxFuncModuleDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = QxFuncModuleDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
 /// <param name = "arrFuncModuleIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsQxFuncModuleEN> GetObjLstByFuncModuleIdLst(List<string> arrFuncModuleIdLst)
{
List<clsQxFuncModuleEN> arrObjLst = new List<clsQxFuncModuleEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrFuncModuleIdLst, true);
 string strWhereCond = string.Format("FuncModuleId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxFuncModuleEN objQxFuncModuleEN = new clsQxFuncModuleEN();
try
{
objQxFuncModuleEN.FuncModuleId = objRow[conQxFuncModule.FuncModuleId].ToString().Trim(); //模块Id
objQxFuncModuleEN.FuncModuleName = objRow[conQxFuncModule.FuncModuleName].ToString().Trim(); //模块名
objQxFuncModuleEN.FuncModuleNameSim = objRow[conQxFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[conQxFuncModule.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objQxFuncModuleEN.FuncModuleEnName = objRow[conQxFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[conQxFuncModule.FuncModuleEnName].ToString().Trim(); //模块英文名
objQxFuncModuleEN.OrderNum = Int32.Parse(objRow[conQxFuncModule.OrderNum].ToString().Trim()); //排序号
objQxFuncModuleEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxFuncModule.InUse].ToString().Trim()); //是否在用
objQxFuncModuleEN.QxPrjId = objRow[conQxFuncModule.QxPrjId].ToString().Trim(); //项目Id
objQxFuncModuleEN.UpdDate = objRow[conQxFuncModule.UpdDate] == DBNull.Value ? null : objRow[conQxFuncModule.UpdDate].ToString().Trim(); //修改日期
objQxFuncModuleEN.UpdUser = objRow[conQxFuncModule.UpdUser] == DBNull.Value ? null : objRow[conQxFuncModule.UpdUser].ToString().Trim(); //修改用户
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxFuncModuleEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxFuncModuleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrFuncModuleIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsQxFuncModuleEN> GetObjLstByFuncModuleIdLstCache(List<string> arrFuncModuleIdLst)
{
string strKey = string.Format("{0}", clsQxFuncModuleEN._CurrTabName);
List<clsQxFuncModuleEN> arrQxFuncModuleObjLstCache = GetObjLstCache();
IEnumerable <clsQxFuncModuleEN> arrQxFuncModuleObjLst_Sel =
arrQxFuncModuleObjLstCache
.Where(x => arrFuncModuleIdLst.Contains(x.FuncModuleId));
return arrQxFuncModuleObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxFuncModuleEN> GetObjLst(string strWhereCond)
{
List<clsQxFuncModuleEN> arrObjLst = new List<clsQxFuncModuleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxFuncModuleEN objQxFuncModuleEN = new clsQxFuncModuleEN();
try
{
objQxFuncModuleEN.FuncModuleId = objRow[conQxFuncModule.FuncModuleId].ToString().Trim(); //模块Id
objQxFuncModuleEN.FuncModuleName = objRow[conQxFuncModule.FuncModuleName].ToString().Trim(); //模块名
objQxFuncModuleEN.FuncModuleNameSim = objRow[conQxFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[conQxFuncModule.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objQxFuncModuleEN.FuncModuleEnName = objRow[conQxFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[conQxFuncModule.FuncModuleEnName].ToString().Trim(); //模块英文名
objQxFuncModuleEN.OrderNum = Int32.Parse(objRow[conQxFuncModule.OrderNum].ToString().Trim()); //排序号
objQxFuncModuleEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxFuncModule.InUse].ToString().Trim()); //是否在用
objQxFuncModuleEN.QxPrjId = objRow[conQxFuncModule.QxPrjId].ToString().Trim(); //项目Id
objQxFuncModuleEN.UpdDate = objRow[conQxFuncModule.UpdDate] == DBNull.Value ? null : objRow[conQxFuncModule.UpdDate].ToString().Trim(); //修改日期
objQxFuncModuleEN.UpdUser = objRow[conQxFuncModule.UpdUser] == DBNull.Value ? null : objRow[conQxFuncModule.UpdUser].ToString().Trim(); //修改用户
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxFuncModuleEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxFuncModuleEN);
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
public static List<clsQxFuncModuleEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsQxFuncModuleEN> arrObjLst = new List<clsQxFuncModuleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxFuncModuleEN objQxFuncModuleEN = new clsQxFuncModuleEN();
try
{
objQxFuncModuleEN.FuncModuleId = objRow[conQxFuncModule.FuncModuleId].ToString().Trim(); //模块Id
objQxFuncModuleEN.FuncModuleName = objRow[conQxFuncModule.FuncModuleName].ToString().Trim(); //模块名
objQxFuncModuleEN.FuncModuleNameSim = objRow[conQxFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[conQxFuncModule.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objQxFuncModuleEN.FuncModuleEnName = objRow[conQxFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[conQxFuncModule.FuncModuleEnName].ToString().Trim(); //模块英文名
objQxFuncModuleEN.OrderNum = Int32.Parse(objRow[conQxFuncModule.OrderNum].ToString().Trim()); //排序号
objQxFuncModuleEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxFuncModule.InUse].ToString().Trim()); //是否在用
objQxFuncModuleEN.QxPrjId = objRow[conQxFuncModule.QxPrjId].ToString().Trim(); //项目Id
objQxFuncModuleEN.UpdDate = objRow[conQxFuncModule.UpdDate] == DBNull.Value ? null : objRow[conQxFuncModule.UpdDate].ToString().Trim(); //修改日期
objQxFuncModuleEN.UpdUser = objRow[conQxFuncModule.UpdUser] == DBNull.Value ? null : objRow[conQxFuncModule.UpdUser].ToString().Trim(); //修改用户
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxFuncModuleEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxFuncModuleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objQxFuncModuleCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsQxFuncModuleEN> GetSubObjLstCache(clsQxFuncModuleEN objQxFuncModuleCond)
{
List<clsQxFuncModuleEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxFuncModuleEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxFuncModule.AttributeName)
{
if (objQxFuncModuleCond.IsUpdated(strFldName) == false) continue;
if (objQxFuncModuleCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxFuncModuleCond[strFldName].ToString());
}
else
{
if (objQxFuncModuleCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxFuncModuleCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxFuncModuleCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxFuncModuleCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxFuncModuleCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxFuncModuleCond[strFldName]));
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
public static List<clsQxFuncModuleEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsQxFuncModuleEN> arrObjLst = new List<clsQxFuncModuleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxFuncModuleEN objQxFuncModuleEN = new clsQxFuncModuleEN();
try
{
objQxFuncModuleEN.FuncModuleId = objRow[conQxFuncModule.FuncModuleId].ToString().Trim(); //模块Id
objQxFuncModuleEN.FuncModuleName = objRow[conQxFuncModule.FuncModuleName].ToString().Trim(); //模块名
objQxFuncModuleEN.FuncModuleNameSim = objRow[conQxFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[conQxFuncModule.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objQxFuncModuleEN.FuncModuleEnName = objRow[conQxFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[conQxFuncModule.FuncModuleEnName].ToString().Trim(); //模块英文名
objQxFuncModuleEN.OrderNum = Int32.Parse(objRow[conQxFuncModule.OrderNum].ToString().Trim()); //排序号
objQxFuncModuleEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxFuncModule.InUse].ToString().Trim()); //是否在用
objQxFuncModuleEN.QxPrjId = objRow[conQxFuncModule.QxPrjId].ToString().Trim(); //项目Id
objQxFuncModuleEN.UpdDate = objRow[conQxFuncModule.UpdDate] == DBNull.Value ? null : objRow[conQxFuncModule.UpdDate].ToString().Trim(); //修改日期
objQxFuncModuleEN.UpdUser = objRow[conQxFuncModule.UpdUser] == DBNull.Value ? null : objRow[conQxFuncModule.UpdUser].ToString().Trim(); //修改用户
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxFuncModuleEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxFuncModuleEN);
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
public static List<clsQxFuncModuleEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsQxFuncModuleEN> arrObjLst = new List<clsQxFuncModuleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxFuncModuleEN objQxFuncModuleEN = new clsQxFuncModuleEN();
try
{
objQxFuncModuleEN.FuncModuleId = objRow[conQxFuncModule.FuncModuleId].ToString().Trim(); //模块Id
objQxFuncModuleEN.FuncModuleName = objRow[conQxFuncModule.FuncModuleName].ToString().Trim(); //模块名
objQxFuncModuleEN.FuncModuleNameSim = objRow[conQxFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[conQxFuncModule.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objQxFuncModuleEN.FuncModuleEnName = objRow[conQxFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[conQxFuncModule.FuncModuleEnName].ToString().Trim(); //模块英文名
objQxFuncModuleEN.OrderNum = Int32.Parse(objRow[conQxFuncModule.OrderNum].ToString().Trim()); //排序号
objQxFuncModuleEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxFuncModule.InUse].ToString().Trim()); //是否在用
objQxFuncModuleEN.QxPrjId = objRow[conQxFuncModule.QxPrjId].ToString().Trim(); //项目Id
objQxFuncModuleEN.UpdDate = objRow[conQxFuncModule.UpdDate] == DBNull.Value ? null : objRow[conQxFuncModule.UpdDate].ToString().Trim(); //修改日期
objQxFuncModuleEN.UpdUser = objRow[conQxFuncModule.UpdUser] == DBNull.Value ? null : objRow[conQxFuncModule.UpdUser].ToString().Trim(); //修改用户
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxFuncModuleEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxFuncModuleEN);
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
List<clsQxFuncModuleEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsQxFuncModuleEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxFuncModuleEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsQxFuncModuleEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsQxFuncModuleEN> arrObjLst = new List<clsQxFuncModuleEN>(); 
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
	clsQxFuncModuleEN objQxFuncModuleEN = new clsQxFuncModuleEN();
try
{
objQxFuncModuleEN.FuncModuleId = objRow[conQxFuncModule.FuncModuleId].ToString().Trim(); //模块Id
objQxFuncModuleEN.FuncModuleName = objRow[conQxFuncModule.FuncModuleName].ToString().Trim(); //模块名
objQxFuncModuleEN.FuncModuleNameSim = objRow[conQxFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[conQxFuncModule.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objQxFuncModuleEN.FuncModuleEnName = objRow[conQxFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[conQxFuncModule.FuncModuleEnName].ToString().Trim(); //模块英文名
objQxFuncModuleEN.OrderNum = Int32.Parse(objRow[conQxFuncModule.OrderNum].ToString().Trim()); //排序号
objQxFuncModuleEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxFuncModule.InUse].ToString().Trim()); //是否在用
objQxFuncModuleEN.QxPrjId = objRow[conQxFuncModule.QxPrjId].ToString().Trim(); //项目Id
objQxFuncModuleEN.UpdDate = objRow[conQxFuncModule.UpdDate] == DBNull.Value ? null : objRow[conQxFuncModule.UpdDate].ToString().Trim(); //修改日期
objQxFuncModuleEN.UpdUser = objRow[conQxFuncModule.UpdUser] == DBNull.Value ? null : objRow[conQxFuncModule.UpdUser].ToString().Trim(); //修改用户
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxFuncModuleEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxFuncModuleEN);
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
public static List<clsQxFuncModuleEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsQxFuncModuleEN> arrObjLst = new List<clsQxFuncModuleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxFuncModuleEN objQxFuncModuleEN = new clsQxFuncModuleEN();
try
{
objQxFuncModuleEN.FuncModuleId = objRow[conQxFuncModule.FuncModuleId].ToString().Trim(); //模块Id
objQxFuncModuleEN.FuncModuleName = objRow[conQxFuncModule.FuncModuleName].ToString().Trim(); //模块名
objQxFuncModuleEN.FuncModuleNameSim = objRow[conQxFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[conQxFuncModule.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objQxFuncModuleEN.FuncModuleEnName = objRow[conQxFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[conQxFuncModule.FuncModuleEnName].ToString().Trim(); //模块英文名
objQxFuncModuleEN.OrderNum = Int32.Parse(objRow[conQxFuncModule.OrderNum].ToString().Trim()); //排序号
objQxFuncModuleEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxFuncModule.InUse].ToString().Trim()); //是否在用
objQxFuncModuleEN.QxPrjId = objRow[conQxFuncModule.QxPrjId].ToString().Trim(); //项目Id
objQxFuncModuleEN.UpdDate = objRow[conQxFuncModule.UpdDate] == DBNull.Value ? null : objRow[conQxFuncModule.UpdDate].ToString().Trim(); //修改日期
objQxFuncModuleEN.UpdUser = objRow[conQxFuncModule.UpdUser] == DBNull.Value ? null : objRow[conQxFuncModule.UpdUser].ToString().Trim(); //修改用户
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxFuncModuleEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxFuncModuleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsQxFuncModuleEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsQxFuncModuleEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsQxFuncModuleEN> arrObjLst = new List<clsQxFuncModuleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxFuncModuleEN objQxFuncModuleEN = new clsQxFuncModuleEN();
try
{
objQxFuncModuleEN.FuncModuleId = objRow[conQxFuncModule.FuncModuleId].ToString().Trim(); //模块Id
objQxFuncModuleEN.FuncModuleName = objRow[conQxFuncModule.FuncModuleName].ToString().Trim(); //模块名
objQxFuncModuleEN.FuncModuleNameSim = objRow[conQxFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[conQxFuncModule.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objQxFuncModuleEN.FuncModuleEnName = objRow[conQxFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[conQxFuncModule.FuncModuleEnName].ToString().Trim(); //模块英文名
objQxFuncModuleEN.OrderNum = Int32.Parse(objRow[conQxFuncModule.OrderNum].ToString().Trim()); //排序号
objQxFuncModuleEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxFuncModule.InUse].ToString().Trim()); //是否在用
objQxFuncModuleEN.QxPrjId = objRow[conQxFuncModule.QxPrjId].ToString().Trim(); //项目Id
objQxFuncModuleEN.UpdDate = objRow[conQxFuncModule.UpdDate] == DBNull.Value ? null : objRow[conQxFuncModule.UpdDate].ToString().Trim(); //修改日期
objQxFuncModuleEN.UpdUser = objRow[conQxFuncModule.UpdUser] == DBNull.Value ? null : objRow[conQxFuncModule.UpdUser].ToString().Trim(); //修改用户
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxFuncModuleEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxFuncModuleEN);
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
public static List<clsQxFuncModuleEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsQxFuncModuleEN> arrObjLst = new List<clsQxFuncModuleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxFuncModuleEN objQxFuncModuleEN = new clsQxFuncModuleEN();
try
{
objQxFuncModuleEN.FuncModuleId = objRow[conQxFuncModule.FuncModuleId].ToString().Trim(); //模块Id
objQxFuncModuleEN.FuncModuleName = objRow[conQxFuncModule.FuncModuleName].ToString().Trim(); //模块名
objQxFuncModuleEN.FuncModuleNameSim = objRow[conQxFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[conQxFuncModule.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objQxFuncModuleEN.FuncModuleEnName = objRow[conQxFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[conQxFuncModule.FuncModuleEnName].ToString().Trim(); //模块英文名
objQxFuncModuleEN.OrderNum = Int32.Parse(objRow[conQxFuncModule.OrderNum].ToString().Trim()); //排序号
objQxFuncModuleEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxFuncModule.InUse].ToString().Trim()); //是否在用
objQxFuncModuleEN.QxPrjId = objRow[conQxFuncModule.QxPrjId].ToString().Trim(); //项目Id
objQxFuncModuleEN.UpdDate = objRow[conQxFuncModule.UpdDate] == DBNull.Value ? null : objRow[conQxFuncModule.UpdDate].ToString().Trim(); //修改日期
objQxFuncModuleEN.UpdUser = objRow[conQxFuncModule.UpdUser] == DBNull.Value ? null : objRow[conQxFuncModule.UpdUser].ToString().Trim(); //修改用户
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxFuncModuleEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxFuncModuleEN);
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
public static IEnumerable<clsQxFuncModuleEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsQxFuncModuleEN objQxFuncModuleCond, string strOrderBy)
{
List<clsQxFuncModuleEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxFuncModuleEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxFuncModule.AttributeName)
{
if (objQxFuncModuleCond.IsUpdated(strFldName) == false) continue;
if (objQxFuncModuleCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxFuncModuleCond[strFldName].ToString());
}
else
{
if (objQxFuncModuleCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxFuncModuleCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxFuncModuleCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxFuncModuleCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxFuncModuleCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxFuncModuleCond[strFldName]));
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
public static IEnumerable<clsQxFuncModuleEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsQxFuncModuleEN objQxFuncModuleCond = JsonConvert.DeserializeObject<clsQxFuncModuleEN>(objPagerPara.whereCond);
if (objQxFuncModuleCond.sfFldComparisonOp == null)
{
objQxFuncModuleCond.dicFldComparisonOp = null;
}
else
{
objQxFuncModuleCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objQxFuncModuleCond.sfFldComparisonOp);
}
clsQxFuncModuleBL.SetUpdFlag(objQxFuncModuleCond);
 try
{
CheckProperty4Condition(objQxFuncModuleCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsQxFuncModuleBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objQxFuncModuleCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxFuncModuleEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsQxFuncModuleEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsQxFuncModuleEN> arrObjLst = new List<clsQxFuncModuleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxFuncModuleEN objQxFuncModuleEN = new clsQxFuncModuleEN();
try
{
objQxFuncModuleEN.FuncModuleId = objRow[conQxFuncModule.FuncModuleId].ToString().Trim(); //模块Id
objQxFuncModuleEN.FuncModuleName = objRow[conQxFuncModule.FuncModuleName].ToString().Trim(); //模块名
objQxFuncModuleEN.FuncModuleNameSim = objRow[conQxFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[conQxFuncModule.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objQxFuncModuleEN.FuncModuleEnName = objRow[conQxFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[conQxFuncModule.FuncModuleEnName].ToString().Trim(); //模块英文名
objQxFuncModuleEN.OrderNum = Int32.Parse(objRow[conQxFuncModule.OrderNum].ToString().Trim()); //排序号
objQxFuncModuleEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxFuncModule.InUse].ToString().Trim()); //是否在用
objQxFuncModuleEN.QxPrjId = objRow[conQxFuncModule.QxPrjId].ToString().Trim(); //项目Id
objQxFuncModuleEN.UpdDate = objRow[conQxFuncModule.UpdDate] == DBNull.Value ? null : objRow[conQxFuncModule.UpdDate].ToString().Trim(); //修改日期
objQxFuncModuleEN.UpdUser = objRow[conQxFuncModule.UpdUser] == DBNull.Value ? null : objRow[conQxFuncModule.UpdUser].ToString().Trim(); //修改用户
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxFuncModuleEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxFuncModuleEN);
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
public static List<clsQxFuncModuleEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsQxFuncModuleEN> arrObjLst = new List<clsQxFuncModuleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxFuncModuleEN objQxFuncModuleEN = new clsQxFuncModuleEN();
try
{
objQxFuncModuleEN.FuncModuleId = objRow[conQxFuncModule.FuncModuleId].ToString().Trim(); //模块Id
objQxFuncModuleEN.FuncModuleName = objRow[conQxFuncModule.FuncModuleName].ToString().Trim(); //模块名
objQxFuncModuleEN.FuncModuleNameSim = objRow[conQxFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[conQxFuncModule.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objQxFuncModuleEN.FuncModuleEnName = objRow[conQxFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[conQxFuncModule.FuncModuleEnName].ToString().Trim(); //模块英文名
objQxFuncModuleEN.OrderNum = Int32.Parse(objRow[conQxFuncModule.OrderNum].ToString().Trim()); //排序号
objQxFuncModuleEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxFuncModule.InUse].ToString().Trim()); //是否在用
objQxFuncModuleEN.QxPrjId = objRow[conQxFuncModule.QxPrjId].ToString().Trim(); //项目Id
objQxFuncModuleEN.UpdDate = objRow[conQxFuncModule.UpdDate] == DBNull.Value ? null : objRow[conQxFuncModule.UpdDate].ToString().Trim(); //修改日期
objQxFuncModuleEN.UpdUser = objRow[conQxFuncModule.UpdUser] == DBNull.Value ? null : objRow[conQxFuncModule.UpdUser].ToString().Trim(); //修改用户
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxFuncModuleEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxFuncModuleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxFuncModuleEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsQxFuncModuleEN> arrObjLst = new List<clsQxFuncModuleEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxFuncModuleEN objQxFuncModuleEN = new clsQxFuncModuleEN();
try
{
objQxFuncModuleEN.FuncModuleId = objRow[conQxFuncModule.FuncModuleId].ToString().Trim(); //模块Id
objQxFuncModuleEN.FuncModuleName = objRow[conQxFuncModule.FuncModuleName].ToString().Trim(); //模块名
objQxFuncModuleEN.FuncModuleNameSim = objRow[conQxFuncModule.FuncModuleNameSim] == DBNull.Value ? null : objRow[conQxFuncModule.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objQxFuncModuleEN.FuncModuleEnName = objRow[conQxFuncModule.FuncModuleEnName] == DBNull.Value ? null : objRow[conQxFuncModule.FuncModuleEnName].ToString().Trim(); //模块英文名
objQxFuncModuleEN.OrderNum = Int32.Parse(objRow[conQxFuncModule.OrderNum].ToString().Trim()); //排序号
objQxFuncModuleEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQxFuncModule.InUse].ToString().Trim()); //是否在用
objQxFuncModuleEN.QxPrjId = objRow[conQxFuncModule.QxPrjId].ToString().Trim(); //项目Id
objQxFuncModuleEN.UpdDate = objRow[conQxFuncModule.UpdDate] == DBNull.Value ? null : objRow[conQxFuncModule.UpdDate].ToString().Trim(); //修改日期
objQxFuncModuleEN.UpdUser = objRow[conQxFuncModule.UpdUser] == DBNull.Value ? null : objRow[conQxFuncModule.UpdUser].ToString().Trim(); //修改用户
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxFuncModuleEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxFuncModuleEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objQxFuncModuleEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxFuncModule(ref clsQxFuncModuleEN objQxFuncModuleEN)
{
bool bolResult = QxFuncModuleDA.GetQxFuncModule(ref objQxFuncModuleEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strFuncModuleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxFuncModuleEN GetObjByFuncModuleId(string strFuncModuleId)
{
if (strFuncModuleId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strFuncModuleId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strFuncModuleId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strFuncModuleId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsQxFuncModuleEN objQxFuncModuleEN = QxFuncModuleDA.GetObjByFuncModuleId(strFuncModuleId);
return objQxFuncModuleEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsQxFuncModuleEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsQxFuncModuleEN objQxFuncModuleEN = QxFuncModuleDA.GetFirstObj(strWhereCond);
 return objQxFuncModuleEN;
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
public static clsQxFuncModuleEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsQxFuncModuleEN objQxFuncModuleEN = QxFuncModuleDA.GetObjByDataRow(objRow);
 return objQxFuncModuleEN;
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
public static clsQxFuncModuleEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsQxFuncModuleEN objQxFuncModuleEN = QxFuncModuleDA.GetObjByDataRow(objRow);
 return objQxFuncModuleEN;
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
 /// <param name = "strFuncModuleId">所给的关键字</param>
 /// <param name = "lstQxFuncModuleObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxFuncModuleEN GetObjByFuncModuleIdFromList(string strFuncModuleId, List<clsQxFuncModuleEN> lstQxFuncModuleObjLst)
{
foreach (clsQxFuncModuleEN objQxFuncModuleEN in lstQxFuncModuleObjLst)
{
if (objQxFuncModuleEN.FuncModuleId == strFuncModuleId)
{
return objQxFuncModuleEN;
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
 string strFuncModuleId;
 try
 {
 strFuncModuleId = new clsQxFuncModuleDA().GetFirstID(strWhereCond);
 return strFuncModuleId;
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
 arrList = QxFuncModuleDA.GetID(strWhereCond);
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
bool bolIsExist = QxFuncModuleDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strFuncModuleId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strFuncModuleId)
{
if (string.IsNullOrEmpty(strFuncModuleId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strFuncModuleId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = QxFuncModuleDA.IsExist(strFuncModuleId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strFuncModuleId">模块Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strFuncModuleId, string strOpUser)
{
clsQxFuncModuleEN objQxFuncModuleEN = clsQxFuncModuleBL.GetObjByFuncModuleId(strFuncModuleId);
objQxFuncModuleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objQxFuncModuleEN.UpdUser = strOpUser;
return clsQxFuncModuleBL.UpdateBySql2(objQxFuncModuleEN);
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
 bolIsExist = clsQxFuncModuleDA.IsExistTable();
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
 bolIsExist = QxFuncModuleDA.IsExistTable(strTabName);
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
 /// <param name = "objQxFuncModuleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsQxFuncModuleEN objQxFuncModuleEN)
{
 if (string.IsNullOrEmpty(objQxFuncModuleEN.FuncModuleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQxFuncModuleBL.IsExist(objQxFuncModuleEN.FuncModuleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQxFuncModuleEN.FuncModuleId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = QxFuncModuleDA.AddNewRecordBySQL2(objQxFuncModuleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxFuncModuleBL.ReFreshCache();

if (clsQxFuncModuleBL.relatedActions != null)
{
clsQxFuncModuleBL.relatedActions.UpdRelaTabDate(objQxFuncModuleEN.FuncModuleId, objQxFuncModuleEN.UpdUser);
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
 /// <param name = "objQxFuncModuleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsQxFuncModuleEN objQxFuncModuleEN)
{
 if (string.IsNullOrEmpty(objQxFuncModuleEN.FuncModuleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQxFuncModuleBL.IsExist(objQxFuncModuleEN.FuncModuleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQxFuncModuleEN.FuncModuleId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = QxFuncModuleDA.AddNewRecordBySQL2WithReturnKey(objQxFuncModuleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxFuncModuleBL.ReFreshCache();

if (clsQxFuncModuleBL.relatedActions != null)
{
clsQxFuncModuleBL.relatedActions.UpdRelaTabDate(objQxFuncModuleEN.FuncModuleId, objQxFuncModuleEN.UpdUser);
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
 /// <param name = "strQxFuncModuleObjXml">代表实体对象的XML串</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql_XML(string strQxFuncModuleObjXml)
{
clsQxFuncModuleEN objQxFuncModuleEN = GetObjFromXmlStr(strQxFuncModuleObjXml);
try
{
bool bolResult = QxFuncModuleDA.AddNewRecordBySQL2(objQxFuncModuleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxFuncModuleBL.ReFreshCache();

if (clsQxFuncModuleBL.relatedActions != null)
{
clsQxFuncModuleBL.relatedActions.UpdRelaTabDate(objQxFuncModuleEN.FuncModuleId, objQxFuncModuleEN.UpdUser);
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
 /// <param name = "objQxFuncModuleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsQxFuncModuleEN objQxFuncModuleEN)
{
try
{
bool bolResult = QxFuncModuleDA.Update(objQxFuncModuleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxFuncModuleBL.ReFreshCache();

if (clsQxFuncModuleBL.relatedActions != null)
{
clsQxFuncModuleBL.relatedActions.UpdRelaTabDate(objQxFuncModuleEN.FuncModuleId, objQxFuncModuleEN.UpdUser);
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
 /// <param name = "objQxFuncModuleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsQxFuncModuleEN objQxFuncModuleEN)
{
 if (string.IsNullOrEmpty(objQxFuncModuleEN.FuncModuleId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = QxFuncModuleDA.UpdateBySql2(objQxFuncModuleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxFuncModuleBL.ReFreshCache();

if (clsQxFuncModuleBL.relatedActions != null)
{
clsQxFuncModuleBL.relatedActions.UpdRelaTabDate(objQxFuncModuleEN.FuncModuleId, objQxFuncModuleEN.UpdUser);
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
 /// <param name = "strQxFuncModuleObjXml">需要修改的对象,用XML来表示</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql_XML(string strQxFuncModuleObjXml)
{
clsQxFuncModuleEN objQxFuncModuleEN = GetObjFromXmlStr(strQxFuncModuleObjXml);
try
{
bool bolResult = QxFuncModuleDA.UpdateBySql2(objQxFuncModuleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxFuncModuleBL.ReFreshCache();

if (clsQxFuncModuleBL.relatedActions != null)
{
clsQxFuncModuleBL.relatedActions.UpdRelaTabDate(objQxFuncModuleEN.FuncModuleId, objQxFuncModuleEN.UpdUser);
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
 /// <param name = "strFuncModuleId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strFuncModuleId)
{
try
{
 clsQxFuncModuleEN objQxFuncModuleEN = clsQxFuncModuleBL.GetObjByFuncModuleId(strFuncModuleId);

if (clsQxFuncModuleBL.relatedActions != null)
{
clsQxFuncModuleBL.relatedActions.UpdRelaTabDate(objQxFuncModuleEN.FuncModuleId, objQxFuncModuleEN.UpdUser);
}
if (objQxFuncModuleEN != null)
{
int intRecNum = QxFuncModuleDA.DelRecord(strFuncModuleId);
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
/// <param name="strFuncModuleId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strFuncModuleId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
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
//删除与表:[QxFuncModule]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conQxFuncModule.FuncModuleId,
//strFuncModuleId);
//        clsQxFuncModuleBL.DelQxFuncModulesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxFuncModuleBL.DelRecord(strFuncModuleId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxFuncModuleBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strFuncModuleId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strFuncModuleId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strFuncModuleId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsQxFuncModuleBL.relatedActions != null)
{
clsQxFuncModuleBL.relatedActions.UpdRelaTabDate(strFuncModuleId, "UpdRelaTabDate");
}
bool bolResult = QxFuncModuleDA.DelRecord(strFuncModuleId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "strFuncModuleId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strFuncModuleId) 
{
try
{
if (clsQxFuncModuleBL.relatedActions != null)
{
clsQxFuncModuleBL.relatedActions.UpdRelaTabDate(strFuncModuleId, "UpdRelaTabDate");
}
bool bolResult = QxFuncModuleDA.DelRecordBySP(strFuncModuleId);
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
 /// <param name = "arrFuncModuleIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelQxFuncModules(List<string> arrFuncModuleIdLst)
{
if (arrFuncModuleIdLst.Count == 0) return 0;
try
{
if (clsQxFuncModuleBL.relatedActions != null)
{
foreach (var strFuncModuleId in arrFuncModuleIdLst)
{
clsQxFuncModuleBL.relatedActions.UpdRelaTabDate(strFuncModuleId, "UpdRelaTabDate");
}
}
int intDelRecNum = QxFuncModuleDA.DelQxFuncModule(arrFuncModuleIdLst);
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
public static int DelQxFuncModulesByCond(string strWhereCond)
{
try
{
if (clsQxFuncModuleBL.relatedActions != null)
{
List<string> arrFuncModuleId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strFuncModuleId in arrFuncModuleId)
{
clsQxFuncModuleBL.relatedActions.UpdRelaTabDate(strFuncModuleId, "UpdRelaTabDate");
}
}
int intRecNum = QxFuncModuleDA.DelQxFuncModule(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[QxFuncModule]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strFuncModuleId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strFuncModuleId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
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
//删除与表:[QxFuncModule]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxFuncModuleBL.DelRecord(strFuncModuleId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxFuncModuleBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strFuncModuleId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objQxFuncModuleENS">源对象</param>
 /// <param name = "objQxFuncModuleENT">目标对象</param>
 public static void CopyTo(clsQxFuncModuleEN objQxFuncModuleENS, clsQxFuncModuleEN objQxFuncModuleENT)
{
try
{
objQxFuncModuleENT.FuncModuleId = objQxFuncModuleENS.FuncModuleId; //模块Id
objQxFuncModuleENT.FuncModuleName = objQxFuncModuleENS.FuncModuleName; //模块名
objQxFuncModuleENT.FuncModuleNameSim = objQxFuncModuleENS.FuncModuleNameSim; //模块名_Sim
objQxFuncModuleENT.FuncModuleEnName = objQxFuncModuleENS.FuncModuleEnName; //模块英文名
objQxFuncModuleENT.OrderNum = objQxFuncModuleENS.OrderNum; //排序号
objQxFuncModuleENT.InUse = objQxFuncModuleENS.InUse; //是否在用
objQxFuncModuleENT.QxPrjId = objQxFuncModuleENS.QxPrjId; //项目Id
objQxFuncModuleENT.UpdDate = objQxFuncModuleENS.UpdDate; //修改日期
objQxFuncModuleENT.UpdUser = objQxFuncModuleENS.UpdUser; //修改用户
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
 /// <param name = "objQxFuncModuleEN">源简化对象</param>
 public static void SetUpdFlag(clsQxFuncModuleEN objQxFuncModuleEN)
{
try
{
objQxFuncModuleEN.ClearUpdateState();
   string strsfUpdFldSetStr = objQxFuncModuleEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conQxFuncModule.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxFuncModuleEN.FuncModuleId = objQxFuncModuleEN.FuncModuleId; //模块Id
}
if (arrFldSet.Contains(conQxFuncModule.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objQxFuncModuleEN.FuncModuleName = objQxFuncModuleEN.FuncModuleName; //模块名
}
if (arrFldSet.Contains(conQxFuncModule.FuncModuleNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objQxFuncModuleEN.FuncModuleNameSim = objQxFuncModuleEN.FuncModuleNameSim == "[null]" ? null :  objQxFuncModuleEN.FuncModuleNameSim; //模块名_Sim
}
if (arrFldSet.Contains(conQxFuncModule.FuncModuleEnName, new clsStrCompareIgnoreCase())  ==  true)
{
objQxFuncModuleEN.FuncModuleEnName = objQxFuncModuleEN.FuncModuleEnName == "[null]" ? null :  objQxFuncModuleEN.FuncModuleEnName; //模块英文名
}
if (arrFldSet.Contains(conQxFuncModule.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objQxFuncModuleEN.OrderNum = objQxFuncModuleEN.OrderNum; //排序号
}
if (arrFldSet.Contains(conQxFuncModule.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objQxFuncModuleEN.InUse = objQxFuncModuleEN.InUse; //是否在用
}
if (arrFldSet.Contains(conQxFuncModule.QxPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxFuncModuleEN.QxPrjId = objQxFuncModuleEN.QxPrjId; //项目Id
}
if (arrFldSet.Contains(conQxFuncModule.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objQxFuncModuleEN.UpdDate = objQxFuncModuleEN.UpdDate == "[null]" ? null :  objQxFuncModuleEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conQxFuncModule.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objQxFuncModuleEN.UpdUser = objQxFuncModuleEN.UpdUser == "[null]" ? null :  objQxFuncModuleEN.UpdUser; //修改用户
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
 /// <param name = "objQxFuncModuleEN">源简化对象</param>
 public static void AccessFldValueNull(clsQxFuncModuleEN objQxFuncModuleEN)
{
try
{
if (objQxFuncModuleEN.FuncModuleNameSim == "[null]") objQxFuncModuleEN.FuncModuleNameSim = null; //模块名_Sim
if (objQxFuncModuleEN.FuncModuleEnName == "[null]") objQxFuncModuleEN.FuncModuleEnName = null; //模块英文名
if (objQxFuncModuleEN.UpdDate == "[null]") objQxFuncModuleEN.UpdDate = null; //修改日期
if (objQxFuncModuleEN.UpdUser == "[null]") objQxFuncModuleEN.UpdUser = null; //修改用户
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
public static void CheckPropertyNew(clsQxFuncModuleEN objQxFuncModuleEN)
{
 QxFuncModuleDA.CheckPropertyNew(objQxFuncModuleEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsQxFuncModuleEN objQxFuncModuleEN)
{
 QxFuncModuleDA.CheckProperty4Condition(objQxFuncModuleEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_FuncModuleId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conQxFuncModule.FuncModuleId); 
List<clsQxFuncModuleEN> arrObjLst = clsQxFuncModuleBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsQxFuncModuleEN objQxFuncModuleEN = new clsQxFuncModuleEN()
{
FuncModuleId = "0",
FuncModuleName = "选[功能模块]..."
};
arrObjLst.Insert(0, objQxFuncModuleEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conQxFuncModule.FuncModuleId;
objComboBox.DisplayMember = conQxFuncModule.FuncModuleName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_FuncModuleId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[功能模块]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conQxFuncModule.FuncModuleId); 
IEnumerable<clsQxFuncModuleEN> arrObjLst = clsQxFuncModuleBL.GetObjLst(strCondition);
objDDL.DataValueField = conQxFuncModule.FuncModuleId;
objDDL.DataTextField = conQxFuncModule.FuncModuleName;
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
public static void BindDdl_FuncModuleIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[功能模块]...","0");
List<clsQxFuncModuleEN> arrQxFuncModuleObjLst = GetAllQxFuncModuleObjLstCache(); 
arrQxFuncModuleObjLst = arrQxFuncModuleObjLst.OrderBy(x=>x.OrderNum).ToList(); 
objDDL.DataValueField = conQxFuncModule.FuncModuleId;
objDDL.DataTextField = conQxFuncModule.FuncModuleName;
objDDL.DataSource = arrQxFuncModuleObjLst;
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
if (clsQxFuncModuleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxFuncModuleBL没有刷新缓存机制(clsQxFuncModuleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by FuncModuleId");
//if (arrQxFuncModuleObjLstCache == null)
//{
//arrQxFuncModuleObjLstCache = QxFuncModuleDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strFuncModuleId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxFuncModuleEN GetObjByFuncModuleIdCache(string strFuncModuleId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsQxFuncModuleEN._CurrTabName);
List<clsQxFuncModuleEN> arrQxFuncModuleObjLstCache = GetObjLstCache();
IEnumerable <clsQxFuncModuleEN> arrQxFuncModuleObjLst_Sel =
arrQxFuncModuleObjLstCache
.Where(x=> x.FuncModuleId == strFuncModuleId 
);
if (arrQxFuncModuleObjLst_Sel.Count() == 0)
{
   clsQxFuncModuleEN obj = clsQxFuncModuleBL.GetObjByFuncModuleId(strFuncModuleId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrQxFuncModuleObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFuncModuleId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetFuncModuleNameByFuncModuleIdCache(string strFuncModuleId)
{
if (string.IsNullOrEmpty(strFuncModuleId) == true) return "";
//获取缓存中的对象列表
clsQxFuncModuleEN objQxFuncModule = GetObjByFuncModuleIdCache(strFuncModuleId);
if (objQxFuncModule == null) return "";
return objQxFuncModule.FuncModuleName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFuncModuleId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByFuncModuleIdCache(string strFuncModuleId)
{
if (string.IsNullOrEmpty(strFuncModuleId) == true) return "";
//获取缓存中的对象列表
clsQxFuncModuleEN objQxFuncModule = GetObjByFuncModuleIdCache(strFuncModuleId);
if (objQxFuncModule == null) return "";
return objQxFuncModule.FuncModuleName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxFuncModuleEN> GetAllQxFuncModuleObjLstCache()
{
//获取缓存中的对象列表
List<clsQxFuncModuleEN> arrQxFuncModuleObjLstCache = GetObjLstCache(); 
return arrQxFuncModuleObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxFuncModuleEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsQxFuncModuleEN._CurrTabName);
List<clsQxFuncModuleEN> arrQxFuncModuleObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrQxFuncModuleObjLstCache;
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
string strKey = string.Format("{0}", clsQxFuncModuleEN._CurrTabName);
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
if (clsQxFuncModuleBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsQxFuncModuleEN._CurrTabName);
CacheHelper.Remove(strKey);
clsQxFuncModuleBL.objCommFun4BL.ReFreshCache();
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
 /// <param name = "lstQxFuncModuleObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsQxFuncModuleEN> lstQxFuncModuleObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstQxFuncModuleObjLst, writer);
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
 /// <param name = "lstQxFuncModuleObjLst">[clsQxFuncModuleEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsQxFuncModuleEN> lstQxFuncModuleObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsQxFuncModuleBL.listXmlNode);
writer.WriteStartElement(clsQxFuncModuleBL.itemsXmlNode);
foreach (clsQxFuncModuleEN objQxFuncModuleEN in lstQxFuncModuleObjLst)
{
clsQxFuncModuleBL.SerializeXML(writer, objQxFuncModuleEN);
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
 /// <param name = "objQxFuncModuleEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsQxFuncModuleEN objQxFuncModuleEN)
{
writer.WriteStartElement(clsQxFuncModuleBL.itemXmlNode);
 
if (objQxFuncModuleEN.FuncModuleId != null)
{
writer.WriteElementString(conQxFuncModule.FuncModuleId, objQxFuncModuleEN.FuncModuleId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxFuncModuleEN.FuncModuleName != null)
{
writer.WriteElementString(conQxFuncModule.FuncModuleName, objQxFuncModuleEN.FuncModuleName.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxFuncModuleEN.FuncModuleNameSim != null)
{
writer.WriteElementString(conQxFuncModule.FuncModuleNameSim, objQxFuncModuleEN.FuncModuleNameSim.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxFuncModuleEN.FuncModuleEnName != null)
{
writer.WriteElementString(conQxFuncModule.FuncModuleEnName, objQxFuncModuleEN.FuncModuleEnName.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(conQxFuncModule.OrderNum, objQxFuncModuleEN.OrderNum.ToString(CultureInfo.InvariantCulture));
 
writer.WriteElementString(conQxFuncModule.InUse, objQxFuncModuleEN.InUse.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objQxFuncModuleEN.QxPrjId != null)
{
writer.WriteElementString(conQxFuncModule.QxPrjId, objQxFuncModuleEN.QxPrjId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxFuncModuleEN.UpdDate != null)
{
writer.WriteElementString(conQxFuncModule.UpdDate, objQxFuncModuleEN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxFuncModuleEN.UpdUser != null)
{
writer.WriteElementString(conQxFuncModule.UpdUser, objQxFuncModuleEN.UpdUser.ToString(CultureInfo.InvariantCulture));
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
public static clsQxFuncModuleEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsQxFuncModuleEN objQxFuncModuleEN = new clsQxFuncModuleEN();
reader.Read();
while (!(reader.Name == clsQxFuncModuleBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(conQxFuncModule.FuncModuleId))
{
objQxFuncModuleEN.FuncModuleId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxFuncModule.FuncModuleName))
{
objQxFuncModuleEN.FuncModuleName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxFuncModule.FuncModuleNameSim))
{
objQxFuncModuleEN.FuncModuleNameSim = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxFuncModule.FuncModuleEnName))
{
objQxFuncModuleEN.FuncModuleEnName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxFuncModule.OrderNum))
{
objQxFuncModuleEN.OrderNum = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(conQxFuncModule.InUse))
{
objQxFuncModuleEN.InUse = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(conQxFuncModule.QxPrjId))
{
objQxFuncModuleEN.QxPrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxFuncModule.UpdDate))
{
objQxFuncModuleEN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxFuncModule.UpdUser))
{
objQxFuncModuleEN.UpdUser = reader.ReadElementContentAsString();
}
}
return objQxFuncModuleEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strQxFuncModuleObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsQxFuncModuleEN GetObjFromXmlStr(string strQxFuncModuleObjXmlStr)
{
clsQxFuncModuleEN objQxFuncModuleEN = new clsQxFuncModuleEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strQxFuncModuleObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsQxFuncModuleBL.itemXmlNode))
{
objQxFuncModuleEN = GetObjFromXml(reader);
return objQxFuncModuleEN;
}
}
return objQxFuncModuleEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objQxFuncModuleEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsQxFuncModuleEN objQxFuncModuleEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objQxFuncModuleEN);
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
public static string Func(string strInFldName, string strOutFldName, string strFuncModuleId)
{
if (strInFldName != conQxFuncModule.FuncModuleId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conQxFuncModule.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conQxFuncModule.AttributeName));
throw new Exception(strMsg);
}
var objQxFuncModule = clsQxFuncModuleBL.GetObjByFuncModuleIdCache(strFuncModuleId);
if (objQxFuncModule == null) return "";
return objQxFuncModule[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objQxFuncModuleEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsQxFuncModuleEN objQxFuncModuleEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsQxFuncModuleEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objQxFuncModuleEN[strField]);
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
 /// <param name = "lstQxFuncModuleObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsQxFuncModuleEN> lstQxFuncModuleObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstQxFuncModuleObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsQxFuncModuleEN objQxFuncModuleEN in lstQxFuncModuleObjLst)
{
string strJSON_One = SerializeObjToJSON(objQxFuncModuleEN);
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
int intRecCount = clsQxFuncModuleDA.GetRecCount(strTabName);
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
int intRecCount = clsQxFuncModuleDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsQxFuncModuleDA.GetRecCount();
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
int intRecCount = clsQxFuncModuleDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objQxFuncModuleCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsQxFuncModuleEN objQxFuncModuleCond)
{
List<clsQxFuncModuleEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxFuncModuleEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxFuncModule.AttributeName)
{
if (objQxFuncModuleCond.IsUpdated(strFldName) == false) continue;
if (objQxFuncModuleCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxFuncModuleCond[strFldName].ToString());
}
else
{
if (objQxFuncModuleCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxFuncModuleCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxFuncModuleCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxFuncModuleCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxFuncModuleCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxFuncModuleCond[strFldName]));
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
 List<string> arrList = clsQxFuncModuleDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = QxFuncModuleDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = QxFuncModuleDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = QxFuncModuleDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxFuncModuleDA.SetFldValue(clsQxFuncModuleEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = QxFuncModuleDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxFuncModuleDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxFuncModuleDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxFuncModuleDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[QxFuncModule] "); 
 strCreateTabCode.Append(" ( "); 
 // /**模块Id*/ 
 strCreateTabCode.Append(" FuncModuleId char(4) primary key, "); 
 // /**模块名*/ 
 strCreateTabCode.Append(" FuncModuleName varchar(30) not Null, "); 
 // /**模块名_Sim*/ 
 strCreateTabCode.Append(" FuncModuleNameSim varchar(30) Null, "); 
 // /**模块英文名*/ 
 strCreateTabCode.Append(" FuncModuleEnName varchar(30) Null, "); 
 // /**排序号*/ 
 strCreateTabCode.Append(" OrderNum int not Null, "); 
 // /**是否在用*/ 
 strCreateTabCode.Append(" InUse bit Null, "); 
 // /**项目Id*/ 
 strCreateTabCode.Append(" QxPrjId char(4) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改用户*/ 
 strCreateTabCode.Append(" UpdUser varchar(18) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
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
strCondition += string.Format(" And {0} = '{1}' ", conQxFuncModule.QxPrjId, strQxPrjId);
 strCondition += string.Format(" order by OrderNum ");
List<clsQxFuncModuleEN> arrQxFuncModuleObjList = new clsQxFuncModuleDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsQxFuncModuleEN objQxFuncModule in arrQxFuncModuleObjList)
{
objQxFuncModule.OrderNum = intIndex;
UpdateBySql2(objQxFuncModule);
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
/// <param name="strFuncModuleId">所给的关键字</param>
/// <param name="strQxPrjId">分类字段</param>
/// <returns>是否成功?</returns>
public static bool AdjustOrderNum(string strDirect, string strFuncModuleId, string strQxPrjId)
{
try
{
//操作步骤：
//1、根据所给定的关键字[FuncModuleId],获取相应的序号[OrderNum]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//   3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字FuncModuleId
//5、把当前关键字FuncModuleId所对应记录的序号加(减)1
//6、把下(上)一个序号关键字FuncModuleId所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
string strPrevFuncModuleId = "";    //上一条序号的关键字FuncModuleId
string strNextFuncModuleId = "";    //下一条序号的关键字FuncModuleId
int intTabRecNum;       //当前表中字段的记录数
StringBuilder sbCondition = new StringBuilder();
//1、根据所给定的关键字[FuncModuleId],获取相应的序号[OrderNum]。

clsQxFuncModuleEN objQxFuncModule = clsQxFuncModuleBL.GetObjByFuncModuleId(strFuncModuleId);

intOrderNum = objQxFuncModule.OrderNum;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conQxFuncModule.QxPrjId, strQxPrjId);
intTabRecNum = clsQxFuncModuleBL.GetRecCountByCond(clsQxFuncModuleEN._CurrTabName, strCondition);    //获取当前表的记录数
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
sbCondition.AppendFormat(" {0} = {1} ", conQxFuncModule.OrderNum, intOrderNum - 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conQxFuncModule.QxPrjId, strQxPrjId);
//4、获取上一个序号字段的关键字FuncModuleId
strPrevFuncModuleId = clsQxFuncModuleBL.GetFirstID_S(sbCondition.ToString());
if (string.IsNullOrEmpty(strPrevFuncModuleId) == true)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字FuncModuleId所对应记录的序号减1
//6、把下(上)一个序号关键字FuncModuleId所对应的记录序号加1
clsQxFuncModuleBL.SetFldValue(clsQxFuncModuleEN._CurrTabName, conQxFuncModule.OrderNum,
 	 	intOrderNum - 1,
  	 	string.Format("{0} = '{1}'", conQxFuncModule.FuncModuleId, strFuncModuleId));
clsQxFuncModuleBL.SetFldValue(clsQxFuncModuleEN._CurrTabName, conQxFuncModule.OrderNum,
 	 	intPrevOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conQxFuncModule.FuncModuleId, strPrevFuncModuleId));
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

//4、获取下一个序号字段的关键字FuncModuleId
sbCondition.AppendFormat(" {0} = {1} ", conQxFuncModule.OrderNum, intOrderNum + 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conQxFuncModule.QxPrjId, strQxPrjId);

strNextFuncModuleId = clsQxFuncModuleBL.GetFirstID_S(sbCondition.ToString());
if (string.IsNullOrEmpty(strNextFuncModuleId) == true)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字FuncModuleId所对应记录的序号加1
//6、把下(上)一个序号关键字FuncModuleId所对应的记录序号减1
clsQxFuncModuleBL.SetFldValue(clsQxFuncModuleEN._CurrTabName, conQxFuncModule.OrderNum,
 	 	intOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conQxFuncModule.FuncModuleId, strFuncModuleId));
clsQxFuncModuleBL.SetFldValue(clsQxFuncModuleEN._CurrTabName, conQxFuncModule.OrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conQxFuncModule.FuncModuleId, strNextFuncModuleId));
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
string strCondition = string.Format("{0} in ({1})", conQxFuncModule.FuncModuleId, strKeyList);
List<clsQxFuncModuleEN> arrQxFuncModuleLst = GetObjLst(strCondition);
foreach (clsQxFuncModuleEN objQxFuncModule in arrQxFuncModuleLst)
{
objQxFuncModule.OrderNum = objQxFuncModule.OrderNum + 10000;
UpdateBySql2(objQxFuncModule);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conQxFuncModule.QxPrjId, strQxPrjId);
 strCondition += string.Format(" order by OrderNum ");
List<clsQxFuncModuleEN> arrQxFuncModuleObjList = new clsQxFuncModuleDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsQxFuncModuleEN objQxFuncModule in arrQxFuncModuleObjList)
{
objQxFuncModule.OrderNum = intIndex;
UpdateBySql2(objQxFuncModule);
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
string strCondition = string.Format("{0} in ({1})", conQxFuncModule.FuncModuleId, strKeyList);
List<clsQxFuncModuleEN> arrQxFuncModuleLst = GetObjLst(strCondition);
foreach (clsQxFuncModuleEN objQxFuncModule in arrQxFuncModuleLst)
{
objQxFuncModule.OrderNum = objQxFuncModule.OrderNum - 10000;
UpdateBySql2(objQxFuncModule);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conQxFuncModule.QxPrjId, strQxPrjId);
 strCondition += string.Format(" order by OrderNum ");
List<clsQxFuncModuleEN> arrQxFuncModuleObjList = new clsQxFuncModuleDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsQxFuncModuleEN objQxFuncModule in arrQxFuncModuleObjList)
{
objQxFuncModule.OrderNum = intIndex;
UpdateBySql2(objQxFuncModule);
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
 /// 功能模块(QxFuncModule)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4QxFuncModule : clsCommFun4BL
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
clsQxFuncModuleBL.ReFreshThisCache();
}
}

}