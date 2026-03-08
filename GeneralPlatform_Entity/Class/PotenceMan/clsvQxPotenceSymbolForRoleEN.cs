
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPotenceSymbolForRoleEN
 表名:vQxPotenceSymbolForRole(00140047)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:32:34
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
 /// 表vQxPotenceSymbolForRole的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vQxPotenceSymbolForRole
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
public K_mId_vQxPotenceSymbolForRole(long lngmId)
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
 /// <returns>返回:[K_mId_vQxPotenceSymbolForRole]类型的对象</returns>
public static implicit operator K_mId_vQxPotenceSymbolForRole(long value)
{
return new K_mId_vQxPotenceSymbolForRole(value);
}
}
 /// <summary>
 /// vPotenceSymbolForRole(vQxPotenceSymbolForRole)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvQxPotenceSymbolForRoleEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vQxPotenceSymbolForRole"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"mId", "RoleId", "RelaMid", "PotenceId", "SymbolForProgramme", "PotenceName", "PotenceTypeId", "PotenceTypeName", "SymbolName"};

protected long mlngmId;    //流水号
protected string mstrRoleId;    //角色Id
protected long mlngRelaMid;    //流水号
protected string mstrPotenceId;    //权限ID
protected string mstrSymbolForProgramme;    //编程标志
protected string mstrPotenceName;    //权限名称
protected string mstrPotenceTypeId;    //权限类型Id
protected string mstrPotenceTypeName;    //权限类型名
protected string mstrSymbolName;    //标志名称

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvQxPotenceSymbolForRoleEN()
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
public clsvQxPotenceSymbolForRoleEN(long lngmId)
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
if (strAttributeName  ==  convQxPotenceSymbolForRole.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convQxPotenceSymbolForRole.RoleId)
{
return mstrRoleId;
}
else if (strAttributeName  ==  convQxPotenceSymbolForRole.RelaMid)
{
return mlngRelaMid;
}
else if (strAttributeName  ==  convQxPotenceSymbolForRole.PotenceId)
{
return mstrPotenceId;
}
else if (strAttributeName  ==  convQxPotenceSymbolForRole.SymbolForProgramme)
{
return mstrSymbolForProgramme;
}
else if (strAttributeName  ==  convQxPotenceSymbolForRole.PotenceName)
{
return mstrPotenceName;
}
else if (strAttributeName  ==  convQxPotenceSymbolForRole.PotenceTypeId)
{
return mstrPotenceTypeId;
}
else if (strAttributeName  ==  convQxPotenceSymbolForRole.PotenceTypeName)
{
return mstrPotenceTypeName;
}
else if (strAttributeName  ==  convQxPotenceSymbolForRole.SymbolName)
{
return mstrSymbolName;
}
return null;
}
set
{
if (strAttributeName  ==  convQxPotenceSymbolForRole.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxPotenceSymbolForRole.mId);
}
else if (strAttributeName  ==  convQxPotenceSymbolForRole.RoleId)
{
mstrRoleId = value.ToString();
 AddUpdatedFld(convQxPotenceSymbolForRole.RoleId);
}
else if (strAttributeName  ==  convQxPotenceSymbolForRole.RelaMid)
{
mlngRelaMid = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxPotenceSymbolForRole.RelaMid);
}
else if (strAttributeName  ==  convQxPotenceSymbolForRole.PotenceId)
{
mstrPotenceId = value.ToString();
 AddUpdatedFld(convQxPotenceSymbolForRole.PotenceId);
}
else if (strAttributeName  ==  convQxPotenceSymbolForRole.SymbolForProgramme)
{
mstrSymbolForProgramme = value.ToString();
 AddUpdatedFld(convQxPotenceSymbolForRole.SymbolForProgramme);
}
else if (strAttributeName  ==  convQxPotenceSymbolForRole.PotenceName)
{
mstrPotenceName = value.ToString();
 AddUpdatedFld(convQxPotenceSymbolForRole.PotenceName);
}
else if (strAttributeName  ==  convQxPotenceSymbolForRole.PotenceTypeId)
{
mstrPotenceTypeId = value.ToString();
 AddUpdatedFld(convQxPotenceSymbolForRole.PotenceTypeId);
}
else if (strAttributeName  ==  convQxPotenceSymbolForRole.PotenceTypeName)
{
mstrPotenceTypeName = value.ToString();
 AddUpdatedFld(convQxPotenceSymbolForRole.PotenceTypeName);
}
else if (strAttributeName  ==  convQxPotenceSymbolForRole.SymbolName)
{
mstrSymbolName = value.ToString();
 AddUpdatedFld(convQxPotenceSymbolForRole.SymbolName);
}
}
}
public object this[int intIndex]
{
get
{
if (convQxPotenceSymbolForRole.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convQxPotenceSymbolForRole.RoleId  ==  AttributeName[intIndex])
{
return mstrRoleId;
}
else if (convQxPotenceSymbolForRole.RelaMid  ==  AttributeName[intIndex])
{
return mlngRelaMid;
}
else if (convQxPotenceSymbolForRole.PotenceId  ==  AttributeName[intIndex])
{
return mstrPotenceId;
}
else if (convQxPotenceSymbolForRole.SymbolForProgramme  ==  AttributeName[intIndex])
{
return mstrSymbolForProgramme;
}
else if (convQxPotenceSymbolForRole.PotenceName  ==  AttributeName[intIndex])
{
return mstrPotenceName;
}
else if (convQxPotenceSymbolForRole.PotenceTypeId  ==  AttributeName[intIndex])
{
return mstrPotenceTypeId;
}
else if (convQxPotenceSymbolForRole.PotenceTypeName  ==  AttributeName[intIndex])
{
return mstrPotenceTypeName;
}
else if (convQxPotenceSymbolForRole.SymbolName  ==  AttributeName[intIndex])
{
return mstrSymbolName;
}
return null;
}
set
{
if (convQxPotenceSymbolForRole.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxPotenceSymbolForRole.mId);
}
else if (convQxPotenceSymbolForRole.RoleId  ==  AttributeName[intIndex])
{
mstrRoleId = value.ToString();
 AddUpdatedFld(convQxPotenceSymbolForRole.RoleId);
}
else if (convQxPotenceSymbolForRole.RelaMid  ==  AttributeName[intIndex])
{
mlngRelaMid = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxPotenceSymbolForRole.RelaMid);
}
else if (convQxPotenceSymbolForRole.PotenceId  ==  AttributeName[intIndex])
{
mstrPotenceId = value.ToString();
 AddUpdatedFld(convQxPotenceSymbolForRole.PotenceId);
}
else if (convQxPotenceSymbolForRole.SymbolForProgramme  ==  AttributeName[intIndex])
{
mstrSymbolForProgramme = value.ToString();
 AddUpdatedFld(convQxPotenceSymbolForRole.SymbolForProgramme);
}
else if (convQxPotenceSymbolForRole.PotenceName  ==  AttributeName[intIndex])
{
mstrPotenceName = value.ToString();
 AddUpdatedFld(convQxPotenceSymbolForRole.PotenceName);
}
else if (convQxPotenceSymbolForRole.PotenceTypeId  ==  AttributeName[intIndex])
{
mstrPotenceTypeId = value.ToString();
 AddUpdatedFld(convQxPotenceSymbolForRole.PotenceTypeId);
}
else if (convQxPotenceSymbolForRole.PotenceTypeName  ==  AttributeName[intIndex])
{
mstrPotenceTypeName = value.ToString();
 AddUpdatedFld(convQxPotenceSymbolForRole.PotenceTypeName);
}
else if (convQxPotenceSymbolForRole.SymbolName  ==  AttributeName[intIndex])
{
mstrSymbolName = value.ToString();
 AddUpdatedFld(convQxPotenceSymbolForRole.SymbolName);
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
 AddUpdatedFld(convQxPotenceSymbolForRole.mId);
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
 AddUpdatedFld(convQxPotenceSymbolForRole.RoleId);
}
}
/// <summary>
/// 流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long RelaMid
{
get
{
return mlngRelaMid;
}
set
{
 mlngRelaMid = value;
//记录修改过的字段
 AddUpdatedFld(convQxPotenceSymbolForRole.RelaMid);
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
 AddUpdatedFld(convQxPotenceSymbolForRole.PotenceId);
}
}
/// <summary>
/// 编程标志(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SymbolForProgramme
{
get
{
return mstrSymbolForProgramme;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSymbolForProgramme = value;
}
else
{
 mstrSymbolForProgramme = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPotenceSymbolForRole.SymbolForProgramme);
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
 AddUpdatedFld(convQxPotenceSymbolForRole.PotenceName);
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
 AddUpdatedFld(convQxPotenceSymbolForRole.PotenceTypeId);
}
}
/// <summary>
/// 权限类型名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PotenceTypeName
{
get
{
return mstrPotenceTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPotenceTypeName = value;
}
else
{
 mstrPotenceTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPotenceSymbolForRole.PotenceTypeName);
}
}
/// <summary>
/// 标志名称(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SymbolName
{
get
{
return mstrSymbolName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSymbolName = value;
}
else
{
 mstrSymbolName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPotenceSymbolForRole.SymbolName);
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
 /// vPotenceSymbolForRole(vQxPotenceSymbolForRole)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convQxPotenceSymbolForRole
{
public const string _CurrTabName = "vQxPotenceSymbolForRole"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "RoleId", "RelaMid", "PotenceId", "SymbolForProgramme", "PotenceName", "PotenceTypeId", "PotenceTypeName", "SymbolName"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //流水号

 /// <summary>
 /// 常量:"RoleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RoleId = "RoleId";    //角色Id

 /// <summary>
 /// 常量:"RelaMid"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RelaMid = "RelaMid";    //流水号

 /// <summary>
 /// 常量:"PotenceId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PotenceId = "PotenceId";    //权限ID

 /// <summary>
 /// 常量:"SymbolForProgramme"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SymbolForProgramme = "SymbolForProgramme";    //编程标志

 /// <summary>
 /// 常量:"PotenceName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PotenceName = "PotenceName";    //权限名称

 /// <summary>
 /// 常量:"PotenceTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PotenceTypeId = "PotenceTypeId";    //权限类型Id

 /// <summary>
 /// 常量:"PotenceTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PotenceTypeName = "PotenceTypeName";    //权限类型名

 /// <summary>
 /// 常量:"SymbolName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SymbolName = "SymbolName";    //标志名称
}

}