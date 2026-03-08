
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxDepartmentInfoWApi
 表名:vQxDepartmentInfo(00140035)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 18:33:32
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

namespace GP4WApi
{
/// <summary>
/// 静态类
/// </summary>
public static class  clsvQxDepartmentInfoWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strDepartmentId">部门Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxDepartmentInfoEN SetDepartmentId(this clsvQxDepartmentInfoEN objvQxDepartmentInfoEN, string strDepartmentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDepartmentId, 8, convQxDepartmentInfo.DepartmentId);
objvQxDepartmentInfoEN.DepartmentId = strDepartmentId; //部门Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxDepartmentInfoEN.dicFldComparisonOp.ContainsKey(convQxDepartmentInfo.DepartmentId) == false)
{
objvQxDepartmentInfoEN.dicFldComparisonOp.Add(convQxDepartmentInfo.DepartmentId, strComparisonOp);
}
else
{
objvQxDepartmentInfoEN.dicFldComparisonOp[convQxDepartmentInfo.DepartmentId] = strComparisonOp;
}
}
return objvQxDepartmentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strDepartmentName">部门名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxDepartmentInfoEN SetDepartmentName(this clsvQxDepartmentInfoEN objvQxDepartmentInfoEN, string strDepartmentName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentName, convQxDepartmentInfo.DepartmentName);
clsCheckSql.CheckFieldLen(strDepartmentName, 100, convQxDepartmentInfo.DepartmentName);
objvQxDepartmentInfoEN.DepartmentName = strDepartmentName; //部门名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxDepartmentInfoEN.dicFldComparisonOp.ContainsKey(convQxDepartmentInfo.DepartmentName) == false)
{
objvQxDepartmentInfoEN.dicFldComparisonOp.Add(convQxDepartmentInfo.DepartmentName, strComparisonOp);
}
else
{
objvQxDepartmentInfoEN.dicFldComparisonOp[convQxDepartmentInfo.DepartmentName] = strComparisonOp;
}
}
return objvQxDepartmentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strDepartmentAbbrName">名称缩写</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxDepartmentInfoEN SetDepartmentAbbrName(this clsvQxDepartmentInfoEN objvQxDepartmentInfoEN, string strDepartmentAbbrName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDepartmentAbbrName, 8, convQxDepartmentInfo.DepartmentAbbrName);
objvQxDepartmentInfoEN.DepartmentAbbrName = strDepartmentAbbrName; //名称缩写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxDepartmentInfoEN.dicFldComparisonOp.ContainsKey(convQxDepartmentInfo.DepartmentAbbrName) == false)
{
objvQxDepartmentInfoEN.dicFldComparisonOp.Add(convQxDepartmentInfo.DepartmentAbbrName, strComparisonOp);
}
else
{
objvQxDepartmentInfoEN.dicFldComparisonOp[convQxDepartmentInfo.DepartmentAbbrName] = strComparisonOp;
}
}
return objvQxDepartmentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strDepartmentTypeId">部门类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxDepartmentInfoEN SetDepartmentTypeId(this clsvQxDepartmentInfoEN objvQxDepartmentInfoEN, string strDepartmentTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentTypeId, convQxDepartmentInfo.DepartmentTypeId);
clsCheckSql.CheckFieldLen(strDepartmentTypeId, 2, convQxDepartmentInfo.DepartmentTypeId);
clsCheckSql.CheckFieldForeignKey(strDepartmentTypeId, 2, convQxDepartmentInfo.DepartmentTypeId);
objvQxDepartmentInfoEN.DepartmentTypeId = strDepartmentTypeId; //部门类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxDepartmentInfoEN.dicFldComparisonOp.ContainsKey(convQxDepartmentInfo.DepartmentTypeId) == false)
{
objvQxDepartmentInfoEN.dicFldComparisonOp.Add(convQxDepartmentInfo.DepartmentTypeId, strComparisonOp);
}
else
{
objvQxDepartmentInfoEN.dicFldComparisonOp[convQxDepartmentInfo.DepartmentTypeId] = strComparisonOp;
}
}
return objvQxDepartmentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strDepartmentTypeName">部门类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxDepartmentInfoEN SetDepartmentTypeName(this clsvQxDepartmentInfoEN objvQxDepartmentInfoEN, string strDepartmentTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDepartmentTypeName, 50, convQxDepartmentInfo.DepartmentTypeName);
objvQxDepartmentInfoEN.DepartmentTypeName = strDepartmentTypeName; //部门类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxDepartmentInfoEN.dicFldComparisonOp.ContainsKey(convQxDepartmentInfo.DepartmentTypeName) == false)
{
objvQxDepartmentInfoEN.dicFldComparisonOp.Add(convQxDepartmentInfo.DepartmentTypeName, strComparisonOp);
}
else
{
objvQxDepartmentInfoEN.dicFldComparisonOp[convQxDepartmentInfo.DepartmentTypeName] = strComparisonOp;
}
}
return objvQxDepartmentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpDepartmentId">所属部门号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxDepartmentInfoEN SetUpDepartmentId(this clsvQxDepartmentInfoEN objvQxDepartmentInfoEN, string strUpDepartmentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpDepartmentId, 6, convQxDepartmentInfo.UpDepartmentId);
objvQxDepartmentInfoEN.UpDepartmentId = strUpDepartmentId; //所属部门号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxDepartmentInfoEN.dicFldComparisonOp.ContainsKey(convQxDepartmentInfo.UpDepartmentId) == false)
{
objvQxDepartmentInfoEN.dicFldComparisonOp.Add(convQxDepartmentInfo.UpDepartmentId, strComparisonOp);
}
else
{
objvQxDepartmentInfoEN.dicFldComparisonOp[convQxDepartmentInfo.UpDepartmentId] = strComparisonOp;
}
}
return objvQxDepartmentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">排序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxDepartmentInfoEN SetOrderNum(this clsvQxDepartmentInfoEN objvQxDepartmentInfoEN, int intOrderNum, string strComparisonOp="")
	{
objvQxDepartmentInfoEN.OrderNum = intOrderNum; //排序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxDepartmentInfoEN.dicFldComparisonOp.ContainsKey(convQxDepartmentInfo.OrderNum) == false)
{
objvQxDepartmentInfoEN.dicFldComparisonOp.Add(convQxDepartmentInfo.OrderNum, strComparisonOp);
}
else
{
objvQxDepartmentInfoEN.dicFldComparisonOp[convQxDepartmentInfo.OrderNum] = strComparisonOp;
}
}
return objvQxDepartmentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxDepartmentInfoEN SetInUse(this clsvQxDepartmentInfoEN objvQxDepartmentInfoEN, bool bolInUse, string strComparisonOp="")
	{
objvQxDepartmentInfoEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxDepartmentInfoEN.dicFldComparisonOp.ContainsKey(convQxDepartmentInfo.InUse) == false)
{
objvQxDepartmentInfoEN.dicFldComparisonOp.Add(convQxDepartmentInfo.InUse, strComparisonOp);
}
else
{
objvQxDepartmentInfoEN.dicFldComparisonOp[convQxDepartmentInfo.InUse] = strComparisonOp;
}
}
return objvQxDepartmentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">备注</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxDepartmentInfoEN SetMemo(this clsvQxDepartmentInfoEN objvQxDepartmentInfoEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxDepartmentInfo.Memo);
objvQxDepartmentInfoEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxDepartmentInfoEN.dicFldComparisonOp.ContainsKey(convQxDepartmentInfo.Memo) == false)
{
objvQxDepartmentInfoEN.dicFldComparisonOp.Add(convQxDepartmentInfo.Memo, strComparisonOp);
}
else
{
objvQxDepartmentInfoEN.dicFldComparisonOp[convQxDepartmentInfo.Memo] = strComparisonOp;
}
}
return objvQxDepartmentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "intUserNum">用户数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxDepartmentInfoEN SetUserNum(this clsvQxDepartmentInfoEN objvQxDepartmentInfoEN, int intUserNum, string strComparisonOp="")
	{
objvQxDepartmentInfoEN.UserNum = intUserNum; //用户数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxDepartmentInfoEN.dicFldComparisonOp.ContainsKey(convQxDepartmentInfo.UserNum) == false)
{
objvQxDepartmentInfoEN.dicFldComparisonOp.Add(convQxDepartmentInfo.UserNum, strComparisonOp);
}
else
{
objvQxDepartmentInfoEN.dicFldComparisonOp[convQxDepartmentInfo.UserNum] = strComparisonOp;
}
}
return objvQxDepartmentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpDepartmentName">上级部门</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxDepartmentInfoEN SetUpDepartmentName(this clsvQxDepartmentInfoEN objvQxDepartmentInfoEN, string strUpDepartmentName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpDepartmentName, 100, convQxDepartmentInfo.UpDepartmentName);
objvQxDepartmentInfoEN.UpDepartmentName = strUpDepartmentName; //上级部门
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxDepartmentInfoEN.dicFldComparisonOp.ContainsKey(convQxDepartmentInfo.UpDepartmentName) == false)
{
objvQxDepartmentInfoEN.dicFldComparisonOp.Add(convQxDepartmentInfo.UpDepartmentName, strComparisonOp);
}
else
{
objvQxDepartmentInfoEN.dicFldComparisonOp[convQxDepartmentInfo.UpDepartmentName] = strComparisonOp;
}
}
return objvQxDepartmentInfoEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQxDepartmentInfoEN objvQxDepartmentInfoCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQxDepartmentInfoCond.IsUpdated(convQxDepartmentInfo.DepartmentId) == true)
{
string strComparisonOpDepartmentId = objvQxDepartmentInfoCond.dicFldComparisonOp[convQxDepartmentInfo.DepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxDepartmentInfo.DepartmentId, objvQxDepartmentInfoCond.DepartmentId, strComparisonOpDepartmentId);
}
if (objvQxDepartmentInfoCond.IsUpdated(convQxDepartmentInfo.DepartmentName) == true)
{
string strComparisonOpDepartmentName = objvQxDepartmentInfoCond.dicFldComparisonOp[convQxDepartmentInfo.DepartmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxDepartmentInfo.DepartmentName, objvQxDepartmentInfoCond.DepartmentName, strComparisonOpDepartmentName);
}
if (objvQxDepartmentInfoCond.IsUpdated(convQxDepartmentInfo.DepartmentAbbrName) == true)
{
string strComparisonOpDepartmentAbbrName = objvQxDepartmentInfoCond.dicFldComparisonOp[convQxDepartmentInfo.DepartmentAbbrName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxDepartmentInfo.DepartmentAbbrName, objvQxDepartmentInfoCond.DepartmentAbbrName, strComparisonOpDepartmentAbbrName);
}
if (objvQxDepartmentInfoCond.IsUpdated(convQxDepartmentInfo.DepartmentTypeId) == true)
{
string strComparisonOpDepartmentTypeId = objvQxDepartmentInfoCond.dicFldComparisonOp[convQxDepartmentInfo.DepartmentTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxDepartmentInfo.DepartmentTypeId, objvQxDepartmentInfoCond.DepartmentTypeId, strComparisonOpDepartmentTypeId);
}
if (objvQxDepartmentInfoCond.IsUpdated(convQxDepartmentInfo.DepartmentTypeName) == true)
{
string strComparisonOpDepartmentTypeName = objvQxDepartmentInfoCond.dicFldComparisonOp[convQxDepartmentInfo.DepartmentTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxDepartmentInfo.DepartmentTypeName, objvQxDepartmentInfoCond.DepartmentTypeName, strComparisonOpDepartmentTypeName);
}
if (objvQxDepartmentInfoCond.IsUpdated(convQxDepartmentInfo.UpDepartmentId) == true)
{
string strComparisonOpUpDepartmentId = objvQxDepartmentInfoCond.dicFldComparisonOp[convQxDepartmentInfo.UpDepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxDepartmentInfo.UpDepartmentId, objvQxDepartmentInfoCond.UpDepartmentId, strComparisonOpUpDepartmentId);
}
if (objvQxDepartmentInfoCond.IsUpdated(convQxDepartmentInfo.OrderNum) == true)
{
string strComparisonOpOrderNum = objvQxDepartmentInfoCond.dicFldComparisonOp[convQxDepartmentInfo.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQxDepartmentInfo.OrderNum, objvQxDepartmentInfoCond.OrderNum, strComparisonOpOrderNum);
}
if (objvQxDepartmentInfoCond.IsUpdated(convQxDepartmentInfo.InUse) == true)
{
if (objvQxDepartmentInfoCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQxDepartmentInfo.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQxDepartmentInfo.InUse);
}
}
if (objvQxDepartmentInfoCond.IsUpdated(convQxDepartmentInfo.Memo) == true)
{
string strComparisonOpMemo = objvQxDepartmentInfoCond.dicFldComparisonOp[convQxDepartmentInfo.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxDepartmentInfo.Memo, objvQxDepartmentInfoCond.Memo, strComparisonOpMemo);
}
if (objvQxDepartmentInfoCond.IsUpdated(convQxDepartmentInfo.UserNum) == true)
{
string strComparisonOpUserNum = objvQxDepartmentInfoCond.dicFldComparisonOp[convQxDepartmentInfo.UserNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQxDepartmentInfo.UserNum, objvQxDepartmentInfoCond.UserNum, strComparisonOpUserNum);
}
if (objvQxDepartmentInfoCond.IsUpdated(convQxDepartmentInfo.UpDepartmentName) == true)
{
string strComparisonOpUpDepartmentName = objvQxDepartmentInfoCond.dicFldComparisonOp[convQxDepartmentInfo.UpDepartmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxDepartmentInfo.UpDepartmentName, objvQxDepartmentInfoCond.UpDepartmentName, strComparisonOpUpDepartmentName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v部门(vQxDepartmentInfo)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxDepartmentInfoWApi
{
private static readonly string mstrApiControllerName = "vQxDepartmentInfoApi";

 public clsvQxDepartmentInfoWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_DepartmentId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v部门]...","0");
List<clsvQxDepartmentInfoEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="DepartmentId";
objDDL.DataTextField="DepartmentName";
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

public static void BindCbo_DepartmentId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convQxDepartmentInfo.DepartmentId); 
List<clsvQxDepartmentInfoEN> arrObjLst = clsvQxDepartmentInfoWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvQxDepartmentInfoEN objvQxDepartmentInfoEN = new clsvQxDepartmentInfoEN()
{
DepartmentId = "0",
DepartmentName = "选[v部门]..."
};
arrObjLst.Insert(0, objvQxDepartmentInfoEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convQxDepartmentInfo.DepartmentId;
objComboBox.DisplayMember = convQxDepartmentInfo.DepartmentName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strDepartmentId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxDepartmentInfoEN GetObjByDepartmentId(string strDepartmentId)
{
string strAction = "GetObjByDepartmentId";
clsvQxDepartmentInfoEN objvQxDepartmentInfoEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strDepartmentId"] = strDepartmentId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvQxDepartmentInfoEN = JsonConvert.DeserializeObject<clsvQxDepartmentInfoEN>(strJson);
return objvQxDepartmentInfoEN;
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
public static clsvQxDepartmentInfoEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvQxDepartmentInfoEN objvQxDepartmentInfoEN;
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
objvQxDepartmentInfoEN = JsonConvert.DeserializeObject<clsvQxDepartmentInfoEN>(strJson);
return objvQxDepartmentInfoEN;
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
//该表没有使用Cache,不需要生成[GetDepartmentNameByDepartmentIdCache]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxDepartmentInfoEN> GetObjLst(string strWhereCond)
{
 List<clsvQxDepartmentInfoEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxDepartmentInfoEN>>(strJson);
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
 /// <param name = "arrDepartmentId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxDepartmentInfoEN> GetObjLstByDepartmentIdLst(List<string> arrDepartmentId)
{
 List<clsvQxDepartmentInfoEN> arrObjLst; 
string strAction = "GetObjLstByDepartmentIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrDepartmentId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxDepartmentInfoEN>>(strJson);
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
public static List<clsvQxDepartmentInfoEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvQxDepartmentInfoEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxDepartmentInfoEN>>(strJson);
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
public static List<clsvQxDepartmentInfoEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvQxDepartmentInfoEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxDepartmentInfoEN>>(strJson);
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
public static List<clsvQxDepartmentInfoEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvQxDepartmentInfoEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxDepartmentInfoEN>>(strJson);
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
public static List<clsvQxDepartmentInfoEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvQxDepartmentInfoEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxDepartmentInfoEN>>(strJson);
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
public static bool IsExist(string strDepartmentId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strDepartmentId"] = strDepartmentId
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
 /// <param name = "objvQxDepartmentInfoENS">源对象</param>
 /// <param name = "objvQxDepartmentInfoENT">目标对象</param>
 public static void CopyTo(clsvQxDepartmentInfoEN objvQxDepartmentInfoENS, clsvQxDepartmentInfoEN objvQxDepartmentInfoENT)
{
try
{
objvQxDepartmentInfoENT.DepartmentId = objvQxDepartmentInfoENS.DepartmentId; //部门Id
objvQxDepartmentInfoENT.DepartmentName = objvQxDepartmentInfoENS.DepartmentName; //部门名
objvQxDepartmentInfoENT.DepartmentAbbrName = objvQxDepartmentInfoENS.DepartmentAbbrName; //名称缩写
objvQxDepartmentInfoENT.DepartmentTypeId = objvQxDepartmentInfoENS.DepartmentTypeId; //部门类型ID
objvQxDepartmentInfoENT.DepartmentTypeName = objvQxDepartmentInfoENS.DepartmentTypeName; //部门类型名
objvQxDepartmentInfoENT.UpDepartmentId = objvQxDepartmentInfoENS.UpDepartmentId; //所属部门号
objvQxDepartmentInfoENT.OrderNum = objvQxDepartmentInfoENS.OrderNum; //排序号
objvQxDepartmentInfoENT.InUse = objvQxDepartmentInfoENS.InUse; //是否在用
objvQxDepartmentInfoENT.Memo = objvQxDepartmentInfoENS.Memo; //备注
objvQxDepartmentInfoENT.UserNum = objvQxDepartmentInfoENS.UserNum; //用户数
objvQxDepartmentInfoENT.UpDepartmentName = objvQxDepartmentInfoENS.UpDepartmentName; //上级部门
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
public static DataTable ToDataTable(List<clsvQxDepartmentInfoEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvQxDepartmentInfoEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvQxDepartmentInfoEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvQxDepartmentInfoEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvQxDepartmentInfoEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvQxDepartmentInfoEN.AttributeName)
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
string strKey = string.Format("{0}", clsvQxDepartmentInfoEN._CurrTabName);
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
public static DataTable GetDataTableByObjLst(List<clsvQxDepartmentInfoEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convQxDepartmentInfo.DepartmentId, Type.GetType("System.String"));
objDT.Columns.Add(convQxDepartmentInfo.DepartmentName, Type.GetType("System.String"));
objDT.Columns.Add(convQxDepartmentInfo.DepartmentAbbrName, Type.GetType("System.String"));
objDT.Columns.Add(convQxDepartmentInfo.DepartmentTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convQxDepartmentInfo.DepartmentTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convQxDepartmentInfo.UpDepartmentId, Type.GetType("System.String"));
objDT.Columns.Add(convQxDepartmentInfo.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convQxDepartmentInfo.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQxDepartmentInfo.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convQxDepartmentInfo.UserNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convQxDepartmentInfo.UpDepartmentName, Type.GetType("System.String"));
foreach (clsvQxDepartmentInfoEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convQxDepartmentInfo.DepartmentId] = objInFor[convQxDepartmentInfo.DepartmentId];
objDR[convQxDepartmentInfo.DepartmentName] = objInFor[convQxDepartmentInfo.DepartmentName];
objDR[convQxDepartmentInfo.DepartmentAbbrName] = objInFor[convQxDepartmentInfo.DepartmentAbbrName];
objDR[convQxDepartmentInfo.DepartmentTypeId] = objInFor[convQxDepartmentInfo.DepartmentTypeId];
objDR[convQxDepartmentInfo.DepartmentTypeName] = objInFor[convQxDepartmentInfo.DepartmentTypeName];
objDR[convQxDepartmentInfo.UpDepartmentId] = objInFor[convQxDepartmentInfo.UpDepartmentId];
objDR[convQxDepartmentInfo.OrderNum] = objInFor[convQxDepartmentInfo.OrderNum];
objDR[convQxDepartmentInfo.InUse] = objInFor[convQxDepartmentInfo.InUse];
objDR[convQxDepartmentInfo.Memo] = objInFor[convQxDepartmentInfo.Memo];
objDR[convQxDepartmentInfo.UserNum] = objInFor[convQxDepartmentInfo.UserNum];
objDR[convQxDepartmentInfo.UpDepartmentName] = objInFor[convQxDepartmentInfo.UpDepartmentName];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}