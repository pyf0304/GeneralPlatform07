
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUserRoleRelationV2BL
 表名:QxUserRoleRelationV2(00140113)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:31:34
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
public static class  clsQxUserRoleRelationV2BL_Static
{

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQxUserRoleRelationV2EN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN)
{
try
{
bool bolResult = clsQxUserRoleRelationV2BL.QxUserRoleRelationV2DA.AddNewRecordBySQL2(objQxUserRoleRelationV2EN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRoleRelationV2BL.ReFreshCache();

if (clsQxUserRoleRelationV2BL.relatedActions != null)
{
clsQxUserRoleRelationV2BL.relatedActions.UpdRelaTabDate(objQxUserRoleRelationV2EN.UId,objQxUserRoleRelationV2EN.RId, objQxUserRoleRelationV2EN.UpdUserId);
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
public static bool AddRecordEx(this clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsQxUserRoleRelationV2BL.IsExist(objQxUserRoleRelationV2EN.UId,objQxUserRoleRelationV2EN.RId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objQxUserRoleRelationV2EN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objQxUserRoleRelationV2EN.AddNewRecord();
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
 /// <param name = "objQxUserRoleRelationV2EN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN)
{
try
{
string strKey = clsQxUserRoleRelationV2BL.QxUserRoleRelationV2DA.AddNewRecordBySQL2WithReturnKey(objQxUserRoleRelationV2EN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRoleRelationV2BL.ReFreshCache();

if (clsQxUserRoleRelationV2BL.relatedActions != null)
{
clsQxUserRoleRelationV2BL.relatedActions.UpdRelaTabDate(objQxUserRoleRelationV2EN.UId,objQxUserRoleRelationV2EN.RId, objQxUserRoleRelationV2EN.UpdUserId);
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
 /// <param name = "objQxUserRoleRelationV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserRoleRelationV2EN SetUId(this clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN, int intUId, string strComparisonOp="")
	{
objQxUserRoleRelationV2EN.UId = intUId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserRoleRelationV2EN.dicFldComparisonOp.ContainsKey(conQxUserRoleRelationV2.UId) == false)
{
objQxUserRoleRelationV2EN.dicFldComparisonOp.Add(conQxUserRoleRelationV2.UId, strComparisonOp);
}
else
{
objQxUserRoleRelationV2EN.dicFldComparisonOp[conQxUserRoleRelationV2.UId] = strComparisonOp;
}
}
return objQxUserRoleRelationV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserRoleRelationV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserRoleRelationV2EN SetRId(this clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN, int intRId, string strComparisonOp="")
	{
objQxUserRoleRelationV2EN.RId = intRId; //角色Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserRoleRelationV2EN.dicFldComparisonOp.ContainsKey(conQxUserRoleRelationV2.RId) == false)
{
objQxUserRoleRelationV2EN.dicFldComparisonOp.Add(conQxUserRoleRelationV2.RId, strComparisonOp);
}
else
{
objQxUserRoleRelationV2EN.dicFldComparisonOp[conQxUserRoleRelationV2.RId] = strComparisonOp;
}
}
return objQxUserRoleRelationV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserRoleRelationV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserRoleRelationV2EN SetQxPrjId(this clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, conQxUserRoleRelationV2.QxPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQxPrjId, 4, conQxUserRoleRelationV2.QxPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, conQxUserRoleRelationV2.QxPrjId);
}
objQxUserRoleRelationV2EN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserRoleRelationV2EN.dicFldComparisonOp.ContainsKey(conQxUserRoleRelationV2.QxPrjId) == false)
{
objQxUserRoleRelationV2EN.dicFldComparisonOp.Add(conQxUserRoleRelationV2.QxPrjId, strComparisonOp);
}
else
{
objQxUserRoleRelationV2EN.dicFldComparisonOp[conQxUserRoleRelationV2.QxPrjId] = strComparisonOp;
}
}
return objQxUserRoleRelationV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserRoleRelationV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserRoleRelationV2EN SetUpdDate(this clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQxUserRoleRelationV2.UpdDate);
}
objQxUserRoleRelationV2EN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserRoleRelationV2EN.dicFldComparisonOp.ContainsKey(conQxUserRoleRelationV2.UpdDate) == false)
{
objQxUserRoleRelationV2EN.dicFldComparisonOp.Add(conQxUserRoleRelationV2.UpdDate, strComparisonOp);
}
else
{
objQxUserRoleRelationV2EN.dicFldComparisonOp[conQxUserRoleRelationV2.UpdDate] = strComparisonOp;
}
}
return objQxUserRoleRelationV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserRoleRelationV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserRoleRelationV2EN SetUpdUserId(this clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conQxUserRoleRelationV2.UpdUserId);
}
objQxUserRoleRelationV2EN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserRoleRelationV2EN.dicFldComparisonOp.ContainsKey(conQxUserRoleRelationV2.UpdUserId) == false)
{
objQxUserRoleRelationV2EN.dicFldComparisonOp.Add(conQxUserRoleRelationV2.UpdUserId, strComparisonOp);
}
else
{
objQxUserRoleRelationV2EN.dicFldComparisonOp[conQxUserRoleRelationV2.UpdUserId] = strComparisonOp;
}
}
return objQxUserRoleRelationV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserRoleRelationV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserRoleRelationV2EN SetMemo(this clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQxUserRoleRelationV2.Memo);
}
objQxUserRoleRelationV2EN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserRoleRelationV2EN.dicFldComparisonOp.ContainsKey(conQxUserRoleRelationV2.Memo) == false)
{
objQxUserRoleRelationV2EN.dicFldComparisonOp.Add(conQxUserRoleRelationV2.Memo, strComparisonOp);
}
else
{
objQxUserRoleRelationV2EN.dicFldComparisonOp[conQxUserRoleRelationV2.Memo] = strComparisonOp;
}
}
return objQxUserRoleRelationV2EN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objQxUserRoleRelationV2EN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objQxUserRoleRelationV2EN.CheckPropertyNew();
clsQxUserRoleRelationV2EN objQxUserRoleRelationV2Cond = new clsQxUserRoleRelationV2EN();
string strCondition = objQxUserRoleRelationV2Cond
.SetUId(objQxUserRoleRelationV2EN.UId, "=")
.GetCombineCondition();
objQxUserRoleRelationV2EN._IsCheckProperty = true;
bool bolIsExist = clsQxUserRoleRelationV2BL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objQxUserRoleRelationV2EN.Update();
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
 /// <param name = "objQxUserRoleRelationV2EN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN)
{
 if (objQxUserRoleRelationV2EN.UId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxUserRoleRelationV2BL.QxUserRoleRelationV2DA.UpdateBySql2(objQxUserRoleRelationV2EN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRoleRelationV2BL.ReFreshCache();

if (clsQxUserRoleRelationV2BL.relatedActions != null)
{
clsQxUserRoleRelationV2BL.relatedActions.UpdRelaTabDate(objQxUserRoleRelationV2EN.UId,objQxUserRoleRelationV2EN.RId, objQxUserRoleRelationV2EN.UpdUserId);
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
 /// <param name = "objQxUserRoleRelationV2EN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objQxUserRoleRelationV2EN.UId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxUserRoleRelationV2BL.QxUserRoleRelationV2DA.UpdateBySql2(objQxUserRoleRelationV2EN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRoleRelationV2BL.ReFreshCache();

if (clsQxUserRoleRelationV2BL.relatedActions != null)
{
clsQxUserRoleRelationV2BL.relatedActions.UpdRelaTabDate(objQxUserRoleRelationV2EN.UId,objQxUserRoleRelationV2EN.RId, objQxUserRoleRelationV2EN.UpdUserId);
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
 /// <param name = "objQxUserRoleRelationV2EN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN, string strWhereCond)
{
try
{
bool bolResult = clsQxUserRoleRelationV2BL.QxUserRoleRelationV2DA.UpdateBySqlWithCondition(objQxUserRoleRelationV2EN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRoleRelationV2BL.ReFreshCache();

if (clsQxUserRoleRelationV2BL.relatedActions != null)
{
clsQxUserRoleRelationV2BL.relatedActions.UpdRelaTabDate(objQxUserRoleRelationV2EN.UId,objQxUserRoleRelationV2EN.RId, objQxUserRoleRelationV2EN.UpdUserId);
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
 /// <param name = "objQxUserRoleRelationV2EN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsQxUserRoleRelationV2BL.QxUserRoleRelationV2DA.UpdateBySqlWithConditionTransaction(objQxUserRoleRelationV2EN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRoleRelationV2BL.ReFreshCache();

if (clsQxUserRoleRelationV2BL.relatedActions != null)
{
clsQxUserRoleRelationV2BL.relatedActions.UpdRelaTabDate(objQxUserRoleRelationV2EN.UId,objQxUserRoleRelationV2EN.RId, objQxUserRoleRelationV2EN.UpdUserId);
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
 /// <param name = "intUId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN)
{
try
{
int intRecNum = clsQxUserRoleRelationV2BL.QxUserRoleRelationV2DA.DelRecord(objQxUserRoleRelationV2EN.UId,objQxUserRoleRelationV2EN.RId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRoleRelationV2BL.ReFreshCache();

if (clsQxUserRoleRelationV2BL.relatedActions != null)
{
clsQxUserRoleRelationV2BL.relatedActions.UpdRelaTabDate(objQxUserRoleRelationV2EN.UId,objQxUserRoleRelationV2EN.RId, objQxUserRoleRelationV2EN.UpdUserId);
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
 /// <param name = "objQxUserRoleRelationV2ENS">源对象</param>
 /// <param name = "objQxUserRoleRelationV2ENT">目标对象</param>
 public static void CopyTo(this clsQxUserRoleRelationV2EN objQxUserRoleRelationV2ENS, clsQxUserRoleRelationV2EN objQxUserRoleRelationV2ENT)
{
try
{
objQxUserRoleRelationV2ENT.UId = objQxUserRoleRelationV2ENS.UId; //用户ID
objQxUserRoleRelationV2ENT.RId = objQxUserRoleRelationV2ENS.RId; //角色Id
objQxUserRoleRelationV2ENT.QxPrjId = objQxUserRoleRelationV2ENS.QxPrjId; //项目Id
objQxUserRoleRelationV2ENT.UpdDate = objQxUserRoleRelationV2ENS.UpdDate; //修改日期
objQxUserRoleRelationV2ENT.UpdUserId = objQxUserRoleRelationV2ENS.UpdUserId; //修改用户Id
objQxUserRoleRelationV2ENT.Memo = objQxUserRoleRelationV2ENS.Memo; //备注
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
 /// <param name = "objQxUserRoleRelationV2ENS">源对象</param>
 /// <returns>目标对象=>clsQxUserRoleRelationV2EN:objQxUserRoleRelationV2ENT</returns>
 public static clsQxUserRoleRelationV2EN CopyTo(this clsQxUserRoleRelationV2EN objQxUserRoleRelationV2ENS)
{
try
{
 clsQxUserRoleRelationV2EN objQxUserRoleRelationV2ENT = new clsQxUserRoleRelationV2EN()
{
UId = objQxUserRoleRelationV2ENS.UId, //用户ID
RId = objQxUserRoleRelationV2ENS.RId, //角色Id
QxPrjId = objQxUserRoleRelationV2ENS.QxPrjId, //项目Id
UpdDate = objQxUserRoleRelationV2ENS.UpdDate, //修改日期
UpdUserId = objQxUserRoleRelationV2ENS.UpdUserId, //修改用户Id
Memo = objQxUserRoleRelationV2ENS.Memo, //备注
};
 return objQxUserRoleRelationV2ENT;
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
public static void CheckPropertyNew(this clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN)
{
 clsQxUserRoleRelationV2BL.QxUserRoleRelationV2DA.CheckPropertyNew(objQxUserRoleRelationV2EN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN)
{
 clsQxUserRoleRelationV2BL.QxUserRoleRelationV2DA.CheckProperty4Condition(objQxUserRoleRelationV2EN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQxUserRoleRelationV2EN objQxUserRoleRelationV2Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQxUserRoleRelationV2Cond.IsUpdated(conQxUserRoleRelationV2.UId) == true)
{
string strComparisonOpUId = objQxUserRoleRelationV2Cond.dicFldComparisonOp[conQxUserRoleRelationV2.UId];
strWhereCond += string.Format(" And {0} {2} {1}", conQxUserRoleRelationV2.UId, objQxUserRoleRelationV2Cond.UId, strComparisonOpUId);
}
if (objQxUserRoleRelationV2Cond.IsUpdated(conQxUserRoleRelationV2.RId) == true)
{
string strComparisonOpRId = objQxUserRoleRelationV2Cond.dicFldComparisonOp[conQxUserRoleRelationV2.RId];
strWhereCond += string.Format(" And {0} {2} {1}", conQxUserRoleRelationV2.RId, objQxUserRoleRelationV2Cond.RId, strComparisonOpRId);
}
if (objQxUserRoleRelationV2Cond.IsUpdated(conQxUserRoleRelationV2.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objQxUserRoleRelationV2Cond.dicFldComparisonOp[conQxUserRoleRelationV2.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserRoleRelationV2.QxPrjId, objQxUserRoleRelationV2Cond.QxPrjId, strComparisonOpQxPrjId);
}
if (objQxUserRoleRelationV2Cond.IsUpdated(conQxUserRoleRelationV2.UpdDate) == true)
{
string strComparisonOpUpdDate = objQxUserRoleRelationV2Cond.dicFldComparisonOp[conQxUserRoleRelationV2.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserRoleRelationV2.UpdDate, objQxUserRoleRelationV2Cond.UpdDate, strComparisonOpUpdDate);
}
if (objQxUserRoleRelationV2Cond.IsUpdated(conQxUserRoleRelationV2.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objQxUserRoleRelationV2Cond.dicFldComparisonOp[conQxUserRoleRelationV2.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserRoleRelationV2.UpdUserId, objQxUserRoleRelationV2Cond.UpdUserId, strComparisonOpUpdUserId);
}
if (objQxUserRoleRelationV2Cond.IsUpdated(conQxUserRoleRelationV2.Memo) == true)
{
string strComparisonOpMemo = objQxUserRoleRelationV2Cond.dicFldComparisonOp[conQxUserRoleRelationV2.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserRoleRelationV2.Memo, objQxUserRoleRelationV2Cond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_QxUserRoleRelationV2
{
public virtual bool UpdRelaTabDate(int intUId,int intRId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 用户角色关系V2(QxUserRoleRelationV2)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsQxUserRoleRelationV2BL
{
public static RelatedActions_QxUserRoleRelationV2 relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "QxUserRoleRelationV2ListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "QxUserRoleRelationV2List";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsQxUserRoleRelationV2EN> arrQxUserRoleRelationV2ObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsQxUserRoleRelationV2DA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsQxUserRoleRelationV2DA QxUserRoleRelationV2DA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsQxUserRoleRelationV2DA();
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
 public clsQxUserRoleRelationV2BL()
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
if (string.IsNullOrEmpty(clsQxUserRoleRelationV2EN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxUserRoleRelationV2EN._ConnectString);
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
objDS = QxUserRoleRelationV2DA.GetDataSet(strWhereCond);
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
objDS = QxUserRoleRelationV2DA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = QxUserRoleRelationV2DA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_QxUserRoleRelationV2(string strWhereCond)
{
DataTable objDT;
try
{
objDT = QxUserRoleRelationV2DA.GetDataTable_QxUserRoleRelationV2(strWhereCond);
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
objDT = QxUserRoleRelationV2DA.GetDataTable(strWhereCond);
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
objDT = QxUserRoleRelationV2DA.GetDataTable(strWhereCond, lstExclude);
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
objDT = QxUserRoleRelationV2DA.GetDataTable(strWhereCond, strTabName);
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
objDT = QxUserRoleRelationV2DA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = QxUserRoleRelationV2DA.GetDataTable_Top(objTopPara);
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
objDT = QxUserRoleRelationV2DA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = QxUserRoleRelationV2DA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = QxUserRoleRelationV2DA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = QxUserRoleRelationV2DA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = QxUserRoleRelationV2DA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = QxUserRoleRelationV2DA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = QxUserRoleRelationV2DA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = QxUserRoleRelationV2DA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
 /// 把多个关键字段的值连接起来,用|连接(Join)--QxUserRoleRelationV2(用户角色关系V2)
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_JoinByKeyLst)
 /// </summary>
 /// <param name = "objQxUserRoleRelationV2EN">需要连接的对象</param>
 /// <returns></returns>
public static string JoinByKeyLst(clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN)
{
//检测记录是否存在
string strResult = "";
strResult += objQxUserRoleRelationV2EN.UId;
strResult += "|" + objQxUserRoleRelationV2EN.RId;
return strResult;
}
 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrKeyLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsQxUserRoleRelationV2EN> GetObjLstByKeyLstsCache(List<string> arrKeyLst)
{
string strKey = string.Format("{0}", clsQxUserRoleRelationV2EN._CurrTabName);
List<clsQxUserRoleRelationV2EN> arrQxUserRoleRelationV2ObjLstCache = GetObjLstCache();
IEnumerable <clsQxUserRoleRelationV2EN> arrQxUserRoleRelationV2ObjLst_Sel =
arrQxUserRoleRelationV2ObjLstCache
.Where(x => arrKeyLst.Contains(JoinByKeyLst(x)));
return arrQxUserRoleRelationV2ObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUserRoleRelationV2EN> GetObjLst(string strWhereCond)
{
List<clsQxUserRoleRelationV2EN> arrObjLst = new List<clsQxUserRoleRelationV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN = new clsQxUserRoleRelationV2EN();
try
{
objQxUserRoleRelationV2EN.UId = Int32.Parse(objRow[conQxUserRoleRelationV2.UId].ToString().Trim()); //用户ID
objQxUserRoleRelationV2EN.RId = Int32.Parse(objRow[conQxUserRoleRelationV2.RId].ToString().Trim()); //角色Id
objQxUserRoleRelationV2EN.QxPrjId = objRow[conQxUserRoleRelationV2.QxPrjId].ToString().Trim(); //项目Id
objQxUserRoleRelationV2EN.UpdDate = objRow[conQxUserRoleRelationV2.UpdDate] == DBNull.Value ? null : objRow[conQxUserRoleRelationV2.UpdDate].ToString().Trim(); //修改日期
objQxUserRoleRelationV2EN.UpdUserId = objRow[conQxUserRoleRelationV2.UpdUserId] == DBNull.Value ? null : objRow[conQxUserRoleRelationV2.UpdUserId].ToString().Trim(); //修改用户Id
objQxUserRoleRelationV2EN.Memo = objRow[conQxUserRoleRelationV2.Memo] == DBNull.Value ? null : objRow[conQxUserRoleRelationV2.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserRoleRelationV2EN.UId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserRoleRelationV2EN);
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
public static List<clsQxUserRoleRelationV2EN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsQxUserRoleRelationV2EN> arrObjLst = new List<clsQxUserRoleRelationV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN = new clsQxUserRoleRelationV2EN();
try
{
objQxUserRoleRelationV2EN.UId = Int32.Parse(objRow[conQxUserRoleRelationV2.UId].ToString().Trim()); //用户ID
objQxUserRoleRelationV2EN.RId = Int32.Parse(objRow[conQxUserRoleRelationV2.RId].ToString().Trim()); //角色Id
objQxUserRoleRelationV2EN.QxPrjId = objRow[conQxUserRoleRelationV2.QxPrjId].ToString().Trim(); //项目Id
objQxUserRoleRelationV2EN.UpdDate = objRow[conQxUserRoleRelationV2.UpdDate] == DBNull.Value ? null : objRow[conQxUserRoleRelationV2.UpdDate].ToString().Trim(); //修改日期
objQxUserRoleRelationV2EN.UpdUserId = objRow[conQxUserRoleRelationV2.UpdUserId] == DBNull.Value ? null : objRow[conQxUserRoleRelationV2.UpdUserId].ToString().Trim(); //修改用户Id
objQxUserRoleRelationV2EN.Memo = objRow[conQxUserRoleRelationV2.Memo] == DBNull.Value ? null : objRow[conQxUserRoleRelationV2.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserRoleRelationV2EN.UId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserRoleRelationV2EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objQxUserRoleRelationV2Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsQxUserRoleRelationV2EN> GetSubObjLstCache(clsQxUserRoleRelationV2EN objQxUserRoleRelationV2Cond)
{
List<clsQxUserRoleRelationV2EN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxUserRoleRelationV2EN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxUserRoleRelationV2.AttributeName)
{
if (objQxUserRoleRelationV2Cond.IsUpdated(strFldName) == false) continue;
if (objQxUserRoleRelationV2Cond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUserRoleRelationV2Cond[strFldName].ToString());
}
else
{
if (objQxUserRoleRelationV2Cond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxUserRoleRelationV2Cond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUserRoleRelationV2Cond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxUserRoleRelationV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxUserRoleRelationV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxUserRoleRelationV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxUserRoleRelationV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxUserRoleRelationV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxUserRoleRelationV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxUserRoleRelationV2Cond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxUserRoleRelationV2Cond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxUserRoleRelationV2Cond[strFldName]));
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
public static List<clsQxUserRoleRelationV2EN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsQxUserRoleRelationV2EN> arrObjLst = new List<clsQxUserRoleRelationV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN = new clsQxUserRoleRelationV2EN();
try
{
objQxUserRoleRelationV2EN.UId = Int32.Parse(objRow[conQxUserRoleRelationV2.UId].ToString().Trim()); //用户ID
objQxUserRoleRelationV2EN.RId = Int32.Parse(objRow[conQxUserRoleRelationV2.RId].ToString().Trim()); //角色Id
objQxUserRoleRelationV2EN.QxPrjId = objRow[conQxUserRoleRelationV2.QxPrjId].ToString().Trim(); //项目Id
objQxUserRoleRelationV2EN.UpdDate = objRow[conQxUserRoleRelationV2.UpdDate] == DBNull.Value ? null : objRow[conQxUserRoleRelationV2.UpdDate].ToString().Trim(); //修改日期
objQxUserRoleRelationV2EN.UpdUserId = objRow[conQxUserRoleRelationV2.UpdUserId] == DBNull.Value ? null : objRow[conQxUserRoleRelationV2.UpdUserId].ToString().Trim(); //修改用户Id
objQxUserRoleRelationV2EN.Memo = objRow[conQxUserRoleRelationV2.Memo] == DBNull.Value ? null : objRow[conQxUserRoleRelationV2.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserRoleRelationV2EN.UId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserRoleRelationV2EN);
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
public static List<clsQxUserRoleRelationV2EN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsQxUserRoleRelationV2EN> arrObjLst = new List<clsQxUserRoleRelationV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN = new clsQxUserRoleRelationV2EN();
try
{
objQxUserRoleRelationV2EN.UId = Int32.Parse(objRow[conQxUserRoleRelationV2.UId].ToString().Trim()); //用户ID
objQxUserRoleRelationV2EN.RId = Int32.Parse(objRow[conQxUserRoleRelationV2.RId].ToString().Trim()); //角色Id
objQxUserRoleRelationV2EN.QxPrjId = objRow[conQxUserRoleRelationV2.QxPrjId].ToString().Trim(); //项目Id
objQxUserRoleRelationV2EN.UpdDate = objRow[conQxUserRoleRelationV2.UpdDate] == DBNull.Value ? null : objRow[conQxUserRoleRelationV2.UpdDate].ToString().Trim(); //修改日期
objQxUserRoleRelationV2EN.UpdUserId = objRow[conQxUserRoleRelationV2.UpdUserId] == DBNull.Value ? null : objRow[conQxUserRoleRelationV2.UpdUserId].ToString().Trim(); //修改用户Id
objQxUserRoleRelationV2EN.Memo = objRow[conQxUserRoleRelationV2.Memo] == DBNull.Value ? null : objRow[conQxUserRoleRelationV2.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserRoleRelationV2EN.UId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserRoleRelationV2EN);
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
List<clsQxUserRoleRelationV2EN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsQxUserRoleRelationV2EN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUserRoleRelationV2EN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsQxUserRoleRelationV2EN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsQxUserRoleRelationV2EN> arrObjLst = new List<clsQxUserRoleRelationV2EN>(); 
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
	clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN = new clsQxUserRoleRelationV2EN();
try
{
objQxUserRoleRelationV2EN.UId = Int32.Parse(objRow[conQxUserRoleRelationV2.UId].ToString().Trim()); //用户ID
objQxUserRoleRelationV2EN.RId = Int32.Parse(objRow[conQxUserRoleRelationV2.RId].ToString().Trim()); //角色Id
objQxUserRoleRelationV2EN.QxPrjId = objRow[conQxUserRoleRelationV2.QxPrjId].ToString().Trim(); //项目Id
objQxUserRoleRelationV2EN.UpdDate = objRow[conQxUserRoleRelationV2.UpdDate] == DBNull.Value ? null : objRow[conQxUserRoleRelationV2.UpdDate].ToString().Trim(); //修改日期
objQxUserRoleRelationV2EN.UpdUserId = objRow[conQxUserRoleRelationV2.UpdUserId] == DBNull.Value ? null : objRow[conQxUserRoleRelationV2.UpdUserId].ToString().Trim(); //修改用户Id
objQxUserRoleRelationV2EN.Memo = objRow[conQxUserRoleRelationV2.Memo] == DBNull.Value ? null : objRow[conQxUserRoleRelationV2.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserRoleRelationV2EN.UId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserRoleRelationV2EN);
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
public static List<clsQxUserRoleRelationV2EN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsQxUserRoleRelationV2EN> arrObjLst = new List<clsQxUserRoleRelationV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN = new clsQxUserRoleRelationV2EN();
try
{
objQxUserRoleRelationV2EN.UId = Int32.Parse(objRow[conQxUserRoleRelationV2.UId].ToString().Trim()); //用户ID
objQxUserRoleRelationV2EN.RId = Int32.Parse(objRow[conQxUserRoleRelationV2.RId].ToString().Trim()); //角色Id
objQxUserRoleRelationV2EN.QxPrjId = objRow[conQxUserRoleRelationV2.QxPrjId].ToString().Trim(); //项目Id
objQxUserRoleRelationV2EN.UpdDate = objRow[conQxUserRoleRelationV2.UpdDate] == DBNull.Value ? null : objRow[conQxUserRoleRelationV2.UpdDate].ToString().Trim(); //修改日期
objQxUserRoleRelationV2EN.UpdUserId = objRow[conQxUserRoleRelationV2.UpdUserId] == DBNull.Value ? null : objRow[conQxUserRoleRelationV2.UpdUserId].ToString().Trim(); //修改用户Id
objQxUserRoleRelationV2EN.Memo = objRow[conQxUserRoleRelationV2.Memo] == DBNull.Value ? null : objRow[conQxUserRoleRelationV2.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserRoleRelationV2EN.UId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserRoleRelationV2EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsQxUserRoleRelationV2EN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsQxUserRoleRelationV2EN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsQxUserRoleRelationV2EN> arrObjLst = new List<clsQxUserRoleRelationV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN = new clsQxUserRoleRelationV2EN();
try
{
objQxUserRoleRelationV2EN.UId = Int32.Parse(objRow[conQxUserRoleRelationV2.UId].ToString().Trim()); //用户ID
objQxUserRoleRelationV2EN.RId = Int32.Parse(objRow[conQxUserRoleRelationV2.RId].ToString().Trim()); //角色Id
objQxUserRoleRelationV2EN.QxPrjId = objRow[conQxUserRoleRelationV2.QxPrjId].ToString().Trim(); //项目Id
objQxUserRoleRelationV2EN.UpdDate = objRow[conQxUserRoleRelationV2.UpdDate] == DBNull.Value ? null : objRow[conQxUserRoleRelationV2.UpdDate].ToString().Trim(); //修改日期
objQxUserRoleRelationV2EN.UpdUserId = objRow[conQxUserRoleRelationV2.UpdUserId] == DBNull.Value ? null : objRow[conQxUserRoleRelationV2.UpdUserId].ToString().Trim(); //修改用户Id
objQxUserRoleRelationV2EN.Memo = objRow[conQxUserRoleRelationV2.Memo] == DBNull.Value ? null : objRow[conQxUserRoleRelationV2.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserRoleRelationV2EN.UId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserRoleRelationV2EN);
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
public static List<clsQxUserRoleRelationV2EN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsQxUserRoleRelationV2EN> arrObjLst = new List<clsQxUserRoleRelationV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN = new clsQxUserRoleRelationV2EN();
try
{
objQxUserRoleRelationV2EN.UId = Int32.Parse(objRow[conQxUserRoleRelationV2.UId].ToString().Trim()); //用户ID
objQxUserRoleRelationV2EN.RId = Int32.Parse(objRow[conQxUserRoleRelationV2.RId].ToString().Trim()); //角色Id
objQxUserRoleRelationV2EN.QxPrjId = objRow[conQxUserRoleRelationV2.QxPrjId].ToString().Trim(); //项目Id
objQxUserRoleRelationV2EN.UpdDate = objRow[conQxUserRoleRelationV2.UpdDate] == DBNull.Value ? null : objRow[conQxUserRoleRelationV2.UpdDate].ToString().Trim(); //修改日期
objQxUserRoleRelationV2EN.UpdUserId = objRow[conQxUserRoleRelationV2.UpdUserId] == DBNull.Value ? null : objRow[conQxUserRoleRelationV2.UpdUserId].ToString().Trim(); //修改用户Id
objQxUserRoleRelationV2EN.Memo = objRow[conQxUserRoleRelationV2.Memo] == DBNull.Value ? null : objRow[conQxUserRoleRelationV2.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserRoleRelationV2EN.UId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserRoleRelationV2EN);
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
public static IEnumerable<clsQxUserRoleRelationV2EN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsQxUserRoleRelationV2EN objQxUserRoleRelationV2Cond, string strOrderBy)
{
List<clsQxUserRoleRelationV2EN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxUserRoleRelationV2EN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxUserRoleRelationV2.AttributeName)
{
if (objQxUserRoleRelationV2Cond.IsUpdated(strFldName) == false) continue;
if (objQxUserRoleRelationV2Cond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUserRoleRelationV2Cond[strFldName].ToString());
}
else
{
if (objQxUserRoleRelationV2Cond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxUserRoleRelationV2Cond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUserRoleRelationV2Cond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxUserRoleRelationV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxUserRoleRelationV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxUserRoleRelationV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxUserRoleRelationV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxUserRoleRelationV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxUserRoleRelationV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxUserRoleRelationV2Cond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxUserRoleRelationV2Cond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxUserRoleRelationV2Cond[strFldName]));
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
public static IEnumerable<clsQxUserRoleRelationV2EN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsQxUserRoleRelationV2EN objQxUserRoleRelationV2Cond = JsonConvert.DeserializeObject<clsQxUserRoleRelationV2EN>(objPagerPara.whereCond);
if (objQxUserRoleRelationV2Cond.sfFldComparisonOp == null)
{
objQxUserRoleRelationV2Cond.dicFldComparisonOp = null;
}
else
{
objQxUserRoleRelationV2Cond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objQxUserRoleRelationV2Cond.sfFldComparisonOp);
}
clsQxUserRoleRelationV2BL.SetUpdFlag(objQxUserRoleRelationV2Cond);
 try
{
CheckProperty4Condition(objQxUserRoleRelationV2Cond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsQxUserRoleRelationV2BL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objQxUserRoleRelationV2Cond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUserRoleRelationV2EN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsQxUserRoleRelationV2EN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsQxUserRoleRelationV2EN> arrObjLst = new List<clsQxUserRoleRelationV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN = new clsQxUserRoleRelationV2EN();
try
{
objQxUserRoleRelationV2EN.UId = Int32.Parse(objRow[conQxUserRoleRelationV2.UId].ToString().Trim()); //用户ID
objQxUserRoleRelationV2EN.RId = Int32.Parse(objRow[conQxUserRoleRelationV2.RId].ToString().Trim()); //角色Id
objQxUserRoleRelationV2EN.QxPrjId = objRow[conQxUserRoleRelationV2.QxPrjId].ToString().Trim(); //项目Id
objQxUserRoleRelationV2EN.UpdDate = objRow[conQxUserRoleRelationV2.UpdDate] == DBNull.Value ? null : objRow[conQxUserRoleRelationV2.UpdDate].ToString().Trim(); //修改日期
objQxUserRoleRelationV2EN.UpdUserId = objRow[conQxUserRoleRelationV2.UpdUserId] == DBNull.Value ? null : objRow[conQxUserRoleRelationV2.UpdUserId].ToString().Trim(); //修改用户Id
objQxUserRoleRelationV2EN.Memo = objRow[conQxUserRoleRelationV2.Memo] == DBNull.Value ? null : objRow[conQxUserRoleRelationV2.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserRoleRelationV2EN.UId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserRoleRelationV2EN);
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
public static List<clsQxUserRoleRelationV2EN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsQxUserRoleRelationV2EN> arrObjLst = new List<clsQxUserRoleRelationV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN = new clsQxUserRoleRelationV2EN();
try
{
objQxUserRoleRelationV2EN.UId = Int32.Parse(objRow[conQxUserRoleRelationV2.UId].ToString().Trim()); //用户ID
objQxUserRoleRelationV2EN.RId = Int32.Parse(objRow[conQxUserRoleRelationV2.RId].ToString().Trim()); //角色Id
objQxUserRoleRelationV2EN.QxPrjId = objRow[conQxUserRoleRelationV2.QxPrjId].ToString().Trim(); //项目Id
objQxUserRoleRelationV2EN.UpdDate = objRow[conQxUserRoleRelationV2.UpdDate] == DBNull.Value ? null : objRow[conQxUserRoleRelationV2.UpdDate].ToString().Trim(); //修改日期
objQxUserRoleRelationV2EN.UpdUserId = objRow[conQxUserRoleRelationV2.UpdUserId] == DBNull.Value ? null : objRow[conQxUserRoleRelationV2.UpdUserId].ToString().Trim(); //修改用户Id
objQxUserRoleRelationV2EN.Memo = objRow[conQxUserRoleRelationV2.Memo] == DBNull.Value ? null : objRow[conQxUserRoleRelationV2.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserRoleRelationV2EN.UId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserRoleRelationV2EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUserRoleRelationV2EN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsQxUserRoleRelationV2EN> arrObjLst = new List<clsQxUserRoleRelationV2EN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN = new clsQxUserRoleRelationV2EN();
try
{
objQxUserRoleRelationV2EN.UId = Int32.Parse(objRow[conQxUserRoleRelationV2.UId].ToString().Trim()); //用户ID
objQxUserRoleRelationV2EN.RId = Int32.Parse(objRow[conQxUserRoleRelationV2.RId].ToString().Trim()); //角色Id
objQxUserRoleRelationV2EN.QxPrjId = objRow[conQxUserRoleRelationV2.QxPrjId].ToString().Trim(); //项目Id
objQxUserRoleRelationV2EN.UpdDate = objRow[conQxUserRoleRelationV2.UpdDate] == DBNull.Value ? null : objRow[conQxUserRoleRelationV2.UpdDate].ToString().Trim(); //修改日期
objQxUserRoleRelationV2EN.UpdUserId = objRow[conQxUserRoleRelationV2.UpdUserId] == DBNull.Value ? null : objRow[conQxUserRoleRelationV2.UpdUserId].ToString().Trim(); //修改用户Id
objQxUserRoleRelationV2EN.Memo = objRow[conQxUserRoleRelationV2.Memo] == DBNull.Value ? null : objRow[conQxUserRoleRelationV2.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserRoleRelationV2EN.UId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserRoleRelationV2EN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objQxUserRoleRelationV2EN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxUserRoleRelationV2(ref clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN)
{
bool bolResult = QxUserRoleRelationV2DA.GetQxUserRoleRelationV2(ref objQxUserRoleRelationV2EN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "intUId">表关键字</param>
 /// <param name = "intRId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxUserRoleRelationV2EN GetObjByKeyLst(int intUId,int intRId)
{
if (intUId == 0)
{
var strMsg = string.Format("(errid:Busi000169)在表中,关键字[intUId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (intRId == 0)
{
var strMsg = string.Format("(errid:Busi000169)在表中,关键字[intRId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN = QxUserRoleRelationV2DA.GetObjByKeyLst(intUId,intRId);
return objQxUserRoleRelationV2EN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsQxUserRoleRelationV2EN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN = QxUserRoleRelationV2DA.GetFirstObj(strWhereCond);
 return objQxUserRoleRelationV2EN;
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
public static clsQxUserRoleRelationV2EN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN = QxUserRoleRelationV2DA.GetObjByDataRow(objRow);
 return objQxUserRoleRelationV2EN;
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
public static clsQxUserRoleRelationV2EN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN = QxUserRoleRelationV2DA.GetObjByDataRow(objRow);
 return objQxUserRoleRelationV2EN;
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
 /// <param name = "intUId">表关键字</param>
 /// <param name = "intRId">表关键字</param>
 /// <param name = "lstQxUserRoleRelationV2ObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxUserRoleRelationV2EN GetObjByKeyLstFromList(int intUId,int intRId, List<clsQxUserRoleRelationV2EN> lstQxUserRoleRelationV2ObjLst)
{
foreach (clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN in lstQxUserRoleRelationV2ObjLst)
{
if (objQxUserRoleRelationV2EN.UId == intUId 
 && objQxUserRoleRelationV2EN.RId == intRId 
)
{
return objQxUserRoleRelationV2EN;
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
public static int GetFirstID_S(string strWhereCond) 
{
 int intUId;
 try
 {
 intUId = new clsQxUserRoleRelationV2DA().GetFirstID(strWhereCond);
 return intUId;
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
 arrList = QxUserRoleRelationV2DA.GetID(strWhereCond);
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
bool bolIsExist = QxUserRoleRelationV2DA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "intUId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(int intUId,int intRId)
{
//检测记录是否存在
bool bolIsExist = QxUserRoleRelationV2DA.IsExist(intUId,intRId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "intUId">用户ID</param>
/// <param name = "intRId">角色Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(int intUId , int intRId, string strOpUser)
{
clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN = clsQxUserRoleRelationV2BL.GetObjByKeyLst(intUId,intRId);
objQxUserRoleRelationV2EN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objQxUserRoleRelationV2EN.UpdUserId = strOpUser;
return clsQxUserRoleRelationV2BL.UpdateBySql2(objQxUserRoleRelationV2EN);
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
 bolIsExist = clsQxUserRoleRelationV2DA.IsExistTable();
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
 bolIsExist = QxUserRoleRelationV2DA.IsExistTable(strTabName);
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
 /// <param name = "objQxUserRoleRelationV2EN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN)
{
try
{
bool bolResult = QxUserRoleRelationV2DA.AddNewRecordBySQL2(objQxUserRoleRelationV2EN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRoleRelationV2BL.ReFreshCache();

if (clsQxUserRoleRelationV2BL.relatedActions != null)
{
clsQxUserRoleRelationV2BL.relatedActions.UpdRelaTabDate(objQxUserRoleRelationV2EN.UId,objQxUserRoleRelationV2EN.RId, objQxUserRoleRelationV2EN.UpdUserId);
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
 /// <param name = "objQxUserRoleRelationV2EN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN)
{
try
{
string strKey = QxUserRoleRelationV2DA.AddNewRecordBySQL2WithReturnKey(objQxUserRoleRelationV2EN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRoleRelationV2BL.ReFreshCache();

if (clsQxUserRoleRelationV2BL.relatedActions != null)
{
clsQxUserRoleRelationV2BL.relatedActions.UpdRelaTabDate(objQxUserRoleRelationV2EN.UId,objQxUserRoleRelationV2EN.RId, objQxUserRoleRelationV2EN.UpdUserId);
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
 /// <param name = "strQxUserRoleRelationV2ObjXml">代表实体对象的XML串</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql_XML(string strQxUserRoleRelationV2ObjXml)
{
clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN = GetObjFromXmlStr(strQxUserRoleRelationV2ObjXml);
try
{
bool bolResult = QxUserRoleRelationV2DA.AddNewRecordBySQL2(objQxUserRoleRelationV2EN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRoleRelationV2BL.ReFreshCache();

if (clsQxUserRoleRelationV2BL.relatedActions != null)
{
clsQxUserRoleRelationV2BL.relatedActions.UpdRelaTabDate(objQxUserRoleRelationV2EN.UId,objQxUserRoleRelationV2EN.RId, objQxUserRoleRelationV2EN.UpdUserId);
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
 /// <param name = "objQxUserRoleRelationV2EN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN)
{
try
{
bool bolResult = QxUserRoleRelationV2DA.Update(objQxUserRoleRelationV2EN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRoleRelationV2BL.ReFreshCache();

if (clsQxUserRoleRelationV2BL.relatedActions != null)
{
clsQxUserRoleRelationV2BL.relatedActions.UpdRelaTabDate(objQxUserRoleRelationV2EN.UId,objQxUserRoleRelationV2EN.RId, objQxUserRoleRelationV2EN.UpdUserId);
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
 /// <param name = "objQxUserRoleRelationV2EN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN)
{
 if (objQxUserRoleRelationV2EN.UId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = QxUserRoleRelationV2DA.UpdateBySql2(objQxUserRoleRelationV2EN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRoleRelationV2BL.ReFreshCache();

if (clsQxUserRoleRelationV2BL.relatedActions != null)
{
clsQxUserRoleRelationV2BL.relatedActions.UpdRelaTabDate(objQxUserRoleRelationV2EN.UId,objQxUserRoleRelationV2EN.RId, objQxUserRoleRelationV2EN.UpdUserId);
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
 /// <param name = "strQxUserRoleRelationV2ObjXml">需要修改的对象,用XML来表示</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql_XML(string strQxUserRoleRelationV2ObjXml)
{
clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN = GetObjFromXmlStr(strQxUserRoleRelationV2ObjXml);
try
{
bool bolResult = QxUserRoleRelationV2DA.UpdateBySql2(objQxUserRoleRelationV2EN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRoleRelationV2BL.ReFreshCache();

if (clsQxUserRoleRelationV2BL.relatedActions != null)
{
clsQxUserRoleRelationV2BL.relatedActions.UpdRelaTabDate(objQxUserRoleRelationV2EN.UId,objQxUserRoleRelationV2EN.RId, objQxUserRoleRelationV2EN.UpdUserId);
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
 /// <param name = "intUId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(int intUId,int intRId)
{
try
{
 clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN = clsQxUserRoleRelationV2BL.GetObjByKeyLst(intUId,intRId);

if (clsQxUserRoleRelationV2BL.relatedActions != null)
{
clsQxUserRoleRelationV2BL.relatedActions.UpdRelaTabDate(objQxUserRoleRelationV2EN.UId,objQxUserRoleRelationV2EN.RId, objQxUserRoleRelationV2EN.UpdUserId);
}
if (objQxUserRoleRelationV2EN != null)
{
int intRecNum = QxUserRoleRelationV2DA.DelRecord(intUId,intRId);
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
/// <param name="intUId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(int intUId,int intRId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxUserRoleRelationV2DA.GetSpecSQLObj();
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
//删除与表:[QxUserRoleRelationV2]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conQxUserRoleRelationV2.UId,
//intUId);
//        clsQxUserRoleRelationV2BL.DelQxUserRoleRelationV2sByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxUserRoleRelationV2BL.DelRecord(intUId,intRId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxUserRoleRelationV2BLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
intUId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "intUId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(int intUId,int intRId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsQxUserRoleRelationV2BL.relatedActions != null)
{
clsQxUserRoleRelationV2BL.relatedActions.UpdRelaTabDate(intUId,intRId, "UpdRelaTabDate");
}
bool bolResult = QxUserRoleRelationV2DA.DelRecord(intUId,intRId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "intUId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(int intUId,int intRId) 
{
try
{
if (clsQxUserRoleRelationV2BL.relatedActions != null)
{
clsQxUserRoleRelationV2BL.relatedActions.UpdRelaTabDate(intUId,intRId, "UpdRelaTabDate");
}
bool bolResult = QxUserRoleRelationV2DA.DelRecordBySP(intUId,intRId);
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
 /// <param name = "arrUIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecKeyLsts(List<string> arrKeyLsts)
{
if (arrKeyLsts.Count == 0) return 0;
try
{
string[] sstrKey;
int intUId;
int intRId;
if (clsQxUserRoleRelationV2BL.relatedActions != null)
{
foreach (var strKeyLst in arrKeyLsts)
{
sstrKey = strKeyLst.Split('|');
intUId = int.Parse(sstrKey[0]);
intRId = int.Parse(sstrKey[1]);
clsQxUserRoleRelationV2BL.relatedActions.UpdRelaTabDate(intUId,intRId, "UpdRelaTabDate");
}
}
sstrKey = arrKeyLsts[0].Split('|');
intUId = int.Parse(sstrKey[0]);
intRId = int.Parse(sstrKey[1]);
int intDelRecNum = QxUserRoleRelationV2DA.DelRecKeyLsts(arrKeyLsts);
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
public static int DelQxUserRoleRelationV2sByCond(string strWhereCond)
{
try
{
int intRecNum = QxUserRoleRelationV2DA.DelQxUserRoleRelationV2(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[QxUserRoleRelationV2]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="intUId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(int intUId,int intRId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxUserRoleRelationV2DA.GetSpecSQLObj();
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
//删除与表:[QxUserRoleRelationV2]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxUserRoleRelationV2BL.DelRecord(intUId,intRId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxUserRoleRelationV2BL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
intUId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objQxUserRoleRelationV2ENS">源对象</param>
 /// <param name = "objQxUserRoleRelationV2ENT">目标对象</param>
 public static void CopyTo(clsQxUserRoleRelationV2EN objQxUserRoleRelationV2ENS, clsQxUserRoleRelationV2EN objQxUserRoleRelationV2ENT)
{
try
{
objQxUserRoleRelationV2ENT.UId = objQxUserRoleRelationV2ENS.UId; //用户ID
objQxUserRoleRelationV2ENT.RId = objQxUserRoleRelationV2ENS.RId; //角色Id
objQxUserRoleRelationV2ENT.QxPrjId = objQxUserRoleRelationV2ENS.QxPrjId; //项目Id
objQxUserRoleRelationV2ENT.UpdDate = objQxUserRoleRelationV2ENS.UpdDate; //修改日期
objQxUserRoleRelationV2ENT.UpdUserId = objQxUserRoleRelationV2ENS.UpdUserId; //修改用户Id
objQxUserRoleRelationV2ENT.Memo = objQxUserRoleRelationV2ENS.Memo; //备注
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
 /// <param name = "objQxUserRoleRelationV2EN">源简化对象</param>
 public static void SetUpdFlag(clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN)
{
try
{
objQxUserRoleRelationV2EN.ClearUpdateState();
   string strsfUpdFldSetStr = objQxUserRoleRelationV2EN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conQxUserRoleRelationV2.UId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserRoleRelationV2EN.UId = objQxUserRoleRelationV2EN.UId; //用户ID
}
if (arrFldSet.Contains(conQxUserRoleRelationV2.RId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserRoleRelationV2EN.RId = objQxUserRoleRelationV2EN.RId; //角色Id
}
if (arrFldSet.Contains(conQxUserRoleRelationV2.QxPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserRoleRelationV2EN.QxPrjId = objQxUserRoleRelationV2EN.QxPrjId; //项目Id
}
if (arrFldSet.Contains(conQxUserRoleRelationV2.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserRoleRelationV2EN.UpdDate = objQxUserRoleRelationV2EN.UpdDate == "[null]" ? null :  objQxUserRoleRelationV2EN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conQxUserRoleRelationV2.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserRoleRelationV2EN.UpdUserId = objQxUserRoleRelationV2EN.UpdUserId == "[null]" ? null :  objQxUserRoleRelationV2EN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conQxUserRoleRelationV2.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserRoleRelationV2EN.Memo = objQxUserRoleRelationV2EN.Memo == "[null]" ? null :  objQxUserRoleRelationV2EN.Memo; //备注
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
 /// <param name = "objQxUserRoleRelationV2EN">源简化对象</param>
 public static void AccessFldValueNull(clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN)
{
try
{
if (objQxUserRoleRelationV2EN.UpdDate == "[null]") objQxUserRoleRelationV2EN.UpdDate = null; //修改日期
if (objQxUserRoleRelationV2EN.UpdUserId == "[null]") objQxUserRoleRelationV2EN.UpdUserId = null; //修改用户Id
if (objQxUserRoleRelationV2EN.Memo == "[null]") objQxUserRoleRelationV2EN.Memo = null; //备注
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
public static void CheckPropertyNew(clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN)
{
 QxUserRoleRelationV2DA.CheckPropertyNew(objQxUserRoleRelationV2EN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN)
{
 QxUserRoleRelationV2DA.CheckProperty4Condition(objQxUserRoleRelationV2EN);
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
if (clsQxUserRoleRelationV2BL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxUserRoleRelationV2BL没有刷新缓存机制(clsQxUserRoleRelationV2BL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by UId");
//if (arrQxUserRoleRelationV2ObjLstCache == null)
//{
//arrQxUserRoleRelationV2ObjLstCache = QxUserRoleRelationV2DA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "intUId">表关键字</param>
 /// <param name = "intRId">表关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxUserRoleRelationV2EN GetObjByKeyLstCache(int intUId,int intRId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsQxUserRoleRelationV2EN._CurrTabName);
List<clsQxUserRoleRelationV2EN> arrQxUserRoleRelationV2ObjLstCache = GetObjLstCache();
IEnumerable <clsQxUserRoleRelationV2EN> arrQxUserRoleRelationV2ObjLst_Sel =
arrQxUserRoleRelationV2ObjLstCache
.Where(x=> x.UId == intUId 
 && x.RId == intRId 
);
if (arrQxUserRoleRelationV2ObjLst_Sel.Count() == 0)
{
   clsQxUserRoleRelationV2EN obj = clsQxUserRoleRelationV2BL.GetObjByKeyLst(intUId,intRId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrQxUserRoleRelationV2ObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxUserRoleRelationV2EN> GetAllQxUserRoleRelationV2ObjLstCache()
{
//获取缓存中的对象列表
List<clsQxUserRoleRelationV2EN> arrQxUserRoleRelationV2ObjLstCache = GetObjLstCache(); 
return arrQxUserRoleRelationV2ObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxUserRoleRelationV2EN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsQxUserRoleRelationV2EN._CurrTabName);
List<clsQxUserRoleRelationV2EN> arrQxUserRoleRelationV2ObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrQxUserRoleRelationV2ObjLstCache;
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
string strKey = string.Format("{0}", clsQxUserRoleRelationV2EN._CurrTabName);
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
if (clsQxUserRoleRelationV2BL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsQxUserRoleRelationV2EN._CurrTabName);
CacheHelper.Remove(strKey);
clsQxUserRoleRelationV2BL.objCommFun4BL.ReFreshCache();
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
 /// <param name = "lstQxUserRoleRelationV2ObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsQxUserRoleRelationV2EN> lstQxUserRoleRelationV2ObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstQxUserRoleRelationV2ObjLst, writer);
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
 /// <param name = "lstQxUserRoleRelationV2ObjLst">[clsQxUserRoleRelationV2EN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsQxUserRoleRelationV2EN> lstQxUserRoleRelationV2ObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsQxUserRoleRelationV2BL.listXmlNode);
writer.WriteStartElement(clsQxUserRoleRelationV2BL.itemsXmlNode);
foreach (clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN in lstQxUserRoleRelationV2ObjLst)
{
clsQxUserRoleRelationV2BL.SerializeXML(writer, objQxUserRoleRelationV2EN);
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
 /// <param name = "objQxUserRoleRelationV2EN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN)
{
writer.WriteStartElement(clsQxUserRoleRelationV2BL.itemXmlNode);
 
writer.WriteElementString(conQxUserRoleRelationV2.UId, objQxUserRoleRelationV2EN.UId.ToString(CultureInfo.InvariantCulture));
 
writer.WriteElementString(conQxUserRoleRelationV2.RId, objQxUserRoleRelationV2EN.RId.ToString(CultureInfo.InvariantCulture));
 
if (objQxUserRoleRelationV2EN.QxPrjId != null)
{
writer.WriteElementString(conQxUserRoleRelationV2.QxPrjId, objQxUserRoleRelationV2EN.QxPrjId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUserRoleRelationV2EN.UpdDate != null)
{
writer.WriteElementString(conQxUserRoleRelationV2.UpdDate, objQxUserRoleRelationV2EN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUserRoleRelationV2EN.UpdUserId != null)
{
writer.WriteElementString(conQxUserRoleRelationV2.UpdUserId, objQxUserRoleRelationV2EN.UpdUserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUserRoleRelationV2EN.Memo != null)
{
writer.WriteElementString(conQxUserRoleRelationV2.Memo, objQxUserRoleRelationV2EN.Memo.ToString(CultureInfo.InvariantCulture));
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
public static clsQxUserRoleRelationV2EN GetObjFromXml(System.Xml.XmlReader reader)
{
clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN = new clsQxUserRoleRelationV2EN();
reader.Read();
while (!(reader.Name == clsQxUserRoleRelationV2BL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(conQxUserRoleRelationV2.UId))
{
objQxUserRoleRelationV2EN.UId = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(conQxUserRoleRelationV2.RId))
{
objQxUserRoleRelationV2EN.RId = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(conQxUserRoleRelationV2.QxPrjId))
{
objQxUserRoleRelationV2EN.QxPrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUserRoleRelationV2.UpdDate))
{
objQxUserRoleRelationV2EN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUserRoleRelationV2.UpdUserId))
{
objQxUserRoleRelationV2EN.UpdUserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUserRoleRelationV2.Memo))
{
objQxUserRoleRelationV2EN.Memo = reader.ReadElementContentAsString();
}
}
return objQxUserRoleRelationV2EN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strQxUserRoleRelationV2ObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsQxUserRoleRelationV2EN GetObjFromXmlStr(string strQxUserRoleRelationV2ObjXmlStr)
{
clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN = new clsQxUserRoleRelationV2EN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strQxUserRoleRelationV2ObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsQxUserRoleRelationV2BL.itemXmlNode))
{
objQxUserRoleRelationV2EN = GetObjFromXml(reader);
return objQxUserRoleRelationV2EN;
}
}
return objQxUserRoleRelationV2EN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objQxUserRoleRelationV2EN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objQxUserRoleRelationV2EN);
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
public static string Func(string strInFldName, string strOutFldName, int intUId,int intRId)
{
if (strInFldName != conQxUserRoleRelationV2.UId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conQxUserRoleRelationV2.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conQxUserRoleRelationV2.AttributeName));
throw new Exception(strMsg);
}
var objQxUserRoleRelationV2 = clsQxUserRoleRelationV2BL.GetObjByKeyLstCache(intUId,intRId);
if (objQxUserRoleRelationV2 == null) return "";
return objQxUserRoleRelationV2[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objQxUserRoleRelationV2EN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsQxUserRoleRelationV2EN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objQxUserRoleRelationV2EN[strField]);
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
 /// <param name = "lstQxUserRoleRelationV2ObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsQxUserRoleRelationV2EN> lstQxUserRoleRelationV2ObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstQxUserRoleRelationV2ObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN in lstQxUserRoleRelationV2ObjLst)
{
string strJSON_One = SerializeObjToJSON(objQxUserRoleRelationV2EN);
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
int intRecCount = clsQxUserRoleRelationV2DA.GetRecCount(strTabName);
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
int intRecCount = clsQxUserRoleRelationV2DA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsQxUserRoleRelationV2DA.GetRecCount();
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
int intRecCount = clsQxUserRoleRelationV2DA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objQxUserRoleRelationV2Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsQxUserRoleRelationV2EN objQxUserRoleRelationV2Cond)
{
List<clsQxUserRoleRelationV2EN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxUserRoleRelationV2EN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxUserRoleRelationV2.AttributeName)
{
if (objQxUserRoleRelationV2Cond.IsUpdated(strFldName) == false) continue;
if (objQxUserRoleRelationV2Cond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUserRoleRelationV2Cond[strFldName].ToString());
}
else
{
if (objQxUserRoleRelationV2Cond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxUserRoleRelationV2Cond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUserRoleRelationV2Cond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxUserRoleRelationV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxUserRoleRelationV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxUserRoleRelationV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxUserRoleRelationV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxUserRoleRelationV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxUserRoleRelationV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxUserRoleRelationV2Cond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxUserRoleRelationV2Cond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxUserRoleRelationV2Cond[strFldName]));
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
 List<string> arrList = clsQxUserRoleRelationV2DA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = QxUserRoleRelationV2DA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = QxUserRoleRelationV2DA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = QxUserRoleRelationV2DA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxUserRoleRelationV2DA.SetFldValue(clsQxUserRoleRelationV2EN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = QxUserRoleRelationV2DA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxUserRoleRelationV2DA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxUserRoleRelationV2DA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxUserRoleRelationV2DA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[QxUserRoleRelationV2] "); 
 strCreateTabCode.Append(" ( "); 
 // /**用户ID*/ 
 strCreateTabCode.Append(" UId int primary key, "); 
 // /**角色Id*/ 
 strCreateTabCode.Append(" RId int primary key, "); 
 // /**项目Id*/ 
 strCreateTabCode.Append(" QxPrjId char(4) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**部门名*/ 
 strCreateTabCode.Append(" DepartmentName varchar(100) Null, "); 
 // /**部门类型名*/ 
 strCreateTabCode.Append(" DepartmentTypeName varchar(50) Null, "); 
 // /**角色名称*/ 
 strCreateTabCode.Append(" RoleName varchar(50) Null, "); 
 // /**用户名*/ 
 strCreateTabCode.Append(" UserName varchar(30) Null, "); 
 // /**工程名*/ 
 strCreateTabCode.Append(" PrjName varchar(30) Null, "); 
 // /**部门Id*/ 
 strCreateTabCode.Append(" DepartmentId varchar(8) Null, "); 
 // /**排序号*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**名称缩写*/ 
 strCreateTabCode.Append(" DepartmentAbbrName varchar(8) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 数据同步


 #endregion 数据同步
}
 /// <summary>
 /// 用户角色关系V2(QxUserRoleRelationV2)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4QxUserRoleRelationV2 : clsCommFun4BL
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
clsQxUserRoleRelationV2BL.ReFreshThisCache();
}
}

}