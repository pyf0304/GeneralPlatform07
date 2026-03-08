
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPrjFileRelaBL
 表名:vQxPrjFileRela(00140060)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:33:06
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:工程文件下载(PrjFileDownLoad)
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
public static class  clsvQxPrjFileRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxPrjFileRelaEN GetObj(this K_mId_vQxPrjFileRela myKey)
{
clsvQxPrjFileRelaEN objvQxPrjFileRelaEN = clsvQxPrjFileRelaBL.vQxPrjFileRelaDA.GetObjBymId(myKey.Value);
return objvQxPrjFileRelaEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjFileRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjFileRelaEN SetmId(this clsvQxPrjFileRelaEN objvQxPrjFileRelaEN, long lngmId, string strComparisonOp="")
	{
objvQxPrjFileRelaEN.mId = lngmId; //流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjFileRelaEN.dicFldComparisonOp.ContainsKey(convQxPrjFileRela.mId) == false)
{
objvQxPrjFileRelaEN.dicFldComparisonOp.Add(convQxPrjFileRela.mId, strComparisonOp);
}
else
{
objvQxPrjFileRelaEN.dicFldComparisonOp[convQxPrjFileRela.mId] = strComparisonOp;
}
}
return objvQxPrjFileRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjFileRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjFileRelaEN SetQxPrjId(this clsvQxPrjFileRelaEN objvQxPrjFileRelaEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, convQxPrjFileRela.QxPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxPrjFileRela.QxPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxPrjFileRela.QxPrjId);
}
objvQxPrjFileRelaEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjFileRelaEN.dicFldComparisonOp.ContainsKey(convQxPrjFileRela.QxPrjId) == false)
{
objvQxPrjFileRelaEN.dicFldComparisonOp.Add(convQxPrjFileRela.QxPrjId, strComparisonOp);
}
else
{
objvQxPrjFileRelaEN.dicFldComparisonOp[convQxPrjFileRela.QxPrjId] = strComparisonOp;
}
}
return objvQxPrjFileRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjFileRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjFileRelaEN SetPrjName(this clsvQxPrjFileRelaEN objvQxPrjFileRelaEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convQxPrjFileRela.PrjName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convQxPrjFileRela.PrjName);
}
objvQxPrjFileRelaEN.PrjName = strPrjName; //工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjFileRelaEN.dicFldComparisonOp.ContainsKey(convQxPrjFileRela.PrjName) == false)
{
objvQxPrjFileRelaEN.dicFldComparisonOp.Add(convQxPrjFileRela.PrjName, strComparisonOp);
}
else
{
objvQxPrjFileRelaEN.dicFldComparisonOp[convQxPrjFileRela.PrjName] = strComparisonOp;
}
}
return objvQxPrjFileRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjFileRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjFileRelaEN SetFileName(this clsvQxPrjFileRelaEN objvQxPrjFileRelaEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFileName, convQxPrjFileRela.FileName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileName, 500, convQxPrjFileRela.FileName);
}
objvQxPrjFileRelaEN.FileName = strFileName; //文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjFileRelaEN.dicFldComparisonOp.ContainsKey(convQxPrjFileRela.FileName) == false)
{
objvQxPrjFileRelaEN.dicFldComparisonOp.Add(convQxPrjFileRela.FileName, strComparisonOp);
}
else
{
objvQxPrjFileRelaEN.dicFldComparisonOp[convQxPrjFileRela.FileName] = strComparisonOp;
}
}
return objvQxPrjFileRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjFileRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjFileRelaEN SetVersion(this clsvQxPrjFileRelaEN objvQxPrjFileRelaEN, string strVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVersion, convQxPrjFileRela.Version);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVersion, 30, convQxPrjFileRela.Version);
}
objvQxPrjFileRelaEN.Version = strVersion; //版本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjFileRelaEN.dicFldComparisonOp.ContainsKey(convQxPrjFileRela.Version) == false)
{
objvQxPrjFileRelaEN.dicFldComparisonOp.Add(convQxPrjFileRela.Version, strComparisonOp);
}
else
{
objvQxPrjFileRelaEN.dicFldComparisonOp[convQxPrjFileRela.Version] = strComparisonOp;
}
}
return objvQxPrjFileRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjFileRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjFileRelaEN SetFilePath(this clsvQxPrjFileRelaEN objvQxPrjFileRelaEN, string strFilePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFilePath, convQxPrjFileRela.FilePath);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFilePath, 500, convQxPrjFileRela.FilePath);
}
objvQxPrjFileRelaEN.FilePath = strFilePath; //文件路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjFileRelaEN.dicFldComparisonOp.ContainsKey(convQxPrjFileRela.FilePath) == false)
{
objvQxPrjFileRelaEN.dicFldComparisonOp.Add(convQxPrjFileRela.FilePath, strComparisonOp);
}
else
{
objvQxPrjFileRelaEN.dicFldComparisonOp[convQxPrjFileRela.FilePath] = strComparisonOp;
}
}
return objvQxPrjFileRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjFileRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjFileRelaEN SetUpdDate(this clsvQxPrjFileRelaEN objvQxPrjFileRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQxPrjFileRela.UpdDate);
}
objvQxPrjFileRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjFileRelaEN.dicFldComparisonOp.ContainsKey(convQxPrjFileRela.UpdDate) == false)
{
objvQxPrjFileRelaEN.dicFldComparisonOp.Add(convQxPrjFileRela.UpdDate, strComparisonOp);
}
else
{
objvQxPrjFileRelaEN.dicFldComparisonOp[convQxPrjFileRela.UpdDate] = strComparisonOp;
}
}
return objvQxPrjFileRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjFileRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjFileRelaEN SetUpdUserId(this clsvQxPrjFileRelaEN objvQxPrjFileRelaEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUserId, convQxPrjFileRela.UpdUserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convQxPrjFileRela.UpdUserId);
}
objvQxPrjFileRelaEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjFileRelaEN.dicFldComparisonOp.ContainsKey(convQxPrjFileRela.UpdUserId) == false)
{
objvQxPrjFileRelaEN.dicFldComparisonOp.Add(convQxPrjFileRela.UpdUserId, strComparisonOp);
}
else
{
objvQxPrjFileRelaEN.dicFldComparisonOp[convQxPrjFileRela.UpdUserId] = strComparisonOp;
}
}
return objvQxPrjFileRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjFileRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjFileRelaEN SetIsNeedDownLoad(this clsvQxPrjFileRelaEN objvQxPrjFileRelaEN, bool bolIsNeedDownLoad, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsNeedDownLoad, convQxPrjFileRela.IsNeedDownLoad);
objvQxPrjFileRelaEN.IsNeedDownLoad = bolIsNeedDownLoad; //是否需要下载
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjFileRelaEN.dicFldComparisonOp.ContainsKey(convQxPrjFileRela.IsNeedDownLoad) == false)
{
objvQxPrjFileRelaEN.dicFldComparisonOp.Add(convQxPrjFileRela.IsNeedDownLoad, strComparisonOp);
}
else
{
objvQxPrjFileRelaEN.dicFldComparisonOp[convQxPrjFileRela.IsNeedDownLoad] = strComparisonOp;
}
}
return objvQxPrjFileRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjFileRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjFileRelaEN SetMemo(this clsvQxPrjFileRelaEN objvQxPrjFileRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxPrjFileRela.Memo);
}
objvQxPrjFileRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjFileRelaEN.dicFldComparisonOp.ContainsKey(convQxPrjFileRela.Memo) == false)
{
objvQxPrjFileRelaEN.dicFldComparisonOp.Add(convQxPrjFileRela.Memo, strComparisonOp);
}
else
{
objvQxPrjFileRelaEN.dicFldComparisonOp[convQxPrjFileRela.Memo] = strComparisonOp;
}
}
return objvQxPrjFileRelaEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvQxPrjFileRelaENS">源对象</param>
 /// <param name = "objvQxPrjFileRelaENT">目标对象</param>
 public static void CopyTo(this clsvQxPrjFileRelaEN objvQxPrjFileRelaENS, clsvQxPrjFileRelaEN objvQxPrjFileRelaENT)
{
try
{
objvQxPrjFileRelaENT.mId = objvQxPrjFileRelaENS.mId; //流水号
objvQxPrjFileRelaENT.QxPrjId = objvQxPrjFileRelaENS.QxPrjId; //项目Id
objvQxPrjFileRelaENT.PrjName = objvQxPrjFileRelaENS.PrjName; //工程名
objvQxPrjFileRelaENT.FileName = objvQxPrjFileRelaENS.FileName; //文件名
objvQxPrjFileRelaENT.Version = objvQxPrjFileRelaENS.Version; //版本
objvQxPrjFileRelaENT.FilePath = objvQxPrjFileRelaENS.FilePath; //文件路径
objvQxPrjFileRelaENT.UpdDate = objvQxPrjFileRelaENS.UpdDate; //修改日期
objvQxPrjFileRelaENT.UpdUserId = objvQxPrjFileRelaENS.UpdUserId; //修改用户Id
objvQxPrjFileRelaENT.IsNeedDownLoad = objvQxPrjFileRelaENS.IsNeedDownLoad; //是否需要下载
objvQxPrjFileRelaENT.Memo = objvQxPrjFileRelaENS.Memo; //备注
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
 /// <param name = "objvQxPrjFileRelaENS">源对象</param>
 /// <returns>目标对象=>clsvQxPrjFileRelaEN:objvQxPrjFileRelaENT</returns>
 public static clsvQxPrjFileRelaEN CopyTo(this clsvQxPrjFileRelaEN objvQxPrjFileRelaENS)
{
try
{
 clsvQxPrjFileRelaEN objvQxPrjFileRelaENT = new clsvQxPrjFileRelaEN()
{
mId = objvQxPrjFileRelaENS.mId, //流水号
QxPrjId = objvQxPrjFileRelaENS.QxPrjId, //项目Id
PrjName = objvQxPrjFileRelaENS.PrjName, //工程名
FileName = objvQxPrjFileRelaENS.FileName, //文件名
Version = objvQxPrjFileRelaENS.Version, //版本
FilePath = objvQxPrjFileRelaENS.FilePath, //文件路径
UpdDate = objvQxPrjFileRelaENS.UpdDate, //修改日期
UpdUserId = objvQxPrjFileRelaENS.UpdUserId, //修改用户Id
IsNeedDownLoad = objvQxPrjFileRelaENS.IsNeedDownLoad, //是否需要下载
Memo = objvQxPrjFileRelaENS.Memo, //备注
};
 return objvQxPrjFileRelaENT;
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
public static void CheckProperty4Condition(this clsvQxPrjFileRelaEN objvQxPrjFileRelaEN)
{
 clsvQxPrjFileRelaBL.vQxPrjFileRelaDA.CheckProperty4Condition(objvQxPrjFileRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQxPrjFileRelaEN objvQxPrjFileRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQxPrjFileRelaCond.IsUpdated(convQxPrjFileRela.mId) == true)
{
string strComparisonOpmId = objvQxPrjFileRelaCond.dicFldComparisonOp[convQxPrjFileRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convQxPrjFileRela.mId, objvQxPrjFileRelaCond.mId, strComparisonOpmId);
}
if (objvQxPrjFileRelaCond.IsUpdated(convQxPrjFileRela.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objvQxPrjFileRelaCond.dicFldComparisonOp[convQxPrjFileRela.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjFileRela.QxPrjId, objvQxPrjFileRelaCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objvQxPrjFileRelaCond.IsUpdated(convQxPrjFileRela.PrjName) == true)
{
string strComparisonOpPrjName = objvQxPrjFileRelaCond.dicFldComparisonOp[convQxPrjFileRela.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjFileRela.PrjName, objvQxPrjFileRelaCond.PrjName, strComparisonOpPrjName);
}
if (objvQxPrjFileRelaCond.IsUpdated(convQxPrjFileRela.FileName) == true)
{
string strComparisonOpFileName = objvQxPrjFileRelaCond.dicFldComparisonOp[convQxPrjFileRela.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjFileRela.FileName, objvQxPrjFileRelaCond.FileName, strComparisonOpFileName);
}
if (objvQxPrjFileRelaCond.IsUpdated(convQxPrjFileRela.Version) == true)
{
string strComparisonOpVersion = objvQxPrjFileRelaCond.dicFldComparisonOp[convQxPrjFileRela.Version];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjFileRela.Version, objvQxPrjFileRelaCond.Version, strComparisonOpVersion);
}
if (objvQxPrjFileRelaCond.IsUpdated(convQxPrjFileRela.FilePath) == true)
{
string strComparisonOpFilePath = objvQxPrjFileRelaCond.dicFldComparisonOp[convQxPrjFileRela.FilePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjFileRela.FilePath, objvQxPrjFileRelaCond.FilePath, strComparisonOpFilePath);
}
if (objvQxPrjFileRelaCond.IsUpdated(convQxPrjFileRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvQxPrjFileRelaCond.dicFldComparisonOp[convQxPrjFileRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjFileRela.UpdDate, objvQxPrjFileRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvQxPrjFileRelaCond.IsUpdated(convQxPrjFileRela.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvQxPrjFileRelaCond.dicFldComparisonOp[convQxPrjFileRela.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjFileRela.UpdUserId, objvQxPrjFileRelaCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvQxPrjFileRelaCond.IsUpdated(convQxPrjFileRela.IsNeedDownLoad) == true)
{
if (objvQxPrjFileRelaCond.IsNeedDownLoad == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQxPrjFileRela.IsNeedDownLoad);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQxPrjFileRela.IsNeedDownLoad);
}
}
if (objvQxPrjFileRelaCond.IsUpdated(convQxPrjFileRela.Memo) == true)
{
string strComparisonOpMemo = objvQxPrjFileRelaCond.dicFldComparisonOp[convQxPrjFileRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjFileRela.Memo, objvQxPrjFileRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vQxPrjFileRela
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v项目相关文件(vQxPrjFileRela)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvQxPrjFileRelaBL
{
public static RelatedActions_vQxPrjFileRela relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "vQxPrjFileRelaListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "vQxPrjFileRelaList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsvQxPrjFileRelaEN> arrvQxPrjFileRelaObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvQxPrjFileRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvQxPrjFileRelaDA vQxPrjFileRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvQxPrjFileRelaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvQxPrjFileRelaBL()
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
if (string.IsNullOrEmpty(clsvQxPrjFileRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxPrjFileRelaEN._ConnectString);
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
objDS = vQxPrjFileRelaDA.GetDataSet(strWhereCond);
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
objDS = vQxPrjFileRelaDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = vQxPrjFileRelaDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_vQxPrjFileRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQxPrjFileRelaDA.GetDataTable_vQxPrjFileRela(strWhereCond);
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
objDT = vQxPrjFileRelaDA.GetDataTable(strWhereCond);
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
objDT = vQxPrjFileRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vQxPrjFileRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vQxPrjFileRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vQxPrjFileRelaDA.GetDataTable_Top(objTopPara);
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
objDT = vQxPrjFileRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vQxPrjFileRelaDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = vQxPrjFileRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vQxPrjFileRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = vQxPrjFileRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = vQxPrjFileRelaDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = vQxPrjFileRelaDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = vQxPrjFileRelaDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
public static List<clsvQxPrjFileRelaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvQxPrjFileRelaEN> arrObjLst = new List<clsvQxPrjFileRelaEN>(); 
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
	clsvQxPrjFileRelaEN objvQxPrjFileRelaEN = new clsvQxPrjFileRelaEN();
try
{
objvQxPrjFileRelaEN.mId = Int32.Parse(objRow[convQxPrjFileRela.mId].ToString().Trim()); //流水号
objvQxPrjFileRelaEN.QxPrjId = objRow[convQxPrjFileRela.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjFileRelaEN.PrjName = objRow[convQxPrjFileRela.PrjName].ToString().Trim(); //工程名
objvQxPrjFileRelaEN.FileName = objRow[convQxPrjFileRela.FileName].ToString().Trim(); //文件名
objvQxPrjFileRelaEN.Version = objRow[convQxPrjFileRela.Version].ToString().Trim(); //版本
objvQxPrjFileRelaEN.FilePath = objRow[convQxPrjFileRela.FilePath].ToString().Trim(); //文件路径
objvQxPrjFileRelaEN.UpdDate = objRow[convQxPrjFileRela.UpdDate] == DBNull.Value ? null : objRow[convQxPrjFileRela.UpdDate].ToString().Trim(); //修改日期
objvQxPrjFileRelaEN.UpdUserId = objRow[convQxPrjFileRela.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjFileRelaEN.IsNeedDownLoad = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjFileRela.IsNeedDownLoad].ToString().Trim()); //是否需要下载
objvQxPrjFileRelaEN.Memo = objRow[convQxPrjFileRela.Memo] == DBNull.Value ? null : objRow[convQxPrjFileRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjFileRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjFileRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvQxPrjFileRelaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvQxPrjFileRelaEN._CurrTabName);
List<clsvQxPrjFileRelaEN> arrvQxPrjFileRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjFileRelaEN> arrvQxPrjFileRelaObjLst_Sel =
arrvQxPrjFileRelaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvQxPrjFileRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjFileRelaEN> GetObjLst(string strWhereCond)
{
List<clsvQxPrjFileRelaEN> arrObjLst = new List<clsvQxPrjFileRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjFileRelaEN objvQxPrjFileRelaEN = new clsvQxPrjFileRelaEN();
try
{
objvQxPrjFileRelaEN.mId = Int32.Parse(objRow[convQxPrjFileRela.mId].ToString().Trim()); //流水号
objvQxPrjFileRelaEN.QxPrjId = objRow[convQxPrjFileRela.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjFileRelaEN.PrjName = objRow[convQxPrjFileRela.PrjName].ToString().Trim(); //工程名
objvQxPrjFileRelaEN.FileName = objRow[convQxPrjFileRela.FileName].ToString().Trim(); //文件名
objvQxPrjFileRelaEN.Version = objRow[convQxPrjFileRela.Version].ToString().Trim(); //版本
objvQxPrjFileRelaEN.FilePath = objRow[convQxPrjFileRela.FilePath].ToString().Trim(); //文件路径
objvQxPrjFileRelaEN.UpdDate = objRow[convQxPrjFileRela.UpdDate] == DBNull.Value ? null : objRow[convQxPrjFileRela.UpdDate].ToString().Trim(); //修改日期
objvQxPrjFileRelaEN.UpdUserId = objRow[convQxPrjFileRela.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjFileRelaEN.IsNeedDownLoad = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjFileRela.IsNeedDownLoad].ToString().Trim()); //是否需要下载
objvQxPrjFileRelaEN.Memo = objRow[convQxPrjFileRela.Memo] == DBNull.Value ? null : objRow[convQxPrjFileRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjFileRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjFileRelaEN);
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
public static List<clsvQxPrjFileRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQxPrjFileRelaEN> arrObjLst = new List<clsvQxPrjFileRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjFileRelaEN objvQxPrjFileRelaEN = new clsvQxPrjFileRelaEN();
try
{
objvQxPrjFileRelaEN.mId = Int32.Parse(objRow[convQxPrjFileRela.mId].ToString().Trim()); //流水号
objvQxPrjFileRelaEN.QxPrjId = objRow[convQxPrjFileRela.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjFileRelaEN.PrjName = objRow[convQxPrjFileRela.PrjName].ToString().Trim(); //工程名
objvQxPrjFileRelaEN.FileName = objRow[convQxPrjFileRela.FileName].ToString().Trim(); //文件名
objvQxPrjFileRelaEN.Version = objRow[convQxPrjFileRela.Version].ToString().Trim(); //版本
objvQxPrjFileRelaEN.FilePath = objRow[convQxPrjFileRela.FilePath].ToString().Trim(); //文件路径
objvQxPrjFileRelaEN.UpdDate = objRow[convQxPrjFileRela.UpdDate] == DBNull.Value ? null : objRow[convQxPrjFileRela.UpdDate].ToString().Trim(); //修改日期
objvQxPrjFileRelaEN.UpdUserId = objRow[convQxPrjFileRela.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjFileRelaEN.IsNeedDownLoad = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjFileRela.IsNeedDownLoad].ToString().Trim()); //是否需要下载
objvQxPrjFileRelaEN.Memo = objRow[convQxPrjFileRela.Memo] == DBNull.Value ? null : objRow[convQxPrjFileRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjFileRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjFileRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvQxPrjFileRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvQxPrjFileRelaEN> GetSubObjLstCache(clsvQxPrjFileRelaEN objvQxPrjFileRelaCond)
{
List<clsvQxPrjFileRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjFileRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxPrjFileRela.AttributeName)
{
if (objvQxPrjFileRelaCond.IsUpdated(strFldName) == false) continue;
if (objvQxPrjFileRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjFileRelaCond[strFldName].ToString());
}
else
{
if (objvQxPrjFileRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxPrjFileRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjFileRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxPrjFileRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxPrjFileRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxPrjFileRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxPrjFileRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxPrjFileRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxPrjFileRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxPrjFileRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxPrjFileRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxPrjFileRelaCond[strFldName]));
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
public static List<clsvQxPrjFileRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvQxPrjFileRelaEN> arrObjLst = new List<clsvQxPrjFileRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjFileRelaEN objvQxPrjFileRelaEN = new clsvQxPrjFileRelaEN();
try
{
objvQxPrjFileRelaEN.mId = Int32.Parse(objRow[convQxPrjFileRela.mId].ToString().Trim()); //流水号
objvQxPrjFileRelaEN.QxPrjId = objRow[convQxPrjFileRela.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjFileRelaEN.PrjName = objRow[convQxPrjFileRela.PrjName].ToString().Trim(); //工程名
objvQxPrjFileRelaEN.FileName = objRow[convQxPrjFileRela.FileName].ToString().Trim(); //文件名
objvQxPrjFileRelaEN.Version = objRow[convQxPrjFileRela.Version].ToString().Trim(); //版本
objvQxPrjFileRelaEN.FilePath = objRow[convQxPrjFileRela.FilePath].ToString().Trim(); //文件路径
objvQxPrjFileRelaEN.UpdDate = objRow[convQxPrjFileRela.UpdDate] == DBNull.Value ? null : objRow[convQxPrjFileRela.UpdDate].ToString().Trim(); //修改日期
objvQxPrjFileRelaEN.UpdUserId = objRow[convQxPrjFileRela.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjFileRelaEN.IsNeedDownLoad = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjFileRela.IsNeedDownLoad].ToString().Trim()); //是否需要下载
objvQxPrjFileRelaEN.Memo = objRow[convQxPrjFileRela.Memo] == DBNull.Value ? null : objRow[convQxPrjFileRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjFileRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjFileRelaEN);
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
public static List<clsvQxPrjFileRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvQxPrjFileRelaEN> arrObjLst = new List<clsvQxPrjFileRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjFileRelaEN objvQxPrjFileRelaEN = new clsvQxPrjFileRelaEN();
try
{
objvQxPrjFileRelaEN.mId = Int32.Parse(objRow[convQxPrjFileRela.mId].ToString().Trim()); //流水号
objvQxPrjFileRelaEN.QxPrjId = objRow[convQxPrjFileRela.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjFileRelaEN.PrjName = objRow[convQxPrjFileRela.PrjName].ToString().Trim(); //工程名
objvQxPrjFileRelaEN.FileName = objRow[convQxPrjFileRela.FileName].ToString().Trim(); //文件名
objvQxPrjFileRelaEN.Version = objRow[convQxPrjFileRela.Version].ToString().Trim(); //版本
objvQxPrjFileRelaEN.FilePath = objRow[convQxPrjFileRela.FilePath].ToString().Trim(); //文件路径
objvQxPrjFileRelaEN.UpdDate = objRow[convQxPrjFileRela.UpdDate] == DBNull.Value ? null : objRow[convQxPrjFileRela.UpdDate].ToString().Trim(); //修改日期
objvQxPrjFileRelaEN.UpdUserId = objRow[convQxPrjFileRela.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjFileRelaEN.IsNeedDownLoad = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjFileRela.IsNeedDownLoad].ToString().Trim()); //是否需要下载
objvQxPrjFileRelaEN.Memo = objRow[convQxPrjFileRela.Memo] == DBNull.Value ? null : objRow[convQxPrjFileRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjFileRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjFileRelaEN);
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
List<clsvQxPrjFileRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvQxPrjFileRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjFileRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvQxPrjFileRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvQxPrjFileRelaEN> arrObjLst = new List<clsvQxPrjFileRelaEN>(); 
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
	clsvQxPrjFileRelaEN objvQxPrjFileRelaEN = new clsvQxPrjFileRelaEN();
try
{
objvQxPrjFileRelaEN.mId = Int32.Parse(objRow[convQxPrjFileRela.mId].ToString().Trim()); //流水号
objvQxPrjFileRelaEN.QxPrjId = objRow[convQxPrjFileRela.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjFileRelaEN.PrjName = objRow[convQxPrjFileRela.PrjName].ToString().Trim(); //工程名
objvQxPrjFileRelaEN.FileName = objRow[convQxPrjFileRela.FileName].ToString().Trim(); //文件名
objvQxPrjFileRelaEN.Version = objRow[convQxPrjFileRela.Version].ToString().Trim(); //版本
objvQxPrjFileRelaEN.FilePath = objRow[convQxPrjFileRela.FilePath].ToString().Trim(); //文件路径
objvQxPrjFileRelaEN.UpdDate = objRow[convQxPrjFileRela.UpdDate] == DBNull.Value ? null : objRow[convQxPrjFileRela.UpdDate].ToString().Trim(); //修改日期
objvQxPrjFileRelaEN.UpdUserId = objRow[convQxPrjFileRela.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjFileRelaEN.IsNeedDownLoad = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjFileRela.IsNeedDownLoad].ToString().Trim()); //是否需要下载
objvQxPrjFileRelaEN.Memo = objRow[convQxPrjFileRela.Memo] == DBNull.Value ? null : objRow[convQxPrjFileRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjFileRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjFileRelaEN);
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
public static List<clsvQxPrjFileRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvQxPrjFileRelaEN> arrObjLst = new List<clsvQxPrjFileRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjFileRelaEN objvQxPrjFileRelaEN = new clsvQxPrjFileRelaEN();
try
{
objvQxPrjFileRelaEN.mId = Int32.Parse(objRow[convQxPrjFileRela.mId].ToString().Trim()); //流水号
objvQxPrjFileRelaEN.QxPrjId = objRow[convQxPrjFileRela.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjFileRelaEN.PrjName = objRow[convQxPrjFileRela.PrjName].ToString().Trim(); //工程名
objvQxPrjFileRelaEN.FileName = objRow[convQxPrjFileRela.FileName].ToString().Trim(); //文件名
objvQxPrjFileRelaEN.Version = objRow[convQxPrjFileRela.Version].ToString().Trim(); //版本
objvQxPrjFileRelaEN.FilePath = objRow[convQxPrjFileRela.FilePath].ToString().Trim(); //文件路径
objvQxPrjFileRelaEN.UpdDate = objRow[convQxPrjFileRela.UpdDate] == DBNull.Value ? null : objRow[convQxPrjFileRela.UpdDate].ToString().Trim(); //修改日期
objvQxPrjFileRelaEN.UpdUserId = objRow[convQxPrjFileRela.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjFileRelaEN.IsNeedDownLoad = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjFileRela.IsNeedDownLoad].ToString().Trim()); //是否需要下载
objvQxPrjFileRelaEN.Memo = objRow[convQxPrjFileRela.Memo] == DBNull.Value ? null : objRow[convQxPrjFileRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjFileRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjFileRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQxPrjFileRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvQxPrjFileRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvQxPrjFileRelaEN> arrObjLst = new List<clsvQxPrjFileRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjFileRelaEN objvQxPrjFileRelaEN = new clsvQxPrjFileRelaEN();
try
{
objvQxPrjFileRelaEN.mId = Int32.Parse(objRow[convQxPrjFileRela.mId].ToString().Trim()); //流水号
objvQxPrjFileRelaEN.QxPrjId = objRow[convQxPrjFileRela.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjFileRelaEN.PrjName = objRow[convQxPrjFileRela.PrjName].ToString().Trim(); //工程名
objvQxPrjFileRelaEN.FileName = objRow[convQxPrjFileRela.FileName].ToString().Trim(); //文件名
objvQxPrjFileRelaEN.Version = objRow[convQxPrjFileRela.Version].ToString().Trim(); //版本
objvQxPrjFileRelaEN.FilePath = objRow[convQxPrjFileRela.FilePath].ToString().Trim(); //文件路径
objvQxPrjFileRelaEN.UpdDate = objRow[convQxPrjFileRela.UpdDate] == DBNull.Value ? null : objRow[convQxPrjFileRela.UpdDate].ToString().Trim(); //修改日期
objvQxPrjFileRelaEN.UpdUserId = objRow[convQxPrjFileRela.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjFileRelaEN.IsNeedDownLoad = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjFileRela.IsNeedDownLoad].ToString().Trim()); //是否需要下载
objvQxPrjFileRelaEN.Memo = objRow[convQxPrjFileRela.Memo] == DBNull.Value ? null : objRow[convQxPrjFileRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjFileRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjFileRelaEN);
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
public static List<clsvQxPrjFileRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvQxPrjFileRelaEN> arrObjLst = new List<clsvQxPrjFileRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjFileRelaEN objvQxPrjFileRelaEN = new clsvQxPrjFileRelaEN();
try
{
objvQxPrjFileRelaEN.mId = Int32.Parse(objRow[convQxPrjFileRela.mId].ToString().Trim()); //流水号
objvQxPrjFileRelaEN.QxPrjId = objRow[convQxPrjFileRela.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjFileRelaEN.PrjName = objRow[convQxPrjFileRela.PrjName].ToString().Trim(); //工程名
objvQxPrjFileRelaEN.FileName = objRow[convQxPrjFileRela.FileName].ToString().Trim(); //文件名
objvQxPrjFileRelaEN.Version = objRow[convQxPrjFileRela.Version].ToString().Trim(); //版本
objvQxPrjFileRelaEN.FilePath = objRow[convQxPrjFileRela.FilePath].ToString().Trim(); //文件路径
objvQxPrjFileRelaEN.UpdDate = objRow[convQxPrjFileRela.UpdDate] == DBNull.Value ? null : objRow[convQxPrjFileRela.UpdDate].ToString().Trim(); //修改日期
objvQxPrjFileRelaEN.UpdUserId = objRow[convQxPrjFileRela.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjFileRelaEN.IsNeedDownLoad = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjFileRela.IsNeedDownLoad].ToString().Trim()); //是否需要下载
objvQxPrjFileRelaEN.Memo = objRow[convQxPrjFileRela.Memo] == DBNull.Value ? null : objRow[convQxPrjFileRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjFileRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjFileRelaEN);
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
public static IEnumerable<clsvQxPrjFileRelaEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsvQxPrjFileRelaEN objvQxPrjFileRelaCond, string strOrderBy)
{
List<clsvQxPrjFileRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjFileRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxPrjFileRela.AttributeName)
{
if (objvQxPrjFileRelaCond.IsUpdated(strFldName) == false) continue;
if (objvQxPrjFileRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjFileRelaCond[strFldName].ToString());
}
else
{
if (objvQxPrjFileRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxPrjFileRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjFileRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxPrjFileRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxPrjFileRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxPrjFileRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxPrjFileRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxPrjFileRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxPrjFileRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxPrjFileRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxPrjFileRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxPrjFileRelaCond[strFldName]));
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
public static IEnumerable<clsvQxPrjFileRelaEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsvQxPrjFileRelaEN objvQxPrjFileRelaCond = JsonConvert.DeserializeObject<clsvQxPrjFileRelaEN>(objPagerPara.whereCond);
if (objvQxPrjFileRelaCond.sfFldComparisonOp == null)
{
objvQxPrjFileRelaCond.dicFldComparisonOp = null;
}
else
{
objvQxPrjFileRelaCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objvQxPrjFileRelaCond.sfFldComparisonOp);
}
clsvQxPrjFileRelaBL.SetUpdFlag(objvQxPrjFileRelaCond);
 try
{
CheckProperty4Condition(objvQxPrjFileRelaCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsvQxPrjFileRelaBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objvQxPrjFileRelaCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjFileRelaEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsvQxPrjFileRelaEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxPrjFileRelaEN> arrObjLst = new List<clsvQxPrjFileRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjFileRelaEN objvQxPrjFileRelaEN = new clsvQxPrjFileRelaEN();
try
{
objvQxPrjFileRelaEN.mId = Int32.Parse(objRow[convQxPrjFileRela.mId].ToString().Trim()); //流水号
objvQxPrjFileRelaEN.QxPrjId = objRow[convQxPrjFileRela.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjFileRelaEN.PrjName = objRow[convQxPrjFileRela.PrjName].ToString().Trim(); //工程名
objvQxPrjFileRelaEN.FileName = objRow[convQxPrjFileRela.FileName].ToString().Trim(); //文件名
objvQxPrjFileRelaEN.Version = objRow[convQxPrjFileRela.Version].ToString().Trim(); //版本
objvQxPrjFileRelaEN.FilePath = objRow[convQxPrjFileRela.FilePath].ToString().Trim(); //文件路径
objvQxPrjFileRelaEN.UpdDate = objRow[convQxPrjFileRela.UpdDate] == DBNull.Value ? null : objRow[convQxPrjFileRela.UpdDate].ToString().Trim(); //修改日期
objvQxPrjFileRelaEN.UpdUserId = objRow[convQxPrjFileRela.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjFileRelaEN.IsNeedDownLoad = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjFileRela.IsNeedDownLoad].ToString().Trim()); //是否需要下载
objvQxPrjFileRelaEN.Memo = objRow[convQxPrjFileRela.Memo] == DBNull.Value ? null : objRow[convQxPrjFileRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjFileRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjFileRelaEN);
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
public static List<clsvQxPrjFileRelaEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxPrjFileRelaEN> arrObjLst = new List<clsvQxPrjFileRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjFileRelaEN objvQxPrjFileRelaEN = new clsvQxPrjFileRelaEN();
try
{
objvQxPrjFileRelaEN.mId = Int32.Parse(objRow[convQxPrjFileRela.mId].ToString().Trim()); //流水号
objvQxPrjFileRelaEN.QxPrjId = objRow[convQxPrjFileRela.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjFileRelaEN.PrjName = objRow[convQxPrjFileRela.PrjName].ToString().Trim(); //工程名
objvQxPrjFileRelaEN.FileName = objRow[convQxPrjFileRela.FileName].ToString().Trim(); //文件名
objvQxPrjFileRelaEN.Version = objRow[convQxPrjFileRela.Version].ToString().Trim(); //版本
objvQxPrjFileRelaEN.FilePath = objRow[convQxPrjFileRela.FilePath].ToString().Trim(); //文件路径
objvQxPrjFileRelaEN.UpdDate = objRow[convQxPrjFileRela.UpdDate] == DBNull.Value ? null : objRow[convQxPrjFileRela.UpdDate].ToString().Trim(); //修改日期
objvQxPrjFileRelaEN.UpdUserId = objRow[convQxPrjFileRela.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjFileRelaEN.IsNeedDownLoad = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjFileRela.IsNeedDownLoad].ToString().Trim()); //是否需要下载
objvQxPrjFileRelaEN.Memo = objRow[convQxPrjFileRela.Memo] == DBNull.Value ? null : objRow[convQxPrjFileRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjFileRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjFileRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjFileRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvQxPrjFileRelaEN> arrObjLst = new List<clsvQxPrjFileRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjFileRelaEN objvQxPrjFileRelaEN = new clsvQxPrjFileRelaEN();
try
{
objvQxPrjFileRelaEN.mId = Int32.Parse(objRow[convQxPrjFileRela.mId].ToString().Trim()); //流水号
objvQxPrjFileRelaEN.QxPrjId = objRow[convQxPrjFileRela.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjFileRelaEN.PrjName = objRow[convQxPrjFileRela.PrjName].ToString().Trim(); //工程名
objvQxPrjFileRelaEN.FileName = objRow[convQxPrjFileRela.FileName].ToString().Trim(); //文件名
objvQxPrjFileRelaEN.Version = objRow[convQxPrjFileRela.Version].ToString().Trim(); //版本
objvQxPrjFileRelaEN.FilePath = objRow[convQxPrjFileRela.FilePath].ToString().Trim(); //文件路径
objvQxPrjFileRelaEN.UpdDate = objRow[convQxPrjFileRela.UpdDate] == DBNull.Value ? null : objRow[convQxPrjFileRela.UpdDate].ToString().Trim(); //修改日期
objvQxPrjFileRelaEN.UpdUserId = objRow[convQxPrjFileRela.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjFileRelaEN.IsNeedDownLoad = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjFileRela.IsNeedDownLoad].ToString().Trim()); //是否需要下载
objvQxPrjFileRelaEN.Memo = objRow[convQxPrjFileRela.Memo] == DBNull.Value ? null : objRow[convQxPrjFileRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjFileRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjFileRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvQxPrjFileRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxPrjFileRela(ref clsvQxPrjFileRelaEN objvQxPrjFileRelaEN)
{
bool bolResult = vQxPrjFileRelaDA.GetvQxPrjFileRela(ref objvQxPrjFileRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxPrjFileRelaEN GetObjBymId(long lngmId)
{
clsvQxPrjFileRelaEN objvQxPrjFileRelaEN = vQxPrjFileRelaDA.GetObjBymId(lngmId);
return objvQxPrjFileRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvQxPrjFileRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvQxPrjFileRelaEN objvQxPrjFileRelaEN = vQxPrjFileRelaDA.GetFirstObj(strWhereCond);
 return objvQxPrjFileRelaEN;
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
public static clsvQxPrjFileRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvQxPrjFileRelaEN objvQxPrjFileRelaEN = vQxPrjFileRelaDA.GetObjByDataRow(objRow);
 return objvQxPrjFileRelaEN;
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
public static clsvQxPrjFileRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvQxPrjFileRelaEN objvQxPrjFileRelaEN = vQxPrjFileRelaDA.GetObjByDataRow(objRow);
 return objvQxPrjFileRelaEN;
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
 /// <param name = "lstvQxPrjFileRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxPrjFileRelaEN GetObjBymIdFromList(long lngmId, List<clsvQxPrjFileRelaEN> lstvQxPrjFileRelaObjLst)
{
foreach (clsvQxPrjFileRelaEN objvQxPrjFileRelaEN in lstvQxPrjFileRelaObjLst)
{
if (objvQxPrjFileRelaEN.mId == lngmId)
{
return objvQxPrjFileRelaEN;
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
 lngmId = new clsvQxPrjFileRelaDA().GetFirstID(strWhereCond);
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
 arrList = vQxPrjFileRelaDA.GetID(strWhereCond);
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
bool bolIsExist = vQxPrjFileRelaDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vQxPrjFileRelaDA.IsExist(lngmId);
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
 bolIsExist = clsvQxPrjFileRelaDA.IsExistTable();
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
 bolIsExist = vQxPrjFileRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objvQxPrjFileRelaENS">源对象</param>
 /// <param name = "objvQxPrjFileRelaENT">目标对象</param>
 public static void CopyTo(clsvQxPrjFileRelaEN objvQxPrjFileRelaENS, clsvQxPrjFileRelaEN objvQxPrjFileRelaENT)
{
try
{
objvQxPrjFileRelaENT.mId = objvQxPrjFileRelaENS.mId; //流水号
objvQxPrjFileRelaENT.QxPrjId = objvQxPrjFileRelaENS.QxPrjId; //项目Id
objvQxPrjFileRelaENT.PrjName = objvQxPrjFileRelaENS.PrjName; //工程名
objvQxPrjFileRelaENT.FileName = objvQxPrjFileRelaENS.FileName; //文件名
objvQxPrjFileRelaENT.Version = objvQxPrjFileRelaENS.Version; //版本
objvQxPrjFileRelaENT.FilePath = objvQxPrjFileRelaENS.FilePath; //文件路径
objvQxPrjFileRelaENT.UpdDate = objvQxPrjFileRelaENS.UpdDate; //修改日期
objvQxPrjFileRelaENT.UpdUserId = objvQxPrjFileRelaENS.UpdUserId; //修改用户Id
objvQxPrjFileRelaENT.IsNeedDownLoad = objvQxPrjFileRelaENS.IsNeedDownLoad; //是否需要下载
objvQxPrjFileRelaENT.Memo = objvQxPrjFileRelaENS.Memo; //备注
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
 /// <param name = "objvQxPrjFileRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsvQxPrjFileRelaEN objvQxPrjFileRelaEN)
{
try
{
objvQxPrjFileRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvQxPrjFileRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convQxPrjFileRela.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjFileRelaEN.mId = objvQxPrjFileRelaEN.mId; //流水号
}
if (arrFldSet.Contains(convQxPrjFileRela.QxPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjFileRelaEN.QxPrjId = objvQxPrjFileRelaEN.QxPrjId; //项目Id
}
if (arrFldSet.Contains(convQxPrjFileRela.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjFileRelaEN.PrjName = objvQxPrjFileRelaEN.PrjName; //工程名
}
if (arrFldSet.Contains(convQxPrjFileRela.FileName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjFileRelaEN.FileName = objvQxPrjFileRelaEN.FileName; //文件名
}
if (arrFldSet.Contains(convQxPrjFileRela.Version, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjFileRelaEN.Version = objvQxPrjFileRelaEN.Version; //版本
}
if (arrFldSet.Contains(convQxPrjFileRela.FilePath, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjFileRelaEN.FilePath = objvQxPrjFileRelaEN.FilePath; //文件路径
}
if (arrFldSet.Contains(convQxPrjFileRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjFileRelaEN.UpdDate = objvQxPrjFileRelaEN.UpdDate == "[null]" ? null :  objvQxPrjFileRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convQxPrjFileRela.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjFileRelaEN.UpdUserId = objvQxPrjFileRelaEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convQxPrjFileRela.IsNeedDownLoad, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjFileRelaEN.IsNeedDownLoad = objvQxPrjFileRelaEN.IsNeedDownLoad; //是否需要下载
}
if (arrFldSet.Contains(convQxPrjFileRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjFileRelaEN.Memo = objvQxPrjFileRelaEN.Memo == "[null]" ? null :  objvQxPrjFileRelaEN.Memo; //备注
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
 /// <param name = "objvQxPrjFileRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvQxPrjFileRelaEN objvQxPrjFileRelaEN)
{
try
{
if (objvQxPrjFileRelaEN.UpdDate == "[null]") objvQxPrjFileRelaEN.UpdDate = null; //修改日期
if (objvQxPrjFileRelaEN.Memo == "[null]") objvQxPrjFileRelaEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvQxPrjFileRelaEN objvQxPrjFileRelaEN)
{
 vQxPrjFileRelaDA.CheckProperty4Condition(objvQxPrjFileRelaEN);
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
if (clsQxProjectsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxProjectsBL没有刷新缓存机制(clsQxProjectsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxPrjFileRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxPrjFileRelaBL没有刷新缓存机制(clsQxPrjFileRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvQxPrjFileRelaObjLstCache == null)
//{
//arrvQxPrjFileRelaObjLstCache = vQxPrjFileRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxPrjFileRelaEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvQxPrjFileRelaEN._CurrTabName);
List<clsvQxPrjFileRelaEN> arrvQxPrjFileRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjFileRelaEN> arrvQxPrjFileRelaObjLst_Sel =
arrvQxPrjFileRelaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvQxPrjFileRelaObjLst_Sel.Count() == 0)
{
   clsvQxPrjFileRelaEN obj = clsvQxPrjFileRelaBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvQxPrjFileRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxPrjFileRelaEN> GetAllvQxPrjFileRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsvQxPrjFileRelaEN> arrvQxPrjFileRelaObjLstCache = GetObjLstCache(); 
return arrvQxPrjFileRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxPrjFileRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvQxPrjFileRelaEN._CurrTabName);
List<clsvQxPrjFileRelaEN> arrvQxPrjFileRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQxPrjFileRelaObjLstCache;
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
string strKey = string.Format("{0}", clsvQxPrjFileRelaEN._CurrTabName);
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
 /// <param name = "lstvQxPrjFileRelaObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsvQxPrjFileRelaEN> lstvQxPrjFileRelaObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstvQxPrjFileRelaObjLst, writer);
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
 /// <param name = "lstvQxPrjFileRelaObjLst">[clsvQxPrjFileRelaEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsvQxPrjFileRelaEN> lstvQxPrjFileRelaObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsvQxPrjFileRelaBL.listXmlNode);
writer.WriteStartElement(clsvQxPrjFileRelaBL.itemsXmlNode);
foreach (clsvQxPrjFileRelaEN objvQxPrjFileRelaEN in lstvQxPrjFileRelaObjLst)
{
clsvQxPrjFileRelaBL.SerializeXML(writer, objvQxPrjFileRelaEN);
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
 /// <param name = "objvQxPrjFileRelaEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsvQxPrjFileRelaEN objvQxPrjFileRelaEN)
{
writer.WriteStartElement(clsvQxPrjFileRelaBL.itemXmlNode);
 
writer.WriteElementString(convQxPrjFileRela.mId, objvQxPrjFileRelaEN.mId.ToString(CultureInfo.InvariantCulture));
 
if (objvQxPrjFileRelaEN.QxPrjId != null)
{
writer.WriteElementString(convQxPrjFileRela.QxPrjId, objvQxPrjFileRelaEN.QxPrjId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjFileRelaEN.PrjName != null)
{
writer.WriteElementString(convQxPrjFileRela.PrjName, objvQxPrjFileRelaEN.PrjName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjFileRelaEN.FileName != null)
{
writer.WriteElementString(convQxPrjFileRela.FileName, objvQxPrjFileRelaEN.FileName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjFileRelaEN.Version != null)
{
writer.WriteElementString(convQxPrjFileRela.Version, objvQxPrjFileRelaEN.Version.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjFileRelaEN.FilePath != null)
{
writer.WriteElementString(convQxPrjFileRela.FilePath, objvQxPrjFileRelaEN.FilePath.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjFileRelaEN.UpdDate != null)
{
writer.WriteElementString(convQxPrjFileRela.UpdDate, objvQxPrjFileRelaEN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjFileRelaEN.UpdUserId != null)
{
writer.WriteElementString(convQxPrjFileRela.UpdUserId, objvQxPrjFileRelaEN.UpdUserId.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convQxPrjFileRela.IsNeedDownLoad, objvQxPrjFileRelaEN.IsNeedDownLoad.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objvQxPrjFileRelaEN.Memo != null)
{
writer.WriteElementString(convQxPrjFileRela.Memo, objvQxPrjFileRelaEN.Memo.ToString(CultureInfo.InvariantCulture));
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
public static clsvQxPrjFileRelaEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsvQxPrjFileRelaEN objvQxPrjFileRelaEN = new clsvQxPrjFileRelaEN();
reader.Read();
while (!(reader.Name == clsvQxPrjFileRelaBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(convQxPrjFileRela.mId))
{
objvQxPrjFileRelaEN.mId = reader.ReadElementContentAsLong();
}
if (reader.IsStartElement(convQxPrjFileRela.QxPrjId))
{
objvQxPrjFileRelaEN.QxPrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjFileRela.PrjName))
{
objvQxPrjFileRelaEN.PrjName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjFileRela.FileName))
{
objvQxPrjFileRelaEN.FileName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjFileRela.Version))
{
objvQxPrjFileRelaEN.Version = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjFileRela.FilePath))
{
objvQxPrjFileRelaEN.FilePath = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjFileRela.UpdDate))
{
objvQxPrjFileRelaEN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjFileRela.UpdUserId))
{
objvQxPrjFileRelaEN.UpdUserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjFileRela.IsNeedDownLoad))
{
objvQxPrjFileRelaEN.IsNeedDownLoad = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(convQxPrjFileRela.Memo))
{
objvQxPrjFileRelaEN.Memo = reader.ReadElementContentAsString();
}
}
return objvQxPrjFileRelaEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strvQxPrjFileRelaObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsvQxPrjFileRelaEN GetObjFromXmlStr(string strvQxPrjFileRelaObjXmlStr)
{
clsvQxPrjFileRelaEN objvQxPrjFileRelaEN = new clsvQxPrjFileRelaEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strvQxPrjFileRelaObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsvQxPrjFileRelaBL.itemXmlNode))
{
objvQxPrjFileRelaEN = GetObjFromXml(reader);
return objvQxPrjFileRelaEN;
}
}
return objvQxPrjFileRelaEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objvQxPrjFileRelaEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsvQxPrjFileRelaEN objvQxPrjFileRelaEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objvQxPrjFileRelaEN);
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
if (strInFldName != convQxPrjFileRela.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convQxPrjFileRela.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convQxPrjFileRela.AttributeName));
throw new Exception(strMsg);
}
var objvQxPrjFileRela = clsvQxPrjFileRelaBL.GetObjBymIdCache(lngmId);
if (objvQxPrjFileRela == null) return "";
return objvQxPrjFileRela[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objvQxPrjFileRelaEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsvQxPrjFileRelaEN objvQxPrjFileRelaEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsvQxPrjFileRelaEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objvQxPrjFileRelaEN[strField]);
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
 /// <param name = "lstvQxPrjFileRelaObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsvQxPrjFileRelaEN> lstvQxPrjFileRelaObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstvQxPrjFileRelaObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsvQxPrjFileRelaEN objvQxPrjFileRelaEN in lstvQxPrjFileRelaObjLst)
{
string strJSON_One = SerializeObjToJSON(objvQxPrjFileRelaEN);
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
int intRecCount = clsvQxPrjFileRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsvQxPrjFileRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvQxPrjFileRelaDA.GetRecCount();
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
int intRecCount = clsvQxPrjFileRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvQxPrjFileRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvQxPrjFileRelaEN objvQxPrjFileRelaCond)
{
List<clsvQxPrjFileRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjFileRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxPrjFileRela.AttributeName)
{
if (objvQxPrjFileRelaCond.IsUpdated(strFldName) == false) continue;
if (objvQxPrjFileRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjFileRelaCond[strFldName].ToString());
}
else
{
if (objvQxPrjFileRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxPrjFileRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjFileRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxPrjFileRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxPrjFileRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxPrjFileRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxPrjFileRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxPrjFileRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxPrjFileRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxPrjFileRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxPrjFileRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxPrjFileRelaCond[strFldName]));
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
 List<string> arrList = clsvQxPrjFileRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vQxPrjFileRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vQxPrjFileRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}