
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUsersEN
 表名:QxUsers(00140015)
 * 版本:2024.09.30.1(服务器:WIN-SRV103-116)
 日期:2024/10/02 04:31:50
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(000010)(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433MSEduSys
 PrjDataBaseId:0199
 模块中文名:用户管理(UserManage_GP)
 框架-层名:实体层(CS)(EntityLayer,0001)
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
 /// 表QxUsers的关键字(UserId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_UserId_QxUsers
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strUserId">表关键字</param>
public K_UserId_QxUsers(string strUserId)
{
if (IsValid(strUserId)) Value = strUserId;
else
{
Value = null;
}
}
private static bool IsValid(string strUserId)
{
if (string.IsNullOrEmpty(strUserId) == true) return false;
if (strUserId.Length > 18) return false;
if (strUserId.IndexOf(' ') >= 0) return false;
if (strUserId.IndexOf(')') >= 0) return false;
if (strUserId.IndexOf('(') >= 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_UserId_QxUsers]类型的对象</returns>
public static implicit operator K_UserId_QxUsers(string value)
{
return new K_UserId_QxUsers(value);
}
}
 /// <summary>
 /// 用户(QxUsers)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQxUsersEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "QxUsers"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "UserId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 23;
public static string[] AttributeName = new string[] {"UserId", "UserName", "DepartmentId", "UserStateId", "Password", "EffitiveBeginDate", "EffitiveEndDate", "StuTeacherId", "IdentityId", "IsArchive", "OpenId", "Email", "PhoneNumber", "IsSynch", "SynchDate", "DetailInfoTab", "IdGradeBase", "IdSchool", "headPic", "IdXzCollege", "UpdDate", "UpdUser", "Memo"};

protected string mstrUserId;    //用户ID
protected string mstrUserName;    //用户名
protected string mstrDepartmentId;    //部门Id
protected string mstrUserStateId;    //用户状态Id
protected string mstrPassword;    //口令
protected string mstrEffitiveBeginDate;    //有效开始日期
protected string mstrEffitiveEndDate;    //有效结束日期
protected string mstrStuTeacherId;    //学工号
protected string mstrIdentityId;    //身份编号
protected bool mbolIsArchive;    //是否存档
protected string mstrOpenId;    //微信openid
protected string mstrEmail;    //邮箱
protected string mstrPhoneNumber;    //电话号码
protected bool mbolIsSynch;    //是否同步
protected string mstrSynchDate;    //同步日期
protected string mstrDetailInfoTab;    //详细信息表
protected string mstrIdGradeBase;    //年级流水号
protected string mstrIdSchool;    //学校流水号
protected string mstrheadPic;    //头像
protected string mstrIdXzCollege;    //学院Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改用户
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQxUsersEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("UserId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strUserId">关键字:用户ID</param>
public clsQxUsersEN(string strUserId)
 {
strUserId = strUserId.Replace("'", "''");
if (strUserId.Length > 18)
{
throw new Exception("在表:QxUsers中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strUserId)  ==  true)
{
throw new Exception("在表:QxUsers中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strUserId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrUserId = strUserId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("UserId");
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
if (strAttributeName  ==  conQxUsers.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conQxUsers.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  conQxUsers.DepartmentId)
{
return mstrDepartmentId;
}
else if (strAttributeName  ==  conQxUsers.UserStateId)
{
return mstrUserStateId;
}
else if (strAttributeName  ==  conQxUsers.Password)
{
return mstrPassword;
}
else if (strAttributeName  ==  conQxUsers.EffitiveBeginDate)
{
return mstrEffitiveBeginDate;
}
else if (strAttributeName  ==  conQxUsers.EffitiveEndDate)
{
return mstrEffitiveEndDate;
}
else if (strAttributeName  ==  conQxUsers.StuTeacherId)
{
return mstrStuTeacherId;
}
else if (strAttributeName  ==  conQxUsers.IdentityId)
{
return mstrIdentityId;
}
else if (strAttributeName  ==  conQxUsers.IsArchive)
{
return mbolIsArchive;
}
else if (strAttributeName  ==  conQxUsers.OpenId)
{
return mstrOpenId;
}
else if (strAttributeName  ==  conQxUsers.Email)
{
return mstrEmail;
}
else if (strAttributeName  ==  conQxUsers.PhoneNumber)
{
return mstrPhoneNumber;
}
else if (strAttributeName  ==  conQxUsers.IsSynch)
{
return mbolIsSynch;
}
else if (strAttributeName  ==  conQxUsers.SynchDate)
{
return mstrSynchDate;
}
else if (strAttributeName  ==  conQxUsers.DetailInfoTab)
{
return mstrDetailInfoTab;
}
else if (strAttributeName  ==  conQxUsers.IdGradeBase)
{
return mstrIdGradeBase;
}
else if (strAttributeName  ==  conQxUsers.IdSchool)
{
return mstrIdSchool;
}
else if (strAttributeName  ==  conQxUsers.headPic)
{
return mstrheadPic;
}
else if (strAttributeName  ==  conQxUsers.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  conQxUsers.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conQxUsers.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conQxUsers.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conQxUsers.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conQxUsers.UserId);
}
else if (strAttributeName  ==  conQxUsers.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(conQxUsers.UserName);
}
else if (strAttributeName  ==  conQxUsers.DepartmentId)
{
mstrDepartmentId = value.ToString();
 AddUpdatedFld(conQxUsers.DepartmentId);
}
else if (strAttributeName  ==  conQxUsers.UserStateId)
{
mstrUserStateId = value.ToString();
 AddUpdatedFld(conQxUsers.UserStateId);
}
else if (strAttributeName  ==  conQxUsers.Password)
{
mstrPassword = value.ToString();
 AddUpdatedFld(conQxUsers.Password);
}
else if (strAttributeName  ==  conQxUsers.EffitiveBeginDate)
{
mstrEffitiveBeginDate = value.ToString();
 AddUpdatedFld(conQxUsers.EffitiveBeginDate);
}
else if (strAttributeName  ==  conQxUsers.EffitiveEndDate)
{
mstrEffitiveEndDate = value.ToString();
 AddUpdatedFld(conQxUsers.EffitiveEndDate);
}
else if (strAttributeName  ==  conQxUsers.StuTeacherId)
{
mstrStuTeacherId = value.ToString();
 AddUpdatedFld(conQxUsers.StuTeacherId);
}
else if (strAttributeName  ==  conQxUsers.IdentityId)
{
mstrIdentityId = value.ToString();
 AddUpdatedFld(conQxUsers.IdentityId);
}
else if (strAttributeName  ==  conQxUsers.IsArchive)
{
mbolIsArchive = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxUsers.IsArchive);
}
else if (strAttributeName  ==  conQxUsers.OpenId)
{
mstrOpenId = value.ToString();
 AddUpdatedFld(conQxUsers.OpenId);
}
else if (strAttributeName  ==  conQxUsers.Email)
{
mstrEmail = value.ToString();
 AddUpdatedFld(conQxUsers.Email);
}
else if (strAttributeName  ==  conQxUsers.PhoneNumber)
{
mstrPhoneNumber = value.ToString();
 AddUpdatedFld(conQxUsers.PhoneNumber);
}
else if (strAttributeName  ==  conQxUsers.IsSynch)
{
mbolIsSynch = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxUsers.IsSynch);
}
else if (strAttributeName  ==  conQxUsers.SynchDate)
{
mstrSynchDate = value.ToString();
 AddUpdatedFld(conQxUsers.SynchDate);
}
else if (strAttributeName  ==  conQxUsers.DetailInfoTab)
{
mstrDetailInfoTab = value.ToString();
 AddUpdatedFld(conQxUsers.DetailInfoTab);
}
else if (strAttributeName  ==  conQxUsers.IdGradeBase)
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(conQxUsers.IdGradeBase);
}
else if (strAttributeName  ==  conQxUsers.IdSchool)
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(conQxUsers.IdSchool);
}
else if (strAttributeName  ==  conQxUsers.headPic)
{
mstrheadPic = value.ToString();
 AddUpdatedFld(conQxUsers.headPic);
}
else if (strAttributeName  ==  conQxUsers.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(conQxUsers.IdXzCollege);
}
else if (strAttributeName  ==  conQxUsers.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxUsers.UpdDate);
}
else if (strAttributeName  ==  conQxUsers.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conQxUsers.UpdUser);
}
else if (strAttributeName  ==  conQxUsers.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxUsers.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conQxUsers.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conQxUsers.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (conQxUsers.DepartmentId  ==  AttributeName[intIndex])
{
return mstrDepartmentId;
}
else if (conQxUsers.UserStateId  ==  AttributeName[intIndex])
{
return mstrUserStateId;
}
else if (conQxUsers.Password  ==  AttributeName[intIndex])
{
return mstrPassword;
}
else if (conQxUsers.EffitiveBeginDate  ==  AttributeName[intIndex])
{
return mstrEffitiveBeginDate;
}
else if (conQxUsers.EffitiveEndDate  ==  AttributeName[intIndex])
{
return mstrEffitiveEndDate;
}
else if (conQxUsers.StuTeacherId  ==  AttributeName[intIndex])
{
return mstrStuTeacherId;
}
else if (conQxUsers.IdentityId  ==  AttributeName[intIndex])
{
return mstrIdentityId;
}
else if (conQxUsers.IsArchive  ==  AttributeName[intIndex])
{
return mbolIsArchive;
}
else if (conQxUsers.OpenId  ==  AttributeName[intIndex])
{
return mstrOpenId;
}
else if (conQxUsers.Email  ==  AttributeName[intIndex])
{
return mstrEmail;
}
else if (conQxUsers.PhoneNumber  ==  AttributeName[intIndex])
{
return mstrPhoneNumber;
}
else if (conQxUsers.IsSynch  ==  AttributeName[intIndex])
{
return mbolIsSynch;
}
else if (conQxUsers.SynchDate  ==  AttributeName[intIndex])
{
return mstrSynchDate;
}
else if (conQxUsers.DetailInfoTab  ==  AttributeName[intIndex])
{
return mstrDetailInfoTab;
}
else if (conQxUsers.IdGradeBase  ==  AttributeName[intIndex])
{
return mstrIdGradeBase;
}
else if (conQxUsers.IdSchool  ==  AttributeName[intIndex])
{
return mstrIdSchool;
}
else if (conQxUsers.headPic  ==  AttributeName[intIndex])
{
return mstrheadPic;
}
else if (conQxUsers.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (conQxUsers.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conQxUsers.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conQxUsers.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conQxUsers.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conQxUsers.UserId);
}
else if (conQxUsers.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(conQxUsers.UserName);
}
else if (conQxUsers.DepartmentId  ==  AttributeName[intIndex])
{
mstrDepartmentId = value.ToString();
 AddUpdatedFld(conQxUsers.DepartmentId);
}
else if (conQxUsers.UserStateId  ==  AttributeName[intIndex])
{
mstrUserStateId = value.ToString();
 AddUpdatedFld(conQxUsers.UserStateId);
}
else if (conQxUsers.Password  ==  AttributeName[intIndex])
{
mstrPassword = value.ToString();
 AddUpdatedFld(conQxUsers.Password);
}
else if (conQxUsers.EffitiveBeginDate  ==  AttributeName[intIndex])
{
mstrEffitiveBeginDate = value.ToString();
 AddUpdatedFld(conQxUsers.EffitiveBeginDate);
}
else if (conQxUsers.EffitiveEndDate  ==  AttributeName[intIndex])
{
mstrEffitiveEndDate = value.ToString();
 AddUpdatedFld(conQxUsers.EffitiveEndDate);
}
else if (conQxUsers.StuTeacherId  ==  AttributeName[intIndex])
{
mstrStuTeacherId = value.ToString();
 AddUpdatedFld(conQxUsers.StuTeacherId);
}
else if (conQxUsers.IdentityId  ==  AttributeName[intIndex])
{
mstrIdentityId = value.ToString();
 AddUpdatedFld(conQxUsers.IdentityId);
}
else if (conQxUsers.IsArchive  ==  AttributeName[intIndex])
{
mbolIsArchive = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxUsers.IsArchive);
}
else if (conQxUsers.OpenId  ==  AttributeName[intIndex])
{
mstrOpenId = value.ToString();
 AddUpdatedFld(conQxUsers.OpenId);
}
else if (conQxUsers.Email  ==  AttributeName[intIndex])
{
mstrEmail = value.ToString();
 AddUpdatedFld(conQxUsers.Email);
}
else if (conQxUsers.PhoneNumber  ==  AttributeName[intIndex])
{
mstrPhoneNumber = value.ToString();
 AddUpdatedFld(conQxUsers.PhoneNumber);
}
else if (conQxUsers.IsSynch  ==  AttributeName[intIndex])
{
mbolIsSynch = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxUsers.IsSynch);
}
else if (conQxUsers.SynchDate  ==  AttributeName[intIndex])
{
mstrSynchDate = value.ToString();
 AddUpdatedFld(conQxUsers.SynchDate);
}
else if (conQxUsers.DetailInfoTab  ==  AttributeName[intIndex])
{
mstrDetailInfoTab = value.ToString();
 AddUpdatedFld(conQxUsers.DetailInfoTab);
}
else if (conQxUsers.IdGradeBase  ==  AttributeName[intIndex])
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(conQxUsers.IdGradeBase);
}
else if (conQxUsers.IdSchool  ==  AttributeName[intIndex])
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(conQxUsers.IdSchool);
}
else if (conQxUsers.headPic  ==  AttributeName[intIndex])
{
mstrheadPic = value.ToString();
 AddUpdatedFld(conQxUsers.headPic);
}
else if (conQxUsers.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(conQxUsers.IdXzCollege);
}
else if (conQxUsers.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxUsers.UpdDate);
}
else if (conQxUsers.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conQxUsers.UpdUser);
}
else if (conQxUsers.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxUsers.Memo);
}
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
 AddUpdatedFld(conQxUsers.UserId);
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
 AddUpdatedFld(conQxUsers.UserName);
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
 AddUpdatedFld(conQxUsers.DepartmentId);
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
 AddUpdatedFld(conQxUsers.UserStateId);
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
 AddUpdatedFld(conQxUsers.Password);
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
 AddUpdatedFld(conQxUsers.EffitiveBeginDate);
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
 AddUpdatedFld(conQxUsers.EffitiveEndDate);
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
 AddUpdatedFld(conQxUsers.StuTeacherId);
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
 AddUpdatedFld(conQxUsers.IdentityId);
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
 AddUpdatedFld(conQxUsers.IsArchive);
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
 AddUpdatedFld(conQxUsers.OpenId);
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
 AddUpdatedFld(conQxUsers.Email);
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
 AddUpdatedFld(conQxUsers.PhoneNumber);
}
}
/// <summary>
/// 是否同步(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsSynch
{
get
{
return mbolIsSynch;
}
set
{
 mbolIsSynch = value;
//记录修改过的字段
 AddUpdatedFld(conQxUsers.IsSynch);
}
}
/// <summary>
/// 同步日期(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SynchDate
{
get
{
return mstrSynchDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSynchDate = value;
}
else
{
 mstrSynchDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxUsers.SynchDate);
}
}
/// <summary>
/// 详细信息表(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DetailInfoTab
{
get
{
return mstrDetailInfoTab;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDetailInfoTab = value;
}
else
{
 mstrDetailInfoTab = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxUsers.DetailInfoTab);
}
}
/// <summary>
/// 年级流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdGradeBase
{
get
{
return mstrIdGradeBase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdGradeBase = value;
}
else
{
 mstrIdGradeBase = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxUsers.IdGradeBase);
}
}
/// <summary>
/// 学校流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdSchool
{
get
{
return mstrIdSchool;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdSchool = value;
}
else
{
 mstrIdSchool = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxUsers.IdSchool);
}
}
/// <summary>
/// 头像(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string headPic
{
get
{
return mstrheadPic;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrheadPic = value;
}
else
{
 mstrheadPic = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxUsers.headPic);
}
}
/// <summary>
/// 学院Id(说明:;字段类型:char;字段长度:4;是否可空:True)
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
 AddUpdatedFld(conQxUsers.IdXzCollege);
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
 AddUpdatedFld(conQxUsers.UpdDate);
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
 AddUpdatedFld(conQxUsers.UpdUser);
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
 AddUpdatedFld(conQxUsers.Memo);
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
  return mstrUserId;
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
  return mstrUserName;
 }
 }
}
 /// <summary>
 /// 用户(QxUsers)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conQxUsers
{
public const string _CurrTabName = "QxUsers"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "UserId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"UserId", "UserName", "DepartmentId", "UserStateId", "Password", "EffitiveBeginDate", "EffitiveEndDate", "StuTeacherId", "IdentityId", "IsArchive", "OpenId", "Email", "PhoneNumber", "IsSynch", "SynchDate", "DetailInfoTab", "IdGradeBase", "IdSchool", "headPic", "IdXzCollege", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


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
 /// 常量:"UserStateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserStateId = "UserStateId";    //用户状态Id

 /// <summary>
 /// 常量:"Password"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Password = "Password";    //口令

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
 /// 常量:"IsArchive"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsArchive = "IsArchive";    //是否存档

 /// <summary>
 /// 常量:"OpenId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OpenId = "OpenId";    //微信openid

 /// <summary>
 /// 常量:"Email"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Email = "Email";    //邮箱

 /// <summary>
 /// 常量:"PhoneNumber"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PhoneNumber = "PhoneNumber";    //电话号码

 /// <summary>
 /// 常量:"IsSynch"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSynch = "IsSynch";    //是否同步

 /// <summary>
 /// 常量:"SynchDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SynchDate = "SynchDate";    //同步日期

 /// <summary>
 /// 常量:"DetailInfoTab"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DetailInfoTab = "DetailInfoTab";    //详细信息表

 /// <summary>
 /// 常量:"IdGradeBase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdGradeBase = "IdGradeBase";    //年级流水号

 /// <summary>
 /// 常量:"IdSchool"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSchool = "IdSchool";    //学校流水号

 /// <summary>
 /// 常量:"headPic"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string headPic = "headPic";    //头像

 /// <summary>
 /// 常量:"IdXzCollege"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzCollege = "IdXzCollege";    //学院Id

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