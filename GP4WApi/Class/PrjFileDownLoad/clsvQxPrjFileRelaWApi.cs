
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPrjFileRelaWApi
 表名:vQxPrjFileRela(00140060)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 18:30:39
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
public static class  clsvQxPrjFileRelaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjFileRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">流水号</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjFileRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strQxPrjId">项目Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjFileRelaEN SetQxPrjId(this clsvQxPrjFileRelaEN objvQxPrjFileRelaEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, convQxPrjFileRela.QxPrjId);
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxPrjFileRela.QxPrjId);
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxPrjFileRela.QxPrjId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjFileRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjFileRelaEN SetPrjName(this clsvQxPrjFileRelaEN objvQxPrjFileRelaEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convQxPrjFileRela.PrjName);
clsCheckSql.CheckFieldLen(strPrjName, 30, convQxPrjFileRela.PrjName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjFileRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFileName">文件名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjFileRelaEN SetFileName(this clsvQxPrjFileRelaEN objvQxPrjFileRelaEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFileName, convQxPrjFileRela.FileName);
clsCheckSql.CheckFieldLen(strFileName, 500, convQxPrjFileRela.FileName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjFileRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strVersion">版本</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjFileRelaEN SetVersion(this clsvQxPrjFileRelaEN objvQxPrjFileRelaEN, string strVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVersion, convQxPrjFileRela.Version);
clsCheckSql.CheckFieldLen(strVersion, 30, convQxPrjFileRela.Version);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjFileRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFilePath">文件路径</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjFileRelaEN SetFilePath(this clsvQxPrjFileRelaEN objvQxPrjFileRelaEN, string strFilePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFilePath, convQxPrjFileRela.FilePath);
clsCheckSql.CheckFieldLen(strFilePath, 500, convQxPrjFileRela.FilePath);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjFileRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjFileRelaEN SetUpdDate(this clsvQxPrjFileRelaEN objvQxPrjFileRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQxPrjFileRela.UpdDate);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjFileRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjFileRelaEN SetUpdUserId(this clsvQxPrjFileRelaEN objvQxPrjFileRelaEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUserId, convQxPrjFileRela.UpdUserId);
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convQxPrjFileRela.UpdUserId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjFileRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNeedDownLoad">是否需要下载</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjFileRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">备注</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjFileRelaEN SetMemo(this clsvQxPrjFileRelaEN objvQxPrjFileRelaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxPrjFileRela.Memo);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
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
 /// v项目相关文件(vQxPrjFileRela)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxPrjFileRelaWApi
{
private static readonly string mstrApiControllerName = "vQxPrjFileRelaApi";

 public clsvQxPrjFileRelaWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxPrjFileRelaEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
clsvQxPrjFileRelaEN objvQxPrjFileRelaEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngmId"] = lngmId.ToString(),
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvQxPrjFileRelaEN = JsonConvert.DeserializeObject<clsvQxPrjFileRelaEN>(strJson);
return objvQxPrjFileRelaEN;
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
public static long GetFirstID(string strWhereCond)
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
return long.Parse(strReturnStr);
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
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsvQxPrjFileRelaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvQxPrjFileRelaEN objvQxPrjFileRelaEN;
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
objvQxPrjFileRelaEN = JsonConvert.DeserializeObject<clsvQxPrjFileRelaEN>(strJson);
return objvQxPrjFileRelaEN;
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
public static List<clsvQxPrjFileRelaEN> GetObjLst(string strWhereCond)
{
 List<clsvQxPrjFileRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjFileRelaEN>>(strJson);
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
 /// <param name = "arrMId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjFileRelaEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvQxPrjFileRelaEN> arrObjLst; 
string strAction = "GetObjLstByMIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjFileRelaEN>>(strJson);
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
public static List<clsvQxPrjFileRelaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvQxPrjFileRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjFileRelaEN>>(strJson);
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
public static List<clsvQxPrjFileRelaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvQxPrjFileRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjFileRelaEN>>(strJson);
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
public static List<clsvQxPrjFileRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvQxPrjFileRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjFileRelaEN>>(strJson);
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
public static List<clsvQxPrjFileRelaEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvQxPrjFileRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjFileRelaEN>>(strJson);
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
public static bool IsExist(long lngmId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngmId"] = lngmId.ToString()
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
public static DataTable ToDataTable(List<clsvQxPrjFileRelaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvQxPrjFileRelaEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvQxPrjFileRelaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvQxPrjFileRelaEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvQxPrjFileRelaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvQxPrjFileRelaEN.AttributeName)
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
//该表没有使用Cache,不需要生成[GetObjLstCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvQxPrjFileRelaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convQxPrjFileRela.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convQxPrjFileRela.QxPrjId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjFileRela.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjFileRela.FileName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjFileRela.Version, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjFileRela.FilePath, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjFileRela.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjFileRela.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjFileRela.IsNeedDownLoad, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQxPrjFileRela.Memo, Type.GetType("System.String"));
foreach (clsvQxPrjFileRelaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convQxPrjFileRela.mId] = objInFor[convQxPrjFileRela.mId];
objDR[convQxPrjFileRela.QxPrjId] = objInFor[convQxPrjFileRela.QxPrjId];
objDR[convQxPrjFileRela.PrjName] = objInFor[convQxPrjFileRela.PrjName];
objDR[convQxPrjFileRela.FileName] = objInFor[convQxPrjFileRela.FileName];
objDR[convQxPrjFileRela.Version] = objInFor[convQxPrjFileRela.Version];
objDR[convQxPrjFileRela.FilePath] = objInFor[convQxPrjFileRela.FilePath];
objDR[convQxPrjFileRela.UpdDate] = objInFor[convQxPrjFileRela.UpdDate];
objDR[convQxPrjFileRela.UpdUserId] = objInFor[convQxPrjFileRela.UpdUserId];
objDR[convQxPrjFileRela.IsNeedDownLoad] = objInFor[convQxPrjFileRela.IsNeedDownLoad];
objDR[convQxPrjFileRela.Memo] = objInFor[convQxPrjFileRela.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}