
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUserRolesEN
 表名:vQxUserRoles(00140025)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 17:42:50
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
 /// 表vQxUserRoles的关键字(RoleId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_RoleId_vQxUserRoles
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
public K_RoleId_vQxUserRoles(string strRoleId)
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
 /// <returns>返回:[K_RoleId_vQxUserRoles]类型的对象</returns>
public static implicit operator K_RoleId_vQxUserRoles(string value)
{
return new K_RoleId_vQxUserRoles(value);
}
}
 /// <summary>
 /// v角色(vQxUserRoles)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvQxUserRolesEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vQxUserRoles"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "RoleId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 10;
public static string[] AttributeName = new string[] {"RoleId", "RoleName", "RoleENName", "RoleIndex", "QxPrjId", "PrjName", "IsInUse", "UpdDate", "UpdUserId", "Memo"};

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

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvQxUserRolesEN()
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
public clsvQxUserRolesEN(string strRoleId)
 {
strRoleId = strRoleId.Replace("'", "''");
if (strRoleId.Length > 8)
{
throw new Exception("在表:vQxUserRoles中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strRoleId)  ==  true)
{
throw new Exception("在表:vQxUserRoles中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convQxUserRoles.RoleId)
{
return mstrRoleId;
}
else if (strAttributeName  ==  convQxUserRoles.RoleName)
{
return mstrRoleName;
}
else if (strAttributeName  ==  convQxUserRoles.RoleENName)
{
return mstrRoleENName;
}
else if (strAttributeName  ==  convQxUserRoles.RoleIndex)
{
return mintRoleIndex;
}
else if (strAttributeName  ==  convQxUserRoles.QxPrjId)
{
return mstrQxPrjId;
}
else if (strAttributeName  ==  convQxUserRoles.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convQxUserRoles.IsInUse)
{
return mbolIsInUse;
}
else if (strAttributeName  ==  convQxUserRoles.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convQxUserRoles.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convQxUserRoles.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convQxUserRoles.RoleId)
{
mstrRoleId = value.ToString();
 AddUpdatedFld(convQxUserRoles.RoleId);
}
else if (strAttributeName  ==  convQxUserRoles.RoleName)
{
mstrRoleName = value.ToString();
 AddUpdatedFld(convQxUserRoles.RoleName);
}
else if (strAttributeName  ==  convQxUserRoles.RoleENName)
{
mstrRoleENName = value.ToString();
 AddUpdatedFld(convQxUserRoles.RoleENName);
}
else if (strAttributeName  ==  convQxUserRoles.RoleIndex)
{
mintRoleIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxUserRoles.RoleIndex);
}
else if (strAttributeName  ==  convQxUserRoles.QxPrjId)
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(convQxUserRoles.QxPrjId);
}
else if (strAttributeName  ==  convQxUserRoles.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convQxUserRoles.PrjName);
}
else if (strAttributeName  ==  convQxUserRoles.IsInUse)
{
mbolIsInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convQxUserRoles.IsInUse);
}
else if (strAttributeName  ==  convQxUserRoles.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convQxUserRoles.UpdDate);
}
else if (strAttributeName  ==  convQxUserRoles.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convQxUserRoles.UpdUserId);
}
else if (strAttributeName  ==  convQxUserRoles.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQxUserRoles.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convQxUserRoles.RoleId  ==  AttributeName[intIndex])
{
return mstrRoleId;
}
else if (convQxUserRoles.RoleName  ==  AttributeName[intIndex])
{
return mstrRoleName;
}
else if (convQxUserRoles.RoleENName  ==  AttributeName[intIndex])
{
return mstrRoleENName;
}
else if (convQxUserRoles.RoleIndex  ==  AttributeName[intIndex])
{
return mintRoleIndex;
}
else if (convQxUserRoles.QxPrjId  ==  AttributeName[intIndex])
{
return mstrQxPrjId;
}
else if (convQxUserRoles.PrjName  ==  AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convQxUserRoles.IsInUse  ==  AttributeName[intIndex])
{
return mbolIsInUse;
}
else if (convQxUserRoles.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convQxUserRoles.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convQxUserRoles.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convQxUserRoles.RoleId  ==  AttributeName[intIndex])
{
mstrRoleId = value.ToString();
 AddUpdatedFld(convQxUserRoles.RoleId);
}
else if (convQxUserRoles.RoleName  ==  AttributeName[intIndex])
{
mstrRoleName = value.ToString();
 AddUpdatedFld(convQxUserRoles.RoleName);
}
else if (convQxUserRoles.RoleENName  ==  AttributeName[intIndex])
{
mstrRoleENName = value.ToString();
 AddUpdatedFld(convQxUserRoles.RoleENName);
}
else if (convQxUserRoles.RoleIndex  ==  AttributeName[intIndex])
{
mintRoleIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxUserRoles.RoleIndex);
}
else if (convQxUserRoles.QxPrjId  ==  AttributeName[intIndex])
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(convQxUserRoles.QxPrjId);
}
else if (convQxUserRoles.PrjName  ==  AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convQxUserRoles.PrjName);
}
else if (convQxUserRoles.IsInUse  ==  AttributeName[intIndex])
{
mbolIsInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convQxUserRoles.IsInUse);
}
else if (convQxUserRoles.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convQxUserRoles.UpdDate);
}
else if (convQxUserRoles.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convQxUserRoles.UpdUserId);
}
else if (convQxUserRoles.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQxUserRoles.Memo);
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
 AddUpdatedFld(convQxUserRoles.RoleId);
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
 AddUpdatedFld(convQxUserRoles.RoleName);
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
 AddUpdatedFld(convQxUserRoles.RoleENName);
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
 AddUpdatedFld(convQxUserRoles.RoleIndex);
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
 AddUpdatedFld(convQxUserRoles.QxPrjId);
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
 AddUpdatedFld(convQxUserRoles.PrjName);
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
 AddUpdatedFld(convQxUserRoles.IsInUse);
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
 AddUpdatedFld(convQxUserRoles.UpdDate);
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
 AddUpdatedFld(convQxUserRoles.UpdUserId);
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
 AddUpdatedFld(convQxUserRoles.Memo);
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
}
 /// <summary>
 /// v角色(vQxUserRoles)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convQxUserRoles
{
public const string _CurrTabName = "vQxUserRoles"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "RoleId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"RoleId", "RoleName", "RoleENName", "RoleIndex", "QxPrjId", "PrjName", "IsInUse", "UpdDate", "UpdUserId", "Memo"};
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
}

}