
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSubjectRelationEN
 表名:SubjectRelation(00140052)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 17:45:48
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:用户管理(UserManage_GP)
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
 /// 表SubjectRelation的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_SubjectRelation
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
public K_mId_SubjectRelation(long lngmId)
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
 /// <returns>返回:[K_mId_SubjectRelation]类型的对象</returns>
public static implicit operator K_mId_SubjectRelation(long value)
{
return new K_mId_SubjectRelation(value);
}
}
 /// <summary>
 /// 隶属关系(SubjectRelation)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsSubjectRelationEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "SubjectRelation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"mId", "UserId", "LeaderId", "IsDirectLeader", "Memo"};

protected long mlngmId;    //流水号
protected string mstrUserId;    //用户ID
protected string mstrLeaderId;    //领导Id
protected bool mbolIsDirectLeader;    //是否直接领导
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsSubjectRelationEN()
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
public clsSubjectRelationEN(long lngmId)
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
if (strAttributeName  ==  conSubjectRelation.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conSubjectRelation.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conSubjectRelation.LeaderId)
{
return mstrLeaderId;
}
else if (strAttributeName  ==  conSubjectRelation.IsDirectLeader)
{
return mbolIsDirectLeader;
}
else if (strAttributeName  ==  conSubjectRelation.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conSubjectRelation.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conSubjectRelation.mId);
}
else if (strAttributeName  ==  conSubjectRelation.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conSubjectRelation.UserId);
}
else if (strAttributeName  ==  conSubjectRelation.LeaderId)
{
mstrLeaderId = value.ToString();
 AddUpdatedFld(conSubjectRelation.LeaderId);
}
else if (strAttributeName  ==  conSubjectRelation.IsDirectLeader)
{
mbolIsDirectLeader = TransNullToBool(value.ToString());
 AddUpdatedFld(conSubjectRelation.IsDirectLeader);
}
else if (strAttributeName  ==  conSubjectRelation.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSubjectRelation.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conSubjectRelation.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conSubjectRelation.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conSubjectRelation.LeaderId  ==  AttributeName[intIndex])
{
return mstrLeaderId;
}
else if (conSubjectRelation.IsDirectLeader  ==  AttributeName[intIndex])
{
return mbolIsDirectLeader;
}
else if (conSubjectRelation.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conSubjectRelation.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conSubjectRelation.mId);
}
else if (conSubjectRelation.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conSubjectRelation.UserId);
}
else if (conSubjectRelation.LeaderId  ==  AttributeName[intIndex])
{
mstrLeaderId = value.ToString();
 AddUpdatedFld(conSubjectRelation.LeaderId);
}
else if (conSubjectRelation.IsDirectLeader  ==  AttributeName[intIndex])
{
mbolIsDirectLeader = TransNullToBool(value.ToString());
 AddUpdatedFld(conSubjectRelation.IsDirectLeader);
}
else if (conSubjectRelation.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSubjectRelation.Memo);
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
 AddUpdatedFld(conSubjectRelation.mId);
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
 AddUpdatedFld(conSubjectRelation.UserId);
}
}
/// <summary>
/// 领导Id(说明:;字段类型:varchar;字段长度:18;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LeaderId
{
get
{
return mstrLeaderId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLeaderId = value;
}
else
{
 mstrLeaderId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSubjectRelation.LeaderId);
}
}
/// <summary>
/// 是否直接领导(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsDirectLeader
{
get
{
return mbolIsDirectLeader;
}
set
{
 mbolIsDirectLeader = value;
//记录修改过的字段
 AddUpdatedFld(conSubjectRelation.IsDirectLeader);
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
 AddUpdatedFld(conSubjectRelation.Memo);
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
 /// 隶属关系(SubjectRelation)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conSubjectRelation
{
public const string _CurrTabName = "SubjectRelation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "UserId", "LeaderId", "IsDirectLeader", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //流水号

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"LeaderId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LeaderId = "LeaderId";    //领导Id

 /// <summary>
 /// 常量:"IsDirectLeader"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDirectLeader = "IsDirectLeader";    //是否直接领导

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}