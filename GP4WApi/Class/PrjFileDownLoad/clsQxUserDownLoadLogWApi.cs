
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUserDownLoadLogWApi
 表名:QxUserDownLoadLog(00140058)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 18:24:37
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:工程文件下载(PrjFileDownLoad)
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
public static class  clsQxUserDownLoadLogWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserDownLoadLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserDownLoadLogId">用户下载日志Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserDownLoadLogEN SetUserDownLoadLogId(this clsQxUserDownLoadLogEN objQxUserDownLoadLogEN, string strUserDownLoadLogId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserDownLoadLogId, 8, conQxUserDownLoadLog.UserDownLoadLogId);
clsCheckSql.CheckFieldForeignKey(strUserDownLoadLogId, 8, conQxUserDownLoadLog.UserDownLoadLogId);
objQxUserDownLoadLogEN.UserDownLoadLogId = strUserDownLoadLogId; //用户下载日志Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserDownLoadLogEN.dicFldComparisonOp.ContainsKey(conQxUserDownLoadLog.UserDownLoadLogId) == false)
{
objQxUserDownLoadLogEN.dicFldComparisonOp.Add(conQxUserDownLoadLog.UserDownLoadLogId, strComparisonOp);
}
else
{
objQxUserDownLoadLogEN.dicFldComparisonOp[conQxUserDownLoadLog.UserDownLoadLogId] = strComparisonOp;
}
}
return objQxUserDownLoadLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserDownLoadLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserDownLoadLogEN SetUserId(this clsQxUserDownLoadLogEN objQxUserDownLoadLogEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, conQxUserDownLoadLog.UserId);
clsCheckSql.CheckFieldLen(strUserId, 18, conQxUserDownLoadLog.UserId);
objQxUserDownLoadLogEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserDownLoadLogEN.dicFldComparisonOp.ContainsKey(conQxUserDownLoadLog.UserId) == false)
{
objQxUserDownLoadLogEN.dicFldComparisonOp.Add(conQxUserDownLoadLog.UserId, strComparisonOp);
}
else
{
objQxUserDownLoadLogEN.dicFldComparisonOp[conQxUserDownLoadLog.UserId] = strComparisonOp;
}
}
return objQxUserDownLoadLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserDownLoadLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjSiteId">工程站点Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserDownLoadLogEN SetPrjSiteId(this clsQxUserDownLoadLogEN objQxUserDownLoadLogEN, string strPrjSiteId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjSiteId, conQxUserDownLoadLog.PrjSiteId);
clsCheckSql.CheckFieldLen(strPrjSiteId, 6, conQxUserDownLoadLog.PrjSiteId);
clsCheckSql.CheckFieldForeignKey(strPrjSiteId, 6, conQxUserDownLoadLog.PrjSiteId);
objQxUserDownLoadLogEN.PrjSiteId = strPrjSiteId; //工程站点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserDownLoadLogEN.dicFldComparisonOp.ContainsKey(conQxUserDownLoadLog.PrjSiteId) == false)
{
objQxUserDownLoadLogEN.dicFldComparisonOp.Add(conQxUserDownLoadLog.PrjSiteId, strComparisonOp);
}
else
{
objQxUserDownLoadLogEN.dicFldComparisonOp[conQxUserDownLoadLog.PrjSiteId] = strComparisonOp;
}
}
return objQxUserDownLoadLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserDownLoadLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strDownLownDate">下载日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserDownLoadLogEN SetDownLownDate(this clsQxUserDownLoadLogEN objQxUserDownLoadLogEN, string strDownLownDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDownLownDate, conQxUserDownLoadLog.DownLownDate);
clsCheckSql.CheckFieldLen(strDownLownDate, 20, conQxUserDownLoadLog.DownLownDate);
objQxUserDownLoadLogEN.DownLownDate = strDownLownDate; //下载日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserDownLoadLogEN.dicFldComparisonOp.ContainsKey(conQxUserDownLoadLog.DownLownDate) == false)
{
objQxUserDownLoadLogEN.dicFldComparisonOp.Add(conQxUserDownLoadLog.DownLownDate, strComparisonOp);
}
else
{
objQxUserDownLoadLogEN.dicFldComparisonOp[conQxUserDownLoadLog.DownLownDate] = strComparisonOp;
}
}
return objQxUserDownLoadLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserDownLoadLogEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsSuccess">是否成功</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserDownLoadLogEN SetIsSuccess(this clsQxUserDownLoadLogEN objQxUserDownLoadLogEN, bool bolIsSuccess, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsSuccess, conQxUserDownLoadLog.IsSuccess);
objQxUserDownLoadLogEN.IsSuccess = bolIsSuccess; //是否成功
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserDownLoadLogEN.dicFldComparisonOp.ContainsKey(conQxUserDownLoadLog.IsSuccess) == false)
{
objQxUserDownLoadLogEN.dicFldComparisonOp.Add(conQxUserDownLoadLog.IsSuccess, strComparisonOp);
}
else
{
objQxUserDownLoadLogEN.dicFldComparisonOp[conQxUserDownLoadLog.IsSuccess] = strComparisonOp;
}
}
return objQxUserDownLoadLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserDownLoadLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strLogInfo">日志信息</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserDownLoadLogEN SetLogInfo(this clsQxUserDownLoadLogEN objQxUserDownLoadLogEN, string strLogInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strLogInfo, conQxUserDownLoadLog.LogInfo);
clsCheckSql.CheckFieldLen(strLogInfo, 500, conQxUserDownLoadLog.LogInfo);
objQxUserDownLoadLogEN.LogInfo = strLogInfo; //日志信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserDownLoadLogEN.dicFldComparisonOp.ContainsKey(conQxUserDownLoadLog.LogInfo) == false)
{
objQxUserDownLoadLogEN.dicFldComparisonOp.Add(conQxUserDownLoadLog.LogInfo, strComparisonOp);
}
else
{
objQxUserDownLoadLogEN.dicFldComparisonOp[conQxUserDownLoadLog.LogInfo] = strComparisonOp;
}
}
return objQxUserDownLoadLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserDownLoadLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">备注</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserDownLoadLogEN SetMemo(this clsQxUserDownLoadLogEN objQxUserDownLoadLogEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQxUserDownLoadLog.Memo);
objQxUserDownLoadLogEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserDownLoadLogEN.dicFldComparisonOp.ContainsKey(conQxUserDownLoadLog.Memo) == false)
{
objQxUserDownLoadLogEN.dicFldComparisonOp.Add(conQxUserDownLoadLog.Memo, strComparisonOp);
}
else
{
objQxUserDownLoadLogEN.dicFldComparisonOp[conQxUserDownLoadLog.Memo] = strComparisonOp;
}
}
return objQxUserDownLoadLogEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQxUserDownLoadLogEN objQxUserDownLoadLogCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQxUserDownLoadLogCond.IsUpdated(conQxUserDownLoadLog.UserDownLoadLogId) == true)
{
string strComparisonOpUserDownLoadLogId = objQxUserDownLoadLogCond.dicFldComparisonOp[conQxUserDownLoadLog.UserDownLoadLogId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserDownLoadLog.UserDownLoadLogId, objQxUserDownLoadLogCond.UserDownLoadLogId, strComparisonOpUserDownLoadLogId);
}
if (objQxUserDownLoadLogCond.IsUpdated(conQxUserDownLoadLog.UserId) == true)
{
string strComparisonOpUserId = objQxUserDownLoadLogCond.dicFldComparisonOp[conQxUserDownLoadLog.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserDownLoadLog.UserId, objQxUserDownLoadLogCond.UserId, strComparisonOpUserId);
}
if (objQxUserDownLoadLogCond.IsUpdated(conQxUserDownLoadLog.PrjSiteId) == true)
{
string strComparisonOpPrjSiteId = objQxUserDownLoadLogCond.dicFldComparisonOp[conQxUserDownLoadLog.PrjSiteId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserDownLoadLog.PrjSiteId, objQxUserDownLoadLogCond.PrjSiteId, strComparisonOpPrjSiteId);
}
if (objQxUserDownLoadLogCond.IsUpdated(conQxUserDownLoadLog.DownLownDate) == true)
{
string strComparisonOpDownLownDate = objQxUserDownLoadLogCond.dicFldComparisonOp[conQxUserDownLoadLog.DownLownDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserDownLoadLog.DownLownDate, objQxUserDownLoadLogCond.DownLownDate, strComparisonOpDownLownDate);
}
if (objQxUserDownLoadLogCond.IsUpdated(conQxUserDownLoadLog.IsSuccess) == true)
{
if (objQxUserDownLoadLogCond.IsSuccess == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQxUserDownLoadLog.IsSuccess);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQxUserDownLoadLog.IsSuccess);
}
}
if (objQxUserDownLoadLogCond.IsUpdated(conQxUserDownLoadLog.LogInfo) == true)
{
string strComparisonOpLogInfo = objQxUserDownLoadLogCond.dicFldComparisonOp[conQxUserDownLoadLog.LogInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserDownLoadLog.LogInfo, objQxUserDownLoadLogCond.LogInfo, strComparisonOpLogInfo);
}
if (objQxUserDownLoadLogCond.IsUpdated(conQxUserDownLoadLog.Memo) == true)
{
string strComparisonOpMemo = objQxUserDownLoadLogCond.dicFldComparisonOp[conQxUserDownLoadLog.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserDownLoadLog.Memo, objQxUserDownLoadLogCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objQxUserDownLoadLogEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxUserDownLoadLogEN objQxUserDownLoadLogEN)
{
 if (string.IsNullOrEmpty(objQxUserDownLoadLogEN.UserDownLoadLogId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objQxUserDownLoadLogEN.sfUpdFldSetStr = objQxUserDownLoadLogEN.getsfUpdFldSetStr();
clsQxUserDownLoadLogWApi.CheckPropertyNew(objQxUserDownLoadLogEN); 
bool bolResult = clsQxUserDownLoadLogWApi.UpdateRecord(objQxUserDownLoadLogEN);
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
 /// 获取唯一性条件串--QxUserDownLoadLog(用户下载日志), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:UserId_PrjSiteId_DownLownDate
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objQxUserDownLoadLogEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsQxUserDownLoadLogEN objQxUserDownLoadLogEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objQxUserDownLoadLogEN == null) return "";
if (objQxUserDownLoadLogEN.UserDownLoadLogId == null || objQxUserDownLoadLogEN.UserDownLoadLogId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and UserId = '{0}'", objQxUserDownLoadLogEN.UserId);
 sbCondition.AppendFormat(" and PrjSiteId = '{0}'", objQxUserDownLoadLogEN.PrjSiteId);
 sbCondition.AppendFormat(" and DownLownDate = '{0}'", objQxUserDownLoadLogEN.DownLownDate);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("UserDownLoadLogId !=  '{0}'", objQxUserDownLoadLogEN.UserDownLoadLogId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objQxUserDownLoadLogEN.UserId);
 sbCondition.AppendFormat(" and PrjSiteId = '{0}'", objQxUserDownLoadLogEN.PrjSiteId);
 sbCondition.AppendFormat(" and DownLownDate = '{0}'", objQxUserDownLoadLogEN.DownLownDate);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQxUserDownLoadLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQxUserDownLoadLogEN objQxUserDownLoadLogEN)
{
try
{
 if (string.IsNullOrEmpty(objQxUserDownLoadLogEN.UserDownLoadLogId) == true || clsQxUserDownLoadLogWApi.IsExist(objQxUserDownLoadLogEN.UserDownLoadLogId) == true)
 {
     objQxUserDownLoadLogEN.UserDownLoadLogId = clsQxUserDownLoadLogWApi.GetMaxStrId();
 }
clsQxUserDownLoadLogWApi.CheckPropertyNew(objQxUserDownLoadLogEN); 
bool bolResult = clsQxUserDownLoadLogWApi.AddNewRecord(objQxUserDownLoadLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserDownLoadLogWApi.ReFreshCache();
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
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值. 该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objQxUserDownLoadLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsQxUserDownLoadLogEN objQxUserDownLoadLogEN)
{
try
{
clsQxUserDownLoadLogWApi.CheckPropertyNew(objQxUserDownLoadLogEN); 
string strUserDownLoadLogId = clsQxUserDownLoadLogWApi.AddNewRecordWithMaxId(objQxUserDownLoadLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserDownLoadLogWApi.ReFreshCache();
return strUserDownLoadLogId;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000009)添加记录出错, {1}.(from {0})",
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
 /// <param name = "objQxUserDownLoadLogEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxUserDownLoadLogEN objQxUserDownLoadLogEN, string strWhereCond)
{
try
{
clsQxUserDownLoadLogWApi.CheckPropertyNew(objQxUserDownLoadLogEN); 
bool bolResult = clsQxUserDownLoadLogWApi.UpdateWithCondition(objQxUserDownLoadLogEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserDownLoadLogWApi.ReFreshCache();
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
 /// 用户下载日志(QxUserDownLoadLog)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsQxUserDownLoadLogWApi
{
private static readonly string mstrApiControllerName = "QxUserDownLoadLogApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsQxUserDownLoadLogWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsQxUserDownLoadLogEN objQxUserDownLoadLogEN)
{
if (!Object.Equals(null, objQxUserDownLoadLogEN.UserDownLoadLogId) && GetStrLen(objQxUserDownLoadLogEN.UserDownLoadLogId) > 8)
{
 throw new Exception("字段[用户下载日志Id]的长度不能超过8!");
}
if (!Object.Equals(null, objQxUserDownLoadLogEN.UserId) && GetStrLen(objQxUserDownLoadLogEN.UserId) > 18)
{
 throw new Exception("字段[用户ID]的长度不能超过18!");
}
if (!Object.Equals(null, objQxUserDownLoadLogEN.PrjSiteId) && GetStrLen(objQxUserDownLoadLogEN.PrjSiteId) > 6)
{
 throw new Exception("字段[工程站点Id]的长度不能超过6!");
}
if (!Object.Equals(null, objQxUserDownLoadLogEN.DownLownDate) && GetStrLen(objQxUserDownLoadLogEN.DownLownDate) > 20)
{
 throw new Exception("字段[下载日期]的长度不能超过20!");
}
if (!Object.Equals(null, objQxUserDownLoadLogEN.LogInfo) && GetStrLen(objQxUserDownLoadLogEN.LogInfo) > 500)
{
 throw new Exception("字段[日志信息]的长度不能超过500!");
}
if (!Object.Equals(null, objQxUserDownLoadLogEN.Memo) && GetStrLen(objQxUserDownLoadLogEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objQxUserDownLoadLogEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strUserDownLoadLogId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxUserDownLoadLogEN GetObjByUserDownLoadLogId(string strUserDownLoadLogId)
{
string strAction = "GetObjByUserDownLoadLogId";
clsQxUserDownLoadLogEN objQxUserDownLoadLogEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strUserDownLoadLogId"] = strUserDownLoadLogId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objQxUserDownLoadLogEN = JsonConvert.DeserializeObject<clsQxUserDownLoadLogEN>(strJson);
return objQxUserDownLoadLogEN;
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
public static string GetFirstID(string strWhereCond)
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
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsQxUserDownLoadLogEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsQxUserDownLoadLogEN objQxUserDownLoadLogEN;
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
objQxUserDownLoadLogEN = JsonConvert.DeserializeObject<clsQxUserDownLoadLogEN>(strJson);
return objQxUserDownLoadLogEN;
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
public static List<clsQxUserDownLoadLogEN> GetObjLst(string strWhereCond)
{
 List<clsQxUserDownLoadLogEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxUserDownLoadLogEN>>(strJson);
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
 /// <param name = "arrUserDownLoadLogId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUserDownLoadLogEN> GetObjLstByUserDownLoadLogIdLst(List<string> arrUserDownLoadLogId)
{
 List<clsQxUserDownLoadLogEN> arrObjLst; 
string strAction = "GetObjLstByUserDownLoadLogIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrUserDownLoadLogId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsQxUserDownLoadLogEN>>(strJson);
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
public static List<clsQxUserDownLoadLogEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsQxUserDownLoadLogEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxUserDownLoadLogEN>>(strJson);
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
public static List<clsQxUserDownLoadLogEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsQxUserDownLoadLogEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxUserDownLoadLogEN>>(strJson);
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
public static List<clsQxUserDownLoadLogEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsQxUserDownLoadLogEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxUserDownLoadLogEN>>(strJson);
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
public static List<clsQxUserDownLoadLogEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsQxUserDownLoadLogEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxUserDownLoadLogEN>>(strJson);
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
public static int DelRecord(string strUserDownLoadLogId)
{
string strAction = "DelRecord";
try
{
 clsQxUserDownLoadLogEN objQxUserDownLoadLogEN = clsQxUserDownLoadLogWApi.GetObjByUserDownLoadLogId(strUserDownLoadLogId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strUserDownLoadLogId.ToString(), out string strResult, out string strErrMsg) == true)
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
public static int DelQxUserDownLoadLogs(List<string> arrUserDownLoadLogId)
{
string strAction = "DelQxUserDownLoadLogs";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrUserDownLoadLogId);
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
public static int DelQxUserDownLoadLogsByCond(string strWhereCond)
{
string strAction = "DelQxUserDownLoadLogsByCond";
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
public static bool AddNewRecord(clsQxUserDownLoadLogEN objQxUserDownLoadLogEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxUserDownLoadLogEN>(objQxUserDownLoadLogEN);
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
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithMaxId)
 /// </summary>
 /// <returns>新建记录的关键字</returns>
public static string AddNewRecordWithMaxId(clsQxUserDownLoadLogEN objQxUserDownLoadLogEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxUserDownLoadLogEN>(objQxUserDownLoadLogEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
var strUserDownLoadLogId = (string)jobjReturn0["returnStr"];
return strUserDownLoadLogId;
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
public static bool UpdateRecord(clsQxUserDownLoadLogEN objQxUserDownLoadLogEN)
{
if (string.IsNullOrEmpty(objQxUserDownLoadLogEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objQxUserDownLoadLogEN.UserDownLoadLogId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxUserDownLoadLogEN>(objQxUserDownLoadLogEN);
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
 /// <param name = "objQxUserDownLoadLogEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsQxUserDownLoadLogEN objQxUserDownLoadLogEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objQxUserDownLoadLogEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objQxUserDownLoadLogEN.UserDownLoadLogId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objQxUserDownLoadLogEN.UserDownLoadLogId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxUserDownLoadLogEN>(objQxUserDownLoadLogEN);
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
public static bool IsExist(string strUserDownLoadLogId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strUserDownLoadLogId"] = strUserDownLoadLogId
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
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId()
{
string strAction = "GetMaxStrId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
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
string strMsg = string.Format("获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefix(string strPrefix)
{
//检测记录是否存在
string strAction = "GetMaxStrIdByPrefix";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
{"strPrefix", strPrefix}
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
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
string strMsg = string.Format("根据前缀获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objQxUserDownLoadLogENS">源对象</param>
 /// <param name = "objQxUserDownLoadLogENT">目标对象</param>
 public static void CopyTo(clsQxUserDownLoadLogEN objQxUserDownLoadLogENS, clsQxUserDownLoadLogEN objQxUserDownLoadLogENT)
{
try
{
objQxUserDownLoadLogENT.UserDownLoadLogId = objQxUserDownLoadLogENS.UserDownLoadLogId; //用户下载日志Id
objQxUserDownLoadLogENT.UserId = objQxUserDownLoadLogENS.UserId; //用户ID
objQxUserDownLoadLogENT.PrjSiteId = objQxUserDownLoadLogENS.PrjSiteId; //工程站点Id
objQxUserDownLoadLogENT.DownLownDate = objQxUserDownLoadLogENS.DownLownDate; //下载日期
objQxUserDownLoadLogENT.IsSuccess = objQxUserDownLoadLogENS.IsSuccess; //是否成功
objQxUserDownLoadLogENT.LogInfo = objQxUserDownLoadLogENS.LogInfo; //日志信息
objQxUserDownLoadLogENT.Memo = objQxUserDownLoadLogENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsQxUserDownLoadLogEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsQxUserDownLoadLogEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsQxUserDownLoadLogEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsQxUserDownLoadLogEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsQxUserDownLoadLogEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsQxUserDownLoadLogEN.AttributeName)
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
string strKey = string.Format("{0}", clsQxUserDownLoadLogEN._CurrTabName);
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
if (clsQxUserDownLoadLogWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsQxUserDownLoadLogEN._CurrTabName);
CacheHelper.Remove(strKey);
clsQxUserDownLoadLogWApi.objCommFun4WApi.ReFreshCache();
}
}
//该表没有使用Cache,不需要生成[GetObjLstCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsQxUserDownLoadLogEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conQxUserDownLoadLog.UserDownLoadLogId, Type.GetType("System.String"));
objDT.Columns.Add(conQxUserDownLoadLog.UserId, Type.GetType("System.String"));
objDT.Columns.Add(conQxUserDownLoadLog.PrjSiteId, Type.GetType("System.String"));
objDT.Columns.Add(conQxUserDownLoadLog.DownLownDate, Type.GetType("System.String"));
objDT.Columns.Add(conQxUserDownLoadLog.IsSuccess, Type.GetType("System.Boolean"));
objDT.Columns.Add(conQxUserDownLoadLog.LogInfo, Type.GetType("System.String"));
objDT.Columns.Add(conQxUserDownLoadLog.Memo, Type.GetType("System.String"));
foreach (clsQxUserDownLoadLogEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conQxUserDownLoadLog.UserDownLoadLogId] = objInFor[conQxUserDownLoadLog.UserDownLoadLogId];
objDR[conQxUserDownLoadLog.UserId] = objInFor[conQxUserDownLoadLog.UserId];
objDR[conQxUserDownLoadLog.PrjSiteId] = objInFor[conQxUserDownLoadLog.PrjSiteId];
objDR[conQxUserDownLoadLog.DownLownDate] = objInFor[conQxUserDownLoadLog.DownLownDate];
objDR[conQxUserDownLoadLog.IsSuccess] = objInFor[conQxUserDownLoadLog.IsSuccess];
objDR[conQxUserDownLoadLog.LogInfo] = objInFor[conQxUserDownLoadLog.LogInfo];
objDR[conQxUserDownLoadLog.Memo] = objInFor[conQxUserDownLoadLog.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 用户下载日志(QxUserDownLoadLog)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4QxUserDownLoadLog : clsCommFun4BL
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
clsQxUserDownLoadLogWApi.ReFreshThisCache();
}
}

}