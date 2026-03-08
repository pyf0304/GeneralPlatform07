
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxPrjUserRelationBL
 表名:QxPrjUserRelation(00140031)
 * 版本:2023.12.07.1(服务器:WIN-SRV103-116)
 日期:2023/12/16 18:25:25
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
public static class  clsQxPrjUserRelationBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxPrjUserRelationEN GetObj(this K_mId_QxPrjUserRelation myKey)
{
clsQxPrjUserRelationEN objQxPrjUserRelationEN = clsQxPrjUserRelationBL.QxPrjUserRelationDA.GetObjBymId(myKey.Value);
return objQxPrjUserRelationEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQxPrjUserRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQxPrjUserRelationEN objQxPrjUserRelationEN)
{
if (CheckUniqueness(objQxPrjUserRelationEN) == false)
{
var strMsg = string.Format("记录已经存在!项目Id = [{0}],用户ID = [{1}]的数据已经存在!(in clsQxPrjUserRelationBL.AddNewRecord)", objQxPrjUserRelationEN.QxPrjId,objQxPrjUserRelationEN.UserId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsQxPrjUserRelationBL.QxPrjUserRelationDA.AddNewRecordBySQL2(objQxPrjUserRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjUserRelationBL.ReFreshCache();

if (clsQxPrjUserRelationBL.relatedActions != null)
{
clsQxPrjUserRelationBL.relatedActions.UpdRelaTabDate(objQxPrjUserRelationEN.mId, objQxPrjUserRelationEN.UpdUser);
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
public static bool AddRecordEx(this clsQxPrjUserRelationEN objQxPrjUserRelationEN)
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
objQxPrjUserRelationEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objQxPrjUserRelationEN.CheckUniqueness() == false)
{
strMsg = string.Format("(项目Id(QxPrjId)=[{0}],用户ID(UserId)=[{1}])已经存在,不能重复!", objQxPrjUserRelationEN.QxPrjId, objQxPrjUserRelationEN.UserId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objQxPrjUserRelationEN.AddNewRecord();
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
 /// <param name = "objQxPrjUserRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsQxPrjUserRelationEN objQxPrjUserRelationEN)
{
if (CheckUniqueness(objQxPrjUserRelationEN) == false)
{
var strMsg = string.Format("记录已经存在!项目Id = [{0}],用户ID = [{1}]的数据已经存在!(in clsQxPrjUserRelationBL.AddNewRecordWithReturnKey)", objQxPrjUserRelationEN.QxPrjId,objQxPrjUserRelationEN.UserId);
throw new Exception(strMsg);
}
try
{
string strKey = clsQxPrjUserRelationBL.QxPrjUserRelationDA.AddNewRecordBySQL2WithReturnKey(objQxPrjUserRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjUserRelationBL.ReFreshCache();

if (clsQxPrjUserRelationBL.relatedActions != null)
{
clsQxPrjUserRelationBL.relatedActions.UpdRelaTabDate(objQxPrjUserRelationEN.mId, objQxPrjUserRelationEN.UpdUser);
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
 /// <param name = "objQxPrjUserRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjUserRelationEN SetmId(this clsQxPrjUserRelationEN objQxPrjUserRelationEN, long lngmId, string strComparisonOp="")
	{
objQxPrjUserRelationEN.mId = lngmId; //流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjUserRelationEN.dicFldComparisonOp.ContainsKey(conQxPrjUserRelation.mId) == false)
{
objQxPrjUserRelationEN.dicFldComparisonOp.Add(conQxPrjUserRelation.mId, strComparisonOp);
}
else
{
objQxPrjUserRelationEN.dicFldComparisonOp[conQxPrjUserRelation.mId] = strComparisonOp;
}
}
return objQxPrjUserRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjUserRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjUserRelationEN SetQxPrjId(this clsQxPrjUserRelationEN objQxPrjUserRelationEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, conQxPrjUserRelation.QxPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQxPrjId, 4, conQxPrjUserRelation.QxPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, conQxPrjUserRelation.QxPrjId);
}
objQxPrjUserRelationEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjUserRelationEN.dicFldComparisonOp.ContainsKey(conQxPrjUserRelation.QxPrjId) == false)
{
objQxPrjUserRelationEN.dicFldComparisonOp.Add(conQxPrjUserRelation.QxPrjId, strComparisonOp);
}
else
{
objQxPrjUserRelationEN.dicFldComparisonOp[conQxPrjUserRelation.QxPrjId] = strComparisonOp;
}
}
return objQxPrjUserRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjUserRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjUserRelationEN SetUserId(this clsQxPrjUserRelationEN objQxPrjUserRelationEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, conQxPrjUserRelation.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conQxPrjUserRelation.UserId);
}
objQxPrjUserRelationEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjUserRelationEN.dicFldComparisonOp.ContainsKey(conQxPrjUserRelation.UserId) == false)
{
objQxPrjUserRelationEN.dicFldComparisonOp.Add(conQxPrjUserRelation.UserId, strComparisonOp);
}
else
{
objQxPrjUserRelationEN.dicFldComparisonOp[conQxPrjUserRelation.UserId] = strComparisonOp;
}
}
return objQxPrjUserRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjUserRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjUserRelationEN SetUpdDate(this clsQxPrjUserRelationEN objQxPrjUserRelationEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQxPrjUserRelation.UpdDate);
}
objQxPrjUserRelationEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjUserRelationEN.dicFldComparisonOp.ContainsKey(conQxPrjUserRelation.UpdDate) == false)
{
objQxPrjUserRelationEN.dicFldComparisonOp.Add(conQxPrjUserRelation.UpdDate, strComparisonOp);
}
else
{
objQxPrjUserRelationEN.dicFldComparisonOp[conQxPrjUserRelation.UpdDate] = strComparisonOp;
}
}
return objQxPrjUserRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjUserRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjUserRelationEN SetUpdUser(this clsQxPrjUserRelationEN objQxPrjUserRelationEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conQxPrjUserRelation.UpdUser);
}
objQxPrjUserRelationEN.UpdUser = strUpdUser; //修改用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjUserRelationEN.dicFldComparisonOp.ContainsKey(conQxPrjUserRelation.UpdUser) == false)
{
objQxPrjUserRelationEN.dicFldComparisonOp.Add(conQxPrjUserRelation.UpdUser, strComparisonOp);
}
else
{
objQxPrjUserRelationEN.dicFldComparisonOp[conQxPrjUserRelation.UpdUser] = strComparisonOp;
}
}
return objQxPrjUserRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjUserRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjUserRelationEN SetMemo(this clsQxPrjUserRelationEN objQxPrjUserRelationEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQxPrjUserRelation.Memo);
}
objQxPrjUserRelationEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjUserRelationEN.dicFldComparisonOp.ContainsKey(conQxPrjUserRelation.Memo) == false)
{
objQxPrjUserRelationEN.dicFldComparisonOp.Add(conQxPrjUserRelation.Memo, strComparisonOp);
}
else
{
objQxPrjUserRelationEN.dicFldComparisonOp[conQxPrjUserRelation.Memo] = strComparisonOp;
}
}
return objQxPrjUserRelationEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objQxPrjUserRelationEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsQxPrjUserRelationEN objQxPrjUserRelationEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objQxPrjUserRelationEN.CheckPropertyNew();
clsQxPrjUserRelationEN objQxPrjUserRelationCond = new clsQxPrjUserRelationEN();
string strCondition = objQxPrjUserRelationCond
.SetmId(objQxPrjUserRelationEN.mId, "<>")
.SetQxPrjId(objQxPrjUserRelationEN.QxPrjId, "=")
.SetUserId(objQxPrjUserRelationEN.UserId, "=")
.GetCombineCondition();
objQxPrjUserRelationEN._IsCheckProperty = true;
bool bolIsExist = clsQxPrjUserRelationBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(QxPrjId_UserId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objQxPrjUserRelationEN.Update();
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
 /// <param name = "objQxPrjUserRelation">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsQxPrjUserRelationEN objQxPrjUserRelation)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsQxPrjUserRelationEN objQxPrjUserRelationCond = new clsQxPrjUserRelationEN();
string strCondition = objQxPrjUserRelationCond
.SetQxPrjId(objQxPrjUserRelation.QxPrjId, "=")
.SetUserId(objQxPrjUserRelation.UserId, "=")
.GetCombineCondition();
objQxPrjUserRelation._IsCheckProperty = true;
bool bolIsExist = clsQxPrjUserRelationBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objQxPrjUserRelation.mId = clsQxPrjUserRelationBL.GetFirstID_S(strCondition);
objQxPrjUserRelation.UpdateWithCondition(strCondition);
}
else
{
objQxPrjUserRelation.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objQxPrjUserRelationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxPrjUserRelationEN objQxPrjUserRelationEN)
{
 if (objQxPrjUserRelationEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxPrjUserRelationBL.QxPrjUserRelationDA.UpdateBySql2(objQxPrjUserRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjUserRelationBL.ReFreshCache();

if (clsQxPrjUserRelationBL.relatedActions != null)
{
clsQxPrjUserRelationBL.relatedActions.UpdRelaTabDate(objQxPrjUserRelationEN.mId, objQxPrjUserRelationEN.UpdUser);
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
 /// <param name = "objQxPrjUserRelationEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxPrjUserRelationEN objQxPrjUserRelationEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objQxPrjUserRelationEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxPrjUserRelationBL.QxPrjUserRelationDA.UpdateBySql2(objQxPrjUserRelationEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjUserRelationBL.ReFreshCache();

if (clsQxPrjUserRelationBL.relatedActions != null)
{
clsQxPrjUserRelationBL.relatedActions.UpdRelaTabDate(objQxPrjUserRelationEN.mId, objQxPrjUserRelationEN.UpdUser);
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
 /// <param name = "objQxPrjUserRelationEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxPrjUserRelationEN objQxPrjUserRelationEN, string strWhereCond)
{
try
{
bool bolResult = clsQxPrjUserRelationBL.QxPrjUserRelationDA.UpdateBySqlWithCondition(objQxPrjUserRelationEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjUserRelationBL.ReFreshCache();

if (clsQxPrjUserRelationBL.relatedActions != null)
{
clsQxPrjUserRelationBL.relatedActions.UpdRelaTabDate(objQxPrjUserRelationEN.mId, objQxPrjUserRelationEN.UpdUser);
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
 /// <param name = "objQxPrjUserRelationEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxPrjUserRelationEN objQxPrjUserRelationEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsQxPrjUserRelationBL.QxPrjUserRelationDA.UpdateBySqlWithConditionTransaction(objQxPrjUserRelationEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjUserRelationBL.ReFreshCache();

if (clsQxPrjUserRelationBL.relatedActions != null)
{
clsQxPrjUserRelationBL.relatedActions.UpdRelaTabDate(objQxPrjUserRelationEN.mId, objQxPrjUserRelationEN.UpdUser);
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
public static int Delete(this clsQxPrjUserRelationEN objQxPrjUserRelationEN)
{
try
{
int intRecNum = clsQxPrjUserRelationBL.QxPrjUserRelationDA.DelRecord(objQxPrjUserRelationEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjUserRelationBL.ReFreshCache();

if (clsQxPrjUserRelationBL.relatedActions != null)
{
clsQxPrjUserRelationBL.relatedActions.UpdRelaTabDate(objQxPrjUserRelationEN.mId, objQxPrjUserRelationEN.UpdUser);
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
 /// <param name = "objQxPrjUserRelationENS">源对象</param>
 /// <param name = "objQxPrjUserRelationENT">目标对象</param>
 public static void CopyTo(this clsQxPrjUserRelationEN objQxPrjUserRelationENS, clsQxPrjUserRelationEN objQxPrjUserRelationENT)
{
try
{
objQxPrjUserRelationENT.mId = objQxPrjUserRelationENS.mId; //流水号
objQxPrjUserRelationENT.QxPrjId = objQxPrjUserRelationENS.QxPrjId; //项目Id
objQxPrjUserRelationENT.UserId = objQxPrjUserRelationENS.UserId; //用户ID
objQxPrjUserRelationENT.UpdDate = objQxPrjUserRelationENS.UpdDate; //修改日期
objQxPrjUserRelationENT.UpdUser = objQxPrjUserRelationENS.UpdUser; //修改用户
objQxPrjUserRelationENT.Memo = objQxPrjUserRelationENS.Memo; //备注
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
 /// <param name = "objQxPrjUserRelationENS">源对象</param>
 /// <returns>目标对象=>clsQxPrjUserRelationEN:objQxPrjUserRelationENT</returns>
 public static clsQxPrjUserRelationEN CopyTo(this clsQxPrjUserRelationEN objQxPrjUserRelationENS)
{
try
{
 clsQxPrjUserRelationEN objQxPrjUserRelationENT = new clsQxPrjUserRelationEN()
{
mId = objQxPrjUserRelationENS.mId, //流水号
QxPrjId = objQxPrjUserRelationENS.QxPrjId, //项目Id
UserId = objQxPrjUserRelationENS.UserId, //用户ID
UpdDate = objQxPrjUserRelationENS.UpdDate, //修改日期
UpdUser = objQxPrjUserRelationENS.UpdUser, //修改用户
Memo = objQxPrjUserRelationENS.Memo, //备注
};
 return objQxPrjUserRelationENT;
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
public static void CheckPropertyNew(this clsQxPrjUserRelationEN objQxPrjUserRelationEN)
{
 clsQxPrjUserRelationBL.QxPrjUserRelationDA.CheckPropertyNew(objQxPrjUserRelationEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsQxPrjUserRelationEN objQxPrjUserRelationEN)
{
 clsQxPrjUserRelationBL.QxPrjUserRelationDA.CheckProperty4Condition(objQxPrjUserRelationEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQxPrjUserRelationEN objQxPrjUserRelationCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQxPrjUserRelationCond.IsUpdated(conQxPrjUserRelation.mId) == true)
{
string strComparisonOpmId = objQxPrjUserRelationCond.dicFldComparisonOp[conQxPrjUserRelation.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conQxPrjUserRelation.mId, objQxPrjUserRelationCond.mId, strComparisonOpmId);
}
if (objQxPrjUserRelationCond.IsUpdated(conQxPrjUserRelation.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objQxPrjUserRelationCond.dicFldComparisonOp[conQxPrjUserRelation.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjUserRelation.QxPrjId, objQxPrjUserRelationCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objQxPrjUserRelationCond.IsUpdated(conQxPrjUserRelation.UserId) == true)
{
string strComparisonOpUserId = objQxPrjUserRelationCond.dicFldComparisonOp[conQxPrjUserRelation.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjUserRelation.UserId, objQxPrjUserRelationCond.UserId, strComparisonOpUserId);
}
if (objQxPrjUserRelationCond.IsUpdated(conQxPrjUserRelation.UpdDate) == true)
{
string strComparisonOpUpdDate = objQxPrjUserRelationCond.dicFldComparisonOp[conQxPrjUserRelation.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjUserRelation.UpdDate, objQxPrjUserRelationCond.UpdDate, strComparisonOpUpdDate);
}
if (objQxPrjUserRelationCond.IsUpdated(conQxPrjUserRelation.UpdUser) == true)
{
string strComparisonOpUpdUser = objQxPrjUserRelationCond.dicFldComparisonOp[conQxPrjUserRelation.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjUserRelation.UpdUser, objQxPrjUserRelationCond.UpdUser, strComparisonOpUpdUser);
}
if (objQxPrjUserRelationCond.IsUpdated(conQxPrjUserRelation.Memo) == true)
{
string strComparisonOpMemo = objQxPrjUserRelationCond.dicFldComparisonOp[conQxPrjUserRelation.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjUserRelation.Memo, objQxPrjUserRelationCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--QxPrjUserRelation(工程用户关系), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:QxPrjId_UserId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objQxPrjUserRelationEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsQxPrjUserRelationEN objQxPrjUserRelationEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objQxPrjUserRelationEN == null) return true;
if (objQxPrjUserRelationEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxPrjUserRelationEN.QxPrjId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objQxPrjUserRelationEN.UserId);
if (clsQxPrjUserRelationBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objQxPrjUserRelationEN.mId);
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxPrjUserRelationEN.QxPrjId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objQxPrjUserRelationEN.UserId);
if (clsQxPrjUserRelationBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--QxPrjUserRelation(工程用户关系), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:QxPrjId_UserId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objQxPrjUserRelationEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsQxPrjUserRelationEN objQxPrjUserRelationEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objQxPrjUserRelationEN == null) return "";
if (objQxPrjUserRelationEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxPrjUserRelationEN.QxPrjId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objQxPrjUserRelationEN.UserId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objQxPrjUserRelationEN.mId);
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxPrjUserRelationEN.QxPrjId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objQxPrjUserRelationEN.UserId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_QxPrjUserRelation
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 工程用户关系(QxPrjUserRelation)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsQxPrjUserRelationBL
{
public static RelatedActions_QxPrjUserRelation relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "QxPrjUserRelationListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "QxPrjUserRelationList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsQxPrjUserRelationEN> arrQxPrjUserRelationObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsQxPrjUserRelationDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsQxPrjUserRelationDA QxPrjUserRelationDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsQxPrjUserRelationDA();
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
 public clsQxPrjUserRelationBL()
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
if (string.IsNullOrEmpty(clsQxPrjUserRelationEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxPrjUserRelationEN._ConnectString);
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
objDS = QxPrjUserRelationDA.GetDataSet(strWhereCond);
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
objDS = QxPrjUserRelationDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = QxPrjUserRelationDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_QxPrjUserRelation(string strWhereCond)
{
DataTable objDT;
try
{
objDT = QxPrjUserRelationDA.GetDataTable_QxPrjUserRelation(strWhereCond);
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
objDT = QxPrjUserRelationDA.GetDataTable(strWhereCond);
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
objDT = QxPrjUserRelationDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = QxPrjUserRelationDA.GetDataTable(strWhereCond, strTabName);
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
objDT = QxPrjUserRelationDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = QxPrjUserRelationDA.GetDataTable_Top(objTopPara);
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
objDT = QxPrjUserRelationDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = QxPrjUserRelationDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = QxPrjUserRelationDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = QxPrjUserRelationDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = QxPrjUserRelationDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = QxPrjUserRelationDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = QxPrjUserRelationDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = QxPrjUserRelationDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
public static List<clsQxPrjUserRelationEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsQxPrjUserRelationEN> arrObjLst = new List<clsQxPrjUserRelationEN>(); 
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
	clsQxPrjUserRelationEN objQxPrjUserRelationEN = new clsQxPrjUserRelationEN();
try
{
objQxPrjUserRelationEN.mId = Int32.Parse(objRow[conQxPrjUserRelation.mId].ToString().Trim()); //流水号
objQxPrjUserRelationEN.QxPrjId = objRow[conQxPrjUserRelation.QxPrjId].ToString().Trim(); //项目Id
objQxPrjUserRelationEN.UserId = objRow[conQxPrjUserRelation.UserId].ToString().Trim(); //用户ID
objQxPrjUserRelationEN.UpdDate = objRow[conQxPrjUserRelation.UpdDate] == DBNull.Value ? null : objRow[conQxPrjUserRelation.UpdDate].ToString().Trim(); //修改日期
objQxPrjUserRelationEN.UpdUser = objRow[conQxPrjUserRelation.UpdUser] == DBNull.Value ? null : objRow[conQxPrjUserRelation.UpdUser].ToString().Trim(); //修改用户
objQxPrjUserRelationEN.Memo = objRow[conQxPrjUserRelation.Memo] == DBNull.Value ? null : objRow[conQxPrjUserRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjUserRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjUserRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsQxPrjUserRelationEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsQxPrjUserRelationEN._CurrTabName);
List<clsQxPrjUserRelationEN> arrQxPrjUserRelationObjLstCache = GetObjLstCache();
IEnumerable <clsQxPrjUserRelationEN> arrQxPrjUserRelationObjLst_Sel =
arrQxPrjUserRelationObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrQxPrjUserRelationObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPrjUserRelationEN> GetObjLst(string strWhereCond)
{
List<clsQxPrjUserRelationEN> arrObjLst = new List<clsQxPrjUserRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjUserRelationEN objQxPrjUserRelationEN = new clsQxPrjUserRelationEN();
try
{
objQxPrjUserRelationEN.mId = Int32.Parse(objRow[conQxPrjUserRelation.mId].ToString().Trim()); //流水号
objQxPrjUserRelationEN.QxPrjId = objRow[conQxPrjUserRelation.QxPrjId].ToString().Trim(); //项目Id
objQxPrjUserRelationEN.UserId = objRow[conQxPrjUserRelation.UserId].ToString().Trim(); //用户ID
objQxPrjUserRelationEN.UpdDate = objRow[conQxPrjUserRelation.UpdDate] == DBNull.Value ? null : objRow[conQxPrjUserRelation.UpdDate].ToString().Trim(); //修改日期
objQxPrjUserRelationEN.UpdUser = objRow[conQxPrjUserRelation.UpdUser] == DBNull.Value ? null : objRow[conQxPrjUserRelation.UpdUser].ToString().Trim(); //修改用户
objQxPrjUserRelationEN.Memo = objRow[conQxPrjUserRelation.Memo] == DBNull.Value ? null : objRow[conQxPrjUserRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjUserRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjUserRelationEN);
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
public static List<clsQxPrjUserRelationEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsQxPrjUserRelationEN> arrObjLst = new List<clsQxPrjUserRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjUserRelationEN objQxPrjUserRelationEN = new clsQxPrjUserRelationEN();
try
{
objQxPrjUserRelationEN.mId = Int32.Parse(objRow[conQxPrjUserRelation.mId].ToString().Trim()); //流水号
objQxPrjUserRelationEN.QxPrjId = objRow[conQxPrjUserRelation.QxPrjId].ToString().Trim(); //项目Id
objQxPrjUserRelationEN.UserId = objRow[conQxPrjUserRelation.UserId].ToString().Trim(); //用户ID
objQxPrjUserRelationEN.UpdDate = objRow[conQxPrjUserRelation.UpdDate] == DBNull.Value ? null : objRow[conQxPrjUserRelation.UpdDate].ToString().Trim(); //修改日期
objQxPrjUserRelationEN.UpdUser = objRow[conQxPrjUserRelation.UpdUser] == DBNull.Value ? null : objRow[conQxPrjUserRelation.UpdUser].ToString().Trim(); //修改用户
objQxPrjUserRelationEN.Memo = objRow[conQxPrjUserRelation.Memo] == DBNull.Value ? null : objRow[conQxPrjUserRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjUserRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjUserRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objQxPrjUserRelationCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsQxPrjUserRelationEN> GetSubObjLstCache(clsQxPrjUserRelationEN objQxPrjUserRelationCond)
{
List<clsQxPrjUserRelationEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxPrjUserRelationEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxPrjUserRelation.AttributeName)
{
if (objQxPrjUserRelationCond.IsUpdated(strFldName) == false) continue;
if (objQxPrjUserRelationCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxPrjUserRelationCond[strFldName].ToString());
}
else
{
if (objQxPrjUserRelationCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxPrjUserRelationCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxPrjUserRelationCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxPrjUserRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxPrjUserRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxPrjUserRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxPrjUserRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxPrjUserRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxPrjUserRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxPrjUserRelationCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxPrjUserRelationCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxPrjUserRelationCond[strFldName]));
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
public static List<clsQxPrjUserRelationEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsQxPrjUserRelationEN> arrObjLst = new List<clsQxPrjUserRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjUserRelationEN objQxPrjUserRelationEN = new clsQxPrjUserRelationEN();
try
{
objQxPrjUserRelationEN.mId = Int32.Parse(objRow[conQxPrjUserRelation.mId].ToString().Trim()); //流水号
objQxPrjUserRelationEN.QxPrjId = objRow[conQxPrjUserRelation.QxPrjId].ToString().Trim(); //项目Id
objQxPrjUserRelationEN.UserId = objRow[conQxPrjUserRelation.UserId].ToString().Trim(); //用户ID
objQxPrjUserRelationEN.UpdDate = objRow[conQxPrjUserRelation.UpdDate] == DBNull.Value ? null : objRow[conQxPrjUserRelation.UpdDate].ToString().Trim(); //修改日期
objQxPrjUserRelationEN.UpdUser = objRow[conQxPrjUserRelation.UpdUser] == DBNull.Value ? null : objRow[conQxPrjUserRelation.UpdUser].ToString().Trim(); //修改用户
objQxPrjUserRelationEN.Memo = objRow[conQxPrjUserRelation.Memo] == DBNull.Value ? null : objRow[conQxPrjUserRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjUserRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjUserRelationEN);
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
public static List<clsQxPrjUserRelationEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsQxPrjUserRelationEN> arrObjLst = new List<clsQxPrjUserRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjUserRelationEN objQxPrjUserRelationEN = new clsQxPrjUserRelationEN();
try
{
objQxPrjUserRelationEN.mId = Int32.Parse(objRow[conQxPrjUserRelation.mId].ToString().Trim()); //流水号
objQxPrjUserRelationEN.QxPrjId = objRow[conQxPrjUserRelation.QxPrjId].ToString().Trim(); //项目Id
objQxPrjUserRelationEN.UserId = objRow[conQxPrjUserRelation.UserId].ToString().Trim(); //用户ID
objQxPrjUserRelationEN.UpdDate = objRow[conQxPrjUserRelation.UpdDate] == DBNull.Value ? null : objRow[conQxPrjUserRelation.UpdDate].ToString().Trim(); //修改日期
objQxPrjUserRelationEN.UpdUser = objRow[conQxPrjUserRelation.UpdUser] == DBNull.Value ? null : objRow[conQxPrjUserRelation.UpdUser].ToString().Trim(); //修改用户
objQxPrjUserRelationEN.Memo = objRow[conQxPrjUserRelation.Memo] == DBNull.Value ? null : objRow[conQxPrjUserRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjUserRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjUserRelationEN);
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
List<clsQxPrjUserRelationEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsQxPrjUserRelationEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPrjUserRelationEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsQxPrjUserRelationEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsQxPrjUserRelationEN> arrObjLst = new List<clsQxPrjUserRelationEN>(); 
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
	clsQxPrjUserRelationEN objQxPrjUserRelationEN = new clsQxPrjUserRelationEN();
try
{
objQxPrjUserRelationEN.mId = Int32.Parse(objRow[conQxPrjUserRelation.mId].ToString().Trim()); //流水号
objQxPrjUserRelationEN.QxPrjId = objRow[conQxPrjUserRelation.QxPrjId].ToString().Trim(); //项目Id
objQxPrjUserRelationEN.UserId = objRow[conQxPrjUserRelation.UserId].ToString().Trim(); //用户ID
objQxPrjUserRelationEN.UpdDate = objRow[conQxPrjUserRelation.UpdDate] == DBNull.Value ? null : objRow[conQxPrjUserRelation.UpdDate].ToString().Trim(); //修改日期
objQxPrjUserRelationEN.UpdUser = objRow[conQxPrjUserRelation.UpdUser] == DBNull.Value ? null : objRow[conQxPrjUserRelation.UpdUser].ToString().Trim(); //修改用户
objQxPrjUserRelationEN.Memo = objRow[conQxPrjUserRelation.Memo] == DBNull.Value ? null : objRow[conQxPrjUserRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjUserRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjUserRelationEN);
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
public static List<clsQxPrjUserRelationEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsQxPrjUserRelationEN> arrObjLst = new List<clsQxPrjUserRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjUserRelationEN objQxPrjUserRelationEN = new clsQxPrjUserRelationEN();
try
{
objQxPrjUserRelationEN.mId = Int32.Parse(objRow[conQxPrjUserRelation.mId].ToString().Trim()); //流水号
objQxPrjUserRelationEN.QxPrjId = objRow[conQxPrjUserRelation.QxPrjId].ToString().Trim(); //项目Id
objQxPrjUserRelationEN.UserId = objRow[conQxPrjUserRelation.UserId].ToString().Trim(); //用户ID
objQxPrjUserRelationEN.UpdDate = objRow[conQxPrjUserRelation.UpdDate] == DBNull.Value ? null : objRow[conQxPrjUserRelation.UpdDate].ToString().Trim(); //修改日期
objQxPrjUserRelationEN.UpdUser = objRow[conQxPrjUserRelation.UpdUser] == DBNull.Value ? null : objRow[conQxPrjUserRelation.UpdUser].ToString().Trim(); //修改用户
objQxPrjUserRelationEN.Memo = objRow[conQxPrjUserRelation.Memo] == DBNull.Value ? null : objRow[conQxPrjUserRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjUserRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjUserRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsQxPrjUserRelationEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsQxPrjUserRelationEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsQxPrjUserRelationEN> arrObjLst = new List<clsQxPrjUserRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjUserRelationEN objQxPrjUserRelationEN = new clsQxPrjUserRelationEN();
try
{
objQxPrjUserRelationEN.mId = Int32.Parse(objRow[conQxPrjUserRelation.mId].ToString().Trim()); //流水号
objQxPrjUserRelationEN.QxPrjId = objRow[conQxPrjUserRelation.QxPrjId].ToString().Trim(); //项目Id
objQxPrjUserRelationEN.UserId = objRow[conQxPrjUserRelation.UserId].ToString().Trim(); //用户ID
objQxPrjUserRelationEN.UpdDate = objRow[conQxPrjUserRelation.UpdDate] == DBNull.Value ? null : objRow[conQxPrjUserRelation.UpdDate].ToString().Trim(); //修改日期
objQxPrjUserRelationEN.UpdUser = objRow[conQxPrjUserRelation.UpdUser] == DBNull.Value ? null : objRow[conQxPrjUserRelation.UpdUser].ToString().Trim(); //修改用户
objQxPrjUserRelationEN.Memo = objRow[conQxPrjUserRelation.Memo] == DBNull.Value ? null : objRow[conQxPrjUserRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjUserRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjUserRelationEN);
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
public static List<clsQxPrjUserRelationEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsQxPrjUserRelationEN> arrObjLst = new List<clsQxPrjUserRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjUserRelationEN objQxPrjUserRelationEN = new clsQxPrjUserRelationEN();
try
{
objQxPrjUserRelationEN.mId = Int32.Parse(objRow[conQxPrjUserRelation.mId].ToString().Trim()); //流水号
objQxPrjUserRelationEN.QxPrjId = objRow[conQxPrjUserRelation.QxPrjId].ToString().Trim(); //项目Id
objQxPrjUserRelationEN.UserId = objRow[conQxPrjUserRelation.UserId].ToString().Trim(); //用户ID
objQxPrjUserRelationEN.UpdDate = objRow[conQxPrjUserRelation.UpdDate] == DBNull.Value ? null : objRow[conQxPrjUserRelation.UpdDate].ToString().Trim(); //修改日期
objQxPrjUserRelationEN.UpdUser = objRow[conQxPrjUserRelation.UpdUser] == DBNull.Value ? null : objRow[conQxPrjUserRelation.UpdUser].ToString().Trim(); //修改用户
objQxPrjUserRelationEN.Memo = objRow[conQxPrjUserRelation.Memo] == DBNull.Value ? null : objRow[conQxPrjUserRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjUserRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjUserRelationEN);
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
public static IEnumerable<clsQxPrjUserRelationEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsQxPrjUserRelationEN objQxPrjUserRelationCond, string strOrderBy)
{
List<clsQxPrjUserRelationEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxPrjUserRelationEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxPrjUserRelation.AttributeName)
{
if (objQxPrjUserRelationCond.IsUpdated(strFldName) == false) continue;
if (objQxPrjUserRelationCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxPrjUserRelationCond[strFldName].ToString());
}
else
{
if (objQxPrjUserRelationCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxPrjUserRelationCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxPrjUserRelationCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxPrjUserRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxPrjUserRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxPrjUserRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxPrjUserRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxPrjUserRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxPrjUserRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxPrjUserRelationCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxPrjUserRelationCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxPrjUserRelationCond[strFldName]));
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
public static IEnumerable<clsQxPrjUserRelationEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsQxPrjUserRelationEN objQxPrjUserRelationCond = JsonConvert.DeserializeObject<clsQxPrjUserRelationEN>(objPagerPara.whereCond);
if (objQxPrjUserRelationCond.sfFldComparisonOp == null)
{
objQxPrjUserRelationCond.dicFldComparisonOp = null;
}
else
{
objQxPrjUserRelationCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objQxPrjUserRelationCond.sfFldComparisonOp);
}
clsQxPrjUserRelationBL.SetUpdFlag(objQxPrjUserRelationCond);
 try
{
CheckProperty4Condition(objQxPrjUserRelationCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsQxPrjUserRelationBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objQxPrjUserRelationCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPrjUserRelationEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsQxPrjUserRelationEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsQxPrjUserRelationEN> arrObjLst = new List<clsQxPrjUserRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjUserRelationEN objQxPrjUserRelationEN = new clsQxPrjUserRelationEN();
try
{
objQxPrjUserRelationEN.mId = Int32.Parse(objRow[conQxPrjUserRelation.mId].ToString().Trim()); //流水号
objQxPrjUserRelationEN.QxPrjId = objRow[conQxPrjUserRelation.QxPrjId].ToString().Trim(); //项目Id
objQxPrjUserRelationEN.UserId = objRow[conQxPrjUserRelation.UserId].ToString().Trim(); //用户ID
objQxPrjUserRelationEN.UpdDate = objRow[conQxPrjUserRelation.UpdDate] == DBNull.Value ? null : objRow[conQxPrjUserRelation.UpdDate].ToString().Trim(); //修改日期
objQxPrjUserRelationEN.UpdUser = objRow[conQxPrjUserRelation.UpdUser] == DBNull.Value ? null : objRow[conQxPrjUserRelation.UpdUser].ToString().Trim(); //修改用户
objQxPrjUserRelationEN.Memo = objRow[conQxPrjUserRelation.Memo] == DBNull.Value ? null : objRow[conQxPrjUserRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjUserRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjUserRelationEN);
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
public static List<clsQxPrjUserRelationEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsQxPrjUserRelationEN> arrObjLst = new List<clsQxPrjUserRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjUserRelationEN objQxPrjUserRelationEN = new clsQxPrjUserRelationEN();
try
{
objQxPrjUserRelationEN.mId = Int32.Parse(objRow[conQxPrjUserRelation.mId].ToString().Trim()); //流水号
objQxPrjUserRelationEN.QxPrjId = objRow[conQxPrjUserRelation.QxPrjId].ToString().Trim(); //项目Id
objQxPrjUserRelationEN.UserId = objRow[conQxPrjUserRelation.UserId].ToString().Trim(); //用户ID
objQxPrjUserRelationEN.UpdDate = objRow[conQxPrjUserRelation.UpdDate] == DBNull.Value ? null : objRow[conQxPrjUserRelation.UpdDate].ToString().Trim(); //修改日期
objQxPrjUserRelationEN.UpdUser = objRow[conQxPrjUserRelation.UpdUser] == DBNull.Value ? null : objRow[conQxPrjUserRelation.UpdUser].ToString().Trim(); //修改用户
objQxPrjUserRelationEN.Memo = objRow[conQxPrjUserRelation.Memo] == DBNull.Value ? null : objRow[conQxPrjUserRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjUserRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjUserRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPrjUserRelationEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsQxPrjUserRelationEN> arrObjLst = new List<clsQxPrjUserRelationEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjUserRelationEN objQxPrjUserRelationEN = new clsQxPrjUserRelationEN();
try
{
objQxPrjUserRelationEN.mId = Int32.Parse(objRow[conQxPrjUserRelation.mId].ToString().Trim()); //流水号
objQxPrjUserRelationEN.QxPrjId = objRow[conQxPrjUserRelation.QxPrjId].ToString().Trim(); //项目Id
objQxPrjUserRelationEN.UserId = objRow[conQxPrjUserRelation.UserId].ToString().Trim(); //用户ID
objQxPrjUserRelationEN.UpdDate = objRow[conQxPrjUserRelation.UpdDate] == DBNull.Value ? null : objRow[conQxPrjUserRelation.UpdDate].ToString().Trim(); //修改日期
objQxPrjUserRelationEN.UpdUser = objRow[conQxPrjUserRelation.UpdUser] == DBNull.Value ? null : objRow[conQxPrjUserRelation.UpdUser].ToString().Trim(); //修改用户
objQxPrjUserRelationEN.Memo = objRow[conQxPrjUserRelation.Memo] == DBNull.Value ? null : objRow[conQxPrjUserRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxPrjUserRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxPrjUserRelationEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objQxPrjUserRelationEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxPrjUserRelation(ref clsQxPrjUserRelationEN objQxPrjUserRelationEN)
{
bool bolResult = QxPrjUserRelationDA.GetQxPrjUserRelation(ref objQxPrjUserRelationEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxPrjUserRelationEN GetObjBymId(long lngmId)
{
clsQxPrjUserRelationEN objQxPrjUserRelationEN = QxPrjUserRelationDA.GetObjBymId(lngmId);
return objQxPrjUserRelationEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsQxPrjUserRelationEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsQxPrjUserRelationEN objQxPrjUserRelationEN = QxPrjUserRelationDA.GetFirstObj(strWhereCond);
 return objQxPrjUserRelationEN;
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
public static clsQxPrjUserRelationEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsQxPrjUserRelationEN objQxPrjUserRelationEN = QxPrjUserRelationDA.GetObjByDataRow(objRow);
 return objQxPrjUserRelationEN;
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
public static clsQxPrjUserRelationEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsQxPrjUserRelationEN objQxPrjUserRelationEN = QxPrjUserRelationDA.GetObjByDataRow(objRow);
 return objQxPrjUserRelationEN;
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
 /// <param name = "lstQxPrjUserRelationObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxPrjUserRelationEN GetObjBymIdFromList(long lngmId, List<clsQxPrjUserRelationEN> lstQxPrjUserRelationObjLst)
{
foreach (clsQxPrjUserRelationEN objQxPrjUserRelationEN in lstQxPrjUserRelationObjLst)
{
if (objQxPrjUserRelationEN.mId == lngmId)
{
return objQxPrjUserRelationEN;
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
 lngmId = new clsQxPrjUserRelationDA().GetFirstID(strWhereCond);
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
 arrList = QxPrjUserRelationDA.GetID(strWhereCond);
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
bool bolIsExist = QxPrjUserRelationDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = QxPrjUserRelationDA.IsExist(lngmId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngmId">流水号</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngmId, string strOpUser)
{
clsQxPrjUserRelationEN objQxPrjUserRelationEN = clsQxPrjUserRelationBL.GetObjBymId(lngmId);
objQxPrjUserRelationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objQxPrjUserRelationEN.UpdUser = strOpUser;
return clsQxPrjUserRelationBL.UpdateBySql2(objQxPrjUserRelationEN);
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
 bolIsExist = clsQxPrjUserRelationDA.IsExistTable();
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
 bolIsExist = QxPrjUserRelationDA.IsExistTable(strTabName);
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
 /// <param name = "objQxPrjUserRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsQxPrjUserRelationEN objQxPrjUserRelationEN)
{
if (objQxPrjUserRelationEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!项目Id = [{0}],用户ID = [{1}]的数据已经存在!(in clsQxPrjUserRelationBL.AddNewRecordBySql2)", objQxPrjUserRelationEN.QxPrjId,objQxPrjUserRelationEN.UserId);
throw new Exception(strMsg);
}
try
{
bool bolResult = QxPrjUserRelationDA.AddNewRecordBySQL2(objQxPrjUserRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjUserRelationBL.ReFreshCache();

if (clsQxPrjUserRelationBL.relatedActions != null)
{
clsQxPrjUserRelationBL.relatedActions.UpdRelaTabDate(objQxPrjUserRelationEN.mId, objQxPrjUserRelationEN.UpdUser);
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
 /// <param name = "objQxPrjUserRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsQxPrjUserRelationEN objQxPrjUserRelationEN)
{
if (objQxPrjUserRelationEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!项目Id = [{0}],用户ID = [{1}]的数据已经存在!(in clsQxPrjUserRelationBL.AddNewRecordBySql2WithReturnKey)", objQxPrjUserRelationEN.QxPrjId,objQxPrjUserRelationEN.UserId);
throw new Exception(strMsg);
}
try
{
string strKey = QxPrjUserRelationDA.AddNewRecordBySQL2WithReturnKey(objQxPrjUserRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjUserRelationBL.ReFreshCache();

if (clsQxPrjUserRelationBL.relatedActions != null)
{
clsQxPrjUserRelationBL.relatedActions.UpdRelaTabDate(objQxPrjUserRelationEN.mId, objQxPrjUserRelationEN.UpdUser);
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
 /// <param name = "strQxPrjUserRelationObjXml">代表实体对象的XML串</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql_XML(string strQxPrjUserRelationObjXml)
{
clsQxPrjUserRelationEN objQxPrjUserRelationEN = GetObjFromXmlStr(strQxPrjUserRelationObjXml);
try
{
bool bolResult = QxPrjUserRelationDA.AddNewRecordBySQL2(objQxPrjUserRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjUserRelationBL.ReFreshCache();

if (clsQxPrjUserRelationBL.relatedActions != null)
{
clsQxPrjUserRelationBL.relatedActions.UpdRelaTabDate(objQxPrjUserRelationEN.mId, objQxPrjUserRelationEN.UpdUser);
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
 /// <param name = "objQxPrjUserRelationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsQxPrjUserRelationEN objQxPrjUserRelationEN)
{
try
{
bool bolResult = QxPrjUserRelationDA.Update(objQxPrjUserRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjUserRelationBL.ReFreshCache();

if (clsQxPrjUserRelationBL.relatedActions != null)
{
clsQxPrjUserRelationBL.relatedActions.UpdRelaTabDate(objQxPrjUserRelationEN.mId, objQxPrjUserRelationEN.UpdUser);
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
 /// <param name = "objQxPrjUserRelationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsQxPrjUserRelationEN objQxPrjUserRelationEN)
{
 if (objQxPrjUserRelationEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = QxPrjUserRelationDA.UpdateBySql2(objQxPrjUserRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjUserRelationBL.ReFreshCache();

if (clsQxPrjUserRelationBL.relatedActions != null)
{
clsQxPrjUserRelationBL.relatedActions.UpdRelaTabDate(objQxPrjUserRelationEN.mId, objQxPrjUserRelationEN.UpdUser);
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
 /// <param name = "strQxPrjUserRelationObjXml">需要修改的对象,用XML来表示</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql_XML(string strQxPrjUserRelationObjXml)
{
clsQxPrjUserRelationEN objQxPrjUserRelationEN = GetObjFromXmlStr(strQxPrjUserRelationObjXml);
try
{
bool bolResult = QxPrjUserRelationDA.UpdateBySql2(objQxPrjUserRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjUserRelationBL.ReFreshCache();

if (clsQxPrjUserRelationBL.relatedActions != null)
{
clsQxPrjUserRelationBL.relatedActions.UpdRelaTabDate(objQxPrjUserRelationEN.mId, objQxPrjUserRelationEN.UpdUser);
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
 clsQxPrjUserRelationEN objQxPrjUserRelationEN = clsQxPrjUserRelationBL.GetObjBymId(lngmId);

if (clsQxPrjUserRelationBL.relatedActions != null)
{
clsQxPrjUserRelationBL.relatedActions.UpdRelaTabDate(objQxPrjUserRelationEN.mId, objQxPrjUserRelationEN.UpdUser);
}
if (objQxPrjUserRelationEN != null)
{
int intRecNum = QxPrjUserRelationDA.DelRecord(lngmId);
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
objSQL = clsQxPrjUserRelationDA.GetSpecSQLObj();
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
//删除与表:[QxPrjUserRelation]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conQxPrjUserRelation.mId,
//lngmId);
//        clsQxPrjUserRelationBL.DelQxPrjUserRelationsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxPrjUserRelationBL.DelRecord(lngmId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxPrjUserRelationBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clsQxPrjUserRelationBL.relatedActions != null)
{
clsQxPrjUserRelationBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = QxPrjUserRelationDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
if (clsQxPrjUserRelationBL.relatedActions != null)
{
clsQxPrjUserRelationBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = QxPrjUserRelationDA.DelRecordBySP(lngmId);
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
public static int DelQxPrjUserRelations(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsQxPrjUserRelationBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsQxPrjUserRelationBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intDelRecNum = QxPrjUserRelationDA.DelQxPrjUserRelation(arrmIdLst);
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
public static int DelQxPrjUserRelationsByCond(string strWhereCond)
{
try
{
if (clsQxPrjUserRelationBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsQxPrjUserRelationBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum = QxPrjUserRelationDA.DelQxPrjUserRelation(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[QxPrjUserRelation]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxPrjUserRelationDA.GetSpecSQLObj();
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
//删除与表:[QxPrjUserRelation]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxPrjUserRelationBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxPrjUserRelationBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objQxPrjUserRelationENS">源对象</param>
 /// <param name = "objQxPrjUserRelationENT">目标对象</param>
 public static void CopyTo(clsQxPrjUserRelationEN objQxPrjUserRelationENS, clsQxPrjUserRelationEN objQxPrjUserRelationENT)
{
try
{
objQxPrjUserRelationENT.mId = objQxPrjUserRelationENS.mId; //流水号
objQxPrjUserRelationENT.QxPrjId = objQxPrjUserRelationENS.QxPrjId; //项目Id
objQxPrjUserRelationENT.UserId = objQxPrjUserRelationENS.UserId; //用户ID
objQxPrjUserRelationENT.UpdDate = objQxPrjUserRelationENS.UpdDate; //修改日期
objQxPrjUserRelationENT.UpdUser = objQxPrjUserRelationENS.UpdUser; //修改用户
objQxPrjUserRelationENT.Memo = objQxPrjUserRelationENS.Memo; //备注
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
 /// <param name = "objQxPrjUserRelationEN">源简化对象</param>
 public static void SetUpdFlag(clsQxPrjUserRelationEN objQxPrjUserRelationEN)
{
try
{
objQxPrjUserRelationEN.ClearUpdateState();
   string strsfUpdFldSetStr = objQxPrjUserRelationEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conQxPrjUserRelation.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjUserRelationEN.mId = objQxPrjUserRelationEN.mId; //流水号
}
if (arrFldSet.Contains(conQxPrjUserRelation.QxPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjUserRelationEN.QxPrjId = objQxPrjUserRelationEN.QxPrjId; //项目Id
}
if (arrFldSet.Contains(conQxPrjUserRelation.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjUserRelationEN.UserId = objQxPrjUserRelationEN.UserId; //用户ID
}
if (arrFldSet.Contains(conQxPrjUserRelation.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjUserRelationEN.UpdDate = objQxPrjUserRelationEN.UpdDate == "[null]" ? null :  objQxPrjUserRelationEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conQxPrjUserRelation.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjUserRelationEN.UpdUser = objQxPrjUserRelationEN.UpdUser == "[null]" ? null :  objQxPrjUserRelationEN.UpdUser; //修改用户
}
if (arrFldSet.Contains(conQxPrjUserRelation.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objQxPrjUserRelationEN.Memo = objQxPrjUserRelationEN.Memo == "[null]" ? null :  objQxPrjUserRelationEN.Memo; //备注
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
 /// <param name = "objQxPrjUserRelationEN">源简化对象</param>
 public static void AccessFldValueNull(clsQxPrjUserRelationEN objQxPrjUserRelationEN)
{
try
{
if (objQxPrjUserRelationEN.UpdDate == "[null]") objQxPrjUserRelationEN.UpdDate = null; //修改日期
if (objQxPrjUserRelationEN.UpdUser == "[null]") objQxPrjUserRelationEN.UpdUser = null; //修改用户
if (objQxPrjUserRelationEN.Memo == "[null]") objQxPrjUserRelationEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsQxPrjUserRelationEN objQxPrjUserRelationEN)
{
 QxPrjUserRelationDA.CheckPropertyNew(objQxPrjUserRelationEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsQxPrjUserRelationEN objQxPrjUserRelationEN)
{
 QxPrjUserRelationDA.CheckProperty4Condition(objQxPrjUserRelationEN);
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
if (clsQxPrjUserRelationBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxPrjUserRelationBL没有刷新缓存机制(clsQxPrjUserRelationBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrQxPrjUserRelationObjLstCache == null)
//{
//arrQxPrjUserRelationObjLstCache = QxPrjUserRelationDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxPrjUserRelationEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsQxPrjUserRelationEN._CurrTabName);
List<clsQxPrjUserRelationEN> arrQxPrjUserRelationObjLstCache = GetObjLstCache();
IEnumerable <clsQxPrjUserRelationEN> arrQxPrjUserRelationObjLst_Sel =
arrQxPrjUserRelationObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrQxPrjUserRelationObjLst_Sel.Count() == 0)
{
   clsQxPrjUserRelationEN obj = clsQxPrjUserRelationBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrQxPrjUserRelationObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxPrjUserRelationEN> GetAllQxPrjUserRelationObjLstCache()
{
//获取缓存中的对象列表
List<clsQxPrjUserRelationEN> arrQxPrjUserRelationObjLstCache = GetObjLstCache(); 
return arrQxPrjUserRelationObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxPrjUserRelationEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsQxPrjUserRelationEN._CurrTabName);
List<clsQxPrjUserRelationEN> arrQxPrjUserRelationObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrQxPrjUserRelationObjLstCache;
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
string strKey = string.Format("{0}", clsQxPrjUserRelationEN._CurrTabName);
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
if (clsQxPrjUserRelationBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsQxPrjUserRelationEN._CurrTabName);
CacheHelper.Remove(strKey);
clsQxPrjUserRelationBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--QxPrjUserRelation(工程用户关系)
 /// 唯一性条件:QxPrjId_UserId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQxPrjUserRelationEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsQxPrjUserRelationEN objQxPrjUserRelationEN)
{
//检测记录是否存在
string strResult = QxPrjUserRelationDA.GetUniCondStr(objQxPrjUserRelationEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-12-16
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstQxPrjUserRelationObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsQxPrjUserRelationEN> lstQxPrjUserRelationObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstQxPrjUserRelationObjLst, writer);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 序列化一个对象列表到XmlWriter
 /// 作者:pyf
 /// 日期:2023-12-16
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXML)
 /// </summary>
 /// <param name = "lstQxPrjUserRelationObjLst">[clsQxPrjUserRelationEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsQxPrjUserRelationEN> lstQxPrjUserRelationObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsQxPrjUserRelationBL.listXmlNode);
writer.WriteStartElement(clsQxPrjUserRelationBL.itemsXmlNode);
foreach (clsQxPrjUserRelationEN objQxPrjUserRelationEN in lstQxPrjUserRelationObjLst)
{
clsQxPrjUserRelationBL.SerializeXML(writer, objQxPrjUserRelationEN);
}
writer.WriteEndElement();
writer.WriteEndElement();
return true;
}

 /// <summary>
 /// 把一个对象序列化到XML中
 /// 作者:pyf
 /// 日期:2023-12-16
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeXML)
 /// </summary>
 /// <param name = "writer">目标:序列化到的XmlWriter</param>
 /// <param name = "objQxPrjUserRelationEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsQxPrjUserRelationEN objQxPrjUserRelationEN)
{
writer.WriteStartElement(clsQxPrjUserRelationBL.itemXmlNode);
 
writer.WriteElementString(conQxPrjUserRelation.mId, objQxPrjUserRelationEN.mId.ToString(CultureInfo.InvariantCulture));
 
if (objQxPrjUserRelationEN.QxPrjId != null)
{
writer.WriteElementString(conQxPrjUserRelation.QxPrjId, objQxPrjUserRelationEN.QxPrjId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjUserRelationEN.UserId != null)
{
writer.WriteElementString(conQxPrjUserRelation.UserId, objQxPrjUserRelationEN.UserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjUserRelationEN.UpdDate != null)
{
writer.WriteElementString(conQxPrjUserRelation.UpdDate, objQxPrjUserRelationEN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjUserRelationEN.UpdUser != null)
{
writer.WriteElementString(conQxPrjUserRelation.UpdUser, objQxPrjUserRelationEN.UpdUser.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxPrjUserRelationEN.Memo != null)
{
writer.WriteElementString(conQxPrjUserRelation.Memo, objQxPrjUserRelationEN.Memo.ToString(CultureInfo.InvariantCulture));
}
writer.WriteEndElement();
}

 /// <summary>
 /// 读XmlReader到一个对象
 /// 作者:pyf
 /// 日期:2023-12-16
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlReader)
 /// </summary>
 /// <param name = "reader">提供的数据源:XmlReader</param>
 /// <returns>返回的一个对象</returns>
public static clsQxPrjUserRelationEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsQxPrjUserRelationEN objQxPrjUserRelationEN = new clsQxPrjUserRelationEN();
reader.Read();
while (!(reader.Name == clsQxPrjUserRelationBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(conQxPrjUserRelation.mId))
{
objQxPrjUserRelationEN.mId = reader.ReadElementContentAsLong();
}
if (reader.IsStartElement(conQxPrjUserRelation.QxPrjId))
{
objQxPrjUserRelationEN.QxPrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjUserRelation.UserId))
{
objQxPrjUserRelationEN.UserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjUserRelation.UpdDate))
{
objQxPrjUserRelationEN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjUserRelation.UpdUser))
{
objQxPrjUserRelationEN.UpdUser = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxPrjUserRelation.Memo))
{
objQxPrjUserRelationEN.Memo = reader.ReadElementContentAsString();
}
}
return objQxPrjUserRelationEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strQxPrjUserRelationObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsQxPrjUserRelationEN GetObjFromXmlStr(string strQxPrjUserRelationObjXmlStr)
{
clsQxPrjUserRelationEN objQxPrjUserRelationEN = new clsQxPrjUserRelationEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strQxPrjUserRelationObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsQxPrjUserRelationBL.itemXmlNode))
{
objQxPrjUserRelationEN = GetObjFromXml(reader);
return objQxPrjUserRelationEN;
}
}
return objQxPrjUserRelationEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-12-16
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objQxPrjUserRelationEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsQxPrjUserRelationEN objQxPrjUserRelationEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objQxPrjUserRelationEN);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-12-16
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != conQxPrjUserRelation.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conQxPrjUserRelation.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conQxPrjUserRelation.AttributeName));
throw new Exception(strMsg);
}
var objQxPrjUserRelation = clsQxPrjUserRelationBL.GetObjBymIdCache(lngmId);
if (objQxPrjUserRelation == null) return "";
return objQxPrjUserRelation[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-12-16
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objQxPrjUserRelationEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsQxPrjUserRelationEN objQxPrjUserRelationEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsQxPrjUserRelationEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objQxPrjUserRelationEN[strField]);
}
sbJSON.Remove(sbJSON.Length - 1, 1);
sbJSON.Append("}");
return sbJSON.ToString();
}

 /// <summary>
 /// 序列化一个对象列表到JSON串
 /// 作者:pyf
 /// 日期:2023-12-16
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToJSONStr)
 /// </summary>
 /// <param name = "lstQxPrjUserRelationObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsQxPrjUserRelationEN> lstQxPrjUserRelationObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstQxPrjUserRelationObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsQxPrjUserRelationEN objQxPrjUserRelationEN in lstQxPrjUserRelationObjLst)
{
string strJSON_One = SerializeObjToJSON(objQxPrjUserRelationEN);
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
int intRecCount = clsQxPrjUserRelationDA.GetRecCount(strTabName);
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
int intRecCount = clsQxPrjUserRelationDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsQxPrjUserRelationDA.GetRecCount();
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
int intRecCount = clsQxPrjUserRelationDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objQxPrjUserRelationCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsQxPrjUserRelationEN objQxPrjUserRelationCond)
{
List<clsQxPrjUserRelationEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxPrjUserRelationEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxPrjUserRelation.AttributeName)
{
if (objQxPrjUserRelationCond.IsUpdated(strFldName) == false) continue;
if (objQxPrjUserRelationCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxPrjUserRelationCond[strFldName].ToString());
}
else
{
if (objQxPrjUserRelationCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxPrjUserRelationCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxPrjUserRelationCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxPrjUserRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxPrjUserRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxPrjUserRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxPrjUserRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxPrjUserRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxPrjUserRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxPrjUserRelationCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxPrjUserRelationCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxPrjUserRelationCond[strFldName]));
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
 List<string> arrList = clsQxPrjUserRelationDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = QxPrjUserRelationDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = QxPrjUserRelationDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = QxPrjUserRelationDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxPrjUserRelationDA.SetFldValue(clsQxPrjUserRelationEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = QxPrjUserRelationDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxPrjUserRelationDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxPrjUserRelationDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxPrjUserRelationDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[QxPrjUserRelation] "); 
 strCreateTabCode.Append(" ( "); 
 // /**流水号*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**项目Id*/ 
 strCreateTabCode.Append(" QxPrjId char(4) not Null, "); 
 // /**用户ID*/ 
 strCreateTabCode.Append(" UserId varchar(18) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改用户*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
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
 /// 工程用户关系(QxPrjUserRelation)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4QxPrjUserRelation : clsCommFun4BL
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
clsQxPrjUserRelationBL.ReFreshThisCache();
}
}

}