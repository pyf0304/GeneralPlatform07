
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUsersEN
 表名:QxUsers(00140015)
 生成代码版本:2019.07.12.1
 生成日期:2019/07/12 11:03:16
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:用户管理
 模块英文名:UserManage
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
 /// 表QxUsers的关键字(UserId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public struct K_UserId_QxUsers
{
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get; }
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
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
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
public const string _CurrTabName_S = "QxUsers"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "UserId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 20;
public static string[] AttributeName = new string[] {"UserId", "UserName", "DepartmentId", "UserStateId", "EffectiveDate", "Password", "id_College", "EffitiveBeginDate", "EffitiveEndDate", "StuTeacherId", "IdentityID", "IsArchive", "openid", "Email", "PhoneNumber", "IsSynch", "SynchDate", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量

protected string mstrUserId;    //用户ID
protected string mstrUserName;    //用户名
protected string mstrDepartmentId;    //部门Id
protected string mstrUserStateId;    //用户状态Id
protected string mstrEffectiveDate;    //有效日期
protected string mstrPassword;    //口令
protected string mstrid_College;    //学院流水号
protected string mstrEffitiveBeginDate;    //有效开始日期
protected string mstrEffitiveEndDate;    //有效结束日期
protected string mstrStuTeacherId;    //学工号
protected string mstrIdentityID;    //身份编号
protected bool mbolIsArchive;    //是否存档
protected string mstropenid;    //微信openid
protected string mstrEmail;    //邮箱
protected string mstrPhoneNumber;    //电话号码
protected bool mbolIsSynch;    //是否同步
protected string mstrSynchDate;    //同步日期
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改用户
protected string mstrMemo;    //备注


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
 /// 常量:"DepartmentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_DepartmentId = "DepartmentId";    //部门Id

 /// <summary>
 /// 常量:"UserStateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UserStateId = "UserStateId";    //用户状态Id

 /// <summary>
 /// 常量:"EffectiveDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_EffectiveDate = "EffectiveDate";    //有效日期

 /// <summary>
 /// 常量:"Password"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Password = "Password";    //口令

 /// <summary>
 /// 常量:"id_College"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_id_College = "id_College";    //学院流水号

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
 /// 常量:"StuTeacherId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_StuTeacherId = "StuTeacherId";    //学工号

 /// <summary>
 /// 常量:"IdentityID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IdentityID = "IdentityID";    //身份编号

 /// <summary>
 /// 常量:"IsArchive"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsArchive = "IsArchive";    //是否存档

 /// <summary>
 /// 常量:"openid"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_openid = "openid";    //微信openid

 /// <summary>
 /// 常量:"Email"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Email = "Email";    //邮箱

 /// <summary>
 /// 常量:"PhoneNumber"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PhoneNumber = "PhoneNumber";    //电话号码

 /// <summary>
 /// 常量:"IsSynch"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsSynch = "IsSynch";    //是否同步

 /// <summary>
 /// 常量:"SynchDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_SynchDate = "SynchDate";    //同步日期

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
 public clsQxUsersEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "QxUsers";
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
 _CurrTabName = "QxUsers";
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
if (strAttributeName  ==  con_UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  con_UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  con_DepartmentId)
{
return mstrDepartmentId;
}
else if (strAttributeName  ==  con_UserStateId)
{
return mstrUserStateId;
}
else if (strAttributeName  ==  con_EffectiveDate)
{
return mstrEffectiveDate;
}
else if (strAttributeName  ==  con_Password)
{
return mstrPassword;
}
else if (strAttributeName  ==  con_id_College)
{
return mstrid_College;
}
else if (strAttributeName  ==  con_EffitiveBeginDate)
{
return mstrEffitiveBeginDate;
}
else if (strAttributeName  ==  con_EffitiveEndDate)
{
return mstrEffitiveEndDate;
}
else if (strAttributeName  ==  con_StuTeacherId)
{
return mstrStuTeacherId;
}
else if (strAttributeName  ==  con_IdentityID)
{
return mstrIdentityID;
}
else if (strAttributeName  ==  con_IsArchive)
{
return mbolIsArchive;
}
else if (strAttributeName  ==  con_openid)
{
return mstropenid;
}
else if (strAttributeName  ==  con_Email)
{
return mstrEmail;
}
else if (strAttributeName  ==  con_PhoneNumber)
{
return mstrPhoneNumber;
}
else if (strAttributeName  ==  con_IsSynch)
{
return mbolIsSynch;
}
else if (strAttributeName  ==  con_SynchDate)
{
return mstrSynchDate;
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
if (strAttributeName  ==  con_UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(con_UserId);
}
else if (strAttributeName  ==  con_UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(con_UserName);
}
else if (strAttributeName  ==  con_DepartmentId)
{
mstrDepartmentId = value.ToString();
 AddUpdatedFld(con_DepartmentId);
}
else if (strAttributeName  ==  con_UserStateId)
{
mstrUserStateId = value.ToString();
 AddUpdatedFld(con_UserStateId);
}
else if (strAttributeName  ==  con_EffectiveDate)
{
mstrEffectiveDate = value.ToString();
 AddUpdatedFld(con_EffectiveDate);
}
else if (strAttributeName  ==  con_Password)
{
mstrPassword = value.ToString();
 AddUpdatedFld(con_Password);
}
else if (strAttributeName  ==  con_id_College)
{
mstrid_College = value.ToString();
 AddUpdatedFld(con_id_College);
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
else if (strAttributeName  ==  con_StuTeacherId)
{
mstrStuTeacherId = value.ToString();
 AddUpdatedFld(con_StuTeacherId);
}
else if (strAttributeName  ==  con_IdentityID)
{
mstrIdentityID = value.ToString();
 AddUpdatedFld(con_IdentityID);
}
else if (strAttributeName  ==  con_IsArchive)
{
mbolIsArchive = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsArchive);
}
else if (strAttributeName  ==  con_openid)
{
mstropenid = value.ToString();
 AddUpdatedFld(con_openid);
}
else if (strAttributeName  ==  con_Email)
{
mstrEmail = value.ToString();
 AddUpdatedFld(con_Email);
}
else if (strAttributeName  ==  con_PhoneNumber)
{
mstrPhoneNumber = value.ToString();
 AddUpdatedFld(con_PhoneNumber);
}
else if (strAttributeName  ==  con_IsSynch)
{
mbolIsSynch = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsSynch);
}
else if (strAttributeName  ==  con_SynchDate)
{
mstrSynchDate = value.ToString();
 AddUpdatedFld(con_SynchDate);
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
if (con_UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (con_UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (con_DepartmentId  ==  AttributeName[intIndex])
{
return mstrDepartmentId;
}
else if (con_UserStateId  ==  AttributeName[intIndex])
{
return mstrUserStateId;
}
else if (con_EffectiveDate  ==  AttributeName[intIndex])
{
return mstrEffectiveDate;
}
else if (con_Password  ==  AttributeName[intIndex])
{
return mstrPassword;
}
else if (con_id_College  ==  AttributeName[intIndex])
{
return mstrid_College;
}
else if (con_EffitiveBeginDate  ==  AttributeName[intIndex])
{
return mstrEffitiveBeginDate;
}
else if (con_EffitiveEndDate  ==  AttributeName[intIndex])
{
return mstrEffitiveEndDate;
}
else if (con_StuTeacherId  ==  AttributeName[intIndex])
{
return mstrStuTeacherId;
}
else if (con_IdentityID  ==  AttributeName[intIndex])
{
return mstrIdentityID;
}
else if (con_IsArchive  ==  AttributeName[intIndex])
{
return mbolIsArchive;
}
else if (con_openid  ==  AttributeName[intIndex])
{
return mstropenid;
}
else if (con_Email  ==  AttributeName[intIndex])
{
return mstrEmail;
}
else if (con_PhoneNumber  ==  AttributeName[intIndex])
{
return mstrPhoneNumber;
}
else if (con_IsSynch  ==  AttributeName[intIndex])
{
return mbolIsSynch;
}
else if (con_SynchDate  ==  AttributeName[intIndex])
{
return mstrSynchDate;
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
if (con_UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(con_UserId);
}
else if (con_UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(con_UserName);
}
else if (con_DepartmentId  ==  AttributeName[intIndex])
{
mstrDepartmentId = value.ToString();
 AddUpdatedFld(con_DepartmentId);
}
else if (con_UserStateId  ==  AttributeName[intIndex])
{
mstrUserStateId = value.ToString();
 AddUpdatedFld(con_UserStateId);
}
else if (con_EffectiveDate  ==  AttributeName[intIndex])
{
mstrEffectiveDate = value.ToString();
 AddUpdatedFld(con_EffectiveDate);
}
else if (con_Password  ==  AttributeName[intIndex])
{
mstrPassword = value.ToString();
 AddUpdatedFld(con_Password);
}
else if (con_id_College  ==  AttributeName[intIndex])
{
mstrid_College = value.ToString();
 AddUpdatedFld(con_id_College);
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
else if (con_StuTeacherId  ==  AttributeName[intIndex])
{
mstrStuTeacherId = value.ToString();
 AddUpdatedFld(con_StuTeacherId);
}
else if (con_IdentityID  ==  AttributeName[intIndex])
{
mstrIdentityID = value.ToString();
 AddUpdatedFld(con_IdentityID);
}
else if (con_IsArchive  ==  AttributeName[intIndex])
{
mbolIsArchive = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsArchive);
}
else if (con_openid  ==  AttributeName[intIndex])
{
mstropenid = value.ToString();
 AddUpdatedFld(con_openid);
}
else if (con_Email  ==  AttributeName[intIndex])
{
mstrEmail = value.ToString();
 AddUpdatedFld(con_Email);
}
else if (con_PhoneNumber  ==  AttributeName[intIndex])
{
mstrPhoneNumber = value.ToString();
 AddUpdatedFld(con_PhoneNumber);
}
else if (con_IsSynch  ==  AttributeName[intIndex])
{
mbolIsSynch = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsSynch);
}
else if (con_SynchDate  ==  AttributeName[intIndex])
{
mstrSynchDate = value.ToString();
 AddUpdatedFld(con_SynchDate);
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
 AddUpdatedFld(con_IsSynch);
}
}
/// <summary>
/// 同步日期(说明:;字段类型:varchar;字段长度:14;是否可空:True)
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
 AddUpdatedFld(con_SynchDate);
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
}