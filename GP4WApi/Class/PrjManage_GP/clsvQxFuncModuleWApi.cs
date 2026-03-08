
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxFuncModuleWApi
 表名:vQxFuncModule(00140087)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 18:31:05
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
public static class  clsvQxFuncModuleWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleId">模块Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxFuncModuleEN SetFuncModuleId(this clsvQxFuncModuleEN objvQxFuncModuleEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convQxFuncModule.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convQxFuncModule.FuncModuleId);
objvQxFuncModuleEN.FuncModuleId = strFuncModuleId; //模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxFuncModuleEN.dicFldComparisonOp.ContainsKey(convQxFuncModule.FuncModuleId) == false)
{
objvQxFuncModuleEN.dicFldComparisonOp.Add(convQxFuncModule.FuncModuleId, strComparisonOp);
}
else
{
objvQxFuncModuleEN.dicFldComparisonOp[convQxFuncModule.FuncModuleId] = strComparisonOp;
}
}
return objvQxFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleName">模块名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxFuncModuleEN SetFuncModuleName(this clsvQxFuncModuleEN objvQxFuncModuleEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convQxFuncModule.FuncModuleName);
objvQxFuncModuleEN.FuncModuleName = strFuncModuleName; //模块名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxFuncModuleEN.dicFldComparisonOp.ContainsKey(convQxFuncModule.FuncModuleName) == false)
{
objvQxFuncModuleEN.dicFldComparisonOp.Add(convQxFuncModule.FuncModuleName, strComparisonOp);
}
else
{
objvQxFuncModuleEN.dicFldComparisonOp[convQxFuncModule.FuncModuleName] = strComparisonOp;
}
}
return objvQxFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleNameSim">模块名_Sim</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxFuncModuleEN SetFuncModuleNameSim(this clsvQxFuncModuleEN objvQxFuncModuleEN, string strFuncModuleNameSim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleNameSim, 30, convQxFuncModule.FuncModuleNameSim);
objvQxFuncModuleEN.FuncModuleNameSim = strFuncModuleNameSim; //模块名_Sim
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxFuncModuleEN.dicFldComparisonOp.ContainsKey(convQxFuncModule.FuncModuleNameSim) == false)
{
objvQxFuncModuleEN.dicFldComparisonOp.Add(convQxFuncModule.FuncModuleNameSim, strComparisonOp);
}
else
{
objvQxFuncModuleEN.dicFldComparisonOp[convQxFuncModule.FuncModuleNameSim] = strComparisonOp;
}
}
return objvQxFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleEnName">模块英文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxFuncModuleEN SetFuncModuleEnName(this clsvQxFuncModuleEN objvQxFuncModuleEN, string strFuncModuleEnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleEnName, 30, convQxFuncModule.FuncModuleEnName);
objvQxFuncModuleEN.FuncModuleEnName = strFuncModuleEnName; //模块英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxFuncModuleEN.dicFldComparisonOp.ContainsKey(convQxFuncModule.FuncModuleEnName) == false)
{
objvQxFuncModuleEN.dicFldComparisonOp.Add(convQxFuncModule.FuncModuleEnName, strComparisonOp);
}
else
{
objvQxFuncModuleEN.dicFldComparisonOp[convQxFuncModule.FuncModuleEnName] = strComparisonOp;
}
}
return objvQxFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">排序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxFuncModuleEN SetOrderNum(this clsvQxFuncModuleEN objvQxFuncModuleEN, int intOrderNum, string strComparisonOp="")
	{
objvQxFuncModuleEN.OrderNum = intOrderNum; //排序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxFuncModuleEN.dicFldComparisonOp.ContainsKey(convQxFuncModule.OrderNum) == false)
{
objvQxFuncModuleEN.dicFldComparisonOp.Add(convQxFuncModule.OrderNum, strComparisonOp);
}
else
{
objvQxFuncModuleEN.dicFldComparisonOp[convQxFuncModule.OrderNum] = strComparisonOp;
}
}
return objvQxFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strQxPrjId">项目Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxFuncModuleEN SetQxPrjId(this clsvQxFuncModuleEN objvQxFuncModuleEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, convQxFuncModule.QxPrjId);
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxFuncModule.QxPrjId);
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxFuncModule.QxPrjId);
objvQxFuncModuleEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxFuncModuleEN.dicFldComparisonOp.ContainsKey(convQxFuncModule.QxPrjId) == false)
{
objvQxFuncModuleEN.dicFldComparisonOp.Add(convQxFuncModule.QxPrjId, strComparisonOp);
}
else
{
objvQxFuncModuleEN.dicFldComparisonOp[convQxFuncModule.QxPrjId] = strComparisonOp;
}
}
return objvQxFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxFuncModuleEN SetPrjName(this clsvQxFuncModuleEN objvQxFuncModuleEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convQxFuncModule.PrjName);
clsCheckSql.CheckFieldLen(strPrjName, 30, convQxFuncModule.PrjName);
objvQxFuncModuleEN.PrjName = strPrjName; //工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxFuncModuleEN.dicFldComparisonOp.ContainsKey(convQxFuncModule.PrjName) == false)
{
objvQxFuncModuleEN.dicFldComparisonOp.Add(convQxFuncModule.PrjName, strComparisonOp);
}
else
{
objvQxFuncModuleEN.dicFldComparisonOp[convQxFuncModule.PrjName] = strComparisonOp;
}
}
return objvQxFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxFuncModuleEN SetInUse(this clsvQxFuncModuleEN objvQxFuncModuleEN, bool bolInUse, string strComparisonOp="")
	{
objvQxFuncModuleEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxFuncModuleEN.dicFldComparisonOp.ContainsKey(convQxFuncModule.InUse) == false)
{
objvQxFuncModuleEN.dicFldComparisonOp.Add(convQxFuncModule.InUse, strComparisonOp);
}
else
{
objvQxFuncModuleEN.dicFldComparisonOp[convQxFuncModule.InUse] = strComparisonOp;
}
}
return objvQxFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxFuncModuleEN SetUpdDate(this clsvQxFuncModuleEN objvQxFuncModuleEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convQxFuncModule.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQxFuncModule.UpdDate);
objvQxFuncModuleEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxFuncModuleEN.dicFldComparisonOp.ContainsKey(convQxFuncModule.UpdDate) == false)
{
objvQxFuncModuleEN.dicFldComparisonOp.Add(convQxFuncModule.UpdDate, strComparisonOp);
}
else
{
objvQxFuncModuleEN.dicFldComparisonOp[convQxFuncModule.UpdDate] = strComparisonOp;
}
}
return objvQxFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改用户</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxFuncModuleEN SetUpdUser(this clsvQxFuncModuleEN objvQxFuncModuleEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 18, convQxFuncModule.UpdUser);
objvQxFuncModuleEN.UpdUser = strUpdUser; //修改用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxFuncModuleEN.dicFldComparisonOp.ContainsKey(convQxFuncModule.UpdUser) == false)
{
objvQxFuncModuleEN.dicFldComparisonOp.Add(convQxFuncModule.UpdUser, strComparisonOp);
}
else
{
objvQxFuncModuleEN.dicFldComparisonOp[convQxFuncModule.UpdUser] = strComparisonOp;
}
}
return objvQxFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">备注</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxFuncModuleEN SetMemo(this clsvQxFuncModuleEN objvQxFuncModuleEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxFuncModule.Memo);
objvQxFuncModuleEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxFuncModuleEN.dicFldComparisonOp.ContainsKey(convQxFuncModule.Memo) == false)
{
objvQxFuncModuleEN.dicFldComparisonOp.Add(convQxFuncModule.Memo, strComparisonOp);
}
else
{
objvQxFuncModuleEN.dicFldComparisonOp[convQxFuncModule.Memo] = strComparisonOp;
}
}
return objvQxFuncModuleEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQxFuncModuleEN objvQxFuncModuleCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQxFuncModuleCond.IsUpdated(convQxFuncModule.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objvQxFuncModuleCond.dicFldComparisonOp[convQxFuncModule.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxFuncModule.FuncModuleId, objvQxFuncModuleCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objvQxFuncModuleCond.IsUpdated(convQxFuncModule.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvQxFuncModuleCond.dicFldComparisonOp[convQxFuncModule.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxFuncModule.FuncModuleName, objvQxFuncModuleCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvQxFuncModuleCond.IsUpdated(convQxFuncModule.FuncModuleNameSim) == true)
{
string strComparisonOpFuncModuleNameSim = objvQxFuncModuleCond.dicFldComparisonOp[convQxFuncModule.FuncModuleNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxFuncModule.FuncModuleNameSim, objvQxFuncModuleCond.FuncModuleNameSim, strComparisonOpFuncModuleNameSim);
}
if (objvQxFuncModuleCond.IsUpdated(convQxFuncModule.FuncModuleEnName) == true)
{
string strComparisonOpFuncModuleEnName = objvQxFuncModuleCond.dicFldComparisonOp[convQxFuncModule.FuncModuleEnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxFuncModule.FuncModuleEnName, objvQxFuncModuleCond.FuncModuleEnName, strComparisonOpFuncModuleEnName);
}
if (objvQxFuncModuleCond.IsUpdated(convQxFuncModule.OrderNum) == true)
{
string strComparisonOpOrderNum = objvQxFuncModuleCond.dicFldComparisonOp[convQxFuncModule.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQxFuncModule.OrderNum, objvQxFuncModuleCond.OrderNum, strComparisonOpOrderNum);
}
if (objvQxFuncModuleCond.IsUpdated(convQxFuncModule.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objvQxFuncModuleCond.dicFldComparisonOp[convQxFuncModule.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxFuncModule.QxPrjId, objvQxFuncModuleCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objvQxFuncModuleCond.IsUpdated(convQxFuncModule.PrjName) == true)
{
string strComparisonOpPrjName = objvQxFuncModuleCond.dicFldComparisonOp[convQxFuncModule.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxFuncModule.PrjName, objvQxFuncModuleCond.PrjName, strComparisonOpPrjName);
}
if (objvQxFuncModuleCond.IsUpdated(convQxFuncModule.InUse) == true)
{
if (objvQxFuncModuleCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQxFuncModule.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQxFuncModule.InUse);
}
}
if (objvQxFuncModuleCond.IsUpdated(convQxFuncModule.UpdDate) == true)
{
string strComparisonOpUpdDate = objvQxFuncModuleCond.dicFldComparisonOp[convQxFuncModule.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxFuncModule.UpdDate, objvQxFuncModuleCond.UpdDate, strComparisonOpUpdDate);
}
if (objvQxFuncModuleCond.IsUpdated(convQxFuncModule.UpdUser) == true)
{
string strComparisonOpUpdUser = objvQxFuncModuleCond.dicFldComparisonOp[convQxFuncModule.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxFuncModule.UpdUser, objvQxFuncModuleCond.UpdUser, strComparisonOpUpdUser);
}
if (objvQxFuncModuleCond.IsUpdated(convQxFuncModule.Memo) == true)
{
string strComparisonOpMemo = objvQxFuncModuleCond.dicFldComparisonOp[convQxFuncModule.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxFuncModule.Memo, objvQxFuncModuleCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v功能模块(vQxFuncModule)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxFuncModuleWApi
{
private static readonly string mstrApiControllerName = "vQxFuncModuleApi";

 public clsvQxFuncModuleWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_FuncModuleId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v功能模块]...","0");
List<clsvQxFuncModuleEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="FuncModuleId";
objDDL.DataTextField="FuncModuleName";
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

public static void BindCbo_FuncModuleId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convQxFuncModule.FuncModuleId); 
List<clsvQxFuncModuleEN> arrObjLst = clsvQxFuncModuleWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvQxFuncModuleEN objvQxFuncModuleEN = new clsvQxFuncModuleEN()
{
FuncModuleId = "0",
FuncModuleName = "选[v功能模块]..."
};
arrObjLst.Insert(0, objvQxFuncModuleEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convQxFuncModule.FuncModuleId;
objComboBox.DisplayMember = convQxFuncModule.FuncModuleName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFuncModuleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxFuncModuleEN GetObjByFuncModuleId(string strFuncModuleId)
{
string strAction = "GetObjByFuncModuleId";
clsvQxFuncModuleEN objvQxFuncModuleEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFuncModuleId"] = strFuncModuleId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvQxFuncModuleEN = JsonConvert.DeserializeObject<clsvQxFuncModuleEN>(strJson);
return objvQxFuncModuleEN;
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
public static clsvQxFuncModuleEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvQxFuncModuleEN objvQxFuncModuleEN;
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
objvQxFuncModuleEN = JsonConvert.DeserializeObject<clsvQxFuncModuleEN>(strJson);
return objvQxFuncModuleEN;
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
//该表没有使用Cache,不需要生成[GetFuncModuleNameByFuncModuleIdCache]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxFuncModuleEN> GetObjLst(string strWhereCond)
{
 List<clsvQxFuncModuleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxFuncModuleEN>>(strJson);
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
 /// <param name = "arrFuncModuleId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxFuncModuleEN> GetObjLstByFuncModuleIdLst(List<string> arrFuncModuleId)
{
 List<clsvQxFuncModuleEN> arrObjLst; 
string strAction = "GetObjLstByFuncModuleIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrFuncModuleId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxFuncModuleEN>>(strJson);
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
public static List<clsvQxFuncModuleEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvQxFuncModuleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxFuncModuleEN>>(strJson);
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
public static List<clsvQxFuncModuleEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvQxFuncModuleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxFuncModuleEN>>(strJson);
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
public static List<clsvQxFuncModuleEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvQxFuncModuleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxFuncModuleEN>>(strJson);
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
public static List<clsvQxFuncModuleEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvQxFuncModuleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxFuncModuleEN>>(strJson);
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
public static bool IsExist(string strFuncModuleId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFuncModuleId"] = strFuncModuleId
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
 /// <param name = "objvQxFuncModuleENS">源对象</param>
 /// <param name = "objvQxFuncModuleENT">目标对象</param>
 public static void CopyTo(clsvQxFuncModuleEN objvQxFuncModuleENS, clsvQxFuncModuleEN objvQxFuncModuleENT)
{
try
{
objvQxFuncModuleENT.FuncModuleId = objvQxFuncModuleENS.FuncModuleId; //模块Id
objvQxFuncModuleENT.FuncModuleName = objvQxFuncModuleENS.FuncModuleName; //模块名
objvQxFuncModuleENT.FuncModuleNameSim = objvQxFuncModuleENS.FuncModuleNameSim; //模块名_Sim
objvQxFuncModuleENT.FuncModuleEnName = objvQxFuncModuleENS.FuncModuleEnName; //模块英文名
objvQxFuncModuleENT.OrderNum = objvQxFuncModuleENS.OrderNum; //排序号
objvQxFuncModuleENT.QxPrjId = objvQxFuncModuleENS.QxPrjId; //项目Id
objvQxFuncModuleENT.PrjName = objvQxFuncModuleENS.PrjName; //工程名
objvQxFuncModuleENT.InUse = objvQxFuncModuleENS.InUse; //是否在用
objvQxFuncModuleENT.UpdDate = objvQxFuncModuleENS.UpdDate; //修改日期
objvQxFuncModuleENT.UpdUser = objvQxFuncModuleENS.UpdUser; //修改用户
objvQxFuncModuleENT.Memo = objvQxFuncModuleENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvQxFuncModuleEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvQxFuncModuleEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvQxFuncModuleEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvQxFuncModuleEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvQxFuncModuleEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvQxFuncModuleEN.AttributeName)
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
string strKey = string.Format("{0}", clsvQxFuncModuleEN._CurrTabName);
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
public static DataTable GetDataTableByObjLst(List<clsvQxFuncModuleEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convQxFuncModule.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convQxFuncModule.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convQxFuncModule.FuncModuleNameSim, Type.GetType("System.String"));
objDT.Columns.Add(convQxFuncModule.FuncModuleEnName, Type.GetType("System.String"));
objDT.Columns.Add(convQxFuncModule.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convQxFuncModule.QxPrjId, Type.GetType("System.String"));
objDT.Columns.Add(convQxFuncModule.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convQxFuncModule.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQxFuncModule.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convQxFuncModule.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convQxFuncModule.Memo, Type.GetType("System.String"));
foreach (clsvQxFuncModuleEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convQxFuncModule.FuncModuleId] = objInFor[convQxFuncModule.FuncModuleId];
objDR[convQxFuncModule.FuncModuleName] = objInFor[convQxFuncModule.FuncModuleName];
objDR[convQxFuncModule.FuncModuleNameSim] = objInFor[convQxFuncModule.FuncModuleNameSim];
objDR[convQxFuncModule.FuncModuleEnName] = objInFor[convQxFuncModule.FuncModuleEnName];
objDR[convQxFuncModule.OrderNum] = objInFor[convQxFuncModule.OrderNum];
objDR[convQxFuncModule.QxPrjId] = objInFor[convQxFuncModule.QxPrjId];
objDR[convQxFuncModule.PrjName] = objInFor[convQxFuncModule.PrjName];
objDR[convQxFuncModule.InUse] = objInFor[convQxFuncModule.InUse];
objDR[convQxFuncModule.UpdDate] = objInFor[convQxFuncModule.UpdDate];
objDR[convQxFuncModule.UpdUser] = objInFor[convQxFuncModule.UpdUser];
objDR[convQxFuncModule.Memo] = objInFor[convQxFuncModule.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}