
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxPrjDataBaseWApi
 表名:QxPrjDataBase(00140039)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 18:23:45
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:工程管理(PrjManage_GP)
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
public static class  clsQxPrjDataBaseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strQxPrjDataBaseId">项目数据库Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjDataBaseEN SetQxPrjDataBaseId(this clsQxPrjDataBaseEN objQxPrjDataBaseEN, string strQxPrjDataBaseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQxPrjDataBaseId, 4, conQxPrjDataBase.QxPrjDataBaseId);
clsCheckSql.CheckFieldForeignKey(strQxPrjDataBaseId, 4, conQxPrjDataBase.QxPrjDataBaseId);
objQxPrjDataBaseEN.QxPrjDataBaseId = strQxPrjDataBaseId; //项目数据库Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjDataBaseEN.dicFldComparisonOp.ContainsKey(conQxPrjDataBase.QxPrjDataBaseId) == false)
{
objQxPrjDataBaseEN.dicFldComparisonOp.Add(conQxPrjDataBase.QxPrjDataBaseId, strComparisonOp);
}
else
{
objQxPrjDataBaseEN.dicFldComparisonOp[conQxPrjDataBase.QxPrjDataBaseId] = strComparisonOp;
}
}
return objQxPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjDataBaseName">项目数据库名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjDataBaseEN SetPrjDataBaseName(this clsQxPrjDataBaseEN objQxPrjDataBaseEN, string strPrjDataBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjDataBaseName, 50, conQxPrjDataBase.PrjDataBaseName);
objQxPrjDataBaseEN.PrjDataBaseName = strPrjDataBaseName; //项目数据库名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjDataBaseEN.dicFldComparisonOp.ContainsKey(conQxPrjDataBase.PrjDataBaseName) == false)
{
objQxPrjDataBaseEN.dicFldComparisonOp.Add(conQxPrjDataBase.PrjDataBaseName, strComparisonOp);
}
else
{
objQxPrjDataBaseEN.dicFldComparisonOp[conQxPrjDataBase.PrjDataBaseName] = strComparisonOp;
}
}
return objQxPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataBaseName">数据库名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjDataBaseEN SetDataBaseName(this clsQxPrjDataBaseEN objQxPrjDataBaseEN, string strDataBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataBaseName, 30, conQxPrjDataBase.DataBaseName);
objQxPrjDataBaseEN.DataBaseName = strDataBaseName; //数据库名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjDataBaseEN.dicFldComparisonOp.ContainsKey(conQxPrjDataBase.DataBaseName) == false)
{
objQxPrjDataBaseEN.dicFldComparisonOp.Add(conQxPrjDataBase.DataBaseName, strComparisonOp);
}
else
{
objQxPrjDataBaseEN.dicFldComparisonOp[conQxPrjDataBase.DataBaseName] = strComparisonOp;
}
}
return objQxPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strDatabaseOwner">数据库拥有者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjDataBaseEN SetDatabaseOwner(this clsQxPrjDataBaseEN objQxPrjDataBaseEN, string strDatabaseOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDatabaseOwner, 30, conQxPrjDataBase.DatabaseOwner);
objQxPrjDataBaseEN.DatabaseOwner = strDatabaseOwner; //数据库拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjDataBaseEN.dicFldComparisonOp.ContainsKey(conQxPrjDataBase.DatabaseOwner) == false)
{
objQxPrjDataBaseEN.dicFldComparisonOp.Add(conQxPrjDataBase.DatabaseOwner, strComparisonOp);
}
else
{
objQxPrjDataBaseEN.dicFldComparisonOp[conQxPrjDataBase.DatabaseOwner] = strComparisonOp;
}
}
return objQxPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataBasePwd">数据库用户口令</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjDataBaseEN SetDataBasePwd(this clsQxPrjDataBaseEN objQxPrjDataBaseEN, string strDataBasePwd, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataBasePwd, 20, conQxPrjDataBase.DataBasePwd);
objQxPrjDataBaseEN.DataBasePwd = strDataBasePwd; //数据库用户口令
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjDataBaseEN.dicFldComparisonOp.ContainsKey(conQxPrjDataBase.DataBasePwd) == false)
{
objQxPrjDataBaseEN.dicFldComparisonOp.Add(conQxPrjDataBase.DataBasePwd, strComparisonOp);
}
else
{
objQxPrjDataBaseEN.dicFldComparisonOp[conQxPrjDataBase.DataBasePwd] = strComparisonOp;
}
}
return objQxPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataBaseTypeId">数据库类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjDataBaseEN SetDataBaseTypeId(this clsQxPrjDataBaseEN objQxPrjDataBaseEN, string strDataBaseTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataBaseTypeId, 2, conQxPrjDataBase.DataBaseTypeId);
clsCheckSql.CheckFieldForeignKey(strDataBaseTypeId, 2, conQxPrjDataBase.DataBaseTypeId);
objQxPrjDataBaseEN.DataBaseTypeId = strDataBaseTypeId; //数据库类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjDataBaseEN.dicFldComparisonOp.ContainsKey(conQxPrjDataBase.DataBaseTypeId) == false)
{
objQxPrjDataBaseEN.dicFldComparisonOp.Add(conQxPrjDataBase.DataBaseTypeId, strComparisonOp);
}
else
{
objQxPrjDataBaseEN.dicFldComparisonOp[conQxPrjDataBase.DataBaseTypeId] = strComparisonOp;
}
}
return objQxPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataBaseUserId">数据库用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjDataBaseEN SetDataBaseUserId(this clsQxPrjDataBaseEN objQxPrjDataBaseEN, string strDataBaseUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataBaseUserId, 18, conQxPrjDataBase.DataBaseUserId);
objQxPrjDataBaseEN.DataBaseUserId = strDataBaseUserId; //数据库用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjDataBaseEN.dicFldComparisonOp.ContainsKey(conQxPrjDataBase.DataBaseUserId) == false)
{
objQxPrjDataBaseEN.dicFldComparisonOp.Add(conQxPrjDataBase.DataBaseUserId, strComparisonOp);
}
else
{
objQxPrjDataBaseEN.dicFldComparisonOp[conQxPrjDataBase.DataBaseUserId] = strComparisonOp;
}
}
return objQxPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strIpAddress">IP地址</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjDataBaseEN SetIpAddress(this clsQxPrjDataBaseEN objQxPrjDataBaseEN, string strIpAddress, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIpAddress, 23, conQxPrjDataBase.IpAddress);
objQxPrjDataBaseEN.IpAddress = strIpAddress; //IP地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjDataBaseEN.dicFldComparisonOp.ContainsKey(conQxPrjDataBase.IpAddress) == false)
{
objQxPrjDataBaseEN.dicFldComparisonOp.Add(conQxPrjDataBase.IpAddress, strComparisonOp);
}
else
{
objQxPrjDataBaseEN.dicFldComparisonOp[conQxPrjDataBase.IpAddress] = strComparisonOp;
}
}
return objQxPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strSID">SID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjDataBaseEN SetSID(this clsQxPrjDataBaseEN objQxPrjDataBaseEN, string strSID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSID, 30, conQxPrjDataBase.SID);
objQxPrjDataBaseEN.SID = strSID; //SID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjDataBaseEN.dicFldComparisonOp.ContainsKey(conQxPrjDataBase.SID) == false)
{
objQxPrjDataBaseEN.dicFldComparisonOp.Add(conQxPrjDataBase.SID, strComparisonOp);
}
else
{
objQxPrjDataBaseEN.dicFldComparisonOp[conQxPrjDataBase.SID] = strComparisonOp;
}
}
return objQxPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strTableSpace">表空间</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjDataBaseEN SetTableSpace(this clsQxPrjDataBaseEN objQxPrjDataBaseEN, string strTableSpace, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTableSpace, 30, conQxPrjDataBase.TableSpace);
objQxPrjDataBaseEN.TableSpace = strTableSpace; //表空间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjDataBaseEN.dicFldComparisonOp.ContainsKey(conQxPrjDataBase.TableSpace) == false)
{
objQxPrjDataBaseEN.dicFldComparisonOp.Add(conQxPrjDataBase.TableSpace, strComparisonOp);
}
else
{
objQxPrjDataBaseEN.dicFldComparisonOp[conQxPrjDataBase.TableSpace] = strComparisonOp;
}
}
return objQxPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjDataBaseEN SetUserId(this clsQxPrjDataBaseEN objQxPrjDataBaseEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 18, conQxPrjDataBase.UserId);
objQxPrjDataBaseEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjDataBaseEN.dicFldComparisonOp.ContainsKey(conQxPrjDataBase.UserId) == false)
{
objQxPrjDataBaseEN.dicFldComparisonOp.Add(conQxPrjDataBase.UserId, strComparisonOp);
}
else
{
objQxPrjDataBaseEN.dicFldComparisonOp[conQxPrjDataBase.UserId] = strComparisonOp;
}
}
return objQxPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjDataBaseEN SetUpdDate(this clsQxPrjDataBaseEN objQxPrjDataBaseEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQxPrjDataBase.UpdDate);
objQxPrjDataBaseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjDataBaseEN.dicFldComparisonOp.ContainsKey(conQxPrjDataBase.UpdDate) == false)
{
objQxPrjDataBaseEN.dicFldComparisonOp.Add(conQxPrjDataBase.UpdDate, strComparisonOp);
}
else
{
objQxPrjDataBaseEN.dicFldComparisonOp[conQxPrjDataBase.UpdDate] = strComparisonOp;
}
}
return objQxPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">备注</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjDataBaseEN SetMemo(this clsQxPrjDataBaseEN objQxPrjDataBaseEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQxPrjDataBase.Memo);
objQxPrjDataBaseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjDataBaseEN.dicFldComparisonOp.ContainsKey(conQxPrjDataBase.Memo) == false)
{
objQxPrjDataBaseEN.dicFldComparisonOp.Add(conQxPrjDataBase.Memo, strComparisonOp);
}
else
{
objQxPrjDataBaseEN.dicFldComparisonOp[conQxPrjDataBase.Memo] = strComparisonOp;
}
}
return objQxPrjDataBaseEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQxPrjDataBaseEN objQxPrjDataBaseCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQxPrjDataBaseCond.IsUpdated(conQxPrjDataBase.QxPrjDataBaseId) == true)
{
string strComparisonOpQxPrjDataBaseId = objQxPrjDataBaseCond.dicFldComparisonOp[conQxPrjDataBase.QxPrjDataBaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjDataBase.QxPrjDataBaseId, objQxPrjDataBaseCond.QxPrjDataBaseId, strComparisonOpQxPrjDataBaseId);
}
if (objQxPrjDataBaseCond.IsUpdated(conQxPrjDataBase.PrjDataBaseName) == true)
{
string strComparisonOpPrjDataBaseName = objQxPrjDataBaseCond.dicFldComparisonOp[conQxPrjDataBase.PrjDataBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjDataBase.PrjDataBaseName, objQxPrjDataBaseCond.PrjDataBaseName, strComparisonOpPrjDataBaseName);
}
if (objQxPrjDataBaseCond.IsUpdated(conQxPrjDataBase.DataBaseName) == true)
{
string strComparisonOpDataBaseName = objQxPrjDataBaseCond.dicFldComparisonOp[conQxPrjDataBase.DataBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjDataBase.DataBaseName, objQxPrjDataBaseCond.DataBaseName, strComparisonOpDataBaseName);
}
if (objQxPrjDataBaseCond.IsUpdated(conQxPrjDataBase.DatabaseOwner) == true)
{
string strComparisonOpDatabaseOwner = objQxPrjDataBaseCond.dicFldComparisonOp[conQxPrjDataBase.DatabaseOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjDataBase.DatabaseOwner, objQxPrjDataBaseCond.DatabaseOwner, strComparisonOpDatabaseOwner);
}
if (objQxPrjDataBaseCond.IsUpdated(conQxPrjDataBase.DataBasePwd) == true)
{
string strComparisonOpDataBasePwd = objQxPrjDataBaseCond.dicFldComparisonOp[conQxPrjDataBase.DataBasePwd];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjDataBase.DataBasePwd, objQxPrjDataBaseCond.DataBasePwd, strComparisonOpDataBasePwd);
}
if (objQxPrjDataBaseCond.IsUpdated(conQxPrjDataBase.DataBaseTypeId) == true)
{
string strComparisonOpDataBaseTypeId = objQxPrjDataBaseCond.dicFldComparisonOp[conQxPrjDataBase.DataBaseTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjDataBase.DataBaseTypeId, objQxPrjDataBaseCond.DataBaseTypeId, strComparisonOpDataBaseTypeId);
}
if (objQxPrjDataBaseCond.IsUpdated(conQxPrjDataBase.DataBaseUserId) == true)
{
string strComparisonOpDataBaseUserId = objQxPrjDataBaseCond.dicFldComparisonOp[conQxPrjDataBase.DataBaseUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjDataBase.DataBaseUserId, objQxPrjDataBaseCond.DataBaseUserId, strComparisonOpDataBaseUserId);
}
if (objQxPrjDataBaseCond.IsUpdated(conQxPrjDataBase.IpAddress) == true)
{
string strComparisonOpIpAddress = objQxPrjDataBaseCond.dicFldComparisonOp[conQxPrjDataBase.IpAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjDataBase.IpAddress, objQxPrjDataBaseCond.IpAddress, strComparisonOpIpAddress);
}
if (objQxPrjDataBaseCond.IsUpdated(conQxPrjDataBase.SID) == true)
{
string strComparisonOpSID = objQxPrjDataBaseCond.dicFldComparisonOp[conQxPrjDataBase.SID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjDataBase.SID, objQxPrjDataBaseCond.SID, strComparisonOpSID);
}
if (objQxPrjDataBaseCond.IsUpdated(conQxPrjDataBase.TableSpace) == true)
{
string strComparisonOpTableSpace = objQxPrjDataBaseCond.dicFldComparisonOp[conQxPrjDataBase.TableSpace];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjDataBase.TableSpace, objQxPrjDataBaseCond.TableSpace, strComparisonOpTableSpace);
}
if (objQxPrjDataBaseCond.IsUpdated(conQxPrjDataBase.UserId) == true)
{
string strComparisonOpUserId = objQxPrjDataBaseCond.dicFldComparisonOp[conQxPrjDataBase.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjDataBase.UserId, objQxPrjDataBaseCond.UserId, strComparisonOpUserId);
}
if (objQxPrjDataBaseCond.IsUpdated(conQxPrjDataBase.UpdDate) == true)
{
string strComparisonOpUpdDate = objQxPrjDataBaseCond.dicFldComparisonOp[conQxPrjDataBase.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjDataBase.UpdDate, objQxPrjDataBaseCond.UpdDate, strComparisonOpUpdDate);
}
if (objQxPrjDataBaseCond.IsUpdated(conQxPrjDataBase.Memo) == true)
{
string strComparisonOpMemo = objQxPrjDataBaseCond.dicFldComparisonOp[conQxPrjDataBase.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjDataBase.Memo, objQxPrjDataBaseCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objQxPrjDataBaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxPrjDataBaseEN objQxPrjDataBaseEN)
{
 if (string.IsNullOrEmpty(objQxPrjDataBaseEN.QxPrjDataBaseId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objQxPrjDataBaseEN.sfUpdFldSetStr = objQxPrjDataBaseEN.getsfUpdFldSetStr();
clsQxPrjDataBaseWApi.CheckPropertyNew(objQxPrjDataBaseEN); 
bool bolResult = clsQxPrjDataBaseWApi.UpdateRecord(objQxPrjDataBaseEN);
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
 /// 获取唯一性条件串--QxPrjDataBase(数据库对象), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PrjDataBaseName
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objQxPrjDataBaseEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsQxPrjDataBaseEN objQxPrjDataBaseEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objQxPrjDataBaseEN == null) return "";
if (objQxPrjDataBaseEN.QxPrjDataBaseId == null || objQxPrjDataBaseEN.QxPrjDataBaseId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjDataBaseName = '{0}'", objQxPrjDataBaseEN.PrjDataBaseName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("QxPrjDataBaseId !=  '{0}'", objQxPrjDataBaseEN.QxPrjDataBaseId);
 sbCondition.AppendFormat(" and PrjDataBaseName = '{0}'", objQxPrjDataBaseEN.PrjDataBaseName);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQxPrjDataBaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQxPrjDataBaseEN objQxPrjDataBaseEN)
{
try
{
 if (string.IsNullOrEmpty(objQxPrjDataBaseEN.QxPrjDataBaseId) == true || clsQxPrjDataBaseWApi.IsExist(objQxPrjDataBaseEN.QxPrjDataBaseId) == true)
 {
     objQxPrjDataBaseEN.QxPrjDataBaseId = clsQxPrjDataBaseWApi.GetMaxStrId();
 }
clsQxPrjDataBaseWApi.CheckPropertyNew(objQxPrjDataBaseEN); 
bool bolResult = clsQxPrjDataBaseWApi.AddNewRecord(objQxPrjDataBaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjDataBaseWApi.ReFreshCache();
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
 /// <param name = "objQxPrjDataBaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsQxPrjDataBaseEN objQxPrjDataBaseEN)
{
try
{
clsQxPrjDataBaseWApi.CheckPropertyNew(objQxPrjDataBaseEN); 
string strQxPrjDataBaseId = clsQxPrjDataBaseWApi.AddNewRecordWithMaxId(objQxPrjDataBaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjDataBaseWApi.ReFreshCache();
return strQxPrjDataBaseId;
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
 /// <param name = "objQxPrjDataBaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxPrjDataBaseEN objQxPrjDataBaseEN, string strWhereCond)
{
try
{
clsQxPrjDataBaseWApi.CheckPropertyNew(objQxPrjDataBaseEN); 
bool bolResult = clsQxPrjDataBaseWApi.UpdateWithCondition(objQxPrjDataBaseEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjDataBaseWApi.ReFreshCache();
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
 /// 数据库对象(QxPrjDataBase)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsQxPrjDataBaseWApi
{
private static readonly string mstrApiControllerName = "QxPrjDataBaseApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsQxPrjDataBaseWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_QxPrjDataBaseId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[数据库对象]...","0");
List<clsQxPrjDataBaseEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="QxPrjDataBaseId";
objDDL.DataTextField="PrjDataBaseName";
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_QxPrjDataBaseId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conQxPrjDataBase.QxPrjDataBaseId); 
List<clsQxPrjDataBaseEN> arrObjLst = clsQxPrjDataBaseWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsQxPrjDataBaseEN objQxPrjDataBaseEN = new clsQxPrjDataBaseEN()
{
QxPrjDataBaseId = "0",
PrjDataBaseName = "选[数据库对象]..."
};
arrObjLst.Insert(0, objQxPrjDataBaseEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conQxPrjDataBase.QxPrjDataBaseId;
objComboBox.DisplayMember = conQxPrjDataBase.PrjDataBaseName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsQxPrjDataBaseEN objQxPrjDataBaseEN)
{
if (!Object.Equals(null, objQxPrjDataBaseEN.QxPrjDataBaseId) && GetStrLen(objQxPrjDataBaseEN.QxPrjDataBaseId) > 4)
{
 throw new Exception("字段[项目数据库Id]的长度不能超过4!");
}
if (!Object.Equals(null, objQxPrjDataBaseEN.PrjDataBaseName) && GetStrLen(objQxPrjDataBaseEN.PrjDataBaseName) > 50)
{
 throw new Exception("字段[项目数据库名]的长度不能超过50!");
}
if (!Object.Equals(null, objQxPrjDataBaseEN.DataBaseName) && GetStrLen(objQxPrjDataBaseEN.DataBaseName) > 30)
{
 throw new Exception("字段[数据库名称]的长度不能超过30!");
}
if (!Object.Equals(null, objQxPrjDataBaseEN.DatabaseOwner) && GetStrLen(objQxPrjDataBaseEN.DatabaseOwner) > 30)
{
 throw new Exception("字段[数据库拥有者]的长度不能超过30!");
}
if (!Object.Equals(null, objQxPrjDataBaseEN.DataBasePwd) && GetStrLen(objQxPrjDataBaseEN.DataBasePwd) > 20)
{
 throw new Exception("字段[数据库用户口令]的长度不能超过20!");
}
if (!Object.Equals(null, objQxPrjDataBaseEN.DataBaseTypeId) && GetStrLen(objQxPrjDataBaseEN.DataBaseTypeId) > 2)
{
 throw new Exception("字段[数据库类型ID]的长度不能超过2!");
}
if (!Object.Equals(null, objQxPrjDataBaseEN.DataBaseUserId) && GetStrLen(objQxPrjDataBaseEN.DataBaseUserId) > 18)
{
 throw new Exception("字段[数据库用户Id]的长度不能超过18!");
}
if (!Object.Equals(null, objQxPrjDataBaseEN.IpAddress) && GetStrLen(objQxPrjDataBaseEN.IpAddress) > 23)
{
 throw new Exception("字段[IP地址]的长度不能超过23!");
}
if (!Object.Equals(null, objQxPrjDataBaseEN.SID) && GetStrLen(objQxPrjDataBaseEN.SID) > 30)
{
 throw new Exception("字段[SID]的长度不能超过30!");
}
if (!Object.Equals(null, objQxPrjDataBaseEN.TableSpace) && GetStrLen(objQxPrjDataBaseEN.TableSpace) > 30)
{
 throw new Exception("字段[表空间]的长度不能超过30!");
}
if (!Object.Equals(null, objQxPrjDataBaseEN.UserId) && GetStrLen(objQxPrjDataBaseEN.UserId) > 18)
{
 throw new Exception("字段[用户ID]的长度不能超过18!");
}
if (!Object.Equals(null, objQxPrjDataBaseEN.UpdDate) && GetStrLen(objQxPrjDataBaseEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objQxPrjDataBaseEN.Memo) && GetStrLen(objQxPrjDataBaseEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objQxPrjDataBaseEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strQxPrjDataBaseId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxPrjDataBaseEN GetObjByQxPrjDataBaseId(string strQxPrjDataBaseId)
{
string strAction = "GetObjByQxPrjDataBaseId";
clsQxPrjDataBaseEN objQxPrjDataBaseEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strQxPrjDataBaseId"] = strQxPrjDataBaseId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objQxPrjDataBaseEN = JsonConvert.DeserializeObject<clsQxPrjDataBaseEN>(strJson);
return objQxPrjDataBaseEN;
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
public static clsQxPrjDataBaseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsQxPrjDataBaseEN objQxPrjDataBaseEN;
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
objQxPrjDataBaseEN = JsonConvert.DeserializeObject<clsQxPrjDataBaseEN>(strJson);
return objQxPrjDataBaseEN;
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
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strQxPrjDataBaseId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxPrjDataBaseEN GetObjByQxPrjDataBaseIdCache(string strQxPrjDataBaseId)
{
if (string.IsNullOrEmpty(strQxPrjDataBaseId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsQxPrjDataBaseEN._CurrTabName);
List<clsQxPrjDataBaseEN> arrQxPrjDataBaseObjLstCache = GetObjLstCache();
IEnumerable <clsQxPrjDataBaseEN> arrQxPrjDataBaseObjLst_Sel =
from objQxPrjDataBaseEN in arrQxPrjDataBaseObjLstCache
where objQxPrjDataBaseEN.QxPrjDataBaseId == strQxPrjDataBaseId 
select objQxPrjDataBaseEN;
if (arrQxPrjDataBaseObjLst_Sel.Count() == 0)
{
   clsQxPrjDataBaseEN obj = clsQxPrjDataBaseWApi.GetObjByQxPrjDataBaseId(strQxPrjDataBaseId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrQxPrjDataBaseObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strQxPrjDataBaseId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetPrjDataBaseNameByQxPrjDataBaseIdCache(string strQxPrjDataBaseId)
{
if (string.IsNullOrEmpty(strQxPrjDataBaseId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsQxPrjDataBaseEN._CurrTabName);
List<clsQxPrjDataBaseEN> arrQxPrjDataBaseObjLstCache = GetObjLstCache();
IEnumerable <clsQxPrjDataBaseEN> arrQxPrjDataBaseObjLst_Sel1 =
from objQxPrjDataBaseEN in arrQxPrjDataBaseObjLstCache
where objQxPrjDataBaseEN.QxPrjDataBaseId == strQxPrjDataBaseId 
select objQxPrjDataBaseEN;
List <clsQxPrjDataBaseEN> arrQxPrjDataBaseObjLst_Sel = new List<clsQxPrjDataBaseEN>();
foreach (clsQxPrjDataBaseEN obj in arrQxPrjDataBaseObjLst_Sel1)
{
arrQxPrjDataBaseObjLst_Sel.Add(obj);
}
if (arrQxPrjDataBaseObjLst_Sel.Count > 0)
{
return arrQxPrjDataBaseObjLst_Sel[0].PrjDataBaseName;
}
string strErrMsgForGetObjById = string.Format("在QxPrjDataBase对象缓存列表中,找不到记录[QxPrjDataBaseId = {0}](函数:{1})", strQxPrjDataBaseId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsQxPrjDataBaseBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strQxPrjDataBaseId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByQxPrjDataBaseIdCache(string strQxPrjDataBaseId)
{
if (string.IsNullOrEmpty(strQxPrjDataBaseId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsQxPrjDataBaseEN._CurrTabName);
List<clsQxPrjDataBaseEN> arrQxPrjDataBaseObjLstCache = GetObjLstCache();
IEnumerable <clsQxPrjDataBaseEN> arrQxPrjDataBaseObjLst_Sel1 =
from objQxPrjDataBaseEN in arrQxPrjDataBaseObjLstCache
where objQxPrjDataBaseEN.QxPrjDataBaseId == strQxPrjDataBaseId 
select objQxPrjDataBaseEN;
List <clsQxPrjDataBaseEN> arrQxPrjDataBaseObjLst_Sel = new List<clsQxPrjDataBaseEN>();
foreach (clsQxPrjDataBaseEN obj in arrQxPrjDataBaseObjLst_Sel1)
{
arrQxPrjDataBaseObjLst_Sel.Add(obj);
}
if (arrQxPrjDataBaseObjLst_Sel.Count > 0)
{
return arrQxPrjDataBaseObjLst_Sel[0].PrjDataBaseName;
}
string strErrMsgForGetObjById = string.Format("在QxPrjDataBase对象缓存列表中,找不到记录的相关名称[QxPrjDataBaseId = {0}](函数:{1})", strQxPrjDataBaseId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsQxPrjDataBaseBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPrjDataBaseEN> GetObjLst(string strWhereCond)
{
 List<clsQxPrjDataBaseEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxPrjDataBaseEN>>(strJson);
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
 /// <param name = "arrQxPrjDataBaseId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPrjDataBaseEN> GetObjLstByQxPrjDataBaseIdLst(List<string> arrQxPrjDataBaseId)
{
 List<clsQxPrjDataBaseEN> arrObjLst; 
string strAction = "GetObjLstByQxPrjDataBaseIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrQxPrjDataBaseId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsQxPrjDataBaseEN>>(strJson);
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

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrQxPrjDataBaseId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsQxPrjDataBaseEN> GetObjLstByQxPrjDataBaseIdLstCache(List<string> arrQxPrjDataBaseId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsQxPrjDataBaseEN._CurrTabName);
List<clsQxPrjDataBaseEN> arrQxPrjDataBaseObjLstCache = GetObjLstCache();
IEnumerable <clsQxPrjDataBaseEN> arrQxPrjDataBaseObjLst_Sel =
from objQxPrjDataBaseEN in arrQxPrjDataBaseObjLstCache
where arrQxPrjDataBaseId.Contains(objQxPrjDataBaseEN.QxPrjDataBaseId)
select objQxPrjDataBaseEN;
return arrQxPrjDataBaseObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPrjDataBaseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsQxPrjDataBaseEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxPrjDataBaseEN>>(strJson);
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
public static List<clsQxPrjDataBaseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsQxPrjDataBaseEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxPrjDataBaseEN>>(strJson);
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
public static List<clsQxPrjDataBaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsQxPrjDataBaseEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxPrjDataBaseEN>>(strJson);
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
public static List<clsQxPrjDataBaseEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsQxPrjDataBaseEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxPrjDataBaseEN>>(strJson);
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
public static int DelRecord(string strQxPrjDataBaseId)
{
string strAction = "DelRecord";
try
{
 clsQxPrjDataBaseEN objQxPrjDataBaseEN = clsQxPrjDataBaseWApi.GetObjByQxPrjDataBaseId(strQxPrjDataBaseId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strQxPrjDataBaseId.ToString(), out string strResult, out string strErrMsg) == true)
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
public static int DelQxPrjDataBases(List<string> arrQxPrjDataBaseId)
{
string strAction = "DelQxPrjDataBases";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrQxPrjDataBaseId);
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
public static int DelQxPrjDataBasesByCond(string strWhereCond)
{
string strAction = "DelQxPrjDataBasesByCond";
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
public static bool AddNewRecord(clsQxPrjDataBaseEN objQxPrjDataBaseEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxPrjDataBaseEN>(objQxPrjDataBaseEN);
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
public static string AddNewRecordWithMaxId(clsQxPrjDataBaseEN objQxPrjDataBaseEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxPrjDataBaseEN>(objQxPrjDataBaseEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
var strQxPrjDataBaseId = (string)jobjReturn0["returnStr"];
return strQxPrjDataBaseId;
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
public static bool UpdateRecord(clsQxPrjDataBaseEN objQxPrjDataBaseEN)
{
if (string.IsNullOrEmpty(objQxPrjDataBaseEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objQxPrjDataBaseEN.QxPrjDataBaseId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxPrjDataBaseEN>(objQxPrjDataBaseEN);
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
 /// <param name = "objQxPrjDataBaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsQxPrjDataBaseEN objQxPrjDataBaseEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objQxPrjDataBaseEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objQxPrjDataBaseEN.QxPrjDataBaseId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objQxPrjDataBaseEN.QxPrjDataBaseId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxPrjDataBaseEN>(objQxPrjDataBaseEN);
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
public static bool IsExist(string strQxPrjDataBaseId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strQxPrjDataBaseId"] = strQxPrjDataBaseId
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
 /// <param name = "objQxPrjDataBaseENS">源对象</param>
 /// <param name = "objQxPrjDataBaseENT">目标对象</param>
 public static void CopyTo(clsQxPrjDataBaseEN objQxPrjDataBaseENS, clsQxPrjDataBaseEN objQxPrjDataBaseENT)
{
try
{
objQxPrjDataBaseENT.QxPrjDataBaseId = objQxPrjDataBaseENS.QxPrjDataBaseId; //项目数据库Id
objQxPrjDataBaseENT.PrjDataBaseName = objQxPrjDataBaseENS.PrjDataBaseName; //项目数据库名
objQxPrjDataBaseENT.DataBaseName = objQxPrjDataBaseENS.DataBaseName; //数据库名称
objQxPrjDataBaseENT.DatabaseOwner = objQxPrjDataBaseENS.DatabaseOwner; //数据库拥有者
objQxPrjDataBaseENT.DataBasePwd = objQxPrjDataBaseENS.DataBasePwd; //数据库用户口令
objQxPrjDataBaseENT.DataBaseTypeId = objQxPrjDataBaseENS.DataBaseTypeId; //数据库类型ID
objQxPrjDataBaseENT.DataBaseUserId = objQxPrjDataBaseENS.DataBaseUserId; //数据库用户Id
objQxPrjDataBaseENT.IpAddress = objQxPrjDataBaseENS.IpAddress; //IP地址
objQxPrjDataBaseENT.SID = objQxPrjDataBaseENS.SID; //SID
objQxPrjDataBaseENT.TableSpace = objQxPrjDataBaseENS.TableSpace; //表空间
objQxPrjDataBaseENT.UserId = objQxPrjDataBaseENS.UserId; //用户ID
objQxPrjDataBaseENT.UpdDate = objQxPrjDataBaseENS.UpdDate; //修改日期
objQxPrjDataBaseENT.Memo = objQxPrjDataBaseENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsQxPrjDataBaseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsQxPrjDataBaseEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsQxPrjDataBaseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsQxPrjDataBaseEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsQxPrjDataBaseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsQxPrjDataBaseEN.AttributeName)
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
string strKey = string.Format("{0}", clsQxPrjDataBaseEN._CurrTabName);
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
if (clsQxPrjDataBaseWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsQxPrjDataBaseEN._CurrTabName);
CacheHelper.Remove(strKey);
clsQxPrjDataBaseWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxPrjDataBaseEN> GetObjLstCache()
{
//初始化列表缓存
var strWhereCond = "";
var strKey = clsQxPrjDataBaseEN._CurrTabName;
List<clsQxPrjDataBaseEN> arrQxPrjDataBaseObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrQxPrjDataBaseObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsQxPrjDataBaseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conQxPrjDataBase.QxPrjDataBaseId, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjDataBase.PrjDataBaseName, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjDataBase.DataBaseName, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjDataBase.DatabaseOwner, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjDataBase.DataBasePwd, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjDataBase.DataBaseTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjDataBase.DataBaseUserId, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjDataBase.IpAddress, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjDataBase.SID, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjDataBase.TableSpace, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjDataBase.UserId, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjDataBase.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjDataBase.Memo, Type.GetType("System.String"));
foreach (clsQxPrjDataBaseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conQxPrjDataBase.QxPrjDataBaseId] = objInFor[conQxPrjDataBase.QxPrjDataBaseId];
objDR[conQxPrjDataBase.PrjDataBaseName] = objInFor[conQxPrjDataBase.PrjDataBaseName];
objDR[conQxPrjDataBase.DataBaseName] = objInFor[conQxPrjDataBase.DataBaseName];
objDR[conQxPrjDataBase.DatabaseOwner] = objInFor[conQxPrjDataBase.DatabaseOwner];
objDR[conQxPrjDataBase.DataBasePwd] = objInFor[conQxPrjDataBase.DataBasePwd];
objDR[conQxPrjDataBase.DataBaseTypeId] = objInFor[conQxPrjDataBase.DataBaseTypeId];
objDR[conQxPrjDataBase.DataBaseUserId] = objInFor[conQxPrjDataBase.DataBaseUserId];
objDR[conQxPrjDataBase.IpAddress] = objInFor[conQxPrjDataBase.IpAddress];
objDR[conQxPrjDataBase.SID] = objInFor[conQxPrjDataBase.SID];
objDR[conQxPrjDataBase.TableSpace] = objInFor[conQxPrjDataBase.TableSpace];
objDR[conQxPrjDataBase.UserId] = objInFor[conQxPrjDataBase.UserId];
objDR[conQxPrjDataBase.UpdDate] = objInFor[conQxPrjDataBase.UpdDate];
objDR[conQxPrjDataBase.Memo] = objInFor[conQxPrjDataBase.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 数据库对象(QxPrjDataBase)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4QxPrjDataBase : clsCommFun4BL
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
clsQxPrjDataBaseWApi.ReFreshThisCache();
}
}

}