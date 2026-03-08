
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUsers4SynchEN
 表名:vQxUsers4Synch(00140090)
 * 版本:2023.12.26.1(服务器:WIN-SRV103-116)
 日期:2023/12/28 19:00:58
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
 /// 表vQxUsers4Synch的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vQxUsers4Synch
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
public K_mId_vQxUsers4Synch(long lngmId)
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
 /// <returns>返回:[K_mId_vQxUsers4Synch]类型的对象</returns>
public static implicit operator K_mId_vQxUsers4Synch(long value)
{
return new K_mId_vQxUsers4Synch(value);
}
}
 /// <summary>
 /// v用户4同步(vQxUsers4Synch)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvQxUsers4SynchEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vQxUsers4Synch"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 27;
public static string[] AttributeName = new string[] {"mId", "IpAddress", "UserId", "UserName", "UserStateId", "UserStateName", "IdentityId", "IdentityDesc", "StuTeacherId", "Password", "DepartmentId", "DepartmentName", "DepartmentAbbrName", "DepartmentTypeId", "DepartmentTypeName", "UpDepartmentId", "UpDepartmentName", "IdXzCollege", "EffitiveBeginDate", "EffitiveEndDate", "IsAccessSynch", "AccessSynchDate", "IsExistUserInCurr", "IsSamePwd", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //流水号
protected string mstrIpAddress;    //IP地址
protected string mstrUserId;    //用户ID
protected string mstrUserName;    //用户名
protected string mstrUserStateId;    //用户状态Id
protected string mstrUserStateName;    //用户状态名
protected string mstrIdentityId;    //身份编号
protected string mstrIdentityDesc;    //身份描述
protected string mstrStuTeacherId;    //学工号
protected string mstrPassword;    //口令
protected string mstrDepartmentId;    //部门Id
protected string mstrDepartmentName;    //部门名
protected string mstrDepartmentAbbrName;    //名称缩写
protected string mstrDepartmentTypeId;    //部门类型ID
protected string mstrDepartmentTypeName;    //部门类型名
protected string mstrUpDepartmentId;    //所属部门号
protected string mstrUpDepartmentName;    //上级部门
protected string mstrIdXzCollege;    //IdXzCollege
protected string mstrEffitiveBeginDate;    //有效开始日期
protected string mstrEffitiveEndDate;    //有效结束日期
protected bool mbolIsAccessSynch;    //是否处理同步
protected string mstrAccessSynchDate;    //处理同步日期
protected bool mbolIsExistUserInCurr;    //当前是否存在用户
protected bool mbolIsSamePwd;    //是否相同密码
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改用户
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvQxUsers4SynchEN()
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
public clsvQxUsers4SynchEN(long lngmId)
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
if (strAttributeName  ==  convQxUsers4Synch.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convQxUsers4Synch.IpAddress)
{
return mstrIpAddress;
}
else if (strAttributeName  ==  convQxUsers4Synch.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convQxUsers4Synch.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convQxUsers4Synch.UserStateId)
{
return mstrUserStateId;
}
else if (strAttributeName  ==  convQxUsers4Synch.UserStateName)
{
return mstrUserStateName;
}
else if (strAttributeName  ==  convQxUsers4Synch.IdentityId)
{
return mstrIdentityId;
}
else if (strAttributeName  ==  convQxUsers4Synch.IdentityDesc)
{
return mstrIdentityDesc;
}
else if (strAttributeName  ==  convQxUsers4Synch.StuTeacherId)
{
return mstrStuTeacherId;
}
else if (strAttributeName  ==  convQxUsers4Synch.Password)
{
return mstrPassword;
}
else if (strAttributeName  ==  convQxUsers4Synch.DepartmentId)
{
return mstrDepartmentId;
}
else if (strAttributeName  ==  convQxUsers4Synch.DepartmentName)
{
return mstrDepartmentName;
}
else if (strAttributeName  ==  convQxUsers4Synch.DepartmentAbbrName)
{
return mstrDepartmentAbbrName;
}
else if (strAttributeName  ==  convQxUsers4Synch.DepartmentTypeId)
{
return mstrDepartmentTypeId;
}
else if (strAttributeName  ==  convQxUsers4Synch.DepartmentTypeName)
{
return mstrDepartmentTypeName;
}
else if (strAttributeName  ==  convQxUsers4Synch.UpDepartmentId)
{
return mstrUpDepartmentId;
}
else if (strAttributeName  ==  convQxUsers4Synch.UpDepartmentName)
{
return mstrUpDepartmentName;
}
else if (strAttributeName  ==  convQxUsers4Synch.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convQxUsers4Synch.EffitiveBeginDate)
{
return mstrEffitiveBeginDate;
}
else if (strAttributeName  ==  convQxUsers4Synch.EffitiveEndDate)
{
return mstrEffitiveEndDate;
}
else if (strAttributeName  ==  convQxUsers4Synch.IsAccessSynch)
{
return mbolIsAccessSynch;
}
else if (strAttributeName  ==  convQxUsers4Synch.AccessSynchDate)
{
return mstrAccessSynchDate;
}
else if (strAttributeName  ==  convQxUsers4Synch.IsExistUserInCurr)
{
return mbolIsExistUserInCurr;
}
else if (strAttributeName  ==  convQxUsers4Synch.IsSamePwd)
{
return mbolIsSamePwd;
}
else if (strAttributeName  ==  convQxUsers4Synch.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convQxUsers4Synch.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convQxUsers4Synch.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convQxUsers4Synch.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxUsers4Synch.mId);
}
else if (strAttributeName  ==  convQxUsers4Synch.IpAddress)
{
mstrIpAddress = value.ToString();
 AddUpdatedFld(convQxUsers4Synch.IpAddress);
}
else if (strAttributeName  ==  convQxUsers4Synch.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convQxUsers4Synch.UserId);
}
else if (strAttributeName  ==  convQxUsers4Synch.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convQxUsers4Synch.UserName);
}
else if (strAttributeName  ==  convQxUsers4Synch.UserStateId)
{
mstrUserStateId = value.ToString();
 AddUpdatedFld(convQxUsers4Synch.UserStateId);
}
else if (strAttributeName  ==  convQxUsers4Synch.UserStateName)
{
mstrUserStateName = value.ToString();
 AddUpdatedFld(convQxUsers4Synch.UserStateName);
}
else if (strAttributeName  ==  convQxUsers4Synch.IdentityId)
{
mstrIdentityId = value.ToString();
 AddUpdatedFld(convQxUsers4Synch.IdentityId);
}
else if (strAttributeName  ==  convQxUsers4Synch.IdentityDesc)
{
mstrIdentityDesc = value.ToString();
 AddUpdatedFld(convQxUsers4Synch.IdentityDesc);
}
else if (strAttributeName  ==  convQxUsers4Synch.StuTeacherId)
{
mstrStuTeacherId = value.ToString();
 AddUpdatedFld(convQxUsers4Synch.StuTeacherId);
}
else if (strAttributeName  ==  convQxUsers4Synch.Password)
{
mstrPassword = value.ToString();
 AddUpdatedFld(convQxUsers4Synch.Password);
}
else if (strAttributeName  ==  convQxUsers4Synch.DepartmentId)
{
mstrDepartmentId = value.ToString();
 AddUpdatedFld(convQxUsers4Synch.DepartmentId);
}
else if (strAttributeName  ==  convQxUsers4Synch.DepartmentName)
{
mstrDepartmentName = value.ToString();
 AddUpdatedFld(convQxUsers4Synch.DepartmentName);
}
else if (strAttributeName  ==  convQxUsers4Synch.DepartmentAbbrName)
{
mstrDepartmentAbbrName = value.ToString();
 AddUpdatedFld(convQxUsers4Synch.DepartmentAbbrName);
}
else if (strAttributeName  ==  convQxUsers4Synch.DepartmentTypeId)
{
mstrDepartmentTypeId = value.ToString();
 AddUpdatedFld(convQxUsers4Synch.DepartmentTypeId);
}
else if (strAttributeName  ==  convQxUsers4Synch.DepartmentTypeName)
{
mstrDepartmentTypeName = value.ToString();
 AddUpdatedFld(convQxUsers4Synch.DepartmentTypeName);
}
else if (strAttributeName  ==  convQxUsers4Synch.UpDepartmentId)
{
mstrUpDepartmentId = value.ToString();
 AddUpdatedFld(convQxUsers4Synch.UpDepartmentId);
}
else if (strAttributeName  ==  convQxUsers4Synch.UpDepartmentName)
{
mstrUpDepartmentName = value.ToString();
 AddUpdatedFld(convQxUsers4Synch.UpDepartmentName);
}
else if (strAttributeName  ==  convQxUsers4Synch.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convQxUsers4Synch.IdXzCollege);
}
else if (strAttributeName  ==  convQxUsers4Synch.EffitiveBeginDate)
{
mstrEffitiveBeginDate = value.ToString();
 AddUpdatedFld(convQxUsers4Synch.EffitiveBeginDate);
}
else if (strAttributeName  ==  convQxUsers4Synch.EffitiveEndDate)
{
mstrEffitiveEndDate = value.ToString();
 AddUpdatedFld(convQxUsers4Synch.EffitiveEndDate);
}
else if (strAttributeName  ==  convQxUsers4Synch.IsAccessSynch)
{
mbolIsAccessSynch = TransNullToBool(value.ToString());
 AddUpdatedFld(convQxUsers4Synch.IsAccessSynch);
}
else if (strAttributeName  ==  convQxUsers4Synch.AccessSynchDate)
{
mstrAccessSynchDate = value.ToString();
 AddUpdatedFld(convQxUsers4Synch.AccessSynchDate);
}
else if (strAttributeName  ==  convQxUsers4Synch.IsExistUserInCurr)
{
mbolIsExistUserInCurr = TransNullToBool(value.ToString());
 AddUpdatedFld(convQxUsers4Synch.IsExistUserInCurr);
}
else if (strAttributeName  ==  convQxUsers4Synch.IsSamePwd)
{
mbolIsSamePwd = TransNullToBool(value.ToString());
 AddUpdatedFld(convQxUsers4Synch.IsSamePwd);
}
else if (strAttributeName  ==  convQxUsers4Synch.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convQxUsers4Synch.UpdDate);
}
else if (strAttributeName  ==  convQxUsers4Synch.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convQxUsers4Synch.UpdUser);
}
else if (strAttributeName  ==  convQxUsers4Synch.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQxUsers4Synch.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convQxUsers4Synch.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convQxUsers4Synch.IpAddress  ==  AttributeName[intIndex])
{
return mstrIpAddress;
}
else if (convQxUsers4Synch.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convQxUsers4Synch.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convQxUsers4Synch.UserStateId  ==  AttributeName[intIndex])
{
return mstrUserStateId;
}
else if (convQxUsers4Synch.UserStateName  ==  AttributeName[intIndex])
{
return mstrUserStateName;
}
else if (convQxUsers4Synch.IdentityId  ==  AttributeName[intIndex])
{
return mstrIdentityId;
}
else if (convQxUsers4Synch.IdentityDesc  ==  AttributeName[intIndex])
{
return mstrIdentityDesc;
}
else if (convQxUsers4Synch.StuTeacherId  ==  AttributeName[intIndex])
{
return mstrStuTeacherId;
}
else if (convQxUsers4Synch.Password  ==  AttributeName[intIndex])
{
return mstrPassword;
}
else if (convQxUsers4Synch.DepartmentId  ==  AttributeName[intIndex])
{
return mstrDepartmentId;
}
else if (convQxUsers4Synch.DepartmentName  ==  AttributeName[intIndex])
{
return mstrDepartmentName;
}
else if (convQxUsers4Synch.DepartmentAbbrName  ==  AttributeName[intIndex])
{
return mstrDepartmentAbbrName;
}
else if (convQxUsers4Synch.DepartmentTypeId  ==  AttributeName[intIndex])
{
return mstrDepartmentTypeId;
}
else if (convQxUsers4Synch.DepartmentTypeName  ==  AttributeName[intIndex])
{
return mstrDepartmentTypeName;
}
else if (convQxUsers4Synch.UpDepartmentId  ==  AttributeName[intIndex])
{
return mstrUpDepartmentId;
}
else if (convQxUsers4Synch.UpDepartmentName  ==  AttributeName[intIndex])
{
return mstrUpDepartmentName;
}
else if (convQxUsers4Synch.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convQxUsers4Synch.EffitiveBeginDate  ==  AttributeName[intIndex])
{
return mstrEffitiveBeginDate;
}
else if (convQxUsers4Synch.EffitiveEndDate  ==  AttributeName[intIndex])
{
return mstrEffitiveEndDate;
}
else if (convQxUsers4Synch.IsAccessSynch  ==  AttributeName[intIndex])
{
return mbolIsAccessSynch;
}
else if (convQxUsers4Synch.AccessSynchDate  ==  AttributeName[intIndex])
{
return mstrAccessSynchDate;
}
else if (convQxUsers4Synch.IsExistUserInCurr  ==  AttributeName[intIndex])
{
return mbolIsExistUserInCurr;
}
else if (convQxUsers4Synch.IsSamePwd  ==  AttributeName[intIndex])
{
return mbolIsSamePwd;
}
else if (convQxUsers4Synch.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convQxUsers4Synch.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convQxUsers4Synch.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convQxUsers4Synch.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxUsers4Synch.mId);
}
else if (convQxUsers4Synch.IpAddress  ==  AttributeName[intIndex])
{
mstrIpAddress = value.ToString();
 AddUpdatedFld(convQxUsers4Synch.IpAddress);
}
else if (convQxUsers4Synch.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convQxUsers4Synch.UserId);
}
else if (convQxUsers4Synch.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convQxUsers4Synch.UserName);
}
else if (convQxUsers4Synch.UserStateId  ==  AttributeName[intIndex])
{
mstrUserStateId = value.ToString();
 AddUpdatedFld(convQxUsers4Synch.UserStateId);
}
else if (convQxUsers4Synch.UserStateName  ==  AttributeName[intIndex])
{
mstrUserStateName = value.ToString();
 AddUpdatedFld(convQxUsers4Synch.UserStateName);
}
else if (convQxUsers4Synch.IdentityId  ==  AttributeName[intIndex])
{
mstrIdentityId = value.ToString();
 AddUpdatedFld(convQxUsers4Synch.IdentityId);
}
else if (convQxUsers4Synch.IdentityDesc  ==  AttributeName[intIndex])
{
mstrIdentityDesc = value.ToString();
 AddUpdatedFld(convQxUsers4Synch.IdentityDesc);
}
else if (convQxUsers4Synch.StuTeacherId  ==  AttributeName[intIndex])
{
mstrStuTeacherId = value.ToString();
 AddUpdatedFld(convQxUsers4Synch.StuTeacherId);
}
else if (convQxUsers4Synch.Password  ==  AttributeName[intIndex])
{
mstrPassword = value.ToString();
 AddUpdatedFld(convQxUsers4Synch.Password);
}
else if (convQxUsers4Synch.DepartmentId  ==  AttributeName[intIndex])
{
mstrDepartmentId = value.ToString();
 AddUpdatedFld(convQxUsers4Synch.DepartmentId);
}
else if (convQxUsers4Synch.DepartmentName  ==  AttributeName[intIndex])
{
mstrDepartmentName = value.ToString();
 AddUpdatedFld(convQxUsers4Synch.DepartmentName);
}
else if (convQxUsers4Synch.DepartmentAbbrName  ==  AttributeName[intIndex])
{
mstrDepartmentAbbrName = value.ToString();
 AddUpdatedFld(convQxUsers4Synch.DepartmentAbbrName);
}
else if (convQxUsers4Synch.DepartmentTypeId  ==  AttributeName[intIndex])
{
mstrDepartmentTypeId = value.ToString();
 AddUpdatedFld(convQxUsers4Synch.DepartmentTypeId);
}
else if (convQxUsers4Synch.DepartmentTypeName  ==  AttributeName[intIndex])
{
mstrDepartmentTypeName = value.ToString();
 AddUpdatedFld(convQxUsers4Synch.DepartmentTypeName);
}
else if (convQxUsers4Synch.UpDepartmentId  ==  AttributeName[intIndex])
{
mstrUpDepartmentId = value.ToString();
 AddUpdatedFld(convQxUsers4Synch.UpDepartmentId);
}
else if (convQxUsers4Synch.UpDepartmentName  ==  AttributeName[intIndex])
{
mstrUpDepartmentName = value.ToString();
 AddUpdatedFld(convQxUsers4Synch.UpDepartmentName);
}
else if (convQxUsers4Synch.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convQxUsers4Synch.IdXzCollege);
}
else if (convQxUsers4Synch.EffitiveBeginDate  ==  AttributeName[intIndex])
{
mstrEffitiveBeginDate = value.ToString();
 AddUpdatedFld(convQxUsers4Synch.EffitiveBeginDate);
}
else if (convQxUsers4Synch.EffitiveEndDate  ==  AttributeName[intIndex])
{
mstrEffitiveEndDate = value.ToString();
 AddUpdatedFld(convQxUsers4Synch.EffitiveEndDate);
}
else if (convQxUsers4Synch.IsAccessSynch  ==  AttributeName[intIndex])
{
mbolIsAccessSynch = TransNullToBool(value.ToString());
 AddUpdatedFld(convQxUsers4Synch.IsAccessSynch);
}
else if (convQxUsers4Synch.AccessSynchDate  ==  AttributeName[intIndex])
{
mstrAccessSynchDate = value.ToString();
 AddUpdatedFld(convQxUsers4Synch.AccessSynchDate);
}
else if (convQxUsers4Synch.IsExistUserInCurr  ==  AttributeName[intIndex])
{
mbolIsExistUserInCurr = TransNullToBool(value.ToString());
 AddUpdatedFld(convQxUsers4Synch.IsExistUserInCurr);
}
else if (convQxUsers4Synch.IsSamePwd  ==  AttributeName[intIndex])
{
mbolIsSamePwd = TransNullToBool(value.ToString());
 AddUpdatedFld(convQxUsers4Synch.IsSamePwd);
}
else if (convQxUsers4Synch.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convQxUsers4Synch.UpdDate);
}
else if (convQxUsers4Synch.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convQxUsers4Synch.UpdUser);
}
else if (convQxUsers4Synch.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQxUsers4Synch.Memo);
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
 AddUpdatedFld(convQxUsers4Synch.mId);
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
 AddUpdatedFld(convQxUsers4Synch.IpAddress);
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
 AddUpdatedFld(convQxUsers4Synch.UserId);
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
 AddUpdatedFld(convQxUsers4Synch.UserName);
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
 AddUpdatedFld(convQxUsers4Synch.UserStateId);
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
 AddUpdatedFld(convQxUsers4Synch.UserStateName);
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
 AddUpdatedFld(convQxUsers4Synch.IdentityId);
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
 AddUpdatedFld(convQxUsers4Synch.IdentityDesc);
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
 AddUpdatedFld(convQxUsers4Synch.StuTeacherId);
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
 AddUpdatedFld(convQxUsers4Synch.Password);
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
 AddUpdatedFld(convQxUsers4Synch.DepartmentId);
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
 AddUpdatedFld(convQxUsers4Synch.DepartmentName);
}
}
/// <summary>
/// 名称缩写(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DepartmentAbbrName
{
get
{
return mstrDepartmentAbbrName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDepartmentAbbrName = value;
}
else
{
 mstrDepartmentAbbrName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUsers4Synch.DepartmentAbbrName);
}
}
/// <summary>
/// 部门类型ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DepartmentTypeId
{
get
{
return mstrDepartmentTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDepartmentTypeId = value;
}
else
{
 mstrDepartmentTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUsers4Synch.DepartmentTypeId);
}
}
/// <summary>
/// 部门类型名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DepartmentTypeName
{
get
{
return mstrDepartmentTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDepartmentTypeName = value;
}
else
{
 mstrDepartmentTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUsers4Synch.DepartmentTypeName);
}
}
/// <summary>
/// 所属部门号(说明:;字段类型:varchar;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpDepartmentId
{
get
{
return mstrUpDepartmentId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpDepartmentId = value;
}
else
{
 mstrUpDepartmentId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUsers4Synch.UpDepartmentId);
}
}
/// <summary>
/// 上级部门(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpDepartmentName
{
get
{
return mstrUpDepartmentName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpDepartmentName = value;
}
else
{
 mstrUpDepartmentName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUsers4Synch.UpDepartmentName);
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
 AddUpdatedFld(convQxUsers4Synch.IdXzCollege);
}
}
/// <summary>
/// 有效开始日期(说明:;字段类型:varchar;字段长度:14;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EffitiveBeginDate
{
get
{
return mstrEffitiveBeginDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEffitiveBeginDate = value;
}
else
{
 mstrEffitiveBeginDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUsers4Synch.EffitiveBeginDate);
}
}
/// <summary>
/// 有效结束日期(说明:;字段类型:varchar;字段长度:14;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EffitiveEndDate
{
get
{
return mstrEffitiveEndDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEffitiveEndDate = value;
}
else
{
 mstrEffitiveEndDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUsers4Synch.EffitiveEndDate);
}
}
/// <summary>
/// 是否处理同步(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsAccessSynch
{
get
{
return mbolIsAccessSynch;
}
set
{
 mbolIsAccessSynch = value;
//记录修改过的字段
 AddUpdatedFld(convQxUsers4Synch.IsAccessSynch);
}
}
/// <summary>
/// 处理同步日期(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AccessSynchDate
{
get
{
return mstrAccessSynchDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAccessSynchDate = value;
}
else
{
 mstrAccessSynchDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUsers4Synch.AccessSynchDate);
}
}
/// <summary>
/// 当前是否存在用户(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsExistUserInCurr
{
get
{
return mbolIsExistUserInCurr;
}
set
{
 mbolIsExistUserInCurr = value;
//记录修改过的字段
 AddUpdatedFld(convQxUsers4Synch.IsExistUserInCurr);
}
}
/// <summary>
/// 是否相同密码(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsSamePwd
{
get
{
return mbolIsSamePwd;
}
set
{
 mbolIsSamePwd = value;
//记录修改过的字段
 AddUpdatedFld(convQxUsers4Synch.IsSamePwd);
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
 AddUpdatedFld(convQxUsers4Synch.UpdDate);
}
}
/// <summary>
/// 修改用户(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUser
{
get
{
return mstrUpdUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUser = value;
}
else
{
 mstrUpdUser = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUsers4Synch.UpdUser);
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
 AddUpdatedFld(convQxUsers4Synch.Memo);
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
 /// v用户4同步(vQxUsers4Synch)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convQxUsers4Synch
{
public const string _CurrTabName = "vQxUsers4Synch"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "IpAddress", "UserId", "UserName", "UserStateId", "UserStateName", "IdentityId", "IdentityDesc", "StuTeacherId", "Password", "DepartmentId", "DepartmentName", "DepartmentAbbrName", "DepartmentTypeId", "DepartmentTypeName", "UpDepartmentId", "UpDepartmentName", "IdXzCollege", "EffitiveBeginDate", "EffitiveEndDate", "IsAccessSynch", "AccessSynchDate", "IsExistUserInCurr", "IsSamePwd", "UpdDate", "UpdUser", "Memo"};
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
 /// 常量:"StuTeacherId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuTeacherId = "StuTeacherId";    //学工号

 /// <summary>
 /// 常量:"Password"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Password = "Password";    //口令

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
 /// 常量:"DepartmentAbbrName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DepartmentAbbrName = "DepartmentAbbrName";    //名称缩写

 /// <summary>
 /// 常量:"DepartmentTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DepartmentTypeId = "DepartmentTypeId";    //部门类型ID

 /// <summary>
 /// 常量:"DepartmentTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DepartmentTypeName = "DepartmentTypeName";    //部门类型名

 /// <summary>
 /// 常量:"UpDepartmentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpDepartmentId = "UpDepartmentId";    //所属部门号

 /// <summary>
 /// 常量:"UpDepartmentName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpDepartmentName = "UpDepartmentName";    //上级部门

 /// <summary>
 /// 常量:"IdXzCollege"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzCollege = "IdXzCollege";    //IdXzCollege

 /// <summary>
 /// 常量:"EffitiveBeginDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EffitiveBeginDate = "EffitiveBeginDate";    //有效开始日期

 /// <summary>
 /// 常量:"EffitiveEndDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EffitiveEndDate = "EffitiveEndDate";    //有效结束日期

 /// <summary>
 /// 常量:"IsAccessSynch"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsAccessSynch = "IsAccessSynch";    //是否处理同步

 /// <summary>
 /// 常量:"AccessSynchDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AccessSynchDate = "AccessSynchDate";    //处理同步日期

 /// <summary>
 /// 常量:"IsExistUserInCurr"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsExistUserInCurr = "IsExistUserInCurr";    //当前是否存在用户

 /// <summary>
 /// 常量:"IsSamePwd"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSamePwd = "IsSamePwd";    //是否相同密码

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改用户

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}