
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUserLoginNameBL
 表名:QxUserLoginName(00140051)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 17:45:20
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:用户管理(UserManage_GP)
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
public static class  clsQxUserLoginNameBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strUserLoginName">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxUserLoginNameEN GetObj(this K_UserLoginName_QxUserLoginName myKey)
{
clsQxUserLoginNameEN objQxUserLoginNameEN = clsQxUserLoginNameBL.QxUserLoginNameDA.GetObjByUserLoginName(myKey.Value);
return objQxUserLoginNameEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQxUserLoginNameEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQxUserLoginNameEN objQxUserLoginNameEN)
{
 if (string.IsNullOrEmpty(objQxUserLoginNameEN.UserLoginName) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQxUserLoginNameBL.IsExist(objQxUserLoginNameEN.UserLoginName) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQxUserLoginNameEN.UserLoginName, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsQxUserLoginNameBL.QxUserLoginNameDA.AddNewRecordBySQL2(objQxUserLoginNameEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserLoginNameBL.ReFreshCache();

if (clsQxUserLoginNameBL.relatedActions != null)
{
clsQxUserLoginNameBL.relatedActions.UpdRelaTabDate(objQxUserLoginNameEN.UserLoginName, objQxUserLoginNameEN.UpdUserId);
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
public static bool AddRecordEx(this clsQxUserLoginNameEN objQxUserLoginNameEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsQxUserLoginNameBL.IsExist(objQxUserLoginNameEN.UserLoginName))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objQxUserLoginNameEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objQxUserLoginNameEN.AddNewRecord();
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
 /// <param name = "objQxUserLoginNameEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsQxUserLoginNameEN objQxUserLoginNameEN)
{
 if (string.IsNullOrEmpty(objQxUserLoginNameEN.UserLoginName) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQxUserLoginNameBL.IsExist(objQxUserLoginNameEN.UserLoginName) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQxUserLoginNameEN.UserLoginName, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsQxUserLoginNameBL.QxUserLoginNameDA.AddNewRecordBySQL2WithReturnKey(objQxUserLoginNameEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserLoginNameBL.ReFreshCache();

if (clsQxUserLoginNameBL.relatedActions != null)
{
clsQxUserLoginNameBL.relatedActions.UpdRelaTabDate(objQxUserLoginNameEN.UserLoginName, objQxUserLoginNameEN.UpdUserId);
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
 /// <param name = "objQxUserLoginNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserLoginNameEN SetUserLoginName(this clsQxUserLoginNameEN objQxUserLoginNameEN, string strUserLoginName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserLoginName, 30, conQxUserLoginName.UserLoginName);
}
objQxUserLoginNameEN.UserLoginName = strUserLoginName; //用户登录名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserLoginNameEN.dicFldComparisonOp.ContainsKey(conQxUserLoginName.UserLoginName) == false)
{
objQxUserLoginNameEN.dicFldComparisonOp.Add(conQxUserLoginName.UserLoginName, strComparisonOp);
}
else
{
objQxUserLoginNameEN.dicFldComparisonOp[conQxUserLoginName.UserLoginName] = strComparisonOp;
}
}
return objQxUserLoginNameEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserLoginNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserLoginNameEN SetUserId(this clsQxUserLoginNameEN objQxUserLoginNameEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, conQxUserLoginName.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conQxUserLoginName.UserId);
}
objQxUserLoginNameEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserLoginNameEN.dicFldComparisonOp.ContainsKey(conQxUserLoginName.UserId) == false)
{
objQxUserLoginNameEN.dicFldComparisonOp.Add(conQxUserLoginName.UserId, strComparisonOp);
}
else
{
objQxUserLoginNameEN.dicFldComparisonOp[conQxUserLoginName.UserId] = strComparisonOp;
}
}
return objQxUserLoginNameEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserLoginNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserLoginNameEN SetUpdUserId(this clsQxUserLoginNameEN objQxUserLoginNameEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUserId, conQxUserLoginName.UpdUserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conQxUserLoginName.UpdUserId);
}
objQxUserLoginNameEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserLoginNameEN.dicFldComparisonOp.ContainsKey(conQxUserLoginName.UpdUserId) == false)
{
objQxUserLoginNameEN.dicFldComparisonOp.Add(conQxUserLoginName.UpdUserId, strComparisonOp);
}
else
{
objQxUserLoginNameEN.dicFldComparisonOp[conQxUserLoginName.UpdUserId] = strComparisonOp;
}
}
return objQxUserLoginNameEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserLoginNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserLoginNameEN SetUpdDate(this clsQxUserLoginNameEN objQxUserLoginNameEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQxUserLoginName.UpdDate);
}
objQxUserLoginNameEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserLoginNameEN.dicFldComparisonOp.ContainsKey(conQxUserLoginName.UpdDate) == false)
{
objQxUserLoginNameEN.dicFldComparisonOp.Add(conQxUserLoginName.UpdDate, strComparisonOp);
}
else
{
objQxUserLoginNameEN.dicFldComparisonOp[conQxUserLoginName.UpdDate] = strComparisonOp;
}
}
return objQxUserLoginNameEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserLoginNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserLoginNameEN SetUpdTime(this clsQxUserLoginNameEN objQxUserLoginNameEN, string strUpdTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdTime, 6, conQxUserLoginName.UpdTime);
}
objQxUserLoginNameEN.UpdTime = strUpdTime; //修改时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserLoginNameEN.dicFldComparisonOp.ContainsKey(conQxUserLoginName.UpdTime) == false)
{
objQxUserLoginNameEN.dicFldComparisonOp.Add(conQxUserLoginName.UpdTime, strComparisonOp);
}
else
{
objQxUserLoginNameEN.dicFldComparisonOp[conQxUserLoginName.UpdTime] = strComparisonOp;
}
}
return objQxUserLoginNameEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserLoginNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserLoginNameEN SetMemo(this clsQxUserLoginNameEN objQxUserLoginNameEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQxUserLoginName.Memo);
}
objQxUserLoginNameEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserLoginNameEN.dicFldComparisonOp.ContainsKey(conQxUserLoginName.Memo) == false)
{
objQxUserLoginNameEN.dicFldComparisonOp.Add(conQxUserLoginName.Memo, strComparisonOp);
}
else
{
objQxUserLoginNameEN.dicFldComparisonOp[conQxUserLoginName.Memo] = strComparisonOp;
}
}
return objQxUserLoginNameEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objQxUserLoginNameEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsQxUserLoginNameEN objQxUserLoginNameEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objQxUserLoginNameEN.CheckPropertyNew();
clsQxUserLoginNameEN objQxUserLoginNameCond = new clsQxUserLoginNameEN();
string strCondition = objQxUserLoginNameCond
.SetUserLoginName(objQxUserLoginNameEN.UserLoginName, "=")
.GetCombineCondition();
objQxUserLoginNameEN._IsCheckProperty = true;
bool bolIsExist = clsQxUserLoginNameBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objQxUserLoginNameEN.Update();
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
 /// <param name = "objQxUserLoginNameEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxUserLoginNameEN objQxUserLoginNameEN)
{
 if (string.IsNullOrEmpty(objQxUserLoginNameEN.UserLoginName) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxUserLoginNameBL.QxUserLoginNameDA.UpdateBySql2(objQxUserLoginNameEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserLoginNameBL.ReFreshCache();

if (clsQxUserLoginNameBL.relatedActions != null)
{
clsQxUserLoginNameBL.relatedActions.UpdRelaTabDate(objQxUserLoginNameEN.UserLoginName, objQxUserLoginNameEN.UpdUserId);
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
 /// <param name = "objQxUserLoginNameEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxUserLoginNameEN objQxUserLoginNameEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objQxUserLoginNameEN.UserLoginName) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxUserLoginNameBL.QxUserLoginNameDA.UpdateBySql2(objQxUserLoginNameEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserLoginNameBL.ReFreshCache();

if (clsQxUserLoginNameBL.relatedActions != null)
{
clsQxUserLoginNameBL.relatedActions.UpdRelaTabDate(objQxUserLoginNameEN.UserLoginName, objQxUserLoginNameEN.UpdUserId);
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
 /// <param name = "objQxUserLoginNameEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxUserLoginNameEN objQxUserLoginNameEN, string strWhereCond)
{
try
{
bool bolResult = clsQxUserLoginNameBL.QxUserLoginNameDA.UpdateBySqlWithCondition(objQxUserLoginNameEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserLoginNameBL.ReFreshCache();

if (clsQxUserLoginNameBL.relatedActions != null)
{
clsQxUserLoginNameBL.relatedActions.UpdRelaTabDate(objQxUserLoginNameEN.UserLoginName, objQxUserLoginNameEN.UpdUserId);
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
 /// <param name = "objQxUserLoginNameEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxUserLoginNameEN objQxUserLoginNameEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsQxUserLoginNameBL.QxUserLoginNameDA.UpdateBySqlWithConditionTransaction(objQxUserLoginNameEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserLoginNameBL.ReFreshCache();

if (clsQxUserLoginNameBL.relatedActions != null)
{
clsQxUserLoginNameBL.relatedActions.UpdRelaTabDate(objQxUserLoginNameEN.UserLoginName, objQxUserLoginNameEN.UpdUserId);
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
 /// <param name = "strUserLoginName">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsQxUserLoginNameEN objQxUserLoginNameEN)
{
try
{
int intRecNum = clsQxUserLoginNameBL.QxUserLoginNameDA.DelRecord(objQxUserLoginNameEN.UserLoginName);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserLoginNameBL.ReFreshCache();

if (clsQxUserLoginNameBL.relatedActions != null)
{
clsQxUserLoginNameBL.relatedActions.UpdRelaTabDate(objQxUserLoginNameEN.UserLoginName, objQxUserLoginNameEN.UpdUserId);
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
 /// <param name = "objQxUserLoginNameENS">源对象</param>
 /// <param name = "objQxUserLoginNameENT">目标对象</param>
 public static void CopyTo(this clsQxUserLoginNameEN objQxUserLoginNameENS, clsQxUserLoginNameEN objQxUserLoginNameENT)
{
try
{
objQxUserLoginNameENT.UserLoginName = objQxUserLoginNameENS.UserLoginName; //用户登录名
objQxUserLoginNameENT.UserId = objQxUserLoginNameENS.UserId; //用户ID
objQxUserLoginNameENT.UpdUserId = objQxUserLoginNameENS.UpdUserId; //修改用户Id
objQxUserLoginNameENT.UpdDate = objQxUserLoginNameENS.UpdDate; //修改日期
objQxUserLoginNameENT.UpdTime = objQxUserLoginNameENS.UpdTime; //修改时间
objQxUserLoginNameENT.Memo = objQxUserLoginNameENS.Memo; //备注
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
 /// <param name = "objQxUserLoginNameENS">源对象</param>
 /// <returns>目标对象=>clsQxUserLoginNameEN:objQxUserLoginNameENT</returns>
 public static clsQxUserLoginNameEN CopyTo(this clsQxUserLoginNameEN objQxUserLoginNameENS)
{
try
{
 clsQxUserLoginNameEN objQxUserLoginNameENT = new clsQxUserLoginNameEN()
{
UserLoginName = objQxUserLoginNameENS.UserLoginName, //用户登录名
UserId = objQxUserLoginNameENS.UserId, //用户ID
UpdUserId = objQxUserLoginNameENS.UpdUserId, //修改用户Id
UpdDate = objQxUserLoginNameENS.UpdDate, //修改日期
UpdTime = objQxUserLoginNameENS.UpdTime, //修改时间
Memo = objQxUserLoginNameENS.Memo, //备注
};
 return objQxUserLoginNameENT;
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
public static void CheckPropertyNew(this clsQxUserLoginNameEN objQxUserLoginNameEN)
{
 clsQxUserLoginNameBL.QxUserLoginNameDA.CheckPropertyNew(objQxUserLoginNameEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsQxUserLoginNameEN objQxUserLoginNameEN)
{
 clsQxUserLoginNameBL.QxUserLoginNameDA.CheckProperty4Condition(objQxUserLoginNameEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQxUserLoginNameEN objQxUserLoginNameCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQxUserLoginNameCond.IsUpdated(conQxUserLoginName.UserLoginName) == true)
{
string strComparisonOpUserLoginName = objQxUserLoginNameCond.dicFldComparisonOp[conQxUserLoginName.UserLoginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserLoginName.UserLoginName, objQxUserLoginNameCond.UserLoginName, strComparisonOpUserLoginName);
}
if (objQxUserLoginNameCond.IsUpdated(conQxUserLoginName.UserId) == true)
{
string strComparisonOpUserId = objQxUserLoginNameCond.dicFldComparisonOp[conQxUserLoginName.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserLoginName.UserId, objQxUserLoginNameCond.UserId, strComparisonOpUserId);
}
if (objQxUserLoginNameCond.IsUpdated(conQxUserLoginName.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objQxUserLoginNameCond.dicFldComparisonOp[conQxUserLoginName.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserLoginName.UpdUserId, objQxUserLoginNameCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objQxUserLoginNameCond.IsUpdated(conQxUserLoginName.UpdDate) == true)
{
string strComparisonOpUpdDate = objQxUserLoginNameCond.dicFldComparisonOp[conQxUserLoginName.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserLoginName.UpdDate, objQxUserLoginNameCond.UpdDate, strComparisonOpUpdDate);
}
if (objQxUserLoginNameCond.IsUpdated(conQxUserLoginName.UpdTime) == true)
{
string strComparisonOpUpdTime = objQxUserLoginNameCond.dicFldComparisonOp[conQxUserLoginName.UpdTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserLoginName.UpdTime, objQxUserLoginNameCond.UpdTime, strComparisonOpUpdTime);
}
if (objQxUserLoginNameCond.IsUpdated(conQxUserLoginName.Memo) == true)
{
string strComparisonOpMemo = objQxUserLoginNameCond.dicFldComparisonOp[conQxUserLoginName.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserLoginName.Memo, objQxUserLoginNameCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_QxUserLoginName
{
public virtual bool UpdRelaTabDate(string strUserLoginName, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 用户登录名(QxUserLoginName)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsQxUserLoginNameBL
{
public static RelatedActions_QxUserLoginName relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "QxUserLoginNameListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "QxUserLoginNameList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsQxUserLoginNameEN> arrQxUserLoginNameObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsQxUserLoginNameDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsQxUserLoginNameDA QxUserLoginNameDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsQxUserLoginNameDA();
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
 public clsQxUserLoginNameBL()
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
if (string.IsNullOrEmpty(clsQxUserLoginNameEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxUserLoginNameEN._ConnectString);
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
objDS = QxUserLoginNameDA.GetDataSet(strWhereCond);
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
objDS = QxUserLoginNameDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = QxUserLoginNameDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_QxUserLoginName(string strWhereCond)
{
DataTable objDT;
try
{
objDT = QxUserLoginNameDA.GetDataTable_QxUserLoginName(strWhereCond);
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
objDT = QxUserLoginNameDA.GetDataTable(strWhereCond);
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
objDT = QxUserLoginNameDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = QxUserLoginNameDA.GetDataTable(strWhereCond, strTabName);
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
objDT = QxUserLoginNameDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = QxUserLoginNameDA.GetDataTable_Top(objTopPara);
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
objDT = QxUserLoginNameDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = QxUserLoginNameDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = QxUserLoginNameDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = QxUserLoginNameDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = QxUserLoginNameDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = QxUserLoginNameDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = QxUserLoginNameDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = QxUserLoginNameDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
 /// <param name = "arrUserLoginNameLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsQxUserLoginNameEN> GetObjLstByUserLoginNameLst(List<string> arrUserLoginNameLst)
{
List<clsQxUserLoginNameEN> arrObjLst = new List<clsQxUserLoginNameEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrUserLoginNameLst, true);
 string strWhereCond = string.Format("UserLoginName in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserLoginNameEN objQxUserLoginNameEN = new clsQxUserLoginNameEN();
try
{
objQxUserLoginNameEN.UserLoginName = objRow[conQxUserLoginName.UserLoginName].ToString().Trim(); //用户登录名
objQxUserLoginNameEN.UserId = objRow[conQxUserLoginName.UserId].ToString().Trim(); //用户ID
objQxUserLoginNameEN.UpdUserId = objRow[conQxUserLoginName.UpdUserId].ToString().Trim(); //修改用户Id
objQxUserLoginNameEN.UpdDate = objRow[conQxUserLoginName.UpdDate] == DBNull.Value ? null : objRow[conQxUserLoginName.UpdDate].ToString().Trim(); //修改日期
objQxUserLoginNameEN.UpdTime = objRow[conQxUserLoginName.UpdTime] == DBNull.Value ? null : objRow[conQxUserLoginName.UpdTime].ToString().Trim(); //修改时间
objQxUserLoginNameEN.Memo = objRow[conQxUserLoginName.Memo] == DBNull.Value ? null : objRow[conQxUserLoginName.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserLoginNameEN.UserLoginName, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserLoginNameEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrUserLoginNameLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsQxUserLoginNameEN> GetObjLstByUserLoginNameLstCache(List<string> arrUserLoginNameLst)
{
string strKey = string.Format("{0}", clsQxUserLoginNameEN._CurrTabName);
List<clsQxUserLoginNameEN> arrQxUserLoginNameObjLstCache = GetObjLstCache();
IEnumerable <clsQxUserLoginNameEN> arrQxUserLoginNameObjLst_Sel =
arrQxUserLoginNameObjLstCache
.Where(x => arrUserLoginNameLst.Contains(x.UserLoginName));
return arrQxUserLoginNameObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUserLoginNameEN> GetObjLst(string strWhereCond)
{
List<clsQxUserLoginNameEN> arrObjLst = new List<clsQxUserLoginNameEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserLoginNameEN objQxUserLoginNameEN = new clsQxUserLoginNameEN();
try
{
objQxUserLoginNameEN.UserLoginName = objRow[conQxUserLoginName.UserLoginName].ToString().Trim(); //用户登录名
objQxUserLoginNameEN.UserId = objRow[conQxUserLoginName.UserId].ToString().Trim(); //用户ID
objQxUserLoginNameEN.UpdUserId = objRow[conQxUserLoginName.UpdUserId].ToString().Trim(); //修改用户Id
objQxUserLoginNameEN.UpdDate = objRow[conQxUserLoginName.UpdDate] == DBNull.Value ? null : objRow[conQxUserLoginName.UpdDate].ToString().Trim(); //修改日期
objQxUserLoginNameEN.UpdTime = objRow[conQxUserLoginName.UpdTime] == DBNull.Value ? null : objRow[conQxUserLoginName.UpdTime].ToString().Trim(); //修改时间
objQxUserLoginNameEN.Memo = objRow[conQxUserLoginName.Memo] == DBNull.Value ? null : objRow[conQxUserLoginName.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserLoginNameEN.UserLoginName, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserLoginNameEN);
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
public static List<clsQxUserLoginNameEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsQxUserLoginNameEN> arrObjLst = new List<clsQxUserLoginNameEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserLoginNameEN objQxUserLoginNameEN = new clsQxUserLoginNameEN();
try
{
objQxUserLoginNameEN.UserLoginName = objRow[conQxUserLoginName.UserLoginName].ToString().Trim(); //用户登录名
objQxUserLoginNameEN.UserId = objRow[conQxUserLoginName.UserId].ToString().Trim(); //用户ID
objQxUserLoginNameEN.UpdUserId = objRow[conQxUserLoginName.UpdUserId].ToString().Trim(); //修改用户Id
objQxUserLoginNameEN.UpdDate = objRow[conQxUserLoginName.UpdDate] == DBNull.Value ? null : objRow[conQxUserLoginName.UpdDate].ToString().Trim(); //修改日期
objQxUserLoginNameEN.UpdTime = objRow[conQxUserLoginName.UpdTime] == DBNull.Value ? null : objRow[conQxUserLoginName.UpdTime].ToString().Trim(); //修改时间
objQxUserLoginNameEN.Memo = objRow[conQxUserLoginName.Memo] == DBNull.Value ? null : objRow[conQxUserLoginName.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserLoginNameEN.UserLoginName, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserLoginNameEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objQxUserLoginNameCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsQxUserLoginNameEN> GetSubObjLstCache(clsQxUserLoginNameEN objQxUserLoginNameCond)
{
List<clsQxUserLoginNameEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxUserLoginNameEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxUserLoginName.AttributeName)
{
if (objQxUserLoginNameCond.IsUpdated(strFldName) == false) continue;
if (objQxUserLoginNameCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUserLoginNameCond[strFldName].ToString());
}
else
{
if (objQxUserLoginNameCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxUserLoginNameCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUserLoginNameCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxUserLoginNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxUserLoginNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxUserLoginNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxUserLoginNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxUserLoginNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxUserLoginNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxUserLoginNameCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxUserLoginNameCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxUserLoginNameCond[strFldName]));
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
public static List<clsQxUserLoginNameEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsQxUserLoginNameEN> arrObjLst = new List<clsQxUserLoginNameEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserLoginNameEN objQxUserLoginNameEN = new clsQxUserLoginNameEN();
try
{
objQxUserLoginNameEN.UserLoginName = objRow[conQxUserLoginName.UserLoginName].ToString().Trim(); //用户登录名
objQxUserLoginNameEN.UserId = objRow[conQxUserLoginName.UserId].ToString().Trim(); //用户ID
objQxUserLoginNameEN.UpdUserId = objRow[conQxUserLoginName.UpdUserId].ToString().Trim(); //修改用户Id
objQxUserLoginNameEN.UpdDate = objRow[conQxUserLoginName.UpdDate] == DBNull.Value ? null : objRow[conQxUserLoginName.UpdDate].ToString().Trim(); //修改日期
objQxUserLoginNameEN.UpdTime = objRow[conQxUserLoginName.UpdTime] == DBNull.Value ? null : objRow[conQxUserLoginName.UpdTime].ToString().Trim(); //修改时间
objQxUserLoginNameEN.Memo = objRow[conQxUserLoginName.Memo] == DBNull.Value ? null : objRow[conQxUserLoginName.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserLoginNameEN.UserLoginName, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserLoginNameEN);
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
public static List<clsQxUserLoginNameEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsQxUserLoginNameEN> arrObjLst = new List<clsQxUserLoginNameEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserLoginNameEN objQxUserLoginNameEN = new clsQxUserLoginNameEN();
try
{
objQxUserLoginNameEN.UserLoginName = objRow[conQxUserLoginName.UserLoginName].ToString().Trim(); //用户登录名
objQxUserLoginNameEN.UserId = objRow[conQxUserLoginName.UserId].ToString().Trim(); //用户ID
objQxUserLoginNameEN.UpdUserId = objRow[conQxUserLoginName.UpdUserId].ToString().Trim(); //修改用户Id
objQxUserLoginNameEN.UpdDate = objRow[conQxUserLoginName.UpdDate] == DBNull.Value ? null : objRow[conQxUserLoginName.UpdDate].ToString().Trim(); //修改日期
objQxUserLoginNameEN.UpdTime = objRow[conQxUserLoginName.UpdTime] == DBNull.Value ? null : objRow[conQxUserLoginName.UpdTime].ToString().Trim(); //修改时间
objQxUserLoginNameEN.Memo = objRow[conQxUserLoginName.Memo] == DBNull.Value ? null : objRow[conQxUserLoginName.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserLoginNameEN.UserLoginName, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserLoginNameEN);
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
List<clsQxUserLoginNameEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsQxUserLoginNameEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUserLoginNameEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsQxUserLoginNameEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsQxUserLoginNameEN> arrObjLst = new List<clsQxUserLoginNameEN>(); 
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
	clsQxUserLoginNameEN objQxUserLoginNameEN = new clsQxUserLoginNameEN();
try
{
objQxUserLoginNameEN.UserLoginName = objRow[conQxUserLoginName.UserLoginName].ToString().Trim(); //用户登录名
objQxUserLoginNameEN.UserId = objRow[conQxUserLoginName.UserId].ToString().Trim(); //用户ID
objQxUserLoginNameEN.UpdUserId = objRow[conQxUserLoginName.UpdUserId].ToString().Trim(); //修改用户Id
objQxUserLoginNameEN.UpdDate = objRow[conQxUserLoginName.UpdDate] == DBNull.Value ? null : objRow[conQxUserLoginName.UpdDate].ToString().Trim(); //修改日期
objQxUserLoginNameEN.UpdTime = objRow[conQxUserLoginName.UpdTime] == DBNull.Value ? null : objRow[conQxUserLoginName.UpdTime].ToString().Trim(); //修改时间
objQxUserLoginNameEN.Memo = objRow[conQxUserLoginName.Memo] == DBNull.Value ? null : objRow[conQxUserLoginName.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserLoginNameEN.UserLoginName, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserLoginNameEN);
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
public static List<clsQxUserLoginNameEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsQxUserLoginNameEN> arrObjLst = new List<clsQxUserLoginNameEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserLoginNameEN objQxUserLoginNameEN = new clsQxUserLoginNameEN();
try
{
objQxUserLoginNameEN.UserLoginName = objRow[conQxUserLoginName.UserLoginName].ToString().Trim(); //用户登录名
objQxUserLoginNameEN.UserId = objRow[conQxUserLoginName.UserId].ToString().Trim(); //用户ID
objQxUserLoginNameEN.UpdUserId = objRow[conQxUserLoginName.UpdUserId].ToString().Trim(); //修改用户Id
objQxUserLoginNameEN.UpdDate = objRow[conQxUserLoginName.UpdDate] == DBNull.Value ? null : objRow[conQxUserLoginName.UpdDate].ToString().Trim(); //修改日期
objQxUserLoginNameEN.UpdTime = objRow[conQxUserLoginName.UpdTime] == DBNull.Value ? null : objRow[conQxUserLoginName.UpdTime].ToString().Trim(); //修改时间
objQxUserLoginNameEN.Memo = objRow[conQxUserLoginName.Memo] == DBNull.Value ? null : objRow[conQxUserLoginName.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserLoginNameEN.UserLoginName, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserLoginNameEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsQxUserLoginNameEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsQxUserLoginNameEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsQxUserLoginNameEN> arrObjLst = new List<clsQxUserLoginNameEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserLoginNameEN objQxUserLoginNameEN = new clsQxUserLoginNameEN();
try
{
objQxUserLoginNameEN.UserLoginName = objRow[conQxUserLoginName.UserLoginName].ToString().Trim(); //用户登录名
objQxUserLoginNameEN.UserId = objRow[conQxUserLoginName.UserId].ToString().Trim(); //用户ID
objQxUserLoginNameEN.UpdUserId = objRow[conQxUserLoginName.UpdUserId].ToString().Trim(); //修改用户Id
objQxUserLoginNameEN.UpdDate = objRow[conQxUserLoginName.UpdDate] == DBNull.Value ? null : objRow[conQxUserLoginName.UpdDate].ToString().Trim(); //修改日期
objQxUserLoginNameEN.UpdTime = objRow[conQxUserLoginName.UpdTime] == DBNull.Value ? null : objRow[conQxUserLoginName.UpdTime].ToString().Trim(); //修改时间
objQxUserLoginNameEN.Memo = objRow[conQxUserLoginName.Memo] == DBNull.Value ? null : objRow[conQxUserLoginName.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserLoginNameEN.UserLoginName, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserLoginNameEN);
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
public static List<clsQxUserLoginNameEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsQxUserLoginNameEN> arrObjLst = new List<clsQxUserLoginNameEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserLoginNameEN objQxUserLoginNameEN = new clsQxUserLoginNameEN();
try
{
objQxUserLoginNameEN.UserLoginName = objRow[conQxUserLoginName.UserLoginName].ToString().Trim(); //用户登录名
objQxUserLoginNameEN.UserId = objRow[conQxUserLoginName.UserId].ToString().Trim(); //用户ID
objQxUserLoginNameEN.UpdUserId = objRow[conQxUserLoginName.UpdUserId].ToString().Trim(); //修改用户Id
objQxUserLoginNameEN.UpdDate = objRow[conQxUserLoginName.UpdDate] == DBNull.Value ? null : objRow[conQxUserLoginName.UpdDate].ToString().Trim(); //修改日期
objQxUserLoginNameEN.UpdTime = objRow[conQxUserLoginName.UpdTime] == DBNull.Value ? null : objRow[conQxUserLoginName.UpdTime].ToString().Trim(); //修改时间
objQxUserLoginNameEN.Memo = objRow[conQxUserLoginName.Memo] == DBNull.Value ? null : objRow[conQxUserLoginName.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserLoginNameEN.UserLoginName, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserLoginNameEN);
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
public static IEnumerable<clsQxUserLoginNameEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsQxUserLoginNameEN objQxUserLoginNameCond, string strOrderBy)
{
List<clsQxUserLoginNameEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxUserLoginNameEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxUserLoginName.AttributeName)
{
if (objQxUserLoginNameCond.IsUpdated(strFldName) == false) continue;
if (objQxUserLoginNameCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUserLoginNameCond[strFldName].ToString());
}
else
{
if (objQxUserLoginNameCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxUserLoginNameCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUserLoginNameCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxUserLoginNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxUserLoginNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxUserLoginNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxUserLoginNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxUserLoginNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxUserLoginNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxUserLoginNameCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxUserLoginNameCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxUserLoginNameCond[strFldName]));
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
public static IEnumerable<clsQxUserLoginNameEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsQxUserLoginNameEN objQxUserLoginNameCond = JsonConvert.DeserializeObject<clsQxUserLoginNameEN>(objPagerPara.whereCond);
if (objQxUserLoginNameCond.sfFldComparisonOp == null)
{
objQxUserLoginNameCond.dicFldComparisonOp = null;
}
else
{
objQxUserLoginNameCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objQxUserLoginNameCond.sfFldComparisonOp);
}
clsQxUserLoginNameBL.SetUpdFlag(objQxUserLoginNameCond);
 try
{
CheckProperty4Condition(objQxUserLoginNameCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsQxUserLoginNameBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objQxUserLoginNameCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUserLoginNameEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsQxUserLoginNameEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsQxUserLoginNameEN> arrObjLst = new List<clsQxUserLoginNameEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserLoginNameEN objQxUserLoginNameEN = new clsQxUserLoginNameEN();
try
{
objQxUserLoginNameEN.UserLoginName = objRow[conQxUserLoginName.UserLoginName].ToString().Trim(); //用户登录名
objQxUserLoginNameEN.UserId = objRow[conQxUserLoginName.UserId].ToString().Trim(); //用户ID
objQxUserLoginNameEN.UpdUserId = objRow[conQxUserLoginName.UpdUserId].ToString().Trim(); //修改用户Id
objQxUserLoginNameEN.UpdDate = objRow[conQxUserLoginName.UpdDate] == DBNull.Value ? null : objRow[conQxUserLoginName.UpdDate].ToString().Trim(); //修改日期
objQxUserLoginNameEN.UpdTime = objRow[conQxUserLoginName.UpdTime] == DBNull.Value ? null : objRow[conQxUserLoginName.UpdTime].ToString().Trim(); //修改时间
objQxUserLoginNameEN.Memo = objRow[conQxUserLoginName.Memo] == DBNull.Value ? null : objRow[conQxUserLoginName.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserLoginNameEN.UserLoginName, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserLoginNameEN);
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
public static List<clsQxUserLoginNameEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsQxUserLoginNameEN> arrObjLst = new List<clsQxUserLoginNameEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserLoginNameEN objQxUserLoginNameEN = new clsQxUserLoginNameEN();
try
{
objQxUserLoginNameEN.UserLoginName = objRow[conQxUserLoginName.UserLoginName].ToString().Trim(); //用户登录名
objQxUserLoginNameEN.UserId = objRow[conQxUserLoginName.UserId].ToString().Trim(); //用户ID
objQxUserLoginNameEN.UpdUserId = objRow[conQxUserLoginName.UpdUserId].ToString().Trim(); //修改用户Id
objQxUserLoginNameEN.UpdDate = objRow[conQxUserLoginName.UpdDate] == DBNull.Value ? null : objRow[conQxUserLoginName.UpdDate].ToString().Trim(); //修改日期
objQxUserLoginNameEN.UpdTime = objRow[conQxUserLoginName.UpdTime] == DBNull.Value ? null : objRow[conQxUserLoginName.UpdTime].ToString().Trim(); //修改时间
objQxUserLoginNameEN.Memo = objRow[conQxUserLoginName.Memo] == DBNull.Value ? null : objRow[conQxUserLoginName.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserLoginNameEN.UserLoginName, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserLoginNameEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUserLoginNameEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsQxUserLoginNameEN> arrObjLst = new List<clsQxUserLoginNameEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserLoginNameEN objQxUserLoginNameEN = new clsQxUserLoginNameEN();
try
{
objQxUserLoginNameEN.UserLoginName = objRow[conQxUserLoginName.UserLoginName].ToString().Trim(); //用户登录名
objQxUserLoginNameEN.UserId = objRow[conQxUserLoginName.UserId].ToString().Trim(); //用户ID
objQxUserLoginNameEN.UpdUserId = objRow[conQxUserLoginName.UpdUserId].ToString().Trim(); //修改用户Id
objQxUserLoginNameEN.UpdDate = objRow[conQxUserLoginName.UpdDate] == DBNull.Value ? null : objRow[conQxUserLoginName.UpdDate].ToString().Trim(); //修改日期
objQxUserLoginNameEN.UpdTime = objRow[conQxUserLoginName.UpdTime] == DBNull.Value ? null : objRow[conQxUserLoginName.UpdTime].ToString().Trim(); //修改时间
objQxUserLoginNameEN.Memo = objRow[conQxUserLoginName.Memo] == DBNull.Value ? null : objRow[conQxUserLoginName.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserLoginNameEN.UserLoginName, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserLoginNameEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objQxUserLoginNameEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxUserLoginName(ref clsQxUserLoginNameEN objQxUserLoginNameEN)
{
bool bolResult = QxUserLoginNameDA.GetQxUserLoginName(ref objQxUserLoginNameEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strUserLoginName">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxUserLoginNameEN GetObjByUserLoginName(string strUserLoginName)
{
if (strUserLoginName.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strUserLoginName]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strUserLoginName) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strUserLoginName]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsQxUserLoginNameEN objQxUserLoginNameEN = QxUserLoginNameDA.GetObjByUserLoginName(strUserLoginName);
return objQxUserLoginNameEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsQxUserLoginNameEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsQxUserLoginNameEN objQxUserLoginNameEN = QxUserLoginNameDA.GetFirstObj(strWhereCond);
 return objQxUserLoginNameEN;
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
public static clsQxUserLoginNameEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsQxUserLoginNameEN objQxUserLoginNameEN = QxUserLoginNameDA.GetObjByDataRow(objRow);
 return objQxUserLoginNameEN;
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
public static clsQxUserLoginNameEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsQxUserLoginNameEN objQxUserLoginNameEN = QxUserLoginNameDA.GetObjByDataRow(objRow);
 return objQxUserLoginNameEN;
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
 /// <param name = "strUserLoginName">所给的关键字</param>
 /// <param name = "lstQxUserLoginNameObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxUserLoginNameEN GetObjByUserLoginNameFromList(string strUserLoginName, List<clsQxUserLoginNameEN> lstQxUserLoginNameObjLst)
{
foreach (clsQxUserLoginNameEN objQxUserLoginNameEN in lstQxUserLoginNameObjLst)
{
if (objQxUserLoginNameEN.UserLoginName == strUserLoginName)
{
return objQxUserLoginNameEN;
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
 string strUserLoginName;
 try
 {
 strUserLoginName = new clsQxUserLoginNameDA().GetFirstID(strWhereCond);
 return strUserLoginName;
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
 arrList = QxUserLoginNameDA.GetID(strWhereCond);
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
bool bolIsExist = QxUserLoginNameDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strUserLoginName">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strUserLoginName)
{
if (string.IsNullOrEmpty(strUserLoginName) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strUserLoginName]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = QxUserLoginNameDA.IsExist(strUserLoginName);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strUserLoginName">用户登录名</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strUserLoginName, string strOpUser)
{
clsQxUserLoginNameEN objQxUserLoginNameEN = clsQxUserLoginNameBL.GetObjByUserLoginName(strUserLoginName);
objQxUserLoginNameEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objQxUserLoginNameEN.UpdUserId = strOpUser;
return clsQxUserLoginNameBL.UpdateBySql2(objQxUserLoginNameEN);
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
 bolIsExist = clsQxUserLoginNameDA.IsExistTable();
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
 bolIsExist = QxUserLoginNameDA.IsExistTable(strTabName);
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
 /// <param name = "objQxUserLoginNameEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsQxUserLoginNameEN objQxUserLoginNameEN)
{
 if (string.IsNullOrEmpty(objQxUserLoginNameEN.UserLoginName) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQxUserLoginNameBL.IsExist(objQxUserLoginNameEN.UserLoginName) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQxUserLoginNameEN.UserLoginName, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = QxUserLoginNameDA.AddNewRecordBySQL2(objQxUserLoginNameEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserLoginNameBL.ReFreshCache();

if (clsQxUserLoginNameBL.relatedActions != null)
{
clsQxUserLoginNameBL.relatedActions.UpdRelaTabDate(objQxUserLoginNameEN.UserLoginName, objQxUserLoginNameEN.UpdUserId);
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
 /// <param name = "objQxUserLoginNameEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsQxUserLoginNameEN objQxUserLoginNameEN)
{
 if (string.IsNullOrEmpty(objQxUserLoginNameEN.UserLoginName) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQxUserLoginNameBL.IsExist(objQxUserLoginNameEN.UserLoginName) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQxUserLoginNameEN.UserLoginName, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = QxUserLoginNameDA.AddNewRecordBySQL2WithReturnKey(objQxUserLoginNameEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserLoginNameBL.ReFreshCache();

if (clsQxUserLoginNameBL.relatedActions != null)
{
clsQxUserLoginNameBL.relatedActions.UpdRelaTabDate(objQxUserLoginNameEN.UserLoginName, objQxUserLoginNameEN.UpdUserId);
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
 /// <param name = "strQxUserLoginNameObjXml">代表实体对象的XML串</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql_XML(string strQxUserLoginNameObjXml)
{
clsQxUserLoginNameEN objQxUserLoginNameEN = GetObjFromXmlStr(strQxUserLoginNameObjXml);
try
{
bool bolResult = QxUserLoginNameDA.AddNewRecordBySQL2(objQxUserLoginNameEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserLoginNameBL.ReFreshCache();

if (clsQxUserLoginNameBL.relatedActions != null)
{
clsQxUserLoginNameBL.relatedActions.UpdRelaTabDate(objQxUserLoginNameEN.UserLoginName, objQxUserLoginNameEN.UpdUserId);
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
 /// <param name = "objQxUserLoginNameEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsQxUserLoginNameEN objQxUserLoginNameEN)
{
try
{
bool bolResult = QxUserLoginNameDA.Update(objQxUserLoginNameEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserLoginNameBL.ReFreshCache();

if (clsQxUserLoginNameBL.relatedActions != null)
{
clsQxUserLoginNameBL.relatedActions.UpdRelaTabDate(objQxUserLoginNameEN.UserLoginName, objQxUserLoginNameEN.UpdUserId);
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
 /// <param name = "objQxUserLoginNameEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsQxUserLoginNameEN objQxUserLoginNameEN)
{
 if (string.IsNullOrEmpty(objQxUserLoginNameEN.UserLoginName) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = QxUserLoginNameDA.UpdateBySql2(objQxUserLoginNameEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserLoginNameBL.ReFreshCache();

if (clsQxUserLoginNameBL.relatedActions != null)
{
clsQxUserLoginNameBL.relatedActions.UpdRelaTabDate(objQxUserLoginNameEN.UserLoginName, objQxUserLoginNameEN.UpdUserId);
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
 /// <param name = "strQxUserLoginNameObjXml">需要修改的对象,用XML来表示</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql_XML(string strQxUserLoginNameObjXml)
{
clsQxUserLoginNameEN objQxUserLoginNameEN = GetObjFromXmlStr(strQxUserLoginNameObjXml);
try
{
bool bolResult = QxUserLoginNameDA.UpdateBySql2(objQxUserLoginNameEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserLoginNameBL.ReFreshCache();

if (clsQxUserLoginNameBL.relatedActions != null)
{
clsQxUserLoginNameBL.relatedActions.UpdRelaTabDate(objQxUserLoginNameEN.UserLoginName, objQxUserLoginNameEN.UpdUserId);
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
 /// <param name = "strUserLoginName">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strUserLoginName)
{
try
{
 clsQxUserLoginNameEN objQxUserLoginNameEN = clsQxUserLoginNameBL.GetObjByUserLoginName(strUserLoginName);

if (clsQxUserLoginNameBL.relatedActions != null)
{
clsQxUserLoginNameBL.relatedActions.UpdRelaTabDate(objQxUserLoginNameEN.UserLoginName, objQxUserLoginNameEN.UpdUserId);
}
if (objQxUserLoginNameEN != null)
{
int intRecNum = QxUserLoginNameDA.DelRecord(strUserLoginName);
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
/// <param name="strUserLoginName">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strUserLoginName )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxUserLoginNameDA.GetSpecSQLObj();
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
//删除与表:[QxUserLoginName]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conQxUserLoginName.UserLoginName,
//strUserLoginName);
//        clsQxUserLoginNameBL.DelQxUserLoginNamesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxUserLoginNameBL.DelRecord(strUserLoginName, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxUserLoginNameBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strUserLoginName, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strUserLoginName">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strUserLoginName, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsQxUserLoginNameBL.relatedActions != null)
{
clsQxUserLoginNameBL.relatedActions.UpdRelaTabDate(strUserLoginName, "UpdRelaTabDate");
}
bool bolResult = QxUserLoginNameDA.DelRecord(strUserLoginName,objSqlConnection,objSqlTransaction);
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
 /// <param name = "strUserLoginName">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strUserLoginName) 
{
try
{
if (clsQxUserLoginNameBL.relatedActions != null)
{
clsQxUserLoginNameBL.relatedActions.UpdRelaTabDate(strUserLoginName, "UpdRelaTabDate");
}
bool bolResult = QxUserLoginNameDA.DelRecordBySP(strUserLoginName);
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
 /// <param name = "arrUserLoginNameLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelQxUserLoginNames(List<string> arrUserLoginNameLst)
{
if (arrUserLoginNameLst.Count == 0) return 0;
try
{
if (clsQxUserLoginNameBL.relatedActions != null)
{
foreach (var strUserLoginName in arrUserLoginNameLst)
{
clsQxUserLoginNameBL.relatedActions.UpdRelaTabDate(strUserLoginName, "UpdRelaTabDate");
}
}
int intDelRecNum = QxUserLoginNameDA.DelQxUserLoginName(arrUserLoginNameLst);
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
public static int DelQxUserLoginNamesByCond(string strWhereCond)
{
try
{
if (clsQxUserLoginNameBL.relatedActions != null)
{
List<string> arrUserLoginName = GetPrimaryKeyID_S(strWhereCond);
foreach (var strUserLoginName in arrUserLoginName)
{
clsQxUserLoginNameBL.relatedActions.UpdRelaTabDate(strUserLoginName, "UpdRelaTabDate");
}
}
int intRecNum = QxUserLoginNameDA.DelQxUserLoginName(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[QxUserLoginName]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strUserLoginName">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strUserLoginName)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxUserLoginNameDA.GetSpecSQLObj();
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
//删除与表:[QxUserLoginName]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxUserLoginNameBL.DelRecord(strUserLoginName, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxUserLoginNameBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strUserLoginName, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objQxUserLoginNameENS">源对象</param>
 /// <param name = "objQxUserLoginNameENT">目标对象</param>
 public static void CopyTo(clsQxUserLoginNameEN objQxUserLoginNameENS, clsQxUserLoginNameEN objQxUserLoginNameENT)
{
try
{
objQxUserLoginNameENT.UserLoginName = objQxUserLoginNameENS.UserLoginName; //用户登录名
objQxUserLoginNameENT.UserId = objQxUserLoginNameENS.UserId; //用户ID
objQxUserLoginNameENT.UpdUserId = objQxUserLoginNameENS.UpdUserId; //修改用户Id
objQxUserLoginNameENT.UpdDate = objQxUserLoginNameENS.UpdDate; //修改日期
objQxUserLoginNameENT.UpdTime = objQxUserLoginNameENS.UpdTime; //修改时间
objQxUserLoginNameENT.Memo = objQxUserLoginNameENS.Memo; //备注
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
 /// <param name = "objQxUserLoginNameEN">源简化对象</param>
 public static void SetUpdFlag(clsQxUserLoginNameEN objQxUserLoginNameEN)
{
try
{
objQxUserLoginNameEN.ClearUpdateState();
   string strsfUpdFldSetStr = objQxUserLoginNameEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conQxUserLoginName.UserLoginName, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserLoginNameEN.UserLoginName = objQxUserLoginNameEN.UserLoginName; //用户登录名
}
if (arrFldSet.Contains(conQxUserLoginName.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserLoginNameEN.UserId = objQxUserLoginNameEN.UserId; //用户ID
}
if (arrFldSet.Contains(conQxUserLoginName.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserLoginNameEN.UpdUserId = objQxUserLoginNameEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conQxUserLoginName.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserLoginNameEN.UpdDate = objQxUserLoginNameEN.UpdDate == "[null]" ? null :  objQxUserLoginNameEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conQxUserLoginName.UpdTime, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserLoginNameEN.UpdTime = objQxUserLoginNameEN.UpdTime == "[null]" ? null :  objQxUserLoginNameEN.UpdTime; //修改时间
}
if (arrFldSet.Contains(conQxUserLoginName.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserLoginNameEN.Memo = objQxUserLoginNameEN.Memo == "[null]" ? null :  objQxUserLoginNameEN.Memo; //备注
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
 /// <param name = "objQxUserLoginNameEN">源简化对象</param>
 public static void AccessFldValueNull(clsQxUserLoginNameEN objQxUserLoginNameEN)
{
try
{
if (objQxUserLoginNameEN.UpdDate == "[null]") objQxUserLoginNameEN.UpdDate = null; //修改日期
if (objQxUserLoginNameEN.UpdTime == "[null]") objQxUserLoginNameEN.UpdTime = null; //修改时间
if (objQxUserLoginNameEN.Memo == "[null]") objQxUserLoginNameEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsQxUserLoginNameEN objQxUserLoginNameEN)
{
 QxUserLoginNameDA.CheckPropertyNew(objQxUserLoginNameEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsQxUserLoginNameEN objQxUserLoginNameEN)
{
 QxUserLoginNameDA.CheckProperty4Condition(objQxUserLoginNameEN);
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
if (clsQxUserLoginNameBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxUserLoginNameBL没有刷新缓存机制(clsQxUserLoginNameBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by UserLoginName");
//if (arrQxUserLoginNameObjLstCache == null)
//{
//arrQxUserLoginNameObjLstCache = QxUserLoginNameDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strUserLoginName">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxUserLoginNameEN GetObjByUserLoginNameCache(string strUserLoginName)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsQxUserLoginNameEN._CurrTabName);
List<clsQxUserLoginNameEN> arrQxUserLoginNameObjLstCache = GetObjLstCache();
IEnumerable <clsQxUserLoginNameEN> arrQxUserLoginNameObjLst_Sel =
arrQxUserLoginNameObjLstCache
.Where(x=> x.UserLoginName == strUserLoginName 
);
if (arrQxUserLoginNameObjLst_Sel.Count() == 0)
{
   clsQxUserLoginNameEN obj = clsQxUserLoginNameBL.GetObjByUserLoginName(strUserLoginName);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrQxUserLoginNameObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxUserLoginNameEN> GetAllQxUserLoginNameObjLstCache()
{
//获取缓存中的对象列表
List<clsQxUserLoginNameEN> arrQxUserLoginNameObjLstCache = GetObjLstCache(); 
return arrQxUserLoginNameObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxUserLoginNameEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsQxUserLoginNameEN._CurrTabName);
List<clsQxUserLoginNameEN> arrQxUserLoginNameObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrQxUserLoginNameObjLstCache;
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
string strKey = string.Format("{0}", clsQxUserLoginNameEN._CurrTabName);
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
if (clsQxUserLoginNameBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsQxUserLoginNameEN._CurrTabName);
CacheHelper.Remove(strKey);
clsQxUserLoginNameBL.objCommFun4BL.ReFreshCache();
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
 /// <param name = "lstQxUserLoginNameObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsQxUserLoginNameEN> lstQxUserLoginNameObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstQxUserLoginNameObjLst, writer);
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
 /// <param name = "lstQxUserLoginNameObjLst">[clsQxUserLoginNameEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsQxUserLoginNameEN> lstQxUserLoginNameObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsQxUserLoginNameBL.listXmlNode);
writer.WriteStartElement(clsQxUserLoginNameBL.itemsXmlNode);
foreach (clsQxUserLoginNameEN objQxUserLoginNameEN in lstQxUserLoginNameObjLst)
{
clsQxUserLoginNameBL.SerializeXML(writer, objQxUserLoginNameEN);
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
 /// <param name = "objQxUserLoginNameEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsQxUserLoginNameEN objQxUserLoginNameEN)
{
writer.WriteStartElement(clsQxUserLoginNameBL.itemXmlNode);
 
if (objQxUserLoginNameEN.UserLoginName != null)
{
writer.WriteElementString(conQxUserLoginName.UserLoginName, objQxUserLoginNameEN.UserLoginName.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUserLoginNameEN.UserId != null)
{
writer.WriteElementString(conQxUserLoginName.UserId, objQxUserLoginNameEN.UserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUserLoginNameEN.UpdUserId != null)
{
writer.WriteElementString(conQxUserLoginName.UpdUserId, objQxUserLoginNameEN.UpdUserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUserLoginNameEN.UpdDate != null)
{
writer.WriteElementString(conQxUserLoginName.UpdDate, objQxUserLoginNameEN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUserLoginNameEN.UpdTime != null)
{
writer.WriteElementString(conQxUserLoginName.UpdTime, objQxUserLoginNameEN.UpdTime.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUserLoginNameEN.Memo != null)
{
writer.WriteElementString(conQxUserLoginName.Memo, objQxUserLoginNameEN.Memo.ToString(CultureInfo.InvariantCulture));
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
public static clsQxUserLoginNameEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsQxUserLoginNameEN objQxUserLoginNameEN = new clsQxUserLoginNameEN();
reader.Read();
while (!(reader.Name == clsQxUserLoginNameBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(conQxUserLoginName.UserLoginName))
{
objQxUserLoginNameEN.UserLoginName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUserLoginName.UserId))
{
objQxUserLoginNameEN.UserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUserLoginName.UpdUserId))
{
objQxUserLoginNameEN.UpdUserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUserLoginName.UpdDate))
{
objQxUserLoginNameEN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUserLoginName.UpdTime))
{
objQxUserLoginNameEN.UpdTime = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUserLoginName.Memo))
{
objQxUserLoginNameEN.Memo = reader.ReadElementContentAsString();
}
}
return objQxUserLoginNameEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strQxUserLoginNameObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsQxUserLoginNameEN GetObjFromXmlStr(string strQxUserLoginNameObjXmlStr)
{
clsQxUserLoginNameEN objQxUserLoginNameEN = new clsQxUserLoginNameEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strQxUserLoginNameObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsQxUserLoginNameBL.itemXmlNode))
{
objQxUserLoginNameEN = GetObjFromXml(reader);
return objQxUserLoginNameEN;
}
}
return objQxUserLoginNameEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objQxUserLoginNameEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsQxUserLoginNameEN objQxUserLoginNameEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objQxUserLoginNameEN);
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
public static string Func(string strInFldName, string strOutFldName, string strUserLoginName)
{
if (strInFldName != conQxUserLoginName.UserLoginName)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conQxUserLoginName.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conQxUserLoginName.AttributeName));
throw new Exception(strMsg);
}
var objQxUserLoginName = clsQxUserLoginNameBL.GetObjByUserLoginNameCache(strUserLoginName);
if (objQxUserLoginName == null) return "";
return objQxUserLoginName[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objQxUserLoginNameEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsQxUserLoginNameEN objQxUserLoginNameEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsQxUserLoginNameEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objQxUserLoginNameEN[strField]);
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
 /// <param name = "lstQxUserLoginNameObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsQxUserLoginNameEN> lstQxUserLoginNameObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstQxUserLoginNameObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsQxUserLoginNameEN objQxUserLoginNameEN in lstQxUserLoginNameObjLst)
{
string strJSON_One = SerializeObjToJSON(objQxUserLoginNameEN);
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
int intRecCount = clsQxUserLoginNameDA.GetRecCount(strTabName);
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
int intRecCount = clsQxUserLoginNameDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsQxUserLoginNameDA.GetRecCount();
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
int intRecCount = clsQxUserLoginNameDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objQxUserLoginNameCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsQxUserLoginNameEN objQxUserLoginNameCond)
{
List<clsQxUserLoginNameEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxUserLoginNameEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxUserLoginName.AttributeName)
{
if (objQxUserLoginNameCond.IsUpdated(strFldName) == false) continue;
if (objQxUserLoginNameCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUserLoginNameCond[strFldName].ToString());
}
else
{
if (objQxUserLoginNameCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxUserLoginNameCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUserLoginNameCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxUserLoginNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxUserLoginNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxUserLoginNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxUserLoginNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxUserLoginNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxUserLoginNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxUserLoginNameCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxUserLoginNameCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxUserLoginNameCond[strFldName]));
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
 List<string> arrList = clsQxUserLoginNameDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = QxUserLoginNameDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = QxUserLoginNameDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = QxUserLoginNameDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxUserLoginNameDA.SetFldValue(clsQxUserLoginNameEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = QxUserLoginNameDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxUserLoginNameDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxUserLoginNameDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxUserLoginNameDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[QxUserLoginName] "); 
 strCreateTabCode.Append(" ( "); 
 // /**用户登录名*/ 
 strCreateTabCode.Append(" UserLoginName varchar(30) primary key, "); 
 // /**用户ID*/ 
 strCreateTabCode.Append(" UserId varchar(18) not Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改时间*/ 
 strCreateTabCode.Append(" UpdTime varchar(6) Null, "); 
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
 /// 用户登录名(QxUserLoginName)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4QxUserLoginName : clsCommFun4BL
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
clsQxUserLoginNameBL.ReFreshThisCache();
}
}

}