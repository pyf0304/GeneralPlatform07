
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFuncModuleWApi
 表名:vFuncModule(00140105)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 18:29:29
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:系统管理(SysManage)
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
public static class  clsvFuncModuleWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleId">模块Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncModuleEN SetFuncModuleId(this clsvFuncModuleEN objvFuncModuleEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convFuncModule.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convFuncModule.FuncModuleId);
objvFuncModuleEN.FuncModuleId = strFuncModuleId; //模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncModuleEN.dicFldComparisonOp.ContainsKey(convFuncModule.FuncModuleId) == false)
{
objvFuncModuleEN.dicFldComparisonOp.Add(convFuncModule.FuncModuleId, strComparisonOp);
}
else
{
objvFuncModuleEN.dicFldComparisonOp[convFuncModule.FuncModuleId] = strComparisonOp;
}
}
return objvFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleName">模块名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncModuleEN SetFuncModuleName(this clsvFuncModuleEN objvFuncModuleEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleName, convFuncModule.FuncModuleName);
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convFuncModule.FuncModuleName);
objvFuncModuleEN.FuncModuleName = strFuncModuleName; //模块名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncModuleEN.dicFldComparisonOp.ContainsKey(convFuncModule.FuncModuleName) == false)
{
objvFuncModuleEN.dicFldComparisonOp.Add(convFuncModule.FuncModuleName, strComparisonOp);
}
else
{
objvFuncModuleEN.dicFldComparisonOp[convFuncModule.FuncModuleName] = strComparisonOp;
}
}
return objvFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleNameSim">模块名_Sim</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncModuleEN SetFuncModuleNameSim(this clsvFuncModuleEN objvFuncModuleEN, string strFuncModuleNameSim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleNameSim, 30, convFuncModule.FuncModuleNameSim);
objvFuncModuleEN.FuncModuleNameSim = strFuncModuleNameSim; //模块名_Sim
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncModuleEN.dicFldComparisonOp.ContainsKey(convFuncModule.FuncModuleNameSim) == false)
{
objvFuncModuleEN.dicFldComparisonOp.Add(convFuncModule.FuncModuleNameSim, strComparisonOp);
}
else
{
objvFuncModuleEN.dicFldComparisonOp[convFuncModule.FuncModuleNameSim] = strComparisonOp;
}
}
return objvFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleEnName">模块英文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncModuleEN SetFuncModuleEnName(this clsvFuncModuleEN objvFuncModuleEN, string strFuncModuleEnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleEnName, 30, convFuncModule.FuncModuleEnName);
objvFuncModuleEN.FuncModuleEnName = strFuncModuleEnName; //模块英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncModuleEN.dicFldComparisonOp.ContainsKey(convFuncModule.FuncModuleEnName) == false)
{
objvFuncModuleEN.dicFldComparisonOp.Add(convFuncModule.FuncModuleEnName, strComparisonOp);
}
else
{
objvFuncModuleEN.dicFldComparisonOp[convFuncModule.FuncModuleEnName] = strComparisonOp;
}
}
return objvFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">排序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncModuleEN SetOrderNum(this clsvFuncModuleEN objvFuncModuleEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, convFuncModule.OrderNum);
objvFuncModuleEN.OrderNum = intOrderNum; //排序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncModuleEN.dicFldComparisonOp.ContainsKey(convFuncModule.OrderNum) == false)
{
objvFuncModuleEN.dicFldComparisonOp.Add(convFuncModule.OrderNum, strComparisonOp);
}
else
{
objvFuncModuleEN.dicFldComparisonOp[convFuncModule.OrderNum] = strComparisonOp;
}
}
return objvFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncModuleEN SetPrjId(this clsvFuncModuleEN objvFuncModuleEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjId, 4, convFuncModule.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convFuncModule.PrjId);
objvFuncModuleEN.PrjId = strPrjId; //工程ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncModuleEN.dicFldComparisonOp.ContainsKey(convFuncModule.PrjId) == false)
{
objvFuncModuleEN.dicFldComparisonOp.Add(convFuncModule.PrjId, strComparisonOp);
}
else
{
objvFuncModuleEN.dicFldComparisonOp[convFuncModule.PrjId] = strComparisonOp;
}
}
return objvFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strUseStateId">UseStateId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncModuleEN SetUseStateId(this clsvFuncModuleEN objvFuncModuleEN, string strUseStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUseStateId, convFuncModule.UseStateId);
clsCheckSql.CheckFieldLen(strUseStateId, 4, convFuncModule.UseStateId);
clsCheckSql.CheckFieldForeignKey(strUseStateId, 4, convFuncModule.UseStateId);
objvFuncModuleEN.UseStateId = strUseStateId; //UseStateId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncModuleEN.dicFldComparisonOp.ContainsKey(convFuncModule.UseStateId) == false)
{
objvFuncModuleEN.dicFldComparisonOp.Add(convFuncModule.UseStateId, strComparisonOp);
}
else
{
objvFuncModuleEN.dicFldComparisonOp[convFuncModule.UseStateId] = strComparisonOp;
}
}
return objvFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strUseStateName">使用状态名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncModuleEN SetUseStateName(this clsvFuncModuleEN objvFuncModuleEN, string strUseStateName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUseStateName, 30, convFuncModule.UseStateName);
objvFuncModuleEN.UseStateName = strUseStateName; //使用状态名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncModuleEN.dicFldComparisonOp.ContainsKey(convFuncModule.UseStateName) == false)
{
objvFuncModuleEN.dicFldComparisonOp.Add(convFuncModule.UseStateName, strComparisonOp);
}
else
{
objvFuncModuleEN.dicFldComparisonOp[convFuncModule.UseStateName] = strComparisonOp;
}
}
return objvFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncModuleEN SetUpdDate(this clsvFuncModuleEN objvFuncModuleEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFuncModule.UpdDate);
objvFuncModuleEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncModuleEN.dicFldComparisonOp.ContainsKey(convFuncModule.UpdDate) == false)
{
objvFuncModuleEN.dicFldComparisonOp.Add(convFuncModule.UpdDate, strComparisonOp);
}
else
{
objvFuncModuleEN.dicFldComparisonOp[convFuncModule.UpdDate] = strComparisonOp;
}
}
return objvFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改用户</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncModuleEN SetUpdUser(this clsvFuncModuleEN objvFuncModuleEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 18, convFuncModule.UpdUser);
objvFuncModuleEN.UpdUser = strUpdUser; //修改用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncModuleEN.dicFldComparisonOp.ContainsKey(convFuncModule.UpdUser) == false)
{
objvFuncModuleEN.dicFldComparisonOp.Add(convFuncModule.UpdUser, strComparisonOp);
}
else
{
objvFuncModuleEN.dicFldComparisonOp[convFuncModule.UpdUser] = strComparisonOp;
}
}
return objvFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">备注</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncModuleEN SetMemo(this clsvFuncModuleEN objvFuncModuleEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFuncModule.Memo);
objvFuncModuleEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncModuleEN.dicFldComparisonOp.ContainsKey(convFuncModule.Memo) == false)
{
objvFuncModuleEN.dicFldComparisonOp.Add(convFuncModule.Memo, strComparisonOp);
}
else
{
objvFuncModuleEN.dicFldComparisonOp[convFuncModule.Memo] = strComparisonOp;
}
}
return objvFuncModuleEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFuncModuleEN objvFuncModuleCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFuncModuleCond.IsUpdated(convFuncModule.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objvFuncModuleCond.dicFldComparisonOp[convFuncModule.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncModule.FuncModuleId, objvFuncModuleCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objvFuncModuleCond.IsUpdated(convFuncModule.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvFuncModuleCond.dicFldComparisonOp[convFuncModule.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncModule.FuncModuleName, objvFuncModuleCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvFuncModuleCond.IsUpdated(convFuncModule.FuncModuleNameSim) == true)
{
string strComparisonOpFuncModuleNameSim = objvFuncModuleCond.dicFldComparisonOp[convFuncModule.FuncModuleNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncModule.FuncModuleNameSim, objvFuncModuleCond.FuncModuleNameSim, strComparisonOpFuncModuleNameSim);
}
if (objvFuncModuleCond.IsUpdated(convFuncModule.FuncModuleEnName) == true)
{
string strComparisonOpFuncModuleEnName = objvFuncModuleCond.dicFldComparisonOp[convFuncModule.FuncModuleEnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncModule.FuncModuleEnName, objvFuncModuleCond.FuncModuleEnName, strComparisonOpFuncModuleEnName);
}
if (objvFuncModuleCond.IsUpdated(convFuncModule.OrderNum) == true)
{
string strComparisonOpOrderNum = objvFuncModuleCond.dicFldComparisonOp[convFuncModule.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convFuncModule.OrderNum, objvFuncModuleCond.OrderNum, strComparisonOpOrderNum);
}
if (objvFuncModuleCond.IsUpdated(convFuncModule.PrjId) == true)
{
string strComparisonOpPrjId = objvFuncModuleCond.dicFldComparisonOp[convFuncModule.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncModule.PrjId, objvFuncModuleCond.PrjId, strComparisonOpPrjId);
}
if (objvFuncModuleCond.IsUpdated(convFuncModule.UseStateId) == true)
{
string strComparisonOpUseStateId = objvFuncModuleCond.dicFldComparisonOp[convFuncModule.UseStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncModule.UseStateId, objvFuncModuleCond.UseStateId, strComparisonOpUseStateId);
}
if (objvFuncModuleCond.IsUpdated(convFuncModule.UseStateName) == true)
{
string strComparisonOpUseStateName = objvFuncModuleCond.dicFldComparisonOp[convFuncModule.UseStateName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncModule.UseStateName, objvFuncModuleCond.UseStateName, strComparisonOpUseStateName);
}
if (objvFuncModuleCond.IsUpdated(convFuncModule.UpdDate) == true)
{
string strComparisonOpUpdDate = objvFuncModuleCond.dicFldComparisonOp[convFuncModule.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncModule.UpdDate, objvFuncModuleCond.UpdDate, strComparisonOpUpdDate);
}
if (objvFuncModuleCond.IsUpdated(convFuncModule.UpdUser) == true)
{
string strComparisonOpUpdUser = objvFuncModuleCond.dicFldComparisonOp[convFuncModule.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncModule.UpdUser, objvFuncModuleCond.UpdUser, strComparisonOpUpdUser);
}
if (objvFuncModuleCond.IsUpdated(convFuncModule.Memo) == true)
{
string strComparisonOpMemo = objvFuncModuleCond.dicFldComparisonOp[convFuncModule.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncModule.Memo, objvFuncModuleCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v功能模块(vFuncModule)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvFuncModuleWApi
{
private static readonly string mstrApiControllerName = "vFuncModuleApi";

 public clsvFuncModuleWApi()
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
List<clsvFuncModuleEN> arrObjLst = GetObjLst("1=1");
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
string strCondition = string.Format("1 =1 Order By {0}", convFuncModule.FuncModuleId); 
List<clsvFuncModuleEN> arrObjLst = clsvFuncModuleWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvFuncModuleEN objvFuncModuleEN = new clsvFuncModuleEN()
{
FuncModuleId = "0",
FuncModuleName = "选[v功能模块]..."
};
arrObjLst.Insert(0, objvFuncModuleEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convFuncModule.FuncModuleId;
objComboBox.DisplayMember = convFuncModule.FuncModuleName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFuncModuleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFuncModuleEN GetObjByFuncModuleId(string strFuncModuleId)
{
string strAction = "GetObjByFuncModuleId";
clsvFuncModuleEN objvFuncModuleEN;
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
objvFuncModuleEN = JsonConvert.DeserializeObject<clsvFuncModuleEN>(strJson);
return objvFuncModuleEN;
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
public static clsvFuncModuleEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvFuncModuleEN objvFuncModuleEN;
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
objvFuncModuleEN = JsonConvert.DeserializeObject<clsvFuncModuleEN>(strJson);
return objvFuncModuleEN;
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
public static List<clsvFuncModuleEN> GetObjLst(string strWhereCond)
{
 List<clsvFuncModuleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFuncModuleEN>>(strJson);
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
public static List<clsvFuncModuleEN> GetObjLstByFuncModuleIdLst(List<string> arrFuncModuleId)
{
 List<clsvFuncModuleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFuncModuleEN>>(strJson);
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
public static List<clsvFuncModuleEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvFuncModuleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFuncModuleEN>>(strJson);
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
public static List<clsvFuncModuleEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvFuncModuleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFuncModuleEN>>(strJson);
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
public static List<clsvFuncModuleEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvFuncModuleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFuncModuleEN>>(strJson);
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
public static List<clsvFuncModuleEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvFuncModuleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFuncModuleEN>>(strJson);
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
 /// <param name = "objvFuncModuleENS">源对象</param>
 /// <param name = "objvFuncModuleENT">目标对象</param>
 public static void CopyTo(clsvFuncModuleEN objvFuncModuleENS, clsvFuncModuleEN objvFuncModuleENT)
{
try
{
objvFuncModuleENT.FuncModuleId = objvFuncModuleENS.FuncModuleId; //模块Id
objvFuncModuleENT.FuncModuleName = objvFuncModuleENS.FuncModuleName; //模块名
objvFuncModuleENT.FuncModuleNameSim = objvFuncModuleENS.FuncModuleNameSim; //模块名_Sim
objvFuncModuleENT.FuncModuleEnName = objvFuncModuleENS.FuncModuleEnName; //模块英文名
objvFuncModuleENT.OrderNum = objvFuncModuleENS.OrderNum; //排序号
objvFuncModuleENT.PrjId = objvFuncModuleENS.PrjId; //工程ID
objvFuncModuleENT.UseStateId = objvFuncModuleENS.UseStateId; //UseStateId
objvFuncModuleENT.UseStateName = objvFuncModuleENS.UseStateName; //使用状态名称
objvFuncModuleENT.UpdDate = objvFuncModuleENS.UpdDate; //修改日期
objvFuncModuleENT.UpdUser = objvFuncModuleENS.UpdUser; //修改用户
objvFuncModuleENT.Memo = objvFuncModuleENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvFuncModuleEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvFuncModuleEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvFuncModuleEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvFuncModuleEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvFuncModuleEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvFuncModuleEN.AttributeName)
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
string strKey = string.Format("{0}", clsvFuncModuleEN._CurrTabName);
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
public static DataTable GetDataTableByObjLst(List<clsvFuncModuleEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convFuncModule.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convFuncModule.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convFuncModule.FuncModuleNameSim, Type.GetType("System.String"));
objDT.Columns.Add(convFuncModule.FuncModuleEnName, Type.GetType("System.String"));
objDT.Columns.Add(convFuncModule.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convFuncModule.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convFuncModule.UseStateId, Type.GetType("System.String"));
objDT.Columns.Add(convFuncModule.UseStateName, Type.GetType("System.String"));
objDT.Columns.Add(convFuncModule.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convFuncModule.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convFuncModule.Memo, Type.GetType("System.String"));
foreach (clsvFuncModuleEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convFuncModule.FuncModuleId] = objInFor[convFuncModule.FuncModuleId];
objDR[convFuncModule.FuncModuleName] = objInFor[convFuncModule.FuncModuleName];
objDR[convFuncModule.FuncModuleNameSim] = objInFor[convFuncModule.FuncModuleNameSim];
objDR[convFuncModule.FuncModuleEnName] = objInFor[convFuncModule.FuncModuleEnName];
objDR[convFuncModule.OrderNum] = objInFor[convFuncModule.OrderNum];
objDR[convFuncModule.PrjId] = objInFor[convFuncModule.PrjId];
objDR[convFuncModule.UseStateId] = objInFor[convFuncModule.UseStateId];
objDR[convFuncModule.UseStateName] = objInFor[convFuncModule.UseStateName];
objDR[convFuncModule.UpdDate] = objInFor[convFuncModule.UpdDate];
objDR[convFuncModule.UpdUser] = objInFor[convFuncModule.UpdUser];
objDR[convFuncModule.Memo] = objInFor[convFuncModule.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}