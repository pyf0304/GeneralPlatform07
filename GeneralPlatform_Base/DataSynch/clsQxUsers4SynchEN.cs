
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUsers4SynchEN
 表名:QxUsers4Synch(00140089)
 生成代码版本:2019.07.11.1
 生成日期:2019/07/12 09:59:11
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:数据同步
 模块英文名:DataSynch
 框架-层名:实体层(EntityLayer)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
using System;
using System.Text; 
using System.Collections; 
using com.taishsoft.commdb;
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
public struct K_mId_QxUsers4Synch
{
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get; }
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
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
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
public const string _CurrTabName_S = "QxUsers4Synch"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 24;
public static string[] AttributeName = new string[] {"mId", "IpAddress", "UserId", "UserName", "UserStateId", "openid", "IdentityID", "StuTeacherId", "Password", "PhoneNumber", "DepartmentId", "id_College", "EffectiveDate", "EffitiveBeginDate", "EffitiveEndDate", "Email", "IsArchive", "IsAccessSynch", "AccessSynchDate", "IsExistUserInCurr", "IsSamePwd", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量

protected long mlngmId;    //流水号
protected string mstrIpAddress;    //IP地址
protected string mstrUserId;    //用户ID
protected string mstrUserName;    //用户名
protected string mstrUserStateId;    //用户状态Id
protected string mstropenid;    //微信openid
protected string mstrIdentityID;    //身份编号
protected string mstrStuTeacherId;    //学工号
protected string mstrPassword;    //口令
protected string mstrPhoneNumber;    //电话号码
protected string mstrDepartmentId;    //部门Id
protected string mstrid_College;    //学院流水号
protected string mstrEffectiveDate;    //有效日期
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
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_mId = "mId";    //流水号

 /// <summary>
 /// 常量:"IpAddress"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IpAddress = "IpAddress";    //IP地址

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"UserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UserName = "UserName";    //用户名

 /// <summary>
 /// 常量:"UserStateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UserStateId = "UserStateId";    //用户状态Id

 /// <summary>
 /// 常量:"openid"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_openid = "openid";    //微信openid

 /// <summary>
 /// 常量:"IdentityID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IdentityID = "IdentityID";    //身份编号

 /// <summary>
 /// 常量:"StuTeacherId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_StuTeacherId = "StuTeacherId";    //学工号

 /// <summary>
 /// 常量:"Password"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Password = "Password";    //口令

 /// <summary>
 /// 常量:"PhoneNumber"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PhoneNumber = "PhoneNumber";    //电话号码

 /// <summary>
 /// 常量:"DepartmentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_DepartmentId = "DepartmentId";    //部门Id

 /// <summary>
 /// 常量:"id_College"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_id_College = "id_College";    //学院流水号

 /// <summary>
 /// 常量:"EffectiveDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_EffectiveDate = "EffectiveDate";    //有效日期

 /// <summary>
 /// 常量:"EffitiveBeginDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_EffitiveBeginDate = "EffitiveBeginDate";    //有效开始日期

 /// <summary>
 /// 常量:"EffitiveEndDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_EffitiveEndDate = "EffitiveEndDate";    //有效结束日期

 /// <summary>
 /// 常量:"Email"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Email = "Email";    //邮箱

 /// <summary>
 /// 常量:"IsArchive"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsArchive = "IsArchive";    //是否存档

 /// <summary>
 /// 常量:"IsAccessSynch"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsAccessSynch = "IsAccessSynch";    //是否处理同步

 /// <summary>
 /// 常量:"AccessSynchDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AccessSynchDate = "AccessSynchDate";    //处理同步日期

 /// <summary>
 /// 常量:"IsExistUserInCurr"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsExistUserInCurr = "IsExistUserInCurr";    //当前是否存在用户

 /// <summary>
 /// 常量:"IsSamePwd"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsSamePwd = "IsSamePwd";    //是否相同密码

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpdUser = "UpdUser";    //修改用户

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo = "Memo";    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQxUsers4SynchEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "QxUsers4Synch";
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
 _CurrTabName = "QxUsers4Synch";
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
if (strAttributeName  ==  con_mId)
{
return mlngmId;
}
else if (strAttributeName  ==  con_IpAddress)
{
return mstrIpAddress;
}
else if (strAttributeName  ==  con_UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  con_UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  con_UserStateId)
{
return mstrUserStateId;
}
else if (strAttributeName  ==  con_openid)
{
return mstropenid;
}
else if (strAttributeName  ==  con_IdentityID)
{
return mstrIdentityID;
}
else if (strAttributeName  ==  con_StuTeacherId)
{
return mstrStuTeacherId;
}
else if (strAttributeName  ==  con_Password)
{
return mstrPassword;
}
else if (strAttributeName  ==  con_PhoneNumber)
{
return mstrPhoneNumber;
}
else if (strAttributeName  ==  con_DepartmentId)
{
return mstrDepartmentId;
}
else if (strAttributeName  ==  con_id_College)
{
return mstrid_College;
}
else if (strAttributeName  ==  con_EffectiveDate)
{
return mstrEffectiveDate;
}
else if (strAttributeName  ==  con_EffitiveBeginDate)
{
return mstrEffitiveBeginDate;
}
else if (strAttributeName  ==  con_EffitiveEndDate)
{
return mstrEffitiveEndDate;
}
else if (strAttributeName  ==  con_Email)
{
return mstrEmail;
}
else if (strAttributeName  ==  con_IsArchive)
{
return mbolIsArchive;
}
else if (strAttributeName  ==  con_IsAccessSynch)
{
return mbolIsAccessSynch;
}
else if (strAttributeName  ==  con_AccessSynchDate)
{
return mstrAccessSynchDate;
}
else if (strAttributeName  ==  con_IsExistUserInCurr)
{
return mbolIsExistUserInCurr;
}
else if (strAttributeName  ==  con_IsSamePwd)
{
return mbolIsSamePwd;
}
else if (strAttributeName  ==  con_UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  con_UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  con_Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  con_mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(con_mId);
}
else if (strAttributeName  ==  con_IpAddress)
{
mstrIpAddress = value.ToString();
 AddUpdatedFld(con_IpAddress);
}
else if (strAttributeName  ==  con_UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(con_UserId);
}
else if (strAttributeName  ==  con_UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(con_UserName);
}
else if (strAttributeName  ==  con_UserStateId)
{
mstrUserStateId = value.ToString();
 AddUpdatedFld(con_UserStateId);
}
else if (strAttributeName  ==  con_openid)
{
mstropenid = value.ToString();
 AddUpdatedFld(con_openid);
}
else if (strAttributeName  ==  con_IdentityID)
{
mstrIdentityID = value.ToString();
 AddUpdatedFld(con_IdentityID);
}
else if (strAttributeName  ==  con_StuTeacherId)
{
mstrStuTeacherId = value.ToString();
 AddUpdatedFld(con_StuTeacherId);
}
else if (strAttributeName  ==  con_Password)
{
mstrPassword = value.ToString();
 AddUpdatedFld(con_Password);
}
else if (strAttributeName  ==  con_PhoneNumber)
{
mstrPhoneNumber = value.ToString();
 AddUpdatedFld(con_PhoneNumber);
}
else if (strAttributeName  ==  con_DepartmentId)
{
mstrDepartmentId = value.ToString();
 AddUpdatedFld(con_DepartmentId);
}
else if (strAttributeName  ==  con_id_College)
{
mstrid_College = value.ToString();
 AddUpdatedFld(con_id_College);
}
else if (strAttributeName  ==  con_EffectiveDate)
{
mstrEffectiveDate = value.ToString();
 AddUpdatedFld(con_EffectiveDate);
}
else if (strAttributeName  ==  con_EffitiveBeginDate)
{
mstrEffitiveBeginDate = value.ToString();
 AddUpdatedFld(con_EffitiveBeginDate);
}
else if (strAttributeName  ==  con_EffitiveEndDate)
{
mstrEffitiveEndDate = value.ToString();
 AddUpdatedFld(con_EffitiveEndDate);
}
else if (strAttributeName  ==  con_Email)
{
mstrEmail = value.ToString();
 AddUpdatedFld(con_Email);
}
else if (strAttributeName  ==  con_IsArchive)
{
mbolIsArchive = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsArchive);
}
else if (strAttributeName  ==  con_IsAccessSynch)
{
mbolIsAccessSynch = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsAccessSynch);
}
else if (strAttributeName  ==  con_AccessSynchDate)
{
mstrAccessSynchDate = value.ToString();
 AddUpdatedFld(con_AccessSynchDate);
}
else if (strAttributeName  ==  con_IsExistUserInCurr)
{
mbolIsExistUserInCurr = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsExistUserInCurr);
}
else if (strAttributeName  ==  con_IsSamePwd)
{
mbolIsSamePwd = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsSamePwd);
}
else if (strAttributeName  ==  con_UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(con_UpdDate);
}
else if (strAttributeName  ==  con_UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(con_UpdUser);
}
else if (strAttributeName  ==  con_Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (con_mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (con_IpAddress  ==  AttributeName[intIndex])
{
return mstrIpAddress;
}
else if (con_UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (con_UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (con_UserStateId  ==  AttributeName[intIndex])
{
return mstrUserStateId;
}
else if (con_openid  ==  AttributeName[intIndex])
{
return mstropenid;
}
else if (con_IdentityID  ==  AttributeName[intIndex])
{
return mstrIdentityID;
}
else if (con_StuTeacherId  ==  AttributeName[intIndex])
{
return mstrStuTeacherId;
}
else if (con_Password  ==  AttributeName[intIndex])
{
return mstrPassword;
}
else if (con_PhoneNumber  ==  AttributeName[intIndex])
{
return mstrPhoneNumber;
}
else if (con_DepartmentId  ==  AttributeName[intIndex])
{
return mstrDepartmentId;
}
else if (con_id_College  ==  AttributeName[intIndex])
{
return mstrid_College;
}
else if (con_EffectiveDate  ==  AttributeName[intIndex])
{
return mstrEffectiveDate;
}
else if (con_EffitiveBeginDate  ==  AttributeName[intIndex])
{
return mstrEffitiveBeginDate;
}
else if (con_EffitiveEndDate  ==  AttributeName[intIndex])
{
return mstrEffitiveEndDate;
}
else if (con_Email  ==  AttributeName[intIndex])
{
return mstrEmail;
}
else if (con_IsArchive  ==  AttributeName[intIndex])
{
return mbolIsArchive;
}
else if (con_IsAccessSynch  ==  AttributeName[intIndex])
{
return mbolIsAccessSynch;
}
else if (con_AccessSynchDate  ==  AttributeName[intIndex])
{
return mstrAccessSynchDate;
}
else if (con_IsExistUserInCurr  ==  AttributeName[intIndex])
{
return mbolIsExistUserInCurr;
}
else if (con_IsSamePwd  ==  AttributeName[intIndex])
{
return mbolIsSamePwd;
}
else if (con_UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (con_UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (con_Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (con_mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(con_mId);
}
else if (con_IpAddress  ==  AttributeName[intIndex])
{
mstrIpAddress = value.ToString();
 AddUpdatedFld(con_IpAddress);
}
else if (con_UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(con_UserId);
}
else if (con_UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(con_UserName);
}
else if (con_UserStateId  ==  AttributeName[intIndex])
{
mstrUserStateId = value.ToString();
 AddUpdatedFld(con_UserStateId);
}
else if (con_openid  ==  AttributeName[intIndex])
{
mstropenid = value.ToString();
 AddUpdatedFld(con_openid);
}
else if (con_IdentityID  ==  AttributeName[intIndex])
{
mstrIdentityID = value.ToString();
 AddUpdatedFld(con_IdentityID);
}
else if (con_StuTeacherId  ==  AttributeName[intIndex])
{
mstrStuTeacherId = value.ToString();
 AddUpdatedFld(con_StuTeacherId);
}
else if (con_Password  ==  AttributeName[intIndex])
{
mstrPassword = value.ToString();
 AddUpdatedFld(con_Password);
}
else if (con_PhoneNumber  ==  AttributeName[intIndex])
{
mstrPhoneNumber = value.ToString();
 AddUpdatedFld(con_PhoneNumber);
}
else if (con_DepartmentId  ==  AttributeName[intIndex])
{
mstrDepartmentId = value.ToString();
 AddUpdatedFld(con_DepartmentId);
}
else if (con_id_College  ==  AttributeName[intIndex])
{
mstrid_College = value.ToString();
 AddUpdatedFld(con_id_College);
}
else if (con_EffectiveDate  ==  AttributeName[intIndex])
{
mstrEffectiveDate = value.ToString();
 AddUpdatedFld(con_EffectiveDate);
}
else if (con_EffitiveBeginDate  ==  AttributeName[intIndex])
{
mstrEffitiveBeginDate = value.ToString();
 AddUpdatedFld(con_EffitiveBeginDate);
}
else if (con_EffitiveEndDate  ==  AttributeName[intIndex])
{
mstrEffitiveEndDate = value.ToString();
 AddUpdatedFld(con_EffitiveEndDate);
}
else if (con_Email  ==  AttributeName[intIndex])
{
mstrEmail = value.ToString();
 AddUpdatedFld(con_Email);
}
else if (con_IsArchive  ==  AttributeName[intIndex])
{
mbolIsArchive = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsArchive);
}
else if (con_IsAccessSynch  ==  AttributeName[intIndex])
{
mbolIsAccessSynch = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsAccessSynch);
}
else if (con_AccessSynchDate  ==  AttributeName[intIndex])
{
mstrAccessSynchDate = value.ToString();
 AddUpdatedFld(con_AccessSynchDate);
}
else if (con_IsExistUserInCurr  ==  AttributeName[intIndex])
{
mbolIsExistUserInCurr = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsExistUserInCurr);
}
else if (con_IsSamePwd  ==  AttributeName[intIndex])
{
mbolIsSamePwd = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsSamePwd);
}
else if (con_UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(con_UpdDate);
}
else if (con_UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(con_UpdUser);
}
else if (con_Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
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
 AddUpdatedFld(con_mId);
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
 AddUpdatedFld(con_IpAddress);
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
 AddUpdatedFld(con_UserId);
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
 AddUpdatedFld(con_UserName);
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
 AddUpdatedFld(con_UserStateId);
}
}
/// <summary>
/// 微信openid(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string openid
{
get
{
return mstropenid;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstropenid = value;
}
else
{
 mstropenid = value;
}
//记录修改过的字段
 AddUpdatedFld(con_openid);
}
}
/// <summary>
/// 身份编号(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdentityID
{
get
{
return mstrIdentityID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdentityID = value;
}
else
{
 mstrIdentityID = value;
}
//记录修改过的字段
 AddUpdatedFld(con_IdentityID);
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
 AddUpdatedFld(con_StuTeacherId);
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
 AddUpdatedFld(con_Password);
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
 AddUpdatedFld(con_PhoneNumber);
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
 AddUpdatedFld(con_DepartmentId);
}
}
/// <summary>
/// 学院流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string id_College
{
get
{
return mstrid_College;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrid_College = value;
}
else
{
 mstrid_College = value;
}
//记录修改过的字段
 AddUpdatedFld(con_id_College);
}
}
/// <summary>
/// 有效日期(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EffectiveDate
{
get
{
return mstrEffectiveDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEffectiveDate = value;
}
else
{
 mstrEffectiveDate = value;
}
//记录修改过的字段
 AddUpdatedFld(con_EffectiveDate);
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
 AddUpdatedFld(con_EffitiveBeginDate);
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
 AddUpdatedFld(con_EffitiveEndDate);
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
 AddUpdatedFld(con_Email);
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
 AddUpdatedFld(con_IsArchive);
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
 AddUpdatedFld(con_IsAccessSynch);
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
 AddUpdatedFld(con_AccessSynchDate);
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
 AddUpdatedFld(con_IsExistUserInCurr);
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
 AddUpdatedFld(con_IsSamePwd);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:14;是否可空:False)
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
 AddUpdatedFld(con_UpdDate);
}
}
/// <summary>
/// 修改用户(说明:;字段类型:varchar;字段长度:18;是否可空:True)
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
 AddUpdatedFld(con_UpdUser);
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
 AddUpdatedFld(con_Memo);
}
}

/// <summary>
/// 获取关键字Id(KeyId)
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
}