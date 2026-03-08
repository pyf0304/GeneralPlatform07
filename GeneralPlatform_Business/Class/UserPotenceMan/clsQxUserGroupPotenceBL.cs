
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUserGroupPotenceBL
 表名:QxUserGroupPotence(00140008)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 17:42:24
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:用户权限管理(UserPotenceMan)
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
public static class  clsQxUserGroupPotenceBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxUserGroupPotenceEN GetObj(this K_mId_QxUserGroupPotence myKey)
{
clsQxUserGroupPotenceEN objQxUserGroupPotenceEN = clsQxUserGroupPotenceBL.QxUserGroupPotenceDA.GetObjBymId(myKey.Value);
return objQxUserGroupPotenceEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQxUserGroupPotenceEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQxUserGroupPotenceEN objQxUserGroupPotenceEN)
{
if (CheckUniqueness(objQxUserGroupPotenceEN) == false)
{
var strMsg = string.Format("记录已经存在!用户ID = [{0}],组Id = [{1}],权限ID = [{2}],角色Id = [{3}]的数据已经存在!(in clsQxUserGroupPotenceBL.AddNewRecord)", objQxUserGroupPotenceEN.UserId,objQxUserGroupPotenceEN.GroupId,objQxUserGroupPotenceEN.PotenceId,objQxUserGroupPotenceEN.RoleId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsQxUserGroupPotenceBL.QxUserGroupPotenceDA.AddNewRecordBySQL2(objQxUserGroupPotenceEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserGroupPotenceBL.ReFreshCache();

if (clsQxUserGroupPotenceBL.relatedActions != null)
{
clsQxUserGroupPotenceBL.relatedActions.UpdRelaTabDate(objQxUserGroupPotenceEN.mId, "SetUpdDate");
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
public static bool AddRecordEx(this clsQxUserGroupPotenceEN objQxUserGroupPotenceEN)
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
objQxUserGroupPotenceEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objQxUserGroupPotenceEN.CheckUniqueness() == false)
{
strMsg = string.Format("(用户ID(UserId)=[{0}],组Id(GroupId)=[{1}],权限ID(PotenceId)=[{2}],角色Id(RoleId)=[{3}])已经存在,不能重复!", objQxUserGroupPotenceEN.UserId, objQxUserGroupPotenceEN.GroupId, objQxUserGroupPotenceEN.PotenceId, objQxUserGroupPotenceEN.RoleId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objQxUserGroupPotenceEN.AddNewRecord();
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
 /// <param name = "objQxUserGroupPotenceEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsQxUserGroupPotenceEN objQxUserGroupPotenceEN)
{
if (CheckUniqueness(objQxUserGroupPotenceEN) == false)
{
var strMsg = string.Format("记录已经存在!用户ID = [{0}],组Id = [{1}],权限ID = [{2}],角色Id = [{3}]的数据已经存在!(in clsQxUserGroupPotenceBL.AddNewRecordWithReturnKey)", objQxUserGroupPotenceEN.UserId,objQxUserGroupPotenceEN.GroupId,objQxUserGroupPotenceEN.PotenceId,objQxUserGroupPotenceEN.RoleId);
throw new Exception(strMsg);
}
try
{
string strKey = clsQxUserGroupPotenceBL.QxUserGroupPotenceDA.AddNewRecordBySQL2WithReturnKey(objQxUserGroupPotenceEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserGroupPotenceBL.ReFreshCache();

if (clsQxUserGroupPotenceBL.relatedActions != null)
{
clsQxUserGroupPotenceBL.relatedActions.UpdRelaTabDate(objQxUserGroupPotenceEN.mId, "SetUpdDate");
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
 /// <param name = "objQxUserGroupPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserGroupPotenceEN SetmId(this clsQxUserGroupPotenceEN objQxUserGroupPotenceEN, long lngmId, string strComparisonOp="")
	{
objQxUserGroupPotenceEN.mId = lngmId; //流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserGroupPotenceEN.dicFldComparisonOp.ContainsKey(conQxUserGroupPotence.mId) == false)
{
objQxUserGroupPotenceEN.dicFldComparisonOp.Add(conQxUserGroupPotence.mId, strComparisonOp);
}
else
{
objQxUserGroupPotenceEN.dicFldComparisonOp[conQxUserGroupPotence.mId] = strComparisonOp;
}
}
return objQxUserGroupPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserGroupPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserGroupPotenceEN SetUserId(this clsQxUserGroupPotenceEN objQxUserGroupPotenceEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conQxUserGroupPotence.UserId);
}
objQxUserGroupPotenceEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserGroupPotenceEN.dicFldComparisonOp.ContainsKey(conQxUserGroupPotence.UserId) == false)
{
objQxUserGroupPotenceEN.dicFldComparisonOp.Add(conQxUserGroupPotence.UserId, strComparisonOp);
}
else
{
objQxUserGroupPotenceEN.dicFldComparisonOp[conQxUserGroupPotence.UserId] = strComparisonOp;
}
}
return objQxUserGroupPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserGroupPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserGroupPotenceEN SetGroupId(this clsQxUserGroupPotenceEN objQxUserGroupPotenceEN, string strGroupId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupId, 8, conQxUserGroupPotence.GroupId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGroupId, 8, conQxUserGroupPotence.GroupId);
}
objQxUserGroupPotenceEN.GroupId = strGroupId; //组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserGroupPotenceEN.dicFldComparisonOp.ContainsKey(conQxUserGroupPotence.GroupId) == false)
{
objQxUserGroupPotenceEN.dicFldComparisonOp.Add(conQxUserGroupPotence.GroupId, strComparisonOp);
}
else
{
objQxUserGroupPotenceEN.dicFldComparisonOp[conQxUserGroupPotence.GroupId] = strComparisonOp;
}
}
return objQxUserGroupPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserGroupPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserGroupPotenceEN SetRoleId(this clsQxUserGroupPotenceEN objQxUserGroupPotenceEN, string strRoleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRoleId, 8, conQxUserGroupPotence.RoleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, conQxUserGroupPotence.RoleId);
}
objQxUserGroupPotenceEN.RoleId = strRoleId; //角色Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserGroupPotenceEN.dicFldComparisonOp.ContainsKey(conQxUserGroupPotence.RoleId) == false)
{
objQxUserGroupPotenceEN.dicFldComparisonOp.Add(conQxUserGroupPotence.RoleId, strComparisonOp);
}
else
{
objQxUserGroupPotenceEN.dicFldComparisonOp[conQxUserGroupPotence.RoleId] = strComparisonOp;
}
}
return objQxUserGroupPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserGroupPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserGroupPotenceEN SetQxPrjId(this clsQxUserGroupPotenceEN objQxUserGroupPotenceEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, conQxUserGroupPotence.QxPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQxPrjId, 4, conQxUserGroupPotence.QxPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, conQxUserGroupPotence.QxPrjId);
}
objQxUserGroupPotenceEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserGroupPotenceEN.dicFldComparisonOp.ContainsKey(conQxUserGroupPotence.QxPrjId) == false)
{
objQxUserGroupPotenceEN.dicFldComparisonOp.Add(conQxUserGroupPotence.QxPrjId, strComparisonOp);
}
else
{
objQxUserGroupPotenceEN.dicFldComparisonOp[conQxUserGroupPotence.QxPrjId] = strComparisonOp;
}
}
return objQxUserGroupPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserGroupPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserGroupPotenceEN SetPotenceId(this clsQxUserGroupPotenceEN objQxUserGroupPotenceEN, string strPotenceId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPotenceId, conQxUserGroupPotence.PotenceId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPotenceId, 8, conQxUserGroupPotence.PotenceId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPotenceId, 8, conQxUserGroupPotence.PotenceId);
}
objQxUserGroupPotenceEN.PotenceId = strPotenceId; //权限ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserGroupPotenceEN.dicFldComparisonOp.ContainsKey(conQxUserGroupPotence.PotenceId) == false)
{
objQxUserGroupPotenceEN.dicFldComparisonOp.Add(conQxUserGroupPotence.PotenceId, strComparisonOp);
}
else
{
objQxUserGroupPotenceEN.dicFldComparisonOp[conQxUserGroupPotence.PotenceId] = strComparisonOp;
}
}
return objQxUserGroupPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserGroupPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserGroupPotenceEN SetRelaMid(this clsQxUserGroupPotenceEN objQxUserGroupPotenceEN, long? lngRelaMid, string strComparisonOp="")
	{
objQxUserGroupPotenceEN.RelaMid = lngRelaMid; //流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserGroupPotenceEN.dicFldComparisonOp.ContainsKey(conQxUserGroupPotence.RelaMid) == false)
{
objQxUserGroupPotenceEN.dicFldComparisonOp.Add(conQxUserGroupPotence.RelaMid, strComparisonOp);
}
else
{
objQxUserGroupPotenceEN.dicFldComparisonOp[conQxUserGroupPotence.RelaMid] = strComparisonOp;
}
}
return objQxUserGroupPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserGroupPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserGroupPotenceEN SetMemo(this clsQxUserGroupPotenceEN objQxUserGroupPotenceEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQxUserGroupPotence.Memo);
}
objQxUserGroupPotenceEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserGroupPotenceEN.dicFldComparisonOp.ContainsKey(conQxUserGroupPotence.Memo) == false)
{
objQxUserGroupPotenceEN.dicFldComparisonOp.Add(conQxUserGroupPotence.Memo, strComparisonOp);
}
else
{
objQxUserGroupPotenceEN.dicFldComparisonOp[conQxUserGroupPotence.Memo] = strComparisonOp;
}
}
return objQxUserGroupPotenceEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objQxUserGroupPotenceEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsQxUserGroupPotenceEN objQxUserGroupPotenceEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objQxUserGroupPotenceEN.CheckPropertyNew();
clsQxUserGroupPotenceEN objQxUserGroupPotenceCond = new clsQxUserGroupPotenceEN();
string strCondition = objQxUserGroupPotenceCond
.SetmId(objQxUserGroupPotenceEN.mId, "<>")
.SetUserId(objQxUserGroupPotenceEN.UserId, "=")
.SetGroupId(objQxUserGroupPotenceEN.GroupId, "=")
.SetPotenceId(objQxUserGroupPotenceEN.PotenceId, "=")
.SetRoleId(objQxUserGroupPotenceEN.RoleId, "=")
.GetCombineCondition();
objQxUserGroupPotenceEN._IsCheckProperty = true;
bool bolIsExist = clsQxUserGroupPotenceBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(UserId_GroupId_PotenceId_RoleId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objQxUserGroupPotenceEN.Update();
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
 /// <param name = "objQxUserGroupPotence">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsQxUserGroupPotenceEN objQxUserGroupPotence)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsQxUserGroupPotenceEN objQxUserGroupPotenceCond = new clsQxUserGroupPotenceEN();
string strCondition = objQxUserGroupPotenceCond
.SetUserId(objQxUserGroupPotence.UserId, "=")
.SetGroupId(objQxUserGroupPotence.GroupId, "=")
.SetPotenceId(objQxUserGroupPotence.PotenceId, "=")
.SetRoleId(objQxUserGroupPotence.RoleId, "=")
.GetCombineCondition();
objQxUserGroupPotence._IsCheckProperty = true;
bool bolIsExist = clsQxUserGroupPotenceBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objQxUserGroupPotence.mId = clsQxUserGroupPotenceBL.GetFirstID_S(strCondition);
objQxUserGroupPotence.UpdateWithCondition(strCondition);
}
else
{
objQxUserGroupPotence.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objQxUserGroupPotenceEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxUserGroupPotenceEN objQxUserGroupPotenceEN)
{
 if (objQxUserGroupPotenceEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxUserGroupPotenceBL.QxUserGroupPotenceDA.UpdateBySql2(objQxUserGroupPotenceEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserGroupPotenceBL.ReFreshCache();

if (clsQxUserGroupPotenceBL.relatedActions != null)
{
clsQxUserGroupPotenceBL.relatedActions.UpdRelaTabDate(objQxUserGroupPotenceEN.mId, "SetUpdDate");
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
 /// <param name = "objQxUserGroupPotenceEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxUserGroupPotenceEN objQxUserGroupPotenceEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objQxUserGroupPotenceEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxUserGroupPotenceBL.QxUserGroupPotenceDA.UpdateBySql2(objQxUserGroupPotenceEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserGroupPotenceBL.ReFreshCache();

if (clsQxUserGroupPotenceBL.relatedActions != null)
{
clsQxUserGroupPotenceBL.relatedActions.UpdRelaTabDate(objQxUserGroupPotenceEN.mId, "SetUpdDate");
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
 /// <param name = "objQxUserGroupPotenceEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxUserGroupPotenceEN objQxUserGroupPotenceEN, string strWhereCond)
{
try
{
bool bolResult = clsQxUserGroupPotenceBL.QxUserGroupPotenceDA.UpdateBySqlWithCondition(objQxUserGroupPotenceEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserGroupPotenceBL.ReFreshCache();

if (clsQxUserGroupPotenceBL.relatedActions != null)
{
clsQxUserGroupPotenceBL.relatedActions.UpdRelaTabDate(objQxUserGroupPotenceEN.mId, "SetUpdDate");
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
 /// <param name = "objQxUserGroupPotenceEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxUserGroupPotenceEN objQxUserGroupPotenceEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsQxUserGroupPotenceBL.QxUserGroupPotenceDA.UpdateBySqlWithConditionTransaction(objQxUserGroupPotenceEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserGroupPotenceBL.ReFreshCache();

if (clsQxUserGroupPotenceBL.relatedActions != null)
{
clsQxUserGroupPotenceBL.relatedActions.UpdRelaTabDate(objQxUserGroupPotenceEN.mId, "SetUpdDate");
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
public static int Delete(this clsQxUserGroupPotenceEN objQxUserGroupPotenceEN)
{
try
{
int intRecNum = clsQxUserGroupPotenceBL.QxUserGroupPotenceDA.DelRecord(objQxUserGroupPotenceEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserGroupPotenceBL.ReFreshCache();

if (clsQxUserGroupPotenceBL.relatedActions != null)
{
clsQxUserGroupPotenceBL.relatedActions.UpdRelaTabDate(objQxUserGroupPotenceEN.mId, "SetUpdDate");
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
 /// <param name = "objQxUserGroupPotenceENS">源对象</param>
 /// <param name = "objQxUserGroupPotenceENT">目标对象</param>
 public static void CopyTo(this clsQxUserGroupPotenceEN objQxUserGroupPotenceENS, clsQxUserGroupPotenceEN objQxUserGroupPotenceENT)
{
try
{
objQxUserGroupPotenceENT.mId = objQxUserGroupPotenceENS.mId; //流水号
objQxUserGroupPotenceENT.UserId = objQxUserGroupPotenceENS.UserId; //用户ID
objQxUserGroupPotenceENT.GroupId = objQxUserGroupPotenceENS.GroupId; //组Id
objQxUserGroupPotenceENT.RoleId = objQxUserGroupPotenceENS.RoleId; //角色Id
objQxUserGroupPotenceENT.QxPrjId = objQxUserGroupPotenceENS.QxPrjId; //项目Id
objQxUserGroupPotenceENT.PotenceId = objQxUserGroupPotenceENS.PotenceId; //权限ID
objQxUserGroupPotenceENT.RelaMid = objQxUserGroupPotenceENS.RelaMid; //流水号
objQxUserGroupPotenceENT.Memo = objQxUserGroupPotenceENS.Memo; //备注
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
 /// <param name = "objQxUserGroupPotenceENS">源对象</param>
 /// <returns>目标对象=>clsQxUserGroupPotenceEN:objQxUserGroupPotenceENT</returns>
 public static clsQxUserGroupPotenceEN CopyTo(this clsQxUserGroupPotenceEN objQxUserGroupPotenceENS)
{
try
{
 clsQxUserGroupPotenceEN objQxUserGroupPotenceENT = new clsQxUserGroupPotenceEN()
{
mId = objQxUserGroupPotenceENS.mId, //流水号
UserId = objQxUserGroupPotenceENS.UserId, //用户ID
GroupId = objQxUserGroupPotenceENS.GroupId, //组Id
RoleId = objQxUserGroupPotenceENS.RoleId, //角色Id
QxPrjId = objQxUserGroupPotenceENS.QxPrjId, //项目Id
PotenceId = objQxUserGroupPotenceENS.PotenceId, //权限ID
RelaMid = objQxUserGroupPotenceENS.RelaMid, //流水号
Memo = objQxUserGroupPotenceENS.Memo, //备注
};
 return objQxUserGroupPotenceENT;
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
public static void CheckPropertyNew(this clsQxUserGroupPotenceEN objQxUserGroupPotenceEN)
{
 clsQxUserGroupPotenceBL.QxUserGroupPotenceDA.CheckPropertyNew(objQxUserGroupPotenceEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsQxUserGroupPotenceEN objQxUserGroupPotenceEN)
{
 clsQxUserGroupPotenceBL.QxUserGroupPotenceDA.CheckProperty4Condition(objQxUserGroupPotenceEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQxUserGroupPotenceEN objQxUserGroupPotenceCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQxUserGroupPotenceCond.IsUpdated(conQxUserGroupPotence.mId) == true)
{
string strComparisonOpmId = objQxUserGroupPotenceCond.dicFldComparisonOp[conQxUserGroupPotence.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conQxUserGroupPotence.mId, objQxUserGroupPotenceCond.mId, strComparisonOpmId);
}
if (objQxUserGroupPotenceCond.IsUpdated(conQxUserGroupPotence.UserId) == true)
{
string strComparisonOpUserId = objQxUserGroupPotenceCond.dicFldComparisonOp[conQxUserGroupPotence.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserGroupPotence.UserId, objQxUserGroupPotenceCond.UserId, strComparisonOpUserId);
}
if (objQxUserGroupPotenceCond.IsUpdated(conQxUserGroupPotence.GroupId) == true)
{
string strComparisonOpGroupId = objQxUserGroupPotenceCond.dicFldComparisonOp[conQxUserGroupPotence.GroupId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserGroupPotence.GroupId, objQxUserGroupPotenceCond.GroupId, strComparisonOpGroupId);
}
if (objQxUserGroupPotenceCond.IsUpdated(conQxUserGroupPotence.RoleId) == true)
{
string strComparisonOpRoleId = objQxUserGroupPotenceCond.dicFldComparisonOp[conQxUserGroupPotence.RoleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserGroupPotence.RoleId, objQxUserGroupPotenceCond.RoleId, strComparisonOpRoleId);
}
if (objQxUserGroupPotenceCond.IsUpdated(conQxUserGroupPotence.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objQxUserGroupPotenceCond.dicFldComparisonOp[conQxUserGroupPotence.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserGroupPotence.QxPrjId, objQxUserGroupPotenceCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objQxUserGroupPotenceCond.IsUpdated(conQxUserGroupPotence.PotenceId) == true)
{
string strComparisonOpPotenceId = objQxUserGroupPotenceCond.dicFldComparisonOp[conQxUserGroupPotence.PotenceId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserGroupPotence.PotenceId, objQxUserGroupPotenceCond.PotenceId, strComparisonOpPotenceId);
}
if (objQxUserGroupPotenceCond.IsUpdated(conQxUserGroupPotence.RelaMid) == true)
{
string strComparisonOpRelaMid = objQxUserGroupPotenceCond.dicFldComparisonOp[conQxUserGroupPotence.RelaMid];
strWhereCond += string.Format(" And {0} {2} {1}", conQxUserGroupPotence.RelaMid, objQxUserGroupPotenceCond.RelaMid, strComparisonOpRelaMid);
}
if (objQxUserGroupPotenceCond.IsUpdated(conQxUserGroupPotence.Memo) == true)
{
string strComparisonOpMemo = objQxUserGroupPotenceCond.dicFldComparisonOp[conQxUserGroupPotence.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserGroupPotence.Memo, objQxUserGroupPotenceCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--QxUserGroupPotence(用户权限关系), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:UserId_GroupId_PotenceId_RoleId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objQxUserGroupPotenceEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsQxUserGroupPotenceEN objQxUserGroupPotenceEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objQxUserGroupPotenceEN == null) return true;
if (objQxUserGroupPotenceEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objQxUserGroupPotenceEN.UserId == null)
{
 sbCondition.AppendFormat(" and UserId is null", objQxUserGroupPotenceEN.UserId);
}
else
{
 sbCondition.AppendFormat(" and UserId = '{0}'", objQxUserGroupPotenceEN.UserId);
}
 if (objQxUserGroupPotenceEN.GroupId == null)
{
 sbCondition.AppendFormat(" and GroupId is null", objQxUserGroupPotenceEN.GroupId);
}
else
{
 sbCondition.AppendFormat(" and GroupId = '{0}'", objQxUserGroupPotenceEN.GroupId);
}
 sbCondition.AppendFormat(" and PotenceId = '{0}'", objQxUserGroupPotenceEN.PotenceId);
 if (objQxUserGroupPotenceEN.RoleId == null)
{
 sbCondition.AppendFormat(" and RoleId is null", objQxUserGroupPotenceEN.RoleId);
}
else
{
 sbCondition.AppendFormat(" and RoleId = '{0}'", objQxUserGroupPotenceEN.RoleId);
}
if (clsQxUserGroupPotenceBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objQxUserGroupPotenceEN.mId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objQxUserGroupPotenceEN.UserId);
 sbCondition.AppendFormat(" and GroupId = '{0}'", objQxUserGroupPotenceEN.GroupId);
 sbCondition.AppendFormat(" and PotenceId = '{0}'", objQxUserGroupPotenceEN.PotenceId);
 sbCondition.AppendFormat(" and RoleId = '{0}'", objQxUserGroupPotenceEN.RoleId);
if (clsQxUserGroupPotenceBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--QxUserGroupPotence(用户权限关系), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:UserId_GroupId_PotenceId_RoleId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objQxUserGroupPotenceEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsQxUserGroupPotenceEN objQxUserGroupPotenceEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objQxUserGroupPotenceEN == null) return "";
if (objQxUserGroupPotenceEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objQxUserGroupPotenceEN.UserId == null)
{
 sbCondition.AppendFormat(" and UserId is null", objQxUserGroupPotenceEN.UserId);
}
else
{
 sbCondition.AppendFormat(" and UserId = '{0}'", objQxUserGroupPotenceEN.UserId);
}
 if (objQxUserGroupPotenceEN.GroupId == null)
{
 sbCondition.AppendFormat(" and GroupId is null", objQxUserGroupPotenceEN.GroupId);
}
else
{
 sbCondition.AppendFormat(" and GroupId = '{0}'", objQxUserGroupPotenceEN.GroupId);
}
 sbCondition.AppendFormat(" and PotenceId = '{0}'", objQxUserGroupPotenceEN.PotenceId);
 if (objQxUserGroupPotenceEN.RoleId == null)
{
 sbCondition.AppendFormat(" and RoleId is null", objQxUserGroupPotenceEN.RoleId);
}
else
{
 sbCondition.AppendFormat(" and RoleId = '{0}'", objQxUserGroupPotenceEN.RoleId);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objQxUserGroupPotenceEN.mId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objQxUserGroupPotenceEN.UserId);
 sbCondition.AppendFormat(" and GroupId = '{0}'", objQxUserGroupPotenceEN.GroupId);
 sbCondition.AppendFormat(" and PotenceId = '{0}'", objQxUserGroupPotenceEN.PotenceId);
 sbCondition.AppendFormat(" and RoleId = '{0}'", objQxUserGroupPotenceEN.RoleId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_QxUserGroupPotence
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 用户权限关系(QxUserGroupPotence)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsQxUserGroupPotenceBL
{
public static RelatedActions_QxUserGroupPotence relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "QxUserGroupPotenceListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "QxUserGroupPotenceList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsQxUserGroupPotenceEN> arrQxUserGroupPotenceObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsQxUserGroupPotenceDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsQxUserGroupPotenceDA QxUserGroupPotenceDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsQxUserGroupPotenceDA();
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
 public clsQxUserGroupPotenceBL()
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
if (string.IsNullOrEmpty(clsQxUserGroupPotenceEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxUserGroupPotenceEN._ConnectString);
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
objDS = QxUserGroupPotenceDA.GetDataSet(strWhereCond);
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
objDS = QxUserGroupPotenceDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = QxUserGroupPotenceDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_QxUserGroupPotence(string strWhereCond)
{
DataTable objDT;
try
{
objDT = QxUserGroupPotenceDA.GetDataTable_QxUserGroupPotence(strWhereCond);
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
objDT = QxUserGroupPotenceDA.GetDataTable(strWhereCond);
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
objDT = QxUserGroupPotenceDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = QxUserGroupPotenceDA.GetDataTable(strWhereCond, strTabName);
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
objDT = QxUserGroupPotenceDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = QxUserGroupPotenceDA.GetDataTable_Top(objTopPara);
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
objDT = QxUserGroupPotenceDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = QxUserGroupPotenceDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = QxUserGroupPotenceDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = QxUserGroupPotenceDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = QxUserGroupPotenceDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = QxUserGroupPotenceDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = QxUserGroupPotenceDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = QxUserGroupPotenceDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
public static List<clsQxUserGroupPotenceEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsQxUserGroupPotenceEN> arrObjLst = new List<clsQxUserGroupPotenceEN>(); 
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
	clsQxUserGroupPotenceEN objQxUserGroupPotenceEN = new clsQxUserGroupPotenceEN();
try
{
objQxUserGroupPotenceEN.mId = Int32.Parse(objRow[conQxUserGroupPotence.mId].ToString().Trim()); //流水号
objQxUserGroupPotenceEN.UserId = objRow[conQxUserGroupPotence.UserId] == DBNull.Value ? null : objRow[conQxUserGroupPotence.UserId].ToString().Trim(); //用户ID
objQxUserGroupPotenceEN.GroupId = objRow[conQxUserGroupPotence.GroupId] == DBNull.Value ? null : objRow[conQxUserGroupPotence.GroupId].ToString().Trim(); //组Id
objQxUserGroupPotenceEN.RoleId = objRow[conQxUserGroupPotence.RoleId] == DBNull.Value ? null : objRow[conQxUserGroupPotence.RoleId].ToString().Trim(); //角色Id
objQxUserGroupPotenceEN.QxPrjId = objRow[conQxUserGroupPotence.QxPrjId].ToString().Trim(); //项目Id
objQxUserGroupPotenceEN.PotenceId = objRow[conQxUserGroupPotence.PotenceId].ToString().Trim(); //权限ID
objQxUserGroupPotenceEN.RelaMid = objRow[conQxUserGroupPotence.RelaMid] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxUserGroupPotence.RelaMid].ToString().Trim()); //流水号
objQxUserGroupPotenceEN.Memo = objRow[conQxUserGroupPotence.Memo] == DBNull.Value ? null : objRow[conQxUserGroupPotence.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserGroupPotenceEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserGroupPotenceEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsQxUserGroupPotenceEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsQxUserGroupPotenceEN._CurrTabName);
List<clsQxUserGroupPotenceEN> arrQxUserGroupPotenceObjLstCache = GetObjLstCache();
IEnumerable <clsQxUserGroupPotenceEN> arrQxUserGroupPotenceObjLst_Sel =
arrQxUserGroupPotenceObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrQxUserGroupPotenceObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUserGroupPotenceEN> GetObjLst(string strWhereCond)
{
List<clsQxUserGroupPotenceEN> arrObjLst = new List<clsQxUserGroupPotenceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserGroupPotenceEN objQxUserGroupPotenceEN = new clsQxUserGroupPotenceEN();
try
{
objQxUserGroupPotenceEN.mId = Int32.Parse(objRow[conQxUserGroupPotence.mId].ToString().Trim()); //流水号
objQxUserGroupPotenceEN.UserId = objRow[conQxUserGroupPotence.UserId] == DBNull.Value ? null : objRow[conQxUserGroupPotence.UserId].ToString().Trim(); //用户ID
objQxUserGroupPotenceEN.GroupId = objRow[conQxUserGroupPotence.GroupId] == DBNull.Value ? null : objRow[conQxUserGroupPotence.GroupId].ToString().Trim(); //组Id
objQxUserGroupPotenceEN.RoleId = objRow[conQxUserGroupPotence.RoleId] == DBNull.Value ? null : objRow[conQxUserGroupPotence.RoleId].ToString().Trim(); //角色Id
objQxUserGroupPotenceEN.QxPrjId = objRow[conQxUserGroupPotence.QxPrjId].ToString().Trim(); //项目Id
objQxUserGroupPotenceEN.PotenceId = objRow[conQxUserGroupPotence.PotenceId].ToString().Trim(); //权限ID
objQxUserGroupPotenceEN.RelaMid = objRow[conQxUserGroupPotence.RelaMid] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxUserGroupPotence.RelaMid].ToString().Trim()); //流水号
objQxUserGroupPotenceEN.Memo = objRow[conQxUserGroupPotence.Memo] == DBNull.Value ? null : objRow[conQxUserGroupPotence.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserGroupPotenceEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserGroupPotenceEN);
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
public static List<clsQxUserGroupPotenceEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsQxUserGroupPotenceEN> arrObjLst = new List<clsQxUserGroupPotenceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserGroupPotenceEN objQxUserGroupPotenceEN = new clsQxUserGroupPotenceEN();
try
{
objQxUserGroupPotenceEN.mId = Int32.Parse(objRow[conQxUserGroupPotence.mId].ToString().Trim()); //流水号
objQxUserGroupPotenceEN.UserId = objRow[conQxUserGroupPotence.UserId] == DBNull.Value ? null : objRow[conQxUserGroupPotence.UserId].ToString().Trim(); //用户ID
objQxUserGroupPotenceEN.GroupId = objRow[conQxUserGroupPotence.GroupId] == DBNull.Value ? null : objRow[conQxUserGroupPotence.GroupId].ToString().Trim(); //组Id
objQxUserGroupPotenceEN.RoleId = objRow[conQxUserGroupPotence.RoleId] == DBNull.Value ? null : objRow[conQxUserGroupPotence.RoleId].ToString().Trim(); //角色Id
objQxUserGroupPotenceEN.QxPrjId = objRow[conQxUserGroupPotence.QxPrjId].ToString().Trim(); //项目Id
objQxUserGroupPotenceEN.PotenceId = objRow[conQxUserGroupPotence.PotenceId].ToString().Trim(); //权限ID
objQxUserGroupPotenceEN.RelaMid = objRow[conQxUserGroupPotence.RelaMid] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxUserGroupPotence.RelaMid].ToString().Trim()); //流水号
objQxUserGroupPotenceEN.Memo = objRow[conQxUserGroupPotence.Memo] == DBNull.Value ? null : objRow[conQxUserGroupPotence.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserGroupPotenceEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserGroupPotenceEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objQxUserGroupPotenceCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsQxUserGroupPotenceEN> GetSubObjLstCache(clsQxUserGroupPotenceEN objQxUserGroupPotenceCond)
{
List<clsQxUserGroupPotenceEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxUserGroupPotenceEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxUserGroupPotence.AttributeName)
{
if (objQxUserGroupPotenceCond.IsUpdated(strFldName) == false) continue;
if (objQxUserGroupPotenceCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUserGroupPotenceCond[strFldName].ToString());
}
else
{
if (objQxUserGroupPotenceCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxUserGroupPotenceCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUserGroupPotenceCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxUserGroupPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxUserGroupPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxUserGroupPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxUserGroupPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxUserGroupPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxUserGroupPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxUserGroupPotenceCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxUserGroupPotenceCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxUserGroupPotenceCond[strFldName]));
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
public static List<clsQxUserGroupPotenceEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsQxUserGroupPotenceEN> arrObjLst = new List<clsQxUserGroupPotenceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserGroupPotenceEN objQxUserGroupPotenceEN = new clsQxUserGroupPotenceEN();
try
{
objQxUserGroupPotenceEN.mId = Int32.Parse(objRow[conQxUserGroupPotence.mId].ToString().Trim()); //流水号
objQxUserGroupPotenceEN.UserId = objRow[conQxUserGroupPotence.UserId] == DBNull.Value ? null : objRow[conQxUserGroupPotence.UserId].ToString().Trim(); //用户ID
objQxUserGroupPotenceEN.GroupId = objRow[conQxUserGroupPotence.GroupId] == DBNull.Value ? null : objRow[conQxUserGroupPotence.GroupId].ToString().Trim(); //组Id
objQxUserGroupPotenceEN.RoleId = objRow[conQxUserGroupPotence.RoleId] == DBNull.Value ? null : objRow[conQxUserGroupPotence.RoleId].ToString().Trim(); //角色Id
objQxUserGroupPotenceEN.QxPrjId = objRow[conQxUserGroupPotence.QxPrjId].ToString().Trim(); //项目Id
objQxUserGroupPotenceEN.PotenceId = objRow[conQxUserGroupPotence.PotenceId].ToString().Trim(); //权限ID
objQxUserGroupPotenceEN.RelaMid = objRow[conQxUserGroupPotence.RelaMid] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxUserGroupPotence.RelaMid].ToString().Trim()); //流水号
objQxUserGroupPotenceEN.Memo = objRow[conQxUserGroupPotence.Memo] == DBNull.Value ? null : objRow[conQxUserGroupPotence.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserGroupPotenceEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserGroupPotenceEN);
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
public static List<clsQxUserGroupPotenceEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsQxUserGroupPotenceEN> arrObjLst = new List<clsQxUserGroupPotenceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserGroupPotenceEN objQxUserGroupPotenceEN = new clsQxUserGroupPotenceEN();
try
{
objQxUserGroupPotenceEN.mId = Int32.Parse(objRow[conQxUserGroupPotence.mId].ToString().Trim()); //流水号
objQxUserGroupPotenceEN.UserId = objRow[conQxUserGroupPotence.UserId] == DBNull.Value ? null : objRow[conQxUserGroupPotence.UserId].ToString().Trim(); //用户ID
objQxUserGroupPotenceEN.GroupId = objRow[conQxUserGroupPotence.GroupId] == DBNull.Value ? null : objRow[conQxUserGroupPotence.GroupId].ToString().Trim(); //组Id
objQxUserGroupPotenceEN.RoleId = objRow[conQxUserGroupPotence.RoleId] == DBNull.Value ? null : objRow[conQxUserGroupPotence.RoleId].ToString().Trim(); //角色Id
objQxUserGroupPotenceEN.QxPrjId = objRow[conQxUserGroupPotence.QxPrjId].ToString().Trim(); //项目Id
objQxUserGroupPotenceEN.PotenceId = objRow[conQxUserGroupPotence.PotenceId].ToString().Trim(); //权限ID
objQxUserGroupPotenceEN.RelaMid = objRow[conQxUserGroupPotence.RelaMid] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxUserGroupPotence.RelaMid].ToString().Trim()); //流水号
objQxUserGroupPotenceEN.Memo = objRow[conQxUserGroupPotence.Memo] == DBNull.Value ? null : objRow[conQxUserGroupPotence.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserGroupPotenceEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserGroupPotenceEN);
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
List<clsQxUserGroupPotenceEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsQxUserGroupPotenceEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUserGroupPotenceEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsQxUserGroupPotenceEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsQxUserGroupPotenceEN> arrObjLst = new List<clsQxUserGroupPotenceEN>(); 
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
	clsQxUserGroupPotenceEN objQxUserGroupPotenceEN = new clsQxUserGroupPotenceEN();
try
{
objQxUserGroupPotenceEN.mId = Int32.Parse(objRow[conQxUserGroupPotence.mId].ToString().Trim()); //流水号
objQxUserGroupPotenceEN.UserId = objRow[conQxUserGroupPotence.UserId] == DBNull.Value ? null : objRow[conQxUserGroupPotence.UserId].ToString().Trim(); //用户ID
objQxUserGroupPotenceEN.GroupId = objRow[conQxUserGroupPotence.GroupId] == DBNull.Value ? null : objRow[conQxUserGroupPotence.GroupId].ToString().Trim(); //组Id
objQxUserGroupPotenceEN.RoleId = objRow[conQxUserGroupPotence.RoleId] == DBNull.Value ? null : objRow[conQxUserGroupPotence.RoleId].ToString().Trim(); //角色Id
objQxUserGroupPotenceEN.QxPrjId = objRow[conQxUserGroupPotence.QxPrjId].ToString().Trim(); //项目Id
objQxUserGroupPotenceEN.PotenceId = objRow[conQxUserGroupPotence.PotenceId].ToString().Trim(); //权限ID
objQxUserGroupPotenceEN.RelaMid = objRow[conQxUserGroupPotence.RelaMid] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxUserGroupPotence.RelaMid].ToString().Trim()); //流水号
objQxUserGroupPotenceEN.Memo = objRow[conQxUserGroupPotence.Memo] == DBNull.Value ? null : objRow[conQxUserGroupPotence.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserGroupPotenceEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserGroupPotenceEN);
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
public static List<clsQxUserGroupPotenceEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsQxUserGroupPotenceEN> arrObjLst = new List<clsQxUserGroupPotenceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserGroupPotenceEN objQxUserGroupPotenceEN = new clsQxUserGroupPotenceEN();
try
{
objQxUserGroupPotenceEN.mId = Int32.Parse(objRow[conQxUserGroupPotence.mId].ToString().Trim()); //流水号
objQxUserGroupPotenceEN.UserId = objRow[conQxUserGroupPotence.UserId] == DBNull.Value ? null : objRow[conQxUserGroupPotence.UserId].ToString().Trim(); //用户ID
objQxUserGroupPotenceEN.GroupId = objRow[conQxUserGroupPotence.GroupId] == DBNull.Value ? null : objRow[conQxUserGroupPotence.GroupId].ToString().Trim(); //组Id
objQxUserGroupPotenceEN.RoleId = objRow[conQxUserGroupPotence.RoleId] == DBNull.Value ? null : objRow[conQxUserGroupPotence.RoleId].ToString().Trim(); //角色Id
objQxUserGroupPotenceEN.QxPrjId = objRow[conQxUserGroupPotence.QxPrjId].ToString().Trim(); //项目Id
objQxUserGroupPotenceEN.PotenceId = objRow[conQxUserGroupPotence.PotenceId].ToString().Trim(); //权限ID
objQxUserGroupPotenceEN.RelaMid = objRow[conQxUserGroupPotence.RelaMid] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxUserGroupPotence.RelaMid].ToString().Trim()); //流水号
objQxUserGroupPotenceEN.Memo = objRow[conQxUserGroupPotence.Memo] == DBNull.Value ? null : objRow[conQxUserGroupPotence.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserGroupPotenceEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserGroupPotenceEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsQxUserGroupPotenceEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsQxUserGroupPotenceEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsQxUserGroupPotenceEN> arrObjLst = new List<clsQxUserGroupPotenceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserGroupPotenceEN objQxUserGroupPotenceEN = new clsQxUserGroupPotenceEN();
try
{
objQxUserGroupPotenceEN.mId = Int32.Parse(objRow[conQxUserGroupPotence.mId].ToString().Trim()); //流水号
objQxUserGroupPotenceEN.UserId = objRow[conQxUserGroupPotence.UserId] == DBNull.Value ? null : objRow[conQxUserGroupPotence.UserId].ToString().Trim(); //用户ID
objQxUserGroupPotenceEN.GroupId = objRow[conQxUserGroupPotence.GroupId] == DBNull.Value ? null : objRow[conQxUserGroupPotence.GroupId].ToString().Trim(); //组Id
objQxUserGroupPotenceEN.RoleId = objRow[conQxUserGroupPotence.RoleId] == DBNull.Value ? null : objRow[conQxUserGroupPotence.RoleId].ToString().Trim(); //角色Id
objQxUserGroupPotenceEN.QxPrjId = objRow[conQxUserGroupPotence.QxPrjId].ToString().Trim(); //项目Id
objQxUserGroupPotenceEN.PotenceId = objRow[conQxUserGroupPotence.PotenceId].ToString().Trim(); //权限ID
objQxUserGroupPotenceEN.RelaMid = objRow[conQxUserGroupPotence.RelaMid] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxUserGroupPotence.RelaMid].ToString().Trim()); //流水号
objQxUserGroupPotenceEN.Memo = objRow[conQxUserGroupPotence.Memo] == DBNull.Value ? null : objRow[conQxUserGroupPotence.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserGroupPotenceEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserGroupPotenceEN);
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
public static List<clsQxUserGroupPotenceEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsQxUserGroupPotenceEN> arrObjLst = new List<clsQxUserGroupPotenceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserGroupPotenceEN objQxUserGroupPotenceEN = new clsQxUserGroupPotenceEN();
try
{
objQxUserGroupPotenceEN.mId = Int32.Parse(objRow[conQxUserGroupPotence.mId].ToString().Trim()); //流水号
objQxUserGroupPotenceEN.UserId = objRow[conQxUserGroupPotence.UserId] == DBNull.Value ? null : objRow[conQxUserGroupPotence.UserId].ToString().Trim(); //用户ID
objQxUserGroupPotenceEN.GroupId = objRow[conQxUserGroupPotence.GroupId] == DBNull.Value ? null : objRow[conQxUserGroupPotence.GroupId].ToString().Trim(); //组Id
objQxUserGroupPotenceEN.RoleId = objRow[conQxUserGroupPotence.RoleId] == DBNull.Value ? null : objRow[conQxUserGroupPotence.RoleId].ToString().Trim(); //角色Id
objQxUserGroupPotenceEN.QxPrjId = objRow[conQxUserGroupPotence.QxPrjId].ToString().Trim(); //项目Id
objQxUserGroupPotenceEN.PotenceId = objRow[conQxUserGroupPotence.PotenceId].ToString().Trim(); //权限ID
objQxUserGroupPotenceEN.RelaMid = objRow[conQxUserGroupPotence.RelaMid] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxUserGroupPotence.RelaMid].ToString().Trim()); //流水号
objQxUserGroupPotenceEN.Memo = objRow[conQxUserGroupPotence.Memo] == DBNull.Value ? null : objRow[conQxUserGroupPotence.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserGroupPotenceEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserGroupPotenceEN);
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
public static IEnumerable<clsQxUserGroupPotenceEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsQxUserGroupPotenceEN objQxUserGroupPotenceCond, string strOrderBy)
{
List<clsQxUserGroupPotenceEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxUserGroupPotenceEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxUserGroupPotence.AttributeName)
{
if (objQxUserGroupPotenceCond.IsUpdated(strFldName) == false) continue;
if (objQxUserGroupPotenceCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUserGroupPotenceCond[strFldName].ToString());
}
else
{
if (objQxUserGroupPotenceCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxUserGroupPotenceCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUserGroupPotenceCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxUserGroupPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxUserGroupPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxUserGroupPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxUserGroupPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxUserGroupPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxUserGroupPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxUserGroupPotenceCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxUserGroupPotenceCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxUserGroupPotenceCond[strFldName]));
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
public static IEnumerable<clsQxUserGroupPotenceEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsQxUserGroupPotenceEN objQxUserGroupPotenceCond = JsonConvert.DeserializeObject<clsQxUserGroupPotenceEN>(objPagerPara.whereCond);
if (objQxUserGroupPotenceCond.sfFldComparisonOp == null)
{
objQxUserGroupPotenceCond.dicFldComparisonOp = null;
}
else
{
objQxUserGroupPotenceCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objQxUserGroupPotenceCond.sfFldComparisonOp);
}
clsQxUserGroupPotenceBL.SetUpdFlag(objQxUserGroupPotenceCond);
 try
{
CheckProperty4Condition(objQxUserGroupPotenceCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsQxUserGroupPotenceBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objQxUserGroupPotenceCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUserGroupPotenceEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsQxUserGroupPotenceEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsQxUserGroupPotenceEN> arrObjLst = new List<clsQxUserGroupPotenceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserGroupPotenceEN objQxUserGroupPotenceEN = new clsQxUserGroupPotenceEN();
try
{
objQxUserGroupPotenceEN.mId = Int32.Parse(objRow[conQxUserGroupPotence.mId].ToString().Trim()); //流水号
objQxUserGroupPotenceEN.UserId = objRow[conQxUserGroupPotence.UserId] == DBNull.Value ? null : objRow[conQxUserGroupPotence.UserId].ToString().Trim(); //用户ID
objQxUserGroupPotenceEN.GroupId = objRow[conQxUserGroupPotence.GroupId] == DBNull.Value ? null : objRow[conQxUserGroupPotence.GroupId].ToString().Trim(); //组Id
objQxUserGroupPotenceEN.RoleId = objRow[conQxUserGroupPotence.RoleId] == DBNull.Value ? null : objRow[conQxUserGroupPotence.RoleId].ToString().Trim(); //角色Id
objQxUserGroupPotenceEN.QxPrjId = objRow[conQxUserGroupPotence.QxPrjId].ToString().Trim(); //项目Id
objQxUserGroupPotenceEN.PotenceId = objRow[conQxUserGroupPotence.PotenceId].ToString().Trim(); //权限ID
objQxUserGroupPotenceEN.RelaMid = objRow[conQxUserGroupPotence.RelaMid] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxUserGroupPotence.RelaMid].ToString().Trim()); //流水号
objQxUserGroupPotenceEN.Memo = objRow[conQxUserGroupPotence.Memo] == DBNull.Value ? null : objRow[conQxUserGroupPotence.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserGroupPotenceEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserGroupPotenceEN);
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
public static List<clsQxUserGroupPotenceEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsQxUserGroupPotenceEN> arrObjLst = new List<clsQxUserGroupPotenceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserGroupPotenceEN objQxUserGroupPotenceEN = new clsQxUserGroupPotenceEN();
try
{
objQxUserGroupPotenceEN.mId = Int32.Parse(objRow[conQxUserGroupPotence.mId].ToString().Trim()); //流水号
objQxUserGroupPotenceEN.UserId = objRow[conQxUserGroupPotence.UserId] == DBNull.Value ? null : objRow[conQxUserGroupPotence.UserId].ToString().Trim(); //用户ID
objQxUserGroupPotenceEN.GroupId = objRow[conQxUserGroupPotence.GroupId] == DBNull.Value ? null : objRow[conQxUserGroupPotence.GroupId].ToString().Trim(); //组Id
objQxUserGroupPotenceEN.RoleId = objRow[conQxUserGroupPotence.RoleId] == DBNull.Value ? null : objRow[conQxUserGroupPotence.RoleId].ToString().Trim(); //角色Id
objQxUserGroupPotenceEN.QxPrjId = objRow[conQxUserGroupPotence.QxPrjId].ToString().Trim(); //项目Id
objQxUserGroupPotenceEN.PotenceId = objRow[conQxUserGroupPotence.PotenceId].ToString().Trim(); //权限ID
objQxUserGroupPotenceEN.RelaMid = objRow[conQxUserGroupPotence.RelaMid] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxUserGroupPotence.RelaMid].ToString().Trim()); //流水号
objQxUserGroupPotenceEN.Memo = objRow[conQxUserGroupPotence.Memo] == DBNull.Value ? null : objRow[conQxUserGroupPotence.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserGroupPotenceEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserGroupPotenceEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUserGroupPotenceEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsQxUserGroupPotenceEN> arrObjLst = new List<clsQxUserGroupPotenceEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserGroupPotenceEN objQxUserGroupPotenceEN = new clsQxUserGroupPotenceEN();
try
{
objQxUserGroupPotenceEN.mId = Int32.Parse(objRow[conQxUserGroupPotence.mId].ToString().Trim()); //流水号
objQxUserGroupPotenceEN.UserId = objRow[conQxUserGroupPotence.UserId] == DBNull.Value ? null : objRow[conQxUserGroupPotence.UserId].ToString().Trim(); //用户ID
objQxUserGroupPotenceEN.GroupId = objRow[conQxUserGroupPotence.GroupId] == DBNull.Value ? null : objRow[conQxUserGroupPotence.GroupId].ToString().Trim(); //组Id
objQxUserGroupPotenceEN.RoleId = objRow[conQxUserGroupPotence.RoleId] == DBNull.Value ? null : objRow[conQxUserGroupPotence.RoleId].ToString().Trim(); //角色Id
objQxUserGroupPotenceEN.QxPrjId = objRow[conQxUserGroupPotence.QxPrjId].ToString().Trim(); //项目Id
objQxUserGroupPotenceEN.PotenceId = objRow[conQxUserGroupPotence.PotenceId].ToString().Trim(); //权限ID
objQxUserGroupPotenceEN.RelaMid = objRow[conQxUserGroupPotence.RelaMid] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQxUserGroupPotence.RelaMid].ToString().Trim()); //流水号
objQxUserGroupPotenceEN.Memo = objRow[conQxUserGroupPotence.Memo] == DBNull.Value ? null : objRow[conQxUserGroupPotence.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserGroupPotenceEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserGroupPotenceEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objQxUserGroupPotenceEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxUserGroupPotence(ref clsQxUserGroupPotenceEN objQxUserGroupPotenceEN)
{
bool bolResult = QxUserGroupPotenceDA.GetQxUserGroupPotence(ref objQxUserGroupPotenceEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxUserGroupPotenceEN GetObjBymId(long lngmId)
{
clsQxUserGroupPotenceEN objQxUserGroupPotenceEN = QxUserGroupPotenceDA.GetObjBymId(lngmId);
return objQxUserGroupPotenceEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsQxUserGroupPotenceEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsQxUserGroupPotenceEN objQxUserGroupPotenceEN = QxUserGroupPotenceDA.GetFirstObj(strWhereCond);
 return objQxUserGroupPotenceEN;
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
public static clsQxUserGroupPotenceEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsQxUserGroupPotenceEN objQxUserGroupPotenceEN = QxUserGroupPotenceDA.GetObjByDataRow(objRow);
 return objQxUserGroupPotenceEN;
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
public static clsQxUserGroupPotenceEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsQxUserGroupPotenceEN objQxUserGroupPotenceEN = QxUserGroupPotenceDA.GetObjByDataRow(objRow);
 return objQxUserGroupPotenceEN;
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
 /// <param name = "lstQxUserGroupPotenceObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxUserGroupPotenceEN GetObjBymIdFromList(long lngmId, List<clsQxUserGroupPotenceEN> lstQxUserGroupPotenceObjLst)
{
foreach (clsQxUserGroupPotenceEN objQxUserGroupPotenceEN in lstQxUserGroupPotenceObjLst)
{
if (objQxUserGroupPotenceEN.mId == lngmId)
{
return objQxUserGroupPotenceEN;
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
 lngmId = new clsQxUserGroupPotenceDA().GetFirstID(strWhereCond);
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
 arrList = QxUserGroupPotenceDA.GetID(strWhereCond);
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
bool bolIsExist = QxUserGroupPotenceDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = QxUserGroupPotenceDA.IsExist(lngmId);
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
 bolIsExist = clsQxUserGroupPotenceDA.IsExistTable();
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
 bolIsExist = QxUserGroupPotenceDA.IsExistTable(strTabName);
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
 /// <param name = "objQxUserGroupPotenceEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsQxUserGroupPotenceEN objQxUserGroupPotenceEN)
{
if (objQxUserGroupPotenceEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!用户ID = [{0}],组Id = [{1}],权限ID = [{2}],角色Id = [{3}]的数据已经存在!(in clsQxUserGroupPotenceBL.AddNewRecordBySql2)", objQxUserGroupPotenceEN.UserId,objQxUserGroupPotenceEN.GroupId,objQxUserGroupPotenceEN.PotenceId,objQxUserGroupPotenceEN.RoleId);
throw new Exception(strMsg);
}
try
{
bool bolResult = QxUserGroupPotenceDA.AddNewRecordBySQL2(objQxUserGroupPotenceEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserGroupPotenceBL.ReFreshCache();

if (clsQxUserGroupPotenceBL.relatedActions != null)
{
clsQxUserGroupPotenceBL.relatedActions.UpdRelaTabDate(objQxUserGroupPotenceEN.mId, "SetUpdDate");
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
 /// <param name = "objQxUserGroupPotenceEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsQxUserGroupPotenceEN objQxUserGroupPotenceEN)
{
if (objQxUserGroupPotenceEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!用户ID = [{0}],组Id = [{1}],权限ID = [{2}],角色Id = [{3}]的数据已经存在!(in clsQxUserGroupPotenceBL.AddNewRecordBySql2WithReturnKey)", objQxUserGroupPotenceEN.UserId,objQxUserGroupPotenceEN.GroupId,objQxUserGroupPotenceEN.PotenceId,objQxUserGroupPotenceEN.RoleId);
throw new Exception(strMsg);
}
try
{
string strKey = QxUserGroupPotenceDA.AddNewRecordBySQL2WithReturnKey(objQxUserGroupPotenceEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserGroupPotenceBL.ReFreshCache();

if (clsQxUserGroupPotenceBL.relatedActions != null)
{
clsQxUserGroupPotenceBL.relatedActions.UpdRelaTabDate(objQxUserGroupPotenceEN.mId, "SetUpdDate");
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
 /// <param name = "strQxUserGroupPotenceObjXml">代表实体对象的XML串</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql_XML(string strQxUserGroupPotenceObjXml)
{
clsQxUserGroupPotenceEN objQxUserGroupPotenceEN = GetObjFromXmlStr(strQxUserGroupPotenceObjXml);
try
{
bool bolResult = QxUserGroupPotenceDA.AddNewRecordBySQL2(objQxUserGroupPotenceEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserGroupPotenceBL.ReFreshCache();

if (clsQxUserGroupPotenceBL.relatedActions != null)
{
clsQxUserGroupPotenceBL.relatedActions.UpdRelaTabDate(objQxUserGroupPotenceEN.mId, "SetUpdDate");
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
 /// <param name = "objQxUserGroupPotenceEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsQxUserGroupPotenceEN objQxUserGroupPotenceEN)
{
try
{
bool bolResult = QxUserGroupPotenceDA.Update(objQxUserGroupPotenceEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserGroupPotenceBL.ReFreshCache();

if (clsQxUserGroupPotenceBL.relatedActions != null)
{
clsQxUserGroupPotenceBL.relatedActions.UpdRelaTabDate(objQxUserGroupPotenceEN.mId, "SetUpdDate");
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
 /// <param name = "objQxUserGroupPotenceEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsQxUserGroupPotenceEN objQxUserGroupPotenceEN)
{
 if (objQxUserGroupPotenceEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = QxUserGroupPotenceDA.UpdateBySql2(objQxUserGroupPotenceEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserGroupPotenceBL.ReFreshCache();

if (clsQxUserGroupPotenceBL.relatedActions != null)
{
clsQxUserGroupPotenceBL.relatedActions.UpdRelaTabDate(objQxUserGroupPotenceEN.mId, "SetUpdDate");
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
 /// <param name = "strQxUserGroupPotenceObjXml">需要修改的对象,用XML来表示</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql_XML(string strQxUserGroupPotenceObjXml)
{
clsQxUserGroupPotenceEN objQxUserGroupPotenceEN = GetObjFromXmlStr(strQxUserGroupPotenceObjXml);
try
{
bool bolResult = QxUserGroupPotenceDA.UpdateBySql2(objQxUserGroupPotenceEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserGroupPotenceBL.ReFreshCache();

if (clsQxUserGroupPotenceBL.relatedActions != null)
{
clsQxUserGroupPotenceBL.relatedActions.UpdRelaTabDate(objQxUserGroupPotenceEN.mId, "SetUpdDate");
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
 clsQxUserGroupPotenceEN objQxUserGroupPotenceEN = clsQxUserGroupPotenceBL.GetObjBymId(lngmId);

if (clsQxUserGroupPotenceBL.relatedActions != null)
{
clsQxUserGroupPotenceBL.relatedActions.UpdRelaTabDate(objQxUserGroupPotenceEN.mId, "SetUpdDate");
}
if (objQxUserGroupPotenceEN != null)
{
int intRecNum = QxUserGroupPotenceDA.DelRecord(lngmId);
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
objSQL = clsQxUserGroupPotenceDA.GetSpecSQLObj();
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
//删除与表:[QxUserGroupPotence]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conQxUserGroupPotence.mId,
//lngmId);
//        clsQxUserGroupPotenceBL.DelQxUserGroupPotencesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxUserGroupPotenceBL.DelRecord(lngmId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxUserGroupPotenceBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clsQxUserGroupPotenceBL.relatedActions != null)
{
clsQxUserGroupPotenceBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = QxUserGroupPotenceDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
if (clsQxUserGroupPotenceBL.relatedActions != null)
{
clsQxUserGroupPotenceBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = QxUserGroupPotenceDA.DelRecordBySP(lngmId);
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
public static int DelQxUserGroupPotences(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsQxUserGroupPotenceBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsQxUserGroupPotenceBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intDelRecNum = QxUserGroupPotenceDA.DelQxUserGroupPotence(arrmIdLst);
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
public static int DelQxUserGroupPotencesByCond(string strWhereCond)
{
try
{
if (clsQxUserGroupPotenceBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsQxUserGroupPotenceBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum = QxUserGroupPotenceDA.DelQxUserGroupPotence(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[QxUserGroupPotence]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxUserGroupPotenceDA.GetSpecSQLObj();
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
//删除与表:[QxUserGroupPotence]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxUserGroupPotenceBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxUserGroupPotenceBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objQxUserGroupPotenceENS">源对象</param>
 /// <param name = "objQxUserGroupPotenceENT">目标对象</param>
 public static void CopyTo(clsQxUserGroupPotenceEN objQxUserGroupPotenceENS, clsQxUserGroupPotenceEN objQxUserGroupPotenceENT)
{
try
{
objQxUserGroupPotenceENT.mId = objQxUserGroupPotenceENS.mId; //流水号
objQxUserGroupPotenceENT.UserId = objQxUserGroupPotenceENS.UserId; //用户ID
objQxUserGroupPotenceENT.GroupId = objQxUserGroupPotenceENS.GroupId; //组Id
objQxUserGroupPotenceENT.RoleId = objQxUserGroupPotenceENS.RoleId; //角色Id
objQxUserGroupPotenceENT.QxPrjId = objQxUserGroupPotenceENS.QxPrjId; //项目Id
objQxUserGroupPotenceENT.PotenceId = objQxUserGroupPotenceENS.PotenceId; //权限ID
objQxUserGroupPotenceENT.RelaMid = objQxUserGroupPotenceENS.RelaMid; //流水号
objQxUserGroupPotenceENT.Memo = objQxUserGroupPotenceENS.Memo; //备注
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
 /// <param name = "objQxUserGroupPotenceEN">源简化对象</param>
 public static void SetUpdFlag(clsQxUserGroupPotenceEN objQxUserGroupPotenceEN)
{
try
{
objQxUserGroupPotenceEN.ClearUpdateState();
   string strsfUpdFldSetStr = objQxUserGroupPotenceEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conQxUserGroupPotence.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserGroupPotenceEN.mId = objQxUserGroupPotenceEN.mId; //流水号
}
if (arrFldSet.Contains(conQxUserGroupPotence.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserGroupPotenceEN.UserId = objQxUserGroupPotenceEN.UserId == "[null]" ? null :  objQxUserGroupPotenceEN.UserId; //用户ID
}
if (arrFldSet.Contains(conQxUserGroupPotence.GroupId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserGroupPotenceEN.GroupId = objQxUserGroupPotenceEN.GroupId == "[null]" ? null :  objQxUserGroupPotenceEN.GroupId; //组Id
}
if (arrFldSet.Contains(conQxUserGroupPotence.RoleId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserGroupPotenceEN.RoleId = objQxUserGroupPotenceEN.RoleId == "[null]" ? null :  objQxUserGroupPotenceEN.RoleId; //角色Id
}
if (arrFldSet.Contains(conQxUserGroupPotence.QxPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserGroupPotenceEN.QxPrjId = objQxUserGroupPotenceEN.QxPrjId; //项目Id
}
if (arrFldSet.Contains(conQxUserGroupPotence.PotenceId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserGroupPotenceEN.PotenceId = objQxUserGroupPotenceEN.PotenceId; //权限ID
}
if (arrFldSet.Contains(conQxUserGroupPotence.RelaMid, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserGroupPotenceEN.RelaMid = objQxUserGroupPotenceEN.RelaMid; //流水号
}
if (arrFldSet.Contains(conQxUserGroupPotence.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserGroupPotenceEN.Memo = objQxUserGroupPotenceEN.Memo == "[null]" ? null :  objQxUserGroupPotenceEN.Memo; //备注
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
 /// <param name = "objQxUserGroupPotenceEN">源简化对象</param>
 public static void AccessFldValueNull(clsQxUserGroupPotenceEN objQxUserGroupPotenceEN)
{
try
{
if (objQxUserGroupPotenceEN.UserId == "[null]") objQxUserGroupPotenceEN.UserId = null; //用户ID
if (objQxUserGroupPotenceEN.GroupId == "[null]") objQxUserGroupPotenceEN.GroupId = null; //组Id
if (objQxUserGroupPotenceEN.RoleId == "[null]") objQxUserGroupPotenceEN.RoleId = null; //角色Id
if (objQxUserGroupPotenceEN.Memo == "[null]") objQxUserGroupPotenceEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsQxUserGroupPotenceEN objQxUserGroupPotenceEN)
{
 QxUserGroupPotenceDA.CheckPropertyNew(objQxUserGroupPotenceEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsQxUserGroupPotenceEN objQxUserGroupPotenceEN)
{
 QxUserGroupPotenceDA.CheckProperty4Condition(objQxUserGroupPotenceEN);
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
if (clsQxUserGroupPotenceBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxUserGroupPotenceBL没有刷新缓存机制(clsQxUserGroupPotenceBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrQxUserGroupPotenceObjLstCache == null)
//{
//arrQxUserGroupPotenceObjLstCache = QxUserGroupPotenceDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxUserGroupPotenceEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsQxUserGroupPotenceEN._CurrTabName);
List<clsQxUserGroupPotenceEN> arrQxUserGroupPotenceObjLstCache = GetObjLstCache();
IEnumerable <clsQxUserGroupPotenceEN> arrQxUserGroupPotenceObjLst_Sel =
arrQxUserGroupPotenceObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrQxUserGroupPotenceObjLst_Sel.Count() == 0)
{
   clsQxUserGroupPotenceEN obj = clsQxUserGroupPotenceBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrQxUserGroupPotenceObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxUserGroupPotenceEN> GetAllQxUserGroupPotenceObjLstCache()
{
//获取缓存中的对象列表
List<clsQxUserGroupPotenceEN> arrQxUserGroupPotenceObjLstCache = GetObjLstCache(); 
return arrQxUserGroupPotenceObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxUserGroupPotenceEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsQxUserGroupPotenceEN._CurrTabName);
List<clsQxUserGroupPotenceEN> arrQxUserGroupPotenceObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrQxUserGroupPotenceObjLstCache;
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
string strKey = string.Format("{0}", clsQxUserGroupPotenceEN._CurrTabName);
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
if (clsQxUserGroupPotenceBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsQxUserGroupPotenceEN._CurrTabName);
CacheHelper.Remove(strKey);
clsQxUserGroupPotenceBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--QxUserGroupPotence(用户权限关系)
 /// 唯一性条件:UserId_GroupId_PotenceId_RoleId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQxUserGroupPotenceEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsQxUserGroupPotenceEN objQxUserGroupPotenceEN)
{
//检测记录是否存在
string strResult = QxUserGroupPotenceDA.GetUniCondStr(objQxUserGroupPotenceEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstQxUserGroupPotenceObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsQxUserGroupPotenceEN> lstQxUserGroupPotenceObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstQxUserGroupPotenceObjLst, writer);
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
 /// <param name = "lstQxUserGroupPotenceObjLst">[clsQxUserGroupPotenceEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsQxUserGroupPotenceEN> lstQxUserGroupPotenceObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsQxUserGroupPotenceBL.listXmlNode);
writer.WriteStartElement(clsQxUserGroupPotenceBL.itemsXmlNode);
foreach (clsQxUserGroupPotenceEN objQxUserGroupPotenceEN in lstQxUserGroupPotenceObjLst)
{
clsQxUserGroupPotenceBL.SerializeXML(writer, objQxUserGroupPotenceEN);
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
 /// <param name = "objQxUserGroupPotenceEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsQxUserGroupPotenceEN objQxUserGroupPotenceEN)
{
writer.WriteStartElement(clsQxUserGroupPotenceBL.itemXmlNode);
 
writer.WriteElementString(conQxUserGroupPotence.mId, objQxUserGroupPotenceEN.mId.ToString(CultureInfo.InvariantCulture));
 
if (objQxUserGroupPotenceEN.UserId != null)
{
writer.WriteElementString(conQxUserGroupPotence.UserId, objQxUserGroupPotenceEN.UserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUserGroupPotenceEN.GroupId != null)
{
writer.WriteElementString(conQxUserGroupPotence.GroupId, objQxUserGroupPotenceEN.GroupId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUserGroupPotenceEN.RoleId != null)
{
writer.WriteElementString(conQxUserGroupPotence.RoleId, objQxUserGroupPotenceEN.RoleId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUserGroupPotenceEN.QxPrjId != null)
{
writer.WriteElementString(conQxUserGroupPotence.QxPrjId, objQxUserGroupPotenceEN.QxPrjId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUserGroupPotenceEN.PotenceId != null)
{
writer.WriteElementString(conQxUserGroupPotence.PotenceId, objQxUserGroupPotenceEN.PotenceId.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(conQxUserGroupPotence.RelaMid, objQxUserGroupPotenceEN.RelaMid.ToString());
 
if (objQxUserGroupPotenceEN.Memo != null)
{
writer.WriteElementString(conQxUserGroupPotence.Memo, objQxUserGroupPotenceEN.Memo.ToString(CultureInfo.InvariantCulture));
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
public static clsQxUserGroupPotenceEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsQxUserGroupPotenceEN objQxUserGroupPotenceEN = new clsQxUserGroupPotenceEN();
reader.Read();
while (!(reader.Name == clsQxUserGroupPotenceBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(conQxUserGroupPotence.mId))
{
objQxUserGroupPotenceEN.mId = reader.ReadElementContentAsLong();
}
if (reader.IsStartElement(conQxUserGroupPotence.UserId))
{
objQxUserGroupPotenceEN.UserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUserGroupPotence.GroupId))
{
objQxUserGroupPotenceEN.GroupId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUserGroupPotence.RoleId))
{
objQxUserGroupPotenceEN.RoleId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUserGroupPotence.QxPrjId))
{
objQxUserGroupPotenceEN.QxPrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUserGroupPotence.PotenceId))
{
objQxUserGroupPotenceEN.PotenceId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUserGroupPotence.RelaMid))
{
objQxUserGroupPotenceEN.RelaMid = reader.ReadElementContentAsLong();
}
if (reader.IsStartElement(conQxUserGroupPotence.Memo))
{
objQxUserGroupPotenceEN.Memo = reader.ReadElementContentAsString();
}
}
return objQxUserGroupPotenceEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strQxUserGroupPotenceObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsQxUserGroupPotenceEN GetObjFromXmlStr(string strQxUserGroupPotenceObjXmlStr)
{
clsQxUserGroupPotenceEN objQxUserGroupPotenceEN = new clsQxUserGroupPotenceEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strQxUserGroupPotenceObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsQxUserGroupPotenceBL.itemXmlNode))
{
objQxUserGroupPotenceEN = GetObjFromXml(reader);
return objQxUserGroupPotenceEN;
}
}
return objQxUserGroupPotenceEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objQxUserGroupPotenceEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsQxUserGroupPotenceEN objQxUserGroupPotenceEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objQxUserGroupPotenceEN);
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
if (strInFldName != conQxUserGroupPotence.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conQxUserGroupPotence.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conQxUserGroupPotence.AttributeName));
throw new Exception(strMsg);
}
var objQxUserGroupPotence = clsQxUserGroupPotenceBL.GetObjBymIdCache(lngmId);
if (objQxUserGroupPotence == null) return "";
return objQxUserGroupPotence[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objQxUserGroupPotenceEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsQxUserGroupPotenceEN objQxUserGroupPotenceEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsQxUserGroupPotenceEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objQxUserGroupPotenceEN[strField]);
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
 /// <param name = "lstQxUserGroupPotenceObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsQxUserGroupPotenceEN> lstQxUserGroupPotenceObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstQxUserGroupPotenceObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsQxUserGroupPotenceEN objQxUserGroupPotenceEN in lstQxUserGroupPotenceObjLst)
{
string strJSON_One = SerializeObjToJSON(objQxUserGroupPotenceEN);
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
int intRecCount = clsQxUserGroupPotenceDA.GetRecCount(strTabName);
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
int intRecCount = clsQxUserGroupPotenceDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsQxUserGroupPotenceDA.GetRecCount();
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
int intRecCount = clsQxUserGroupPotenceDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objQxUserGroupPotenceCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsQxUserGroupPotenceEN objQxUserGroupPotenceCond)
{
List<clsQxUserGroupPotenceEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxUserGroupPotenceEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxUserGroupPotence.AttributeName)
{
if (objQxUserGroupPotenceCond.IsUpdated(strFldName) == false) continue;
if (objQxUserGroupPotenceCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUserGroupPotenceCond[strFldName].ToString());
}
else
{
if (objQxUserGroupPotenceCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxUserGroupPotenceCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUserGroupPotenceCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxUserGroupPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxUserGroupPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxUserGroupPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxUserGroupPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxUserGroupPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxUserGroupPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxUserGroupPotenceCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxUserGroupPotenceCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxUserGroupPotenceCond[strFldName]));
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
 List<string> arrList = clsQxUserGroupPotenceDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = QxUserGroupPotenceDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = QxUserGroupPotenceDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = QxUserGroupPotenceDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxUserGroupPotenceDA.SetFldValue(clsQxUserGroupPotenceEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = QxUserGroupPotenceDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxUserGroupPotenceDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxUserGroupPotenceDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxUserGroupPotenceDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[QxUserGroupPotence] "); 
 strCreateTabCode.Append(" ( "); 
 // /**流水号*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**用户ID*/ 
 strCreateTabCode.Append(" UserId varchar(18) Null, "); 
 // /**组Id*/ 
 strCreateTabCode.Append(" GroupId char(8) Null, "); 
 // /**角色Id*/ 
 strCreateTabCode.Append(" RoleId char(8) Null, "); 
 // /**项目Id*/ 
 strCreateTabCode.Append(" QxPrjId char(4) not Null, "); 
 // /**权限ID*/ 
 strCreateTabCode.Append(" PotenceId char(8) not Null, "); 
 // /**流水号*/ 
 strCreateTabCode.Append(" RelaMid bigint Null, "); 
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
 /// 用户权限关系(QxUserGroupPotence)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4QxUserGroupPotence : clsCommFun4BL
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
clsQxUserGroupPotenceBL.ReFreshThisCache();
}
}

}