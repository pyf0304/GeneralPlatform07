
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPrjMenuSetBL
 表名:vQxPrjMenuSet(00140072)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:34:26
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:菜单管理(MenuManage_GP)
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
public static class  clsvQxPrjMenuSetBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strMenuSetId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxPrjMenuSetEN GetObj(this K_MenuSetId_vQxPrjMenuSet myKey)
{
clsvQxPrjMenuSetEN objvQxPrjMenuSetEN = clsvQxPrjMenuSetBL.vQxPrjMenuSetDA.GetObjByMenuSetId(myKey.Value);
return objvQxPrjMenuSetEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenuSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenuSetEN SetMenuSetId(this clsvQxPrjMenuSetEN objvQxPrjMenuSetEN, string strMenuSetId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuSetId, 4, convQxPrjMenuSet.MenuSetId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMenuSetId, 4, convQxPrjMenuSet.MenuSetId);
}
objvQxPrjMenuSetEN.MenuSetId = strMenuSetId; //菜单集Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenuSetEN.dicFldComparisonOp.ContainsKey(convQxPrjMenuSet.MenuSetId) == false)
{
objvQxPrjMenuSetEN.dicFldComparisonOp.Add(convQxPrjMenuSet.MenuSetId, strComparisonOp);
}
else
{
objvQxPrjMenuSetEN.dicFldComparisonOp[convQxPrjMenuSet.MenuSetId] = strComparisonOp;
}
}
return objvQxPrjMenuSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenuSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenuSetEN SetMenuSetName(this clsvQxPrjMenuSetEN objvQxPrjMenuSetEN, string strMenuSetName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuSetName, 50, convQxPrjMenuSet.MenuSetName);
}
objvQxPrjMenuSetEN.MenuSetName = strMenuSetName; //菜单集名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenuSetEN.dicFldComparisonOp.ContainsKey(convQxPrjMenuSet.MenuSetName) == false)
{
objvQxPrjMenuSetEN.dicFldComparisonOp.Add(convQxPrjMenuSet.MenuSetName, strComparisonOp);
}
else
{
objvQxPrjMenuSetEN.dicFldComparisonOp[convQxPrjMenuSet.MenuSetName] = strComparisonOp;
}
}
return objvQxPrjMenuSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenuSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenuSetEN SetQxPrjId(this clsvQxPrjMenuSetEN objvQxPrjMenuSetEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, convQxPrjMenuSet.QxPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxPrjMenuSet.QxPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxPrjMenuSet.QxPrjId);
}
objvQxPrjMenuSetEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenuSetEN.dicFldComparisonOp.ContainsKey(convQxPrjMenuSet.QxPrjId) == false)
{
objvQxPrjMenuSetEN.dicFldComparisonOp.Add(convQxPrjMenuSet.QxPrjId, strComparisonOp);
}
else
{
objvQxPrjMenuSetEN.dicFldComparisonOp[convQxPrjMenuSet.QxPrjId] = strComparisonOp;
}
}
return objvQxPrjMenuSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenuSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenuSetEN SetPrjName(this clsvQxPrjMenuSetEN objvQxPrjMenuSetEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convQxPrjMenuSet.PrjName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convQxPrjMenuSet.PrjName);
}
objvQxPrjMenuSetEN.PrjName = strPrjName; //工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenuSetEN.dicFldComparisonOp.ContainsKey(convQxPrjMenuSet.PrjName) == false)
{
objvQxPrjMenuSetEN.dicFldComparisonOp.Add(convQxPrjMenuSet.PrjName, strComparisonOp);
}
else
{
objvQxPrjMenuSetEN.dicFldComparisonOp[convQxPrjMenuSet.PrjName] = strComparisonOp;
}
}
return objvQxPrjMenuSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenuSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenuSetEN SetIsDefault(this clsvQxPrjMenuSetEN objvQxPrjMenuSetEN, bool bolIsDefault, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsDefault, convQxPrjMenuSet.IsDefault);
objvQxPrjMenuSetEN.IsDefault = bolIsDefault; //是否默认
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenuSetEN.dicFldComparisonOp.ContainsKey(convQxPrjMenuSet.IsDefault) == false)
{
objvQxPrjMenuSetEN.dicFldComparisonOp.Add(convQxPrjMenuSet.IsDefault, strComparisonOp);
}
else
{
objvQxPrjMenuSetEN.dicFldComparisonOp[convQxPrjMenuSet.IsDefault] = strComparisonOp;
}
}
return objvQxPrjMenuSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjMenuSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjMenuSetEN SetMemo(this clsvQxPrjMenuSetEN objvQxPrjMenuSetEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxPrjMenuSet.Memo);
}
objvQxPrjMenuSetEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjMenuSetEN.dicFldComparisonOp.ContainsKey(convQxPrjMenuSet.Memo) == false)
{
objvQxPrjMenuSetEN.dicFldComparisonOp.Add(convQxPrjMenuSet.Memo, strComparisonOp);
}
else
{
objvQxPrjMenuSetEN.dicFldComparisonOp[convQxPrjMenuSet.Memo] = strComparisonOp;
}
}
return objvQxPrjMenuSetEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvQxPrjMenuSetENS">源对象</param>
 /// <param name = "objvQxPrjMenuSetENT">目标对象</param>
 public static void CopyTo(this clsvQxPrjMenuSetEN objvQxPrjMenuSetENS, clsvQxPrjMenuSetEN objvQxPrjMenuSetENT)
{
try
{
objvQxPrjMenuSetENT.MenuSetId = objvQxPrjMenuSetENS.MenuSetId; //菜单集Id
objvQxPrjMenuSetENT.MenuSetName = objvQxPrjMenuSetENS.MenuSetName; //菜单集名称
objvQxPrjMenuSetENT.QxPrjId = objvQxPrjMenuSetENS.QxPrjId; //项目Id
objvQxPrjMenuSetENT.PrjName = objvQxPrjMenuSetENS.PrjName; //工程名
objvQxPrjMenuSetENT.IsDefault = objvQxPrjMenuSetENS.IsDefault; //是否默认
objvQxPrjMenuSetENT.Memo = objvQxPrjMenuSetENS.Memo; //备注
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
 /// <param name = "objvQxPrjMenuSetENS">源对象</param>
 /// <returns>目标对象=>clsvQxPrjMenuSetEN:objvQxPrjMenuSetENT</returns>
 public static clsvQxPrjMenuSetEN CopyTo(this clsvQxPrjMenuSetEN objvQxPrjMenuSetENS)
{
try
{
 clsvQxPrjMenuSetEN objvQxPrjMenuSetENT = new clsvQxPrjMenuSetEN()
{
MenuSetId = objvQxPrjMenuSetENS.MenuSetId, //菜单集Id
MenuSetName = objvQxPrjMenuSetENS.MenuSetName, //菜单集名称
QxPrjId = objvQxPrjMenuSetENS.QxPrjId, //项目Id
PrjName = objvQxPrjMenuSetENS.PrjName, //工程名
IsDefault = objvQxPrjMenuSetENS.IsDefault, //是否默认
Memo = objvQxPrjMenuSetENS.Memo, //备注
};
 return objvQxPrjMenuSetENT;
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
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsvQxPrjMenuSetEN objvQxPrjMenuSetEN)
{
 clsvQxPrjMenuSetBL.vQxPrjMenuSetDA.CheckProperty4Condition(objvQxPrjMenuSetEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQxPrjMenuSetEN objvQxPrjMenuSetCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQxPrjMenuSetCond.IsUpdated(convQxPrjMenuSet.MenuSetId) == true)
{
string strComparisonOpMenuSetId = objvQxPrjMenuSetCond.dicFldComparisonOp[convQxPrjMenuSet.MenuSetId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenuSet.MenuSetId, objvQxPrjMenuSetCond.MenuSetId, strComparisonOpMenuSetId);
}
if (objvQxPrjMenuSetCond.IsUpdated(convQxPrjMenuSet.MenuSetName) == true)
{
string strComparisonOpMenuSetName = objvQxPrjMenuSetCond.dicFldComparisonOp[convQxPrjMenuSet.MenuSetName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenuSet.MenuSetName, objvQxPrjMenuSetCond.MenuSetName, strComparisonOpMenuSetName);
}
if (objvQxPrjMenuSetCond.IsUpdated(convQxPrjMenuSet.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objvQxPrjMenuSetCond.dicFldComparisonOp[convQxPrjMenuSet.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenuSet.QxPrjId, objvQxPrjMenuSetCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objvQxPrjMenuSetCond.IsUpdated(convQxPrjMenuSet.PrjName) == true)
{
string strComparisonOpPrjName = objvQxPrjMenuSetCond.dicFldComparisonOp[convQxPrjMenuSet.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenuSet.PrjName, objvQxPrjMenuSetCond.PrjName, strComparisonOpPrjName);
}
if (objvQxPrjMenuSetCond.IsUpdated(convQxPrjMenuSet.IsDefault) == true)
{
if (objvQxPrjMenuSetCond.IsDefault == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQxPrjMenuSet.IsDefault);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQxPrjMenuSet.IsDefault);
}
}
if (objvQxPrjMenuSetCond.IsUpdated(convQxPrjMenuSet.Memo) == true)
{
string strComparisonOpMemo = objvQxPrjMenuSetCond.dicFldComparisonOp[convQxPrjMenuSet.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjMenuSet.Memo, objvQxPrjMenuSetCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vQxPrjMenuSet
{
public virtual bool UpdRelaTabDate(string strMenuSetId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v菜单集(vQxPrjMenuSet)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvQxPrjMenuSetBL
{
public static RelatedActions_vQxPrjMenuSet relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "vQxPrjMenuSetListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "vQxPrjMenuSetList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsvQxPrjMenuSetEN> arrvQxPrjMenuSetObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvQxPrjMenuSetDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvQxPrjMenuSetDA vQxPrjMenuSetDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvQxPrjMenuSetDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvQxPrjMenuSetBL()
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
if (string.IsNullOrEmpty(clsvQxPrjMenuSetEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxPrjMenuSetEN._ConnectString);
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
objDS = vQxPrjMenuSetDA.GetDataSet(strWhereCond);
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
objDS = vQxPrjMenuSetDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = vQxPrjMenuSetDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_vQxPrjMenuSet(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQxPrjMenuSetDA.GetDataTable_vQxPrjMenuSet(strWhereCond);
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
objDT = vQxPrjMenuSetDA.GetDataTable(strWhereCond);
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
objDT = vQxPrjMenuSetDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vQxPrjMenuSetDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vQxPrjMenuSetDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vQxPrjMenuSetDA.GetDataTable_Top(objTopPara);
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
objDT = vQxPrjMenuSetDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vQxPrjMenuSetDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = vQxPrjMenuSetDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vQxPrjMenuSetDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = vQxPrjMenuSetDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = vQxPrjMenuSetDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = vQxPrjMenuSetDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = vQxPrjMenuSetDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
 /// <param name = "arrMenuSetIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvQxPrjMenuSetEN> GetObjLstByMenuSetIdLst(List<string> arrMenuSetIdLst)
{
List<clsvQxPrjMenuSetEN> arrObjLst = new List<clsvQxPrjMenuSetEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMenuSetIdLst, true);
 string strWhereCond = string.Format("MenuSetId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenuSetEN objvQxPrjMenuSetEN = new clsvQxPrjMenuSetEN();
try
{
objvQxPrjMenuSetEN.MenuSetId = objRow[convQxPrjMenuSet.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenuSetEN.MenuSetName = objRow[convQxPrjMenuSet.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenuSet.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenuSetEN.QxPrjId = objRow[convQxPrjMenuSet.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenuSetEN.PrjName = objRow[convQxPrjMenuSet.PrjName].ToString().Trim(); //工程名
objvQxPrjMenuSetEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenuSet.IsDefault].ToString().Trim()); //是否默认
objvQxPrjMenuSetEN.Memo = objRow[convQxPrjMenuSet.Memo] == DBNull.Value ? null : objRow[convQxPrjMenuSet.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenuSetEN.MenuSetId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenuSetEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMenuSetIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvQxPrjMenuSetEN> GetObjLstByMenuSetIdLstCache(List<string> arrMenuSetIdLst)
{
string strKey = string.Format("{0}", clsvQxPrjMenuSetEN._CurrTabName);
List<clsvQxPrjMenuSetEN> arrvQxPrjMenuSetObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjMenuSetEN> arrvQxPrjMenuSetObjLst_Sel =
arrvQxPrjMenuSetObjLstCache
.Where(x => arrMenuSetIdLst.Contains(x.MenuSetId));
return arrvQxPrjMenuSetObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjMenuSetEN> GetObjLst(string strWhereCond)
{
List<clsvQxPrjMenuSetEN> arrObjLst = new List<clsvQxPrjMenuSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenuSetEN objvQxPrjMenuSetEN = new clsvQxPrjMenuSetEN();
try
{
objvQxPrjMenuSetEN.MenuSetId = objRow[convQxPrjMenuSet.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenuSetEN.MenuSetName = objRow[convQxPrjMenuSet.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenuSet.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenuSetEN.QxPrjId = objRow[convQxPrjMenuSet.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenuSetEN.PrjName = objRow[convQxPrjMenuSet.PrjName].ToString().Trim(); //工程名
objvQxPrjMenuSetEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenuSet.IsDefault].ToString().Trim()); //是否默认
objvQxPrjMenuSetEN.Memo = objRow[convQxPrjMenuSet.Memo] == DBNull.Value ? null : objRow[convQxPrjMenuSet.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenuSetEN.MenuSetId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenuSetEN);
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
public static List<clsvQxPrjMenuSetEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQxPrjMenuSetEN> arrObjLst = new List<clsvQxPrjMenuSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenuSetEN objvQxPrjMenuSetEN = new clsvQxPrjMenuSetEN();
try
{
objvQxPrjMenuSetEN.MenuSetId = objRow[convQxPrjMenuSet.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenuSetEN.MenuSetName = objRow[convQxPrjMenuSet.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenuSet.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenuSetEN.QxPrjId = objRow[convQxPrjMenuSet.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenuSetEN.PrjName = objRow[convQxPrjMenuSet.PrjName].ToString().Trim(); //工程名
objvQxPrjMenuSetEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenuSet.IsDefault].ToString().Trim()); //是否默认
objvQxPrjMenuSetEN.Memo = objRow[convQxPrjMenuSet.Memo] == DBNull.Value ? null : objRow[convQxPrjMenuSet.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenuSetEN.MenuSetId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenuSetEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvQxPrjMenuSetCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvQxPrjMenuSetEN> GetSubObjLstCache(clsvQxPrjMenuSetEN objvQxPrjMenuSetCond)
{
List<clsvQxPrjMenuSetEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjMenuSetEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxPrjMenuSet.AttributeName)
{
if (objvQxPrjMenuSetCond.IsUpdated(strFldName) == false) continue;
if (objvQxPrjMenuSetCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjMenuSetCond[strFldName].ToString());
}
else
{
if (objvQxPrjMenuSetCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxPrjMenuSetCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjMenuSetCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxPrjMenuSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxPrjMenuSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxPrjMenuSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxPrjMenuSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxPrjMenuSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxPrjMenuSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxPrjMenuSetCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxPrjMenuSetCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxPrjMenuSetCond[strFldName]));
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
public static List<clsvQxPrjMenuSetEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvQxPrjMenuSetEN> arrObjLst = new List<clsvQxPrjMenuSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenuSetEN objvQxPrjMenuSetEN = new clsvQxPrjMenuSetEN();
try
{
objvQxPrjMenuSetEN.MenuSetId = objRow[convQxPrjMenuSet.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenuSetEN.MenuSetName = objRow[convQxPrjMenuSet.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenuSet.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenuSetEN.QxPrjId = objRow[convQxPrjMenuSet.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenuSetEN.PrjName = objRow[convQxPrjMenuSet.PrjName].ToString().Trim(); //工程名
objvQxPrjMenuSetEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenuSet.IsDefault].ToString().Trim()); //是否默认
objvQxPrjMenuSetEN.Memo = objRow[convQxPrjMenuSet.Memo] == DBNull.Value ? null : objRow[convQxPrjMenuSet.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenuSetEN.MenuSetId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenuSetEN);
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
public static List<clsvQxPrjMenuSetEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvQxPrjMenuSetEN> arrObjLst = new List<clsvQxPrjMenuSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenuSetEN objvQxPrjMenuSetEN = new clsvQxPrjMenuSetEN();
try
{
objvQxPrjMenuSetEN.MenuSetId = objRow[convQxPrjMenuSet.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenuSetEN.MenuSetName = objRow[convQxPrjMenuSet.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenuSet.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenuSetEN.QxPrjId = objRow[convQxPrjMenuSet.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenuSetEN.PrjName = objRow[convQxPrjMenuSet.PrjName].ToString().Trim(); //工程名
objvQxPrjMenuSetEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenuSet.IsDefault].ToString().Trim()); //是否默认
objvQxPrjMenuSetEN.Memo = objRow[convQxPrjMenuSet.Memo] == DBNull.Value ? null : objRow[convQxPrjMenuSet.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenuSetEN.MenuSetId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenuSetEN);
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
List<clsvQxPrjMenuSetEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvQxPrjMenuSetEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjMenuSetEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvQxPrjMenuSetEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvQxPrjMenuSetEN> arrObjLst = new List<clsvQxPrjMenuSetEN>(); 
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
	clsvQxPrjMenuSetEN objvQxPrjMenuSetEN = new clsvQxPrjMenuSetEN();
try
{
objvQxPrjMenuSetEN.MenuSetId = objRow[convQxPrjMenuSet.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenuSetEN.MenuSetName = objRow[convQxPrjMenuSet.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenuSet.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenuSetEN.QxPrjId = objRow[convQxPrjMenuSet.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenuSetEN.PrjName = objRow[convQxPrjMenuSet.PrjName].ToString().Trim(); //工程名
objvQxPrjMenuSetEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenuSet.IsDefault].ToString().Trim()); //是否默认
objvQxPrjMenuSetEN.Memo = objRow[convQxPrjMenuSet.Memo] == DBNull.Value ? null : objRow[convQxPrjMenuSet.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenuSetEN.MenuSetId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenuSetEN);
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
public static List<clsvQxPrjMenuSetEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvQxPrjMenuSetEN> arrObjLst = new List<clsvQxPrjMenuSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenuSetEN objvQxPrjMenuSetEN = new clsvQxPrjMenuSetEN();
try
{
objvQxPrjMenuSetEN.MenuSetId = objRow[convQxPrjMenuSet.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenuSetEN.MenuSetName = objRow[convQxPrjMenuSet.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenuSet.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenuSetEN.QxPrjId = objRow[convQxPrjMenuSet.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenuSetEN.PrjName = objRow[convQxPrjMenuSet.PrjName].ToString().Trim(); //工程名
objvQxPrjMenuSetEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenuSet.IsDefault].ToString().Trim()); //是否默认
objvQxPrjMenuSetEN.Memo = objRow[convQxPrjMenuSet.Memo] == DBNull.Value ? null : objRow[convQxPrjMenuSet.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenuSetEN.MenuSetId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenuSetEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQxPrjMenuSetEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvQxPrjMenuSetEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvQxPrjMenuSetEN> arrObjLst = new List<clsvQxPrjMenuSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenuSetEN objvQxPrjMenuSetEN = new clsvQxPrjMenuSetEN();
try
{
objvQxPrjMenuSetEN.MenuSetId = objRow[convQxPrjMenuSet.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenuSetEN.MenuSetName = objRow[convQxPrjMenuSet.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenuSet.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenuSetEN.QxPrjId = objRow[convQxPrjMenuSet.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenuSetEN.PrjName = objRow[convQxPrjMenuSet.PrjName].ToString().Trim(); //工程名
objvQxPrjMenuSetEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenuSet.IsDefault].ToString().Trim()); //是否默认
objvQxPrjMenuSetEN.Memo = objRow[convQxPrjMenuSet.Memo] == DBNull.Value ? null : objRow[convQxPrjMenuSet.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenuSetEN.MenuSetId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenuSetEN);
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
public static List<clsvQxPrjMenuSetEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvQxPrjMenuSetEN> arrObjLst = new List<clsvQxPrjMenuSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenuSetEN objvQxPrjMenuSetEN = new clsvQxPrjMenuSetEN();
try
{
objvQxPrjMenuSetEN.MenuSetId = objRow[convQxPrjMenuSet.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenuSetEN.MenuSetName = objRow[convQxPrjMenuSet.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenuSet.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenuSetEN.QxPrjId = objRow[convQxPrjMenuSet.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenuSetEN.PrjName = objRow[convQxPrjMenuSet.PrjName].ToString().Trim(); //工程名
objvQxPrjMenuSetEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenuSet.IsDefault].ToString().Trim()); //是否默认
objvQxPrjMenuSetEN.Memo = objRow[convQxPrjMenuSet.Memo] == DBNull.Value ? null : objRow[convQxPrjMenuSet.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenuSetEN.MenuSetId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenuSetEN);
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
public static IEnumerable<clsvQxPrjMenuSetEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsvQxPrjMenuSetEN objvQxPrjMenuSetCond, string strOrderBy)
{
List<clsvQxPrjMenuSetEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjMenuSetEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxPrjMenuSet.AttributeName)
{
if (objvQxPrjMenuSetCond.IsUpdated(strFldName) == false) continue;
if (objvQxPrjMenuSetCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjMenuSetCond[strFldName].ToString());
}
else
{
if (objvQxPrjMenuSetCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxPrjMenuSetCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjMenuSetCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxPrjMenuSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxPrjMenuSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxPrjMenuSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxPrjMenuSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxPrjMenuSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxPrjMenuSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxPrjMenuSetCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxPrjMenuSetCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxPrjMenuSetCond[strFldName]));
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
public static IEnumerable<clsvQxPrjMenuSetEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsvQxPrjMenuSetEN objvQxPrjMenuSetCond = JsonConvert.DeserializeObject<clsvQxPrjMenuSetEN>(objPagerPara.whereCond);
if (objvQxPrjMenuSetCond.sfFldComparisonOp == null)
{
objvQxPrjMenuSetCond.dicFldComparisonOp = null;
}
else
{
objvQxPrjMenuSetCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objvQxPrjMenuSetCond.sfFldComparisonOp);
}
clsvQxPrjMenuSetBL.SetUpdFlag(objvQxPrjMenuSetCond);
 try
{
CheckProperty4Condition(objvQxPrjMenuSetCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsvQxPrjMenuSetBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objvQxPrjMenuSetCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjMenuSetEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsvQxPrjMenuSetEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxPrjMenuSetEN> arrObjLst = new List<clsvQxPrjMenuSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenuSetEN objvQxPrjMenuSetEN = new clsvQxPrjMenuSetEN();
try
{
objvQxPrjMenuSetEN.MenuSetId = objRow[convQxPrjMenuSet.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenuSetEN.MenuSetName = objRow[convQxPrjMenuSet.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenuSet.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenuSetEN.QxPrjId = objRow[convQxPrjMenuSet.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenuSetEN.PrjName = objRow[convQxPrjMenuSet.PrjName].ToString().Trim(); //工程名
objvQxPrjMenuSetEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenuSet.IsDefault].ToString().Trim()); //是否默认
objvQxPrjMenuSetEN.Memo = objRow[convQxPrjMenuSet.Memo] == DBNull.Value ? null : objRow[convQxPrjMenuSet.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenuSetEN.MenuSetId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenuSetEN);
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
public static List<clsvQxPrjMenuSetEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxPrjMenuSetEN> arrObjLst = new List<clsvQxPrjMenuSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenuSetEN objvQxPrjMenuSetEN = new clsvQxPrjMenuSetEN();
try
{
objvQxPrjMenuSetEN.MenuSetId = objRow[convQxPrjMenuSet.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenuSetEN.MenuSetName = objRow[convQxPrjMenuSet.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenuSet.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenuSetEN.QxPrjId = objRow[convQxPrjMenuSet.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenuSetEN.PrjName = objRow[convQxPrjMenuSet.PrjName].ToString().Trim(); //工程名
objvQxPrjMenuSetEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenuSet.IsDefault].ToString().Trim()); //是否默认
objvQxPrjMenuSetEN.Memo = objRow[convQxPrjMenuSet.Memo] == DBNull.Value ? null : objRow[convQxPrjMenuSet.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenuSetEN.MenuSetId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenuSetEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjMenuSetEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvQxPrjMenuSetEN> arrObjLst = new List<clsvQxPrjMenuSetEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenuSetEN objvQxPrjMenuSetEN = new clsvQxPrjMenuSetEN();
try
{
objvQxPrjMenuSetEN.MenuSetId = objRow[convQxPrjMenuSet.MenuSetId].ToString().Trim(); //菜单集Id
objvQxPrjMenuSetEN.MenuSetName = objRow[convQxPrjMenuSet.MenuSetName] == DBNull.Value ? null : objRow[convQxPrjMenuSet.MenuSetName].ToString().Trim(); //菜单集名称
objvQxPrjMenuSetEN.QxPrjId = objRow[convQxPrjMenuSet.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjMenuSetEN.PrjName = objRow[convQxPrjMenuSet.PrjName].ToString().Trim(); //工程名
objvQxPrjMenuSetEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjMenuSet.IsDefault].ToString().Trim()); //是否默认
objvQxPrjMenuSetEN.Memo = objRow[convQxPrjMenuSet.Memo] == DBNull.Value ? null : objRow[convQxPrjMenuSet.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjMenuSetEN.MenuSetId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjMenuSetEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvQxPrjMenuSetEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxPrjMenuSet(ref clsvQxPrjMenuSetEN objvQxPrjMenuSetEN)
{
bool bolResult = vQxPrjMenuSetDA.GetvQxPrjMenuSet(ref objvQxPrjMenuSetEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strMenuSetId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxPrjMenuSetEN GetObjByMenuSetId(string strMenuSetId)
{
if (strMenuSetId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strMenuSetId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strMenuSetId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strMenuSetId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvQxPrjMenuSetEN objvQxPrjMenuSetEN = vQxPrjMenuSetDA.GetObjByMenuSetId(strMenuSetId);
return objvQxPrjMenuSetEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvQxPrjMenuSetEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvQxPrjMenuSetEN objvQxPrjMenuSetEN = vQxPrjMenuSetDA.GetFirstObj(strWhereCond);
 return objvQxPrjMenuSetEN;
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
public static clsvQxPrjMenuSetEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvQxPrjMenuSetEN objvQxPrjMenuSetEN = vQxPrjMenuSetDA.GetObjByDataRow(objRow);
 return objvQxPrjMenuSetEN;
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
public static clsvQxPrjMenuSetEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvQxPrjMenuSetEN objvQxPrjMenuSetEN = vQxPrjMenuSetDA.GetObjByDataRow(objRow);
 return objvQxPrjMenuSetEN;
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
 /// <param name = "strMenuSetId">所给的关键字</param>
 /// <param name = "lstvQxPrjMenuSetObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxPrjMenuSetEN GetObjByMenuSetIdFromList(string strMenuSetId, List<clsvQxPrjMenuSetEN> lstvQxPrjMenuSetObjLst)
{
foreach (clsvQxPrjMenuSetEN objvQxPrjMenuSetEN in lstvQxPrjMenuSetObjLst)
{
if (objvQxPrjMenuSetEN.MenuSetId == strMenuSetId)
{
return objvQxPrjMenuSetEN;
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
 string strMenuSetId;
 try
 {
 strMenuSetId = new clsvQxPrjMenuSetDA().GetFirstID(strWhereCond);
 return strMenuSetId;
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
 arrList = vQxPrjMenuSetDA.GetID(strWhereCond);
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
bool bolIsExist = vQxPrjMenuSetDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strMenuSetId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strMenuSetId)
{
if (string.IsNullOrEmpty(strMenuSetId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strMenuSetId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vQxPrjMenuSetDA.IsExist(strMenuSetId);
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
 bolIsExist = clsvQxPrjMenuSetDA.IsExistTable();
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
 bolIsExist = vQxPrjMenuSetDA.IsExistTable(strTabName);
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


 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CopyObj_S)
 /// </summary>
 /// <param name = "objvQxPrjMenuSetENS">源对象</param>
 /// <param name = "objvQxPrjMenuSetENT">目标对象</param>
 public static void CopyTo(clsvQxPrjMenuSetEN objvQxPrjMenuSetENS, clsvQxPrjMenuSetEN objvQxPrjMenuSetENT)
{
try
{
objvQxPrjMenuSetENT.MenuSetId = objvQxPrjMenuSetENS.MenuSetId; //菜单集Id
objvQxPrjMenuSetENT.MenuSetName = objvQxPrjMenuSetENS.MenuSetName; //菜单集名称
objvQxPrjMenuSetENT.QxPrjId = objvQxPrjMenuSetENS.QxPrjId; //项目Id
objvQxPrjMenuSetENT.PrjName = objvQxPrjMenuSetENS.PrjName; //工程名
objvQxPrjMenuSetENT.IsDefault = objvQxPrjMenuSetENS.IsDefault; //是否默认
objvQxPrjMenuSetENT.Memo = objvQxPrjMenuSetENS.Memo; //备注
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
 /// <param name = "objvQxPrjMenuSetEN">源简化对象</param>
 public static void SetUpdFlag(clsvQxPrjMenuSetEN objvQxPrjMenuSetEN)
{
try
{
objvQxPrjMenuSetEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvQxPrjMenuSetEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convQxPrjMenuSet.MenuSetId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenuSetEN.MenuSetId = objvQxPrjMenuSetEN.MenuSetId; //菜单集Id
}
if (arrFldSet.Contains(convQxPrjMenuSet.MenuSetName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenuSetEN.MenuSetName = objvQxPrjMenuSetEN.MenuSetName == "[null]" ? null :  objvQxPrjMenuSetEN.MenuSetName; //菜单集名称
}
if (arrFldSet.Contains(convQxPrjMenuSet.QxPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenuSetEN.QxPrjId = objvQxPrjMenuSetEN.QxPrjId; //项目Id
}
if (arrFldSet.Contains(convQxPrjMenuSet.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenuSetEN.PrjName = objvQxPrjMenuSetEN.PrjName; //工程名
}
if (arrFldSet.Contains(convQxPrjMenuSet.IsDefault, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenuSetEN.IsDefault = objvQxPrjMenuSetEN.IsDefault; //是否默认
}
if (arrFldSet.Contains(convQxPrjMenuSet.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjMenuSetEN.Memo = objvQxPrjMenuSetEN.Memo == "[null]" ? null :  objvQxPrjMenuSetEN.Memo; //备注
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
 /// <param name = "objvQxPrjMenuSetEN">源简化对象</param>
 public static void AccessFldValueNull(clsvQxPrjMenuSetEN objvQxPrjMenuSetEN)
{
try
{
if (objvQxPrjMenuSetEN.MenuSetName == "[null]") objvQxPrjMenuSetEN.MenuSetName = null; //菜单集名称
if (objvQxPrjMenuSetEN.Memo == "[null]") objvQxPrjMenuSetEN.Memo = null; //备注
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
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsvQxPrjMenuSetEN objvQxPrjMenuSetEN)
{
 vQxPrjMenuSetDA.CheckProperty4Condition(objvQxPrjMenuSetEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_MenuSetId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convQxPrjMenuSet.MenuSetId); 
List<clsvQxPrjMenuSetEN> arrObjLst = clsvQxPrjMenuSetBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvQxPrjMenuSetEN objvQxPrjMenuSetEN = new clsvQxPrjMenuSetEN()
{
MenuSetId = "0",
MenuSetName = "选[v菜单集]..."
};
arrObjLst.Insert(0, objvQxPrjMenuSetEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convQxPrjMenuSet.MenuSetId;
objComboBox.DisplayMember = convQxPrjMenuSet.MenuSetName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_MenuSetId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v菜单集]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convQxPrjMenuSet.MenuSetId); 
IEnumerable<clsvQxPrjMenuSetEN> arrObjLst = clsvQxPrjMenuSetBL.GetObjLst(strCondition);
objDDL.DataValueField = convQxPrjMenuSet.MenuSetId;
objDDL.DataTextField = convQxPrjMenuSet.MenuSetName;
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_MenuSetIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v菜单集]...","0");
List<clsvQxPrjMenuSetEN> arrvQxPrjMenuSetObjLst = GetAllvQxPrjMenuSetObjLstCache(); 
objDDL.DataValueField = convQxPrjMenuSet.MenuSetId;
objDDL.DataTextField = convQxPrjMenuSet.MenuSetName;
objDDL.DataSource = arrvQxPrjMenuSetObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}


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
if (clsQxProjectsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxProjectsBL没有刷新缓存机制(clsQxProjectsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxPrjMenuSetBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxPrjMenuSetBL没有刷新缓存机制(clsQxPrjMenuSetBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by MenuSetId");
//if (arrvQxPrjMenuSetObjLstCache == null)
//{
//arrvQxPrjMenuSetObjLstCache = vQxPrjMenuSetDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strMenuSetId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxPrjMenuSetEN GetObjByMenuSetIdCache(string strMenuSetId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvQxPrjMenuSetEN._CurrTabName);
List<clsvQxPrjMenuSetEN> arrvQxPrjMenuSetObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjMenuSetEN> arrvQxPrjMenuSetObjLst_Sel =
arrvQxPrjMenuSetObjLstCache
.Where(x=> x.MenuSetId == strMenuSetId 
);
if (arrvQxPrjMenuSetObjLst_Sel.Count() == 0)
{
   clsvQxPrjMenuSetEN obj = clsvQxPrjMenuSetBL.GetObjByMenuSetId(strMenuSetId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvQxPrjMenuSetObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strMenuSetId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetMenuSetNameByMenuSetIdCache(string strMenuSetId)
{
if (string.IsNullOrEmpty(strMenuSetId) == true) return "";
//获取缓存中的对象列表
clsvQxPrjMenuSetEN objvQxPrjMenuSet = GetObjByMenuSetIdCache(strMenuSetId);
if (objvQxPrjMenuSet == null) return "";
return objvQxPrjMenuSet.MenuSetName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strMenuSetId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByMenuSetIdCache(string strMenuSetId)
{
if (string.IsNullOrEmpty(strMenuSetId) == true) return "";
//获取缓存中的对象列表
clsvQxPrjMenuSetEN objvQxPrjMenuSet = GetObjByMenuSetIdCache(strMenuSetId);
if (objvQxPrjMenuSet == null) return "";
return objvQxPrjMenuSet.MenuSetName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxPrjMenuSetEN> GetAllvQxPrjMenuSetObjLstCache()
{
//获取缓存中的对象列表
List<clsvQxPrjMenuSetEN> arrvQxPrjMenuSetObjLstCache = GetObjLstCache(); 
return arrvQxPrjMenuSetObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxPrjMenuSetEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvQxPrjMenuSetEN._CurrTabName);
List<clsvQxPrjMenuSetEN> arrvQxPrjMenuSetObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQxPrjMenuSetObjLstCache;
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
string strKey = string.Format("{0}", clsvQxPrjMenuSetEN._CurrTabName);
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


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstvQxPrjMenuSetObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsvQxPrjMenuSetEN> lstvQxPrjMenuSetObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstvQxPrjMenuSetObjLst, writer);
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
 /// <param name = "lstvQxPrjMenuSetObjLst">[clsvQxPrjMenuSetEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsvQxPrjMenuSetEN> lstvQxPrjMenuSetObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsvQxPrjMenuSetBL.listXmlNode);
writer.WriteStartElement(clsvQxPrjMenuSetBL.itemsXmlNode);
foreach (clsvQxPrjMenuSetEN objvQxPrjMenuSetEN in lstvQxPrjMenuSetObjLst)
{
clsvQxPrjMenuSetBL.SerializeXML(writer, objvQxPrjMenuSetEN);
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
 /// <param name = "objvQxPrjMenuSetEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsvQxPrjMenuSetEN objvQxPrjMenuSetEN)
{
writer.WriteStartElement(clsvQxPrjMenuSetBL.itemXmlNode);
 
if (objvQxPrjMenuSetEN.MenuSetId != null)
{
writer.WriteElementString(convQxPrjMenuSet.MenuSetId, objvQxPrjMenuSetEN.MenuSetId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenuSetEN.MenuSetName != null)
{
writer.WriteElementString(convQxPrjMenuSet.MenuSetName, objvQxPrjMenuSetEN.MenuSetName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenuSetEN.QxPrjId != null)
{
writer.WriteElementString(convQxPrjMenuSet.QxPrjId, objvQxPrjMenuSetEN.QxPrjId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjMenuSetEN.PrjName != null)
{
writer.WriteElementString(convQxPrjMenuSet.PrjName, objvQxPrjMenuSetEN.PrjName.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convQxPrjMenuSet.IsDefault, objvQxPrjMenuSetEN.IsDefault.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objvQxPrjMenuSetEN.Memo != null)
{
writer.WriteElementString(convQxPrjMenuSet.Memo, objvQxPrjMenuSetEN.Memo.ToString(CultureInfo.InvariantCulture));
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
public static clsvQxPrjMenuSetEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsvQxPrjMenuSetEN objvQxPrjMenuSetEN = new clsvQxPrjMenuSetEN();
reader.Read();
while (!(reader.Name == clsvQxPrjMenuSetBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(convQxPrjMenuSet.MenuSetId))
{
objvQxPrjMenuSetEN.MenuSetId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenuSet.MenuSetName))
{
objvQxPrjMenuSetEN.MenuSetName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenuSet.QxPrjId))
{
objvQxPrjMenuSetEN.QxPrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenuSet.PrjName))
{
objvQxPrjMenuSetEN.PrjName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjMenuSet.IsDefault))
{
objvQxPrjMenuSetEN.IsDefault = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(convQxPrjMenuSet.Memo))
{
objvQxPrjMenuSetEN.Memo = reader.ReadElementContentAsString();
}
}
return objvQxPrjMenuSetEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strvQxPrjMenuSetObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsvQxPrjMenuSetEN GetObjFromXmlStr(string strvQxPrjMenuSetObjXmlStr)
{
clsvQxPrjMenuSetEN objvQxPrjMenuSetEN = new clsvQxPrjMenuSetEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strvQxPrjMenuSetObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsvQxPrjMenuSetBL.itemXmlNode))
{
objvQxPrjMenuSetEN = GetObjFromXml(reader);
return objvQxPrjMenuSetEN;
}
}
return objvQxPrjMenuSetEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objvQxPrjMenuSetEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsvQxPrjMenuSetEN objvQxPrjMenuSetEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objvQxPrjMenuSetEN);
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
public static string Func(string strInFldName, string strOutFldName, string strMenuSetId)
{
if (strInFldName != convQxPrjMenuSet.MenuSetId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convQxPrjMenuSet.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convQxPrjMenuSet.AttributeName));
throw new Exception(strMsg);
}
var objvQxPrjMenuSet = clsvQxPrjMenuSetBL.GetObjByMenuSetIdCache(strMenuSetId);
if (objvQxPrjMenuSet == null) return "";
return objvQxPrjMenuSet[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objvQxPrjMenuSetEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsvQxPrjMenuSetEN objvQxPrjMenuSetEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsvQxPrjMenuSetEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objvQxPrjMenuSetEN[strField]);
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
 /// <param name = "lstvQxPrjMenuSetObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsvQxPrjMenuSetEN> lstvQxPrjMenuSetObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstvQxPrjMenuSetObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsvQxPrjMenuSetEN objvQxPrjMenuSetEN in lstvQxPrjMenuSetObjLst)
{
string strJSON_One = SerializeObjToJSON(objvQxPrjMenuSetEN);
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
int intRecCount = clsvQxPrjMenuSetDA.GetRecCount(strTabName);
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
int intRecCount = clsvQxPrjMenuSetDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvQxPrjMenuSetDA.GetRecCount();
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
int intRecCount = clsvQxPrjMenuSetDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvQxPrjMenuSetCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvQxPrjMenuSetEN objvQxPrjMenuSetCond)
{
List<clsvQxPrjMenuSetEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjMenuSetEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxPrjMenuSet.AttributeName)
{
if (objvQxPrjMenuSetCond.IsUpdated(strFldName) == false) continue;
if (objvQxPrjMenuSetCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjMenuSetCond[strFldName].ToString());
}
else
{
if (objvQxPrjMenuSetCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxPrjMenuSetCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjMenuSetCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxPrjMenuSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxPrjMenuSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxPrjMenuSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxPrjMenuSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxPrjMenuSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxPrjMenuSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxPrjMenuSetCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxPrjMenuSetCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxPrjMenuSetCond[strFldName]));
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
 List<string> arrList = clsvQxPrjMenuSetDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vQxPrjMenuSetDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vQxPrjMenuSetDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}