
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUsers4SynchEN
 表名:QxUsers4Synch(00140089)
 * 版本:2023.12.26.1(服务器:WIN-SRV103-116)
 日期:2023/12/28 19:01:02
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
 /// 表QxUsers4Synch的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_QxUsers4Synch
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
public K_mId_QxUsers4Synch(long lngmId)
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
 /// <returns>返回:[K_mId_QxUsers4Synch]类型的对象</returns>
public static implicit operator K_mId_QxUsers4Synch(long value)
{
return new K_mId_QxUsers4Synch(value);
}
}
 /// <summary>
 /// 用户4同步(QxUsers4Synch)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQxUsers4SynchEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "QxUsers4Synch"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 23;
public static string[] AttributeName = new string[] {"mId", "IpAddress", "UserId", "UserName", "UserStateId", "OpenId", "IdentityId", "StuTeacherId", "Password", "PhoneNumber", "DepartmentId", "IdXzCollege", "EffitiveBeginDate", "EffitiveEndDate", "Email", "IsArchive", "IsAccessSynch", "AccessSynchDate", "IsExistUserInCurr", "IsSamePwd", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //流水号
protected string mstrIpAddress;    //IP地址
protected string mstrUserId;    //用户ID
protected string mstrUserName;    //用户名
protected string mstrUserStateId;    //用户状态Id
protected string mstrOpenId;    //微信openid
protected string mstrIdentityId;    //身份编号
protected string mstrStuTeacherId;    //学工号
protected string mstrPassword;    //口令
protected string mstrPhoneNumber;    //电话号码
protected string mstrDepartmentId;    //部门Id
protected string mstrIdXzCollege;    //IdXzCollege
protected string mstrEffitiveBeginDate;    //有效开始日期
protected string mstrEffitiveEndDate;    //有效结束日期
protected string mstrEmail;    //邮箱
protected bool mbolIsArchive;    //是否存档
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
 public clsQxUsers4SynchEN()
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
public clsQxUsers4SynchEN(long lngmId)
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
if (strAttributeName  ==  conQxUsers4Synch.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conQxUsers4Synch.IpAddress)
{
return mstrIpAddress;
}
else if (strAttributeName  ==  conQxUsers4Synch.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conQxUsers4Synch.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  conQxUsers4Synch.UserStateId)
{
return mstrUserStateId;
}
else if (strAttributeName  ==  conQxUsers4Synch.OpenId)
{
return mstrOpenId;
}
else if (strAttributeName  ==  conQxUsers4Synch.IdentityId)
{
return mstrIdentityId;
}
else if (strAttributeName  ==  conQxUsers4Synch.StuTeacherId)
{
return mstrStuTeacherId;
}
else if (strAttributeName  ==  conQxUsers4Synch.Password)
{
return mstrPassword;
}
else if (strAttributeName  ==  conQxUsers4Synch.PhoneNumber)
{
return mstrPhoneNumber;
}
else if (strAttributeName  ==  conQxUsers4Synch.DepartmentId)
{
return mstrDepartmentId;
}
else if (strAttributeName  ==  conQxUsers4Synch.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  conQxUsers4Synch.EffitiveBeginDate)
{
return mstrEffitiveBeginDate;
}
else if (strAttributeName  ==  conQxUsers4Synch.EffitiveEndDate)
{
return mstrEffitiveEndDate;
}
else if (strAttributeName  ==  conQxUsers4Synch.Email)
{
return mstrEmail;
}
else if (strAttributeName  ==  conQxUsers4Synch.IsArchive)
{
return mbolIsArchive;
}
else if (strAttributeName  ==  conQxUsers4Synch.IsAccessSynch)
{
return mbolIsAccessSynch;
}
else if (strAttributeName  ==  conQxUsers4Synch.AccessSynchDate)
{
return mstrAccessSynchDate;
}
else if (strAttributeName  ==  conQxUsers4Synch.IsExistUserInCurr)
{
return mbolIsExistUserInCurr;
}
else if (strAttributeName  ==  conQxUsers4Synch.IsSamePwd)
{
return mbolIsSamePwd;
}
else if (strAttributeName  ==  conQxUsers4Synch.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conQxUsers4Synch.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conQxUsers4Synch.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conQxUsers4Synch.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxUsers4Synch.mId);
}
else if (strAttributeName  ==  conQxUsers4Synch.IpAddress)
{
mstrIpAddress = value.ToString();
 AddUpdatedFld(conQxUsers4Synch.IpAddress);
}
else if (strAttributeName  ==  conQxUsers4Synch.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conQxUsers4Synch.UserId);
}
else if (strAttributeName  ==  conQxUsers4Synch.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(conQxUsers4Synch.UserName);
}
else if (strAttributeName  ==  conQxUsers4Synch.UserStateId)
{
mstrUserStateId = value.ToString();
 AddUpdatedFld(conQxUsers4Synch.UserStateId);
}
else if (strAttributeName  ==  conQxUsers4Synch.OpenId)
{
mstrOpenId = value.ToString();
 AddUpdatedFld(conQxUsers4Synch.OpenId);
}
else if (strAttributeName  ==  conQxUsers4Synch.IdentityId)
{
mstrIdentityId = value.ToString();
 AddUpdatedFld(conQxUsers4Synch.IdentityId);
}
else if (strAttributeName  ==  conQxUsers4Synch.StuTeacherId)
{
mstrStuTeacherId = value.ToString();
 AddUpdatedFld(conQxUsers4Synch.StuTeacherId);
}
else if (strAttributeName  ==  conQxUsers4Synch.Password)
{
mstrPassword = value.ToString();
 AddUpdatedFld(conQxUsers4Synch.Password);
}
else if (strAttributeName  ==  conQxUsers4Synch.PhoneNumber)
{
mstrPhoneNumber = value.ToString();
 AddUpdatedFld(conQxUsers4Synch.PhoneNumber);
}
else if (strAttributeName  ==  conQxUsers4Synch.DepartmentId)
{
mstrDepartmentId = value.ToString();
 AddUpdatedFld(conQxUsers4Synch.DepartmentId);
}
else if (strAttributeName  ==  conQxUsers4Synch.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(conQxUsers4Synch.IdXzCollege);
}
else if (strAttributeName  ==  conQxUsers4Synch.EffitiveBeginDate)
{
mstrEffitiveBeginDate = value.ToString();
 AddUpdatedFld(conQxUsers4Synch.EffitiveBeginDate);
}
else if (strAttributeName  ==  conQxUsers4Synch.EffitiveEndDate)
{
mstrEffitiveEndDate = value.ToString();
 AddUpdatedFld(conQxUsers4Synch.EffitiveEndDate);
}
else if (strAttributeName  ==  conQxUsers4Synch.Email)
{
mstrEmail = value.ToString();
 AddUpdatedFld(conQxUsers4Synch.Email);
}
else if (strAttributeName  ==  conQxUsers4Synch.IsArchive)
{
mbolIsArchive = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxUsers4Synch.IsArchive);
}
else if (strAttributeName  ==  conQxUsers4Synch.IsAccessSynch)
{
mbolIsAccessSynch = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxUsers4Synch.IsAccessSynch);
}
else if (strAttributeName  ==  conQxUsers4Synch.AccessSynchDate)
{
mstrAccessSynchDate = value.ToString();
 AddUpdatedFld(conQxUsers4Synch.AccessSynchDate);
}
else if (strAttributeName  ==  conQxUsers4Synch.IsExistUserInCurr)
{
mbolIsExistUserInCurr = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxUsers4Synch.IsExistUserInCurr);
}
else if (strAttributeName  ==  conQxUsers4Synch.IsSamePwd)
{
mbolIsSamePwd = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxUsers4Synch.IsSamePwd);
}
else if (strAttributeName  ==  conQxUsers4Synch.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxUsers4Synch.UpdDate);
}
else if (strAttributeName  ==  conQxUsers4Synch.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conQxUsers4Synch.UpdUser);
}
else if (strAttributeName  ==  conQxUsers4Synch.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxUsers4Synch.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conQxUsers4Synch.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conQxUsers4Synch.IpAddress  ==  AttributeName[intIndex])
{
return mstrIpAddress;
}
else if (conQxUsers4Synch.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conQxUsers4Synch.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (conQxUsers4Synch.UserStateId  ==  AttributeName[intIndex])
{
return mstrUserStateId;
}
else if (conQxUsers4Synch.OpenId  ==  AttributeName[intIndex])
{
return mstrOpenId;
}
else if (conQxUsers4Synch.IdentityId  ==  AttributeName[intIndex])
{
return mstrIdentityId;
}
else if (conQxUsers4Synch.StuTeacherId  ==  AttributeName[intIndex])
{
return mstrStuTeacherId;
}
else if (conQxUsers4Synch.Password  ==  AttributeName[intIndex])
{
return mstrPassword;
}
else if (conQxUsers4Synch.PhoneNumber  ==  AttributeName[intIndex])
{
return mstrPhoneNumber;
}
else if (conQxUsers4Synch.DepartmentId  ==  AttributeName[intIndex])
{
return mstrDepartmentId;
}
else if (conQxUsers4Synch.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (conQxUsers4Synch.EffitiveBeginDate  ==  AttributeName[intIndex])
{
return mstrEffitiveBeginDate;
}
else if (conQxUsers4Synch.EffitiveEndDate  ==  AttributeName[intIndex])
{
return mstrEffitiveEndDate;
}
else if (conQxUsers4Synch.Email  ==  AttributeName[intIndex])
{
return mstrEmail;
}
else if (conQxUsers4Synch.IsArchive  ==  AttributeName[intIndex])
{
return mbolIsArchive;
}
else if (conQxUsers4Synch.IsAccessSynch  ==  AttributeName[intIndex])
{
return mbolIsAccessSynch;
}
else if (conQxUsers4Synch.AccessSynchDate  ==  AttributeName[intIndex])
{
return mstrAccessSynchDate;
}
else if (conQxUsers4Synch.IsExistUserInCurr  ==  AttributeName[intIndex])
{
return mbolIsExistUserInCurr;
}
else if (conQxUsers4Synch.IsSamePwd  ==  AttributeName[intIndex])
{
return mbolIsSamePwd;
}
else if (conQxUsers4Synch.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conQxUsers4Synch.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conQxUsers4Synch.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conQxUsers4Synch.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxUsers4Synch.mId);
}
else if (conQxUsers4Synch.IpAddress  ==  AttributeName[intIndex])
{
mstrIpAddress = value.ToString();
 AddUpdatedFld(conQxUsers4Synch.IpAddress);
}
else if (conQxUsers4Synch.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conQxUsers4Synch.UserId);
}
else if (conQxUsers4Synch.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(conQxUsers4Synch.UserName);
}
else if (conQxUsers4Synch.UserStateId  ==  AttributeName[intIndex])
{
mstrUserStateId = value.ToString();
 AddUpdatedFld(conQxUsers4Synch.UserStateId);
}
else if (conQxUsers4Synch.OpenId  ==  AttributeName[intIndex])
{
mstrOpenId = value.ToString();
 AddUpdatedFld(conQxUsers4Synch.OpenId);
}
else if (conQxUsers4Synch.IdentityId  ==  AttributeName[intIndex])
{
mstrIdentityId = value.ToString();
 AddUpdatedFld(conQxUsers4Synch.IdentityId);
}
else if (conQxUsers4Synch.StuTeacherId  ==  AttributeName[intIndex])
{
mstrStuTeacherId = value.ToString();
 AddUpdatedFld(conQxUsers4Synch.StuTeacherId);
}
else if (conQxUsers4Synch.Password  ==  AttributeName[intIndex])
{
mstrPassword = value.ToString();
 AddUpdatedFld(conQxUsers4Synch.Password);
}
else if (conQxUsers4Synch.PhoneNumber  ==  AttributeName[intIndex])
{
mstrPhoneNumber = value.ToString();
 AddUpdatedFld(conQxUsers4Synch.PhoneNumber);
}
else if (conQxUsers4Synch.DepartmentId  ==  AttributeName[intIndex])
{
mstrDepartmentId = value.ToString();
 AddUpdatedFld(conQxUsers4Synch.DepartmentId);
}
else if (conQxUsers4Synch.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(conQxUsers4Synch.IdXzCollege);
}
else if (conQxUsers4Synch.EffitiveBeginDate  ==  AttributeName[intIndex])
{
mstrEffitiveBeginDate = value.ToString();
 AddUpdatedFld(conQxUsers4Synch.EffitiveBeginDate);
}
else if (conQxUsers4Synch.EffitiveEndDate  ==  AttributeName[intIndex])
{
mstrEffitiveEndDate = value.ToString();
 AddUpdatedFld(conQxUsers4Synch.EffitiveEndDate);
}
else if (conQxUsers4Synch.Email  ==  AttributeName[intIndex])
{
mstrEmail = value.ToString();
 AddUpdatedFld(conQxUsers4Synch.Email);
}
else if (conQxUsers4Synch.IsArchive  ==  AttributeName[intIndex])
{
mbolIsArchive = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxUsers4Synch.IsArchive);
}
else if (conQxUsers4Synch.IsAccessSynch  ==  AttributeName[intIndex])
{
mbolIsAccessSynch = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxUsers4Synch.IsAccessSynch);
}
else if (conQxUsers4Synch.AccessSynchDate  ==  AttributeName[intIndex])
{
mstrAccessSynchDate = value.ToString();
 AddUpdatedFld(conQxUsers4Synch.AccessSynchDate);
}
else if (conQxUsers4Synch.IsExistUserInCurr  ==  AttributeName[intIndex])
{
mbolIsExistUserInCurr = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxUsers4Synch.IsExistUserInCurr);
}
else if (conQxUsers4Synch.IsSamePwd  ==  AttributeName[intIndex])
{
mbolIsSamePwd = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxUsers4Synch.IsSamePwd);
}
else if (conQxUsers4Synch.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxUsers4Synch.UpdDate);
}
else if (conQxUsers4Synch.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conQxUsers4Synch.UpdUser);
}
else if (conQxUsers4Synch.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxUsers4Synch.Memo);
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
 AddUpdatedFld(conQxUsers4Synch.mId);
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
 AddUpdatedFld(conQxUsers4Synch.IpAddress);
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
 AddUpdatedFld(conQxUsers4Synch.UserId);
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
 AddUpdatedFld(conQxUsers4Synch.UserName);
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
 AddUpdatedFld(conQxUsers4Synch.UserStateId);
}
}
/// <summary>
/// 微信openid(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OpenId
{
get
{
return mstrOpenId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOpenId = value;
}
else
{
 mstrOpenId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxUsers4Synch.OpenId);
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
 AddUpdatedFld(conQxUsers4Synch.IdentityId);
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
 AddUpdatedFld(conQxUsers4Synch.StuTeacherId);
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
 AddUpdatedFld(conQxUsers4Synch.Password);
}
}
/// <summary>
/// 电话号码(说明:;字段类型:varchar;字段长度:15;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PhoneNumber
{
get
{
return mstrPhoneNumber;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPhoneNumber = value;
}
else
{
 mstrPhoneNumber = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxUsers4Synch.PhoneNumber);
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
 AddUpdatedFld(conQxUsers4Synch.DepartmentId);
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
 AddUpdatedFld(conQxUsers4Synch.IdXzCollege);
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
 AddUpdatedFld(conQxUsers4Synch.EffitiveBeginDate);
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
 AddUpdatedFld(conQxUsers4Synch.EffitiveEndDate);
}
}
/// <summary>
/// 邮箱(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Email
{
get
{
return mstrEmail;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEmail = value;
}
else
{
 mstrEmail = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxUsers4Synch.Email);
}
}
/// <summary>
/// 是否存档(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsArchive
{
get
{
return mbolIsArchive;
}
set
{
 mbolIsArchive = value;
//记录修改过的字段
 AddUpdatedFld(conQxUsers4Synch.IsArchive);
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
 AddUpdatedFld(conQxUsers4Synch.IsAccessSynch);
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
 AddUpdatedFld(conQxUsers4Synch.AccessSynchDate);
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
 AddUpdatedFld(conQxUsers4Synch.IsExistUserInCurr);
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
 AddUpdatedFld(conQxUsers4Synch.IsSamePwd);
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
 AddUpdatedFld(conQxUsers4Synch.UpdDate);
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
 AddUpdatedFld(conQxUsers4Synch.UpdUser);
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
 AddUpdatedFld(conQxUsers4Synch.Memo);
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
 /// 用户4同步(QxUsers4Synch)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conQxUsers4Synch
{
public const string _CurrTabName = "QxUsers4Synch"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "IpAddress", "UserId", "UserName", "UserStateId", "OpenId", "IdentityId", "StuTeacherId", "Password", "PhoneNumber", "DepartmentId", "IdXzCollege", "EffitiveBeginDate", "EffitiveEndDate", "Email", "IsArchive", "IsAccessSynch", "AccessSynchDate", "IsExistUserInCurr", "IsSamePwd", "UpdDate", "UpdUser", "Memo"};
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
 /// 常量:"OpenId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OpenId = "OpenId";    //微信openid

 /// <summary>
 /// 常量:"IdentityId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdentityId = "IdentityId";    //身份编号

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
 /// 常量:"PhoneNumber"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PhoneNumber = "PhoneNumber";    //电话号码

 /// <summary>
 /// 常量:"DepartmentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DepartmentId = "DepartmentId";    //部门Id

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
 /// 常量:"Email"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Email = "Email";    //邮箱

 /// <summary>
 /// 常量:"IsArchive"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsArchive = "IsArchive";    //是否存档

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