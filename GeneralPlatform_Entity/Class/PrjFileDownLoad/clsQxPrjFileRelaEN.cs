
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxPrjFileRelaEN
 表名:QxPrjFileRela(00140054)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:28:59
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
 /// 表QxPrjFileRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_QxPrjFileRela
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
public K_mId_QxPrjFileRela(long lngmId)
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
 /// <returns>返回:[K_mId_QxPrjFileRela]类型的对象</returns>
public static implicit operator K_mId_QxPrjFileRela(long value)
{
return new K_mId_QxPrjFileRela(value);
}
}
 /// <summary>
 /// 项目相关文件(QxPrjFileRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQxPrjFileRelaEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "QxPrjFileRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"mId", "QxPrjId", "FileName", "FilePath", "IsNeedDownLoad", "Version", "UpdDate", "UpdUserId", "Memo"};

protected long mlngmId;    //流水号
protected string mstrQxPrjId;    //项目Id
protected string mstrFileName;    //文件名
protected string mstrFilePath;    //文件路径
protected bool mbolIsNeedDownLoad;    //是否需要下载
protected string mstrVersion;    //版本
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQxPrjFileRelaEN()
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
public clsQxPrjFileRelaEN(long lngmId)
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
if (strAttributeName  ==  conQxPrjFileRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conQxPrjFileRela.QxPrjId)
{
return mstrQxPrjId;
}
else if (strAttributeName  ==  conQxPrjFileRela.FileName)
{
return mstrFileName;
}
else if (strAttributeName  ==  conQxPrjFileRela.FilePath)
{
return mstrFilePath;
}
else if (strAttributeName  ==  conQxPrjFileRela.IsNeedDownLoad)
{
return mbolIsNeedDownLoad;
}
else if (strAttributeName  ==  conQxPrjFileRela.Version)
{
return mstrVersion;
}
else if (strAttributeName  ==  conQxPrjFileRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conQxPrjFileRela.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conQxPrjFileRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conQxPrjFileRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxPrjFileRela.mId);
}
else if (strAttributeName  ==  conQxPrjFileRela.QxPrjId)
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(conQxPrjFileRela.QxPrjId);
}
else if (strAttributeName  ==  conQxPrjFileRela.FileName)
{
mstrFileName = value.ToString();
 AddUpdatedFld(conQxPrjFileRela.FileName);
}
else if (strAttributeName  ==  conQxPrjFileRela.FilePath)
{
mstrFilePath = value.ToString();
 AddUpdatedFld(conQxPrjFileRela.FilePath);
}
else if (strAttributeName  ==  conQxPrjFileRela.IsNeedDownLoad)
{
mbolIsNeedDownLoad = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxPrjFileRela.IsNeedDownLoad);
}
else if (strAttributeName  ==  conQxPrjFileRela.Version)
{
mstrVersion = value.ToString();
 AddUpdatedFld(conQxPrjFileRela.Version);
}
else if (strAttributeName  ==  conQxPrjFileRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxPrjFileRela.UpdDate);
}
else if (strAttributeName  ==  conQxPrjFileRela.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conQxPrjFileRela.UpdUserId);
}
else if (strAttributeName  ==  conQxPrjFileRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxPrjFileRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conQxPrjFileRela.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conQxPrjFileRela.QxPrjId  ==  AttributeName[intIndex])
{
return mstrQxPrjId;
}
else if (conQxPrjFileRela.FileName  ==  AttributeName[intIndex])
{
return mstrFileName;
}
else if (conQxPrjFileRela.FilePath  ==  AttributeName[intIndex])
{
return mstrFilePath;
}
else if (conQxPrjFileRela.IsNeedDownLoad  ==  AttributeName[intIndex])
{
return mbolIsNeedDownLoad;
}
else if (conQxPrjFileRela.Version  ==  AttributeName[intIndex])
{
return mstrVersion;
}
else if (conQxPrjFileRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conQxPrjFileRela.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conQxPrjFileRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conQxPrjFileRela.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxPrjFileRela.mId);
}
else if (conQxPrjFileRela.QxPrjId  ==  AttributeName[intIndex])
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(conQxPrjFileRela.QxPrjId);
}
else if (conQxPrjFileRela.FileName  ==  AttributeName[intIndex])
{
mstrFileName = value.ToString();
 AddUpdatedFld(conQxPrjFileRela.FileName);
}
else if (conQxPrjFileRela.FilePath  ==  AttributeName[intIndex])
{
mstrFilePath = value.ToString();
 AddUpdatedFld(conQxPrjFileRela.FilePath);
}
else if (conQxPrjFileRela.IsNeedDownLoad  ==  AttributeName[intIndex])
{
mbolIsNeedDownLoad = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxPrjFileRela.IsNeedDownLoad);
}
else if (conQxPrjFileRela.Version  ==  AttributeName[intIndex])
{
mstrVersion = value.ToString();
 AddUpdatedFld(conQxPrjFileRela.Version);
}
else if (conQxPrjFileRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxPrjFileRela.UpdDate);
}
else if (conQxPrjFileRela.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conQxPrjFileRela.UpdUserId);
}
else if (conQxPrjFileRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxPrjFileRela.Memo);
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
 AddUpdatedFld(conQxPrjFileRela.mId);
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
 AddUpdatedFld(conQxPrjFileRela.QxPrjId);
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
 AddUpdatedFld(conQxPrjFileRela.FileName);
}
}
/// <summary>
/// 文件路径(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FilePath
{
get
{
return mstrFilePath;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFilePath = value;
}
else
{
 mstrFilePath = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxPrjFileRela.FilePath);
}
}
/// <summary>
/// 是否需要下载(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsNeedDownLoad
{
get
{
return mbolIsNeedDownLoad;
}
set
{
 mbolIsNeedDownLoad = value;
//记录修改过的字段
 AddUpdatedFld(conQxPrjFileRela.IsNeedDownLoad);
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
 AddUpdatedFld(conQxPrjFileRela.Version);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdDate
{
get
{
return mstrUpdDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdDate = value;
}
else
{
 mstrUpdDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxPrjFileRela.UpdDate);
}
}
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUserId
{
get
{
return mstrUpdUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUserId = value;
}
else
{
 mstrUpdUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxPrjFileRela.UpdUserId);
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
 AddUpdatedFld(conQxPrjFileRela.Memo);
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
 /// 项目相关文件(QxPrjFileRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conQxPrjFileRela
{
public const string _CurrTabName = "QxPrjFileRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "QxPrjId", "FileName", "FilePath", "IsNeedDownLoad", "Version", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //流水号

 /// <summary>
 /// 常量:"QxPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QxPrjId = "QxPrjId";    //项目Id

 /// <summary>
 /// 常量:"FileName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileName = "FileName";    //文件名

 /// <summary>
 /// 常量:"FilePath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FilePath = "FilePath";    //文件路径

 /// <summary>
 /// 常量:"IsNeedDownLoad"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsNeedDownLoad = "IsNeedDownLoad";    //是否需要下载

 /// <summary>
 /// 常量:"Version"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Version = "Version";    //版本

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}