
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUserRolesV2EN
 表名:QxUserRolesV2(00140116)
 * 版本:2023.05.10.1(服务器:WIN-SRV103-116)
 日期:2023/05/14 00:35:26
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:用户管理(UserManage)
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
 /// 表QxUserRolesV2的关键字(RId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_RId_QxUserRolesV2
{
private int _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public int Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="intRId">表关键字</param>
public K_RId_QxUserRolesV2(int intRId)
{
if (IsValid(intRId)) Value = intRId;
else
{
Value = 0;
}
}
private static bool IsValid(int intRId)
{
if (intRId == 0) return false;
if (intRId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_RId_QxUserRolesV2]类型的对象</returns>
public static implicit operator K_RId_QxUserRolesV2(int value)
{
return new K_RId_QxUserRolesV2(value);
}
}
 /// <summary>
 /// 角色V2(QxUserRolesV2)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQxUserRolesV2EN : clsEntityBase2
{
public const string _CurrTabName_S = "QxUserRolesV2"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "RId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"RId", "RoleName", "RoleENName", "RoleIndex", "QxPrjId", "IsInUse", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量

protected int mintRId;    //角色Id
protected string mstrRoleName;    //角色名称
protected string mstrRoleENName;    //角色英文名
protected int mintRoleIndex;    //角色序号
protected string mstrQxPrjId;    //项目Id
protected bool mbolIsInUse;    //是否在使用
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQxUserRolesV2EN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "QxUserRolesV2";
 lstKeyFldNames.Add("RId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "intRId">关键字:角色Id</param>
public clsQxUserRolesV2EN(int intRId)
 {
 if (intRId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mintRId = intRId;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "QxUserRolesV2";
 lstKeyFldNames.Add("RId");
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
if (strAttributeName  ==  conQxUserRolesV2.RId)
{
return mintRId;
}
else if (strAttributeName  ==  conQxUserRolesV2.RoleName)
{
return mstrRoleName;
}
else if (strAttributeName  ==  conQxUserRolesV2.RoleENName)
{
return mstrRoleENName;
}
else if (strAttributeName  ==  conQxUserRolesV2.RoleIndex)
{
return mintRoleIndex;
}
else if (strAttributeName  ==  conQxUserRolesV2.QxPrjId)
{
return mstrQxPrjId;
}
else if (strAttributeName  ==  conQxUserRolesV2.IsInUse)
{
return mbolIsInUse;
}
else if (strAttributeName  ==  conQxUserRolesV2.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conQxUserRolesV2.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conQxUserRolesV2.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conQxUserRolesV2.RId)
{
mintRId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxUserRolesV2.RId);
}
else if (strAttributeName  ==  conQxUserRolesV2.RoleName)
{
mstrRoleName = value.ToString();
 AddUpdatedFld(conQxUserRolesV2.RoleName);
}
else if (strAttributeName  ==  conQxUserRolesV2.RoleENName)
{
mstrRoleENName = value.ToString();
 AddUpdatedFld(conQxUserRolesV2.RoleENName);
}
else if (strAttributeName  ==  conQxUserRolesV2.RoleIndex)
{
mintRoleIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxUserRolesV2.RoleIndex);
}
else if (strAttributeName  ==  conQxUserRolesV2.QxPrjId)
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(conQxUserRolesV2.QxPrjId);
}
else if (strAttributeName  ==  conQxUserRolesV2.IsInUse)
{
mbolIsInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxUserRolesV2.IsInUse);
}
else if (strAttributeName  ==  conQxUserRolesV2.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxUserRolesV2.UpdDate);
}
else if (strAttributeName  ==  conQxUserRolesV2.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conQxUserRolesV2.UpdUserId);
}
else if (strAttributeName  ==  conQxUserRolesV2.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxUserRolesV2.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conQxUserRolesV2.RId  ==  AttributeName[intIndex])
{
return mintRId;
}
else if (conQxUserRolesV2.RoleName  ==  AttributeName[intIndex])
{
return mstrRoleName;
}
else if (conQxUserRolesV2.RoleENName  ==  AttributeName[intIndex])
{
return mstrRoleENName;
}
else if (conQxUserRolesV2.RoleIndex  ==  AttributeName[intIndex])
{
return mintRoleIndex;
}
else if (conQxUserRolesV2.QxPrjId  ==  AttributeName[intIndex])
{
return mstrQxPrjId;
}
else if (conQxUserRolesV2.IsInUse  ==  AttributeName[intIndex])
{
return mbolIsInUse;
}
else if (conQxUserRolesV2.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conQxUserRolesV2.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conQxUserRolesV2.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conQxUserRolesV2.RId  ==  AttributeName[intIndex])
{
mintRId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxUserRolesV2.RId);
}
else if (conQxUserRolesV2.RoleName  ==  AttributeName[intIndex])
{
mstrRoleName = value.ToString();
 AddUpdatedFld(conQxUserRolesV2.RoleName);
}
else if (conQxUserRolesV2.RoleENName  ==  AttributeName[intIndex])
{
mstrRoleENName = value.ToString();
 AddUpdatedFld(conQxUserRolesV2.RoleENName);
}
else if (conQxUserRolesV2.RoleIndex  ==  AttributeName[intIndex])
{
mintRoleIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxUserRolesV2.RoleIndex);
}
else if (conQxUserRolesV2.QxPrjId  ==  AttributeName[intIndex])
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(conQxUserRolesV2.QxPrjId);
}
else if (conQxUserRolesV2.IsInUse  ==  AttributeName[intIndex])
{
mbolIsInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxUserRolesV2.IsInUse);
}
else if (conQxUserRolesV2.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxUserRolesV2.UpdDate);
}
else if (conQxUserRolesV2.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conQxUserRolesV2.UpdUserId);
}
else if (conQxUserRolesV2.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxUserRolesV2.Memo);
}
}
}

/// <summary>
/// 角色Id(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int RId
{
get
{
return mintRId;
}
set
{
 mintRId = value;
//记录修改过的字段
 AddUpdatedFld(conQxUserRolesV2.RId);
}
}
/// <summary>
/// 角色名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RoleName
{
get
{
return mstrRoleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRoleName = value;
}
else
{
 mstrRoleName = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxUserRolesV2.RoleName);
}
}
/// <summary>
/// 角色英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RoleENName
{
get
{
return mstrRoleENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRoleENName = value;
}
else
{
 mstrRoleENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxUserRolesV2.RoleENName);
}
}
/// <summary>
/// 角色序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int RoleIndex
{
get
{
return mintRoleIndex;
}
set
{
 mintRoleIndex = value;
//记录修改过的字段
 AddUpdatedFld(conQxUserRolesV2.RoleIndex);
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
 AddUpdatedFld(conQxUserRolesV2.QxPrjId);
}
}
/// <summary>
/// 是否在使用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsInUse
{
get
{
return mbolIsInUse;
}
set
{
 mbolIsInUse = value;
//记录修改过的字段
 AddUpdatedFld(conQxUserRolesV2.IsInUse);
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
 AddUpdatedFld(conQxUserRolesV2.UpdDate);
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
 AddUpdatedFld(conQxUserRolesV2.UpdUserId);
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
 AddUpdatedFld(conQxUserRolesV2.Memo);
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
  return mintRId.ToString();
 }
 }

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrRoleName;
 }
 }
}
 /// <summary>
 /// 角色V2(QxUserRolesV2)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conQxUserRolesV2
{
public const string _CurrTabName_S = "QxUserRolesV2"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "RId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"RId", "RoleName", "RoleENName", "RoleIndex", "QxPrjId", "IsInUse", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"RId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RId = "RId";    //角色Id

 /// <summary>
 /// 常量:"RoleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RoleName = "RoleName";    //角色名称

 /// <summary>
 /// 常量:"RoleENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RoleENName = "RoleENName";    //角色英文名

 /// <summary>
 /// 常量:"RoleIndex"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RoleIndex = "RoleIndex";    //角色序号

 /// <summary>
 /// 常量:"QxPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QxPrjId = "QxPrjId";    //项目Id

 /// <summary>
 /// 常量:"IsInUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsInUse = "IsInUse";    //是否在使用

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