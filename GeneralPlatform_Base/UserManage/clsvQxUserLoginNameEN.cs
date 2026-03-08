
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUserLoginNameEN
 表名:vQxUserLoginName(00140077)
 生成代码版本:2019.07.11.1
 生成日期:2019/07/12 09:57:49
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
 /// 表vQxUserLoginName的关键字(UserLoginName)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public struct K_UserLoginName_vQxUserLoginName
{
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get; }
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
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
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
public const string _CurrTabName_S = "vQxUserLoginName"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "UserLoginName"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 15;
public static string[] AttributeName = new string[] {"UserLoginName", "UserId", "UserName", "DepartmentId", "DepartmentName", "DepartmentAbbrName", "UserStateId", "UserStateName", "Password", "EffitiveBeginDate", "EffitiveEndDate", "StuTeacherId", "IdentityID", "IdentityDesc", "Memo"};
//以下是属性变量

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
protected string mstrIdentityID;    //身份编号
protected string mstrIdentityDesc;    //身份描述
protected string mstrMemo;    //备注


 /// <summary>
 /// 常量:"UserLoginName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UserLoginName = "UserLoginName";    //用户登录名

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
 /// 常量:"DepartmentName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_DepartmentName = "DepartmentName";    //部门名

 /// <summary>
 /// 常量:"DepartmentAbbrName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_DepartmentAbbrName = "DepartmentAbbrName";    //名称缩写

 /// <summary>
 /// 常量:"UserStateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UserStateId = "UserStateId";    //用户状态Id

 /// <summary>
 /// 常量:"UserStateName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UserStateName = "UserStateName";    //用户状态名

 /// <summary>
 /// 常量:"Password"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Password = "Password";    //口令

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
 /// 常量:"IdentityDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IdentityDesc = "IdentityDesc";    //身份描述

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo = "Memo";    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvQxUserLoginNameEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "vQxUserLoginName";
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
 _CurrTabName = "vQxUserLoginName";
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
if (strAttributeName  ==  con_UserLoginName)
{
return mstrUserLoginName;
}
else if (strAttributeName  ==  con_UserId)
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
else if (strAttributeName  ==  con_DepartmentName)
{
return mstrDepartmentName;
}
else if (strAttributeName  ==  con_DepartmentAbbrName)
{
return mstrDepartmentAbbrName;
}
else if (strAttributeName  ==  con_UserStateId)
{
return mstrUserStateId;
}
else if (strAttributeName  ==  con_UserStateName)
{
return mstrUserStateName;
}
else if (strAttributeName  ==  con_Password)
{
return mstrPassword;
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
else if (strAttributeName  ==  con_IdentityDesc)
{
return mstrIdentityDesc;
}
else if (strAttributeName  ==  con_Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  con_UserLoginName)
{
mstrUserLoginName = value.ToString();
 AddUpdatedFld(con_UserLoginName);
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
else if (strAttributeName  ==  con_DepartmentId)
{
mstrDepartmentId = value.ToString();
 AddUpdatedFld(con_DepartmentId);
}
else if (strAttributeName  ==  con_DepartmentName)
{
mstrDepartmentName = value.ToString();
 AddUpdatedFld(con_DepartmentName);
}
else if (strAttributeName  ==  con_DepartmentAbbrName)
{
mstrDepartmentAbbrName = value.ToString();
 AddUpdatedFld(con_DepartmentAbbrName);
}
else if (strAttributeName  ==  con_UserStateId)
{
mstrUserStateId = value.ToString();
 AddUpdatedFld(con_UserStateId);
}
else if (strAttributeName  ==  con_UserStateName)
{
mstrUserStateName = value.ToString();
 AddUpdatedFld(con_UserStateName);
}
else if (strAttributeName  ==  con_Password)
{
mstrPassword = value.ToString();
 AddUpdatedFld(con_Password);
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
else if (strAttributeName  ==  con_IdentityDesc)
{
mstrIdentityDesc = value.ToString();
 AddUpdatedFld(con_IdentityDesc);
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
if (con_UserLoginName  ==  AttributeName[intIndex])
{
return mstrUserLoginName;
}
else if (con_UserId  ==  AttributeName[intIndex])
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
else if (con_DepartmentName  ==  AttributeName[intIndex])
{
return mstrDepartmentName;
}
else if (con_DepartmentAbbrName  ==  AttributeName[intIndex])
{
return mstrDepartmentAbbrName;
}
else if (con_UserStateId  ==  AttributeName[intIndex])
{
return mstrUserStateId;
}
else if (con_UserStateName  ==  AttributeName[intIndex])
{
return mstrUserStateName;
}
else if (con_Password  ==  AttributeName[intIndex])
{
return mstrPassword;
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
else if (con_IdentityDesc  ==  AttributeName[intIndex])
{
return mstrIdentityDesc;
}
else if (con_Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (con_UserLoginName  ==  AttributeName[intIndex])
{
mstrUserLoginName = value.ToString();
 AddUpdatedFld(con_UserLoginName);
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
else if (con_DepartmentId  ==  AttributeName[intIndex])
{
mstrDepartmentId = value.ToString();
 AddUpdatedFld(con_DepartmentId);
}
else if (con_DepartmentName  ==  AttributeName[intIndex])
{
mstrDepartmentName = value.ToString();
 AddUpdatedFld(con_DepartmentName);
}
else if (con_DepartmentAbbrName  ==  AttributeName[intIndex])
{
mstrDepartmentAbbrName = value.ToString();
 AddUpdatedFld(con_DepartmentAbbrName);
}
else if (con_UserStateId  ==  AttributeName[intIndex])
{
mstrUserStateId = value.ToString();
 AddUpdatedFld(con_UserStateId);
}
else if (con_UserStateName  ==  AttributeName[intIndex])
{
mstrUserStateName = value.ToString();
 AddUpdatedFld(con_UserStateName);
}
else if (con_Password  ==  AttributeName[intIndex])
{
mstrPassword = value.ToString();
 AddUpdatedFld(con_Password);
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
else if (con_IdentityDesc  ==  AttributeName[intIndex])
{
mstrIdentityDesc = value.ToString();
 AddUpdatedFld(con_IdentityDesc);
}
else if (con_Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
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
 AddUpdatedFld(con_UserLoginName);
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
 AddUpdatedFld(con_DepartmentName);
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
 AddUpdatedFld(con_DepartmentAbbrName);
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
 AddUpdatedFld(con_UserStateName);
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
 AddUpdatedFld(con_IdentityDesc);
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
  return mstrUserLoginName;
 }
 }
}
}