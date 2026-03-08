
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPrjUserRelationByRoleEN
 表名:vQxPrjUserRelationByRole(00140076)
 * 版本:2023.12.26.1(服务器:WIN-SRV103-116)
 日期:2023/12/28 18:48:57
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
 /// 表vQxPrjUserRelationByRole的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vQxPrjUserRelationByRole
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
public K_mId_vQxPrjUserRelationByRole(long lngmId)
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
 /// <returns>返回:[K_mId_vQxPrjUserRelationByRole]类型的对象</returns>
public static implicit operator K_mId_vQxPrjUserRelationByRole(long value)
{
return new K_mId_vQxPrjUserRelationByRole(value);
}
}
 /// <summary>
 /// v工程用户关系ByRole(vQxPrjUserRelationByRole)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvQxPrjUserRelationByRoleEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vQxPrjUserRelationByRole"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 12;
public static string[] AttributeName = new string[] {"mId", "QxPrjId", "IdentityId", "RoleId", "RoleName", "PrjName", "UserId", "UserName", "DepartmentId", "DepartmentName", "UserStateName", "IdentityDesc"};

protected long mlngmId;    //流水号
protected string mstrQxPrjId;    //项目Id
protected string mstrIdentityId;    //身份编号
protected string mstrRoleId;    //角色Id
protected string mstrRoleName;    //角色名称
protected string mstrPrjName;    //工程名
protected string mstrUserId;    //用户ID
protected string mstrUserName;    //用户名
protected string mstrDepartmentId;    //部门Id
protected string mstrDepartmentName;    //部门名
protected string mstrUserStateName;    //用户状态名
protected string mstrIdentityDesc;    //身份描述

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvQxPrjUserRelationByRoleEN()
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
public clsvQxPrjUserRelationByRoleEN(long lngmId)
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
if (strAttributeName  ==  convQxPrjUserRelationByRole.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convQxPrjUserRelationByRole.QxPrjId)
{
return mstrQxPrjId;
}
else if (strAttributeName  ==  convQxPrjUserRelationByRole.IdentityId)
{
return mstrIdentityId;
}
else if (strAttributeName  ==  convQxPrjUserRelationByRole.RoleId)
{
return mstrRoleId;
}
else if (strAttributeName  ==  convQxPrjUserRelationByRole.RoleName)
{
return mstrRoleName;
}
else if (strAttributeName  ==  convQxPrjUserRelationByRole.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convQxPrjUserRelationByRole.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convQxPrjUserRelationByRole.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convQxPrjUserRelationByRole.DepartmentId)
{
return mstrDepartmentId;
}
else if (strAttributeName  ==  convQxPrjUserRelationByRole.DepartmentName)
{
return mstrDepartmentName;
}
else if (strAttributeName  ==  convQxPrjUserRelationByRole.UserStateName)
{
return mstrUserStateName;
}
else if (strAttributeName  ==  convQxPrjUserRelationByRole.IdentityDesc)
{
return mstrIdentityDesc;
}
return null;
}
set
{
if (strAttributeName  ==  convQxPrjUserRelationByRole.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxPrjUserRelationByRole.mId);
}
else if (strAttributeName  ==  convQxPrjUserRelationByRole.QxPrjId)
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(convQxPrjUserRelationByRole.QxPrjId);
}
else if (strAttributeName  ==  convQxPrjUserRelationByRole.IdentityId)
{
mstrIdentityId = value.ToString();
 AddUpdatedFld(convQxPrjUserRelationByRole.IdentityId);
}
else if (strAttributeName  ==  convQxPrjUserRelationByRole.RoleId)
{
mstrRoleId = value.ToString();
 AddUpdatedFld(convQxPrjUserRelationByRole.RoleId);
}
else if (strAttributeName  ==  convQxPrjUserRelationByRole.RoleName)
{
mstrRoleName = value.ToString();
 AddUpdatedFld(convQxPrjUserRelationByRole.RoleName);
}
else if (strAttributeName  ==  convQxPrjUserRelationByRole.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convQxPrjUserRelationByRole.PrjName);
}
else if (strAttributeName  ==  convQxPrjUserRelationByRole.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convQxPrjUserRelationByRole.UserId);
}
else if (strAttributeName  ==  convQxPrjUserRelationByRole.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convQxPrjUserRelationByRole.UserName);
}
else if (strAttributeName  ==  convQxPrjUserRelationByRole.DepartmentId)
{
mstrDepartmentId = value.ToString();
 AddUpdatedFld(convQxPrjUserRelationByRole.DepartmentId);
}
else if (strAttributeName  ==  convQxPrjUserRelationByRole.DepartmentName)
{
mstrDepartmentName = value.ToString();
 AddUpdatedFld(convQxPrjUserRelationByRole.DepartmentName);
}
else if (strAttributeName  ==  convQxPrjUserRelationByRole.UserStateName)
{
mstrUserStateName = value.ToString();
 AddUpdatedFld(convQxPrjUserRelationByRole.UserStateName);
}
else if (strAttributeName  ==  convQxPrjUserRelationByRole.IdentityDesc)
{
mstrIdentityDesc = value.ToString();
 AddUpdatedFld(convQxPrjUserRelationByRole.IdentityDesc);
}
}
}
public object this[int intIndex]
{
get
{
if (convQxPrjUserRelationByRole.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convQxPrjUserRelationByRole.QxPrjId  ==  AttributeName[intIndex])
{
return mstrQxPrjId;
}
else if (convQxPrjUserRelationByRole.IdentityId  ==  AttributeName[intIndex])
{
return mstrIdentityId;
}
else if (convQxPrjUserRelationByRole.RoleId  ==  AttributeName[intIndex])
{
return mstrRoleId;
}
else if (convQxPrjUserRelationByRole.RoleName  ==  AttributeName[intIndex])
{
return mstrRoleName;
}
else if (convQxPrjUserRelationByRole.PrjName  ==  AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convQxPrjUserRelationByRole.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convQxPrjUserRelationByRole.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convQxPrjUserRelationByRole.DepartmentId  ==  AttributeName[intIndex])
{
return mstrDepartmentId;
}
else if (convQxPrjUserRelationByRole.DepartmentName  ==  AttributeName[intIndex])
{
return mstrDepartmentName;
}
else if (convQxPrjUserRelationByRole.UserStateName  ==  AttributeName[intIndex])
{
return mstrUserStateName;
}
else if (convQxPrjUserRelationByRole.IdentityDesc  ==  AttributeName[intIndex])
{
return mstrIdentityDesc;
}
return null;
}
set
{
if (convQxPrjUserRelationByRole.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxPrjUserRelationByRole.mId);
}
else if (convQxPrjUserRelationByRole.QxPrjId  ==  AttributeName[intIndex])
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(convQxPrjUserRelationByRole.QxPrjId);
}
else if (convQxPrjUserRelationByRole.IdentityId  ==  AttributeName[intIndex])
{
mstrIdentityId = value.ToString();
 AddUpdatedFld(convQxPrjUserRelationByRole.IdentityId);
}
else if (convQxPrjUserRelationByRole.RoleId  ==  AttributeName[intIndex])
{
mstrRoleId = value.ToString();
 AddUpdatedFld(convQxPrjUserRelationByRole.RoleId);
}
else if (convQxPrjUserRelationByRole.RoleName  ==  AttributeName[intIndex])
{
mstrRoleName = value.ToString();
 AddUpdatedFld(convQxPrjUserRelationByRole.RoleName);
}
else if (convQxPrjUserRelationByRole.PrjName  ==  AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convQxPrjUserRelationByRole.PrjName);
}
else if (convQxPrjUserRelationByRole.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convQxPrjUserRelationByRole.UserId);
}
else if (convQxPrjUserRelationByRole.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convQxPrjUserRelationByRole.UserName);
}
else if (convQxPrjUserRelationByRole.DepartmentId  ==  AttributeName[intIndex])
{
mstrDepartmentId = value.ToString();
 AddUpdatedFld(convQxPrjUserRelationByRole.DepartmentId);
}
else if (convQxPrjUserRelationByRole.DepartmentName  ==  AttributeName[intIndex])
{
mstrDepartmentName = value.ToString();
 AddUpdatedFld(convQxPrjUserRelationByRole.DepartmentName);
}
else if (convQxPrjUserRelationByRole.UserStateName  ==  AttributeName[intIndex])
{
mstrUserStateName = value.ToString();
 AddUpdatedFld(convQxPrjUserRelationByRole.UserStateName);
}
else if (convQxPrjUserRelationByRole.IdentityDesc  ==  AttributeName[intIndex])
{
mstrIdentityDesc = value.ToString();
 AddUpdatedFld(convQxPrjUserRelationByRole.IdentityDesc);
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
 AddUpdatedFld(convQxPrjUserRelationByRole.mId);
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
 AddUpdatedFld(convQxPrjUserRelationByRole.QxPrjId);
}
}
/// <summary>
/// 身份编号(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdentityId
{
get
{
return mstrIdentityId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdentityId = value;
}
else
{
 mstrIdentityId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPrjUserRelationByRole.IdentityId);
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
 AddUpdatedFld(convQxPrjUserRelationByRole.RoleId);
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
 AddUpdatedFld(convQxPrjUserRelationByRole.RoleName);
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
 AddUpdatedFld(convQxPrjUserRelationByRole.PrjName);
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
 AddUpdatedFld(convQxPrjUserRelationByRole.UserId);
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
 AddUpdatedFld(convQxPrjUserRelationByRole.UserName);
}
}
/// <summary>
/// 部门Id(说明:;字段类型:varchar;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DepartmentId
{
get
{
return mstrDepartmentId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDepartmentId = value;
}
else
{
 mstrDepartmentId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPrjUserRelationByRole.DepartmentId);
}
}
/// <summary>
/// 部门名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DepartmentName
{
get
{
return mstrDepartmentName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDepartmentName = value;
}
else
{
 mstrDepartmentName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPrjUserRelationByRole.DepartmentName);
}
}
/// <summary>
/// 用户状态名(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserStateName
{
get
{
return mstrUserStateName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserStateName = value;
}
else
{
 mstrUserStateName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPrjUserRelationByRole.UserStateName);
}
}
/// <summary>
/// 身份描述(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdentityDesc
{
get
{
return mstrIdentityDesc;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdentityDesc = value;
}
else
{
 mstrIdentityDesc = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPrjUserRelationByRole.IdentityDesc);
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
 /// v工程用户关系ByRole(vQxPrjUserRelationByRole)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convQxPrjUserRelationByRole
{
public const string _CurrTabName = "vQxPrjUserRelationByRole"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "QxPrjId", "IdentityId", "RoleId", "RoleName", "PrjName", "UserId", "UserName", "DepartmentId", "DepartmentName", "UserStateName", "IdentityDesc"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //流水号

 /// <summary>
 /// 常量:"QxPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QxPrjId = "QxPrjId";    //项目Id

 /// <summary>
 /// 常量:"IdentityId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdentityId = "IdentityId";    //身份编号

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
 /// 常量:"PrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjName = "PrjName";    //工程名

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
 /// 常量:"DepartmentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DepartmentId = "DepartmentId";    //部门Id

 /// <summary>
 /// 常量:"DepartmentName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DepartmentName = "DepartmentName";    //部门名

 /// <summary>
 /// 常量:"UserStateName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserStateName = "UserStateName";    //用户状态名

 /// <summary>
 /// 常量:"IdentityDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdentityDesc = "IdentityDesc";    //身份描述
}

}