
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUserRoleRelationEN
 表名:vQxUserRoleRelation(00140023)
 * 版本:2023.12.07.1(服务器:WIN-SRV103-116)
 日期:2023/12/20 22:54:51
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
 /// 表vQxUserRoleRelation的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vQxUserRoleRelation
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
public K_mId_vQxUserRoleRelation(long lngmId)
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
 /// <returns>返回:[K_mId_vQxUserRoleRelation]类型的对象</returns>
public static implicit operator K_mId_vQxUserRoleRelation(long value)
{
return new K_mId_vQxUserRoleRelation(value);
}
}
 /// <summary>
 /// v用户角色关系(vQxUserRoleRelation)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvQxUserRoleRelationEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vQxUserRoleRelation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 18;
public static string[] AttributeName = new string[] {"mId", "UserId", "UserName", "DepartmentId", "DepartmentName", "UserStateId", "UserStateName", "StuTeacherId", "IdentityId", "IdentityDesc", "RoleId", "RoleName", "QxPrjId", "PrjName", "Memo", "IdXzCollege", "CollegeName", "Password"};

protected long mlngmId;    //流水号
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
protected string mstrMemo;    //备注
protected string mstrIdXzCollege;    //IdXzCollege
protected string mstrCollegeName;    //CollegeName
protected string mstrPassword;    //口令

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvQxUserRoleRelationEN()
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
public clsvQxUserRoleRelationEN(long lngmId)
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
if (strAttributeName  ==  convQxUserRoleRelation.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convQxUserRoleRelation.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convQxUserRoleRelation.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convQxUserRoleRelation.DepartmentId)
{
return mstrDepartmentId;
}
else if (strAttributeName  ==  convQxUserRoleRelation.DepartmentName)
{
return mstrDepartmentName;
}
else if (strAttributeName  ==  convQxUserRoleRelation.UserStateId)
{
return mstrUserStateId;
}
else if (strAttributeName  ==  convQxUserRoleRelation.UserStateName)
{
return mstrUserStateName;
}
else if (strAttributeName  ==  convQxUserRoleRelation.StuTeacherId)
{
return mstrStuTeacherId;
}
else if (strAttributeName  ==  convQxUserRoleRelation.IdentityId)
{
return mstrIdentityId;
}
else if (strAttributeName  ==  convQxUserRoleRelation.IdentityDesc)
{
return mstrIdentityDesc;
}
else if (strAttributeName  ==  convQxUserRoleRelation.RoleId)
{
return mstrRoleId;
}
else if (strAttributeName  ==  convQxUserRoleRelation.RoleName)
{
return mstrRoleName;
}
else if (strAttributeName  ==  convQxUserRoleRelation.QxPrjId)
{
return mstrQxPrjId;
}
else if (strAttributeName  ==  convQxUserRoleRelation.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convQxUserRoleRelation.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convQxUserRoleRelation.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convQxUserRoleRelation.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convQxUserRoleRelation.Password)
{
return mstrPassword;
}
return null;
}
set
{
if (strAttributeName  ==  convQxUserRoleRelation.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxUserRoleRelation.mId);
}
else if (strAttributeName  ==  convQxUserRoleRelation.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation.UserId);
}
else if (strAttributeName  ==  convQxUserRoleRelation.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation.UserName);
}
else if (strAttributeName  ==  convQxUserRoleRelation.DepartmentId)
{
mstrDepartmentId = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation.DepartmentId);
}
else if (strAttributeName  ==  convQxUserRoleRelation.DepartmentName)
{
mstrDepartmentName = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation.DepartmentName);
}
else if (strAttributeName  ==  convQxUserRoleRelation.UserStateId)
{
mstrUserStateId = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation.UserStateId);
}
else if (strAttributeName  ==  convQxUserRoleRelation.UserStateName)
{
mstrUserStateName = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation.UserStateName);
}
else if (strAttributeName  ==  convQxUserRoleRelation.StuTeacherId)
{
mstrStuTeacherId = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation.StuTeacherId);
}
else if (strAttributeName  ==  convQxUserRoleRelation.IdentityId)
{
mstrIdentityId = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation.IdentityId);
}
else if (strAttributeName  ==  convQxUserRoleRelation.IdentityDesc)
{
mstrIdentityDesc = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation.IdentityDesc);
}
else if (strAttributeName  ==  convQxUserRoleRelation.RoleId)
{
mstrRoleId = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation.RoleId);
}
else if (strAttributeName  ==  convQxUserRoleRelation.RoleName)
{
mstrRoleName = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation.RoleName);
}
else if (strAttributeName  ==  convQxUserRoleRelation.QxPrjId)
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation.QxPrjId);
}
else if (strAttributeName  ==  convQxUserRoleRelation.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation.PrjName);
}
else if (strAttributeName  ==  convQxUserRoleRelation.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation.Memo);
}
else if (strAttributeName  ==  convQxUserRoleRelation.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation.IdXzCollege);
}
else if (strAttributeName  ==  convQxUserRoleRelation.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation.CollegeName);
}
else if (strAttributeName  ==  convQxUserRoleRelation.Password)
{
mstrPassword = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation.Password);
}
}
}
public object this[int intIndex]
{
get
{
if (convQxUserRoleRelation.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convQxUserRoleRelation.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convQxUserRoleRelation.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convQxUserRoleRelation.DepartmentId  ==  AttributeName[intIndex])
{
return mstrDepartmentId;
}
else if (convQxUserRoleRelation.DepartmentName  ==  AttributeName[intIndex])
{
return mstrDepartmentName;
}
else if (convQxUserRoleRelation.UserStateId  ==  AttributeName[intIndex])
{
return mstrUserStateId;
}
else if (convQxUserRoleRelation.UserStateName  ==  AttributeName[intIndex])
{
return mstrUserStateName;
}
else if (convQxUserRoleRelation.StuTeacherId  ==  AttributeName[intIndex])
{
return mstrStuTeacherId;
}
else if (convQxUserRoleRelation.IdentityId  ==  AttributeName[intIndex])
{
return mstrIdentityId;
}
else if (convQxUserRoleRelation.IdentityDesc  ==  AttributeName[intIndex])
{
return mstrIdentityDesc;
}
else if (convQxUserRoleRelation.RoleId  ==  AttributeName[intIndex])
{
return mstrRoleId;
}
else if (convQxUserRoleRelation.RoleName  ==  AttributeName[intIndex])
{
return mstrRoleName;
}
else if (convQxUserRoleRelation.QxPrjId  ==  AttributeName[intIndex])
{
return mstrQxPrjId;
}
else if (convQxUserRoleRelation.PrjName  ==  AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convQxUserRoleRelation.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convQxUserRoleRelation.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convQxUserRoleRelation.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convQxUserRoleRelation.Password  ==  AttributeName[intIndex])
{
return mstrPassword;
}
return null;
}
set
{
if (convQxUserRoleRelation.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxUserRoleRelation.mId);
}
else if (convQxUserRoleRelation.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation.UserId);
}
else if (convQxUserRoleRelation.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation.UserName);
}
else if (convQxUserRoleRelation.DepartmentId  ==  AttributeName[intIndex])
{
mstrDepartmentId = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation.DepartmentId);
}
else if (convQxUserRoleRelation.DepartmentName  ==  AttributeName[intIndex])
{
mstrDepartmentName = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation.DepartmentName);
}
else if (convQxUserRoleRelation.UserStateId  ==  AttributeName[intIndex])
{
mstrUserStateId = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation.UserStateId);
}
else if (convQxUserRoleRelation.UserStateName  ==  AttributeName[intIndex])
{
mstrUserStateName = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation.UserStateName);
}
else if (convQxUserRoleRelation.StuTeacherId  ==  AttributeName[intIndex])
{
mstrStuTeacherId = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation.StuTeacherId);
}
else if (convQxUserRoleRelation.IdentityId  ==  AttributeName[intIndex])
{
mstrIdentityId = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation.IdentityId);
}
else if (convQxUserRoleRelation.IdentityDesc  ==  AttributeName[intIndex])
{
mstrIdentityDesc = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation.IdentityDesc);
}
else if (convQxUserRoleRelation.RoleId  ==  AttributeName[intIndex])
{
mstrRoleId = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation.RoleId);
}
else if (convQxUserRoleRelation.RoleName  ==  AttributeName[intIndex])
{
mstrRoleName = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation.RoleName);
}
else if (convQxUserRoleRelation.QxPrjId  ==  AttributeName[intIndex])
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation.QxPrjId);
}
else if (convQxUserRoleRelation.PrjName  ==  AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation.PrjName);
}
else if (convQxUserRoleRelation.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation.Memo);
}
else if (convQxUserRoleRelation.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation.IdXzCollege);
}
else if (convQxUserRoleRelation.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation.CollegeName);
}
else if (convQxUserRoleRelation.Password  ==  AttributeName[intIndex])
{
mstrPassword = value.ToString();
 AddUpdatedFld(convQxUserRoleRelation.Password);
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
 AddUpdatedFld(convQxUserRoleRelation.mId);
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
 AddUpdatedFld(convQxUserRoleRelation.UserId);
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
 AddUpdatedFld(convQxUserRoleRelation.UserName);
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
 AddUpdatedFld(convQxUserRoleRelation.DepartmentId);
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
 AddUpdatedFld(convQxUserRoleRelation.DepartmentName);
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
 AddUpdatedFld(convQxUserRoleRelation.UserStateId);
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
 AddUpdatedFld(convQxUserRoleRelation.UserStateName);
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
 AddUpdatedFld(convQxUserRoleRelation.StuTeacherId);
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
 AddUpdatedFld(convQxUserRoleRelation.IdentityId);
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
 AddUpdatedFld(convQxUserRoleRelation.IdentityDesc);
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
 AddUpdatedFld(convQxUserRoleRelation.RoleId);
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
 AddUpdatedFld(convQxUserRoleRelation.RoleName);
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
 AddUpdatedFld(convQxUserRoleRelation.QxPrjId);
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
 AddUpdatedFld(convQxUserRoleRelation.PrjName);
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
 AddUpdatedFld(convQxUserRoleRelation.Memo);
}
}
/// <summary>
/// IdXzCollege(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdXzCollege
{
get
{
return mstrIdXzCollege;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdXzCollege = value;
}
else
{
 mstrIdXzCollege = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUserRoleRelation.IdXzCollege);
}
}
/// <summary>
/// CollegeName(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CollegeName
{
get
{
return mstrCollegeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCollegeName = value;
}
else
{
 mstrCollegeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUserRoleRelation.CollegeName);
}
}
/// <summary>
/// 口令(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Password
{
get
{
return mstrPassword;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPassword = value;
}
else
{
 mstrPassword = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUserRoleRelation.Password);
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
 /// v用户角色关系(vQxUserRoleRelation)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convQxUserRoleRelation
{
public const string _CurrTabName = "vQxUserRoleRelation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "UserId", "UserName", "DepartmentId", "DepartmentName", "UserStateId", "UserStateName", "StuTeacherId", "IdentityId", "IdentityDesc", "RoleId", "RoleName", "QxPrjId", "PrjName", "Memo", "IdXzCollege", "CollegeName", "Password"};
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
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"IdXzCollege"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzCollege = "IdXzCollege";    //IdXzCollege

 /// <summary>
 /// 常量:"CollegeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeName = "CollegeName";    //CollegeName

 /// <summary>
 /// 常量:"Password"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Password = "Password";    //口令
}

}