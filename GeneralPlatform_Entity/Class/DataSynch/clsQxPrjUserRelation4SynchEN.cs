
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxPrjUserRelation4SynchEN
 表名:QxPrjUserRelation4Synch(00140093)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:08:28
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:数据同步(DataSynch)
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
 /// 表QxPrjUserRelation4Synch的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_QxPrjUserRelation4Synch
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
public K_mId_QxPrjUserRelation4Synch(long lngmId)
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
 /// <returns>返回:[K_mId_QxPrjUserRelation4Synch]类型的对象</returns>
public static implicit operator K_mId_QxPrjUserRelation4Synch(long value)
{
return new K_mId_QxPrjUserRelation4Synch(value);
}
}
 /// <summary>
 /// 工程用户关系4同步(QxPrjUserRelation4Synch)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQxPrjUserRelation4SynchEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "QxPrjUserRelation4Synch"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"mId", "IpAddress", "QxPrjId", "UserId", "UpdDate", "UpdUserId", "Memo"};

protected long mlngmId;    //流水号
protected string mstrIpAddress;    //IP地址
protected string mstrQxPrjId;    //项目Id
protected string mstrUserId;    //用户ID
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQxPrjUserRelation4SynchEN()
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
public clsQxPrjUserRelation4SynchEN(long lngmId)
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
if (strAttributeName  ==  conQxPrjUserRelation4Synch.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conQxPrjUserRelation4Synch.IpAddress)
{
return mstrIpAddress;
}
else if (strAttributeName  ==  conQxPrjUserRelation4Synch.QxPrjId)
{
return mstrQxPrjId;
}
else if (strAttributeName  ==  conQxPrjUserRelation4Synch.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conQxPrjUserRelation4Synch.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conQxPrjUserRelation4Synch.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conQxPrjUserRelation4Synch.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conQxPrjUserRelation4Synch.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxPrjUserRelation4Synch.mId);
}
else if (strAttributeName  ==  conQxPrjUserRelation4Synch.IpAddress)
{
mstrIpAddress = value.ToString();
 AddUpdatedFld(conQxPrjUserRelation4Synch.IpAddress);
}
else if (strAttributeName  ==  conQxPrjUserRelation4Synch.QxPrjId)
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(conQxPrjUserRelation4Synch.QxPrjId);
}
else if (strAttributeName  ==  conQxPrjUserRelation4Synch.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conQxPrjUserRelation4Synch.UserId);
}
else if (strAttributeName  ==  conQxPrjUserRelation4Synch.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxPrjUserRelation4Synch.UpdDate);
}
else if (strAttributeName  ==  conQxPrjUserRelation4Synch.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conQxPrjUserRelation4Synch.UpdUserId);
}
else if (strAttributeName  ==  conQxPrjUserRelation4Synch.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxPrjUserRelation4Synch.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conQxPrjUserRelation4Synch.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conQxPrjUserRelation4Synch.IpAddress  ==  AttributeName[intIndex])
{
return mstrIpAddress;
}
else if (conQxPrjUserRelation4Synch.QxPrjId  ==  AttributeName[intIndex])
{
return mstrQxPrjId;
}
else if (conQxPrjUserRelation4Synch.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conQxPrjUserRelation4Synch.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conQxPrjUserRelation4Synch.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conQxPrjUserRelation4Synch.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conQxPrjUserRelation4Synch.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxPrjUserRelation4Synch.mId);
}
else if (conQxPrjUserRelation4Synch.IpAddress  ==  AttributeName[intIndex])
{
mstrIpAddress = value.ToString();
 AddUpdatedFld(conQxPrjUserRelation4Synch.IpAddress);
}
else if (conQxPrjUserRelation4Synch.QxPrjId  ==  AttributeName[intIndex])
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(conQxPrjUserRelation4Synch.QxPrjId);
}
else if (conQxPrjUserRelation4Synch.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conQxPrjUserRelation4Synch.UserId);
}
else if (conQxPrjUserRelation4Synch.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxPrjUserRelation4Synch.UpdDate);
}
else if (conQxPrjUserRelation4Synch.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conQxPrjUserRelation4Synch.UpdUserId);
}
else if (conQxPrjUserRelation4Synch.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxPrjUserRelation4Synch.Memo);
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
 AddUpdatedFld(conQxPrjUserRelation4Synch.mId);
}
}
/// <summary>
/// IP地址(说明:;字段类型:varchar;字段长度:23;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IpAddress
{
get
{
return mstrIpAddress;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIpAddress = value;
}
else
{
 mstrIpAddress = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxPrjUserRelation4Synch.IpAddress);
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
 AddUpdatedFld(conQxPrjUserRelation4Synch.QxPrjId);
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
 AddUpdatedFld(conQxPrjUserRelation4Synch.UserId);
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
 AddUpdatedFld(conQxPrjUserRelation4Synch.UpdDate);
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
 AddUpdatedFld(conQxPrjUserRelation4Synch.UpdUserId);
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
 AddUpdatedFld(conQxPrjUserRelation4Synch.Memo);
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
 /// 工程用户关系4同步(QxPrjUserRelation4Synch)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conQxPrjUserRelation4Synch
{
public const string _CurrTabName = "QxPrjUserRelation4Synch"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "IpAddress", "QxPrjId", "UserId", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //流水号

 /// <summary>
 /// 常量:"IpAddress"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IpAddress = "IpAddress";    //IP地址

 /// <summary>
 /// 常量:"QxPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QxPrjId = "QxPrjId";    //项目Id

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

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