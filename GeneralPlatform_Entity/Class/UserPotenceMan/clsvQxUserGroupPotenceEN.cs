
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUserGroupPotenceEN
 表名:vQxUserGroupPotence(00140022)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 17:42:30
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
 /// 表vQxUserGroupPotence的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vQxUserGroupPotence
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
public K_mId_vQxUserGroupPotence(long lngmId)
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
 /// <returns>返回:[K_mId_vQxUserGroupPotence]类型的对象</returns>
public static implicit operator K_mId_vQxUserGroupPotence(long value)
{
return new K_mId_vQxUserGroupPotence(value);
}
}
 /// <summary>
 /// v用户权限关系(vQxUserGroupPotence)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvQxUserGroupPotenceEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vQxUserGroupPotence"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 20;
public static string[] AttributeName = new string[] {"mId", "UserId", "UserName", "GroupId", "GroupName", "RoleId", "RoleName", "QxPrjId", "PrjName", "PotenceId", "PotenceName", "PotenceTypeId", "PotenceTypeName", "MenuId", "MenuName", "UpMenuId", "RelaMid", "SymbolForProgramme", "SymbolName", "Memo"};

protected long mlngmId;    //流水号
protected string mstrUserId;    //用户ID
protected string mstrUserName;    //用户名
protected string mstrGroupId;    //组Id
protected string mstrGroupName;    //组名
protected string mstrRoleId;    //角色Id
protected string mstrRoleName;    //角色名称
protected string mstrQxPrjId;    //项目Id
protected string mstrPrjName;    //工程名
protected string mstrPotenceId;    //权限ID
protected string mstrPotenceName;    //权限名称
protected string mstrPotenceTypeId;    //权限类型Id
protected string mstrPotenceTypeName;    //权限类型名
protected string mstrMenuId;    //菜单Id
protected string mstrMenuName;    //菜单名
protected string mstrUpMenuId;    //上级菜单Id
protected long? mlngRelaMid;    //流水号
protected string mstrSymbolForProgramme;    //编程标志
protected string mstrSymbolName;    //标志名称
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvQxUserGroupPotenceEN()
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
public clsvQxUserGroupPotenceEN(long lngmId)
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
if (strAttributeName  ==  convQxUserGroupPotence.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convQxUserGroupPotence.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convQxUserGroupPotence.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convQxUserGroupPotence.GroupId)
{
return mstrGroupId;
}
else if (strAttributeName  ==  convQxUserGroupPotence.GroupName)
{
return mstrGroupName;
}
else if (strAttributeName  ==  convQxUserGroupPotence.RoleId)
{
return mstrRoleId;
}
else if (strAttributeName  ==  convQxUserGroupPotence.RoleName)
{
return mstrRoleName;
}
else if (strAttributeName  ==  convQxUserGroupPotence.QxPrjId)
{
return mstrQxPrjId;
}
else if (strAttributeName  ==  convQxUserGroupPotence.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convQxUserGroupPotence.PotenceId)
{
return mstrPotenceId;
}
else if (strAttributeName  ==  convQxUserGroupPotence.PotenceName)
{
return mstrPotenceName;
}
else if (strAttributeName  ==  convQxUserGroupPotence.PotenceTypeId)
{
return mstrPotenceTypeId;
}
else if (strAttributeName  ==  convQxUserGroupPotence.PotenceTypeName)
{
return mstrPotenceTypeName;
}
else if (strAttributeName  ==  convQxUserGroupPotence.MenuId)
{
return mstrMenuId;
}
else if (strAttributeName  ==  convQxUserGroupPotence.MenuName)
{
return mstrMenuName;
}
else if (strAttributeName  ==  convQxUserGroupPotence.UpMenuId)
{
return mstrUpMenuId;
}
else if (strAttributeName  ==  convQxUserGroupPotence.RelaMid)
{
return mlngRelaMid;
}
else if (strAttributeName  ==  convQxUserGroupPotence.SymbolForProgramme)
{
return mstrSymbolForProgramme;
}
else if (strAttributeName  ==  convQxUserGroupPotence.SymbolName)
{
return mstrSymbolName;
}
else if (strAttributeName  ==  convQxUserGroupPotence.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convQxUserGroupPotence.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxUserGroupPotence.mId);
}
else if (strAttributeName  ==  convQxUserGroupPotence.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convQxUserGroupPotence.UserId);
}
else if (strAttributeName  ==  convQxUserGroupPotence.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convQxUserGroupPotence.UserName);
}
else if (strAttributeName  ==  convQxUserGroupPotence.GroupId)
{
mstrGroupId = value.ToString();
 AddUpdatedFld(convQxUserGroupPotence.GroupId);
}
else if (strAttributeName  ==  convQxUserGroupPotence.GroupName)
{
mstrGroupName = value.ToString();
 AddUpdatedFld(convQxUserGroupPotence.GroupName);
}
else if (strAttributeName  ==  convQxUserGroupPotence.RoleId)
{
mstrRoleId = value.ToString();
 AddUpdatedFld(convQxUserGroupPotence.RoleId);
}
else if (strAttributeName  ==  convQxUserGroupPotence.RoleName)
{
mstrRoleName = value.ToString();
 AddUpdatedFld(convQxUserGroupPotence.RoleName);
}
else if (strAttributeName  ==  convQxUserGroupPotence.QxPrjId)
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(convQxUserGroupPotence.QxPrjId);
}
else if (strAttributeName  ==  convQxUserGroupPotence.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convQxUserGroupPotence.PrjName);
}
else if (strAttributeName  ==  convQxUserGroupPotence.PotenceId)
{
mstrPotenceId = value.ToString();
 AddUpdatedFld(convQxUserGroupPotence.PotenceId);
}
else if (strAttributeName  ==  convQxUserGroupPotence.PotenceName)
{
mstrPotenceName = value.ToString();
 AddUpdatedFld(convQxUserGroupPotence.PotenceName);
}
else if (strAttributeName  ==  convQxUserGroupPotence.PotenceTypeId)
{
mstrPotenceTypeId = value.ToString();
 AddUpdatedFld(convQxUserGroupPotence.PotenceTypeId);
}
else if (strAttributeName  ==  convQxUserGroupPotence.PotenceTypeName)
{
mstrPotenceTypeName = value.ToString();
 AddUpdatedFld(convQxUserGroupPotence.PotenceTypeName);
}
else if (strAttributeName  ==  convQxUserGroupPotence.MenuId)
{
mstrMenuId = value.ToString();
 AddUpdatedFld(convQxUserGroupPotence.MenuId);
}
else if (strAttributeName  ==  convQxUserGroupPotence.MenuName)
{
mstrMenuName = value.ToString();
 AddUpdatedFld(convQxUserGroupPotence.MenuName);
}
else if (strAttributeName  ==  convQxUserGroupPotence.UpMenuId)
{
mstrUpMenuId = value.ToString();
 AddUpdatedFld(convQxUserGroupPotence.UpMenuId);
}
else if (strAttributeName  ==  convQxUserGroupPotence.RelaMid)
{
mlngRelaMid = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxUserGroupPotence.RelaMid);
}
else if (strAttributeName  ==  convQxUserGroupPotence.SymbolForProgramme)
{
mstrSymbolForProgramme = value.ToString();
 AddUpdatedFld(convQxUserGroupPotence.SymbolForProgramme);
}
else if (strAttributeName  ==  convQxUserGroupPotence.SymbolName)
{
mstrSymbolName = value.ToString();
 AddUpdatedFld(convQxUserGroupPotence.SymbolName);
}
else if (strAttributeName  ==  convQxUserGroupPotence.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQxUserGroupPotence.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convQxUserGroupPotence.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convQxUserGroupPotence.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convQxUserGroupPotence.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convQxUserGroupPotence.GroupId  ==  AttributeName[intIndex])
{
return mstrGroupId;
}
else if (convQxUserGroupPotence.GroupName  ==  AttributeName[intIndex])
{
return mstrGroupName;
}
else if (convQxUserGroupPotence.RoleId  ==  AttributeName[intIndex])
{
return mstrRoleId;
}
else if (convQxUserGroupPotence.RoleName  ==  AttributeName[intIndex])
{
return mstrRoleName;
}
else if (convQxUserGroupPotence.QxPrjId  ==  AttributeName[intIndex])
{
return mstrQxPrjId;
}
else if (convQxUserGroupPotence.PrjName  ==  AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convQxUserGroupPotence.PotenceId  ==  AttributeName[intIndex])
{
return mstrPotenceId;
}
else if (convQxUserGroupPotence.PotenceName  ==  AttributeName[intIndex])
{
return mstrPotenceName;
}
else if (convQxUserGroupPotence.PotenceTypeId  ==  AttributeName[intIndex])
{
return mstrPotenceTypeId;
}
else if (convQxUserGroupPotence.PotenceTypeName  ==  AttributeName[intIndex])
{
return mstrPotenceTypeName;
}
else if (convQxUserGroupPotence.MenuId  ==  AttributeName[intIndex])
{
return mstrMenuId;
}
else if (convQxUserGroupPotence.MenuName  ==  AttributeName[intIndex])
{
return mstrMenuName;
}
else if (convQxUserGroupPotence.UpMenuId  ==  AttributeName[intIndex])
{
return mstrUpMenuId;
}
else if (convQxUserGroupPotence.RelaMid  ==  AttributeName[intIndex])
{
return mlngRelaMid;
}
else if (convQxUserGroupPotence.SymbolForProgramme  ==  AttributeName[intIndex])
{
return mstrSymbolForProgramme;
}
else if (convQxUserGroupPotence.SymbolName  ==  AttributeName[intIndex])
{
return mstrSymbolName;
}
else if (convQxUserGroupPotence.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convQxUserGroupPotence.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxUserGroupPotence.mId);
}
else if (convQxUserGroupPotence.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convQxUserGroupPotence.UserId);
}
else if (convQxUserGroupPotence.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convQxUserGroupPotence.UserName);
}
else if (convQxUserGroupPotence.GroupId  ==  AttributeName[intIndex])
{
mstrGroupId = value.ToString();
 AddUpdatedFld(convQxUserGroupPotence.GroupId);
}
else if (convQxUserGroupPotence.GroupName  ==  AttributeName[intIndex])
{
mstrGroupName = value.ToString();
 AddUpdatedFld(convQxUserGroupPotence.GroupName);
}
else if (convQxUserGroupPotence.RoleId  ==  AttributeName[intIndex])
{
mstrRoleId = value.ToString();
 AddUpdatedFld(convQxUserGroupPotence.RoleId);
}
else if (convQxUserGroupPotence.RoleName  ==  AttributeName[intIndex])
{
mstrRoleName = value.ToString();
 AddUpdatedFld(convQxUserGroupPotence.RoleName);
}
else if (convQxUserGroupPotence.QxPrjId  ==  AttributeName[intIndex])
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(convQxUserGroupPotence.QxPrjId);
}
else if (convQxUserGroupPotence.PrjName  ==  AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convQxUserGroupPotence.PrjName);
}
else if (convQxUserGroupPotence.PotenceId  ==  AttributeName[intIndex])
{
mstrPotenceId = value.ToString();
 AddUpdatedFld(convQxUserGroupPotence.PotenceId);
}
else if (convQxUserGroupPotence.PotenceName  ==  AttributeName[intIndex])
{
mstrPotenceName = value.ToString();
 AddUpdatedFld(convQxUserGroupPotence.PotenceName);
}
else if (convQxUserGroupPotence.PotenceTypeId  ==  AttributeName[intIndex])
{
mstrPotenceTypeId = value.ToString();
 AddUpdatedFld(convQxUserGroupPotence.PotenceTypeId);
}
else if (convQxUserGroupPotence.PotenceTypeName  ==  AttributeName[intIndex])
{
mstrPotenceTypeName = value.ToString();
 AddUpdatedFld(convQxUserGroupPotence.PotenceTypeName);
}
else if (convQxUserGroupPotence.MenuId  ==  AttributeName[intIndex])
{
mstrMenuId = value.ToString();
 AddUpdatedFld(convQxUserGroupPotence.MenuId);
}
else if (convQxUserGroupPotence.MenuName  ==  AttributeName[intIndex])
{
mstrMenuName = value.ToString();
 AddUpdatedFld(convQxUserGroupPotence.MenuName);
}
else if (convQxUserGroupPotence.UpMenuId  ==  AttributeName[intIndex])
{
mstrUpMenuId = value.ToString();
 AddUpdatedFld(convQxUserGroupPotence.UpMenuId);
}
else if (convQxUserGroupPotence.RelaMid  ==  AttributeName[intIndex])
{
mlngRelaMid = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxUserGroupPotence.RelaMid);
}
else if (convQxUserGroupPotence.SymbolForProgramme  ==  AttributeName[intIndex])
{
mstrSymbolForProgramme = value.ToString();
 AddUpdatedFld(convQxUserGroupPotence.SymbolForProgramme);
}
else if (convQxUserGroupPotence.SymbolName  ==  AttributeName[intIndex])
{
mstrSymbolName = value.ToString();
 AddUpdatedFld(convQxUserGroupPotence.SymbolName);
}
else if (convQxUserGroupPotence.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQxUserGroupPotence.Memo);
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
 AddUpdatedFld(convQxUserGroupPotence.mId);
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
 AddUpdatedFld(convQxUserGroupPotence.UserId);
}
}
/// <summary>
/// 用户名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserName
{
get
{
return mstrUserName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserName = value;
}
else
{
 mstrUserName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUserGroupPotence.UserName);
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
 AddUpdatedFld(convQxUserGroupPotence.GroupId);
}
}
/// <summary>
/// 组名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GroupName
{
get
{
return mstrGroupName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGroupName = value;
}
else
{
 mstrGroupName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUserGroupPotence.GroupName);
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
 AddUpdatedFld(convQxUserGroupPotence.RoleId);
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
 AddUpdatedFld(convQxUserGroupPotence.RoleName);
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
 AddUpdatedFld(convQxUserGroupPotence.QxPrjId);
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
 AddUpdatedFld(convQxUserGroupPotence.PrjName);
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
 AddUpdatedFld(convQxUserGroupPotence.PotenceId);
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
 AddUpdatedFld(convQxUserGroupPotence.PotenceName);
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
 AddUpdatedFld(convQxUserGroupPotence.PotenceTypeId);
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
 AddUpdatedFld(convQxUserGroupPotence.PotenceTypeName);
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
 AddUpdatedFld(convQxUserGroupPotence.MenuId);
}
}
/// <summary>
/// 菜单名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MenuName
{
get
{
return mstrMenuName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMenuName = value;
}
else
{
 mstrMenuName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUserGroupPotence.MenuName);
}
}
/// <summary>
/// 上级菜单Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpMenuId
{
get
{
return mstrUpMenuId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpMenuId = value;
}
else
{
 mstrUpMenuId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUserGroupPotence.UpMenuId);
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
 AddUpdatedFld(convQxUserGroupPotence.RelaMid);
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
 AddUpdatedFld(convQxUserGroupPotence.SymbolForProgramme);
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
 AddUpdatedFld(convQxUserGroupPotence.SymbolName);
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
 AddUpdatedFld(convQxUserGroupPotence.Memo);
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
 /// v用户权限关系(vQxUserGroupPotence)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convQxUserGroupPotence
{
public const string _CurrTabName = "vQxUserGroupPotence"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "UserId", "UserName", "GroupId", "GroupName", "RoleId", "RoleName", "QxPrjId", "PrjName", "PotenceId", "PotenceName", "PotenceTypeId", "PotenceTypeName", "MenuId", "MenuName", "UpMenuId", "RelaMid", "SymbolForProgramme", "SymbolName", "Memo"};
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
 /// 常量:"UserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserName = "UserName";    //用户名

 /// <summary>
 /// 常量:"GroupId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GroupId = "GroupId";    //组Id

 /// <summary>
 /// 常量:"GroupName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GroupName = "GroupName";    //组名

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
 /// 常量:"PotenceId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PotenceId = "PotenceId";    //权限ID

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
 /// 常量:"MenuId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MenuId = "MenuId";    //菜单Id

 /// <summary>
 /// 常量:"MenuName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MenuName = "MenuName";    //菜单名

 /// <summary>
 /// 常量:"UpMenuId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpMenuId = "UpMenuId";    //上级菜单Id

 /// <summary>
 /// 常量:"RelaMid"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RelaMid = "RelaMid";    //流水号

 /// <summary>
 /// 常量:"SymbolForProgramme"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SymbolForProgramme = "SymbolForProgramme";    //编程标志

 /// <summary>
 /// 常量:"SymbolName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SymbolName = "SymbolName";    //标志名称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}