
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPrjDataBaseWApi
 表名:vQxPrjDataBase(00140040)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 18:31:01
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
public static class  clsvQxPrjDataBaseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strQxPrjDataBaseId">项目数据库Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjDataBaseEN SetQxPrjDataBaseId(this clsvQxPrjDataBaseEN objvQxPrjDataBaseEN, string strQxPrjDataBaseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQxPrjDataBaseId, 4, convQxPrjDataBase.QxPrjDataBaseId);
clsCheckSql.CheckFieldForeignKey(strQxPrjDataBaseId, 4, convQxPrjDataBase.QxPrjDataBaseId);
objvQxPrjDataBaseEN.QxPrjDataBaseId = strQxPrjDataBaseId; //项目数据库Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convQxPrjDataBase.QxPrjDataBaseId) == false)
{
objvQxPrjDataBaseEN.dicFldComparisonOp.Add(convQxPrjDataBase.QxPrjDataBaseId, strComparisonOp);
}
else
{
objvQxPrjDataBaseEN.dicFldComparisonOp[convQxPrjDataBase.QxPrjDataBaseId] = strComparisonOp;
}
}
return objvQxPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjDataBaseName">项目数据库名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjDataBaseEN SetPrjDataBaseName(this clsvQxPrjDataBaseEN objvQxPrjDataBaseEN, string strPrjDataBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjDataBaseName, 50, convQxPrjDataBase.PrjDataBaseName);
objvQxPrjDataBaseEN.PrjDataBaseName = strPrjDataBaseName; //项目数据库名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convQxPrjDataBase.PrjDataBaseName) == false)
{
objvQxPrjDataBaseEN.dicFldComparisonOp.Add(convQxPrjDataBase.PrjDataBaseName, strComparisonOp);
}
else
{
objvQxPrjDataBaseEN.dicFldComparisonOp[convQxPrjDataBase.PrjDataBaseName] = strComparisonOp;
}
}
return objvQxPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strIpAddress">IP地址</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjDataBaseEN SetIpAddress(this clsvQxPrjDataBaseEN objvQxPrjDataBaseEN, string strIpAddress, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIpAddress, 23, convQxPrjDataBase.IpAddress);
objvQxPrjDataBaseEN.IpAddress = strIpAddress; //IP地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convQxPrjDataBase.IpAddress) == false)
{
objvQxPrjDataBaseEN.dicFldComparisonOp.Add(convQxPrjDataBase.IpAddress, strComparisonOp);
}
else
{
objvQxPrjDataBaseEN.dicFldComparisonOp[convQxPrjDataBase.IpAddress] = strComparisonOp;
}
}
return objvQxPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataBaseUserId">数据库用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjDataBaseEN SetDataBaseUserId(this clsvQxPrjDataBaseEN objvQxPrjDataBaseEN, string strDataBaseUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataBaseUserId, 18, convQxPrjDataBase.DataBaseUserId);
objvQxPrjDataBaseEN.DataBaseUserId = strDataBaseUserId; //数据库用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convQxPrjDataBase.DataBaseUserId) == false)
{
objvQxPrjDataBaseEN.dicFldComparisonOp.Add(convQxPrjDataBase.DataBaseUserId, strComparisonOp);
}
else
{
objvQxPrjDataBaseEN.dicFldComparisonOp[convQxPrjDataBase.DataBaseUserId] = strComparisonOp;
}
}
return objvQxPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataBasePwd">数据库用户口令</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjDataBaseEN SetDataBasePwd(this clsvQxPrjDataBaseEN objvQxPrjDataBaseEN, string strDataBasePwd, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataBasePwd, 20, convQxPrjDataBase.DataBasePwd);
objvQxPrjDataBaseEN.DataBasePwd = strDataBasePwd; //数据库用户口令
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convQxPrjDataBase.DataBasePwd) == false)
{
objvQxPrjDataBaseEN.dicFldComparisonOp.Add(convQxPrjDataBase.DataBasePwd, strComparisonOp);
}
else
{
objvQxPrjDataBaseEN.dicFldComparisonOp[convQxPrjDataBase.DataBasePwd] = strComparisonOp;
}
}
return objvQxPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataBaseName">数据库名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjDataBaseEN SetDataBaseName(this clsvQxPrjDataBaseEN objvQxPrjDataBaseEN, string strDataBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataBaseName, 30, convQxPrjDataBase.DataBaseName);
objvQxPrjDataBaseEN.DataBaseName = strDataBaseName; //数据库名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convQxPrjDataBase.DataBaseName) == false)
{
objvQxPrjDataBaseEN.dicFldComparisonOp.Add(convQxPrjDataBase.DataBaseName, strComparisonOp);
}
else
{
objvQxPrjDataBaseEN.dicFldComparisonOp[convQxPrjDataBase.DataBaseName] = strComparisonOp;
}
}
return objvQxPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataBaseTypeName">数据库类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjDataBaseEN SetDataBaseTypeName(this clsvQxPrjDataBaseEN objvQxPrjDataBaseEN, string strDataBaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataBaseTypeName, convQxPrjDataBase.DataBaseTypeName);
clsCheckSql.CheckFieldLen(strDataBaseTypeName, 30, convQxPrjDataBase.DataBaseTypeName);
objvQxPrjDataBaseEN.DataBaseTypeName = strDataBaseTypeName; //数据库类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convQxPrjDataBase.DataBaseTypeName) == false)
{
objvQxPrjDataBaseEN.dicFldComparisonOp.Add(convQxPrjDataBase.DataBaseTypeName, strComparisonOp);
}
else
{
objvQxPrjDataBaseEN.dicFldComparisonOp[convQxPrjDataBase.DataBaseTypeName] = strComparisonOp;
}
}
return objvQxPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataBaseTypeId">数据库类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjDataBaseEN SetDataBaseTypeId(this clsvQxPrjDataBaseEN objvQxPrjDataBaseEN, string strDataBaseTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataBaseTypeId, convQxPrjDataBase.DataBaseTypeId);
clsCheckSql.CheckFieldLen(strDataBaseTypeId, 2, convQxPrjDataBase.DataBaseTypeId);
clsCheckSql.CheckFieldForeignKey(strDataBaseTypeId, 2, convQxPrjDataBase.DataBaseTypeId);
objvQxPrjDataBaseEN.DataBaseTypeId = strDataBaseTypeId; //数据库类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convQxPrjDataBase.DataBaseTypeId) == false)
{
objvQxPrjDataBaseEN.dicFldComparisonOp.Add(convQxPrjDataBase.DataBaseTypeId, strComparisonOp);
}
else
{
objvQxPrjDataBaseEN.dicFldComparisonOp[convQxPrjDataBase.DataBaseTypeId] = strComparisonOp;
}
}
return objvQxPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strDatabaseOwner">数据库拥有者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjDataBaseEN SetDatabaseOwner(this clsvQxPrjDataBaseEN objvQxPrjDataBaseEN, string strDatabaseOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDatabaseOwner, 30, convQxPrjDataBase.DatabaseOwner);
objvQxPrjDataBaseEN.DatabaseOwner = strDatabaseOwner; //数据库拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convQxPrjDataBase.DatabaseOwner) == false)
{
objvQxPrjDataBaseEN.dicFldComparisonOp.Add(convQxPrjDataBase.DatabaseOwner, strComparisonOp);
}
else
{
objvQxPrjDataBaseEN.dicFldComparisonOp[convQxPrjDataBase.DatabaseOwner] = strComparisonOp;
}
}
return objvQxPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strTableSpace">表空间</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjDataBaseEN SetTableSpace(this clsvQxPrjDataBaseEN objvQxPrjDataBaseEN, string strTableSpace, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTableSpace, 30, convQxPrjDataBase.TableSpace);
objvQxPrjDataBaseEN.TableSpace = strTableSpace; //表空间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convQxPrjDataBase.TableSpace) == false)
{
objvQxPrjDataBaseEN.dicFldComparisonOp.Add(convQxPrjDataBase.TableSpace, strComparisonOp);
}
else
{
objvQxPrjDataBaseEN.dicFldComparisonOp[convQxPrjDataBase.TableSpace] = strComparisonOp;
}
}
return objvQxPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjDataBaseEN SetUpdDate(this clsvQxPrjDataBaseEN objvQxPrjDataBaseEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQxPrjDataBase.UpdDate);
objvQxPrjDataBaseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convQxPrjDataBase.UpdDate) == false)
{
objvQxPrjDataBaseEN.dicFldComparisonOp.Add(convQxPrjDataBase.UpdDate, strComparisonOp);
}
else
{
objvQxPrjDataBaseEN.dicFldComparisonOp[convQxPrjDataBase.UpdDate] = strComparisonOp;
}
}
return objvQxPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strSID">SID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjDataBaseEN SetSID(this clsvQxPrjDataBaseEN objvQxPrjDataBaseEN, string strSID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSID, 30, convQxPrjDataBase.SID);
objvQxPrjDataBaseEN.SID = strSID; //SID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convQxPrjDataBase.SID) == false)
{
objvQxPrjDataBaseEN.dicFldComparisonOp.Add(convQxPrjDataBase.SID, strComparisonOp);
}
else
{
objvQxPrjDataBaseEN.dicFldComparisonOp[convQxPrjDataBase.SID] = strComparisonOp;
}
}
return objvQxPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjDataBaseEN SetUserId(this clsvQxPrjDataBaseEN objvQxPrjDataBaseEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convQxPrjDataBase.UserId);
clsCheckSql.CheckFieldLen(strUserId, 18, convQxPrjDataBase.UserId);
objvQxPrjDataBaseEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convQxPrjDataBase.UserId) == false)
{
objvQxPrjDataBaseEN.dicFldComparisonOp.Add(convQxPrjDataBase.UserId, strComparisonOp);
}
else
{
objvQxPrjDataBaseEN.dicFldComparisonOp[convQxPrjDataBase.UserId] = strComparisonOp;
}
}
return objvQxPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">备注</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjDataBaseEN SetMemo(this clsvQxPrjDataBaseEN objvQxPrjDataBaseEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxPrjDataBase.Memo);
objvQxPrjDataBaseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convQxPrjDataBase.Memo) == false)
{
objvQxPrjDataBaseEN.dicFldComparisonOp.Add(convQxPrjDataBase.Memo, strComparisonOp);
}
else
{
objvQxPrjDataBaseEN.dicFldComparisonOp[convQxPrjDataBase.Memo] = strComparisonOp;
}
}
return objvQxPrjDataBaseEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQxPrjDataBaseEN objvQxPrjDataBaseCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQxPrjDataBaseCond.IsUpdated(convQxPrjDataBase.QxPrjDataBaseId) == true)
{
string strComparisonOpQxPrjDataBaseId = objvQxPrjDataBaseCond.dicFldComparisonOp[convQxPrjDataBase.QxPrjDataBaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjDataBase.QxPrjDataBaseId, objvQxPrjDataBaseCond.QxPrjDataBaseId, strComparisonOpQxPrjDataBaseId);
}
if (objvQxPrjDataBaseCond.IsUpdated(convQxPrjDataBase.PrjDataBaseName) == true)
{
string strComparisonOpPrjDataBaseName = objvQxPrjDataBaseCond.dicFldComparisonOp[convQxPrjDataBase.PrjDataBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjDataBase.PrjDataBaseName, objvQxPrjDataBaseCond.PrjDataBaseName, strComparisonOpPrjDataBaseName);
}
if (objvQxPrjDataBaseCond.IsUpdated(convQxPrjDataBase.IpAddress) == true)
{
string strComparisonOpIpAddress = objvQxPrjDataBaseCond.dicFldComparisonOp[convQxPrjDataBase.IpAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjDataBase.IpAddress, objvQxPrjDataBaseCond.IpAddress, strComparisonOpIpAddress);
}
if (objvQxPrjDataBaseCond.IsUpdated(convQxPrjDataBase.DataBaseUserId) == true)
{
string strComparisonOpDataBaseUserId = objvQxPrjDataBaseCond.dicFldComparisonOp[convQxPrjDataBase.DataBaseUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjDataBase.DataBaseUserId, objvQxPrjDataBaseCond.DataBaseUserId, strComparisonOpDataBaseUserId);
}
if (objvQxPrjDataBaseCond.IsUpdated(convQxPrjDataBase.DataBasePwd) == true)
{
string strComparisonOpDataBasePwd = objvQxPrjDataBaseCond.dicFldComparisonOp[convQxPrjDataBase.DataBasePwd];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjDataBase.DataBasePwd, objvQxPrjDataBaseCond.DataBasePwd, strComparisonOpDataBasePwd);
}
if (objvQxPrjDataBaseCond.IsUpdated(convQxPrjDataBase.DataBaseName) == true)
{
string strComparisonOpDataBaseName = objvQxPrjDataBaseCond.dicFldComparisonOp[convQxPrjDataBase.DataBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjDataBase.DataBaseName, objvQxPrjDataBaseCond.DataBaseName, strComparisonOpDataBaseName);
}
if (objvQxPrjDataBaseCond.IsUpdated(convQxPrjDataBase.DataBaseTypeName) == true)
{
string strComparisonOpDataBaseTypeName = objvQxPrjDataBaseCond.dicFldComparisonOp[convQxPrjDataBase.DataBaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjDataBase.DataBaseTypeName, objvQxPrjDataBaseCond.DataBaseTypeName, strComparisonOpDataBaseTypeName);
}
if (objvQxPrjDataBaseCond.IsUpdated(convQxPrjDataBase.DataBaseTypeId) == true)
{
string strComparisonOpDataBaseTypeId = objvQxPrjDataBaseCond.dicFldComparisonOp[convQxPrjDataBase.DataBaseTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjDataBase.DataBaseTypeId, objvQxPrjDataBaseCond.DataBaseTypeId, strComparisonOpDataBaseTypeId);
}
if (objvQxPrjDataBaseCond.IsUpdated(convQxPrjDataBase.DatabaseOwner) == true)
{
string strComparisonOpDatabaseOwner = objvQxPrjDataBaseCond.dicFldComparisonOp[convQxPrjDataBase.DatabaseOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjDataBase.DatabaseOwner, objvQxPrjDataBaseCond.DatabaseOwner, strComparisonOpDatabaseOwner);
}
if (objvQxPrjDataBaseCond.IsUpdated(convQxPrjDataBase.TableSpace) == true)
{
string strComparisonOpTableSpace = objvQxPrjDataBaseCond.dicFldComparisonOp[convQxPrjDataBase.TableSpace];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjDataBase.TableSpace, objvQxPrjDataBaseCond.TableSpace, strComparisonOpTableSpace);
}
if (objvQxPrjDataBaseCond.IsUpdated(convQxPrjDataBase.UpdDate) == true)
{
string strComparisonOpUpdDate = objvQxPrjDataBaseCond.dicFldComparisonOp[convQxPrjDataBase.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjDataBase.UpdDate, objvQxPrjDataBaseCond.UpdDate, strComparisonOpUpdDate);
}
if (objvQxPrjDataBaseCond.IsUpdated(convQxPrjDataBase.SID) == true)
{
string strComparisonOpSID = objvQxPrjDataBaseCond.dicFldComparisonOp[convQxPrjDataBase.SID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjDataBase.SID, objvQxPrjDataBaseCond.SID, strComparisonOpSID);
}
if (objvQxPrjDataBaseCond.IsUpdated(convQxPrjDataBase.UserId) == true)
{
string strComparisonOpUserId = objvQxPrjDataBaseCond.dicFldComparisonOp[convQxPrjDataBase.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjDataBase.UserId, objvQxPrjDataBaseCond.UserId, strComparisonOpUserId);
}
if (objvQxPrjDataBaseCond.IsUpdated(convQxPrjDataBase.Memo) == true)
{
string strComparisonOpMemo = objvQxPrjDataBaseCond.dicFldComparisonOp[convQxPrjDataBase.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjDataBase.Memo, objvQxPrjDataBaseCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v数据库对象(vQxPrjDataBase)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxPrjDataBaseWApi
{
private static readonly string mstrApiControllerName = "vQxPrjDataBaseApi";

 public clsvQxPrjDataBaseWApi()
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v数据库对象]...","0");
List<clsvQxPrjDataBaseEN> arrObjLst = GetObjLst("1=1");
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
string strCondition = string.Format("1 =1 Order By {0}", convQxPrjDataBase.QxPrjDataBaseId); 
List<clsvQxPrjDataBaseEN> arrObjLst = clsvQxPrjDataBaseWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvQxPrjDataBaseEN objvQxPrjDataBaseEN = new clsvQxPrjDataBaseEN()
{
QxPrjDataBaseId = "0",
PrjDataBaseName = "选[v数据库对象]..."
};
arrObjLst.Insert(0, objvQxPrjDataBaseEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convQxPrjDataBase.QxPrjDataBaseId;
objComboBox.DisplayMember = convQxPrjDataBase.PrjDataBaseName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strQxPrjDataBaseId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxPrjDataBaseEN GetObjByQxPrjDataBaseId(string strQxPrjDataBaseId)
{
string strAction = "GetObjByQxPrjDataBaseId";
clsvQxPrjDataBaseEN objvQxPrjDataBaseEN;
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
objvQxPrjDataBaseEN = JsonConvert.DeserializeObject<clsvQxPrjDataBaseEN>(strJson);
return objvQxPrjDataBaseEN;
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
public static clsvQxPrjDataBaseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvQxPrjDataBaseEN objvQxPrjDataBaseEN;
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
objvQxPrjDataBaseEN = JsonConvert.DeserializeObject<clsvQxPrjDataBaseEN>(strJson);
return objvQxPrjDataBaseEN;
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
//该表没有使用Cache,不需要生成[GetPrjDataBaseNameByQxPrjDataBaseIdCache]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjDataBaseEN> GetObjLst(string strWhereCond)
{
 List<clsvQxPrjDataBaseEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjDataBaseEN>>(strJson);
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
public static List<clsvQxPrjDataBaseEN> GetObjLstByQxPrjDataBaseIdLst(List<string> arrQxPrjDataBaseId)
{
 List<clsvQxPrjDataBaseEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjDataBaseEN>>(strJson);
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
public static List<clsvQxPrjDataBaseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvQxPrjDataBaseEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjDataBaseEN>>(strJson);
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
public static List<clsvQxPrjDataBaseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvQxPrjDataBaseEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjDataBaseEN>>(strJson);
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
public static List<clsvQxPrjDataBaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvQxPrjDataBaseEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjDataBaseEN>>(strJson);
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
public static List<clsvQxPrjDataBaseEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvQxPrjDataBaseEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjDataBaseEN>>(strJson);
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objvQxPrjDataBaseENS">源对象</param>
 /// <param name = "objvQxPrjDataBaseENT">目标对象</param>
 public static void CopyTo(clsvQxPrjDataBaseEN objvQxPrjDataBaseENS, clsvQxPrjDataBaseEN objvQxPrjDataBaseENT)
{
try
{
objvQxPrjDataBaseENT.QxPrjDataBaseId = objvQxPrjDataBaseENS.QxPrjDataBaseId; //项目数据库Id
objvQxPrjDataBaseENT.PrjDataBaseName = objvQxPrjDataBaseENS.PrjDataBaseName; //项目数据库名
objvQxPrjDataBaseENT.IpAddress = objvQxPrjDataBaseENS.IpAddress; //IP地址
objvQxPrjDataBaseENT.DataBaseUserId = objvQxPrjDataBaseENS.DataBaseUserId; //数据库用户Id
objvQxPrjDataBaseENT.DataBasePwd = objvQxPrjDataBaseENS.DataBasePwd; //数据库用户口令
objvQxPrjDataBaseENT.DataBaseName = objvQxPrjDataBaseENS.DataBaseName; //数据库名称
objvQxPrjDataBaseENT.DataBaseTypeName = objvQxPrjDataBaseENS.DataBaseTypeName; //数据库类型名
objvQxPrjDataBaseENT.DataBaseTypeId = objvQxPrjDataBaseENS.DataBaseTypeId; //数据库类型ID
objvQxPrjDataBaseENT.DatabaseOwner = objvQxPrjDataBaseENS.DatabaseOwner; //数据库拥有者
objvQxPrjDataBaseENT.TableSpace = objvQxPrjDataBaseENS.TableSpace; //表空间
objvQxPrjDataBaseENT.UpdDate = objvQxPrjDataBaseENS.UpdDate; //修改日期
objvQxPrjDataBaseENT.SID = objvQxPrjDataBaseENS.SID; //SID
objvQxPrjDataBaseENT.UserId = objvQxPrjDataBaseENS.UserId; //用户ID
objvQxPrjDataBaseENT.Memo = objvQxPrjDataBaseENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvQxPrjDataBaseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvQxPrjDataBaseEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvQxPrjDataBaseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvQxPrjDataBaseEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvQxPrjDataBaseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvQxPrjDataBaseEN.AttributeName)
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
string strKey = string.Format("{0}", clsvQxPrjDataBaseEN._CurrTabName);
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
//该表没有使用Cache,不需要生成[GetObjLstCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvQxPrjDataBaseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convQxPrjDataBase.QxPrjDataBaseId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjDataBase.PrjDataBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjDataBase.IpAddress, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjDataBase.DataBaseUserId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjDataBase.DataBasePwd, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjDataBase.DataBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjDataBase.DataBaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjDataBase.DataBaseTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjDataBase.DatabaseOwner, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjDataBase.TableSpace, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjDataBase.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjDataBase.SID, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjDataBase.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjDataBase.Memo, Type.GetType("System.String"));
foreach (clsvQxPrjDataBaseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convQxPrjDataBase.QxPrjDataBaseId] = objInFor[convQxPrjDataBase.QxPrjDataBaseId];
objDR[convQxPrjDataBase.PrjDataBaseName] = objInFor[convQxPrjDataBase.PrjDataBaseName];
objDR[convQxPrjDataBase.IpAddress] = objInFor[convQxPrjDataBase.IpAddress];
objDR[convQxPrjDataBase.DataBaseUserId] = objInFor[convQxPrjDataBase.DataBaseUserId];
objDR[convQxPrjDataBase.DataBasePwd] = objInFor[convQxPrjDataBase.DataBasePwd];
objDR[convQxPrjDataBase.DataBaseName] = objInFor[convQxPrjDataBase.DataBaseName];
objDR[convQxPrjDataBase.DataBaseTypeName] = objInFor[convQxPrjDataBase.DataBaseTypeName];
objDR[convQxPrjDataBase.DataBaseTypeId] = objInFor[convQxPrjDataBase.DataBaseTypeId];
objDR[convQxPrjDataBase.DatabaseOwner] = objInFor[convQxPrjDataBase.DatabaseOwner];
objDR[convQxPrjDataBase.TableSpace] = objInFor[convQxPrjDataBase.TableSpace];
objDR[convQxPrjDataBase.UpdDate] = objInFor[convQxPrjDataBase.UpdDate];
objDR[convQxPrjDataBase.SID] = objInFor[convQxPrjDataBase.SID];
objDR[convQxPrjDataBase.UserId] = objInFor[convQxPrjDataBase.UserId];
objDR[convQxPrjDataBase.Memo] = objInFor[convQxPrjDataBase.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}