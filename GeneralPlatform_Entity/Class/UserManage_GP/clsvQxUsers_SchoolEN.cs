
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUsers_SchoolEN
 表名:vQxUsers_School(00140075)
 * 版本:2023.12.26.1(服务器:WIN-SRV103-116)
 日期:2023/12/28 19:00:47
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
 /// 表vQxUsers_School的关键字(UserId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_UserId_vQxUsers_School
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
public K_UserId_vQxUsers_School(string strUserId)
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
 /// <returns>返回:[K_UserId_vQxUsers_School]类型的对象</returns>
public static implicit operator K_UserId_vQxUsers_School(string value)
{
return new K_UserId_vQxUsers_School(value);
}
}
 /// <summary>
 /// vUsers_School(vQxUsers_School)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvQxUsers_SchoolEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vQxUsers_School"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "UserId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 26;
public static string[] AttributeName = new string[] {"UserId", "UserName", "DepartmentId", "DepartmentName", "DepartmentAbbrName", "DepartmentTypeId", "DepartmentTypeName", "UpDepartmentId", "UpDepartmentName", "UserStateId", "UserStateName", "IdentityId", "IdentityDesc", "CardNo", "StuTeacherId", "IdGradeBase", "GradeBaseName", "EnterSchoolDate", "IsOffed", "BeginYearMonth", "EndYearMonth", "CardState", "IsLeaved", "UpdDate", "UpdUser", "Memo"};

protected string mstrUserId;    //用户ID
protected string mstrUserName;    //用户名
protected string mstrDepartmentId;    //部门Id
protected string mstrDepartmentName;    //部门名
protected string mstrDepartmentAbbrName;    //名称缩写
protected string mstrDepartmentTypeId;    //部门类型ID
protected string mstrDepartmentTypeName;    //部门类型名
protected string mstrUpDepartmentId;    //所属部门号
protected string mstrUpDepartmentName;    //上级部门
protected string mstrUserStateId;    //用户状态Id
protected string mstrUserStateName;    //用户状态名
protected string mstrIdentityId;    //身份编号
protected string mstrIdentityDesc;    //身份描述
protected string mstrCardNo;    //卡号
protected string mstrStuTeacherId;    //学工号
protected string mstrIdGradeBase;    //年级流水号
protected string mstrGradeBaseName;    //年级名称
protected string mstrEnterSchoolDate;    //进校日期
protected bool mbolIsOffed;    //是否毕业
protected string mstrBeginYearMonth;    //开始年月
protected string mstrEndYearMonth;    //结束年月
protected string mstrCardState;    //卡状态
protected bool mbolIsLeaved;    //IsLeaved
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改用户
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvQxUsers_SchoolEN()
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
public clsvQxUsers_SchoolEN(string strUserId)
 {
strUserId = strUserId.Replace("'", "''");
if (strUserId.Length > 18)
{
throw new Exception("在表:vQxUsers_School中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strUserId)  ==  true)
{
throw new Exception("在表:vQxUsers_School中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convQxUsers_School.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convQxUsers_School.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convQxUsers_School.DepartmentId)
{
return mstrDepartmentId;
}
else if (strAttributeName  ==  convQxUsers_School.DepartmentName)
{
return mstrDepartmentName;
}
else if (strAttributeName  ==  convQxUsers_School.DepartmentAbbrName)
{
return mstrDepartmentAbbrName;
}
else if (strAttributeName  ==  convQxUsers_School.DepartmentTypeId)
{
return mstrDepartmentTypeId;
}
else if (strAttributeName  ==  convQxUsers_School.DepartmentTypeName)
{
return mstrDepartmentTypeName;
}
else if (strAttributeName  ==  convQxUsers_School.UpDepartmentId)
{
return mstrUpDepartmentId;
}
else if (strAttributeName  ==  convQxUsers_School.UpDepartmentName)
{
return mstrUpDepartmentName;
}
else if (strAttributeName  ==  convQxUsers_School.UserStateId)
{
return mstrUserStateId;
}
else if (strAttributeName  ==  convQxUsers_School.UserStateName)
{
return mstrUserStateName;
}
else if (strAttributeName  ==  convQxUsers_School.IdentityId)
{
return mstrIdentityId;
}
else if (strAttributeName  ==  convQxUsers_School.IdentityDesc)
{
return mstrIdentityDesc;
}
else if (strAttributeName  ==  convQxUsers_School.CardNo)
{
return mstrCardNo;
}
else if (strAttributeName  ==  convQxUsers_School.StuTeacherId)
{
return mstrStuTeacherId;
}
else if (strAttributeName  ==  convQxUsers_School.IdGradeBase)
{
return mstrIdGradeBase;
}
else if (strAttributeName  ==  convQxUsers_School.GradeBaseName)
{
return mstrGradeBaseName;
}
else if (strAttributeName  ==  convQxUsers_School.EnterSchoolDate)
{
return mstrEnterSchoolDate;
}
else if (strAttributeName  ==  convQxUsers_School.IsOffed)
{
return mbolIsOffed;
}
else if (strAttributeName  ==  convQxUsers_School.BeginYearMonth)
{
return mstrBeginYearMonth;
}
else if (strAttributeName  ==  convQxUsers_School.EndYearMonth)
{
return mstrEndYearMonth;
}
else if (strAttributeName  ==  convQxUsers_School.CardState)
{
return mstrCardState;
}
else if (strAttributeName  ==  convQxUsers_School.IsLeaved)
{
return mbolIsLeaved;
}
else if (strAttributeName  ==  convQxUsers_School.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convQxUsers_School.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convQxUsers_School.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convQxUsers_School.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convQxUsers_School.UserId);
}
else if (strAttributeName  ==  convQxUsers_School.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convQxUsers_School.UserName);
}
else if (strAttributeName  ==  convQxUsers_School.DepartmentId)
{
mstrDepartmentId = value.ToString();
 AddUpdatedFld(convQxUsers_School.DepartmentId);
}
else if (strAttributeName  ==  convQxUsers_School.DepartmentName)
{
mstrDepartmentName = value.ToString();
 AddUpdatedFld(convQxUsers_School.DepartmentName);
}
else if (strAttributeName  ==  convQxUsers_School.DepartmentAbbrName)
{
mstrDepartmentAbbrName = value.ToString();
 AddUpdatedFld(convQxUsers_School.DepartmentAbbrName);
}
else if (strAttributeName  ==  convQxUsers_School.DepartmentTypeId)
{
mstrDepartmentTypeId = value.ToString();
 AddUpdatedFld(convQxUsers_School.DepartmentTypeId);
}
else if (strAttributeName  ==  convQxUsers_School.DepartmentTypeName)
{
mstrDepartmentTypeName = value.ToString();
 AddUpdatedFld(convQxUsers_School.DepartmentTypeName);
}
else if (strAttributeName  ==  convQxUsers_School.UpDepartmentId)
{
mstrUpDepartmentId = value.ToString();
 AddUpdatedFld(convQxUsers_School.UpDepartmentId);
}
else if (strAttributeName  ==  convQxUsers_School.UpDepartmentName)
{
mstrUpDepartmentName = value.ToString();
 AddUpdatedFld(convQxUsers_School.UpDepartmentName);
}
else if (strAttributeName  ==  convQxUsers_School.UserStateId)
{
mstrUserStateId = value.ToString();
 AddUpdatedFld(convQxUsers_School.UserStateId);
}
else if (strAttributeName  ==  convQxUsers_School.UserStateName)
{
mstrUserStateName = value.ToString();
 AddUpdatedFld(convQxUsers_School.UserStateName);
}
else if (strAttributeName  ==  convQxUsers_School.IdentityId)
{
mstrIdentityId = value.ToString();
 AddUpdatedFld(convQxUsers_School.IdentityId);
}
else if (strAttributeName  ==  convQxUsers_School.IdentityDesc)
{
mstrIdentityDesc = value.ToString();
 AddUpdatedFld(convQxUsers_School.IdentityDesc);
}
else if (strAttributeName  ==  convQxUsers_School.CardNo)
{
mstrCardNo = value.ToString();
 AddUpdatedFld(convQxUsers_School.CardNo);
}
else if (strAttributeName  ==  convQxUsers_School.StuTeacherId)
{
mstrStuTeacherId = value.ToString();
 AddUpdatedFld(convQxUsers_School.StuTeacherId);
}
else if (strAttributeName  ==  convQxUsers_School.IdGradeBase)
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(convQxUsers_School.IdGradeBase);
}
else if (strAttributeName  ==  convQxUsers_School.GradeBaseName)
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(convQxUsers_School.GradeBaseName);
}
else if (strAttributeName  ==  convQxUsers_School.EnterSchoolDate)
{
mstrEnterSchoolDate = value.ToString();
 AddUpdatedFld(convQxUsers_School.EnterSchoolDate);
}
else if (strAttributeName  ==  convQxUsers_School.IsOffed)
{
mbolIsOffed = TransNullToBool(value.ToString());
 AddUpdatedFld(convQxUsers_School.IsOffed);
}
else if (strAttributeName  ==  convQxUsers_School.BeginYearMonth)
{
mstrBeginYearMonth = value.ToString();
 AddUpdatedFld(convQxUsers_School.BeginYearMonth);
}
else if (strAttributeName  ==  convQxUsers_School.EndYearMonth)
{
mstrEndYearMonth = value.ToString();
 AddUpdatedFld(convQxUsers_School.EndYearMonth);
}
else if (strAttributeName  ==  convQxUsers_School.CardState)
{
mstrCardState = value.ToString();
 AddUpdatedFld(convQxUsers_School.CardState);
}
else if (strAttributeName  ==  convQxUsers_School.IsLeaved)
{
mbolIsLeaved = TransNullToBool(value.ToString());
 AddUpdatedFld(convQxUsers_School.IsLeaved);
}
else if (strAttributeName  ==  convQxUsers_School.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convQxUsers_School.UpdDate);
}
else if (strAttributeName  ==  convQxUsers_School.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convQxUsers_School.UpdUser);
}
else if (strAttributeName  ==  convQxUsers_School.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQxUsers_School.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convQxUsers_School.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convQxUsers_School.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convQxUsers_School.DepartmentId  ==  AttributeName[intIndex])
{
return mstrDepartmentId;
}
else if (convQxUsers_School.DepartmentName  ==  AttributeName[intIndex])
{
return mstrDepartmentName;
}
else if (convQxUsers_School.DepartmentAbbrName  ==  AttributeName[intIndex])
{
return mstrDepartmentAbbrName;
}
else if (convQxUsers_School.DepartmentTypeId  ==  AttributeName[intIndex])
{
return mstrDepartmentTypeId;
}
else if (convQxUsers_School.DepartmentTypeName  ==  AttributeName[intIndex])
{
return mstrDepartmentTypeName;
}
else if (convQxUsers_School.UpDepartmentId  ==  AttributeName[intIndex])
{
return mstrUpDepartmentId;
}
else if (convQxUsers_School.UpDepartmentName  ==  AttributeName[intIndex])
{
return mstrUpDepartmentName;
}
else if (convQxUsers_School.UserStateId  ==  AttributeName[intIndex])
{
return mstrUserStateId;
}
else if (convQxUsers_School.UserStateName  ==  AttributeName[intIndex])
{
return mstrUserStateName;
}
else if (convQxUsers_School.IdentityId  ==  AttributeName[intIndex])
{
return mstrIdentityId;
}
else if (convQxUsers_School.IdentityDesc  ==  AttributeName[intIndex])
{
return mstrIdentityDesc;
}
else if (convQxUsers_School.CardNo  ==  AttributeName[intIndex])
{
return mstrCardNo;
}
else if (convQxUsers_School.StuTeacherId  ==  AttributeName[intIndex])
{
return mstrStuTeacherId;
}
else if (convQxUsers_School.IdGradeBase  ==  AttributeName[intIndex])
{
return mstrIdGradeBase;
}
else if (convQxUsers_School.GradeBaseName  ==  AttributeName[intIndex])
{
return mstrGradeBaseName;
}
else if (convQxUsers_School.EnterSchoolDate  ==  AttributeName[intIndex])
{
return mstrEnterSchoolDate;
}
else if (convQxUsers_School.IsOffed  ==  AttributeName[intIndex])
{
return mbolIsOffed;
}
else if (convQxUsers_School.BeginYearMonth  ==  AttributeName[intIndex])
{
return mstrBeginYearMonth;
}
else if (convQxUsers_School.EndYearMonth  ==  AttributeName[intIndex])
{
return mstrEndYearMonth;
}
else if (convQxUsers_School.CardState  ==  AttributeName[intIndex])
{
return mstrCardState;
}
else if (convQxUsers_School.IsLeaved  ==  AttributeName[intIndex])
{
return mbolIsLeaved;
}
else if (convQxUsers_School.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convQxUsers_School.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convQxUsers_School.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convQxUsers_School.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convQxUsers_School.UserId);
}
else if (convQxUsers_School.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convQxUsers_School.UserName);
}
else if (convQxUsers_School.DepartmentId  ==  AttributeName[intIndex])
{
mstrDepartmentId = value.ToString();
 AddUpdatedFld(convQxUsers_School.DepartmentId);
}
else if (convQxUsers_School.DepartmentName  ==  AttributeName[intIndex])
{
mstrDepartmentName = value.ToString();
 AddUpdatedFld(convQxUsers_School.DepartmentName);
}
else if (convQxUsers_School.DepartmentAbbrName  ==  AttributeName[intIndex])
{
mstrDepartmentAbbrName = value.ToString();
 AddUpdatedFld(convQxUsers_School.DepartmentAbbrName);
}
else if (convQxUsers_School.DepartmentTypeId  ==  AttributeName[intIndex])
{
mstrDepartmentTypeId = value.ToString();
 AddUpdatedFld(convQxUsers_School.DepartmentTypeId);
}
else if (convQxUsers_School.DepartmentTypeName  ==  AttributeName[intIndex])
{
mstrDepartmentTypeName = value.ToString();
 AddUpdatedFld(convQxUsers_School.DepartmentTypeName);
}
else if (convQxUsers_School.UpDepartmentId  ==  AttributeName[intIndex])
{
mstrUpDepartmentId = value.ToString();
 AddUpdatedFld(convQxUsers_School.UpDepartmentId);
}
else if (convQxUsers_School.UpDepartmentName  ==  AttributeName[intIndex])
{
mstrUpDepartmentName = value.ToString();
 AddUpdatedFld(convQxUsers_School.UpDepartmentName);
}
else if (convQxUsers_School.UserStateId  ==  AttributeName[intIndex])
{
mstrUserStateId = value.ToString();
 AddUpdatedFld(convQxUsers_School.UserStateId);
}
else if (convQxUsers_School.UserStateName  ==  AttributeName[intIndex])
{
mstrUserStateName = value.ToString();
 AddUpdatedFld(convQxUsers_School.UserStateName);
}
else if (convQxUsers_School.IdentityId  ==  AttributeName[intIndex])
{
mstrIdentityId = value.ToString();
 AddUpdatedFld(convQxUsers_School.IdentityId);
}
else if (convQxUsers_School.IdentityDesc  ==  AttributeName[intIndex])
{
mstrIdentityDesc = value.ToString();
 AddUpdatedFld(convQxUsers_School.IdentityDesc);
}
else if (convQxUsers_School.CardNo  ==  AttributeName[intIndex])
{
mstrCardNo = value.ToString();
 AddUpdatedFld(convQxUsers_School.CardNo);
}
else if (convQxUsers_School.StuTeacherId  ==  AttributeName[intIndex])
{
mstrStuTeacherId = value.ToString();
 AddUpdatedFld(convQxUsers_School.StuTeacherId);
}
else if (convQxUsers_School.IdGradeBase  ==  AttributeName[intIndex])
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(convQxUsers_School.IdGradeBase);
}
else if (convQxUsers_School.GradeBaseName  ==  AttributeName[intIndex])
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(convQxUsers_School.GradeBaseName);
}
else if (convQxUsers_School.EnterSchoolDate  ==  AttributeName[intIndex])
{
mstrEnterSchoolDate = value.ToString();
 AddUpdatedFld(convQxUsers_School.EnterSchoolDate);
}
else if (convQxUsers_School.IsOffed  ==  AttributeName[intIndex])
{
mbolIsOffed = TransNullToBool(value.ToString());
 AddUpdatedFld(convQxUsers_School.IsOffed);
}
else if (convQxUsers_School.BeginYearMonth  ==  AttributeName[intIndex])
{
mstrBeginYearMonth = value.ToString();
 AddUpdatedFld(convQxUsers_School.BeginYearMonth);
}
else if (convQxUsers_School.EndYearMonth  ==  AttributeName[intIndex])
{
mstrEndYearMonth = value.ToString();
 AddUpdatedFld(convQxUsers_School.EndYearMonth);
}
else if (convQxUsers_School.CardState  ==  AttributeName[intIndex])
{
mstrCardState = value.ToString();
 AddUpdatedFld(convQxUsers_School.CardState);
}
else if (convQxUsers_School.IsLeaved  ==  AttributeName[intIndex])
{
mbolIsLeaved = TransNullToBool(value.ToString());
 AddUpdatedFld(convQxUsers_School.IsLeaved);
}
else if (convQxUsers_School.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convQxUsers_School.UpdDate);
}
else if (convQxUsers_School.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convQxUsers_School.UpdUser);
}
else if (convQxUsers_School.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQxUsers_School.Memo);
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
 AddUpdatedFld(convQxUsers_School.UserId);
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
 AddUpdatedFld(convQxUsers_School.UserName);
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
 AddUpdatedFld(convQxUsers_School.DepartmentId);
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
 AddUpdatedFld(convQxUsers_School.DepartmentName);
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
 AddUpdatedFld(convQxUsers_School.DepartmentAbbrName);
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
 AddUpdatedFld(convQxUsers_School.DepartmentTypeId);
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
 AddUpdatedFld(convQxUsers_School.DepartmentTypeName);
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
 AddUpdatedFld(convQxUsers_School.UpDepartmentId);
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
 AddUpdatedFld(convQxUsers_School.UpDepartmentName);
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
 AddUpdatedFld(convQxUsers_School.UserStateId);
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
 AddUpdatedFld(convQxUsers_School.UserStateName);
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
 AddUpdatedFld(convQxUsers_School.IdentityId);
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
 AddUpdatedFld(convQxUsers_School.IdentityDesc);
}
}
/// <summary>
/// 卡号(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CardNo
{
get
{
return mstrCardNo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCardNo = value;
}
else
{
 mstrCardNo = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUsers_School.CardNo);
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
 AddUpdatedFld(convQxUsers_School.StuTeacherId);
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
 AddUpdatedFld(convQxUsers_School.IdGradeBase);
}
}
/// <summary>
/// 年级名称(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GradeBaseName
{
get
{
return mstrGradeBaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGradeBaseName = value;
}
else
{
 mstrGradeBaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUsers_School.GradeBaseName);
}
}
/// <summary>
/// 进校日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EnterSchoolDate
{
get
{
return mstrEnterSchoolDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEnterSchoolDate = value;
}
else
{
 mstrEnterSchoolDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUsers_School.EnterSchoolDate);
}
}
/// <summary>
/// 是否毕业(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsOffed
{
get
{
return mbolIsOffed;
}
set
{
 mbolIsOffed = value;
//记录修改过的字段
 AddUpdatedFld(convQxUsers_School.IsOffed);
}
}
/// <summary>
/// 开始年月(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string BeginYearMonth
{
get
{
return mstrBeginYearMonth;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrBeginYearMonth = value;
}
else
{
 mstrBeginYearMonth = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUsers_School.BeginYearMonth);
}
}
/// <summary>
/// 结束年月(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EndYearMonth
{
get
{
return mstrEndYearMonth;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEndYearMonth = value;
}
else
{
 mstrEndYearMonth = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUsers_School.EndYearMonth);
}
}
/// <summary>
/// 卡状态(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CardState
{
get
{
return mstrCardState;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCardState = value;
}
else
{
 mstrCardState = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUsers_School.CardState);
}
}
/// <summary>
/// IsLeaved(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsLeaved
{
get
{
return mbolIsLeaved;
}
set
{
 mbolIsLeaved = value;
//记录修改过的字段
 AddUpdatedFld(convQxUsers_School.IsLeaved);
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
 AddUpdatedFld(convQxUsers_School.UpdDate);
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
 AddUpdatedFld(convQxUsers_School.UpdUser);
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
 AddUpdatedFld(convQxUsers_School.Memo);
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
}
 /// <summary>
 /// vUsers_School(vQxUsers_School)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convQxUsers_School
{
public const string _CurrTabName = "vQxUsers_School"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "UserId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"UserId", "UserName", "DepartmentId", "DepartmentName", "DepartmentAbbrName", "DepartmentTypeId", "DepartmentTypeName", "UpDepartmentId", "UpDepartmentName", "UserStateId", "UserStateName", "IdentityId", "IdentityDesc", "CardNo", "StuTeacherId", "IdGradeBase", "GradeBaseName", "EnterSchoolDate", "IsOffed", "BeginYearMonth", "EndYearMonth", "CardState", "IsLeaved", "UpdDate", "UpdUser", "Memo"};
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
 /// 常量:"CardNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CardNo = "CardNo";    //卡号

 /// <summary>
 /// 常量:"StuTeacherId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuTeacherId = "StuTeacherId";    //学工号

 /// <summary>
 /// 常量:"IdGradeBase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdGradeBase = "IdGradeBase";    //年级流水号

 /// <summary>
 /// 常量:"GradeBaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GradeBaseName = "GradeBaseName";    //年级名称

 /// <summary>
 /// 常量:"EnterSchoolDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EnterSchoolDate = "EnterSchoolDate";    //进校日期

 /// <summary>
 /// 常量:"IsOffed"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsOffed = "IsOffed";    //是否毕业

 /// <summary>
 /// 常量:"BeginYearMonth"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BeginYearMonth = "BeginYearMonth";    //开始年月

 /// <summary>
 /// 常量:"EndYearMonth"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EndYearMonth = "EndYearMonth";    //结束年月

 /// <summary>
 /// 常量:"CardState"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CardState = "CardState";    //卡状态

 /// <summary>
 /// 常量:"IsLeaved"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsLeaved = "IsLeaved";    //IsLeaved

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