
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUserDownLoadLogEN
 表名:QxUserDownLoadLog(00140058)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:19:04
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:工程文件下载(PrjFileDownLoad)
 框架-层名:实体层(CS)(EntityLayer)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Text; 
using System.Collections; 

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
public class K_UserDownLoadLogId_QxUserDownLoadLog
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
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
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
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
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "QxUserDownLoadLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "UserDownLoadLogId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"UserDownLoadLogId", "UserId", "PrjSiteId", "DownLownDate", "IsSuccess", "LogInfo", "Memo"};

protected string mstrUserDownLoadLogId;    //用户下载日志Id
protected string mstrUserId;    //用户ID
protected string mstrPrjSiteId;    //工程站点Id
protected string mstrDownLownDate;    //下载日期
protected bool mbolIsSuccess;    //是否成功
protected string mstrLogInfo;    //日志信息
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQxUserDownLoadLogEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
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
if (strAttributeName  ==  conQxUserDownLoadLog.UserDownLoadLogId)
{
return mstrUserDownLoadLogId;
}
else if (strAttributeName  ==  conQxUserDownLoadLog.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conQxUserDownLoadLog.PrjSiteId)
{
return mstrPrjSiteId;
}
else if (strAttributeName  ==  conQxUserDownLoadLog.DownLownDate)
{
return mstrDownLownDate;
}
else if (strAttributeName  ==  conQxUserDownLoadLog.IsSuccess)
{
return mbolIsSuccess;
}
else if (strAttributeName  ==  conQxUserDownLoadLog.LogInfo)
{
return mstrLogInfo;
}
else if (strAttributeName  ==  conQxUserDownLoadLog.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conQxUserDownLoadLog.UserDownLoadLogId)
{
mstrUserDownLoadLogId = value.ToString();
 AddUpdatedFld(conQxUserDownLoadLog.UserDownLoadLogId);
}
else if (strAttributeName  ==  conQxUserDownLoadLog.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conQxUserDownLoadLog.UserId);
}
else if (strAttributeName  ==  conQxUserDownLoadLog.PrjSiteId)
{
mstrPrjSiteId = value.ToString();
 AddUpdatedFld(conQxUserDownLoadLog.PrjSiteId);
}
else if (strAttributeName  ==  conQxUserDownLoadLog.DownLownDate)
{
mstrDownLownDate = value.ToString();
 AddUpdatedFld(conQxUserDownLoadLog.DownLownDate);
}
else if (strAttributeName  ==  conQxUserDownLoadLog.IsSuccess)
{
mbolIsSuccess = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxUserDownLoadLog.IsSuccess);
}
else if (strAttributeName  ==  conQxUserDownLoadLog.LogInfo)
{
mstrLogInfo = value.ToString();
 AddUpdatedFld(conQxUserDownLoadLog.LogInfo);
}
else if (strAttributeName  ==  conQxUserDownLoadLog.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxUserDownLoadLog.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conQxUserDownLoadLog.UserDownLoadLogId  ==  AttributeName[intIndex])
{
return mstrUserDownLoadLogId;
}
else if (conQxUserDownLoadLog.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conQxUserDownLoadLog.PrjSiteId  ==  AttributeName[intIndex])
{
return mstrPrjSiteId;
}
else if (conQxUserDownLoadLog.DownLownDate  ==  AttributeName[intIndex])
{
return mstrDownLownDate;
}
else if (conQxUserDownLoadLog.IsSuccess  ==  AttributeName[intIndex])
{
return mbolIsSuccess;
}
else if (conQxUserDownLoadLog.LogInfo  ==  AttributeName[intIndex])
{
return mstrLogInfo;
}
else if (conQxUserDownLoadLog.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conQxUserDownLoadLog.UserDownLoadLogId  ==  AttributeName[intIndex])
{
mstrUserDownLoadLogId = value.ToString();
 AddUpdatedFld(conQxUserDownLoadLog.UserDownLoadLogId);
}
else if (conQxUserDownLoadLog.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conQxUserDownLoadLog.UserId);
}
else if (conQxUserDownLoadLog.PrjSiteId  ==  AttributeName[intIndex])
{
mstrPrjSiteId = value.ToString();
 AddUpdatedFld(conQxUserDownLoadLog.PrjSiteId);
}
else if (conQxUserDownLoadLog.DownLownDate  ==  AttributeName[intIndex])
{
mstrDownLownDate = value.ToString();
 AddUpdatedFld(conQxUserDownLoadLog.DownLownDate);
}
else if (conQxUserDownLoadLog.IsSuccess  ==  AttributeName[intIndex])
{
mbolIsSuccess = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxUserDownLoadLog.IsSuccess);
}
else if (conQxUserDownLoadLog.LogInfo  ==  AttributeName[intIndex])
{
mstrLogInfo = value.ToString();
 AddUpdatedFld(conQxUserDownLoadLog.LogInfo);
}
else if (conQxUserDownLoadLog.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxUserDownLoadLog.Memo);
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
 AddUpdatedFld(conQxUserDownLoadLog.UserDownLoadLogId);
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
 AddUpdatedFld(conQxUserDownLoadLog.UserId);
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
 AddUpdatedFld(conQxUserDownLoadLog.PrjSiteId);
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
 AddUpdatedFld(conQxUserDownLoadLog.DownLownDate);
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
 AddUpdatedFld(conQxUserDownLoadLog.IsSuccess);
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
 AddUpdatedFld(conQxUserDownLoadLog.LogInfo);
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
 AddUpdatedFld(conQxUserDownLoadLog.Memo);
}
}

/// <summary>
/// 获取关键字Id(keyId)
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
 /// <summary>
 /// 用户下载日志(QxUserDownLoadLog)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conQxUserDownLoadLog
{
public const string _CurrTabName = "QxUserDownLoadLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "UserDownLoadLogId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"UserDownLoadLogId", "UserId", "PrjSiteId", "DownLownDate", "IsSuccess", "LogInfo", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"UserDownLoadLogId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserDownLoadLogId = "UserDownLoadLogId";    //用户下载日志Id

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"PrjSiteId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjSiteId = "PrjSiteId";    //工程站点Id

 /// <summary>
 /// 常量:"DownLownDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DownLownDate = "DownLownDate";    //下载日期

 /// <summary>
 /// 常量:"IsSuccess"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSuccess = "IsSuccess";    //是否成功

 /// <summary>
 /// 常量:"LogInfo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LogInfo = "LogInfo";    //日志信息

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}