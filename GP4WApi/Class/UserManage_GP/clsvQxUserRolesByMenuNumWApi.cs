
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxRolesByMenuNumWApi
 表名:vQxRolesByMenuNum(00140083)
 * 版本:2023.12.26.1(服务器:WIN-SRV103-116)
 日期:2023/12/28 18:56:54
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:用户管理(UserManage_GP)
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
using GP4WApi;

namespace GeneralPlatform4WApi
{
/// <summary>
/// 静态类
/// </summary>
public static class  clsvQxRolesByMenuNumWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRolesByMenuNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strRoleId">角色Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRolesByMenuNumEN SetRoleId(this clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN, string strRoleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRoleId, 8, convQxRolesByMenuNum.RoleId);
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, convQxRolesByMenuNum.RoleId);
objvQxRolesByMenuNumEN.RoleId = strRoleId; //角色Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRolesByMenuNumEN.dicFldComparisonOp.ContainsKey(convQxRolesByMenuNum.RoleId) == false)
{
objvQxRolesByMenuNumEN.dicFldComparisonOp.Add(convQxRolesByMenuNum.RoleId, strComparisonOp);
}
else
{
objvQxRolesByMenuNumEN.dicFldComparisonOp[convQxRolesByMenuNum.RoleId] = strComparisonOp;
}
}
return objvQxRolesByMenuNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRolesByMenuNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strRoleName">角色名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRolesByMenuNumEN SetRoleName(this clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN, string strRoleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRoleName, convQxRolesByMenuNum.RoleName);
clsCheckSql.CheckFieldLen(strRoleName, 50, convQxRolesByMenuNum.RoleName);
objvQxRolesByMenuNumEN.RoleName = strRoleName; //角色名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRolesByMenuNumEN.dicFldComparisonOp.ContainsKey(convQxRolesByMenuNum.RoleName) == false)
{
objvQxRolesByMenuNumEN.dicFldComparisonOp.Add(convQxRolesByMenuNum.RoleName, strComparisonOp);
}
else
{
objvQxRolesByMenuNumEN.dicFldComparisonOp[convQxRolesByMenuNum.RoleName] = strComparisonOp;
}
}
return objvQxRolesByMenuNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRolesByMenuNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strRoleENName">角色英文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRolesByMenuNumEN SetRoleENName(this clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN, string strRoleENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRoleENName, 50, convQxRolesByMenuNum.RoleENName);
objvQxRolesByMenuNumEN.RoleENName = strRoleENName; //角色英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRolesByMenuNumEN.dicFldComparisonOp.ContainsKey(convQxRolesByMenuNum.RoleENName) == false)
{
objvQxRolesByMenuNumEN.dicFldComparisonOp.Add(convQxRolesByMenuNum.RoleENName, strComparisonOp);
}
else
{
objvQxRolesByMenuNumEN.dicFldComparisonOp[convQxRolesByMenuNum.RoleENName] = strComparisonOp;
}
}
return objvQxRolesByMenuNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRolesByMenuNumEN">需要设置字段值的实体对象</param>
 /// <param name = "intRoleIndex">角色序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRolesByMenuNumEN SetRoleIndex(this clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN, int intRoleIndex, string strComparisonOp="")
	{
objvQxRolesByMenuNumEN.RoleIndex = intRoleIndex; //角色序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRolesByMenuNumEN.dicFldComparisonOp.ContainsKey(convQxRolesByMenuNum.RoleIndex) == false)
{
objvQxRolesByMenuNumEN.dicFldComparisonOp.Add(convQxRolesByMenuNum.RoleIndex, strComparisonOp);
}
else
{
objvQxRolesByMenuNumEN.dicFldComparisonOp[convQxRolesByMenuNum.RoleIndex] = strComparisonOp;
}
}
return objvQxRolesByMenuNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRolesByMenuNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strQxPrjId">项目Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRolesByMenuNumEN SetQxPrjId(this clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxRolesByMenuNum.QxPrjId);
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxRolesByMenuNum.QxPrjId);
objvQxRolesByMenuNumEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRolesByMenuNumEN.dicFldComparisonOp.ContainsKey(convQxRolesByMenuNum.QxPrjId) == false)
{
objvQxRolesByMenuNumEN.dicFldComparisonOp.Add(convQxRolesByMenuNum.QxPrjId, strComparisonOp);
}
else
{
objvQxRolesByMenuNumEN.dicFldComparisonOp[convQxRolesByMenuNum.QxPrjId] = strComparisonOp;
}
}
return objvQxRolesByMenuNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRolesByMenuNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRolesByMenuNumEN SetPrjName(this clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjName, 30, convQxRolesByMenuNum.PrjName);
objvQxRolesByMenuNumEN.PrjName = strPrjName; //工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRolesByMenuNumEN.dicFldComparisonOp.ContainsKey(convQxRolesByMenuNum.PrjName) == false)
{
objvQxRolesByMenuNumEN.dicFldComparisonOp.Add(convQxRolesByMenuNum.PrjName, strComparisonOp);
}
else
{
objvQxRolesByMenuNumEN.dicFldComparisonOp[convQxRolesByMenuNum.PrjName] = strComparisonOp;
}
}
return objvQxRolesByMenuNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRolesByMenuNumEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsInUse">是否在使用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRolesByMenuNumEN SetIsInUse(this clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN, bool bolIsInUse, string strComparisonOp="")
	{
objvQxRolesByMenuNumEN.IsInUse = bolIsInUse; //是否在使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRolesByMenuNumEN.dicFldComparisonOp.ContainsKey(convQxRolesByMenuNum.IsInUse) == false)
{
objvQxRolesByMenuNumEN.dicFldComparisonOp.Add(convQxRolesByMenuNum.IsInUse, strComparisonOp);
}
else
{
objvQxRolesByMenuNumEN.dicFldComparisonOp[convQxRolesByMenuNum.IsInUse] = strComparisonOp;
}
}
return objvQxRolesByMenuNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRolesByMenuNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRolesByMenuNumEN SetUpdDate(this clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQxRolesByMenuNum.UpdDate);
objvQxRolesByMenuNumEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRolesByMenuNumEN.dicFldComparisonOp.ContainsKey(convQxRolesByMenuNum.UpdDate) == false)
{
objvQxRolesByMenuNumEN.dicFldComparisonOp.Add(convQxRolesByMenuNum.UpdDate, strComparisonOp);
}
else
{
objvQxRolesByMenuNumEN.dicFldComparisonOp[convQxRolesByMenuNum.UpdDate] = strComparisonOp;
}
}
return objvQxRolesByMenuNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRolesByMenuNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRolesByMenuNumEN SetUpdUserId(this clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convQxRolesByMenuNum.UpdUserId);
objvQxRolesByMenuNumEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRolesByMenuNumEN.dicFldComparisonOp.ContainsKey(convQxRolesByMenuNum.UpdUserId) == false)
{
objvQxRolesByMenuNumEN.dicFldComparisonOp.Add(convQxRolesByMenuNum.UpdUserId, strComparisonOp);
}
else
{
objvQxRolesByMenuNumEN.dicFldComparisonOp[convQxRolesByMenuNum.UpdUserId] = strComparisonOp;
}
}
return objvQxRolesByMenuNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRolesByMenuNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">备注</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRolesByMenuNumEN SetMemo(this clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxRolesByMenuNum.Memo);
objvQxRolesByMenuNumEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRolesByMenuNumEN.dicFldComparisonOp.ContainsKey(convQxRolesByMenuNum.Memo) == false)
{
objvQxRolesByMenuNumEN.dicFldComparisonOp.Add(convQxRolesByMenuNum.Memo, strComparisonOp);
}
else
{
objvQxRolesByMenuNumEN.dicFldComparisonOp[convQxRolesByMenuNum.Memo] = strComparisonOp;
}
}
return objvQxRolesByMenuNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRolesByMenuNumEN">需要设置字段值的实体对象</param>
 /// <param name = "intMenuNum">MenuNum</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRolesByMenuNumEN SetMenuNum(this clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN, int intMenuNum, string strComparisonOp="")
	{
objvQxRolesByMenuNumEN.MenuNum = intMenuNum; //MenuNum
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRolesByMenuNumEN.dicFldComparisonOp.ContainsKey(convQxRolesByMenuNum.MenuNum) == false)
{
objvQxRolesByMenuNumEN.dicFldComparisonOp.Add(convQxRolesByMenuNum.MenuNum, strComparisonOp);
}
else
{
objvQxRolesByMenuNumEN.dicFldComparisonOp[convQxRolesByMenuNum.MenuNum] = strComparisonOp;
}
}
return objvQxRolesByMenuNumEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQxRolesByMenuNumEN objvQxRolesByMenuNumCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQxRolesByMenuNumCond.IsUpdated(convQxRolesByMenuNum.RoleId) == true)
{
string strComparisonOpRoleId = objvQxRolesByMenuNumCond.dicFldComparisonOp[convQxRolesByMenuNum.RoleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRolesByMenuNum.RoleId, objvQxRolesByMenuNumCond.RoleId, strComparisonOpRoleId);
}
if (objvQxRolesByMenuNumCond.IsUpdated(convQxRolesByMenuNum.RoleName) == true)
{
string strComparisonOpRoleName = objvQxRolesByMenuNumCond.dicFldComparisonOp[convQxRolesByMenuNum.RoleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRolesByMenuNum.RoleName, objvQxRolesByMenuNumCond.RoleName, strComparisonOpRoleName);
}
if (objvQxRolesByMenuNumCond.IsUpdated(convQxRolesByMenuNum.RoleENName) == true)
{
string strComparisonOpRoleENName = objvQxRolesByMenuNumCond.dicFldComparisonOp[convQxRolesByMenuNum.RoleENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRolesByMenuNum.RoleENName, objvQxRolesByMenuNumCond.RoleENName, strComparisonOpRoleENName);
}
if (objvQxRolesByMenuNumCond.IsUpdated(convQxRolesByMenuNum.RoleIndex) == true)
{
string strComparisonOpRoleIndex = objvQxRolesByMenuNumCond.dicFldComparisonOp[convQxRolesByMenuNum.RoleIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convQxRolesByMenuNum.RoleIndex, objvQxRolesByMenuNumCond.RoleIndex, strComparisonOpRoleIndex);
}
if (objvQxRolesByMenuNumCond.IsUpdated(convQxRolesByMenuNum.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objvQxRolesByMenuNumCond.dicFldComparisonOp[convQxRolesByMenuNum.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRolesByMenuNum.QxPrjId, objvQxRolesByMenuNumCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objvQxRolesByMenuNumCond.IsUpdated(convQxRolesByMenuNum.PrjName) == true)
{
string strComparisonOpPrjName = objvQxRolesByMenuNumCond.dicFldComparisonOp[convQxRolesByMenuNum.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRolesByMenuNum.PrjName, objvQxRolesByMenuNumCond.PrjName, strComparisonOpPrjName);
}
if (objvQxRolesByMenuNumCond.IsUpdated(convQxRolesByMenuNum.IsInUse) == true)
{
if (objvQxRolesByMenuNumCond.IsInUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQxRolesByMenuNum.IsInUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQxRolesByMenuNum.IsInUse);
}
}
if (objvQxRolesByMenuNumCond.IsUpdated(convQxRolesByMenuNum.UpdDate) == true)
{
string strComparisonOpUpdDate = objvQxRolesByMenuNumCond.dicFldComparisonOp[convQxRolesByMenuNum.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRolesByMenuNum.UpdDate, objvQxRolesByMenuNumCond.UpdDate, strComparisonOpUpdDate);
}
if (objvQxRolesByMenuNumCond.IsUpdated(convQxRolesByMenuNum.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvQxRolesByMenuNumCond.dicFldComparisonOp[convQxRolesByMenuNum.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRolesByMenuNum.UpdUserId, objvQxRolesByMenuNumCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvQxRolesByMenuNumCond.IsUpdated(convQxRolesByMenuNum.Memo) == true)
{
string strComparisonOpMemo = objvQxRolesByMenuNumCond.dicFldComparisonOp[convQxRolesByMenuNum.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRolesByMenuNum.Memo, objvQxRolesByMenuNumCond.Memo, strComparisonOpMemo);
}
if (objvQxRolesByMenuNumCond.IsUpdated(convQxRolesByMenuNum.MenuNum) == true)
{
string strComparisonOpMenuNum = objvQxRolesByMenuNumCond.dicFldComparisonOp[convQxRolesByMenuNum.MenuNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQxRolesByMenuNum.MenuNum, objvQxRolesByMenuNumCond.MenuNum, strComparisonOpMenuNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v角色By菜单数(vQxRolesByMenuNum)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxRolesByMenuNumWApi
{
private static readonly string mstrApiControllerName = "vQxRolesByMenuNumApi";

 public clsvQxRolesByMenuNumWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_RoleId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v角色By菜单数]...","0");
List<clsvQxRolesByMenuNumEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="RoleId";
objDDL.DataTextField="RoleName";
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

public static void BindCbo_RoleId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convQxRolesByMenuNum.RoleId); 
List<clsvQxRolesByMenuNumEN> arrObjLst = clsvQxRolesByMenuNumWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN = new clsvQxRolesByMenuNumEN()
{
RoleId = "0",
RoleName = "选[v角色By菜单数]..."
};
arrObjLst.Insert(0, objvQxRolesByMenuNumEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convQxRolesByMenuNum.RoleId;
objComboBox.DisplayMember = convQxRolesByMenuNum.RoleName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strRoleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxRolesByMenuNumEN GetObjByRoleId(string strRoleId)
{
string strAction = "GetObjByRoleId";
clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strRoleId"] = strRoleId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvQxRolesByMenuNumEN = JsonConvert.DeserializeObject<clsvQxRolesByMenuNumEN>(strJson);
return objvQxRolesByMenuNumEN;
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
public static clsvQxRolesByMenuNumEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN;
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
objvQxRolesByMenuNumEN = JsonConvert.DeserializeObject<clsvQxRolesByMenuNumEN>(strJson);
return objvQxRolesByMenuNumEN;
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
//该表没有使用Cache,不需要生成[GetRoleNameByRoleIdCache]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxRolesByMenuNumEN> GetObjLst(string strWhereCond)
{
 List<clsvQxRolesByMenuNumEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxRolesByMenuNumEN>>(strJson);
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
 /// <param name = "arrRoleId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxRolesByMenuNumEN> GetObjLstByRoleIdLst(List<string> arrRoleId)
{
 List<clsvQxRolesByMenuNumEN> arrObjLst; 
string strAction = "GetObjLstByRoleIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrRoleId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxRolesByMenuNumEN>>(strJson);
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
public static List<clsvQxRolesByMenuNumEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvQxRolesByMenuNumEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxRolesByMenuNumEN>>(strJson);
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
public static List<clsvQxRolesByMenuNumEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvQxRolesByMenuNumEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxRolesByMenuNumEN>>(strJson);
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
public static List<clsvQxRolesByMenuNumEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvQxRolesByMenuNumEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxRolesByMenuNumEN>>(strJson);
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
public static List<clsvQxRolesByMenuNumEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvQxRolesByMenuNumEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxRolesByMenuNumEN>>(strJson);
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
public static bool IsExist(string strRoleId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strRoleId"] = strRoleId
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
 /// <param name = "objvQxRolesByMenuNumENS">源对象</param>
 /// <param name = "objvQxRolesByMenuNumENT">目标对象</param>
 public static void CopyTo(clsvQxRolesByMenuNumEN objvQxRolesByMenuNumENS, clsvQxRolesByMenuNumEN objvQxRolesByMenuNumENT)
{
try
{
objvQxRolesByMenuNumENT.RoleId = objvQxRolesByMenuNumENS.RoleId; //角色Id
objvQxRolesByMenuNumENT.RoleName = objvQxRolesByMenuNumENS.RoleName; //角色名称
objvQxRolesByMenuNumENT.RoleENName = objvQxRolesByMenuNumENS.RoleENName; //角色英文名
objvQxRolesByMenuNumENT.RoleIndex = objvQxRolesByMenuNumENS.RoleIndex; //角色序号
objvQxRolesByMenuNumENT.QxPrjId = objvQxRolesByMenuNumENS.QxPrjId; //项目Id
objvQxRolesByMenuNumENT.PrjName = objvQxRolesByMenuNumENS.PrjName; //工程名
objvQxRolesByMenuNumENT.IsInUse = objvQxRolesByMenuNumENS.IsInUse; //是否在使用
objvQxRolesByMenuNumENT.UpdDate = objvQxRolesByMenuNumENS.UpdDate; //修改日期
objvQxRolesByMenuNumENT.UpdUserId = objvQxRolesByMenuNumENS.UpdUserId; //修改用户Id
objvQxRolesByMenuNumENT.Memo = objvQxRolesByMenuNumENS.Memo; //备注
objvQxRolesByMenuNumENT.MenuNum = objvQxRolesByMenuNumENS.MenuNum; //MenuNum
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
public static DataTable ToDataTable(List<clsvQxRolesByMenuNumEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvQxRolesByMenuNumEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvQxRolesByMenuNumEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvQxRolesByMenuNumEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvQxRolesByMenuNumEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvQxRolesByMenuNumEN.AttributeName)
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
string strKey = string.Format("{0}", clsvQxRolesByMenuNumEN._CurrTabName);
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
//该表没有使用Cache,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvQxRolesByMenuNumEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convQxRolesByMenuNum.RoleId, Type.GetType("System.String"));
objDT.Columns.Add(convQxRolesByMenuNum.RoleName, Type.GetType("System.String"));
objDT.Columns.Add(convQxRolesByMenuNum.RoleENName, Type.GetType("System.String"));
objDT.Columns.Add(convQxRolesByMenuNum.RoleIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(convQxRolesByMenuNum.QxPrjId, Type.GetType("System.String"));
objDT.Columns.Add(convQxRolesByMenuNum.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convQxRolesByMenuNum.IsInUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQxRolesByMenuNum.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convQxRolesByMenuNum.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convQxRolesByMenuNum.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convQxRolesByMenuNum.MenuNum, Type.GetType("System.Int32"));
foreach (clsvQxRolesByMenuNumEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convQxRolesByMenuNum.RoleId] = objInFor[convQxRolesByMenuNum.RoleId];
objDR[convQxRolesByMenuNum.RoleName] = objInFor[convQxRolesByMenuNum.RoleName];
objDR[convQxRolesByMenuNum.RoleENName] = objInFor[convQxRolesByMenuNum.RoleENName];
objDR[convQxRolesByMenuNum.RoleIndex] = objInFor[convQxRolesByMenuNum.RoleIndex];
objDR[convQxRolesByMenuNum.QxPrjId] = objInFor[convQxRolesByMenuNum.QxPrjId];
objDR[convQxRolesByMenuNum.PrjName] = objInFor[convQxRolesByMenuNum.PrjName];
objDR[convQxRolesByMenuNum.IsInUse] = objInFor[convQxRolesByMenuNum.IsInUse];
objDR[convQxRolesByMenuNum.UpdDate] = objInFor[convQxRolesByMenuNum.UpdDate];
objDR[convQxRolesByMenuNum.UpdUserId] = objInFor[convQxRolesByMenuNum.UpdUserId];
objDR[convQxRolesByMenuNum.Memo] = objInFor[convQxRolesByMenuNum.Memo];
objDR[convQxRolesByMenuNum.MenuNum] = objInFor[convQxRolesByMenuNum.MenuNum];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}