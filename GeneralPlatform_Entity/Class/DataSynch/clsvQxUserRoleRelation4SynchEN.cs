
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUserRoleRelation4SynchEN
 表名:vQxUserRoleRelation4Synch(00140095)
 * 版本:2023.12.26.1(服务器:WIN-SRV103-116)
 日期:2023/12/28 18:46:18
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:数据同步(DataSynch)
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
 /// 表vQxUserRoleRelation4Synch的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vQxUserRoleRelation4Synch
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
public K_mId_vQxUserRoleRelation4Synch(long lngmId)
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
 /// <returns>返回:[K_mId_vQxUserRoleRelation4Synch]类型的对象</returns>
public static implicit operator K_mId_vQxUserRoleRelation4Synch(long value)
{
return new K_mId_vQxUserRoleRelation4Synch(value);
}
}
 /// <summary>
 /// v用户角色关系4同步(vQxUserRoleRelation4Synch)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvQxUserRoleRelation4SynchEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vQxUserRoleRelation4Synch"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 18;
public static string[] AttributeName = new string[] {"mId", "IpAddress", "UserId", "UserName", "DepartmentId", "DepartmentName", "UserStateId", "UserStateName", "StuTeacherId", "IdentityId", "IdentityDesc", "RoleId", "RoleName", "QxPrjId", "PrjName", "UpdDate", "UpdUserId", "Memo"};

protected long mlngmId;    //流水号
protected string mstrIpAddress;    //IP地址
protected string mstrUserId;    //用户ID
protected string mstrUserName;    //用户名
protected string mstrDepartmentId;    //部门Id
protected string mstrDepartmentName;    //部门名
protected string mstrUserStateId;    //用户状态Id
protected string mstrUserStateName;    //用户状态名
protected string mstrStuTeacherId;    //学工号
protected string mstrIdentityId;    //身份编号
protected string mstrIdentityDesc;    //身份描述
protected string mstrRoleId;    //角色Id
protected string mstrRoleName;    //角色名称
protected string mstrQxPrjId;    //项目Id
protected string mstrPrjName;    //工程名
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvQxUserRoleRelation4SynchEN()
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
public clsvQxUserRoleRelation4SynchEN(long lngmId)
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
if (strAttributeName  ==  convQxUserRoleRelation4Synch.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convQxUserRoleRelation4Synch.IpAddress)
{
return mstrIpAddress;
}
else if (strAttributeName  ==  convQxUserRoleRelation4Synch.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convQxUserRoleRelation4Synch.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convQxUserRoleRelation4Synch.DepartmentId)
{
return mstrDepartmentId;
}
else if (strAttributeName  ==  convQxUserRoleRelation4Synch.DepartmentName)
{
return mstrDepartmentName;
}
else if (strAttributeName  ==  convQxUserRoleRelation4Synch.UserStateId)
{
return mstrUserStateId;
}
else if (strAttributeName  ==  convQxUserRoleRelation4Synch.UserStateName)
{
return mstrUserStateName;
}
else if (strAttributeName  ==  convQxUserRoleRelation4Synch.StuTeacherId)
{
return mstrStuTeacherId;
}
else if (strAttributeName  ==  convQxUserRoleRelation4Synch.IdentityId)
{
return mstrIdentityId;
}
else if (strAttributeName  ==  convQxUserRoleRelation4Synch.IdentityDesc)
{
return mstrIdentityDesc;
}
else if (strAttributeName  ==  convQxUserRoleRelation4Synch.RoleId)
{
return mstrRoleId;
}
else if (strAttributeName  ==  convQxUserRoleRelation4Synch.RoleName)
{
return mstrRoleName;
}
else if (strAttributeName  ==  convQxUserRoleRelation4Synch.QxPrjId)
{
return mstrQxPrjId;
}
else if (strAttributeName  ==  convQxUserRoleRelation4Synch.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convQxUserRoleRelation4Synch.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convQxUserRoleRelation4Synch.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convQxUserRoleRelation4Synch.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convQxUserRoleRelation4Synch.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxUserRoleRelation4Synch.mId);
}
else if (strAttributeName  ==  convQxUserRoleRelation4Synch.IpAddress)
{
mstrIpAddress = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation4Synch.IpAddress);
}
else if (strAttributeName  ==  convQxUserRoleRelation4Synch.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation4Synch.UserId);
}
else if (strAttributeName  ==  convQxUserRoleRelation4Synch.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation4Synch.UserName);
}
else if (strAttributeName  ==  convQxUserRoleRelation4Synch.DepartmentId)
{
mstrDepartmentId = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation4Synch.DepartmentId);
}
else if (strAttributeName  ==  convQxUserRoleRelation4Synch.DepartmentName)
{
mstrDepartmentName = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation4Synch.DepartmentName);
}
else if (strAttributeName  ==  convQxUserRoleRelation4Synch.UserStateId)
{
mstrUserStateId = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation4Synch.UserStateId);
}
else if (strAttributeName  ==  convQxUserRoleRelation4Synch.UserStateName)
{
mstrUserStateName = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation4Synch.UserStateName);
}
else if (strAttributeName  ==  convQxUserRoleRelation4Synch.StuTeacherId)
{
mstrStuTeacherId = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation4Synch.StuTeacherId);
}
else if (strAttributeName  ==  convQxUserRoleRelation4Synch.IdentityId)
{
mstrIdentityId = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation4Synch.IdentityId);
}
else if (strAttributeName  ==  convQxUserRoleRelation4Synch.IdentityDesc)
{
mstrIdentityDesc = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation4Synch.IdentityDesc);
}
else if (strAttributeName  ==  convQxUserRoleRelation4Synch.RoleId)
{
mstrRoleId = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation4Synch.RoleId);
}
else if (strAttributeName  ==  convQxUserRoleRelation4Synch.RoleName)
{
mstrRoleName = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation4Synch.RoleName);
}
else if (strAttributeName  ==  convQxUserRoleRelation4Synch.QxPrjId)
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation4Synch.QxPrjId);
}
else if (strAttributeName  ==  convQxUserRoleRelation4Synch.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation4Synch.PrjName);
}
else if (strAttributeName  ==  convQxUserRoleRelation4Synch.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation4Synch.UpdDate);
}
else if (strAttributeName  ==  convQxUserRoleRelation4Synch.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation4Synch.UpdUserId);
}
else if (strAttributeName  ==  convQxUserRoleRelation4Synch.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation4Synch.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convQxUserRoleRelation4Synch.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convQxUserRoleRelation4Synch.IpAddress  ==  AttributeName[intIndex])
{
return mstrIpAddress;
}
else if (convQxUserRoleRelation4Synch.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convQxUserRoleRelation4Synch.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convQxUserRoleRelation4Synch.DepartmentId  ==  AttributeName[intIndex])
{
return mstrDepartmentId;
}
else if (convQxUserRoleRelation4Synch.DepartmentName  ==  AttributeName[intIndex])
{
return mstrDepartmentName;
}
else if (convQxUserRoleRelation4Synch.UserStateId  ==  AttributeName[intIndex])
{
return mstrUserStateId;
}
else if (convQxUserRoleRelation4Synch.UserStateName  ==  AttributeName[intIndex])
{
return mstrUserStateName;
}
else if (convQxUserRoleRelation4Synch.StuTeacherId  ==  AttributeName[intIndex])
{
return mstrStuTeacherId;
}
else if (convQxUserRoleRelation4Synch.IdentityId  ==  AttributeName[intIndex])
{
return mstrIdentityId;
}
else if (convQxUserRoleRelation4Synch.IdentityDesc  ==  AttributeName[intIndex])
{
return mstrIdentityDesc;
}
else if (convQxUserRoleRelation4Synch.RoleId  ==  AttributeName[intIndex])
{
return mstrRoleId;
}
else if (convQxUserRoleRelation4Synch.RoleName  ==  AttributeName[intIndex])
{
return mstrRoleName;
}
else if (convQxUserRoleRelation4Synch.QxPrjId  ==  AttributeName[intIndex])
{
return mstrQxPrjId;
}
else if (convQxUserRoleRelation4Synch.PrjName  ==  AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convQxUserRoleRelation4Synch.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convQxUserRoleRelation4Synch.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convQxUserRoleRelation4Synch.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convQxUserRoleRelation4Synch.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxUserRoleRelation4Synch.mId);
}
else if (convQxUserRoleRelation4Synch.IpAddress  ==  AttributeName[intIndex])
{
mstrIpAddress = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation4Synch.IpAddress);
}
else if (convQxUserRoleRelation4Synch.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation4Synch.UserId);
}
else if (convQxUserRoleRelation4Synch.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation4Synch.UserName);
}
else if (convQxUserRoleRelation4Synch.DepartmentId  ==  AttributeName[intIndex])
{
mstrDepartmentId = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation4Synch.DepartmentId);
}
else if (convQxUserRoleRelation4Synch.DepartmentName  ==  AttributeName[intIndex])
{
mstrDepartmentName = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation4Synch.DepartmentName);
}
else if (convQxUserRoleRelation4Synch.UserStateId  ==  AttributeName[intIndex])
{
mstrUserStateId = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation4Synch.UserStateId);
}
else if (convQxUserRoleRelation4Synch.UserStateName  ==  AttributeName[intIndex])
{
mstrUserStateName = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation4Synch.UserStateName);
}
else if (convQxUserRoleRelation4Synch.StuTeacherId  ==  AttributeName[intIndex])
{
mstrStuTeacherId = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation4Synch.StuTeacherId);
}
else if (convQxUserRoleRelation4Synch.IdentityId  ==  AttributeName[intIndex])
{
mstrIdentityId = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation4Synch.IdentityId);
}
else if (convQxUserRoleRelation4Synch.IdentityDesc  ==  AttributeName[intIndex])
{
mstrIdentityDesc = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation4Synch.IdentityDesc);
}
else if (convQxUserRoleRelation4Synch.RoleId  ==  AttributeName[intIndex])
{
mstrRoleId = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation4Synch.RoleId);
}
else if (convQxUserRoleRelation4Synch.RoleName  ==  AttributeName[intIndex])
{
mstrRoleName = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation4Synch.RoleName);
}
else if (convQxUserRoleRelation4Synch.QxPrjId  ==  AttributeName[intIndex])
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation4Synch.QxPrjId);
}
else if (convQxUserRoleRelation4Synch.PrjName  ==  AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation4Synch.PrjName);
}
else if (convQxUserRoleRelation4Synch.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation4Synch.UpdDate);
}
else if (convQxUserRoleRelation4Synch.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation4Synch.UpdUserId);
}
else if (convQxUserRoleRelation4Synch.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation4Synch.Memo);
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
 AddUpdatedFld(convQxUserRoleRelation4Synch.mId);
}
}
/// <summary>
/// IP地址(说明:;字段类型:varchar;字段长度:23;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IpAddress
{
get
{
return mstrIpAddress;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIpAddress = value;
}
else
{
 mstrIpAddress = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUserRoleRelation4Synch.IpAddress);
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
 AddUpdatedFld(convQxUserRoleRelation4Synch.UserId);
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
 AddUpdatedFld(convQxUserRoleRelation4Synch.UserName);
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
 AddUpdatedFld(convQxUserRoleRelation4Synch.DepartmentId);
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
 AddUpdatedFld(convQxUserRoleRelation4Synch.DepartmentName);
}
}
/// <summary>
/// 用户状态Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserStateId
{
get
{
return mstrUserStateId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserStateId = value;
}
else
{
 mstrUserStateId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUserRoleRelation4Synch.UserStateId);
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
 AddUpdatedFld(convQxUserRoleRelation4Synch.UserStateName);
}
}
/// <summary>
/// 学工号(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StuTeacherId
{
get
{
return mstrStuTeacherId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStuTeacherId = value;
}
else
{
 mstrStuTeacherId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUserRoleRelation4Synch.StuTeacherId);
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
 AddUpdatedFld(convQxUserRoleRelation4Synch.IdentityId);
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
 AddUpdatedFld(convQxUserRoleRelation4Synch.IdentityDesc);
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
 AddUpdatedFld(convQxUserRoleRelation4Synch.RoleId);
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
 AddUpdatedFld(convQxUserRoleRelation4Synch.RoleName);
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
 AddUpdatedFld(convQxUserRoleRelation4Synch.QxPrjId);
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
 AddUpdatedFld(convQxUserRoleRelation4Synch.PrjName);
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
 AddUpdatedFld(convQxUserRoleRelation4Synch.UpdDate);
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
 AddUpdatedFld(convQxUserRoleRelation4Synch.UpdUserId);
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
 AddUpdatedFld(convQxUserRoleRelation4Synch.Memo);
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
 /// v用户角色关系4同步(vQxUserRoleRelation4Synch)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convQxUserRoleRelation4Synch
{
public const string _CurrTabName = "vQxUserRoleRelation4Synch"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "IpAddress", "UserId", "UserName", "DepartmentId", "DepartmentName", "UserStateId", "UserStateName", "StuTeacherId", "IdentityId", "IdentityDesc", "RoleId", "RoleName", "QxPrjId", "PrjName", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //流水号

 /// <summary>
 /// 常量:"IpAddress"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IpAddress = "IpAddress";    //IP地址

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
 /// 常量:"UserStateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserStateId = "UserStateId";    //用户状态Id

 /// <summary>
 /// 常量:"UserStateName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserStateName = "UserStateName";    //用户状态名

 /// <summary>
 /// 常量:"StuTeacherId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuTeacherId = "StuTeacherId";    //学工号

 /// <summary>
 /// 常量:"IdentityId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdentityId = "IdentityId";    //身份编号

 /// <summary>
 /// 常量:"IdentityDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdentityDesc = "IdentityDesc";    //身份描述

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