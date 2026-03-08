
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxRolePotenceRelaBL
 表名:QxRolePotenceRela(00140123)
 * 版本:2024.03.19.1(服务器:WIN-SRV103-116)
 日期:2024/03/20 11:14:53
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:权限管理(PotenceMan)
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
public static class  clsQxRolePotenceRelaBL_Static
{

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQxRolePotenceRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQxRolePotenceRelaEN objQxRolePotenceRelaEN)
{
 if (string.IsNullOrEmpty(objQxRolePotenceRelaEN.RoleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (string.IsNullOrEmpty(objQxRolePotenceRelaEN.PotenceId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQxRolePotenceRelaBL.IsExist(objQxRolePotenceRelaEN.RoleId,objQxRolePotenceRelaEN.PotenceId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQxRolePotenceRelaEN.RoleId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsQxRolePotenceRelaBL.QxRolePotenceRelaDA.AddNewRecordBySQL2(objQxRolePotenceRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRolePotenceRelaBL.ReFreshCache();

if (clsQxRolePotenceRelaBL.relatedActions != null)
{
clsQxRolePotenceRelaBL.relatedActions.UpdRelaTabDate(objQxRolePotenceRelaEN.RoleId,objQxRolePotenceRelaEN.PotenceId, objQxRolePotenceRelaEN.UpdUser);
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
public static bool AddRecordEx(this clsQxRolePotenceRelaEN objQxRolePotenceRelaEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsQxRolePotenceRelaBL.IsExist(objQxRolePotenceRelaEN.RoleId,objQxRolePotenceRelaEN.PotenceId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objQxRolePotenceRelaEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objQxRolePotenceRelaEN.AddNewRecord();
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
 /// <param name = "objQxRolePotenceRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsQxRolePotenceRelaEN objQxRolePotenceRelaEN)
{
 if (string.IsNullOrEmpty(objQxRolePotenceRelaEN.RoleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQxRolePotenceRelaBL.IsExist(objQxRolePotenceRelaEN.RoleId,objQxRolePotenceRelaEN.PotenceId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQxRolePotenceRelaEN.RoleId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsQxRolePotenceRelaBL.QxRolePotenceRelaDA.AddNewRecordBySQL2WithReturnKey(objQxRolePotenceRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRolePotenceRelaBL.ReFreshCache();

if (clsQxRolePotenceRelaBL.relatedActions != null)
{
clsQxRolePotenceRelaBL.relatedActions.UpdRelaTabDate(objQxRolePotenceRelaEN.RoleId,objQxRolePotenceRelaEN.PotenceId, objQxRolePotenceRelaEN.UpdUser);
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
 /// <param name = "objQxRolePotenceRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRolePotenceRelaEN SetRoleId(this clsQxRolePotenceRelaEN objQxRolePotenceRelaEN, string strRoleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRoleId, 8, conQxRolePotenceRela.RoleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, conQxRolePotenceRela.RoleId);
}
objQxRolePotenceRelaEN.RoleId = strRoleId; //角色Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRolePotenceRelaEN.dicFldComparisonOp.ContainsKey(conQxRolePotenceRela.RoleId) == false)
{
objQxRolePotenceRelaEN.dicFldComparisonOp.Add(conQxRolePotenceRela.RoleId, strComparisonOp);
}
else
{
objQxRolePotenceRelaEN.dicFldComparisonOp[conQxRolePotenceRela.RoleId] = strComparisonOp;
}
}
return objQxRolePotenceRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRolePotenceRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRolePotenceRelaEN SetPotenceId(this clsQxRolePotenceRelaEN objQxRolePotenceRelaEN, string strPotenceId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPotenceId, 8, conQxRolePotenceRela.PotenceId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPotenceId, 8, conQxRolePotenceRela.PotenceId);
}
objQxRolePotenceRelaEN.PotenceId = strPotenceId; //权限ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRolePotenceRelaEN.dicFldComparisonOp.ContainsKey(conQxRolePotenceRela.PotenceId) == false)
{
objQxRolePotenceRelaEN.dicFldComparisonOp.Add(conQxRolePotenceRela.PotenceId, strComparisonOp);
}
else
{
objQxRolePotenceRelaEN.dicFldComparisonOp[conQxRolePotenceRela.PotenceId] = strComparisonOp;
}
}
return objQxRolePotenceRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRolePotenceRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRolePotenceRelaEN SetQxPrjId(this clsQxRolePotenceRelaEN objQxRolePotenceRelaEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, conQxRolePotenceRela.QxPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQxPrjId, 4, conQxRolePotenceRela.QxPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, conQxRolePotenceRela.QxPrjId);
}
objQxRolePotenceRelaEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRolePotenceRelaEN.dicFldComparisonOp.ContainsKey(conQxRolePotenceRela.QxPrjId) == false)
{
objQxRolePotenceRelaEN.dicFldComparisonOp.Add(conQxRolePotenceRela.QxPrjId, strComparisonOp);
}
else
{
objQxRolePotenceRelaEN.dicFldComparisonOp[conQxRolePotenceRela.QxPrjId] = strComparisonOp;
}
}
return objQxRolePotenceRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRolePotenceRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRolePotenceRelaEN SetUpdDate(this clsQxRolePotenceRelaEN objQxRolePotenceRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conQxRolePotenceRela.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQxRolePotenceRela.UpdDate);
}
objQxRolePotenceRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRolePotenceRelaEN.dicFldComparisonOp.ContainsKey(conQxRolePotenceRela.UpdDate) == false)
{
objQxRolePotenceRelaEN.dicFldComparisonOp.Add(conQxRolePotenceRela.UpdDate, strComparisonOp);
}
else
{
objQxRolePotenceRelaEN.dicFldComparisonOp[conQxRolePotenceRela.UpdDate] = strComparisonOp;
}
}
return objQxRolePotenceRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRolePotenceRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRolePotenceRelaEN SetUpdUser(this clsQxRolePotenceRelaEN objQxRolePotenceRelaEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conQxRolePotenceRela.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conQxRolePotenceRela.UpdUser);
}
objQxRolePotenceRelaEN.UpdUser = strUpdUser; //修改用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRolePotenceRelaEN.dicFldComparisonOp.ContainsKey(conQxRolePotenceRela.UpdUser) == false)
{
objQxRolePotenceRelaEN.dicFldComparisonOp.Add(conQxRolePotenceRela.UpdUser, strComparisonOp);
}
else
{
objQxRolePotenceRelaEN.dicFldComparisonOp[conQxRolePotenceRela.UpdUser] = strComparisonOp;
}
}
return objQxRolePotenceRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRolePotenceRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRolePotenceRelaEN SetMemo(this clsQxRolePotenceRelaEN objQxRolePotenceRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQxRolePotenceRela.Memo);
}
objQxRolePotenceRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRolePotenceRelaEN.dicFldComparisonOp.ContainsKey(conQxRolePotenceRela.Memo) == false)
{
objQxRolePotenceRelaEN.dicFldComparisonOp.Add(conQxRolePotenceRela.Memo, strComparisonOp);
}
else
{
objQxRolePotenceRelaEN.dicFldComparisonOp[conQxRolePotenceRela.Memo] = strComparisonOp;
}
}
return objQxRolePotenceRelaEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objQxRolePotenceRelaEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsQxRolePotenceRelaEN objQxRolePotenceRelaEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objQxRolePotenceRelaEN.CheckPropertyNew();
clsQxRolePotenceRelaEN objQxRolePotenceRelaCond = new clsQxRolePotenceRelaEN();
string strCondition = objQxRolePotenceRelaCond
.SetRoleId(objQxRolePotenceRelaEN.RoleId, "=")
.GetCombineCondition();
objQxRolePotenceRelaEN._IsCheckProperty = true;
bool bolIsExist = clsQxRolePotenceRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objQxRolePotenceRelaEN.Update();
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
 /// <param name = "objQxRolePotenceRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxRolePotenceRelaEN objQxRolePotenceRelaEN)
{
 if (string.IsNullOrEmpty(objQxRolePotenceRelaEN.RoleId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxRolePotenceRelaBL.QxRolePotenceRelaDA.UpdateBySql2(objQxRolePotenceRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRolePotenceRelaBL.ReFreshCache();

if (clsQxRolePotenceRelaBL.relatedActions != null)
{
clsQxRolePotenceRelaBL.relatedActions.UpdRelaTabDate(objQxRolePotenceRelaEN.RoleId,objQxRolePotenceRelaEN.PotenceId, objQxRolePotenceRelaEN.UpdUser);
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
 /// <param name = "objQxRolePotenceRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxRolePotenceRelaEN objQxRolePotenceRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objQxRolePotenceRelaEN.RoleId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxRolePotenceRelaBL.QxRolePotenceRelaDA.UpdateBySql2(objQxRolePotenceRelaEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRolePotenceRelaBL.ReFreshCache();

if (clsQxRolePotenceRelaBL.relatedActions != null)
{
clsQxRolePotenceRelaBL.relatedActions.UpdRelaTabDate(objQxRolePotenceRelaEN.RoleId,objQxRolePotenceRelaEN.PotenceId, objQxRolePotenceRelaEN.UpdUser);
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
 /// <param name = "objQxRolePotenceRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxRolePotenceRelaEN objQxRolePotenceRelaEN, string strWhereCond)
{
try
{
bool bolResult = clsQxRolePotenceRelaBL.QxRolePotenceRelaDA.UpdateBySqlWithCondition(objQxRolePotenceRelaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRolePotenceRelaBL.ReFreshCache();

if (clsQxRolePotenceRelaBL.relatedActions != null)
{
clsQxRolePotenceRelaBL.relatedActions.UpdRelaTabDate(objQxRolePotenceRelaEN.RoleId,objQxRolePotenceRelaEN.PotenceId, objQxRolePotenceRelaEN.UpdUser);
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
 /// <param name = "objQxRolePotenceRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxRolePotenceRelaEN objQxRolePotenceRelaEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsQxRolePotenceRelaBL.QxRolePotenceRelaDA.UpdateBySqlWithConditionTransaction(objQxRolePotenceRelaEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRolePotenceRelaBL.ReFreshCache();

if (clsQxRolePotenceRelaBL.relatedActions != null)
{
clsQxRolePotenceRelaBL.relatedActions.UpdRelaTabDate(objQxRolePotenceRelaEN.RoleId,objQxRolePotenceRelaEN.PotenceId, objQxRolePotenceRelaEN.UpdUser);
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
 /// <param name = "strRoleId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsQxRolePotenceRelaEN objQxRolePotenceRelaEN)
{
try
{
int intRecNum = clsQxRolePotenceRelaBL.QxRolePotenceRelaDA.DelRecord(objQxRolePotenceRelaEN.RoleId,objQxRolePotenceRelaEN.PotenceId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRolePotenceRelaBL.ReFreshCache();

if (clsQxRolePotenceRelaBL.relatedActions != null)
{
clsQxRolePotenceRelaBL.relatedActions.UpdRelaTabDate(objQxRolePotenceRelaEN.RoleId,objQxRolePotenceRelaEN.PotenceId, objQxRolePotenceRelaEN.UpdUser);
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
 /// <param name = "objQxRolePotenceRelaENS">源对象</param>
 /// <param name = "objQxRolePotenceRelaENT">目标对象</param>
 public static void CopyTo(this clsQxRolePotenceRelaEN objQxRolePotenceRelaENS, clsQxRolePotenceRelaEN objQxRolePotenceRelaENT)
{
try
{
objQxRolePotenceRelaENT.RoleId = objQxRolePotenceRelaENS.RoleId; //角色Id
objQxRolePotenceRelaENT.PotenceId = objQxRolePotenceRelaENS.PotenceId; //权限ID
objQxRolePotenceRelaENT.QxPrjId = objQxRolePotenceRelaENS.QxPrjId; //项目Id
objQxRolePotenceRelaENT.UpdDate = objQxRolePotenceRelaENS.UpdDate; //修改日期
objQxRolePotenceRelaENT.UpdUser = objQxRolePotenceRelaENS.UpdUser; //修改用户
objQxRolePotenceRelaENT.Memo = objQxRolePotenceRelaENS.Memo; //备注
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
 /// <param name = "objQxRolePotenceRelaENS">源对象</param>
 /// <returns>目标对象=>clsQxRolePotenceRelaEN:objQxRolePotenceRelaENT</returns>
 public static clsQxRolePotenceRelaEN CopyTo(this clsQxRolePotenceRelaEN objQxRolePotenceRelaENS)
{
try
{
 clsQxRolePotenceRelaEN objQxRolePotenceRelaENT = new clsQxRolePotenceRelaEN()
{
RoleId = objQxRolePotenceRelaENS.RoleId, //角色Id
PotenceId = objQxRolePotenceRelaENS.PotenceId, //权限ID
QxPrjId = objQxRolePotenceRelaENS.QxPrjId, //项目Id
UpdDate = objQxRolePotenceRelaENS.UpdDate, //修改日期
UpdUser = objQxRolePotenceRelaENS.UpdUser, //修改用户
Memo = objQxRolePotenceRelaENS.Memo, //备注
};
 return objQxRolePotenceRelaENT;
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
public static void CheckPropertyNew(this clsQxRolePotenceRelaEN objQxRolePotenceRelaEN)
{
 clsQxRolePotenceRelaBL.QxRolePotenceRelaDA.CheckPropertyNew(objQxRolePotenceRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsQxRolePotenceRelaEN objQxRolePotenceRelaEN)
{
 clsQxRolePotenceRelaBL.QxRolePotenceRelaDA.CheckProperty4Condition(objQxRolePotenceRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQxRolePotenceRelaEN objQxRolePotenceRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQxRolePotenceRelaCond.IsUpdated(conQxRolePotenceRela.RoleId) == true)
{
string strComparisonOpRoleId = objQxRolePotenceRelaCond.dicFldComparisonOp[conQxRolePotenceRela.RoleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxRolePotenceRela.RoleId, objQxRolePotenceRelaCond.RoleId, strComparisonOpRoleId);
}
if (objQxRolePotenceRelaCond.IsUpdated(conQxRolePotenceRela.PotenceId) == true)
{
string strComparisonOpPotenceId = objQxRolePotenceRelaCond.dicFldComparisonOp[conQxRolePotenceRela.PotenceId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxRolePotenceRela.PotenceId, objQxRolePotenceRelaCond.PotenceId, strComparisonOpPotenceId);
}
if (objQxRolePotenceRelaCond.IsUpdated(conQxRolePotenceRela.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objQxRolePotenceRelaCond.dicFldComparisonOp[conQxRolePotenceRela.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxRolePotenceRela.QxPrjId, objQxRolePotenceRelaCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objQxRolePotenceRelaCond.IsUpdated(conQxRolePotenceRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objQxRolePotenceRelaCond.dicFldComparisonOp[conQxRolePotenceRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxRolePotenceRela.UpdDate, objQxRolePotenceRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objQxRolePotenceRelaCond.IsUpdated(conQxRolePotenceRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objQxRolePotenceRelaCond.dicFldComparisonOp[conQxRolePotenceRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxRolePotenceRela.UpdUser, objQxRolePotenceRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objQxRolePotenceRelaCond.IsUpdated(conQxRolePotenceRela.Memo) == true)
{
string strComparisonOpMemo = objQxRolePotenceRelaCond.dicFldComparisonOp[conQxRolePotenceRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxRolePotenceRela.Memo, objQxRolePotenceRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_QxRolePotenceRela
{
public virtual bool UpdRelaTabDate(string strRoleId,string strPotenceId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 角色权限关系(QxRolePotenceRela)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsQxRolePotenceRelaBL
{
public static RelatedActions_QxRolePotenceRela relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "QxRolePotenceRelaListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "QxRolePotenceRelaList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsQxRolePotenceRelaEN> arrQxRolePotenceRelaObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsQxRolePotenceRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsQxRolePotenceRelaDA QxRolePotenceRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsQxRolePotenceRelaDA();
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
 public clsQxRolePotenceRelaBL()
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
if (string.IsNullOrEmpty(clsQxRolePotenceRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxRolePotenceRelaEN._ConnectString);
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
objDS = QxRolePotenceRelaDA.GetDataSet(strWhereCond);
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
objDS = QxRolePotenceRelaDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = QxRolePotenceRelaDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_QxRolePotenceRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = QxRolePotenceRelaDA.GetDataTable_QxRolePotenceRela(strWhereCond);
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
objDT = QxRolePotenceRelaDA.GetDataTable(strWhereCond);
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
objDT = QxRolePotenceRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = QxRolePotenceRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = QxRolePotenceRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = QxRolePotenceRelaDA.GetDataTable_Top(objTopPara);
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
objDT = QxRolePotenceRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = QxRolePotenceRelaDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = QxRolePotenceRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = QxRolePotenceRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = QxRolePotenceRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = QxRolePotenceRelaDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = QxRolePotenceRelaDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = QxRolePotenceRelaDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
 /// 把多个关键字段的值连接起来,用|连接(Join)--QxRolePotenceRela(角色权限关系)
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_JoinByKeyLst)
 /// </summary>
 /// <param name = "objQxRolePotenceRelaEN">需要连接的对象</param>
 /// <returns></returns>
public static string JoinByKeyLst(clsQxRolePotenceRelaEN objQxRolePotenceRelaEN)
{
//检测记录是否存在
string strResult = "";
strResult += objQxRolePotenceRelaEN.RoleId;
strResult += "|" + objQxRolePotenceRelaEN.PotenceId;
return strResult;
}
 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrKeyLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsQxRolePotenceRelaEN> GetObjLstByKeyLstsCache(List<string> arrKeyLst)
{
string strKey = string.Format("{0}", clsQxRolePotenceRelaEN._CurrTabName);
List<clsQxRolePotenceRelaEN> arrQxRolePotenceRelaObjLstCache = GetObjLstCache();
IEnumerable <clsQxRolePotenceRelaEN> arrQxRolePotenceRelaObjLst_Sel =
arrQxRolePotenceRelaObjLstCache
.Where(x => arrKeyLst.Contains(JoinByKeyLst(x)));
return arrQxRolePotenceRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxRolePotenceRelaEN> GetObjLst(string strWhereCond)
{
List<clsQxRolePotenceRelaEN> arrObjLst = new List<clsQxRolePotenceRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRolePotenceRelaEN objQxRolePotenceRelaEN = new clsQxRolePotenceRelaEN();
try
{
objQxRolePotenceRelaEN.RoleId = objRow[conQxRolePotenceRela.RoleId].ToString().Trim(); //角色Id
objQxRolePotenceRelaEN.PotenceId = objRow[conQxRolePotenceRela.PotenceId].ToString().Trim(); //权限ID
objQxRolePotenceRelaEN.QxPrjId = objRow[conQxRolePotenceRela.QxPrjId].ToString().Trim(); //项目Id
objQxRolePotenceRelaEN.UpdDate = objRow[conQxRolePotenceRela.UpdDate].ToString().Trim(); //修改日期
objQxRolePotenceRelaEN.UpdUser = objRow[conQxRolePotenceRela.UpdUser].ToString().Trim(); //修改用户
objQxRolePotenceRelaEN.Memo = objRow[conQxRolePotenceRela.Memo] == DBNull.Value ? null : objRow[conQxRolePotenceRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxRolePotenceRelaEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxRolePotenceRelaEN);
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
public static List<clsQxRolePotenceRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsQxRolePotenceRelaEN> arrObjLst = new List<clsQxRolePotenceRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRolePotenceRelaEN objQxRolePotenceRelaEN = new clsQxRolePotenceRelaEN();
try
{
objQxRolePotenceRelaEN.RoleId = objRow[conQxRolePotenceRela.RoleId].ToString().Trim(); //角色Id
objQxRolePotenceRelaEN.PotenceId = objRow[conQxRolePotenceRela.PotenceId].ToString().Trim(); //权限ID
objQxRolePotenceRelaEN.QxPrjId = objRow[conQxRolePotenceRela.QxPrjId].ToString().Trim(); //项目Id
objQxRolePotenceRelaEN.UpdDate = objRow[conQxRolePotenceRela.UpdDate].ToString().Trim(); //修改日期
objQxRolePotenceRelaEN.UpdUser = objRow[conQxRolePotenceRela.UpdUser].ToString().Trim(); //修改用户
objQxRolePotenceRelaEN.Memo = objRow[conQxRolePotenceRela.Memo] == DBNull.Value ? null : objRow[conQxRolePotenceRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxRolePotenceRelaEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxRolePotenceRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objQxRolePotenceRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsQxRolePotenceRelaEN> GetSubObjLstCache(clsQxRolePotenceRelaEN objQxRolePotenceRelaCond)
{
List<clsQxRolePotenceRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxRolePotenceRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxRolePotenceRela.AttributeName)
{
if (objQxRolePotenceRelaCond.IsUpdated(strFldName) == false) continue;
if (objQxRolePotenceRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxRolePotenceRelaCond[strFldName].ToString());
}
else
{
if (objQxRolePotenceRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxRolePotenceRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxRolePotenceRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxRolePotenceRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxRolePotenceRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxRolePotenceRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxRolePotenceRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxRolePotenceRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxRolePotenceRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxRolePotenceRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxRolePotenceRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxRolePotenceRelaCond[strFldName]));
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
public static List<clsQxRolePotenceRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsQxRolePotenceRelaEN> arrObjLst = new List<clsQxRolePotenceRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRolePotenceRelaEN objQxRolePotenceRelaEN = new clsQxRolePotenceRelaEN();
try
{
objQxRolePotenceRelaEN.RoleId = objRow[conQxRolePotenceRela.RoleId].ToString().Trim(); //角色Id
objQxRolePotenceRelaEN.PotenceId = objRow[conQxRolePotenceRela.PotenceId].ToString().Trim(); //权限ID
objQxRolePotenceRelaEN.QxPrjId = objRow[conQxRolePotenceRela.QxPrjId].ToString().Trim(); //项目Id
objQxRolePotenceRelaEN.UpdDate = objRow[conQxRolePotenceRela.UpdDate].ToString().Trim(); //修改日期
objQxRolePotenceRelaEN.UpdUser = objRow[conQxRolePotenceRela.UpdUser].ToString().Trim(); //修改用户
objQxRolePotenceRelaEN.Memo = objRow[conQxRolePotenceRela.Memo] == DBNull.Value ? null : objRow[conQxRolePotenceRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxRolePotenceRelaEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxRolePotenceRelaEN);
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
public static List<clsQxRolePotenceRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsQxRolePotenceRelaEN> arrObjLst = new List<clsQxRolePotenceRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRolePotenceRelaEN objQxRolePotenceRelaEN = new clsQxRolePotenceRelaEN();
try
{
objQxRolePotenceRelaEN.RoleId = objRow[conQxRolePotenceRela.RoleId].ToString().Trim(); //角色Id
objQxRolePotenceRelaEN.PotenceId = objRow[conQxRolePotenceRela.PotenceId].ToString().Trim(); //权限ID
objQxRolePotenceRelaEN.QxPrjId = objRow[conQxRolePotenceRela.QxPrjId].ToString().Trim(); //项目Id
objQxRolePotenceRelaEN.UpdDate = objRow[conQxRolePotenceRela.UpdDate].ToString().Trim(); //修改日期
objQxRolePotenceRelaEN.UpdUser = objRow[conQxRolePotenceRela.UpdUser].ToString().Trim(); //修改用户
objQxRolePotenceRelaEN.Memo = objRow[conQxRolePotenceRela.Memo] == DBNull.Value ? null : objRow[conQxRolePotenceRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxRolePotenceRelaEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxRolePotenceRelaEN);
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
List<clsQxRolePotenceRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsQxRolePotenceRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxRolePotenceRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsQxRolePotenceRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsQxRolePotenceRelaEN> arrObjLst = new List<clsQxRolePotenceRelaEN>(); 
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
	clsQxRolePotenceRelaEN objQxRolePotenceRelaEN = new clsQxRolePotenceRelaEN();
try
{
objQxRolePotenceRelaEN.RoleId = objRow[conQxRolePotenceRela.RoleId].ToString().Trim(); //角色Id
objQxRolePotenceRelaEN.PotenceId = objRow[conQxRolePotenceRela.PotenceId].ToString().Trim(); //权限ID
objQxRolePotenceRelaEN.QxPrjId = objRow[conQxRolePotenceRela.QxPrjId].ToString().Trim(); //项目Id
objQxRolePotenceRelaEN.UpdDate = objRow[conQxRolePotenceRela.UpdDate].ToString().Trim(); //修改日期
objQxRolePotenceRelaEN.UpdUser = objRow[conQxRolePotenceRela.UpdUser].ToString().Trim(); //修改用户
objQxRolePotenceRelaEN.Memo = objRow[conQxRolePotenceRela.Memo] == DBNull.Value ? null : objRow[conQxRolePotenceRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxRolePotenceRelaEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxRolePotenceRelaEN);
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
public static List<clsQxRolePotenceRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsQxRolePotenceRelaEN> arrObjLst = new List<clsQxRolePotenceRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRolePotenceRelaEN objQxRolePotenceRelaEN = new clsQxRolePotenceRelaEN();
try
{
objQxRolePotenceRelaEN.RoleId = objRow[conQxRolePotenceRela.RoleId].ToString().Trim(); //角色Id
objQxRolePotenceRelaEN.PotenceId = objRow[conQxRolePotenceRela.PotenceId].ToString().Trim(); //权限ID
objQxRolePotenceRelaEN.QxPrjId = objRow[conQxRolePotenceRela.QxPrjId].ToString().Trim(); //项目Id
objQxRolePotenceRelaEN.UpdDate = objRow[conQxRolePotenceRela.UpdDate].ToString().Trim(); //修改日期
objQxRolePotenceRelaEN.UpdUser = objRow[conQxRolePotenceRela.UpdUser].ToString().Trim(); //修改用户
objQxRolePotenceRelaEN.Memo = objRow[conQxRolePotenceRela.Memo] == DBNull.Value ? null : objRow[conQxRolePotenceRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxRolePotenceRelaEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxRolePotenceRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsQxRolePotenceRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsQxRolePotenceRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsQxRolePotenceRelaEN> arrObjLst = new List<clsQxRolePotenceRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRolePotenceRelaEN objQxRolePotenceRelaEN = new clsQxRolePotenceRelaEN();
try
{
objQxRolePotenceRelaEN.RoleId = objRow[conQxRolePotenceRela.RoleId].ToString().Trim(); //角色Id
objQxRolePotenceRelaEN.PotenceId = objRow[conQxRolePotenceRela.PotenceId].ToString().Trim(); //权限ID
objQxRolePotenceRelaEN.QxPrjId = objRow[conQxRolePotenceRela.QxPrjId].ToString().Trim(); //项目Id
objQxRolePotenceRelaEN.UpdDate = objRow[conQxRolePotenceRela.UpdDate].ToString().Trim(); //修改日期
objQxRolePotenceRelaEN.UpdUser = objRow[conQxRolePotenceRela.UpdUser].ToString().Trim(); //修改用户
objQxRolePotenceRelaEN.Memo = objRow[conQxRolePotenceRela.Memo] == DBNull.Value ? null : objRow[conQxRolePotenceRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxRolePotenceRelaEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxRolePotenceRelaEN);
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
public static List<clsQxRolePotenceRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsQxRolePotenceRelaEN> arrObjLst = new List<clsQxRolePotenceRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRolePotenceRelaEN objQxRolePotenceRelaEN = new clsQxRolePotenceRelaEN();
try
{
objQxRolePotenceRelaEN.RoleId = objRow[conQxRolePotenceRela.RoleId].ToString().Trim(); //角色Id
objQxRolePotenceRelaEN.PotenceId = objRow[conQxRolePotenceRela.PotenceId].ToString().Trim(); //权限ID
objQxRolePotenceRelaEN.QxPrjId = objRow[conQxRolePotenceRela.QxPrjId].ToString().Trim(); //项目Id
objQxRolePotenceRelaEN.UpdDate = objRow[conQxRolePotenceRela.UpdDate].ToString().Trim(); //修改日期
objQxRolePotenceRelaEN.UpdUser = objRow[conQxRolePotenceRela.UpdUser].ToString().Trim(); //修改用户
objQxRolePotenceRelaEN.Memo = objRow[conQxRolePotenceRela.Memo] == DBNull.Value ? null : objRow[conQxRolePotenceRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxRolePotenceRelaEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxRolePotenceRelaEN);
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
public static IEnumerable<clsQxRolePotenceRelaEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsQxRolePotenceRelaEN objQxRolePotenceRelaCond, string strOrderBy)
{
List<clsQxRolePotenceRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxRolePotenceRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxRolePotenceRela.AttributeName)
{
if (objQxRolePotenceRelaCond.IsUpdated(strFldName) == false) continue;
if (objQxRolePotenceRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxRolePotenceRelaCond[strFldName].ToString());
}
else
{
if (objQxRolePotenceRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxRolePotenceRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxRolePotenceRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxRolePotenceRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxRolePotenceRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxRolePotenceRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxRolePotenceRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxRolePotenceRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxRolePotenceRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxRolePotenceRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxRolePotenceRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxRolePotenceRelaCond[strFldName]));
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
public static IEnumerable<clsQxRolePotenceRelaEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsQxRolePotenceRelaEN objQxRolePotenceRelaCond = JsonConvert.DeserializeObject<clsQxRolePotenceRelaEN>(objPagerPara.whereCond);
if (objQxRolePotenceRelaCond.sfFldComparisonOp == null)
{
objQxRolePotenceRelaCond.dicFldComparisonOp = null;
}
else
{
objQxRolePotenceRelaCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objQxRolePotenceRelaCond.sfFldComparisonOp);
}
clsQxRolePotenceRelaBL.SetUpdFlag(objQxRolePotenceRelaCond);
 try
{
CheckProperty4Condition(objQxRolePotenceRelaCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsQxRolePotenceRelaBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objQxRolePotenceRelaCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxRolePotenceRelaEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsQxRolePotenceRelaEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsQxRolePotenceRelaEN> arrObjLst = new List<clsQxRolePotenceRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRolePotenceRelaEN objQxRolePotenceRelaEN = new clsQxRolePotenceRelaEN();
try
{
objQxRolePotenceRelaEN.RoleId = objRow[conQxRolePotenceRela.RoleId].ToString().Trim(); //角色Id
objQxRolePotenceRelaEN.PotenceId = objRow[conQxRolePotenceRela.PotenceId].ToString().Trim(); //权限ID
objQxRolePotenceRelaEN.QxPrjId = objRow[conQxRolePotenceRela.QxPrjId].ToString().Trim(); //项目Id
objQxRolePotenceRelaEN.UpdDate = objRow[conQxRolePotenceRela.UpdDate].ToString().Trim(); //修改日期
objQxRolePotenceRelaEN.UpdUser = objRow[conQxRolePotenceRela.UpdUser].ToString().Trim(); //修改用户
objQxRolePotenceRelaEN.Memo = objRow[conQxRolePotenceRela.Memo] == DBNull.Value ? null : objRow[conQxRolePotenceRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxRolePotenceRelaEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxRolePotenceRelaEN);
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
public static List<clsQxRolePotenceRelaEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsQxRolePotenceRelaEN> arrObjLst = new List<clsQxRolePotenceRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRolePotenceRelaEN objQxRolePotenceRelaEN = new clsQxRolePotenceRelaEN();
try
{
objQxRolePotenceRelaEN.RoleId = objRow[conQxRolePotenceRela.RoleId].ToString().Trim(); //角色Id
objQxRolePotenceRelaEN.PotenceId = objRow[conQxRolePotenceRela.PotenceId].ToString().Trim(); //权限ID
objQxRolePotenceRelaEN.QxPrjId = objRow[conQxRolePotenceRela.QxPrjId].ToString().Trim(); //项目Id
objQxRolePotenceRelaEN.UpdDate = objRow[conQxRolePotenceRela.UpdDate].ToString().Trim(); //修改日期
objQxRolePotenceRelaEN.UpdUser = objRow[conQxRolePotenceRela.UpdUser].ToString().Trim(); //修改用户
objQxRolePotenceRelaEN.Memo = objRow[conQxRolePotenceRela.Memo] == DBNull.Value ? null : objRow[conQxRolePotenceRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxRolePotenceRelaEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxRolePotenceRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxRolePotenceRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsQxRolePotenceRelaEN> arrObjLst = new List<clsQxRolePotenceRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRolePotenceRelaEN objQxRolePotenceRelaEN = new clsQxRolePotenceRelaEN();
try
{
objQxRolePotenceRelaEN.RoleId = objRow[conQxRolePotenceRela.RoleId].ToString().Trim(); //角色Id
objQxRolePotenceRelaEN.PotenceId = objRow[conQxRolePotenceRela.PotenceId].ToString().Trim(); //权限ID
objQxRolePotenceRelaEN.QxPrjId = objRow[conQxRolePotenceRela.QxPrjId].ToString().Trim(); //项目Id
objQxRolePotenceRelaEN.UpdDate = objRow[conQxRolePotenceRela.UpdDate].ToString().Trim(); //修改日期
objQxRolePotenceRelaEN.UpdUser = objRow[conQxRolePotenceRela.UpdUser].ToString().Trim(); //修改用户
objQxRolePotenceRelaEN.Memo = objRow[conQxRolePotenceRela.Memo] == DBNull.Value ? null : objRow[conQxRolePotenceRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxRolePotenceRelaEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxRolePotenceRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objQxRolePotenceRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxRolePotenceRela(ref clsQxRolePotenceRelaEN objQxRolePotenceRelaEN)
{
bool bolResult = QxRolePotenceRelaDA.GetQxRolePotenceRela(ref objQxRolePotenceRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strRoleId">表关键字</param>
 /// <param name = "strPotenceId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxRolePotenceRelaEN GetObjByKeyLst(string strRoleId,string strPotenceId)
{
if (strRoleId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000168)在表中,关键字[strRoleId,strPotenceId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (strPotenceId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000168)在表中,关键字[strRoleId,strPotenceId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strRoleId) == true)
{
var strMsg = string.Format("(errid:Busi000169)在表中,关键字[strRoleId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strPotenceId) == true)
{
var strMsg = string.Format("(errid:Busi000169)在表中,关键字[strPotenceId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsQxRolePotenceRelaEN objQxRolePotenceRelaEN = QxRolePotenceRelaDA.GetObjByKeyLst(strRoleId,strPotenceId);
return objQxRolePotenceRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsQxRolePotenceRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsQxRolePotenceRelaEN objQxRolePotenceRelaEN = QxRolePotenceRelaDA.GetFirstObj(strWhereCond);
 return objQxRolePotenceRelaEN;
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
public static clsQxRolePotenceRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsQxRolePotenceRelaEN objQxRolePotenceRelaEN = QxRolePotenceRelaDA.GetObjByDataRow(objRow);
 return objQxRolePotenceRelaEN;
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
public static clsQxRolePotenceRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsQxRolePotenceRelaEN objQxRolePotenceRelaEN = QxRolePotenceRelaDA.GetObjByDataRow(objRow);
 return objQxRolePotenceRelaEN;
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
 /// <param name = "strRoleId">表关键字</param>
 /// <param name = "strPotenceId">表关键字</param>
 /// <param name = "lstQxRolePotenceRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxRolePotenceRelaEN GetObjByKeyLstFromList(string strRoleId,string strPotenceId, List<clsQxRolePotenceRelaEN> lstQxRolePotenceRelaObjLst)
{
foreach (clsQxRolePotenceRelaEN objQxRolePotenceRelaEN in lstQxRolePotenceRelaObjLst)
{
if (objQxRolePotenceRelaEN.RoleId == strRoleId 
 && objQxRolePotenceRelaEN.PotenceId == strPotenceId 
)
{
return objQxRolePotenceRelaEN;
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
 string strRoleId;
 try
 {
 strRoleId = new clsQxRolePotenceRelaDA().GetFirstID(strWhereCond);
 return strRoleId;
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
 arrList = QxRolePotenceRelaDA.GetID(strWhereCond);
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
bool bolIsExist = QxRolePotenceRelaDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strRoleId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strRoleId,string strPotenceId)
{
//检测记录是否存在
bool bolIsExist = QxRolePotenceRelaDA.IsExist(strRoleId,strPotenceId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strRoleId">角色Id</param>
/// <param name = "strPotenceId">权限ID</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strRoleId , string strPotenceId, string strOpUser)
{
clsQxRolePotenceRelaEN objQxRolePotenceRelaEN = clsQxRolePotenceRelaBL.GetObjByKeyLst(strRoleId,strPotenceId);
objQxRolePotenceRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objQxRolePotenceRelaEN.UpdUser = strOpUser;
return clsQxRolePotenceRelaBL.UpdateBySql2(objQxRolePotenceRelaEN);
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
 bolIsExist = clsQxRolePotenceRelaDA.IsExistTable();
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
 bolIsExist = QxRolePotenceRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objQxRolePotenceRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsQxRolePotenceRelaEN objQxRolePotenceRelaEN)
{
 if (string.IsNullOrEmpty(objQxRolePotenceRelaEN.RoleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQxRolePotenceRelaBL.IsExist(objQxRolePotenceRelaEN.RoleId,objQxRolePotenceRelaEN.PotenceId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQxRolePotenceRelaEN.RoleId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = QxRolePotenceRelaDA.AddNewRecordBySQL2(objQxRolePotenceRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRolePotenceRelaBL.ReFreshCache();

if (clsQxRolePotenceRelaBL.relatedActions != null)
{
clsQxRolePotenceRelaBL.relatedActions.UpdRelaTabDate(objQxRolePotenceRelaEN.RoleId,objQxRolePotenceRelaEN.PotenceId, objQxRolePotenceRelaEN.UpdUser);
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
 /// <param name = "objQxRolePotenceRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsQxRolePotenceRelaEN objQxRolePotenceRelaEN)
{
 if (string.IsNullOrEmpty(objQxRolePotenceRelaEN.RoleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQxRolePotenceRelaBL.IsExist(objQxRolePotenceRelaEN.RoleId,objQxRolePotenceRelaEN.PotenceId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQxRolePotenceRelaEN.RoleId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = QxRolePotenceRelaDA.AddNewRecordBySQL2WithReturnKey(objQxRolePotenceRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRolePotenceRelaBL.ReFreshCache();

if (clsQxRolePotenceRelaBL.relatedActions != null)
{
clsQxRolePotenceRelaBL.relatedActions.UpdRelaTabDate(objQxRolePotenceRelaEN.RoleId,objQxRolePotenceRelaEN.PotenceId, objQxRolePotenceRelaEN.UpdUser);
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
 /// <param name = "strQxRolePotenceRelaObjXml">代表实体对象的XML串</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql_XML(string strQxRolePotenceRelaObjXml)
{
clsQxRolePotenceRelaEN objQxRolePotenceRelaEN = GetObjFromXmlStr(strQxRolePotenceRelaObjXml);
try
{
bool bolResult = QxRolePotenceRelaDA.AddNewRecordBySQL2(objQxRolePotenceRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRolePotenceRelaBL.ReFreshCache();

if (clsQxRolePotenceRelaBL.relatedActions != null)
{
clsQxRolePotenceRelaBL.relatedActions.UpdRelaTabDate(objQxRolePotenceRelaEN.RoleId,objQxRolePotenceRelaEN.PotenceId, objQxRolePotenceRelaEN.UpdUser);
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
 /// <param name = "objQxRolePotenceRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsQxRolePotenceRelaEN objQxRolePotenceRelaEN)
{
try
{
bool bolResult = QxRolePotenceRelaDA.Update(objQxRolePotenceRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRolePotenceRelaBL.ReFreshCache();

if (clsQxRolePotenceRelaBL.relatedActions != null)
{
clsQxRolePotenceRelaBL.relatedActions.UpdRelaTabDate(objQxRolePotenceRelaEN.RoleId,objQxRolePotenceRelaEN.PotenceId, objQxRolePotenceRelaEN.UpdUser);
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
 /// <param name = "objQxRolePotenceRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsQxRolePotenceRelaEN objQxRolePotenceRelaEN)
{
 if (string.IsNullOrEmpty(objQxRolePotenceRelaEN.RoleId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = QxRolePotenceRelaDA.UpdateBySql2(objQxRolePotenceRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRolePotenceRelaBL.ReFreshCache();

if (clsQxRolePotenceRelaBL.relatedActions != null)
{
clsQxRolePotenceRelaBL.relatedActions.UpdRelaTabDate(objQxRolePotenceRelaEN.RoleId,objQxRolePotenceRelaEN.PotenceId, objQxRolePotenceRelaEN.UpdUser);
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
 /// <param name = "strQxRolePotenceRelaObjXml">需要修改的对象,用XML来表示</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql_XML(string strQxRolePotenceRelaObjXml)
{
clsQxRolePotenceRelaEN objQxRolePotenceRelaEN = GetObjFromXmlStr(strQxRolePotenceRelaObjXml);
try
{
bool bolResult = QxRolePotenceRelaDA.UpdateBySql2(objQxRolePotenceRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRolePotenceRelaBL.ReFreshCache();

if (clsQxRolePotenceRelaBL.relatedActions != null)
{
clsQxRolePotenceRelaBL.relatedActions.UpdRelaTabDate(objQxRolePotenceRelaEN.RoleId,objQxRolePotenceRelaEN.PotenceId, objQxRolePotenceRelaEN.UpdUser);
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
 /// <param name = "strRoleId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strRoleId,string strPotenceId)
{
try
{
 clsQxRolePotenceRelaEN objQxRolePotenceRelaEN = clsQxRolePotenceRelaBL.GetObjByKeyLst(strRoleId,strPotenceId);

if (clsQxRolePotenceRelaBL.relatedActions != null)
{
clsQxRolePotenceRelaBL.relatedActions.UpdRelaTabDate(objQxRolePotenceRelaEN.RoleId,objQxRolePotenceRelaEN.PotenceId, objQxRolePotenceRelaEN.UpdUser);
}
if (objQxRolePotenceRelaEN != null)
{
int intRecNum = QxRolePotenceRelaDA.DelRecord(strRoleId,strPotenceId);
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
/// <param name="strRoleId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strRoleId,string strPotenceId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxRolePotenceRelaDA.GetSpecSQLObj();
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
//删除与表:[QxRolePotenceRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conQxRolePotenceRela.RoleId,
//strRoleId);
//        clsQxRolePotenceRelaBL.DelQxRolePotenceRelasByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxRolePotenceRelaBL.DelRecord(strRoleId,strPotenceId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxRolePotenceRelaBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strRoleId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strRoleId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strRoleId,string strPotenceId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsQxRolePotenceRelaBL.relatedActions != null)
{
clsQxRolePotenceRelaBL.relatedActions.UpdRelaTabDate(strRoleId,strPotenceId, "UpdRelaTabDate");
}
bool bolResult = QxRolePotenceRelaDA.DelRecord(strRoleId,strPotenceId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "strRoleId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strRoleId,string strPotenceId) 
{
try
{
if (clsQxRolePotenceRelaBL.relatedActions != null)
{
clsQxRolePotenceRelaBL.relatedActions.UpdRelaTabDate(strRoleId,strPotenceId, "UpdRelaTabDate");
}
bool bolResult = QxRolePotenceRelaDA.DelRecordBySP(strRoleId,strPotenceId);
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
 /// <param name = "arrRoleIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecKeyLsts(List<string> arrKeyLsts)
{
if (arrKeyLsts.Count == 0) return 0;
try
{
string[] sstrKey;
string strRoleId;
string strPotenceId;
if (clsQxRolePotenceRelaBL.relatedActions != null)
{
foreach (var strKeyLst in arrKeyLsts)
{
sstrKey = strKeyLst.Split('|');
strRoleId = sstrKey[0];
strPotenceId = sstrKey[1];
clsQxRolePotenceRelaBL.relatedActions.UpdRelaTabDate(strRoleId,strPotenceId, "UpdRelaTabDate");
}
}
sstrKey = arrKeyLsts[0].Split('|');
strRoleId = sstrKey[0];
strPotenceId = sstrKey[1];
int intDelRecNum = QxRolePotenceRelaDA.DelRecKeyLsts(arrKeyLsts);
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
public static int DelQxRolePotenceRelasByCond(string strWhereCond)
{
try
{
int intRecNum = QxRolePotenceRelaDA.DelQxRolePotenceRela(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[QxRolePotenceRela]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strRoleId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strRoleId,string strPotenceId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxRolePotenceRelaDA.GetSpecSQLObj();
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
//删除与表:[QxRolePotenceRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxRolePotenceRelaBL.DelRecord(strRoleId,strPotenceId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxRolePotenceRelaBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strRoleId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objQxRolePotenceRelaENS">源对象</param>
 /// <param name = "objQxRolePotenceRelaENT">目标对象</param>
 public static void CopyTo(clsQxRolePotenceRelaEN objQxRolePotenceRelaENS, clsQxRolePotenceRelaEN objQxRolePotenceRelaENT)
{
try
{
objQxRolePotenceRelaENT.RoleId = objQxRolePotenceRelaENS.RoleId; //角色Id
objQxRolePotenceRelaENT.PotenceId = objQxRolePotenceRelaENS.PotenceId; //权限ID
objQxRolePotenceRelaENT.QxPrjId = objQxRolePotenceRelaENS.QxPrjId; //项目Id
objQxRolePotenceRelaENT.UpdDate = objQxRolePotenceRelaENS.UpdDate; //修改日期
objQxRolePotenceRelaENT.UpdUser = objQxRolePotenceRelaENS.UpdUser; //修改用户
objQxRolePotenceRelaENT.Memo = objQxRolePotenceRelaENS.Memo; //备注
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
 /// <param name = "objQxRolePotenceRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsQxRolePotenceRelaEN objQxRolePotenceRelaEN)
{
try
{
objQxRolePotenceRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objQxRolePotenceRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conQxRolePotenceRela.RoleId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxRolePotenceRelaEN.RoleId = objQxRolePotenceRelaEN.RoleId; //角色Id
}
if (arrFldSet.Contains(conQxRolePotenceRela.PotenceId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxRolePotenceRelaEN.PotenceId = objQxRolePotenceRelaEN.PotenceId; //权限ID
}
if (arrFldSet.Contains(conQxRolePotenceRela.QxPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxRolePotenceRelaEN.QxPrjId = objQxRolePotenceRelaEN.QxPrjId; //项目Id
}
if (arrFldSet.Contains(conQxRolePotenceRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objQxRolePotenceRelaEN.UpdDate = objQxRolePotenceRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conQxRolePotenceRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objQxRolePotenceRelaEN.UpdUser = objQxRolePotenceRelaEN.UpdUser; //修改用户
}
if (arrFldSet.Contains(conQxRolePotenceRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objQxRolePotenceRelaEN.Memo = objQxRolePotenceRelaEN.Memo == "[null]" ? null :  objQxRolePotenceRelaEN.Memo; //备注
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
 /// <param name = "objQxRolePotenceRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsQxRolePotenceRelaEN objQxRolePotenceRelaEN)
{
try
{
if (objQxRolePotenceRelaEN.Memo == "[null]") objQxRolePotenceRelaEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsQxRolePotenceRelaEN objQxRolePotenceRelaEN)
{
 QxRolePotenceRelaDA.CheckPropertyNew(objQxRolePotenceRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsQxRolePotenceRelaEN objQxRolePotenceRelaEN)
{
 QxRolePotenceRelaDA.CheckProperty4Condition(objQxRolePotenceRelaEN);
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
if (clsQxRolePotenceRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxRolePotenceRelaBL没有刷新缓存机制(clsQxRolePotenceRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by RoleId");
//if (arrQxRolePotenceRelaObjLstCache == null)
//{
//arrQxRolePotenceRelaObjLstCache = QxRolePotenceRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strRoleId">表关键字</param>
 /// <param name = "strPotenceId">表关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxRolePotenceRelaEN GetObjByKeyLstCache(string strRoleId,string strPotenceId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsQxRolePotenceRelaEN._CurrTabName);
List<clsQxRolePotenceRelaEN> arrQxRolePotenceRelaObjLstCache = GetObjLstCache();
IEnumerable <clsQxRolePotenceRelaEN> arrQxRolePotenceRelaObjLst_Sel =
arrQxRolePotenceRelaObjLstCache
.Where(x=> x.RoleId == strRoleId 
 && x.PotenceId == strPotenceId 
);
if (arrQxRolePotenceRelaObjLst_Sel.Count() == 0)
{
   clsQxRolePotenceRelaEN obj = clsQxRolePotenceRelaBL.GetObjByKeyLst(strRoleId,strPotenceId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrQxRolePotenceRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxRolePotenceRelaEN> GetAllQxRolePotenceRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsQxRolePotenceRelaEN> arrQxRolePotenceRelaObjLstCache = GetObjLstCache(); 
return arrQxRolePotenceRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxRolePotenceRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsQxRolePotenceRelaEN._CurrTabName);
List<clsQxRolePotenceRelaEN> arrQxRolePotenceRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrQxRolePotenceRelaObjLstCache;
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
string strKey = string.Format("{0}", clsQxRolePotenceRelaEN._CurrTabName);
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
if (clsQxRolePotenceRelaBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsQxRolePotenceRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsQxRolePotenceRelaBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2024-03-20
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstQxRolePotenceRelaObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsQxRolePotenceRelaEN> lstQxRolePotenceRelaObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstQxRolePotenceRelaObjLst, writer);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 序列化一个对象列表到XmlWriter
 /// 作者:pyf
 /// 日期:2024-03-20
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXML)
 /// </summary>
 /// <param name = "lstQxRolePotenceRelaObjLst">[clsQxRolePotenceRelaEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsQxRolePotenceRelaEN> lstQxRolePotenceRelaObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsQxRolePotenceRelaBL.listXmlNode);
writer.WriteStartElement(clsQxRolePotenceRelaBL.itemsXmlNode);
foreach (clsQxRolePotenceRelaEN objQxRolePotenceRelaEN in lstQxRolePotenceRelaObjLst)
{
clsQxRolePotenceRelaBL.SerializeXML(writer, objQxRolePotenceRelaEN);
}
writer.WriteEndElement();
writer.WriteEndElement();
return true;
}

 /// <summary>
 /// 把一个对象序列化到XML中
 /// 作者:pyf
 /// 日期:2024-03-20
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeXML)
 /// </summary>
 /// <param name = "writer">目标:序列化到的XmlWriter</param>
 /// <param name = "objQxRolePotenceRelaEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsQxRolePotenceRelaEN objQxRolePotenceRelaEN)
{
writer.WriteStartElement(clsQxRolePotenceRelaBL.itemXmlNode);
 
if (objQxRolePotenceRelaEN.RoleId != null)
{
writer.WriteElementString(conQxRolePotenceRela.RoleId, objQxRolePotenceRelaEN.RoleId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxRolePotenceRelaEN.PotenceId != null)
{
writer.WriteElementString(conQxRolePotenceRela.PotenceId, objQxRolePotenceRelaEN.PotenceId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxRolePotenceRelaEN.QxPrjId != null)
{
writer.WriteElementString(conQxRolePotenceRela.QxPrjId, objQxRolePotenceRelaEN.QxPrjId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxRolePotenceRelaEN.UpdDate != null)
{
writer.WriteElementString(conQxRolePotenceRela.UpdDate, objQxRolePotenceRelaEN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxRolePotenceRelaEN.UpdUser != null)
{
writer.WriteElementString(conQxRolePotenceRela.UpdUser, objQxRolePotenceRelaEN.UpdUser.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxRolePotenceRelaEN.Memo != null)
{
writer.WriteElementString(conQxRolePotenceRela.Memo, objQxRolePotenceRelaEN.Memo.ToString(CultureInfo.InvariantCulture));
}
writer.WriteEndElement();
}

 /// <summary>
 /// 读XmlReader到一个对象
 /// 作者:pyf
 /// 日期:2024-03-20
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlReader)
 /// </summary>
 /// <param name = "reader">提供的数据源:XmlReader</param>
 /// <returns>返回的一个对象</returns>
public static clsQxRolePotenceRelaEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsQxRolePotenceRelaEN objQxRolePotenceRelaEN = new clsQxRolePotenceRelaEN();
reader.Read();
while (!(reader.Name == clsQxRolePotenceRelaBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(conQxRolePotenceRela.RoleId))
{
objQxRolePotenceRelaEN.RoleId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxRolePotenceRela.PotenceId))
{
objQxRolePotenceRelaEN.PotenceId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxRolePotenceRela.QxPrjId))
{
objQxRolePotenceRelaEN.QxPrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxRolePotenceRela.UpdDate))
{
objQxRolePotenceRelaEN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxRolePotenceRela.UpdUser))
{
objQxRolePotenceRelaEN.UpdUser = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxRolePotenceRela.Memo))
{
objQxRolePotenceRelaEN.Memo = reader.ReadElementContentAsString();
}
}
return objQxRolePotenceRelaEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strQxRolePotenceRelaObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsQxRolePotenceRelaEN GetObjFromXmlStr(string strQxRolePotenceRelaObjXmlStr)
{
clsQxRolePotenceRelaEN objQxRolePotenceRelaEN = new clsQxRolePotenceRelaEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strQxRolePotenceRelaObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsQxRolePotenceRelaBL.itemXmlNode))
{
objQxRolePotenceRelaEN = GetObjFromXml(reader);
return objQxRolePotenceRelaEN;
}
}
return objQxRolePotenceRelaEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2024-03-20
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objQxRolePotenceRelaEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsQxRolePotenceRelaEN objQxRolePotenceRelaEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objQxRolePotenceRelaEN);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2024-03-20
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strRoleId,string strPotenceId)
{
if (strInFldName != conQxRolePotenceRela.RoleId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conQxRolePotenceRela.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conQxRolePotenceRela.AttributeName));
throw new Exception(strMsg);
}
var objQxRolePotenceRela = clsQxRolePotenceRelaBL.GetObjByKeyLstCache(strRoleId,strPotenceId);
if (objQxRolePotenceRela == null) return "";
return objQxRolePotenceRela[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2024-03-20
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objQxRolePotenceRelaEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsQxRolePotenceRelaEN objQxRolePotenceRelaEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsQxRolePotenceRelaEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objQxRolePotenceRelaEN[strField]);
}
sbJSON.Remove(sbJSON.Length - 1, 1);
sbJSON.Append("}");
return sbJSON.ToString();
}

 /// <summary>
 /// 序列化一个对象列表到JSON串
 /// 作者:pyf
 /// 日期:2024-03-20
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToJSONStr)
 /// </summary>
 /// <param name = "lstQxRolePotenceRelaObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsQxRolePotenceRelaEN> lstQxRolePotenceRelaObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstQxRolePotenceRelaObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsQxRolePotenceRelaEN objQxRolePotenceRelaEN in lstQxRolePotenceRelaObjLst)
{
string strJSON_One = SerializeObjToJSON(objQxRolePotenceRelaEN);
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
int intRecCount = clsQxRolePotenceRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsQxRolePotenceRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsQxRolePotenceRelaDA.GetRecCount();
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
int intRecCount = clsQxRolePotenceRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objQxRolePotenceRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsQxRolePotenceRelaEN objQxRolePotenceRelaCond)
{
List<clsQxRolePotenceRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxRolePotenceRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxRolePotenceRela.AttributeName)
{
if (objQxRolePotenceRelaCond.IsUpdated(strFldName) == false) continue;
if (objQxRolePotenceRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxRolePotenceRelaCond[strFldName].ToString());
}
else
{
if (objQxRolePotenceRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxRolePotenceRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxRolePotenceRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxRolePotenceRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxRolePotenceRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxRolePotenceRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxRolePotenceRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxRolePotenceRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxRolePotenceRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxRolePotenceRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxRolePotenceRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxRolePotenceRelaCond[strFldName]));
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
 List<string> arrList = clsQxRolePotenceRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = QxRolePotenceRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = QxRolePotenceRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = QxRolePotenceRelaDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxRolePotenceRelaDA.SetFldValue(clsQxRolePotenceRelaEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = QxRolePotenceRelaDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxRolePotenceRelaDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxRolePotenceRelaDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxRolePotenceRelaDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[QxRolePotenceRela] "); 
 strCreateTabCode.Append(" ( "); 
 // /**角色Id*/ 
 strCreateTabCode.Append(" RoleId char(8) primary key, "); 
 // /**权限ID*/ 
 strCreateTabCode.Append(" PotenceId char(8) primary key, "); 
 // /**项目Id*/ 
 strCreateTabCode.Append(" QxPrjId char(4) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) not Null, "); 
 // /**修改用户*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) not Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**角色名称*/ 
 strCreateTabCode.Append(" RoleName varchar(50) Null, "); 
 // /**权限名称*/ 
 strCreateTabCode.Append(" PotenceName varchar(200) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 数据同步


 #endregion 数据同步
}
 /// <summary>
 /// 角色权限关系(QxRolePotenceRela)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4QxRolePotenceRela : clsCommFun4BL
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
clsQxRolePotenceRelaBL.ReFreshThisCache();
}
}

}