
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUsers_SchoolBL
 表名:QxUsers_School(00140074)
 * 版本:2023.12.26.1(服务器:WIN-SRV103-116)
 日期:2023/12/28 19:00:56
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
public static class  clsQxUsers_SchoolBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strUserId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxUsers_SchoolEN GetObj(this K_UserId_QxUsers_School myKey)
{
clsQxUsers_SchoolEN objQxUsers_SchoolEN = clsQxUsers_SchoolBL.QxUsers_SchoolDA.GetObjByUserId(myKey.Value);
return objQxUsers_SchoolEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQxUsers_SchoolEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQxUsers_SchoolEN objQxUsers_SchoolEN)
{
 if (string.IsNullOrEmpty(objQxUsers_SchoolEN.UserId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQxUsers_SchoolBL.IsExist(objQxUsers_SchoolEN.UserId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQxUsers_SchoolEN.UserId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsQxUsers_SchoolBL.QxUsers_SchoolDA.AddNewRecordBySQL2(objQxUsers_SchoolEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsers_SchoolBL.ReFreshCache();

if (clsQxUsers_SchoolBL.relatedActions != null)
{
clsQxUsers_SchoolBL.relatedActions.UpdRelaTabDate(objQxUsers_SchoolEN.UserId, objQxUsers_SchoolEN.UpdUser);
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
public static bool AddRecordEx(this clsQxUsers_SchoolEN objQxUsers_SchoolEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsQxUsers_SchoolBL.IsExist(objQxUsers_SchoolEN.UserId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objQxUsers_SchoolEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objQxUsers_SchoolEN.AddNewRecord();
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
 /// <param name = "objQxUsers_SchoolEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsQxUsers_SchoolEN objQxUsers_SchoolEN)
{
 if (string.IsNullOrEmpty(objQxUsers_SchoolEN.UserId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQxUsers_SchoolBL.IsExist(objQxUsers_SchoolEN.UserId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQxUsers_SchoolEN.UserId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsQxUsers_SchoolBL.QxUsers_SchoolDA.AddNewRecordBySQL2WithReturnKey(objQxUsers_SchoolEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsers_SchoolBL.ReFreshCache();

if (clsQxUsers_SchoolBL.relatedActions != null)
{
clsQxUsers_SchoolBL.relatedActions.UpdRelaTabDate(objQxUsers_SchoolEN.UserId, objQxUsers_SchoolEN.UpdUser);
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
 /// <param name = "objQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsers_SchoolEN SetUserId(this clsQxUsers_SchoolEN objQxUsers_SchoolEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conQxUsers_School.UserId);
}
objQxUsers_SchoolEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsers_SchoolEN.dicFldComparisonOp.ContainsKey(conQxUsers_School.UserId) == false)
{
objQxUsers_SchoolEN.dicFldComparisonOp.Add(conQxUsers_School.UserId, strComparisonOp);
}
else
{
objQxUsers_SchoolEN.dicFldComparisonOp[conQxUsers_School.UserId] = strComparisonOp;
}
}
return objQxUsers_SchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsers_SchoolEN SetIdentityId(this clsQxUsers_SchoolEN objQxUsers_SchoolEN, string strIdentityId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdentityId, conQxUsers_School.IdentityId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdentityId, 2, conQxUsers_School.IdentityId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdentityId, 2, conQxUsers_School.IdentityId);
}
objQxUsers_SchoolEN.IdentityId = strIdentityId; //身份编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsers_SchoolEN.dicFldComparisonOp.ContainsKey(conQxUsers_School.IdentityId) == false)
{
objQxUsers_SchoolEN.dicFldComparisonOp.Add(conQxUsers_School.IdentityId, strComparisonOp);
}
else
{
objQxUsers_SchoolEN.dicFldComparisonOp[conQxUsers_School.IdentityId] = strComparisonOp;
}
}
return objQxUsers_SchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsers_SchoolEN SetCardNo(this clsQxUsers_SchoolEN objQxUsers_SchoolEN, string strCardNo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCardNo, 10, conQxUsers_School.CardNo);
}
objQxUsers_SchoolEN.CardNo = strCardNo; //卡号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsers_SchoolEN.dicFldComparisonOp.ContainsKey(conQxUsers_School.CardNo) == false)
{
objQxUsers_SchoolEN.dicFldComparisonOp.Add(conQxUsers_School.CardNo, strComparisonOp);
}
else
{
objQxUsers_SchoolEN.dicFldComparisonOp[conQxUsers_School.CardNo] = strComparisonOp;
}
}
return objQxUsers_SchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsers_SchoolEN SetStuTeacherId(this clsQxUsers_SchoolEN objQxUsers_SchoolEN, string strStuTeacherId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuTeacherId, 20, conQxUsers_School.StuTeacherId);
}
objQxUsers_SchoolEN.StuTeacherId = strStuTeacherId; //学工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsers_SchoolEN.dicFldComparisonOp.ContainsKey(conQxUsers_School.StuTeacherId) == false)
{
objQxUsers_SchoolEN.dicFldComparisonOp.Add(conQxUsers_School.StuTeacherId, strComparisonOp);
}
else
{
objQxUsers_SchoolEN.dicFldComparisonOp[conQxUsers_School.StuTeacherId] = strComparisonOp;
}
}
return objQxUsers_SchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsers_SchoolEN SetIdGradeBase(this clsQxUsers_SchoolEN objQxUsers_SchoolEN, string strIdGradeBase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdGradeBase, 4, conQxUsers_School.IdGradeBase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdGradeBase, 4, conQxUsers_School.IdGradeBase);
}
objQxUsers_SchoolEN.IdGradeBase = strIdGradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsers_SchoolEN.dicFldComparisonOp.ContainsKey(conQxUsers_School.IdGradeBase) == false)
{
objQxUsers_SchoolEN.dicFldComparisonOp.Add(conQxUsers_School.IdGradeBase, strComparisonOp);
}
else
{
objQxUsers_SchoolEN.dicFldComparisonOp[conQxUsers_School.IdGradeBase] = strComparisonOp;
}
}
return objQxUsers_SchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsers_SchoolEN SetCardState(this clsQxUsers_SchoolEN objQxUsers_SchoolEN, string strCardState, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCardState, 10, conQxUsers_School.CardState);
}
objQxUsers_SchoolEN.CardState = strCardState; //卡状态
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsers_SchoolEN.dicFldComparisonOp.ContainsKey(conQxUsers_School.CardState) == false)
{
objQxUsers_SchoolEN.dicFldComparisonOp.Add(conQxUsers_School.CardState, strComparisonOp);
}
else
{
objQxUsers_SchoolEN.dicFldComparisonOp[conQxUsers_School.CardState] = strComparisonOp;
}
}
return objQxUsers_SchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsers_SchoolEN SetIsLeaved(this clsQxUsers_SchoolEN objQxUsers_SchoolEN, bool bolIsLeaved, string strComparisonOp="")
	{
objQxUsers_SchoolEN.IsLeaved = bolIsLeaved; //IsLeaved
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsers_SchoolEN.dicFldComparisonOp.ContainsKey(conQxUsers_School.IsLeaved) == false)
{
objQxUsers_SchoolEN.dicFldComparisonOp.Add(conQxUsers_School.IsLeaved, strComparisonOp);
}
else
{
objQxUsers_SchoolEN.dicFldComparisonOp[conQxUsers_School.IsLeaved] = strComparisonOp;
}
}
return objQxUsers_SchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsers_SchoolEN SetUpdDate(this clsQxUsers_SchoolEN objQxUsers_SchoolEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conQxUsers_School.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQxUsers_School.UpdDate);
}
objQxUsers_SchoolEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsers_SchoolEN.dicFldComparisonOp.ContainsKey(conQxUsers_School.UpdDate) == false)
{
objQxUsers_SchoolEN.dicFldComparisonOp.Add(conQxUsers_School.UpdDate, strComparisonOp);
}
else
{
objQxUsers_SchoolEN.dicFldComparisonOp[conQxUsers_School.UpdDate] = strComparisonOp;
}
}
return objQxUsers_SchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsers_SchoolEN SetUpdUser(this clsQxUsers_SchoolEN objQxUsers_SchoolEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conQxUsers_School.UpdUser);
}
objQxUsers_SchoolEN.UpdUser = strUpdUser; //修改用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsers_SchoolEN.dicFldComparisonOp.ContainsKey(conQxUsers_School.UpdUser) == false)
{
objQxUsers_SchoolEN.dicFldComparisonOp.Add(conQxUsers_School.UpdUser, strComparisonOp);
}
else
{
objQxUsers_SchoolEN.dicFldComparisonOp[conQxUsers_School.UpdUser] = strComparisonOp;
}
}
return objQxUsers_SchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUsers_SchoolEN SetMemo(this clsQxUsers_SchoolEN objQxUsers_SchoolEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQxUsers_School.Memo);
}
objQxUsers_SchoolEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUsers_SchoolEN.dicFldComparisonOp.ContainsKey(conQxUsers_School.Memo) == false)
{
objQxUsers_SchoolEN.dicFldComparisonOp.Add(conQxUsers_School.Memo, strComparisonOp);
}
else
{
objQxUsers_SchoolEN.dicFldComparisonOp[conQxUsers_School.Memo] = strComparisonOp;
}
}
return objQxUsers_SchoolEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objQxUsers_SchoolEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsQxUsers_SchoolEN objQxUsers_SchoolEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objQxUsers_SchoolEN.CheckPropertyNew();
clsQxUsers_SchoolEN objQxUsers_SchoolCond = new clsQxUsers_SchoolEN();
string strCondition = objQxUsers_SchoolCond
.SetUserId(objQxUsers_SchoolEN.UserId, "=")
.GetCombineCondition();
objQxUsers_SchoolEN._IsCheckProperty = true;
bool bolIsExist = clsQxUsers_SchoolBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objQxUsers_SchoolEN.Update();
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
 /// <param name = "objQxUsers_SchoolEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxUsers_SchoolEN objQxUsers_SchoolEN)
{
 if (string.IsNullOrEmpty(objQxUsers_SchoolEN.UserId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxUsers_SchoolBL.QxUsers_SchoolDA.UpdateBySql2(objQxUsers_SchoolEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsers_SchoolBL.ReFreshCache();

if (clsQxUsers_SchoolBL.relatedActions != null)
{
clsQxUsers_SchoolBL.relatedActions.UpdRelaTabDate(objQxUsers_SchoolEN.UserId, objQxUsers_SchoolEN.UpdUser);
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
 /// <param name = "objQxUsers_SchoolEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxUsers_SchoolEN objQxUsers_SchoolEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objQxUsers_SchoolEN.UserId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxUsers_SchoolBL.QxUsers_SchoolDA.UpdateBySql2(objQxUsers_SchoolEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsers_SchoolBL.ReFreshCache();

if (clsQxUsers_SchoolBL.relatedActions != null)
{
clsQxUsers_SchoolBL.relatedActions.UpdRelaTabDate(objQxUsers_SchoolEN.UserId, objQxUsers_SchoolEN.UpdUser);
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
 /// <param name = "objQxUsers_SchoolEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxUsers_SchoolEN objQxUsers_SchoolEN, string strWhereCond)
{
try
{
bool bolResult = clsQxUsers_SchoolBL.QxUsers_SchoolDA.UpdateBySqlWithCondition(objQxUsers_SchoolEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsers_SchoolBL.ReFreshCache();

if (clsQxUsers_SchoolBL.relatedActions != null)
{
clsQxUsers_SchoolBL.relatedActions.UpdRelaTabDate(objQxUsers_SchoolEN.UserId, objQxUsers_SchoolEN.UpdUser);
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
 /// <param name = "objQxUsers_SchoolEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxUsers_SchoolEN objQxUsers_SchoolEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsQxUsers_SchoolBL.QxUsers_SchoolDA.UpdateBySqlWithConditionTransaction(objQxUsers_SchoolEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsers_SchoolBL.ReFreshCache();

if (clsQxUsers_SchoolBL.relatedActions != null)
{
clsQxUsers_SchoolBL.relatedActions.UpdRelaTabDate(objQxUsers_SchoolEN.UserId, objQxUsers_SchoolEN.UpdUser);
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
 /// <param name = "strUserId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsQxUsers_SchoolEN objQxUsers_SchoolEN)
{
try
{
int intRecNum = clsQxUsers_SchoolBL.QxUsers_SchoolDA.DelRecord(objQxUsers_SchoolEN.UserId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsers_SchoolBL.ReFreshCache();

if (clsQxUsers_SchoolBL.relatedActions != null)
{
clsQxUsers_SchoolBL.relatedActions.UpdRelaTabDate(objQxUsers_SchoolEN.UserId, objQxUsers_SchoolEN.UpdUser);
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
 /// <param name = "objQxUsers_SchoolENS">源对象</param>
 /// <param name = "objQxUsers_SchoolENT">目标对象</param>
 public static void CopyTo(this clsQxUsers_SchoolEN objQxUsers_SchoolENS, clsQxUsers_SchoolEN objQxUsers_SchoolENT)
{
try
{
objQxUsers_SchoolENT.UserId = objQxUsers_SchoolENS.UserId; //用户ID
objQxUsers_SchoolENT.IdentityId = objQxUsers_SchoolENS.IdentityId; //身份编号
objQxUsers_SchoolENT.CardNo = objQxUsers_SchoolENS.CardNo; //卡号
objQxUsers_SchoolENT.StuTeacherId = objQxUsers_SchoolENS.StuTeacherId; //学工号
objQxUsers_SchoolENT.IdGradeBase = objQxUsers_SchoolENS.IdGradeBase; //年级流水号
objQxUsers_SchoolENT.CardState = objQxUsers_SchoolENS.CardState; //卡状态
objQxUsers_SchoolENT.IsLeaved = objQxUsers_SchoolENS.IsLeaved; //IsLeaved
objQxUsers_SchoolENT.UpdDate = objQxUsers_SchoolENS.UpdDate; //修改日期
objQxUsers_SchoolENT.UpdUser = objQxUsers_SchoolENS.UpdUser; //修改用户
objQxUsers_SchoolENT.Memo = objQxUsers_SchoolENS.Memo; //备注
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
 /// <param name = "objQxUsers_SchoolENS">源对象</param>
 /// <returns>目标对象=>clsQxUsers_SchoolEN:objQxUsers_SchoolENT</returns>
 public static clsQxUsers_SchoolEN CopyTo(this clsQxUsers_SchoolEN objQxUsers_SchoolENS)
{
try
{
 clsQxUsers_SchoolEN objQxUsers_SchoolENT = new clsQxUsers_SchoolEN()
{
UserId = objQxUsers_SchoolENS.UserId, //用户ID
IdentityId = objQxUsers_SchoolENS.IdentityId, //身份编号
CardNo = objQxUsers_SchoolENS.CardNo, //卡号
StuTeacherId = objQxUsers_SchoolENS.StuTeacherId, //学工号
IdGradeBase = objQxUsers_SchoolENS.IdGradeBase, //年级流水号
CardState = objQxUsers_SchoolENS.CardState, //卡状态
IsLeaved = objQxUsers_SchoolENS.IsLeaved, //IsLeaved
UpdDate = objQxUsers_SchoolENS.UpdDate, //修改日期
UpdUser = objQxUsers_SchoolENS.UpdUser, //修改用户
Memo = objQxUsers_SchoolENS.Memo, //备注
};
 return objQxUsers_SchoolENT;
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
public static void CheckPropertyNew(this clsQxUsers_SchoolEN objQxUsers_SchoolEN)
{
 clsQxUsers_SchoolBL.QxUsers_SchoolDA.CheckPropertyNew(objQxUsers_SchoolEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsQxUsers_SchoolEN objQxUsers_SchoolEN)
{
 clsQxUsers_SchoolBL.QxUsers_SchoolDA.CheckProperty4Condition(objQxUsers_SchoolEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQxUsers_SchoolEN objQxUsers_SchoolCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQxUsers_SchoolCond.IsUpdated(conQxUsers_School.UserId) == true)
{
string strComparisonOpUserId = objQxUsers_SchoolCond.dicFldComparisonOp[conQxUsers_School.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers_School.UserId, objQxUsers_SchoolCond.UserId, strComparisonOpUserId);
}
if (objQxUsers_SchoolCond.IsUpdated(conQxUsers_School.IdentityId) == true)
{
string strComparisonOpIdentityId = objQxUsers_SchoolCond.dicFldComparisonOp[conQxUsers_School.IdentityId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers_School.IdentityId, objQxUsers_SchoolCond.IdentityId, strComparisonOpIdentityId);
}
if (objQxUsers_SchoolCond.IsUpdated(conQxUsers_School.CardNo) == true)
{
string strComparisonOpCardNo = objQxUsers_SchoolCond.dicFldComparisonOp[conQxUsers_School.CardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers_School.CardNo, objQxUsers_SchoolCond.CardNo, strComparisonOpCardNo);
}
if (objQxUsers_SchoolCond.IsUpdated(conQxUsers_School.StuTeacherId) == true)
{
string strComparisonOpStuTeacherId = objQxUsers_SchoolCond.dicFldComparisonOp[conQxUsers_School.StuTeacherId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers_School.StuTeacherId, objQxUsers_SchoolCond.StuTeacherId, strComparisonOpStuTeacherId);
}
if (objQxUsers_SchoolCond.IsUpdated(conQxUsers_School.IdGradeBase) == true)
{
string strComparisonOpIdGradeBase = objQxUsers_SchoolCond.dicFldComparisonOp[conQxUsers_School.IdGradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers_School.IdGradeBase, objQxUsers_SchoolCond.IdGradeBase, strComparisonOpIdGradeBase);
}
if (objQxUsers_SchoolCond.IsUpdated(conQxUsers_School.CardState) == true)
{
string strComparisonOpCardState = objQxUsers_SchoolCond.dicFldComparisonOp[conQxUsers_School.CardState];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers_School.CardState, objQxUsers_SchoolCond.CardState, strComparisonOpCardState);
}
if (objQxUsers_SchoolCond.IsUpdated(conQxUsers_School.IsLeaved) == true)
{
if (objQxUsers_SchoolCond.IsLeaved == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQxUsers_School.IsLeaved);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQxUsers_School.IsLeaved);
}
}
if (objQxUsers_SchoolCond.IsUpdated(conQxUsers_School.UpdDate) == true)
{
string strComparisonOpUpdDate = objQxUsers_SchoolCond.dicFldComparisonOp[conQxUsers_School.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers_School.UpdDate, objQxUsers_SchoolCond.UpdDate, strComparisonOpUpdDate);
}
if (objQxUsers_SchoolCond.IsUpdated(conQxUsers_School.UpdUser) == true)
{
string strComparisonOpUpdUser = objQxUsers_SchoolCond.dicFldComparisonOp[conQxUsers_School.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers_School.UpdUser, objQxUsers_SchoolCond.UpdUser, strComparisonOpUpdUser);
}
if (objQxUsers_SchoolCond.IsUpdated(conQxUsers_School.Memo) == true)
{
string strComparisonOpMemo = objQxUsers_SchoolCond.dicFldComparisonOp[conQxUsers_School.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUsers_School.Memo, objQxUsers_SchoolCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_QxUsers_School
{
public virtual bool UpdRelaTabDate(string strUserId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 用户_学校(QxUsers_School)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsQxUsers_SchoolBL
{
public static RelatedActions_QxUsers_School relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "QxUsers_SchoolListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "QxUsers_SchoolList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsQxUsers_SchoolEN> arrQxUsers_SchoolObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsQxUsers_SchoolDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsQxUsers_SchoolDA QxUsers_SchoolDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsQxUsers_SchoolDA();
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
 public clsQxUsers_SchoolBL()
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
if (string.IsNullOrEmpty(clsQxUsers_SchoolEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxUsers_SchoolEN._ConnectString);
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
objDS = QxUsers_SchoolDA.GetDataSet(strWhereCond);
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
objDS = QxUsers_SchoolDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = QxUsers_SchoolDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_QxUsers_School(string strWhereCond)
{
DataTable objDT;
try
{
objDT = QxUsers_SchoolDA.GetDataTable_QxUsers_School(strWhereCond);
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
objDT = QxUsers_SchoolDA.GetDataTable(strWhereCond);
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
objDT = QxUsers_SchoolDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = QxUsers_SchoolDA.GetDataTable(strWhereCond, strTabName);
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
objDT = QxUsers_SchoolDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = QxUsers_SchoolDA.GetDataTable_Top(objTopPara);
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
objDT = QxUsers_SchoolDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = QxUsers_SchoolDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = QxUsers_SchoolDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = QxUsers_SchoolDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = QxUsers_SchoolDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = QxUsers_SchoolDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = QxUsers_SchoolDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = QxUsers_SchoolDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
 /// <param name = "arrUserIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsQxUsers_SchoolEN> GetObjLstByUserIdLst(List<string> arrUserIdLst)
{
List<clsQxUsers_SchoolEN> arrObjLst = new List<clsQxUsers_SchoolEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrUserIdLst, true);
 string strWhereCond = string.Format("UserId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsers_SchoolEN objQxUsers_SchoolEN = new clsQxUsers_SchoolEN();
try
{
objQxUsers_SchoolEN.UserId = objRow[conQxUsers_School.UserId].ToString().Trim(); //用户ID
objQxUsers_SchoolEN.IdentityId = objRow[conQxUsers_School.IdentityId].ToString().Trim(); //身份编号
objQxUsers_SchoolEN.CardNo = objRow[conQxUsers_School.CardNo] == DBNull.Value ? null : objRow[conQxUsers_School.CardNo].ToString().Trim(); //卡号
objQxUsers_SchoolEN.StuTeacherId = objRow[conQxUsers_School.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsers_School.StuTeacherId].ToString().Trim(); //学工号
objQxUsers_SchoolEN.IdGradeBase = objRow[conQxUsers_School.IdGradeBase] == DBNull.Value ? null : objRow[conQxUsers_School.IdGradeBase].ToString().Trim(); //年级流水号
objQxUsers_SchoolEN.CardState = objRow[conQxUsers_School.CardState] == DBNull.Value ? null : objRow[conQxUsers_School.CardState].ToString().Trim(); //卡状态
objQxUsers_SchoolEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers_School.IsLeaved].ToString().Trim()); //IsLeaved
objQxUsers_SchoolEN.UpdDate = objRow[conQxUsers_School.UpdDate].ToString().Trim(); //修改日期
objQxUsers_SchoolEN.UpdUser = objRow[conQxUsers_School.UpdUser] == DBNull.Value ? null : objRow[conQxUsers_School.UpdUser].ToString().Trim(); //修改用户
objQxUsers_SchoolEN.Memo = objRow[conQxUsers_School.Memo] == DBNull.Value ? null : objRow[conQxUsers_School.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUsers_SchoolEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUsers_SchoolEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrUserIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsQxUsers_SchoolEN> GetObjLstByUserIdLstCache(List<string> arrUserIdLst)
{
string strKey = string.Format("{0}", clsQxUsers_SchoolEN._CurrTabName);
List<clsQxUsers_SchoolEN> arrQxUsers_SchoolObjLstCache = GetObjLstCache();
IEnumerable <clsQxUsers_SchoolEN> arrQxUsers_SchoolObjLst_Sel =
arrQxUsers_SchoolObjLstCache
.Where(x => arrUserIdLst.Contains(x.UserId));
return arrQxUsers_SchoolObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUsers_SchoolEN> GetObjLst(string strWhereCond)
{
List<clsQxUsers_SchoolEN> arrObjLst = new List<clsQxUsers_SchoolEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsers_SchoolEN objQxUsers_SchoolEN = new clsQxUsers_SchoolEN();
try
{
objQxUsers_SchoolEN.UserId = objRow[conQxUsers_School.UserId].ToString().Trim(); //用户ID
objQxUsers_SchoolEN.IdentityId = objRow[conQxUsers_School.IdentityId].ToString().Trim(); //身份编号
objQxUsers_SchoolEN.CardNo = objRow[conQxUsers_School.CardNo] == DBNull.Value ? null : objRow[conQxUsers_School.CardNo].ToString().Trim(); //卡号
objQxUsers_SchoolEN.StuTeacherId = objRow[conQxUsers_School.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsers_School.StuTeacherId].ToString().Trim(); //学工号
objQxUsers_SchoolEN.IdGradeBase = objRow[conQxUsers_School.IdGradeBase] == DBNull.Value ? null : objRow[conQxUsers_School.IdGradeBase].ToString().Trim(); //年级流水号
objQxUsers_SchoolEN.CardState = objRow[conQxUsers_School.CardState] == DBNull.Value ? null : objRow[conQxUsers_School.CardState].ToString().Trim(); //卡状态
objQxUsers_SchoolEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers_School.IsLeaved].ToString().Trim()); //IsLeaved
objQxUsers_SchoolEN.UpdDate = objRow[conQxUsers_School.UpdDate].ToString().Trim(); //修改日期
objQxUsers_SchoolEN.UpdUser = objRow[conQxUsers_School.UpdUser] == DBNull.Value ? null : objRow[conQxUsers_School.UpdUser].ToString().Trim(); //修改用户
objQxUsers_SchoolEN.Memo = objRow[conQxUsers_School.Memo] == DBNull.Value ? null : objRow[conQxUsers_School.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUsers_SchoolEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUsers_SchoolEN);
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
public static List<clsQxUsers_SchoolEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsQxUsers_SchoolEN> arrObjLst = new List<clsQxUsers_SchoolEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsers_SchoolEN objQxUsers_SchoolEN = new clsQxUsers_SchoolEN();
try
{
objQxUsers_SchoolEN.UserId = objRow[conQxUsers_School.UserId].ToString().Trim(); //用户ID
objQxUsers_SchoolEN.IdentityId = objRow[conQxUsers_School.IdentityId].ToString().Trim(); //身份编号
objQxUsers_SchoolEN.CardNo = objRow[conQxUsers_School.CardNo] == DBNull.Value ? null : objRow[conQxUsers_School.CardNo].ToString().Trim(); //卡号
objQxUsers_SchoolEN.StuTeacherId = objRow[conQxUsers_School.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsers_School.StuTeacherId].ToString().Trim(); //学工号
objQxUsers_SchoolEN.IdGradeBase = objRow[conQxUsers_School.IdGradeBase] == DBNull.Value ? null : objRow[conQxUsers_School.IdGradeBase].ToString().Trim(); //年级流水号
objQxUsers_SchoolEN.CardState = objRow[conQxUsers_School.CardState] == DBNull.Value ? null : objRow[conQxUsers_School.CardState].ToString().Trim(); //卡状态
objQxUsers_SchoolEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers_School.IsLeaved].ToString().Trim()); //IsLeaved
objQxUsers_SchoolEN.UpdDate = objRow[conQxUsers_School.UpdDate].ToString().Trim(); //修改日期
objQxUsers_SchoolEN.UpdUser = objRow[conQxUsers_School.UpdUser] == DBNull.Value ? null : objRow[conQxUsers_School.UpdUser].ToString().Trim(); //修改用户
objQxUsers_SchoolEN.Memo = objRow[conQxUsers_School.Memo] == DBNull.Value ? null : objRow[conQxUsers_School.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUsers_SchoolEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUsers_SchoolEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objQxUsers_SchoolCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsQxUsers_SchoolEN> GetSubObjLstCache(clsQxUsers_SchoolEN objQxUsers_SchoolCond)
{
List<clsQxUsers_SchoolEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxUsers_SchoolEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxUsers_School.AttributeName)
{
if (objQxUsers_SchoolCond.IsUpdated(strFldName) == false) continue;
if (objQxUsers_SchoolCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUsers_SchoolCond[strFldName].ToString());
}
else
{
if (objQxUsers_SchoolCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxUsers_SchoolCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUsers_SchoolCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxUsers_SchoolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxUsers_SchoolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxUsers_SchoolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxUsers_SchoolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxUsers_SchoolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxUsers_SchoolCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxUsers_SchoolCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxUsers_SchoolCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxUsers_SchoolCond[strFldName]));
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
public static List<clsQxUsers_SchoolEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsQxUsers_SchoolEN> arrObjLst = new List<clsQxUsers_SchoolEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsers_SchoolEN objQxUsers_SchoolEN = new clsQxUsers_SchoolEN();
try
{
objQxUsers_SchoolEN.UserId = objRow[conQxUsers_School.UserId].ToString().Trim(); //用户ID
objQxUsers_SchoolEN.IdentityId = objRow[conQxUsers_School.IdentityId].ToString().Trim(); //身份编号
objQxUsers_SchoolEN.CardNo = objRow[conQxUsers_School.CardNo] == DBNull.Value ? null : objRow[conQxUsers_School.CardNo].ToString().Trim(); //卡号
objQxUsers_SchoolEN.StuTeacherId = objRow[conQxUsers_School.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsers_School.StuTeacherId].ToString().Trim(); //学工号
objQxUsers_SchoolEN.IdGradeBase = objRow[conQxUsers_School.IdGradeBase] == DBNull.Value ? null : objRow[conQxUsers_School.IdGradeBase].ToString().Trim(); //年级流水号
objQxUsers_SchoolEN.CardState = objRow[conQxUsers_School.CardState] == DBNull.Value ? null : objRow[conQxUsers_School.CardState].ToString().Trim(); //卡状态
objQxUsers_SchoolEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers_School.IsLeaved].ToString().Trim()); //IsLeaved
objQxUsers_SchoolEN.UpdDate = objRow[conQxUsers_School.UpdDate].ToString().Trim(); //修改日期
objQxUsers_SchoolEN.UpdUser = objRow[conQxUsers_School.UpdUser] == DBNull.Value ? null : objRow[conQxUsers_School.UpdUser].ToString().Trim(); //修改用户
objQxUsers_SchoolEN.Memo = objRow[conQxUsers_School.Memo] == DBNull.Value ? null : objRow[conQxUsers_School.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUsers_SchoolEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUsers_SchoolEN);
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
public static List<clsQxUsers_SchoolEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsQxUsers_SchoolEN> arrObjLst = new List<clsQxUsers_SchoolEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsers_SchoolEN objQxUsers_SchoolEN = new clsQxUsers_SchoolEN();
try
{
objQxUsers_SchoolEN.UserId = objRow[conQxUsers_School.UserId].ToString().Trim(); //用户ID
objQxUsers_SchoolEN.IdentityId = objRow[conQxUsers_School.IdentityId].ToString().Trim(); //身份编号
objQxUsers_SchoolEN.CardNo = objRow[conQxUsers_School.CardNo] == DBNull.Value ? null : objRow[conQxUsers_School.CardNo].ToString().Trim(); //卡号
objQxUsers_SchoolEN.StuTeacherId = objRow[conQxUsers_School.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsers_School.StuTeacherId].ToString().Trim(); //学工号
objQxUsers_SchoolEN.IdGradeBase = objRow[conQxUsers_School.IdGradeBase] == DBNull.Value ? null : objRow[conQxUsers_School.IdGradeBase].ToString().Trim(); //年级流水号
objQxUsers_SchoolEN.CardState = objRow[conQxUsers_School.CardState] == DBNull.Value ? null : objRow[conQxUsers_School.CardState].ToString().Trim(); //卡状态
objQxUsers_SchoolEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers_School.IsLeaved].ToString().Trim()); //IsLeaved
objQxUsers_SchoolEN.UpdDate = objRow[conQxUsers_School.UpdDate].ToString().Trim(); //修改日期
objQxUsers_SchoolEN.UpdUser = objRow[conQxUsers_School.UpdUser] == DBNull.Value ? null : objRow[conQxUsers_School.UpdUser].ToString().Trim(); //修改用户
objQxUsers_SchoolEN.Memo = objRow[conQxUsers_School.Memo] == DBNull.Value ? null : objRow[conQxUsers_School.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUsers_SchoolEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUsers_SchoolEN);
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
List<clsQxUsers_SchoolEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsQxUsers_SchoolEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUsers_SchoolEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsQxUsers_SchoolEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsQxUsers_SchoolEN> arrObjLst = new List<clsQxUsers_SchoolEN>(); 
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
	clsQxUsers_SchoolEN objQxUsers_SchoolEN = new clsQxUsers_SchoolEN();
try
{
objQxUsers_SchoolEN.UserId = objRow[conQxUsers_School.UserId].ToString().Trim(); //用户ID
objQxUsers_SchoolEN.IdentityId = objRow[conQxUsers_School.IdentityId].ToString().Trim(); //身份编号
objQxUsers_SchoolEN.CardNo = objRow[conQxUsers_School.CardNo] == DBNull.Value ? null : objRow[conQxUsers_School.CardNo].ToString().Trim(); //卡号
objQxUsers_SchoolEN.StuTeacherId = objRow[conQxUsers_School.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsers_School.StuTeacherId].ToString().Trim(); //学工号
objQxUsers_SchoolEN.IdGradeBase = objRow[conQxUsers_School.IdGradeBase] == DBNull.Value ? null : objRow[conQxUsers_School.IdGradeBase].ToString().Trim(); //年级流水号
objQxUsers_SchoolEN.CardState = objRow[conQxUsers_School.CardState] == DBNull.Value ? null : objRow[conQxUsers_School.CardState].ToString().Trim(); //卡状态
objQxUsers_SchoolEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers_School.IsLeaved].ToString().Trim()); //IsLeaved
objQxUsers_SchoolEN.UpdDate = objRow[conQxUsers_School.UpdDate].ToString().Trim(); //修改日期
objQxUsers_SchoolEN.UpdUser = objRow[conQxUsers_School.UpdUser] == DBNull.Value ? null : objRow[conQxUsers_School.UpdUser].ToString().Trim(); //修改用户
objQxUsers_SchoolEN.Memo = objRow[conQxUsers_School.Memo] == DBNull.Value ? null : objRow[conQxUsers_School.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUsers_SchoolEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUsers_SchoolEN);
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
public static List<clsQxUsers_SchoolEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsQxUsers_SchoolEN> arrObjLst = new List<clsQxUsers_SchoolEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsers_SchoolEN objQxUsers_SchoolEN = new clsQxUsers_SchoolEN();
try
{
objQxUsers_SchoolEN.UserId = objRow[conQxUsers_School.UserId].ToString().Trim(); //用户ID
objQxUsers_SchoolEN.IdentityId = objRow[conQxUsers_School.IdentityId].ToString().Trim(); //身份编号
objQxUsers_SchoolEN.CardNo = objRow[conQxUsers_School.CardNo] == DBNull.Value ? null : objRow[conQxUsers_School.CardNo].ToString().Trim(); //卡号
objQxUsers_SchoolEN.StuTeacherId = objRow[conQxUsers_School.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsers_School.StuTeacherId].ToString().Trim(); //学工号
objQxUsers_SchoolEN.IdGradeBase = objRow[conQxUsers_School.IdGradeBase] == DBNull.Value ? null : objRow[conQxUsers_School.IdGradeBase].ToString().Trim(); //年级流水号
objQxUsers_SchoolEN.CardState = objRow[conQxUsers_School.CardState] == DBNull.Value ? null : objRow[conQxUsers_School.CardState].ToString().Trim(); //卡状态
objQxUsers_SchoolEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers_School.IsLeaved].ToString().Trim()); //IsLeaved
objQxUsers_SchoolEN.UpdDate = objRow[conQxUsers_School.UpdDate].ToString().Trim(); //修改日期
objQxUsers_SchoolEN.UpdUser = objRow[conQxUsers_School.UpdUser] == DBNull.Value ? null : objRow[conQxUsers_School.UpdUser].ToString().Trim(); //修改用户
objQxUsers_SchoolEN.Memo = objRow[conQxUsers_School.Memo] == DBNull.Value ? null : objRow[conQxUsers_School.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUsers_SchoolEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUsers_SchoolEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsQxUsers_SchoolEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsQxUsers_SchoolEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsQxUsers_SchoolEN> arrObjLst = new List<clsQxUsers_SchoolEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsers_SchoolEN objQxUsers_SchoolEN = new clsQxUsers_SchoolEN();
try
{
objQxUsers_SchoolEN.UserId = objRow[conQxUsers_School.UserId].ToString().Trim(); //用户ID
objQxUsers_SchoolEN.IdentityId = objRow[conQxUsers_School.IdentityId].ToString().Trim(); //身份编号
objQxUsers_SchoolEN.CardNo = objRow[conQxUsers_School.CardNo] == DBNull.Value ? null : objRow[conQxUsers_School.CardNo].ToString().Trim(); //卡号
objQxUsers_SchoolEN.StuTeacherId = objRow[conQxUsers_School.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsers_School.StuTeacherId].ToString().Trim(); //学工号
objQxUsers_SchoolEN.IdGradeBase = objRow[conQxUsers_School.IdGradeBase] == DBNull.Value ? null : objRow[conQxUsers_School.IdGradeBase].ToString().Trim(); //年级流水号
objQxUsers_SchoolEN.CardState = objRow[conQxUsers_School.CardState] == DBNull.Value ? null : objRow[conQxUsers_School.CardState].ToString().Trim(); //卡状态
objQxUsers_SchoolEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers_School.IsLeaved].ToString().Trim()); //IsLeaved
objQxUsers_SchoolEN.UpdDate = objRow[conQxUsers_School.UpdDate].ToString().Trim(); //修改日期
objQxUsers_SchoolEN.UpdUser = objRow[conQxUsers_School.UpdUser] == DBNull.Value ? null : objRow[conQxUsers_School.UpdUser].ToString().Trim(); //修改用户
objQxUsers_SchoolEN.Memo = objRow[conQxUsers_School.Memo] == DBNull.Value ? null : objRow[conQxUsers_School.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUsers_SchoolEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUsers_SchoolEN);
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
public static List<clsQxUsers_SchoolEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsQxUsers_SchoolEN> arrObjLst = new List<clsQxUsers_SchoolEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsers_SchoolEN objQxUsers_SchoolEN = new clsQxUsers_SchoolEN();
try
{
objQxUsers_SchoolEN.UserId = objRow[conQxUsers_School.UserId].ToString().Trim(); //用户ID
objQxUsers_SchoolEN.IdentityId = objRow[conQxUsers_School.IdentityId].ToString().Trim(); //身份编号
objQxUsers_SchoolEN.CardNo = objRow[conQxUsers_School.CardNo] == DBNull.Value ? null : objRow[conQxUsers_School.CardNo].ToString().Trim(); //卡号
objQxUsers_SchoolEN.StuTeacherId = objRow[conQxUsers_School.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsers_School.StuTeacherId].ToString().Trim(); //学工号
objQxUsers_SchoolEN.IdGradeBase = objRow[conQxUsers_School.IdGradeBase] == DBNull.Value ? null : objRow[conQxUsers_School.IdGradeBase].ToString().Trim(); //年级流水号
objQxUsers_SchoolEN.CardState = objRow[conQxUsers_School.CardState] == DBNull.Value ? null : objRow[conQxUsers_School.CardState].ToString().Trim(); //卡状态
objQxUsers_SchoolEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers_School.IsLeaved].ToString().Trim()); //IsLeaved
objQxUsers_SchoolEN.UpdDate = objRow[conQxUsers_School.UpdDate].ToString().Trim(); //修改日期
objQxUsers_SchoolEN.UpdUser = objRow[conQxUsers_School.UpdUser] == DBNull.Value ? null : objRow[conQxUsers_School.UpdUser].ToString().Trim(); //修改用户
objQxUsers_SchoolEN.Memo = objRow[conQxUsers_School.Memo] == DBNull.Value ? null : objRow[conQxUsers_School.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUsers_SchoolEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUsers_SchoolEN);
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
public static IEnumerable<clsQxUsers_SchoolEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsQxUsers_SchoolEN objQxUsers_SchoolCond, string strOrderBy)
{
List<clsQxUsers_SchoolEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxUsers_SchoolEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxUsers_School.AttributeName)
{
if (objQxUsers_SchoolCond.IsUpdated(strFldName) == false) continue;
if (objQxUsers_SchoolCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUsers_SchoolCond[strFldName].ToString());
}
else
{
if (objQxUsers_SchoolCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxUsers_SchoolCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUsers_SchoolCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxUsers_SchoolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxUsers_SchoolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxUsers_SchoolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxUsers_SchoolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxUsers_SchoolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxUsers_SchoolCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxUsers_SchoolCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxUsers_SchoolCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxUsers_SchoolCond[strFldName]));
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
public static IEnumerable<clsQxUsers_SchoolEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsQxUsers_SchoolEN objQxUsers_SchoolCond = JsonConvert.DeserializeObject<clsQxUsers_SchoolEN>(objPagerPara.whereCond);
if (objQxUsers_SchoolCond.sfFldComparisonOp == null)
{
objQxUsers_SchoolCond.dicFldComparisonOp = null;
}
else
{
objQxUsers_SchoolCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objQxUsers_SchoolCond.sfFldComparisonOp);
}
clsQxUsers_SchoolBL.SetUpdFlag(objQxUsers_SchoolCond);
 try
{
CheckProperty4Condition(objQxUsers_SchoolCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsQxUsers_SchoolBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objQxUsers_SchoolCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUsers_SchoolEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsQxUsers_SchoolEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsQxUsers_SchoolEN> arrObjLst = new List<clsQxUsers_SchoolEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsers_SchoolEN objQxUsers_SchoolEN = new clsQxUsers_SchoolEN();
try
{
objQxUsers_SchoolEN.UserId = objRow[conQxUsers_School.UserId].ToString().Trim(); //用户ID
objQxUsers_SchoolEN.IdentityId = objRow[conQxUsers_School.IdentityId].ToString().Trim(); //身份编号
objQxUsers_SchoolEN.CardNo = objRow[conQxUsers_School.CardNo] == DBNull.Value ? null : objRow[conQxUsers_School.CardNo].ToString().Trim(); //卡号
objQxUsers_SchoolEN.StuTeacherId = objRow[conQxUsers_School.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsers_School.StuTeacherId].ToString().Trim(); //学工号
objQxUsers_SchoolEN.IdGradeBase = objRow[conQxUsers_School.IdGradeBase] == DBNull.Value ? null : objRow[conQxUsers_School.IdGradeBase].ToString().Trim(); //年级流水号
objQxUsers_SchoolEN.CardState = objRow[conQxUsers_School.CardState] == DBNull.Value ? null : objRow[conQxUsers_School.CardState].ToString().Trim(); //卡状态
objQxUsers_SchoolEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers_School.IsLeaved].ToString().Trim()); //IsLeaved
objQxUsers_SchoolEN.UpdDate = objRow[conQxUsers_School.UpdDate].ToString().Trim(); //修改日期
objQxUsers_SchoolEN.UpdUser = objRow[conQxUsers_School.UpdUser] == DBNull.Value ? null : objRow[conQxUsers_School.UpdUser].ToString().Trim(); //修改用户
objQxUsers_SchoolEN.Memo = objRow[conQxUsers_School.Memo] == DBNull.Value ? null : objRow[conQxUsers_School.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUsers_SchoolEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUsers_SchoolEN);
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
public static List<clsQxUsers_SchoolEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsQxUsers_SchoolEN> arrObjLst = new List<clsQxUsers_SchoolEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsers_SchoolEN objQxUsers_SchoolEN = new clsQxUsers_SchoolEN();
try
{
objQxUsers_SchoolEN.UserId = objRow[conQxUsers_School.UserId].ToString().Trim(); //用户ID
objQxUsers_SchoolEN.IdentityId = objRow[conQxUsers_School.IdentityId].ToString().Trim(); //身份编号
objQxUsers_SchoolEN.CardNo = objRow[conQxUsers_School.CardNo] == DBNull.Value ? null : objRow[conQxUsers_School.CardNo].ToString().Trim(); //卡号
objQxUsers_SchoolEN.StuTeacherId = objRow[conQxUsers_School.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsers_School.StuTeacherId].ToString().Trim(); //学工号
objQxUsers_SchoolEN.IdGradeBase = objRow[conQxUsers_School.IdGradeBase] == DBNull.Value ? null : objRow[conQxUsers_School.IdGradeBase].ToString().Trim(); //年级流水号
objQxUsers_SchoolEN.CardState = objRow[conQxUsers_School.CardState] == DBNull.Value ? null : objRow[conQxUsers_School.CardState].ToString().Trim(); //卡状态
objQxUsers_SchoolEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers_School.IsLeaved].ToString().Trim()); //IsLeaved
objQxUsers_SchoolEN.UpdDate = objRow[conQxUsers_School.UpdDate].ToString().Trim(); //修改日期
objQxUsers_SchoolEN.UpdUser = objRow[conQxUsers_School.UpdUser] == DBNull.Value ? null : objRow[conQxUsers_School.UpdUser].ToString().Trim(); //修改用户
objQxUsers_SchoolEN.Memo = objRow[conQxUsers_School.Memo] == DBNull.Value ? null : objRow[conQxUsers_School.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUsers_SchoolEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUsers_SchoolEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUsers_SchoolEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsQxUsers_SchoolEN> arrObjLst = new List<clsQxUsers_SchoolEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsers_SchoolEN objQxUsers_SchoolEN = new clsQxUsers_SchoolEN();
try
{
objQxUsers_SchoolEN.UserId = objRow[conQxUsers_School.UserId].ToString().Trim(); //用户ID
objQxUsers_SchoolEN.IdentityId = objRow[conQxUsers_School.IdentityId].ToString().Trim(); //身份编号
objQxUsers_SchoolEN.CardNo = objRow[conQxUsers_School.CardNo] == DBNull.Value ? null : objRow[conQxUsers_School.CardNo].ToString().Trim(); //卡号
objQxUsers_SchoolEN.StuTeacherId = objRow[conQxUsers_School.StuTeacherId] == DBNull.Value ? null : objRow[conQxUsers_School.StuTeacherId].ToString().Trim(); //学工号
objQxUsers_SchoolEN.IdGradeBase = objRow[conQxUsers_School.IdGradeBase] == DBNull.Value ? null : objRow[conQxUsers_School.IdGradeBase].ToString().Trim(); //年级流水号
objQxUsers_SchoolEN.CardState = objRow[conQxUsers_School.CardState] == DBNull.Value ? null : objRow[conQxUsers_School.CardState].ToString().Trim(); //卡状态
objQxUsers_SchoolEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[conQxUsers_School.IsLeaved].ToString().Trim()); //IsLeaved
objQxUsers_SchoolEN.UpdDate = objRow[conQxUsers_School.UpdDate].ToString().Trim(); //修改日期
objQxUsers_SchoolEN.UpdUser = objRow[conQxUsers_School.UpdUser] == DBNull.Value ? null : objRow[conQxUsers_School.UpdUser].ToString().Trim(); //修改用户
objQxUsers_SchoolEN.Memo = objRow[conQxUsers_School.Memo] == DBNull.Value ? null : objRow[conQxUsers_School.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUsers_SchoolEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUsers_SchoolEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objQxUsers_SchoolEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxUsers_School(ref clsQxUsers_SchoolEN objQxUsers_SchoolEN)
{
bool bolResult = QxUsers_SchoolDA.GetQxUsers_School(ref objQxUsers_SchoolEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strUserId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxUsers_SchoolEN GetObjByUserId(string strUserId)
{
if (strUserId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strUserId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strUserId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strUserId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsQxUsers_SchoolEN objQxUsers_SchoolEN = QxUsers_SchoolDA.GetObjByUserId(strUserId);
return objQxUsers_SchoolEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsQxUsers_SchoolEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsQxUsers_SchoolEN objQxUsers_SchoolEN = QxUsers_SchoolDA.GetFirstObj(strWhereCond);
 return objQxUsers_SchoolEN;
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
public static clsQxUsers_SchoolEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsQxUsers_SchoolEN objQxUsers_SchoolEN = QxUsers_SchoolDA.GetObjByDataRow(objRow);
 return objQxUsers_SchoolEN;
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
public static clsQxUsers_SchoolEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsQxUsers_SchoolEN objQxUsers_SchoolEN = QxUsers_SchoolDA.GetObjByDataRow(objRow);
 return objQxUsers_SchoolEN;
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
 /// <param name = "strUserId">所给的关键字</param>
 /// <param name = "lstQxUsers_SchoolObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxUsers_SchoolEN GetObjByUserIdFromList(string strUserId, List<clsQxUsers_SchoolEN> lstQxUsers_SchoolObjLst)
{
foreach (clsQxUsers_SchoolEN objQxUsers_SchoolEN in lstQxUsers_SchoolObjLst)
{
if (objQxUsers_SchoolEN.UserId == strUserId)
{
return objQxUsers_SchoolEN;
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
 string strUserId;
 try
 {
 strUserId = new clsQxUsers_SchoolDA().GetFirstID(strWhereCond);
 return strUserId;
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
 arrList = QxUsers_SchoolDA.GetID(strWhereCond);
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
bool bolIsExist = QxUsers_SchoolDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strUserId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strUserId)
{
if (string.IsNullOrEmpty(strUserId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strUserId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = QxUsers_SchoolDA.IsExist(strUserId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strUserId">用户ID</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strUserId, string strOpUser)
{
clsQxUsers_SchoolEN objQxUsers_SchoolEN = clsQxUsers_SchoolBL.GetObjByUserId(strUserId);
objQxUsers_SchoolEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objQxUsers_SchoolEN.UpdUser = strOpUser;
return clsQxUsers_SchoolBL.UpdateBySql2(objQxUsers_SchoolEN);
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
 bolIsExist = clsQxUsers_SchoolDA.IsExistTable();
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
 bolIsExist = QxUsers_SchoolDA.IsExistTable(strTabName);
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
 /// <param name = "objQxUsers_SchoolEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsQxUsers_SchoolEN objQxUsers_SchoolEN)
{
 if (string.IsNullOrEmpty(objQxUsers_SchoolEN.UserId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQxUsers_SchoolBL.IsExist(objQxUsers_SchoolEN.UserId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQxUsers_SchoolEN.UserId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = QxUsers_SchoolDA.AddNewRecordBySQL2(objQxUsers_SchoolEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsers_SchoolBL.ReFreshCache();

if (clsQxUsers_SchoolBL.relatedActions != null)
{
clsQxUsers_SchoolBL.relatedActions.UpdRelaTabDate(objQxUsers_SchoolEN.UserId, objQxUsers_SchoolEN.UpdUser);
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
 /// <param name = "objQxUsers_SchoolEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsQxUsers_SchoolEN objQxUsers_SchoolEN)
{
 if (string.IsNullOrEmpty(objQxUsers_SchoolEN.UserId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQxUsers_SchoolBL.IsExist(objQxUsers_SchoolEN.UserId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQxUsers_SchoolEN.UserId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = QxUsers_SchoolDA.AddNewRecordBySQL2WithReturnKey(objQxUsers_SchoolEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsers_SchoolBL.ReFreshCache();

if (clsQxUsers_SchoolBL.relatedActions != null)
{
clsQxUsers_SchoolBL.relatedActions.UpdRelaTabDate(objQxUsers_SchoolEN.UserId, objQxUsers_SchoolEN.UpdUser);
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
 /// <param name = "strQxUsers_SchoolObjXml">代表实体对象的XML串</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql_XML(string strQxUsers_SchoolObjXml)
{
clsQxUsers_SchoolEN objQxUsers_SchoolEN = GetObjFromXmlStr(strQxUsers_SchoolObjXml);
try
{
bool bolResult = QxUsers_SchoolDA.AddNewRecordBySQL2(objQxUsers_SchoolEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsers_SchoolBL.ReFreshCache();

if (clsQxUsers_SchoolBL.relatedActions != null)
{
clsQxUsers_SchoolBL.relatedActions.UpdRelaTabDate(objQxUsers_SchoolEN.UserId, objQxUsers_SchoolEN.UpdUser);
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
 /// <param name = "objQxUsers_SchoolEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsQxUsers_SchoolEN objQxUsers_SchoolEN)
{
try
{
bool bolResult = QxUsers_SchoolDA.Update(objQxUsers_SchoolEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsers_SchoolBL.ReFreshCache();

if (clsQxUsers_SchoolBL.relatedActions != null)
{
clsQxUsers_SchoolBL.relatedActions.UpdRelaTabDate(objQxUsers_SchoolEN.UserId, objQxUsers_SchoolEN.UpdUser);
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
 /// <param name = "objQxUsers_SchoolEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsQxUsers_SchoolEN objQxUsers_SchoolEN)
{
 if (string.IsNullOrEmpty(objQxUsers_SchoolEN.UserId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = QxUsers_SchoolDA.UpdateBySql2(objQxUsers_SchoolEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsers_SchoolBL.ReFreshCache();

if (clsQxUsers_SchoolBL.relatedActions != null)
{
clsQxUsers_SchoolBL.relatedActions.UpdRelaTabDate(objQxUsers_SchoolEN.UserId, objQxUsers_SchoolEN.UpdUser);
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
 /// <param name = "strQxUsers_SchoolObjXml">需要修改的对象,用XML来表示</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql_XML(string strQxUsers_SchoolObjXml)
{
clsQxUsers_SchoolEN objQxUsers_SchoolEN = GetObjFromXmlStr(strQxUsers_SchoolObjXml);
try
{
bool bolResult = QxUsers_SchoolDA.UpdateBySql2(objQxUsers_SchoolEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUsers_SchoolBL.ReFreshCache();

if (clsQxUsers_SchoolBL.relatedActions != null)
{
clsQxUsers_SchoolBL.relatedActions.UpdRelaTabDate(objQxUsers_SchoolEN.UserId, objQxUsers_SchoolEN.UpdUser);
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
 /// <param name = "strUserId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strUserId)
{
try
{
 clsQxUsers_SchoolEN objQxUsers_SchoolEN = clsQxUsers_SchoolBL.GetObjByUserId(strUserId);

if (clsQxUsers_SchoolBL.relatedActions != null)
{
clsQxUsers_SchoolBL.relatedActions.UpdRelaTabDate(objQxUsers_SchoolEN.UserId, objQxUsers_SchoolEN.UpdUser);
}
if (objQxUsers_SchoolEN != null)
{
int intRecNum = QxUsers_SchoolDA.DelRecord(strUserId);
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
/// <param name="strUserId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strUserId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxUsers_SchoolDA.GetSpecSQLObj();
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
//删除与表:[QxUsers_School]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conQxUsers_School.UserId,
//strUserId);
//        clsQxUsers_SchoolBL.DelQxUsers_SchoolsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxUsers_SchoolBL.DelRecord(strUserId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxUsers_SchoolBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strUserId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strUserId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strUserId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsQxUsers_SchoolBL.relatedActions != null)
{
clsQxUsers_SchoolBL.relatedActions.UpdRelaTabDate(strUserId, "UpdRelaTabDate");
}
bool bolResult = QxUsers_SchoolDA.DelRecord(strUserId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "strUserId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strUserId) 
{
try
{
if (clsQxUsers_SchoolBL.relatedActions != null)
{
clsQxUsers_SchoolBL.relatedActions.UpdRelaTabDate(strUserId, "UpdRelaTabDate");
}
bool bolResult = QxUsers_SchoolDA.DelRecordBySP(strUserId);
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
 /// <param name = "arrUserIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelQxUsers_Schools(List<string> arrUserIdLst)
{
if (arrUserIdLst.Count == 0) return 0;
try
{
if (clsQxUsers_SchoolBL.relatedActions != null)
{
foreach (var strUserId in arrUserIdLst)
{
clsQxUsers_SchoolBL.relatedActions.UpdRelaTabDate(strUserId, "UpdRelaTabDate");
}
}
int intDelRecNum = QxUsers_SchoolDA.DelQxUsers_School(arrUserIdLst);
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
public static int DelQxUsers_SchoolsByCond(string strWhereCond)
{
try
{
if (clsQxUsers_SchoolBL.relatedActions != null)
{
List<string> arrUserId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strUserId in arrUserId)
{
clsQxUsers_SchoolBL.relatedActions.UpdRelaTabDate(strUserId, "UpdRelaTabDate");
}
}
int intRecNum = QxUsers_SchoolDA.DelQxUsers_School(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[QxUsers_School]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strUserId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strUserId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxUsers_SchoolDA.GetSpecSQLObj();
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
//删除与表:[QxUsers_School]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxUsers_SchoolBL.DelRecord(strUserId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxUsers_SchoolBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strUserId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objQxUsers_SchoolENS">源对象</param>
 /// <param name = "objQxUsers_SchoolENT">目标对象</param>
 public static void CopyTo(clsQxUsers_SchoolEN objQxUsers_SchoolENS, clsQxUsers_SchoolEN objQxUsers_SchoolENT)
{
try
{
objQxUsers_SchoolENT.UserId = objQxUsers_SchoolENS.UserId; //用户ID
objQxUsers_SchoolENT.IdentityId = objQxUsers_SchoolENS.IdentityId; //身份编号
objQxUsers_SchoolENT.CardNo = objQxUsers_SchoolENS.CardNo; //卡号
objQxUsers_SchoolENT.StuTeacherId = objQxUsers_SchoolENS.StuTeacherId; //学工号
objQxUsers_SchoolENT.IdGradeBase = objQxUsers_SchoolENS.IdGradeBase; //年级流水号
objQxUsers_SchoolENT.CardState = objQxUsers_SchoolENS.CardState; //卡状态
objQxUsers_SchoolENT.IsLeaved = objQxUsers_SchoolENS.IsLeaved; //IsLeaved
objQxUsers_SchoolENT.UpdDate = objQxUsers_SchoolENS.UpdDate; //修改日期
objQxUsers_SchoolENT.UpdUser = objQxUsers_SchoolENS.UpdUser; //修改用户
objQxUsers_SchoolENT.Memo = objQxUsers_SchoolENS.Memo; //备注
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
 /// <param name = "objQxUsers_SchoolEN">源简化对象</param>
 public static void SetUpdFlag(clsQxUsers_SchoolEN objQxUsers_SchoolEN)
{
try
{
objQxUsers_SchoolEN.ClearUpdateState();
   string strsfUpdFldSetStr = objQxUsers_SchoolEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conQxUsers_School.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsers_SchoolEN.UserId = objQxUsers_SchoolEN.UserId; //用户ID
}
if (arrFldSet.Contains(conQxUsers_School.IdentityId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsers_SchoolEN.IdentityId = objQxUsers_SchoolEN.IdentityId; //身份编号
}
if (arrFldSet.Contains(conQxUsers_School.CardNo, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsers_SchoolEN.CardNo = objQxUsers_SchoolEN.CardNo == "[null]" ? null :  objQxUsers_SchoolEN.CardNo; //卡号
}
if (arrFldSet.Contains(conQxUsers_School.StuTeacherId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsers_SchoolEN.StuTeacherId = objQxUsers_SchoolEN.StuTeacherId == "[null]" ? null :  objQxUsers_SchoolEN.StuTeacherId; //学工号
}
if (arrFldSet.Contains(conQxUsers_School.IdGradeBase, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsers_SchoolEN.IdGradeBase = objQxUsers_SchoolEN.IdGradeBase == "[null]" ? null :  objQxUsers_SchoolEN.IdGradeBase; //年级流水号
}
if (arrFldSet.Contains(conQxUsers_School.CardState, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsers_SchoolEN.CardState = objQxUsers_SchoolEN.CardState == "[null]" ? null :  objQxUsers_SchoolEN.CardState; //卡状态
}
if (arrFldSet.Contains(conQxUsers_School.IsLeaved, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsers_SchoolEN.IsLeaved = objQxUsers_SchoolEN.IsLeaved; //IsLeaved
}
if (arrFldSet.Contains(conQxUsers_School.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsers_SchoolEN.UpdDate = objQxUsers_SchoolEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conQxUsers_School.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsers_SchoolEN.UpdUser = objQxUsers_SchoolEN.UpdUser == "[null]" ? null :  objQxUsers_SchoolEN.UpdUser; //修改用户
}
if (arrFldSet.Contains(conQxUsers_School.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUsers_SchoolEN.Memo = objQxUsers_SchoolEN.Memo == "[null]" ? null :  objQxUsers_SchoolEN.Memo; //备注
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
 /// <param name = "objQxUsers_SchoolEN">源简化对象</param>
 public static void AccessFldValueNull(clsQxUsers_SchoolEN objQxUsers_SchoolEN)
{
try
{
if (objQxUsers_SchoolEN.CardNo == "[null]") objQxUsers_SchoolEN.CardNo = null; //卡号
if (objQxUsers_SchoolEN.StuTeacherId == "[null]") objQxUsers_SchoolEN.StuTeacherId = null; //学工号
if (objQxUsers_SchoolEN.IdGradeBase == "[null]") objQxUsers_SchoolEN.IdGradeBase = null; //年级流水号
if (objQxUsers_SchoolEN.CardState == "[null]") objQxUsers_SchoolEN.CardState = null; //卡状态
if (objQxUsers_SchoolEN.UpdUser == "[null]") objQxUsers_SchoolEN.UpdUser = null; //修改用户
if (objQxUsers_SchoolEN.Memo == "[null]") objQxUsers_SchoolEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsQxUsers_SchoolEN objQxUsers_SchoolEN)
{
 QxUsers_SchoolDA.CheckPropertyNew(objQxUsers_SchoolEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsQxUsers_SchoolEN objQxUsers_SchoolEN)
{
 QxUsers_SchoolDA.CheckProperty4Condition(objQxUsers_SchoolEN);
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
if (clsQxUsers_SchoolBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxUsers_SchoolBL没有刷新缓存机制(clsQxUsers_SchoolBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by UserId");
//if (arrQxUsers_SchoolObjLstCache == null)
//{
//arrQxUsers_SchoolObjLstCache = QxUsers_SchoolDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strUserId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxUsers_SchoolEN GetObjByUserIdCache(string strUserId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsQxUsers_SchoolEN._CurrTabName);
List<clsQxUsers_SchoolEN> arrQxUsers_SchoolObjLstCache = GetObjLstCache();
IEnumerable <clsQxUsers_SchoolEN> arrQxUsers_SchoolObjLst_Sel =
arrQxUsers_SchoolObjLstCache
.Where(x=> x.UserId == strUserId 
);
if (arrQxUsers_SchoolObjLst_Sel.Count() == 0)
{
   clsQxUsers_SchoolEN obj = clsQxUsers_SchoolBL.GetObjByUserId(strUserId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrQxUsers_SchoolObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxUsers_SchoolEN> GetAllQxUsers_SchoolObjLstCache()
{
//获取缓存中的对象列表
List<clsQxUsers_SchoolEN> arrQxUsers_SchoolObjLstCache = GetObjLstCache(); 
return arrQxUsers_SchoolObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxUsers_SchoolEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsQxUsers_SchoolEN._CurrTabName);
List<clsQxUsers_SchoolEN> arrQxUsers_SchoolObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrQxUsers_SchoolObjLstCache;
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
string strKey = string.Format("{0}", clsQxUsers_SchoolEN._CurrTabName);
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
if (clsQxUsers_SchoolBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsQxUsers_SchoolEN._CurrTabName);
CacheHelper.Remove(strKey);
clsQxUsers_SchoolBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-12-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstQxUsers_SchoolObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsQxUsers_SchoolEN> lstQxUsers_SchoolObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstQxUsers_SchoolObjLst, writer);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 序列化一个对象列表到XmlWriter
 /// 作者:pyf
 /// 日期:2023-12-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXML)
 /// </summary>
 /// <param name = "lstQxUsers_SchoolObjLst">[clsQxUsers_SchoolEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsQxUsers_SchoolEN> lstQxUsers_SchoolObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsQxUsers_SchoolBL.listXmlNode);
writer.WriteStartElement(clsQxUsers_SchoolBL.itemsXmlNode);
foreach (clsQxUsers_SchoolEN objQxUsers_SchoolEN in lstQxUsers_SchoolObjLst)
{
clsQxUsers_SchoolBL.SerializeXML(writer, objQxUsers_SchoolEN);
}
writer.WriteEndElement();
writer.WriteEndElement();
return true;
}

 /// <summary>
 /// 把一个对象序列化到XML中
 /// 作者:pyf
 /// 日期:2023-12-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeXML)
 /// </summary>
 /// <param name = "writer">目标:序列化到的XmlWriter</param>
 /// <param name = "objQxUsers_SchoolEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsQxUsers_SchoolEN objQxUsers_SchoolEN)
{
writer.WriteStartElement(clsQxUsers_SchoolBL.itemXmlNode);
 
if (objQxUsers_SchoolEN.UserId != null)
{
writer.WriteElementString(conQxUsers_School.UserId, objQxUsers_SchoolEN.UserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUsers_SchoolEN.IdentityId != null)
{
writer.WriteElementString(conQxUsers_School.IdentityId, objQxUsers_SchoolEN.IdentityId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUsers_SchoolEN.CardNo != null)
{
writer.WriteElementString(conQxUsers_School.CardNo, objQxUsers_SchoolEN.CardNo.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUsers_SchoolEN.StuTeacherId != null)
{
writer.WriteElementString(conQxUsers_School.StuTeacherId, objQxUsers_SchoolEN.StuTeacherId.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUsers_SchoolEN.IdGradeBase != null)
{
writer.WriteElementString(conQxUsers_School.IdGradeBase, objQxUsers_SchoolEN.IdGradeBase.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUsers_SchoolEN.CardState != null)
{
writer.WriteElementString(conQxUsers_School.CardState, objQxUsers_SchoolEN.CardState.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(conQxUsers_School.IsLeaved, objQxUsers_SchoolEN.IsLeaved.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objQxUsers_SchoolEN.UpdDate != null)
{
writer.WriteElementString(conQxUsers_School.UpdDate, objQxUsers_SchoolEN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUsers_SchoolEN.UpdUser != null)
{
writer.WriteElementString(conQxUsers_School.UpdUser, objQxUsers_SchoolEN.UpdUser.ToString(CultureInfo.InvariantCulture));
}
 
if (objQxUsers_SchoolEN.Memo != null)
{
writer.WriteElementString(conQxUsers_School.Memo, objQxUsers_SchoolEN.Memo.ToString(CultureInfo.InvariantCulture));
}
writer.WriteEndElement();
}

 /// <summary>
 /// 读XmlReader到一个对象
 /// 作者:pyf
 /// 日期:2023-12-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlReader)
 /// </summary>
 /// <param name = "reader">提供的数据源:XmlReader</param>
 /// <returns>返回的一个对象</returns>
public static clsQxUsers_SchoolEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsQxUsers_SchoolEN objQxUsers_SchoolEN = new clsQxUsers_SchoolEN();
reader.Read();
while (!(reader.Name == clsQxUsers_SchoolBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(conQxUsers_School.UserId))
{
objQxUsers_SchoolEN.UserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsers_School.IdentityId))
{
objQxUsers_SchoolEN.IdentityId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsers_School.CardNo))
{
objQxUsers_SchoolEN.CardNo = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsers_School.StuTeacherId))
{
objQxUsers_SchoolEN.StuTeacherId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsers_School.IdGradeBase))
{
objQxUsers_SchoolEN.IdGradeBase = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsers_School.CardState))
{
objQxUsers_SchoolEN.CardState = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsers_School.IsLeaved))
{
objQxUsers_SchoolEN.IsLeaved = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(conQxUsers_School.UpdDate))
{
objQxUsers_SchoolEN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsers_School.UpdUser))
{
objQxUsers_SchoolEN.UpdUser = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conQxUsers_School.Memo))
{
objQxUsers_SchoolEN.Memo = reader.ReadElementContentAsString();
}
}
return objQxUsers_SchoolEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strQxUsers_SchoolObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsQxUsers_SchoolEN GetObjFromXmlStr(string strQxUsers_SchoolObjXmlStr)
{
clsQxUsers_SchoolEN objQxUsers_SchoolEN = new clsQxUsers_SchoolEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strQxUsers_SchoolObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsQxUsers_SchoolBL.itemXmlNode))
{
objQxUsers_SchoolEN = GetObjFromXml(reader);
return objQxUsers_SchoolEN;
}
}
return objQxUsers_SchoolEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-12-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objQxUsers_SchoolEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsQxUsers_SchoolEN objQxUsers_SchoolEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objQxUsers_SchoolEN);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-12-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strUserId)
{
if (strInFldName != conQxUsers_School.UserId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conQxUsers_School.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conQxUsers_School.AttributeName));
throw new Exception(strMsg);
}
var objQxUsers_School = clsQxUsers_SchoolBL.GetObjByUserIdCache(strUserId);
if (objQxUsers_School == null) return "";
return objQxUsers_School[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-12-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objQxUsers_SchoolEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsQxUsers_SchoolEN objQxUsers_SchoolEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsQxUsers_SchoolEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objQxUsers_SchoolEN[strField]);
}
sbJSON.Remove(sbJSON.Length - 1, 1);
sbJSON.Append("}");
return sbJSON.ToString();
}

 /// <summary>
 /// 序列化一个对象列表到JSON串
 /// 作者:pyf
 /// 日期:2023-12-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToJSONStr)
 /// </summary>
 /// <param name = "lstQxUsers_SchoolObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsQxUsers_SchoolEN> lstQxUsers_SchoolObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstQxUsers_SchoolObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsQxUsers_SchoolEN objQxUsers_SchoolEN in lstQxUsers_SchoolObjLst)
{
string strJSON_One = SerializeObjToJSON(objQxUsers_SchoolEN);
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
int intRecCount = clsQxUsers_SchoolDA.GetRecCount(strTabName);
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
int intRecCount = clsQxUsers_SchoolDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsQxUsers_SchoolDA.GetRecCount();
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
int intRecCount = clsQxUsers_SchoolDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objQxUsers_SchoolCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsQxUsers_SchoolEN objQxUsers_SchoolCond)
{
List<clsQxUsers_SchoolEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxUsers_SchoolEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxUsers_School.AttributeName)
{
if (objQxUsers_SchoolCond.IsUpdated(strFldName) == false) continue;
if (objQxUsers_SchoolCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUsers_SchoolCond[strFldName].ToString());
}
else
{
if (objQxUsers_SchoolCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxUsers_SchoolCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUsers_SchoolCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxUsers_SchoolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxUsers_SchoolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxUsers_SchoolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxUsers_SchoolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxUsers_SchoolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxUsers_SchoolCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxUsers_SchoolCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxUsers_SchoolCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxUsers_SchoolCond[strFldName]));
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
 List<string> arrList = clsQxUsers_SchoolDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = QxUsers_SchoolDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = QxUsers_SchoolDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = QxUsers_SchoolDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxUsers_SchoolDA.SetFldValue(clsQxUsers_SchoolEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = QxUsers_SchoolDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxUsers_SchoolDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxUsers_SchoolDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxUsers_SchoolDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[QxUsers_School] "); 
 strCreateTabCode.Append(" ( "); 
 // /**用户ID*/ 
 strCreateTabCode.Append(" UserId varchar(18) primary key, "); 
 // /**身份编号*/ 
 strCreateTabCode.Append(" IdentityId char(2) not Null, "); 
 // /**卡号*/ 
 strCreateTabCode.Append(" CardNo varchar(10) Null, "); 
 // /**学工号*/ 
 strCreateTabCode.Append(" StuTeacherId varchar(20) Null, "); 
 // /**年级流水号*/ 
 strCreateTabCode.Append(" IdGradeBase char(4) Null, "); 
 // /**卡状态*/ 
 strCreateTabCode.Append(" CardState varchar(10) Null, "); 
 // /**IsLeaved*/ 
 strCreateTabCode.Append(" IsLeaved bit Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) not Null, "); 
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
 /// 用户_学校(QxUsers_School)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4QxUsers_School : clsCommFun4BL
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
clsQxUsers_SchoolBL.ReFreshThisCache();
}
}

}