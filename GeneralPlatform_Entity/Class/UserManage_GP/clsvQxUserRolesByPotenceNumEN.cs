
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUserRolesByPotenceNumEN
 表名:vQxUserRolesByPotenceNum(00140084)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:30:33
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
 /// 表vQxUserRolesByPotenceNum的关键字(RoleId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_RoleId_vQxUserRolesByPotenceNum
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strRoleId">表关键字</param>
public K_RoleId_vQxUserRolesByPotenceNum(string strRoleId)
{
if (IsValid(strRoleId)) Value = strRoleId;
else
{
Value = null;
}
}
private static bool IsValid(string strRoleId)
{
if (string.IsNullOrEmpty(strRoleId) == true) return false;
if (strRoleId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_RoleId_vQxUserRolesByPotenceNum]类型的对象</returns>
public static implicit operator K_RoleId_vQxUserRolesByPotenceNum(string value)
{
return new K_RoleId_vQxUserRolesByPotenceNum(value);
}
}
 /// <summary>
 /// v角色By权限数(vQxUserRolesByPotenceNum)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvQxUserRolesByPotenceNumEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vQxUserRolesByPotenceNum"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "RoleId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 11;
public static string[] AttributeName = new string[] {"RoleId", "RoleName", "RoleENName", "RoleIndex", "QxPrjId", "PrjName", "IsInUse", "UpdDate", "UpdUserId", "Memo", "PotenceNum"};

protected string mstrRoleId;    //角色Id
protected string mstrRoleName;    //角色名称
protected string mstrRoleENName;    //角色英文名
protected int? mintRoleIndex;    //角色序号
protected string mstrQxPrjId;    //项目Id
protected string mstrPrjName;    //工程名
protected bool mbolIsInUse;    //是否在使用
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注
protected int? mintPotenceNum;    //PotenceNum

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvQxUserRolesByPotenceNumEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("RoleId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strRoleId">关键字:角色Id</param>
public clsvQxUserRolesByPotenceNumEN(string strRoleId)
 {
strRoleId = strRoleId.Replace("'", "''");
if (strRoleId.Length > 8)
{
throw new Exception("在表:vQxUserRolesByPotenceNum中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strRoleId)  ==  true)
{
throw new Exception("在表:vQxUserRolesByPotenceNum中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strRoleId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrRoleId = strRoleId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("RoleId");
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
if (strAttributeName  ==  convQxUserRolesByPotenceNum.RoleId)
{
return mstrRoleId;
}
else if (strAttributeName  ==  convQxUserRolesByPotenceNum.RoleName)
{
return mstrRoleName;
}
else if (strAttributeName  ==  convQxUserRolesByPotenceNum.RoleENName)
{
return mstrRoleENName;
}
else if (strAttributeName  ==  convQxUserRolesByPotenceNum.RoleIndex)
{
return mintRoleIndex;
}
else if (strAttributeName  ==  convQxUserRolesByPotenceNum.QxPrjId)
{
return mstrQxPrjId;
}
else if (strAttributeName  ==  convQxUserRolesByPotenceNum.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convQxUserRolesByPotenceNum.IsInUse)
{
return mbolIsInUse;
}
else if (strAttributeName  ==  convQxUserRolesByPotenceNum.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convQxUserRolesByPotenceNum.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convQxUserRolesByPotenceNum.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convQxUserRolesByPotenceNum.PotenceNum)
{
return mintPotenceNum;
}
return null;
}
set
{
if (strAttributeName  ==  convQxUserRolesByPotenceNum.RoleId)
{
mstrRoleId = value.ToString();
 AddUpdatedFld(convQxUserRolesByPotenceNum.RoleId);
}
else if (strAttributeName  ==  convQxUserRolesByPotenceNum.RoleName)
{
mstrRoleName = value.ToString();
 AddUpdatedFld(convQxUserRolesByPotenceNum.RoleName);
}
else if (strAttributeName  ==  convQxUserRolesByPotenceNum.RoleENName)
{
mstrRoleENName = value.ToString();
 AddUpdatedFld(convQxUserRolesByPotenceNum.RoleENName);
}
else if (strAttributeName  ==  convQxUserRolesByPotenceNum.RoleIndex)
{
mintRoleIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxUserRolesByPotenceNum.RoleIndex);
}
else if (strAttributeName  ==  convQxUserRolesByPotenceNum.QxPrjId)
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(convQxUserRolesByPotenceNum.QxPrjId);
}
else if (strAttributeName  ==  convQxUserRolesByPotenceNum.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convQxUserRolesByPotenceNum.PrjName);
}
else if (strAttributeName  ==  convQxUserRolesByPotenceNum.IsInUse)
{
mbolIsInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convQxUserRolesByPotenceNum.IsInUse);
}
else if (strAttributeName  ==  convQxUserRolesByPotenceNum.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convQxUserRolesByPotenceNum.UpdDate);
}
else if (strAttributeName  ==  convQxUserRolesByPotenceNum.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convQxUserRolesByPotenceNum.UpdUserId);
}
else if (strAttributeName  ==  convQxUserRolesByPotenceNum.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQxUserRolesByPotenceNum.Memo);
}
else if (strAttributeName  ==  convQxUserRolesByPotenceNum.PotenceNum)
{
mintPotenceNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxUserRolesByPotenceNum.PotenceNum);
}
}
}
public object this[int intIndex]
{
get
{
if (convQxUserRolesByPotenceNum.RoleId  ==  AttributeName[intIndex])
{
return mstrRoleId;
}
else if (convQxUserRolesByPotenceNum.RoleName  ==  AttributeName[intIndex])
{
return mstrRoleName;
}
else if (convQxUserRolesByPotenceNum.RoleENName  ==  AttributeName[intIndex])
{
return mstrRoleENName;
}
else if (convQxUserRolesByPotenceNum.RoleIndex  ==  AttributeName[intIndex])
{
return mintRoleIndex;
}
else if (convQxUserRolesByPotenceNum.QxPrjId  ==  AttributeName[intIndex])
{
return mstrQxPrjId;
}
else if (convQxUserRolesByPotenceNum.PrjName  ==  AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convQxUserRolesByPotenceNum.IsInUse  ==  AttributeName[intIndex])
{
return mbolIsInUse;
}
else if (convQxUserRolesByPotenceNum.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convQxUserRolesByPotenceNum.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convQxUserRolesByPotenceNum.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convQxUserRolesByPotenceNum.PotenceNum  ==  AttributeName[intIndex])
{
return mintPotenceNum;
}
return null;
}
set
{
if (convQxUserRolesByPotenceNum.RoleId  ==  AttributeName[intIndex])
{
mstrRoleId = value.ToString();
 AddUpdatedFld(convQxUserRolesByPotenceNum.RoleId);
}
else if (convQxUserRolesByPotenceNum.RoleName  ==  AttributeName[intIndex])
{
mstrRoleName = value.ToString();
 AddUpdatedFld(convQxUserRolesByPotenceNum.RoleName);
}
else if (convQxUserRolesByPotenceNum.RoleENName  ==  AttributeName[intIndex])
{
mstrRoleENName = value.ToString();
 AddUpdatedFld(convQxUserRolesByPotenceNum.RoleENName);
}
else if (convQxUserRolesByPotenceNum.RoleIndex  ==  AttributeName[intIndex])
{
mintRoleIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxUserRolesByPotenceNum.RoleIndex);
}
else if (convQxUserRolesByPotenceNum.QxPrjId  ==  AttributeName[intIndex])
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(convQxUserRolesByPotenceNum.QxPrjId);
}
else if (convQxUserRolesByPotenceNum.PrjName  ==  AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convQxUserRolesByPotenceNum.PrjName);
}
else if (convQxUserRolesByPotenceNum.IsInUse  ==  AttributeName[intIndex])
{
mbolIsInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convQxUserRolesByPotenceNum.IsInUse);
}
else if (convQxUserRolesByPotenceNum.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convQxUserRolesByPotenceNum.UpdDate);
}
else if (convQxUserRolesByPotenceNum.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convQxUserRolesByPotenceNum.UpdUserId);
}
else if (convQxUserRolesByPotenceNum.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQxUserRolesByPotenceNum.Memo);
}
else if (convQxUserRolesByPotenceNum.PotenceNum  ==  AttributeName[intIndex])
{
mintPotenceNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxUserRolesByPotenceNum.PotenceNum);
}
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
 AddUpdatedFld(convQxUserRolesByPotenceNum.RoleId);
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
 AddUpdatedFld(convQxUserRolesByPotenceNum.RoleName);
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
 AddUpdatedFld(convQxUserRolesByPotenceNum.RoleENName);
}
}
/// <summary>
/// 角色序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? RoleIndex
{
get
{
return mintRoleIndex;
}
set
{
 mintRoleIndex = value;
//记录修改过的字段
 AddUpdatedFld(convQxUserRolesByPotenceNum.RoleIndex);
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
 AddUpdatedFld(convQxUserRolesByPotenceNum.QxPrjId);
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
 AddUpdatedFld(convQxUserRolesByPotenceNum.PrjName);
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
 AddUpdatedFld(convQxUserRolesByPotenceNum.IsInUse);
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
 AddUpdatedFld(convQxUserRolesByPotenceNum.UpdDate);
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
 AddUpdatedFld(convQxUserRolesByPotenceNum.UpdUserId);
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
 AddUpdatedFld(convQxUserRolesByPotenceNum.Memo);
}
}
/// <summary>
/// PotenceNum(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? PotenceNum
{
get
{
return mintPotenceNum;
}
set
{
 mintPotenceNum = value;
//记录修改过的字段
 AddUpdatedFld(convQxUserRolesByPotenceNum.PotenceNum);
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
  return mstrRoleId;
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
 /// v角色By权限数(vQxUserRolesByPotenceNum)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convQxUserRolesByPotenceNum
{
public const string _CurrTabName = "vQxUserRolesByPotenceNum"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "RoleId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"RoleId", "RoleName", "RoleENName", "RoleIndex", "QxPrjId", "PrjName", "IsInUse", "UpdDate", "UpdUserId", "Memo", "PotenceNum"};
//以下是属性变量


 /// <summary>
 /// 常量:"RoleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RoleId = "RoleId";    //角色Id

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
 /// 常量:"PrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjName = "PrjName";    //工程名

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

 /// <summary>
 /// 常量:"PotenceNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PotenceNum = "PotenceNum";    //PotenceNum
}

}