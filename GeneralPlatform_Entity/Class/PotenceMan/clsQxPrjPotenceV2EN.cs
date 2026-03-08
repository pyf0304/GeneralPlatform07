
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxPrjPotenceV2EN
 表名:QxPrjPotenceV2(00140115)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:30:55
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:权限管理(PotenceMan)
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
 /// 表QxPrjPotenceV2的关键字(PId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PId_QxPrjPotenceV2
{
private int _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public int Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="intPId">表关键字</param>
public K_PId_QxPrjPotenceV2(int intPId)
{
if (IsValid(intPId)) Value = intPId;
else
{
Value = 0;
}
}
private static bool IsValid(int intPId)
{
if (intPId == 0) return false;
if (intPId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PId_QxPrjPotenceV2]类型的对象</returns>
public static implicit operator K_PId_QxPrjPotenceV2(int value)
{
return new K_PId_QxPrjPotenceV2(value);
}
}
 /// <summary>
 /// 工程权限V2(QxPrjPotenceV2)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQxPrjPotenceV2EN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "QxPrjPotenceV2"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 10;
public static string[] AttributeName = new string[] {"PId", "PotenceName", "QxPrjId", "FuncModuleId", "PotenceTypeId", "MenuId", "MenuId4Win", "UpdDate", "UpdUserId", "Memo"};

protected int mintPId;    //菜单Id
protected string mstrPotenceName;    //权限名称
protected string mstrQxPrjId;    //项目Id
protected string mstrFuncModuleId;    //模块Id
protected string mstrPotenceTypeId;    //权限类型Id
protected string mstrMenuId;    //菜单Id
protected string mstrMenuId4Win;    //菜单Id4Win
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQxPrjPotenceV2EN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "intPId">关键字:菜单Id</param>
public clsQxPrjPotenceV2EN(int intPId)
 {
 if (intPId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mintPId = intPId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PId");
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
if (strAttributeName  ==  conQxPrjPotenceV2.PId)
{
return mintPId;
}
else if (strAttributeName  ==  conQxPrjPotenceV2.PotenceName)
{
return mstrPotenceName;
}
else if (strAttributeName  ==  conQxPrjPotenceV2.QxPrjId)
{
return mstrQxPrjId;
}
else if (strAttributeName  ==  conQxPrjPotenceV2.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  conQxPrjPotenceV2.PotenceTypeId)
{
return mstrPotenceTypeId;
}
else if (strAttributeName  ==  conQxPrjPotenceV2.MenuId)
{
return mstrMenuId;
}
else if (strAttributeName  ==  conQxPrjPotenceV2.MenuId4Win)
{
return mstrMenuId4Win;
}
else if (strAttributeName  ==  conQxPrjPotenceV2.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conQxPrjPotenceV2.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conQxPrjPotenceV2.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conQxPrjPotenceV2.PId)
{
mintPId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxPrjPotenceV2.PId);
}
else if (strAttributeName  ==  conQxPrjPotenceV2.PotenceName)
{
mstrPotenceName = value.ToString();
 AddUpdatedFld(conQxPrjPotenceV2.PotenceName);
}
else if (strAttributeName  ==  conQxPrjPotenceV2.QxPrjId)
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(conQxPrjPotenceV2.QxPrjId);
}
else if (strAttributeName  ==  conQxPrjPotenceV2.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(conQxPrjPotenceV2.FuncModuleId);
}
else if (strAttributeName  ==  conQxPrjPotenceV2.PotenceTypeId)
{
mstrPotenceTypeId = value.ToString();
 AddUpdatedFld(conQxPrjPotenceV2.PotenceTypeId);
}
else if (strAttributeName  ==  conQxPrjPotenceV2.MenuId)
{
mstrMenuId = value.ToString();
 AddUpdatedFld(conQxPrjPotenceV2.MenuId);
}
else if (strAttributeName  ==  conQxPrjPotenceV2.MenuId4Win)
{
mstrMenuId4Win = value.ToString();
 AddUpdatedFld(conQxPrjPotenceV2.MenuId4Win);
}
else if (strAttributeName  ==  conQxPrjPotenceV2.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxPrjPotenceV2.UpdDate);
}
else if (strAttributeName  ==  conQxPrjPotenceV2.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conQxPrjPotenceV2.UpdUserId);
}
else if (strAttributeName  ==  conQxPrjPotenceV2.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxPrjPotenceV2.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conQxPrjPotenceV2.PId  ==  AttributeName[intIndex])
{
return mintPId;
}
else if (conQxPrjPotenceV2.PotenceName  ==  AttributeName[intIndex])
{
return mstrPotenceName;
}
else if (conQxPrjPotenceV2.QxPrjId  ==  AttributeName[intIndex])
{
return mstrQxPrjId;
}
else if (conQxPrjPotenceV2.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (conQxPrjPotenceV2.PotenceTypeId  ==  AttributeName[intIndex])
{
return mstrPotenceTypeId;
}
else if (conQxPrjPotenceV2.MenuId  ==  AttributeName[intIndex])
{
return mstrMenuId;
}
else if (conQxPrjPotenceV2.MenuId4Win  ==  AttributeName[intIndex])
{
return mstrMenuId4Win;
}
else if (conQxPrjPotenceV2.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conQxPrjPotenceV2.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conQxPrjPotenceV2.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conQxPrjPotenceV2.PId  ==  AttributeName[intIndex])
{
mintPId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxPrjPotenceV2.PId);
}
else if (conQxPrjPotenceV2.PotenceName  ==  AttributeName[intIndex])
{
mstrPotenceName = value.ToString();
 AddUpdatedFld(conQxPrjPotenceV2.PotenceName);
}
else if (conQxPrjPotenceV2.QxPrjId  ==  AttributeName[intIndex])
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(conQxPrjPotenceV2.QxPrjId);
}
else if (conQxPrjPotenceV2.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(conQxPrjPotenceV2.FuncModuleId);
}
else if (conQxPrjPotenceV2.PotenceTypeId  ==  AttributeName[intIndex])
{
mstrPotenceTypeId = value.ToString();
 AddUpdatedFld(conQxPrjPotenceV2.PotenceTypeId);
}
else if (conQxPrjPotenceV2.MenuId  ==  AttributeName[intIndex])
{
mstrMenuId = value.ToString();
 AddUpdatedFld(conQxPrjPotenceV2.MenuId);
}
else if (conQxPrjPotenceV2.MenuId4Win  ==  AttributeName[intIndex])
{
mstrMenuId4Win = value.ToString();
 AddUpdatedFld(conQxPrjPotenceV2.MenuId4Win);
}
else if (conQxPrjPotenceV2.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxPrjPotenceV2.UpdDate);
}
else if (conQxPrjPotenceV2.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conQxPrjPotenceV2.UpdUserId);
}
else if (conQxPrjPotenceV2.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxPrjPotenceV2.Memo);
}
}
}

/// <summary>
/// 菜单Id(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int PId
{
get
{
return mintPId;
}
set
{
 mintPId = value;
//记录修改过的字段
 AddUpdatedFld(conQxPrjPotenceV2.PId);
}
}
/// <summary>
/// 权限名称(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PotenceName
{
get
{
return mstrPotenceName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPotenceName = value;
}
else
{
 mstrPotenceName = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxPrjPotenceV2.PotenceName);
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
 AddUpdatedFld(conQxPrjPotenceV2.QxPrjId);
}
}
/// <summary>
/// 模块Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleId
{
get
{
return mstrFuncModuleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleId = value;
}
else
{
 mstrFuncModuleId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxPrjPotenceV2.FuncModuleId);
}
}
/// <summary>
/// 权限类型Id(说明:;字段类型:char;字段长度:6;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PotenceTypeId
{
get
{
return mstrPotenceTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPotenceTypeId = value;
}
else
{
 mstrPotenceTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxPrjPotenceV2.PotenceTypeId);
}
}
/// <summary>
/// 菜单Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MenuId
{
get
{
return mstrMenuId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMenuId = value;
}
else
{
 mstrMenuId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxPrjPotenceV2.MenuId);
}
}
/// <summary>
/// 菜单Id4Win(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MenuId4Win
{
get
{
return mstrMenuId4Win;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMenuId4Win = value;
}
else
{
 mstrMenuId4Win = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxPrjPotenceV2.MenuId4Win);
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
 AddUpdatedFld(conQxPrjPotenceV2.UpdDate);
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
 AddUpdatedFld(conQxPrjPotenceV2.UpdUserId);
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
 AddUpdatedFld(conQxPrjPotenceV2.Memo);
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
  return mintPId.ToString();
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
  return mstrPotenceName;
 }
 }
}
 /// <summary>
 /// 工程权限V2(QxPrjPotenceV2)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conQxPrjPotenceV2
{
public const string _CurrTabName = "QxPrjPotenceV2"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PId", "PotenceName", "QxPrjId", "FuncModuleId", "PotenceTypeId", "MenuId", "MenuId4Win", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"PId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PId = "PId";    //菜单Id

 /// <summary>
 /// 常量:"PotenceName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PotenceName = "PotenceName";    //权限名称

 /// <summary>
 /// 常量:"QxPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QxPrjId = "QxPrjId";    //项目Id

 /// <summary>
 /// 常量:"FuncModuleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleId = "FuncModuleId";    //模块Id

 /// <summary>
 /// 常量:"PotenceTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PotenceTypeId = "PotenceTypeId";    //权限类型Id

 /// <summary>
 /// 常量:"MenuId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MenuId = "MenuId";    //菜单Id

 /// <summary>
 /// 常量:"MenuId4Win"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MenuId4Win = "MenuId4Win";    //菜单Id4Win

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