
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUserDownLoadDetailLogEN
 表名:QxUserDownLoadDetailLog(00140059)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:18:51
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
 /// 表QxUserDownLoadDetailLog的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_QxUserDownLoadDetailLog
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
public K_mId_QxUserDownLoadDetailLog(long lngmId)
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
 /// <returns>返回:[K_mId_QxUserDownLoadDetailLog]类型的对象</returns>
public static implicit operator K_mId_QxUserDownLoadDetailLog(long value)
{
return new K_mId_QxUserDownLoadDetailLog(value);
}
}
 /// <summary>
 /// 用户下载日志细节(QxUserDownLoadDetailLog)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQxUserDownLoadDetailLogEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "QxUserDownLoadDetailLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"mId", "UserDownLoadLogId", "FileName", "Version", "IsSuccess", "LogInfo", "Memo"};

protected long mlngmId;    //流水号
protected string mstrUserDownLoadLogId;    //用户下载日志Id
protected string mstrFileName;    //文件名
protected string mstrVersion;    //版本
protected bool mbolIsSuccess;    //是否成功
protected string mstrLogInfo;    //日志信息
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQxUserDownLoadDetailLogEN()
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
public clsQxUserDownLoadDetailLogEN(long lngmId)
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
if (strAttributeName  ==  conQxUserDownLoadDetailLog.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conQxUserDownLoadDetailLog.UserDownLoadLogId)
{
return mstrUserDownLoadLogId;
}
else if (strAttributeName  ==  conQxUserDownLoadDetailLog.FileName)
{
return mstrFileName;
}
else if (strAttributeName  ==  conQxUserDownLoadDetailLog.Version)
{
return mstrVersion;
}
else if (strAttributeName  ==  conQxUserDownLoadDetailLog.IsSuccess)
{
return mbolIsSuccess;
}
else if (strAttributeName  ==  conQxUserDownLoadDetailLog.LogInfo)
{
return mstrLogInfo;
}
else if (strAttributeName  ==  conQxUserDownLoadDetailLog.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conQxUserDownLoadDetailLog.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxUserDownLoadDetailLog.mId);
}
else if (strAttributeName  ==  conQxUserDownLoadDetailLog.UserDownLoadLogId)
{
mstrUserDownLoadLogId = value.ToString();
 AddUpdatedFld(conQxUserDownLoadDetailLog.UserDownLoadLogId);
}
else if (strAttributeName  ==  conQxUserDownLoadDetailLog.FileName)
{
mstrFileName = value.ToString();
 AddUpdatedFld(conQxUserDownLoadDetailLog.FileName);
}
else if (strAttributeName  ==  conQxUserDownLoadDetailLog.Version)
{
mstrVersion = value.ToString();
 AddUpdatedFld(conQxUserDownLoadDetailLog.Version);
}
else if (strAttributeName  ==  conQxUserDownLoadDetailLog.IsSuccess)
{
mbolIsSuccess = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxUserDownLoadDetailLog.IsSuccess);
}
else if (strAttributeName  ==  conQxUserDownLoadDetailLog.LogInfo)
{
mstrLogInfo = value.ToString();
 AddUpdatedFld(conQxUserDownLoadDetailLog.LogInfo);
}
else if (strAttributeName  ==  conQxUserDownLoadDetailLog.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxUserDownLoadDetailLog.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conQxUserDownLoadDetailLog.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conQxUserDownLoadDetailLog.UserDownLoadLogId  ==  AttributeName[intIndex])
{
return mstrUserDownLoadLogId;
}
else if (conQxUserDownLoadDetailLog.FileName  ==  AttributeName[intIndex])
{
return mstrFileName;
}
else if (conQxUserDownLoadDetailLog.Version  ==  AttributeName[intIndex])
{
return mstrVersion;
}
else if (conQxUserDownLoadDetailLog.IsSuccess  ==  AttributeName[intIndex])
{
return mbolIsSuccess;
}
else if (conQxUserDownLoadDetailLog.LogInfo  ==  AttributeName[intIndex])
{
return mstrLogInfo;
}
else if (conQxUserDownLoadDetailLog.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conQxUserDownLoadDetailLog.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxUserDownLoadDetailLog.mId);
}
else if (conQxUserDownLoadDetailLog.UserDownLoadLogId  ==  AttributeName[intIndex])
{
mstrUserDownLoadLogId = value.ToString();
 AddUpdatedFld(conQxUserDownLoadDetailLog.UserDownLoadLogId);
}
else if (conQxUserDownLoadDetailLog.FileName  ==  AttributeName[intIndex])
{
mstrFileName = value.ToString();
 AddUpdatedFld(conQxUserDownLoadDetailLog.FileName);
}
else if (conQxUserDownLoadDetailLog.Version  ==  AttributeName[intIndex])
{
mstrVersion = value.ToString();
 AddUpdatedFld(conQxUserDownLoadDetailLog.Version);
}
else if (conQxUserDownLoadDetailLog.IsSuccess  ==  AttributeName[intIndex])
{
mbolIsSuccess = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxUserDownLoadDetailLog.IsSuccess);
}
else if (conQxUserDownLoadDetailLog.LogInfo  ==  AttributeName[intIndex])
{
mstrLogInfo = value.ToString();
 AddUpdatedFld(conQxUserDownLoadDetailLog.LogInfo);
}
else if (conQxUserDownLoadDetailLog.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxUserDownLoadDetailLog.Memo);
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
 AddUpdatedFld(conQxUserDownLoadDetailLog.mId);
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
 AddUpdatedFld(conQxUserDownLoadDetailLog.UserDownLoadLogId);
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
 AddUpdatedFld(conQxUserDownLoadDetailLog.FileName);
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
 AddUpdatedFld(conQxUserDownLoadDetailLog.Version);
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
 AddUpdatedFld(conQxUserDownLoadDetailLog.IsSuccess);
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
 AddUpdatedFld(conQxUserDownLoadDetailLog.LogInfo);
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
 AddUpdatedFld(conQxUserDownLoadDetailLog.Memo);
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
 /// 用户下载日志细节(QxUserDownLoadDetailLog)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conQxUserDownLoadDetailLog
{
public const string _CurrTabName = "QxUserDownLoadDetailLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "UserDownLoadLogId", "FileName", "Version", "IsSuccess", "LogInfo", "Memo"};
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