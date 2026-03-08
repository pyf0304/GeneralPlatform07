
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUserDownLoadDetailLogEN
 表名:vQxUserDownLoadDetailLog(00140063)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 17:47:33
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
 /// 表vQxUserDownLoadDetailLog的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vQxUserDownLoadDetailLog
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngmId">表关键字</param>
public K_mId_vQxUserDownLoadDetailLog(long lngmId)
{
if (IsValid(lngmId)) Value = lngmId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngmId)
{
if (lngmId == 0) return false;
if (lngmId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_mId_vQxUserDownLoadDetailLog]类型的对象</returns>
public static implicit operator K_mId_vQxUserDownLoadDetailLog(long value)
{
return new K_mId_vQxUserDownLoadDetailLog(value);
}
}
 /// <summary>
 /// v用户下载日志细节(vQxUserDownLoadDetailLog)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvQxUserDownLoadDetailLogEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vQxUserDownLoadDetailLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 16;
public static string[] AttributeName = new string[] {"mId", "UserDownLoadLogId", "PrjSiteId", "PrjSiteName", "QxPrjId", "PrjName", "UserId", "FileName", "Version", "DownLownDate", "IsSuccess", "LogInfo", "FtpServer", "FtpUserId", "FtpUserPassword", "Memo"};

protected long mlngmId;    //流水号
protected string mstrUserDownLoadLogId;    //用户下载日志Id
protected string mstrPrjSiteId;    //工程站点Id
protected string mstrPrjSiteName;    //工程站点名
protected string mstrQxPrjId;    //项目Id
protected string mstrPrjName;    //工程名
protected string mstrUserId;    //用户ID
protected string mstrFileName;    //文件名
protected string mstrVersion;    //版本
protected string mstrDownLownDate;    //下载日期
protected bool mbolIsSuccess;    //是否成功
protected string mstrLogInfo;    //日志信息
protected string mstrFtpServer;    //Ftp服务器
protected string mstrFtpUserId;    //Ftp用户Id
protected string mstrFtpUserPassword;    //Ftp用户口令
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvQxUserDownLoadDetailLogEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:流水号</param>
public clsvQxUserDownLoadDetailLogEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
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
if (strAttributeName  ==  convQxUserDownLoadDetailLog.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convQxUserDownLoadDetailLog.UserDownLoadLogId)
{
return mstrUserDownLoadLogId;
}
else if (strAttributeName  ==  convQxUserDownLoadDetailLog.PrjSiteId)
{
return mstrPrjSiteId;
}
else if (strAttributeName  ==  convQxUserDownLoadDetailLog.PrjSiteName)
{
return mstrPrjSiteName;
}
else if (strAttributeName  ==  convQxUserDownLoadDetailLog.QxPrjId)
{
return mstrQxPrjId;
}
else if (strAttributeName  ==  convQxUserDownLoadDetailLog.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convQxUserDownLoadDetailLog.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convQxUserDownLoadDetailLog.FileName)
{
return mstrFileName;
}
else if (strAttributeName  ==  convQxUserDownLoadDetailLog.Version)
{
return mstrVersion;
}
else if (strAttributeName  ==  convQxUserDownLoadDetailLog.DownLownDate)
{
return mstrDownLownDate;
}
else if (strAttributeName  ==  convQxUserDownLoadDetailLog.IsSuccess)
{
return mbolIsSuccess;
}
else if (strAttributeName  ==  convQxUserDownLoadDetailLog.LogInfo)
{
return mstrLogInfo;
}
else if (strAttributeName  ==  convQxUserDownLoadDetailLog.FtpServer)
{
return mstrFtpServer;
}
else if (strAttributeName  ==  convQxUserDownLoadDetailLog.FtpUserId)
{
return mstrFtpUserId;
}
else if (strAttributeName  ==  convQxUserDownLoadDetailLog.FtpUserPassword)
{
return mstrFtpUserPassword;
}
else if (strAttributeName  ==  convQxUserDownLoadDetailLog.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convQxUserDownLoadDetailLog.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxUserDownLoadDetailLog.mId);
}
else if (strAttributeName  ==  convQxUserDownLoadDetailLog.UserDownLoadLogId)
{
mstrUserDownLoadLogId = value.ToString();
 AddUpdatedFld(convQxUserDownLoadDetailLog.UserDownLoadLogId);
}
else if (strAttributeName  ==  convQxUserDownLoadDetailLog.PrjSiteId)
{
mstrPrjSiteId = value.ToString();
 AddUpdatedFld(convQxUserDownLoadDetailLog.PrjSiteId);
}
else if (strAttributeName  ==  convQxUserDownLoadDetailLog.PrjSiteName)
{
mstrPrjSiteName = value.ToString();
 AddUpdatedFld(convQxUserDownLoadDetailLog.PrjSiteName);
}
else if (strAttributeName  ==  convQxUserDownLoadDetailLog.QxPrjId)
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(convQxUserDownLoadDetailLog.QxPrjId);
}
else if (strAttributeName  ==  convQxUserDownLoadDetailLog.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convQxUserDownLoadDetailLog.PrjName);
}
else if (strAttributeName  ==  convQxUserDownLoadDetailLog.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convQxUserDownLoadDetailLog.UserId);
}
else if (strAttributeName  ==  convQxUserDownLoadDetailLog.FileName)
{
mstrFileName = value.ToString();
 AddUpdatedFld(convQxUserDownLoadDetailLog.FileName);
}
else if (strAttributeName  ==  convQxUserDownLoadDetailLog.Version)
{
mstrVersion = value.ToString();
 AddUpdatedFld(convQxUserDownLoadDetailLog.Version);
}
else if (strAttributeName  ==  convQxUserDownLoadDetailLog.DownLownDate)
{
mstrDownLownDate = value.ToString();
 AddUpdatedFld(convQxUserDownLoadDetailLog.DownLownDate);
}
else if (strAttributeName  ==  convQxUserDownLoadDetailLog.IsSuccess)
{
mbolIsSuccess = TransNullToBool(value.ToString());
 AddUpdatedFld(convQxUserDownLoadDetailLog.IsSuccess);
}
else if (strAttributeName  ==  convQxUserDownLoadDetailLog.LogInfo)
{
mstrLogInfo = value.ToString();
 AddUpdatedFld(convQxUserDownLoadDetailLog.LogInfo);
}
else if (strAttributeName  ==  convQxUserDownLoadDetailLog.FtpServer)
{
mstrFtpServer = value.ToString();
 AddUpdatedFld(convQxUserDownLoadDetailLog.FtpServer);
}
else if (strAttributeName  ==  convQxUserDownLoadDetailLog.FtpUserId)
{
mstrFtpUserId = value.ToString();
 AddUpdatedFld(convQxUserDownLoadDetailLog.FtpUserId);
}
else if (strAttributeName  ==  convQxUserDownLoadDetailLog.FtpUserPassword)
{
mstrFtpUserPassword = value.ToString();
 AddUpdatedFld(convQxUserDownLoadDetailLog.FtpUserPassword);
}
else if (strAttributeName  ==  convQxUserDownLoadDetailLog.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQxUserDownLoadDetailLog.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convQxUserDownLoadDetailLog.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convQxUserDownLoadDetailLog.UserDownLoadLogId  ==  AttributeName[intIndex])
{
return mstrUserDownLoadLogId;
}
else if (convQxUserDownLoadDetailLog.PrjSiteId  ==  AttributeName[intIndex])
{
return mstrPrjSiteId;
}
else if (convQxUserDownLoadDetailLog.PrjSiteName  ==  AttributeName[intIndex])
{
return mstrPrjSiteName;
}
else if (convQxUserDownLoadDetailLog.QxPrjId  ==  AttributeName[intIndex])
{
return mstrQxPrjId;
}
else if (convQxUserDownLoadDetailLog.PrjName  ==  AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convQxUserDownLoadDetailLog.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convQxUserDownLoadDetailLog.FileName  ==  AttributeName[intIndex])
{
return mstrFileName;
}
else if (convQxUserDownLoadDetailLog.Version  ==  AttributeName[intIndex])
{
return mstrVersion;
}
else if (convQxUserDownLoadDetailLog.DownLownDate  ==  AttributeName[intIndex])
{
return mstrDownLownDate;
}
else if (convQxUserDownLoadDetailLog.IsSuccess  ==  AttributeName[intIndex])
{
return mbolIsSuccess;
}
else if (convQxUserDownLoadDetailLog.LogInfo  ==  AttributeName[intIndex])
{
return mstrLogInfo;
}
else if (convQxUserDownLoadDetailLog.FtpServer  ==  AttributeName[intIndex])
{
return mstrFtpServer;
}
else if (convQxUserDownLoadDetailLog.FtpUserId  ==  AttributeName[intIndex])
{
return mstrFtpUserId;
}
else if (convQxUserDownLoadDetailLog.FtpUserPassword  ==  AttributeName[intIndex])
{
return mstrFtpUserPassword;
}
else if (convQxUserDownLoadDetailLog.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convQxUserDownLoadDetailLog.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxUserDownLoadDetailLog.mId);
}
else if (convQxUserDownLoadDetailLog.UserDownLoadLogId  ==  AttributeName[intIndex])
{
mstrUserDownLoadLogId = value.ToString();
 AddUpdatedFld(convQxUserDownLoadDetailLog.UserDownLoadLogId);
}
else if (convQxUserDownLoadDetailLog.PrjSiteId  ==  AttributeName[intIndex])
{
mstrPrjSiteId = value.ToString();
 AddUpdatedFld(convQxUserDownLoadDetailLog.PrjSiteId);
}
else if (convQxUserDownLoadDetailLog.PrjSiteName  ==  AttributeName[intIndex])
{
mstrPrjSiteName = value.ToString();
 AddUpdatedFld(convQxUserDownLoadDetailLog.PrjSiteName);
}
else if (convQxUserDownLoadDetailLog.QxPrjId  ==  AttributeName[intIndex])
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(convQxUserDownLoadDetailLog.QxPrjId);
}
else if (convQxUserDownLoadDetailLog.PrjName  ==  AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convQxUserDownLoadDetailLog.PrjName);
}
else if (convQxUserDownLoadDetailLog.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convQxUserDownLoadDetailLog.UserId);
}
else if (convQxUserDownLoadDetailLog.FileName  ==  AttributeName[intIndex])
{
mstrFileName = value.ToString();
 AddUpdatedFld(convQxUserDownLoadDetailLog.FileName);
}
else if (convQxUserDownLoadDetailLog.Version  ==  AttributeName[intIndex])
{
mstrVersion = value.ToString();
 AddUpdatedFld(convQxUserDownLoadDetailLog.Version);
}
else if (convQxUserDownLoadDetailLog.DownLownDate  ==  AttributeName[intIndex])
{
mstrDownLownDate = value.ToString();
 AddUpdatedFld(convQxUserDownLoadDetailLog.DownLownDate);
}
else if (convQxUserDownLoadDetailLog.IsSuccess  ==  AttributeName[intIndex])
{
mbolIsSuccess = TransNullToBool(value.ToString());
 AddUpdatedFld(convQxUserDownLoadDetailLog.IsSuccess);
}
else if (convQxUserDownLoadDetailLog.LogInfo  ==  AttributeName[intIndex])
{
mstrLogInfo = value.ToString();
 AddUpdatedFld(convQxUserDownLoadDetailLog.LogInfo);
}
else if (convQxUserDownLoadDetailLog.FtpServer  ==  AttributeName[intIndex])
{
mstrFtpServer = value.ToString();
 AddUpdatedFld(convQxUserDownLoadDetailLog.FtpServer);
}
else if (convQxUserDownLoadDetailLog.FtpUserId  ==  AttributeName[intIndex])
{
mstrFtpUserId = value.ToString();
 AddUpdatedFld(convQxUserDownLoadDetailLog.FtpUserId);
}
else if (convQxUserDownLoadDetailLog.FtpUserPassword  ==  AttributeName[intIndex])
{
mstrFtpUserPassword = value.ToString();
 AddUpdatedFld(convQxUserDownLoadDetailLog.FtpUserPassword);
}
else if (convQxUserDownLoadDetailLog.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQxUserDownLoadDetailLog.Memo);
}
}
}

/// <summary>
/// 流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long mId
{
get
{
return mlngmId;
}
set
{
 mlngmId = value;
//记录修改过的字段
 AddUpdatedFld(convQxUserDownLoadDetailLog.mId);
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
 AddUpdatedFld(convQxUserDownLoadDetailLog.UserDownLoadLogId);
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
 AddUpdatedFld(convQxUserDownLoadDetailLog.PrjSiteId);
}
}
/// <summary>
/// 工程站点名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjSiteName
{
get
{
return mstrPrjSiteName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjSiteName = value;
}
else
{
 mstrPrjSiteName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUserDownLoadDetailLog.PrjSiteName);
}
}
/// <summary>
/// 项目Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QxPrjId
{
get
{
return mstrQxPrjId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQxPrjId = value;
}
else
{
 mstrQxPrjId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUserDownLoadDetailLog.QxPrjId);
}
}
/// <summary>
/// 工程名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjName
{
get
{
return mstrPrjName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjName = value;
}
else
{
 mstrPrjName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUserDownLoadDetailLog.PrjName);
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
 AddUpdatedFld(convQxUserDownLoadDetailLog.UserId);
}
}
/// <summary>
/// 文件名(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FileName
{
get
{
return mstrFileName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFileName = value;
}
else
{
 mstrFileName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUserDownLoadDetailLog.FileName);
}
}
/// <summary>
/// 版本(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Version
{
get
{
return mstrVersion;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVersion = value;
}
else
{
 mstrVersion = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUserDownLoadDetailLog.Version);
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
 AddUpdatedFld(convQxUserDownLoadDetailLog.DownLownDate);
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
 AddUpdatedFld(convQxUserDownLoadDetailLog.IsSuccess);
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
 AddUpdatedFld(convQxUserDownLoadDetailLog.LogInfo);
}
}
/// <summary>
/// Ftp服务器(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FtpServer
{
get
{
return mstrFtpServer;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFtpServer = value;
}
else
{
 mstrFtpServer = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUserDownLoadDetailLog.FtpServer);
}
}
/// <summary>
/// Ftp用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FtpUserId
{
get
{
return mstrFtpUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFtpUserId = value;
}
else
{
 mstrFtpUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUserDownLoadDetailLog.FtpUserId);
}
}
/// <summary>
/// Ftp用户口令(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FtpUserPassword
{
get
{
return mstrFtpUserPassword;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFtpUserPassword = value;
}
else
{
 mstrFtpUserPassword = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUserDownLoadDetailLog.FtpUserPassword);
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
 AddUpdatedFld(convQxUserDownLoadDetailLog.Memo);
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
  return mlngmId.ToString();
 }
 }
}
 /// <summary>
 /// v用户下载日志细节(vQxUserDownLoadDetailLog)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convQxUserDownLoadDetailLog
{
public const string _CurrTabName = "vQxUserDownLoadDetailLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "UserDownLoadLogId", "PrjSiteId", "PrjSiteName", "QxPrjId", "PrjName", "UserId", "FileName", "Version", "DownLownDate", "IsSuccess", "LogInfo", "FtpServer", "FtpUserId", "FtpUserPassword", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //流水号

 /// <summary>
 /// 常量:"UserDownLoadLogId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserDownLoadLogId = "UserDownLoadLogId";    //用户下载日志Id

 /// <summary>
 /// 常量:"PrjSiteId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjSiteId = "PrjSiteId";    //工程站点Id

 /// <summary>
 /// 常量:"PrjSiteName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjSiteName = "PrjSiteName";    //工程站点名

 /// <summary>
 /// 常量:"QxPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QxPrjId = "QxPrjId";    //项目Id

 /// <summary>
 /// 常量:"PrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjName = "PrjName";    //工程名

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"FileName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileName = "FileName";    //文件名

 /// <summary>
 /// 常量:"Version"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Version = "Version";    //版本

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
 /// 常量:"FtpServer"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FtpServer = "FtpServer";    //Ftp服务器

 /// <summary>
 /// 常量:"FtpUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FtpUserId = "FtpUserId";    //Ftp用户Id

 /// <summary>
 /// 常量:"FtpUserPassword"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FtpUserPassword = "FtpUserPassword";    //Ftp用户口令

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}