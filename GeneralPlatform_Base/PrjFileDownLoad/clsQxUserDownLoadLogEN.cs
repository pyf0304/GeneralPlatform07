
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUserDownLoadLogEN
 表名:QxUserDownLoadLog(00140058)
 生成代码版本:2019.07.11.1
 生成日期:2019/07/12 10:01:10
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:工程文件下载
 模块英文名:PrjFileDownLoad
 框架-层名:实体层(EntityLayer)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
using System;
using System.Text; 
using System.Collections; 
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System.Runtime.Serialization;

namespace GeneralPlatform.Entity
{
 /// <summary>
 /// 表QxUserDownLoadLog的关键字(UserDownLoadLogId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public struct K_UserDownLoadLogId_QxUserDownLoadLog
{
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get; }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strUserDownLoadLogId">表关键字</param>
public K_UserDownLoadLogId_QxUserDownLoadLog(string strUserDownLoadLogId)
{
if (IsValid(strUserDownLoadLogId)) Value = strUserDownLoadLogId;
else
{
Value = null;
}
}
private static bool IsValid(string strUserDownLoadLogId)
{
if (string.IsNullOrEmpty(strUserDownLoadLogId) == true) return false;
if (strUserDownLoadLogId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_UserDownLoadLogId_QxUserDownLoadLog]类型的对象</returns>
public static implicit operator K_UserDownLoadLogId_QxUserDownLoadLog(string value)
{
return new K_UserDownLoadLogId_QxUserDownLoadLog(value);
}
}
 /// <summary>
 /// 用户下载日志(QxUserDownLoadLog)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQxUserDownLoadLogEN : clsEntityBase2
{
public const string _CurrTabName_S = "QxUserDownLoadLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "UserDownLoadLogId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"UserDownLoadLogId", "UserId", "PrjSiteId", "DownLownDate", "IsSuccess", "LogInfo", "Memo"};
//以下是属性变量

protected string mstrUserDownLoadLogId;    //用户下载日志Id
protected string mstrUserId;    //用户ID
protected string mstrPrjSiteId;    //工程站点Id
protected string mstrDownLownDate;    //下载日期
protected bool mbolIsSuccess;    //是否成功
protected string mstrLogInfo;    //日志信息
protected string mstrMemo;    //备注


 /// <summary>
 /// 常量:"UserDownLoadLogId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UserDownLoadLogId = "UserDownLoadLogId";    //用户下载日志Id

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"PrjSiteId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PrjSiteId = "PrjSiteId";    //工程站点Id

 /// <summary>
 /// 常量:"DownLownDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_DownLownDate = "DownLownDate";    //下载日期

 /// <summary>
 /// 常量:"IsSuccess"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsSuccess = "IsSuccess";    //是否成功

 /// <summary>
 /// 常量:"LogInfo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_LogInfo = "LogInfo";    //日志信息

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo = "Memo";    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQxUserDownLoadLogEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "QxUserDownLoadLog";
 lstKeyFldNames.Add("UserDownLoadLogId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strUserDownLoadLogId">关键字:用户下载日志Id</param>
public clsQxUserDownLoadLogEN(string strUserDownLoadLogId)
 {
strUserDownLoadLogId = strUserDownLoadLogId.Replace("'", "''");
if (strUserDownLoadLogId.Length > 8)
{
throw new Exception("在表:QxUserDownLoadLog中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strUserDownLoadLogId)  ==  true)
{
throw new Exception("在表:QxUserDownLoadLog中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strUserDownLoadLogId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrUserDownLoadLogId = strUserDownLoadLogId;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "QxUserDownLoadLog";
 lstKeyFldNames.Add("UserDownLoadLogId");
 }

public static int AttributeCount
{
get
{
return mintAttributeCount;
}
}
public override object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  con_UserDownLoadLogId)
{
return mstrUserDownLoadLogId;
}
else if (strAttributeName  ==  con_UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  con_PrjSiteId)
{
return mstrPrjSiteId;
}
else if (strAttributeName  ==  con_DownLownDate)
{
return mstrDownLownDate;
}
else if (strAttributeName  ==  con_IsSuccess)
{
return mbolIsSuccess;
}
else if (strAttributeName  ==  con_LogInfo)
{
return mstrLogInfo;
}
else if (strAttributeName  ==  con_Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  con_UserDownLoadLogId)
{
mstrUserDownLoadLogId = value.ToString();
 AddUpdatedFld(con_UserDownLoadLogId);
}
else if (strAttributeName  ==  con_UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(con_UserId);
}
else if (strAttributeName  ==  con_PrjSiteId)
{
mstrPrjSiteId = value.ToString();
 AddUpdatedFld(con_PrjSiteId);
}
else if (strAttributeName  ==  con_DownLownDate)
{
mstrDownLownDate = value.ToString();
 AddUpdatedFld(con_DownLownDate);
}
else if (strAttributeName  ==  con_IsSuccess)
{
mbolIsSuccess = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsSuccess);
}
else if (strAttributeName  ==  con_LogInfo)
{
mstrLogInfo = value.ToString();
 AddUpdatedFld(con_LogInfo);
}
else if (strAttributeName  ==  con_Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (con_UserDownLoadLogId  ==  AttributeName[intIndex])
{
return mstrUserDownLoadLogId;
}
else if (con_UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (con_PrjSiteId  ==  AttributeName[intIndex])
{
return mstrPrjSiteId;
}
else if (con_DownLownDate  ==  AttributeName[intIndex])
{
return mstrDownLownDate;
}
else if (con_IsSuccess  ==  AttributeName[intIndex])
{
return mbolIsSuccess;
}
else if (con_LogInfo  ==  AttributeName[intIndex])
{
return mstrLogInfo;
}
else if (con_Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (con_UserDownLoadLogId  ==  AttributeName[intIndex])
{
mstrUserDownLoadLogId = value.ToString();
 AddUpdatedFld(con_UserDownLoadLogId);
}
else if (con_UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(con_UserId);
}
else if (con_PrjSiteId  ==  AttributeName[intIndex])
{
mstrPrjSiteId = value.ToString();
 AddUpdatedFld(con_PrjSiteId);
}
else if (con_DownLownDate  ==  AttributeName[intIndex])
{
mstrDownLownDate = value.ToString();
 AddUpdatedFld(con_DownLownDate);
}
else if (con_IsSuccess  ==  AttributeName[intIndex])
{
mbolIsSuccess = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsSuccess);
}
else if (con_LogInfo  ==  AttributeName[intIndex])
{
mstrLogInfo = value.ToString();
 AddUpdatedFld(con_LogInfo);
}
else if (con_Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
}
}
}

/// <summary>
/// 用户下载日志Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserDownLoadLogId
{
get
{
return mstrUserDownLoadLogId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserDownLoadLogId = value;
}
else
{
 mstrUserDownLoadLogId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_UserDownLoadLogId);
}
}
/// <summary>
/// 用户ID(说明:;字段类型:varchar;字段长度:18;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserId
{
get
{
return mstrUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserId = value;
}
else
{
 mstrUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_UserId);
}
}
/// <summary>
/// 工程站点Id(说明:;字段类型:char;字段长度:6;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjSiteId
{
get
{
return mstrPrjSiteId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjSiteId = value;
}
else
{
 mstrPrjSiteId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_PrjSiteId);
}
}
/// <summary>
/// 下载日期(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DownLownDate
{
get
{
return mstrDownLownDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDownLownDate = value;
}
else
{
 mstrDownLownDate = value;
}
//记录修改过的字段
 AddUpdatedFld(con_DownLownDate);
}
}
/// <summary>
/// 是否成功(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsSuccess
{
get
{
return mbolIsSuccess;
}
set
{
 mbolIsSuccess = value;
//记录修改过的字段
 AddUpdatedFld(con_IsSuccess);
}
}
/// <summary>
/// 日志信息(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LogInfo
{
get
{
return mstrLogInfo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLogInfo = value;
}
else
{
 mstrLogInfo = value;
}
//记录修改过的字段
 AddUpdatedFld(con_LogInfo);
}
}
/// <summary>
/// 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Memo
{
get
{
return mstrMemo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMemo = value;
}
else
{
 mstrMemo = value;
}
//记录修改过的字段
 AddUpdatedFld(con_Memo);
}
}

/// <summary>
/// 获取关键字Id(KeyId)
 /// (AutoGCLib.clsGeneCodeBase:GenGetKeyId)
/// </summary>
 public override string _KeyId
 {
 get
 {
  return mstrUserDownLoadLogId;
 }
 }
}
}