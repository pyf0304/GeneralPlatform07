
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUserGroupRelationEN
 表名:QxUserGroupRelation(00140009)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:21:21
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
 /// 表QxUserGroupRelation的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_QxUserGroupRelation
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
public K_mId_QxUserGroupRelation(long lngmId)
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
 /// <returns>返回:[K_mId_QxUserGroupRelation]类型的对象</returns>
public static implicit operator K_mId_QxUserGroupRelation(long value)
{
return new K_mId_QxUserGroupRelation(value);
}
}
 /// <summary>
 /// 用户/组关系(QxUserGroupRelation)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQxUserGroupRelationEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "QxUserGroupRelation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 8;
public static string[] AttributeName = new string[] {"mId", "UserId", "GroupId", "Memo", "QxPrjId", "ManageId", "ManageTypeId", "IsDefault"};

protected long mlngmId;    //流水号
protected string mstrUserId;    //用户ID
protected string mstrGroupId;    //组Id
protected string mstrMemo;    //备注
protected string mstrQxPrjId;    //项目Id
protected string mstrManageId;    //ManageId
protected string mstrManageTypeId;    //ManageTypeId
protected bool mbolIsDefault;    //是否默认

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQxUserGroupRelationEN()
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
public clsQxUserGroupRelationEN(long lngmId)
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
if (strAttributeName  ==  conQxUserGroupRelation.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conQxUserGroupRelation.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conQxUserGroupRelation.GroupId)
{
return mstrGroupId;
}
else if (strAttributeName  ==  conQxUserGroupRelation.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conQxUserGroupRelation.QxPrjId)
{
return mstrQxPrjId;
}
else if (strAttributeName  ==  conQxUserGroupRelation.ManageId)
{
return mstrManageId;
}
else if (strAttributeName  ==  conQxUserGroupRelation.ManageTypeId)
{
return mstrManageTypeId;
}
else if (strAttributeName  ==  conQxUserGroupRelation.IsDefault)
{
return mbolIsDefault;
}
return null;
}
set
{
if (strAttributeName  ==  conQxUserGroupRelation.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxUserGroupRelation.mId);
}
else if (strAttributeName  ==  conQxUserGroupRelation.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conQxUserGroupRelation.UserId);
}
else if (strAttributeName  ==  conQxUserGroupRelation.GroupId)
{
mstrGroupId = value.ToString();
 AddUpdatedFld(conQxUserGroupRelation.GroupId);
}
else if (strAttributeName  ==  conQxUserGroupRelation.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxUserGroupRelation.Memo);
}
else if (strAttributeName  ==  conQxUserGroupRelation.QxPrjId)
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(conQxUserGroupRelation.QxPrjId);
}
else if (strAttributeName  ==  conQxUserGroupRelation.ManageId)
{
mstrManageId = value.ToString();
 AddUpdatedFld(conQxUserGroupRelation.ManageId);
}
else if (strAttributeName  ==  conQxUserGroupRelation.ManageTypeId)
{
mstrManageTypeId = value.ToString();
 AddUpdatedFld(conQxUserGroupRelation.ManageTypeId);
}
else if (strAttributeName  ==  conQxUserGroupRelation.IsDefault)
{
mbolIsDefault = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxUserGroupRelation.IsDefault);
}
}
}
public object this[int intIndex]
{
get
{
if (conQxUserGroupRelation.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conQxUserGroupRelation.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conQxUserGroupRelation.GroupId  ==  AttributeName[intIndex])
{
return mstrGroupId;
}
else if (conQxUserGroupRelation.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conQxUserGroupRelation.QxPrjId  ==  AttributeName[intIndex])
{
return mstrQxPrjId;
}
else if (conQxUserGroupRelation.ManageId  ==  AttributeName[intIndex])
{
return mstrManageId;
}
else if (conQxUserGroupRelation.ManageTypeId  ==  AttributeName[intIndex])
{
return mstrManageTypeId;
}
else if (conQxUserGroupRelation.IsDefault  ==  AttributeName[intIndex])
{
return mbolIsDefault;
}
return null;
}
set
{
if (conQxUserGroupRelation.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxUserGroupRelation.mId);
}
else if (conQxUserGroupRelation.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conQxUserGroupRelation.UserId);
}
else if (conQxUserGroupRelation.GroupId  ==  AttributeName[intIndex])
{
mstrGroupId = value.ToString();
 AddUpdatedFld(conQxUserGroupRelation.GroupId);
}
else if (conQxUserGroupRelation.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxUserGroupRelation.Memo);
}
else if (conQxUserGroupRelation.QxPrjId  ==  AttributeName[intIndex])
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(conQxUserGroupRelation.QxPrjId);
}
else if (conQxUserGroupRelation.ManageId  ==  AttributeName[intIndex])
{
mstrManageId = value.ToString();
 AddUpdatedFld(conQxUserGroupRelation.ManageId);
}
else if (conQxUserGroupRelation.ManageTypeId  ==  AttributeName[intIndex])
{
mstrManageTypeId = value.ToString();
 AddUpdatedFld(conQxUserGroupRelation.ManageTypeId);
}
else if (conQxUserGroupRelation.IsDefault  ==  AttributeName[intIndex])
{
mbolIsDefault = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxUserGroupRelation.IsDefault);
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
 AddUpdatedFld(conQxUserGroupRelation.mId);
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
 AddUpdatedFld(conQxUserGroupRelation.UserId);
}
}
/// <summary>
/// 组Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GroupId
{
get
{
return mstrGroupId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGroupId = value;
}
else
{
 mstrGroupId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxUserGroupRelation.GroupId);
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
 AddUpdatedFld(conQxUserGroupRelation.Memo);
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
 AddUpdatedFld(conQxUserGroupRelation.QxPrjId);
}
}
/// <summary>
/// ManageId(说明:;字段类型:varchar;字段长度:18;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ManageId
{
get
{
return mstrManageId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrManageId = value;
}
else
{
 mstrManageId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxUserGroupRelation.ManageId);
}
}
/// <summary>
/// ManageTypeId(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ManageTypeId
{
get
{
return mstrManageTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrManageTypeId = value;
}
else
{
 mstrManageTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxUserGroupRelation.ManageTypeId);
}
}
/// <summary>
/// 是否默认(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsDefault
{
get
{
return mbolIsDefault;
}
set
{
 mbolIsDefault = value;
//记录修改过的字段
 AddUpdatedFld(conQxUserGroupRelation.IsDefault);
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
 /// 用户/组关系(QxUserGroupRelation)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conQxUserGroupRelation
{
public const string _CurrTabName = "QxUserGroupRelation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "UserId", "GroupId", "Memo", "QxPrjId", "ManageId", "ManageTypeId", "IsDefault"};
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
 /// 常量:"GroupId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GroupId = "GroupId";    //组Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"QxPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QxPrjId = "QxPrjId";    //项目Id

 /// <summary>
 /// 常量:"ManageId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ManageId = "ManageId";    //ManageId

 /// <summary>
 /// 常量:"ManageTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ManageTypeId = "ManageTypeId";    //ManageTypeId

 /// <summary>
 /// 常量:"IsDefault"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDefault = "IsDefault";    //是否默认
}

}