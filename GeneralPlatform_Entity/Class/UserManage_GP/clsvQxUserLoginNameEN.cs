
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUserLoginNameEN
 表名:vQxUserLoginName(00140077)
 * 版本:2023.12.26.1(服务器:WIN-SRV103-116)
 日期:2023/12/28 18:51:35
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
 /// 表vQxUserLoginName的关键字(UserLoginName)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_UserLoginName_vQxUserLoginName
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strUserLoginName">表关键字</param>
public K_UserLoginName_vQxUserLoginName(string strUserLoginName)
{
if (IsValid(strUserLoginName)) Value = strUserLoginName;
else
{
Value = null;
}
}
private static bool IsValid(string strUserLoginName)
{
if (string.IsNullOrEmpty(strUserLoginName) == true) return false;
if (strUserLoginName.Length > 30) return false;
if (strUserLoginName.IndexOf(' ') >= 0) return false;
if (strUserLoginName.IndexOf(')') >= 0) return false;
if (strUserLoginName.IndexOf('(') >= 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_UserLoginName_vQxUserLoginName]类型的对象</returns>
public static implicit operator K_UserLoginName_vQxUserLoginName(string value)
{
return new K_UserLoginName_vQxUserLoginName(value);
}
}
 /// <summary>
 /// vUserLoginName(vQxUserLoginName)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvQxUserLoginNameEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vQxUserLoginName"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "UserLoginName"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 15;
public static string[] AttributeName = new string[] {"UserLoginName", "UserId", "UserName", "DepartmentId", "DepartmentName", "DepartmentAbbrName", "UserStateId", "UserStateName", "Password", "EffitiveBeginDate", "EffitiveEndDate", "StuTeacherId", "IdentityId", "IdentityDesc", "Memo"};

protected string mstrUserLoginName;    //用户登录名
protected string mstrUserId;    //用户ID
protected string mstrUserName;    //用户名
protected string mstrDepartmentId;    //部门Id
protected string mstrDepartmentName;    //部门名
protected string mstrDepartmentAbbrName;    //名称缩写
protected string mstrUserStateId;    //用户状态Id
protected string mstrUserStateName;    //用户状态名
protected string mstrPassword;    //口令
protected string mstrEffitiveBeginDate;    //有效开始日期
protected string mstrEffitiveEndDate;    //有效结束日期
protected string mstrStuTeacherId;    //学工号
protected string mstrIdentityId;    //身份编号
protected string mstrIdentityDesc;    //身份描述
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvQxUserLoginNameEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("UserLoginName");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strUserLoginName">关键字:用户登录名</param>
public clsvQxUserLoginNameEN(string strUserLoginName)
 {
strUserLoginName = strUserLoginName.Replace("'", "''");
if (strUserLoginName.Length > 30)
{
throw new Exception("在表:vQxUserLoginName中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strUserLoginName)  ==  true)
{
throw new Exception("在表:vQxUserLoginName中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strUserLoginName);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrUserLoginName = strUserLoginName;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("UserLoginName");
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
if (strAttributeName  ==  convQxUserLoginName.UserLoginName)
{
return mstrUserLoginName;
}
else if (strAttributeName  ==  convQxUserLoginName.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convQxUserLoginName.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convQxUserLoginName.DepartmentId)
{
return mstrDepartmentId;
}
else if (strAttributeName  ==  convQxUserLoginName.DepartmentName)
{
return mstrDepartmentName;
}
else if (strAttributeName  ==  convQxUserLoginName.DepartmentAbbrName)
{
return mstrDepartmentAbbrName;
}
else if (strAttributeName  ==  convQxUserLoginName.UserStateId)
{
return mstrUserStateId;
}
else if (strAttributeName  ==  convQxUserLoginName.UserStateName)
{
return mstrUserStateName;
}
else if (strAttributeName  ==  convQxUserLoginName.Password)
{
return mstrPassword;
}
else if (strAttributeName  ==  convQxUserLoginName.EffitiveBeginDate)
{
return mstrEffitiveBeginDate;
}
else if (strAttributeName  ==  convQxUserLoginName.EffitiveEndDate)
{
return mstrEffitiveEndDate;
}
else if (strAttributeName  ==  convQxUserLoginName.StuTeacherId)
{
return mstrStuTeacherId;
}
else if (strAttributeName  ==  convQxUserLoginName.IdentityId)
{
return mstrIdentityId;
}
else if (strAttributeName  ==  convQxUserLoginName.IdentityDesc)
{
return mstrIdentityDesc;
}
else if (strAttributeName  ==  convQxUserLoginName.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convQxUserLoginName.UserLoginName)
{
mstrUserLoginName = value.ToString();
 AddUpdatedFld(convQxUserLoginName.UserLoginName);
}
else if (strAttributeName  ==  convQxUserLoginName.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convQxUserLoginName.UserId);
}
else if (strAttributeName  ==  convQxUserLoginName.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convQxUserLoginName.UserName);
}
else if (strAttributeName  ==  convQxUserLoginName.DepartmentId)
{
mstrDepartmentId = value.ToString();
 AddUpdatedFld(convQxUserLoginName.DepartmentId);
}
else if (strAttributeName  ==  convQxUserLoginName.DepartmentName)
{
mstrDepartmentName = value.ToString();
 AddUpdatedFld(convQxUserLoginName.DepartmentName);
}
else if (strAttributeName  ==  convQxUserLoginName.DepartmentAbbrName)
{
mstrDepartmentAbbrName = value.ToString();
 AddUpdatedFld(convQxUserLoginName.DepartmentAbbrName);
}
else if (strAttributeName  ==  convQxUserLoginName.UserStateId)
{
mstrUserStateId = value.ToString();
 AddUpdatedFld(convQxUserLoginName.UserStateId);
}
else if (strAttributeName  ==  convQxUserLoginName.UserStateName)
{
mstrUserStateName = value.ToString();
 AddUpdatedFld(convQxUserLoginName.UserStateName);
}
else if (strAttributeName  ==  convQxUserLoginName.Password)
{
mstrPassword = value.ToString();
 AddUpdatedFld(convQxUserLoginName.Password);
}
else if (strAttributeName  ==  convQxUserLoginName.EffitiveBeginDate)
{
mstrEffitiveBeginDate = value.ToString();
 AddUpdatedFld(convQxUserLoginName.EffitiveBeginDate);
}
else if (strAttributeName  ==  convQxUserLoginName.EffitiveEndDate)
{
mstrEffitiveEndDate = value.ToString();
 AddUpdatedFld(convQxUserLoginName.EffitiveEndDate);
}
else if (strAttributeName  ==  convQxUserLoginName.StuTeacherId)
{
mstrStuTeacherId = value.ToString();
 AddUpdatedFld(convQxUserLoginName.StuTeacherId);
}
else if (strAttributeName  ==  convQxUserLoginName.IdentityId)
{
mstrIdentityId = value.ToString();
 AddUpdatedFld(convQxUserLoginName.IdentityId);
}
else if (strAttributeName  ==  convQxUserLoginName.IdentityDesc)
{
mstrIdentityDesc = value.ToString();
 AddUpdatedFld(convQxUserLoginName.IdentityDesc);
}
else if (strAttributeName  ==  convQxUserLoginName.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQxUserLoginName.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convQxUserLoginName.UserLoginName  ==  AttributeName[intIndex])
{
return mstrUserLoginName;
}
else if (convQxUserLoginName.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convQxUserLoginName.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convQxUserLoginName.DepartmentId  ==  AttributeName[intIndex])
{
return mstrDepartmentId;
}
else if (convQxUserLoginName.DepartmentName  ==  AttributeName[intIndex])
{
return mstrDepartmentName;
}
else if (convQxUserLoginName.DepartmentAbbrName  ==  AttributeName[intIndex])
{
return mstrDepartmentAbbrName;
}
else if (convQxUserLoginName.UserStateId  ==  AttributeName[intIndex])
{
return mstrUserStateId;
}
else if (convQxUserLoginName.UserStateName  ==  AttributeName[intIndex])
{
return mstrUserStateName;
}
else if (convQxUserLoginName.Password  ==  AttributeName[intIndex])
{
return mstrPassword;
}
else if (convQxUserLoginName.EffitiveBeginDate  ==  AttributeName[intIndex])
{
return mstrEffitiveBeginDate;
}
else if (convQxUserLoginName.EffitiveEndDate  ==  AttributeName[intIndex])
{
return mstrEffitiveEndDate;
}
else if (convQxUserLoginName.StuTeacherId  ==  AttributeName[intIndex])
{
return mstrStuTeacherId;
}
else if (convQxUserLoginName.IdentityId  ==  AttributeName[intIndex])
{
return mstrIdentityId;
}
else if (convQxUserLoginName.IdentityDesc  ==  AttributeName[intIndex])
{
return mstrIdentityDesc;
}
else if (convQxUserLoginName.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convQxUserLoginName.UserLoginName  ==  AttributeName[intIndex])
{
mstrUserLoginName = value.ToString();
 AddUpdatedFld(convQxUserLoginName.UserLoginName);
}
else if (convQxUserLoginName.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convQxUserLoginName.UserId);
}
else if (convQxUserLoginName.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convQxUserLoginName.UserName);
}
else if (convQxUserLoginName.DepartmentId  ==  AttributeName[intIndex])
{
mstrDepartmentId = value.ToString();
 AddUpdatedFld(convQxUserLoginName.DepartmentId);
}
else if (convQxUserLoginName.DepartmentName  ==  AttributeName[intIndex])
{
mstrDepartmentName = value.ToString();
 AddUpdatedFld(convQxUserLoginName.DepartmentName);
}
else if (convQxUserLoginName.DepartmentAbbrName  ==  AttributeName[intIndex])
{
mstrDepartmentAbbrName = value.ToString();
 AddUpdatedFld(convQxUserLoginName.DepartmentAbbrName);
}
else if (convQxUserLoginName.UserStateId  ==  AttributeName[intIndex])
{
mstrUserStateId = value.ToString();
 AddUpdatedFld(convQxUserLoginName.UserStateId);
}
else if (convQxUserLoginName.UserStateName  ==  AttributeName[intIndex])
{
mstrUserStateName = value.ToString();
 AddUpdatedFld(convQxUserLoginName.UserStateName);
}
else if (convQxUserLoginName.Password  ==  AttributeName[intIndex])
{
mstrPassword = value.ToString();
 AddUpdatedFld(convQxUserLoginName.Password);
}
else if (convQxUserLoginName.EffitiveBeginDate  ==  AttributeName[intIndex])
{
mstrEffitiveBeginDate = value.ToString();
 AddUpdatedFld(convQxUserLoginName.EffitiveBeginDate);
}
else if (convQxUserLoginName.EffitiveEndDate  ==  AttributeName[intIndex])
{
mstrEffitiveEndDate = value.ToString();
 AddUpdatedFld(convQxUserLoginName.EffitiveEndDate);
}
else if (convQxUserLoginName.StuTeacherId  ==  AttributeName[intIndex])
{
mstrStuTeacherId = value.ToString();
 AddUpdatedFld(convQxUserLoginName.StuTeacherId);
}
else if (convQxUserLoginName.IdentityId  ==  AttributeName[intIndex])
{
mstrIdentityId = value.ToString();
 AddUpdatedFld(convQxUserLoginName.IdentityId);
}
else if (convQxUserLoginName.IdentityDesc  ==  AttributeName[intIndex])
{
mstrIdentityDesc = value.ToString();
 AddUpdatedFld(convQxUserLoginName.IdentityDesc);
}
else if (convQxUserLoginName.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQxUserLoginName.Memo);
}
}
}

/// <summary>
/// 用户登录名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserLoginName
{
get
{
return mstrUserLoginName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserLoginName = value;
}
else
{
 mstrUserLoginName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUserLoginName.UserLoginName);
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
 AddUpdatedFld(convQxUserLoginName.UserId);
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
 AddUpdatedFld(convQxUserLoginName.UserName);
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
 AddUpdatedFld(convQxUserLoginName.DepartmentId);
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
 AddUpdatedFld(convQxUserLoginName.DepartmentName);
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
 AddUpdatedFld(convQxUserLoginName.DepartmentAbbrName);
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
 AddUpdatedFld(convQxUserLoginName.UserStateId);
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
 AddUpdatedFld(convQxUserLoginName.UserStateName);
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
 AddUpdatedFld(convQxUserLoginName.Password);
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
 AddUpdatedFld(convQxUserLoginName.EffitiveBeginDate);
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
 AddUpdatedFld(convQxUserLoginName.EffitiveEndDate);
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
 AddUpdatedFld(convQxUserLoginName.StuTeacherId);
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
 AddUpdatedFld(convQxUserLoginName.IdentityId);
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
 AddUpdatedFld(convQxUserLoginName.IdentityDesc);
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
 AddUpdatedFld(convQxUserLoginName.Memo);
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
  return mstrUserLoginName;
 }
 }
}
 /// <summary>
 /// vUserLoginName(vQxUserLoginName)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convQxUserLoginName
{
public const string _CurrTabName = "vQxUserLoginName"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "UserLoginName"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"UserLoginName", "UserId", "UserName", "DepartmentId", "DepartmentName", "DepartmentAbbrName", "UserStateId", "UserStateName", "Password", "EffitiveBeginDate", "EffitiveEndDate", "StuTeacherId", "IdentityId", "IdentityDesc", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"UserLoginName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserLoginName = "UserLoginName";    //用户登录名

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
 /// 常量:"DepartmentAbbrName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DepartmentAbbrName = "DepartmentAbbrName";    //名称缩写

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
 /// 常量:"IdentityDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdentityDesc = "IdentityDesc";    //身份描述

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}