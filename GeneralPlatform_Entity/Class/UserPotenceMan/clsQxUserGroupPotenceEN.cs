
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUserGroupPotenceEN
 表名:QxUserGroupPotence(00140008)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 17:42:19
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:用户权限管理(UserPotenceMan)
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
 /// 表QxUserGroupPotence的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_QxUserGroupPotence
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
public K_mId_QxUserGroupPotence(long lngmId)
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
 /// <returns>返回:[K_mId_QxUserGroupPotence]类型的对象</returns>
public static implicit operator K_mId_QxUserGroupPotence(long value)
{
return new K_mId_QxUserGroupPotence(value);
}
}
 /// <summary>
 /// 用户权限关系(QxUserGroupPotence)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQxUserGroupPotenceEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "QxUserGroupPotence"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 8;
public static string[] AttributeName = new string[] {"mId", "UserId", "GroupId", "RoleId", "QxPrjId", "PotenceId", "RelaMid", "Memo"};

protected long mlngmId;    //流水号
protected string mstrUserId;    //用户ID
protected string mstrGroupId;    //组Id
protected string mstrRoleId;    //角色Id
protected string mstrQxPrjId;    //项目Id
protected string mstrPotenceId;    //权限ID
protected long? mlngRelaMid;    //流水号
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQxUserGroupPotenceEN()
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
public clsQxUserGroupPotenceEN(long lngmId)
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
if (strAttributeName  ==  conQxUserGroupPotence.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conQxUserGroupPotence.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conQxUserGroupPotence.GroupId)
{
return mstrGroupId;
}
else if (strAttributeName  ==  conQxUserGroupPotence.RoleId)
{
return mstrRoleId;
}
else if (strAttributeName  ==  conQxUserGroupPotence.QxPrjId)
{
return mstrQxPrjId;
}
else if (strAttributeName  ==  conQxUserGroupPotence.PotenceId)
{
return mstrPotenceId;
}
else if (strAttributeName  ==  conQxUserGroupPotence.RelaMid)
{
return mlngRelaMid;
}
else if (strAttributeName  ==  conQxUserGroupPotence.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conQxUserGroupPotence.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxUserGroupPotence.mId);
}
else if (strAttributeName  ==  conQxUserGroupPotence.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conQxUserGroupPotence.UserId);
}
else if (strAttributeName  ==  conQxUserGroupPotence.GroupId)
{
mstrGroupId = value.ToString();
 AddUpdatedFld(conQxUserGroupPotence.GroupId);
}
else if (strAttributeName  ==  conQxUserGroupPotence.RoleId)
{
mstrRoleId = value.ToString();
 AddUpdatedFld(conQxUserGroupPotence.RoleId);
}
else if (strAttributeName  ==  conQxUserGroupPotence.QxPrjId)
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(conQxUserGroupPotence.QxPrjId);
}
else if (strAttributeName  ==  conQxUserGroupPotence.PotenceId)
{
mstrPotenceId = value.ToString();
 AddUpdatedFld(conQxUserGroupPotence.PotenceId);
}
else if (strAttributeName  ==  conQxUserGroupPotence.RelaMid)
{
mlngRelaMid = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxUserGroupPotence.RelaMid);
}
else if (strAttributeName  ==  conQxUserGroupPotence.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxUserGroupPotence.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conQxUserGroupPotence.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conQxUserGroupPotence.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conQxUserGroupPotence.GroupId  ==  AttributeName[intIndex])
{
return mstrGroupId;
}
else if (conQxUserGroupPotence.RoleId  ==  AttributeName[intIndex])
{
return mstrRoleId;
}
else if (conQxUserGroupPotence.QxPrjId  ==  AttributeName[intIndex])
{
return mstrQxPrjId;
}
else if (conQxUserGroupPotence.PotenceId  ==  AttributeName[intIndex])
{
return mstrPotenceId;
}
else if (conQxUserGroupPotence.RelaMid  ==  AttributeName[intIndex])
{
return mlngRelaMid;
}
else if (conQxUserGroupPotence.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conQxUserGroupPotence.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxUserGroupPotence.mId);
}
else if (conQxUserGroupPotence.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conQxUserGroupPotence.UserId);
}
else if (conQxUserGroupPotence.GroupId  ==  AttributeName[intIndex])
{
mstrGroupId = value.ToString();
 AddUpdatedFld(conQxUserGroupPotence.GroupId);
}
else if (conQxUserGroupPotence.RoleId  ==  AttributeName[intIndex])
{
mstrRoleId = value.ToString();
 AddUpdatedFld(conQxUserGroupPotence.RoleId);
}
else if (conQxUserGroupPotence.QxPrjId  ==  AttributeName[intIndex])
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(conQxUserGroupPotence.QxPrjId);
}
else if (conQxUserGroupPotence.PotenceId  ==  AttributeName[intIndex])
{
mstrPotenceId = value.ToString();
 AddUpdatedFld(conQxUserGroupPotence.PotenceId);
}
else if (conQxUserGroupPotence.RelaMid  ==  AttributeName[intIndex])
{
mlngRelaMid = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxUserGroupPotence.RelaMid);
}
else if (conQxUserGroupPotence.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxUserGroupPotence.Memo);
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
 AddUpdatedFld(conQxUserGroupPotence.mId);
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
 AddUpdatedFld(conQxUserGroupPotence.UserId);
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
 AddUpdatedFld(conQxUserGroupPotence.GroupId);
}
}
/// <summary>
/// 角色Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RoleId
{
get
{
return mstrRoleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRoleId = value;
}
else
{
 mstrRoleId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxUserGroupPotence.RoleId);
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
 AddUpdatedFld(conQxUserGroupPotence.QxPrjId);
}
}
/// <summary>
/// 权限ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PotenceId
{
get
{
return mstrPotenceId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPotenceId = value;
}
else
{
 mstrPotenceId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxUserGroupPotence.PotenceId);
}
}
/// <summary>
/// 流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long? RelaMid
{
get
{
return mlngRelaMid;
}
set
{
 mlngRelaMid = value;
//记录修改过的字段
 AddUpdatedFld(conQxUserGroupPotence.RelaMid);
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
 AddUpdatedFld(conQxUserGroupPotence.Memo);
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
 /// 用户权限关系(QxUserGroupPotence)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conQxUserGroupPotence
{
public const string _CurrTabName = "QxUserGroupPotence"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "UserId", "GroupId", "RoleId", "QxPrjId", "PotenceId", "RelaMid", "Memo"};
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
 /// 常量:"RoleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RoleId = "RoleId";    //角色Id

 /// <summary>
 /// 常量:"QxPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QxPrjId = "QxPrjId";    //项目Id

 /// <summary>
 /// 常量:"PotenceId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PotenceId = "PotenceId";    //权限ID

 /// <summary>
 /// 常量:"RelaMid"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RelaMid = "RelaMid";    //流水号

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}